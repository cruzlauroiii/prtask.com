namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class NullnessCasts {
    private NullnessCasts() {
    }

    @com.google.common.collect.ParametricNullness
    static <T> T UncheckedCastNullableTToT(@javax.annotation.CheckForNull T t) {
        return t;
    }

    @com.google.common.collect.ParametricNullness
    static <T> T UnsafeNull() {
        return null;
    }
}

