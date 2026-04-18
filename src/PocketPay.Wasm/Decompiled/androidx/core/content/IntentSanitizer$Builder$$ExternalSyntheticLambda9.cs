namespace WillowMaze.Wasm.Decompiled;


public readonly class objectSanitizer$Builder$$ExternalSyntheticLambda9 : androidx.core.util.Predicate {
    public readonly java.lang.string f$0;

    public objectSanitizer$Builder$$ExternalSyntheticLambda9(java.lang.string str) {
        this.f$0 = str;
    }

    public override readonly bool Test(java.lang.object obj) {
        return androidx.core.content.objectSanitizer$Builder.lambda$allowExtraStreamUriWithAuthority$15(this.f$0, (android.net.Uri) obj);
    }
}

