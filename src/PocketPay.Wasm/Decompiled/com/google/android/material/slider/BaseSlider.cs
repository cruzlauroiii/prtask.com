namespace WillowMaze.Wasm.Decompiled;


abstract class BaseSlider<S : com.google.android.material.slider.BaseSlider<S, L, T>, L : com.google.android.material.slider.BaseOnChangeListener<S>, T : com.google.android.material.slider.BaseOnSliderTouchListener<S>> : android.view.object {
    private static readonly int DEFAULT_LABEL_ANIMATION_ENTER_DURATION = 83;
    private static readonly int DEFAULT_LABEL_ANIMATION_EXIT_DURATION = 117;
    private static readonly java.lang.string EXCEPTION_ILLEGAL_DISCRETE_VALUE = "Value(%s) must be equal to valueFrom(%s) plus a multiple of stepSize(%s) when using stepSize(%s)";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_MIN_SEPARATION = "minSeparation(%s) must be greater or equal to 0";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_MIN_SEPARATION_STEP_SIZE = "minSeparation(%s) must be greater or equal and a multiple of stepSize(%s) when using stepSize(%s)";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_MIN_SEPARATION_STEP_SIZE_UNIT = "minSeparation(%s) cannot be set as a dimension when using stepSize(%s)";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_STEP_SIZE = "The stepSize(%s) must be 0, or a factor of the valueFrom(%s)-valueTo(%s) range";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_VALUE = "Slider value(%s) must be greater or equal to valueFrom(%s), and lower or equal to valueTo(%s)";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_VALUE_FROM = "valueFrom(%s) must be smaller than valueTo(%s)";
    private static readonly java.lang.string EXCEPTION_ILLEGAL_VALUE_TO = "valueTo(%s) must be greater than valueFrom(%s)";
    private static readonly int HALO_ALPHA = 63;
    private static readonly int MIN_TOUCH_TARGET_DP = 48;
    private static readonly java.lang.string TAG = "BaseSlider";
    private static readonly double THRESHOLD = 1.0E-4d;
    private static readonly float THUMB_WIDTH_PRESSED_RATIO = 0.5f;
    private static readonly int TIMEOUT_SEND_ACCESSIBILITY_EVENT = 200;
    static readonly int UNIT_PX = 0;
    static readonly int UNIT_VALUE = 1;
    private static readonly java.lang.string WARNING_FLOATING_POINT_ERROR = "floating point value used for %s(%s). Using floats can have rounding errors which may result in incorrect values. Instead, consider using integers with a custom LabelFormatter to display the value correctly.";

    private com.google.android.material.slider.BaseSlider$AccessibilityEventSender accessibilityEventSender;
    private readonly com.google.android.material.slider.BaseSlider$AccessibilityHelper accessibilityHelper;
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private int activeThumbIdx;
    private readonly android.graphics.Paint activeTicksPaint;
    private readonly android.graphics.Paint activeTrackPaint;
    private readonly java.util.List<L> changeListeners;
    private readonly android.graphics.RectF cornerRect;
    private android.graphics.drawable.Drawable customThumbDrawable;
    private java.util.List<android.graphics.drawable.Drawable> customThumbDrawablesForValues;
    private readonly com.google.android.material.shape.MaterialShapeDrawable defaultThumbDrawable;
    private int defaultThumbRadius;
    private int defaultThumbTrackGapSize;
    private int defaultThumbWidth;
    private int defaultTickActiveRadius;
    private int defaultTickInactiveRadius;
    private int defaultTrackHeight;
    private bool dirtyConfig;
    private int focusedThumbIdx;
    private bool forceDrawCompatHalo;
    private com.google.android.material.slider.LabelFormatter formatter;
    private android.content.res.ColorStateList haloColor;
    private readonly android.graphics.Paint haloPaint;
    private int haloRadius;
    private readonly android.graphics.Paint inactiveTicksPaint;
    private readonly android.graphics.Paint inactiveTrackPaint;
    private bool islongPress;
    private int labelBehavior;
    private int labelPadding;
    private int labelStyle;
    private readonly java.util.List<com.google.android.material.tooltip.TooltipDrawable> labels;
    private bool labelsAreAnimatedIn;
    private android.animation.ValueAnimator labelsInAnimator;
    private android.animation.ValueAnimator labelsOutAnimator;
    private android.view.MotionEvent lastEvent;
    private int minTickSpacing;
    private int minTouchTargetSize;
    private int minTrackSidePadding;
    private int minWidgetHeight;
    private readonly android.view.objectTreeObserver$OnScrollChangedListener onScrollChangedListener;
    private readonly int scaledTouchSlop;
    private int separationUnit;
    private float stepSize;
    private readonly android.graphics.Paint stopIndicatorPaint;
    private int thumbHeight;
    private bool thumbIsPressed;
    private readonly android.graphics.Paint thumbPaint;
    private int thumbTrackGapSize;
    private int thumbWidth;
    private int tickActiveRadius;
    private android.content.res.ColorStateList tickColorActive;
    private android.content.res.ColorStateList tickColorInactive;
    private int tickInactiveRadius;
    private bool tickVisible;
    private float[] ticksCoordinates;
    private float touchDownX;
    private readonly java.util.List<T> touchListeners;
    private float touchPosition;
    private android.content.res.ColorStateList trackColorActive;
    private android.content.res.ColorStateList trackColorInactive;
    private int trackHeight;
    private int trackInsideCornerSize;
    private readonly android.graphics.Path trackPath;
    private readonly android.graphics.RectF trackRect;
    private int trackSidePadding;
    private int trackStopIndicatorSize;
    private int trackWidth;
    private float valueFrom;
    private float valueTo;
    private java.util.List<java.lang.float> values;
    private int widgetHeight;
    static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_Slider;
    private static readonly int LABEL_ANIMATION_ENTER_DURATION_ATTR = com.google.android.material.R$attr.motionDurationMedium4;
    private static readonly int LABEL_ANIMATION_EXIT_DURATION_ATTR = com.google.android.material.R$attr.motionDurationshort3;
    private static readonly int LABEL_ANIMATION_ENTER_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedInterpolator;
    private static readonly int LABEL_ANIMATION_EXIT_EASING_ATTR = com.google.android.material.R$attr.motionEasingEmphasizedAccelerateInterpolator;

    public static void $r8$lambda$WXiNVeXFM7RTh57Z9Tr5jBbN9l4(com.google.android.material.slider.BaseSlider baseSlider) {
        sseyVlAGxUxZvbNe(baseSlider);
    }

    public BaseSlider(android.content.object context) {
        this(context, null);
    }

