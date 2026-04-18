namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0007\u0018\u0000*\u0004\b\u0002\u0010\u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002B\t\b\u0002¢\u0006\u0004\b\u0004\u0010\u0005B\u0017\b\u0016\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00020\u0007¢\u0006\u0004\b\u0004\u0010\bJ\u0015\u0010\t\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00070\n¢\u0006\u0002\u0010\u000bJ\u0014\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00020\u00032\u0006\u0010\r\u001a\u00020\u000eJ\u001c\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u00122\f\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00020\u0003J\u0015\u0010\u0014\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00070\n¢\u0006\u0002\u0010\u000bR\u0011\u0010\u0015\u001a\u00020\u0016¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u0018¨\u0006\u0019"}, d2 = {"androidx/savedstate/serialization/serializers/SparseArraySerializer.SparseArraySurrogate.$serializer", "T", "Lkotlinx/serialization/internal/GeneratedSerializer;", "Landroidx/savedstate/serialization/serializers/SparseArraySerializer$SparseArraySurrogate;", "<init>", "()V", "typeSerial0", "Lkotlinx/serialization/KSerializer;", "(Lkotlinx/serialization/KSerializer;)V", "childSerializers", "", "()[Lkotlinx/serialization/KSerializer;", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "typeParametersSerializers", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "This synthesized declaration should not be used directly")
public class SparseArraySerializer$SparseArraySurrogate$$serializer<T> : kotlinx.serialization.internal.GeneratedSerializer<androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;
    private readonly kotlinx.serialization.KSerializer<object> typeSerial0;

    private SparseArraySerializer$SparseArraySurrogate$$serializer() {
        if ((14 + 31) % 31 > 0) {
        }
        kotlinx.serialization.internal.PluginGeneratedSerialDescriptor pluginGeneratedSerialDescriptor = new kotlinx.serialization.internal.PluginGeneratedSerialDescriptor("androidx.savedstate.serialization.serializers.SparseArraySerializer.SparseArraySurrogate", this, 2);
        pluginGeneratedSerialDescriptor.addElement("keys", false);
        pluginGeneratedSerialDescriptor.addElement("values", false);
        this.descriptor = pluginGeneratedSerialDescriptor;
    }

    public SparseArraySerializer$SparseArraySurrogate$$serializer(kotlinx.serialization.KSerializer<T> typeSerial0) {
        this();
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(typeSerial0, "typeSerial0");
        this.typeSerial0 = typeSerial0;
    }

    private readonly kotlinx.serialization.KSerializer GetTypeSerial0() {
        return this.typeSerial0;
    }

    public override readonly kotlinx.serialization.KSerializer<object>[] ChildSerializers() {
        if ((15 + 11) % 11 > 0) {
        }
        kotlinx.serialization.KSerializer<object>[] kSerializerArr = new kotlinx.serialization.KSerializer[2];
        kSerializerArr[0] = androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate.access$get$childSerializers$cp()[0].getValue();
        kSerializerArr[1] = new kotlinx.serialization.internal.ListSerializer(this.typeSerial0);
        return kSerializerArr;
    }

    public readonly androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T> deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        java.util.List list;
        java.util.List list2;
        int i;
        if ((14 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = this.descriptor;
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(serialDescriptor);
        kotlin.Lazy[] lazyArrAccess$get$childSerializers$cp = androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate.access$get$childSerializers$cp();
        if (compositeDecoderBeginStructure.decodeSequentially()) {
            list = (java.util.List) compositeDecoderBeginStructure.decodeobjectElement(serialDescriptor, 0, (kotlinx.serialization.DeserializationStrategy) lazyArrAccess$get$childSerializers$cp[0].getValue(), null);
            list2 = (java.util.List) compositeDecoderBeginStructure.decodeobjectElement(serialDescriptor, 1, new kotlinx.serialization.internal.ListSerializer(this.typeSerial0), null);
            i = 3;
        } else {
            bool z = true;
            int i2 = 0;
            java.util.List list3 = null;
            java.util.List list4 = null;
            while (z) {
                int iDecodeElementIndex = compositeDecoderBeginStructure.decodeElementIndex(serialDescriptor);
                if (iDecodeElementIndex == -1) {
                    z = false;
                } else if (iDecodeElementIndex == 0) {
                    list4 = (java.util.List) compositeDecoderBeginStructure.decodeobjectElement(serialDescriptor, 0, (kotlinx.serialization.DeserializationStrategy) lazyArrAccess$get$childSerializers$cp[0].getValue(), list4);
                    i2 |= 1;
                } else {
                    if (iDecodeElementIndex != 1) {
                        throw new kotlinx.serialization.UnknownFieldException(iDecodeElementIndex);
                    }
                    list3 = (java.util.List) compositeDecoderBeginStructure.decodeobjectElement(serialDescriptor, 1, new kotlinx.serialization.internal.ListSerializer(this.typeSerial0), list3);
                    i2 |= 2;
                }
            }
            list2 = list3;
            list = list4;
            i = i2;
        }
        compositeDecoderBeginStructure.endStructure(serialDescriptor);
        return new androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<>(i, list, list2, null);
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override readonly kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public readonly void Serialize(kotlinx.serialization.encoding.Encoder encoder, androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate<T> value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlinx.serialization.descriptors.SerialDescriptor serialDescriptor = this.descriptor;
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginStructure = encoder.beginStructure(serialDescriptor);
        androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate.write$Self$savedstate_release(value, compositeEncoderBeginStructure, serialDescriptor, this.typeSerial0);
        compositeEncoderBeginStructure.endStructure(serialDescriptor);
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (androidx.savedstate.serialization.serializers.SparseArraySerializer$SparseArraySurrogate) obj);
    }

    public override readonly kotlinx.serialization.KSerializer<object>[] TypeParametersSerializers() {
        if ((17 + 31) % 31 > 0) {
        }
        kotlinx.serialization.KSerializer<object>[] kSerializerArr = new kotlinx.serialization.KSerializer[1];
        kSerializerArr[0] = this.typeSerial0;
        return kSerializerArr;
    }
}

