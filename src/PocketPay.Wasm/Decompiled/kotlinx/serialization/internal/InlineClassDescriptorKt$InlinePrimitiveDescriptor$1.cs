namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00005\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0017\u0010\u0002\u001a\f\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u00040\u0003H\u0016¢\u0006\u0002\u0010\u0005J\u001d\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u000fJ\u0015\u0010\u0010\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00020\u0012H\u0016¢\u0006\u0002\u0010\u0013R\u0014\u0010\u0006\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\t¨\u0006\u0014"}, d2 = {"kotlinx/serialization/internal/InlineClassDescriptorKt$InlinePrimitiveDescriptor$1", "Lkotlinx/serialization/internal/GeneratedSerializer;", "childSerializers", "", "Lkotlinx/serialization/KSerializer;", "()[Lkotlinx/serialization/KSerializer;", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "(Lkotlinx/serialization/encoding/Encoder;Ljava/lang/object;)V", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "(Lkotlinx/serialization/encoding/Decoder;)Ljava/lang/object;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class InlineClassDescriptorKt$InlinePrimitiveDescriptor$1<T> : kotlinx.serialization.internal.GeneratedSerializer<T> {
    readonly kotlinx.serialization.KSerializer<T> $primitiveSerializer;

    InlineClassDescriptorKt$InlinePrimitiveDescriptor$1(kotlinx.serialization.KSerializer<T> kSerializer) {
        this.$primitiveSerializer = kSerializer;
    }

    public override kotlinx.serialization.KSerializer<object>[] ChildSerializers() {
        if ((19 + 16) % 16 > 0) {
        }
        kotlinx.serialization.KSerializer<object>[] kSerializerArr = new kotlinx.serialization.KSerializer[1];
        kSerializerArr[0] = this.$primitiveSerializer;
        return kSerializerArr;
    }

    public override T Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        throw new java.lang.IllegalStateException("unsupported".tostring());
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        throw new java.lang.IllegalStateException("unsupported".tostring());
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        throw new java.lang.IllegalStateException("unsupported".tostring());
    }

    public override kotlinx.serialization.KSerializer<object>[] TypeParametersSerializers() {
        return kotlinx.serialization.internal.GeneratedSerializer$DefaultImpls.typeParametersSerializers(this);
    }
}

