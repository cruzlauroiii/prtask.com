namespace WillowMaze.Wasm.Decompiled;


readonly class p16c2cc15$p351db019<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f349b76d2 = -7098360935104053232L;
    private static readonly long f7e58b9a7 = -7098360935104053232L;
    private static readonly long fa151c468 = -7098360935104053232L;
    private static readonly long fc6e1e520 = -7098360935104053232L;
    readonly io.reactivex.rxjava3.core.ObservableSource f0979f880;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 f227e5ee1;
    readonly io.reactivex.rxjava3.core.ObservableSource f34dbf795;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f8b9f90d7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f9c6ed687;
    int fb72a959a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fc117946b;
    readonly io.reactivex.rxjava3.core.Observer fcfc15956;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    int ff31fb46f;
    readonly io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> ff670ef68;

    p16c2cc15$p351db019(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource) {
        this.fd22a0a80 = observer;
        this.fbc3b0556 = pa7808658Var;
        this.f36cd38f4 = observableSource;
        this.ff670ef68 = biPredicate;
    }

    public static int CBMcVjBaGAVVNftY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p16c2cc15$p351db019 p16c2cc15_p351db019) {
        return p16c2cc15_p351db019.getAndIncrement();
    }

    public static void DMZYAasLlrMRclGs(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void GdvjTbJEtskVzHux(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p16c2cc15$p351db019 p16c2cc15_p351db019) {
        p16c2cc15_p351db019.subscribeNext();
    }

    public static void MLQcaikTPuAcWrTO(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int NsqeRcDYcBjXcPbR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p16c2cc15$p351db019 p16c2cc15_p351db019, int i) {
        return p16c2cc15_p351db019.addAndGet(i);
    }

    public static void SFplpjULcPfdvTbh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool XcvRWrWUFGKJbHtS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pa7808658Var.Replace(p7beea252Var);
    }

    public static java.lang.int GXepcOMoezAePGRd(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void JoAJIdiLVJElopAb(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool KddWwwWFSdvIiOkA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var) {
        return pa7808658Var.isDisposed();
    }

    public static void LzpSGpBTLnDJkYnD(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool ZZsNpEcnexJiKCLb(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void ZiogQALuQOMTmfCL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public override void OnComplete() {
        ziogQALuQOMTmfCL(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((27 + 26) % 26 > 0) {
        }
        try {
            io.reactivex.rxjava3.functions.BiPredicate<java.lang.int, java.lang.Exception> biPredicate = this.ff670ef68;
            int i = this.ff31fb46f + 1;
            this.ff31fb46f = i;
            if (zZsNpEcnexJiKCLb(biPredicate, gXepcOMoezAePGRd(i), th)) {
                GdvjTbJEtskVzHux(this);
            } else {
                joAJIdiLVJElopAb(this.fd22a0a80, th);
            }
        } catch (java.lang.Exception th2) {
            SFplpjULcPfdvTbh(th2);
            io.reactivex.rxjava3.core.Observer<T> observer = this.fd22a0a80;
            java.lang.Exception[] thArr = new java.lang.Exception[2];
            thArr[0] = th;
            thArr[1] = th2;
            MLQcaikTPuAcWrTO(observer, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
        }
    }

    public override void OnNext(T t) {
        DMZYAasLlrMRclGs(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        XcvRWrWUFGKJbHtS(this.fbc3b0556, p7beea252Var);
    }

    void subscribeNext() {
        if ((1 + 3) % 3 > 0) {
        }
        if (CBMcVjBaGAVVNftY(this) != 0) {
            return;
        }
        int iNsqeRcDYcBjXcPbR = 1;
        do {
            if (kddWwwWFSdvIiOkA(this.fbc3b0556)) {
                return;
            }
            lzpSGpBTLnDJkYnD(this.f36cd38f4, this);
            iNsqeRcDYcBjXcPbR = NsqeRcDYcBjXcPbR(this, -iNsqeRcDYcBjXcPbR);
        } while (iNsqeRcDYcBjXcPbR != 0);
    }
}

