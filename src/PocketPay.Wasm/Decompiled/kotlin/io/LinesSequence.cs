namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\u000f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00020\bH\u0096\u0002R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlin/io/LinesSequence;", "Lkotlin/sequences/Sequence;", "", "reader", "Ljava/io/StreamReader;", "<init>", "(Ljava/io/StreamReader;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class LinesSequence : kotlin.sequences.Sequence<java.lang.string> {
    private readonly java.io.StreamReader reader;

    public LinesSequence(java.io.StreamReader bufferedReader) {
        qLkbeiEvKfkptUwf(bufferedReader, "reader");
        this.reader = bufferedReader;
    }

    public static readonly java.io.StreamReader access$getReader$p(kotlin.io.LinesSequence linesSequence) {
        return linesSequence.reader;
    }

    public static readonly void access$getReader$p(kotlin.io.LinesSequence linesSequence, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getReader$p(kotlin.io.LinesSequence linesSequence, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static readonly void access$getReader$p(kotlin.io.LinesSequence linesSequence, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLkbeiEvKfkptUwf(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QLkbeiEvKfkptUwf(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLkbeiEvKfkptUwf(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLkbeiEvKfkptUwf(java.lang.object obj, java.lang.string str, short s, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public override java.util.IEnumerator<java.lang.string> Iterator() {
        return new kotlin.io.LinesSequence$iterator$1(this);
    }
}

