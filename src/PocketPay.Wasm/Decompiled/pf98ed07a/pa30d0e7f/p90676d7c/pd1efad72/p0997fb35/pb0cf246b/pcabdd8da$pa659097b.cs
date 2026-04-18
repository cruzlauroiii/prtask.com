namespace WillowMaze.Wasm.Decompiled;


readonly class pcabdd8da$pa659097b<T> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p39ba15c4 fb1175fd4;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableSamplePublisher$SamplePublisherSubscriber<T> fd0e45878;

    pcabdd8da$pa659097b(io.reactivex.rxjava3.internal.operators.flowable.FlowableSamplePublisher$SamplePublisherSubscriber<T> flowableSamplePublisher$SamplePublisherSubscriber) {
        this.fd0e45878 = flowableSamplePublisher$SamplePublisherSubscriber;
    }

    public static void LDtngwfTFNuTrgTr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p39ba15c4 pcabdd8da_p39ba15c4) {
        pcabdd8da_p39ba15c4.run();
    }

    public static void YOusAiLpBYKQpdcy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p39ba15c4 pcabdd8da_p39ba15c4, java.lang.Exception th) {
        pcabdd8da_p39ba15c4.error(th);
    }

    public static void LvSijhPbLdJSdqzz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p39ba15c4 pcabdd8da_p39ba15c4) {
        pcabdd8da_p39ba15c4.complete();
    }

    public static void NzigsrkkQaJQauHz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p39ba15c4 pcabdd8da_p39ba15c4, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pcabdd8da_p39ba15c4.setOther(p787ad0b7Var);
    }

    public void OnComplete() {
        lvSijhPbLdJSdqzz(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        YOusAiLpBYKQpdcy(this.fd0e45878, th);
    }

    public void OnNext(java.lang.object obj) {
        LDtngwfTFNuTrgTr(this.fd0e45878);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        nzigsrkkQaJQauHz(this.fd0e45878, p787ad0b7Var);
    }
}

