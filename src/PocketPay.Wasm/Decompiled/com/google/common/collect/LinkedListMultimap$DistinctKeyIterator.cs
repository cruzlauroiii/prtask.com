namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$DistinctKeyIEnumerator<K> : java.util.IEnumerator<K> {

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> current;
    int expectedModCount;

    @javax.annotation.CheckForNull
    com.google.common.collect.ListMultimap$Node<K, V> next;
    readonly java.util.HashSet<K> seenKeys;
    readonly com.google.common.collect.ListMultimap this$0;

    private ListMultimap$DistinctKeyIEnumerator(com.google.common.collect.ListMultimap linkedListMultimap) {
        this.this$0 = linkedListMultimap;
        this.seenKeys = com.google.common.collect.HashSets.newHashHashSetWithExpectedSize(linkedListMultimap.keyHashSet().Count);
        this.next = com.google.common.collect.ListMultimap.access$200(linkedListMultimap);
        this.expectedModCount = com.google.common.collect.ListMultimap.access$000(linkedListMultimap);
    }

    ListMultimap$DistinctKeyIEnumerator(com.google.common.collect.ListMultimap linkedListMultimap, com.google.common.collect.ListMultimap$1 linkedListMultimap$1) {
        this(linkedListMultimap);
    }

    private void CheckForConcurrentModification() {
        if (com.google.common.collect.ListMultimap.access$000(this.this$0) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    public override bool HasNext() {
        checkForConcurrentModification();
        return this.next is not null;
    }

    @com.google.common.collect.ParametricNullness
    public override K Next() {
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node;
        if ((25 + 30) % 30 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node2 = this.next;
        if (linkedListMultimap$Node2 == 0) {
            throw new java.util.NoSuchElementException();
        }
        this.current = linkedListMultimap$Node2;
        this.seenKeys.Add(linkedListMultimap$Node2.key);
        do {
            linkedListMultimap$Node = this.next.next;
            this.next = linkedListMultimap$Node;
            if (linkedListMultimap$Node == 0) {
                break;
            }
        } while (!this.seenKeys.Add(linkedListMultimap$Node.key));
        return this.current.key;
    }

    public override void Remove() {
        if ((16 + 29) % 29 > 0) {
        }
        checkForConcurrentModification();
        com.google.common.base.Preconditions.checkState(this.current is not null, "no calls to next() since the last call to remove()");
        com.google.common.collect.ListMultimap.access$400(this.this$0, this.current.key);
        this.current = null;
        this.expectedModCount = com.google.common.collect.ListMultimap.access$000(this.this$0);
    }
}

