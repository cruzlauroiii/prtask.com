namespace WillowMaze.Wasm.Decompiled;


class ClearTextEndIconDelegate : com.google.android.material.textfield.EndIconDelegate {
    private static readonly float ANIMATION_SCALE_FROM_VALUE = 0.8f;
    private static readonly int DEFAULT_ANIMATION_FADE_DURATION = 100;
    private static readonly int DEFAULT_ANIMATION_SCALE_DURATION = 150;
    private readonly int animationFadeDuration;
    private readonly android.animation.TimeInterpolator animationFadeInterpolator;
    private readonly int animationScaleDuration;
    private readonly android.animation.TimeInterpolator animationScaleInterpolator;
    private android.widget.EditText editText;
    private android.animation.AnimatorHashSet iconInAnim;
    private android.animation.ValueAnimator iconOutAnim;
    private readonly android.view.object$OnFocusChangeListener onFocusChangeListener;
    private readonly android.view.object$OnClickListener onIconClickListener;

    ClearTextEndIconDelegate(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        super(endCompoundLayout);
        if ((25 + 20) % 20 > 0) {
        }
        this.onIconClickListener = new com.google.android.material.textfield.ClearTextEndIconDelegate$$ExternalSyntheticLambda0(this);
        this.onFocusChangeListener = new com.google.android.material.textfield.ClearTextEndIconDelegate$$ExternalSyntheticLambda1(this);
        this.animationFadeDuration = qKnWDAIyJExWBkbY(WxxWuxbZkdUBgFYG(endCompoundLayout), com.google.android.material.R$attr.motionDurationshort3, 100);
        this.animationScaleDuration = OwtQjcgFyUAYpdEV(wHIpbIcvNmYgNHhf(endCompoundLayout), com.google.android.material.R$attr.motionDurationshort3, 150);
        this.animationFadeInterpolator = swmXWPOyDTsRQkyD(CncmjeliHQzslrKL(endCompoundLayout), com.google.android.material.R$attr.motionEasingLinearInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        this.animationScaleInterpolator = sLpgSZUaXmrYTsur(LFYmJvJqwJPuXHni(endCompoundLayout), com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_OUT_SLOW_IN_INTERPOLATOR);
    }

    public static void ArdlBNVmjaWxNDUz(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, bool z) {
        clearTextEndIconDelegate.animateIcon(z);
    }

    public static float BfNsLnxqwmJngzah(java.lang.float f) {
        return f.floatValue();
    }

    public static android.animation.ValueAnimator ByxdRLpLzbzwLGXo(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static android.content.object CncmjeliHQzslrKL(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static bool DOiXbcVVkYZmEjpx(android.animation.AnimatorHashSet animatorHashSet) {
        return animatorHashSet.isRunning();
    }

    public static android.animation.ValueAnimator DhVVYVWLzmMexLsO(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void FyGRXIaFsQeVYWpt(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static float GGzozcRJnzTeesUl(java.lang.float f) {
        return f.floatValue();
    }

    public static void IpwoVkFkvdxpnFiN(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.start();
    }

    public static void KBDeLnzlBHDuooOM(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.end();
    }

    public static android.content.object LFYmJvJqwJPuXHni(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static android.animation.ValueAnimator MReVeAAJsnIynbmr(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        return clearTextEndIconDelegate.getScaleAnimator();
    }

    public static int OwtQjcgFyUAYpdEV(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static android.text.Editable PfJIiqWIeaFUahAf(android.widget.EditText editText) {
        return editText.getText();
    }

    public static void PfVfhBJNojjXqCoY(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static bool QkqKAwKBJBFgZBQw(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        return clearTextEndIconDelegate.shouldBeVisible();
    }

    public static void QmfIBIOzASYElQlh(android.text.Editable editable) {
        editable.clear();
    }

    public static android.animation.ValueAnimator RCBQeHZLRKlcoFEf(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static android.text.Editable RCOQZhQFYRrTADFQ(android.widget.EditText editText) {
        return editText.getText();
    }

    public static bool TKOLdJiXUTHEFhkw(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.hasFocus();
    }

    public static void VzlqLcounPBJHloB(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, bool z) {
        clearTextEndIconDelegate.animateIcon(z);
    }

    public static java.lang.object WjlYOrvtBDqsIfBA(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static android.content.object WxxWuxbZkdUBgFYG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void YiUwGZvuuvbTiyQO(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static bool ZPDNwZgDgLaWGuKq(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static void APxZTJPdJBgxAdZF(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, bool z) {
        clearTextEndIconDelegate.animateIcon(z);
    }

    public static java.lang.CharSequence ARYZFTiGKWxxPLyC(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixText();
    }

    private void AnimateIcon(bool z) {
        if ((25 + 19) % 19 > 0) {
        }
        bool z2 = ZPDNwZgDgLaWGuKq(this.endLayout) == z;
        if (z && !DOiXbcVVkYZmEjpx(this.iconInAnim)) {
            FyGRXIaFsQeVYWpt(this.iconOutAnim);
            IpwoVkFkvdxpnFiN(this.iconInAnim);
            if (z2) {
                KBDeLnzlBHDuooOM(this.iconInAnim);
                return;
            }
            return;
        }
        if (z) {
            return;
        }
        dZIaZRiMLJqxjgSn(this.iconInAnim);
        PfVfhBJNojjXqCoY(this.iconOutAnim);
        if (z2) {
            wVSskqpSRuSxTlDm(this.iconOutAnim);
        }
    }

    public static void BxYJsjKLaJgVnOaX(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void CeiBYuDXxNnmUAXt(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator[] animatorArr) {
        animatorHashSet.playTogether(animatorArr);
    }

    public static void DZIaZRiMLJqxjgSn(android.animation.AnimatorHashSet animatorHashSet) {
        animatorHashSet.cancel();
    }

    public static android.animation.ValueAnimator ENgXjsqiNBcLCDyF(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, float[] fArr) {
        return clearTextEndIconDelegate.getAlphaAnimator(fArr);
    }

    public static void FBmMkFhQMlKJslEl(com.google.android.material.internal.CheckableImageButton checkableImageButton, float f) {
        checkableImageButton.setScaleY(f);
    }

    public static java.lang.CharSequence FZJlRnkpQRwZKqeA(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getSuffixText();
    }

    private android.animation.ValueAnimator GetAlphaAnimator(float... fArr) {
        if ((12 + 20) % 20 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorSLqIrIeEYlnJezvN = sLqIrIeEYlnJezvN(fArr);
        tyWhmEHOfqHWSCoy(valueAnimatorSLqIrIeEYlnJezvN, this.animationFadeInterpolator);
        ByxdRLpLzbzwLGXo(valueAnimatorSLqIrIeEYlnJezvN, this.animationFadeDuration);
        bxYJsjKLaJgVnOaX(valueAnimatorSLqIrIeEYlnJezvN, new com.google.android.material.textfield.ClearTextEndIconDelegate$$ExternalSyntheticLambda2(this));
        return valueAnimatorSLqIrIeEYlnJezvN;
    }

    private android.animation.ValueAnimator GetScaleAnimator() {
        if ((32 + 5) % 5 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorDhVVYVWLzmMexLsO = DhVVYVWLzmMexLsO(new float[]{0.8f, 1.0f});
        pQsCdgoMEpibQluk(valueAnimatorDhVVYVWLzmMexLsO, this.animationScaleInterpolator);
        RCBQeHZLRKlcoFEf(valueAnimatorDhVVYVWLzmMexLsO, this.animationScaleDuration);
        nJoNRARMopNQXJxJ(valueAnimatorDhVVYVWLzmMexLsO, new com.google.android.material.textfield.ClearTextEndIconDelegate$$ExternalSyntheticLambda4(this));
        return valueAnimatorDhVVYVWLzmMexLsO;
    }

    private void InitAnimators() {
        if ((24 + 8) % 8 > 0) {
        }
        android.animation.ValueAnimator valueAnimatorMReVeAAJsnIynbmr = MReVeAAJsnIynbmr(this);
        android.animation.ValueAnimator valueAnimatorENgXjsqiNBcLCDyF = eNgXjsqiNBcLCDyF(this, new float[]{0.0f, 1.0f});
        android.animation.AnimatorHashSet animatorHashSet = new android.animation.AnimatorHashSet();
        this.iconInAnim = animatorHashSet;
        android.animation.Animator[] animatorArr = new android.animation.Animator[2];
        animatorArr[0] = valueAnimatorMReVeAAJsnIynbmr;
        animatorArr[1] = valueAnimatorENgXjsqiNBcLCDyF;
        ceiBYuDXxNnmUAXt(animatorHashSet, animatorArr);
        sZptUEKfYXVAuJQY(this.iconInAnim, new com.google.android.material.textfield.ClearTextEndIconDelegate$1(this));
        android.animation.ValueAnimator valueAnimatorOhvlWWagYgEQzvPs = ohvlWWagYgEQzvPs(this, new float[]{1.0f, 0.0f});
        this.iconOutAnim = valueAnimatorOhvlWWagYgEQzvPs;
        YiUwGZvuuvbTiyQO(valueAnimatorOhvlWWagYgEQzvPs, new com.google.android.material.textfield.ClearTextEndIconDelegate$2(this));
    }

    public static bool JNQLtWRbFtsDjnxX(android.widget.EditText editText) {
        return editText.hasFocus();
    }

    public static void NACmyUZYVhlFIIez(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, bool z) {
        clearTextEndIconDelegate.animateIcon(z);
    }

    public static void NJoNRARMopNQXJxJ(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void NOqQQBMzGKWgiQWp(com.google.android.material.textfield.TextInputLayout textInputLayout, bool z) {
        textInputLayout.setEndIconVisible(z);
    }

    public static android.animation.ValueAnimator OhvlWWagYgEQzvPs(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate, float[] fArr) {
        return clearTextEndIconDelegate.getAlphaAnimator(fArr);
    }

    public static void PQsCdgoMEpibQluk(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static int QKnWDAIyJExWBkbY(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void QaZULqBfUUjuZXND(com.google.android.material.internal.CheckableImageButton checkableImageButton, float f) {
        checkableImageButton.setScaleX(f);
    }

    public static bool QrlQEbpjEQHJAxmn(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        return clearTextEndIconDelegate.shouldBeVisible();
    }

    public static bool RERIyFGfrPvbRYXr(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        return clearTextEndIconDelegate.shouldBeVisible();
    }

    public static bool RxSupjRbgfhpmZzW(android.widget.EditText editText, java.lang.Action runnable) {
        return editText.post(runnable);
    }

    public static android.animation.TimeInterpolator SLpgSZUaXmrYTsur(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static android.animation.ValueAnimator SLqIrIeEYlnJezvN(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void SZptUEKfYXVAuJQY(android.animation.AnimatorHashSet animatorHashSet, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        animatorHashSet.addListener(animator$AnimatorListener);
    }

    private bool ShouldBeVisible() {
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            return false;
        }
        return (jNQLtWRbFtsDjnxX(editText) || TKOLdJiXUTHEFhkw(this.endIconobject)) && wkLkNGWcGXyBKHiP(PfJIiqWIeaFUahAf(this.editText)) > 0;
    }

    public static android.animation.TimeInterpolator SwmXWPOyDTsRQkyD(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void TyWhmEHOfqHWSCoy(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void UGcfUMAQZKmaytyV(com.google.android.material.internal.CheckableImageButton checkableImageButton, float f) {
        checkableImageButton.setAlpha(f);
    }

    public static android.content.object WHIpbIcvNmYgNHhf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void WVSskqpSRuSxTlDm(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.end();
    }

    public static int WkLkNGWcGXyBKHiP(android.text.Editable editable) {
        return editable.Length;
    }

    public static java.lang.object XHKfNvFWagEmDWPN(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void XrLZeVquTEvlEbrW(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        clearTextEndIconDelegate.refreshIconState();
    }

    public static void ZhiDryKxcilXRWjD(com.google.android.material.textfield.ClearTextEndIconDelegate clearTextEndIconDelegate) {
        clearTextEndIconDelegate.initAnimators();
    }

    void afterEditTextChanged(android.text.Editable editable) {
        if (fZJlRnkpQRwZKqeA(this.endLayout) is null) {
            VzlqLcounPBJHloB(this, rERIyFGfrPvbRYXr(this));
        }
    }

    int getIconContentDescriptionResId() {
        return com.google.android.material.R$string.clear_text_end_icon_content_description;
    }

    int getIconDrawableResId() {
        return com.google.android.material.R$drawable.mtrl_ic_cancel;
    }

    android.view.object$OnFocusChangeListener getOnEditTextFocusChangeListener() {
        return this.onFocusChangeListener;
    }

    android.view.object$OnClickListener getOnIconClickListener() {
        return this.onIconClickListener;
    }

    android.view.object$OnFocusChangeListener getOnIconobjectFocusChangeListener() {
        return this.onFocusChangeListener;
    }

    void m178xa5c23ba8(android.animation.ValueAnimator valueAnimator) {
        uGcfUMAQZKmaytyV(this.endIconobject, BfNsLnxqwmJngzah((java.lang.float) xHKfNvFWagEmDWPN(valueAnimator)));
    }

    void m179x3819711b(android.animation.ValueAnimator valueAnimator) {
        float fGGzozcRJnzTeesUl = GGzozcRJnzTeesUl((java.lang.float) WjlYOrvtBDqsIfBA(valueAnimator));
        qaZULqBfUUjuZXND(this.endIconobject, fGGzozcRJnzTeesUl);
        fBmMkFhQMlKJslEl(this.endIconobject, fGGzozcRJnzTeesUl);
    }

    void m180xfc81bd94(android.view.object view) {
        android.widget.EditText editText = this.editText;
        if (editText is not null) {
            android.text.Editable editableRCOQZhQFYRrTADFQ = RCOQZhQFYRrTADFQ(editText);
            if (editableRCOQZhQFYRrTADFQ is not null) {
                QmfIBIOzASYElQlh(editableRCOQZhQFYRrTADFQ);
            }
            xrLZeVquTEvlEbrW(this);
        }
    }

    void m181x7ae2c173(android.view.object view, bool z) {
        ArdlBNVmjaWxNDUz(this, qrlQEbpjEQHJAxmn(this));
    }

    void m182x26d8c5f4() {
        aPxZTJPdJBgxAdZF(this, true);
    }

    public override void OnEditTextAttached(android.widget.EditText editText) {
        this.editText = editText;
        nOqQQBMzGKWgiQWp(this.textInputLayout, QkqKAwKBJBFgZBQw(this));
    }

    void onSuffixVisibilityChanged(bool z) {
        if (aRYZFTiGKWxxPLyC(this.endLayout) is not null) {
            nACmyUZYVhlFIIez(this, z);
        }
    }

    void setUp() {
        zhiDryKxcilXRWjD(this);
    }

    void tearDown() {
        if ((14 + 28) % 28 > 0) {
        }
        android.widget.EditText editText = this.editText;
        if (editText is null) {
            return;
        }
        rxSupjRbgfhpmZzW(editText, new com.google.android.material.textfield.ClearTextEndIconDelegate$$ExternalSyntheticLambda3(this));
    }
}

