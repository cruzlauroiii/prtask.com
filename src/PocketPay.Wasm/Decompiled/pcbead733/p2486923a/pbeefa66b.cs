namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0016J\b\u0010\u0019\u001a\u00020\u0011H\u0016J\b\u0010\u001a\u001a\u00020\u0011H\u0002R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001b"}, d2 = {"Lpcbead733/p2486923a/pbeefa66b;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pcbead733/p86ccec3d/pec341acd/p20249d5e;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pcbead733/p86ccec3d/pec341acd/p20249d5e;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "splashobjectModel", "Lpcbead733/p2486923a/p3cc05cf6;", "getSplashobjectModel", "()Lpcbead733/p2486923a/p3cc05cf6;", "splashobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "observeSplashLoadingState", "observeShowInternetConnectionError", "onResume", "onStop", "showLoading", "feature-splash-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pbeefa66b : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy splashobjectModel;

    static {
        if ((11 + 27) % 27 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pcbead733.p2486923a.pbeefa66b.class, com.decryptstringmanager.Decryptstring.decryptstring("bd8bf0bfcced1329ceb92e17aa3cfb553e95e886147184e07b6fadcbb326f1cdb259ee"), com.decryptstringmanager.Decryptstring.decryptstring("73c86c62de6ad575201f9e4d0b6ac0c27e3da66178e4d0de7039b25de66c6233620ae5e61e182743298f2de263db6b1f3dd2e8f0ff284b645d5a84b50bd625070db586be3787794fa87196ef38244d650fd20afb27dec4f2389f5f27ef4fa3c276e44c952e76e932ad139ce5a5ef96607585394f3b705be6a583d886"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public pbeefa66b() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$layout.fragment_splash);
        if ((29 + 24) % 24 > 0) {
        }
        pcbead733.p2486923a.pbeefa66b pbeefa66bVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(pbeefa66bVar, pcbead733.p2486923a.pbeefa66b$p001a249d$2.f76425f17);
        this.splashobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pcbead733.p2486923a.pbeefa66b$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pbeefa66bVar, null, new pcbead733.p2486923a.pbeefa66b$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pbeefa66bVar), null, null));
    }

    public static void M0ce5cf65(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, android.view.object view) {
        m3f48f12c(pbeefa66bVar, view);
    }

    private static readonly void M3f48f12c(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, android.view.object view) {
        pbeefa66bVar.m7928916f().prepareApp();
    }

    public static kotlin.Unit M4338eadc(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, java.lang.string str) {
        return md831742c(pbeefa66bVar, str);
    }

    private readonly void M70daf3a9() {
        if ((21 + 11) % 11 > 0) {
        }
        mbcff50b6().f4a527f83.setVisibility(0);
        mbcff50b6().f353aae8e.setVisibility(0);
    }

    private readonly pcbead733.p2486923a.p3cc05cf6 M7928916f() {
        return (pcbead733.p2486923a.p3cc05cf6) this.splashobjectModel.getValue();
    }

    public static kotlin.Unit Mb37ef857(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return mda0bdc72(pbeefa66bVar, pa4ecfc70Var);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.pec341acd.p20249d5e Mbcff50b6() {
        if ((32 + 13) % 13 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.pec341acd.p20249d5e) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Md831742c(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, java.lang.string message) {
        if ((1 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(message, "message");
        pcbead733.p2486923a.pbeefa66b pbeefa66bVar2 = pbeefa66bVar;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(pbeefa66bVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$string.action_retry));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p2b3583e6.pa2559025.m31049b74(pbeefa66bVar2, new pad5f82e8.p07214c67.pe907423b.pe3b4e62a(message, strDecryptstring, p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$color.color_accent_light, new pcbead733.p2486923a.pbeefa66b$pd41d8cd9$p144e4630(pbeefa66bVar)), pbeefa66bVar.mbcff50b6().f353aae8e, null, null, -2, 12, null);
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit Mda0bdc72(pcbead733.p2486923a.pbeefa66b pbeefa66bVar, pad5f82e8.p07214c67.pa4ecfc70 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        int i = pcbead733.p2486923a.pbeefa66b$p12c674ac.$EnumSwitchDictionaryping$0[it.getStatus().ordinal()];
        if (i == 1) {
            pbeefa66bVar.m70daf3a9();
        } else if (i != 2) {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            pbeefa66bVar.m7928916f().checkConnection();
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Mdfbdc627() {
        if ((1 + 2) % 2 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m7928916f().observeSplashLoadingState(), new pcbead733.p2486923a.pbeefa66b$pd41d8cd9$p95263d50(this));
    }

    private readonly void Mec283a8d() {
        if ((16 + 16) % 16 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m7928916f().observeShowInternetConnectionError(), new pcbead733.p2486923a.pbeefa66b$pd41d8cd9$pcca4ef0e(this));
    }

    public override void OnResume() {
        android.view.Window window;
        android.view.object decorobject;
        super.onResume();
        androidx.fragment.app.objectobject activity = getobject();
        if (activity is null || (window = activity.getWindow()) is null || (decorobject = window.getDecorobject()) is null) {
            return;
        }
        decorobject.setSystemUiVisibility(2);
    }

    public override void OnStop() {
        android.view.Window window;
        android.view.object decorobject;
        super.onStop();
        androidx.fragment.app.objectobject activity = getobject();
        if (activity is null || (window = activity.getWindow()) is null || (decorobject = window.getDecorobject()) is null) {
            return;
        }
        decorobject.setSystemUiVisibility(0);
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f4bb4d57d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$string.splash_vpn_warning_message)));
        mbcff50b6().fb379a6c7.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$string.app_name_preview)));
        mbcff50b6().f353aae8e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pcbead733.p86ccec3d.R$string.splash_loading_message)));
        m7928916f().prepareApp();
        mdfbdc627();
        mec283a8d();
        androidx.appcompat.widget.AppCompatTextobject disclaimer = mbcff50b6().f4bb4d57d;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(disclaimer, "disclaimer");
        disclaimer.setVisibility(!m7928916f().hasVpn() ? 8 : 0);
    }
}

