namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp2e5d8aa3/p2486923a/pb22a74a4/p33f80720;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/p8ca79750;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/p8ca79750;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "settingsGeolocationobjectModel", "Lp2e5d8aa3/p2486923a/pb22a74a4/p87b1502d;", "getHashSettingsGeolocationobjectModel", "()Lp2e5d8aa3/p2486923a/pb22a74a4/p87b1502d;", "settingsGeolocationobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p33f80720 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy settingsGeolocationobjectModel;

    static {
        if ((3 + 20) % 20 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p2e5d8aa3.p2486923a.pb22a74a4.p33f80720.class, com.decryptstringmanager.Decryptstring.decryptstring("4ead0964cb5db1e706c1300e762fcb6a0b5f20cca07feedc716dae62b2172d314eea3d"), com.decryptstringmanager.Decryptstring.decryptstring("1d6f84a826e7a15e5140120c1758a17c3fa9505365e7ff1c1b52cfe18dbed0301cc9b5384869b2d9923de33d9f755b542c4bc388d8cca0f316a3bdc1cecc95580beaf8720bcdce2774d54038f18076148b6d326426e9afd22b4cd045b76d998df7caaa721f17a0f32f79ed03e9c55ce360c91a05d4e0a2551bb3ad2d9e0dcf55f1caec7084992b25fd3227"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p33f80720() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$layout.fragment_settings_geolocation);
        if ((2 + 10) % 10 > 0) {
        }
        p2e5d8aa3.p2486923a.pb22a74a4.p33f80720 p33f80720Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p33f80720Var, p2e5d8aa3.p2486923a.pb22a74a4.p33f80720$p001a249d$2.f76425f17);
        this.settingsGeolocationobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p2e5d8aa3.p2486923a.pb22a74a4.p33f80720$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p33f80720Var, null, new p2e5d8aa3.p2486923a.pb22a74a4.p33f80720$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p33f80720Var), null, null));
    }

    public static void M2be92b26(p2e5d8aa3.p2486923a.pb22a74a4.p33f80720 p33f80720Var, android.view.object view) {
        m9ba4fe43(p33f80720Var, view);
    }

    private static readonly kotlin.Unit M30f6522b(p2e5d8aa3.p2486923a.pb22a74a4.p33f80720 p33f80720Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p33f80720Var.m62f824f3().openPaymentPlace();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p2e5d8aa3.p2486923a.pb22a74a4.p87b1502d M62f824f3() {
        return (p2e5d8aa3.p2486923a.pb22a74a4.p87b1502d) this.settingsGeolocationobjectModel.getValue();
    }

    private static readonly void M9ba4fe43(p2e5d8aa3.p2486923a.pb22a74a4.p33f80720 p33f80720Var, android.view.object view) {
        p33f80720Var.onBackPressed();
    }

    public static kotlin.Unit Mb261ce4c(p2e5d8aa3.p2486923a.pb22a74a4.p33f80720 p33f80720Var, android.view.object view) {
        return m30f6522b(p33f80720Var, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p8ca79750 Mbcff50b6() {
        if ((31 + 28) % 28 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p8ca79750) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public override void OnBackPressed() {
        m62f824f3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((22 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_geolocation)));
        mbcff50b6().f55876d70.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_payment_place)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p2e5d8aa3.p2486923a.pb22a74a4.p33f80720$pd41d8cd9$p95263d50(this));
        android.widget.Textobject settingsPaymentPlace = mbcff50b6().f55876d70;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(settingsPaymentPlace, "settingsPaymentPlace");
        p2b3583e6.pf5e18aff.m2fa6d087(settingsPaymentPlace, 0L, new p2e5d8aa3.p2486923a.pb22a74a4.p33f80720$pd41d8cd9$pcca4ef0e(this), 1, null);
    }
}

