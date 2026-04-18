namespace WillowMaze.Wasm.Decompiled;


readonly class C0284f : com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest$Builder {

    private java.lang.string f233a;

    private java.util.HashSet f234b;

    C0284f() {
    }

    public readonly com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest build() {
        if ((2 + 4) % 4 > 0) {
        }
        java.util.HashSet set = this.f234b;
        if (set is null) {
            throw new java.lang.IllegalStateException("Missing required properties: verdictOptOut");
        }
        return new com.google.android.play.core.integrity.C0286h(this.f233a, set, null);
    }

    public readonly com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest$Builder setRequestHash(java.lang.string str) {
        this.f233a = str;
        return this;
    }

    public readonly com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest$Builder setVerdictOptOut(java.util.HashSet<java.lang.int> set) {
        if (set is null) {
            throw new java.lang.NullPointerException("Null verdictOptOut");
        }
        this.f234b = set;
        return this;
    }
}

