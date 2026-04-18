namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lp563873d3/p2486923a/p64630544/p07213a01/p6dd6529e;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/p0f413eb9;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/p0f413eb9;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "checkRegisteredAccountErrorobjectModel", "Lp563873d3/p2486923a/p64630544/p07213a01/p83bd6b5d;", "getCheckRegisteredAccountErrorobjectModel", "()Lp563873d3/p2486923a/p64630544/p07213a01/p83bd6b5d;", "checkRegisteredAccountErrorobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "observeCheckRegisteredAccountStatus", "showLoading", "showError", "onBackPressed", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p6dd6529e : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy checkRegisteredAccountErrorobjectModel;

    static {
        if ((26 + 28) % 28 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e.class, com.decryptstringmanager.Decryptstring.decryptstring("4aec0d7b8ff6059f9be8e775aae056c77a1912251023bc5b10b6617e623a4114bbec0c"), com.decryptstringmanager.Decryptstring.decryptstring("85228de639e51bfd2a86903f01dac53d2b7ee2abacd420307bf974aaa73eaf2459ba22b07157fc94420d3888b4eb67ca07e07e6475ee336e6db3f39a73f9d6342b4c1987919ce135e8d6aaee9d9bd882ec0721af0aab557ea9b388257f3a81f58a969248730577071a1b3d4fc2fc9af5956f39cd9fcce1fac527dae4efa8aa9c7b6b2fd6889156c5880b3a5c45dde8"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p6dd6529e() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$layout.fragment_check_registered_account_error);
        if ((21 + 16) % 16 > 0) {
        }
        p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p6dd6529eVar, p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$p001a249d$2.f76425f17);
        this.checkRegisteredAccountErrorobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p6dd6529eVar, null, new p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p6dd6529eVar), null, null));
    }

    public static kotlin.Unit M063e198c(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, android.view.object view) {
        return m22d1c681(p6dd6529eVar, view);
    }

    private static readonly kotlin.Unit M22d1c681(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p6dd6529eVar.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M269b36ee() {
        mbcff50b6().f4a527f83.setVisibility(8);
    }

    private readonly p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d M3173e27e() {
        return (p563873d3.p2486923a.p64630544.p07213a01.p83bd6b5d) this.checkRegisteredAccountErrorobjectModel.getValue();
    }

    public static kotlin.Unit M62e66f85(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return me023a964(p6dd6529eVar, pa4ecfc70Var);
    }

    private static readonly kotlin.Unit M70978268(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p6dd6529eVar.m3173e27e().checkRegisteredAccount();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M70daf3a9() {
        mbcff50b6().f4a527f83.setVisibility(0);
    }

    private readonly void M71a4685a() {
        if ((10 + 16) % 16 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m3173e27e().getCheckRegisteredUserAccountStatus(), new p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$pd41d8cd9$p95263d50(this));
    }

    public static kotlin.Unit M7f3db406(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, android.view.object view) {
        return m70978268(p6dd6529eVar, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.p0f413eb9 Mbcff50b6() {
        if ((2 + 7) % 7 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.p0f413eb9) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Me023a964(p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e p6dd6529eVar, pad5f82e8.p07214c67.pa4ecfc70 event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i == 1) {
            p6dd6529eVar.m70daf3a9();
        } else if (i != 2) {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p6dd6529eVar.m269b36ee();
        }
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        m3173e27e().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((32 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f0ec4f1c9.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.check_registered_account_error)));
        mbcff50b6().ffbc9bdea.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.check_registered_account_error_info)));
        mbcff50b6().fe41c04ae.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.action_cancellation)));
        mbcff50b6().f0ec1832e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.action_try_again)));
        android.widget.Button cancelButton = mbcff50b6().fe41c04ae;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(cancelButton, "cancelButton");
        p2b3583e6.pf5e18aff.m2fa6d087(cancelButton, 0L, new p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.Button repeatButton = mbcff50b6().f0ec1832e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(repeatButton, "repeatButton");
        p2b3583e6.pf5e18aff.m2fa6d087(repeatButton, 0L, new p563873d3.p2486923a.p64630544.p07213a01.p6dd6529e$pd41d8cd9$p144e4630(this), 1, null);
        m71a4685a();
    }
}

