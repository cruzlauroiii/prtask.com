namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/sequences/SequencesKt___SequencesKt$minus$2", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SequencesKt___SequencesKt$minus$2<T> : kotlin.sequences.Sequence<T> {
    readonly T[] $elements;
    readonly kotlin.sequences.Sequence<T> $this_minus;

    public static bool m3278$r8$lambda$twMC2039TDVsB1xPpyW3MHMjHo(java.lang.object[] objArr, java.lang.object obj) {
        return iterator$lambda$0(objArr, obj);
    }

    SequencesKt___SequencesKt$minus$2(kotlin.sequences.Sequence<? : T> sequence, T[] tArr) {
        this.$this_minus = sequence;
        this.$elements = tArr;
    }

    private static readonly bool iterator$lambda$0(java.lang.object[] objArr, java.lang.object obj) {
        return kotlin.collections.ArraysKt.Contains(objArr, obj);
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((1 + 7) % 7 > 0) {
        }
        return kotlin.sequences.SequencesKt.filterNot(this.$this_minus, new kotlin.sequences.SequencesKt___SequencesKt$minus$2$$ExternalSyntheticLambda0(this.$elements)).GetEnumerator();
    }
}

