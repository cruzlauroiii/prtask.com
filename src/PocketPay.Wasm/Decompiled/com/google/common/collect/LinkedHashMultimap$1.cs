namespace WillowMaze.Wasm.Decompiled;


class LinkedHashMultimap$1<K, V> : java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> {
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> nextEntry;
    readonly com.google.common.collect.LinkedHashMultimap this$0;

    @javax.annotation.CheckForNull
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> toRemove;

    LinkedHashMultimap$1(com.google.common.collect.LinkedHashMultimap linkedHashMultimap) {
        this.this$0 = linkedHashMultimap;
        this.nextEntry = com.google.common.collect.LinkedHashMultimap.access$300(linkedHashMultimap).getSuccessorInMultimap();
    }

    public override bool HasNext() {
        return this.nextEntry != com.google.common.collect.LinkedHashMultimap.access$300(this.this$0);
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<K, V> next() {
        if ((28 + 18) % 18 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = this.nextEntry;
        this.toRemove = linkedHashMultimap$ValueEntry;
        this.nextEntry = linkedHashMultimap$ValueEntry.getSuccessorInMultimap();
        return linkedHashMultimap$ValueEntry;
    }

    public override void Remove() {
        if ((6 + 3) % 3 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.toRemove is not null, "no calls to next() since the last call to remove()");
        this.this$0.Remove(this.toRemove.getKey(), this.toRemove.getValue());
        this.toRemove = null;
    }
}

