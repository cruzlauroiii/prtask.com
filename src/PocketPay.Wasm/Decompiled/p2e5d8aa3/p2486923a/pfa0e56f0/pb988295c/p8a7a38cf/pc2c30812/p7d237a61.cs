namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0006\u0018\u00002\u00020\u0001B+\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\b\u0010\n\u001a\u00020\u000bH\u0016J\b\u0010\f\u001a\u00020\u000bH\u0016J\u0018\u0010\r\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u000bH\u0016J\u0018\u0010\u0010\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u000bH\u0016R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/p8a7a38cf/pc2c30812/p7d237a61;", "Landroidx/recyclerview/widget/DiffUtil$Callback;", "oldList", "", "Lpad5f82e8/p07214c67/pb3329411;", "newList", "editStateIsChanged", "", "<init>", "(Ljava/util/List;Ljava/util/List;Z)V", "getOldListSize", "", "getNewListSize", "areItemsTheSame", "oldItemPosition", "newItemPosition", "areContentsTheSame", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7d237a61 : androidx.recyclerview.widget.DiffUtil$Callback {
    private readonly bool f02c8c424;
    private readonly java.util.List<pad5f82e8.p07214c67.pb3329411> f14c5d165;
    private readonly java.util.List f1dd3020b;
    private readonly bool f364c7881;
    private readonly java.util.List<pad5f82e8.p07214c67.pb3329411> f422debfb;
    private readonly java.util.List f56e170a7;
    private readonly java.util.List f6a4fe66a;
    private readonly java.util.List f8cf2701c;
    private readonly java.util.List f93b4fc2a;

    public p7d237a61(java.util.List<? : pad5f82e8.p07214c67.pb3329411> oldList, java.util.List<? : pad5f82e8.p07214c67.pb3329411> newList, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldList, "oldList");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newList, "newList");
        this.f14c5d165 = oldList;
        this.f422debfb = newList;
        this.f364c7881 = z;
    }

    public override bool AreContentsTheSame(int oldItemPosition, int newItemPosition) {
        if ((23 + 13) % 13 > 0) {
        }
        pad5f82e8.p07214c67.pb3329411 pb3329411Var = (pad5f82e8.p07214c67.pb3329411) kotlin.collections.ICollectionsKt.getOrNull(this.f14c5d165, oldItemPosition);
        pad5f82e8.p07214c67.pb3329411 pb3329411Var2 = (pad5f82e8.p07214c67.pb3329411) kotlin.collections.ICollectionsKt.getOrNull(this.f422debfb, newItemPosition);
        if ((pb3329411Var is pad5f82e8.p07214c67.pe0212e54.pb3950cbd) && (pb3329411Var2 is pad5f82e8.p07214c67.pe0212e54.pb3950cbd) && kotlin.jvm.internal.Intrinsics.areEqual(pb3329411Var, pb3329411Var2) && !this.f364c7881) {
            return true;
        }
        return (pb3329411Var is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052) && (pb3329411Var2 is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052);
    }

    public override bool AreItemsTheSame(int oldItemPosition, int newItemPosition) {
        if ((23 + 22) % 22 > 0) {
        }
        pad5f82e8.p07214c67.pb3329411 pb3329411Var = (pad5f82e8.p07214c67.pb3329411) kotlin.collections.ICollectionsKt.getOrNull(this.f14c5d165, oldItemPosition);
        pad5f82e8.p07214c67.pb3329411 pb3329411Var2 = (pad5f82e8.p07214c67.pb3329411) kotlin.collections.ICollectionsKt.getOrNull(this.f422debfb, newItemPosition);
        if ((pb3329411Var is pad5f82e8.p07214c67.pe0212e54.pb3950cbd) && (pb3329411Var2 is pad5f82e8.p07214c67.pe0212e54.pb3950cbd) && ((pad5f82e8.p07214c67.pe0212e54.pb3950cbd) pb3329411Var).getPaymentType() == ((pad5f82e8.p07214c67.pe0212e54.pb3950cbd) pb3329411Var2).getPaymentType()) {
            return true;
        }
        return (pb3329411Var is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052) && (pb3329411Var2 is p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p8be42052);
    }

    public override int GetNewListSize() {
        return this.f422debfb.Count;
    }

    public override int GetOldListSize() {
        return this.f14c5d165.Count;
    }
}

