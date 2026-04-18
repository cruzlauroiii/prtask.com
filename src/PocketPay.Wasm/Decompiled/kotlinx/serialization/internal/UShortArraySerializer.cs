namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\b\u001a\u00020\t*\u00020\u0002H\u0014¢\u0006\u0004\b\n\u0010\u000bJ\u0013\u0010\f\u001a\u00020\u0005*\u00020\u0002H\u0014¢\u0006\u0004\b\r\u0010\u000eJ\u000f\u0010\u000f\u001a\u00020\u0002H\u0014¢\u0006\u0004\b\u0010\u0010\u0011J(\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0014J'\u0010\u001a\u001a\u00020\u00132\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u00022\u0006\u0010\u001e\u001a\u00020\tH\u0014¢\u0006\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/serialization/internal/UshortArraySerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/UshortArray;", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "Lkotlin/Ushort;", "Lkotlinx/serialization/internal/UshortArrayBuilder;", "<init>", "()V", "collectionSize", "", "collectionSize-rL5Bavg", "([S)I", "toBuilder", "toBuilder-rL5Bavg", "([S)Lkotlinx/serialization/internal/UshortArrayBuilder;", "empty", "empty-amswpOA", "()[S", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "writeContent-eny0XGE", "(Lkotlinx/serialization/encoding/CompositeEncoder;[SI)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UshortArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<kotlin.Ushort, kotlin.UshortArray, kotlinx.serialization.internal.UshortArrayBuilder> : kotlinx.serialization.KSerializer<kotlin.UshortArray> {
    public static readonly kotlinx.serialization.internal.UshortArraySerializer INSTANCE = new kotlinx.serialization.internal.UshortArraySerializer();

    private UshortArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.Ushort.Companion));
    }

    public override int CollectionSize(java.lang.object obj) {
        return m3584collectionSizerL5Bavg(((kotlin.UshortArray) obj).m2283unboximpl());
    }

    protected int M3584collectionSizerL5Bavg(short[] collectionSize) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collectionSize, "$this$collectionSize");
        return kotlin.UshortArray.m2257getSizeimpl(collectionSize);
    }

    public override kotlin.UshortArray Empty() {
        return kotlin.UshortArray.m2225boximpl(m3585emptyamswpOA());
    }

    protected short[] M3585emptyamswpOA() {
        return kotlin.UshortArray.m2235constructorimpl(0);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UshortArrayBuilder) obj, z);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UshortArrayBuilder) primitiveArrayBuilder, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.UshortArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.m3582appendxj2QHRw$kotlinx_serialization_core(kotlin.Ushort.m2024constructorimpl(decoder.decodeInlineElement(getDescriptor(), index).decodeshort()));
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return m3586toBuilderrL5Bavg(((kotlin.UshortArray) obj).m2283unboximpl());
    }

    protected kotlinx.serialization.internal.UshortArrayBuilder M3586toBuilderrL5Bavg(short[] toBuilder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(toBuilder, "$this$toBuilder");
        return new kotlinx.serialization.internal.UshortArrayBuilder(toBuilder, null);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, kotlin.UshortArray ushortArray, int i) {
        m3587writeContenteny0XGE(compositeEncoder, ushortArray.m2283unboximpl(), i);
    }

    protected void M3587writeContenteny0XGE(kotlinx.serialization.encoding.CompositeEncoder encoder, short[] content, int size) {
        if ((12 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeInlineElement(getDescriptor(), i).encodeshort(kotlin.UshortArray.m2253getMh2AYeg(content, i));
        }
    }
}

