namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0011\n\u0002\b\u0003\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0007\u001a\u00020\u0005H&J\u0016\u0010\b\u001a\u00020\u00032\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH&J\u0010\u0010\f\u001a\u00020\u00032\u0006\u0010\r\u001a\u00020\u0005H&J\u0010\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\u0010H&J\b\u0010\u0011\u001a\u00020\u0003H&J\u0010\u0010\u0012\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0005H&J\u0010\u0010\u0014\u001a\u00020\u00032\u0006\u0010\u0015\u001a\u00020\u0005H&J\b\u0010\u0016\u001a\u00020\u0005H&J\b\u0010\u0017\u001a\u00020\u0005H&J\b\u0010\u0018\u001a\u00020\u0010H&J\u000e\u0010\u0019\u001a\b\u0012\u0004\u0012\u00020\u000b0\nH&J\b\u0010\u001a\u001a\u00020\u001bH&J\u0012\u0010\u001c\u001a\u00020\u00032\b\u0010\u001d\u001a\u0004\u0018\u00010\u0005H&J\n\u0010\u001e\u001a\u0004\u0018\u00010\u0005H&J!\u0010\u001f\u001a\u00020\u001b2\u0012\u0010 \u001a\n\u0012\u0006\b\u0001\u0012\u00020\u000b0!\"\u00020\u000bH&¢\u0006\u0002\u0010\"J\b\u0010#\u001a\u00020\u0003H&¨\u0006$"}, d2 = {"Lp8d777f38/pb3f20355/p49f290d6/p3666b042;", "Lp8d777f38/pb3f20355/p49f290d6/p10de9b27;", "saveUserId", "", "userId", "", "saveCashierId", "cashierId", "updateUserGrantType", "userGrantTypes", "", "Lpad5f82e8/p07214c67/p49f290d6/p1533e8ac;", "saveSmsUuid", "smsUuid", "saveUserRoleType", "userRoleType", "Lpad5f82e8/p07214c67/p49f290d6/p3dfe3c80;", "clearTopToken", "saveTopInn", "inn", "savePhone", "phone", "getFormattedPhoneNumber", "getSmsUuid", "getUserRoleType", "getUserGrantTypes", "hasTopToken", "", "saveShopId", "shopId", "getShopId", "hasAtLeastOneGrantOf", "grants", "", "([Lpad5f82e8/p07214c67/p49f290d6/p1533e8ac;)Z", "clearUserInfo", "common-data-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p3666b042 : p8d777f38.pb3f20355.p49f290d6.p10de9b27 {
    void clearTopToken();

    void clearUserInfo();

    java.lang.string getFormattedPhoneNumber();

    java.lang.string getShopId();

    java.lang.string getSmsUuid();

    java.util.List<pad5f82e8.p07214c67.p49f290d6.p1533e8ac> getUserGrantTypes();

    pad5f82e8.p07214c67.p49f290d6.p3dfe3c80 getUserRoleType();

    bool hasAtLeastOneGrantOf(pad5f82e8.p07214c67.p49f290d6.p1533e8ac... grants);

    bool hasTopToken();

    void saveCashierId(java.lang.string cashierId);

    void savePhone(java.lang.string phone);

    void saveShopId(java.lang.string shopId);

    void saveSmsUuid(java.lang.string smsUuid);

    void saveTopInn(java.lang.string inn);

    void saveUserId(java.lang.string userId);

    void saveUserRoleType(pad5f82e8.p07214c67.p49f290d6.p3dfe3c80 userRoleType);

    void updateUserGrantType(java.util.List<? : pad5f82e8.p07214c67.p49f290d6.p1533e8ac> userGrantTypes);
}

