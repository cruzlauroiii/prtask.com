namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$ExtensionRangeOptions$VerificationState : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState DECLARATION;
    public static readonly int DECLARATION_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState UNVERIFIED;
    public static readonly int UNVERIFIED_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState> internalValueDictionary;
    private readonly int value;

    static {
        if ((15 + 24) % 24 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState = new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState("DECLARATION", 0, 0);
        DECLARATION = descriptorProtos$ExtensionRangeOptions$VerificationState;
        androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState descriptorProtos$ExtensionRangeOptions$VerificationState2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState("UNVERIFIED", 1, 1);
        UNVERIFIED = descriptorProtos$ExtensionRangeOptions$VerificationState2;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState[]{descriptorProtos$ExtensionRangeOptions$VerificationState, descriptorProtos$ExtensionRangeOptions$VerificationState2};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState$1();
    }

    private DescriptorProtos$ExtensionRangeOptions$VerificationState(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState fcmUPEDGtaHaCrcB(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState forNumber(int i) {
        if (i == 0) {
            return DECLARATION;
        }
        if (i == 1) {
            return UNVERIFIED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0070xfd86d390.INSTANCE;
    }

    public static java.lang.Enum NLBGiGOYcAemWWok(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState valueOf(int i) {
        return fcmUPEDGtaHaCrcB(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState) nLBGiGOYcAemWWok(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState[]) wqKIePRDDsgTOGUP($VALUES);
    }

    public static java.lang.object WqKIePRDDsgTOGUP(androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState[] descriptorProtos$ExtensionRangeOptions$VerificationStateArr) {
        return descriptorProtos$ExtensionRangeOptions$VerificationStateArr.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

