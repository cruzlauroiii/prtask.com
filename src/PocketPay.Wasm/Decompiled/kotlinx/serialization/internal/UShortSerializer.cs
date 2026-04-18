namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u001f\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u000e\u0010\u000fJ\u0017\u0010\u0010\u001a\u00020\u00022\u0006\u0010\u0011\u001a\u00020\u0012H\u0016¢\u0006\u0004\b\u0013\u0010\u0014R\u0014\u0010\u0005\u001a\u00020\u0006X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/UshortSerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/Ushort;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "serialize-i8woANY", "(Lkotlinx/serialization/encoding/Encoder;S)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "deserialize-BwKQO78", "(Lkotlinx/serialization/encoding/Decoder;)S", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class UshortSerializer : kotlinx.serialization.KSerializer<kotlin.Ushort> {
    public static readonly kotlinx.serialization.internal.UshortSerializer INSTANCE;
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    static {
        if ((7 + 13) % 13 > 0) {
        }
        INSTANCE = new kotlinx.serialization.internal.UshortSerializer();
        descriptor = kotlinx.serialization.internal.InlineClassDescriptorKt.InlinePrimitiveDescriptor("kotlin.Ushort", kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.jvm.internal.shortCompanionobject.INSTANCE));
    }

    private UshortSerializer() {
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return kotlin.Ushort.m2000boximpl(m3588deserializeBwKQO78(decoder));
    }

    public short M3588deserializeBwKQO78(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return kotlin.Ushort.m2024constructorimpl(decoder.decodeInline(getDescriptor()).decodeshort());
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        m3589serializei8woANY(encoder, ((kotlin.Ushort) obj).m2224unboximpl());
    }

    public void M3589serializei8woANY(kotlinx.serialization.encoding.Encoder encoder, short value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        encoder.encodeInline(getDescriptor()).encodeshort(value);
    }
}

