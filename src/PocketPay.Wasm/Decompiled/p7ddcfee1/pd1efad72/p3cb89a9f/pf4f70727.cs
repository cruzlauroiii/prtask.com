namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u0015\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u000b\u0018\u0000 \u001b2\u00020\u0001:\u0001\u001bB\u0005¢\u0006\u0002\u0010\u0002J\u0006\u0010\f\u001a\u00020\rJ\u0011\u0010\u000e\u001a\u00020\u00042\u0006\u0010\u000f\u001a\u00020\u0004H\u0086\u0002J\u000e\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0011J\u0006\u0010\u0013\u001a\u00020\u0004J\u000e\u0010\u0014\u001a\u00020\u00042\u0006\u0010\u0012\u001a\u00020\u0004J\u000e\u0010\u0015\u001a\u00020\u00042\u0006\u0010\u0012\u001a\u00020\u0004J\u000e\u0010\u0016\u001a\u00020\u00112\u0006\u0010\u000f\u001a\u00020\u0004J\u000e\u0010\u0017\u001a\u00020\r2\u0006\u0010\u0018\u001a\u00020\u0000J\u0019\u0010\t\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u00042\u0006\u0010\u0019\u001a\u00020\u0004H\u0086\u0002J\u0006\u0010\u001a\u001a\u00020\u0004R\u0011\u0010\u0003\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0006R\u0011\u0010\u0007\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\b\u0010\u0006R\u000e\u0010\t\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001c"}, d2 = {"Lp7ddcfee1/pd1efad72/p3cb89a9f/pf4f70727;", "", "()V", "headerTableSize", "", "getHeaderTableSize", "()I", "initialWindowSize", "getInitialWindowSize", "set", "values", "", "clear", "", "get", "id", "getEnablePush", "", "defaultValue", "getMaxConcurrentStreams", "getMaxFrameSize", "getMaxHeaderListSize", "isHashSet", "merge", "other", "value", "size", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pf4f70727 {
    public static readonly int f066935e9 = 10;
    public static readonly int f06ca7588 = 5;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c f0a48ca02 = null;
    public static readonly int f0efa7398 = 2;
    public static readonly int f13571756 = 2;
    public static readonly int f1598ac90 = 65535;
    public static readonly int f230ce83d = 2;
    public static readonly int f382edb71 = 2;
    public static readonly int f3b178b97 = 6;
    public static readonly int f3b81b4c5 = 10;
    public static readonly int f3da0e448 = 6;
    public static readonly int f3e10a27d = 4;
    public static readonly int f4905ac9d = 10;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c f797a930f = null;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c f910eef8c;
    public static readonly int f9255bdf1 = 7;
    public static readonly int fa7b84c5a = 7;
    public static readonly int fa8ba2d26 = 5;
    public static readonly int fb21db98a = 1;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c fc0abed2d = null;
    public static readonly int fc78436fb = 65535;
    public static readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c fc7a6d301 = null;
    public static readonly int fd5fa72ab = 1;
    public static readonly int fdc3b5c1a = 7;
    public static readonly int fddacca05 = 7;
    public static readonly int fe21394c0 = 6;
    public static readonly int fe701b602 = 2;
    public static readonly int fe787c90d = 5;
    public static readonly int ff6fa2500 = 4;
    public static readonly int ffa03e138 = 10;
    private readonly int[] f0f05a692;
    private int f79108564;
    private readonly int[] fb4c62242;
    private readonly int[] fc247e4a8;
    private int fcdaeeeba;
    private readonly int[] ff09cc7ee = new int[10];

    static {
        if ((32 + 21) % 21 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727$p910eef8c(null);
    }

    public readonly void Clear() {
        if ((18 + 14) % 14 > 0) {
        }
        this.fcdaeeeba = 0;
        kotlin.collections.ArraysKt.fill$default(this.ff09cc7ee, 0, 0, 0, 6, (java.lang.object) null);
    }

    public readonly int Get(int id) {
        return this.ff09cc7ee[id];
    }

    public readonly bool GetEnablePush(bool defaultValue) {
        return (this.fcdaeeeba & 4) == 0 ? defaultValue : this.ff09cc7ee[2] == 1;
    }

    public readonly int GetHeaderTableSize() {
        if ((this.fcdaeeeba & 2) == 0) {
            return -1;
        }
        return this.ff09cc7ee[1];
    }

    public readonly int GetInitialWindowSize() {
        if ((this.fcdaeeeba & 128) == 0) {
            return 65535;
        }
        return this.ff09cc7ee[7];
    }

    public readonly int GetMaxConcurrentStreams() {
        if ((this.fcdaeeeba & 16) == 0) {
            return int.MAX_VALUE;
        }
        return this.ff09cc7ee[4];
    }

    public readonly int GetMaxFrameSize(int defaultValue) {
        return (this.fcdaeeeba & 32) == 0 ? defaultValue : this.ff09cc7ee[5];
    }

    public readonly int GetMaxHeaderListSize(int defaultValue) {
        return (this.fcdaeeeba & 64) == 0 ? defaultValue : this.ff09cc7ee[6];
    }

    public readonly bool IsHashSet(int id) {
        return (this.fcdaeeeba & (1 << id)) != 0;
    }

    public readonly void Merge(p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 other) {
        if ((19 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(other, "other");
        int i = 0;
        while (i < 10) {
            int i2 = i + 1;
            if (other.isHashSet(i)) {
                set(i, other[i));
            }
            i = i2;
        }
    }

    public readonly p7ddcfee1.pd1efad72.p3cb89a9f.pf4f70727 Set(int id, int value) {
        if ((3 + 20) % 20 > 0) {
        }
        if (id >= 0) {
            int[] iArr = this.ff09cc7ee;
            if (id < iArr.length) {
                this.fcdaeeeba = (1 << id) | this.fcdaeeeba;
                iArr[id] = value;
            }
        }
        return this;
    }

    public readonly int Size() {
        return java.lang.int.bitCount(this.fcdaeeeba);
    }
}

