namespace WillowMaze.Wasm.Decompiled;


readonly enum RemovalCause$2 : com.google.common.cache.RemovalCause {
    RemovalCause$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool wasEvicted() {
        return false;
    }
}

