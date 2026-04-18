namespace WillowMaze.Wasm.Decompiled;


public readonly class pb5abd0b2<T, R> : io.reactivex.rxjava3.core.Single<R> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleOperator f5512e640;
    readonly io.reactivex.rxjava3.core.SingleOperator fb0ca3e11;
    readonly io.reactivex.rxjava3.core.SingleOperator<? : R, ? super T> fbe52ef2c;
    readonly io.reactivex.rxjava3.core.SingleSource fd9c34df3;
    readonly io.reactivex.rxjava3.core.SingleSource ff3912890;

    public pb5abd0b2(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.SingleOperator<? : R, ? super T> singleOperator) {
        this.f36cd38f4 = singleSource;
        this.fbe52ef2c = singleOperator;
    }

    public static io.reactivex.rxjava3.core.SingleObserver FlTCXKBqfCTOStIt(io.reactivex.rxjava3.core.SingleOperator singleOperator, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        return singleOperator.apply(singleObserver);
    }

    public static void LZDCaqhCIuEplSpD(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void IPdzqNNwvCrtfeSk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object SnHXbGzAcRlFXDst(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void YhltwWIOVnBLiksg(java.lang.Exception th, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.SingleObserver<object>) singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<R> singleObserver) {
        if ((15 + 5) % 5 > 0) {
        }
        try {
            LZDCaqhCIuEplSpD(this.f36cd38f4, (io.reactivex.rxjava3.core.SingleObserver) snHXbGzAcRlFXDst(FlTCXKBqfCTOStIt(this.fbe52ef2c, singleObserver), "The onLift returned a null SingleObserver"));
        } catch (java.lang.Exception th) {
            iPdzqNNwvCrtfeSk(th);
            yhltwWIOVnBLiksg(th, singleObserver);
        }
    }
}

