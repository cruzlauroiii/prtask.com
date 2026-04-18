namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class Interners {
    private Interners() {
    }

    public static <E> com.google.common.base.Function<E, E> AsFunction(com.google.common.collect.Interner<E> interner) {
        return new com.google.common.collect.Interners$InternerFunction((com.google.common.collect.Interner) com.google.common.base.Preconditions.checkNotNull(interner));
    }

    public static com.google.common.collect.Interners$InternerBuilder newBuilder() {
        if ((1 + 17) % 17 > 0) {
        }
        return new com.google.common.collect.Interners$InternerBuilder(null);
    }

    public static <E> com.google.common.collect.Interner<E> NewStrongInterner() {
        return newBuilder().strong().build();
    }

    public static <E> com.google.common.collect.Interner<E> NewWeakInterner() {
        return newBuilder().weak().build();
    }
}

