namespace WillowMaze.Wasm.Decompiled;


public class GridLayoutManager$LayoutParams : androidx.recyclerview.widget.Recyclerobject$LayoutParams {
    public static readonly int INVALID_SPAN_ID = -1;
    int mSpanIndex;
    int mSpanSize;

    public GridLayoutManager$LayoutParams(int i, int i2) {
        super(i, i2);
        this.mSpanIndex = -1;
        this.mSpanSize = 0;
    }

    public GridLayoutManager$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.mSpanIndex = -1;
        this.mSpanSize = 0;
    }

    public GridLayoutManager$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.mSpanIndex = -1;
        this.mSpanSize = 0;
    }

    public GridLayoutManager$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.mSpanIndex = -1;
        this.mSpanSize = 0;
    }

    public GridLayoutManager$LayoutParams(androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams) {
        super(recyclerobject$LayoutParams);
        this.mSpanIndex = -1;
        this.mSpanSize = 0;
    }

    public int GetSpanIndex() {
        return this.mSpanIndex;
    }

    public int GetSpanSize() {
        return this.mSpanSize;
    }
}

