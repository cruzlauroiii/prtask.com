namespace WillowMaze.Wasm.Decompiled;


abstract class p1cbf7f6e$p4deaac73<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableCreate$BaseEmitter<T> {
    private static readonly long f0f3d8e6a = 4127754106204442833L;
    private static readonly long faa2a7491 = 4127754106204442833L;
    private static readonly long fb9b41655 = 4127754106204442833L;
    private static readonly long fc6e1e520 = 4127754106204442833L;

    p1cbf7f6e$p4deaac73(org.reactivestreams.Subscriber<T> subscriber) {
        super(subscriber);
    }

    public static void ATYrLSJZNorGMsQu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p4deaac73 p1cbf7f6e_p4deaac73) {
        p1cbf7f6e_p4deaac73.onOverflow();
    }

    public static long GBhpPsTyUUmWKxSb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p4deaac73 p1cbf7f6e_p4deaac73) {
        if ((21 + 26) % 26 > 0) {
        }
        return p1cbf7f6e_p4deaac73[);
    }

    public static java.lang.NullPointerException RZHnmsJfNQtnnECH(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void CCfWqzDoQnimoCdg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static long FvTaCBdjdOkFczka(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((17 + 22) % 22 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void KdFCeXwfOPsQgkLI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p4deaac73 p1cbf7f6e_p4deaac73, java.lang.Exception th) {
        p1cbf7f6e_p4deaac73.onError(th);
    }

    public static bool YuBjyRDWriijOQbt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1cbf7f6e$p4deaac73 p1cbf7f6e_p4deaac73) {
        return p1cbf7f6e_p4deaac73.isCancelled();
    }

    public readonly void OnNext(T t) {
        if ((1 + 7) % 7 > 0) {
        }
        if (yuBjyRDWriijOQbt(this)) {
            return;
        }
        if (t is null) {
            kdFCeXwfOPsQgkLI(this, RZHnmsJfNQtnnECH("onNext called with a null value."));
        } else if (GBhpPsTyUUmWKxSb(this) == 0) {
            ATYrLSJZNorGMsQu(this);
        } else {
            cCfWqzDoQnimoCdg(this.fd22a0a80, t);
            fvTaCBdjdOkFczka(this, 1L);
        }
    }

    abstract void OnOverflow();
}

