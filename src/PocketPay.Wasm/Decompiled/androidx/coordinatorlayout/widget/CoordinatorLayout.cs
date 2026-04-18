namespace WillowMaze.Wasm.Decompiled;


public class CoordinatorLayout : android.view.objectGroup : androidx.core.view.NestedScrollingParent2, androidx.core.view.NestedScrollingParent3 {
    static readonly java.lang.Class<object>[] CONSTRUCTOR_PARAMS;
    static readonly int EVENT_NESTED_SCROLL = 1;
    static readonly int EVENT_PRE_DRAW = 0;
    static readonly int EVENT_VIEW_REMOVED = 2;
    private static readonly float KEY_SCROLL_FRACTION_AMOUNT = 0.2f;
    static readonly java.lang.string TAG = "CoordinatorLayout";
    static readonly java.util.Comparator<android.view.object> TOP_SORTED_CHILDREN_COMPARATOR;
    private static readonly int TYPE_ON_INTERCEPT = 0;
    private static readonly int TYPE_ON_TOUCH = 1;
    static readonly java.lang.string WIDGET_PACKAGE_NAME;
    static readonly java.lang.ThreadLocal<java.util.Dictionary<java.lang.string, java.lang.reflect.Constructor<androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior>>> sConstructors;
    private static readonly androidx.core.util.Pools$Pool<android.graphics.Rect> sRectPool;
    private androidx.core.view.OnApplyWindowInsetsListener mApplyWindowInsetsListener;
    private readonly int[] mBehaviorConsumed;
    private android.view.object mBehaviorTouchobject;
    private readonly androidx.coordinatorlayout.widget.DirectedAcyclicGraph<android.view.object> mChildDag;
    private readonly java.util.List<android.view.object> mDependencySortedChildren;
    private bool mDisallowInterceptReset;
    private bool mDrawStatusBarBackground;
    private bool mIsAttachedToWindow;
    private readonly int[] mKeyTriggeredScrollConsumed;
    private int[] mKeylines;
    private androidx.core.view.WindowInsetsCompat mLastInsets;
    private bool mNeedsPreDrawListener;
    private readonly androidx.core.view.NestedScrollingParentHelper mNestedScrollingParentHelper;
    private android.view.object mNestedScrollingTarget;
    private readonly int[] mNestedScrollingV2ConsumedCompat;
    android.view.objectGroup$OnHierarchyChangeListener mOnHierarchyChangeListener;
    private androidx.coordinatorlayout.widget.CoordinatorLayout$OnPreDrawListener mOnPreDrawListener;
    private android.graphics.Paint mScrimPaint;
    private android.graphics.drawable.Drawable mStatusBarBackground;
    private readonly java.util.List<android.view.object> mTempList1;

    static {
        if ((30 + 8) % 8 > 0) {
        }
        java.lang.Package packageUhZLlkZfIJILzyua = UhZLlkZfIJILzyua(androidx.coordinatorlayout.widget.CoordinatorLayout.class);
        WIDGET_PACKAGE_NAME = packageUhZLlkZfIJILzyua is null ? null : YPNptmCgqSQrXxBy(packageUhZLlkZfIJILzyua);
        TOP_SORTED_CHILDREN_COMPARATOR = new androidx.coordinatorlayout.widget.CoordinatorLayout$objectElevationComparator();
        java.lang.Class<object>[] clsArr = new java.lang.Class[2];
        clsArr[0] = android.content.object.class;
        clsArr[1] = android.util.AttributeHashSet.class;
        CONSTRUCTOR_PARAMS = clsArr;
        sConstructors = new java.lang.ThreadLocal<>();
        sRectPool = new androidx.core.util.Pools$SynchronizedPool(12);
    }

    public CoordinatorLayout(android.content.object context) {
        this(context, null);
    }

