namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$MethodOptions$IdempotencyLevel : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel IDEMPOTENCY_UNKNOWN;
    public static readonly int IDEMPOTENCY_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel IDEMPOTENT;
    public static readonly int IDEMPOTENT_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel NO_SIDE_EFFECTS;
    public static readonly int NO_SIDE_EFFECTS_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel> internalValueDictionary;
    private readonly int value;

    static {
        if ((17 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel("IDEMPOTENCY_UNKNOWN", 0, 0);
        IDEMPOTENCY_UNKNOWN = descriptorProtos$MethodOptions$IdempotencyLevel;
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel("NO_SIDE_EFFECTS", 1, 1);
        NO_SIDE_EFFECTS = descriptorProtos$MethodOptions$IdempotencyLevel2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel descriptorProtos$MethodOptions$IdempotencyLevel3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel("IDEMPOTENT", 2, 2);
        IDEMPOTENT = descriptorProtos$MethodOptions$IdempotencyLevel3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel[]{descriptorProtos$MethodOptions$IdempotencyLevel, descriptorProtos$MethodOptions$IdempotencyLevel2, descriptorProtos$MethodOptions$IdempotencyLevel3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel$1();
    }

    private DescriptorProtos$MethodOptions$IdempotencyLevel(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel forNumber(int i) {
        if (i == 0) {
            return IDEMPOTENCY_UNKNOWN;
        }
        if (i == 1) {
            return NO_SIDE_EFFECTS;
        }
        if (i == 2) {
            return IDEMPOTENT;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0079x9e84b349.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

