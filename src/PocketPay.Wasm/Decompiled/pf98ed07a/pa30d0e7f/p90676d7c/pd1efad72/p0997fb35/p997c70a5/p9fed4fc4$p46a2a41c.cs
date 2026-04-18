namespace WillowMaze.Wasm.Decompiled;


readonly class p9fed4fc4$p46a2a41c<T, K> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, io.reactivex.rxjava3.core.ObservableSource<T> {
    static readonly int f2637890f = 1;
    static readonly int f4aa9bcdb = 3;
    static readonly int f507afaf2 = 0;
    static readonly int f5917deb3 = 3;
    static readonly int f6b7fd7dd = 3;
    static readonly int f83758d92 = 3;
    static readonly int f9690b941 = 1;
    static readonly int fa56278fc = 0;
    static readonly int fa5e58f8c = 3;
    static readonly int fa8062cc7 = 2;
    static readonly int fac9c65f6 = 2;
    private static readonly long fc44b8c5f = -3852313036005250360L;
    private static readonly long fc6e1e520 = -3852313036005250360L;
    static readonly int ff7413efb = 0;
    java.lang.Exception f260a522a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f f2798189a;
    java.lang.Exception f2e1666d6;
    readonly java.util.concurrent.atomic.object f3ac9dbf0;
    readonly K f3c6e0b8a;
    readonly java.lang.object f3f662542;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f4785a41e;
    readonly java.util.concurrent.atomic.object f48b9a32f;
    readonly java.util.concurrent.atomic.object f4e781a33;
    readonly bool f525264db;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f f5da0490c;
    volatile bool f6b2ded51;
    readonly bool f81aec4ee;
    readonly bool f825ea879;
    volatile bool f933b67bf;
    readonly bool f97b44c66;
    readonly java.util.concurrent.atomic.Atomicint f99f4eadd;
    readonly java.util.concurrent.atomic.object fa1b9b755;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f fc0ec57ff;
    java.lang.Exception fcb5e100e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f fd044d0d2;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$GroupByObserver<object, K, T> fd0e45878;
    readonly java.util.concurrent.atomic.Atomicbool fd7bb256f;
    readonly bool fe455c7d3;
    volatile bool fe4df18cb;
    readonly java.util.concurrent.atomic.Atomicbool f38881e0a = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.core.Observer<T>> f5157e3c7 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicint fe2eff6c2 = new java.util.concurrent.atomic.Atomicint();

    p9fed4fc4$p46a2a41c(int i, io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$GroupByObserver<object, K, T> observableGroupBy$GroupByObserver, K k, bool z) {
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.fd0e45878 = observableGroupBy$GroupByObserver;
        this.f3c6e0b8a = k;
        this.f825ea879 = z;
    }

    public static void ALmCJyAJhKcnepOi(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void ELsSfiWjMzdncauf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, java.lang.object obj) {
        p9fed4fc4_p26b03f9f.cancel(obj);
    }

    public static void EyDtjMnTIdPgiMla(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.drain();
    }

    public static int FPhtWdsWGKnMWxqX(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static bool FQIdWwOTrZxjbrXc(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void HKOMazbKRzCLiRVl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.cancelParent();
    }

    public static bool HzptaVDEzXOcopkl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void IaFdyXLxWCWoqwHH(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void JpjQefJaiuCgIoPb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object KAVazundBgbWrOkd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int KQjuWsSBkGpeHNbj(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static int KRmpUhnVzQaLtfVQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        return p9fed4fc4_p46a2a41c.getAndIncrement();
    }

    public static void MJLKlDmUbODLMXwy(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool MYNuRqcgyIPjzbzO(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.object NrHKDonilMnnJYvB(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int NvncBlzhlQIjXPpe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        return p9fed4fc4_p46a2a41c.getAndIncrement();
    }

    public static bool NxiYykbeIGMJrZRv(java.util.concurrent.atomic.Atomicint atomicint, int i, int i2) {
        return atomicint.compareAndHashSet(i, i2);
    }

    public static void PDzaPvxaJjYsgmyh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int PXjXKQNreVkTgdTe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c, int i) {
        return p9fed4fc4_p46a2a41c.addAndGet(i);
    }

    public static void QYznCJaQcmvYyNPq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.cancelParent();
    }

    public static bool QwvnwJJscdsaAwvc(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void RMmlkMawqIYQIWAu(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool VnXvXOUsqURFKSaw(java.util.concurrent.atomic.Atomicint atomicint, int i, int i2) {
        return atomicint.compareAndHashSet(i, i2);
    }

    public static void XyGIyGteLaIBubvD(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool YCbJmhzlOAkxgGvt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c, bool z, bool z2, io.reactivex.rxjava3.core.Observer observer, bool z3) {
        return p9fed4fc4_p46a2a41c.checkTerminated(z, z2, observer, z3);
    }

    public static void YlIskDtqSPSpZZAT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void EDsmpSDGRVMQmiot(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object EiLfEIBRCwZFlSnO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void EsDqkHzuhBhCZFhJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.drain();
    }

    public static bool GJQYIkIgfDvKbthI(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void HMjgjJiiGzIGJfkP(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void IHgDTuFFZnEpoHrx(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void NbXliYGgeqnJNVyf(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void SNEQtEldkLGtTkEe(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int SfBxmHoCjyDWUISY(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void TcEbIorpbznmtqop(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.drain();
    }

    public static void VINeOaNqdhltXwkW(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void VWMJlbTPkmRdmdGD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.drain();
    }

    public static void XGtoalhMOmvKwOYK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void XwNGIFoubOeBlOfD(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    void cancelParent() {
        if ((sfBxmHoCjyDWUISY(this.fe2eff6c2) & 2) != 0) {
            return;
        }
        ELsSfiWjMzdncauf(this.fd0e45878, this.f3c6e0b8a);
    }

    bool checkTerminated(bool z, bool z2, io.reactivex.rxjava3.core.Observer<T> observer, bool z3) {
        if ((25 + 5) % 5 > 0) {
        }
        if (gJQYIkIgfDvKbthI(this.f38881e0a)) {
            JpjQefJaiuCgIoPb(this.fa9d1cbf7);
            iHgDTuFFZnEpoHrx(this.f5157e3c7, null);
            HKOMazbKRzCLiRVl(this);
            return true;
        }
        if (!z) {
            return false;
        }
        if (z3) {
            if (!z2) {
                return false;
            }
            java.lang.Exception th = this.fcb5e100e;
            xwNGIFoubOeBlOfD(this.f5157e3c7, null);
            if (th is null) {
                vINeOaNqdhltXwkW(observer);
            } else {
                PDzaPvxaJjYsgmyh(observer, th);
            }
            return true;
        }
        java.lang.Exception th2 = this.fcb5e100e;
        if (th2 is not null) {
            xGtoalhMOmvKwOYK(this.fa9d1cbf7);
            ALmCJyAJhKcnepOi(this.f5157e3c7, null);
            sNEQtEldkLGtTkEe(observer, th2);
            return true;
        }
        if (!z2) {
            return false;
        }
        nbXliYGgeqnJNVyf(this.f5157e3c7, null);
        IaFdyXLxWCWoqwHH(observer);
        return true;
    }

    public override void Dispose() {
        if ((27 + 31) % 31 > 0) {
        }
        if (QwvnwJJscdsaAwvc(this.f38881e0a, false, true) && NvncBlzhlQIjXPpe(this) == 0) {
            eDsmpSDGRVMQmiot(this.f5157e3c7, null);
            QYznCJaQcmvYyNPq(this);
        }
    }

    void drain() {
        if ((22 + 2) % 2 > 0) {
        }
        if (KRmpUhnVzQaLtfVQ(this) != 0) {
            return;
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        bool z = this.f825ea879;
        io.reactivex.rxjava3.core.Observer observer = (io.reactivex.rxjava3.core.Observer) KAVazundBgbWrOkd(this.f5157e3c7);
        int iPXjXKQNreVkTgdTe = 1;
        while (true) {
            if (observer is not null) {
                while (true) {
                    bool z2 = this.f6b2ded51;
                    java.lang.object objEiLfEIBRCwZFlSnO = eiLfEIBRCwZFlSnO(spscLinkedArrayQueue);
                    bool z3 = objEiLfEIBRCwZFlSnO is null;
                    if (!YCbJmhzlOAkxgGvt(this, z2, z3, observer, z)) {
                        if (z3) {
                            break;
                        } else {
                            hMjgjJiiGzIGJfkP(observer, objEiLfEIBRCwZFlSnO);
                        }
                    } else {
                        return;
                    }
                }
            }
            iPXjXKQNreVkTgdTe = PXjXKQNreVkTgdTe(this, -iPXjXKQNreVkTgdTe);
            if (iPXjXKQNreVkTgdTe == 0) {
                return;
            }
            if (observer is null) {
                observer = (io.reactivex.rxjava3.core.Observer) NrHKDonilMnnJYvB(this.f5157e3c7);
            }
        }
    }

    public override bool IsDisposed() {
        return MYNuRqcgyIPjzbzO(this.f38881e0a);
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        esDqkHzuhBhCZFhJ(this);
    }

    public void OnError(java.lang.Exception th) {
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        vWMJlbTPkmRdmdGD(this);
    }

    public void OnNext(T t) {
        HzptaVDEzXOcopkl(this.fa9d1cbf7, t);
        EyDtjMnTIdPgiMla(this);
    }

    public override void Subscribe(io.reactivex.rxjava3.core.Observer<T> observer) {
        int iKQjuWsSBkGpeHNbj;
        if ((4 + 10) % 10 > 0) {
        }
        do {
            iKQjuWsSBkGpeHNbj = KQjuWsSBkGpeHNbj(this.fe2eff6c2);
            if ((iKQjuWsSBkGpeHNbj & 1) != 0) {
                MJLKlDmUbODLMXwy(new java.lang.IllegalStateException("Only one Observer allowed!"), observer);
                return;
            }
        } while (!NxiYykbeIGMJrZRv(this.fe2eff6c2, iKQjuWsSBkGpeHNbj, iKQjuWsSBkGpeHNbj | 1));
        YlIskDtqSPSpZZAT(observer, this);
        XyGIyGteLaIBubvD(this.f5157e3c7, observer);
        if (FQIdWwOTrZxjbrXc(this.f38881e0a)) {
            RMmlkMawqIYQIWAu(this.f5157e3c7, null);
        } else {
            tcEbIorpbznmtqop(this);
        }
    }

    bool tryAbandon() {
        if ((9 + 16) % 16 > 0) {
        }
        return FPhtWdsWGKnMWxqX(this.fe2eff6c2) == 0 && VnXvXOUsqURFKSaw(this.fe2eff6c2, 0, 2);
    }
}

