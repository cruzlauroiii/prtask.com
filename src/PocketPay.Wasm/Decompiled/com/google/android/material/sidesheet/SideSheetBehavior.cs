namespace WillowMaze.Wasm.Decompiled;


public class SideSheetBehavior<V : android.view.object> : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<V> : com.google.android.material.sidesheet.Sheet<com.google.android.material.sidesheet.SideSheetCallback> {
    private static readonly int DEFAULT_ACCESSIBILITY_PANE_TITLE = com.google.android.material.R$string.side_sheet_accessibility_pane_title;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Material3_SideSheet;
    private static readonly float HIDE_FRICTION = 0.1f;
    private static readonly float HIDE_THRESHOLD = 0.5f;
    private static readonly int NO_MAX_SIZE = -1;
    static readonly int SIGNIFICANT_VEL_THRESHOLD = 500;
    private android.content.res.ColorStateList backgroundTint;
    private readonly java.util.HashSet<com.google.android.material.sidesheet.SideSheetCallback> callbacks;
    private int childWidth;
    private int coplanarSiblingobjectId;
    private java.lang.ref.WeakReference<android.view.object> coplanarSiblingobjectRef;
    private readonly androidx.customview.widget.objectDragHelper$Callback dragCallback;
    private bool draggable;
    private float elevation;
    private float hideFriction;
    private bool ignoreEvents;
    private int initialX;
    private int innerMargin;
    private int lastStableState;
    private com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable;
    private float maximumVelocity;
    private int parentInnerEdge;
    private int parentWidth;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel;
    private com.google.android.material.sidesheet.SheetDelegate sheetDelegate;
    private com.google.android.material.motion.MaterialSideContainerBackHelper sideContainerBackHelper;
    private int state;

    private readonly com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker stateHashSettlingTracker;
    private android.view.VelocityTracker velocityTracker;
    private androidx.customview.widget.objectDragHelper viewDragHelper;
    private java.lang.ref.WeakReference<V> viewRef;

    public SideSheetBehavior() {
        this.stateHashSettlingTracker = new com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker(this);
        this.draggable = true;
        this.state = 5;
        this.lastStableState = 5;
        this.hideFriction = 0.1f;
        this.coplanarSiblingobjectId = -1;
        this.callbacks = new java.util.LinkedHashHashSet();
        this.dragCallback = new com.google.android.material.sidesheet.SideSheetBehavior$1(this);
    }

