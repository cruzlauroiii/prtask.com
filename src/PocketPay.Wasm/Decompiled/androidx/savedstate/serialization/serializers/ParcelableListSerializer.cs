namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\bÀ\u0002\u0018\u00002\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00030\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0004\u0010\u0005J\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00030\u0002H\u0016J\u0016\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00030\u00022\u0006\u0010\u0010\u001a\u00020\u0011H\u0016R\u0014\u0010\u0006\u001a\u00020\u0007X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u0012"}, d2 = {"Landroidx/savedstate/serialization/serializers/ParcelableListSerializer;", "Lkotlinx/serialization/KSerializer;", "", "Landroid/os/Parcelable;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ParcelableListSerializer : kotlinx.serialization.KSerializer<java.util.List<? : android.os.Parcelable>> {
    public static readonly androidx.savedstate.serialization.serializers.ParcelableListSerializer INSTANCE;
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    static {
        if ((1 + 13) % 13 > 0) {
        }
        INSTANCE = new androidx.savedstate.serialization.serializers.ParcelableListSerializer();
        descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildClassSerialDescriptor$default("kotlin.collections.List<android.os.Parcelable>", new kotlinx.serialization.descriptors.SerialDescriptor[0], null, 4, null);
    }

    private ParcelableListSerializer() {
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override java.util.List<android.os.Parcelable> Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        if (!(decoder is androidx.savedstate.serialization.SavedStateDecoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.decoderErrorMessage(INSTANCE.getDescriptor().getSerialName(), decoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateDecoder savedStateDecoder = (androidx.savedstate.serialization.SavedStateDecoder) decoder;
        return androidx.savedstate.SavedStateReader.m773getParcelableListimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(savedStateDecoder.getSavedState$savedstate_release()), savedStateDecoder.getKey$savedstate_release(), kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(android.os.Parcelable.class));
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (java.util.List<? : android.os.Parcelable>) obj);
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.util.List<? : android.os.Parcelable> value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!(encoder is androidx.savedstate.serialization.SavedStateEncoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.encoderErrorMessage(INSTANCE.getDescriptor().getSerialName(), encoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder = (androidx.savedstate.serialization.SavedStateEncoder) encoder;
        androidx.savedstate.SavedStateWriter.m833putParcelableListimpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(savedStateEncoder.getSavedState$savedstate_release()), savedStateEncoder.getKey$savedstate_release(), value);
    }
}

