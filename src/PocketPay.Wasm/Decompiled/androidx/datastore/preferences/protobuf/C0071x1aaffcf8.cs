namespace WillowMaze.Wasm.Decompiled;


readonly class C0071x1aaffcf8 : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.C0071x1aaffcf8();

    private C0071x1aaffcf8() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding.forNumber(i) is not null;
    }
}

