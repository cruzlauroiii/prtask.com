namespace WillowMaze.Wasm.Decompiled;


public readonly class NetworkConnectionInfo$NetworkType {
    private static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType[] $VALUES;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType BLUETOOTH;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType DUMMY;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType ETHERNET;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_CBS;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_DUN;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_EMERGENCY;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_FOTA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_HIPRI;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_IA;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_IMS;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_MMS;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType MOBILE_SUPL;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType NONE;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType PROXY;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType VPN;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType WIFI;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType WIFI_P2P;
    public static readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType WIMAX;
    private static readonly android.util.SparseArray<com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType> valueDictionary;
    private readonly int value;

    static {
        if ((17 + 6) % 6 > 0) {
        }
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE", 0, 0);
        MOBILE = networkConnectionInfo$NetworkType;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType2 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("WIFI", 1, 1);
        WIFI = networkConnectionInfo$NetworkType2;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType3 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_MMS", 2, 2);
        MOBILE_MMS = networkConnectionInfo$NetworkType3;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType4 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_SUPL", 3, 3);
        MOBILE_SUPL = networkConnectionInfo$NetworkType4;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType5 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_DUN", 4, 4);
        MOBILE_DUN = networkConnectionInfo$NetworkType5;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType6 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_HIPRI", 5, 5);
        MOBILE_HIPRI = networkConnectionInfo$NetworkType6;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType7 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("WIMAX", 6, 6);
        WIMAX = networkConnectionInfo$NetworkType7;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType8 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("BLUETOOTH", 7, 7);
        BLUETOOTH = networkConnectionInfo$NetworkType8;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType9 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("DUMMY", 8, 8);
        DUMMY = networkConnectionInfo$NetworkType9;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType10 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("ETHERNET", 9, 9);
        ETHERNET = networkConnectionInfo$NetworkType10;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType11 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_FOTA", 10, 10);
        MOBILE_FOTA = networkConnectionInfo$NetworkType11;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType12 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_IMS", 11, 11);
        MOBILE_IMS = networkConnectionInfo$NetworkType12;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType13 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_CBS", 12, 12);
        MOBILE_CBS = networkConnectionInfo$NetworkType13;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType14 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("WIFI_P2P", 13, 13);
        WIFI_P2P = networkConnectionInfo$NetworkType14;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType15 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_IA", 14, 14);
        MOBILE_IA = networkConnectionInfo$NetworkType15;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType16 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("MOBILE_EMERGENCY", 15, 15);
        MOBILE_EMERGENCY = networkConnectionInfo$NetworkType16;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType17 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("PROXY", 16, 16);
        PROXY = networkConnectionInfo$NetworkType17;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType18 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("VPN", 17, 17);
        VPN = networkConnectionInfo$NetworkType18;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType19 = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType("NONE", 18, -1);
        NONE = networkConnectionInfo$NetworkType19;
        $VALUES = new com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType[]{networkConnectionInfo$NetworkType, networkConnectionInfo$NetworkType2, networkConnectionInfo$NetworkType3, networkConnectionInfo$NetworkType4, networkConnectionInfo$NetworkType5, networkConnectionInfo$NetworkType6, networkConnectionInfo$NetworkType7, networkConnectionInfo$NetworkType8, networkConnectionInfo$NetworkType9, networkConnectionInfo$NetworkType10, networkConnectionInfo$NetworkType11, networkConnectionInfo$NetworkType12, networkConnectionInfo$NetworkType13, networkConnectionInfo$NetworkType14, networkConnectionInfo$NetworkType15, networkConnectionInfo$NetworkType16, networkConnectionInfo$NetworkType17, networkConnectionInfo$NetworkType18, networkConnectionInfo$NetworkType19};
        android.util.SparseArray<com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType> sparseArray = new android.util.SparseArray<>();
        valueDictionary = sparseArray;
        pFqKPqXNLwXTJupn(sparseArray, 0, networkConnectionInfo$NetworkType);
        EbXAbQXZMeEuWPJp(sparseArray, 1, networkConnectionInfo$NetworkType2);
        gRnxiFCvxWNUmroq(sparseArray, 2, networkConnectionInfo$NetworkType3);
        JixdQCXRWiBaoSGF(sparseArray, 3, networkConnectionInfo$NetworkType4);
        mGuZRyGgaCnlKeLp(sparseArray, 4, networkConnectionInfo$NetworkType5);
        UYIGuoUgyiGoawll(sparseArray, 5, networkConnectionInfo$NetworkType6);
        bYJpOWSZmCyaFQXH(sparseArray, 6, networkConnectionInfo$NetworkType7);
        vNwPUoDMYDLvQfDL(sparseArray, 7, networkConnectionInfo$NetworkType8);
        skvwNMeYXdJUkNzD(sparseArray, 8, networkConnectionInfo$NetworkType9);
        NEeXZfvEnkbnVyDr(sparseArray, 9, networkConnectionInfo$NetworkType10);
        kvkxCrxZdMFTopwE(sparseArray, 10, networkConnectionInfo$NetworkType11);
        UlIwshhqXeLMHRzG(sparseArray, 11, networkConnectionInfo$NetworkType12);
        BZVyURXRkXFdyxrI(sparseArray, 12, networkConnectionInfo$NetworkType13);
        dsahmQtsrBwEHhqM(sparseArray, 13, networkConnectionInfo$NetworkType14);
        SgfmhkENihpWYckV(sparseArray, 14, networkConnectionInfo$NetworkType15);
        nUpsXQFcKksBihsX(sparseArray, 15, networkConnectionInfo$NetworkType16);
        CLRMRNUQBjgFPPVc(sparseArray, 16, networkConnectionInfo$NetworkType17);
        wHTEiNwaDmzITXAO(sparseArray, 17, networkConnectionInfo$NetworkType18);
        LiGzNXoBZRxjBlSQ(sparseArray, -1, networkConnectionInfo$NetworkType19);
    }

    private NetworkConnectionInfo$NetworkType(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static void BZVyURXRkXFdyxrI(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void CLRMRNUQBjgFPPVc(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void EbXAbQXZMeEuWPJp(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.object JNqNStjBXawJoUsc(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType[] networkConnectionInfo$NetworkTypeArr) {
        return networkConnectionInfo$NetworkTypeArr.clone();
    }

    public static void JixdQCXRWiBaoSGF(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void LiGzNXoBZRxjBlSQ(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void NEeXZfvEnkbnVyDr(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void SgfmhkENihpWYckV(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void UYIGuoUgyiGoawll(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void UlIwshhqXeLMHRzG(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void BYJpOWSZmCyaFQXH(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void DsahmQtsrBwEHhqM(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.object FgjhqrgNjkaSUkdD(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType forNumber(int i) {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType) fgjhqrgNjkaSUkdD(valueDictionary, i);
    }

    public static void GRnxiFCvxWNUmroq(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.Enum IKNIjfYvSMgpMbRv(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static void KvkxCrxZdMFTopwE(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void MGuZRyGgaCnlKeLp(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void NUpsXQFcKksBihsX(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void PFqKPqXNLwXTJupn(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void SkvwNMeYXdJUkNzD(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void VNwPUoDMYDLvQfDL(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType valueOf(java.lang.string str) {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType) iKNIjfYvSMgpMbRv(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType.class, str);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType[] values() {
        return (com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType[]) JNqNStjBXawJoUsc($VALUES);
    }

    public static void WHTEiNwaDmzITXAO(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public int GetValue() {
        return this.value;
    }
}

