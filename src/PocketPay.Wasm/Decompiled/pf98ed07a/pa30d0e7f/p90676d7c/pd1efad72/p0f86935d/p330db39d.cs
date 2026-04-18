namespace WillowMaze.Wasm.Decompiled;


public readonly class p330db39d<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.Single f0c96a91e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f141135b0;
    readonly io.reactivex.rxjava3.core.Single f1c038639;
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.Single f4cd7454e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f544896c9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd88f6555;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff6bebed0;

    public p330db39d(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> function) {
        this.f36cd38f4 = single;
        this.f4b9f83e1 = function;
    }

    public static void WSlURgOYgSZNPFJE(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    public static void WSlURgOYgSZNPFJE(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WSlURgOYgSZNPFJE(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WSlURgOYgSZNPFJE(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((29 + 30) % 30 > 0) {
        }
        WSlURgOYgSZNPFJE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pc34cfcaf$pd5e3730c(observer, this.f4b9f83e1));
    }
}

