namespace WillowMaze.Wasm.Decompiled;


readonly class p9cfd2a4f$peec42446<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f7f19bd12 = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f0660be94;
    long f099ac384;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f09c848d2;
    long f2626772c;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Observer f444071af;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f4c08352b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f56e1724d;
    long f6d31c74e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f6f42d499;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f82b49d1c;
    long f8d5574f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f8f980ec5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fbc3b0556;
    readonly io.reactivex.rxjava3.core.ObservableSource fc00435de;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 feddd9515;
    long ff2078cf9;
    readonly io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> ff670ef68;

    p9cfd2a4f$peec42446(io.reactivex.rxjava3.core.Observer<T> observer, long j, io.reactivex.rxjava3.functions.Predicate<java.lang.Exception> predicate, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.fbc3b0556 = pa7808658Var;
        this.f36cd38f4 = observableSource;
        this.ff670ef68 = predicate;
        this.f2626772c = j;
    }

    public static void CrveTAJmMkqTZAgu(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void GnXfWXUyWBuWMdgZ(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void OSyatbjItGXfRkOS(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool SoTTYwmeeUSbfUCj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var.isDisposed();
    }

    public static void YaQTqKWLylmTAOoa(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool BkQkhbYmqbedhrYA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void IAiuwtmjfAySVBFM(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static int JNCOVlRTroJHHfgB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cfd2a4f$peec42446 p9cfd2a4f_peec42446, int i) {
        return p9cfd2a4f_peec42446.addAndGet(i);
    }

    public static bool PxWSeVotCqLnIOJB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static void QIycdhcGHYjwRsCG(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void RZxgaWzvEfIkwOho(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int TvscYoxeLwEFdKEe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cfd2a4f$peec42446 p9cfd2a4f_peec42446) {
        return p9cfd2a4f_peec42446.getAndIncrement();
    }

    public static void UaOVWDRMsYQzTAzl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cfd2a4f$peec42446 p9cfd2a4f_peec42446) {
        p9cfd2a4f_peec42446.subscribeNext();
    }

    public override void OnComplete() {
        iAiuwtmjfAySVBFM(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((7 + 28) % 28 > 0) {
        }
        long j = this.f2626772c;
        if (j != long.MAX_VALUE) {
            this.f2626772c = j - 1;
        }
        if (j == 0) {
            CrveTAJmMkqTZAgu(this.fd22a0a80, th);
            return;
        }
        try {
            if (bkQkhbYmqbedhrYA(this.ff670ef68, th)) {
                uaOVWDRMsYQzTAzl(this);
            } else {
                GnXfWXUyWBuWMdgZ(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            YaQTqKWLylmTAOoa(th2);
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            rZxgaWzvEfIkwOho(observer, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnNext(T t) {
        qIycdhcGHYjwRsCG(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        pxWSeVotCqLnIOJB(this.fbc3b0556, p7beea252Var);
    }

    void subscribeNext() {
        if ((23 + 32) % 32 > 0) {
        }
        if (tvscYoxeLwEFdKEe(this) != 0) {
            return;
        }
        int iJNCOVlRTroJHHfgB = 1;
        while (!SoTTYwmeeUSbfUCj(this.fbc3b0556)) {
            OSyatbjItGXfRkOS(this.f36cd38f4, this);
            iJNCOVlRTroJHHfgB = jNCOVlRTroJHHfgB(this, -iJNCOVlRTroJHHfgB);
            if (iJNCOVlRTroJHHfgB == 0) {
                return;
            }
        }
    }
}

