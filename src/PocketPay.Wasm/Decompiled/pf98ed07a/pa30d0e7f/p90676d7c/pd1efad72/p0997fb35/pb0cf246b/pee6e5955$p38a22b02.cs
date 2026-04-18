namespace WillowMaze.Wasm.Decompiled;


readonly class pee6e5955$p38a22b02<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    p5a445d71.p18f29add.p787ad0b7 f12921542;
    T f2063c160;
    p5a445d71.p18f29add.p787ad0b7 f35dd2272;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f4929a9d0;
    p5a445d71.p18f29add.p787ad0b7 f4f085bbc;
    java.lang.object f584178e0;
    bool f6b2ded51;
    readonly p5a445d71.p18f29add.p992c4a5b f75fc86d0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f7c8f8db1;
    readonly p5a445d71.p18f29add.p992c4a5b f8876e7b2;
    bool f8d6bb78f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f933771c2;
    bool fb28c17fb;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.functions.BiFunction<T, T, T> fbdc1d413;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly p5a445d71.p18f29add.p992c4a5b fd2a762a5;
    java.lang.object fd8aa64b2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba feeed28fb;
    bool ff792175b;
    java.lang.object ffb18ff3b;

    pee6e5955$p38a22b02(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.BiFunction<T, T, T> biFunction) {
        this.fd22a0a80 = subscriber;
        this.fbdc1d413 = biFunction;
    }

    public static void EVmPzdQgLivKpBJu(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object GIBTlgTsjPJrbYSB(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void MSyxioZEiomudIxY(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void XWZJEXWiKedhBLch(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object BMxoqZKDUpiqMOeY(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void CUbEZfUWdBJPVddX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool KkDuKrdnsngWeYIQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void OgccjZtAMEupqXxn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void PEVyAviEjeRWKlnu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void PrISvLCWUFWlQXrG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void QFFIjAVSQIIZxKLc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void QazYPVMrEilzyiRH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TdQVDjtKeQONCfbd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void UuybgpZKEkRKakRv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pee6e5955$p38a22b02 pee6e5955_p38a22b02, java.lang.Exception th) {
        pee6e5955_p38a22b02.onError(th);
    }

    public override void Cancel() {
        prISvLCWUFWlQXrG(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        pEVyAviEjeRWKlnu(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            qazYPVMrEilzyiRH(th);
        } else {
            this.f6b2ded51 = true;
            qFFIjAVSQIIZxKLc(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((13 + 32) % 32 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        T t2 = this.f2063c160;
        if (t2 is null) {
            this.f2063c160 = t;
            cUbEZfUWdBJPVddX(subscriber, t);
            return;
        }
        try {
            T t3 = (T) bMxoqZKDUpiqMOeY(GIBTlgTsjPJrbYSB(this.fbdc1d413, t2, t), "The value returned by the accumulator is null");
            this.f2063c160 = t3;
            ogccjZtAMEupqXxn(subscriber, t3);
        } catch (java.lang.Exception th) {
            EVmPzdQgLivKpBJu(th);
            XWZJEXWiKedhBLch(this.fbc3b0556);
            uuybgpZKEkRKakRv(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (kkDuKrdnsngWeYIQ(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            tdQVDjtKeQONCfbd(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        MSyxioZEiomudIxY(this.fbc3b0556, j);
    }
}

