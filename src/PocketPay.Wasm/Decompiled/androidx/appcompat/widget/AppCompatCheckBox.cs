namespace WillowMaze.Wasm.Decompiled;


public class AppCompatCheckBox : android.widget.CheckBox : androidx.core.widget.TintableCompoundButton, androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatCompoundButtonHelper mCompoundButtonHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatCheckBox(android.content.object context) {
        this(context, null);
    }

    public AppCompatCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.checkboxStyle);
    }

    public AppCompatCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(frMZWfwbhJHxTmsv(context), attributeHashSet, i);
        sGWbIJyGlPmLkJnL(this, dOibdnqkHIqAYOXD(this));
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = new androidx.appcompat.widget.AppCompatCompoundButtonHelper(this);
        this.mCompoundButtonHelper = appCompatCompoundButtonHelper;
        idBRKihMQhfHHpNE(appCompatCompoundButtonHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        VkpBKfLKtAFKgWna(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        TKKTPFoafZpTjyNs(appCompatTextHelper, attributeHashSet, i);
        UirlBOgjwGHWZTjl(EAHYMZtMXGTqkhxW(this), attributeHashSet, i);
    }

    public static void ASbbAENXIEsMZtPA(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void CQnFnDvfOllRRruf(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.content.res.ColorStateList colorStateList) {
        appCompatCompoundButtonHelper.setSupportButtonTintList(colorStateList);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper EAHYMZtMXGTqkhxW(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getEmojiTextobjectHelper();
    }

    public static void GXslCHBBpRQEQWCy(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static int HczzMkpMtaTZmLMZ(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, int i) {
        return appCompatCompoundButtonHelper.getCompoundPaddingLeft(i);
    }

    public static void KURrZfqEvszVdACa(android.widget.CheckBox checkBox, android.graphics.drawable.Drawable drawable) {
        super.setButtonDrawable(drawable);
    }

    public static android.content.res.ColorStateList LdybVWBPuTNBPQcm(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void MBPWXNYvoPKaArUR(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatCompoundButtonHelper.setSupportButtonTintMode(porterDuff$Mode);
    }

    public static android.content.res.ColorStateList ORDEqMGeFXnZaDeD(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        return appCompatCompoundButtonHelper.getSupportButtonTintList();
    }

    public static void OUYPXJgdTIgUnLFT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static android.graphics.PorterDuff$Mode RmpMepANgCDCdhHA(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        return appCompatCompoundButtonHelper.getSupportButtonTintMode();
    }

    public static void TKKTPFoafZpTjyNs(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void TbxgZYfkWCNfaDbk(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void UirlBOgjwGHWZTjl(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void UiwezGMUuSTRBGec(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void VkpBKfLKtAFKgWna(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void XCwZqPworJairMdR(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable) {
        appCompatCheckBox.setButtonDrawable(drawable);
    }

    public static void XJDjGRGkHXbiVlnl(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void YQDtMRdoNdEPTZZj(android.widget.CheckBox checkBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static android.graphics.PorterDuff$Mode YaPEalauzzpVlvKQ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static android.content.res.ColorStateList CQmQgfjZauJYDWai(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void CUskaisuxtbquUGl(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static android.content.object DOibdnqkHIqAYOXD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getobject();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper DhtcXxQrfTkRtqDY(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getEmojiTextobjectHelper();
    }

    public static void DswDokONJpGEJHPy(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static void FIiOXvjGrzvzwTei(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static android.content.object FrMZWfwbhJHxTmsv(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static android.content.object GWAiUKnGvTmJnqzL(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getobject();
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    public static void GkaiFIJeJLIRBNok(android.widget.CheckBox checkBox, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static void HHPXyoxlgydONdlf(android.widget.CheckBox checkBox) {
        super.drawableStateChanged();
    }

    public static void HJBkQKCbcumqRVNl(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static void HPGXZoKkwRYXzFNT(android.widget.CheckBox checkBox, int i) {
        super.setBackgroundResource(i);
    }

    public static void IdBRKihMQhfHHpNE(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatCompoundButtonHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static int IeaToamIqRBqNubX(android.widget.CheckBox checkBox) {
        return super.getCompoundPaddingLeft();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper LZhTpkeThjDreBks(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getEmojiTextobjectHelper();
    }

    public static void NWPVRMkXsYHpplxU(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void NcalZdlSwmYEgpFP(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static android.graphics.drawable.Drawable NcuNcIkKDmhvpavT(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void OqxypAPoIxdKQdjq(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        appCompatCompoundButtonHelper.onHashSetButtonDrawable();
    }

    public static void PMKUVzTeZcDiELFS(android.widget.CheckBox checkBox, bool z) {
        super.setAllCaps(z);
    }

    public static bool QIVoWkyqbCBWOBoe(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static android.text.InputFilter[] QwHPSTtXMYOaIHpS(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static void RQZPgmkLSqlkritQ(android.widget.CheckBox checkBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void SGWbIJyGlPmLkJnL(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static android.graphics.PorterDuff$Mode sLNQWtsuxzmivkRR(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void UzzCyguNRqhpovme(android.widget.CheckBox checkBox, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void WSIVtGXlpXpscPKR(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper XXirZmlUzMaHOeVg(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getEmojiTextobjectHelper();
    }

    public static void YtSPMnvSyuSzFJFy(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper ZQdWkSIHBayQmdZo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        return appCompatCheckBox.getEmojiTextobjectHelper();
    }

    protected override void DrawableStateChanged() {
        hHPXyoxlgydONdlf(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            UiwezGMUuSTRBGec(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        XJDjGRGkHXbiVlnl(appCompatTextHelper);
    }

    public override int GetCompoundPaddingLeft() {
        int iIeaToamIqRBqNubX = ieaToamIqRBqNubX(this);
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        return appCompatCompoundButtonHelper is null ? iIeaToamIqRBqNubX : HczzMkpMtaTZmLMZ(appCompatCompoundButtonHelper, iIeaToamIqRBqNubX);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return cQmQgfjZauJYDWai(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return YaPEalauzzpVlvKQ(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportButtonTintList() {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return null;
        }
        return ORDEqMGeFXnZaDeD(appCompatCompoundButtonHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportButtonTintMode() {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return null;
        }
        return RmpMepANgCDCdhHA(appCompatCompoundButtonHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return LdybVWBPuTNBPQcm(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return sLNQWtsuxzmivkRR(this.mTextHelper);
    }

    public override bool IsEmojiCompatEnabled() {
        return qIVoWkyqbCBWOBoe(dhtcXxQrfTkRtqDY(this));
    }

    public override void SetAllCaps(bool z) {
        pMKUVzTeZcDiELFS(this, z);
        dswDokONJpGEJHPy(xXirZmlUzMaHOeVg(this), z);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        uzzCyguNRqhpovme(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        nWPVRMkXsYHpplxU(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        hPGXZoKkwRYXzFNT(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        cUskaisuxtbquUGl(appCompatBackgroundHelper, i);
    }

    public override void SetButtonDrawable(int i) {
        XCwZqPworJairMdR(this, ncuNcIkKDmhvpavT(gWAiUKnGvTmJnqzL(this), i));
    }

    public override void SetButtonDrawable(android.graphics.drawable.Drawable drawable) {
        KURrZfqEvszVdACa(this, drawable);
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        oqxypAPoIxdKQdjq(appCompatCompoundButtonHelper);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        YQDtMRdoNdEPTZZj(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        ytSPMnvSyuSzFJFy(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        rQZPgmkLSqlkritQ(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        TbxgZYfkWCNfaDbk(appCompatTextHelper);
    }

    public override void SetEmojiCompatEnabled(bool z) {
        fIiOXvjGrzvzwTei(zQdWkSIHBayQmdZo(this), z);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        gkaiFIJeJLIRBNok(this, qwHPSTtXMYOaIHpS(lZhTpkeThjDreBks(this), inputFilterArr));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        wSIVtGXlpXpscPKR(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        ASbbAENXIEsMZtPA(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportButtonTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        CQnFnDvfOllRRruf(appCompatCompoundButtonHelper, colorStateList);
    }

    public override void SetSupportButtonTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        MBPWXNYvoPKaArUR(appCompatCompoundButtonHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        ncalZdlSwmYEgpFP(this.mTextHelper, colorStateList);
        OUYPXJgdTIgUnLFT(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        hJBkQKCbcumqRVNl(this.mTextHelper, porterDuff$Mode);
        GXslCHBBpRQEQWCy(this.mTextHelper);
    }
}

