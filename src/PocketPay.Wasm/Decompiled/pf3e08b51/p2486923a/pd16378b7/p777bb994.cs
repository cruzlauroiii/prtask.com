namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\b\u0010\u001b\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001c"}, d2 = {"Lpf3e08b51/p2486923a/pd16378b7/p777bb994;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pf3e08b51/p86ccec3d/pec341acd/p8d183427;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pf3e08b51/p86ccec3d/pec341acd/p8d183427;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "reviewAppobjectModel", "Lpf3e08b51/p2486923a/pd16378b7/pd5481c88;", "getReviewAppobjectModel", "()Lpf3e08b51/p2486923a/pd16378b7/pd5481c88;", "reviewAppobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initMessageInput", "validate", "observeReviewApp", "showLoading", "showContent", "onBackPressed", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p777bb994 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy reviewAppobjectModel;

    static {
        if ((28 + 22) % 22 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pf3e08b51.p2486923a.pd16378b7.p777bb994.class, com.decryptstringmanager.Decryptstring.decryptstring("9e8ca376c5de8008d0b00382874376fcee762928f708e59a59b79d1dc65a3b98fc9a8b"), com.decryptstringmanager.Decryptstring.decryptstring("8ea16674e98fb7aafb6b672fd76c6bca18e2493693089308508f8b665b38a195e2880146c065cf2d8ffbe7819476f2bfcb1c4014cbdd130465af719d406339ad2c82581cb925d4504ac3d308a2e4c7b470c94bd9007dfc4c275c1e156f5c33e5028e0d8c3aae8010893ce92ca7039ef888bd4026fc686b7481ad1289dc5c78339b"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p777bb994() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$layout.fragment_review_app);
        if ((14 + 27) % 27 > 0) {
        }
        pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p777bb994Var, pf3e08b51.p2486923a.pd16378b7.p777bb994$p001a249d$2.f76425f17);
        this.reviewAppobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pf3e08b51.p2486923a.pd16378b7.p777bb994$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p777bb994Var, null, new pf3e08b51.p2486923a.pd16378b7.p777bb994$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p777bb994Var), null, null));
    }

    private readonly void M04af7fcd() {
        mbcff50b6().fa14fa216.getRoot().setVisibility(8);
    }

    public static readonly void M2ce8f1c1(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var) {
        p777bb994Var.mf9ab0545();
    }

    public static kotlin.Unit M2eab102b(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return mba821759(p777bb994Var, pa4ecfc70Var);
    }

    private static readonly kotlin.Unit M30f6522b(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pf3e08b51.p2486923a.pd16378b7.pd5481c88 pd5481c88VarMcb9c5ad2 = p777bb994Var.mcb9c5ad2();
        android.widget.EditText editText = p777bb994Var.mbcff50b6().f681a6982.getEditText();
        pd5481c88VarMcb9c5ad2.sendFeedback(java.lang.string.valueOf(editText is null ? null : editText.getText()));
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M70daf3a9() {
        mbcff50b6().fa14fa216.getRoot().setVisibility(0);
    }

    public static void M8a78d05c(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, android.view.object view) {
        m9ba4fe43(p777bb994Var, view);
    }

    private readonly void M8be9d8c5() {
        if ((18 + 3) % 3 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mcb9c5ad2().getAppReviewStatus(), new pf3e08b51.p2486923a.pd16378b7.p777bb994$pd41d8cd9$p144e4630(this));
    }

    private static readonly void M9ba4fe43(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, android.view.object view) {
        p777bb994Var.onBackPressed();
    }

    private static readonly kotlin.Unit Mba821759(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, pad5f82e8.p07214c67.pa4ecfc70 event) {
        if ((32 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = pf3e08b51.p2486923a.pd16378b7.p777bb994$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i == 1) {
            p777bb994Var.m70daf3a9();
        } else if (i == 2) {
            pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var2 = p777bb994Var;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(p777bb994Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.review_app_success));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
            p2b3583e6.pa2559025.m31049b74(p777bb994Var2, new pad5f82e8.p07214c67.pe907423b.p325296ab(strDecryptstring), null, null, null, 0, 30, null);
            p777bb994Var.onBackPressed();
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p777bb994Var.m04af7fcd();
            pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var3 = p777bb994Var;
            java.lang.string strDecryptstring2 = com.decryptstringmanager.Decryptstring.decryptstring(p777bb994Var.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.review_app_error));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring2, "getstring(...)");
            p2b3583e6.pa2559025.m31049b74(p777bb994Var3, new pad5f82e8.p07214c67.pe907423b.p89a5ff7f(strDecryptstring2), null, null, null, 0, 30, null);
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.pec341acd.p8d183427 Mbcff50b6() {
        if ((9 + 6) % 6 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.pec341acd.p8d183427) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static kotlin.Unit Mc6c00b89(pf3e08b51.p2486923a.pd16378b7.p777bb994 p777bb994Var, android.view.object view) {
        return m30f6522b(p777bb994Var, view);
    }

    private readonly pf3e08b51.p2486923a.pd16378b7.pd5481c88 Mcb9c5ad2() {
        return (pf3e08b51.p2486923a.pd16378b7.pd5481c88) this.reviewAppobjectModel.getValue();
    }

    private readonly void Mf44f150c() {
        if ((19 + 17) % 17 > 0) {
        }
        android.widget.EditText editText = mbcff50b6().f681a6982.getEditText();
        if (editText is null) {
            return;
        }
        showKeyboard(editText);
        editText.addTextChangedListener(new pf3e08b51.p2486923a.pd16378b7.C0587x77fde131(this));
    }

    private readonly void Mf9ab0545() {
        android.widget.Button button = mbcff50b6().fa26cff5c;
        android.widget.EditText editText = mbcff50b6().f681a6982.getEditText();
        button.setEnabled(kotlin.text.stringsKt.trim((java.lang.CharSequence) java.lang.string.valueOf(editText is null ? null : editText.getText())).tostring().Length > 0);
    }

    public override void OnBackPressed() {
        hideKeyboard();
        mcb9c5ad2().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((27 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.review_app_title)));
        mbcff50b6().fb8f8dcb3.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.review_app_description)));
        mbcff50b6().f681a6982.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.review_app_message)));
        mbcff50b6().fa26cff5c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.action_send)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new pf3e08b51.p2486923a.pd16378b7.p777bb994$pd41d8cd9$p95263d50(this));
        mf44f150c();
        android.widget.Button sendButton = mbcff50b6().fa26cff5c;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sendButton, "sendButton");
        p2b3583e6.pf5e18aff.m2fa6d087(sendButton, 0L, new pf3e08b51.p2486923a.pd16378b7.p777bb994$pd41d8cd9$pcca4ef0e(this), 1, null);
        m8be9d8c5();
    }
}

