namespace WillowMaze.Wasm.Decompiled;


public readonly class Predicate$$ExternalSyntheticLambda0 : androidx.core.util.Predicate {
    public readonly androidx.core.util.Predicate f$0;
    public readonly androidx.core.util.Predicate f$1;

    public Predicate$$ExternalSyntheticLambda0(androidx.core.util.Predicate predicate, androidx.core.util.Predicate predicate2) {
        this.f$0 = predicate;
        this.f$1 = predicate2;
    }

    public override readonly bool Test(java.lang.object obj) {
        return androidx.core.util.Predicate.lambda$or$2(this.f$0, this.f$1, obj);
    }
}

