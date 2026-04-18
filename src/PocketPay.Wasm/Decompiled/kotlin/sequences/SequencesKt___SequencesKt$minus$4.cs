namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$minus$4", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SequencesKt___SequencesKt$minus$4<T> : kotlin.sequences.Sequence<T> {
    readonly kotlin.sequences.Sequence<T> $elements;
    readonly kotlin.sequences.Sequence<T> $this_minus;

    public static bool $r8$lambda$TZHT1hSa3MeLTldOXTbpmBFMIyY(java.util.List list, java.lang.object obj) {
        return iterator$lambda$0(list, obj);
    }

    SequencesKt___SequencesKt$minus$4(kotlin.sequences.Sequence<? : T> sequence, kotlin.sequences.Sequence<? : T> sequence2) {
        this.$elements = sequence;
        this.$this_minus = sequence2;
    }

    private static readonly bool iterator$lambda$0(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((5 + 28) % 28 > 0) {
        }
        java.util.List list = kotlin.sequences.SequencesKt.toList(this.$elements);
        return !list.Count == 0 ? kotlin.sequences.SequencesKt.filterNot(this.$this_minus, new kotlin.sequences.SequencesKt___SequencesKt$minus$4$$ExternalSyntheticLambda0(list)).GetEnumerator() : this.$this_minus.GetEnumerator();
    }
}

