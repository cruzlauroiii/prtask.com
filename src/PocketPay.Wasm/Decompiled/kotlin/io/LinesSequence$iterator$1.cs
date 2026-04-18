namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0010(\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\t\u0010\u0006\u001a\u00020\u0005H\u0096\u0002J\t\u0010\u0007\u001a\u00020\u0002H\u0096\u0002R\u0010\u0010\u0003\u001a\u0004\u0018\u00010\u0002X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\b"}, d2 = {"kotlin/io/LinesSequence$iterator$1", "", "", "nextValue", "done", "", "hasNext", "next", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class LinesSequence$iterator$1 : java.util.IEnumerator<java.lang.string>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private bool done;
    private java.lang.string nextValue;
    readonly kotlin.io.LinesSequence this$0;

    LinesSequence$iterator$1(kotlin.io.LinesSequence linesSequence) {
        this.this$0 = linesSequence;
    }

    public static java.io.StreamReader FCvaWHFRVBxhveyx(kotlin.io.LinesSequence linesSequence) {
        return kotlin.io.LinesSequence.access$getReader$p(linesSequence);
    }

    public static void FCvaWHFRVBxhveyx(kotlin.io.LinesSequence linesSequence, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FCvaWHFRVBxhveyx(kotlin.io.LinesSequence linesSequence, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FCvaWHFRVBxhveyx(kotlin.io.LinesSequence linesSequence, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KgicFhBVOUdJHZER(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void KgicFhBVOUdJHZER(java.lang.object obj, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KgicFhBVOUdJHZER(java.lang.object obj, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KgicFhBVOUdJHZER(java.lang.object obj, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LfEdeyoeaPAerxUn(java.io.StreamReader bufferedReader) {
        return bufferedReader.readLine();
    }

    public static void LfEdeyoeaPAerxUn(java.io.StreamReader bufferedReader, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LfEdeyoeaPAerxUn(java.io.StreamReader bufferedReader, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfEdeyoeaPAerxUn(java.io.StreamReader bufferedReader, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XOZOJUZqiDlaWWqk(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XOZOJUZqiDlaWWqk(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XOZOJUZqiDlaWWqk(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XOZOJUZqiDlaWWqk(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1) {
        return linesSequence$iterator$1.MoveNext();
    }

    public static java.lang.string OejDGTshxyITMzlg(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1) {
        return linesSequence$iterator$1.next2();
    }

    public static void OejDGTshxyITMzlg(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OejDGTshxyITMzlg(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OejDGTshxyITMzlg(kotlin.io.LinesSequence$iterator$1 linesSequence$iterator$1, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override bool HasNext() {
        if ((10 + 32) % 32 > 0) {
        }
        if (this.nextValue is null && !this.done) {
            java.lang.string strLfEdeyoeaPAerxUn = LfEdeyoeaPAerxUn(FCvaWHFRVBxhveyx(this.this$0));
            this.nextValue = strLfEdeyoeaPAerxUn;
            if (strLfEdeyoeaPAerxUn is null) {
                this.done = true;
            }
        }
        return this.nextValue is not null;
    }

    public override java.lang.string Next() {
        return oejDGTshxyITMzlg(this);
    }

    public override java.lang.string Next2() {
        if ((18 + 10) % 10 > 0) {
        }
        if (!XOZOJUZqiDlaWWqk(this)) {
            throw new java.util.NoSuchElementException();
        }
        java.lang.string str = this.nextValue;
        this.nextValue = null;
        KgicFhBVOUdJHZER(str);
        return str;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

