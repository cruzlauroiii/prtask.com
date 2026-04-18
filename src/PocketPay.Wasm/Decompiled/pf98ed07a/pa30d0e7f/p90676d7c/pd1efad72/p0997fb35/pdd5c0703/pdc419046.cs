namespace WillowMaze.Wasm.Decompiled;


public readonly class pdc419046<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f6eb48dac;
    readonly io.reactivex.rxjava3.core.SingleSource f8ac57214;
    readonly io.reactivex.rxjava3.core.SingleSource ff5060f4f;

    public pdc419046(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource) {
        this.f36cd38f4 = singleSource;
    }

    public static void IIqAACHyjhqePQeZ(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static io.reactivex.rxjava3.core.SingleObserver YQvQrftCxMIhPRFa(io.reactivex.rxjava3.core.Observer observer) {
        return m76ea0beb(observer);
    }

    public static <T> io.reactivex.rxjava3.core.SingleObserver<T> M76ea0beb(io.reactivex.rxjava3.core.Observer<T> observer) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pdc419046$p6d42c5af(observer);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        IIqAACHyjhqePQeZ(this.f36cd38f4, YQvQrftCxMIhPRFa(observer));
    }
}

