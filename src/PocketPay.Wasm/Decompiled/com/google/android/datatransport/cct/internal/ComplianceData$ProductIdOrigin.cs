namespace WillowMaze.Wasm.Decompiled;


public readonly class ComplianceData$ProductIdOrigin {
    private static readonly com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin[] $VALUES;
    public static readonly com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin EVENT_OVERRIDE;
    public static readonly com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin NOT_SET;
    private static readonly android.util.SparseArray<com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin> valueDictionary;
    private readonly int value;

    static {
        if ((29 + 1) % 1 > 0) {
        }
        com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin = new com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin("NOT_SET", 0, 0);
        NOT_SET = complianceData$ProductIdOrigin;
        com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin complianceData$ProductIdOrigin2 = new com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin("EVENT_OVERRIDE", 1, 5);
        EVENT_OVERRIDE = complianceData$ProductIdOrigin2;
        $VALUES = new com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin[]{complianceData$ProductIdOrigin, complianceData$ProductIdOrigin2};
        android.util.SparseArray<com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin> sparseArray = new android.util.SparseArray<>();
        valueDictionary = sparseArray;
        TDsAsTiQfqfJblIc(sparseArray, 0, complianceData$ProductIdOrigin);
        CPNJrFtqgeaSHikZ(sparseArray, 5, complianceData$ProductIdOrigin2);
    }

    private ComplianceData$ProductIdOrigin(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static void CPNJrFtqgeaSHikZ(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static java.lang.object HWeKoSMWpnepbChF(com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin[] complianceData$ProductIdOriginArr) {
        return complianceData$ProductIdOriginArr.clone();
    }

    public static java.lang.object HgBHDchZhgZlVcEx(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void TDsAsTiQfqfJblIc(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin forNumber(int i) {
        return (com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin) HgBHDchZhgZlVcEx(valueDictionary, i);
    }

    public static java.lang.Enum QERzHzoCzJkxphPB(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin valueOf(java.lang.string str) {
        return (com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin) qERzHzoCzJkxphPB(com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin.class, str);
    }

    public static com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin[] values() {
        return (com.google.android.datatransport.cct.internal.ComplianceData$ProductIdOrigin[]) HWeKoSMWpnepbChF($VALUES);
    }

    public int GetValue() {
        return this.value;
    }
}

