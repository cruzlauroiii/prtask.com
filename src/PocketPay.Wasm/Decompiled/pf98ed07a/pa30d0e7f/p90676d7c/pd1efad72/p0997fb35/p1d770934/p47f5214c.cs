namespace WillowMaze.Wasm.Decompiled;


public readonly class p47f5214c<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly bool f2ea73815;
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.Observable f424db687;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f45f0e993;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly io.reactivex.rxjava3.core.Observable f86014830;
    readonly io.reactivex.rxjava3.core.Observable f964a3c8b;
    readonly bool fa9230d6d;
    readonly bool fb3ee217a;
    readonly bool fbf51a677;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fea69e321;
    readonly io.reactivex.rxjava3.core.Observable ffb8ef552;

    public p47f5214c(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void HkKUcbjCEnLQzetK(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public static bool HntiOEjIWzDKAMcE(java.lang.object obj, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p864fd216.m0695b60d(obj, p86408593Var, observer);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((19 + 7) % 7 > 0) {
        }
        if (hntiOEjIWzDKAMcE(this.f36cd38f4, this.f4b9f83e1, observer)) {
            return;
        }
        hkKUcbjCEnLQzetK(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p47f5214c$p66bb6546(observer, this.f4b9f83e1, this.f50fee566));
    }
}

