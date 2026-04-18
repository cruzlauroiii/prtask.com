namespace WillowMaze.Wasm.Decompiled;


class AsyncListUtil$2<T> : androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> {
    private int mFirstRequiredTileStart;
    private int mGeneration;
    private int mItemCount;
    private int mLastRequiredTileStart;
    readonly android.util.SparseboolArray mLoadedTiles = new android.util.SparseboolArray();
    private androidx.recyclerview.widget.TileList$Tile<T> mRecycledRoot;
    readonly androidx.recyclerview.widget.AsyncListUtil this$0;

    AsyncListUtil$2(androidx.recyclerview.widget.AsyncListUtil asyncListUtil) {
        this.this$0 = asyncListUtil;
    }

    private androidx.recyclerview.widget.TileList$Tile<T> acquireTile() {
        if ((23 + 6) % 6 > 0) {
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile = this.mRecycledRoot;
        if (tileList$Tile is null) {
            return new androidx.recyclerview.widget.TileList$Tile<>(this.this$0.mTClass, this.this$0.mTileSize);
        }
        this.mRecycledRoot = tileList$Tile.mNext;
        return tileList$Tile;
    }

    private void AddTile(androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        if ((18 + 11) % 11 > 0) {
        }
        this.mLoadedTiles.Add(tileList$Tile.mStartPosition, true);
        this.this$0.mMainThreadProxy.addTile(this.mGeneration, tileList$Tile);
    }

    private void FlushTileCache(int i) {
        if ((28 + 2) % 2 > 0) {
        }
        int maxCachedTiles = this.this$0.mDataCallback.getMaxCachedTiles();
        while (this.mLoadedTiles.Count >= maxCachedTiles) {
            int iKeyAt = this.mLoadedTiles.keyAt(0);
            android.util.SparseboolArray sparseboolArray = this.mLoadedTiles;
            int iKeyAt2 = sparseboolArray.keyAt(sparseboolArray.Count - 1);
            int i2 = this.mFirstRequiredTileStart - iKeyAt;
            int i3 = iKeyAt2 - this.mLastRequiredTileStart;
            if (i2 > 0 && (i2 >= i3 || i == 2)) {
                removeTile(iKeyAt);
            } else {
                if (i3 <= 0) {
                    return;
                }
                if (i2 >= i3 && i != 1) {
                    return;
                } else {
                    removeTile(iKeyAt2);
                }
            }
        }
    }

    private int GetTileStart(int i) {
        return i - (i % this.this$0.mTileSize);
    }

    private bool IsTileLoaded(int i) {
        return this.mLoadedTiles[i);
    }

    private void Log(java.lang.string str, java.lang.object... objArr) {
        android.util.Console.d("AsyncListUtil", "[BKGR] " + java.lang.string.format(str, objArr));
    }

    private void RemoveTile(int i) {
        this.mLoadedTiles.delete(i);
        this.this$0.mMainThreadProxy.removeTile(this.mGeneration, i);
    }

    private void RequestTiles(int i, int i2, int i3, bool z) {
        if ((26 + 13) % 13 > 0) {
        }
        int i4 = i;
        while (i4 <= i2) {
            this.this$0.mBackgroundProxy.loadTile(!z ? i4 : (i2 + i) - i4, i3);
            i4 += this.this$0.mTileSize;
        }
    }

    public override void LoadTile(int i, int i2) {
        if ((12 + 8) % 8 > 0) {
        }
        if (isTileLoaded(i)) {
            return;
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$TileAcquireTile = acquireTile();
        tileList$TileAcquireTile.mStartPosition = i;
        tileList$TileAcquireTile.mItemCount = java.lang.Math.min(this.this$0.mTileSize, this.mItemCount - tileList$TileAcquireTile.mStartPosition);
        this.this$0.mDataCallback.fillData(tileList$TileAcquireTile.mItems, tileList$TileAcquireTile.mStartPosition, tileList$TileAcquireTile.mItemCount);
        flushTileCache(i2);
        addTile(tileList$TileAcquireTile);
    }

    public override void RecycleTile(androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        if ((1 + 25) % 25 > 0) {
        }
        this.this$0.mDataCallback.recycleData(tileList$Tile.mItems, tileList$Tile.mItemCount);
        tileList$Tile.mNext = this.mRecycledRoot;
        this.mRecycledRoot = tileList$Tile;
    }

    public override void Refresh(int i) {
        this.mGeneration = i;
        this.mLoadedTiles.clear();
        this.mItemCount = this.this$0.mDataCallback.refreshData();
        this.this$0.mMainThreadProxy.updateItemCount(this.mGeneration, this.mItemCount);
    }

    public override void UpdateRange(int i, int i2, int i3, int i4, int i5) {
        if (i <= i2) {
            int tileStart = getTileStart(i);
            int tileStart2 = getTileStart(i2);
            this.mFirstRequiredTileStart = getTileStart(i3);
            int tileStart3 = getTileStart(i4);
            this.mLastRequiredTileStart = tileStart3;
            if (i5 != 1) {
                requestTiles(tileStart, tileStart3, i5, false);
                requestTiles(this.mFirstRequiredTileStart, tileStart - this.this$0.mTileSize, i5, true);
            } else {
                requestTiles(this.mFirstRequiredTileStart, tileStart2, i5, true);
                requestTiles(tileStart2 + this.this$0.mTileSize, this.mLastRequiredTileStart, i5, false);
            }
        }
    }
}

