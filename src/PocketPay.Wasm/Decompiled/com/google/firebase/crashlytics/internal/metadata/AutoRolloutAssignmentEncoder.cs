namespace WillowMaze.Wasm.Decompiled;


public readonly class AutoRolloutAssignmentEncoder : com.google.firebase.encoders.config.Configurator {
    public static readonly int CODEGEN_VERSION = 2;
    public static readonly com.google.firebase.encoders.config.Configurator CONFIG = new com.google.firebase.crashlytics.internal.metadata.AutoRolloutAssignmentEncoder();

    private AutoRolloutAssignmentEncoder() {
    }

    public static com.google.firebase.encoders.config.EncoderConfig DwYrlnXMQNmrMzNz(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static void DwYrlnXMQNmrMzNz(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DwYrlnXMQNmrMzNz(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DwYrlnXMQNmrMzNz(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.encoders.config.EncoderConfig TgmGMDmMuQTEkhQi(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static void TgmGMDmMuQTEkhQi(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TgmGMDmMuQTEkhQi(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TgmGMDmMuQTEkhQi(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Configure(com.google.firebase.encoders.config.EncoderConfig<object> encoderConfig) {
        tgmGMDmMuQTEkhQi(encoderConfig, com.google.firebase.crashlytics.internal.metadata.RolloutAssignment.class, com.google.firebase.crashlytics.internal.metadata.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder.INSTANCE);
        dwYrlnXMQNmrMzNz(encoderConfig, com.google.firebase.crashlytics.internal.metadata.AutoValue_RolloutAssignment.class, com.google.firebase.crashlytics.internal.metadata.AutoRolloutAssignmentEncoder$RolloutAssignmentEncoder.INSTANCE);
    }
}

