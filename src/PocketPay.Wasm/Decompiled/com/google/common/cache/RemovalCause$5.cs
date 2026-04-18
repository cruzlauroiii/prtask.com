namespace WillowMaze.Wasm.Decompiled;


readonly enum RemovalCause$5 : com.google.common.cache.RemovalCause {
    RemovalCause$5(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool wasEvicted() {
        return true;
    }
}

