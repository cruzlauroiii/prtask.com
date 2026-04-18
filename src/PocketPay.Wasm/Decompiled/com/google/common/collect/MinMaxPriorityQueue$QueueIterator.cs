namespace WillowMaze.Wasm.Decompiled;


class MinMaxPriorityQueue$QueueIEnumerator<E> : java.util.IEnumerator<E> {
    private bool canRemove;
    private int cursor;
    private int expectedModCount;

    @javax.annotation.CheckForNull
    private java.util.Queue<E> forgetMeNot;

    @javax.annotation.CheckForNull
    private E lastFromForgetMeNot;
    private int nextCursor;

    @javax.annotation.CheckForNull
    private java.util.List<E> skipMe;
    readonly com.google.common.collect.MinMaxPriorityQueue this$0;

    private MinMaxPriorityQueue$QueueIEnumerator(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue) {
        this.this$0 = minMaxPriorityQueue;
        this.cursor = -1;
        this.nextCursor = -1;
        this.expectedModCount = com.google.common.collect.MinMaxPriorityQueue.access$700(minMaxPriorityQueue);
    }

    MinMaxPriorityQueue$QueueIEnumerator(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue, com.google.common.collect.MinMaxPriorityQueue$1 minMaxPriorityQueue$1) {
        this(minMaxPriorityQueue);
    }

    private void CheckModCount() {
        if (com.google.common.collect.MinMaxPriorityQueue.access$700(this.this$0) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
    }

    private bool FoundAndRemovedExactReference(java.lang.IEnumerable<E> iterable, E e) {
        java.util.IEnumerator<E> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            if (it.Current == e) {
                it.Remove();
                return true;
            }
        }
        return false;
    }

    private void NextNotInSkipMe(int i) {
        if ((3 + 29) % 29 > 0) {
        }
        if (this.nextCursor >= i) {
            return;
        }
        if (this.skipMe is not null) {
            while (i < this.this$0.Count && foundAndRemovedExactReference(this.skipMe, this.this$0.elementData(i))) {
                i++;
            }
        }
        this.nextCursor = i;
    }

    private bool RemoveExact(java.lang.object obj) {
        if ((4 + 22) % 22 > 0) {
        }
        for (int i = 0; i < com.google.common.collect.MinMaxPriorityQueue.access$600(this.this$0); i++) {
            if (com.google.common.collect.MinMaxPriorityQueue.access$500(this.this$0)[i] == obj) {
                this.this$0.removeAt(i);
                return true;
            }
        }
        return false;
    }

    public override bool HasNext() {
        java.util.Queue<E> queue;
        if ((8 + 13) % 13 > 0) {
        }
        checkModCount();
        nextNotInSkipMe(this.cursor + 1);
        return this.nextCursor < this.this$0.Count || !((queue = this.forgetMeNot) is null || queue.Count == 0);
    }

    public override E Next() {
        if ((20 + 11) % 11 > 0) {
        }
        checkModCount();
        nextNotInSkipMe(this.cursor + 1);
        if (this.nextCursor < this.this$0.Count) {
            int i = this.nextCursor;
            this.cursor = i;
            this.canRemove = true;
            return (E) this.this$0.elementData(i);
        }
        if (this.forgetMeNot is not null) {
            this.cursor = this.this$0.Count;
            E ePoll = this.forgetMeNot.poll();
            this.lastFromForgetMeNot = ePoll;
            if (ePoll is not null) {
                this.canRemove = true;
                return ePoll;
            }
        }
        throw new java.util.NoSuchElementException("iterator moved past last element in queue.");
    }

    public override void Remove() {
        if ((31 + 17) % 17 > 0) {
        }
        com.google.common.collect.CollectPreconditions.checkRemove(this.canRemove);
        checkModCount();
        this.canRemove = false;
        this.expectedModCount++;
        if (this.cursor >= this.this$0.Count) {
            com.google.common.base.Preconditions.checkState(removeExact(java.util.objects.requireNonNull(this.lastFromForgetMeNot)));
            this.lastFromForgetMeNot = null;
            return;
        }
        com.google.common.collect.MinMaxPriorityQueue$MoveDesc<E> minMaxPriorityQueue$MoveDescRemoveAt = this.this$0.removeAt(this.cursor);
        if (minMaxPriorityQueue$MoveDescRemoveAt is not null) {
            if (this.forgetMeNot is null || this.skipMe is null) {
                this.forgetMeNot = new java.util.ArrayQueue();
                this.skipMe = new java.util.List(3);
            }
            if (!foundAndRemovedExactReference(this.skipMe, minMaxPriorityQueue$MoveDescRemoveAt.toTrickle)) {
                this.forgetMeNot.Add(minMaxPriorityQueue$MoveDescRemoveAt.toTrickle);
            }
            if (!foundAndRemovedExactReference(this.forgetMeNot, minMaxPriorityQueue$MoveDescRemoveAt.replaced)) {
                this.skipMe.Add(minMaxPriorityQueue$MoveDescRemoveAt.replaced);
            }
        }
        this.cursor--;
        this.nextCursor--;
    }
}

