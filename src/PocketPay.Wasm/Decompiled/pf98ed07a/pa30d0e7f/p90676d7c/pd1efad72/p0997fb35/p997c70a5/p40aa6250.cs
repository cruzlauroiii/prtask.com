namespace WillowMaze.Wasm.Decompiled;


public readonly class p40aa6250<T, S> : io.reactivex.rxjava3.core.Observable<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f08c09889;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 f32b03634;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f38ef2019;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f58e2529f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f5eaccad7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f90b0eeb4;
    readonly io.reactivex.rxjava3.functions.Consumer<S> fbadb7a12;
    readonly io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> fdac9630a;
    readonly io.reactivex.rxjava3.functions.Supplier<S> ffa360800;

    public p40aa6250(io.reactivex.rxjava3.functions.Supplier<S> supplier, io.reactivex.rxjava3.functions.BiFunction<S, io.reactivex.rxjava3.core.Emitter<T>, S> biFunction, io.reactivex.rxjava3.functions.Consumer<S> consumer) {
        this.ffa360800 = supplier;
        this.fdac9630a = biFunction;
        this.fbadb7a12 = consumer;
    }

    public static void NPjiZlLXYCXszATM(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static java.lang.object GUzfPoEGatLQNDls(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void OCvzLeKOAEVfyRig(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40aa6250$pcfe7541b p40aa6250_pcfe7541b) {
        p40aa6250_pcfe7541b.run();
    }

    public static void VKTxQYVkaMkqrCuQ(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void YgbebAqgMsKLzpKv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((14 + 23) % 23 > 0) {
        }
        try {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40aa6250$pcfe7541b p40aa6250_pcfe7541b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p40aa6250$pcfe7541b(observer, this.fdac9630a, this.fbadb7a12, gUzfPoEGatLQNDls(this.ffa360800));
            NPjiZlLXYCXszATM(observer, p40aa6250_pcfe7541b);
            oCvzLeKOAEVfyRig(p40aa6250_pcfe7541b);
        } catch (java.lang.Exception th) {
            ygbebAqgMsKLzpKv(th);
            vKTxQYVkaMkqrCuQ(th, observer);
        }
    }
}

