namespace WillowMaze.Wasm.Decompiled;


public readonly class p23526405<T, D> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.functions.Supplier<? : D> f451ed497;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f54ede7f8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f558337b4;
    readonly bool f5b154520;
    readonly bool f7ba00493;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f83008cae;
    readonly io.reactivex.rxjava3.functions.Function<? super D, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> f9053270d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 fb6715941;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fb6a28682;
    readonly io.reactivex.rxjava3.functions.Consumer<D> fc7103d53;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fcacda473;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fe8891e2c;

    public p23526405(io.reactivex.rxjava3.functions.Supplier<? : D> supplier, io.reactivex.rxjava3.functions.Function<? super D, ? : io.reactivex.rxjava3.core.MaybeSource<? : T>> function, io.reactivex.rxjava3.functions.Consumer<D> consumer, bool z) {
        this.f451ed497 = supplier;
        this.f9053270d = function;
        this.fc7103d53 = consumer;
        this.f5b154520 = z;
    }

    public static java.lang.object BxAPnxCExjfKHayA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void EwJNfQlDyAoQXLjH(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static java.lang.object HPgYZJULLaCjONvg(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JNFFmwkHBlAKIQdC(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void RMCEqODFmmOsYQNJ(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void RgbsrNaqmicxwAAZ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object WvqTURJIkCTRhmNw(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void AvgeNDNDDYZlEatR(java.lang.Exception th, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.MaybeObserver<object>) maybeObserver);
    }

    public static void BEOMqxpwWcXwiemh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void OTnPrdokBHgJswJG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void OcUFmPrEXcwrqNyu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SatsZAaBegvmLnkv(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    public static void THOGDSdLRvnlURdk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void WqlCTwTemiLqVTRg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var, java.lang.object obj) throws java.lang.Exception {
        pf8afcf86Var.accept(obj);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((5 + 27) % 27 > 0) {
        }
        try {
            java.lang.object objBxAPnxCExjfKHayA = BxAPnxCExjfKHayA(this.f451ed497);
            try {
                EwJNfQlDyAoQXLjH((io.reactivex.rxjava3.core.MaybeSource) HPgYZJULLaCjONvg(WvqTURJIkCTRhmNw(this.f9053270d, objBxAPnxCExjfKHayA), "The sourceSupplier returned a null MaybeSource"), new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p23526405$p0af79e9c(maybeObserver, objBxAPnxCExjfKHayA, this.fc7103d53, this.f5b154520));
            } catch (java.lang.Exception th) {
                bEOMqxpwWcXwiemh(th);
                if (this.f5b154520) {
                    try {
                        satsZAaBegvmLnkv(this.fc7103d53, objBxAPnxCExjfKHayA);
                    } catch (java.lang.Exception th2) {
                        oTnPrdokBHgJswJG(th2);
                        java.lang.Exception[] thArr = new java.lang.Exception[2];
                        thArr[0] = th;
                        thArr[1] = th2;
                        avgeNDNDDYZlEatR(new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr), maybeObserver);
                        return;
                    }
                }
                JNFFmwkHBlAKIQdC(th, maybeObserver);
                if (this.f5b154520) {
                    return;
                }
                try {
                    wqlCTwTemiLqVTRg(this.fc7103d53, objBxAPnxCExjfKHayA);
                } catch (java.lang.Exception th3) {
                    ocUFmPrEXcwrqNyu(th3);
                    RgbsrNaqmicxwAAZ(th3);
                }
            }
        } catch (java.lang.Exception th4) {
            tHOGDSdLRvnlURdk(th4);
            RMCEqODFmmOsYQNJ(th4, maybeObserver);
        }
    }
}

