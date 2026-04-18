namespace WillowMaze.Wasm.Decompiled;


public class MaterialCheckBox : androidx.appcompat.widget.AppCompatCheckBox {
    private static readonly int[][] CHECKBOX_STATES;
    private static readonly int DEF_STYLE_RES;
    private static readonly int[] ERROR_STATE_SET;
    private static readonly int FRAMEWORK_BUTTON_DRAWABLE_RES_ID;
    private static readonly int[] INDETERMINATE_STATE_SET;
    public static readonly int STATE_CHECKED = 1;
    public static readonly int STATE_INDETERMINATE = 2;
    public static readonly int STATE_UNCHECKED = 0;
    private bool broadcasting;
    private android.graphics.drawable.Drawable buttonDrawable;
    private android.graphics.drawable.Drawable buttonIconDrawable;
    android.content.res.ColorStateList buttonIconTintList;
    private android.graphics.PorterDuff$Mode buttonIconTintMode;
    android.content.res.ColorStateList buttonTintList;
    private bool centerIfNoTextEnabled;
    private int checkedState;
    private int[] currentStateChecked;
    private java.lang.CharSequence customStateDescription;
    private java.lang.CharSequence errorAccessibilityLabel;
    private bool errorShown;
    private android.content.res.ColorStateList materialThemeColorsTintList;
    private android.widget.CompoundButton$OnCheckedChangeListener onCheckedChangeListener;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener> onCheckedStateChangedListeners;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener> onErrorChangedListeners;
    private readonly androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat transitionToUnchecked;
    private readonly androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback transitionToUncheckedCallback;
    private bool useMaterialThemeColors;
    private bool usingMaterialButtonDrawable;

