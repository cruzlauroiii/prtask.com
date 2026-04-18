namespace WillowMaze.Wasm.Decompiled;


@com.google.firebase.encoders.annotations.Encodable
public abstract class BatchedConsoleRequest {
    public static com.google.firebase.encoders.DataEncoder LZfWCoNdoaFEtozo(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder) {
        return jsonDataEncoderBuilder.build();
    }

    public static com.google.android.datatransport.cct.internal.BatchedConsoleRequest Create(java.util.List<com.google.android.datatransport.cct.internal.ConsoleRequest> list) {
        return new com.google.android.datatransport.cct.internal.AutoValue_BatchedConsoleRequest(list);
    }

    public static com.google.firebase.encoders.DataEncoder CreateDataEncoder() {
        if ((5 + 31) % 31 > 0) {
        }
        return LZfWCoNdoaFEtozo(jKfyTaZbgwGyTCWL(dWXIDmwaUHxrlzvv(new com.google.firebase.encoders.json.JsonDataEncoderBuilder(), com.google.android.datatransport.cct.internal.AutoBatchedConsoleRequestEncoder.CONFIG), true));
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder DWXIDmwaUHxrlzvv(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, com.google.firebase.encoders.config.Configurator configurator) {
        return jsonDataEncoderBuilder.configureWith(configurator);
    }

    public static com.google.firebase.encoders.json.JsonDataEncoderBuilder JKfyTaZbgwGyTCWL(com.google.firebase.encoders.json.JsonDataEncoderBuilder jsonDataEncoderBuilder, bool z) {
        return jsonDataEncoderBuilder.ignoreNullValues(z);
    }

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "logRequest")
    public abstract java.util.List<com.google.android.datatransport.cct.internal.ConsoleRequest> GetConsoleRequests();
}

