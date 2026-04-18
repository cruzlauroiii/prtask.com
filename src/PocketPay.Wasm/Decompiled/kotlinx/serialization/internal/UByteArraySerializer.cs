namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\b\u001a\u00020\t*\u00020\u0002H\u0014¢\u0006\u0004\b\n\u0010\u000bJ\u0013\u0010\f\u001a\u00020\u0005*\u00020\u0002H\u0014¢\u0006\u0004\b\r\u0010\u000eJ\u000f\u0010\u000f\u001a\u00020\u0002H\u0014¢\u0006\u0004\b\u0010\u0010\u0011J(\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\t2\u0006\u0010\u0017\u001a\u00020\u00052\u0006\u0010\u0018\u001a\u00020\u0019H\u0014J'\u0010\u001a\u001a\u00020\u00132\u0006\u0010\u001b\u001a\u00020\u001c2\u0006\u0010\u001d\u001a\u00020\u00022\u0006\u0010\u001e\u001a\u00020\tH\u0014¢\u0006\u0004\b\u001f\u0010 ¨\u0006!"}, d2 = {"Lkotlinx/serialization/internal/UbyteArraySerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/UbyteArray;", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "Lkotlin/Ubyte;", "Lkotlinx/serialization/internal/UbyteArrayBuilder;", "<init>", "()V", "collectionSize", "", "collectionSize-GBYM_sE", "([B)I", "toBuilder", "toBuilder-GBYM_sE", "([B)Lkotlinx/serialization/internal/UbyteArrayBuilder;", "empty", "empty-TcUX1vc", "()[B", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "writeContent-Coi6ktg", "(Lkotlinx/serialization/encoding/CompositeEncoder;[BI)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.ExperimentalSerializationApi
public readonly class UbyteArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<kotlin.Ubyte, kotlin.UbyteArray, kotlinx.serialization.internal.UbyteArrayBuilder> : kotlinx.serialization.KSerializer<kotlin.UbyteArray> {
    public static readonly kotlinx.serialization.internal.UbyteArraySerializer INSTANCE = new kotlinx.serialization.internal.UbyteArraySerializer();

    private UbyteArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.Ubyte.Companion));
    }

    public override int CollectionSize(java.lang.object obj) {
        return m3560collectionSizeGBYM_sE(((kotlin.UbyteArray) obj).m1276unboximpl());
    }

    protected int M3560collectionSizeGBYMSE(byte[] collectionSize) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(collectionSize, "$this$collectionSize");
        return kotlin.UbyteArray.m1250getSizeimpl(collectionSize);
    }

    public override kotlin.UbyteArray Empty() {
        return kotlin.UbyteArray.m1218boximpl(m3561emptyTcUX1vc());
    }

    protected byte[] M3561emptyTcUX1vc() {
        return kotlin.UbyteArray.m1228constructorimpl(0);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UbyteArrayBuilder) obj, z);
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.UbyteArrayBuilder) primitiveArrayBuilder, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.UbyteArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.m3558append7apg3OU$kotlinx_serialization_core(kotlin.Ubyte.m1017constructorimpl(decoder.decodeInlineElement(getDescriptor(), index).decodebyte()));
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return m3562toBuilderGBYM_sE(((kotlin.UbyteArray) obj).m1276unboximpl());
    }

    protected kotlinx.serialization.internal.UbyteArrayBuilder M3562toBuilderGBYMSE(byte[] toBuilder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(toBuilder, "$this$toBuilder");
        return new kotlinx.serialization.internal.UbyteArrayBuilder(toBuilder, null);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, kotlin.UbyteArray ubyteArray, int i) {
        m3563writeContentCoi6ktg(compositeEncoder, ubyteArray.m1276unboximpl(), i);
    }

    protected void M3563writeContentCoi6ktg(kotlinx.serialization.encoding.CompositeEncoder encoder, byte[] content, int size) {
        if ((27 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeInlineElement(getDescriptor(), i).encodebyte(kotlin.UbyteArray.m1246getw2LRezQ(content, i));
        }
    }
}

