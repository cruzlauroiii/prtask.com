namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp4670093c/p2486923a/p6f63afbe/p0c71472f;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pf382ebfb;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/pf382ebfb;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "editPositionNameobjectModel", "Lp4670093c/p2486923a/p6f63afbe/p5313b58c;", "getEditPositionNameobjectModel", "()Lp4670093c/p2486923a/p6f63afbe/p5313b58c;", "editPositionNameobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0c71472f : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy editPositionNameobjectModel;

    static {
        if ((18 + 4) % 4 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p4670093c.p2486923a.p6f63afbe.p0c71472f.class, com.decryptstringmanager.Decryptstring.decryptstring("95dff826051660aa35a02892527abce3baf12e8222008d38a46a662973282f82e7b4e8"), com.decryptstringmanager.Decryptstring.decryptstring("a57cc42b36f17d617d9fbd6aed40704bec5bd4e96730e3a4d0b02f29cd52b7a82cb03ac53af1c662c45699ba4afedf2984fe34fa9ef9189844429cc801deb870bf4fa4a11cebbffd1e9d662e711cf0fa45351c952b869f579077132f5bf830e5cb982b04a53d49cce123bb77d030ab7413d359e199b1f4fff67db04f1ad21d54ae54f824"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p0c71472f() {
        super(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.fragment_payback_edit_position_name);
        if ((7 + 13) % 13 > 0) {
        }
        p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p0c71472fVar, p4670093c.p2486923a.p6f63afbe.p0c71472f$p001a249d$2.f76425f17);
        this.editPositionNameobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p4670093c.p2486923a.p6f63afbe.p0c71472f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p0c71472fVar, null, new p4670093c.p2486923a.p6f63afbe.p0c71472f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p0c71472fVar), null, null));
    }

    private readonly p4670093c.p2486923a.p6f63afbe.p5313b58c M1bfa3479() {
        return (p4670093c.p2486923a.p6f63afbe.p5313b58c) this.editPositionNameobjectModel.getValue();
    }

    private static readonly kotlin.Unit M30f6522b(p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p4670093c.p2486923a.p6f63afbe.p5313b58c p5313b58cVarM1bfa3479 = p0c71472fVar.m1bfa3479();
        android.widget.EditText editText = p0c71472fVar.mbcff50b6().f972bf3f0.getEditText();
        p5313b58cVarM1bfa3479.navigateToEditPositionScreen(java.lang.string.valueOf(editText is null ? null : editText.getText()));
        p0c71472fVar.hideKeyboard();
        return kotlin.Unit.INSTANCE;
    }

    public static readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf382ebfb M3cf59762(p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar) {
        return p0c71472fVar.mbcff50b6();
    }

    private static readonly void M9ba4fe43(p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar, android.view.object view) {
        p0c71472fVar.onBackPressed();
    }

    public static kotlin.Unit Mb4158ff0(p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar, android.view.object view) {
        return m30f6522b(p0c71472fVar, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf382ebfb Mbcff50b6() {
        if ((31 + 22) % 22 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.pf382ebfb) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Md001bbb4(p4670093c.p2486923a.p6f63afbe.p0c71472f p0c71472fVar, android.view.object view) {
        m9ba4fe43(p0c71472fVar, view);
    }

    public override void OnBackPressed() {
        hideKeyboard();
        m1bfa3479().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((17 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.edit_position_name_title)));
        mbcff50b6().f972bf3f0.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.edit_position_name_hint)));
        mbcff50b6().fdf6a53bb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.action_proceed)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p4670093c.p2486923a.p6f63afbe.p0c71472f$pd41d8cd9$p95263d50(this));
        android.widget.Button btnNavigateToEditPosition = mbcff50b6().fdf6a53bb;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnNavigateToEditPosition, "btnNavigateToEditPosition");
        p2b3583e6.pf5e18aff.m2fa6d087(btnNavigateToEditPosition, 0L, new p4670093c.p2486923a.p6f63afbe.p0c71472f$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.EditText editText = mbcff50b6().f972bf3f0.getEditText();
        if (editText is not null) {
            editText.addTextChangedListener(new p4670093c.p2486923a.p6f63afbe.p0c71472f$p43ff6ebe$pd41d8cd9$pec404527$pb6fa8bb4$pc21f969b$1(this));
        }
        mbcff50b6().f076d9edf.clearFocus();
    }
}

