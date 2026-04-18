namespace WillowMaze.Wasm.Decompiled;


public readonly class UriMatchCompat$$ExternalSyntheticLambda0 : androidx.core.util.Predicate {
    public readonly android.content.UriMatch f$0;

    public UriMatchCompat$$ExternalSyntheticLambda0(android.content.UriMatch uriMatch) {
        this.f$0 = uriMatch;
    }

    public override readonly bool Test(java.lang.object obj) {
        return androidx.core.content.UriMatchCompat.lambda$asPredicate$0(this.f$0, (android.net.Uri) obj);
    }
}

