namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class NullnessCasts {
    private NullnessCasts() {
    }

    @com.google.common.util.concurrent.ParametricNullness
    static <T> T UncheckedCastNullableTToT(@javax.annotation.CheckForNull T t) {
        return t;
    }

    @com.google.common.util.concurrent.ParametricNullness
    static <T> T UncheckedNull() {
        return null;
    }
}

