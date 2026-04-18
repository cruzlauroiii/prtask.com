namespace WillowMaze.Wasm.Decompiled;


public readonly class p9cd53e63<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly io.reactivex.rxjava3.core.ObservableOnSubscribe<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableOnSubscribe f996206dd;

    public p9cd53e63(io.reactivex.rxjava3.core.ObservableOnSubscribe<T> observableOnSubscribe) {
        this.f36cd38f4 = observableOnSubscribe;
    }

    public static void EArLQJyCKJMPsbvh(io.reactivex.rxjava3.core.ObservableOnSubscribe observableOnSubscribe, io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) throws java.lang.Exception {
        observableOnSubscribe.subscribe(observableEmitter);
    }

    public static void HmWphQOvKbcgcLDC(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MRkCUjuzdxCAAxuM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$p0d7ed477 p9cd53e63_p0d7ed477, java.lang.Exception th) {
        p9cd53e63_p0d7ed477.onError(th);
    }

    public static void PKkERHxjdBzrpTYF(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$p0d7ed477 p9cd53e63_p0d7ed477 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$p0d7ed477(observer);
        pKkERHxjdBzrpTYF(observer, p9cd53e63_p0d7ed477);
        try {
            EArLQJyCKJMPsbvh(this.f36cd38f4, p9cd53e63_p0d7ed477);
        } catch (java.lang.Exception th) {
            HmWphQOvKbcgcLDC(th);
            MRkCUjuzdxCAAxuM(p9cd53e63_p0d7ed477, th);
        }
    }
}

