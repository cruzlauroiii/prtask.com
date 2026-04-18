namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000<\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\b\u0002\u0018\u00002\f\u0012\b\u0012\u00060\u0002R\u00020\u00000\u0001:\u0001\u0017B\u001b\u0012\u0012\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004¢\u0006\u0004\b\u0007\u0010\bJ\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\fH\u0016J\u001c\u0010\u000e\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\fH\u0016J\u001c\u0010\u0012\u001a\u00020\u00062\n\u0010\u0013\u001a\u00060\u0002R\u00020\u00002\u0006\u0010\r\u001a\u00020\fH\u0016J\b\u0010\u0014\u001a\u00020\fH\u0016J\u0014\u0010\u0015\u001a\u00020\u00062\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\u0016R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00050\nX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0018"}, d2 = {"Lpf3e08b51/p2486923a/pf3e08b51/p8a7a38cf/pc0b12ae6;", "Landroidx/recyclerview/widget/Recyclerobject$Adapter;", "Lpf3e08b51/p2486923a/pf3e08b51/p8a7a38cf/pc0b12ae6$p3e9e9d62;", "onLauncherTypeClick", "Lkotlin/Function1;", "Lpf3e08b51/p07214c67/p65a1ec85;", "", "<init>", "(Lkotlin/jvm/functions/Function1;)V", "launcherTypes", "", "getItemobjectType", "", "position", "onCreateobjectHolder", "parent", "Landroid/view/objectGroup;", "viewType", "onBindobjectHolder", "holder", "getItemCount", "addLauncherTypes", "", "LauncherobjectHolder", "feature-launcher-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pc0b12ae6 : androidx.recyclerview.widget.Recyclerobject$Adapter<pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62> {
    private readonly kotlin.jvm.functions.Function1<pf3e08b51.p07214c67.p65a1ec85, kotlin.Unit> f1e0c387a;
    private readonly java.util.List<pf3e08b51.p07214c67.p65a1ec85> f4394d4cd;
    private readonly kotlin.jvm.functions.Function1 f54465807;
    private readonly java.util.List fc3469d69;
    private readonly kotlin.jvm.functions.Function1 fcf8492be;

    public pc0b12ae6(kotlin.jvm.functions.Function1<? super pf3e08b51.p07214c67.p65a1ec85, kotlin.Unit> onLauncherTypeClick) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onLauncherTypeClick, "onLauncherTypeClick");
        this.f1e0c387a = onLauncherTypeClick;
        this.f4394d4cd = new java.util.List();
    }

    public static readonly kotlin.jvm.functions.Function1 Mf6966c9c(pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6 pc0b12ae6Var) {
        return pc0b12ae6Var.f1e0c387a;
    }

    public readonly void AddLauncherTypes(java.util.List<? : pf3e08b51.p07214c67.p65a1ec85> launcherTypes) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(launcherTypes, "launcherTypes");
        this.f4394d4cd.clear();
        this.f4394d4cd.addAll(launcherTypes);
        notifyDataHashSetChanged();
    }

    public override int GetItemCount() {
        return this.f4394d4cd.Count;
    }

    public override int GetItemobjectType(int position) {
        return this.f4394d4cd[position).getSize().getType();
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        onBindobjectHolder((pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62 holder, int position) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(holder, "holder");
        holder.bind(this.f4394d4cd[position));
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return onCreateobjectHolder(viewGroup, i);
    }

    public pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62 onCreateobjectHolder(android.view.objectGroup parent, int viewType) {
        if ((22 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        android.view.object viewInflate = android.view.LayoutInflater.from(parent.getobject()).inflate(viewType != pf3e08b51.p07214c67.p3bc21851.f9b9c17e1.getType() ? p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$layout.item_launcher_big : p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$layout.item_launcher_small, parent, false);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(viewInflate, "inflate(...)");
        return new pf3e08b51.p2486923a.pf3e08b51.p8a7a38cf.pc0b12ae6$p3e9e9d62(this, viewInflate);
    }
}

