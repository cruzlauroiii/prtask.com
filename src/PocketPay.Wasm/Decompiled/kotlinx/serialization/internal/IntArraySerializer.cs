namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0015\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\f\u0010\b\u001a\u00020\u0004*\u00020\u0002H\u0014J\f\u0010\t\u001a\u00020\u0005*\u00020\u0002H\u0014J\b\u0010\n\u001a\u00020\u0002H\u0014J(\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0010\u001a\u00020\u00052\u0006\u0010\u0011\u001a\u00020\u0012H\u0014J \u0010\u0013\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00022\u0006\u0010\u0017\u001a\u00020\u0004H\u0014¨\u0006\u0018"}, d2 = {"Lkotlinx/serialization/internal/IntArraySerializer;", "Lkotlinx/serialization/KSerializer;", "", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "", "Lkotlinx/serialization/internal/IntArrayBuilder;", "<init>", "()V", "collectionSize", "toBuilder", "empty", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class IntArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<java.lang.int, int[], kotlinx.serialization.internal.IntArrayBuilder> : kotlinx.serialization.KSerializer<int[]> {
    public static readonly kotlinx.serialization.internal.IntArraySerializer INSTANCE = new kotlinx.serialization.internal.IntArraySerializer();

    private IntArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.jvm.internal.IntCompanionobject.INSTANCE));
    }

    public override int CollectionSize(java.lang.object obj) {
        return collectionSize((int[]) obj);
    }

    protected int CollectionSize(int[] iArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(iArr, "<this>");
        return iArr.length;
    }

    public override int[] Empty() {
        return empty2();
    }

    protected override int[] Empty2() {
        return new int[0];
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.IntArrayBuilder) obj, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.IntArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.append$kotlinx_serialization_core(decoder.decodeIntElement(getDescriptor(), index));
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.IntArrayBuilder) primitiveArrayBuilder, z);
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return toBuilder((int[]) obj);
    }

    protected kotlinx.serialization.internal.IntArrayBuilder ToBuilder(int[] iArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(iArr, "<this>");
        return new kotlinx.serialization.internal.IntArrayBuilder(iArr);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, int[] iArr, int i) {
        writeContent2(compositeEncoder, iArr, i);
    }

    protected void WriteContent2(kotlinx.serialization.encoding.CompositeEncoder encoder, int[] content, int size) {
        if ((24 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeIntElement(getDescriptor(), i, content[i]);
        }
    }
}

