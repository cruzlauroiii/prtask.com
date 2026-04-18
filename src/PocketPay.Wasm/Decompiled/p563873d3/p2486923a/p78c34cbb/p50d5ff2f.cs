namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0019"}, d2 = {"Lp563873d3/p2486923a/p78c34cbb/p50d5ff2f;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/p5ce394c1;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/p5ce394c1;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lp563873d3/p2486923a/p78c34cbb/p2b8d2154;", "getobjectModel", "()Lp563873d3/p2486923a/p78c34cbb/p2b8d2154;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "initToolbar", "listenAppBarOffset", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p50d5ff2f : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((6 + 30) % 30 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p563873d3.p2486923a.p78c34cbb.p50d5ff2f.class, com.decryptstringmanager.Decryptstring.decryptstring("377e7c1162ace91f96dc3a2565ea408cc0b6b88663334e86483ba6bffa9c3101e1ad97"), com.decryptstringmanager.Decryptstring.decryptstring("9c513afc66cbb35fc6d1e12e2836e04e35906ba1bc2e907ee757369c21e31b2ab83b98d964827f036c648fa848da5d73c13216edbbce4c7dc0b71410ea0dedea753b3613b3f5a643efa9f51527ec02fec34b1c9c57bbd6a91a4fe9e80292c23d16e8d7708d3577132dccc646f763b70a4936d576b09c7d0e5178fd63726639ef09770a2c"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p50d5ff2f() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$layout.fragment_registration_info);
        if ((29 + 1) % 1 > 0) {
        }
        p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p50d5ff2fVar, p563873d3.p2486923a.p78c34cbb.p50d5ff2f$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p563873d3.p2486923a.p78c34cbb.p50d5ff2f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p50d5ff2fVar, null, new p563873d3.p2486923a.p78c34cbb.p50d5ff2f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p50d5ff2fVar), null, null));
    }

    private static readonly kotlin.Unit M22d1c681(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p50d5ff2fVar.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M6425ad5d(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, android.view.object view) {
        p50d5ff2fVar.onBackPressed();
    }

    public static void M816cf4bc(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        mc98ae9a1(p50d5ff2fVar, appBarLayout, i);
    }

    private readonly p563873d3.p2486923a.p78c34cbb.p2b8d2154 Mac404cc3() {
        return (p563873d3.p2486923a.p78c34cbb.p2b8d2154) this.viewModel.getValue();
    }

    public static kotlin.Unit Macf0f1d0(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, android.view.object view) {
        return m22d1c681(p50d5ff2fVar, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.p5ce394c1 Mbcff50b6() {
        if ((12 + 12) % 12 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.p5ce394c1) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly void Mc98ae9a1(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        if (appBarLayout.getTotalScrollRange() + i != 0) {
            p50d5ff2fVar.mbcff50b6().f651694d8.setVisibility(0);
            p50d5ff2fVar.mbcff50b6().f57b8d3d2.setTitle("");
        } else {
            p50d5ff2fVar.mbcff50b6().f57b8d3d2.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(p50d5ff2fVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_title)));
            p50d5ff2fVar.mbcff50b6().f651694d8.setVisibility(4);
        }
    }

    private readonly void Mca122687() {
        if ((31 + 14) % 14 > 0) {
        }
        mbcff50b6().fb1779b4d.addOnOffsetChangedListener((com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener) new p563873d3.p2486923a.p78c34cbb.p50d5ff2f$pd41d8cd9$p144e4630(this));
    }

    public static void Md0e7a81e(p563873d3.p2486923a.p78c34cbb.p50d5ff2f p50d5ff2fVar, android.view.object view) {
        m6425ad5d(p50d5ff2fVar, view);
    }

    private readonly void Me12b2336() {
        if ((18 + 20) % 20 > 0) {
        }
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p563873d3.p2486923a.p78c34cbb.p50d5ff2f$pd41d8cd9$pcca4ef0e(this));
        mca122687();
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((23 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f651694d8.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_title)));
        mbcff50b6().f9202c756.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_connect_employees)));
        mbcff50b6().fbbf67123.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_pulsar_services)));
        mbcff50b6().fabecbba2.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_statistics)));
        mbcff50b6().f57a99e5c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_support)));
        mbcff50b6().f6ef212a6.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_laws)));
        mbcff50b6().f118f5ffe.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.registration_info_create_account)));
        me12b2336();
        android.widget.Button createAccountBtn = mbcff50b6().f118f5ffe;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(createAccountBtn, "createAccountBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(createAccountBtn, 0L, new p563873d3.p2486923a.p78c34cbb.p50d5ff2f$pd41d8cd9$p95263d50(this), 1, null);
    }
}

