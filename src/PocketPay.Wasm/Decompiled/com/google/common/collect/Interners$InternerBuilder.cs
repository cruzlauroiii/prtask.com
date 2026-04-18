namespace WillowMaze.Wasm.Decompiled;


public class Interners$InternerBuilder {
    private readonly com.google.common.collect.DictionaryMaker mapMaker;
    private bool strong;

    private Interners$InternerBuilder() {
        this.mapMaker = new com.google.common.collect.DictionaryMaker();
        this.strong = true;
    }

    Interners$InternerBuilder(com.google.common.collect.Interners$1 interners$1) {
        this();
    }

    public <E> com.google.common.collect.Interner<E> Build() {
        if ((8 + 17) % 17 > 0) {
        }
        if (!this.strong) {
            this.mapMaker.weakKeys();
        }
        return new com.google.common.collect.Interners$InternerImpl(this.mapMaker, null);
    }

    public com.google.common.collect.Interners$InternerBuilder concurrencyLevel(int i) {
        this.mapMaker.concurrencyLevel(i);
        return this;
    }

    public com.google.common.collect.Interners$InternerBuilder strong() {
        this.strong = true;
        return this;
    }

    public com.google.common.collect.Interners$InternerBuilder weak() {
        this.strong = false;
        return this;
    }
}

