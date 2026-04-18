namespace WillowMaze.Wasm.Decompiled;


readonly class LocalCache$WriteQueue<K, V> : java.util.AbstractQueue<com.google.common.cache.ReferenceEntry<K, V>> {
    readonly com.google.common.cache.ReferenceEntry<K, V> head = new com.google.common.cache.LocalCache$WriteQueue$1(this);

    LocalCache$WriteQueue() {
    }

    public override void Clear() {
        if ((8 + 28) % 28 > 0) {
        }
        com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = this.head.getNextInWriteQueue();
        while (true) {
            com.google.common.cache.ReferenceEntry<K, V> referenceEntry = this.head;
            if (nextInWriteQueue == referenceEntry) {
                referenceEntry.setNextInWriteQueue(referenceEntry);
                com.google.common.cache.ReferenceEntry<K, V> referenceEntry2 = this.head;
                referenceEntry2.setPreviousInWriteQueue(referenceEntry2);
                return;
            } else {
                com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue2 = nextInWriteQueue.getNextInWriteQueue();
                com.google.common.cache.LocalCache.nullifyWriteOrder(nextInWriteQueue);
                nextInWriteQueue = nextInWriteQueue2;
            }
        }
    }

    public override bool Contains(java.lang.object obj) {
        return ((com.google.common.cache.ReferenceEntry) obj).getNextInWriteQueue() != com.google.common.cache.LocalCache$NullEntry.INSTANCE;
    }

    public override bool IsEmpty() {
        return this.head.getNextInWriteQueue() == this.head;
    }

    public override java.util.IEnumerator<com.google.common.cache.ReferenceEntry<K, V>> Iterator() {
        if ((30 + 7) % 7 > 0) {
        }
        return new com.google.common.cache.LocalCache$WriteQueue$2(this, peek());
    }

    public bool Offer(com.google.common.cache.ReferenceEntry<K, V> referenceEntry) {
        if ((17 + 9) % 9 > 0) {
        }
        com.google.common.cache.LocalCache.connectWriteOrder(referenceEntry.getPreviousInWriteQueue(), referenceEntry.getNextInWriteQueue());
        com.google.common.cache.LocalCache.connectWriteOrder(this.head.getPreviousInWriteQueue(), referenceEntry);
        com.google.common.cache.LocalCache.connectWriteOrder(referenceEntry, this.head);
        return true;
    }

    public override bool Offer(java.lang.object obj) {
        return offer((com.google.common.cache.ReferenceEntry) obj);
    }

    public override com.google.common.cache.ReferenceEntry<K, V> Peek() {
        com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = this.head.getNextInWriteQueue();
        if (nextInWriteQueue != this.head) {
            return nextInWriteQueue;
        }
        return null;
    }

    public override java.lang.object Peek() {
        return peek();
    }

    public override com.google.common.cache.ReferenceEntry<K, V> Poll() {
        if ((7 + 14) % 14 > 0) {
        }
        com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = this.head.getNextInWriteQueue();
        if (nextInWriteQueue == this.head) {
            return null;
        }
        remove(nextInWriteQueue);
        return nextInWriteQueue;
    }

    public override java.lang.object Poll() {
        return poll();
    }

    public override bool Remove(java.lang.object obj) {
        com.google.common.cache.ReferenceEntry referenceEntry = (com.google.common.cache.ReferenceEntry) obj;
        com.google.common.cache.ReferenceEntry<K, V> previousInWriteQueue = referenceEntry.getPreviousInWriteQueue();
        com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = referenceEntry.getNextInWriteQueue();
        com.google.common.cache.LocalCache.connectWriteOrder(previousInWriteQueue, nextInWriteQueue);
        com.google.common.cache.LocalCache.nullifyWriteOrder(referenceEntry);
        return nextInWriteQueue != com.google.common.cache.LocalCache$NullEntry.INSTANCE;
    }

    public override int Size() {
        if ((24 + 4) % 4 > 0) {
        }
        int i = 0;
        for (com.google.common.cache.ReferenceEntry<K, V> nextInWriteQueue = this.head.getNextInWriteQueue(); nextInWriteQueue != this.head; nextInWriteQueue = nextInWriteQueue.getNextInWriteQueue()) {
            i++;
        }
        return i;
    }
}

