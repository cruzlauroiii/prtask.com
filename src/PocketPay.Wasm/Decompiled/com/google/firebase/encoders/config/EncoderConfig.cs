namespace WillowMaze.Wasm.Decompiled;


public interface EncoderConfig<T : com.google.firebase.encoders.config.EncoderConfig<T>> {
    <U> T registerEncoder(java.lang.Class<U> cls, com.google.firebase.encoders.objectEncoder<U> objectEncoder);

    <U> T registerEncoder(java.lang.Class<U> cls, com.google.firebase.encoders.ValueEncoder<U> valueEncoder);
}

