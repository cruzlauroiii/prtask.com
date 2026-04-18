namespace WillowMaze.Wasm.Decompiled;


readonly class C0070xfd86d390 : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.C0070xfd86d390();

    private C0070xfd86d390() {
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState ytktENLTnisJsYAT(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$ExtensionRangeOptions$VerificationState.forNumber(i);
    }

    public override bool IsInRange(int i) {
        return ytktENLTnisJsYAT(i) is not null;
    }
}

