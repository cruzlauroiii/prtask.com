namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p73c50ada$p35f6b268$1<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p13ff1b30 $this_waitInProcessTransaction;
    readonly java.lang.string $trxRef;

    p73c50ada$p35f6b268$1(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p13ff1b30 p13ff1b30Var, java.lang.string str) {
        this.$this_waitInProcessTransaction = p13ff1b30Var;
        this.$trxRef = str;
    }

    public static io.reactivex.rxjava3.core.Single OJQuKEVepKzoQkJX(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p13ff1b30 p13ff1b30Var, java.lang.string str) {
        return p13ff1b30Var.getTransaction(str);
    }

    public static void GNMwYRASlcdJfngs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.SingleSource LIFBcTVzsPRcyurk(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.p73c50ada$p35f6b268$1 p73c50ada_p35f6b268_1, java.lang.long l) {
        return p73c50ada_p35f6b268_1.apply(l);
    }

    public readonly io.reactivex.rxjava3.core.SingleSource<? : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.paf0a7887> apply(java.lang.long l) {
        gNMwYRASlcdJfngs(l, "it");
        return OJQuKEVepKzoQkJX(this.$this_waitInProcessTransaction, this.$trxRef);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return lIFBcTVzsPRcyurk(this, (java.lang.long) obj);
    }
}

