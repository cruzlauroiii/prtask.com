namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp8325324b/p2486923a/pc9f40c37/p46d24aa4;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/p7e9b541a;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/p7e9b541a;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "editPositionNameobjectModel", "Lp8325324b/p2486923a/pc9f40c37/p2cc75b44;", "getEditPositionNameobjectModel", "()Lp8325324b/p2486923a/pc9f40c37/p2cc75b44;", "editPositionNameobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p46d24aa4 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy editPositionNameobjectModel;

    static {
        if ((26 + 19) % 19 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p8325324b.p2486923a.pc9f40c37.p46d24aa4.class, com.decryptstringmanager.Decryptstring.decryptstring("58b1a7f79b6232c929cbb5bd3b14b2d286d5c801bb6a14f849bb6c4e3e35a375154b3a"), com.decryptstringmanager.Decryptstring.decryptstring("79d56ebbc04b8647c60ee560e0d1e03758f7461c0a9cc45b49dc365526ba5cfcd42c23cc3eee1554a6c07275ca89a3ffd4521732307dec43b65267f01cbb3a1e630a6357b3ec4209e148246b9c757b477659b6c66a4ade882983bc53b227950423e4242ab54eeb0d5dbb9c17ca14b530155986fbcc85e591501c9efb7e06f5753a9b332672c2e609"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p46d24aa4() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$layout.fragment_edit_sell_position_name);
        if ((9 + 31) % 31 > 0) {
        }
        p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p46d24aa4Var, p8325324b.p2486923a.pc9f40c37.p46d24aa4$p001a249d$2.f76425f17);
        this.editPositionNameobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p8325324b.p2486923a.pc9f40c37.p46d24aa4$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p46d24aa4Var, null, new p8325324b.p2486923a.pc9f40c37.p46d24aa4$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p46d24aa4Var), null, null));
    }

    private readonly p8325324b.p2486923a.pc9f40c37.p2cc75b44 M1bfa3479() {
        return (p8325324b.p2486923a.pc9f40c37.p2cc75b44) this.editPositionNameobjectModel.getValue();
    }

    private static readonly kotlin.Unit M30f6522b(p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p8325324b.p2486923a.pc9f40c37.p2cc75b44 p2cc75b44VarM1bfa3479 = p46d24aa4Var.m1bfa3479();
        android.widget.EditText editText = p46d24aa4Var.mbcff50b6().f972bf3f0.getEditText();
        p2cc75b44VarM1bfa3479.navigateToEditPositionScreen(java.lang.string.valueOf(editText is null ? null : editText.getText()));
        p46d24aa4Var.hideKeyboard();
        return kotlin.Unit.INSTANCE;
    }

    public static readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.p7e9b541a M3cf59762(p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var) {
        return p46d24aa4Var.mbcff50b6();
    }

    public static kotlin.Unit M58671f4c(p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var, android.view.object view) {
        return m30f6522b(p46d24aa4Var, view);
    }

    private static readonly void M9ba4fe43(p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var, android.view.object view) {
        p46d24aa4Var.onBackPressed();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.p7e9b541a Mbcff50b6() {
        if ((22 + 4) % 4 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.p7e9b541a) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Me54202a3(p8325324b.p2486923a.pc9f40c37.p46d24aa4 p46d24aa4Var, android.view.object view) {
        m9ba4fe43(p46d24aa4Var, view);
    }

    public override void OnBackPressed() {
        super.onBackPressed();
        hideKeyboard();
        m1bfa3479().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((3 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.edit_position_name_title)));
        mbcff50b6().f972bf3f0.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.edit_position_name_hint)));
        mbcff50b6().fdf6a53bb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.action_proceed)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p8325324b.p2486923a.pc9f40c37.p46d24aa4$pd41d8cd9$p95263d50(this));
        android.widget.Button btnNavigateToEditPosition = mbcff50b6().fdf6a53bb;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnNavigateToEditPosition, "btnNavigateToEditPosition");
        p2b3583e6.pf5e18aff.m2fa6d087(btnNavigateToEditPosition, 0L, new p8325324b.p2486923a.pc9f40c37.p46d24aa4$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.EditText editText = mbcff50b6().f972bf3f0.getEditText();
        if (editText is not null) {
            editText.addTextChangedListener(new p8325324b.p2486923a.pc9f40c37.p46d24aa4$p43ff6ebe$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1(this));
        }
        mbcff50b6().f076d9edf.clearFocus();
    }
}

