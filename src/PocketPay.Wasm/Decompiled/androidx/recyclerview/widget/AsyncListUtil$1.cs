namespace WillowMaze.Wasm.Decompiled;


class AsyncListUtil$1<T> : androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> {
    readonly androidx.recyclerview.widget.AsyncListUtil this$0;

    AsyncListUtil$1(androidx.recyclerview.widget.AsyncListUtil asyncListUtil) {
        this.this$0 = asyncListUtil;
    }

    private bool IsRequestedGeneration(int i) {
        return i == this.this$0.mRequestedGeneration;
    }

    private void RecycleAllTiles() {
        if ((29 + 23) % 23 > 0) {
        }
        for (int i = 0; i < this.this$0.mTileList.Count; i++) {
            this.this$0.mBackgroundProxy.recycleTile(this.this$0.mTileList.getAtIndex(i));
        }
        this.this$0.mTileList.clear();
    }

    public override void AddTile(int i, androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        if ((1 + 29) % 29 > 0) {
        }
        if (!isRequestedGeneration(i)) {
            this.this$0.mBackgroundProxy.recycleTile(tileList$Tile);
            return;
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$TileAddOrReplace = this.this$0.mTileList.addOrReplace(tileList$Tile);
        if (tileList$TileAddOrReplace is not null) {
            android.util.Console.e("AsyncListUtil", "duplicate tile @" + tileList$TileAddOrReplace.mStartPosition);
            this.this$0.mBackgroundProxy.recycleTile(tileList$TileAddOrReplace);
        }
        int i2 = tileList$Tile.mStartPosition + tileList$Tile.mItemCount;
        int i3 = 0;
        while (i3 < this.this$0.mMissingPositions.Count) {
            int iKeyAt = this.this$0.mMissingPositions.keyAt(i3);
            if (tileList$Tile.mStartPosition <= iKeyAt && iKeyAt < i2) {
                this.this$0.mMissingPositions.removeAt(i3);
                this.this$0.mobjectCallback.onItemLoaded(iKeyAt);
            } else {
                i3++;
            }
        }
    }

    public override void RemoveTile(int i, int i2) {
        if (isRequestedGeneration(i)) {
            androidx.recyclerview.widget.TileList$Tile<T> tileList$TileRemoveAtPos = this.this$0.mTileList.removeAtPos(i2);
            if (tileList$TileRemoveAtPos is not null) {
                this.this$0.mBackgroundProxy.recycleTile(tileList$TileRemoveAtPos);
            } else {
                android.util.Console.e("AsyncListUtil", "tile not found @" + i2);
            }
        }
    }

    public override void UpdateItemCount(int i, int i2) {
        if (isRequestedGeneration(i)) {
            this.this$0.mItemCount = i2;
            this.this$0.mobjectCallback.onDataRefresh();
            androidx.recyclerview.widget.AsyncListUtil asyncListUtil = this.this$0;
            asyncListUtil.mDisplayedGeneration = asyncListUtil.mRequestedGeneration;
            recycleAllTiles();
            this.this$0.mAllowScrollHints = false;
            this.this$0.updateRange();
        }
    }
}

