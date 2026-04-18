namespace WillowMaze.Wasm.Decompiled;


readonly enum RemovalCause$4 : com.google.common.cache.RemovalCause {
    RemovalCause$4(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool wasEvicted() {
        return true;
    }
}

