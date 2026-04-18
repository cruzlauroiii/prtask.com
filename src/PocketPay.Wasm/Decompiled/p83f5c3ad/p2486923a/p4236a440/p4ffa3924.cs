namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0003\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u001a\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0016J\b\u0010\u0010\u001a\u00020\u000bH\u0002J\u0012\u0010\u0011\u001a\u00020\u000b2\b\u0010\u0012\u001a\u0004\u0018\u00010\u0013H\u0002R\u001b\u0010\u0004\u001a\u00020\u00058BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\b\u0010\t\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0014"}, d2 = {"Lp83f5c3ad/p2486923a/p4236a440/p4ffa3924;", "Lp593616de/p9efab239/p0742d3f9;", "<init>", "()V", "tophConsoleoutobjectModel", "Lp83f5c3ad/p2486923a/p4236a440/p8c01482f;", "getTophConsoleoutobjectModel", "()Lp83f5c3ad/p2486923a/p4236a440/p8c01482f;", "tophConsoleoutobjectModel$delegate", "Lkotlin/Lazy;", "onobjectCreated", "", "view", "Landroid/view/object;", "savedInstanceState", "Landroid/os/Dictionary<string, object>;", "collectResetActivationState", "showError", "throwable", "", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4ffa3924 : p593616de.p9efab239.p0742d3f9 {

    private readonly kotlin.Lazy tophConsoleoutobjectModel;

    public p4ffa3924() {
        super(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.R$layout.fragment_logout);
        if ((5 + 18) % 18 > 0) {
        }
        p83f5c3ad.p2486923a.p4236a440.p4ffa3924 p4ffa3924Var = this;
        this.tophConsoleoutobjectModel = kotlin.LazyKt.lazy(kotlin.LazyThreadSafetyMode.NONE, (kotlin.jvm.functions.Function0) new p83f5c3ad.p2486923a.p4236a440.p4ffa3924$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$2(p4ffa3924Var, null, new p83f5c3ad.p2486923a.p4236a440.p4ffa3924$p0bd65069$pd41d8cd9$pec404527$p5e1cbed3$pc21f969b$1(p4ffa3924Var), null, null));
    }

    public static kotlin.Unit M1340cd16(p83f5c3ad.p2486923a.p4236a440.p4ffa3924 p4ffa3924Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        return m7ae42676(p4ffa3924Var, pa4ecfc70Var);
    }

    private readonly void M1a829e67() {
        if ((10 + 22) % 22 > 0) {
        }
        p593616de.p9efab239.pfafca1ef.m0788a692(this, m80226795().getResetActivationState(), new p83f5c3ad.p2486923a.p4236a440.p4ffa3924$pd41d8cd9$p95263d50(this));
    }

    private readonly void M269b36ee(java.lang.Exception th) {
        if ((11 + 22) % 22 > 0) {
        }
        p83f5c3ad.p2486923a.p4236a440.p4ffa3924 p4ffa3924Var = this;
        android.content.object contextRequireobject = requireobject();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(contextRequireobject, "requireobject(...)");
        p2b3583e6.pa2559025.m31049b74(p4ffa3924Var, new pad5f82e8.p07214c67.pe907423b.p1f54b646(p83f5c3ad.p684019bc.p42552b1f.p14804b31.md9ae7f57(th, contextRequireobject)), null, null, null, 0, 30, null);
    }

    private static readonly kotlin.Unit M7ae42676(p83f5c3ad.p2486923a.p4236a440.p4ffa3924 p4ffa3924Var, pad5f82e8.p07214c67.pa4ecfc70 pa4ecfc70Var) {
        if ((28 + 8) % 8 > 0) {
        }
        pad5f82e8.p07214c67.pec53a8c4 status = pa4ecfc70Var is null ? null : pa4ecfc70Var.getStatus();
        if ((status is not null ? p83f5c3ad.p2486923a.p4236a440.p4ffa3924$p12c674ac.$EnumSwitchDictionaryping$0[status.ordinal()] : -1) == 3) {
            p4ffa3924Var.m269b36ee(pa4ecfc70Var.getException());
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly p83f5c3ad.p2486923a.p4236a440.p8c01482f M80226795() {
        return (p83f5c3ad.p2486923a.p4236a440.p8c01482f) this.tophConsoleoutobjectModel.getValue();
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> savedInstanceState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        super.onobjectCreated(view, savedInstanceState);
        m1a829e67();
    }
}

