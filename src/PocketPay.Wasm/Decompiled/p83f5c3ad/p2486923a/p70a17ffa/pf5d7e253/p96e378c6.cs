namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp83f5c3ad/p2486923a/p70a17ffa/pf5d7e253/p96e378c6;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "tophBusinessOrderobjectModel", "Lp83f5c3ad/p2486923a/p70a17ffa/pf5d7e253/pc8c4b5e7;", "getTophBusinessOrderobjectModel", "()Lp83f5c3ad/p2486923a/p70a17ffa/pf5d7e253/pc8c4b5e7;", "tophBusinessOrderobjectModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pd55a3b4a;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pd55a3b4a;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p96e378c6 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy tophBusinessOrderobjectModel;

    static {
        if ((11 + 8) % 8 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6.class, com.decryptstringmanager.Decryptstring.decryptstring("de4452ed92915826abd8b36f34d72fe727e9466b4a9333576f8888a63ddf268013641a"), com.decryptstringmanager.Decryptstring.decryptstring("a0d5170b3ac4460c61cd47aa126cd3066a7783822dcb85abc1fa0e1294b11598421c9240908ede544b3ffcf6686eaf24beb0be1375292dc13108ec1f01228f4a436eb873674415ce7aa3e8637bacb1f69c7eca99730190c18a9c6b27a267f743aacde23855163ca397405a6f546b170ebb997ef01dd2dd20f6275e"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p96e378c6() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_business_order);
        if ((1 + 32) % 32 > 0) {
        }
        p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var = this;
        this.tophBusinessOrderobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p96e378c6Var, null, new p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p96e378c6Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p96e378c6Var, p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$p001a249d$2.f76425f17);
    }

    private static readonly kotlin.Unit M02b9d5e1(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p96e378c6Var.mf3eaaa5a().openCreateOrderScreen();
        return kotlin.Unit.INSTANCE;
    }

    public static void M23e5c42f(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object view) {
        m9dd52507(p96e378c6Var, view);
    }

    public static kotlin.Unit M243e5593(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object view) {
        return m5b94f250(p96e378c6Var, view);
    }

    private static readonly kotlin.Unit M5b94f250(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p96e378c6Var.mf3eaaa5a().openTophActivationScreen();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M80335330(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object view) {
        return m02b9d5e1(p96e378c6Var, view);
    }

    private static readonly void M9dd52507(p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6 p96e378c6Var, android.view.object view) {
        p96e378c6Var.onBackPressed();
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pd55a3b4a Mbcff50b6() {
        if ((5 + 5) % 5 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pd55a3b4a) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.pc8c4b5e7 Mf3eaaa5a() {
        return (p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.pc8c4b5e7) this.tophBusinessOrderobjectModel.getValue();
    }

    public override void OnBackPressed() {
        mf3eaaa5a().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((20 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pd55a3b4a pd55a3b4aVarMbcff50b6 = mbcff50b6();
        pd55a3b4aVarMbcff50b6.ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_title)));
        pd55a3b4aVarMbcff50b6.fad65a293.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_business_order_title)));
        pd55a3b4aVarMbcff50b6.f464e32aa.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_business_order_subtitle)));
        pd55a3b4aVarMbcff50b6.fef07e821.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_business_order_button_create_order)));
        pd55a3b4aVarMbcff50b6.ff76a171c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_business_order_button_activation)));
        pd55a3b4aVarMbcff50b6.ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$pd41d8cd9$p95263d50(this));
        android.widget.Button btnTophCreateOrder = pd55a3b4aVarMbcff50b6.fef07e821;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTophCreateOrder, "btnTophCreateOrder");
        p2b3583e6.pf5e18aff.m2fa6d087(btnTophCreateOrder, 0L, new p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.Textobject btnTophActivation = pd55a3b4aVarMbcff50b6.ff76a171c;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTophActivation, "btnTophActivation");
        p2b3583e6.pf5e18aff.m2fa6d087(btnTophActivation, 0L, new p83f5c3ad.p2486923a.p70a17ffa.pf5d7e253.p96e378c6$pd41d8cd9$p144e4630(this), 1, null);
    }
}

