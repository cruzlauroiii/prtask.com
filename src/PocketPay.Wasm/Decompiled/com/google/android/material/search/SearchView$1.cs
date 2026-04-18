namespace WillowMaze.Wasm.Decompiled;


class Searchobject$1 : android.text.TextWatcher {
    readonly com.google.android.material.search.Searchobject this$0;

    Searchobject$1(com.google.android.material.search.Searchobject searchobject) {
        this.this$0 = searchobject;
    }

    public static void HutXiydlCePbMRbX(android.widget.ImageButton imageButton, int i) {
        imageButton.setVisibility(i);
    }

    public static void HutXiydlCePbMRbX(android.widget.ImageButton imageButton, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HutXiydlCePbMRbX(android.widget.ImageButton imageButton, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HutXiydlCePbMRbX(android.widget.ImageButton imageButton, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PUXPfYsHysDskldF(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static void PUXPfYsHysDskldF(java.lang.CharSequence charSequence, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PUXPfYsHysDskldF(java.lang.CharSequence charSequence, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PUXPfYsHysDskldF(java.lang.CharSequence charSequence, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override void AfterTextChanged(android.text.Editable editable) {
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        HutXiydlCePbMRbX(this.this$0.clearButton, pUXPfYsHysDskldF(charSequence) <= 0 ? 8 : 0);
    }
}

