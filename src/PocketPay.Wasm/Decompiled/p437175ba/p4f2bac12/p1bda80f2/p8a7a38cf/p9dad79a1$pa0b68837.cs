namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0004\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u0018\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0016J\u0018\u0010\t\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\u00022\u0006\u0010\b\u001a\u00020\u0002H\u0016¨\u0006\n"}, d2 = {"Lp437175ba/p4f2bac12/p1bda80f2/p8a7a38cf/p9dad79a1$pa0b68837;", "Landroidx/recyclerview/widget/DiffUtil$ItemCallback;", "Landroid/graphics/Bitmap;", "<init>", "()V", "areItemsTheSame", "", "oldItem", "newItem", "areContentsTheSame", "feature-pdf-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p9dad79a1$pa0b68837 : androidx.recyclerview.widget.DiffUtil$ItemCallback<android.graphics.Bitmap> {
    public bool AreContentsTheSame2(android.graphics.Bitmap oldItem, android.graphics.Bitmap newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        return oldItem.sameAs(newItem);
    }

    public override bool AreContentsTheSame(android.graphics.Bitmap bitmap, android.graphics.Bitmap bitmap2) {
        return areContentsTheSame2(bitmap, bitmap2);
    }

    public bool AreItemsTheSame2(android.graphics.Bitmap oldItem, android.graphics.Bitmap newItem) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(oldItem, "oldItem");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(newItem, "newItem");
        return oldItem == newItem;
    }

    public override bool AreItemsTheSame(android.graphics.Bitmap bitmap, android.graphics.Bitmap bitmap2) {
        return areItemsTheSame2(bitmap, bitmap2);
    }
}

