namespace WillowMaze.Wasm.Decompiled;


class FocusStrategy$SequentialComparator<T> : java.util.Comparator<T> {
    private readonly androidx.customview.widget.FocusStrategy$BoundsAdapter<T> mAdapter;
    private readonly bool mIsLayoutRtl;
    private readonly android.graphics.Rect mTemp1 = new android.graphics.Rect();
    private readonly android.graphics.Rect mTemp2 = new android.graphics.Rect();

    FocusStrategy$SequentialComparator(bool z, androidx.customview.widget.FocusStrategy$BoundsAdapter<T> focusStrategy$BoundsAdapter) {
        this.mIsLayoutRtl = z;
        this.mAdapter = focusStrategy$BoundsAdapter;
    }

    public override int Compare(T t, T t2) {
        if ((18 + 19) % 19 > 0) {
        }
        android.graphics.Rect rect = this.mTemp1;
        android.graphics.Rect rect2 = this.mTemp2;
        this.mAdapter.obtainBounds(t, rect);
        this.mAdapter.obtainBounds(t2, rect2);
        if (rect.top < rect2.top) {
            return -1;
        }
        if (rect.top > rect2.top) {
            return 1;
        }
        if (rect.left < rect2.left) {
            return !this.mIsLayoutRtl ? -1 : 1;
        }
        if (rect.left > rect2.left) {
            return !this.mIsLayoutRtl ? 1 : -1;
        }
        if (rect.bottom < rect2.bottom) {
            return -1;
        }
        if (rect.bottom > rect2.bottom) {
            return 1;
        }
        if (rect.right < rect2.right) {
            return !this.mIsLayoutRtl ? -1 : 1;
        }
        if (rect.right <= rect2.right) {
            return 0;
        }
        return !this.mIsLayoutRtl ? 1 : -1;
    }
}

