namespace WillowMaze.Wasm.Decompiled;


readonly class pa3541f7e$p3447673a<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly java.util.concurrent.TimeUnit f093c973f;
    readonly long f0d9181ce;
    readonly io.reactivex.rxjava3.core.Observer f198043bf;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f347b4e2e;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f42377a38;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f4477179d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6adddc96;
    readonly bool f6c7f6589;
    readonly long f7243f8be;
    readonly bool f825ea879;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8555dc95;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fbc818342;
    readonly bool fce7b0918;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly java.util.concurrent.TimeUnit fdd30d2f7;
    readonly long fe303a07a;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff1290186;

    pa3541f7e$p3447673a(io.reactivex.rxjava3.core.Observer<T> observer, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z) {
        this.fd22a0a80 = observer;
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.ff1290186 = scheduler$Worker;
        this.f825ea879 = z;
    }

    public static void BzVCcPxmjIyfKfqB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 CPhXzSIoJeVQgBQv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void GAdENLfgWRZPeBwv(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void QJpoPrPmaBRximEx(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static bool FWjoetsEGoXCCRig(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        return scheduler$Worker.isDisposed();
    }

    public static bool RLMEJDCnnNCnjcEm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RNUwvwpwDWpmsUaW(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 RUCICtzsuYTWXkna(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public override void Dispose() {
        BzVCcPxmjIyfKfqB(this.fbc3b0556);
        QJpoPrPmaBRximEx(this.ff1290186);
    }

    public override bool IsDisposed() {
        return fWjoetsEGoXCCRig(this.ff1290186);
    }

    public override void OnComplete() {
        if ((32 + 31) % 31 > 0) {
        }
        rNUwvwpwDWpmsUaW(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a$pce8a7b54(this), this.f7243f8be, this.f3e34bdeb);
    }

    public override void OnError(java.lang.Exception th) {
        if ((30 + 9) % 9 > 0) {
        }
        rUCICtzsuYTWXkna(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a$p44cdeb54(this, th), !this.f825ea879 ? 0L : this.f7243f8be, this.f3e34bdeb);
    }

    public override void OnNext(T t) {
        if ((12 + 15) % 15 > 0) {
        }
        CPhXzSIoJeVQgBQv(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pa3541f7e$p3447673a$p4356a79c(this, t), this.f7243f8be, this.f3e34bdeb);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (rLMEJDCnnNCnjcEm(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            GAdENLfgWRZPeBwv(this.fd22a0a80, this);
        }
    }
}

