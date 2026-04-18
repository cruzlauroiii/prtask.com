namespace WillowMaze.Wasm.Decompiled;


public class AppCompatMultiAutoCompleteTextobject : android.widget.MultiAutoCompleteTextobject : androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private static readonly int[] TINT_ATTRS = {16843126};
    private readonly androidx.appcompat.widget.AppCompatEmojiEditTextHelper mAppCompatEmojiEditTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatMultiAutoCompleteTextobject(android.content.object context) {
        this(context, null);
    }

    public AppCompatMultiAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.autoCompleteTextobjectStyle);
    }

    public AppCompatMultiAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(JZEdYNVohuJkrcyN(context), attributeHashSet, i);
        if ((10 + 20) % 20 > 0) {
        }
        qpIIlUspqHmvGTux(this, ZBkMOIkBmxbFQZAU(this));
        androidx.appcompat.widget.TintTypedArray tintTypedArrayMztVlfUZawxkSJdK = MztVlfUZawxkSJdK(NESEEtQDTunaOTcN(this), attributeHashSet, TINT_ATTRS, i, 0);
        if (OJsWYsLXhiafHNGn(tintTypedArrayMztVlfUZawxkSJdK, 0)) {
            joiCWPuFZqWooDZQ(this, JWOLCqnmysMaZBFf(tintTypedArrayMztVlfUZawxkSJdK, 0));
        }
        ZabEPQnAGkndTzUx(tintTypedArrayMztVlfUZawxkSJdK);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        hYZWwujLLBkcNrKd(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        GvppjTYKCespHpkW(appCompatTextHelper, attributeHashSet, i);
        WLrpRiOpBYZVIgee(appCompatTextHelper);
        androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper = new androidx.appcompat.widget.AppCompatEmojiEditTextHelper(this);
        this.mAppCompatEmojiEditTextHelper = appCompatEmojiEditTextHelper;
        VZisIcQNhlDrJOMB(appCompatEmojiEditTextHelper, attributeHashSet, i);
        gNdPrsoklKwfFxNU(this, appCompatEmojiEditTextHelper);
    }

    public static void AQcTKYDYoGlUpgrB(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, bool z) {
        appCompatEmojiEditTextHelper.setEnabled(z);
    }

    public static android.graphics.PorterDuff$Mode BRRuVUTsolRAwqDH(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static void DACPcNEwJzTSGbuB(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static void DDYrKySTkLZueQpc(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    public static android.view.inputmethod.InputConnection DtkSIocwgCcVEeey(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static void EQaTZAEMdjtMqInT(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static android.graphics.PorterDuff$Mode ExWBXPkXbwlkONbP(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void GSSlINZHjiMZFzAm(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void GhqTDflqpmrZPMnk(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        appCompatMultiAutoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static void GvppjTYKCespHpkW(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.view.inputmethod.InputConnection HSCHQRiRClsOkDWO(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        return androidx.appcompat.widget.AppCompatHintHelper.onCreateInputConnection(inputConnection, editorInfo, view);
    }

    public static void HUwklFTBhNtYZQdZ(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject) {
        super.drawableStateChanged();
    }

    public static android.graphics.drawable.Drawable JWOLCqnmysMaZBFf(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.content.object JZEdYNVohuJkrcyN(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void KiqaMiYiQULvBvww(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void KsSNnNJavIvqZDAB(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static android.content.res.ColorStateList LtfSIvabvTYjuFVA(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void MaresyIZhMZjVitt(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static androidx.appcompat.widget.TintTypedArray MztVlfUZawxkSJdK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static android.content.object NESEEtQDTunaOTcN(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject) {
        return appCompatMultiAutoCompleteTextobject.getobject();
    }

    public static bool OJsWYsLXhiafHNGn(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void OVJBpxTWzavJowUs(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, bool z) {
        super.setClickable(z);
    }

    public static bool OiaTHNvAPlKTeaXj(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject) {
        return super.isFocusable();
    }

    public static void TWeZXkNAePKtxLwq(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, bool z) {
        super.setlongClickable(z);
    }

    public static android.text.method.KeyListener TuAdAVunuKCsIEHQ(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static void VZisIcQNhlDrJOMB(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiEditTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void WLrpRiOpBYZVIgee(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void WxtnwYtflaQBFroX(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, int i) {
        super.setBackgroundResource(i);
    }

    public static android.content.object ZBkMOIkBmxbFQZAU(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject) {
        return appCompatMultiAutoCompleteTextobject.getobject();
    }

    public static void ZabEPQnAGkndTzUx(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool AUGJIFnNVetPXeeg(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.isEmojiCapableKeyListener(keyListener);
    }

    public static void CEMfwQGHFUpiGviz(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static android.graphics.drawable.Drawable CdIGWKyQWDRvgYAS(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void DszuEbZQnlpVJigv(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, bool z) {
        super.setFocusable(z);
    }

    public static bool EBLUorvLUjobCgwO(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject) {
        return super.islongClickable();
    }

    public static android.view.inputmethod.InputConnection ECFsNMnLKzKUygai(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return appCompatEmojiEditTextHelper.onCreateInputConnection(inputConnection, editorInfo);
    }

    public static void EURjcrYrdxHREcOu(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void GNdPrsoklKwfFxNU(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject, androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        appCompatMultiAutoCompleteTextobject.initEmojiKeyListener(appCompatEmojiEditTextHelper);
    }

    public static void HYZWwujLLBkcNrKd(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static bool IalnxsavbNtqVmcS(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        return appCompatEmojiEditTextHelper.isEnabled();
    }

    public static void JoiCWPuFZqWooDZQ(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject, android.graphics.drawable.Drawable drawable) {
        appCompatMultiAutoCompleteTextobject.setDropDownBackgroundDrawable(drawable);
    }

    public static void KDFRcplmsBnkzFcY(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.content.res.ColorStateList KKNysYfZltarosDE(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void OOehoFVmLqYXrATa(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void PpWEekdzdSaGNDqe(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static android.text.method.KeyListener QjetehwLWkiHGYyJ(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject) {
        return appCompatMultiAutoCompleteTextobject.getKeyListener();
    }

    public static void QpIIlUspqHmvGTux(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void SADFRqLyfMIovAQA(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void SbEEmqvFgVAnHnzl(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, int i) {
        super.setRawInputType(i);
    }

    public static android.content.object TIOwBFLeCCgiOGpN(androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject appCompatMultiAutoCompleteTextobject) {
        return appCompatMultiAutoCompleteTextobject.getobject();
    }

    public static void UZbXEszdfUfxkiYq(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static int VCoQzRQkGCPhAVIt(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject) {
        return super.getInputType();
    }

    public static android.text.method.KeyListener WeDzyojoAzadOyhl(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static void WrGaHvvjOhbmQWDT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void XbkidaNFopbGVoHx(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static void XtJZqINRKrZQdNpJ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void XtuVEKymvYwjUppI(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void XxPnGujWExOnLNbX(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static bool ZUVQCtccbQiSUDGv(android.widget.MultiAutoCompleteTextobject multiAutoCompleteTextobject) {
        return super.isClickable();
    }

    protected override void DrawableStateChanged() {
        HUwklFTBhNtYZQdZ(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            eURjcrYrdxHREcOu(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        xtuVEKymvYwjUppI(appCompatTextHelper);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return LtfSIvabvTYjuFVA(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return BRRuVUTsolRAwqDH(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return kKNysYfZltarosDE(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return ExWBXPkXbwlkONbP(this.mTextHelper);
    }

    void initEmojiKeyListener(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        if ((21 + 17) % 17 > 0) {
        }
        android.text.method.KeyListener keyListenerQjetehwLWkiHGYyJ = qjetehwLWkiHGYyJ(this);
        if (aUGJIFnNVetPXeeg(appCompatEmojiEditTextHelper, keyListenerQjetehwLWkiHGYyJ)) {
            bool zOiaTHNvAPlKTeaXj = OiaTHNvAPlKTeaXj(this);
            bool zZUVQCtccbQiSUDGv = zUVQCtccbQiSUDGv(this);
            bool zEBLUorvLUjobCgwO = eBLUorvLUjobCgwO(this);
            int iVCoQzRQkGCPhAVIt = vCoQzRQkGCPhAVIt(this);
            android.text.method.KeyListener keyListenerTuAdAVunuKCsIEHQ = TuAdAVunuKCsIEHQ(appCompatEmojiEditTextHelper, keyListenerQjetehwLWkiHGYyJ);
            if (keyListenerTuAdAVunuKCsIEHQ != keyListenerQjetehwLWkiHGYyJ) {
                xxPnGujWExOnLNbX(this, keyListenerTuAdAVunuKCsIEHQ);
                sbEEmqvFgVAnHnzl(this, iVCoQzRQkGCPhAVIt);
                dszuEbZQnlpVJigv(this, zOiaTHNvAPlKTeaXj);
                OVJBpxTWzavJowUs(this, zZUVQCtccbQiSUDGv);
                TWeZXkNAePKtxLwq(this, zEBLUorvLUjobCgwO);
            }
        }
    }

    public override bool IsEmojiCompatEnabled() {
        return ialnxsavbNtqVmcS(this.mAppCompatEmojiEditTextHelper);
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        return eCFsNMnLKzKUygai(this.mAppCompatEmojiEditTextHelper, HSCHQRiRClsOkDWO(DtkSIocwgCcVEeey(this, editorInfo), editorInfo, this), editorInfo);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        MaresyIZhMZjVitt(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        ppWEekdzdSaGNDqe(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        WxtnwYtflaQBFroX(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        KsSNnNJavIvqZDAB(appCompatBackgroundHelper, i);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        oOehoFVmLqYXrATa(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        kDFRcplmsBnkzFcY(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        cEMfwQGHFUpiGviz(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        GSSlINZHjiMZFzAm(appCompatTextHelper);
    }

    public override void SetDropDownBackgroundResource(int i) {
        GhqTDflqpmrZPMnk(this, cdIGWKyQWDRvgYAS(tIOwBFLeCCgiOGpN(this), i));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        AQcTKYDYoGlUpgrB(this.mAppCompatEmojiEditTextHelper, z);
    }

    public override void SetKeyListener(android.text.method.KeyListener keyListener) {
        EQaTZAEMdjtMqInT(this, weDzyojoAzadOyhl(this.mAppCompatEmojiEditTextHelper, keyListener));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        xtJZqINRKrZQdNpJ(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        sADFRqLyfMIovAQA(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        uZbXEszdfUfxkiYq(this.mTextHelper, colorStateList);
        KiqaMiYiQULvBvww(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        xbkidaNFopbGVoHx(this.mTextHelper, porterDuff$Mode);
        wrGaHvvjOhbmQWDT(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        DACPcNEwJzTSGbuB(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        DDYrKySTkLZueQpc(appCompatTextHelper, context, i);
    }
}

