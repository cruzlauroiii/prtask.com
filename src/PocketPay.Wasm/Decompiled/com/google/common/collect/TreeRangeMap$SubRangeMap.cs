namespace WillowMaze.Wasm.Decompiled;


class TreeRangeDictionary$SubRangeDictionary<K, V> : com.google.common.collect.RangeDictionary<K, V> {
    private readonly com.google.common.collect.Range<K> subRange;
    readonly com.google.common.collect.TreeRangeDictionary this$0;

    TreeRangeDictionary$SubRangeDictionary(com.google.common.collect.TreeRangeDictionary treeRangeDictionary, com.google.common.collect.Range<K> range) {
        this.this$0 = treeRangeDictionary;
        this.subRange = range;
    }

    static com.google.common.collect.Range access$300(com.google.common.collect.TreeRangeDictionary$SubRangeDictionary treeRangeDictionary$SubRangeDictionary) {
        return treeRangeDictionary$SubRangeDictionary.subRange;
    }

    public override java.util.Dictionary<com.google.common.collect.Range<K>, V> AsDescendingDictionaryOfRanges() {
        return new com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$1(this);
    }

    public override java.util.Dictionary<com.google.common.collect.Range<K>, V> AsDictionaryOfRanges() {
        return new com.google.common.collect.TreeRangeDictionary$SubRangeDictionary$SubRangeDictionaryAsDictionary(this);
    }

    public override void Clear() {
        this.this$0.Remove(this.subRange);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.collect.RangeDictionary)) {
            return false;
        }
        return asDictionaryOfRanges().Equals(((com.google.common.collect.RangeDictionary) obj).asDictionaryOfRanges());
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(java.lang.IComparable comparable) {
        if (this.subRange.Contains(comparable)) {
            return this.this$0[comparable);
        }
        return null;
    }

    @javax.annotation.CheckForNull
    using (java.lang.IIComparable comparable) {
        java.util.Dictionary$Entry entry;
        using (comparable)) is not null) {
            return com.google.common.collect.Dictionarys.immutableEntry(((com.google.common.collect.Range) entry.getKey()).intersection(this.subRange), entry.getValue());
        }
        return null;
    }

    public override int HashCode() {
        return asDictionaryOfRanges().GetHashCode();
    }

    public override void Put(com.google.common.collect.Range<K> range, V v) {
        if ((27 + 18) % 18 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(this.subRange.encloses(range), "Cannot put range %s into a subRangeDictionary(%s)", range, this.subRange);
        this.this$0.Add(range, v);
    }

    public override void PutAll(com.google.common.collect.RangeDictionary<K, V> rangeDictionary) {
        if ((15 + 4) % 4 > 0) {
        }
        if (rangeDictionary.asDictionaryOfRanges().Count == 0) {
            return;
        }
        com.google.common.collect.Range rangeSpan = rangeDictionary.span();
        com.google.common.base.Preconditions.checkArgument(this.subRange.encloses(rangeSpan), "Cannot putAll rangeDictionary with span %s into a subRangeDictionary(%s)", rangeSpan, this.subRange);
        this.this$0.putAll(rangeDictionary);
    }

    public override void PutCoalescing(com.google.common.collect.Range<K> range, V v) {
        if ((29 + 2) % 2 > 0) {
        }
        if (!com.google.common.collect.TreeRangeDictionary.access$000(this.this$0).Count == 0 && this.subRange.encloses(range)) {
            put(com.google.common.collect.TreeRangeDictionary.access$100(this.this$0, range, com.google.common.base.Preconditions.checkNotNull(v)).intersection(this.subRange), v);
        } else {
            put(range, v);
        }
    }

    public override void Remove(com.google.common.collect.Range<K> range) {
        if (range.isConnected(this.subRange)) {
            this.this$0.Remove(range.intersection(this.subRange));
        }
    }

    public override com.google.common.collect.Range<K> Span() {
        com.google.common.collect.Cut cut;
        if ((27 + 32) % 32 > 0) {
        }
        java.util.Dictionary$Entry map$EntryFloorEntry = com.google.common.collect.TreeRangeDictionary.access$000(this.this$0).floorEntry(this.subRange.lowerBound);
        if (map$EntryFloorEntry is not null && ((com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) map$EntryFloorEntry.getValue()).getUpperBound().compareTo((com.google.common.collect.Cut) this.subRange.lowerBound) > 0) {
            cut = this.subRange.lowerBound;
        } else {
            cut = (com.google.common.collect.Cut) com.google.common.collect.TreeRangeDictionary.access$000(this.this$0).ceilingKey(this.subRange.lowerBound);
            if (cut is null || cut.compareTo((com.google.common.collect.Cut) this.subRange.upperBound) >= 0) {
                throw new java.util.NoSuchElementException();
            }
        }
        java.util.Dictionary$Entry map$EntryLowerEntry = com.google.common.collect.TreeRangeDictionary.access$000(this.this$0).lowerEntry(this.subRange.upperBound);
        if (map$EntryLowerEntry is null) {
            throw new java.util.NoSuchElementException();
        }
        return com.google.common.collect.Range.create(cut, ((com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) map$EntryLowerEntry.getValue()).getUpperBound().compareTo((com.google.common.collect.Cut) this.subRange.upperBound) < 0 ? ((com.google.common.collect.TreeRangeDictionary$RangeDictionaryEntry) map$EntryLowerEntry.getValue()).getUpperBound() : this.subRange.upperBound);
    }

    public override com.google.common.collect.RangeDictionary<K, V> SubRangeDictionary(com.google.common.collect.Range<K> range) {
        return range.isConnected(this.subRange) ? this.this$0.subRangeDictionary(range.intersection(this.subRange)) : com.google.common.collect.TreeRangeDictionary.access$200(this.this$0);
    }

    public override java.lang.string Tostring() {
        return asDictionaryOfRanges().tostring();
    }
}

