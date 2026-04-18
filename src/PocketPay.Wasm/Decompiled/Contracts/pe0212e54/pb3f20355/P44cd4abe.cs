namespace WillowMaze.Wasm.Decompiled;

public interface P44cd4abe
{
    object ClearDevices(object P0);
    object ClearShops(object P0);
    object GetDeviceIdByUuid(string P0, object P1);
    List<object> GetExpandedShopIds();
    p34dfc252 GetFilter();
    object GetRemoteDevices(object P0);
    object GetSelectedDevice(object P0);
    object GetShops(object P0);
    bool IsFirstTimeEnter();
    object RemoveDevice(string P0, object P1);
    void RemoveExpandedShopId(string P0);
    void SaveExpandedShopId(string P0);
    object SelectDevice(string P0, object P1);
    void UpdateFilter(p34dfc252 P0);
}
