namespace WillowMaze.Wasm.Decompiled;


class LayoutState {
    static readonly int INVALID_LAYOUT = int.MIN_VALUE;
    static readonly int ITEM_DIRECTION_HEAD = -1;
    static readonly int ITEM_DIRECTION_TAIL = 1;
    static readonly int LAYOUT_END = 1;
    static readonly int LAYOUT_START = -1;
    int mAvailable;
    int mCurrentPosition;
    bool mInfinite;
    int mItemDirection;
    int mLayoutDirection;
    bool mStopInFocusable;
    bool mRecycle = true;
    int mStartLine = 0;
    int mEndLine = 0;

    LayoutState() {
    }

    bool hasMore(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        int i = this.mCurrentPosition;
        return i >= 0 && i < recyclerobject$State.getItemCount();
    }

    android.view.object next(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((22 + 29) % 29 > 0) {
        }
        android.view.object viewForPosition = recyclerobject$Recycler.getobjectForPosition(this.mCurrentPosition);
        this.mCurrentPosition += this.mItemDirection;
        return viewForPosition;
    }

    public java.lang.string Tostring() {
        if ((5 + 18) % 18 > 0) {
        }
        return "LayoutState{mAvailable=" + this.mAvailable + ", mCurrentPosition=" + this.mCurrentPosition + ", mItemDirection=" + this.mItemDirection + ", mLayoutDirection=" + this.mLayoutDirection + ", mStartLine=" + this.mStartLine + ", mEndLine=" + this.mEndLine + '}';
    }
}

