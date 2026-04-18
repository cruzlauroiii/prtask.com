namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\u0010\u0010\u0017\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u0019H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0002J\b\u0010\u001c\u001a\u00020\u0011H\u0002J\b\u0010\u001d\u001a\u00020\u0011H\u0002J\b\u0010\u001e\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001f"}, d2 = {"Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/p82685126;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p96d30f99;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p96d30f99;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/paf1985d6;", "getobjectModel", "()Lp83f5c3ad/p2486923a/p0bf719df/p657f8b8d/paf1985d6;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectData", "setupCalibratedNfcobjects", "isShowNfcSpot", "", "setupNotCalibratedNfcobjects", "showLoading", "showContent", "showSnackBarError", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p82685126 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((27 + 7) % 7 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126.class, com.decryptstringmanager.Decryptstring.decryptstring("e005a698cd576597f4515eec22f5595b6711880e82cc998f8a7341a3d94a4b6112bc84"), com.decryptstringmanager.Decryptstring.decryptstring("f473c3fce39055e25588b4d9ae030288cfd2f59717d41fbcb96a61fd5ed5934d40c93fa227f343b041d39f76247ce8d82a0093e3dde9b7e2db6d0d7a4bcbfbbe590b8f390c320ec4dadbc68a74f4f8078d1154aff2a860a7d658eaed67a2231019021967762ad216169fee6e0f9996f7608526ce79d40df891b35a84888a8436"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p82685126() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_nfc_calibration_help);
        if ((30 + 22) % 22 > 0) {
        }
        p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p82685126Var, p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p82685126Var, null, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p82685126Var), null, null));
    }

    private readonly void M04af7fcd() {
        if ((17 + 18) % 18 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintLayout content = mbcff50b6().f9a0364b9;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(content, "content");
        content.setVisibility(0);
        android.widget.FrameLayout step2ActionLayout = mbcff50b6().f12f6837b;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2ActionLayout, "step2ActionLayout");
        step2ActionLayout.setVisibility(0);
        androidx.constraintlayout.widget.ConstraintLayout loader = mbcff50b6().fdb276d10.f4a527f83;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(loader, "loader");
        loader.setVisibility(8);
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object view) {
        p82685126Var.onBackPressed();
    }

    public static kotlin.Unit M2731b199(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object view) {
        return mee3a4bc4(p82685126Var, view);
    }

    private readonly void M49d81568() {
        if ((16 + 19) % 19 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getUiState(), new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$pd41d8cd9$p00f53dc7(this));
    }

    private static readonly kotlin.Unit M531ec5ab(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p82685126Var.mac404cc3().startTophNfcCalibrationFlow();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M5c3f0f25(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object view) {
        return m531ec5ab(p82685126Var, view);
    }

    private readonly void M6da993e0(bool z) {
        if ((16 + 20) % 20 > 0) {
        }
        androidx.cardview.widget.Cardobject step2ShowNfcSpotCv = mbcff50b6().f8a1a751e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2ShowNfcSpotCv, "step2ShowNfcSpotCv");
        step2ShowNfcSpotCv.setVisibility(0);
        mbcff50b6().f6244f310.setChecked(z);
        androidx.cardview.widget.Cardobject step2ShowNfcSpotCv2 = mbcff50b6().f8a1a751e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2ShowNfcSpotCv2, "step2ShowNfcSpotCv");
        p2b3583e6.pf5e18aff.m2fa6d087(step2ShowNfcSpotCv2, 0L, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$pd41d8cd9$p144e4630(this), 1, null);
        com.google.android.material.button.MaterialButton step2IdentifyNfcLocationBtn = mbcff50b6().ff86d38ae;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2IdentifyNfcLocationBtn, "step2IdentifyNfcLocationBtn");
        step2IdentifyNfcLocationBtn.setVisibility(8);
    }

    private static readonly kotlin.Unit M70978268(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p82685126Var.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M70daf3a9() {
        if ((13 + 5) % 5 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintLayout loader = mbcff50b6().fdb276d10.f4a527f83;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(loader, "loader");
        loader.setVisibility(0);
        androidx.constraintlayout.widget.ConstraintLayout content = mbcff50b6().f9a0364b9;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(content, "content");
        content.setVisibility(8);
    }

    private readonly void M9f54cce7() {
        if ((20 + 16) % 16 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintLayout content = mbcff50b6().f9a0364b9;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(content, "content");
        content.setVisibility(0);
        android.widget.FrameLayout step2ActionLayout = mbcff50b6().f12f6837b;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2ActionLayout, "step2ActionLayout");
        step2ActionLayout.setVisibility(8);
        androidx.constraintlayout.widget.ConstraintLayout loader = mbcff50b6().fdb276d10.f4a527f83;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(loader, "loader");
        loader.setVisibility(8);
        p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var = this;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.common_error));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p2b3583e6.pa2559025.m31049b74(p82685126Var, new pad5f82e8.p07214c67.pe907423b.p89a5ff7f(strDecryptstring), null, null, null, 0, 30, null);
    }

    private readonly p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6 Mac404cc3() {
        return (p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.paf1985d6) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p96d30f99 Mbcff50b6() {
        if ((2 + 14) % 14 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p96d30f99) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly void Md5d04072() {
        if ((30 + 26) % 26 > 0) {
        }
        com.google.android.material.button.MaterialButton step2IdentifyNfcLocationBtn = mbcff50b6().ff86d38ae;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2IdentifyNfcLocationBtn, "step2IdentifyNfcLocationBtn");
        step2IdentifyNfcLocationBtn.setVisibility(0);
        com.google.android.material.button.MaterialButton step2IdentifyNfcLocationBtn2 = mbcff50b6().ff86d38ae;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2IdentifyNfcLocationBtn2, "step2IdentifyNfcLocationBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(step2IdentifyNfcLocationBtn2, 0L, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$pd41d8cd9$p437e9676(this), 1, null);
        androidx.cardview.widget.Cardobject step2ShowNfcSpotCv = mbcff50b6().f8a1a751e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(step2ShowNfcSpotCv, "step2ShowNfcSpotCv");
        step2ShowNfcSpotCv.setVisibility(8);
    }

    public static void Med8432df(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object view) {
        m22d1c681(p82685126Var, view);
    }

    private static readonly kotlin.Unit Mee3a4bc4(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p82685126Var.mac404cc3().setShowNfcSpotChecked(!p82685126Var.mbcff50b6().f6244f310.isChecked());
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mef905eac(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 p247a0e39Var) {
        return mfa01c813(p82685126Var, p247a0e39Var);
    }

    public static kotlin.Unit Mf4278939(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, android.view.object view) {
        return m70978268(p82685126Var, view);
    }

    private static readonly kotlin.Unit Mfa01c813(p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126 p82685126Var, p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p247a0e39 state) {
        if ((27 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$p12c674ac.$EnumSwitchDictionaryping$0[state.isNfcCalibrated().getStatus().ordinal()];
        if (i == 1) {
            p82685126Var.m70daf3a9();
        } else if (i == 2) {
            java.lang.bool bool = (java.lang.bool) state.isNfcCalibrated().getData();
            if (bool is not null) {
                if (bool.boolValue()) {
                    p82685126Var.m6da993e0(state.isShowNfcSpot());
                } else {
                    p82685126Var.md5d04072();
                }
            }
            p82685126Var.m04af7fcd();
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p82685126Var.m9f54cce7();
        }
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((21 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_title)));
        mbcff50b6().f05882d51.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._1)));
        mbcff50b6().f80e9725a.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step1)));
        mbcff50b6().fcbdddb69.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._2)));
        mbcff50b6().fe21839eb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step2)));
        mbcff50b6().f368ea36f.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step2_show_nfc_spot)));
        mbcff50b6().ff86d38ae.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step2_identify_nfc_location)));
        mbcff50b6().f67595656.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step2_description)));
        mbcff50b6().f1140ba51.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._3)));
        mbcff50b6().fbde9b59d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step3)));
        mbcff50b6().fc2aa2106.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._4)));
        mbcff50b6().f6f43c5ff.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step4)));
        mbcff50b6().f8e085b00.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string._5)));
        mbcff50b6().ffabc5d24.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_calibration_help_step5)));
        mbcff50b6().fac8e374f.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_return)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$pd41d8cd9$p95263d50(this));
        android.widget.Button returnBtn = mbcff50b6().fac8e374f;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(returnBtn, "returnBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(returnBtn, 0L, new p83f5c3ad.p2486923a.p0bf719df.p657f8b8d.p82685126$pd41d8cd9$pcca4ef0e(this), 1, null);
        m49d81568();
    }
}

