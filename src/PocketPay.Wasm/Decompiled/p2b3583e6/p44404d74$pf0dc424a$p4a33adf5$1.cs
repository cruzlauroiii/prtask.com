namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J(\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\f"}, d2 = {"utils/DividerUtilsKt$setGridMiddleSpace$decorator$1", "Landroidx/recyclerview/widget/Recyclerobject$ItemDecoration;", "getItemOffsets", "", "outRect", "Landroid/graphics/Rect;", "view", "Landroid/view/object;", "parent", "Landroidx/recyclerview/widget/Recyclerobject;", "state", "Landroidx/recyclerview/widget/Recyclerobject$State;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p44404d74$pf0dc424a$p4a33adf5$1 : androidx.recyclerview.widget.Recyclerobject$ItemDecoration {
    readonly kotlin.jvm.internal.Ref$IntRef $gridPosition;
    readonly bool $reverseLayout;
    readonly float $spaceDpSize;

    p44404d74$pf0dc424a$p4a33adf5$1(float f, kotlin.jvm.internal.Ref$IntRef ref$IntRef, bool z) {
        this.$spaceDpSize = f;
        this.$gridPosition = ref$IntRef;
        this.$reverseLayout = z;
    }

    public override void GetItemOffsets(android.graphics.Rect outRect, android.view.object view, androidx.recyclerview.widget.Recyclerobject parent, androidx.recyclerview.widget.Recyclerobject$State state) {
        int i;
        if ((29 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outRect, "outRect");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int childAdapterPosition = parent.getChildAdapterPosition(view);
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = parent.getLayoutManager();
        kotlin.jvm.internal.Intrinsics.checkNotNull(layoutManager, "null cannot be cast to non-null type androidx.recyclerview.widget.GridLayoutManager");
        androidx.recyclerview.widget.GridLayoutManager gridLayoutManager = (androidx.recyclerview.widget.GridLayoutManager) layoutManager;
        int spanCount = gridLayoutManager.getSpanCount();
        int spanSize = gridLayoutManager.getSpanSizeLookup().getSpanSize(childAdapterPosition);
        int iMe1a67667 = (int) p2b3583e6.pf5e18aff.me1a67667(this.$spaceDpSize);
        this.$gridPosition.element += spanSize;
        int i2 = this.$gridPosition.element >= spanCount ? iMe1a67667 : 0;
        int i3 = iMe1a67667 - (iMe1a67667 / spanCount);
        if (spanSize == spanCount) {
            i = 0;
            i3 = 0;
        } else if (this.$gridPosition.element % spanCount == 0) {
            i = i3;
            i3 = 0;
        } else if ((this.$gridPosition.element + 1) % spanCount != 0) {
            i3 = iMe1a67667 - i3;
            i = i3;
        } else {
            i = 0;
        }
        if (this.$reverseLayout) {
            outRect.set(i, 0, i3, i2);
        } else {
            outRect.set(i3, i2, i, 0);
        }
    }
}

