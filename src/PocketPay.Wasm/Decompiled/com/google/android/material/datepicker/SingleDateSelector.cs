namespace WillowMaze.Wasm.Decompiled;


public class SingleDateTimeSelector : com.google.android.material.datepicker.DateTimeSelector<java.lang.long> {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.SingleDateTimeSelector> CREATOR = new com.google.android.material.datepicker.SingleDateTimeSelector$2();
    private java.lang.CharSequence error;
    private java.lang.long selectedItem;
    private java.text.SimpleDateTimeFormat textInputFormat;

    public static java.lang.string EKMLmLJvrzKXTNPu(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string FEfEKESnuxYNQqti(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static long GHsnmuCeFkACqWeb(java.lang.long l) {
        if ((12 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static void GeCdndxRtQdTOVKA(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector) {
        singleDateTimeSelector.clearSelection();
    }

    public static java.lang.string GmVYnsCpPtCmGLYo(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static java.lang.string GoTAKOkEEukmBPYL(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.long LAoutRoWKbjGyyMq(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string MYMEDHdXoOUqeWrF(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.long NEsiOYBzXdYhWOwQ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string RuMNfActRNyhfPPt(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return simpleDateTimeFormat.toRegex();
    }

    public static void RwCxBIYhpXHdnZPe(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void SjayPPUbEPDtlSLr(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static void SvmtGLlEzznfXdmN(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.long l) {
        singleDateTimeSelector.setSelection2(l);
    }

    public static long UyIKjckJfBUGGCFY(long j) {
        if ((24 + 32) % 32 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static java.text.DateTimeFormat VGCaAxodhTPUZtAv(java.text.DateTimeFormat dateFormat) {
        return com.google.android.material.datepicker.UtcDateTimes.getNormalizedFormat(dateFormat);
    }

    public static void VRCzaPQDEpZTgGUi(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setPlaceholderText(charSequence);
    }

    public static java.lang.string WgZpbOYfygjTfHMj(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getYearMonthDay(j);
    }

    public static bool ABlRSmUgxacMOlZY() {
        return com.google.android.material.internal.ManufacturerUtils.isDateTimeInputKeyboardMissingSeparatorchars();
    }

    public static void ADumtKXdmXIZfvBy(android.widget.EditText[] editTextArr) {
        com.google.android.material.datepicker.DateTimeSelector.showKeyboardWithAutoHideBehavior(editTextArr);
    }

    static void access$000(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector) {
        GeCdndxRtQdTOVKA(singleDateTimeSelector);
    }

    static java.lang.CharSequence access$102(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.CharSequence charSequence) {
        singleDateTimeSelector.error = charSequence;
        return charSequence;
    }

    static java.lang.long access$202(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector, java.lang.long l) {
        singleDateTimeSelector.selectedItem = l;
        return l;
    }

    private void ClearSelection() {
        this.selectedItem = null;
    }

    public static android.content.res.Resources DoGGyOXuHRRhkkUY(android.content.object context) {
        return context.getResources();
    }

    public static long EWXoeChUExkfFdTF(java.lang.long l) {
        if ((3 + 10) % 10 > 0) {
        }
        return l.longValue();
    }

    public static java.text.SimpleDateTimeFormat EqtedEyUOJFMUbIP() {
        return com.google.android.material.datepicker.UtcDateTimes.getDefaultTextInputFormat();
    }

    public static bool FZNHVRmkGWfWYfxQ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int KuvwauDbkwDyeGNh(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.resources.MaterialAttributes.resolveOrThrow(context, i, str);
    }

    public static java.lang.string LzRTuQWkYSOcTsrg(android.content.res.Resources resources, java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return com.google.android.material.datepicker.UtcDateTimes.getDefaultTextInputHint(resources, simpleDateTimeFormat);
    }

    public static void NKJbUeBTcNXKNrXf(android.os.Parcel parcel, java.lang.object obj) {
        parcel.writeValue(obj);
    }

    public static java.lang.string NWONKnhMChSqAbTz(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static android.view.object PCrzfcFCbTquIXWc(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static java.lang.string PPVymALIAYhrdjOs(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getYearMonthDay(j);
    }

    public static android.content.res.Resources TIxSXWSthjfmAzVO(android.view.object view) {
        return view.getResources();
    }

    public static long ToJnEKmQbPanUVGC(java.lang.long l) {
        if ((27 + 21) % 21 > 0) {
        }
        return l.longValue();
    }

    public static void UDVzqonWgduzJnQF(android.widget.EditText editText, int i) {
        editText.setInputType(i);
    }

    public static android.view.object WPItRBxKYoTjqRVR(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.widget.EditText WPNKEuSQZYPnpHEM(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static bool XbExdewhsQvUbmCo(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.string XbqXhXUUIcernwLN(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.object obj) {
        return simpleDateTimeFormat.format(obj);
    }

    public static android.content.res.Resources YAibkMkTnYsnqdEb(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.long ZaDAWELZXBtgavut(com.google.android.material.datepicker.SingleDateTimeSelector singleDateTimeSelector) {
        return singleDateTimeSelector.getSelection();
    }

    public override int DescribeContents() {
        return 0;
    }

    public override int GetDefaultThemeResId(android.content.object context) {
        return kuvwauDbkwDyeGNh(context, com.google.android.material.R$attr.materialDateTimeTheme, MYMEDHdXoOUqeWrF(com.google.android.material.datepicker.MaterialDateTimePicker.class));
    }

    public override int GetDefaultTitleResId() {
        return com.google.android.material.R$string.mtrl_picker_date_header_title;
    }

    public override java.lang.string GetError() {
        if (fZNHVRmkGWfWYfxQ(this.error)) {
            return null;
        }
        return GoTAKOkEEukmBPYL(this.error);
    }

    public override java.util.ICollection<java.lang.long> GetSelectedDays() {
        java.util.List arrayList = new java.util.List();
        java.lang.long l = this.selectedItem;
        if (l is not null) {
            xbExdewhsQvUbmCo(arrayList, l);
        }
        return arrayList;
    }

    public override java.util.ICollection<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> GetSelectedRanges() {
        return new java.util.List();
    }

    public override java.lang.long GetSelection() {
        return this.selectedItem;
    }

    public override java.lang.long GetSelection() {
        return zaDAWELZXBtgavut(this);
    }

    public override java.lang.string GetSelectionContentDescription(android.content.object context) {
        if ((4 + 9) % 9 > 0) {
        }
        android.content.res.Resources resourcesDoGGyOXuHRRhkkUY = doGGyOXuHRRhkkUY(context);
        java.lang.long l = this.selectedItem;
        return FEfEKESnuxYNQqti(resourcesDoGGyOXuHRRhkkUY, com.google.android.material.R$string.mtrl_picker_announce_current_selection, new java.lang.object[]{l is not null ? WgZpbOYfygjTfHMj(GHsnmuCeFkACqWeb(l)) : nWONKnhMChSqAbTz(resourcesDoGGyOXuHRRhkkUY, com.google.android.material.R$string.mtrl_picker_announce_current_selection_none)});
    }

    public override java.lang.string GetSelectionDisplaystring(android.content.object context) {
        if ((26 + 5) % 5 > 0) {
        }
        android.content.res.Resources resourcesYAibkMkTnYsnqdEb = yAibkMkTnYsnqdEb(context);
        java.lang.long l = this.selectedItem;
        if (l is null) {
            return EKMLmLJvrzKXTNPu(resourcesYAibkMkTnYsnqdEb, com.google.android.material.R$string.mtrl_picker_date_header_unselected);
        }
        return GmVYnsCpPtCmGLYo(resourcesYAibkMkTnYsnqdEb, com.google.android.material.R$string.mtrl_picker_date_header_selected, new java.lang.object[]{pPVymALIAYhrdjOs(eWXoeChUExkfFdTF(l))});
    }

    public override bool IsSelectionComplete() {
        return this.selectedItem is not null;
    }

    public override android.view.object OnCreateTextInputobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.OnSelectionChangedListener<java.lang.long> onSelectionChangedListener) {
        if ((7 + 11) % 11 > 0) {
        }
        android.view.object viewPCrzfcFCbTquIXWc = pCrzfcFCbTquIXWc(layoutInflater, com.google.android.material.R$layout.mtrl_picker_text_input_date, viewGroup, false);
        com.google.android.material.textfield.TextInputLayout textInputLayout = (com.google.android.material.textfield.TextInputLayout) wPItRBxKYoTjqRVR(viewPCrzfcFCbTquIXWc, com.google.android.material.R$id.mtrl_picker_text_input_date);
        android.widget.EditText editTextWPNKEuSQZYPnpHEM = wPNKEuSQZYPnpHEM(textInputLayout);
        if (aBlRSmUgxacMOlZY()) {
            uDVzqonWgduzJnQF(editTextWPNKEuSQZYPnpHEM, 17);
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormatEqtedEyUOJFMUbIP = this.textInputFormat;
        bool z = simpleDateTimeFormatEqtedEyUOJFMUbIP is not null;
        if (!z) {
            simpleDateTimeFormatEqtedEyUOJFMUbIP = eqtedEyUOJFMUbIP();
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = simpleDateTimeFormatEqtedEyUOJFMUbIP;
        java.lang.string strLzRTuQWkYSOcTsrg = !z ? lzRTuQWkYSOcTsrg(tIxSXWSthjfmAzVO(viewPCrzfcFCbTquIXWc), simpleDateTimeFormat) : RuMNfActRNyhfPPt(simpleDateTimeFormat);
        VRCzaPQDEpZTgGUi(textInputLayout, strLzRTuQWkYSOcTsrg);
        java.lang.long l = this.selectedItem;
        if (l is not null) {
            SjayPPUbEPDtlSLr(editTextWPNKEuSQZYPnpHEM, xbqXhXUUIcernwLN(simpleDateTimeFormat, l));
        }
        RwCxBIYhpXHdnZPe(editTextWPNKEuSQZYPnpHEM, new com.google.android.material.datepicker.SingleDateTimeSelector$1(this, strLzRTuQWkYSOcTsrg, simpleDateTimeFormat, textInputLayout, calendarConstraints, onSelectionChangedListener, textInputLayout));
        android.widget.EditText[] editTextArr = new android.widget.EditText[1];
        editTextArr[0] = editTextWPNKEuSQZYPnpHEM;
        aDumtKXdmXIZfvBy(editTextArr);
        return viewPCrzfcFCbTquIXWc;
    }

    public override void Select(long j) {
        this.selectedItem = LAoutRoWKbjGyyMq(j);
    }

    public void SetSelection2(java.lang.long l) {
        if ((22 + 7) % 7 > 0) {
        }
        this.selectedItem = l is not null ? NEsiOYBzXdYhWOwQ(UyIKjckJfBUGGCFY(toJnEKmQbPanUVGC(l))) : null;
    }

    public override void SetSelection(java.lang.long l) {
        SvmtGLlEzznfXdmN(this, l);
    }

    public override void SetTextInputFormat(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        if (simpleDateTimeFormat is not null) {
            simpleDateTimeFormat = (java.text.SimpleDateTimeFormat) VGCaAxodhTPUZtAv(simpleDateTimeFormat);
        }
        this.textInputFormat = simpleDateTimeFormat;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        nKJbUeBTcNXKNrXf(parcel, this.selectedItem);
    }
}

