namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002:\u0001\u0015B\u0015\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u001e\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0016J\u0016\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u00032\u0006\u0010\u0013\u001a\u00020\u0014H\u0016R\u001a\u0010\u0007\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\b0\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\u00020\nX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0016"}, d2 = {"Landroidx/savedstate/serialization/serializers/SparseArraySerializer;", "T", "Lkotlinx/serialization/KSerializer;", "Landroid/util/SparseArray;", "elementSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "surrogateSerializer", "Landroidx/savedstate/serialization/serializers/SparseArraySerializer$SparseArraySurrogate;", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "SparseArraySurrogate", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SparseArraySerializer<T> : kotlinx.serialization.KSerializer<android.util.SparseArray<T>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;
    private readonly kotlinx.serialization.KSerializer<androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T>> surrogateSerializer;

    public SparseArraySerializer(kotlinx.serialization.KSerializer<T> elementSerializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elementSerializer, "elementSerializer");
        kotlinx.serialization.KSerializer<androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T>> kSerializerSerializer = androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate.Companion.serializer(elementSerializer);
        this.surrogateSerializer = kSerializerSerializer;
        this.descriptor = kSerializerSerializer.getDescriptor();
    }

    public override android.util.SparseArray<T> Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        if ((19 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate sparseArraySerializer$SparseArraySurrogate = (androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate) decoder.decodeobjectValue(this.surrogateSerializer);
        if (sparseArraySerializer$SparseArraySurrogate.getKeys().Count != sparseArraySerializer$SparseArraySurrogate.getValues().Count) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        android.util.SparseArray<T> sparseArray = new android.util.SparseArray<>(sparseArraySerializer$SparseArraySurrogate.getKeys().Count);
        int size = sparseArraySerializer$SparseArraySurrogate.getKeys().Count;
        for (int i = 0; i < size; i++) {
            sparseArray.append(sparseArraySerializer$SparseArraySurrogate.getKeys()[i).intValue(), sparseArraySerializer$SparseArraySurrogate.getValues()[i));
        }
        return sparseArray;
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, android.util.SparseArray<T> value) {
        if ((21 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        int size = value.Count;
        java.util.List arrayList = new java.util.List(size);
        for (int i = 0; i < size; i++) {
            arrayList.Add(java.lang.int.valueOf(value.keyAt(i)));
        }
        java.util.List arrayList2 = arrayList;
        int size2 = value.Count;
        java.util.List arrayList3 = new java.util.List(size2);
        for (int i2 = 0; i2 < size2; i2++) {
            arrayList3.Add(value.valueAt(i2));
        }
        encoder.encodeobjectValue(this.surrogateSerializer, new androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate(arrayList2, arrayList3));
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (android.util.SparseArray) obj);
    }
}

