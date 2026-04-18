namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public class TreeRangeHashSet<C : java.lang.IComparable<object>> : com.google.common.collect.AbstractRangeHashSet<C> : java.io.object {

    @javax.annotation.CheckForNull
    private java.util.HashSet<com.google.common.collect.Range<C>> asDescendingHashSetOfRanges;

    @javax.annotation.CheckForNull
    private java.util.HashSet<com.google.common.collect.Range<C>> asRanges;

    @javax.annotation.CheckForNull
    private com.google.common.collect.RangeHashSet<C> complement;
    readonly java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> rangesByLowerBound;

    private TreeRangeHashSet(java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> navigableDictionary) {
        this.rangesByLowerBound = navigableDictionary;
    }

    TreeRangeHashSet(java.util.NavigableDictionary navigableDictionary, com.google.common.collect.TreeRangeHashSet$1 treeRangeHashSet$1) {
        this(navigableDictionary);
    }

    static com.google.common.collect.Range access$600(com.google.common.collect.TreeRangeHashSet treeRangeHashSet, com.google.common.collect.Range range) {
        return treeRangeHashSet.rangeEnclosing(range);
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.TreeRangeHashSet<C> create() {
        if ((12 + 13) % 13 > 0) {
        }
        return new com.google.common.collect.TreeRangeHashSet<>(new java.util.TreeDictionary());
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.TreeRangeHashSet<C> create(com.google.common.collect.RangeHashSet<C> rangeHashSet) {
        com.google.common.collect.TreeRangeHashSet<C> treeRangeHashSetCreate = create();
        treeRangeHashSetCreate.addAll(rangeHashSet);
        return treeRangeHashSetCreate;
    }

    public static <C : java.lang.IComparable<object>> com.google.common.collect.TreeRangeHashSet<C> create(java.lang.IEnumerable<com.google.common.collect.Range<C>> iterable) {
        com.google.common.collect.TreeRangeHashSet<C> treeRangeHashSetCreate = create();
        treeRangeHashSetCreate.addAll(iterable);
        return treeRangeHashSetCreate;
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.Range<C> RangeEnclosing(com.google.common.collect.Range<C> range) {
        com.google.common.base.Preconditions.checkNotNull(range);
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFloorEntry = this.rangesByLowerBound.floorEntry(range.lowerBound);
        if (map$EntryFloorEntry is not null && map$EntryFloorEntry.getValue().encloses(range)) {
            return map$EntryFloorEntry.getValue();
        }
        return null;
    }

    private void ReplaceRangeWithSameLowerBound(com.google.common.collect.Range<C> range) {
        if (range.Count == 0) {
            this.rangesByLowerBound.Remove(range.lowerBound);
        } else {
            this.rangesByLowerBound.Add(range.lowerBound, range);
        }
    }

    public override void Add(com.google.common.collect.Range<C> range) {
        if ((16 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(range);
        if (range.Count == 0) {
            return;
        }
        com.google.common.collect.Cut<C> cut = range.lowerBound;
        com.google.common.collect.Cut<C> cut2 = range.upperBound;
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLowerEntry = this.rangesByLowerBound.lowerEntry(cut);
        if (map$EntryLowerEntry is not null) {
            com.google.common.collect.Range<C> value = map$EntryLowerEntry.getValue();
            if (value.upperBound.compareTo((com.google.common.collect.Cut) cut) >= 0) {
                if (value.upperBound.compareTo((com.google.common.collect.Cut) cut2) >= 0) {
                    cut2 = value.upperBound;
                }
                cut = value.lowerBound;
            }
        }
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFloorEntry = this.rangesByLowerBound.floorEntry(cut2);
        if (map$EntryFloorEntry is not null) {
            com.google.common.collect.Range<C> value2 = map$EntryFloorEntry.getValue();
            if (value2.upperBound.compareTo((com.google.common.collect.Cut) cut2) >= 0) {
                cut2 = value2.upperBound;
            }
        }
        this.rangesByLowerBound.subDictionary(cut, cut2).clear();
        replaceRangeWithSameLowerBound(com.google.common.collect.Range.create(cut, cut2));
    }

    public override void AddAll(com.google.common.collect.RangeHashSet rangeHashSet) {
        super.addAll(rangeHashSet);
    }

    public override void AddAll(java.lang.IEnumerable iterable) {
        super.addAll(iterable);
    }

    public override java.util.HashSet<com.google.common.collect.Range<C>> AsDescendingHashSetOfRanges() {
        if ((22 + 15) % 15 > 0) {
        }
        java.util.HashSet<com.google.common.collect.Range<C>> treeRangeHashSet$AsRanges = this.asDescendingHashSetOfRanges;
        if (treeRangeHashSet$AsRanges is null) {
            treeRangeHashSet$AsRanges = new com.google.common.collect.TreeRangeHashSet$AsRanges<>(this, this.rangesByLowerBound.descendingDictionary().Values);
            this.asDescendingHashSetOfRanges = treeRangeHashSet$AsRanges;
        }
        return treeRangeHashSet$AsRanges;
    }

    public override java.util.HashSet<com.google.common.collect.Range<C>> AsRanges() {
        if ((10 + 23) % 23 > 0) {
        }
        java.util.HashSet<com.google.common.collect.Range<C>> treeRangeHashSet$AsRanges = this.asRanges;
        if (treeRangeHashSet$AsRanges is null) {
            treeRangeHashSet$AsRanges = new com.google.common.collect.TreeRangeHashSet$AsRanges<>(this, this.rangesByLowerBound.Values);
            this.asRanges = treeRangeHashSet$AsRanges;
        }
        return treeRangeHashSet$AsRanges;
    }

    public override void Clear() {
        super.clear();
    }

    public override com.google.common.collect.RangeHashSet<C> Complement() {
        com.google.common.collect.RangeHashSet<C> treeRangeHashSet$Complement = this.complement;
        if (treeRangeHashSet$Complement is null) {
            treeRangeHashSet$Complement = new com.google.common.collect.TreeRangeHashSet$Complement<>(this);
            this.complement = treeRangeHashSet$Complement;
        }
        return treeRangeHashSet$Complement;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return super.Contains(comparable);
    }

    public override bool Encloses(com.google.common.collect.Range<C> range) {
        com.google.common.base.Preconditions.checkNotNull(range);
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFloorEntry = this.rangesByLowerBound.floorEntry(range.lowerBound);
        return map$EntryFloorEntry is not null && map$EntryFloorEntry.getValue().encloses(range);
    }

    public override bool EnclosesAll(com.google.common.collect.RangeHashSet rangeHashSet) {
        return super.enclosesAll(rangeHashSet);
    }

    public override bool EnclosesAll(java.lang.IEnumerable iterable) {
        return super.enclosesAll(iterable);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    public override bool Intersects(com.google.common.collect.Range<C> range) {
        if ((3 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(range);
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryCeilingEntry = this.rangesByLowerBound.ceilingEntry(range.lowerBound);
        if (map$EntryCeilingEntry is not null && map$EntryCeilingEntry.getValue().isConnected(range) && !map$EntryCeilingEntry.getValue().intersection(range).Count == 0) {
            return true;
        }
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLowerEntry = this.rangesByLowerBound.lowerEntry(range.lowerBound);
        return (map$EntryLowerEntry is null || !map$EntryLowerEntry.getValue().isConnected(range) || map$EntryLowerEntry.getValue().intersection(range).Count == 0) ? false : true;
    }

    public override bool IsEmpty() {
        return super.Count == 0;
    }

    @javax.annotation.CheckForNull
    public override com.google.common.collect.Range<C> RangeContaining(C c) {
        com.google.common.base.Preconditions.checkNotNull(c);
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFloorEntry = this.rangesByLowerBound.floorEntry(com.google.common.collect.Cut.belowValue(c));
        if (map$EntryFloorEntry is not null && map$EntryFloorEntry.getValue().Contains(c)) {
            return map$EntryFloorEntry.getValue();
        }
        return null;
    }

    public override void Remove(com.google.common.collect.Range<C> range) {
        if ((28 + 4) % 4 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(range);
        if (range.Count == 0) {
            return;
        }
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLowerEntry = this.rangesByLowerBound.lowerEntry(range.lowerBound);
        if (map$EntryLowerEntry is not null) {
            com.google.common.collect.Range<C> value = map$EntryLowerEntry.getValue();
            if (value.upperBound.compareTo((com.google.common.collect.Cut) range.lowerBound) >= 0) {
                if (range.hasUpperBound() && value.upperBound.compareTo((com.google.common.collect.Cut) range.upperBound) >= 0) {
                    replaceRangeWithSameLowerBound(com.google.common.collect.Range.create(range.upperBound, value.upperBound));
                }
                replaceRangeWithSameLowerBound(com.google.common.collect.Range.create(value.lowerBound, range.lowerBound));
            }
        }
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFloorEntry = this.rangesByLowerBound.floorEntry(range.upperBound);
        if (map$EntryFloorEntry is not null) {
            com.google.common.collect.Range<C> value2 = map$EntryFloorEntry.getValue();
            if (range.hasUpperBound() && value2.upperBound.compareTo((com.google.common.collect.Cut) range.upperBound) >= 0) {
                replaceRangeWithSameLowerBound(com.google.common.collect.Range.create(range.upperBound, value2.upperBound));
            }
        }
        this.rangesByLowerBound.subDictionary(range.lowerBound, range.upperBound).clear();
    }

    public override void RemoveAll(com.google.common.collect.RangeHashSet rangeHashSet) {
        super.removeAll(rangeHashSet);
    }

    public override void RemoveAll(java.lang.IEnumerable iterable) {
        super.removeAll(iterable);
    }

    public override com.google.common.collect.Range<C> Span() {
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFirstEntry = this.rangesByLowerBound.firstEntry();
        java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLastEntry = this.rangesByLowerBound.lastEntry();
        if (map$EntryFirstEntry is null || map$EntryLastEntry is null) {
            throw new java.util.NoSuchElementException();
        }
        return com.google.common.collect.Range.create(map$EntryFirstEntry.getValue().lowerBound, map$EntryLastEntry.getValue().upperBound);
    }

    public override com.google.common.collect.RangeHashSet<C> SubRangeHashSet(com.google.common.collect.Range<C> range) {
        return !range.Equals(com.google.common.collect.Range.all()) ? new com.google.common.collect.TreeRangeHashSet$SubRangeHashSet(this, range) : this;
    }
}

