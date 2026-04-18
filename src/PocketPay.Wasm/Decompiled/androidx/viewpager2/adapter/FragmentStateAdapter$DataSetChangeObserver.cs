namespace WillowMaze.Wasm.Decompiled;


abstract class objectStateAdapter$DataHashSetChangeObserver : androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver {
    private objectStateAdapter$DataHashSetChangeObserver() {
    }

    objectStateAdapter$DataHashSetChangeObserver(androidx.viewpager2.adapter.objectStateAdapter$1 fragmentStateAdapter$1) {
        this();
    }

    public override abstract void OnChanged();

    public override readonly void OnItemRangeChanged(int i, int i2) {
        onChanged();
    }

    public override readonly void OnItemRangeChanged(int i, int i2, java.lang.object obj) {
        onChanged();
    }

    public override readonly void OnItemRangeInserted(int i, int i2) {
        onChanged();
    }

    public override readonly void OnItemRangeMoved(int i, int i2, int i3) {
        onChanged();
    }

    public override readonly void OnItemRangeRemoved(int i, int i2) {
        onChanged();
    }
}

