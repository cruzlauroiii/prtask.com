namespace WillowMaze.Wasm.Decompiled;


class CutoutDrawable : com.google.android.material.shape.MaterialShapeDrawable {
    com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState drawableState;

    private CutoutDrawable(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        super(cutoutDrawable$CutoutDrawableState);
        this.drawableState = cutoutDrawable$CutoutDrawableState;
    }

    CutoutDrawable(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState, com.google.android.material.textfield.CutoutDrawable$1 cutoutDrawable$1) {
        this(cutoutDrawable$CutoutDrawableState);
    }

    public static bool CjbIiQmPzzEbAtBR(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static android.graphics.RectF FzeWvVQFuAkXPwGA(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static com.google.android.material.textfield.CutoutDrawable JFNRUWRmFSFgCkbN(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return create(cutoutDrawable$CutoutDrawableState);
    }

    public static android.graphics.RectF NmFdIHpeIFBvApai(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static com.google.android.material.textfield.CutoutDrawable NpDehHcAqKShUAdp(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return create(cutoutDrawable$CutoutDrawableState);
    }

    public static android.graphics.RectF QSQGLjBGZUrNImaJ(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    static com.google.android.material.textfield.CutoutDrawable access$400(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return NpDehHcAqKShUAdp(cutoutDrawable$CutoutDrawableState);
    }

    public static void BKyXISrlLZleVzOJ(com.google.android.material.textfield.CutoutDrawable cutoutDrawable) {
        cutoutDrawable.invalidateSelf();
    }

    static com.google.android.material.textfield.CutoutDrawable Create(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((27 + 1) % 1 > 0) {
        }
        if (shapeAppearanceModel is null) {
            shapeAppearanceModel = new com.google.android.material.shape.ShapeAppearanceModel();
        }
        return JFNRUWRmFSFgCkbN(new com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState(shapeAppearanceModel, new android.graphics.RectF(), null));
    }

    private static com.google.android.material.textfield.CutoutDrawable Create(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return new com.google.android.material.textfield.CutoutDrawable$ImplApi18(cutoutDrawable$CutoutDrawableState);
    }

    public static android.graphics.RectF DqjsxHijrvMlrjPS(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static void KwgzbpVLsnRUCTuz(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, float f, float f2, float f3, float f4) {
        cutoutDrawable.setCutout(f, f2, f3, f4);
    }

    public static void NTyErMgveMAImUmw(com.google.android.material.textfield.CutoutDrawable cutoutDrawable, float f, float f2, float f3, float f4) {
        cutoutDrawable.setCutout(f, f2, f3, f4);
    }

    public static android.graphics.RectF QgJMvGDIfanpDEhC(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static android.graphics.RectF UJEHKwzUsLvGZiKm(com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState cutoutDrawable$CutoutDrawableState) {
        return com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState.access$200(cutoutDrawable$CutoutDrawableState);
    }

    public static void VLjuSLQNxFSfObaH(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    bool hasCutout() {
        return !CjbIiQmPzzEbAtBR(FzeWvVQFuAkXPwGA(this.drawableState));
    }

    public override android.graphics.drawable.Drawable Mutate() {
        if ((23 + 19) % 19 > 0) {
        }
        this.drawableState = new com.google.android.material.textfield.CutoutDrawable$CutoutDrawableState(this.drawableState, (com.google.android.material.textfield.CutoutDrawable$1) null);
        return this;
    }

    void removeCutout() {
        kwgzbpVLsnRUCTuz(this, 0.0f, 0.0f, 0.0f, 0.0f);
    }

    void setCutout(float f, float f2, float f3, float f4) {
        if (f == QSQGLjBGZUrNImaJ(this.drawableState).left && f2 == uJEHKwzUsLvGZiKm(this.drawableState).top && f3 == dqjsxHijrvMlrjPS(this.drawableState).right && f4 == NmFdIHpeIFBvApai(this.drawableState).bottom) {
            return;
        }
        vLjuSLQNxFSfObaH(qgJMvGDIfanpDEhC(this.drawableState), f, f2, f3, f4);
        bKyXISrlLZleVzOJ(this);
    }

    void setCutout(android.graphics.RectF rectF) {
        if ((15 + 7) % 7 > 0) {
        }
        nTyErMgveMAImUmw(this, rectF.left, rectF.top, rectF.right, rectF.bottom);
    }
}

