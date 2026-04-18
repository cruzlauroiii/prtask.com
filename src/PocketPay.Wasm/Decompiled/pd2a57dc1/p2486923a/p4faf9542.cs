namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\u000e\u0010\f\u001a\u00020\u000b2\u0006\u0010\r\u001a\u00020\u000eJ\u0010\u0010\u000f\u001a\u00020\u000b2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lpd2a57dc1/p2486923a/p4faf9542;", "Landroidx/lifecycle/objectModel;", "applicationModeUseCase", "Lpad5f82e8/pac143fb7/pd2a57dc1/p1d4a7bbf;", "deepLinkQrDataUseCase", "Lp582ca3f7/pac143fb7/p063acbd2;", "analytics", "Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/p13d58ddc;", "<init>", "(Lpad5f82e8/pac143fb7/pd2a57dc1/p1d4a7bbf;Lp582ca3f7/pac143fb7/p063acbd2;Lpad5f82e8/pac143fb7/p68c4283d/pbf12e151/p13d58ddc;)V", "setDefaultApplicationMode", "", "sendLifecycleEvent", "lifecycle", "Landroidx/lifecycle/Lifecycle$Event;", "handleDeeplinkData", "data", "Landroid/net/Uri;", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4faf9542 : androidx.lifecycle.objectModel {
    private readonly pad5f82e8.pac143fb7.pd2a57dc1.p1d4a7bbf f0bc585cc;
    private readonly p582ca3f7.pac143fb7.p063acbd2 f428c0391;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.p13d58ddc f68c4283d;
    private readonly p582ca3f7.pac143fb7.p063acbd2 f6aa1d361;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.p13d58ddc f7407e7e9;
    private readonly p582ca3f7.pac143fb7.p063acbd2 f98599e8e;
    private readonly p582ca3f7.pac143fb7.p063acbd2 f9d10bfe0;
    private readonly pad5f82e8.pac143fb7.pd2a57dc1.p1d4a7bbf fdbf5ea21;
    private readonly p582ca3f7.pac143fb7.p063acbd2 ffa6fa8c6;
    private readonly pad5f82e8.pac143fb7.p68c4283d.pbf12e151.p13d58ddc fff9d87ef;

    public p4faf9542(pad5f82e8.pac143fb7.pd2a57dc1.p1d4a7bbf applicationModeUseCase, p582ca3f7.pac143fb7.p063acbd2 deepLinkQrDataUseCase, pad5f82e8.pac143fb7.p68c4283d.pbf12e151.p13d58ddc analytics) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationModeUseCase, "applicationModeUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deepLinkQrDataUseCase, "deepLinkQrDataUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(analytics, "analytics");
        this.fdbf5ea21 = applicationModeUseCase;
        this.ffa6fa8c6 = deepLinkQrDataUseCase;
        this.f68c4283d = analytics;
    }

    public static readonly p582ca3f7.pac143fb7.p063acbd2 M6c23f1be(pd2a57dc1.p2486923a.p4faf9542 p4faf9542Var) {
        return p4faf9542Var.ffa6fa8c6;
    }

    public readonly void HandleDeeplinkData(android.net.Uri data2) {
        if ((29 + 12) % 12 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pd2a57dc1.p2486923a.p4faf9542$p0d29c738$1(this, data2, null), 3, null);
    }

    public readonly void SendLifecycleEvent(androidx.lifecycle.Lifecycle$Event lifecycle) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "lifecycle");
        this.f68c4283d.changeobjectLifecycleState(lifecycle);
    }

    public readonly void SetDefaultApplicationMode() {
        this.fdbf5ea21.setMode(pad5f82e8.p07214c67.pd2a57dc1.p5eb17667.f5b39c8b5);
    }
}

