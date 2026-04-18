namespace WillowMaze.Wasm.Decompiled;


public readonly class objectSanitizer$Builder$$ExternalSyntheticLambda4 : androidx.core.util.Predicate {
    public readonly java.lang.Class f$0;
    public readonly androidx.core.util.Predicate f$1;

    public objectSanitizer$Builder$$ExternalSyntheticLambda4(java.lang.Class cls, androidx.core.util.Predicate predicate) {
        this.f$0 = cls;
        this.f$1 = predicate;
    }

    public override readonly bool Test(java.lang.object obj) {
        return androidx.core.content.objectSanitizer$Builder.lambda$allowExtra$13(this.f$0, this.f$1, obj);
    }
}

