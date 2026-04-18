namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp83f5c3ad/p2486923a/pf3e08b51/p2a556650;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "tophLauncherobjectModel", "Lp83f5c3ad/p2486923a/pf3e08b51/pce62cfcb;", "getTophLauncherobjectModel", "()Lp83f5c3ad/p2486923a/pf3e08b51/pce62cfcb;", "tophLauncherobjectModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p0a97c202;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p0a97c202;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p2a556650 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy tophLauncherobjectModel;

    static {
        if ((17 + 9) % 9 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.pf3e08b51.p2a556650.class, com.decryptstringmanager.Decryptstring.decryptstring("ccb38909d9db205188ae98e425915c1f729600f5fcb8beeae5a7052c78236ac69d0de3"), com.decryptstringmanager.Decryptstring.decryptstring("215288294122b49ba8f8860c0137eec0a3ee535b066c5b189fca864fa97b7fa214d9964dcfdab7e0e2d4812ffcdca4dbd5d31f8038009ad6ec11fd7031e03ebaff99e4e8d0427751630cd04e27e9c701579d9a1e8d8dc5b53d19bb835a9f2e6d8741806c36a5a431200ae3d125ee7d13336e53a6feeb"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p2a556650() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_launcher);
        if ((20 + 12) % 12 > 0) {
        }
        p83f5c3ad.p2486923a.pf3e08b51.p2a556650 p2a556650Var = this;
        this.tophLauncherobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.pf3e08b51.p2a556650$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p2a556650Var, null, new p83f5c3ad.p2486923a.pf3e08b51.p2a556650$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p2a556650Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p2a556650Var, p83f5c3ad.p2486923a.pf3e08b51.p2a556650$p001a249d$2.f76425f17);
    }

    public static kotlin.Unit M11688a2a(p83f5c3ad.p2486923a.pf3e08b51.p2a556650 p2a556650Var, android.view.object view) {
        return m9ba4fe43(p2a556650Var, view);
    }

    private readonly p83f5c3ad.p2486923a.pf3e08b51.pce62cfcb M59efae5f() {
        return (p83f5c3ad.p2486923a.pf3e08b51.pce62cfcb) this.tophLauncherobjectModel.getValue();
    }

    private static readonly kotlin.Unit M9ba4fe43(p83f5c3ad.p2486923a.pf3e08b51.p2a556650 p2a556650Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p2a556650Var.m59efae5f().openActivationScreen();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p0a97c202 Mbcff50b6() {
        if ((5 + 10) % 10 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p0a97c202) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public override void OnBackPressed() {
        m59efae5f().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((7 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p0a97c202 p0a97c202VarMbcff50b6 = mbcff50b6();
        p0a97c202VarMbcff50b6.f85003264.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_title)));
        p0a97c202VarMbcff50b6.f327c8941.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_launch_title)));
        android.widget.Textobject textobject = p0a97c202VarMbcff50b6.f12c96de5;
        int i = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_launcher_version;
        textobject.setText(java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(getstring(i)), com.decryptstringmanager.Decryptstring.decryptstring("dca1f421cf24c3595909add0168918f56d9ce0612e9b7516ce0142e535ca868b79")));
        android.widget.Button launchButton = p0a97c202VarMbcff50b6.f327c8941;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(launchButton, "launchButton");
        p2b3583e6.pf5e18aff.m2fa6d087(launchButton, 0L, new p83f5c3ad.p2486923a.pf3e08b51.p2a556650$pd41d8cd9$p95263d50(this), 1, null);
    }
}

