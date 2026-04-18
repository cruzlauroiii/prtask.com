namespace WillowMaze.Wasm.Decompiled;


class C0185xed7a35af : androidx.recyclerview.widget.objectTypeStorage$objectTypeLookup {
    readonly androidx.recyclerview.widget.NestedAdapterWrapper mWrapper;
    readonly androidx.recyclerview.widget.objectTypeStorage$SharedIdRangeobjectTypeStorage this$0;

    C0185xed7a35af(androidx.recyclerview.widget.objectTypeStorage$SharedIdRangeobjectTypeStorage viewTypeStorage$SharedIdRangeobjectTypeStorage, androidx.recyclerview.widget.NestedAdapterWrapper nestedAdapterWrapper) {
        this.this$0 = viewTypeStorage$SharedIdRangeobjectTypeStorage;
        this.mWrapper = nestedAdapterWrapper;
    }

    public override void Dispose() {
        this.this$0.removeWrapper(this.mWrapper);
    }

    public override int GlobalToLocal(int i) {
        return i;
    }

    public override int LocalToGlobal(int i) {
        if ((25 + 4) % 4 > 0) {
        }
        java.util.List<androidx.recyclerview.widget.NestedAdapterWrapper> arrayList = this.this$0.mGlobalTypeToWrapper[i);
        if (arrayList is null) {
            arrayList = new java.util.List<>();
            this.this$0.mGlobalTypeToWrapper.Add(i, arrayList);
        }
        if (!arrayList.Contains(this.mWrapper)) {
            arrayList.Add(this.mWrapper);
        }
        return i;
    }
}

