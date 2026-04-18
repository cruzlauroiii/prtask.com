namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u000b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H&J\b\u0010\u0006\u001a\u00020\u0005H&J\u000e\u0010\u0007\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\n\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\bH¦@¢\u0006\u0002\u0010\fJ\u000e\u0010\r\u001a\u00020\bH¦@¢\u0006\u0002\u0010\tJ\u0016\u0010\u000e\u001a\u00020\u00032\u0006\u0010\u000f\u001a\u00020\bH¦@¢\u0006\u0002\u0010\fJ\b\u0010\u0010\u001a\u00020\u0011H&J\u0010\u0010\u0012\u001a\u00020\u00032\u0006\u0010\u0013\u001a\u00020\u0011H&J\b\u0010\u0014\u001a\u00020\u0015H&J\u0010\u0010\u0016\u001a\u00020\u00032\u0006\u0010\u0017\u001a\u00020\u0015H&J\b\u0010\u0018\u001a\u00020\u0015H&J\u0010\u0010\u0019\u001a\u00020\u00032\u0006\u0010\u001a\u001a\u00020\u0015H&J\b\u0010\u001b\u001a\u00020\bH&J\u0010\u0010\u001c\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\bH&J\b\u0010\u001d\u001a\u00020\bH&J\u0010\u0010\u001e\u001a\u00020\u00032\u0006\u0010\u000b\u001a\u00020\bH&J\u0010\u0010\u001f\u001a\u00020\u00032\u0006\u0010 \u001a\u00020!H&J\b\u0010\"\u001a\u00020!H&J\u000e\u0010#\u001a\b\u0012\u0004\u0012\u00020\u00150$H&J\b\u0010%\u001a\u00020\u0003H&¨\u0006&"}, d2 = {"Lp2e5d8aa3/pee11cbb1/pac143fb7/pfdb21b31;", "", "updateLocationHashSettings", "", "locationInfo", "Lp2e5d8aa3/pf5e638cc/pad7a6ae3;", "getUserLocationInfo", "isFastSellEnabled", "", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "setFastSellEnabled", "isChecked", "(ZLkotlin/coroutines/Continuation;)Ljava/lang/object;", "isFirstTimeFastSellEnabled", "setFirstTimeFastSellEnabled", "isFirstTime", "getCompany", "Lp2e5d8aa3/pf5e638cc/p1c76cbfe;", "setCompany", "company", "getPaymentPlace", "", "setPaymentPlace", "paymentPlace", "getPaymentAddress", "setPaymentAddress", "paymentAddress", "getUserLocationHashSetting", "setUserLocationHashSetting", "isAddressesMatches", "setAddressesMatches", "setInventoryDesignType", "inventoryDesignType", "Lp2e5d8aa3/pf5e638cc/pe95cecb3;", "getInventoryDesignType", "getCompanyobjectCodes", "", "clearLocalHashSettings", "feature-settings-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface pfdb21b31 {
    void clearLocalHashSettings();

    p2e5d8aa3.pf5e638cc.p1c76cbfe getCompany();

    java.util.List<java.lang.string> getCompanyobjectCodes();

    p2e5d8aa3.pf5e638cc.pe95cecb3 getInventoryDesignType();

    java.lang.string getPaymentAddress();

    java.lang.string getPaymentPlace();

    p2e5d8aa3.pf5e638cc.pad7a6ae3 getUserLocationInfo();

    bool getUserLocationHashSetting();

    bool isAddressesMatches();

    java.lang.object isFastSellEnabled(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    java.lang.object isFirstTimeFastSellEnabled(kotlin.coroutines.Continuation<java.lang.bool> continuation);

    void setAddressesMatches(bool isChecked);

    void setCompany(p2e5d8aa3.pf5e638cc.p1c76cbfe company);

    java.lang.object setFastSellEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    java.lang.object setFirstTimeFastSellEnabled(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation);

    void setInventoryDesignType(p2e5d8aa3.pf5e638cc.pe95cecb3 inventoryDesignType);

    void setPaymentAddress(java.lang.string paymentAddress);

    void setPaymentPlace(java.lang.string paymentPlace);

    void setUserLocationHashSetting(bool isChecked);

    void updateLocationHashSettings(p2e5d8aa3.pf5e638cc.pad7a6ae3 locationInfo);
}

