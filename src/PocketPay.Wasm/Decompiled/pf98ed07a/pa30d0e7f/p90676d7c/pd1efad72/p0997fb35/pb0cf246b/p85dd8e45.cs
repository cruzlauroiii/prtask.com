namespace WillowMaze.Wasm.Decompiled;


public readonly class p85dd8e45<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f418c5509;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f777c860e;

    public p85dd8e45(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        this.f418c5509 = p004bf6c9Var;
    }

    public static void DFmTdnxlAvyhUiWg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ORJzRkLaLGdSRoBk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void RkmvFZJWSTkbYPYp(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void UhlGjOnsUmsyzjkO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool WiAmwSIyCecjnmtT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void CxBDjhgmYTkQPsAo(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static void DKHvoajVyJrYYmyl(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool GyawXxPtOWfDbRrF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static bool HNzFLqPjZtHQdQMJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void LmoYlQUHOrSzBznt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public T Get() throws java.lang.Exception {
        RkmvFZJWSTkbYPYp(this.f418c5509);
        return null;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((26 + 13) % 13 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025();
        UhlGjOnsUmsyzjkO(subscriber, p9ec25025Var);
        if (hNzFLqPjZtHQdQMJ(p9ec25025Var)) {
            return;
        }
        try {
            cxBDjhgmYTkQPsAo(this.f418c5509);
            if (gyawXxPtOWfDbRrF(p9ec25025Var)) {
                return;
            }
            lmoYlQUHOrSzBznt(subscriber);
        } catch (java.lang.Exception th) {
            dKHvoajVyJrYYmyl(th);
            if (WiAmwSIyCecjnmtT(p9ec25025Var)) {
                ORJzRkLaLGdSRoBk(th);
            } else {
                DFmTdnxlAvyhUiWg(subscriber, th);
            }
        }
    }
}

