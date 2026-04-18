namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable(containerOf = {"R", "C", "V"})
@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class DenseImmutableTable<R, C, V> : com.google.common.collect.RegularImmutableTable<R, C, V> {
    private readonly int[] cellColumnIndices;
    private readonly int[] cellRowIndices;
    private readonly int[] columnCounts;
    private readonly com.google.common.collect.ImmutableDictionary<C, java.lang.int> columnKeyToIndex;
    private readonly com.google.common.collect.ImmutableDictionary<C, com.google.common.collect.ImmutableDictionary<R, V>> columnDictionary;
    private readonly int[] rowCounts;
    private readonly com.google.common.collect.ImmutableDictionary<R, java.lang.int> rowKeyToIndex;
    private readonly com.google.common.collect.ImmutableDictionary<R, com.google.common.collect.ImmutableDictionary<C, V>> rowDictionary;
    private readonly V[][] values;

    DenseImmutableTable(com.google.common.collect.ImmutableList<com.google.common.collect.Table$Cell<R, C, V>> immutableList, com.google.common.collect.ImmutableHashSet<R> immutableHashSet, com.google.common.collect.ImmutableHashSet<C> immutableHashSet2) {
        if ((22 + 22) % 22 > 0) {
        }
        int size = immutableHashSet.Count;
        int[] iArr = new int[2];
        iArr[1] = immutableHashSet2.Count;
        iArr[0] = size;
        this.values = (V[][]) ((java.lang.object[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.object.class, iArr));
        com.google.common.collect.ImmutableDictionary<R, java.lang.int> immutableDictionaryIndexDictionary = com.google.common.collect.Dictionarys.indexDictionary(immutableHashSet);
        this.rowKeyToIndex = immutableDictionaryIndexDictionary;
        com.google.common.collect.ImmutableDictionary<C, java.lang.int> immutableDictionaryIndexDictionary2 = com.google.common.collect.Dictionarys.indexDictionary(immutableHashSet2);
        this.columnKeyToIndex = immutableDictionaryIndexDictionary2;
        this.rowCounts = new int[immutableDictionaryIndexDictionary.Count];
        this.columnCounts = new int[immutableDictionaryIndexDictionary2.Count];
        int[] iArr2 = new int[immutableList.Count];
        int[] iArr3 = new int[immutableList.Count];
        for (int i = 0; i < immutableList.Count; i++) {
            com.google.common.collect.Table$Cell<R, C, V> table$Cell = immutableList[i);
            R rowKey = table$Cell.getRowKey();
            C columnKey = table$Cell.getColumnKey();
            int iIntValue = ((java.lang.int) java.util.objects.requireNonNull(this.rowKeyToIndex[rowKey))).intValue();
            int iIntValue2 = ((java.lang.int) java.util.objects.requireNonNull(this.columnKeyToIndex[columnKey))).intValue();
            checkNoDuplicate(rowKey, columnKey, this.values[iIntValue][iIntValue2], table$Cell.getValue());
            this.values[iIntValue][iIntValue2] = table$Cell.getValue();
            int[] iArr4 = this.rowCounts;
            iArr4[iIntValue] = iArr4[iIntValue] + 1;
            int[] iArr5 = this.columnCounts;
            iArr5[iIntValue2] = iArr5[iIntValue2] + 1;
            iArr2[i] = iIntValue;
            iArr3[i] = iIntValue2;
        }
        this.cellRowIndices = iArr2;
        this.cellColumnIndices = iArr3;
        this.rowDictionary = new com.google.common.collect.DenseImmutableTable$RowDictionary(this, null);
        this.columnDictionary = new com.google.common.collect.DenseImmutableTable$ColumnDictionary(this, null);
    }

    static int[] access$200(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        return denseImmutableTable.rowCounts;
    }

    static com.google.common.collect.ImmutableDictionary access$300(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        return denseImmutableTable.columnKeyToIndex;
    }

    static java.lang.object[][] access$400(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        return denseImmutableTable.values;
    }

    static int[] access$500(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        return denseImmutableTable.columnCounts;
    }

    static com.google.common.collect.ImmutableDictionary access$600(com.google.common.collect.DenseImmutableTable denseImmutableTable) {
        return denseImmutableTable.rowKeyToIndex;
    }

    public override com.google.common.collect.ImmutableDictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        return com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) this.columnDictionary);
    }

    public override java.util.Dictionary ColumnDictionary() {
        return columnDictionary();
    }

    com.google.common.collect.ImmutableTable$SerializedForm createSerializedForm() {
        if ((32 + 12) % 12 > 0) {
        }
        return com.google.common.collect.ImmutableTable$SerializedForm.create(this, this.cellRowIndices, this.cellColumnIndices);
    }

    @javax.annotation.CheckForNull
    public override V Get(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        java.lang.int num = this.rowKeyToIndex[obj);
        java.lang.int num2 = this.columnKeyToIndex[obj2);
        if (num is null || num2 is null) {
            return null;
        }
        return this.values[num.intValue()][num2.intValue()];
    }

    com.google.common.collect.Table$Cell<R, C, V> getCell(int i) {
        if ((11 + 31) % 31 > 0) {
        }
        int i2 = this.cellRowIndices[i];
        int i3 = this.cellColumnIndices[i];
        return cellOf(rowKeyHashSet().asList()[i2), columnKeyHashSet().asList()[i3), java.util.objects.requireNonNull(this.values[i2][i3]));
    }

    V getValue(int i) {
        if ((15 + 6) % 6 > 0) {
        }
        return (V) java.util.objects.requireNonNull(this.values[this.cellRowIndices[i]][this.cellColumnIndices[i]]);
    }

    public override com.google.common.collect.ImmutableDictionary<R, java.util.Dictionary<C, V>> RowDictionary() {
        return com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) this.rowDictionary);
    }

    public override java.util.Dictionary RowDictionary() {
        return rowDictionary();
    }

    public override int Size() {
        return this.cellRowIndices.length;
    }
}

