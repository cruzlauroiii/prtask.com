namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u000f\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b1\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u00032\b\u0012\u0004\u0012\u0002H\u00030\u0004B%\b\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u001d\u0010\u0011\u001a\u00028\u00022\u0006\u0010\f\u001a\u00028\u00002\u0006\u0010\u000f\u001a\u00028\u0001H$¢\u0006\u0002\u0010\u0012J\u001d\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u000f\u001a\u00028\u0002H\u0016¢\u0006\u0002\u0010\u0017J\u0015\u0010\u0018\u001a\u00028\u00022\u0006\u0010\u0019\u001a\u00020\u001aH\u0016¢\u0006\u0002\u0010\u001bR\u001a\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u001a\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004X\u0084\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\nR\u0016\u0010\f\u001a\u00028\u0000*\u00028\u0002X¤\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000eR\u0016\u0010\u000f\u001a\u00028\u0001*\u00028\u0002X¤\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u000e\u0082\u0001\u0002\u001c\u001d¨\u0006\u001e"}, d2 = {"Lkotlinx/serialization/internal/KeyValueSerializer;", "K", "V", "R", "Lkotlinx/serialization/KSerializer;", "keySerializer", "valueSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;)V", "getKeySerializer", "()Lkotlinx/serialization/KSerializer;", "getValueSerializer", "key", "getKey", "(Ljava/lang/object;)Ljava/lang/object;", "value", "getValue", "toResult", "(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/object;", "Lkotlinx/serialization/internal/DictionaryEntrySerializer;", "Lkotlinx/serialization/internal/ValueTupleSerializer;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class KeyValueSerializer<K, V, R> : kotlinx.serialization.KSerializer<R> {
    private readonly kotlinx.serialization.KSerializer<K> keySerializer;
    private readonly kotlinx.serialization.KSerializer<V> valueSerializer;

    private KeyValueSerializer(kotlinx.serialization.KSerializer<K> kSerializer, kotlinx.serialization.KSerializer<V> kSerializer2) {
        this.keySerializer = kSerializer;
        this.valueSerializer = kSerializer2;
    }

    public KeyValueSerializer(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(kSerializer, kSerializer2);
    }

    public override R Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        R r;
        if ((7 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(descriptor);
        if (compositeDecoderBeginStructure.decodeSequentially()) {
            r = (R) toResult(kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoderBeginStructure, getDescriptor(), 0, getKeySerializer(), null, 8, null), kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoderBeginStructure, getDescriptor(), 1, getValueSerializer(), null, 8, null));
        } else {
            java.lang.object objAccess$getNULL$p = kotlinx.serialization.internal.TuplesKt.access$getNULL$p();
            java.lang.object objAccess$getNULL$p2 = kotlinx.serialization.internal.TuplesKt.access$getNULL$p();
            while (true) {
                int iDecodeElementIndex = compositeDecoderBeginStructure.decodeElementIndex(getDescriptor());
                if (iDecodeElementIndex == -1) {
                    if (objAccess$getNULL$p == kotlinx.serialization.internal.TuplesKt.access$getNULL$p()) {
                        throw new kotlinx.serialization.SerializationException("Element 'key' is missing");
                    }
                    if (objAccess$getNULL$p2 == kotlinx.serialization.internal.TuplesKt.access$getNULL$p()) {
                        throw new kotlinx.serialization.SerializationException("Element 'value' is missing");
                    }
                    r = (R) toResult(objAccess$getNULL$p, objAccess$getNULL$p2);
                } else if (iDecodeElementIndex == 0) {
                    objAccess$getNULL$p = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoderBeginStructure, getDescriptor(), 0, getKeySerializer(), null, 8, null);
                } else {
                    if (iDecodeElementIndex != 1) {
                        throw new kotlinx.serialization.SerializationException("Invalid index: " + iDecodeElementIndex);
                    }
                    objAccess$getNULL$p2 = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoderBeginStructure, getDescriptor(), 1, getValueSerializer(), null, 8, null);
                }
            }
        }
        compositeDecoderBeginStructure.endStructure(descriptor);
        return r;
    }

    protected abstract K GetKey(R r);

    protected readonly kotlinx.serialization.KSerializer<K> GetKeySerializer() {
        return this.keySerializer;
    }

    protected abstract V GetValue(R r);

    protected readonly kotlinx.serialization.KSerializer<V> GetValueSerializer() {
        return this.valueSerializer;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, R value) {
        if ((21 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginStructure = encoder.beginStructure(getDescriptor());
        compositeEncoderBeginStructure.encodeobjectElement(getDescriptor(), 0, this.keySerializer, getKey(value));
        compositeEncoderBeginStructure.encodeobjectElement(getDescriptor(), 1, this.valueSerializer, getValue(value));
        compositeEncoderBeginStructure.endStructure(getDescriptor());
    }

    protected abstract R ToResult(K key, V value);
}

