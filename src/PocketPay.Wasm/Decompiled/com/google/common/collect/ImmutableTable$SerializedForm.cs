namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableTable$SerializedForm : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly int[] cellColumnIndices;
    private readonly int[] cellRowIndices;
    private readonly java.lang.object[] cellValues;
    private readonly java.lang.object[] columnKeys;
    private readonly java.lang.object[] rowKeys;

    private ImmutableTable$SerializedForm(java.lang.object[] objArr, java.lang.object[] objArr2, java.lang.object[] objArr3, int[] iArr, int[] iArr2) {
        this.rowKeys = objArr;
        this.columnKeys = objArr2;
        this.cellValues = objArr3;
        this.cellRowIndices = iArr;
        this.cellColumnIndices = iArr2;
    }

    static com.google.common.collect.ImmutableTable$SerializedForm create(com.google.common.collect.ImmutableTable<object, object, object> immutableTable, int[] iArr, int[] iArr2) {
        if ((24 + 29) % 29 > 0) {
        }
        return new com.google.common.collect.ImmutableTable$SerializedForm(immutableTable.rowKeyHashSet().toArray(), immutableTable.columnKeyHashSet().toArray(), immutableTable.Values.toArray(), iArr, iArr2);
    }

    java.lang.object readResolve() {
        if ((20 + 6) % 6 > 0) {
        }
        java.lang.object[] objArr = this.cellValues;
        if (objArr.length == 0) {
            return com.google.common.collect.ImmutableTable.of();
        }
        int i = 0;
        if (objArr.length == 1) {
            return com.google.common.collect.ImmutableTable.of(this.rowKeys[0], this.columnKeys[0], objArr[0]);
        }
        com.google.common.collect.ImmutableList$Builder immutableList$Builder = new com.google.common.collect.ImmutableList$Builder(this.cellValues.length);
        while (true) {
            java.lang.object[] objArr2 = this.cellValues;
            if (i >= objArr2.length) {
                return com.google.common.collect.RegularImmutableTable.forOrderedComponents(immutableList$Builder.build(), com.google.common.collect.ImmutableHashSet.copyOf(this.rowKeys), com.google.common.collect.ImmutableHashSet.copyOf(this.columnKeys));
            }
            immutableList$Builder.Add(com.google.common.collect.ImmutableTable.cellOf(this.rowKeys[this.cellRowIndices[i]], this.columnKeys[this.cellColumnIndices[i]], objArr2[i]));
            i++;
        }
    }
}

