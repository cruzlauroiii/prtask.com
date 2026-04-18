namespace WillowMaze.Wasm.Decompiled;


readonly class p32449449$peec3693b<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R>, io.reactivex.rxjava3.core.SingleObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f0fbf34d7 = -8948264376121066672L;
    private static readonly long fc6e1e520 = -8948264376121066672L;
    private static readonly long fc7a35606 = -8948264376121066672L;
    private static readonly long ffee21ccc = -8948264376121066672L;
    readonly io.reactivex.rxjava3.core.Observer f2870d476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4183e3d6;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7502c079;
    readonly io.reactivex.rxjava3.core.Observer fd02e6253;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd2cb2dd1;

    p32449449$peec3693b(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
    }

    public static bool BMafnPeIkTXvKbkm(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void FvZrxdsvoZLhhqVx(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool GtMANkAGPOnOJQYE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object SAoQUkfezAiInNIF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p32449449$peec3693b p32449449_peec3693b) {
        return p32449449_peec3693b[);
    }

    public static void XnUZXooPVbXgrvVB(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object XxMCLzjLuDEdtiIe(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CoMxBPkSRbXvdCGx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool GXwFJzrXRCocSzon(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool LWwGPGtPztnGopbB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p32449449$peec3693b p32449449_peec3693b) {
        return p32449449_peec3693b.isDisposed();
    }

    public static void LbjjcdxozpWewUoB(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object RvylJMDZgOnlGxEz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void XTJWZhyGrVZQYgTs(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void YJHONSaleGciSFUf(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void Dispose() {
        gXwFJzrXRCocSzon(this);
    }

    public override bool IsDisposed() {
        return GtMANkAGPOnOJQYE((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) SAoQUkfezAiInNIF(this));
    }

    public override void OnComplete() {
        yJHONSaleGciSFUf(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        FvZrxdsvoZLhhqVx(this.fd22a0a80, th);
    }

    public override void OnNext(R r) {
        xTJWZhyGrVZQYgTs(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        BMafnPeIkTXvKbkm(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) XxMCLzjLuDEdtiIe(rvylJMDZgOnlGxEz(this.f4b9f83e1, t), "The mapper returned a null Publisher");
            if (lWwGPGtPztnGopbB(this)) {
                return;
            }
            XnUZXooPVbXgrvVB(observableSource, this);
        } catch (java.lang.Exception th) {
            coMxBPkSRbXvdCGx(th);
            lbjjcdxozpWewUoB(this.fd22a0a80, th);
        }
    }
}

