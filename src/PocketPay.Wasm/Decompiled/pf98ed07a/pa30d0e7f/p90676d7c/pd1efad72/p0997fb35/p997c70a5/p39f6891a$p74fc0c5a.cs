namespace WillowMaze.Wasm.Decompiled;


readonly class p39f6891a$p74fc0c5a<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.TimeUnit f03c30c92;
    volatile long f1a3be06b;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1d4281e2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f24bd9d4c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f2c127bf3;
    bool f36dbd51d;
    readonly io.reactivex.rxjava3.core.Observer f3d77263c;
    readonly io.reactivex.rxjava3.core.Observer f3e1d4377;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f433c061a;
    volatile long f4ad328a8;
    bool f51f78f71;
    readonly java.util.concurrent.TimeUnit f5eade18f;
    volatile long f6a992d55;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f8d4997b9;
    readonly io.reactivex.rxjava3.core.Observer f8d89758b;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit f93407eae;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f98182494;
    readonly io.reactivex.rxjava3.core.Observer f9af2a295;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9c6538d6;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f9f0bdbfd;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 faabbbbd7;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fd8f75b56;
    volatile long fdfd4aee2;
    readonly java.util.concurrent.TimeUnit ff2e17f33;

    p39f6891a$p74fc0c5a(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = observer;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 AZCUWghIJDgqCDOj(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void AtrjNQQeZUbuollr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void DsMhbmkMROahPWvJ(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void HaAqnouOkTarThYK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void PAtaGAVfOVoYTLmk(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void RyDHLyuvRitQwJJZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void UjdcXhVtLBGFaCsJ(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void XsHyxNgHOxamKQIE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8) {
        p39f6891a_p25b223f8.dispose();
    }

    public static void AHnbYXeyAGMVQGls(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void CycDllKKKjVezjDX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8) {
        p39f6891a_p25b223f8.run();
    }

    public static void NjWnnSTRZHVNKFjE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void RPQmHmhFZYmtTmoo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TtvpFKxUemlkmAKe(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool TuMBSFZJQIIsbUSF(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        return scheduler$Worker.isDisposed();
    }

    public static void WNJgyTxLUWKYhxAn(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XTuNNFNVzuZDKeJB(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void YocsvZvrqbrEZjne(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p39f6891a_p25b223f8.setResource(p7beea252Var);
    }

    public static bool ZSBuvnGyiiqAILAx(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public override void Dispose() {
        PAtaGAVfOVoYTLmk(this.fbc3b0556);
        DsMhbmkMROahPWvJ(this.fb61822e8);
    }

    void emit(long j, T t, io.reactivex.rxjava3.internal.operators.observable.ObservableDebounceTimed$DebounceEmitter<T> observableDebounceTimed$DebounceEmitter) {
        if ((10 + 17) % 17 > 0) {
        }
        if (j != this.f6a992d55) {
            return;
        }
        aHnbYXeyAGMVQGls(this.fd22a0a80, t);
        XsHyxNgHOxamKQIE(observableDebounceTimed$DebounceEmitter);
    }

    public override bool IsDisposed() {
        return tuMBSFZJQIIsbUSF(this.fb61822e8);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.f2c127bf3;
        if (p7beea252Var is not null) {
            RyDHLyuvRitQwJJZ(p7beea252Var);
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8) p7beea252Var;
        if (p39f6891a_p25b223f8 is not null) {
            cycDllKKKjVezjDX(p39f6891a_p25b223f8);
        }
        ttvpFKxUemlkmAKe(this.fd22a0a80);
        xTuNNFNVzuZDKeJB(this.fb61822e8);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            rPQmHmhFZYmtTmoo(th);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.f2c127bf3;
        if (p7beea252Var is not null) {
            njWnnSTRZHVNKFjE(p7beea252Var);
        }
        this.f6b2ded51 = true;
        wNJgyTxLUWKYhxAn(this.fd22a0a80, th);
        UjdcXhVtLBGFaCsJ(this.fb61822e8);
    }

    public override void OnNext(T t) {
        if ((23 + 10) % 10 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.f6a992d55 + 1;
        this.f6a992d55 = j;
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = this.f2c127bf3;
        if (p7beea252Var is not null) {
            AtrjNQQeZUbuollr(p7beea252Var);
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8 p39f6891a_p25b223f8 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p39f6891a$p25b223f8(t, j, this);
        this.f2c127bf3 = p39f6891a_p25b223f8;
        yocsvZvrqbrEZjne(p39f6891a_p25b223f8, AZCUWghIJDgqCDOj(this.fb61822e8, p39f6891a_p25b223f8, this.f90272dda, this.f3e34bdeb));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (zSBuvnGyiiqAILAx(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            HaAqnouOkTarThYK(this.fd22a0a80, this);
        }
    }
}

