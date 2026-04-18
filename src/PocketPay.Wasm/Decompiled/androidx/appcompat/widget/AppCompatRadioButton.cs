namespace WillowMaze.Wasm.Decompiled;


public class AppCompatRadioButton : android.widget.RadioButton : androidx.core.widget.TintableCompoundButton, androidx.core.view.TintableBackgroundobject, androidx.appcompat.widget.EmojiCompatConfigurationobject, androidx.core.widget.TintableCompoundDrawablesobject {
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mAppCompatEmojiTextHelper;
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private readonly androidx.appcompat.widget.AppCompatCompoundButtonHelper mCompoundButtonHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatRadioButton(android.content.object context) {
        this(context, null);
    }

    public AppCompatRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.radioButtonStyle);
    }

    public AppCompatRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(SjJUpqcdpNVdzRMk(context), attributeHashSet, i);
        lELUKFtIfqupFxRN(this, rHWqmClijJUopUHl(this));
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = new androidx.appcompat.widget.AppCompatCompoundButtonHelper(this);
        this.mCompoundButtonHelper = appCompatCompoundButtonHelper;
        bZxIgGeqBsYaTNwC(appCompatCompoundButtonHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        UpKBBiqBtTyttyPG(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        PikxAPOSwhKrcDvu(appCompatTextHelper, attributeHashSet, i);
        VNtXMKLZCfdNtmbj(ZCimRmlwtPXyYURG(this), attributeHashSet, i);
    }

    public static android.graphics.PorterDuff$Mode APPhAgDcpyYhSibN(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static void EbtYxkSzCZVpViDX(android.widget.RadioButton radioButton) {
        super.drawableStateChanged();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper FYjDtNWEgoFknslF(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getEmojiTextobjectHelper();
    }

    public static android.content.res.ColorStateList GOSUTKSVKDSLyyiP(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper GRvZwOdNrcvBCWUo(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getEmojiTextobjectHelper();
    }

    public static void LBFPfoXsYROVgFKh(android.widget.RadioButton radioButton, int i) {
        super.setBackgroundResource(i);
    }

    public static void NOKyGpbBlEmuFQvA(android.widget.RadioButton radioButton, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper POJbvxXdsPwUwTmB(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getEmojiTextobjectHelper();
    }

    public static void PikxAPOSwhKrcDvu(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.content.res.ColorStateList QWQJNpVHRneFhBUd(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper RTwGYNrhOARomoeu(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getEmojiTextobjectHelper();
    }

    public static android.content.object SjJUpqcdpNVdzRMk(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void SwTEfbSOsKjsdoLo(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void TInDqXxfCbdVWBvc(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void UHarFgtPWKRloLjG(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static bool UhBBXYYOVuvhTyOG(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static void UpKBBiqBtTyttyPG(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void VNtXMKLZCfdNtmbj(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void VgKauKzGhSSThKrk(android.widget.RadioButton radioButton, android.graphics.drawable.Drawable drawable) {
        super.setButtonDrawable(drawable);
    }

    public static void YWpYSyWerLarJQBn(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static void YpnktWSZHIhotgNx(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper ZCimRmlwtPXyYURG(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getEmojiTextobjectHelper();
    }

    public static void BKdXGQGtDWnzaYBJ(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton, android.graphics.drawable.Drawable drawable) {
        appCompatRadioButton.setButtonDrawable(drawable);
    }

    public static void BZxIgGeqBsYaTNwC(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatCompoundButtonHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void BkzDsSmzzfaCOhMS(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void DhvpxUtLLTphFeKB(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static int EPWiBbuBHexgmzye(android.widget.RadioButton radioButton) {
        return super.getCompoundPaddingLeft();
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mAppCompatEmojiTextHelper is null) {
            this.mAppCompatEmojiTextHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mAppCompatEmojiTextHelper;
    }

    public static void HPKtnahlRPzGxyte(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.graphics.drawable.Drawable HqYnpDFuDeOwDoDb(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.graphics.PorterDuff$Mode icSWLYmyPyTIQzgq(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static void JKtJwYzeVTSItuvL(android.widget.RadioButton radioButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void JTOYhqDphvjrBhht(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void KDWkEetLDXRRytPZ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void KZQvwjIgrEwJLdso(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatCompoundButtonHelper.setSupportButtonTintMode(porterDuff$Mode);
    }

    public static int KyoqoEqVVqkkfzVZ(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, int i) {
        return appCompatCompoundButtonHelper.getCompoundPaddingLeft(i);
    }

    public static void LELUKFtIfqupFxRN(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void LTUNIRnmRrMaEVwz(android.widget.RadioButton radioButton, bool z) {
        super.setAllCaps(z);
    }

    public static void LaCzFBUtoNcSPPup(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        appCompatCompoundButtonHelper.onHashSetButtonDrawable();
    }

    public static android.graphics.PorterDuff$Mode ljgjheJlrxvMEWwv(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        return appCompatCompoundButtonHelper.getSupportButtonTintMode();
    }

    public static void MWOQQvsylYWNTHaE(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void MzDKAtfTUnrwzXKh(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper, android.content.res.ColorStateList colorStateList) {
        appCompatCompoundButtonHelper.setSupportButtonTintList(colorStateList);
    }

    public static void PASOKNPWUxmowWNs(android.widget.RadioButton radioButton, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static void QWVCSAOATboqNLKV(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static android.content.object RHWqmClijJUopUHl(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getobject();
    }

    public static android.content.object TGzrbwIUEdoowQIz(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        return appCompatRadioButton.getobject();
    }

    public static android.content.res.ColorStateList TIVwbobcjvhZJlYk(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        return appCompatCompoundButtonHelper.getSupportButtonTintList();
    }

    public static android.text.InputFilter[] WdYdwdRyUdMcYMPA(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static void XIhtYbqnUInpbEPJ(android.widget.RadioButton radioButton, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void XzKaoKjhMFsqoPIA(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void YouSzWyIYsTRoird(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    protected override void DrawableStateChanged() {
        EbtYxkSzCZVpViDX(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            kDWkEetLDXRRytPZ(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        xzKaoKjhMFsqoPIA(appCompatTextHelper);
    }

    public override int GetCompoundPaddingLeft() {
        int iEPWiBbuBHexgmzye = ePWiBbuBHexgmzye(this);
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        return appCompatCompoundButtonHelper is null ? iEPWiBbuBHexgmzye : kyoqoEqVVqkkfzVZ(appCompatCompoundButtonHelper, iEPWiBbuBHexgmzye);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return QWQJNpVHRneFhBUd(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return APPhAgDcpyYhSibN(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportButtonTintList() {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return null;
        }
        return tIVwbobcjvhZJlYk(appCompatCompoundButtonHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportButtonTintMode() {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return null;
        }
        return ljgjheJlrxvMEWwv(appCompatCompoundButtonHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return GOSUTKSVKDSLyyiP(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return icSWLYmyPyTIQzgq(this.mTextHelper);
    }

    public override bool IsEmojiCompatEnabled() {
        return UhBBXYYOVuvhTyOG(RTwGYNrhOARomoeu(this));
    }

    public override void SetAllCaps(bool z) {
        lTUNIRnmRrMaEVwz(this, z);
        youSzWyIYsTRoird(GRvZwOdNrcvBCWUo(this), z);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        jKtJwYzeVTSItuvL(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        bkzDsSmzzfaCOhMS(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        LBFPfoXsYROVgFKh(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        jTOYhqDphvjrBhht(appCompatBackgroundHelper, i);
    }

    public override void SetButtonDrawable(int i) {
        bKdXGQGtDWnzaYBJ(this, hqYnpDFuDeOwDoDb(tGzrbwIUEdoowQIz(this), i));
    }

    public override void SetButtonDrawable(android.graphics.drawable.Drawable drawable) {
        VgKauKzGhSSThKrk(this, drawable);
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        laCzFBUtoNcSPPup(appCompatCompoundButtonHelper);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        NOKyGpbBlEmuFQvA(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        hPKtnahlRPzGxyte(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        xIhtYbqnUInpbEPJ(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        SwTEfbSOsKjsdoLo(appCompatTextHelper);
    }

    public override void SetEmojiCompatEnabled(bool z) {
        YWpYSyWerLarJQBn(FYjDtNWEgoFknslF(this), z);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        pASOKNPWUxmowWNs(this, wdYdwdRyUdMcYMPA(POJbvxXdsPwUwTmB(this), inputFilterArr));
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        YpnktWSZHIhotgNx(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        TInDqXxfCbdVWBvc(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportButtonTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        mzDKAtfTUnrwzXKh(appCompatCompoundButtonHelper, colorStateList);
    }

    public override void SetSupportButtonTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper = this.mCompoundButtonHelper;
        if (appCompatCompoundButtonHelper is null) {
            return;
        }
        kZQvwjIgrEwJLdso(appCompatCompoundButtonHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        dhvpxUtLLTphFeKB(this.mTextHelper, colorStateList);
        mWOQQvsylYWNTHaE(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        qWVCSAOATboqNLKV(this.mTextHelper, porterDuff$Mode);
        UHarFgtPWKRloLjG(this.mTextHelper);
    }
}

