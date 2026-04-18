namespace WillowMaze.Wasm.Decompiled;


public class AppCompatButton : android.widget.Button : androidx.core.view.TintableBackgroundobject, androidx.core.widget.AutoSizeableTextobject, androidx.core.widget.TintableCompoundDrawablesobject, androidx.appcompat.widget.EmojiCompatConfigurationobject {
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatButton(android.content.object context) {
        this(context, null);
    }

    public AppCompatButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.buttonStyle);
    }

    public AppCompatButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(IyQEOqpwwAPJdVgS(context), attributeHashSet, i);
        WEpuiLauwgsZhAJq(this, RubzPqXDNEWhIGpm(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        zlPlWOhczMkxRsSY(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        llZMswZorUojOrXu(appCompatTextHelper, attributeHashSet, i);
        IkTQrAiusRciWFQc(appCompatTextHelper);
        gwPmjnKNISOtGHIp(aOjWtgjmgaNsTRnv(this), attributeHashSet, i);
    }

    public static android.view.ActionMode$Callback AKMWEdNoMbmyJhVO(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static java.lang.string AWJtHXXpTBUsajWU(java.lang.Class cls) {
        return cls.getName();
    }

    public static void AwWbFZZotCFcYrqz(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static bool BKiVodREOJHgHXeQ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.isAutoSizeEnabled();
    }

    public static bool BRUGuYCrBLnaWXSi(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static android.view.ActionMode$Callback BvqCBjMuCSBAwHFz(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static void CFEQahyDFQaLvGJZ(android.widget.Button button, int i, float f) {
        super.setTextSize(i, f);
    }

    public static void DlfLHtFFTTeLDAyt(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, bool z, int i, int i2, int i3, int i4) {
        appCompatTextHelper.onLayout(z, i, i2, i3, i4);
    }

    public static android.content.res.ColorStateList EXBgmLgWKwcVEClI(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static android.graphics.PorterDuff$Mode FBtwICirkDlgEDPz(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void FFIGKrFzQqwypeDv(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static void FYhgGcDSbZNNchpe(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static void GUHIHylbomQSvbOi(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void GkTuexZCquoQfUow(android.widget.Button button, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static void HKNXDUUxbHXZAdPV(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, float f) {
        appCompatTextHelper.setTextSize(i, f);
    }

    public static int HrDwHkZCanKxewSl(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeMinTextSize();
    }

    public static int IDOBvwdnTRQAJvfU(android.widget.Button button) {
        return super.getAutoSizeMaxTextSize();
    }

    public static void IkTQrAiusRciWFQc(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper IxXrCeJFRDNHDcsB(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getEmojiTextobjectHelper();
    }

    public static android.content.object IyQEOqpwwAPJdVgS(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void LTePYcGwTwAXnIMj(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper LVJKEZFaMpmWkvhx(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getEmojiTextobjectHelper();
    }

    public static void LfzMJEKnJYhujizD(android.widget.Button button, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void MyNPEUXphRDWesuv(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, bool z) {
        appCompatTextHelper.setAllCaps(z);
    }

    public static void OkGneNjhfSFOjGHZ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void PkrNPzvMBOElMsbm(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static int QItwNGUAzttscnDh(android.widget.Button button) {
        return super.getAutoSizeStepGranularity();
    }

    public static void QfEZbvyMOSMRktbf(android.widget.Button button, int[] iArr, int i) {
        super.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static int[] QhlQxutYvHKeIAjU(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeTextAvailableSizes();
    }

    public static int RYbSriXrPgZBSAyP(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeMaxTextSize();
    }

    public static void RqXMXdOngsREFAbd(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static android.content.object RubzPqXDNEWhIGpm(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getobject();
    }

    public static void TivAJSTKeuucSrWE(android.widget.Button button, int i, int i2, int i3, int i4) {
        super.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper VlkylaILLuMkTYJV(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getEmojiTextobjectHelper();
    }

    public static void WEpuiLauwgsZhAJq(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void WKARoPZJiRgdueAI(android.widget.Button button, java.lang.CharSequence charSequence, int i, int i2, int i3) {
        super.onTextChanged(charSequence, i, i2, i3);
    }

    public static int WNngtpHCRjanASCl(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeStepGranularity();
    }

    public static void WzRZhaDMjjjgzjjz(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void XSLjnDfrjxQDLeyk(android.widget.Button button) {
        super.drawableStateChanged();
    }

    public static void YNDewFPslcvkAOyT(android.widget.Button button, int i) {
        super.setBackgroundResource(i);
    }

    public static int ZMutPSUWHXXwlxSu(android.widget.Button button) {
        return super.getAutoSizeMinTextSize();
    }

    public static int ZmCbISGszcAdSfdS(android.widget.Button button) {
        return super.getAutoSizeTextType();
    }

    public static void ABTmtTCWdvaGpBub(android.widget.Button button, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static int[] AFERBZkzdimKfnaE(android.widget.Button button) {
        return super.getAutoSizeTextAvailableSizes();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper AOjWtgjmgaNsTRnv(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getEmojiTextobjectHelper();
    }

    public static void CeUenLeercDhoAia(android.widget.Button button, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static android.graphics.PorterDuff$Mode dTrUXYcWxLNmUSri(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper EMBiDcrGSTnveVHD(androidx.appcompat.widget.AppCompatButton appCompatButton) {
        return appCompatButton.getEmojiTextobjectHelper();
    }

    public static void EWihbmolpXenSzgt(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, int i2, int i3, int i4) {
        appCompatTextHelper.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static android.view.ActionMode$Callback etEmvxvKOaoFkQiM(android.widget.Button button) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static void FuQuOUrgqEomkQHN(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.autoSizeText();
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    public static void GwPmjnKNISOtGHIp(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void HITMPWcXIBQtVXpY(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void HPojOOvLMDIbQNIT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int[] iArr, int i) {
        appCompatTextHelper.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static void KSWrlItPDBGwUGQH(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i) {
        appCompatTextHelper.setAutoSizeTextTypeWithDefaults(i);
    }

    public static void LGZEjfONiGhdUJXc(android.widget.Button button, bool z) {
        super.setAllCaps(z);
    }

    public static void LlZMswZorUojOrXu(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void OLNLtjFukgvCRYIn(android.widget.Button button, int i) {
        super.setAutoSizeTextTypeWithDefaults(i);
    }

    public static android.text.InputFilter[] PQtdkcETVSQwLDQV(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static void PotnRdbnJmsDNrYu(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void RXwMMAGBymJesfuZ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void SrVyrMXPIufECTtr(android.widget.Button button, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void TFIcsfoHebpuKvWn(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static java.lang.string TzuAQgyQMQSFmNgk(java.lang.Class cls) {
        return cls.getName();
    }

    public static void UBysIdVFQQlukSKi(android.widget.Button button, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static android.content.res.ColorStateList XSRAMkIGpeqNsJpa(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void XejBJRIDoDutwYPU(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static void YnAkbvBKiWUMInfk(android.widget.Button button, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static int YyFjQLaqIDEtRvjH(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeTextType();
    }

    public static void ZfAuUZOcQFsPPegH(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static void ZlPlWOhczMkxRsSY(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    protected override void DrawableStateChanged() {
        XSLjnDfrjxQDLeyk(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            hITMPWcXIBQtVXpY(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        RqXMXdOngsREFAbd(appCompatTextHelper);
    }

    public override int GetAutoSizeMaxTextSize() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return IDOBvwdnTRQAJvfU(this);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return RYbSriXrPgZBSAyP(appCompatTextHelper);
    }

    public override int GetAutoSizeMinTextSize() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return ZMutPSUWHXXwlxSu(this);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return HrDwHkZCanKxewSl(appCompatTextHelper);
    }

    public override int GetAutoSizeStepGranularity() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return QItwNGUAzttscnDh(this);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return WNngtpHCRjanASCl(appCompatTextHelper);
    }

    public override int[] GetAutoSizeTextAvailableSizes() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return aFERBZkzdimKfnaE(this);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        return appCompatTextHelper is null ? new int[0] : QhlQxutYvHKeIAjU(appCompatTextHelper);
    }

    public override int GetAutoSizeTextType() {
        if ((5 + 21) % 21 > 0) {
        }
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return ZmCbISGszcAdSfdS(this) != 1 ? 0 : 1;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return 0;
        }
        return yyFjQLaqIDEtRvjH(appCompatTextHelper);
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return AKMWEdNoMbmyJhVO(etEmvxvKOaoFkQiM(this));
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return EXBgmLgWKwcVEClI(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return dTrUXYcWxLNmUSri(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return xSRAMkIGpeqNsJpa(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return FBtwICirkDlgEDPz(this.mTextHelper);
    }

    public override bool IsEmojiCompatEnabled() {
        return BRUGuYCrBLnaWXSi(eMBiDcrGSTnveVHD(this));
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        ceUenLeercDhoAia(this, accessibilityEvent);
        AwWbFZZotCFcYrqz(accessibilityEvent, tzuAQgyQMQSFmNgk(android.widget.Button.class));
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        ynAkbvBKiWUMInfk(this, accessibilityNodeInfo);
        FYhgGcDSbZNNchpe(accessibilityNodeInfo, AWJtHXXpTBUsajWU(android.widget.Button.class));
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        srVyrMXPIufECTtr(this, z, i, i2, i3, i4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        DlfLHtFFTTeLDAyt(appCompatTextHelper, z, i, i2, i3, i4);
    }

    protected override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        WKARoPZJiRgdueAI(this, charSequence, i, i2, i3);
        if (this.mTextHelper is null || androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE || !BKiVodREOJHgHXeQ(this.mTextHelper)) {
            return;
        }
        fuQuOUrgqEomkQHN(this.mTextHelper);
    }

    public override void SetAllCaps(bool z) {
        lGZEjfONiGhdUJXc(this, z);
        tFIcsfoHebpuKvWn(LVJKEZFaMpmWkvhx(this), z);
    }

    public override void SetAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            TivAJSTKeuucSrWE(this, i, i2, i3, i4);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        eWihbmolpXenSzgt(appCompatTextHelper, i, i2, i3, i4);
    }

    public override void SetAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i) throws java.lang.IllegalArgumentException {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            QfEZbvyMOSMRktbf(this, iArr, i);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        hPojOOvLMDIbQNIT(appCompatTextHelper, iArr, i);
    }

    public override void SetAutoSizeTextTypeWithDefaults(int i) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            oLNLtjFukgvCRYIn(this, i);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        kSWrlItPDBGwUGQH(appCompatTextHelper, i);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        LfzMJEKnJYhujizD(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        WzRZhaDMjjjgzjjz(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        YNDewFPslcvkAOyT(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        GUHIHylbomQSvbOi(appCompatBackgroundHelper, i);
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        aBTmtTCWdvaGpBub(this, BvqCBjMuCSBAwHFz(this, actionMode$Callback));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        FFIGKrFzQqwypeDv(VlkylaILLuMkTYJV(this), z);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        GkTuexZCquoQfUow(this, pQtdkcETVSQwLDQV(IxXrCeJFRDNHDcsB(this), inputFilterArr));
    }

    public void SetSupportAllCaps(bool z) {
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        MyNPEUXphRDWesuv(appCompatTextHelper, z);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        potnRdbnJmsDNrYu(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        PkrNPzvMBOElMsbm(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        xejBJRIDoDutwYPU(this.mTextHelper, colorStateList);
        rXwMMAGBymJesfuZ(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        zfAuUZOcQFsPPegH(this.mTextHelper, porterDuff$Mode);
        OkGneNjhfSFOjGHZ(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        uBysIdVFQQlukSKi(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        LTePYcGwTwAXnIMj(appCompatTextHelper, context, i);
    }

    public override void SetTextSize(int i, float f) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            CFEQahyDFQaLvGJZ(this, i, f);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        HKNXDUUxbHXZAdPV(appCompatTextHelper, i, f);
    }
}

