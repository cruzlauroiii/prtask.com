namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$FeatureHashSet$JsonFormat$JsonFormatVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat$JsonFormatVerifier();

    private DescriptorProtos$FeatureHashSet$JsonFormat$JsonFormatVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat.forNumber(i) is not null;
    }
}

