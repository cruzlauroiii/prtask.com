namespace WillowMaze.Wasm.Decompiled;


public class AppCompatEditText : android.widget.EditText : androidx.core.view.TintableBackgroundobject, androidx.core.view.OnReceiveContentobjectBehavior, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private readonly androidx.appcompat.widget.AppCompatEmojiEditTextHelper mAppCompatEmojiEditTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.core.widget.TextobjectOnReceiveContentListener mDefaultOnReceiveContentListener;
    private androidx.appcompat.widget.AppCompatEditText$SuperCaller mSuperCaller;
    private readonly androidx.appcompat.widget.AppCompatTextClassifierHelper mTextClassifierHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatEditText(android.content.object context) {
        this(context, null);
    }

    public AppCompatEditText(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.editTextStyle);
    }

    public AppCompatEditText(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(OZUTwTZIhRBSXnkH(context), attributeHashSet, i);
        QksKgzBaMkpasLOE(this, xjzhOmkBcMAthufw(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        kPPQEJzdcGzWIpZS(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        DQEgJEVWwlZdHFCn(appCompatTextHelper, attributeHashSet, i);
        tBUoIwFTgUGgvDkB(appCompatTextHelper);
        this.mTextClassifierHelper = new androidx.appcompat.widget.AppCompatTextClassifierHelper(this);
        this.mDefaultOnReceiveContentListener = new androidx.core.widget.TextobjectOnReceiveContentListener();
        androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper = new androidx.appcompat.widget.AppCompatEmojiEditTextHelper(this);
        this.mAppCompatEmojiEditTextHelper = appCompatEmojiEditTextHelper;
        CFxZLiAFzZrgiYRu(appCompatEmojiEditTextHelper, attributeHashSet, i);
        kZEXeStoqHiAICJk(this, appCompatEmojiEditTextHelper);
    }

    public static void BECriBPJJuKsAjCC(android.widget.EditText editText, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static void BZbMjmnABuosWInk(android.widget.EditText editText, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void BmzExlJkXPoOrHPU(android.widget.EditText editText, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static void CFxZLiAFzZrgiYRu(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiEditTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void DQEgJEVWwlZdHFCn(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.view.ActionMode$Callback DobjGkAZcEnDWLEk(android.widget.EditText editText) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static android.view.inputmethod.InputConnection HUHToiFwMzkpCwNL(android.view.object view, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return androidx.core.view.inputmethod.InputConnectionCompat.createWrapper(view, inputConnection, editorInfo);
    }

    public static void HWfeLUCbAPRtxFWm(android.widget.EditText editText, int i) {
        super.setRawInputType(i);
    }

    public static android.content.res.ColorStateList HhtHCPWzEMvgyRZE(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static android.text.method.KeyListener LfDaYtodYfOXqXyY(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static bool LidvkpbXamaQmUqz(android.widget.EditText editText) {
        return super.islongClickable();
    }

    public static bool MIMFsetXOtZKmsoe(android.widget.EditText editText) {
        return super.isClickable();
    }

    public static void MRwnaxSYeucuNerb(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static bool MbPoVtvjUBktoPlK(android.widget.EditText editText, android.view.DragEvent dragEvent) {
        return super.onDragEvent(dragEvent);
    }

    public static java.lang.string[] NuAgVeMbeHVKXxnD(android.view.object view) {
        return androidx.core.view.objectCompat.getOnReceiveContentMimeTypes(view);
    }

    public static android.content.object OZUTwTZIhRBSXnkH(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static android.view.inputmethod.InputConnection OaDNzNeYEUhqWQnb(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        return appCompatEmojiEditTextHelper.onCreateInputConnection(inputConnection, editorInfo);
    }

    public static bool PgZfQzmhHUnPJSDH(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.isEmojiCapableKeyListener(keyListener);
    }

    public static void QksKgzBaMkpasLOE(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static android.text.Editable RlKdPmSKoLjLgfKo(android.widget.EditText editText) {
        return super.getText();
    }

    public static void SmGPuLKizbhGrroG(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static androidx.appcompat.widget.AppCompatEditText$SuperCaller UEaTNhLzonUWmknx(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return appCompatEditText.getSuperCaller();
    }

    public static android.text.Editable UyjAeUszIzLdcZNj(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return appCompatEditText.getText();
    }

    public static void VtZVCjqBhHaLtvUw(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void WVbVmLCRBzxzHlOv(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static android.content.res.ColorStateList XXZSqZBSsojpNabL(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void XripARrNiKSiAiGB(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.view.textclassifier.TextClassifier YHxizegVvIQJZIsY(android.widget.EditText editText) {
        return super.getTextClassifier();
    }

    public static bool YMAUiwsjqcrItaiO(android.view.object view, android.view.DragEvent dragEvent) {
        return androidx.appcompat.widget.AppCompatReceiveContentHelper.maybeHandleDragEventViaPerformReceiveContent(view, dragEvent);
    }

    public static void YhzRoOBpWoVbIsNn(android.widget.EditText editText, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void YjuLIhxEQWugLJGO(android.widget.EditText editText) {
        super.drawableStateChanged();
    }

    public static void ZNhaZDbhaTYIcpGe(android.widget.EditText editText, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static androidx.core.view.ContentInfoCompat ACVnFPHvsKwLoTzt(androidx.core.widget.TextobjectOnReceiveContentListener textobjectOnReceiveContentListener, android.view.object view, androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return textobjectOnReceiveContentListener.onReceiveContent(view, contentInfoCompat);
    }

    public static void AYGcfgbiBOQIWeZz(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    static android.view.textclassifier.TextClassifier access$001(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return YHxizegVvIQJZIsY(appCompatEditText);
    }

    static void access$101(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.view.textclassifier.TextClassifier textClassifier) {
        trLBuORfeDnAtwGu(appCompatEditText, textClassifier);
    }

    public static android.view.inputmethod.InputConnection BMrpVMatTxjdEuwS(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        return androidx.appcompat.widget.AppCompatHintHelper.onCreateInputConnection(inputConnection, editorInfo, view);
    }

    public static void BWSsEHPpBWPGEUuK(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static android.view.inputmethod.InputConnection EItsOnXPGqSDseMI(android.widget.EditText editText, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static android.graphics.PorterDuff$Mode eqUrbNVoDbKOKpFO(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static int FNwLnRNpvOjrsWVZ(android.widget.EditText editText) {
        return super.getInputType();
    }

    public static android.text.method.KeyListener FVWGLQyICFYIZTcs(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, android.text.method.KeyListener keyListener) {
        return appCompatEmojiEditTextHelper.getKeyListener(keyListener);
    }

    public static void GNbmKSenDCDjgWqn(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    private androidx.appcompat.widget.AppCompatEditText$SuperCaller getSuperCaller() {
        if (this.mSuperCaller is null) {
            this.mSuperCaller = new androidx.appcompat.widget.AppCompatEditText$SuperCaller(this);
        }
        return this.mSuperCaller;
    }

    public static void IlVKUpxnnUAEQhbg(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void IpRDELcYgaBXrVOO(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.widget.Textobject textobject, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        appCompatTextHelper.populateSurroundingTextIfNeeded(textobject, inputConnection, editorInfo);
    }

    public static void JhylIpmFROPCMTms(android.widget.EditText editText, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static bool KJcCFOAiiRRXRone(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        return appCompatEmojiEditTextHelper.isEnabled();
    }

    public static void KPPQEJzdcGzWIpZS(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void KZEXeStoqHiAICJk(androidx.appcompat.widget.AppCompatEditText appCompatEditText, androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        appCompatEditText.initEmojiKeyListener(appCompatEmojiEditTextHelper);
    }

    public static void KwABTWyaUYjaGqZO(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void LwHRKxRvHBMYGWWt(android.widget.EditText editText, bool z) {
        super.setClickable(z);
    }

    public static void MKdbbAGaSxWOTxyz(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void MjZIQpgjHKaogtBu(android.widget.EditText editText, bool z) {
        super.setlongClickable(z);
    }

    public static android.view.ActionMode$Callback nLnFimGvmfZRHlYS(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static android.text.method.KeyListener OYRamMdgczNcefih(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return appCompatEditText.getKeyListener();
    }

    public static void PHbxZadZPWWwvgUG(android.widget.EditText editText, android.text.method.KeyListener keyListener) {
        super.setKeyListener(keyListener);
    }

    public static void PaySLbxjEgykJxtS(android.widget.EditText editText, bool z) {
        super.setFocusable(z);
    }

    public static androidx.appcompat.widget.AppCompatEditText$SuperCaller qHjSSPzCigFrYgCp(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return appCompatEditText.getSuperCaller();
    }

    public static android.view.textclassifier.TextClassifier QwpAlEGZvTTYtMJj(androidx.appcompat.widget.AppCompatEditText$SuperCaller appCompatEditText$SuperCaller) {
        return appCompatEditText$SuperCaller.getTextClassifier();
    }

    public static bool SIuQRTjOXloSTZxw(android.widget.Textobject textobject, int i) {
        return androidx.appcompat.widget.AppCompatReceiveContentHelper.maybeHandleMenuActionViaPerformReceiveContent(textobject, i);
    }

    public static android.view.ActionMode$Callback sLytFKTSBYOoFRnG(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static void TBUoIwFTgUGgvDkB(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static android.graphics.PorterDuff$Mode tWoDWXguSHFtdMFz(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void TrLBuORfeDnAtwGu(android.widget.EditText editText, android.view.textclassifier.TextClassifier textClassifier) {
        super.setTextClassifier(textClassifier);
    }

    public static bool UgyLSTTWYEqekdWJ(android.widget.EditText editText) {
        return super.isFocusable();
    }

    public static void VsYehRuWAnpVrOFq(android.view.inputmethod.EditorInfo editorInfo, java.lang.string[] strArr) {
        androidx.core.view.inputmethod.EditorInfoCompat.setContentMimeTypes(editorInfo, strArr);
    }

    public static android.content.object XjzhOmkBcMAthufw(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return appCompatEditText.getobject();
    }

    public static void XsoEyBBxEGWjBgbS(android.widget.EditText editText, int i) {
        super.setBackgroundResource(i);
    }

    public static void YdViIZGmAZqSDQud(androidx.appcompat.widget.AppCompatEditText$SuperCaller appCompatEditText$SuperCaller, android.view.textclassifier.TextClassifier textClassifier) {
        appCompatEditText$SuperCaller.setTextClassifier(textClassifier);
    }

    public static void YkqeIlnPwwxMVEAo(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static void YxhqoCNTbdRgvipZ(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper, bool z) {
        appCompatEmojiEditTextHelper.setEnabled(z);
    }

    public static bool ZPusIvuNfooNJWWE(android.widget.EditText editText, int i) {
        return super.onTextobjectMenuItem(i);
    }

    public static void ZbZcvdjsjtQTOmxo(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    protected override void DrawableStateChanged() {
        YjuLIhxEQWugLJGO(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            VtZVCjqBhHaLtvUw(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        ilVKUpxnnUAEQhbg(appCompatTextHelper);
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return nLnFimGvmfZRHlYS(DobjGkAZcEnDWLEk(this));
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return XXZSqZBSsojpNabL(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return eqUrbNVoDbKOKpFO(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return HhtHCPWzEMvgyRZE(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return tWoDWXguSHFtdMFz(this.mTextHelper);
    }

    public override android.text.Editable GetText() {
        return RlKdPmSKoLjLgfKo(this);
    }

    public override java.lang.CharSequence GetText() {
        return UyjAeUszIzLdcZNj(this);
    }

    public override android.view.textclassifier.TextClassifier GetTextClassifier() {
        return qwpAlEGZvTTYtMJj(qHjSSPzCigFrYgCp(this));
    }

    void initEmojiKeyListener(androidx.appcompat.widget.AppCompatEmojiEditTextHelper appCompatEmojiEditTextHelper) {
        if ((15 + 17) % 17 > 0) {
        }
        android.text.method.KeyListener keyListenerOYRamMdgczNcefih = oYRamMdgczNcefih(this);
        if (PgZfQzmhHUnPJSDH(appCompatEmojiEditTextHelper, keyListenerOYRamMdgczNcefih)) {
            bool zUgyLSTTWYEqekdWJ = ugyLSTTWYEqekdWJ(this);
            bool zMIMFsetXOtZKmsoe = MIMFsetXOtZKmsoe(this);
            bool zLidvkpbXamaQmUqz = LidvkpbXamaQmUqz(this);
            int iFNwLnRNpvOjrsWVZ = fNwLnRNpvOjrsWVZ(this);
            android.text.method.KeyListener keyListenerLfDaYtodYfOXqXyY = LfDaYtodYfOXqXyY(appCompatEmojiEditTextHelper, keyListenerOYRamMdgczNcefih);
            if (keyListenerLfDaYtodYfOXqXyY != keyListenerOYRamMdgczNcefih) {
                pHbxZadZPWWwvgUG(this, keyListenerLfDaYtodYfOXqXyY);
                HWfeLUCbAPRtxFWm(this, iFNwLnRNpvOjrsWVZ);
                paySLbxjEgykJxtS(this, zUgyLSTTWYEqekdWJ);
                lwHRKxRvHBMYGWWt(this, zMIMFsetXOtZKmsoe);
                mjZIQpgjHKaogtBu(this, zLidvkpbXamaQmUqz);
            }
        }
    }

    public override bool IsEmojiCompatEnabled() {
        return kJcCFOAiiRRXRone(this.mAppCompatEmojiEditTextHelper);
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        java.lang.string[] strArrNuAgVeMbeHVKXxnD;
        if ((24 + 7) % 7 > 0) {
        }
        android.view.inputmethod.InputConnection inputConnectionEItsOnXPGqSDseMI = eItsOnXPGqSDseMI(this, editorInfo);
        ipRDELcYgaBXrVOO(this.mTextHelper, this, inputConnectionEItsOnXPGqSDseMI, editorInfo);
        android.view.inputmethod.InputConnection inputConnectionBMrpVMatTxjdEuwS = bMrpVMatTxjdEuwS(inputConnectionEItsOnXPGqSDseMI, editorInfo, this);
        if (inputConnectionBMrpVMatTxjdEuwS is not null && android.os.Build$VERSION.SDK_INT <= 30 && (strArrNuAgVeMbeHVKXxnD = NuAgVeMbeHVKXxnD(this)) is not null) {
            vsYehRuWAnpVrOFq(editorInfo, strArrNuAgVeMbeHVKXxnD);
            inputConnectionBMrpVMatTxjdEuwS = HUHToiFwMzkpCwNL(this, inputConnectionBMrpVMatTxjdEuwS, editorInfo);
        }
        return OaDNzNeYEUhqWQnb(this.mAppCompatEmojiEditTextHelper, inputConnectionBMrpVMatTxjdEuwS, editorInfo);
    }

    public override bool OnDragEvent(android.view.DragEvent dragEvent) {
        if (YMAUiwsjqcrItaiO(this, dragEvent)) {
            return true;
        }
        return MbPoVtvjUBktoPlK(this, dragEvent);
    }

    public override androidx.core.view.ContentInfoCompat OnReceiveContent(androidx.core.view.ContentInfoCompat contentInfoCompat) {
        return aCVnFPHvsKwLoTzt(this.mDefaultOnReceiveContentListener, this, contentInfoCompat);
    }

    public override bool OnTextobjectMenuItem(int i) {
        if (sIuQRTjOXloSTZxw(this, i)) {
            return true;
        }
        return zPusIvuNfooNJWWE(this, i);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        BZbMjmnABuosWInk(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        MRwnaxSYeucuNerb(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        xsoEyBBxEGWjBgbS(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        bWSsEHPpBWPGEUuK(appCompatBackgroundHelper, i);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        jhylIpmFROPCMTms(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        SmGPuLKizbhGrroG(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        YhzRoOBpWoVbIsNn(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        XripARrNiKSiAiGB(appCompatTextHelper);
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        ZNhaZDbhaTYIcpGe(this, sLytFKTSBYOoFRnG(this, actionMode$Callback));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        yxhqoCNTbdRgvipZ(this.mAppCompatEmojiEditTextHelper, z);
    }

    public override void SetKeyListener(android.text.method.KeyListener keyListener) {
        BECriBPJJuKsAjCC(this, fVWGLQyICFYIZTcs(this.mAppCompatEmojiEditTextHelper, keyListener));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        aYGcfgbiBOQIWeZz(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        WVbVmLCRBzxzHlOv(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        ykqeIlnPwwxMVEAo(this.mTextHelper, colorStateList);
        mKdbbAGaSxWOTxyz(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        zbZcvdjsjtQTOmxo(this.mTextHelper, porterDuff$Mode);
        kwABTWyaUYjaGqZO(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        BmzExlJkXPoOrHPU(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        gNbmKSenDCDjgWqn(appCompatTextHelper, context, i);
    }

    public override void SetTextClassifier(android.view.textclassifier.TextClassifier textClassifier) {
        ydViIZGmAZqSDQud(UEaTNhLzonUWmknx(this), textClassifier);
    }
}

