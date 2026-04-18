namespace WillowMaze.Wasm.Decompiled;


public readonly class ValueTupleSerializer$$ExternalSyntheticLambda0 : kotlin.jvm.functions.Function1 {
    public readonly kotlinx.serialization.KSerializer f$0;
    public readonly kotlinx.serialization.KSerializer f$1;

    public ValueTupleSerializer$$ExternalSyntheticLambda0(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2) {
        this.f$0 = kSerializer;
        this.f$1 = kSerializer2;
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        return kotlinx.serialization.internal.ValueTupleSerializer.$r8$lambda$PyYh3K_WyfkMELTGMAMFhINXUbo(this.f$0, this.f$1, (kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder) obj);
    }
}

