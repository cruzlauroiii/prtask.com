namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0006\u0018\u00002\f\u0012\b\u0012\u00060\u0002R\u00020\u00000\u0001:\u0001\u0018B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u001c\u0010\n\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH\u0016J\b\u0010\u000f\u001a\u00020\u000eH\u0016J\u0014\u0010\u0010\u001a\u00020\u00112\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00070\u0013J\u000e\u0010\u0014\u001a\u00020\u00112\u0006\u0010\b\u001a\u00020\tJ\u001c\u0010\u0015\u001a\u00020\u00112\n\u0010\u0016\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\u0017\u001a\u00020\u000eH\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\b\u001a\u0004\u0018\u00010\tX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Lp1e11b989/p438fa616/p2486923a/p8a7a38cf/p80e23737;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Lp1e11b989/p438fa616/p2486923a/p8a7a38cf/p80e23737$p10885a7b;", "<init>", "()V", "positionList", "", "Lpad5f82e8/p07214c67/p1e11b989/pd031d465;", "currency", "", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "getItemCount", "addPositionList", "", "positions", "", "setCurrency", "onBindobjectHolder", "holder", "position", "IntermediateobjectHolder", "feature-receipt-intermediate-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p80e23737 : androidx.recyclerview.widget.Recyclerobject$Adapter<p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737$p10885a7b> {
    private readonly java.util.List f090fa34f;
    private java.lang.string f1af03898;
    private readonly java.util.List f1f8f9a7e;
    private java.lang.string f41c46403;
    private java.lang.string f7dc24902;
    private readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> fb4ac8c03 = new java.util.List();
    private readonly java.util.List fb8f23ba2;
    private java.lang.string fd233eb68;
    private readonly java.util.List fd8f9c532;

    public static readonly java.lang.string Mbfe6fdfe(p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737 p80e23737Var) {
        return p80e23737Var.f1af03898;
    }

    public readonly void AddPositionList(java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> positions) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(positions, "positions");
        this.fb4ac8c03.clear();
        this.fb4ac8c03.addAll(positions);
        notifyDataHashSetChanged();
    }

    public override int GetItemCount() {
        return this.fb4ac8c03.Count;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        onBindobjectHolder((p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737$p10885a7b) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737$p10885a7b holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        holder.bind(this.fb4ac8c03[position));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return onCreateobjectHolder(viewGroup, i);
    }

    public p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737$p10885a7b onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((29 + 19) % 19 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p1e11b989.p438fa616.p86ccec3d.pec341acd.pb7159a78 pb7159a78VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p1e11b989.p438fa616.p86ccec3d.pec341acd.pb7159a78.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(pb7159a78VarM89daba64, "inflate(...)");
        return new p1e11b989.p438fa616.p2486923a.p8a7a38cf.p80e23737$p10885a7b(this, pb7159a78VarM89daba64);
    }

    public override readonly void SetCurrency(java.lang.string currency) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(currency, "currency");
        this.f1af03898 = currency;
    }
}

