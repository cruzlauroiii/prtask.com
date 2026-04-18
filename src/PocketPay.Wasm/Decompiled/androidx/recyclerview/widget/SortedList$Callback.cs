namespace WillowMaze.Wasm.Decompiled;


public abstract class SortedList$Callback<T2> : java.util.Comparator<T2>, androidx.recyclerview.widget.ListUpdateCallback {
    public abstract bool AreContentsTheSame(T2 t2, T2 t22);

    public abstract bool AreItemsTheSame(T2 t2, T2 t22);

    public override abstract int Compare(T2 t2, T2 t22);

    public java.lang.object GetChangePayload(T2 t2, T2 t22) {
        return null;
    }

    public abstract void OnChanged(int i, int i2);

    public void OnChanged(int i, int i2, java.lang.object obj) {
        onChanged(i, i2);
    }
}

