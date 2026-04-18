namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0014J\b\u0010\u0017\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0018"}, d2 = {"Lpd2a57dc1/p2486923a/p57cb773a/p9f385644;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pd2a57dc1/p86ccec3d/pec341acd/pc4801975;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p705f8913/p518a4861/pd2a57dc1/p86ccec3d/pec341acd/pc4801975;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "viewModel", "Lpd2a57dc1/p2486923a/p57cb773a/pae8d1f35;", "getobjectModel", "()Lpd2a57dc1/p2486923a/p57cb773a/pae8d1f35;", "viewModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "checkState", "onBackPressed", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9f385644 : p593616de.p9efab239.p0742d3f9 {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy viewModel;

    static {
        if ((17 + 31) % 31 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(pd2a57dc1.p2486923a.p57cb773a.p9f385644.class, com.decryptstringmanager.Decryptstring.decryptstring("6610e4257072d2f1bf89eff16a56389fd80b8555c19c025c426c2b2b3cbadee250181f"), com.decryptstringmanager.Decryptstring.decryptstring("fca375297b9516c7a6a4b506e0e02f148da2514ecf228a1e8d777ce57b5394967b2fb8b2896d3b004e6c512fb009d84013c093ffb884148669ec8e144feae911acfee31172f8b082859d8e8d132670eabea0473fd1354e2e59200461e08e8aaf5ff9f04cf5a7c2a70607d16676425d0afa7a72978032e9c1a1a6eb77e11efea80423"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p9f385644() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$layout.fragment_maintenance_mode);
        if ((15 + 26) % 26 > 0) {
        }
        pd2a57dc1.p2486923a.p57cb773a.p9f385644 p9f385644Var = this;
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p9f385644Var, pd2a57dc1.p2486923a.p57cb773a.p9f385644$p001a249d$2.f76425f17);
        this.viewModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new pd2a57dc1.p2486923a.p57cb773a.p9f385644$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p9f385644Var, null, new pd2a57dc1.p2486923a.p57cb773a.p9f385644$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p9f385644Var), null, null));
    }

    private static readonly void M22d1c681(pd2a57dc1.p2486923a.p57cb773a.p9f385644 p9f385644Var, android.view.object view) {
        p9f385644Var.onBackPressed();
    }

    private readonly pd2a57dc1.p2486923a.p57cb773a.pae8d1f35 Mac404cc3() {
        return (pd2a57dc1.p2486923a.p57cb773a.pae8d1f35) this.viewModel.getValue();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.pec341acd.pc4801975 Mbcff50b6() {
        if ((16 + 23) % 23 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.pec341acd.pc4801975) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Me7942bb5(pd2a57dc1.p2486923a.p57cb773a.p9f385644 p9f385644Var, android.view.object view) {
        m22d1c681(p9f385644Var, view);
    }

    protected override void CheckState() {
    }

    public override void OnBackPressed() {
        mac404cc3().finish();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        mbcff50b6().fccdc43f6.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.maintenance_mode_title)));
        mbcff50b6().f11f22de3.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.maintenance_mode_description)));
        mbcff50b6().fdf2490ea.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pd2a57dc1.p86ccec3d.R$string.maintenance_mode_close_app)));
        mbcff50b6().fdf2490ea.setOnClickListener(new pd2a57dc1.p2486923a.p57cb773a.p9f385644$pd41d8cd9$p95263d50(this));
        mac404cc3().checkMaintenanceMode();
    }
}

