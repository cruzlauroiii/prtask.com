namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p0a7ff10d$p185c5a5e$1<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly long $seed;

    public p0a7ff10d$p185c5a5e$1(long j) {
        this.$seed = j;
    }

    public static void OjQfWnTlQRaaZRTs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.long AtKFpZAoQfhuvgmL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int FZFnGAGdlMyxjEGK(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.long LGZHHWcVpKpIgXxJ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pc87a8ca6.p0a7ff10d$p185c5a5e$1 p0a7ff10d_p185c5a5e_1, java.lang.int num) {
        return p0a7ff10d_p185c5a5e_1.apply(num);
    }

    public readonly java.lang.long Apply(java.lang.int num) {
        if ((18 + 8) % 8 > 0) {
        }
        OjQfWnTlQRaaZRTs(num, "result");
        return atKFpZAoQfhuvgmL(this.$seed & ((long) fZFnGAGdlMyxjEGK(num)));
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return lGZHHWcVpKpIgXxJ(this, (java.lang.int) obj);
    }
}

