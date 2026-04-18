namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004¸\u0006\u0000"}, d2 = {"kotlin/sequences/SequencesKt__SequencesKt$Sequence$1", "Lkotlin/sequences/Sequence;", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class StreamsKt$asSequence$$inlined$Sequence$4 : kotlin.sequences.Sequence<java.lang.double> {
    readonly java.util.stream.doubleStream $this_asSequence$inlined;

    public StreamsKt$asSequence$$inlined$Sequence$4(java.util.stream.doubleStream doubleStream) {
        this.$this_asSequence$inlined = doubleStream;
    }

    public override java.util.IEnumerator<java.lang.double> Iterator() {
        java.util.IEnumerator<java.lang.double> it = this.$this_asSequence$inlined.GetEnumerator();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(it, "iterator(...)");
        return it;
    }
}

