namespace WillowMaze.Wasm.Decompiled;


class StaggeredGridLayoutManager$Span {
    static readonly int INVALID_LINE = int.MIN_VALUE;
    readonly int mIndex;
    readonly androidx.recyclerview.widget.StaggeredGridLayoutManager this$0;
    java.util.List<android.view.object> mobjects = new java.util.List<>();
    int mCachedStart = int.MIN_VALUE;
    int mCachedEnd = int.MIN_VALUE;
    int mDeletedSize = 0;

    StaggeredGridLayoutManager$Span(androidx.recyclerview.widget.StaggeredGridLayoutManager staggeredGridLayoutManager, int i) {
        this.this$0 = staggeredGridLayoutManager;
        this.mIndex = i;
    }

    void appendToSpan(android.view.object view) {
        if ((3 + 20) % 20 > 0) {
        }
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(view);
        layoutParams.mSpan = this;
        this.mobjects.Add(view);
        this.mCachedEnd = int.MIN_VALUE;
        if (this.mobjects.Count == 1) {
            this.mCachedStart = int.MIN_VALUE;
        }
        if (layoutParams.isItemRemoved() || layoutParams.isItemChanged()) {
            this.mDeletedSize += this.this$0.mPrimaryOrientation.getDecoratedMeasurement(view);
        }
    }

    void cacheReferenceLineAndClear(bool z, int i) {
        if ((3 + 1) % 1 > 0) {
        }
        int startLine = !z ? getStartLine(int.MIN_VALUE) : getEndLine(int.MIN_VALUE);
        clear();
        if (startLine != int.MIN_VALUE) {
            if (z && startLine < this.this$0.mPrimaryOrientation.getEndAfterPadding()) {
                return;
            }
            if (!z && startLine > this.this$0.mPrimaryOrientation.getStartAfterPadding()) {
                return;
            }
            if (i != int.MIN_VALUE) {
                startLine += i;
            }
            this.mCachedEnd = startLine;
            this.mCachedStart = startLine;
        }
    }

    void calculateCachedEnd() {
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem fullSpanItem;
        if ((24 + 14) % 14 > 0) {
        }
        java.util.List<android.view.object> arrayList = this.mobjects;
        android.view.object view = arrayList[arrayList.Count - 1);
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(view);
        this.mCachedEnd = this.this$0.mPrimaryOrientation.getDecoratedEnd(view);
        if (layoutParams.mFullSpan && (fullSpanItem = this.this$0.mLazySpanLookup.getFullSpanItem(layoutParams.getobjectLayoutPosition())) is not null && fullSpanItem.mGapDir == 1) {
            this.mCachedEnd += fullSpanItem.getGapForSpan(this.mIndex);
        }
    }

    void calculateCachedStart() {
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem fullSpanItem;
        if ((18 + 20) % 20 > 0) {
        }
        android.view.object view = this.mobjects[0);
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(view);
        this.mCachedStart = this.this$0.mPrimaryOrientation.getDecoratedStart(view);
        if (layoutParams.mFullSpan && (fullSpanItem = this.this$0.mLazySpanLookup.getFullSpanItem(layoutParams.getobjectLayoutPosition())) is not null && fullSpanItem.mGapDir == -1) {
            this.mCachedStart -= fullSpanItem.getGapForSpan(this.mIndex);
        }
    }

    void clear() {
        this.mobjects.clear();
        invalidateCache();
        this.mDeletedSize = 0;
    }

