namespace WillowMaze.Wasm.Decompiled;


class EndCompoundLayout$1 : com.google.android.material.internal.TextWatcherAdapter {
    readonly com.google.android.material.textfield.EndCompoundLayout this$0;

    EndCompoundLayout$1(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        this.this$0 = endCompoundLayout;
    }

    public static void FLXmzUUGBsWqnzNn(com.google.android.material.textfield.EndIconDelegate endIconDelegate, android.text.Editable editable) {
        endIconDelegate.afterEditTextChanged(editable);
    }

    public static com.google.android.material.textfield.EndIconDelegate YeYEziCVDatLKYgd(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static com.google.android.material.textfield.EndIconDelegate EfaYxmAPHUcIqzCo(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static void RgMUacasHNDgLQcs(com.google.android.material.textfield.EndIconDelegate endIconDelegate, java.lang.CharSequence charSequence, int i, int i2, int i3) {
        endIconDelegate.beforeEditTextChanged(charSequence, i, i2, i3);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        FLXmzUUGBsWqnzNn(YeYEziCVDatLKYgd(this.this$0), editable);
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        rgMUacasHNDgLQcs(efaYxmAPHUcIqzCo(this.this$0), charSequence, i, i2, i3);
    }
}

