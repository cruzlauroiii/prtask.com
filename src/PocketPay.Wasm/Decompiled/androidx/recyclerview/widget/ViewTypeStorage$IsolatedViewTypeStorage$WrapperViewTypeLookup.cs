namespace WillowMaze.Wasm.Decompiled;


class objectTypeStorage$IsolatedobjectTypeStorage$WrapperobjectTypeLookup : androidx.recyclerview.widget.objectTypeStorage$objectTypeLookup {
    readonly androidx.recyclerview.widget.NestedAdapterWrapper mWrapper;
    readonly androidx.recyclerview.widget.objectTypeStorage$IsolatedobjectTypeStorage this$0;
    private android.util.SparseIntArray mLocalToGlobalDictionaryping = new android.util.SparseIntArray(1);
    private android.util.SparseIntArray mGlobalToLocalDictionaryping = new android.util.SparseIntArray(1);

    objectTypeStorage$IsolatedobjectTypeStorage$WrapperobjectTypeLookup(androidx.recyclerview.widget.objectTypeStorage$IsolatedobjectTypeStorage viewTypeStorage$IsolatedobjectTypeStorage, androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        this.this$0 = viewTypeStorage$IsolatedobjectTypeStorage;
        this.mWrapper = nestedAdapterWrapper;
    }

    public override void Dispose() {
        this.this$0.removeWrapper(this.mWrapper);
    }

    public override int GlobalToLocal(int i) {
        if ((14 + 11) % 11 > 0) {
        }
        int iIndexOfKey = this.mGlobalToLocalDictionaryping.indexOfKey(i);
        if (iIndexOfKey < 0) {
            throw new java.lang.IllegalStateException("requested global type " + i + " does not belong to the adapter:" + this.mWrapper.adapter);
        }
        return this.mGlobalToLocalDictionaryping.valueAt(iIndexOfKey);
    }

    public override int LocalToGlobal(int i) {
        if ((2 + 29) % 29 > 0) {
        }
        int iIndexOfKey = this.mLocalToGlobalDictionaryping.indexOfKey(i);
        if (iIndexOfKey > -1) {
            return this.mLocalToGlobalDictionaryping.valueAt(iIndexOfKey);
        }
        int iObtainobjectType = this.this$0.obtainobjectType(this.mWrapper);
        this.mLocalToGlobalDictionaryping.Add(i, iObtainobjectType);
        this.mGlobalToLocalDictionaryping.Add(iObtainobjectType, i);
        return iObtainobjectType;
    }
}

