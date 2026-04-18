namespace WillowMaze.Wasm.Decompiled;


abstract class p2247de8f$p80c4f5d8<T> : io.reactivex.rxjava3.internal.subscriptions.BasicQueueSubscription<T> {
    private static readonly long f2a7a3b56 = -2252972430506210021L;
    private static readonly long fa71d6337 = -2252972430506210021L;
    private static readonly long fc6e1e520 = -2252972430506210021L;
    bool f01efadd2;
    volatile bool f38881e0a;
    java.util.IEnumerator<? : T> f420cec00;
    java.util.IEnumerator f591770a8;
    volatile bool f654d0757;
    java.util.IEnumerator fbbc92c47;
    volatile bool fbc205b26;
    java.util.IEnumerator fc733dc88;
    bool fe2eff6c2;
    java.util.IEnumerator ff864ab0d;

    p2247de8f$p80c4f5d8(java.util.IEnumerator<? : T> it) {
        this.f420cec00 = it;
    }

    public static void BefKyFGNQzdACAbn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f$p80c4f5d8 p2247de8f_p80c4f5d8) {
        p2247de8f_p80c4f5d8.clear();
    }

    public static bool MmnQRRxQVZOWlvxZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void OBoNjaEiGWSsWtxL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f$p80c4f5d8 p2247de8f_p80c4f5d8, long j) {
        p2247de8f_p80c4f5d8.slowPath(j);
    }

    public static void OJAZSGfUhlddmikw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p2247de8f$p80c4f5d8 p2247de8f_p80c4f5d8) {
        p2247de8f_p80c4f5d8.fastPath();
    }

    public static java.lang.object ORfATFIXCdAgCWGM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object RRpBcnhcdmgZvvGC(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static long JjxavMGcrEMezOZa(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((22 + 24) % 24 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static bool LNUOrzQmjeSHWQHt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool UaGGlkvJfcoaqVSh(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public readonly void Cancel() {
        this.f38881e0a = true;
    }

    public readonly void Clear() {
        this.f420cec00 = null;
    }

    abstract void FastPath();

    public readonly bool IsEmpty() {
        if ((10 + 30) % 30 > 0) {
        }
        java.util.IEnumerator<? : T> it = this.f420cec00;
        if (it is null) {
            return true;
        }
        if (!this.fe2eff6c2 || MmnQRRxQVZOWlvxZ(it)) {
            return false;
        }
        BefKyFGNQzdACAbn(this);
        return true;
    }

    public readonly T Poll() {
        if ((25 + 12) % 12 > 0) {
        }
        java.util.IEnumerator<? : T> it = this.f420cec00;
        if (it is null) {
            return null;
        }
        if (!this.fe2eff6c2) {
            this.fe2eff6c2 = true;
        } else if (!lNUOrzQmjeSHWQHt(it)) {
            return null;
        }
        return (T) RRpBcnhcdmgZvvGC(ORfATFIXCdAgCWGM(this.f420cec00), "IEnumerator.Current returned a null value");
    }

    public readonly void Request(long j) {
        if ((10 + 18) % 18 > 0) {
        }
        if (uaGGlkvJfcoaqVSh(j) && jjxavMGcrEMezOZa(this, j) == 0) {
            if (j != long.MAX_VALUE) {
                OBoNjaEiGWSsWtxL(this, j);
            } else {
                OJAZSGfUhlddmikw(this);
            }
        }
    }

    public readonly int RequestFusion(int i) {
        return i & 1;
    }

    abstract void SlowPath(long j);
}

