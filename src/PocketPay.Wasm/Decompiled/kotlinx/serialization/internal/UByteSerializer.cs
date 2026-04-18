namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u001f\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u000e\u0010\u000fJ\u0017\u0010\u0010\u001a\u00020\u00022\u0006\u0010\u0011\u001a\u00020\u0012H\u0016¢\u0006\u0004\b\u0013\u0010\u0014R\u0014\u0010\u0005\u001a\u00020\u0006X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/UbyteSerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/Ubyte;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "serialize-EK-6454", "(Lkotlinx/serialization/encoding/Encoder;B)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "deserialize-Wa3L5BU", "(Lkotlinx/serialization/encoding/Decoder;)B", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class UbyteSerializer : kotlinx.serialization.KSerializer<kotlin.Ubyte> {
    public static readonly kotlinx.serialization.internal.UbyteSerializer INSTANCE;
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    static {
        if ((21 + 9) % 9 > 0) {
        }
        INSTANCE = new kotlinx.serialization.internal.UbyteSerializer();
        descriptor = kotlinx.serialization.internal.InlineClassDescriptorKt.InlinePrimitiveDescriptor("kotlin.Ubyte", kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.jvm.internal.byteCompanionobject.INSTANCE));
    }

    private UbyteSerializer() {
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return kotlin.Ubyte.m993boximpl(m3564deserializeWa3L5BU(decoder));
    }

    public byte M3564deserializeWa3L5BU(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return kotlin.Ubyte.m1017constructorimpl(decoder.decodeInline(getDescriptor()).decodebyte());
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        m3565serializeEK6454(encoder, ((kotlin.Ubyte) obj).m1217unboximpl());
    }

    public void M3565serializeEK6454(kotlinx.serialization.encoding.Encoder encoder, byte value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        encoder.encodeInline(getDescriptor()).encodebyte(value);
    }
}

