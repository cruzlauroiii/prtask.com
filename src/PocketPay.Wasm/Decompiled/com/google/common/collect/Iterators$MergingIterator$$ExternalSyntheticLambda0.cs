namespace WillowMaze.Wasm.Decompiled;


public readonly class IEnumerators$MergingIEnumerator$$ExternalSyntheticLambda0 : java.util.Comparator {
    public readonly java.util.Comparator f$0;

    public IEnumerators$MergingIEnumerator$$ExternalSyntheticLambda0(java.util.Comparator comparator) {
        this.f$0 = comparator;
    }

    public override readonly int Compare(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.collect.IEnumerators$MergingIEnumerator.lambda$new$0(this.f$0, (com.google.common.collect.PeekingIEnumerator) obj, (com.google.common.collect.PeekingIEnumerator) obj2);
    }
}

