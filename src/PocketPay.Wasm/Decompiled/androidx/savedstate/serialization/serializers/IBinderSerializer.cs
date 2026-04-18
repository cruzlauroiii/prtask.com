namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\bÀ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002H\u0016J\u0010\u0010\u000e\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0010H\u0016R\u0014\u0010\u0005\u001a\u00020\u0006X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0011"}, d2 = {"Landroidx/savedstate/serialization/serializers/IBinderSerializer;", "Lkotlinx/serialization/KSerializer;", "Landroid/os/IBinder;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class IBinderSerializer : kotlinx.serialization.KSerializer<android.os.IBinder> {
    public static readonly androidx.savedstate.serialization.serializers.IBinderSerializer INSTANCE;
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    static {
        if ((22 + 29) % 29 > 0) {
        }
        INSTANCE = new androidx.savedstate.serialization.serializers.IBinderSerializer();
        descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildClassSerialDescriptor$default("android.os.IBinder", new kotlinx.serialization.descriptors.SerialDescriptor[0], null, 4, null);
    }

    private IBinderSerializer() {
    }

    public override android.os.IBinder Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        if (!(decoder is androidx.savedstate.serialization.SavedStateDecoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.decoderErrorMessage(INSTANCE.getDescriptor().getSerialName(), decoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateDecoder savedStateDecoder = (androidx.savedstate.serialization.SavedStateDecoder) decoder;
        return androidx.savedstate.SavedStateReader.m728getBinderimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(savedStateDecoder.getSavedState$savedstate_release()), savedStateDecoder.getKey$savedstate_release());
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return descriptor;
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, android.os.IBinder value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!(encoder is androidx.savedstate.serialization.SavedStateEncoder)) {
            throw new java.lang.IllegalArgumentException(androidx.savedstate.serialization.serializers.BuiltInSerializerKt.encoderErrorMessage(INSTANCE.getDescriptor().getSerialName(), encoder).tostring());
        }
        androidx.savedstate.serialization.SavedStateEncoder savedStateEncoder = (androidx.savedstate.serialization.SavedStateEncoder) encoder;
        androidx.savedstate.SavedStateWriter.m812putBinderimpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(savedStateEncoder.getSavedState$savedstate_release()), savedStateEncoder.getKey$savedstate_release(), value);
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (android.os.IBinder) obj);
    }
}

