namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldDescriptorProto$Label : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label LABEL_OPTIONAL;
    public static readonly int LABEL_OPTIONAL_VALUE = 1;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label LABEL_REPEATED;
    public static readonly int LABEL_REPEATED_VALUE = 3;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label LABEL_REQUIRED;
    public static readonly int LABEL_REQUIRED_VALUE = 2;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label> internalValueDictionary;
    private readonly int value;

    static {
        if ((6 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$Label = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label("LABEL_OPTIONAL", 0, 1);
        LABEL_OPTIONAL = descriptorProtos$FieldDescriptorProto$Label;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$Label2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label("LABEL_REPEATED", 1, 3);
        LABEL_REPEATED = descriptorProtos$FieldDescriptorProto$Label2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$Label3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label("LABEL_REQUIRED", 2, 2);
        LABEL_REQUIRED = descriptorProtos$FieldDescriptorProto$Label3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label[]{descriptorProtos$FieldDescriptorProto$Label, descriptorProtos$FieldDescriptorProto$Label2, descriptorProtos$FieldDescriptorProto$Label3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label$1();
    }

    private DescriptorProtos$FieldDescriptorProto$Label(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label forNumber(int i) {
        if (i == 1) {
            return LABEL_OPTIONAL;
        }
        if (i == 2) {
            return LABEL_REQUIRED;
        }
        if (i == 3) {
            return LABEL_REPEATED;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label$LabelVerifier.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

