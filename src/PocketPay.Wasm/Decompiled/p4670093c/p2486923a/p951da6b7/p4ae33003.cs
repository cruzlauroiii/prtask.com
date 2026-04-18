namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00182\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u0016H\u0002J\b\u0010\u001c\u001a\u00020\u0016H\u0002J\b\u0010\u001d\u001a\u00020\u0016H\u0002J\b\u0010\u001e\u001a\u00020\u0016H\u0002J\b\u0010\u001f\u001a\u00020\u0016H\u0002J\b\u0010 \u001a\u00020\u0016H\u0002J\b\u0010!\u001a\u00020\u0016H\u0002J\b\u0010\"\u001a\u00020\u0016H\u0002J\b\u0010#\u001a\u00020\u0016H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR\u001b\u0010\u0010\u001a\u00020\u00118BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u0014\u0010\u000f\u001a\u0004\b\u0012\u0010\u0013¨\u0006$"}, d2 = {"Lp4670093c/p2486923a/p951da6b7/p4ae33003;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pb2e56f3b;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pb2e56f3b;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "paybackReceiptDetailobjectModel", "Lp4670093c/p2486923a/p951da6b7/p346d0a2c;", "getPaybackReceiptDetailobjectModel", "()Lp4670093c/p2486923a/p951da6b7/p346d0a2c;", "paybackReceiptDetailobjectModel$delegate", "Lkotlin/Lazy;", "paybackPositionsAdapter", "Lp4670093c/p2486923a/p8a7a38cf/p8f27460d;", "getPaybackPositionsAdapter", "()Lp4670093c/p2486923a/p8a7a38cf/p8f27460d;", "paybackPositionsAdapter$delegate", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "setupAppbar", "initPaybackPositionsRecyclerobject", "observeToolbarReceiptNumber", "observeToolbarDateTime", "observePositionsForPayback", "collectShowHasComboTophPaymentDialogState", "observeSnackBarStatus", "showHasComboTophPaymentBSDialog", "onBackPressed", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4ae33003 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy paybackPositionsAdapter;

    private readonly kotlin.Lazy paybackReceiptDetailobjectModel;

    static {
        if ((15 + 9) % 9 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p4670093c.p2486923a.p951da6b7.p4ae33003.class, com.decryptstringmanager.Decryptstring.decryptstring("df473c73f884bbe8a277999417ae5434a4a31e325549bb0dd44b2084aadb053280f9aa"), com.decryptstringmanager.Decryptstring.decryptstring("5e203394ab3eaa76b4e7f60bc706e1b92e69a7df464dccaef35146b0cdfa9ca28e2cafdc506f7d315e41d27083a51164a09c4aa26142306cc8c6357fe563b7aa46d10e33996863f19d45abca5ab3c547c1981815642e9da1fc9cfbf3996944813a70f13c775b1cb28ef9f9c1bbeede8fac8f4ef149b74c892a7c53"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p4ae33003() {
        super(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.fragment_payback_receipt);
        if ((19 + 23) % 23 > 0) {
        }
        p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p4ae33003Var, p4670093c.p2486923a.p951da6b7.p4ae33003$p001a249d$2.f76425f17);
        this.paybackReceiptDetailobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p4670093c.p2486923a.p951da6b7.p4ae33003$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p4ae33003Var, null, new p4670093c.p2486923a.p951da6b7.p4ae33003$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p4ae33003Var), null, null));
        this.paybackPositionsAdapter = kotlin.LazyKt.lazy(new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p437e9676(this));
    }

    private static readonly kotlin.Unit M021c6a2c(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3e6f9f3a().openSearchScreen();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M08ce50b3(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, int i) {
        if ((6 + 17) % 17 > 0) {
        }
        android.widget.Textobject textobject = p4ae33003Var.mbcff50b6().fef3cba7c;
        kotlin.jvm.internal.stringCompanionobject stringCompanionobject = kotlin.jvm.internal.stringCompanionobject.INSTANCE;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(p4ae33003Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_receipt_template));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        java.lang.string str = java.lang.string.format(strDecryptstring, java.util.Arrays.copyOf(new java.lang.object[]{java.lang.int.valueOf(i)}, 1));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str, "format(...)");
        textobject.setText(str);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M0c532d86(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.object view) {
        return m021c6a2c(p4ae33003Var, view);
    }

    public static void M13653b78(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.object view) {
        mbe03528e(p4ae33003Var, view);
    }

    private static readonly p4670093c.p2486923a.p8a7a38cf.p8f27460d M1ab96f51(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var) {
        if ((19 + 29) % 29 > 0) {
        }
        return new p4670093c.p2486923a.p8a7a38cf.p8f27460d(new p4670093c.p2486923a.p951da6b7.p4ae33003$pf19f8bc9$2$1(p4ae33003Var.m3e6f9f3a()), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p95263d50(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$pe05f4621());
    }

    private readonly void M22dc5cb6() {
        if ((21 + 32) % 32 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m3e6f9f3a().observeToolbarDateTime(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$pc1590ac5(this));
    }

    private static readonly kotlin.Unit M244bdd0c(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.os.Dictionary<string, object> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3e6f9f3a().openTophInfoScreen();
        return kotlin.Unit.INSTANCE;
    }

    public static bool M27cb1cf5(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.MenuItem menuItem) {
        return mc441adee(p4ae33003Var, menuItem);
    }

    public static kotlin.Unit M34bd67c7(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, kotlin.Unit unit) {
        return mce5cc2a9(p4ae33003Var, unit);
    }

    private readonly p4670093c.p2486923a.p8a7a38cf.p8f27460d M3b4d8967() {
        return (p4670093c.p2486923a.p8a7a38cf.p8f27460d) this.paybackPositionsAdapter.getValue();
    }

    public static kotlin.Unit M3c1a4b92(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, java.util.List list) {
        return md6facbc4(p4ae33003Var, list);
    }

    private readonly p4670093c.p2486923a.p951da6b7.p346d0a2c M3e6f9f3a() {
        return (p4670093c.p2486923a.p951da6b7.p346d0a2c) this.paybackReceiptDetailobjectModel.getValue();
    }

    public static kotlin.Unit M5334a0de(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.os.Dictionary<string, object> bundle) {
        return m244bdd0c(p4ae33003Var, bundle);
    }

    private readonly void M54dc7bf1() {
        if ((2 + 2) % 2 > 0) {
        }
        p593616de.p9efab239.pee74e2d6.pc108e6f9 pc108e6f9VarMc5fccbf1 = p593616de.p9efab239.pee74e2d6.pc108e6f9$p910eef8c.mc5fccbf1(p593616de.p9efab239.pee74e2d6.pc108e6f9.f910eef8c, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.has_combo_toph_payment_bs_title)), null, null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.has_combo_toph_payment_bs_message)), com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.has_combo_toph_payment_bs_secondary_message)), com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.has_combo_toph_payment_bs_reconciliation_results)), com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.has_combo_toph_payment_bs_payback_full_receipt)), com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.action_cancellation)), null, null, null, false, null, null, 16134, null);
        p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var = this;
        androidx.fragment.app.objectManager childobjectManager = getChildobjectManager();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(childobjectManager, "getChildobjectManager(...)");
        p593616de.p9efab239.pfafca1ef.mf5d59114(p4ae33003Var, childobjectManager, com.decryptstringmanager.Decryptstring.decryptstring("2ddf733f6782ab8dc901cc7bfe787c84f1ad45c814c46b75acf1533ea408f0ce511b2fb6e59ef9d2da75e2f831"), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p2dcb4222(this));
        androidx.fragment.app.objectManager childobjectManager2 = getChildobjectManager();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(childobjectManager2, "getChildobjectManager(...)");
        p593616de.p9efab239.pfafca1ef.mf5d59114(p4ae33003Var, childobjectManager2, com.decryptstringmanager.Decryptstring.decryptstring("1583d5ca350f1d705ed5f73d66d5f6aa3d85856b8a063f131c7edf11893711fd1ef29b5fb991b8ada149e60351199bf9cf890fe5905cfe"), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p5e679a10(this));
        pc108e6f9VarMc5fccbf1.show(getChildobjectManager(), pc108e6f9VarMc5fccbf1.getTag());
    }

    public static kotlin.Unit M57d42cac(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, int i) {
        return m08ce50b3(p4ae33003Var, i);
    }

    private readonly void M6e02fd51() {
        if ((30 + 32) % 32 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = mbcff50b6().f17498fd7;
        recyclerobject.setLayoutManager(new androidx.recyclerview.widget.LinearLayoutManager(recyclerobject.getobject()));
        recyclerobject.setAdapter(m3b4d8967());
        kotlin.jvm.internal.Intrinsics.checkNotNull(recyclerobject);
        p2b3583e6.p44404d74.m8ccd542f(recyclerobject, m3b4d8967().getItemCount(), p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.divider_horizontal_left_margin_16, false, 4, null);
    }

    public static void M6ed7a1ae(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        me8eb13d5(p4ae33003Var, appBarLayout, i);
    }

    private static readonly kotlin.Unit M77ed29b9(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, java.lang.string str) {
        if ((16 + 23) % 23 > 0) {
        }
        p4ae33003Var.mbcff50b6().fee737ada.setVisibility(8);
        if (str is not null) {
            p4ae33003Var.mbcff50b6().fee737ada.setVisibility(0);
            p4ae33003Var.mbcff50b6().fee737ada.setText(str);
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M79207988(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 snackBarData) {
        if ((30 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(snackBarData, "snackBarData");
        p2b3583e6.pa2559025.m31049b74(p4ae33003Var, snackBarData, null, null, null, 0, 30, null);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M79a4ca86(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.os.Dictionary<string, object> bundle) {
        return m9751cf67(p4ae33003Var, bundle);
    }

    public static kotlin.Unit M7a75a710(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return mc348fe54(pd031d465Var);
    }

    private readonly void M8dafc978() {
        if ((13 + 25) % 25 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, m3e6f9f3a().getShowHasComboTophPaymentDialogState(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$pf62cc59c(this));
    }

    private static readonly kotlin.Unit M9751cf67(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.os.Dictionary<string, object> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3e6f9f3a().addAllPositionsForPaybackToReceipt();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M9dde3295() {
        if ((1 + 3) % 3 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m3e6f9f3a().getSnackBarStatus(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p00f53dc7(this));
    }

    public static kotlin.Unit Ma2da80cd(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, java.lang.string str) {
        return m77ed29b9(p4ae33003Var, str);
    }

    public static bool Ma84af597(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.MenuItem menuItem) {
        return mbe3acc61(p4ae33003Var, menuItem);
    }

    private static readonly kotlin.Unit Mb6c876a7(pad5f82e8.p07214c67.p1e11b989.pd031d465 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Mbb2e0614() {
        if ((2 + 31) % 31 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m3e6f9f3a().observePositionsForPayback(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p19211fb6(this));
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pb2e56f3b Mbcff50b6() {
        if ((12 + 4) % 4 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pb2e56f3b) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly void Mbe03528e(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.object view) {
        p4ae33003Var.onBackPressed();
    }

    private static readonly bool Mbe3acc61(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.MenuItem it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3e6f9f3a().openSearchScreen();
        return true;
    }

    public static p4670093c.p2486923a.p8a7a38cf.p8f27460d Mc1b4c785(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var) {
        return m1ab96f51(p4ae33003Var);
    }

    private static readonly kotlin.Unit Mc348fe54(pad5f82e8.p07214c67.p1e11b989.pd031d465 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return kotlin.Unit.INSTANCE;
    }

    private static readonly bool Mc441adee(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, android.view.MenuItem it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3e6f9f3a().addAllPositionsForPaybackToReceipt();
        return true;
    }

    public static kotlin.Unit Mc6d17b3f(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 pb3f3bb37Var) {
        return m79207988(p4ae33003Var, pb3f3bb37Var);
    }

    private readonly void Mca139bdb() {
        if ((1 + 29) % 29 > 0) {
        }
        mbcff50b6().fece3fff1.addOnOffsetChangedListener((com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener) new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p4b82c4cb(this));
    }

    private static readonly kotlin.Unit Mce5cc2a9(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, kotlin.Unit it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m54dc7bf1();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Md2c2b6ac() {
        if ((8 + 15) % 15 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m3e6f9f3a().observeToolbarReceiptNumber(), new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p3f7145ba(this));
    }

    private static readonly kotlin.Unit Md6facbc4(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, java.util.List it) {
        if ((7 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4ae33003Var.m3b4d8967().addAll(it, kotlin.collections.ICollectionsKt.emptyList());
        p4ae33003Var.m3b4d8967().setCurrency(p4ae33003Var.getCurrency());
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mdd45eb0d(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return mb6c876a7(pd031d465Var);
    }

    private static readonly void Me8eb13d5(p4670093c.p2486923a.p951da6b7.p4ae33003 p4ae33003Var, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        p4ae33003Var.mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.action_search).setVisible(appBarLayout.getHeight() + i <= 0);
    }

    public override void OnBackPressed() {
        m3e6f9f3a().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((26 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f173b212b.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_search_main_hint)));
        androidx.appcompat.widget.Toolbar toolbar = mbcff50b6().ff50b3c2a;
        android.view.object actionobject = mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.action_search).getActionobject();
        android.widget.Textobject textobject = actionobject is null ? null : (android.widget.Textobject) actionobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.tv_menu_search);
        android.view.object actionobject2 = mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.all_to_receipt).getActionobject();
        android.widget.Textobject textobject2 = actionobject2 is not null ? (android.widget.Textobject) actionobject2.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.tv_all_in_receipt) : null;
        if (textobject is not null) {
            textobject.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.search_menu)));
        }
        if (textobject2 is not null) {
            textobject2.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_all_to_receipt)));
        }
        toolbar.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.action_search).setOnMenuItemClickListener(new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$pac8d69d9(this));
        toolbar.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$id.all_to_receipt).setOnMenuItemClickListener(new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p25e76ab7(this));
        toolbar.setNavigationOnClickListener(new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$pcca4ef0e(this));
        mca139bdb();
        m6e02fd51();
        md2c2b6ac();
        m22dc5cb6();
        mbb2e0614();
        m8dafc978();
        m9dde3295();
        android.widget.Textobject tvSearch = mbcff50b6().f173b212b;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(tvSearch, "tvSearch");
        p2b3583e6.pf5e18aff.m2fa6d087(tvSearch, 0L, new p4670093c.p2486923a.p951da6b7.p4ae33003$pd41d8cd9$p144e4630(this), 1, null);
        m3e6f9f3a().getPaybackReceipt();
    }
}

