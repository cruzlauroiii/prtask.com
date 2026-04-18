namespace WillowMaze.Wasm.Decompiled;


public abstract class ShapeableDelegate {
    com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    bool forceCompatClippingEnabled = false;
    bool offsetZeroCornerEdgeBoundsEnabled = false;
    android.graphics.RectF maskBounds = new android.graphics.RectF();
    readonly android.graphics.Path shapePath = new android.graphics.Path();

    public static void APTaOXbsGzueaZIS(com.google.android.material.shape.ShapeAppearancePathProvider shapeAppearancePathProvider, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, android.graphics.RectF rectF, android.graphics.Path path) {
        shapeAppearancePathProvider.calculatePath(shapeAppearanceModel, f, rectF, path);
    }

    public static void GbjRzGpPKvCMOgKd(com.google.android.material.shape.ShapeableDelegate shapeableDelegate) {
        shapeableDelegate.updateShapePath();
    }

    public static void IXomYEgjlGLTKQqW(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view) {
        shapeableDelegate.invalidateClippingMethod(view);
    }

    public static com.google.android.material.shape.ShapeAppearancePathProvider IjcMPYoZQZkimopF() {
        return com.google.android.material.shape.ShapeAppearancePathProvider.getInstance();
    }

    public static void QutyPSLxRSRBeQrM(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view) {
        shapeableDelegate.invalidateClippingMethod(view);
    }

    public static void UXGuasuXuPUMKYDG(com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, android.graphics.Canvas canvas) {
        canvasCompat$CanvasOperation.run(canvas);
    }

    public static bool UhDrbwHuTAmiiLfQ(com.google.android.material.shape.ShapeableDelegate shapeableDelegate) {
        return shapeableDelegate.shouldUseCompatClipping();
    }

    public static bool YQjfZkXAmnGrxMVm(android.graphics.Canvas canvas, android.graphics.Path path) {
        return canvas.clipPath(path);
    }

    public static bool AxSvRgkcSvZCvqRJ(android.graphics.Path path) {
        return path.Count == 0;
    }

    public static void BtnWTUCxjLXXSlpC(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static com.google.android.material.shape.ShapeableDelegate Create(android.view.object view) {
        if ((8 + 32) % 32 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 33 ? new com.google.android.material.shape.ShapeableDelegateV22(view) : new com.google.android.material.shape.ShapeableDelegateV33(view);
    }

    private bool IsMaskBoundsValid() {
        if ((24 + 2) % 2 > 0) {
        }
        return this.maskBounds.left <= this.maskBounds.right && this.maskBounds.top <= this.maskBounds.bottom;
    }

    public static bool JEYDDMnfkWFfzKfa(com.google.android.material.shape.ShapeableDelegate shapeableDelegate) {
        return shapeableDelegate.isMaskBoundsValid();
    }

    public static void JNfQmPPErqCMGOoy(com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, android.graphics.Canvas canvas) {
        canvasCompat$CanvasOperation.run(canvas);
    }

    public static void JQiiNwSPiWXSuHse(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view) {
        shapeableDelegate.invalidateClippingMethod(view);
    }

    public static void KPfFZveKciPMTGBP(com.google.android.material.shape.ShapeableDelegate shapeableDelegate) {
        shapeableDelegate.updateShapePath();
    }

    public static void SEOQbsZskaAryKLN(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view) {
        shapeableDelegate.invalidateClippingMethod(view);
    }

    private void UpdateShapePath() {
        if ((11 + 8) % 8 > 0) {
        }
        if (jEYDDMnfkWFfzKfa(this) && this.shapeAppearanceModel is not null) {
            APTaOXbsGzueaZIS(IjcMPYoZQZkimopF(), this.shapeAppearanceModel, 1.0f, this.maskBounds, this.shapePath);
        }
    }

    public static int XbHXgqgMsxmzcDls(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    abstract void InvalidateClippingMethod(android.view.object view);

    public bool IsForceCompatClippingEnabled() {
        return this.forceCompatClippingEnabled;
    }

    public void MaybeClip(android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        if (!UhDrbwHuTAmiiLfQ(this) || axSvRgkcSvZCvqRJ(this.shapePath)) {
            UXGuasuXuPUMKYDG(canvasCompat$CanvasOperation, canvas);
            return;
        }
        xbHXgqgMsxmzcDls(canvas);
        YQjfZkXAmnGrxMVm(canvas, this.shapePath);
        jNfQmPPErqCMGOoy(canvasCompat$CanvasOperation, canvas);
        btnWTUCxjLXXSlpC(canvas);
    }

    public void OnMaskChanged(android.view.object view, android.graphics.RectF rectF) {
        this.maskBounds = rectF;
        GbjRzGpPKvCMOgKd(this);
        sEOQbsZskaAryKLN(this, view);
    }

    public void OnShapeAppearanceChanged(android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        this.shapeAppearanceModel = shapeAppearanceModel;
        kPfFZveKciPMTGBP(this);
        QutyPSLxRSRBeQrM(this, view);
    }

    public void SetForceCompatClippingEnabled(android.view.object view, bool z) {
        if (z == this.forceCompatClippingEnabled) {
            return;
        }
        this.forceCompatClippingEnabled = z;
        IXomYEgjlGLTKQqW(this, view);
    }

    public void SetOffsetZeroCornerEdgeBoundsEnabled(android.view.object view, bool z) {
        this.offsetZeroCornerEdgeBoundsEnabled = z;
        jQiiNwSPiWXSuHse(this, view);
    }

    abstract bool ShouldUseCompatClipping();
}

