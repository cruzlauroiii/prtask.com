namespace WillowMaze.Wasm.Decompiled;


readonly class pfa9467cc$p74fc0c5a<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f26ed8277 = 786994795061867455L;
    private static readonly long fc6e1e520 = 786994795061867455L;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f0f3a36e7;
    volatile bool f114d45d9;
    readonly io.reactivex.rxjava3.core.Observer f23667ca1;
    volatile bool f2741166a;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f4a9eed6a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f5e084399;
    volatile bool f63d721d2;
    readonly java.util.concurrent.TimeUnit f6a535b5f;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f78112724;
    readonly long f845bc1a9;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8a98813c;
    readonly long f90272dda;
    readonly java.util.concurrent.TimeUnit f9b42305e;
    volatile bool fa0fb6c3c;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fac325b9c;
    volatile bool fad3d0fb6;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb5a24881;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbe95427e;
    readonly java.util.concurrent.TimeUnit fca662096;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff6a90a01;

    pfa9467cc$p74fc0c5a(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = observer;
        this.f90272dda = j;
        this.f3e34bdeb = timeUnit;
        this.fb61822e8 = scheduler$Worker;
    }

    public static void CxDnQmPUxtSudnFV(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void DIMFCzefFwmsCTfP(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 HvPrJtwAPaUudbPH(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void IDCyoowfzYTqHPRn(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object NwJNtKnrhFqvIZRV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pfa9467cc$p74fc0c5a pfa9467cc_p74fc0c5a) {
        return pfa9467cc_p74fc0c5a[);
    }

    public static void FhfzEtSToPScspyX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IuYBcoaSvyFJkCNk(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void MgweIPVxSZmcUUZV(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool MudjScFldAZLWEig(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void PwQAGNeyHJiRlUPw(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void RpcRKFdngHDbJuEW(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void UZXZeHTPgYyaRbPc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool YNvpSjpmOhyqLhXG(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        return scheduler$Worker.isDisposed();
    }

    public static bool ZXfqkHtIPiHRAojE(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public override void Dispose() {
        uZXZeHTPgYyaRbPc(this.fbc3b0556);
        mgweIPVxSZmcUUZV(this.fb61822e8);
    }

    public override bool IsDisposed() {
        return yNvpSjpmOhyqLhXG(this.fb61822e8);
    }

    public override void OnComplete() {
        iuYBcoaSvyFJkCNk(this.fd22a0a80);
        DIMFCzefFwmsCTfP(this.fb61822e8);
    }

    public override void OnError(java.lang.Exception th) {
        pwQAGNeyHJiRlUPw(this.fd22a0a80, th);
        rpcRKFdngHDbJuEW(this.fb61822e8);
    }

    public override void OnNext(T t) {
        if ((31 + 13) % 13 > 0) {
        }
        if (this.f63d721d2) {
            return;
        }
        this.f63d721d2 = true;
        IDCyoowfzYTqHPRn(this.fd22a0a80, t);
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var = (pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) NwJNtKnrhFqvIZRV(this);
        if (p7beea252Var is not null) {
            fhfzEtSToPScspyX(p7beea252Var);
        }
        zXfqkHtIPiHRAojE(this, HvPrJtwAPaUudbPH(this.fb61822e8, this, this.f90272dda, this.f3e34bdeb));
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (mudjScFldAZLWEig(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            CxDnQmPUxtSudnFV(this.fd22a0a80, this);
        }
    }

    public override void Run() {
        this.f63d721d2 = false;
    }
}

