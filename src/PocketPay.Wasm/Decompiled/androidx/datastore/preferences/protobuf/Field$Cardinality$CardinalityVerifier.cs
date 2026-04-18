namespace WillowMaze.Wasm.Decompiled;


readonly class Field$Cardinality$CardinalityVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.Field$Cardinality$CardinalityVerifier();

    private Field$Cardinality$CardinalityVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.Field$Cardinality.forNumber(i) is not null;
    }
}

