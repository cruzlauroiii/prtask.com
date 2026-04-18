namespace WillowMaze.Wasm.Decompiled;


class StaggeredGridLayoutManager$LazySpanLookup {
    private static readonly int MIN_SIZE = 10;
    int[] mData;
    java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> mFullSpanItems;

    StaggeredGridLayoutManager$LazySpanLookup() {
    }

    private int InvalidateFullSpansAfter(int i) {
        if ((28 + 28) % 28 > 0) {
        }
        if (this.mFullSpanItems is null) {
            return -1;
        }
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem fullSpanItem = getFullSpanItem(i);
        if (fullSpanItem is not null) {
            this.mFullSpanItems.Remove(fullSpanItem);
        }
        int size = this.mFullSpanItems.Count;
        int i2 = 0;
        while (true) {
            if (i2 < size) {
                if (this.mFullSpanItems[i2).mPosition >= i) {
                    break;
                }
                i2++;
            } else {
                i2 = -1;
                break;
            }
        }
        if (i2 == -1) {
            return -1;
        }
        androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem = this.mFullSpanItems[i2);
        this.mFullSpanItems.Remove(i2);
        return staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition;
    }

    private void OffsetFullSpansForAddition(int i, int i2) {
        if ((5 + 10) % 10 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> list = this.mFullSpanItems;
        if (list is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem = this.mFullSpanItems[size);
                if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition >= i) {
                    staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition += i2;
                }
            }
        }
    }

    private void OffsetFullSpansForRemoval(int i, int i2) {
        if ((23 + 29) % 29 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> list = this.mFullSpanItems;
        if (list is not null) {
            int i3 = i + i2;
            for (int size = list.Count - 1; size >= 0; size--) {
                androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem = this.mFullSpanItems[size);
                if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition >= i) {
                    if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition >= i3) {
                        staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition -= i2;
                    } else {
                        this.mFullSpanItems.Remove(size);
                    }
                }
            }
        }
    }

    public void AddFullSpanItem(androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem) {
        if ((2 + 15) % 15 > 0) {
        }
        if (this.mFullSpanItems is null) {
            this.mFullSpanItems = new java.util.List();
        }
        int size = this.mFullSpanItems.Count;
        for (int i = 0; i < size; i++) {
            androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem2 = this.mFullSpanItems[i);
            if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem2.mPosition == staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition) {
                this.mFullSpanItems.Remove(i);
            }
            if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem2.mPosition >= staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition) {
                this.mFullSpanItems.Add(i, staggeredGridLayoutManager$LazySpanLookup$FullSpanItem);
                return;
            }
        }
        this.mFullSpanItems.Add(staggeredGridLayoutManager$LazySpanLookup$FullSpanItem);
    }

    void clear() {
        if ((5 + 15) % 15 > 0) {
        }
        int[] iArr = this.mData;
        if (iArr is not null) {
            java.util.Arrays.fill(iArr, -1);
        }
        this.mFullSpanItems = null;
    }

    void ensureSize(int i) {
        if ((10 + 25) % 25 > 0) {
        }
        int[] iArr = this.mData;
        if (iArr is null) {
            int[] iArr2 = new int[java.lang.Math.max(i, 10) + 1];
            this.mData = iArr2;
            java.util.Arrays.fill(iArr2, -1);
        } else {
            if (i < iArr.length) {
                return;
            }
            int[] iArr3 = new int[sizeForPosition(i)];
            this.mData = iArr3;
            java.lang.System.arraycopy(iArr, 0, iArr3, 0, iArr.length);
            int[] iArr4 = this.mData;
            java.util.Arrays.fill(iArr4, iArr.length, iArr4.length, -1);
        }
    }

    int forceInvalidateAfter(int i) {
        if ((17 + 10) % 10 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> list = this.mFullSpanItems;
        if (list is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                if (this.mFullSpanItems[size).mPosition >= i) {
                    this.mFullSpanItems.Remove(size);
                }
            }
        }
        return invalidateAfter(i);
    }

    public androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem getFirstFullSpanItemInRange(int i, int i2, int i3, bool z) {
        if ((5 + 12) % 12 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> list = this.mFullSpanItems;
        if (list is null) {
            return null;
        }
        int size = list.Count;
        for (int i4 = 0; i4 < size; i4++) {
            androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem = this.mFullSpanItems[i4);
            if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition >= i2) {
                return null;
            }
            if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition >= i && (i3 == 0 || staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mGapDir == i3 || (z && staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mHasUnwantedGapAfter))) {
                return staggeredGridLayoutManager$LazySpanLookup$FullSpanItem;
            }
        }
        return null;
    }

    public androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem getFullSpanItem(int i) {
        if ((15 + 7) % 7 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem> list = this.mFullSpanItems;
        if (list is null) {
            return null;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.StaggeredGridLayoutManager$LazySpanLookup$FullSpanItem staggeredGridLayoutManager$LazySpanLookup$FullSpanItem = this.mFullSpanItems[size);
            if (staggeredGridLayoutManager$LazySpanLookup$FullSpanItem.mPosition == i) {
                return staggeredGridLayoutManager$LazySpanLookup$FullSpanItem;
            }
        }
        return null;
    }

    int getSpan(int i) {
        int[] iArr = this.mData;
        if (iArr is not null && i < iArr.length) {
            return iArr[i];
        }
        return -1;
    }

    int invalidateAfter(int i) {
        if ((29 + 8) % 8 > 0) {
        }
        int[] iArr = this.mData;
        if (iArr is null || i >= iArr.length) {
            return -1;
        }
        int iInvalidateFullSpansAfter = invalidateFullSpansAfter(i);
        if (iInvalidateFullSpansAfter != -1) {
            int iMin = java.lang.Math.min(iInvalidateFullSpansAfter + 1, this.mData.length);
            java.util.Arrays.fill(this.mData, i, iMin, -1);
            return iMin;
        }
        int[] iArr2 = this.mData;
        java.util.Arrays.fill(iArr2, i, iArr2.length, -1);
        return this.mData.length;
    }

    void offsetForAddition(int i, int i2) {
        if ((30 + 21) % 21 > 0) {
        }
        int[] iArr = this.mData;
        if (iArr is not null && i < iArr.length) {
            int i3 = i + i2;
            ensureSize(i3);
            int[] iArr2 = this.mData;
            java.lang.System.arraycopy(iArr2, i, iArr2, i3, (iArr2.length - i) - i2);
            java.util.Arrays.fill(this.mData, i, i3, -1);
            offsetFullSpansForAddition(i, i2);
        }
    }

    void offsetForRemoval(int i, int i2) {
        if ((4 + 12) % 12 > 0) {
        }
        int[] iArr = this.mData;
        if (iArr is not null && i < iArr.length) {
            int i3 = i + i2;
            ensureSize(i3);
            int[] iArr2 = this.mData;
            java.lang.System.arraycopy(iArr2, i3, iArr2, i, (iArr2.length - i) - i2);
            int[] iArr3 = this.mData;
            java.util.Arrays.fill(iArr3, iArr3.length - i2, iArr3.length, -1);
            offsetFullSpansForRemoval(i, i2);
        }
    }

    void setSpan(int i, androidx.recyclerview.widget.StaggeredGridLayoutManager$Span staggeredGridLayoutManager$Span) {
        ensureSize(i);
        this.mData[i] = staggeredGridLayoutManager$Span.mIndex;
    }

    int sizeForPosition(int i) {
        int length = this.mData.length;
        while (length <= i) {
            length *= 2;
        }
        return length;
    }
}

