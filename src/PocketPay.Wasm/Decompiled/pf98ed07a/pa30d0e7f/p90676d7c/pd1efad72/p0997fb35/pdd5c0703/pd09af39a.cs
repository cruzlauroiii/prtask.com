namespace WillowMaze.Wasm.Decompiled;


public readonly class pd09af39a<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleOnSubscribe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleOnSubscribe f3ad96c29;
    readonly io.reactivex.rxjava3.core.SingleOnSubscribe f4536c8d3;

    public pd09af39a(io.reactivex.rxjava3.core.SingleOnSubscribe<T> singleOnSubscribe) {
        this.f36cd38f4 = singleOnSubscribe;
    }

    public static void HjwASwKwnkbqeDoX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pd09af39a$p7efb1083 pd09af39a_p7efb1083, java.lang.Exception th) {
        pd09af39a_p7efb1083.onError(th);
    }

    public static void LbcSkPsLbuyUvXPG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void AujeSybfGZEawJrm(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void DfKNiounxcmGJYZQ(io.reactivex.rxjava3.core.SingleOnSubscribe singleOnSubscribe, io.reactivex.rxjava3.core.SingleEmitter singleEmitter) throws java.lang.Exception {
        singleOnSubscribe.subscribe(singleEmitter);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pd09af39a$p7efb1083 pd09af39a_p7efb1083 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pd09af39a$p7efb1083(singleObserver);
        aujeSybfGZEawJrm(singleObserver, pd09af39a_p7efb1083);
        try {
            dfKNiounxcmGJYZQ(this.f36cd38f4, pd09af39a_p7efb1083);
        } catch (java.lang.Exception th) {
            LbcSkPsLbuyUvXPG(th);
            HjwASwKwnkbqeDoX(pd09af39a_p7efb1083, th);
        }
    }
}

