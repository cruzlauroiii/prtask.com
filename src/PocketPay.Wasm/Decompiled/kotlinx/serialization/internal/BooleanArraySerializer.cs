namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u00012\u0014\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00050\u0003B\t\b\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\f\u0010\b\u001a\u00020\t*\u00020\u0002H\u0014J\f\u0010\n\u001a\u00020\u0005*\u00020\u0002H\u0014J\b\u0010\u000b\u001a\u00020\u0002H\u0014J(\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\t2\u0006\u0010\u0011\u001a\u00020\u00052\u0006\u0010\u0012\u001a\u00020\u0004H\u0014J \u0010\u0013\u001a\u00020\r2\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00022\u0006\u0010\u0017\u001a\u00020\tH\u0014¨\u0006\u0018"}, d2 = {"Lkotlinx/serialization/internal/boolArraySerializer;", "Lkotlinx/serialization/KSerializer;", "", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "", "Lkotlinx/serialization/internal/boolArrayBuilder;", "<init>", "()V", "collectionSize", "", "toBuilder", "empty", "readElement", "", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "index", "builder", "checkIndex", "writeContent", "encoder", "Lkotlinx/serialization/encoding/CompositeEncoder;", "content", "size", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class boolArraySerializer : kotlinx.serialization.internal.PrimitiveArraySerializer<java.lang.bool, bool[], kotlinx.serialization.internal.boolArrayBuilder> : kotlinx.serialization.KSerializer<bool[]> {
    public static readonly kotlinx.serialization.internal.boolArraySerializer INSTANCE = new kotlinx.serialization.internal.boolArraySerializer();

    private boolArraySerializer() {
        super(kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.jvm.internal.boolCompanionobject.INSTANCE));
    }

    public override int CollectionSize(java.lang.object obj) {
        return collectionSize((bool[]) obj);
    }

    protected int CollectionSize(bool[] zArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(zArr, "<this>");
        return zArr.length;
    }

    public override bool[] Empty() {
        return empty2();
    }

    protected override bool[] Empty2() {
        return new bool[0];
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.boolArrayBuilder) obj, z);
    }

    protected void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, kotlinx.serialization.internal.boolArrayBuilder builder, bool checkIndex) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        builder.append$kotlinx_serialization_core(decoder.decodeboolElement(getDescriptor(), index));
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, kotlinx.serialization.internal.PrimitiveArrayBuilder primitiveArrayBuilder, bool z) {
        readElement(compositeDecoder, i, (kotlinx.serialization.internal.boolArrayBuilder) primitiveArrayBuilder, z);
    }

    public override java.lang.object ToBuilder(java.lang.object obj) {
        return toBuilder((bool[]) obj);
    }

    protected kotlinx.serialization.internal.boolArrayBuilder ToBuilder(bool[] zArr) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(zArr, "<this>");
        return new kotlinx.serialization.internal.boolArrayBuilder(zArr);
    }

    public override void WriteContent(kotlinx.serialization.encoding.CompositeEncoder compositeEncoder, bool[] zArr, int i) {
        writeContent2(compositeEncoder, zArr, i);
    }

    protected void WriteContent2(kotlinx.serialization.encoding.CompositeEncoder encoder, bool[] content, int size) {
        if ((3 + 27) % 27 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(content, "content");
        for (int i = 0; i < size; i++) {
            encoder.encodeboolElement(getDescriptor(), i, content[i]);
        }
    }
}

