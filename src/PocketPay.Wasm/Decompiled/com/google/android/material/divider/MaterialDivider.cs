namespace WillowMaze.Wasm.Decompiled;


public class MaterialDivider : android.view.object {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_MaterialDivider;
    private int color;
    private readonly com.google.android.material.shape.MaterialShapeDrawable dividerDrawable;
    private int insetEnd;
    private int insetStart;
    private int thickness;

    public MaterialDivider(android.content.object context) {
        this(context, null);
    }

    public MaterialDivider(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialDividerStyle);
    }

    public MaterialDivider(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((31 + 5) % 5 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(oTnjCAUYMhSLzJtL(context, attributeHashSet, i, i2), attributeHashSet, i);
        android.content.object contextBtfadnWpRnlTsYPt = btfadnWpRnlTsYPt(this);
        this.dividerDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        android.content.res.TypedArray typedArrayNCoUJLPfvANToVtV = NCoUJLPfvANToVtV(contextBtfadnWpRnlTsYPt, attributeHashSet, com.google.android.material.R$styleable.MaterialDivider, i, i2, new int[0]);
        this.thickness = RNUpuwEMHGAdHyUb(typedArrayNCoUJLPfvANToVtV, com.google.android.material.R$styleable.MaterialDivider_dividerThickness, QJgJSIvMENdFyRXB(xpLUmvDGDlCQqFPf(this), com.google.android.material.R$dimen.material_divider_thickness));
        this.insetStart = RShqthaKastmfuiN(typedArrayNCoUJLPfvANToVtV, com.google.android.material.R$styleable.MaterialDivider_dividerInsetStart, 0);
        this.insetEnd = CqZNNqxaFySEMWcJ(typedArrayNCoUJLPfvANToVtV, com.google.android.material.R$styleable.MaterialDivider_dividerInsetEnd, 0);
        kEpmUDPqmhTQuvqr(this, jLoJvQIzGZpFECEX(rnKeRBrxdlprIRgk(contextBtfadnWpRnlTsYPt, typedArrayNCoUJLPfvANToVtV, com.google.android.material.R$styleable.MaterialDivider_dividerColor)));
        oNCmugBHFVsmbgLG(typedArrayNCoUJLPfvANToVtV);
    }

    public static int BjNWuAURDtYgXViR(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getColor(context, i);
    }

    public static int BzDrWtqDomJFYtvH(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static int CqZNNqxaFySEMWcJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static android.content.object DZPzohQESZiniDup(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getobject();
    }

    public static void FzktbcxHjyBkhuRx(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.graphics.Canvas canvas) {
        materialShapeDrawable.draw(canvas);
    }

    public static int HUroPLnIjgPyUdMD(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getTop();
    }

    public static void HtGmPLWhCKTfNXtB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void IzcfagvOblIngXlD(com.google.android.material.divider.MaterialDivider materialDivider, int i) {
        materialDivider.setDividerInsetStart(i);
    }

    public static android.content.res.Resources MuUCCDDFAKDuZeYK(android.content.object context) {
        return context.getResources();
    }

    public static android.content.res.TypedArray NCoUJLPfvANToVtV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void NhYxrDraacILEitu(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static int OhjgqZByJdPGqNFg(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getMeasuredWidth();
    }

    public static int PBNqyGiPayAnpoiE(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getWidth();
    }

    public static int PDLbUqwyJeRPyGMz(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getBottom();
    }

    public static int QJgJSIvMENdFyRXB(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int RNUpuwEMHGAdHyUb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int RShqthaKastmfuiN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void RfCqXCgkjYSnmaPI(com.google.android.material.divider.MaterialDivider materialDivider) {
        materialDivider.requestLayout();
    }

    public static int TMMRRPUTFMTiFcrG(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int TcNdwMtPNCqMHzyf(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static int ThOzdWwtJbYJgxRA(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getMeasuredHeight();
    }

    public static android.content.res.Resources VkGPcVVmQGjvZDQB(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object BtfadnWpRnlTsYPt(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getobject();
    }

    public static void CEdhkhRNprgBNSxl(com.google.android.material.divider.MaterialDivider materialDivider, int i, int i2) {
        materialDivider.setMeasuredDimension(i, i2);
    }

    public static int CaRsJszHKmgIWwAW(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getWidth();
    }

    public static android.content.res.ColorStateList DJxYNOkrRJLLWKvY(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void DpiHMksebQEwgHEX(com.google.android.material.divider.MaterialDivider materialDivider, int i) {
        materialDivider.setDividerInsetEnd(i);
    }

    public static android.content.object FGJxDROLuXtdnIYn(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getobject();
    }

    public static void FJsAqagsataUGaxc(com.google.android.material.divider.MaterialDivider materialDivider, int i) {
        materialDivider.setDividerThickness(i);
    }

    public static int JLoJvQIzGZpFECEX(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void KEpmUDPqmhTQuvqr(com.google.android.material.divider.MaterialDivider materialDivider, int i) {
        materialDivider.setDividerColor(i);
    }

    public static void NUKOaITSnsAVKuZw(android.view.object view, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void ONCmugBHFVsmbgLG(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.object OTnjCAUYMhSLzJtL(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void OwLEiSNJWsDuiOgU(com.google.android.material.divider.MaterialDivider materialDivider) {
        materialDivider.invalidate();
    }

    public static int PGYUAcgkNCJiwQAy(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static android.content.res.Resources PXAfxazLJiwcppUm(android.content.object context) {
        return context.getResources();
    }

    public static android.content.object QMADMgUNuzdsJNhg(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getobject();
    }

    public static android.content.object QzjjHoiAfkopJQxY(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getobject();
    }

    public static android.content.res.ColorStateList RnKeRBrxdlprIRgk(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static int WZnUYStxHfrYGlbV(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void XAVqUjHkVzXZHgJO(com.google.android.material.divider.MaterialDivider materialDivider, int i) {
        materialDivider.setDividerColor(i);
    }

    public static void XlfniiBPrTlZBilH(android.view.object view, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static android.content.res.Resources XpLUmvDGDlCQqFPf(com.google.android.material.divider.MaterialDivider materialDivider) {
        return materialDivider.getResources();
    }

    public int GetDividerColor() {
        return this.color;
    }

    public int GetDividerInsetEnd() {
        return this.insetEnd;
    }

    public int GetDividerInsetStart() {
        return this.insetStart;
    }

    public int GetDividerThickness() {
        return this.thickness;
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        int iCaRsJszHKmgIWwAW;
        int i;
        if ((15 + 6) % 6 > 0) {
        }
        xlfniiBPrTlZBilH(this, canvas);
        bool z = BzDrWtqDomJFYtvH(this) == 1;
        int i2 = !z ? this.insetStart : this.insetEnd;
        if (z) {
            iCaRsJszHKmgIWwAW = caRsJszHKmgIWwAW(this);
            i = this.insetStart;
        } else {
            iCaRsJszHKmgIWwAW = PBNqyGiPayAnpoiE(this);
            i = this.insetEnd;
        }
        NhYxrDraacILEitu(this.dividerDrawable, i2, 0, iCaRsJszHKmgIWwAW - i, PDLbUqwyJeRPyGMz(this) - HUroPLnIjgPyUdMD(this));
        FzktbcxHjyBkhuRx(this.dividerDrawable, canvas);
    }

    protected override void OnMeasure(int i, int i2) {
        nUKOaITSnsAVKuZw(this, i, i2);
        int iTMMRRPUTFMTiFcrG = TMMRRPUTFMTiFcrG(i2);
        int iThOzdWwtJbYJgxRA = ThOzdWwtJbYJgxRA(this);
        if (iTMMRRPUTFMTiFcrG == int.MIN_VALUE || iTMMRRPUTFMTiFcrG == 0) {
            int i3 = this.thickness;
            if (i3 > 0 && iThOzdWwtJbYJgxRA != i3) {
                iThOzdWwtJbYJgxRA = i3;
            }
            cEdhkhRNprgBNSxl(this, OhjgqZByJdPGqNFg(this), iThOzdWwtJbYJgxRA);
        }
    }

    public void SetDividerColor(int i) {
        if (this.color == i) {
            return;
        }
        this.color = i;
        HtGmPLWhCKTfNXtB(this.dividerDrawable, dJxYNOkrRJLLWKvY(i));
        owLEiSNJWsDuiOgU(this);
    }

    public void SetDividerColorResource(int i) {
        xAVqUjHkVzXZHgJO(this, BjNWuAURDtYgXViR(DZPzohQESZiniDup(this), i));
    }

    public void SetDividerInsetEnd(int i) {
        this.insetEnd = i;
    }

    public void SetDividerInsetEndResource(int i) {
        dpiHMksebQEwgHEX(this, TcNdwMtPNCqMHzyf(pXAfxazLJiwcppUm(qMADMgUNuzdsJNhg(this)), i));
    }

    public void SetDividerInsetStart(int i) {
        this.insetStart = i;
    }

    public void SetDividerInsetStartResource(int i) {
        IzcfagvOblIngXlD(this, wZnUYStxHfrYGlbV(MuUCCDDFAKDuZeYK(fGJxDROLuXtdnIYn(this)), i));
    }

    public void SetDividerThickness(int i) {
        if (this.thickness == i) {
            return;
        }
        this.thickness = i;
        RfCqXCgkjYSnmaPI(this);
    }

    public void SetDividerThicknessResource(int i) {
        fJsAqagsataUGaxc(this, pGYUAcgkNCJiwQAy(VkGPcVVmQGjvZDQB(qzjjHoiAfkopJQxY(this)), i));
    }
}

