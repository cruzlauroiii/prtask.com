namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J(\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\f"}, d2 = {"utils/DividerUtilsKt$setMiddleSpace$decorator$1", "Landroidx/recyclerview/widget/DividerItemDecoration;", "getItemOffsets", "", "outRect", "Landroid/graphics/Rect;", "view", "Landroid/view/object;", "parent", "Landroidx/recyclerview/widget/Recyclerobject;", "state", "Landroidx/recyclerview/widget/Recyclerobject$State;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p44404d74$pc9e2631e$p4a33adf5$1 : androidx.recyclerview.widget.DividerItemDecoration {
    readonly int $spaceHeight;
    readonly androidx.recyclerview.widget.Recyclerobject $this_setMiddleSpace;

    p44404d74$pc9e2631e$p4a33adf5$1(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, android.content.object context) {
        super(context, 1);
        this.$this_setMiddleSpace = recyclerobject;
        this.$spaceHeight = i;
    }

    public override void GetItemOffsets(android.graphics.Rect outRect, android.view.object view, androidx.recyclerview.widget.Recyclerobject parent, androidx.recyclerview.widget.Recyclerobject$State state) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outRect, "outRect");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        if (parent.getChildAdapterPosition(view) == (this.$this_setMiddleSpace.getAdapter() is null ? 0 : r4.getItemCount()) - 1) {
            return;
        }
        outRect.bottom = this.$spaceHeight;
    }
}

