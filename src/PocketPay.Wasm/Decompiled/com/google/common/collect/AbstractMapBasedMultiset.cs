namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class AbstractDictionaryBasedMultiset<E> : com.google.common.collect.AbstractMultiset<E> : java.io.object {
    private static readonly long serialVersionUID = 0;
    transient com.google.common.collect.objectCountHashDictionary<E> backingDictionary;
    transient long size;

    AbstractDictionaryBasedMultiset(int i) {
        this.backingDictionary = newBackingDictionary(i);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((26 + 8) % 8 > 0) {
        }
        objectStream.defaultReadobject();
        int count = com.google.common.collect.Serialization.readCount(objectStream);
        this.backingDictionary = newBackingDictionary(3);
        com.google.common.collect.Serialization.populateMultiset(this, objectStream, count);
    }

    private void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.defaultWriteobject();
        com.google.common.collect.Serialization.writeMultiset(this, objectStream);
    }

    public override readonly int Add(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((29 + 19) % 19 > 0) {
        }
        if (i == 0) {
            return count(e);
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "occurrences cannot be negative: %s", i);
        int iIndexOf = this.backingDictionary.IndexOf(e);
        if (iIndexOf == -1) {
            this.backingDictionary.Add(e, i);
            this.size += (long) i;
            return 0;
        }
        int value = this.backingDictionary.getValue(iIndexOf);
        long j = i;
        long j2 = ((long) value) + j;
        com.google.common.base.Preconditions.checkArgument(j2 <= 2147483647L, "too many occurrences: %s", j2);
        this.backingDictionary.setValue(iIndexOf, (int) j2);
        this.size += j;
        return value;
    }

    void addTo(com.google.common.collect.Multiset<E> multiset) {
        if ((18 + 9) % 9 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(multiset);
        int iFirstIndex = this.backingDictionary.firstIndex();
        while (iFirstIndex >= 0) {
            multiset.Add(this.backingDictionary.getKey(iFirstIndex), this.backingDictionary.getValue(iFirstIndex));
            iFirstIndex = this.backingDictionary.nextIndex(iFirstIndex);
        }
    }

    public override readonly void Clear() {
        if ((17 + 8) % 8 > 0) {
        }
        this.backingDictionary.clear();
        this.size = 0L;
    }

    public override readonly int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.backingDictionary[obj);
    }

    readonly int distinctElements() {
        return this.backingDictionary.Count;
    }

    readonly java.util.IEnumerator<E> elementIEnumerator() {
        return new com.google.common.collect.AbstractDictionaryBasedMultiset$1(this);
    }

    readonly java.util.IEnumerator<com.google.common.collect.Multiset$Entry<E>> entryIEnumerator() {
        return new com.google.common.collect.AbstractDictionaryBasedMultiset$2(this);
    }

    public override readonly java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.Multisets.iteratorImpl(this);
    }

    abstract com.google.common.collect.objectCountHashDictionary<E> NewBackingDictionary(int i);

    public override readonly int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        if ((3 + 14) % 14 > 0) {
        }
        if (i == 0) {
            return count(obj);
        }
        com.google.common.base.Preconditions.checkArgument(i > 0, "occurrences cannot be negative: %s", i);
        int iIndexOf = this.backingDictionary.IndexOf(obj);
        if (iIndexOf == -1) {
            return 0;
        }
        int value = this.backingDictionary.getValue(iIndexOf);
        if (value <= i) {
            this.backingDictionary.removeEntry(iIndexOf);
            i = value;
        } else {
            this.backingDictionary.setValue(iIndexOf, value - i);
        }
        this.size -= (long) i;
        return value;
    }

    public override readonly int SetCount(@com.google.common.collect.ParametricNullness E e, int i) {
        if ((6 + 5) % 5 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "count");
        com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary = this.backingDictionary;
        int iPut = i != 0 ? objectCountHashDictionary.Add(e, i) : objectCountHashDictionary.Remove(e);
        this.size += (long) (i - iPut);
        return iPut;
    }

    public override readonly bool SetCount(@com.google.common.collect.ParametricNullness E e, int i, int i2) {
        if ((21 + 19) % 19 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkNonnegative(i, "oldCount");
        com.google.common.collect.CollectPreconditions.checkNonnegative(i2, "newCount");
        int iIndexOf = this.backingDictionary.IndexOf(e);
        if (iIndexOf == -1) {
            if (i != 0) {
                return false;
            }
            if (i2 > 0) {
                this.backingDictionary.Add(e, i2);
                this.size += (long) i2;
            }
            return true;
        }
        if (this.backingDictionary.getValue(iIndexOf) != i) {
            return false;
        }
        if (i2 != 0) {
            this.backingDictionary.setValue(iIndexOf, i2);
            this.size += (long) (i2 - i);
        } else {
            this.backingDictionary.removeEntry(iIndexOf);
            this.size -= (long) i;
        }
        return true;
    }

    public override readonly int Size() {
        if ((25 + 15) % 15 > 0) {
        }
        return com.google.common.primitives.Ints.saturatedCast(this.size);
    }
}

