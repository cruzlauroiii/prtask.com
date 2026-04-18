namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\b\u001a\u00020\t*\u00020\u0002H\u0014¢\u0006\u0004\b\n\u0010\u000bJ\u0013\u0010\f\u001a\u00020\u0005*\u00020\u0002H\u0014¢\u0006\u0004\b\r\u0010\u000eJ\u000f\u0010\u000f\u001a\u00020\u0002H\u0014¢\u0006\u0004\b\u0010\u0010\u0011J(\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0014J'\u0010\u001a\u001a\u00020\u00132\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u00022\u0006\u0010\u001e\u001a\u00020\tH\u0014¢\u0006\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/serialization/internal/UlongArraySerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/UlongArray;", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "Lkotlin/Ulong;", "Lkotlinx/serialization/internal/UlongArrayBuilder;", "<init>", "()V", "collectionSize", "", "collectionSize-QwZRm1k", "([J)I", "toBuilder", "toBuilder-QwZRm1k", "([J)Lkotlinx/serialization/internal/UlongArrayBuilder;", "empty", "empty-Y2RjT0g", "()[J", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "writeContent-0q3Fkuo", "(Lkotlinx/serialization/encoding/CompositeEncoder;[JI)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UlongArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<kotlin.Ulong, kotlin.UlongArray, kotlinx.serialization.internal.UlongArrayBuilder> : kotlinx.serialization.KSerializer<kotlin.UlongArray> {
    public static readonly kotlinx.serialization.internal.UlongArraySerializer INSTANCE = new kotlinx.serialization.internal.UlongArraySerializer();

    private UlongArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.Ulong.Companion));
    }

    public override int CollectionSize(java.lang.object obj) {
        return m3576collectionSizeQwZRm1k(((kotlin.UlongArray) obj).m1878unboximpl());
    }

    protected int M3576collectionSizeQwZRm1k(long[] collectionSize) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collectionSize, "$this$collectionSize");
        return kotlin.UlongArray.m1852getSizeimpl(collectionSize);
    }

    public override kotlin.UlongArray Empty() {
        return kotlin.UlongArray.m1820boximpl(m3577emptyY2RjT0g());
    }

    protected long[] M3577emptyY2RjT0g() {
        return kotlin.UlongArray.m1830constructorimpl(0);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UlongArrayBuilder) obj, z);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UlongArrayBuilder) primitiveArrayBuilder, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.UlongArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.m3574appendVKZWuLQ$kotlinx_serialization_core(kotlin.Ulong.m1611constructorimpl(decoder.decodeInlineElement(getDescriptor(), index).decodelong()));
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return m3578toBuilderQwZRm1k(((kotlin.UlongArray) obj).m1878unboximpl());
    }

    protected kotlinx.serialization.internal.UlongArrayBuilder M3578toBuilderQwZRm1k(long[] toBuilder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(toBuilder, "$this$toBuilder");
        return new kotlinx.serialization.internal.UlongArrayBuilder(toBuilder, null);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, kotlin.UlongArray ulongArray, int i) {
        m3579writeContent0q3Fkuo(compositeEncoder, ulongArray.m1878unboximpl(), i);
    }

    protected void M3579writeContent0q3Fkuo(kotlinx.serialization.encoding.CompositeEncoder encoder, long[] content, int size) {
        if ((13 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeInlineElement(getDescriptor(), i).encodelong(kotlin.UlongArray.m1848getsVKNKU(content, i));
        }
    }
}

