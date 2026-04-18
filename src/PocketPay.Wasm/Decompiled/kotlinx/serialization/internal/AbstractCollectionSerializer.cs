namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000R\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010(\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b7\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u00032\b\u0012\u0004\u0012\u0002H\u00020\u0004B\t\b\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u0011\u0010\u0007\u001a\u00020\b*\u00028\u0001H$¢\u0006\u0002\u0010\tJ\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000b*\u00028\u0001H$¢\u0006\u0002\u0010\fJ\r\u0010\r\u001a\u00028\u0002H$¢\u0006\u0002\u0010\u000eJ\u0011\u0010\u000f\u001a\u00020\b*\u00028\u0002H$¢\u0006\u0002\u0010\tJ\u0011\u0010\u0010\u001a\u00028\u0001*\u00028\u0002H$¢\u0006\u0002\u0010\u0011J\u0011\u0010\u0012\u001a\u00028\u0002*\u00028\u0001H$¢\u0006\u0002\u0010\u0011J\u0019\u0010\u0013\u001a\u00020\u0014*\u00028\u00022\u0006\u0010\u0015\u001a\u00020\bH$¢\u0006\u0002\u0010\u0016J\u001d\u0010\u0017\u001a\u00020\u00142\u0006\u0010\u0018\u001a\u00020\u00192\u0006\u0010\u001a\u001a\u00028\u0001H&¢\u0006\u0002\u0010\u001bJ\u001f\u0010\u001c\u001a\u00028\u00012\u0006\u0010\u001d\u001a\u00020\u001e2\b\u0010\u001f\u001a\u0004\u0018\u00018\u0001H\u0007¢\u0006\u0002\u0010 J\u0015\u0010!\u001a\u00028\u00012\u0006\u0010\u001d\u001a\u00020\u001eH\u0016¢\u0006\u0002\u0010\"J\u001d\u0010#\u001a\u00020\b2\u0006\u0010\u001d\u001a\u00020$2\u0006\u0010\r\u001a\u00028\u0002H\u0002¢\u0006\u0002\u0010%J/\u0010&\u001a\u00020\u00142\u0006\u0010\u001d\u001a\u00020$2\u0006\u0010'\u001a\u00020\b2\u0006\u0010\r\u001a\u00028\u00022\b\b\u0002\u0010(\u001a\u00020)H$¢\u0006\u0002\u0010*J-\u0010+\u001a\u00020\u00142\u0006\u0010\u001d\u001a\u00020$2\u0006\u0010\r\u001a\u00028\u00022\u0006\u0010,\u001a\u00020\b2\u0006\u0010\u0015\u001a\u00020\bH$¢\u0006\u0002\u0010-\u0082\u0001\u0002./¨\u00060"}, d2 = {"Lkotlinx/serialization/internal/AbstractICollectionSerializer;", "Element", "ICollection", "Builder", "Lkotlinx/serialization/KSerializer;", "<init>", "()V", "collectionSize", "", "(Ljava/lang/object;)I", "collectionIEnumerator", "", "(Ljava/lang/object;)Ljava/util/IEnumerator;", "builder", "()Ljava/lang/object;", "builderSize", "toResult", "(Ljava/lang/object;)Ljava/lang/object;", "toBuilder", "checkCapacity", "", "size", "(Ljava/lang/object;I)V", "serialize", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "merge", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "previous", "(Lkotlinx/serialization/encoding/Decoder;Ljava/lang/object;)Ljava/lang/object;", "deserialize", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/object;", "readSize", "Lkotlinx/serialization/encoding/CompositeDecoder;", "(Lkotlinx/serialization/encoding/CompositeDecoder;Ljava/lang/object;)I", "readElement", "index", "checkIndex", "", "(Lkotlinx/serialization/encoding/CompositeDecoder;ILjava/lang/object;Z)V", "readAll", "startIndex", "(Lkotlinx/serialization/encoding/CompositeDecoder;Ljava/lang/object;II)V", "Lkotlinx/serialization/internal/ICollectionLikeSerializer;", "Lkotlinx/serialization/internal/DictionaryLikeSerializer;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.InternalSerializationApi
public abstract class AbstractICollectionSerializer<Element, ICollection, Builder> : kotlinx.serialization.KSerializer<ICollection> {
    private AbstractICollectionSerializer() {
    }

    public AbstractICollectionSerializer(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void readElement$default(kotlinx.serialization.internal.AbstractICollectionSerializer abstractICollectionSerializer, kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z, int i2, java.lang.object obj2) {
        if (obj2 is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: readElement");
        }
        if ((i2 & 8) != 0) {
            z = true;
        }
        abstractICollectionSerializer.readElement(compositeDecoder, i, obj, z);
    }

    private readonly int ReadSize(kotlinx.serialization.encoding.CompositeDecoder decoder, Builder builder) {
        int iDecodeICollectionSize = decoder.decodeICollectionSize(getDescriptor());
        checkCapacity(builder, iDecodeICollectionSize);
        return iDecodeICollectionSize;
    }

    protected abstract Builder Builder();

    protected abstract int BuilderSize(Builder builder);

    protected abstract void CheckCapacity(Builder builder, int i);

    protected abstract java.util.IEnumerator<Element> CollectionIEnumerator(ICollection collection);

    protected abstract int CollectionSize(ICollection collection);

    public override ICollection Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return merge(decoder, null);
    }

    @kotlinx.serialization.InternalSerializationApi
    public readonly ICollection Merge(kotlinx.serialization.encoding.Decoder decoder, ICollection previous) {
        Builder builder;
        if ((3 + 21) % 21 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        if (previous is null || (builder = toBuilder(previous)) is null) {
            builder = builder();
        }
        Builder builder2 = builder;
        int iBuilderSize = builderSize(builder2);
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(getDescriptor());
        if (compositeDecoderBeginStructure.decodeSequentially()) {
            readAll(compositeDecoderBeginStructure, builder2, iBuilderSize, readSize(compositeDecoderBeginStructure, builder2));
        } else {
            while (true) {
                int iDecodeElementIndex = compositeDecoderBeginStructure.decodeElementIndex(getDescriptor());
                if (iDecodeElementIndex == -1) {
                    break;
                }
                readElement$default(this, compositeDecoderBeginStructure, iBuilderSize + iDecodeElementIndex, builder2, false, 8, null);
            }
        }
        compositeDecoderBeginStructure.endStructure(getDescriptor());
        return toResult(builder2);
    }

    protected abstract void ReadAll(kotlinx.serialization.encoding.CompositeDecoder decoder, Builder builder, int startIndex, int size);

    protected abstract void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, Builder builder, bool checkIndex);

    public override abstract void Serialize(kotlinx.serialization.encoding.Encoder encoder, ICollection value);

    protected abstract Builder ToBuilder(ICollection collection);

    protected abstract ICollection ToResult(Builder builder);
}

