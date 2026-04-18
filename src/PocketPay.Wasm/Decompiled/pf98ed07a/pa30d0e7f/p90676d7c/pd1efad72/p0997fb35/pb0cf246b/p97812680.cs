namespace WillowMaze.Wasm.Decompiled;


public readonly class p97812680<T, S> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f066c59e9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f14f99434;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f3e94f789;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f436c44a5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f73b3b7f3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f90740d6e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa79d246b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fb16ddeff;
    readonly io.reactivex.rxjava3.functions.Consumer<S> fbadb7a12;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fcf493711;
    readonly io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> fdac9630a;
    readonly io.reactivex.rxjava3.functions.Supplier<S> ffa360800;

    public p97812680(io.reactivex.rxjava3.functions.Supplier<S> supplier, io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> biFunction, io.reactivex.rxjava3.functions.Consumer<S> consumer) {
        this.ffa360800 = supplier;
        this.fdac9630a = biFunction;
        this.fbadb7a12 = consumer;
    }

    public static void GfgLYDthCdNSiBnr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object ITTHBAQgKCpKhMwx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QKaCqamWiPKFLWoG(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static void VWPtkhShdXOxqhpH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((5 + 28) % 28 > 0) {
        }
        try {
            vWPtkhShdXOxqhpH(subscriber, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p97812680$p16ae4f80(subscriber, this.fdac9630a, this.fbadb7a12, iTTHBAQgKCpKhMwx(this.ffa360800)));
        } catch (java.lang.Exception th) {
            gfgLYDthCdNSiBnr(th);
            qKaCqamWiPKFLWoG(th, subscriber);
        }
    }
}

