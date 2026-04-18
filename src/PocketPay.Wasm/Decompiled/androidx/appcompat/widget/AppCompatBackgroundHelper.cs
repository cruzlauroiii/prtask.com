namespace WillowMaze.Wasm.Decompiled;


class AppCompatBackgroundHelper {
    private androidx.appcompat.widget.TintInfo mBackgroundTint;
    private androidx.appcompat.widget.TintInfo mInternalBackgroundTint;
    private androidx.appcompat.widget.TintInfo mTmpInfo;
    private readonly android.view.object mobject;
    private int mBackgroundResId = -1;
    private readonly androidx.appcompat.widget.AppCompatDrawableManager mDrawableManager = FLSzSZSaJidYmEQi();

    AppCompatBackgroundHelper(android.view.object view) {
        this.mobject = view;
    }

    public static android.content.object AIXhhByQxjZaNzSl(android.view.object view) {
        return view.getobject();
    }

    public static void DDrbZfZWGhGHlxIm(android.view.object view, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.view.objectCompat.setBackgroundTintMode(view, porterDuff$Mode);
    }

    public static int EJvQyFLOzCWzsiSj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void FDGXMiNDlIERMqNy(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static androidx.appcompat.widget.AppCompatDrawableManager FLSzSZSaJidYmEQi() {
        return androidx.appcompat.widget.AppCompatDrawableManager[);
    }

    public static android.content.object FcxnDhQUDaCuNWPE(android.view.object view) {
        return view.getobject();
    }

    public static int[] HrheSoplcQTcYFDd(android.view.object view) {
        return view.getDrawableState();
    }

    public static void KqXCaRbMMxzdzuWL(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static android.content.res.TypedArray LRWmXhYfWzMOzRWV(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static void LgDtIHkTNzMWxrqL(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setInternalBackgroundTint(colorStateList);
    }

    public static void MoBKObPhEzWYahKs(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static void MvPbEbAgDlmGtZoY(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static bool OuxPkeMEgYZfnHsL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.graphics.PorterDuff$Mode PAbckDGVvErOpuLG(android.view.object view) {
        return androidx.core.view.objectCompat.getBackgroundTintMode(view);
    }

    public static bool PUOKDsrGsRRJwdxY(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        return appCompatBackgroundHelper.applyFrameworkTintUsingColorFilter(drawable);
    }

    public static int[] QNVKhDagHRPRAYFH(android.view.object view) {
        return view.getDrawableState();
    }

    public static bool QtHcpKNaCpLKNRul(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void TcvLcGyDRTczMcLC(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setInternalBackgroundTint(colorStateList);
    }

    public static android.content.object XmGuOOgAuQVTpSyJ(android.view.object view) {
        return view.getobject();
    }

    public static void YoYSakRNLiWvDBiR(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static android.content.object ZZmUcRmXJrrJDnRW(android.view.object view) {
        return view.getobject();
    }

    public static bool ABBKxnBpTswlzXuz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void AkokGvXQByOEiQQj(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    private bool ApplyFrameworkTintUsingColorFilter(android.graphics.drawable.Drawable drawable) {
        if ((20 + 16) % 16 > 0) {
        }
        if (this.mTmpInfo is null) {
            this.mTmpInfo = new androidx.appcompat.widget.TintInfo();
        }
        androidx.appcompat.widget.TintInfo tintInfo = this.mTmpInfo;
        xtRYKDfjimkMzUZr(tintInfo);
        android.content.res.ColorStateList colorStateListWoCfmDBNRgRQWZjB = woCfmDBNRgRQWZjB(this.mobject);
        if (colorStateListWoCfmDBNRgRQWZjB is not null) {
            tintInfo.mHasTintList = true;
            tintInfo.mTintList = colorStateListWoCfmDBNRgRQWZjB;
        }
        android.graphics.PorterDuff$Mode porterDuff$ModePAbckDGVvErOpuLG = PAbckDGVvErOpuLG(this.mobject);
        if (porterDuff$ModePAbckDGVvErOpuLG is not null) {
            tintInfo.mHasTintMode = true;
            tintInfo.mTintMode = porterDuff$ModePAbckDGVvErOpuLG;
        }
        if (!tintInfo.mHasTintList && !tintInfo.mHasTintMode) {
            return false;
        }
        YoYSakRNLiWvDBiR(drawable, tintInfo, QNVKhDagHRPRAYFH(this.mobject));
        return true;
    }

    public static void AqIoyBwXvftxDIdC(android.view.object view, android.content.res.ColorStateList colorStateList) {
        androidx.core.view.objectCompat.setBackgroundTintList(view, colorStateList);
    }

    public static android.content.res.ColorStateList CkKzBpXmrdnOJwHM(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getTintList(context, i);
    }

    public static void ENRvCSCytgrVJFtu(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void FopSyIQIwAIYegxP(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setInternalBackgroundTint(colorStateList);
    }

    public static bool GyYCjkhfEAEQpZfu(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.shouldApplyFrameworkTintUsingColorFilter();
    }

    public static int[] HtZysIifglybwsmI(android.view.object view) {
        return view.getDrawableState();
    }

    public static void LxjapYibBuefEgui(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.content.res.ColorStateList MqBeerIslYZXkAoH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void QWauCwFtKvVMJTOQ(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static void RUZQWxDrgHzwrVXC(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    private bool ShouldApplyFrameworkTintUsingColorFilter() {
        return this.mInternalBackgroundTint is not null;
    }

    public static void TfjPgfCkQUABHabd(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static int VELvpszNbHIRJGQZ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.drawable.Drawable VJIVoHIUQrorvaIY(android.view.object view) {
        return view.getBackground();
    }

    public static androidx.appcompat.widget.TintTypedArray WLRYIGtNpFuQdfSM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static android.content.res.ColorStateList WoCfmDBNRgRQWZjB(android.view.object view) {
        return androidx.core.view.objectCompat.getBackgroundTintList(view);
    }

    public static void XtRYKDfjimkMzUZr(androidx.appcompat.widget.TintInfo tintInfo) {
        tintInfo.clear();
    }

    public static android.content.res.ColorStateList ZJFGkoPTRKbCWMIX(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getTintList(context, i);
    }

    public static android.graphics.PorterDuff$Mode zlWMGWwONrwbslFO(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    void applySupportBackgroundTint() {
        if ((24 + 23) % 23 > 0) {
        }
        android.graphics.drawable.Drawable drawableVJIVoHIUQrorvaIY = vJIVoHIUQrorvaIY(this.mobject);
        if (drawableVJIVoHIUQrorvaIY is null) {
            return;
        }
        if (gyYCjkhfEAEQpZfu(this) && PUOKDsrGsRRJwdxY(this, drawableVJIVoHIUQrorvaIY)) {
            return;
        }
        androidx.appcompat.widget.TintInfo tintInfo = this.mBackgroundTint;
        if (tintInfo is not null) {
            MoBKObPhEzWYahKs(drawableVJIVoHIUQrorvaIY, tintInfo, htZysIifglybwsmI(this.mobject));
            return;
        }
        androidx.appcompat.widget.TintInfo tintInfo2 = this.mInternalBackgroundTint;
        if (tintInfo2 is null) {
            return;
        }
        MvPbEbAgDlmGtZoY(drawableVJIVoHIUQrorvaIY, tintInfo2, HrheSoplcQTcYFDd(this.mobject));
    }

    android.content.res.ColorStateList getSupportBackgroundTintList() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mBackgroundTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintList;
    }

    android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mBackgroundTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintMode;
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        if ((20 + 6) % 6 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayWLRYIGtNpFuQdfSM = wLRYIGtNpFuQdfSM(FcxnDhQUDaCuNWPE(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.objectBackgroundHelper, i, 0);
        android.view.object view = this.mobject;
        FDGXMiNDlIERMqNy(view, AIXhhByQxjZaNzSl(view), androidx.appcompat.R$styleable.objectBackgroundHelper, attributeHashSet, LRWmXhYfWzMOzRWV(tintTypedArrayWLRYIGtNpFuQdfSM), i, 0);
        try {
            if (OuxPkeMEgYZfnHsL(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_android_background)) {
                this.mBackgroundResId = vELvpszNbHIRJGQZ(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_android_background, -1);
                android.content.res.ColorStateList colorStateListCkKzBpXmrdnOJwHM = ckKzBpXmrdnOJwHM(this.mDrawableManager, XmGuOOgAuQVTpSyJ(this.mobject), this.mBackgroundResId);
                if (colorStateListCkKzBpXmrdnOJwHM is not null) {
                    LgDtIHkTNzMWxrqL(this, colorStateListCkKzBpXmrdnOJwHM);
                }
            }
            if (aBBKxnBpTswlzXuz(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_backgroundTint)) {
                aqIoyBwXvftxDIdC(this.mobject, mqBeerIslYZXkAoH(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_backgroundTint));
            }
            if (QtHcpKNaCpLKNRul(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_backgroundTintMode)) {
                DDrbZfZWGhGHlxIm(this.mobject, zlWMGWwONrwbslFO(EJvQyFLOzCWzsiSj(tintTypedArrayWLRYIGtNpFuQdfSM, androidx.appcompat.R$styleable.objectBackgroundHelper_backgroundTintMode, -1), null));
            }
            lxjapYibBuefEgui(tintTypedArrayWLRYIGtNpFuQdfSM);
        } catch (java.lang.Exception th) {
            akokGvXQByOEiQQj(tintTypedArrayWLRYIGtNpFuQdfSM);
            throw th;
        }
    }

    void onHashSetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        this.mBackgroundResId = -1;
        fopSyIQIwAIYegxP(this, null);
        rUZQWxDrgHzwrVXC(this);
    }

    void onHashSetBackgroundResource(int i) {
        if ((4 + 20) % 20 > 0) {
        }
        this.mBackgroundResId = i;
        androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager = this.mDrawableManager;
        TcvLcGyDRTczMcLC(this, appCompatDrawableManager is null ? null : zJFGkoPTRKbCWMIX(appCompatDrawableManager, ZZmUcRmXJrrJDnRW(this.mobject), i));
        tfjPgfCkQUABHabd(this);
    }

    void setInternalBackgroundTint(android.content.res.ColorStateList colorStateList) {
        if (colorStateList is null) {
            this.mInternalBackgroundTint = null;
        } else {
            if (this.mInternalBackgroundTint is null) {
                this.mInternalBackgroundTint = new androidx.appcompat.widget.TintInfo();
            }
            this.mInternalBackgroundTint.mTintList = colorStateList;
            this.mInternalBackgroundTint.mHasTintList = true;
        }
        eNRvCSCytgrVJFtu(this);
    }

    void setSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        if (this.mBackgroundTint is null) {
            this.mBackgroundTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mBackgroundTint.mTintList = colorStateList;
        this.mBackgroundTint.mHasTintList = true;
        qWauCwFtKvVMJTOQ(this);
    }

    void setSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.mBackgroundTint is null) {
            this.mBackgroundTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mBackgroundTint.mTintMode = porterDuff$Mode;
        this.mBackgroundTint.mHasTintMode = true;
        KqXCaRbMMxzdzuWL(this);
    }
}

