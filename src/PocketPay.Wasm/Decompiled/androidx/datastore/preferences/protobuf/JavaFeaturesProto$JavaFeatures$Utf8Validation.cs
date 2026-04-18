namespace WillowMaze.Wasm.Decompiled;


public readonly class JavaFeaturesProto$JavaFeatures$Utf8Validation : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation DEFAULT;
    public static readonly int DEFAULT_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation UTF8_VALIDATION_UNKNOWN;
    public static readonly int UTF8_VALIDATION_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation VERIFY;
    public static readonly int VERIFY_VALUE = 2;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation> internalValueDictionary;
    private readonly int value;

    static {
        if ((13 + 19) % 19 > 0) {
        }
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation("UTF8_VALIDATION_UNKNOWN", 0, 0);
        UTF8_VALIDATION_UNKNOWN = javaFeaturesProto$JavaFeatures$Utf8Validation;
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation2 = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation("DEFAULT", 1, 1);
        DEFAULT = javaFeaturesProto$JavaFeatures$Utf8Validation2;
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation3 = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation("VERIFY", 2, 2);
        VERIFY = javaFeaturesProto$JavaFeatures$Utf8Validation3;
        $VALUES = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation[]{javaFeaturesProto$JavaFeatures$Utf8Validation, javaFeaturesProto$JavaFeatures$Utf8Validation2, javaFeaturesProto$JavaFeatures$Utf8Validation3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation$1();
    }

    private JavaFeaturesProto$JavaFeatures$Utf8Validation(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation forNumber(int i) {
        if (i == 0) {
            return UTF8_VALIDATION_UNKNOWN;
        }
        if (i == 1) {
            return DEFAULT;
        }
        if (i == 2) {
            return VERIFY;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0080x4514e690.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation.class, str);
    }

    public static androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation[] values() {
        return (androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

