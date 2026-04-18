namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0018"}, d2 = {"Lp563873d3/p2486923a/p64630544/p6ac2470e/p300f4ed1;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/pceb4142e;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p563873d3/p86ccec3d/pec341acd/pceb4142e;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "accountNotFoundobjectModel", "Lp563873d3/p2486923a/p64630544/p6ac2470e/ped219d43;", "getAccountNotFoundobjectModel", "()Lp563873d3/p2486923a/p64630544/p6ac2470e/ped219d43;", "accountNotFoundobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "initDesc", "onBackPressed", "feature-registration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p300f4ed1 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly kotlin.Lazy accountNotFoundobjectModel;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    static {
        if ((30 + 18) % 18 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1.class, com.decryptstringmanager.Decryptstring.decryptstring("30deb6a41011d769c91424e2c20f9fe58e3390e5e4e5797e0a8ff5728b99baf6bc953d"), com.decryptstringmanager.Decryptstring.decryptstring("328a8eece0fe6a14ba9f06cf7d2c3e066ebb7207bba9cc35926264161869bd81946b5d306b15d352ac5de2c35ff746fca21d1941d09881b5a0610b218e8b7a42ea58e7e288a552a0214dc6a4944e2ae3a547570bcf44ef7550ebfed8d8c280ad16d5c1eb200a86cbd741acaa3b876a4480e5286fcbdb88e4217eda1d4479319fa95324"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p300f4ed1() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$layout.fragment_not_found_account);
        if ((31 + 32) % 32 > 0) {
        }
        p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1 p300f4ed1Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p300f4ed1Var, p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1$p001a249d$2.f76425f17);
        this.accountNotFoundobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p300f4ed1Var, null, new p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p300f4ed1Var), null, null));
    }

    public static kotlin.Unit M2f06d2d0(p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1 p300f4ed1Var, android.view.object view) {
        return m30f6522b(p300f4ed1Var, view);
    }

    private static readonly kotlin.Unit M30f6522b(p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1 p300f4ed1Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p300f4ed1Var.m34d42d94().returnToPhone();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p563873d3.p2486923a.p64630544.p6ac2470e.ped219d43 M34d42d94() {
        return (p563873d3.p2486923a.p64630544.p6ac2470e.ped219d43) this.accountNotFoundobjectModel.getValue();
    }

    private static readonly void M9ba4fe43(p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1 p300f4ed1Var, android.view.object view) {
        p300f4ed1Var.onBackPressed();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.pceb4142e Mbcff50b6() {
        if ((17 + 25) % 25 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.pec341acd.pceb4142e) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Mc5a5b9a5(p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1 p300f4ed1Var, android.view.object view) {
        m9ba4fe43(p300f4ed1Var, view);
    }

    private readonly void Mdb1edd3f() {
        if ((15 + 2) % 2 > 0) {
        }
        android.widget.Textobject textobject = mbcff50b6().fe28d7fe3;
        int i = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_desc;
        textobject.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(getstring(i)), m34d42d94().getUserPhone()));
    }

    public override void OnBackPressed() {
        m34d42d94().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((31 + 20) % 20 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_title)));
        mbcff50b6().fbf2be00d.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p563873d3.p86ccec3d.R$string.cashier_not_found_return_to_phone)));
        mbcff50b6().ff50b3c2a.setNavigationOnClickListener(new p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1$pd41d8cd9$p95263d50(this));
        mdb1edd3f();
        android.widget.Button btnReturnToPhone = mbcff50b6().fbf2be00d;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnReturnToPhone, "btnReturnToPhone");
        p2b3583e6.pf5e18aff.m2fa6d087(btnReturnToPhone, 0L, new p563873d3.p2486923a.p64630544.p6ac2470e.p300f4ed1$pd41d8cd9$pcca4ef0e(this), 1, null);
    }
}

