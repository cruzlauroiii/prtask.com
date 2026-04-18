namespace WillowMaze.Wasm.Decompiled;


readonly class pb32a6fcd$pba31132c<T> : io.reactivex.rxjava3.core.Observer<T> {
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f1a4f6e5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f504ec2fa;
    readonly io.reactivex.rxjava3.core.Observer f5302ca3a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f63b0913d;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f6f383ec0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f79106d6f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
    bool f90971ef6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9eaa4be2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fa7b2a2ac;
    bool fac1e8c87;
    bool fb833a43b;
    bool fc0f1c8ce;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fe2eff6c2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fe83af87a;

    pb32a6fcd$pba31132c(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> function) {
        this.fd22a0a80 = observer;
        this.f1a4f6e5a = function;
    }

    public static void GvifvZjXubzwJSZh(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void HaCLUSotCeijXRZV(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool SOZuAHkTzjJNPwuv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void AYRyzJRvFtEOaxuj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void DZABTAlUkKcLrDkL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.Exception IetNUyPimxxCMyfK(java.lang.NullPointerException nullPointerException, java.lang.Exception th) {
        return nullPointerException.initCause(th);
    }

    public static java.lang.object SzaWupFbvaISZoQq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void SzoyXTIhumjuJveF(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void WwNtdOcoJqMwYwoe(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void YDUUXlowUOALJGEw(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void ZQQSyBQOIMPaDPWV(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        this.fe2eff6c2 = true;
        GvifvZjXubzwJSZh(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((25 + 10) % 10 > 0) {
        }
        if (this.fe2eff6c2) {
            if (this.f6b2ded51) {
                aYRyzJRvFtEOaxuj(th);
                return;
            } else {
                zQQSyBQOIMPaDPWV(this.fd22a0a80, th);
                return;
            }
        }
        this.fe2eff6c2 = true;
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) szaWupFbvaISZoQq(this.f1a4f6e5a, th);
            if (observableSource is not null) {
                yDUUXlowUOALJGEw(observableSource, this);
                return;
            }
            java.lang.NullPointerException nullPointerException = new java.lang.NullPointerException("Observable is null");
            ietNUyPimxxCMyfK(nullPointerException, th);
            szoyXTIhumjuJveF(this.fd22a0a80, nullPointerException);
        } catch (java.lang.Exception th2) {
            dZABTAlUkKcLrDkL(th2);
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            wwNtdOcoJqMwYwoe(observer, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        HaCLUSotCeijXRZV(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        SOZuAHkTzjJNPwuv(this.f79106d6f, p7beea252Var);
    }
}

