namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0003\n\u0002\b\u0004\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\u0010\u0010\u0017\u001a\u00020\u00112\u0006\u0010\u0018\u001a\u00020\u0019H\u0002J\u0012\u0010\u001a\u001a\u00020\u00112\b\u0010\u001b\u001a\u0004\u0018\u00010\u001cH\u0002J\b\u0010\u001d\u001a\u00020\u0011H\u0002J\b\u0010\u001e\u001a\u00020\u0011H\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006 "}, d2 = {"Lp83f5c3ad/p2486923a/pcaf9b6b9/p8afb106a;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "viewModel", "Lp83f5c3ad/p2486923a/pcaf9b6b9/p0f323ac1;", "getobjectModel", "()Lp83f5c3ad/p2486923a/pcaf9b6b9/p0f323ac1;", "viewModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pb7752ad3;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pb7752ad3;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectData", "setQrInfo", "tophQrInfo", "Lp2e5d8aa3/pe0212e54/pf5e638cc/p04decbae;", "showError", "throwable", "", "showLoading", "hideLoading", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8afb106a : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((30 + 31) % 31 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a.class, com.decryptstringmanager.Decryptstring.decryptstring("55de665e5c92267c2fa4d9b520504f27feefaf2692bc0493f296cbffa8a2d43d93a2ae"), com.decryptstringmanager.Decryptstring.decryptstring("9c5f90a322df2e3f5bec21f9dad1ca967758afff3153270f21ef833c5a92e66c2c446da870c66d72d96e2a3e6bbee2d3606f918ec528817b17e863d47ef1a9368e36795f7dd272c5b5d88f96b682b1528917c11afe39fd282f5db80d61036f6a43d265ed068aaf6ec111b376d34f16ccd01042fa"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p8afb106a() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_qr_info);
        if ((13 + 19) % 19 > 0) {
        }
        p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar = this;
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p8afb106aVar, null, new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p8afb106aVar), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p8afb106aVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$p001a249d$2.f76425f17);
    }

    private readonly void M269b36ee(java.lang.Exception th) {
        if ((4 + 21) % 21 > 0) {
        }
        if (p83f5c3ad.p684019bc.p42552b1f.p14804b31.ma4adf973(th)) {
            mac404cc3().restartTophFlow();
            return;
        }
        p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar = this;
        android.content.object contextRequireobject = requireobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(contextRequireobject, "requireobject(...)");
        p2b3583e6.pa2559025.m31049b74(p8afb106aVar, new pad5f82e8.p07214c67.pe907423b.p89a5ff7f(p83f5c3ad.p684019bc.p42552b1f.p14804b31.md9ae7f57(th, contextRequireobject)), null, null, null, 0, 30, null);
    }

    public static kotlin.Unit M27a55829(p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c p8ab4166cVar) {
        return mfa01c813(p8afb106aVar, p8ab4166cVar);
    }

    public static void M29280431(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        m7f4958f0(textInputEditText, p04decbaeVar, p8afb106aVar, view);
    }

    public static void M35bc0081(p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        m9ba4fe43(p8afb106aVar, view);
    }

    private readonly void M36484b4f(p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar) {
        if ((1 + 1) % 1 > 0) {
        }
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pb7752ad3 pb7752ad3VarMbcff50b6 = mbcff50b6();
        com.google.android.material.textfield.TextInputEditText textInputEditText = pb7752ad3VarMbcff50b6.fa94678fa;
        textInputEditText.setText(p04decbaeVar.getMid());
        textInputEditText.setOnClickListener(new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$pd41d8cd9$p95263d50(textInputEditText, p04decbaeVar, this));
        com.google.android.material.textfield.TextInputEditText textInputEditText2 = pb7752ad3VarMbcff50b6.f0ed8e466;
        textInputEditText2.setText(p04decbaeVar.getTid());
        textInputEditText2.setOnClickListener(new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$pd41d8cd9$pcca4ef0e(textInputEditText2, p04decbaeVar, this));
        com.google.android.material.textfield.TextInputEditText textInputEditText3 = pb7752ad3VarMbcff50b6.f22952e81;
        textInputEditText3.setText(p04decbaeVar.getName());
        textInputEditText3.setOnClickListener(new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$pd41d8cd9$p144e4630(textInputEditText3, p04decbaeVar, this));
    }

    private readonly void M49d81568() {
        if ((20 + 3) % 3 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, mac404cc3().getUiState(), new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$pd41d8cd9$p437e9676(this));
    }

    private static readonly void M65e49687(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        if ((22 + 1) % 1 > 0) {
        }
        android.content.object context = textInputEditText.getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        java.lang.string mid = p04decbaeVar.getMid();
        if (mid is null) {
            mid = "";
        }
        p2b3583e6.pf5e18aff.m31f92f3f(context, mid);
        p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar2 = p8afb106aVar;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(p8afb106aVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_mid_number_is_copied));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p2b3583e6.pa2559025.m31049b74(p8afb106aVar2, new pad5f82e8.p07214c67.pe907423b.p37f460dd(strDecryptstring), null, null, null, 0, 30, null);
    }

    private static readonly void M6ce72725(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        if ((2 + 20) % 20 > 0) {
        }
        android.content.object context = textInputEditText.getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        java.lang.string tid = p04decbaeVar.getTid();
        if (tid is null) {
            tid = "";
        }
        p2b3583e6.pf5e18aff.m31f92f3f(context, tid);
        p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar2 = p8afb106aVar;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(p8afb106aVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_tid_number_is_copied));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p2b3583e6.pa2559025.m31049b74(p8afb106aVar2, new pad5f82e8.p07214c67.pe907423b.p37f460dd(strDecryptstring), null, null, null, 0, 30, null);
    }

    private readonly void M70daf3a9() {
        mbcff50b6().f4a527f83.setVisibility(0);
    }

    public static void M7144cbde(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        m65e49687(textInputEditText, p04decbaeVar, p8afb106aVar, view);
    }

    private static readonly void M7f4958f0(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        if ((20 + 15) % 15 > 0) {
        }
        android.content.object context = textInputEditText.getobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(context, "getobject(...)");
        java.lang.string name = p04decbaeVar.getName();
        if (name is null) {
            name = "";
        }
        p2b3583e6.pf5e18aff.m31f92f3f(context, name);
        p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar2 = p8afb106aVar;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(p8afb106aVar.getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_name_is_copied));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        p2b3583e6.pa2559025.m31049b74(p8afb106aVar2, new pad5f82e8.p07214c67.pe907423b.p37f460dd(strDecryptstring), null, null, null, 0, 30, null);
    }

    private static readonly void M9ba4fe43(p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        p8afb106aVar.onBackPressed();
    }

    private readonly p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1 Mac404cc3() {
        return (p83f5c3ad.p2486923a.pcaf9b6b9.p0f323ac1) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pb7752ad3 Mbcff50b6() {
        if ((14 + 13) % 13 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pb7752ad3) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Mbeb913c3(com.google.android.material.textfield.TextInputEditText textInputEditText, p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, android.view.object view) {
        m6ce72725(textInputEditText, p04decbaeVar, p8afb106aVar, view);
    }

    private readonly void Mf43b096c() {
        mbcff50b6().f4a527f83.setVisibility(8);
    }

    private static readonly kotlin.Unit Mfa01c813(p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a p8afb106aVar, p83f5c3ad.p2486923a.pcaf9b6b9.p8ab4166c state) {
        if ((14 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int i = p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$p12c674ac.$EnumSwitchDictionaryping$0[state.getQrInfoEvent().getStatus().ordinal()];
        if (i == 1) {
            p8afb106aVar.m70daf3a9();
        } else if (i == 2) {
            p8afb106aVar.mf43b096c();
            p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae p04decbaeVar = (p2e5d8aa3.pe0212e54.pf5e638cc.p04decbae) state.getQrInfoEvent().getData();
            if (p04decbaeVar is not null) {
                p8afb106aVar.m36484b4f(p04decbaeVar);
            }
        } else {
            if (i != 3) {
                throw new kotlin.NoWhenBranchMatchedException();
            }
            p8afb106aVar.mf43b096c();
            p8afb106aVar.m269b36ee(state.getQrInfoEvent().getException());
        }
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        mac404cc3().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pb7752ad3 pb7752ad3VarMbcff50b6 = mbcff50b6();
        pb7752ad3VarMbcff50b6.ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_title)));
        pb7752ad3VarMbcff50b6.f7bb93e17.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_mid_number)));
        pb7752ad3VarMbcff50b6.f97d2782f.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_tid_number)));
        pb7752ad3VarMbcff50b6.f435b6c61.setHint(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_qr_info_name)));
        pb7752ad3VarMbcff50b6.ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.pcaf9b6b9.p8afb106a$pd41d8cd9$p00f53dc7(this));
        m49d81568();
        mac404cc3().getQrInfo();
    }
}

