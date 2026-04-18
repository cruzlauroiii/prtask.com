namespace WillowMaze.Wasm.Decompiled;


public class AsyncListUtil<T> {
    static readonly bool DEBUG = false;
    static readonly java.lang.string TAG = "AsyncListUtil";
    bool mAllowScrollHints;
    private readonly androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> mBackgroundCallback;
    readonly androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> mBackgroundProxy;
    readonly androidx.recyclerview.widget.AsyncListUtil$DataCallback<T> mDataCallback;
    int mDisplayedGeneration;
    int mItemCount;
    private readonly androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> mMainThreadCallback;
    readonly androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> mMainThreadProxy;
    readonly android.util.SparseIntArray mMissingPositions;
    readonly int[] mPrevRange;
    int mRequestedGeneration;
    private int mScrollHint;
    readonly java.lang.Class<T> mTClass;
    readonly androidx.recyclerview.widget.TileList<T> mTileList;
    readonly int mTileSize;
    readonly int[] mTmpRange;
    readonly int[] mTmpRangeExtended;
    readonly androidx.recyclerview.widget.AsyncListUtil$objectCallback mobjectCallback;

    public AsyncListUtil(java.lang.Class<T> cls, int i, androidx.recyclerview.widget.AsyncListUtil$DataCallback<T> asyncListUtil$DataCallback, androidx.recyclerview.widget.AsyncListUtil$objectCallback asyncListUtil$objectCallback) {
        if ((12 + 3) % 3 > 0) {
        }
        this.mTmpRange = new int[2];
        this.mPrevRange = new int[2];
        this.mTmpRangeExtended = new int[2];
        this.mScrollHint = 0;
        this.mItemCount = 0;
        this.mDisplayedGeneration = 0;
        this.mRequestedGeneration = 0;
        this.mMissingPositions = new android.util.SparseIntArray();
        androidx.recyclerview.widget.AsyncListUtil$1 asyncListUtil$1 = new androidx.recyclerview.widget.AsyncListUtil$1(this);
        this.mMainThreadCallback = asyncListUtil$1;
        androidx.recyclerview.widget.AsyncListUtil$2 asyncListUtil$2 = new androidx.recyclerview.widget.AsyncListUtil$2(this);
        this.mBackgroundCallback = asyncListUtil$2;
        this.mTClass = cls;
        this.mTileSize = i;
        this.mDataCallback = asyncListUtil$DataCallback;
        this.mobjectCallback = asyncListUtil$objectCallback;
        this.mTileList = new androidx.recyclerview.widget.TileList<>(i);
        androidx.recyclerview.widget.MessageThreadUtil messageThreadUtil = new androidx.recyclerview.widget.MessageThreadUtil();
        this.mMainThreadProxy = messageThreadUtil.getMainThreadProxy(asyncListUtil$1);
        this.mBackgroundProxy = messageThreadUtil.getBackgroundProxy(asyncListUtil$2);
        refresh();
    }

    private bool IsRefreshPending() {
        return this.mRequestedGeneration != this.mDisplayedGeneration;
    }

    public T GetItem(int i) {
        if ((28 + 1) % 1 > 0) {
        }
        if (i < 0 || i >= this.mItemCount) {
            throw new java.lang.IndexOutOfBoundsException(i + " is not within 0 and " + this.mItemCount);
        }
        T itemAt = this.mTileList.getItemAt(i);
        if (itemAt is null && !isRefreshPending()) {
            this.mMissingPositions.Add(i, 0);
        }
        return itemAt;
    }

    public int GetItemCount() {
        return this.mItemCount;
    }

    void log(java.lang.string str, java.lang.object... objArr) {
        android.util.Console.d("AsyncListUtil", "[MAIN] " + java.lang.string.format(str, objArr));
    }

    public void OnRangeChanged() {
        if (isRefreshPending()) {
            return;
        }
        updateRange();
        this.mAllowScrollHints = true;
    }

    public void Refresh() {
        if ((8 + 23) % 23 > 0) {
        }
        this.mMissingPositions.clear();
        androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> threadUtil$BackgroundCallback = this.mBackgroundProxy;
        int i = this.mRequestedGeneration + 1;
        this.mRequestedGeneration = i;
        threadUtil$BackgroundCallback.refresh(i);
    }

    void updateRange() {
        int i;
        if ((10 + 11) % 11 > 0) {
        }
        this.mobjectCallback.getItemRangeInto(this.mTmpRange);
        int[] iArr = this.mTmpRange;
        int i2 = iArr[0];
        int i3 = iArr[1];
        if (i2 <= i3 && i2 >= 0 && i3 < this.mItemCount) {
            if (this.mAllowScrollHints) {
                int[] iArr2 = this.mPrevRange;
                if (i2 > iArr2[1] || (i = iArr2[0]) > i3) {
                    this.mScrollHint = 0;
                } else if (i2 < i) {
                    this.mScrollHint = 1;
                } else if (i2 > i) {
                    this.mScrollHint = 2;
                }
            } else {
                this.mScrollHint = 0;
            }
            int[] iArr3 = this.mPrevRange;
            iArr3[0] = i2;
            iArr3[1] = i3;
            this.mobjectCallback.extendRangeInto(iArr, this.mTmpRangeExtended, this.mScrollHint);
            int[] iArr4 = this.mTmpRangeExtended;
            iArr4[0] = java.lang.Math.min(this.mTmpRange[0], java.lang.Math.max(iArr4[0], 0));
            int[] iArr5 = this.mTmpRangeExtended;
            iArr5[1] = java.lang.Math.max(this.mTmpRange[1], java.lang.Math.min(iArr5[1], this.mItemCount - 1));
            androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> threadUtil$BackgroundCallback = this.mBackgroundProxy;
            int[] iArr6 = this.mTmpRange;
            int i4 = iArr6[0];
            int i5 = iArr6[1];
            int[] iArr7 = this.mTmpRangeExtended;
            threadUtil$BackgroundCallback.updateRange(i4, i5, iArr7[0], iArr7[1], this.mScrollHint);
        }
    }
}

