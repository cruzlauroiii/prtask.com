namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p73c50ada$p35f6b268$2<T> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p5070f570 $transactionState;

    p73c50ada$p35f6b268$2(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p5070f570 p5070f570Var) {
        this.$transactionState = p5070f570Var;
    }

    public static bool GqfHqSfKFctPCVOr(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p2ac737d2.p73c50ada$p35f6b268$2 p73c50ada_p35f6b268_2, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.paf0a7887 paf0a7887Var) {
        return p73c50ada_p35f6b268_2.test(paf0a7887Var);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.p5070f570 JIdkWzDWTBjNfkmA(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.paf0a7887 paf0a7887Var) {
        return paf0a7887Var.getState();
    }

    public static void UdEtlqphAxueJIVH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override bool Test(java.lang.object obj) {
        return gqfHqSfKFctPCVOr(this, (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.paf0a7887) obj);
    }

    public readonly bool Test(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p07214c67.paf0a7887 paf0a7887Var) {
        udEtlqphAxueJIVH(paf0a7887Var, "transaction");
        return jIdkWzDWTBjNfkmA(paf0a7887Var) != this.$transactionState;
    }
}

