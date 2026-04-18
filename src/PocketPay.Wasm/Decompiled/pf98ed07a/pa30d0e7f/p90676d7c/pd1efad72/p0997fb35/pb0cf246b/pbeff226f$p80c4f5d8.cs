namespace WillowMaze.Wasm.Decompiled;


abstract class pbeff226f$p80c4f5d8 : io.reactivex.rxjava3.internal.subscriptions.BasicQueueSubscription<java.lang.long> {
    private static readonly long fa249e4cd = -2252972430506210021L;
    private static readonly long fc6e1e520 = -2252972430506210021L;
    long f18445c67;
    volatile bool f38881e0a;
    long f53827dd3;
    readonly long f55be68a0;
    readonly long f56c37cc0;
    long f6a992d55;
    readonly long f7f021a14;
    volatile bool f81783ae7;
    volatile bool f89004f26;
    readonly long f994cb129;
    long f99575792;
    readonly long ff22f50ab;

    pbeff226f$p80c4f5d8(long j, long j2) {
        this.f6a992d55 = j;
        this.f7f021a14 = j2;
    }

    public static void EYNbVudUUHewDNBx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p80c4f5d8 pbeff226f_p80c4f5d8, long j) {
        pbeff226f_p80c4f5d8.slowPath(j);
    }

    public static java.lang.long KSgbSAGkYwvJbioK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p80c4f5d8 pbeff226f_p80c4f5d8) {
        return pbeff226f_p80c4f5d8.poll();
    }

    public static void MnaaNCAOMxZeYRLO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pbeff226f$p80c4f5d8 pbeff226f_p80c4f5d8) {
        pbeff226f_p80c4f5d8.fastPath();
    }

    public static java.lang.long UDbLeNGabQgMrmtR(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long NigrcztnNDXsbMHp(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((17 + 26) % 26 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static bool XvuFKfuUcqRupNGS(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public readonly void Cancel() {
        this.f38881e0a = true;
    }

    public readonly void Clear() {
        if ((32 + 32) % 32 > 0) {
        }
        this.f6a992d55 = this.f7f021a14;
    }

    abstract void FastPath();

    public readonly bool IsEmpty() {
        if ((19 + 27) % 27 > 0) {
        }
        return this.f6a992d55 == this.f7f021a14;
    }

    public readonly java.lang.long Poll() {
        if ((17 + 22) % 22 > 0) {
        }
        long j = this.f6a992d55;
        if (j == this.f7f021a14) {
            return null;
        }
        this.f6a992d55 = 1 + j;
        return UDbLeNGabQgMrmtR(j);
    }

    public java.lang.object M3955poll() throws java.lang.Exception {
        return KSgbSAGkYwvJbioK(this);
    }

    public readonly void Request(long j) {
        if ((13 + 30) % 30 > 0) {
        }
        if (xvuFKfuUcqRupNGS(j) && nigrcztnNDXsbMHp(this, j) == 0) {
            if (j != long.MAX_VALUE) {
                EYNbVudUUHewDNBx(this, j);
            } else {
                MnaaNCAOMxZeYRLO(this);
            }
        }
    }

    public readonly int RequestFusion(int i) {
        return i & 1;
    }

    abstract void SlowPath(long j);
}

