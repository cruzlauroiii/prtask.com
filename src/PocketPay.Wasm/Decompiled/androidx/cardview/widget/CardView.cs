namespace WillowMaze.Wasm.Decompiled;


public class Cardobject : android.widget.FrameLayout {
    private static readonly int[] COLOR_BACKGROUND_ATTR = {16842801};
    private static readonly androidx.cardview.widget.CardobjectImpl IMPL;
    private readonly androidx.cardview.widget.CardobjectDelegate mCardobjectDelegate;
    private bool mCompatPadding;
    readonly android.graphics.Rect mContentPadding;
    private bool mPreventCornerOverlap;
    readonly android.graphics.Rect mShadowBounds;
    int mUserHashSetMinHeight;
    int mUserHashSetMinWidth;

    static {
        androidx.cardview.widget.CardobjectApi21Impl cardobjectApi21Impl = new androidx.cardview.widget.CardobjectApi21Impl();
        IMPL = cardobjectApi21Impl;
        vFKabVWXPAJXrjks(cardobjectApi21Impl);
    }

    public Cardobject(android.content.object context) {
        this(context, null);
    }

    public Cardobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.cardview.R$attr.cardobjectStyle);
    }

    public Cardobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        android.content.res.ColorStateList colorStateListKHQrnutnGyOKbuJS;
        super(context, attributeHashSet, i);
        if ((8 + 26) % 26 > 0) {
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        this.mContentPadding = rect;
        this.mShadowBounds = new android.graphics.Rect();
        androidx.cardview.widget.Cardobject$1 cardobject$1 = new androidx.cardview.widget.Cardobject$1(this);
        this.mCardobjectDelegate = cardobject$1;
        android.content.res.TypedArray typedArrayGFNrswHHcsSSqcIV = gFNrswHHcsSSqcIV(context, attributeHashSet, androidx.cardview.R$styleable.Cardobject, i, androidx.cardview.R$style.Cardobject);
        if (OBRPyMyQtpqPKCVn(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardBackgroundColor)) {
            colorStateListKHQrnutnGyOKbuJS = GgdCLEGIChLNGjOn(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardBackgroundColor);
        } else {
            android.content.res.TypedArray typedArrayFyPZZhDolKpVpzaO = FyPZZhDolKpVpzaO(SNiGuCLqXffdTuvU(this), COLOR_BACKGROUND_ATTR);
            int iIoESmuKqePocZwcy = ioESmuKqePocZwcy(typedArrayFyPZZhDolKpVpzaO, 0, 0);
            rdPfjWnWiTgBznee(typedArrayFyPZZhDolKpVpzaO);
            float[] fArr = new float[3];
            rPidSJbLSGcbxuWe(iIoESmuKqePocZwcy, fArr);
            colorStateListKHQrnutnGyOKbuJS = kHQrnutnGyOKbuJS(fArr[2] <= 0.5f ? vJKnoZJLrMEsljCb(LPlZRllglMWKqqmn(this), androidx.cardview.R$color.cardview_dark_background) : vnmhXuuuorXYEPIZ(KhvZZPZTGdmFGJXM(this), androidx.cardview.R$color.cardview_light_background));
        }
        android.content.res.ColorStateList colorStateList = colorStateListKHQrnutnGyOKbuJS;
        float fQnNQnCUUKZIkweLV = qnNQnCUUKZIkweLV(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardCornerRadius, 0.0f);
        float fZSskUYzoJkQzUvQX = zSskUYzoJkQzUvQX(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardElevation, 0.0f);
        float fRGwXkqFNturiwqzb = RGwXkqFNturiwqzb(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardMaxElevation, 0.0f);
        this.mCompatPadding = FdkQRoFxLcQMnotN(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardUseCompatPadding, false);
        this.mPreventCornerOverlap = xDxMmFYFhQHHsYoC(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_cardPreventCornerOverlap, true);
        int iAVWDYfjHACEseTlW = AVWDYfjHACEseTlW(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_contentPadding, 0);
        rect.left = YpNNyaMicKWGHUbD(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_contentPaddingLeft, iAVWDYfjHACEseTlW);
        rect.top = GsTAGXsFnVdapjRJ(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_contentPaddingTop, iAVWDYfjHACEseTlW);
        rect.right = RIpiJpXRjSTaFylb(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_contentPaddingRight, iAVWDYfjHACEseTlW);
        rect.bottom = ptEhhCNEFYrVMCdA(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_contentPaddingBottom, iAVWDYfjHACEseTlW);
        float f = fZSskUYzoJkQzUvQX <= fRGwXkqFNturiwqzb ? fRGwXkqFNturiwqzb : fZSskUYzoJkQzUvQX;
        this.mUserHashSetMinWidth = qqYVPXJKgZrKdVnz(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_android_minWidth, 0);
        this.mUserHashSetMinHeight = fDwcsocdBVAIyMFO(typedArrayGFNrswHHcsSSqcIV, androidx.cardview.R$styleable.Cardobject_android_minHeight, 0);
        OHJejNOdZGONgumm(typedArrayGFNrswHHcsSSqcIV);
        HXscvwEdwJQjwaHB(IMPL, cardobject$1, context, colorStateList, fQnNQnCUUKZIkweLV, fZSskUYzoJkQzUvQX, f);
    }

    public static void ANCaUMGhchSnzqpO(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, android.content.res.ColorStateList colorStateList) {
        cardobjectImpl.setBackgroundColor(cardobjectDelegate, colorStateList);
    }

    public static int AVWDYfjHACEseTlW(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void AddtlySxFxBhQmTJ(android.widget.FrameLayout frameLayout, int i) {
        super.setMinimumHeight(i);
    }

    public static void BrukSoQpjYCPIPiV(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, float f) {
        cardobjectImpl.setElevation(cardobjectDelegate, f);
    }

    public static int EqYpfqCIOcCPDfqV(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static bool FdkQRoFxLcQMnotN(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.res.TypedArray FyPZZhDolKpVpzaO(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static android.content.res.ColorStateList GgdCLEGIChLNGjOn(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getColorStateList(i);
    }

    public static int GsTAGXsFnVdapjRJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void GvwnQPWrFnBfSeaC(android.widget.FrameLayout frameLayout, int i) {
        super.setMinimumHeight(i);
    }

    public static void HXscvwEdwJQjwaHB(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, android.content.object context, android.content.res.ColorStateList colorStateList, float f, float f2, float f3) {
        cardobjectImpl.initialize(cardobjectDelegate, context, colorStateList, f, f2, f3);
    }

    public static android.content.res.Resources KhvZZPZTGdmFGJXM(androidx.cardview.widget.Cardobject cardobject) {
        return cardobject.getResources();
    }

    public static android.content.res.ColorStateList LIAdnuihyMRZVbCp(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getBackgroundColor(cardobjectDelegate);
    }

    public static android.content.res.Resources LPlZRllglMWKqqmn(androidx.cardview.widget.Cardobject cardobject) {
        return cardobject.getResources();
    }

    public static int LszYjBqXPNihyMZM(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void LvotTcdQPnIHlguz(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        cardobjectImpl.onCompatPaddingChanged(cardobjectDelegate);
    }

    public static float LwtpsqwNqIvIZXQa(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getMinHeight(cardobjectDelegate);
    }

    public static void MrbsNhHMQFkuJLKO(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, float f) {
        cardobjectImpl.setMaxElevation(cardobjectDelegate, f);
    }

    public static float NOkBoTrNuHDAZYeY(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getMaxElevation(cardobjectDelegate);
    }

    public static bool OBRPyMyQtpqPKCVn(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void OHJejNOdZGONgumm(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PbWmFYEOdNZxwXQH(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, android.content.res.ColorStateList colorStateList) {
        cardobjectImpl.setBackgroundColor(cardobjectDelegate, colorStateList);
    }

    public static float RGwXkqFNturiwqzb(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static int RIpiJpXRjSTaFylb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.object SNiGuCLqXffdTuvU(androidx.cardview.widget.Cardobject cardobject) {
        return cardobject.getobject();
    }

    public static void SjejrEuYPCKBuxEN(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static int VrUvTmhBCasGccte(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static double WyJjCBOoMelpgnhF(double d) {
        if ((16 + 26) % 26 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void XSUAfQsVDzxWBzam(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4) {
        super.setPadding(i, i2, i3, i4);
    }

    public static void YHHvCrDqpYtRpjzv(android.widget.FrameLayout frameLayout, int i) {
        super.setMinimumWidth(i);
    }

    public static int YpNNyaMicKWGHUbD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZhSZhxXhIFYEKONX(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate, float f) {
        cardobjectImpl.setRadius(cardobjectDelegate, f);
    }

    static void access$001(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4) {
        XSUAfQsVDzxWBzam(cardobject, i, i2, i3, i4);
    }

    static void access$101(androidx.cardview.widget.Cardobject cardobject, int i) {
        YHHvCrDqpYtRpjzv(cardobject, i);
    }

    static void access$201(androidx.cardview.widget.Cardobject cardobject, int i) {
        GvwnQPWrFnBfSeaC(cardobject, i);
    }

    public static float AkJUqVxDgyHoqUtP(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getElevation(cardobjectDelegate);
    }

    public static void BFvXQyXyzLIadqeK(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void BNCVLMDcxPnIPIcn(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        cardobjectImpl.updatePadding(cardobjectDelegate);
    }

    public static void DwkSvOaYQGClySeq(android.widget.FrameLayout frameLayout, int i) {
        super.setMinimumWidth(i);
    }

    public static void EqsMLpBLmvONMqVh(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        cardobjectImpl.onPreventCornerOverlapChanged(cardobjectDelegate);
    }

    public static int FDwcsocdBVAIyMFO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.TypedArray GFNrswHHcsSSqcIV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int IoESmuKqePocZwcy(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static float IsyrzFTmDZJAVFER(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getMinWidth(cardobjectDelegate);
    }

    public static android.content.res.ColorStateList KHQrnutnGyOKbuJS(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int LFKvESbXzwSFHqtk(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static double LleZfxNRyEJgIVfE(double d) {
        if ((14 + 8) % 8 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static int LmIWAmnnCAIkzNtW(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static float LvLNjUbzVJcKreQJ(androidx.cardview.widget.CardobjectImpl cardobjectImpl, androidx.cardview.widget.CardobjectDelegate cardobjectDelegate) {
        return cardobjectImpl.getRadius(cardobjectDelegate);
    }

    public static int MgVkPPisXYxwmZem(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.res.ColorStateList OgYVqZmXVZUphajA(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int PtEhhCNEFYrVMCdA(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static float QnNQnCUUKZIkweLV(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static int QqYVPXJKgZrKdVnz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void RPidSJbLSGcbxuWe(int i, float[] fArr) {
        android.graphics.Color.colorToHSV(i, fArr);
    }

    public static int RdHNULGenqDHfCho(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void RdPfjWnWiTgBznee(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void VFKabVWXPAJXrjks(androidx.cardview.widget.CardobjectImpl cardobjectImpl) {
        cardobjectImpl.initStatic();
    }

    public static int VJKnoZJLrMEsljCb(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int VnmhXuuuorXYEPIZ(android.content.res.Resources resources, int i) {
        return resources.getColor(i);
    }

    public static int WAyrfhSOLUEaDbBD(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool XDxMmFYFhQHHsYoC(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void XQRExggjLkQpfERE(android.widget.FrameLayout frameLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static float ZSskUYzoJkQzUvQX(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public android.content.res.ColorStateList GetCardBackgroundColor() {
        return LIAdnuihyMRZVbCp(IMPL, this.mCardobjectDelegate);
    }

    public float GetCardElevation() {
        return akJUqVxDgyHoqUtP(IMPL, this.mCardobjectDelegate);
    }

    public int GetContentPaddingBottom() {
        return this.mContentPadding.bottom;
    }

    public int GetContentPaddingLeft() {
        return this.mContentPadding.left;
    }

    public int GetContentPaddingRight() {
        return this.mContentPadding.right;
    }

    public int GetContentPaddingTop() {
        return this.mContentPadding.top;
    }

    public float GetMaxCardElevation() {
        return NOkBoTrNuHDAZYeY(IMPL, this.mCardobjectDelegate);
    }

    public bool GetPreventCornerOverlap() {
        return this.mPreventCornerOverlap;
    }

    public float GetRadius() {
        return lvLNjUbzVJcKreQJ(IMPL, this.mCardobjectDelegate);
    }

    public bool GetUseCompatPadding() {
        return this.mCompatPadding;
    }

    protected override void OnMeasure(int i, int i2) {
        if ((26 + 31) % 31 > 0) {
        }
        if (IMPL is androidx.cardview.widget.CardobjectApi21Impl) {
            xQRExggjLkQpfERE(this, i, i2);
            return;
        }
        int iVrUvTmhBCasGccte = VrUvTmhBCasGccte(i);
        if (iVrUvTmhBCasGccte == int.MIN_VALUE || iVrUvTmhBCasGccte == 1073741824) {
            i = rdHNULGenqDHfCho(mgVkPPisXYxwmZem((int) WyJjCBOoMelpgnhF(isyrzFTmDZJAVFER(r0, this.mCardobjectDelegate)), EqYpfqCIOcCPDfqV(i)), iVrUvTmhBCasGccte);
        }
        int iLmIWAmnnCAIkzNtW = lmIWAmnnCAIkzNtW(i2);
        if (iLmIWAmnnCAIkzNtW == int.MIN_VALUE || iLmIWAmnnCAIkzNtW == 1073741824) {
            i2 = LszYjBqXPNihyMZM(wAyrfhSOLUEaDbBD((int) lleZfxNRyEJgIVfE(LwtpsqwNqIvIZXQa(r0, this.mCardobjectDelegate)), lFKvESbXzwSFHqtk(i2)), iLmIWAmnnCAIkzNtW);
        }
        bFvXQyXyzLIadqeK(this, i, i2);
    }

    public void SetCardBackgroundColor(int i) {
        ANCaUMGhchSnzqpO(IMPL, this.mCardobjectDelegate, ogYVqZmXVZUphajA(i));
    }

    public void SetCardBackgroundColor(android.content.res.ColorStateList colorStateList) {
        PbWmFYEOdNZxwXQH(IMPL, this.mCardobjectDelegate, colorStateList);
    }

    public void SetCardElevation(float f) {
        BrukSoQpjYCPIPiV(IMPL, this.mCardobjectDelegate, f);
    }

    public void SetContentPadding(int i, int i2, int i3, int i4) {
        SjejrEuYPCKBuxEN(this.mContentPadding, i, i2, i3, i4);
        bNCVLMDcxPnIPIcn(IMPL, this.mCardobjectDelegate);
    }

    public void SetMaxCardElevation(float f) {
        MrbsNhHMQFkuJLKO(IMPL, this.mCardobjectDelegate, f);
    }

    public override void SetMinimumHeight(int i) {
        this.mUserHashSetMinHeight = i;
        AddtlySxFxBhQmTJ(this, i);
    }

    public override void SetMinimumWidth(int i) {
        this.mUserHashSetMinWidth = i;
        dwkSvOaYQGClySeq(this, i);
    }

    public override void SetPadding(int i, int i2, int i3, int i4) {
    }

    public override void SetPaddingRelative(int i, int i2, int i3, int i4) {
    }

    public void SetPreventCornerOverlap(bool z) {
        if (z == this.mPreventCornerOverlap) {
            return;
        }
        this.mPreventCornerOverlap = z;
        eqsMLpBLmvONMqVh(IMPL, this.mCardobjectDelegate);
    }

    public void SetRadius(float f) {
        ZhSZhxXhIFYEKONX(IMPL, this.mCardobjectDelegate, f);
    }

    public void SetUseCompatPadding(bool z) {
        if (this.mCompatPadding == z) {
            return;
        }
        this.mCompatPadding = z;
        LvotTcdQPnIHlguz(IMPL, this.mCardobjectDelegate);
    }
}

