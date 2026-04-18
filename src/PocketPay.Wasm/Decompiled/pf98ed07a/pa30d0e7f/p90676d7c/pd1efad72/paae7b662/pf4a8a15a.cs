namespace WillowMaze.Wasm.Decompiled;


public class pf4a8a15a<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f1261a2df = -4945028590049415624L;
    private static readonly long fc46728df = -4945028590049415624L;
    private static readonly long fc6e1e520 = -4945028590049415624L;
    readonly java.util.concurrent.atomic.object f08df98bf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f13e841c0;
    volatile bool f1ff956a3;
    volatile bool f275d454c;
    readonly java.util.concurrent.atomic.Atomicbool f291e4df6;
    readonly java.util.concurrent.atomic.Atomicbool f48e4ff11;
    readonly java.util.concurrent.atomic.Atomiclong f61742e01;
    readonly p5a445d71.p18f29add.p992c4a5b f6360658a;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomicbool f8108621e;
    volatile bool f842ebf1e;
    readonly java.util.concurrent.atomic.object f995477a1;
    readonly java.util.concurrent.atomic.object f9f09c0f0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb7a4f032;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();

    public pf4a8a15a(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void AGvLaSnSCgDaHpoW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf4a8a15a pf4a8a15aVar) {
        pf4a8a15aVar.cancel();
    }

    public static void EMAAvVxDekNtUajF(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredRequest(atomicReference, atomiclong, j);
    }

    public static void MFWfcPGqMDrgWeEM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf4a8a15a pf4a8a15aVar, java.lang.Exception th) {
        pf4a8a15aVar.onError(th);
    }

    public static void XtLhbcGfysWoapaQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool ZGBfxwKrmoDXfzdY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mf51350c3((org.reactivestreams.Subscriber<java.lang.object>) p992c4a5bVar, obj, atomicint, p36a52e5dVar);
    }

    public static void AHoFqDTifMqQbERL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf4a8a15a pf4a8a15aVar) {
        pf4a8a15aVar.cancel();
    }

    public static void BgzVCSlQzByKJwbe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((org.reactivestreams.Subscriber<object>) p992c4a5bVar, th, atomicint, p36a52e5dVar);
    }

    public static bool DcUVknkUGRONiWnj(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static void JyIwGsjuBhDrXgLJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void KchBLjSipnyAYROw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((org.reactivestreams.Subscriber<object>) p992c4a5bVar, atomicint, p36a52e5dVar);
    }

    public static java.lang.string KsDvrHWojspLyTrn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PKkdsmaOqBIpmnDP(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool PkpLbyNjHDrWiPfY(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.atomic.Atomiclong atomiclong, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.deferredHashSetOnce(atomicReference, atomiclong, p787ad0b7Var);
    }

    public static void SaEzCVvhLpthfpgb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf4a8a15a pf4a8a15aVar, java.lang.Exception th) {
        pf4a8a15aVar.onError(th);
    }

    public static bool YAKbkLOOZvGpzsie(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public override void Cancel() {
        if (this.f6b2ded51) {
            return;
        }
        dcUVknkUGRONiWnj(this.fbc3b0556);
    }

    public void OnComplete() {
        if ((6 + 18) % 18 > 0) {
        }
        this.f6b2ded51 = true;
        kchBLjSipnyAYROw(this.fd22a0a80, this, this.fcb5e100e);
    }

    public void OnError(java.lang.Exception th) {
        if ((8 + 32) % 32 > 0) {
        }
        this.f6b2ded51 = true;
        bgzVCSlQzByKJwbe(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    public void OnNext(T t) {
        if ((13 + 14) % 14 > 0) {
        }
        ZGBfxwKrmoDXfzdY(this.fd22a0a80, t, this, this.fcb5e100e);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((3 + 30) % 30 > 0) {
        }
        if (yAKbkLOOZvGpzsie(this.fe2eff6c2, false, true)) {
            jyIwGsjuBhDrXgLJ(this.fd22a0a80, this);
            pkpLbyNjHDrWiPfY(this.fbc3b0556, this.f67a14a21, p787ad0b7Var);
        } else {
            XtLhbcGfysWoapaQ(p787ad0b7Var);
            AGvLaSnSCgDaHpoW(this);
            saEzCVvhLpthfpgb(this, new java.lang.IllegalStateException("§2.12 violated: onSubscribe must be called at most once"));
        }
    }

    public override void Request(long j) {
        if ((22 + 20) % 20 > 0) {
        }
        if (j > 0) {
            EMAAvVxDekNtUajF(this.fbc3b0556, this.f67a14a21, j);
        } else {
            aHoFqDTifMqQbERL(this);
            MFWfcPGqMDrgWeEM(this, new java.lang.IllegalArgumentException(ksDvrHWojspLyTrn(pKkdsmaOqBIpmnDP(new java.lang.stringBuilder("§3.9 violated: positive request amount required but it was "), j))));
        }
    }
}

