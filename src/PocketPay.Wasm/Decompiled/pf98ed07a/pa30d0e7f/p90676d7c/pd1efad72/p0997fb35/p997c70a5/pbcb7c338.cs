namespace WillowMaze.Wasm.Decompiled;


public readonly class pbcb7c338<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.core.Single<U> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<U> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f590a3e62;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f5e9a47a2;
    readonly io.reactivex.rxjava3.core.ObservableSource f937d00da;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fa120b672;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 feb536e9d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 ff0aeb4f2;

    public pbcb7c338(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, int i) {
        this.f36cd38f4 = observableSource;
        this.f590a3e62 = gOdUMxXfMAtxHgbe(i);
    }

    public pbcb7c338(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        this.f36cd38f4 = observableSource;
        this.f590a3e62 = supplier;
    }

    public static void HOXRBlzcUIxUfgJj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object LAvPPdVGvfNNaqQb(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void UDZMKPtQqGulidFM(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object AwQDKepPxVHiyXyt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 GOdUMxXfMAtxHgbe(int i) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14.ma49f7045(i);
    }

    public static io.reactivex.rxjava3.core.Observable XxsQEZGLLianbbjM(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void ZRmRFcBrlTGUIByf(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    public io.reactivex.rxjava3.core.Observable<U> FuseToObservable() {
        if ((24 + 24) % 24 > 0) {
        }
        return xxsQEZGLLianbbjM(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p4d96459e(this.f36cd38f4, this.f590a3e62));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<U> singleObserver) {
        if ((19 + 10) % 10 > 0) {
        }
        try {
            UDZMKPtQqGulidFM(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbcb7c338$p0a1915a4(singleObserver, (java.util.ICollection) LAvPPdVGvfNNaqQb(awQDKepPxVHiyXyt(this.f590a3e62), "The collectionSupplier returned a null ICollection.")));
        } catch (java.lang.Exception th) {
            HOXRBlzcUIxUfgJj(th);
            zRmRFcBrlTGUIByf(th, singleObserver);
        }
    }
}

