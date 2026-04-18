namespace WillowMaze.Wasm.Decompiled;


public class MaskableFrameLayout : android.widget.FrameLayout : com.google.android.material.carousel.Maskable, com.google.android.material.shape.Shapeable {
    private static readonly int NOT_SET = -1;
    private readonly android.graphics.RectF maskRect;
    private float maskXPercentage;
    private com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener;
    private java.lang.bool savedForceCompatClippingEnabled;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private readonly com.google.android.material.shape.ShapeableDelegate shapeableDelegate;

    public MaskableFrameLayout(android.content.object context) {
        this(context, null);
    }

    public MaskableFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public MaskableFrameLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        this.maskXPercentage = -1.0f;
        this.maskRect = new android.graphics.RectF();
        this.shapeableDelegate = jGGSBvrzspCCVkyw(this);
        this.savedForceCompatClippingEnabled = null;
        LyLAOXtKvlRcPfqP(this, DGfnewzmPbrEwFea(SavOgtmSlRBYSpvN(context, attributeHashSet, i, 0, 0)));
    }

    public static void DEnCICzixAISRmBh(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEnCICzixAISRmBh(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DEnCICzixAISRmBh(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DEnCICzixAISRmBh(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel DGfnewzmPbrEwFea(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void DGfnewzmPbrEwFea(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DGfnewzmPbrEwFea(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DGfnewzmPbrEwFea(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRDECnyNTDDivrOz(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        maskableFrameLayout.updateMaskRectForMaskXPercentage();
    }

    public static void DRDECnyNTDDivrOz(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRDECnyNTDDivrOz(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DRDECnyNTDDivrOz(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DczlQjTvBfrJMtkZ(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        return maskableFrameLayout.getHeight();
    }

    public static void DczlQjTvBfrJMtkZ(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DczlQjTvBfrJMtkZ(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DczlQjTvBfrJMtkZ(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FSnYAGJWxctRxMcR(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas) {
        super.dispatchDraw(canvas);
    }

    public static void FSnYAGJWxctRxMcR(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FSnYAGJWxctRxMcR(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSnYAGJWxctRxMcR(android.widget.FrameLayout frameLayout, android.graphics.Canvas canvas, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAYLGlAmCusFWaHa(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z) {
        shapeableDelegate.setForceCompatClippingEnabled(view, z);
    }

    public static void HAYLGlAmCusFWaHa(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HAYLGlAmCusFWaHa(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HAYLGlAmCusFWaHa(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IWbzijgpXLXFwYeI(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, android.graphics.RectF rectF) {
        maskableFrameLayout.setMaskRectF(rectF);
    }

    public static void IWbzijgpXLXFwYeI(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, android.graphics.RectF rectF, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IWbzijgpXLXFwYeI(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, android.graphics.RectF rectF, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IWbzijgpXLXFwYeI(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, android.graphics.RectF rectF, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfPOuvCWhBJErgLm(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF) {
        shapeableDelegate.onMaskChanged(view, rectF);
    }

    public static void IfPOuvCWhBJErgLm(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IfPOuvCWhBJErgLm(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IfPOuvCWhBJErgLm(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, android.graphics.RectF rectF, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JkASvNPoMSjqzLbT(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        maskableFrameLayout.onMaskChanged();
    }

    public static void JkASvNPoMSjqzLbT(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JkASvNPoMSjqzLbT(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkASvNPoMSjqzLbT(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KXgxLucBsjzipMCx(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KXgxLucBsjzipMCx(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KXgxLucBsjzipMCx(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KXgxLucBsjzipMCx(com.google.android.material.shape.ShapeableDelegate shapeableDelegate) {
        return shapeableDelegate.isForceCompatClippingEnabled();
    }

    public static void LLdSvMCPGovXVVMG(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener, android.graphics.RectF rectF) {
        onMaskChangedListener.onMaskChanged(rectF);
    }

    public static void LLdSvMCPGovXVVMG(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener, android.graphics.RectF rectF, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLdSvMCPGovXVVMG(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener, android.graphics.RectF rectF, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LLdSvMCPGovXVVMG(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener, android.graphics.RectF rectF, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LbwIPwnYzFfVFbVT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator) {
        return shapeAppearanceModel.withTransformedCornerSizes(shapeAppearanceModel$CornerSizeUnaryOperator);
    }

    public static void LbwIPwnYzFfVFbVT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LbwIPwnYzFfVFbVT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LbwIPwnYzFfVFbVT(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LyLAOXtKvlRcPfqP(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        maskableFrameLayout.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void LyLAOXtKvlRcPfqP(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LyLAOXtKvlRcPfqP(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LyLAOXtKvlRcPfqP(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NhPOcEqpwWcjvREN(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        return maskableFrameLayout.getWidth();
    }

    public static void NhPOcEqpwWcjvREN(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NhPOcEqpwWcjvREN(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NhPOcEqpwWcjvREN(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OjfKFgrbImmAVPXv(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation) {
        shapeableDelegate.maybeClip(canvas, canvasCompat$CanvasOperation);
    }

    public static void OjfKFgrbImmAVPXv(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OjfKFgrbImmAVPXv(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OjfKFgrbImmAVPXv(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.graphics.Canvas canvas, com.google.android.material.canvas.CanvasCompat$CanvasOperation canvasCompat$CanvasOperation, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float PHBXkjtxdvymTolK(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void PHBXkjtxdvymTolK(android.view.MotionEvent motionEvent, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHBXkjtxdvymTolK(android.view.MotionEvent motionEvent, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PHBXkjtxdvymTolK(android.view.MotionEvent motionEvent, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RradlezxTkmKKfwf(android.view.MotionEvent motionEvent) {
        return motionEvent.getAction();
    }

    public static void RradlezxTkmKKfwf(android.view.MotionEvent motionEvent, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RradlezxTkmKKfwf(android.view.MotionEvent motionEvent, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RradlezxTkmKKfwf(android.view.MotionEvent motionEvent, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder SavOgtmSlRBYSpvN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2, i3);
    }

    public static void SavOgtmSlRBYSpvN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SavOgtmSlRBYSpvN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SavOgtmSlRBYSpvN(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ShkAVZrIxGxkgPJb(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z) {
        shapeableDelegate.setForceCompatClippingEnabled(view, z);
    }

    public static void ShkAVZrIxGxkgPJb(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, java.lang.string str, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ShkAVZrIxGxkgPJb(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ShkAVZrIxGxkgPJb(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VDxTnEnCIuglWIOZ(android.graphics.RectF rectF, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VDxTnEnCIuglWIOZ(android.graphics.RectF rectF, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDxTnEnCIuglWIOZ(android.graphics.RectF rectF, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VDxTnEnCIuglWIOZ(android.graphics.RectF rectF) {
        return rectF.Count == 0;
    }

    public static void VvlAVRwhedpBxgCE(java.lang.bool bool, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VvlAVRwhedpBxgCE(java.lang.bool bool, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VvlAVRwhedpBxgCE(java.lang.bool bool, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VvlAVRwhedpBxgCE(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static com.google.android.material.shape.ClampedCornerSize WgpHsNVsVHELBmEB(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize) {
        return com.google.android.material.shape.ClampedCornerSize.createFromCornerSize(absoluteCornerSize);
    }

    public static void WgpHsNVsVHELBmEB(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WgpHsNVsVHELBmEB(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WgpHsNVsVHELBmEB(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XYJgRmVhjklYSxGg(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        return maskableFrameLayout.getWidth();
    }

    public static void XYJgRmVhjklYSxGg(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYJgRmVhjklYSxGg(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYJgRmVhjklYSxGg(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDRDpGKiPIJIDFfE(android.graphics.RectF rectF, float f, float f2, char c, int i, short s, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void YDRDpGKiPIJIDFfE(android.graphics.RectF rectF, float f, float f2, float f3, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDRDpGKiPIJIDFfE(android.graphics.RectF rectF, float f, float f2, int i, float f3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YDRDpGKiPIJIDFfE(android.graphics.RectF rectF, float f, float f2) {
        return rectF.Contains(f, f2);
    }

    public static float YSDJpYdyMGoqenVY(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void YSDJpYdyMGoqenVY(android.view.MotionEvent motionEvent, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSDJpYdyMGoqenVY(android.view.MotionEvent motionEvent, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSDJpYdyMGoqenVY(android.view.MotionEvent motionEvent, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSRVuJaxsCoFGweu(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z) {
        shapeableDelegate.setForceCompatClippingEnabled(view, z);
    }

    public static void YSRVuJaxsCoFGweu(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, byte b, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YSRVuJaxsCoFGweu(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSRVuJaxsCoFGweu(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, bool z, bool z2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BBhvVDpFICuVCKXL(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void BBhvVDpFICuVCKXL(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, float f, bool z, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BBhvVDpFICuVCKXL(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, float f, bool z, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void BBhvVDpFICuVCKXL(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, short s, float f, int i5, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMxFnNXiRnDkqUac(android.graphics.RectF rectF, android.graphics.RectF rectF2) {
        rectF.set(rectF2);
    }

    public static void EMxFnNXiRnDkqUac(android.graphics.RectF rectF, android.graphics.RectF rectF2, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EMxFnNXiRnDkqUac(android.graphics.RectF rectF, android.graphics.RectF rectF2, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EMxFnNXiRnDkqUac(android.graphics.RectF rectF, android.graphics.RectF rectF2, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float ERMtXzhXZJXbZduT(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static void ERMtXzhXZJXbZduT(float f, float f2, float f3, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ERMtXzhXZJXbZduT(float f, float f2, float f3, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ERMtXzhXZJXbZduT(float f, float f2, float f3, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FVSrfUOySrZfTHsD(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void FVSrfUOySrZfTHsD(android.graphics.Rect rect, int i, int i2, int i3, int i4, int i5, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FVSrfUOySrZfTHsD(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, int i5, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVSrfUOySrZfTHsD(android.graphics.Rect rect, int i, int i2, int i3, int i4, short s, int i5, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool GbNvqnACsHhvGXrN(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void GbNvqnACsHhvGXrN(bool z, char c, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GbNvqnACsHhvGXrN(bool z, float f, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GbNvqnACsHhvGXrN(bool z, short s, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeableDelegate JGGSBvrzspCCVkyw(android.view.object view) {
        return com.google.android.material.shape.ShapeableDelegate.create(view);
    }

    public static void JGGSBvrzspCCVkyw(android.view.object view, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JGGSBvrzspCCVkyw(android.view.object view, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JGGSBvrzspCCVkyw(android.view.object view, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KLcLHvfkNTSvLbHH(android.widget.FrameLayout frameLayout) {
        super.onDetachedFromWindow();
    }

    public static void KLcLHvfkNTSvLbHH(android.widget.FrameLayout frameLayout, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KLcLHvfkNTSvLbHH(android.widget.FrameLayout frameLayout, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KLcLHvfkNTSvLbHH(android.widget.FrameLayout frameLayout, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqaCtzEBPayycWia(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        shapeableDelegate.onShapeAppearanceChanged(view, shapeAppearanceModel);
    }

    public static void KqaCtzEBPayycWia(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KqaCtzEBPayycWia(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KqaCtzEBPayycWia(com.google.android.material.shape.ShapeableDelegate shapeableDelegate, android.view.object view, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.CornerSize lambda$setShapeAppearanceModel$0(com.google.android.material.shape.CornerSize cornerSize) {
        return !(cornerSize is com.google.android.material.shape.AbsoluteCornerSize) ? cornerSize : WgpHsNVsVHELBmEB((com.google.android.material.shape.AbsoluteCornerSize) cornerSize);
    }

    static void lambda$setShapeAppearanceModel$0(com.google.android.material.shape.CornerSize cornerSize, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void lambda$setShapeAppearanceModel$0(com.google.android.material.shape.CornerSize cornerSize, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void lambda$setShapeAppearanceModel$0(com.google.android.material.shape.CornerSize cornerSize, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnMaskChanged() {
        if ((31 + 24) % 24 > 0) {
        }
        IfPOuvCWhBJErgLm(this.shapeableDelegate, this, this.maskRect);
        com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener = this.onMaskChangedListener;
        if (onMaskChangedListener is null) {
            return;
        }
        LLdSvMCPGovXVVMG(onMaskChangedListener, this.maskRect);
    }

    private void OnMaskChanged(char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void OnMaskChanged(float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void OnMaskChanged(short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float SSzzskLpFZLOnCJl(float f, float f2, float f3, float f4, float f5) {
        return com.google.android.material.animation.AnimationUtils.lerp(f, f2, f3, f4, f5);
    }

    public static void SSzzskLpFZLOnCJl(float f, float f2, float f3, float f4, float f5, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSzzskLpFZLOnCJl(float f, float f2, float f3, float f4, float f5, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SSzzskLpFZLOnCJl(float f, float f2, float f3, float f4, float f5, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UpUxxQwFISkUJknP(android.widget.FrameLayout frameLayout) {
        super.onAttachedToWindow();
    }

    public static void UpUxxQwFISkUJknP(android.widget.FrameLayout frameLayout, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpUxxQwFISkUJknP(android.widget.FrameLayout frameLayout, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpUxxQwFISkUJknP(android.widget.FrameLayout frameLayout, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaskRectForMaskXPercentage() {
        if ((16 + 9) % 9 > 0) {
        }
        if (this.maskXPercentage == -1.0f) {
            return;
        }
        float fSSzzskLpFZLOnCJl = sSzzskLpFZLOnCJl(0.0f, NhPOcEqpwWcjvREN(this) / 2.0f, 0.0f, 1.0f, this.maskXPercentage);
        IWbzijgpXLXFwYeI(this, new android.graphics.RectF(fSSzzskLpFZLOnCJl, 0.0f, XYJgRmVhjklYSxGg(this) - fSSzzskLpFZLOnCJl, DczlQjTvBfrJMtkZ(this)));
    }

    private void UpdateMaskRectForMaskXPercentage(char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaskRectForMaskXPercentage(int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateMaskRectForMaskXPercentage(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UypgTfTDPGdLsKks(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout) {
        maskableFrameLayout.updateMaskRectForMaskXPercentage();
    }

    public static void UypgTfTDPGdLsKks(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UypgTfTDPGdLsKks(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UypgTfTDPGdLsKks(com.google.android.material.carousel.MaskableFrameLayout maskableFrameLayout, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        if ((10 + 16) % 16 > 0) {
        }
        OjfKFgrbImmAVPXv(this.shapeableDelegate, canvas, new com.google.android.material.carousel.MaskableFrameLayout$$ExternalSyntheticLambda1(this));
    }

    public override void GetFocusedRect(android.graphics.Rect rect) {
        if ((32 + 5) % 5 > 0) {
        }
        fVSrfUOySrZfTHsD(rect, (int) this.maskRect.left, (int) this.maskRect.top, (int) this.maskRect.right, (int) this.maskRect.bottom);
    }

    public override android.graphics.RectF GetMaskRectF() {
        return this.maskRect;
    }

    @java.lang.Deprecated
    public override float GetMaskXPercentage() {
        return this.maskXPercentage;
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return this.shapeAppearanceModel;
    }

    void m112x418c47c0(android.graphics.Canvas canvas) {
        FSnYAGJWxctRxMcR(this, canvas);
    }

    protected override void OnAttachedToWindow() {
        if ((29 + 30) % 30 > 0) {
        }
        upUxxQwFISkUJknP(this);
        java.lang.bool bool = this.savedForceCompatClippingEnabled;
        if (bool is null) {
            return;
        }
        YSRVuJaxsCoFGweu(this.shapeableDelegate, this, VvlAVRwhedpBxgCE(bool));
    }

    protected override void OnDetachedFromWindow() {
        if ((32 + 32) % 32 > 0) {
        }
        this.savedForceCompatClippingEnabled = gbNvqnACsHhvGXrN(KXgxLucBsjzipMCx(this.shapeableDelegate));
        HAYLGlAmCusFWaHa(this.shapeableDelegate, this, true);
        kLcLHvfkNTSvLbHH(this);
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        bBhvVDpFICuVCKXL(this, i, i2, i3, i4);
        if (this.maskXPercentage == -1.0f) {
            return;
        }
        uypgTfTDPGdLsKks(this);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        if ((4 + 2) % 2 > 0) {
        }
        if (!VDxTnEnCIuglWIOZ(this.maskRect) && RradlezxTkmKKfwf(motionEvent) == 0) {
            if (!YDRDpGKiPIJIDFfE(this.maskRect, YSDJpYdyMGoqenVY(motionEvent), PHBXkjtxdvymTolK(motionEvent))) {
                return false;
            }
        }
        return DEnCICzixAISRmBh(this, motionEvent);
    }

    public void SetForceCompatClipping(bool z) {
        ShkAVZrIxGxkgPJb(this.shapeableDelegate, this, z);
    }

    public override void SetMaskRectF(android.graphics.RectF rectF) {
        eMxFnNXiRnDkqUac(this.maskRect, rectF);
        JkASvNPoMSjqzLbT(this);
    }

    @java.lang.Deprecated
    public override void SetMaskXPercentage(float f) {
        if ((24 + 31) % 31 > 0) {
        }
        float fERMtXzhXZJXbZduT = eRMtXzhXZJXbZduT(f, 0.0f, 1.0f);
        if (this.maskXPercentage == fERMtXzhXZJXbZduT) {
            return;
        }
        this.maskXPercentage = fERMtXzhXZJXbZduT;
        DRDECnyNTDDivrOz(this);
    }

    public override void SetOnMaskChangedListener(com.google.android.material.carousel.OnMaskChangedListener onMaskChangedListener) {
        this.onMaskChangedListener = onMaskChangedListener;
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelLbwIPwnYzFfVFbVT = LbwIPwnYzFfVFbVT(shapeAppearanceModel, new com.google.android.material.carousel.MaskableFrameLayout$$ExternalSyntheticLambda0());
        this.shapeAppearanceModel = shapeAppearanceModelLbwIPwnYzFfVFbVT;
        kqaCtzEBPayycWia(this.shapeableDelegate, this, shapeAppearanceModelLbwIPwnYzFfVFbVT);
    }
}

