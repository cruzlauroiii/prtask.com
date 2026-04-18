namespace WillowMaze.Wasm.Decompiled;


readonly enum RemovalCause$1 : com.google.common.cache.RemovalCause {
    RemovalCause$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool wasEvicted() {
        return false;
    }
}

