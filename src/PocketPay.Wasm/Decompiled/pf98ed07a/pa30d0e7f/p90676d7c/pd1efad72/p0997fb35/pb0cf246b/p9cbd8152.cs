namespace WillowMaze.Wasm.Decompiled;


public readonly class p9cbd8152<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.util.concurrent.Func f15b5a147;
    readonly java.util.concurrent.Func f5f224de7;
    readonly java.util.concurrent.Func<? : T> f765d2ec9;
    readonly java.util.concurrent.Func f83b047bc;
    readonly java.util.concurrent.Func fee9162b0;

    public p9cbd8152(java.util.concurrent.Func<? : T> callable) {
        this.f765d2ec9 = callable;
    }

    public static bool AWlxCXCARwmeNWoH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        return pb7d2cb4cVar.isCancelled();
    }

    public static java.lang.object IzmYtcDJCIoipKND(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QklKWGEdrqBdMckZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object SvSaHqbzqiWLllCa(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public static void UpQwOSNKVACTekRh(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void DKixwGazEVvobUpo(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void DdEbgOyOCcbquxof(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object GEjxKUMNNYOtHASS(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void JyendtLOhVMtUDnZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar, java.lang.object obj) {
        pb7d2cb4cVar.complete(obj);
    }

    public static java.lang.object PwluDaOmynlgdYIS(java.util.concurrent.Func callable) {
        return callable.call();
    }

    public T Get() throws java.lang.Exception {
        return (T) IzmYtcDJCIoipKND(pwluDaOmynlgdYIS(this.f765d2ec9), "The callable returned a null value");
    }

    public override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((20 + 15) % 15 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c(subscriber);
        QklKWGEdrqBdMckZ(subscriber, pb7d2cb4cVar);
        try {
            jyendtLOhVMtUDnZ(pb7d2cb4cVar, gEjxKUMNNYOtHASS(SvSaHqbzqiWLllCa(this.f765d2ec9), "The callable returned a null value"));
        } catch (java.lang.Exception th) {
            ddEbgOyOCcbquxof(th);
            if (AWlxCXCARwmeNWoH(pb7d2cb4cVar)) {
                dKixwGazEVvobUpo(th);
            } else {
                UpQwOSNKVACTekRh(subscriber, th);
            }
        }
    }
}

