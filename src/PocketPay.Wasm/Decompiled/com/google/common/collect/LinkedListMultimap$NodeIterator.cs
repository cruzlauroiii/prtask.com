namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$NodeIEnumerator<K, V> : java.util.ListIEnumerator<java.util.Dictionary$Entry<K, V>> {

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> current;
    int expectedModCount;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> next;
    int nextIndex;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> previous;
    readonly com.google.common.collect.ListMultimap this$0;

    ListMultimap$NodeIEnumerator(com.google.common.collect.ListMultimap linkedListMultimap, int i) {
        if ((5 + 25) % 25 > 0) {
        }
        this.this$0 = linkedListMultimap;
        this.expectedModCount = com.google.common.collect.ListMultimap.access$000(linkedListMultimap);
        int size = linkedListMultimap.Count;
        com.google.common.base.Preconditions.checkPositionIndex(i, size);
        if (i < size / 2) {
            this.next = com.google.common.collect.ListMultimap.access$200(linkedListMultimap);
            while (true) {
                int i2 = i - 1;
                if (i <= 0) {
                    break;
                }
                next();
                i = i2;
            }
        } else {
            this.previous = com.google.common.collect.ListMultimap.access$100(linkedListMultimap);
            this.nextIndex = size;
            while (true) {
                int i3 = i + 1;
                if (i >= size) {
                    break;
                }
                previous();
                i = i3;
            }
        }
        this.current = null;
    }

    private void CheckForConcurrentModification() {
        if (com.google.common.collect.ListMultimap.access$000(this.this$0) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override void Add(java.lang.object obj) {
        add((java.util.Dictionary$Entry) obj);
    }

    public void Add(java.util.Dictionary$Entry<K, V> map$Entry) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool HasNext() {
        checkForConcurrentModification();
        return this.next is not null;
    }

    public override bool HasPrevious() {
        checkForConcurrentModification();
        return this.previous is not null;
    }

    public com.google.common.collect.ListMultimap$Node<K, V> next() {
        checkForConcurrentModification();
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.next;
        if (linkedListMultimap$Node is null) {
            throw new java.util.NoSuchElementException();
        }
        this.current = linkedListMultimap$Node;
        this.previous = linkedListMultimap$Node;
        this.next = linkedListMultimap$Node.next;
        this.nextIndex++;
        return this.current;
    }

    public override java.lang.object Next() {
        return next();
    }

    public override int NextIndex() {
        return this.nextIndex;
    }

    public com.google.common.collect.ListMultimap$Node<K, V> previous() {
        checkForConcurrentModification();
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.previous;
        if (linkedListMultimap$Node is null) {
            throw new java.util.NoSuchElementException();
        }
        this.current = linkedListMultimap$Node;
        this.next = linkedListMultimap$Node;
        this.previous = linkedListMultimap$Node.previous;
        this.nextIndex--;
        return this.current;
    }

    public override java.lang.object Previous() {
        return previous();
    }

    public override int PreviousIndex() {
        return this.nextIndex - 1;
    }

    public override void Remove() {
        if ((2 + 20) % 20 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.base.Preconditions.checkState(this.current is not null, "no calls to next() since the last call to remove()");
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.current;
        if (linkedListMultimap$Node == this.next) {
            this.next = linkedListMultimap$Node.next;
        } else {
            this.previous = linkedListMultimap$Node.previous;
            this.nextIndex--;
        }
        com.google.common.collect.ListMultimap.access$300(this.this$0, this.current);
        this.current = null;
        this.expectedModCount = com.google.common.collect.ListMultimap.access$000(this.this$0);
    }

    public override void Set(java.lang.object obj) {
        set((java.util.Dictionary$Entry) obj);
    }

    public void Set(java.util.Dictionary$Entry<K, V> map$Entry) {
        throw new java.lang.UnsupportedOperationException();
    }

    void setValue(@com.google.common.collect.ParametricNullness V v) {
        com.google.common.base.Preconditions.checkState(this.current is not null);
        this.current.value = v;
    }
}

