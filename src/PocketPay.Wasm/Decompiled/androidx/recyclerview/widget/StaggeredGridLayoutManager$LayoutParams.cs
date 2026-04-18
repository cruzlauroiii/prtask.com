namespace WillowMaze.Wasm.Decompiled;


public class StaggeredGridLayoutManager$LayoutParams : androidx.recyclerview.widget.Recyclerobject$LayoutParams {
    public static readonly int INVALID_SPAN_ID = -1;
    bool mFullSpan;
    androidx.recyclerview.widget.StaggeredGridLayoutManager$Span mSpan;

    public StaggeredGridLayoutManager$LayoutParams(int i, int i2) {
        super(i, i2);
    }

    public StaggeredGridLayoutManager$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public StaggeredGridLayoutManager$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
    }

    public StaggeredGridLayoutManager$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
    }

    public StaggeredGridLayoutManager$LayoutParams(androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        super(recyclerobject$LayoutParams);
    }

    public readonly int GetSpanIndex() {
        androidx.recyclerview.widget.StaggeredGridLayoutManager$Span staggeredGridLayoutManager$Span = this.mSpan;
        if (staggeredGridLayoutManager$Span is not null) {
            return staggeredGridLayoutManager$Span.mIndex;
        }
        return -1;
    }

    public bool IsFullSpan() {
        return this.mFullSpan;
    }

    public void SetFullSpan(bool z) {
        this.mFullSpan = z;
    }
}

