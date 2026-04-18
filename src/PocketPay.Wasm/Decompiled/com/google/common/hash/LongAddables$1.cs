namespace WillowMaze.Wasm.Decompiled;


class longAddables$1 : com.google.common.base.Supplier<com.google.common.hash.longAddable> {
    longAddables$1() {
    }

    public override com.google.common.hash.longAddable Get() {
        return new com.google.common.hash.longAdder();
    }

    public override com.google.common.hash.longAddable Get() {
        return get();
    }
}

