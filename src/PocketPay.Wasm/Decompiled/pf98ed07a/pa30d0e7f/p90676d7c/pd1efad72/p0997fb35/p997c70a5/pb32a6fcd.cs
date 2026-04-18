namespace WillowMaze.Wasm.Decompiled;


public readonly class pb32a6fcd<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f1a4f6e5a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa04de1c3;

    public pb32a6fcd(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : io.reactivex.rxjava3.core.ObservableSource<? : T>> function) {
        super(observableSource);
        this.f1a4f6e5a = function;
    }

    public static void CnPlVEMDLNgqilyF(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void FjBKWnSchVNFZxdd(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((15 + 27) % 27 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb32a6fcd$pba31132c pb32a6fcd_pba31132c = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pb32a6fcd$pba31132c(observer, this.f1a4f6e5a);
        fjBKWnSchVNFZxdd(observer, pb32a6fcd_pba31132c.f79106d6f);
        cnPlVEMDLNgqilyF(this.f36cd38f4, pb32a6fcd_pba31132c);
    }
}

