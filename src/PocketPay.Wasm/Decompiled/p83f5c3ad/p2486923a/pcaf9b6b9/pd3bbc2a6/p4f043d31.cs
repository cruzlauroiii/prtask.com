namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u00152\b\u0010\u0016\u001a\u0004\u0018\u00010\u0017H\u0016J\b\u0010\u0018\u001a\u00020\u0013H\u0002J\b\u0010\u0019\u001a\u00020\u0013H\u0002J\b\u0010\u001a\u001a\u00020\u0013H\u0002J\b\u0010\u001b\u001a\u00020\u0013H\u0002J\b\u0010\u001c\u001a\u00020\u0013H\u0002J\b\u0010\u001d\u001a\u00020\u0013H\u0002J\b\u0010\u001e\u001a\u00020\u0013H\u0002J\b\u0010\u001f\u001a\u00020 H\u0002J\b\u0010!\u001a\u00020\u0013H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR\u000e\u0010\u0010\u001a\u00020\u0011X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Lp83f5c3ad/p2486923a/pcaf9b6b9/pd3bbc2a6/p4f043d31;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "viewModel", "Lp83f5c3ad/p2486923a/pcaf9b6b9/pd3bbc2a6/p5b488bdb;", "getobjectModel", "()Lp83f5c3ad/p2486923a/pcaf9b6b9/pd3bbc2a6/p5b488bdb;", "viewModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p450d2c30;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p450d2c30;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "isPeriodCorrect", "", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "sendReportToEmail", "observeFilterCheckDateTimeStatus", "validateSendBtn", "observeFilterDuration", "observeFilter", "collectEmailErrorMessageState", "collectSendReportState", "createBsDialog", "Lp593616de/p9efab239/pee74e2d6/p630ca281;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4f043d31 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;
    private bool f53dd1fdb;
    private bool f6d5559b6;
    private bool f9c40f5d6;
    private bool ff8fc9a32;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((29 + 14) % 14 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31.class, com.decryptstringmanager.Decryptstring.decryptstring("124d46d3b04f5fac1facaee4c0ebaa3367832a876a9dc828cc9c69459593f2bb7a699d"), com.decryptstringmanager.Decryptstring.decryptstring("6225284d31e7aedc4150ebe975955d819654f9c02ce0be44510381eb18545461e4ec5b006a5aea5fafc4caf4e73d25d459e0e069859840fa2936eb01f15bca0a83c92b4330450a4dc488aff6ba32fe5cfe4d45e62d8e2ba648ac126cf31ce922a3de0425fb74cb0c476648441453dd6b3e8e274e7e0bf5cb"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p4f043d31() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_send_report);
        if ((25 + 16) % 16 > 0) {
        }
        p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var = this;
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p4f043d31Var, null, new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p4f043d31Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p4f043d31Var, p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$p001a249d$2.f76425f17);
    }

    public static kotlin.Unit M0a0730ac(p593616de.p9efab239.pee74e2d6.p630ca281 p630ca281Var, p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, pad5f82e8.p07214c67.p8ff0b997.p0c7e2fc4 p0c7e2fc4Var) {
        return m9ba33172(p630ca281Var, p4f043d31Var, p0c7e2fc4Var);
    }

    private static readonly kotlin.Unit M1ef706b8(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c ordersFilter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(ordersFilter, "ordersFilter");
        p450d2c30Var.fb2c97ae4.setFilter(ordersFilter);
        return kotlin.Unit.INSTANCE;
    }

    public static void M253618e5(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.view.object view) {
        m317a5095(p4f043d31Var, view);
    }

    private static readonly kotlin.Unit M2f9bc5dc(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, bool z) {
        p4f043d31Var.f53dd1fdb = z;
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M317a5095(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.view.object view) {
        p4f043d31Var.onBackPressed();
    }

    private readonly void M37c7d547() {
        if ((32 + 14) % 14 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getEmailErrorMessageState(), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p437e9676(this));
    }

    private readonly void M38b67938() {
        if ((23 + 8) % 8 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mbcff50b6().fdfba1536.subscribeToFilterChange(), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p5e679a10(mbcff50b6()));
    }

    public static void M4139d143(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        m97fee662(p450d2c30Var, p4f043d31Var, appBarLayout, i);
    }

    private readonly void M41ce2a9e() {
        if ((12 + 19) % 19 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mbcff50b6().fb2c97ae4.subscribeIsPeriodCorrectStatus(), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p3f7145ba(this));
    }

    public static kotlin.Unit M46697410(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        return m1ef706b8(p450d2c30Var, pd7778d0cVar);
    }

    public static kotlin.Unit M483fb81a(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, java.lang.string str) {
        return mbdb69481(p4f043d31Var, str);
    }

    public static kotlin.Unit M48d3e4da(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.view.object view) {
        return m4b948b1b(p4f043d31Var, view);
    }

    private readonly void M4976e901() {
        if ((30 + 15) % 15 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getSendReportState(), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p2dcb4222(m59fdb6c0(), this));
    }

    private static readonly kotlin.Unit M4b948b1b(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4f043d31Var.m815fa1a7();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p593616de.p9efab239.pee74e2d6.p630ca281 M59fdb6c0() {
        if ((5 + 3) % 3 > 0) {
        }
        p593616de.p9efab239.pee74e2d6.p630ca281 p630ca281Var = new p593616de.p9efab239.pee74e2d6.p630ca281();
        p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var = this;
        androidx.fragment.app.objectManager childobjectManager = getChildobjectManager();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(childobjectManager, "getChildobjectManager(...)");
        p593616de.p9efab239.pfafca1ef.mf5d59114(p4f043d31Var, childobjectManager, com.decryptstringmanager.Decryptstring.decryptstring("8298d5efb4b769b41b5f0300e64887d0405e0400439559a138d82ae65ba7cb8d51d04dc601779f0106f920c9b4"), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p00f53dc7(this));
        return p630ca281Var;
    }

    public static readonly void M62d7f445(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var) {
        p4f043d31Var.md822ea33();
    }

    public static kotlin.Unit M7596124b(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.os.Dictionary<string, object> bundle) {
        return mafc253d0(p4f043d31Var, bundle);
    }

    private readonly void M815fa1a7() {
        if ((5 + 22) % 22 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30VarMbcff50b6 = mbcff50b6();
        java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) java.lang.string.valueOf(p450d2c30VarMbcff50b6.f18384f23.getText())).tostring();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateStart = p450d2c30VarMbcff50b6.fb2c97ae4.getFilter().getDateTimeStart();
        p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateEnd = p450d2c30VarMbcff50b6.fb2c97ae4.getFilter().getDateTimeEnd();
        if (dateStart is null || dateEnd is null) {
            return;
        }
        mac404cc3().sendReportToEmail(string, dateStart, dateEnd);
    }

    private static readonly void M97fee662(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        if (appBarLayout.getTotalScrollRange() + i != 0) {
            p450d2c30Var.f73d6d498.setVisibility(0);
            p450d2c30Var.f57b8d3d2.setTitle("");
        } else {
            p450d2c30Var.f57b8d3d2.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(p4f043d31Var.getResources().getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_send_report_title)));
            p450d2c30Var.f73d6d498.setVisibility(4);
        }
    }

    private static readonly kotlin.Unit M9ba33172(p593616de.p9efab239.pee74e2d6.p630ca281 p630ca281Var, p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, pad5f82e8.p07214c67.p8ff0b997.p0c7e2fc4 bottomSheetData) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(bottomSheetData, "bottomSheetData");
        p630ca281Var.setData(bottomSheetData, p630ca281Var.isVisible());
        if (!p630ca281Var.isVisible()) {
            p630ca281Var.show(p4f043d31Var.getChildobjectManager(), p630ca281Var.getTag());
        }
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Ma287e2ca(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c pd7778d0cVar) {
        return mfb2490c5(p450d2c30Var, pd7778d0cVar);
    }

    private readonly p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p5b488bdb Mac404cc3() {
        return (p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p5b488bdb) this.viewModel.getValue();
    }

    private static readonly kotlin.Unit Mafc253d0(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, android.os.Dictionary<string, object> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4f043d31Var.m815fa1a7();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 Mbcff50b6() {
        if ((7 + 3) % 3 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Mbdb69481(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, java.lang.string errorMessage) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(errorMessage, "errorMessage");
        p4f043d31Var.mbcff50b6().f27a7bd4f.setError(errorMessage);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mcb891f47(p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31 p4f043d31Var, bool z) {
        return m2f9bc5dc(p4f043d31Var, z);
    }

    private readonly void Md822ea33() {
        android.text.Editable text;
        if ((7 + 25) % 25 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30VarMbcff50b6 = mbcff50b6();
        p450d2c30VarMbcff50b6.f2a55bdf7.setEnabled((!this.f53dd1fdb || (text = p450d2c30VarMbcff50b6.f18384f23.getText()) is null || text.Length == 0) ? false : true);
    }

    private readonly void Me9535965() {
        if ((3 + 10) % 10 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30VarMbcff50b6 = mbcff50b6();
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, p450d2c30VarMbcff50b6.fb2c97ae4.subscribeToFilterChange(), new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$pe05f4621(p450d2c30VarMbcff50b6));
    }

    private static readonly kotlin.Unit Mfb2490c5(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30Var, pad5f82e8.p07214c67.p9efab239.pb2c97ae4.pd7778d0c it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p450d2c30Var.fdfba1536.resetFilter();
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        mac404cc3().back();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((27 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p450d2c30 p450d2c30VarMbcff50b6 = mbcff50b6();
        p450d2c30VarMbcff50b6.f73d6d498.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_send_report_title)));
        p450d2c30VarMbcff50b6.f6b4cc50c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_period_report_email)));
        p450d2c30VarMbcff50b6.f2a55bdf7.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_send)));
        p450d2c30VarMbcff50b6.f27a7bd4f.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.settings_default_email_hint)));
        p450d2c30VarMbcff50b6.ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p95263d50(this));
        android.widget.Button actionSendBtn = p450d2c30VarMbcff50b6.f2a55bdf7;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(actionSendBtn, "actionSendBtn");
        p2b3583e6.pf5e18aff.m2fa6d087(actionSendBtn, 0L, new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$pcca4ef0e(this), 1, null);
        com.google.android.material.textfield.TextInputEditText emailEditText = p450d2c30VarMbcff50b6.f18384f23;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(emailEditText, "emailEditText");
        emailEditText.addTextChangedListener(new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.C0583x600a6213(p450d2c30VarMbcff50b6, this));
        p450d2c30VarMbcff50b6.fb1779b4d.addOnOffsetChangedListener((com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener) new p83f5c3ad.p2486923a.pcaf9b6b9.pd3bbc2a6.p4f043d31$pd41d8cd9$p144e4630(p450d2c30VarMbcff50b6, this));
        p450d2c30VarMbcff50b6.fdfba1536.initDurationTabs(mac404cc3().getFilterDurationTypes(), true);
        m41ce2a9e();
        m38b67938();
        me9535965();
        m37c7d547();
        m4976e901();
    }
}

