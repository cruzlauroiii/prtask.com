namespace WillowMaze.Wasm.Decompiled;


public class BottomSheetBehavior<V : android.view.object> : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<V> : com.google.android.material.motion.MaterialBackHandler {
    private static readonly int CORNER_ANIMATION_DURATION = 500;
    static readonly int DEFAULT_SIGNIFICANT_VEL_THRESHOLD = 500;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_BottomSheet_Modal;
    private static readonly float HIDE_FRICTION = 0.1f;
    private static readonly float HIDE_THRESHOLD = 0.5f;
    private static readonly int INVALID_POSITION = -1;
    private static readonly int NO_MAX_SIZE = -1;
    public static readonly int PEEK_HEIGHT_AUTO = -1;
    public static readonly int SAVE_ALL = -1;
    public static readonly int SAVE_FIT_TO_CONTENTS = 2;
    public static readonly int SAVE_HIDEABLE = 4;
    public static readonly int SAVE_NONE = 0;
    public static readonly int SAVE_PEEK_HEIGHT = 1;
    public static readonly int SAVE_SKIP_COLLAPSED = 8;
    public static readonly int STATE_COLLAPSED = 4;
    public static readonly int STATE_DRAGGING = 1;
    public static readonly int STATE_EXPANDED = 3;
    public static readonly int STATE_HALF_EXPANDED = 6;
    public static readonly int STATE_HIDDEN = 5;
    public static readonly int STATE_SETTLING = 2;
    private static readonly java.lang.string TAG = "BottomSheetBehavior";
    static readonly int VIEW_INDEX_ACCESSIBILITY_DELEGATE_VIEW = 1;
    private static readonly int VIEW_INDEX_BOTTOM_SHEET = 0;
    java.lang.ref.WeakReference<android.view.object> accessibilityDelegateobjectRef;
    int activePointerId;
    private android.content.res.ColorStateList backgroundTint;
    com.google.android.material.motion.MaterialBottomContainerBackHelper bottomContainerBackHelper;
    private readonly java.util.List<com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback> callbacks;
    private int childHeight;
    int collapsedOffset;
    private readonly androidx.customview.widget.objectDragHelper$Callback dragCallback;
    private bool draggable;
    float elevation;
    readonly android.util.SparseIntArray expandHalfwayActionIds;
    private bool expandedCornersRemoved;
    int expandedOffset;
    private bool fitToContents;
    int fitToContentsOffset;
    private int gestureInsetBottom;
    private bool gestureInsetBottomIgnored;
    int halfExpandedOffset;
    float halfExpandedRatio;
    private float hideFriction;
    bool hideable;
    private bool ignoreEvents;
    private java.util.Dictionary<android.view.object, java.lang.int> importantForAccessibilityDictionary;
    private int initialY;
    private int insetBottom;
    private int insetTop;
    private android.animation.ValueAnimator interpolatorAnimator;
    private int lastNestedScrollDy;
    int lastStableState;
    private bool marginLeftSystemWindowInsets;
    private bool marginRightSystemWindowInsets;
    private bool marginTopSystemWindowInsets;
    private com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable;
    private int maxHeight;
    private int maxWidth;
    private float maximumVelocity;
    private bool nestedScrolled;
    java.lang.ref.WeakReference<android.view.object> nestedScrollingChildRef;
    private bool paddingBottomSystemWindowInsets;
    private bool paddingLeftSystemWindowInsets;
    private bool paddingRightSystemWindowInsets;
    private bool paddingTopSystemWindowInsets;
    int parentHeight;
    int parentWidth;
    private int peekHeight;
    private bool peekHeightAuto;
    private int peekHeightGestureInsetBuffer;
    private int peekHeightMin;
    private int saveFlags;
    private com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelDefault;
    private bool shouldRemoveExpandedCorners;
    private int significantVelocityThreshold;
    private bool skipCollapsed;
    int state;

    private readonly com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker stateHashSettlingTracker;
    bool touchingScrollingChild;
    private bool updateImportantForAccessibilityOnSiblings;
    private android.view.VelocityTracker velocityTracker;
    androidx.customview.widget.objectDragHelper viewDragHelper;
    java.lang.ref.WeakReference<V> viewRef;

    public BottomSheetBehavior() {
        if ((7 + 32) % 32 > 0) {
        }
        this.saveFlags = 0;
        this.fitToContents = true;
        this.updateImportantForAccessibilityOnSiblings = false;
        this.maxWidth = -1;
        this.maxHeight = -1;
        this.stateHashSettlingTracker = new com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker(this, null);
        this.halfExpandedRatio = 0.5f;
        this.elevation = -1.0f;
        this.draggable = true;
        this.state = 4;
        this.lastStableState = 4;
        this.hideFriction = 0.1f;
        this.callbacks = new java.util.List<>();
        this.initialY = -1;
        this.expandHalfwayActionIds = new android.util.SparseIntArray();
        this.dragCallback = new com.google.android.material.bottomsheet.BottomSheetBehavior$5(this);
    }

