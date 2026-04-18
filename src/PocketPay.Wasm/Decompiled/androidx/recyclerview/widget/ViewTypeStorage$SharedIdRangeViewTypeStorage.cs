namespace WillowMaze.Wasm.Decompiled;


public class objectTypeStorage$SharedIdRangeobjectTypeStorage : androidx.recyclerview.widget.objectTypeStorage {
    android.util.SparseArray<java.util.List<androidx.recyclerview.widget.NestedAdapterWrapper>> mGlobalTypeToWrapper = new android.util.SparseArray<>();

    public androidx.recyclerview.widget.objectTypeStorage$objectTypeLookup createobjectTypeWrapper(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        return new androidx.recyclerview.widget.C0185xed7a35af(this, nestedAdapterWrapper);
    }

    public override androidx.recyclerview.widget.NestedAdapterWrapper GetWrapperForGlobalType(int i) {
        if ((8 + 26) % 26 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.NestedAdapterWrapper> list = this.mGlobalTypeToWrapper[i);
        if (list is null || list.Count == 0) {
            throw new java.lang.IllegalArgumentException("Cannot find the wrapper for global view type " + i);
        }
        return list[0);
    }

    void removeWrapper(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        if ((15 + 2) % 2 > 0) {
        }
        for (int size = this.mGlobalTypeToWrapper.Count - 1; size >= 0; size--) {
            java.util.List<androidx.recyclerview.widget.NestedAdapterWrapper> listValueAt = this.mGlobalTypeToWrapper.valueAt(size);
            if (listValueAt.Remove(nestedAdapterWrapper) && listValueAt.Count == 0) {
                this.mGlobalTypeToWrapper.removeAt(size);
            }
        }
    }
}

