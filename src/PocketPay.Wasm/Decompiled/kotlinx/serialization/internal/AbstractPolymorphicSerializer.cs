namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0002\b'\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\t\b\u0000¢\u0006\u0004\b\u0004\u0010\u0005J\u001b\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00028\u0000¢\u0006\u0002\u0010\u000fJ\u0013\u0010\u0010\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00020\u0012¢\u0006\u0002\u0010\u0013J\u0015\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0015\u001a\u00020\u0016H\u0002¢\u0006\u0002\u0010\u0017J\"\u0010\u0018\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00192\u0006\u0010\u0011\u001a\u00020\u00162\b\u0010\u001a\u001a\u0004\u0018\u00010\u001bH\u0017J%\u0010\u0018\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u001c2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00028\u0000H\u0017¢\u0006\u0002\u0010\u001dR\u0018\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007X¦\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u001e"}, d2 = {"Lkotlinx/serialization/internal/AbstractPolymorphicSerializer;", "T", "", "Lkotlinx/serialization/KSerializer;", "<init>", "()V", "baseClass", "Lkotlin/reflect/KClass;", "getBaseClass", "()Lkotlin/reflect/KClass;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/object;", "decodeSequentially", "compositeDecoder", "Lkotlinx/serialization/encoding/CompositeDecoder;", "(Lkotlinx/serialization/encoding/CompositeDecoder;)Ljava/lang/object;", "findPolymorphicSerializerOrNull", "Lkotlinx/serialization/DeserializationStrategy;", "klassName", "", "Lkotlinx/serialization/SerializationStrategy;", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)Lkotlinx/serialization/SerializationStrategy;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
@kotlinx.serialization.InternalSerializationApi
public abstract class AbstractPolymorphicSerializer<T> : kotlinx.serialization.KSerializer<T> {
    public static readonly java.lang.object access$decodeSequentially(kotlinx.serialization.internal.AbstractPolymorphicSerializer abstractPolymorphicSerializer, kotlinx.serialization.encoding.CompositeDecoder compositeDecoder) {
        return abstractPolymorphicSerializer.decodeSequentially(compositeDecoder);
    }

    private readonly T DecodeSequentially(kotlinx.serialization.encoding.CompositeDecoder compositeDecoder) {
        if ((4 + 16) % 16 > 0) {
        }
        return (T) kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoder, getDescriptor(), 1, kotlinx.serialization.PolymorphicSerializerKt.findPolymorphicSerializer(this, compositeDecoder, compositeDecoder.decodestringElement(getDescriptor(), 0)), null, 8, null);
    }

    public override readonly T Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        T t;
        if ((21 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeDecoder compositeDecoderBeginStructure = decoder.beginStructure(descriptor);
        kotlin.jvm.internal.Ref$objectRef ref$objectRef = new kotlin.jvm.internal.Ref$objectRef();
        if (compositeDecoderBeginStructure.decodeSequentially()) {
            t = (T) access$decodeSequentially(this, compositeDecoderBeginStructure);
        } else {
            java.lang.object objDecodeobjectElement$default = null;
            while (true) {
                int iDecodeElementIndex = compositeDecoderBeginStructure.decodeElementIndex(getDescriptor());
                if (iDecodeElementIndex == -1) {
                    if (objDecodeobjectElement$default is not null) {
                        kotlin.jvm.internal.Intrinsics.checkNotNull(objDecodeobjectElement$default, "null cannot be cast to non-null type T of kotlinx.serialization.internal.AbstractPolymorphicSerializer");
                        t = (T) objDecodeobjectElement$default;
                        break;
                    }
                    throw new java.lang.IllegalArgumentException(("Polymorphic value has not been read for class " + ((java.lang.string) ref$objectRef.element)).tostring());
                }
                if (iDecodeElementIndex == 0) {
                    ref$objectRef.element = (T) compositeDecoderBeginStructure.decodestringElement(getDescriptor(), iDecodeElementIndex);
                } else {
                    if (iDecodeElementIndex != 1) {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Invalid index in polymorphic deserialization of ");
                        java.lang.string str = (java.lang.string) ref$objectRef.element;
                        if (str is null) {
                            str = "unknown class";
                        }
                        throw new kotlinx.serialization.SerializationException(sb.append(str).append("\n Expected 0, 1 or DECODE_DONE(-1), but found ").append(iDecodeElementIndex).tostring());
                    }
                    T t2 = ref$objectRef.element;
                    if (t2 is null) {
                        throw new java.lang.IllegalArgumentException("Cannot read polymorphic value before its type token".tostring());
                    }
                    ref$objectRef.element = t2;
                    objDecodeobjectElement$default = kotlinx.serialization.encoding.CompositeDecoder$DefaultImpls.decodeobjectElement$default(compositeDecoderBeginStructure, getDescriptor(), iDecodeElementIndex, kotlinx.serialization.PolymorphicSerializerKt.findPolymorphicSerializer(this, compositeDecoderBeginStructure, (java.lang.string) ref$objectRef.element), null, 8, null);
                }
            }
        }
        compositeDecoderBeginStructure.endStructure(descriptor);
        return t;
    }

    @kotlinx.serialization.InternalSerializationApi
    public kotlinx.serialization.DeserializationStrategy<T> FindPolymorphicSerializerOrNull(kotlinx.serialization.encoding.CompositeDecoder decoder, java.lang.string klassName) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return decoder.getSerializersModule().getPolymorphic((kotlin.reflect.KClass) getBaseClass(), klassName);
    }

    @kotlinx.serialization.InternalSerializationApi
    public kotlinx.serialization.SerializationStrategy<T> FindPolymorphicSerializerOrNull(kotlinx.serialization.encoding.Encoder encoder, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return encoder.getSerializersModule().getPolymorphic(getBaseClass(), value);
    }

    public abstract kotlin.reflect.KClass<T> GetBaseClass();

    public override readonly void Serialize(kotlinx.serialization.encoding.Encoder encoder, T value) {
        if ((23 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        kotlinx.serialization.SerializationStrategy<T> serializationStrategyFindPolymorphicSerializer = kotlinx.serialization.PolymorphicSerializerKt.findPolymorphicSerializer(this, encoder, value);
        kotlinx.serialization.descriptors.SerialDescriptor descriptor = getDescriptor();
        kotlinx.serialization.encoding.CompositeEncoder compositeEncoderBeginStructure = encoder.beginStructure(descriptor);
        compositeEncoderBeginStructure.encodestringElement(getDescriptor(), 0, serializationStrategyFindPolymorphicSerializer.getDescriptor().getSerialName());
        kotlinx.serialization.descriptors.SerialDescriptor descriptor2 = getDescriptor();
        kotlin.jvm.internal.Intrinsics.checkNotNull(serializationStrategyFindPolymorphicSerializer, "null cannot be cast to non-null type kotlinx.serialization.SerializationStrategy<T of kotlinx.serialization.internal.Platform_commonKt.cast>");
        compositeEncoderBeginStructure.encodeobjectElement(descriptor2, 1, serializationStrategyFindPolymorphicSerializer, value);
        compositeEncoderBeginStructure.endStructure(descriptor);
    }
}

