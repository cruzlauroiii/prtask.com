namespace WillowMaze.Wasm.Decompiled;


public class AppCompatImageobject : android.widget.Imageobject : androidx.core.view.TintableBackgroundobject, androidx.core.widget.TintableImageSourceobject {
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private bool mHasLevel;
    private readonly androidx.appcompat.widget.AppCompatImageHelper mImageHelper;

    public AppCompatImageobject(android.content.object context) {
        this(context, null);
    }

    public AppCompatImageobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public AppCompatImageobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(JkAAqOoCpYqglXti(context), attributeHashSet, i);
        this.mHasLevel = false;
        UJqxOpObiXLydXws(this, ZOPnBCNHKetsJftT(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        hEPRUhkZJIgsZvVj(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = new androidx.appcompat.widget.AppCompatImageHelper(this);
        this.mImageHelper = appCompatImageHelper;
        TjvBThRmSOsRCNVW(appCompatImageHelper, attributeHashSet, i);
    }

    public static void ANXBGNNKgOxcWCgp(android.widget.Imageobject imageobject, int i) {
        super.setBackgroundResource(i);
    }

    public static bool AbFkQhjkPIRiUKaA(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.hasOverlappingRendering();
    }

    public static bool HDFeVeOCUbxlxdFU(android.widget.Imageobject imageobject) {
        return super.hasOverlappingRendering();
    }

    public static android.graphics.PorterDuff$Mode HoHvpiVsKKVAxZsV(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.getSupportImageTintMode();
    }

    public static void JTQzFRywBgThGaaI(android.widget.Imageobject imageobject) {
        super.drawableStateChanged();
    }

    public static android.content.object JkAAqOoCpYqglXti(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void KApeCkdwkMBNtBDb(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.graphics.drawable.Drawable drawable) {
        appCompatImageHelper.obtainLevelFromDrawable(drawable);
    }

    public static android.graphics.PorterDuff$Mode KeAemXVWTmYWnHua(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static void MZpPhDsAYxgFaOJU(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applyImageLevel();
    }

    public static void OGvBAgaWRWiyipVf(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        super.setImageDrawable(drawable);
    }

    public static void OQyysSoLRcbbubUg(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void RHmkVVHUFJIIOwDA(android.widget.Imageobject imageobject, int i) {
        super.setImageLevel(i);
    }

    public static void RzLEkqBjIhovFLOA(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void TjvBThRmSOsRCNVW(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatImageHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void UJqxOpObiXLydXws(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void WSFTQhXfZhKOWkdh(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, int i) {
        appCompatImageHelper.setImageResource(i);
    }

    public static void YWaFMGksTZNmDWfr(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static android.content.object ZOPnBCNHKetsJftT(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        return appCompatImageobject.getobject();
    }

    public static void CxfRqEECHLkYOaah(android.widget.Imageobject imageobject, android.net.Uri uri) {
        super.setImageUri(uri);
    }

    public static void HEPRUhkZJIgsZvVj(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void IQUXWlunINKrgGDY(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void IdyhlsRHHNSejhjQ(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatImageHelper.setSupportImageTintMode(porterDuff$Mode);
    }

    public static android.content.res.ColorStateList KZqoWCjLfuwojVWJ(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.getSupportImageTintList();
    }

    public static void LjhCbeULdJSWbGir(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static void MweftuUWYtecBPZv(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void QlSLeBOgezgGVjGe(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.content.res.ColorStateList colorStateList) {
        appCompatImageHelper.setSupportImageTintList(colorStateList);
    }

    public static void QnLXfAnWHWRBxuoJ(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void TzASdetlBiGxhcqH(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static android.content.res.ColorStateList VbQYwSFlOPieeCEI(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static void VfYyWrxzXEPFOaix(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static void ZFGORaLhYShqSePU(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static void ZnmWCksVjZpfmYZn(android.widget.Imageobject imageobject, android.graphics.Bitmap bitmap) {
        super.setImageBitmap(bitmap);
    }

    protected override void DrawableStateChanged() {
        JTQzFRywBgThGaaI(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            OQyysSoLRcbbubUg(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        RzLEkqBjIhovFLOA(appCompatImageHelper);
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return vbQYwSFlOPieeCEI(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return KeAemXVWTmYWnHua(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportImageTintList() {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return null;
        }
        return kZqoWCjLfuwojVWJ(appCompatImageHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportImageTintMode() {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return null;
        }
        return HoHvpiVsKKVAxZsV(appCompatImageHelper);
    }

    public override bool HasOverlappingRendering() {
        return AbFkQhjkPIRiUKaA(this.mImageHelper) && HDFeVeOCUbxlxdFU(this);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        tzASdetlBiGxhcqH(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        zFGORaLhYShqSePU(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        ANXBGNNKgOxcWCgp(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        vfYyWrxzXEPFOaix(appCompatBackgroundHelper, i);
    }

    public override void SetImageBitmap(android.graphics.Bitmap bitmap) {
        znmWCksVjZpfmYZn(this, bitmap);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        YWaFMGksTZNmDWfr(appCompatImageHelper);
    }

    public override void SetImageDrawable(android.graphics.drawable.Drawable drawable) {
        if ((9 + 25) % 25 > 0) {
        }
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is not null && drawable is not null && !this.mHasLevel) {
            KApeCkdwkMBNtBDb(appCompatImageHelper, drawable);
        }
        OGvBAgaWRWiyipVf(this, drawable);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper2 = this.mImageHelper;
        if (appCompatImageHelper2 is null) {
            return;
        }
        iQUXWlunINKrgGDY(appCompatImageHelper2);
        if (this.mHasLevel) {
            return;
        }
        MZpPhDsAYxgFaOJU(this.mImageHelper);
    }

    public override void SetImageLevel(int i) {
        RHmkVVHUFJIIOwDA(this, i);
        this.mHasLevel = true;
    }

    public override void SetImageResource(int i) {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        WSFTQhXfZhKOWkdh(appCompatImageHelper, i);
    }

    public override void SetImageUri(android.net.Uri uri) {
        cxfRqEECHLkYOaah(this, uri);
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        qnLXfAnWHWRBxuoJ(appCompatImageHelper);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        ljhCbeULdJSWbGir(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        mweftuUWYtecBPZv(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportImageTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        qlSLeBOgezgGVjGe(appCompatImageHelper, colorStateList);
    }

    public override void SetSupportImageTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper = this.mImageHelper;
        if (appCompatImageHelper is null) {
            return;
        }
        idyhlsRHHNSejhjQ(appCompatImageHelper, porterDuff$Mode);
    }
}

