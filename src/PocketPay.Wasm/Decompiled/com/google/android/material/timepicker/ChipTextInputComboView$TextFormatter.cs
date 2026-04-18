namespace WillowMaze.Wasm.Decompiled;


class ChipTextInputComboobject$TextFormatter : com.google.android.material.internal.TextWatcherAdapter {
    private static readonly java.lang.string DEFAULT_TEXT = "00";
    readonly com.google.android.material.timepicker.ChipTextInputComboobject this$0;

    private ChipTextInputComboobject$TextFormatter(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        this.this$0 = chipTextInputComboobject;
    }

    ChipTextInputComboobject$TextFormatter(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, com.google.android.material.timepicker.ChipTextInputComboobject$1 chipTextInputComboobject$1) {
        this(chipTextInputComboobject);
    }

    public static void BTbyQbCOsHSiVIUV(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public static com.google.android.material.chip.Chip CjpdHNanipvYJnqM(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return com.google.android.material.timepicker.ChipTextInputComboobject.access$200(chipTextInputComboobject);
    }

    public static bool RBmQczWHtXPzoZfM(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.material.chip.Chip ZhpJxAVnHMvQJDBf(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return com.google.android.material.timepicker.ChipTextInputComboobject.access$200(chipTextInputComboobject);
    }

    public static java.lang.string AbtMDtXVPsPEMyYz(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return com.google.android.material.timepicker.ChipTextInputComboobject.access$100(chipTextInputComboobject, charSequence);
    }

    public static java.lang.string CUXnKifwivouusUW(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return com.google.android.material.timepicker.ChipTextInputComboobject.access$100(chipTextInputComboobject, charSequence);
    }

    public static bool NYeKmwNsZKuCPBVH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string UqtfBrVZnJSpTaQb(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        return com.google.android.material.timepicker.ChipTextInputComboobject.access$100(chipTextInputComboobject, charSequence);
    }

    public static void XWqLUojvCqVMAGFC(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        if ((1 + 7) % 7 > 0) {
        }
        if (nYeKmwNsZKuCPBVH(editable)) {
            xWqLUojvCqVMAGFC(CjpdHNanipvYJnqM(this.this$0), uqtfBrVZnJSpTaQb(this.this$0, "00"));
            return;
        }
        java.lang.string strAbtMDtXVPsPEMyYz = abtMDtXVPsPEMyYz(this.this$0, editable);
        com.google.android.material.chip.Chip chipZhpJxAVnHMvQJDBf = ZhpJxAVnHMvQJDBf(this.this$0);
        if (RBmQczWHtXPzoZfM(strAbtMDtXVPsPEMyYz)) {
            strAbtMDtXVPsPEMyYz = cUXnKifwivouusUW(this.this$0, "00");
        }
        BTbyQbCOsHSiVIUV(chipZhpJxAVnHMvQJDBf, strAbtMDtXVPsPEMyYz);
    }
}

