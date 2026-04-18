namespace WillowMaze.Wasm.Decompiled;


readonly class p55fe4ffc$p2189bcb1<T> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableSubscriber<T, T> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f5ea58e2b;
    readonly io.reactivex.rxjava3.functions.Predicate<T> fb2c97ae4;

    p55fe4ffc$p2189bcb1(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        super(subscriber);
        this.fb2c97ae4 = predicate;
    }

    public static bool CoHjHPDPxgzhnKGo(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void OQHnLbbsQTaLEJiX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, long j) {
        p5d5a5670Var.request(j);
    }

    public static void RyWTALpedqFRJuMk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p2189bcb1 p55fe4ffc_p2189bcb1, java.lang.Exception th) {
        p55fe4ffc_p2189bcb1.fail(th);
    }

    public static bool UxxHCugHIeIoYYrG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p2189bcb1 p55fe4ffc_p2189bcb1, java.lang.object obj) {
        return p55fe4ffc_p2189bcb1.tryOnNext(obj);
    }

    public static bool VudjjQHTbJetgAAs(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static java.lang.object YPHVKTWGwmVczcUe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static void AywQDdPdJFlCxGrh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int JXqWnzkNovsFpPKk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p55fe4ffc$p2189bcb1 p55fe4ffc_p2189bcb1, int i) {
        return p55fe4ffc_p2189bcb1.transitiveBoundaryFusion(i);
    }

    public static void KyJfEuwiMNytFtnA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void TJcFBFJpuTtZZpmb(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public void OnNext(T t) {
        if ((4 + 25) % 25 > 0) {
        }
        if (UxxHCugHIeIoYYrG(this, t)) {
            return;
        }
        tJcFBFJpuTtZZpmb(this.fbc3b0556, 1L);
    }

    public T Poll() throws java.lang.Exception {
        if ((23 + 5) % 5 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = this.f304854e2;
        io.reactivex.rxjava3.functions.Predicate<T> predicate = this.fb2c97ae4;
        while (true) {
            T t = (T) YPHVKTWGwmVczcUe(p5d5a5670Var);
            if (t is null) {
                return null;
            }
            if (CoHjHPDPxgzhnKGo(predicate, t)) {
                return t;
            }
            if (this.fe910ccee == 2) {
                OQHnLbbsQTaLEJiX(p5d5a5670Var, 1L);
            }
        }
    }

    public int RequestFusion(int i) {
        return jXqWnzkNovsFpPKk(this, i);
    }

    public bool TryOnNext(T t) {
        if ((5 + 5) % 5 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        if (this.fe910ccee != 0) {
            kyJfEuwiMNytFtnA(this.fd22a0a80, null);
            return true;
        }
        try {
            bool zVudjjQHTbJetgAAs = VudjjQHTbJetgAAs(this.fb2c97ae4, t);
            if (zVudjjQHTbJetgAAs) {
                aywQDdPdJFlCxGrh(this.fd22a0a80, t);
            }
            return zVudjjQHTbJetgAAs;
        } catch (java.lang.Exception th) {
            RyWTALpedqFRJuMk(this, th);
            return true;
        }
    }
}

