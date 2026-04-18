namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$stringOptions$OptimizeMode : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode CODE_SIZE;
    public static readonly int CODE_SIZE_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode LITE_RUNTIME;
    public static readonly int LITE_RUNTIME_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode SPEED;
    public static readonly int SPEED_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode> internalValueDictionary;
    private readonly int value;

    static {
        if ((19 + 19) % 19 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeMode = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode("SPEED", 0, 1);
        SPEED = descriptorProtos$stringOptions$OptimizeMode;
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeMode2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode("CODE_SIZE", 1, 2);
        CODE_SIZE = descriptorProtos$stringOptions$OptimizeMode2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode descriptorProtos$stringOptions$OptimizeMode3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode("LITE_RUNTIME", 2, 3);
        LITE_RUNTIME = descriptorProtos$stringOptions$OptimizeMode3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode[]{descriptorProtos$stringOptions$OptimizeMode, descriptorProtos$stringOptions$OptimizeMode2, descriptorProtos$stringOptions$OptimizeMode3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode$1();
    }

    private DescriptorProtos$stringOptions$OptimizeMode(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode forNumber(int i) {
        if (i == 1) {
            return SPEED;
        }
        if (i == 2) {
            return CODE_SIZE;
        }
        if (i == 3) {
            return LITE_RUNTIME;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode$OptimizeModeVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