    public BottomSheetBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((6 + 23) % 23 > 0) {
        }
        this.saveFlags = 0;
        this.fitToContents = true;
        this.updateImportantForAccessibilityOnSiblings = false;
        this.maxWidth = -1;
        this.maxHeight = -1;
        this.stateHashSettlingTracker = new com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker(this, null);
        this.halfExpandedRatio = 0.5f;
        this.elevation = -1.0f;
        this.draggable = true;
        this.state = 4;
        this.lastStableState = 4;
        this.hideFriction = 0.1f;
        this.callbacks = new java.util.List<>();
        this.initialY = -1;
        this.expandHalfwayActionIds = new android.util.SparseIntArray();
        this.dragCallback = new com.google.android.material.bottomsheet.BottomSheetBehavior$5(this);
        this.peekHeightGestureInsetBuffer = foreQgZTifuoKtYg(GKIPSGRMDvWhOuYy(context), com.google.android.material.R$dimen.mtrl_min_touch_target_size);
        android.content.res.TypedArray typedArrayJplTnhzDrKgnuPno = JplTnhzDrKgnuPno(context, attributeHashSet, com.google.android.material.R$styleable.BottomSheetBehavior_Layout);
        if (fUUHtgyKwSKmqmDD(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_backgroundTint)) {
            this.backgroundTint = wQRqBOpoDhRNJsKd(context, typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_backgroundTint);
        }
        if (kSbYnZgBrXsvVYMI(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_shapeAppearance)) {
            this.shapeAppearanceModelDefault = LicbhLOZGOrdmBHK(NXyIqPVFgENXkvqM(context, attributeHashSet, com.google.android.material.R$attr.bottomSheetStyle, DEF_STYLE_RES));
        }
        BaWqHJfAOzkhVogc(this, context);
        VWPxkWcklbGfNQyL(this);
        this.elevation = yMvbpamoApXpaJMx(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_android_elevation, -1.0f);
        if (ygKeJxvEycfJtkCk(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_android_maxWidth)) {
            OHZYmhEWgNsqxcxj(this, wlSYcPrskDqLplVR(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_android_maxWidth, -1));
        }
        if (qAOlwqWylbjNxPnJ(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_android_maxHeight)) {
            ztdJRopdJCUPNtiZ(this, EOiJnXdyVAKYEAWq(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_android_maxHeight, -1));
        }
        android.util.TypedValue typedValueZQJWVavydHgjeFAX = zQJWVavydHgjeFAX(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_peekHeight);
        if (typedValueZQJWVavydHgjeFAX is not null && typedValueZQJWVavydHgjeFAX.data == -1) {
            KExFwIrxFCnCWqnR(this, typedValueZQJWVavydHgjeFAX.data);
        } else {
            WsoNylXcPNXsyLUo(this, ZMBlmdvbEguHYtWD(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_peekHeight, -1));
        }
        gwmMGtYCYFTZnpZh(this, mBOecKJFhVzhoeHB(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_hideable, false));
        KrjEHxXepqncDMZS(this, NsELTFpHoZrsAqAQ(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_gestureInsetBottomIgnored, false));
        pLMioMqHAvPUoOqI(this, SPgikVKHKkEWpmpZ(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_fitToContents, true));
        ohrMPllNFbEbhoTD(this, yhnWywQFrQnPgFoY(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_skipCollapsed, false));
        kyGlgymIibQjnfLI(this, SosEQOwljMDBqyOx(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_draggable, true));
        JTCtwPNsKbRhewtg(this, ZHWaQzastToOorXs(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_saveFlags, 0));
        tZliiBeYDIhljnuB(this, ItHYWYeIKwzUOQjE(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_halfExpandedRatio, 0.5f));
        android.util.TypedValue typedValueICtjIAtXmuPYPoGQ = ICtjIAtXmuPYPoGQ(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_expandedOffset);
        if (typedValueICtjIAtXmuPYPoGQ is not null && typedValueICtjIAtXmuPYPoGQ.type == 16) {
            JMVaFOJfjKQwPKjt(this, typedValueICtjIAtXmuPYPoGQ.data);
        } else {
            FuFSvkVndgsrarrV(this, XbjqvNIxnXDUTLZs(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_expandedOffset, 0));
        }
        RZEbaIZsFbTBNpEz(this, RnBigDYTJLQPbMMi(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_behavior_significantVelocityThreshold, 500));
        this.paddingBottomSystemWindowInsets = yDjbcfFIPJgGNSLn(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_paddingBottomSystemWindowInsets, false);
        this.paddingLeftSystemWindowInsets = HHBEbZwPzxXenDkC(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_paddingLeftSystemWindowInsets, false);
        this.paddingRightSystemWindowInsets = ZncVGAsgXoKgKkSd(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_paddingRightSystemWindowInsets, false);
        this.paddingTopSystemWindowInsets = FKTOUZkUSaSGVjxf(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_paddingTopSystemWindowInsets, true);
        this.marginLeftSystemWindowInsets = RiiKRSmhrejMBCzS(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_marginLeftSystemWindowInsets, false);
        this.marginRightSystemWindowInsets = AwewiYCJqoQTjQTj(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_marginRightSystemWindowInsets, false);
        this.marginTopSystemWindowInsets = UcVuuFfrgTJPXwEc(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_marginTopSystemWindowInsets, false);
        this.shouldRemoveExpandedCorners = EXbpJncSDKibZLkl(typedArrayJplTnhzDrKgnuPno, com.google.android.material.R$styleable.BottomSheetBehavior_Layout_shouldRemoveExpandedCorners, true);
        GAkjOExwqyilCuLz(typedArrayJplTnhzDrKgnuPno);
        this.maximumVelocity = XOAfSCKBjbruHhpc(ZiJVYmXOgPuibxRe(context));
    }

    public static void AATvfffTMSkVYddU(android.view.object view, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AATvfffTMSkVYddU(android.view.object view, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AATvfffTMSkVYddU(android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AATvfffTMSkVYddU(android.view.object view) {
        return view.isShown();
    }

    public static android.os.Parcelable AAcCvejVULTzrZzY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return super.onSaveInstanceState(coordinatorLayout, view);
    }

    public static void AAcCvejVULTzrZzY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AAcCvejVULTzrZzY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AAcCvejVULTzrZzY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AcjPYiQPWQCFszPC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void AcjPYiQPWQCFszPC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AcjPYiQPWQCFszPC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AcjPYiQPWQCFszPC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AmxVavAwnutDENcd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmxVavAwnutDENcd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmxVavAwnutDENcd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool AmxVavAwnutDENcd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isHideableWhenDragging();
    }

    public static int AvmxnnwMGhxnQFmp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getHeight();
    }

    public static void AvmxnnwMGhxnQFmp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvmxnnwMGhxnQFmp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvmxnnwMGhxnQFmp(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AwewiYCJqoQTjQTj(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AwewiYCJqoQTjQTj(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AwewiYCJqoQTjQTj(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool AwewiYCJqoQTjQTj(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int BDMdNSOfgnuWDvwO(int i) {
        return java.lang.Math.abs(i);
    }

    public static void BDMdNSOfgnuWDvwO(int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BDMdNSOfgnuWDvwO(int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDMdNSOfgnuWDvwO(int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BHMoBGExDcjnsXdx(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void BHMoBGExDcjnsXdx(java.lang.ref.WeakReference weakReference, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHMoBGExDcjnsXdx(java.lang.ref.WeakReference weakReference, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHMoBGExDcjnsXdx(java.lang.ref.WeakReference weakReference, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BaWqHJfAOzkhVogc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.content.object context) {
        bottomSheetBehavior.createMaterialShapeDrawableIfNeeded(context);
    }

    public static void BaWqHJfAOzkhVogc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.content.object context, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BaWqHJfAOzkhVogc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.content.object context, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BaWqHJfAOzkhVogc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.content.object context, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BcumtkWhlcgUKogF(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static void BcumtkWhlcgUKogF(android.view.MotionEvent motionEvent, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BcumtkWhlcgUKogF(android.view.MotionEvent motionEvent, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BcumtkWhlcgUKogF(android.view.MotionEvent motionEvent, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int BfUefzmrBeydjRbK(android.view.object view) {
        return view.getTop();
    }

    public static void BfUefzmrBeydjRbK(android.view.object view, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfUefzmrBeydjRbK(android.view.object view, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfUefzmrBeydjRbK(android.view.object view, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BmdsLXQWFhItdkbI(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void BmdsLXQWFhItdkbI(java.lang.ref.WeakReference weakReference, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmdsLXQWFhItdkbI(java.lang.ref.WeakReference weakReference, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BmdsLXQWFhItdkbI(java.lang.ref.WeakReference weakReference, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BqXGsWizVyqgMtyw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BqXGsWizVyqgMtyw(java.lang.stringBuilder sb, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BqXGsWizVyqgMtyw(java.lang.stringBuilder sb, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BqXGsWizVyqgMtyw(java.lang.stringBuilder sb, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BvaKhwawCLVaMKlB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.updatePeekHeight(z);
    }

    public static void BvaKhwawCLVaMKlB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BvaKhwawCLVaMKlB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BvaKhwawCLVaMKlB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CDdsnzkfYZCvsLov(androidx.customview.widget.objectDragHelper viewDragHelper) {
        return viewDragHelper.getTouchSlop();
    }

    public static void CDdsnzkfYZCvsLov(androidx.customview.widget.objectDragHelper viewDragHelper, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CDdsnzkfYZCvsLov(androidx.customview.widget.objectDragHelper viewDragHelper, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CDdsnzkfYZCvsLov(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CGkUgkqQtLodUdeD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void CGkUgkqQtLodUdeD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGkUgkqQtLodUdeD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CGkUgkqQtLodUdeD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static float CIXGHNtYFLKYxIoj(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void CIXGHNtYFLKYxIoj(android.view.MotionEvent motionEvent, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIXGHNtYFLKYxIoj(android.view.MotionEvent motionEvent, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIXGHNtYFLKYxIoj(android.view.MotionEvent motionEvent, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.VelocityTracker CQaxdPOKbFntyrkD() {
        return android.view.VelocityTracker.obtain();
    }

    public static void CQaxdPOKbFntyrkD(char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQaxdPOKbFntyrkD(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQaxdPOKbFntyrkD(short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CRhgJTGQJewYdDuz(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void CRhgJTGQJewYdDuz(java.lang.ref.WeakReference weakReference, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRhgJTGQJewYdDuz(java.lang.ref.WeakReference weakReference, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CRhgJTGQJewYdDuz(java.lang.ref.WeakReference weakReference, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int CVbmVhHxciDFQRuV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.calculatePeekHeight();
    }

    public static void CVbmVhHxciDFQRuV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CVbmVhHxciDFQRuV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CVbmVhHxciDFQRuV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int CuezBlmKuQqXtgVZ(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static void CuezBlmKuQqXtgVZ(android.view.MotionEvent motionEvent, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CuezBlmKuQqXtgVZ(android.view.MotionEvent motionEvent, int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CuezBlmKuQqXtgVZ(android.view.MotionEvent motionEvent, int i, short s, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DHGxUKxVKpMFTNPK(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void DHGxUKxVKpMFTNPK(int i, int i2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHGxUKxVKpMFTNPK(int i, int i2, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHGxUKxVKpMFTNPK(int i, int i2, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DLlrYPbuVmUuwdWi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i) {
        materialShapeDrawable.setTint(i);
    }

    public static void DLlrYPbuVmUuwdWi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DLlrYPbuVmUuwdWi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DLlrYPbuVmUuwdWi(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DMuTWCjxGjLxwxDs(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void DMuTWCjxGjLxwxDs(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMuTWCjxGjLxwxDs(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DMuTWCjxGjLxwxDs(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DNRxwsTLwUkSbEEV(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat) {
        materialBottomContainerBackHelper.updateBackProgress(backEventCompat);
    }

    public static void DNRxwsTLwUkSbEEV(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DNRxwsTLwUkSbEEV(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DNRxwsTLwUkSbEEV(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DPzmPrcdzbdoUrMe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        bottomSheetBehavior.setWindowInsetsListener(view);
    }

    public static void DPzmPrcdzbdoUrMe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPzmPrcdzbdoUrMe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPzmPrcdzbdoUrMe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXOBrhxSQSxGncNw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DXOBrhxSQSxGncNw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DXOBrhxSQSxGncNw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool DXOBrhxSQSxGncNw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isExpandedAndShouldRemoveCorners();
    }

    public static void DcroFtMGRootKEJJ(android.view.object view) {
        view.requestLayout();
    }

    public static void DcroFtMGRootKEJJ(android.view.object view, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DcroFtMGRootKEJJ(android.view.object view, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DcroFtMGRootKEJJ(android.view.object view, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DsOsbHZiuqoRTFUQ(android.view.object view) {
        return androidx.core.view.objectCompat.getImportantForAccessibility(view);
    }

    public static void DsOsbHZiuqoRTFUQ(android.view.object view, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsOsbHZiuqoRTFUQ(android.view.object view, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsOsbHZiuqoRTFUQ(android.view.object view, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsYGjliRKAzgvCiS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        bottomSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void DsYGjliRKAzgvCiS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DsYGjliRKAzgvCiS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DsYGjliRKAzgvCiS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EBlLQYoaZrdcuyEb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void EBlLQYoaZrdcuyEb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBlLQYoaZrdcuyEb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBlLQYoaZrdcuyEb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EEQccJVYMlJhabLO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void EEQccJVYMlJhabLO(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EEQccJVYMlJhabLO(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EEQccJVYMlJhabLO(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EKyLdGwjFkdSQrhW(java.util.List arrayList, java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EKyLdGwjFkdSQrhW(java.util.List arrayList, java.lang.object obj, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EKyLdGwjFkdSQrhW(java.util.List arrayList, java.lang.object obj, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EKyLdGwjFkdSQrhW(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static int EOiJnXdyVAKYEAWq(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void EOiJnXdyVAKYEAWq(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EOiJnXdyVAKYEAWq(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EOiJnXdyVAKYEAWq(android.content.res.TypedArray typedArray, int i, int i2, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator EQGuIysJfAGKgRsR(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void EQGuIysJfAGKgRsR(float[] fArr, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EQGuIysJfAGKgRsR(float[] fArr, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EQGuIysJfAGKgRsR(float[] fArr, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EQflHZZnOzZnclUu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.calculateHalfExpandedOffset();
    }

    public static void EQflHZZnOzZnclUu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EQflHZZnOzZnclUu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EQflHZZnOzZnclUu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVzWPfskisjNqehg(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void EVzWPfskisjNqehg(android.view.object view, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVzWPfskisjNqehg(android.view.object view, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EVzWPfskisjNqehg(android.view.object view, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EXbpJncSDKibZLkl(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EXbpJncSDKibZLkl(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXbpJncSDKibZLkl(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool EXbpJncSDKibZLkl(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void EZxuCHDLKXdBFSGn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void EZxuCHDLKXdBFSGn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EZxuCHDLKXdBFSGn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EZxuCHDLKXdBFSGn(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EhbVYkFihEbPcAdY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void EhbVYkFihEbPcAdY(java.lang.stringBuilder sb, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EhbVYkFihEbPcAdY(java.lang.stringBuilder sb, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EhbVYkFihEbPcAdY(java.lang.stringBuilder sb, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable EpdtgmAggXcCoUat(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState) {
        return bottomSheetBehavior$SavedState.getSuperState();
    }

    public static void EpdtgmAggXcCoUat(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EpdtgmAggXcCoUat(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EpdtgmAggXcCoUat(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ErrDMuUJICeikkrl(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ErrDMuUJICeikkrl(java.util.List arrayList, int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ErrDMuUJICeikkrl(java.util.List arrayList, int i, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErrDMuUJICeikkrl(java.util.List arrayList, int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme EyMpKQBxaYjLKOcY(android.content.object context) {
        return context.getTheme();
    }

    public static void EyMpKQBxaYjLKOcY(android.content.object context, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EyMpKQBxaYjLKOcY(android.content.object context, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EyMpKQBxaYjLKOcY(android.content.object context, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FFvKykgZZVDoxVMx(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2, byte b, float f3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FFvKykgZZVDoxVMx(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2, int i, float f3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FFvKykgZZVDoxVMx(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2, bool z, int i, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FFvKykgZZVDoxVMx(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, float f, float f2) {
        return super.onNestedPreFling(coordinatorLayout, view, view2, f, f2);
    }

    public static void FKTOUZkUSaSGVjxf(android.content.res.TypedArray typedArray, int i, bool z, char c, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FKTOUZkUSaSGVjxf(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FKTOUZkUSaSGVjxf(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FKTOUZkUSaSGVjxf(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int FNJBSxqHbKgQkYVF(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void FNJBSxqHbKgQkYVF(int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FNJBSxqHbKgQkYVF(int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FNJBSxqHbKgQkYVF(int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOAJqscqZGRGRLvN(android.view.object view, int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FOAJqscqZGRGRLvN(android.view.object view, int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FOAJqscqZGRGRLvN(android.view.object view, int i, int i2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FOAJqscqZGRGRLvN(android.view.object view, int i) {
        return view.canScrollVertically(i);
    }

    public static void FRiYSasndTTLNXAU(android.view.object view, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRiYSasndTTLNXAU(android.view.object view, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FRiYSasndTTLNXAU(android.view.object view, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FRiYSasndTTLNXAU(android.view.object view) {
        return androidx.core.view.objectCompat.isNestedScrollingEnabled(view);
    }

    public static int FXPRTIodRRHrpKOt(int i) {
        return java.lang.Math.abs(i);
    }

    public static void FXPRTIodRRHrpKOt(int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FXPRTIodRRHrpKOt(int i, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FXPRTIodRRHrpKOt(int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FYpujKDpOmnZoTwV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z) {
        bottomSheetBehavior.startHashSettling(view, i, z);
    }

    public static void FYpujKDpOmnZoTwV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, char c, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FYpujKDpOmnZoTwV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYpujKDpOmnZoTwV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FaXEDymbjiiuzCTo(android.animation.ValueAnimator valueAnimator, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FaXEDymbjiiuzCTo(android.animation.ValueAnimator valueAnimator, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FaXEDymbjiiuzCTo(android.animation.ValueAnimator valueAnimator, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FaXEDymbjiiuzCTo(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static void FilzqIHeLnHYHBqM(java.util.List arrayList, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FilzqIHeLnHYHBqM(java.util.List arrayList, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FilzqIHeLnHYHBqM(java.util.List arrayList, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FilzqIHeLnHYHBqM(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static int FqflflqMITydCTCX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getWidth();
    }

    public static void FqflflqMITydCTCX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqflflqMITydCTCX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FqflflqMITydCTCX(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FuFSvkVndgsrarrV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setExpandedOffset(i);
    }

    public static void FuFSvkVndgsrarrV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FuFSvkVndgsrarrV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FuFSvkVndgsrarrV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvMgZkgWCdTQCQNq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FvMgZkgWCdTQCQNq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvMgZkgWCdTQCQNq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FvMgZkgWCdTQCQNq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.canBeHiddenByDragging();
    }

    public static void GAkjOExwqyilCuLz(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void GAkjOExwqyilCuLz(android.content.res.TypedArray typedArray, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GAkjOExwqyilCuLz(android.content.res.TypedArray typedArray, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GAkjOExwqyilCuLz(android.content.res.TypedArray typedArray, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GKIPSGRMDvWhOuYy(android.content.object context) {
        return context.getResources();
    }

    public static void GKIPSGRMDvWhOuYy(android.content.object context, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GKIPSGRMDvWhOuYy(android.content.object context, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GKIPSGRMDvWhOuYy(android.content.object context, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GLeHhwenBUoCAwIS(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void GLeHhwenBUoCAwIS(android.view.MotionEvent motionEvent, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GLeHhwenBUoCAwIS(android.view.MotionEvent motionEvent, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GLeHhwenBUoCAwIS(android.view.MotionEvent motionEvent, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GToLXnyKliWMPdXa(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void GToLXnyKliWMPdXa(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GToLXnyKliWMPdXa(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GToLXnyKliWMPdXa(java.lang.ref.WeakReference weakReference, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GVEryAImhGRItOrU(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void GVEryAImhGRItOrU(android.view.object view, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GVEryAImhGRItOrU(android.view.object view, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GVEryAImhGRItOrU(android.view.object view, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GcHOfJVNfGagvcOQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void GcHOfJVNfGagvcOQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GcHOfJVNfGagvcOQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcHOfJVNfGagvcOQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GcTrWdcnOCbVwgVj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void GcTrWdcnOCbVwgVj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GcTrWdcnOCbVwgVj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GcTrWdcnOCbVwgVj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static float GkhHWChKKMWPOlkz(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void GkhHWChKKMWPOlkz(android.view.MotionEvent motionEvent, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GkhHWChKKMWPOlkz(android.view.MotionEvent motionEvent, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GkhHWChKKMWPOlkz(android.view.MotionEvent motionEvent, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GvIpspiFCZgBvict(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void GvIpspiFCZgBvict(int i, int i2, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvIpspiFCZgBvict(int i, int i2, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GvIpspiFCZgBvict(int i, int i2, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HCJryVGWwVlGjeFL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        coordinatorLayout.onLayoutChild(view, i);
    }

    public static void HCJryVGWwVlGjeFL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCJryVGWwVlGjeFL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCJryVGWwVlGjeFL(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HHBEbZwPzxXenDkC(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HHBEbZwPzxXenDkC(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HHBEbZwPzxXenDkC(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HHBEbZwPzxXenDkC(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void HogrgKqlgrnyBQTL(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void HogrgKqlgrnyBQTL(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HogrgKqlgrnyBQTL(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HogrgKqlgrnyBQTL(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.TypedValue ICtjIAtXmuPYPoGQ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.peekValue(i);
    }

    public static void ICtjIAtXmuPYPoGQ(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ICtjIAtXmuPYPoGQ(android.content.res.TypedArray typedArray, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ICtjIAtXmuPYPoGQ(android.content.res.TypedArray typedArray, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPqLGhkIqMbafhpw(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        materialBottomContainerBackHelper.finishBackProgressPersistent(backEventCompat, animator$AnimatorListener);
    }

    public static void IPqLGhkIqMbafhpw(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IPqLGhkIqMbafhpw(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPqLGhkIqMbafhpw(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IWIizBaEsRmtyRXZ(android.view.objectParent viewParent, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IWIizBaEsRmtyRXZ(android.view.objectParent viewParent, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IWIizBaEsRmtyRXZ(android.view.objectParent viewParent, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IWIizBaEsRmtyRXZ(android.view.objectParent viewParent) {
        return viewParent.isLayoutRequested();
    }

    public static int IhpuwvybOFZkjyNF(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionIndex();
    }

    public static void IhpuwvybOFZkjyNF(android.view.MotionEvent motionEvent, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IhpuwvybOFZkjyNF(android.view.MotionEvent motionEvent, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IhpuwvybOFZkjyNF(android.view.MotionEvent motionEvent, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IokvdjIXWaxhSEjP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void IokvdjIXWaxhSEjP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IokvdjIXWaxhSEjP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IokvdjIXWaxhSEjP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int IqwcDudPXOPPmFoM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getState();
    }

    public static void IqwcDudPXOPPmFoM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IqwcDudPXOPPmFoM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IqwcDudPXOPPmFoM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static float ItHYWYeIKwzUOQjE(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void ItHYWYeIKwzUOQjE(android.content.res.TypedArray typedArray, int i, float f, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ItHYWYeIKwzUOQjE(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ItHYWYeIKwzUOQjE(android.content.res.TypedArray typedArray, int i, float f, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JJdoKqenOlZdUCjw(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void JJdoKqenOlZdUCjw(java.lang.ref.WeakReference weakReference, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JJdoKqenOlZdUCjw(java.lang.ref.WeakReference weakReference, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JJdoKqenOlZdUCjw(java.lang.ref.WeakReference weakReference, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityobjectCommand JJjWLAyPHLHbZdtu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.createAccessibilityobjectCommandForState(i);
    }

    public static void JJjWLAyPHLHbZdtu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJjWLAyPHLHbZdtu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JJjWLAyPHLHbZdtu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JKtNvocFohMtjdRm(float f) {
        return java.lang.Math.abs(f);
    }

    public static void JKtNvocFohMtjdRm(float f, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKtNvocFohMtjdRm(float f, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JKtNvocFohMtjdRm(float f, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int JLdfcdHREnscvcty(android.view.object view) {
        return view.getTop();
    }

    public static void JLdfcdHREnscvcty(android.view.object view, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JLdfcdHREnscvcty(android.view.object view, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JLdfcdHREnscvcty(android.view.object view, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JLljHqnCCFPvuvTz(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void JLljHqnCCFPvuvTz(android.content.res.Resources resources, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JLljHqnCCFPvuvTz(android.content.res.Resources resources, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JLljHqnCCFPvuvTz(android.content.res.Resources resources, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMVaFOJfjKQwPKjt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setExpandedOffset(i);
    }

    public static void JMVaFOJfjKQwPKjt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JMVaFOJfjKQwPKjt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JMVaFOJfjKQwPKjt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMoaWEedQfnkNzwD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void JMoaWEedQfnkNzwD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JMoaWEedQfnkNzwD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JMoaWEedQfnkNzwD(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JTCtwPNsKbRhewtg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setSaveFlags(i);
    }

    public static void JTCtwPNsKbRhewtg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTCtwPNsKbRhewtg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTCtwPNsKbRhewtg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JXUbwxRDPwzTuBJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXUbwxRDPwzTuBJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JXUbwxRDPwzTuBJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool JXUbwxRDPwzTuBJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isNestedScrollingCheckEnabled();
    }

    public static android.content.res.TypedArray JplTnhzDrKgnuPno(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void JplTnhzDrKgnuPno(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JplTnhzDrKgnuPno(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JplTnhzDrKgnuPno(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KExFwIrxFCnCWqnR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setPeekHeight(i);
    }

    public static void KExFwIrxFCnCWqnR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KExFwIrxFCnCWqnR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KExFwIrxFCnCWqnR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KFGuwdXAfDzwZUQX(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior) {
        super.onDetachedFromLayoutParams();
    }

    public static void KFGuwdXAfDzwZUQX(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFGuwdXAfDzwZUQX(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KFGuwdXAfDzwZUQX(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.customview.widget.objectDragHelper KOtiVRxrSthwexQc(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        return androidx.customview.widget.objectDragHelper.create(viewGroup, viewDragHelper$Callback);
    }

    public static void KOtiVRxrSthwexQc(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOtiVRxrSthwexQc(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KOtiVRxrSthwexQc(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float KWgvZoeBxknrVeMh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.calculateSlideOffsetWithTop(i);
    }

    public static void KWgvZoeBxknrVeMh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KWgvZoeBxknrVeMh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KWgvZoeBxknrVeMh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KXEATMLpCGlccLuL(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, int i2, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KXEATMLpCGlccLuL(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, bool z2, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KXEATMLpCGlccLuL(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, bool z2, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool KXEATMLpCGlccLuL(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static int KZdlocHFTsynZHGs(int i, int i2, int i3) {
        return android.view.objectGroup.getChildMeasureSpec(i, i2, i3);
    }

    public static void KZdlocHFTsynZHGs(int i, int i2, int i3, int i4, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KZdlocHFTsynZHGs(int i, int i2, int i3, java.lang.string str, float f, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void KZdlocHFTsynZHGs(int i, int i2, int i3, bool z, int i4, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrjEHxXepqncDMZS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setGestureInsetBottomIgnored(z);
    }

    public static void KrjEHxXepqncDMZS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrjEHxXepqncDMZS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KrjEHxXepqncDMZS(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, bool z2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KsmqbMAtExpnRmiw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i) {
        bottomSheetBehavior.updateAccessibilityActions(view, i);
    }

    public static void KsmqbMAtExpnRmiw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KsmqbMAtExpnRmiw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KsmqbMAtExpnRmiw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LCBvRsKJvHFQGvFF(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void LCBvRsKJvHFQGvFF(android.view.object view, int i, int i2, byte b, int i3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LCBvRsKJvHFQGvFF(android.view.object view, int i, int i2, float f, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LCBvRsKJvHFQGvFF(android.view.object view, int i, int i2, float f, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LDiBBEexbBtwPnUf(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        sparseIntArray.Add(i, i2);
    }

    public static void LDiBBEexbBtwPnUf(android.util.SparseIntArray sparseIntArray, int i, int i2, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LDiBBEexbBtwPnUf(android.util.SparseIntArray sparseIntArray, int i, int i2, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LDiBBEexbBtwPnUf(android.util.SparseIntArray sparseIntArray, int i, int i2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LeMfFaMDMtufSMVe(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void LeMfFaMDMtufSMVe(android.view.object view, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LeMfFaMDMtufSMVe(android.view.object view, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LeMfFaMDMtufSMVe(android.view.object view, int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LicbhLOZGOrdmBHK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void LicbhLOZGOrdmBHK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LicbhLOZGOrdmBHK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LicbhLOZGOrdmBHK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LnKZmAHIaelpAFpO(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void LnKZmAHIaelpAFpO(java.lang.ref.WeakReference weakReference, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LnKZmAHIaelpAFpO(java.lang.ref.WeakReference weakReference, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LnKZmAHIaelpAFpO(java.lang.ref.WeakReference weakReference, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LzVJqxCrSBeGoBFk(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void LzVJqxCrSBeGoBFk(android.view.object view, int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LzVJqxCrSBeGoBFk(android.view.object view, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LzVJqxCrSBeGoBFk(android.view.object view, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MQkXrmlRnGKAwvCx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MQkXrmlRnGKAwvCx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MQkXrmlRnGKAwvCx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MQkXrmlRnGKAwvCx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isNestedScrollingCheckEnabled();
    }

    public static void MdQFwqMVxGTOHdPo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MdQFwqMVxGTOHdPo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MdQFwqMVxGTOHdPo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MdQFwqMVxGTOHdPo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isHideable();
    }

    public static int NOMwRltQTkKCCDBn(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void NOMwRltQTkKCCDBn(int i, int i2, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NOMwRltQTkKCCDBn(int i, int i2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NOMwRltQTkKCCDBn(int i, int i2, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int NRztcrhbDXsTZkJb(android.view.object view) {
        return view.getLeft();
    }

    public static void NRztcrhbDXsTZkJb(android.view.object view, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NRztcrhbDXsTZkJb(android.view.object view, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRztcrhbDXsTZkJb(android.view.object view, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NUWYMtJPUPFHpLmD(android.view.object view) {
        return view.getTop();
    }

    public static void NUWYMtJPUPFHpLmD(android.view.object view, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUWYMtJPUPFHpLmD(android.view.object view, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUWYMtJPUPFHpLmD(android.view.object view, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder NXyIqPVFgENXkvqM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.shape.ShapeAppearanceModel.builder(context, attributeHashSet, i, i2);
    }

    public static void NXyIqPVFgENXkvqM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXyIqPVFgENXkvqM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXyIqPVFgENXkvqM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, bool z, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int NaDtDRGSPKessjfN(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void NaDtDRGSPKessjfN(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaDtDRGSPKessjfN(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NaDtDRGSPKessjfN(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaxxKIhKCRuNQXAj(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void NaxxKIhKCRuNQXAj(android.animation.ValueAnimator valueAnimator, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NaxxKIhKCRuNQXAj(android.animation.ValueAnimator valueAnimator, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NaxxKIhKCRuNQXAj(android.animation.ValueAnimator valueAnimator, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NekeJgYSqBVJJvNV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void NekeJgYSqBVJJvNV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NekeJgYSqBVJJvNV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NekeJgYSqBVJJvNV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int NghLVjkqXxMowRmR(android.view.object view) {
        return view.getTop();
    }

    public static void NghLVjkqXxMowRmR(android.view.object view, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NghLVjkqXxMowRmR(android.view.object view, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NghLVjkqXxMowRmR(android.view.object view, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NngYSgZTAKBzaZhV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setInterpolation(f);
    }

    public static void NngYSgZTAKBzaZhV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, char c, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NngYSgZTAKBzaZhV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, float f2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NngYSgZTAKBzaZhV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NsELTFpHoZrsAqAQ(android.content.res.TypedArray typedArray, int i, bool z, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NsELTFpHoZrsAqAQ(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NsELTFpHoZrsAqAQ(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool NsELTFpHoZrsAqAQ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int NzEymWqJGtgBtRyJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void NzEymWqJGtgBtRyJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzEymWqJGtgBtRyJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzEymWqJGtgBtRyJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OFPCfKSzluEannFO(java.util.List arrayList, java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OFPCfKSzluEannFO(java.util.List arrayList, java.lang.object obj, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OFPCfKSzluEannFO(java.util.List arrayList, java.lang.object obj, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OFPCfKSzluEannFO(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Contains(obj);
    }

    public static void OHZYmhEWgNsqxcxj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setMaxWidth(i);
    }

    public static void OHZYmhEWgNsqxcxj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OHZYmhEWgNsqxcxj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OHZYmhEWgNsqxcxj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OOynxzkGqAQhzXaH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z) {
        bottomSheetBehavior.startHashSettling(view, i, z);
    }

    public static void OOynxzkGqAQhzXaH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOynxzkGqAQhzXaH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOynxzkGqAQhzXaH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OSBVELQSvNFkxzBO(int i) {
        return java.lang.Math.abs(i);
    }

    public static void OSBVELQSvNFkxzBO(int i, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OSBVELQSvNFkxzBO(int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSBVELQSvNFkxzBO(int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OXpjnUohamnortyU(android.view.object view) {
        return view.getTop();
    }

    public static void OXpjnUohamnortyU(android.view.object view, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXpjnUohamnortyU(android.view.object view, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OXpjnUohamnortyU(android.view.object view, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int OeEMQzcJsyjLFqCY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void OeEMQzcJsyjLFqCY(android.content.res.Resources resources, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OeEMQzcJsyjLFqCY(android.content.res.Resources resources, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OeEMQzcJsyjLFqCY(android.content.res.Resources resources, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.RoundedCorner OlFMchTBlbXuMSZQ(android.view.WindowInsets windowInsets, int i) {
        return windowInsets.getRoundedCorner(i);
    }

    public static void OlFMchTBlbXuMSZQ(android.view.WindowInsets windowInsets, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OlFMchTBlbXuMSZQ(android.view.WindowInsets windowInsets, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OlFMchTBlbXuMSZQ(android.view.WindowInsets windowInsets, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OrfhgxGpwiwPnDGN(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void OrfhgxGpwiwPnDGN(java.util.List arrayList, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OrfhgxGpwiwPnDGN(java.util.List arrayList, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OrfhgxGpwiwPnDGN(java.util.List arrayList, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static float OxyVOXqhGFMWvRNW(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void OxyVOXqhGFMWvRNW(android.view.MotionEvent motionEvent, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OxyVOXqhGFMWvRNW(android.view.MotionEvent motionEvent, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxyVOXqhGFMWvRNW(android.view.MotionEvent motionEvent, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PNuiysNopduLPiYk(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.updatePeekHeight(z);
    }

    public static void PNuiysNopduLPiYk(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PNuiysNopduLPiYk(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNuiysNopduLPiYk(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PVWAzSVCFbTqCYGM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        bottomSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void PVWAzSVCFbTqCYGM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PVWAzSVCFbTqCYGM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PVWAzSVCFbTqCYGM(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PinvByhtXQJiKBpC(android.animation.ValueAnimator valueAnimator, float[] fArr) {
        valueAnimator.setfloatValues(fArr);
    }

    public static void PinvByhtXQJiKBpC(android.animation.ValueAnimator valueAnimator, float[] fArr, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PinvByhtXQJiKBpC(android.animation.ValueAnimator valueAnimator, float[] fArr, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PinvByhtXQJiKBpC(android.animation.ValueAnimator valueAnimator, float[] fArr, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PkhLmhSYLNNGzIRc(java.util.List arrayList, java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PkhLmhSYLNNGzIRc(java.util.List arrayList, java.lang.object obj, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkhLmhSYLNNGzIRc(java.util.List arrayList, java.lang.object obj, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PkhLmhSYLNNGzIRc(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void PnKsBiNHulbKlAcb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.reset();
    }

    public static void PnKsBiNHulbKlAcb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PnKsBiNHulbKlAcb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PnKsBiNHulbKlAcb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PqKyvwGtZXPzRlVp(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void PqKyvwGtZXPzRlVp(android.view.object view, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PqKyvwGtZXPzRlVp(android.view.object view, int i, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PqKyvwGtZXPzRlVp(android.view.object view, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PwMEjSUMekWjRTFr(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void PwMEjSUMekWjRTFr(java.lang.ref.WeakReference weakReference, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwMEjSUMekWjRTFr(java.lang.ref.WeakReference weakReference, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PwMEjSUMekWjRTFr(java.lang.ref.WeakReference weakReference, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PyTqbYaeIyUGkSWD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void PyTqbYaeIyUGkSWD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyTqbYaeIyUGkSWD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PyTqbYaeIyUGkSWD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QHAQTbizhCpTvmKb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void QHAQTbizhCpTvmKb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QHAQTbizhCpTvmKb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QHAQTbizhCpTvmKb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QJpGYTMhGmjwabrh(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void QJpGYTMhGmjwabrh(android.view.object view, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QJpGYTMhGmjwabrh(android.view.object view, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QJpGYTMhGmjwabrh(android.view.object view, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QlUPUnqSxHGIEoSQ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void QlUPUnqSxHGIEoSQ(java.util.List arrayList, int i, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QlUPUnqSxHGIEoSQ(java.util.List arrayList, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlUPUnqSxHGIEoSQ(java.util.List arrayList, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QtzxuRcOPriddQuI(android.view.objectGroup viewGroup) {
        return viewGroup.getChildCount();
    }

    public static void QtzxuRcOPriddQuI(android.view.objectGroup viewGroup, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QtzxuRcOPriddQuI(android.view.objectGroup viewGroup, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QtzxuRcOPriddQuI(android.view.objectGroup viewGroup, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityobjectCommand QwTIgaQHjeYHbRuc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.createAccessibilityobjectCommandForState(i);
    }

    public static void QwTIgaQHjeYHbRuc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QwTIgaQHjeYHbRuc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QwTIgaQHjeYHbRuc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RKNpailrYSANnuEO(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void RKNpailrYSANnuEO(int i, int i2, byte b, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RKNpailrYSANnuEO(int i, int i2, java.lang.string str, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RKNpailrYSANnuEO(int i, int i2, java.lang.string str, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RPuIdyXMUkcDTvOg(android.view.object view) {
        return view.getHeight();
    }

    public static void RPuIdyXMUkcDTvOg(android.view.object view, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPuIdyXMUkcDTvOg(android.view.object view, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPuIdyXMUkcDTvOg(android.view.object view, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RTrQvGOMlLFczdrP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void RTrQvGOMlLFczdrP(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTrQvGOMlLFczdrP(java.lang.string str, java.lang.string str2, java.lang.string str3, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTrQvGOMlLFczdrP(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RXsxHQCPNpuuSiiM(android.view.RoundedCorner roundedCorner) {
        return roundedCorner.getRadius();
    }

    public static void RXsxHQCPNpuuSiiM(android.view.RoundedCorner roundedCorner, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RXsxHQCPNpuuSiiM(android.view.RoundedCorner roundedCorner, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RXsxHQCPNpuuSiiM(android.view.RoundedCorner roundedCorner, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RZEbaIZsFbTBNpEz(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setSignificantVelocityThreshold(i);
    }

    public static void RZEbaIZsFbTBNpEz(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RZEbaIZsFbTBNpEz(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RZEbaIZsFbTBNpEz(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdJcsKBwAHPNPUJA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdJcsKBwAHPNPUJA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RdJcsKBwAHPNPUJA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RdJcsKBwAHPNPUJA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isHideableWhenDragging();
    }

    public static void RiiKRSmhrejMBCzS(android.content.res.TypedArray typedArray, int i, bool z, char c, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RiiKRSmhrejMBCzS(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RiiKRSmhrejMBCzS(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RiiKRSmhrejMBCzS(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void RlLIsnYAQcaFitRA(java.lang.Action runnable) {
        runnable.run();
    }

    public static void RlLIsnYAQcaFitRA(java.lang.Action runnable, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RlLIsnYAQcaFitRA(java.lang.Action runnable, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RlLIsnYAQcaFitRA(java.lang.Action runnable, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RnBigDYTJLQPbMMi(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void RnBigDYTJLQPbMMi(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RnBigDYTJLQPbMMi(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RnBigDYTJLQPbMMi(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SPgikVKHKkEWpmpZ(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SPgikVKHKkEWpmpZ(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SPgikVKHKkEWpmpZ(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SPgikVKHKkEWpmpZ(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void SalUKszzKvtqgjln(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void SalUKszzKvtqgjln(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SalUKszzKvtqgjln(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SalUKszzKvtqgjln(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SbFtoOpmdayGjVfw(android.view.object view) {
        return view.getLeft();
    }

    public static void SbFtoOpmdayGjVfw(android.view.object view, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbFtoOpmdayGjVfw(android.view.object view, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbFtoOpmdayGjVfw(android.view.object view, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgOBJQXUujylAZQI(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, int i2, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SgOBJQXUujylAZQI(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, int i2, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SgOBJQXUujylAZQI(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, int i2, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SgOBJQXUujylAZQI(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, int i2) {
        return viewDragHelper.smoothSlideobjectTo(view, i, i2);
    }

    public static void SgRCQUyfOicSoOFK(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.calculateCollapsedOffset();
    }

    public static void SgRCQUyfOicSoOFK(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SgRCQUyfOicSoOFK(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgRCQUyfOicSoOFK(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SgmomCJttZUvtSYw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgmomCJttZUvtSYw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SgmomCJttZUvtSYw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SgmomCJttZUvtSYw(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.shouldSkipHalfExpandedStateWhenDragging();
    }

    public static void SosEQOwljMDBqyOx(android.content.res.TypedArray typedArray, int i, bool z, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SosEQOwljMDBqyOx(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SosEQOwljMDBqyOx(android.content.res.TypedArray typedArray, int i, bool z, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool SosEQOwljMDBqyOx(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void SxUxDIHFHIIVsMRJ(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, int i) {
        bottomSheetBehavior$StateHashSettlingTracker.continueHashSettlingToState(i);
    }

    public static void SxUxDIHFHIIVsMRJ(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SxUxDIHFHIIVsMRJ(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SxUxDIHFHIIVsMRJ(com.google.android.material.bottomsheet.BottomSheetBehavior$StateHashSettlingTracker bottomSheetBehavior$StateHashSettlingTracker, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIpwEecYGrlYyiSO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.setPeekHeight(i, z);
    }

    public static void TIpwEecYGrlYyiSO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TIpwEecYGrlYyiSO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TIpwEecYGrlYyiSO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, bool z2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TLtzyOomyvJHasrA(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void TLtzyOomyvJHasrA(int i, int i2, byte b, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TLtzyOomyvJHasrA(int i, int i2, int i3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TLtzyOomyvJHasrA(int i, int i2, bool z, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TOvGCMSBxWCnDNID(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void TOvGCMSBxWCnDNID(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TOvGCMSBxWCnDNID(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TOvGCMSBxWCnDNID(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TQrOCMLuUZwaYBhJ(android.animation.ValueAnimator valueAnimator, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TQrOCMLuUZwaYBhJ(android.animation.ValueAnimator valueAnimator, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQrOCMLuUZwaYBhJ(android.animation.ValueAnimator valueAnimator, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TQrOCMLuUZwaYBhJ(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.isRunning();
    }

    public static int TgzUQKyjERgxVfGF(int i) {
        return java.lang.Math.abs(i);
    }

    public static void TgzUQKyjERgxVfGF(int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgzUQKyjERgxVfGF(int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TgzUQKyjERgxVfGF(int i, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TpcuSmEwQmhUxrQB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.updateImportantForAccessibility(z);
    }

    public static void TpcuSmEwQmhUxrQB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TpcuSmEwQmhUxrQB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TpcuSmEwQmhUxrQB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TzVQNrPRklnLOdAp(android.view.object view) {
        return view.getTop();
    }

    public static void TzVQNrPRklnLOdAp(android.view.object view, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TzVQNrPRklnLOdAp(android.view.object view, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TzVQNrPRklnLOdAp(android.view.object view, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TzqzzNwRRtpdMSfk(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void TzqzzNwRRtpdMSfk(java.lang.ref.WeakReference weakReference, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TzqzzNwRRtpdMSfk(java.lang.ref.WeakReference weakReference, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TzqzzNwRRtpdMSfk(java.lang.ref.WeakReference weakReference, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UZSyGLgeGeJNkIWH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UZSyGLgeGeJNkIWH(java.lang.stringBuilder sb, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UZSyGLgeGeJNkIWH(java.lang.stringBuilder sb, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UZSyGLgeGeJNkIWH(java.lang.stringBuilder sb, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbONToVflUKZlIyO(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void UbONToVflUKZlIyO(android.view.object view, int i, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UbONToVflUKZlIyO(android.view.object view, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbONToVflUKZlIyO(android.view.object view, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcVuuFfrgTJPXwEc(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UcVuuFfrgTJPXwEc(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UcVuuFfrgTJPXwEc(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool UcVuuFfrgTJPXwEc(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void UntVHeezKPiRszlt(android.view.object view, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UntVHeezKPiRszlt(android.view.object view, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UntVHeezKPiRszlt(android.view.object view, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UntVHeezKPiRszlt(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void UvxAkdzwpcTBFhOp(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.calculateCollapsedOffset();
    }

    public static void UvxAkdzwpcTBFhOp(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UvxAkdzwpcTBFhOp(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UvxAkdzwpcTBFhOp(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float UyYTFOiHzqygfaDt(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void UyYTFOiHzqygfaDt(android.view.object view, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyYTFOiHzqygfaDt(android.view.object view, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyYTFOiHzqygfaDt(android.view.object view, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float VFYIdKiVMMNVsmoB(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void VFYIdKiVMMNVsmoB(android.view.MotionEvent motionEvent, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VFYIdKiVMMNVsmoB(android.view.MotionEvent motionEvent, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VFYIdKiVMMNVsmoB(android.view.MotionEvent motionEvent, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VJwLSVEZVfUhYsoH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.updateAccessibilityActions();
    }

    public static void VJwLSVEZVfUhYsoH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJwLSVEZVfUhYsoH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJwLSVEZVfUhYsoH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VKalVsFdHrcXcPSC(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void VKalVsFdHrcXcPSC(java.lang.ref.WeakReference weakReference, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKalVsFdHrcXcPSC(java.lang.ref.WeakReference weakReference, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VKalVsFdHrcXcPSC(java.lang.ref.WeakReference weakReference, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOzJkBJFcXwNqmrD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOzJkBJFcXwNqmrD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VOzJkBJFcXwNqmrD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VOzJkBJFcXwNqmrD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.shouldHandleDraggingWithHelper();
    }

    public static void VPkuTnzLaXZjyZET(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void VPkuTnzLaXZjyZET(android.view.object view, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPkuTnzLaXZjyZET(android.view.object view, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPkuTnzLaXZjyZET(android.view.object view, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VWPxkWcklbGfNQyL(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.createShapeValueAnimator();
    }

    public static void VWPxkWcklbGfNQyL(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWPxkWcklbGfNQyL(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VWPxkWcklbGfNQyL(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VbHpctKnktoUvcGT(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VbHpctKnktoUvcGT(int i, int i2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VbHpctKnktoUvcGT(int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbHpctKnktoUvcGT(int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VhDrYzNzZJaHuJku(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void VhDrYzNzZJaHuJku(java.lang.ref.WeakReference weakReference, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VhDrYzNzZJaHuJku(java.lang.ref.WeakReference weakReference, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VhDrYzNzZJaHuJku(java.lang.ref.WeakReference weakReference, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.VelocityTracker WEWHGTQgBygzJAUK() {
        return android.view.VelocityTracker.obtain();
    }

    public static void WEWHGTQgBygzJAUK(char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WEWHGTQgBygzJAUK(int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WEWHGTQgBygzJAUK(int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WElvFKegYmzDnNdl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, java.lang.Action runnable) {
        bottomSheetBehavior.runAfterLayout(view, runnable);
    }

    public static void WElvFKegYmzDnNdl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, java.lang.Action runnable, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WElvFKegYmzDnNdl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, java.lang.Action runnable, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WElvFKegYmzDnNdl(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, java.lang.Action runnable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WFBCMJTnfMstOufh(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void WFBCMJTnfMstOufh(java.util.List arrayList, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFBCMJTnfMstOufh(java.util.List arrayList, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFBCMJTnfMstOufh(java.util.List arrayList, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WgMxjdoxmxHYxZxa(android.view.VelocityTracker velocityTracker) {
        velocityTracker.recycle();
    }

    public static void WgMxjdoxmxHYxZxa(android.view.VelocityTracker velocityTracker, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WgMxjdoxmxHYxZxa(android.view.VelocityTracker velocityTracker, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WgMxjdoxmxHYxZxa(android.view.VelocityTracker velocityTracker, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WgPlrlvyFBtxznar(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void WgPlrlvyFBtxznar(java.util.Dictionary map, java.lang.object obj, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WgPlrlvyFBtxznar(java.util.Dictionary map, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WgPlrlvyFBtxznar(java.util.Dictionary map, java.lang.object obj, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WqQBffCVEjsHdmyW(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WqQBffCVEjsHdmyW(int i, int i2, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WqQBffCVEjsHdmyW(int i, int i2, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WqQBffCVEjsHdmyW(int i, int i2, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WrKDjrvMpkXJEXxK(android.view.object view) {
        return view.getVisibility();
    }

    public static void WrKDjrvMpkXJEXxK(android.view.object view, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WrKDjrvMpkXJEXxK(android.view.object view, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WrKDjrvMpkXJEXxK(android.view.object view, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WsoNylXcPNXsyLUo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setPeekHeight(i);
    }

    public static void WsoNylXcPNXsyLUo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WsoNylXcPNXsyLUo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WsoNylXcPNXsyLUo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WtbxQZlOEmpvWcPA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtbxQZlOEmpvWcPA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtbxQZlOEmpvWcPA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WtbxQZlOEmpvWcPA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isAtTopOfScreen();
    }

    public static void WzZfWGbaNCBxnZcQ(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void WzZfWGbaNCBxnZcQ(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzZfWGbaNCBxnZcQ(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WzZfWGbaNCBxnZcQ(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.activity.BackEventCompat XJqNfuhpyOxobBpx(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper) {
        return materialBottomContainerBackHelper.onHandleBackInvoked();
    }

    public static void XJqNfuhpyOxobBpx(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XJqNfuhpyOxobBpx(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJqNfuhpyOxobBpx(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent XLcJUAXuKvFSJMkb(android.view.object view) {
        return view.getParent();
    }

    public static void XLcJUAXuKvFSJMkb(android.view.object view, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XLcJUAXuKvFSJMkb(android.view.object view, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XLcJUAXuKvFSJMkb(android.view.object view, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XOAfSCKBjbruHhpc(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledMaximumFlingVelocity();
    }

    public static void XOAfSCKBjbruHhpc(android.view.objectConfiguration viewConfiguration, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XOAfSCKBjbruHhpc(android.view.objectConfiguration viewConfiguration, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XOAfSCKBjbruHhpc(android.view.objectConfiguration viewConfiguration, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XUodGkPEFDvZKVtC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void XUodGkPEFDvZKVtC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XUodGkPEFDvZKVtC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XUodGkPEFDvZKVtC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object XYUDOwHkhhFTGGeP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        return bottomSheetBehavior.findScrollingChild(view);
    }

    public static void XYUDOwHkhhFTGGeP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYUDOwHkhhFTGGeP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYUDOwHkhhFTGGeP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XbjqvNIxnXDUTLZs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void XbjqvNIxnXDUTLZs(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XbjqvNIxnXDUTLZs(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XbjqvNIxnXDUTLZs(android.content.res.TypedArray typedArray, int i, int i2, bool z, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XfoLQyyJMjJdQLzQ(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener) {
        materialBottomContainerBackHelper.finishBackProgressNotPersistent(backEventCompat, animator$AnimatorListener);
    }

    public static void XfoLQyyJMjJdQLzQ(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XfoLQyyJMjJdQLzQ(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XfoLQyyJMjJdQLzQ(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, android.animation.Animator$AnimatorListener animator$AnimatorListener, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float XuDxiROLsCNYFPQF(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void XuDxiROLsCNYFPQF(android.view.MotionEvent motionEvent, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XuDxiROLsCNYFPQF(android.view.MotionEvent motionEvent, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XuDxiROLsCNYFPQF(android.view.MotionEvent motionEvent, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEyoLuYKYlUCKXeY(android.view.object view, int[] iArr) {
        view.getLocationOnScreen(iArr);
    }

    public static void YEyoLuYKYlUCKXeY(android.view.object view, int[] iArr, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEyoLuYKYlUCKXeY(android.view.object view, int[] iArr, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEyoLuYKYlUCKXeY(android.view.object view, int[] iArr, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YIOpgttVWXdauRWR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YIOpgttVWXdauRWR(java.lang.stringBuilder sb, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void YIOpgttVWXdauRWR(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YIOpgttVWXdauRWR(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YRsxorQbLibfHLUc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i) {
        bottomSheetBehavior.updateAccessibilityActions(view, i);
    }

    public static void YRsxorQbLibfHLUc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRsxorQbLibfHLUc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YRsxorQbLibfHLUc(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSYiJmDHcUcPYUFp(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void YSYiJmDHcUcPYUFp(android.view.object view, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSYiJmDHcUcPYUFp(android.view.object view, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YSYiJmDHcUcPYUFp(android.view.object view, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YgWnXbYpCgcZFqcb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YgWnXbYpCgcZFqcb(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YgWnXbYpCgcZFqcb(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YgWnXbYpCgcZFqcb(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YlbtfwsxpZScqbdd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingRight();
    }

    public static void YlbtfwsxpZScqbdd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YlbtfwsxpZScqbdd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YlbtfwsxpZScqbdd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YnUisOzivlfOwguS(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper) {
        materialBottomContainerBackHelper.cancelBackProgress();
    }

    public static void YnUisOzivlfOwguS(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YnUisOzivlfOwguS(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YnUisOzivlfOwguS(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YuzsbAJqktTKxZXP(android.view.object view) {
        return view.getTop();
    }

    public static void YuzsbAJqktTKxZXP(android.view.object view, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YuzsbAJqktTKxZXP(android.view.object view, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YuzsbAJqktTKxZXP(android.view.object view, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YzdGuDHzcgObGVHT(android.view.object view) {
        return view.getTop();
    }

    public static void YzdGuDHzcgObGVHT(android.view.object view, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YzdGuDHzcgObGVHT(android.view.object view, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YzdGuDHzcgObGVHT(android.view.object view, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZBrMxTlYymqgBbyt(androidx.customview.widget.objectDragHelper viewDragHelper) {
        return viewDragHelper.getTouchSlop();
    }

    public static void ZBrMxTlYymqgBbyt(androidx.customview.widget.objectDragHelper viewDragHelper, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZBrMxTlYymqgBbyt(androidx.customview.widget.objectDragHelper viewDragHelper, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZBrMxTlYymqgBbyt(androidx.customview.widget.objectDragHelper viewDragHelper, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZHWaQzastToOorXs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void ZHWaQzastToOorXs(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZHWaQzastToOorXs(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, bool z, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZHWaQzastToOorXs(android.content.res.TypedArray typedArray, int i, int i2, bool z, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpXYJGRXmFLTOTO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpXYJGRXmFLTOTO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpXYJGRXmFLTOTO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZJpXYJGRXmFLTOTO(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        return bottomSheetBehavior.isLayouting(view);
    }

    public static java.lang.object ZJzTvQQxKDXJseCB(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void ZJzTvQQxKDXJseCB(java.lang.ref.WeakReference weakReference, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZJzTvQQxKDXJseCB(java.lang.ref.WeakReference weakReference, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJzTvQQxKDXJseCB(java.lang.ref.WeakReference weakReference, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZMBlmdvbEguHYtWD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void ZMBlmdvbEguHYtWD(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZMBlmdvbEguHYtWD(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZMBlmdvbEguHYtWD(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZNAGxjhjMHeTYeKa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4) {
        return bottomSheetBehavior.getChildMeasureSpec(i, i2, i3, i4);
    }

    public static void ZNAGxjhjMHeTYeKa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, float f, short s, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void ZNAGxjhjMHeTYeKa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, int i5, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZNAGxjhjMHeTYeKa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, short s, byte b, int i5, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZSWCBgiYxGZHFxOf(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void ZSWCBgiYxGZHFxOf(int i, int i2, char c, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSWCBgiYxGZHFxOf(int i, int i2, char c, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZSWCBgiYxGZHFxOf(int i, int i2, bool z, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZczZhsqUzHnwWTRh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.calculateCollapsedOffset();
    }

    public static void ZczZhsqUzHnwWTRh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZczZhsqUzHnwWTRh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZczZhsqUzHnwWTRh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float ZeOpbPTJRCQiUuhx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getYVelocity();
    }

    public static void ZeOpbPTJRCQiUuhx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZeOpbPTJRCQiUuhx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZeOpbPTJRCQiUuhx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZhHxzXhbDGuxeEJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.updateImportantForAccessibility(z);
    }

    public static void ZhHxzXhbDGuxeEJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhHxzXhbDGuxeEJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZhHxzXhbDGuxeEJQ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZhlhOyNzMLvKEhVA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.reset();
    }

    public static void ZhlhOyNzMLvKEhVA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZhlhOyNzMLvKEhVA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZhlhOyNzMLvKEhVA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectConfiguration ZiJVYmXOgPuibxRe(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void ZiJVYmXOgPuibxRe(android.content.object context, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZiJVYmXOgPuibxRe(android.content.object context, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZiJVYmXOgPuibxRe(android.content.object context, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ZiLmUMAkLnmPWUtn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void ZiLmUMAkLnmPWUtn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZiLmUMAkLnmPWUtn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZiLmUMAkLnmPWUtn(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZncVGAsgXoKgKkSd(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZncVGAsgXoKgKkSd(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZncVGAsgXoKgKkSd(android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZncVGAsgXoKgKkSd(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static java.lang.object ZzlwfIfCsCPgXAsE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void ZzlwfIfCsCPgXAsE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzlwfIfCsCPgXAsE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzlwfIfCsCPgXAsE(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADBpzYBCrUGwlidj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.updateAccessibilityActions();
    }

    public static void ADBpzYBCrUGwlidj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADBpzYBCrUGwlidj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADBpzYBCrUGwlidj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFErwSCyMcyGVoRH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.dispatchOnSlide(i);
    }

    public static void AFErwSCyMcyGVoRH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFErwSCyMcyGVoRH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFErwSCyMcyGVoRH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AKRmyHYQAxFzFcMR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        bottomSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void AKRmyHYQAxFzFcMR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AKRmyHYQAxFzFcMR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AKRmyHYQAxFzFcMR(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z) {
        OOynxzkGqAQhzXaH(bottomSheetBehavior, view, i, z);
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, float f, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, short s, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$1000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.marginTopSystemWindowInsets;
    }

    static int access$1102(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.gestureInsetBottom = i;
        return i;
    }

    static void access$1102(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1102(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$1102(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        PNuiysNopduLPiYk(bottomSheetBehavior, z);
    }

    static void access$1200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$1200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1300(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$1300(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.draggable;
    }

    static void access$1400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$1400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static bool access$1400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.fitToContents;
    }

    static int access$1500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.significantVelocityThreshold;
    }

    static void access$1500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$1500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$1600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$1600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return FvMgZkgWCdTQCQNq(bottomSheetBehavior);
    }

    static int access$1900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.peekHeight;
    }

    static void access$1900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$1900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.shape.MaterialShapeDrawable access$200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.materialShapeDrawable;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$2000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$2000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static bool access$2000(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.skipCollapsed;
    }

    static int access$302(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.insetTop = i;
        return i;
    }

    static void access$302(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void access$302(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    static bool access$400(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.paddingBottomSystemWindowInsets;
    }

    static int access$500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.insetBottom;
    }

    static void access$500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$502(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.insetBottom = i;
        return i;
    }

    static void access$502(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$502(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$600(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.paddingLeftSystemWindowInsets;
    }

    static void access$700(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$700(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    static bool access$700(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.paddingRightSystemWindowInsets;
    }

    static void access$800(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$800(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static bool access$800(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.marginLeftSystemWindowInsets;
    }

    static void access$900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    static bool access$900(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.marginRightSystemWindowInsets;
    }

    private int AddAccessibilityActionForState(android.view.object view, int i, int i2) {
        return oXdTqnvNBXPqbiLQ(view, JLljHqnCCFPvuvTz(dBKBCFBdlzdNePZp(view), i), QwTIgaQHjeYHbRuc(this, i2));
    }

    private void AddAccessibilityActionForState(android.view.object view, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    private void AddAccessibilityActionForState(android.view.object view, int i, int i2, char c, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AddAccessibilityActionForState(android.view.object view, int i, int i2, int i3, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AoToaejRYxdrvDtv(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AoToaejRYxdrvDtv(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoToaejRYxdrvDtv(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool AoToaejRYxdrvDtv(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.canBeHiddenByDragging();
    }

    public static void AvBnQBRrBQPliQWm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void AvBnQBRrBQPliQWm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvBnQBRrBQPliQWm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AvBnQBRrBQPliQWm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float BJdjjQJKkQNTjvTt(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.getYVelocity(i);
    }

    public static void BJdjjQJKkQNTjvTt(android.view.VelocityTracker velocityTracker, int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BJdjjQJKkQNTjvTt(android.view.VelocityTracker velocityTracker, int i, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BJdjjQJKkQNTjvTt(android.view.VelocityTracker velocityTracker, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTvVFjzsHsKFXcoX(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        viewDragHelper.processTouchEvent(motionEvent);
    }

    public static void BTvVFjzsHsKFXcoX(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTvVFjzsHsKFXcoX(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BTvVFjzsHsKFXcoX(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int BaygEpgJUAbGFAEe(java.lang.int num) {
        return num.intValue();
    }

    public static void BaygEpgJUAbGFAEe(java.lang.int num, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BaygEpgJUAbGFAEe(java.lang.int num, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BaygEpgJUAbGFAEe(java.lang.int num, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BeoSTJFjMfcfaQPu(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void BeoSTJFjMfcfaQPu(android.view.object view, int i, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BeoSTJFjMfcfaQPu(android.view.object view, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BeoSTJFjMfcfaQPu(android.view.object view, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BojJpZZcCHzQhDkK(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void BojJpZZcCHzQhDkK(java.util.List arrayList, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BojJpZZcCHzQhDkK(java.util.List arrayList, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BojJpZZcCHzQhDkK(java.util.List arrayList, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BpnGAsXBwIlmOBcB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.calculateHalfExpandedOffset();
    }

    public static void BpnGAsXBwIlmOBcB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpnGAsXBwIlmOBcB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpnGAsXBwIlmOBcB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float CGUjZKNXlnXGNFSe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner) {
        return bottomSheetBehavior.calculateCornerInterpolation(f, roundedCorner);
    }

    public static void CGUjZKNXlnXGNFSe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, byte b, int i, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void CGUjZKNXlnXGNFSe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, float f2, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CGUjZKNXlnXGNFSe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, int i, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void COaBdleVoDCMypmx(android.view.object view, android.content.res.ColorStateList colorStateList) {
        androidx.core.view.objectCompat.setBackgroundTintList(view, colorStateList);
    }

    public static void COaBdleVoDCMypmx(android.view.object view, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COaBdleVoDCMypmx(android.view.object view, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COaBdleVoDCMypmx(android.view.object view, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CVSdOmxfTEUzLbVf(android.util.SparseIntArray sparseIntArray, int i) {
        sparseIntArray.delete(i);
    }

    public static void CVSdOmxfTEUzLbVf(android.util.SparseIntArray sparseIntArray, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CVSdOmxfTEUzLbVf(android.util.SparseIntArray sparseIntArray, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CVSdOmxfTEUzLbVf(android.util.SparseIntArray sparseIntArray, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZVIudjOXDGJBCtl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, char c, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CZVIudjOXDGJBCtl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, java.lang.string str, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void CZVIudjOXDGJBCtl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, java.lang.string str, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CZVIudjOXDGJBCtl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    public static int CabeELyIBfnTlLVk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void CabeELyIBfnTlLVk(int i, int i2, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CabeELyIBfnTlLVk(int i, int i2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CabeELyIBfnTlLVk(int i, int i2, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCollapsedOffset() {
        if ((29 + 26) % 26 > 0) {
        }
        int iCVbmVhHxciDFQRuV = CVbmVhHxciDFQRuV(this);
        if (this.fitToContents) {
            this.collapsedOffset = jeCClrrZwHWWDbpq(this.parentHeight - iCVbmVhHxciDFQRuV, this.fitToContentsOffset);
        } else {
            this.collapsedOffset = this.parentHeight - iCVbmVhHxciDFQRuV;
        }
    }

    private void CalculateCollapsedOffset(byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCollapsedOffset(byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCollapsedOffset(float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private float CalculateCornerInterpolation(float f, android.view.RoundedCorner roundedCorner) {
        if (roundedCorner is not null) {
            float fRXsxHQCPNpuuSiiM = RXsxHQCPNpuuSiiM(roundedCorner);
            if (fRXsxHQCPNpuuSiiM > 0.0f && f > 0.0f) {
                return fRXsxHQCPNpuuSiiM / f;
            }
        }
        return 0.0f;
    }

    private void CalculateCornerInterpolation(float f, android.view.RoundedCorner roundedCorner, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCornerInterpolation(float f, android.view.RoundedCorner roundedCorner, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateCornerInterpolation(float f, android.view.RoundedCorner roundedCorner, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateHalfExpandedOffset() {
        if ((18 + 16) % 16 > 0) {
        }
        this.halfExpandedOffset = (int) (this.parentHeight * (1.0f - this.halfExpandedRatio));
    }

    private void CalculateHalfExpandedOffset(char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CalculateHalfExpandedOffset(char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void CalculateHalfExpandedOffset(bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private float CalculateInterpolationWithCornersRemoved() {
        java.lang.ref.WeakReference<V> weakReference;
        android.view.WindowInsets windowInsetsUFLCNeetKDLwCfYF;
        if ((5 + 21) % 21 > 0) {
        }
        if (this.materialShapeDrawable is null || (weakReference = this.viewRef) is null || TzqzzNwRRtpdMSfk(weakReference) is null || android.os.Build$VERSION.SDK_INT < 31) {
            return 0.0f;
        }
        android.view.object view = (android.view.object) jqYUFifDImFfueSW(this.viewRef);
        if (kqMZrhsuptiUWIdC(this) && (windowInsetsUFLCNeetKDLwCfYF = uFLCNeetKDLwCfYF(view)) is not null) {
            return gJyipXUAJvAVVKpD(cGUjZKNXlnXGNFSe(this, noFovgOJVZOnUBSS(this.materialShapeDrawable), wNcaosAWpNRdzhuO(windowInsetsUFLCNeetKDLwCfYF, 0)), pBdctgEcpxHsOhHt(this, wfoPupquWSUozVMA(this.materialShapeDrawable), OlFMchTBlbXuMSZQ(windowInsetsUFLCNeetKDLwCfYF, 1)));
        }
        return 0.0f;
    }

    private void CalculateInterpolationWithCornersRemoved(byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateInterpolationWithCornersRemoved(float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateInterpolationWithCornersRemoved(float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private int CalculatePeekHeight() {
        int iTLtzyOomyvJHasrA;
        int i;
        int i2;
        if ((9 + 23) % 23 > 0) {
        }
        if (this.peekHeightAuto) {
            iTLtzyOomyvJHasrA = TLtzyOomyvJHasrA(ZSWCBgiYxGZHFxOf(this.peekHeightMin, this.parentHeight - ((this.parentWidth * 9) / 16)), this.childHeight);
            i = this.insetBottom;
        } else {
            if (!this.gestureInsetBottomIgnored && !this.paddingBottomSystemWindowInsets && (i2 = this.gestureInsetBottom) > 0) {
                return gEctdiKYtzdOsKcL(this.peekHeight, i2 + this.peekHeightGestureInsetBuffer);
            }
            iTLtzyOomyvJHasrA = this.peekHeight;
            i = this.insetBottom;
        }
        return iTLtzyOomyvJHasrA + i;
    }

    private void CalculatePeekHeight(byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculatePeekHeight(short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculatePeekHeight(short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private float CalculateSlideOffsetWithTop(int i) {
        float f;
        float fEHiGxnopfQyAuAfj;
        if ((12 + 2) % 2 > 0) {
        }
        int i2 = this.collapsedOffset;
        if (i <= i2 && i2 != lwKPgwkzPzjThxFd(this)) {
            int i3 = this.collapsedOffset;
            f = i3 - i;
            fEHiGxnopfQyAuAfj = i3 - eHiGxnopfQyAuAfj(this);
        } else {
            int i4 = this.collapsedOffset;
            f = i4 - i;
            fEHiGxnopfQyAuAfj = this.parentHeight - i4;
        }
        return f / fEHiGxnopfQyAuAfj;
    }

    private void CalculateSlideOffsetWithTop(int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void CalculateSlideOffsetWithTop(int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateSlideOffsetWithTop(int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void CanBeHiddenByDragging(int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CanBeHiddenByDragging(int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void CanBeHiddenByDragging(java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private bool CanBeHiddenByDragging() {
        return MdQFwqMVxGTOHdPo(this) && RdJcsKBwAHPNPUJA(this);
    }

    private void ClearAccessibilityAction(android.view.object view, int i) {
        if ((9 + 17) % 17 > 0) {
        }
        if (view is not null) {
            uDgCSprMBKYmVOAS(view, 524288);
            YSYiJmDHcUcPYUFp(view, 262144);
            LeMfFaMDMtufSMVe(view, 1048576);
            int iTHHnCzsHSVZHhoLy = tHHnCzsHSVZHhoLy(this.expandHalfwayActionIds, i, -1);
            if (iTHHnCzsHSVZHhoLy == -1) {
                return;
            }
            GVEryAImhGRItOrU(view, iTHHnCzsHSVZHhoLy);
            cVSdOmxfTEUzLbVf(this.expandHalfwayActionIds, i);
        }
    }

    private void ClearAccessibilityAction(android.view.object view, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void ClearAccessibilityAction(android.view.object view, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void ClearAccessibilityAction(android.view.object view, int i, bool z, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    private androidx.core.view.accessibility.AccessibilityobjectCommand CreateAccessibilityobjectCommandForState(int i) {
        return new com.google.android.material.bottomsheet.BottomSheetBehavior$6(this, i);
    }

    private void CreateAccessibilityobjectCommandForState(int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateAccessibilityobjectCommandForState(int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateAccessibilityobjectCommandForState(int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateMaterialShapeDrawableIfNeeded(android.content.object context) {
        if ((2 + 1) % 1 > 0) {
        }
        if (this.shapeAppearanceModelDefault is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(this.shapeAppearanceModelDefault);
            this.materialShapeDrawable = materialShapeDrawable;
            fsjxokLsxCDRFYsA(materialShapeDrawable, context);
            android.content.res.ColorStateList colorStateList = this.backgroundTint;
            if (colorStateList is not null) {
                EZxuCHDLKXdBFSGn(this.materialShapeDrawable, colorStateList);
                return;
            }
            android.util.TypedValue typedValue = new android.util.TypedValue();
            KXEATMLpCGlccLuL(EyMpKQBxaYjLKOcY(context), 16842801, typedValue, true);
            DLlrYPbuVmUuwdWi(this.materialShapeDrawable, typedValue.data);
        }
    }

    private void CreateMaterialShapeDrawableIfNeeded(android.content.object context, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateMaterialShapeDrawableIfNeeded(android.content.object context, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateMaterialShapeDrawableIfNeeded(android.content.object context, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CreateShapeValueAnimator() {
        if ((16 + 24) % 24 > 0) {
        }
        float[] fArr = new float[2];
        fArr[0] = kPaPqbJtowqhodvm(this);
        fArr[1] = 1.0f;
        android.animation.ValueAnimator valueAnimatorEQGuIysJfAGKgRsR = EQGuIysJfAGKgRsR(fArr);
        this.interpolatorAnimator = valueAnimatorEQGuIysJfAGKgRsR;
        gXVWXkljjQWccStI(valueAnimatorEQGuIysJfAGKgRsR, 500L);
        JMoaWEedQfnkNzwD(this.interpolatorAnimator, new com.google.android.material.bottomsheet.BottomSheetBehavior$3(this));
    }

    private void CreateShapeValueAnimator(byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateShapeValueAnimator(short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateShapeValueAnimator(short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CuYJdjJHDlCGjFMM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void CuYJdjJHDlCGjFMM(java.util.List arrayList, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CuYJdjJHDlCGjFMM(java.util.List arrayList, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CuYJdjJHDlCGjFMM(java.util.List arrayList, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DBKBCFBdlzdNePZp(android.view.object view) {
        return view.getResources();
    }

    public static void DBKBCFBdlzdNePZp(android.view.object view, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DBKBCFBdlzdNePZp(android.view.object view, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DBKBCFBdlzdNePZp(android.view.object view, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DKRSoYHXZCqcwPJz(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void DKRSoYHXZCqcwPJz(java.lang.ref.WeakReference weakReference, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DKRSoYHXZCqcwPJz(java.lang.ref.WeakReference weakReference, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKRSoYHXZCqcwPJz(java.lang.ref.WeakReference weakReference, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DmIFrhOaBPUGFSOL(android.view.object view, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DmIFrhOaBPUGFSOL(android.view.object view, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DmIFrhOaBPUGFSOL(android.view.object view, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DmIFrhOaBPUGFSOL(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int DnQsyetpyqqXPVoC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4) {
        return bottomSheetBehavior.getChildMeasureSpec(i, i2, i3, i4);
    }

    public static void DnQsyetpyqqXPVoC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DnQsyetpyqqXPVoC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DnQsyetpyqqXPVoC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, int i3, int i4, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DpMPwExvzdsxcDFF(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void DpMPwExvzdsxcDFF(java.lang.stringBuilder sb, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DpMPwExvzdsxcDFF(java.lang.stringBuilder sb, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DpMPwExvzdsxcDFF(java.lang.stringBuilder sb, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DraVBtSgERjaAeLD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getResources();
    }

    public static void DraVBtSgERjaAeLD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DraVBtSgERjaAeLD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DraVBtSgERjaAeLD(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EHiGxnopfQyAuAfj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void EHiGxnopfQyAuAfj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EHiGxnopfQyAuAfj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EHiGxnopfQyAuAfj(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EXMWbmywmESbzbWi(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void EXMWbmywmESbzbWi(int i, int i2, char c, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXMWbmywmESbzbWi(int i, int i2, int i3, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXMWbmywmESbzbWi(int i, int i2, short s, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EbSCSJHKnZYzEHqR(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void EbSCSJHKnZYzEHqR(java.util.List arrayList, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EbSCSJHKnZYzEHqR(java.util.List arrayList, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EbSCSJHKnZYzEHqR(java.util.List arrayList, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EfcHlwseRxQzqPxx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void EfcHlwseRxQzqPxx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfcHlwseRxQzqPxx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfcHlwseRxQzqPxx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int FNFYrSNBfScxMxDY(android.view.object view) {
        return view.getImportantForAccessibility();
    }

    public static void FNFYrSNBfScxMxDY(android.view.object view, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FNFYrSNBfScxMxDY(android.view.object view, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FNFYrSNBfScxMxDY(android.view.object view, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FUUHtgyKwSKmqmDD(android.content.res.TypedArray typedArray, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUUHtgyKwSKmqmDD(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FUUHtgyKwSKmqmDD(android.content.res.TypedArray typedArray, int i, short s, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FUUHtgyKwSKmqmDD(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int FlXOJCcitAZJnNHd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingLeft();
    }

    public static void FlXOJCcitAZJnNHd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlXOJCcitAZJnNHd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlXOJCcitAZJnNHd(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ForeQgZTifuoKtYg(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void ForeQgZTifuoKtYg(android.content.res.Resources resources, int i, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ForeQgZTifuoKtYg(android.content.res.Resources resources, int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ForeQgZTifuoKtYg(android.content.res.Resources resources, int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static <V : android.view.object> com.google.android.material.bottomsheet.BottomSheetBehavior<V> from(V v) {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsIOMzbIqWxFsjGnGM = iOMzbIqWxFsjGnGM(v);
        if (!(viewGroup$LayoutParamsIOMzbIqWxFsjGnGM is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams)) {
            throw new java.lang.IllegalArgumentException("The view is not a child of CoordinatorLayout");
        }
        androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorTpjXyExISapIDYdj = tpjXyExISapIDYdj((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsIOMzbIqWxFsjGnGM);
        if (coordinatorLayout$BehaviorTpjXyExISapIDYdj is com.google.android.material.bottomsheet.BottomSheetBehavior) {
            return (com.google.android.material.bottomsheet.BottomSheetBehavior) coordinatorLayout$BehaviorTpjXyExISapIDYdj;
        }
        throw new java.lang.IllegalArgumentException("The view is not associated with BottomSheetBehavior");
    }

    public static void From(android.view.object view, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void From(android.view.object view, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void From(android.view.object view, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FsjxokLsxCDRFYsA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void FsjxokLsxCDRFYsA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FsjxokLsxCDRFYsA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FsjxokLsxCDRFYsA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FuVAXgjxpnlQfWGJ(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void FuVAXgjxpnlQfWGJ(android.view.object view, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FuVAXgjxpnlQfWGJ(android.view.object view, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FuVAXgjxpnlQfWGJ(android.view.object view, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FvhmzjwfnrJlyNAg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i) {
        bottomSheetBehavior.updateAccessibilityActions(view, i);
    }

    public static void FvhmzjwfnrJlyNAg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FvhmzjwfnrJlyNAg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FvhmzjwfnrJlyNAg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int GCtumdKtYBDeBbYb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, int i2) {
        return bottomSheetBehavior.addAccessibilityActionForState(view, i, i2);
    }

    public static void GCtumdKtYBDeBbYb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, int i2, char c, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCtumdKtYBDeBbYb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, int i2, char c, java.lang.string str, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GCtumdKtYBDeBbYb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, int i2, java.lang.string str, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GEctdiKYtzdOsKcL(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void GEctdiKYtzdOsKcL(int i, int i2, char c, int i3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GEctdiKYtzdOsKcL(int i, int i2, char c, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEctdiKYtzdOsKcL(int i, int i2, float f, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static float GJyipXUAJvAVVKpD(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void GJyipXUAJvAVVKpD(float f, float f2, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GJyipXUAJvAVVKpD(float f, float f2, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GJyipXUAJvAVVKpD(float f, float f2, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator GXVWXkljjQWccStI(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void GXVWXkljjQWccStI(android.animation.ValueAnimator valueAnimator, long j, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GXVWXkljjQWccStI(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GXVWXkljjQWccStI(android.animation.ValueAnimator valueAnimator, long j, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GZzwExoDnpKvpBBg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        return bottomSheetBehavior.findScrollingChild(view);
    }

    public static void GZzwExoDnpKvpBBg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GZzwExoDnpKvpBBg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GZzwExoDnpKvpBBg(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetChildMeasureSpec(int i, int i2, int i3, int i4) {
        int iKZdlocHFTsynZHGs = KZdlocHFTsynZHGs(i, i2, i4);
        if (i3 == -1) {
            return iKZdlocHFTsynZHGs;
        }
        int iFNJBSxqHbKgQkYVF = FNJBSxqHbKgQkYVF(iKZdlocHFTsynZHGs);
        int iHhKBnJALZucMbnoW = hhKBnJALZucMbnoW(iKZdlocHFTsynZHGs);
        if (iFNJBSxqHbKgQkYVF == 1073741824) {
            return eXMWbmywmESbzbWi(NOMwRltQTkKCCDBn(iHhKBnJALZucMbnoW, i3), 1073741824);
        }
        if (iHhKBnJALZucMbnoW != 0) {
            i3 = vuPuPnyekYutVbIZ(iHhKBnJALZucMbnoW, i3);
        }
        return GvIpspiFCZgBvict(i3, int.MIN_VALUE);
    }

    private void GetChildMeasureSpec(int i, int i2, int i3, int i4, char c, java.lang.string str, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    private void GetChildMeasureSpec(int i, int i2, int i3, int i4, int i5, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetChildMeasureSpec(int i, int i2, int i3, int i4, bool z, int i5, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetTopOffsetForState(int i) {
        if ((18 + 23) % 23 > 0) {
        }
        if (i == 3) {
            return NaDtDRGSPKessjfN(this);
        }
        if (i == 4) {
            return this.collapsedOffset;
        }
        if (i == 5) {
            return this.parentHeight;
        }
        if (i != 6) {
            throw new java.lang.IllegalArgumentException(iYQGyLVqIZIxxOSv(dpMPwExvzdsxcDFF(new java.lang.stringBuilder("Invalid state to get top offset: "), i)));
        }
        return this.halfExpandedOffset;
    }

    private void GetTopOffsetForState(int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTopOffsetForState(int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetTopOffsetForState(int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private float GetYVelocity() {
        if ((27 + 23) % 23 > 0) {
        }
        android.view.VelocityTracker velocityTracker = this.velocityTracker;
        if (velocityTracker is null) {
            return 0.0f;
        }
        otDJssRDYnkmNXhW(velocityTracker, 1000, this.maximumVelocity);
        return bJdjjQJKkQNTjvTt(this.velocityTracker, this.activePointerId);
    }

    private void GetYVelocity(char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetYVelocity(int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetYVelocity(int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GhwhQXyPvbHtUOqv(android.view.object view) {
        return view.getTop();
    }

    public static void GhwhQXyPvbHtUOqv(android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhwhQXyPvbHtUOqv(android.view.object view, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GhwhQXyPvbHtUOqv(android.view.object view, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GolEvGfOcSxKWcUa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GolEvGfOcSxKWcUa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GolEvGfOcSxKWcUa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GolEvGfOcSxKWcUa(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isHideableWhenDragging();
    }

    public static int GsUOpIBOvLcZcaXv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingBottom();
    }

    public static void GsUOpIBOvLcZcaXv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GsUOpIBOvLcZcaXv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GsUOpIBOvLcZcaXv(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GwmMGtYCYFTZnpZh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setHideable(z);
    }

    public static void GwmMGtYCYFTZnpZh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GwmMGtYCYFTZnpZh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GwmMGtYCYFTZnpZh(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static float HEiCYtszxbFtWauy(float f) {
        return java.lang.Math.abs(f);
    }

    public static void HEiCYtszxbFtWauy(float f, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEiCYtszxbFtWauy(float f, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HEiCYtszxbFtWauy(float f, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HOYgCgytbKObLecT(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void HOYgCgytbKObLecT(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HOYgCgytbKObLecT(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HOYgCgytbKObLecT(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HaYIYLTVnrtSypLO(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void HaYIYLTVnrtSypLO(android.animation.ValueAnimator valueAnimator, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HaYIYLTVnrtSypLO(android.animation.ValueAnimator valueAnimator, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HaYIYLTVnrtSypLO(android.animation.ValueAnimator valueAnimator, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HhKBnJALZucMbnoW(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void HhKBnJALZucMbnoW(int i, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HhKBnJALZucMbnoW(int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhKBnJALZucMbnoW(int i, char c, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HkIauNVMzsuvVloX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkIauNVMzsuvVloX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HkIauNVMzsuvVloX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HkIauNVMzsuvVloX(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.shouldHandleDraggingWithHelper();
    }

    public static void HlbULfRWcNSKjqWy(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.reverse();
    }

    public static void HlbULfRWcNSKjqWy(android.animation.ValueAnimator valueAnimator, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlbULfRWcNSKjqWy(android.animation.ValueAnimator valueAnimator, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlbULfRWcNSKjqWy(android.animation.ValueAnimator valueAnimator, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams iOMzbIqWxFsjGnGM(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void IOMzbIqWxFsjGnGM(android.view.object view, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IOMzbIqWxFsjGnGM(android.view.object view, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOMzbIqWxFsjGnGM(android.view.object view, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IYQGyLVqIZIxxOSv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IYQGyLVqIZIxxOSv(java.lang.stringBuilder sb, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IYQGyLVqIZIxxOSv(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IYQGyLVqIZIxxOSv(java.lang.stringBuilder sb, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsAtTopOfScreen(byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsAtTopOfScreen(float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsAtTopOfScreen(bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsAtTopOfScreen() {
        if ((19 + 24) % 24 > 0) {
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is not null && wrQvtCAwEIiGyjEi(weakReference) is not null) {
            int[] iArr = new int[2];
            YEyoLuYKYlUCKXeY((android.view.object) LnKZmAHIaelpAFpO(this.viewRef), iArr);
            if (iArr[1] == 0) {
                return true;
            }
        }
        return false;
    }

    private void IsExpandedAndShouldRemoveCorners(char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsExpandedAndShouldRemoveCorners(float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsExpandedAndShouldRemoveCorners(short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool IsExpandedAndShouldRemoveCorners() {
        if ((9 + 7) % 7 > 0) {
        }
        if (this.state != 3) {
            return false;
        }
        return this.shouldRemoveExpandedCorners || WtbxQZlOEmpvWcPA(this);
    }

    private void IsLayouting(android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsLayouting(android.view.object view, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsLayouting(android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private bool IsLayouting(V v) {
        android.view.objectParent viewParentXLcJUAXuKvFSJMkb = XLcJUAXuKvFSJMkb(v);
        return viewParentXLcJUAXuKvFSJMkb is not null && IWIizBaEsRmtyRXZ(viewParentXLcJUAXuKvFSJMkb) && kpHWFRKMMtoypLgL(v);
    }

    public static int IzlABjJIbxMhhJnE(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.calculatePeekHeight();
    }

    public static void IzlABjJIbxMhhJnE(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IzlABjJIbxMhhJnE(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IzlABjJIbxMhhJnE(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JFPGmepLHSiJSJRe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i) {
        bottomSheetBehavior.clearAccessibilityAction(view, i);
    }

    public static void JFPGmepLHSiJSJRe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JFPGmepLHSiJSJRe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFPGmepLHSiJSJRe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JSSeBjhIekuIVbJA(float f) {
        return java.lang.Math.abs(f);
    }

    public static void JSSeBjhIekuIVbJA(float f, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JSSeBjhIekuIVbJA(float f, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JSSeBjhIekuIVbJA(float f, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JeCClrrZwHWWDbpq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void JeCClrrZwHWWDbpq(int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeCClrrZwHWWDbpq(int i, int i2, java.lang.string str, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeCClrrZwHWWDbpq(int i, int i2, bool z, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JeUOCnwjMziyDdJP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getInterpolation();
    }

    public static void JeUOCnwjMziyDdJP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JeUOCnwjMziyDdJP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JeUOCnwjMziyDdJP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int JfKpCGdwiOqJgCHI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.getTopOffsetForState(i);
    }

    public static void JfKpCGdwiOqJgCHI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfKpCGdwiOqJgCHI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfKpCGdwiOqJgCHI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent JoMgPVjXiiZZosqB(android.view.object view) {
        return view.getParent();
    }

    public static void JoMgPVjXiiZZosqB(android.view.object view, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JoMgPVjXiiZZosqB(android.view.object view, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JoMgPVjXiiZZosqB(android.view.object view, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float JqBfGXHWFxmyLskH(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void JqBfGXHWFxmyLskH(android.view.MotionEvent motionEvent, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JqBfGXHWFxmyLskH(android.view.MotionEvent motionEvent, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JqBfGXHWFxmyLskH(android.view.MotionEvent motionEvent, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JqYUFifDImFfueSW(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void JqYUFifDImFfueSW(java.lang.ref.WeakReference weakReference, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqYUFifDImFfueSW(java.lang.ref.WeakReference weakReference, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqYUFifDImFfueSW(java.lang.ref.WeakReference weakReference, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMCWQlYAWVifDHYo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i) {
        bottomSheetBehavior.clearAccessibilityAction(view, i);
    }

    public static void KMCWQlYAWVifDHYo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KMCWQlYAWVifDHYo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KMCWQlYAWVifDHYo(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, bool z, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KOkPWoYrUtiupgiA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState) {
        bottomSheetBehavior.restoreobject?State(bottomSheetBehavior$SavedState);
    }

    public static void KOkPWoYrUtiupgiA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KOkPWoYrUtiupgiA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOkPWoYrUtiupgiA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KPELsMyODfXkyvQl(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i) {
        bottomSheetBehavior$BottomSheetCallback.onStateChanged(view, i);
    }

    public static void KPELsMyODfXkyvQl(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KPELsMyODfXkyvQl(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPELsMyODfXkyvQl(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static float KPaPqbJtowqhodvm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.calculateInterpolationWithCornersRemoved();
    }

    public static void KPaPqbJtowqhodvm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPaPqbJtowqhodvm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KPaPqbJtowqhodvm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KSbYnZgBrXsvVYMI(android.content.res.TypedArray typedArray, int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KSbYnZgBrXsvVYMI(android.content.res.TypedArray typedArray, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KSbYnZgBrXsvVYMI(android.content.res.TypedArray typedArray, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool KSbYnZgBrXsvVYMI(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void KpHWFRKMMtoypLgL(android.view.object view, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KpHWFRKMMtoypLgL(android.view.object view, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KpHWFRKMMtoypLgL(android.view.object view, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KpHWFRKMMtoypLgL(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void KqMZrhsuptiUWIdC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqMZrhsuptiUWIdC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KqMZrhsuptiUWIdC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KqMZrhsuptiUWIdC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isAtTopOfScreen();
    }

    public static void KyGlgymIibQjnfLI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setDraggable(z);
    }

    public static void KyGlgymIibQjnfLI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KyGlgymIibQjnfLI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KyGlgymIibQjnfLI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXRFTJrgsAOlZlYA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void LXRFTJrgsAOlZlYA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LXRFTJrgsAOlZlYA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LXRFTJrgsAOlZlYA(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfotsQoHzKtguadY(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, float f2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LfotsQoHzKtguadY(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, java.lang.string str, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LfotsQoHzKtguadY(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f, java.lang.string str, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool LfotsQoHzKtguadY(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, float f) {
        return bottomSheetBehavior.shouldHide(view, f);
    }

    public static float LlmEYNwuwTvtIYoW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.calculateInterpolationWithCornersRemoved();
    }

    public static void LlmEYNwuwTvtIYoW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LlmEYNwuwTvtIYoW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LlmEYNwuwTvtIYoW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LwKPgwkzPzjThxFd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getExpandedOffset();
    }

    public static void LwKPgwkzPzjThxFd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LwKPgwkzPzjThxFd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LwKPgwkzPzjThxFd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LydXhbPZpZyPKgYJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        super.onAttachedToLayoutParams(coordinatorLayout$LayoutParams);
    }

    public static void LydXhbPZpZyPKgYJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LydXhbPZpZyPKgYJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LydXhbPZpZyPKgYJ(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBOecKJFhVzhoeHB(android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MBOecKJFhVzhoeHB(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBOecKJFhVzhoeHB(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MBOecKJFhVzhoeHB(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static java.lang.object MMSjeVSOEuRiKnoN(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void MMSjeVSOEuRiKnoN(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMSjeVSOEuRiKnoN(java.lang.ref.WeakReference weakReference, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MMSjeVSOEuRiKnoN(java.lang.ref.WeakReference weakReference, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MZmMdEqVOQYTKjgo(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MZmMdEqVOQYTKjgo(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MZmMdEqVOQYTKjgo(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MZmMdEqVOQYTKjgo(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        return viewDragHelper.shouldInterceptTouchEvent(motionEvent);
    }

    public static void MbRdsVdmtDeWbdhD(android.view.object view, bool z) {
        view.setFitsSystemWindows(z);
    }

    public static void MbRdsVdmtDeWbdhD(android.view.object view, bool z, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MbRdsVdmtDeWbdhD(android.view.object view, bool z, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MbRdsVdmtDeWbdhD(android.view.object view, bool z, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MqLsscAVSxYZOoHh(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void MqLsscAVSxYZOoHh(android.view.object view, int i, short s, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqLsscAVSxYZOoHh(android.view.object view, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MqLsscAVSxYZOoHh(android.view.object view, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MtpYzrYnMOJBEKQe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.updateAccessibilityActions();
    }

    public static void MtpYzrYnMOJBEKQe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MtpYzrYnMOJBEKQe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MtpYzrYnMOJBEKQe(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdkYnJphmGEhjNoH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NdkYnJphmGEhjNoH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NdkYnJphmGEhjNoH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NdkYnJphmGEhjNoH(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    public static void NdrVnGSCUsKmXFMu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void NdrVnGSCUsKmXFMu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NdrVnGSCUsKmXFMu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NdrVnGSCUsKmXFMu(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, bool z2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float NoFovgOJVZOnUBSS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopLeftCornerResolvedSize();
    }

    public static void NoFovgOJVZOnUBSS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NoFovgOJVZOnUBSS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoFovgOJVZOnUBSS(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object NznQLkjRDGAwNzYn(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void NznQLkjRDGAwNzYn(android.view.objectGroup viewGroup, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NznQLkjRDGAwNzYn(android.view.objectGroup viewGroup, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NznQLkjRDGAwNzYn(android.view.objectGroup viewGroup, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int OXdTqnvNBXPqbiLQ(android.view.object view, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        return androidx.core.view.objectCompat.addAccessibilityAction(view, charSequence, accessibilityobjectCommand);
    }

    public static void OXdTqnvNBXPqbiLQ(android.view.object view, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXdTqnvNBXPqbiLQ(android.view.object view, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OXdTqnvNBXPqbiLQ(android.view.object view, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhrMPllNFbEbhoTD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setSkipCollapsed(z);
    }

    public static void OhrMPllNFbEbhoTD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OhrMPllNFbEbhoTD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OhrMPllNFbEbhoTD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int OjyEdNhzHzfEttIs(android.view.object view) {
        return view.getTop();
    }

    public static void OjyEdNhzHzfEttIs(android.view.object view, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OjyEdNhzHzfEttIs(android.view.object view, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OjyEdNhzHzfEttIs(android.view.object view, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OtDJssRDYnkmNXhW(android.view.VelocityTracker velocityTracker, int i, float f) {
        velocityTracker.computeCurrentVelocity(i, f);
    }

    public static void OtDJssRDYnkmNXhW(android.view.VelocityTracker velocityTracker, int i, float f, char c, float f2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OtDJssRDYnkmNXhW(android.view.VelocityTracker velocityTracker, int i, float f, float f2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtDJssRDYnkmNXhW(android.view.VelocityTracker velocityTracker, int i, float f, short s, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OuKxmpDsCHmuIwJM(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void OuKxmpDsCHmuIwJM(java.lang.ref.WeakReference weakReference, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OuKxmpDsCHmuIwJM(java.lang.ref.WeakReference weakReference, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OuKxmpDsCHmuIwJM(java.lang.ref.WeakReference weakReference, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvDibhihoOODEKlZ(androidx.customview.widget.objectDragHelper viewDragHelper, int i, int i2, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OvDibhihoOODEKlZ(androidx.customview.widget.objectDragHelper viewDragHelper, int i, int i2, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OvDibhihoOODEKlZ(androidx.customview.widget.objectDragHelper viewDragHelper, int i, int i2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool OvDibhihoOODEKlZ(androidx.customview.widget.objectDragHelper viewDragHelper, int i, int i2) {
        return viewDragHelper.settleCapturedobjectAt(i, i2);
    }

    public static java.lang.object OykRWMqAjWdIREye(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void OykRWMqAjWdIREye(java.lang.ref.WeakReference weakReference, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OykRWMqAjWdIREye(java.lang.ref.WeakReference weakReference, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OykRWMqAjWdIREye(java.lang.ref.WeakReference weakReference, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float PBdctgEcpxHsOhHt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner) {
        return bottomSheetBehavior.calculateCornerInterpolation(f, roundedCorner);
    }

    public static void PBdctgEcpxHsOhHt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, int i, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PBdctgEcpxHsOhHt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, java.lang.string str, int i, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PBdctgEcpxHsOhHt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, android.view.RoundedCorner roundedCorner, java.lang.string str, int i, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PLMioMqHAvPUoOqI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z) {
        bottomSheetBehavior.setFitToContents(z);
    }

    public static void PLMioMqHAvPUoOqI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, byte b, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLMioMqHAvPUoOqI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PLMioMqHAvPUoOqI(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, bool z2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZzJzZQGisKHaJMy(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void PZzJzZQGisKHaJMy(android.view.object view, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZzJzZQGisKHaJMy(android.view.object view, int i, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZzJzZQGisKHaJMy(android.view.object view, int i, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PfIaLIbikbFTpFFJ(android.view.object view, int i) {
        view.sendAccessibilityEvent(i);
    }

    public static void PfIaLIbikbFTpFFJ(android.view.object view, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PfIaLIbikbFTpFFJ(android.view.object view, int i, float f, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PfIaLIbikbFTpFFJ(android.view.object view, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PfjICtKhilZiowMS(int i) {
        return java.lang.Math.abs(i);
    }

    public static void PfjICtKhilZiowMS(int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PfjICtKhilZiowMS(int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PfjICtKhilZiowMS(int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PgZOMEYeQQLgVfnY(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        androidx.core.view.objectCompat.replaceAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, charSequence, accessibilityobjectCommand);
    }

    public static void PgZOMEYeQQLgVfnY(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PgZOMEYeQQLgVfnY(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PgZOMEYeQQLgVfnY(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QAOlwqWylbjNxPnJ(android.content.res.TypedArray typedArray, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAOlwqWylbjNxPnJ(android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAOlwqWylbjNxPnJ(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QAOlwqWylbjNxPnJ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void QAwriLKOKfvfHdYd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setStateInternal(i);
    }

    public static void QAwriLKOKfvfHdYd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QAwriLKOKfvfHdYd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QAwriLKOKfvfHdYd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QJDGLudhIJyDILjI(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void QJDGLudhIJyDILjI(java.lang.ref.WeakReference weakReference, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QJDGLudhIJyDILjI(java.lang.ref.WeakReference weakReference, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QJDGLudhIJyDILjI(java.lang.ref.WeakReference weakReference, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QKapSiSgtpvihnJh(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view) {
        bottomSheetBehavior$BottomSheetCallback.onLayout(view);
    }

    public static void QKapSiSgtpvihnJh(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QKapSiSgtpvihnJh(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QKapSiSgtpvihnJh(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTtNyKwjbypqFTfK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void QTtNyKwjbypqFTfK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, java.lang.string str, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTtNyKwjbypqFTfK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, float f2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTtNyKwjbypqFTfK(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RFWIkcTEJAMtQVSB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RFWIkcTEJAMtQVSB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RFWIkcTEJAMtQVSB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RFWIkcTEJAMtQVSB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isGestureInsetBottomIgnored();
    }

    public static void RJATPXTuxcRTWiPY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable) {
        super.onRestoreInstanceState(coordinatorLayout, view, parcelable);
    }

    public static void RJATPXTuxcRTWiPY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RJATPXTuxcRTWiPY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RJATPXTuxcRTWiPY(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.os.Parcelable parcelable, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RURtfmNGhapFFasx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void RURtfmNGhapFFasx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RURtfmNGhapFFasx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RURtfmNGhapFFasx(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, short s, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ReplaceAccessibilityActionForState(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        pgZOMEYeQQLgVfnY(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, null, JJjWLAyPHLHbZdtu(this, i));
    }

    private void ReplaceAccessibilityActionForState(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ReplaceAccessibilityActionForState(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ReplaceAccessibilityActionForState(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void Reset() {
        this.activePointerId = -1;
        this.initialY = -1;
        android.view.VelocityTracker velocityTracker = this.velocityTracker;
        if (velocityTracker is null) {
            return;
        }
        WgMxjdoxmxHYxZxa(velocityTracker);
        this.velocityTracker = null;
    }

    private void Reset(short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Reset(short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Reset(bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void restoreobject?State(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState) {
        if ((6 + 13) % 13 > 0) {
        }
        int i = this.saveFlags;
        if (i != 0) {
            if (i == -1 || (i & 1) == 1) {
                this.peekHeight = bottomSheetBehavior$SavedState.peekHeight;
            }
            int i2 = this.saveFlags;
            if (i2 == -1 || (i2 & 2) == 2) {
                this.fitToContents = bottomSheetBehavior$SavedState.fitToContents;
            }
            int i3 = this.saveFlags;
            if (i3 == -1 || (i3 & 4) == 4) {
                this.hideable = bottomSheetBehavior$SavedState.hideable;
            }
            int i4 = this.saveFlags;
            if (i4 == -1 || (i4 & 8) == 8) {
                this.skipCollapsed = bottomSheetBehavior$SavedState.skipCollapsed;
            }
        }
    }

    private void restoreobject?State(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void restoreobject?State(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void restoreobject?State(com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RlJoejOyOzjijRbE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, char c, java.lang.string str, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RlJoejOyOzjijRbE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, float f, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RlJoejOyOzjijRbE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RlJoejOyOzjijRbE(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    private void RunAfterLayout(V v, java.lang.Action runnable) {
        if (ZJpXYJGRXmFLTOTO(this, v)) {
            yHzzzWjqIWapacuk(v, runnable);
        } else {
            RlLIsnYAQcaFitRA(runnable);
        }
    }

    private void RunAfterLayout(android.view.object view, java.lang.Action runnable, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void RunAfterLayout(android.view.object view, java.lang.Action runnable, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void RunAfterLayout(android.view.object view, java.lang.Action runnable, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RxeNSRFMURVQJpvh(int i) {
        return java.lang.Math.abs(i);
    }

    public static void RxeNSRFMURVQJpvh(int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RxeNSRFMURVQJpvh(int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxeNSRFMURVQJpvh(int i, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SSaAUmnqnxvPPzzT(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void SSaAUmnqnxvPPzzT(java.lang.ref.WeakReference weakReference, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SSaAUmnqnxvPPzzT(java.lang.ref.WeakReference weakReference, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SSaAUmnqnxvPPzzT(java.lang.ref.WeakReference weakReference, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetWindowInsetsListener(android.view.object view) {
        if ((10 + 14) % 14 > 0) {
        }
        bool z = (rFWIkcTEJAMtQVSB(this) || this.peekHeightAuto) ? false : true;
        if (this.paddingBottomSystemWindowInsets || this.paddingLeftSystemWindowInsets || this.paddingRightSystemWindowInsets || this.marginLeftSystemWindowInsets || this.marginRightSystemWindowInsets || this.marginTopSystemWindowInsets || z) {
            wNyegxUofPgQRncu(view, new com.google.android.material.bottomsheet.BottomSheetBehavior$4(this, z));
        }
    }

    private void SetWindowInsetsListener(android.view.object view, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetWindowInsetsListener(android.view.object view, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetWindowInsetsListener(android.view.object view, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShouldHandleDraggingWithHelper(int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ShouldHandleDraggingWithHelper(short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldHandleDraggingWithHelper(short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldHandleDraggingWithHelper() {
        if ((23 + 27) % 27 > 0) {
        }
        if (this.viewDragHelper is null) {
            return false;
        }
        return this.draggable || this.state == 1;
    }

    private void StartHashSettling(android.view.object view, int i, bool z) {
        if ((27 + 31) % 31 > 0) {
        }
        int iJfKpCGdwiOqJgCHI = jfKpCGdwiOqJgCHI(this, i);
        androidx.customview.widget.objectDragHelper viewDragHelper = this.viewDragHelper;
        if (viewDragHelper is null || (z ? !ovDibhihoOODEKlZ(viewDragHelper, NRztcrhbDXsTZkJb(view), iJfKpCGdwiOqJgCHI) : !SgOBJQXUujylAZQI(viewDragHelper, view, SbFtoOpmdayGjVfw(view), iJfKpCGdwiOqJgCHI))) {
            IokvdjIXWaxhSEjP(this, i);
            return;
        }
        hOYgCgytbKObLecT(this, 2);
        PyTqbYaeIyUGkSWD(this, i, true);
        SxUxDIHFHIIVsMRJ(this.stateHashSettlingTracker, i);
    }

    private void StartHashSettling(android.view.object view, int i, bool z, short s, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void StartHashSettling(android.view.object view, int i, bool z, bool z2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void StartHashSettling(android.view.object view, int i, bool z, bool z2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TAOfXiwbeHSOpCVP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.getTopOffsetForState(i);
    }

    public static void TAOfXiwbeHSOpCVP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TAOfXiwbeHSOpCVP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, int i2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TAOfXiwbeHSOpCVP(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int THHnCzsHSVZHhoLy(android.util.SparseIntArray sparseIntArray, int i, int i2) {
        return sparseIntArray[i, i2);
    }

    public static void THHnCzsHSVZHhoLy(android.util.SparseIntArray sparseIntArray, int i, int i2, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void THHnCzsHSVZHhoLy(android.util.SparseIntArray sparseIntArray, int i, int i2, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void THHnCzsHSVZHhoLy(android.util.SparseIntArray sparseIntArray, int i, int i2, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void THnIJlEefdPrGFTW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        bottomSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void THnIJlEefdPrGFTW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void THnIJlEefdPrGFTW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void THnIJlEefdPrGFTW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TZliiBeYDIhljnuB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f) {
        bottomSheetBehavior.setHalfExpandedRatio(f);
    }

    public static void TZliiBeYDIhljnuB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZliiBeYDIhljnuB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TZliiBeYDIhljnuB(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior tpjXyExISapIDYdj(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void TpjXyExISapIDYdj(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TpjXyExISapIDYdj(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TpjXyExISapIDYdj(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UDgCSprMBKYmVOAS(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void UDgCSprMBKYmVOAS(android.view.object view, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UDgCSprMBKYmVOAS(android.view.object view, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UDgCSprMBKYmVOAS(android.view.object view, int i, int i2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.WindowInsets UFLCNeetKDLwCfYF(android.view.object view) {
        return view.getRootWindowInsets();
    }

    public static void UFLCNeetKDLwCfYF(android.view.object view, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UFLCNeetKDLwCfYF(android.view.object view, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UFLCNeetKDLwCfYF(android.view.object view, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVEycwYDqypzXVNA(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback) {
        androidx.core.view.objectCompat.setWindowInsetsAnimationCallback(view, windowInsetsAnimationCompat$Callback);
    }

    public static void UVEycwYDqypzXVNA(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVEycwYDqypzXVNA(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UVEycwYDqypzXVNA(android.view.object view, androidx.core.view.WindowInsetsAnimationCompat$Callback windowInsetsAnimationCompat$Callback, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UZkfHLoCuaFWONPU(android.view.object view) {
        return view.getTop();
    }

    public static void UZkfHLoCuaFWONPU(android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UZkfHLoCuaFWONPU(android.view.object view, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UZkfHLoCuaFWONPU(android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UaIRtsTeQmqHyfHC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UaIRtsTeQmqHyfHC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UaIRtsTeQmqHyfHC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UaIRtsTeQmqHyfHC(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isNestedScrollingCheckEnabled();
    }

    private void UpdateAccessibilityActions() {
        if ((22 + 3) % 3 > 0) {
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is not null) {
            KsmqbMAtExpnRmiw(this, (android.view.object) sSaAUmnqnxvPPzzT(weakReference), 0);
        }
        java.lang.ref.WeakReference<android.view.object> weakReference2 = this.accessibilityDelegateobjectRef;
        if (weakReference2 is null) {
            return;
        }
        fvhmzjwfnrJlyNAg(this, (android.view.object) mMSjeVSOEuRiKnoN(weakReference2), 1);
    }

    private void UpdateAccessibilityActions(char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view, int i) {
        if ((21 + 21) % 21 > 0) {
        }
        if (view is not null) {
            jFPGmepLHSiJSJRe(this, view, i);
            if (!this.fitToContents && this.state != 6) {
                LDiBBEexbBtwPnUf(this.expandHalfwayActionIds, i, gCtumdKtYBDeBbYb(this, view, com.google.android.material.R$string.bottomsheet_action_expand_halfway, 6));
            }
            if (this.hideable && golEvGfOcSxKWcUa(this) && this.state != 5) {
                wrIxotoldgFtXmlb(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_DISMISS, 5);
            }
            int i2 = this.state;
            if (i2 == 3) {
                aKRmyHYQAxFzFcMR(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_COLLAPSE, this.fitToContents ? 4 : 6);
                return;
            }
            if (i2 == 4) {
                PVWAzSVCFbTqCYGM(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_EXPAND, this.fitToContents ? 3 : 6);
            } else if (i2 == 6) {
                DsYGjliRKAzgvCiS(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_COLLAPSE, 4);
                tHnIJlEefdPrGFTW(this, view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_EXPAND, 3);
            }
        }
    }

    private void UpdateAccessibilityActions(android.view.object view, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view, int i, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableForTargetState(int i, bool z) {
        android.animation.ValueAnimator valueAnimator;
        if ((4 + 6) % 6 > 0) {
        }
        if (i != 2) {
            bool zDXOBrhxSQSxGncNw = DXOBrhxSQSxGncNw(this);
            if (this.expandedCornersRemoved == zDXOBrhxSQSxGncNw || this.materialShapeDrawable is null) {
                return;
            }
            this.expandedCornersRemoved = zDXOBrhxSQSxGncNw;
            if (!z || (valueAnimator = this.interpolatorAnimator) is null) {
                android.animation.ValueAnimator valueAnimator2 = this.interpolatorAnimator;
                if (valueAnimator2 is not null && TQrOCMLuUZwaYBhJ(valueAnimator2)) {
                    haYIYLTVnrtSypLO(this.interpolatorAnimator);
                }
                NngYSgZTAKBzaZhV(this.materialShapeDrawable, this.expandedCornersRemoved ? xkGKsAstGkoyFPpi(this) : 1.0f);
                return;
            }
            if (FaXEDymbjiiuzCTo(valueAnimator)) {
                hlbULfRWcNSKjqWy(this.interpolatorAnimator);
                return;
            }
            float fJeUOCnwjMziyDdJP = jeUOCnwjMziyDdJP(this.materialShapeDrawable);
            float fLlmEYNwuwTvtIYoW = zDXOBrhxSQSxGncNw ? llmEYNwuwTvtIYoW(this) : 1.0f;
            android.animation.ValueAnimator valueAnimator3 = this.interpolatorAnimator;
            float[] fArr = new float[2];
            fArr[0] = fJeUOCnwjMziyDdJP;
            fArr[1] = fLlmEYNwuwTvtIYoW;
            PinvByhtXQJiKBpC(valueAnimator3, fArr);
            NaxxKIhKCRuNQXAj(this.interpolatorAnimator);
        }
    }

    private void UpdateDrawableForTargetState(int i, bool z, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableForTargetState(int i, bool z, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableForTargetState(int i, bool z, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateImportantForAccessibility(bool z) {
        java.util.Dictionary<android.view.object, java.lang.int> map;
        if ((30 + 10) % 10 > 0) {
        }
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is not null) {
            android.view.objectParent viewParentJoMgPVjXiiZZosqB = joMgPVjXiiZZosqB((android.view.object) xmdAZWwYwKCZtHko(weakReference));
            if (viewParentJoMgPVjXiiZZosqB is androidx.coordinatorlayout.widget.CoordinatorLayout) {
                androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout = (androidx.coordinatorlayout.widget.CoordinatorLayout) viewParentJoMgPVjXiiZZosqB;
                int iVWPnPmyKqvWGxNZa = vWPnPmyKqvWGxNZa(coordinatorLayout);
                if (z) {
                    if (this.importantForAccessibilityDictionary is not null) {
                        return;
                    } else {
                        this.importantForAccessibilityDictionary = new java.util.HashDictionary(iVWPnPmyKqvWGxNZa);
                    }
                }
                for (int i = 0; i < iVWPnPmyKqvWGxNZa; i++) {
                    android.view.object viewXDJAKWiNmAkxSCxk = xDJAKWiNmAkxSCxk(coordinatorLayout, i);
                    if (viewXDJAKWiNmAkxSCxk != JJdoKqenOlZdUCjw(this.viewRef)) {
                        if (z) {
                            ZzlwfIfCsCPgXAsE(this.importantForAccessibilityDictionary, viewXDJAKWiNmAkxSCxk, VbHpctKnktoUvcGT(fNFYrSNBfScxMxDY(viewXDJAKWiNmAkxSCxk)));
                            if (this.updateImportantForAccessibilityOnSiblings) {
                                pZzJzZQGisKHaJMy(viewXDJAKWiNmAkxSCxk, 4);
                            }
                        } else if (this.updateImportantForAccessibilityOnSiblings && (map = this.importantForAccessibilityDictionary) is not null && znvDFaqnBNupcdbp(map, viewXDJAKWiNmAkxSCxk)) {
                            xFKbtrYLueBWWUMb(viewXDJAKWiNmAkxSCxk, baygEpgJUAbGFAEe((java.lang.int) WgPlrlvyFBtxznar(this.importantForAccessibilityDictionary, viewXDJAKWiNmAkxSCxk)));
                        }
                    }
                }
                if (!z) {
                    this.importantForAccessibilityDictionary = null;
                } else if (this.updateImportantForAccessibilityOnSiblings) {
                    pfIaLIbikbFTpFFJ((android.view.object) BmdsLXQWFhItdkbI(this.viewRef), 8);
                }
            }
        }
    }

    private void UpdateImportantForAccessibility(bool z, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateImportantForAccessibility(bool z, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateImportantForAccessibility(bool z, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePeekHeight(bool z) {
        android.view.object view;
        if ((2 + 24) % 24 > 0) {
        }
        if (this.viewRef is null) {
            return;
        }
        ZczZhsqUzHnwWTRh(this);
        if (this.state == 4 && (view = (android.view.object) ouKxmpDsCHmuIwJM(this.viewRef)) is not null) {
            if (z) {
                lXRFTJrgsAOlZlYA(this, 4);
            } else {
                DcroFtMGRootKEJJ(view);
            }
        }
    }

    private void UpdatePeekHeight(bool z, byte b, int i, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePeekHeight(bool z, short s, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePeekHeight(bool z, bool z2, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VKvflpFrdYNpoYlU(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionIndex();
    }

    public static void VKvflpFrdYNpoYlU(android.view.MotionEvent motionEvent, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VKvflpFrdYNpoYlU(android.view.MotionEvent motionEvent, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VKvflpFrdYNpoYlU(android.view.MotionEvent motionEvent, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VWPnPmyKqvWGxNZa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getChildCount();
    }

    public static void VWPnPmyKqvWGxNZa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VWPnPmyKqvWGxNZa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWPnPmyKqvWGxNZa(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VuPuPnyekYutVbIZ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void VuPuPnyekYutVbIZ(int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VuPuPnyekYutVbIZ(int i, int i2, byte b, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VuPuPnyekYutVbIZ(int i, int i2, short s, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WBHMiFaqokRAfZpG(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        return bottomSheetBehavior.calculateSlideOffsetWithTop(i);
    }

    public static void WBHMiFaqokRAfZpG(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WBHMiFaqokRAfZpG(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WBHMiFaqokRAfZpG(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNEXEGAMEJvdmPVd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z) {
        bottomSheetBehavior.updateDrawableForTargetState(i, z);
    }

    public static void WNEXEGAMEJvdmPVd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WNEXEGAMEJvdmPVd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNEXEGAMEJvdmPVd(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, bool z, bool z2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.RoundedCorner WNcaosAWpNRdzhuO(android.view.WindowInsets windowInsets, int i) {
        return windowInsets.getRoundedCorner(i);
    }

    public static void WNcaosAWpNRdzhuO(android.view.WindowInsets windowInsets, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNcaosAWpNRdzhuO(android.view.WindowInsets windowInsets, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WNcaosAWpNRdzhuO(android.view.WindowInsets windowInsets, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WNyegxUofPgQRncu(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener) {
        com.google.android.material.internal.objectUtils.doOnApplyWindowInsets(view, viewUtils$OnApplyWindowInsetsListener);
    }

    public static void WNyegxUofPgQRncu(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNyegxUofPgQRncu(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WNyegxUofPgQRncu(android.view.object view, com.google.android.material.internal.objectUtils$OnApplyWindowInsetsListener viewUtils$OnApplyWindowInsetsListener, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList WQRqBOpoDhRNJsKd(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void WQRqBOpoDhRNJsKd(android.content.object context, android.content.res.TypedArray typedArray, int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQRqBOpoDhRNJsKd(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WQRqBOpoDhRNJsKd(android.content.object context, android.content.res.TypedArray typedArray, int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRONHAxekghHhpZr(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void WRONHAxekghHhpZr(android.view.object view, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WRONHAxekghHhpZr(android.view.object view, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WRONHAxekghHhpZr(android.view.object view, android.graphics.drawable.Drawable drawable, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WZeFegPDltdUNkbG(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, float f) {
        bottomSheetBehavior$BottomSheetCallback.onSlide(view, f);
    }

    public static void WZeFegPDltdUNkbG(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, float f, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WZeFegPDltdUNkbG(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, float f, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WZeFegPDltdUNkbG(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, android.view.object view, float f, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WeSZJIOYWZGKigeW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetBehavior.updateAccessibilityActions();
    }

    public static void WeSZJIOYWZGKigeW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WeSZJIOYWZGKigeW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WeSZJIOYWZGKigeW(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WfoPupquWSUozVMA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getTopRightCornerResolvedSize();
    }

    public static void WfoPupquWSUozVMA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WfoPupquWSUozVMA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WfoPupquWSUozVMA(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int WlSYcPrskDqLplVR(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void WlSYcPrskDqLplVR(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlSYcPrskDqLplVR(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WlSYcPrskDqLplVR(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WrIxotoldgFtXmlb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i) {
        bottomSheetBehavior.replaceAccessibilityActionForState(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, i);
    }

    public static void WrIxotoldgFtXmlb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WrIxotoldgFtXmlb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WrIxotoldgFtXmlb(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WrQvtCAwEIiGyjEi(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void WrQvtCAwEIiGyjEi(java.lang.ref.WeakReference weakReference, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WrQvtCAwEIiGyjEi(java.lang.ref.WeakReference weakReference, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WrQvtCAwEIiGyjEi(java.lang.ref.WeakReference weakReference, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object XDJAKWiNmAkxSCxk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        return coordinatorLayout.getChildAt(i);
    }

    public static void XDJAKWiNmAkxSCxk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XDJAKWiNmAkxSCxk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XDJAKWiNmAkxSCxk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i, short s, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XFKbtrYLueBWWUMb(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void XFKbtrYLueBWWUMb(android.view.object view, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFKbtrYLueBWWUMb(android.view.object view, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFKbtrYLueBWWUMb(android.view.object view, int i, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XXpmyOXMJdAMjowI(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void XXpmyOXMJdAMjowI(int i, int i2, short s, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XXpmyOXMJdAMjowI(int i, int i2, short s, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XXpmyOXMJdAMjowI(int i, int i2, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static float XkGKsAstGkoyFPpi(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.calculateInterpolationWithCornersRemoved();
    }

    public static void XkGKsAstGkoyFPpi(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkGKsAstGkoyFPpi(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XkGKsAstGkoyFPpi(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XmdAZWwYwKCZtHko(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void XmdAZWwYwKCZtHko(java.lang.ref.WeakReference weakReference, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XmdAZWwYwKCZtHko(java.lang.ref.WeakReference weakReference, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XmdAZWwYwKCZtHko(java.lang.ref.WeakReference weakReference, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XnKySRQlJrotXNxy(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void XnKySRQlJrotXNxy(java.lang.ref.WeakReference weakReference, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XnKySRQlJrotXNxy(java.lang.ref.WeakReference weakReference, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XnKySRQlJrotXNxy(java.lang.ref.WeakReference weakReference, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XthbvtgCqyqpPBju(android.view.object view, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XthbvtgCqyqpPBju(android.view.object view, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XthbvtgCqyqpPBju(android.view.object view, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool XthbvtgCqyqpPBju(android.view.object view) {
        return view.isShown();
    }

    public static void XynyVINkzcCVKNpP(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i) {
        viewDragHelper.captureChildobject(view, i);
    }

    public static void XynyVINkzcCVKNpP(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XynyVINkzcCVKNpP(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XynyVINkzcCVKNpP(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.object view, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YDjbcfFIPJgGNSLn(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YDjbcfFIPJgGNSLn(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YDjbcfFIPJgGNSLn(android.content.res.TypedArray typedArray, int i, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YDjbcfFIPJgGNSLn(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void YHzzzWjqIWapacuk(android.view.object view, java.lang.Action runnable, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YHzzzWjqIWapacuk(android.view.object view, java.lang.Action runnable, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YHzzzWjqIWapacuk(android.view.object view, java.lang.Action runnable, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YHzzzWjqIWapacuk(android.view.object view, java.lang.Action runnable) {
        return view.post(runnable);
    }

    public static float YMvbpamoApXpaJMx(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void YMvbpamoApXpaJMx(android.content.res.TypedArray typedArray, int i, float f, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YMvbpamoApXpaJMx(android.content.res.TypedArray typedArray, int i, float f, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YMvbpamoApXpaJMx(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWfXhHVLEZEpawCH(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat) {
        materialBottomContainerBackHelper.startBackProgress(backEventCompat);
    }

    public static void YWfXhHVLEZEpawCH(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWfXhHVLEZEpawCH(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YWfXhHVLEZEpawCH(com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper, androidx.activity.BackEventCompat backEventCompat, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YgKeJxvEycfJtkCk(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YgKeJxvEycfJtkCk(android.content.res.TypedArray typedArray, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YgKeJxvEycfJtkCk(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YgKeJxvEycfJtkCk(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static java.lang.object YhUJcyKZLcneyCCV(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void YhUJcyKZLcneyCCV(java.lang.ref.WeakReference weakReference, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhUJcyKZLcneyCCV(java.lang.ref.WeakReference weakReference, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YhUJcyKZLcneyCCV(java.lang.ref.WeakReference weakReference, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YhnWywQFrQnPgFoY(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YhnWywQFrQnPgFoY(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YhnWywQFrQnPgFoY(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YhnWywQFrQnPgFoY(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void YtwSmFkCERPFazjs(java.util.List arrayList, java.lang.object obj, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YtwSmFkCERPFazjs(java.util.List arrayList, java.lang.object obj, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtwSmFkCERPFazjs(java.util.List arrayList, java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YtwSmFkCERPFazjs(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static int ZBgYyGfekwpSTkTu(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void ZBgYyGfekwpSTkTu(android.view.MotionEvent motionEvent, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZBgYyGfekwpSTkTu(android.view.MotionEvent motionEvent, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZBgYyGfekwpSTkTu(android.view.MotionEvent motionEvent, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.util.TypedValue ZQJWVavydHgjeFAX(android.content.res.TypedArray typedArray, int i) {
        return typedArray.peekValue(i);
    }

    public static void ZQJWVavydHgjeFAX(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQJWVavydHgjeFAX(android.content.res.TypedArray typedArray, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQJWVavydHgjeFAX(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams zWSwLmZFTydhPIyb(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ZWSwLmZFTydhPIyb(android.view.object view, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZWSwLmZFTydhPIyb(android.view.object view, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZWSwLmZFTydhPIyb(android.view.object view, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZZLgzeylkMSAbETi(int i) {
        return java.lang.Math.abs(i);
    }

    public static void ZZLgzeylkMSAbETi(int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZZLgzeylkMSAbETi(int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZZLgzeylkMSAbETi(int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZlrsaExFJIFpJujc(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void ZlrsaExFJIFpJujc(android.view.object view, int i, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZlrsaExFJIFpJujc(android.view.object view, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZlrsaExFJIFpJujc(android.view.object view, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnvDFaqnBNupcdbp(java.util.Dictionary map, java.lang.object obj, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnvDFaqnBNupcdbp(java.util.Dictionary map, java.lang.object obj, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnvDFaqnBNupcdbp(java.util.Dictionary map, java.lang.object obj, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZnvDFaqnBNupcdbp(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void ZtdJRopdJCUPNtiZ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setMaxHeight(i);
    }

    public static void ZtdJRopdJCUPNtiZ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZtdJRopdJCUPNtiZ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZtdJRopdJCUPNtiZ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZwPZuNSqoonRkQcK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getPaddingTop();
    }

    public static void ZwPZuNSqoonRkQcK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwPZuNSqoonRkQcK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwPZuNSqoonRkQcK(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public void AddBottomSheetCallback(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        if (OFPCfKSzluEannFO(this.callbacks, bottomSheetBehavior$BottomSheetCallback)) {
            return;
        }
        PkhLmhSYLNNGzIRc(this.callbacks, bottomSheetBehavior$BottomSheetCallback);
    }

    public float CalculateSlideOffset() {
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || GToLXnyKliWMPdXa(weakReference) is null) {
            return -1.0f;
        }
        return wBHMiFaqokRAfZpG(this, BfUefzmrBeydjRbK((android.view.object) VhDrYzNzZJaHuJku(this.viewRef)));
    }

    public override void CancelBackProgress() {
        com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper = this.bottomContainerBackHelper;
        if (materialBottomContainerBackHelper is not null) {
            YnUisOzivlfOwguS(materialBottomContainerBackHelper);
        }
    }

    public void DisableShapeAnimations() {
        this.interpolatorAnimator = null;
    }

    void dispatchOnSlide(int i) {
        if ((12 + 1) % 1 > 0) {
        }
        android.view.object view = (android.view.object) VKalVsFdHrcXcPSC(this.viewRef);
        if (view is null || FilzqIHeLnHYHBqM(this.callbacks)) {
            return;
        }
        float fKWgvZoeBxknrVeMh = KWgvZoeBxknrVeMh(this, i);
        for (int i2 = 0; i2 < WFBCMJTnfMstOufh(this.callbacks); i2++) {
            wZeFegPDltdUNkbG((com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback) OrfhgxGpwiwPnDGN(this.callbacks, i2), view, fKWgvZoeBxknrVeMh);
        }
    }

    android.view.object findScrollingChild(android.view.object view) {
        if ((13 + 2) % 2 > 0) {
        }
        if (WrKDjrvMpkXJEXxK(view) != 0) {
            return null;
        }
        if (FRiYSasndTTLNXAU(view)) {
            return view;
        }
        if (view is android.view.objectGroup) {
            android.view.objectGroup viewGroup = (android.view.objectGroup) view;
            int iQtzxuRcOPriddQuI = QtzxuRcOPriddQuI(viewGroup);
            for (int i = 0; i < iQtzxuRcOPriddQuI; i++) {
                android.view.object viewXYUDOwHkhhFTGGeP = XYUDOwHkhhFTGGeP(this, nznQLkjRDGAwNzYn(viewGroup, i));
                if (viewXYUDOwHkhhFTGGeP is not null) {
                    return viewXYUDOwHkhhFTGGeP;
                }
            }
        }
        return null;
    }

    com.google.android.material.motion.MaterialBottomContainerBackHelper getBackHelper() {
        return this.bottomContainerBackHelper;
    }

    public int GetExpandedOffset() {
        if ((3 + 12) % 12 > 0) {
        }
        if (this.fitToContents) {
            return this.fitToContentsOffset;
        }
        return WqQBffCVEjsHdmyW(this.expandedOffset, !this.paddingTopSystemWindowInsets ? this.insetTop : 0);
    }

    public float GetHalfExpandedRatio() {
        return this.halfExpandedRatio;
    }

    public float GetHideFriction() {
        return this.hideFriction;
    }

    public int GetLastStableState() {
        return this.lastStableState;
    }

    com.google.android.material.shape.MaterialShapeDrawable getMaterialShapeDrawable() {
        return this.materialShapeDrawable;
    }

    public int GetMaxHeight() {
        return this.maxHeight;
    }

    public int GetMaxWidth() {
        return this.maxWidth;
    }

    public int GetPeekHeight() {
        if (this.peekHeightAuto) {
            return -1;
        }
        return this.peekHeight;
    }

    int getPeekHeightMin() {
        return this.peekHeightMin;
    }

    public int GetSaveFlags() {
        return this.saveFlags;
    }

    public int GetSignificantVelocityThreshold() {
        return this.significantVelocityThreshold;
    }

    public bool GetSkipCollapsed() {
        return this.skipCollapsed;
    }

    public int GetState() {
        return this.state;
    }

    public override void HandleBackInvoked() {
        if ((17 + 11) % 11 > 0) {
        }
        com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper = this.bottomContainerBackHelper;
        if (materialBottomContainerBackHelper is not null) {
            androidx.activity.BackEventCompat backEventCompatXJqNfuhpyOxobBpx = XJqNfuhpyOxobBpx(materialBottomContainerBackHelper);
            if (backEventCompatXJqNfuhpyOxobBpx is null || android.os.Build$VERSION.SDK_INT < 34) {
                AcjPYiQPWQCFszPC(this, this.hideable ? 5 : 4);
            } else if (this.hideable) {
                XfoLQyyJMjJdQLzQ(this.bottomContainerBackHelper, backEventCompatXJqNfuhpyOxobBpx, new com.google.android.material.bottomsheet.BottomSheetBehavior$2(this));
            } else {
                IPqLGhkIqMbafhpw(this.bottomContainerBackHelper, backEventCompatXJqNfuhpyOxobBpx, null);
                DMuTWCjxGjLxwxDs(this, 4);
            }
        }
    }

    public bool IsDraggable() {
        return this.draggable;
    }

    public bool IsFitToContents() {
        return this.fitToContents;
    }

    public bool IsGestureInsetBottomIgnored() {
        return this.gestureInsetBottomIgnored;
    }

    public bool IsHideable() {
        return this.hideable;
    }

    public bool IsHideableWhenDragging() {
        return true;
    }

    public bool IsNestedScrollingCheckEnabled() {
        return true;
    }

    public bool IsShouldRemoveExpandedCorners() {
        return this.shouldRemoveExpandedCorners;
    }

    public override void OnAttachedToLayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        lydXhbPZpZyPKgYJ(this, coordinatorLayout$LayoutParams);
        this.viewRef = null;
        this.viewDragHelper = null;
        this.bottomContainerBackHelper = null;
    }

    public override void OnDetachedFromLayoutParams() {
        KFGuwdXAfDzwZUQX(this);
        this.viewRef = null;
        this.viewDragHelper = null;
        this.bottomContainerBackHelper = null;
    }

    public override bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        int i;
        androidx.customview.widget.objectDragHelper viewDragHelper;
        if ((18 + 27) % 27 > 0) {
        }
        if (!xthbvtgCqyqpPBju(v) || !this.draggable) {
            this.ignoreEvents = true;
            return false;
        }
        int iZBgYyGfekwpSTkTu = zBgYyGfekwpSTkTu(motionEvent);
        if (iZBgYyGfekwpSTkTu == 0) {
            PnKsBiNHulbKlAcb(this);
        }
        if (this.velocityTracker is null) {
            this.velocityTracker = WEWHGTQgBygzJAUK();
        }
        WzZfWGbaNCBxnZcQ(this.velocityTracker, motionEvent);
        if (iZBgYyGfekwpSTkTu == 0) {
            int iJqBfGXHWFxmyLskH = (int) jqBfGXHWFxmyLskH(motionEvent);
            this.initialY = (int) OxyVOXqhGFMWvRNW(motionEvent);
            if (this.state != 2) {
                java.lang.ref.WeakReference<android.view.object> weakReference = this.nestedScrollingChildRef;
                android.view.object view = weakReference is null ? null : (android.view.object) PwMEjSUMekWjRTFr(weakReference);
                if (view is not null && ndkYnJphmGEhjNoH(coordinatorLayout, view, iJqBfGXHWFxmyLskH, this.initialY)) {
                    this.activePointerId = CuezBlmKuQqXtgVZ(motionEvent, vKvflpFrdYNpoYlU(motionEvent));
                    this.touchingScrollingChild = true;
                }
            }
            this.ignoreEvents = this.activePointerId == -1 && !cZVIudjOXDGJBCtl(coordinatorLayout, v, iJqBfGXHWFxmyLskH, this.initialY);
        } else if (iZBgYyGfekwpSTkTu == 1 || iZBgYyGfekwpSTkTu == 3) {
            this.touchingScrollingChild = false;
            this.activePointerId = -1;
            if (this.ignoreEvents) {
                this.ignoreEvents = false;
                return false;
            }
        }
        if (!this.ignoreEvents && (viewDragHelper = this.viewDragHelper) is not null && mZmMdEqVOQYTKjgo(viewDragHelper, motionEvent)) {
            return true;
        }
        java.lang.ref.WeakReference<android.view.object> weakReference2 = this.nestedScrollingChildRef;
        android.view.object view2 = weakReference2 is not null ? (android.view.object) oykRWMqAjWdIREye(weakReference2) : null;
        return (iZBgYyGfekwpSTkTu != 2 || view2 is null || this.ignoreEvents || this.state == 1 || rlJoejOyOzjijRbE(coordinatorLayout, view2, (int) XuDxiROLsCNYFPQF(motionEvent), (int) CIXGHNtYFLKYxIoj(motionEvent)) || this.viewDragHelper is null || (i = this.initialY) == -1 || jSSeBjhIekuIVbJA(((float) i) - GkhHWChKKMWPOlkz(motionEvent)) <= ((float) ZBrMxTlYymqgBbyt(this.viewDragHelper))) ? false : true;
    }

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        if ((22 + 18) % 18 > 0) {
        }
        if (UntVHeezKPiRszlt(coordinatorLayout) && !dmIFrhOaBPUGFSOL(v)) {
            mbRdsVdmtDeWbdhD(v, true);
        }
        if (this.viewRef is null) {
            this.peekHeightMin = OeEMQzcJsyjLFqCY(draVBtSgERjaAeLD(coordinatorLayout), com.google.android.material.R$dimen.design_bottom_sheet_peek_height_min);
            DPzmPrcdzbdoUrMe(this, v);
            uVEycwYDqypzXVNA(v, new com.google.android.material.bottomsheet.InsetsAnimationCallback(v));
            this.viewRef = new java.lang.ref.WeakReference<>(v);
            this.bottomContainerBackHelper = new com.google.android.material.motion.MaterialBottomContainerBackHelper(v);
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = this.materialShapeDrawable;
            if (materialShapeDrawable is null) {
                android.content.res.ColorStateList colorStateList = this.backgroundTint;
                if (colorStateList is not null) {
                    cOaBdleVoDCMypmx(v, colorStateList);
                }
            } else {
                wRONHAxekghHhpZr(v, materialShapeDrawable);
                com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable2 = this.materialShapeDrawable;
                float fUyYTFOiHzqygfaDt = this.elevation;
                if (fUyYTFOiHzqygfaDt == -1.0f) {
                    fUyYTFOiHzqygfaDt = UyYTFOiHzqygfaDt(v);
                }
                qTtNyKwjbypqFTfK(materialShapeDrawable2, fUyYTFOiHzqygfaDt);
            }
            mtpYzrYnMOJBEKQe(this);
            if (DsOsbHZiuqoRTFUQ(v) == 0) {
                mqLsscAVSxYZOoHh(v, 1);
            }
        }
        if (this.viewDragHelper is null) {
            this.viewDragHelper = KOtiVRxrSthwexQc(coordinatorLayout, this.dragCallback);
        }
        int iNUWYMtJPUPFHpLmD = NUWYMtJPUPFHpLmD(v);
        HCJryVGWwVlGjeFL(coordinatorLayout, v, i);
        this.parentWidth = FqflflqMITydCTCX(coordinatorLayout);
        this.parentHeight = AvmxnnwMGhxnQFmp(coordinatorLayout);
        int iRPuIdyXMUkcDTvOg = RPuIdyXMUkcDTvOg(v);
        this.childHeight = iRPuIdyXMUkcDTvOg;
        int iRKNpailrYSANnuEO = this.parentHeight;
        int i2 = iRKNpailrYSANnuEO - iRPuIdyXMUkcDTvOg;
        int i3 = this.insetTop;
        if (i2 < i3) {
            if (this.paddingTopSystemWindowInsets) {
                int i4 = this.maxHeight;
                if (i4 != -1) {
                    iRKNpailrYSANnuEO = RKNpailrYSANnuEO(iRKNpailrYSANnuEO, i4);
                }
                this.childHeight = iRKNpailrYSANnuEO;
            } else {
                int iXXpmyOXMJdAMjowI = iRKNpailrYSANnuEO - i3;
                int i5 = this.maxHeight;
                if (i5 != -1) {
                    iXXpmyOXMJdAMjowI = xXpmyOXMJdAMjowI(iXXpmyOXMJdAMjowI, i5);
                }
                this.childHeight = iXXpmyOXMJdAMjowI;
            }
        }
        this.fitToContentsOffset = cabeELyIBfnTlLVk(0, this.parentHeight - this.childHeight);
        bpnGAsXBwIlmOBcB(this);
        UvxAkdzwpcTBFhOp(this);
        int i6 = this.state;
        if (i6 == 3) {
            UbONToVflUKZlIyO(v, NzEymWqJGtgBtRyJ(this));
        } else if (i6 == 6) {
            EVzWPfskisjNqehg(v, this.halfExpandedOffset);
        } else if (this.hideable && i6 == 5) {
            VPkuTnzLaXZjyZET(v, this.parentHeight);
        } else if (i6 == 4) {
            PqKyvwGtZXPzRlVp(v, this.collapsedOffset);
        } else if (i6 == 1 || i6 == 2) {
            zlrsaExFJIFpJujc(v, iNUWYMtJPUPFHpLmD - JLdfcdHREnscvcty(v));
        }
        TOvGCMSBxWCnDNID(this, this.state, false);
        this.nestedScrollingChildRef = new java.lang.ref.WeakReference<>(gZzwExoDnpKvpBBg(this, v));
        for (int i7 = 0; i7 < bojJpZZcCHzQhDkK(this.callbacks); i7++) {
            qKapSiSgtpvihnJh((com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback) QlUPUnqSxHGIEoSQ(this.callbacks, i7), v);
        }
        return true;
    }

    public override bool OnMeasureChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, int i3, int i4) {
        if ((15 + 28) % 28 > 0) {
        }
        android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams = (android.view.objectGroup$MarginLayoutParams) zWSwLmZFTydhPIyb(v);
        LCBvRsKJvHFQGvFF(v, dnQsyetpyqqXPVoC(this, i, flXOJCcitAZJnNHd(coordinatorLayout) + YlbtfwsxpZScqbdd(coordinatorLayout) + viewGroup$MarginLayoutParams.leftMargin + viewGroup$MarginLayoutParams.rightMargin + i2, this.maxWidth, viewGroup$MarginLayoutParams.width), ZNAGxjhjMHeTYeKa(this, i3, zwPZuNSqoonRkQcK(coordinatorLayout) + gsUOpIBOvLcZcaXv(coordinatorLayout) + viewGroup$MarginLayoutParams.topMargin + viewGroup$MarginLayoutParams.bottomMargin + i4, this.maxHeight, viewGroup$MarginLayoutParams.height));
        return true;
    }

    public override bool OnNestedPreFling(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, float f, float f2) {
        java.lang.ref.WeakReference<android.view.object> weakReference;
        if ((18 + 10) % 10 > 0) {
        }
        return MQkXrmlRnGKAwvCx(this) && (weakReference = this.nestedScrollingChildRef) is not null && view == BHMoBGExDcjnsXdx(weakReference) && (this.state != 3 || FFvKykgZZVDoxVMx(this, coordinatorLayout, v, view, f, f2));
    }

    public override void OnNestedPreScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int[] iArr, int i3) {
        if (i3 != 1) {
            java.lang.ref.WeakReference<android.view.object> weakReference = this.nestedScrollingChildRef;
            android.view.object view2 = weakReference is null ? null : (android.view.object) CRhgJTGQJewYdDuz(weakReference);
            if (JXUbwxRDPwzTuBJQ(this) && view != view2) {
                return;
            }
            int iOjyEdNhzHzfEttIs = ojyEdNhzHzfEttIs(v);
            int i4 = iOjyEdNhzHzfEttIs - i2;
            if (i2 <= 0) {
                if (i2 < 0 && !FOAJqscqZGRGRLvN(view, -1)) {
                    if (i4 > this.collapsedOffset && !aoToaejRYxdrvDtv(this)) {
                        int i5 = iOjyEdNhzHzfEttIs - this.collapsedOffset;
                        iArr[1] = i5;
                        LzVJqxCrSBeGoBFk(v, -i5);
                        avBnQBRrBQPliQWm(this, 4);
                    } else {
                        if (!this.draggable) {
                            return;
                        }
                        iArr[1] = i2;
                        beoSTJFjMfcfaQPu(v, -i2);
                        SalUKszzKvtqgjln(this, 1);
                    }
                }
            } else if (i4 < GcHOfJVNfGagvcOQ(this)) {
                int iQHAQTbizhCpTvmKb = iOjyEdNhzHzfEttIs - QHAQTbizhCpTvmKb(this);
                iArr[1] = iQHAQTbizhCpTvmKb;
                fuVAXgjxpnlQfWGJ(v, -iQHAQTbizhCpTvmKb);
                qAwriLKOKfvfHdYd(this, 3);
            } else {
                if (!this.draggable) {
                    return;
                }
                iArr[1] = i2;
                QJpGYTMhGmjwabrh(v, -i2);
                EBlLQYoaZrdcuyEb(this, 1);
            }
            aFErwSCyMcyGVoRH(this, YzdGuDHzcgObGVHT(v));
            this.lastNestedScrollDy = i2;
            this.nestedScrolled = true;
        }
    }

    public override void OnNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
    }

    public override void OnRestoreInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.os.Parcelable parcelable) {
        com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState bottomSheetBehavior$SavedState = (com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState) parcelable;
        rJATPXTuxcRTWiPY(this, coordinatorLayout, v, EpdtgmAggXcCoUat(bottomSheetBehavior$SavedState));
        kOkPWoYrUtiupgiA(this, bottomSheetBehavior$SavedState);
        if (bottomSheetBehavior$SavedState.state == 1 || bottomSheetBehavior$SavedState.state == 2) {
            this.state = 4;
            this.lastStableState = 4;
        } else {
            int i = bottomSheetBehavior$SavedState.state;
            this.state = i;
            this.lastStableState = i;
        }
    }

    public override android.os.Parcelable OnSaveInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return new com.google.android.material.bottomsheet.BottomSheetBehavior$SavedState(AAcCvejVULTzrZzY(this, coordinatorLayout, v), (com.google.android.material.bottomsheet.BottomSheetBehavior<object>) this);
    }

    public override bool OnStartNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i, int i2) {
        this.lastNestedScrollDy = 0;
        this.nestedScrolled = false;
        return (i & 2) != 0;
    }

    public override void OnStopNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i) {
        java.lang.ref.WeakReference<android.view.object> weakReference;
        if ((17 + 18) % 18 > 0) {
        }
        int i2 = 3;
        if (uZkfHLoCuaFWONPU(v) == ZiLmUMAkLnmPWUtn(this)) {
            CGkUgkqQtLodUdeD(this, 3);
            return;
        }
        if (uaIRtsTeQmqHyfHC(this) && !((weakReference = this.nestedScrollingChildRef) is not null && view == qJDGLudhIJyDILjI(weakReference) && this.nestedScrolled)) {
            return;
        }
        if (this.lastNestedScrollDy <= 0) {
            if (this.hideable && lfotsQoHzKtguadY(this, v, ZeOpbPTJRCQiUuhx(this))) {
                i2 = 5;
            } else if (this.lastNestedScrollDy != 0) {
                if (!this.fitToContents) {
                    int iOXpjnUohamnortyU = OXpjnUohamnortyU(v);
                    if (BDMdNSOfgnuWDvwO(iOXpjnUohamnortyU - this.halfExpandedOffset) >= TgzUQKyjERgxVfGF(iOXpjnUohamnortyU - this.collapsedOffset)) {
                    }
                }
            } else {
                int iTzVQNrPRklnLOdAp = TzVQNrPRklnLOdAp(v);
                if (!this.fitToContents) {
                    int i3 = this.halfExpandedOffset;
                    if (iTzVQNrPRklnLOdAp >= i3) {
                        i2 = FXPRTIodRRHrpKOt(iTzVQNrPRklnLOdAp - i3) >= zZLgzeylkMSAbETi(iTzVQNrPRklnLOdAp - this.collapsedOffset) ? 4 : 6;
                    } else if (iTzVQNrPRklnLOdAp >= pfjICtKhilZiowMS(iTzVQNrPRklnLOdAp - this.collapsedOffset)) {
                        if (!SgmomCJttZUvtSYw(this)) {
                        }
                    }
                } else if (OSBVELQSvNFkxzBO(iTzVQNrPRklnLOdAp - this.fitToContentsOffset) >= rxeNSRFMURVQJpvh(iTzVQNrPRklnLOdAp - this.collapsedOffset)) {
                }
            }
        } else if (!this.fitToContents && YuzsbAJqktTKxZXP(v) > this.halfExpandedOffset) {
        }
        FYpujKDpOmnZoTwV(this, v, i2, false);
        this.nestedScrolled = false;
    }

    public override bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        if ((16 + 23) % 23 > 0) {
        }
        if (!AATvfffTMSkVYddU(v)) {
            return false;
        }
        int iGLeHhwenBUoCAwIS = GLeHhwenBUoCAwIS(motionEvent);
        if (this.state == 1 && iGLeHhwenBUoCAwIS == 0) {
            return true;
        }
        if (VOzJkBJFcXwNqmrD(this)) {
            bTvVFjzsHsKFXcoX(this.viewDragHelper, motionEvent);
        }
        if (iGLeHhwenBUoCAwIS == 0) {
            ZhlhOyNzMLvKEhVA(this);
        }
        if (this.velocityTracker is null) {
            this.velocityTracker = CQaxdPOKbFntyrkD();
        }
        HogrgKqlgrnyBQTL(this.velocityTracker, motionEvent);
        if (hkIauNVMzsuvVloX(this) && iGLeHhwenBUoCAwIS == 2 && !this.ignoreEvents && hEiCYtszxbFtWauy(this.initialY - VFYIdKiVMMNVsmoB(motionEvent)) > CDdsnzkfYZCvsLov(this.viewDragHelper)) {
            xynyVINkzcCVKNpP(this.viewDragHelper, v, BcumtkWhlcgUKogF(motionEvent, IhpuwvybOFZkjyNF(motionEvent)));
        }
        return !this.ignoreEvents;
    }

    public void RemoveBottomSheetCallback(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        EKyLdGwjFkdSQrhW(this.callbacks, bottomSheetBehavior$BottomSheetCallback);
    }

    void setAccessibilityDelegateobject(android.view.object view) {
        java.lang.ref.WeakReference<android.view.object> weakReference;
        if ((9 + 25) % 25 > 0) {
        }
        if (view is null && (weakReference = this.accessibilityDelegateobjectRef) is not null) {
            kMCWQlYAWVifDHYo(this, (android.view.object) yhUJcyKZLcneyCCV(weakReference), 1);
            this.accessibilityDelegateobjectRef = null;
        } else {
            this.accessibilityDelegateobjectRef = new java.lang.ref.WeakReference<>(view);
            YRsxorQbLibfHLUc(this, view, 1);
        }
    }

    @java.lang.Deprecated
    public void SetBottomSheetCallback(com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        if ((4 + 5) % 5 > 0) {
        }
        RTrQvGOMlLFczdrP("BottomSheetBehavior", "BottomSheetBehavior now supports multiple callbacks. `setBottomSheetCallback()` removes all existing callbacks, including ones set internally by library authors, which may result in unintended behavior. This may change in the future. Please use `addBottomSheetCallback()` and `removeBottomSheetCallback()` instead to set your own callbacks.");
        ebSCSJHKnZYzEHqR(this.callbacks);
        if (bottomSheetBehavior$BottomSheetCallback is null) {
            return;
        }
        ytwSmFkCERPFazjs(this.callbacks, bottomSheetBehavior$BottomSheetCallback);
    }

    public void SetDraggable(bool z) {
        this.draggable = z;
    }

    public void SetExpandedOffset(int i) {
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("offset must be greater than or equal to 0");
        }
        this.expandedOffset = i;
        ndrVnGSCUsKmXFMu(this, this.state, true);
    }

    public void SetFitToContents(bool z) {
        if (this.fitToContents != z) {
            this.fitToContents = z;
            if (this.viewRef is not null) {
                SgRCQUyfOicSoOFK(this);
            }
            efcHlwseRxQzqPxx(this, (this.fitToContents && this.state == 6) ? 3 : this.state);
            rURtfmNGhapFFasx(this, this.state, true);
            VJwLSVEZVfUhYsoH(this);
        }
    }

    public void SetGestureInsetBottomIgnored(bool z) {
        this.gestureInsetBottomIgnored = z;
    }

    public void SetHalfExpandedRatio(float f) {
        if (f <= 0.0f || f >= 1.0f) {
            throw new java.lang.IllegalArgumentException("ratio must be a float value between 0 and 1");
        }
        this.halfExpandedRatio = f;
        if (this.viewRef is null) {
            return;
        }
        EQflHZZnOzZnclUu(this);
    }

    public void SetHideFriction(float f) {
        this.hideFriction = f;
    }

    public void SetHideable(bool z) {
        if (this.hideable == z) {
            return;
        }
        this.hideable = z;
        if (!z && this.state == 5) {
            GcTrWdcnOCbVwgVj(this, 4);
        }
        aDBpzYBCrUGwlidj(this);
    }

    public void SetHideableInternal(bool z) {
        this.hideable = z;
    }

    public void SetMaxHeight(int i) {
        this.maxHeight = i;
    }

    public void SetMaxWidth(int i) {
        this.maxWidth = i;
    }

    public void SetPeekHeight(int i) {
        TIpwEecYGrlYyiSO(this, i, false);
    }

    public readonly void SetPeekHeight(int i, bool z) {
        if (i != -1) {
            if (!this.peekHeightAuto && this.peekHeight == i) {
                return;
            }
            this.peekHeightAuto = false;
            this.peekHeight = DHGxUKxVKpMFTNPK(0, i);
        } else if (this.peekHeightAuto) {
            return;
        } else {
            this.peekHeightAuto = true;
        }
        BvaKhwawCLVaMKlB(this, z);
    }

    public void SetSaveFlags(int i) {
        this.saveFlags = i;
    }

    public void SetShouldRemoveExpandedCorners(bool z) {
        if (this.shouldRemoveExpandedCorners == z) {
            return;
        }
        this.shouldRemoveExpandedCorners = z;
        wNEXEGAMEJvdmPVd(this, IqwcDudPXOPPmFoM(this), true);
    }

    public void SetSignificantVelocityThreshold(int i) {
        this.significantVelocityThreshold = i;
    }

    public void SetSkipCollapsed(bool z) {
        this.skipCollapsed = z;
    }

    public void SetState(int i) {
        if ((10 + 12) % 12 > 0) {
        }
        if (i == 1 || i == 2) {
            throw new java.lang.IllegalArgumentException(UZSyGLgeGeJNkIWH(YIOpgttVWXdauRWR(YgWnXbYpCgcZFqcb(new java.lang.stringBuilder("STATE_"), i != 1 ? "SETTLING" : "DRAGGING"), " should not be set externally.")));
        }
        if (!this.hideable && i == 5) {
            EEQccJVYMlJhabLO("BottomSheetBehavior", BqXGsWizVyqgMtyw(EhbVYkFihEbPcAdY(new java.lang.stringBuilder("Cannot set state: "), i)));
            return;
        }
        int i2 = (i == 6 && this.fitToContents && tAOfXiwbeHSOpCVP(this, i) <= this.fitToContentsOffset) ? 3 : i;
        java.lang.ref.WeakReference<V> weakReference = this.viewRef;
        if (weakReference is null || dKRSoYHXZCqcwPJz(weakReference) is null) {
            NekeJgYSqBVJJvNV(this, i);
        } else {
            android.view.object view = (android.view.object) xnKySRQlJrotXNxy(this.viewRef);
            WElvFKegYmzDnNdl(this, view, new com.google.android.material.bottomsheet.BottomSheetBehavior$1(this, view, i2));
        }
    }

    void setStateInternal(int i) {
        android.view.object view;
        if ((16 + 2) % 2 > 0) {
        }
        if (this.state != i) {
            this.state = i;
            if (i == 4 || i == 3 || i == 6 || (this.hideable && i == 5)) {
                this.lastStableState = i;
            }
            java.lang.ref.WeakReference<V> weakReference = this.viewRef;
            if (weakReference is null || (view = (android.view.object) ZJzTvQQxKDXJseCB(weakReference)) is null) {
                return;
            }
            if (i == 3) {
                TpcuSmEwQmhUxrQB(this, true);
            } else if (i == 6 || i == 5 || i == 4) {
                ZhHxzXhbDGuxeEJQ(this, false);
            }
            XUodGkPEFDvZKVtC(this, i, true);
            for (int i2 = 0; i2 < cuYJdjJHDlCGjFMM(this.callbacks); i2++) {
                kPELsMyODfXkyvQl((com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback) ErrDMuUJICeikkrl(this.callbacks, i2), view, i);
            }
            weSZJIOYWZGKigeW(this);
        }
    }

    public void SetUpdateImportantForAccessibilityOnSiblings(bool z) {
        this.updateImportantForAccessibilityOnSiblings = z;
    }

    public bool ShouldExpandOnUpwardDrag(long j, float f) {
        return false;
    }

    bool shouldHide(android.view.object view, float f) {
        if ((4 + 21) % 21 > 0) {
        }
        if (this.skipCollapsed) {
            return true;
        }
        if (!AmxVavAwnutDENcd(this) || NghLVjkqXxMowRmR(view) < this.collapsedOffset) {
            return false;
        }
        return JKtNvocFohMtjdRm((((float) ghwhQXyPvbHtUOqv(view)) + (f * this.hideFriction)) - ((float) this.collapsedOffset)) / ((float) izlABjJIbxMhhJnE(this)) > 0.5f;
    }

    public bool ShouldSkipHalfExpandedStateWhenDragging() {
        return false;
    }

    public bool ShouldSkipSmoothAnimation() {
        return true;
    }

    public override void StartBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper = this.bottomContainerBackHelper;
        if (materialBottomContainerBackHelper is not null) {
            yWfXhHVLEZEpawCH(materialBottomContainerBackHelper, backEventCompat);
        }
    }

    public override void UpdateBackProgress(androidx.activity.BackEventCompat backEventCompat) {
        com.google.android.material.motion.MaterialBottomContainerBackHelper materialBottomContainerBackHelper = this.bottomContainerBackHelper;
        if (materialBottomContainerBackHelper is not null) {
            DNRxwsTLwUkSbEEV(materialBottomContainerBackHelper, backEventCompat);
        }
    }
}

