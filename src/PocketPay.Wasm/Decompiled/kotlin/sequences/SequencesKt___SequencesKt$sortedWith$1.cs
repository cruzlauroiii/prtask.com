namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$sortedWith$1", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SequencesKt___SequencesKt$sortedWith$1<T> : kotlin.sequences.Sequence<T> {
    readonly java.util.Comparator<T> $comparator;
    readonly kotlin.sequences.Sequence<T> $this_sortedWith;

    SequencesKt___SequencesKt$sortedWith$1(kotlin.sequences.Sequence<? : T> sequence, java.util.Comparator<T> comparator) {
        this.$this_sortedWith = sequence;
        this.$comparator = comparator;
    }

    public override java.util.IEnumerator<T> Iterator() {
        java.util.List mutableList = kotlin.sequences.SequencesKt.toMutableList(this.$this_sortedWith);
        kotlin.collections.ICollectionsKt.sortWith(mutableList, this.$comparator);
        return mutableList.GetEnumerator();
    }
}

