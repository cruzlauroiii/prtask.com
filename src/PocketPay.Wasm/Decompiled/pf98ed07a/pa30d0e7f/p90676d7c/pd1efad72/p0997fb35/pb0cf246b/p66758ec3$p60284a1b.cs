namespace WillowMaze.Wasm.Decompiled;


readonly class p66758ec3$p60284a1b<T, B> : io.reactivex.rxjava3.subscribers.DisposableSubscriber<B> {
    bool f04c85834;
    bool f3e24ce39;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 fa2eb52d6;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundary$WindowBoundaryMainSubscriber<T, B> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 fe618abc7;

    p66758ec3$p60284a1b(io.reactivex.rxjava3.internal.operators.flowable.FlowableWindowBoundary$WindowBoundaryMainSubscriber<T, B> flowableWindowBoundary$WindowBoundaryMainSubscriber) {
        this.fd0e45878 = flowableWindowBoundary$WindowBoundaryMainSubscriber;
    }

    public static void KTUHFAawiHNXnJDb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.innerNext();
    }

    public static void OPipTgwffUCjFCcY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6) {
        p66758ec3_pcbd5c6a6.innerComplete();
    }

    public static void RTeXwMGWNymfsElp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void TVHXSigdFvPCbZlt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p66758ec3$pcbd5c6a6 p66758ec3_pcbd5c6a6, java.lang.Exception th) {
        p66758ec3_pcbd5c6a6.innerError(th);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        oPipTgwffUCjFCcY(this.fd0e45878);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            rTeXwMGWNymfsElp(th);
        } else {
            this.f6b2ded51 = true;
            tVHXSigdFvPCbZlt(this.fd0e45878, th);
        }
    }

    public void OnNext(B b) {
        if (this.f6b2ded51) {
            return;
        }
        KTUHFAawiHNXnJDb(this.fd0e45878);
    }
}

