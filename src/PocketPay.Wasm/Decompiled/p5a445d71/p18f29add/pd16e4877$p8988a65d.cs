namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p8988a65d<T> : java.util.concurrent.Flow$Subscriber<T> {
    readonly org.reactivestreams.Subscriber<T> f07490603;
    readonly p5a445d71.p18f29add.p992c4a5b f0b6aecc9;
    readonly p5a445d71.p18f29add.p992c4a5b f2960ec33;
    readonly p5a445d71.p18f29add.p992c4a5b f523b9112;

    public pd16e4877$p8988a65d(org.reactivestreams.Subscriber<T> subscriber) {
        this.f07490603 = subscriber;
    }

    public static void UdLTZhXbysWdDobe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void XhixloZDWlJENwiO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void FHJLufYHAgEMuGUF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void UrThKlfqRyYzJTQd(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public override void OnComplete() {
        fHJLufYHAgEMuGUF(this.f07490603);
    }

    public override void OnError(java.lang.Exception th) {
        urThKlfqRyYzJTQd(this.f07490603, th);
    }

    public override void OnNext(T t) {
        XhixloZDWlJENwiO(this.f07490603, t);
    }

    public override void OnSubscribe(java.util.concurrent.Flow$Subscription flow$Subscription) {
        UdLTZhXbysWdDobe(this.f07490603, flow$Subscription is not null ? new p5a445d71.p18f29add.pd16e4877$p4525c828(flow$Subscription) : null);
    }
}

