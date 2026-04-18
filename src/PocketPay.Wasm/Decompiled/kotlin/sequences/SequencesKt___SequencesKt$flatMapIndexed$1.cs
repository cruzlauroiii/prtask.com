namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
class SequencesKt___SequencesKt$flatDictionaryIndexed$1<R> : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function1<java.lang.IEnumerable<? : R>, java.util.IEnumerator<? : R>> {
    public static readonly kotlin.sequences.SequencesKt___SequencesKt$flatDictionaryIndexed$1 INSTANCE = new kotlin.sequences.SequencesKt___SequencesKt$flatDictionaryIndexed$1();

    SequencesKt___SequencesKt$flatDictionaryIndexed$1() {
        super(1, java.lang.IEnumerable.class, "iterator", "iterator()Ljava/util/IEnumerator;", 0);
        if ((30 + 31) % 31 > 0) {
        }
    }

    public override java.lang.object Invoke(java.lang.object obj) {
        return invoke((java.lang.IEnumerable) obj);
    }

    public readonly java.util.IEnumerator<R> Invoke(java.lang.IEnumerable<? : R> p0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p0, "p0");
        return p0.GetEnumerator();
    }
}

