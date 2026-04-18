namespace WillowMaze.Wasm.Decompiled;


readonly class C0079x9e84b349 : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.C0079x9e84b349();

    private C0079x9e84b349() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$MethodOptions$IdempotencyLevel.forNumber(i) is not null;
    }
}

