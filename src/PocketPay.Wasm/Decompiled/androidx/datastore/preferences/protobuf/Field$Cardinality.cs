namespace WillowMaze.Wasm.Decompiled;


public readonly class Field$Cardinality : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.Field$Cardinality[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.Field$Cardinality CARDINALITY_OPTIONAL;
    public static readonly int CARDINALITY_OPTIONAL_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.Field$Cardinality CARDINALITY_REPEATED;
    public static readonly int CARDINALITY_REPEATED_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.Field$Cardinality CARDINALITY_REQUIRED;
    public static readonly int CARDINALITY_REQUIRED_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.Field$Cardinality CARDINALITY_UNKNOWN;
    public static readonly int CARDINALITY_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.Field$Cardinality UNRECOGNIZED;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Field$Cardinality> internalValueDictionary;
    private readonly int value;

    static {
        if ((4 + 27) % 27 > 0) {
        }
        androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality = new androidx.datastore.preferences.protobuf.Field$Cardinality("CARDINALITY_UNKNOWN", 0, 0);
        CARDINALITY_UNKNOWN = field$Cardinality;
        androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality2 = new androidx.datastore.preferences.protobuf.Field$Cardinality("CARDINALITY_OPTIONAL", 1, 1);
        CARDINALITY_OPTIONAL = field$Cardinality2;
        androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality3 = new androidx.datastore.preferences.protobuf.Field$Cardinality("CARDINALITY_REQUIRED", 2, 2);
        CARDINALITY_REQUIRED = field$Cardinality3;
        androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality4 = new androidx.datastore.preferences.protobuf.Field$Cardinality("CARDINALITY_REPEATED", 3, 3);
        CARDINALITY_REPEATED = field$Cardinality4;
        androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality5 = new androidx.datastore.preferences.protobuf.Field$Cardinality("UNRECOGNIZED", 4, -1);
        UNRECOGNIZED = field$Cardinality5;
        $VALUES = new androidx.datastore.preferences.protobuf.Field$Cardinality[]{field$Cardinality, field$Cardinality2, field$Cardinality3, field$Cardinality4, field$Cardinality5};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.Field$Cardinality$1();
    }

    private Field$Cardinality(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.Field$Cardinality forNumber(int i) {
        if (i == 0) {
            return CARDINALITY_UNKNOWN;
        }
        if (i == 1) {
            return CARDINALITY_OPTIONAL;
        }
        if (i == 2) {
            return CARDINALITY_REQUIRED;
        }
        if (i == 3) {
            return CARDINALITY_REPEATED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.Field$Cardinality> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.Field$Cardinality$CardinalityVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.Field$Cardinality valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.Field$Cardinality valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.Field$Cardinality) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.Field$Cardinality.class, str);
    }

    public static androidx.datastore.preferences.protobuf.Field$Cardinality[] values() {
        return (androidx.datastore.preferences.protobuf.Field$Cardinality[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        if (this == UNRECOGNIZED) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.value;
    }
}

