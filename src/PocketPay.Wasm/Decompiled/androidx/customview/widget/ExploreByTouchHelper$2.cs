namespace WillowMaze.Wasm.Decompiled;


class ExploreByTouchHelper$2 : androidx.customview.widget.FocusStrategy$ICollectionAdapter<androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat>, androidx.core.view.accessibility.AccessibilityNodeInfoCompat> {
    ExploreByTouchHelper$2() {
    }

    public androidx.core.view.accessibility.AccessibilityNodeInfoCompat Get2(androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> sparseArrayCompat, int i) {
        return sparseArrayCompat.valueAt(i);
    }

    public override androidx.core.view.accessibility.AccessibilityNodeInfoCompat Get(androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> sparseArrayCompat, int i) {
        return get2(sparseArrayCompat, i);
    }

    public int Size2(androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> sparseArrayCompat) {
        return sparseArrayCompat.Count;
    }

    public override int Size(androidx.collection.SparseArrayCompat<androidx.core.view.accessibility.AccessibilityNodeInfoCompat> sparseArrayCompat) {
        return size2(sparseArrayCompat);
    }
}

