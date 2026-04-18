namespace WillowMaze.Wasm.Decompiled;


public readonly class p6f5e6c40 {
    private p6f5e6c40() {
        throw new java.lang.IllegalStateException("No instances!");
    }

    public static void CFdIMDcLfKpPKEAi(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object HBbuPPYGYgUNWCwH(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void HhwRIiXpvRXyXrdd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MKaryfpUiuyLzucL(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void ZKtmlFPIHIRCsMqH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static io.reactivex.rxjava3.core.Flowable DFexZsmLrzhlRcsN(io.reactivex.rxjava3.core.Flowable flowable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(flowable);
    }

    public static void GOZHYPBylrzZEDci(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object JrrfHdpDNdGaENBI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void KIKmxSZEUmvCwkBB(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static void LoScLyfiwcPksYzO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static <T, R> bool M0abd2e53(org.reactivestreams.Publisher<T> publisher, org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function) {
        if (!(publisher is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44)) {
            return false;
        }
        try {
            java.lang.object objHBbuPPYGYgUNWCwH = HBbuPPYGYgUNWCwH((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) publisher);
            if (objHBbuPPYGYgUNWCwH is null) {
                loScLyfiwcPksYzO(subscriber);
                return true;
            }
            try {
                p5a445d71.p18f29add.p32c73be0 p32c73be0Var = (p5a445d71.p18f29add.p32c73be0) jrrfHdpDNdGaENBI(wpDObsrBFnZmccUg(function, objHBbuPPYGYgUNWCwH), "The mapper returned a null Publisher");
                if (p32c73be0Var is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) {
                    try {
                        java.lang.object objOaiYYFLlvZKqUDIl = oaiYYFLlvZKqUDIl((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) p32c73be0Var);
                        if (objOaiYYFLlvZKqUDIl is null) {
                            pbkmzOURQufZJPAP(subscriber);
                            return true;
                        }
                        qdTRWFhxiHMjjOKb(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p4c3c8cda(subscriber, objOaiYYFLlvZKqUDIl));
                    } catch (java.lang.Exception th) {
                        ZKtmlFPIHIRCsMqH(th);
                        MKaryfpUiuyLzucL(th, subscriber);
                        return true;
                    }
                } else {
                    kIKmxSZEUmvCwkBB(p32c73be0Var, subscriber);
                }
                return true;
            } catch (java.lang.Exception th2) {
                HhwRIiXpvRXyXrdd(th2);
                nWPrCBEMXIvWkYvy(th2, subscriber);
                return true;
            }
        } catch (java.lang.Exception th3) {
            gOZHYPBylrzZEDci(th3);
            CFdIMDcLfKpPKEAi(th3, subscriber);
            return true;
        }
    }

    public static <T, U> io.reactivex.rxjava3.core.Flowable<U> Mac2035ca(T t, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : U>> function) {
        return dFexZsmLrzhlRcsN(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p6f5e6c40$pc67f1241(t, function));
    }

    public static void NWPrCBEMXIvWkYvy(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object OaiYYFLlvZKqUDIl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void PbkmzOURQufZJPAP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.complete(p992c4a5bVar);
    }

    public static void QdTRWFhxiHMjjOKb(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object WpDObsrBFnZmccUg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }
}

