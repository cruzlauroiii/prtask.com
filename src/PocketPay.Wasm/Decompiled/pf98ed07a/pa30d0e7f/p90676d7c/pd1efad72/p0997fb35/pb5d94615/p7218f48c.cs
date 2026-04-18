namespace WillowMaze.Wasm.Decompiled;


public readonly class p7218f48c<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f03bc4e75;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f04d6939c;
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f49778dd0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f65ae58a9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc2e71d37;
    readonly java.lang.object fcac9e50d;
    readonly T ff5a26224;
    readonly io.reactivex.rxjava3.functions.Supplier<? : T> ffbd2e0b3;

    public p7218f48c(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.functions.Supplier<? : T> supplier, T t) {
        this.f36cd38f4 = completableSource;
        this.ff5a26224 = t;
        this.ffbd2e0b3 = supplier;
    }

    public static void VFftvxkltHPgwsWg(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public static void VFftvxkltHPgwsWg(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VFftvxkltHPgwsWg(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VFftvxkltHPgwsWg(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((14 + 24) % 24 > 0) {
        }
        VFftvxkltHPgwsWg(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb5d94615.p7218f48c$p169877fb(this, singleObserver));
    }
}

