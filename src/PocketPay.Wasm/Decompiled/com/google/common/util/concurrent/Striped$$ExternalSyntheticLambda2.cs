namespace WillowMaze.Wasm.Decompiled;


public readonly class Striped$$ExternalSyntheticLambda2 : com.google.common.base.Supplier {
    public readonly int f$0;

    public Striped$$ExternalSyntheticLambda2(int i) {
        this.f$0 = i;
    }

    public override readonly java.lang.object Get() {
        return com.google.common.util.concurrent.Striped.lambda$semaphore$1(this.f$0);
    }
}

