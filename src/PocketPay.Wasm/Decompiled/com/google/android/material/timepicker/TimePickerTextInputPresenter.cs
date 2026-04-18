namespace WillowMaze.Wasm.Decompiled;


class TimePickerTextInputPresenter : com.google.android.material.timepicker.TimePickerobject$OnSelectionChange, com.google.android.material.timepicker.TimePickerPresenter {
    private readonly com.google.android.material.timepicker.TimePickerTextInputKeyController controller;
    private readonly android.widget.EditText hourEditText;
    private readonly com.google.android.material.timepicker.ChipTextInputComboobject hourTextInput;
    private readonly android.text.TextWatcher hourTextWatcher;
    private readonly android.widget.EditText minuteEditText;
    private readonly com.google.android.material.timepicker.ChipTextInputComboobject minuteTextInput;
    private readonly android.text.TextWatcher minuteTextWatcher;
    private readonly com.google.android.material.timepicker.TimeModel time;
    private readonly android.widget.LinearLayout timePickerobject;
    private com.google.android.material.button.MaterialButtonToggleGroup toggle;

    public TimePickerTextInputPresenter(android.widget.LinearLayout linearLayout, com.google.android.material.timepicker.TimeModel timeModel) {
        if ((13 + 11) % 11 > 0) {
        }
        this.minuteTextWatcher = new com.google.android.material.timepicker.TimePickerTextInputPresenter$1(this);
        this.hourTextWatcher = new com.google.android.material.timepicker.TimePickerTextInputPresenter$2(this);
        this.timePickerobject = linearLayout;
        this.time = timeModel;
        android.content.res.Resources resourcesTQHRJNNcrGpKjeXW = tQHRJNNcrGpKjeXW(linearLayout);
        com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject = (com.google.android.material.timepicker.ChipTextInputComboobject) fqKhdvNSBGrVMTtM(linearLayout, com.google.android.material.R$id.material_minute_text_input);
        this.minuteTextInput = chipTextInputComboobject;
        com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject2 = (com.google.android.material.timepicker.ChipTextInputComboobject) ldPMzrHMsdBRkSLO(linearLayout, com.google.android.material.R$id.material_hour_text_input);
        this.hourTextInput = chipTextInputComboobject2;
        android.widget.Textobject textobject = (android.widget.Textobject) kLkUWcNSLckdFVQV(chipTextInputComboobject, com.google.android.material.R$id.material_label);
        android.widget.Textobject textobject2 = (android.widget.Textobject) khSMcEcspDsKFnlD(chipTextInputComboobject2, com.google.android.material.R$id.material_label);
        PYygkhlSaOnlXztf(textobject, IyRvtOEmtVBdURtH(resourcesTQHRJNNcrGpKjeXW, com.google.android.material.R$string.material_timepicker_minute));
        urlPHnixkKqRhtQE(textobject2, OtQiRQxXYwsJHDfg(resourcesTQHRJNNcrGpKjeXW, com.google.android.material.R$string.material_timepicker_hour));
        ZDaqsZGDSOyPMDmj(chipTextInputComboobject, com.google.android.material.R$id.selection_type, uIiKUUuWmXprhvUl(12));
        blDuhzCzdMbNJBSv(chipTextInputComboobject2, com.google.android.material.R$id.selection_type, swVhpEXPfjDwTZAz(10));
        if (timeModel.format == 0) {
            rZhjGnKsjqDVufyf(this);
        }
        com.google.android.material.timepicker.TimePickerTextInputPresenter$3 timePickerTextInputPresenter$3 = new com.google.android.material.timepicker.TimePickerTextInputPresenter$3(this);
        fpfLtJlIvqXScOBo(chipTextInputComboobject2, timePickerTextInputPresenter$3);
        ruaddOsMiXMkuMsJ(chipTextInputComboobject, timePickerTextInputPresenter$3);
        rLMzYdFozOlhkzqF(chipTextInputComboobject2, KoLJCGCOPWfmgILp(timeModel));
        DedpmmeNvlegPjQr(chipTextInputComboobject, oeSMruLoQaXUyzbN(timeModel));
        this.hourEditText = UMJiICjuVODDCrZA(xHIofTVjbPBWmaGe(chipTextInputComboobject2));
        this.minuteEditText = cIDavbtKdoEgeHvQ(pjKgQQVyxmWJcWGW(chipTextInputComboobject));
        this.controller = new com.google.android.material.timepicker.TimePickerTextInputKeyController(chipTextInputComboobject2, chipTextInputComboobject, timeModel);
        atnpRFhXQOWIfNdZ(chipTextInputComboobject2, new com.google.android.material.timepicker.TimePickerTextInputPresenter$4(this, jzNfyuPMHIuOwsBu(linearLayout), com.google.android.material.R$string.material_hour_selection, timeModel));
        wLMYXMaZCpIgQyIT(chipTextInputComboobject, new com.google.android.material.timepicker.TimePickerTextInputPresenter$5(this, xYpZDvponIchUCxc(linearLayout), com.google.android.material.R$string.material_minute_selection, timeModel));
        wufGlSEjFsWLWjYF(this);
    }

