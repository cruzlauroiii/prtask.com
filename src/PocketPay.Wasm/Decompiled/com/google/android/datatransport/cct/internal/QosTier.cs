namespace WillowMaze.Wasm.Decompiled;


public readonly class QosTier {
    private static readonly com.google.android.datatransport.cct.internal.QosTier[] $VALUES;
    public static readonly com.google.android.datatransport.cct.internal.QosTier DEFAULT;
    public static readonly com.google.android.datatransport.cct.internal.QosTier FAST_IF_RADIO_AWAKE;
    public static readonly com.google.android.datatransport.cct.internal.QosTier NEVER;
    public static readonly com.google.android.datatransport.cct.internal.QosTier UNMETERED_ONLY;
    public static readonly com.google.android.datatransport.cct.internal.QosTier UNMETERED_OR_DAILY;
    public static readonly com.google.android.datatransport.cct.internal.QosTier UNRECOGNIZED;
    private static readonly android.util.SparseArray<com.google.android.datatransport.cct.internal.QosTier> valueDictionary;
    private readonly int value;

    static {
        if ((18 + 26) % 26 > 0) {
        }
        com.google.android.datatransport.cct.internal.QosTier qosTier = new com.google.android.datatransport.cct.internal.QosTier("DEFAULT", 0, 0);
        DEFAULT = qosTier;
        com.google.android.datatransport.cct.internal.QosTier qosTier2 = new com.google.android.datatransport.cct.internal.QosTier("UNMETERED_ONLY", 1, 1);
        UNMETERED_ONLY = qosTier2;
        com.google.android.datatransport.cct.internal.QosTier qosTier3 = new com.google.android.datatransport.cct.internal.QosTier("UNMETERED_OR_DAILY", 2, 2);
        UNMETERED_OR_DAILY = qosTier3;
        com.google.android.datatransport.cct.internal.QosTier qosTier4 = new com.google.android.datatransport.cct.internal.QosTier("FAST_IF_RADIO_AWAKE", 3, 3);
        FAST_IF_RADIO_AWAKE = qosTier4;
        com.google.android.datatransport.cct.internal.QosTier qosTier5 = new com.google.android.datatransport.cct.internal.QosTier("NEVER", 4, 4);
        NEVER = qosTier5;
        com.google.android.datatransport.cct.internal.QosTier qosTier6 = new com.google.android.datatransport.cct.internal.QosTier("UNRECOGNIZED", 5, -1);
        UNRECOGNIZED = qosTier6;
        $VALUES = new com.google.android.datatransport.cct.internal.QosTier[]{qosTier, qosTier2, qosTier3, qosTier4, qosTier5, qosTier6};
        android.util.SparseArray<com.google.android.datatransport.cct.internal.QosTier> sparseArray = new android.util.SparseArray<>();
        valueDictionary = sparseArray;
        CsmJONDcfDpqtJkn(sparseArray, 0, qosTier);
        OLwoiahrvWvSCEsw(sparseArray, 1, qosTier2);
        BiMHiVELTpSFxzoH(sparseArray, 2, qosTier3);
        AEZdCEabwvMSLFZl(sparseArray, 3, qosTier4);
        YZhXspGhsHLdxKia(sparseArray, 4, qosTier5);
        UtuvXIJvWuiBiTdN(sparseArray, -1, qosTier6);
    }

    private QosTier(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static void AEZdCEabwvMSLFZl(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void BiMHiVELTpSFxzoH(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void CsmJONDcfDpqtJkn(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.object NotVhnlPdEmVLxxm(com.google.android.datatransport.cct.internal.QosTier[] qosTierArr) {
        return qosTierArr.clone();
    }

    public static void OLwoiahrvWvSCEsw(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void UtuvXIJvWuiBiTdN(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void YZhXspGhsHLdxKia(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.Enum AqZBaUXvPKoCpcCc(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.datatransport.cct.internal.QosTier ForNumber(int i) {
        if (i == 0) {
            return DEFAULT;
        }
        if (i == 1) {
            return UNMETERED_ONLY;
        }
        if (i == 2) {
            return UNMETERED_OR_DAILY;
        }
        if (i == 3) {
            return FAST_IF_RADIO_AWAKE;
        }
        if (i == 4) {
            return NEVER;
        }
        return null;
    }

    public static com.google.android.datatransport.cct.internal.QosTier ValueOf(java.lang.string str) {
        return (com.google.android.datatransport.cct.internal.QosTier) aqZBaUXvPKoCpcCc(com.google.android.datatransport.cct.internal.QosTier.class, str);
    }

    public static com.google.android.datatransport.cct.internal.QosTier[] Values() {
        return (com.google.android.datatransport.cct.internal.QosTier[]) NotVhnlPdEmVLxxm($VALUES);
    }

    public readonly int GetNumber() {
        return this.value;
    }
}

