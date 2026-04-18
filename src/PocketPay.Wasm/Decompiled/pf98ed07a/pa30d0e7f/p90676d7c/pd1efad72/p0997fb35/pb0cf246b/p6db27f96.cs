namespace WillowMaze.Wasm.Decompiled;


public readonly class p6db27f96<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f05fe7393;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f2b226b4e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f998b6ad0;
    readonly io.reactivex.rxjava3.functions.Supplier<? : T> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fcedda894;

    public p6db27f96(io.reactivex.rxjava3.functions.Supplier<? : T> supplier) {
        this.f99b0e8da = supplier;
    }

    public static void DfoZEwcTEsZIHqbs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object HOaKclLohuMEMtCL(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void VBvPHebxqjoTkrvd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool XDkGWdnPDYLQfzHB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        return pb7d2cb4cVar.isCancelled();
    }

    public static void XzwpnrmDPyYjMDCm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar, java.lang.object obj) {
        pb7d2cb4cVar.complete(obj);
    }

    public static java.lang.object ESUimfolCuZqxVnD(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object JIIGWKbIiZAUzhCv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JvMrmXeDjNMHIyOQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WzHymukhAkpMhBkw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object ZOZjtzBBYMAcHZvP(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public T Get() throws java.lang.Exception {
        return (T) jIIGWKbIiZAUzhCv(eSUimfolCuZqxVnD(this.f99b0e8da), "The supplier returned a null value");
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((20 + 30) % 30 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c(subscriber);
        jvMrmXeDjNMHIyOQ(subscriber, pb7d2cb4cVar);
        try {
            XzwpnrmDPyYjMDCm(pb7d2cb4cVar, HOaKclLohuMEMtCL(zOZjtzBBYMAcHZvP(this.f99b0e8da), "The supplier returned a null value"));
        } catch (java.lang.Exception th) {
            VBvPHebxqjoTkrvd(th);
            if (XDkGWdnPDYLQfzHB(pb7d2cb4cVar)) {
                DfoZEwcTEsZIHqbs(th);
            } else {
                wzHymukhAkpMhBkw(subscriber, th);
            }
        }
    }
}

