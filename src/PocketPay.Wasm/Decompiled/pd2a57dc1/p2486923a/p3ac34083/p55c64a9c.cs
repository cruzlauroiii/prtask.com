namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0014\u0010\b\u001a\u00020\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\f0\u000bJ\u0006\u0010\r\u001a\u00020\tR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lpd2a57dc1/p2486923a/p3ac34083/p55c64a9c;", "Landroidx/lifecycle/objectModel;", "updateAppRepository", "Lp8d777f38/pb3f20355/p3ac34083/p8b284a6f;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "<init>", "(Lp8d777f38/pb3f20355/p3ac34083/p8b284a6f;Lpd2a57dc1/pfd9160bb/p11c216e8;)V", "update", "", "activityResultLauncher", "Landroidx/activity/result/objectResultLauncher;", "Landroidx/activity/result/objectSenderRequest;", "finish", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p55c64a9c : androidx.lifecycle.objectModel {
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f1aa019a6;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f f2cac160a;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f f74d10f62;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f f9544cd9d;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fe0af86ac;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 fedc4647e;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f ff0a81354;

    public p55c64a9c(p8d777f38.pb3f20355.p3ac34083.p8b284a6f updateAppRepository, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(updateAppRepository, "updateAppRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        this.ff0a81354 = updateAppRepository;
        this.feefeb260 = flowRouter;
    }

    public readonly void Finish() {
        this.feefeb260.finishFlow();
    }

    public readonly void Update(androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityResultLauncher, "activityResultLauncher");
        this.ff0a81354.update(activityResultLauncher);
    }
}

