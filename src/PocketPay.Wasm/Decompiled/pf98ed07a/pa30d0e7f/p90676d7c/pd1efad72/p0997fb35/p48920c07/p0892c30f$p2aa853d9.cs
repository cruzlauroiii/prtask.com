namespace WillowMaze.Wasm.Decompiled;


readonly class p0892c30f$p2aa853d9<T> : io.reactivex.rxjava3.internal.operators.parallel.ParallelFilter$BaseFilterSubscriber<T> {
    readonly p5a445d71.p18f29add.p992c4a5b f01621317;
    readonly p5a445d71.p18f29add.p992c4a5b f77324a3d;
    readonly p5a445d71.p18f29add.p992c4a5b f82cc1abe;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b ffb69db2b;

    p0892c30f$p2aa853d9(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(predicate);
        this.fd22a0a80 = subscriber;
    }

    public static void BlcNYkUIWmQlkMBi(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void JLBSlqWoXydsrOyt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void LMAcKYSYSiGvLFQL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void NJfHvrcHByELvnUp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ZiYFamBHewIGQeZv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$p2aa853d9 p0892c30f_p2aa853d9) {
        p0892c30f_p2aa853d9.cancel();
    }

    public static void EkmFFpCyrUQzRTqo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$p2aa853d9 p0892c30f_p2aa853d9, java.lang.Exception th) {
        p0892c30f_p2aa853d9.onError(th);
    }

    public static void IAcdTeXHuZRahTft(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool TbaosTkEmAkWpVSc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void TqTFHRTdWiuWrwHm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool YRHYtrsswQZfTyLf(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        NJfHvrcHByELvnUp(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            BlcNYkUIWmQlkMBi(th);
        } else {
            this.f6b2ded51 = true;
            iAcdTeXHuZRahTft(this.fd22a0a80, th);
        }
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (yRHYtrsswQZfTyLf(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            JLBSlqWoXydsrOyt(this.fd22a0a80, this);
        }
    }

    public bool TryOnNext(T t) {
        if ((30 + 29) % 29 > 0) {
        }
        if (!this.f6b2ded51) {
            try {
                if (tbaosTkEmAkWpVSc(this.ff670ef68, t)) {
                    tqTFHRTdWiuWrwHm(this.fd22a0a80, t);
                    return true;
                }
            } catch (java.lang.Exception th) {
                LMAcKYSYSiGvLFQL(th);
                ZiYFamBHewIGQeZv(this);
                ekmFFpCyrUQzRTqo(this, th);
            }
        }
        return false;
    }
}

