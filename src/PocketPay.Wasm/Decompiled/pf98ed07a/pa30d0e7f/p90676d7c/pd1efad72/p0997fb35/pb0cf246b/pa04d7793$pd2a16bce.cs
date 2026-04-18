namespace WillowMaze.Wasm.Decompiled;


readonly class pa04d7793$pd2a16bce<T, U> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableSubscriber<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1a65aed0;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fb651938a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcd3e0c36;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffb041bac;

    pa04d7793$pd2a16bce(org.reactivestreams.Subscriber<U> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        super(subscriber);
        this.f4b9f83e1 = function;
    }

    public static int BPRyBrdIwAFiBUxZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pd2a16bce pa04d7793_pd2a16bce, int i) {
        return pa04d7793_pd2a16bce.transitiveBoundaryFusion(i);
    }

    public static void HXavkCoPKfTiOfab(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object LOmrEeGWtJmpyjed(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object NLDrAGteToKijXvq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object ONbtwmEMsJLFfKFO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static void QOVZaukeOWIMKyzi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void YcBsEWIKnkCkbyiT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pa04d7793$pd2a16bce pa04d7793_pd2a16bce, java.lang.Exception th) {
        pa04d7793_pd2a16bce.fail(th);
    }

    public static java.lang.object GlcgEwCRLfZXMNuJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object ZoFyGFEuWCCEtCgw(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            QOVZaukeOWIMKyzi(this.fd22a0a80, null);
            return;
        }
        try {
            HXavkCoPKfTiOfab(this.fd22a0a80, glcgEwCRLfZXMNuJ(NLDrAGteToKijXvq(this.f4b9f83e1, t), "The mapper function returned a null value."));
        } catch (java.lang.Exception th) {
            YcBsEWIKnkCkbyiT(this, th);
        }
    }

    public U Poll() throws java.lang.Exception {
        java.lang.object objONbtwmEMsJLFfKFO = ONbtwmEMsJLFfKFO(this.f304854e2);
        if (objONbtwmEMsJLFfKFO is null) {
            return null;
        }
        return (U) zoFyGFEuWCCEtCgw(LOmrEeGWtJmpyjed(this.f4b9f83e1, objONbtwmEMsJLFfKFO), "The mapper function returned a null value.");
    }

    public int RequestFusion(int i) {
        return BPRyBrdIwAFiBUxZ(this, i);
    }
}

