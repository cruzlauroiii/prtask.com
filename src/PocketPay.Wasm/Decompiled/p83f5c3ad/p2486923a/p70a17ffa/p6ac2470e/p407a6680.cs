namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp83f5c3ad/p2486923a/p70a17ffa/p6ac2470e/p407a6680;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "tophCashierOrderobjectModel", "Lp83f5c3ad/p2486923a/p70a17ffa/p6ac2470e/pb0260289;", "getTophCashierOrderobjectModel", "()Lp83f5c3ad/p2486923a/p70a17ffa/p6ac2470e/pb0260289;", "tophCashierOrderobjectModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pf89846ff;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/pf89846ff;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p407a6680 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy tophCashierOrderobjectModel;

    static {
        if ((30 + 12) % 12 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680.class, com.decryptstringmanager.Decryptstring.decryptstring("5ccb9b03d0baf12bd5f2ea657266a175e5734bde7260a855014bf8d100663951f027f4"), com.decryptstringmanager.Decryptstring.decryptstring("b2ae5c748a8f365e131b7d5641b77e29977b47be0384656ab136996b6762606bd2c430836111e36693037ba037412c533b321a6f9601a9720eab709b30ea52c2d0f7481f7c4f86e04dca35adb00ce1e9c66d79c2a9151c1f265bc36ea581a860e36ad5087d1b6e387117ec9e15dae15aaf255742173362a3c834"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p407a6680() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_cashier_order);
        if ((17 + 23) % 23 > 0) {
        }
        p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680 p407a6680Var = this;
        this.tophCashierOrderobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p407a6680Var, null, new p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p407a6680Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p407a6680Var, p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680$p001a249d$2.f76425f17);
    }

    private static readonly void M2eaf0180(p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680 p407a6680Var, android.view.object view) {
        p407a6680Var.onBackPressed();
    }

    public static void M7bf16018(p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680 p407a6680Var, android.view.object view) {
        m2eaf0180(p407a6680Var, view);
    }

    public static kotlin.Unit M853f81fa(p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680 p407a6680Var, android.view.object view) {
        return mff914539(p407a6680Var, view);
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pf89846ff Mbcff50b6() {
        if ((8 + 4) % 4 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pf89846ff) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    private readonly p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.pb0260289 Me26d646b() {
        return (p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.pb0260289) this.tophCashierOrderobjectModel.getValue();
    }

    private static readonly kotlin.Unit Mff914539(p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680 p407a6680Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p407a6680Var.me26d646b().openTophActivationScreen();
        return kotlin.Unit.INSTANCE;
    }

    public override void OnBackPressed() {
        me26d646b().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((28 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.pf89846ff pf89846ffVarMbcff50b6 = mbcff50b6();
        pf89846ffVarMbcff50b6.ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_title)));
        pf89846ffVarMbcff50b6.fad65a293.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_cashier_order_title)));
        pf89846ffVarMbcff50b6.f464e32aa.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_cashier_order_subtitle)));
        pf89846ffVarMbcff50b6.ff76a171c.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_cashier_order_button_activation)));
        pf89846ffVarMbcff50b6.ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680$pd41d8cd9$p95263d50(this));
        android.widget.Textobject btnTophActivation = pf89846ffVarMbcff50b6.ff76a171c;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnTophActivation, "btnTophActivation");
        p2b3583e6.pf5e18aff.m2fa6d087(btnTophActivation, 0L, new p83f5c3ad.p2486923a.p70a17ffa.p6ac2470e.p407a6680$pd41d8cd9$pcca4ef0e(this), 1, null);
    }
}

