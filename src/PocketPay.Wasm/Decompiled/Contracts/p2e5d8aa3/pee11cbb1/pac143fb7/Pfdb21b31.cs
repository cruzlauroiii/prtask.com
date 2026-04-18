namespace WillowMaze.Wasm.Decompiled;

public interface Pfdb21b31
{
    void ClearLocalSettings();
    p1c76cbfe GetCompany();
    List<object> GetCompanyActivityCodes();
    pe95cecb3 GetInventoryDesignType();
    string GetPaymentAddress();
    string GetPaymentPlace();
    pad7a6ae3 GetUserLocationInfo();
    bool GetUserLocationSetting();
    bool IsAddressesMatches();
    object IsFastSellEnabled(object P0);
    object IsFirstTimeFastSellEnabled(object P0);
    void SetAddressesMatches(bool P0);
    void SetCompany(p1c76cbfe P0);
    object SetFastSellEnabled(bool P0, object P1);
    object SetFirstTimeFastSellEnabled(bool P0, object P1);
    void SetInventoryDesignType(pe95cecb3 P0);
    void SetPaymentAddress(string P0);
    void SetPaymentPlace(string P0);
    void SetUserLocationSetting(bool P0);
    void UpdateLocationSettings(pad7a6ae3 P0);
}
