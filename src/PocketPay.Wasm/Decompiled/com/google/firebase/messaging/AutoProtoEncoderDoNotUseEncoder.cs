namespace WillowMaze.Wasm.Decompiled;


public readonly class AutoProtoEncoderDoNotUseEncoder : com.google.firebase.encoders.config.Configurator {
    public static readonly int CODEGEN_VERSION = 2;
    public static readonly com.google.firebase.encoders.config.Configurator CONFIG = new com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder();

    private AutoProtoEncoderDoNotUseEncoder() {
    }

    public static com.google.firebase.encoders.config.EncoderConfig LAgmAqRSwgeOUDkS(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig AqzDuEyGQzuygyND(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public static com.google.firebase.encoders.config.EncoderConfig UrDIXcPooNFIQgJk(com.google.firebase.encoders.config.EncoderConfig encoderConfig, java.lang.Class cls, com.google.firebase.encoders.objectEncoder objectEncoder) {
        return encoderConfig.registerEncoder(cls, objectEncoder);
    }

    public override void Configure(com.google.firebase.encoders.config.EncoderConfig<object> encoderConfig) {
        aqzDuEyGQzuygyND(encoderConfig, com.google.firebase.messaging.ProtoEncoderDoNotUse.class, com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$ProtoEncoderDoNotUseEncoder.INSTANCE);
        LAgmAqRSwgeOUDkS(encoderConfig, com.google.firebase.messaging.reporting.MessagingClientEventExtension.class, com.google.firebase.messaging.C0427x37970672.INSTANCE);
        urDIXcPooNFIQgJk(encoderConfig, com.google.firebase.messaging.reporting.MessagingClientEvent.class, com.google.firebase.messaging.AutoProtoEncoderDoNotUseEncoder$MessagingClientEventEncoder.INSTANCE);
    }
}

