namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p3c9c4135<T, U> : java.util.concurrent.Flow$Processor<T, U> {
    readonly org.reactivestreams.Processor<? super T, ? : U> f07490603;
    readonly p5a445d71.p18f29add.pe22b6495 f0928251a;
    readonly p5a445d71.p18f29add.pe22b6495 f8445e6fd;
    readonly p5a445d71.p18f29add.pe22b6495 fbc5acb1b;

    public pd16e4877$p3c9c4135(org.reactivestreams.Processor<? super T, ? : U> processor) {
        this.f07490603 = processor;
    }

    public static void LxKnnIryPyOmsqTL(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pe22b6495Var.subscribe(p992c4a5bVar);
    }

    public static void MnyhNgbSzNyxkKMT(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, java.lang.Exception th) {
        pe22b6495Var.onError(th);
    }

    public static void KypZwbuEfvHehoAy(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, java.lang.object obj) {
        pe22b6495Var.onNext(obj);
    }

    public static void WqGMtLmWlbfjUkcj(p5a445d71.p18f29add.pe22b6495 pe22b6495Var) {
        pe22b6495Var.onComplete();
    }

    public static void ZZPHzLYHZuMRwJEr(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        pe22b6495Var.onSubscribe(p787ad0b7Var);
    }

    public override void OnComplete() {
        wqGMtLmWlbfjUkcj(this.f07490603);
    }

    public override void OnError(java.lang.Exception th) {
        MnyhNgbSzNyxkKMT(this.f07490603, th);
    }

    public override void OnNext(T t) {
        kypZwbuEfvHehoAy(this.f07490603, t);
    }

    public override void OnSubscribe(java.util.concurrent.Flow$Subscription flow$Subscription) {
        zZPHzLYHZuMRwJEr(this.f07490603, flow$Subscription is not null ? new p5a445d71.p18f29add.pd16e4877$p4525c828(flow$Subscription) : null);
    }

    public override void Subscribe(java.util.concurrent.Flow$Subscriber<U> flow$Subscriber) {
        LxKnnIryPyOmsqTL(this.f07490603, flow$Subscriber is not null ? new p5a445d71.p18f29add.pd16e4877$pe01ee695(flow$Subscriber) : null);
    }
}

