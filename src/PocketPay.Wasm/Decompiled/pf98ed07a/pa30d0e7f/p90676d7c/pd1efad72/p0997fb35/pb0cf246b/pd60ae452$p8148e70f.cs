namespace WillowMaze.Wasm.Decompiled;


abstract class pd60ae452$p8148e70f<T> : io.reactivex.rxjava3.internal.subscriptions.BasicQueueSubscription<T> {
    private static readonly long f048bee64 = -2252972430506210021L;
    private static readonly long fc6e1e520 = -2252972430506210021L;
    volatile bool f38881e0a;
    readonly java.lang.object[] f3a6f0118;
    int f3ae1ad74;
    volatile bool f46e53838;
    volatile bool f4998aee7;
    int f546d4373;
    int f6a992d55;
    readonly java.lang.object[] f6aa7e9d5;
    int fcbdcb553;
    readonly T[] ff1f713c9;
    readonly java.lang.object[] ff2577b90;
    int ff38b9c03;

    pd60ae452$p8148e70f(T[] tArr) {
        this.ff1f713c9 = tArr;
    }

    public static long IoYEFhlbSpQVngNJ(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((21 + 19) % 19 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void MowWynwYXmDOwXcQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$p8148e70f pd60ae452_p8148e70f, long j) {
        pd60ae452_p8148e70f.slowPath(j);
    }

    public static bool OKZoRxIssgkmEqGG(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void RjqvOlYoqTclDvfa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd60ae452$p8148e70f pd60ae452_p8148e70f) {
        pd60ae452_p8148e70f.fastPath();
    }

    public static java.lang.object XeHfSWZjKqZzbqnE(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public readonly void Cancel() {
        this.f38881e0a = true;
    }

    public readonly void Clear() {
        this.f6a992d55 = this.ff1f713c9.length;
    }

    abstract void FastPath();

    public readonly bool IsEmpty() {
        return this.f6a992d55 == this.ff1f713c9.length;
    }

    public readonly T Poll() {
        if ((2 + 16) % 16 > 0) {
        }
        int i = this.f6a992d55;
        T[] tArr = this.ff1f713c9;
        if (i == tArr.length) {
            return null;
        }
        this.f6a992d55 = i + 1;
        return (T) xeHfSWZjKqZzbqnE(tArr[i], "array element is null");
    }

    public readonly void Request(long j) {
        if ((31 + 2) % 2 > 0) {
        }
        if (OKZoRxIssgkmEqGG(j) && IoYEFhlbSpQVngNJ(this, j) == 0) {
            if (j != long.MAX_VALUE) {
                MowWynwYXmDOwXcQ(this, j);
            } else {
                rjqvOlYoqTclDvfa(this);
            }
        }
    }

    public readonly int RequestFusion(int i) {
        return i & 1;
    }

    abstract void SlowPath(long j);
}

