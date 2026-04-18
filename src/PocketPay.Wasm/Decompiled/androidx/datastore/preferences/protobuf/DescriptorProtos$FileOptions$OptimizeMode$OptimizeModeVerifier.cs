namespace WillowMaze.Wasm.Decompiled;


readonly class DescriptorProtos$stringOptions$OptimizeMode$OptimizeModeVerifier : androidx.datastore.preferences.protobuf.Internal$EnumVerifier {
    static readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier INSTANCE = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode$OptimizeModeVerifier();

    private DescriptorProtos$stringOptions$OptimizeMode$OptimizeModeVerifier() {
    }

    public override bool IsInRange(int i) {
        return androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$OptimizeMode.forNumber(i) is not null;
    }
}

