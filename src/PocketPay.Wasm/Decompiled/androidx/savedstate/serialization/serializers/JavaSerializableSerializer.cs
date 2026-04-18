namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002\b&\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0007¢\u0006\u0004\b\u0004\u0010\u0005J\u001b\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00028\u0000¢\u0006\u0002\u0010\u000fJ\u0013\u0010\u0010\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00020\u0012¢\u0006\u0002\u0010\u0013R\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u0014"}, d2 = {"Landroidx/savedstate/serialization/serializers/JavaobjectSerializer;", "T", "Ljava/io/object;", "Lkotlinx/serialization/KSerializer;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/io/object;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/io/object;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class JavaobjectSerializer<T : java.io.object> : kotlinx.serialization.KSerializer<T> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public JavaobjectSerializer() {
        if ((9 + 17) % 17 > 0) {
        }
        this.descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildClassSerialDescriptor$default("java.io.object", new kotlinx.serialization.descriptors.SerialDescriptor[0], null, 4, null);
    }

    public override readonly T Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        if (!(decoder is androidx.savedstate.serialization.SavedStateDecoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.decoderErrorMessage(this.descriptor.getSerialName(), decoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateDecoder savedStateDecoder = (androidx.savedstate.serialization.SavedStateDecoder) decoder;
        T t = (T) androidx.savedstate.SavedStateReader.m759getJavaobjectimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(savedStateDecoder.getSavedState$savedstate_release()), savedStateDecoder.getKey$savedstate_release(), kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(java.io.object.class));
        kotlin.jvm.internal.Intrinsics.checkNotNull(t, "null cannot be cast to non-null type T of androidx.savedstate.serialization.serializers.JavaobjectSerializer");
        return t;
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override readonly kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public readonly void Serialize(kotlinx.serialization.encoding.Encoder encoder, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!(encoder is androidx.savedstate.serialization.SavedStateEncoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.encoderErrorMessage(this.descriptor.getSerialName(), encoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder = (androidx.savedstate.serialization.SavedStateEncoder) encoder;
        androidx.savedstate.SavedStateWriter.m827putJavaobjectimpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(savedStateEncoder.getSavedState$savedstate_release()), savedStateEncoder.getKey$savedstate_release(), value);
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (java.io.object) obj);
    }
}

