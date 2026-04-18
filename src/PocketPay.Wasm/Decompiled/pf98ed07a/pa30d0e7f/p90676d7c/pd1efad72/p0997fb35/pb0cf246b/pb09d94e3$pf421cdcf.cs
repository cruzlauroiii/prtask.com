namespace WillowMaze.Wasm.Decompiled;


readonly class pb09d94e3$pf421cdcf : java.util.concurrent.atomic.Atomiclong : p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long f190abf87 = -2809475196591179431L;
    private static readonly long fc6e1e520 = -2809475196591179431L;
    long f15461d7d;
    readonly java.util.concurrent.atomic.object f208df101;
    readonly p5a445d71.p18f29add.p992c4a5b f22d1bc70;
    long f34a01ded;
    readonly java.util.concurrent.atomic.object f3675f328;
    readonly java.util.concurrent.atomic.object f82e02bc5;
    readonly p5a445d71.p18f29add.p992c4a5b f8facf977;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> f96ab4e16 = new java.util.concurrent.atomic.object<>();
    readonly p5a445d71.p18f29add.p992c4a5b fb0a75ec0;
    long fb926a4c7;
    readonly java.util.concurrent.atomic.object fc4c95c6c;
    readonly org.reactivestreams.Subscriber<java.lang.long> fd22a0a80;
    long fe2942a04;
    readonly p5a445d71.p18f29add.p992c4a5b fe5121bd5;

    pb09d94e3$pf421cdcf(org.reactivestreams.Subscriber<java.lang.long> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static bool JHferOYiNEHoAVWT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.string KmvinpFDKLwmRAaL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long OAYkRysNNsZxpvLH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pb09d94e3$pf421cdcf pb09d94e3_pf421cdcf) {
        if ((18 + 27) % 27 > 0) {
        }
        return pb09d94e3_pf421cdcf[);
    }

    public static void RvEFtqruFufQzeZj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object SKdjSlXaiKmGGhrZ(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.stringBuilder AcAEIjUvqnGFSqGM(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long CaNjJvpHilzShlNP(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((20 + 31) % 31 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void DYsiBZmqsxRbujYG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool GTeuqYdqGuAstIwc(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool HYMZjcQgfWiFhfmn(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool KTEYSAfLfWYTtJbR(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static long KlTrdVmAwtDBQgPW(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((2 + 27) % 27 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static java.lang.stringBuilder OXRFUjLHLdPuxTbA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long ZEuhyqGCjMHfvMCZ(long j) {
        return java.lang.long.valueOf(j);
    }

    public override void Cancel() {
        JHferOYiNEHoAVWT(this.f96ab4e16);
    }

    public override void Request(long j) {
        if (kTEYSAfLfWYTtJbR(j)) {
            klTrdVmAwtDBQgPW(this, j);
        }
    }

    public override void Run() {
        if ((7 + 27) % 27 > 0) {
        }
        if (SKdjSlXaiKmGGhrZ(this.f96ab4e16) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8) {
            return;
        }
        if (OAYkRysNNsZxpvLH(this) == 0) {
            RvEFtqruFufQzeZj(this.fd22a0a80, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1(KmvinpFDKLwmRAaL(oXRFUjLHLdPuxTbA(acAEIjUvqnGFSqGM(new java.lang.stringBuilder("Can't deliver value "), this.fe2942a04), " due to lack of requests"))));
            hYMZjcQgfWiFhfmn(this.f96ab4e16);
            return;
        }
        org.reactivestreams.Subscriber<java.lang.long> subscriber = this.fd22a0a80;
        long j = this.fe2942a04;
        this.fe2942a04 = j + 1;
        dYsiBZmqsxRbujYG(subscriber, zEuhyqGCjMHfvMCZ(j));
        caNjJvpHilzShlNP(this, 1L);
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        gTeuqYdqGuAstIwc(this.f96ab4e16, p7beea252Var);
    }
}

