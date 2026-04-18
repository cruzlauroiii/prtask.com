namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\u0012\u0010\u0017\u001a\u00020\u00112\b\u0010\u0018\u001a\u0004\u0018\u00010\u0019H\u0002J\b\u0010\u001a\u001a\u00020\u0011H\u0002J\u0010\u0010\u001b\u001a\u00020\u00112\u0006\u0010\u001c\u001a\u00020\u001dH\u0002J\b\u0010\u001e\u001a\u00020\u0011H\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006 "}, d2 = {"Lp83f5c3ad/p2486923a/peb430691/p4670093c/p1091d367;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "viewModel", "Lp83f5c3ad/p2486923a/peb430691/p4670093c/p8bb2a95d;", "getobjectModel", "()Lp83f5c3ad/p2486923a/peb430691/p4670093c/p8bb2a95d;", "viewModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p15f3fa4e;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p15f3fa4e;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectRefund", "showError", "throwable", "", "showLoading", "showErrorContent", "exception", "", "showSuccess", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1091d367 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((15 + 7) % 7 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367.class, com.decryptstringmanager.Decryptstring.decryptstring("dfa6c473d30a6dac609515a6cb10c5014291efdff4fc224ecf27114829e18827171d2d"), com.decryptstringmanager.Decryptstring.decryptstring("3f24f5c5afc9a2b8cb3a79e7dd8814142f8760cb8396609de1b9a22639cbb93c2acea53c9944420e62ea70ad42e879696e28435b6b9f5ae74a481abba7be55ae0a8d7a0464995fd220da4682cf42927eb18a5e61258a0aa0b1c7ca27f9d6411f21c60184315a52097f36fa70fdc92d561a3db57ff675"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p1091d367() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_qr_pay_payback);
        if ((9 + 28) % 28 > 0) {
        }
        p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var = this;
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p1091d367Var, null, new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p1091d367Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p1091d367Var, p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$p001a249d$2.f76425f17);
    }

    public static kotlin.Unit M1769cd53(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m3ef414d7(p1091d367Var, pa4ecfc70Var);
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object view) {
        p1091d367Var.onBackPressed();
    }

    private readonly void M269b36ee(java.lang.Exception th) {
        if ((1 + 30) % 30 > 0) {
        }
        android.content.object contextRequireobject = requireobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(contextRequireobject, "requireobject(...)");
        java.lang.string strMd9ae7f57 = p83f5c3ad.p684019bc.p42552b1f.p14804b31.md9ae7f57(th, contextRequireobject);
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma4adf973(th) || p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma8460ae3(th)) {
            mac404cc3().restartTophFlow();
        } else {
            if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m8d3f60fb(th)) {
                mac404cc3().restartAttestation();
                return;
            }
            if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m9b730638(th)) {
                mac404cc3().disableQrPayments();
            }
            mad43a89f(strMd9ae7f57);
        }
    }

    public static void M3d0c5f5e(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object view) {
        m22d1c681(p1091d367Var, view);
    }

    private static readonly kotlin.Unit M3ef414d7(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, pad5f82e8.p07214c67.pa4ecfc70 event) {
        if ((5 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i == 1) {
            p1091d367Var.m70daf3a9();
        } else if (i == 2) {
            p1091d367Var.md2c60d6a();
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p1091d367Var.m269b36ee(event.getException());
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M70daf3a9() {
        if ((12 + 29) % 29 > 0) {
        }
        mbcff50b6().fa14fa216.setVisibility(0);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f1ce674dc.setVisibility(8);
        mbcff50b6().ff78d5ffc.setVisibility(8);
        mbcff50b6().f9aa9d1ee.setVisibility(8);
    }

    public static kotlin.Unit M84f11a90(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object view) {
        return mf21580e9(p1091d367Var, view);
    }

    private readonly void M94c885d6() {
        if ((14 + 2) % 2 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getRefundState(), new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$pd41d8cd9$p144e4630(this));
    }

    private readonly p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d Mac404cc3() {
        return (p83f5c3ad.p2486923a.peb430691.p4670093c.p8bb2a95d) this.viewModel.getValue();
    }

    private readonly void Mad43a89f(java.lang.string str) {
        if ((21 + 17) % 17 > 0) {
        }
        mbcff50b6().fa14fa216.setVisibility(8);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f1ce674dc.setVisibility(8);
        mbcff50b6().ff78d5ffc.setVisibility(8);
        mbcff50b6().f9aa9d1ee.setVisibility(0);
        mbcff50b6().fd773ab1f.setText(str);
        android.widget.Button btnTryAgainAfterQrGeneration = mbcff50b6().faa90e814;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTryAgainAfterQrGeneration, "btnTryAgainAfterQrGeneration");
        p2b3583e6.pf5e18aff.m2fa6d087(btnTryAgainAfterQrGeneration, 0L, new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$pd41d8cd9$p437e9676(this), 1, null);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p15f3fa4e Mbcff50b6() {
        if ((19 + 14) % 14 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p15f3fa4e) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly void Md2c60d6a() {
        if ((16 + 6) % 6 > 0) {
        }
        mbcff50b6().fa14fa216.setVisibility(8);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f9aa9d1ee.setVisibility(8);
        mbcff50b6().f1ce674dc.setVisibility(0);
        mbcff50b6().ff78d5ffc.setVisibility(0);
        android.widget.Button btnFinish = mbcff50b6().ff78d5ffc;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnFinish, "btnFinish");
        p2b3583e6.pf5e18aff.m2fa6d087(btnFinish, 0L, new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$pd41d8cd9$p95263d50(this), 1, null);
    }

    private static readonly kotlin.Unit Mf21580e9(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p1091d367Var.mac404cc3().startPayback();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit Mf5450f92(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p1091d367Var.mac404cc3().finish();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mf93f3ea6(p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367 p1091d367Var, android.view.object view) {
        return mf5450f92(p1091d367Var, view);
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.peb430691.p4670093c.p1091d367$pd41d8cd9$pcca4ef0e(this));
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.by_qr_code_payback)));
        mbcff50b6().fd773ab1f.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.error_for_qr_payback)));
        mbcff50b6().faa90e814.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_try_again)));
        mbcff50b6().f353c48a3.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.for_qr_payback_successful)));
        mbcff50b6().ff78d5ffc.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_continue)));
        mac404cc3().startPayback();
        m94c885d6();
    }
}

