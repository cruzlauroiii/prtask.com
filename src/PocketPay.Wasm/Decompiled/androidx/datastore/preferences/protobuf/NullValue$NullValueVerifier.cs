namespace WillowMaze.Wasm.Decompiled;


readonly class NullValue$NullValueVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.NullValue$NullValueVerifier();

    private NullValue$NullValueVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.NullValue.forNumber(i) is not null;
    }
}

