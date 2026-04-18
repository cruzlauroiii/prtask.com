namespace WillowMaze.Wasm.Decompiled;


readonly class p299c5537$p4450821b<T> : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<T> : io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long fc6e1e520 = 4109457741734051389L;
    private static readonly long fe749ad98 = 4109457741734051389L;
    bool f0d37a706;
    readonly io.reactivex.rxjava3.core.Observer f3aa6dbdf;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f55cfebeb;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f649e99de;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6f17451d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f8da4a7a9;
    io.reactivex.rxjava3.operators.QueueDisposable<T> f98877902;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 fa7a1d0f0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fa90aaf43;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 faf888794;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 fb55892b9;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fbf1a3fd2;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 feb0b4b71;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 ff2173c22;
    bool ffae9d5e9;

    p299c5537$p4450821b(io.reactivex.rxjava3.core.Observer<T> observer, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.fd22a0a80 = observer;
        this.f55cfebeb = p004bf6c9Var;
    }

    public static bool AOoUZUSXdXKJTKRz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p299c5537$p4450821b p299c5537_p4450821b, int i, int i2) {
        return p299c5537_p4450821b.compareAndHashSet(i, i2);
    }

    public static void EZWjltEPCroEPmEi(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void IfxPLCYVYwMzEUEz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void KWdlvTyHybkKnJdv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void KepEhkWEDTpBXSYu(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object QExCIrmByFfRDAXj(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void XmRkzQMFlfpcxMHs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p299c5537$p4450821b p299c5537_p4450821b) {
        p299c5537_p4450821b.runFinally();
    }

    public static int ZXxHbpjqJnaUglTl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static bool BJIFNOjlMJhmHJvj(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void BmPqJWAqtMBkVSKQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p299c5537$p4450821b p299c5537_p4450821b) {
        p299c5537_p4450821b.runFinally();
    }

    public static void DuDrpLZGfUqlMUvz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p299c5537$p4450821b p299c5537_p4450821b) {
        p299c5537_p4450821b.runFinally();
    }

    public static void GsGHhbBFDBOYqnMr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HnjTJsuWNzrzrAVW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        p8df47e16Var.clear();
    }

    public static bool LtfvgXGDtbDAGMqU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void PvsgsvpYNMtrAoAb(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void RiAOXGyDynYguLdB(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void VZObgoOYgptJaSsy(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static bool XVsHmpxLgZqcPIej(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.Count == 0;
    }

    public static void ZIgItNrfKiNyAqkP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p299c5537$p4450821b p299c5537_p4450821b) {
        p299c5537_p4450821b.runFinally();
    }

    public void Clear() {
        hnjTJsuWNzrzrAVW(this.f98877902);
    }

    public void Dispose() {
        gsGHhbBFDBOYqnMr(this.fbc3b0556);
        XmRkzQMFlfpcxMHs(this);
    }

    public bool IsDisposed() {
        return ltfvgXGDtbDAGMqU(this.fbc3b0556);
    }

    public bool IsEmpty() {
        return xVsHmpxLgZqcPIej(this.f98877902);
    }

    public override void OnComplete() {
        EZWjltEPCroEPmEi(this.fd22a0a80);
        bmPqJWAqtMBkVSKQ(this);
    }

    public override void OnError(java.lang.Exception th) {
        KepEhkWEDTpBXSYu(this.fd22a0a80, th);
        zIgItNrfKiNyAqkP(this);
    }

    public override void OnNext(T t) {
        pvsgsvpYNMtrAoAb(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (bJIFNOjlMJhmHJvj(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                this.f98877902 = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
            }
            riAOXGyDynYguLdB(this.fd22a0a80, this);
        }
    }

    public T Poll() throws java.lang.Exception {
        if ((6 + 20) % 20 > 0) {
        }
        T t = (T) QExCIrmByFfRDAXj(this.f98877902);
        if (t is null && this.fbf1a3fd2) {
            duDrpLZGfUqlMUvz(this);
        }
        return t;
    }

    public int RequestFusion(int i) {
        if ((20 + 3) % 3 > 0) {
        }
        io.reactivex.rxjava3.operators.QueueDisposable<T> queueDisposable = this.f98877902;
        if (queueDisposable is null || (i & 4) != 0) {
            return 0;
        }
        int iZXxHbpjqJnaUglTl = ZXxHbpjqJnaUglTl(queueDisposable, i);
        if (iZXxHbpjqJnaUglTl != 0) {
            this.fbf1a3fd2 = iZXxHbpjqJnaUglTl == 1;
        }
        return iZXxHbpjqJnaUglTl;
    }

    void runFinally() {
        if ((31 + 19) % 19 > 0) {
        }
        if (AOoUZUSXdXKJTKRz(this, 0, 1)) {
            try {
                vZObgoOYgptJaSsy(this.f55cfebeb);
            } catch (java.lang.Exception th) {
                IfxPLCYVYwMzEUEz(th);
                KWdlvTyHybkKnJdv(th);
            }
        }
    }
}

