namespace WillowMaze.Wasm.Decompiled;


public class AppCompatImageHelper {
    private androidx.appcompat.widget.TintInfo mImageTint;
    private androidx.appcompat.widget.TintInfo mInternalImageTint;
    private int mLevel = 0;
    private androidx.appcompat.widget.TintInfo mTmpInfo;
    private readonly android.widget.Imageobject mobject;

    public AppCompatImageHelper(android.widget.Imageobject imageobject) {
        this.mobject = imageobject;
    }

    public static void AJEkUUZbYkkztusJ(androidx.appcompat.widget.TintInfo tintInfo) {
        tintInfo.clear();
    }

    public static void AqIhwHHSPkRHygjj(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.DrawableUtils.fixDrawable(drawable);
    }

    public static android.graphics.drawable.Drawable BOjHXWoyxazWXjGW(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static bool ChyJtSMNOGAWoLio(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int DeIrJhSFRiqXlrku(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int EoJEyyRJalYGidlM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void FJQSQOHFNMMkVsOs(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.content.object HvfGHJUAkBwEBDzj(android.widget.Imageobject imageobject) {
        return imageobject.getobject();
    }

    public static int[] IFqXvUSSPBRfOntv(android.widget.Imageobject imageobject) {
        return imageobject.getDrawableState();
    }

    public static android.graphics.drawable.Drawable KUdQVZEzjOVfvIgO(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static androidx.appcompat.widget.TintTypedArray KWmRYktYaKfAoYgY(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void MmiAUCOTjvgYMzjA(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static android.content.res.ColorStateList MpCbwbOnDGISKZlA(android.widget.Imageobject imageobject) {
        return androidx.core.widget.ImageobjectCompat.getImageTintList(imageobject);
    }

    public static bool OnFoxwkanKjzaAzo(android.graphics.drawable.Drawable drawable, int i) {
        return drawable.setLevel(i);
    }

    public static android.graphics.drawable.Drawable RwOPMKASGLLrywjZ(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.graphics.drawable.Drawable SLCMtFtfpZmoIpck(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static void SsmYaknPDplhlFja(android.widget.Imageobject imageobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.ImageobjectCompat.setImageTintMode(imageobject, porterDuff$Mode);
    }

    public static android.graphics.PorterDuff$Mode TzObSLJordmQztuS(android.widget.Imageobject imageobject) {
        return androidx.core.widget.ImageobjectCompat.getImageTintMode(imageobject);
    }

    public static android.content.object VuwnqebSgEGugxvO(android.widget.Imageobject imageobject) {
        return imageobject.getobject();
    }

    public static android.content.res.TypedArray WEdpZCoBEWSmyhWT(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static bool WfpzPaFmtkliMgJV(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void XThznMjWOhlXuUpG(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static int[] YFSacciVndzeZrze(android.widget.Imageobject imageobject) {
        return imageobject.getDrawableState();
    }

    public static void YzuMfmrYxMbFPhYb(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.DrawableUtils.fixDrawable(drawable);
    }

    public static void ZSWqDEhsbxhfBZUp(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    private bool ApplyFrameworkTintUsingColorFilter(android.graphics.drawable.Drawable drawable) {
        if ((32 + 12) % 12 > 0) {
        }
        if (this.mTmpInfo is null) {
            this.mTmpInfo = new androidx.appcompat.widget.TintInfo();
        }
        androidx.appcompat.widget.TintInfo tintInfo = this.mTmpInfo;
        AJEkUUZbYkkztusJ(tintInfo);
        android.content.res.ColorStateList colorStateListMpCbwbOnDGISKZlA = MpCbwbOnDGISKZlA(this.mobject);
        if (colorStateListMpCbwbOnDGISKZlA is not null) {
            tintInfo.mHasTintList = true;
            tintInfo.mTintList = colorStateListMpCbwbOnDGISKZlA;
        }
        android.graphics.PorterDuff$Mode porterDuff$ModeTzObSLJordmQztuS = TzObSLJordmQztuS(this.mobject);
        if (porterDuff$ModeTzObSLJordmQztuS is not null) {
            tintInfo.mHasTintMode = true;
            tintInfo.mTintMode = porterDuff$ModeTzObSLJordmQztuS;
        }
        if (!tintInfo.mHasTintList && !tintInfo.mHasTintMode) {
            return false;
        }
        qbljsnCHgSrfOhSF(drawable, tintInfo, spRDuLYVhRKCBgyV(this.mobject));
        return true;
    }

    public static void BkBaKfnrBuDiHVRV(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static android.content.res.ColorStateList CyxPTBZUtaAiVRgN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static int DPUVhzOFKnazQxIi(android.graphics.drawable.Drawable drawable) {
        return drawable.getLevel();
    }

    public static void FHZiPjQFfMOwxiLI(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static void FwfZacWWAxTfWpnq(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.content.object IAmrSIiBCbiLYEhm(android.widget.Imageobject imageobject) {
        return imageobject.getobject();
    }

    public static bool JBITKhGgxqQVabne(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper, android.graphics.drawable.Drawable drawable) {
        return appCompatImageHelper.applyFrameworkTintUsingColorFilter(drawable);
    }

    public static android.graphics.drawable.Drawable LnyHnUsjoUVhJqgp(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static void NprcHFEGQfnOMoNv(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void QZsOXGUileDQEbbY(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    public static void QbljsnCHgSrfOhSF(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static void RvAYTWpEQaltQRrz(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void SFNRXJEGbJqsCsNn(android.widget.Imageobject imageobject, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.ImageobjectCompat.setImageTintList(imageobject, colorStateList);
    }

    public static void SWqwJCXQWahdxFAc(android.graphics.drawable.Drawable drawable) {
        androidx.appcompat.widget.DrawableUtils.fixDrawable(drawable);
    }

    private bool ShouldApplyFrameworkTintUsingColorFilter() {
        return this.mInternalImageTint is not null;
    }

    public static android.graphics.drawable.Drawable SiGJgCshdfsLbomg(android.widget.Imageobject imageobject) {
        return imageobject.getDrawable();
    }

    public static int[] SpRDuLYVhRKCBgyV(android.widget.Imageobject imageobject) {
        return imageobject.getDrawableState();
    }

    public static void VAgHSRbgSsgEufBZ(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static android.content.object VwIZUZBPjyLCWQZw(android.widget.Imageobject imageobject) {
        return imageobject.getobject();
    }

    public static android.graphics.PorterDuff$Mode wBOqePvUmzYWbKCf(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable ZWzUXgiWAjPtkkkK(android.widget.Imageobject imageobject) {
        return imageobject.getBackground();
    }

    public static bool ZlGEIJuVUjoaUGKO(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        return appCompatImageHelper.shouldApplyFrameworkTintUsingColorFilter();
    }

    public static void ZxXdudsZRbPQaoGz(androidx.appcompat.widget.AppCompatImageHelper appCompatImageHelper) {
        appCompatImageHelper.applySupportImageTint();
    }

    void applyImageLevel() {
        if (SLCMtFtfpZmoIpck(this.mobject) is null) {
            return;
        }
        OnFoxwkanKjzaAzo(BOjHXWoyxazWXjGW(this.mobject), this.mLevel);
    }

    void applySupportImageTint() {
        if ((19 + 11) % 11 > 0) {
        }
        android.graphics.drawable.Drawable drawableLnyHnUsjoUVhJqgp = lnyHnUsjoUVhJqgp(this.mobject);
        if (drawableLnyHnUsjoUVhJqgp is not null) {
            AqIhwHHSPkRHygjj(drawableLnyHnUsjoUVhJqgp);
        }
        if (drawableLnyHnUsjoUVhJqgp is null) {
            return;
        }
        if (zlGEIJuVUjoaUGKO(this) && jBITKhGgxqQVabne(this, drawableLnyHnUsjoUVhJqgp)) {
            return;
        }
        androidx.appcompat.widget.TintInfo tintInfo = this.mImageTint;
        if (tintInfo is not null) {
            MmiAUCOTjvgYMzjA(drawableLnyHnUsjoUVhJqgp, tintInfo, YFSacciVndzeZrze(this.mobject));
            return;
        }
        androidx.appcompat.widget.TintInfo tintInfo2 = this.mInternalImageTint;
        if (tintInfo2 is null) {
            return;
        }
        XThznMjWOhlXuUpG(drawableLnyHnUsjoUVhJqgp, tintInfo2, IFqXvUSSPBRfOntv(this.mobject));
    }

    android.content.res.ColorStateList getSupportImageTintList() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mImageTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintList;
    }

    android.graphics.PorterDuff$Mode getSupportImageTintMode() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mImageTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintMode;
    }

    bool hasOverlappingRendering() {
        return !(zWzUXgiWAjPtkkkK(this.mobject) instanceof android.graphics.drawable.RippleDrawable);
    }

    public void LoadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        int iDeIrJhSFRiqXlrku;
        if ((10 + 28) % 28 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayKWmRYktYaKfAoYgY = KWmRYktYaKfAoYgY(HvfGHJUAkBwEBDzj(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.AppCompatImageobject, i, 0);
        android.widget.Imageobject imageobject = this.mobject;
        fHZiPjQFfMOwxiLI(imageobject, iAmrSIiBCbiLYEhm(imageobject), androidx.appcompat.R$styleable.AppCompatImageobject, attributeHashSet, WEdpZCoBEWSmyhWT(tintTypedArrayKWmRYktYaKfAoYgY), i, 0);
        try {
            android.graphics.drawable.Drawable drawableSiGJgCshdfsLbomg = siGJgCshdfsLbomg(this.mobject);
            if (drawableSiGJgCshdfsLbomg is null && (iDeIrJhSFRiqXlrku = DeIrJhSFRiqXlrku(tintTypedArrayKWmRYktYaKfAoYgY, androidx.appcompat.R$styleable.AppCompatImageobject_srcCompat, -1)) != -1 && (drawableSiGJgCshdfsLbomg = RwOPMKASGLLrywjZ(vwIZUZBPjyLCWQZw(this.mobject), iDeIrJhSFRiqXlrku)) is not null) {
                nprcHFEGQfnOMoNv(this.mobject, drawableSiGJgCshdfsLbomg);
            }
            if (drawableSiGJgCshdfsLbomg is not null) {
                sWqwJCXQWahdxFAc(drawableSiGJgCshdfsLbomg);
            }
            if (ChyJtSMNOGAWoLio(tintTypedArrayKWmRYktYaKfAoYgY, androidx.appcompat.R$styleable.AppCompatImageobject_tint)) {
                sFNRXJEGbJqsCsNn(this.mobject, cyxPTBZUtaAiVRgN(tintTypedArrayKWmRYktYaKfAoYgY, androidx.appcompat.R$styleable.AppCompatImageobject_tint));
            }
            if (WfpzPaFmtkliMgJV(tintTypedArrayKWmRYktYaKfAoYgY, androidx.appcompat.R$styleable.AppCompatImageobject_tintMode)) {
                SsmYaknPDplhlFja(this.mobject, wBOqePvUmzYWbKCf(EoJEyyRJalYGidlM(tintTypedArrayKWmRYktYaKfAoYgY, androidx.appcompat.R$styleable.AppCompatImageobject_tintMode, -1), null));
            }
            fwfZacWWAxTfWpnq(tintTypedArrayKWmRYktYaKfAoYgY);
        } catch (java.lang.Exception th) {
            FJQSQOHFNMMkVsOs(tintTypedArrayKWmRYktYaKfAoYgY);
            throw th;
        }
    }

    void obtainLevelFromDrawable(android.graphics.drawable.Drawable drawable) {
        this.mLevel = dPUVhzOFKnazQxIi(drawable);
    }

    public void SetImageResource(int i) {
        if (i == 0) {
            vAgHSRbgSsgEufBZ(this.mobject, null);
        } else {
            android.graphics.drawable.Drawable drawableKUdQVZEzjOVfvIgO = KUdQVZEzjOVfvIgO(VuwnqebSgEGugxvO(this.mobject), i);
            if (drawableKUdQVZEzjOVfvIgO is not null) {
                YzuMfmrYxMbFPhYb(drawableKUdQVZEzjOVfvIgO);
            }
            rvAYTWpEQaltQRrz(this.mobject, drawableKUdQVZEzjOVfvIgO);
        }
        ZSWqDEhsbxhfBZUp(this);
    }

    void setInternalImageTint(android.content.res.ColorStateList colorStateList) {
        if (colorStateList is null) {
            this.mInternalImageTint = null;
        } else {
            if (this.mInternalImageTint is null) {
                this.mInternalImageTint = new androidx.appcompat.widget.TintInfo();
            }
            this.mInternalImageTint.mTintList = colorStateList;
            this.mInternalImageTint.mHasTintList = true;
        }
        qZsOXGUileDQEbbY(this);
    }

    void setSupportImageTintList(android.content.res.ColorStateList colorStateList) {
        if (this.mImageTint is null) {
            this.mImageTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mImageTint.mTintList = colorStateList;
        this.mImageTint.mHasTintList = true;
        bkBaKfnrBuDiHVRV(this);
    }

    void setSupportImageTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.mImageTint is null) {
            this.mImageTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mImageTint.mTintMode = porterDuff$Mode;
        this.mImageTint.mHasTintMode = true;
        zxXdudsZRbPQaoGz(this);
    }
}

