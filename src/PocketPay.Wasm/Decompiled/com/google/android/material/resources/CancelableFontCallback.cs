namespace WillowMaze.Wasm.Decompiled;


public readonly class CancelableFontCallback : com.google.android.material.resources.TextAppearanceFontCallback {
    private readonly com.google.android.material.resources.CancelableFontCallback$ApplyFont applyFont;
    private bool cancelled;
    private readonly android.graphics.Typeface fallbackFont;

    public CancelableFontCallback(com.google.android.material.resources.CancelableFontCallback$ApplyFont cancelableFontCallback$ApplyFont, android.graphics.Typeface typeface) {
        this.fallbackFont = typeface;
        this.applyFont = cancelableFontCallback$ApplyFont;
    }

    public static void HEWOCcWTRSMBXJhH(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface) {
        cancelableFontCallback.updateIfNotCancelled(typeface);
    }

    public static void HEWOCcWTRSMBXJhH(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HEWOCcWTRSMBXJhH(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HEWOCcWTRSMBXJhH(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HZqQvLXsYADIAOqu(com.google.android.material.resources.CancelableFontCallback$ApplyFont cancelableFontCallback$ApplyFont, android.graphics.Typeface typeface) {
        cancelableFontCallback$ApplyFont.apply(typeface);
    }

    public static void HZqQvLXsYADIAOqu(com.google.android.material.resources.CancelableFontCallback$ApplyFont cancelableFontCallback$ApplyFont, android.graphics.Typeface typeface, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HZqQvLXsYADIAOqu(com.google.android.material.resources.CancelableFontCallback$ApplyFont cancelableFontCallback$ApplyFont, android.graphics.Typeface typeface, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HZqQvLXsYADIAOqu(com.google.android.material.resources.CancelableFontCallback$ApplyFont cancelableFontCallback$ApplyFont, android.graphics.Typeface typeface, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YqfoUSGVraodRqMA(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface) {
        cancelableFontCallback.updateIfNotCancelled(typeface);
    }

    public static void YqfoUSGVraodRqMA(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YqfoUSGVraodRqMA(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YqfoUSGVraodRqMA(com.google.android.material.resources.CancelableFontCallback cancelableFontCallback, android.graphics.Typeface typeface, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIfNotCancelled(android.graphics.Typeface typeface) {
        if (this.cancelled) {
            return;
        }
        HZqQvLXsYADIAOqu(this.applyFont, typeface);
    }

    private void UpdateIfNotCancelled(android.graphics.Typeface typeface, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIfNotCancelled(android.graphics.Typeface typeface, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIfNotCancelled(android.graphics.Typeface typeface, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public void Cancel() {
        this.cancelled = true;
    }

    public override void OnFontRetrievalFailed(int i) {
        YqfoUSGVraodRqMA(this, this.fallbackFont);
    }

    public override void OnFontRetrieved(android.graphics.Typeface typeface, bool z) {
        HEWOCcWTRSMBXJhH(this, typeface);
    }
}

