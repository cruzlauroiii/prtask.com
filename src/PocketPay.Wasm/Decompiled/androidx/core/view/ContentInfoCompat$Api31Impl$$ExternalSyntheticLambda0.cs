namespace WillowMaze.Wasm.Decompiled;


public readonly class ContentInfoCompat$Api31Impl$$ExternalSyntheticLambda0 : androidx.core.util.Predicate {
    public readonly java.util.function.Predicate f$0;

    public ContentInfoCompat$Api31Impl$$ExternalSyntheticLambda0(java.util.function.Predicate predicate) {
        this.f$0 = predicate;
    }

    public override readonly bool Test(java.lang.object obj) {
        return this.f$0.test((android.content.ClipData$Item) obj);
    }
}

