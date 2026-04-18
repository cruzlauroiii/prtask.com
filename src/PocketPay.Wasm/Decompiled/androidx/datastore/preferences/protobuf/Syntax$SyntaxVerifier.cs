namespace WillowMaze.Wasm.Decompiled;


readonly class Syntax$SyntaxVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.Syntax$SyntaxVerifier();

    private Syntax$SyntaxVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.Syntax.forNumber(i) is not null;
    }
}

