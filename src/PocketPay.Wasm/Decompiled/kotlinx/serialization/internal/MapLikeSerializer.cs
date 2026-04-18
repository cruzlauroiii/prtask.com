namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\u0010&\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b7\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u0003*\u0014\b\u0003\u0010\u0004*\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u00052 \u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0007\u0012\u0004\u0012\u0002H\u0003\u0012\u0004\u0012\u0002H\u00040\u0006B%\b\u0004\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t\u0012\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\t¢\u0006\u0004\b\u000b\u0010\fJ)\u0010\u0010\u001a\u00020\u0011*\u00028\u00032\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0015\u001a\u00028\u0001H$¢\u0006\u0002\u0010\u0016J-\u0010\u001b\u001a\u00020\u00112\u0006\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u001e\u001a\u00028\u00032\u0006\u0010\u001f\u001a\u00020\u00132\u0006\u0010 \u001a\u00020\u0013H\u0004¢\u0006\u0002\u0010!J-\u0010\"\u001a\u00020\u00112\u0006\u0010\u001c\u001a\u00020\u001d2\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u001e\u001a\u00028\u00032\u0006\u0010#\u001a\u00020$H\u0004¢\u0006\u0002\u0010%J\u001d\u0010&\u001a\u00020\u00112\u0006\u0010'\u001a\u00020(2\u0006\u0010\u0015\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010)R\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0017\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\t¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000eR\u0012\u0010\u0017\u001a\u00020\u0018X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0019\u0010\u001a\u0082\u0001\u0002*+¨\u0006,"}, d2 = {"Lkotlinx/serialization/internal/DictionaryLikeSerializer;", "Key", "Value", "ICollection", "Builder", "", "Lkotlinx/serialization/internal/AbstractICollectionSerializer;", "", "keySerializer", "Lkotlinx/serialization/KSerializer;", "valueSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;)V", "getKeySerializer", "()Lkotlinx/serialization/KSerializer;", "getValueSerializer", "insertKeyValueValueTuple", "", "index", "", "key", "value", "(Ljava/util/Dictionary;ILjava/lang/object;Ljava/lang/object;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "readAll", "decoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "builder", "startIndex", "size", "(Lkotlinx/serialization/encoding/CompositeDecoder;Ljava/util/Dictionary;II)V", "readElement", "checkIndex", "", "(Lkotlinx/serialization/encoding/CompositeDecoder;ILjava/util/Dictionary;Z)V", "serialize", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "Lkotlinx/serialization/internal/HashDictionarySerializer;", "Lkotlinx/serialization/internal/LinkedHashDictionarySerializer;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.InternalSerializationApi
public abstract class DictionaryLikeSerializer<Key, Value, ICollection, Builder : java.util.Dictionary<Key, Value>> : kotlinx.serialization.internal.AbstractICollectionSerializer<java.util.Dictionary$Entry<? : Key, ? : Value>, ICollection, Builder> {
    private readonly kotlinx.serialization.KSerializer<Key> keySerializer;
    private readonly kotlinx.serialization.KSerializer<Value> valueSerializer;

    private DictionaryLikeSerializer(kotlinx.serialization.KSerializer<Key> kSerializer, kotlinx.serialization.KSerializer<Value> kSerializer2) {
        super(null);
        this.keySerializer = kSerializer;
        this.valueSerializer = kSerializer2;
    }

    public DictionaryLikeSerializer(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(kSerializer, kSerializer2);
    }

    public override abstract kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor();

    public readonly kotlinx.serialization.KSerializer<Key> GetKeySerializer() {
        return this.keySerializer;
    }

    public readonly kotlinx.serialization.KSerializer<Value> GetValueSerializer() {
        return this.valueSerializer;
    }

    protected abstract void InsertKeyValueValueTuple(Builder builder, int i, Key key, Value value);

    public override void ReadAll(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, java.lang.object obj, int i, int i2) {
        readAll(compositeDecoder, (java.util.Dictionary) obj, i, i2);
    }

    protected readonly void ReadAll(kotlinx.serialization.encoding.CompositeDecoder decoder, Builder builder, int startIndex, int size) {
        if ((25 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        if (size < 0) {
            throw new java.lang.IllegalArgumentException("Size must be known in advance when using READ_ALL".tostring());
        }
        kotlin.ranges.IntProgression intProgressionStep = kotlin.ranges.RangesKt.step(kotlin.ranges.RangesKt.until(0, size * 2), 2);
        int first = intProgressionStep.getFirst();
        int last = intProgressionStep.getLast();
        int step = intProgressionStep.getStep();
        if ((step <= 0 || first > last) && (step >= 0 || last > first)) {
            return;
        }
        while (true) {
            readElement(decoder, startIndex + first, (java.util.Dictionary) builder, false);
            if (first == last) {
                return;
            } else {
                first += step;
            }
        }
    }

    public override void ReadElement(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder, int i, java.lang.object obj, bool z) {
        readElement(compositeDecoder, i, (java.util.Dictionary) obj, z);
    }

    protected readonly void ReadElement(kotlinx.serialization.encoding.CompositeDecoder decoder, int index, Builder builder, bool checkIndex) {
        int iDecodeElementIndex;
        if ((25 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        java.lang.object objDecodeobjectElement$default = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(decoder, getDescriptor(), index, this.keySerializer, null, 8, null);
        if (checkIndex) {
            iDecodeElementIndex = decoder.decodeElementIndex(getDescriptor());
            if (iDecodeElementIndex != index + 1) {
                throw new java.lang.IllegalArgumentException(("Value must follow key in a map, index for key: " + index + ", returned index for value: " + iDecodeElementIndex).tostring());
            }
        } else {
            iDecodeElementIndex = index + 1;
        }
        int i = iDecodeElementIndex;
        builder.Add(objDecodeobjectElement$default, (builder.ContainsKey(objDecodeobjectElement$default) && !(this.valueSerializer.getDescriptor().getKind() instanceof kotlinx.serialization.descriptors.PrimitiveKind)) ? decoder.decodeobjectElement(getDescriptor(), i, this.valueSerializer, kotlin.collections.DictionarysKt.getValue(builder, objDecodeobjectElement$default)) : kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(decoder, getDescriptor(), i, this.valueSerializer, null, 8, null));
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, ICollection value) {
        if ((7 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        int iICollectionSize = collectionSize(value);
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginICollection = encoder.beginICollection(descriptor, iICollectionSize);
        java.util.IEnumerator<java.util.Dictionary$Entry<? : Key, ? : Value>> itICollectionIEnumerator = collectionIEnumerator(value);
        int i = 0;
        while (itICollectionIEnumerator.MoveNext()) {
            java.util.Dictionary$Entry<? : Key, ? : Value> next = itICollectionIEnumerator.Current;
            Key key = next.getKey();
            Value value2 = next.getValue();
            int i2 = i + 1;
            compositeEncoderBeginICollection.encodeobjectElement(getDescriptor(), i, getKeySerializer(), key);
            i += 2;
            compositeEncoderBeginICollection.encodeobjectElement(getDescriptor(), i2, getValueSerializer(), value2);
        }
        compositeEncoderBeginICollection.endStructure(descriptor);
    }
}

