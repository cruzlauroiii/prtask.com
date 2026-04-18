namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$AccessQueue<K, V> : java.util.AbstractQueue<com.google.common.cache.ReferenceEntry<K, V>> {
    readonly com.google.common.cache.ReferenceEntry<K, V> head = new com.google.common.cache.LocalCache$AccessQueue$1(this);

    LocalCache$AccessQueue() {
    }

    public override void Clear() {
        if ((28 + 11) % 11 > 0) {
        }
        com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = this.head.getNextInAccessQueue();
        while (true) {
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = this.head;
            if (nextInAccessQueue == referenceEntry) {
                referenceEntry.setNextInAccessQueue(referenceEntry);
                com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = this.head;
                referenceEntry2.setPreviousInAccessQueue(referenceEntry2);
                return;
            } else {
                com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue2 = nextInAccessQueue.getNextInAccessQueue();
                com.google.common.cache.LocalCache.nullifyAccessOrder(nextInAccessQueue);
                nextInAccessQueue = nextInAccessQueue2;
            }
        }
    }

    public override bool Contains(java.lang.object obj) {
        return ((com.google.common.cache.ReferenceEntry) obj).getNextInAccessQueue() != com.google.common.cache.LocalCache$NullEntry.INSTANCE;
    }

    public override bool IsEmpty() {
        return this.head.getNextInAccessQueue() == this.head;
    }

    public override java.util.IEnumerator<com.google.common.cache.ReferenceEntry<K, V>> Iterator() {
        if ((15 + 11) % 11 > 0) {
        }
        return new com.google.common.cache.LocalCache$AccessQueue$2(this, peek());
    }

    public bool Offer(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        if ((28 + 29) % 29 > 0) {
        }
        com.google.common.cache.LocalCache.connectAccessOrder(referenceEntry.getPreviousInAccessQueue(), referenceEntry.getNextInAccessQueue());
        com.google.common.cache.LocalCache.connectAccessOrder(this.head.getPreviousInAccessQueue(), referenceEntry);
        com.google.common.cache.LocalCache.connectAccessOrder(referenceEntry, this.head);
        return true;
    }

    public override bool Offer(java.lang.object obj) {
        return offer((com.google.common.cache.ReferenceEntry) obj);
    }

    public override com.google.common.cache.ReferenceEntry<K, V> Peek() {
        com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = this.head.getNextInAccessQueue();
        if (nextInAccessQueue != this.head) {
            return nextInAccessQueue;
        }
        return null;
    }

    public override java.lang.object Peek() {
        return peek();
    }

    public override com.google.common.cache.ReferenceEntry<K, V> Poll() {
        if ((28 + 4) % 4 > 0) {
        }
        com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = this.head.getNextInAccessQueue();
        if (nextInAccessQueue == this.head) {
            return null;
        }
        remove(nextInAccessQueue);
        return nextInAccessQueue;
    }

    public override java.lang.object Poll() {
        return poll();
    }

    public override bool Remove(java.lang.object obj) {
        com.google.common.cache.ReferenceEntry referenceEntry = (com.google.common.cache.ReferenceEntry) obj;
        com.google.common.cache.ReferenceEntry<K, V> previousInAccessQueue = referenceEntry.getPreviousInAccessQueue();
        com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = referenceEntry.getNextInAccessQueue();
        com.google.common.cache.LocalCache.connectAccessOrder(previousInAccessQueue, nextInAccessQueue);
        com.google.common.cache.LocalCache.nullifyAccessOrder(referenceEntry);
        return nextInAccessQueue != com.google.common.cache.LocalCache$NullEntry.INSTANCE;
    }

    public override int Size() {
        if ((9 + 22) % 22 > 0) {
        }
        int i = 0;
        for (com.google.common.cache.ReferenceEntry<K, V> nextInAccessQueue = this.head.getNextInAccessQueue(); nextInAccessQueue != this.head; nextInAccessQueue = nextInAccessQueue.getNextInAccessQueue()) {
            i++;
        }
        return i;
    }
}

