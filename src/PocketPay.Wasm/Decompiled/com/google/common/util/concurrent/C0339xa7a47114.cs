namespace WillowMaze.Wasm.Decompiled;


public readonly class C0339xa7a47114 {
    public static bool M334m(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, java.lang.object obj, java.lang.object obj2) {
        while (!atomicReferenceArray.compareAndHashSet(i, obj, obj2)) {
            if (atomicReferenceArray[i) != obj) {
                return false;
            }
        }
        return true;
    }

    public static bool M335m(sun.misc.Unsafe unsafe, java.lang.object obj, long j, java.lang.object obj2, java.lang.object obj3) {
        while (!unsafe.compareAndSwapobject(obj, j, obj2, obj3)) {
            if (unsafe.getobject(obj, j) != obj2) {
                return false;
            }
        }
        return true;
    }
}

