namespace WillowMaze.Wasm.Decompiled;


public readonly class pbe069a49<T> : io.reactivex.rxjava3.core.Maybe<T> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p16a0487a.pe349b74c {
    readonly io.reactivex.rxjava3.core.CompletableSource f36cd38f4;
    readonly io.reactivex.rxjava3.core.CompletableSource f73fc116a;
    readonly io.reactivex.rxjava3.core.CompletableSource f903b592e;
    readonly io.reactivex.rxjava3.core.CompletableSource f9a9dc841;
    readonly io.reactivex.rxjava3.core.CompletableSource feeb05a27;

    public pbe069a49(io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = completableSource;
    }

    public static void QppcunjnssiHFXND(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    public override io.reactivex.rxjava3.core.CompletableSource Source() {
        return this.f36cd38f4;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        qppcunjnssiHFXND(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pbe069a49$p93332f27(maybeObserver));
    }
}

