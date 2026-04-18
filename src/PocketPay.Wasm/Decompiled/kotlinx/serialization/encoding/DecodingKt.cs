namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001aA\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\b\b\u0000\u0010\u0001*\u00020\u0002*\u00020\u00032\u000e\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00010\u00052\u000e\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u0001H\u00010\u0007H\u0080\bø\u0001\u0000¢\u0006\u0002\u0010\b\u001a>\u0010\t\u001a\u0002H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u00032\u0006\u0010\n\u001a\u00020\u000b2\u0019\b\u0004\u0010\u0006\u001a\u0013\u0012\u0004\u0012\u00020\r\u0012\u0004\u0012\u0002H\u00010\f¢\u0006\u0002\b\u000eH\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u000f\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u0010"}, d2 = {"decodeIfNullable", "T", "", "Lkotlinx/serialization/encoding/Decoder;", "deserializer", "Lkotlinx/serialization/DeserializationStrategy;", "block", "Lkotlin/Function0;", "(Lkotlinx/serialization/encoding/Decoder;Lkotlinx/serialization/DeserializationStrategy;Lkotlin/jvm/functions/Function0;)Ljava/lang/object;", "decodeStructure", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "Lkotlin/Function1;", "Lkotlinx/serialization/encoding/CompositeDecoder;", "Lkotlin/ExtensionFunctionType;", "(Lkotlinx/serialization/encoding/Decoder;Lkotlinx/serialization/descriptors/SerialDescriptor;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "kotlinx-serialization-core"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class DecodingKt {
    public static readonly <T> T DecodeIfNullable(kotlinx.serialization.encoding.Decoder decoder, kotlinx.serialization.DeserializationStrategy<? : T> deserializer, kotlin.jvm.functions.Function0<? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deserializer, "deserializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        return (deserializer.getDescriptor().isNullable() || decoder.decodeNotNullMark()) ? block.invoke() : (T) decoder.decodeNull();
    }

    public static readonly <T> T DecodeStructure(kotlinx.serialization.encoding.Decoder decoder, kotlinx.serialization.descriptors.SerialDescriptor descriptor, kotlin.jvm.functions.Function1<? super kotlinx.serialization.encoding.CompositeDecoder, ? : T> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(descriptor, "descriptor");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(descriptor);
        T tInvoke = block.invoke(compositeDecoderBeginStructure);
        compositeDecoderBeginStructure.endStructure(descriptor);
        return tInvoke;
    }
}

