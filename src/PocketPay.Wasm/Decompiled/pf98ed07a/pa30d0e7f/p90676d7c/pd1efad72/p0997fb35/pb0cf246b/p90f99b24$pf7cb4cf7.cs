namespace WillowMaze.Wasm.Decompiled;


readonly class p90f99b24$pf7cb4cf7<T> : io.reactivex.rxjava3.core.Observer<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f15113d41;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f37c3d090;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdf8ccc16;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ff0f3a754;

    p90f99b24$pf7cb4cf7(org.reactivestreams.Subscriber<T> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void MooQKXMaPKOYhyjQ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void VLPJyGVbZUiXwnMU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void BagWPBcMCOaAGAdi(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void KSKaWrNxUxfAbXrp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ZHMnqSCBPmZDGCEw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public override void Cancel() {
        MooQKXMaPKOYhyjQ(this.fbc3b0556);
    }

    public override void OnComplete() {
        VLPJyGVbZUiXwnMU(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        kSKaWrNxUxfAbXrp(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        zHMnqSCBPmZDGCEw(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fbc3b0556 = p7beea252Var;
        bagWPBcMCOaAGAdi(this.fd22a0a80, this);
    }

    public override void Request(long j) {
    }
}

