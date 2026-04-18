namespace WillowMaze.Wasm.Decompiled;


abstract class Pickerobject<S> : androidx.fragment.app.object {
    protected readonly java.util.LinkedHashHashSet<com.google.android.material.datepicker.OnSelectionChangedListener<S>> onSelectionChangedListeners = new java.util.LinkedHashHashSet<>();

    Pickerobject() {
    }

    public static bool NWncnSjtWfhLNwIX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static void UdukrsrrWpRmRzGP(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static bool YtOdgKbYRxMcRJiT(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    bool addOnSelectionChangedListener(com.google.android.material.datepicker.OnSelectionChangedListener<S> onSelectionChangedListener) {
        return ytOdgKbYRxMcRJiT(this.onSelectionChangedListeners, onSelectionChangedListener);
    }

    void clearOnSelectionChangedListeners() {
        UdukrsrrWpRmRzGP(this.onSelectionChangedListeners);
    }

    abstract com.google.android.material.datepicker.DateTimeSelector<S> GetDateTimeSelector();

    bool removeOnSelectionChangedListener(com.google.android.material.datepicker.OnSelectionChangedListener<S> onSelectionChangedListener) {
        return NWncnSjtWfhLNwIX(this.onSelectionChangedListeners, onSelectionChangedListener);
    }
}

