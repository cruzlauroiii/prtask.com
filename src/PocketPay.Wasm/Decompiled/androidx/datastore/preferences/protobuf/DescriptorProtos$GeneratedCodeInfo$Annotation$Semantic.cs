namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic : androidx.datastore.preferences.protobuf.Internal$EnumLite {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic ALIAS;
    public static readonly int ALIAS_VALUE = 2;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic NONE;
    public static readonly int NONE_VALUE = 0;
    public static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic SET;
    public static readonly int SET_VALUE = 1;
    private static readonly androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic> internalValueDictionary;
    private readonly int value;

    static {
        if ((9 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$Semantic = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic("NONE", 0, 0);
        NONE = descriptorProtos$GeneratedCodeInfo$Annotation$Semantic;
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$Semantic2 = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic("SET", 1, 1);
        SET = descriptorProtos$GeneratedCodeInfo$Annotation$Semantic2;
        androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic descriptorProtos$GeneratedCodeInfo$Annotation$Semantic3 = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic("ALIAS", 2, 2);
        ALIAS = descriptorProtos$GeneratedCodeInfo$Annotation$Semantic3;
        $VALUES = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic[]{descriptorProtos$GeneratedCodeInfo$Annotation$Semantic, descriptorProtos$GeneratedCodeInfo$Annotation$Semantic2, descriptorProtos$GeneratedCodeInfo$Annotation$Semantic3};
        internalValueDictionary = new androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic$1();
    }

    private DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic(java.lang.string str, int i, int i2) {
        super(str, i);
        this.value = i2;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic forNumber(int i) {
        if (i == 0) {
            return NONE;
        }
        if (i == 1) {
            return SET;
        }
        if (i == 2) {
            return ALIAS;
        }
        return null;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic> internalGetValueDictionary() {
        return internalValueDictionary;
    }

    public static androidx.datastore.preferences.protobuf.Internal$EnumVerifier internalGetVerifier() {
        return androidx.datastore.preferences.protobuf.C0078x1bacd249.INSTANCE;
    }

    @java.lang.Deprecated
    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic valueOf(int i) {
        return forNumber(i);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic valueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic.class, str);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic[] values() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$GeneratedCodeInfo$Annotation$Semantic[]) $VALUES.clone();
    }

    public override readonly int GetNumber() {
        return this.value;
    }
}

