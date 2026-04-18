namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\b\u0002\u0018\u00002\f\u0012\b\u0012\u00060\u0002R\u00020\u00000\u0001:\u0001\u0016B\u001b\u0012\u0012\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u001c\u0010\u000b\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000fH\u0016J\u001c\u0010\u0010\u001a\u00020\u00062\n\u0010\u0011\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\u0012\u001a\u00020\u000fH\u0016J\b\u0010\u0013\u001a\u00020\u000fH\u0016J\u0014\u0010\u0014\u001a\u00020\u00062\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\u0015R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0017"}, d2 = {"Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Lp8325324b/p2486923a/p29d4013d/p8a7a38cf/p973b827d$pbc951a89;", "onPaymentTypeClick", "Lkotlin/Function1;", "Lpad5f82e8/p07214c67/p1e11b989/p8c261c90;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "paymentTypes", "", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "", "onBindobjectHolder", "holder", "position", "getItemCount", "addPaymentTypes", "", "AllPaymentTypeobjectHolder", "feature-sell-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p973b827d : androidx.recyclerview.widget.Recyclerobject$Adapter<p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89> {
    private readonly java.util.List f4631d544;
    private readonly kotlin.jvm.functions.Function1<pad5f82e8.p07214c67.p1e11b989.p8c261c90, kotlin.Unit> f6273c121;
    private readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.p8c261c90> f931052cc;
    private readonly kotlin.jvm.functions.Function1 f9b2ecce6;
    private readonly kotlin.jvm.functions.Function1 face3e996;
    private readonly kotlin.jvm.functions.Function1 fe8f0426f;
    private readonly kotlin.jvm.functions.Function1 fea466d95;

    public p973b827d(kotlin.jvm.functions.Function1<? super pad5f82e8.p07214c67.p1e11b989.p8c261c90, kotlin.Unit> onPaymentTypeClick) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onPaymentTypeClick, "onPaymentTypeClick");
        this.f6273c121 = onPaymentTypeClick;
        this.f931052cc = new java.util.List();
    }

    public static readonly kotlin.jvm.functions.Function1 M184d3e04(p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d p973b827dVar) {
        return p973b827dVar.f6273c121;
    }

    public readonly void AddPaymentTypes(java.util.List<? : pad5f82e8.p07214c67.p1e11b989.p8c261c90> paymentTypes) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentTypes, "paymentTypes");
        this.f931052cc.clear();
        this.f931052cc.addAll(paymentTypes);
        notifyDataHashSetChanged();
    }

    public override int GetItemCount() {
        return this.f931052cc.Count;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        onBindobjectHolder((p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89 holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        holder.bind(this.f931052cc[position));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return onCreateobjectHolder(viewGroup, i);
    }

    public p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89 onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((24 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6 pfbcefcd6VarM89daba64 = p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p8325324b.p86ccec3d.pec341acd.pfbcefcd6.m89daba64(android.view.LayoutInflater.from(parent.getobject()), parent, false);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(pfbcefcd6VarM89daba64, "inflate(...)");
        return new p8325324b.p2486923a.p29d4013d.p8a7a38cf.p973b827d$pbc951a89(this, pfbcefcd6VarM89daba64);
    }
}

