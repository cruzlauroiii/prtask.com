namespace WillowMaze.Wasm.Decompiled;


readonly class CutoutDrawable$CutoutDrawableState : com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState {
    private readonly android.graphics.RectF cutoutBounds;

    private CutoutDrawable$CutoutDrawableState(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        super(shapeAppearanceModel, null);
        this.cutoutBounds = rectF;
    }

    CutoutDrawable$CutoutDrawableState(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, com.google.android.material.textfield.CutoutDrawable$1 cutoutDrawable$1) {
        this(shapeAppearanceModel, rectF);
    }

    private CutoutDrawable$CutoutDrawableState(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        super(cutoutDrawable$CutoutDrawableState);
        this.cutoutBounds = cutoutDrawable$CutoutDrawableState.cutoutBounds;
    }

    CutoutDrawable$CutoutDrawableState(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState, com.google.android.material.textfield.CutoutDrawable$1 cutoutDrawable$1) {
        this(cutoutDrawable$CutoutDrawableState);
    }

    public static void LNhplrHGyiyDncSJ(com.google.android.material.textfield.CutoutDrawable cutoutDrawable) {
        cutoutDrawable.invalidateSelf();
    }

    public static com.google.android.material.textfield.CutoutDrawable XrXPPGGZxaTADkan(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable.access$400(cutoutDrawable$CutoutDrawableState);
    }

    static android.graphics.RectF access$200(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return cutoutDrawable$CutoutDrawableState.cutoutBounds;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        com.google.android.material.textfield.CutoutDrawable cutoutDrawableXrXPPGGZxaTADkan = XrXPPGGZxaTADkan(this);
        LNhplrHGyiyDncSJ(cutoutDrawableXrXPPGGZxaTADkan);
        return cutoutDrawableXrXPPGGZxaTADkan;
    }
}

