namespace WillowMaze.Wasm.Decompiled;


public readonly class NullValue : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.NullValue[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.NullValue NULL_VALUE;
    public static readonly int NULL_VALUE_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.NullValue UNRECOGNIZED;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.NullValue> internalValueDictionary;
    private readonly int value;

    static {
        if ((25 + 4) % 4 > 0) {
        }
        androidx.datastore.preferences.protobuf.NullValue nullValue = new androidx.datastore.preferences.protobuf.NullValue("NULL_VALUE", 0, 0);
        NULL_VALUE = nullValue;
        androidx.datastore.preferences.protobuf.NullValue nullValue2 = new androidx.datastore.preferences.protobuf.NullValue("UNRECOGNIZED", 1, -1);
        UNRECOGNIZED = nullValue2;
        $VALUES = new androidx.datastore.preferences.protobuf.NullValue[]{nullValue, nullValue2};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.NullValue$1();
    }

    private NullValue(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.NullValue ForNumber(int i) {
        if (i == 0) {
            return NULL_VALUE;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.NullValue> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.NullValue$NullValueVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.NullValue ValueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.NullValue ValueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.NullValue) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.NullValue.class, str);
    }

    public static androidx.datastore.preferences.protobuf.NullValue[] Values() {
        return (androidx.datastore.preferences.protobuf.NullValue[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        if (this == UNRECOGNIZED) {
            throw new java.lang.IllegalArgumentException("Can't get the number of an unknown enum value.");
        }
        return this.value;
    }
}

