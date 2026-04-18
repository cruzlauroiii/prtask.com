namespace WillowMaze.Wasm.Decompiled;


public readonly class pb1d4328a<T> : io.reactivex.rxjava3.core.Maybe<T> {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f57d20cec;
    readonly io.reactivex.rxjava3.core.CompletableSource fa387da26;
    readonly io.reactivex.rxjava3.core.CompletableSource fbbf3e5ec;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;
    readonly io.reactivex.rxjava3.core.CompletableSource fed6f649b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fef6a504e;

    public pb1d4328a(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function) {
        this.f36cd38f4 = completableSource;
        this.fdb9d6c56 = function;
    }

    public static void MzItZyQwWBNQWjgn(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void MzItZyQwWBNQWjgn(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzItZyQwWBNQWjgn(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MzItZyQwWBNQWjgn(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((18 + 30) % 30 > 0) {
        }
        MzItZyQwWBNQWjgn(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb5d94615.pb1d4328a$p4bc0959a(maybeObserver, this.fdb9d6c56));
    }
}

