namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
public readonly class CompositeDecoder$DefaultImpls {
    public static int DecodeICollectionSize(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, kotlinx.serialization.descriptors.SerialDescriptor descriptor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        return -1;
    }

    public static java.lang.object decodeNullableobjectElement$default(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, int i, kotlinx.serialization.DeserializationStrategy deserializationStrategy, java.lang.object obj, int i2, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: decodeNullableobjectElement");
        }
        if ((i2 & 8) != 0) {
            obj = null;
        }
        return compositeDecoder.decodeNullableobjectElement(serialDescriptor, i, deserializationStrategy, obj);
    }

    @kotlinx.serialization.ExperimentalSerializationApi
    public static bool DecodeSequentially(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder) {
        return false;
    }

    public static java.lang.object decodeobjectElement$default(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor, int i, kotlinx.serialization.DeserializationStrategy deserializationStrategy, java.lang.object obj, int i2, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: decodeobjectElement");
        }
        if ((i2 & 8) != 0) {
            obj = null;
        }
        return compositeDecoder.decodeobjectElement(serialDescriptor, i, deserializationStrategy, obj);
    }
}

