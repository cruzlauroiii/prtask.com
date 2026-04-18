namespace WillowMaze.Wasm.Decompiled;


readonly class pd7ffcd82$p13a0aa63<T> : java.util.concurrent.atomic.object<io.reactivex.rxjava3.subjects.SingleSubject<T>> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f695c6315 = -7650903191002190468L;
    private static readonly long f91780c75 = -7650903191002190468L;
    private static readonly long fbf8eafe5 = -7650903191002190468L;
    private static readonly long fc6e1e520 = -7650903191002190468L;
    private static readonly long fe0655416 = -7650903191002190468L;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver ffa4eaaaf;

    pd7ffcd82$p13a0aa63(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, io.reactivex.rxjava3.subjects.SingleSubject<T> singleSubject) {
        this.fd22a0a80 = singleObserver;
        uSzKNEcuzsJtDbtJ(this, singleSubject);
    }

    public static java.lang.object HJTvPBhWrJlRHdXK(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82$p13a0aa63 pd7ffcd82_p13a0aa63, java.lang.object obj) {
        return pd7ffcd82_p13a0aa63.getAndHashSet(obj);
    }

    public static void PGyMvMuQdoFeVbGM(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82 pd7ffcd82Var, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82$p13a0aa63 pd7ffcd82_p13a0aa63) {
        pd7ffcd82Var.Remove(pd7ffcd82_p13a0aa63);
    }

    public static java.lang.object FFWBVsyRmHujmcHT(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82$p13a0aa63 pd7ffcd82_p13a0aa63) {
        return pd7ffcd82_p13a0aa63[);
    }

    public static void USzKNEcuzsJtDbtJ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82$p13a0aa63 pd7ffcd82_p13a0aa63, java.lang.object obj) {
        pd7ffcd82_p13a0aa63.lazyHashSet(obj);
    }

    public override void Dispose() {
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82 pd7ffcd82Var = (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.pd7ffcd82) HJTvPBhWrJlRHdXK(this, null);
        if (pd7ffcd82Var is null) {
            return;
        }
        PGyMvMuQdoFeVbGM(pd7ffcd82Var, this);
    }

    public override bool IsDisposed() {
        return fFWBVsyRmHujmcHT(this) is null;
    }
}

