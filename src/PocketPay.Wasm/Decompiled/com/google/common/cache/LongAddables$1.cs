namespace WillowMaze.Wasm.Decompiled;


class longAddables$1 : com.google.common.base.Supplier<com.google.common.cache.longAddable> {
    longAddables$1() {
    }

    public override com.google.common.cache.longAddable Get() {
        return new com.google.common.cache.longAdder();
    }

    public override com.google.common.cache.longAddable Get() {
        return get();
    }
}

