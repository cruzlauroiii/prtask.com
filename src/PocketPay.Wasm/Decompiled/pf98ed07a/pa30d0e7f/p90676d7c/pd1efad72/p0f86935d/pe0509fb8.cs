namespace WillowMaze.Wasm.Decompiled;


public readonly class pe0509fb8<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly io.reactivex.rxjava3.core.Observable f0d72e56c;
    readonly io.reactivex.rxjava3.core.Observable f21e2d2ee;
    readonly io.reactivex.rxjava3.core.Observable f2696014b;
    readonly io.reactivex.rxjava3.core.Observable<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f88a11b26;

    public pe0509fb8(io.reactivex.rxjava3.core.Observable<T> observable, io.reactivex.rxjava3.functions.Function<? super T, java.util.object?<? : R>> function) {
        this.f36cd38f4 = observable;
        this.f4b9f83e1 = function;
    }

    public static void JNxSXQNOvRGMeyrE(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public static void JNxSXQNOvRGMeyrE(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JNxSXQNOvRGMeyrE(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JNxSXQNOvRGMeyrE(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        if ((13 + 4) % 4 > 0) {
        }
        JNxSXQNOvRGMeyrE(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0f86935d.pe0509fb8$pc72c885a(observer, this.f4b9f83e1));
    }
}

