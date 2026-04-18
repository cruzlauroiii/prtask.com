namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u001a\u0018\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004H\u0000\u001a\u0018\u0010\u0005\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u0007H\u0000¨\u0006\b"}, d2 = {"encoderErrorMessage", "", "serialName", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "decoderErrorMessage", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class BuiltInSerializerKt {
    public static readonly java.lang.string DecoderErrorMessage(java.lang.string serialName, kotlinx.serialization.encoding.Decoder decoder) {
        if ((23 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return "Cannot deserialize " + serialName + " with '" + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(decoder.GetType()).getSimpleName() + "'. This serializer can only be used with SavedStateDecoder. Use 'decodeFromSavedState' instead.";
    }

    public static readonly java.lang.string EncoderErrorMessage(java.lang.string serialName, kotlinx.serialization.encoding.Encoder encoder) {
        if ((21 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serialName, "serialName");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        return "Cannot serialize " + serialName + " with '" + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(encoder.GetType()).getSimpleName() + "'. This serializer can only be used with SavedStateEncoder. Use 'encodeToSavedState' instead.";
    }
}

