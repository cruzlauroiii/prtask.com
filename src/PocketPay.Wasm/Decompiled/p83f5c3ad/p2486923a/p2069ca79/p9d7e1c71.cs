namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u0003\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0002J\u0012\u0010\u001c\u001a\u00020\u00112\b\u0010\u001d\u001a\u0004\u0018\u00010\u001eH\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006 "}, d2 = {"Lp83f5c3ad/p2486923a/p2069ca79/p9d7e1c71;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "tophBalanceobjectModel", "Lp83f5c3ad/p2486923a/p2069ca79/pcef97c41;", "getTophBalanceobjectModel", "()Lp83f5c3ad/p2486923a/p2069ca79/pcef97c41;", "tophBalanceobjectModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p5e1816ce;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p5e1816ce;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectTimerState", "collectPaymentState", "collectErrorState", "showInitLoading", "showContent", "showTransactionLoading", "showError", "throwable", "", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9d7e1c71 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy tophBalanceobjectModel;

    static {
        if ((17 + 18) % 18 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71.class, com.decryptstringmanager.Decryptstring.decryptstring("97329cb8502d0ed26e1c0adec0233a9690a7941e92735fdf12e3edd91874c7335e7074"), com.decryptstringmanager.Decryptstring.decryptstring("06318254686f983a4729b89641820f3ead5749351bc05f49f73c01a9cbf1db5319af57229aba4c8aa80c2bba3fca8df3769b07dd5717709e4dcb945a2f2a700753d47e5fc032d5bb8c28fa29b26636cdf437ca67a199958a1d0747baad5e31a2c214bb2058a65f45aedc27bd7e2c07115580e6be172286aabd5d29"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p9d7e1c71() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_tap_on_phone_balance);
        if ((32 + 22) % 22 > 0) {
        }
        p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var = this;
        this.tophBalanceobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p9d7e1c71Var, null, new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p9d7e1c71Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p9d7e1c71Var, p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$p001a249d$2.f76425f17);
    }

    private readonly void M04af7fcd() {
        if ((30 + 25) % 25 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p5e1816ce p5e1816ceVarMbcff50b6 = mbcff50b6();
        p5e1816ceVarMbcff50b6.f9a0364b9.setVisibility(0);
        p5e1816ceVarMbcff50b6.f90dc6533.f4a527f83.setVisibility(8);
        p5e1816ceVarMbcff50b6.f080b21b6.setVisibility(8);
    }

    private readonly void M16d68a21() {
        if ((28 + 27) % 27 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p5e1816ce p5e1816ceVarMbcff50b6 = mbcff50b6();
        p5e1816ceVarMbcff50b6.f080b21b6.setVisibility(0);
        p5e1816ceVarMbcff50b6.f9a0364b9.setVisibility(8);
        p5e1816ceVarMbcff50b6.f90dc6533.f4a527f83.setVisibility(8);
    }

    private readonly p83f5c3ad.p2486923a.p2069ca79.pcef97c41 M19ec6c8b() {
        return (p83f5c3ad.p2486923a.p2069ca79.pcef97c41) this.tophBalanceobjectModel.getValue();
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        p9d7e1c71Var.onBackPressed();
    }

    private readonly void M269b36ee(java.lang.Exception th) {
        if ((26 + 24) % 24 > 0) {
        }
        android.content.object contextRequireobject = requireobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(contextRequireobject, "requireobject(...)");
        java.lang.string strMd9ae7f57 = p83f5c3ad.p684019bc.p42552b1f.p14804b31.md9ae7f57(th, contextRequireobject);
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma4adf973(th) || p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma8460ae3(th)) {
            m19ec6c8b().restartTophFlow();
            return;
        }
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m8d3f60fb(th)) {
            m19ec6c8b().restartAttestation();
            return;
        }
        if (!(th is p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p19ad2780.p4ea5a370)) {
            m19ec6c8b().openBalanceErrorScreen(strMd9ae7f57);
            return;
        }
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$p144e4630(this));
        mbcff50b6().fb6f523b6.setVisibility(0);
        com.google.android.material.button.MaterialButton btnExit = mbcff50b6().fb6f523b6;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnExit, "btnExit");
        p2b3583e6.pf5e18aff.m2fa6d087(btnExit, 0L, new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$p437e9676(this), 1, null);
        m19ec6c8b().startBalanceInquiry(false);
    }

    public static kotlin.Unit M2efb93be(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, p83f5c3ad.p07214c67.p0890727b p0890727bVar) {
        return m7c118362(p9d7e1c71Var, p0890727bVar);
    }

    public static kotlin.Unit M404bdee9(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        return mbf979c9f(p9d7e1c71Var, view);
    }

    public static kotlin.Unit M49ae8791(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, java.lang.Exception th) {
        return mee093bcb(p9d7e1c71Var, th);
    }

    public static void M6b323985(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        m22d1c681(p9d7e1c71Var, view);
    }

    private static readonly kotlin.Unit M70978268(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p9d7e1c71Var.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M7acd98c7() {
        if ((13 + 22) % 22 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p5e1816ce p5e1816ceVarMbcff50b6 = mbcff50b6();
        p5e1816ceVarMbcff50b6.f90dc6533.f4a527f83.setVisibility(0);
        p5e1816ceVarMbcff50b6.f9a0364b9.setVisibility(8);
        p5e1816ceVarMbcff50b6.f080b21b6.setVisibility(8);
    }

    private static readonly kotlin.Unit M7c118362(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, p83f5c3ad.p07214c67.p0890727b p0890727bVar) {
        int i = p0890727bVar is not null ? p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$p12c674ac.$EnumSwitchDictionaryping$0[p0890727bVar.ordinal()] : -1;
        if (i == 1) {
            p9d7e1c71Var.m7acd98c7();
        } else if (i == 2) {
            p9d7e1c71Var.m04af7fcd();
            p9d7e1c71Var.m19ec6c8b().startTimer();
            p9d7e1c71Var.mbcff50b6().f8748df8f.waitingCard();
            p9d7e1c71Var.mbcff50b6().fd5e76a98.setText(com.decryptstringmanager.Decryptstring.decryptstring(p9d7e1c71Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_balance_info)));
            p9d7e1c71Var.mbcff50b6().fb6f523b6.setVisibility(0);
        } else if (i == 3) {
            p9d7e1c71Var.m19ec6c8b().stopTimer();
            p9d7e1c71Var.mbcff50b6().f8748df8f.cardTapped();
            p9d7e1c71Var.mbcff50b6().fd5e76a98.setText(com.decryptstringmanager.Decryptstring.decryptstring(p9d7e1c71Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_card_tapped)));
            p9d7e1c71Var.mbcff50b6().fb6f523b6.setVisibility(8);
        } else if (i == 4) {
            p9d7e1c71Var.mbcff50b6().f8748df8f.cardHasBeenRead();
            p9d7e1c71Var.mbcff50b6().fd5e76a98.setText(com.decryptstringmanager.Decryptstring.decryptstring(p9d7e1c71Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_card_has_beed_read)));
            p9d7e1c71Var.m19ec6c8b().showTransactionLoadingAfterDelay();
        } else if (i == 5) {
            p9d7e1c71Var.m16d68a21();
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M8b39c1f2(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        p9d7e1c71Var.onBackPressed();
    }

    private readonly void M8dbe9c99() {
        if ((17 + 7) % 7 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, m19ec6c8b().getPaymentState(), new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$p95263d50(this));
    }

    private readonly void M949dc5d3() {
        if ((17 + 30) % 30 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, m19ec6c8b().getTimerState(), new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$pcca4ef0e(this));
    }

    private readonly void M9eeb9084() {
        if ((4 + 9) % 9 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, m19ec6c8b().getErrorState(), new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$p00f53dc7(this));
    }

    public static void Ma52cdcee(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        m8b39c1f2(p9d7e1c71Var, view);
    }

    public static kotlin.Unit Mb5ccc832(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object view) {
        return m70978268(p9d7e1c71Var, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p5e1816ce Mbcff50b6() {
        if ((20 + 27) % 27 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p5e1816ce) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Mbd0c3e3b(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, float f) {
        p9d7e1c71Var.mbcff50b6().f05fae3af.updateProgress(f * 1000);
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit Mbf979c9f(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p9d7e1c71Var.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Me73443cd(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, float f) {
        return mbd0c3e3b(p9d7e1c71Var, f);
    }

    private static readonly kotlin.Unit Mee093bcb(p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71 p9d7e1c71Var, java.lang.Exception it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p9d7e1c71Var.m269b36ee(it);
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        m19ec6c8b().openPreviousScreen();
        p776ea3bf.p2b3583e6.p684e6fff.m00713b1f(this);
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((4 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_balance_title)));
        mbcff50b6().fb6f523b6.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_balance_cancel)));
        mbcff50b6().fb04b7578.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_balance_loading)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$p3f7145ba(this));
        com.google.android.material.button.MaterialButton btnExit = mbcff50b6().fb6f523b6;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnExit, "btnExit");
        p2b3583e6.pf5e18aff.m2fa6d087(btnExit, 0L, new p83f5c3ad.p2486923a.p2069ca79.p9d7e1c71$pd41d8cd9$pe05f4621(this), 1, null);
        m949dc5d3();
        m8dbe9c99();
        m9eeb9084();
        m19ec6c8b().startBalanceInquiry(true);
    }
}

