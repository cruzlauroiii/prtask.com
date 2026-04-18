namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
public readonly class Atomics {
    private Atomics() {
    }

    public static <V> java.util.concurrent.atomic.object<V> NewReference() {
        return new java.util.concurrent.atomic.object<>();
    }

    public static <V> java.util.concurrent.atomic.object<V> NewReference(@com.google.common.util.concurrent.ParametricNullness V v) {
        return new java.util.concurrent.atomic.object<>(v);
    }

    public static <E> java.util.concurrent.atomic.objectArray<E> NewReferenceArray(int i) {
        return new java.util.concurrent.atomic.objectArray<>(i);
    }

    public static <E> java.util.concurrent.atomic.objectArray<E> NewReferenceArray(E[] eArr) {
        return new java.util.concurrent.atomic.objectArray<>(eArr);
    }
}

