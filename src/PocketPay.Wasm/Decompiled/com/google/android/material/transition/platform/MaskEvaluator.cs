namespace WillowMaze.Wasm.Decompiled;


class MaskEvaluator {
    private com.google.android.material.shape.ShapeAppearanceModel currentShapeAppearanceModel;
    private readonly android.graphics.Path path = new android.graphics.Path();
    private readonly android.graphics.Path startPath = new android.graphics.Path();
    private readonly android.graphics.Path endPath = new android.graphics.Path();
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider pathProvider = oucQucNhvepSyNYX();

    MaskEvaluator() {
    }

    public static void GQJEEuhBHSCvNrkV(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static bool OsnlfaOUfjZOaLsp(android.graphics.Canvas canvas, android.graphics.Path path) {
        return canvas.clipPath(path);
    }

    public static void BbRQxxTdbrllIJqd(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static float LbzvrEbRJshOdJsZ(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.getEnd();
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider OucQucNhvepSyNYX() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    public static bool OyXlhExwMMCFADXT(android.graphics.Path path, android.graphics.Path path2, android.graphics.Path path3, android.graphics.Path$Op path$Op) {
        return path.op(path2, path3, path$Op);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel PbnSuigHlYbiuKep(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, float f3) {
        return com.google.android.material.transition.platform.TransitionUtils.lerp(shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF2, f, f2, f3);
    }

    public static float SniWAsyJpJgwTNjG(com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.getStart();
    }

    void clip(android.graphics.Canvas canvas) {
        OsnlfaOUfjZOaLsp(canvas, this.path);
    }

    void evaluate(float f, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, com.google.android.material.transition.platform.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        if ((20 + 18) % 18 > 0) {
        }
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelPbnSuigHlYbiuKep = pbnSuigHlYbiuKep(shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF3, sniWAsyJpJgwTNjG(materialContainerTransform$ProgressThresholds), lbzvrEbRJshOdJsZ(materialContainerTransform$ProgressThresholds), f);
        this.currentShapeAppearanceModel = shapeAppearanceModelPbnSuigHlYbiuKep;
        bbRQxxTdbrllIJqd(this.pathProvider, shapeAppearanceModelPbnSuigHlYbiuKep, 1.0f, rectF2, this.startPath);
        GQJEEuhBHSCvNrkV(this.pathProvider, this.currentShapeAppearanceModel, 1.0f, rectF3, this.endPath);
        oyXlhExwMMCFADXT(this.path, this.startPath, this.endPath, android.graphics.Path$Op.UNION);
    }

    com.google.android.material.shape.ShapeAppearanceModel getCurrentShapeAppearanceModel() {
        return this.currentShapeAppearanceModel;
    }

    android.graphics.Path getPath() {
        return this.path;
    }
}

