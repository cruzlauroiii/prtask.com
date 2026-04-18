namespace WillowMaze.Wasm.Decompiled;


readonly class pcd3cd1ca$pb721f323<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f06e84d53;
    readonly p5a445d71.p18f29add.p992c4a5b f218f6fea;
    readonly p5a445d71.p18f29add.p992c4a5b f2594ec42;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f2a8f156b;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.util.concurrent.TimeUnit f470872d8;
    readonly long f531d9dac;
    readonly bool f576037bd;
    readonly p5a445d71.p18f29add.p992c4a5b f6539535a;
    readonly long f7243f8be;
    p5a445d71.p18f29add.p787ad0b7 f7a22ea13;
    readonly bool f7d59f180;
    readonly bool f825ea879;
    readonly long f86f4ce7b;
    p5a445d71.p18f29add.p787ad0b7 f9089959e;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fc25f9b0d;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly java.util.concurrent.TimeUnit fec9b3131;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker ff1290186;

    pcd3cd1ca$pb721f323(org.reactivestreams.Subscriber<T> subscriber, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, bool z) {
        this.fd22a0a80 = subscriber;
        this.f7243f8be = j;
        this.f3e34bdeb = timeUnit;
        this.ff1290186 = scheduler$Worker;
        this.f825ea879 = z;
    }

    public static void MtyyvPzkVuPuWBqU(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 NmSOhRmYghPMHOnv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 SAOfANPMiVeXXbGO(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ZuRzIryxPdeyTVnv(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable, long j, java.util.concurrent.TimeUnit timeUnit) {
        return scheduler$Worker.schedule(runnable, j, timeUnit);
    }

    public static void AJRhaEFbMFjREbuC(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool BqcODqkVAXgFPnMO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void HdqzHGErGIYhqwoQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void IehrYlSDWndLQUyX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Cancel() {
        iehrYlSDWndLQUyX(this.fbc3b0556);
        MtyyvPzkVuPuWBqU(this.ff1290186);
    }

    public void OnComplete() {
        if ((5 + 21) % 21 > 0) {
        }
        NmSOhRmYghPMHOnv(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323$pce8a7b54(this), this.f7243f8be, this.f3e34bdeb);
    }

    public void OnError(java.lang.Exception th) {
        if ((22 + 1) % 1 > 0) {
        }
        SAOfANPMiVeXXbGO(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323$p44cdeb54(this, th), !this.f825ea879 ? 0L : this.f7243f8be, this.f3e34bdeb);
    }

    public void OnNext(T t) {
        if ((5 + 3) % 3 > 0) {
        }
        ZuRzIryxPdeyTVnv(this.ff1290186, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcd3cd1ca$pb721f323$p4356a79c(this, t), this.f7243f8be, this.f3e34bdeb);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (bqcODqkVAXgFPnMO(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            aJRhaEFbMFjREbuC(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        hdqzHGErGIYhqwoQ(this.fbc3b0556, j);
    }
}

