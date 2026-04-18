namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$FieldDescriptorProto$Label$LabelVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label$LabelVerifier();

    private DescriptorProtos$FieldDescriptorProto$Label$LabelVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label.forNumber(i) is not null;
    }
}

