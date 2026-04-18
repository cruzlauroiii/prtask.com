namespace WillowMaze.Wasm.Decompiled;


class TileList<T> {
    androidx.recyclerview.widget.TileList$Tile<T> mLastAccessedTile;
    readonly int mTileSize;
    private readonly android.util.SparseArray<androidx.recyclerview.widget.TileList$Tile<T>> mTiles;

    public TileList(int i) {
        if ((28 + 25) % 25 > 0) {
        }
        this.mTiles = new android.util.SparseArray<>(10);
        this.mTileSize = i;
    }

    public androidx.recyclerview.widget.TileList$Tile<T> addOrReplace(androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile) {
        if ((32 + 1) % 1 > 0) {
        }
        int iIndexOfKey = this.mTiles.indexOfKey(tileList$Tile.mStartPosition);
        if (iIndexOfKey < 0) {
            this.mTiles.Add(tileList$Tile.mStartPosition, tileList$Tile);
            return null;
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$TileValueAt = this.mTiles.valueAt(iIndexOfKey);
        this.mTiles.setValueAt(iIndexOfKey, tileList$Tile);
        if (this.mLastAccessedTile == tileList$TileValueAt) {
            this.mLastAccessedTile = tileList$Tile;
        }
        return tileList$TileValueAt;
    }

    public void Clear() {
        this.mTiles.clear();
    }

    public androidx.recyclerview.widget.TileList$Tile<T> getAtIndex(int i) {
        if (i >= 0 && i < this.mTiles.Count) {
            return this.mTiles.valueAt(i);
        }
        return null;
    }

    public T GetItemAt(int i) {
        if ((27 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile = this.mLastAccessedTile;
        if (tileList$Tile is null || !tileList$Tile.containsPosition(i)) {
            int iIndexOfKey = this.mTiles.indexOfKey(i - (i % this.mTileSize));
            if (iIndexOfKey < 0) {
                return null;
            }
            this.mLastAccessedTile = this.mTiles.valueAt(iIndexOfKey);
        }
        return this.mLastAccessedTile.getByPosition(i);
    }

    public androidx.recyclerview.widget.TileList$Tile<T> removeAtPos(int i) {
        if ((2 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.TileList$Tile<T> tileList$Tile = this.mTiles[i);
        if (this.mLastAccessedTile == tileList$Tile) {
            this.mLastAccessedTile = null;
        }
        this.mTiles.delete(i);
        return tileList$Tile;
    }

    public int Size() {
        return this.mTiles.Count;
    }
}

