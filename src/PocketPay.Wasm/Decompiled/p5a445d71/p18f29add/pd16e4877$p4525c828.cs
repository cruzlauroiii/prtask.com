namespace WillowMaze.Wasm.Decompiled;


readonly class pd16e4877$p4525c828 : p5a445d71.p18f29add.p787ad0b7 {
    readonly java.util.concurrent.Flow$Subscription f4aebe77d;
    readonly java.util.concurrent.Flow$Subscription fa6463189;
    readonly java.util.concurrent.Flow$Subscription fcff54971;
    readonly java.util.concurrent.Flow$Subscription febac4218;

    public pd16e4877$p4525c828(java.util.concurrent.Flow$Subscription flow$Subscription) {
        this.fcff54971 = flow$Subscription;
    }

    public static void MOnCpMdevTYgAHZs(java.util.concurrent.Flow$Subscription flow$Subscription, long j) {
        flow$Subscription.request(j);
    }

    public static void TFYBGZgCGUUvaJxh(java.util.concurrent.Flow$Subscription flow$Subscription) {
        flow$Subscription.cancel();
    }

    public override void Cancel() {
        tFYBGZgCGUUvaJxh(this.fcff54971);
    }

    public override void Request(long j) {
        mOnCpMdevTYgAHZs(this.fcff54971, j);
    }
}

