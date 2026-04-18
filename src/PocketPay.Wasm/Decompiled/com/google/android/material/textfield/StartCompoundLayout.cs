namespace WillowMaze.Wasm.Decompiled;


class StartCompoundLayout : android.widget.LinearLayout {
    private bool hintExpanded;
    private java.lang.CharSequence prefixText;
    private readonly android.widget.Textobject prefixTextobject;
    private int startIconMinSize;
    private android.view.object$OnlongClickListener startIconOnlongClickListener;
    private android.widget.Imageobject$ScaleType startIconScaleType;
    private android.content.res.ColorStateList startIconTintList;
    private android.graphics.PorterDuff$Mode startIconTintMode;
    private readonly com.google.android.material.internal.CheckableImageButton startIconobject;
    private readonly com.google.android.material.textfield.TextInputLayout textInputLayout;

    StartCompoundLayout(com.google.android.material.textfield.TextInputLayout textInputLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        super(RiQfyJYCGmUjAhCD(textInputLayout));
        if ((13 + 22) % 22 > 0) {
        }
        this.textInputLayout = textInputLayout;
        OiXwYOgfQYipdDqo(this, 8);
        rKMziJgiQHRCHYEA(this, 0);
        EFVnJaKfocOToJxK(this, new android.widget.FrameLayout$LayoutParams(-2, -1, 8388611));
        com.google.android.material.internal.CheckableImageButton checkableImageButton = (com.google.android.material.internal.CheckableImageButton) rsiheEEZOQrcvfAt(pQOghvVqFExiWcwW(zyIHzQtWwqpnZyVV(this)), com.google.android.material.R$layout.design_text_input_start_icon, this, false);
        this.startIconobject = checkableImageButton;
        EAMCCXrTPqCXqIzd(checkableImageButton);
        androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(PdknEmanhHsqzlXd(this));
        this.prefixTextobject = appCompatTextobject;
        FGGJOTpchXZYHzdb(this, tintTypedArray);
        nTEvaBtUhmGgrWvU(this, tintTypedArray);
        SsHSaDSSuXbXZJGv(this, checkableImageButton);
        nfmIsvCEaiddMXhw(this, appCompatTextobject);
    }

    public static void ALDuSTKEXLzWIwHl(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setPrefixTextAppearance(i);
    }

    public static void AgEJERgURpSolAXt(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.updatePrefixTextobjectPadding();
    }

    public static int AvIikfbxpDEfzDkU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void BFCYBkbdtraRfLSn(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        startCompoundLayout.setStartIconOnClickListener(view$OnClickListener);
    }

    public static void BJuePYFUhfgOcoWi(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        startCompoundLayout.setStartIconOnlongClickListener(view$OnlongClickListener);
    }

