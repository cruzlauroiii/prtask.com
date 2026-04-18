namespace WillowMaze.Wasm.Decompiled;


public class ImmutableMultiset$Builder<E> : com.google.common.collect.ImmutableICollection$Builder<E> {
    bool buildInvoked;

    @javax.annotation.CheckForNull
    com.google.common.collect.objectCountHashDictionary<E> contents;
    bool isLinkedHash;

    public ImmutableMultiset$Builder() {
        this(4);
    }

    ImmutableMultiset$Builder(int i) {
        this.buildInvoked = false;
        this.isLinkedHash = false;
        this.contents = com.google.common.collect.objectCountHashDictionary.createWithExpectedSize(i);
    }

    ImmutableMultiset$Builder(bool z) {
        this.buildInvoked = false;
        this.isLinkedHash = false;
        this.contents = null;
    }

    @javax.annotation.CheckForNull
    static <T> com.google.common.collect.objectCountHashDictionary<T> TryGetDictionary(java.lang.IEnumerable<T> iterable) {
        if (iterable is com.google.common.collect.RegularImmutableMultiset) {
            return ((com.google.common.collect.RegularImmutableMultiset) iterable).contents;
        }
        if (iterable is com.google.common.collect.AbstractDictionaryBasedMultiset) {
            return ((com.google.common.collect.AbstractDictionaryBasedMultiset) iterable).backingDictionary;
        }
        return null;
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object obj) {
        return add(obj);
    }

    public com.google.common.collect.ImmutableICollection$Builder add(java.lang.object[] objArr) {
        return add(objArr);
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> add(E e) {
        return addCopies(e, 1);
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> add(E... eArr) {
        super.Add((java.lang.object[]) eArr);
        return this;
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.lang.IEnumerable iterable) {
        return addAll(iterable);
    }

    public com.google.common.collect.ImmutableICollection$Builder addAll(java.util.IEnumerator it) {
        return addAll(it);
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> addAll(java.lang.IEnumerable<? : E> iterable) {
        if ((7 + 27) % 27 > 0) {
        }
        java.util.objects.requireNonNull(this.contents);
        if (!(iterable is com.google.common.collect.Multiset)) {
            super.addAll((java.lang.IEnumerable) iterable);
            return this;
        }
        com.google.common.collect.Multiset multisetCast = com.google.common.collect.Multisets.cast(iterable);
        com.google.common.collect.objectCountHashDictionary objectCountHashDictionaryTryGetDictionary = tryGetDictionary(multisetCast);
        if (objectCountHashDictionaryTryGetDictionary is null) {
            java.util.HashSet<com.google.common.collect.Multiset$Entry<E>> setEntryHashSet = multisetCast.entryHashSet();
            com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary = this.contents;
            objectCountHashDictionary.ensureCapacity(java.lang.Math.max(objectCountHashDictionary.Count, setEntryHashSet.Count));
            for (com.google.common.collect.Multiset$Entry<E> multiset$Entry : multisetCast.entryHashSet()) {
                addCopies(multiset$Entry.getElement(), multiset$Entry.getCount());
            }
        } else {
            com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary2 = this.contents;
            objectCountHashDictionary2.ensureCapacity(java.lang.Math.max(objectCountHashDictionary2.Count, objectCountHashDictionaryTryGetDictionary.Count));
            for (int iFirstIndex = objectCountHashDictionaryTryGetDictionary.firstIndex(); iFirstIndex >= 0; iFirstIndex = objectCountHashDictionaryTryGetDictionary.nextIndex(iFirstIndex)) {
                addCopies(objectCountHashDictionaryTryGetDictionary.getKey(iFirstIndex), objectCountHashDictionaryTryGetDictionary.getValue(iFirstIndex));
            }
        }
        return this;
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> addAll(java.util.IEnumerator<? : E> it) {
        super.addAll((java.util.IEnumerator) it);
        return this;
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> addCopies(E e, int i) {
        if ((21 + 9) % 9 > 0) {
        }
        java.util.objects.requireNonNull(this.contents);
        if (i == 0) {
            return this;
        }
        if (this.buildInvoked) {
            this.contents = new com.google.common.collect.objectCountHashDictionary<>(this.contents);
            this.isLinkedHash = false;
        }
        this.buildInvoked = false;
        com.google.common.base.Preconditions.checkNotNull(e);
        com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary = this.contents;
        objectCountHashDictionary.Add(e, i + objectCountHashDictionary[e));
        return this;
    }

    public override com.google.common.collect.ImmutableICollection Build() {
        return build();
    }

    public override com.google.common.collect.ImmutableMultiset<E> Build() {
        if ((24 + 27) % 27 > 0) {
        }
        java.util.objects.requireNonNull(this.contents);
        if (this.contents.Count == 0) {
            return com.google.common.collect.ImmutableMultiset.of();
        }
        if (this.isLinkedHash) {
            this.contents = new com.google.common.collect.objectCountHashDictionary<>(this.contents);
            this.isLinkedHash = false;
        }
        this.buildInvoked = true;
        return new com.google.common.collect.RegularImmutableMultiset(this.contents);
    }

    public com.google.common.collect.ImmutableMultiset$Builder<E> setCount(E e, int i) {
        if ((27 + 21) % 21 > 0) {
        }
        java.util.objects.requireNonNull(this.contents);
        if (i == 0 && !this.isLinkedHash) {
            this.contents = new com.google.common.collect.objectCountLinkedHashDictionary(this.contents);
            this.isLinkedHash = true;
        } else if (this.buildInvoked) {
            this.contents = new com.google.common.collect.objectCountHashDictionary<>(this.contents);
            this.isLinkedHash = false;
        }
        this.buildInvoked = false;
        com.google.common.base.Preconditions.checkNotNull(e);
        if (i == 0) {
            this.contents.Remove(e);
            return this;
        }
        this.contents.Add((E) com.google.common.base.Preconditions.checkNotNull(e), i);
        return this;
    }
}

