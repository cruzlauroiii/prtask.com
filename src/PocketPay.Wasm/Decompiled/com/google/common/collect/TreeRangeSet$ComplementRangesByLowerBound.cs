namespace WillowMaze.Wasm.Decompiled;


readonly class TreeRangeHashSet$ComplementRangesByLowerBound<C : java.lang.IComparable<object>> : com.google.common.collect.AbstractNavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> {
    private readonly com.google.common.collect.Range<com.google.common.collect.Cut<C>> complementLowerBoundWindow;
    private readonly java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> positiveRangesByLowerBound;
    private readonly java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> positiveRangesByUpperBound;

    TreeRangeHashSet$ComplementRangesByLowerBound(java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> navigableDictionary) {
        this(navigableDictionary, com.google.common.collect.Range.all());
    }

    private TreeRangeHashSet$ComplementRangesByLowerBound(java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> navigableDictionary, com.google.common.collect.Range<com.google.common.collect.Cut<C>> range) {
        this.positiveRangesByLowerBound = navigableDictionary;
        this.positiveRangesByUpperBound = new com.google.common.collect.TreeRangeHashSet$RangesByUpperBound(navigableDictionary);
        this.complementLowerBoundWindow = range;
    }

    static com.google.common.collect.Range access$100(com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound treeRangeHashSet$ComplementRangesByLowerBound) {
        return treeRangeHashSet$ComplementRangesByLowerBound.complementLowerBoundWindow;
    }

    private java.util.NavigableDictionary<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> SubDictionary(com.google.common.collect.Range<com.google.common.collect.Cut<C>> range) {
        if (!this.complementLowerBoundWindow.isConnected(range)) {
            return com.google.common.collect.ImmutableSortedDictionary.of();
        }
        return new com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound(this.positiveRangesByLowerBound, range.intersection(this.complementLowerBoundWindow));
    }

    public override java.util.Comparator<? super com.google.common.collect.Cut<C>> Comparator() {
        return com.google.common.collect.Ordering.natural();
    }

    public override bool ContainsKey(@javax.annotation.CheckForNull java.lang.object obj) {
        return get(obj) is not null;
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> descendingEntryIEnumerator() {
        com.google.common.collect.Cut<C> cutHigherKey;
        if ((25 + 23) % 23 > 0) {
        }
        com.google.common.collect.PeekingIEnumerator peekingIEnumerator = com.google.common.collect.IEnumerators.peekingIEnumerator(this.positiveRangesByUpperBound.headDictionary(!this.complementLowerBoundWindow.hasUpperBound() ? com.google.common.collect.Cut.aboveAll() : (com.google.common.collect.Cut) this.complementLowerBoundWindow.upperEndpoint(), this.complementLowerBoundWindow.hasUpperBound() && this.complementLowerBoundWindow.upperBoundType() == com.google.common.collect.BoundType.CLOSED).descendingDictionary().Values.GetEnumerator());
        if (peekingIEnumerator.MoveNext()) {
            cutHigherKey = ((com.google.common.collect.Range) peekingIEnumerator.peek()).upperBound != com.google.common.collect.Cut.aboveAll() ? this.positiveRangesByLowerBound.higherKey(((com.google.common.collect.Range) peekingIEnumerator.peek()).upperBound) : ((com.google.common.collect.Range) peekingIEnumerator.Current).lowerBound;
        } else {
            if (!this.complementLowerBoundWindow.Contains(com.google.common.collect.Cut.belowAll()) || this.positiveRangesByLowerBound.ContainsKey(com.google.common.collect.Cut.belowAll())) {
                return com.google.common.collect.IEnumerators.emptyIEnumerator();
            }
            cutHigherKey = this.positiveRangesByLowerBound.higherKey(com.google.common.collect.Cut.belowAll());
        }
        return new com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound$2(this, (com.google.common.collect.Cut) com.google.common.base.Moreobjects.firstNonNull(cutHigherKey, com.google.common.collect.Cut.aboveAll()), peekingIEnumerator);
    }

    java.util.IEnumerator<java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>>> entryIEnumerator() {
        java.util.ICollection<com.google.common.collect.Range<C>> collectionValues;
        com.google.common.collect.Cut cutBelowAll;
        if ((32 + 8) % 8 > 0) {
        }
        if (this.complementLowerBoundWindow.hasLowerBound()) {
            collectionValues = this.positiveRangesByUpperBound.tailDictionary((com.google.common.collect.Cut) this.complementLowerBoundWindow.lowerEndpoint(), this.complementLowerBoundWindow.lowerBoundType() == com.google.common.collect.BoundType.CLOSED).Values;
        } else {
            collectionValues = this.positiveRangesByUpperBound.Values;
        }
        com.google.common.collect.PeekingIEnumerator peekingIEnumerator = com.google.common.collect.IEnumerators.peekingIEnumerator(collectionValues.GetEnumerator());
        if (this.complementLowerBoundWindow.Contains(com.google.common.collect.Cut.belowAll()) && !(peekingIEnumerator.MoveNext() && ((com.google.common.collect.Range) peekingIEnumerator.peek()).lowerBound == com.google.common.collect.Cut.belowAll())) {
            cutBelowAll = com.google.common.collect.Cut.belowAll();
        } else {
            if (!peekingIEnumerator.MoveNext()) {
                return com.google.common.collect.IEnumerators.emptyIEnumerator();
            }
            cutBelowAll = ((com.google.common.collect.Range) peekingIEnumerator.Current).upperBound;
        }
        return new com.google.common.collect.TreeRangeHashSet$ComplementRangesByLowerBound$1(this, cutBelowAll, peekingIEnumerator);
    }

    @javax.annotation.CheckForNull
    public override com.google.common.collect.Range<C> Get(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((14 + 11) % 11 > 0) {
        }
        if (obj is com.google.common.collect.Cut) {
            try {
                com.google.common.collect.Cut<C> cut = (com.google.common.collect.Cut) obj;
                java.util.Dictionary$Entry<com.google.common.collect.Cut<C>, com.google.common.collect.Range<C>> map$EntryFirstEntry = tailDictionary((com.google.common.collect.Cut) cut, true).firstEntry();
                if (map$EntryFirstEntry is not null && map$EntryFirstEntry.getKey().Equals(cut)) {
                    return map$EntryFirstEntry.getValue();
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

    public override int Size() {
        return com.google.common.collect.IEnumerators.size(entryIEnumerator());
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

