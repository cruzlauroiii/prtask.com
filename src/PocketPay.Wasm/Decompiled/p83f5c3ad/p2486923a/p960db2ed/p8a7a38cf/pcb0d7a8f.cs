namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001B\u001b\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\u0018\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0018\u0010\u000e\u001a\u00020\u00062\u0006\u0010\u000f\u001a\u00020\u00032\u0006\u0010\u0010\u001a\u00020\rH\u0016R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp83f5c3ad/p2486923a/p960db2ed/p8a7a38cf/pcb0d7a8f;", "Landroidx/recyclerview/widget/ListAdapter;", "Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "Lp83f5c3ad/p2486923a/p960db2ed/p8a7a38cf/p58c5dbdb;", "onRegionClick", "Lkotlin/Function1;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "onBindobjectHolder", "holder", "position", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcb0d7a8f : androidx.recyclerview.widget.ListAdapter<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85, p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb> {
    private readonly kotlin.jvm.functions.Function1<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85, kotlin.Unit> f1ea6370b;
    private readonly kotlin.jvm.functions.Function1 f8052f887;

    public pcb0d7a8f(kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p83f5c3ad.pf447ac85, kotlin.Unit> onRegionClick) {
        super(p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.pba003473.f76425f17);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onRegionClick, "onRegionClick");
        this.f1ea6370b = onRegionClick;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        onBindobjectHolder((p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var = getCurrentList()[position);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(pf447ac85Var, "get(...)");
        holder.bind(pf447ac85Var);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return onCreateobjectHolder(viewGroup, i);
    }

    public override p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb OnCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((22 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p296b20b3 p296b20b3VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p518a4861.p83f5c3ad.p86ccec3d.pec341acd.p296b20b3.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(p296b20b3VarM89daba64, "inflate(...)");
        return new p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.p58c5dbdb(p296b20b3VarM89daba64, this.f1ea6370b);
    }
}

