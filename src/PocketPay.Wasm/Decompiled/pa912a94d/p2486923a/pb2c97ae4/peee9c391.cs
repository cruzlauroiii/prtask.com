namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0002J\b\u0010\u0017\u001a\u00020\u0011H\u0002J\b\u0010\u0018\u001a\u00020\u0011H\u0002J\b\u0010\u0019\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u001a"}, d2 = {"Lpa912a94d/p2486923a/pb2c97ae4/peee9c391;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pa912a94d/p86ccec3d/pec341acd/pda01549a;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pa912a94d/p86ccec3d/pec341acd/pda01549a;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "statisticsFilterobjectModel", "Lpa912a94d/p2486923a/pb2c97ae4/p884f7d43;", "getStatisticsFilterobjectModel", "()Lpa912a94d/p2486923a/pb2c97ae4/p884f7d43;", "statisticsFilterobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "setFilter", "observeFilterCheckDateTimeStatus", "resetFilter", "onBackPressed", "feature-statistics-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peee9c391 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy statisticsFilterobjectModel;

    static {
        if ((32 + 22) % 22 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pa912a94d.p2486923a.pb2c97ae4.peee9c391.class, com.decryptstringmanager.Decryptstring.decryptstring("9b524f07d3b83229d3e84dde190b8fce9b28518b83d7afafa2b56b739161ad94c244f3"), com.decryptstringmanager.Decryptstring.decryptstring("c8d3cd1afd5233e091b9da736c193649de9c8a1b122a0c7ed1691f124c884c158515a461591ed87d5c8b3866c1eacef6346d3decc2064daf8aa78ad5c4a790c99f6ae6b194f594f5c311a8cbdd276b3a6455e683e662e9fbf10a15fe113ecd1a498049a4a2fe5a5675d1d88543dee17d522e07d695bd56076a0c5d67a96654b1b057e739ca7b8bc78e69"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public peee9c391() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$layout.fragment_statistics_filter);
        if ((10 + 19) % 19 > 0) {
        }
        pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(peee9c391Var, pa912a94d.p2486923a.pb2c97ae4.peee9c391$p001a249d$2.f76425f17);
        this.statisticsFilterobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pa912a94d.p2486923a.pb2c97ae4.peee9c391$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(peee9c391Var, null, new pa912a94d.p2486923a.pb2c97ae4.peee9c391$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(peee9c391Var), null, null));
    }

    private readonly pa912a94d.p2486923a.pb2c97ae4.p884f7d43 M11f12c63() {
        return (pa912a94d.p2486923a.pb2c97ae4.p884f7d43) this.statisticsFilterobjectModel.getValue();
    }

    private readonly void M1df13c6e() {
        m11f12c63().resetFilter();
        mb032f5ba();
    }

    private static readonly bool M2eaf0180(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.MenuItem it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        peee9c391Var.m1df13c6e();
        return true;
    }

    private readonly void M41ce2a9e() {
        if ((19 + 23) % 23 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m1b65e84b(this, mbcff50b6().fb2c97ae4.subscribeIsPeriodCorrectStatus(), new pa912a94d.p2486923a.pb2c97ae4.peee9c391$pd41d8cd9$p437e9676(this));
    }

    private static readonly kotlin.Unit M526f9ebb(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        peee9c391Var.m11f12c63().updateFilter(peee9c391Var.mbcff50b6().fb2c97ae4.getFilter());
        return kotlin.Unit.INSTANCE;
    }

    public static void M58772ea3(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.object view) {
        mff914539(peee9c391Var, view);
    }

    private static readonly kotlin.Unit M66e941f4(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, bool z) {
        peee9c391Var.mbcff50b6().f3ff41432.setEnabled(z);
        return kotlin.Unit.INSTANCE;
    }

    public static bool Ma8e4ef29(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.MenuItem menuItem) {
        return m2eaf0180(peee9c391Var, menuItem);
    }

    private readonly void Mb032f5ba() {
        mbcff50b6().fb2c97ae4.setFilter(m11f12c63().getFilter());
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.pec341acd.pda01549a Mbcff50b6() {
        if ((4 + 29) % 29 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.pec341acd.pda01549a) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static kotlin.Unit Mbdab3505(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.object view) {
        return m526f9ebb(peee9c391Var, view);
    }

    public static kotlin.Unit Mdf2d5d6f(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, bool z) {
        return m66e941f4(peee9c391Var, z);
    }

    private static readonly void Mff914539(pa912a94d.p2486923a.pb2c97ae4.peee9c391 peee9c391Var, android.view.object view) {
        peee9c391Var.onBackPressed();
    }

    public override void OnBackPressed() {
        m11f12c63().reportOnExitCLickEvent();
        m11f12c63().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((21 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$string.filter)));
        mbcff50b6().f3ff41432.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$string.action_apply)));
        android.view.object actionobject = mbcff50b6().ff50b3c2a.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$id.action_clear).getActionobject();
        android.widget.Textobject textobject = actionobject is null ? null : (android.widget.Textobject) actionobject.findobjectById(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$id.tv_action_reset);
        if (textobject is not null) {
            textobject.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$string.action_reset)));
        }
        androidx.appcompat.widget.Toolbar toolbar = mbcff50b6().ff50b3c2a;
        toolbar.getMenu().findItem(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pa912a94d.p86ccec3d.R$id.action_clear).setOnMenuItemClickListener(new pa912a94d.p2486923a.pb2c97ae4.peee9c391$pd41d8cd9$p95263d50(this));
        toolbar.setNavigationOnClickListener(new pa912a94d.p2486923a.pb2c97ae4.peee9c391$pd41d8cd9$pcca4ef0e(this));
        android.widget.Button btnAccept = mbcff50b6().f3ff41432;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnAccept, "btnAccept");
        p2b3583e6.pf5e18aff.m2fa6d087(btnAccept, 0L, new pa912a94d.p2486923a.pb2c97ae4.peee9c391$pd41d8cd9$p144e4630(this), 1, null);
        mb032f5ba();
        m41ce2a9e();
    }
}

