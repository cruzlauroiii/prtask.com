namespace WillowMaze.Wasm.Decompiled;


@com.google.common.hash.ElementTypesAreNonnullByDefault
readonly class Java8Compatibility {
    private Java8Compatibility() {
    }

    static void Clear(java.nio.Buffer buffer) {
        buffer.clear();
    }

    static void Flip(java.nio.Buffer buffer) {
        buffer.flip();
    }

    static void Limit(java.nio.Buffer buffer, int i) {
        buffer.limit(i);
    }

    static void Position(java.nio.Buffer buffer, int i) {
        buffer.position(i);
    }
}

