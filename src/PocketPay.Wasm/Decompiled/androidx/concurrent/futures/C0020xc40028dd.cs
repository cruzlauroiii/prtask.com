namespace WillowMaze.Wasm.Decompiled;


public readonly class C0020xc40028dd {
    public static bool KwYxdYkORbxJSCWa(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return atomicReferenceFieldUpdater.compareAndHashSet(obj, obj2, obj3);
    }

    public static bool M6m(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        while (!kwYxdYkORbxJSCWa(atomicReferenceFieldUpdater, obj, obj2, obj3)) {
            if (uOkXzwiprvPlVkNo(atomicReferenceFieldUpdater, obj) != obj2) {
                return false;
            }
        }
        return true;
    }

    public static java.lang.object UOkXzwiprvPlVkNo(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, java.lang.object obj) {
        return atomicReferenceFieldUpdater[obj);
    }
}

