namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u0000 *2\u00020\u0001:\u0001*B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u001f\u001a\u00020 2\u0006\u0010!\u001a\u00020\"2\b\u0010#\u001a\u0004\u0018\u00010$H\u0016J\b\u0010%\u001a\u00020 H\u0002J\u0010\u0010&\u001a\u00020 2\u0006\u0010'\u001a\u00020\u0012H\u0002J\b\u0010(\u001a\u00020 H\u0002J\b\u0010)\u001a\u00020 H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\rR7\u0010\u0013\u001a\b\u0012\u0004\u0012\u00020\u00120\u00112\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00120\u00118B@BX\u0082\u008e\u0002¢\u0006\u0012\n\u0004\b\u0018\u0010\u0019\u001a\u0004\b\u0014\u0010\u0015\"\u0004\b\u0016\u0010\u0017R\u001b\u0010\u001a\u001a\u00020\u001b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u001e\u0010\u000f\u001a\u0004\b\u001c\u0010\u001d¨\u0006+"}, d2 = {"Lp8325324b/p2486923a/p29d4013d/peffcfce9;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/pa0aa25e9;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/p8325324b/p86ccec3d/pec341acd/pa0aa25e9;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "sellAllPaymentTypesobjectModel", "Lp8325324b/p2486923a/p29d4013d/p47c05cb4;", "getSellAllPaymentTypesobjectModel", "()Lp8325324b/p2486923a/p29d4013d/p47c05cb4;", "sellAllPaymentTypesobjectModel$delegate", "Lkotlin/Lazy;", "<set-?>", "", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "paymentTypes", "getPaymentTypes", "()Ljava/util/List;", "setPaymentTypes", "(Ljava/util/List;)V", "paymentTypes$delegate", "Lkotlin/properties/ReadWriteProperty;", "adapter", "Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d;", "getAdapter", "()Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d;", "adapter$delegate", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "observeSnackBarStatus", "selectPaymentType", "paymentType", "initAdapter", "onBackPressed", "Companion", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peffcfce9 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;
    public static readonly p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c f24451751 = null;
    public static readonly p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c f285d1266 = null;
    public static readonly p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c f753d9988 = null;
    public static readonly p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c f910eef8c;
    public static readonly p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c fcd2931ca = null;

    private readonly kotlin.Lazy adapter;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.properties.ReadWriteProperty paymentTypes;

    private readonly kotlin.Lazy sellAllPaymentTypesobjectModel;

    static {
        if ((27 + 23) % 23 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[2];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p8325324b.p2486923a.p29d4013d.peffcfce9.class, com.decryptstringmanager.Decryptstring.decryptstring("34b15de152fff7c0f90b6f533ca303c310973c56c1bb1c106a0368fee9bb46ecb59a1f"), com.decryptstringmanager.Decryptstring.decryptstring("d6c3518aae6840f2349dbb1c777e38c3b7bae774390a6cb0c3085775e390dc4dfa1c0b4e2e1a4e6de5baf6fede22cfb1b15031dbb44339ddc4c8dbbdd96d9f4be821cade7930382a13c05b945308146ee2ac56476daf8c9cf55d9859329e0ad7bbce8656ddc18d5957419c0fc5e11458a0a4de2d93f4e48e8f4e50c3bae5837fe6fbcad407434e"), 0));
        kPropertyArr[1] = kotlin.jvm.internal.Reflection.mutableProperty1(new kotlin.jvm.internal.MutablePropertyReference1Impl(p8325324b.p2486923a.p29d4013d.peffcfce9.class, com.decryptstringmanager.Decryptstring.decryptstring("585e134de0d809c700fa241b45783113b873596da57a9aa75839386197cb9dfc6b24756326da84d9"), com.decryptstringmanager.Decryptstring.decryptstring("2ed50f239de562cdbe292fe8b48b3bc9e5ad1e1ccdafcbe9729a38216165c27306288c5a0052bce7cee09afc2ee9064ae0c3bfae84db189c4b3b450480"), 0));
        $$delegatedProperties = kPropertyArr;
        f910eef8c = new p8325324b.p2486923a.p29d4013d.peffcfce9$p910eef8c(null);
    }

    public peffcfce9() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$layout.fragment_sell_all_payment_types);
        if ((31 + 14) % 14 > 0) {
        }
        p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(peffcfce9Var, p8325324b.p2486923a.p29d4013d.peffcfce9$p001a249d$2.f76425f17);
        this.sellAllPaymentTypesobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p8325324b.p2486923a.p29d4013d.peffcfce9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(peffcfce9Var, null, new p8325324b.p2486923a.p29d4013d.peffcfce9$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(peffcfce9Var), null, null));
        this.paymentTypes = p2b3583e6.p7f662005.pdbc11caa.p9f235ffa.m03cde060();
        this.adapter = p2b3583e6.pba041b39.m4605bd15(new p8325324b.p2486923a.p29d4013d.peffcfce9$pd41d8cd9$p95263d50(this));
    }

    private readonly void M0ec2c495(java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p8c261c90> list) {
        if ((21 + 26) % 26 > 0) {
        }
        this.paymentTypes.setValue(this, $$delegatedProperties[1], list);
    }

    private readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.p8c261c90> M10cea955() {
        if ((5 + 24) % 24 > 0) {
        }
        return (java.util.List) this.paymentTypes.getValue(this, $$delegatedProperties[1]);
    }

    public static readonly void M16dc8bc4(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, java.util.List list) {
        peffcfce9Var.m0ec2c495(list);
    }

    private readonly p8325324b.p2486923a.p29d4013d.p47c05cb4 M2e6c7766() {
        return (p8325324b.p2486923a.p29d4013d.p47c05cb4) this.sellAllPaymentTypesobjectModel.getValue();
    }

    private readonly void M32d86fdb() {
        if ((2 + 20) % 20 > 0) {
        }
        mae0842f8().addPaymentTypes(m10cea955());
        androidx.recyclerview.widget.Recyclerobject recyclerobject = mbcff50b6().fde75169d;
        recyclerobject.setAdapter(mae0842f8());
        recyclerobject.setLayoutManager(new androidx.recyclerview.widget.LinearLayoutManager(recyclerobject.getobject()));
    }

    private static readonly p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d M372b534b(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var) {
        if ((25 + 15) % 15 > 0) {
        }
        return new p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d(new p8325324b.p2486923a.p29d4013d.peffcfce9$p8a7a38cf$2$1(peffcfce9Var));
    }

    private readonly void M37db92e8(pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        m2e6c7766().selectPaymentTypeAnalytics(p8c261c90Var);
        m2e6c7766().processPayment(p8c261c90Var);
    }

    public static readonly void M461b99bd(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, pad5f82e8.p07214c67.p1e11b989.p8c261c90 p8c261c90Var) {
        peffcfce9Var.m37db92e8(p8c261c90Var);
    }

    public static kotlin.Unit M56b3a45c(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 pb3f3bb37Var) {
        return m6a7db4b0(peffcfce9Var, pb3f3bb37Var);
    }

    private static readonly kotlin.Unit M6a7db4b0(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, pad5f82e8.p07214c67.pe907423b.pb3f3bb37 snackBarData) {
        if ((11 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(snackBarData, "snackBarData");
        p2b3583e6.pa2559025.m31049b74(peffcfce9Var, snackBarData, null, null, null, 0, 30, null);
        return kotlin.Unit.INSTANCE;
    }

    private readonly void M9dde3295() {
        if ((17 + 32) % 32 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, m2e6c7766().observeSnackBarStatus(), new p8325324b.p2486923a.p29d4013d.peffcfce9$pd41d8cd9$p144e4630(this));
    }

    public static void M9f4cdb4c(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, android.view.object view) {
        mff914539(peffcfce9Var, view);
    }

    private readonly p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d Mae0842f8() {
        return (p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d) this.adapter.getValue();
    }

    public static p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d Mb8f3b949(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var) {
        return m372b534b(peffcfce9Var);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pa0aa25e9 Mbcff50b6() {
        if ((23 + 28) % 28 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pa0aa25e9) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private static readonly void Mff914539(p8325324b.p2486923a.p29d4013d.peffcfce9 peffcfce9Var, android.view.object view) {
        peffcfce9Var.onBackPressed();
    }

    public override void OnBackPressed() {
        m2e6c7766().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().fef3cba7c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.R$string.sell_all_payment_types_title)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p8325324b.p2486923a.p29d4013d.peffcfce9$pd41d8cd9$pcca4ef0e(this));
        m32d86fdb();
        m9dde3295();
    }
}

