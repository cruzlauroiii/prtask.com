namespace WillowMaze.Wasm.Decompiled;


public readonly class Striped$$ExternalSyntheticLambda3 : com.google.common.base.Supplier {
    public readonly int f$0;

    public Striped$$ExternalSyntheticLambda3(int i) {
        this.f$0 = i;
    }

    public override readonly java.lang.object Get() {
        return com.google.common.util.concurrent.Striped.lambda$lazyWeakSemaphoreSlim$2(this.f$0);
    }
}

