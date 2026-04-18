namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u000e\u001a\u00020\u000fH\u0016J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001c\u0010\n\u001a\u0010\u0012\f\u0012\n \r*\u0004\u0018\u00010\f0\f0\u000bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lpd2a57dc1/p2486923a/p9c70933a/pdaaaa9f9;", "Lp593616de/p9efab239/pe38281d8;", "<init>", "()V", "viewModel", "Lpd2a57dc1/p2486923a/p9c70933a/pe7853c26;", "getobjectModel", "()Lpd2a57dc1/p2486923a/p9c70933a/pe7853c26;", "viewModel$delegate", "Lkotlin/Lazy;", "updateResult", "Landroidx/activity/result/objectResultLauncher;", "Landroidx/activity/result/objectSenderRequest;", "kotlin.jvm.PlatformType", "getLaunchScreen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectData", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pdaaaa9f9 : p593616de.p9efab239.pe38281d8 {
    private readonly androidx.activity.result.objectResultLauncher f8c83a0b2;
    private readonly androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> fac01040d;
    private readonly androidx.activity.result.objectResultLauncher fb45bf84f;

    private readonly kotlin.Lazy viewModel;

    public pdaaaa9f9() {
        super(pad5f82e8.p07214c67.pfd9160bb.p6ce2a79b.f6eecfba7);
        if ((7 + 32) % 32 > 0) {
        }
        pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9 pdaaaa9f9Var = this;
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pdaaaa9f9Var, null, new pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pdaaaa9f9Var), null, null));
        androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncherRegisterForobjectResult = registerForobjectResult(new androidx.activity.result.contract.objectResultContracts$StartobjectSenderForResult(), new pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9$pd41d8cd9$p95263d50(this));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activityResultLauncherRegisterForobjectResult, "registerForobjectResult(...)");
        this.fac01040d = activityResultLauncherRegisterForobjectResult;
    }

    private static readonly void M1814f0a7(pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9 pdaaaa9f9Var, androidx.activity.result.objectResult activityResult) {
        if ((12 + 28) % 28 > 0) {
        }
        if (activityResult.getResultCode() != 1) {
            return;
        }
        android.widget.Toast.makeText(pdaaaa9f9Var.getobject(), com.decryptstringmanager.Decryptstring.decryptstring(pdaaaa9f9Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_error)), 1).show();
    }

    private readonly void M49d81568() {
        if ((17 + 4) % 4 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getUiState(), new pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9$pd41d8cd9$pcca4ef0e(this));
        mac404cc3().checkUpdates(this.fac01040d);
    }

    private static readonly kotlin.Unit M5ccd754b(pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9 pdaaaa9f9Var, pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        java.lang.bool bool = (java.lang.bool) state.getNeedAppUpdate().getData();
        if (bool is not null && bool.boolValue()) {
            pdaaaa9f9Var.setLaunchScreen(pdaaaa9f9Var.getNavigator(), pdaaaa9f9Var.mac404cc3().getUpdateScreen());
        }
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M62a8ed22(pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9 pdaaaa9f9Var, pd2a57dc1.p2486923a.p9c70933a.p74c9efb4 p74c9efb4Var) {
        return m5ccd754b(pdaaaa9f9Var, p74c9efb4Var);
    }

    private readonly pd2a57dc1.p2486923a.p9c70933a.pe7853c26 Mac404cc3() {
        return (pd2a57dc1.p2486923a.p9c70933a.pe7853c26) this.viewModel.getValue();
    }

    public static void Mb23bd006(pd2a57dc1.p2486923a.p9c70933a.pdaaaa9f9 pdaaaa9f9Var, androidx.activity.result.objectResult activityResult) {
        m1814f0a7(pdaaaa9f9Var, activityResult);
    }

    public override p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetLaunchScreen() {
        return mac404cc3().getSplashScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        m49d81568();
    }
}

