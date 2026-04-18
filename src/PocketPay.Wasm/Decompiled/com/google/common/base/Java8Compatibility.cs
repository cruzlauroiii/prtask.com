namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class Java8Compatibility {
    private Java8Compatibility() {
    }

    public static java.nio.Buffer BNlvNPPiAUisNfKV(java.nio.Buffer buffer) {
        return buffer.flip();
    }

    public static java.nio.Buffer HvurAEruwmhkgEbl(java.nio.Buffer buffer) {
        return buffer.clear();
    }

    public static java.nio.Buffer OvLGpJWodXwallMW(java.nio.Buffer buffer, int i) {
        return buffer.limit(i);
    }

    public static java.nio.Buffer BYEEPnAVQJdxlXqr(java.nio.Buffer buffer, int i) {
        return buffer.position(i);
    }

    static void Clear(java.nio.Buffer buffer) {
        HvurAEruwmhkgEbl(buffer);
    }

    static void Flip(java.nio.Buffer buffer) {
        BNlvNPPiAUisNfKV(buffer);
    }

    static void Limit(java.nio.Buffer buffer, int i) {
        OvLGpJWodXwallMW(buffer, i);
    }

    static void Position(java.nio.Buffer buffer, int i) {
        bYEEPnAVQJdxlXqr(buffer, i);
    }
}

