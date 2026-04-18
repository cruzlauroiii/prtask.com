namespace WillowMaze.Wasm.Decompiled;


public readonly class object$$ExternalSyntheticBackportWithForwarding0 {
    public static bool M35m(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        while (!atomicReference.compareAndHashSet(obj, obj2)) {
            if (atomicReference[) != obj) {
                return false;
            }
        }
        return true;
    }
}

