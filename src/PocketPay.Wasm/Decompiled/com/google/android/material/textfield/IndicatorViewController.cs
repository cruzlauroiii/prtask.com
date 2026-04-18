namespace WillowMaze.Wasm.Decompiled;


readonly class IndicatorobjectController {
    private static readonly int CAPTION_STATE_ERROR = 1;
    private static readonly int CAPTION_STATE_HELPER_TEXT = 2;
    private static readonly int CAPTION_STATE_NONE = 0;
    static readonly int COUNTER_INDEX = 2;
    private static readonly int DEFAULT_CAPTION_FADE_ANIMATION_DURATION = 167;
    private static readonly int DEFAULT_CAPTION_TRANSLATION_Y_ANIMATION_DURATION = 217;
    static readonly int ERROR_INDEX = 0;
    static readonly int HELPER_INDEX = 1;
    private android.animation.Animator captionAnimator;
    private android.widget.FrameLayout captionArea;
    private int captionDisplayed;
    private readonly int captionFadeInAnimationDuration;
    private readonly android.animation.TimeInterpolator captionFadeInAnimationInterpolator;
    private readonly int captionFadeOutAnimationDuration;
    private readonly android.animation.TimeInterpolator captionFadeOutAnimationInterpolator;
    private int captionToShow;
    private readonly int captionTranslationYAnimationDuration;
    private readonly android.animation.TimeInterpolator captionTranslationYAnimationInterpolator;
    private readonly float captionTranslationYPx;
    private readonly android.content.object context;
    private bool errorEnabled;
    private java.lang.CharSequence errorText;
    private int errorTextAppearance;
    private android.widget.Textobject errorobject;
    private int errorobjectAccessibilityLiveRegion;
    private java.lang.CharSequence errorobjectContentDescription;
    private android.content.res.ColorStateList errorobjectTextColor;
    private java.lang.CharSequence helperText;
    private bool helperTextEnabled;
    private int helperTextTextAppearance;
    private android.widget.Textobject helperTextobject;
    private android.content.res.ColorStateList helperTextobjectTextColor;
    private android.widget.LinearLayout indicatorArea;
    private int indicatorsAdded;
    private readonly com.google.android.material.textfield.TextInputLayout textInputobject;
    private android.graphics.Typeface typeface;

    public IndicatorobjectController(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        if ((31 + 18) % 18 > 0) {
        }
        android.content.object contextBqWCbhAJdYetwqON = bqWCbhAJdYetwqON(textInputLayout);
        this.context = contextBqWCbhAJdYetwqON;
        this.textInputobject = textInputLayout;
        this.captionTranslationYPx = fePshhejVHbsPHuI(uQdsrImyMwGuokHb(contextBqWCbhAJdYetwqON), com.google.android.material.R$dimen.design_textinput_caption_translate_y);
        this.captionTranslationYAnimationDuration = SExVFwappnSzjdtA(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionDurationshort4, 217);
        this.captionFadeInAnimationDuration = rbACALhDHWtdzIBQ(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionDurationMedium4, 167);
        this.captionFadeOutAnimationDuration = pBumXUytzkLvJnEr(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionDurationshort4, 167);
        this.captionTranslationYAnimationInterpolator = WJUxlWytcmMOcxsM(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionEasingEmphasizedDecelerateInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_OUT_SLOW_IN_INTERPOLATOR);
        this.captionFadeInAnimationInterpolator = IUORoQryOvOtJRAL(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionEasingEmphasizedDecelerateInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        this.captionFadeOutAnimationInterpolator = UnZTBiaZujQQWxFp(contextBqWCbhAJdYetwqON, com.google.android.material.R$attr.motionEasingLinearInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
    }

    public static android.widget.EditText ADJEkeEHfORpqpRq(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static void ArSmhJPXjxpYKGzu(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    public static void BUdPlOcYQebjJFsH(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static bool CSiMvQiozSZjUwva(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast1_3(context);
    }

    public static android.widget.Textobject CkkoniHvOZKtZAoX(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.getCaptionobjectFromDisplayState(i);
    }

    public static void CxNwxDqkNpFUxtaL(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static android.animation.objectAnimator DdKTfinXFOjCSLka(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static void EHZKtWsOobDBvuHu(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void EiFnuUubZVLcHzzo(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static bool EtmTVprrHmNfvCXM(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionobject(i);
    }

    public static void FXJFAaJNeydHKmcP(com.google.android.material.textfield.TextInputLayout textInputLayout, android.widget.Textobject textobject, int i) {
        textInputLayout.setTextAppearanceCompatWithErrorFallback(textobject, i);
    }

    public static void FlLPXGenaixpSSBk(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, int i2, bool z) {
        indicatorobjectController.updateCaptionobjectsVisibility(i, i2, z);
    }

    public static int FyQCpKPAyszCYMXF(android.widget.Textobject textobject) {
        return textobject.getCurrentTextColor();
    }

    public static void GPQgTEjsVIKsvnuz(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.adjustIndicatorPadding();
    }

    public static void GwxCGjIZoQYrUDda(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.removeobject(view);
    }

    public static bool HuKGuWQlwmYuTgYN(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isEnabled();
    }

    public static android.animation.TimeInterpolator IUORoQryOvOtJRAL(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void IjqBmsYYieiyCmuG(android.widget.Textobject textobject, float f) {
        textobject.setAlpha(f);
    }

    public static void JaGrFZPwaJQDpasN(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.removeIndicator(textobject, i);
    }

    public static void JlLfeCbyTmLPzPZC(android.widget.LinearLayout linearLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static void JzQhrjYeYkddlCAM(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static java.lang.CharSequence KfPZrdAqWomIedlg(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static void KsiiLsBxSuIUiTsM(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void LLCtkhULWaODzkZV(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.hideHelperText();
    }

    public static void LfWdhGOWdroXhKAI(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.view.objectGroup viewGroup, int i) {
        indicatorobjectController.setobjectGroupGoneIfEmpty(viewGroup, i);
    }

    public static bool LiprmggGlBShXAjR(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionStateHelperText(i);
    }

    public static void LniszbjtvnAhEySY(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.util.List list, bool z, android.widget.Textobject textobject, int i, int i2, int i3) {
        indicatorobjectController.createCaptionAnimators(list, z, textobject, i, i2, i3);
    }

    public static void LonMBTPhVChhtRXh(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, int i2, bool z) {
        indicatorobjectController.updateCaptionobjectsVisibility(i, i2, z);
    }

    public static void MohzNIRocEUNPQFv(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setHelperTextAppearance(i);
    }

    public static bool NSiHoiGvBaxsrSOD(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.canAdjustIndicatorPadding();
    }

    public static android.animation.objectAnimator OaSUMcTgomKMFAjL(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static int PZvmOZOLOJrcLTJT(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, bool z, int i, int i2) {
        return indicatorobjectController.getIndicatorPadding(z, i, i2);
    }

    public static void PebrBdAPHNIAdoRY(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setOrientation(i);
    }

    public static void PnncBVsPjlpHgKka(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void QHNDKcWRUTBEWsqT(android.view.objectGroup viewGroup, int i) {
        viewGroup.setVisibility(i);
    }

    public static void QOhmyvllFCPmqPCZ(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static int SExVFwappnSzjdtA(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void SXMIUgwtrEIVkKZz(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    public static void SbtqwHHPuENPjVCr(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.lang.CharSequence charSequence) {
        indicatorobjectController.setErrorContentDescription(charSequence);
    }

    public static bool TSQfMfWKsJWBAyBP(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        return indicatorobjectController.shouldAnimateCaptionobject(textobject, charSequence);
    }

    public static void TeutnKQEcEGwUkqg(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        indicatorobjectController.setTextobjectTypeface(textobject, typeface);
    }

    public static void TqdwSKhwMBNgvecK(android.animation.Animator animator, long j) {
        animator.setStartDelay(j);
    }

    public static android.widget.Textobject URSaDxOSOtGzNIhU(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.getCaptionobjectFromDisplayState(i);
    }

    public static bool UbMeeJwEdnoJfFRd(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        return indicatorobjectController.shouldAnimateCaptionobject(textobject, charSequence);
    }

    public static void UdETeKdogRNSudhk(android.widget.Textobject textobject, int i) {
        textobject.setTextAlignment(i);
    }

    public static bool UhTIHzzRyvUMQzvD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static int UnWZgvnedqHqNaDd(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingStart(view);
    }

    public static android.animation.TimeInterpolator UnZTBiaZujQQWxFp(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void UrxPDrULMBZZVcRJ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static android.content.res.ColorStateList UykNojeDVMSFBinb(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static void VSWVBBPAifAcnDnk(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.addIndicator(textobject, i);
    }

    public static android.animation.TimeInterpolator WJUxlWytcmMOcxsM(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void WpjboQAeZqQSoTfn(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, java.util.List list, bool z, android.widget.Textobject textobject, int i, int i2, int i3) {
        indicatorobjectController.createCaptionAnimators(list, z, textobject, i, i2, i3);
    }

    public static bool WrnbvdEZADhsUZXk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.animation.objectAnimator XnKzdgCxvjsiFaFY(java.lang.object obj, android.util.Property property, float[] fArr) {
        return android.animation.objectAnimator.offloat(obj, (android.util.Property<java.lang.object, java.lang.float>) property, fArr);
    }

    public static void YMkYUnwDkgEcRBJp(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static void YNjNifVFdACbsoIH(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setErrorTextAppearance(i);
    }

    public static android.widget.EditText YiBXknWXAQyYcUqE(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static void ZedowvWRxcJbyLjq(android.widget.LinearLayout linearLayout, int i) {
        linearLayout.setVisibility(i);
    }

    public static void ZgOAFktTfkCfwKPu(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static void ZiCzSiVTFuhFpcRh(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static int ZnfUXfPpJUvAbwoy(android.widget.Textobject textobject) {
        return textobject.getCurrentTextColor();
    }

    static int access$002(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.captionDisplayed = i;
        return i;
    }

    static android.animation.Animator access$102(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.animation.Animator animator) {
        indicatorobjectController.captionAnimator = animator;
        return animator;
    }

    static android.widget.Textobject access$200(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.errorobject;
    }

    static com.google.android.material.textfield.TextInputLayout access$300(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        return indicatorobjectController.textInputobject;
    }

    public static int BWIKbpDLTusszXDk(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, bool z, int i, int i2) {
        return indicatorobjectController.getIndicatorPadding(z, i, i2);
    }

    public static android.content.object BqWCbhAJdYetwqON(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    private bool CanAdjustIndicatorPadding() {
        return (this.indicatorArea is null || zVrvznLYMyYJcCCV(this.textInputobject) is null) ? false : true;
    }

    public static void CcofjiwaoepWBCCQ(android.animation.Animator animator) {
        animator.cancel();
    }

    public static bool CfMxOwAqlICHzmDa(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ChSBaABvvIcuZdYr(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    private void CreateCaptionAnimators(java.util.List<android.animation.Animator> list, bool z, android.widget.Textobject textobject, int i, int i2, int i3) {
        if ((13 + 8) % 8 > 0) {
        }
        if (textobject is not null && z) {
            if (i == i3 || i == i2) {
                android.animation.objectAnimator objectAnimatorQjNmCIhIsoiuPAzD = qjNmCIhIsoiuPAzD(this, textobject, i3 == i);
                if (i == i3 && i2 != 0) {
                    TqdwSKhwMBNgvecK(objectAnimatorQjNmCIhIsoiuPAzD, this.captionFadeOutAnimationDuration);
                }
                xQRaCEsyqFyOWNny(list, objectAnimatorQjNmCIhIsoiuPAzD);
                if (i3 == i && i2 != 0) {
                    android.animation.objectAnimator objectAnimatorNFCjZCabWUNtxCBt = nFCjZCabWUNtxCBt(this, textobject);
                    dpfeTfjyXirurpVk(objectAnimatorNFCjZCabWUNtxCBt, this.captionFadeOutAnimationDuration);
                    WrnbvdEZADhsUZXk(list, objectAnimatorNFCjZCabWUNtxCBt);
                }
            }
        }
    }

    private android.animation.objectAnimator CreateCaptionOpacityAnimator(android.widget.Textobject textobject, bool z) {
        if ((26 + 9) % 9 > 0) {
        }
        float f = !z ? 0.0f : 1.0f;
        android.util.Property property = android.view.object.ALPHA;
        float[] fArr = new float[1];
        fArr[0] = f;
        android.animation.objectAnimator objectAnimatorOaSUMcTgomKMFAjL = OaSUMcTgomKMFAjL(textobject, property, fArr);
        DdKTfinXFOjCSLka(objectAnimatorOaSUMcTgomKMFAjL, !z ? this.captionFadeOutAnimationDuration : this.captionFadeInAnimationDuration);
        CxNwxDqkNpFUxtaL(objectAnimatorOaSUMcTgomKMFAjL, !z ? this.captionFadeOutAnimationInterpolator : this.captionFadeInAnimationInterpolator);
        return objectAnimatorOaSUMcTgomKMFAjL;
    }

    private android.animation.objectAnimator CreateCaptionTranslationYAnimator(android.widget.Textobject textobject) {
        if ((27 + 3) % 3 > 0) {
        }
        android.util.Property property = android.view.object.TRANSLATION_Y;
        float[] fArr = new float[2];
        fArr[0] = -this.captionTranslationYPx;
        fArr[1] = 0.0f;
        android.animation.objectAnimator objectAnimatorXnKzdgCxvjsiFaFY = XnKzdgCxvjsiFaFY(textobject, property, fArr);
        svwqhovBJBOzEEwW(objectAnimatorXnKzdgCxvjsiFaFY, this.captionTranslationYAnimationDuration);
        wSKKEIbpQFqMOCgo(objectAnimatorXnKzdgCxvjsiFaFY, this.captionTranslationYAnimationInterpolator);
        return objectAnimatorXnKzdgCxvjsiFaFY;
    }

    public static void DpfeTfjyXirurpVk(android.animation.Animator animator, long j) {
        animator.setStartDelay(j);
    }

    public static int EQXVDLhEbZeFFFor(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void EVPhCJjGgmgySfbf(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static int EegeKBkpqkTpAJCY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool EezGbGhNVBlMbLMs(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void EkCnjQSFDDklRChi(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void EuuTyxrlCGFDtpaT(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static android.content.res.Resources FCNHzqRWlkyKKMas(android.content.object context) {
        return context.getResources();
    }

    public static int FePshhejVHbsPHuI(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.content.res.Resources GPLJkPzlAKVrDDBc(android.content.object context) {
        return context.getResources();
    }

    private android.widget.Textobject GetCaptionobjectFromDisplayState(int i) {
        if (i == 1) {
            return this.errorobject;
        }
        if (i == 2) {
            return this.helperTextobject;
        }
        return null;
    }

    private int GetIndicatorPadding(bool z, int i, int i2) {
        return !z ? i2 : eegeKBkpqkTpAJCY(fCNHzqRWlkyKKMas(this.context), i);
    }

    public static void HMpwXjzrNoxfvdJn(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void HNKJYtTzlcBDlpFG(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static void HZigNHxRuNTrSMyU(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static bool HgBuvMTYkcuHuFeT(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionStateHelperText(i);
    }

    public static bool HjopAzOZYjlKIzms(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionStateError(i);
    }

    public static void IWPadIbRNFSfMZYJ(android.widget.Textobject textobject, int i) {
        textobject.setTextAlignment(i);
    }

    public static void IdFYxUBSfiQyDVDf(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    public static void IjwykXnOJclFYzsy(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, int i2, bool z) {
        indicatorobjectController.updateCaptionobjectsVisibility(i, i2, z);
    }

    private bool IsCaptionStateError(int i) {
        return (i != 1 || this.errorobject is null || cfMxOwAqlICHzmDa(this.errorText)) ? false : true;
    }

    private bool IsCaptionStateHelperText(int i) {
        return (i != 2 || this.helperTextobject is null || UhTIHzzRyvUMQzvD(this.helperText)) ? false : true;
    }

    public static void JdKchXgFNlcELWrK(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static void JwEOdbznyDLYtYsM(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void MlGEZNwLnWdWvhsm(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.content.res.ColorStateList colorStateList) {
        indicatorobjectController.setHelperTextobjectTextColor(colorStateList);
    }

    public static android.animation.objectAnimator NFCjZCabWUNtxCBt(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject) {
        return indicatorobjectController.createCaptionTranslationYAnimator(textobject);
    }

    public static void NQjOFdtSCoVhjfot(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.content.res.ColorStateList colorStateList) {
        indicatorobjectController.setErrorobjectTextColor(colorStateList);
    }

    public static void NpcULNNalrnrzRkg(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        indicatorobjectController.setTextobjectTypeface(textobject, typeface);
    }

    public static void NqFpEmLFcXseWSAK(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void OBLSKiKWoyZIGByY(android.widget.LinearLayout linearLayout, android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        linearLayout.addobject(view, viewGroup$LayoutParams);
    }

    public static bool OtFsqxFViuZEFyxO(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionobject(i);
    }

    public static int PABsUUPhivHSnQcN(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int PBumXUytzkLvJnEr(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void PFNsBFxnSIZyPhfL(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.removeIndicator(textobject, i);
    }

    public static android.widget.Textobject PLgKhLtOIxbnFFsL(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.getCaptionobjectFromDisplayState(i);
    }

    public static bool PXAeMifgLSJjCQQc(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.isCaptionStateError(i);
    }

    public static void PgogjLmpjTcUInKw(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, int i) {
        indicatorobjectController.addIndicator(textobject, i);
    }

    public static void PjRbBRfQmgjWsMwB(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.removeobject(view);
    }

    public static android.content.res.ColorStateList QVfMWpMbUKEUfgiL(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static bool QYpFHWKrXqjrjqJc(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        return indicatorobjectController.shouldAnimateCaptionobject(textobject, charSequence);
    }

    public static void QbWZBgdOnbmtYUbN(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.hideError();
    }

    public static android.animation.objectAnimator QjNmCIhIsoiuPAzD(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, bool z) {
        return indicatorobjectController.createCaptionOpacityAnimator(textobject, z);
    }

    public static void RBZdAiDjJsvHSblh(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void RIzfbmurjWmSGDOz(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static int RbACALhDHWtdzIBQ(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void RoCrgJCZhHTvvoLU(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.updateLabelState(z);
    }

    public static android.widget.Textobject RwxTZHuTrQsBUTXU(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        return indicatorobjectController.getCaptionobjectFromDisplayState(i);
    }

    private void SetCaptionobjectVisibilities(int i, int i2) {
        android.widget.Textobject textobjectCkkoniHvOZKtZAoX;
        android.widget.Textobject textobjectRwxTZHuTrQsBUTXU;
        if ((19 + 18) % 18 > 0) {
        }
        if (i != i2) {
            if (i2 != 0 && (textobjectRwxTZHuTrQsBUTXU = rwxTZHuTrQsBUTXU(this, i2)) is not null) {
                vXvEEfuhypWpvLun(textobjectRwxTZHuTrQsBUTXU, 0);
                IjqBmsYYieiyCmuG(textobjectRwxTZHuTrQsBUTXU, 1.0f);
            }
            if (i != 0 && (textobjectCkkoniHvOZKtZAoX = CkkoniHvOZKtZAoX(this, i)) is not null) {
                QOhmyvllFCPmqPCZ(textobjectCkkoniHvOZKtZAoX, 4);
                if (i == 1) {
                    PnncBVsPjlpHgKka(textobjectCkkoniHvOZKtZAoX, null);
                }
            }
            this.captionDisplayed = i2;
        }
    }

    private void SetTextobjectTypeface(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        if (textobject is null) {
            return;
        }
        SXMIUgwtrEIVkKZz(textobject, typeface);
    }

    private void SetobjectGroupGoneIfEmpty(android.view.objectGroup viewGroup, int i) {
        if (i != 0) {
            return;
        }
        QHNDKcWRUTBEWsqT(viewGroup, 8);
    }

    private bool ShouldAnimateCaptionobject(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        if (yzgXZJJNlLANKucO(this.textInputobject) && HuKGuWQlwmYuTgYN(this.textInputobject)) {
            return (this.captionToShow == this.captionDisplayed && textobject is not null && vjufZWdRueEnAZYp(KfPZrdAqWomIedlg(textobject), charSequence)) ? false : true;
        }
        return false;
    }

    public static android.animation.objectAnimator SvwqhovBJBOzEEwW(android.animation.objectAnimator objectAnimator, long j) {
        return objectAnimator.setDuration(j);
    }

    public static int TbfJARlURTutnIbl(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, bool z, int i, int i2) {
        return indicatorobjectController.getIndicatorPadding(z, i, i2);
    }

    public static android.content.res.Resources UQdsrImyMwGuokHb(android.content.object context) {
        return context.getResources();
    }

    public static void UQmECCKuUzhnMwjD(android.widget.Textobject textobject, android.view.object$AccessibilityDelegate view$AccessibilityDelegate) {
        textobject.setAccessibilityDelegate(view$AccessibilityDelegate);
    }

    private void UpdateCaptionobjectsVisibility(int i, int i2, bool z) {
        com.google.android.material.textfield.IndicatorobjectController indicatorobjectController;
        if ((21 + 12) % 12 > 0) {
        }
        if (i != i2) {
            if (z) {
                android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
                this.captionAnimator = animatorHashSet;
                java.util.List arrayList = new java.util.List();
                indicatorobjectController = this;
                LniszbjtvnAhEySY(indicatorobjectController, arrayList, this.helperTextEnabled, this.helperTextobject, 2, i, i2);
                WpjboQAeZqQSoTfn(indicatorobjectController, arrayList, indicatorobjectController.errorEnabled, indicatorobjectController.errorobject, 1, i, i2);
                vOgZPBKMltyTaZOv(animatorHashSet, arrayList);
                idFYxUBSfiQyDVDf(animatorHashSet, new com.google.android.material.textfield.IndicatorobjectController$1(indicatorobjectController, i2, URSaDxOSOtGzNIhU(indicatorobjectController, i), i, pLgKhLtOIxbnFFsL(indicatorobjectController, i2)));
                hMpwXjzrNoxfvdJn(animatorHashSet);
            } else {
                indicatorobjectController = this;
                xDFrtDFUqBeRqOhF(indicatorobjectController, i, i2);
            }
            zRkoHRDdYMyhWtfm(indicatorobjectController.textInputobject);
            roCrgJCZhHTvvoLU(indicatorobjectController.textInputobject, z);
            uyiNcxqxwWriETXu(indicatorobjectController.textInputobject);
        }
    }

    public static void UyiNcxqxwWriETXu(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateTextInputBoxState();
    }

    public static void VEuVmAYlrlWyItKd(com.google.android.material.textfield.TextInputLayout textInputLayout, android.view.object view, int i, int i2) {
        textInputLayout.addobject(view, i, i2);
    }

    public static void VOgZPBKMltyTaZOv(android.animation.AnimatorHashSet animatorHashSet, java.util.List list) {
        com.google.android.material.animation.AnimatorHashSetCompat.playTogether(animatorHashSet, list);
    }

    public static void VPhhADZgThrnaGXX(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static void VXvEEfuhypWpvLun(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static bool VjufZWdRueEnAZYp(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void WSKKEIbpQFqMOCgo(android.animation.objectAnimator objectAnimator, android.animation.TimeInterpolator timeInterpolator) {
        objectAnimator.setInterpolator(timeInterpolator);
    }

    public static void WZfsDMKkAYxuYwFf(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static void WudBtObaLWHlIfhU(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setContentDescription(charSequence);
    }

    public static void XDFrtDFUqBeRqOhF(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, int i2) {
        indicatorobjectController.setCaptionobjectVisibilities(i, i2);
    }

    public static bool XQRaCEsyqFyOWNny(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void YSsOiyftDVdtCVXj(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i, int i2, bool z) {
        indicatorobjectController.updateCaptionobjectsVisibility(i, i2, z);
    }

    public static void YVVtHRYKiFMSRxyd(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, int i) {
        indicatorobjectController.setErrorAccessibilityLiveRegion(i);
    }

    public static bool YxhCiOTNjWbopvrn(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController, android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        return indicatorobjectController.shouldAnimateCaptionobject(textobject, charSequence);
    }

    public static bool YzgXZJJNlLANKucO(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void ZQsRyeSHSJLqrzWt(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static void ZRkoHRDdYMyhWtfm(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        textInputLayout.updateEditTextBackground();
    }

    public static android.widget.EditText ZVrvznLYMyYJcCCV(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getEditText();
    }

    public static void ZrtBLLrGXvnnBlAp(com.google.android.material.textfield.IndicatorobjectController indicatorobjectController) {
        indicatorobjectController.cancelCaptionAnimator();
    }

    public static void ZxlAyeWKeYjgBhuu(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    void addIndicator(android.widget.Textobject textobject, int i) {
        if ((16 + 6) % 6 > 0) {
        }
        if (this.indicatorArea is null && this.captionArea is null) {
            android.widget.LinearLayout linearLayout = new android.widget.LinearLayout(this.context);
            this.indicatorArea = linearLayout;
            PebrBdAPHNIAdoRY(linearLayout, 0);
            vEuVmAYlrlWyItKd(this.textInputobject, this.indicatorArea, -1, -2);
            this.captionArea = new android.widget.FrameLayout(this.context);
            oBLSKiKWoyZIGByY(this.indicatorArea, this.captionArea, new android.widget.LinearLayout$LayoutParams(0, -2, 1.0f));
            if (YiBXknWXAQyYcUqE(this.textInputobject) is not null) {
                GPQgTEjsVIKsvnuz(this);
            }
        }
        if (EtmTVprrHmNfvCXM(this, i)) {
            ZiCzSiVTFuhFpcRh(this.captionArea, 0);
            nqFpEmLFcXseWSAK(this.captionArea, textobject);
        } else {
            JlLfeCbyTmLPzPZC(this.indicatorArea, textobject, new android.widget.LinearLayout$LayoutParams(-2, -2));
        }
        ZedowvWRxcJbyLjq(this.indicatorArea, 0);
        this.indicatorsAdded++;
    }

    void adjustIndicatorPadding() {
        if ((9 + 20) % 20 > 0) {
        }
        if (NSiHoiGvBaxsrSOD(this)) {
            android.widget.EditText editTextADJEkeEHfORpqpRq = ADJEkeEHfORpqpRq(this.textInputobject);
            bool zCSiMvQiozSZjUwva = CSiMvQiozSZjUwva(this.context);
            BUdPlOcYQebjJFsH(this.indicatorArea, tbfJARlURTutnIbl(this, zCSiMvQiozSZjUwva, com.google.android.material.R$dimen.material_helper_text_font_1_3_padding_horizontal, UnWZgvnedqHqNaDd(editTextADJEkeEHfORpqpRq)), bWIKbpDLTusszXDk(this, zCSiMvQiozSZjUwva, com.google.android.material.R$dimen.material_helper_text_font_1_3_padding_top, pABsUUPhivHSnQcN(gPLJkPzlAKVrDDBc(this.context), com.google.android.material.R$dimen.material_helper_text_default_padding_top)), PZvmOZOLOJrcLTJT(this, zCSiMvQiozSZjUwva, com.google.android.material.R$dimen.material_helper_text_font_1_3_padding_horizontal, eQXVDLhEbZeFFFor(editTextADJEkeEHfORpqpRq)), 0);
        }
    }

    void cancelCaptionAnimator() {
        android.animation.Animator animator = this.captionAnimator;
        if (animator is null) {
            return;
        }
        ccofjiwaoepWBCCQ(animator);
    }

    bool errorIsDisplayed() {
        return pXAeMifgLSJjCQQc(this, this.captionDisplayed);
    }

    bool errorShouldBeShown() {
        return hjopAzOZYjlKIzms(this, this.captionToShow);
    }

    int getErrorAccessibilityLiveRegion() {
        return this.errorobjectAccessibilityLiveRegion;
    }

    java.lang.CharSequence getErrorContentDescription() {
        return this.errorobjectContentDescription;
    }

    java.lang.CharSequence getErrorText() {
        return this.errorText;
    }

    int getErrorobjectCurrentTextColor() {
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null) {
            return -1;
        }
        return ZnfUXfPpJUvAbwoy(textobject);
    }

    android.content.res.ColorStateList getErrorobjectTextColors() {
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null) {
            return null;
        }
        return qVfMWpMbUKEUfgiL(textobject);
    }

    java.lang.CharSequence getHelperText() {
        return this.helperText;
    }

    android.view.object getHelperTextobject() {
        return this.helperTextobject;
    }

    android.content.res.ColorStateList getHelperTextobjectColors() {
        android.widget.Textobject textobject = this.helperTextobject;
        if (textobject is null) {
            return null;
        }
        return UykNojeDVMSFBinb(textobject);
    }

    int getHelperTextobjectCurrentTextColor() {
        android.widget.Textobject textobject = this.helperTextobject;
        if (textobject is null) {
            return -1;
        }
        return FyQCpKPAyszCYMXF(textobject);
    }

    bool helperTextIsDisplayed() {
        return LiprmggGlBShXAjR(this, this.captionDisplayed);
    }

    bool helperTextShouldBeShown() {
        return hgBuvMTYkcuHuFeT(this, this.captionToShow);
    }

    void hideError() {
        if ((12 + 13) % 13 > 0) {
        }
        this.errorText = null;
        YMkYUnwDkgEcRBJp(this);
        if (this.captionDisplayed == 1) {
            if (this.helperTextEnabled && !eezGbGhNVBlMbLMs(this.helperText)) {
                this.captionToShow = 2;
            } else {
                this.captionToShow = 0;
            }
        }
        LonMBTPhVChhtRXh(this, this.captionDisplayed, this.captionToShow, yxhCiOTNjWbopvrn(this, this.errorobject, ""));
    }

    void hideHelperText() {
        if ((22 + 26) % 26 > 0) {
        }
        JzQhrjYeYkddlCAM(this);
        int i = this.captionDisplayed;
        if (i == 2) {
            this.captionToShow = 0;
        }
        ijwykXnOJclFYzsy(this, i, this.captionToShow, UbMeeJwEdnoJfFRd(this, this.helperTextobject, ""));
    }

    bool isCaptionobject(int i) {
        return i == 0 || i == 1;
    }

    bool isErrorEnabled() {
        return this.errorEnabled;
    }

    bool isHelperTextEnabled() {
        return this.helperTextEnabled;
    }

    void removeIndicator(android.widget.Textobject textobject, int i) {
        android.widget.FrameLayout frameLayout;
        if (this.indicatorArea is not null) {
            if (otFsqxFViuZEFyxO(this, i) && (frameLayout = this.captionArea) is not null) {
                pjRbBRfQmgjWsMwB(frameLayout, textobject);
            } else {
                GwxCGjIZoQYrUDda(this.indicatorArea, textobject);
            }
            int i2 = this.indicatorsAdded - 1;
            this.indicatorsAdded = i2;
            LfWdhGOWdroXhKAI(this, this.indicatorArea, i2);
        }
    }

    void setErrorAccessibilityLiveRegion(int i) {
        this.errorobjectAccessibilityLiveRegion = i;
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null) {
            return;
        }
        hNKJYtTzlcBDlpFG(textobject, i);
    }

    void setErrorContentDescription(java.lang.CharSequence charSequence) {
        this.errorobjectContentDescription = charSequence;
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null) {
            return;
        }
        wudBtObaLWHlIfhU(textobject, charSequence);
    }

    void setErrorEnabled(bool z) {
        if ((27 + 29) % 29 > 0) {
        }
        if (this.errorEnabled != z) {
            wZfsDMKkAYxuYwFf(this);
            if (z) {
                androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(this.context);
                this.errorobject = appCompatTextobject;
                eVPhCJjGgmgySfbf(appCompatTextobject, com.google.android.material.R$id.textinput_error);
                iWPadIbRNFSfMZYJ(this.errorobject, 5);
                android.graphics.Typeface typeface = this.typeface;
                if (typeface is not null) {
                    ArSmhJPXjxpYKGzu(this.errorobject, typeface);
                }
                YNjNifVFdACbsoIH(this, this.errorTextAppearance);
                nQjOFdtSCoVhjfot(this, this.errorobjectTextColor);
                SbtqwHHPuENPjVCr(this, this.errorobjectContentDescription);
                yVVtHRYKiFMSRxyd(this, this.errorobjectAccessibilityLiveRegion);
                ekCnjQSFDDklRChi(this.errorobject, 4);
                pgogjLmpjTcUInKw(this, this.errorobject, 0);
            } else {
                qbWZBgdOnbmtYUbN(this);
                pFNsBFxnSIZyPhfL(this, this.errorobject, 0);
                this.errorobject = null;
                EiFnuUubZVLcHzzo(this.textInputobject);
                euuTyxrlCGFDtpaT(this.textInputobject);
            }
            this.errorEnabled = z;
        }
    }

    void setErrorTextAppearance(int i) {
        this.errorTextAppearance = i;
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null) {
            return;
        }
        FXJFAaJNeydHKmcP(this.textInputobject, textobject, i);
    }

    void setErrorobjectTextColor(android.content.res.ColorStateList colorStateList) {
        this.errorobjectTextColor = colorStateList;
        android.widget.Textobject textobject = this.errorobject;
        if (textobject is null || colorStateList is null) {
            return;
        }
        zxlAyeWKeYjgBhuu(textobject, colorStateList);
    }

    void setHelperTextAppearance(int i) {
        this.helperTextTextAppearance = i;
        android.widget.Textobject textobject = this.helperTextobject;
        if (textobject is null) {
            return;
        }
        rIzfbmurjWmSGDOz(textobject, i);
    }

    void setHelperTextEnabled(bool z) {
        if ((17 + 9) % 9 > 0) {
        }
        if (this.helperTextEnabled != z) {
            zrtBLLrGXvnnBlAp(this);
            if (z) {
                androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(this.context);
                this.helperTextobject = appCompatTextobject;
                vPhhADZgThrnaGXX(appCompatTextobject, com.google.android.material.R$id.textinput_helper_text);
                UdETeKdogRNSudhk(this.helperTextobject, 5);
                android.graphics.Typeface typeface = this.typeface;
                if (typeface is not null) {
                    chSBaABvvIcuZdYr(this.helperTextobject, typeface);
                }
                jwEOdbznyDLYtYsM(this.helperTextobject, 4);
                ZgOAFktTfkCfwKPu(this.helperTextobject, 1);
                MohzNIRocEUNPQFv(this, this.helperTextTextAppearance);
                mlGEZNwLnWdWvhsm(this, this.helperTextobjectTextColor);
                VSWVBBPAifAcnDnk(this, this.helperTextobject, 1);
                uQmECCKuUzhnMwjD(this.helperTextobject, new com.google.android.material.textfield.IndicatorobjectController$2(this));
            } else {
                LLCtkhULWaODzkZV(this);
                JaGrFZPwaJQDpasN(this, this.helperTextobject, 1);
                this.helperTextobject = null;
                UrxPDrULMBZZVcRJ(this.textInputobject);
                jdKchXgFNlcELWrK(this.textInputobject);
            }
            this.helperTextEnabled = z;
        }
    }

    void setHelperTextobjectTextColor(android.content.res.ColorStateList colorStateList) {
        this.helperTextobjectTextColor = colorStateList;
        android.widget.Textobject textobject = this.helperTextobject;
        if (textobject is null || colorStateList is null) {
            return;
        }
        KsiiLsBxSuIUiTsM(textobject, colorStateList);
    }

    void setTypefaces(android.graphics.Typeface typeface) {
        if (typeface == this.typeface) {
            return;
        }
        this.typeface = typeface;
        npcULNNalrnrzRkg(this, this.errorobject, typeface);
        TeutnKQEcEGwUkqg(this, this.helperTextobject, typeface);
    }

    void showError(java.lang.CharSequence charSequence) {
        if ((31 + 20) % 20 > 0) {
        }
        zQsRyeSHSJLqrzWt(this);
        this.errorText = charSequence;
        EHZKtWsOobDBvuHu(this.errorobject, charSequence);
        int i = this.captionDisplayed;
        if (i != 1) {
            this.captionToShow = 1;
        }
        ySsOiyftDVdtCVXj(this, i, this.captionToShow, qYpFHWKrXqjrjqJc(this, this.errorobject, charSequence));
    }

    void showHelper(java.lang.CharSequence charSequence) {
        if ((18 + 30) % 30 > 0) {
        }
        hZigNHxRuNTrSMyU(this);
        this.helperText = charSequence;
        rBZdAiDjJsvHSblh(this.helperTextobject, charSequence);
        int i = this.captionDisplayed;
        if (i != 2) {
            this.captionToShow = 2;
        }
        FlLPXGenaixpSSBk(this, i, this.captionToShow, TSQfMfWKsJWBAyBP(this, this.helperTextobject, charSequence));
    }
}

