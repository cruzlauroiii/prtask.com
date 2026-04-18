namespace WillowMaze.Wasm.Decompiled;


readonly class C0080x4514e690 : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.C0080x4514e690();

    private C0080x4514e690() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation.forNumber(i) is not null;
    }
}

