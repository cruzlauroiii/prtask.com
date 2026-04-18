namespace WillowMaze.Wasm.Decompiled;


public class AppCompatCheckedTextobject : android.widget.CheckedTextobject : androidx.core.widget.TintableCheckedTextobject, androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatCheckedTextobjectHelper mCheckedHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatCheckedTextobject(android.content.object context) {
        this(context, null);
    }

    public AppCompatCheckedTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.checkedTextobjectStyle);
    }

    public AppCompatCheckedTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(BahFDCFepsxretNQ(context), attributeHashSet, i);
        RmgpxnpXsDCUWGkf(this, KsKDLttxAZtAjCBT(this));
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        OeKjAzqYDuBwtEnn(appCompatTextHelper, attributeHashSet, i);
        UsgXIesOfLKstAVT(appCompatTextHelper);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        uVhKWGgwuaIbtYZw(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = new androidx.appcompat.widget.AppCompatCheckedTextobjectHelper(this);
        this.mCheckedHelper = appCompatCheckedTextobjectHelper;
        BhbPhODjPPiKcATp(appCompatCheckedTextobjectHelper, attributeHashSet, i);
        sNVoqSoEaEpWveRg(bcAwnLwoGGaCNAxr(this), attributeHashSet, i);
    }

    public static void AhlDvepsgAxEEMRd(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void BJSoxUtVhOSEtyZK(android.widget.CheckedTextobject checkedTextobject) {
        super.drawableStateChanged();
    }

    public static android.content.object BahFDCFepsxretNQ(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void BhbPhODjPPiKcATp(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatCheckedTextobjectHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void CucNBdhxgQbIyeNb(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static void DLfLvwjkeFHEHijJ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void DQvzzYJprelRpcSH(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper) {
        appCompatCheckedTextobjectHelper.onHashSetCheckMarkDrawable();
    }

    public static void EhBRLmwEmVCfPgrO(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static android.graphics.drawable.Drawable EoTaLRwFlCYrxpBv(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void FcpuOqIpUXoVohMJ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void GEzNMltaREVhqusU(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper HhieaquLjexamglS(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getEmojiTextobjectHelper();
    }

    public static void IaIJBFDFGoKdTzIc(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject, android.graphics.drawable.Drawable drawable) {
        appCompatCheckedTextobject.setCheckMarkDrawable(drawable);
    }

    public static android.content.object KsKDLttxAZtAjCBT(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getobject();
    }

    public static void LRgKNQoptAhjAdPD(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.graphics.PorterDuff$Mode LtfBQNQyUixkufcB(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper) {
        return appCompatCheckedTextobjectHelper.getSupportCheckMarkTintMode();
    }

    public static android.view.inputmethod.InputConnection NOjgwVJtzvsTZunX(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        return androidx.appcompat.widget.AppCompatHintHelper.onCreateInputConnection(inputConnection, editorInfo, view);
    }

    public static android.view.ActionMode$Callback NWYpNZvtHiWJojvQ(android.widget.CheckedTextobject checkedTextobject) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static void OeKjAzqYDuBwtEnn(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void PvjBGtCAVFbBOEFu(android.widget.CheckedTextobject checkedTextobject, int i) {
        super.setBackgroundResource(i);
    }

    public static void RRCAXAlIlrKmNIMf(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatCheckedTextobjectHelper.setSupportCheckMarkTintMode(porterDuff$Mode);
    }

    public static void RmgpxnpXsDCUWGkf(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static android.content.object RoiiDRORpACNLuno(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getobject();
    }

    public static void ShfsKYCUiydUZprI(android.widget.CheckedTextobject checkedTextobject, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static void SnwdyrfnrJAiLzYt(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable) {
        super.setCheckMarkDrawable(drawable);
    }

    public static void SsdjnedwbluSgEEa(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void TeIrgYjWDPxPhOZs(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void UMSAALBDzyqUAiie(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper, android.content.res.ColorStateList colorStateList) {
        appCompatCheckedTextobjectHelper.setSupportCheckMarkTintList(colorStateList);
    }

    public static void UsgXIesOfLKstAVT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void VDrmZhDrodynreDU(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static android.graphics.PorterDuff$Mode WiCRpJTnQArQVvlD(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static android.view.ActionMode$Callback XUxWihTpppFrTDvH(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static void XmGiAkktbkcQsDge(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void YpqQJwhYVyhzfrJC(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void AMexWQlKhINaNSSz(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper BNLCsGhLrWYSkZQb(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getEmojiTextobjectHelper();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper BcAwnLwoGGaCNAxr(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getEmojiTextobjectHelper();
    }

    public static android.content.res.ColorStateList BpPelqExbMliAPPk(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void ChWXnxAhiytDvNsW(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper EvuXAQwWXelRwpQW(androidx.appcompat.widget.AppCompatCheckedTextobject appCompatCheckedTextobject) {
        return appCompatCheckedTextobject.getEmojiTextobjectHelper();
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    public static void HVdOrMSWXlPossXJ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    public static bool MWvcijMrrVTjgzPc(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static void MoZvraEAhKrgysAG(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper) {
        appCompatCheckedTextobjectHelper.applyCheckMarkTint();
    }

    public static android.view.ActionMode$Callback otiMgnFYNtUpGFer(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static void PBTcUjiikiwMVCbh(android.widget.CheckedTextobject checkedTextobject, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static void SNVoqSoEaEpWveRg(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void SWWsGLrfxSmPzVQd(android.widget.CheckedTextobject checkedTextobject, bool z) {
        super.setAllCaps(z);
    }

    public static android.content.res.ColorStateList TYyuXuVpyxijtPRm(androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper) {
        return appCompatCheckedTextobjectHelper.getSupportCheckMarkTintList();
    }

    public static void UVhKWGgwuaIbtYZw(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.graphics.PorterDuff$Mode vHatLKIulVFXvcpu(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void VStrhWLtJyCCvgHR(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static android.content.res.ColorStateList WfjGnBzRJjdEdKIA(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void YUYZcmMKyyRmLkBK(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void YhRGZFFOBybVaXGF(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static android.view.inputmethod.InputConnection ZUipYYunJEFoAats(android.widget.CheckedTextobject checkedTextobject, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    protected override void DrawableStateChanged() {
        BJSoxUtVhOSEtyZK(this);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is not null) {
            FcpuOqIpUXoVohMJ(appCompatTextHelper);
        }
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            TeIrgYjWDPxPhOZs(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return;
        }
        moZvraEAhKrgysAG(appCompatCheckedTextobjectHelper);
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return otiMgnFYNtUpGFer(NWYpNZvtHiWJojvQ(this));
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return wfjGnBzRJjdEdKIA(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return WiCRpJTnQArQVvlD(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCheckMarkTintList() {
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return null;
        }
        return tYyuXuVpyxijtPRm(appCompatCheckedTextobjectHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCheckMarkTintMode() {
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return null;
        }
        return LtfBQNQyUixkufcB(appCompatCheckedTextobjectHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return bpPelqExbMliAPPk(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return vHatLKIulVFXvcpu(this.mTextHelper);
    }

    public override bool IsEmojiCompatEnabled() {
        return mWvcijMrrVTjgzPc(evuXAQwWXelRwpQW(this));
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        return NOjgwVJtzvsTZunX(zUipYYunJEFoAats(this, editorInfo), editorInfo, this);
    }

    public override void SetAllCaps(bool z) {
        sWWsGLrfxSmPzVQd(this, z);
        EhBRLmwEmVCfPgrO(bNLCsGhLrWYSkZQb(this), z);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        XmGiAkktbkcQsDge(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        YpqQJwhYVyhzfrJC(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        PvjBGtCAVFbBOEFu(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        yUYZcmMKyyRmLkBK(appCompatBackgroundHelper, i);
    }

    public override void SetCheckMarkDrawable(int i) {
        IaIJBFDFGoKdTzIc(this, EoTaLRwFlCYrxpBv(RoiiDRORpACNLuno(this), i));
    }

    public override void SetCheckMarkDrawable(android.graphics.drawable.Drawable drawable) {
        SnwdyrfnrJAiLzYt(this, drawable);
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return;
        }
        DQvzzYJprelRpcSH(appCompatCheckedTextobjectHelper);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        vStrhWLtJyCCvgHR(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        LRgKNQoptAhjAdPD(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        aMexWQlKhINaNSSz(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        chWXnxAhiytDvNsW(appCompatTextHelper);
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        pBTcUjiikiwMVCbh(this, XUxWihTpppFrTDvH(this, actionMode$Callback));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        CucNBdhxgQbIyeNb(HhieaquLjexamglS(this), z);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        DLfLvwjkeFHEHijJ(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        GEzNMltaREVhqusU(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCheckMarkTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return;
        }
        UMSAALBDzyqUAiie(appCompatCheckedTextobjectHelper, colorStateList);
    }

    public override void SetSupportCheckMarkTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatCheckedTextobjectHelper appCompatCheckedTextobjectHelper = this.mCheckedHelper;
        if (appCompatCheckedTextobjectHelper is null) {
            return;
        }
        RRCAXAlIlrKmNIMf(appCompatCheckedTextobjectHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        VDrmZhDrodynreDU(this.mTextHelper, colorStateList);
        AhlDvepsgAxEEMRd(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        yhRGZFFOBybVaXGF(this.mTextHelper, porterDuff$Mode);
        SsdjnedwbluSgEEa(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        ShfsKYCUiydUZprI(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        hVdOrMSWXlPossXJ(appCompatTextHelper, context, i);
    }
}

