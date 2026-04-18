namespace WillowMaze.Wasm.Decompiled;


public readonly class AutoSessionEventEncoder : com.google.firebase.encoders.config.Configurator {
    public static readonly int CODEGEN_VERSION = 2;
    public static readonly com.google.firebase.encoders.config.Configurator CONFIG = new com.google.firebase.sessions.AutoSessionEventEncoder();

    private AutoSessionEventEncoder() {
    }

    public static com.google.firebase.encoders.config.EncoderConfig ErceQPGsnGXPdoOd(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig GPHVAIxppZUjEoGy(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig RBzyNsdcSfZCiizX(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig WkSxBmTrBIsUfthE(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig EQHcgWJvcRGFeZxd(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig FPCZCTtHKEHXnflF(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public override void Configure(com.google.firebase.encoders.config.EncoderConfig<object> encoderConfig) {
        GPHVAIxppZUjEoGy(encoderConfig, com.google.firebase.sessions.SessionEvent.class, com.google.firebase.sessions.AutoSessionEventEncoder$SessionEventEncoder.INSTANCE);
        eQHcgWJvcRGFeZxd(encoderConfig, com.google.firebase.sessions.SessionInfo.class, com.google.firebase.sessions.AutoSessionEventEncoder$SessionInfoEncoder.INSTANCE);
        WkSxBmTrBIsUfthE(encoderConfig, com.google.firebase.sessions.DataICollectionStatus.class, com.google.firebase.sessions.AutoSessionEventEncoder$DataICollectionStatusEncoder.INSTANCE);
        fPCZCTtHKEHXnflF(encoderConfig, com.google.firebase.sessions.ApplicationInfo.class, com.google.firebase.sessions.AutoSessionEventEncoder$ApplicationInfoEncoder.INSTANCE);
        ErceQPGsnGXPdoOd(encoderConfig, com.google.firebase.sessions.AndroidApplicationInfo.class, com.google.firebase.sessions.AutoSessionEventEncoder$AndroidApplicationInfoEncoder.INSTANCE);
        RBzyNsdcSfZCiizX(encoderConfig, com.google.firebase.sessions.ProcessDetails.class, com.google.firebase.sessions.AutoSessionEventEncoder$ProcessDetailsEncoder.INSTANCE);
    }
}

