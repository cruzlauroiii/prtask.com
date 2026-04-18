namespace WillowMaze.Wasm.Decompiled;


public abstract class DiffUtil$Callback {
    public abstract bool AreContentsTheSame(int i, int i2);

    public abstract bool AreItemsTheSame(int i, int i2);

    public java.lang.object GetChangePayload(int i, int i2) {
        return null;
    }

    public abstract int GetNewListSize();

    public abstract int GetOldListSize();
}

