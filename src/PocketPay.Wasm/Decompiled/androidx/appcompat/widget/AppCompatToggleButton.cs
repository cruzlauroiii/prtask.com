namespace WillowMaze.Wasm.Decompiled;


public class AppCompatToggleButton : android.widget.ToggleButton : androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatToggleButton(android.content.object context) {
        this(context, null);
    }

    public AppCompatToggleButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 16842827);
    }

    public AppCompatToggleButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        RlKNyiarznjEUymy(this, dDcAgXidCeEhtxvH(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        VPlNNHmZIBqtbzoB(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        gVypeOTQZufYnMRw(appCompatTextHelper, attributeHashSet, i);
        cqUbsWyDNieAVMDS(dZDdmBukEUocEZRY(this), attributeHashSet, i);
    }

    public static android.text.InputFilter[] CJHdFuDrHjTELtwK(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static void FXyCuSGuYiDHjFWn(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void FebmvUDqemOKyTHV(android.widget.ToggleButton toggleButton, int i) {
        super.setBackgroundResource(i);
    }

    public static void HevkyMUYtGXRlqAh(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static bool LWglQZekIVheNhaq(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static void NIuQypehMwfDhwsM(android.widget.ToggleButton toggleButton, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void PnaJLzGNbnNXAzyg(android.widget.ToggleButton toggleButton, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static void QHZuqZQcooKLeNNr(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static void QcXDpQEIqEdlcWdA(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper RImWjkZPYRowBWLM(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getEmojiTextobjectHelper();
    }

    public static void RlKNyiarznjEUymy(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void TCdyKsZHsobFsoja(android.widget.ToggleButton toggleButton) {
        super.drawableStateChanged();
    }

    public static void VPlNNHmZIBqtbzoB(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void ZDVEBtDvFUDrshYq(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void AJzdgFkpumXYLQDQ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper AMCDEzxMbIBygfkE(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getEmojiTextobjectHelper();
    }

    public static void AbQFKNhnDJAuIPaY(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void BDTPoRmSogqdWaHJ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void CqUbsWyDNieAVMDS(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.content.object DDcAgXidCeEhtxvH(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getobject();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper DZDdmBukEUocEZRY(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getEmojiTextobjectHelper();
    }

    public static void FoUiKlJIQgKgBAVF(android.widget.ToggleButton toggleButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void GVypeOTQZufYnMRw(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper PAmnEEYtoeisJDlF(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getEmojiTextobjectHelper();
    }

    public static void RREireqCZCsUfQdf(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void TCaeRkJNatMSwEMj(android.widget.ToggleButton toggleButton, bool z) {
        super.setAllCaps(z);
    }

    public static void TZkbVkCcHcpfIhKA(android.widget.ToggleButton toggleButton, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void TeVvMyuyhniJmrVn(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void UsFOoIoyjvZAVgYx(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static void VXCwyoqISdKZdrEv(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void VZHTUjBklFfJtJmC(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static android.content.res.ColorStateList VudLlzKPEMvnOvDI(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static void WbgvQmBXTYrkfzne(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static android.graphics.PorterDuff$Mode wjusqTKcfwSQFgpv(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static android.content.res.ColorStateList WymULbVgACfVnPXa(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper YfOZKTZiTcFbaEco(androidx.appcompat.widget.AppCompatToggleButton appCompatToggleButton) {
        return appCompatToggleButton.getEmojiTextobjectHelper();
    }

    public static android.graphics.PorterDuff$Mode zHwtblBfWzuaWTrd(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    protected override void DrawableStateChanged() {
        TCdyKsZHsobFsoja(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            aJzdgFkpumXYLQDQ(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        HevkyMUYtGXRlqAh(appCompatTextHelper);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return wymULbVgACfVnPXa(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return wjusqTKcfwSQFgpv(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return vudLlzKPEMvnOvDI(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return zHwtblBfWzuaWTrd(this.mTextHelper);
    }

    public override bool IsEmojiCompatEnabled() {
        return LWglQZekIVheNhaq(RImWjkZPYRowBWLM(this));
    }

    public override void SetAllCaps(bool z) {
        tCaeRkJNatMSwEMj(this, z);
        QcXDpQEIqEdlcWdA(pAmnEEYtoeisJDlF(this), z);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        foUiKlJIQgKgBAVF(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        wbgvQmBXTYrkfzne(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        FebmvUDqemOKyTHV(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        ZDVEBtDvFUDrshYq(appCompatBackgroundHelper, i);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        tZkbVkCcHcpfIhKA(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        rREireqCZCsUfQdf(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        NIuQypehMwfDhwsM(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        vXCwyoqISdKZdrEv(appCompatTextHelper);
    }

    public override void SetEmojiCompatEnabled(bool z) {
        vZHTUjBklFfJtJmC(aMCDEzxMbIBygfkE(this), z);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        PnaJLzGNbnNXAzyg(this, CJHdFuDrHjTELtwK(yfOZKTZiTcFbaEco(this), inputFilterArr));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        FXyCuSGuYiDHjFWn(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        abQFKNhnDJAuIPaY(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        usFOoIoyjvZAVgYx(this.mTextHelper, colorStateList);
        bDTPoRmSogqdWaHJ(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        QHZuqZQcooKLeNNr(this.mTextHelper, porterDuff$Mode);
        teVvMyuyhniJmrVn(this.mTextHelper);
    }
}

