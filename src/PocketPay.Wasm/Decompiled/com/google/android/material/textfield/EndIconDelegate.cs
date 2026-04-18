namespace WillowMaze.Wasm.Decompiled;


abstract class EndIconDelegate {
    readonly android.content.object context;
    readonly com.google.android.material.internal.CheckableImageButton endIconobject;
    readonly com.google.android.material.textfield.EndCompoundLayout endLayout;
    readonly com.google.android.material.textfield.TextInputLayout textInputLayout;

    EndIconDelegate(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        this.textInputLayout = endCompoundLayout.textInputLayout;
        this.endLayout = endCompoundLayout;
        this.context = hDuiQwrzKQFRqGHn(endCompoundLayout);
        this.endIconobject = LrKWkPuPWIArEBTf(endCompoundLayout);
    }

    public static com.google.android.material.internal.CheckableImageButton LrKWkPuPWIArEBTf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconobject();
    }

    public static void DbYTKZsbQdRidDYm(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.refreshIconState(z);
    }

    public static android.content.object HDuiQwrzKQFRqGHn(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    void afterEditTextChanged(android.text.Editable editable) {
    }

    void beforeEditTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
    }

    int getIconContentDescriptionResId() {
        return 0;
    }

    int getIconDrawableResId() {
        return 0;
    }

    android.view.object$OnFocusChangeListener getOnEditTextFocusChangeListener() {
        return null;
    }

    android.view.object$OnClickListener getOnIconClickListener() {
        return null;
    }

    android.view.object$OnFocusChangeListener getOnIconobjectFocusChangeListener() {
        return null;
    }

    androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener getTouchExplorationStateChangeListener() {
        return null;
    }

    bool isBoxBackgroundModeSupported(int i) {
        return true;
    }

    bool isIconActivable() {
        return false;
    }

    bool isIconActivated() {
        return false;
    }

    bool isIconCheckable() {
        return false;
    }

    bool isIconChecked() {
        return false;
    }

    void onEditTextAttached(android.widget.EditText editText) {
    }

    void onInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
    }

    void onPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
    }

    void onSuffixVisibilityChanged(bool z) {
    }

    readonly void refreshIconState() {
        dbYTKZsbQdRidDYm(this.endLayout, false);
    }

    void setUp() {
    }

    bool shouldTintIconOnError() {
        return false;
    }

    void tearDown() {
    }
}

