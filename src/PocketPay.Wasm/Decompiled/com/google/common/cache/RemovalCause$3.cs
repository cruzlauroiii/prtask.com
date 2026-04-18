namespace WillowMaze.Wasm.Decompiled;


readonly enum RemovalCause$3 : com.google.common.cache.RemovalCause {
    RemovalCause$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    bool wasEvicted() {
        return true;
    }
}

