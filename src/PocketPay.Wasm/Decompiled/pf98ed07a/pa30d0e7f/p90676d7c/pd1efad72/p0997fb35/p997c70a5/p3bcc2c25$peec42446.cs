namespace WillowMaze.Wasm.Decompiled;


readonly class p3bcc2c25$peec42446<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f23d14dac = -7098360935104053232L;
    private static readonly long f9440e07b = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    long f2626772c;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    long f45c25196;
    readonly io.reactivex.rxjava3.core.ObservableSource f5fe850f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f6226f7cb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f6f4877fa;
    readonly io.reactivex.rxjava3.core.Observer f6fc9bcbf;
    long f7eed84dc;
    readonly io.reactivex.rxjava3.core.ObservableSource f8e020992;
    readonly io.reactivex.rxjava3.core.Observer f8ed36c2a;
    long f9fca5022;
    readonly io.reactivex.rxjava3.core.ObservableSource fc4c1e1d3;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.ObservableSource ff1ce5701;
    long ff5e89c67;

    p3bcc2c25$peec42446(io.reactivex.rxjava3.core.Observer<T> observer, long j, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.f6226f7cb = pa7808658Var;
        this.f36cd38f4 = observableSource;
        this.f2626772c = j;
    }

    public static void BuckcsviZHbIOYoS(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool FyFJrsEhLEMbiiyQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static bool JYbEMagoPrhRzAFd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var.isDisposed();
    }

    public static int KdfmpfNOevkwKCcl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bcc2c25$peec42446 p3bcc2c25_peec42446, int i) {
        return p3bcc2c25_peec42446.addAndGet(i);
    }

    public static int NrZeaOghOSfTeBwi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bcc2c25$peec42446 p3bcc2c25_peec42446) {
        return p3bcc2c25_peec42446.getAndIncrement();
    }

    public static void VLpPbbdNuYYFIXhv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bcc2c25$peec42446 p3bcc2c25_peec42446) {
        p3bcc2c25_peec42446.subscribeNext();
    }

    public static void GVbYDsfvutQnQzba(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void LrpcikLACAOFETqr(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void XEfYafiJbyAaRkYP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void OnComplete() {
        if ((15 + 18) % 18 > 0) {
        }
        long j = this.f2626772c;
        if (j != long.MAX_VALUE) {
            this.f2626772c = j - 1;
        }
        if (j == 0) {
            xEfYafiJbyAaRkYP(this.fd22a0a80);
        } else {
            VLpPbbdNuYYFIXhv(this);
        }
    }

    public override void OnError(java.lang.Exception th) {
        gVbYDsfvutQnQzba(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        BuckcsviZHbIOYoS(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        FyFJrsEhLEMbiiyQ(this.f6226f7cb, p7beea252Var);
    }

    void subscribeNext() {
        if ((10 + 22) % 22 > 0) {
        }
        if (NrZeaOghOSfTeBwi(this) != 0) {
            return;
        }
        int iKdfmpfNOevkwKCcl = 1;
        do {
            if (JYbEMagoPrhRzAFd(this.f6226f7cb)) {
                return;
            }
            lrpcikLACAOFETqr(this.f36cd38f4, this);
            iKdfmpfNOevkwKCcl = KdfmpfNOevkwKCcl(this, -iKdfmpfNOevkwKCcl);
        } while (iKdfmpfNOevkwKCcl != 0);
    }
}

