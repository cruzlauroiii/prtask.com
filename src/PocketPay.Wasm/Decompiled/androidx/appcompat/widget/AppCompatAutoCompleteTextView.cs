namespace WillowMaze.Wasm.Decompiled;


public class AppCompatAutoCompleteTextobject : android.widget.AutoCompleteTextobject : androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private static readonly int[] TINT_ATTRS = {16843126};
    private readonly androidx.appcompat.widget.AppCompatEmojiEditTextHelper mAppCompatEmojiEditTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatAutoCompleteTextobject(android.content.object context) {
        this(context, null);
    }

    public AppCompatAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.autoCompleteTextobjectStyle);
    }

    public AppCompatAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(hYHvTWyftNFtGGxU(context), attributeHashSet, i);
        if ((18 + 21) % 21 > 0) {
        }
        JqolcdLQLvlrqnQK(this, fMdZXAAZwVFhpbXh(this));
        androidx.appcompat.widget.TintTypedArray tintTypedArraySfyrrzkDtVpBCEeM = sfyrrzkDtVpBCEeM(eujsqxAQGtRZwJNx(this), attributeHashSet, TINT_ATTRS, i, 0);
        if (octugtGVHfZHtzGz(tintTypedArraySfyrrzkDtVpBCEeM, 0)) {
            aamDjeJDSSwWGJom(this, WNAesqbcNMpxdrEd(tintTypedArraySfyrrzkDtVpBCEeM, 0));
        }
        FCotXLTtGvfUoUJw(tintTypedArraySfyrrzkDtVpBCEeM);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        wlKaRGUIoZsObcMJ(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        SKwLwBETIvChzNJn(appCompatTextHelper, attributeHashSet, i);
        NUQpjtrWqgEfbFPX(appCompatTextHelper);
        androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper = new androidx.appcompat.widget.AppCompatEmojiEditTextHelper(this);
        this.mAppCompatEmojiEditTextHelper = appCompatEmojiEditTextHelper;
        HhqhPeTyPHmxLwjy(appCompatEmojiEditTextHelper, attributeHashSet, i);
        tbzbSRgjLhOAPcEv(this, appCompatEmojiEditTextHelper);
    }

    public static android.content.res.ColorStateList AMmKYHWYHJziudTd(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void APLeVhCmjruLJRFO(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        appCompatAutoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static android.content.object AqaUeRYRffMTyysP(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return appCompatAutoCompleteTextobject.getobject();
    }

    public static android.text.method.KeyListener EHGdDBXzMDsRQFof(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static void EKRmbyAvAXpYDHPH(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void FCotXLTtGvfUoUJw(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void FGOCrBjESXiRZcuM(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void FdZfVLFyPscKfjRh(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void FgXAJHMjaPDDPEdn(android.widget.AutoCompleteTextobject autoCompleteTextobject, bool z) {
        super.setClickable(z);
    }

    public static bool GYuWagVKawCtRRIC(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        return appCompatEmojiEditTextHelper.isEnabled();
    }

    public static void HhqhPeTyPHmxLwjy(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiEditTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void JqolcdLQLvlrqnQK(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void MJlMEvHqHRCtTYMy(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static android.graphics.drawable.Drawable NCfidCIrtdKSsSkg(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void NLCxssQEdFxwQRJr(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.text.method.KeyListener NMpvFtpZTeqdURpn(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static void NUQpjtrWqgEfbFPX(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void NcxujdSBtZSMDfej(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static bool ODcyJXXcumwdXNKn(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.isEmojiCapableKeyListener(keyListener);
    }

    public static void OHIkHmqpVasMJbDo(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void ORmFfNvqPqmsYkiW(android.widget.AutoCompleteTextobject autoCompleteTextobject, int i) {
        super.setRawInputType(i);
    }

    public static void RCCkFZjQqNsuXHvU(android.widget.AutoCompleteTextobject autoCompleteTextobject, bool z) {
        super.setlongClickable(z);
    }

    public static void RCqLpfISdXazekuo(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    public static void RZzaLOCIUXqMnjuR(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static void SKwLwBETIvChzNJn(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.view.ActionMode$Callback TtHlIqQgnfHtFLEd(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static android.graphics.drawable.Drawable WNAesqbcNMpxdrEd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.view.ActionMode$Callback WUvVJNNhnssFrXvA(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static void WcfKeTGiUyAldlxZ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void XEpTLMKKymXDooez(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        super.drawableStateChanged();
    }

    public static android.view.inputmethod.InputConnection XdqetyrRBhOpyioa(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return appCompatEmojiEditTextHelper.onCreateInputConnection(inputConnection, editorInfo);
    }

    public static void XqtLksIXdnULNIJJ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void XwBpryavUvkcRSWT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void ZGCxCByQygirWNmt(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static android.text.method.KeyListener ZfPCZoXVnsyYDIQJ(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return appCompatAutoCompleteTextobject.getKeyListener();
    }

    public static void AamDjeJDSSwWGJom(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        appCompatAutoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static int CImYBEYdfmuCTOxr(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return super.getInputType();
    }

    public static void CKEtdHcreJiwIppx(android.widget.AutoCompleteTextobject autoCompleteTextobject, bool z) {
        super.setFocusable(z);
    }

    public static void DAtcaowhCCOcTlID(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.content.object EujsqxAQGtRZwJNx(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return appCompatAutoCompleteTextobject.getobject();
    }

    public static android.content.object FMdZXAAZwVFhpbXh(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject) {
        return appCompatAutoCompleteTextobject.getobject();
    }

    public static void GihxDsBHpLPurvcw(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static android.content.object HYHvTWyftNFtGGxU(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static bool IsCmXlJAiBqePoUx(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return super.isClickable();
    }

    public static void KEkxuAOnZUbkFQda(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static bool KQrjPmoWxeRhNXGC(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return super.isFocusable();
    }

    public static android.view.inputmethod.InputConnection MnubunDonyhkwizR(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static android.view.inputmethod.InputConnection NujafWGJxkLcWnqT(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        return androidx.appcompat.widget.AppCompatHintHelper.onCreateInputConnection(inputConnection, editorInfo, view);
    }

    public static void OOHfAiOJTeAcrjOj(android.widget.AutoCompleteTextobject autoCompleteTextobject, int i) {
        super.setBackgroundResource(i);
    }

    public static bool OctugtGVHfZHtzGz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void PrbfDBTaYxTbPwtY(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static android.view.ActionMode$Callback qkPmKpCBxoSmuoJV(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static android.graphics.PorterDuff$Mode rCCdQnmHRzKnOUun(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static androidx.appcompat.widget.TintTypedArray SfyrrzkDtVpBCEeM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void TTXATRDwtkRVBRWW(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, bool z) {
        appCompatEmojiEditTextHelper.setEnabled(z);
    }

    public static void TbzbSRgjLhOAPcEv(androidx.appcompat.widget.AppCompatAutoCompleteTextobject appCompatAutoCompleteTextobject, androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        appCompatAutoCompleteTextobject.initEmojiKeyListener(appCompatEmojiEditTextHelper);
    }

    public static android.content.res.ColorStateList TqelApLfEmTJyoUm(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void WlKaRGUIoZsObcMJ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void XTXFTbirKmBDHToF(android.widget.AutoCompleteTextobject autoCompleteTextobject, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static bool XgXLoIlVfyishHFt(android.widget.AutoCompleteTextobject autoCompleteTextobject) {
        return super.islongClickable();
    }

    public static void YxYcrGGwQQtbgRMR(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void ZvSEKUcnfMoLQDAZ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static android.graphics.PorterDuff$Mode zwyGKRPEJpjdofjK(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    protected override void DrawableStateChanged() {
        XEpTLMKKymXDooez(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            WcfKeTGiUyAldlxZ(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        MJlMEvHqHRCtTYMy(appCompatTextHelper);
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return qkPmKpCBxoSmuoJV(WUvVJNNhnssFrXvA(this));
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return AMmKYHWYHJziudTd(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return zwyGKRPEJpjdofjK(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return tqelApLfEmTJyoUm(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return rCCdQnmHRzKnOUun(this.mTextHelper);
    }

    void initEmojiKeyListener(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        if ((19 + 7) % 7 > 0) {
        }
        android.text.method.KeyListener keyListenerZfPCZoXVnsyYDIQJ = ZfPCZoXVnsyYDIQJ(this);
        if (ODcyJXXcumwdXNKn(appCompatEmojiEditTextHelper, keyListenerZfPCZoXVnsyYDIQJ)) {
            bool zKQrjPmoWxeRhNXGC = kQrjPmoWxeRhNXGC(this);
            bool zIsCmXlJAiBqePoUx = isCmXlJAiBqePoUx(this);
            bool zXgXLoIlVfyishHFt = xgXLoIlVfyishHFt(this);
            int iCImYBEYdfmuCTOxr = cImYBEYdfmuCTOxr(this);
            android.text.method.KeyListener keyListenerNMpvFtpZTeqdURpn = NMpvFtpZTeqdURpn(appCompatEmojiEditTextHelper, keyListenerZfPCZoXVnsyYDIQJ);
            if (keyListenerNMpvFtpZTeqdURpn != keyListenerZfPCZoXVnsyYDIQJ) {
                gihxDsBHpLPurvcw(this, keyListenerNMpvFtpZTeqdURpn);
                ORmFfNvqPqmsYkiW(this, iCImYBEYdfmuCTOxr);
                cKEtdHcreJiwIppx(this, zKQrjPmoWxeRhNXGC);
                FgXAJHMjaPDDPEdn(this, zIsCmXlJAiBqePoUx);
                RCCkFZjQqNsuXHvU(this, zXgXLoIlVfyishHFt);
            }
        }
    }

    public override bool IsEmojiCompatEnabled() {
        return GYuWagVKawCtRRIC(this.mAppCompatEmojiEditTextHelper);
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        return XdqetyrRBhOpyioa(this.mAppCompatEmojiEditTextHelper, nujafWGJxkLcWnqT(mnubunDonyhkwizR(this, editorInfo), editorInfo, this), editorInfo);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        OHIkHmqpVasMJbDo(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        NcxujdSBtZSMDfej(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        oOHfAiOJTeAcrjOj(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        yxYcrGGwQQtbgRMR(appCompatBackgroundHelper, i);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        EKRmbyAvAXpYDHPH(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        NLCxssQEdFxwQRJr(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        FGOCrBjESXiRZcuM(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        dAtcaowhCCOcTlID(appCompatTextHelper);
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        xTXFTbirKmBDHToF(this, TtHlIqQgnfHtFLEd(this, actionMode$Callback));
    }

    public override void SetDropDownBackgroundResource(int i) {
        APLeVhCmjruLJRFO(this, NCfidCIrtdKSsSkg(AqaUeRYRffMTyysP(this), i));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        tTXATRDwtkRVBRWW(this.mAppCompatEmojiEditTextHelper, z);
    }

    public override void SetKeyListener(android.text.method.KeyListener keyListener) {
        ZGCxCByQygirWNmt(this, EHGdDBXzMDsRQFof(this.mAppCompatEmojiEditTextHelper, keyListener));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        XqtLksIXdnULNIJJ(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        FdZfVLFyPscKfjRh(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        kEkxuAOnZUbkFQda(this.mTextHelper, colorStateList);
        prbfDBTaYxTbPwtY(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        zvSEKUcnfMoLQDAZ(this.mTextHelper, porterDuff$Mode);
        XwBpryavUvkcRSWT(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        RZzaLOCIUXqMnjuR(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        RCqLpfISdXazekuo(appCompatTextHelper, context, i);
    }
}

