namespace WillowMaze.Wasm.Decompiled;


readonly class p88d71a70$p1a8685d9<T> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f3ece3f39 = 466549804534799122L;
    private static readonly long fb3e8e872 = 466549804534799122L;
    private static readonly long fc6e1e520 = 466549804534799122L;
    private static readonly long fe524e9ac = 466549804534799122L;
    readonly io.reactivex.rxjava3.core.Observer f0910c540;
    java.lang.object f1c85e748;
    java.lang.object f26ea2c7b;
    java.lang.object f3599b417;
    volatile bool f38881e0a;
    volatile bool f42f0efda;
    readonly io.reactivex.rxjava3.core.Observer f44370941;
    volatile bool f443cefa6;
    java.lang.object f6665365b;
    java.lang.object f6a992d55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p88d71a70 f772ef211;
    readonly io.reactivex.rxjava3.subjects.ReplaySubject<T> f9ed39e2e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p88d71a70 fa7122a86;
    readonly io.reactivex.rxjava3.core.Observer fba1dc04d;
    volatile bool fc6bb4168;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    p88d71a70$p1a8685d9(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.subjects.ReplaySubject<T> replaySubject) {
        this.fd22a0a80 = observer;
        this.f9ed39e2e = replaySubject;
    }

    public static void UZlpdEsbgurOjWRi(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p88d71a70 p88d71a70Var, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p88d71a70$p1a8685d9 p88d71a70_p1a8685d9) {
        p88d71a70Var.Remove(p88d71a70_p1a8685d9);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        uZlpdEsbgurOjWRi(this.f9ed39e2e, this);
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }
}

