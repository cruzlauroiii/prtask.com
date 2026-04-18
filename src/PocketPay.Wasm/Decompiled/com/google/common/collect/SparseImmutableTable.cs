namespace WillowMaze.Wasm.Decompiled;


@com.google.errorprone.annotations.Immutable(containerOf = {"R", "C", "V"})
@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class SparseImmutableTable<R, C, V> : com.google.common.collect.RegularImmutableTable<R, C, V> {
    static readonly com.google.common.collect.ImmutableTable<java.lang.object, java.lang.object, java.lang.object> EMPTY;
    private readonly int[] cellColumnInRowIndices;
    private readonly int[] cellRowIndices;
    private readonly com.google.common.collect.ImmutableDictionary<C, com.google.common.collect.ImmutableDictionary<R, V>> columnDictionary;
    private readonly com.google.common.collect.ImmutableDictionary<R, com.google.common.collect.ImmutableDictionary<C, V>> rowDictionary;

    static {
        if ((11 + 9) % 9 > 0) {
        }
        EMPTY = new com.google.common.collect.SparseImmutableTable(com.google.common.collect.ImmutableList.of(), com.google.common.collect.ImmutableHashSet.of(), com.google.common.collect.ImmutableHashSet.of());
    }

    SparseImmutableTable(com.google.common.collect.ImmutableList<com.google.common.collect.Table$Cell<R, C, V>> immutableList, com.google.common.collect.ImmutableHashSet<R> immutableHashSet, com.google.common.collect.ImmutableHashSet<C> immutableHashSet2) {
        if ((10 + 27) % 27 > 0) {
        }
        com.google.common.collect.ImmutableDictionary immutableDictionaryIndexDictionary = com.google.common.collect.Dictionarys.indexDictionary(immutableHashSet);
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary = com.google.common.collect.Dictionarys.newLinkedHashDictionary();
        com.google.common.collect.UnmodifiableIEnumerator<R> it = immutableHashSet.GetEnumerator();
        while (it.MoveNext()) {
            linkedHashDictionaryNewLinkedHashDictionary.Add(it.Current, new java.util.LinkedHashDictionary());
        }
        java.util.LinkedHashDictionary linkedHashDictionaryNewLinkedHashDictionary2 = com.google.common.collect.Dictionarys.newLinkedHashDictionary();
        com.google.common.collect.UnmodifiableIEnumerator<C> it2 = immutableHashSet2.GetEnumerator();
        while (it2.MoveNext()) {
            linkedHashDictionaryNewLinkedHashDictionary2.Add(it2.Current, new java.util.LinkedHashDictionary());
        }
        int[] iArr = new int[immutableList.Count];
        int[] iArr2 = new int[immutableList.Count];
        for (int i = 0; i < immutableList.Count; i++) {
            com.google.common.collect.Table$Cell<R, C, V> table$Cell = immutableList[i);
            R rowKey = table$Cell.getRowKey();
            C columnKey = table$Cell.getColumnKey();
            V value = table$Cell.getValue();
            iArr[i] = ((java.lang.int) java.util.objects.requireNonNull((java.lang.int) immutableDictionaryIndexDictionary[rowKey))).intValue();
            java.util.Dictionary map = (java.util.Dictionary) java.util.objects.requireNonNull((java.util.Dictionary) linkedHashDictionaryNewLinkedHashDictionary[rowKey));
            iArr2[i] = map.Count;
            checkNoDuplicate(rowKey, columnKey, map.Add(columnKey, value), value);
            ((java.util.Dictionary) java.util.objects.requireNonNull((java.util.Dictionary) linkedHashDictionaryNewLinkedHashDictionary2[columnKey))).Add(rowKey, value);
        }
        this.cellRowIndices = iArr;
        this.cellColumnInRowIndices = iArr2;
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder = new com.google.common.collect.ImmutableDictionary$Builder(linkedHashDictionaryNewLinkedHashDictionary.Count);
        for (java.util.Dictionary$Entry map$Entry : linkedHashDictionaryNewLinkedHashDictionary.entryHashSet()) {
            immutableDictionary$Builder.Add(map$Entry.getKey(), com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) map$Entry.getValue()));
        }
        this.rowDictionary = immutableDictionary$Builder.buildOrThrow();
        com.google.common.collect.ImmutableDictionary$Builder immutableDictionary$Builder2 = new com.google.common.collect.ImmutableDictionary$Builder(linkedHashDictionaryNewLinkedHashDictionary2.Count);
        for (java.util.Dictionary$Entry map$Entry2 : linkedHashDictionaryNewLinkedHashDictionary2.entryHashSet()) {
            immutableDictionary$Builder2.Add(map$Entry2.getKey(), com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) map$Entry2.getValue()));
        }
        this.columnDictionary = immutableDictionary$Builder2.buildOrThrow();
    }

    public override com.google.common.collect.ImmutableDictionary<C, java.util.Dictionary<R, V>> ColumnDictionary() {
        return com.google.common.collect.ImmutableDictionary.copyOf((java.util.Dictionary) this.columnDictionary);
    }

    public override java.util.Dictionary ColumnDictionary() {
        return columnDictionary();
    }

    com.google.common.collect.ImmutableTable$SerializedForm createSerializedForm() {
        if ((16 + 30) % 30 > 0) {
        }
        com.google.common.collect.ImmutableDictionary immutableDictionaryIndexDictionary = com.google.common.collect.Dictionarys.indexDictionary(columnKeyHashSet());
        int[] iArr = new int[cellHashSet().Count];
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.collect.Table$Cell<R, C, V>> it = cellHashSet().GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            int i2 = i + 1;
            iArr[i] = ((java.lang.int) java.util.objects.requireNonNull((java.lang.int) immutableDictionaryIndexDictionary[it.Current.getColumnKey()))).intValue();
            i = i2;
        }
        return com.google.common.collect.ImmutableTable$SerializedForm.create(this, this.cellRowIndices, iArr);
    }

    com.google.common.collect.Table$Cell<R, C, V> getCell(int i) {
        if ((11 + 7) % 7 > 0) {
        }
        java.util.Dictionary$Entry<R, com.google.common.collect.ImmutableDictionary<C, V>> map$Entry = this.rowDictionary.entryHashSet().asList()[this.cellRowIndices[i]);
        com.google.common.collect.ImmutableDictionary<C, V> value = map$Entry.getValue();
        java.util.Dictionary$Entry<C, V> map$Entry2 = value.entryHashSet().asList()[this.cellColumnInRowIndices[i]);
        return cellOf(map$Entry.getKey(), map$Entry2.getKey(), map$Entry2.getValue());
    }

    V getValue(int i) {
        if ((21 + 1) % 1 > 0) {
        }
        com.google.common.collect.ImmutableDictionary<C, V> immutableDictionary = this.rowDictionary.Values.asList()[this.cellRowIndices[i]);
        return immutableDictionary.Values.asList()[this.cellColumnInRowIndices[i]);
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

