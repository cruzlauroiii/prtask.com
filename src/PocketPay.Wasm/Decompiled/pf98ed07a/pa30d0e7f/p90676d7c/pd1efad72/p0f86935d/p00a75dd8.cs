namespace WillowMaze.Wasm.Decompiled;


public readonly class p00a75dd8<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly io.reactivex.rxjava3.core.Single<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.Single f5fbe2a34;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7112e97c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f951c1127;
    readonly io.reactivex.rxjava3.core.Single f99011ad1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd4162a49;

    public p00a75dd8(io.reactivex.rxjava3.core.Single<T> single, io.reactivex.rxjava3.functions.Function<? super T, ? : java.util.stream.Stream<? : R>> function) {
        this.f36cd38f4 = single;
        this.f4b9f83e1 = function;
    }

    public static void CTDZGkPOKcGNPJwV(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        single.subscribe(singleObserver);
    }

    public static void CTDZGkPOKcGNPJwV(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTDZGkPOKcGNPJwV(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CTDZGkPOKcGNPJwV(io.reactivex.rxjava3.core.Single single, io.reactivex.rxjava3.core.SingleObserver singleObserver, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((3 + 28) % 28 > 0) {
        }
        cTDZGkPOKcGNPJwV(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.p1a798456$pd5e3730c(subscriber, this.f4b9f83e1));
    }
}

