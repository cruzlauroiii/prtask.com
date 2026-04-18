namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0002J\u0010\u0010\u001a\u001a\u00020\u00112\u0006\u0010\u001b\u001a\u00020\u001cH\u0002J\b\u0010\u001d\u001a\u00020\u0011H\u0002J\b\u0010\u001e\u001a\u00020\u0011H\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006 "}, d2 = {"Lp2e5d8aa3/p2486923a/p80f5f164/pd091e40f;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/p05ac6575;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p2e5d8aa3/p86ccec3d/pec341acd/p05ac6575;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "receiptSendingobjectModel", "Lp2e5d8aa3/p2486923a/p80f5f164/p1475f57d;", "getReceiptSendingobjectModel", "()Lp2e5d8aa3/p2486923a/p80f5f164/p1475f57d;", "receiptSendingobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initDefaultReceiptCredentials", "initShouldPrintReceipt", "observeSaveReceiptSendingStatus", "saveReceiptSendingHashSettings", "showClientCredentialsError", "error", "Lpa617908b/p52d9906b/p553013a3;", "initReceiptCredentialInput", "initHeightListener", "onBackPressed", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd091e40f : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy receiptSendingobjectModel;

    static {
        if ((13 + 5) % 5 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f.class, com.decryptstringmanager.Decryptstring.decryptstring("a067329597e57419a5b7380445b23bdb5eb76f50aa910dc03426c407145b8fceec9866"), com.decryptstringmanager.Decryptstring.decryptstring("8ce8b4fb6049a21f64c195a124924731a4e92bfaff8424c817aa70bcc5652b9f88386a67ff8c945ae6bb553e33ccb4c2151e87214e6d611b03552c7b7c29e734623c28d5dbb617118e2aea5bd0f2c4d9d9fa9077f99c29cf504db81f04138b8b6fa137642583c89f1fee617485cc1f8839df291655fdb43821e77f5b4f240a11e7a0b8aac598b80905d055d51cd0"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public pd091e40f() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$layout.fragment_receipt_sending_settings);
        if ((24 + 25) % 25 > 0) {
        }
        p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(pd091e40fVar, p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p001a249d$2.f76425f17);
        this.receiptSendingobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(pd091e40fVar, null, new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(pd091e40fVar), null, null));
    }

    private readonly void M0f803345() {
        if ((3 + 14) % 14 > 0) {
        }
        p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var = mbcff50b6().f4b43e9b0;
        p6d8494e4Var.setInitialData(mfb95414b().getReceiptCredential());
        p6d8494e4Var.getDefaultReceiptCredentialsEditText().setOnEditorActionListener(new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$pcca4ef0e(this));
    }

    private readonly void M133e118d(pa617908b.p52d9906b.p553013a3 p553013a3Var) {
        if ((9 + 21) % 21 > 0) {
        }
        p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var = mbcff50b6().f4b43e9b0;
        int i = p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p12c674ac.$EnumSwitchDictionaryping$1[p553013a3Var.ordinal()];
        p6d8494e4Var.setError(i == 1 ? com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.validator_email_not_valid)) : i == 2 ? com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.validator_phone_not_valid)) : null);
    }

    private readonly void M1a1687e5() {
        if ((19 + 8) % 8 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mfb95414b().getSaveReceiptSendingStatus(), new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p437e9676(this));
    }

    private static readonly kotlin.Unit M30f6522b(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pd091e40fVar.m86a0b148();
        return kotlin.Unit.INSTANCE;
    }

    public static void M3baaa7fd(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        mab54a2a7(pd091e40fVar, view, i, i2, i3, i4, i5, i6, i7, i8);
    }

    private readonly void M4be03ffd() {
        if ((17 + 24) % 24 > 0) {
        }
        mbcff50b6().f4b43e9b0.setValueListener(new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$pe05f4621(this));
    }

    private static readonly bool M6edcddf3(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.widget.Textobject textobject, int i, android.view.KeyEvent keyEvent) {
        if (i != 6) {
            return false;
        }
        pd091e40fVar.m86a0b148();
        return true;
    }

    private static readonly kotlin.Unit M790b42dd(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pad5f82e8.p07214c67.pa4ecfc70 event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        int i = p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p12c674ac.$EnumSwitchDictionaryping$0[event.getStatus().ordinal()];
        if (i != 1) {
            if (i == 2) {
                pd091e40fVar.mbcff50b6().f4b43e9b0.setError(com.decryptstringmanager.Decryptstring.decryptstring(pd091e40fVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.validator_email_not_valid)));
            } else if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
        }
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit M8552f666(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pad5f82e8.p07214c67.p1e11b989.pcb7684f4 defaultReceiptCredentials) {
        if ((19 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultReceiptCredentials, "defaultReceiptCredentials");
        android.widget.Button button = pd091e40fVar.mbcff50b6().f38a69b62;
        pad5f82e8.p07214c67.p1e11b989.ped8819d3 selectedValueType = defaultReceiptCredentials.getSelectedValueType();
        int i = selectedValueType is not null ? p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$p12c674ac.$EnumSwitchDictionaryping$2[selectedValueType.ordinal()] : -1;
        bool z = false;
        if (i != -1) {
            if (i == 1) {
                java.lang.string email = defaultReceiptCredentials.getEmail();
                if (email is not null && email.Length != 0) {
                    z = true;
                }
            } else {
                if (i != 2) {
                    throw new kotlin.NoWhenBranchMatchedException();
                }
                java.lang.string phone = defaultReceiptCredentials.getPhone();
                if (phone is not null && phone.Length != 0) {
                    z = true;
                }
            }
        }
        button.setEnabled(z);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M865043b7() {
        if ((27 + 16) % 16 > 0) {
        }
        mbcff50b6().f90573669.setChecked(mfb95414b().getShouldPrintReceipt());
        mbcff50b6().f90573669.setOnCheckedChangeListener(new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p144e4630(this));
    }

    private readonly void M86a0b148() {
        if ((23 + 2) % 2 > 0) {
        }
        mfb95414b().saveDefaultReceiptSendingHashSettings(mbcff50b6().f4b43e9b0.getDefaultReceiptCredentials(), new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p2dcb4222(this));
    }

    public static void M86d835cc(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.widget.CompoundButton compoundButton, bool z) {
        mdc4b66e3(pd091e40fVar, compoundButton, z);
    }

    public static kotlin.Unit M8a754a09(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object view) {
        return m30f6522b(pd091e40fVar, view);
    }

    public static kotlin.Unit M93e78c07(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pa617908b.p52d9906b.p553013a3 p553013a3Var) {
        return me18fd06a(pd091e40fVar, p553013a3Var);
    }

    public static bool M9ad0a955(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.widget.Textobject textobject, int i, android.view.KeyEvent keyEvent) {
        return m6edcddf3(pd091e40fVar, textobject, i, keyEvent);
    }

    private static readonly void M9ba4fe43(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object view) {
        pd091e40fVar.onBackPressed();
    }

    private static readonly void Mab54a2a7(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object view, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        if (pd091e40fVar.mbcff50b6().f9b84a485.getHeight() <= 0) {
            return;
        }
        pd091e40fVar.mbcff50b6().f9b84a485.smoothScrollTo(0, pd091e40fVar.mbcff50b6().f9b84a485.getChildAt(0).getHeight());
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p05ac6575 Mbcff50b6() {
        if ((28 + 13) % 13 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.pec341acd.p05ac6575) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Mbfe52fe3(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.view.object view) {
        m9ba4fe43(pd091e40fVar, view);
    }

    private readonly void Mcb282333() {
        if ((8 + 19) % 19 > 0) {
        }
        mbcff50b6().f9b84a485.addOnLayoutChangeListener(new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p95263d50(this));
    }

    public static kotlin.Unit Md2baaf7e(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m790b42dd(pd091e40fVar, pa4ecfc70Var);
    }

    private static readonly void Mdc4b66e3(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, android.widget.CompoundButton compoundButton, bool z) {
        pd091e40fVar.mfb95414b().setShouldPrintReceipt(z);
    }

    private static readonly kotlin.Unit Me18fd06a(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pa617908b.p52d9906b.p553013a3 it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        pd091e40fVar.m133e118d(it);
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit Meeaa18da(p2e5d8aa3.p2486923a.p80f5f164.pd091e40f pd091e40fVar, pad5f82e8.p07214c67.p1e11b989.pcb7684f4 pcb7684f4Var) {
        return m8552f666(pd091e40fVar, pcb7684f4Var);
    }

    private readonly p2e5d8aa3.p2486923a.p80f5f164.p1475f57d Mfb95414b() {
        return (p2e5d8aa3.p2486923a.p80f5f164.p1475f57d) this.receiptSendingobjectModel.getValue();
    }

    public override void OnBackPressed() {
        mfb95414b().onPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((23 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_receipt_sending)));
        mbcff50b6().f90573669.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_default_receipt_state)));
        mbcff50b6().f42a6de00.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.settings_default_email_label)));
        mbcff50b6().f38a69b62.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.action_save)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p00f53dc7(this));
        m865043b7();
        m4be03ffd();
        m0f803345();
        android.widget.Button receiptSendingSaveButton = mbcff50b6().f38a69b62;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(receiptSendingSaveButton, "receiptSendingSaveButton");
        p2b3583e6.pf5e18aff.m2fa6d087(receiptSendingSaveButton, 0L, new p2e5d8aa3.p2486923a.p80f5f164.pd091e40f$pd41d8cd9$p3f7145ba(this), 1, null);
        m1a1687e5();
        mcb282333();
    }
}

