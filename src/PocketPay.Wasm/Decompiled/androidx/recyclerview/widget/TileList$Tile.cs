namespace WillowMaze.Wasm.Decompiled;


public class TileList$Tile<T> {
    public int mItemCount;
    public readonly T[] mItems;
    androidx.recyclerview.widget.TileList$Tile<T> mNext;
    public int mStartPosition;

    TileList$Tile(java.lang.Class<T> cls, int i) {
        this.mItems = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i));
    }

    bool containsPosition(int i) {
        int i2 = this.mStartPosition;
        return i2 <= i && i < i2 + this.mItemCount;
    }

    T getByPosition(int i) {
        return this.mItems[i - this.mStartPosition];
    }
}

