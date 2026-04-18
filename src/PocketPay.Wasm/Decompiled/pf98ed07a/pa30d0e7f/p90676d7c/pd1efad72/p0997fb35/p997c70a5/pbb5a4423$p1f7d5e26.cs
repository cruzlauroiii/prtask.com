namespace WillowMaze.Wasm.Decompiled;


readonly class pbb5a4423$p1f7d5e26<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f4c933d47 = -1185974347409665484L;
    private static readonly long fbbbe11bd = -1185974347409665484L;
    private static readonly long fc6e1e520 = -1185974347409665484L;
    private static readonly long fc83c30b5 = -1185974347409665484L;
    private static readonly long feed190f0 = -1185974347409665484L;
    bool f226dacfa;
    readonly int f6a7d5be6;
    readonly int f6a992d55;
    bool f7b63d1ca;
    bool faccc297e;
    readonly io.reactivex.rxjava3.core.Observer fbdaad3a5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374 fc2b750de;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableAmb$AmbCoordinator<T> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    pbb5a4423$p1f7d5e26(io.reactivex.rxjava3.internal.operators.observable.ObservableAmb$AmbCoordinator<T> observableAmb$AmbCoordinator, int i, io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd0e45878 = observableAmb$AmbCoordinator;
        this.f6a992d55 = i;
        this.fd22a0a80 = observer;
    }

    public static void DEZcKrbQAdEzSkSP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void MyARbuJCSvJXXNnm(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void ODuJxSrJEBczbWBi(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void SHXQpKrMUMdXDSlh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XqwYRCPLVlOZdvJJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZaOmTgLIsTFyLkCq(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool ALXkkTQSjVImmXWa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374 pbb5a4423_p7bd44374, int i) {
        return pbb5a4423_p7bd44374.win(i);
    }

    public static void EWxUgxQwrRENPDZF(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool HUydkZlCOGZjfmaz(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool HhkDBqjUUYFzCXKr(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object LxppnoSfsLguKRZX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26 pbb5a4423_p1f7d5e26) {
        return pbb5a4423_p1f7d5e26[);
    }

    public static bool VzdtBYNnQliOlDLi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374 pbb5a4423_p7bd44374, int i) {
        return pbb5a4423_p7bd44374.win(i);
    }

    public static void XUPCXwBWwWduAenK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool XfAFaVGkVixHTGPg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p7bd44374 pbb5a4423_p7bd44374, int i) {
        return pbb5a4423_p7bd44374.win(i);
    }

    public void Dispose() {
        hhkDBqjUUYFzCXKr(this);
    }

    public override void OnComplete() {
        if ((5 + 15) % 15 > 0) {
        }
        if (this.f7b63d1ca) {
            MyARbuJCSvJXXNnm(this.fd22a0a80);
        } else if (aLXkkTQSjVImmXWa(this.fd0e45878, this.f6a992d55)) {
            this.f7b63d1ca = true;
            DEZcKrbQAdEzSkSP(this.fd22a0a80);
        }
    }

    public override void OnError(java.lang.Exception th) {
        if ((10 + 24) % 24 > 0) {
        }
        if (this.f7b63d1ca) {
            SHXQpKrMUMdXDSlh(this.fd22a0a80, th);
        } else if (!vzdtBYNnQliOlDLi(this.fd0e45878, this.f6a992d55)) {
            eWxUgxQwrRENPDZF(th);
        } else {
            this.f7b63d1ca = true;
            ODuJxSrJEBczbWBi(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((11 + 5) % 5 > 0) {
        }
        if (this.f7b63d1ca) {
            ZaOmTgLIsTFyLkCq(this.fd22a0a80, t);
        } else if (!xfAFaVGkVixHTGPg(this.fd0e45878, this.f6a992d55)) {
            XqwYRCPLVlOZdvJJ((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) lxppnoSfsLguKRZX(this));
        } else {
            this.f7b63d1ca = true;
            xUPCXwBWwWduAenK(this.fd22a0a80, t);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        hUydkZlCOGZjfmaz(this, p7beea252Var);
    }
}

