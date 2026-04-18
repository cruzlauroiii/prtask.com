namespace WillowMaze.Wasm.Decompiled;


public class AppCompatImageButton : android.widget.ImageButton : androidx.core.view.TintableBackgroundobject, androidx.core.widget.TintableImageSourceobject {
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private bool mHasLevel;
    private readonly androidx.appcompat.widget.AppCompatImageHelper mImageHelper;

    public AppCompatImageButton(android.content.object context) {
        this(context, null);
    }

    public AppCompatImageButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.appcompat.R$attr.imageButtonStyle);
    }

    public AppCompatImageButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(IwAbEjRAjFezabMM(context), attributeHashSet, i);
        this.mHasLevel = false;
        RZjgFYkeeCLGhBNd(this, EjyzKLZHZrgMqCWX(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        lSNHuEJPGrgLUJEr(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = new androidx.appcompat.widget.AppCompatImageHelper(this);
        this.mImageHelper = appCompatImageHelper;
        rYCwglMpSZIQgtwY(appCompatImageHelper, attributeHashSet, i);
    }

    public static android.graphics.PorterDuff$Mode AZWJqcLRebunQrEA(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static void BorPtiRNEpccozyb(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void CnerwVeUajHUhBYz(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void DGogBNysnzvonyJB(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static bool EKMfCrSbbJGGNQJo(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.hasOverlappingRendering();
    }

    public static android.content.object EjyzKLZHZrgMqCWX(androidx.appcompat.widget.AppCompatImageButton appCompatImageButton) {
        return appCompatImageButton.getobject();
    }

    public static android.content.object IwAbEjRAjFezabMM(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void JcFxPehXuNtgFVwE(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static android.content.res.ColorStateList JzxjvhxPjKqYxopw(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void MTzIqRCtFZPuFYml(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i) {
        appCompatImageHelper.setImageResource(i);
    }

    public static void PSHfxPbyvZZOYkAa(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void QVYEXGmxmvluigNX(android.widget.ImageButton imageButton, android.graphics.Bitmap bitmap) {
        super.setImageBitmap(bitmap);
    }

    public static void QWknYteOUVbTbwgS(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.graphics.drawable.Drawable drawable) {
        appCompatImageHelper.obtainLevelFromDrawable(drawable);
    }

    public static void RMvPJcLxNkkRwcQa(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatImageHelper.setSupportImageTintMode(porterDuff$Mode);
    }

    public static void RZjgFYkeeCLGhBNd(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void UXrkrfigHAdPrSbJ(android.widget.ImageButton imageButton, int i) {
        super.setBackgroundResource(i);
    }

    public static void VmbYGghKJEfuPPEZ(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void XCRHIlttUVDoYKcK(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applyImageLevel();
    }

    public static void YmRYzXXKsrvRZJPO(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void ZNAMRSQAJZwKJwix(android.widget.ImageButton imageButton, android.graphics.drawable.Drawable drawable) {
        super.setImageDrawable(drawable);
    }

    public static void AFzzHUkhAcMkMNNV(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void BCnEfnXELgJIaQSa(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void FJqnohzEuRvWLAgY(android.widget.ImageButton imageButton, android.net.Uri uri) {
        super.setImageUri(uri);
    }

    public static void JeQGaYdWvvzNzQVj(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void LQHlCxNqevHFOSzd(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.content.res.ColorStateList colorStateList) {
        appCompatImageHelper.setSupportImageTintList(colorStateList);
    }

    public static void LSNHuEJPGrgLUJEr(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static bool MaKvolXdpTdiEpZk(android.widget.ImageButton imageButton) {
        return super.hasOverlappingRendering();
    }

    public static void RYCwglMpSZIQgtwY(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatImageHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static android.content.res.ColorStateList TVsLPikmJvNRkkhi(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.getSupportImageTintList();
    }

    public static void TwLSVACEvhFCUFBy(android.widget.ImageButton imageButton, int i) {
        super.setImageLevel(i);
    }

    public static void UcwTbexTHnxpBRsO(android.widget.ImageButton imageButton) {
        super.drawableStateChanged();
    }

    public static android.graphics.PorterDuff$Mode yVOWOLeSPjCQZygz(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.getSupportImageTintMode();
    }

    protected override void DrawableStateChanged() {
        ucwTbexTHnxpBRsO(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            PSHfxPbyvZZOYkAa(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        VmbYGghKJEfuPPEZ(appCompatImageHelper);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return JzxjvhxPjKqYxopw(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return AZWJqcLRebunQrEA(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportImageTintList() {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return null;
        }
        return tVsLPikmJvNRkkhi(appCompatImageHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportImageTintMode() {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return null;
        }
        return yVOWOLeSPjCQZygz(appCompatImageHelper);
    }

    public override bool HasOverlappingRendering() {
        return EKMfCrSbbJGGNQJo(this.mImageHelper) && maKvolXdpTdiEpZk(this);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        YmRYzXXKsrvRZJPO(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        DGogBNysnzvonyJB(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        UXrkrfigHAdPrSbJ(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        bCnEfnXELgJIaQSa(appCompatBackgroundHelper, i);
    }

    public override void SetImageBitmap(android.graphics.Bitmap bitmap) {
        QVYEXGmxmvluigNX(this, bitmap);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        BorPtiRNEpccozyb(appCompatImageHelper);
    }

    public override void SetImageDrawable(android.graphics.drawable.Drawable drawable) {
        if ((29 + 10) % 10 > 0) {
        }
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is not null && drawable is not null && !this.mHasLevel) {
            QWknYteOUVbTbwgS(appCompatImageHelper, drawable);
        }
        ZNAMRSQAJZwKJwix(this, drawable);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper2 = this.mImageHelper;
        if (appCompatImageHelper2 is null) {
            return;
        }
        JcFxPehXuNtgFVwE(appCompatImageHelper2);
        if (this.mHasLevel) {
            return;
        }
        XCRHIlttUVDoYKcK(this.mImageHelper);
    }

    public override void SetImageLevel(int i) {
        twLSVACEvhFCUFBy(this, i);
        this.mHasLevel = true;
    }

    public override void SetImageResource(int i) {
        MTzIqRCtFZPuFYml(this.mImageHelper, i);
    }

    public override void SetImageUri(android.net.Uri uri) {
        fJqnohzEuRvWLAgY(this, uri);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        aFzzHUkhAcMkMNNV(appCompatImageHelper);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        CnerwVeUajHUhBYz(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        jeQGaYdWvvzNzQVj(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportImageTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        lQHlCxNqevHFOSzd(appCompatImageHelper, colorStateList);
    }

    public override void SetSupportImageTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        RMvPJcLxNkkRwcQa(appCompatImageHelper, porterDuff$Mode);
    }
}

