namespace WillowMaze.Wasm.Decompiled;


readonly class ShapeAppearancePathProvider$ShapeAppearancePathSpec {
    public readonly android.graphics.RectF bounds;
    public readonly float interpolation;
    public readonly android.graphics.Path path;
    public readonly com.google.android.material.shape.ShapeAppearancePathProvider$PathListener pathListener;
    public readonly com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;

    ShapeAppearancePathProvider$ShapeAppearancePathSpec(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, com.google.android.material.shape.ShapeAppearancePathProvider$PathListener shapeAppearancePathProvider$PathListener, android.graphics.Path path) {
        this.pathListener = shapeAppearancePathProvider$PathListener;
        this.shapeAppearanceModel = shapeAppearanceModel;
        this.interpolation = f;
        this.bounds = rectF;
        this.path = path;
    }
}

