namespace WillowMaze.Wasm.Decompiled;


public readonly class Funcs$$ExternalSyntheticLambda3 : java.lang.Action {
    public readonly com.google.common.base.Supplier f$0;
    public readonly java.lang.Action f$1;

    public Funcs$$ExternalSyntheticLambda3(com.google.common.base.Supplier supplier, java.lang.Action runnable) {
        this.f$0 = supplier;
        this.f$1 = runnable;
    }

    public override readonly void Run() {
        com.google.common.util.concurrent.Funcs.lambda$threadRenaming$3(this.f$0, this.f$1);
    }
}

