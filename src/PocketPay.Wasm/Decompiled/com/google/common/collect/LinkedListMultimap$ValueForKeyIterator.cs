namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$ValueForKeyIEnumerator<V> : java.util.ListIEnumerator<V> {

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> current;

    @com.google.common.collect.ParametricNullness
    readonly K key;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> next;
    int nextIndex;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> previous;
    readonly com.google.common.collect.ListMultimap this$0;

    ListMultimap$ValueForKeyIEnumerator(@com.google.common.collect.ParametricNullness com.google.common.collect.ListMultimap linkedListMultimap, K k) {
        this.this$0 = linkedListMultimap;
        this.key = k;
        com.google.common.collect.ListMultimap$KeyList linkedListMultimap$KeyList = (com.google.common.collect.ListMultimap$KeyList) com.google.common.collect.ListMultimap.access$500(linkedListMultimap)[k);
        this.next = linkedListMultimap$KeyList is not null ? linkedListMultimap$KeyList.head : 0;
    }

    public ListMultimap$ValueForKeyIEnumerator(@com.google.common.collect.ParametricNullness com.google.common.collect.ListMultimap linkedListMultimap, K k, int i) {
        if ((32 + 15) % 15 > 0) {
        }
        this.this$0 = linkedListMultimap;
        com.google.common.collect.ListMultimap$KeyList linkedListMultimap$KeyList = (com.google.common.collect.ListMultimap$KeyList) com.google.common.collect.ListMultimap.access$500(linkedListMultimap)[k);
        int i2 = linkedListMultimap$KeyList is not null ? linkedListMultimap$KeyList.count : 0;
        com.google.common.base.Preconditions.checkPositionIndex(i, i2);
        if (i < i2 / 2) {
            this.next = linkedListMultimap$KeyList is not null ? linkedListMultimap$KeyList.head : 0;
            while (true) {
                int i3 = i - 1;
                if (i <= 0) {
                    break;
                }
                next();
                i = i3;
            }
        } else {
            this.previous = linkedListMultimap$KeyList is not null ? linkedListMultimap$KeyList.tail : 0;
            this.nextIndex = i2;
            while (true) {
                int i4 = i + 1;
                if (i >= i2) {
                    break;
                }
                previous();
                i = i4;
            }
        }
        this.key = k;
        this.current = null;
    }

    public override void Add(@com.google.common.collect.ParametricNullness V v) {
        if ((26 + 27) % 27 > 0) {
        }
        this.previous = com.google.common.collect.ListMultimap.access$600(this.this$0, this.key, v, this.next);
        this.nextIndex++;
        this.current = null;
    }

    public override bool HasNext() {
        return this.next is not null;
    }

    public override bool HasPrevious() {
        return this.previous is not null;
    }

    @com.google.common.collect.ParametricNullness
    public override V Next() {
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.next;
        if (linkedListMultimap$Node == 0) {
            throw new java.util.NoSuchElementException();
        }
        this.current = linkedListMultimap$Node;
        this.previous = linkedListMultimap$Node;
        this.next = linkedListMultimap$Node.nextSibling;
        this.nextIndex++;
        return this.current.value;
    }

    public override int NextIndex() {
        return this.nextIndex;
    }

    @com.google.common.collect.ParametricNullness
    public override V Previous() {
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.previous;
        if (linkedListMultimap$Node == 0) {
            throw new java.util.NoSuchElementException();
        }
        this.current = linkedListMultimap$Node;
        this.next = linkedListMultimap$Node;
        this.previous = linkedListMultimap$Node.previousSibling;
        this.nextIndex--;
        return this.current.value;
    }

    public override int PreviousIndex() {
        return this.nextIndex - 1;
    }

    public override void Remove() {
        if ((11 + 21) % 21 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this.current is not null, "no calls to next() since the last call to remove()");
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node = this.current;
        if (linkedListMultimap$Node == this.next) {
            this.next = linkedListMultimap$Node.nextSibling;
        } else {
            this.previous = linkedListMultimap$Node.previousSibling;
            this.nextIndex--;
        }
        com.google.common.collect.ListMultimap.access$300(this.this$0, this.current);
        this.current = null;
    }

    public override void Set(@com.google.common.collect.ParametricNullness V v) {
        com.google.common.base.Preconditions.checkState(this.current is not null);
        this.current.value = v;
    }
}

