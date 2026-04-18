namespace WillowMaze.Wasm.Decompiled;


readonly class p37bdd9f6$pb4430254<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    p5a445d71.p18f29add.p992c4a5b f384bcd72;
    p5a445d71.p18f29add.p992c4a5b f50c6ae61;
    p5a445d71.p18f29add.p992c4a5b f70417aae;
    p5a445d71.p18f29add.p787ad0b7 fa2bd26c9;
    p5a445d71.p18f29add.p787ad0b7 fb1c37b67;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p992c4a5b fbd7e66a4;
    org.reactivestreams.Subscriber<T> fd22a0a80;
    p5a445d71.p18f29add.p787ad0b7 fdedad5c7;
    p5a445d71.p18f29add.p787ad0b7 ff8c1df51;

    p37bdd9f6$pb4430254(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static bool FOpwzXoYQNDJztxZ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void FhHIqLzeQdfWLsJO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void IQoHjPTDOOKIFmSH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static p5a445d71.p18f29add.p992c4a5b QqVOQpiIggdmkpZF() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asSubscriber();
    }

    public static void WCtqiiPRcAFboEMk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static p5a445d71.p18f29add.p992c4a5b BucQCkwHxEfEzmFQ() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asSubscriber();
    }

    public static void FnuUBYQNYSMPcXgi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void HiHdDFtoOnSWqdxG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LFrISCvarquwrgsR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static p5a445d71.p18f29add.p992c4a5b QvyfrMPwuxoqAoKZ() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.asSubscriber();
    }

    public override void Cancel() {
        if ((31 + 7) % 7 > 0) {
        }
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = bucQCkwHxEfEzmFQ();
        hiHdDFtoOnSWqdxG(p787ad0b7Var);
    }

    public void OnComplete() {
        if ((14 + 16) % 16 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = QqVOQpiIggdmkpZF();
        IQoHjPTDOOKIFmSH(subscriber);
    }

    public void OnError(java.lang.Exception th) {
        if ((5 + 22) % 22 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17;
        this.fd22a0a80 = qvyfrMPwuxoqAoKZ();
        WCtqiiPRcAFboEMk(subscriber, th);
    }

    public void OnNext(T t) {
        FhHIqLzeQdfWLsJO(this.fd22a0a80, t);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (FOpwzXoYQNDJztxZ(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            fnuUBYQNYSMPcXgi(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        lFrISCvarquwrgsR(this.fbc3b0556, j);
    }
}

