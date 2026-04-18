namespace WillowMaze.Wasm.Decompiled;

public interface P2d884c28
{
    void ClearLocalSettings();
    p1c76cbfe GetCompany();
    List<object> GetCompanyActivityCodes();
    pcb7684f4 GetDefaultReceiptCredentials();
    pe95cecb3 GetInventoryDesignType();
    pad7a6ae3 GetLocationInfo();
    string GetPaymentAddress();
    string GetPaymentPlace();
    bool GetShouldPrintReceipt();
    bool GetUserLocationSetting();
    bool IsAddressesMatches();
    object IsFastSellEnabled(string P0, object P1);
    object IsFirstTimeFastSellEnabled(string P0, object P1);
    void SetAddressesMatches(bool P0);
    void SetCompany(p1c76cbfe P0);
    void SetDefaultReceiptCredentials(pcb7684f4 P0);
    object SetFastSellEnabled(string P0, bool P1, object P2);
    object SetFirstTimeFastSellEnabled(string P0, bool P1, object P2);
    void SetInventoryDesignType(pe95cecb3 P0);
    void SetLocationInfo(pad7a6ae3 P0);
    void SetPaymentAddress(string P0);
    void SetPaymentPlace(string P0);
    void SetShouldPrintReceipt(bool P0);
    void SetUserLocationSetting(bool P0);
}
