namespace WillowMaze.Wasm.Decompiled;


class MaskEvaluator {
    private com.google.android.material.shape.ShapeAppearanceModel currentShapeAppearanceModel;
    private readonly android.graphics.Path path = new android.graphics.Path();
    private readonly android.graphics.Path startPath = new android.graphics.Path();
    private readonly android.graphics.Path endPath = new android.graphics.Path();
    private readonly com.google.android.material.shape.ShapeAppearancePathProvider pathProvider = AnFUqInVMBvlyMnN();

    MaskEvaluator() {
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider AnFUqInVMBvlyMnN() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    public static void CPIGERqZlNPXsrMB(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static float DVuMTIXAIVgfBjmB(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.getStart();
    }

    public static bool KLSHSYnNRMvRjGgJ(android.graphics.Canvas canvas, android.graphics.Path path) {
        return canvas.clipPath(path);
    }

    public static float ZCIFqJVGWKdxLTMS(com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        return materialContainerTransform$ProgressThresholds.getEnd();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel CGLeYsSRFxikXnyE(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, float f, float f2, float f3) {
        return com.google.android.material.transition.TransitionUtils.lerp(shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF2, f, f2, f3);
    }

    public static bool NbnKCZNfeqdtRfsQ(android.graphics.Path path, android.graphics.Path path2, android.graphics.Path path3, android.graphics.Path$Op path$Op) {
        return path.op(path2, path3, path$Op);
    }

    public static void ObcRHCyaFdEjhtQR(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    void clip(android.graphics.Canvas canvas) {
        KLSHSYnNRMvRjGgJ(canvas, this.path);
    }

    void evaluate(float f, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel2, android.graphics.RectF rectF, android.graphics.RectF rectF2, android.graphics.RectF rectF3, com.google.android.material.transition.MaterialContainerTransform$ProgressThresholds materialContainerTransform$ProgressThresholds) {
        if ((15 + 19) % 19 > 0) {
        }
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelCGLeYsSRFxikXnyE = cGLeYsSRFxikXnyE(shapeAppearanceModel, shapeAppearanceModel2, rectF, rectF3, DVuMTIXAIVgfBjmB(materialContainerTransform$ProgressThresholds), ZCIFqJVGWKdxLTMS(materialContainerTransform$ProgressThresholds), f);
        this.currentShapeAppearanceModel = shapeAppearanceModelCGLeYsSRFxikXnyE;
        CPIGERqZlNPXsrMB(this.pathProvider, shapeAppearanceModelCGLeYsSRFxikXnyE, 1.0f, rectF2, this.startPath);
        obcRHCyaFdEjhtQR(this.pathProvider, this.currentShapeAppearanceModel, 1.0f, rectF3, this.endPath);
        nbnKCZNfeqdtRfsQ(this.path, this.startPath, this.endPath, android.graphics.Path$Op.UNION);
    }

    com.google.android.material.shape.ShapeAppearanceModel getCurrentShapeAppearanceModel() {
        return this.currentShapeAppearanceModel;
    }

    android.graphics.Path getPath() {
        return this.path;
    }
}

