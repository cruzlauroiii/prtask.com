namespace WillowMaze.Wasm.Decompiled;


readonly class Field$Kind$KindVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.Field$Kind$KindVerifier();

    private Field$Kind$KindVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.Field$Kind.forNumber(i) is not null;
    }
}

