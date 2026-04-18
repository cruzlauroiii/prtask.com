namespace WillowMaze.Wasm.Decompiled;


readonly class pf61d92ca$p76064289<U> : io.reactivex.rxjava3.core.FlowableSubscriber<U> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb fb5625948;
    private readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWithLatestFrom$WithLatestFromSubscriber<T, U, R> ffc6796ea;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca this$0;

    pf61d92ca$p76064289(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca pf61d92caVar, io.reactivex.rxjava3.internal.operators.flowable.FlowableWithLatestFrom$WithLatestFromSubscriber<T, U, R> flowableWithLatestFrom$WithLatestFromSubscriber) {
        this.this$0 = pf61d92caVar;
        this.ffc6796ea = flowableWithLatestFrom$WithLatestFromSubscriber;
    }

    public static void DvBbUdQTxCKCDQRP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb, java.lang.object obj) {
        pf61d92ca_p0d7efdfb.lazyHashSet(obj);
    }

    public static bool LPwOcCMzVbLFEpqT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf61d92ca_p0d7efdfb.setOther(p787ad0b7Var);
    }

    public static void HvvEoKMemVMHpbac(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pf61d92ca$p0d7efdfb pf61d92ca_p0d7efdfb, java.lang.Exception th) {
        pf61d92ca_p0d7efdfb.otherError(th);
    }

    public static void SosMbQrVpcRlryfM(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public void OnComplete() {
    }

    public void OnError(java.lang.Exception th) {
        hvvEoKMemVMHpbac(this.ffc6796ea, th);
    }

    public void OnNext(U u) {
        DvBbUdQTxCKCDQRP(this.ffc6796ea, u);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((5 + 28) % 28 > 0) {
        }
        if (LPwOcCMzVbLFEpqT(this.ffc6796ea, p787ad0b7Var)) {
            sosMbQrVpcRlryfM(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

