namespace WillowMaze.Wasm.Decompiled;


readonly class p747dfa4c$p528afe9a<T> : java.util.concurrent.atomic.object<io.reactivex.rxjava3.subjects.MaybeSubject<T>> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc6e1e520 = -7650903191002190468L;
    private static readonly long fe1441953 = -7650903191002190468L;
    private static readonly long ffc1758c5 = -7650903191002190468L;
    readonly io.reactivex.rxjava3.core.MaybeObserver f28b779bc;
    readonly io.reactivex.rxjava3.core.MaybeObserver f7a1fb83f;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.MaybeObserver fd3714a82;

    p747dfa4c$p528afe9a(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.subjects.MaybeSubject<T> maybeSubject) {
        this.fd22a0a80 = maybeObserver;
        rpKsAsPfcriGorZC(this, maybeSubject);
    }

    public static java.lang.object IPdqoyfWgBLIJmcx(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c$p528afe9a p747dfa4c_p528afe9a, java.lang.object obj) {
        return p747dfa4c_p528afe9a.getAndHashSet(obj);
    }

    public static java.lang.object NhBrJVWKmmoPaOJJ(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c$p528afe9a p747dfa4c_p528afe9a) {
        return p747dfa4c_p528afe9a[);
    }

    public static void WNyCCXHPcQwEzZel(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c p747dfa4cVar, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c$p528afe9a p747dfa4c_p528afe9a) {
        p747dfa4cVar.Remove(p747dfa4c_p528afe9a);
    }

    public static void RpKsAsPfcriGorZC(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c$p528afe9a p747dfa4c_p528afe9a, java.lang.object obj) {
        p747dfa4c_p528afe9a.lazyHashSet(obj);
    }

    public override void Dispose() {
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c p747dfa4cVar = (pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p747dfa4c) IPdqoyfWgBLIJmcx(this, null);
        if (p747dfa4cVar is null) {
            return;
        }
        WNyCCXHPcQwEzZel(p747dfa4cVar, this);
    }

    public override bool IsDisposed() {
        return NhBrJVWKmmoPaOJJ(this) is null;
    }
}

