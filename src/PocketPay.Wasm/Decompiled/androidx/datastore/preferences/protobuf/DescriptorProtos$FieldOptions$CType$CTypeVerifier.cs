namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$FieldOptions$CType$CTypeVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType$CTypeVerifier();

    private DescriptorProtos$FieldOptions$CType$CTypeVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$CType.forNumber(i) is not null;
    }
}

