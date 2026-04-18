namespace WillowMaze.Wasm.Decompiled;


readonly class C0076x40db608e : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.C0076x40db608e();

    private C0076x40db608e() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$OptionRetention.forNumber(i) is not null;
    }
}

