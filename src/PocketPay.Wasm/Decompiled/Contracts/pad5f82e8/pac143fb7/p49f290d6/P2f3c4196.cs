namespace WillowMaze.Wasm.Decompiled;

public interface P2f3c4196
{
    void ClearTopToken();
    void ClearUserInfo();
    string GetFormattedPhoneNumber();
    string GetPhoneNumber();
    string GetShopId();
    string GetSmsUuid();
    string GetTopToken();
    List<object> GetUserGrantTypes();
    string GetUserId();
    p3dfe3c80 GetUserRoleType();
    bool HasAtLeastOneGrantOf(p1533e8ac[] P0);
    bool HasTopToken();
    void SaveCashierId(string P0);
    void SavePhone(string P0);
    void SaveShopId(string P0);
    void SaveSmsUuid(string P0);
    void SaveTopInn(string P0);
    void SaveTopToken(string P0);
    void SaveUserId(string P0);
    void SaveUserRoleType(p3dfe3c80 P0);
    void UpdateUserGrantType(List<object> P0);
}
