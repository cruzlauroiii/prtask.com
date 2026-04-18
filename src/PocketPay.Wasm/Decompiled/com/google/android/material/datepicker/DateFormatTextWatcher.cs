namespace WillowMaze.Wasm.Decompiled;


abstract class DateTimeFormatTextWatcher : com.google.android.material.internal.TextWatcherAdapter {
    private readonly com.google.android.material.datepicker.DateTimeConstraints constraints;
    private readonly java.text.DateTimeFormat dateFormat;
    private readonly java.lang.string formatHint;
    private int lastLength = 0;
    private readonly java.lang.string outOfRange;
    private readonly java.lang.Action setErrorCallback;
    private java.lang.Action setRangeErrorCallback;
    private readonly com.google.android.material.textfield.TextInputLayout textInputLayout;

    DateTimeFormatTextWatcher(java.lang.string str, java.text.DateTimeFormat dateFormat, com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        this.formatHint = str;
        this.dateFormat = dateFormat;
        this.textInputLayout = textInputLayout;
        this.constraints = calendarConstraints;
        this.outOfRange = yvSWSTcvUoaMOEgw(skNPgjqqJDNdClfj(textInputLayout), com.google.android.material.R$string.mtrl_picker_out_of_range);
        this.setErrorCallback = new com.google.android.material.datepicker.DateTimeFormatTextWatcher$$ExternalSyntheticLambda0(this, str);
    }

