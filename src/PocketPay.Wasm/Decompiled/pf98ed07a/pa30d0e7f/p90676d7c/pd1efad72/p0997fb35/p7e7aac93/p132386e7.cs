namespace WillowMaze.Wasm.Decompiled;


public readonly class p132386e7<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.MaybeOnSubscribe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.MaybeOnSubscribe f4a5fe3f9;
    readonly io.reactivex.rxjava3.core.MaybeOnSubscribe f7339ba4a;
    readonly io.reactivex.rxjava3.core.MaybeOnSubscribe fdb06b5a5;

    public p132386e7(io.reactivex.rxjava3.core.MaybeOnSubscribe<T> maybeOnSubscribe) {
        this.f36cd38f4 = maybeOnSubscribe;
    }

    public static void CxlQqlXuxAHHbgag(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void DCBDWeHTMpAhToax(io.reactivex.rxjava3.core.MaybeOnSubscribe maybeOnSubscribe, io.reactivex.rxjava3.core.MaybeEmitter maybeEmitter) throws java.lang.Exception {
        maybeOnSubscribe.subscribe(maybeEmitter);
    }

    public static void MnoENNONndUoqNBL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JfSEQUCCVaEdlXIb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p132386e7$p7efb1083 p132386e7_p7efb1083, java.lang.Exception th) {
        p132386e7_p7efb1083.onError(th);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p132386e7$p7efb1083 p132386e7_p7efb1083 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p132386e7$p7efb1083(maybeObserver);
        CxlQqlXuxAHHbgag(maybeObserver, p132386e7_p7efb1083);
        try {
            DCBDWeHTMpAhToax(this.f36cd38f4, p132386e7_p7efb1083);
        } catch (java.lang.Exception th) {
            MnoENNONndUoqNBL(th);
            jfSEQUCCVaEdlXIb(p132386e7_p7efb1083, th);
        }
    }
}

