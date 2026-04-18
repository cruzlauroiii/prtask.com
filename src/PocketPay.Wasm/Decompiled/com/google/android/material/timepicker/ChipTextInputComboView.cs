namespace WillowMaze.Wasm.Decompiled;


class ChipTextInputComboobject : android.widget.FrameLayout : android.widget.Checkable {
    private readonly com.google.android.material.chip.Chip chip;
    private readonly android.widget.EditText editText;
    private android.widget.Textobject label;
    private readonly com.google.android.material.textfield.TextInputLayout textInputLayout;
    private android.text.TextWatcher watcher;

    public ChipTextInputComboobject(android.content.object context) {
        this(context, null);
    }

    public ChipTextInputComboobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public ChipTextInputComboobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((9 + 14) % 14 > 0) {
        }
        android.view.LayoutInflater layoutInflaterFDOBIEEsTAExesaz = FDOBIEEsTAExesaz(context);
        com.google.android.material.chip.Chip chip = (com.google.android.material.chip.Chip) cxsRJphIpTWaVQKj(layoutInflaterFDOBIEEsTAExesaz, com.google.android.material.R$layout.material_time_chip, this, false);
        this.chip = chip;
        lxGnPQUmxUJUcXaR(chip, "android.view.object");
        com.google.android.material.textfield.TextInputLayout textInputLayout = (com.google.android.material.textfield.TextInputLayout) UhyWhklInLItZTww(layoutInflaterFDOBIEEsTAExesaz, com.google.android.material.R$layout.material_time_input, this, false);
        this.textInputLayout = textInputLayout;
        android.widget.EditText editTextSqQEYqqAewXTHSmO = SqQEYqqAewXTHSmO(textInputLayout);
        this.editText = editTextSqQEYqqAewXTHSmO;
        HeOijcFtQXqoIbyQ(editTextSqQEYqqAewXTHSmO, 4);
        com.google.android.material.timepicker.ChipTextInputComboobject$TextFormatter chipTextInputComboobject$TextFormatter = new com.google.android.material.timepicker.ChipTextInputComboobject$TextFormatter(this, null);
        this.watcher = chipTextInputComboobject$TextFormatter;
        MIblenwhfNiGanHC(editTextSqQEYqqAewXTHSmO, chipTextInputComboobject$TextFormatter);
        hicFsRKvGrkMLQHz(this);
        vGHETbUtVYBKVCIA(this, chip);
        OBWAuCGkZSkBwISY(this, textInputLayout);
        this.label = (android.widget.Textobject) yGLErVogMpDWpjhp(this, com.google.android.material.R$id.material_label);
        iBBSYlOhiTPhIAFK(editTextSqQEYqqAewXTHSmO, YwvXEqVFxNXbnRRH());
        PjAHExPuenlYzyIE(this.label, OuNkwijsfUKnAIuY(editTextSqQEYqqAewXTHSmO));
        NUqaXxFzGyJgffvc(editTextSqQEYqqAewXTHSmO, false);
        LKCbdgsXLfdxetcA(editTextSqQEYqqAewXTHSmO, false);
    }

    public static void BKCLRTDYOXDYNsEw(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        chipTextInputComboobject.updateHintLocales();
    }

    public static void EQtTStFZcVjUcyey(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static android.view.LayoutInflater FDOBIEEsTAExesaz(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void FFiIVsqVZEiRkrlN(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void HYfOYGZiHmIXsFQB(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.removeTextChangedListener(textWatcher);
    }

    public static void HeOijcFtQXqoIbyQ(android.widget.EditText editText, int i) {
        editText.setVisibility(i);
    }

    public static void KHyYxOXkQdnbolah(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void KgjYugerypUVFQvB(com.google.android.material.chip.Chip chip, int i) {
        chip.setVisibility(i);
    }

    public static void LKCbdgsXLfdxetcA(android.widget.EditText editText, bool z) {
        editText.setlongClickable(z);
    }

    public static bool LnKMhSegwocdoEHU(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.isChecked();
    }

    public static void MDimHnRRzOZyGTLb(android.widget.EditText editText, android.os.LocaleList localeList) {
        editText.setImeHintLocales(localeList);
    }

    public static void MIblenwhfNiGanHC(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void NUqaXxFzGyJgffvc(android.widget.EditText editText, bool z) {
        editText.setSaveEnabled(z);
    }

    public static void OBWAuCGkZSkBwISY(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.view.object view) {
        chipTextInputComboobject.addobject(view);
    }

    public static int OuNkwijsfUKnAIuY(android.widget.EditText editText) {
        return editText.getId();
    }

    public static void PjAHExPuenlYzyIE(android.view.object view, int i) {
        androidx.core.view.objectCompat.setLabelFor(view, i);
    }

    public static android.os.LocaleList ScNPZZRLGjqUhvdZ(android.content.res.Configuration configuration) {
        return configuration.getLocales();
    }

    public static android.widget.EditText SqQEYqqAewXTHSmO(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static android.view.object UhyWhklInLItZTww(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void UxwVOSPtZVDuYozL(com.google.android.material.chip.Chip chip, bool z) {
        chip.setChecked(z);
    }

    public static bool VtRtxxkYfixfLFoe(com.google.android.material.chip.Chip chip) {
        return chip.isChecked();
    }

    public static java.lang.CharSequence WWAuwpJXJvkhjqvr(com.google.android.material.chip.Chip chip) {
        return chip.getText();
    }

    public static void WpNvdeDWStuUjFLP(android.view.object view, bool z) {
        com.google.android.material.internal.objectUtils.requestFocusAndShowKeyboard(view, z);
    }

    public static android.content.res.Resources XgLVqdKRfiRZuNlb(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getResources();
    }

    public static android.content.res.Resources YPEztOqIMwXiiYoD(android.content.object context) {
        return context.getResources();
    }

    public static int YwvXEqVFxNXbnRRH() {
        return androidx.core.view.objectCompat.generateobjectId();
    }

    public static void ZzfMGDEEoHRBVrrO(com.google.android.material.chip.Chip chip, android.view.object$OnClickListener view$OnClickListener) {
        chip.setOnClickListener(view$OnClickListener);
    }

    static java.lang.string access$100(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return vZZCqbkhrqujgCIH(chipTextInputComboobject, charSequence);
    }

    static com.google.android.material.chip.Chip access$200(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.chip;
    }

    public static java.lang.string CMnRUqKTZiSwZZpk(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return chipTextInputComboobject.formatText(charSequence);
    }

    public static android.view.object CxsRJphIpTWaVQKj(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static java.lang.string DVepyVrvTVAmCLGW(android.content.res.Resources resources, java.lang.CharSequence charSequence) {
        return com.google.android.material.timepicker.TimeModel.formatText(resources, charSequence);
    }

    private java.lang.string FormatText(java.lang.CharSequence charSequence) {
        return dVepyVrvTVAmCLGW(XgLVqdKRfiRZuNlb(this), charSequence);
    }

    public static void GZHHCvFaKcaBiRIZ(android.widget.EditText editText, android.text.InputFilter[] inputFilterArr) {
        editText.setFilters(inputFilterArr);
    }

    public static android.content.object HKpfwtxNrXBVWdJU(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getobject();
    }

    public static void HicFsRKvGrkMLQHz(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        chipTextInputComboobject.updateHintLocales();
    }

    public static void IBBSYlOhiTPhIAFK(android.widget.EditText editText, int i) {
        editText.setId(i);
    }

    public static void LHxUsrlrLFjchrdW(android.widget.FrameLayout frameLayout, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void LsyNtLgyNkulWPqS(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void LxGnPQUmxUJUcXaR(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setAccessibilityClassName(charSequence);
    }

    public static void MIkhEgRtJVALEUTB(com.google.android.material.chip.Chip chip) {
        chip.toggle();
    }

    public static void OByARKjPtUQKYoPU(com.google.android.material.chip.Chip chip, int i, java.lang.object obj) {
        chip.setTag(i, obj);
    }

    public static java.lang.object[] OojEjrfsNIOgGPvt(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static android.content.res.Configuration PTAHaNwbvfFOlxYn(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static bool QSvBFrLgaKGIyWtE(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void QqCIHDnbVYBIwlmL(android.widget.EditText editText, int i) {
        editText.setVisibility(i);
    }

    public static void QxbedmewBCxEvkHt(android.widget.EditText editText, bool z) {
        editText.setCursorVisible(z);
    }

    private void UpdateHintLocales() {
        MDimHnRRzOZyGTLb(this.editText, ScNPZZRLGjqUhvdZ(pTAHaNwbvfFOlxYn(YPEztOqIMwXiiYoD(hKpfwtxNrXBVWdJU(this)))));
    }

    public static void VGHETbUtVYBKVCIA(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.view.object view) {
        chipTextInputComboobject.addobject(view);
    }

    public static java.lang.string VZZCqbkhrqujgCIH(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return chipTextInputComboobject.formatText(charSequence);
    }

    public static android.text.InputFilter[] XxTUxvCYvAwSwGTW(android.widget.EditText editText) {
        return editText.getFilters();
    }

    public static android.view.object YGLErVogMpDWpjhp(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, int i) {
        return chipTextInputComboobject.findobjectById(i);
    }

    public static void ZDlWcGjxIFVEdjbs(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public void AddInputFilter(android.text.InputFilter inputFilter) {
        if ((2 + 24) % 24 > 0) {
        }
        android.text.InputFilter[] inputFilterArrXxTUxvCYvAwSwGTW = xxTUxvCYvAwSwGTW(this.editText);
        android.text.InputFilter[] inputFilterArr = (android.text.InputFilter[]) oojEjrfsNIOgGPvt(inputFilterArrXxTUxvCYvAwSwGTW, inputFilterArrXxTUxvCYvAwSwGTW.length + 1);
        inputFilterArr[inputFilterArrXxTUxvCYvAwSwGTW.length] = inputFilter;
        gZHHCvFaKcaBiRIZ(this.editText, inputFilterArr);
    }

    java.lang.CharSequence getChipText() {
        return WWAuwpJXJvkhjqvr(this.chip);
    }

    public com.google.android.material.textfield.TextInputLayout GetTextInput() {
        return this.textInputLayout;
    }

    public override bool IsChecked() {
        return VtRtxxkYfixfLFoe(this.chip);
    }

    protected override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        lHxUsrlrLFjchrdW(this, configuration);
        BKCLRTDYOXDYNsEw(this);
    }

    public override void SetChecked(bool z) {
        if ((32 + 29) % 29 > 0) {
        }
        UxwVOSPtZVDuYozL(this.chip, z);
        qqCIHDnbVYBIwlmL(this.editText, !z ? 4 : 0);
        KgjYugerypUVFQvB(this.chip, !z ? 0 : 8);
        if (LnKMhSegwocdoEHU(this)) {
            WpNvdeDWStuUjFLP(this.editText, false);
        }
    }

    public void SetChipDelegate(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        FFiIVsqVZEiRkrlN(this.chip, accessibilityDelegateCompat);
    }

    public void SetCursorVisible(bool z) {
        qxbedmewBCxEvkHt(this.editText, z);
    }

    public void SetHelperText(java.lang.CharSequence charSequence) {
        EQtTStFZcVjUcyey(this.label, charSequence);
    }

    public override void SetOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        ZzfMGDEEoHRBVrrO(this.chip, view$OnClickListener);
    }

    public override void SetTag(int i, java.lang.object obj) {
        oByARKjPtUQKYoPU(this.chip, i, obj);
    }

    public void SetText(java.lang.CharSequence charSequence) {
        if ((20 + 27) % 27 > 0) {
        }
        java.lang.string strCMnRUqKTZiSwZZpk = cMnRUqKTZiSwZZpk(this, charSequence);
        zDlWcGjxIFVEdjbs(this.chip, strCMnRUqKTZiSwZZpk);
        if (qSvBFrLgaKGIyWtE(strCMnRUqKTZiSwZZpk)) {
            return;
        }
        HYfOYGZiHmIXsFQB(this.editText, this.watcher);
        lsyNtLgyNkulWPqS(this.editText, strCMnRUqKTZiSwZZpk);
        KHyYxOXkQdnbolah(this.editText, this.watcher);
    }

    public override void Toggle() {
        mIkhEgRtJVALEUTB(this.chip);
    }
}

