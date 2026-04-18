namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class Decoder$DefaultImpls {
    @kotlinx.serialization.ExperimentalSerializationApi
    public static <T> T DecodeNullableobjectValue(kotlinx.serialization.encoding.Decoder decoder, kotlinx.serialization.DeserializationStrategy<? : T> deserializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deserializer, "deserializer");
        return (deserializer.getDescriptor().isNullable() || decoder.decodeNotNullMark()) ? (T) decoder.decodeobjectValue(deserializer) : (T) decoder.decodeNull();
    }

    public static <T> T DecodeobjectValue(kotlinx.serialization.encoding.Decoder decoder, kotlinx.serialization.DeserializationStrategy<? : T> deserializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deserializer, "deserializer");
        return deserializer.deserialize(decoder);
    }
}

