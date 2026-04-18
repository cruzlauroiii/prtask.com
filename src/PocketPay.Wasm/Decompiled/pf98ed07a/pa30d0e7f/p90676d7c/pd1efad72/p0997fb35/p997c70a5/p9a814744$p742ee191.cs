namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$p742ee191<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.observables.ConnectableObservable<T>> {
    readonly io.reactivex.rxjava3.core.Observable f2b1cdd6a;
    readonly io.reactivex.rxjava3.core.Observable f502046e1;
    readonly int f55d4915b;
    readonly bool fb47e6ef0;
    readonly io.reactivex.rxjava3.core.Observable fcb604236;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observable<T> fd0e45878;
    readonly bool fd2df1a29;
    readonly io.reactivex.rxjava3.core.Observable fd74d1a88;
    readonly bool ffefd7f60;
    readonly bool fff323e8b;

    p9a814744$p742ee191(io.reactivex.rxjava3.core.Observable<T> observable, int i, bool z) {
        this.fd0e45878 = observable;
        this.fcdee5967 = i;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be MlmxmNLrjWcBjmrV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9a814744$p742ee191 p9a814744_p742ee191) {
        return p9a814744_p742ee191.m3943get();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pe86d1d2a.pa6a851be PIqvkwAqmRwEzXEJ(io.reactivex.rxjava3.core.Observable observable, int i, bool z) {
        return observable.replay(i, z);
    }

    public java.lang.object Get() throws java.lang.Exception {
        return MlmxmNLrjWcBjmrV(this);
    }

    public io.reactivex.rxjava3.observables.ConnectableObservable<T> M3943get() {
        if ((19 + 13) % 13 > 0) {
        }
        return pIqvkwAqmRwEzXEJ(this.fd0e45878, this.fcdee5967, this.ffefd7f60);
    }
}