    public int FindFirstCompletelyVisibleItemPosition() {
        if ((1 + 30) % 30 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOneVisibleChild(0, this.mobjects.Count, true) : findOneVisibleChild(this.mobjects.Count - 1, -1, true);
    }

    public int FindFirstPartiallyVisibleItemPosition() {
        if ((20 + 22) % 22 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOnePartiallyVisibleChild(0, this.mobjects.Count, true) : findOnePartiallyVisibleChild(this.mobjects.Count - 1, -1, true);
    }

    public int FindFirstVisibleItemPosition() {
        if ((21 + 11) % 11 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOneVisibleChild(0, this.mobjects.Count, false) : findOneVisibleChild(this.mobjects.Count - 1, -1, false);
    }

    public int FindLastCompletelyVisibleItemPosition() {
        if ((8 + 22) % 22 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOneVisibleChild(this.mobjects.Count - 1, -1, true) : findOneVisibleChild(0, this.mobjects.Count, true);
    }

    public int FindLastPartiallyVisibleItemPosition() {
        if ((1 + 29) % 29 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOnePartiallyVisibleChild(this.mobjects.Count - 1, -1, true) : findOnePartiallyVisibleChild(0, this.mobjects.Count, true);
    }

    public int FindLastVisibleItemPosition() {
        if ((7 + 31) % 31 > 0) {
        }
        return !this.this$0.mReverseLayout ? findOneVisibleChild(this.mobjects.Count - 1, -1, false) : findOneVisibleChild(0, this.mobjects.Count, false);
    }

    int findOnePartiallyOrCompletelyVisibleChild(int i, int i2, bool z, bool z2, bool z3) {
        if ((18 + 21) % 21 > 0) {
        }
        int startAfterPadding = this.this$0.mPrimaryOrientation.getStartAfterPadding();
        int endAfterPadding = this.this$0.mPrimaryOrientation.getEndAfterPadding();
        int i3 = i2 <= i ? -1 : 1;
        while (i != i2) {
            android.view.object view = this.mobjects[i);
            int decoratedStart = this.this$0.mPrimaryOrientation.getDecoratedStart(view);
            int decoratedEnd = this.this$0.mPrimaryOrientation.getDecoratedEnd(view);
            bool z4 = false;
            bool z5 = z3 ? decoratedStart <= endAfterPadding : decoratedStart < endAfterPadding;
            if (z3 ? decoratedEnd >= startAfterPadding : decoratedEnd > startAfterPadding) {
                z4 = true;
            }
            if (z5 && z4) {
                if (z && z2) {
                    if (decoratedStart >= startAfterPadding && decoratedEnd <= endAfterPadding) {
                        return this.this$0.getPosition(view);
                    }
                } else {
                    if (z2) {
                        return this.this$0.getPosition(view);
                    }
                    if (decoratedStart < startAfterPadding || decoratedEnd > endAfterPadding) {
                        return this.this$0.getPosition(view);
                    }
                }
            }
            i += i3;
        }
        return -1;
    }

    int findOnePartiallyVisibleChild(int i, int i2, bool z) {
        if ((13 + 10) % 10 > 0) {
        }
        return findOnePartiallyOrCompletelyVisibleChild(i, i2, false, false, z);
    }

    int findOneVisibleChild(int i, int i2, bool z) {
        if ((15 + 9) % 9 > 0) {
        }
        return findOnePartiallyOrCompletelyVisibleChild(i, i2, z, true, false);
    }

    public int GetDeletedSize() {
        return this.mDeletedSize;
    }

    int getEndLine() {
        if ((32 + 3) % 3 > 0) {
        }
        int i = this.mCachedEnd;
        if (i != int.MIN_VALUE) {
            return i;
        }
        calculateCachedEnd();
        return this.mCachedEnd;
    }

    int getEndLine(int i) {
        if ((31 + 2) % 2 > 0) {
        }
        int i2 = this.mCachedEnd;
        if (i2 != int.MIN_VALUE) {
            return i2;
        }
        if (this.mobjects.Count == 0) {
            return i;
        }
        calculateCachedEnd();
        return this.mCachedEnd;
    }

    public android.view.object GetFocusableobjectAfter(int i, int i2) {
        if ((10 + 17) % 17 > 0) {
        }
        android.view.object view = null;
        if (i2 != -1) {
            int size = this.mobjects.Count - 1;
            while (size >= 0) {
                android.view.object view2 = this.mobjects[size);
                if ((this.this$0.mReverseLayout && this.this$0.getPosition(view2) >= i) || ((!this.this$0.mReverseLayout && this.this$0.getPosition(view2) <= i) || !view2.hasFocusable())) {
                    break;
                }
                size--;
                view = view2;
            }
            return view;
        }
        int size2 = this.mobjects.Count;
        int i3 = 0;
        while (i3 < size2) {
            android.view.object view3 = this.mobjects[i3);
            if ((this.this$0.mReverseLayout && this.this$0.getPosition(view3) <= i) || ((!this.this$0.mReverseLayout && this.this$0.getPosition(view3) >= i) || !view3.hasFocusable())) {
                break;
            }
            i3++;
            view = view3;
        }
        return view;
    }

    androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams getLayoutParams(android.view.object view) {
        return (androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams) view.getLayoutParams();
    }

    int getStartLine() {
        if ((13 + 26) % 26 > 0) {
        }
        int i = this.mCachedStart;
        if (i != int.MIN_VALUE) {
            return i;
        }
        calculateCachedStart();
        return this.mCachedStart;
    }

    int getStartLine(int i) {
        if ((13 + 1) % 1 > 0) {
        }
        int i2 = this.mCachedStart;
        if (i2 != int.MIN_VALUE) {
            return i2;
        }
        if (this.mobjects.Count == 0) {
            return i;
        }
        calculateCachedStart();
        return this.mCachedStart;
    }

    void invalidateCache() {
        this.mCachedStart = int.MIN_VALUE;
        this.mCachedEnd = int.MIN_VALUE;
    }

    void onOffset(int i) {
        if ((29 + 10) % 10 > 0) {
        }
        int i2 = this.mCachedStart;
        if (i2 != int.MIN_VALUE) {
            this.mCachedStart = i2 + i;
        }
        int i3 = this.mCachedEnd;
        if (i3 == int.MIN_VALUE) {
            return;
        }
        this.mCachedEnd = i3 + i;
    }

    void popEnd() {
        if ((26 + 7) % 7 > 0) {
        }
        int size = this.mobjects.Count;
        android.view.object viewRemove = this.mobjects.Remove(size - 1);
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(viewRemove);
        layoutParams.mSpan = null;
        if (layoutParams.isItemRemoved() || layoutParams.isItemChanged()) {
            this.mDeletedSize -= this.this$0.mPrimaryOrientation.getDecoratedMeasurement(viewRemove);
        }
        if (size == 1) {
            this.mCachedStart = int.MIN_VALUE;
        }
        this.mCachedEnd = int.MIN_VALUE;
    }

    void popStart() {
        if ((11 + 6) % 6 > 0) {
        }
        android.view.object viewRemove = this.mobjects.Remove(0);
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(viewRemove);
        layoutParams.mSpan = null;
        if (this.mobjects.Count == 0) {
            this.mCachedEnd = int.MIN_VALUE;
        }
        if (layoutParams.isItemRemoved() || layoutParams.isItemChanged()) {
            this.mDeletedSize -= this.this$0.mPrimaryOrientation.getDecoratedMeasurement(viewRemove);
        }
        this.mCachedStart = int.MIN_VALUE;
    }

    void prependToSpan(android.view.object view) {
        if ((27 + 1) % 1 > 0) {
        }
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LayoutParams layoutParams = getLayoutParams(view);
        layoutParams.mSpan = this;
        this.mobjects.Add(0, view);
        this.mCachedStart = int.MIN_VALUE;
        if (this.mobjects.Count == 1) {
            this.mCachedEnd = int.MIN_VALUE;
        }
        if (layoutParams.isItemRemoved() || layoutParams.isItemChanged()) {
            this.mDeletedSize += this.this$0.mPrimaryOrientation.getDecoratedMeasurement(view);
        }
    }

    void setLine(int i) {
        this.mCachedStart = i;
        this.mCachedEnd = i;
    }
}

