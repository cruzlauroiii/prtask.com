namespace WillowMaze.Wasm.Decompiled;

public interface P54785431
{
    object ClearDevices(object P0);
    object GetAllDevices(object P0);
    object GetDevice(string P0, object P1);
    object GetDeviceIdByUuid(string P0, object P1);
    object GetLocalDevices(object P0);
    object GetRemoteDevices(object P0);
    object GetSelectedDevice(object P0);
    object HasDevice(string P0, object P1);
    object InsertDevice(p6285e3eb P0, object P1);
    object InsertDevices(List<object> P0, object P1);
    object RemoveDevice(string P0, object P1);
    object RemoveRemoteDevices(object P0);
    object SelectCurrentDevice(string P0, object P1);
    object SelectDevice(string P0, object P1);
    object UnselectDevices(object P0);
    object UpdateDevice(p6285e3eb P0, object P1);
    object UpdateDevices(List<object> P0, object P1);
    object UpdateRemoteDevices(List<object> P0, object P1);
}
