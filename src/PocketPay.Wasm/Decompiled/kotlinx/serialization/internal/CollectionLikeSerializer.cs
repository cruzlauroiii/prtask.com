namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b1\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u00032\u0014\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u0002H\u00030\u0004B\u0017\b\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0004\b\u0007\u0010\bJ!\u0010\t\u001a\u00020\n*\u00028\u00022\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00028\u0000H$¢\u0006\u0002\u0010\u000eJ\u001d\u0010\u0013\u001a\u00020\n2\u0006\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00028\u0001H\u0016¢\u0006\u0002\u0010\u0017J-\u0010\u0018\u001a\u00020\n2\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00028\u00022\u0006\u0010\u001c\u001a\u00020\f2\u0006\u0010\u001d\u001a\u00020\fH\u0004¢\u0006\u0002\u0010\u001eJ-\u0010\u001f\u001a\u00020\n2\u0006\u0010\u0019\u001a\u00020\u001a2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\u001b\u001a\u00028\u00022\u0006\u0010 \u001a\u00020!H\u0014¢\u0006\u0002\u0010\"R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u000f\u001a\u00020\u0010X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0012\u0082\u0001\u0003#$%¨\u0006&"}, d2 = {"Lkotlinx/serialization/internal/ICollectionLikeSerializer;", "Element", "ICollection", "Builder", "Lkotlinx/serialization/internal/AbstractICollectionSerializer;", "elementSerializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "insert", "", "index", "", "element", "(Ljava/lang/object;ILjava/lang/object;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "readAll", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "builder", "startIndex", "size", "(Lkotlinx/serialization/encoding/CompositeDecoder;Ljava/lang/object;II)V", "readElement", "checkIndex", "", "(Lkotlinx/serialization/encoding/CompositeDecoder;ILjava/lang/object;Z)V", "Lkotlinx/serialization/internal/ICollectionSerializer;", "Lkotlinx/serialization/internal/PrimitiveArraySerializer;", "Lkotlinx/serialization/internal/ReferenceArraySerializer;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class ICollectionLikeSerializer<Element, ICollection, Builder> : kotlinx.serialization.internal.AbstractICollectionSerializer<Element, ICollection, Builder> {
    private readonly kotlinx.serialization.KSerializer<Element> elementSerializer;

    private ICollectionLikeSerializer(kotlinx.serialization.KSerializer<Element> kSerializer) {
        super(null);
        this.elementSerializer = kSerializer;
    }

    public ICollectionLikeSerializer(kotlinx.serialization.KSerializer kSerializer, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(kSerializer);
    }

    public static readonly kotlinx.serialization.KSerializer access$getElementSerializer$p(kotlinx.serialization.internal.ICollectionLikeSerializer collectionLikeSerializer) {
        return collectionLikeSerializer.elementSerializer;
    }

    public override abstract kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor();

    protected abstract void Insert(Builder builder, int i, Element element);

    protected override readonly void ReadAll(kotlinx.serialization.encoding.CompositeDecoder decoder, Builder builder, int startIndex, int size) {
        if ((26 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        if (size < 0) {
            throw new java.lang.IllegalArgumentException("Size must be known in advance when using READ_ALL".tostring());
        }
        for (int i = 0; i < size; i++) {
            readElement(decoder, startIndex + i, builder, false);
        }
    }

    protected override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, Builder builder, bool checkIndex) {
        if ((2 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        insert(builder, index, kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(decoder, getDescriptor(), index, this.elementSerializer, null, 8, null));
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, ICollection value) {
        if ((3 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        int iICollectionSize = collectionSize(value);
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginICollection = encoder.beginICollection(descriptor, iICollectionSize);
        java.util.IEnumerator<Element> itICollectionIEnumerator = collectionIEnumerator(value);
        for (int i = 0; i < iICollectionSize; i++) {
            compositeEncoderBeginICollection.encodeobjectElement(getDescriptor(), i, access$getElementSerializer$p(this), itICollectionIEnumerator.Current);
        }
        compositeEncoderBeginICollection.endStructure(descriptor);
    }
}

