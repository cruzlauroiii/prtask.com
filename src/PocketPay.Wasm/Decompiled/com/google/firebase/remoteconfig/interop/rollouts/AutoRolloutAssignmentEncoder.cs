namespace WillowMaze.Wasm.Decompiled;


public readonly class AutoRolloutAssignmentEncoder : com.google.firebase.encoders.config.Configurator {
    public static readonly int CODEGEN_VERSION = 2;
    public static readonly com.google.firebase.encoders.config.Configurator CONFIG = new com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder();

    private AutoRolloutAssignmentEncoder() {
    }

    public static com.google.firebase.encoders.config.EncoderConfig BfhFzAUMYWPfIWyJ(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig NdGtgXygtAFWqAfZ(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public override void Configure(com.google.firebase.encoders.config.EncoderConfig<object> encoderConfig) {
        ndGtgXygtAFWqAfZ(encoderConfig, com.google.firebase.remoteconfig.interop.rollouts.RolloutAssignment.class, com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder.INSTANCE);
        bfhFzAUMYWPfIWyJ(encoderConfig, com.google.firebase.remoteconfig.interop.rollouts.AutoValue_RolloutAssignment.class, com.google.firebase.remoteconfig.interop.rollouts.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder.INSTANCE);
    }
}

