namespace WillowMaze.Wasm.Decompiled;


public abstract class DiffUtil$ItemCallback<T> {
    public abstract bool AreContentsTheSame(T t, T t2);

    public abstract bool AreItemsTheSame(T t, T t2);

    public java.lang.object GetChangePayload(T t, T t2) {
        return null;
    }
}

