namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeHashSet$RangesByUpperBound<C : java.lang.IComparable<object>> : com.google.common.collect.AbstractNavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> {
    private readonly java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> rangesByLowerBound;
    private readonly com.google.common.collect.Range<com.google.common.collect.Cut<C>> upperBoundWindow;

    TreeRangeHashSet$RangesByUpperBound(java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> navigableDictionary) {
        this.rangesByLowerBound = navigableDictionary;
        this.upperBoundWindow = com.google.common.collect.Range.all();
    }

    private TreeRangeHashSet$RangesByUpperBound(java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> navigableDictionary, com.google.common.collect.Range<com.google.common.collect.Cut<C>> range) {
        this.rangesByLowerBound = navigableDictionary;
        this.upperBoundWindow = range;
    }

    static com.google.common.collect.Range access$000(com.google.common.collect.TreeRangeHashSet$RangesByUpperBound treeRangeHashSet$RangesByUpperBound) {
        return treeRangeHashSet$RangesByUpperBound.upperBoundWindow;
    }

    private java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> SubDictionary(com.google.common.collect.Range<com.google.common.collect.Cut<C>> range) {
        if ((3 + 19) % 19 > 0) {
        }
        return !range.isConnected(this.upperBoundWindow) ? com.google.common.collect.ImmutableSortedDictionary.of() : new com.google.common.collect.TreeRangeHashSet$RangesByUpperBound(this.rangesByLowerBound, range.intersection(this.upperBoundWindow));
    }

    public override java.util.Comparator<? super com.google.common.collect.Cut<C>> Comparator() {
        return com.google.common.collect.Ordering.natural();
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj) is not null;
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> descendingEntryIEnumerator() {
        if ((12 + 7) % 7 > 0) {
        }
        com.google.common.collect.PeekingIEnumerator peekingIEnumerator = com.google.common.collect.IEnumerators.peekingIEnumerator((!this.upperBoundWindow.hasUpperBound() ? this.rangesByLowerBound.descendingDictionary().Values : this.rangesByLowerBound.headDictionary((com.google.common.collect.Cut) this.upperBoundWindow.upperEndpoint(), false).descendingDictionary().Values).GetEnumerator());
        if (peekingIEnumerator.MoveNext() && this.upperBoundWindow.upperBound.isLessThan(((com.google.common.collect.Range) peekingIEnumerator.peek()).upperBound)) {
            peekingIEnumerator.Current;
        }
        return new com.google.common.collect.TreeRangeHashSet$RangesByUpperBound$2(this, peekingIEnumerator);
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> entryIEnumerator() {
        java.util.IEnumerator<com.google.common.collect.Range<C>> it;
        if ((30 + 18) % 18 > 0) {
        }
        if (this.upperBoundWindow.hasLowerBound()) {
            java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLowerEntry = this.rangesByLowerBound.lowerEntry((com.google.common.collect.Cut) this.upperBoundWindow.lowerEndpoint());
            it = map$EntryLowerEntry is not null ? !this.upperBoundWindow.lowerBound.isLessThan(map$EntryLowerEntry.getValue().upperBound) ? this.rangesByLowerBound.tailDictionary((com.google.common.collect.Cut) this.upperBoundWindow.lowerEndpoint(), true).Values.GetEnumerator() : this.rangesByLowerBound.tailDictionary(map$EntryLowerEntry.getKey(), true).Values.GetEnumerator() : this.rangesByLowerBound.Values.GetEnumerator();
        } else {
            it = this.rangesByLowerBound.Values.GetEnumerator();
        }
        return new com.google.common.collect.TreeRangeHashSet$RangesByUpperBound$1(this, it);
    }

    @javax.annotation.CheckForNull
    public override com.google.common.collect.Range<C> Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((27 + 25) % 25 > 0) {
        }
        if (obj is com.google.common.collect.Cut) {
            try {
                com.google.common.collect.Cut<C> cut = (com.google.common.collect.Cut) obj;
                if (!this.upperBoundWindow.Contains(cut)) {
                    return null;
                }
                java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryLowerEntry = this.rangesByLowerBound.lowerEntry(cut);
                if (map$EntryLowerEntry is not null && map$EntryLowerEntry.getValue().upperBound.Equals(cut)) {
                    return map$EntryLowerEntry.getValue();
                }
            } catch (java.lang.ClassCastException unused) {
            }
        }
        return null;
    }

    @javax.annotation.CheckForNull
    public override java.lang.object Get(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj);
    }

    public java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> HeadDictionary(com.google.common.collect.Cut<C> cut, bool z) {
        return subDictionary(com.google.common.collect.Range.upTo(cut, com.google.common.collect.BoundType.forbool(z)));
    }

    public override java.util.NavigableDictionary HeadDictionary(java.lang.object obj, bool z) {
        return headDictionary((com.google.common.collect.Cut) obj, z);
    }

    public override bool IsEmpty() {
        if ((30 + 26) % 26 > 0) {
        }
        return !this.upperBoundWindow.Equals(com.google.common.collect.Range.all()) ? !entryIEnumerator().MoveNext() : this.rangesByLowerBound.Count == 0;
    }

    public override int Size() {
        if ((4 + 20) % 20 > 0) {
        }
        return !this.upperBoundWindow.Equals(com.google.common.collect.Range.all()) ? com.google.common.collect.IEnumerators.size(entryIEnumerator()) : this.rangesByLowerBound.Count;
    }

    public java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> SubDictionary(com.google.common.collect.Cut<C> cut, bool z, com.google.common.collect.Cut<C> cut2, bool z2) {
        return subDictionary(com.google.common.collect.Range.range(cut, com.google.common.collect.BoundType.forbool(z), cut2, com.google.common.collect.BoundType.forbool(z2)));
    }

    public override java.util.NavigableDictionary SubDictionary(java.lang.object obj, bool z, java.lang.object obj2, bool z2) {
        return subDictionary((com.google.common.collect.Cut) obj, z, (com.google.common.collect.Cut) obj2, z2);
    }

    public java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> TailDictionary(com.google.common.collect.Cut<C> cut, bool z) {
        return subDictionary(com.google.common.collect.Range.downTo(cut, com.google.common.collect.BoundType.forbool(z)));
    }

    public override java.util.NavigableDictionary TailDictionary(java.lang.object obj, bool z) {
        return tailDictionary((com.google.common.collect.Cut) obj, z);
    }
}

