namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\bÆ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\u0018\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0016J\u0018\u0010\t\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0016¨\u0006\n"}, d2 = {"Lp83f5c3ad/p2486923a/p960db2ed/p8a7a38cf/pba003473;", "Landroidx/recyclerview/widget/DiffUtil$ItemCallback;", "Lpad5f82e8/p07214c67/p83f5c3ad/pf447ac85;", "<init>", "()V", "areItemsTheSame", "", "oldItem", "newItem", "areContentsTheSame", "feature-toph-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pba003473 : androidx.recyclerview.widget.DiffUtil$ItemCallback<pad5f82e8.p07214c67.p83f5c3ad.pf447ac85> {
    public static readonly p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.pba003473 f76425f17 = new p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.pba003473();
    public static readonly p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.pba003473 f8aa75ffb = null;
    public static readonly p83f5c3ad.p2486923a.p960db2ed.p8a7a38cf.pba003473 fdd1d0eeb = null;

    private pba003473() {
    }

    public override bool AreContentsTheSame(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var2) {
        return areContentsTheSame2(pf447ac85Var, pf447ac85Var2);
    }

    public bool AreContentsTheSame2(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 oldItem, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        return kotlin.jvm.internal.Intrinsics.areEqual(oldItem.getName(), newItem.getName());
    }

    public override bool AreItemsTheSame(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 pf447ac85Var2) {
        return areItemsTheSame2(pf447ac85Var, pf447ac85Var2);
    }

    public bool AreItemsTheSame2(pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 oldItem, pad5f82e8.p07214c67.p83f5c3ad.pf447ac85 newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        return oldItem.getId() == newItem.getId();
    }
}

