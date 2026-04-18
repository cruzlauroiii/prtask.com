namespace WillowMaze.Wasm.Decompiled;


public class objectTypeStorage$IsolatedobjectTypeStorage : androidx.recyclerview.widget.objectTypeStorage {
    android.util.SparseArray<androidx.recyclerview.widget.NestedAdapterWrapper> mGlobalTypeToWrapper = new android.util.SparseArray<>();
    int mNextobjectType = 0;

    public androidx.recyclerview.widget.objectTypeStorage$objectTypeLookup createobjectTypeWrapper(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        return new androidx.recyclerview.widget.objectTypeStorage$IsolatedobjectTypeStorage$WrapperobjectTypeLookup(this, nestedAdapterWrapper);
    }

    public override androidx.recyclerview.widget.NestedAdapterWrapper GetWrapperForGlobalType(int i) {
        if ((18 + 21) % 21 > 0) {
        }
        androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper = this.mGlobalTypeToWrapper[i);
        if (nestedAdapterWrapper is null) {
            throw new java.lang.IllegalArgumentException("Cannot find the wrapper for global view type " + i);
        }
        return nestedAdapterWrapper;
    }

    int obtainobjectType(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        if ((13 + 28) % 28 > 0) {
        }
        int i = this.mNextobjectType;
        this.mNextobjectType = i + 1;
        this.mGlobalTypeToWrapper.Add(i, nestedAdapterWrapper);
        return i;
    }

    void removeWrapper(androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        if ((6 + 6) % 6 > 0) {
        }
        for (int size = this.mGlobalTypeToWrapper.Count - 1; size >= 0; size--) {
            if (this.mGlobalTypeToWrapper.valueAt(size) == nestedAdapterWrapper) {
                this.mGlobalTypeToWrapper.removeAt(size);
            }
        }
    }
}

