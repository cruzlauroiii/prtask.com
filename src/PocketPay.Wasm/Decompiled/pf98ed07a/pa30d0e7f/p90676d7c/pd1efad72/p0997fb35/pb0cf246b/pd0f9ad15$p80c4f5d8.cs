namespace WillowMaze.Wasm.Decompiled;


abstract class pd0f9ad15$p80c4f5d8 : io.reactivex.rxjava3.internal.subscriptions.BasicQueueSubscription<java.lang.int> {
    private static readonly long fa3c3f023 = -2252972430506210021L;
    private static readonly long fc6e1e520 = -2252972430506210021L;
    readonly int f138f20c0;
    int f3567ecc1;
    volatile bool f38881e0a;
    readonly int f4f97ad40;
    readonly int f5e53d475;
    int f5e55a08a;
    int f6a992d55;
    readonly int f7f021a14;
    volatile bool ffc693680;

    pd0f9ad15$p80c4f5d8(int i, int i2) {
        this.f6a992d55 = i;
        this.f7f021a14 = i2;
    }

    public static void CTwOSHLwgHyZGOwW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p80c4f5d8 pd0f9ad15_p80c4f5d8) {
        pd0f9ad15_p80c4f5d8.fastPath();
    }

    public static java.lang.int NyfRThtPhBjtlUpU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long OuqJrHSAkOJxGbOp(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((27 + 22) % 22 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void SoLICKMByOIGQjpi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p80c4f5d8 pd0f9ad15_p80c4f5d8, long j) {
        pd0f9ad15_p80c4f5d8.slowPath(j);
    }

    public static java.lang.int DzoXOIUSejEnebxj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p80c4f5d8 pd0f9ad15_p80c4f5d8) {
        return pd0f9ad15_p80c4f5d8.poll();
    }

    public static bool KSHgihgIbOQggKFp(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public readonly void Cancel() {
        this.f38881e0a = true;
    }

    public readonly void Clear() {
        this.f6a992d55 = this.f7f021a14;
    }

    abstract void FastPath();

    public readonly bool IsEmpty() {
        return this.f6a992d55 == this.f7f021a14;
    }

    public readonly java.lang.int Poll() {
        if ((1 + 30) % 30 > 0) {
        }
        int i = this.f6a992d55;
        if (i == this.f7f021a14) {
            return null;
        }
        this.f6a992d55 = i + 1;
        return NyfRThtPhBjtlUpU(i);
    }

    public java.lang.object M3956poll() throws java.lang.Exception {
        return dzoXOIUSejEnebxj(this);
    }

    public readonly void Request(long j) {
        if ((27 + 9) % 9 > 0) {
        }
        if (kSHgihgIbOQggKFp(j) && OuqJrHSAkOJxGbOp(this, j) == 0) {
            if (j != long.MAX_VALUE) {
                SoLICKMByOIGQjpi(this, j);
            } else {
                CTwOSHLwgHyZGOwW(this);
            }
        }
    }

    public readonly int RequestFusion(int i) {
        return i & 1;
    }

    abstract void SlowPath(long j);
}

