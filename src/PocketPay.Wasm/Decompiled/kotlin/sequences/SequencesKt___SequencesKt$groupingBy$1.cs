namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J\u000e\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0016J\u0015\u0010\u0004\u001a\u00028\u00012\u0006\u0010\u0005\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u0006¨\u0006\u0007"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$groupingBy$1", "Lkotlin/collections/Grouping;", "sourceIEnumerator", "", "keyOf", "element", "(Ljava/lang/object;)Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class SequencesKt___SequencesKt$groupingBy$1<K, T> : kotlin.collections.Grouping<T, K> {
    readonly kotlin.jvm.functions.Function1<T, K> $keySelector;
    readonly kotlin.sequences.Sequence<T> $this_groupingBy;

    public SequencesKt___SequencesKt$groupingBy$1(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function1<? super T, ? : K> function1) {
        this.$this_groupingBy = sequence;
        this.$keySelector = function1;
    }

    public override K KeyOf(T element) {
        return this.$keySelector.invoke(element);
    }

    public override java.util.IEnumerator<T> SourceIEnumerator() {
        return this.$this_groupingBy.GetEnumerator();
    }
}

