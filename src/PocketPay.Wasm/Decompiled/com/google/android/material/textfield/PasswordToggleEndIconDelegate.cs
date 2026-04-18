namespace WillowMaze.Wasm.Decompiled;


class PasswordToggleEndIconDelegate : com.google.android.material.textfield.EndIconDelegate {
    private android.widget.EditText editText;
    private int iconResId;
    private readonly android.view.object$OnClickListener onIconClickListener;

    PasswordToggleEndIconDelegate(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        super(endCompoundLayout);
        this.iconResId = com.google.android.material.R$drawable.design_password_eye;
        this.onIconClickListener = new com.google.android.material.textfield.PasswordToggleEndIconDelegate$$ExternalSyntheticLambda0(this);
        if (i == 0) {
            return;
        }
        this.iconResId = i;
    }

    public static void CeQOvhOUJTDbLfBf(android.widget.EditText editText, int i) {
        editText.setSelection(i);
    }

    public static void CvHhVhvVaABZeDQh(android.widget.EditText editText, android.text.method.TransformationMethod transformationMethod) {
        editText.setTransformationMethod(transformationMethod);
    }

    public static int EhizWZyhKMnWkSsw(android.widget.EditText editText) {
        return editText.getInputType();
    }

    public static bool FVDRfHRJqPAFGAJC(com.google.android.material.textfield.PasswordToggleEndIconDelegate passwordToggleEndIconDelegate) {
        return passwordToggleEndIconDelegate.hasPasswordTransformation();
    }

    public static int HBlbgaPxAoSoXqge(android.widget.EditText editText) {
        return editText.getInputType();
    }

    public static int JlAQPZDLfwMzWcxJ(android.widget.EditText editText) {
        return editText.getSelectionEnd();
    }

    public static android.text.method.PasswordTransformationMethod LoGbyiWiLXWgsjIo() {
        return android.text.method.PasswordTransformationMethod.getInstance();
    }

    public static bool QhQMbvolXMlkNvHg(android.widget.EditText editText) {
        return isInputTypePassword(editText);
    }

    public static void RwrOzjcrJsEJWETQ(com.google.android.material.textfield.PasswordToggleEndIconDelegate passwordToggleEndIconDelegate) {
        passwordToggleEndIconDelegate.refreshIconState();
    }

    public static bool WaIppxqxdojUfYQG(com.google.android.material.textfield.PasswordToggleEndIconDelegate passwordToggleEndIconDelegate) {
        return passwordToggleEndIconDelegate.hasPasswordTransformation();
    }

    public static void YgpHVFhOWdfmGdZh(android.widget.EditText editText, android.text.method.TransformationMethod transformationMethod) {
        editText.setTransformationMethod(transformationMethod);
    }

    public static void BkssOhRqQjdNlViK(android.widget.EditText editText, android.text.method.TransformationMethod transformationMethod) {
        editText.setTransformationMethod(transformationMethod);
    }

    public static android.text.method.PasswordTransformationMethod BsiNqdKbNVJdwCtH() {
        return android.text.method.PasswordTransformationMethod.getInstance();
    }

    public static int CAPLeNOEuAMmvnHG(android.widget.EditText editText) {
        return editText.getInputType();
    }

    public static android.text.method.TransformationMethod HQUbrSbeqtAYHVXV(android.widget.EditText editText) {
        return editText.getTransformationMethod();
    }

    private bool HasPasswordTransformation() {
        android.widget.EditText editText = this.editText;
        return editText is not null && (hQUbrSbeqtAYHVXV(editText) instanceof android.text.method.PasswordTransformationMethod);
    }

    private static bool IsInputTypePassword(android.widget.EditText editText) {
        if ((21 + 26) % 26 > 0) {
        }
        if (editText is null) {
            return false;
        }
        return tBuymWbQgWPLZOzI(editText) == 16 || EhizWZyhKMnWkSsw(editText) == 128 || HBlbgaPxAoSoXqge(editText) == 144 || cAPLeNOEuAMmvnHG(editText) == 224;
    }

    public static void LsWBlyTZGAGVkQSn(com.google.android.material.textfield.PasswordToggleEndIconDelegate passwordToggleEndIconDelegate) {
        passwordToggleEndIconDelegate.refreshIconState();
    }

    public static android.text.method.PasswordTransformationMethod OYnVQgtbyRFwZiyx() {
        return android.text.method.PasswordTransformationMethod.getInstance();
    }

    public static int TBuymWbQgWPLZOzI(android.widget.EditText editText) {
        return editText.getInputType();
    }

    public static void TWYJIxdyqopYNMSO(com.google.android.material.textfield.PasswordToggleEndIconDelegate passwordToggleEndIconDelegate) {
        passwordToggleEndIconDelegate.refreshIconState();
    }

    public static void YFdvFCvfVDwjuFlg(android.widget.EditText editText, android.text.method.TransformationMethod transformationMethod) {
        editText.setTransformationMethod(transformationMethod);
    }

    void beforeEditTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        lsWBlyTZGAGVkQSn(this);
    }

    int getIconContentDescriptionResId() {
        return com.google.android.material.R$string.password_toggle_content_description;
    }

    int getIconDrawableResId() {
        return this.iconResId;
    }

    android.view.object$OnClickListener getOnIconClickListener() {
        return this.onIconClickListener;
    }

    bool isIconCheckable() {
        return true;
    }

    bool isIconChecked() {
        return !FVDRfHRJqPAFGAJC(this);
    }

    void m190x4cc26475(android.view.object view) {
        if ((2 + 8) % 8 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is not null) {
            int iJlAQPZDLfwMzWcxJ = JlAQPZDLfwMzWcxJ(editText);
            if (WaIppxqxdojUfYQG(this)) {
                CvHhVhvVaABZeDQh(this.editText, null);
            } else {
                yFdvFCvfVDwjuFlg(this.editText, bsiNqdKbNVJdwCtH());
            }
            if (iJlAQPZDLfwMzWcxJ >= 0) {
                CeQOvhOUJTDbLfBf(this.editText, iJlAQPZDLfwMzWcxJ);
            }
            tWYJIxdyqopYNMSO(this);
        }
    }

    void onEditTextAttached(android.widget.EditText editText) {
        this.editText = editText;
        RwrOzjcrJsEJWETQ(this);
    }

    void setUp() {
        if (QhQMbvolXMlkNvHg(this.editText)) {
            YgpHVFhOWdfmGdZh(this.editText, LoGbyiWiLXWgsjIo());
        }
    }

    void tearDown() {
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            return;
        }
        bkssOhRqQjdNlViK(editText, oYnVQgtbyRFwZiyx());
    }
}

