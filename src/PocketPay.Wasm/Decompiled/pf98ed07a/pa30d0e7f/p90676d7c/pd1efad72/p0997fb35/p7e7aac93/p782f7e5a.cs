namespace WillowMaze.Wasm.Decompiled;


public readonly class p782f7e5a<T> : io.reactivex.rxjava3.internal.operators.maybe.AbstractMaybeWithUpstream<T, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f55cfebeb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f9a21b38e;

    public p782f7e5a(io.reactivex.rxjava3.core.MaybeSource<T> maybeSource, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) {
        super(maybeSource);
        this.f55cfebeb = p004bf6c9Var;
    }

    public static void EZgPqwLKidhQQYcp(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver) {
        if ((15 + 29) % 29 > 0) {
        }
        eZgPqwLKidhQQYcp(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p782f7e5a$p4450821b(maybeObserver, this.f55cfebeb));
    }
}

