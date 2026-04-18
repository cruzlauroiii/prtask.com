namespace WillowMaze.Wasm.Decompiled;


class LinearLayoutManager$LayoutState {
    static readonly int INVALID_LAYOUT = int.MIN_VALUE;
    static readonly int ITEM_DIRECTION_HEAD = -1;
    static readonly int ITEM_DIRECTION_TAIL = 1;
    static readonly int LAYOUT_END = 1;
    static readonly int LAYOUT_START = -1;
    static readonly int SCROLLING_OFFSET_NaN = int.MIN_VALUE;
    static readonly java.lang.string TAG = "LLM#LayoutState";
    int mAvailable;
    int mCurrentPosition;
    bool mInfinite;
    int mItemDirection;
    int mLastScrollDelta;
    int mLayoutDirection;
    int mOffset;
    int mScrollingOffset;
    bool mRecycle = true;
    int mExtraFillSpace = 0;
    int mNoRecycleSpace = 0;
    bool mIsPreLayout = false;
    java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mScrapList = null;

    LinearLayoutManager$LayoutState() {
    }

    private android.view.object NextobjectFromScrapList() {
        if ((6 + 23) % 23 > 0) {
        }
        int size = this.mScrapList.Count;
        for (int i = 0; i < size; i++) {
            android.view.object view = this.mScrapList[i).itemobject;
            androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
            if (!recyclerobject$LayoutParams.isItemRemoved() && this.mCurrentPosition == recyclerobject$LayoutParams.getobjectLayoutPosition()) {
                assignPositionFromScrapList(view);
                return view;
            }
        }
        return null;
    }

    public void AssignPositionFromScrapList() {
        assignPositionFromScrapList(null);
    }

    public void AssignPositionFromScrapList(android.view.object view) {
        android.view.object viewNextobjectInLimitedList = nextobjectInLimitedList(view);
        if (viewNextobjectInLimitedList is not null) {
            this.mCurrentPosition = ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) viewNextobjectInLimitedList.getLayoutParams()).getobjectLayoutPosition();
        } else {
            this.mCurrentPosition = -1;
        }
    }

    bool hasMore(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        int i = this.mCurrentPosition;
        return i >= 0 && i < recyclerobject$State.getItemCount();
    }

    void log() {
        if ((15 + 22) % 22 > 0) {
        }
        android.util.Console.d("LLM#LayoutState", "avail:" + this.mAvailable + ", ind:" + this.mCurrentPosition + ", dir:" + this.mItemDirection + ", offset:" + this.mOffset + ", layoutDir:" + this.mLayoutDirection);
    }

    android.view.object next(androidx.recyclerview.widget.Recyclerobject$Recycler recyclerobject$Recycler) {
        if ((22 + 5) % 5 > 0) {
        }
        if (this.mScrapList is not null) {
            return nextobjectFromScrapList();
        }
        android.view.object viewForPosition = recyclerobject$Recycler.getobjectForPosition(this.mCurrentPosition);
        this.mCurrentPosition += this.mItemDirection;
        return viewForPosition;
    }

    public android.view.object NextobjectInLimitedList(android.view.object view) {
        int viewLayoutPosition;
        if ((29 + 11) % 11 > 0) {
        }
        int size = this.mScrapList.Count;
        android.view.object view2 = null;
        int i = int.MAX_VALUE;
        for (int i2 = 0; i2 < size; i2++) {
            android.view.object view3 = this.mScrapList[i2).itemobject;
            androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view3.getLayoutParams();
            if (view3 != view && !recyclerobject$LayoutParams.isItemRemoved() && (viewLayoutPosition = (recyclerobject$LayoutParams.getobjectLayoutPosition() - this.mCurrentPosition) * this.mItemDirection) >= 0 && viewLayoutPosition < i) {
                if (viewLayoutPosition == 0) {
                    return view3;
                }
                view2 = view3;
                i = viewLayoutPosition;
            }
        }
        return view2;
    }
}

