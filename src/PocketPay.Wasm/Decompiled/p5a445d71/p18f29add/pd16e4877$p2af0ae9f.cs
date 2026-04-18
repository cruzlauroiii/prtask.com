namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p2af0ae9f<T> : org.reactivestreams.Publisher<T> {
    readonly java.util.concurrent.Flow$Publisher f791102b9;
    readonly java.util.concurrent.Flow$Publisher f7c6562a5;
    readonly java.util.concurrent.Flow$Publisher fc6598d3b;
    readonly java.util.concurrent.Flow$Publisher<? : T> fcff54971;

    public pd16e4877$p2af0ae9f(java.util.concurrent.Flow$Publisher<? : T> flow$Publisher) {
        this.fcff54971 = flow$Publisher;
    }

    public static void LiNaulnAQRbwfVqb(java.util.concurrent.Flow$Publisher flow$Publisher, java.util.concurrent.Flow$Subscriber flow$Subscriber) {
        flow$Publisher.subscribe(flow$Subscriber);
    }

    public void Subscribe(org.reactivestreams.Subscriber<T> subscriber) {
        LiNaulnAQRbwfVqb(this.fcff54971, subscriber is not null ? new p5a445d71.p18f29add.pd16e4877$p8988a65d(subscriber) : null);
    }
}

