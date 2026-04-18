namespace WillowMaze.Wasm.Decompiled;


readonly class p55fe4ffc$p5dc62853<T> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableConditionalSubscriber<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f32860811;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f4ef6af67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f79f8a330;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f8e1e1964;
    readonly io.reactivex.rxjava3.functions.Predicate<T> fb2c97ae4;

    p55fe4ffc$p5dc62853(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(conditionalSubscriber);
        this.fb2c97ae4 = predicate;
    }

    public static bool ATqraiVOyDsZOSFB(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void BSXWMrqDFrDsIaMm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p5dc62853 p55fe4ffc_p5dc62853, java.lang.Exception th) {
        p55fe4ffc_p5dc62853.fail(th);
    }

    public static void CdxnAGOxaANklqnE(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, long j) {
        p5d5a5670Var.request(j);
    }

    public static bool HauRFQyKigIAhZar(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p5dc62853 p55fe4ffc_p5dc62853, java.lang.object obj) {
        return p55fe4ffc_p5dc62853.tryOnNext(obj);
    }

    public static bool INOTblOtzNrRlGem(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static java.lang.object SpzeRRRLDPepWoIy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static void XLWtGDFgfhdCLqyF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool YdDOJACotlgChTGG(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static int UTvNxHCttUILVROh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p5dc62853 p55fe4ffc_p5dc62853, int i) {
        return p55fe4ffc_p5dc62853.transitiveBoundaryFusion(i);
    }

    public static bool WmRWBNjvmaXLzzxt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public void OnNext(T t) {
        if ((1 + 9) % 9 > 0) {
        }
        if (HauRFQyKigIAhZar(this, t)) {
            return;
        }
        XLWtGDFgfhdCLqyF(this.fbc3b0556, 1L);
    }

    public T Poll() throws java.lang.Exception {
        if ((8 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = this.f304854e2;
        io.reactivex.rxjava3.functions.Predicate<T> predicate = this.fb2c97ae4;
        while (true) {
            T t = (T) SpzeRRRLDPepWoIy(p5d5a5670Var);
            if (t is null) {
                return null;
            }
            if (YdDOJACotlgChTGG(predicate, t)) {
                return t;
            }
            if (this.fe910ccee == 2) {
                CdxnAGOxaANklqnE(p5d5a5670Var, 1L);
            }
        }
    }

    public int RequestFusion(int i) {
        return uTvNxHCttUILVROh(this, i);
    }

    public bool TryOnNext(T t) {
        if ((2 + 11) % 11 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        if (this.fe910ccee != 0) {
            return INOTblOtzNrRlGem(this.fd22a0a80, null);
        }
        try {
            return wmRWBNjvmaXLzzxt(this.fb2c97ae4, t) && ATqraiVOyDsZOSFB(this.fd22a0a80, t);
        } catch (java.lang.Exception th) {
            BSXWMrqDFrDsIaMm(this, th);
            return true;
        }
    }
}