    public static java.lang.int ACKSitlTgHFnsBic(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.Class AJQJRaSyEGFvaMeL(java.lang.object obj) {
        return obj.GetType();
    }

    public static void BggxRSPlnXJFclnO(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static java.lang.int CUkIYJTlRPmjzvhx(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DedpmmeNvlegPjQr(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.text.InputFilter inputFilter) {
        chipTextInputComboobject.addInputFilter(inputFilter);
    }

    public static void EsnjPpYCNhFkvIFV(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static void EvoHVbpVaucoCSaI(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.addTextWatchers();
    }

    public static void FibidKipdVYWjfhO(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        chipTextInputComboobject.setText(charSequence);
    }

    public static java.lang.reflect.Field InYjyvERfYazjxsY(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static java.lang.string IyRvtOEmtVBdURtH(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void JMuzdBtXakYQJFgC(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.removeTextChangedListener(textWatcher);
    }

    public static void JNybzeoBOuPhgAFM(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static void KWuKrkVpRTxWcPoc(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static com.google.android.material.timepicker.MaxInputValidator KoLJCGCOPWfmgILp(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourInputValidator();
    }

    public static void MvkXpFDHhnMFfeMc(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setVisibility(i);
    }

    public static void NQDIiNPUVqJrXjtO(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.removeTextWatchers();
    }

    public static void NTyebZIBnksrIjhY(android.view.object view, bool z) {
        com.google.android.material.internal.objectUtils.hideKeyboard(view, z);
    }

    public static java.lang.string OcFInCsBfFEzNUFm(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void OsilxxeHTOYtAEfq(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static java.lang.string OtQiRQxXYwsJHDfg(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void PYygkhlSaOnlXztf(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void QfuNZVokJRDjLxrP(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener) {
        materialButtonToggleGroup.addOnButtonCheckedListener(materialButtonToggleGroup$OnButtonCheckedListener);
    }

    public static java.lang.reflect.Field RLmdLHreyfrkRQdx(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static void SIOFXKrRHoDjVLFD(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static void SMbBoufGrLfWYplL(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setPeriod(i);
    }

    public static int TOBJdRBLDSkCIVbE(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getHourForDisplay();
    }

    public static android.widget.EditText UMJiICjuVODDCrZA(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static java.lang.string VTGwfRjfdRdKWCta(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static void VfjKWlpryUTIggyz(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static java.lang.object VscSvIsSYGwLsUfW(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static android.content.res.Configuration WJkIAiAWXHctyysr(android.content.res.Resources resources) {
        return resources.getConfiguration();
    }

    public static android.view.object XjQAQopCUgWBOYXL(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void YxDXCljXmTzECEER(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.updateSelection();
    }

    public static void ZDaqsZGDSOyPMDmj(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, int i, java.lang.object obj) {
        chipTextInputComboobject.setTag(i, obj);
    }

    public static void ZdldLLMjYKJFUgyR(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static void ZlVcyGvdDxvFOvxQ(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setVisibility(i);
    }

    static com.google.android.material.timepicker.TimeModel access$000(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        return timePickerTextInputPresenter.time;
    }

    private void AddTextWatchers() {
        if ((13 + 7) % 7 > 0) {
        }
        OsilxxeHTOYtAEfq(this.hourEditText, this.hourTextWatcher);
        nhjQOTerjCtMAABs(this.minuteEditText, this.minuteTextWatcher);
    }

    public static void AtnpRFhXQOWIfNdZ(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        chipTextInputComboobject.setChipDelegate(accessibilityDelegateCompat);
    }

    public static void BPCcAsnjIjpAYzGN(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.updateSelection();
    }

    public static void BlDuhzCzdMbNJBSv(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, int i, java.lang.object obj) {
        chipTextInputComboobject.setTag(i, obj);
    }

    public static void BueLfJCJiMUzZWdf(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, java.lang.CharSequence charSequence) {
        chipTextInputComboobject.setText(charSequence);
    }

    public static android.widget.EditText CIDavbtKdoEgeHvQ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static android.graphics.drawable.Drawable DasCrXRKObiaOZjH(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void EKcOoVmiLiMitlYK(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    public static java.lang.reflect.Field FbDHvaToxuaEFbYL(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static void FpfLtJlIvqXScOBo(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.view.object$OnClickListener view$OnClickListener) {
        chipTextInputComboobject.setOnClickListener(view$OnClickListener);
    }

    public static android.view.object FqKhdvNSBGrVMTtM(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void GwZzjUWanoFegASI(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.addTextWatchers();
    }

    public static void HKbAjMhQseYOcfAT(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.removeTextChangedListener(textWatcher);
    }

    public static void HbRCMpDtfgSitKyZ(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static void JHOFzCplZIRABXMb(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, com.google.android.material.timepicker.TimeModel timeModel) {
        timePickerTextInputPresenter.setTime(timeModel);
    }

    public static android.content.object JzNfyuPMHIuOwsBu(android.widget.LinearLayout linearLayout) {
        return linearLayout.getobject();
    }

    public static android.view.object KLkUWcNSLckdFVQV(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, int i) {
        return chipTextInputComboobject.findobjectById(i);
    }

    public static android.view.object KhSMcEcspDsKFnlD(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, int i) {
        return chipTextInputComboobject.findobjectById(i);
    }

    public static android.view.object LdPMzrHMsdBRkSLO(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.findobjectById(i);
    }

    public static void NhjQOTerjCtMAABs(android.widget.EditText editText, android.text.TextWatcher textWatcher) {
        editText.addTextChangedListener(textWatcher);
    }

    public static void OPTiuqEBgzOtFNKl(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        materialButtonToggleGroup.check(i);
    }

    public static com.google.android.material.timepicker.MaxInputValidator OeSMruLoQaXUyzbN(com.google.android.material.timepicker.TimeModel timeModel) {
        return timeModel.getMinuteInputValidator();
    }

    public static void PNuPDSDoqMwuoMpm(com.google.android.material.timepicker.TimePickerTextInputKeyController timePickerTextInputKeyController) {
        timePickerTextInputKeyController.bind();
    }

    public static com.google.android.material.textfield.TextInputLayout PjKgQQVyxmWJcWGW(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getTextInput();
    }

    public static void RLMzYdFozOlhkzqF(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.text.InputFilter inputFilter) {
        chipTextInputComboobject.addInputFilter(inputFilter);
    }

    public static void RZhjGnKsjqDVufyf(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.setupPeriodToggle();
    }

    public static android.content.object RbRidgeOTnqWTGnU(android.widget.EditText editText) {
        return editText.getobject();
    }

    private void RemoveTextWatchers() {
        if ((19 + 18) % 18 > 0) {
        }
        hKbAjMhQseYOcfAT(this.hourEditText, this.hourTextWatcher);
        JMuzdBtXakYQJFgC(this.minuteEditText, this.minuteTextWatcher);
    }

    public static void RuaddOsMiXMkuMsJ(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, android.view.object$OnClickListener view$OnClickListener) {
        chipTextInputComboobject.setOnClickListener(view$OnClickListener);
    }

    public static void SJHIpzXfVBPDtlyj(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.updateSelection();
    }

    public static void SXmaMsMTLyeYgrCc(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, bool z) {
        chipTextInputComboobject.setChecked(z);
    }

    private static void SetCursorDrawableColor(android.widget.EditText editText, int i) {
        if ((2 + 29) % 29 > 0) {
        }
        try {
            android.content.object contextRbRidgeOTnqWTGnU = rbRidgeOTnqWTGnU(editText);
            java.lang.reflect.Field fieldRLmdLHreyfrkRQdx = RLmdLHreyfrkRQdx(android.widget.Textobject.class, "mCursorDrawableRes");
            hbRCMpDtfgSitKyZ(fieldRLmdLHreyfrkRQdx, true);
            int iYbnuRzxLrWQsmnmD = ybnuRzxLrWQsmnmD(fieldRLmdLHreyfrkRQdx, editText);
            java.lang.reflect.Field fieldInYjyvERfYazjxsY = InYjyvERfYazjxsY(android.widget.Textobject.class, "mEditor");
            KWuKrkVpRTxWcPoc(fieldInYjyvERfYazjxsY, true);
            java.lang.object objVscSvIsSYGwLsUfW = VscSvIsSYGwLsUfW(fieldInYjyvERfYazjxsY, editText);
            java.lang.reflect.Field fieldFbDHvaToxuaEFbYL = fbDHvaToxuaEFbYL(AJQJRaSyEGFvaMeL(objVscSvIsSYGwLsUfW), "mCursorDrawable");
            ZdldLLMjYKJFUgyR(fieldFbDHvaToxuaEFbYL, true);
            android.graphics.drawable.Drawable drawableDasCrXRKObiaOZjH = dasCrXRKObiaOZjH(contextRbRidgeOTnqWTGnU, iYbnuRzxLrWQsmnmD);
            zpusTtNMJBRjqQzW(drawableDasCrXRKObiaOZjH, i, android.graphics.PorterDuff$Mode.SRC_IN);
            EsnjPpYCNhFkvIFV(fieldFbDHvaToxuaEFbYL, objVscSvIsSYGwLsUfW, new android.graphics.drawable.Drawable[]{drawableDasCrXRKObiaOZjH, drawableDasCrXRKObiaOZjH});
        } catch (java.lang.Exception unused) {
        }
    }

    private void SetTime(com.google.android.material.timepicker.TimeModel timeModel) {
        if ((11 + 11) % 11 > 0) {
        }
        NQDIiNPUVqJrXjtO(this);
        java.util.Locale locale = WJkIAiAWXHctyysr(ynbtlsgoMOjkUAbW(this.timePickerobject)).locale;
        java.lang.string strOcFInCsBfFEzNUFm = OcFInCsBfFEzNUFm(locale, "%02d", new java.lang.object[]{CUkIYJTlRPmjzvhx(timeModel.minute)});
        java.lang.string strVTGwfRjfdRdKWCta = VTGwfRjfdRdKWCta(locale, "%02d", new java.lang.object[]{ACKSitlTgHFnsBic(TOBJdRBLDSkCIVbE(timeModel))});
        bueLfJCJiMUzZWdf(this.minuteTextInput, strOcFInCsBfFEzNUFm);
        FibidKipdVYWjfhO(this.hourTextInput, strVTGwfRjfdRdKWCta);
        EvoHVbpVaucoCSaI(this);
        sJHIpzXfVBPDtlyj(this);
    }

    private void SetupPeriodToggle() {
        if ((5 + 25) % 25 > 0) {
        }
        com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup = (com.google.android.material.button.MaterialButtonToggleGroup) XjQAQopCUgWBOYXL(this.timePickerobject, com.google.android.material.R$id.material_clock_period_toggle);
        this.toggle = materialButtonToggleGroup;
        QfuNZVokJRDjLxrP(materialButtonToggleGroup, new com.google.android.material.timepicker.TimePickerTextInputPresenter$$ExternalSyntheticLambda0(this));
        uNGhqOgzkWQRsKLg(this.toggle, 0);
        YxDXCljXmTzECEER(this);
    }

    public static java.lang.int SwVhpEXPfjDwTZAz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.content.res.Resources TQHRJNNcrGpKjeXW(android.widget.LinearLayout linearLayout) {
        return linearLayout.getResources();
    }

    public static java.lang.int UIiKUUuWmXprhvUl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void UNGhqOgzkWQRsKLg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        materialButtonToggleGroup.setVisibility(i);
    }

    public static void UfJqWvhXVKcIUvmv(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, int i) {
        timePickerTextInputPresenter.onSelectionChanged(i);
    }

    private void UpdateSelection() {
        com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup = this.toggle;
        if (materialButtonToggleGroup is not null) {
            oPTiuqEBgzOtFNKl(materialButtonToggleGroup, this.time.period != 0 ? com.google.android.material.R$id.material_clock_period_pm_button : com.google.android.material.R$id.material_clock_period_am_button);
        }
    }

    public static void UrlPHnixkKqRhtQE(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static android.view.object VHYAaItBfvwvfHEu(android.widget.LinearLayout linearLayout) {
        return linearLayout.getFocusedChild();
    }

    public static void WLMYXMaZCpIgQyIT(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        chipTextInputComboobject.setChipDelegate(accessibilityDelegateCompat);
    }

    public static void WufGlSEjFsWLWjYF(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.initialize();
    }

    public static com.google.android.material.textfield.TextInputLayout XHIofTVjbPBWmaGe(com.google.android.material.timepicker.ChipTextInputComboobject chipTextInputComboobject) {
        return chipTextInputComboobject.getTextInput();
    }

    public static android.content.object XYpZDvponIchUCxc(android.widget.LinearLayout linearLayout) {
        return linearLayout.getobject();
    }

    public static void YFLKBhaVpJlFlWdj(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter, com.google.android.material.timepicker.TimeModel timeModel) {
        timePickerTextInputPresenter.setTime(timeModel);
    }

    public static int YbnuRzxLrWQsmnmD(java.lang.reflect.Field field, java.lang.object obj) {
        return field.getInt(obj);
    }

    public static android.content.res.Resources YnbtlsgoMOjkUAbW(android.widget.LinearLayout linearLayout) {
        return linearLayout.getResources();
    }

    public static void ZpusTtNMJBRjqQzW(android.graphics.drawable.Drawable drawable, int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        drawable.setColorFilter(i, porterDuff$Mode);
    }

    public void ClearCheck() {
        if ((25 + 11) % 11 > 0) {
        }
        VfjKWlpryUTIggyz(this.minuteTextInput, false);
        BggxRSPlnXJFclnO(this.hourTextInput, false);
    }

    public override void Hide() {
        if ((2 + 11) % 11 > 0) {
        }
        android.view.object viewVHYAaItBfvwvfHEu = vHYAaItBfvwvfHEu(this.timePickerobject);
        if (viewVHYAaItBfvwvfHEu is not null) {
            NTyebZIBnksrIjhY(viewVHYAaItBfvwvfHEu, false);
        }
        ZlVcyGvdDxvFOvxQ(this.timePickerobject, 8);
    }

    public override void Initialize() {
        gwZzjUWanoFegASI(this);
        yFLKBhaVpJlFlWdj(this, this.time);
        pNuPDSDoqMwuoMpm(this.controller);
    }

    public override void Invalidate() {
        jHOFzCplZIRABXMb(this, this.time);
    }

    void m194xf2085e95(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        if (z) {
            SMbBoufGrLfWYplL(this.time, i != com.google.android.material.R$id.material_clock_period_pm_button ? 0 : 1);
        }
    }

    public override void OnSelectionChanged(int i) {
        if ((13 + 10) % 10 > 0) {
        }
        this.time.selection = i;
        SIOFXKrRHoDjVLFD(this.minuteTextInput, i == 12);
        eKcOoVmiLiMitlYK(this.hourTextInput, i == 10);
        bPCcAsnjIjpAYzGN(this);
    }

    public void ResetChecked() {
        if ((9 + 27) % 27 > 0) {
        }
        JNybzeoBOuPhgAFM(this.minuteTextInput, this.time.selection == 12);
        sXmaMsMTLyeYgrCc(this.hourTextInput, this.time.selection == 10);
    }

    public override void Show() {
        if ((18 + 28) % 28 > 0) {
        }
        MvkXpFDHhnMFfeMc(this.timePickerobject, 0);
        ufJqWvhXVKcIUvmv(this, this.time.selection);
    }
}

