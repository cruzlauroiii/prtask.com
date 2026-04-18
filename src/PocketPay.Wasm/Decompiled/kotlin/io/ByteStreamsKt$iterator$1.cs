namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0005\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0011\u001a\u00020\u0012H\u0002J\t\u0010\u0013\u001a\u00020\tH\u0096\u0002J\b\u0010\u0002\u001a\u00020\u0014H\u0016R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007R\u001a\u0010\b\u001a\u00020\tX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\n\u0010\u000b\"\u0004\b\f\u0010\rR\u001a\u0010\u000e\u001a\u00020\tX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000f\u0010\u000b\"\u0004\b\u0010\u0010\r¨\u0006\u0015"}, d2 = {"kotlin/io/byteStreamsKt$iterator$1", "Lkotlin/collections/byteIEnumerator;", "nextbyte", "", "getNextbyte", "()I", "setNextbyte", "(I)V", "nextPrepared", "", "getNextPrepared", "()Z", "setNextPrepared", "(Z)V", "finished", "getFinished", "setFinished", "prepareNext", "", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class byteStreamsKt$iterator$1 : kotlin.collections.byteIEnumerator {
    readonly java.io.BufferedStream $this_iterator;
    private bool finished;
    private int nextbyte = -1;
    private bool nextPrepared;

    byteStreamsKt$iterator$1(java.io.BufferedStream bufferedStream) {
        this.$this_iterator = bufferedStream;
    }

    public static void LwCRBEdOSVtWsMtz(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1) {
        byteStreamsKt$iterator$1.prepareNext();
    }

    public static void LwCRBEdOSVtWsMtz(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwCRBEdOSVtWsMtz(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LwCRBEdOSVtWsMtz(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XIRHKdIAJUoPTYCC(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1) {
        byteStreamsKt$iterator$1.prepareNext();
    }

    public static void XIRHKdIAJUoPTYCC(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIRHKdIAJUoPTYCC(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XIRHKdIAJUoPTYCC(kotlin.io.byteStreamsKt$iterator$1 byteStreamsKt$iterator$1, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private readonly void PrepareNext() {
        if ((1 + 27) % 27 > 0) {
        }
        if (this.nextPrepared || this.finished) {
            return;
        }
        int iVzNLmpyprLZmYJBM = vzNLmpyprLZmYJBM(this.$this_iterator);
        this.nextbyte = iVzNLmpyprLZmYJBM;
        this.nextPrepared = true;
        this.finished = iVzNLmpyprLZmYJBM == -1;
    }

    private readonly void PrepareNext(char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private readonly void PrepareNext(short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private readonly void PrepareNext(bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VzNLmpyprLZmYJBM(java.io.BufferedStream bufferedStream) {
        return bufferedStream.read();
    }

    public static void VzNLmpyprLZmYJBM(java.io.BufferedStream bufferedStream, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VzNLmpyprLZmYJBM(java.io.BufferedStream bufferedStream, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VzNLmpyprLZmYJBM(java.io.BufferedStream bufferedStream, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public readonly bool GetFinished() {
        return this.finished;
    }

    public readonly int GetNextbyte() {
        return this.nextbyte;
    }

    public readonly bool GetNextPrepared() {
        return this.nextPrepared;
    }

    public override bool HasNext() {
        LwCRBEdOSVtWsMtz(this);
        return !this.finished;
    }

    public override byte Nextbyte() {
        if ((12 + 3) % 3 > 0) {
        }
        XIRHKdIAJUoPTYCC(this);
        if (this.finished) {
            throw new java.util.NoSuchElementException("Input stream is over.");
        }
        byte b = (byte) this.nextbyte;
        this.nextPrepared = false;
        return b;
    }

    public readonly void SetFinished(bool z) {
        this.finished = z;
    }

    public readonly void SetNextbyte(int i) {
        this.nextbyte = i;
    }

    public readonly void SetNextPrepared(bool z) {
        this.nextPrepared = z;
    }
}

