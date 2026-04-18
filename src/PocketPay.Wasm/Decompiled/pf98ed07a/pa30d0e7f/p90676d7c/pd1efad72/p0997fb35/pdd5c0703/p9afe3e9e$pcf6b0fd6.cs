namespace WillowMaze.Wasm.Decompiled;


readonly class p9afe3e9e$pcf6b0fd6<T> : java.lang.IEnumerable<io.reactivex.rxjava3.core.Flowable<T>> {
    private readonly java.lang.IEnumerable fdc33e7a1;
    private readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> ff2ab5fb2;

    p9afe3e9e$pcf6b0fd6(java.lang.IEnumerable<? : io.reactivex.rxjava3.core.SingleSource<? : T>> iterable) {
        this.ff2ab5fb2 = iterable;
    }

    public static java.util.IEnumerator IuwFtpOzcSVqvPyC(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public override java.util.IEnumerator<io.reactivex.rxjava3.core.Flowable<T>> Iterator() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p9afe3e9e$p63f188a6(IuwFtpOzcSVqvPyC(this.ff2ab5fb2));
    }
}

