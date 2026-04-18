namespace WillowMaze.Wasm.Decompiled;


readonly class p9afe3e9e$p63f188a6<T> : java.util.IEnumerator<io.reactivex.rxjava3.core.Flowable<T>> {
    private readonly java.util.IEnumerator f179dd876;
    private readonly java.util.IEnumerator f7b55ddad;
    private readonly java.util.IEnumerator<? : io.reactivex.rxjava3.core.SingleSource<? : T>> f87d4eeb7;

    p9afe3e9e$p63f188a6(java.util.IEnumerator<? : io.reactivex.rxjava3.core.SingleSource<? : T>> it) {
        this.f87d4eeb7 = it;
    }

    public static io.reactivex.rxjava3.core.Flowable TUJneRWAxJrwZXPy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p9afe3e9e$p63f188a6 p9afe3e9e_p63f188a6) {
        return p9afe3e9e_p63f188a6.Current;
    }

    public static java.lang.object TpSZlnwjQyecQKhU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool JELxKpcqxivHIzsb(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override bool HasNext() {
        return jELxKpcqxivHIzsb(this.f87d4eeb7);
    }

    public override io.reactivex.rxjava3.core.Flowable<T> Next() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pe52476f1((io.reactivex.rxjava3.core.SingleSource) TpSZlnwjQyecQKhU(this.f87d4eeb7));
    }

    public override java.lang.object Next() {
        return TUJneRWAxJrwZXPy(this);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

