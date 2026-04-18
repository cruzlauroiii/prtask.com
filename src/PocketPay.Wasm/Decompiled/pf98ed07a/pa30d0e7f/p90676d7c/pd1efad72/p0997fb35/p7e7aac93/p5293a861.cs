namespace WillowMaze.Wasm.Decompiled;


public readonly class p5293a861<T, R> : io.reactivex.rxjava3.core.Maybe<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f31626a91;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4147477f;
    readonly io.reactivex.rxjava3.core.MaybeSource[] fc0be55c3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc5754d32;
    readonly io.reactivex.rxjava3.core.MaybeSource[] fc687d064;
    readonly io.reactivex.rxjava3.core.MaybeSource[] fd755e5d6;
    readonly io.reactivex.rxjava3.core.MaybeSource[] feb89f3d8;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T>[] ff2ab5fb2;

    public p5293a861(io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function) {
        this.ff2ab5fb2 = maybeSourceArr;
        this.f3298b476 = function;
    }

    public static bool CHDVAVJriTGcRpXN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22) {
        return p5293a861_pcbceec22.isDisposed();
    }

    public static void IlDYGoJvOclzezdk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22, java.lang.Exception th, int i) {
        p5293a861_pcbceec22.innerError(th, i);
    }

    public static void GYrFjOKuZuTlaQpS(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void SQkttowcwrtiaVpv(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void TFyzEqKixrgrjdiY(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<R> maybeObserver) {
        if ((15 + 28) % 28 > 0) {
        }
        io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr = this.ff2ab5fb2;
        int length = maybeSourceArr.length;
        if (length == 1) {
            tFyzEqKixrgrjdiY(maybeSourceArr[0], new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p87a59ce6$p6bec872e(maybeObserver, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pfb7c43fc(this)));
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22 p5293a861_pcbceec22 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p5293a861$pcbceec22(maybeObserver, length, this.f3298b476);
        gYrFjOKuZuTlaQpS(maybeObserver, p5293a861_pcbceec22);
        for (int i = 0; i < length && !CHDVAVJriTGcRpXN(p5293a861_pcbceec22); i++) {
            io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource = maybeSourceArr[i];
            if (maybeSource is null) {
                IlDYGoJvOclzezdk(p5293a861_pcbceec22, new java.lang.NullPointerException("One of the sources is null"), i);
                return;
            }
            sQkttowcwrtiaVpv(maybeSource, p5293a861_pcbceec22.f6ea648a6[i]);
        }
    }
}

