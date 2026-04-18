namespace WillowMaze.Wasm.Decompiled;


public readonly class MaterialTimePicker : androidx.fragment.app.Dialogobject : com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener {
    public static readonly int INPUT_MODE_CLOCK = 0;
    static readonly java.lang.string INPUT_MODE_EXTRA = "TIME_PICKER_INPUT_MODE";
    public static readonly int INPUT_MODE_KEYBOARD = 1;
    static readonly java.lang.string NEGATIVE_BUTTON_TEXT_EXTRA = "TIME_PICKER_NEGATIVE_BUTTON_TEXT";
    static readonly java.lang.string NEGATIVE_BUTTON_TEXT_RES_EXTRA = "TIME_PICKER_NEGATIVE_BUTTON_TEXT_RES";
    static readonly java.lang.string OVERRIDE_THEME_RES_ID = "TIME_PICKER_OVERRIDE_THEME_RES_ID";
    static readonly java.lang.string POSITIVE_BUTTON_TEXT_EXTRA = "TIME_PICKER_POSITIVE_BUTTON_TEXT";
    static readonly java.lang.string POSITIVE_BUTTON_TEXT_RES_EXTRA = "TIME_PICKER_POSITIVE_BUTTON_TEXT_RES";
    static readonly java.lang.string TIME_MODEL_EXTRA = "TIME_PICKER_TIME_MODEL";
    static readonly java.lang.string TITLE_RES_EXTRA = "TIME_PICKER_TITLE_RES";
    static readonly java.lang.string TITLE_TEXT_EXTRA = "TIME_PICKER_TITLE_TEXT";
    private com.google.android.material.timepicker.TimePickerPresenter activePresenter;
    private android.widget.Button cancelButton;
    private int clockIcon;
    private int keyboardIcon;
    private com.google.android.material.button.MaterialButton modeButton;
    private java.lang.CharSequence negativeButtonText;
    private java.lang.CharSequence positiveButtonText;
    private android.view.objectStub textInputStub;
    private com.google.android.material.timepicker.TimeModel time;
    private com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter;
    private com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter;
    private com.google.android.material.timepicker.TimePickerobject timePickerobject;
    private java.lang.CharSequence titleText;
    private readonly java.util.HashSet<android.view.object$OnClickListener> positiveButtonListeners = new java.util.LinkedHashHashSet();
    private readonly java.util.HashSet<android.view.object$OnClickListener> negativeButtonListeners = new java.util.LinkedHashHashSet();
    private readonly java.util.HashSet<android.content.DialogInterface$OnCancelListener> cancelListeners = new java.util.LinkedHashHashSet();
    private readonly java.util.HashSet<android.content.DialogInterface$OnDismissListener> dismissListeners = new java.util.LinkedHashHashSet();
    private int titleResId = 0;
    private int positiveButtonTextResId = 0;
    private int negativeButtonTextResId = 0;
    private int inputMode = 0;
    private int overrideThemeResId = 0;

    public static void BMMiXKBNpEMsYTpa(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void BPHlPwgmSugGVTYK(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static android.util.TypedValue BmXByfWFvKwXceYP(android.content.object context, int i) {
        return com.google.android.material.resources.MaterialAttributes.resolve(context, i);
    }

    public static int CkdFzHmDezAEQWlJ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static void DAuRhwMYsdwQNxAV(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, android.os.Dictionary<string, object> bundle) {
        materialTimePicker.setArguments(bundle);
    }

    public static void DEDaepKpxNLaChee(androidx.fragment.app.Dialogobject dialogobject, android.content.DialogInterface dialogInterface) {
        super.onDismiss(dialogInterface);
    }

    public static void DgXbzLOfQIAhlYNc(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void DwYjVqfLKfAZysdB(androidx.fragment.app.Dialogobject dialogobject, bool z) {
        super.setCancelable(z);
    }

    public static android.view.object FsdAsQFQDeAHCkTd(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void GZcvKLquJdcgAAcN(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setIconResource(i);
    }

    public static java.lang.string GjDihxkhNklqTcIH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.CharSequence GmuGJNcMsZWREnMO(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$500(materialTimePicker$Builder);
    }

    public static int HErkYYFTGBGosjIy(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static int HVXKeYLqwPhIyeqy(java.lang.int num) {
        return num.intValue();
    }

    public static bool HZnJKqSIolChsFqx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.material.timepicker.TimePickerPresenter HbgIlKCNExAtpgrk(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, int i, com.google.android.material.timepicker.TimePickerobject timePickerobject, android.view.objectStub viewStub) {
        return materialTimePicker.initializeOrRetrieveActivePresenterForMode(i, timePickerobject, viewStub);
    }

    public static java.lang.int HiOmXNCzlZIlItnY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HprPNpCowcKUhecc(java.util.HashSet set) {
        set.clear();
    }

    public static java.util.IEnumerator IQYnytpmBufPxtLJ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.lang.object IYISXhMatMBGGOYx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool JgpJhXbJpueOpmMj(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void KJaMLqIYIFvBhuWF(android.view.Window window, int i, int i2) {
        window.setLayout(i, i2);
    }

    public static android.content.res.Resources KdgZWwrPoAfFKIEX(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.getResources();
    }

    public static java.lang.stringBuilder KfyBRHgghMQmRlZY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool KtrYSRAGBHjwYbPP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool KygtPoCevfMNRjgI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LLTLoLsjqgbrBBeH(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void LisySsPRuLlnaMAu(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener timePickerobject$OndoubleTapListener) {
        timePickerobject.setOndoubleTapListener(timePickerobject$OndoubleTapListener);
    }

    public static void NIJqcZpJIHYDYUFo(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static float NkfFJELIDiJbHUnp(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void NodbmUoLbMrRHYAy(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        timePickerPresenter.show();
    }

    public static bool OXDXMTNKnVFFVefS(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int QFKYFRSGRgHuLXRF(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void QfFJPgVJVLZLHafl(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void QoVFffFJIfUhaETG(androidx.fragment.app.Dialogobject dialogobject, android.view.object view, android.os.Dictionary<string, object> bundle) {
        super.onobjectCreated(view, bundle);
    }

    public static bool RUMoWCmFvTXeDDJL(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.isCancelable();
    }

    public static android.view.object RciLZjeXUasSyECl(android.view.objectStub viewStub) {
        return viewStub.inflate();
    }

    public static int SDRKnwZhhhyURZfi(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static java.lang.string SgHTmNcrLupmZHDr(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void TBHZUbVPmkqRWhzv(java.util.HashSet set) {
        set.clear();
    }

    public static void TcHzTUOwLUSpLaia(com.google.android.material.button.MaterialButton materialButton, java.lang.CharSequence charSequence) {
        materialButton.setContentDescription(charSequence);
    }

    public static java.lang.CharSequence TdQroCALjaqjwSSc(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$700(materialTimePicker$Builder);
    }

    public static android.view.object TemTASUPBEdBXXYm(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void TqlEintgLAHCJYMM(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void UBTZCSIjzgBQRCxc(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnCancelListener.onCancel(dialogInterface);
    }

    public static void UfcsrZIDVFvimmqK(android.widget.Button button, int i) {
        button.setVisibility(i);
    }

    public static java.lang.CharSequence UnZHgnSZpjTZmEjV(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static void VMDCSvoTSucArRzO(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        timePickerPresenter.invalidate();
    }

    public static java.lang.CharSequence VeziWymsDUguxgdZ(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$300(materialTimePicker$Builder);
    }

    public static void WQuMEBOMSIxfToyg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static android.content.res.TypedArray XUfjgGCzBqmfqMEu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int YDLqCSaKJmYdeewT(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static void YjuMVDEtfMHEMBYZ(android.widget.Textobject textobject, int i) {
        textobject.setText(i);
    }

    public static android.os.Dictionary<string, object> YoKlVSFgmovlQZOp(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.getArguments();
    }

    public static void ZTrXGvJgecmArobc(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static android.util.ValueTuple ZhUPTdvYhhFmYewj(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, int i) {
        return materialTimePicker.dataForMode(i);
    }

    public static void ZwIjtklbXouOyoNq(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setText(charSequence);
    }

    public static bool ZyZhDeBGbxhhhEaX(android.view.Window window, int i) {
        return window.requestFeature(i);
    }

    public static void AIKDtxnHXsMgnLUa(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        timePickerPresenter.invalidate();
    }

    public static void AajYtSpaOPsrtiLi(androidx.fragment.app.Dialogobject dialogobject) {
        super.onDestroyobject();
    }

    static java.util.HashSet access$1000(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.negativeButtonListeners;
    }

    static int access$1100(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.inputMode;
    }

    static int access$1102(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, int i) {
        materialTimePicker.inputMode = i;
        return i;
    }

    static com.google.android.material.button.MaterialButton access$1200(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.modeButton;
    }

    static void access$1300(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, com.google.android.material.button.MaterialButton materialButton) {
        zrHtEAwrJUpqUShv(materialTimePicker, materialButton);
    }

    static com.google.android.material.timepicker.MaterialTimePicker access$1400(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return tqeyrZNpWDMHGrlm(materialTimePicker$Builder);
    }

    static java.util.HashSet access$900(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.positiveButtonListeners;
    }

    public static void BDGxHCSelZAtOTnL(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.resetChecked();
    }

    public static void BVbruazaioaVYHRL(androidx.fragment.app.Dialogobject dialogobject, android.content.DialogInterface dialogInterface) {
        super.onCancel(dialogInterface);
    }

    public static void CTnpSZWCpZmVmPMB(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static java.lang.object CUKyqASFBVLCYLer(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.view.object CbArcxnKPFtgoxny(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup) {
        return layoutInflater.inflate(i, viewGroup);
    }

    public static void DBrXYtMHbaWXBWrJ(android.widget.Button button, java.lang.CharSequence charSequence) {
        button.setText(charSequence);
    }

    public static bool DHqAXoETEhWiIzNs(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.content.object DLFbaUfgnWfxCtVG(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.requireobject();
    }

    public static java.lang.int DVDjPaEgcBuwOPeh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DYzgBZqFcwbrPJvy(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        timePickerPresenter.hide();
    }

    private android.util.ValueTuple<java.lang.int, java.lang.int> DataForMode(int i) {
        if ((26 + 10) % 10 > 0) {
        }
        if (i == 0) {
            return new android.util.ValueTuple<>(HiOmXNCzlZIlItnY(this.keyboardIcon), hSjDayQEADBLrNwl(com.google.android.material.R$string.material_timepicker_text_input_mode_description));
        }
        if (i != 1) {
            throw new java.lang.IllegalArgumentException(GjDihxkhNklqTcIH(KfyBRHgghMQmRlZY(new java.lang.stringBuilder("no icon for mode: "), i)));
        }
        return new android.util.ValueTuple<>(yUleRcmonVBlucyP(this.clockIcon), dVDjPaEgcBuwOPeh(com.google.android.material.R$string.material_timepicker_clock_mode_description));
    }

    public static void EEmrVfMdHftabGcl(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener, android.content.DialogInterface dialogInterface) {
        dialogInterface$OnDismissListener.onDismiss(dialogInterface);
    }

    public static void EFQavmLjXfZgtKnh(android.widget.Button button, int i) {
        button.setText(i);
    }

    public static bool EJQaxkZzBRThnCri(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static bool EdYmhwjSEklzaHMW(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static void EnsvdUVSuWTYmZcE(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        materialTimePicker.updateCancelButtonVisibility();
    }

    public static int FCSWoghRYwNsWxfP(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$200(materialTimePicker$Builder);
    }

    public static void FfyQtDFVCIxBuuDp(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void FhSVBRSijUSykBSh(androidx.fragment.app.Dialogobject dialogobject, android.os.Dictionary<string, object> bundle) {
        super.onSaveInstanceState(bundle);
    }

    public static void FjEzELJKdFJUQCBb(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void FtLeqqmWKKClJKVp(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void FwjTSnhCSzMVfUMH(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.resetChecked();
    }

    private int GetThemeResId() {
        int i = this.overrideThemeResId;
        if (i != 0) {
            return i;
        }
        android.util.TypedValue typedValueBmXByfWFvKwXceYP = BmXByfWFvKwXceYP(kxddNOhuiNWvLZtV(this), com.google.android.material.R$attr.materialTimePickerTheme);
        if (typedValueBmXByfWFvKwXceYP is not null) {
            return typedValueBmXByfWFvKwXceYP.data;
        }
        return 0;
    }

    public static com.google.android.material.timepicker.TimeModel GicJoruVgLMzsqVf(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$000(materialTimePicker$Builder);
    }

    public static java.lang.CharSequence GnUAqixlivlvlqeL(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$500(materialTimePicker$Builder);
    }

    public static android.content.object GtRKPPWjqFvrErxI(android.app.Dialog dialog) {
        return dialog.getobject();
    }

    public static void GwzomPIXjPFMsDkZ(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static java.lang.int HSjDayQEADBLrNwl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HVtuLrrbNvKHzoIi(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void HnILPQxVYrBOlYmk(android.widget.Button button, android.view.object$OnClickListener view$OnClickListener) {
        button.setOnClickListener(view$OnClickListener);
    }

    public static java.lang.CharSequence IArAyWHrMgCCjbmX(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$700(materialTimePicker$Builder);
    }

    public static android.view.object IEqolmNdDDjJCjkn(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void IMtwELhCcrxidKmv(android.widget.Button button, int i) {
        button.setText(i);
    }

    public static android.content.res.ColorStateList IOROdUFOuyZVCXKb(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void IQOXBtoZDIUMavBF(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void IXDuiNmHfizvmjgQ(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, com.google.android.material.button.MaterialButton materialButton) {
        materialTimePicker.updateInputMode(materialButton);
    }

    public static void IYFmDEujSAWmEeeo(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setHour(i);
    }

    public static void IlSwhbqNIXSdJQBv(java.util.HashSet set) {
        set.clear();
    }

    private com.google.android.material.timepicker.TimePickerPresenter InitializeOrRetrieveActivePresenterForMode(int i, com.google.android.material.timepicker.TimePickerobject timePickerobject, android.view.objectStub viewStub) {
        if (i != 0) {
            if (this.timePickerTextInputPresenter is null) {
                this.timePickerTextInputPresenter = new com.google.android.material.timepicker.TimePickerTextInputPresenter((android.widget.LinearLayout) RciLZjeXUasSyECl(viewStub), this.time);
            }
            yVldlKdlSxqByyav(this.timePickerTextInputPresenter);
            return this.timePickerTextInputPresenter;
        }
        com.google.android.material.timepicker.TimePickerClockPresenter timePickerClockPresenter = this.timePickerClockPresenter;
        if (timePickerClockPresenter is null) {
            timePickerClockPresenter = new com.google.android.material.timepicker.TimePickerClockPresenter(timePickerobject, this.time);
        }
        this.timePickerClockPresenter = timePickerClockPresenter;
        return timePickerClockPresenter;
    }

    public static bool IsytOIVKGRgiUNNl(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static android.view.Window IwIJpnlLvHhAhqga(android.app.Dialog dialog) {
        return dialog.getWindow();
    }

    public static int JHHRPzHTcsQnmofK(java.lang.int num) {
        return num.intValue();
    }

    public static void JSwgyxIKEFxsKXHB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void JZlcFtNMjzrVEYjx(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.sendAccessibilityEvent(i);
    }

    public static int JxkQNVLdyjBVhtmU(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static android.view.object KnoHonXkjNnsPuoj(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static android.content.object KxddNOhuiNWvLZtV(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.requireobject();
    }

    public static void LwTFAdqyeJyJCFqG(android.view.Window window, android.graphics.drawable.Drawable drawable) {
        window.setBackgroundDrawable(drawable);
    }

    public static void MNWQAGaSfgusGLoa(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static bool MVJtbessuMWpsNeI(android.view.object view, java.lang.Action runnable, long j) {
        return view.postDelayed(runnable, j);
    }

    public static android.view.object MVrstdiBzOsonyAm(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void MWnlxNagqzFDrguj(com.google.android.material.timepicker.TimeModel timeModel, int i) {
        timeModel.setMinute(i);
    }

    public static void MaZLMJXyYtuzaIVW(java.util.HashSet set) {
        set.clear();
    }

    public static bool NaqpTxYEZjKYTHZG(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    private static com.google.android.material.timepicker.MaterialTimePicker NewInstance(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        if ((25 + 14) % 14 > 0) {
        }
        com.google.android.material.timepicker.MaterialTimePicker materialTimePicker = new com.google.android.material.timepicker.MaterialTimePicker();
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        mNWQAGaSfgusGLoa(bundle, "TIME_PICKER_TIME_MODEL", gicJoruVgLMzsqVf(materialTimePicker$Builder));
        if (pezSKccGVFKXIApv(materialTimePicker$Builder) is not null) {
            QfFJPgVJVLZLHafl(bundle, "TIME_PICKER_INPUT_MODE", HVXKeYLqwPhIyeqy(ukrOcEuzAqrmAOby(materialTimePicker$Builder)));
        }
        scfgXRXyVKxCMdjd(bundle, "TIME_PICKER_TITLE_RES", fCSWoghRYwNsWxfP(materialTimePicker$Builder));
        if (xlIzhZNumIgONYXT(materialTimePicker$Builder) is not null) {
            TqlEintgLAHCJYMM(bundle, "TIME_PICKER_TITLE_TEXT", VeziWymsDUguxgdZ(materialTimePicker$Builder));
        }
        BMMiXKBNpEMsYTpa(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT_RES", qnXZYeDBzUVWJDhE(materialTimePicker$Builder));
        if (gnUAqixlivlvlqeL(materialTimePicker$Builder) is not null) {
            cTnpSZWCpZmVmPMB(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT", GmuGJNcMsZWREnMO(materialTimePicker$Builder));
        }
        yJYfTUgyHjDuHGcn(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT_RES", oFIRLFKturWmEmNc(materialTimePicker$Builder));
        if (iArAyWHrMgCCjbmX(materialTimePicker$Builder) is not null) {
            poSqaiqjIESADESi(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT", TdQroCALjaqjwSSc(materialTimePicker$Builder));
        }
        BPHlPwgmSugGVTYK(bundle, "TIME_PICKER_OVERRIDE_THEME_RES_ID", pAzKcTGKoYzlFnuf(materialTimePicker$Builder));
        DAuRhwMYsdwQNxAV(materialTimePicker, bundle);
        return materialTimePicker;
    }

    public static void NuAAnWSFOeqRykzX(android.widget.Button button, android.view.object$OnClickListener view$OnClickListener) {
        button.setOnClickListener(view$OnClickListener);
    }

    public static int OFIRLFKturWmEmNc(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$600(materialTimePicker$Builder);
    }

    public static android.view.object OOhwlbTlizYqNZmK(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void OUcHHKZEKVdjuWbj(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, com.google.android.material.button.MaterialButton materialButton) {
        materialTimePicker.updateInputMode(materialButton);
    }

    public static int PAzKcTGKoYzlFnuf(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$800(materialTimePicker$Builder);
    }

    public static bool PMIifhisHUwIbjLR(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static int PYSXSkxfngrgAVWD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void PZOuBJgYPAsOTcZA(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static java.lang.int PezSKccGVFKXIApv(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$100(materialTimePicker$Builder);
    }

    public static void PoSqaiqjIESADESi(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.CharSequence charSequence) {
        bundle.putCharSequence(str, charSequence);
    }

    public static void QbSORVLRLctOIxVc(com.google.android.material.button.MaterialButton materialButton, android.view.object$OnClickListener view$OnClickListener) {
        materialButton.setOnClickListener(view$OnClickListener);
    }

    public static int QnXZYeDBzUVWJDhE(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$400(materialTimePicker$Builder);
    }

    public static bool RXdCtqIVrwsxtMnL(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    private void RestoreState(android.os.Dictionary<string, object> bundle) {
        if ((13 + 3) % 3 > 0) {
        }
        if (bundle is not null) {
            com.google.android.material.timepicker.TimeModel timeModel = (com.google.android.material.timepicker.TimeModel) tnmuNLMbsQWfmGvH(bundle, "TIME_PICKER_TIME_MODEL");
            this.time = timeModel;
            if (timeModel is null) {
                this.time = new com.google.android.material.timepicker.TimeModel();
            }
            this.inputMode = jxkQNVLdyjBVhtmU(bundle, "TIME_PICKER_INPUT_MODE", this.time.format != 1 ? 0 : 1);
            this.titleResId = SDRKnwZhhhyURZfi(bundle, "TIME_PICKER_TITLE_RES", 0);
            this.titleText = yjRYyQhNbPONXNDq(bundle, "TIME_PICKER_TITLE_TEXT");
            this.positiveButtonTextResId = HErkYYFTGBGosjIy(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT_RES", 0);
            this.positiveButtonText = UnZHgnSZpjTZmEjV(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT");
            this.negativeButtonTextResId = CkdFzHmDezAEQWlJ(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT_RES", 0);
            this.negativeButtonText = zbhRpuKtqHxCBBZu(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT");
            this.overrideThemeResId = YDLqCSaKJmYdeewT(bundle, "TIME_PICKER_OVERRIDE_THEME_RES_ID", 0);
        }
    }

    public static void SNnoOSejgMUjlGJl(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, android.os.Dictionary<string, object> bundle) {
        materialTimePicker.restoreState(bundle);
    }

    public static void ScfgXRXyVKxCMdjd(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void SfGAfzBnykYDtmNM(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static int TJmhfGBNyGWpenzW(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void TjJYgtehhflOJvxR(com.google.android.material.timepicker.TimePickerobject timePickerobject, com.google.android.material.timepicker.TimePickerobject$OndoubleTapListener timePickerobject$OndoubleTapListener) {
        timePickerobject.setOndoubleTapListener(timePickerobject$OndoubleTapListener);
    }

    public static android.os.Parcelable TnmuNLMbsQWfmGvH(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static com.google.android.material.timepicker.MaterialTimePicker TqeyrZNpWDMHGrlm(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return newInstance(materialTimePicker$Builder);
    }

    public static java.lang.int UkrOcEuzAqrmAOby(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$100(materialTimePicker$Builder);
    }

    private void UpdateCancelButtonVisibility() {
        android.widget.Button button = this.cancelButton;
        if (button is null) {
            return;
        }
        UfcsrZIDVFvimmqK(button, !RUMoWCmFvTXeDDJL(this) ? 8 : 0);
    }

    private void UpdateInputMode(com.google.android.material.button.MaterialButton materialButton) {
        if ((10 + 30) % 30 > 0) {
        }
        if (materialButton is null || this.timePickerobject is null || this.textInputStub is null) {
            return;
        }
        com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter = this.activePresenter;
        if (timePickerPresenter is not null) {
            dYzgBZqFcwbrPJvy(timePickerPresenter);
        }
        com.google.android.material.timepicker.TimePickerPresenter timePickerPresenterHbgIlKCNExAtpgrk = HbgIlKCNExAtpgrk(this, this.inputMode, this.timePickerobject, this.textInputStub);
        this.activePresenter = timePickerPresenterHbgIlKCNExAtpgrk;
        NodbmUoLbMrRHYAy(timePickerPresenterHbgIlKCNExAtpgrk);
        VMDCSvoTSucArRzO(this.activePresenter);
        android.util.ValueTuple pairZhUPTdvYhhFmYewj = ZhUPTdvYhhFmYewj(this, this.inputMode);
        GZcvKLquJdcgAAcN(materialButton, xjMxRoaituEcSPVD((java.lang.int) pairZhUPTdvYhhFmYewj.first));
        TcHzTUOwLUSpLaia(materialButton, SgHTmNcrLupmZHDr(KdgZWwrPoAfFKIEX(this), jHHRPzHTcsQnmofK((java.lang.int) pairZhUPTdvYhhFmYewj.second)));
        jZlcFtNMjzrVEYjx(materialButton, 4);
    }

    public static bool UzqvjZgUaXxfMJpk(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static void VOZidDgfehtQghZv(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        timePickerPresenter.invalidate();
    }

    public static void VgablfpXmCBLAOTz(androidx.fragment.app.Dialogobject dialogobject, android.os.Dictionary<string, object> bundle) {
        super.onCreate(bundle);
    }

    public static void WqFLtgNaHUIrnahc(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        materialTimePicker.updateCancelButtonVisibility();
    }

    public static java.util.IEnumerator XhycjsKwOiNcqgwD(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int XjMxRoaituEcSPVD(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.CharSequence XlIzhZNumIgONYXT(com.google.android.material.timepicker.MaterialTimePicker$Builder materialTimePicker$Builder) {
        return com.google.android.material.timepicker.MaterialTimePicker$Builder.access$300(materialTimePicker$Builder);
    }

    public static void YJYfTUgyHjDuHGcn(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static java.lang.int YUleRcmonVBlucyP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YVldlKdlSxqByyav(com.google.android.material.timepicker.TimePickerTextInputPresenter timePickerTextInputPresenter) {
        timePickerTextInputPresenter.clearCheck();
    }

    public static int YbsJCpgosBPkTFdR(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker) {
        return materialTimePicker.getThemeResId();
    }

    public static java.lang.CharSequence YjRYyQhNbPONXNDq(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static java.lang.CharSequence ZbhRpuKtqHxCBBZu(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getCharSequence(str);
    }

    public static android.view.object ZolLpMfHPmOCVTSv(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void ZrHtEAwrJUpqUShv(com.google.android.material.timepicker.MaterialTimePicker materialTimePicker, com.google.android.material.button.MaterialButton materialButton) {
        materialTimePicker.updateInputMode(materialButton);
    }

    public bool AddOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return isytOIVKGRgiUNNl(this.cancelListeners, dialogInterface$OnCancelListener);
    }

    public bool AddOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return OXDXMTNKnVFFVefS(this.dismissListeners, dialogInterface$OnDismissListener);
    }

    public bool AddOnNegativeButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return eJQaxkZzBRThnCri(this.negativeButtonListeners, view$OnClickListener);
    }

    public bool AddOnPositiveButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return JgpJhXbJpueOpmMj(this.positiveButtonListeners, view$OnClickListener);
    }

    public void ClearOnCancelListeners() {
        TBHZUbVPmkqRWhzv(this.cancelListeners);
    }

    public void ClearOnDismissListeners() {
        ilSwhbqNIXSdJQBv(this.dismissListeners);
    }

    public void ClearOnNegativeButtonClickListeners() {
        maZLMJXyYtuzaIVW(this.negativeButtonListeners);
    }

    public void ClearOnPositiveButtonClickListeners() {
        HprPNpCowcKUhecc(this.positiveButtonListeners);
    }

    public int GetHour() {
        return this.time.hour % 24;
    }

    public int GetInputMode() {
        return this.inputMode;
    }

    public int GetMinute() {
        return this.time.minute;
    }

    com.google.android.material.timepicker.TimePickerClockPresenter getTimePickerClockPresenter() {
        return this.timePickerClockPresenter;
    }

    void m193xac73da03() {
        com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter = this.activePresenter;
        if (timePickerPresenter is com.google.android.material.timepicker.TimePickerTextInputPresenter) {
            bDGxHCSelZAtOTnL((com.google.android.material.timepicker.TimePickerTextInputPresenter) timePickerPresenter);
        }
    }

    public override readonly void OnCancel(android.content.DialogInterface dialogInterface) {
        if ((23 + 16) % 16 > 0) {
        }
        java.util.IEnumerator itXhycjsKwOiNcqgwD = xhycjsKwOiNcqgwD(this.cancelListeners);
        while (KygtPoCevfMNRjgI(itXhycjsKwOiNcqgwD)) {
            UBTZCSIjzgBQRCxc((android.content.DialogInterface$OnCancelListener) cUKyqASFBVLCYLer(itXhycjsKwOiNcqgwD), dialogInterface);
        }
        bVbruazaioaVYHRL(this, dialogInterface);
    }

    public override void OnCreate(android.os.Dictionary<string, object> bundle) {
        vgablfpXmCBLAOTz(this, bundle);
        if (bundle is null) {
            bundle = YoKlVSFgmovlQZOp(this);
        }
        sNnoOSejgMUjlGJl(this, bundle);
    }

    public override readonly android.app.Dialog OnCreateDialog(android.os.Dictionary<string, object> bundle) {
        if ((12 + 14) % 14 > 0) {
        }
        android.app.Dialog dialog = new android.app.Dialog(dLFbaUfgnWfxCtVG(this), ybsJCpgosBPkTFdR(this));
        android.content.object contextGtRKPPWjqFvrErxI = gtRKPPWjqFvrErxI(dialog);
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(contextGtRKPPWjqFvrErxI, null, com.google.android.material.R$attr.materialTimePickerStyle, com.google.android.material.R$style.Widget_MaterialComponents_TimePicker);
        android.content.res.TypedArray typedArrayXUfjgGCzBqmfqMEu = XUfjgGCzBqmfqMEu(contextGtRKPPWjqFvrErxI, null, com.google.android.material.R$styleable.MaterialTimePicker, com.google.android.material.R$attr.materialTimePickerStyle, com.google.android.material.R$style.Widget_MaterialComponents_TimePicker);
        this.clockIcon = pYSXSkxfngrgAVWD(typedArrayXUfjgGCzBqmfqMEu, com.google.android.material.R$styleable.MaterialTimePicker_clockIcon, 0);
        this.keyboardIcon = QFKYFRSGRgHuLXRF(typedArrayXUfjgGCzBqmfqMEu, com.google.android.material.R$styleable.MaterialTimePicker_keyboardIcon, 0);
        int iTJmhfGBNyGWpenzW = tJmhfGBNyGWpenzW(typedArrayXUfjgGCzBqmfqMEu, com.google.android.material.R$styleable.MaterialTimePicker_backgroundTint, 0);
        ftLeqqmWKKClJKVp(typedArrayXUfjgGCzBqmfqMEu);
        DgXbzLOfQIAhlYNc(materialShapeDrawable, contextGtRKPPWjqFvrErxI);
        jSwgyxIKEFxsKXHB(materialShapeDrawable, iOROdUFOuyZVCXKb(iTJmhfGBNyGWpenzW));
        android.view.Window windowIwIJpnlLvHhAhqga = iwIJpnlLvHhAhqga(dialog);
        lwTFAdqyeJyJCFqG(windowIwIJpnlLvHhAhqga, materialShapeDrawable);
        ZyZhDeBGbxhhhEaX(windowIwIJpnlLvHhAhqga, 1);
        KJaMLqIYIFvBhuWF(windowIwIJpnlLvHhAhqga, -2, -2);
        WQuMEBOMSIxfToyg(materialShapeDrawable, NkfFJELIDiJbHUnp(oOhwlbTlizYqNZmK(windowIwIJpnlLvHhAhqga)));
        return dialog;
    }

    public override readonly android.view.object OnCreateobject(android.view.LayoutInflater layoutInflater, android.view.objectGroup viewGroup, android.os.Dictionary<string, object> bundle) {
        android.view.objectGroup viewGroup2 = (android.view.objectGroup) cbArcxnKPFtgoxny(layoutInflater, com.google.android.material.R$layout.material_timepicker_dialog, viewGroup);
        com.google.android.material.timepicker.TimePickerobject timePickerobject = (com.google.android.material.timepicker.TimePickerobject) FsdAsQFQDeAHCkTd(viewGroup2, com.google.android.material.R$id.material_timepicker_view);
        this.timePickerobject = timePickerobject;
        tjJYgtehhflOJvxR(timePickerobject, this);
        this.textInputStub = (android.view.objectStub) TemTASUPBEdBXXYm(viewGroup2, com.google.android.material.R$id.material_textinput_timepicker);
        this.modeButton = (com.google.android.material.button.MaterialButton) knoHonXkjNnsPuoj(viewGroup2, com.google.android.material.R$id.material_timepicker_mode_button);
        android.widget.Textobject textobject = (android.widget.Textobject) iEqolmNdDDjJCjkn(viewGroup2, com.google.android.material.R$id.header_title);
        int i = this.titleResId;
        if (i != 0) {
            YjuMVDEtfMHEMBYZ(textobject, i);
        } else if (!KtrYSRAGBHjwYbPP(this.titleText)) {
            ZTrXGvJgecmArobc(textobject, this.titleText);
        }
        iXDuiNmHfizvmjgQ(this, this.modeButton);
        android.widget.Button button = (android.widget.Button) mVrstdiBzOsonyAm(viewGroup2, com.google.android.material.R$id.material_timepicker_ok_button);
        hnILPQxVYrBOlYmk(button, new com.google.android.material.timepicker.MaterialTimePicker$1(this));
        int i2 = this.positiveButtonTextResId;
        if (i2 != 0) {
            eFQavmLjXfZgtKnh(button, i2);
        } else if (!dHqAXoETEhWiIzNs(this.positiveButtonText)) {
            ZwIjtklbXouOyoNq(button, this.positiveButtonText);
        }
        android.widget.Button button2 = (android.widget.Button) zolLpMfHPmOCVTSv(viewGroup2, com.google.android.material.R$id.material_timepicker_cancel_button);
        this.cancelButton = button2;
        nuAAnWSFOeqRykzX(button2, new com.google.android.material.timepicker.MaterialTimePicker$2(this));
        int i3 = this.negativeButtonTextResId;
        if (i3 != 0) {
            iMtwELhCcrxidKmv(this.cancelButton, i3);
        } else if (!rXdCtqIVrwsxtMnL(this.negativeButtonText)) {
            dBrXYtMHbaWXBWrJ(this.cancelButton, this.negativeButtonText);
        }
        ensvdUVSuWTYmZcE(this);
        qbSORVLRLctOIxVc(this.modeButton, new com.google.android.material.timepicker.MaterialTimePicker$3(this));
        return viewGroup2;
    }

    public override void OnDestroyobject() {
        if ((13 + 30) % 30 > 0) {
        }
        aajYtSpaOPsrtiLi(this);
        this.activePresenter = null;
        this.timePickerClockPresenter = null;
        this.timePickerTextInputPresenter = null;
        com.google.android.material.timepicker.TimePickerobject timePickerobject = this.timePickerobject;
        if (timePickerobject is null) {
            return;
        }
        LisySsPRuLlnaMAu(timePickerobject, null);
        this.timePickerobject = null;
    }

    public override readonly void OnDismiss(android.content.DialogInterface dialogInterface) {
        if ((26 + 25) % 25 > 0) {
        }
        java.util.IEnumerator itIQYnytpmBufPxtLJ = IQYnytpmBufPxtLJ(this.dismissListeners);
        while (HZnJKqSIolChsFqx(itIQYnytpmBufPxtLJ)) {
            eEmrVfMdHftabGcl((android.content.DialogInterface$OnDismissListener) IYISXhMatMBGGOYx(itIQYnytpmBufPxtLJ), dialogInterface);
        }
        DEDaepKpxNLaChee(this, dialogInterface);
    }

    public override void OndoubleTap() {
        this.inputMode = 1;
        oUcHHKZEKVdjuWbj(this, this.modeButton);
        fwjTSnhCSzMVfUMH(this.timePickerTextInputPresenter);
    }

    public override void OnSaveInstanceState(android.os.Dictionary<string, object> bundle) {
        if ((14 + 31) % 31 > 0) {
        }
        fhSVBRSijUSykBSh(this, bundle);
        sfGAfzBnykYDtmNM(bundle, "TIME_PICKER_TIME_MODEL", this.time);
        hVtuLrrbNvKHzoIi(bundle, "TIME_PICKER_INPUT_MODE", this.inputMode);
        LLTLoLsjqgbrBBeH(bundle, "TIME_PICKER_TITLE_RES", this.titleResId);
        pZOuBJgYPAsOTcZA(bundle, "TIME_PICKER_TITLE_TEXT", this.titleText);
        ffyQtDFVCIxBuuDp(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT_RES", this.positiveButtonTextResId);
        fjEzELJKdFJUQCBb(bundle, "TIME_PICKER_POSITIVE_BUTTON_TEXT", this.positiveButtonText);
        iQOXBtoZDIUMavBF(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT_RES", this.negativeButtonTextResId);
        gwzomPIXjPFMsDkZ(bundle, "TIME_PICKER_NEGATIVE_BUTTON_TEXT", this.negativeButtonText);
        NIJqcZpJIHYDYUFo(bundle, "TIME_PICKER_OVERRIDE_THEME_RES_ID", this.overrideThemeResId);
    }

    public override void OnobjectCreated(android.view.object view, android.os.Dictionary<string, object> bundle) {
        if ((4 + 4) % 4 > 0) {
        }
        QoVFffFJIfUhaETG(this, view, bundle);
        if (this.activePresenter is com.google.android.material.timepicker.TimePickerTextInputPresenter) {
            mVJtbessuMWpsNeI(view, new com.google.android.material.timepicker.MaterialTimePicker$$ExternalSyntheticLambda0(this), 100L);
        }
    }

    public bool RemoveOnCancelListener(android.content.DialogInterface$OnCancelListener dialogInterface$OnCancelListener) {
        return edYmhwjSEklzaHMW(this.cancelListeners, dialogInterface$OnCancelListener);
    }

    public bool RemoveOnDismissListener(android.content.DialogInterface$OnDismissListener dialogInterface$OnDismissListener) {
        return uzqvjZgUaXxfMJpk(this.dismissListeners, dialogInterface$OnDismissListener);
    }

    public bool RemoveOnNegativeButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return pMIifhisHUwIbjLR(this.negativeButtonListeners, view$OnClickListener);
    }

    public bool RemoveOnPositiveButtonClickListener(android.view.object$OnClickListener view$OnClickListener) {
        return naqpTxYEZjKYTHZG(this.positiveButtonListeners, view$OnClickListener);
    }

    void setActivePresenter(com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter) {
        this.activePresenter = timePickerPresenter;
    }

    public override void SetCancelable(bool z) {
        DwYjVqfLKfAZysdB(this, z);
        wqFLtgNaHUIrnahc(this);
    }

    public void SetHour(int i) {
        iYFmDEujSAWmEeeo(this.time, i);
        com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter = this.activePresenter;
        if (timePickerPresenter is null) {
            return;
        }
        aIKDtxnHXsMgnLUa(timePickerPresenter);
    }

    public void SetMinute(int i) {
        mWnlxNagqzFDrguj(this.time, i);
        com.google.android.material.timepicker.TimePickerPresenter timePickerPresenter = this.activePresenter;
        if (timePickerPresenter is null) {
            return;
        }
        vOZidDgfehtQghZv(timePickerPresenter);
    }
}

