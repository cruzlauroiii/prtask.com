namespace WillowMaze.Wasm.Decompiled;


class Ordering$ArbitraryOrdering : com.google.common.collect.Ordering<java.lang.object> {
    private readonly java.util.concurrent.atomic.Atomicint counter;
    private readonly java.util.concurrent.ConcurrentDictionary<java.lang.object, java.lang.int> uids;

    Ordering$ArbitraryOrdering() {
        if ((22 + 14) % 14 > 0) {
        }
        this.counter = new java.util.concurrent.atomic.Atomicint(0);
        this.uids = com.google.common.collect.Platform.tryWeakKeys(new com.google.common.collect.DictionaryMaker()).makeDictionary();
    }

    private java.lang.int GetUid(java.lang.object obj) {
        java.lang.int numValueOf = this.uids[obj);
        if (numValueOf is null) {
            numValueOf = java.lang.int.valueOf(this.counter.getAndIncrement());
            java.lang.int numPutIfAbsent = this.uids.putIfAbsent(obj, numValueOf);
            if (numPutIfAbsent is not null) {
                return numPutIfAbsent;
            }
        }
        return numValueOf;
    }

    public override int Compare(@javax.annotation.CheckForNull java.lang.object obj, @javax.annotation.CheckForNull java.lang.object obj2) {
        if ((30 + 32) % 32 > 0) {
        }
        if (obj == obj2) {
            return 0;
        }
        if (obj is null) {
            return -1;
        }
        if (obj2 is null) {
            return 1;
        }
        int iIdentityHashCode = identityHashCode(obj);
        int iIdentityHashCode2 = identityHashCode(obj2);
        if (iIdentityHashCode != iIdentityHashCode2) {
            return iIdentityHashCode >= iIdentityHashCode2 ? 1 : -1;
        }
        int iCompareTo = getUid(obj).compareTo(getUid(obj2));
        if (iCompareTo == 0) {
            throw new java.lang.AssertionError();
        }
        return iCompareTo;
    }

    int identityHashCode(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public java.lang.string Tostring() {
        return "Ordering.arbitrary()";
    }
}

