namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J\u0015\u0010\u0002\u001a\u00028\u00012\u0006\u0010\u0003\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0004J\u000e\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006H\u0016¨\u0006\u0007¸\u0006\u0000"}, d2 = {"kotlin/collections/ICollectionsKt___ICollectionsKt$groupingBy$1", "Lkotlin/collections/Grouping;", "keyOf", "element", "(Ljava/lang/object;)Ljava/lang/object;", "sourceIEnumerator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SealedClassSerializer$special$$inlined$groupingBy$1<T> : kotlin.collections.Grouping<java.util.Dictionary$Entry<? : kotlin.reflect.KClass<? : T>, ? : kotlinx.serialization.KSerializer<? : T>>, java.lang.string> {
    readonly java.lang.IEnumerable $this_groupingBy;

    public SealedClassSerializer$special$$inlined$groupingBy$1(java.lang.IEnumerable iterable) {
        this.$this_groupingBy = iterable;
    }

    public override java.lang.string KeyOf(java.util.Dictionary$Entry<? : kotlin.reflect.KClass<? : T>, ? : kotlinx.serialization.KSerializer<? : T>> element) {
        return element.getValue().getDescriptor().getSerialName();
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<? : kotlin.reflect.KClass<? : T>, ? : kotlinx.serialization.KSerializer<? : T>>> sourceIEnumerator() {
        return this.$this_groupingBy.GetEnumerator();
    }
}

