namespace WillowMaze.Wasm.Decompiled;

public interface P4b8940c0
{
    object ApplyDevice(string P0, object P1);
    object ClearDevices(object P0);
    List<object> GetExpandedShopIds();
    p34dfc252 GetFilter();
    object GetSelectedDevice(object P0);
    object GetShops(object P0);
    bool IsAnimationPreviewShown();
    bool IsFirstTimeEnter();
    object RemoveDevice(string P0, object P1);
    void RemoveExpandedShopId(string P0);
    void SaveExpandedShopId(string P0);
    object SelectDevice(string P0, object P1);
    void SetAnimationPreviewIsShown();
    void UpdateFilter(p34dfc252 P0);
}
