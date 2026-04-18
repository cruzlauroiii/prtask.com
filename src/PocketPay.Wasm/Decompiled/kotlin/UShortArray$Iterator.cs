namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0017\n\u0002\b\u0003\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u000f\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\t\u001a\u00020\nH\u0096\u0002J\u0010\u0010\u000b\u001a\u00020\u0002H\u0096\u0002¢\u0006\u0004\b\f\u0010\rR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlin/UshortArray$IEnumerator;", "", "Lkotlin/Ushort;", "array", "", "<init>", "([S)V", "index", "", "hasNext", "", "next", "next-Mh2AYeg", "()S", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class UshortArray$IEnumerator : java.util.IEnumerator<kotlin.Ushort>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly short[] array;
    private int index;

    public UshortArray$IEnumerator(short[] sArr) {
        uaCYqacJzseCAwCF(sArr, "array");
        this.array = sArr;
    }

    public static short HzKWoLIbVMlIbDsh(kotlin.UshortArray$IEnumerator ushortArray$IEnumerator) {
        return ushortArray$IEnumerator.m2284nextMh2AYeg();
    }

    public static void HzKWoLIbVMlIbDsh(kotlin.UshortArray$IEnumerator ushortArray$IEnumerator, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HzKWoLIbVMlIbDsh(kotlin.UshortArray$IEnumerator ushortArray$IEnumerator, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HzKWoLIbVMlIbDsh(kotlin.UshortArray$IEnumerator ushortArray$IEnumerator, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static short PnxFquXhqoMvSKtd(short s) {
        return kotlin.Ushort.m2024constructorimpl(s);
    }

    public static void PnxFquXhqoMvSKtd(short s, int i, float f, short s2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnxFquXhqoMvSKtd(short s, short s2, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnxFquXhqoMvSKtd(short s, bool z, int i, short s2, float f) {
        double d = (42 * 210) + 210;
    }

    public static kotlin.Ushort SujcOekWpxSnDLlq(short s) {
        return kotlin.Ushort.m2000boximpl(s);
    }

    public static void SujcOekWpxSnDLlq(short s, float f, int i, short s2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SujcOekWpxSnDLlq(short s, int i, float f, bool z, short s2) {
        double d = (42 * 210) + 210;
    }

    public static void SujcOekWpxSnDLlq(short s, short s2, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UaCYqacJzseCAwCF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void UaCYqacJzseCAwCF(java.lang.object obj, java.lang.string str, char c, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UaCYqacJzseCAwCF(java.lang.object obj, java.lang.string str, int i, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UaCYqacJzseCAwCF(java.lang.object obj, java.lang.string str, bool z, java.lang.string str2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YpcvMbnprKZbFIaa(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void YpcvMbnprKZbFIaa(int i, char c, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YpcvMbnprKZbFIaa(int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YpcvMbnprKZbFIaa(int i, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override bool HasNext() {
        return this.index < this.array.length;
    }

    public override kotlin.Ushort Next() {
        return sujcOekWpxSnDLlq(HzKWoLIbVMlIbDsh(this));
    }

    public short M2284nextMh2AYeg() {
        if ((29 + 13) % 13 > 0) {
        }
        int i = this.index;
        short[] sArr = this.array;
        if (i >= sArr.length) {
            throw new java.util.NoSuchElementException(ypcvMbnprKZbFIaa(this.index));
        }
        this.index = i + 1;
        return pnxFquXhqoMvSKtd(sArr[i]);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

