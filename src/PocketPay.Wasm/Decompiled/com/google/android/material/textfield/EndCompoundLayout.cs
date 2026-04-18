namespace WillowMaze.Wasm.Decompiled;


class EndCompoundLayout : android.widget.LinearLayout {
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private android.widget.EditText editText;
    private readonly android.text.TextWatcher editTextWatcher;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener> endIconChangedListeners;
    private readonly com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates endIconDelegates;
    private readonly android.widget.FrameLayout endIconFrame;
    private int endIconMinSize;
    private int endIconMode;
    private android.view.object$OnlongClickListener endIconOnlongClickListener;
    private android.widget.Imageobject$ScaleType endIconScaleType;
    private android.content.res.ColorStateList endIconTintList;
    private android.graphics.PorterDuff$Mode endIconTintMode;
    private readonly com.google.android.material.internal.CheckableImageButton endIconobject;
    private android.view.object$OnlongClickListener errorIconOnlongClickListener;
    private android.content.res.ColorStateList errorIconTintList;
    private android.graphics.PorterDuff$Mode errorIconTintMode;
    private readonly com.google.android.material.internal.CheckableImageButton errorIconobject;
    private bool hintExpanded;
    private readonly com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener onEditTextAttachedListener;
    private java.lang.CharSequence suffixText;
    private readonly android.widget.Textobject suffixTextobject;
    readonly com.google.android.material.textfield.TextInputLayout textInputLayout;
    private androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener touchExplorationStateChangeListener;

