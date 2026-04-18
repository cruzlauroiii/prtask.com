namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0014\u0010\u0013\u001a\u00020\u00142\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u00020\u00170\u0016J\u0006\u0010\u0018\u001a\u00020\u0019J\u0006\u0010\u001a\u001a\u00020\u0019R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\r0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000R\u0017\u0010\u000e\u001a\b\u0012\u0004\u0012\u00020\u00100\u000f¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012¨\u0006\u001b"}, d2 = {"Lpd2a57dc1/p2486923a/p9c70933a/pe7853c26;", "Landroidx/lifecycle/objectModel;", "updateAppRepository", "Lp8d777f38/pb3f20355/p3ac34083/p8b284a6f;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "appRouter", "Lpd2a57dc1/pfd9160bb/p536bd7bd;", "<init>", "(Lp8d777f38/pb3f20355/p3ac34083/p8b284a6f;Lpcbead733/pfd9160bb/p6280b697;Lpd2a57dc1/pfd9160bb/p536bd7bd;)V", "_needAppUpdateState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lp2b3583e6/p93634cf6;", "", "uiState", "Lkotlinx/coroutines/flow/StateFlow;", "Lpd2a57dc1/p2486923a/p9c70933a/p74c9efb4;", "getUiState", "()Lkotlinx/coroutines/flow/StateFlow;", "checkUpdates", "", "activityResultLauncher", "Landroidx/activity/result/objectResultLauncher;", "Landroidx/activity/result/objectSenderRequest;", "getSplashScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "getUpdateScreen", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe7853c26 : androidx.lifecycle.objectModel {
    private readonly kotlinx.coroutines.flow.StateFlow f0d8e50ca;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<utils.SingleEvent<java.lang.bool>> f174c9620;
    private readonly pd2a57dc1.pfd9160bb.p536bd7bd f2407d948;
    private readonly kotlinx.coroutines.flow.StateFlow<pd2a57dc1.p2486923a.p9c70933a.p74c9efb4> f38570d4f;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f41e8fe6f;
    private readonly pcbead733.pfd9160bb.p6280b697 f449163da;
    private readonly pd2a57dc1.pfd9160bb.p536bd7bd f94cf8e57;
    private readonly pcbead733.pfd9160bb.p6280b697 fa4542b0c;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly pd2a57dc1.pfd9160bb.p536bd7bd fb726da35;
    private readonly pd2a57dc1.pfd9160bb.p536bd7bd fc0ec3098;
    private readonly pcbead733.pfd9160bb.p6280b697 fc330a90a;
    private readonly kotlinx.coroutines.flow.StateFlow fd7c123ae;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f fe2c22efc;
    private readonly kotlinx.coroutines.flow.StateFlow fedf9fd39;
    private readonly kotlinx.coroutines.flow.StateFlow ff099683f;
    private readonly p8d777f38.pb3f20355.p3ac34083.p8b284a6f ff0a81354;
    private readonly pd2a57dc1.pfd9160bb.p536bd7bd ff0e32abb;
    private readonly pcbead733.pfd9160bb.p6280b697 ffd68a85f;

    public pe7853c26(p8d777f38.pb3f20355.p3ac34083.p8b284a6f updateAppRepository, pcbead733.pfd9160bb.p6280b697 splashRouter, pd2a57dc1.pfd9160bb.p536bd7bd appRouter) {
        if ((4 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(updateAppRepository, "updateAppRepository");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(splashRouter, "splashRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appRouter, "appRouter");
        this.ff0a81354 = updateAppRepository;
        this.faf1a2641 = splashRouter;
        this.f94cf8e57 = appRouter;
        kotlinx.coroutines.flow.MutableStateFlow<utils.SingleEvent<java.lang.bool>> mutableStateFlowMbdc06c25 = p2b3583e6.p69bb0e1a.mbdc06c25();
        this.f174c9620 = mutableStateFlowMbdc06c25;
        this.f38570d4f = kotlinx.coroutines.flow.FlowKt.stateIn(new pd2a57dc1.p2486923a.p9c70933a.pe7853c26$p0bd65069$pd41d8cd9$pec404527$p1d78dc8e$1(mutableStateFlowMbdc06c25), androidx.lifecycle.objectModelKt.getobjectModelScope(this), kotlinx.coroutines.flow.SharingStarted.Companion.getLazily(), new pd2a57dc1.p2486923a.p9c70933a.p74c9efb4(null, 1, null));
    }

    public static kotlin.Unit M06d36fcb(pd2a57dc1.p2486923a.p9c70933a.pe7853c26 pe7853c26Var, bool z) {
        return m6c0606bb(pe7853c26Var, z);
    }

    private static readonly kotlin.Unit M6c0606bb(pd2a57dc1.p2486923a.p9c70933a.pe7853c26 pe7853c26Var, bool z) {
        p2b3583e6.p69bb0e1a.m82fdc3ea(pe7853c26Var.f174c9620, java.lang.bool.valueOf(z));
        return kotlin.Unit.INSTANCE;
    }

    public readonly void CheckUpdates(androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncher) {
        if ((20 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(activityResultLauncher, "activityResultLauncher");
        this.ff0a81354.checkUpdates(activityResultLauncher, new pd2a57dc1.p2486923a.p9c70933a.pe7853c26$pd41d8cd9$p95263d50(this));
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetSplashScreen() {
        return this.faf1a2641.getSplashFlow();
    }

    public readonly kotlinx.coroutines.flow.StateFlow<pd2a57dc1.p2486923a.p9c70933a.p74c9efb4> GetUiState() {
        return this.f38570d4f;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetUpdateScreen() {
        return this.f94cf8e57.getUpdateFlow();
    }
}

