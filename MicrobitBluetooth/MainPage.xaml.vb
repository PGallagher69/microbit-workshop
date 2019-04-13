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

        MicroBit = Await BluetoothLEDevice.FromIdAsync("BluetoothLE#BluetoothLEbc:83:85:c7:93:21-c7:52:f2:24:9a:67")

        Dim result As GattDeviceServicesResult = Await MicroBit.GetGattServicesAsync(BluetoothCacheMode.Uncached)

        If result.Status = GattCommunicationStatus.Success Then


        End If

    End Sub
End Class
