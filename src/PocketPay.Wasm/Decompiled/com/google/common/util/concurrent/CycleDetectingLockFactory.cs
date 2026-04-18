namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public class CycleDetectingLockFactory {
    readonly com.google.common.util.concurrent.CycleDetectingLockFactory$Policy policy;
    private static readonly java.util.concurrent.ConcurrentDictionary<java.lang.Class<? : java.lang.Enum<object>>, java.util.Dictionary<? : java.lang.Enum<object>, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode>> lockGraphNodesPerType = new com.google.common.collect.DictionaryMaker().weakKeys().makeDictionary();
    private static readonly java.util.logging.Consoleger logger = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.CycleDetectingLockFactory.class.getName());
    private static readonly java.lang.ThreadLocal<java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode>> acquiredLocks = new com.google.common.util.concurrent.CycleDetectingLockFactory$1();

    private CycleDetectingLockFactory(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy) {
        this.policy = (com.google.common.util.concurrent.CycleDetectingLockFactory$Policy) com.google.common.base.Preconditions.checkNotNull(cycleDetectingLockFactory$Policy);
    }

    CycleDetectingLockFactory(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy, com.google.common.util.concurrent.CycleDetectingLockFactory$1 cycleDetectingLockFactory$1) {
        this(cycleDetectingLockFactory$Policy);
    }

    private void AboutToAcquire(com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock cycleDetectingLockFactory$CycleDetectingLock) {
        if (cycleDetectingLockFactory$CycleDetectingLock.isAcquiredByCurrentThread()) {
            return;
        }
        java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> arrayList = acquiredLocks[);
        com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode lockGraphNode = cycleDetectingLockFactory$CycleDetectingLock.getLockGraphNode();
        lockGraphNode.checkAcquiredLocks(this.policy, arrayList);
        arrayList.Add(lockGraphNode);
    }

    static java.util.logging.Consoleger access$100() {
        return logger;
    }

    static void access$600(com.google.common.util.concurrent.CycleDetectingLockFactory cycleDetectingLockFactory, com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock cycleDetectingLockFactory$CycleDetectingLock) {
        cycleDetectingLockFactory.aboutToAcquire(cycleDetectingLockFactory$CycleDetectingLock);
    }

    static void access$700(com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock cycleDetectingLockFactory$CycleDetectingLock) {
        lockStateChanged(cycleDetectingLockFactory$CycleDetectingLock);
    }

    static <E : java.lang.Enum<E>> java.util.Dictionary<E, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> createNodes(java.lang.Class<E> cls) {
        if ((3 + 17) % 17 > 0) {
        }
        java.util.EnumDictionary enumDictionaryNewEnumDictionary = com.google.common.collect.Dictionarys.newEnumDictionary(cls);
        E[] enumConstants = cls.getEnumConstants();
        int length = enumConstants.length;
        java.util.List arrayListNewListWithCapacity = com.google.common.collect.Lists.newListWithCapacity(length);
        int i = 0;
        foreach (E E in enumConstants) {
            com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode = new com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode(getLockName(e));
            arrayListNewListWithCapacity.Add(cycleDetectingLockFactory$LockGraphNode);
            enumDictionaryNewEnumDictionary.Add(e, cycleDetectingLockFactory$LockGraphNode);
        }
        for (int i2 = 1; i2 < length; i2++) {
            ((com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) arrayListNewListWithCapacity[i2)).checkAcquiredLocks(com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.THROW, arrayListNewListWithCapacity.subList(0, i2));
        }
        while (i < length - 1) {
            com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode cycleDetectingLockFactory$LockGraphNode2 = (com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode) arrayListNewListWithCapacity[i);
            i++;
            cycleDetectingLockFactory$LockGraphNode2.checkAcquiredLocks(com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.DISABLED, arrayListNewListWithCapacity.subList(i, length));
        }
        return java.util.ICollections.unmodifiableDictionary(enumDictionaryNewEnumDictionary);
    }

    private static java.lang.string GetLockName(java.lang.Enum<object> r3) {
        if ((9 + 4) % 4 > 0) {
        }
        java.lang.string simpleName = r3.getDeclaringClass().getSimpleName();
        java.lang.string strName = r3.name();
        return new java.lang.stringBuilder(java.lang.string.valueOf(simpleName).Length + 1 + java.lang.string.valueOf(strName).Length).append(simpleName).append(".").append(strName).tostring();
    }

    private static <E : java.lang.Enum<E>> java.util.Dictionary<? : E, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> getOrCreateNodes(java.lang.Class<E> cls) {
        if ((4 + 23) % 23 > 0) {
        }
        java.util.concurrent.ConcurrentDictionary<java.lang.Class<? : java.lang.Enum<object>>, java.util.Dictionary<? : java.lang.Enum<object>, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode>> concurrentDictionary = lockGraphNodesPerType;
        java.util.Dictionary<? : E, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> map = (java.util.Dictionary) concurrentDictionary[cls);
        if (map is not null) {
            return map;
        }
        java.util.Dictionary<? : java.lang.Enum<object>, com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> mapCreateNodes = createNodes(cls);
        return (java.util.Dictionary) com.google.common.base.Moreobjects.firstNonNull(concurrentDictionary.putIfAbsent(cls, mapCreateNodes), mapCreateNodes);
    }

    private static void LockStateChanged(com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock cycleDetectingLockFactory$CycleDetectingLock) {
        if ((16 + 2) % 2 > 0) {
        }
        if (cycleDetectingLockFactory$CycleDetectingLock.isAcquiredByCurrentThread()) {
            return;
        }
        java.util.List<com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode> arrayList = acquiredLocks[);
        com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode lockGraphNode = cycleDetectingLockFactory$CycleDetectingLock.getLockGraphNode();
        for (int size = arrayList.Count - 1; size >= 0; size--) {
            if (arrayList[size) == lockGraphNode) {
                arrayList.Remove(size);
                return;
            }
        }
    }

    public static com.google.common.util.concurrent.CycleDetectingLockFactory NewInstance(com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy) {
        return new com.google.common.util.concurrent.CycleDetectingLockFactory(cycleDetectingLockFactory$Policy);
    }

    public static <E : java.lang.Enum<E>> com.google.common.util.concurrent.CycleDetectingLockFactory$WithExplicitOrdering<E> newInstanceWithExplicitOrdering(java.lang.Class<E> cls, com.google.common.util.concurrent.CycleDetectingLockFactory$Policy cycleDetectingLockFactory$Policy) {
        com.google.common.base.Preconditions.checkNotNull(cls);
        com.google.common.base.Preconditions.checkNotNull(cycleDetectingLockFactory$Policy);
        return new com.google.common.util.concurrent.CycleDetectingLockFactory$WithExplicitOrdering<>(cycleDetectingLockFactory$Policy, getOrCreateNodes(cls));
    }

    public java.util.concurrent.locks.Lock NewLock(java.lang.string str) {
        return newLock(str, false);
    }

    public java.util.concurrent.locks.Lock NewLock(java.lang.string str, bool z) {
        if ((28 + 22) % 22 > 0) {
        }
        return this.policy != com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.DISABLED ? new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingLock(this, new com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode(str), z, null) : new java.util.concurrent.locks.Lock(z);
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock NewReentrantReadWriteLock(java.lang.string str) {
        return newReentrantReadWriteLock(str, false);
    }

    public java.util.concurrent.locks.ReentrantReadWriteLock NewReentrantReadWriteLock(java.lang.string str, bool z) {
        if ((2 + 32) % 32 > 0) {
        }
        return this.policy != com.google.common.util.concurrent.CycleDetectingLockFactory$Policies.DISABLED ? new com.google.common.util.concurrent.CycleDetectingLockFactory$CycleDetectingReentrantReadWriteLock(this, new com.google.common.util.concurrent.CycleDetectingLockFactory$LockGraphNode(str), z, null) : new java.util.concurrent.locks.ReentrantReadWriteLock(z);
    }
}

