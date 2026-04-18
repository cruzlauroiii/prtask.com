namespace WillowMaze.Wasm.Decompiled;

public interface Pfeb9ca41
{
    object ClearDevices(object P0);
    object ClearShops(object P0);
    object GetAllDevices(object P0);
    object GetDevice(string P0, object P1);
    object GetDeviceIdByUuid(string P0, object P1);
    object GetDeviceStatusByDeviceId(string P0, object P1);
    object GetLocalDevices(object P0);
    object GetRemoteDevices(object P0);
    object GetShops(object P0);
    object HasDevice(string P0, object P1);
    object RemoveDevice(string P0, object P1);
    object RemoveRemoteDevices(object P0);
    object SelectDevice(string P0, object P1);
    object UpdateDevice(p6285e3eb P0, object P1);
    object UpdateDeviceStatus(p94db0041 P0, object P1);
    object UpdateDevices(List<object> P0, object P1);
    object UpdateRemoteDevices(List<object> P0, object P1);
    object UpdateShops(List<object> P0, object P1);
}