    public SideSheetBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((19 + 16) % 16 > 0) {
        }
        this.stateHashSettlingTracker = new com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker(this);
        this.draggable = true;
        this.state = 5;
        this.lastStableState = 5;
        this.hideFriction = 0.1f;
        this.coplanarSiblingobjectId = -1;
        this.callbacks = new java.util.LinkedHashHashSet();
        this.dragCallback = new com.google.android.material.sidesheet.SideSheetBehavior$1(this);
        android.content.res.TypedArray typedArrayKfxkviYFWIYaZygV = kfxkviYFWIYaZygV(context, attributeHashSet, com.google.android.material.R$styleable.SideSheetBehavior_Layout);
        if (uWWiGbKDSLKHHwGT(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_backgroundTint)) {
            this.backgroundTint = zCZrFynBCjAwsFrf(context, typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_backgroundTint);
        }
        if (UZQhEdNTviTwQmrK(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_shapeAppearance)) {
            this.shapeAppearanceModel = YRavpQIIlTgsFeHT(XvbmaPzuALOyjOaz(context, attributeHashSet, 0, DEF_STYLE_RES));
        }
        if (odRKQjyZqeTjGneq(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_coplanarSiblingobjectId)) {
            RlANNiqqcMituyyV(this, rNpNkZSJtsiFrrCq(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_coplanarSiblingobjectId, -1));
        }
        pEIBGplyLlmBrXSB(this, context);
        this.elevation = krtEJEBpQaZniKMn(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_android_elevation, -1.0f);
        yMtMMeTYYxDDZtaI(this, ZoWiLbRKMfccgMPq(typedArrayKfxkviYFWIYaZygV, com.google.android.material.R$styleable.SideSheetBehavior_Layout_behavior_draggable, true));
        BGsGoiSQadRSqpnI(typedArrayKfxkviYFWIYaZygV);
        this.maximumVelocity = ABZguPlDJAzManIc(pGHhbkErBnpRqEUT(context));
    }

    public static int ABZguPlDJAzManIc(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledMaximumFlingVelocity();
    }

    public static void AFqVSmnqgwSIZTGX(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        super.onAttachedToLayoutParams(coordinatorLayout$LayoutParams);
    }

    public static int APMTYTnJyjfpiiYu(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getGravityFromSheetEdge();
    }

    public static void ARKAkkdCHVZghYMF(android.view.object view, bool z) {
        view.setFitsSystemWindows(z);
    }

    public static void BGrhsVMpMBAYvubL(android.view.object view, android.content.res.ColorStateList colorStateList) {
        androidx.core.view.objectCompat.setBackgroundTintList(view, colorStateList);
    }

    public static void BGsGoiSQadRSqpnI(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static bool BRwGfBDKHugmCLte(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static java.lang.string BVhjzJQLlhSDAOrZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool BYrCxwgqlHTtdLuV(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void BbnsArYhJZsTVhXj(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setState(i);
    }

    public static int BkTwQUkfQfNoypVe(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static int CGoViggKRiCONIIb(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return sheetDelegate.calculateInnerMargin(viewGroup$MarginLayoutParams);
    }

    public static int CIlYrXXdkFihdpib(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getHiddenOffset();
    }

    public static void ChzthloOGyvLsVgX(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.updateCoplanarSiblingBackProgress();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder CrZqnSGwzVbSRrbw(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static void CycaXnuuJWlkXezy(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        sideSheetBehavior.updateMaterialShapeDrawable(shapeAppearanceModel);
    }

    public static int DmuXmkiljMSrfVDd(android.view.object view) {
        return view.getVisibility();
    }

    public static bool DtZJpzQmzQwQitgn(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, float f) {
        return sheetDelegate.isExpandingOutwards(f);
    }

    public static bool DvkdmZpWiKtKLXHq(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, float f) {
        return sideSheetBehavior.isExpandingOutwards(f);
    }

    public static bool DyVLfxewzbgHrWDr(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view) {
        return sideSheetBehavior.shouldInterceptTouchEvent(view);
    }

    public static void EKMFiibtSIJOrbyk(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        viewDragHelper.processTouchEvent(motionEvent);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder EMGOJjQlGEfrqBOy(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(f);
    }

    public static int EgEhRTlAdMLrDAxJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void EgNIPxizeuTCmqEn(java.lang.Action runnable) {
        runnable.run();
    }

    public static java.lang.CharSequence EqgtyCooJTxjIrRc(android.view.object view) {
        return androidx.core.view.objectCompat.getAccessibilityPaneTitle(view);
    }

    public static void FBfPuTtjaSXGJJqp(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setState(i);
    }

    public static int FTWrtkVNdeWhtYMh(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static float FaKmpWyzxIjWpKiy(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static float FcdoknRSiiTdhbax(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static bool FdqNIoonzXVrOphB(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.hasLeftMargin();
    }

    public static void FlYVAHbjRPxCRhrb(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void FpbGJozXBmSWIQFG(android.view.VelocityTracker velocityTracker) {
        velocityTracker.recycle();
    }

    public static void GKjPsncyYRKVuzZp(android.view.object view) {
        view.requestLayout();
    }

    public static bool GRsLmDOpHxQHLIRt(float f, float f2) {
        return com.google.android.material.sidesheet.SheetUtils.isSwipeMostlyHorizontal(f, f2);
    }

    public static void GpRSACZDMTTTqECS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void HEnCIrIKkQxvXhZz(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        sheetDelegate.updateCoplanarSiblingAdjacentMargin(viewGroup$MarginLayoutParams, i);
    }

    public static void HLmThXNBMNbyaQPh(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static android.view.VelocityTracker HZLggbolCLZstYro() {
        return android.view.VelocityTracker.obtain();
    }

    public static android.view.objectGroup$LayoutParams HasWBKfsgaMBkHBs(android.view.object view) {
        return view.getLayoutParams();
    }

    public static androidx.customview.widget.objectDragHelper HdBLiRUwMjbwfFmV(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getobjectDragHelper();
    }

    public static int IAqtpAuTLgGwKcDx(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getExpandedOffset();
    }

    public static void ICCRxlFdxRJYWNDi(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setSheetEdge(i);
    }

    public static bool ISxoKWjAElAJkSGy(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static int IvUWKYUiRxfeiHja(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getExpandedOffset();
    }

    public static bool JwTuHKKsIUrsFLwG(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i, bool z) {
        return sideSheetBehavior.isHashSettling(view, i, z);
    }

    public static int KQemJnDGRchFNVFl(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int KVQFotYFiZoyvPHF(int i) {
        return java.lang.Math.abs(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder KpXLumnmrSCbYdJc(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(f);
    }

    public static java.lang.object KwvyqNqnwGuKwErD(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static android.view.objectParent LKkGWJdMlMFgAkeG(android.view.object view) {
        return view.getParent();
    }

    public static android.view.objectGroup$LayoutParams LWueTrAJKsFoafwe(android.view.object view) {
        return view.getLayoutParams();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder LbqgCdNfPUtnMBHO(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(f);
    }

    public static android.view.objectGroup$LayoutParams MGkrcRTyUUUTlwFb(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void MVRlcExIqqKTcPhY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void MkPfJrrriDsoPLtM(android.view.VelocityTracker velocityTracker, int i, float f) {
        velocityTracker.computeCurrentVelocity(i, f);
    }

    public static void MvvSHTqpHDvAIoWC(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.clearCoplanarSiblingobject();
    }

    public static bool NAjAsBKyxWYIMVnm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int NCRkBbANGOoEyMEe(android.view.object view) {
        return view.getLeft();
    }

    public static int NGvaGMoRpkEsMwhn(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i, android.view.object view) {
        return sideSheetBehavior.calculateCurrentOffset(i, view);
    }

    public static void NNPkyYMwXORxlDqY(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setStateInternal(i);
    }

    public static int NsPfGygqgqZLVlzE(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, float f, float f2) {
        return sideSheetBehavior.calculateTargetStateOnobjectReleased(view, f, f2);
    }

    public static void OIOeXunyceJpObts(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.resetVelocity();
    }

    public static int OXWYwjQNqovLDWzH(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        return sheetDelegate.getCoplanarSiblingAdjacentMargin(viewGroup$MarginLayoutParams);
    }

    public static int OhcIOxCUXulnUyfH(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getSheetEdge();
    }

    public static int PTtHtDqLnZbhQFEH(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        return sideSheetBehavior.getOuterEdgeOffsetForState(i);
    }

    public static android.view.objectGroup$LayoutParams PUKiPAGYssEQsmCZ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool PUcAQXubrSkdzlvB(android.view.object view) {
        return view.isShown();
    }

    public static int QfaxRUOEmudtCAWt(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getSheetEdge();
    }

    public static int QqZeyZLIwVadnNSO(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static int RBtgoJgpUVTUEurC(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void RlANNiqqcMituyyV(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setCoplanarSiblingobjectId(i);
    }

    public static void RlYIKFfxvmWFloYE(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        super.onDetachedFromLayoutParams();
    }

    public static void RmxSUNUfEzXtzXkK(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view) {
        sideSheetBehavior.updateSheetVisibility(view);
    }

    public static java.lang.stringBuilder SCdkBaHPidTDLYYI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float SWfEzwMBNPbbLWjO(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, float f, float f2) {
        return sideSheetBehavior.calculateDragDistance(f, f2);
    }

    public static android.view.VelocityTracker SisvFgMzipALFBtG() {
        return android.view.VelocityTracker.obtain();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel SqzcncJoqWnxAffL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static java.lang.object SvQjNIUZktyVYPXm(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SwasgAzEjjTKhYbJ(android.view.object view) {
        view.requestLayout();
    }

    public static int SwtWYuiumkYqOPdA(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionIndex();
    }

    public static void TADFdIUXVWGcbOxX(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setStateInternal(i);
    }

    public static void TMhZijWPEUNVneru(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static bool TbZVOGNZPjghNgZU(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static void TvGHKSwvSABWJqSd(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper) {
        materialSideContainerBackHelper.cancelBackProgress();
    }

    public static void TwyONkciVFEbRxjQ(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i) {
        sideSheetBehavior.dispatchOnSlide(view, i);
    }

    public static void UVpCMtYtorctiVjd(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.resetVelocity();
    }

    public static bool UZQhEdNTviTwQmrK(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.animation.ValueAnimator$AnimatorUpdateListener UcUbyAJvQQgxcomS(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getCoplanarFinishAnimatorUpdateListener();
    }

    public static java.lang.object UyUJssmlkMrfqubZ(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static int UzeEsDLEXyCHkMpY(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VGKICbGlsnAQXntX(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view) {
        sideSheetBehavior.updateSheetVisibility(view);
    }

    public static void VTnttPOliTyvTilc(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.clearCoplanarSiblingobject();
    }

    public static float VYWofQgCCjPasqQQ(float f) {
        return java.lang.Math.abs(f);
    }

    public static java.lang.stringBuilder VdrPNojXCGXrrsHO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object WhIhnMRfbDxrrnhk(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void WqhJkNngSDPcRVNi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static java.lang.string WuDJlujqwpyiVcCy(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static int WyoZNfBpFQPIJyRb(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static java.lang.object XIaohVRMhxqqPNru(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static int XgHbRMGaVzKMxNev(int i) {
        return java.lang.Math.abs(i);
    }

    public static java.lang.string XuqkqnFhAsNsyGCX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder XvbmaPzuALOyjOaz(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void XwiedNXcrZORTvAy(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.core.view.objectCompat.setAccessibilityPaneTitle(view, charSequence);
    }

    public static int XxOQwBfFKmPvlCaF(android.view.object view) {
        return view.getTop();
    }

    public static java.lang.object XxhjMFqoIKIXcFMT(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.util.IEnumerator XxwwhLrGdrSfGdkW(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool YBjAqkZbjfZipHOO(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.shouldHandleDraggingWithHelper();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel YRavpQIIlTgsFeHT(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel YbNXDgXqwqwISYXd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void YqPsgFAftHymqFKN(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetLeftAndRight(view, i);
    }

    public static void ZQPQvQWhkwwTaWOs(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, com.google.android.material.sidesheet.SideSheetCallback sideSheetCallback) {
        sideSheetBehavior.removeCallback(sideSheetCallback);
    }

    public static int ZYlfisJzurkaOkoK(android.view.object view) {
        return view.getTop();
    }

    public static android.view.object ZZOZxQHAQfGjExlU(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.findobjectById(i);
    }

    public static bool ZmBzLvKMYvtTxwFe(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static bool ZoWiLbRKMfccgMPq(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static bool ZtUhRAgOsmkcCmLZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool ZwFJlqAsEfhSFmEg(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.hasRightMargin();
    }

    public static int ASrTtMUNRnXanFxa(int i, int i2, float f) {
        return com.google.android.material.animation.AnimationUtils.lerp(i, i2, f);
    }

    public static android.view.object ASvMjfbElLmvkcfM(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getCoplanarSiblingobject();
    }

    public static java.lang.string AbrHNsTYOElOABFy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static int access$000(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.state;
    }

    static java.lang.ref.WeakReference access$100(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.viewRef;
    }

    static com.google.android.material.sidesheet.SheetDelegate access$200(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.sheetDelegate;
    }

    static void access$300(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i) {
        TwyONkciVFEbRxjQ(sideSheetBehavior, view, i);
    }

    static bool access$400(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.draggable;
    }

    static int access$500(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, float f, float f2) {
        return NsPfGygqgqZLVlzE(sideSheetBehavior, view, f, f2);
    }

    static void access$600(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i, bool z) {
        nvtrTzyUIGOYMtoX(sideSheetBehavior, view, i, z);
    }

    static int access$700(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.childWidth;
    }

    static androidx.customview.widget.objectDragHelper access$800(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.viewDragHelper;
    }

    public static int AhreViZQKcfqxrot(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getGravityFromSheetEdge();
    }

    public static java.lang.object AnpvwOvyQAVBEBHH(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void AxKJXePVxwhHnOMy(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        sideSheetBehavior.maybeAssignCoplanarSiblingobjectBasedId(coordinatorLayout);
    }

    public static androidx.activity.BackEventCompat BDVBnSoiKqFYuYcc(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper) {
        return materialSideContainerBackHelper.onHandleBackInvoked();
    }

    public static java.lang.object BOyyDDcwbjudAsTe(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool CDUroMswPyTSEReL(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static bool CJzdFlIFTAYDRcqV(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.object view) {
        return sheetDelegate.isReleasedCloseToInnerEdge(view);
    }

    private int CalculateCurrentOffset(int i, V v) {
        if ((27 + 32) % 32 > 0) {
        }
        int i2 = this.state;
        if (i2 == 1 || i2 == 2) {
            return i - wnTzKShjACRBKPWi(this.sheetDelegate, v);
        }
        if (i2 == 3) {
            return 0;
        }
        if (i2 != 5) {
            throw new java.lang.IllegalStateException(XuqkqnFhAsNsyGCX(lHJgXzuyfFBamCOv(new java.lang.stringBuilder("Unexpected value: "), this.state)));
        }
        return znpqDnjKdKWgPucc(this.sheetDelegate);
    }

    private float CalculateDragDistance(float f, float f2) {
        return VYWofQgCCjPasqQQ(f - f2);
    }

    private int CalculateTargetStateOnobjectReleased(android.view.object view, float f, float f2) {
        if ((29 + 4) % 4 > 0) {
        }
        if (DvkdmZpWiKtKLXHq(this, f)) {
            return 3;
        }
        if (iwHHqHrFKaTYUkSS(this, view, f)) {
            return (gxkInNWQsvSjSKLS(this.sheetDelegate, f, f2) || cJzdFlIFTAYDRcqV(this.sheetDelegate, view)) ? 5 : 3;
        }
        if (f != 0.0f && GRsLmDOpHxQHLIRt(f, f2)) {
            return 5;
        }
        int iNCRkBbANGOoEyMEe = NCRkBbANGOoEyMEe(view);
        return XgHbRMGaVzKMxNev(iNCRkBbANGOoEyMEe - tznNKohObYrzBlzw(this)) >= KVQFotYFiZoyvPHF(iNCRkBbANGOoEyMEe - iqxiHLjgeJratGag(this.sheetDelegate)) ? 5 : 3;
    }

    private void ClearCoplanarSiblingobject() {
        java.lang.ref.WeakReference<android.view.object> weakReference = this.coplanarSiblingobjectRef;
        if (weakReference is not null) {
            nToVDjQVLXvrAVcp(weakReference);
        }
        this.coplanarSiblingobjectRef = null;
    }

    public static java.lang.object CoxmVWEaUxKYBFIV(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    private androidx.core.view.accessibility.AccessibilityobjectCommand CreateAccessibilityobjectCommandForState(int i) {
        return new com.google.android.material.sidesheet.SideSheetBehavior$$ExternalSyntheticLambda1(this, i);
    }

    private void CreateMaterialShapeDrawableIfNeeded(android.content.object context) {
        if ((28 + 7) % 7 > 0) {
        }
        if (this.shapeAppearanceModel is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModel);
            this.materialShapeDrawable = materialShapeDrawable;
            MVRlcExIqqKTcPhY(materialShapeDrawable, context);
            android.content.res.ColorStateList colorStateList = this.backgroundTint;
            if (colorStateList is not null) {
                WqhJkNngSDPcRVNi(this.materialShapeDrawable, colorStateList);
                return;
            }
            android.util.TypedValue typedValue = new android.util.TypedValue();
            BRwGfBDKHugmCLte(kvwQFqYOnSkPHJwe(context), 16842801, typedValue, true);
            GpRSACZDMTTTqECS(this.materialShapeDrawable, typedValue.data);
        }
    }

    public static int DFhppTZkSiGZVatq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static bool DYFjzbZruTYtCKxD(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static bool DfEbqgGugzpYMiUX(android.view.objectParent viewParent) {
        return viewParent.isLayoutRequested();
    }

    public static int DftbvtojEBvlnkoj(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    private void DispatchOnSlide(android.view.object view, int i) {
        if (ZmBzLvKMYvtTxwFe(this.callbacks)) {
            return;
        }
        float fGOBfhaExQvKqEEbZ = gOBfhaExQvKqEEbZ(this.sheetDelegate, i);
        java.util.IEnumerator itPnXsakNcehllMzsJ = pnXsakNcehllMzsJ(this.callbacks);
        while (NAjAsBKyxWYIMVnm(itPnXsakNcehllMzsJ)) {
            hHEJSSCaOUTiHYTo((com.google.android.material.sidesheet.SheetCallback) thfpWYZzmdZVDmYA(itPnXsakNcehllMzsJ), view, fGOBfhaExQvKqEEbZ);
        }
    }

    public static bool DkDYsjGXDhVeUugv(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.shouldHandleDraggingWithHelper();
    }

    public static java.lang.stringBuilder ELPxeIjhTfzyUrvM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private void EnsureAccessibilityPaneTitleIsHashSet(android.view.object view) {
        if (EqgtyCooJTxjIrRc(view) is not null) {
            return;
        }
        XwiedNXcrZORTvAy(view, WuDJlujqwpyiVcCy(hSRLCjANjKfKKOjK(view), DEFAULT_ACCESSIBILITY_PANE_TITLE));
    }

    public static void EsAEzQdbjtKaXBSb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams fAaEquRfBhWZLUyc(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getobjectLayoutParams();
    }

    public static int FbxxjnQsqMxdAETJ(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return sheetDelegate.getParentInnerEdge(coordinatorLayout);
    }

    public static <V : android.view.object> com.google.android.material.sidesheet.SideSheetBehavior<V> from(V v) {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsQEgsreQUaSwbDagn = qEgsreQUaSwbDagn(v);
        if (!(viewGroup$LayoutParamsQEgsreQUaSwbDagn is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams)) {
            throw new java.lang.IllegalArgumentException("The view is not a child of CoordinatorLayout");
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorUpEzKRxdYhaeaahe = upEzKRxdYhaeaahe((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsQEgsreQUaSwbDagn);
        if (coordinatorLayout$BehaviorUpEzKRxdYhaeaahe is com.google.android.material.sidesheet.SideSheetBehavior) {
            return (com.google.android.material.sidesheet.SideSheetBehavior) coordinatorLayout$BehaviorUpEzKRxdYhaeaahe;
        }
        throw new java.lang.IllegalArgumentException("The view is not associated with SideSheetBehavior");
    }

    public static androidx.core.view.accessibility.AccessibilityobjectCommand GHruWgUEZhcqmKiC(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        return sideSheetBehavior.createAccessibilityobjectCommandForState(i);
    }

    public static void GLVUEHZhJUtINGBF(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.updateAccessibilityActions();
    }

    public static float GOBfhaExQvKqEEbZ(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, int i) {
        return sheetDelegate.calculateSlideOffset(i);
    }

    private int GetChildMeasureSpec(int i, int i2, int i3, int i4) {
        int iOVtVSxycGrfOzLRa = oVtVSxycGrfOzLRa(i, i2, i4);
        if (i3 == -1) {
            return iOVtVSxycGrfOzLRa;
        }
        int iFTWrtkVNdeWhtYMh = FTWrtkVNdeWhtYMh(iOVtVSxycGrfOzLRa);
        int iMQPNVcAfXWsGpWEC = mQPNVcAfXWsGpWEC(iOVtVSxycGrfOzLRa);
        if (iFTWrtkVNdeWhtYMh == 1073741824) {
            return RBtgoJgpUVTUEurC(UzeEsDLEXyCHkMpY(iMQPNVcAfXWsGpWEC, i3), 1073741824);
        }
        if (iMQPNVcAfXWsGpWEC != 0) {
            i3 = KQemJnDGRchFNVFl(iMQPNVcAfXWsGpWEC, i3);
        }
        return kZBkBArXMrzdmarU(i3, int.MIN_VALUE);
    }

    private android.animation.ValueAnimator$AnimatorUpdateListener getCoplanarFinishAnimatorUpdateListener() {
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams;
        if ((31 + 21) % 21 > 0) {
        }
        android.view.object viewASvMjfbElLmvkcfM = aSvMjfbElLmvkcfM(this);
        if (viewASvMjfbElLmvkcfM is null || (viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) PUKiPAGYssEQsmCZ(viewASvMjfbElLmvkcfM)) is null) {
            return null;
        }
        return new com.google.android.material.sidesheet.SideSheetBehavior$$ExternalSyntheticLambda2(this, viewGroup$MarginLayoutParams, OXWYwjQNqovLDWzH(this.sheetDelegate, viewGroup$MarginLayoutParams), viewASvMjfbElLmvkcfM);
    }

    private int GetGravityFromSheetEdge() {
        com.google.android.material.sidesheet.SheetDelegate sheetDelegate = this.sheetDelegate;
        return (sheetDelegate is null || OhcIOxCUXulnUyfH(sheetDelegate) == 0) ? 5 : 3;
    }

    private androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams getobjectLayoutParams() {
        android.view.object view;
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || (view = (android.view.object) KwvyqNqnwGuKwErD(weakReference)) is null || !(qMHfbzISMXfpuljw(view) instanceof androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams)) {
            return null;
        }
        return (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) LWueTrAJKsFoafwe(view);
    }

    public static void GnaoaSkPdNlefFkx(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void GneSWHRFgqcfETnq(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        androidx.core.view.objectCompat.replaceAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, charSequence, accessibilityobjectCommand);
    }

    public static bool GxkInNWQsvSjSKLS(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, float f, float f2) {
        return sheetDelegate.isSwipeSignificant(f, f2);
    }

    public static void HHEJSSCaOUTiHYTo(com.google.android.material.sidesheet.SheetCallback sheetCallback, android.view.object view, float f) {
        sheetCallback.onSlide(view, f);
    }

    public static android.content.res.Resources HSRLCjANjKfKKOjK(android.view.object view) {
        return view.getResources();
    }

    private bool HasLeftMargin() {
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParamsWNOvbIwFQlvbTExN = wNOvbIwFQlvbTExN(this);
        return coordinatorLayout$LayoutParamsWNOvbIwFQlvbTExN is not null && coordinatorLayout$LayoutParamsWNOvbIwFQlvbTExN.leftMargin > 0;
    }

    private bool HasRightMargin() {
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParamsFAaEquRfBhWZLUyc = fAaEquRfBhWZLUyc(this);
        return coordinatorLayout$LayoutParamsFAaEquRfBhWZLUyc is not null && coordinatorLayout$LayoutParamsFAaEquRfBhWZLUyc.rightMargin > 0;
    }

    public static void HcCLJffajgmCGcxA(com.google.android.material.sidesheet.SheetCallback sheetCallback, android.view.object view, int i) {
        sheetCallback.onStateChanged(view, i);
    }

    public static bool HgIRYrNHrPsNBFRm(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        return viewDragHelper.shouldInterceptTouchEvent(motionEvent);
    }

    public static int ICOLAwmdlBdOPxWk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static int IDDSepKMeWVyraeP(android.view.object view) {
        return androidx.core.view.objectCompat.getImportantForAccessibility(view);
    }

    public static android.view.objectGroup$LayoutParams iTOtEPOqqSdMLIYd(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void InsSIoAQyQalqBYC(com.google.android.material.sidesheet.SideSheetBehavior$StateHashSettlingTracker sideSheetBehavior$StateHashSettlingTracker, int i) {
        sideSheetBehavior$StateHashSettlingTracker.continueHashSettlingToState(i);
    }

    public static int IqxiHLjgeJratGag(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getHiddenOffset();
    }

    private bool IsDraggedFarEnough(android.view.MotionEvent motionEvent) {
        if ((32 + 18) % 18 > 0) {
        }
        return xvdxlhIrUVSwmSYZ(this) && SWfEzwMBNPbbLWjO(this, (float) this.initialX, FaKmpWyzxIjWpKiy(motionEvent)) > ((float) wGyXewUKzBMURfEa(this.viewDragHelper));
    }

    private bool IsExpandingOutwards(float f) {
        return DtZJpzQmzQwQitgn(this.sheetDelegate, f);
    }

    private bool IsLayingOut(V v) {
        android.view.objectParent viewParentLKkGWJdMlMFgAkeG = LKkGWJdMlMFgAkeG(v);
        return viewParentLKkGWJdMlMFgAkeG is not null && dfEbqgGugzpYMiUX(viewParentLKkGWJdMlMFgAkeG) && suuwNxqHqLNSfPxB(v);
    }

    private bool IsHashSettling(android.view.object view, int i, bool z) {
        int iPTtHtDqLnZbhQFEH = PTtHtDqLnZbhQFEH(this, i);
        androidx.customview.widget.objectDragHelper viewDragHelperHdBLiRUwMjbwfFmV = HdBLiRUwMjbwfFmV(this);
        if (viewDragHelperHdBLiRUwMjbwfFmV is null) {
            return false;
        }
        return !z ? mqLdBZVDTIHbIlGa(viewDragHelperHdBLiRUwMjbwfFmV, view, iPTtHtDqLnZbhQFEH, ZYlfisJzurkaOkoK(view)) : pruFyOrOATkMCtVa(viewDragHelperHdBLiRUwMjbwfFmV, iPTtHtDqLnZbhQFEH, XxOQwBfFKmPvlCaF(view));
    }

    public static bool IwHHqHrFKaTYUkSS(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, float f) {
        return sideSheetBehavior.shouldHide(view, f);
    }

    public static int IwwWhcrdIxINjjiL(android.view.object view) {
        return view.getWidth();
    }

    public static bool IyqMJSfKyPvgQhaG(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.object view, float f) {
        return sheetDelegate.shouldHide(view, f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder jfFlVYqvHUqkkyjM(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(f);
    }

    public static android.os.Parcelable JyUluZUpkCELMXNJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return super.onSaveInstanceState(coordinatorLayout, view);
    }

    public static void KReicrBStOHDmZRW(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, java.lang.Action runnable) {
        sideSheetBehavior.runAfterLayout(view, runnable);
    }

    public static void KVfKpGiVzvuFkfYq(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i, android.animation.Animator$AnimatorListener animator$AnimatorListener, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        materialSideContainerBackHelper.finishBackProgress(backEventCompat, i, animator$AnimatorListener, valueAnimator$AnimatorUpdateListener);
    }

    public static int KZBkBArXMrzdmarU(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void KZdHPBIbSqeAUfhS(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        sideSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void KaNSHgChQzeZLLAA(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        sheetDelegate.updateCoplanarSiblingAdjacentMargin(viewGroup$MarginLayoutParams, i);
    }

    public static android.content.res.TypedArray KfxkviYFWIYaZygV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static float KrtEJEBpQaZniKMn(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static android.content.res.Resources$Theme kvwQFqYOnSkPHJwe(android.content.object context) {
        return context.getTheme();
    }

    public static java.lang.stringBuilder LHJgXzuyfFBamCOv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool LUBUVIJpwNHzyWdJ(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static androidx.customview.widget.objectDragHelper LlpnpfyxVgPkBjmB(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        return androidx.customview.widget.objectDragHelper.create(viewGroup, viewDragHelper$Callback);
    }

    public static int MQPNVcAfXWsGpWEC(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void MSkwMrHvzMVaVsuP(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setStateInternal(i);
    }

    private void MaybeAssignCoplanarSiblingobjectBasedId(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        android.view.object viewZZOZxQHAQfGjExlU;
        if ((30 + 30) % 30 > 0) {
        }
        if (this.coplanarSiblingobjectRef is not null) {
            return;
        }
        int i = this.coplanarSiblingobjectId;
        if (i == -1 || (viewZZOZxQHAQfGjExlU = ZZOZxQHAQfGjExlU(coordinatorLayout, i)) is null) {
            return;
        }
        this.coplanarSiblingobjectRef = new java.lang.ref.WeakReference<>(viewZZOZxQHAQfGjExlU);
    }

    public static float MjbKMyKkUflwxtXL(android.view.VelocityTracker velocityTracker) {
        return velocityTracker.getXVelocity();
    }

    public static bool MmrajRTrjWbZFhgU(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view) {
        return sideSheetBehavior.isLayingOut(view);
    }

    public static bool MqLdBZVDTIHbIlGa(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, int i2) {
        return viewDragHelper.smoothSlideobjectTo(view, i, i2);
    }

    public static int MyUmILhxNIlTCFug(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.object view) {
        return sheetDelegate.getOuterEdge(view);
    }

    public static java.lang.stringBuilder NKgROXcTPyzQGRhw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NMDJoSknQmzEfjOd(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        sideSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void NToVDjQVLXvrAVcp(java.lang.ref.WeakReference weakReference) {
        weakReference.clear();
    }

    public static void NZPTAbQcLsACefec(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static java.lang.object NlaZqEkPOGCLQZNq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NljDnNRMhoPVlxQn(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setState(i);
    }

    public static void NvtrTzyUIGOYMtoX(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i, bool z) {
        sideSheetBehavior.startHashSettling(view, i, z);
    }

    public static java.util.IEnumerator NvylJqKstmsVbKGq(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void OFVXIwAzBJBqpPLU(com.google.android.material.sidesheet.SideSheetCallback sideSheetCallback, android.view.object view) {
        sideSheetCallback.onLayout(view);
    }

    public static java.lang.string OSRxIuKvqsXQFMPF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static float OUFIukYXeVkmXDiK(android.view.object view) {
        return view.getScaleX();
    }

    public static int OVtVSxycGrfOzLRa(int i, int i2, int i3) {
        return android.view.objectGroup.getChildMeasureSpec(i, i2, i3);
    }

    public static bool OdRKQjyZqeTjGneq(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void OeOSfluzqqizmloG(android.view.object view) {
        view.requestLayout();
    }

    public static void PCieBUhdovaRGcOf(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i, bool z) {
        sideSheetBehavior.startHashSettling(view, i, z);
    }

    public static void PEIBGplyLlmBrXSB(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.content.object context) {
        sideSheetBehavior.createMaterialShapeDrawableIfNeeded(context);
    }

    public static float PFZTGsKjpxmgTfri(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedFraction();
    }

    public static android.view.objectConfiguration PGHhbkErBnpRqEUT(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void PbpTlBQAcGVRsmsu(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view) {
        sideSheetBehavior.ensureAccessibilityPaneTitleIsHashSet(view);
    }

    public static android.view.objectGroup$LayoutParams pgAWueqGBMNxRXZi(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.util.IEnumerator PnXsakNcehllMzsJ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static bool PruFyOrOATkMCtVa(androidx.customview.widget.objectDragHelper viewDragHelper, int i, int i2) {
        return viewDragHelper.settleCapturedobjectAt(i, i2);
    }

    public static android.view.objectGroup$LayoutParams qEgsreQUaSwbDagn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QGppgVFxygpxOPeX(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static android.view.objectGroup$LayoutParams qMHfbzISMXfpuljw(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void QrGJLgvjnUxIWPHy(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat) {
        materialSideContainerBackHelper.startBackProgress(backEventCompat);
    }

    public static bool RGPhsPjrfaLjDIHs(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int RNpNkZSJtsiFrrCq(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    private void ReplaceAccessibilityActionForState(V v, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        gneSWHRFgqcfETnq(v, accessibilityNodeInfoCompat$AccessibilityActionCompat, null, gHruWgUEZhcqmKiC(this, i));
    }

    private void ResetVelocity() {
        android.view.VelocityTracker velocityTracker = this.velocityTracker;
        if (velocityTracker is null) {
            return;
        }
        FpbGJozXBmSWIQFG(velocityTracker);
        this.velocityTracker = null;
    }

    public static android.os.Parcelable RjdIpecwNnCJYIGC(com.google.android.material.sidesheet.SideSheetBehavior$SavedState sideSheetBehavior$SavedState) {
        return sideSheetBehavior$SavedState.getSuperState();
    }

    private void RunAfterLayout(V v, java.lang.Action runnable) {
        if (mmrajRTrjWbZFhgU(this, v)) {
            TbZVOGNZPjghNgZU(v, runnable);
        } else {
            EgNIPxizeuTCmqEn(runnable);
        }
    }

    public static java.lang.object SPJyFqYdgQqzUxYB(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    private void SetSheetEdge(int i) {
        if ((5 + 26) % 26 > 0) {
        }
        com.google.android.material.sidesheet.SheetDelegate sheetDelegate = this.sheetDelegate;
        if (sheetDelegate is not null && QfaxRUOEmudtCAWt(sheetDelegate) == i) {
            return;
        }
        if (i == 0) {
            this.sheetDelegate = new com.google.android.material.sidesheet.RightSheetDelegate(this);
            if (this.shapeAppearanceModel is null || ZwFJlqAsEfhSFmEg(this)) {
                return;
            }
            com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderXIiXFkHaFQGQwwul = xIiXFkHaFQGQwwul(this.shapeAppearanceModel);
            jfFlVYqvHUqkkyjM(LbqgCdNfPUtnMBHO(shapeAppearanceModel$BuilderXIiXFkHaFQGQwwul, 0.0f), 0.0f);
            vvfsrLevjAzrBVoT(this, SqzcncJoqWnxAffL(shapeAppearanceModel$BuilderXIiXFkHaFQGQwwul));
            return;
        }
        if (i != 1) {
            throw new java.lang.IllegalArgumentException(abrHNsTYOElOABFy(SCdkBaHPidTDLYYI(nKgROXcTPyzQGRhw(new java.lang.stringBuilder("Invalid sheet edge position value: "), i), ". Must be 0 or 1.")));
        }
        this.sheetDelegate = new com.google.android.material.sidesheet.LeftSheetDelegate(this);
        if (this.shapeAppearanceModel is null || FdqNIoonzXVrOphB(this)) {
            return;
        }
        com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderCrZqnSGwzVbSRrbw = CrZqnSGwzVbSRrbw(this.shapeAppearanceModel);
        EMGOJjQlGEfrqBOy(KpXLumnmrSCbYdJc(shapeAppearanceModel$BuilderCrZqnSGwzVbSRrbw, 0.0f), 0.0f);
        CycaXnuuJWlkXezy(this, YbNXDgXqwqwISYXd(shapeAppearanceModel$BuilderCrZqnSGwzVbSRrbw));
    }

    private void SetSheetEdge(V v, int i) {
        ICCRxlFdxRJYWNDi(this, dftbvtojEBvlnkoj(((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) HasWBKfsgaMBkHBs(v)).gravity, i) != 3 ? 0 : 1);
    }

    private bool ShouldHandleDraggingWithHelper() {
        if ((24 + 26) % 26 > 0) {
        }
        if (this.viewDragHelper is null) {
            return false;
        }
        return this.draggable || this.state == 1;
    }

    private bool ShouldInterceptTouchEvent(V v) {
        return (PUcAQXubrSkdzlvB(v) || xHtbsUaBbEtTrDHl(v) is not null) && this.draggable;
    }

    public static void SsFYAtcYWpJGKjkl(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(coordinatorLayout, view, parcelable);
    }

    private void StartHashSettling(android.view.object view, int i, bool z) {
        if (!JwTuHKKsIUrsFLwG(this, view, i, z)) {
            NNPkyYMwXORxlDqY(this, i);
        } else {
            mSkwMrHvzMVaVsuP(this, 2);
            insSIoAQyQalqBYC(this.stateHashSettlingTracker, i);
        }
    }

    public static bool SuuwNxqHqLNSfPxB(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static bool TAwhYhQqZKhJxWYH(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.MotionEvent motionEvent) {
        return sideSheetBehavior.isDraggedFarEnough(motionEvent);
    }

    public static java.lang.object ThfpWYZzmdZVDmYA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int TznNKohObYrzBlzw(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getExpandedOffset();
    }

    public static void UOqhSDJXEsUWcizg(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i) {
        sideSheetBehavior.setState(i);
    }

    public static bool UWWiGbKDSLKHHwGT(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void UYvkWBcXHWSWNkxB(android.view.object view) {
        view.requestLayout();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior upEzKRxdYhaeaahe(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void UpOGVQnMAgIBAixX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onLayoutChild(view, i);
    }

    private void UpdateAccessibilityActions() {
        android.view.object view;
        if ((20 + 18) % 18 > 0) {
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || (view = (android.view.object) ybuPvVAPwFWKdRrl(weakReference)) is null) {
            return;
        }
        TMhZijWPEUNVneru(view, 262144);
        gnaoaSkPdNlefFkx(view, 1048576);
        if (this.state != 5) {
            kZdHPBIbSqeAUfhS(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_DISMISS, 5);
        }
        if (this.state == 3) {
            return;
        }
        nMDJoSknQmzEfjOd(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_EXPAND, 3);
    }

    private void UpdateCoplanarSiblingBackProgress() {
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams;
        if ((24 + 11) % 11 > 0) {
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || anpvwOvyQAVBEBHH(weakReference) is null) {
            return;
        }
        android.view.object view = (android.view.object) SvQjNIUZktyVYPXm(this.viewRef);
        android.view.object viewWEwUHuPCJtWdddhD = wEwUHuPCJtWdddhD(this);
        if (viewWEwUHuPCJtWdddhD is null || (viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) MGkrcRTyUUUTlwFb(viewWEwUHuPCJtWdddhD)) is null) {
            return;
        }
        kaNSHgChQzeZLLAA(this.sheetDelegate, viewGroup$MarginLayoutParams, (int) ((this.childWidth * oUFIukYXeVkmXDiK(view)) + this.innerMargin));
        SwasgAzEjjTKhYbJ(viewWEwUHuPCJtWdddhD);
    }

    private void UpdateMaterialShapeDrawable(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.materialShapeDrawable;
        if (materialShapeDrawable is null) {
            return;
        }
        esAEzQdbjtKaXBSb(materialShapeDrawable, shapeAppearanceModel);
    }

    private void UpdateSheetVisibility(android.view.object view) {
        int i = this.state != 5 ? 0 : 4;
        if (DmuXmkiljMSrfVDd(view) == i) {
            return;
        }
        yYnlUIxoeMoswpCw(view, i);
    }

    public static float VPnzHfQmerugblVl(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void VUHgUjhItFenETig(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        sideSheetBehavior.updateAccessibilityActions();
    }

    public static void VvfsrLevjAzrBVoT(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        sideSheetBehavior.updateMaterialShapeDrawable(shapeAppearanceModel);
    }

    public static void VzYtNonAGDexuOPb(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static android.view.object WEwUHuPCJtWdddhD(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getCoplanarSiblingobject();
    }

    public static int WGyXewUKzBMURfEa(androidx.customview.widget.objectDragHelper viewDragHelper) {
        return viewDragHelper.getTouchSlop();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams wNOvbIwFQlvbTExN(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.getobjectLayoutParams();
    }

    public static int WnTzKShjACRBKPWi(com.google.android.material.sidesheet.SheetDelegate sheetDelegate, android.view.object view) {
        return sheetDelegate.getOuterEdge(view);
    }

    public static void WnvhqZqPWbtuAmQG(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, android.view.object view, int i) {
        sideSheetBehavior.setSheetEdge(view, i);
    }

    public static bool WpMbenskbrQgDFVC(android.view.object view) {
        return view.isShown();
    }

    public static java.lang.object XGfTBGrOeOXiIbwM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.CharSequence XHtbsUaBbEtTrDHl(android.view.object view) {
        return androidx.core.view.objectCompat.getAccessibilityPaneTitle(view);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xIiXFkHaFQGQwwul(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static int XXaGvutRIWrpRUVj(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i, int i2, int i3, int i4) {
        return sideSheetBehavior.getChildMeasureSpec(i, i2, i3, i4);
    }

    public static void XexDvUxESmEyUGsX(com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, int i) {
        materialSideContainerBackHelper.updateBackProgress(backEventCompat, i);
    }

    public static bool XvdxlhIrUVSwmSYZ(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior) {
        return sideSheetBehavior.shouldHandleDraggingWithHelper();
    }

    public static void YMtMMeTYYxDDZtaI(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, bool z) {
        sideSheetBehavior.setDraggable(z);
    }

    public static void YYnlUIxoeMoswpCw(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static java.lang.object YbuPvVAPwFWKdRrl(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void YfWUmqLTNYKMIiuq(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void YtnkqYVOJmzwgomn(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i) {
        viewDragHelper.captureChildobject(view, i);
    }

    public static android.os.Parcelable YvrebRvTmQaagHCi(com.google.android.material.sidesheet.SideSheetBehavior$SavedState sideSheetBehavior$SavedState) {
        return sideSheetBehavior$SavedState.getSuperState();
    }

    public static android.content.res.ColorStateList ZCZrFynBCjAwsFrf(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void ZIMgWEiyiLMZbqyF(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void ZMykBTVmriUODORq(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, com.google.android.material.sidesheet.SideSheetCallback sideSheetCallback) {
        sideSheetBehavior.addCallback(sideSheetCallback);
    }

    public static int ZSfDSeLpFYEkdVic(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static java.lang.stringBuilder ZeaTSqPpUNeiTfpI(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ZnpqDnjKdKWgPucc(com.google.android.material.sidesheet.SheetDelegate sheetDelegate) {
        return sheetDelegate.getHiddenOffset();
    }

    public static bool ZzLYeLkOOxDcsTvh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int ZzYeuGYhJbHqYjnD(com.google.android.material.sidesheet.SideSheetBehavior sideSheetBehavior, int i, int i2, int i3, int i4) {
        return sideSheetBehavior.getChildMeasureSpec(i, i2, i3, i4);
    }

    public override void AddCallback(com.google.android.material.sidesheet.SheetCallback sheetCallback) {
        zMykBTVmriUODORq(this, (com.google.android.material.sidesheet.SideSheetCallback) sheetCallback);
    }

    public void AddCallback(com.google.android.material.sidesheet.SideSheetCallback sideSheetCallback) {
        ISxoKWjAElAJkSGy(this.callbacks, sideSheetCallback);
    }

    public override void CancelBackProgress() {
        com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper = this.sideContainerBackHelper;
        if (materialSideContainerBackHelper is not null) {
            TvGHKSwvSABWJqSd(materialSideContainerBackHelper);
        }
    }

    public void Expand() {
        FBfPuTtjaSXGJJqp(this, 3);
    }

    com.google.android.material.motion.MaterialSideContainerBackHelper getBackHelper() {
        return this.sideContainerBackHelper;
    }

    int getChildWidth() {
        return this.childWidth;
    }

    public android.view.object GetCoplanarSiblingobject() {
        java.lang.ref.WeakReference<android.view.object> weakReference = this.coplanarSiblingobjectRef;
        if (weakReference is null) {
            return null;
        }
        return (android.view.object) bOyyDDcwbjudAsTe(weakReference);
    }

    public int GetExpandedOffset() {
        return IAqtpAuTLgGwKcDx(this.sheetDelegate);
    }

    public float GetHideFriction() {
        return this.hideFriction;
    }

    float getHideThreshold() {
        return 0.5f;
    }

    int getInnerMargin() {
        return this.innerMargin;
    }

    public int GetLastStableState() {
        return this.lastStableState;
    }

    int getOuterEdgeOffsetForState(int i) {
        if ((30 + 26) % 26 > 0) {
        }
        if (i == 3) {
            return IvUWKYUiRxfeiHja(this);
        }
        if (i != 5) {
            throw new java.lang.IllegalArgumentException(BVhjzJQLlhSDAOrZ(zeaTSqPpUNeiTfpI(new java.lang.stringBuilder("Invalid state to get outer edge offset: "), i)));
        }
        return CIlYrXXdkFihdpib(this.sheetDelegate);
    }

    int getParentInnerEdge() {
        return this.parentInnerEdge;
    }

    int getParentWidth() {
        return this.parentWidth;
    }

    int getSignificantVelocityThreshold() {
        return 500;
    }

    public override int GetState() {
        return this.state;
    }

    androidx.customview.widget.objectDragHelper getobjectDragHelper() {
        return this.viewDragHelper;
    }

    float getXVelocity() {
        if ((6 + 17) % 17 > 0) {
        }
        android.view.VelocityTracker velocityTracker = this.velocityTracker;
        if (velocityTracker is null) {
            return 0.0f;
        }
        MkPfJrrriDsoPLtM(velocityTracker, 1000, this.maximumVelocity);
        return mjbKMyKkUflwxtXL(this.velocityTracker);
    }

    public override void HandleBackInvoked() {
        if ((20 + 15) % 15 > 0) {
        }
        com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper = this.sideContainerBackHelper;
        if (materialSideContainerBackHelper is not null) {
            androidx.activity.BackEventCompat backEventCompatBDVBnSoiKqFYuYcc = bDVBnSoiKqFYuYcc(materialSideContainerBackHelper);
            if (backEventCompatBDVBnSoiKqFYuYcc is not null && android.os.Build$VERSION.SDK_INT >= 34) {
                kVfKpGiVzvuFkfYq(this.sideContainerBackHelper, backEventCompatBDVBnSoiKqFYuYcc, APMTYTnJyjfpiiYu(this), new com.google.android.material.sidesheet.SideSheetBehavior$2(this), UcUbyAJvQQgxcomS(this));
            } else {
                uOqhSDJXEsUWcizg(this, 5);
            }
        }
    }

    public void Hide() {
        BbnsArYhJZsTVhXj(this, 5);
    }

    public bool IsDraggable() {
        return this.draggable;
    }

    bool m174x564aa398(int i, android.view.object view, androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments) {
        nljDnNRMhoPVlxQn(this, i);
        return true;
    }

    void m175xc3af8fb4(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, android.view.object view, android.animation.ValueAnimator valueAnimator) {
        HEnCIrIKkQxvXhZz(this.sheetDelegate, viewGroup$MarginLayoutParams, aSrTtMUNRnXanFxa(i, 0, pFZTGsKjpxmgTfri(valueAnimator)));
        oeOSfluzqqizmloG(view);
    }

    void m176xc0f1d0a9(int i) {
        if ((18 + 23) % 23 > 0) {
        }
        android.view.object view = (android.view.object) coxmVWEaUxKYBFIV(this.viewRef);
        if (view is null) {
            return;
        }
        pCieBUhdovaRGcOf(this, view, i, false);
    }

    public override void OnAttachedToLayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        AFqVSmnqgwSIZTGX(this, coordinatorLayout$LayoutParams);
        this.viewRef = null;
        this.viewDragHelper = null;
        this.sideContainerBackHelper = null;
    }

    public override void OnDetachedFromLayoutParams() {
        RlYIKFfxvmWFloYE(this);
        this.viewRef = null;
        this.viewDragHelper = null;
        this.sideContainerBackHelper = null;
    }

    public override bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        androidx.customview.widget.objectDragHelper viewDragHelper;
        if ((26 + 27) % 27 > 0) {
        }
        if (!DyVLfxewzbgHrWDr(this, v)) {
            this.ignoreEvents = true;
            return false;
        }
        int iQGppgVFxygpxOPeX = qGppgVFxygpxOPeX(motionEvent);
        if (iQGppgVFxygpxOPeX == 0) {
            UVpCMtYtorctiVjd(this);
        }
        if (this.velocityTracker is null) {
            this.velocityTracker = SisvFgMzipALFBtG();
        }
        nZPTAbQcLsACefec(this.velocityTracker, motionEvent);
        if (iQGppgVFxygpxOPeX == 0) {
            this.initialX = (int) FcdoknRSiiTdhbax(motionEvent);
        } else if ((iQGppgVFxygpxOPeX == 1 || iQGppgVFxygpxOPeX == 3) && this.ignoreEvents) {
            this.ignoreEvents = false;
            return false;
        }
        return (this.ignoreEvents || (viewDragHelper = this.viewDragHelper) is null || !hgIRYrNHrPsNBFRm(viewDragHelper, motionEvent)) ? false : true;
    }

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        if ((17 + 27) % 27 > 0) {
        }
        if (rGPhsPjrfaLjDIHs(coordinatorLayout) && !cDUroMswPyTSEReL(v)) {
            ARKAkkdCHVZghYMF(v, true);
        }
        if (this.viewRef is null) {
            this.viewRef = new java.lang.ref.WeakReference<>(v);
            this.sideContainerBackHelper = new com.google.android.material.motion.MaterialSideContainerBackHelper(v);
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.materialShapeDrawable;
            if (materialShapeDrawable is null) {
                android.content.res.ColorStateList colorStateList = this.backgroundTint;
                if (colorStateList is not null) {
                    BGrhsVMpMBAYvubL(v, colorStateList);
                }
            } else {
                zIMgWEiyiLMZbqyF(v, materialShapeDrawable);
                com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = this.materialShapeDrawable;
                float fVPnzHfQmerugblVl = this.elevation;
                if (fVPnzHfQmerugblVl == -1.0f) {
                    fVPnzHfQmerugblVl = vPnzHfQmerugblVl(v);
                }
                HLmThXNBMNbyaQPh(materialShapeDrawable2, fVPnzHfQmerugblVl);
            }
            VGKICbGlsnAQXntX(this, v);
            vUHgUjhItFenETig(this);
            if (iDDSepKMeWVyraeP(v) == 0) {
                vzYtNonAGDexuOPb(v, 1);
            }
            pbpTlBQAcGVRsmsu(this, v);
        }
        wnvhqZqPWbtuAmQG(this, v, i);
        if (this.viewDragHelper is null) {
            this.viewDragHelper = llpnpfyxVgPkBjmB(coordinatorLayout, this.dragCallback);
        }
        int iMyUmILhxNIlTCFug = myUmILhxNIlTCFug(this.sheetDelegate, v);
        upOGVQnMAgIBAixX(coordinatorLayout, v, i);
        this.parentWidth = EgEhRTlAdMLrDAxJ(coordinatorLayout);
        this.parentInnerEdge = fbxxjnQsqMxdAETJ(this.sheetDelegate, coordinatorLayout);
        this.childWidth = iwwWhcrdIxINjjiL(v);
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) pgAWueqGBMNxRXZi(v);
        this.innerMargin = viewGroup$MarginLayoutParams is null ? 0 : CGoViggKRiCONIIb(this.sheetDelegate, viewGroup$MarginLayoutParams);
        YqPsgFAftHymqFKN(v, NGvaGMoRpkEsMwhn(this, iMyUmILhxNIlTCFug, v));
        axKJXePVxwhHnOMy(this, coordinatorLayout);
        java.util.IEnumerator itNvylJqKstmsVbKGq = nvylJqKstmsVbKGq(this.callbacks);
        while (ZtUhRAgOsmkcCmLZ(itNvylJqKstmsVbKGq)) {
            com.google.android.material.sidesheet.SheetCallback sheetCallback = (com.google.android.material.sidesheet.SheetCallback) nlaZqEkPOGCLQZNq(itNvylJqKstmsVbKGq);
            if (sheetCallback is com.google.android.material.sidesheet.SideSheetCallback) {
                oFVXIwAzBJBqpPLU((com.google.android.material.sidesheet.SideSheetCallback) sheetCallback, v);
            }
        }
        return true;
    }

    public override bool OnMeasureChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, int i3, int i4) {
        if ((32 + 17) % 17 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) iTOtEPOqqSdMLIYd(v);
        yfWUmqLTNYKMIiuq(v, zzYeuGYhJbHqYjnD(this, i, dFhppTZkSiGZVatq(coordinatorLayout) + BkTwQUkfQfNoypVe(coordinatorLayout) + viewGroup$MarginLayoutParams.leftMargin + viewGroup$MarginLayoutParams.rightMargin + i2, -1, viewGroup$MarginLayoutParams.width), xXaGvutRIWrpRUVj(this, i3, zSfDSeLpFYEkdVic(coordinatorLayout) + iCOLAwmdlBdOPxWk(coordinatorLayout) + viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin + i4, -1, viewGroup$MarginLayoutParams.height));
        return true;
    }

    public override void OnRestoreInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.os.Parcelable parcelable) {
        com.google.android.material.sidesheet.SideSheetBehavior$SavedState sideSheetBehavior$SavedState = (com.google.android.material.sidesheet.SideSheetBehavior$SavedState) parcelable;
        if (rjdIpecwNnCJYIGC(sideSheetBehavior$SavedState) is not null) {
            ssFYAtcYWpJGKjkl(this, coordinatorLayout, v, yvrebRvTmQaagHCi(sideSheetBehavior$SavedState));
        }
        int i = (sideSheetBehavior$SavedState.state == 1 || sideSheetBehavior$SavedState.state == 2) ? 5 : sideSheetBehavior$SavedState.state;
        this.state = i;
        this.lastStableState = i;
    }

    public override android.os.Parcelable OnSaveInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return new com.google.android.material.sidesheet.SideSheetBehavior$SavedState(jyUluZUpkCELMXNJ(this, coordinatorLayout, v), (com.google.android.material.sidesheet.SideSheetBehavior<object>) this);
    }

    public override bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        if ((11 + 25) % 25 > 0) {
        }
        if (!wpMbenskbrQgDFVC(v)) {
            return false;
        }
        int iWyoZNfBpFQPIJyRb = WyoZNfBpFQPIJyRb(motionEvent);
        if (this.state == 1 && iWyoZNfBpFQPIJyRb == 0) {
            return true;
        }
        if (YBjAqkZbjfZipHOO(this)) {
            EKMFiibtSIJOrbyk(this.viewDragHelper, motionEvent);
        }
        if (iWyoZNfBpFQPIJyRb == 0) {
            OIOeXunyceJpObts(this);
        }
        if (this.velocityTracker is null) {
            this.velocityTracker = HZLggbolCLZstYro();
        }
        FlYVAHbjRPxCRhrb(this.velocityTracker, motionEvent);
        if (dkDYsjGXDhVeUugv(this) && iWyoZNfBpFQPIJyRb == 2 && !this.ignoreEvents && tAwhYhQqZKhJxWYH(this, motionEvent)) {
            ytnkqYVOJmzwgomn(this.viewDragHelper, v, QqZeyZLIwVadnNSO(motionEvent, SwtWYuiumkYqOPdA(motionEvent)));
        }
        return !this.ignoreEvents;
    }

    public override void RemoveCallback(com.google.android.material.sidesheet.SheetCallback sheetCallback) {
        ZQPQvQWhkwwTaWOs(this, (com.google.android.material.sidesheet.SideSheetCallback) sheetCallback);
    }

    public void RemoveCallback(com.google.android.material.sidesheet.SideSheetCallback sideSheetCallback) {
        dYFjzbZruTYtCKxD(this.callbacks, sideSheetCallback);
    }

    public void SetCoplanarSiblingobject(android.view.object view) {
        this.coplanarSiblingobjectId = -1;
        if (view is null) {
            MvvSHTqpHDvAIoWC(this);
            return;
        }
        this.coplanarSiblingobjectRef = new java.lang.ref.WeakReference<>(view);
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null) {
            return;
        }
        android.view.object view2 = (android.view.object) XIaohVRMhxqqPNru(weakReference);
        if (BYrCxwgqlHTtdLuV(view2)) {
            GKjPsncyYRKVuzZp(view2);
        }
    }

    public void SetCoplanarSiblingobjectId(int i) {
        this.coplanarSiblingobjectId = i;
        VTnttPOliTyvTilc(this);
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null) {
            return;
        }
        android.view.object view = (android.view.object) XxhjMFqoIKIXcFMT(weakReference);
        if (i != -1 && lUBUVIJpwNHzyWdJ(view)) {
            uYvkWBcXHWSWNkxB(view);
        }
    }

    public void SetDraggable(bool z) {
        this.draggable = z;
    }

    public void SetHideFriction(float f) {
        this.hideFriction = f;
    }

    public override void SetState(int i) {
        if ((23 + 29) % 29 > 0) {
        }
        if (i == 1 || i == 2) {
            throw new java.lang.IllegalArgumentException(oSRxIuKvqsXQFMPF(eLPxeIjhTfzyUrvM(VdrPNojXCGXrrsHO(new java.lang.stringBuilder("STATE_"), i != 1 ? "SETTLING" : "DRAGGING"), " should not be set externally.")));
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || UyUJssmlkMrfqubZ(weakReference) is null) {
            TADFdIUXVWGcbOxX(this, i);
        } else {
            kReicrBStOHDmZRW(this, (android.view.object) sPJyFqYdgQqzUxYB(this.viewRef), new com.google.android.material.sidesheet.SideSheetBehavior$$ExternalSyntheticLambda0(this, i));
        }
    }

    void setStateInternal(int i) {
        android.view.object view;
        if ((19 + 7) % 7 > 0) {
        }
        if (this.state != i) {
            this.state = i;
            if (i == 3 || i == 5) {
                this.lastStableState = i;
            }
            java.lang.ref.WeakReference<V> weakReference = this.viewRef;
            if (weakReference is null || (view = (android.view.object) WhIhnMRfbDxrrnhk(weakReference)) is null) {
                return;
            }
            RmxSUNUfEzXtzXkK(this, view);
            java.util.IEnumerator itXxwwhLrGdrSfGdkW = XxwwhLrGdrSfGdkW(this.callbacks);
            while (zzLYeLkOOxDcsTvh(itXxwwhLrGdrSfGdkW)) {
                hcCLJffajgmCGcxA((com.google.android.material.sidesheet.SheetCallback) xGfTBGrOeOXiIbwM(itXxwwhLrGdrSfGdkW), view, i);
            }
            gLVUEHZhJUtINGBF(this);
        }
    }

    bool shouldHide(android.view.object view, float f) {
        return iyqMJSfKyPvgQhaG(this.sheetDelegate, view, f);
    }

    public bool ShouldSkipSmoothAnimation() {
        return true;
    }

    public override void StartBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper = this.sideContainerBackHelper;
        if (materialSideContainerBackHelper is not null) {
            qrGJLgvjnUxIWPHy(materialSideContainerBackHelper, backEventCompat);
        }
    }

    public override void UpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        if ((26 + 5) % 5 > 0) {
        }
        com.google.android.material.motion.MaterialSideContainerBackHelper materialSideContainerBackHelper = this.sideContainerBackHelper;
        if (materialSideContainerBackHelper is not null) {
            xexDvUxESmEyUGsX(materialSideContainerBackHelper, backEventCompat, ahreViZQKcfqxrot(this));
            ChzthloOGyvLsVgX(this);
        }
    }
}

