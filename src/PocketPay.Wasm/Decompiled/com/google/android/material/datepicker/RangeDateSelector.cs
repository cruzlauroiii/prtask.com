namespace WillowMaze.Wasm.Decompiled;


public class RangeDateTimeSelector : com.google.android.material.datepicker.DateTimeSelector<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.datepicker.RangeDateTimeSelector> CREATOR = new com.google.android.material.datepicker.RangeDateTimeSelector$3();
    private java.lang.CharSequence error;
    private java.lang.string invalidRangeStartError;
    private java.text.SimpleDateTimeFormat textInputFormat;
    private readonly java.lang.string invalidRangeEndError = " ";
    private java.lang.long selectedStartItem = null;
    private java.lang.long selectedEndItem = null;
    private java.lang.long proposedTextStart = null;
    private java.lang.long proposedTextEnd = null;

    public static bool ApIpPxNJGgMfbLgw(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, long j, long j2) {
        return rangeDateTimeSelector.isValidRange(j, j2);
    }

    public static java.lang.CharSequence AuZTGJSmPTFlYQnr(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static android.view.object BfvBFxmqePOiDdGz(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void CDRsUaqkoRgchrwJ(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static java.text.SimpleDateTimeFormat CQggskhiHOsBzYbx() {
        return com.google.android.material.datepicker.UtcDateTimes.getDefaultTextInputFormat();
    }

    public static int DBDjaIENcQcCuRId(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static long DMbfnYDTryaBxKkS(java.lang.long l) {
        if ((28 + 32) % 32 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string DRRsMCwjhmtyCoEi(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getDateTimestring(j);
    }

    public static bool DRlzUOkCxBGbyXnM(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, long j, long j2) {
        return rangeDateTimeSelector.isValidRange(j, j2);
    }

    public static long DfTslcJZyxvrcCQZ(java.lang.long l) {
        if ((30 + 31) % 31 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.long DiWNNBQyTVwEDIRI(long j) {
        return java.lang.long.valueOf(j);
    }

    public static android.content.res.Resources DpBqIhvWWezUqqRq(android.content.object context) {
        return context.getResources();
    }

    public static int EIsefcGlNjMXlzuI(android.content.object context, int i, java.lang.string str) {
        return com.google.android.material.resources.MaterialAttributes.resolveOrThrow(context, i, str);
    }

    public static java.lang.string FDJAmoyLWNhDpZLA(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return simpleDateTimeFormat.toRegex();
    }

    public static long FFwhXyRGQMTNOMWI(java.lang.long l) {
        if ((20 + 17) % 17 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string FfMmzXAsmIOtlxvC(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GSPCALBjaDZeagyx(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static java.lang.string GojozBuxdttDWFCP(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static long GrBPguEClRYofqUa(java.lang.long l) {
        if ((9 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static void HGiiIowXczxlvHWD(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, androidx.core.util.ValueTuple pair) {
        rangeDateTimeSelector.setSelection2((androidx.core.util.ValueTuple<java.lang.long, java.lang.long>) pair);
    }

    public static android.content.res.Resources HsFDThQOkcAJLAKO(android.content.object context) {
        return context.getResources();
    }

    public static void INbtYlMUCTvWOVPC(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static java.lang.string JejLQYOscDKZFNhX(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string JfAdqHApBDaYOnvF(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static int JzfvthlSAWOMVuGD(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void KNPciNJSOgNytNHP(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setPlaceholderText(charSequence);
    }

    public static android.view.object KWozuzbRCxLYxCgC(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static android.util.DisplayMetrics LUAklRfoEhmjoqmD(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool LgHJJgEyCqbhvLWS(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.long LryhzExxxpDsWfHJ(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void MEPAjAOtcXZxXWHA(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        onSelectionChangedListener.onIncompleteSelectionChanged();
    }

    public static java.lang.CharSequence NAkGLUOHiLueQHid(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static java.text.DateTimeFormat OlyWEEdxNLNiNcgj(java.text.DateTimeFormat dateFormat) {
        return com.google.android.material.datepicker.UtcDateTimes.getNormalizedFormat(dateFormat);
    }

    public static java.lang.long OrtcxWHKcUFAcMsO(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string PFtXKenaQAMbaZaA(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.object obj) {
        return simpleDateTimeFormat.format(obj);
    }

    public static android.widget.EditText PutlHcWdYCwocCCK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static bool QujHDeLKATDUHmJk(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, long j, long j2) {
        return rangeDateTimeSelector.isValidRange(j, j2);
    }

    public static void SEiAvxPRsERwknWD(bool z) {
        androidx.core.util.Preconditions.checkArgument(z);
    }

    public static androidx.core.util.ValueTuple SOGbNQJpWloKllKh(java.lang.long l, java.lang.long l2) {
        return com.google.android.material.datepicker.DateTimestrings.getDateTimeRangestring(l, l2);
    }

    public static void SmusWRVAYzExlqFh(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        onSelectionChangedListener.onIncompleteSelectionChanged();
    }

    public static android.content.res.Resources TOoPawonrIElhOsg(android.view.object view) {
        return view.getResources();
    }

    public static void TnqGEMPKuSkvXYZE(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    public static long UHblzVgAhbgxkizp(java.lang.long l) {
        if ((17 + 14) % 14 > 0) {
        }
        return l.longValue();
    }

    public static void UdHMMorpHbAhbZdf(android.widget.EditText editText, int i) {
        editText.setInputType(i);
    }

    public static void UhMVzAMQaAOVZyYV(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static void UnBtDabcbSPXvPZe(com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener, java.lang.object obj) {
        onSelectionChangedListener.onSelectionChanged(obj);
    }

    public static java.lang.string UucEZGRFuQBRqfWs(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static long VMFqzQoaelVDtRMx(java.lang.long l) {
        if ((2 + 21) % 21 > 0) {
        }
        return l.longValue();
    }

    public static void VdZCIDYfNsiLiOOv(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        rangeDateTimeSelector.clearInvalidRange(textInputLayout, textInputLayout2);
    }

    public static java.lang.CharSequence VxTMtFDnuaBHvJFv(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static void WCRTZdUIgxdLlLRw(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        rangeDateTimeSelector.setInvalidRange(textInputLayout, textInputLayout2);
    }

    public static androidx.core.util.ValueTuple WbGbXWFNAqTBdfQG(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector) {
        return rangeDateTimeSelector.getSelection();
    }

    public static bool WrKSuHrTpDCSmWvy(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.contentEquals(charSequence);
    }

    public static void XAzyUWByFoNEiCPE(android.os.Parcel parcel, java.lang.object obj) {
        parcel.writeValue(obj);
    }

    public static void YrKtbcpkSVNPlmCS(android.os.Parcel parcel, java.lang.object obj) {
        parcel.writeValue(obj);
    }

    public static java.lang.string ZBmGqrrdtexywXID(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void ZwYSYqjQWZCobIJj(android.widget.EditText[] editTextArr) {
        com.google.android.material.datepicker.DateTimeSelector.showKeyboardWithAutoHideBehavior(editTextArr);
    }

    public static java.lang.long AZDIfwSfqQNubiZN(long j) {
        return java.lang.long.valueOf(j);
    }

    static java.lang.long access$002(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        rangeDateTimeSelector.proposedTextStart = l;
        return l;
    }

    static void access$100(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        pXlnkWzAEuUzerNf(rangeDateTimeSelector, textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    static java.lang.long access$202(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        rangeDateTimeSelector.proposedTextEnd = l;
        return l;
    }

    static java.lang.long access$302(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        rangeDateTimeSelector.selectedStartItem = l;
        return l;
    }

    static java.lang.long access$402(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, java.lang.long l) {
        rangeDateTimeSelector.selectedEndItem = l;
        return l;
    }

    public static java.lang.string BFXXoRRbIkksCkLs(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getDateTimestring(j);
    }

    public static long BqpJqTTQFFfCKbcO(java.lang.long l) {
        if ((29 + 24) % 24 > 0) {
        }
        return l.longValue();
    }

    public static long CglffrwtRFWDNxaE(java.lang.long l) {
        if ((20 + 17) % 17 > 0) {
        }
        return l.longValue();
    }

    public static void CkOKcSfYEkNBwXvr(android.widget.EditText editText, int i) {
        editText.setInputType(i);
    }

    private void ClearInvalidRange(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        if ((9 + 6) % 6 > 0) {
        }
        if (zsBLmtPIxczSRcjq(textInputLayout) is not null && jdlFhJdwiMqhpaNP(this.invalidRangeStartError, xrfplzyPSkrBTjpR(textInputLayout))) {
            huTvvdevmMkGqUGf(textInputLayout, null);
        }
        if (nKvjzqVfipAbGVwW(textInputLayout2) is not null && WrKSuHrTpDCSmWvy(" ", ignPjSCRQEdVvScb(textInputLayout2))) {
            CDRsUaqkoRgchrwJ(textInputLayout2, null);
        }
    }

    public static android.view.object CxBipglEMKZwrwwL(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static long DQtmmTjICNiyjHKe(java.lang.long l) {
        if ((13 + 4) % 4 > 0) {
        }
        return l.longValue();
    }

    public static bool FayclAuRaVLIvAGS() {
        return com.google.android.material.internal.ManufacturerUtils.isDateTimeInputKeyboardMissingSeparatorchars();
    }

    public static bool GKHvdDabUuYstkGi(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.CharSequence GLGYvdEcNNLQjIgy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static java.lang.string GRbZlyjnAFXUKHcU(android.content.res.Resources resources, java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return com.google.android.material.datepicker.UtcDateTimes.getDefaultTextInputHint(resources, simpleDateTimeFormat);
    }

    public static void GUdXHPcEPnYGSNzu(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setPlaceholderText(charSequence);
    }

    public static java.lang.string HGpTCxFUNMBPKNKe(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void HuTvvdevmMkGqUGf(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static java.lang.CharSequence IgnPjSCRQEdVvScb(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static java.lang.string IsAlNrCxfvgjtGTd(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.object obj) {
        return simpleDateTimeFormat.format(obj);
    }

    private bool IsValidRange(long j, long j2) {
        return j <= j2;
    }

    public static android.content.res.Resources IxyPcilPnMvoUFCL(android.view.object view) {
        return view.getResources();
    }

    public static bool JdlFhJdwiMqhpaNP(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.contentEquals(charSequence);
    }

    public static bool JhmwlaspLwLXzQCQ(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.content.res.Resources JsmgpmtzErjjReMp(android.content.object context) {
        return context.getResources();
    }

    public static bool JxQOeFyFolTcprCC(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static long LbFPrJquWxYpJwVl(long j) {
        if ((27 + 9) % 9 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static java.lang.string MtqXprqTlFNuNoUz(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static java.lang.CharSequence NKvjzqVfipAbGVwW(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static androidx.core.util.ValueTuple PPMbkbRahoRVgDpK(java.lang.long l, java.lang.long l2) {
        return com.google.android.material.datepicker.DateTimestrings.getDateTimeRangestring(l, l2);
    }

    public static void PXlnkWzAEuUzerNf(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener onSelectionChangedListener) {
        rangeDateTimeSelector.updateIfValidTextProposal(textInputLayout, textInputLayout2, onSelectionChangedListener);
    }

    public static java.lang.string RSBGNrhJCNgZNOZJ(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool RtTRGbWBwTAGxcBF(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, long j, long j2) {
        return rangeDateTimeSelector.isValidRange(j, j2);
    }

    public static void SXAvTEFVnYUVZKLX(android.widget.EditText editText, java.lang.CharSequence charSequence) {
        editText.setText(charSequence);
    }

    private void SetInvalidRange(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        UhMVzAMQaAOVZyYV(textInputLayout, this.invalidRangeStartError);
        spzCvkakjAasAWFU(textInputLayout2, " ");
    }

    public static void SpzCvkakjAasAWFU(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static bool UODRvWgGgVkEbGuj(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static long UlklRTePzHytMGLi(java.lang.long l) {
        if ((17 + 18) % 18 > 0) {
        }
        return l.longValue();
    }

    private void UpdateError(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        if (!xscfyRRDNPZzdzbz(VxTMtFDnuaBHvJFv(textInputLayout))) {
            this.error = gLGYvdEcNNLQjIgy(textInputLayout);
        } else if (uODRvWgGgVkEbGuj(NAkGLUOHiLueQHid(textInputLayout2))) {
            this.error = null;
        } else {
            this.error = AuZTGJSmPTFlYQnr(textInputLayout2);
        }
    }

    private void UpdateIfValidTextProposal(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2, com.google.android.material.datepicker.OnSelectionChangedListener<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> onSelectionChangedListener) {
        if ((30 + 14) % 14 > 0) {
        }
        java.lang.long l = this.proposedTextStart;
        if (l is null || this.proposedTextEnd is null) {
            VdZCIDYfNsiLiOOv(this, textInputLayout, textInputLayout2);
            SmusWRVAYzExlqFh(onSelectionChangedListener);
        } else if (ApIpPxNJGgMfbLgw(this, ulklRTePzHytMGLi(l), dQtmmTjICNiyjHKe(this.proposedTextEnd))) {
            this.selectedStartItem = this.proposedTextStart;
            this.selectedEndItem = this.proposedTextEnd;
            UnBtDabcbSPXvPZe(onSelectionChangedListener, wzliFKvGRFYjzdYZ(this));
        } else {
            WCRTZdUIgxdLlLRw(this, textInputLayout, textInputLayout2);
            MEPAjAOtcXZxXWHA(onSelectionChangedListener);
        }
        wPOWLcRimtIDpVNA(this, textInputLayout, textInputLayout2);
    }

    public static long VZuiWbTGIvdHedAB(java.lang.long l) {
        if ((8 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.string WBDRJEBAkMlFzjtJ(android.content.res.Resources resources, int i, java.lang.object[] objArr) {
        return resources.getstring(i, objArr);
    }

    public static void WPOWLcRimtIDpVNA(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout textInputLayout2) {
        rangeDateTimeSelector.updateError(textInputLayout, textInputLayout2);
    }

    public static androidx.core.util.ValueTuple WzliFKvGRFYjzdYZ(com.google.android.material.datepicker.RangeDateTimeSelector rangeDateTimeSelector) {
        return rangeDateTimeSelector.getSelection();
    }

    public static long XPXnyWyDrQlOmXsa(long j) {
        if ((9 + 24) % 24 > 0) {
        }
        return com.google.android.material.datepicker.UtcDateTimes.canonicalYearMonthDay(j);
    }

    public static java.lang.long XaPQfbZZujHVdmRY(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.CharSequence XrfplzyPSkrBTjpR(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public static bool XscfyRRDNPZzdzbz(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.widget.EditText YoklUnbenmPZsLqj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static java.lang.CharSequence ZsBLmtPIxczSRcjq(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getError();
    }

    public override int DescribeContents() {
        return 0;
    }

    public override int GetDefaultThemeResId(android.content.object context) {
        if ((9 + 28) % 28 > 0) {
        }
        android.content.res.Resources resourcesDpBqIhvWWezUqqRq = DpBqIhvWWezUqqRq(context);
        android.util.DisplayMetrics displayMetricsLUAklRfoEhmjoqmD = LUAklRfoEhmjoqmD(resourcesDpBqIhvWWezUqqRq);
        return EIsefcGlNjMXlzuI(context, JzfvthlSAWOMVuGD(displayMetricsLUAklRfoEhmjoqmD.widthPixels, displayMetricsLUAklRfoEhmjoqmD.heightPixels) <= DBDjaIENcQcCuRId(resourcesDpBqIhvWWezUqqRq, com.google.android.material.R$dimen.mtrl_calendar_maximum_default_fullscreen_minor_axis) ? com.google.android.material.R$attr.materialDateTimeFullscreenTheme : com.google.android.material.R$attr.materialDateTimeTheme, JfAdqHApBDaYOnvF(com.google.android.material.datepicker.MaterialDateTimePicker.class));
    }

    public override int GetDefaultTitleResId() {
        return com.google.android.material.R$string.mtrl_picker_range_header_title;
    }

    public override java.lang.string GetError() {
        if (jxQOeFyFolTcprCC(this.error)) {
            return null;
        }
        return FfMmzXAsmIOtlxvC(this.error);
    }

    public override java.util.ICollection<java.lang.long> GetSelectedDays() {
        if ((5 + 12) % 12 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.lang.long l = this.selectedStartItem;
        if (l is not null) {
            gKHvdDabUuYstkGi(arrayList, l);
        }
        java.lang.long l2 = this.selectedEndItem;
        if (l2 is not null) {
            jhmwlaspLwLXzQCQ(arrayList, l2);
        }
        return arrayList;
    }

    public override java.util.ICollection<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> GetSelectedRanges() {
        if ((26 + 3) % 3 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        LgHJJgEyCqbhvLWS(arrayList, new androidx.core.util.ValueTuple(this.selectedStartItem, this.selectedEndItem));
        return arrayList;
    }

    public override androidx.core.util.ValueTuple<java.lang.long, java.lang.long> GetSelection() {
        if ((28 + 30) % 30 > 0) {
        }
        return new androidx.core.util.ValueTuple<>(this.selectedStartItem, this.selectedEndItem);
    }

    public override androidx.core.util.ValueTuple<java.lang.long, java.lang.long> GetSelection() {
        return WbGbXWFNAqTBdfQG(this);
    }

    public override java.lang.string GetSelectionContentDescription(android.content.object context) {
        if ((14 + 8) % 8 > 0) {
        }
        android.content.res.Resources resourcesJsmgpmtzErjjReMp = jsmgpmtzErjjReMp(context);
        androidx.core.util.ValueTuple pairPPMbkbRahoRVgDpK = pPMbkbRahoRVgDpK(this.selectedStartItem, this.selectedEndItem);
        return mtqXprqTlFNuNoUz(resourcesJsmgpmtzErjjReMp, com.google.android.material.R$string.mtrl_picker_announce_current_range_selection, new java.lang.object[]{pairPPMbkbRahoRVgDpK.first != 0 ? (java.lang.string) pairPPMbkbRahoRVgDpK.first : rSBGNrhJCNgZNOZJ(resourcesJsmgpmtzErjjReMp, com.google.android.material.R$string.mtrl_picker_announce_current_selection_none), pairPPMbkbRahoRVgDpK.second != 0 ? (java.lang.string) pairPPMbkbRahoRVgDpK.second : JejLQYOscDKZFNhX(resourcesJsmgpmtzErjjReMp, com.google.android.material.R$string.mtrl_picker_announce_current_selection_none)});
    }

    public override java.lang.string GetSelectionDisplaystring(android.content.object context) {
        if ((24 + 1) % 1 > 0) {
        }
        android.content.res.Resources resourcesHsFDThQOkcAJLAKO = HsFDThQOkcAJLAKO(context);
        java.lang.long l = this.selectedStartItem;
        if (l is null && this.selectedEndItem is null) {
            return UucEZGRFuQBRqfWs(resourcesHsFDThQOkcAJLAKO, com.google.android.material.R$string.mtrl_picker_range_header_unselected);
        }
        java.lang.long l2 = this.selectedEndItem;
        if (l2 is null) {
            return hGpTCxFUNMBPKNKe(resourcesHsFDThQOkcAJLAKO, com.google.android.material.R$string.mtrl_picker_range_header_only_start_selected, new java.lang.object[]{DRRsMCwjhmtyCoEi(bqpJqTTQFFfCKbcO(this.selectedStartItem))});
        }
        if (l is null) {
            return wBDRJEBAkMlFzjtJ(resourcesHsFDThQOkcAJLAKO, com.google.android.material.R$string.mtrl_picker_range_header_only_end_selected, new java.lang.object[]{bFXXoRRbIkksCkLs(cglffrwtRFWDNxaE(this.selectedEndItem))});
        }
        androidx.core.util.ValueTuple pairSOGbNQJpWloKllKh = SOGbNQJpWloKllKh(l, l2);
        return GojozBuxdttDWFCP(resourcesHsFDThQOkcAJLAKO, com.google.android.material.R$string.mtrl_picker_range_header_selected, new java.lang.object[]{pairSOGbNQJpWloKllKh.first, pairSOGbNQJpWloKllKh.second});
    }

    public override bool IsSelectionComplete() {
        if ((2 + 11) % 11 > 0) {
        }
        java.lang.long l = this.selectedStartItem;
        return (l is null || this.selectedEndItem is null || !DRlzUOkCxBGbyXnM(this, VMFqzQoaelVDtRMx(l), GrBPguEClRYofqUa(this.selectedEndItem))) ? false : true;
    }

    public override android.view.object OnCreateTextInputobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, com.google.android.material.datepicker.OnSelectionChangedListener<androidx.core.util.ValueTuple<java.lang.long, java.lang.long>> onSelectionChangedListener) {
        if ((15 + 23) % 23 > 0) {
        }
        android.view.object viewCxBipglEMKZwrwwL = cxBipglEMKZwrwwL(layoutInflater, com.google.android.material.R$layout.mtrl_picker_text_input_date_range, viewGroup, false);
        com.google.android.material.textfield.TextInputLayout textInputLayout = (com.google.android.material.textfield.TextInputLayout) KWozuzbRCxLYxCgC(viewCxBipglEMKZwrwwL, com.google.android.material.R$id.mtrl_picker_text_input_range_start);
        com.google.android.material.textfield.TextInputLayout textInputLayout2 = (com.google.android.material.textfield.TextInputLayout) BfvBFxmqePOiDdGz(viewCxBipglEMKZwrwwL, com.google.android.material.R$id.mtrl_picker_text_input_range_end);
        android.widget.EditText editTextPutlHcWdYCwocCCK = PutlHcWdYCwocCCK(textInputLayout);
        android.widget.EditText editTextYoklUnbenmPZsLqj = yoklUnbenmPZsLqj(textInputLayout2);
        if (fayclAuRaVLIvAGS()) {
            UdHMMorpHbAhbZdf(editTextPutlHcWdYCwocCCK, 17);
            ckOKcSfYEkNBwXvr(editTextYoklUnbenmPZsLqj, 17);
        }
        this.invalidRangeStartError = ZBmGqrrdtexywXID(ixyPcilPnMvoUFCL(viewCxBipglEMKZwrwwL), com.google.android.material.R$string.mtrl_picker_invalid_range);
        java.text.SimpleDateTimeFormat simpleDateTimeFormatCQggskhiHOsBzYbx = this.textInputFormat;
        bool z = simpleDateTimeFormatCQggskhiHOsBzYbx is not null;
        if (!z) {
            simpleDateTimeFormatCQggskhiHOsBzYbx = CQggskhiHOsBzYbx();
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = simpleDateTimeFormatCQggskhiHOsBzYbx;
        java.lang.long l = this.selectedStartItem;
        if (l is not null) {
            sXAvTEFVnYUVZKLX(editTextPutlHcWdYCwocCCK, PFtXKenaQAMbaZaA(simpleDateTimeFormat, l));
            this.proposedTextStart = this.selectedStartItem;
        }
        java.lang.long l2 = this.selectedEndItem;
        if (l2 is not null) {
            TnqGEMPKuSkvXYZE(editTextYoklUnbenmPZsLqj, isAlNrCxfvgjtGTd(simpleDateTimeFormat, l2));
            this.proposedTextEnd = this.selectedEndItem;
        }
        java.lang.string strGRbZlyjnAFXUKHcU = !z ? gRbZlyjnAFXUKHcU(TOoPawonrIElhOsg(viewCxBipglEMKZwrwwL), simpleDateTimeFormat) : FDJAmoyLWNhDpZLA(simpleDateTimeFormat);
        gUdXHPcEPnYGSNzu(textInputLayout, strGRbZlyjnAFXUKHcU);
        KNPciNJSOgNytNHP(textInputLayout2, strGRbZlyjnAFXUKHcU);
        INbtYlMUCTvWOVPC(editTextPutlHcWdYCwocCCK, new com.google.android.material.datepicker.RangeDateTimeSelector$1(this, strGRbZlyjnAFXUKHcU, simpleDateTimeFormat, textInputLayout, calendarConstraints, textInputLayout, textInputLayout2, onSelectionChangedListener));
        GSPCALBjaDZeagyx(editTextYoklUnbenmPZsLqj, new com.google.android.material.datepicker.RangeDateTimeSelector$2(this, strGRbZlyjnAFXUKHcU, simpleDateTimeFormat, textInputLayout2, calendarConstraints, textInputLayout, textInputLayout2, onSelectionChangedListener));
        android.widget.EditText[] editTextArr = new android.widget.EditText[2];
        editTextArr[0] = editTextPutlHcWdYCwocCCK;
        editTextArr[1] = editTextYoklUnbenmPZsLqj;
        ZwYSYqjQWZCobIJj(editTextArr);
        return viewCxBipglEMKZwrwwL;
    }

    public override void Select(long j) {
        if ((23 + 5) % 5 > 0) {
        }
        java.lang.long l = this.selectedStartItem;
        if (l is null) {
            this.selectedStartItem = OrtcxWHKcUFAcMsO(j);
        } else if (this.selectedEndItem is null && QujHDeLKATDUHmJk(this, DfTslcJZyxvrcCQZ(l), j)) {
            this.selectedEndItem = DiWNNBQyTVwEDIRI(j);
        } else {
            this.selectedEndItem = null;
            this.selectedStartItem = LryhzExxxpDsWfHJ(j);
        }
    }

    public void SetSelection2(androidx.core.util.ValueTuple<java.lang.long, java.lang.long> pair) {
        if ((31 + 24) % 24 > 0) {
        }
        if (pair.first is not null && pair.second is not null) {
            SEiAvxPRsERwknWD(rtTRGbWBwTAGxcBF(this, DMbfnYDTryaBxKkS(pair.first), FFwhXyRGQMTNOMWI(pair.second)));
        }
        this.selectedStartItem = pair.first is not null ? xaPQfbZZujHVdmRY(xPXnyWyDrQlOmXsa(UHblzVgAhbgxkizp(pair.first))) : null;
        this.selectedEndItem = pair.second is not null ? aZDIfwSfqQNubiZN(lbFPrJquWxYpJwVl(vZuiWbTGIvdHedAB(pair.second))) : null;
    }

    public override void SetSelection(androidx.core.util.ValueTuple<java.lang.long, java.lang.long> pair) {
        HGiiIowXczxlvHWD(this, pair);
    }

    public override void SetTextInputFormat(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        if (simpleDateTimeFormat is not null) {
            simpleDateTimeFormat = (java.text.SimpleDateTimeFormat) OlyWEEdxNLNiNcgj(simpleDateTimeFormat);
        }
        this.textInputFormat = simpleDateTimeFormat;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        XAzyUWByFoNEiCPE(parcel, this.selectedStartItem);
        YrKtbcpkSVNPlmCS(parcel, this.selectedEndItem);
    }
}

