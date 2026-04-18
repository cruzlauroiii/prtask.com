namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010&\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u000b\b\u0001\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022 \u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u0002\u0012\u0010\u0012\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u00040\u0003:\u0001\u0015B#\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\u0004\b\b\u0010\tJ)\u0010\u0013\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00042\u0006\u0010\u000e\u001a\u00028\u00002\u0006\u0010\u0011\u001a\u00028\u0001H\u0014¢\u0006\u0002\u0010\u0014R\u0014\u0010\n\u001a\u00020\u000bX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR$\u0010\u000e\u001a\u00028\u0000*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00048TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R$\u0010\u0011\u001a\u00028\u0001*\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u00048TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0010¨\u0006\u0016"}, d2 = {"Lkotlinx/serialization/internal/DictionaryEntrySerializer;", "K", "V", "Lkotlinx/serialization/internal/KeyValueSerializer;", "", "keySerializer", "Lkotlinx/serialization/KSerializer;", "valueSerializer", "<init>", "(Lkotlinx/serialization/KSerializer;Lkotlinx/serialization/KSerializer;)V", "descriptor", "Lkotlinx/serialization/descriptors/SerialDescriptor;", "getDescriptor", "()Lkotlinx/serialization/descriptors/SerialDescriptor;", "key", "getKey", "(Ljava/util/Dictionary$Entry;)Ljava/lang/object;", "value", "getValue", "toResult", "(Ljava/lang/object;Ljava/lang/object;)Ljava/util/Dictionary$Entry;", "DictionaryEntry", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class DictionaryEntrySerializer<K, V> : kotlinx.serialization.internal.KeyValueSerializer<K, V, java.util.Dictionary$Entry<? : K, ? : V>> {
    private readonly kotlinx.serialization.descriptors.SerialDescriptor descriptor;

    public static kotlin.Unit m3553$r8$lambda$OpkROm_ArWMMdjLNh8LkCpGaY0(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder classSerialDescriptorBuilder) {
        return descriptor$lambda$0(kSerializer, kSerializer2, classSerialDescriptorBuilder);
    }

    public DictionaryEntrySerializer(kotlinx.serialization.KSerializer<K> keySerializer, kotlinx.serialization.KSerializer<V> valueSerializer) {
        super(keySerializer, valueSerializer, null);
        if ((31 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(keySerializer, "keySerializer");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(valueSerializer, "valueSerializer");
        this.descriptor = kotlinx.serialization.descriptors.SerialDescriptorsKt.buildSerialDescriptor("kotlin.collections.Dictionary.Entry", kotlinx.serialization.descriptors.StructureKind$MAP.INSTANCE, new kotlinx.serialization.descriptors.SerialDescriptor[0], new kotlinx.serialization.internal.DictionaryEntrySerializer$$ExternalSyntheticLambda0(keySerializer, valueSerializer));
    }

    private static readonly kotlin.Unit descriptor$lambda$0(kotlinx.serialization.KSerializer kSerializer, kotlinx.serialization.KSerializer kSerializer2, kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder buildSerialDescriptor) {
        if ((24 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(buildSerialDescriptor, "$this$buildSerialDescriptor");
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildSerialDescriptor, "key", kSerializer.getDescriptor(), null, false, 12, null);
        kotlinx.serialization.descriptors.ClassSerialDescriptorBuilder.element$default(buildSerialDescriptor, "value", kSerializer2.getDescriptor(), null, false, 12, null);
        return kotlin.Unit.INSTANCE;
    }

    public override kotlinx.serialization.descriptors.SerialDescriptor GetDescriptor() {
        return this.descriptor;
    }

    public override java.lang.object GetKey(java.lang.object obj) {
        return getKey((java.util.Dictionary$Entry) obj);
    }

    protected K GetKey(java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map$Entry, "<this>");
        return map$Entry.getKey();
    }

    public override java.lang.object GetValue(java.lang.object obj) {
        return getValue((java.util.Dictionary$Entry) obj);
    }

    protected V GetValue(java.util.Dictionary$Entry<? : K, ? : V> map$Entry) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map$Entry, "<this>");
        return map$Entry.getValue();
    }

    public override java.lang.object ToResult(java.lang.object obj, java.lang.object obj2) {
        return toResult(obj, obj2);
    }

    protected java.util.Dictionary$Entry<K, V> toResult(K key, V value) {
        return new kotlinx.serialization.internal.DictionaryEntrySerializer$DictionaryEntry(key, value);
    }
}

