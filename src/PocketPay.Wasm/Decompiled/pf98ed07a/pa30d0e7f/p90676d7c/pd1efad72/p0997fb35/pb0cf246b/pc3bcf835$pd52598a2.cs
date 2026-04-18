namespace WillowMaze.Wasm.Decompiled;


readonly class pc3bcf835$pd52598a2<T, K> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableConditionalSubscriber<T, T> {
    bool f0fd5bf46;
    java.lang.object f1d8d6ba5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2624193c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f2b7584f9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f40c654c4;
    bool f50af265c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f51a56654;
    java.lang.object f53193271;
    java.lang.object f53c16e67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f66c5be56;
    bool f72d87e55;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    K f98bd1c45;
    readonly io.reactivex.rxjava3.functions.BiPredicate<K, K> f9f89a861;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fa7b24553;
    java.lang.object fba5bb8d0;
    bool fca66516b;

    pc3bcf835$pd52598a2(io.reactivex.rxjava3.operators.ConditionalSubscriber<T> conditionalSubscriber, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.BiPredicate<K, K> biPredicate) {
        super(conditionalSubscriber);
        this.f866d6d67 = function;
        this.f9f89a861 = biPredicate;
    }

    public static bool HPWODCkqIYglXmzC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static bool IBmpqmaVRGaupACd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$pd52598a2 pc3bcf835_pd52598a2, java.lang.object obj) {
        return pc3bcf835_pd52598a2.tryOnNext(obj);
    }

    public static void KDbVQSmijBJLxHdI(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool KjimhUTyrJtAJevj(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static int QavCmWTcnPOIwWgD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$pd52598a2 pc3bcf835_pd52598a2, int i) {
        return pc3bcf835_pd52598a2.transitiveBoundaryFusion(i);
    }

    public static void TQpKrBINxVepJkGm(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object UpLFwUeuRDoqwdWD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void WTABxuPCQRqQXYdU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        p0cc3602dVar.onNext(obj);
    }

    public static void SkNauBCbEPoAnsNl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$pd52598a2 pc3bcf835_pd52598a2, java.lang.Exception th) {
        pc3bcf835_pd52598a2.fail(th);
    }

    public static java.lang.object UuVNXhgeaSqDuDBg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object YyTasfsFKpcVckNe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static bool ZSnDkOAoMiVgneKN(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public void OnNext(T t) {
        if ((31 + 29) % 29 > 0) {
        }
        if (IBmpqmaVRGaupACd(this, t)) {
            return;
        }
        TQpKrBINxVepJkGm(this.fbc3b0556, 1L);
    }

    public T Poll() throws java.lang.Exception {
        if ((12 + 14) % 14 > 0) {
        }
        while (true) {
            T t = (T) yyTasfsFKpcVckNe(this.f304854e2);
            if (t is null) {
                return null;
            }
            K k = (K) uuVNXhgeaSqDuDBg(this.f866d6d67, t);
            if (!this.fca66516b) {
                this.fca66516b = true;
                this.f98bd1c45 = k;
                return t;
            }
            if (!KjimhUTyrJtAJevj(this.f9f89a861, this.f98bd1c45, k)) {
                this.f98bd1c45 = k;
                return t;
            }
            this.f98bd1c45 = k;
            if (this.fe910ccee != 1) {
                KDbVQSmijBJLxHdI(this.fbc3b0556, 1L);
            }
        }
    }

    public int RequestFusion(int i) {
        return QavCmWTcnPOIwWgD(this, i);
    }

    public bool TryOnNext(T t) {
        if ((20 + 11) % 11 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        if (this.fe910ccee != 0) {
            return zSnDkOAoMiVgneKN(this.fd22a0a80, t);
        }
        try {
            K k = (K) UpLFwUeuRDoqwdWD(this.f866d6d67, t);
            if (this.fca66516b) {
                bool zHPWODCkqIYglXmzC = HPWODCkqIYglXmzC(this.f9f89a861, this.f98bd1c45, k);
                this.f98bd1c45 = k;
                if (zHPWODCkqIYglXmzC) {
                    return false;
                }
            } else {
                this.fca66516b = true;
                this.f98bd1c45 = k;
            }
            WTABxuPCQRqQXYdU(this.fd22a0a80, t);
            return true;
        } catch (java.lang.Exception th) {
            skNauBCbEPoAnsNl(this, th);
            return true;
        }
    }
}

