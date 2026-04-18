namespace WillowMaze.Wasm.Decompiled;


abstract class objectPager2$DataHashSetChangeObserver : androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver {
    private objectPager2$DataHashSetChangeObserver() {
    }

    objectPager2$DataHashSetChangeObserver(androidx.viewpager2.widget.objectPager2$1 viewPager2$1) {
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

