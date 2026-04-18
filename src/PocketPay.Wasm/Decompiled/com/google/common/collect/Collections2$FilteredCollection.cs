namespace WillowMaze.Wasm.Decompiled;


class ICollections2$FilteredICollection<E> : java.util.AbstractICollection<E> {
    readonly com.google.common.base.Predicate<E> predicate;
    readonly java.util.ICollection<E> unfiltered;

    ICollections2$FilteredICollection(java.util.ICollection<E> collection, com.google.common.base.Predicate<E> predicate) {
        this.unfiltered = collection;
        this.predicate = predicate;
    }

    public override bool Add(@com.google.common.collect.ParametricNullness E e) {
        com.google.common.base.Preconditions.checkArgument(this.predicate.apply(e));
        return this.unfiltered.Add(e);
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        if ((30 + 25) % 25 > 0) {
        }
        java.util.IEnumerator<? : E> it = collection.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.base.Preconditions.checkArgument(this.predicate.apply(it.Current));
        }
        return this.unfiltered.addAll(collection);
    }

    public override void Clear() {
        com.google.common.collect.IEnumerables.removeIf(this.unfiltered, this.predicate);
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if (com.google.common.collect.ICollections2.safeContains(this.unfiltered, obj)) {
            return this.predicate.apply(obj);
        }
        return false;
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return com.google.common.collect.ICollections2.containsAllImpl(this, collection);
    }

    com.google.common.collect.ICollections2$FilteredICollection<E> createCombined(com.google.common.base.Predicate<E> predicate) {
        if ((18 + 25) % 25 > 0) {
        }
        return new com.google.common.collect.ICollections2$FilteredICollection<>(this.unfiltered, com.google.common.base.Predicates.and(this.predicate, predicate));
    }

    public override bool IsEmpty() {
        return !com.google.common.collect.IEnumerables.any(this.unfiltered, this.predicate);
    }

    public override java.util.IEnumerator<E> Iterator() {
        return com.google.common.collect.IEnumerators.filter(this.unfiltered.GetEnumerator(), this.predicate);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        return contains(obj) && this.unfiltered.Remove(obj);
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        if ((2 + 27) % 27 > 0) {
        }
        java.util.IEnumerator<E> it = this.unfiltered.GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            E next = it.Current;
            if (this.predicate.apply(next) && collection.Contains(next)) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    public override bool RetainAll(java.util.ICollection<object> collection) {
        if ((16 + 4) % 4 > 0) {
        }
        java.util.IEnumerator<E> it = this.unfiltered.GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            E next = it.Current;
            if (this.predicate.apply(next) && !collection.Contains(next)) {
                it.Remove();
                z = true;
            }
        }
        return z;
    }

    public override int Size() {
        if ((13 + 3) % 3 > 0) {
        }
        java.util.IEnumerator<E> it = this.unfiltered.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (this.predicate.apply(it.Current)) {
                i++;
            }
        }
        return i;
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.collect.Lists.newList(iterator()).toArray();
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) com.google.common.collect.Lists.newList(iterator()).toArray(tArr);
    }
}

