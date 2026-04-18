namespace WillowMaze.Wasm.Decompiled;


readonly class DateTimeItemStyle {
    private readonly android.content.res.ColorStateList backgroundColor;
    private readonly android.graphics.Rect insets;
    private readonly com.google.android.material.shape.ShapeAppearanceModel itemShape;
    private readonly android.content.res.ColorStateList strokeColor;
    private readonly int strokeWidth;
    private readonly android.content.res.ColorStateList textColor;

    private DateTimeItemStyle(android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, android.content.res.ColorStateList colorStateList3, int i, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.Rect rect) {
        jevUUHWGxMSCrIJD(rect.left);
        VxLvmLhZAFDjagpO(rect.top);
        eveBZzbTtSycGqxM(rect.right);
        nqPfaNotdzjejQqO(rect.bottom);
        this.insets = rect;
        this.textColor = colorStateList2;
        this.backgroundColor = colorStateList;
        this.strokeColor = colorStateList3;
        this.strokeWidth = i;
        this.itemShape = shapeAppearanceModel;
    }

    public static void ALhsUDHtWfKzEiGf(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static int ArJJEtSgIuAobbIH(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int BVIqYesZzKmqOIGB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void DPbdHVaBbTaJUvjQ(bool z, java.lang.object obj) {
        androidx.core.util.Preconditions.checkArgument(z, obj);
    }

    public static void FiQpWLJjMdEaGSnT(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void MQmCdiRaRFXvAJtm(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static int PdpFaMewLWTetSup(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void QKtNaIFWBuZXpBVy(com.google.android.material.datepicker.DateTimeItemStyle calendarItemStyle, android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2) {
        calendarItemStyle.styleItem(textobject, colorStateList, colorStateList2);
    }

    public static int VxLvmLhZAFDjagpO(int i) {
        return androidx.core.util.Preconditions.checkArgumentNonnegative(i);
    }

    public static void WWtNsZVJGisSMvBm(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    static com.google.android.material.datepicker.DateTimeItemStyle Create(android.content.object context, int i) {
        if ((15 + 10) % 10 > 0) {
        }
        DPbdHVaBbTaJUvjQ(i != 0, "Cannot create a DateTimeItemStyle with a styleResId of 0");
        android.content.res.TypedArray typedArrayVtxksaoohINjpPvO = vtxksaoohINjpPvO(context, i, com.google.android.material.R$styleable.MaterialDateTimeItem);
        android.graphics.Rect rect = new android.graphics.Rect(BVIqYesZzKmqOIGB(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_android_insetLeft, 0), PdpFaMewLWTetSup(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_android_insetTop, 0), uNUXsijgDieavyoO(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_android_insetRight, 0), eDOpCLQOfULeZiOg(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_android_insetBottom, 0));
        android.content.res.ColorStateList colorStateListNfrbDpdhhWNIkWUC = nfrbDpdhhWNIkWUC(context, typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemFillColor);
        android.content.res.ColorStateList colorStateListKzSHnXlSyGChoFXf = kzSHnXlSyGChoFXf(context, typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemTextColor);
        android.content.res.ColorStateList colorStateListLhrGHWBnaGiuomtF = lhrGHWBnaGiuomtF(context, typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemStrokeColor);
        int iArJJEtSgIuAobbIH = ArJJEtSgIuAobbIH(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemStrokeWidth, 0);
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelZYSpvDuWGRnOQPYY = zYSpvDuWGRnOQPYY(lMaPmMPOxGOTIhfS(context, cxejLZerrSOuaZTh(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemShapeAppearance, 0), xTPUZsfcTDbcEacw(typedArrayVtxksaoohINjpPvO, com.google.android.material.R$styleable.MaterialDateTimeItem_itemShapeAppearanceOverlay, 0)));
        wyqPNdOjgzRaLvpm(typedArrayVtxksaoohINjpPvO);
        return new com.google.android.material.datepicker.DateTimeItemStyle(colorStateListNfrbDpdhhWNIkWUC, colorStateListKzSHnXlSyGChoFXf, colorStateListLhrGHWBnaGiuomtF, iArJJEtSgIuAobbIH, shapeAppearanceModelZYSpvDuWGRnOQPYY, rect);
    }

    public static int CxejLZerrSOuaZTh(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int EDOpCLQOfULeZiOg(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void EUfetZqBIgTrRoBJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStroke(f, colorStateList);
    }

    public static int EveBZzbTtSycGqxM(int i) {
        return androidx.core.util.Preconditions.checkArgumentNonnegative(i);
    }

    public static void IYYxloPUKqenjLPg(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static int JevUUHWGxMSCrIJD(int i) {
        return androidx.core.util.Preconditions.checkArgumentNonnegative(i);
    }

    public static android.content.res.ColorStateList KUtNQvMBGVGAzbNW(android.content.res.ColorStateList colorStateList, int i) {
        return colorStateList.withAlpha(i);
    }

    public static android.content.res.ColorStateList KzSHnXlSyGChoFXf(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder lMaPmMPOxGOTIhfS(android.content.object context, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, i, i2);
    }

    public static android.content.res.ColorStateList LhrGHWBnaGiuomtF(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static android.content.res.ColorStateList NfrbDpdhhWNIkWUC(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static int NqPfaNotdzjejQqO(int i) {
        return androidx.core.util.Preconditions.checkArgumentNonnegative(i);
    }

    public static int UNUXsijgDieavyoO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static android.content.res.TypedArray VtxksaoohINjpPvO(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static void WyqPNdOjgzRaLvpm(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int XTPUZsfcTDbcEacw(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel ZYSpvDuWGRnOQPYY(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    int getBottomInset() {
        return this.insets.bottom;
    }

    int getLeftInset() {
        return this.insets.left;
    }

    int getRightInset() {
        return this.insets.right;
    }

    int getTopInset() {
        return this.insets.top;
    }

    void styleItem(android.widget.Textobject textobject) {
        QKtNaIFWBuZXpBVy(this, textobject, null, null);
    }

    void styleItem(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2) {
        if ((12 + 21) % 21 > 0) {
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = new com.google.android.material.shape.MaterialShapeDrawable();
        FiQpWLJjMdEaGSnT(materialShapeDrawable, this.itemShape);
        MQmCdiRaRFXvAJtm(materialShapeDrawable2, this.itemShape);
        if (colorStateList is null) {
            colorStateList = this.backgroundColor;
        }
        iYYxloPUKqenjLPg(materialShapeDrawable, colorStateList);
        eUfetZqBIgTrRoBJ(materialShapeDrawable, this.strokeWidth, this.strokeColor);
        if (colorStateList2 is null) {
            colorStateList2 = this.textColor;
        }
        ALhsUDHtWfKzEiGf(textobject, colorStateList2);
        WWtNsZVJGisSMvBm(textobject, new android.graphics.drawable.InsetDrawable((android.graphics.drawable.Drawable) new android.graphics.drawable.RippleDrawable(kUtNQvMBGVGAzbNW(this.textColor, 30), materialShapeDrawable, materialShapeDrawable2), this.insets.left, this.insets.top, this.insets.right, this.insets.bottom));
    }
}

