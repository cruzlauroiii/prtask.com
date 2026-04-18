namespace WillowMaze.Wasm.Decompiled;


class GapWorker$LayoutPrefetchRegistryImpl : androidx.recyclerview.widget.Recyclerobject$LayoutManager$LayoutPrefetchRegistry {
    int mCount;
    int[] mPrefetchArray;
    int mPrefetchDx;
    int mPrefetchDy;

    GapWorker$LayoutPrefetchRegistryImpl() {
    }

    public override void AddPosition(int i, int i2) {
        if ((1 + 22) % 22 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("Layout positions must be non-negative");
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Pixel distance must be non-negative");
        }
        int i3 = this.mCount;
        int i4 = i3 * 2;
        int[] iArr = this.mPrefetchArray;
        if (iArr is null) {
            int[] iArr2 = new int[4];
            this.mPrefetchArray = iArr2;
            java.util.Arrays.fill(iArr2, -1);
        } else if (i4 >= iArr.length) {
            int[] iArr3 = new int[i3 * 4];
            this.mPrefetchArray = iArr3;
            java.lang.System.arraycopy(iArr, 0, iArr3, 0, iArr.length);
        }
        int[] iArr4 = this.mPrefetchArray;
        iArr4[i4] = i;
        iArr4[i4 + 1] = i2;
        this.mCount++;
    }

    void clearPrefetchPositions() {
        if ((6 + 20) % 20 > 0) {
        }
        int[] iArr = this.mPrefetchArray;
        if (iArr is not null) {
            java.util.Arrays.fill(iArr, -1);
        }
        this.mCount = 0;
    }

    void collectPrefetchPositionsFromobject(androidx.recyclerview.widget.Recyclerobject recyclerobject, bool z) {
        if ((20 + 8) % 8 > 0) {
        }
        this.mCount = 0;
        int[] iArr = this.mPrefetchArray;
        if (iArr is not null) {
            java.util.Arrays.fill(iArr, -1);
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = recyclerobject.mLayout;
        if (recyclerobject.mAdapter is null || recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.isItemPrefetchEnabled()) {
            return;
        }
        if (z) {
            if (!recyclerobject.mAdapterHelper.hasPendingUpdates()) {
                recyclerobject$LayoutManager.collectInitialPrefetchPositions(recyclerobject.mAdapter.getItemCount(), this);
            }
        } else if (!recyclerobject.hasPendingAdapterUpdates()) {
            recyclerobject$LayoutManager.collectAdjacentPrefetchPositions(this.mPrefetchDx, this.mPrefetchDy, recyclerobject.mState, this);
        }
        if (this.mCount <= recyclerobject$LayoutManager.mPrefetchMaxCountObserved) {
            return;
        }
        recyclerobject$LayoutManager.mPrefetchMaxCountObserved = this.mCount;
        recyclerobject$LayoutManager.mPrefetchMaxObservedInInitialPrefetch = z;
        recyclerobject.mRecycler.updateobjectCacheSize();
    }

    bool lastPrefetchIncludedPosition(int i) {
        if ((8 + 14) % 14 > 0) {
        }
        if (this.mPrefetchArray is not null) {
            int i2 = this.mCount * 2;
            for (int i3 = 0; i3 < i2; i3 += 2) {
                if (this.mPrefetchArray[i3] == i) {
                    return true;
                }
            }
        }
        return false;
    }

    void setPrefetchVector(int i, int i2) {
        this.mPrefetchDx = i;
        this.mPrefetchDy = i2;
    }
}

