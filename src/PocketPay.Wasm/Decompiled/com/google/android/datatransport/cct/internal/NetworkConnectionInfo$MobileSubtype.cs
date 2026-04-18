namespace WillowMaze.Wasm.Decompiled;


public readonly class NetworkConnectionInfo$MobileSubtype {
    private static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype[] $VALUES;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype CDMA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype COMBINED;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype EDGE;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype EHRPD;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype EVDO_0;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype EVDO_A;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype EVDO_B;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype GPRS;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype GSM;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype HSDPA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype HSPA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype HSPAP;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype HSUPA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype IDEN;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype IWLAN;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype LTE;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype LTE_CA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype RTT;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype TD_SCDMA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype UMTS;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype UNKNOWN_MOBILE_SUBTYPE;
    private static readonly android.util.SparseArray<com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype> valueDictionary;
    private readonly int value;

    static {
        if ((22 + 22) % 22 > 0) {
        }
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("UNKNOWN_MOBILE_SUBTYPE", 0, 0);
        UNKNOWN_MOBILE_SUBTYPE = networkConnectionInfo$MobileSubtype;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype2 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("GPRS", 1, 1);
        GPRS = networkConnectionInfo$MobileSubtype2;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype3 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("EDGE", 2, 2);
        EDGE = networkConnectionInfo$MobileSubtype3;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype4 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("UMTS", 3, 3);
        UMTS = networkConnectionInfo$MobileSubtype4;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype5 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("CDMA", 4, 4);
        CDMA = networkConnectionInfo$MobileSubtype5;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype6 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("EVDO_0", 5, 5);
        EVDO_0 = networkConnectionInfo$MobileSubtype6;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype7 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("EVDO_A", 6, 6);
        EVDO_A = networkConnectionInfo$MobileSubtype7;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype8 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("RTT", 7, 7);
        RTT = networkConnectionInfo$MobileSubtype8;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype9 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("HSDPA", 8, 8);
        HSDPA = networkConnectionInfo$MobileSubtype9;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype10 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("HSUPA", 9, 9);
        HSUPA = networkConnectionInfo$MobileSubtype10;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype11 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("HSPA", 10, 10);
        HSPA = networkConnectionInfo$MobileSubtype11;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype12 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("IDEN", 11, 11);
        IDEN = networkConnectionInfo$MobileSubtype12;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype13 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("EVDO_B", 12, 12);
        EVDO_B = networkConnectionInfo$MobileSubtype13;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype14 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("LTE", 13, 13);
        LTE = networkConnectionInfo$MobileSubtype14;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype15 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("EHRPD", 14, 14);
        EHRPD = networkConnectionInfo$MobileSubtype15;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype16 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("HSPAP", 15, 15);
        HSPAP = networkConnectionInfo$MobileSubtype16;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype17 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("GSM", 16, 16);
        GSM = networkConnectionInfo$MobileSubtype17;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype18 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("TD_SCDMA", 17, 17);
        TD_SCDMA = networkConnectionInfo$MobileSubtype18;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype19 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("IWLAN", 18, 18);
        IWLAN = networkConnectionInfo$MobileSubtype19;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype20 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("LTE_CA", 19, 19);
        LTE_CA = networkConnectionInfo$MobileSubtype20;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype21 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype("COMBINED", 20, 100);
        COMBINED = networkConnectionInfo$MobileSubtype21;
        $VALUES = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype[]{networkConnectionInfo$MobileSubtype, networkConnectionInfo$MobileSubtype2, networkConnectionInfo$MobileSubtype3, networkConnectionInfo$MobileSubtype4, networkConnectionInfo$MobileSubtype5, networkConnectionInfo$MobileSubtype6, networkConnectionInfo$MobileSubtype7, networkConnectionInfo$MobileSubtype8, networkConnectionInfo$MobileSubtype9, networkConnectionInfo$MobileSubtype10, networkConnectionInfo$MobileSubtype11, networkConnectionInfo$MobileSubtype12, networkConnectionInfo$MobileSubtype13, networkConnectionInfo$MobileSubtype14, networkConnectionInfo$MobileSubtype15, networkConnectionInfo$MobileSubtype16, networkConnectionInfo$MobileSubtype17, networkConnectionInfo$MobileSubtype18, networkConnectionInfo$MobileSubtype19, networkConnectionInfo$MobileSubtype20, networkConnectionInfo$MobileSubtype21};
        android.util.SparseArray<com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype> sparseArray = new android.util.SparseArray<>();
        valueDictionary = sparseArray;
        FSLTEhLykuFcySbA(sparseArray, 0, networkConnectionInfo$MobileSubtype);
        sEtbOkXvvOsEoQSr(sparseArray, 1, networkConnectionInfo$MobileSubtype2);
        pHvdKwoPTpKSSZpE(sparseArray, 2, networkConnectionInfo$MobileSubtype3);
        LxkgNUTkTNEPzYTW(sparseArray, 3, networkConnectionInfo$MobileSubtype4);
        eDGCygsighJACaXn(sparseArray, 4, networkConnectionInfo$MobileSubtype5);
        MOfYnYiSryvewLtB(sparseArray, 5, networkConnectionInfo$MobileSubtype6);
        eQXCEkwbvyEShLRG(sparseArray, 6, networkConnectionInfo$MobileSubtype7);
        FKHztptVvWhejdlW(sparseArray, 7, networkConnectionInfo$MobileSubtype8);
        YTBMNXjQEbyfkNlG(sparseArray, 8, networkConnectionInfo$MobileSubtype9);
        ooWtjFXyLfZxvzKv(sparseArray, 9, networkConnectionInfo$MobileSubtype10);
        dXFQEhkhdVdiJDIz(sparseArray, 10, networkConnectionInfo$MobileSubtype11);
        PixUpdUdGVPzLAYc(sparseArray, 11, networkConnectionInfo$MobileSubtype12);
        IKATAyOSlxZJJxBU(sparseArray, 12, networkConnectionInfo$MobileSubtype13);
        OkOQuoHaHdoiifPJ(sparseArray, 13, networkConnectionInfo$MobileSubtype14);
        yYWbdSNoRGRfZJqo(sparseArray, 14, networkConnectionInfo$MobileSubtype15);
        OoEaynjfPDbcQGRB(sparseArray, 15, networkConnectionInfo$MobileSubtype16);
        dbLYYIcZXNmwhEeb(sparseArray, 16, networkConnectionInfo$MobileSubtype17);
        rAOZeRtUrQnmcFEj(sparseArray, 17, networkConnectionInfo$MobileSubtype18);
        zvwdoOAASopcnjxj(sparseArray, 18, networkConnectionInfo$MobileSubtype19);
        lOdbUfNFvCLtUXoS(sparseArray, 19, networkConnectionInfo$MobileSubtype20);
    }

    private NetworkConnectionInfo$MobileSubtype(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static void FKHztptVvWhejdlW(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void FSLTEhLykuFcySbA(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.Enum GWkUbxlvHBsQutCM(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void IKATAyOSlxZJJxBU(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void LxkgNUTkTNEPzYTW(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void MOfYnYiSryvewLtB(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void OkOQuoHaHdoiifPJ(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void OoEaynjfPDbcQGRB(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void PixUpdUdGVPzLAYc(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void YTBMNXjQEbyfkNlG(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void DXFQEhkhdVdiJDIz(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void DbLYYIcZXNmwhEeb(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void EDGCygsighJACaXn(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void EQXCEkwbvyEShLRG(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype forNumber(int i) {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype) iazdpAnQQXXwTqoD(valueDictionary, i);
    }

    public static java.lang.object HKQuBkeMbULWDtkw(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype[] networkConnectionInfo$MobileSubtypeArr) {
        return networkConnectionInfo$MobileSubtypeArr.clone();
    }

    public static java.lang.object IazdpAnQQXXwTqoD(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void LOdbUfNFvCLtUXoS(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void OoWtjFXyLfZxvzKv(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void PHvdKwoPTpKSSZpE(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void RAOZeRtUrQnmcFEj(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void SEtbOkXvvOsEoQSr(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype valueOf(java.lang.string str) {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype) GWkUbxlvHBsQutCM(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype.class, str);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype[] values() {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype[]) hKQuBkeMbULWDtkw($VALUES);
    }

    public static void YYWbdSNoRGRfZJqo(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void ZvwdoOAASopcnjxj(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public int GetValue() {
        return this.value;
    }
}

