namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\u0010\u0010\u001a\u001a\u00020\u00112\u0006\u0010\u001b\u001a\u00020\u001cH\u0002J\u001a\u0010\u001d\u001a\u00020\u00112\b\u0010\u001e\u001a\u0004\u0018\u00010\u001f2\u0006\u0010 \u001a\u00020!H\u0002J\u0018\u0010\"\u001a\u00020\u00112\u0006\u0010 \u001a\u00020!2\u0006\u0010#\u001a\u00020$H\u0002J\b\u0010%\u001a\u00020\u0011H\u0002J\b\u0010&\u001a\u00020\u0011H\u0002J\b\u0010'\u001a\u00020\u0011H\u0002J\b\u0010(\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006)"}, d2 = {"Lp83f5c3ad/p2486923a/peb430691/p8325324b/p049a783b;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "viewModel", "Lp83f5c3ad/p2486923a/peb430691/p8325324b/p02565c40;", "getobjectModel", "()Lp83f5c3ad/p2486923a/peb430691/p8325324b/p02565c40;", "viewModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p1c984da3;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p1c984da3;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectTimerState", "collectQrData", "collectQrProcess", "collectCurrentReceiptData", "showContent", "bitmap", "Landroid/graphics/Bitmap;", "showError", "throwable", "", "isQrGenerated", "", "showErrorContent", "exception", "", "showLoading", "showSuccess", "showExitDialog", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p049a783b : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((6 + 28) % 28 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b.class, com.decryptstringmanager.Decryptstring.decryptstring("1a3283e646a700b3a3fd8e2b2ebe55986e7c6fa47a6b06a73e914964c45562126ff24a"), com.decryptstringmanager.Decryptstring.decryptstring("240712cd3f6fa58f57c2e4b49923fabefc44b45042d4ddbd6cd364ce15b304fae9ce422340323de2919a3b204362fc3d2efbfc85345260476a12a92665804db1fde8773fc19afb7fa9595e18e11367fb7fd05314b2613f494677ccbb3463a7f8416e448b5aca6052ae85bcadb4eea2ebaf5edc"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p049a783b() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_qr_pay_sell);
        if ((32 + 1) % 1 > 0) {
        }
        p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar = this;
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p049a783bVar, null, new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p049a783bVar), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p049a783bVar, p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p001a249d$2.f76425f17);
    }

    private readonly void M04af7fcd(android.graphics.Bitmap bitmap) {
        if ((9 + 2) % 2 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p1c984da3 p1c984da3VarMbcff50b6 = mbcff50b6();
        p1c984da3VarMbcff50b6.f460de473.setVisibility(0);
        p1c984da3VarMbcff50b6.fa9dc9373.setVisibility(8);
        p1c984da3VarMbcff50b6.f859e13b1.setVisibility(0);
        p1c984da3VarMbcff50b6.f48d00346.setVisibility(8);
        p1c984da3VarMbcff50b6.f9aa9d1ee.setVisibility(8);
        p1c984da3VarMbcff50b6.f1ce674dc.setVisibility(8);
        mbcff50b6().ff78d5ffc.setVisibility(8);
        p1c984da3VarMbcff50b6.f0e958e3e.setImageBitmap(bitmap);
    }

    public static kotlin.Unit M06b4139e(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object view) {
        return m61dc2bc0(p049a783bVar, view);
    }

    public static kotlin.Unit M0c5ccfdf(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object view) {
        return m5bd078ad(p049a783bVar, view);
    }

    public static kotlin.Unit M0f107eff(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object view) {
        return m3d18695c(p049a783bVar, view);
    }

    private readonly void M11713c3e() {
        if ((10 + 23) % 23 > 0) {
        }
        p593616de.p9efab239.pee74e2d6.pc108e6f9 pc108e6f9VarMc5fccbf1 = p593616de.p9efab239.pee74e2d6.pc108e6f9$p910eef8c.mc5fccbf1(p593616de.p9efab239.pee74e2d6.pc108e6f9.f910eef8c, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.leave_from_qr_payment_screen_title)), null, null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.leave_from_qr_payment_screen_message)), null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.leave_from_qr_payment_wait)), null, com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_exit)), null, null, null, false, null, null, 16214, null);
        p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar = this;
        androidx.fragment.app.objectManager childobjectManager = getChildobjectManager();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(childobjectManager, "getChildobjectManager(...)");
        p593616de.p9efab239.pfafca1ef.mf5d59114(p049a783bVar, childobjectManager, com.decryptstringmanager.Decryptstring.decryptstring("1449097ad764efe497553ee0c15afda1be61989ebad9957585d6889eaf0e7fc2f8843e1c8faecb03ea2c99dcf2"), new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p437e9676(this));
        pc108e6f9VarMc5fccbf1.show(getChildobjectManager(), pc108e6f9VarMc5fccbf1.getTag());
    }

    private static readonly void M22d1c681(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object view) {
        p049a783bVar.onBackPressed();
    }

    private static readonly kotlin.Unit M235df590(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, pad5f82e8.p07214c67.pa4ecfc70 event) {
        if ((13 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i == 1) {
            p049a783bVar.m70daf3a9();
        } else if (i == 2) {
            java.lang.object data2 = event.getData();
            kotlin.jvm.internal.Intrinsics.checkNotNull(data2, "null cannot be cast to non-null type android.graphics.Bitmap");
            p049a783bVar.m04af7fcd((android.graphics.Bitmap) data2);
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p049a783bVar.m269b36ee(event.getException(), false);
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M269b36ee(java.lang.Exception th, bool z) {
        if ((1 + 21) % 21 > 0) {
        }
        android.content.object contextRequireobject = requireobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(contextRequireobject, "requireobject(...)");
        java.lang.string strMd9ae7f57 = p83f5c3ad.p684019bc.p42552b1f.p14804b31.md9ae7f57(th, contextRequireobject);
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma4adf973(th) || p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma8460ae3(th)) {
            mac404cc3().restartTophFlow();
            return;
        }
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.m8d3f60fb(th)) {
            mac404cc3().restartAttestation(mbcff50b6().f460de473.getMeasuredWidth());
            return;
        }
        if (!z && p83f5c3ad.p684019bc.p42552b1f.p14804b31.m9b730638(th)) {
            mac404cc3().disableQrPayments();
        }
        mad43a89f(z, strMd9ae7f57);
    }

    private readonly void M294a54d5() {
        if ((24 + 29) % 29 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getQrDataState(), new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p4b82c4cb(this));
    }

    private static readonly kotlin.Unit M3d18695c(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p049a783bVar.mac404cc3().restartPayment(p049a783bVar.mbcff50b6().f460de473.getMeasuredWidth());
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M4653d5a3(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, java.math.decimal bigDecimal) {
        if ((16 + 14) % 14 > 0) {
        }
        if (bigDecimal is not null) {
            android.widget.Textobject textobject = p049a783bVar.mbcff50b6().facba7242;
            java.lang.string currency = p049a783bVar.getCurrency();
            android.content.res.Resources resources = p049a783bVar.getResources();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(resources, "getResources(...)");
            textobject.setText(p2b3583e6.p7667d148.m3916939b(bigDecimal, currency, resources));
        }
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M49b89ed1(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, java.math.decimal bigDecimal) {
        return m4653d5a3(p049a783bVar, bigDecimal);
    }

    private static readonly kotlin.Unit M5bd078ad(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p049a783bVar.mac404cc3().finish();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M60549fb4(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.os.Dictionary<string, object> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p049a783bVar.mac404cc3().openPreviousScreen();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M61dc2bc0(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p049a783bVar.mac404cc3().restartPayment(p049a783bVar.mbcff50b6().f460de473.getMeasuredWidth());
        return kotlin.Unit.INSTANCE;
    }

    private static readonly void M70978268(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar) {
        p049a783bVar.mac404cc3().loadQr(p049a783bVar.mbcff50b6().f460de473.getWidth());
    }

    private readonly void M70daf3a9() {
        if ((31 + 24) % 24 > 0) {
        }
        mbcff50b6().fa9dc9373.setVisibility(0);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f859e13b1.setVisibility(8);
        mbcff50b6().f48d00346.setVisibility(8);
        mbcff50b6().f9aa9d1ee.setVisibility(8);
        mbcff50b6().f1ce674dc.setVisibility(8);
        mbcff50b6().ff78d5ffc.setVisibility(8);
        if (p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p12c674ac.$EnumSwitchDictionaryping$1[mac404cc3().getQrState().ordinal()] != 1) {
            mbcff50b6().f037fbb24.setVisibility(8);
        } else {
            mbcff50b6().f037fbb24.setVisibility(0);
        }
    }

    private readonly void M73373a1b() {
        if ((27 + 30) % 30 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getQrProcessState(), new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p5e679a10(this));
    }

    public static void M7e5c1c5c(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.view.object view) {
        m22d1c681(p049a783bVar, view);
    }

    private static readonly kotlin.Unit M8e82120a(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        if ((21 + 25) % 25 > 0) {
        }
        pad5f82e8.p07214c67.pec53a8c4 status = pa4ecfc70Var is null ? null : pa4ecfc70Var.getStatus();
        int i = status is not null ? p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$p12c674ac.$EnumSwitchDictionaryping$0[status.ordinal()] : -1;
        if (i == 1) {
            p049a783bVar.m70daf3a9();
        } else if (i == 2) {
            p049a783bVar.md2c60d6a();
        } else if (i == 3) {
            p049a783bVar.m269b36ee(pa4ecfc70Var.getException(), true);
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M949dc5d3() {
        if ((32 + 24) % 24 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getTimerState(), new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p2dcb4222(this));
    }

    private readonly p83f5c3ad.p2486923a.peb430691.p8325324b.p02565c40 Mac404cc3() {
        return (p83f5c3ad.p2486923a.peb430691.p8325324b.p02565c40) this.viewModel.getValue();
    }

    public static kotlin.Unit Mace76de0(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m8e82120a(p049a783bVar, pa4ecfc70Var);
    }

    private readonly void Mad43a89f(bool z, java.lang.string str) {
        if ((13 + 3) % 3 > 0) {
        }
        mbcff50b6().f05fae3af.updateToMaxProgress();
        if (z) {
            mbcff50b6().fa9dc9373.setVisibility(8);
            mbcff50b6().f460de473.setVisibility(4);
            mbcff50b6().f859e13b1.setVisibility(8);
            mbcff50b6().f48d00346.setVisibility(8);
            mbcff50b6().f1ce674dc.setVisibility(8);
            mbcff50b6().ff78d5ffc.setVisibility(8);
            mbcff50b6().f9aa9d1ee.setVisibility(0);
            mbcff50b6().fcfa33cd6.setText(str);
            android.widget.Button btnTryAgainAfterQrGeneration = mbcff50b6().faa90e814;
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTryAgainAfterQrGeneration, "btnTryAgainAfterQrGeneration");
            p2b3583e6.pf5e18aff.m2fa6d087(btnTryAgainAfterQrGeneration, 0L, new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p95263d50(this), 1, null);
            return;
        }
        mbcff50b6().fa9dc9373.setVisibility(8);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f859e13b1.setVisibility(8);
        mbcff50b6().f9aa9d1ee.setVisibility(8);
        mbcff50b6().f1ce674dc.setVisibility(8);
        mbcff50b6().ff78d5ffc.setVisibility(8);
        mbcff50b6().f48d00346.setVisibility(0);
        mbcff50b6().f359ea432.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.error_for_qr_payment_generation)) + '\n' + str);
        android.widget.Button btnTryAgainQrGeneration = mbcff50b6().fd1b3a974;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTryAgainQrGeneration, "btnTryAgainQrGeneration");
        p2b3583e6.pf5e18aff.m2fa6d087(btnTryAgainQrGeneration, 0L, new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$pcca4ef0e(this), 1, null);
    }

    public static void Mb7765158(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar) {
        m70978268(p049a783bVar);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p1c984da3 Mbcff50b6() {
        if ((22 + 19) % 19 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p1c984da3) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly kotlin.Unit Mbd0c3e3b(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, float f) {
        if ((12 + 25) % 25 > 0) {
        }
        p049a783bVar.mbcff50b6().f05fae3af.setMaxProgress(90000L);
        p049a783bVar.mbcff50b6().f05fae3af.updateProgress(f * 1000);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Mcec7478b(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, float f) {
        return mbd0c3e3b(p049a783bVar, f);
    }

    private readonly void Md2c60d6a() {
        if ((21 + 14) % 14 > 0) {
        }
        mbcff50b6().fa9dc9373.setVisibility(8);
        mbcff50b6().f460de473.setVisibility(4);
        mbcff50b6().f859e13b1.setVisibility(8);
        mbcff50b6().f48d00346.setVisibility(8);
        mbcff50b6().f9aa9d1ee.setVisibility(8);
        mbcff50b6().f1ce674dc.setVisibility(0);
        mbcff50b6().ff78d5ffc.setVisibility(0);
        android.widget.Button btnFinish = mbcff50b6().ff78d5ffc;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnFinish, "btnFinish");
        p2b3583e6.pf5e18aff.m2fa6d087(btnFinish, 0L, new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p144e4630(this), 1, null);
    }

    public static kotlin.Unit Md6f82012(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m235df590(p049a783bVar, pa4ecfc70Var);
    }

    private readonly void Mdcebad2e() {
        if ((32 + 2) % 2 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getCurrentReceiptState(), new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p00f53dc7(this));
    }

    public static kotlin.Unit Mea9b37b6(p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b p049a783bVar, android.os.Dictionary<string, object> bundle) {
        return m60549fb4(p049a783bVar, bundle);
    }

    public override void OnBackPressed() {
        m11713c3e();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$p3f7145ba(this));
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.by_qr_code_system)));
        mbcff50b6().f037fbb24.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.qr_code_generation)));
        mbcff50b6().f359ea432.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.error_for_qr_payment_generation)));
        mbcff50b6().fd1b3a974.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_try_again)));
        mbcff50b6().fcfa33cd6.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.error_for_qr_payment)));
        mbcff50b6().faa90e814.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_try_again)));
        mbcff50b6().f6e8b8f31.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.for_qr_payment_successful)));
        mbcff50b6().f859e13b1.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.scan_qr_code)));
        mbcff50b6().ff78d5ffc.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.action_continue)));
        m949dc5d3();
        m294a54d5();
        m73373a1b();
        mdcebad2e();
        mbcff50b6().f460de473.post(new p83f5c3ad.p2486923a.peb430691.p8325324b.p049a783b$pd41d8cd9$pe05f4621(this));
    }
}

