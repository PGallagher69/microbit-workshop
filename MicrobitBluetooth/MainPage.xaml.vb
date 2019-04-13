' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.Devices.Bluetooth
Imports Windows.Devices.Bluetooth.GenericAttributeProfile

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Dim MicroBit As BluetoothLEDevice

    Private Async Sub CmdConnect_Click(sender As Object, e As RoutedEventArgs) Handles cmdConnect.Click

        MicroBit = Await BluetoothLEDevice.FromIdAsync(txtMicrobitID.Text)

        Dim result As GattDeviceServicesResult = Await MicroBit.GetGattServicesAsync(BluetoothCacheMode.Uncached)

        If result.Status = GattCommunicationStatus.Success Then

            cmdConnect.IsEnabled = False
            cmdDisconnect.IsEnabled = True

        End If

    End Sub

    Private Sub cmdDisconnect_Click(sender As Object, e As RoutedEventArgs) Handles cmdDisconnect.Click

        If MicroBit IsNot Nothing Then

            MicroBit.Dispose()
            MicroBit = Nothing

            cmdConnect.IsEnabled = True
            cmdDisconnect.IsEnabled = False

        End If

    End Sub

    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        cmdConnect.IsEnabled = True
        cmdDisconnect.IsEnabled = False

    End Sub

End Class
