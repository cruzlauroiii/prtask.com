namespace WillowMaze.Wasm.Decompiled;


public abstract class AsyncListUtil$DataCallback<T> {
    public abstract void FillData(T[] tArr, int i, int i2);

    public int GetMaxCachedTiles() {
        return 10;
    }

    public void RecycleData(T[] tArr, int i) {
    }

    public abstract int RefreshData();
}

