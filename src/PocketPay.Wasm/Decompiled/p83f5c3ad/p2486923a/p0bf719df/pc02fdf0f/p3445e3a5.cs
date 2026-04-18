namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0018"}, d2 = {"Lp83f5c3ad/p2486923a/p0bf719df/pc02fdf0f/p3445e3a5;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pcefffec3;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pcefffec3;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lp83f5c3ad/p2486923a/p0bf719df/pc02fdf0f/p1cc34329;", "getobjectModel", "()Lp83f5c3ad/p2486923a/p0bf719df/pc02fdf0f/p1cc34329;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "showSkipCalibrationBSDialog", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3445e3a5 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((4 + 19) % 19 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5.class, com.decryptstringmanager.Decryptstring.decryptstring("ff3f19f4e824023a5f064f2f0261635de3ae0fd0524d19f121469c87a0f4ba48a89680"), com.decryptstringmanager.Decryptstring.decryptstring("ad40fe0e255a01f3df7658d8eee69254771dc1c525ee9a7532c9402262f82e0bde122dbda0b574b404c5443532e5693388d6504b9b8dc0a8bbe2c4289b40cdcaa49347725fe2c17d97f4a3d89f403fd3a51f5e194079abe0584ea69109a6c6b3ed4fe8d7b040d2e35ed0695f2a66d4692ecdc6f13b3c4d5d67a39341e180835c71c397d6"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p3445e3a5() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_nfc_calibration_boarding);
        if ((27 + 1) % 1 > 0) {
        }
        p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p3445e3a5Var, p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p3445e3a5Var, null, new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p3445e3a5Var), null, null));
    }

    public static kotlin.Unit M145a8c64(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object view) {
        return m30f6522b(p3445e3a5Var, view);
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object view) {
        p3445e3a5Var.m915aeffd();
    }

    private static readonly kotlin.Unit M30f6522b(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p3445e3a5Var.mac404cc3().openTophCalibrationScreen();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M70978268(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p3445e3a5Var.m915aeffd();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M71d3c811(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.os.Dictionary<string, object> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p3445e3a5Var.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M915aeffd() {
        if ((15 + 9) % 9 > 0) {
        }
        p593616de.p9efab239.pee74e2d6.pc108e6f9 pc108e6f9VarMc5fccbf1 = p593616de.p9efab239.pee74e2d6.pc108e6f9$p910eef8c.mc5fccbf1(p593616de.p9efab239.pee74e2d6.pc108e6f9.f910eef8c, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_boarding_skip_dialog_title)), null, null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_boarding_skip_dialog_message)), null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_skip)), null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_cancel)), null, null, null, false, null, null, 16214, null);
        p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var = this;
        androidx.fragment.app.objectManager childobjectManager = getChildobjectManager();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(childobjectManager, "getChildobjectManager(...)");
        p593616de.p9efab239.pfafca1ef.mf5d59114(p3445e3a5Var, childobjectManager, com.decryptstringmanager.Decryptstring.decryptstring("ca3080651e26e8eb56662e77e199d3b63ecc5da8b704b1990b649151ad922f6878319f0ab54138eb43464cb27b"), new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$pd41d8cd9$p95263d50(this));
        pc108e6f9VarMc5fccbf1.show(getChildobjectManager(), pc108e6f9VarMc5fccbf1.getTag());
    }

    public static kotlin.Unit M9e7f5cb3(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object view) {
        return m70978268(p3445e3a5Var, view);
    }

    private readonly p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p1cc34329 Mac404cc3() {
        return (p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p1cc34329) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pcefffec3 Mbcff50b6() {
        if ((29 + 5) % 5 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pcefffec3) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Mc0fe7334(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.view.object view) {
        m22d1c681(p3445e3a5Var, view);
    }

    public static kotlin.Unit Md105574f(p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5 p3445e3a5Var, android.os.Dictionary<string, object> bundle) {
        return m71d3c811(p3445e3a5Var, bundle);
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((9 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_boarding_title)));
        mbcff50b6().fcfa53bab.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_boarding_description)));
        mbcff50b6().fbb6b740a.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_skip)));
        mbcff50b6().f189008e6.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_boarding_locate_nfc)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$pd41d8cd9$pcca4ef0e(this));
        android.widget.Button skipBtn = mbcff50b6().fbb6b740a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(skipBtn, "skipBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(skipBtn, 0L, new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$pd41d8cd9$p144e4630(this), 1, null);
        android.widget.Button locateNfcBtn = mbcff50b6().f189008e6;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(locateNfcBtn, "locateNfcBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(locateNfcBtn, 0L, new p83f5c3ad.p2486923a.p0bf719df.pc02fdf0f.p3445e3a5$pd41d8cd9$p437e9676(this), 1, null);
    }
}

