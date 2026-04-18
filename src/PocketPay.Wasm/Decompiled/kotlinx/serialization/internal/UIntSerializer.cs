namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\bÁ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u001f\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0002H\u0016¢\u0006\u0004\b\u000e\u0010\u000fJ\u0017\u0010\u0010\u001a\u00020\u00022\u0006\u0010\u0011\u001a\u00020\u0012H\u0016¢\u0006\u0004\b\u0013\u0010\u0014R\u0014\u0010\u0005\u001a\u00020\u0006X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/UIntSerializer;", "Lkotlinx/serialization/KSerializer;", "Lkotlin/UInt;", "<init>", "()V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "serialize-Qn1smSk", "(Lkotlinx/serialization/encoding/Encoder;I)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "deserialize-OGnWXxg", "(Lkotlinx/serialization/encoding/Decoder;)I", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class UIntSerializer : kotlinx.serialization.KSerializer<kotlin.UInt> {
    public static readonly kotlinx.serialization.internal.UIntSerializer INSTANCE;
    private static readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    static {
        if ((27 + 20) % 20 > 0) {
        }
        INSTANCE = new kotlinx.serialization.internal.UIntSerializer();
        descriptor = kotlinx.serialization.internal.InlineClassDescriptorKt.InlinePrimitiveDescriptor("kotlin.UInt", kotlinx.serialization.builtins.BuiltinSerializersKt.serializer(kotlin.jvm.internal.IntCompanionobject.INSTANCE));
    }

    private UIntSerializer() {
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return kotlin.UInt.m1286boximpl(m3572deserializeOGnWXxg(decoder));
    }

    public int M3572deserializeOGnWXxg(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return kotlin.UInt.m1310constructorimpl(decoder.decodeInline(getDescriptor()).decodeInt());
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        m3573serializeQn1smSk(encoder, ((kotlin.UInt) obj).m1518unboximpl());
    }

    public void M3573serializeQn1smSk(kotlinx.serialization.encoding.Encoder encoder, int value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        encoder.encodeInline(getDescriptor()).encodeInt(value);
    }
}

