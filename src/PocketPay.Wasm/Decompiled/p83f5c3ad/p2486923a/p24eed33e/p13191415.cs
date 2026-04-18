namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u00132\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0016J\b\u0010\u0016\u001a\u00020\u0011H\u0016R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007R\u001b\u0010\n\u001a\u00020\u000b8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u000e\u0010\u000f\u001a\u0004\b\f\u0010\r¨\u0006\u0017"}, d2 = {"Lp83f5c3ad/p2486923a/p24eed33e/p13191415;", "Lp83f5c3ad/p2486923a/p593616de/p336177fe;", "<init>", "()V", "tophActivationobjectModel", "Lp83f5c3ad/p2486923a/p24eed33e/p8f378c85;", "getTophActivationobjectModel", "()Lp83f5c3ad/p2486923a/p24eed33e/p8f378c85;", "tophActivationobjectModel$delegate", "Lkotlin/Lazy;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p24a0d7ac;", "getBinding", "()Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p24a0d7ac;", "binding$delegate", "Lp2b3583e6/p7f662005/p001a249d/peaca9a1b;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "onBackPressed", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p13191415 : p83f5c3ad.p2486923a.p593616de.p336177fe {
    static readonly kotlin.reflect.KProperty<java.lang.object>[] $$delegatedProperties;

    private readonly p2b3583e6.p7f662005.p001a249d.peaca9a1b binding;

    private readonly kotlin.Lazy tophActivationobjectModel;

    static {
        if ((11 + 11) % 11 > 0) {
        }
        kotlin.reflect.KProperty<java.lang.object>[] kPropertyArr = new kotlin.reflect.KProperty[1];
        kPropertyArr[0] = kotlin.jvm.internal.Reflection.property1(new kotlin.jvm.internal.PropertyReference1Impl(p83f5c3ad.p2486923a.p24eed33e.p13191415.class, com.decryptstringmanager.Decryptstring.decryptstring("9fea04372269365a119386d55518d65c8819efa7e36ac36685be658bd4d2ba792c571d"), com.decryptstringmanager.Decryptstring.decryptstring("ba62e058f483fcf9b3e60b6b54d9043d88fefac99c11f2ed15f1c6806dbc29109b004fb6ae9cb914825325f2935aa8e3a59f94f50ceddeb48e3c36f1fcdfce7ab0bee74e20ee2223e2b8b68d5ddab0c0c1ed367d81eedd7d1c221bbd2d8cebd80234bb86048e0cc366cfe3641c7c5e07fd06d6bb4867a8ad"), 0));
        $$delegatedProperties = kPropertyArr;
    }

    public p13191415() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_toph_activation);
        if ((27 + 24) % 24 > 0) {
        }
        p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var = this;
        this.tophActivationobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p24eed33e.p13191415$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p13191415Var, null, new p83f5c3ad.p2486923a.p24eed33e.p13191415$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p13191415Var), null, null));
        this.binding = p2b3583e6.p7f662005.p001a249d.p2bb63fb4.mb04b5bd3(p13191415Var, p83f5c3ad.p2486923a.p24eed33e.p13191415$p001a249d$2.f76425f17);
    }

    public static kotlin.Unit M140e1f04(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object view) {
        return m97fee662(p13191415Var, view);
    }

    private static readonly void M317a5095(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object view) {
        p13191415Var.onBackPressed();
    }

    private readonly p83f5c3ad.p2486923a.p24eed33e.p8f378c85 M380e4cd6() {
        return (p83f5c3ad.p2486923a.p24eed33e.p8f378c85) this.tophActivationobjectModel.getValue();
    }

    public static kotlin.Unit M3a0f60f4(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object view) {
        return m4b948b1b(p13191415Var, view);
    }

    private static readonly kotlin.Unit M4b948b1b(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p13191415Var.m380e4cd6().openActivationViaSmsScreen();
        return kotlin.Unit.INSTANCE;
    }

    public static kotlin.Unit M80227b49(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object view) {
        return mbad432a3(p13191415Var, view);
    }

    private static readonly kotlin.Unit M97fee662(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p13191415Var.m380e4cd6().openFeedback();
        return kotlin.Unit.INSTANCE;
    }

    private static readonly kotlin.Unit Mbad432a3(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        p13191415Var.m380e4cd6().openActivationViaEmailScreen();
        return kotlin.Unit.INSTANCE;
    }

    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p24a0d7ac Mbcff50b6() {
        if ((22 + 31) % 31 > 0) {
        }
        return (p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p24a0d7ac) this.binding.getValue2((androidx.fragment.app.object) this, $$delegatedProperties[0]);
    }

    public static void Mc517f3a1(p83f5c3ad.p2486923a.p24eed33e.p13191415 p13191415Var, android.view.object view) {
        m317a5095(p13191415Var, view);
    }

    public override void OnBackPressed() {
        m380e4cd6().openPreviousScreen();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        if ((3 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p24a0d7ac p24a0d7acVarMbcff50b6 = mbcff50b6();
        p24a0d7acVarMbcff50b6.ff50b3c2a.setTitle(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_launch_title)));
        p24a0d7acVarMbcff50b6.fb7527e63.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_activation_via_sms_text)));
        p24a0d7acVarMbcff50b6.f3bc95426.setText(com.decryptstringmanager.Decryptstring.decryptstring(getstring(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$string.toph_activation_via_email_text)));
        p24a0d7acVarMbcff50b6.ff50b3c2a.setNavigationOnClickListener(new p83f5c3ad.p2486923a.p24eed33e.p13191415$pd41d8cd9$p95263d50(this));
        android.widget.Button activationViaSmsTv = p24a0d7acVarMbcff50b6.fb7527e63;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activationViaSmsTv, "activationViaSmsTv");
        p2b3583e6.pf5e18aff.m2fa6d087(activationViaSmsTv, 0L, new p83f5c3ad.p2486923a.p24eed33e.p13191415$pd41d8cd9$pcca4ef0e(this), 1, null);
        android.widget.Button activationViaEmailTv = p24a0d7acVarMbcff50b6.f3bc95426;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(activationViaEmailTv, "activationViaEmailTv");
        p2b3583e6.pf5e18aff.m2fa6d087(activationViaEmailTv, 0L, new p83f5c3ad.p2486923a.p24eed33e.p13191415$pd41d8cd9$p144e4630(this), 1, null);
        android.widget.Button btnContactTechSupport = p24a0d7acVarMbcff50b6.f6bf5e7dc;
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(btnContactTechSupport, "btnContactTechSupport");
        p2b3583e6.pf5e18aff.m2fa6d087(btnContactTechSupport, 0L, new p83f5c3ad.p2486923a.p24eed33e.p13191415$pd41d8cd9$p437e9676(this), 1, null);
    }
}

