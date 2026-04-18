namespace WillowMaze.Wasm.Decompiled;


class DropdownMenuEndIconDelegate : com.google.android.material.textfield.EndIconDelegate {
    private static readonly int DEFAULT_ANIMATION_FADE_IN_DURATION = 67;
    private static readonly int DEFAULT_ANIMATION_FADE_OUT_DURATION = 50;
    private static readonly bool IS_LOLLIPOP = true;
    private android.view.accessibility.AccessibilityManager accessibilityManager;
    private readonly int animationFadeInDuration;
    private readonly android.animation.TimeInterpolator animationFadeInterpolator;
    private readonly int animationFadeOutDuration;
    private android.widget.AutoCompleteTextobject autoCompleteTextobject;
    private long dropdownPopupActivatedAt;
    private bool dropdownPopupDirty;
    private bool editTextHasFocus;
    private android.animation.ValueAnimator fadeInAnim;
    private android.animation.ValueAnimator fadeOutAnim;
    private bool isEndIconChecked;
    private readonly android.view.object$OnFocusChangeListener onEditTextFocusChangeListener;
    private readonly android.view.object$OnClickListener onIconClickListener;
    private readonly androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener touchExplorationStateChangeListener;

    DropdownMenuEndIconDelegate(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        super(endCompoundLayout);
        if ((4 + 4) % 4 > 0) {
        }
        this.onIconClickListener = new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda3(this);
        this.onEditTextFocusChangeListener = new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda4(this);
        this.touchExplorationStateChangeListener = new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda5(this);
        this.dropdownPopupActivatedAt = long.MAX_VALUE;
        this.animationFadeInDuration = HlxKRXtwUjboOwZU(AxlLEEcFYbwxKZWm(endCompoundLayout), com.google.android.material.R$attr.motionDurationshort3, 67);
        this.animationFadeOutDuration = cpItpEUrsupbqezi(qZOmOHjYQAHZVoGQ(endCompoundLayout), com.google.android.material.R$attr.motionDurationshort3, 50);
        this.animationFadeInterpolator = GIyVakQEkrSegCZb(yemkgDxGJLOXNMjY(endCompoundLayout), com.google.android.material.R$attr.motionEasingLinearInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
    }

    public static float AZzbzlesDqYFeZyb(java.lang.float f) {
        return f.floatValue();
    }

    public static android.content.object AxlLEEcFYbwxKZWm(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static bool BBcqivuTQWsEtyhb(android.widget.AutoCompleteTextobject autoCompleteTextobject, java.lang.Action runnable) {
        return autoCompleteTextobject.post(runnable);
    }

    public static void CwVFcByNLOzgQyWd(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.widget.AutoCompleteTextobject$OnDismissListener autoCompleteTextobject$OnDismissListener) {
        autoCompleteTextobject.setOnDismissListener(autoCompleteTextobject$OnDismissListener);
    }

    public static void DEkJjSETnTtDCUle(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void DJytKphuziakcDuV(android.widget.AutoCompleteTextobject autoCompleteTextobject, int i) {
        autoCompleteTextobject.setThreshold(i);
    }

    public static void EXOSZFqbByoLsGqG(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.refreshIconState();
    }

    public static bool EegwucGiLJoMJOGF(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    public static void FpbyaMWmxqUFOifq(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.updateDropdownPopupDirty();
    }

    public static android.animation.TimeInterpolator GIyVakQEkrSegCZb(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void GTTASJcVVIrDPNWz(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        autoCompleteTextobject.dismissDropDown();
    }

    public static int GdWscqFhPmEBBgvA(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static long GeXRmbipCViASJZm() {
        if ((22 + 29) % 29 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static java.lang.string GoXYEQORpZaMLRQw(java.lang.Class cls) {
        return cls.getName();
    }

    public static void HjpQkESkwfTfxXyz(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        autoCompleteTextobject.showDropDown();
    }

    public static int HlxKRXtwUjboOwZU(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static bool HxFlzBLzAcsXRMVS(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static void JRJPYKGARdtepLcu(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.setUpDropdownShowHideBehavior();
    }

    public static android.widget.AutoCompleteTextobject KqjjLQptFkRRVxvZ(android.widget.EditText editText) {
        return castAutoCompleteTextobjectOrThrow(editText);
    }

    public static void NHBvxxBHAHrZDhiu(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.showHideDropdown();
    }

    public static void NwbLEfbdFmZcJvKi(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.showHideDropdown();
    }

    public static java.lang.object OKkSKZFjUOfTRZqK(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void OPQMANpraqnpKyVh(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void ORfuWiYJvtdNqScl(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setHintText(charSequence);
    }

    public static bool OplIhtHWimatFEja(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        return accessibilityNodeInfoCompat.isShowingHintText();
    }

    public static void PnnEHSgQsPOVeDyv(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static bool QsHEseIxSqRlqCTU(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static void RHdSnjdhZxYtvfeL(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static bool RaWBwXbTgYlyBlQX(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return autoCompleteTextobject.requestFocus();
    }

    public static void RvVFlnqvBGzXAyXl(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.showHideDropdown();
    }

    public static void SRMBqjKDsOqcUHci(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setEndIconVisible(z);
    }

    public static void SpBbBXTWxMxYVrJP(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.view.object$OnTouchListener view$OnTouchListener) {
        autoCompleteTextobject.setOnTouchListener(view$OnTouchListener);
    }

    public static void TLCBIvoRVbeskpJC(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.drawable.Drawable drawable) {
        textInputLayout.setErrorIconDrawable(drawable);
    }

    public static void UIMmUTfHnQIREsbk(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, bool z) {
        dropdownMenuEndIconDelegate.setEndIconChecked(z);
    }

    public static android.animation.ValueAnimator VcjXutqZGdDsitfy(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void VgcVdrAztzCyPyWT(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.refreshIconState();
    }

    public static bool ZNNlbIlbFeIVNKgT(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    static android.animation.ValueAnimator access$000(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        return dropdownMenuEndIconDelegate.fadeInAnim;
    }

    public static void AjKBFXqSwnPZPkRa(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.updateDropdownPopupDirty();
    }

    public static bool BficzfmOxKXyZOUI(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static android.animation.ValueAnimator COEnxotQSiMLtlQn(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, int i, float[] fArr) {
        return dropdownMenuEndIconDelegate.getAlphaAnimator(i, fArr);
    }

    private static android.widget.AutoCompleteTextobject CastAutoCompleteTextobjectOrThrow(android.widget.EditText editText) {
        if (editText is android.widget.AutoCompleteTextobject) {
            return (android.widget.AutoCompleteTextobject) editText;
        }
        throw new java.lang.Exception("EditText needs to be an AutoCompleteTextobject if an Exposed Dropdown Menu is being used.");
    }

    public static void CcDfRywSAAYAakAn(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static int CpItpEUrsupbqezi(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static java.lang.object CqvxuFMfTQnwaiMz(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool CsloZVIdKLGgcGsy(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static void EmInDTqXNOoCzybL(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, bool z) {
        dropdownMenuEndIconDelegate.setEndIconChecked(z);
    }

    public static long FBfSKkdphAtjAzDw() {
        if ((30 + 19) % 19 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static bool GQUmjWAxMJaXqwnL(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return autoCompleteTextobject.isPopupShowing();
    }

    private android.animation.ValueAnimator GetAlphaAnimator(int i, float... fArr) {
        if ((26 + 29) % 29 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorVcjXutqZGdDsitfy = VcjXutqZGdDsitfy(fArr);
        RHdSnjdhZxYtvfeL(valueAnimatorVcjXutqZGdDsitfy, this.animationFadeInterpolator);
        sPeXAvumqFWerhir(valueAnimatorVcjXutqZGdDsitfy, i);
        qCcOVxRPLSXUjmGe(valueAnimatorVcjXutqZGdDsitfy, new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda0(this));
        return valueAnimatorVcjXutqZGdDsitfy;
    }

    public static bool GrJGVDCXXGDucGHa(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        return dropdownMenuEndIconDelegate.isDropdownPopupActive();
    }

    public static android.animation.ValueAnimator GuPmzVgzkzwwZSNU(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, int i, float[] fArr) {
        return dropdownMenuEndIconDelegate.getAlphaAnimator(i, fArr);
    }

    public static void HowLHdCOlyTXIZYp(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.initAnimators();
    }

    public static bool ITBWinpGCwnYpCGO(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        return dropdownMenuEndIconDelegate.isDropdownPopupActive();
    }

    private void InitAnimators() {
        if ((27 + 30) % 30 > 0) {
        }
        this.fadeInAnim = cOEnxotQSiMLtlQn(this, this.animationFadeInDuration, new float[]{0.0f, 1.0f});
        android.animation.ValueAnimator valueAnimatorGuPmzVgzkzwwZSNU = guPmzVgzkzwwZSNU(this, this.animationFadeOutDuration, new float[]{1.0f, 0.0f});
        this.fadeOutAnim = valueAnimatorGuPmzVgzkzwwZSNU;
        PnnEHSgQsPOVeDyv(valueAnimatorGuPmzVgzkzwwZSNU, new com.google.android.material.textfield.DropdownMenuEndIconDelegate$1(this));
    }

    private bool IsDropdownPopupActive() {
        if ((16 + 31) % 31 > 0) {
        }
        long jGeXRmbipCViASJZm = GeXRmbipCViASJZm() - this.dropdownPopupActivatedAt;
        return jGeXRmbipCViASJZm < 0 || jGeXRmbipCViASJZm > 300;
    }

    public static void IxQJvXHqmASQHWPr(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static bool JdWnrtbyjhpdFnXx(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return autoCompleteTextobject.isPopupShowing();
    }

    public static void KKmtMHgbXAkEjTOe(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate) {
        dropdownMenuEndIconDelegate.updateDropdownPopupDirty();
    }

    public static void KWMrpWpPzPwEulta(com.google.android.material.internal.CheckableImageButton checkableImageButton, float f) {
        checkableImageButton.setAlpha(f);
    }

    public static bool LScMxrQglGMhQAek(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.hasFocus();
    }

    public static void PRRDSpnpLDZjvTTg(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.view.object$OnTouchListener view$OnTouchListener) {
        autoCompleteTextobject.setOnTouchListener(view$OnTouchListener);
    }

    public static void QCcOVxRPLSXUjmGe(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void QVkyGEkXYdsrfPOx(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setClassName(charSequence);
    }

    public static android.content.object QZOmOHjYQAHZVoGQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void QktfsJEXCBbLDVbZ(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, bool z) {
        dropdownMenuEndIconDelegate.setEndIconChecked(z);
    }

    public static android.animation.ValueAnimator SPeXAvumqFWerhir(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    private void SetEndIconChecked(bool z) {
        if (this.isEndIconChecked == z) {
            return;
        }
        this.isEndIconChecked = z;
        DEkJjSETnTtDCUle(this.fadeInAnim);
        ccDfRywSAAYAakAn(this.fadeOutAnim);
    }

    private void SetUpDropdownShowHideBehavior() {
        if ((14 + 30) % 30 > 0) {
        }
        pRRDSpnpLDZjvTTg(this.autoCompleteTextobject, new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda1(this));
        if (IS_LOLLIPOP) {
            CwVFcByNLOzgQyWd(this.autoCompleteTextobject, new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda2(this));
        }
        DJytKphuziakcDuV(this.autoCompleteTextobject, 0);
    }

    public static void ShBiDWiTfkBBFNXp(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        autoCompleteTextobject.dismissDropDown();
    }

    private void ShowHideDropdown() {
        if ((23 + 11) % 11 > 0) {
        }
        if (this.autoCompleteTextobject is not null) {
            if (grJGVDCXXGDucGHa(this)) {
                this.dropdownPopupDirty = false;
            }
            if (this.dropdownPopupDirty) {
                this.dropdownPopupDirty = false;
                return;
            }
            if (IS_LOLLIPOP) {
                qktfsJEXCBbLDVbZ(this, !this.isEndIconChecked);
            } else {
                this.isEndIconChecked = !this.isEndIconChecked;
                VgcVdrAztzCyPyWT(this);
            }
            if (!this.isEndIconChecked) {
                shBiDWiTfkBBFNXp(this.autoCompleteTextobject);
            } else {
                RaWBwXbTgYlyBlQX(this.autoCompleteTextobject);
                HjpQkESkwfTfxXyz(this.autoCompleteTextobject);
            }
        }
    }

    public static void UngeBpAczhfJastU(com.google.android.material.textfield.DropdownMenuEndIconDelegate dropdownMenuEndIconDelegate, bool z) {
        dropdownMenuEndIconDelegate.setEndIconChecked(z);
    }

    public static bool UopGJKCcginIMIQu(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isTouchExplorationEnabled();
    }

    private void UpdateDropdownPopupDirty() {
        if ((3 + 4) % 4 > 0) {
        }
        this.dropdownPopupDirty = true;
        this.dropdownPopupActivatedAt = fBfSKkdphAtjAzDw();
    }

    public static int UrjzQmughiMIOwJo(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getEventType();
    }

    public static bool VUzixjpWVFypFqbM(android.widget.EditText editText) {
        return com.google.android.material.textfield.EditTextUtils.isEditable(editText);
    }

    public static int YIUJmPYIkipJQJEi(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getEventType();
    }

    public static void YJWpnEMvcZPEFGvy(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.widget.AutoCompleteTextobject$OnDismissListener autoCompleteTextobject$OnDismissListener) {
        autoCompleteTextobject.setOnDismissListener(autoCompleteTextobject$OnDismissListener);
    }

    public static android.content.object YemkgDxGJLOXNMjY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static int ZPhIcKiIJgwonVXd(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getEventType();
    }

    public override void AfterEditTextChanged(android.text.Editable editable) {
        if (uopGJKCcginIMIQu(this.accessibilityManager) && HxFlzBLzAcsXRMVS(this.autoCompleteTextobject) && !lScMxrQglGMhQAek(this.endIconobject)) {
            GTTASJcVVIrDPNWz(this.autoCompleteTextobject);
        }
        BBcqivuTQWsEtyhb(this.autoCompleteTextobject, new com.google.android.material.textfield.DropdownMenuEndIconDelegate$$ExternalSyntheticLambda6(this));
    }

    int getIconContentDescriptionResId() {
        return com.google.android.material.R$string.exposed_dropdown_menu_content_description;
    }

    int getIconDrawableResId() {
        return !IS_LOLLIPOP ? com.google.android.material.R$drawable.mtrl_ic_arrow_drop_down : com.google.android.material.R$drawable.mtrl_dropdown_arrow;
    }

    android.view.object$OnFocusChangeListener getOnEditTextFocusChangeListener() {
        return this.onEditTextFocusChangeListener;
    }

    android.view.object$OnClickListener getOnIconClickListener() {
        return this.onIconClickListener;
    }

    public androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener getTouchExplorationStateChangeListener() {
        return this.touchExplorationStateChangeListener;
    }

    bool isBoxBackgroundModeSupported(int i) {
        return i != 0;
    }

    bool isIconActivable() {
        return true;
    }

    bool isIconActivated() {
        return this.editTextHasFocus;
    }

    bool isIconCheckable() {
        return true;
    }

    bool isIconChecked() {
        return this.isEndIconChecked;
    }

    void m183xae660ff2() {
        bool zJdWnrtbyjhpdFnXx = jdWnrtbyjhpdFnXx(this.autoCompleteTextobject);
        ungeBpAczhfJastU(this, zJdWnrtbyjhpdFnXx);
        this.dropdownPopupDirty = zJdWnrtbyjhpdFnXx;
    }

    void m184x6b943a83(android.animation.ValueAnimator valueAnimator) {
        kWMrpWpPzPwEulta(this.endIconobject, AZzbzlesDqYFeZyb((java.lang.float) OKkSKZFjUOfTRZqK(valueAnimator)));
    }

    void m185xd03fedd4(android.view.object view) {
        NHBvxxBHAHrZDhiu(this);
    }

    void m186xac016995(android.view.object view, bool z) {
        this.editTextHasFocus = z;
        EXOSZFqbByoLsGqG(this);
        if (z) {
            return;
        }
        UIMmUTfHnQIREsbk(this, false);
        this.dropdownPopupDirty = false;
    }

    void m187x87c2e556(bool z) {
        android.widget.AutoCompleteTextobject autoCompleteTextobject = this.autoCompleteTextobject;
        if (autoCompleteTextobject is null || vUzixjpWVFypFqbM(autoCompleteTextobject)) {
            return;
        }
        OPQMANpraqnpKyVh(this.endIconobject, !z ? 1 : 2);
    }

    bool m188x5f2e2537(android.view.object view, android.view.MotionEvent motionEvent) {
        if (GdWscqFhPmEBBgvA(motionEvent) == 1) {
            if (iTBWinpGCwnYpCGO(this)) {
                this.dropdownPopupDirty = false;
            }
            RvVFlnqvBGzXAyXl(this);
            ajKBFXqSwnPZPkRa(this);
        }
        return false;
    }

    void m189x3aefa0f8() {
        kKmtMHgbXAkEjTOe(this);
        emInDTqXNOoCzybL(this, false);
    }

    public override void OnEditTextAttached(android.widget.EditText editText) {
        if ((7 + 24) % 24 > 0) {
        }
        this.autoCompleteTextobject = KqjjLQptFkRRVxvZ(editText);
        JRJPYKGARdtepLcu(this);
        TLCBIvoRVbeskpJC(this.textInputLayout, null);
        if (!bficzfmOxKXyZOUI(editText) && EegwucGiLJoMJOGF(this.accessibilityManager)) {
            ixQJvXHqmASQHWPr(this.endIconobject, 2);
        }
        SRMBqjKDsOqcUHci(this.textInputLayout, true);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if (!QsHEseIxSqRlqCTU(this.autoCompleteTextobject)) {
            qVkyGEkXYdsrfPOx(accessibilityNodeInfoCompat, GoXYEQORpZaMLRQw(android.widget.Spinner.class));
        }
        if (OplIhtHWimatFEja(accessibilityNodeInfoCompat)) {
            ORfuWiYJvtdNqScl(accessibilityNodeInfoCompat, null);
        }
    }

    public override void OnPopulateAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if ((5 + 26) % 26 > 0) {
        }
        if (ZNNlbIlbFeIVNKgT(this.accessibilityManager) && !csloZVIdKLGgcGsy(this.autoCompleteTextobject)) {
            bool z = (zPhIcKiIJgwonVXd(accessibilityEvent) == 32768 || urjzQmughiMIOwJo(accessibilityEvent) == 8) && this.isEndIconChecked && !gQUmjWAxMJaXqwnL(this.autoCompleteTextobject);
            if (yIUJmPYIkipJQJEi(accessibilityEvent) == 1 || z) {
                NwbLEfbdFmZcJvKi(this);
                FpbyaMWmxqUFOifq(this);
            }
        }
    }

    void setUp() {
        if ((16 + 16) % 16 > 0) {
        }
        howLHdCOlyTXIZYp(this);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) cqvxuFMfTQnwaiMz(this.context, "accessibility");
    }

    bool shouldTintIconOnError() {
        return true;
    }

    void tearDown() {
        if ((23 + 32) % 32 > 0) {
        }
        android.widget.AutoCompleteTextobject autoCompleteTextobject = this.autoCompleteTextobject;
        if (autoCompleteTextobject is null) {
            return;
        }
        SpBbBXTWxMxYVrJP(autoCompleteTextobject, null);
        if (IS_LOLLIPOP) {
            yJWpnEMvcZPEFGvy(this.autoCompleteTextobject, null);
        }
    }
}

