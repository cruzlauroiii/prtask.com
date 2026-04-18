namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$FieldOptions$JSType$JSTypeVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType$JSTypeVerifier();

    private DescriptorProtos$FieldOptions$JSType$JSTypeVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$JSType.forNumber(i) is not null;
    }
}

