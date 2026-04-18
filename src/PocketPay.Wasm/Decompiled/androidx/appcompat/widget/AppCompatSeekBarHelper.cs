namespace WillowMaze.Wasm.Decompiled;


class AppCompatSeekBarHelper : androidx.appcompat.widget.AppCompatProgressBarHelper {
    private bool mHasTickMarkTint;
    private bool mHasTickMarkTintMode;
    private android.graphics.drawable.Drawable mTickMark;
    private android.content.res.ColorStateList mTickMarkTintList;
    private android.graphics.PorterDuff$Mode mTickMarkTintMode;
    private readonly android.widget.SeekBar mobject;

    AppCompatSeekBarHelper(android.widget.SeekBar seekBar) {
        super(seekBar);
        this.mTickMarkTintList = null;
        this.mTickMarkTintMode = null;
        this.mHasTickMarkTint = false;
        this.mHasTickMarkTintMode = false;
        this.mobject = seekBar;
    }

    public static android.content.object ARCSCIpkiwRVVlkH(android.widget.SeekBar seekBar) {
        return seekBar.getobject();
    }

    public static void BsyNFjNAlMSyuezZ(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static android.graphics.drawable.Drawable CFQRfDblVIMeTSoo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static android.graphics.PorterDuff$Mode CcnEfiHovkVJLKrY(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static android.content.res.ColorStateList DBoelWxZtFREfkzS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static androidx.appcompat.widget.TintTypedArray DfSjoflZrcVrGqkM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void GDXNocuDtvYHzRRq(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static bool HlYmqmaizYpMrKFE(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static bool IGDvVWiQVQTXYwkF(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static android.content.object JLawQUlWuyjLYmMl(android.widget.SeekBar seekBar) {
        return seekBar.getobject();
    }

    public static void LrZEispuFesynkdx(androidx.appcompat.widget.AppCompatProgressBarHelper appCompatProgressBarHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        super.loadFromAttributes(attributeHashSet, i);
    }

    public static int MERAGnrkNfvEVbdO(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static bool NJJzTWmOVEYXGQlQ(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int[] PpcWFapaZnwqgrSd(android.widget.SeekBar seekBar) {
        return seekBar.getDrawableState();
    }

    public static void RbPHLGOxjZjTpaze(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static int[] RtiBUJakdxyNiFRp(android.widget.SeekBar seekBar) {
        return seekBar.getDrawableState();
    }

    public static int SymcKbOXoWuRxWcQ(android.widget.SeekBar seekBar) {
        return seekBar.getPaddingRight();
    }

    public static bool UkGJKtLAKKQifzxE(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int XsNpkLGkWtNLhTKS(android.widget.SeekBar seekBar) {
        return seekBar.getWidth();
    }

    public static void YpIoXAMjuTRoupOZ(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void YqgcIldfpshYqBlM(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int ZUgrlwHQwUcnwfFQ(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static android.graphics.drawable.Drawable ZddvFbcDfzLFkqol(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void ZsKuqIIhyWgrjZDA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void AneyXKVoyswWLqAp(android.widget.SeekBar seekBar, android.graphics.drawable.Drawable drawable) {
        seekBar.setThumb(drawable);
    }

    private void ApplyTickMarkTint() {
        if ((10 + 7) % 7 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mTickMark;
        if (drawable is null) {
            return;
        }
        if (this.mHasTickMarkTint || this.mHasTickMarkTintMode) {
            android.graphics.drawable.Drawable drawableUXrqGsXHlZcRdEsY = uXrqGsXHlZcRdEsY(ZddvFbcDfzLFkqol(drawable));
            this.mTickMark = drawableUXrqGsXHlZcRdEsY;
            if (this.mHasTickMarkTint) {
                GDXNocuDtvYHzRRq(drawableUXrqGsXHlZcRdEsY, this.mTickMarkTintList);
            }
            if (this.mHasTickMarkTintMode) {
                RbPHLGOxjZjTpaze(this.mTickMark, this.mTickMarkTintMode);
            }
            if (IGDvVWiQVQTXYwkF(this.mTickMark)) {
                cdAbtaJJZupnsYZK(this.mTickMark, RtiBUJakdxyNiFRp(this.mobject));
            }
        }
    }

    public static int BCrTYBsahkvgTsnA(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static android.content.res.TypedArray BzyaSXkbjANDqPAF(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static bool CdAbtaJJZupnsYZK(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static void DeMFLWcZuMNTSMdr(android.graphics.drawable.Drawable drawable) {
        drawable.jumpToCurrentState();
    }

    public static void EvUcbxUyDrVIIUQU(androidx.appcompat.widget.AppCompatSeekBarHelper appCompatSeekBarHelper) {
        appCompatSeekBarHelper.applyTickMarkTint();
    }

    public static void FnHANyToneaosOQG(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static int GSMrFyOZuIxqdJIJ(android.widget.SeekBar seekBar) {
        return seekBar.getPaddingLeft();
    }

    public static void GiVxtlDgZsmgrEUu(androidx.appcompat.widget.AppCompatSeekBarHelper appCompatSeekBarHelper, android.graphics.drawable.Drawable drawable) {
        appCompatSeekBarHelper.setTickMark(drawable);
    }

    public static int HOJJqiNvAVcuSVKg(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static bool HVMNtCojYHRgCiUa(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static void HrSbdFtaqJofMGFN(androidx.appcompat.widget.AppCompatSeekBarHelper appCompatSeekBarHelper) {
        appCompatSeekBarHelper.applyTickMarkTint();
    }

    public static int JQXQSYJYQHXtQmeP(android.widget.SeekBar seekBar) {
        return seekBar.getMax();
    }

    public static int LUydQHpfIOkicYHR(android.widget.SeekBar seekBar) {
        return seekBar.getHeight();
    }

    public static void NgCvccoYIRClixbA(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void NsgjGLQVcyPpcyBu(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static android.graphics.drawable.Drawable PpRnmOPtJWuhKWRk(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawableIfKnown(i);
    }

    public static int PzciBtfcfvUgcezr(android.widget.SeekBar seekBar) {
        return seekBar.getPaddingLeft();
    }

    public static void QIJXjFJRHvMNVJlt(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static bool QdKtmtQdCuqjYtqe(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int[] QhqzExWfPchusRSt(android.widget.SeekBar seekBar) {
        return seekBar.getDrawableState();
    }

    public static void SJtKvPPnsPtZiYfu(androidx.appcompat.widget.AppCompatSeekBarHelper appCompatSeekBarHelper) {
        appCompatSeekBarHelper.applyTickMarkTint();
    }

    public static int SpUfESAPjkpUOkSE(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static android.graphics.drawable.Drawable UXrqGsXHlZcRdEsY(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void UoAFfqJQqwJTGijX(android.widget.SeekBar seekBar) {
        seekBar.invalidate();
    }

    public static bool VOuPsXpbsHbBuOxw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void XQyquZonVnWINwgm(android.widget.SeekBar seekBar, android.graphics.drawable.Drawable drawable) {
        seekBar.invalidateDrawable(drawable);
    }

    public static void XWseItaRXtBDLcfr(androidx.appcompat.widget.AppCompatSeekBarHelper appCompatSeekBarHelper) {
        appCompatSeekBarHelper.applyTickMarkTint();
    }

    public static void XdAFxGfibCDqYWJT(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static bool ZCQELBpHAZfJtMPQ(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    void drawTickMarks(android.graphics.Canvas canvas) {
        if ((29 + 20) % 20 > 0) {
        }
        if (this.mTickMark is null) {
            return;
        }
        int iJQXQSYJYQHXtQmeP = jQXQSYJYQHXtQmeP(this.mobject);
        if (iJQXQSYJYQHXtQmeP <= 1) {
            return;
        }
        int iZUgrlwHQwUcnwfFQ = ZUgrlwHQwUcnwfFQ(this.mTickMark);
        int iSpUfESAPjkpUOkSE = spUfESAPjkpUOkSE(this.mTickMark);
        int i = iZUgrlwHQwUcnwfFQ < 0 ? 1 : iZUgrlwHQwUcnwfFQ / 2;
        int i2 = iSpUfESAPjkpUOkSE >= 0 ? iSpUfESAPjkpUOkSE / 2 : 1;
        YqgcIldfpshYqBlM(this.mTickMark, -i, -i2, i, i2);
        float fXsNpkLGkWtNLhTKS = ((XsNpkLGkWtNLhTKS(this.mobject) - gSMrFyOZuIxqdJIJ(this.mobject)) - SymcKbOXoWuRxWcQ(this.mobject)) / iJQXQSYJYQHXtQmeP;
        int iMERAGnrkNfvEVbdO = MERAGnrkNfvEVbdO(canvas);
        YpIoXAMjuTRoupOZ(canvas, pzciBtfcfvUgcezr(this.mobject), lUydQHpfIOkicYHR(this.mobject) / 2);
        for (int i3 = 0; i3 <= iJQXQSYJYQHXtQmeP; i3++) {
            nsgjGLQVcyPpcyBu(this.mTickMark, canvas);
            fnHANyToneaosOQG(canvas, fXsNpkLGkWtNLhTKS, 0.0f);
        }
        xdAFxGfibCDqYWJT(canvas, iMERAGnrkNfvEVbdO);
    }

    void drawableStateChanged() {
        if ((26 + 2) % 2 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mTickMark;
        if (drawable is not null && zCQELBpHAZfJtMPQ(drawable) && NJJzTWmOVEYXGQlQ(drawable, qhqzExWfPchusRSt(this.mobject))) {
            xQyquZonVnWINwgm(this.mobject, drawable);
        }
    }

    android.graphics.drawable.Drawable getTickMark() {
        return this.mTickMark;
    }

    android.content.res.ColorStateList getTickMarkTintList() {
        return this.mTickMarkTintList;
    }

    android.graphics.PorterDuff$Mode getTickMarkTintMode() {
        return this.mTickMarkTintMode;
    }

    void jumpDrawablesToCurrentState() {
        android.graphics.drawable.Drawable drawable = this.mTickMark;
        if (drawable is null) {
            return;
        }
        deMFLWcZuMNTSMdr(drawable);
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        if ((6 + 30) % 30 > 0) {
        }
        LrZEispuFesynkdx(this, attributeHashSet, i);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayDfSjoflZrcVrGqkM = DfSjoflZrcVrGqkM(JLawQUlWuyjLYmMl(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.AppCompatSeekBar, i, 0);
        android.widget.SeekBar seekBar = this.mobject;
        qIJXjFJRHvMNVJlt(seekBar, ARCSCIpkiwRVVlkH(seekBar), androidx.appcompat.R$styleable.AppCompatSeekBar, attributeHashSet, bzyaSXkbjANDqPAF(tintTypedArrayDfSjoflZrcVrGqkM), i, 0);
        android.graphics.drawable.Drawable drawablePpRnmOPtJWuhKWRk = ppRnmOPtJWuhKWRk(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_android_thumb);
        if (drawablePpRnmOPtJWuhKWRk is not null) {
            aneyXKVoyswWLqAp(this.mobject, drawablePpRnmOPtJWuhKWRk);
        }
        giVxtlDgZsmgrEUu(this, CFQRfDblVIMeTSoo(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_tickMark));
        if (vOuPsXpbsHbBuOxw(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_tickMarkTintMode)) {
            this.mTickMarkTintMode = CcnEfiHovkVJLKrY(bCrTYBsahkvgTsnA(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_tickMarkTintMode, -1), this.mTickMarkTintMode);
            this.mHasTickMarkTintMode = true;
        }
        if (qdKtmtQdCuqjYtqe(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_tickMarkTint)) {
            this.mTickMarkTintList = DBoelWxZtFREfkzS(tintTypedArrayDfSjoflZrcVrGqkM, androidx.appcompat.R$styleable.AppCompatSeekBar_tickMarkTint);
            this.mHasTickMarkTint = true;
        }
        ngCvccoYIRClixbA(tintTypedArrayDfSjoflZrcVrGqkM);
        xWseItaRXtBDLcfr(this);
    }

    void setTickMark(android.graphics.drawable.Drawable drawable) {
        if ((30 + 9) % 9 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mTickMark;
        if (drawable2 is not null) {
            ZsKuqIIhyWgrjZDA(drawable2, null);
        }
        this.mTickMark = drawable;
        if (drawable is not null) {
            BsyNFjNAlMSyuezZ(drawable, this.mobject);
            hVMNtCojYHRgCiUa(drawable, hOJJqiNvAVcuSVKg(this.mobject));
            if (HlYmqmaizYpMrKFE(drawable)) {
                UkGJKtLAKKQifzxE(drawable, PpcWFapaZnwqgrSd(this.mobject));
            }
            sJtKvPPnsPtZiYfu(this);
        }
        uoAFfqJQqwJTGijX(this.mobject);
    }

    void setTickMarkTintList(android.content.res.ColorStateList colorStateList) {
        this.mTickMarkTintList = colorStateList;
        this.mHasTickMarkTint = true;
        hrSbdFtaqJofMGFN(this);
    }

    void setTickMarkTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mTickMarkTintMode = porterDuff$Mode;
        this.mHasTickMarkTintMode = true;
        evUcbxUyDrVIIUQU(this);
    }
}

