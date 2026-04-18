namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002B\u0015\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u001e\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0016J\u0016\u0010\u0012\u001a\b\u0012\u0004\u0012\u00028\u00000\u00032\u0006\u0010\u0013\u001a\u00020\u0014H\u0016R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0007\u001a\u00020\bX\u0096\u0004¢\u0006\u000e\n\u0000\u0012\u0004\b\t\u0010\n\u001a\u0004\b\u000b\u0010\f¨\u0006\u0015"}, d2 = {"Landroidx/savedstate/serialization/serializers/MutableStateFlowSerializer;", "T", "Lkotlinx/serialization/KSerializer;", "Lkotlinx/coroutines/flow/MutableStateFlow;", "valueSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor$annotations", "()V", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "serialize", "", "encoder", "Lkotlinx/serialization/encoding/Encoder;", "value", "deserialize", "decoder", "Lkotlinx/serialization/encoding/Decoder;", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class MutableStateFlowSerializer<T> : kotlinx.serialization.KSerializer<kotlinx.coroutines.flow.MutableStateFlow<T>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;
    private readonly kotlinx.serialization.KSerializer<T> valueSerializer;

    public MutableStateFlowSerializer(kotlinx.serialization.KSerializer<T> valueSerializer) {
        if ((27 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(valueSerializer, "valueSerializer");
        this.valueSerializer = valueSerializer;
        kotlinx.serialization.descriptors.SerialKind kind = this.valueSerializer.getDescriptor().getKind();
        this.descriptor = !(kind is kotlinx.serialization.descriptors.PrimitiveKind) ? kotlinx.serialization.descriptors.SerialDescriptorsKt.SerialDescriptor("kotlinx.coroutines.flow.MutableStateFlow", this.valueSerializer.getDescriptor()) : kotlinx.serialization.descriptors.SerialDescriptorsKt.PrimitiveSerialDescriptor("kotlinx.coroutines.flow.MutableStateFlow", (kotlinx.serialization.descriptors.PrimitiveKind) kind);
    }

    public static void getDescriptor$annotations() {
    }

    public override java.lang.object Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        return deserialize(decoder);
    }

    public override kotlinx.coroutines.flow.MutableStateFlow<T> Deserialize(kotlinx.serialization.encoding.Decoder decoder) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(decoder, "decoder");
        return kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(decoder.decodeobjectValue(this.valueSerializer));
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override void Serialize(kotlinx.serialization.encoding.Encoder encoder, java.lang.object obj) {
        serialize(encoder, (kotlinx.coroutines.flow.MutableStateFlow) obj);
    }

    public void Serialize(kotlinx.serialization.encoding.Encoder encoder, kotlinx.coroutines.flow.MutableStateFlow<T> value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(encoder, "encoder");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        encoder.encodeobjectValue(this.valueSerializer, value.getValue());
    }
}