    public BaseSlider(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.sliderStyle);
    }

    public BaseSlider(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(cgRONZCXmceShKHk(context, attributeHashSet, i, DEF_STYLE_RES), attributeHashSet, i);
        if ((15 + 4) % 4 > 0) {
        }
        this.labels = new java.util.List();
        this.changeListeners = new java.util.List();
        this.touchListeners = new java.util.List();
        this.labelsAreAnimatedIn = false;
        this.defaultThumbWidth = -1;
        this.defaultThumbTrackGapSize = -1;
        this.thumbIsPressed = false;
        this.values = new java.util.List<>();
        this.activeThumbIdx = -1;
        this.focusedThumbIdx = -1;
        this.stepSize = 0.0f;
        this.tickVisible = true;
        this.islongPress = false;
        this.trackPath = new android.graphics.Path();
        this.trackRect = new android.graphics.RectF();
        this.cornerRect = new android.graphics.RectF();
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        this.defaultThumbDrawable = materialShapeDrawable;
        this.customThumbDrawablesForValues = BuwscNdzzwElKtLn();
        this.separationUnit = 0;
        this.onScrollChangedListener = new com.google.android.material.slider.BaseSlider$$ExternalSyntheticLambda0(this);
        android.content.object contextBETvNpNQZhIUiOlC = bETvNpNQZhIUiOlC(this);
        this.inactiveTrackPaint = new android.graphics.Paint();
        this.activeTrackPaint = new android.graphics.Paint();
        android.graphics.Paint paint = new android.graphics.Paint(1);
        this.thumbPaint = paint;
        wNJYtZlymASVJSEw(paint, android.graphics.Paint$Style.FILL);
        rXiADOdnYKhmMkwX(paint, new android.graphics.PorterDuffXfermode(android.graphics.PorterDuff$Mode.CLEAR));
        android.graphics.Paint paint2 = new android.graphics.Paint(1);
        this.haloPaint = paint2;
        MOeVRjWmFQBFcTzl(paint2, android.graphics.Paint$Style.FILL);
        android.graphics.Paint paint3 = new android.graphics.Paint();
        this.inactiveTicksPaint = paint3;
        lmVoQdveVwFOJsBQ(paint3, android.graphics.Paint$Style.STROKE);
        vVhLcDwjydUexrhN(paint3, android.graphics.Paint$Cap.ROUND);
        android.graphics.Paint paint4 = new android.graphics.Paint();
        this.activeTicksPaint = paint4;
        cYpswiRMUzzQHXqe(paint4, android.graphics.Paint$Style.STROKE);
        VMXyycUTSAevxIaL(paint4, android.graphics.Paint$Cap.ROUND);
        android.graphics.Paint paint5 = new android.graphics.Paint();
        this.stopIndicatorPaint = paint5;
        mHxmOqaCdIbUfdXl(paint5, android.graphics.Paint$Style.FILL);
        ITyuedJXCqZiNzIR(paint5, android.graphics.Paint$Cap.ROUND);
        rvRNzObVGJDbobVt(this, LfMqQxiTKvPZjECc(contextBETvNpNQZhIUiOlC));
        DqFpymYFfHgGaaPV(this, contextBETvNpNQZhIUiOlC, attributeHashSet, i);
        WwhDIkbSaoELnSeT(this, true);
        AecFXHjsUmKGTxle(this, true);
        SFnZImhqngxEuQpQ(materialShapeDrawable, 2);
        this.scaledTouchSlop = rIHtfWsmNMhtqwAe(mgOkktmpWJydcssh(contextBETvNpNQZhIUiOlC));
        com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper = new com.google.android.material.slider.BaseSlider$AccessibilityHelper(this);
        this.accessibilityHelper = baseSlider$AccessibilityHelper;
        GRlwIERKUnjImvaT(this, baseSlider$AccessibilityHelper);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) nboInmXXyIlrazRQ(BXHoECbfVajhYYrQ(this), "accessibility");
    }

    public static com.google.android.material.shape.ShapeAppearanceModel AGBBsEHkzuKZlcOo(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static float AGXrAADOhZwDQlVU(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static void AHFFHyiehzmUUjyl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static java.lang.stringBuilder AHQjHWKBNRogBNAe(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int ALCrmXBhmSsOsUQb(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ALmZMcojpkAtQdij(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnScrollChangedListener viewTreeObserver$OnScrollChangedListener) {
        viewTreeObserver.addOnScrollChangedListener(viewTreeObserver$OnScrollChangedListener);
    }

    public static bool AMhuMHVLfzJDsGfU(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Rect rect) {
        return baseSlider.getLocalVisibleRect(rect);
    }

    public static void ANjtGFmlfCXSjFVu(android.graphics.Canvas canvas, android.graphics.Path path, android.graphics.Paint paint) {
        canvas.drawPath(path, paint);
    }

    public static float AQFZmcLIOcWFcYUu(float f) {
        return java.lang.Math.abs(f);
    }

    public static void ASeiAGORNqfhIIov(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static int ATJYPkPDbODtGUtG(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static float ATZsqMngHUcnRHlo(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static int AXQlDMdivWYOHRRJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.graphics.drawable.Drawable AcIeumKEfHqxAXko(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static void AcRBUodjWAnwqtIw(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2, float f, android.graphics.drawable.Drawable drawable) {
        baseSlider.drawThumbDrawable(canvas, i, i2, f, drawable);
    }

    public static bool AdBonwZaVpTxrUQI(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static void AecFXHjsUmKGTxle(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        baseSlider.setClickable(z);
    }

    public static void AgVzwKBjIaGdaYfi(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.updateTrackWidth(i);
    }

    public static int AkNdTeoxVCZnQZCX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool AlDrttOXdmEzlXyx(com.google.android.material.slider.BaseSlider baseSlider, java.lang.Action runnable, long j) {
        return baseSlider.postDelayed(runnable, j);
    }

    public static float AnokIfACYblgTDnT(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static float AvXWqOrqkQJcMaEC(float f, float f2, float f3) {
        return androidx.core.math.MathUtils.clamp(f, f2, f3);
    }

    public static bool AxbflMOIjTkMQBgu(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void AyxxXImXHxkeVYkJ(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static double BEbPFxlJXisZYzOB(double d) {
        if ((25 + 9) % 9 > 0) {
        }
        return java.lang.Math.abs(d);
    }

    public static java.lang.float BFRBNedpuyDjBzFO(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.string BFiUIqzdHWzyCjLC(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void BFxdEjOmmFMMiZBI(android.view.object view, android.graphics.Canvas canvas) {
        super.onDraw(canvas);
    }

    public static void BIlgtRUhtlDfvYmD(android.view.objectGroup viewGroup, android.view.object view, android.graphics.Rect rect) {
        com.google.android.material.internal.DescendantOffsetUtils.offsetDescendantRect(viewGroup, view, rect);
    }

    public static void BJTBzwuOTWBQsQyx(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        baseSlider.setValueForLabel(tooltipDrawable, f);
    }

    public static int BORbkivzhiiGkekr(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static void BOYNBeJpIlVyjwLB(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateWidgetLayout();
    }

    public static int BTRWUuDmsnyiohsG(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static android.content.object BXHoECbfVajhYYrQ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static float BYZUcBGDayuihFvu(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int BctUzxrglHYWrAHS(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static android.graphics.drawable.Drawable BqRzYCiZUFSTTWsx(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        return baseSlider.initializeCustomThumbDrawable(drawable);
    }

    public static java.util.List BuwscNdzzwElKtLn() {
        return java.util.ICollections.emptyList();
    }

    public static bool BxsORJRkpIZqaSdO(com.google.android.material.slider.BaseSlider baseSlider, java.lang.Action runnable) {
        return baseSlider.removeCallbacks(runnable);
    }

    public static float ByrOpIDncDXvVzBH(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static void BzaCUTwrBWrohcnb(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static void CAEwNCIEDcYIRLiA(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static int CAIeqUqQNdbFERLs(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getIntrinsicHeight();
    }

    public static java.lang.float CCIDYbsMjVwwoFrA(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void CFEfrVLaZJXLBMRV(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static bool CKtsBXcPDDsBziSb(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object CLqcTsznbOnLqCfD(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool CNnpuDNAKQKKlJIw(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.isStateful();
    }

    public static void CTJDNKTtBrRGZKyP(android.graphics.drawable.RippleDrawable rippleDrawable, android.content.res.ColorStateList colorStateList) {
        rippleDrawable.setColor(colorStateList);
    }

    public static int CWwcpdDfxvICocoY(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getWidth();
    }

    public static void CYDcTZKDmkuyOXjT(android.graphics.Paint paint, bool z) {
        paint.setAntiAlias(z);
    }

    public static java.lang.int CYmjrhLPAebXZIhr(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int CbeoPAhFhClHnaEr(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static bool CdKgKDDppwzBpbGN(android.view.object view, android.view.MotionEvent motionEvent) {
        return super.dispatchHoverEvent(motionEvent);
    }

    public static void CeLdMfbiWFXVNNHN(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTrackInactiveTintList(colorStateList);
    }

    public static bool ChaJycszlERFcVoA(android.view.objectGroup viewGroup, int i) {
        return viewGroup.canScrollVertically(i);
    }

    public static bool CivLzayUovufJEtZ(android.view.MotionEvent motionEvent) {
        return isMouseEvent(motionEvent);
    }

    public static float CmGOgfihsVeKAwGC(java.lang.float f) {
        return f.floatValue();
    }

    public static void CmQnIQEiNtAYlwfK(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.object CmYFNymYIgnSJEoc(java.util.List arrayList, int i, java.lang.object obj) {
        return arrayList.set(i, obj);
    }

    public static bool CqyRyFXcFldKjFMQ(android.view.object view, android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent);
    }

    public static void CucEbuVHYIslHGRK(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static bool CxOXfoynPKwruSSi(com.google.android.material.slider.BaseSlider baseSlider, double d) {
        return baseSlider.isMultipleOfStepSize(d);
    }

    public static float DAOLyiGZsGryOTIw(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static android.graphics.drawable.Drawable DCrSSSFQCKwdlvIB(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static int DGIKHyybkWUgRBiB(android.graphics.Rect rect) {
        return rect.height();
    }

    public static float DGzwVkZlATeuSxOn(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object DLYeoBGlEXjqDZjx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DNEOVeNErUBQcBGA(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2) {
        baseSlider.drawActiveTrack(canvas, i, i2);
    }

    public static android.animation.ValueAnimator DPoDhbyZmDGWJjDv(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        return baseSlider.createLabelAnimator(z);
    }

    public static int DQIdJJGNOuIIyVgp(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool DUIbAvSVlEgfnpdU(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocusInAbsoluteDirection(i);
    }

    public static bool DWBJsyERwtgCBcSt(com.google.android.material.slider.BaseSlider baseSlider, android.view.MotionEvent motionEvent) {
        return baseSlider.isPotentialVerticalScroll(motionEvent);
    }

    public static bool DYnKvtoKuhlLHpqZ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasLabelFormatter();
    }

    public static void DdXiekEPsSocMEHz(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static void DkISUJdLcBIJkXjM(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbRadius(i);
    }

    public static java.lang.bool DlFZIHNgUCWgVXwz(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool DmZKFaWBfmgTNDxf(com.google.android.material.slider.BaseSlider baseSlider, double d) {
        return baseSlider.isMultipleOfStepSize(d);
    }

    public static void DqFpymYFfHgGaaPV(com.google.android.material.slider.BaseSlider baseSlider, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        baseSlider.processAttributes(context, attributeHashSet, i);
    }

    public static void ECpdcOSSeMFeuOnU(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.adjustCustomThumbDrawableBounds(drawable);
    }

    public static float EHdtnNMAGdEpDhLw(java.lang.float f) {
        return f.floatValue();
    }

    public static int EIhmotIfjLrREImD(float f) {
        return java.lang.Math.round(f);
    }

    public static int EWMTqBDsAcVaVmEl(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool EbzTflxFRlzhVyth(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void EiqYOwjdFRlZevcO(android.view.objectParent viewParent, bool z) {
        viewParent.requestDisallowInterceptTouchEvent(z);
    }

    public static bool EirymmAKDqqFohIL(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static void EjOwzyDlCirTYUIG(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static java.lang.string EjczoIPLyJoZNfAU(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void EmYlkMdUBxUFvtxg(com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener, java.lang.object obj) {
        baseOnSliderTouchListener.onStopTrackingTouch(obj);
    }

    public static int FCKJxcxqeadSwvlh(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.string FEBHUjGrpZCOhTZr(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int FLrvjPjfjDBKvjSA(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void FLyyaVILwCGwqPjX(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static int FOPaTeTUzTVccmNY(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getPaddingBottom();
    }

    public static java.lang.object FQKiRKnWGVweIFiu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void FTlmkROjwCEIJpby(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static bool FUUvumcLkhwhDHJR(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static java.lang.float FZzpYKyEuUEsbIhW(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void FbGQIipUKGisdolY(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.onStartTrackingTouch();
    }

    public static void FeHyCkIwHzACITHj(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialShapeDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void FexUkGBSgPThGwPi(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static int FfEKCqXpqTliceED(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static int FiGPiAUGPAXrNHJb(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateTrackCenter();
    }

    public static long FiRircBtkmTHZEFe(double d) {
        if ((27 + 3) % 3 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static void FjeomqyaWJDmtOCk(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void FjoqFoViqylBFDQH(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int[] FklMNvrcPpxpBcGs(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getDrawableState();
    }

    public static bool FrSepHlCKixggECA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static bool FuObNFkVsWBMbqJB(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocusInAbsoluteDirection(i);
    }

    public static int FuhdTwEYVjDTegIg(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void FxPuoHDZhUIYsufN(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static java.lang.float GFXNHzGUiWstdbOx(float f) {
        return java.lang.float.valueOf(f);
    }

    public static android.view.objectParent GFlckztzetqEoGWI(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getParent();
    }

    public static float GOxWCmEhpwzJCxmq(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.dimenToValue(f);
    }

    public static void GPUBBhcEIFADpnET(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.ensureLabelsAdded();
    }

    public static bool GPmMVokMDlVrunyO(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static void GRlwIERKUnjImvaT(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static java.lang.object GXGmzWczmkTTdcGb(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void GacZsvgFBQgTwFDu(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbWidth(i);
    }

    public static int GcHJgFlktKWhoGbp(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static java.lang.float GcHdMYSfGKllZLSq(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float GjJnQMLXUSjwUTPS(java.lang.float f) {
        return f.floatValue();
    }

    public static void GkSiGsRlgjxSJrps(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void GngZEvnQnecEBDog(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static com.google.android.material.tooltip.TooltipDrawable GpHHkhTHtAESessq(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.tooltip.TooltipDrawable.createFromAttributes(context, attributeHashSet, i, i2);
    }

    public static void GtJdTTvnaBpVsbuc(android.graphics.Path path) {
        path.reset();
    }

    public static android.graphics.drawable.Drawable GtkKFGZHabcPExfl(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getBackground();
    }

    public static bool GtpLrOEBlDyFRyrN(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyUp(i, keyEvent);
    }

    public static void HDwEtQGpWQDyKPyI(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.ensureLabelsRemoved();
    }

    public static bool HIwHXIrajLMnEGxX(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void HNsSiqvYcEAkIJuN(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static bool HOkUkbSyZqKvsLeW(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        return baseSlider$AccessibilityHelper.requestKeyboardFocusForVirtualobject(i);
    }

    public static int HQPelJsBsLlrrekV(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.float HUcjKOkwVYQyYfOR(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void HVjadZcNCbbWOYUx(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void HYlPSXJqzQVYPhKl(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static java.lang.float HcMGlYujDrwcYcyM(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool HdhjjwEqKvjaQVbA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.snapTouchPosition();
    }

    public static java.util.IEnumerator HfwdFsXgpwClrTym(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    public static void HikXodaokLrynMyy(android.graphics.Canvas canvas, float f, float f2, float f3, android.graphics.Paint paint) {
        canvas.drawCircle(f, f2, f3, paint);
    }

    public static android.content.object HjmpKefwBnwQbWvh(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static java.lang.string HkPRMBLCQAYskrTc(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static android.graphics.drawable.Drawable HoCRHZzFiqbOVctj(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getBackground();
    }

    public static void HqhMqEJIWldoqUoy(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateMinSeparation();
    }

    public static int HraMacAajhQsJyEJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void IBuYoXvnVhGOaAoX(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setTrackHeight(i);
    }

    public static float IKpfRTiZijKDTFaY(java.lang.float f) {
        return f.floatValue();
    }

    public static void IMLEeIWPiocGZinf(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.dispatchOnChangedProgrammatically();
    }

    public static bool INHIYWKiYEYJqtDm(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static float IPiihxLNMFIXzOIL(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static int IRMHcVpoqhZyIbkn(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void ITyuedJXCqZiNzIR(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void IVzwjkngrfMYHSIu(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void IWtkBORTdZFSZMYL(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void IZSEYskJQcnAKVgQ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.bool IftoSETWJKRRiEZc(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int IiXGnCGbLZCUiKcu(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static double IlUVXJztGLolbidE(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        if ((25 + 10) % 10 > 0) {
        }
        return baseSlider.snapPosition(f);
    }

    public static void IocGgoAYZrspncUx(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static float[] IqNweiILuuacgVLk(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getActiveRange();
    }

    public static void IvFgnuNdYbaTFZLn(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTickInactiveTintList(colorStateList);
    }

    public static java.util.IEnumerator IxCevOhJOoQYOdIz(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void IxgjwwFaySEXQUYa(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void JEgGbPFEoBCAnaVk(com.google.android.material.slider.BaseOnSliderTouchListener baseOnSliderTouchListener, java.lang.object obj) {
        baseOnSliderTouchListener.onStartTrackingTouch(obj);
    }

    public static bool JKxZcHNyVJetCmgH(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocusInAbsoluteDirection(i);
    }

    public static java.util.IEnumerator JRInTEDMXyklzpJg(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void JTlkbdHpSldkTpzg(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, int i, int i2, int i3, int i4) {
        tooltipDrawable.setBounds(i, i2, i3, i4);
    }

    public static float JdCmzhjDQamXzlgu(java.lang.float f) {
        return f.floatValue();
    }

    public static bool JeGbtixeMVNgdEQd(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasFocus();
    }

    public static java.util.IEnumerator JehlyaIEpDukwQjn(java.util.List list) {
        return list.GetEnumerator();
    }

    public static float JiDYQTwLXGHtnQHH(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    public static bool JjVFXADihSSMVwoj(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.pickActiveThumb();
    }

    public static void JlRHemEhZnQMVHAY(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.RectF rectF, com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        baseSlider.updateTrack(canvas, paint, rectF, baseSlider$FullCornerDirection);
    }

    public static bool JluPFHPHeKOlBoRl(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    public static bool JoukfuYPJnlvkpbl(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueLandsOnTick(f);
    }

    public static void JvTbqsDjdzqgTlUG(android.view.objectGroup viewGroup, android.graphics.Rect rect) {
        viewGroup.getHitRect(rect);
    }

    public static float JzastRKRHlMplXiu(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    public static java.lang.float KBbwgsUfyfdrErPG(float f) {
        return java.lang.float.valueOf(f);
    }

    public static android.content.res.ColorStateList KBjTqesAdnbUvecq(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void KDMpAwAhhvdWGnNt(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.setCustomThumbDrawable(drawable);
    }

    public static android.view.objectGroup KDqAHpflGyXgXYKv(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobject(view);
    }

    public static void KHohSlrhauFOMqSy(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTickInactiveTintList(colorStateList);
    }

    public static void KQxUYjooGADiOzgw(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        androidx.core.graphics.drawable.DrawableCompat.setHotspotBounds(drawable, i, i2, i3, i4);
    }

    public static void KSoITdWUGHYsxfWj(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2) {
        baseSlider.drawThumbs(canvas, i, i2);
    }

    public static java.lang.object KYPXtJTIaZVUpotP(java.util.List list, int i) {
        return list[i);
    }

    public static void KafMbwJtYPcHuKrN(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.scheduleAccessibilityEventSender(i);
    }

    public static int KczkSTURiwAYRTyV(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool KfXZuebcOHShANyS(android.view.KeyEvent keyEvent) {
        return keyEvent.isShiftPressed();
    }

    public static float KgcyioBGayoMBast(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueOfTouchPosition();
    }

    public static void KjiUeUSQXFjRtbnW(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawLine(f, f2, f3, f4, paint);
    }

    public static android.os.Parcelable KnqFLZABeBOLSktX(com.google.android.material.slider.BaseSlider$SliderState baseSlider$SliderState) {
        return baseSlider$SliderState.getSuperState();
    }

    public static float KouCNgdltwCJhubz(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getMinSeparation();
    }

    public static void KzutijKxtGVmKEpO(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        baseSlider.setThumbStrokeWidth(f);
    }

    public static void LDwOpNqCpPpconFm(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbTrackGapSize(i);
    }

    public static float LFSJbqlSAGCauhAR(java.lang.float f) {
        return f.floatValue();
    }

    public static float LJoknPcNsqBAZXDh(java.lang.float f) {
        return f.floatValue();
    }

    public static int LJsvPNQFTuPNmNmB(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getPaddingTop();
    }

    public static android.content.res.Resources LLbEqaYwJDytqKTk(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static void LNGnsxTiaJCvEKuf(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static com.google.android.material.internal.objectOverlayImpl LSgnkxTvozuzRQjf(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobjectOverlay(view);
    }

    public static android.content.res.Resources LcHtyHJuXTkfEotA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static android.content.res.Resources LfMqQxiTKvPZjECc(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.float LgQVAmQQofOlvlsF(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int LhLnmfjAhJiZNpbf(java.util.List list) {
        return list.Count;
    }

    public static bool LilLcmbnbrLcPCkt(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.snapActiveThumbToValue(f);
    }

    public static com.google.android.material.internal.objectOverlayImpl LjjeyzcEbhsrIUAI(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobjectOverlay(view);
    }

    public static bool LjsQfDzWzNrbQgjt(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.requestFocus();
    }

    public static java.lang.bool LmgCrgswkqSwSeZb(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static float LooHprkLgTsxGjpH(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getMinSeparation();
    }

    public static void MIvEtikFzPPsZUeS(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void MKliwldJQsehGATC(android.view.object view, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(parcelable);
    }

    public static void MLXPNZztLMVkmsCu(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void MOeVRjWmFQBFcTzl(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static bool MPWHvgslxsQrKEAa(android.view.objectGroup viewGroup) {
        return viewGroup.shouldDelayChildPressedState();
    }

    public static bool MVCbhBbYxzVrphLY(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.maybeIncreaseWidgetHeight();
    }

    public static java.lang.float MXTyKVUjXtrRojFH(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool MXrGTOxlnzagvZpW(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static void MYUpavDBnEZNscmo(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.object MZKzUUwHbzKueMPv(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.float MbUBwfkkBjOHHagy(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float MmPxJHPevQqhMEtU(java.lang.float f) {
        return f.floatValue();
    }

    public static long MscmkweDWjKBTJFT(long j, long j2, long j3) {
        if ((15 + 28) % 28 > 0) {
        }
        return androidx.core.math.MathUtils.clamp(j, j2, j3);
    }

    public static bool MuMCVVeNDxOUyTpe(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static bool MwUqaDbJvftioLww(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int MxIhLmtBYREuznut(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.float MxLTFJqPJCfipsUy(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void MxjzBmXtYtJPWrOq(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateWidgetLayout();
    }

    public static java.lang.string MztkGroEmukllniO(com.google.android.material.slider.LabelFormatter labelFormatter, float f) {
        return labelFormatter.getFormattedValue(f);
    }

    public static float NAGZwSRuqftiMLDd(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeWidth();
    }

    public static int NApsegcxCpJckrtl(java.util.List list) {
        return list.Count;
    }

    public static bool NBGviKWzPefKwCoe(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static void NEgvgAJwlkVbDkst(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbHeight(i);
    }

    public static int NJLJljkdYvzvWmWk(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static bool NJdszTIOTdYPGSkh(android.view.KeyEvent keyEvent) {
        return keyEvent.islongPress();
    }

    public static int NLqmncSNjUvkfPhz(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int NMrwPVlOXoDGEkcE(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static float NOwIwdJlZYbUkaFO(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static bool NScgbKWNFrQEPVSQ(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return baseSlider.snapThumbToValue(i, f);
    }

    public static void NZsQUbGYvPPJFOSI(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static android.content.object NbbjGzZjZttglJWL(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static void NdQQDrericpqIFIm(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static java.lang.object NeeaEueejYkFWcFh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NqJpKpYsLVUmeRGq(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static float OAwdwzTBfLmuFkMW(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object OBNEejnhDKsLDZfn(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void OEUynYzMrbVuBqWd(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.adjustCustomThumbDrawableBounds(drawable);
    }

    public static void OGmLFdRbkzCLuAZp(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void OPtPsBSPonrsZVKR(android.animation.ValueAnimator valueAnimator, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        valueAnimator.addListener(animator$AnimatorListener);
    }

    public static int OUJzhDIMXycrzZpm(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getMeasuredWidth();
    }

    public static java.lang.float OYqPfQUOiGrVeHaD(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float OhKQUyZnYyzGvtno(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static java.util.IEnumerator OmBEoKJqOHfeZXjx(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object OpoEFvkDbBXBwpDd(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void PBqAuAhDlMKkzSVD(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawLine(f, f2, f3, f4, paint);
    }

    public static void PBxnVKYcSTZkuCNP(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setTickActiveRadius(i);
    }

    public static void PDbztdBlLfwCkCQv(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setHaloRadius(i);
    }

    public static bool PHAaXAiirPPYlkFN(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.maybeIncreaseTrackSidePadding();
    }

    public static void PKXsikJyZIvyzMHU(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void PKkHBEJFoARDtXgY(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static int PYzYepKQwTkBniwd(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void PZMXihNYiFeNuzDM(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.maybeCalculateTicksCoordinates();
    }

    public static float PZiOkDIwnAXcXZzl(java.lang.float f) {
        return f.floatValue();
    }

    public static int PbeCVEBqhJgURupB(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int PcrgqsgIjaTWgKqt(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void PfExPOGBCmQSvMdX(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        baseSlider.detachLabelFromContentobject(tooltipDrawable);
    }

    public static bool PmFxCUsGptkPFbXt(com.google.android.material.slider.BaseSlider baseSlider, java.lang.Action runnable) {
        return baseSlider.removeCallbacks(runnable);
    }

    public static void PnpVsdzPnbSHtPuk(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.ensureLabelsAdded();
    }

    public static void PqoKrEwOBhZzuxBH(android.view.object view, bool z) {
        super.setEnabled(z);
    }

    public static java.lang.string PwNYEjjniMjsuhYs(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.formatValue(f);
    }

    public static bool PwdvXEoTmZqLjmph(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static void QAMuJDDOdtUCKPHv(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateValues();
    }

    public static float QBaaDUTHmKLDJwNr(float f) {
        return java.lang.Math.abs(f);
    }

    public static android.view.objectParent QErbRkqUkWIaPKbx(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static void QIZPWUrpHhfQNJxk(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void QLjzYDudvtcSLlQN(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.RectF rectF, com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        baseSlider.updateTrack(canvas, paint, rectF, baseSlider$FullCornerDirection);
    }

    public static android.view.objectGroup QPzOeJdnFrZyLqVO(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobject(view);
    }

    public static android.content.res.ColorStateList QSTOcsfeifBqnMAt(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static float QSrUqmgTrghrEjnj(java.lang.float f) {
        return f.floatValue();
    }

    public static float QTsEVIHazKBONLZh(float f) {
        return java.lang.Math.abs(f);
    }

    public static android.content.res.Resources QWmMMCJSLcxzPsXM(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static void QbsJUDDFfpEbESbS(android.graphics.Canvas canvas, float[] fArr, int i, int i2, android.graphics.Paint paint) {
        canvas.drawPoints(fArr, i, i2, paint);
    }

    public static int QdBzfgEnoMghwQKT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void QjyHtBcqOeGspTIZ(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static java.lang.object QlZqVFweUFPlmTtB(java.util.List list, int i) {
        return list[i);
    }

    public static float QsOwWZJJSlkHbrqp(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static int QtSpKfhGNbPsWrrm(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static void QykDOiFhwjxNWDLh(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbWidth(i);
    }

    public static android.content.object RATYdCPchbMNrJEQ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static void RChQhRlIFjLNVARn(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        baseSlider.attachLabelToContentobject(tooltipDrawable);
    }

    public static void RGrxtZsVjiidGRKA(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static float RJbNsRCfRHZjLmxB(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static void RKvEMlCAElKZIfyD(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Remove(drawable);
    }

    public static int RMSSWRHWNWlxrmyU(float f) {
        return java.lang.Math.round(f);
    }

    public static void RPLMGGMnuDgAQDys(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.onStartTrackingTouch();
    }

    public static bool RPMIPTpUdKgNndOB(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static bool RSOqjCnAdJmVjalA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static float RWjXKxpNfqLutObJ(float f) {
        return java.lang.Math.abs(f);
    }

    public static void RYfeyExayksxgCYM(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        baseSlider.detachLabelFromContentobject(tooltipDrawable);
    }

    public static java.lang.bool RbqvPdwObdeZABwV(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void RshbIitJTGJoJYTf(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Remove(drawable);
    }

    public static void RvPBFeeTfpcLhVfj(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setLabelBehavior(i);
    }

    public static bool RxycKMcmHyUKgijy(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static android.view.objectTreeObserver SBIHykCiItDhAdUU(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobjectTreeObserver();
    }

    public static void SFnZImhqngxEuQpQ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setShadowCompatibilityMode(i);
    }

    public static void SIpgAbazobcZYBQB(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2, float f, android.graphics.drawable.Drawable drawable) {
        baseSlider.drawThumbDrawable(canvas, i, i2, f, drawable);
    }

    public static void SJOtDgvhTAxBjPiZ(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void SZfSfEDhjDiYQDmO(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbHeight(i);
    }

    public static java.lang.string ScDyrcnfrvcnIWGz(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static float SddYPOTcLmlZFKgS(java.lang.float f) {
        return f.floatValue();
    }

    public static int SdxiqPIfFQCOyRle(android.graphics.Rect rect) {
        return rect.width();
    }

    public static int StiebdPoKPpouEhE(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.string StviAUubmYZtBtlW(java.lang.Class cls) {
        return cls.getName();
    }

    public static void TBDbrysTmpuRndGq(com.google.android.material.internal.objectOverlayImpl viewOverlayImpl, android.graphics.drawable.Drawable drawable) {
        viewOverlayImpl.Add(drawable);
    }

    public static void TCmTEfYruMsEDEgu(com.google.android.material.slider.BaseSlider baseSlider, java.lang.float[] fArr) {
        baseSlider.setValues(fArr);
    }

    public static int TDomPsduzqCNWheR(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static java.lang.float TGFAEmmaaXeLhKQd(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool TIjlutIiKCHwUpgf(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void TJhJKgdxhDgBRhpy(com.google.android.material.slider.BaseSlider$AccessibilityEventSender baseSlider$AccessibilityEventSender, int i) {
        baseSlider$AccessibilityEventSender.setVirtualobjectId(i);
    }

    public static void TKwWSSLhCNQHndlO(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static java.lang.float TOCwGCQBVWntiqoZ(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.object TQhEOlJOcDvxuhcq(java.util.List list, int i) {
        return list[i);
    }

    public static void TRYJxxtmSOFJDQpS(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static void TYxuCAYNjvHyBeNE(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateStepSize();
    }

    public static bool TkQinCUUlMOCITBx(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void TnDKOxSNUnFjTHzB(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int TnMkbCwBULcJBdSn(float f) {
        return java.lang.Math.round(f);
    }

    public static void TnfHXyZxccSTRecu(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        baseSlider.setThumbElevation(f);
    }

    public static java.lang.string TnsrUNscLUbnOYTU(float f) {
        return java.lang.float.tostring(f);
    }

    public static double TpPPQZWfbMQIkFcC(double d) {
        if ((25 + 12) % 12 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static int TrZgRjCTGTAQNZOg(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool TszYWenGOCqKRMHR(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isInVerticalScrollingContainer();
    }

    public static java.lang.object TtIWOxKAyKzKZSYS(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int TwGzFVsKXbxpOprE(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static void TwqJlRHRrAwuExGa(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static float TxAhHpPGNjTkGToV(java.lang.float f) {
        return f.floatValue();
    }

    public static void TxxQHDJqRTLTZRDT(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTickActiveTintList(colorStateList);
    }

    public static void UAhNlSWQsqXxBPmj(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.dispatchOnChangedFromUser(i);
    }

    public static android.content.object UBkkZkqipWxTbdRo(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static float UBmyUEgjvpYxwKvx(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return baseSlider.getClampedValue(i, f);
    }

    public static android.content.object UDRfRMGTsPiqISXv(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static java.lang.object UGjXHfmKACtpYhBc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.view.objectParent UHtxLUuejsGXJwKM(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getParent();
    }

    public static void ULuZFBCyVgqHJpnh(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTrackActiveTintList(colorStateList);
    }

    public static void ULySNpZRvqFbqbfU(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static int URdsoFauSkNeOiqV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int UdjKpBQXhoxreUUg(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static float UkzujZcHKFoCRrym(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object UlCtNbAekvtVpqPQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator UqULjwReInwoTKqn(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool UsECgUhZkyRvgkXi(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static int UsqdUFtLcLUeEvSs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static java.lang.string UzKlDvmxBcbUEoNx(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool UzfpeLZbapdADPCa(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static float VAxEHarNTvNnaijB(java.lang.float f) {
        return f.floatValue();
    }

    public static void VBjdPyzaKppULOEr(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static java.lang.float VDZFAkFfreFvDLeB(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int VDglFbNUZxnftUWF(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void VMXyycUTSAevxIaL(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static android.view.MotionEvent VWgHqsWBtRZPvFhd(android.view.MotionEvent motionEvent) {
        return android.view.MotionEvent.obtain(motionEvent);
    }

    public static float VZRAmRkatJGqYmZw(java.lang.float f) {
        return f.floatValue();
    }

    public static android.content.res.ColorStateList VaKfYECRglHVvGFL(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void VaqWlTWhNPeIZNVc(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void VdnKbZndFZMKxITC(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.adjustCustomThumbDrawableBounds(drawable);
    }

    public static float VgkThxVSatSYvWSK(java.lang.float f) {
        return f.floatValue();
    }

    public static void VhrHDYuxnmYkakmP(com.google.android.material.slider.BaseSlider baseSlider, java.util.List arrayList) {
        baseSlider.setValuesInternal(arrayList);
    }

    public static float VlQzYObvMtlasMkT(java.lang.float f) {
        return f.floatValue();
    }

    public static android.content.res.ColorStateList VlcajPPJewNHcDGY(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static bool VyKDIjDutTTTMMqp(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.snapTouchPosition();
    }

    public static int WBtXoKAMOFgmdlRg(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getIntrinsicWidth();
    }

    public static java.util.List WCmAwRLKPNDiDtFC(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValues();
    }

    public static java.lang.string WDTjyuBJXDWcugcg(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int WPVrYtLZbmTxhIqH(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static android.view.objectGroup WRfGgAOzlXqEMRHW(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobject(view);
    }

    public static bool WYAvGhULpXKFvleq(android.view.KeyEvent keyEvent) {
        return keyEvent.hasNoModifiers();
    }

    public static float WYtpdKdNRyiWeZQG(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    public static double WYvHiiHuUfPWdUzp(java.math.decimal bigDecimal) {
        if ((20 + 22) % 22 > 0) {
        }
        return bigDecimal.doubleValue();
    }

    public static int WamWzFNVHXWLbAbp(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static android.graphics.drawable.Drawable WeVOnjQzLgyrMCvP(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        return baseSlider.initializeCustomThumbDrawable(drawable);
    }

    public static double WiHSkaLMYxxfxuBK(java.math.decimal bigDecimal) {
        if ((2 + 27) % 27 > 0) {
        }
        return bigDecimal.doubleValue();
    }

    public static float WjYquYwKtYDIFpez(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    public static android.content.res.ColorStateList WkcvtWrjxtnTDmPY(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static float[] WkxokxMZZHKBSBjm(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getActiveRange();
    }

    public static com.google.android.material.internal.objectOverlayImpl WndlbhIAnIHlVemh(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobjectOverlay(view);
    }

    public static void WwhDIkbSaoELnSeT(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        baseSlider.setFocusable(z);
    }

    public static java.util.IEnumerator WyXFZpKRaFLxqGhb(java.util.List list) {
        return list.GetEnumerator();
    }

    public static float XBCeuWIlhWggWqmq(float f) {
        return java.lang.Math.abs(f);
    }

    public static void XBOtGZFFCBQGaySh(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbTrackGapSize(i);
    }

    public static float XFAXZNwtKEPWKpOr(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    public static bool XLVJYvKOeKGoCnYV(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.requestFocus();
    }

    public static java.lang.float XmZWVHZwjeEpXShS(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.calculateIncrementForKey(i);
    }

    public static bool XondyPKCxBueXZkS(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void XrBkTvRVEvuxuCes(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static bool YAxcmtlHkqYwviQb(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static void YBFlpwlpEQQNdJpj(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static int YFjOxCRiRpfsiCmh(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateTrackCenter();
    }

    public static void YHXkdQXEuxMBMLmD(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setTrackStopIndicatorSize(i);
    }

    public static void YOkQgsmrkHtijtvu(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        baseSlider.setValueForLabel(tooltipDrawable, f);
    }

    public static int YTTzUgfxPihEbaHr(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.animation.ValueAnimator YVZXatmGzTNgboib(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static float YXxJgmAyqdyWkxDe(java.lang.float f) {
        return f.floatValue();
    }

    public static android.content.res.Resources YaZclZvemtdMMPxu(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static android.graphics.Rect YjVvroVsTWyebNwV(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static java.lang.int YmsTzOcOQssHTLoI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void YpjQliEoFHDNkLmk(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.warnAboutfloatingPointError();
    }

    public static int YrHaXldUyqnOcptJ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateTrackCenter();
    }

    public static java.lang.string YtVaPOvbEAsMUzwT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static float ZJgHpojcJgxZeUgn(java.lang.float f) {
        return f.floatValue();
    }

    public static bool ZNCIOjhgctYdFYeT(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueLandsOnTick(f);
    }

    public static bool ZObDPokXXvLKpWTb(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static void ZZiqhmJyXtlgRIVo(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.view.object view) {
        tooltipDrawable.setRelativeToobject(view);
    }

    public static bool ZbefpxjTKrPDetxw(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isSliderVisibleOnScreen();
    }

    public static void ZhxmhoZmXAXouWbo(java.util.List list) {
        java.util.ICollections.sort(list);
    }

    public static void ZorqQrxtRIgOnone(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static int ZqoCdkXsDNTIEvzL(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object ZruFTyynUOEzXOEa(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object ZtFXlPvbJaFIHfHt(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ZtmoZUdIYJeejgOa(android.view.KeyEvent keyEvent) {
        return keyEvent.hasNoModifiers();
    }

    public static bool ZvEwQzyEUkbSyPYN(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        return baseSlider$AccessibilityHelper.requestKeyboardFocusForVirtualobject(i);
    }

    public static float ZxhZRiIqjUgYjISu(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static void ZzjhflDNqyFGpeqE(android.view.object view) {
        super.drawableStateChanged();
    }

    public static android.graphics.Rect AIYHBySDDlUmNeRG(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getBounds();
    }

    public static android.content.object AJhnEOiBDnuWIoam(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static double ASshkLtWHhepezSW(double d) {
        if ((29 + 32) % 32 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void AXudxDDchLmDeaix(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static void AZFrOFjxyWDTYGLW(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static int AaplhMubOBHLnkdL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    static java.util.List access$000(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.labels;
    }

    static com.google.android.material.slider.BaseSlider$AccessibilityHelper access$200(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.accessibilityHelper;
    }

    static java.lang.string access$400(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return PwNYEjjniMjsuhYs(baseSlider, f);
    }

    static bool access$500(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return mFdFWRhIVQsraGwP(baseSlider, i, f);
    }

    static void access$600(com.google.android.material.slider.BaseSlider baseSlider) {
        CAEwNCIEDcYIRLiA(baseSlider);
    }

    static float access$700(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return yXWBXTGFmUDyAjkU(baseSlider, i);
    }

    public static int AcgeaZcPdZUmqCzd(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    private void AdjustCustomThumbDrawableBounds(android.graphics.drawable.Drawable drawable) {
        if ((21 + 9) % 9 > 0) {
        }
        int iCNRoVfzRfJnZyTHD = cNRoVfzRfJnZyTHD(drawable);
        int iVgUTcCSCgItPcpsQ = vgUTcCSCgItPcpsQ(drawable);
        if (iCNRoVfzRfJnZyTHD == -1 && iVgUTcCSCgItPcpsQ == -1) {
            NqJpKpYsLVUmeRGq(drawable, 0, 0, this.thumbWidth, this.thumbHeight);
        } else {
            float fYDMKfqzpXgGZPiHQ = yDMKfqzpXgGZPiHQ(this.thumbWidth, this.thumbHeight) / URdsoFauSkNeOiqV(iCNRoVfzRfJnZyTHD, iVgUTcCSCgItPcpsQ);
            YBFlpwlpEQQNdJpj(drawable, 0, 0, (int) (iCNRoVfzRfJnZyTHD * fYDMKfqzpXgGZPiHQ), (int) (iVgUTcCSCgItPcpsQ * fYDMKfqzpXgGZPiHQ));
        }
    }

    public static int AiLfWvVrDuGUmbSb(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void AinpBcTazMdZGFuB(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static bool AjPQFMiiQptYBAvI(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldAlwaysShowLabel();
    }

    public static float AjpkYgbxsQuluNvx(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static void AklKtjmWltjdosBo(com.google.android.material.slider.BaseSlider baseSlider, java.util.List arrayList) {
        baseSlider.setValuesInternal(arrayList);
    }

    public static void ApUYDrPsaeDwagpv(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        baseSlider.setEnabled(z);
    }

    private void AttachLabelToContentobject(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        ZZiqhmJyXtlgRIVo(tooltipDrawable, QPzOeJdnFrZyLqVO(this));
    }

    public static java.lang.float AwUaHgFfiQvMXzMD(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float AxAVZAIjUNqqxmYb(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateStepIncrement();
    }

    public static java.lang.object AygabxuOTAcQiQcV(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void AzEUaPFVatPAiyXZ(android.view.objectTreeObserver viewTreeObserver, android.view.objectTreeObserver$OnScrollChangedListener viewTreeObserver$OnScrollChangedListener) {
        viewTreeObserver.removeOnScrollChangedListener(viewTreeObserver$OnScrollChangedListener);
    }

    public static bool BBcTzNgghxFXAumn(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static android.content.object BETvNpNQZhIUiOlC(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static android.content.object BGhMboZqYRgvvpPW(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobject();
    }

    public static void BHWSYUbayqbEhUIK(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder bOamwejWldITbNsz(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, float f) {
        return shapeAppearanceModel$Builder.setAllCorners(i, f);
    }

    public static java.util.IEnumerator BSlNXLlcNcKLymRt(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int BUhefWyXsQIoFCuH(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper) {
        return baseSlider$AccessibilityHelper.getAccessibilityFocusedVirtualobjectId();
    }

    public static void BaoQWuYbfGIkfDHS(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        tooltipDrawable.setStrokeWidth(f);
    }

    public static void BbUUObPKrqkAarqN(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2, float f, android.graphics.drawable.Drawable drawable) {
        baseSlider.drawThumbDrawable(canvas, i, i2, f, drawable);
    }

    public static void BeOTwIWnrXNvNani(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateWidgetLayout();
    }

    public static void BfxJKNpzVhxSbxvk(com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener, java.lang.object obj, float f, bool z) {
        baseOnChangeListener.onValueChange(obj, f, z);
    }

    public static void BiGrybvsmppsXPNh(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        baseSlider.setPressed(z);
    }

    public static int BiajafHaaSFaxoyZ(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void BjNalPrvZIRReHea(com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener, java.lang.object obj, float f, bool z) {
        baseOnChangeListener.onValueChange(obj, f, z);
    }

    public static float BmWLuXIoSelvuNjW(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object BtwZdMMxAkqISRKm(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.float BuMdqLWTgqvUqAht(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int BxKEznscYyNZxgrF(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void BznDoXlGRWbJjcCQ(java.util.List list) {
        list.clear();
    }

    public static void BzvZfzQdqbPDRSaR(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateWidgetLayout();
    }

    public static void CBGoRunUTGvMvJjj(java.util.List list) {
        list.clear();
    }

    public static int CBrToKeNrTnwbiOb(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getToolType(i);
    }

    public static java.util.IEnumerator CCvOnBxpRJWNoJtY(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.bool CLircBlJqSVTHbFH(com.google.android.material.slider.BaseSlider baseSlider, int i, android.view.KeyEvent keyEvent) {
        return baseSlider.onKeyDownNoActiveThumb(i, keyEvent);
    }

    public static int CNRoVfzRfJnZyTHD(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void COkTvYmYrUrqOZFa(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateValueFrom();
    }

    public static void CRTcdrJXRTLWCXJL(android.graphics.Path path, android.graphics.RectF rectF, float[] fArr, android.graphics.Path$Direction path$Direction) {
        path.addRoundRect(rectF, fArr, path$Direction);
    }

    public static int CWQhwhhigtdIhkFt(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void CYpswiRMUzzQHXqe(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static java.util.IEnumerator CZAiTWHRJMiqKNOR(java.util.List arrayList) {
        return arrayList.GetEnumerator();
    }

    private java.lang.float CalculateIncrementForKey(int i) {
        if ((21 + 5) % 5 > 0) {
        }
        float fAxAVZAIjUNqqxmYb = !this.islongPress ? axAVZAIjUNqqxmYb(this) : mvkafpNrQggIfKjg(this, 20);
        if (i == 21) {
            if (!FrSepHlCKixggECA(this)) {
                fAxAVZAIjUNqqxmYb = -fAxAVZAIjUNqqxmYb;
            }
            return HcMGlYujDrwcYcyM(fAxAVZAIjUNqqxmYb);
        }
        if (i == 22) {
            if (MXrGTOxlnzagvZpW(this)) {
                fAxAVZAIjUNqqxmYb = -fAxAVZAIjUNqqxmYb;
            }
            return idQAxaYAzLfEGzdF(fAxAVZAIjUNqqxmYb);
        }
        if (i == 69) {
            return TOCwGCQBVWntiqoZ(-fAxAVZAIjUNqqxmYb);
        }
        if (i == 70 || i == 81) {
            return HUcjKOkwVYQyYfOR(fAxAVZAIjUNqqxmYb);
        }
        return null;
    }

    private float CalculateStepIncrement() {
        float f = this.stepSize;
        if (f != 0.0f) {
            return f;
        }
        return 1.0f;
    }

    private float CalculateStepIncrement(int i) {
        if ((30 + 22) % 22 > 0) {
        }
        float fKnYpudYBfDjpMWAf = knYpudYBfDjpMWAf(this);
        return (this.valueTo - this.valueFrom) / fKnYpudYBfDjpMWAf > i ? EIhmotIfjLrREImD(r1 / r2) * fKnYpudYBfDjpMWAf : fKnYpudYBfDjpMWAf;
    }

    private int CalculateTrackCenter() {
        if ((17 + 20) % 20 > 0) {
        }
        return (this.widgetHeight / 2) + ((this.labelBehavior == 1 || maOMeNsjUXAoWRPo(this)) ? tpCYJRlfRnetUPeo((com.google.android.material.tooltip.TooltipDrawable) QlZqVFweUFPlmTtB(this.labels, 0)) : 0);
    }

    public static android.content.object CgRONZCXmceShKHk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void CmnLzoFsyueWPakT(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable[] drawableArr) {
        baseSlider.setCustomThumbDrawablesForValues(drawableArr);
    }

    private android.animation.ValueAnimator CreateLabelAnimator(bool z) {
        int iGcHJgFlktKWhoGbp;
        android.animation.TimeInterpolator timeInterpolatorLORypwAuBpzSdcHZ;
        if ((6 + 29) % 29 > 0) {
        }
        float fTcnilRqZnDKHXvCq = tcnilRqZnDKHXvCq(!z ? this.labelsInAnimator : this.labelsOutAnimator, !z ? 1.0f : 0.0f);
        float f = z ? 1.0f : 0.0f;
        float[] fArr = new float[2];
        fArr[0] = fTcnilRqZnDKHXvCq;
        fArr[1] = f;
        android.animation.ValueAnimator valueAnimatorYVZXatmGzTNgboib = YVZXatmGzTNgboib(fArr);
        if (z) {
            iGcHJgFlktKWhoGbp = vJGseeUglWPAjfuc(bGhMboZqYRgvvpPW(this), LABEL_ANIMATION_ENTER_DURATION_ATTR, 83);
            timeInterpolatorLORypwAuBpzSdcHZ = vbTFHaFrauiYGhom(HjmpKefwBnwQbWvh(this), LABEL_ANIMATION_ENTER_EASING_ATTR, com.google.android.material.animation.AnimationUtils.DECELERATE_INTERPOLATOR);
        } else {
            iGcHJgFlktKWhoGbp = GcHJgFlktKWhoGbp(NbbjGzZjZttglJWL(this), LABEL_ANIMATION_EXIT_DURATION_ATTR, 117);
            timeInterpolatorLORypwAuBpzSdcHZ = lORypwAuBpzSdcHZ(UDRfRMGTsPiqISXv(this), LABEL_ANIMATION_EXIT_EASING_ATTR, com.google.android.material.animation.AnimationUtils.FAST_OUT_LINEAR_IN_INTERPOLATOR);
        }
        nANnPeDWxAhfPmqQ(valueAnimatorYVZXatmGzTNgboib, iGcHJgFlktKWhoGbp);
        hWbhjKsIERcKxmhr(valueAnimatorYVZXatmGzTNgboib, timeInterpolatorLORypwAuBpzSdcHZ);
        aZFrOFjxyWDTYGLW(valueAnimatorYVZXatmGzTNgboib, new com.google.android.material.slider.BaseSlider$1(this));
        return valueAnimatorYVZXatmGzTNgboib;
    }

    private void CreateLabelPool() {
        if ((16 + 4) % 4 > 0) {
        }
        if (LhLnmfjAhJiZNpbf(this.labels) > DQIdJJGNOuIIyVgp(this.values)) {
            java.util.List listKKqWpJJOQUecUHEP = kKqWpJJOQUecUHEP(this.labels, ensDnTvYVwUfmaju(this.values), NApsegcxCpJckrtl(this.labels));
            java.util.IEnumerator itCCvOnBxpRJWNoJtY = cCvOnBxpRJWNoJtY(listKKqWpJJOQUecUHEP);
            while (wmIFrNgWQazSHnIg(itCCvOnBxpRJWNoJtY)) {
                com.google.android.material.tooltip.TooltipDrawable tooltipDrawable = (com.google.android.material.tooltip.TooltipDrawable) rmxfOrGHnhEhSeYm(itCCvOnBxpRJWNoJtY);
                if (jxDsYbGYalgCfYqY(this)) {
                    PfExPOGBCmQSvMdX(this, tooltipDrawable);
                }
            }
            qbPkPjEQmmjIATYa(listKKqWpJJOQUecUHEP);
        }
        while (true) {
            if (dKqYCIaFTnBSKLWg(this.labels) >= whewEuOyRwwSCbOM(this.values)) {
                break;
            }
            com.google.android.material.tooltip.TooltipDrawable tooltipDrawableGpHHkhTHtAESessq = GpHHkhTHtAESessq(aJhnEOiBDnuWIoam(this), null, 0, this.labelStyle);
            pzGgjHawllRXovjl(this.labels, tooltipDrawableGpHHkhTHtAESessq);
            if (TIjlutIiKCHwUpgf(this)) {
                RChQhRlIFjLNVARn(this, tooltipDrawableGpHHkhTHtAESessq);
            }
        }
        int i = ynScTZziBphXuAvR(this.labels) != 1 ? 1 : 0;
        java.util.IEnumerator itIxCevOhJOoQYOdIz = IxCevOhJOoQYOdIz(this.labels);
        while (lrLZjwfDmXzXWnVv(itIxCevOhJOoQYOdIz)) {
            baoQWuYbfGIkfDHS((com.google.android.material.tooltip.TooltipDrawable) NeeaEueejYkFWcFh(itIxCevOhJOoQYOdIz), i);
        }
    }

    public static java.lang.object CsAjIcKPPPRbiwtw(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static bool DEGgCMohmwdvBlEN(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void DHDurYNqtiYCAeik(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static bool DISxZUBAkeicrJEz(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasGapBetweenThumbAndTrack();
    }

    public static int DKqYCIaFTnBSKLWg(java.util.List list) {
        return list.Count;
    }

    public static bool DKqnWeltjjeHRzNl(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.isStateful();
    }

    public static java.lang.object DOQBacJojxuTXrxD(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.object DQOIPuXZurVbCjmF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool DQvCBYaatvnQCxGh(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasGapBetweenThumbAndTrack();
    }

    public static float[] DUmufOvXmLpsCSiq(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getActiveRange();
    }

    public static bool DXePFAHgqpmsGmFR(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int DbpAmWTFivFZPQKc(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    private void DetachLabelFromContentobject(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        com.google.android.material.internal.objectOverlayImpl viewOverlayImplWndlbhIAnIHlVemh = WndlbhIAnIHlVemh(this);
        if (viewOverlayImplWndlbhIAnIHlVemh is null) {
            return;
        }
        RshbIitJTGJoJYTf(viewOverlayImplWndlbhIAnIHlVemh, tooltipDrawable);
        hzBlUQBKktkUlpVI(tooltipDrawable, lYJHLpMHlqXmkjjz(this));
    }

    public static bool DgwHUPuTTLwmrSis(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.snapTouchPosition();
    }

    private float DimenToValue(float f) {
        if ((13 + 8) % 8 > 0) {
        }
        if (f == 0.0f) {
            return 0.0f;
        }
        float f2 = (f - this.trackSidePadding) / this.trackWidth;
        float f3 = this.valueFrom;
        return (f2 * (f3 - this.valueTo)) + f3;
    }

    private void DispatchOnChangedFromUser(int i) {
        if ((8 + 23) % 23 > 0) {
        }
        java.util.IEnumerator itWyXFZpKRaFLxqGhb = WyXFZpKRaFLxqGhb(this.changeListeners);
        while (TkQinCUUlMOCITBx(itWyXFZpKRaFLxqGhb)) {
            bfxJKNpzVhxSbxvk((com.google.android.material.slider.BaseOnChangeListener) UlCtNbAekvtVpqPQ(itWyXFZpKRaFLxqGhb), this, DGzwVkZlATeuSxOn((java.lang.float) gLBvhGsWRhCADfXm(this.values, i)), true);
        }
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is not null && JluPFHPHeKOlBoRl(accessibilityManager)) {
            KafMbwJtYPcHuKrN(this, i);
        }
    }

    private void DispatchOnChangedProgrammatically() {
        if ((8 + 7) % 7 > 0) {
        }
        java.util.IEnumerator itEQIvXZKMHosOkRMw = eQIvXZKMHosOkRMw(this.changeListeners);
        while (oOazeklVAnvKpnvI(itEQIvXZKMHosOkRMw)) {
            com.google.android.material.slider.BaseOnChangeListener baseOnChangeListener = (com.google.android.material.slider.BaseOnChangeListener) TtIWOxKAyKzKZSYS(itEQIvXZKMHosOkRMw);
            java.util.IEnumerator itHfwdFsXgpwClrTym = HfwdFsXgpwClrTym(this.values);
            while (meJWZxiGfhmGcDCC(itHfwdFsXgpwClrTym)) {
                bjNalPrvZIRReHea(baseOnChangeListener, this, UkzujZcHKFoCRrym((java.lang.float) qvNxkqNxMCOtZoGJ(itHfwdFsXgpwClrTym)), false);
            }
        }
    }

    public static void DkqtyGtFuNuagDrS(android.graphics.drawable.RippleDrawable rippleDrawable, int i) {
        com.google.android.material.drawable.DrawableUtils.setRippleDrawableRadius(rippleDrawable, i);
    }

    public static float DlBfQrlrMOZjGBgR(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static void DlomoKuhfgnuiyov(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.focusThumbOnFocusGained(i);
    }

    public static android.graphics.drawable.Drawable DnJdvBXaHdwQTDYN(android.content.res.Resources resources, int i) {
        return resources.getDrawable(i);
    }

    public static void DnWeYSVqRoXJSZhh(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.onStartTrackingTouch();
    }

    private void DrawActiveTrack(android.graphics.Canvas canvas, int i, int i2) {
        int i3;
        if ((24 + 30) % 30 > 0) {
        }
        float[] fArrIqNweiILuuacgVLk = IqNweiILuuacgVLk(this);
        int i4 = this.trackSidePadding;
        float f = i;
        float f2 = i4 + (fArrIqNweiILuuacgVLk[1] * f);
        float fJiDYQTwLXGHtnQHH = i4 + (fArrIqNweiILuuacgVLk[0] * f);
        if (!mUdlAlxkLivJEgJE(this)) {
            IocGgoAYZrspncUx(this.activeTrackPaint, android.graphics.Paint$Style.STROKE);
            tNJOgtnCYNjvjSqi(this.activeTrackPaint, android.graphics.Paint$Cap.ROUND);
            float f3 = i2;
            PBqAuAhDlMKkzSVD(canvas, fJiDYQTwLXGHtnQHH, f3, f2, f3, this.activeTrackPaint);
            return;
        }
        com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection = com.google.android.material.slider.BaseSlider$FullCornerDirection.NONE;
        if (biajafHaaSFaxoyZ(this.values) == 1) {
            baseSlider$FullCornerDirection = !ZObDPokXXvLKpWTb(this) ? com.google.android.material.slider.BaseSlider$FullCornerDirection.LEFT : com.google.android.material.slider.BaseSlider$FullCornerDirection.RIGHT;
        }
        for (int i5 = 0; i5 < lyzUJxLfLEMpXGpA(this.values); i5++) {
            if (earkFBiSCfDcvwoW(this.values) > 1) {
                if (i5 > 0) {
                    fJiDYQTwLXGHtnQHH = JiDYQTwLXGHtnQHH(this, kSbdfQbVighPesAP((java.lang.float) btwZdMMxAkqISRKm(this.values, i5 - 1)));
                }
                float fJzastRKRHlMplXiu = JzastRKRHlMplXiu(this, gKXRbGuTIvLGgjEV((java.lang.float) yLtxTSNkElGINlvc(this.values, i5)));
                if (srJXaUkPbktnXMpP(this)) {
                    f2 = fJiDYQTwLXGHtnQHH;
                    fJiDYQTwLXGHtnQHH = fJzastRKRHlMplXiu;
                } else {
                    f2 = fJzastRKRHlMplXiu;
                }
            }
            int i6 = com.google.android.material.slider.BaseSlider$3.f122xd982e6cc[wERGzSXweTGEOusC(baseSlider$FullCornerDirection)];
            if (i6 == 1) {
                i3 = this.thumbTrackGapSize;
                fJiDYQTwLXGHtnQHH += i3;
            } else {
                if (i6 == 2) {
                    fJiDYQTwLXGHtnQHH -= this.trackHeight / 2.0f;
                    i3 = this.thumbTrackGapSize;
                } else if (i6 == 3) {
                    fJiDYQTwLXGHtnQHH += this.thumbTrackGapSize;
                    f2 += this.trackHeight / 2.0f;
                }
                if (fJiDYQTwLXGHtnQHH < f2) {
                    android.graphics.RectF rectF = this.trackRect;
                    float f4 = i2;
                    int i7 = this.trackHeight;
                    wetdLdotanpioJVE(rectF, fJiDYQTwLXGHtnQHH, f4 - (i7 / 2.0f), f2, f4 + (i7 / 2.0f));
                    JlRHemEhZnQMVHAY(this, canvas, this.activeTrackPaint, this.trackRect, baseSlider$FullCornerDirection);
                }
            }
            f2 -= i3;
            if (fJiDYQTwLXGHtnQHH < f2) {
                android.graphics.RectF rectF2 = this.trackRect;
                float f42 = i2;
                int i72 = this.trackHeight;
                wetdLdotanpioJVE(rectF2, fJiDYQTwLXGHtnQHH, f42 - (i72 / 2.0f), f2, f42 + (i72 / 2.0f));
                JlRHemEhZnQMVHAY(this, canvas, this.activeTrackPaint, this.trackRect, baseSlider$FullCornerDirection);
            }
        }
    }

    private void DrawInactiveTrack(android.graphics.Canvas canvas, int i, int i2) {
        if ((15 + 18) % 18 > 0) {
        }
        float[] fArrWkxokxMZZHKBSBjm = WkxokxMZZHKBSBjm(this);
        float f = i;
        float f2 = this.trackSidePadding + (fArrWkxokxMZZHKBSBjm[1] * f);
        if (f2 < r3 + i) {
            if (qqzrnNNZRjDcLhqd(this)) {
                android.graphics.RectF rectF = this.trackRect;
                float f3 = f2 + this.thumbTrackGapSize;
                float f4 = i2;
                int i3 = this.trackHeight;
                HVjadZcNCbbWOYUx(rectF, f3, f4 - (i3 / 2.0f), this.trackSidePadding + i + (i3 / 2.0f), f4 + (i3 / 2.0f));
                sOyjZzeqWmLQRPKH(this, canvas, this.inactiveTrackPaint, this.trackRect, com.google.android.material.slider.BaseSlider$FullCornerDirection.RIGHT);
            } else {
                NZsQUbGYvPPJFOSI(this.inactiveTrackPaint, android.graphics.Paint$Style.STROKE);
                yQaTxMiBevdszeNq(this.inactiveTrackPaint, android.graphics.Paint$Cap.ROUND);
                float f5 = i2;
                KjiUeUSQXFjRtbnW(canvas, f2, f5, this.trackSidePadding + i, f5, this.inactiveTrackPaint);
            }
        }
        int i4 = this.trackSidePadding;
        float f6 = i4 + (fArrWkxokxMZZHKBSBjm[0] * f);
        if (f6 <= i4) {
            return;
        }
        if (!zmrBVAWDXUovlgdb(this)) {
            dHDurYNqtiYCAeik(this.inactiveTrackPaint, android.graphics.Paint$Style.STROKE);
            wHNNRiHYSZbCCPOh(this.inactiveTrackPaint, android.graphics.Paint$Cap.ROUND);
            float f7 = i2;
            rGJleAxbOrRYvWRs(canvas, this.trackSidePadding, f7, f6, f7, this.inactiveTrackPaint);
            return;
        }
        android.graphics.RectF rectF2 = this.trackRect;
        float f8 = this.trackSidePadding;
        int i5 = this.trackHeight;
        float f9 = i2;
        uMTPADMvgxzaZfXo(rectF2, f8 - (i5 / 2.0f), f9 - (i5 / 2.0f), f6 - this.thumbTrackGapSize, f9 + (i5 / 2.0f));
        QLjzYDudvtcSLlQN(this, canvas, this.inactiveTrackPaint, this.trackRect, com.google.android.material.slider.BaseSlider$FullCornerDirection.LEFT);
    }

    private void DrawThumbDrawable(android.graphics.Canvas canvas, int i, int i2, float f, android.graphics.drawable.Drawable drawable) {
        WamWzFNVHXWLbAbp(canvas);
        IxgjwwFaySEXQUYa(canvas, (this.trackSidePadding + ((int) (oGVgiqEzydIWTmeI(this, f) * i))) - (SdxiqPIfFQCOyRle(YjVvroVsTWyebNwV(drawable)) / 2.0f), i2 - (DGIKHyybkWUgRBiB(gwTnizGBbaXrbpsD(drawable)) / 2.0f));
        yjSBLhnEjVHXBktU(drawable, canvas);
        gHQzkWdbGRvBjqQv(canvas);
    }

    private void DrawThumbs(android.graphics.Canvas canvas, int i, int i2) {
        com.google.android.material.slider.BaseSlider<S, L, T> baseSlider;
        android.graphics.Canvas canvas2;
        int i3;
        int i4;
        if ((9 + 16) % 16 > 0) {
        }
        int i5 = 0;
        while (i5 < KczkSTURiwAYRTyV(this.values)) {
            float fJdCmzhjDQamXzlgu = JdCmzhjDQamXzlgu((java.lang.float) CLqcTsznbOnLqCfD(this.values, i5));
            android.graphics.drawable.Drawable drawable = this.customThumbDrawable;
            if (drawable is null) {
                baseSlider = this;
                canvas2 = canvas;
                i3 = i;
                i4 = i2;
                if (i5 >= yFWEHAlivQlnKLHO(baseSlider.customThumbDrawablesForValues)) {
                    if (!nSZIvUCtXarKMSTU(baseSlider)) {
                        HikXodaokLrynMyy(canvas2, baseSlider.trackSidePadding + (ByrOpIDncDXvVzBH(baseSlider, fJdCmzhjDQamXzlgu) * i3), i4, oeJFQBCcMOnLDWxh(baseSlider), baseSlider.thumbPaint);
                    }
                    AcRBUodjWAnwqtIw(baseSlider, canvas2, i3, i4, fJdCmzhjDQamXzlgu, baseSlider.defaultThumbDrawable);
                } else {
                    bbUUObPKrqkAarqN(baseSlider, canvas2, i3, i4, fJdCmzhjDQamXzlgu, (android.graphics.drawable.Drawable) KYPXtJTIaZVUpotP(baseSlider.customThumbDrawablesForValues, i5));
                }
            } else {
                baseSlider = this;
                canvas2 = canvas;
                i3 = i;
                i4 = i2;
                SIpgAbazobcZYBQB(baseSlider, canvas2, i3, i4, fJdCmzhjDQamXzlgu, drawable);
            }
            i5++;
            this = baseSlider;
            canvas = canvas2;
            i = i3;
            i2 = i4;
        }
    }

    public static void DsOYssNjqWfupOqU(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static java.lang.float EBiSWObNEXvPScVI(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void EDXeaaSgpkMXkRMR(android.graphics.Canvas canvas, android.graphics.RectF rectF, float f, float f2, android.graphics.Paint paint) {
        canvas.drawRoundRect(rectF, f, f2, paint);
    }

    public static bool EEvvFBRxyVYJwHMA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isFocused();
    }

    public static bool EGHxoZUXYERIonew(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static void ELmGmRHNBQIIQhQC(android.view.object view, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static java.lang.object ENoZAcRRfbpoWprc(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.util.IEnumerator EQIvXZKMHosOkRMw(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void EUBFBqqMjHiqFqCp(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static bool EYpEEWHiKAJWmxSi(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void EafkbSGbLhzyGUEj(android.graphics.Canvas canvas, float f, float f2, android.graphics.Paint paint) {
        canvas.drawPoint(f, f2, paint);
    }

    public static int EarkFBiSCfDcvwoW(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static int EcmUkHHtPiWCpODa(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static int EgcpsWAhrxrPWyrX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.util.IEnumerator EhpCqVbudXWXFYCW(java.util.List list) {
        return list.GetEnumerator();
    }

    public static bool EidQZMOnwFvPWGUb(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static void EkPCYsYEQSrGotrk(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static bool EmnDxhzhuZiFtkxo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int EnsDnTvYVwUfmaju(java.util.List arrayList) {
        return arrayList.Count;
    }

    private void EnsureLabelsAdded() {
        if ((7 + 32) % 32 > 0) {
        }
        if (!this.labelsAreAnimatedIn) {
            this.labelsAreAnimatedIn = true;
            android.animation.ValueAnimator valueAnimatorDPoDhbyZmDGWJjDv = DPoDhbyZmDGWJjDv(this, true);
            this.labelsInAnimator = valueAnimatorDPoDhbyZmDGWJjDv;
            this.labelsOutAnimator = null;
            VaqWlTWhNPeIZNVc(valueAnimatorDPoDhbyZmDGWJjDv);
        }
        java.util.IEnumerator itBSlNXLlcNcKLymRt = bSlNXLlcNcKLymRt(this.labels);
        for (int i = 0; i < ALCrmXBhmSsOsUQb(this.values) && AxbflMOIjTkMQBgu(itBSlNXLlcNcKLymRt); i++) {
            if (i != this.focusedThumbIdx) {
                BJTBzwuOTWBQsQyx(this, (com.google.android.material.tooltip.TooltipDrawable) nBbshnXpthxHupSm(itBSlNXLlcNcKLymRt), VgkThxVSatSYvWSK((java.lang.float) xQEVdSzqyDmhRkZb(this.values, i)));
            }
        }
        if (!HIwHXIrajLMnEGxX(itBSlNXLlcNcKLymRt)) {
            throw new java.lang.IllegalStateException(EjczoIPLyJoZNfAU("Not enough labels(%d) to display all the values(%d)", new java.lang.object[]{CYmjrhLPAebXZIhr(sppSPFZejUPjRVyh(this.labels)), YmsTzOcOQssHTLoI(rphkEBenuHOrBCZX(this.values))}));
        }
        YOkQgsmrkHtijtvu(this, (com.google.android.material.tooltip.TooltipDrawable) DLYeoBGlEXjqDZjx(itBSlNXLlcNcKLymRt), henYZWjwHBeiTjDo((java.lang.float) OBNEejnhDKsLDZfn(this.values, this.focusedThumbIdx)));
    }

    private void EnsureLabelsRemoved() {
        if ((30 + 22) % 22 > 0) {
        }
        if (this.labelsAreAnimatedIn) {
            this.labelsAreAnimatedIn = false;
            android.animation.ValueAnimator valueAnimatorWcclXQRPkehCGwFn = wcclXQRPkehCGwFn(this, false);
            this.labelsOutAnimator = valueAnimatorWcclXQRPkehCGwFn;
            this.labelsInAnimator = null;
            OPtPsBSPonrsZVKR(valueAnimatorWcclXQRPkehCGwFn, new com.google.android.material.slider.BaseSlider$2(this));
            QjyHtBcqOeGspTIZ(this.labelsOutAnimator);
        }
    }

    public static void EqUjItJXcPjlmxIw(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static void EuIjTBSyTMTUXlet(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTrackInactiveTintList(colorStateList);
    }

    public static int[] EugxycpSoklMcEqn(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getDrawableState();
    }

    public static bool FKAILwoDkSWjgoCi(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static java.lang.string FaBWQEyVPYLmoRFF(float f) {
        return java.lang.float.tostring(f);
    }

    public static void FdNZsfPKvVhssrMO(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas) {
        baseSlider.maybeDrawTicks(canvas);
    }

    private void FocusThumbOnFocusGained(int i) {
        if ((7 + 25) % 25 > 0) {
        }
        if (i == 1) {
            GPmMVokMDlVrunyO(this, int.MAX_VALUE);
            return;
        }
        if (i == 2) {
            yXeTZeQpXbxLrCUp(this, int.MIN_VALUE);
        } else if (i == 17) {
            FuObNFkVsWBMbqJB(this, int.MAX_VALUE);
        } else if (i == 66) {
            ptZiNbxlMkraKjfr(this, int.MIN_VALUE);
        }
    }

    private java.lang.string FormatValue(float f) {
        if (DYnKvtoKuhlLHpqZ(this)) {
            return MztkGroEmukllniO(this.formatter, f);
        }
        return tpzkQIWWLEEOYnwT(((float) ((int) f)) != f ? "%.2f" : "%.0f", new java.lang.object[]{eBiSWObNEXvPScVI(f)});
    }

    public static java.lang.object FqLCcSPwlirhqNQW(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.res.ColorStateList FzguvcjVvcmvLpot(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static java.lang.object GGETSiGAWbSJXTBT(java.util.List list, int i) {
        return list[i);
    }

    public static void GHQzkWdbGRvBjqQv(android.graphics.Canvas canvas) {
        canvas.restore();
    }

    public static int GIsjLFLBWVosOUBH(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateTrackCenter();
    }

    public static java.math.decimal GJRGDupNWefRxCad(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.Mathobject mathobject) {
        return bigDecimal.subtract(bigDecimal2, mathobject);
    }

    public static float GKXRbGuTIvLGgjEV(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.object GLBvhGsWRhCADfXm(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.lang.float GRAjihEeHzGsnwML(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void GSQWPpBWYomzzvNJ(com.google.android.material.slider.BaseSlider baseSlider, java.util.List arrayList) {
        baseSlider.setValuesInternal(arrayList);
    }

    public static int GUJzNasEqzGIIeVD(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    private float[] GetActiveRange() {
        if ((32 + 3) % 3 > 0) {
        }
        float fSddYPOTcLmlZFKgS = SddYPOTcLmlZFKgS((java.lang.float) pTlVztvqRpPgLhmZ(this.values, 0));
        java.util.List<java.lang.float> arrayList = this.values;
        float fCmGOgfihsVeKAwGC = CmGOgfihsVeKAwGC((java.lang.float) mtdRrJmKKwWEGRJw(arrayList, PYzYepKQwTkBniwd(arrayList) - 1));
        if (nZiUCHyqenFpQFKo(this.values) == 1) {
            fSddYPOTcLmlZFKgS = this.valueFrom;
        }
        float fAGXrAADOhZwDQlVU = AGXrAADOhZwDQlVU(this, fSddYPOTcLmlZFKgS);
        float fZkrCOLfFhoChswpy = zkrCOLfFhoChswpy(this, fCmGOgfihsVeKAwGC);
        if (UzfpeLZbapdADPCa(this)) {
            float[] fArr = new float[2];
            fArr[0] = fZkrCOLfFhoChswpy;
            fArr[1] = fAGXrAADOhZwDQlVU;
            return fArr;
        }
        float[] fArr2 = new float[2];
        fArr2[0] = fAGXrAADOhZwDQlVU;
        fArr2[1] = fZkrCOLfFhoChswpy;
        return fArr2;
    }

    private static float GetAnimatorCurrentValueOrDefault(android.animation.ValueAnimator valueAnimator, float f) {
        if (valueAnimator is not null && rVvKSwtYQaOZDZLc(valueAnimator)) {
            f = YXxJgmAyqdyWkxDe((java.lang.float) csAjIcKPPPRbiwtw(valueAnimator));
            zQlGhefDsaxboaTV(valueAnimator);
        }
        return f;
    }

    private float GetClampedValue(int i, float f) {
        if ((1 + 17) % 17 > 0) {
        }
        float fLooHprkLgTsxGjpH = LooHprkLgTsxGjpH(this);
        if (this.separationUnit == 0) {
            fLooHprkLgTsxGjpH = GOxWCmEhpwzJCxmq(this, fLooHprkLgTsxGjpH);
        }
        if (oZcMAkglebtqEYix(this)) {
            fLooHprkLgTsxGjpH = -fLooHprkLgTsxGjpH;
        }
        int i2 = i + 1;
        int i3 = i - 1;
        return AvXWqOrqkQJcMaEC(f, i3 >= 0 ? zjvTGwwKHNvFOWVO((java.lang.float) aygabxuOTAcQiQcV(this.values, i3)) + fLooHprkLgTsxGjpH : this.valueFrom, i2 < PbeCVEBqhJgURupB(this.values) ? GjJnQMLXUSjwUTPS((java.lang.float) jHFgMNDYoCMKJeqd(this.values, i2)) - fLooHprkLgTsxGjpH : this.valueTo);
    }

    private int GetColorForState(android.content.res.ColorStateList colorStateList) {
        return dbpAmWTFivFZPQKc(colorStateList, pmQKfbyLUPVpfHxs(this), FLrvjPjfjDBKvjSA(colorStateList));
    }

    private float[] GetCornerRadii(float f, float f2) {
        float[] fArr = new float[8];
        fArr[0] = f;
        fArr[1] = f;
        fArr[2] = f2;
        fArr[3] = f2;
        fArr[4] = f2;
        fArr[5] = f2;
        fArr[6] = f;
        fArr[7] = f;
        return fArr;
    }

    private float GetValueOfTouchPosition() {
        if ((5 + 2) % 2 > 0) {
        }
        double dIlUVXJztGLolbidE = IlUVXJztGLolbidE(this, this.touchPosition);
        if (obRomAdZpdNpzPab(this)) {
            dIlUVXJztGLolbidE = 1.0d - dIlUVXJztGLolbidE;
        }
        float f = this.valueTo;
        float f2 = this.valueFrom;
        return (float) ((dIlUVXJztGLolbidE * ((double) (f - f2))) + ((double) f2));
    }

    private float GetValueOfTouchPositionAbsolute() {
        if ((6 + 27) % 27 > 0) {
        }
        float f = this.touchPosition;
        if (YAxcmtlHkqYwviQb(this)) {
            f = 1.0f - f;
        }
        float f2 = this.valueTo;
        float f3 = this.valueFrom;
        return (f * (f2 - f3)) + f3;
    }

    public static void GkHTkXxSIJrqbxKx(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static int GkUiqnzMqurKpGcZ(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static int GmZWLbQNyKoEXvKh(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int GmeScdGhaFFwFIkP(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool GqzhiyHfkUpkmYqo(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string GsphMaBouVEJMGCT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static android.graphics.Rect GwTnizGBbaXrbpsD(android.graphics.drawable.Drawable drawable) {
        return drawable.getBounds();
    }

    public static void GxbioCkzqkPxXMXG(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void GyhLAMmufGpFjEQB(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateConfigurationIfDirty();
    }

    public static void HFqvSzBcChkafHaK(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static bool HHNUKadNfGXBxmBO(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldDrawCompatHalo();
    }

    public static java.lang.float HTLTYFNnmavmUiAS(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void HWbhjKsIERcKxmhr(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    private bool HasGapBetweenThumbAndTrack() {
        return this.thumbTrackGapSize > 0;
    }

    public static int HcrezvvffSzkWbLx(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getIntrinsicWidth();
    }

    public static float HenYZWjwHBeiTjDo(java.lang.float f) {
        return f.floatValue();
    }

    public static void HiliizDbuTWxUflz(android.graphics.Path path, android.graphics.RectF rectF, float f, float f2, android.graphics.Path$Direction path$Direction) {
        path.addRoundRect(rectF, f, f2, path$Direction);
    }

    public static int HnHwEAmezFktuRIo(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static void HvSkSJKOKmPnjFEV(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.requestLayout();
    }

    public static java.lang.float HyqCIvrsRQsQNiSe(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void HzBlUQBKktkUlpVI(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.view.object view) {
        tooltipDrawable.detachobject(view);
    }

    public static java.lang.object IDtaGbQDYhlGxRem(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void IEoQENlWtqLrQOPl(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static java.lang.object IINMdMecxQBbwFhg(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int IJBtTMDftchJnGJh(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static int IRwQPXWbXHyxJpMK(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool IYCuEUUZLKnGUfeH(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool IbAfPAJQebuygZdA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static java.lang.float IdQAxaYAzLfEGzdF(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool IgaxOBfBTeGaBbYt(android.view.KeyEvent keyEvent) {
        return keyEvent.isShiftPressed();
    }

    public static bool IhKglpzzFNWOONos(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ImWjwEAYcaXwSEov(android.view.object view) {
        super.onDetachedFromWindow();
    }

    private android.graphics.drawable.Drawable InitializeCustomThumbDrawable(android.graphics.drawable.Drawable drawable) {
        android.graphics.drawable.Drawable drawableLgjoNNxLGrrulwBK = lgjoNNxLGrrulwBK(lONTFKZmNzAsFFhj(DCrSSSFQCKwdlvIB(drawable)));
        vgGmxrerwusaEtXS(this, drawableLgjoNNxLGrrulwBK);
        return drawableLgjoNNxLGrrulwBK;
    }

    private void InvalidateTrack() {
        if ((5 + 4) % 4 > 0) {
        }
        bHWSYUbayqbEhUIK(this.inactiveTrackPaint, this.trackHeight);
        nZZmxCwiZlUUDSRQ(this.activeTrackPaint, this.trackHeight);
    }

    private bool IsInVerticalScrollingContainer() {
        if ((29 + 3) % 3 > 0) {
        }
        for (android.view.objectParent viewParentMFgcAtmpxhwbDmEe = mFgcAtmpxhwbDmEe(this); viewParentMFgcAtmpxhwbDmEe is android.view.objectGroup; viewParentMFgcAtmpxhwbDmEe = QErbRkqUkWIaPKbx(viewParentMFgcAtmpxhwbDmEe)) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) viewParentMFgcAtmpxhwbDmEe;
            if ((ChaJycszlERFcVoA(viewGroup, 1) || zzroezqsjwgsbZkJ(viewGroup, -1)) && MPWHvgslxsQrKEAa(viewGroup)) {
                return true;
            }
        }
        return false;
    }

    private static bool IsMouseEvent(android.view.MotionEvent motionEvent) {
        if ((28 + 26) % 26 > 0) {
        }
        return cBrToKeNrTnwbiOb(motionEvent, 0) == 3;
    }

    private bool IsMultipleOfStepSize(double d) {
        if ((8 + 6) % 6 > 0) {
        }
        double dWYvHiiHuUfPWdUzp = WYvHiiHuUfPWdUzp(sTNxWVaMBIEzxIHS(new java.math.decimal(lknbiasgCYzMhdQU(d)), new java.math.decimal(faBWQEyVPYLmoRFF(this.stepSize)), java.math.Mathobject.DECIMAL64));
        return BEbPFxlJXisZYzOB(((double) FiRircBtkmTHZEFe(dWYvHiiHuUfPWdUzp)) - dWYvHiiHuUfPWdUzp) < 1.0E-4d;
    }

    private bool IsPotentialVerticalScroll(android.view.MotionEvent motionEvent) {
        return !CivLzayUovufJEtZ(motionEvent) && TszYWenGOCqKRMHR(this);
    }

    private bool IsSliderVisibleOnScreen() {
        if ((29 + 17) % 17 > 0) {
        }
        android.graphics.Rect rect = new android.graphics.Rect();
        JvTbqsDjdzqgTlUG(KDqAHpflGyXgXYKv(this), rect);
        return AMhuMHVLfzJDsGfU(this, rect);
    }

    public static int JDnfozeXeQrrbAcp(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object JHFgMNDYoCMKJeqd(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static float JKGCtibpTLPIWcGX(float f) {
        return java.lang.Math.abs(f);
    }

    public static float JStAYukJeRtVlaaH(java.lang.float f) {
        return f.floatValue();
    }

    public static void JVJIuKLgHzCkPRrO(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i) {
        baseSlider.maybeDrawStopIndicator(canvas, i);
    }

    public static int JkYQhyzlNhPiRDMe(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool JmuArhtzrLoxdAZa(android.view.object view, int i, android.view.KeyEvent keyEvent) {
        return super.onKeyDown(i, keyEvent);
    }

    public static void JnZCGseapaWYeEDI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setStrokeWidth(f);
    }

    public static bool JqUlTqYRbQzHgtbt(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldDrawCompatHalo();
    }

    public static void JtTgklCxxbkksGor(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbTrackGapSize(i);
    }

    public static bool JxBvzrcEPycUCjWk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool JxDsYbGYalgCfYqY(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void JyXOPGqLoOaPfSbB(android.view.object view) {
        super.onAttachedToWindow();
    }

    public static void JysZpyjBcIqdFuQL(android.view.object view, bool z, int i, android.graphics.Rect rect) {
        super.onFocusChanged(z, i, rect);
    }

    public static java.lang.bool KACcwxDiPWnwmzdY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool KBVHIdtyuTGSapBA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldDrawCompatHalo();
    }

    public static void KFkvUfJzVFdrYJro(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        baseSlider.positionLabel(tooltipDrawable, f);
    }

    public static void KIUxIIVVPcNSuOal(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, int i2, int i3, int i4) {
        materialShapeDrawable.setBounds(i, i2, i3, i4);
    }

    public static java.util.List KKqWpJJOQUecUHEP(java.util.List list, int i, int i2) {
        return list.subList(i, i2);
    }

    public static void KLqHsGlnbwThlVgn(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.createLabelPool();
    }

    public static void KNKxQNAWWqRHwsxO(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidateTrack();
    }

    public static void KQjrpAZzbVqScZdP(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.ensureLabelsRemoved();
    }

    public static float KSbdfQbVighPesAP(java.lang.float f) {
        return f.floatValue();
    }

    public static android.content.res.ColorStateList KXezRXWcqkZzcAXR(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static java.lang.bool KhcfxcedVyJcNEZf(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void KmwNRviPJpMylPfP(com.google.android.material.slider.BaseSlider baseSlider, com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        baseSlider.attachLabelToContentobject(tooltipDrawable);
    }

    public static float KnYpudYBfDjpMWAf(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateStepIncrement();
    }

    public static int KqHDDOprWBGQhQQn(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static float KrHhXTccHElGCZQB(java.lang.float f) {
        return f.floatValue();
    }

    public static void KrVQDwGIDknPsFcv(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static int KsxfONdmXvORaXZk(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KtckUOZhZANxIeyo(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.maybeCalculateTicksCoordinates();
    }

    public static bool KvFJbekbkptDktRs(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static int KyjTeuzkbjyjHJzQ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static android.content.res.ColorStateList LDLYFQgOtvGbXmgO(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getStrokeColor();
    }

    public static float LGTxiHoSAjSANpWz(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void LJSTsDBFLRVcusfD(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setThumbStrokeColor(colorStateList);
    }

    public static int LJwNAniouhwOzFIm(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void LNnIOwttfktTZcCH(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbWidth(i);
    }

    public static android.graphics.drawable.Drawable$ConstantState lONTFKZmNzAsFFhj(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static android.animation.TimeInterpolator LORypwAuBpzSdcHZ(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static float LUNRsGGYpUPqomZG(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void LWNpFLuADKTDbqpQ(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static android.view.objectGroup LYJHLpMHlqXmkjjz(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getContentobject(view);
    }

    public static android.graphics.drawable.Drawable LgjoNNxLGrrulwBK(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static android.content.res.Resources LiscvwjBsewVArup(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static bool LkMEjcpaAQkLSSbY(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.snapActiveThumbToValue(f);
    }

    public static java.lang.string LknbiasgCYzMhdQU(double d) {
        return java.lang.double.tostring(d);
    }

    public static void LmVoQdveVwFOJsBQ(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static java.lang.string LoRNwFdARbOQHLhY(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    private void LoadResources(android.content.res.Resources resources) {
        this.minWidgetHeight = lJwNAniouhwOzFIm(resources, com.google.android.material.R$dimen.mtrl_slider_widget_height);
        int iRoXBTXcJtmNJrFqu = roXBTXcJtmNJrFqu(resources, com.google.android.material.R$dimen.mtrl_slider_track_side_padding);
        this.minTrackSidePadding = iRoXBTXcJtmNJrFqu;
        this.trackSidePadding = iRoXBTXcJtmNJrFqu;
        this.defaultThumbRadius = iRwQPXWbXHyxJpMK(resources, com.google.android.material.R$dimen.mtrl_slider_thumb_radius);
        this.defaultTrackHeight = nokifAkLTchpBfoR(resources, com.google.android.material.R$dimen.mtrl_slider_track_height);
        this.defaultTickActiveRadius = uGIvFNgLAALWDOMw(resources, com.google.android.material.R$dimen.mtrl_slider_tick_radius);
        this.defaultTickInactiveRadius = NMrwPVlOXoDGEkcE(resources, com.google.android.material.R$dimen.mtrl_slider_tick_radius);
        this.minTickSpacing = qpneFsdwcrhGtltF(resources, com.google.android.material.R$dimen.mtrl_slider_tick_min_spacing);
        this.labelPadding = EWMTqBDsAcVaVmEl(resources, com.google.android.material.R$dimen.mtrl_slider_label_padding);
    }

    public static bool LrLZjwfDmXzXWnVv(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool LtzxgRXJuNvbbxeJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int LyzUJxLfLEMpXGpA(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object MEBjYXVJDcGBerXL(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool MFdFWRhIVQsraGwP(com.google.android.material.slider.BaseSlider baseSlider, int i, float f) {
        return baseSlider.snapThumbToValue(i, f);
    }

    public static android.view.objectParent MFgcAtmpxhwbDmEe(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getParent();
    }

    public static void MHxmOqaCdIbUfdXl(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static bool MOqotUTrcdlaQhJC(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static bool MRHOzEIpQmLULjGd(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, android.view.MotionEvent motionEvent) {
        return baseSlider$AccessibilityHelper.dispatchHoverEvent(motionEvent);
    }

    public static int MSQebAgfaRJQqgMf(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static float MTzTJtoGMPhnNniF(android.graphics.RectF rectF) {
        return rectF.centerX();
    }

    public static bool MUdlAlxkLivJEgJE(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasGapBetweenThumbAndTrack();
    }

    public static float MZbviEekjSgQJbId(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static bool MaOMeNsjUXAoWRPo(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldAlwaysShowLabel();
    }

    public static java.lang.object MaTpekAWTIZfLSOs(java.util.IEnumerator it) {
        return it.Current;
    }

    private void MaybeCalculateTicksCoordinates() {
        if ((11 + 3) % 3 > 0) {
        }
        if (this.stepSize > 0.0f) {
            gyhLAMmufGpFjEQB(this);
            int iMSQebAgfaRJQqgMf = mSQebAgfaRJQqgMf((int) (((this.valueTo - this.valueFrom) / this.stepSize) + 1.0f), (this.trackWidth / this.minTickSpacing) + 1);
            float[] fArr = this.ticksCoordinates;
            if (fArr is null || fArr.length != iMSQebAgfaRJQqgMf * 2) {
                this.ticksCoordinates = new float[iMSQebAgfaRJQqgMf * 2];
            }
            float f = this.trackWidth / (iMSQebAgfaRJQqgMf - 1);
            for (int i = 0; i < iMSQebAgfaRJQqgMf * 2; i += 2) {
                float[] fArr2 = this.ticksCoordinates;
                fArr2[i] = this.trackSidePadding + ((i / 2.0f) * f);
                fArr2[i + 1] = FiGPiAUGPAXrNHJb(this);
            }
        }
    }

    private void MaybeDrawCompatHalo(android.graphics.Canvas canvas, int i, int i2) {
        if ((5 + 8) % 8 > 0) {
        }
        if (peuHintOtAIlTQTK(this)) {
            CucEbuVHYIslHGRK(canvas, (int) (this.trackSidePadding + (ajpkYgbxsQuluNvx(this, VZRAmRkatJGqYmZw((java.lang.float) GXGmzWczmkTTdcGb(this.values, this.focusedThumbIdx))) * i)), i2, this.haloRadius, this.haloPaint);
        }
    }

    private void MaybeDrawStopIndicator(android.graphics.Canvas canvas, int i) {
        if ((8 + 3) % 3 > 0) {
        }
        if (this.trackStopIndicatorSize > 0) {
            if (jkYQhyzlNhPiRDMe(this.values) >= 1) {
                java.util.List<java.lang.float> arrayList = this.values;
                float fJStAYukJeRtVlaaH = jStAYukJeRtVlaaH((java.lang.float) qcnyKntxOPTvfTxl(arrayList, cWQhwhhigtdIhkFt(arrayList) - 1));
                float f = this.valueTo;
                if (fJStAYukJeRtVlaaH < f) {
                    eafkbSGbLhzyGUEj(canvas, vYPgmeutHNSsuAfh(this, f), i, this.stopIndicatorPaint);
                }
            }
            if (ZqoCdkXsDNTIEvzL(this.values) <= 1) {
                return;
            }
            float fTxAhHpPGNjTkGToV = TxAhHpPGNjTkGToV((java.lang.float) zpiwSNlvmWkRgvQH(this.values, 0));
            float f2 = this.valueFrom;
            if (fTxAhHpPGNjTkGToV <= f2) {
                return;
            }
            qsypchOAzVbPLabZ(canvas, XFAXZNwtKEPWKpOr(this, f2), i, this.stopIndicatorPaint);
        }
    }

    private void MaybeDrawTicks(android.graphics.Canvas canvas) {
        if ((2 + 17) % 17 > 0) {
        }
        if (this.tickVisible && this.stepSize > 0.0f) {
            float[] fArrDUmufOvXmLpsCSiq = dUmufOvXmLpsCSiq(this);
            int iASshkLtWHhepezSW = (int) aSshkLtWHhepezSW(fArrDUmufOvXmLpsCSiq[0] * ((this.ticksCoordinates.length / 2.0f) - 1.0f));
            int iTpPPQZWfbMQIkFcC = (int) TpPPQZWfbMQIkFcC(fArrDUmufOvXmLpsCSiq[1] * ((this.ticksCoordinates.length / 2.0f) - 1.0f));
            if (iASshkLtWHhepezSW > 0) {
                vIuXXSRQTrnxFZzJ(canvas, this.ticksCoordinates, 0, iASshkLtWHhepezSW * 2, this.inactiveTicksPaint);
            }
            if (iASshkLtWHhepezSW <= iTpPPQZWfbMQIkFcC) {
                QbsJUDDFfpEbESbS(canvas, this.ticksCoordinates, iASshkLtWHhepezSW * 2, ((iTpPPQZWfbMQIkFcC - iASshkLtWHhepezSW) + 1) * 2, this.activeTicksPaint);
            }
            int i = (iTpPPQZWfbMQIkFcC + 1) * 2;
            float[] fArr = this.ticksCoordinates;
            if (i >= fArr.length) {
                return;
            }
            nrtjbJNbPfmKHCHS(canvas, fArr, i, fArr.length - i, this.inactiveTicksPaint);
        }
    }

    private bool MaybeIncreaseTrackSidePadding() {
        if ((18 + 8) % 8 > 0) {
        }
        int iTJYlrNgPWitCJmKo = this.minTrackSidePadding + tJYlrNgPWitCJmKo(sVquIxdyFANGcYIm(gUJzNasEqzGIIeVD((this.thumbWidth / 2) - this.defaultThumbRadius, 0), BctUzxrglHYWrAHS((this.trackHeight - this.defaultTrackHeight) / 2, 0)), nRicYkEMDsNCGsyH(StiebdPoKPpouEhE(this.tickActiveRadius - this.defaultTickActiveRadius, 0), UdjKpBQXhoxreUUg(this.tickInactiveRadius - this.defaultTickInactiveRadius, 0)));
        if (this.trackSidePadding == iTJYlrNgPWitCJmKo) {
            return false;
        }
        this.trackSidePadding = iTJYlrNgPWitCJmKo;
        if (!FUUvumcLkhwhDHJR(this)) {
            return true;
        }
        AgVzwKBjIaGdaYfi(this, CWwcpdDfxvICocoY(this));
        return true;
    }

    private bool MaybeIncreaseWidgetHeight() {
        if ((27 + 32) % 32 > 0) {
        }
        int iPcrgqsgIjaTWgKqt = PcrgqsgIjaTWgKqt(this.minWidgetHeight, rEzIkhBOoZbJmgHX(this.trackHeight + LJsvPNQFTuPNmNmB(this) + sBeVExqXMmvuuYUj(this), this.thumbHeight + tFQrqoCRJRvCKuvT(this) + FOPaTeTUzTVccmNY(this)));
        if (iPcrgqsgIjaTWgKqt == this.widgetHeight) {
            return false;
        }
        this.widgetHeight = iPcrgqsgIjaTWgKqt;
        return true;
    }

    public static bool MeJWZxiGfhmGcDCC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.view.objectConfiguration MgOkktmpWJydcssh(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void MmrwmSSaepUlTIBN(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static double MoCmlTjPOUIvmmjO(double d) {
        if ((30 + 23) % 23 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    private bool MoveFocus(int i) {
        if ((31 + 29) % 29 > 0) {
        }
        int i2 = this.focusedThumbIdx;
        int iMscmkweDWjKBTJFT = (int) MscmkweDWjKBTJFT(((long) i2) + ((long) i), 0L, jDnfozeXeQrrbAcp(this.values) - 1);
        this.focusedThumbIdx = iMscmkweDWjKBTJFT;
        if (iMscmkweDWjKBTJFT == i2) {
            return false;
        }
        if (this.activeThumbIdx != -1) {
            this.activeThumbIdx = iMscmkweDWjKBTJFT;
        }
        FLyyaVILwCGwqPjX(this);
        IWtkBORTdZFSZMYL(this);
        return true;
    }

    private bool MoveFocusInAbsoluteDirection(int i) {
        if (mOqotUTrcdlaQhJC(this)) {
            i = i != int.MIN_VALUE ? -i : int.MAX_VALUE;
        }
        return NBGviKWzPefKwCoe(this, i);
    }

    public static bool MsUrJYkquXWRAfiJ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.object MtdRrJmKKwWEGRJw(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static float MvkafpNrQggIfKjg(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.calculateStepIncrement(i);
    }

    public static android.animation.ValueAnimator NANnPeDWxAhfPmqQ(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static java.lang.object NBbshnXpthxHupSm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static android.content.res.ColorStateList NBwnxpWbqOadcxgM(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static float NEDmMfrsJIpSBpDJ(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getValueOfTouchPositionAbsolute();
    }

    public static int NRicYkEMDsNCGsyH(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static bool NSZIvUCtXarKMSTU(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static android.os.Parcelable NUWeXQuRDuMlKPcW(android.view.object view) {
        return super.onSaveInstanceState();
    }

    public static void NZZmxCwiZlUUDSRQ(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static int NZiUCHyqenFpQFKo(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static java.lang.object NboInmXXyIlrazRQ(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool NcwSYJNbOEqRcBXs(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void NdOSalSzqaExSGps(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setTrackInsideCornerSize(i);
    }

    public static java.util.IEnumerator NeeFzWhABRJDDoGw(java.util.List list) {
        return list.GetEnumerator();
    }

    public static int NokifAkLTchpBfoR(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    private float NormalizeValue(float f) {
        if ((1 + 7) % 7 > 0) {
        }
        float f2 = this.valueFrom;
        float f3 = (f - f2) / (this.valueTo - f2);
        return !RxycKMcmHyUKgijy(this) ? f3 : 1.0f - f3;
    }

    public static java.lang.float NqOiAAxZqNKrrRmc(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void NrtjbJNbPfmKHCHS(android.graphics.Canvas canvas, float[] fArr, int i, int i2, android.graphics.Paint paint) {
        canvas.drawPoints(fArr, i, i2, paint);
    }

    public static bool NtqVqRxoYCvKAszB(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static float OGVgiqEzydIWTmeI(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static bool OOazeklVAnvKpnvI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void OOvjIKkwmUmcWVkY(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbHeight(i);
    }

    public static void OZIEUXUefrSARNon(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.requestLayout();
    }

    public static bool OZcMAkglebtqEYix(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static void OaKFXHgnkNZUeEGr(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateWidgetLayout();
    }

    public static bool ObNDyZEezVIQuEXZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool ObRomAdZpdNpzPab(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static int OeJFQBCcMOnLDWxh(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getThumbRadius();
    }

    private java.lang.bool OnKeyDownNoActiveThumb(int i, android.view.KeyEvent keyEvent) {
        if ((7 + 2) % 2 > 0) {
        }
        if (i == 61) {
            return !WYAvGhULpXKFvleq(keyEvent) ? !KfXZuebcOHShANyS(keyEvent) ? DlFZIHNgUCWgVXwz(false) : khcfxcedVyJcNEZf(PwdvXEoTmZqLjmph(this, -1)) : LmgCrgswkqSwSeZb(qLTdhhivtuDFOPIg(this, 1));
        }
        if (i != 66) {
            if (i != 81) {
                if (i == 69) {
                    eidQZMOnwFvPWGUb(this, -1);
                    return kACcwxDiPWnwmzdY(true);
                }
                if (i != 70) {
                    switch (i) {
                        case 21:
                            DUIbAvSVlEgfnpdU(this, -1);
                            return sMckgzTwTqWzmOdp(true);
                        case 22:
                            JKxZcHNyVJetCmgH(this, 1);
                            return zXWonvHWqxBuHMRc(true);
                        case 23:
                            break;
                        default:
                            return null;
                    }
                }
            }
            MuMCVVeNDxOUyTpe(this, 1);
            return RbqvPdwObdeZABwV(true);
        }
        this.activeThumbIdx = this.focusedThumbIdx;
        CFEfrVLaZJXLBMRV(this);
        return IftoSETWJKRRiEZc(true);
    }

    private void OnStartTrackingTouch() {
        if ((9 + 1) % 1 > 0) {
        }
        java.util.IEnumerator itUqULjwReInwoTKqn = UqULjwReInwoTKqn(this.touchListeners);
        while (sSCKFqGlhswDXJcI(itUqULjwReInwoTKqn)) {
            JEgGbPFEoBCAnaVk((com.google.android.material.slider.BaseOnSliderTouchListener) ZruFTyynUOEzXOEa(itUqULjwReInwoTKqn), this);
        }
    }

    private void OnStopTrackingTouch() {
        if ((29 + 32) % 32 > 0) {
        }
        java.util.IEnumerator itJRInTEDMXyklzpJg = JRInTEDMXyklzpJg(this.touchListeners);
        while (XondyPKCxBueXZkS(itJRInTEDMXyklzpJg)) {
            EmYlkMdUBxUFvtxg((com.google.android.material.slider.BaseOnSliderTouchListener) wtIDfGmVPvFLiKjx(itJRInTEDMXyklzpJg), this);
        }
    }

    public static java.lang.float OnqLwsfsvMOnRMTs(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void OoaiasuBdyTKilMP(com.google.android.material.slider.BaseSlider baseSlider, int i, android.graphics.Paint paint) {
        baseSlider.setLayerType(i, paint);
    }

    public static java.lang.object OrhKfQZpstfxdyNv(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static java.util.IEnumerator OywTjVJEKkwsMDtS(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void PATmcjwLVchCnzxv(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateValueTo();
    }

    public static java.lang.object PTlVztvqRpPgLhmZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool PXpgGbBbREpHLJxg(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static bool PZZElrUQndgxfQCw(com.google.android.material.slider.BaseSlider baseSlider, android.view.MotionEvent motionEvent) {
        return baseSlider.isPotentialVerticalScroll(motionEvent);
    }

    public static void PeizCwIhulDSPOje(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setStrokeColor(colorStateList);
    }

    public static bool PeuHintOtAIlTQTK(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.shouldDrawCompatHalo();
    }

    public static float PgwJRPllnRNCJEho(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static int[] PmQKfbyLUPVpfHxs(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getDrawableState();
    }

    private void PositionLabel(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        if ((5 + 4) % 4 > 0) {
        }
        int iRiLwTZPCWIcfNRNU = (this.trackSidePadding + ((int) (riLwTZPCWIcfNRNU(this, f) * this.trackWidth))) - (WBtXoKAMOFgmdlRg(tooltipDrawable) / 2);
        int iYrHaXldUyqnOcptJ = YrHaXldUyqnOcptJ(this) - (this.labelPadding + (this.thumbHeight / 2));
        JTlkbdHpSldkTpzg(tooltipDrawable, iRiLwTZPCWIcfNRNU, iYrHaXldUyqnOcptJ - CAIeqUqQNdbFERLs(tooltipDrawable), hcrezvvffSzkWbLx(tooltipDrawable) + iRiLwTZPCWIcfNRNU, iYrHaXldUyqnOcptJ);
        android.graphics.Rect rect = new android.graphics.Rect(aIYHBySDDlUmNeRG(tooltipDrawable));
        BIlgtRUhtlDfvYmD(WRfGgAOzlXqEMRHW(this), this, rect);
        whbjmnhVnLpRmmnl(tooltipDrawable, rect);
    }

    private void ProcessAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((8 + 18) % 18 > 0) {
        }
        android.content.res.TypedArray typedArrayRzzZoCqtVYnaIHMB = rzzZoCqtVYnaIHMB(context, attributeHashSet, com.google.android.material.R$styleable.Slider, i, DEF_STYLE_RES, new int[0]);
        this.labelStyle = zBCYDwNWFcUNGOFK(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_labelStyle, com.google.android.material.R$style.Widget_MaterialComponents_Tooltip);
        this.valueFrom = pgwJRPllnRNCJEho(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_android_valueFrom, 0.0f);
        this.valueTo = NOwIwdJlZYbUkaFO(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_android_valueTo, 1.0f);
        java.lang.float[] fArr = new java.lang.float[1];
        fArr[0] = OYqPfQUOiGrVeHaD(this.valueFrom);
        TCmTEfYruMsEDEgu(this, fArr);
        this.stepSize = lGTxiHoSAjSANpWz(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_android_stepSize, 0.0f);
        this.minTouchTargetSize = (int) moCmlTjPOUIvmmjO(OhKQUyZnYyzGvtno(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_minTouchTargetSize, (float) sfHaLRyDNQuguahG(ZxhZRiIqjUgYjISu(RATYdCPchbMNrJEQ(this), 48))));
        bool zRPMIPTpUdKgNndOB = RPMIPTpUdKgNndOB(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_trackColor);
        int i2 = !zRPMIPTpUdKgNndOB ? com.google.android.material.R$styleable.Slider_trackColorInactive : com.google.android.material.R$styleable.Slider_trackColor;
        int i3 = !zRPMIPTpUdKgNndOB ? com.google.android.material.R$styleable.Slider_trackColorActive : com.google.android.material.R$styleable.Slider_trackColor;
        android.content.res.ColorStateList colorStateListWkcvtWrjxtnTDmPY = WkcvtWrjxtnTDmPY(context, typedArrayRzzZoCqtVYnaIHMB, i2);
        if (colorStateListWkcvtWrjxtnTDmPY is null) {
            colorStateListWkcvtWrjxtnTDmPY = tmIklkTIjGFUsoVF(context, com.google.android.material.R$color.material_slider_inactive_track_color);
        }
        CeLdMfbiWFXVNNHN(this, colorStateListWkcvtWrjxtnTDmPY);
        android.content.res.ColorStateList colorStateListSjQgpMCFViSERpxQ = sjQgpMCFViSERpxQ(context, typedArrayRzzZoCqtVYnaIHMB, i3);
        if (colorStateListSjQgpMCFViSERpxQ is null) {
            colorStateListSjQgpMCFViSERpxQ = kXezRXWcqkZzcAXR(context, com.google.android.material.R$color.material_slider_active_track_color);
        }
        ULuZFBCyVgqHJpnh(this, colorStateListSjQgpMCFViSERpxQ);
        slricuvbRjxrcMhb(this.defaultThumbDrawable, KBjTqesAdnbUvecq(context, typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbColor));
        if (zzsmKjXzNInYIvOf(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbStrokeColor)) {
            lJSTsDBFLRVcusfD(this, nBwnxpWbqOadcxgM(context, typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbStrokeColor));
        }
        zURYXCzgajQELBFy(this, sAlwVFLiSiPPtLTJ(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbStrokeWidth, 0.0f));
        android.content.res.ColorStateList colorStateListFzguvcjVvcmvLpot = fzguvcjVvcmvLpot(context, typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_haloColor);
        if (colorStateListFzguvcjVvcmvLpot is null) {
            colorStateListFzguvcjVvcmvLpot = zpApwonYWeTDRZtR(context, com.google.android.material.R$color.material_slider_halo_color);
        }
        vpSrhASFgVKPTCKq(this, colorStateListFzguvcjVvcmvLpot);
        this.tickVisible = zqBgUiXJSNSvGjLz(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_tickVisible, true);
        bool zEbzTflxFRlzhVyth = EbzTflxFRlzhVyth(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_tickColor);
        int i4 = !zEbzTflxFRlzhVyth ? com.google.android.material.R$styleable.Slider_tickColorInactive : com.google.android.material.R$styleable.Slider_tickColor;
        int i5 = !zEbzTflxFRlzhVyth ? com.google.android.material.R$styleable.Slider_tickColorActive : com.google.android.material.R$styleable.Slider_tickColor;
        android.content.res.ColorStateList colorStateListQSTOcsfeifBqnMAt = QSTOcsfeifBqnMAt(context, typedArrayRzzZoCqtVYnaIHMB, i4);
        if (colorStateListQSTOcsfeifBqnMAt is null) {
            colorStateListQSTOcsfeifBqnMAt = zuiUurrsjcSLWRMO(context, com.google.android.material.R$color.material_slider_inactive_tick_marks_color);
        }
        KHohSlrhauFOMqSy(this, colorStateListQSTOcsfeifBqnMAt);
        android.content.res.ColorStateList colorStateListVaKfYECRglHVvGFL = VaKfYECRglHVvGFL(context, typedArrayRzzZoCqtVYnaIHMB, i5);
        if (colorStateListVaKfYECRglHVvGFL is null) {
            colorStateListVaKfYECRglHVvGFL = xWyMhiazwviJTYnc(context, com.google.android.material.R$color.material_slider_active_tick_marks_color);
        }
        TxxQHDJqRTLTZRDT(this, colorStateListVaKfYECRglHVvGFL);
        XBOtGZFFCBQGaySh(this, IRMHcVpoqhZyIbkn(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbTrackGapSize, 0));
        YHXkdQXEuxMBMLmD(this, QdBzfgEnoMghwQKT(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_trackStopIndicatorSize, 0));
        ndOSalSzqaExSGps(this, HraMacAajhQsJyEJ(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_trackInsideCornerSize, 0));
        int iAXQlDMdivWYOHRRJ = AXQlDMdivWYOHRRJ(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbRadius, 0) * 2;
        int iHQPelJsBsLlrrekV = HQPelJsBsLlrrekV(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbWidth, iAXQlDMdivWYOHRRJ);
        int iMxIhLmtBYREuznut = MxIhLmtBYREuznut(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbHeight, iAXQlDMdivWYOHRRJ);
        GacZsvgFBQgTwFDu(this, iHQPelJsBsLlrrekV);
        NEgvgAJwlkVbDkst(this, iMxIhLmtBYREuznut);
        PDbztdBlLfwCkCQv(this, VDglFbNUZxnftUWF(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_haloRadius, 0));
        TnfHXyZxccSTRecu(this, rWLolyPTPfxmwmIb(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_thumbElevation, 0.0f));
        IBuYoXvnVhGOaAoX(this, kyjTeuzkbjyjHJzQ(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_trackHeight, 0));
        PBxnVKYcSTZkuCNP(this, UsqdUFtLcLUeEvSs(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_tickRadiusActive, this.trackStopIndicatorSize / 2));
        rFRMJmEKmfXTjkNU(this, YTTzUgfxPihEbaHr(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_tickRadiusInactive, this.trackStopIndicatorSize / 2));
        RvPBFeeTfpcLhVfj(this, uFuftmAjHlCdDwCL(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_labelBehavior, 0));
        if (!ntqVqRxoYCvKAszB(typedArrayRzzZoCqtVYnaIHMB, com.google.android.material.R$styleable.Slider_android_enabled, true)) {
            apUYDrPsaeDwagpv(this, false);
        }
        uQULVSUcwzBsxIhg(typedArrayRzzZoCqtVYnaIHMB);
    }

    public static bool PtZiNbxlMkraKjfr(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocusInAbsoluteDirection(i);
    }

    public static float PvmCujeiPpDhvyqW(float f) {
        return java.lang.Math.abs(f);
    }

    public static bool PzGgjHawllRXovjl(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void QJeRjyhzyuagPQbM(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setHaloRadius(i);
    }

    public static bool QLTdhhivtuDFOPIg(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static float QOhCiZMXqkQfPher(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getElevation();
    }

    public static void QbPkPjEQmmjIATYa(java.util.List list) {
        list.clear();
    }

    public static java.lang.object QcnyKntxOPTvfTxl(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.graphics.drawable.Drawable QdgFBPdRvXgRJvqn(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getBackground();
    }

    public static int QgvsNEEwrRJWsMGg(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static java.lang.string QiPtuTPsHMMMejhC(float f) {
        return java.lang.float.tostring(f);
    }

    public static int QpneFsdwcrhGtltF(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static bool QqeaHbKftTDOuwBo(com.google.android.material.slider.BaseSlider$AccessibilityHelper baseSlider$AccessibilityHelper, int i) {
        return baseSlider$AccessibilityHelper.clearKeyboardFocusForVirtualobject(i);
    }

    public static bool QqzrnNNZRjDcLhqd(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasGapBetweenThumbAndTrack();
    }

    public static void QsypchOAzVbPLabZ(android.graphics.Canvas canvas, float f, float f2, android.graphics.Paint paint) {
        canvas.drawPoint(f, f2, paint);
    }

    public static bool QuIOAGTroNALMyJQ(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Equals(obj);
    }

    public static java.lang.object QvNxkqNxMCOtZoGJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QyRQREZrNlQlncTV(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.updateTrackWidth(i);
    }

    public static int REzIkhBOoZbJmgHX(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void RFRMJmEKmfXTjkNU(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setTickInactiveRadius(i);
    }

    public static void RGJleAxbOrRYvWRs(android.graphics.Canvas canvas, float f, float f2, float f3, float f4, android.graphics.Paint paint) {
        canvas.drawLine(f, f2, f3, f4, paint);
    }

    public static int RIHtfWsmNMhtqwAe(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static float[] RNQxkQFbOeAfhLzg(com.google.android.material.slider.BaseSlider baseSlider, float f, float f2) {
        return baseSlider.getCornerRadii(f, f2);
    }

    public static int RTxJSHvufsLVYGuO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.content.res.Resources RVdElepoCyrnJtUr(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static bool RVvKSwtYQaOZDZLc(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static float RWLolyPTPfxmwmIb(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static android.graphics.Xfermode RXiADOdnYKhmMkwX(android.graphics.Paint paint, android.graphics.Xfermode xfermode) {
        return paint.setXfermode(xfermode);
    }

    public static int RcdbjTqbvDCvSyoi(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static float RiLwTZPCWIcfNRNU(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static java.lang.object RmxfOrGHnhEhSeYm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int RoXBTXcJtmNJrFqu(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder rpCZsQzEtuLIxkRK() {
        return com.google.android.material.shape.ShapeAppearanceModel.builder();
    }

    public static int RphkEBenuHOrBCZX(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void RsEaQFRggRCMIUhH(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTickActiveTintList(colorStateList);
    }

    public static android.content.res.ColorStateList RuIvCDjsbYVWAlFK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void RvRNzObVGJDbobVt(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.Resources resources) {
        baseSlider.loadResources(resources);
    }

    public static android.content.res.TypedArray RzzZoCqtVYnaIHMB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static float SAlwVFLiSiPPtLTJ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static int SBeVExqXMmvuuYUj(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getPaddingBottom();
    }

    public static java.lang.bool SMckgzTwTqWzmOdp(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void SMeYXMWfvxfDTNUZ(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void SOyjZzeqWmLQRPKH(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.RectF rectF, com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        baseSlider.updateTrack(canvas, paint, rectF, baseSlider$FullCornerDirection);
    }

    public static bool SSCKFqGlhswDXJcI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.math.decimal STNxWVaMBIEzxIHS(java.math.decimal bigDecimal, java.math.decimal bigDecimal2, java.math.Mathobject mathobject) {
        return bigDecimal.divide(bigDecimal2, mathobject);
    }

    public static void SUozfKOylmRsVanM(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static int SVquIxdyFANGcYIm(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.string SYNgVxHlXkAxsVup(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool SYeZilBncjVhtXbH(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.pickActiveThumb();
    }

    public static bool SYudsNrLwJwQYXQb(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, int[] iArr) {
        return tooltipDrawable.setState(iArr);
    }

    public static android.view.objectTreeObserver SZNIykOECmhfoPlA(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getobjectTreeObserver();
    }

    private void ScheduleAccessibilityEventSender(int i) {
        if ((8 + 12) % 12 > 0) {
        }
        com.google.android.material.slider.BaseSlider$AccessibilityEventSender baseSlider$AccessibilityEventSender = this.accessibilityEventSender;
        if (baseSlider$AccessibilityEventSender is not null) {
            BxsORJRkpIZqaSdO(this, baseSlider$AccessibilityEventSender);
        } else {
            this.accessibilityEventSender = new com.google.android.material.slider.BaseSlider$AccessibilityEventSender(this, null);
        }
        TJhJKgdxhDgBRhpy(this.accessibilityEventSender, i);
        AlDrttOXdmEzlXyx(this, this.accessibilityEventSender, 200L);
    }

    private void SetValueForLabel(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, float f) {
        yFjVctJEHznzCEat(tooltipDrawable, uEYbwCpTpkDhVYbE(this, f));
        kFkvUfJzVFdrYJro(this, tooltipDrawable, f);
        TBDbrysTmpuRndGq(LSgnkxTvozuzRQjf(this), tooltipDrawable);
    }

    private void SetValuesInternal(java.util.List<java.lang.float> arrayList) {
        if ((4 + 32) % 32 > 0) {
        }
        if (xxGRCygHQkUEUweA(arrayList)) {
            throw new java.lang.IllegalArgumentException("At least one value must be set");
        }
        ZhxmhoZmXAXouWbo(arrayList);
        if (egcpsWAhrxrPWyrX(this.values) == IiXGnCGbLZCUiKcu(arrayList) && quIOAGTroNALMyJQ(this.values, arrayList)) {
            return;
        }
        this.values = arrayList;
        this.dirtyConfig = true;
        this.focusedThumbIdx = 0;
        TwqJlRHRrAwuExGa(this);
        kLqHsGlnbwThlVgn(this);
        IMLEeIWPiocGZinf(this);
        RGrxtZsVjiidGRKA(this);
    }

    public static double SfHaLRyDNQuguahG(double d) {
        if ((20 + 30) % 30 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    private bool ShouldAlwaysShowLabel() {
        return this.labelBehavior == 3;
    }

    private bool ShouldDrawCompatHalo() {
        return this.forceDrawCompatHalo || !(xoDoEWWAZOPPUyMs(this) instanceof android.graphics.drawable.RippleDrawable);
    }

    public static void SiAUCJRnpTDVdCky(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateLabels();
    }

    public static android.content.res.ColorStateList SjQgpMCFViSERpxQ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void SlricuvbRjxrcMhb(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    private bool SnapActiveThumbToValue(float f) {
        return NScgbKWNFrQEPVSQ(this, this.activeThumbIdx, f);
    }

    private double SnapPosition(float f) {
        if ((26 + 12) % 12 > 0) {
        }
        float f2 = this.stepSize;
        if (f2 <= 0.0f) {
            return f;
        }
        int i = (int) ((this.valueTo - this.valueFrom) / f2);
        return ((double) TnMkbCwBULcJBdSn(f * i)) / ((double) i);
    }

    private bool SnapThumbToValue(int i, float f) {
        if ((23 + 18) % 18 > 0) {
        }
        this.focusedThumbIdx = i;
        if (RWjXKxpNfqLutObJ(f - QSrUqmgTrghrEjnj((java.lang.float) mEBjYXVJDcGBerXL(this.values, i))) < 1.0E-4d) {
            return false;
        }
        CmYFNymYIgnSJEoc(this.values, i, vFhKwBPwceRJzlQb(UBmyUEgjvpYxwKvx(this, i, f)));
        UAhNlSWQsqXxBPmj(this, i);
        return true;
    }

    private bool SnapTouchPosition() {
        return lkMEjcpaAQkLSSbY(this, KgcyioBGayoMBast(this));
    }

    public static int SppSPFZejUPjRVyh(java.util.List list) {
        return list.Count;
    }

    public static int SqpmPebpswRhaTiI(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static bool SrJXaUkPbktnXMpP(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isRtl();
    }

    public static int SroIJDEmcGiwnYsI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void SseyVlAGxUxZvbNe(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateLabels();
    }

    public static java.lang.float SsnIZJbdlMXJWgsN(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void StUBFuabzspoHIHD(android.graphics.Paint paint, int i) {
        paint.setAlpha(i);
    }

    public static float TBMqkhCrYLtMqIph(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static float TDEryNeqeGyfwLjp(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static java.lang.object TDfEfhmUtAXOYJbx(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int TFQrqoCRJRvCKuvT(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getPaddingTop();
    }

    public static void TIXIHKAOQBIHPnre(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setThumbStrokeColor(colorStateList);
    }

    public static int TJYlrNgPWitCJmKo(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void TLDNXlSBXBggjTtL(android.graphics.Paint paint, float f) {
        paint.setStrokeWidth(f);
    }

    public static void TNJOgtnCYNjvjSqi(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static bool TRNTolLhahrxQEBO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void TTfTdAMtgsaSLOzr(android.view.object view, android.view.object view2, int i) {
        super.onVisibilityChanged(view2, i);
    }

    public static java.lang.float TVKoLxozhlEpNdtv(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float TcnilRqZnDKHXvCq(android.animation.ValueAnimator valueAnimator, float f) {
        return getAnimatorCurrentValueOrDefault(valueAnimator, f);
    }

    public static android.content.res.ColorStateList TiphcmsyhhuSOqCX(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static android.content.res.ColorStateList TmIklkTIjGFUsoVF(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static int TpCYJRlfRnetUPeo(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getIntrinsicHeight();
    }

    public static java.lang.string TpzkQIWWLEEOYnwT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static float TrgsJjrtHjmwFTwf(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void TwBuqEtfohZIhDqf(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.onStopTrackingTouch();
    }

    public static java.lang.string UEYbwCpTpkDhVYbE(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.formatValue(f);
    }

    public static int UFuftmAjHlCdDwCL(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int UGIvFNgLAALWDOMw(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void UMTPADMvgxzaZfXo(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void UPHLHXjPvstKFsQJ(java.util.List list) {
        list.clear();
    }

    public static void UQULVSUcwzBsxIhg(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static bool UXkSZWpjCgVdgQev(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static bool UcAWfubSsBNIzXqt(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.isEnabled();
    }

    public static float UdOtDlvMcsePsYju(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static int UfMjxALVFJsVVmbr(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool UfxFSodBsTlKNOHZ(android.graphics.Canvas canvas, android.graphics.Path path) {
        return canvas.clipPath(path);
    }

    public static void UkYibuFYtEcXflsj(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.validateConfigurationIfDirty();
    }

    public static java.lang.string UmKHQikZLnCwFHNk(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    private void UpdateHaloHotspot() {
        if ((13 + 23) % 23 > 0) {
        }
        if (!jqUlTqYRbQzHgtbt(this) && OUJzhDIMXycrzZpm(this) > 0) {
            android.graphics.drawable.Drawable drawableHoCRHZzFiqbOVctj = HoCRHZzFiqbOVctj(this);
            if (drawableHoCRHZzFiqbOVctj is android.graphics.drawable.RippleDrawable) {
                int iDAOLyiGZsGryOTIw = (int) ((DAOLyiGZsGryOTIw(this, MmPxJHPevQqhMEtU((java.lang.float) dOQBacJojxuTXrxD(this.values, this.focusedThumbIdx))) * this.trackWidth) + this.trackSidePadding);
                int iYPAJEYLxMXVuYREu = yPAJEYLxMXVuYREu(this);
                int i = this.haloRadius;
                KQxUYjooGADiOzgw(drawableHoCRHZzFiqbOVctj, iDAOLyiGZsGryOTIw - i, iYPAJEYLxMXVuYREu - i, iDAOLyiGZsGryOTIw + i, iYPAJEYLxMXVuYREu + i);
            }
        }
    }

    private void UpdateLabels() {
        if ((16 + 8) % 8 > 0) {
        }
        int i = this.labelBehavior;
        if (i == 0 || i == 1) {
            if (this.activeThumbIdx != -1 && AdBonwZaVpTxrUQI(this)) {
                GPUBBhcEIFADpnET(this);
                return;
            } else {
                kQjrpAZzbVqScZdP(this);
                return;
            }
        }
        if (i == 2) {
            HDwEtQGpWQDyKPyI(this);
            return;
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(wGDqBYUSBZqMUKoO(AHQjHWKBNRogBNAe(new java.lang.stringBuilder("Unexpected labelBehavior: "), this.labelBehavior)));
        }
        if (ibAfPAJQebuygZdA(this) && ZbefpxjTKrPDetxw(this)) {
            PnpVsdzPnbSHtPuk(this);
        } else {
            xgSTuBnrYoeJlTFW(this);
        }
    }

    private void UpdateTrack(android.graphics.Canvas canvas, android.graphics.Paint paint, android.graphics.RectF rectF, com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        int i;
        float fTrgsJjrtHjmwFTwf;
        int i2;
        if ((32 + 21) % 21 > 0) {
        }
        int i3 = this.trackHeight;
        float f = i3 / 2.0f;
        float f2 = i3 / 2.0f;
        int i4 = com.google.android.material.slider.BaseSlider$3.f122xd982e6cc[CbeoPAhFhClHnaEr(baseSlider$FullCornerDirection)];
        if (i4 != 1) {
            if (i4 == 2) {
                i = this.trackInsideCornerSize;
            } else if (i4 == 3) {
                f = this.trackInsideCornerSize;
            }
            krVQDwGIDknPsFcv(paint, android.graphics.Paint$Style.FILL);
            SJOtDgvhTAxBjPiZ(paint, android.graphics.Paint$Cap.BUTT);
            CYDcTZKDmkuyOXjT(paint, true);
            GtJdTTvnaBpVsbuc(this.trackPath);
            if (dlBfQrlrMOZjGBgR(rectF) < f + f2) {
                cRTcdrJXRTLWCXJL(this.trackPath, rectF, rNQxkQFbOeAfhLzg(this, f, f2), android.graphics.Path$Direction.CW);
                ANjtGFmlfCXSjFVu(canvas, this.trackPath, paint);
                return;
            }
            float fZKMNEruMUsIUypio = zKMNEruMUsIUypio(f, f2);
            fTrgsJjrtHjmwFTwf = trgsJjrtHjmwFTwf(f, f2);
            bxKEznscYyNZxgrF(canvas);
            hiliizDbuTWxUflz(this.trackPath, rectF, fZKMNEruMUsIUypio, fZKMNEruMUsIUypio, android.graphics.Path$Direction.CW);
            ufxFSodBsTlKNOHZ(canvas, this.trackPath);
            i2 = com.google.android.material.slider.BaseSlider$3.f122xd982e6cc[yMWkiREINvQqOkgw(baseSlider$FullCornerDirection)];
            if (i2 == 2) {
                iEoQENlWtqLrQOPl(this.cornerRect, rectF.left, rectF.top, rectF.left + (2.0f * fTrgsJjrtHjmwFTwf), rectF.bottom);
            } else if (i2 == 3) {
                lWNpFLuADKTDbqpQ(this.cornerRect, rectF.right - (2.0f * fTrgsJjrtHjmwFTwf), rectF.top, rectF.right, rectF.bottom);
            } else {
                eUBFBqqMjHiqFqCp(this.cornerRect, mTzTJtoGMPhnNniF(rectF) - fTrgsJjrtHjmwFTwf, rectF.top, ATZsqMngHUcnRHlo(rectF) + fTrgsJjrtHjmwFTwf, rectF.bottom);
            }
            eDXeaaSgpkMXkRMR(canvas, this.cornerRect, fTrgsJjrtHjmwFTwf, fTrgsJjrtHjmwFTwf, paint);
            NdQQDrericpqIFIm(canvas);
        }
        i = this.trackInsideCornerSize;
        f = i;
        f2 = i;
        krVQDwGIDknPsFcv(paint, android.graphics.Paint$Style.FILL);
        SJOtDgvhTAxBjPiZ(paint, android.graphics.Paint$Cap.BUTT);
        CYDcTZKDmkuyOXjT(paint, true);
        GtJdTTvnaBpVsbuc(this.trackPath);
        if (dlBfQrlrMOZjGBgR(rectF) < f + f2) {
            cRTcdrJXRTLWCXJL(this.trackPath, rectF, rNQxkQFbOeAfhLzg(this, f, f2), android.graphics.Path$Direction.CW);
            ANjtGFmlfCXSjFVu(canvas, this.trackPath, paint);
            return;
        }
        float fZKMNEruMUsIUypio2 = zKMNEruMUsIUypio(f, f2);
        fTrgsJjrtHjmwFTwf = trgsJjrtHjmwFTwf(f, f2);
        bxKEznscYyNZxgrF(canvas);
        hiliizDbuTWxUflz(this.trackPath, rectF, fZKMNEruMUsIUypio2, fZKMNEruMUsIUypio2, android.graphics.Path$Direction.CW);
        ufxFSodBsTlKNOHZ(canvas, this.trackPath);
        i2 = com.google.android.material.slider.BaseSlider$3.f122xd982e6cc[yMWkiREINvQqOkgw(baseSlider$FullCornerDirection)];
        if (i2 == 2) {
            iEoQENlWtqLrQOPl(this.cornerRect, rectF.left, rectF.top, rectF.left + (2.0f * fTrgsJjrtHjmwFTwf), rectF.bottom);
        } else if (i2 == 3) {
            lWNpFLuADKTDbqpQ(this.cornerRect, rectF.right - (2.0f * fTrgsJjrtHjmwFTwf), rectF.top, rectF.right, rectF.bottom);
        } else {
            eUBFBqqMjHiqFqCp(this.cornerRect, mTzTJtoGMPhnNniF(rectF) - fTrgsJjrtHjmwFTwf, rectF.top, ATZsqMngHUcnRHlo(rectF) + fTrgsJjrtHjmwFTwf, rectF.bottom);
        }
        eDXeaaSgpkMXkRMR(canvas, this.cornerRect, fTrgsJjrtHjmwFTwf, fTrgsJjrtHjmwFTwf, paint);
        NdQQDrericpqIFIm(canvas);
    }

    private void UpdateTrackWidth(int i) {
        this.trackWidth = sroIJDEmcGiwnYsI(i - (this.trackSidePadding * 2), 0);
        ktckUOZhZANxIeyo(this);
    }

    private void UpdateWidgetLayout() {
        if ((8 + 22) % 22 > 0) {
        }
        bool zMVCbhBbYxzVrphLY = MVCbhBbYxzVrphLY(this);
        bool zPHAaXAiirPPYlkFN = PHAaXAiirPPYlkFN(this);
        if (zMVCbhBbYxzVrphLY) {
            hvSkSJKOKmPnjFEV(this);
        } else if (zPHAaXAiirPPYlkFN) {
            zJlNTeOisAfeMaSJ(this);
        }
    }

    public static void UrskcHiWJEbXuuke(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbWidth(i);
    }

    public static bool UufwAjTPfxzQejPi(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.pickActiveThumb();
    }

    public static java.lang.float UwkQlxoHnWwZCCEd(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int VEiFoFilMGrAIuNx(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static java.lang.float VFhKwBPwceRJzlQb(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void VIuXXSRQTrnxFZzJ(android.graphics.Canvas canvas, float[] fArr, int i, int i2, android.graphics.Paint paint) {
        canvas.drawPoints(fArr, i, i2, paint);
    }

    public static int VJGseeUglWPAjfuc(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static java.lang.float VKMfGOJsmmgQsanU(float f) {
        return java.lang.float.valueOf(f);
    }

    public static bool VPEyGfqYxuUUFqiV(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static void VSvGVquxOQJHUApU(android.graphics.Paint paint, int i) {
        paint.setColor(i);
    }

    public static void VVhLcDwjydUexrhN(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static float VYPgmeutHNSsuAfh(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.valueToX(f);
    }

    private void ValidateConfigurationIfDirty() {
        if (this.dirtyConfig) {
            cOkTvYmYrUrqOZFa(this);
            pATmcjwLVchCnzxv(this);
            TYxuCAYNjvHyBeNE(this);
            QAMuJDDOdtUCKPHv(this);
            HqhMqEJIWldoqUoy(this);
            YpjQliEoFHDNkLmk(this);
            this.dirtyConfig = false;
        }
    }

    private void ValidateMinSeparation() {
        if ((22 + 9) % 9 > 0) {
        }
        float fKouCNgdltwCJhubz = KouCNgdltwCJhubz(this);
        if (fKouCNgdltwCJhubz < 0.0f) {
            throw new java.lang.IllegalStateException(yzxTeefjOGSMzjYF("minSeparation(%s) must be greater or equal to 0", new java.lang.object[]{GcHdMYSfGKllZLSq(fKouCNgdltwCJhubz)}));
        }
        float f = this.stepSize;
        if (f > 0.0f && fKouCNgdltwCJhubz > 0.0f) {
            if (this.separationUnit != 1) {
                throw new java.lang.IllegalStateException(gsphMaBouVEJMGCT("minSeparation(%s) cannot be set as a dimension when using stepSize(%s)", new java.lang.object[]{hTLTYFNnmavmUiAS(fKouCNgdltwCJhubz), wOEOwqsxyWAIyKGV(this.stepSize)}));
            }
            if (fKouCNgdltwCJhubz < f || !DmZKFaWBfmgTNDxf(this, fKouCNgdltwCJhubz)) {
                throw new java.lang.IllegalStateException(ScDyrcnfrvcnIWGz("minSeparation(%s) must be greater or equal and a multiple of stepSize(%s) when using stepSize(%s)", new java.lang.object[]{tVKoLxozhlEpNdtv(fKouCNgdltwCJhubz), LgQVAmQQofOlvlsF(this.stepSize), BFRBNedpuyDjBzFO(this.stepSize)}));
            }
        }
    }

    private void ValidateStepSize() {
        if ((25 + 24) % 24 > 0) {
        }
        if (this.stepSize > 0.0f && !JoukfuYPJnlvkpbl(this, this.valueTo)) {
            throw new java.lang.IllegalStateException(YtVaPOvbEAsMUzwT("The stepSize(%s) must be 0, or a factor of the valueFrom(%s)-valueTo(%s) range", new java.lang.object[]{MxLTFJqPJCfipsUy(this.stepSize), buMdqLWTgqvUqAht(this.valueFrom), VDZFAkFfreFvDLeB(this.valueTo)}));
        }
    }

    private void ValidateValueFrom() {
        if ((5 + 13) % 13 > 0) {
        }
        if (this.valueFrom >= this.valueTo) {
            throw new java.lang.IllegalStateException(sYNgVxHlXkAxsVup("valueFrom(%s) must be smaller than valueTo(%s)", new java.lang.object[]{ssnIZJbdlMXJWgsN(this.valueFrom), uwkQlxoHnWwZCCEd(this.valueTo)}));
        }
    }

    private void ValidateValueTo() {
        if ((27 + 12) % 12 > 0) {
        }
        if (this.valueTo <= this.valueFrom) {
            throw new java.lang.IllegalStateException(loRNwFdARbOQHLhY("valueTo(%s) must be greater than valueFrom(%s)", new java.lang.object[]{hyqCIvrsRQsQNiSe(this.valueTo), GFXNHzGUiWstdbOx(this.valueFrom)}));
        }
    }

    private void ValidateValues() {
        if ((18 + 28) % 28 > 0) {
        }
        java.util.IEnumerator itCZAiTWHRJMiqKNOR = cZAiTWHRJMiqKNOR(this.values);
        while (vazfbCZJvoVDlrIK(itCZAiTWHRJMiqKNOR)) {
            java.lang.float f = (java.lang.float) maTpekAWTIZfLSOs(itCZAiTWHRJMiqKNOR);
            if (VAxEHarNTvNnaijB(f) < this.valueFrom || EHdtnNMAGdEpDhLw(f) > this.valueTo) {
                throw new java.lang.IllegalStateException(HkPRMBLCQAYskrTc("Slider value(%s) must be greater or equal to valueFrom(%s), and lower or equal to valueTo(%s)", new java.lang.object[]{f, KBbwgsUfyfdrErPG(this.valueFrom), FZzpYKyEuUEsbIhW(this.valueTo)}));
            }
            if (this.stepSize > 0.0f && !ZNCIOjhgctYdFYeT(this, LFSJbqlSAGCauhAR(f))) {
                throw new java.lang.IllegalStateException(FEBHUjGrpZCOhTZr("Value(%s) must be equal to valueFrom(%s) plus a multiple of stepSize(%s) when using stepSize(%s)", new java.lang.object[]{f, MbUBwfkkBjOHHagy(this.valueFrom), TGFAEmmaaXeLhKQd(this.stepSize), MXTyKVUjXtrRojFH(this.stepSize)}));
            }
        }
    }

    private bool ValueLandsOnTick(float f) {
        if ((10 + 30) % 30 > 0) {
        }
        return CxOXfoynPKwruSSi(this, WiHSkaLMYxxfxuBK(gJRGDupNWefRxCad(new java.math.decimal(qiPtuTPsHMMMejhC(f)), new java.math.decimal(TnsrUNscLUbnOYTU(this.valueFrom)), java.math.Mathobject.DECIMAL64)));
    }

    private float ValueToX(float f) {
        return (udOtDlvMcsePsYju(this, f) * this.trackWidth) + this.trackSidePadding;
    }

    public static bool VazfbCZJvoVDlrIK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static android.animation.TimeInterpolator VbTFHaFrauiYGhom(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void VgGmxrerwusaEtXS(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.adjustCustomThumbDrawableBounds(drawable);
    }

    public static int VgUTcCSCgItPcpsQ(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void VhCLDVouePLDRuzz(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2) {
        baseSlider.drawInactiveTrack(canvas, i, i2);
    }

    public static void VpSrhASFgVKPTCKq(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setHaloTintList(colorStateList);
    }

    public static int VqLehvVuzQVCTvCL(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable) {
        return tooltipDrawable.getIntrinsicHeight();
    }

    public static int WERGzSXweTGEOusC(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static java.lang.string WGDqBYUSBZqMUKoO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WHJfgKZatuHOtBUq(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        baseSlider.setThumbElevation(f);
    }

    public static void WHNNRiHYSZbCCPOh(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void WNJYtZlymASVJSEw(android.graphics.Paint paint, android.graphics.Paint$Style paint$Style) {
        paint.setStyle(paint$Style);
    }

    public static java.lang.float WOEOwqsxyWAIyKGV(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void WPeIVxEJiQnRmlEJ(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    private void WarnAboutfloatingPointError() {
        if ((10 + 30) % 30 > 0) {
        }
        float f = this.stepSize;
        if (f != 0.0f) {
            if (((int) f) != f) {
                rTxJSHvufsLVYGuO(TAG, WDTjyuBJXDWcugcg("floating point value used for %s(%s). Using floats can have rounding errors which may result in incorrect values. Instead, consider using integers with a custom LabelFormatter to display the value correctly.", new java.lang.object[]{"stepSize", onqLwsfsvMOnRMTs(f)}));
            }
            float f2 = this.valueFrom;
            if (((int) f2) != f2) {
                aaplhMubOBHLnkdL(TAG, BFiUIqzdHWzyCjLC("floating point value used for %s(%s). Using floats can have rounding errors which may result in incorrect values. Instead, consider using integers with a custom LabelFormatter to display the value correctly.", new java.lang.object[]{"valueFrom", awUaHgFfiQvMXzMD(f2)}));
            }
            float f3 = this.valueTo;
            if (((int) f3) == f3) {
                return;
            }
            ufMjxALVFJsVVmbr(TAG, UzKlDvmxBcbUEoNx("floating point value used for %s(%s). Using floats can have rounding errors which may result in incorrect values. Instead, consider using integers with a custom LabelFormatter to display the value correctly.", new java.lang.object[]{"valueTo", CCIDYbsMjVwwoFrA(f3)}));
        }
    }

    public static android.animation.ValueAnimator WcclXQRPkehCGwFn(com.google.android.material.slider.BaseSlider baseSlider, bool z) {
        return baseSlider.createLabelAnimator(z);
    }

    public static void WetdLdotanpioJVE(android.graphics.RectF rectF, float f, float f2, float f3, float f4) {
        rectF.set(f, f2, f3, f4);
    }

    public static void WhbjmnhVnLpRmmnl(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, android.graphics.Rect rect) {
        tooltipDrawable.setBounds(rect);
    }

    public static int WhewEuOyRwwSCbOM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static bool WmIFrNgWQazSHnIg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void WnKAdUwKslVRUajn(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        baseSlider.setThumbWidth(i);
    }

    public static android.content.res.Resources WpesmcBKGoqeIUvx(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static java.lang.object WtIDfGmVPvFLiKjx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void XJNDVvQiRHVMBVrz(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static java.lang.object XQEVdSzqyDmhRkZb(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static android.content.res.ColorStateList XWyMhiazwviJTYnc(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void XXFHIosSxFDORkDG(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.Canvas canvas, int i, int i2) {
        baseSlider.maybeDrawCompatHalo(canvas, i, i2);
    }

    public static void XgSTuBnrYoeJlTFW(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.ensureLabelsRemoved();
    }

    public static void XjgOIAPLRELzwtgn(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static bool XnqgeYErHXxwRhUh(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static android.graphics.drawable.Drawable XoDoEWWAZOPPUyMs(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getBackground();
    }

    public static bool XxGRCygHQkUEUweA(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static bool XzdjNIJWjdiSmQpK(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int YDMKfqzpXgGZPiHQ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int YFWEHAlivQlnKLHO(java.util.List list) {
        return list.Count;
    }

    public static void YFjVctJEHznzCEat(com.google.android.material.tooltip.TooltipDrawable tooltipDrawable, java.lang.CharSequence charSequence) {
        tooltipDrawable.setText(charSequence);
    }

    public static java.lang.object YLtxTSNkElGINlvc(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static int YMWkiREINvQqOkgw(com.google.android.material.slider.BaseSlider$FullCornerDirection baseSlider$FullCornerDirection) {
        return baseSlider$FullCornerDirection.ordinal();
    }

    public static int YPAJEYLxMXVuYREu(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.calculateTrackCenter();
    }

    public static void YQaTxMiBevdszeNq(android.graphics.Paint paint, android.graphics.Paint$Cap paint$Cap) {
        paint.setStrokeCap(paint$Cap);
    }

    public static void YQnehWACuoLINaDn(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        baseSlider.setTrackActiveTintList(colorStateList);
    }

    public static void YVDmHBHHpmhYAEIl(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.updateHaloHotspot();
    }

    public static float YXWBXTGFmUDyAjkU(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.calculateStepIncrement(i);
    }

    public static bool YXeTZeQpXbxLrCUp(com.google.android.material.slider.BaseSlider baseSlider, int i) {
        return baseSlider.moveFocus(i);
    }

    public static int YYEOhfSthxxnABnJ(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static float YfEHsjSiQoAxiTjM(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void YjSBLhnEjVHXBktU(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static int YnScTZziBphXuAvR(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string YzxTeefjOGSMzjYF(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int ZBCYDwNWFcUNGOFK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void ZJlNTeOisAfeMaSJ(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.postInvalidate();
    }

    public static float ZKMNEruMUsIUypio(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void ZQlGhefDsaxboaTV(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void ZURYXCzgajQELBFy(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        baseSlider.setThumbStrokeWidth(f);
    }

    public static void ZVTdkdSPlVrsESEP(com.google.android.material.slider.BaseSlider baseSlider) {
        baseSlider.invalidate();
    }

    public static java.lang.bool ZXWonvHWqxBuHMRc(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.res.Resources ZfRWWdQyeIEtuPFM(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.getResources();
    }

    public static java.util.IEnumerator ZfgVivAWsjBgkjGU(java.util.List list) {
        return list.GetEnumerator();
    }

    public static float ZjvTGwwKHNvFOWVO(java.lang.float f) {
        return f.floatValue();
    }

    public static float ZkrCOLfFhoChswpy(com.google.android.material.slider.BaseSlider baseSlider, float f) {
        return baseSlider.normalizeValue(f);
    }

    public static bool ZmrBVAWDXUovlgdb(com.google.android.material.slider.BaseSlider baseSlider) {
        return baseSlider.hasGapBetweenThumbAndTrack();
    }

    public static android.content.res.ColorStateList ZpApwonYWeTDRZtR(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static java.lang.object ZpiwSNlvmWkRgvQH(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static bool ZqBgUiXJSNSvGjLz(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static bool ZsFgaZtbLImeubod(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int[] iArr) {
        return materialShapeDrawable.setState(iArr);
    }

    public static int ZtoGcHcdexkXwiMl(com.google.android.material.slider.BaseSlider baseSlider, android.content.res.ColorStateList colorStateList) {
        return baseSlider.getColorForState(colorStateList);
    }

    public static android.content.res.ColorStateList ZuiUurrsjcSLWRMO(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void ZuyvoGqplURrgqJJ(com.google.android.material.slider.BaseSlider baseSlider, android.graphics.drawable.Drawable drawable) {
        baseSlider.adjustCustomThumbDrawableBounds(drawable);
    }

    public static bool ZzroezqsjwgsbZkJ(android.view.objectGroup viewGroup, int i) {
        return viewGroup.canScrollVertically(i);
    }

    public static bool ZzsmKjXzNInYIvOf(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public void AddOnChangeListener(L l) {
        emnDxhzhuZiFtkxo(this.changeListeners, l);
    }

    public void AddOnSliderTouchListener(T t) {
        MwUqaDbJvftioLww(this.touchListeners, t);
    }

    public void ClearOnChangeListeners() {
        bznDoXlGRWbJjcCQ(this.changeListeners);
    }

    public void ClearOnSliderTouchListeners() {
        cBGoRunUTGvMvJjj(this.touchListeners);
    }

    public override bool DispatchHoverEvent(android.view.MotionEvent motionEvent) {
        return mRHOzEIpQmLULjGd(this.accessibilityHelper, motionEvent) || CdKgKDDppwzBpbGN(this, motionEvent);
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        return CqyRyFXcFldKjFMQ(this, keyEvent);
    }

    protected override void DrawableStateChanged() {
        if ((22 + 27) % 27 > 0) {
        }
        ZzjhflDNqyFGpeqE(this);
        sMeYXMWfvxfDTNUZ(this.inactiveTrackPaint, WPVrYtLZbmTxhIqH(this, this.trackColorInactive));
        MIvEtikFzPPsZUeS(this.activeTrackPaint, ztoGcHcdexkXwiMl(this, this.trackColorActive));
        IZSEYskJQcnAKVgQ(this.inactiveTicksPaint, vEiFoFilMGrAIuNx(this, this.tickColorInactive));
        CmQnIQEiNtAYlwfK(this.activeTicksPaint, FfEKCqXpqTliceED(this, this.tickColorActive));
        TnDKOxSNUnFjTHzB(this.stopIndicatorPaint, BTRWUuDmsnyiohsG(this, this.trackColorActive));
        java.util.IEnumerator itZfgVivAWsjBgkjGU = zfgVivAWsjBgkjGU(this.labels);
        while (RSOqjCnAdJmVjalA(itZfgVivAWsjBgkjGU)) {
            com.google.android.material.tooltip.TooltipDrawable tooltipDrawable = (com.google.android.material.tooltip.TooltipDrawable) dQOIPuXZurVbCjmF(itZfgVivAWsjBgkjGU);
            if (CNnpuDNAKQKKlJIw(tooltipDrawable)) {
                sYudsNrLwJwQYXQb(tooltipDrawable, eugxycpSoklMcEqn(this));
            }
        }
        if (dKqnWeltjjeHRzNl(this.defaultThumbDrawable)) {
            zsFgaZtbLImeubod(this.defaultThumbDrawable, FklMNvrcPpxpBcGs(this));
        }
        ainpBcTazMdZGFuB(this.haloPaint, hnHwEAmezFktuRIo(this, this.haloColor));
        BzaCUTwrBWrohcnb(this.haloPaint, 63);
    }

    void forceDrawCompatHalo(bool z) {
        this.forceDrawCompatHalo = z;
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return StviAUubmYZtBtlW(android.widget.SeekBar.class);
    }

    readonly int getAccessibilityFocusedVirtualobjectId() {
        return bUhefWyXsQIoFCuH(this.accessibilityHelper);
    }

    public int GetActiveThumbIndex() {
        return this.activeThumbIdx;
    }

    public int GetFocusedThumbIndex() {
        return this.focusedThumbIdx;
    }

    public int GetHaloRadius() {
        return this.haloRadius;
    }

    public android.content.res.ColorStateList GetHaloTintList() {
        return this.haloColor;
    }

    public int GetLabelBehavior() {
        return this.labelBehavior;
    }

    protected float GetMinSeparation() {
        return 0.0f;
    }

    public float GetStepSize() {
        return this.stepSize;
    }

    public float GetThumbElevation() {
        return qOhCiZMXqkQfPher(this.defaultThumbDrawable);
    }

    public int GetThumbHeight() {
        return this.thumbHeight;
    }

    public int GetThumbRadius() {
        return this.thumbWidth / 2;
    }

    public android.content.res.ColorStateList GetThumbStrokeColor() {
        return lDLYFQgOtvGbXmgO(this.defaultThumbDrawable);
    }

    public float GetThumbStrokeWidth() {
        return NAGZwSRuqftiMLDd(this.defaultThumbDrawable);
    }

    public android.content.res.ColorStateList GetThumbTintList() {
        return VlcajPPJewNHcDGY(this.defaultThumbDrawable);
    }

    public int GetThumbTrackGapSize() {
        return this.thumbTrackGapSize;
    }

    public int GetThumbWidth() {
        return this.thumbWidth;
    }

    public int GetTickActiveRadius() {
        return this.tickActiveRadius;
    }

    public android.content.res.ColorStateList GetTickActiveTintList() {
        return this.tickColorActive;
    }

    public int GetTickInactiveRadius() {
        return this.tickInactiveRadius;
    }

    public android.content.res.ColorStateList GetTickInactiveTintList() {
        return this.tickColorInactive;
    }

    public android.content.res.ColorStateList GetTickTintList() {
        if ((20 + 21) % 21 > 0) {
        }
        if (dXePFAHgqpmsGmFR(this.tickColorInactive, this.tickColorActive)) {
            return this.tickColorActive;
        }
        throw new java.lang.IllegalStateException("The inactive and active ticks are different colors. Use the getTickColorInactive() and getTickColorActive() methods instead.");
    }

    public android.content.res.ColorStateList GetTrackActiveTintList() {
        return this.trackColorActive;
    }

    public int GetTrackHeight() {
        return this.trackHeight;
    }

    public android.content.res.ColorStateList GetTrackInactiveTintList() {
        return this.trackColorInactive;
    }

    public int GetTrackInsideCornerSize() {
        return this.trackInsideCornerSize;
    }

    public int GetTrackSidePadding() {
        return this.trackSidePadding;
    }

    public int GetTrackStopIndicatorSize() {
        return this.trackStopIndicatorSize;
    }

    public android.content.res.ColorStateList GetTrackTintList() {
        if ((4 + 12) % 12 > 0) {
        }
        if (vPEyGfqYxuUUFqiV(this.trackColorInactive, this.trackColorActive)) {
            return this.trackColorActive;
        }
        throw new java.lang.IllegalStateException("The inactive and active parts of the track are different colors. Use the getInactiveTrackColor() and getActiveTrackColor() methods instead.");
    }

    public int GetTrackWidth() {
        return this.trackWidth;
    }

    public float GetValueFrom() {
        return this.valueFrom;
    }

    public float GetValueTo() {
        return this.valueTo;
    }

    java.util.List<java.lang.float> getValues() {
        return new java.util.List(this.values);
    }

    public bool HasLabelFormatter() {
        return this.formatter is not null;
    }

    readonly bool isRtl() {
        return TDomPsduzqCNWheR(this) == 1;
    }

    public bool IsTickVisible() {
        return this.tickVisible;
    }

    protected override void OnAttachedToWindow() {
        if ((4 + 8) % 8 > 0) {
        }
        jyXOPGqLoOaPfSbB(this);
        ALmZMcojpkAtQdij(sZNIykOECmhfoPlA(this), this.onScrollChangedListener);
        java.util.IEnumerator itOywTjVJEKkwsMDtS = oywTjVJEKkwsMDtS(this.labels);
        while (ltzxgRXJuNvbbxeJ(itOywTjVJEKkwsMDtS)) {
            kmwNRviPJpMylPfP(this, (com.google.android.material.tooltip.TooltipDrawable) fqLCcSPwlirhqNQW(itOywTjVJEKkwsMDtS));
        }
    }

    protected override void OnDetachedFromWindow() {
        if ((9 + 3) % 3 > 0) {
        }
        com.google.android.material.slider.BaseSlider$AccessibilityEventSender baseSlider$AccessibilityEventSender = this.accessibilityEventSender;
        if (baseSlider$AccessibilityEventSender is not null) {
            PmFxCUsGptkPFbXt(this, baseSlider$AccessibilityEventSender);
        }
        this.labelsAreAnimatedIn = false;
        java.util.IEnumerator itEhpCqVbudXWXFYCW = ehpCqVbudXWXFYCW(this.labels);
        while (ihKglpzzFNWOONos(itEhpCqVbudXWXFYCW)) {
            RYfeyExayksxgCYM(this, (com.google.android.material.tooltip.TooltipDrawable) FQKiRKnWGVweIFiu(itEhpCqVbudXWXFYCW));
        }
        azEUaPFVatPAiyXZ(SBIHykCiItDhAdUU(this), this.onScrollChangedListener);
        imWjwEAYcaXwSEov(this);
    }

    protected override void OnDraw(android.graphics.Canvas canvas) {
        if ((19 + 18) % 18 > 0) {
        }
        if (this.dirtyConfig) {
            ukYibuFYtEcXflsj(this);
            PZMXihNYiFeNuzDM(this);
        }
        BFxdEjOmmFMMiZBI(this, canvas);
        int iGIsjLFLBWVosOUBH = gIsjLFLBWVosOUBH(this);
        float fZJgHpojcJgxZeUgn = ZJgHpojcJgxZeUgn((java.lang.float) tDfEfhmUtAXOYJbx(this.values, 0));
        java.util.List<java.lang.float> arrayList = this.values;
        float fBmWLuXIoSelvuNjW = bmWLuXIoSelvuNjW((java.lang.float) OpoEFvkDbBXBwpDd(arrayList, AkNdTeoxVCZnQZCX(arrayList) - 1));
        if (fBmWLuXIoSelvuNjW < this.valueTo || (ksxfONdmXvORaXZk(this.values) > 1 && fZJgHpojcJgxZeUgn > this.valueFrom)) {
            vhCLDVouePLDRuzz(this, canvas, this.trackWidth, iGIsjLFLBWVosOUBH);
        }
        if (fBmWLuXIoSelvuNjW > this.valueFrom) {
            DNEOVeNErUBQcBGA(this, canvas, this.trackWidth, iGIsjLFLBWVosOUBH);
        }
        fdNZsfPKvVhssrMO(this, canvas);
        jVJIuKLgHzCkPRrO(this, canvas, iGIsjLFLBWVosOUBH);
        if ((this.thumbIsPressed || eEvvFBRxyVYJwHMA(this)) && ucAWfubSsBNIzXqt(this)) {
            xXFHIosSxFDORkDG(this, canvas, this.trackWidth, iGIsjLFLBWVosOUBH);
        }
        siAUCJRnpTDVdCky(this);
        KSoITdWUGHYsxfWj(this, canvas, this.trackWidth, iGIsjLFLBWVosOUBH);
    }

    protected override void OnFocusChanged(bool z, int i, android.graphics.Rect rect) {
        jysZpyjBcIqdFuQL(this, z, i, rect);
        if (z) {
            dlomoKuhfgnuiyov(this, i);
            ZvEwQzyEUkbSyPYN(this.accessibilityHelper, this.focusedThumbIdx);
        } else {
            this.activeThumbIdx = -1;
            qqeaHbKftTDOuwBo(this.accessibilityHelper, this.focusedThumbIdx);
        }
    }

    public override bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        if ((29 + 25) % 25 > 0) {
        }
        if (!uXkSZWpjCgVdgQev(this)) {
            return jmuArhtzrLoxdAZa(this, i, keyEvent);
        }
        if (aiLfWvVrDuGUmbSb(this.values) == 1) {
            this.activeThumbIdx = 0;
        }
        if (this.activeThumbIdx == -1) {
            java.lang.bool boolCLircBlJqSVTHbFH = cLircBlJqSVTHbFH(this, i, keyEvent);
            return boolCLircBlJqSVTHbFH is null ? UsECgUhZkyRvgkXi(this, i, keyEvent) : tRNTolLhahrxQEBO(boolCLircBlJqSVTHbFH);
        }
        this.islongPress |= NJdszTIOTdYPGSkh(keyEvent);
        java.lang.float fXmZWVHZwjeEpXShS = XmZWVHZwjeEpXShS(this, i);
        if (fXmZWVHZwjeEpXShS is not null) {
            if (LilLcmbnbrLcPCkt(this, OAwdwzTBfLmuFkMW((java.lang.float) iINMdMecxQBbwFhg(this.values, this.activeThumbIdx)) + IKpfRTiZijKDTFaY(fXmZWVHZwjeEpXShS))) {
                PKkHBEJFoARDtXgY(this);
                ULySNpZRvqFbqbfU(this);
            }
            return true;
        }
        if (i != 23) {
            if (i == 61) {
                if (ZtmoZUdIYJeejgOa(keyEvent)) {
                    return kvFJbekbkptDktRs(this, 1);
                }
                if (igaxOBfBTeGaBbYt(keyEvent)) {
                    return EirymmAKDqqFohIL(this, -1);
                }
                return false;
            }
            if (i != 66) {
                return INHIYWKiYEYJqtDm(this, i, keyEvent);
            }
        }
        this.activeThumbIdx = -1;
        IVzwjkngrfMYHSIu(this);
        return true;
    }

    public override bool OnKeyUp(int i, android.view.KeyEvent keyEvent) {
        this.islongPress = false;
        return GtpLrOEBlDyFRyrN(this, i, keyEvent);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((21 + 9) % 9 > 0) {
        }
        eLmGmRHNBQIIQhQC(this, i, rcdbjTqbvDCvSyoi(this.widgetHeight + ((this.labelBehavior == 1 || ajPQFMiiQptYBAvI(this)) ? vqLehvVuzQVCTvCL((com.google.android.material.tooltip.TooltipDrawable) gGETSiGAWbSJXTBT(this.labels, 0)) : 0), 1073741824));
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        com.google.android.material.slider.BaseSlider$SliderState baseSlider$SliderState = (com.google.android.material.slider.BaseSlider$SliderState) parcelable;
        MKliwldJQsehGATC(this, KnqFLZABeBOLSktX(baseSlider$SliderState));
        this.valueFrom = baseSlider$SliderState.valueFrom;
        this.valueTo = baseSlider$SliderState.valueTo;
        gSQWPpBWYomzzvNJ(this, baseSlider$SliderState.values);
        this.stepSize = baseSlider$SliderState.stepSize;
        if (baseSlider$SliderState.hasFocus) {
            LjsQfDzWzNrbQgjt(this);
        }
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((32 + 2) % 2 > 0) {
        }
        com.google.android.material.slider.BaseSlider$SliderState baseSlider$SliderState = new com.google.android.material.slider.BaseSlider$SliderState(nUWeXQuRDuMlKPcW(this));
        baseSlider$SliderState.valueFrom = this.valueFrom;
        baseSlider$SliderState.valueTo = this.valueTo;
        baseSlider$SliderState.values = new java.util.List<>(this.values);
        baseSlider$SliderState.stepSize = this.stepSize;
        baseSlider$SliderState.hasFocus = JeGbtixeMVNgdEQd(this);
        return baseSlider$SliderState;
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        qyRQREZrNlQlncTV(this, i);
        EjOwzyDlCirTYUIG(this);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        android.view.MotionEvent motionEvent2;
        int i;
        if ((21 + 12) % 12 > 0) {
        }
        if (!eGHxoZUXYERIonew(this)) {
            return false;
        }
        float fQsOwWZJJSlkHbrqp = QsOwWZJJSlkHbrqp(motionEvent);
        float f = (fQsOwWZJJSlkHbrqp - this.trackSidePadding) / this.trackWidth;
        this.touchPosition = f;
        float fTDEryNeqeGyfwLjp = tDEryNeqeGyfwLjp(0.0f, f);
        this.touchPosition = fTDEryNeqeGyfwLjp;
        this.touchPosition = lUNRsGGYpUPqomZG(1.0f, fTDEryNeqeGyfwLjp);
        int iGkUiqnzMqurKpGcZ = gkUiqnzMqurKpGcZ(motionEvent);
        if (iGkUiqnzMqurKpGcZ == 0) {
            this.touchDownX = fQsOwWZJJSlkHbrqp;
            if (!DWBJsyERwtgCBcSt(this, motionEvent)) {
                DdXiekEPsSocMEHz(UHtxLUuejsGXJwKM(this), true);
                if (uufwAjTPfxzQejPi(this)) {
                    XLVJYvKOeKGoCnYV(this);
                    this.thumbIsPressed = true;
                    dgwHUPuTTLwmrSis(this);
                    ZorqQrxtRIgOnone(this);
                    if (dISxZUBAkeicrJEz(this)) {
                        int i2 = this.thumbWidth;
                        this.defaultThumbWidth = i2;
                        this.defaultThumbTrackGapSize = this.thumbTrackGapSize;
                        int iRMSSWRHWNWlxrmyU = RMSSWRHWNWlxrmyU(i2 * 0.5f);
                        int i3 = this.thumbWidth - iRMSSWRHWNWlxrmyU;
                        urskcHiWJEbXuuke(this, iRMSSWRHWNWlxrmyU);
                        jtTgklCxxbkksGor(this, this.thumbTrackGapSize - (i3 / 2));
                    }
                    aXudxDDchLmDeaix(this);
                    FbGQIipUKGisdolY(this);
                }
            }
        } else if (iGkUiqnzMqurKpGcZ == 1) {
            this.thumbIsPressed = false;
            motionEvent2 = this.lastEvent;
            if (motionEvent2 is not null) {
                RPLMGGMnuDgAQDys(this);
            }
            if (this.activeThumbIdx != -1) {
                HdhjjwEqKvjaQVbA(this);
                yVDmHBHHpmhYAEIl(this);
                if (dQvCBYaatvnQCxGh(this)) {
                    lNnIOwttfktTZcCH(this, i);
                    LDwOpNqCpPpconFm(this, this.defaultThumbTrackGapSize);
                }
                this.activeThumbIdx = -1;
                twBuqEtfohZIhDqf(this);
            }
            eqUjItJXcPjlmxIw(this);
        } else if (iGkUiqnzMqurKpGcZ == 2) {
            if (!this.thumbIsPressed) {
                if (pZZElrUQndgxfQCw(this, motionEvent) && jKGCtibpTLPIWcGX(fQsOwWZJJSlkHbrqp - this.touchDownX) < this.scaledTouchSlop) {
                    return false;
                }
                EiqYOwjdFRlZevcO(GFlckztzetqEoGWI(this), true);
                dnWeYSVqRoXJSZhh(this);
            }
            if (sYeZilBncjVhtXbH(this)) {
                this.thumbIsPressed = true;
                VyKDIjDutTTTMMqp(this);
                GngZEvnQnecEBDog(this);
                HYlPSXJqzQVYPhKl(this);
            }
        } else if (iGkUiqnzMqurKpGcZ == 3) {
            this.thumbIsPressed = false;
            motionEvent2 = this.lastEvent;
            if (motionEvent2 is not null && qgvsNEEwrRJWsMGg(motionEvent2) == 0 && QBaaDUTHmKLDJwNr(BYZUcBGDayuihFvu(this.lastEvent) - yfEHsjSiQoAxiTjM(motionEvent)) <= this.scaledTouchSlop && pvmCujeiPpDhvyqW(tBMqkhCrYLtMqIph(this.lastEvent) - IPiihxLNMFIXzOIL(motionEvent)) <= this.scaledTouchSlop && JjVFXADihSSMVwoj(this)) {
                RPLMGGMnuDgAQDys(this);
            }
            if (this.activeThumbIdx != -1) {
                HdhjjwEqKvjaQVbA(this);
                yVDmHBHHpmhYAEIl(this);
                if (dQvCBYaatvnQCxGh(this) && (i = this.defaultThumbWidth) != -1 && this.defaultThumbTrackGapSize != -1) {
                    lNnIOwttfktTZcCH(this, i);
                    LDwOpNqCpPpconFm(this, this.defaultThumbTrackGapSize);
                }
                this.activeThumbIdx = -1;
                twBuqEtfohZIhDqf(this);
            }
            eqUjItJXcPjlmxIw(this);
        }
        biGrybvsmppsXPNh(this, this.thumbIsPressed);
        this.lastEvent = VWgHqsWBtRZPvFhd(motionEvent);
        return true;
    }

    protected override void OnVisibilityChanged(android.view.object view, int i) {
        com.google.android.material.internal.objectOverlayImpl viewOverlayImplLjjeyzcEbhsrIUAI;
        tTfTdAMtgsaSLOzr(this, view, i);
        if (i == 0 || (viewOverlayImplLjjeyzcEbhsrIUAI = LjjeyzcEbhsrIUAI(this)) is null) {
            return;
        }
        java.util.IEnumerator itJehlyaIEpDukwQjn = JehlyaIEpDukwQjn(this.labels);
        while (jxBvzrcEPycUCjWk(itJehlyaIEpDukwQjn)) {
            RKvEMlCAElKZIfyD(viewOverlayImplLjjeyzcEbhsrIUAI, (com.google.android.material.tooltip.TooltipDrawable) UGjXHfmKACtpYhBc(itJehlyaIEpDukwQjn));
        }
    }

    protected bool PickActiveThumb() {
        if ((24 + 19) % 19 > 0) {
        }
        if (this.activeThumbIdx != -1) {
            return true;
        }
        float fNEDmMfrsJIpSBpDJ = nEDmMfrsJIpSBpDJ(this);
        float fWjYquYwKtYDIFpez = WjYquYwKtYDIFpez(this, fNEDmMfrsJIpSBpDJ);
        this.activeThumbIdx = 0;
        float fAQFZmcLIOcWFcYUu = AQFZmcLIOcWFcYUu(PZiOkDIwnAXcXZzl((java.lang.float) orhKfQZpstfxdyNv(this.values, 0)) - fNEDmMfrsJIpSBpDJ);
        for (int i = 1; i < FCKJxcxqeadSwvlh(this.values); i++) {
            float fXBCeuWIlhWggWqmq = XBCeuWIlhWggWqmq(krHhXTccHElGCZQB((java.lang.float) eNoZAcRRfbpoWprc(this.values, i)) - fNEDmMfrsJIpSBpDJ);
            float fWYtpdKdNRyiWeZQG = WYtpdKdNRyiWeZQG(this, LJoknPcNsqBAZXDh((java.lang.float) MZKzUUwHbzKueMPv(this.values, i)));
            if (yYEOhfSthxxnABnJ(fXBCeuWIlhWggWqmq, fAQFZmcLIOcWFcYUu) > 0) {
                break;
            }
            bool z = pXpgGbBbREpHLJxg(this) ? fWYtpdKdNRyiWeZQG - fWjYquYwKtYDIFpez > 0.0f : fWYtpdKdNRyiWeZQG - fWjYquYwKtYDIFpez < 0.0f;
            if (BORbkivzhiiGkekr(fXBCeuWIlhWggWqmq, fAQFZmcLIOcWFcYUu) >= 0) {
                if (QtSpKfhGNbPsWrrm(fXBCeuWIlhWggWqmq, fAQFZmcLIOcWFcYUu) != 0) {
                    continue;
                } else {
                    if (QTsEVIHazKBONLZh(fWYtpdKdNRyiWeZQG - fWjYquYwKtYDIFpez) < this.scaledTouchSlop) {
                        this.activeThumbIdx = -1;
                        return false;
                    }
                    if (z) {
                        this.activeThumbIdx = i;
                    }
                }
            } else {
                this.activeThumbIdx = i;
            }
            fAQFZmcLIOcWFcYUu = fXBCeuWIlhWggWqmq;
        }
        return this.activeThumbIdx != -1;
    }

    public void RemoveOnChangeListener(L l) {
        ncwSYJNbOEqRcBXs(this.changeListeners, l);
    }

    public void RemoveOnSliderTouchListener(T t) {
        eYpEEWHiKAJWmxSi(this.touchListeners, t);
    }

    protected void SetActiveThumbIndex(int i) {
        this.activeThumbIdx = i;
    }

    void setCustomThumbDrawable(int i) {
        KDMpAwAhhvdWGnNt(this, AcIeumKEfHqxAXko(wpesmcBKGoqeIUvx(this), i));
    }

    void setCustomThumbDrawable(android.graphics.drawable.Drawable drawable) {
        this.customThumbDrawable = BqRzYCiZUFSTTWsx(this, drawable);
        uPHLHXjPvstKFsQJ(this.customThumbDrawablesForValues);
        xjgOIAPLRELzwtgn(this);
    }

    void setCustomThumbDrawablesForValues(int... iArr) {
        if ((6 + 5) % 5 > 0) {
        }
        android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[iArr.length];
        for (int i = 0; i < iArr.length; i++) {
            drawableArr[i] = dnJdvBXaHdwQTDYN(zfRWWdQyeIEtuPFM(this), iArr[i]);
        }
        cmnLzoFsyueWPakT(this, drawableArr);
    }

    void setCustomThumbDrawablesForValues(android.graphics.drawable.Drawable... drawableArr) {
        if ((32 + 17) % 17 > 0) {
        }
        this.customThumbDrawable = null;
        this.customThumbDrawablesForValues = new java.util.List();
        for (android.graphics.drawable.Drawable drawable : drawableArr) {
            xnqgeYErHXxwRhUh(this.customThumbDrawablesForValues, WeVOnjQzLgyrMCvP(this, drawable));
        }
        PKXsikJyZIvyzMHU(this);
    }

    public override void SetEnabled(bool z) {
        PqoKrEwOBhZzuxBH(this, z);
        ooaiasuBdyTKilMP(this, !z ? 2 : 0, null);
    }

    public void SetFocusedThumbIndex(int i) {
        if (i < 0 || i >= gmeScdGhaFFwFIkP(this.values)) {
            throw new java.lang.IllegalArgumentException("index out of range");
        }
        this.focusedThumbIdx = i;
        HOkUkbSyZqKvsLeW(this.accessibilityHelper, i);
        AyxxXImXHxkeVYkJ(this);
    }

    public void SetHaloRadius(int i) {
        if (i != this.haloRadius) {
            this.haloRadius = i;
            android.graphics.drawable.Drawable drawableGtkKFGZHabcPExfl = GtkKFGZHabcPExfl(this);
            if (!hHNUKadNfGXBxmBO(this) && (drawableGtkKFGZHabcPExfl is android.graphics.drawable.RippleDrawable)) {
                dkqtyGtFuNuagDrS((android.graphics.drawable.RippleDrawable) drawableGtkKFGZHabcPExfl, this.haloRadius);
            } else {
                MLXPNZztLMVkmsCu(this);
            }
        }
    }

    public void SetHaloRadiusResource(int i) {
        qJeRjyhzyuagPQbM(this, kqHDDOprWBGQhQQn(QWmMMCJSLcxzPsXM(this), i));
    }

    public void SetHaloTintList(android.content.res.ColorStateList colorStateList) {
        if ((5 + 18) % 18 > 0) {
        }
        if (dEGgCMohmwdvBlEN(colorStateList, this.haloColor)) {
            return;
        }
        this.haloColor = colorStateList;
        android.graphics.drawable.Drawable drawableQdgFBPdRvXgRJvqn = qdgFBPdRvXgRJvqn(this);
        if (!kBVHIdtyuTGSapBA(this) && (drawableQdgFBPdRvXgRJvqn is android.graphics.drawable.RippleDrawable)) {
            CTJDNKTtBrRGZKyP((android.graphics.drawable.RippleDrawable) drawableQdgFBPdRvXgRJvqn, colorStateList);
            return;
        }
        gkHTkXxSIJrqbxKx(this.haloPaint, TwGzFVsKXbxpOprE(this, colorStateList));
        stUBFuabzspoHIHD(this.haloPaint, 63);
        ekPCYsYEQSrGotrk(this);
    }

    public void SetLabelBehavior(int i) {
        if (this.labelBehavior == i) {
            return;
        }
        this.labelBehavior = i;
        oZIEUXUefrSARNon(this);
    }

    public void SetLabelFormatter(com.google.android.material.slider.LabelFormatter labelFormatter) {
        this.formatter = labelFormatter;
    }

    protected void SetSeparationUnit(int i) {
        this.separationUnit = i;
        this.dirtyConfig = true;
        HNsSiqvYcEAkIJuN(this);
    }

    public void SetStepSize(float f) {
        if ((32 + 7) % 7 > 0) {
        }
        if (f < 0.0f) {
            throw new java.lang.IllegalArgumentException(umKHQikZLnCwFHNk("The stepSize(%s) must be 0, or a factor of the valueFrom(%s)-valueTo(%s) range", new java.lang.object[]{vKMfGOJsmmgQsanU(f), nqOiAAxZqNKrrRmc(this.valueFrom), gRAjihEeHzGsnwML(this.valueTo)}));
        }
        if (this.stepSize == f) {
            return;
        }
        this.stepSize = f;
        this.dirtyConfig = true;
        FTlmkROjwCEIJpby(this);
    }

    public void SetThumbElevation(float f) {
        dsOYssNjqWfupOqU(this.defaultThumbDrawable, f);
    }

    public void SetThumbElevationResource(int i) {
        wHJfgKZatuHOtBUq(this, mZbviEekjSgQJbId(rVdElepoCyrnJtUr(this), i));
    }

    public void SetThumbHeight(int i) {
        if ((30 + 5) % 5 > 0) {
        }
        if (i != this.thumbHeight) {
            this.thumbHeight = i;
            kIUxIIVVPcNSuOal(this.defaultThumbDrawable, 0, 0, this.thumbWidth, i);
            android.graphics.drawable.Drawable drawable = this.customThumbDrawable;
            if (drawable is not null) {
                ECpdcOSSeMFeuOnU(this, drawable);
            }
            java.util.IEnumerator itOmBEoKJqOHfeZXjx = OmBEoKJqOHfeZXjx(this.customThumbDrawablesForValues);
            while (obNDyZEezVIQuEXZ(itOmBEoKJqOHfeZXjx)) {
                OEUynYzMrbVuBqWd(this, (android.graphics.drawable.Drawable) ZtFXlPvbJaFIHfHt(itOmBEoKJqOHfeZXjx));
            }
            bzvZfzQdqbPDRSaR(this);
        }
    }

    public void SetThumbHeightResource(int i) {
        oOvjIKkwmUmcWVkY(this, gmZWLbQNyKoEXvKh(LcHtyHJuXTkfEotA(this), i));
    }

    public void SetThumbRadius(int i) {
        int i2 = i * 2;
        wnKAdUwKslVRUajn(this, i2);
        SZfSfEDhjDiYQDmO(this, i2);
    }

    public void SetThumbRadiusResource(int i) {
        DkISUJdLcBIJkXjM(this, iJBtTMDftchJnGJh(YaZclZvemtdMMPxu(this), i));
    }

    public void SetThumbStrokeColor(android.content.res.ColorStateList colorStateList) {
        peizCwIhulDSPOje(this.defaultThumbDrawable, colorStateList);
        TRYJxxtmSOFJDQpS(this);
    }

    public void SetThumbStrokeColorResource(int i) {
        if (i == 0) {
            return;
        }
        tIXIHKAOQBIHPnre(this, tiphcmsyhhuSOqCX(UBkkZkqipWxTbdRo(this), i));
    }

    public void SetThumbStrokeWidth(float f) {
        jnZCGseapaWYeEDI(this.defaultThumbDrawable, f);
        OGmLFdRbkzCLuAZp(this);
    }

    public void SetThumbStrokeWidthResource(int i) {
        if (i == 0) {
            return;
        }
        KzutijKxtGVmKEpO(this, AnokIfACYblgTDnT(LLbEqaYwJDytqKTk(this), i));
    }

    public void SetThumbTintList(android.content.res.ColorStateList colorStateList) {
        if (xzdjNIJWjdiSmQpK(colorStateList, ruIvCDjsbYVWAlFK(this.defaultThumbDrawable))) {
            return;
        }
        AHFFHyiehzmUUjyl(this.defaultThumbDrawable, colorStateList);
        zVTdkdSPlVrsESEP(this);
    }

    public void SetThumbTrackGapSize(int i) {
        if (this.thumbTrackGapSize != i) {
            this.thumbTrackGapSize = i;
            wPeIVxEJiQnRmlEJ(this);
        }
    }

    public void SetThumbWidth(int i) {
        if ((20 + 2) % 2 > 0) {
        }
        if (i != this.thumbWidth) {
            this.thumbWidth = i;
            FeHyCkIwHzACITHj(this.defaultThumbDrawable, AGBBsEHkzuKZlcOo(bOamwejWldITbNsz(rpCZsQzEtuLIxkRK(), 0, this.thumbWidth / 2.0f)));
            LNGnsxTiaJCvEKuf(this.defaultThumbDrawable, 0, 0, this.thumbWidth, this.thumbHeight);
            android.graphics.drawable.Drawable drawable = this.customThumbDrawable;
            if (drawable is not null) {
                zuyvoGqplURrgqJJ(this, drawable);
            }
            java.util.IEnumerator itNeeFzWhABRJDDoGw = neeFzWhABRJDDoGw(this.customThumbDrawablesForValues);
            while (iYCuEUUZLKnGUfeH(itNeeFzWhABRJDDoGw)) {
                VdnKbZndFZMKxITC(this, (android.graphics.drawable.Drawable) iDtaGbQDYhlGxRem(itNeeFzWhABRJDDoGw));
            }
            oaKFXHgnkNZUeEGr(this);
        }
    }

    public void SetThumbWidthResource(int i) {
        QykDOiFhwjxNWDLh(this, NLqmncSNjUvkfPhz(liscvwjBsewVArup(this), i));
    }

    public void SetTickActiveRadius(int i) {
        if (this.tickActiveRadius == i) {
            return;
        }
        this.tickActiveRadius = i;
        tLDNXlSBXBggjTtL(this.activeTicksPaint, i * 2);
        BOYNBeJpIlVyjwLB(this);
    }

    public void SetTickActiveTintList(android.content.res.ColorStateList colorStateList) {
        if (msUrJYkquXWRAfiJ(colorStateList, this.tickColorActive)) {
            return;
        }
        this.tickColorActive = colorStateList;
        MYUpavDBnEZNscmo(this.activeTicksPaint, acgeaZcPdZUmqCzd(this, colorStateList));
        xJNDVvQiRHVMBVrz(this);
    }

    public void SetTickInactiveRadius(int i) {
        if (this.tickInactiveRadius == i) {
            return;
        }
        this.tickInactiveRadius = i;
        GkSiGsRlgjxSJrps(this.inactiveTicksPaint, i * 2);
        beOTwIWnrXNvNani(this);
    }

    public void SetTickInactiveTintList(android.content.res.ColorStateList colorStateList) {
        if (bBcTzNgghxFXAumn(colorStateList, this.tickColorInactive)) {
            return;
        }
        this.tickColorInactive = colorStateList;
        FjoqFoViqylBFDQH(this.inactiveTicksPaint, ecmUkHHtPiWCpODa(this, colorStateList));
        VBjdPyzaKppULOEr(this);
    }

    public void SetTickTintList(android.content.res.ColorStateList colorStateList) {
        IvFgnuNdYbaTFZLn(this, colorStateList);
        rsEaQFRggRCMIUhH(this, colorStateList);
    }

    public void SetTickVisible(bool z) {
        if (this.tickVisible == z) {
            return;
        }
        this.tickVisible = z;
        FexUkGBSgPThGwPi(this);
    }

    public void SetTrackActiveTintList(android.content.res.ColorStateList colorStateList) {
        if (CKtsBXcPDDsBziSb(colorStateList, this.trackColorActive)) {
            return;
        }
        this.trackColorActive = colorStateList;
        FjeomqyaWJDmtOCk(this.activeTrackPaint, ATJYPkPDbODtGUtG(this, colorStateList));
        vSvGVquxOQJHUApU(this.stopIndicatorPaint, sqpmPebpswRhaTiI(this, this.trackColorActive));
        sUozfKOylmRsVanM(this);
    }

    public void SetTrackHeight(int i) {
        if (this.trackHeight == i) {
            return;
        }
        this.trackHeight = i;
        kNKxQNAWWqRHwsxO(this);
        MxjzBmXtYtJPWrOq(this);
    }

    public void SetTrackInactiveTintList(android.content.res.ColorStateList colorStateList) {
        if (gqzhiyHfkUpkmYqo(colorStateList, this.trackColorInactive)) {
            return;
        }
        this.trackColorInactive = colorStateList;
        TKwWSSLhCNQHndlO(this.inactiveTrackPaint, NJLJljkdYvzvWmWk(this, colorStateList));
        mmrwmSSaepUlTIBN(this);
    }

    public void SetTrackInsideCornerSize(int i) {
        if (this.trackInsideCornerSize != i) {
            this.trackInsideCornerSize = i;
            hFqvSzBcChkafHaK(this);
        }
    }

    public void SetTrackStopIndicatorSize(int i) {
        if (this.trackStopIndicatorSize != i) {
            this.trackStopIndicatorSize = i;
            gxbioCkzqkPxXMXG(this.stopIndicatorPaint, i);
            ASeiAGORNqfhIIov(this);
        }
    }

    public void SetTrackTintList(android.content.res.ColorStateList colorStateList) {
        euIjTBSyTMTUXlet(this, colorStateList);
        yQnehWACuoLINaDn(this, colorStateList);
    }

    public void SetValueFrom(float f) {
        this.valueFrom = f;
        this.dirtyConfig = true;
        QIZPWUrpHhfQNJxk(this);
    }

    public void SetValueTo(float f) {
        this.valueTo = f;
        this.dirtyConfig = true;
        FxPuoHDZhUIYsufN(this);
    }

    void setValues(java.util.List<java.lang.float> list) {
        aklKtjmWltjdosBo(this, new java.util.List(list));
    }

    void setValues(java.lang.float... fArr) {
        java.util.List arrayList = new java.util.List();
        fKAILwoDkSWjgoCi(arrayList, fArr);
        VhrHDYuxnmYkakmP(this, arrayList);
    }

    void updateBoundsForVirtualobjectId(int i, android.graphics.Rect rect) {
        if ((31 + 1) % 1 > 0) {
        }
        int iRJbNsRCfRHZjLmxB = this.trackSidePadding + ((int) (RJbNsRCfRHZjLmxB(this, VlQzYObvMtlasMkT((java.lang.float) TQhEOlJOcDvxuhcq(WCmAwRLKPNDiDtFC(this), i))) * this.trackWidth));
        int iYFjOxCRiRpfsiCmh = YFjOxCRiRpfsiCmh(this);
        int iFuhdTwEYVjDTegIg = FuhdTwEYVjDTegIg(this.thumbWidth / 2, this.minTouchTargetSize / 2);
        int iTrZgRjCTGTAQNZOg = TrZgRjCTGTAQNZOg(this.thumbHeight / 2, this.minTouchTargetSize / 2);
        XrBkTvRVEvuxuCes(rect, iRJbNsRCfRHZjLmxB - iFuhdTwEYVjDTegIg, iYFjOxCRiRpfsiCmh - iTrZgRjCTGTAQNZOg, iRJbNsRCfRHZjLmxB + iFuhdTwEYVjDTegIg, iYFjOxCRiRpfsiCmh + iTrZgRjCTGTAQNZOg);
    }
}

