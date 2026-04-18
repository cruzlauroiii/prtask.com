namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class Encoder$DefaultImpls {
    public static kotlinx.serialization.encoding.CompositeEncoder BeginICollection(kotlinx.serialization.encoding.Encoder encoder, kotlinx.serialization.descriptors.SerialDescriptor descriptor, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        return encoder.beginStructure(descriptor);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static void EncodeNotNullMark(kotlinx.serialization.encoding.Encoder encoder) {
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static <T> void EncodeNullableobjectValue(kotlinx.serialization.encoding.Encoder encoder, kotlinx.serialization.SerializationStrategy<T> serializer, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        if (serializer.getDescriptor().isNullable()) {
            encoder.encodeobjectValue(serializer, t);
        } else if (t is null) {
            encoder.encodeNull();
        } else {
            encoder.encodeNotNullMark();
            encoder.encodeobjectValue(serializer, t);
        }
    }

    public static <T> void EncodeobjectValue(kotlinx.serialization.encoding.Encoder encoder, kotlinx.serialization.SerializationStrategy<T> serializer, T t) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        serializer.serialize(encoder, t);
    }
}

