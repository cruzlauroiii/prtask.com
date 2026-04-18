namespace WillowMaze.Wasm.Decompiled;


public readonly class p69ec5f87<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.functions.Supplier<? : org.reactivestreams.Publisher<? : T>> f99b0e8da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f99dfdc76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc2be3d74;

    public p69ec5f87(io.reactivex.rxjava3.functions.Supplier<? : org.reactivestreams.Publisher<? : T>> supplier) {
        this.f99b0e8da = supplier;
    }

    public static void DBkHfMfgmiGddWlW(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object FurtKliFNRZMpLhB(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void ZtklTHuPUkcbmzzN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object HiABnXKyufVQYtTc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void XuYjuhSvuUyHqgoY(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        try {
            xuYjuhSvuUyHqgoY((p5a445d71.p18f29add.p32c73be0) FurtKliFNRZMpLhB(hiABnXKyufVQYtTc(this.f99b0e8da), "The publisher supplied is null"), subscriber);
        } catch (java.lang.Exception th) {
            ZtklTHuPUkcbmzzN(th);
            DBkHfMfgmiGddWlW(th, subscriber);
        }
    }
}

