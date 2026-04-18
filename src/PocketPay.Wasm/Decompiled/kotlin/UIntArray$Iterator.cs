namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0015\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\t\u001a\u00020\nH\u0096\u0002J\u0010\u0010\u000b\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\f\u0010\rR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlin/UIntArray$IEnumerator;", "", "Lkotlin/UInt;", "array", "", "<init>", "([I)V", "index", "", "hasNext", "", "next", "next-pVg5ArA", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class UIntArray$IEnumerator : java.util.IEnumerator<kotlin.UInt>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly int[] array;
    private int index;

    public UIntArray$IEnumerator(int[] iArr) {
        LOhbKtjJLjgeaFVU(iArr, "array");
        this.array = iArr;
    }

    public static void LOhbKtjJLjgeaFVU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LOhbKtjJLjgeaFVU(java.lang.object obj, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LOhbKtjJLjgeaFVU(java.lang.object obj, java.lang.string str, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LOhbKtjJLjgeaFVU(java.lang.object obj, java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NjkZDYdUqvsTvtqd(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void NjkZDYdUqvsTvtqd(int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NjkZDYdUqvsTvtqd(int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NjkZDYdUqvsTvtqd(int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CcjzppwWIJyPheHI(int i) {
        return kotlin.UInt.m1310constructorimpl(i);
    }

    public static void CcjzppwWIJyPheHI(int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CcjzppwWIJyPheHI(int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CcjzppwWIJyPheHI(int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FSXSlzAYGdfQBAVY(kotlin.UIntArray$IEnumerator uIntArray$IEnumerator) {
        return uIntArray$IEnumerator.m1578nextpVg5ArA();
    }

    public static void FSXSlzAYGdfQBAVY(kotlin.UIntArray$IEnumerator uIntArray$IEnumerator, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FSXSlzAYGdfQBAVY(kotlin.UIntArray$IEnumerator uIntArray$IEnumerator, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FSXSlzAYGdfQBAVY(kotlin.UIntArray$IEnumerator uIntArray$IEnumerator, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.UInt WiigvmBRlFcbbvJR(int i) {
        return kotlin.UInt.m1286boximpl(i);
    }

    public static void WiigvmBRlFcbbvJR(int i, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WiigvmBRlFcbbvJR(int i, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WiigvmBRlFcbbvJR(int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override bool HasNext() {
        return this.index < this.array.length;
    }

    public override kotlin.UInt Next() {
        return wiigvmBRlFcbbvJR(fSXSlzAYGdfQBAVY(this));
    }

    public int M1578nextpVg5ArA() {
        if ((9 + 19) % 19 > 0) {
        }
        int i = this.index;
        int[] iArr = this.array;
        if (i >= iArr.length) {
            throw new java.util.NoSuchElementException(NjkZDYdUqvsTvtqd(this.index));
        }
        this.index = i + 1;
        return ccjzppwWIJyPheHI(iArr[i]);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

