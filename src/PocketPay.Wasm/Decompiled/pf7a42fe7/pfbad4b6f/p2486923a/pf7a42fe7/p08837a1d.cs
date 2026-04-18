namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0010\u000e\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0002J\u0010\u0010\u001c\u001a\u00020\u00112\u0006\u0010\u001d\u001a\u00020\u001eH\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0002J\b\u0010 \u001a\u00020\u0011H\u0002J\b\u0010!\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\""}, d2 = {"Lpf7a42fe7/pfbad4b6f/p2486923a/pf7a42fe7/p08837a1d;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lpf7a42fe7/pfbad4b6f/p2e0e9d9c/pec341acd/p34ff6d01;", "getBinding", "()Lpf7a42fe7/pfbad4b6f/p2e0e9d9c/pec341acd/p34ff6d01;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "phoneVerificationobjectModel", "Lpf7a42fe7/pfbad4b6f/p2486923a/pf7a42fe7/p26456980;", "getPhoneVerificationobjectModel", "()Lpf7a42fe7/pfbad4b6f/p2486923a/pf7a42fe7/p26456980;", "phoneVerificationobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initPhoneobject", "initClickListeners", "observePhoneValidationState", "observeSmsSendingState", "getUnregisteredTIDState", "showLoading", "showError", "message", "", "observeSwitchHostState", "showPrivacyNoticeBS", "onBackPressed", "feature-phone-verification-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p08837a1d : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy phoneVerificationobjectModel;

    static {
        if ((14 + 19) % 19 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d.class, com.decryptstringmanager.Decryptstring.decryptstring("dd2af2fedfcdbb6431607eb3b99e5ecedf4e036ae3567b3edcbaa1a90e973756e629a0"), com.decryptstringmanager.Decryptstring.decryptstring("09543e4bc64bdddda3e05f5ddf86a589ad5cfd4c4e685d198133a387753f7a1eea1a48ebca27df10d7f1be023deebb756f302ce0803d719ede1e9d34b761609f2255768d112e6dbd9dd963b2023946dc68ba6845da8ae59fb5de91f7fc5ee78567e7ba6300083ecf052137b2635aaadcabb5cabff4dff19bf5475b99a385b2a7f5900a62dae35a4233"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p08837a1d() {
        super(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$layout.fragment_phone_verification);
        if ((21 + 1) % 1 > 0) {
        }
        pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p08837a1dVar, pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$p001a249d$2.f76425f17);
        this.phoneVerificationobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p08837a1dVar, null, new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p08837a1dVar), null, null));
    }

    private readonly void M025da8fd() {
        if ((20 + 17) % 17 > 0) {
        }
        android.widget.Button confirmPhoneButton = mbcff50b6().f739a6e4e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(confirmPhoneButton, "confirmPhoneButton");
        p2b3583e6.pf5e18aff.m2fa6d087(confirmPhoneButton, 0L, new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$pe05f4621(this), 1, null);
        androidx.appcompat.widget.Toolbar toolbar = mbcff50b6().ff50b3c2a;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(toolbar, "toolbar");
        p2b3583e6.pf5e18aff.m2fa6d087(toolbar, 0L, new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p2dcb4222(this), 1, null);
    }

    private readonly void M1f170760() {
        if ((31 + 16) % 16 > 0) {
        }
        p593616de.p9efab239.pee74e2d6.pc108e6f9 pc108e6f9VarMc5fccbf1 = p593616de.p9efab239.pee74e2d6.pc108e6f9$p910eef8c.mc5fccbf1(p593616de.p9efab239.pee74e2d6.pc108e6f9.f910eef8c, com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.privacy_notice_bs_title)), null, null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.privacy_notice_bs_message)), null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.privacy_notice_bs_understand)), null, null, null, null, null, false, null, null, 16342, null);
        pc108e6f9VarMc5fccbf1.show(getChildobjectManager(), pc108e6f9VarMc5fccbf1.getTag());
    }

    private static readonly kotlin.Unit M1fb77076(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pad5f82e8.p07214c67.pa4ecfc70 event) {
        if ((5 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$p12c674ac.$EnumSwitchDictionaryping$1[event.getStatus().ordinal()];
        if (i == 1) {
            p08837a1dVar.m70daf3a9();
        } else if (i != 2) {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            java.lang.Exception throwable = event.getException();
            java.lang.string message = throwable is null ? null : throwable.getMessage();
            if (message is null) {
                message = "";
            }
            p08837a1dVar.m269b36ee(message);
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M269b36ee(java.lang.string str) {
        if ((3 + 13) % 13 > 0) {
        }
        mbcff50b6().f4a527f83.setVisibility(8);
        p2b3583e6.pa2559025.m31049b74(this, new pad5f82e8.p07214c67.pe907423b.p89a5ff7f(str), null, null, null, 0, 30, null);
    }

    private static readonly kotlin.Unit M312b169a(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pa617908b.pfdef8b4b state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$p12c674ac.$EnumSwitchDictionaryping$0[state.ordinal()];
        if (i == 1) {
            p08837a1dVar.mbcff50b6().f739a6e4e.setEnabled(true);
        } else {
            if (i != 2) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p08837a1dVar.mbcff50b6().f739a6e4e.setEnabled(false);
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M371c6e9c() {
        if ((19 + 9) % 9 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mfc8da25c().getPhoneValidationState(), new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p144e4630(this));
    }

    public static kotlin.Unit M4820d94f(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pa617908b.pfdef8b4b pfdef8b4bVar) {
        return m312b169a(p08837a1dVar, pfdef8b4bVar);
    }

    private static readonly kotlin.Unit M61b7b549(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p08837a1dVar.mfc8da25c().switchHost();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M6689cc0a(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p08837a1dVar.mfc8da25c().getSms();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M706713d3(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, java.lang.string str, int i) {
        return ma55d17ff(p08837a1dVar, str, i);
    }

    private readonly void M70daf3a9() {
        mbcff50b6().f4a527f83.setVisibility(0);
    }

    private readonly void M74d612fd() {
        if ((8 + 22) % 22 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mfc8da25c().getUnregisteredTIDState(), new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p3f7145ba(this));
    }

    private static readonly kotlin.Unit Ma55d17ff(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, java.lang.string phone, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phone, "phone");
        p08837a1dVar.mfc8da25c().setPhone(phone);
        p08837a1dVar.mfc8da25c().validatePhone(i);
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit Maaccf149(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p08837a1dVar.m1f170760();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mafaa5177(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, java.lang.object obj) {
        return mcae31811(p08837a1dVar, obj);
    }

    public static kotlin.Unit Mb1bdd965(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object view) {
        return m6689cc0a(p08837a1dVar, view);
    }

    private readonly void Mbc084e0e() {
        if ((29 + 22) % 22 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mfc8da25c().getSmsSendingState(), new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p437e9676(this));
    }

    private readonly pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01 Mbcff50b6() {
        if ((22 + 32) % 32 > 0) {
        }
        return (pf7a42fe7.pfbad4b6f.p2e0e9d9c.pec341acd.p34ff6d01) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly void Mc7555313() {
        if ((31 + 30) % 30 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mfc8da25c().getSwitchHostStateState(), new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p00f53dc7(this));
    }

    public static kotlin.Unit Mc76ea05f(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 pb3f3bb37Var) {
        return meaab9a41(p08837a1dVar, pb3f3bb37Var);
    }

    private static readonly kotlin.Unit Mcae31811(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, java.lang.object it) {
        if ((24 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p08837a1dVar.mbcff50b6().f4a527f83.setVisibility(8);
        p593616de.p9efab239.pee74e2d6.pb456a1c4 pb456a1c4VarMc5fccbf1 = p593616de.p9efab239.pee74e2d6.pb456a1c4$p910eef8c.mc5fccbf1(p593616de.p9efab239.pee74e2d6.pb456a1c4.f910eef8c, com.decryptstringmanager.Decryptstring.decryptstring(p08837a1dVar.getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.toph_activation_not_permitted_error_bs_title)), com.decryptstringmanager.Decryptstring.decryptstring(p08837a1dVar.getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.toph_activation_not_permitted_error_bs_text)), null, null, com.decryptstringmanager.Decryptstring.decryptstring(p08837a1dVar.getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.action_close)), 12, null);
        pb456a1c4VarMc5fccbf1.show(p08837a1dVar.getChildobjectManager(), pb456a1c4VarMc5fccbf1.getTag());
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mde37ed12(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object view) {
        return m61b7b549(p08837a1dVar, view);
    }

    public static kotlin.Unit Mdf83590f(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, android.view.object view) {
        return maaccf149(p08837a1dVar, view);
    }

    private readonly void Me44412ff() {
        if ((11 + 30) % 30 > 0) {
        }
        android.widget.Button btnPrivacyNotice = mbcff50b6().ff92767a8;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnPrivacyNotice, "btnPrivacyNotice");
        p2b3583e6.pf5e18aff.m2fa6d087(btnPrivacyNotice, 0L, new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$p95263d50(this), 1, null);
        p59a14a57.pf7a42fe7.pe9a5d05c pe9a5d05cVar = mbcff50b6().ffe0ce730;
        p59a14a57.pf7a42fe7.pe9a5d05c.me89f72a7(pe9a5d05cVar, null, 1, null);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.phone_verification_hint));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        pe9a5d05cVar.setPhoneHint(strDecryptstring);
        pe9a5d05cVar.setOnPhoneChangedListener(new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d$pd41d8cd9$pcca4ef0e(this));
    }

    private static readonly kotlin.Unit Meaab9a41(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 snackBar) {
        if ((9 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(snackBar, "snackBar");
        p2b3583e6.pa2559025.m31049b74(p08837a1dVar, snackBar, p08837a1dVar.mbcff50b6().f739a6e4e, null, null, 0, 28, null);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mf3085a6f(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p08837a1d p08837a1dVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m1fb77076(p08837a1dVar, pa4ecfc70Var);
    }

    private readonly pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980 Mfc8da25c() {
        return (pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980) this.phoneVerificationobjectModel.getValue();
    }

    public override void OnBackPressed() {
        mfc8da25c().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.app_name_preview)));
        mbcff50b6().f68f5cc99.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.phone_verification_title)));
        mbcff50b6().f8303d3aa.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.phone_verification_info)));
        mbcff50b6().ff92767a8.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.privacy_notice_title)));
        mbcff50b6().f739a6e4e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(pf7a42fe7.pfbad4b6f.p2e0e9d9c.R$string.action_enter)));
        me44412ff();
        m025da8fd();
        m371c6e9c();
        mbc084e0e();
        m74d612fd();
        mc7555313();
    }
}

