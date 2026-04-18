namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0006\u0010\n\u001a\u00020\u000bJ\b\u0010\f\u001a\u00020\u000bH\u0002J\u0006\u0010\r\u001a\u00020\u000bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lpd2a57dc1/p2486923a/p57cb773a/pae8d1f35;", "Landroidx/lifecycle/objectModel;", "maintenanceModeUseCase", "Lpad5f82e8/pac143fb7/p57cb773a/p701d673c;", "flowRouter", "Lpd2a57dc1/pfd9160bb/p11c216e8;", "splashRouter", "Lpcbead733/pfd9160bb/p6280b697;", "<init>", "(Lpad5f82e8/pac143fb7/p57cb773a/p701d673c;Lpd2a57dc1/pfd9160bb/p11c216e8;Lpcbead733/pfd9160bb/p6280b697;)V", "checkMaintenanceMode", "", "startRootFlowSplashScreen", "finish", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pae8d1f35 : androidx.lifecycle.objectModel {
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f10da9134;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f3a1d4379;
    private readonly pcbead733.pfd9160bb.p6280b697 f41dfc938;
    private readonly pad5f82e8.pac143fb7.p57cb773a.p701d673c f51cef364;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f8eebdfbc;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 f99e344a9;
    private readonly pad5f82e8.pac143fb7.p57cb773a.p701d673c fa9d7fc99;
    private readonly pcbead733.pfd9160bb.p6280b697 faf1a2641;
    private readonly pad5f82e8.pac143fb7.p57cb773a.p701d673c fb20b3cf5;
    private readonly pcbead733.pfd9160bb.p6280b697 fc5623f00;
    private readonly pcbead733.pfd9160bb.p6280b697 fcc99789b;
    private readonly pd2a57dc1.pfd9160bb.p11c216e8 feefeb260;

    public pae8d1f35(pad5f82e8.pac143fb7.p57cb773a.p701d673c maintenanceModeUseCase, pd2a57dc1.pfd9160bb.p11c216e8 flowRouter, pcbead733.pfd9160bb.p6280b697 splashRouter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(maintenanceModeUseCase, "maintenanceModeUseCase");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(flowRouter, "flowRouter");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(splashRouter, "splashRouter");
        this.fa9d7fc99 = maintenanceModeUseCase;
        this.feefeb260 = flowRouter;
        this.faf1a2641 = splashRouter;
    }

    private readonly void M54db11dc() {
        this.feefeb260.startRootFlow(this.faf1a2641.getSplashFlow());
    }

    public static readonly void M6f1040a9(pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 pae8d1f35Var) {
        pae8d1f35Var.m54db11dc();
    }

    public static readonly pad5f82e8.pac143fb7.p57cb773a.p701d673c Mb1d064ef(pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 pae8d1f35Var) {
        return pae8d1f35Var.fa9d7fc99;
    }

    public readonly void CheckMaintenanceMode() {
        if ((8 + 1) % 1 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.objectModelKt.getobjectModelScope(this), null, null, new pd2a57dc1.p2486923a.p57cb773a.pae8d1f35$p944469a1$1(this, null), 3, null);
    }

    public readonly void Finish() {
        this.feefeb260.finishAllFlows();
    }
}

