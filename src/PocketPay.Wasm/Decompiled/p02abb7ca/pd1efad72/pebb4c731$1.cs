namespace WillowMaze.Wasm.Decompiled;


class pebb4c731$1<T> : dagger.internal.Provider<T> {
    readonly javax.inject.Provider val$provider;

    pebb4c731$1(javax.inject.Provider provider) {
        this.val$provider = provider;
    }

    public static java.lang.object MjIUNfpNSkARkvYt(javax.inject.Provider provider) {
        return provider[);
    }

    public T Get() {
        return (T) mjIUNfpNSkARkvYt(this.val$provider);
    }
}