    static {
        if ((22 + 12) % 12 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_CompoundButton_CheckBox;
        INDETERMINATE_STATE_SET = new int[]{com.google.android.material.R$attr.state_indeterminate};
        ERROR_STATE_SET = new int[]{com.google.android.material.R$attr.state_error};
        CHECKBOX_STATES = new int[][]{new int[]{16842910, com.google.android.material.R$attr.state_error}, new int[]{16842910, 16842912}, new int[]{16842910, -16842912}, new int[]{-16842910, 16842912}, new int[]{-16842910, -16842912}};
        FRAMEWORK_BUTTON_DRAWABLE_RES_ID = sXmAQjLtUPgnCZXZ(eZSZjJJmtygablRG(), "btn_check_material_anim", "drawable", "android");
    }

    public MaterialCheckBox(android.content.object context) {
        this(context, null);
    }

    public MaterialCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.checkboxStyle);
    }

    public MaterialCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((25 + 30) % 30 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(KPdIDCDnNVnrzGXW(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.onErrorChangedListeners = new java.util.LinkedHashHashSet<>();
        this.onCheckedStateChangedListeners = new java.util.LinkedHashHashSet<>();
        this.transitionToUnchecked = TycpflFJQxmjcqOT(UyUQdZBMseHClPyM(this), com.google.android.material.R$drawable.mtrl_checkbox_button_checked_unchecked);
        this.transitionToUncheckedCallback = new com.google.android.material.checkbox.MaterialCheckBox$1(this);
        android.content.object contextHuRAagQHBycvRuoW = HuRAagQHBycvRuoW(this);
        this.buttonDrawable = pJHmnitSyvXjNDXb(this);
        this.buttonTintList = hkltgvXTCdHrsINg(this);
        KSSGHtiIwEpQEuBu(this, null);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayRZeqkohnSELmtmdh = rZeqkohnSELmtmdh(contextHuRAagQHBycvRuoW, attributeHashSet, com.google.android.material.R$styleable.MaterialCheckBox, i, i2, new int[0]);
        this.buttonIconDrawable = WbgQdRscxCufNjaw(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_buttonIcon);
        if (this.buttonDrawable is not null && jBrSxZdPJXtcOnPO(contextHuRAagQHBycvRuoW) && RlImDdYwqHvTylQt(this, tintTypedArrayRZeqkohnSELmtmdh)) {
            uuDPyHWPcDsIvTYu(this, null);
            this.buttonDrawable = xnceGYAkJVnaqLnL(contextHuRAagQHBycvRuoW, com.google.android.material.R$drawable.mtrl_checkbox_button);
            this.usingMaterialButtonDrawable = true;
            if (this.buttonIconDrawable is null) {
                this.buttonIconDrawable = bdMUPcDSmLYxhMVE(contextHuRAagQHBycvRuoW, com.google.android.material.R$drawable.mtrl_checkbox_button_icon);
            }
        }
        this.buttonIconTintList = ZGCywrqlDqjXsBEZ(contextHuRAagQHBycvRuoW, tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_buttonIconTint);
        this.buttonIconTintMode = TeRQSnCMCBLHbbJM(fjrHEPGFXGPUyMTx(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_buttonIconTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        this.useMaterialThemeColors = vKfXtpnXXtoZOwMY(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_useMaterialThemeColors, false);
        this.centerIfNoTextEnabled = TcfbjwqrtzfaqVYd(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_centerIfNoTextEnabled, true);
        this.errorShown = eiZEvpSIhcQjpcEA(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_errorShown, false);
        this.errorAccessibilityLabel = pYnlrMPADBNsGIwo(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_errorAccessibilityLabel);
        if (htfSiOSmlqyGNylC(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_checkedState)) {
            qLCMlfHHNXSbuwbk(this, UCJBQvdwOtybBoKa(tintTypedArrayRZeqkohnSELmtmdh, com.google.android.material.R$styleable.MaterialCheckBox_checkedState, 0));
        }
        XJIxgttLXWHOQqgn(tintTypedArrayRZeqkohnSELmtmdh);
        HHVXrvguJPVYsdZN(this);
    }

    public static android.content.object ABnYvQQCxJJLIsEk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getobject();
    }

    public static void ABnYvQQCxJJLIsEk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABnYvQQCxJJLIsEk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ABnYvQQCxJJLIsEk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence AigxkuOatMNcIgct(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void AigxkuOatMNcIgct(android.content.res.Resources resources, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AigxkuOatMNcIgct(android.content.res.Resources resources, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AigxkuOatMNcIgct(android.content.res.Resources resources, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNvwjOFoIKUAJTTb(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BNvwjOFoIKUAJTTb(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNvwjOFoIKUAJTTb(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BNvwjOFoIKUAJTTb(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static void BbIFMXUMMdeCgjld(android.view.autofill.AutofillManager autofillManager, android.view.object view) {
        autofillManager.notifyValueChanged(view);
    }

    public static void BbIFMXUMMdeCgjld(android.view.autofill.AutofillManager autofillManager, android.view.object view, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BbIFMXUMMdeCgjld(android.view.autofill.AutofillManager autofillManager, android.view.object view, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbIFMXUMMdeCgjld(android.view.autofill.AutofillManager autofillManager, android.view.object view, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CAiuCWMshWzzJCtx(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.setDefaultStateDescription();
    }

    public static void CAiuCWMshWzzJCtx(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CAiuCWMshWzzJCtx(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAiuCWMshWzzJCtx(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnznUvixTgnYzHNc(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.CharSequence charSequence) {
        materialCheckBox.setErrorAccessibilityLabel(charSequence);
    }

    public static void CnznUvixTgnYzHNc(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.CharSequence charSequence, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CnznUvixTgnYzHNc(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.CharSequence charSequence, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CnznUvixTgnYzHNc(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.CharSequence charSequence, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGdpiQDxngNzxoKe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void DGdpiQDxngNzxoKe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DGdpiQDxngNzxoKe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DGdpiQDxngNzxoKe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EBxVYXSSoMpvazLP(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EBxVYXSSoMpvazLP(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EBxVYXSSoMpvazLP(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool EBxVYXSSoMpvazLP(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        return animatedVectorDrawableCompat.unregisterAnimationCallback(animatable2Compat$AnimationCallback);
    }

    public static android.graphics.Rect EWJrKAPoYygWotoZ(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void EWJrKAPoYygWotoZ(android.graphics.drawable.Drawable drawable, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EWJrKAPoYygWotoZ(android.graphics.drawable.Drawable drawable, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EWJrKAPoYygWotoZ(android.graphics.drawable.Drawable drawable, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXENRknGJZNjRXJo(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.setUpDefaultButtonDrawableAnimationIfNeeded();
    }

    public static void EXENRknGJZNjRXJo(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXENRknGJZNjRXJo(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EXENRknGJZNjRXJo(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ErLxFCojaaDkyZjU(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ErLxFCojaaDkyZjU(java.util.IEnumerator it, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ErLxFCojaaDkyZjU(java.util.IEnumerator it, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErLxFCojaaDkyZjU(java.util.IEnumerator it, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYFwXIYKYSEEJvau(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static void FYFwXIYKYSEEJvau(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FYFwXIYKYSEEJvau(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYFwXIYKYSEEJvau(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GBgNwhmGOrdcWCZh(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getText();
    }

    public static void GBgNwhmGOrdcWCZh(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GBgNwhmGOrdcWCZh(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GBgNwhmGOrdcWCZh(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GlwBfKvyKeyJZnHQ(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void GlwBfKvyKeyJZnHQ(int i, int i2, float f, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlwBfKvyKeyJZnHQ(int i, int i2, float f, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GlwBfKvyKeyJZnHQ(int i, int i2, float f, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmXMZYFLAwvRwZax(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z) {
        animatedStateListDrawable.addTransition(i, i2, drawable, z);
    }

    public static void GmXMZYFLAwvRwZax(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GmXMZYFLAwvRwZax(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GmXMZYFLAwvRwZax(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GyWRNtrGPjuAHeUn(java.lang.CharSequence charSequence, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GyWRNtrGPjuAHeUn(java.lang.CharSequence charSequence, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GyWRNtrGPjuAHeUn(java.lang.CharSequence charSequence, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GyWRNtrGPjuAHeUn(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void HHVXrvguJPVYsdZN(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void HHVXrvguJPVYsdZN(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HHVXrvguJPVYsdZN(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HHVXrvguJPVYsdZN(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HdCJeNZYwnekANDJ(int[] iArr, int[] iArr2, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdCJeNZYwnekANDJ(int[] iArr, int[] iArr2, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdCJeNZYwnekANDJ(int[] iArr, int[] iArr2, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] HdCJeNZYwnekANDJ(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static android.content.object HuRAagQHBycvRuoW(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getobject();
    }

    public static void HuRAagQHBycvRuoW(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HuRAagQHBycvRuoW(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HuRAagQHBycvRuoW(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HychCUDpQEyfGUQh(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void HychCUDpQEyfGUQh(int i, int i2, float f, float f2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HychCUDpQEyfGUQh(int i, int i2, float f, java.lang.string str, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void HychCUDpQEyfGUQh(int i, int i2, float f, bool z, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JBVSfpWMpeXNHWOr(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void JBVSfpWMpeXNHWOr(android.graphics.Canvas canvas, float f, float f2, float f3, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBVSfpWMpeXNHWOr(android.graphics.Canvas canvas, float f, float f2, float f3, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBVSfpWMpeXNHWOr(android.graphics.Canvas canvas, float f, float f2, int i, char c, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JeEawezPcjCCahnh(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i) {
        materialCheckBox$OnCheckedStateChangedListener.onCheckedStateChangedListener(materialCheckBox, i);
    }

    public static void JeEawezPcjCCahnh(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JeEawezPcjCCahnh(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JeEawezPcjCCahnh(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, bool z, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JlJzkloshqtUDVsU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void JlJzkloshqtUDVsU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JlJzkloshqtUDVsU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JlJzkloshqtUDVsU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JwJVSJBCFDJdouow(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static void JwJVSJBCFDJdouow(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JwJVSJBCFDJdouow(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JwJVSJBCFDJdouow(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JzPClLbFIFgDCHrL(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat.getButtonDrawable(compoundButton);
    }

    public static void JzPClLbFIFgDCHrL(android.widget.CompoundButton compoundButton, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JzPClLbFIFgDCHrL(android.widget.CompoundButton compoundButton, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzPClLbFIFgDCHrL(android.widget.CompoundButton compoundButton, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KPdIDCDnNVnrzGXW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void KPdIDCDnNVnrzGXW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KPdIDCDnNVnrzGXW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KPdIDCDnNVnrzGXW(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KSSGHtiIwEpQEuBu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.content.res.ColorStateList colorStateList) {
        tintableCompoundButton.setSupportButtonTintList(colorStateList);
    }

    public static void KSSGHtiIwEpQEuBu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.content.res.ColorStateList colorStateList, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSSGHtiIwEpQEuBu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.content.res.ColorStateList colorStateList, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KSSGHtiIwEpQEuBu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.content.res.ColorStateList colorStateList, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KUBKsFNgtfjmwSIS(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void KUBKsFNgtfjmwSIS(android.content.res.Resources resources, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KUBKsFNgtfjmwSIS(android.content.res.Resources resources, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KUBKsFNgtfjmwSIS(android.content.res.Resources resources, int i, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LILlcqqROfZLsEzR(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.updateButtonTints();
    }

    public static void LILlcqqROfZLsEzR(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LILlcqqROfZLsEzR(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LILlcqqROfZLsEzR(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LMKyWkIQtbXpcAxT(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void LMKyWkIQtbXpcAxT(android.content.res.Resources resources, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LMKyWkIQtbXpcAxT(android.content.res.Resources resources, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LMKyWkIQtbXpcAxT(android.content.res.Resources resources, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LOCvJzAhJCAhAkFJ(java.util.IEnumerator it, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LOCvJzAhJCAhAkFJ(java.util.IEnumerator it, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LOCvJzAhJCAhAkFJ(java.util.IEnumerator it, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LOCvJzAhJCAhAkFJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LxkhyDpNuEbfTeBb(int[] iArr, int[] iArr2, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LxkhyDpNuEbfTeBb(int[] iArr, int[] iArr2, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LxkhyDpNuEbfTeBb(int[] iArr, int[] iArr2, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int[] LxkhyDpNuEbfTeBb(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static android.graphics.drawable.Drawable MMifwIMAeZibibPX(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void MMifwIMAeZibibPX(android.content.object context, int i, char c, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MMifwIMAeZibibPX(android.content.object context, int i, java.lang.string str, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MMifwIMAeZibibPX(android.content.object context, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MesAzMaxfxLdEyUX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableMutatedDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void MesAzMaxfxLdEyUX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MesAzMaxfxLdEyUX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MesAzMaxfxLdEyUX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MjvDiNCUTitZlkvB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getobject();
    }

    public static void MjvDiNCUTitZlkvB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MjvDiNCUTitZlkvB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MjvDiNCUTitZlkvB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGpODKydeOqTJjgM(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void NGpODKydeOqTJjgM(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NGpODKydeOqTJjgM(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NGpODKydeOqTJjgM(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NJuhibzLOFXxpUoI(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void NJuhibzLOFXxpUoI(android.graphics.Canvas canvas, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NJuhibzLOFXxpUoI(android.graphics.Canvas canvas, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJuhibzLOFXxpUoI(android.graphics.Canvas canvas, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable NmYVmUMEnyOQQIVf(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getBackground();
    }

    public static void NmYVmUMEnyOQQIVf(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NmYVmUMEnyOQQIVf(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NmYVmUMEnyOQQIVf(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NpPufjVoDOTVnwtI(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NpPufjVoDOTVnwtI(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NpPufjVoDOTVnwtI(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NpPufjVoDOTVnwtI(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static void NzRDLfUuhgKpTqtB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NzRDLfUuhgKpTqtB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NzRDLfUuhgKpTqtB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NzRDLfUuhgKpTqtB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.isErrorShown();
    }

    public static void OOEeIoyCSWzsewcQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        super.onAttachedToWindow();
    }

    public static void OOEeIoyCSWzsewcQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOEeIoyCSWzsewcQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOEeIoyCSWzsewcQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OeKQcTkxfgFxHcvp(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void OeKQcTkxfgFxHcvp(int i, int i2, float f, float f2, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OeKQcTkxfgFxHcvp(int i, int i2, float f, short s, int i3, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OeKQcTkxfgFxHcvp(int i, int i2, float f, bool z, float f2, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int PXpqmlwXWNLUaPqc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void PXpqmlwXWNLUaPqc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, int i3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PXpqmlwXWNLUaPqc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PXpqmlwXWNLUaPqc(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QApwUWaytVyWfsIw(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence) {
        super.setStateDescription(charSequence);
    }

    public static void QApwUWaytVyWfsIw(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QApwUWaytVyWfsIw(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QApwUWaytVyWfsIw(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QKLMgUqRyWYjkXcf(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QKLMgUqRyWYjkXcf(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QKLMgUqRyWYjkXcf(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QKLMgUqRyWYjkXcf(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static java.lang.string QmshHwoocTKruCSt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getButtonStateDescription();
    }

    public static void QmshHwoocTKruCSt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QmshHwoocTKruCSt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QmshHwoocTKruCSt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RlImDdYwqHvTylQt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, androidx.appcompat.widget.TintTypedArray tintTypedArray, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlImDdYwqHvTylQt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlImDdYwqHvTylQt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RlImDdYwqHvTylQt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return materialCheckBox.isButtonDrawableLegacy(tintTypedArray);
    }

    public static void SlQvALabGplTeVya(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void SlQvALabGplTeVya(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SlQvALabGplTeVya(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SlQvALabGplTeVya(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.os.Parcelable parcelable, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SoaDIiHUzLsxIZDY(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void SoaDIiHUzLsxIZDY(int i, int i2, float f, float f2, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SoaDIiHUzLsxIZDY(int i, int i2, float f, int i3, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SoaDIiHUzLsxIZDY(int i, int i2, float f, int i3, char c, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList StpPeBCUDMoxsZcc(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return super.getButtonTintList();
    }

    public static void StpPeBCUDMoxsZcc(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void StpPeBCUDMoxsZcc(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StpPeBCUDMoxsZcc(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SwpIbrwOvZGDusUp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void SwpIbrwOvZGDusUp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SwpIbrwOvZGDusUp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SwpIbrwOvZGDusUp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TcfbjwqrtzfaqVYd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TcfbjwqrtzfaqVYd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TcfbjwqrtzfaqVYd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, bool z2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TcfbjwqrtzfaqVYd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static android.graphics.PorterDuff$Mode TeRQSnCMCBLHbbJM(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void TeRQSnCMCBLHbbJM(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TeRQSnCMCBLHbbJM(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TeRQSnCMCBLHbbJM(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThLWUCBYTgkdasLA(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshDrawableState();
    }

    public static void ThLWUCBYTgkdasLA(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThLWUCBYTgkdasLA(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ThLWUCBYTgkdasLA(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator ThTmPYQcRlvOSZIt(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void ThTmPYQcRlvOSZIt(java.util.LinkedHashHashSet linkedHashHashSet, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ThTmPYQcRlvOSZIt(java.util.LinkedHashHashSet linkedHashHashSet, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ThTmPYQcRlvOSZIt(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int TyWBNyIEtwfWcXTy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getCheckedState();
    }

    public static void TyWBNyIEtwfWcXTy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TyWBNyIEtwfWcXTy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TyWBNyIEtwfWcXTy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat TycpflFJQxmjcqOT(android.content.object context, int i) {
        return androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat.create(context, i);
    }

    public static void TycpflFJQxmjcqOT(android.content.object context, int i, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TycpflFJQxmjcqOT(android.content.object context, int i, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TycpflFJQxmjcqOT(android.content.object context, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UCJBQvdwOtybBoKa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void UCJBQvdwOtybBoKa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UCJBQvdwOtybBoKa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, java.lang.string str, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UCJBQvdwOtybBoKa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object UyUQdZBMseHClPyM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getobject();
    }

    public static void UyUQdZBMseHClPyM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UyUQdZBMseHClPyM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyUQdZBMseHClPyM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VPWvmgSkZRMtIBrS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getCheckedState();
    }

    public static void VPWvmgSkZRMtIBrS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VPWvmgSkZRMtIBrS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VPWvmgSkZRMtIBrS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable WbgQdRscxCufNjaw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void WbgQdRscxCufNjaw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WbgQdRscxCufNjaw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WbgQdRscxCufNjaw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XJIxgttLXWHOQqgn(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void XJIxgttLXWHOQqgn(androidx.appcompat.widget.TintTypedArray tintTypedArray, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJIxgttLXWHOQqgn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJIxgttLXWHOQqgn(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XOqtBlPpWIuDOdzz(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z) {
        animatedStateListDrawable.addTransition(i, i2, drawable, z);
    }

    public static void XOqtBlPpWIuDOdzz(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XOqtBlPpWIuDOdzz(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XOqtBlPpWIuDOdzz(android.graphics.drawable.AnimatedStateListDrawable animatedStateListDrawable, int i, int i2, android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable XTdcznEtWSVzHUAP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return super.onSaveInstanceState();
    }

    public static void XTdcznEtWSVzHUAP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XTdcznEtWSVzHUAP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XTdcznEtWSVzHUAP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGanwzdeMJrDPySe(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence) {
        super.setStateDescription(charSequence);
    }

    public static void YGanwzdeMJrDPySe(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YGanwzdeMJrDPySe(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YGanwzdeMJrDPySe(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YRBZrSKcfEioZWST(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void YRBZrSKcfEioZWST(android.view.object view, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YRBZrSKcfEioZWST(android.view.object view, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YRBZrSKcfEioZWST(android.view.object view, int i, int i2, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YgfEsMNAkkOhmIBH(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static void YgfEsMNAkkOhmIBH(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YgfEsMNAkkOhmIBH(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YgfEsMNAkkOhmIBH(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Canvas canvas, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZFkigiooyctpImCx(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void ZFkigiooyctpImCx(android.graphics.Canvas canvas, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFkigiooyctpImCx(android.graphics.Canvas canvas, int i, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZFkigiooyctpImCx(android.graphics.Canvas canvas, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZGCywrqlDqjXsBEZ(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void ZGCywrqlDqjXsBEZ(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZGCywrqlDqjXsBEZ(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGCywrqlDqjXsBEZ(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources ZVGYdWdWkURdtPnM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getResources();
    }

    public static void ZVGYdWdWkURdtPnM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZVGYdWdWkURdtPnM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZVGYdWdWkURdtPnM(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZYjnhQHSDyNtfsNt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void ZYjnhQHSDyNtfsNt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZYjnhQHSDyNtfsNt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZYjnhQHSDyNtfsNt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZhYrMyQASBEpkjmy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getWidth();
    }

    public static void ZhYrMyQASBEpkjmy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhYrMyQASBEpkjmy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZhYrMyQASBEpkjmy(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AHfrtZzlQBoTMWNj(android.content.object context, java.lang.Class cls) {
        return context.getSystemService(cls);
    }

    public static void AHfrtZzlQBoTMWNj(android.content.object context, java.lang.Class cls, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AHfrtZzlQBoTMWNj(android.content.object context, java.lang.Class cls, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AHfrtZzlQBoTMWNj(android.content.object context, java.lang.Class cls, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode aLzIyfJxsrtmTagL(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat.getButtonTintMode(compoundButton);
    }

    public static void ALzIyfJxsrtmTagL(android.widget.CompoundButton compoundButton, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ALzIyfJxsrtmTagL(android.widget.CompoundButton compoundButton, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ALzIyfJxsrtmTagL(android.widget.CompoundButton compoundButton, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int[] access$000(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.currentStateChecked;
    }

    public static java.lang.stringBuilder AheeLjWPNEEiFZEy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AheeLjWPNEEiFZEy(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AheeLjWPNEEiFZEy(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AheeLjWPNEEiFZEy(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BPaLnOtmYBhFQUhh(java.util.IEnumerator it, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BPaLnOtmYBhFQUhh(java.util.IEnumerator it, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPaLnOtmYBhFQUhh(java.util.IEnumerator it, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BPaLnOtmYBhFQUhh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.graphics.drawable.Drawable BdMUPcDSmLYxhMVE(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void BdMUPcDSmLYxhMVE(android.content.object context, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdMUPcDSmLYxhMVE(android.content.object context, int i, int i2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdMUPcDSmLYxhMVE(android.content.object context, int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CPtkBwyFJOrMSScE(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z) {
        compoundButton$OnCheckedChangeListener.onCheckedChanged(compoundButton, z);
    }

    public static void CPtkBwyFJOrMSScE(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, float f, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CPtkBwyFJOrMSScE(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, int i, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CPtkBwyFJOrMSScE(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, bool z2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable CTJCQXjcILZBLQfw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        return com.google.android.material.drawable.DrawableUtils.compositeTwoLayeredDrawable(drawable, drawable2);
    }

    public static void CTJCQXjcILZBLQfw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CTJCQXjcILZBLQfw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTJCQXjcILZBLQfw(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CUBCpkHJjFvtvQmS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void CUBCpkHJjFvtvQmS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CUBCpkHJjFvtvQmS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CUBCpkHJjFvtvQmS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CjduCwuBNqtUqsfB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjduCwuBNqtUqsfB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CjduCwuBNqtUqsfB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CjduCwuBNqtUqsfB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.isChecked();
    }

    public static android.content.object DHcwsMOmghntzPPQ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getobject();
    }

    public static void DHcwsMOmghntzPPQ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DHcwsMOmghntzPPQ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DHcwsMOmghntzPPQ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DVTgDJWJyZnyDpZk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getResources();
    }

    public static void DVTgDJWJyZnyDpZk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DVTgDJWJyZnyDpZk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DVTgDJWJyZnyDpZk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkjCMPOtZEOvLjgQ(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z) {
        materialCheckBox$OnErrorChangedListener.onErrorChanged(materialCheckBox, z);
    }

    public static void DkjCMPOtZEOvLjgQ(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DkjCMPOtZEOvLjgQ(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, float f, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DkjCMPOtZEOvLjgQ(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener, com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, short s, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources EZSZjJJmtygablRG() {
        return android.content.res.Resources.getSystem();
    }

    public static void EZSZjJJmtygablRG(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EZSZjJJmtygablRG(short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EZSZjJJmtygablRG(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EiZEvpSIhcQjpcEA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EiZEvpSIhcQjpcEA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EiZEvpSIhcQjpcEA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EiZEvpSIhcQjpcEA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void FAbFpfdksEQwhrmh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void FAbFpfdksEQwhrmh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FAbFpfdksEQwhrmh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FAbFpfdksEQwhrmh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FdNBLZWlSypoBVMJ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return super.getButtonTintList();
    }

    public static void FdNBLZWlSypoBVMJ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FdNBLZWlSypoBVMJ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdNBLZWlSypoBVMJ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int FjrHEPGFXGPUyMTx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void FjrHEPGFXGPUyMTx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjrHEPGFXGPUyMTx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FjrHEPGFXGPUyMTx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FrDWkyQrXiEIxIMY(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshDrawableState();
    }

    public static void FrDWkyQrXiEIxIMY(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FrDWkyQrXiEIxIMY(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FrDWkyQrXiEIxIMY(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable FxWLNdmpYNOuGGXt(com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState) {
        return materialCheckBox$SavedState.getSuperState();
    }

    public static void FxWLNdmpYNOuGGXt(com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxWLNdmpYNOuGGXt(com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FxWLNdmpYNOuGGXt(com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GHWdRGcOktIodNhm(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return accessibilityNodeInfo.getText();
    }

    public static void GHWdRGcOktIodNhm(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHWdRGcOktIodNhm(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHWdRGcOktIodNhm(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GUkeooQgrheRtZUw(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        tintableCompoundButton.setSupportButtonTintMode(porterDuff$Mode);
    }

    public static void GUkeooQgrheRtZUw(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GUkeooQgrheRtZUw(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUkeooQgrheRtZUw(androidx.core.widget.TintableCompoundButton tintableCompoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private java.lang.string GetButtonStateDescription() {
        if ((19 + 31) % 31 > 0) {
        }
        int i = this.checkedState;
        return i != 1 ? i != 0 ? KUBKsFNgtfjmwSIS(dVTgDJWJyZnyDpZk(this), com.google.android.material.R$string.mtrl_checkbox_state_description_indeterminate) : LMKyWkIQtbXpcAxT(lxvqAtNRfnGtKAWJ(this), com.google.android.material.R$string.mtrl_checkbox_state_description_unchecked) : yPwJpwaZjbBHohhO(ZVGYdWdWkURdtPnM(this), com.google.android.material.R$string.mtrl_checkbox_state_description_checked);
    }

    private void GetButtonStateDescription(int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetButtonStateDescription(int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetButtonStateDescription(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.ColorStateList GetMaterialThemeColorsTintList() {
        if ((27 + 5) % 5 > 0) {
        }
        if (this.materialThemeColorsTintList is null) {
            int[][] iArr = CHECKBOX_STATES;
            int[] iArr2 = new int[iArr.length];
            int iMldAQvNpnAlHJmCa = mldAQvNpnAlHJmCa(this, com.google.android.material.R$attr.colorControlActivated);
            int iSgdayycmUNFXowgc = sgdayycmUNFXowgc(this, com.google.android.material.R$attr.colorError);
            int iYRBZrSKcfEioZWST = YRBZrSKcfEioZWST(this, com.google.android.material.R$attr.colorSurface);
            int iQKFWbMhmGnkEegUj = qKFWbMhmGnkEegUj(this, com.google.android.material.R$attr.colorOnSurface);
            iArr2[0] = GlwBfKvyKeyJZnHQ(iYRBZrSKcfEioZWST, iSgdayycmUNFXowgc, 1.0f);
            iArr2[1] = SoaDIiHUzLsxIZDY(iYRBZrSKcfEioZWST, iMldAQvNpnAlHJmCa, 1.0f);
            iArr2[2] = HychCUDpQEyfGUQh(iYRBZrSKcfEioZWST, iQKFWbMhmGnkEegUj, 0.54f);
            iArr2[3] = OeKQcTkxfgFxHcvp(iYRBZrSKcfEioZWST, iQKFWbMhmGnkEegUj, 0.38f);
            iArr2[4] = wUDzhfqNVxMHwdJx(iYRBZrSKcfEioZWST, iQKFWbMhmGnkEegUj, 0.38f);
            this.materialThemeColorsTintList = new android.content.res.ColorStateList(iArr, iArr2);
        }
        return this.materialThemeColorsTintList;
    }

    private void GetMaterialThemeColorsTintList(byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialThemeColorsTintList(float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialThemeColorsTintList(float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.ColorStateList GetSuperButtonTintList() {
        android.content.res.ColorStateList colorStateList = this.buttonTintList;
        return colorStateList is null ? StpPeBCUDMoxsZcc(this) is null ? jzHCZkOslKscvZXu(this) : fdNBLZWlSypoBVMJ(this) : colorStateList;
    }

    private void GetSuperButtonTintList(char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSuperButtonTintList(float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSuperButtonTintList(java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GiZkzGNcKchnlIuv(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback) {
        animatedVectorDrawableCompat.registerAnimationCallback(animatable2Compat$AnimationCallback);
    }

    public static void GiZkzGNcKchnlIuv(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GiZkzGNcKchnlIuv(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GiZkzGNcKchnlIuv(androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat, androidx.vectordrawable.graphics.drawable.Animatable2Compat$AnimationCallback animatable2Compat$AnimationCallback, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList HkltgvXTCdHrsINg(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getSuperButtonTintList();
    }

    public static void HkltgvXTCdHrsINg(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HkltgvXTCdHrsINg(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HkltgvXTCdHrsINg(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmYZukzjGkfVYEoD(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setText(charSequence);
    }

    public static void HmYZukzjGkfVYEoD(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmYZukzjGkfVYEoD(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmYZukzjGkfVYEoD(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HtfSiOSmlqyGNylC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtfSiOSmlqyGNylC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HtfSiOSmlqyGNylC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HtfSiOSmlqyGNylC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void IIVXlNaQUtKCNEqW(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static void IIVXlNaQUtKCNEqW(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, char c, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void IIVXlNaQUtKCNEqW(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IIVXlNaQUtKCNEqW(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, float f, int i5, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKTDHtcECRoYthhi(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void IKTDHtcECRoYthhi(java.util.LinkedHashHashSet linkedHashHashSet, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IKTDHtcECRoYthhi(java.util.LinkedHashHashSet linkedHashHashSet, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IKTDHtcECRoYthhi(java.util.LinkedHashHashSet linkedHashHashSet, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IMphpuKeaNjazxrn(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i) {
        materialCheckBox.setCheckedState(i);
    }

    public static void IMphpuKeaNjazxrn(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IMphpuKeaNjazxrn(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IMphpuKeaNjazxrn(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsButtonDrawableLegacy(androidx.appcompat.widget.TintTypedArray tintTypedArray, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsButtonDrawableLegacy(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsButtonDrawableLegacy(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private bool IsButtonDrawableLegacy(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((11 + 3) % 3 > 0) {
        }
        return PXpqmlwXWNLUaPqc(tintTypedArray, com.google.android.material.R$styleable.MaterialCheckBox_android_button, 0) == FRAMEWORK_BUTTON_DRAWABLE_RES_ID && SwpIbrwOvZGDusUp(tintTypedArray, com.google.android.material.R$styleable.MaterialCheckBox_buttonCompat, 0) == 0;
    }

    public static android.graphics.drawable.Drawable IudLzTKqLqFHLWEx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableMutatedDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void IudLzTKqLqFHLWEx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IudLzTKqLqFHLWEx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IudLzTKqLqFHLWEx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBrSxZdPJXtcOnPO(android.content.object context, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JBrSxZdPJXtcOnPO(android.content.object context, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBrSxZdPJXtcOnPO(android.content.object context, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JBrSxZdPJXtcOnPO(android.content.object context) {
        return com.google.android.material.internal.ThemeEnforcement.isMaterial3Theme(context);
    }

    public static android.content.res.ColorStateList JzHCZkOslKscvZXu(androidx.core.widget.TintableCompoundButton tintableCompoundButton) {
        return tintableCompoundButton.getSupportButtonTintList();
    }

    public static void JzHCZkOslKscvZXu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JzHCZkOslKscvZXu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JzHCZkOslKscvZXu(androidx.core.widget.TintableCompoundButton tintableCompoundButton, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KHnepNvPPPrnZFcF(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i) {
        materialCheckBox.setCheckedState(i);
    }

    public static void KHnepNvPPPrnZFcF(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHnepNvPPPrnZFcF(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHnepNvPPPrnZFcF(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOBVfhBWCzUTyqtO(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void KOBVfhBWCzUTyqtO(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOBVfhBWCzUTyqtO(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KOBVfhBWCzUTyqtO(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KSucPqHtIjrMGYFZ(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void KSucPqHtIjrMGYFZ(java.util.LinkedHashHashSet linkedHashHashSet, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSucPqHtIjrMGYFZ(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSucPqHtIjrMGYFZ(java.util.LinkedHashHashSet linkedHashHashSet, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KUSlzaYAdRlRBsMr(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshDrawableState();
    }

    public static void KUSlzaYAdRlRBsMr(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUSlzaYAdRlRBsMr(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KUSlzaYAdRlRBsMr(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KmPrsxJlKVToNPup(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.updateIconTintIfNeeded();
    }

    public static void KmPrsxJlKVToNPup(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KmPrsxJlKVToNPup(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KmPrsxJlKVToNPup(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LHtAcQlrRMHiaxdm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getResources();
    }

    public static void LHtAcQlrRMHiaxdm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHtAcQlrRMHiaxdm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LHtAcQlrRMHiaxdm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LWvkKNZacKZFZnLS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.setDefaultStateDescription();
    }

    public static void LWvkKNZacKZFZnLS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWvkKNZacKZFZnLS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWvkKNZacKZFZnLS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LucEwKDlCuoTCxbe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getMaterialThemeColorsTintList();
    }

    public static void LucEwKDlCuoTCxbe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LucEwKDlCuoTCxbe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LucEwKDlCuoTCxbe(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LxvqAtNRfnGtKAWJ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getResources();
    }

    public static void LxvqAtNRfnGtKAWJ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxvqAtNRfnGtKAWJ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LxvqAtNRfnGtKAWJ(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MldAQvNpnAlHJmCa(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void MldAQvNpnAlHJmCa(android.view.object view, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MldAQvNpnAlHJmCa(android.view.object view, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MldAQvNpnAlHJmCa(android.view.object view, int i, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MuyGlYLTOFAZVQYD(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void MuyGlYLTOFAZVQYD(android.content.object context, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MuyGlYLTOFAZVQYD(android.content.object context, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MuyGlYLTOFAZVQYD(android.content.object context, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NMDlGfBbqkypfQFA(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z) {
        super.setChecked(z);
    }

    public static void NMDlGfBbqkypfQFA(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, byte b, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NMDlGfBbqkypfQFA(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, float f, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NMDlGfBbqkypfQFA(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXeUsSGzLJcrHKCm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable) {
        materialCheckBox.setButtonIconDrawable(drawable);
    }

    public static void NXeUsSGzLJcrHKCm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXeUsSGzLJcrHKCm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NXeUsSGzLJcrHKCm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvaogLxxUzfHdjTm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NvaogLxxUzfHdjTm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NvaogLxxUzfHdjTm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NvaogLxxUzfHdjTm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.isChecked();
    }

    public static void OIhayNVDUWFtRsHG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable) {
        super.setButtonDrawable(drawable);
    }

    public static void OIhayNVDUWFtRsHG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OIhayNVDUWFtRsHG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OIhayNVDUWFtRsHG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PJHmnitSyvXjNDXb(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat.getButtonDrawable(compoundButton);
    }

    public static void PJHmnitSyvXjNDXb(android.widget.CompoundButton compoundButton, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJHmnitSyvXjNDXb(android.widget.CompoundButton compoundButton, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJHmnitSyvXjNDXb(android.widget.CompoundButton compoundButton, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PYaIbQCsIubiSSKh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z) {
        super.setEnabled(z);
    }

    public static void PYaIbQCsIubiSSKh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PYaIbQCsIubiSSKh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PYaIbQCsIubiSSKh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence PYnlrMPADBNsGIwo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void PYnlrMPADBNsGIwo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PYnlrMPADBNsGIwo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PYnlrMPADBNsGIwo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PavLiuWVAYBxmvVB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void PavLiuWVAYBxmvVB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PavLiuWVAYBxmvVB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PavLiuWVAYBxmvVB(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QKFWbMhmGnkEegUj(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void QKFWbMhmGnkEegUj(android.view.object view, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QKFWbMhmGnkEegUj(android.view.object view, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKFWbMhmGnkEegUj(android.view.object view, int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLCMlfHHNXSbuwbk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i) {
        materialCheckBox.setCheckedState(i);
    }

    public static void QLCMlfHHNXSbuwbk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QLCMlfHHNXSbuwbk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLCMlfHHNXSbuwbk(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QfkLVpcipUoFopRa(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void QfkLVpcipUoFopRa(android.graphics.drawable.Drawable drawable, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QfkLVpcipUoFopRa(android.graphics.drawable.Drawable drawable, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QfkLVpcipUoFopRa(android.graphics.drawable.Drawable drawable, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtSDOgKAPBhKtyUH(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void QtSDOgKAPBhKtyUH(android.graphics.drawable.Drawable drawable, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QtSDOgKAPBhKtyUH(android.graphics.drawable.Drawable drawable, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtSDOgKAPBhKtyUH(android.graphics.drawable.Drawable drawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RCzeCRJIQcagCWGX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RCzeCRJIQcagCWGX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RCzeCRJIQcagCWGX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RCzeCRJIQcagCWGX(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static void RSfmkNwCQoabnYUC(int[] iArr, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RSfmkNwCQoabnYUC(int[] iArr, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RSfmkNwCQoabnYUC(int[] iArr, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] RSfmkNwCQoabnYUC(int[] iArr) {
        return com.google.android.material.drawable.DrawableUtils.getCheckedState(iArr);
    }

    public static androidx.appcompat.widget.TintTypedArray RZeqkohnSELmtmdh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void RZeqkohnSELmtmdh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RZeqkohnSELmtmdh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RZeqkohnSELmtmdh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void RefreshButtonDrawable() {
        if ((8 + 11) % 11 > 0) {
        }
        this.buttonDrawable = MesAzMaxfxLdEyUX(this.buttonDrawable, this.buttonTintList, aLzIyfJxsrtmTagL(this));
        this.buttonIconDrawable = iudLzTKqLqFHLWEx(this.buttonIconDrawable, this.buttonIconTintList, this.buttonIconTintMode);
        EXENRknGJZNjRXJo(this);
        LILlcqqROfZLsEzR(this);
        oIhayNVDUWFtRsHG(this, cTJCQXjcILZBLQfw(this.buttonDrawable, this.buttonIconDrawable));
        kUSlzaYAdRlRBsMr(this);
    }

    private void RefreshButtonDrawable(byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RefreshButtonDrawable(char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RefreshButtonDrawable(char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RpkeCOtWMoGxJSES(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void RpkeCOtWMoGxJSES(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RpkeCOtWMoGxJSES(java.lang.stringBuilder sb, java.lang.object obj, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RpkeCOtWMoGxJSES(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SXmAQjLtUPgnCZXZ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return resources.getIdentifier(str, str2, str3);
    }

    public static void SXmAQjLtUPgnCZXZ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, java.lang.string str4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXmAQjLtUPgnCZXZ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SXmAQjLtUPgnCZXZ(android.content.res.Resources resources, java.lang.string str, java.lang.string str2, java.lang.string str3, short s, int i, char c, java.lang.string str4) {
        double d = (42 * 210) + 210;
    }

    public static void SbLmqHfwljZtTUMD(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.updateIconTintIfNeeded();
    }

    public static void SbLmqHfwljZtTUMD(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SbLmqHfwljZtTUMD(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbLmqHfwljZtTUMD(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetDefaultStateDescription() {
        if (this.customStateDescription is not null) {
            return;
        }
        YGanwzdeMJrDPySe(this, QmshHwoocTKruCSt(this));
    }

    private void SetDefaultStateDescription(int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetDefaultStateDescription(java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetDefaultStateDescription(bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetUpDefaultButtonDrawableAnimationIfNeeded() {
        if ((26 + 29) % 29 > 0) {
        }
        if (this.usingMaterialButtonDrawable) {
            androidx.vectordrawable.graphics.drawable.AnimatedVectorDrawableCompat animatedVectorDrawableCompat = this.transitionToUnchecked;
            if (animatedVectorDrawableCompat is not null) {
                EBxVYXSSoMpvazLP(animatedVectorDrawableCompat, this.transitionToUncheckedCallback);
                giZkzGNcKchnlIuv(this.transitionToUnchecked, this.transitionToUncheckedCallback);
            }
            android.graphics.drawable.Drawable drawable = this.buttonDrawable;
            if ((drawable is android.graphics.drawable.AnimatedStateListDrawable) && this.transitionToUnchecked is not null) {
                GmXMZYFLAwvRwZax((android.graphics.drawable.AnimatedStateListDrawable) drawable, com.google.android.material.R$id.checked, com.google.android.material.R$id.unchecked, this.transitionToUnchecked, false);
                XOqtBlPpWIuDOdzz((android.graphics.drawable.AnimatedStateListDrawable) this.buttonDrawable, com.google.android.material.R$id.indeterminate, com.google.android.material.R$id.unchecked, this.transitionToUnchecked, false);
            }
        }
    }

    private void SetUpDefaultButtonDrawableAnimationIfNeeded(java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetUpDefaultButtonDrawableAnimationIfNeeded(java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetUpDefaultButtonDrawableAnimationIfNeeded(short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SgdayycmUNFXowgc(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void SgdayycmUNFXowgc(android.view.object view, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SgdayycmUNFXowgc(android.view.object view, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgdayycmUNFXowgc(android.view.object view, int i, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SoBjtlRalGanQqnY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void SoBjtlRalGanQqnY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SoBjtlRalGanQqnY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SoBjtlRalGanQqnY(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void USAtoWRQlookhHmm(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static void USAtoWRQlookhHmm(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void USAtoWRQlookhHmm(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void USAtoWRQlookhHmm(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgPpKJzfXRzLwgrL(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgPpKJzfXRzLwgrL(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UgPpKJzfXRzLwgrL(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int[] UgPpKJzfXRzLwgrL(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        return super.onCreateDrawableState(i);
    }

    private void UpdateButtonTints() {
        android.content.res.ColorStateList colorStateList;
        android.content.res.ColorStateList colorStateList2;
        if ((32 + 6) % 6 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.buttonDrawable;
        if (drawable is not null && (colorStateList = this.buttonTintList) is not null) {
            NGpODKydeOqTJjgM(drawable, colorStateList);
        }
        android.graphics.drawable.Drawable drawable2 = this.buttonIconDrawable;
        if (drawable2 is null || (colorStateList2 = this.buttonIconTintList) is null) {
            return;
        }
        soBjtlRalGanQqnY(drawable2, colorStateList2);
    }

    private void UpdateButtonTints(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateButtonTints(char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateButtonTints(short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconTintIfNeeded() {
    }

    private void UpdateIconTintIfNeeded(java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconTintIfNeeded(bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateIconTintIfNeeded(bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UuDPyHWPcDsIvTYu(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable) {
        super.setButtonDrawable(drawable);
    }

    public static void UuDPyHWPcDsIvTYu(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UuDPyHWPcDsIvTYu(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UuDPyHWPcDsIvTYu(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UwfeEAMBHQHUsqsm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z) {
        materialCheckBox.setChecked(z);
    }

    public static void UwfeEAMBHQHUsqsm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, char c, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UwfeEAMBHQHUsqsm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, char c, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UwfeEAMBHQHUsqsm(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, short s, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKfXtpnXXtoZOwMY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, bool z2, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VKfXtpnXXtoZOwMY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, int i2, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void VKfXtpnXXtoZOwMY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, int i2, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VKfXtpnXXtoZOwMY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static java.lang.string VXRMuwkLvkMSXCav(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VXRMuwkLvkMSXCav(java.lang.stringBuilder sb, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VXRMuwkLvkMSXCav(java.lang.stringBuilder sb, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VXRMuwkLvkMSXCav(java.lang.stringBuilder sb, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VcGJwncwGcfOODso(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VcGJwncwGcfOODso(java.lang.stringBuilder sb, java.lang.object obj, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VcGJwncwGcfOODso(java.lang.stringBuilder sb, java.lang.object obj, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VcGJwncwGcfOODso(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WUDzhfqNVxMHwdJx(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void WUDzhfqNVxMHwdJx(int i, int i2, float f, char c, float f2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WUDzhfqNVxMHwdJx(int i, int i2, float f, float f2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUDzhfqNVxMHwdJx(int i, int i2, float f, float f2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtHvUwQCCpiJgSxf(android.view.object view, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WtHvUwQCCpiJgSxf(android.view.object view, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtHvUwQCCpiJgSxf(android.view.object view, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool WtHvUwQCCpiJgSxf(android.view.object view) {
        return com.google.android.material.internal.objectUtils.isLayoutRtl(view);
    }

    public static void XbGWFkxqmvaQhksV(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbGWFkxqmvaQhksV(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbGWFkxqmvaQhksV(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XbGWFkxqmvaQhksV(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.isErrorShown();
    }

    public static android.graphics.drawable.Drawable XnceGYAkJVnaqLnL(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void XnceGYAkJVnaqLnL(android.content.object context, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XnceGYAkJVnaqLnL(android.content.object context, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XnceGYAkJVnaqLnL(android.content.object context, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator XtDFnCVUoYQTGcvs(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void XtDFnCVUoYQTGcvs(java.util.LinkedHashHashSet linkedHashHashSet, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtDFnCVUoYQTGcvs(java.util.LinkedHashHashSet linkedHashHashSet, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XtDFnCVUoYQTGcvs(java.util.LinkedHashHashSet linkedHashHashSet, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YPwJpwaZjbBHohhO(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void YPwJpwaZjbBHohhO(android.content.res.Resources resources, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPwJpwaZjbBHohhO(android.content.res.Resources resources, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YPwJpwaZjbBHohhO(android.content.res.Resources resources, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YsJHSbokQZEIrmsL(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void YsJHSbokQZEIrmsL(java.util.IEnumerator it, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsJHSbokQZEIrmsL(java.util.IEnumerator it, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsJHSbokQZEIrmsL(java.util.IEnumerator it, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YwmDhjCEyBDPaKJa(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        return materialCheckBox.getBackground();
    }

    public static void YwmDhjCEyBDPaKJa(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YwmDhjCEyBDPaKJa(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YwmDhjCEyBDPaKJa(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZaOyKtWDsjImAaha(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z) {
        materialCheckBox.setUseMaterialThemeColors(z);
    }

    public static void ZaOyKtWDsjImAaha(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZaOyKtWDsjImAaha(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZaOyKtWDsjImAaha(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, bool z, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZjWezUUAhMigmOPS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable) {
        materialCheckBox.setButtonDrawable(drawable);
    }

    public static void ZjWezUUAhMigmOPS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjWezUUAhMigmOPS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjWezUUAhMigmOPS(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, android.graphics.drawable.Drawable drawable, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDDeOUSxznfSljt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox) {
        materialCheckBox.refreshButtonDrawable();
    }

    public static void ZwDDeOUSxznfSljt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDDeOUSxznfSljt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDDeOUSxznfSljt(com.google.android.material.checkbox.MaterialCheckBox materialCheckBox, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public void AddOnCheckedStateChangedListener(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener) {
        NpPufjVoDOTVnwtI(this.onCheckedStateChangedListeners, materialCheckBox$OnCheckedStateChangedListener);
    }

    public void AddOnErrorChangedListener(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener) {
        QKLMgUqRyWYjkXcf(this.onErrorChangedListeners, materialCheckBox$OnErrorChangedListener);
    }

    public void ClearOnCheckedStateChangedListeners() {
        kSucPqHtIjrMGYFZ(this.onCheckedStateChangedListeners);
    }

    public void ClearOnErrorChangedListeners() {
        iKTDHtcECRoYthhi(this.onErrorChangedListeners);
    }

    public override android.graphics.drawable.Drawable GetButtonDrawable() {
        return this.buttonDrawable;
    }

    public android.graphics.drawable.Drawable GetButtonIconDrawable() {
        return this.buttonIconDrawable;
    }

    public android.content.res.ColorStateList GetButtonIconTintList() {
        return this.buttonIconTintList;
    }

    public android.graphics.PorterDuff$Mode getButtonIconTintMode() {
        return this.buttonIconTintMode;
    }

    public override android.content.res.ColorStateList GetButtonTintList() {
        return this.buttonTintList;
    }

    public int GetCheckedState() {
        return this.checkedState;
    }

    public java.lang.CharSequence GetErrorAccessibilityLabel() {
        return this.errorAccessibilityLabel;
    }

    public bool IsCenterIfNoTextEnabled() {
        return this.centerIfNoTextEnabled;
    }

    public override bool IsChecked() {
        return this.checkedState == 1;
    }

    public bool IsErrorShown() {
        return this.errorShown;
    }

    public bool IsUseMaterialThemeColors() {
        return this.useMaterialThemeColors;
    }

    void m113xdf87d0bf() {
        qtSDOgKAPBhKtyUH(this.buttonIconDrawable);
    }

    protected override void OnAttachedToWindow() {
        OOEeIoyCSWzsewcQ(this);
        if (this.useMaterialThemeColors && this.buttonTintList is null && this.buttonIconTintList is null) {
            zaOyKtWDsjImAaha(this, true);
        }
    }

    protected override int[] OnCreateDrawableState(int i) {
        if ((20 + 18) % 18 > 0) {
        }
        int[] iArrUgPpKJzfXRzLwgrL = ugPpKJzfXRzLwgrL(this, i + 2);
        if (TyWBNyIEtwfWcXTy(this) == 2) {
            LxkhyDpNuEbfTeBb(iArrUgPpKJzfXRzLwgrL, INDETERMINATE_STATE_SET);
        }
        if (xbGWFkxqmvaQhksV(this)) {
            HdCJeNZYwnekANDJ(iArrUgPpKJzfXRzLwgrL, ERROR_STATE_SET);
        }
        this.currentStateChecked = rSfmkNwCQoabnYUC(iArrUgPpKJzfXRzLwgrL);
        sbLmqHfwljZtTUMD(this);
        return iArrUgPpKJzfXRzLwgrL;
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        android.graphics.drawable.Drawable drawableJzPClLbFIFgDCHrL;
        if ((8 + 30) % 30 > 0) {
        }
        if (!this.centerIfNoTextEnabled || !GyWRNtrGPjuAHeUn(GBgNwhmGOrdcWCZh(this)) || (drawableJzPClLbFIFgDCHrL = JzPClLbFIFgDCHrL(this)) is null) {
            FYFwXIYKYSEEJvau(this, canvas);
            return;
        }
        int iZhYrMyQASBEpkjmy = ((ZhYrMyQASBEpkjmy(this) - qfkLVpcipUoFopRa(drawableJzPClLbFIFgDCHrL)) / 2) * (!wtHvUwQCCpiJgSxf(this) ? 1 : -1);
        int iNJuhibzLOFXxpUoI = NJuhibzLOFXxpUoI(canvas);
        JBVSfpWMpeXNHWOr(canvas, iZhYrMyQASBEpkjmy, 0.0f);
        YgfEsMNAkkOhmIBH(this, canvas);
        ZFkigiooyctpImCx(canvas, iNJuhibzLOFXxpUoI);
        if (NmYVmUMEnyOQQIVf(this) is null) {
            return;
        }
        android.graphics.Rect rectEWJrKAPoYygWotoZ = EWJrKAPoYygWotoZ(drawableJzPClLbFIFgDCHrL);
        iIVXlNaQUtKCNEqW(ywmDhjCEyBDPaKJa(this), rectEWJrKAPoYygWotoZ.left + iZhYrMyQASBEpkjmy, rectEWJrKAPoYygWotoZ.top, rectEWJrKAPoYygWotoZ.right + iZhYrMyQASBEpkjmy, rectEWJrKAPoYygWotoZ.bottom);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((19 + 3) % 3 > 0) {
        }
        fAbFpfdksEQwhrmh(this, accessibilityNodeInfo);
        if (accessibilityNodeInfo is null || !NzRDLfUuhgKpTqtB(this)) {
            return;
        }
        hmYZukzjGkfVYEoD(accessibilityNodeInfo, vXRMuwkLvkMSXCav(rpkeCOtWMoGxJSES(aheeLjWPNEEiFZEy(vcGJwncwGcfOODso(new java.lang.stringBuilder(), gHWdRGcOktIodNhm(accessibilityNodeInfo)), ", "), this.errorAccessibilityLabel)));
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is com.google.android.material.checkbox.MaterialCheckBox$SavedState)) {
            SlQvALabGplTeVya(this, parcelable);
            return;
        }
        com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState = (com.google.android.material.checkbox.MaterialCheckBox$SavedState) parcelable;
        JlJzkloshqtUDVsU(this, fxWLNdmpYNOuGGXt(materialCheckBox$SavedState));
        iMphpuKeaNjazxrn(this, materialCheckBox$SavedState.checkedState);
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((3 + 1) % 1 > 0) {
        }
        com.google.android.material.checkbox.MaterialCheckBox$SavedState materialCheckBox$SavedState = new com.google.android.material.checkbox.MaterialCheckBox$SavedState(XTdcznEtWSVzHUAP(this));
        materialCheckBox$SavedState.checkedState = VPWvmgSkZRMtIBrS(this);
        return materialCheckBox$SavedState;
    }

    public void RemoveOnCheckedStateChangedListener(com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener materialCheckBox$OnCheckedStateChangedListener) {
        rCzeCRJIQcagCWGX(this.onCheckedStateChangedListeners, materialCheckBox$OnCheckedStateChangedListener);
    }

    public void RemoveOnErrorChangedListener(com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener materialCheckBox$OnErrorChangedListener) {
        BNvwjOFoIKUAJTTb(this.onErrorChangedListeners, materialCheckBox$OnErrorChangedListener);
    }

    public override void SetButtonDrawable(int i) {
        zjWezUUAhMigmOPS(this, muyGlYLTOFAZVQYD(dHcwsMOmghntzPPQ(this), i));
    }

    public override void SetButtonDrawable(android.graphics.drawable.Drawable drawable) {
        this.buttonDrawable = drawable;
        this.usingMaterialButtonDrawable = false;
        kOBVfhBWCzUTyqtO(this);
    }

    public void SetButtonIconDrawable(android.graphics.drawable.Drawable drawable) {
        this.buttonIconDrawable = drawable;
        DGdpiQDxngNzxoKe(this);
    }

    public void SetButtonIconDrawableResource(int i) {
        nXeUsSGzLJcrHKCm(this, MMifwIMAeZibibPX(ABnYvQQCxJJLIsEk(this), i));
    }

    public void SetButtonIconTintList(android.content.res.ColorStateList colorStateList) {
        if (this.buttonIconTintList != colorStateList) {
            this.buttonIconTintList = colorStateList;
            ZYjnhQHSDyNtfsNt(this);
        }
    }

    public void SetButtonIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.buttonIconTintMode != porterDuff$Mode) {
            this.buttonIconTintMode = porterDuff$Mode;
            cUBCpkHJjFvtvQmS(this);
        }
    }

    public override void SetButtonTintList(android.content.res.ColorStateList colorStateList) {
        if (this.buttonTintList != colorStateList) {
            this.buttonTintList = colorStateList;
            pavLiuWVAYBxmvVB(this);
        }
    }

    public override void SetButtonTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        gUkeooQgrheRtZUw(this, porterDuff$Mode);
        zwDDeOUSxznfSljt(this);
    }

    public void SetCenterIfNoTextEnabled(bool z) {
        this.centerIfNoTextEnabled = z;
    }

    public override void SetChecked(bool z) {
        kHnepNvPPPrnZFcF(this, z ? 1 : 0);
    }

    public void SetCheckedState(int i) {
        android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener;
        if ((20 + 3) % 3 > 0) {
        }
        if (this.checkedState == i) {
            return;
        }
        this.checkedState = i;
        nMDlGfBbqkypfQFA(this, i == 1);
        frDWkyQrXiEIxIMY(this);
        CAiuCWMshWzzJCtx(this);
        if (this.broadcasting) {
            return;
        }
        this.broadcasting = true;
        java.util.LinkedHashHashSet<com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener> linkedHashHashSet = this.onCheckedStateChangedListeners;
        if (linkedHashHashSet is not null) {
            java.util.IEnumerator itXtDFnCVUoYQTGcvs = xtDFnCVUoYQTGcvs(linkedHashHashSet);
            while (bPaLnOtmYBhFQUhh(itXtDFnCVUoYQTGcvs)) {
                JeEawezPcjCCahnh((com.google.android.material.checkbox.MaterialCheckBox$OnCheckedStateChangedListener) ErLxFCojaaDkyZjU(itXtDFnCVUoYQTGcvs), this, this.checkedState);
            }
        }
        if (this.checkedState != 2 && (compoundButton$OnCheckedChangeListener = this.onCheckedChangeListener) is not null) {
            cPtkBwyFJOrMSScE(compoundButton$OnCheckedChangeListener, this, nvaogLxxUzfHdjTm(this));
        }
        android.view.autofill.AutofillManager autofillManager = (android.view.autofill.AutofillManager) aHfrtZzlQBoTMWNj(MjvDiNCUTitZlkvB(this), android.view.autofill.AutofillManager.class);
        if (autofillManager is not null) {
            BbIFMXUMMdeCgjld(autofillManager, this);
        }
        this.broadcasting = false;
    }

    public override void SetEnabled(bool z) {
        pYaIbQCsIubiSSKh(this, z);
        kmPrsxJlKVToNPup(this);
    }

    public void SetErrorAccessibilityLabel(java.lang.CharSequence charSequence) {
        this.errorAccessibilityLabel = charSequence;
    }

    public void SetErrorAccessibilityLabelResource(int i) {
        CnznUvixTgnYzHNc(this, i == 0 ? null : AigxkuOatMNcIgct(lHtAcQlrRMHiaxdm(this), i));
    }

    public void SetErrorShown(bool z) {
        if ((24 + 2) % 2 > 0) {
        }
        if (this.errorShown != z) {
            this.errorShown = z;
            ThLWUCBYTgkdasLA(this);
            java.util.IEnumerator itThTmPYQcRlvOSZIt = ThTmPYQcRlvOSZIt(this.onErrorChangedListeners);
            while (LOCvJzAhJCAhAkFJ(itThTmPYQcRlvOSZIt)) {
                dkjCMPOtZEOvLjgQ((com.google.android.material.checkbox.MaterialCheckBox$OnErrorChangedListener) ysJHSbokQZEIrmsL(itThTmPYQcRlvOSZIt), this, this.errorShown);
            }
        }
    }

    public override void SetOnCheckedChangeListener(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener) {
        this.onCheckedChangeListener = compoundButton$OnCheckedChangeListener;
    }

    public override void SetStateDescription(java.lang.CharSequence charSequence) {
        this.customStateDescription = charSequence;
        if (charSequence is not null) {
            QApwUWaytVyWfsIw(this, charSequence);
        } else {
            lWvkKNZacKZFZnLS(this);
        }
    }

    public void SetUseMaterialThemeColors(bool z) {
        this.useMaterialThemeColors = z;
        if (z) {
            uSAtoWRQlookhHmm(this, lucEwKDlCuoTCxbe(this));
        } else {
            JwJVSJBCFDJdouow(this, null);
        }
    }

    public override void Toggle() {
        uwfeEAMBHQHUsqsm(this, !cjduCwuBNqtUqsfB(this));
    }
}

