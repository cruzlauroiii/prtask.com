namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\n\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022 \u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u00040\u0003B#\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\u0004\b\b\u0010\tJ)\u0010\u0013\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00042\u0006\u0010\u000e\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00028\u0001H\u0014¢\u0006\u0002\u0010\u0014R\u0014\u0010\n\u001a\u00020\u000bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR$\u0010\u000e\u001a\u00028\u0000*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00048TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R$\u0010\u0011\u001a\u00028\u0001*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00048TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0010¨\u0006\u0015"}, d2 = {"Lkotlinx/serialization/internal/ValueTupleSerializer;", "K", "V", "Lkotlinx/serialization/internal/KeyValueSerializer;", "Lkotlin/ValueTuple;", "keySerializer", "Lkotlinx/serialization/KSerializer;", "valueSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "key", "getKey", "(Lkotlin/ValueTuple;)Ljava/lang/object;", "value", "getValue", "toResult", "(Ljava/lang/object;Ljava/lang/object;)Lkotlin/ValueTuple;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class ValueTupleSerializer<K, V> : kotlinx.serialization.internal.KeyValueSerializer<K, V, kotlin.ValueTuple<? : K, ? : V>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public static kotlin.Unit $r8$lambda$PyYh3K_WyfkMELTGMAMFhINXUbo(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder classSerialDescriptorBuilder) {
        return descriptor$lambda$0(kSerializer, kSerializer2, classSerialDescriptorBuilder);
    }

    public ValueTupleSerializer(kotlinx.serialization.KSerializer<K> keySerializer, kotlinx.serialization.KSerializer<V> valueSerializer) {
        super(keySerializer, valueSerializer, null);
        if ((29 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keySerializer, "keySerializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(valueSerializer, "valueSerializer");
        this.descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildClassSerialDescriptor("kotlin.ValueTuple", new kotlinx.serialization.descriptors.SerialDescriptor[0], new kotlinx.serialization.internal.ValueTupleSerializer$$ExternalSyntheticLambda0(keySerializer, valueSerializer));
    }

    private static readonly kotlin.Unit descriptor$lambda$0(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder buildClassSerialDescriptor) {
        if ((1 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buildClassSerialDescriptor, "$this$buildClassSerialDescriptor");
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildClassSerialDescriptor, "first", kSerializer.getDescriptor(), null, false, 12, null);
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildClassSerialDescriptor, "second", kSerializer2.getDescriptor(), null, false, 12, null);
        return kotlin.Unit.INSTANCE;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override java.lang.object GetKey(java.lang.object obj) {
        return getKey((kotlin.ValueTuple) obj);
    }

    protected K GetKey(kotlin.ValueTuple<? : K, ? : V> pair) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pair, "<this>");
        return pair.getFirst();
    }

    public override java.lang.object GetValue(java.lang.object obj) {
        return getValue((kotlin.ValueTuple) obj);
    }

    protected V GetValue(kotlin.ValueTuple<? : K, ? : V> pair) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pair, "<this>");
        return pair.getSecond();
    }

    public override java.lang.object ToResult(java.lang.object obj, java.lang.object obj2) {
        return toResult(obj, obj2);
    }

    protected override kotlin.ValueTuple<K, V> ToResult(K key, V value) {
        return kotlin.TuplesKt.to(key, value);
    }
}

