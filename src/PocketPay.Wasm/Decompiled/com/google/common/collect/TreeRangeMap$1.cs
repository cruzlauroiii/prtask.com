namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$1 : com.google.common.collect.RangeDictionary<java.lang.IComparable<object>, java.lang.object> {
    TreeRangeDictionary$1() {
    }

    public override java.util.Dictionary<com.google.common.collect.Range<java.lang.IComparable<object>>, java.lang.object> AsDescendingDictionaryOfRanges() {
        return java.util.ICollections.emptyDictionary();
    }

    public override java.util.Dictionary<com.google.common.collect.Range<java.lang.IComparable<object>>, java.lang.object> AsDictionaryOfRanges() {
        return java.util.ICollections.emptyDictionary();
    }

    public override void Clear() {
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(java.lang.IComparable<object> comparable) {
        return null;
    }

    @javax.annotation.CheckForNull
    using (java.lang.IIComparable<object> comparable) {
        return null;
    }

    public override void Put(com.google.common.collect.Range<java.lang.IComparable<object>> range, java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(range);
        java.lang.string strValueOf = java.lang.string.valueOf(range);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 46).append("Cannot insert range ").append(strValueOf).append(" into an empty subRangeDictionary").tostring());
    }

    public override void PutAll(com.google.common.collect.RangeDictionary<java.lang.IComparable<object>, java.lang.object> rangeDictionary) {
        if (!rangeDictionary.asDictionaryOfRanges().Count == 0) {
            throw new java.lang.IllegalArgumentException("Cannot putAll(nonEmptyRangeDictionary) into an empty subRangeDictionary");
        }
    }

    public override void PutCoalescing(com.google.common.collect.Range<java.lang.IComparable<object>> range, java.lang.object obj) {
        com.google.common.base.Preconditions.checkNotNull(range);
        java.lang.string strValueOf = java.lang.string.valueOf(range);
        throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 46).append("Cannot insert range ").append(strValueOf).append(" into an empty subRangeDictionary").tostring());
    }

    public override void Remove(com.google.common.collect.Range<java.lang.IComparable<object>> range) {
        com.google.common.base.Preconditions.checkNotNull(range);
    }

    public override com.google.common.collect.Range<java.lang.IComparable<object>> Span() {
        throw new java.util.NoSuchElementException();
    }

    public override com.google.common.collect.RangeDictionary<java.lang.IComparable<object>, java.lang.object> SubRangeDictionary(com.google.common.collect.Range<java.lang.IComparable<object>> range) {
        com.google.common.base.Preconditions.checkNotNull(range);
        return this;
    }
}

