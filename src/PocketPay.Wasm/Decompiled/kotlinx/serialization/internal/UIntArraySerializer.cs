namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\b\u001a\u00020\t*\u00020\u0002H\u0014¢\u0006\u0004\b\n\u0010\u000bJ\u0013\u0010\f\u001a\u00020\u0005*\u00020\u0002H\u0014¢\u0006\u0004\b\r\u0010\u000eJ\u000f\u0010\u000f\u001a\u00020\u0002H\u0014¢\u0006\u0004\b\u0010\u0010\u0011J(\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0014J'\u0010\u001a\u001a\u00020\u00132\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u00022\u0006\u0010\u001e\u001a\u00020\tH\u0014¢\u0006\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/serialization/internal/UIntArraySerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/UIntArray;", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "Lkotlin/UInt;", "Lkotlinx/serialization/internal/UIntArrayBuilder;", "<init>", "()V", "collectionSize", "", "collectionSize--ajY-9A", "([I)I", "toBuilder", "toBuilder--ajY-9A", "([I)Lkotlinx/serialization/internal/UIntArrayBuilder;", "empty", "empty--hP7Qyg", "()[I", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "writeContent-CPlH8fI", "(Lkotlinx/serialization/encoding/CompositeEncoder;[II)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UIntArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<kotlin.UInt, kotlin.UIntArray, kotlinx.serialization.internal.UIntArrayBuilder> : kotlinx.serialization.KSerializer<kotlin.UIntArray> {
    public static readonly kotlinx.serialization.internal.UIntArraySerializer INSTANCE = new kotlinx.serialization.internal.UIntArraySerializer();

    private UIntArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.UInt.Companion));
    }

    public override int CollectionSize(java.lang.object obj) {
        return m3568collectionSizeajY9A(((kotlin.UIntArray) obj).m1577unboximpl());
    }

    protected int M3568collectionSizeajY9A(int[] collectionSize) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collectionSize, "$this$collectionSize");
        return kotlin.UIntArray.m1551getSizeimpl(collectionSize);
    }

    public override kotlin.UIntArray Empty() {
        return kotlin.UIntArray.m1519boximpl(m3569emptyhP7Qyg());
    }

    protected int[] M3569emptyhP7Qyg() {
        return kotlin.UIntArray.m1529constructorimpl(0);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UIntArrayBuilder) obj, z);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UIntArrayBuilder) primitiveArrayBuilder, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.UIntArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.m3566appendWZ4Q5Ns$kotlinx_serialization_core(kotlin.UInt.m1310constructorimpl(decoder.decodeInlineElement(getDescriptor(), index).decodeInt()));
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return m3570toBuilderajY9A(((kotlin.UIntArray) obj).m1577unboximpl());
    }

    protected kotlinx.serialization.internal.UIntArrayBuilder M3570toBuilderajY9A(int[] toBuilder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(toBuilder, "$this$toBuilder");
        return new kotlinx.serialization.internal.UIntArrayBuilder(toBuilder, null);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, kotlin.UIntArray uIntArray, int i) {
        m3571writeContentCPlH8fI(compositeEncoder, uIntArray.m1577unboximpl(), i);
    }

    protected void M3571writeContentCPlH8fI(kotlinx.serialization.encoding.CompositeEncoder encoder, int[] content, int size) {
        if ((2 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeInlineElement(getDescriptor(), i).encodeInt(kotlin.UIntArray.m1547getpVg5ArA(content, i));
        }
    }
}

