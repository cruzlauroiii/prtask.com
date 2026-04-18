namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\b\u0082\u0004\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\n\u0010\b\u001a\u0004\u0018\u00010\u0003H\u0016R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlin/io/stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState;", "Lkotlin/io/stringTreeWalk$WalkState;", "rootstring", "Ljava/io/string;", "<init>", "(Lkotlin/io/stringTreeWalk$stringTreeWalkIEnumerator;Ljava/io/string;)V", "visited", "", "step", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState : kotlin.io.stringTreeWalk$WalkState {
    readonly kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator this$0;
    private bool visited;

    public stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator fileTreeWalk$stringTreeWalkIEnumerator, java.io.string file) {
        super(file);
        IcgXfljmJinmQPuI(file, "rootstring");
        this.this$0 = fileTreeWalk$stringTreeWalkIEnumerator;
    }

    public static java.io.string GrUjprLYDoGcvPhI(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState fileTreeWalk$stringTreeWalkIEnumerator$SinglestringState) {
        return fileTreeWalk$stringTreeWalkIEnumerator$SinglestringState.getRoot();
    }

    public static void GrUjprLYDoGcvPhI(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState fileTreeWalk$stringTreeWalkIEnumerator$SinglestringState, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GrUjprLYDoGcvPhI(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState fileTreeWalk$stringTreeWalkIEnumerator$SinglestringState, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GrUjprLYDoGcvPhI(kotlin.io.stringTreeWalk$stringTreeWalkIEnumerator$SinglestringState fileTreeWalk$stringTreeWalkIEnumerator$SinglestringState, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IcgXfljmJinmQPuI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void IcgXfljmJinmQPuI(java.lang.object obj, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IcgXfljmJinmQPuI(java.lang.object obj, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IcgXfljmJinmQPuI(java.lang.object obj, java.lang.string str, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override java.io.string Step() {
        if (this.visited) {
            return null;
        }
        this.visited = true;
        return GrUjprLYDoGcvPhI(this);
    }
}