    EndCompoundLayout(com.google.android.material.textfield.TextInputLayout textInputLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        super(SZikGzQVWpbhHCnu(textInputLayout));
        if ((18 + 27) % 27 > 0) {
        }
        this.endIconMode = 0;
        this.endIconChangedListeners = new java.util.LinkedHashHashSet<>();
        this.editTextWatcher = new com.google.android.material.textfield.EndCompoundLayout$1(this);
        com.google.android.material.textfield.EndCompoundLayout$2 endCompoundLayout$2 = new com.google.android.material.textfield.EndCompoundLayout$2(this);
        this.onEditTextAttachedListener = endCompoundLayout$2;
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) FrhlpqRUPgEoSXfR(KTtlJPbsmvYGAiFF(this), "accessibility");
        this.textInputLayout = textInputLayout;
        uVEmkBnjSdOtjzwH(this, 8);
        QECZkADfOrmzWDZf(this, 0);
        ZiSsBecfmwOQDGcP(this, new android.widget.FrameLayout$LayoutParams(-2, -1, 8388613));
        android.widget.FrameLayout frameLayout = new android.widget.FrameLayout(UayjxwlXiYfiEWQU(this));
        this.endIconFrame = frameLayout;
        uRCzkTFJvZEXohiE(frameLayout, 8);
        XJbfOfErwcdwZeTt(frameLayout, new android.widget.LinearLayout$LayoutParams(-2, -1));
        android.view.LayoutInflater layoutInflaterRPqAduJpocfgNQMS = RPqAduJpocfgNQMS(ZfAakHnPGXlAcjcA(this));
        com.google.android.material.internal.CheckableImageButton checkableImageButtonKjlvULGbBOTpyCLZ = kjlvULGbBOTpyCLZ(this, this, layoutInflaterRPqAduJpocfgNQMS, com.google.android.material.R$id.text_input_error_icon);
        this.errorIconobject = checkableImageButtonKjlvULGbBOTpyCLZ;
        com.google.android.material.internal.CheckableImageButton checkableImageButtonUzdJwrFyTLESlShk = UzdJwrFyTLESlShk(this, frameLayout, layoutInflaterRPqAduJpocfgNQMS, com.google.android.material.R$id.text_input_end_icon);
        this.endIconobject = checkableImageButtonUzdJwrFyTLESlShk;
        this.endIconDelegates = new com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates(this, tintTypedArray);
        androidx.appcompat.widget.AppCompatTextobject appCompatTextobject = new androidx.appcompat.widget.AppCompatTextobject(ZMIlDnXyiPQKxsdH(this));
        this.suffixTextobject = appCompatTextobject;
        VtWOHowXfeVKRYJT(this, tintTypedArray);
        QbnCLtJiTLjLnXek(this, tintTypedArray);
        aXfJkSzdUemKHbrf(this, tintTypedArray);
        NfbNCUfuVUVdbQtz(frameLayout, checkableImageButtonUzdJwrFyTLESlShk);
        YIPorgvaAFFNwDcm(this, appCompatTextobject);
        YHFEWLqYQtzeONtv(this, frameLayout);
        bwcUFbLLlJpNoOQS(this, checkableImageButtonKjlvULGbBOTpyCLZ);
        tKnDfQSngINhDvLO(textInputLayout, endCompoundLayout$2);
        GUPjeZZqAWrNRsQQ(this, new com.google.android.material.textfield.EndCompoundLayout$3(this));
    }

    public static android.content.res.ColorStateList ADckkkJhwKKXiiKG(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void ARGEDEusOxKElGfg(android.widget.EditText editText, android.view.object$OnFocusChangeListener view$OnFocusChangeListener) {
        editText.setOnFocusChangeListener(view$OnFocusChangeListener);
    }

    public static android.graphics.drawable.Drawable ATTljsQkNpatJUiO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getErrorIconDrawable();
    }

    public static int AdfvaPdPwqlUMRIo(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getVisibility();
    }

    public static void AepozgEsTwDAXbMB(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        checkableImageButton.jumpDrawablesToCurrentState();
    }

    public static void BBodoKYEgMFjUyew(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextobjectPadding();
    }

    public static bool BaTJjlxzBNoRHLwC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool BfJsBTlGCgtjFLRf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isErrorEnabled();
    }

    public static void BlyWgfckFyyvTKTh(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static java.lang.object BvbKNXXLLFrMCLfX(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool CKBOEoWvygbejdmW(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.isIconCheckable();
    }

    public static void CMmFxbHnXfEtXyUR(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconCheckable(z);
    }

    public static bool CklNsDsgzXNoRVot(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static com.google.android.material.textfield.EndIconDelegate DCtObEAnNNeVbVVn(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static java.lang.CharSequence DSEycbpguBfrLPzp(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void DbDzSokZPDFlERyG(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setCheckable(z);
    }

    public static bool EKtiEXWwPeMIUUFE(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.performClick();
    }

    public static void EgFHnhwykjcFcPaJ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateErrorIconVisibility();
    }

    public static void EohSJJFsoANFajVT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMode(i);
    }

    public static bool FAdtcwhvyhsybDXF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int FKhUmyNOqyoUArQU(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool FdavETBFFrLaKjbF(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.isCheckable();
    }

    public static java.lang.object FrhlpqRUPgEoSXfR(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool FwPDBVVGLqgDwltD(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.isChecked();
    }

    public static void GJedaMKBibNeJwgH(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setPasswordVisibilityToggleContentDescription(charSequence);
    }

    public static void GUPjeZZqAWrNRsQQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnAttachStateChangeListener view$OnAttachStateChangeListener) {
        endCompoundLayout.addOnAttachStateChangeListener(view$OnAttachStateChangeListener);
    }

    public static void GZXDAPAaGpyTcEdz(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setPressable(z);
    }

    public static android.content.res.Resources GasQoUbYKszfcXIf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getResources();
    }

    public static int GcjiXeNiRbzpNcko(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static android.view.object GgKRSYQvwPxUjRdQ(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static int GylXwKPVKpNprYsc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getBoxBackgroundMode();
    }

    public static bool HDGCbISxnUDJRxSl(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static bool HHJBaRjEIRmnjPbx(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.hasEndIcon();
    }

    public static void HMUGXVRXuUdKzIpu(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.CharSequence charSequence) {
        checkableImageButton.setContentDescription(charSequence);
    }

    public static void HSIfDZZYBNKCfIeK(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnlongClickListener(checkableImageButton, view$OnlongClickListener);
    }

    public static int HwnCcXFuTsJRnRaO(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getIconDrawableResId();
    }

    public static android.graphics.PorterDuff$Mode HxhlrOAPZrnClurv(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static int IARsmxIfgYrDyRrz(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void ILzefWXCKjXvJBob(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.content.res.ColorStateList colorStateList) {
        endCompoundLayout.setSuffixTextColor(colorStateList);
    }

    public static bool IQDbuGDQPvNxAPDN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool ITZFMKBdxyVVRKnH(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.isIconActivable();
    }

    public static void IWfdQAptqHWlQxSW(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.CharSequence charSequence) {
        checkableImageButton.setContentDescription(charSequence);
    }

    public static android.graphics.drawable.Drawable IbeFfFVzXEyPxsIA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static bool IqPhLmsMoqguLxhD(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static bool IsJmmqYLKblWdHkB(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static com.google.android.material.textfield.EndIconDelegate IxMctwGVWpBanYNZ(com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates endCompoundLayout$EndIconDelegates, int i) {
        return endCompoundLayout$EndIconDelegates[i);
    }

    public static bool JATdTDTrPCaAawun(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static void JFLWJLcVCbIFIozF(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void JbmkmAuHmDUUUnXc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateEndLayoutVisibility();
    }

    public static void JcFRrgvWlxKSsUup(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setActivated(z);
    }

    public static com.google.android.material.textfield.EndIconDelegate JglAKWENpAIRKFTC(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static bool KNcweeTCKvXoJLTi(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static void KQMYEPABJFKghUWQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconDrawable(i);
    }

    public static android.content.object KTtlJPbsmvYGAiFF(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void KcohEKQRtImNNiNB(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setErrorIconDrawable(drawable);
    }

    public static android.content.res.ColorStateList KjEJqSkxFzDuXUHI(android.widget.Textobject textobject) {
        return textobject.getTextColors();
    }

    public static void KnnrWAeIWNFHQYGT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextVisibility();
    }

    public static bool KqkKCicYIXuodZEg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void LemHqZGCjiwWlhdY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshEndIconDrawableState();
    }

    public static void LoNkLdJekBmGNAuA(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setChecked(z);
    }

    public static int MYornsUiAVKGCusS(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return androidx.core.view.MarginLayoutParamsCompat.getMarginStart(viewGroup$MarginLayoutParams);
    }

    public static void MrnfxxahtRGPKrNc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextVisibility();
    }

    public static void MxWpMDqdFWTVXFAM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setEndIconDrawable(drawable);
    }

    public static android.graphics.drawable.Drawable NHZAZcbYDKGWwunN(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void NdLPxGXgzNDhzxXE(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setEndIconContentDescription(charSequence);
    }

    public static void NfbNCUfuVUVdbQtz(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static int NiASJuuaGeRNmfML(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void NxSzqYvSPkbMILCD(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconCheckable(z);
    }

    public static bool OFiHFLmfHcqhBXKB(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener) {
        return androidx.core.view.accessibility.AccessibilityManagerCompat.addTouchExplorationStateChangeListener(accessibilityManager, accessibilityManagerCompat$TouchExplorationStateChangeListener);
    }

    public static void OdYjRoSmFMIIhcNZ(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static android.content.res.ColorStateList OegpkVGxwRzCdeLT(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static void OyZWtmqYliGvQnxi(android.widget.Textobject textobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        textobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void PDeDEKvPnKvVOTUw(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.addTouchExplorationStateChangeListenerIfNeeded();
    }

    public static void PKpkWlIpyOgPdwbx(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static void PrTztmSYNhraoSuS(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        com.google.android.material.textfield.IconHelper.setIconScaleType(checkableImageButton, imageobject$ScaleType);
    }

    public static android.view.objectGroup$LayoutParams QBYdHErAZTmRqUXC(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getLayoutParams();
    }

    public static void QECZkADfOrmzWDZf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setOrientation(i);
    }

    public static bool QJEALvrECXtzzaAe(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.isIconCheckable();
    }

    public static android.view.object$OnFocusChangeListener QMSYhCbVDoMoXlfn(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getOnIconobjectFocusChangeListener();
    }

    public static void QRnyMSXKFhTfxbIw(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static java.lang.CharSequence QUJyMpVJSJBuqvLd(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static int QYdDSrZskVcCKMmD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void QbnCLtJiTLjLnXek(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        endCompoundLayout.initEndIconobject(tintTypedArray);
    }

    public static int RACCXYLpIhnBADaE(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static int RCVKTJOOypUpfboy(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getErrorCurrentTextColors();
    }

    public static void RMnNWyyQPqjNuTtI(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endCompoundLayout.tearDownDelegate(endIconDelegate);
    }

    public static void RNCCkkNrdqoZYRLp(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static android.view.LayoutInflater RPqAduJpocfgNQMS(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void RTMyifbLUynpVRLf(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        com.google.android.material.textfield.IconHelper.setIconScaleType(checkableImageButton, imageobject$ScaleType);
    }

    public static int RkAmlqfKJrHTJAfU(com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates endCompoundLayout$EndIconDelegates) {
        return com.google.android.material.textfield.EndCompoundLayout$EndIconDelegates.access$500(endCompoundLayout$EndIconDelegates);
    }

    public static void RucceeaCIhuPdbAn(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        endCompoundLayout.setEndIconScaleType(imageobject$ScaleType);
    }

    public static bool RyKgkbKQBEBpeprO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static bool STmlIWllRqrGhMof(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.hasEndIcon();
    }

    public static android.content.object SZikGzQVWpbhHCnu(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getobject();
    }

    public static int SmNYNjfezgEBvScb(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getVisibility();
    }

    public static bool SmeeHnmyvjdxqmvN(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.isActivated();
    }

    public static bool SxmsnuXivOqTmTuc(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void THAhPCnKaOZRyaoM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMode(i);
    }

    public static void TRKGECNJlwYqtPvw(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static void TRbuXYFqcEOqLspT(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList) {
        com.google.android.material.textfield.IconHelper.refreshIconDrawableState(textInputLayout, checkableImageButton, colorStateList);
    }

    public static android.content.res.Resources TjMDZmEHTBMALNFk(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getResources();
    }

    public static void TmDcrInBqPNuyhUc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateSuffixTextobjectPadding();
    }

    public static android.graphics.drawable.Drawable TmYInlFdPDwOgfjv(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDrawable();
    }

    public static android.content.object TutBalojzZDLfRwd(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static int TwPpPxxeEbUBLtHg(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getMeasuredWidth();
    }

    public static void TwhsHNreqbEReyGE(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateErrorIconVisibility();
    }

    public static android.content.object TzADKBeSFRgFnjJf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static android.content.object UayjxwlXiYfiEWQU(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void UcjgGLkQnGdvMjse(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        com.google.android.material.textfield.IconHelper.setIconMinSize(checkableImageButton, i);
    }

    public static com.google.android.material.internal.CheckableImageButton UzdJwrFyTLESlShk(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.objectGroup viewGroup, android.view.LayoutInflater layoutInflater, int i) {
        return endCompoundLayout.createIconobject(viewGroup, layoutInflater, i);
    }

    public static android.view.object$OnFocusChangeListener VDrEgLebutWmnSTN(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getOnEditTextFocusChangeListener();
    }

    public static void VgMmbJxZDFuYKMKE(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setPasswordVisibilityToggleDrawable(drawable);
    }

    public static java.lang.stringBuilder VhfpzZbmIRiAqYuk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VtWOHowXfeVKRYJT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        endCompoundLayout.initErrorIconobject(tintTypedArray);
    }

    public static android.content.object VwPposxogkuARGSY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static bool VwgyyJzxUeNPJnxP(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void WFmSCnbGRDaZxNgS(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        com.google.android.material.textfield.IconHelper.setIconMinSize(checkableImageButton, i);
    }

    public static androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener WvtgYzJzEbrqZabD(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getTouchExplorationStateChangeListener();
    }

    public static void XJbfOfErwcdwZeTt(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static android.content.object XMIVPoHgBgWTCrGk(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void XOLZvWLkzcYomKPG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconVisible(z);
    }

    public static void XfFIYWxlNlSHXziS(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static android.content.object YEmFEBSoESuOwQQd(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void YHFEWLqYQtzeONtv(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object view) {
        endCompoundLayout.addobject(view);
    }

    public static void YIPorgvaAFFNwDcm(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object view) {
        endCompoundLayout.addobject(view);
    }

    public static bool YLTLkIshKPiwFwbO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static java.lang.CharSequence YMUyKEDTfiRAFHsW(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getContentDescription();
    }

    public static android.view.object$OnFocusChangeListener YWQUvwgKlAqSScWb(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getOnEditTextFocusChangeListener();
    }

    public static bool YxCrirFoSLOAGTBB(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static java.lang.CharSequence ZFwueBxJukGDxbDx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static android.content.object ZMIlDnXyiPQKxsdH(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void ZNHvsNArcePTfIBy(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnClickListener(checkableImageButton, view$OnClickListener, view$OnlongClickListener);
    }

    public static void ZOpITNHMoetZjILh(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.removeTouchExplorationStateChangeListenerIfNeeded();
    }

    public static android.content.object ZfAakHnPGXlAcjcA(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void ZgNYtPgyHppmdpuT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.addTouchExplorationStateChangeListenerIfNeeded();
    }

    public static void ZiSsBecfmwOQDGcP(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        endCompoundLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void ZpFyxRUSiOINKuUp(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void ZuMzLjfnfXUWWswo(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnFocusChangeListener view$OnFocusChangeListener) {
        checkableImageButton.setOnFocusChangeListener(view$OnFocusChangeListener);
    }

    public static int ZwYYRHLBPurJUPhg(android.widget.EditText editText) {
        return editText.getPaddingTop();
    }

    public static android.content.object AIgBgtxQfEZqeHbc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static void ALMBRgRjzhBuwOnW(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setFocusable(z);
    }

    public static int AXeSNfgtnFUWWIEH(android.view.object view) {
        return androidx.core.view.objectCompat.getPaddingEnd(view);
    }

    public static void AXfJkSzdUemKHbrf(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        endCompoundLayout.initSuffixTextobject(tintTypedArray);
    }

    public static bool AaNaAqYuljWaYeMa(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    static android.widget.EditText access$000(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.editText;
    }

    static android.widget.EditText access$002(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.widget.EditText editText) {
        endCompoundLayout.editText = editText;
        return editText;
    }

    static android.text.TextWatcher access$100(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.editTextWatcher;
    }

    static void access$200(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        mVyZmxpTlMKvzIoh(endCompoundLayout, endIconDelegate);
    }

    static void access$300(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        PDeDEKvPnKvVOTUw(endCompoundLayout);
    }

    static void access$400(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        ZOpITNHMoetZjILh(endCompoundLayout);
    }

    private void AddTouchExplorationStateChangeListenerIfNeeded() {
        if (this.touchExplorationStateChangeListener is null || this.accessibilityManager is null || !spIQdjVTijGaRChR(this)) {
            return;
        }
        OFiHFLmfHcqhBXKB(this.accessibilityManager, this.touchExplorationStateChangeListener);
    }

    public static void AqkSlBRSqAvVgmQT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setEndIconContentDescription(charSequence);
    }

    public static bool BKiYWVBOAKAEZTGl(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.object$OnClickListener bUpqNxrjzbPsLwtY(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getOnIconClickListener();
    }

    public static void BkKPgHWoDsdXHVil(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshEndIconDrawableState();
    }

    public static bool BkWJERrGKxWAomsx(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.isChecked();
    }

    public static void BwcUFbLLlJpNoOQS(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object view) {
        endCompoundLayout.addobject(view);
    }

    public static bool CFvbnkPMWOwbKxSO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static java.lang.stringBuilder CIemxGqGbUoFnanZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool CKSfhqBuvohrdelu(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static void CLVSOgGTOEgmoquE(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setVisibility(i);
    }

    public static int CNFRLCrfaVGrfelZ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static android.content.res.ColorStateList CPCWaoPTzrsoFImI(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, tintTypedArray, i);
    }

    public static com.google.android.material.textfield.EndIconDelegate CPNhGDHUKnxsKBGM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    private com.google.android.material.internal.CheckableImageButton CreateIconobject(android.view.objectGroup viewGroup, android.view.LayoutInflater layoutInflater, int i) {
        if ((1 + 13) % 13 > 0) {
        }
        com.google.android.material.internal.CheckableImageButton checkableImageButton = (com.google.android.material.internal.CheckableImageButton) GgKRSYQvwPxUjRdQ(layoutInflater, com.google.android.material.R$layout.design_text_input_end_icon, viewGroup, false);
        mSLQGnvDNjnakdwy(checkableImageButton, i);
        wzOPzouQutIzPYml(checkableImageButton);
        if (xJxestuWIiZuLpMs(TzADKBeSFRgFnjJf(this))) {
            nNWPUbahJZJhLHHk((android.view.objectGroup$MarginLayoutParams) dvyUMCwGkdlAHLBS(checkableImageButton), 0);
        }
        return checkableImageButton;
    }

    public static bool DBNUDAJDjGNhUHon(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static void DYhTcpxtRqUYSBbG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.refreshIconState(z);
    }

    public static void DazLVETNIOnObctQ(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static bool DedNxvSoDlYFXGZk(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateDummyDrawables();
    }

    private void DispatchOnEndIconChanged(int i) {
        if ((9 + 17) % 17 > 0) {
        }
        java.util.IEnumerator itFQGBtIEVPnbxJpws = fQGBtIEVPnbxJpws(this.endIconChangedListeners);
        while (wTOfhUpPnuwYYdVQ(itFQGBtIEVPnbxJpws)) {
            mgcFjpbrZsuXTvCP((com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener) BvbKNXXLLFrMCLfX(itFQGBtIEVPnbxJpws), this.textInputLayout, i);
        }
    }

    public static android.graphics.PorterDuff$Mode dsuxoOPjrpBmQDvz(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable DtYMKIibxDtNkERj(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.view.objectGroup$LayoutParams dvyUMCwGkdlAHLBS(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getLayoutParams();
    }

    public static bool ENYhkTGshWyasDza(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.hasEndIcon();
    }

    public static void EcqzFWHnDsKVrfUH(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static int EpgNOintvtPbBSFl(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endCompoundLayout.getIconResId(endIconDelegate);
    }

    public static android.content.object FAczMcfclQYFPMtC(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static android.content.object FNSCvPFKFefndrCh(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getobject();
    }

    public static java.util.IEnumerator FQGBtIEVPnbxJpws(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static android.graphics.drawable.Drawable FoyiydIFzLkEzqTB(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDrawable();
    }

    public static void FqsYQtGnFEsKyctc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.removeTouchExplorationStateChangeListenerIfNeeded();
    }

    public static void FtOkOdRcwpocgQdO(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setClickable(z);
    }

    private int GetIconResId(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        int iRkAmlqfKJrHTJAfU = RkAmlqfKJrHTJAfU(this.endIconDelegates);
        return iRkAmlqfKJrHTJAfU != 0 ? iRkAmlqfKJrHTJAfU : HwnCcXFuTsJRnRaO(endIconDelegate);
    }

    public static void GfcXveuwjSoTXYEv(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.graphics.drawable.Drawable drawable) {
        endCompoundLayout.setErrorIconDrawable(drawable);
    }

    public static void GgdcCRQUKzXohKyZ(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static int GlKOJfhtcygaGSUY(android.widget.EditText editText) {
        return editText.getPaddingBottom();
    }

    public static bool HDvNxHMMdfCwJVcD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void HWsoskwwFicgKTLk(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.object$OnClickListener view$OnClickListener) {
        endCompoundLayout.setEndIconOnClickListener(view$OnClickListener);
    }

    public static bool HgztgnQfSPCcPONt(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isErrorIconVisible();
    }

    public static void HnEXvcgaTeAODQCW(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshEndIconDrawableState();
    }

    public static bool HrvWbvXvFqXIgQxs(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateDummyDrawables();
    }

    public static android.graphics.drawable.Drawable HyKpHLRnZyhgCuQy(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void IOEOZzVGyNxQYBmD(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static bool IXCJpaGtmNDrPOjX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    private void InitEndIconobject(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((29 + 30) % 30 > 0) {
        }
        if (!ohlWVKgUJckvvsKM(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleEnabled)) {
            if (xFVnMGXyxAxlpxEY(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconTint)) {
                this.endIconTintList = OegpkVGxwRzCdeLT(fAczMcfclQYFPMtC(this), tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconTint);
            }
            if (CklNsDsgzXNoRVot(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconTintMode)) {
                this.endIconTintMode = dsuxoOPjrpBmQDvz(QYdDSrZskVcCKMmD(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconTintMode, -1), null);
            }
        }
        if (VwgyyJzxUeNPJnxP(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconMode)) {
            pMBTdXejvjyFFAvq(this, cNFRLCrfaVGrfelZ(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconMode, 0));
            if (hDvNxHMMdfCwJVcD(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconContentDescription)) {
                aqkSlBRSqAvVgmQT(this, ZFwueBxJukGDxbDx(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconContentDescription));
            }
            NxSzqYvSPkbMILCD(this, HDGCbISxnUDJRxSl(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconCheckable, true));
        } else if (qAAWlqQmfiJKimOa(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleEnabled)) {
            if (BaTJjlxzBNoRHLwC(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleTint)) {
                this.endIconTintList = ADckkkJhwKKXiiKG(aIgBgtxQfEZqeHbc(this), tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleTint);
            }
            if (iXCJpaGtmNDrPOjX(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleTintMode)) {
                this.endIconTintMode = nvsPaqyFpjUvBzVE(zAWoLCXffNlXCLkG(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleTintMode, -1), null);
            }
            wtskrVtJfioNYwaG(this, RyKgkbKQBEBpeprO(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleEnabled, false) ? 1 : 0);
            NdLPxGXgzNDhzxXE(this, rjAgakTCldpCRvFp(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_passwordToggleContentDescription));
        }
        xMjXGQqeoCRzMpbp(this, uopwdxVijGmxdQtg(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconMinSize, FKhUmyNOqyoUArQU(rKuXhdJPAKxrRAJV(this), com.google.android.material.R$dimen.mtrl_min_touch_target_size)));
        if (KqkKCicYIXuodZEg(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconScaleType)) {
            RucceeaCIhuPdbAn(this, xviQECaIVinACVaQ(RACCXYLpIhnBADaE(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_endIconScaleType, -1)));
        }
    }

    private void InitErrorIconobject(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((16 + 27) % 27 > 0) {
        }
        if (vhUNXianoAESBnAX(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconTint)) {
            this.errorIconTintList = cPCWaoPTzrsoFImI(XMIVPoHgBgWTCrGk(this), tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconTint);
        }
        if (IQDbuGDQPvNxAPDN(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconTintMode)) {
            this.errorIconTintMode = HxhlrOAPZrnClurv(uSpxjwWyZZRFOGuI(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconTintMode, -1), null);
        }
        if (FAdtcwhvyhsybDXF(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconDrawable)) {
            KcohEKQRtImNNiNB(this, IbeFfFVzXEyPxsIA(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_errorIconDrawable));
        }
        IWfdQAptqHWlQxSW(this.errorIconobject, DSEycbpguBfrLPzp(GasQoUbYKszfcXIf(this), com.google.android.material.R$string.error_icon_content_description));
        ixVwJklvCCKGCUBK(this.errorIconobject, 2);
        ftOkOdRcwpocgQdO(this.errorIconobject, false);
        GZXDAPAaGpyTcEdz(this.errorIconobject, false);
        aLMBRgRjzhBuwOnW(this.errorIconobject, false);
    }

    private void InitSuffixTextobject(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        if ((7 + 7) % 7 > 0) {
        }
        ZpFyxRUSiOINKuUp(this.suffixTextobject, 8);
        rAlaEPjIlSHQZwAO(this.suffixTextobject, com.google.android.material.R$id.textinput_suffix_text);
        OyZWtmqYliGvQnxi(this.suffixTextobject, new android.widget.LinearLayout$LayoutParams(-2, -2, 80.0f));
        kFWpmhKNVxmlkGiq(this.suffixTextobject, 1);
        oUXnSnWnDJTMLydM(this, NiASJuuaGeRNmfML(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_suffixTextAppearance, 0));
        if (IsJmmqYLKblWdHkB(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_suffixTextColor)) {
            ILzefWXCKjXvJBob(this, rSTAHNcoVCgKJquF(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_suffixTextColor));
        }
        uNflrAjaIilRXHoi(this, pGEXiDWtVtyVbOxJ(tintTypedArray, com.google.android.material.R$styleable.TextInputLayout_suffixText));
    }

    public static int IpfHFMSVwWiirxHK(android.widget.Textobject textobject) {
        return textobject.getVisibility();
    }

    public static void IxVwJklvCCKGCUBK(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void JCQTPsToZUjtpMPM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endCompoundLayout.setUpDelegate(endIconDelegate);
    }

    public static void JKFSgKuDIZvpMZuQ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateEndLayoutVisibility();
    }

    public static void JMKhxtbvbCGeSMDY(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static void JgtJLsvyOwEDVnCo(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endIconDelegate.tearDown();
    }

    public static android.graphics.drawable.Drawable JyQauENAuuQjOcAA(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static void KFWpmhKNVxmlkGiq(android.view.object view, int i) {
        androidx.core.view.objectCompat.setAccessibilityLiveRegion(view, i);
    }

    public static void KGoecwLtXwSIgAfL(com.google.android.material.internal.CheckableImageButton checkableImageButton, java.lang.CharSequence charSequence) {
        checkableImageButton.setContentDescription(charSequence);
    }

    public static bool KPVEhViILvXPMYxf(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.shouldShowError();
    }

    public static void KPlGuFmnZqoFNfNq(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static com.google.android.material.internal.CheckableImageButton KjlvULGbBOTpyCLZ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, android.view.objectGroup viewGroup, android.view.LayoutInflater layoutInflater, int i) {
        return endCompoundLayout.createIconobject(viewGroup, layoutInflater, i);
    }

    public static android.graphics.drawable.Drawable KpCrTIgztFcpLtNU(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static void KsArBOSpmWVClYQV(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static com.google.android.material.textfield.EndIconDelegate KsQcEvxPWyoBOzRo(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static android.content.res.Resources KtfKflIwaDnXjyOI(android.content.object context) {
        return context.getResources();
    }

    public static bool LBLRMazDuHvpMgfB(android.view.accessibility.AccessibilityManager accessibilityManager, androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener) {
        return androidx.core.view.accessibility.AccessibilityManagerCompat.removeTouchExplorationStateChangeListener(accessibilityManager, accessibilityManagerCompat$TouchExplorationStateChangeListener);
    }

    public static void LFCiSnfVPlXerpJs(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static int LShRuDIBvBiFOQjX(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getIconContentDescriptionResId();
    }

    public static com.google.android.material.textfield.EndIconDelegate LUpZwMlYPFKEODve(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconDelegate();
    }

    public static void LYHLLKlTGqciInPr(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endCompoundLayout.setOnFocusChangeListenersIfNeeded(endIconDelegate);
    }

    public static bool LtYlUbbEoQxtXpyT(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static bool LyfodpLxqVLsGGRM(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.isIconActivated();
    }

    public static void MLeJCfqdaTzAnWPS(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endIconDelegate.setUp();
    }

    public static void MSLQGnvDNjnakdwy(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setId(i);
    }

    public static void MVyZmxpTlMKvzIoh(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        endCompoundLayout.setOnFocusChangeListenersIfNeeded(endIconDelegate);
    }

    public static void MaLbzXepGGbclxhp(com.google.android.material.textfield.EndIconDelegate endIconDelegate, android.widget.EditText editText) {
        endIconDelegate.onEditTextAttached(editText);
    }

    public static void MgcFjpbrZsuXTvCP(com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener, com.google.android.material.textfield.TextInputLayout textInputLayout, int i) {
        textInputLayout$OnEndIconChangedListener.onEndIconChanged(textInputLayout, i);
    }

    public static void MtPTusMpiUyhSqCY(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnClickListener(checkableImageButton, view$OnClickListener, view$OnlongClickListener);
    }

    public static void NNWPUbahJZJhLHHk(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static java.lang.CharSequence NQaFsbHfnnWlBNOH(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getContentDescription();
    }

    public static void NhJPbZLkgVAJJIFE(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.updateEndLayoutVisibility();
    }

    public static bool NqzUTVGMurIfskfc(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.isEndIconVisible();
    }

    public static android.graphics.PorterDuff$Mode nvsPaqyFpjUvBzVE(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static bool NwevlgOAqpbungly(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.updateDummyDrawables();
    }

    public static void ORNMrVSEOCiAbWJL(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        com.google.android.material.textfield.IconHelper.setIconOnlongClickListener(checkableImageButton, view$OnlongClickListener);
    }

    public static void OUXnSnWnDJTMLydM(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setSuffixTextAppearance(i);
    }

    public static android.graphics.drawable.Drawable OdaVVbEaZCypTRIe(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static bool OhlWVKgUJckvvsKM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable OpdooHqsRWBAIgeW(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void OtzxVQbVfWikxBVa(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        com.google.android.material.textfield.IconHelper.applyIconTint(textInputLayout, checkableImageButton, colorStateList, porterDuff$Mode);
    }

    public static java.lang.CharSequence PGEXiDWtVtyVbOxJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void PMBTdXejvjyFFAvq(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMode(i);
    }

    public static void PYQSkyxiGatLMAgO(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshErrorIconDrawableState();
    }

    public static android.graphics.drawable.Drawable PfmtxShidzEEYRjU(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static bool PyLkdxuIrkvLOPfu(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.performClick();
    }

    public static android.content.res.Resources PzszbxGQpDSmWKPg(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getResources();
    }

    public static bool QAAWlqQmfiJKimOa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void QDCAanwfbxRnlZNc(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        checkableImageButton.jumpDrawablesToCurrentState();
    }

    public static int QFUJeqiWValpCFNH(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getVisibility();
    }

    public static bool QtchwwUfkiEOCKHY(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.shouldTintIconOnError();
    }

    public static void QzuonjgEEkZJEyml(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setVisibility(i);
    }

    public static void RAlaEPjIlSHQZwAO(android.widget.Textobject textobject, int i) {
        textobject.setId(i);
    }

    public static android.content.res.Resources RKuXhdJPAKxrRAJV(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getResources();
    }

    public static android.content.res.ColorStateList RSTAHNcoVCgKJquF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void RZpeQVLZLDRALUwv(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    private void RemoveTouchExplorationStateChangeListenerIfNeeded() {
        android.view.accessibility.AccessibilityManager accessibilityManager;
        androidx.core.view.accessibility.AccessibilityManagerCompat$TouchExplorationStateChangeListener accessibilityManagerCompat$TouchExplorationStateChangeListener = this.touchExplorationStateChangeListener;
        if (accessibilityManagerCompat$TouchExplorationStateChangeListener is null || (accessibilityManager = this.accessibilityManager) is null) {
            return;
        }
        lBLRMazDuHvpMgfB(accessibilityManager, accessibilityManagerCompat$TouchExplorationStateChangeListener);
    }

    public static bool RgtrObqzFcHlJRlK(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.isIconChecked();
    }

    public static java.lang.CharSequence RjAgakTCldpCRvFp(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getText(i);
    }

    public static void SSEQkXhaFQAPphOR(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void ScWjYvwslLJsWKbY(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setEndIconContentDescription(charSequence);
    }

    private void SetOnFocusChangeListenersIfNeeded(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        if ((32 + 9) % 9 > 0) {
        }
        if (this.editText is not null) {
            if (VDrEgLebutWmnSTN(endIconDelegate) is not null) {
                ARGEDEusOxKElGfg(this.editText, YWQUvwgKlAqSScWb(endIconDelegate));
            }
            if (uctSrHrhsSAeCJJY(endIconDelegate) is null) {
                return;
            }
            ZuMzLjfnfXUWWswo(this.endIconobject, QMSYhCbVDoMoXlfn(endIconDelegate));
        }
    }

    private void SetUpDelegate(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        mLeJCfqdaTzAnWPS(endIconDelegate);
        this.touchExplorationStateChangeListener = WvtgYzJzEbrqZabD(endIconDelegate);
        ZgNYtPgyHppmdpuT(this);
    }

    public static int ShSKXqquMpgCSUJy(android.widget.FrameLayout frameLayout) {
        return frameLayout.getVisibility();
    }

    public static bool SpIQdjVTijGaRChR(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static java.lang.CharSequence SwfrcDFGBWPCkgWt(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        return endCompoundLayout.getEndIconContentDescription();
    }

    public static void SwxccTiCWThOwtED(com.google.android.material.textfield.EndIconDelegate endIconDelegate, bool z) {
        endIconDelegate.onSuffixVisibilityChanged(z);
    }

    public static void TCvPJhujiauDwrJU(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void TKnDfQSngINhDvLO(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.textfield.TextInputLayout$OnEditTextAttachedListener textInputLayout$OnEditTextAttachedListener) {
        textInputLayout.addOnEditTextAttachedListener(textInputLayout$OnEditTextAttachedListener);
    }

    private void TearDownDelegate(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        fqsYQtGnFEsKyctc(this);
        this.touchExplorationStateChangeListener = null;
        jgtJLsvyOwEDVnCo(endIconDelegate);
    }

    public static void TiJvCJaGklesrTLt(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconContentDescription(i);
    }

    private void TintEndIconOnError(bool z) {
        if ((24 + 16) % 16 > 0) {
        }
        if (!z || TmYInlFdPDwOgfjv(this) is null) {
            BlyWgfckFyyvTKTh(this.textInputLayout, this.endIconobject, this.endIconTintList, this.endIconTintMode);
            return;
        }
        android.graphics.drawable.Drawable drawableNHZAZcbYDKGWwunN = NHZAZcbYDKGWwunN(opdooHqsRWBAIgeW(foyiydIFzLkEzqTB(this)));
        ksArBOSpmWVClYQV(drawableNHZAZcbYDKGWwunN, RCVKTJOOypUpfboy(this.textInputLayout));
        dazLVETNIOnObctQ(this.endIconobject, drawableNHZAZcbYDKGWwunN);
    }

    public static void UNflrAjaIilRXHoi(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, java.lang.CharSequence charSequence) {
        endCompoundLayout.setSuffixText(charSequence);
    }

    public static void URCzkTFJvZEXohiE(android.widget.FrameLayout frameLayout, int i) {
        frameLayout.setVisibility(i);
    }

    public static int USpxjwWyZZRFOGuI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void UVEmkBnjSdOtjzwH(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setVisibility(i);
    }

    public static android.view.object$OnFocusChangeListener uctSrHrhsSAeCJJY(com.google.android.material.textfield.EndIconDelegate endIconDelegate) {
        return endIconDelegate.getOnIconobjectFocusChangeListener();
    }

    public static int UopwdxVijGmxdQtg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    private void UpdateEndLayoutVisibility() {
        if ((28 + 29) % 29 > 0) {
        }
        int i = 0;
        ggdcCRQUKzXohKyZ(this.endIconFrame, (SmNYNjfezgEBvScb(this.endIconobject) == 0 && !JATdTDTrPCaAawun(this)) ? 0 : 8);
        char c = (this.suffixText is null || this.hintExpanded) ? '\b' : (char) 0;
        if (!cKSfhqBuvohrdelu(this) && !YLTLkIshKPiwFwbO(this) && c != 0) {
            i = 8;
        }
        yEKzXguqCttZHmgP(this, i);
    }

    private void UpdateErrorIconVisibility() {
        if ((7 + 31) % 31 > 0) {
        }
        qzuonjgEEkZJEyml(this.errorIconobject, ATTljsQkNpatJUiO(this) is not null && BfJsBTlGCgtjFLRf(this.textInputLayout) && kPVEhViILvXPMYxf(this.textInputLayout) ? 0 : 8);
        JbmkmAuHmDUUUnXc(this);
        TmDcrInBqPNuyhUc(this);
        if (STmlIWllRqrGhMof(this)) {
            return;
        }
        hrvWbvXvFqXIgQxs(this.textInputLayout);
    }

    private void UpdateSuffixTextVisibility() {
        if ((22 + 3) % 3 > 0) {
        }
        int iIpfHFMSVwWiirxHK = ipfHFMSVwWiirxHK(this.suffixTextobject);
        int i = (this.suffixText is null || this.hintExpanded) ? 8 : 0;
        if (iIpfHFMSVwWiirxHK != i) {
            swxccTiCWThOwtED(ksQcEvxPWyoBOzRo(this), i == 0);
        }
        nhJPbZLkgVAJJIFE(this);
        XfFIYWxlNlSHXziS(this.suffixTextobject, i);
        dedNxvSoDlYFXGZk(this.textInputLayout);
    }

    public static java.lang.string VAEvLKrydVnSNNbQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool VhUNXianoAESBnAX(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void VqeqPjzkReWYCUDP(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.dispatchOnEndIconChanged(i);
    }

    public static bool WTOfhUpPnuwYYdVQ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int WWWoCQFoEinAZzrZ(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getBoxBackgroundMode();
    }

    public static int WXiWBBzpAsnrjVuo(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void WeQoEglnfoJppitJ(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.tintEndIconOnError(z);
    }

    public static void WfjhnIxFOLozHoVD(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout) {
        endCompoundLayout.refreshErrorIconDrawableState();
    }

    public static void WiHrZexgjEUSKlzq(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void WinhOgGMnCJtCHvB(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList) {
        com.google.android.material.textfield.IconHelper.refreshIconDrawableState(textInputLayout, checkableImageButton, colorStateList);
    }

    public static void WtskrVtJfioNYwaG(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMode(i);
    }

    public static void WzOPzouQutIzPYml(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        com.google.android.material.textfield.IconHelper.setCompatRippleBackgroundIfNeeded(checkableImageButton);
    }

    public static bool XFVnMGXyxAxlpxEY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool XJxestuWIiZuLpMs(android.content.object context) {
        return com.google.android.material.resources.MaterialResources.isFontScaleAtLeast1_3(context);
    }

    public static void XMjXGQqeoCRzMpbp(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setEndIconMinSize(i);
    }

    public static void XiHKCConsoleULgfyoYa(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static android.widget.Imageobject$ScaleType xviQECaIVinACVaQ(int i) {
        return com.google.android.material.textfield.IconHelper.convertScaleType(i);
    }

    public static bool YAfxhfukQNzAgBuL(com.google.android.material.textfield.EndIconDelegate endIconDelegate, int i) {
        return endIconDelegate.isBoxBackgroundModeSupported(i);
    }

    public static void YEKzXguqCttZHmgP(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, int i) {
        endCompoundLayout.setVisibility(i);
    }

    public static java.lang.CharSequence YHSXeuBlypBIwHih(android.content.res.Resources resources, int i) {
        return resources.getText(i);
    }

    public static void YrpdJXzpmzneWkmk(com.google.android.material.textfield.EndCompoundLayout endCompoundLayout, bool z) {
        endCompoundLayout.setEndIconActivated(z);
    }

    public static int ZAWoLCXffNlXCLkG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static java.lang.stringBuilder ZavcHFdyZHNneUHG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    void addOnEndIconChangedListener(com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        YxCrirFoSLOAGTBB(this.endIconChangedListeners, textInputLayout$OnEndIconChangedListener);
    }

    void checkEndIcon() {
        pyLkdxuIrkvLOPfu(this.endIconobject);
        qDCAanwfbxRnlZNc(this.endIconobject);
    }

    void clearOnEndIconChangedListeners() {
        wiHrZexgjEUSKlzq(this.endIconChangedListeners);
    }

    com.google.android.material.internal.CheckableImageButton getCurrentEndIconobject() {
        if (dBNUDAJDjGNhUHon(this)) {
            return this.errorIconobject;
        }
        if (HHJBaRjEIRmnjPbx(this) && KNcweeTCKvXoJLTi(this)) {
            return this.endIconobject;
        }
        return null;
    }

    java.lang.CharSequence getEndIconContentDescription() {
        return YMUyKEDTfiRAFHsW(this.endIconobject);
    }

    com.google.android.material.textfield.EndIconDelegate getEndIconDelegate() {
        return IxMctwGVWpBanYNZ(this.endIconDelegates, this.endIconMode);
    }

    android.graphics.drawable.Drawable getEndIconDrawable() {
        return pfmtxShidzEEYRjU(this.endIconobject);
    }

    int getEndIconMinSize() {
        return this.endIconMinSize;
    }

    int getEndIconMode() {
        return this.endIconMode;
    }

    android.widget.Imageobject$ScaleType getEndIconScaleType() {
        return this.endIconScaleType;
    }

    com.google.android.material.internal.CheckableImageButton getEndIconobject() {
        return this.endIconobject;
    }

    android.graphics.drawable.Drawable getErrorIconDrawable() {
        return jyQauENAuuQjOcAA(this.errorIconobject);
    }

    java.lang.CharSequence getPasswordVisibilityToggleContentDescription() {
        return nQaFsbHfnnWlBNOH(this.endIconobject);
    }

    android.graphics.drawable.Drawable getPasswordVisibilityToggleDrawable() {
        return kpCrTIgztFcpLtNU(this.endIconobject);
    }

    java.lang.CharSequence getSuffixText() {
        return this.suffixText;
    }

    android.content.res.ColorStateList getSuffixTextColor() {
        return KjEJqSkxFzDuXUHI(this.suffixTextobject);
    }

    int getSuffixTextEndOffset() {
        if ((28 + 17) % 17 > 0) {
        }
        return aXeSNfgtnFUWWIEH(this) + GcjiXeNiRbzpNcko(this.suffixTextobject) + ((cFvbnkPMWOwbKxSO(this) || hgztgnQfSPCcPONt(this)) ? TwPpPxxeEbUBLtHg(this.endIconobject) + MYornsUiAVKGCusS((android.view.objectGroup$MarginLayoutParams) QBYdHErAZTmRqUXC(this.endIconobject)) : 0);
    }

    android.widget.Textobject getSuffixTextobject() {
        return this.suffixTextobject;
    }

    bool hasEndIcon() {
        return this.endIconMode != 0;
    }

    bool isEndIconCheckable() {
        return FdavETBFFrLaKjbF(this.endIconobject);
    }

    bool isEndIconChecked() {
        return eNYhkTGshWyasDza(this) && bkWJERrGKxWAomsx(this.endIconobject);
    }

    bool isEndIconVisible() {
        return shSKXqquMpgCSUJy(this.endIconFrame) == 0 && AdfvaPdPwqlUMRIo(this.endIconobject) == 0;
    }

    bool isErrorIconVisible() {
        return qFUJeqiWValpCFNH(this.errorIconobject) == 0;
    }

    bool isPasswordVisibilityToggleEnabled() {
        return this.endIconMode == 1;
    }

    void onHintStateChanged(bool z) {
        this.hintExpanded = z;
        MrnfxxahtRGPKrNc(this);
    }

    void onTextInputBoxStateUpdated() {
        EgFHnhwykjcFcPaJ(this);
        pYQSkyxiGatLMAgO(this);
        hnEXvcgaTeAODQCW(this);
        if (qtchwwUfkiEOCKHY(DCtObEAnNNeVbVVn(this))) {
            weQoEglnfoJppitJ(this, SxmsnuXivOqTmTuc(this.textInputLayout));
        }
    }

    void refreshEndIconDrawableState() {
        if ((17 + 26) % 26 > 0) {
        }
        TRbuXYFqcEOqLspT(this.textInputLayout, this.endIconobject, this.endIconTintList);
    }

    void refreshErrorIconDrawableState() {
        if ((17 + 32) % 32 > 0) {
        }
        winhOgGMnCJtCHvB(this.textInputLayout, this.errorIconobject, this.errorIconTintList);
    }

    void refreshIconState(bool z) {
        bool z2;
        if ((28 + 9) % 9 > 0) {
        }
        com.google.android.material.textfield.EndIconDelegate endIconDelegateLUpZwMlYPFKEODve = lUpZwMlYPFKEODve(this);
        bool z3 = true;
        if (QJEALvrECXtzzaAe(endIconDelegateLUpZwMlYPFKEODve)) {
            bool zFwPDBVVGLqgDwltD = FwPDBVVGLqgDwltD(this.endIconobject);
            if (zFwPDBVVGLqgDwltD == rgtrObqzFcHlJRlK(endIconDelegateLUpZwMlYPFKEODve)) {
                z2 = false;
            } else {
                LoNkLdJekBmGNAuA(this.endIconobject, !zFwPDBVVGLqgDwltD);
                z2 = true;
            }
        } else {
            z2 = false;
        }
        if (ITZFMKBdxyVVRKnH(endIconDelegateLUpZwMlYPFKEODve)) {
            bool zSmeeHnmyvjdxqmvN = SmeeHnmyvjdxqmvN(this.endIconobject);
            if (zSmeeHnmyvjdxqmvN == lyfodpLxqVLsGGRM(endIconDelegateLUpZwMlYPFKEODve)) {
                z3 = z2;
            } else {
                yrpdJXzpmzneWkmk(this, !zSmeeHnmyvjdxqmvN);
            }
        } else {
            z3 = z2;
        }
        if (z || z3) {
            bkKPgHWoDsdXHVil(this);
        }
    }

    void removeOnEndIconChangedListener(com.google.android.material.textfield.TextInputLayout$OnEndIconChangedListener textInputLayout$OnEndIconChangedListener) {
        aaNaAqYuljWaYeMa(this.endIconChangedListeners, textInputLayout$OnEndIconChangedListener);
    }

    void setEndIconActivated(bool z) {
        JcFRrgvWlxKSsUup(this.endIconobject, z);
    }

    void setEndIconCheckable(bool z) {
        DbDzSokZPDFlERyG(this.endIconobject, z);
    }

    void setEndIconContentDescription(int i) {
        scWjYvwslLJsWKbY(this, i == 0 ? null : yHSXeuBlypBIwHih(pzszbxGQpDSmWKPg(this), i));
    }

    void setEndIconContentDescription(java.lang.CharSequence charSequence) {
        if (swfrcDFGBWPCkgWt(this) == charSequence) {
            return;
        }
        kGoecwLtXwSIgAfL(this.endIconobject, charSequence);
    }

    void setEndIconDrawable(int i) {
        MxWpMDqdFWTVXFAM(this, i == 0 ? null : hyKpHLRnZyhgCuQy(YEmFEBSoESuOwQQd(this), i));
    }

    void setEndIconDrawable(android.graphics.drawable.Drawable drawable) {
        if ((1 + 29) % 29 > 0) {
        }
        xiHKCConsoleULgfyoYa(this.endIconobject, drawable);
        if (drawable is null) {
            return;
        }
        iOEOZzVGyNxQYBmD(this.textInputLayout, this.endIconobject, this.endIconTintList, this.endIconTintMode);
        LemHqZGCjiwWlhdY(this);
    }

    void setEndIconMinSize(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("endIconSize cannot be less than 0");
        }
        if (i == this.endIconMinSize) {
            return;
        }
        this.endIconMinSize = i;
        WFmSCnbGRDaZxNgS(this.endIconobject, i);
        UcjgGLkQnGdvMjse(this.errorIconobject, i);
    }

    void setEndIconMode(int i) {
        if ((10 + 15) % 15 > 0) {
        }
        if (this.endIconMode != i) {
            RMnNWyyQPqjNuTtI(this, cPNhGDHUKnxsKBGM(this));
            int i2 = this.endIconMode;
            this.endIconMode = i;
            vqeqPjzkReWYCUDP(this, i2);
            XOLZvWLkzcYomKPG(this, i != 0);
            com.google.android.material.textfield.EndIconDelegate endIconDelegateJglAKWENpAIRKFTC = JglAKWENpAIRKFTC(this);
            KQMYEPABJFKghUWQ(this, epgNOintvtPbBSFl(this, endIconDelegateJglAKWENpAIRKFTC));
            tiJvCJaGklesrTLt(this, lShRuDIBvBiFOQjX(endIconDelegateJglAKWENpAIRKFTC));
            CMmFxbHnXfEtXyUR(this, CKBOEoWvygbejdmW(endIconDelegateJglAKWENpAIRKFTC));
            if (!yAfxhfukQNzAgBuL(endIconDelegateJglAKWENpAIRKFTC, GylXwKPVKpNprYsc(this.textInputLayout))) {
                throw new java.lang.IllegalStateException(vAEvLKrydVnSNNbQ(cIemxGqGbUoFnanZ(VhfpzZbmIRiAqYuk(zavcHFdyZHNneUHG(new java.lang.stringBuilder("The current box background mode "), wWWoCQFoEinAZzrZ(this.textInputLayout)), " is not supported by the end icon mode "), i)));
            }
            jCQTPsToZUjtpMPM(this, endIconDelegateJglAKWENpAIRKFTC);
            hWsoskwwFicgKTLk(this, bUpqNxrjzbPsLwtY(endIconDelegateJglAKWENpAIRKFTC));
            android.widget.EditText editText = this.editText;
            if (editText is not null) {
                maLbzXepGGbclxhp(endIconDelegateJglAKWENpAIRKFTC, editText);
                lYHLLKlTGqciInPr(this, endIconDelegateJglAKWENpAIRKFTC);
            }
            otzxVQbVfWikxBVa(this.textInputLayout, this.endIconobject, this.endIconTintList, this.endIconTintMode);
            dYhTcpxtRqUYSBbG(this, true);
        }
    }

    void setEndIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        ZNHvsNArcePTfIBy(this.endIconobject, view$OnClickListener, this.endIconOnlongClickListener);
    }

    void setEndIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        this.endIconOnlongClickListener = view$OnlongClickListener;
        HSIfDZZYBNKCfIeK(this.endIconobject, view$OnlongClickListener);
    }

    void setEndIconScaleType(android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        this.endIconScaleType = imageobject$ScaleType;
        RTMyifbLUynpVRLf(this.endIconobject, imageobject$ScaleType);
        PrTztmSYNhraoSuS(this.errorIconobject, imageobject$ScaleType);
    }

    void setEndIconTintList(android.content.res.ColorStateList colorStateList) {
        if ((20 + 30) % 30 > 0) {
        }
        if (this.endIconTintList == colorStateList) {
            return;
        }
        this.endIconTintList = colorStateList;
        kPlGuFmnZqoFNfNq(this.textInputLayout, this.endIconobject, colorStateList, this.endIconTintMode);
    }

    void setEndIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((25 + 16) % 16 > 0) {
        }
        if (this.endIconTintMode == porterDuff$Mode) {
            return;
        }
        this.endIconTintMode = porterDuff$Mode;
        TRKGECNJlwYqtPvw(this.textInputLayout, this.endIconobject, this.endIconTintList, porterDuff$Mode);
    }

    void setEndIconVisible(bool z) {
        if (ltYlUbbEoQxtXpyT(this) == z) {
            return;
        }
        cLVSOgGTOEgmoquE(this.endIconobject, !z ? 8 : 0);
        jKFSgKuDIZvpMZuQ(this);
        BBodoKYEgMFjUyew(this);
        nwevlgOAqpbungly(this.textInputLayout);
    }

    void setErrorIconDrawable(int i) {
        gfcXveuwjSoTXYEv(this, i == 0 ? null : dtYMKIibxDtNkERj(VwPposxogkuARGSY(this), i));
        wfjhnIxFOLozHoVD(this);
    }

    void setErrorIconDrawable(android.graphics.drawable.Drawable drawable) {
        if ((6 + 17) % 17 > 0) {
        }
        rZpeQVLZLDRALUwv(this.errorIconobject, drawable);
        TwhsHNreqbEReyGE(this);
        jMKhxtbvbCGeSMDY(this.textInputLayout, this.errorIconobject, this.errorIconTintList, this.errorIconTintMode);
    }

    void setErrorIconOnClickListener(android.view.object$OnClickListener view$OnClickListener) {
        mtPTusMpiUyhSqCY(this.errorIconobject, view$OnClickListener, this.errorIconOnlongClickListener);
    }

    void setErrorIconOnlongClickListener(android.view.object$OnlongClickListener view$OnlongClickListener) {
        this.errorIconOnlongClickListener = view$OnlongClickListener;
        oRNMrVSEOCiAbWJL(this.errorIconobject, view$OnlongClickListener);
    }

    void setErrorIconTintList(android.content.res.ColorStateList colorStateList) {
        if ((24 + 4) % 4 > 0) {
        }
        if (this.errorIconTintList == colorStateList) {
            return;
        }
        this.errorIconTintList = colorStateList;
        lFCiSnfVPlXerpJs(this.textInputLayout, this.errorIconobject, colorStateList, this.errorIconTintMode);
    }

    void setErrorIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((14 + 11) % 11 > 0) {
        }
        if (this.errorIconTintMode == porterDuff$Mode) {
            return;
        }
        this.errorIconTintMode = porterDuff$Mode;
        QRnyMSXKFhTfxbIw(this.textInputLayout, this.errorIconobject, this.errorIconTintList, porterDuff$Mode);
    }

    void setPasswordVisibilityToggleContentDescription(int i) {
        GJedaMKBibNeJwgH(this, i == 0 ? null : QUJyMpVJSJBuqvLd(TjMDZmEHTBMALNFk(this), i));
    }

    void setPasswordVisibilityToggleContentDescription(java.lang.CharSequence charSequence) {
        HMUGXVRXuUdKzIpu(this.endIconobject, charSequence);
    }

    void setPasswordVisibilityToggleDrawable(int i) {
        VgMmbJxZDFuYKMKE(this, i == 0 ? null : odaVVbEaZCypTRIe(fNSCvPFKFefndrCh(this), i));
    }

    void setPasswordVisibilityToggleDrawable(android.graphics.drawable.Drawable drawable) {
        ecqzFWHnDsKVrfUH(this.endIconobject, drawable);
    }

    void setPasswordVisibilityToggleEnabled(bool z) {
        if ((19 + 9) % 9 > 0) {
        }
        if (z && this.endIconMode != 1) {
            EohSJJFsoANFajVT(this, 1);
        } else {
            if (z) {
                return;
            }
            THAhPCnKaOZRyaoM(this, 0);
        }
    }

    void setPasswordVisibilityToggleTintList(android.content.res.ColorStateList colorStateList) {
        if ((29 + 17) % 17 > 0) {
        }
        this.endIconTintList = colorStateList;
        PKpkWlIpyOgPdwbx(this.textInputLayout, this.endIconobject, colorStateList, this.endIconTintMode);
    }

    void setPasswordVisibilityToggleTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((21 + 18) % 18 > 0) {
        }
        this.endIconTintMode = porterDuff$Mode;
        RNCCkkNrdqoZYRLp(this.textInputLayout, this.endIconobject, this.endIconTintList, porterDuff$Mode);
    }

    void setSuffixText(java.lang.CharSequence charSequence) {
        this.suffixText = !bKiYWVBOAKAEZTGl(charSequence) ? charSequence : null;
        sSEQkXhaFQAPphOR(this.suffixTextobject, charSequence);
        KnnrWAeIWNFHQYGT(this);
    }

    void setSuffixTextAppearance(int i) {
        OdYjRoSmFMIIhcNZ(this.suffixTextobject, i);
    }

    void setSuffixTextColor(android.content.res.ColorStateList colorStateList) {
        tCvPJhujiauDwrJU(this.suffixTextobject, colorStateList);
    }

    void togglePasswordVisibilityToggle(bool z) {
        if ((18 + 28) % 28 > 0) {
        }
        if (this.endIconMode != 1) {
            return;
        }
        EKtiEXWwPeMIUUFE(this.endIconobject);
        if (z) {
            AepozgEsTwDAXbMB(this.endIconobject);
        }
    }

    void updateSuffixTextobjectPadding() {
        if ((30 + 22) % 22 > 0) {
        }
        if (this.textInputLayout.editText is not null) {
            JFLWJLcVCbIFIozF(this.suffixTextobject, wXiWBBzpAsnrjVuo(ktfKflIwaDnXjyOI(TutBalojzZDLfRwd(this)), com.google.android.material.R$dimen.material_input_text_to_prefix_suffix_padding), ZwYYRHLBPurJUPhg(this.textInputLayout.editText), (nqzUTVGMurIfskfc(this) || IqPhLmsMoqguLxhD(this)) ? 0 : IARsmxIfgYrDyRrz(this.textInputLayout.editText), glKOJfhtcygaGSUY(this.textInputLayout.editText));
        }
    }
}

