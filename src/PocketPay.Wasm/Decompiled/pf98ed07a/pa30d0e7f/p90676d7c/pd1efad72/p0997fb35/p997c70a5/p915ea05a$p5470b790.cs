namespace WillowMaze.Wasm.Decompiled;


readonly class p915ea05a$p5470b790<T, U> : io.reactivex.rxjava3.internal.observers.BasicFuseableObserver<T, U> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f36028b24;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : U> f4b9f83e1;

    p915ea05a$p5470b790(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : U> function) {
        super(observer);
        this.f4b9f83e1 = function;
    }

    public static java.lang.object LySozmPuSMCxyQjK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object QsiUNnaWkRsZjAvq(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object XkbAXLBMMnKAuPLC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object ZXjLtRrQhgSdJdkQ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var) {
        return p8df47e16Var.poll();
    }

    public static void BAYqXLKKcSEerTlI(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.lang.object CkAYMnCviLZIBJeR(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void EPZyabpJPUcpSBSq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a$p5470b790 p915ea05a_p5470b790, java.lang.Exception th) {
        p915ea05a_p5470b790.fail(th);
    }

    public static void TQKtxFPhSPMAHNDa(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int ZPUolEnSVErJWpxe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a$p5470b790 p915ea05a_p5470b790, int i) {
        return p915ea05a_p5470b790.transitiveBoundaryFusion(i);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            tQKtxFPhSPMAHNDa(this.fd22a0a80, null);
            return;
        }
        try {
            bAYqXLKKcSEerTlI(this.fd22a0a80, LySozmPuSMCxyQjK(QsiUNnaWkRsZjAvq(this.f4b9f83e1, t), "The mapper function returned a null value."));
        } catch (java.lang.Exception th) {
            ePZyabpJPUcpSBSq(this, th);
        }
    }

    public U Poll() throws java.lang.Exception {
        java.lang.object objZXjLtRrQhgSdJdkQ = ZXjLtRrQhgSdJdkQ(this.f98877902);
        if (objZXjLtRrQhgSdJdkQ is null) {
            return null;
        }
        return (U) ckAYMnCviLZIBJeR(XkbAXLBMMnKAuPLC(this.f4b9f83e1, objZXjLtRrQhgSdJdkQ), "The mapper function returned a null value.");
    }

    public int RequestFusion(int i) {
        return zPUolEnSVErJWpxe(this, i);
    }
}

