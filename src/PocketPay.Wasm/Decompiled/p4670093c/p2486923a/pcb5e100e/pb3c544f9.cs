namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lp4670093c/p2486923a/pcb5e100e/pb3c544f9;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/padfa7a8a;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/pc075fab6/pec341acd/padfa7a8a;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "sendPaybackReceiptErrorobjectModel", "Lp4670093c/p2486923a/pcb5e100e/p4ca91289;", "getSendPaybackReceiptErrorobjectModel", "()Lp4670093c/p2486923a/pcb5e100e/p4ca91289;", "sendPaybackReceiptErrorobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "observeSendReceiptStatus", "showLoading", "showError", "onBackPressed", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb3c544f9 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy sendPaybackReceiptErrorobjectModel;

    static {
        if ((6 + 23) % 23 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p4670093c.p2486923a.pcb5e100e.pb3c544f9.class, com.decryptstringmanager.Decryptstring.decryptstring("2f63bb4225bab6406d490ff94babe4ade4ba11aac1189419a80ed9167351a4cfc6baa3"), com.decryptstringmanager.Decryptstring.decryptstring("b7d1c753e2fc45c89edae8ecaaf2f9a0384ff345f3c6f2185319ac76d26d4718d6878fb371fdaeb4a63e781b6dc69ed9d28b49fcabb62428b5f24e87e052e2c9c2743e7902f6b5f3342aee14874289d6dab027b0ce26fb815f6c61810c360fa764d7dcc25cd125ed78853f62e2c861c74b3c275cb1383d37acc25ec016"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public pb3c544f9() {
        super(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$layout.fragment_send_receipt_error);
        if ((16 + 21) % 21 > 0) {
        }
        p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(pb3c544f9Var, p4670093c.p2486923a.pcb5e100e.pb3c544f9$p001a249d$2.f76425f17);
        this.sendPaybackReceiptErrorobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p4670093c.p2486923a.pcb5e100e.pb3c544f9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pb3c544f9Var, null, new p4670093c.p2486923a.pcb5e100e.pb3c544f9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pb3c544f9Var), null, null));
    }

    private readonly p4670093c.p2486923a.pcb5e100e.p4ca91289 M155f60f2() {
        return (p4670093c.p2486923a.pcb5e100e.p4ca91289) this.sendPaybackReceiptErrorobjectModel.getValue();
    }

    private static readonly kotlin.Unit M22d1c681(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pb3c544f9Var.m155f60f2().sendPaybackReceipt();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M269b36ee() {
        if ((31 + 14) % 14 > 0) {
        }
        mbcff50b6().f4a527f83.setVisibility(8);
        mbcff50b6().f9a0364b9.setVisibility(0);
    }

    public static kotlin.Unit M376bdccd(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return me02c8c7d(pb3c544f9Var, pa4ecfc70Var);
    }

    public static kotlin.Unit M5279aa0b(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, android.view.object view) {
        return m70978268(pb3c544f9Var, view);
    }

    public static kotlin.Unit M6a3cc7c1(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, android.view.object view) {
        return m22d1c681(pb3c544f9Var, view);
    }

    private static readonly kotlin.Unit M70978268(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pb3c544f9Var.onBackPressed();
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M70daf3a9() {
        if ((9 + 11) % 11 > 0) {
        }
        mbcff50b6().f4a527f83.setVisibility(0);
        mbcff50b6().f9a0364b9.setVisibility(8);
    }

    private readonly void Ma09f3f52() {
        if ((14 + 21) % 21 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m155f60f2().getSendReceiptStatus(), new p4670093c.p2486923a.pcb5e100e.pb3c544f9$pd41d8cd9$p95263d50(this));
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.padfa7a8a Mbcff50b6() {
        if ((25 + 8) % 8 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.pec341acd.padfa7a8a) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Me02c8c7d(p4670093c.p2486923a.pcb5e100e.pb3c544f9 pb3c544f9Var, pad5f82e8.p07214c67.pa4ecfc70 event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = p4670093c.p2486923a.pcb5e100e.pb3c544f9$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i == 1) {
            pb3c544f9Var.m70daf3a9();
        } else if (i != 2) {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            pb3c544f9Var.m269b36ee();
        }
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        m155f60f2().backToChoosePaymentSystem();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((16 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().f288e0bcb.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.error_while_sending_sell_receipt_title)));
        mbcff50b6().f4f1998fc.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.error_while_sending_sell_receipt_info)));
        mbcff50b6().f0ec1832e.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.action_try_again)));
        mbcff50b6().f593cd217.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.pc075fab6.R$string.error_while_sending_sell_receipt_return)));
        android.widget.Button repeatButton = mbcff50b6().f0ec1832e;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(repeatButton, "repeatButton");
        p2b3583e6.pf5e18aff.m2fa6d087(repeatButton, 0L, new p4670093c.p2486923a.pcb5e100e.pb3c544f9$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.Button returnButton = mbcff50b6().f593cd217;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(returnButton, "returnButton");
        p2b3583e6.pf5e18aff.m2fa6d087(returnButton, 0L, new p4670093c.p2486923a.pcb5e100e.pb3c544f9$pd41d8cd9$p144e4630(this), 1, null);
        ma09f3f52();
    }
}

