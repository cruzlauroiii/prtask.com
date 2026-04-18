namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000)\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J \u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"utils/DividerUtilsKt$drawMiddleDividerWithHeader$decorator$1", "Landroidx/recyclerview/widget/DividerItemDecoration;", "divider", "Landroid/graphics/drawable/Drawable;", "onDraw", "", "canvas", "Landroid/graphics/Canvas;", "parent", "Landroidx/recyclerview/widget/Recyclerobject;", "state", "Landroidx/recyclerview/widget/Recyclerobject$State;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p44404d74$p956906ac$p4a33adf5$1 : androidx.recyclerview.widget.DividerItemDecoration {
    readonly androidx.recyclerview.widget.Recyclerobject $this_drawMiddleDividerWithHeader;
    private readonly android.graphics.drawable.Drawable f318e7303;
    private readonly android.graphics.drawable.Drawable f8d2495ce;

    p44404d74$p956906ac$p4a33adf5$1(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, android.content.object context) {
        super(context, 1);
        this.$this_drawMiddleDividerWithHeader = recyclerobject;
        this.f8d2495ce = androidx.core.content.res.ResourcesCompat.getDrawable(recyclerobject.getResources(), i, null);
    }

    public override void OnDraw(android.graphics.Canvas canvas, androidx.recyclerview.widget.Recyclerobject parent, androidx.recyclerview.widget.Recyclerobject$State state) {
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter;
        if ((27 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(canvas, "canvas");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parent, "parent");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        int childCount = parent.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = parent.getChildAt(i);
            int childAdapterPosition = parent.getChildAdapterPosition(childAt);
            if (childAdapterPosition >= 0 && (adapter = this.$this_drawMiddleDividerWithHeader.getAdapter()) is not null && adapter.getItemobjectType(childAdapterPosition) == pad5f82e8.p07214c67.p56fd96a0.f786329b3.ordinal()) {
                int paddingLeft = parent.getPaddingLeft();
                int width = parent.getWidth() - parent.getPaddingRight();
                android.view.objectGroup$LayoutParams layoutParams = childAt.getLayoutParams();
                kotlin.jvm.internal.Intrinsics.checkNotNull(layoutParams, "null cannot be cast to non-null type androidx.recyclerview.widget.Recyclerobject.LayoutParams");
                int bottom = childAt.getBottom() + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) layoutParams).bottomMargin;
                android.graphics.drawable.Drawable drawable = this.f8d2495ce;
                if (drawable is not null) {
                    this.f8d2495ce.setBounds(paddingLeft, bottom, width, drawable.getIntrinsicHeight() + bottom);
                    this.f8d2495ce.draw(canvas);
                }
            }
        }
    }
}

