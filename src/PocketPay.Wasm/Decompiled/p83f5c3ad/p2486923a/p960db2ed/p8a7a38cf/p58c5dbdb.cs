namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\u0018\u00002\u00020\u0001B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0004\b\b\u0010\tJ\u000e\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\u0006R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp83f5c3ad/p2486923a/p960db2ed/p8a7a38cf/p58c5dbdb;", "Landroidx/recyclerview/widget/Recyclerobject$objectHolder;", "binding", "Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p296b20b3;", "onRegionClick", "Lkotlin/Function1;", "Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "", "<init>", "(Lp4d236d9a/p2df4812c/pf5d7e253/p518a4861/p83f5c3ad/p86ccec3d/pec341acd/p296b20b3;Lkotlin/jvm/functions/Function1;)V", "bind", "region", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p58c5dbdb : androidx.recyclerview.widget.Recyclerobject$objectHolder {
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p296b20b3 f001a249d;
    private readonly kotlin.jvm.functions.Function1 f0de522c5;
    private readonly kotlin.jvm.functions.Function1<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85, kotlin.Unit> f1ea6370b;
    private readonly kotlin.jvm.functions.Function1 f44d60e1c;
    private readonly p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p296b20b3 f4f87a6b0;

    public p58c5dbdb(p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p296b20b3 binding, kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p83f5c3ad.pf447ac85, kotlin.Unit> onRegionClick) {
        super(binding.getRoot());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(binding, "binding");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onRegionClick, "onRegionClick");
        this.f001a249d = binding;
        this.f1ea6370b = onRegionClick;
    }

    public static void M6c0e3644(p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb p58c5dbdbVar, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var, android.view.object view) {
        mac7fcf5d(p58c5dbdbVar, pf447ac85Var, view);
    }

    private static readonly void Mac7fcf5d(p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb p58c5dbdbVar, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var, android.view.object view) {
        p58c5dbdbVar.f1ea6370b.invoke(pf447ac85Var);
    }

    public readonly void Bind(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 region) {
        if ((19 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(region, "region");
        android.widget.Textobject root = this.f001a249d.getRoot();
        root.setText(region.getName());
        root.setOnClickListener(new p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb$pd41d8cd9$p95263d50(this, region));
    }
}

