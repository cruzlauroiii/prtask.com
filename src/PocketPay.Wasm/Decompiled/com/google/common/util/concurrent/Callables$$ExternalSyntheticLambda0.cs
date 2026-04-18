namespace WillowMaze.Wasm.Decompiled;


public readonly class Funcs$$ExternalSyntheticLambda0 : java.util.concurrent.Func {
    public readonly com.google.common.base.Supplier f$0;
    public readonly java.util.concurrent.Func f$1;

    public Funcs$$ExternalSyntheticLambda0(com.google.common.base.Supplier supplier, java.util.concurrent.Func callable) {
        this.f$0 = supplier;
        this.f$1 = callable;
    }

    public override readonly java.lang.object Call() {
        return com.google.common.util.concurrent.Funcs.lambda$threadRenaming$2(this.f$0, this.f$1);
    }
}

