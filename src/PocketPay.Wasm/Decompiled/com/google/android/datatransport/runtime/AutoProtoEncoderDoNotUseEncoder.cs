namespace WillowMaze.Wasm.Decompiled;


public readonly class AutoProtoEncoderDoNotUseEncoder : com.google.firebase.encoders.config.Configurator {
    public static readonly int CODEGEN_VERSION = 2;
    public static readonly com.google.firebase.encoders.config.Configurator CONFIG = new com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder();

    private AutoProtoEncoderDoNotUseEncoder() {
    }

    public static com.google.firebase.encoders.config.EncoderConfig BYkiEQQKjRqqcuVK(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig NrqNiQifRYcRBsMs(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig NyoAiztIlfOBNeNt(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig BvcFBYdBcZfEEbNF(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig DWmzolecBSFJDqUE(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig KcGASqbYtVuRZpBA(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig PBmgVVeaigFoJAQf(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public override void Configure(com.google.firebase.encoders.config.EncoderConfig<object> encoderConfig) {
        BYkiEQQKjRqqcuVK(encoderConfig, com.google.android.datatransport.runtime.ProtoEncoderDoNotUse.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder.INSTANCE);
        dWmzolecBSFJDqUE(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.ClientMetrics.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ClientMetricsEncoder.INSTANCE);
        NyoAiztIlfOBNeNt(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.TimeWindow.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$TimeWindowEncoder.INSTANCE);
        pBmgVVeaigFoJAQf(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.ConsoleSourceMetrics.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleSourceMetricsEncoder.INSTANCE);
        kcGASqbYtVuRZpBA(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.ConsoleEventDropped.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$ConsoleEventDroppedEncoder.INSTANCE);
        bvcFBYdBcZfEEbNF(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.GlobalMetrics.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$GlobalMetricsEncoder.INSTANCE);
        NrqNiQifRYcRBsMs(encoderConfig, com.google.android.datatransport.runtime.firebase.transport.StorageMetrics.class, com.google.android.datatransport.runtime.AutoProtoEncoderDoNotUseEncoder$StorageMetricsEncoder.INSTANCE);
    }
}

