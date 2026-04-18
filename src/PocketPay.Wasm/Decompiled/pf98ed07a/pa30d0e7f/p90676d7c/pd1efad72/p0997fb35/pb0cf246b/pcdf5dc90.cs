namespace WillowMaze.Wasm.Decompiled;


public readonly class pcdf5dc90<T> : io.reactivex.rxjava3.core.Flowable<T> : io.reactivex.rxjava3.functions.Supplier<T> {
    readonly java.lang.Action f509c995b;
    readonly java.lang.Action f9a488edc;
    readonly java.lang.Action fa53108f7;
    readonly java.lang.Action fdfb4248e;
    readonly java.lang.Action ff810c54d;

    public pcdf5dc90(java.lang.Action runnable) {
        this.fa53108f7 = runnable;
    }

    public static void FGIVrfZxuoSHlMQe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void NpKuOrbSUiODunXQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool RwplDBvzbXPKybcY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void XOMRIFTlwsiptFeG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ZCFIOofftLActnrJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void AMRTfVjMvqLobxun(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void BWUPIuehSwYsTnkA(java.lang.Action runnable) {
        runnable.run();
    }

    public static bool TFAQeLHQqgJNFgku(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static bool XCaeITqRwXEMXKni(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var) {
        return p9ec25025Var.isDisposed();
    }

    public static void XFZBfLHIiZhfyYKM(java.lang.Action runnable) {
        runnable.run();
    }

    public T Get() throws java.lang.Exception {
        bWUPIuehSwYsTnkA(this.fa53108f7);
        return null;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((21 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025 p9ec25025Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.p9ec25025();
        NpKuOrbSUiODunXQ(subscriber, p9ec25025Var);
        if (RwplDBvzbXPKybcY(p9ec25025Var)) {
            return;
        }
        try {
            xFZBfLHIiZhfyYKM(this.fa53108f7);
            if (xCaeITqRwXEMXKni(p9ec25025Var)) {
                return;
            }
            FGIVrfZxuoSHlMQe(subscriber);
        } catch (java.lang.Exception th) {
            XOMRIFTlwsiptFeG(th);
            if (tFAQeLHQqgJNFgku(p9ec25025Var)) {
                aMRTfVjMvqLobxun(th);
            } else {
                ZCFIOofftLActnrJ(subscriber, th);
            }
        }
    }
}

