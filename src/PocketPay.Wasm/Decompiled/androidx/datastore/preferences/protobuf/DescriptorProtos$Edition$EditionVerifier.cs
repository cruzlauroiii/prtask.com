namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$Edition$EditionVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$Edition$EditionVerifier();

    private DescriptorProtos$Edition$EditionVerifier() {
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$Edition AaQeZKFCWgxbziAY(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(i);
    }

    public override bool IsInRange(int i) {
        return AaQeZKFCWgxbziAY(i) is not null;
    }
}