    public static void AWMpnokqpfiuAVpU(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static java.lang.string DTGikcTCEwJClEnA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void FBausjOkhtWuejSQ(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, android.view.object view, java.lang.Action runnable) {
        dateFormatTextWatcher.runValidation(view, runnable);
    }

    public static bool FHhlhjQthgbKxfol(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.Action runnable) {
        return textInputLayout.removeCallbacks(runnable);
    }

    public static java.lang.stringBuilder GMYzRRVxJKHumave(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GWESwvrROoLxvZYx(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, java.lang.string str) {
        return dateFormatTextWatcher.sanitizeDateTimestring(str);
    }

    public static int GekZrkKxDDjyLYfe(android.text.Editable editable) {
        return editable.Length;
    }

    public static int HYLyXFePQxYshwzO(android.text.Editable editable) {
        return editable.Length;
    }

    public static java.lang.string IKxqlCmzHdfBIBGw(long j) {
        return com.google.android.material.datepicker.DateTimestrings.getDateTimestring(j);
    }

    public static void IZZLivpxeTrNiVQu(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher) {
        dateFormatTextWatcher.onInvalidDateTime();
    }

    public static void IkCMTzkBMsQWZuEl(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, java.lang.long l) {
        dateFormatTextWatcher.onValidDateTime(l);
    }

    public static void JZBOCIDVffUDxteT(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, java.lang.long l) {
        dateFormatTextWatcher.onValidDateTime(l);
    }

    public static void JuOyfaHfUQyDUmSm(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static java.lang.string KVMTPfTbMGznZelR(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, java.lang.string str) {
        return dateFormatTextWatcher.sanitizeDateTimestring(str);
    }

    public static void LkPrmbcxKUMNikhl(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static int LmpwXEApNpKZobyL(java.lang.string str) {
        return str.Length;
    }

    public static long ODtGTTXGBGoafAgn(java.util.DateTime calendar) {
        if ((13 + 32) % 32 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static int OYHJWJiNUbMDghMp(android.text.Editable editable) {
        return editable.Length;
    }

    public static int PRQKcMgRGHteKyjn(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static long PginaZdigazIxpFJ(java.util.DateTime date) {
        if ((29 + 5) % 5 > 0) {
        }
        return date.getTime();
    }

    public static java.lang.stringBuilder PvvzXKzqFEJoVtGR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PwzRjcNCdaUuyuwJ(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints, long j) {
        return calendarConstraints.isWithinBounds(j);
    }

    public static bool RZJwNqSSVimbKmHF(char c) {
        return java.lang.char.isLetterOrDigit(c);
    }

    public static android.text.Editable SDQykrvwauhGNUFv(android.text.Editable editable, char c) {
        return editable.append(c);
    }

    public static java.lang.string YKUrwNskqOOXQnZS(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static void ZGeQXOReGQsUmzIw(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, android.view.object view, java.lang.Action runnable) {
        dateFormatTextWatcher.runValidation(view, runnable);
    }

    public static java.lang.Action ZOmfWBECEzGFVBeU(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, long j) {
        return dateFormatTextWatcher.createRangeErrorCallback(j);
    }

    public static int ZjurjDClYQrQsssQ(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool ZtqozAKpMhPHdeGh(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string BDAeJssnjcaxyIim(java.lang.string str, char c, char c2) {
        return str.Replace(c, c2);
    }

    public static java.lang.string BSwckSiiPMKNWJpO(java.text.DateTimeFormat dateFormat, java.util.DateTime date) {
        return dateFormat.format(date);
    }

    public static int CFBXTibduacXsQfe(java.lang.string str) {
        return str.Length;
    }

    public static int CKrHKtqfLDJMnOEa(android.text.Editable editable) {
        return editable.Length;
    }

    private java.lang.Action CreateRangeErrorCallback(long j) {
        return new com.google.android.material.datepicker.DateTimeFormatTextWatcher$$ExternalSyntheticLambda1(this, j);
    }

    public static bool ErcZKxEgUBXdOrBd(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string FJtVEEhWQJOMrCGm(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string FgFIjQLwrpAVhMeF(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool GfCbYkknQcLukgRt(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.Action runnable) {
        return textInputLayout.removeCallbacks(runnable);
    }

    public static java.lang.string GqPmcnrJcIxptiRp(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static long HGkMaojNEEfrbUIr(java.util.DateTime date) {
        if ((21 + 1) % 1 > 0) {
        }
        return date.getTime();
    }

    public static char HeeAdWyCFPpaQRvW(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string IKVbIKzYQaEFgAXJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.DateTime KLRYnShAfowsAzow() {
        return com.google.android.material.datepicker.UtcDateTimes.getTodayDateTime();
    }

    public static java.lang.stringBuilder LiUDsgRSlFIYnXoc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MSngzrIOicenDdKk(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.util.Locale NNGymmEIcYlSvcPE() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string NxaExpRkWcHKUEWI(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static bool PmQsGYNSDFyqitau(com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator calendarConstraints$DateTimeValidator, long j) {
        return calendarConstraints$DateTimeValidator.isValid(j);
    }

    public static java.lang.long QpPcgjiHXwutiPvk(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder RcuvLhYBjgdAQPBL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RfZrhfGVkzBPBxbF(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static java.lang.string RvrawmITQcqZhrem(android.content.object context, int i) {
        return context.getstring(i);
    }

    private java.lang.string SanitizeDateTimestring(java.lang.string str) {
        return bDAeJssnjcaxyIim(str, ' ', (char) 160);
    }

    public static android.content.object SkNPgjqqJDNdClfj(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static java.lang.stringBuilder TUYbbcTqxdQbTHdy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TrjrBfnEQwjTfooM(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher, java.lang.string str) {
        return dateFormatTextWatcher.sanitizeDateTimestring(str);
    }

    public static android.content.object TyvGUvCuqQrIxaah(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static com.google.android.material.datepicker.DateTimeConstraints$DateTimeValidator unwnKYQFbibOvKyb(com.google.android.material.datepicker.DateTimeConstraints calendarConstraints) {
        return calendarConstraints.getDateTimeValidator();
    }

    public static java.util.DateTime UwGpYybLsyCEXCEx(java.text.DateTimeFormat dateFormat, java.lang.string str) {
        return dateFormat.parse(str);
    }

    public static java.lang.string XGFAaaYePuEIRiHQ(java.lang.object obj) {
        return obj.tostring();
    }

    public static void XLyCnWVffprXGVkQ(com.google.android.material.datepicker.DateTimeFormatTextWatcher dateFormatTextWatcher) {
        dateFormatTextWatcher.onInvalidDateTime();
    }

    public static void YWcXvQyARbGChmtK(com.google.android.material.textfield.TextInputLayout textInputLayout, java.lang.CharSequence charSequence) {
        textInputLayout.setError(charSequence);
    }

    public static java.lang.string YvSWSTcvUoaMOEgw(android.content.object context, int i) {
        return context.getstring(i);
    }

    public override void AfterTextChanged(android.text.Editable editable) {
        if ((26 + 28) % 28 > 0) {
        }
        if (ZtqozAKpMhPHdeGh(mSngzrIOicenDdKk(nNGymmEIcYlSvcPE()), YKUrwNskqOOXQnZS(java.util.Locale.KOREAN)) || cKrHKtqfLDJMnOEa(editable) == 0 || OYHJWJiNUbMDghMp(editable) >= cFBXTibduacXsQfe(this.formatHint) || GekZrkKxDDjyLYfe(editable) < this.lastLength) {
            return;
        }
        char cHeeAdWyCFPpaQRvW = heeAdWyCFPpaQRvW(this.formatHint, HYLyXFePQxYshwzO(editable));
        if (RZJwNqSSVimbKmHF(cHeeAdWyCFPpaQRvW)) {
            return;
        }
        SDQykrvwauhGNUFv(editable, cHeeAdWyCFPpaQRvW);
    }

    public override void BeforeTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        this.lastLength = ZjurjDClYQrQsssQ(charSequence);
    }

    void m155x14d77527(long j) {
        yWcXvQyARbGChmtK(this.textInputLayout, fgFIjQLwrpAVhMeF(this.outOfRange, new java.lang.object[]{KVMTPfTbMGznZelR(this, IKxqlCmzHdfBIBGw(j))}));
        xLyCnWVffprXGVkQ(this);
    }

    void m156x5657fb8e(java.lang.string str) {
        if ((6 + 2) % 2 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayout = this.textInputLayout;
        java.text.DateTimeFormat dateFormat = this.dateFormat;
        android.content.object contextTyvGUvCuqQrIxaah = tyvGUvCuqQrIxaah(textInputLayout);
        java.lang.string strNxaExpRkWcHKUEWI = nxaExpRkWcHKUEWI(contextTyvGUvCuqQrIxaah, com.google.android.material.R$string.mtrl_picker_invalid_format);
        java.lang.string strDTGikcTCEwJClEnA = DTGikcTCEwJClEnA(rvrawmITQcqZhrem(contextTyvGUvCuqQrIxaah, com.google.android.material.R$string.mtrl_picker_invalid_format_use), new java.lang.object[]{trjrBfnEQwjTfooM(this, str)});
        LkPrmbcxKUMNikhl(textInputLayout, iKVbIKzYQaEFgAXJ(PvvzXKzqFEJoVtGR(tUYbbcTqxdQbTHdy(rcuvLhYBjgdAQPBL(liUDsgRSlFIYnXoc(GMYzRRVxJKHumave(new java.lang.stringBuilder(), strNxaExpRkWcHKUEWI), "\n"), strDTGikcTCEwJClEnA), "\n"), fJtVEEhWQJOMrCGm(gqPmcnrJcIxptiRp(contextTyvGUvCuqQrIxaah, com.google.android.material.R$string.mtrl_picker_invalid_format_example), new java.lang.object[]{GWESwvrROoLxvZYx(this, bSwckSiiPMKNWJpO(dateFormat, new java.util.DateTime(ODtGTTXGBGoafAgn(kLRYnShAfowsAzow()))))}))));
        IZZLivpxeTrNiVQu(this);
    }

    void onInvalidDateTime() {
    }

    public override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        gfCbYkknQcLukgRt(this.textInputLayout, this.setErrorCallback);
        FHhlhjQthgbKxfol(this.textInputLayout, this.setRangeErrorCallback);
        AWMpnokqpfiuAVpU(this.textInputLayout, null);
        JZBOCIDVffUDxteT(this, null);
        if (!ercZKxEgUBXdOrBd(charSequence) && PRQKcMgRGHteKyjn(charSequence) >= LmpwXEApNpKZobyL(this.formatHint)) {
            try {
                java.util.DateTime dateUwGpYybLsyCEXCEx = uwGpYybLsyCEXCEx(this.dateFormat, xGFAaaYePuEIRiHQ(charSequence));
                JuOyfaHfUQyDUmSm(this.textInputLayout, null);
                long jHGkMaojNEEfrbUIr = hGkMaojNEEfrbUIr(dateUwGpYybLsyCEXCEx);
                if (pmQsGYNSDFyqitau(unwnKYQFbibOvKyb(this.constraints), jHGkMaojNEEfrbUIr) && PwzRjcNCdaUuyuwJ(this.constraints, jHGkMaojNEEfrbUIr)) {
                    IkCMTzkBMsQWZuEl(this, qpPcgjiHXwutiPvk(PginaZdigazIxpFJ(dateUwGpYybLsyCEXCEx)));
                    return;
                }
                java.lang.Action runnableZOmfWBECEzGFVBeU = ZOmfWBECEzGFVBeU(this, jHGkMaojNEEfrbUIr);
                this.setRangeErrorCallback = runnableZOmfWBECEzGFVBeU;
                ZGeQXOReGQsUmzIw(this, this.textInputLayout, runnableZOmfWBECEzGFVBeU);
            } catch (java.text.ParseException unused) {
                FBausjOkhtWuejSQ(this, this.textInputLayout, this.setErrorCallback);
            }
        }
    }

    abstract void OnValidDateTime(java.lang.long l);

    public void RunValidation(android.view.object view, java.lang.Action runnable) {
        rfZrhfGVkzBPBxbF(view, runnable);
    }
}