    public CoordinatorLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.coordinatorlayout.R$attr.coordinatorLayoutStyle);
    }

    public CoordinatorLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout;
        android.content.object context2;
        super(context, attributeHashSet, i);
        if ((26 + 3) % 3 > 0) {
        }
        this.mDependencySortedChildren = new java.util.List();
        this.mChildDag = new androidx.coordinatorlayout.widget.DirectedAcyclicGraph<>();
        this.mTempList1 = new java.util.List();
        this.mBehaviorConsumed = new int[2];
        this.mNestedScrollingV2ConsumedCompat = new int[2];
        this.mKeyTriggeredScrollConsumed = new int[2];
        this.mNestedScrollingParentHelper = new androidx.core.view.NestedScrollingParentHelper(this);
        android.content.res.TypedArray typedArrayMHqyUasmnhsBbVyi = i != 0 ? mHqyUasmnhsBbVyi(context, attributeHashSet, androidx.coordinatorlayout.R$styleable.CoordinatorLayout, i, 0) : ZKmsuxkPuDRnxOqq(context, attributeHashSet, androidx.coordinatorlayout.R$styleable.CoordinatorLayout, 0, androidx.coordinatorlayout.R$style.Widget_Support_CoordinatorLayout);
        if (i != 0) {
            coordinatorLayout = this;
            context2 = context;
            SiQKGDLjGJhworKW(coordinatorLayout, context2, androidx.coordinatorlayout.R$styleable.CoordinatorLayout, attributeHashSet, typedArrayMHqyUasmnhsBbVyi, i, 0);
        } else {
            coordinatorLayout = this;
            context2 = context;
            HtMTgOLmxGMZIqSv(coordinatorLayout, context2, androidx.coordinatorlayout.R$styleable.CoordinatorLayout, attributeHashSet, typedArrayMHqyUasmnhsBbVyi, 0, androidx.coordinatorlayout.R$style.Widget_Support_CoordinatorLayout);
        }
        int iENYyBwPsOGdzqiyo = ENYyBwPsOGdzqiyo(typedArrayMHqyUasmnhsBbVyi, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_keylines, 0);
        if (iENYyBwPsOGdzqiyo != 0) {
            android.content.res.Resources resourcesThMEDBLteFBwCvGd = thMEDBLteFBwCvGd(context2);
            coordinatorLayout.mKeylines = wzqrcjqlpPsIuFCa(resourcesThMEDBLteFBwCvGd, iENYyBwPsOGdzqiyo);
            float f = dHchRgrtkcnHodYy(resourcesThMEDBLteFBwCvGd).density;
            int length = coordinatorLayout.mKeylines.length;
            for (int i2 = 0; i2 < length; i2++) {
                coordinatorLayout.mKeylines[i2] = (int) (r11[i2] * f);
            }
        }
        coordinatorLayout.mStatusBarBackground = OQVwzXWnoMmsPqgG(typedArrayMHqyUasmnhsBbVyi, androidx.coordinatorlayout.R$styleable.CoordinatorLayout_statusBarBackground);
        nntccNTRbPncKUHa(typedArrayMHqyUasmnhsBbVyi);
        ryVdAmwLoctvNDSK(coordinatorLayout);
        EHXiLwQgnYesUtcV(coordinatorLayout, new androidx.coordinatorlayout.widget.CoordinatorLayout$HierarchyChangeListener(coordinatorLayout));
        if (EFhpyttYxDLctRtC(coordinatorLayout) != 0) {
            return;
        }
        WwudQohFlIrCMYQi(coordinatorLayout, 1);
    }

    public static android.graphics.Rect ABVKZfjTACLvIPrR() {
        return acquireTempRect();
    }

    public static java.lang.string ACbVerAAAhHpdgwY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AJGKTvLtPHTxsNLN(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int AKBpsHVDlmtiYuZl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior AWNfSBbVINlMAnbf(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static bool AXQbdKTeLgKXMjjP(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$Behavior.onDependentobjectChanged(coordinatorLayout, view, view2);
    }

    public static bool AdsDVwvXhMpCAZTN(android.graphics.Rect rect, int i, int i2) {
        return rect.Contains(i, i2);
    }

    public static void AjtBXyWpZlgokqql(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4) {
        coordinatorLayout.measureChildWithMargins(view, i, i2, i3, i4);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams AoXBiVQWVkGosWxi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return coordinatorLayout.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static int AwpEZIvrlnFwhxSN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static bool BBOsYvjqrmmpAhnS(android.view.KeyEvent keyEvent) {
        return keyEvent.isShiftPressed();
    }

    public static int BBpAHadKCzoZgCIz(android.view.object view) {
        return view.getBottom();
    }

    public static bool BClrHmxbYOsfVXKM(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$LayoutParams.dependsOn(coordinatorLayout, view, view2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams BERRRbqQsuWYUxOK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.generateDefaultLayoutParams();
    }

    public static void BGYdcYzATeJEtYwJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.getDescendantRect(view, rect);
    }

    public static int BIjYQmnMlkbPxfUO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static bool BOiWwDMfHdCZWqoX(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static bool BQbFAeAzbjeJQnqb(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Region$Op region$Op) {
        return canvas.clipRect(f, f2, f3, f4, region$Op);
    }

    public static bool BfJKCbXAuekXdozh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static void BvjbPuWiICHSJHsm(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void BwGcvtyZjAuwARRB(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.addOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static int BxKeUjpCBAJMhmQj(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static bool CDGAaPOZpegWJfMZ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return coordinatorLayout$Behavior.onTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static int CJpwuVaHZEwmOfjE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static android.view.object CNmHhROgYoXuFaib(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static bool CecSDWEbuPuCYaCR(android.view.object view) {
        return view.isOpaque();
    }

    public static java.lang.object CmwBosNBpaJVRBjz(java.util.List list, int i) {
        return list[i);
    }

    public static int CwTrcpErdvCimSoK(android.view.object view) {
        return view.getVisibility();
    }

    public static bool DGyzrvPIYrJEMdZY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$Behavior.layoutDependsOn(coordinatorLayout, view, view2);
    }

    public static android.view.objectParent DIfprESOmfJLbXLM(android.view.object view) {
        return view.getParent();
    }

    public static void DKYuMPOMJZlMPUGU(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$LayoutParams.resetChangedAfterNestedScroll();
    }

    public static int DMZjHTCLnWeZQnbS(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static int DNvxjPEHpvQuSEJK(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static android.view.objectGroup$LayoutParams DRSAMcWiecPEQEnz(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int DTXVzEkIvYfYUwYT(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int DVWujmJdUErHvzFc(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static java.lang.stringBuilder DavKKlIjrVbLiYlF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DrjQTNQydaZwSyDK(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static bool DrxRXEpFmOCPVgfV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.isChildrenDrawingOrderEnabled();
    }

    public static android.graphics.Rect DvfcWvapkxRMbAHB(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getLastChildRect();
    }

    public static java.lang.object DzzTzSJpuVquBbOV(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void EDVIwVkKSdFIVBYS(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.removePreDrawListener();
    }

    public static void EEAtegFtOoUcQhfk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetX(view, i);
    }

    public static int EFhpyttYxDLctRtC(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getImportantForAccessibility();
    }

    public static int EGaSRHoSvpzOQVsR(float f) {
        return java.lang.Math.round(f);
    }

    public static void EHXiLwQgnYesUtcV(android.view.objectGroup viewGroup, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener) {
        super.setOnHierarchyChangeListener(viewGroup$OnHierarchyChangeListener);
    }

    public static void EIRJfxhKrBQEGpGQ(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int EJGrQXxkrrJnBZXk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static int EJccZOlrSywkrwlx(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void EKOifrZaAFUoeHsV(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static android.view.objectGroup$LayoutParams EKxSCNruFnYPQuyC(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int ENYyBwPsOGdzqiyo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static java.lang.object EPtWmOzZPAAZGPWt(java.util.List list, int i) {
        return list[i);
    }

    public static android.graphics.Rect ERrhpwdUQaUXGQpF() {
        return acquireTempRect();
    }

    public static void ESPuGefRLBoMibrp(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        androidx.coordinatorlayout.widget.objectGroupUtils.getDescendantRect(viewGroup, view, rect);
    }

    public static void EXHVWXSZLaMeWJwK(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void EelxUEYyzoJjTtES(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onStopNestedScroll(view, i);
    }

    public static java.lang.stringBuilder EnFzkNsRObGAnPnk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EogmNyfRpAPyBctp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    public static java.lang.Class EwuQCPNVVXrHIieJ(java.lang.string str, bool z, java.lang.ClassLoader classLoader) {
        return java.lang.Class.forName(str, z, classLoader);
    }

    public static bool FQoSUfHbXmjeNOhc(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj) {
        return pools$Pool.release(obj);
    }

    public static int FSlagbUlJaoMCheW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.content.object FSocNCqgCkppkndy(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobject();
    }

    public static android.graphics.Rect FUrNKzKfEzoKAQqP() {
        return acquireTempRect();
    }

    public static void FXFRbJuUWvskOwxN(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static android.view.objectTreeObserver FYSNurvYAqbiVrHx(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobjectTreeObserver();
    }

    public static void FZVGSsfsDPKETfBP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        coordinatorLayout.onNestedScroll(view, i, i2, i3, i4, i5, iArr);
    }

    public static bool FiUEvpAwAOtvkpyV(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect, bool z) {
        return coordinatorLayout$Behavior.onRequestChildRectangleOnScreen(coordinatorLayout, view, rect, z);
    }

    public static void FmDmzuAvmxUuiclN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onLayoutChild(view, i);
    }

    public static int FtxvJpurcwkgvlWL(android.view.object view) {
        return view.getTop();
    }

    public static int GDfwogHkVmoErwrY(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static android.view.objectGroup$LayoutParams GLcBwXlsCWIgqcyg(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void GSkuqLNqGspqnIhK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.onChildobjectsChanged(i);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior GTcfHhsTJfegfSGe(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void GYcUValyzTqTWJla(android.view.objectGroup viewGroup) {
        super.onAttachedToWindow();
    }

    public static bool GbATFuCCWMAPxARP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static java.lang.Class GeEiJRhWWldYYcan(androidx.coordinatorlayout.widget.CoordinatorLayout$DefaultBehavior coordinatorLayout$DefaultBehavior) {
        return coordinatorLayout$DefaultBehavior.value();
    }

    public static void GmgjbFTGNCTHuchp(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static int GobPNZAJilvOVeMM(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool GrGFSwuRjDaUFzxz(android.graphics.Rect rect, android.graphics.Rect rect2) {
        return rect.Contains(rect2);
    }

    public static java.lang.stringBuilder GrxOorhADDZkQpnn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GvWVRRWlwgrVnkhM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.onChildobjectsChanged(i);
    }

    public static int GyxSBHUSwVeQdHSg(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool GzbsiEAIygbruUlC(android.view.object view) {
        return view.isLayoutRequested();
    }

    public static java.lang.reflect.Constructor HAKIdreRsmUhKWlM(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static androidx.core.view.WindowInsetsCompat HAzVkpjPfAlHLAfg(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return coordinatorLayout$Behavior.onApplyWindowInsets(coordinatorLayout, view, windowInsetsCompat);
    }

    public static bool HBsqqlSchGITCQBx(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.hasOutgoingEdges(obj);
    }

    public static int HFIasyexoejmcJzg(android.view.object view) {
        return view.getLeft();
    }

    public static int HIIUfQTGsgonKEuu(android.view.object view) {
        return view.getVisibility();
    }

    public static java.lang.stringBuilder HRsYnWBRwpmLLQsR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HUJKRvVKbPscSNlV(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static int HWcODtScLOwizoMK(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$Behavior.getScrimColor(coordinatorLayout, view);
    }

    public static int HXIvDNkbcqoHGQlM(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static int HXKmedgjUmDXfdtq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static int HZvqGgJGKHXnOxih(android.view.object view) {
        return view.getLeft();
    }

    public static android.view.object HmZTKMOdGUVpUbSn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void HtMTgOLmxGMZIqSv(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static bool HtXFlQbahwhZYAeF(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.isConsumed();
    }

    public static int HyLTDvvZVhKLrkml(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static int IMfRVVsTTgqkhOei(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static java.lang.Class INNADUXkOYSlpzSA(java.lang.Class cls) {
        return cls.getSuperclass();
    }

    public static java.lang.string IRtriezVfioVkVLu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IXaNSXFnCUAHQKnb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void IZJjMszRKTGLdlar(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    public static int IZkkJdTwiyTGgYay(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, int i2) {
        return coordinatorLayout.getChildDrawingOrder(i, i2);
    }

    public static android.view.object IgJNfaGFkOuhAVQp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int IllZsYneQwLDklUl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getSuggestedMinimumHeight();
    }

    public static android.view.objectGroup$LayoutParams ImhqCCBrslJzGfLM(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool InvBBhwspkEmiVlo(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static bool ItihPwskxAObMmLb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static android.view.object IwOHcTNSacXqTmAn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int JBirrLefyuqdmTSJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLayoutDirection();
    }

    public static bool JDkLJknpzLeDaAgh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static java.util.List JGqCtMkhCzzWKGJH() {
        return java.util.ICollections.emptyList();
    }

    public static void JKKojOKwuYKSElyG(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static android.view.objectGroup$LayoutParams JWHHyMLmEqBTAHGc(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.view.objectGroup$LayoutParams JcfvskszojfruEGg(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool JfHrfvhkQRNcmaBp(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void JnFSBfpMirvpWNnR(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static void JnNGWrRudiOpfkGb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, android.graphics.Rect rect, android.graphics.Rect rect2, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i2, int i3) {
        coordinatorLayout.getDesiredAnchoredChildRectWithoutConstraints(i, rect, rect2, coordinatorLayout$LayoutParams, i2, i3);
    }

    public static void JnztdfuPscvifPdM(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void JrWVKHgFZJCGaflH(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static void JtFTOflsHpvZeSOq(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static android.view.objectGroup$LayoutParams JvFrFzBooAacxoPZ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int JyvUzyDnsRSpSRuM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static int KEZaKpuexiAdlAzh(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static java.lang.string KEtJNXufKSyHJdxk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.view.objectParent KKAUDZQFCwImWVex(android.view.object view) {
        return view.getParent();
    }

    public static bool KMAcqqOWBKTfNQAb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static bool KNWELyNVUxqlMBfo(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$LayoutParams.isBlockingInteractionBelow(coordinatorLayout, view);
    }

    public static int KUIFbbCgeaWednmO(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static int KcWUpzFSCcgQucDG(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static int KcqtMrLGhZjxemHQ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void KlWklAKlUibzwgDU(java.util.List list, java.util.Comparator comparator) {
        java.util.ICollections.sort(list, comparator);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior KqxKWgGskVjZwOFJ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static android.os.Parcelable KscsvcuDmyvBtDKJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$Behavior.onSaveInstanceState(coordinatorLayout, view);
    }

    public static android.content.object KtaIpFHLeHLEEncy(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobject();
    }

    public static java.lang.stringBuilder KvAzTctXzkzpKGME(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KwUuOOlJtIDjpZWZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static android.graphics.Rect KyCTwPwhBnjXoXzE() {
        return acquireTempRect();
    }

    public static bool LBIIjRSquzphUMwP(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return coordinatorLayout$Behavior.onInterceptTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static java.lang.string LFwIgDiQrnpDJIaH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool LHQVeHCXSUcQbeRE(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static android.view.object LIlzJnvtqLFZHQwv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void LJFvyeILkqJbLoXR(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.requestLayout();
    }

    public static int LMOrKbMFJkRUezQJ(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int LOjUSMMusbwUsyna(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.distanceToTop();
    }

    public static android.view.objectGroup$LayoutParams LPivhzTYOvbhTeMk(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void LbadJmwQeTggtfcc(android.view.objectGroup viewGroup) {
        super.drawableStateChanged();
    }

    public static int LlgSefiTinOKdPfS(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static bool LmvjtnyPnyHqcUMh(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.checkAnchorChanged();
    }

    public static int LprgYQnjJggUgmmf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static android.view.MotionEvent MIcJVgOHEPSXxihj(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.MotionEvent motionEvent) {
        return coordinatorLayout.obtainCancelEvent(motionEvent);
    }

    public static int MJUuXvBHbjdsewjW(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static bool MJmPyQxHnXdTndgZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, android.view.object view, android.view.MotionEvent motionEvent, int i) {
        return coordinatorLayout.performEvent(coordinatorLayout$Behavior, view, motionEvent, i);
    }

    public static void MMqNEXmUoJinpPbH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.graphics.Rect rect, int i, int i2) {
        coordinatorLayout.constrainChildRect(coordinatorLayout$LayoutParams, rect, i, i2);
    }

    public static android.view.object MNOFWpTznSjhqVNv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.findDeepestFocusedChild(view);
    }

    public static void MjVnjtvPnonmEFUx(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.removeOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static int MnUEUtNRcFgiwYiv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.view.objectGroup$LayoutParams MsgiSkTHsmResyeW(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.graphics.Rect MvvRDhaZqMjnSVSJ() {
        return acquireTempRect();
    }

    public static android.graphics.Rect MxKHkPCsHkWjiJZs() {
        return acquireTempRect();
    }

    public static void MxzdnNXMZmCqqBdr(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.getLastChildRect(view, rect);
    }

    public static int MyRQTJIAxHzjqkXj(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static bool MzQIDWXRuKZOKSSS(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static void NDLXENdhZARgLEGR(android.view.objectGroup viewGroup, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior NDwhFEvycsWJIgLM(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior NDyelbrQqOQLasBG(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void NItgKZzuFRZmfoHB(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i, bool z) {
        coordinatorLayout$LayoutParams.setNestedScrollAccepted(i, z);
    }

    public static bool NNODTGwcCcpHExGk(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return coordinatorLayout$Behavior.onTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static void NPWKgVLuJptQTFHh(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int NPiddVFRzrQnHgYX(java.util.List list) {
        return list.Count;
    }

    public static int NWsuBvqLBYkovZlQ(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void NYlUuIGFXgWRMcDx(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static java.lang.reflect.Constructor NZuLZxQOUxNcTPna(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getConstructor(clsArr);
    }

    public static int NhFmrEnfjyIzAIXx(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void NkUDwVbqexVNWSLt(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        coordinatorLayout$Behavior.onDependentobjectRemoved(coordinatorLayout, view, view2);
    }

    public static android.view.object NrEmwxvLBRrRbZDp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void NsofcNpWppVrpnaj(java.util.List list) {
        java.util.ICollections.reverse(list);
    }

    public static void NuEbEtfByIwXQKva(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void OEhuObNpDrGSVxmc(java.util.List list) {
        list.clear();
    }

    public static void OMmggaetEurCRoPi(java.lang.reflect.Constructor constructor, bool z) {
        constructor.setAccessible(z);
    }

    public static android.graphics.drawable.Drawable OQVwzXWnoMmsPqgG(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static int OQgxHAcZdfAIZuog(android.view.object view) {
        return view.getLeft();
    }

    public static java.lang.Class OSiPAKLNtDjRGaWk(java.lang.object obj) {
        return obj.GetType();
    }

    public static int OSoIRBcwAixOJEck(android.view.objectGroup viewGroup) {
        return super.getSuggestedMinimumHeight();
    }

    public static void OWQJQQoqISdWPzku(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, android.graphics.Rect rect) {
        coordinatorLayout.getChildRect(view, z, rect);
    }

    public static void OWsjCCcPJeYaFJli(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static bool OYHBLNBbXAgsKGep(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int OaXuOsxGRWpGuKpZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getKeyline(i);
    }

    public static void OkxqFxTdALyZHCyc(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static android.view.objectGroup$LayoutParams OlhGcxjdEmisYHAJ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool OnVrPqgwCXUsFFhY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return coordinatorLayout$Behavior.onInterceptTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static int OwhalpEPhVxdGJXG(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int PIEpwByfMqynvJTG(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.view.object PIapFhQniSakyCOT(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int PLmaXRPjtVeMAseN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static bool PMZsHBcgGCPvjfuZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.hasDependencies(view);
    }

    public static void PNeVapqaaOSLbptU(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    public static android.view.object PWwXECYUdvjTfXYl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams PhFsJlDFcVFjoCcf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.getResolvedLayoutParams(view);
    }

    public static int PimOGdfsPPoDqRYY(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void PlyXPpqOrpyYAKsN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.cancelInterceptBehaviors();
    }

    public static void PxkDbptcRIjiXtMc(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, android.graphics.Rect rect) {
        coordinatorLayout.getChildRect(view, z, rect);
    }

    public static android.os.Parcelable PzsjdNfsBrfBUPAx(android.view.objectGroup viewGroup) {
        return super.onSaveInstanceState();
    }

    public static int QGlhrPTvRfpGprPz(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static android.view.MotionEvent QTwjlrkUWXMjBeuP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.MotionEvent motionEvent) {
        return coordinatorLayout.obtainCancelEvent(motionEvent);
    }

    public static void QWVtIXYyxQUlVEQz(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static android.view.objectGroup$LayoutParams QbBqXHaMShgmXrnI(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int QbRATHkSiWINWwdC(android.view.object view) {
        return view.getMeasuredState();
    }

    public static int QbsXcfhrzEaxEYMT(android.view.object view) {
        return view.getVisibility();
    }

    public static bool QdtnbOvsxZfyqUKN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2) {
        return coordinatorLayout.onStartNestedScroll(view, view2, i, i2);
    }

    public static android.view.objectGroup$LayoutParams QfxFjKdOMRVqnnuf(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void QixXrIjkTYXgAnMc(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int QlVqtpXZkJfNWjox(android.view.object view) {
        return view.getWidth();
    }

    public static int QrCpuTEzfupsAFHI(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.distanceToBottom();
    }

    public static int QrfXAcsEllLsbXns(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static java.lang.string QxRPqQQtmHuvsXmK(android.graphics.Rect rect) {
        return rect.toshortstring();
    }

    public static void RRShJsViHLmodCWw(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2, int[] iArr, int i3) {
        coordinatorLayout$Behavior.onNestedPreScroll(coordinatorLayout, view, view2, i, i2, iArr, i3);
    }

    public static void RRYChyykACdhHiuk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.onChildobjectsChanged(i);
    }

    public static java.lang.object RiTNWLBCWZsGIedQ(java.util.List list, int i) {
        return list[i);
    }

    public static int RljnTaUNSeWPNSUN(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static java.lang.object RoHRzUQxVtATOMNA(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static android.os.Parcelable RrvYJGHNkAfenFlw(androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState coordinatorLayout$SavedState) {
        return coordinatorLayout$SavedState.getSuperState();
    }

    public static int RsRZwuipUGCdwbKJ(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static int RtiDwQaMqPztsmrc(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static bool RxdYnNPWOmmIxLNI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int SAhAbQvNSDvOVwAp(android.view.object view) {
        return view.getId();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior SNBewfdNTksmHkkF(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int SONDcDvJaCmftzlV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static android.view.objectGroup$LayoutParams SRzxCkiRmbKOKRAT(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SUcGCiBdnqGJBEbc(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.graphics.Rect rect, int i, int i2) {
        coordinatorLayout.constrainChildRect(coordinatorLayout$LayoutParams, rect, i, i2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior SWRBDIJbGMUUgMqb(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int SWYklgrGXOzgUuiI(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void SiQKGDLjGJhworKW(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static int SlIDgtMSICtIDhxn(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object SmHyHBkMcipDnqbq(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static int SpqZjNZcBoajWpMW(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void TALRLtxRXTcXbytd(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static void TCuaIYOPWMMdmnfF(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetY(view, i);
    }

    public static void TEKLEvlzHDthMhoi(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void TFdtHWRRBPapgYEw(android.view.objectGroup viewGroup, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior THYzgAgHGgzhfKXN(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int TNuvQyXhfUCaQCrO(android.view.objectGroup viewGroup) {
        return super.getSuggestedMinimumWidth();
    }

    public static int TOfHkIsqFHAQbaOs(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static android.view.objectGroup$LayoutParams TYtVFxfRkhtRGQvC(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int TdPGilDpoQtJehik(java.util.List list) {
        return list.Count;
    }

    public static void TqPfXFPQsfEwYzwo(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$LayoutParams.resetChangedAfterNestedScroll();
    }

    public static int TsWqtJnOVRJnYaEL(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static bool TssqPDKdzajtFbMc(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static bool TxRfKvHfjxSxAIJE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, android.view.object view, android.view.MotionEvent motionEvent, int i) {
        return coordinatorLayout.performEvent(coordinatorLayout$Behavior, view, motionEvent, i);
    }

    public static bool UAtBcsoAKXuXTSnq(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static android.view.objectTreeObserver UCDOXngwKMpfUKdV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobjectTreeObserver();
    }

    public static int UFIRLTqeCewZwrif(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.lineDelta();
    }

    public static void UPVRxQeaIysQburY(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.removeOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static int URWCNpzjOTiyzKcP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getVisibility();
    }

    public static int UZqgiDueyXJSFEEY(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static java.lang.object UbXYePkeTtAZjKZv(java.util.List list, int i) {
        return list[i);
    }

    public static void UcwazzEIqZGygdaF(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void UcySSBNHHWmiUQfD(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        directedAcyclicGraph.addNode(obj);
    }

    public static java.lang.Package UhZLlkZfIJILzyua(java.lang.Class cls) {
        return cls.getPackage();
    }

    public static void UqfBGxOjDyGnZFdn(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        coordinatorLayout$LayoutParams.setBehavior(coordinatorLayout$Behavior);
    }

    public static void UvQLKdBzYJFVnpqa(androidx.core.view.NestedScrollingParentHelper nestedScrollingParentHelper, android.view.object view, int i) {
        nestedScrollingParentHelper.onStopNestedScroll(view, i);
    }

    public static android.view.objectGroup$LayoutParams UxyDTJZlHlZFLDWv(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int UxyYAjaYitkzGRfE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void UyGPibqtHSlfwDDk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.getDescendantRect(view, rect);
    }

    public static bool VCDiPrmaBCfNTFei(android.view.object view) {
        return view.isFocused();
    }

    public static int VERzPEltJpOeroAV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool VHdfSJvMwGxHhWYz(android.view.KeyEvent keyEvent) {
        return keyEvent.isAltPressed();
    }

    public static int VHfnaPhsuFmQfSlc(int i) {
        return resolveKeylineGravity(i);
    }

    public static void VHnsAKHaMZbdlDId(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.getDescendantRect(view, rect);
    }

    public static void VJsdWtdDmSYcVLvq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        coordinatorLayout.getDesiredAnchoredChildRect(view, i, rect, rect2);
    }

    public static int VMWKAcasWeTACNuN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior VWjGIWtFYxiDXrYC(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void VXloSxbdxiWvxukT(java.util.List list) {
        list.clear();
    }

    public static java.lang.object VgXtzpbloRemDDOj(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static bool VqwHROCSJEYQVxTL(android.view.object view) {
        return view.isLaidOut();
    }

    public static bool VxBBXGMZavwHxlTi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static int WAapGxMwhHIPMHPn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void WAvUykiSbFyzXrGE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onStopNestedScroll(view, i);
    }

    public static java.lang.stringBuilder WBEwSiWkDtogmIpx(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior WBszBSFAdHUqceCZ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void WJXDdpHnxRoELqbh(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams WLIKpuXJwzbYxtEy(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.util.AttributeHashSet attributeHashSet) {
        return coordinatorLayout.generateLayoutParams(attributeHashSet);
    }

    public static bool WaNvRssWEFVoIdWn(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.Contains(obj);
    }

    public static java.lang.string WhAZfILcnyvWSpiq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WmEeYHiQofGjTYCL(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        directedAcyclicGraph.addNode(obj);
    }

    public static java.lang.stringBuilder WnDsXjgwssvpRXEL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void WtGYySXSYpFACsQx(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetX(view, i);
    }

    public static java.lang.Class WwQbJQuroUOmZcEz(androidx.coordinatorlayout.widget.CoordinatorLayout$DefaultBehavior coordinatorLayout$DefaultBehavior) {
        return coordinatorLayout$DefaultBehavior.value();
    }

    public static void WwudQohFlIrCMYQi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.setImportantForAccessibility(i);
    }

    public static bool XCVbATAfGaPHypvL(java.util.List list) {
        return list.Count == 0;
    }

    public static void XMHUiEOltoRECBKO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.invalidate();
    }

    public static int XPIJnSnXejNtMwvV(android.view.object view) {
        return view.getVisibility();
    }

    public static int XRikPSqlHcXnZldC(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.pageDelta();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior XSEbWBieIbIQEnIs(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int XfvxemuHvyeAxWpg(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLayoutDirection();
    }

    public static bool XomEizefFFlyNSIe(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2) {
        return coordinatorLayout.onStartNestedScroll(view, view2, i, i2);
    }

    public static int XyQPSKnRnwkOOdYZ(int i) {
        return resolveKeylineGravity(i);
    }

    public static bool YHeRlrsuxFlFvEvO(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static bool YIAvCSklTQVyEByx(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$Behavior.onDependentobjectChanged(coordinatorLayout, view, view2);
    }

    public static bool YKfDXcnQDZcsFxzH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void YMVeMPiBMpEdxaHC(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        coordinatorLayout.onStopNestedScroll(view);
    }

    public static bool YOyZleIiLHflmotn(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static java.lang.string YPNptmCgqSQrXxBy(java.lang.Package r1) {
        return r1.getName();
    }

    public static void YSCJxYHtLmcYfCQc(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        coordinatorLayout.onNestedScroll(view, i, i2, i3, i4, i5, iArr);
    }

    public static void YSkQdmCjRYBotlGy(android.view.objectGroup viewGroup) {
        super.onDetachedFromWindow();
    }

    public static android.graphics.Rect YTAhWbPqYJqmtkPP() {
        return acquireTempRect();
    }

    public static int YTGRFoEkUBdbHFFC(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void YhMSaWanUaIbpgWN(androidx.core.view.NestedScrollingParentHelper nestedScrollingParentHelper, android.view.object view, android.view.object view2, int i, int i2) {
        nestedScrollingParentHelper.onNestedScrollAccepted(view, view2, i, i2);
    }

    public static java.lang.object YjHttjWZYCZnPZlZ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void YmAYzDVOZyQYqpoM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, android.graphics.Rect rect, android.graphics.Rect rect2, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i2, int i3) {
        coordinatorLayout.getDesiredAnchoredChildRectWithoutConstraints(i, rect, rect2, coordinatorLayout$LayoutParams, i2, i3);
    }

    public static java.lang.string YnhbTgsjcIBYrvzO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int YpmAZLotfinHVVst(androidx.core.view.NestedScrollingParentHelper nestedScrollingParentHelper) {
        return nestedScrollingParentHelper.getNestedScrollAxes();
    }

    public static void YrwqGOGzUJJvgwNx(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        coordinatorLayout.onNestedScroll(view, i, i2, i3, i4, i5);
    }

    public static int YyCXKEvpJbEDllEm(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior YySdKkwzPBTyBlgg(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int YywYSfACpBkmgzzv(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int YzNLkeCZMtKpIauG(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLayoutDirection();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior ZBQAzzdEkEPxDUng(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void ZIRlcrPgockEZrdA(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static android.content.res.TypedArray ZKmsuxkPuDRnxOqq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static android.view.objectGroup$LayoutParams ZLnSUjbWjsDTpcBL(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.string ZPdlhSQwQEcNZqTm(android.graphics.Rect rect) {
        return rect.toshortstring();
    }

    public static int ZThwzSvUlTwXDMeC(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.MotionEvent ZWCoWOGIxRljHBVb(long j, long j2, int i, float f, float f2, int i2) {
        return android.view.MotionEvent.obtain(j, j2, i, f, f2, i2);
    }

    public static android.view.object ZXNSDuJfIjsvZJFQ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static android.view.objectGroup$LayoutParams ZYHVFlQvcdkYpDpw(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool ZdDDDgFPZCuTmsQv(android.view.KeyEvent keyEvent) {
        return keyEvent.isAltPressed();
    }

    public static bool ZipvfOTAhllOIQgE(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static android.view.objectGroup$LayoutParams ZnFGcyKDvjUyFpbx(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.stringBuilder ZsGftsKoplDFKxOH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ZufpIOzGObRooCtD(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int ABnskVMiRzzARswH(android.view.object view) {
        return view.getTop();
    }

    public static int AEprOJVuAYuexclD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior aNQxXLNtYSJojKrG(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void AVxhWTtmwyBjEECN(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static java.lang.object AXZEvUmTKSLTwPhQ(androidx.core.util.Pools$Pool pools$Pool) {
        return pools$Pool.acquire();
    }

    public static android.view.object AYkFWxeoAxRsrylb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int AbaNzKcfeJGnSnXr(android.view.object view) {
        return view.getVisibility();
    }

    private static android.graphics.Rect AcquireTempRect() {
        android.graphics.Rect rect = (android.graphics.Rect) aXZEvUmTKSLTwPhQ(sRectPool);
        if (rect is null) {
            rect = new android.graphics.Rect();
        }
        return rect;
    }

    public static int AeOjqTwxkyfOURcl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static int AhnHgAHQqyxLVUuM(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetRight();
    }

    public static java.lang.object AjGJzloLwGjCQcEp(java.util.List list, int i) {
        return list[i);
    }

    public static android.view.object AjiHpTMjYZKCNoLg(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static android.graphics.Rect AuQTOszSOUtPHxrT() {
        return acquireTempRect();
    }

    public static int AzjkjLnzuTIHGFCa(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static int BAqheZPAJKEbikHs(int i, int i2) {
        return android.view.object.combineMeasuredStates(i, i2);
    }

    public static void BFQEIzyfxdZWtFDP(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable) {
        coordinatorLayout$Behavior.onRestoreInstanceState(coordinatorLayout, view, parcelable);
    }

    public static bool BFynKkxPoyesIIpH(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static android.view.objectGroup$LayoutParams bHizFMgFZDfigvos(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void BIkOiwFZwyYENOdK(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static int BPdYfEsRMVydHENb(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int BQZeZFErmcCDrsUQ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static void BbMuwQwsnyFUzqPj(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, android.view.object view3, int i, int i2) {
        coordinatorLayout$Behavior.onNestedScrollAccepted(coordinatorLayout, view, view2, view3, i, i2);
    }

    public static int BcOSRxkJqqDszOzX(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static int BcRYFmqqjyZrXtrP(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void BjiPXeRUvHNScjSV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.prepareChildren();
    }

    public static void BlHoyuglFbxlfTgD(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static int BnTnvbjNJswjPrla(android.graphics.Rect rect) {
        return rect.width();
    }

    public static void BntEOQuVOJpsMzUS(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static void BvlQKbAVavcHiQkJ(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph) {
        directedAcyclicGraph.clear();
    }

    public static int ByMwmwPKLtMbBbQu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.util.List BzDdPyWzIcVUuJkO(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.getOutgoingEdges(obj);
    }

    public static android.graphics.Rect CAyzNQyxzeCUZMVq() {
        return acquireTempRect();
    }

    public static int CDcypVQejOHfkmdf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void CEgavBvRLEhdhzHI(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, java.util.List list) {
        coordinatorLayout.getTopSortedChildren(list);
    }

    public static int CHKdLQiqchoUfYBB(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.pageDelta();
    }

    public static void CJWPbKJUfWxFeemK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.getDescendantRect(view, rect);
    }

    public static void CMaeVPRXbsiazfDH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    private void CancelInterceptBehaviors() {
        if ((29 + 10) % 10 > 0) {
        }
        int iUdjlExEjZWuQVxRn = udjlExEjZWuQVxRn(this);
        android.view.MotionEvent motionEventZWCoWOGIxRljHBVb = null;
        for (int i = 0; i < iUdjlExEjZWuQVxRn; i++) {
            android.view.object viewHGfGdqHkhJaUDQnC = hGfGdqHkhJaUDQnC(this, i);
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorDOEFVWyIgpMrWEfX = dOEFVWyIgpMrWEfX((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) duLgNriCYuRXBkbC(viewHGfGdqHkhJaUDQnC));
            if (coordinatorLayout$BehaviorDOEFVWyIgpMrWEfX is not null) {
                if (motionEventZWCoWOGIxRljHBVb is null) {
                    long jPIMyLhWxyCJBttCq = pIMyLhWxyCJBttCq();
                    motionEventZWCoWOGIxRljHBVb = ZWCoWOGIxRljHBVb(jPIMyLhWxyCJBttCq, jPIMyLhWxyCJBttCq, 3, 0.0f, 0.0f, 0);
                }
                LBIIjRSquzphUMwP(coordinatorLayout$BehaviorDOEFVWyIgpMrWEfX, this, viewHGfGdqHkhJaUDQnC, motionEventZWCoWOGIxRljHBVb);
            }
        }
        if (motionEventZWCoWOGIxRljHBVb is null) {
            return;
        }
        JnFSBfpMirvpWNnR(motionEventZWCoWOGIxRljHBVb);
    }

    public static bool CfCmRItgCaIZkkZi(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return coordinatorLayout$Behavior.onLayoutChild(coordinatorLayout, view, i);
    }

    public static int CgBgwARkPlFChSNi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int CiORGiOFOmpukjDU(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private static int Clamp(int i, int i2, int i3) {
        return i >= i2 ? i <= i3 ? i : i3 : i2;
    }

    public static int CldQHzoYpbbEscko(android.view.object view) {
        return view.getRight();
    }

    private void ConstrainChildRect(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.graphics.Rect rect, int i, int i2) {
        if ((6 + 30) % 30 > 0) {
        }
        int iHVelYrHozlLPBmDJ = hVelYrHozlLPBmDJ(this);
        int iBIjYQmnMlkbPxfUO = BIjYQmnMlkbPxfUO(this);
        int iYyCXKEvpJbEDllEm = YyCXKEvpJbEDllEm(SONDcDvJaCmftzlV(this) + coordinatorLayout$LayoutParams.leftMargin, SWYklgrGXOzgUuiI(rect.left, ((iHVelYrHozlLPBmDJ - QGlhrPTvRfpGprPz(this)) - i) - coordinatorLayout$LayoutParams.rightMargin));
        int iGobPNZAJilvOVeMM = GobPNZAJilvOVeMM(MJUuXvBHbjdsewjW(this) + coordinatorLayout$LayoutParams.topMargin, bPdYfEsRMVydHENb(rect.top, ((iBIjYQmnMlkbPxfUO - pInKtXYABPnwRhBP(this)) - i2) - coordinatorLayout$LayoutParams.bottomMargin));
        JnztdfuPscvifPdM(rect, iYyCXKEvpJbEDllEm, iGobPNZAJilvOVeMM, i + iYyCXKEvpJbEDllEm, i2 + iGobPNZAJilvOVeMM);
    }

    public static int CpBGLGkgfMIDOsFt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static java.lang.stringBuilder CvvmoVceDSQfzxvZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DDyiFttrllrYZoxm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DEWPKHZWaeeaBOWQ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        coordinatorLayout$LayoutParams.resetNestedScroll(i);
    }

    public static int DHOkoddpPDXWvLaB(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static android.util.DisplayMetrics DHchRgrtkcnHodYy(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static int DLOUTiASbHvwvZQb(android.view.object view) {
        return view.getTop();
    }

    public static bool DLUyMrCXTONXQeiN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static void DMygzYUmYHlYJeas(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        coordinatorLayout$Behavior.onNestedScroll(coordinatorLayout, view, view2, i, i2, i3, i4, i5, iArr);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior dOEFVWyIgpMrWEfX(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void DQVXILcIWtdAZdGf(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static void DVqCMlOPNQJimqRm(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static android.view.object DZbzeouCuazWGbTg(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int DZioVIRfTFZwvpnX(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static int DdeDkNRBUoSKwQOp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static int DhdAIiiUiaBpgjPJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private androidx.core.view.WindowInsetsCompat DispatchApplyWindowInsetsToBehaviors(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorNDwhFEvycsWJIgLM;
        if ((3 + 19) % 19 > 0) {
        }
        if (uqiZYqvpmjDUTzSZ(windowInsetsCompat)) {
            return windowInsetsCompat;
        }
        int iQAOIdvsawnfNCKHN = qAOIdvsawnfNCKHN(this);
        for (int i = 0; i < iQAOIdvsawnfNCKHN; i++) {
            android.view.object viewRjhDmEGglPqmKDUu = rjhDmEGglPqmKDUu(this, i);
            if (BOiWwDMfHdCZWqoX(viewRjhDmEGglPqmKDUu) && (coordinatorLayout$BehaviorNDwhFEvycsWJIgLM = NDwhFEvycsWJIgLM((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) UxyDTJZlHlZFLDWv(viewRjhDmEGglPqmKDUu))) is not null) {
                windowInsetsCompat = HAzVkpjPfAlHLAfg(coordinatorLayout$BehaviorNDwhFEvycsWJIgLM, this, viewRjhDmEGglPqmKDUu, windowInsetsCompat);
                if (HtXFlQbahwhZYAeF(windowInsetsCompat)) {
                    return windowInsetsCompat;
                }
            }
        }
        return windowInsetsCompat;
    }

    private int DistanceToBottom() {
        return gDCzsLjHzbQHiGNf(this) - UZqgiDueyXJSFEEY(this);
    }

    private int DistanceToTop() {
        return -rqKjDocKwuXlgykV(this);
    }

    public static bool DnauyWurburjXiqM(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static void DtwosfTiYohiLTvp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int[] iArr, int i3) {
        coordinatorLayout.onNestedPreScroll(view, i, i2, iArr, i3);
    }

    public static android.view.objectGroup$LayoutParams duLgNriCYuRXBkbC(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int DukkUNLbPoBtuYZt(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int EHhNFiYDXXXrLxXe(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static int EMDRwSOOFeFeBerm(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void ENfXNbIWNZifrViq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    public static int EXhTbYLAZVKDplUy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool EZJwunvHLxcbFdoq(android.graphics.Rect rect) {
        return rect.Count == 0;
    }

    public static void EaeoixIKFzRSQTZO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2) {
        coordinatorLayout.onNestedScrollAccepted(view, view2, i, i2);
    }

    public static java.util.List EeZFIFdNGPphUPBq(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph) {
        return directedAcyclicGraph.getSortedList();
    }

    public static int EiaZljeuppzQENTz(android.view.object view) {
        return view.getId();
    }

    public static int EjdsOUsbRIUkAZGz(android.view.object view) {
        return view.getRight();
    }

    public static int EkByhuJTTxDykyAs(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.distanceToTop();
    }

    public static int EpHHqjbObRaBfehQ(android.view.object view) {
        return view.getRight();
    }

    public static android.view.objectGroup$LayoutParams epSAZHzJRVMSHpfn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int EqmcOsvYprKjdssn(android.view.object view) {
        return view.getBottom();
    }

    public static bool ErbWJMzvLjztHAyo(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static int EuxOVmJhLgLRASFV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.distanceToBottom();
    }

    public static int EywKpujoIkSlnvwH(java.util.List list) {
        return list.Count;
    }

    public static bool FGJlpKnPaNpNdJHe(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2, bool z) {
        return coordinatorLayout$Behavior.onNestedFling(coordinatorLayout, view, view2, f, f2, z);
    }

    public static void FJlhgSGuPgqLhFXY(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawRect(f, f2, f3, f4, paint);
    }

    public static int FMrjpPAHjYhPBKue(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getKeyline(i);
    }

    public static void FOauvGMQXxHGhCOx(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static int FQOZfqppFsnoUxys(android.view.object view) {
        return view.getVisibility();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior fYegvRzROfVnoYVS(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior fdwtczNnvVuxrQBQ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior feiCyRMAMDAFgKIE(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static int FiODFAtEWSAjzZla(int i, int i2, int i3) {
        return android.view.object.resolveSizeAndState(i, i2, i3);
    }

    public static void FinaNzlLdjHxPOMN(java.util.List list) {
        list.clear();
    }

    private android.view.object FindDeepestFocusedChild(android.view.object view) {
        while (true) {
            android.view.object viewQWdkgfsTFKWDPUNP = null;
            if (view is null) {
                return null;
            }
            if (VCDiPrmaBCfNTFei(view)) {
                return view;
            }
            if (view is android.view.objectGroup) {
                viewQWdkgfsTFKWDPUNP = qWdkgfsTFKWDPUNP((android.view.objectGroup) view);
            }
            view = viewQWdkgfsTFKWDPUNP;
        }
    }

    public static bool FjoMzQroHSRohBgE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, android.view.object view, android.view.MotionEvent motionEvent, int i) {
        return coordinatorLayout.performEvent(coordinatorLayout$Behavior, view, motionEvent, i);
    }

    public static java.lang.object FozcNHaOLgUaBBGR(java.util.List list, int i) {
        return list[i);
    }

    public static void FqfANGzBAoxHchXu(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static void GBcDKoQzoIhagHHT(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj, java.lang.object obj2) {
        directedAcyclicGraph.addEdge(obj, obj2);
    }

    public static int GDCzsLjHzbQHiGNf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getFullContentHeight();
    }

    public static android.view.objectGroup$LayoutParams gNxocIIgQGFyhAOU(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int GPmdwEhdorgMHuyp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.pageDelta();
    }

    public static bool GRfApUsbBZIKoMIj(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static java.lang.ClassLoader GTlUbUlfdSpnWJCS(android.content.object context) {
        return context.getClassLoader();
    }

    public static void GUbqsvjfCgroupaK(android.view.objectGroup viewGroup, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static int GcwvABsmJHntUczk(android.view.object view) {
        return view.getVisibility();
    }

    private void GetDesiredAnchoredChildRectWithoutConstraints(int i, android.graphics.Rect rect, android.graphics.Rect rect2, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i2, int i3) {
        if ((2 + 1) % 1 > 0) {
        }
        int iIblBUMJoeRcIdmOR = iblBUMJoeRcIdmOR(rKRQHEArKhKRgnPC(coordinatorLayout$LayoutParams.gravity), i);
        int iEHhNFiYDXXXrLxXe = eHhNFiYDXXXrLxXe(ngoOMjaiyeRbEXLt(coordinatorLayout$LayoutParams.anchorGravity), i);
        int i4 = iIblBUMJoeRcIdmOR & 7;
        int i5 = iIblBUMJoeRcIdmOR & 112;
        int i6 = iEHhNFiYDXXXrLxXe & 7;
        int i7 = iEHhNFiYDXXXrLxXe & 112;
        int iBnTnvbjNJswjPrla = i6 == 1 ? rect.left + (bnTnvbjNJswjPrla(rect) / 2) : i6 == 5 ? rect.right : rect.left;
        int iOLMSXsOigrASUPoM = i7 == 16 ? rect.top + (oLMSXsOigrASUPoM(rect) / 2) : i7 == 80 ? rect.bottom : rect.top;
        if (i4 == 1) {
            iBnTnvbjNJswjPrla -= i2 / 2;
        } else if (i4 != 5) {
            iBnTnvbjNJswjPrla -= i2;
        }
        if (i5 == 16) {
            iOLMSXsOigrASUPoM -= i3 / 2;
        } else if (i5 != 80) {
            iOLMSXsOigrASUPoM -= i3;
        }
        FXFRbJuUWvskOwxN(rect2, iBnTnvbjNJswjPrla, iOLMSXsOigrASUPoM, i2 + iBnTnvbjNJswjPrla, i3 + iOLMSXsOigrASUPoM);
    }

    private int GetFullContentHeight() {
        if ((23 + 1) % 1 > 0) {
        }
        int iMTwwZFWfFtGBUztI = 0;
        for (int i = 0; i < VMWKAcasWeTACNuN(this); i++) {
            android.view.object viewIgJNfaGFkOuhAVQp = IgJNfaGFkOuhAVQp(this, i);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) JvFrFzBooAacxoPZ(viewIgJNfaGFkOuhAVQp);
            iMTwwZFWfFtGBUztI += mTwwZFWfFtGBUztI(viewIgJNfaGFkOuhAVQp) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin;
        }
        return iMTwwZFWfFtGBUztI;
    }

    private int GetKeyline(int i) {
        if ((30 + 29) % 29 > 0) {
        }
        int[] iArr = this.mKeylines;
        if (iArr is null) {
            kMWjuVdQGRfNIlFI("CoordinatorLayout", ACbVerAAAhHpdgwY(DavKKlIjrVbLiYlF(GrxOorhADDZkQpnn(mgqiWChzBYYqgODa(new java.lang.stringBuilder("No keylines defined for "), this), " - attempted index lookup "), i)));
            return 0;
        }
        if (i >= 0 && i < iArr.length) {
            return iArr[i];
        }
        MnUEUtNRcFgiwYiv("CoordinatorLayout", mFCjGACBBhseQFAM(WnDsXjgwssvpRXEL(opLWgagmpEYxZabZ(WBEwSiWkDtogmIpx(new java.lang.stringBuilder("Keyline index "), i), " out of range for "), this)));
        return 0;
    }

    private void GetTopSortedChildren(java.util.List<android.view.object> list) {
        if ((10 + 3) % 3 > 0) {
        }
        finaNzlLdjHxPOMN(list);
        bool zDrxRXEpFmOCPVgfV = DrxRXEpFmOCPVgfV(this);
        int iCDcypVQejOHfkmdf = cDcypVQejOHfkmdf(this);
        for (int i = iCDcypVQejOHfkmdf - 1; i >= 0; i--) {
            RxdYnNPWOmmIxLNI(list, PWwXECYUdvjTfXYl(this, !zDrxRXEpFmOCPVgfV ? i : IZkkJdTwiyTGgYay(this, iCDcypVQejOHfkmdf, i)));
        }
        java.util.Comparator<android.view.object> comparator = TOP_SORTED_CHILDREN_COMPARATOR;
        if (comparator is null) {
            return;
        }
        KlWklAKlUibzwgDU(list, comparator);
    }

    public static bool GmVjqTPSNmrmetUD(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static int GsArhCIGcpVmobcE(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static void GtjEsSnYmddwpJDc(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void GvrJWvliQWhGexSq(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static java.util.List GyOrybHQcSINSvGV(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.getIncomingEdgesInternal(obj);
    }

    public static void HBQdBSbXBJLZYaGk(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int HDnTKfVEroEHlmKR(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static android.view.object HGfGdqHkhJaUDQnC(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static bool HHKySAVcBxbBbwAq(android.view.objectGroup viewGroup, android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent);
    }

    public static android.graphics.Rect HLGAyKLQmmtvJKUU() {
        return acquireTempRect();
    }

    public static int HQaBIWDYGHjnZXej(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static java.lang.string HRgPdVEXRuxQhowh(java.lang.Class cls) {
        return cls.getName();
    }

    public static int HVelYrHozlLPBmDJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static bool HXWZImhaWWquOjiR(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.didBlockInteraction();
    }

    private bool HasDependencies(android.view.object view) {
        return HBsqqlSchGITCQBx(this.mChildDag, view);
    }

    public static void HbCHUBicLiNZEzDz(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, int i2) {
        coordinatorLayout.setMeasuredDimension(i, i2);
    }

    public static java.lang.stringBuilder HjILljcQouxFwCCK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HlSPEvUJibDnrQSv(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static bool HxjYHrhlugQCTese(android.graphics.Rect rect, java.lang.object obj) {
        return rect.Equals(obj);
    }

    public static java.util.List HyFptEzBPMMFApED(androidx.coordinatorlayout.widget.DirectedAcyclicGraph directedAcyclicGraph, java.lang.object obj) {
        return directedAcyclicGraph.getIncomingEdges(obj);
    }

    public static int HyuVDNWwpAkjIVbE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.lineDelta();
    }

    public static void IKLNxHkcgwFKZkAS(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetLeftAndRight(view, i);
    }

    public static void IOxBlItRpdvIkZDq(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetY(view, i);
    }

    public static void IVpyEIDixhRULlIk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        coordinatorLayout.recordLastChildRect(view, rect);
    }

    public static void IWBdhMuEvLDQepTJ(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static android.graphics.Rect IYiyhZTaVAmEgtlR() {
        return acquireTempRect();
    }

    public static int IblBUMJoeRcIdmOR(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static int IbqppdTehRYAebKn(java.util.List list) {
        return list.Count;
    }

    public static bool IjcCchzkxgFbcbzE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.MotionEvent motionEvent, int i) {
        return coordinatorLayout.performIntercept(motionEvent, i);
    }

    public static int IoCgFXIHBbpIQLjh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static bool IrefHRxhCYVJcMct(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return coordinatorLayout.manuallyTriggersNestedScrollFromKeyEvent(view, i);
    }

    public static int IxwJLbNLXoXCIZyt(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static androidx.core.view.WindowInsetsCompat JDTbkXWamYssIqaG(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return coordinatorLayout.dispatchApplyWindowInsetsToBehaviors(windowInsetsCompat);
    }

    public static int JEbNSFllEkuZzhRc(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void JKOICfZecbRxyGWf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, android.graphics.Rect rect) {
        coordinatorLayout.getChildRect(view, z, rect);
    }

    public static java.lang.object JKxhFestnfwFKUTt(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int JNRfKjjLWuWzkvWb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void JQzwOTzzmAKnBUhZ(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void JheAVZcdBOsqxbts(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    public static int JwkiwdYqdWcWOieZ(android.view.object view) {
        return view.getVisibility();
    }

    public static int JwpOhFcnZegaVItl(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void JyjzrZoximfVNvdb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i) {
        coordinatorLayout.layoutChildWithAnchor(view, view2, i);
    }

    public static void KDDWCPyEuePwbpez(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int KEDTQuOTPokcvpmf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static android.view.objectGroup$LayoutParams kELguzSuMeJcOzSX(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int KIIeDCZaVIiXHuub(java.util.List list) {
        return list.Count;
    }

    public static void KIvwaKxtnJmQdnkB(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static int KJNznGkFGSPQIixk(android.view.object view) {
        return view.getVisibility();
    }

    public static int KMWjuVdQGRfNIlFI(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void KMkHvSbbhbZQJkFL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        coordinatorLayout.layoutChildWithKeyline(view, i, i2);
    }

    public static void KOXjxVPlxKUhsAQR(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static java.util.List KOyuoalHvAeRGFoR() {
        return java.util.ICollections.emptyList();
    }

    public static bool KcCiTNAfiLkMgexZ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect) {
        return coordinatorLayout$Behavior.getInsetDodgeRect(coordinatorLayout, view, rect);
    }

    public static android.view.object KhBwOyEXvEvjWXGZ(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$LayoutParams.findAnchorobject(coordinatorLayout, view);
    }

    public static void KksauBLGJmAFefEa(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        coordinatorLayout$LayoutParams.resetTouchBehaviorTracking();
    }

    public static android.view.objectGroup$LayoutParams kuipvXpJGeBZWGCB(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool KvfyBOusisXqrxSC(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static void KxKNHDFleGxObaow(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.setupForInsets();
    }

    public static bool LAspqMNEUvHRgKwl(android.view.objectGroup viewGroup, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static int LHOJVxqzjvjzRuyh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static bool LMYoSdSGnLhmBdAI(android.view.objectGroup viewGroup, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return super.checkLayoutParams(viewGroup$LayoutParams);
    }

    public static int LSINtecxiGgakhVh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static android.view.objectTreeObserver LUKLcplTztFRFPRN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobjectTreeObserver();
    }

    public static java.lang.string LZheUNcyfDFNJRDz(android.content.object context) {
        return context.getPackageName();
    }

    private void LayoutChild(android.view.object view, int i) {
        if ((31 + 21) % 21 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) JcfvskszojfruEGg(view);
        android.graphics.Rect rectABVKZfjTACLvIPrR = ABVKZfjTACLvIPrR();
        jQzwOTzzmAKnBUhZ(rectABVKZfjTACLvIPrR, kEDTQuOTPokcvpmf(this) + coordinatorLayout$LayoutParams.leftMargin, AwpEZIvrlnFwhxSN(this) + coordinatorLayout$LayoutParams.topMargin, (GDfwogHkVmoErwrY(this) - bQZeZFErmcCDrsUQ(this)) - coordinatorLayout$LayoutParams.rightMargin, (TOfHkIsqFHAQbaOs(this) - ioCgFXIHBbpIQLjh(this)) - coordinatorLayout$LayoutParams.bottomMargin);
        if (this.mLastInsets is not null && UAtBcsoAKXuXTSnq(this) && !xcqnbkFmDamEvruq(view)) {
            rectABVKZfjTACLvIPrR.left += gsArhCIGcpVmobcE(this.mLastInsets);
            rectABVKZfjTACLvIPrR.top += TsWqtJnOVRJnYaEL(this.mLastInsets);
            rectABVKZfjTACLvIPrR.right -= ahnHgAHQqyxLVUuM(this.mLastInsets);
            rectABVKZfjTACLvIPrR.bottom -= HXIvDNkbcqoHGQlM(this.mLastInsets);
        }
        android.graphics.Rect rectNyIQWcdqpTAUvCUj = nyIQWcdqpTAUvCUj();
        upLjsxOuoYAtuBRz(uhfAPMPMKQyCHVHE(coordinatorLayout$LayoutParams.gravity), jwpOhFcnZegaVItl(view), OwhalpEPhVxdGJXG(view), rectABVKZfjTACLvIPrR, rectNyIQWcdqpTAUvCUj, i);
        GmgjbFTGNCTHuchp(view, rectNyIQWcdqpTAUvCUj.left, rectNyIQWcdqpTAUvCUj.top, rectNyIQWcdqpTAUvCUj.right, rectNyIQWcdqpTAUvCUj.bottom);
        kDDWCPyEuePwbpez(rectABVKZfjTACLvIPrR);
        qpOBWNcbYtkoyTzE(rectNyIQWcdqpTAUvCUj);
    }

    private void LayoutChildWithAnchor(android.view.object view, android.view.object view2, int i) {
        if ((4 + 17) % 17 > 0) {
        }
        android.graphics.Rect rectHLGAyKLQmmtvJKUU = hLGAyKLQmmtvJKUU();
        android.graphics.Rect rectFUrNKzKfEzoKAQqP = FUrNKzKfEzoKAQqP();
        try {
            cJWPbKJUfWxFeemK(this, view2, rectHLGAyKLQmmtvJKUU);
            VJsdWtdDmSYcVLvq(this, view, i, rectHLGAyKLQmmtvJKUU, rectFUrNKzKfEzoKAQqP);
            OkxqFxTdALyZHCyc(view, rectFUrNKzKfEzoKAQqP.left, rectFUrNKzKfEzoKAQqP.top, rectFUrNKzKfEzoKAQqP.right, rectFUrNKzKfEzoKAQqP.bottom);
            JrWVKHgFZJCGaflH(rectHLGAyKLQmmtvJKUU);
            kIvwaKxtnJmQdnkB(rectFUrNKzKfEzoKAQqP);
        } catch (java.lang.Exception th) {
            ZufpIOzGObRooCtD(rectHLGAyKLQmmtvJKUU);
            JtFTOflsHpvZeSOq(rectFUrNKzKfEzoKAQqP);
            throw th;
        }
    }

    private void LayoutChildWithKeyline(android.view.object view, int i, int i2) {
        if ((19 + 18) % 18 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) EKxSCNruFnYPQuyC(view);
        int iPmDoRIyTRdGtkrCt = pmDoRIyTRdGtkrCt(XyQPSKnRnwkOOdYZ(coordinatorLayout$LayoutParams.gravity), i2);
        int i3 = iPmDoRIyTRdGtkrCt & 7;
        int i4 = iPmDoRIyTRdGtkrCt & 112;
        int iJNRfKjjLWuWzkvWb = jNRfKjjLWuWzkvWb(this);
        int iJyvUzyDnsRSpSRuM = JyvUzyDnsRSpSRuM(this);
        int iKEZaKpuexiAdlAzh = KEZaKpuexiAdlAzh(view);
        int iLMOrKbMFJkRUezQJ = LMOrKbMFJkRUezQJ(view);
        if (i2 == 1) {
            i = iJNRfKjjLWuWzkvWb - i;
        }
        int iOaXuOsxGRWpGuKpZ = OaXuOsxGRWpGuKpZ(this, i) - iKEZaKpuexiAdlAzh;
        if (i3 == 1) {
            iOaXuOsxGRWpGuKpZ += iKEZaKpuexiAdlAzh / 2;
        } else if (i3 == 5) {
            iOaXuOsxGRWpGuKpZ += iKEZaKpuexiAdlAzh;
        }
        int i5 = i4 == 16 ? iLMOrKbMFJkRUezQJ / 2 : i4 == 80 ? iLMOrKbMFJkRUezQJ : 0;
        int iGyxSBHUSwVeQdHSg = GyxSBHUSwVeQdHSg(yZPEDNYUbRCAntpD(this) + coordinatorLayout$LayoutParams.leftMargin, ixwJLbNLXoXCIZyt(iOaXuOsxGRWpGuKpZ, ((iJNRfKjjLWuWzkvWb - tFPUageyZoqnFYPi(this)) - iKEZaKpuexiAdlAzh) - coordinatorLayout$LayoutParams.rightMargin));
        int iCiORGiOFOmpukjDU = ciORGiOFOmpukjDU(LprgYQnjJggUgmmf(this) + coordinatorLayout$LayoutParams.topMargin, mUrLUKwRBwSPzgHk(i5, ((iJyvUzyDnsRSpSRuM - AKBpsHVDlmtiYuZl(this)) - iLMOrKbMFJkRUezQJ) - coordinatorLayout$LayoutParams.bottomMargin));
        WJXDdpHnxRoELqbh(view, iGyxSBHUSwVeQdHSg, iCiORGiOFOmpukjDU, iKEZaKpuexiAdlAzh + iGyxSBHUSwVeQdHSg, iLMOrKbMFJkRUezQJ + iCiORGiOFOmpukjDU);
    }

    public static int LdgEMCdListwicbX(int i, int i2, int i3) {
        return clamp(i, i2, i3);
    }

    public static void LiXvFejByPoZZzkb(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.prepareChildren();
    }

    private int LineDelta() {
        return (int) (DVWujmJdUErHvzFc(this) * 0.2f);
    }

    public static int LkIOPrhYckJnbFxf(android.view.object view) {
        return view.getHeight();
    }

    public static bool Lpbhaahyftpcjqel(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void LqIGtMqWtWZEwqRF(android.view.objectGroup viewGroup, bool z) {
        super.requestDisallowInterceptTouchEvent(z);
    }

    public static int LuWhHHVaimKuMpuf(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetLeft();
    }

    public static int LvjhsWuuFgvHhqEH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void LxAIITPpjwYSNbgZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.resetTouchBehaviors();
    }

    public static android.view.MotionEvent LyadkyfKdCRIIrDg(long j, long j2, int i, float f, float f2, int i2) {
        return android.view.MotionEvent.obtain(j, j2, i, f, f2, i2);
    }

    public static java.lang.string MFCjGACBBhseQFAM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.content.res.TypedArray MHqyUasmnhsBbVyi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int MTwwZFWfFtGBUztI(android.view.object view) {
        return view.getHeight();
    }

    public static int MUrLUKwRBwSPzgHk(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void MXYjnlcZxsqjvWAl(android.view.objectGroup viewGroup, bool z) {
        super.setFitsSystemWindows(z);
    }

    public static android.view.MotionEvent MZTHBXCdnblzDKoM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.MotionEvent motionEvent) {
        return coordinatorLayout.obtainCancelEvent(motionEvent);
    }

    private bool ManuallyTriggersNestedScrollFromKeyEvent(android.view.object view, int i) {
        if ((15 + 13) % 13 > 0) {
        }
        XomEizefFFlyNSIe(this, this, view, 2, 1);
        dtwosfTiYohiLTvp(this, view, 0, i, this.mKeyTriggeredScrollConsumed, 1);
        int[] iArr = this.mKeyTriggeredScrollConsumed;
        int i2 = iArr[1];
        iArr[0] = 0;
        iArr[1] = 0;
        FZVGSsfsDPKETfBP(this, view, 0, i2, 0, i, 1, iArr);
        EelxUEYyzoJjTtES(this, view, 1);
        return this.mKeyTriggeredScrollConsumed[1] > 0;
    }

    public static int MfkQqtWqjDJWHzLV(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static java.lang.stringBuilder MgqiWChzBYYqgODa(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MiEXDAKIGXmebwrz(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static android.graphics.Rect MiYMNCLusGFGhEFV() {
        return acquireTempRect();
    }

    public static void MkeqYxMjayiogjAk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4) {
        coordinatorLayout.onMeasureChild(view, i, i2, i3, i4);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior mommJMvHhipoXMcr(androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior coordinatorLayout$AttachedBehavior) {
        return coordinatorLayout$AttachedBehavior.getBehavior();
    }

    private bool MoveVertically(int i) {
        return irefHRxhCYVJcMct(this, MNOFWpTznSjhqVNv(this, this), i);
    }

    public static int MubsEEfwTTwvxcav(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool NBunZAcxIfFQgZvO(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getChangedAfterNestedScroll();
    }

    public static java.lang.object NEIZMlEIwZUIwTop(java.util.List list, int i) {
        return list[i);
    }

    public static android.graphics.drawable.Drawable NFKgaoYAzRSHOCqt(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getBackground();
    }

    public static bool NIVPWamThyuQgMuf(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static bool NdiyNILHDRssYyax(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static int NgoOMjaiyeRbEXLt(int i) {
        return resolveGravity(i);
    }

    public static int NisvRvHqwwiXZvfb(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void NntccNTRbPncKUHa(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.graphics.Rect NyIQWcdqpTAUvCUj() {
        return acquireTempRect();
    }

    public static android.view.objectGroup$LayoutParams nyKjmrdCgNnGQtxW(android.view.object view) {
        return view.getLayoutParams();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams oDvQSobdIyVXuGne(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout.getResolvedLayoutParams(view);
    }

    public static int OLMSXsOigrASUPoM(android.graphics.Rect rect) {
        return rect.height();
    }

    public static int OXNSFoVUPSDQIXDR(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    private android.view.MotionEvent ObtainCancelEvent(android.view.MotionEvent motionEvent) {
        android.view.MotionEvent motionEventUMQTKVcWZtbOyTPl = uMQTKVcWZtbOyTPl(motionEvent);
        rddJAsGkPGybElvi(motionEventUMQTKVcWZtbOyTPl, 3);
        return motionEventUMQTKVcWZtbOyTPl;
    }

    private void OffsetChildByInset(android.view.object view, android.graphics.Rect rect, int i) {
        bool z;
        bool z2;
        if ((26 + 22) % 22 > 0) {
        }
        if (!VqwHROCSJEYQVxTL(view) || QlVqtpXZkJfNWjox(view) <= 0 || lkIOPrhYckJnbFxf(view) <= 0) {
            return;
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) qlNGQePRUmSCAEKP(view);
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorFYegvRzROfVnoYVS = fYegvRzROfVnoYVS(coordinatorLayout$LayoutParams);
        android.graphics.Rect rectYTAhWbPqYJqmtkPP = YTAhWbPqYJqmtkPP();
        android.graphics.Rect rectAuQTOszSOUtPHxrT = auQTOszSOUtPHxrT();
        kOXjxVPlxKUhsAQR(rectAuQTOszSOUtPHxrT, HZvqGgJGKHXnOxih(view), FtxvJpurcwkgvlWL(view), ejdsOUsbRIUkAZGz(view), eqmcOsvYprKjdssn(view));
        if (coordinatorLayout$BehaviorFYegvRzROfVnoYVS is null || !kcCiTNAfiLkMgexZ(coordinatorLayout$BehaviorFYegvRzROfVnoYVS, this, view, rectYTAhWbPqYJqmtkPP)) {
            pEfpqZrIEgRZdTOA(rectYTAhWbPqYJqmtkPP, rectAuQTOszSOUtPHxrT);
        } else if (!GrGFSwuRjDaUFzxz(rectAuQTOszSOUtPHxrT, rectYTAhWbPqYJqmtkPP)) {
            throw new java.lang.IllegalArgumentException(WhAZfILcnyvWSpiq(szAwlskLplzaZefP(cvvmoVceDSQfzxvZ(KvAzTctXzkzpKGME(new java.lang.stringBuilder("Rect should be within the child's bounds. Rect:"), ZPdlhSQwQEcNZqTm(rectYTAhWbPqYJqmtkPP)), " | Bounds:"), QxRPqQQtmHuvsXmK(rectAuQTOszSOUtPHxrT))));
        }
        EKOifrZaAFUoeHsV(rectAuQTOszSOUtPHxrT);
        if (JfHrfvhkQRNcmaBp(rectYTAhWbPqYJqmtkPP)) {
            NYlUuIGFXgWRMcDx(rectYTAhWbPqYJqmtkPP);
            return;
        }
        int iXsDzjqreRgElICfy = xsDzjqreRgElICfy(coordinatorLayout$LayoutParams.dodgeInsetEdges, i);
        bool z3 = true;
        if ((iXsDzjqreRgElICfy & 48) != 48) {
            z = false;
        } else {
            int i2 = (rectYTAhWbPqYJqmtkPP.top - coordinatorLayout$LayoutParams.topMargin) - coordinatorLayout$LayoutParams.mInsetOffsetY;
            if (i2 >= rect.top) {
                z = false;
            } else {
                iOxBlItRpdvIkZDq(this, view, rect.top - i2);
                z = true;
            }
        }
        if ((iXsDzjqreRgElICfy & 80) == 80) {
            int iOXNSFoVUPSDQIXDR = ((oXNSFoVUPSDQIXDR(this) - rectYTAhWbPqYJqmtkPP.bottom) - coordinatorLayout$LayoutParams.bottomMargin) + coordinatorLayout$LayoutParams.mInsetOffsetY;
            if (iOXNSFoVUPSDQIXDR < rect.bottom) {
                rgdNXzTLxZAyaRLW(this, view, iOXNSFoVUPSDQIXDR - rect.bottom);
                z = true;
            }
        }
        if (!z) {
            TCuaIYOPWMMdmnfF(this, view, 0);
        }
        if ((iXsDzjqreRgElICfy & 3) != 3) {
            z2 = false;
        } else {
            int i3 = (rectYTAhWbPqYJqmtkPP.left - coordinatorLayout$LayoutParams.leftMargin) - coordinatorLayout$LayoutParams.mInsetOffsetX;
            if (i3 >= rect.left) {
                z2 = false;
            } else {
                EEAtegFtOoUcQhfk(this, view, rect.left - i3);
                z2 = true;
            }
        }
        if ((iXsDzjqreRgElICfy & 5) != 5) {
            z3 = z2;
        } else {
            int iSpqZjNZcBoajWpMW = ((SpqZjNZcBoajWpMW(this) - rectYTAhWbPqYJqmtkPP.right) - coordinatorLayout$LayoutParams.rightMargin) + coordinatorLayout$LayoutParams.mInsetOffsetX;
            if (iSpqZjNZcBoajWpMW >= rect.right) {
                z3 = z2;
            } else {
                WtGYySXSYpFACsQx(this, view, iSpqZjNZcBoajWpMW - rect.right);
            }
        }
        if (!z3) {
            yCrKSaPQqGmvJSxp(this, view, 0);
        }
        EIRJfxhKrBQEGpGQ(rectYTAhWbPqYJqmtkPP);
    }

    public static java.lang.stringBuilder OpLWgagmpEYxZabZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.view.objectGroup$LayoutParams opNtjSWyDnEyjnTu(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool OrzjpmdiWvIoPTRW(android.graphics.drawable.Drawable drawable) {
        return drawable.isVisible();
    }

    public static android.view.object OtlEMcNEZKbevHRg(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void OvhXEvZreBopXFvX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.graphics.Rect rect, int i) {
        coordinatorLayout.offsetChildByInset(view, rect, i);
    }

    public static void PEfpqZrIEgRZdTOA(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static long PIMyLhWxyCJBttCq() {
        if ((29 + 2) % 2 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static int PInKtXYABPnwRhBP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static void PSGhItbRrlxjMzsp(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, android.graphics.Rect rect) {
        coordinatorLayout$LayoutParams.setLastChildRect(rect);
    }

    public static void PSYRbaYgZzvgUPwD(android.view.MotionEvent motionEvent) {
        motionEvent.recycle();
    }

    private int PageDelta() {
        return xJUvUhJEjtCczgqw(this);
    }

    public static int PamyIoyJwnzDTTbH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.pageDelta();
    }

    static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior parseBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str) {
        if ((5 + 10) % 10 > 0) {
        }
        if (tbFXtOooUWpriWLe(str)) {
            return null;
        }
        if (ZipvfOTAhllOIQgE(str, ".")) {
            str = YnhbTgsjcIBYrvzO(hjILljcQouxFwCCK(EnFzkNsRObGAnPnk(new java.lang.stringBuilder(), lZheUNcyfDFNJRDz(context)), str));
        } else if (hlSPEvUJibDnrQSv(str, 46) < 0) {
            java.lang.string str2 = WIDGET_PACKAGE_NAME;
            if (!YKfDXcnQDZcsFxzH(str2)) {
                str = LFwIgDiQrnpDJIaH(rcpWueIkBzepkOIN(ZsGftsKoplDFKxOH(HRsYnWBRwpmLLQsR(new java.lang.stringBuilder(), str2), '.'), str));
            }
        }
        try {
            java.lang.ThreadLocal<java.util.Dictionary<java.lang.string, java.lang.reflect.Constructor<androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior>>> threadLocal = sConstructors;
            java.util.Dictionary map = (java.util.Dictionary) VgXtzpbloRemDDOj(threadLocal);
            if (map is null) {
                map = new java.util.HashDictionary();
                TALRLtxRXTcXbytd(threadLocal, map);
            }
            java.lang.reflect.Constructor constructorNZuLZxQOUxNcTPna = (java.lang.reflect.Constructor) jKxhFestnfwFKUTt(map, str);
            if (constructorNZuLZxQOUxNcTPna is null) {
                constructorNZuLZxQOUxNcTPna = NZuLZxQOUxNcTPna(EwuQCPNVVXrHIieJ(str, false, gTlUbUlfdSpnWJCS(context)), CONSTRUCTOR_PARAMS);
                OMmggaetEurCRoPi(constructorNZuLZxQOUxNcTPna, true);
                YjHttjWZYCZnPZlZ(map, str, constructorNZuLZxQOUxNcTPna);
            }
            return (androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior) RoHRzUQxVtATOMNA(constructorNZuLZxQOUxNcTPna, new java.lang.object[]{context, attributeHashSet});
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(IRtriezVfioVkVLu(dDyiFttrllrYZoxm(new java.lang.stringBuilder("Could not inflate Behavior subclass "), str)), e);
        }
    }

    private bool PerformEvent(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, android.view.object view, android.view.MotionEvent motionEvent, int i) {
        if (i == 0) {
            return OnVrPqgwCXUsFFhY(coordinatorLayout$Behavior, this, view, motionEvent);
        }
        if (i != 1) {
            throw new java.lang.IllegalArgumentException();
        }
        return rgzkHHGnOmokJajB(coordinatorLayout$Behavior, this, view, motionEvent);
    }

    private bool PerformIntercept(android.view.MotionEvent motionEvent, int i) {
        if ((10 + 6) % 6 > 0) {
        }
        int iHUJKRvVKbPscSNlV = HUJKRvVKbPscSNlV(motionEvent);
        java.util.List<android.view.object> list = this.mTempList1;
        cEgavBvRLEhdhzHI(this, list);
        int iTdPGilDpoQtJehik = TdPGilDpoQtJehik(list);
        android.view.MotionEvent motionEventMIcJVgOHEPSXxihj = null;
        bool zMJmPyQxHnXdTndgZ = false;
        bool z = false;
        for (int i2 = 0; i2 < iTdPGilDpoQtJehik; i2++) {
            android.view.object view = (android.view.object) nEIZMlEIwZUIwTop(list, i2);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) xooyJoPdDtUgCJQW(view);
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorFdwtczNnvVuxrQBQ = fdwtczNnvVuxrQBQ(coordinatorLayout$LayoutParams);
            if (!(zMJmPyQxHnXdTndgZ || z) || iHUJKRvVKbPscSNlV == 0) {
                if (!z && !zMJmPyQxHnXdTndgZ && coordinatorLayout$BehaviorFdwtczNnvVuxrQBQ is not null && (zMJmPyQxHnXdTndgZ = MJmPyQxHnXdTndgZ(this, coordinatorLayout$BehaviorFdwtczNnvVuxrQBQ, view, motionEvent, i))) {
                    this.mBehaviorTouchobject = view;
                    if (iHUJKRvVKbPscSNlV != 3 && iHUJKRvVKbPscSNlV != 1) {
                        for (int i3 = 0; i3 < i2; i3++) {
                            android.view.object view2 = (android.view.object) rTMyFAIRxkRqFJip(list, i3);
                            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorKqxKWgGskVjZwOFJ = KqxKWgGskVjZwOFJ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) SRzxCkiRmbKOKRAT(view2));
                            if (coordinatorLayout$BehaviorKqxKWgGskVjZwOFJ is not null) {
                                if (motionEventMIcJVgOHEPSXxihj is null) {
                                    motionEventMIcJVgOHEPSXxihj = MIcJVgOHEPSXxihj(this, motionEvent);
                                }
                                fjoMzQroHSRohBgE(this, coordinatorLayout$BehaviorKqxKWgGskVjZwOFJ, view2, motionEventMIcJVgOHEPSXxihj, i);
                            }
                        }
                    }
                }
                bool zHXWZImhaWWquOjiR = hXWZImhaWWquOjiR(coordinatorLayout$LayoutParams);
                bool zKNWELyNVUxqlMBfo = KNWELyNVUxqlMBfo(coordinatorLayout$LayoutParams, this, view);
                z = zKNWELyNVUxqlMBfo && !zHXWZImhaWWquOjiR;
                if (zKNWELyNVUxqlMBfo && !z) {
                    break;
                }
            } else if (coordinatorLayout$BehaviorFdwtczNnvVuxrQBQ is not null) {
                if (motionEventMIcJVgOHEPSXxihj is null) {
                    motionEventMIcJVgOHEPSXxihj = mZTHBXCdnblzDKoM(this, motionEvent);
                }
                TxRfKvHfjxSxAIJE(this, coordinatorLayout$BehaviorFdwtczNnvVuxrQBQ, view, motionEventMIcJVgOHEPSXxihj, i);
            }
        }
        OEhuObNpDrGSVxmc(list);
        if (motionEventMIcJVgOHEPSXxihj is not null) {
            jheAVZcdBOsqxbts(motionEventMIcJVgOHEPSXxihj);
        }
        return zMJmPyQxHnXdTndgZ;
    }

    public static int PkDDjirYoveHvFXD(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static int PmDoRIyTRdGtkrCt(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    private void PrepareChildren() {
        if ((25 + 12) % 12 > 0) {
        }
        VXloSxbdxiWvxukT(this.mDependencySortedChildren);
        bvlQKbAVavcHiQkJ(this.mChildDag);
        int iVuaJmcmewGErOZkB = vuaJmcmewGErOZkB(this);
        for (int i = 0; i < iVuaJmcmewGErOZkB; i++) {
            android.view.object viewZXNSDuJfIjsvZJFQ = ZXNSDuJfIjsvZJFQ(this, i);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParamsODvQSobdIyVXuGne = oDvQSobdIyVXuGne(this, viewZXNSDuJfIjsvZJFQ);
            khBwOyEXvEvjWXGZ(coordinatorLayout$LayoutParamsODvQSobdIyVXuGne, this, viewZXNSDuJfIjsvZJFQ);
            UcySSBNHHWmiUQfD(this.mChildDag, viewZXNSDuJfIjsvZJFQ);
            for (int i2 = 0; i2 < iVuaJmcmewGErOZkB; i2++) {
                if (i2 != i) {
                    android.view.object viewWfKbaSSHRhrHEHrX = wfKbaSSHRhrHEHrX(this, i2);
                    if (BClrHmxbYOsfVXKM(coordinatorLayout$LayoutParamsODvQSobdIyVXuGne, this, viewZXNSDuJfIjsvZJFQ, viewWfKbaSSHRhrHEHrX)) {
                        if (!WaNvRssWEFVoIdWn(this.mChildDag, viewWfKbaSSHRhrHEHrX)) {
                            WmEeYHiQofGjTYCL(this.mChildDag, viewWfKbaSSHRhrHEHrX);
                        }
                        gBcDKoQzoIhagHHT(this.mChildDag, viewWfKbaSSHRhrHEHrX, viewZXNSDuJfIjsvZJFQ);
                    }
                }
            }
        }
        ndiyNILHDRssYyax(this.mDependencySortedChildren, eeZFIFdNGPphUPBq(this.mChildDag));
        NsofcNpWppVrpnaj(this.mDependencySortedChildren);
    }

    public static int QAOIdvsawnfNCKHN(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static int QTaszbUsPQMiUcCR(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static int QTsBqBCLqhhTrpzx(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static android.view.object QWdkgfsTFKWDPUNP(android.view.objectGroup viewGroup) {
        return viewGroup.getFocusedChild();
    }

    public static android.view.objectGroup$LayoutParams qlNGQePRUmSCAEKP(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void QpOBWNcbYtkoyTzE(android.graphics.Rect rect) {
        releaseTempRect(rect);
    }

    public static void QpRjvFKjXbqMTNvk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.setSystemUiVisibility(i);
    }

    public static void QtRwCVfcBUwkecaO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.ensurePreDrawListener();
    }

    public static int RBmgWUFKHyxnksWN(android.view.object view) {
        return view.getVisibility();
    }

    public static android.view.objectTreeObserver RFXlCiZBPNcjyvkF(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobjectTreeObserver();
    }

    public static void RFqxQrNczZPlPNmX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.layoutChild(view, i);
    }

    public static int RKRQHEArKhKRgnPC(int i) {
        return resolveAnchoredChildGravity(i);
    }

    public static int RLRMrJWVZdcGbKUF(android.view.object view) {
        return view.getBottom();
    }

    public static java.lang.object RTMyFAIRxkRqFJip(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.stringBuilder RcpWueIkBzepkOIN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RddJAsGkPGybElvi(android.view.MotionEvent motionEvent, int i) {
        motionEvent.setAction(i);
    }

    private static void ReleaseTempRect(android.graphics.Rect rect) {
        ZIRlcrPgockEZrdA(rect);
        FQoSUfHbXmjeNOhc(sRectPool, rect);
    }

    private void ResetTouchBehaviors() {
        if ((14 + 14) % 14 > 0) {
        }
        android.view.object view = this.mBehaviorTouchobject;
        if (view is not null) {
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorANQxXLNtYSJojKrG = aNQxXLNtYSJojKrG((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) uBgStkFXUyxbFoju(view));
            if (coordinatorLayout$BehaviorANQxXLNtYSJojKrG is not null) {
                long jYQViOZdGymXmReyw = yQViOZdGymXmReyw();
                android.view.MotionEvent motionEventLyadkyfKdCRIIrDg = lyadkyfKdCRIIrDg(jYQViOZdGymXmReyw, jYQViOZdGymXmReyw, 3, 0.0f, 0.0f, 0);
                NNODTGwcCcpHExGk(coordinatorLayout$BehaviorANQxXLNtYSJojKrG, this, this.mBehaviorTouchobject, motionEventLyadkyfKdCRIIrDg);
                fOauvGMQXxHGhCOx(motionEventLyadkyfKdCRIIrDg);
            }
            this.mBehaviorTouchobject = null;
        }
        int iAEprOJVuAYuexclD = aEprOJVuAYuexclD(this);
        for (int i = 0; i < iAEprOJVuAYuexclD; i++) {
            kksauBLGJmAFefEa((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) DRSAMcWiecPEQEnz(HmZTKMOdGUVpUbSn(this, i)));
        }
        this.mDisallowInterceptReset = false;
    }

    private static int ResolveAnchoredChildGravity(int i) {
        if (i != 0) {
            return i;
        }
        return 17;
    }

    private static int ResolveGravity(int i) {
        if ((i & 7) == 0) {
            i |= 8388611;
        }
        return (i & 112) != 0 ? i : i | 48;
    }

    private static int ResolveKeylineGravity(int i) {
        if (i != 0) {
            return i;
        }
        return 8388661;
    }

    public static void RgdNXzTLxZAyaRLW(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetY(view, i);
    }

    public static bool RgzkHHGnOmokJajB(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.MotionEvent motionEvent) {
        return coordinatorLayout$Behavior.onTouchEvent(coordinatorLayout, view, motionEvent);
    }

    public static android.view.object RjhDmEGglPqmKDUu(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static int RqKjDocKwuXlgykV(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getFullContentHeight();
    }

    public static int RsWtWkYmnePgZWnv(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void RvHWgUDJTDyleYBY(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.append(i, obj);
    }

    public static void RyVdAmwLoctvNDSK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.setupForInsets();
    }

    public static java.lang.stringBuilder SApqXhnNVZdjPOYq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.view.objectGroup$LayoutParams sIjTiBvDAQhexOhQ(android.view.object view) {
        return view.getLayoutParams();
    }

    public static float SJkDcrwGegrvAaNv(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$Behavior.getScrimOpacity(coordinatorLayout, view);
    }

    public static void SQwqsbVDmyxeQzpo(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.graphics.drawable.Drawable drawable) {
        coordinatorLayout.setStatusBarBackground(drawable);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior sdbfFvumcEcyUhOh(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    private void SetInsetOffsetX(android.view.object view, int i) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) LPivhzTYOvbhTeMk(view);
        if (coordinatorLayout$LayoutParams.mInsetOffsetX == i) {
            return;
        }
        iKLNxHkcgwFKZkAS(view, i - coordinatorLayout$LayoutParams.mInsetOffsetX);
        coordinatorLayout$LayoutParams.mInsetOffsetX = i;
    }

    private void SetInsetOffsetY(android.view.object view, int i) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) epSAZHzJRVMSHpfn(view);
        if (coordinatorLayout$LayoutParams.mInsetOffsetY == i) {
            return;
        }
        EXHVWXSZLaMeWJwK(view, i - coordinatorLayout$LayoutParams.mInsetOffsetY);
        coordinatorLayout$LayoutParams.mInsetOffsetY = i;
    }

    private void SetupForInsets() {
        if (!LHQVeHCXSUcQbeRE(this)) {
            sikjaVTKNNEBKyoO(this, null);
            return;
        }
        if (this.mApplyWindowInsetsListener is null) {
            this.mApplyWindowInsetsListener = new androidx.coordinatorlayout.widget.CoordinatorLayout$1(this);
        }
        TEKLEvlzHDthMhoi(this, this.mApplyWindowInsetsListener);
        qpRjvFKjXbqMTNvk(this, 1280);
    }

    public static bool SgFDBQXacbSRlxFP(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.moveVertically(i);
    }

    public static void SikjaVTKNNEBKyoO(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static bool SqPqRLhlHpuxoCxQ(android.view.objectGroup viewGroup, android.graphics.Canvas canvas, android.view.object view, long j) {
        return super.drawChild(canvas, view, j);
    }

    public static java.lang.stringBuilder SzAwlskLplzaZefP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TDAmedOppKzjafko(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i) {
        return coordinatorLayout$LayoutParams.isNestedScrollAccepted(i);
    }

    public static int TFPUageyZoqnFYPi(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static void TLCLbGKKoloXiAQg(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, bool z) {
        coordinatorLayout$LayoutParams.setChangedAfterNestedScroll(z);
    }

    public static void TMVbwuVDHaPvGkdc(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.addPreDrawListener();
    }

    public static bool TNWMCjbHwRIrENXa(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static java.lang.annotation.Annotation TQropImfwkYLTbBc(java.lang.Class cls, java.lang.Class cls2) {
        return cls.getAnnotation(cls2);
    }

    public static void TXOHxYsxscblkmIh(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, int i, bool z) {
        coordinatorLayout$LayoutParams.setNestedScrollAccepted(i, z);
    }

    public static android.graphics.Rect TZORCFAAvVXqlwPM() {
        return acquireTempRect();
    }

    public static bool TbFXtOooUWpriWLe(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.objectGroup$LayoutParams tbkTCtVSLvojqLIn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static android.content.res.Resources ThMEDBLteFBwCvGd(android.content.object context) {
        return context.getResources();
    }

    public static int TjcKrEfPEKRckUXs(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getLayoutDirection();
    }

    public static void TjqJNSjiomXmqLJe(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z) {
        coordinatorLayout.setWillNotDraw(z);
    }

    public static int TuBNZYIYBScTIXGx(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior txgZOtFqXyxCNUyK(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static bool TzWFPEyqrQcuocYm(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        return coordinatorLayout$Behavior.onDependentobjectChanged(coordinatorLayout, view, view2);
    }

    public static android.view.objectGroup$LayoutParams uBgStkFXUyxbFoju(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int UHoWFABmGehZdgrh(android.view.KeyEvent keyEvent) {
        return keyEvent.getKeyCode();
    }

    public static void ULOyARWufhgLCOZU(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static android.view.MotionEvent UMQTKVcWZtbOyTPl(android.view.MotionEvent motionEvent) {
        return android.view.MotionEvent.obtain(motionEvent);
    }

    public static bool UQRDNflwiDybuSNS(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4) {
        return coordinatorLayout$Behavior.onMeasureChild(coordinatorLayout, view, i, i2, i3, i4);
    }

    public static java.util.List UdBjTmJncVJCheYq(java.util.List list) {
        return java.util.ICollections.unmodifiableList(list);
    }

    public static int UdjlExEjZWuQVxRn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static int UemFMDwGvrusMDCp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void UgrrcIhDmKtJKLEN(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetLeftAndRight(view, i);
    }

    public static int UhfAPMPMKQyCHVHE(int i) {
        return resolveGravity(i);
    }

    public static void UpLjsxOuoYAtuBRz(int i, int i2, int i3, android.graphics.Rect rect, android.graphics.Rect rect2, int i4) {
        androidx.core.view.GravityCompat.apply(i, i2, i3, rect, rect2, i4);
    }

    public static int UqPOEeMbEDFucdpE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool UqiZYqvpmjDUTzSZ(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.isConsumed();
    }

    public static int UvMgLEOBFOpcakwh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static bool VIQCYRbGMYJuXSyj(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2) {
        return coordinatorLayout$Behavior.onNestedPreFling(coordinatorLayout, view, view2, f, f2);
    }

    public static android.graphics.drawable.Drawable VKiJDOggblwONRyE(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static bool VSfduBimfAmLRHmQ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.MotionEvent motionEvent, int i) {
        return coordinatorLayout.performIntercept(motionEvent, i);
    }

    public static int VVGtOZcEyUHKxsuT(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void VVZxqtxyeSeOqsdI(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        coordinatorLayout.postInvalidateOnAnimation();
    }

    public static android.view.objectGroup$LayoutParams vpxoJltXImJPmabN(android.view.object view) {
        return view.getLayoutParams();
    }

    public static int VqWJNKZLeQKNHgZB(android.view.object view) {
        return view.getVisibility();
    }

    public static int VuaJmcmewGErOZkB(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void VvnKFioKRpronAAT(android.view.objectGroup viewGroup, int i) {
        super.setVisibility(i);
    }

    public static bool VwjRHZKfSWpCtyKt(android.view.objectGroup viewGroup, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static void WAElLuDujDJWGnFo(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, android.graphics.Rect rect) {
        coordinatorLayout.getChildRect(view, z, rect);
    }

    public static bool WIZoEsLJECvNknho(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int WTMSjTqaoqcSFNhp(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static android.graphics.Rect WYBwayVugLzftGxK() {
        return acquireTempRect();
    }

    public static android.graphics.drawable.Drawable WcWbUSTcCQjWfxax(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static android.view.object WfKbaSSHRhrHEHrX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static android.view.objectGroup$LayoutParams wifddcwnckBzkMNr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void WrJtjduRYflcLpyL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.offsetChildToAnchor(view, i);
    }

    public static int WrSsksUfBjZPFEDQ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static int[] WzqrcjqlpPsIuFCa(android.content.res.Resources resources, int i) {
        return resources.getIntArray(i);
    }

    public static int XFsRorXwBEPNXuyh(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int XJUvUhJEjtCczgqw(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static android.view.objectGroup$LayoutParams xSbyJTfEMHlHJJci(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool XcqnbkFmDamEvruq(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void XiIqEJkPTMTPCXoW(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnPreDrawListener viewTreeObserver$OnPreDrawListener) {
        viewTreeObserver.addOnPreDrawListener(viewTreeObserver$OnPreDrawListener);
    }

    public static bool XlJOcRxJWlGqqiXx(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect, bool z) {
        return super.requestChildRectangleOnScreen(view, rect, z);
    }

    public static void XoFNfYuzYJyXpgcM(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        coordinatorLayout$LayoutParams.setBehavior(coordinatorLayout$Behavior);
    }

    public static android.view.objectGroup$LayoutParams xooyJoPdDtUgCJQW(android.view.object view) {
        return view.getLayoutParams();
    }

    public static java.lang.stringBuilder XpabtKUwzvUTYBPj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XsDzjqreRgElICfy(int i, int i2) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(i, i2);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior xwWopSYiewuVnGyo(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void YCrKSaPQqGmvJSxp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.setInsetOffsetX(view, i);
    }

    public static int YGnqSJxgWepJsGla(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getSuggestedMinimumWidth();
    }

    public static int YOBYsGKvszShvnwh(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static void YQQmkeZlGwbQVlww(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i) {
        coordinatorLayout$Behavior.onStopNestedScroll(coordinatorLayout, view, view2, i);
    }

    public static long YQViOZdGymXmReyw() {
        if ((20 + 16) % 16 > 0) {
        }
        return android.os.SystemClock.uptimeMillis();
    }

    public static bool YSOSYVoHSCaPmdHg(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static int YZPEDNYUbRCAntpD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static void YctPADuJgNugUWIL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int[] iArr, int i3) {
        coordinatorLayout.onNestedPreScroll(view, i, i2, iArr, i3);
    }

    public static int YkBNpddcAuBSupHk(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void YoQNKfIcNOeaBiDC(android.graphics.Rect rect) {
        rect.setEmpty();
    }

    public static int YqUprnpMmczuzszJ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static bool YqyUtIYYckGqXexy(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static android.view.object YutSFVsvxAQRUPwK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior yyNURQMavTQOHHxo(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void ZGCYdQcJNkitrReZ(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.graphics.drawable.Drawable drawable) {
        coordinatorLayout.setStatusBarBackground(drawable);
    }

    public static int[] ZWWfyzJkUoMhlqZf(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getDrawableState();
    }

    public static void ZconLuRxczZYMOiR(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static bool ZiFdfrROINxYvxsa(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, android.view.object view3, int i, int i2) {
        return coordinatorLayout$Behavior.onStartNestedScroll(coordinatorLayout, view, view2, view3, i, i2);
    }

    public static int[] ZxrwWTTLsmYJwIuG(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getDrawableState();
    }

    void addPreDrawListener() {
        if ((3 + 14) % 14 > 0) {
        }
        if (this.mIsAttachedToWindow) {
            if (this.mOnPreDrawListener is null) {
                this.mOnPreDrawListener = new androidx.coordinatorlayout.widget.CoordinatorLayout$OnPreDrawListener(this);
            }
            BwGcvtyZjAuwARRB(UCDOXngwKMpfUKdV(this), this.mOnPreDrawListener);
        }
        this.mNeedsPreDrawListener = true;
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return (viewGroup$LayoutParams is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) && lMYoSdSGnLhmBdAI(this, viewGroup$LayoutParams);
    }

    public void DispatchDependentobjectsChanged(android.view.object view) {
        if ((28 + 24) % 24 > 0) {
        }
        java.util.List arrayListGyOrybHQcSINSvGV = gyOrybHQcSINSvGV(this.mChildDag, view);
        if (arrayListGyOrybHQcSINSvGV is null || XCVbATAfGaPHypvL(arrayListGyOrybHQcSINSvGV)) {
            return;
        }
        for (int i = 0; i < kIIeDCZaVIiXHuub(arrayListGyOrybHQcSINSvGV); i++) {
            android.view.object view2 = (android.view.object) CmwBosNBpaJVRBjz(arrayListGyOrybHQcSINSvGV, i);
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorSdbfFvumcEcyUhOh = sdbfFvumcEcyUhOh((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) TYtVFxfRkhtRGQvC(view2));
            if (coordinatorLayout$BehaviorSdbfFvumcEcyUhOh is not null) {
                AXQbdKTeLgKXMjjP(coordinatorLayout$BehaviorSdbfFvumcEcyUhOh, this, view2, view);
            }
        }
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        if ((21 + 21) % 21 > 0) {
        }
        bool zHHKySAVcBxbBbwAq = hHKySAVcBxbBbwAq(this, keyEvent);
        if (!zHHKySAVcBxbBbwAq && dHOkoddpPDXWvLaB(keyEvent) == 0) {
            int iUHoWFABmGehZdgrh = uHoWFABmGehZdgrh(keyEvent);
            if (iUHoWFABmGehZdgrh == 19) {
                return !VHdfSJvMwGxHhWYz(keyEvent) ? VxBBXGMZavwHxlTi(this, -UFIRLTqeCewZwrif(this)) : KMAcqqOWBKTfNQAb(this, -cHKdLQiqchoUfYBB(this));
            }
            if (iUHoWFABmGehZdgrh == 20) {
                return !ZdDDDgFPZCuTmsQv(keyEvent) ? GbATFuCCWMAPxARP(this, hyuVDNWwpAkjIVbE(this)) : erbWJMzvLjztHAyo(this, gPmdwEhdorgMHuyp(this));
            }
            if (iUHoWFABmGehZdgrh == 62) {
                return !BBOsYvjqrmmpAhnS(keyEvent) ? sgFDBQXacbSRlxFP(this, euxOVmJhLgLRASFV(this)) : ItihPwskxAObMmLb(this, LOjUSMMusbwUsyna(this));
            }
            if (iUHoWFABmGehZdgrh == 92) {
                return KwUuOOlJtIDjpZWZ(this, -XRikPSqlHcXnZldC(this));
            }
            if (iUHoWFABmGehZdgrh == 93) {
                return BfJKCbXAuekXdozh(this, pamyIoyJwnzDTTbH(this));
            }
            if (iUHoWFABmGehZdgrh == 122) {
                return dLUyMrCXTONXQeiN(this, ekByhuJTTxDykyAs(this));
            }
            if (iUHoWFABmGehZdgrh == 123) {
                return JDkLJknpzLeDaAgh(this, QrCpuTEzfupsAFHI(this));
            }
        }
        return zHHKySAVcBxbBbwAq;
    }

    public bool DoobjectsOverlap(android.view.object view, android.view.object view2) {
        if ((6 + 2) % 2 > 0) {
        }
        bool z = false;
        if (HIIUfQTGsgonKEuu(view) != 0 || ZThwzSvUlTwXDMeC(view2) != 0) {
            return false;
        }
        android.graphics.Rect rectERrhpwdUQaUXGQpF = ERrhpwdUQaUXGQpF();
        wAElLuDujDJWGnFo(this, view, DIfprESOmfJLbXLM(view) != this, rectERrhpwdUQaUXGQpF);
        android.graphics.Rect rectTZORCFAAvVXqlwPM = tZORCFAAvVXqlwPM();
        PxkDbptcRIjiXtMc(this, view2, KKAUDZQFCwImWVex(view2) != this, rectTZORCFAAvVXqlwPM);
        try {
            if (rectERrhpwdUQaUXGQpF.left <= rectTZORCFAAvVXqlwPM.right && rectERrhpwdUQaUXGQpF.top <= rectTZORCFAAvVXqlwPM.bottom && rectERrhpwdUQaUXGQpF.right >= rectTZORCFAAvVXqlwPM.left && rectERrhpwdUQaUXGQpF.bottom >= rectTZORCFAAvVXqlwPM.top) {
                z = true;
            }
            aVxhWTtmwyBjEECN(rectERrhpwdUQaUXGQpF);
            bntEOQuVOJpsMzUS(rectTZORCFAAvVXqlwPM);
            return z;
        } catch (java.lang.Exception th) {
            gvrJWvliQWhGexSq(rectERrhpwdUQaUXGQpF);
            dQVXILcIWtdAZdGf(rectTZORCFAAvVXqlwPM);
            throw th;
        }
    }

    protected override bool DrawChild(android.graphics.Canvas canvas, android.view.object view, long j) {
        if ((6 + 24) % 24 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) xSbyJTfEMHlHJJci(view);
        if (coordinatorLayout$LayoutParams.mBehavior is not null) {
            float fSJkDcrwGegrvAaNv = sJkDcrwGegrvAaNv(coordinatorLayout$LayoutParams.mBehavior, this, view);
            if (fSJkDcrwGegrvAaNv > 0.0f) {
                if (this.mScrimPaint is null) {
                    this.mScrimPaint = new android.graphics.Paint();
                }
                NuEbEtfByIwXQKva(this.mScrimPaint, HWcODtScLOwizoMK(coordinatorLayout$LayoutParams.mBehavior, this, view));
                JKKojOKwuYKSElyG(this.mScrimPaint, ldgEMCdListwicbX(EGaSRHoSvpzOQVsR(fSJkDcrwGegrvAaNv * 255.0f), 0, 255));
                int iBcOSRxkJqqDszOzX = bcOSRxkJqqDszOzX(canvas);
                if (CecSDWEbuPuCYaCR(view)) {
                    BQbFAeAzbjeJQnqb(canvas, HFIasyexoejmcJzg(view), aBnskVMiRzzARswH(view), cldQHzoYpbbEscko(view), rLRMrJWVZdcGbKUF(view), android.graphics.Region$Op.DIFFERENCE);
                }
                fJlhgSGuPgqLhFXY(canvas, LlgSefiTinOKdPfS(this), BxKeUjpCBAJMhmQj(this), lvjhsWuuFgvHhqEH(this) - uvMgLEOBFOpcakwh(this), KcWUpzFSCcgQucDG(this) - yqUprnpMmczuzszJ(this), this.mScrimPaint);
                OWsjCCcPJeYaFJli(canvas, iBcOSRxkJqqDszOzX);
            }
        }
        return sqPqRLhlHpuxoCxQ(this, canvas, view, j);
    }

    protected override void DrawableStateChanged() {
        if ((15 + 11) % 11 > 0) {
        }
        LbadJmwQeTggtfcc(this);
        int[] iArrZxrwWTTLsmYJwIuG = zxrwWTTLsmYJwIuG(this);
        android.graphics.drawable.Drawable drawable = this.mStatusBarBackground;
        if ((drawable is not null && ySOSYVoHSCaPmdHg(drawable)) ? tNWMCjbHwRIrENXa(drawable, iArrZxrwWTTLsmYJwIuG) : false) {
            XMHUiEOltoRECBKO(this);
        }
    }

    void ensurePreDrawListener() {
        if ((16 + 32) % 32 > 0) {
        }
        int iYTGRFoEkUBdbHFFC = YTGRFoEkUBdbHFFC(this);
        bool z = false;
        for (int i = 0; i < iYTGRFoEkUBdbHFFC; i++) {
            if (PMZsHBcgGCPvjfuZ(this, yutSFVsvxAQRUPwK(this, i))) {
                z = true;
                break;
            }
        }
        if (z == this.mNeedsPreDrawListener) {
            return;
        }
        if (z) {
            tMVbwuVDHaPvGkdc(this);
        } else {
            EDVIwVkKSdFIVBYS(this);
        }
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return BERRRbqQsuWYUxOK(this);
    }

    protected androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams generateDefaultLayoutParams() {
        return new androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams(-2, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return WLIKpuXJwzbYxtEy(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return AoXBiVQWVkGosWxi(this, viewGroup$LayoutParams);
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams(FSocNCqgCkppkndy(this), attributeHashSet);
    }

    protected androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams(viewGroup$LayoutParams) : new androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParams);
    }

    void getChildRect(android.view.object view, bool z, android.graphics.Rect rect) {
        if ((19 + 30) % 30 > 0) {
        }
        if (GzbsiEAIygbruUlC(view) || CwTrcpErdvCimSoK(view) == 8) {
            yoQNKfIcNOeaBiDC(rect);
        } else if (z) {
            VHnsAKHaMZbdlDId(this, view, rect);
        } else {
            bIkOiwFZwyYENOdK(rect, OQgxHAcZdfAIZuog(view), dLOUTiASbHvwvZQb(view), epHHqjbObRaBfehQ(view), BBpAHadKCzoZgCIz(view));
        }
    }

    public override java.util.List<android.view.object> GetDependencies(android.view.object view) {
        java.util.List<android.view.object> listBzDdPyWzIcVUuJkO = bzDdPyWzIcVUuJkO(this.mChildDag, view);
        return listBzDdPyWzIcVUuJkO is not null ? listBzDdPyWzIcVUuJkO : kOyuoalHvAeRGFoR();
    }

    readonly java.util.List<android.view.object> getDependencySortedChildren() {
        bjiPXeRUvHNScjSV(this);
        return udBjTmJncVJCheYq(this.mDependencySortedChildren);
    }

    public java.util.List<android.view.object> GetDependents(android.view.object view) {
        java.util.List<android.view.object> listHyFptEzBPMMFApED = hyFptEzBPMMFApED(this.mChildDag, view);
        return listHyFptEzBPMMFApED is not null ? listHyFptEzBPMMFApED : JGqCtMkhCzzWKGJH();
    }

    void getDescendantRect(android.view.object view, android.graphics.Rect rect) {
        ESPuGefRLBoMibrp(this, view, rect);
    }

    void getDesiredAnchoredChildRect(android.view.object view, int i, android.graphics.Rect rect, android.graphics.Rect rect2) {
        if ((4 + 7) % 7 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) wifddcwnckBzkMNr(view);
        int iDZioVIRfTFZwvpnX = dZioVIRfTFZwvpnX(view);
        int iDNvxjPEHpvQuSEJK = DNvxjPEHpvQuSEJK(view);
        YmAYzDVOZyQYqpoM(this, i, rect, rect2, coordinatorLayout$LayoutParams, iDZioVIRfTFZwvpnX, iDNvxjPEHpvQuSEJK);
        MMqNEXmUoJinpPbH(this, coordinatorLayout$LayoutParams, rect2, iDZioVIRfTFZwvpnX, iDNvxjPEHpvQuSEJK);
    }

    void getLastChildRect(android.view.object view, android.graphics.Rect rect) {
        gtjEsSnYmddwpJDc(rect, DvfcWvapkxRMbAHB((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) vpxoJltXImJPmabN(view)));
    }

    public readonly androidx.core.view.WindowInsetsCompat GetLastWindowInsets() {
        return this.mLastInsets;
    }

    public override int GetNestedScrollAxes() {
        return YpmAZLotfinHVVst(this.mNestedScrollingParentHelper);
    }

    androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams getResolvedLayoutParams(android.view.object view) {
        if ((29 + 4) % 4 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) bHizFMgFZDfigvos(view);
        if (!coordinatorLayout$LayoutParams.mBehaviorResolved) {
            if (view is androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorMommJMvHhipoXMcr = mommJMvHhipoXMcr((androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior) view);
                if (coordinatorLayout$BehaviorMommJMvHhipoXMcr is null) {
                    byMwmwPKLtMbBbQu("CoordinatorLayout", "Attached behavior class is null");
                }
                xoFNfYuzYJyXpgcM(coordinatorLayout$LayoutParams, coordinatorLayout$BehaviorMommJMvHhipoXMcr);
                coordinatorLayout$LayoutParams.mBehaviorResolved = true;
                return coordinatorLayout$LayoutParams;
            }
            androidx.coordinatorlayout.widget.CoordinatorLayout$DefaultBehavior coordinatorLayout$DefaultBehavior = null;
            for (java.lang.Class clsOSiPAKLNtDjRGaWk = OSiPAKLNtDjRGaWk(view); clsOSiPAKLNtDjRGaWk is not null; clsOSiPAKLNtDjRGaWk = INNADUXkOYSlpzSA(clsOSiPAKLNtDjRGaWk)) {
                coordinatorLayout$DefaultBehavior = (androidx.coordinatorlayout.widget.CoordinatorLayout$DefaultBehavior) tQropImfwkYLTbBc(clsOSiPAKLNtDjRGaWk, androidx.coordinatorlayout.widget.CoordinatorLayout$DefaultBehavior.class);
                if (coordinatorLayout$DefaultBehavior is not null) {
                    break;
                }
            }
            if (coordinatorLayout$DefaultBehavior is not null) {
                try {
                    UqfBGxOjDyGnZFdn(coordinatorLayout$LayoutParams, (androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior) SmHyHBkMcipDnqbq(HAKIdreRsmUhKWlM(WwQbJQuroUOmZcEz(coordinatorLayout$DefaultBehavior), new java.lang.Class[0]), new java.lang.object[0]));
                } catch (java.lang.Exception e) {
                    jEbNSFllEkuZzhRc("CoordinatorLayout", KEtJNXufKSyHJdxk(sApqXhnNVZdjPOYq(xpabtKUwzvUTYBPj(new java.lang.stringBuilder("Default behavior class "), hRgPdVEXRuxQhowh(GeEiJRhWWldYYcan(coordinatorLayout$DefaultBehavior))), " could not be instantiated. Did you forget a default constructor?")), e);
                }
            }
            coordinatorLayout$LayoutParams.mBehaviorResolved = true;
        }
        return coordinatorLayout$LayoutParams;
    }

    public android.graphics.drawable.Drawable GetStatusBarBackground() {
        return this.mStatusBarBackground;
    }

    protected override int GetSuggestedMinimumHeight() {
        if ((22 + 8) % 8 > 0) {
        }
        return uqPOEeMbEDFucdpE(OSoIRBcwAixOJEck(this), HyLTDvvZVhKLrkml(this) + hQaBIWDYGHjnZXej(this));
    }

    protected override int GetSuggestedMinimumWidth() {
        if ((10 + 6) % 6 > 0) {
        }
        return xFsRorXwBEPNXuyh(TNuvQyXhfUCaQCrO(this), aeOjqTwxkyfOURcl(this) + CJpwuVaHZEwmOfjE(this));
    }

    public bool IsPointInChildBounds(android.view.object view, int i, int i2) {
        android.graphics.Rect rectWYBwayVugLzftGxK = wYBwayVugLzftGxK();
        UyGPibqtHSlfwDDk(this, view, rectWYBwayVugLzftGxK);
        try {
            bool zAdsDVwvXhMpCAZTN = AdsDVwvXhMpCAZTN(rectWYBwayVugLzftGxK, i, i2);
            DrjQTNQydaZwSyDK(rectWYBwayVugLzftGxK);
            return zAdsDVwvXhMpCAZTN;
        } catch (java.lang.Exception th) {
            QWVtIXYyxQUlVEQz(rectWYBwayVugLzftGxK);
            throw th;
        }
    }

    void offsetChildToAnchor(android.view.object view, int i) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorTxgZOtFqXyxCNUyK;
        if ((15 + 16) % 16 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) QfxFjKdOMRVqnnuf(view);
        if (coordinatorLayout$LayoutParams.mAnchorobject is null) {
            return;
        }
        android.graphics.Rect rectKyCTwPwhBnjXoXzE = KyCTwPwhBnjXoXzE();
        android.graphics.Rect rectIYiyhZTaVAmEgtlR = iYiyhZTaVAmEgtlR();
        android.graphics.Rect rectMiYMNCLusGFGhEFV = miYMNCLusGFGhEFV();
        BGYdcYzATeJEtYwJ(this, coordinatorLayout$LayoutParams.mAnchorobject, rectKyCTwPwhBnjXoXzE);
        jKOICfZecbRxyGWf(this, view, false, rectIYiyhZTaVAmEgtlR);
        int iNWsuBvqLBYkovZlQ = NWsuBvqLBYkovZlQ(view);
        int iTuBNZYIYBScTIXGx = tuBNZYIYBScTIXGx(view);
        JnNGWrRudiOpfkGb(this, i, rectKyCTwPwhBnjXoXzE, rectMiYMNCLusGFGhEFV, coordinatorLayout$LayoutParams, iNWsuBvqLBYkovZlQ, iTuBNZYIYBScTIXGx);
        bool z = (rectMiYMNCLusGFGhEFV.left == rectIYiyhZTaVAmEgtlR.left && rectMiYMNCLusGFGhEFV.top == rectIYiyhZTaVAmEgtlR.top) ? false : true;
        SUcGCiBdnqGJBEbc(this, coordinatorLayout$LayoutParams, rectMiYMNCLusGFGhEFV, iNWsuBvqLBYkovZlQ, iTuBNZYIYBScTIXGx);
        int i2 = rectMiYMNCLusGFGhEFV.left - rectIYiyhZTaVAmEgtlR.left;
        int i3 = rectMiYMNCLusGFGhEFV.top - rectIYiyhZTaVAmEgtlR.top;
        if (i2 != 0) {
            ugrrcIhDmKtJKLEN(view, i2);
        }
        if (i3 != 0) {
            zconLuRxczZYMOiR(view, i3);
        }
        if (z && (coordinatorLayout$BehaviorTxgZOtFqXyxCNUyK = txgZOtFqXyxCNUyK(coordinatorLayout$LayoutParams)) is not null) {
            tzWFPEyqrQcuocYm(coordinatorLayout$BehaviorTxgZOtFqXyxCNUyK, this, view, coordinatorLayout$LayoutParams.mAnchorobject);
        }
        hBQdBSbXBJLZYaGk(rectKyCTwPwhBnjXoXzE);
        fqfANGzBAoxHchXu(rectIYiyhZTaVAmEgtlR);
        AJGKTvLtPHTxsNLN(rectMiYMNCLusGFGhEFV);
    }

    public override void OnAttachedToWindow() {
        if ((18 + 2) % 2 > 0) {
        }
        GYcUValyzTqTWJla(this);
        PNeVapqaaOSLbptU(this);
        if (this.mNeedsPreDrawListener) {
            if (this.mOnPreDrawListener is null) {
                this.mOnPreDrawListener = new androidx.coordinatorlayout.widget.CoordinatorLayout$OnPreDrawListener(this);
            }
            xiIqEJkPTMTPCXoW(rFXlCiZBPNcjyvkF(this), this.mOnPreDrawListener);
        }
        if (this.mLastInsets is null && wIZoEsLJECvNknho(this)) {
            uLOyARWufhgLCOZU(this);
        }
        this.mIsAttachedToWindow = true;
    }

    readonly void onChildobjectsChanged(int i) {
        int i2;
        android.view.object view;
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams;
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorYySdKkwzPBTyBlgg;
        bool zYIAvCSklTQVyEByx;
        if ((19 + 15) % 15 > 0) {
        }
        int iJBirrLefyuqdmTSJ = JBirrLefyuqdmTSJ(this);
        int iEywKpujoIkSlnvwH = eywKpujoIkSlnvwH(this.mDependencySortedChildren);
        android.graphics.Rect rectMxKHkPCsHkWjiJZs = MxKHkPCsHkWjiJZs();
        android.graphics.Rect rectMvvRDhaZqMjnSVSJ = MvvRDhaZqMjnSVSJ();
        android.graphics.Rect rectCAyzNQyxzeCUZMVq = cAyzNQyxzeCUZMVq();
        for (int i3 = 0; i3 < iEywKpujoIkSlnvwH; i3++) {
            android.view.object view2 = (android.view.object) ajGJzloLwGjCQcEp(this.mDependencySortedChildren, i3);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams2 = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) nyKjmrdCgNnGQtxW(view2);
            if (i != 0 || rBmgWUFKHyxnksWN(view2) != 8) {
                for (int i4 = 0; i4 < i3; i4++) {
                    if (coordinatorLayout$LayoutParams2.mAnchorDirectChild == ((android.view.object) RiTNWLBCWZsGIedQ(this.mDependencySortedChildren, i4))) {
                        wrJtjduRYflcLpyL(this, view2, iJBirrLefyuqdmTSJ);
                    }
                }
                OWQJQQoqISdWPzku(this, view2, true, rectMvvRDhaZqMjnSVSJ);
                if (coordinatorLayout$LayoutParams2.insetEdge != 0 && !eZJwunvHLxcbFdoq(rectMvvRDhaZqMjnSVSJ)) {
                    int iKUIFbbCgeaWednmO = KUIFbbCgeaWednmO(coordinatorLayout$LayoutParams2.insetEdge, iJBirrLefyuqdmTSJ);
                    int i5 = iKUIFbbCgeaWednmO & 112;
                    if (i5 == 48) {
                        rectMxKHkPCsHkWjiJZs.top = dukkUNLbPoBtuYZt(rectMxKHkPCsHkWjiJZs.top, rectMvvRDhaZqMjnSVSJ.bottom);
                    } else if (i5 == 80) {
                        rectMxKHkPCsHkWjiJZs.bottom = VERzPEltJpOeroAV(rectMxKHkPCsHkWjiJZs.bottom, lSINtecxiGgakhVh(this) - rectMvvRDhaZqMjnSVSJ.top);
                    }
                    int i6 = iKUIFbbCgeaWednmO & 7;
                    if (i6 == 3) {
                        rectMxKHkPCsHkWjiJZs.left = dhdAIiiUiaBpgjPJ(rectMxKHkPCsHkWjiJZs.left, rectMvvRDhaZqMjnSVSJ.right);
                    } else if (i6 == 5) {
                        rectMxKHkPCsHkWjiJZs.right = eXhTbYLAZVKDplUy(rectMxKHkPCsHkWjiJZs.right, UxyYAjaYitkzGRfE(this) - rectMvvRDhaZqMjnSVSJ.left);
                    }
                }
                if (coordinatorLayout$LayoutParams2.dodgeInsetEdges != 0 && vqWJNKZLeQKNHgZB(view2) == 0) {
                    ovhXEvZreBopXFvX(this, view2, rectMxKHkPCsHkWjiJZs, iJBirrLefyuqdmTSJ);
                }
                if (i == 2) {
                    for (i2 = i3 + 1; i2 < iEywKpujoIkSlnvwH; i2++) {
                        view = (android.view.object) fozcNHaOLgUaBBGR(this.mDependencySortedChildren, i2);
                        coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) kELguzSuMeJcOzSX(view);
                        coordinatorLayout$BehaviorYySdKkwzPBTyBlgg = YySdKkwzPBTyBlgg(coordinatorLayout$LayoutParams);
                        if (coordinatorLayout$BehaviorYySdKkwzPBTyBlgg is not null && DGyzrvPIYrJEMdZY(coordinatorLayout$BehaviorYySdKkwzPBTyBlgg, this, view, view2)) {
                            if (i != 0 && nBunZAcxIfFQgZvO(coordinatorLayout$LayoutParams)) {
                                DKYuMPOMJZlMPUGU(coordinatorLayout$LayoutParams);
                            } else {
                                if (i == 2) {
                                    NkUDwVbqexVNWSLt(coordinatorLayout$BehaviorYySdKkwzPBTyBlgg, this, view, view2);
                                    zYIAvCSklTQVyEByx = true;
                                } else {
                                    zYIAvCSklTQVyEByx = YIAvCSklTQVyEByx(coordinatorLayout$BehaviorYySdKkwzPBTyBlgg, this, view, view2);
                                }
                                if (i != 1) {
                                    tLCLbGKKoloXiAQg(coordinatorLayout$LayoutParams, zYIAvCSklTQVyEByx);
                                }
                            }
                        }
                    }
                } else {
                    MxzdnNXMZmCqqBdr(this, view2, rectCAyzNQyxzeCUZMVq);
                    if (!hxjYHrhlugQCTese(rectCAyzNQyxzeCUZMVq, rectMvvRDhaZqMjnSVSJ)) {
                        iVpyEIDixhRULlIk(this, view2, rectMvvRDhaZqMjnSVSJ);
                        while (i2 < iEywKpujoIkSlnvwH) {
                            view = (android.view.object) fozcNHaOLgUaBBGR(this.mDependencySortedChildren, i2);
                            coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) kELguzSuMeJcOzSX(view);
                            coordinatorLayout$BehaviorYySdKkwzPBTyBlgg = YySdKkwzPBTyBlgg(coordinatorLayout$LayoutParams);
                            if (coordinatorLayout$BehaviorYySdKkwzPBTyBlgg is not null) {
                                if (i != 0) {
                                    if (i == 2) {
                                        NkUDwVbqexVNWSLt(coordinatorLayout$BehaviorYySdKkwzPBTyBlgg, this, view, view2);
                                        zYIAvCSklTQVyEByx = true;
                                    } else {
                                        zYIAvCSklTQVyEByx = YIAvCSklTQVyEByx(coordinatorLayout$BehaviorYySdKkwzPBTyBlgg, this, view, view2);
                                    }
                                    if (i != 1) {
                                        tLCLbGKKoloXiAQg(coordinatorLayout$LayoutParams, zYIAvCSklTQVyEByx);
                                    }
                                } else {
                                    DKYuMPOMJZlMPUGU(coordinatorLayout$LayoutParams);
                                }
                            }
                        }
                    }
                }
            }
        }
        iWBdhMuEvLDQepTJ(rectMxKHkPCsHkWjiJZs);
        dVqCMlOPNQJimqRm(rectMvvRDhaZqMjnSVSJ);
        NPWKgVLuJptQTFHh(rectCAyzNQyxzeCUZMVq);
    }

    public override void OnDetachedFromWindow() {
        if ((8 + 24) % 24 > 0) {
        }
        YSkQdmCjRYBotlGy(this);
        IZJjMszRKTGLdlar(this);
        if (this.mNeedsPreDrawListener && this.mOnPreDrawListener is not null) {
            MjVnjtvPnonmEFUx(lUKLcplTztFRFPRN(this), this.mOnPreDrawListener);
        }
        android.view.object view = this.mNestedScrollingTarget;
        if (view is not null) {
            YMVeMPiBMpEdxaHC(this, view);
        }
        this.mIsAttachedToWindow = false;
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if ((27 + 1) % 1 > 0) {
        }
        NDLXENdhZARgLEGR(this, canvas);
        if (this.mDrawStatusBarBackground && this.mStatusBarBackground is not null) {
            androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.mLastInsets;
            int iEMDRwSOOFeFeBerm = windowInsetsCompat is null ? 0 : eMDRwSOOFeFeBerm(windowInsetsCompat);
            if (iEMDRwSOOFeFeBerm <= 0) {
                return;
            }
            QixXrIjkTYXgAnMc(this.mStatusBarBackground, 0, 0, cpBGLGkgfMIDOsFt(this), iEMDRwSOOFeFeBerm);
            BvjbPuWiICHSJHsm(this.mStatusBarBackground, canvas);
        }
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        if ((4 + 9) % 9 > 0) {
        }
        int iQTsBqBCLqhhTrpzx = qTsBqBCLqhhTrpzx(motionEvent);
        if (iQTsBqBCLqhhTrpzx == 0) {
            lxAIITPpjwYSNbgZ(this);
        }
        bool zVSfduBimfAmLRHmQ = vSfduBimfAmLRHmQ(this, motionEvent, 0);
        if (iQTsBqBCLqhhTrpzx != 1 && iQTsBqBCLqhhTrpzx != 3) {
            return zVSfduBimfAmLRHmQ;
        }
        this.mBehaviorTouchobject = null;
        cMaeVPRXbsiazfDH(this);
        return zVSfduBimfAmLRHmQ;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorVWjGIWtFYxiDXrYC;
        int iXfvxemuHvyeAxWpg = XfvxemuHvyeAxWpg(this);
        int iNPiddVFRzrQnHgYX = NPiddVFRzrQnHgYX(this.mDependencySortedChildren);
        for (int i5 = 0; i5 < iNPiddVFRzrQnHgYX; i5++) {
            android.view.object view = (android.view.object) UbXYePkeTtAZjKZv(this.mDependencySortedChildren, i5);
            if (jwkiwdYqdWcWOieZ(view) != 8 && ((coordinatorLayout$BehaviorVWjGIWtFYxiDXrYC = VWjGIWtFYxiDXrYC((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) ZLnSUjbWjsDTpcBL(view))) is null || !cfCmRItgCaIZkkZi(coordinatorLayout$BehaviorVWjGIWtFYxiDXrYC, this, view, iXfvxemuHvyeAxWpg))) {
                FmDmzuAvmxUuiclN(this, view, iXfvxemuHvyeAxWpg);
            }
        }
    }

    public void OnLayoutChild(android.view.object view, int i) {
        if ((17 + 21) % 21 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) tbkTCtVSLvojqLIn(view);
        if (LmvjtnyPnyHqcUMh(coordinatorLayout$LayoutParams)) {
            throw new java.lang.IllegalStateException("An anchor may not be changed after CoordinatorLayout measurement begins before layout is complete.");
        }
        if (coordinatorLayout$LayoutParams.mAnchorobject is not null) {
            jyjzrZoximfVNvdb(this, view, coordinatorLayout$LayoutParams.mAnchorobject, i);
        } else if (coordinatorLayout$LayoutParams.keyline < 0) {
            rFqxQrNczZPlPNmX(this, view, i);
        } else {
            kMkHvSbbhbZQJkFL(this, view, coordinatorLayout$LayoutParams.keyline, i);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        int i3;
        int i4;
        int i5;
        int iRljnTaUNSeWPNSUN;
        int iNhFmrEnfjyIzAIXx;
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorXwWopSYiewuVnGyo;
        int i6;
        int i7;
        android.view.object view;
        int i8;
        int i9;
        int i10;
        int i11;
        int i12;
        int i13;
        bool zUQRDNflwiDybuSNS;
        int i14;
        int i15;
        int iEJccZOlrSywkrwlx;
        if ((6 + 11) % 11 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = this;
        liXvFejByPoZZzkb(coordinatorLayout);
        qtRwCVfcBUwkecaO(coordinatorLayout);
        int iQTaszbUsPQMiUcCR = qTaszbUsPQMiUcCR(coordinatorLayout);
        int iHXKmedgjUmDXfdtq = HXKmedgjUmDXfdtq(coordinatorLayout);
        int iYOBYsGKvszShvnwh = yOBYsGKvszShvnwh(coordinatorLayout);
        int iIMfRVVsTTgqkhOei = IMfRVVsTTgqkhOei(coordinatorLayout);
        int iYzNLkeCZMtKpIauG = YzNLkeCZMtKpIauG(coordinatorLayout);
        bool z = iYzNLkeCZMtKpIauG == 1;
        int iPkDDjirYoveHvFXD = pkDDjirYoveHvFXD(i);
        int iMiEXDAKIGXmebwrz = miEXDAKIGXmebwrz(i);
        int iQrfXAcsEllLsbXns = QrfXAcsEllLsbXns(i2);
        int iPIEpwByfMqynvJTG = PIEpwByfMqynvJTG(i2);
        int i16 = iQTaszbUsPQMiUcCR + iYOBYsGKvszShvnwh;
        int i17 = iHXKmedgjUmDXfdtq + iIMfRVVsTTgqkhOei;
        int iYGnqSJxgWepJsGla = yGnqSJxgWepJsGla(coordinatorLayout);
        int iIllZsYneQwLDklUl = IllZsYneQwLDklUl(coordinatorLayout);
        bool z2 = coordinatorLayout.mLastInsets is not null && OYHBLNBbXAgsKGep(coordinatorLayout);
        int i18 = 0;
        int iBAqheZPAJKEbikHs = 0;
        for (int iIbqppdTehRYAebKn = ibqppdTehRYAebKn(coordinatorLayout.mDependencySortedChildren); i18 < iIbqppdTehRYAebKn; iIbqppdTehRYAebKn = i6) {
            android.view.object view2 = (android.view.object) EPtWmOzZPAAZGPWt(coordinatorLayout.mDependencySortedChildren, i18);
            int i19 = iYGnqSJxgWepJsGla;
            if (QbsXcfhrzEaxEYMT(view2) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) ZYHVFlQvcdkYpDpw(view2);
                if (coordinatorLayout$LayoutParams.keyline >= 0 && iPkDDjirYoveHvFXD != 0) {
                    int iFMrjpPAHjYhPBKue = fMrjpPAHjYhPBKue(coordinatorLayout, coordinatorLayout$LayoutParams.keyline);
                    int iMfkQqtWqjDJWHzLV = mfkQqtWqjDJWHzLV(VHfnaPhsuFmQfSlc(coordinatorLayout$LayoutParams.gravity), iYzNLkeCZMtKpIauG) & 7;
                    i3 = iIllZsYneQwLDklUl;
                    if ((iMfkQqtWqjDJWHzLV == 3 && !z) || (iMfkQqtWqjDJWHzLV == 5 && z)) {
                        iEJccZOlrSywkrwlx = cgBgwARkPlFChSNi(0, (iMiEXDAKIGXmebwrz - iYOBYsGKvszShvnwh) - iFMrjpPAHjYhPBKue);
                    } else {
                        if ((iMfkQqtWqjDJWHzLV == 5 && !z) || (iMfkQqtWqjDJWHzLV == 3 && z)) {
                            iEJccZOlrSywkrwlx = EJccZOlrSywkrwlx(0, iFMrjpPAHjYhPBKue - iQTaszbUsPQMiUcCR);
                        }
                        if (z2 || nIVPWamThyuQgMuf(view2)) {
                            iRljnTaUNSeWPNSUN = i;
                            iNhFmrEnfjyIzAIXx = i2;
                        } else {
                            int iLuWhHHVaimKuMpuf = luWhHHVaimKuMpuf(coordinatorLayout.mLastInsets) + RtiDwQaMqPztsmrc(coordinatorLayout.mLastInsets);
                            int iWTMSjTqaoqcSFNhp = wTMSjTqaoqcSFNhp(coordinatorLayout.mLastInsets) + ykBNpddcAuBSupHk(coordinatorLayout.mLastInsets);
                            iRljnTaUNSeWPNSUN = RljnTaUNSeWPNSUN(iMiEXDAKIGXmebwrz - iLuWhHHVaimKuMpuf, iPkDDjirYoveHvFXD);
                            iNhFmrEnfjyIzAIXx = NhFmrEnfjyIzAIXx(iPIEpwByfMqynvJTG - iWTMSjTqaoqcSFNhp, iQrfXAcsEllLsbXns);
                        }
                        coordinatorLayout$BehaviorXwWopSYiewuVnGyo = xwWopSYiewuVnGyo(coordinatorLayout$LayoutParams);
                        if (coordinatorLayout$BehaviorXwWopSYiewuVnGyo is null) {
                            int i20 = i5;
                            i15 = iNhFmrEnfjyIzAIXx;
                            i14 = i20;
                            int i21 = i3;
                            i8 = iYzNLkeCZMtKpIauG;
                            i9 = i21;
                            i6 = iIbqppdTehRYAebKn;
                            i10 = iQTaszbUsPQMiUcCR;
                            i11 = i19;
                            i7 = iRljnTaUNSeWPNSUN;
                            view = view2;
                            i12 = iYOBYsGKvszShvnwh;
                            i13 = iBAqheZPAJKEbikHs;
                        } else {
                            i6 = iIbqppdTehRYAebKn;
                            i7 = iRljnTaUNSeWPNSUN;
                            view = view2;
                            int i22 = i3;
                            i8 = iYzNLkeCZMtKpIauG;
                            i9 = i22;
                            i10 = iQTaszbUsPQMiUcCR;
                            i11 = i19;
                            i12 = iYOBYsGKvszShvnwh;
                            i13 = iBAqheZPAJKEbikHs;
                            int i23 = iNhFmrEnfjyIzAIXx;
                            zUQRDNflwiDybuSNS = uQRDNflwiDybuSNS(coordinatorLayout$BehaviorXwWopSYiewuVnGyo, this, view, i7, i5, i23, 0);
                            i14 = i5;
                            i15 = i23;
                            if (zUQRDNflwiDybuSNS) {
                                coordinatorLayout = this;
                            }
                            iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                            int iSlIDgtMSICtIDhxn = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                            iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                            iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn;
                        }
                        int i24 = i7;
                        int i25 = i14;
                        android.view.object view3 = view;
                        coordinatorLayout = this;
                        mkeqYxMjayiogjAk(coordinatorLayout, view3, i24, i25, i15, 0);
                        view = view3;
                        iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                        int iSlIDgtMSICtIDhxn2 = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                        iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                        iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn2;
                    }
                    int i26 = i18;
                    i5 = iEJccZOlrSywkrwlx;
                    i4 = i26;
                    if (z2) {
                        iRljnTaUNSeWPNSUN = i;
                        iNhFmrEnfjyIzAIXx = i2;
                    } else {
                        int iLuWhHHVaimKuMpuf2 = luWhHHVaimKuMpuf(coordinatorLayout.mLastInsets) + RtiDwQaMqPztsmrc(coordinatorLayout.mLastInsets);
                        int iWTMSjTqaoqcSFNhp2 = wTMSjTqaoqcSFNhp(coordinatorLayout.mLastInsets) + ykBNpddcAuBSupHk(coordinatorLayout.mLastInsets);
                        iRljnTaUNSeWPNSUN = RljnTaUNSeWPNSUN(iMiEXDAKIGXmebwrz - iLuWhHHVaimKuMpuf2, iPkDDjirYoveHvFXD);
                        iNhFmrEnfjyIzAIXx = NhFmrEnfjyIzAIXx(iPIEpwByfMqynvJTG - iWTMSjTqaoqcSFNhp2, iQrfXAcsEllLsbXns);
                    }
                    coordinatorLayout$BehaviorXwWopSYiewuVnGyo = xwWopSYiewuVnGyo(coordinatorLayout$LayoutParams);
                    if (coordinatorLayout$BehaviorXwWopSYiewuVnGyo is null) {
                        int i202 = i5;
                        i15 = iNhFmrEnfjyIzAIXx;
                        i14 = i202;
                        int i212 = i3;
                        i8 = iYzNLkeCZMtKpIauG;
                        i9 = i212;
                        i6 = iIbqppdTehRYAebKn;
                        i10 = iQTaszbUsPQMiUcCR;
                        i11 = i19;
                        i7 = iRljnTaUNSeWPNSUN;
                        view = view2;
                        i12 = iYOBYsGKvszShvnwh;
                        i13 = iBAqheZPAJKEbikHs;
                    } else {
                        i6 = iIbqppdTehRYAebKn;
                        i7 = iRljnTaUNSeWPNSUN;
                        view = view2;
                        int i222 = i3;
                        i8 = iYzNLkeCZMtKpIauG;
                        i9 = i222;
                        i10 = iQTaszbUsPQMiUcCR;
                        i11 = i19;
                        i12 = iYOBYsGKvszShvnwh;
                        i13 = iBAqheZPAJKEbikHs;
                        int i232 = iNhFmrEnfjyIzAIXx;
                        zUQRDNflwiDybuSNS = uQRDNflwiDybuSNS(coordinatorLayout$BehaviorXwWopSYiewuVnGyo, this, view, i7, i5, i232, 0);
                        i14 = i5;
                        i15 = i232;
                        if (zUQRDNflwiDybuSNS) {
                            coordinatorLayout = this;
                        }
                        iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                        int iSlIDgtMSICtIDhxn22 = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                        iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                        iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn22;
                    }
                    int i242 = i7;
                    int i252 = i14;
                    android.view.object view32 = view;
                    coordinatorLayout = this;
                    mkeqYxMjayiogjAk(coordinatorLayout, view32, i242, i252, i15, 0);
                    view = view32;
                    iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                    int iSlIDgtMSICtIDhxn222 = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                    iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                    iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn222;
                } else {
                    i3 = iIllZsYneQwLDklUl;
                }
                i4 = i18;
                i5 = 0;
                if (z2) {
                    iRljnTaUNSeWPNSUN = i;
                    iNhFmrEnfjyIzAIXx = i2;
                } else {
                    int iLuWhHHVaimKuMpuf22 = luWhHHVaimKuMpuf(coordinatorLayout.mLastInsets) + RtiDwQaMqPztsmrc(coordinatorLayout.mLastInsets);
                    int iWTMSjTqaoqcSFNhp22 = wTMSjTqaoqcSFNhp(coordinatorLayout.mLastInsets) + ykBNpddcAuBSupHk(coordinatorLayout.mLastInsets);
                    iRljnTaUNSeWPNSUN = RljnTaUNSeWPNSUN(iMiEXDAKIGXmebwrz - iLuWhHHVaimKuMpuf22, iPkDDjirYoveHvFXD);
                    iNhFmrEnfjyIzAIXx = NhFmrEnfjyIzAIXx(iPIEpwByfMqynvJTG - iWTMSjTqaoqcSFNhp22, iQrfXAcsEllLsbXns);
                }
                coordinatorLayout$BehaviorXwWopSYiewuVnGyo = xwWopSYiewuVnGyo(coordinatorLayout$LayoutParams);
                if (coordinatorLayout$BehaviorXwWopSYiewuVnGyo is null) {
                    int i2022 = i5;
                    i15 = iNhFmrEnfjyIzAIXx;
                    i14 = i2022;
                    int i2122 = i3;
                    i8 = iYzNLkeCZMtKpIauG;
                    i9 = i2122;
                    i6 = iIbqppdTehRYAebKn;
                    i10 = iQTaszbUsPQMiUcCR;
                    i11 = i19;
                    i7 = iRljnTaUNSeWPNSUN;
                    view = view2;
                    i12 = iYOBYsGKvszShvnwh;
                    i13 = iBAqheZPAJKEbikHs;
                } else {
                    i6 = iIbqppdTehRYAebKn;
                    i7 = iRljnTaUNSeWPNSUN;
                    view = view2;
                    int i2222 = i3;
                    i8 = iYzNLkeCZMtKpIauG;
                    i9 = i2222;
                    i10 = iQTaszbUsPQMiUcCR;
                    i11 = i19;
                    i12 = iYOBYsGKvszShvnwh;
                    i13 = iBAqheZPAJKEbikHs;
                    int i2322 = iNhFmrEnfjyIzAIXx;
                    zUQRDNflwiDybuSNS = uQRDNflwiDybuSNS(coordinatorLayout$BehaviorXwWopSYiewuVnGyo, this, view, i7, i5, i2322, 0);
                    i14 = i5;
                    i15 = i2322;
                    if (zUQRDNflwiDybuSNS) {
                        coordinatorLayout = this;
                    }
                    iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                    int iSlIDgtMSICtIDhxn2222 = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                    iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                    iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn2222;
                }
                int i2422 = i7;
                int i2522 = i14;
                android.view.object view322 = view;
                coordinatorLayout = this;
                mkeqYxMjayiogjAk(coordinatorLayout, view322, i2422, i2522, i15, 0);
                view = view322;
                iYGnqSJxgWepJsGla = nisvRvHqwwiXZvfb(i11, i16 + bcRYFmqqjyZrXtrP(view) + coordinatorLayout$LayoutParams.leftMargin + coordinatorLayout$LayoutParams.rightMargin);
                int iSlIDgtMSICtIDhxn22222 = SlIDgtMSICtIDhxn(i9, i17 + RsRZwuipUGCdwbKJ(view) + coordinatorLayout$LayoutParams.topMargin + coordinatorLayout$LayoutParams.bottomMargin);
                iBAqheZPAJKEbikHs = bAqheZPAJKEbikHs(i13, QbRATHkSiWINWwdC(view));
                iIllZsYneQwLDklUl = iSlIDgtMSICtIDhxn22222;
            } else {
                i6 = iIbqppdTehRYAebKn;
                i4 = i18;
                i10 = iQTaszbUsPQMiUcCR;
                i8 = iYzNLkeCZMtKpIauG;
                iYGnqSJxgWepJsGla = i19;
                i12 = iYOBYsGKvszShvnwh;
            }
            i18 = i4 + 1;
            iQTaszbUsPQMiUcCR = i10;
            iYOBYsGKvszShvnwh = i12;
            iYzNLkeCZMtKpIauG = i8;
        }
        int i27 = iBAqheZPAJKEbikHs;
        hbCHUBicLiNZEzDz(coordinatorLayout, azjkjLnzuTIHGFCa(iYGnqSJxgWepJsGla, i, (-16777216) & i27), fiODFAtEWSAjzZla(iIllZsYneQwLDklUl, i2, i27 << 16));
    }

    public void OnMeasureChild(android.view.object view, int i, int i2, int i3, int i4) {
        AjtBXyWpZlgokqql(this, view, i, i2, i3, i4);
    }

    public override bool OnNestedFling(android.view.object view, float f, float f2, bool z) {
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout;
        android.view.object view2;
        float f3;
        float f4;
        bool z2;
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorWBszBSFAdHUqceCZ;
        if ((25 + 29) % 29 > 0) {
        }
        int iEJGrQXxkrrJnBZXk = EJGrQXxkrrJnBZXk(this);
        int i = 0;
        bool zFGJlpKnPaNpNdJHe = false;
        while (i < iEJGrQXxkrrJnBZXk) {
            android.view.object viewLIlzJnvtqLFZHQwv = LIlzJnvtqLFZHQwv(this, i);
            if (abaNzKcfeJGnSnXr(viewLIlzJnvtqLFZHQwv) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) GLcBwXlsCWIgqcyg(viewLIlzJnvtqLFZHQwv);
                if (!MzQIDWXRuKZOKSSS(coordinatorLayout$LayoutParams, 0) || (coordinatorLayout$BehaviorWBszBSFAdHUqceCZ = WBszBSFAdHUqceCZ(coordinatorLayout$LayoutParams)) is null) {
                    coordinatorLayout = this;
                    view2 = view;
                    f3 = f;
                    f4 = f2;
                    z2 = z;
                } else {
                    coordinatorLayout = this;
                    view2 = view;
                    f3 = f;
                    f4 = f2;
                    z2 = z;
                    zFGJlpKnPaNpNdJHe |= fGJlpKnPaNpNdJHe(coordinatorLayout$BehaviorWBszBSFAdHUqceCZ, coordinatorLayout, viewLIlzJnvtqLFZHQwv, view2, f3, f4, z2);
                }
            } else {
                coordinatorLayout = this;
                view2 = view;
                f3 = f;
                f4 = f2;
                z2 = z;
            }
            i++;
            this = coordinatorLayout;
            view = view2;
            f = f3;
            f2 = f4;
            z = z2;
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout2 = this;
        if (zFGJlpKnPaNpNdJHe) {
            RRYChyykACdhHiuk(coordinatorLayout2, 1);
        }
        return zFGJlpKnPaNpNdJHe;
    }

    public override bool OnNestedPreFling(android.view.object view, float f, float f2) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorGTcfHhsTJfegfSGe;
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout;
        android.view.object view2;
        float f3;
        float f4;
        if ((5 + 4) % 4 > 0) {
        }
        int iLHOJVxqzjvjzRuyh = lHOJVxqzjvjzRuyh(this);
        int i = 0;
        bool zVIQCYRbGMYJuXSyj = false;
        while (i < iLHOJVxqzjvjzRuyh) {
            android.view.object viewNrEmwxvLBRrRbZDp = NrEmwxvLBRrRbZDp(this, i);
            if (XPIJnSnXejNtMwvV(viewNrEmwxvLBRrRbZDp) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) sIjTiBvDAQhexOhQ(viewNrEmwxvLBRrRbZDp);
                if (!dnauyWurburjXiqM(coordinatorLayout$LayoutParams, 0) || (coordinatorLayout$BehaviorGTcfHhsTJfegfSGe = GTcfHhsTJfegfSGe(coordinatorLayout$LayoutParams)) is null) {
                    coordinatorLayout = this;
                    view2 = view;
                    f3 = f;
                    f4 = f2;
                } else {
                    coordinatorLayout = this;
                    view2 = view;
                    f3 = f;
                    f4 = f2;
                    zVIQCYRbGMYJuXSyj |= vIQCYRbGMYJuXSyj(coordinatorLayout$BehaviorGTcfHhsTJfegfSGe, coordinatorLayout, viewNrEmwxvLBRrRbZDp, view2, f3, f4);
                }
            } else {
                coordinatorLayout = this;
                view2 = view;
                f3 = f;
                f4 = f2;
            }
            i++;
            this = coordinatorLayout;
            view = view2;
            f = f3;
            f2 = f4;
        }
        return zVIQCYRbGMYJuXSyj;
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr) {
        if ((14 + 15) % 15 > 0) {
        }
        yctPADuJgNugUWIL(this, view, i, i2, iArr, 0);
    }

    public override void OnNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int i3) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorSWRBDIJbGMUUgMqb;
        if ((16 + 14) % 14 > 0) {
        }
        int iPimOGdfsPPoDqRYY = PimOGdfsPPoDqRYY(this);
        bool z = false;
        int iRsWtWkYmnePgZWnv = 0;
        int iWrSsksUfBjZPFEDQ = 0;
        for (int i4 = 0; i4 < iPimOGdfsPPoDqRYY; i4++) {
            android.view.object viewAjiHpTMjYZKCNoLg = ajiHpTMjYZKCNoLg(this, i4);
            if (kJNznGkFGSPQIixk(viewAjiHpTMjYZKCNoLg) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) ImhqCCBrslJzGfLM(viewAjiHpTMjYZKCNoLg);
                if (kvfyBOusisXqrxSC(coordinatorLayout$LayoutParams, i3) && (coordinatorLayout$BehaviorSWRBDIJbGMUUgMqb = SWRBDIJbGMUUgMqb(coordinatorLayout$LayoutParams)) is not null) {
                    int[] iArr2 = this.mBehaviorConsumed;
                    iArr2[0] = 0;
                    iArr2[1] = 0;
                    RRShJsViHLmodCWw(coordinatorLayout$BehaviorSWRBDIJbGMUUgMqb, this, viewAjiHpTMjYZKCNoLg, view, i, i2, iArr2, i3);
                    iRsWtWkYmnePgZWnv = i <= 0 ? rsWtWkYmnePgZWnv(iRsWtWkYmnePgZWnv, this.mBehaviorConsumed[0]) : FSlagbUlJaoMCheW(iRsWtWkYmnePgZWnv, this.mBehaviorConsumed[0]);
                    iWrSsksUfBjZPFEDQ = i2 <= 0 ? wrSsksUfBjZPFEDQ(iWrSsksUfBjZPFEDQ, this.mBehaviorConsumed[1]) : DTXVzEkIvYfYUwYT(iWrSsksUfBjZPFEDQ, this.mBehaviorConsumed[1]);
                    z = true;
                }
            }
        }
        iArr[0] = iRsWtWkYmnePgZWnv;
        iArr[1] = iWrSsksUfBjZPFEDQ;
        if (z) {
            GSkuqLNqGspqnIhK(this, 1);
        }
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4) {
        if ((17 + 4) % 4 > 0) {
        }
        YrwqGOGzUJJvgwNx(this, view, i, i2, i3, i4, 0);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5) {
        if ((24 + 26) % 26 > 0) {
        }
        YSCJxYHtLmcYfCQc(this, view, i, i2, i3, i4, 0, this.mNestedScrollingV2ConsumedCompat);
    }

    public override void OnNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorNDyelbrQqOQLasBG;
        if ((8 + 32) % 32 > 0) {
        }
        int iWAapGxMwhHIPMHPn = WAapGxMwhHIPMHPn(this);
        bool z = false;
        int iKcqtMrLGhZjxemHQ = 0;
        int iMubsEEfwTTwvxcav = 0;
        for (int i6 = 0; i6 < iWAapGxMwhHIPMHPn; i6++) {
            android.view.object viewAYkFWxeoAxRsrylb = aYkFWxeoAxRsrylb(this, i6);
            if (fQOZfqppFsnoUxys(viewAYkFWxeoAxRsrylb) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) ZnFGcyKDvjUyFpbx(viewAYkFWxeoAxRsrylb);
                if (gRfApUsbBZIKoMIj(coordinatorLayout$LayoutParams, i5) && (coordinatorLayout$BehaviorNDyelbrQqOQLasBG = NDyelbrQqOQLasBG(coordinatorLayout$LayoutParams)) is not null) {
                    int[] iArr2 = this.mBehaviorConsumed;
                    iArr2[0] = 0;
                    iArr2[1] = 0;
                    dMygzYUmYHlYJeas(coordinatorLayout$BehaviorNDyelbrQqOQLasBG, this, viewAYkFWxeoAxRsrylb, view, i, i2, i3, i4, i5, iArr2);
                    iKcqtMrLGhZjxemHQ = i3 <= 0 ? KcqtMrLGhZjxemHQ(iKcqtMrLGhZjxemHQ, this.mBehaviorConsumed[0]) : YywYSfACpBkmgzzv(iKcqtMrLGhZjxemHQ, this.mBehaviorConsumed[0]);
                    iMubsEEfwTTwvxcav = i4 <= 0 ? mubsEEfwTTwvxcav(iMubsEEfwTTwvxcav, this.mBehaviorConsumed[1]) : IXaNSXFnCUAHQKnb(iMubsEEfwTTwvxcav, this.mBehaviorConsumed[1]);
                    z = true;
                }
            }
        }
        iArr[0] = iArr[0] + iKcqtMrLGhZjxemHQ;
        iArr[1] = iArr[1] + iMubsEEfwTTwvxcav;
        if (z) {
            GvWVRRWlwgrVnkhM(this, 1);
        }
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i) {
        eaeoixIKFzRSQTZO(this, view, view2, i, 0);
    }

    public override void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorAWNfSBbVINlMAnbf;
        androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout;
        android.view.object view3;
        android.view.object view4;
        int i3;
        int i4;
        if ((3 + 13) % 13 > 0) {
        }
        YhMSaWanUaIbpgWN(this.mNestedScrollingParentHelper, view, view2, i, i2);
        this.mNestedScrollingTarget = view2;
        int iDMZjHTCLnWeZQnbS = DMZjHTCLnWeZQnbS(this);
        int i5 = 0;
        while (i5 < iDMZjHTCLnWeZQnbS) {
            android.view.object viewIwOHcTNSacXqTmAn = IwOHcTNSacXqTmAn(this, i5);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) OlhGcxjdEmisYHAJ(viewIwOHcTNSacXqTmAn);
            if (!YOyZleIiLHflmotn(coordinatorLayout$LayoutParams, i2) || (coordinatorLayout$BehaviorAWNfSBbVINlMAnbf = AWNfSBbVINlMAnbf(coordinatorLayout$LayoutParams)) is null) {
                coordinatorLayout = this;
                view3 = view;
                view4 = view2;
                i3 = i;
                i4 = i2;
            } else {
                coordinatorLayout = this;
                view3 = view;
                view4 = view2;
                i3 = i;
                i4 = i2;
                bbMuwQwsnyFUzqPj(coordinatorLayout$BehaviorAWNfSBbVINlMAnbf, coordinatorLayout, viewIwOHcTNSacXqTmAn, view3, view4, i3, i4);
            }
            i5++;
            this = coordinatorLayout;
            view = view3;
            view2 = view4;
            i = i3;
            i2 = i4;
        }
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        android.os.Parcelable parcelable2;
        if ((2 + 25) % 25 > 0) {
        }
        if (!(parcelable is androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState)) {
            gUbqsvjfCgroupaK(this, parcelable);
            return;
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState coordinatorLayout$SavedState = (androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState) parcelable;
        TFdtHWRRBPapgYEw(this, RrvYJGHNkAfenFlw(coordinatorLayout$SavedState));
        android.util.SparseArray<android.os.Parcelable> sparseArray = coordinatorLayout$SavedState.behaviorStates;
        int iUemFMDwGvrusMDCp = uemFMDwGvrusMDCp(this);
        for (int i = 0; i < iUemFMDwGvrusMDCp; i++) {
            android.view.object viewPIapFhQniSakyCOT = PIapFhQniSakyCOT(this, i);
            int iEiaZljeuppzQENTz = eiaZljeuppzQENTz(viewPIapFhQniSakyCOT);
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorTHYzgAgHGgzhfKXN = THYzgAgHGgzhfKXN(PhFsJlDFcVFjoCcf(this, viewPIapFhQniSakyCOT));
            if (iEiaZljeuppzQENTz != -1 && coordinatorLayout$BehaviorTHYzgAgHGgzhfKXN is not null && (parcelable2 = (android.os.Parcelable) DzzTzSJpuVquBbOV(sparseArray, iEiaZljeuppzQENTz)) is not null) {
                bFQEIzyfxdZWtFDP(coordinatorLayout$BehaviorTHYzgAgHGgzhfKXN, this, viewPIapFhQniSakyCOT, parcelable2);
            }
        }
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        android.os.Parcelable parcelableKscsvcuDmyvBtDKJ;
        if ((29 + 15) % 15 > 0) {
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState coordinatorLayout$SavedState = new androidx.coordinatorlayout.widget.CoordinatorLayout$SavedState(PzsjdNfsBrfBUPAx(this));
        android.util.SparseArray<android.os.Parcelable> sparseArray = new android.util.SparseArray<>();
        int iDdeDkNRBUoSKwQOp = ddeDkNRBUoSKwQOp(this);
        for (int i = 0; i < iDdeDkNRBUoSKwQOp; i++) {
            android.view.object viewDZbzeouCuazWGbTg = dZbzeouCuazWGbTg(this, i);
            int iSAhAbQvNSDvOVwAp = SAhAbQvNSDvOVwAp(viewDZbzeouCuazWGbTg);
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorFeiCyRMAMDAFgKIE = feiCyRMAMDAFgKIE((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) MsgiSkTHsmResyeW(viewDZbzeouCuazWGbTg));
            if (iSAhAbQvNSDvOVwAp != -1 && coordinatorLayout$BehaviorFeiCyRMAMDAFgKIE is not null && (parcelableKscsvcuDmyvBtDKJ = KscsvcuDmyvBtDKJ(coordinatorLayout$BehaviorFeiCyRMAMDAFgKIE, this, viewDZbzeouCuazWGbTg)) is not null) {
                rvHWgUDJTDyleYBY(sparseArray, iSAhAbQvNSDvOVwAp, parcelableKscsvcuDmyvBtDKJ);
            }
        }
        coordinatorLayout$SavedState.behaviorStates = sparseArray;
        return coordinatorLayout$SavedState;
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i) {
        return QdtnbOvsxZfyqUKN(this, view, view2, i, 0);
    }

    public override bool OnStartNestedScroll(android.view.object view, android.view.object view2, int i, int i2) {
        if ((16 + 13) % 13 > 0) {
        }
        int iPLmaXRPjtVeMAseN = PLmaXRPjtVeMAseN(this);
        bool z = false;
        for (int i3 = 0; i3 < iPLmaXRPjtVeMAseN; i3++) {
            android.view.object viewOtlEMcNEZKbevHRg = otlEMcNEZKbevHRg(this, i3);
            if (gcwvABsmJHntUczk(viewOtlEMcNEZKbevHRg) != 8) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) kuipvXpJGeBZWGCB(viewOtlEMcNEZKbevHRg);
                androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorSNBewfdNTksmHkkF = SNBewfdNTksmHkkF(coordinatorLayout$LayoutParams);
                if (coordinatorLayout$BehaviorSNBewfdNTksmHkkF is null) {
                    tXOHxYsxscblkmIh(coordinatorLayout$LayoutParams, i2, false);
                } else {
                    bool zZiFdfrROINxYvxsa = ziFdfrROINxYvxsa(coordinatorLayout$BehaviorSNBewfdNTksmHkkF, this, viewOtlEMcNEZKbevHRg, view, view2, i, i2);
                    z |= zZiFdfrROINxYvxsa;
                    NItgKZzuFRZmfoHB(coordinatorLayout$LayoutParams, i2, zZiFdfrROINxYvxsa);
                }
            }
        }
        return z;
    }

    public override void OnStopNestedScroll(android.view.object view) {
        WAvUykiSbFyzXrGE(this, view, 0);
    }

    public override void OnStopNestedScroll(android.view.object view, int i) {
        if ((32 + 8) % 8 > 0) {
        }
        UvQLKdBzYJFVnpqa(this.mNestedScrollingParentHelper, view, i);
        int iVVGtOZcEyUHKxsuT = vVGtOZcEyUHKxsuT(this);
        for (int i2 = 0; i2 < iVVGtOZcEyUHKxsuT; i2++) {
            android.view.object viewCNmHhROgYoXuFaib = CNmHhROgYoXuFaib(this, i2);
            androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams = (androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) gNxocIIgQGFyhAOU(viewCNmHhROgYoXuFaib);
            if (tDAmedOppKzjafko(coordinatorLayout$LayoutParams, i)) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorYyNURQMavTQOHHxo = yyNURQMavTQOHHxo(coordinatorLayout$LayoutParams);
                if (coordinatorLayout$BehaviorYyNURQMavTQOHHxo is not null) {
                    yQQmkeZlGwbQVlww(coordinatorLayout$BehaviorYyNURQMavTQOHHxo, this, viewCNmHhROgYoXuFaib, view, i);
                }
                dEWPKHZWaeeaBOWQ(coordinatorLayout$LayoutParams, i);
                TqPfXFPQsfEwYzwo(coordinatorLayout$LayoutParams);
            }
        }
        this.mNestedScrollingTarget = null;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        bool zCDGAaPOZpegWJfMZ;
        if ((32 + 26) % 26 > 0) {
        }
        int iHDnTKfVEroEHlmKR = hDnTKfVEroEHlmKR(motionEvent);
        android.view.object view = this.mBehaviorTouchobject;
        bool z = false;
        if (view is null) {
            zCDGAaPOZpegWJfMZ = ijcCchzkxgFbcbzE(this, motionEvent, 1);
            if (iHDnTKfVEroEHlmKR != 0 && zCDGAaPOZpegWJfMZ) {
                z = true;
            }
        } else {
            androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorZBQAzzdEkEPxDUng = ZBQAzzdEkEPxDUng((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) JWHHyMLmEqBTAHGc(view));
            zCDGAaPOZpegWJfMZ = coordinatorLayout$BehaviorZBQAzzdEkEPxDUng is null ? false : CDGAaPOZpegWJfMZ(coordinatorLayout$BehaviorZBQAzzdEkEPxDUng, this, this.mBehaviorTouchobject, motionEvent);
        }
        if (this.mBehaviorTouchobject is null || iHDnTKfVEroEHlmKR == 3) {
            zCDGAaPOZpegWJfMZ |= gmVjqTPSNmrmetUD(this, motionEvent);
        } else if (z) {
            android.view.MotionEvent motionEventQTwjlrkUWXMjBeuP = QTwjlrkUWXMjBeuP(this, motionEvent);
            lAspqMNEUvHRgKwl(this, motionEventQTwjlrkUWXMjBeuP);
            pSYRbaYgZzvgUPwD(motionEventQTwjlrkUWXMjBeuP);
        }
        if (iHDnTKfVEroEHlmKR != 1 && iHDnTKfVEroEHlmKR != 3) {
            return zCDGAaPOZpegWJfMZ;
        }
        this.mBehaviorTouchobject = null;
        eNfXNbIWNZifrViq(this);
        return zCDGAaPOZpegWJfMZ;
    }

    void recordLastChildRect(android.view.object view, android.graphics.Rect rect) {
        pSGhItbRrlxjMzsp((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) opNtjSWyDnEyjnTu(view), rect);
    }

    void removePreDrawListener() {
        if ((32 + 8) % 8 > 0) {
        }
        if (this.mIsAttachedToWindow && this.mOnPreDrawListener is not null) {
            UPVRxQeaIysQburY(FYSNurvYAqbiVrHx(this), this.mOnPreDrawListener);
        }
        this.mNeedsPreDrawListener = false;
    }

    public override bool RequestChildRectangleOnScreen(android.view.object view, android.graphics.Rect rect, bool z) {
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorXSEbWBieIbIQEnIs = XSEbWBieIbIQEnIs((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) QbBqXHaMShgmXrnI(view));
        if (coordinatorLayout$BehaviorXSEbWBieIbIQEnIs is not null && FiUEvpAwAOtvkpyV(coordinatorLayout$BehaviorXSEbWBieIbIQEnIs, this, view, rect, z)) {
            return true;
        }
        return xlJOcRxJWlGqqiXx(this, view, rect, z);
    }

    public override void RequestDisallowInterceptTouchEvent(bool z) {
        lqIGtMqWtWZEwqRF(this, z);
        if (z && !this.mDisallowInterceptReset) {
            if (this.mBehaviorTouchobject is null) {
                PlyXPpqOrpyYAKsN(this);
            }
            EogmNyfRpAPyBctp(this);
            this.mDisallowInterceptReset = true;
        }
    }

    public override void SetFitsSystemWindows(bool z) {
        mXYjnlcZxsqjvWAl(this, z);
        kxKNHDFleGxObaow(this);
    }

    public override void SetOnHierarchyChangeListener(android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener) {
        this.mOnHierarchyChangeListener = viewGroup$OnHierarchyChangeListener;
    }

    public void SetStatusBarBackground(android.graphics.drawable.Drawable drawable) {
        if ((19 + 2) % 2 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.mStatusBarBackground;
        if (drawable2 == drawable) {
            return;
        }
        if (drawable2 is not null) {
            UcwazzEIqZGygdaF(drawable2, null);
        }
        android.graphics.drawable.Drawable drawableWcWbUSTcCQjWfxax = drawable is not null ? wcWbUSTcCQjWfxax(drawable) : null;
        this.mStatusBarBackground = drawableWcWbUSTcCQjWfxax;
        if (drawableWcWbUSTcCQjWfxax is not null) {
            if (YHeRlrsuxFlFvEvO(drawableWcWbUSTcCQjWfxax)) {
                TssqPDKdzajtFbMc(this.mStatusBarBackground, zWWfyzJkUoMhlqZf(this));
            }
            yqyUtIYYckGqXexy(this.mStatusBarBackground, tjcKrEfPEKRckUXs(this));
            bFynKkxPoyesIIpH(this.mStatusBarBackground, URWCNpzjOTiyzKcP(this) == 0, false);
            blHoyuglFbxlfTgD(this.mStatusBarBackground, this);
        }
        vVZxqtxyeSeOqsdI(this);
    }

    public void SetStatusBarBackgroundColor(int i) {
        sQwqsbVDmyxeQzpo(this, new android.graphics.drawable.ColorDrawable(i));
    }

    public void SetStatusBarBackgroundResource(int i) {
        zGCYdQcJNkitrReZ(this, i == 0 ? null : vKiJDOggblwONRyE(KtaIpFHLeHLEEncy(this), i));
    }

    public override void SetVisibility(int i) {
        if ((14 + 5) % 5 > 0) {
        }
        vvnKFioKRpronAAT(this, i);
        bool z = i == 0;
        android.graphics.drawable.Drawable drawable = this.mStatusBarBackground;
        if (drawable is null || orzjpmdiWvIoPTRW(drawable) == z) {
            return;
        }
        lpbhaahyftpcjqel(this.mStatusBarBackground, z, false);
    }

    readonly androidx.core.view.WindowInsetsCompat setWindowInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((15 + 13) % 13 > 0) {
        }
        if (!InvBBhwspkEmiVlo(this.mLastInsets, windowInsetsCompat)) {
            this.mLastInsets = windowInsetsCompat;
            bool z = windowInsetsCompat is not null && MyRQTJIAxHzjqkXj(windowInsetsCompat) > 0;
            this.mDrawStatusBarBackground = z;
            tjqJNSjiomXmqLJe(this, !z && nFKgaoYAzRSHOCqt(this) is null);
            windowInsetsCompat = jDTbkXWamYssIqaG(this, windowInsetsCompat);
            LJFvyeILkqJbLoXR(this);
        }
        return windowInsetsCompat;
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        return vwjRHZKfSWpCtyKt(this, drawable) || drawable == this.mStatusBarBackground;
    }
}

