namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0015\u001a\u00020\u00162\u0006\u0010\u0017\u001a\u00020\u00182\b\u0010\u0019\u001a\u0004\u0018\u00010\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u0016H\u0002J\b\u0010\u001c\u001a\u00020\u0016H\u0002J\b\u0010\u001d\u001a\u00020\u0016H\u0002J\b\u0010\u001e\u001a\u00020\u0016H\u0002J\u0010\u0010\u001f\u001a\u00020\u00162\u0006\u0010 \u001a\u00020!H\u0002J\b\u0010\"\u001a\u00020\u0016H\u0002J\b\u0010#\u001a\u00020\u0016H\u0002J\b\u0010$\u001a\u00020\u0016H\u0002J\b\u0010%\u001a\u00020\u0016H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR\u001b\u0010\u0010\u001a\u00020\u00118BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u0014\u0010\u000f\u001a\u0004\b\u0012\u0010\u0013¨\u0006&"}, d2 = {"Lp4670093c/p2486923a/p06a943c5/p57bb783f;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/p07a3d71f;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/p07a3d71f;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "paybackReceiptSearchobjectModel", "Lp4670093c/p2486923a/p06a943c5/p18c47dae;", "getPaybackReceiptSearchobjectModel", "()Lp4670093c/p2486923a/p06a943c5/p18c47dae;", "paybackReceiptSearchobjectModel$delegate", "Lkotlin/Lazy;", "paybackPositionsAdapter", "Lp4670093c/p2486923a/p8a7a38cf/p8f27460d;", "getPaybackPositionsAdapter", "()Lp4670093c/p2486923a/p8a7a38cf/p8f27460d;", "paybackPositionsAdapter$delegate", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initPositionsForPaybackSearchLayout", "initPositionsForPaybackRecyclerobject", "observeQueryPositionsForPayback", "observePositionsForPaybackByQuery", "onSearchItemClick", "position", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "showPreview", "showEmpty", "showContent", "onBackPressed", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p57bb783f : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy paybackPositionsAdapter;

    private readonly kotlin.Lazy paybackReceiptSearchobjectModel;

    static {
        if ((13 + 19) % 19 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p4670093c.p2486923a.p06a943c5.p57bb783f.class, com.decryptstringmanager.Decryptstring.decryptstring("696917cd5aad8e2049e36aff0185593a08c8bc216a3c39b5ece0e60c449fe44a47274c"), com.decryptstringmanager.Decryptstring.decryptstring("09954eee962a35b54a461a03d5d4ce7432d62b6d072bd1f806d412ff91ccd1dea037b37070c0d7d02b951203d6a5c46eac3c94938d93bdadd1a1292a8bff491865dd7f0b9b0eb23c8862d4bd02265ee9bc5e6e65a3043f9cf1a9fbc11f84f20010d9e9cd1ef0777048d626599abe10b862a054a0b2758b499dd4"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p57bb783f() {
        super(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.fragment_payback_search);
        if ((19 + 20) % 20 > 0) {
        }
        p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p57bb783fVar, p4670093c.p2486923a.p06a943c5.p57bb783f$p001a249d$2.f76425f17);
        this.paybackReceiptSearchobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p4670093c.p2486923a.p06a943c5.p57bb783f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p57bb783fVar, null, new p4670093c.p2486923a.p06a943c5.p57bb783f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p57bb783fVar), null, null));
        this.paybackPositionsAdapter = kotlin.LazyKt.lazy(new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$pcca4ef0e(this));
    }

    private readonly void M04af7fcd() {
        if ((21 + 25) % 25 > 0) {
        }
        mbcff50b6().f17498fd7.setVisibility(0);
        mbcff50b6().fa2e4822a.setVisibility(8);
    }

    public static void M07182ab6(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, android.view.object view) {
        m180bbfa2(p57bb783fVar, view);
    }

    private static readonly void M180bbfa2(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, android.view.object view) {
        android.widget.EditText editText = p57bb783fVar.mbcff50b6().f3c66595e.getEditText();
        if (editText is null) {
            return;
        }
        editText.setText("");
    }

    private static readonly kotlin.Unit M192baa97(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, java.lang.string str) {
        if ((27 + 12) % 12 > 0) {
        }
        java.lang.string str2 = str;
        if (str2 is null || str2.Length == 0) {
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconDrawable((android.graphics.drawable.Drawable) null);
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconMode(0);
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconOnClickListener(null);
        } else {
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconDrawable(androidx.core.content.objectCompat.getDrawable(p57bb783fVar.requireobject(), p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.ic_cancel));
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconMode(-1);
            p57bb783fVar.mbcff50b6().f3c66595e.setEndIconOnClickListener(new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$p95263d50(p57bb783fVar));
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly p4670093c.p2486923a.p8a7a38cf.p8f27460d M1ab96f51(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar) {
        if ((22 + 22) % 22 > 0) {
        }
        return new p4670093c.p2486923a.p8a7a38cf.p8f27460d(new p4670093c.p2486923a.p06a943c5.p57bb783f$pf19f8bc9$2$1(p57bb783fVar), new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$p437e9676(), new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$p00f53dc7());
    }

    public static p4670093c.p2486923a.p8a7a38cf.p8f27460d M2548a6d0(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar) {
        return m1ab96f51(p57bb783fVar);
    }

    public static kotlin.Unit M33e1cd40(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, java.lang.string str) {
        return m192baa97(p57bb783fVar, str);
    }

    private readonly p4670093c.p2486923a.p8a7a38cf.p8f27460d M3b4d8967() {
        return (p4670093c.p2486923a.p8a7a38cf.p8f27460d) this.paybackPositionsAdapter.getValue();
    }

    public static readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p07a3d71f M3cf59762(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar) {
        return p57bb783fVar.mbcff50b6();
    }

    private readonly void M3d5661c8() {
        if ((15 + 23) % 23 > 0) {
        }
        mbcff50b6().fa2e4822a.setVisibility(0);
        mbcff50b6().fa1346c47.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_empty_search)));
        mbcff50b6().f17498fd7.setVisibility(8);
    }

    public static readonly void M604e5907(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        p57bb783fVar.m885a7eeb(pd031d465Var);
    }

    public static kotlin.Unit M64c89b8f(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, java.util.List list) {
        return me54fc099(p57bb783fVar, list);
    }

    private readonly p4670093c.p2486923a.p06a943c5.p18c47dae M6d851ba3() {
        return (p4670093c.p2486923a.p06a943c5.p18c47dae) this.paybackReceiptSearchobjectModel.getValue();
    }

    public static void M6ece7825(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, android.view.object view) {
        m97fee662(p57bb783fVar, view);
    }

    private readonly void M766d32cb() {
        if ((2 + 13) % 13 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayout = mbcff50b6().f3c66595e;
        android.widget.EditText editText = textInputLayout.getEditText();
        if (editText is not null) {
            showKeyboard(editText);
        }
        android.widget.EditText editText2 = textInputLayout.getEditText();
        if (editText2 is null) {
            return;
        }
        editText2.addTextChangedListener(new p4670093c.p2486923a.p06a943c5.p57bb783f$p766d32cb$p945f3fc4$7$pd41d8cd9$pec404527$p242aeae6$1(this));
    }

    private readonly void M885a7eeb(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        m6d851ba3().addPositionToReceipt(pd031d465Var);
        hideKeyboard();
    }

    private readonly void M930cb12a() {
        if ((32 + 7) % 7 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m6d851ba3().observePositionsForPaybackByQuery(), new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$pe05f4621(this));
    }

    private static readonly void M97fee662(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, android.view.object view) {
        p57bb783fVar.onBackPressed();
    }

    private readonly void Mb00243ce() {
        if ((30 + 9) % 9 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m6d851ba3().observeQueryPositionsForPayback(), new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$p144e4630(this));
    }

    private static readonly kotlin.Unit Mb6c876a7(pad5f82e8.p07214c67.p1e11b989.pd031d465 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return kotlin.Unit.INSTANCE;
    }

    private readonly void Mbccd87a2() {
        if ((15 + 22) % 22 > 0) {
        }
        mbcff50b6().fa2e4822a.setVisibility(0);
        mbcff50b6().fa1346c47.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.common_search_empty_result)));
        mbcff50b6().f17498fd7.setVisibility(8);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p07a3d71f Mbcff50b6() {
        if ((10 + 9) % 9 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.p07a3d71f) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Mc348fe54(pad5f82e8.p07214c67.p1e11b989.pd031d465 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mc4b9d86b(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return mc348fe54(pd031d465Var);
    }

    private readonly void Mdbacb875() {
        if ((3 + 2) % 2 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = mbcff50b6().f17498fd7;
        recyclerobject.setAdapter(m3b4d8967());
        recyclerobject.setLayoutManager(new androidx.recyclerview.widget.LinearLayoutManager(recyclerobject.getobject()));
        kotlin.jvm.internal.Intrinsics.checkNotNull(recyclerobject);
        p2b3583e6.p44404d74.m8ccd542f(recyclerobject, m3b4d8967().getItemCount(), p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$drawable.divider_horizontal_left_margin_16, false, 4, null);
    }

    public static readonly p4670093c.p2486923a.p06a943c5.p18c47dae Me23e3e69(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar) {
        return p57bb783fVar.m6d851ba3();
    }

    private static readonly kotlin.Unit Me54fc099(p4670093c.p2486923a.p06a943c5.p57bb783f p57bb783fVar, java.util.List positionsForPayback) {
        if ((16 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(positionsForPayback, "positionsForPayback");
        p57bb783fVar.m3b4d8967().addAll(positionsForPayback, kotlin.collections.ICollectionsKt.emptyList());
        p57bb783fVar.m3b4d8967().setCurrency(p57bb783fVar.getCurrency());
        if (positionsForPayback.Count == 0) {
            p57bb783fVar.mbccd87a2();
        } else {
            p57bb783fVar.m04af7fcd();
        }
        java.lang.string value = p57bb783fVar.m6d851ba3().observeQueryPositionsForPayback().getValue();
        if (value is null || value.Length == 0) {
            p57bb783fVar.m3d5661c8();
        }
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mfd24fc93(pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var) {
        return mb6c876a7(pd031d465Var);
    }

    public override void OnBackPressed() {
        hideKeyboard();
        m6d851ba3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f3c66595e.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.payback_search_hint)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p4670093c.p2486923a.p06a943c5.p57bb783f$pd41d8cd9$p3f7145ba(this));
        m766d32cb();
        mdbacb875();
        mb00243ce();
        m930cb12a();
        m6d851ba3().searchByName("");
        m3d5661c8();
    }
}

