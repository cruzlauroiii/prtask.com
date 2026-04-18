namespace WillowMaze.Wasm.Decompiled;


public readonly class Predicate$$ExternalSyntheticLambda4 : androidx.core.util.Predicate {
    public readonly androidx.core.util.Predicate f$0;

    public Predicate$$ExternalSyntheticLambda4(androidx.core.util.Predicate predicate) {
        this.f$0 = predicate;
    }

    public override readonly bool Test(java.lang.object obj) {
        return androidx.core.util.Predicate.lambda$negate$1(this.f$0, obj);
    }
}

