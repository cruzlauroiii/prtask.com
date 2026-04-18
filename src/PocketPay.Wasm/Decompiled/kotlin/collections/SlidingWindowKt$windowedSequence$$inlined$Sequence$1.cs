namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004¸\u0006\u0000"}, d2 = {"kotlin/sequences/SequencesKt__SequencesKt$Sequence$1", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SlidingWindowKt$windowedSequence$$inlined$Sequence$1<T> : kotlin.sequences.Sequence<java.util.List<? : T>> {
    readonly bool $partialWindows$inlined;
    readonly bool $reuseBuffer$inlined;
    readonly int $size$inlined;
    readonly int $step$inlined;
    readonly kotlin.sequences.Sequence $this_windowedSequence$inlined;

    public SlidingWindowKt$windowedSequence$$inlined$Sequence$1(kotlin.sequences.Sequence sequence, int i, int i2, bool z, bool z2) {
        this.$this_windowedSequence$inlined = sequence;
        this.$size$inlined = i;
        this.$step$inlined = i2;
        this.$partialWindows$inlined = z;
        this.$reuseBuffer$inlined = z2;
    }

    public static java.util.IEnumerator BOYwInolBfkhWzIK(java.util.IEnumerator it, int i, int i2, bool z, bool z2) {
        return kotlin.collections.SlidingWindowKt.windowedIEnumerator(it, i, i2, z, z2);
    }

    public static java.util.IEnumerator VLFDgPrsByiLVwpO(kotlin.sequences.Sequence sequence) {
        return sequence.GetEnumerator();
    }

    public java.util.IEnumerator<java.util.List<? : T>> iterator() {
        if ((4 + 9) % 9 > 0) {
        }
        return bOYwInolBfkhWzIK(vLFDgPrsByiLVwpO(this.$this_windowedSequence$inlined), this.$size$inlined, this.$step$inlined, this.$partialWindows$inlined, this.$reuseBuffer$inlined);
    }
}