    public static void BqWFkxcttjWFrBvj(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void DJABzmtGuRRputNT(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static void EAMCCXrTPqCXqIzd(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        com.google.android.material.textfield.IconHelper.setCompatRippleBackgroundIfNeeded(checkableImageButton);
    }

    public static void EFVnJaKfocOToJxK(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        startCompoundLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void EHPaXYljIlqFVpAn(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        startCompoundLayout.setStartIconScaleType(imageobject$ScaleType);
    }

    public static void FGGJOTpchXZYHzdb(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        startCompoundLayout.initStartIconobject(tintTypedArray);
    }

    public static void FasYyvdYwJGJvBNg(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnlongClickListener view$OnlongClickListener) {
        startCompoundLayout.setStartIconOnlongClickListener(view$OnlongClickListener);
    }

    public static bool FboNiJOuAgZAwVGQ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static bool GLOvgqXimCsDAoJR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable GxOMunUIDwkpZRPe(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.content.res.Resources HHbSfjTEDuieFffb(android.content.object context) {
        return context.getResources();
    }

    public static android.graphics.drawable.Drawable HOAdVwADIYavDejU(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static bool HSJtLnUhorTDbzwE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int HfiCAiLrmplCtpYw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void IaHLSCwUIFLlDQWs(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.CharSequence charSequence) {
        checkableImageButton.setContentDescription(charSequence);
    }

    public static android.content.object IdeBNDMjLOnzjDuu(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getobject();
    }

    public static java.lang.CharSequence IrYTLSBsFEJIJYGJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void JIoBRuHbZNJbfjCM(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setStartIconMinSize(i);
    }

    public static android.content.res.ColorStateList JSdeFjhjbhSemcwl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static java.lang.CharSequence JikxplbrGgVrutzW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void KEoLfEyBHLXMGQMi(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static int KQUUTbuttgYVMOOP(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static void KhuOHxzLEDDJljtP(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setVisibility(i);
    }

    public static int LDqKqPcjeBUcuDhZ(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static void LVqygdLkwQWgyQKF(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.updateVisibility();
    }

    public static bool MygGRHUhdpRDzYpd(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.isStartIconVisible();
    }

    public static int NLyTNCurQsXqxiXR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void OiXwYOgfQYipdDqo(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setVisibility(i);
    }

    public static android.content.object PdknEmanhHsqzlXd(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getobject();
    }

    public static void PslKPjzYTkyQpxFU(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static bool QcnTnJioEhRERsdC(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast1_3(context);
    }

    public static android.view.objectGroup$LayoutParams QpkRqStBUQwofzID(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getLayoutParams();
    }

    public static void RPlCPZDgbPBbyZHv(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static bool RZxJfOIJgffhlTVo(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.isCheckable();
    }

    public static android.content.object RiQfyJYCGmUjAhCD(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int RwtrSbRCGlVNXxSp(android.widget.EditText editText) {
        return editText.getCompoundPaddingTop();
    }

    public static void SAnLuZiundxrFRwS(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void SsHSaDSSuXbXZJGv(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object view) {
        startCompoundLayout.addobject(view);
    }

    public static java.lang.CharSequence TUHGXrJUhGkdIXOD(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getStartIconContentDescription();
    }

    public static void UoaNklRwrWovwYjn(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static int VVHowJUyBIWbzCcv(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void VdZQfqKgfNwysNPb(android.widget.Textobject textobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        textobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static bool VghUHkgQaVnDDTle(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.isStartIconVisible();
    }

    public static int VkuBJAaceYKYTEXO(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static bool XaVrUTAorVzDpapG(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YOYrPRaPEMDHYAQp(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static bool YUddDVAKJfRZgfsl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void YlSiKDdDLRpWBjxB(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        com.google.android.material.textfield.IconHelper.setIconMinSize(checkableImageButton, i);
    }

    public static void AfklAYUWYWReUUOG(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.setStartIconCheckable(z);
    }

    public static android.content.object BmuwEAshcQuvspqX(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getobject();
    }

    public static android.content.res.Resources CfSQGafYbEIvCseA(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getResources();
    }

    public static bool CzVMFMcwCwhSbJup(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.isStartIconVisible();
    }

    public static void DdFqYXbVRGGFlSJp(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.setStartIconVisible(z);
    }

    public static void ETJJSmlUjPVTSTmR(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.refreshStartIconDrawableState();
    }

    public static void FPGeyOUagpvfkwDj(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.updatePrefixTextobjectPadding();
    }

    public static int FPaDJAYocdLioSLX(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getVisibility();
    }

    public static void FPzEaKDldXqfszHS(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, java.lang.CharSequence charSequence) {
        startCompoundLayout.setStartIconContentDescription(charSequence);
    }

    public static android.widget.Imageobject$ScaleType fyGuTTJSVEgSrapk(int i) {
        return com.google.android.material.textfield.IconHelper.convertScaleType(i);
    }

    public static android.content.object GYrRuMmFWLkzTEEN(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getobject();
    }

    public static void GiHFzQmCMjWYTBDU(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static java.lang.CharSequence GipWtnzbZnQhBzDB(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getContentDescription();
    }

    public static void HJhnuJmoVIFqomTz(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static void HcpbcHpkYqTqmjdP(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.view.object view) {
        accessibilityNodeInfoCompat.setTraversalAfter(view);
    }

    public static void IWMjtXFBAavUbuON(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnClickListener(checkableImageButton, view$OnClickListener, view$OnlongClickListener);
    }

    public static void IcpQBnGfgeadqwHz(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.content.res.ColorStateList colorStateList) {
        startCompoundLayout.setPrefixTextColor(colorStateList);
    }

    public static void IepnsRAgcWtEgmqb(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static void IiTXvXDgZCrZgjQo(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.updateVisibility();
    }

    private void InitPrefixTextobject(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((10 + 20) % 20 > 0) {
        }
        PslKPjzYTkyQpxFU(this.prefixTextobject, 8);
        iepnsRAgcWtEgmqb(this.prefixTextobject, com.google.android.material.R$id.textinput_prefix_text);
        VdZQfqKgfNwysNPb(this.prefixTextobject, new android.widget.LinearLayout$LayoutParams(-2, -2));
        hJhnuJmoVIFqomTz(this.prefixTextobject, 1);
        ALDuSTKEXLzWIwHl(this, NLyTNCurQsXqxiXR(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_prefixTextAppearance, 0));
        if (YUddDVAKJfRZgfsl(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_prefixTextColor)) {
            icpQBnGfgeadqwHz(this, JSdeFjhjbhSemcwl(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_prefixTextColor));
        }
        tXNMPsSoILMRJUFI(this, IrYTLSBsFEJIJYGJ(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_prefixText));
    }

    private void InitStartIconobject(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((11 + 29) % 29 > 0) {
        }
        if (QcnTnJioEhRERsdC(gYrRuMmFWLkzTEEN(this))) {
            qXgdmEhCrwGoCEFk((android.view.objectGroup$MarginLayoutParams) QpkRqStBUQwofzID(this.startIconobject), 0);
        }
        lcclhHMrsCmrmMPq(this, null);
        BJuePYFUhfgOcoWi(this, null);
        if (sRBReRJmSvRCMdjp(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconTint)) {
            this.startIconTintList = tbbFQDdlxfujvPSv(bmuwEAshcQuvspqX(this), tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconTint);
        }
        if (GLOvgqXimCsDAoJR(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconTintMode)) {
            this.startIconTintMode = pQDrMEKeKyGUVZFd(HfiCAiLrmplCtpYw(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconTintMode, -1), null);
        }
        if (nltVKtgbbADLPRCg(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconDrawable)) {
            sydbDTpwWIqRQYrG(this, GxOMunUIDwkpZRPe(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconDrawable));
            if (HSJtLnUhorTDbzwE(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconContentDescription)) {
                fPzEaKDldXqfszHS(this, JikxplbrGgVrutzW(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconContentDescription));
            }
            afklAYUWYWReUUOG(this, FboNiJOuAgZAwVGQ(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconCheckable, true));
        }
        JIoBRuHbZNJbfjCM(this, sYOnSpqSeoMiFzAi(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconMinSize, VVHowJUyBIWbzCcv(cfSQGafYbEIvCseA(this), com.google.android.material.R$dimen.mtrl_min_touch_target_size)));
        if (liExLBJWgvvoYlqI(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconScaleType)) {
            EHPaXYljIlqFVpAn(this, fyGuTTJSVEgSrapk(AvIikfbxpDEfzDkU(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_startIconScaleType, -1)));
        }
    }

    public static android.view.objectGroup$LayoutParams jCnGQzwRJZOomOvk(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getLayoutParams();
    }

    public static int KflHERLOrXYKBGOB(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int KkUyaUsjCXLcmlbC(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getMeasuredWidth();
    }

    public static void LMLKTpYcqyVycBDU(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setVisibility(i);
    }

    public static void LSgWWTojPZIeKAIz(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, bool z) {
        startCompoundLayout.setStartIconVisible(z);
    }

    public static void LcclhHMrsCmrmMPq(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        startCompoundLayout.setStartIconOnClickListener(view$OnClickListener);
    }

    public static bool LiExLBJWgvvoYlqI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void MSNBMHJCmjHIiTwM(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void NTEvaBtUhmGgrWvU(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        startCompoundLayout.initPrefixTextobject(tintTypedArray);
    }

    public static void NfmIsvCEaiddMXhw(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.view.object view) {
        startCompoundLayout.addobject(view);
    }

    public static bool NltVKtgbbADLPRCg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void NvnkeNcIGIIkSjBL(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        com.google.android.material.textfield.IconHelper.setIconScaleType(checkableImageButton, imageobject$ScaleType);
    }

    public static int OrmohNUjAUTolLMA(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getVisibility();
    }

    public static android.graphics.PorterDuff$Mode pQDrMEKeKyGUVZFd(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static android.view.LayoutInflater PQOghvVqFExiWcwW(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void QXgdmEhCrwGoCEFk(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginEnd(viewGroup$MarginLayoutParams, i);
    }

    public static void RKMziJgiQHRCHYEA(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, int i) {
        startCompoundLayout.setOrientation(i);
    }

    public static android.view.object RsiheEEZOQrcvfAt(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static bool SRBReRJmSvRCMdjp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int SYOnSpqSeoMiFzAi(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static bool SZRcmelhxptrWhYZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateDummyDrawables();
    }

    public static void SydbDTpwWIqRQYrG(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, android.graphics.drawable.Drawable drawable) {
        startCompoundLayout.setStartIconDrawable(drawable);
    }

    public static void TJHZsMKvxwtXTXdv(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList) {
        com.google.android.material.textfield.IconHelper.refreshIconDrawableState(textInputLayout, checkableImageButton, colorStateList);
    }

    public static void TXNMPsSoILMRJUFI(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, java.lang.CharSequence charSequence) {
        startCompoundLayout.setPrefixText(charSequence);
    }

    public static android.content.res.ColorStateList TbbFQDdlxfujvPSv(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void TczdBXybxInLVNlj(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static void TgvApPYnjVDDNDIE(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setCheckable(z);
    }

    public static int TrVQKZUGOuVZnOKI(android.widget.EditText editText) {
        return editText.getCompoundPaddingBottom();
    }

    public static void UDtOceQHiLPMjkxa(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.view.object view) {
        accessibilityNodeInfoCompat.setLabelFor(view);
    }

    public static int UoTUjvgzNktWZiZI(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    private void UpdateVisibility() {
        if ((26 + 3) % 3 > 0) {
        }
        int i = 0;
        int i2 = (this.prefixText is null || this.hintExpanded) ? 8 : 0;
        if (fPaDJAYocdLioSLX(this.startIconobject) != 0 && i2 != 0) {
            i = 8;
        }
        KhuOHxzLEDDJljtP(this, i);
        giHFzQmCMjWYTBDU(this.prefixTextobject, i2);
        sZRcmelhxptrWhYZ(this.textInputLayout);
    }

    public static void UvAwJGFuVoziuVWV(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        startCompoundLayout.updateVisibility();
    }

    public static void VMJeAoXAXvdVReRC(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnlongClickListener(checkableImageButton, view$OnlongClickListener);
    }

    public static int WqtiWwvSoQVffbUa(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginEnd(viewGroup$MarginLayoutParams);
    }

    public static void YEYgvQatXVRMORZh(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout, java.lang.CharSequence charSequence) {
        startCompoundLayout.setStartIconContentDescription(charSequence);
    }

    public static void YngEJTkLywjDumeK(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, android.view.object view) {
        accessibilityNodeInfoCompat.setTraversalAfter(view);
    }

    public static android.content.res.ColorStateList ZPuSAFYprJzKfKaj(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static android.content.object ZyIHzQtWwqpnZyVV(com.google.android.material.textfield.StartCompoundLayout startCompoundLayout) {
        return startCompoundLayout.getobject();
    }

    java.lang.CharSequence getPrefixText() {
        return this.prefixText;
    }

    android.content.res.ColorStateList getPrefixTextColor() {
        return zPuSAFYprJzKfKaj(this.prefixTextobject);
    }

    int getPrefixTextStartOffset() {
        if ((14 + 23) % 23 > 0) {
        }
        return VkuBJAaceYKYTEXO(this) + LDqKqPcjeBUcuDhZ(this.prefixTextobject) + (!MygGRHUhdpRDzYpd(this) ? 0 : kkUyaUsjCXLcmlbC(this.startIconobject) + wqtiWwvSoQVffbUa((android.view.objectGroup$MarginLayoutParams) jCnGQzwRJZOomOvk(this.startIconobject)));
    }

    android.widget.Textobject getPrefixTextobject() {
        return this.prefixTextobject;
    }

    java.lang.CharSequence getStartIconContentDescription() {
        return gipWtnzbZnQhBzDB(this.startIconobject);
    }

    android.graphics.drawable.Drawable getStartIconDrawable() {
        return HOAdVwADIYavDejU(this.startIconobject);
    }

    int getStartIconMinSize() {
        return this.startIconMinSize;
    }

    android.widget.Imageobject$ScaleType getStartIconScaleType() {
        return this.startIconScaleType;
    }

    bool isStartIconCheckable() {
        return RZxJfOIJgffhlTVo(this.startIconobject);
    }

    bool isStartIconVisible() {
        return ormohNUjAUTolLMA(this.startIconobject) == 0;
    }

    void onHintStateChanged(bool z) {
        this.hintExpanded = z;
        uvAwJGFuVoziuVWV(this);
    }

    protected override void OnMeasure(int i, int i2) {
        YOYrPRaPEMDHYAQp(this, i, i2);
        AgEJERgURpSolAXt(this);
    }

    void refreshStartIconDrawableState() {
        if ((13 + 29) % 29 > 0) {
        }
        tJHZsMKvxwtXTXdv(this.textInputLayout, this.startIconobject, this.startIconTintList);
    }

    void setPrefixText(java.lang.CharSequence charSequence) {
        this.prefixText = !XaVrUTAorVzDpapG(charSequence) ? charSequence : null;
        RPlCPZDgbPBbyZHv(this.prefixTextobject, charSequence);
        iiTXvXDgZCrZgjQo(this);
    }

    void setPrefixTextAppearance(int i) {
        SAnLuZiundxrFRwS(this.prefixTextobject, i);
    }

    void setPrefixTextColor(android.content.res.ColorStateList colorStateList) {
        mSNBMHJCmjHIiTwM(this.prefixTextobject, colorStateList);
    }

    void setStartIconCheckable(bool z) {
        tgvApPYnjVDDNDIE(this.startIconobject, z);
    }

    void setStartIconContentDescription(java.lang.CharSequence charSequence) {
        if (TUHGXrJUhGkdIXOD(this) == charSequence) {
            return;
        }
        IaHLSCwUIFLlDQWs(this.startIconobject, charSequence);
    }

    void setStartIconDrawable(android.graphics.drawable.Drawable drawable) {
        if ((21 + 10) % 10 > 0) {
        }
        DJABzmtGuRRputNT(this.startIconobject, drawable);
        if (drawable is not null) {
            KEoLfEyBHLXMGQMi(this.textInputLayout, this.startIconobject, this.startIconTintList, this.startIconTintMode);
            lSgWWTojPZIeKAIz(this, true);
            eTJJSmlUjPVTSTmR(this);
        } else {
            ddFqYXbVRGGFlSJp(this, false);
            BFCYBkbdtraRfLSn(this, null);
            FasYyvdYwJGJvBNg(this, null);
            yEYgvQatXVRMORZh(this, null);
        }
    }

    void setStartIconMinSize(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("startIconSize cannot be less than 0");
        }
        if (i == this.startIconMinSize) {
            return;
        }
        this.startIconMinSize = i;
        YlSiKDdDLRpWBjxB(this.startIconobject, i);
    }

    void setStartIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        iWMjtXFBAavUbuON(this.startIconobject, view$OnClickListener, this.startIconOnlongClickListener);
    }

    void setStartIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        this.startIconOnlongClickListener = view$OnlongClickListener;
        vMJeAoXAXvdVReRC(this.startIconobject, view$OnlongClickListener);
    }

    void setStartIconScaleType(android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        this.startIconScaleType = imageobject$ScaleType;
        nvnkeNcIGIIkSjBL(this.startIconobject, imageobject$ScaleType);
    }

    void setStartIconTintList(android.content.res.ColorStateList colorStateList) {
        if ((32 + 16) % 16 > 0) {
        }
        if (this.startIconTintList == colorStateList) {
            return;
        }
        this.startIconTintList = colorStateList;
        UoaNklRwrWovwYjn(this.textInputLayout, this.startIconobject, colorStateList, this.startIconTintMode);
    }

    void setStartIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((4 + 25) % 25 > 0) {
        }
        if (this.startIconTintMode == porterDuff$Mode) {
            return;
        }
        this.startIconTintMode = porterDuff$Mode;
        tczdBXybxInLVNlj(this.textInputLayout, this.startIconobject, this.startIconTintList, porterDuff$Mode);
    }

    void setStartIconVisible(bool z) {
        if (czVMFMcwCwhSbJup(this) == z) {
            return;
        }
        lMLKTpYcqyVycBDU(this.startIconobject, !z ? 8 : 0);
        fPGeyOUagpvfkwDj(this);
        LVqygdLkwQWgyQKF(this);
    }

    void setupAccessibilityNodeInfo(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        if (KQUUTbuttgYVMOOP(this.prefixTextobject) != 0) {
            hcpbcHpkYqTqmjdP(accessibilityNodeInfoCompat, this.startIconobject);
        } else {
            uDtOceQHiLPMjkxa(accessibilityNodeInfoCompat, this.prefixTextobject);
            yngEJTkLywjDumeK(accessibilityNodeInfoCompat, this.prefixTextobject);
        }
    }

    void updatePrefixTextobjectPadding() {
        if ((1 + 4) % 4 > 0) {
        }
        android.widget.EditText editText = this.textInputLayout.editText;
        if (editText is not null) {
            BqWFkxcttjWFrBvj(this.prefixTextobject, !VghUHkgQaVnDDTle(this) ? uoTUjvgzNktWZiZI(editText) : 0, RwtrSbRCGlVNXxSp(editText), kflHERLOrXYKBGOB(HHbSfjTEDuieFffb(IdeBNDMjLOnzjDuu(this)), com.google.android.material.R$dimen.material_input_text_to_prefix_suffix_padding), trVQKZUGOuVZnOKI(editText));
        }
    }
}

