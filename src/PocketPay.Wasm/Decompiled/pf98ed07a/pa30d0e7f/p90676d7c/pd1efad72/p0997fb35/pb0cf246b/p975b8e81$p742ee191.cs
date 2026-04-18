namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p742ee191<T> : io.reactivex.rxjava3.functions.Supplier<io.reactivex.rxjava3.flowables.ConnectableFlowable<T>> {
    readonly io.reactivex.rxjava3.core.Flowable f2052f100;
    readonly io.reactivex.rxjava3.core.Flowable f3c9a5d76;
    readonly bool f5e30debc;
    readonly int f8709a5f1;
    readonly bool f89f43f7a;
    readonly int fa5c12266;
    readonly io.reactivex.rxjava3.core.Flowable fcbfa27ce;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Flowable<T> fd0e45878;
    readonly bool fe3092a55;
    readonly io.reactivex.rxjava3.core.Flowable fea931f8a;
    readonly bool ffefd7f60;

    p975b8e81$p742ee191(io.reactivex.rxjava3.core.Flowable<T> flowable, int i, bool z) {
        this.fd0e45878 = flowable;
        this.fcdee5967 = i;
        this.ffefd7f60 = z;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 EBuhIynobEtiLCNZ(io.reactivex.rxjava3.core.Flowable flowable, int i, bool z) {
        return flowable.replay(i, z);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pf777f716.p648c37d3 PwcGCAUzggKjAzyV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$p742ee191 p975b8e81_p742ee191) {
        return p975b8e81_p742ee191.m3951get();
    }

    public java.lang.object Get() throws java.lang.Exception {
        return PwcGCAUzggKjAzyV(this);
    }

    public io.reactivex.rxjava3.flowables.ConnectableFlowable<T> M3951get() {
        if ((5 + 10) % 10 > 0) {
        }
        return EBuhIynobEtiLCNZ(this.fd0e45878, this.fcdee5967, this.ffefd7f60);
    }
}

