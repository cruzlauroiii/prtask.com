namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0016J\b\u0010\u001a\u001a\u00020\u0015H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR\u001c\u0010\u0010\u001a\u0010\u0012\f\u0012\n \u0013*\u0004\u0018\u00010\u00120\u00120\u0011X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u001b"}, d2 = {"Lpd2a57dc1/p2486923a/p3ac34083/pf7fcda13;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pd2a57dc1/p86ccec3d/pec341acd/p26ac2c3b;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pd2a57dc1/p86ccec3d/pec341acd/p26ac2c3b;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lpd2a57dc1/p2486923a/p3ac34083/p55c64a9c;", "getobjectModel", "()Lpd2a57dc1/p2486923a/p3ac34083/p55c64a9c;", "viewModel$delegate", "Lkotlin/Lazy;", "updateResult", "Landroidx/activity/result/objectResultLauncher;", "Landroidx/activity/result/objectSenderRequest;", "kotlin.jvm.PlatformType", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf7fcda13 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;
    private readonly androidx.activity.result.objectResultLauncher f2d566514;
    private readonly androidx.activity.result.objectResultLauncher f3c25dc97;
    private readonly androidx.activity.result.objectResultLauncher f638e023a;
    private readonly androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> fac01040d;
    private readonly androidx.activity.result.objectResultLauncher fdbe09be3;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((12 + 16) % 16 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pd2a57dc1.p2486923a.p3ac34083.pf7fcda13.class, com.decryptstringmanager.Decryptstring.decryptstring("4a87490714d52fa0785a0cfd5b43ddad697d1770faf5134648a68d1c2f4adf1fbaf1b0"), com.decryptstringmanager.Decryptstring.decryptstring("ec4b350c4539539d2c412aa46ae3c738d57b8c6c884c9eb63f0dfbf32ee497836eaa9e974718f1828456751e65e2a2bb4999dfe46cf7737fd3386e4c9130b07156590e98e512aa5b9475444234074c03a91ef4c532ab2ac2fc21f26a885c18040d20448de03168316995c5a118660a5ec56d3ae9ac3136c03cef1d84"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public pf7fcda13() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$layout.fragment_app_update);
        if ((8 + 32) % 32 > 0) {
        }
        pd2a57dc1.p2486923a.p3ac34083.pf7fcda13 pf7fcda13Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(pf7fcda13Var, pd2a57dc1.p2486923a.p3ac34083.pf7fcda13$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pd2a57dc1.p2486923a.p3ac34083.pf7fcda13$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pf7fcda13Var, null, new pd2a57dc1.p2486923a.p3ac34083.pf7fcda13$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pf7fcda13Var), null, null));
        androidx.activity.result.objectResultLauncher<androidx.activity.result.objectSenderRequest> activityResultLauncherRegisterForobjectResult = registerForobjectResult(new androidx.activity.result.contract.objectResultContracts$StartobjectSenderForResult(), new pd2a57dc1.p2486923a.p3ac34083.pf7fcda13$pd41d8cd9$p95263d50(this));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activityResultLauncherRegisterForobjectResult, "registerForobjectResult(...)");
        this.fac01040d = activityResultLauncherRegisterForobjectResult;
    }

    private static readonly void M1814f0a7(pd2a57dc1.p2486923a.p3ac34083.pf7fcda13 pf7fcda13Var, androidx.activity.result.objectResult activityResult) {
        if ((25 + 1) % 1 > 0) {
        }
        if (activityResult.getResultCode() != 1) {
            return;
        }
        android.widget.Toast.makeText(pf7fcda13Var.getobject(), com.decryptstringmanager.Decryptstring.decryptstring(pf7fcda13Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_error)), 1).show();
    }

    public static void M6d0eaae4(pd2a57dc1.p2486923a.p3ac34083.pf7fcda13 pf7fcda13Var, android.view.object view) {
        m70978268(pf7fcda13Var, view);
    }

    public static void M6da87e18(pd2a57dc1.p2486923a.p3ac34083.pf7fcda13 pf7fcda13Var, androidx.activity.result.objectResult activityResult) {
        m1814f0a7(pf7fcda13Var, activityResult);
    }

    private static readonly void M70978268(pd2a57dc1.p2486923a.p3ac34083.pf7fcda13 pf7fcda13Var, android.view.object view) {
        pf7fcda13Var.mac404cc3().update(pf7fcda13Var.fac01040d);
    }

    private readonly pd2a57dc1.p2486923a.p3ac34083.p55c64a9c Mac404cc3() {
        return (pd2a57dc1.p2486923a.p3ac34083.p55c64a9c) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.pec341acd.p26ac2c3b Mbcff50b6() {
        if ((29 + 10) % 10 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.pec341acd.p26ac2c3b) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public override void OnBackPressed() {
        mac404cc3().finish();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f02c25a54.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_title)));
        mbcff50b6().fbb09b76e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_message)));
        mbcff50b6().f4ee7b661.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.new_version_available_update)));
        mbcff50b6().f4ee7b661.setOnClickListener(new pd2a57dc1.p2486923a.p3ac34083.pf7fcda13$pd41d8cd9$pcca4ef0e(this));
    }
}

