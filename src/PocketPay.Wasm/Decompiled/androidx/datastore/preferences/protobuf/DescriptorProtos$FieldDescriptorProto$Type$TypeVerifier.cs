namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$FieldDescriptorProto$Type$TypeVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type$TypeVerifier();

    private DescriptorProtos$FieldDescriptorProto$Type$TypeVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type.forNumber(i) is not null;
    }
}

