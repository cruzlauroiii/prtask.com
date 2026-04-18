namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet$FieldPresence : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence EXPLICIT;
    public static readonly int EXPLICIT_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence FIELD_PRESENCE_UNKNOWN;
    public static readonly int FIELD_PRESENCE_UNKNOWN_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence IMPLICIT;
    public static readonly int IMPLICIT_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence LEGACY_REQUIRED;
    public static readonly int LEGACY_REQUIRED_VALUE = 3;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence> internalValueDictionary;
    private readonly int value;

    static {
        if ((27 + 19) % 19 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence("FIELD_PRESENCE_UNKNOWN", 0, 0);
        FIELD_PRESENCE_UNKNOWN = descriptorProtos$FeatureHashSet$FieldPresence;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence("EXPLICIT", 1, 1);
        EXPLICIT = descriptorProtos$FeatureHashSet$FieldPresence2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence("IMPLICIT", 2, 2);
        IMPLICIT = descriptorProtos$FeatureHashSet$FieldPresence3;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence4 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence("LEGACY_REQUIRED", 3, 3);
        LEGACY_REQUIRED = descriptorProtos$FeatureHashSet$FieldPresence4;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence[]{descriptorProtos$FeatureHashSet$FieldPresence, descriptorProtos$FeatureHashSet$FieldPresence2, descriptorProtos$FeatureHashSet$FieldPresence3, descriptorProtos$FeatureHashSet$FieldPresence4};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence$1();
    }

    private DescriptorProtos$FeatureHashSet$FieldPresence(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static java.lang.object AtLGpZHJnivIUcDR(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence[] descriptorProtos$FeatureHashSet$FieldPresenceArr) {
        return descriptorProtos$FeatureHashSet$FieldPresenceArr.clone();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence HOfeIChXdOmHHIYw(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence forNumber(int i) {
        if (i == 0) {
            return FIELD_PRESENCE_UNKNOWN;
        }
        if (i == 1) {
            return EXPLICIT;
        }
        if (i == 2) {
            return IMPLICIT;
        }
        if (i == 3) {
            return LEGACY_REQUIRED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence$FieldPresenceVerifier.INSTANCE;
    }

    public static java.lang.Enum NPIwGXcDdMTXntZL(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence valueOf(int i) {
        return HOfeIChXdOmHHIYw(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence) nPIwGXcDdMTXntZL(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence[]) AtLGpZHJnivIUcDR($VALUES);
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

