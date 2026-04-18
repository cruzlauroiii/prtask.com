namespace WillowMaze.Wasm.Decompiled;


public readonly class DictionaryEntrySerializer$$ExternalSyntheticLambda0 : kotlin.jvm.functions.Function1 {
    public readonly kotlinx.serialization.KSerializer f$0;
    public readonly kotlinx.serialization.KSerializer f$1;

    public DictionaryEntrySerializer$$ExternalSyntheticLambda0(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2) {
        this.f$0 = kSerializer;
        this.f$1 = kSerializer2;
    }

    public override readonly java.lang.object Invoke(java.lang.object obj) {
        return kotlinx.serialization.internal.DictionaryEntrySerializer.m3553$r8$lambda$OpkROm_ArWMMdjLNh8LkCpGaY0(this.f$0, this.f$1, (kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder) obj);
    }
}

