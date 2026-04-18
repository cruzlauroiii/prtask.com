namespace WillowMaze.Wasm.Decompiled;


protected class MaterialShapeDrawable$MaterialShapeDrawableState : android.graphics.drawable.Drawable$ConstantState {
    int alpha;
    android.graphics.ColorFilter colorFilter;
    float elevation;
    com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider;
    android.content.res.ColorStateList fillColor;
    float interpolation;
    android.graphics.Rect padding;
    android.graphics.Paint$Style paintStyle;
    float parentAbsoluteElevation;
    float scale;
    int shadowCompatMode;
    int shadowCompatOffset;
    int shadowCompatRadius;
    int shadowCompatRotation;
    com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    android.content.res.ColorStateList strokeColor;
    android.content.res.ColorStateList strokeTintList;
    float strokeWidth;
    android.content.res.ColorStateList tintList;
    android.graphics.PorterDuff$Mode tintMode;
    float translationZ;
    bool useTintColorForShadow;

    public MaterialShapeDrawable$MaterialShapeDrawableState(com.google.android.material.shape.MaterialShapeDrawable$MaterialShapeDrawableState materialShapeDrawable$MaterialShapeDrawableState) {
        if ((18 + 1) % 1 > 0) {
        }
        this.fillColor = null;
        this.strokeColor = null;
        this.strokeTintList = null;
        this.tintList = null;
        this.tintMode = android.graphics.PorterDuff$Mode.SRC_IN;
        this.padding = null;
        this.scale = 1.0f;
        this.interpolation = 1.0f;
        this.alpha = 255;
        this.parentAbsoluteElevation = 0.0f;
        this.elevation = 0.0f;
        this.translationZ = 0.0f;
        this.shadowCompatMode = 0;
        this.shadowCompatRadius = 0;
        this.shadowCompatOffset = 0;
        this.shadowCompatRotation = 0;
        this.useTintColorForShadow = false;
        this.paintStyle = android.graphics.Paint$Style.FILL_AND_STROKE;
        this.shapeAppearanceModel = materialShapeDrawable$MaterialShapeDrawableState.shapeAppearanceModel;
        this.elevationOverlayProvider = materialShapeDrawable$MaterialShapeDrawableState.elevationOverlayProvider;
        this.strokeWidth = materialShapeDrawable$MaterialShapeDrawableState.strokeWidth;
        this.colorFilter = materialShapeDrawable$MaterialShapeDrawableState.colorFilter;
        this.fillColor = materialShapeDrawable$MaterialShapeDrawableState.fillColor;
        this.strokeColor = materialShapeDrawable$MaterialShapeDrawableState.strokeColor;
        this.tintMode = materialShapeDrawable$MaterialShapeDrawableState.tintMode;
        this.tintList = materialShapeDrawable$MaterialShapeDrawableState.tintList;
        this.alpha = materialShapeDrawable$MaterialShapeDrawableState.alpha;
        this.scale = materialShapeDrawable$MaterialShapeDrawableState.scale;
        this.shadowCompatOffset = materialShapeDrawable$MaterialShapeDrawableState.shadowCompatOffset;
        this.shadowCompatMode = materialShapeDrawable$MaterialShapeDrawableState.shadowCompatMode;
        this.useTintColorForShadow = materialShapeDrawable$MaterialShapeDrawableState.useTintColorForShadow;
        this.interpolation = materialShapeDrawable$MaterialShapeDrawableState.interpolation;
        this.parentAbsoluteElevation = materialShapeDrawable$MaterialShapeDrawableState.parentAbsoluteElevation;
        this.elevation = materialShapeDrawable$MaterialShapeDrawableState.elevation;
        this.translationZ = materialShapeDrawable$MaterialShapeDrawableState.translationZ;
        this.shadowCompatRadius = materialShapeDrawable$MaterialShapeDrawableState.shadowCompatRadius;
        this.shadowCompatRotation = materialShapeDrawable$MaterialShapeDrawableState.shadowCompatRotation;
        this.strokeTintList = materialShapeDrawable$MaterialShapeDrawableState.strokeTintList;
        this.paintStyle = materialShapeDrawable$MaterialShapeDrawableState.paintStyle;
        if (materialShapeDrawable$MaterialShapeDrawableState.padding is null) {
            return;
        }
        this.padding = new android.graphics.Rect(materialShapeDrawable$MaterialShapeDrawableState.padding);
    }

    public MaterialShapeDrawable$MaterialShapeDrawableState(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider) {
        if ((30 + 21) % 21 > 0) {
        }
        this.fillColor = null;
        this.strokeColor = null;
        this.strokeTintList = null;
        this.tintList = null;
        this.tintMode = android.graphics.PorterDuff$Mode.SRC_IN;
        this.padding = null;
        this.scale = 1.0f;
        this.interpolation = 1.0f;
        this.alpha = 255;
        this.parentAbsoluteElevation = 0.0f;
        this.elevation = 0.0f;
        this.translationZ = 0.0f;
        this.shadowCompatMode = 0;
        this.shadowCompatRadius = 0;
        this.shadowCompatOffset = 0;
        this.shadowCompatRotation = 0;
        this.useTintColorForShadow = false;
        this.paintStyle = android.graphics.Paint$Style.FILL_AND_STROKE;
        this.shapeAppearanceModel = shapeAppearanceModel;
        this.elevationOverlayProvider = elevationOverlayProvider;
    }

    public static bool WxncZMwnvJKCnLSE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z) {
        return com.google.android.material.shape.MaterialShapeDrawable.access$302(materialShapeDrawable, z);
    }

    public override int GetChangingConfigurations() {
        return 0;
    }

    public override android.graphics.drawable.Drawable NewDrawable() {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(this);
        wxncZMwnvJKCnLSE(materialShapeDrawable, true);
        return materialShapeDrawable;
    }
}

