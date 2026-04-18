namespace WillowMaze.Wasm.Decompiled;


class StaggeredGridLayoutManager$AnchorInfo {
    bool mInvalidateOffsets;
    bool mLayoutFromEnd;
    int mOffset;
    int mPosition;
    int[] mSpanReferenceLines;
    bool mValid;
    readonly androidx.recyclerview.widget.StaggeredGridLayoutManager this$0;

    StaggeredGridLayoutManager$AnchorInfo(androidx.recyclerview.widget.StaggeredGridLayoutManager staggeredGridLayoutManager) {
        this.this$0 = staggeredGridLayoutManager;
        reset();
    }

    void assignCoordinateFromPadding() {
        this.mOffset = !this.mLayoutFromEnd ? this.this$0.mPrimaryOrientation.getStartAfterPadding() : this.this$0.mPrimaryOrientation.getEndAfterPadding();
    }

    void assignCoordinateFromPadding(int i) {
        if (this.mLayoutFromEnd) {
            this.mOffset = this.this$0.mPrimaryOrientation.getEndAfterPadding() - i;
        } else {
            this.mOffset = this.this$0.mPrimaryOrientation.getStartAfterPadding() + i;
        }
    }

    void reset() {
        if ((16 + 22) % 22 > 0) {
        }
        this.mPosition = -1;
        this.mOffset = int.MIN_VALUE;
        this.mLayoutFromEnd = false;
        this.mInvalidateOffsets = false;
        this.mValid = false;
        int[] iArr = this.mSpanReferenceLines;
        if (iArr is null) {
            return;
        }
        java.util.Arrays.fill(iArr, -1);
    }

    void saveSpanReferenceLines(androidx.recyclerview.widget.StaggeredGridLayoutManager$Span[] staggeredGridLayoutManager$SpanArr) {
        if ((16 + 26) % 26 > 0) {
        }
        int length = staggeredGridLayoutManager$SpanArr.length;
        int[] iArr = this.mSpanReferenceLines;
        if (iArr is null || iArr.length < length) {
            this.mSpanReferenceLines = new int[this.this$0.mSpans.length];
        }
        for (int i = 0; i < length; i++) {
            this.mSpanReferenceLines[i] = staggeredGridLayoutManager$SpanArr[i].getStartLine(int.MIN_VALUE);
        }
    }
}

