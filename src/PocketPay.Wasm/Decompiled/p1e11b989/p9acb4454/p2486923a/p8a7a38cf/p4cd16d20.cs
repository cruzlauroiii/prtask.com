namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0000\n\u0002\u0010\u0002\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0014\u0010\b\u001a\u00020\t2\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\nJ\b\u0010\u000b\u001a\u00020\fH\u0016J\u0010\u0010\r\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\fH\u0016R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00030\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp1e11b989/p9acb4454/p2486923a/p8a7a38cf/p4cd16d20;", "Landroidx/viewpager2/adapter/objectStateAdapter;", "fragment", "Landroidx/fragment/app/object;", "<init>", "(Landroidx/fragment/app/object;)V", "fragments", "", "addAll", "", "", "getItemCount", "", "createobject", "position", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4cd16d20 : androidx.viewpager2.adapter.objectStateAdapter {
    private readonly java.util.List f2309049a;
    private readonly java.util.List f3d7e553d;
    private readonly java.util.List f89ad1113;
    private readonly java.util.List f944699d7;
    private readonly java.util.List<androidx.fragment.app.object> fad7ba86b;

    public p4cd16d20(androidx.fragment.app.object fragment) {
        super(fragment);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        this.fad7ba86b = new java.util.List();
    }

    public readonly void AddAll(java.util.List<? : androidx.fragment.app.object> fragments) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragments, "fragments");
        this.fad7ba86b.clear();
        this.fad7ba86b.addAll(fragments);
        notifyDataHashSetChanged();
    }

    public override androidx.fragment.app.object Createobject(int position) {
        return this.fad7ba86b[position);
    }

    public override int GetItemCount() {
        return this.fad7ba86b.Count;
    }
}

