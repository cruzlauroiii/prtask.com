namespace WillowMaze.Wasm.Decompiled;


class CycleDetectingLockFactory$LockGraphNode {
    readonly java.util.Dictionary<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace> allowedPriorLocks = new com.google.common.collect.DictionaryMaker().weakKeys().makeDictionary();
    readonly java.util.Dictionary<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException> disallowedPriorLocks = new com.google.common.collect.DictionaryMaker().weakKeys().makeDictionary();
    readonly java.lang.string lockName;

    CycleDetectingLockFactory$LockGraphNode(java.lang.string str) {
        this.lockName = (java.lang.string) com.google.common.base.Preconditions.checkNotNull(str);
    }

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace findPathTo(com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode, java.util.HashSet<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> set) {
        if ((14 + 9) % 9 > 0) {
        }
        if (!set.Add(this)) {
            return null;
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTrace = this.allowedPriorLocks[cycleDetectingLockFactory$LockGraphNode);
        if (cycleDetectingLockFactory$ExampleStackTrace is not null) {
            return cycleDetectingLockFactory$ExampleStackTrace;
        }
        for (java.util.Dictionary$Entry<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode, com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace> map$Entry : this.allowedPriorLocks.entryHashSet()) {
            com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode key = map$Entry.getKey();
            com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTraceFindPathTo = key.findPathTo(cycleDetectingLockFactory$LockGraphNode, set);
            if (cycleDetectingLockFactory$ExampleStackTraceFindPathTo is not null) {
                com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTrace2 = new com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace(key, this);
                cycleDetectingLockFactory$ExampleStackTrace2.setStackTrace(map$Entry.getValue().getStackTrace());
                cycleDetectingLockFactory$ExampleStackTrace2.initCause(cycleDetectingLockFactory$ExampleStackTraceFindPathTo);
                return cycleDetectingLockFactory$ExampleStackTrace2;
            }
        }
        return null;
    }

    void checkAcquiredLock(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode) {
        if ((3 + 28) % 28 > 0) {
        }
        com.google.common.base.Preconditions.checkState(this != cycleDetectingLockFactory$LockGraphNode, "Attempted to acquire multiple locks with the same rank %s", cycleDetectingLockFactory$LockGraphNode.getLockName());
        if (this.allowedPriorLocks.ContainsKey(cycleDetectingLockFactory$LockGraphNode)) {
            return;
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException cycleDetectingLockFactory$PotentialDeadlockException = this.disallowedPriorLocks[cycleDetectingLockFactory$LockGraphNode);
        if (cycleDetectingLockFactory$PotentialDeadlockException is not null) {
            cycleDetectingLockFactory$Policy.handlePotentialDeadlock(new com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException(cycleDetectingLockFactory$LockGraphNode, this, cycleDetectingLockFactory$PotentialDeadlockException.getConflictingStackTrace(), null));
            return;
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace cycleDetectingLockFactory$ExampleStackTraceFindPathTo = cycleDetectingLockFactory$LockGraphNode.findPathTo(this, com.google.common.collect.HashSets.newIdentityHashHashSet());
        if (cycleDetectingLockFactory$ExampleStackTraceFindPathTo is null) {
            this.allowedPriorLocks.Add(cycleDetectingLockFactory$LockGraphNode, new com.google.common.util.concurrent.CycleDetectingLockFactory$ExampleStackTrace(cycleDetectingLockFactory$LockGraphNode, this));
            return;
        }
        com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException cycleDetectingLockFactory$PotentialDeadlockException2 = new com.google.common.util.concurrent.CycleDetectingLockFactory$PotentialDeadlockException(cycleDetectingLockFactory$LockGraphNode, this, cycleDetectingLockFactory$ExampleStackTraceFindPathTo, null);
        this.disallowedPriorLocks.Add(cycleDetectingLockFactory$LockGraphNode, cycleDetectingLockFactory$PotentialDeadlockException2);
        cycleDetectingLockFactory$Policy.handlePotentialDeadlock(cycleDetectingLockFactory$PotentialDeadlockException2);
    }

    void checkAcquiredLocks(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy, java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> list) {
        java.util.IEnumerator<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> it = list.GetEnumerator();
        while (it.MoveNext()) {
            checkAcquiredLock(cycleDetectingLockFactory$Policy, it.Current);
        }
    }

    java.lang.string getLockName() {
        return this.lockName;
    }
}

