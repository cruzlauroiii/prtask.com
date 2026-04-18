namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0017\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001J\u0018\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u0002H\u0016J\u0018\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00022\u0006\u0010\u0006\u001a\u00020\u0002H\u0016¨\u0006\b"}, d2 = {"receipt/status/presentation/adapter/ReceiptStatusesAdapter$Companion$RECEIPT_DIFFER$1", "Landroidx/recyclerview/widget/DiffUtil$ItemCallback;", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;", "areItemsTheSame", "", "oldItem", "newItem", "areContentsTheSame", "feature-receipt-status-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p025c44a5$p910eef8c$pce957f6f$1 : androidx.recyclerview.widget.DiffUtil$ItemCallback<pad5f82e8.p07214c67.p1e11b989.p55f8d305> {
    p025c44a5$p910eef8c$pce957f6f$1() {
    }

    public override bool AreContentsTheSame(pad5f82e8.p07214c67.p1e11b989.p55f8d305 p55f8d305Var, pad5f82e8.p07214c67.p1e11b989.p55f8d305 p55f8d305Var2) {
        return areContentsTheSame2(p55f8d305Var, p55f8d305Var2);
    }

    public bool AreContentsTheSame2(pad5f82e8.p07214c67.p1e11b989.p55f8d305 oldItem, pad5f82e8.p07214c67.p1e11b989.p55f8d305 newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        if ((oldItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) && (newItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4)) {
            kotlin.jvm.internal.Intrinsics.areEqual(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) oldItem).getDateTime(), ((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) newItem).getDateTime());
        }
        if (!(oldItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) || !(newItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af)) {
            return false;
        }
        kotlin.jvm.internal.Intrinsics.areEqual(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) oldItem).getReceipt().getUuid(), ((pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) newItem).getReceipt().getUuid());
        return false;
    }

    public override bool AreItemsTheSame(pad5f82e8.p07214c67.p1e11b989.p55f8d305 p55f8d305Var, pad5f82e8.p07214c67.p1e11b989.p55f8d305 p55f8d305Var2) {
        return areItemsTheSame2(p55f8d305Var, p55f8d305Var2);
    }

    public bool AreItemsTheSame2(pad5f82e8.p07214c67.p1e11b989.p55f8d305 oldItem, pad5f82e8.p07214c67.p1e11b989.p55f8d305 newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        if ((oldItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) && (newItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) && kotlin.jvm.internal.Intrinsics.areEqual(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) oldItem).getReceipt().getUuid(), ((pad5f82e8.p07214c67.p1e11b989.p55f8d305$p5d3072af) newItem).getReceipt().getUuid())) {
            return true;
        }
        return (oldItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) && (newItem is pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) && kotlin.jvm.internal.Intrinsics.areEqual(((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) oldItem).getDateTime(), ((pad5f82e8.p07214c67.p1e11b989.p55f8d305$pffe42ac4) newItem).getDateTime());
    }
}

