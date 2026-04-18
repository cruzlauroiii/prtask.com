namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject : android.view.objectGroup : androidx.core.view.Scrollingobject, androidx.core.view.NestedScrollingChild2, androidx.core.view.NestedScrollingChild3 {
    static readonly bool ALLOW_SIZE_IN_UNSPECIFIED_SPEC;
    static readonly bool ALLOW_THREAD_GAP_WORK;
    private static readonly float DECELERATION_RATE;
    static readonly int DEFAULT_ORIENTATION = 1;
    static readonly bool DISPATCH_TEMP_DETACH = false;
    private static readonly float FLING_DESTRETCH_FACTOR = 4.0f;
    static readonly bool FORCE_INVALIDATE_DISPLAY_LIST;
    static readonly long FOREVER_NS = long.MAX_VALUE;
    public static readonly int HORIZONTAL = 0;
    private static readonly float INFLEXION = 0.35f;
    private static readonly int INVALID_POINTER = -1;
    public static readonly int INVALID_TYPE = -1;
    private static readonly java.lang.Class<object>[] LAYOUT_MANAGER_CONSTRUCTOR_SIGNATURE;
    static readonly java.lang.string LOW_RES_ROTARY_ENCODER_FEATURE = "android.hardware.rotaryencoder.lowres";
    static readonly int MAX_SCROLL_DURATION = 2000;
    private static readonly int[] NESTED_SCROLLING_ATTRS;
    public static readonly long NO_ID = -1;
    public static readonly int NO_POSITION = -1;
    private static readonly float SCROLL_FRICTION = 0.015f;
    public static readonly int SCROLL_STATE_DRAGGING = 1;
    public static readonly int SCROLL_STATE_IDLE = 0;
    public static readonly int SCROLL_STATE_SETTLING = 2;
    static readonly java.lang.string TAG = "Recyclerobject";
    public static readonly int TOUCH_SLOP_DEFAULT = 0;
    public static readonly int TOUCH_SLOP_PAGING = 1;
    static readonly java.lang.string TRACE_CREATE_VIEW_TAG = "RV Createobject";
    private static readonly java.lang.string TRACE_HANDLE_ADAPTER_UPDATES_TAG = "RV PartialInvalidate";
    private static readonly java.lang.string TRACE_ON_DATA_SET_CHANGE_LAYOUT_TAG = "RV FullInvalidate";
    private static readonly java.lang.string TRACE_ON_LAYOUT_TAG = "RV OnLayout";
    static readonly java.lang.string TRACE_PREFETCH_TAG = "RV Prefetch";
    static readonly java.lang.string TRACE_SCROLL_TAG = "RV Scroll";
    public static readonly int UNDEFINED_DURATION = int.MIN_VALUE;
    static readonly bool VERBOSE_TRACING = false;
    public static readonly int VERTICAL = 1;
    static bool sDebugAssertionsEnabled;
    static readonly androidx.recyclerview.widget.Recyclerobject$StretchEdgeEffectFactory sDefaultEdgeEffectFactory;
    static readonly android.view.animation.Interpolator sQuinticInterpolator;
    static bool sVerboseConsolegingEnabled;
    androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate mAccessibilityDelegate;
    private readonly android.view.accessibility.AccessibilityManager mAccessibilityManager;
    androidx.recyclerview.widget.Recyclerobject$Adapter mAdapter;
    androidx.recyclerview.widget.AdapterHelper mAdapterHelper;
    bool mAdapterUpdateDuringMeasure;
    private android.widget.EdgeEffect mBottomGlow;
    private androidx.recyclerview.widget.Recyclerobject$ChildDrawingOrderCallback mChildDrawingOrderCallback;
    androidx.recyclerview.widget.ChildHelper mChildHelper;
    bool mClipToPadding;
    bool mDataHashSetHasChangedAfterLayout;
    androidx.core.view.DifferentialMotionFlingController mDifferentialMotionFlingController;
    private readonly androidx.core.view.DifferentialMotionFlingTarget mDifferentialMotionFlingTarget;
    bool mDispatchItemsChangedEvent;
    private int mDispatchScrollCounter;
    private int mEatenAccessibilityChangeFlags;
    private androidx.recyclerview.widget.Recyclerobject$EdgeEffectFactory mEdgeEffectFactory;
    bool mEnableFastScroller;
    bool mFirstLayoutComplete;
    androidx.recyclerview.widget.GapWorker mGapWorker;
    bool mHasFixedSize;
    private bool mIgnoreMotionEventTillDown;
    private int mInitialTouchX;
    private int mInitialTouchY;
    private int mInterceptRequestLayoutDepth;
    private androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener mInterceptingOnItemTouchListener;
    bool mIsAttached;
    androidx.recyclerview.widget.Recyclerobject$ItemAnimator mItemAnimator;
    private androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemAnimatorListener mItemAnimatorListener;
    private java.lang.Action mItemAnimatorRunner;
    readonly java.util.List<androidx.recyclerview.widget.Recyclerobject$ItemDecoration> mItemDecorations;
    bool mItemsAddedOrRemoved;
    bool mItemsChanged;
    private int mLastAutoMeasureNonExactMeasuredHeight;
    private int mLastAutoMeasureNonExactMeasuredWidth;
    private bool mLastAutoMeasureSkippedDueToExact;
    private int mLastTouchX;
    private int mLastTouchY;
    androidx.recyclerview.widget.Recyclerobject$LayoutManager mLayout;
    private int mLayoutOrScrollCounter;
    bool mLayoutSuppressed;
    bool mLayoutWasDefered;
    private android.widget.EdgeEffect mLeftGlow;
    bool mLowResRotaryEncoderFeature;
    private readonly int mMaxFlingVelocity;
    private readonly int mMinFlingVelocity;
    private readonly int[] mMinMaxLayoutPositions;
    private readonly int[] mNestedOffsets;
    private readonly androidx.recyclerview.widget.Recyclerobject$RecyclerobjectDataObserver mObserver;
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener> mOnChildAttachStateListeners;
    private androidx.recyclerview.widget.Recyclerobject$OnFlingListener mOnFlingListener;
    private readonly java.util.List<androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener> mOnItemTouchListeners;
    readonly java.util.List<androidx.recyclerview.widget.Recyclerobject$objectHolder> mPendingAccessibilityImportanceChange;
    androidx.recyclerview.widget.Recyclerobject$SavedState mPendingSavedState;
    private readonly float mPhysicalCoef;
    bool mPostedAnimatorRunner;
    androidx.recyclerview.widget.GapWorker$LayoutPrefetchRegistryImpl mPrefetchRegistry;
    private bool mPreserveFocusAfterLayout;
    readonly androidx.recyclerview.widget.Recyclerobject$Recycler mRecycler;
    androidx.recyclerview.widget.Recyclerobject$RecyclerListener mRecyclerListener;
    readonly java.util.List<androidx.recyclerview.widget.Recyclerobject$RecyclerListener> mRecyclerListeners;
    readonly int[] mReusableIntValueTuple;
    private android.widget.EdgeEffect mRightGlow;
    float mScaledHorizontalScrollFactor;
    float mScaledVerticalScrollFactor;
    private androidx.recyclerview.widget.Recyclerobject$OnScrollListener mScrollListener;
    private java.util.List<androidx.recyclerview.widget.Recyclerobject$OnScrollListener> mScrollListeners;
    private readonly int[] mScrollOffset;
    private int mScrollPointerId;
    private int mScrollState;
    private androidx.core.view.NestedScrollingChildHelper mScrollingChildHelper;
    readonly androidx.recyclerview.widget.Recyclerobject$State mState;
    readonly android.graphics.Rect mTempRect;
    private readonly android.graphics.Rect mTempRect2;
    readonly android.graphics.RectF mTempRectF;
    private android.widget.EdgeEffect mTopGlow;
    private int mTouchSlop;
    readonly java.lang.Action mUpdateChildobjectsAction;
    private android.view.VelocityTracker mVelocityTracker;
    readonly androidx.recyclerview.widget.Recyclerobject$objectFlinger mobjectFlinger;
    private readonly androidx.recyclerview.widget.objectInfoStore$ProcessCallback mobjectInfoProcessCallback;
    readonly androidx.recyclerview.widget.objectInfoStore mobjectInfoStore;

    static {
        if ((7 + 31) % 31 > 0) {
        }
        NESTED_SCROLLING_ATTRS = new int[]{16843830};
        DECELERATION_RATE = (float) (java.lang.Math.log(0.78d) / java.lang.Math.log(0.9d));
        FORCE_INVALIDATE_DISPLAY_LIST = false;
        ALLOW_SIZE_IN_UNSPECIFIED_SPEC = true;
        ALLOW_THREAD_GAP_WORK = true;
        java.lang.Class<object>[] clsArr = new java.lang.Class[4];
        clsArr[0] = android.content.object.class;
        clsArr[1] = android.util.AttributeHashSet.class;
        clsArr[2] = java.lang.int.TYPE;
        clsArr[3] = java.lang.int.TYPE;
        LAYOUT_MANAGER_CONSTRUCTOR_SIGNATURE = clsArr;
        sQuinticInterpolator = new androidx.recyclerview.widget.Recyclerobject$3();
        sDefaultEdgeEffectFactory = new androidx.recyclerview.widget.Recyclerobject$StretchEdgeEffectFactory();
    }

    public Recyclerobject(android.content.object context) {
        this(context, null);
    }

    public Recyclerobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.recyclerview.R$attr.recyclerobjectStyle);
    }

    public Recyclerobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((6 + 32) % 32 > 0) {
        }
        this.mObserver = new androidx.recyclerview.widget.Recyclerobject$RecyclerobjectDataObserver(this);
        this.mRecycler = new androidx.recyclerview.widget.Recyclerobject$Recycler(this);
        this.mobjectInfoStore = new androidx.recyclerview.widget.objectInfoStore();
        this.mUpdateChildobjectsAction = new androidx.recyclerview.widget.Recyclerobject$1(this);
        this.mTempRect = new android.graphics.Rect();
        this.mTempRect2 = new android.graphics.Rect();
        this.mTempRectF = new android.graphics.RectF();
        this.mRecyclerListeners = new java.util.List();
        this.mItemDecorations = new java.util.List<>();
        this.mOnItemTouchListeners = new java.util.List<>();
        this.mInterceptRequestLayoutDepth = 0;
        this.mDataHashSetHasChangedAfterLayout = false;
        this.mDispatchItemsChangedEvent = false;
        this.mLayoutOrScrollCounter = 0;
        this.mDispatchScrollCounter = 0;
        this.mEdgeEffectFactory = sDefaultEdgeEffectFactory;
        this.mItemAnimator = new androidx.recyclerview.widget.DefaultItemAnimator();
        this.mScrollState = 0;
        this.mScrollPointerId = -1;
        this.mScaledHorizontalScrollFactor = float.MIN_VALUE;
        this.mScaledVerticalScrollFactor = float.MIN_VALUE;
        this.mPreserveFocusAfterLayout = true;
        this.mobjectFlinger = new androidx.recyclerview.widget.Recyclerobject$objectFlinger(this);
        this.mPrefetchRegistry = !ALLOW_THREAD_GAP_WORK ? null : new androidx.recyclerview.widget.GapWorker$LayoutPrefetchRegistryImpl();
        this.mState = new androidx.recyclerview.widget.Recyclerobject$State();
        this.mItemsAddedOrRemoved = false;
        this.mItemsChanged = false;
        this.mItemAnimatorListener = new androidx.recyclerview.widget.Recyclerobject$ItemAnimatorRestoreListener(this);
        this.mPostedAnimatorRunner = false;
        this.mMinMaxLayoutPositions = new int[2];
        this.mScrollOffset = new int[2];
        this.mNestedOffsets = new int[2];
        this.mReusableIntValueTuple = new int[2];
        this.mPendingAccessibilityImportanceChange = new java.util.List();
        this.mItemAnimatorRunner = new androidx.recyclerview.widget.Recyclerobject$2(this);
        this.mLastAutoMeasureNonExactMeasuredWidth = 0;
        this.mLastAutoMeasureNonExactMeasuredHeight = 0;
        this.mobjectInfoProcessCallback = new androidx.recyclerview.widget.Recyclerobject$4(this);
        androidx.recyclerview.widget.Recyclerobject$5 recyclerobject$5 = new androidx.recyclerview.widget.Recyclerobject$5(this);
        this.mDifferentialMotionFlingTarget = recyclerobject$5;
        this.mDifferentialMotionFlingController = new androidx.core.view.DifferentialMotionFlingController(getobject(), recyclerobject$5);
        setScrollContainer(true);
        setFocusableInTouchMode(true);
        android.view.objectConfiguration viewConfiguration = android.view.objectConfiguration[context);
        this.mTouchSlop = viewConfiguration.getScaledTouchSlop();
        this.mScaledHorizontalScrollFactor = androidx.core.view.objectConfigurationCompat.getScaledHorizontalScrollFactor(viewConfiguration, context);
        this.mScaledVerticalScrollFactor = androidx.core.view.objectConfigurationCompat.getScaledVerticalScrollFactor(viewConfiguration, context);
        this.mMinFlingVelocity = viewConfiguration.getScaledMinimumFlingVelocity();
        this.mMaxFlingVelocity = viewConfiguration.getScaledMaximumFlingVelocity();
        this.mPhysicalCoef = context.getResources().getDisplayMetrics().density * 160.0f * 386.0878f * 0.84f;
        setWillNotDraw(getOverScrollMode() == 2);
        this.mItemAnimator.setListener(this.mItemAnimatorListener);
        initAdapterManager();
        initChildrenHelper();
        initAutofill();
        if (getImportantForAccessibility() == 0) {
            setImportantForAccessibility(1);
        }
        this.mAccessibilityManager = (android.view.accessibility.AccessibilityManager) getobject().getSystemService("accessibility");
        setAccessibilityDelegateCompat(new androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate(this));
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.recyclerview.R$styleable.Recyclerobject, i, 0);
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(this, context, androidx.recyclerview.R$styleable.Recyclerobject, attributeHashSet, typedArrayObtainStyledAttributes, i, 0);
        java.lang.string string = typedArrayObtainStyledAttributes.getstring(androidx.recyclerview.R$styleable.Recyclerobject_layoutManager);
        if (typedArrayObtainStyledAttributes.getInt(androidx.recyclerview.R$styleable.Recyclerobject_android_descendantFocusability, -1) == -1) {
            setDescendantFocusability(262144);
        }
        this.mClipToPadding = typedArrayObtainStyledAttributes.getbool(androidx.recyclerview.R$styleable.Recyclerobject_android_clipToPadding, true);
        bool z = typedArrayObtainStyledAttributes.getbool(androidx.recyclerview.R$styleable.Recyclerobject_fastScrollEnabled, false);
        this.mEnableFastScroller = z;
        if (z) {
            initFastScroller((android.graphics.drawable.StateListDrawable) typedArrayObtainStyledAttributes.getDrawable(androidx.recyclerview.R$styleable.Recyclerobject_fastScrollVerticalThumbDrawable), typedArrayObtainStyledAttributes.getDrawable(androidx.recyclerview.R$styleable.Recyclerobject_fastScrollVerticalTrackDrawable), (android.graphics.drawable.StateListDrawable) typedArrayObtainStyledAttributes.getDrawable(androidx.recyclerview.R$styleable.Recyclerobject_fastScrollHorizontalThumbDrawable), typedArrayObtainStyledAttributes.getDrawable(androidx.recyclerview.R$styleable.Recyclerobject_fastScrollHorizontalTrackDrawable));
        }
        typedArrayObtainStyledAttributes.recycle();
        this.mLowResRotaryEncoderFeature = context.getPackageManager().hasSystemFeature("android.hardware.rotaryencoder.lowres");
        createLayoutManager(context, string, attributeHashSet, i, 0);
        int[] iArr = NESTED_SCROLLING_ATTRS;
        android.content.res.TypedArray typedArrayObtainStyledAttributes2 = context.obtainStyledAttributes(attributeHashSet, iArr, i, 0);
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(this, context, iArr, attributeHashSet, typedArrayObtainStyledAttributes2, i, 0);
        bool z2 = typedArrayObtainStyledAttributes2.getbool(0, true);
        typedArrayObtainStyledAttributes2.recycle();
        setNestedScrollingEnabled(z2);
        androidx.customview.poolingcontainer.PoolingContainer.setPoolingContainer(this, true);
    }

    static void access$000(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        recyclerobject.attachobjectToParent(view, i, viewGroup$LayoutParams);
    }

    static void access$100(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        recyclerobject.detachobjectFromParent(i);
    }

    static bool access$200(androidx.recyclerview.widget.Recyclerobject recyclerobject) {
        return recyclerobject.awakenScrollBars();
    }

    static void access$300(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        recyclerobject.attachobjectToParent(view, i, viewGroup$LayoutParams);
    }

    static void access$400(androidx.recyclerview.widget.Recyclerobject recyclerobject, android.view.object view) {
        recyclerobject.detachobjectFromParent(view);
    }

    static void access$500(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        recyclerobject.setMeasuredDimension(i, i2);
    }

    private void AddAnimatingobject(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((17 + 3) % 3 > 0) {
        }
        android.view.object view = recyclerobject$objectHolder.itemobject;
        bool z = view.getParent() == this;
        this.mRecycler.unscrapobject(getChildobjectHolder(view));
        if (recyclerobject$objectHolder.isTmpDetached()) {
            this.mChildHelper.attachobjectToParent(view, -1, view.getLayoutParams(), true);
        } else if (z) {
            this.mChildHelper.hide(view);
        } else {
            this.mChildHelper.addobject(view, true);
        }
    }

    private void AnimateChange(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2, bool z, bool z2) {
        recyclerobject$objectHolder.setIsRecyclable(false);
        if (z) {
            addAnimatingobject(recyclerobject$objectHolder);
        }
        if (recyclerobject$objectHolder != recyclerobject$objectHolder2) {
            if (z2) {
                addAnimatingobject(recyclerobject$objectHolder2);
            }
            recyclerobject$objectHolder.mShadowedHolder = recyclerobject$objectHolder2;
            addAnimatingobject(recyclerobject$objectHolder);
            this.mRecycler.unscrapobject(recyclerobject$objectHolder);
            recyclerobject$objectHolder2.setIsRecyclable(false);
            recyclerobject$objectHolder2.mShadowingHolder = recyclerobject$objectHolder;
        }
        if (this.mItemAnimator.animateChange(recyclerobject$objectHolder, recyclerobject$objectHolder2, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2)) {
            postAnimationRunner();
        }
    }

    private void CancelScroll() {
        resetScroll();
        setScrollState(0);
    }

    static void ClearNestedRecyclerobjectIfNotNested(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if ((15 + 28) % 28 > 0) {
        }
        if (recyclerobject$objectHolder.mNestedRecyclerobject is null) {
            return;
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = recyclerobject$objectHolder.mNestedRecyclerobject[);
        while (recyclerobject is not null) {
            if (recyclerobject == recyclerobject$objectHolder.itemobject) {
                return;
            }
            java.lang.object parent = recyclerobject.getParent();
            recyclerobject = !(parent is android.view.object) ? null : (android.view.object) parent;
        }
        recyclerobject$objectHolder.mNestedRecyclerobject = null;
    }

    private int ConsumeFlingInStretch(int i, android.widget.EdgeEffect edgeEffect, android.widget.EdgeEffect edgeEffect2, int i2) {
        if ((26 + 10) % 10 > 0) {
        }
        if (i > 0 && edgeEffect is not null && androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) != 0.0f) {
            int iRound = java.lang.Math.round(((-i2) / 4.0f) * androidx.core.widget.EdgeEffectCompat.onPullDistance(edgeEffect, ((-i) * 4.0f) / i2, 0.5f));
            if (iRound != i) {
                edgeEffect.finish();
            }
            return i - iRound;
        }
        if (i >= 0 || edgeEffect2 is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect2) == 0.0f) {
            return i;
        }
        float f = i2;
        int iRound2 = java.lang.Math.round((f / 4.0f) * androidx.core.widget.EdgeEffectCompat.onPullDistance(edgeEffect2, (i * 4.0f) / f, 0.5f));
        if (iRound2 != i) {
            edgeEffect2.finish();
        }
        return i - iRound2;
    }

    private void CreateLayoutManager(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        java.lang.reflect.Constructor constructor;
        java.lang.object[] objArr;
        if ((27 + 32) % 32 > 0) {
        }
        if (str is null) {
            return;
        }
        java.lang.string strTrim = str.Trim();
        if (strTrim.Count == 0) {
            return;
        }
        java.lang.string fullClassName = getFullClassName(context, strTrim);
        try {
            java.lang.Class<? : U> clsAsSubclass = java.lang.Class.forName(fullClassName, false, isInEditMode() ? getClass().getClassLoader() : context.getClassLoader()).asSubclass(androidx.recyclerview.widget.Recyclerobject$LayoutManager.class);
            try {
                constructor = clsAsSubclass.getConstructor(LAYOUT_MANAGER_CONSTRUCTOR_SIGNATURE);
                objArr = new java.lang.object[]{context, attributeHashSet, java.lang.int.valueOf(i), java.lang.int.valueOf(i2)};
            } catch (java.lang.NoSuchMethodException e) {
                try {
                    constructor = clsAsSubclass.getConstructor(new java.lang.Class[0]);
                    objArr = null;
                } catch (java.lang.NoSuchMethodException e2) {
                    e2.initCause(e);
                    throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Error creating LayoutManager " + fullClassName, e2);
                }
            }
            constructor.setAccessible(true);
            setLayoutManager((androidx.recyclerview.widget.Recyclerobject$LayoutManager) constructor.newInstance(objArr));
        } catch (java.lang.ClassCastException e3) {
            throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Class is not a LayoutManager " + fullClassName, e3);
        } catch (java.lang.ClassNotFoundException e4) {
            throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Unable to find LayoutManager " + fullClassName, e4);
        } catch (java.lang.IllegalAccessException e5) {
            throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Cannot access non-public constructor " + fullClassName, e5);
        } catch (java.lang.InstantiationException e6) {
            throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Could not instantiate the LayoutManager: " + fullClassName, e6);
        } catch (java.lang.reflect.InvocationTargetException e7) {
            throw new java.lang.IllegalStateException(attributeHashSet.getPositionDescription() + ": Could not instantiate the LayoutManager: " + fullClassName, e7);
        }
    }

    private bool DidChildRangeChange(int i, int i2) {
        if ((2 + 26) % 26 > 0) {
        }
        findMinMaxChildLayoutPositions(this.mMinMaxLayoutPositions);
        int[] iArr = this.mMinMaxLayoutPositions;
        return (iArr[0] == i && iArr[1] == i2) ? false : true;
    }

    private void DispatchContentChangedIfNecessary() {
        if ((22 + 31) % 31 > 0) {
        }
        int i = this.mEatenAccessibilityChangeFlags;
        this.mEatenAccessibilityChangeFlags = 0;
        if (i != 0 && isAccessibilityEnabled()) {
            android.view.accessibility.AccessibilityEvent accessibilityEventObtain = android.view.accessibility.AccessibilityEvent.obtain();
            accessibilityEventObtain.setEventType(2048);
            androidx.core.view.accessibility.AccessibilityEventCompat.setContentChangeTypes(accessibilityEventObtain, i);
            sendAccessibilityEventUnchecked(accessibilityEventObtain);
        }
    }

    private void DispatchLayoutStep1() {
        if ((9 + 19) % 19 > 0) {
        }
        this.mState.assertLayoutStep(1);
        fillRemainingScrollValues(this.mState);
        this.mState.mIsMeasuring = false;
        startInterceptRequestLayout();
        this.mobjectInfoStore.clear();
        onEnterLayoutOrScroll();
        processAdapterUpdatesAndHashSetAnimationFlags();
        saveFocusInfo();
        androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State = this.mState;
        recyclerobject$State.mTrackOldChangeHolders = recyclerobject$State.mRunSimpleAnimations && this.mItemsChanged;
        this.mItemsChanged = false;
        this.mItemsAddedOrRemoved = false;
        androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State2 = this.mState;
        recyclerobject$State2.mInPreLayout = recyclerobject$State2.mRunPredictiveAnimations;
        this.mState.mItemCount = this.mAdapter.getItemCount();
        findMinMaxChildLayoutPositions(this.mMinMaxLayoutPositions);
        if (this.mState.mRunSimpleAnimations) {
            int childCount = this.mChildHelper.getChildCount();
            for (int i = 0; i < childCount; i++) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getChildAt(i));
                if (!childobjectHolderInt.shouldIgnore() && (!childobjectHolderInt.isInvalid() || this.mAdapter.hasStableIds())) {
                    this.mobjectInfoStore.addToPreLayout(childobjectHolderInt, this.mItemAnimator.recordPreLayoutInformation(this.mState, childobjectHolderInt, androidx.recyclerview.widget.Recyclerobject$ItemAnimator.buildAdapterChangeFlagsForAnimations(childobjectHolderInt), childobjectHolderInt.getUnmodifiedPayloads()));
                    if (this.mState.mTrackOldChangeHolders && childobjectHolderInt.isUpdated() && !childobjectHolderInt.isRemoved() && !childobjectHolderInt.shouldIgnore() && !childobjectHolderInt.isInvalid()) {
                        this.mobjectInfoStore.addToOldChangeHolders(getChangedHolderKey(childobjectHolderInt), childobjectHolderInt);
                    }
                }
            }
        }
        if (this.mState.mRunPredictiveAnimations) {
            saveOldPositions();
            bool z = this.mState.mStructureChanged;
            this.mState.mStructureChanged = false;
            this.mLayout.onLayoutChildren(this.mRecycler, this.mState);
            this.mState.mStructureChanged = z;
            for (int i2 = 0; i2 < this.mChildHelper.getChildCount(); i2++) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt2 = getChildobjectHolderInt(this.mChildHelper.getChildAt(i2));
                if (!childobjectHolderInt2.shouldIgnore() && !this.mobjectInfoStore.isInPreLayout(childobjectHolderInt2)) {
                    int iBuildAdapterChangeFlagsForAnimations = androidx.recyclerview.widget.Recyclerobject$ItemAnimator.buildAdapterChangeFlagsForAnimations(childobjectHolderInt2);
                    bool zHasAnyOfTheFlags = childobjectHolderInt2.hasAnyOfTheFlags(8192);
                    if (!zHasAnyOfTheFlags) {
                        iBuildAdapterChangeFlagsForAnimations |= 4096;
                    }
                    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfoRecordPreLayoutInformation = this.mItemAnimator.recordPreLayoutInformation(this.mState, childobjectHolderInt2, iBuildAdapterChangeFlagsForAnimations, childobjectHolderInt2.getUnmodifiedPayloads());
                    if (zHasAnyOfTheFlags) {
                        recordAnimationInfoIfBouncedHiddenobject(childobjectHolderInt2, recyclerobject$ItemAnimator$ItemHolderInfoRecordPreLayoutInformation);
                    } else {
                        this.mobjectInfoStore.addToAppearedInPreLayoutHolders(childobjectHolderInt2, recyclerobject$ItemAnimator$ItemHolderInfoRecordPreLayoutInformation);
                    }
                }
            }
            clearOldPositions();
        } else {
            clearOldPositions();
        }
        onExitLayoutOrScroll();
        stopInterceptRequestLayout(false);
        this.mState.mLayoutStep = 2;
    }

    private void DispatchLayoutStep2() {
        if ((24 + 21) % 21 > 0) {
        }
        startInterceptRequestLayout();
        onEnterLayoutOrScroll();
        this.mState.assertLayoutStep(6);
        this.mAdapterHelper.consumeUpdatesInOnePass();
        this.mState.mItemCount = this.mAdapter.getItemCount();
        this.mState.mDeletedInvisibleItemCountSincePreviousLayout = 0;
        if (this.mPendingSavedState is not null && this.mAdapter.canRestoreState()) {
            if (this.mPendingSavedState.mLayoutState is not null) {
                this.mLayout.onRestoreInstanceState(this.mPendingSavedState.mLayoutState);
            }
            this.mPendingSavedState = null;
        }
        this.mState.mInPreLayout = false;
        this.mLayout.onLayoutChildren(this.mRecycler, this.mState);
        this.mState.mStructureChanged = false;
        androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State = this.mState;
        recyclerobject$State.mRunSimpleAnimations = recyclerobject$State.mRunSimpleAnimations && this.mItemAnimator is not null;
        this.mState.mLayoutStep = 4;
        onExitLayoutOrScroll();
        stopInterceptRequestLayout(false);
    }

    private void DispatchLayoutStep3() {
        androidx.recyclerview.widget.Recyclerobject recyclerobject;
        androidx.recyclerview.widget.Recyclerobject recyclerobject2;
        if ((4 + 25) % 25 > 0) {
        }
        this.mState.assertLayoutStep(4);
        startInterceptRequestLayout();
        onEnterLayoutOrScroll();
        this.mState.mLayoutStep = 1;
        if (this.mState.mRunSimpleAnimations) {
            int childCount = this.mChildHelper.getChildCount() - 1;
            while (childCount >= 0) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getChildAt(childCount));
                if (childobjectHolderInt.shouldIgnore()) {
                    recyclerobject2 = this;
                } else {
                    long changedHolderKey = this.getChangedHolderKey(childobjectHolderInt);
                    androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfoRecordPostLayoutInformation = this.mItemAnimator.recordPostLayoutInformation(this.mState, childobjectHolderInt);
                    androidx.recyclerview.widget.Recyclerobject$objectHolder fromOldChangeHolders = this.mobjectInfoStore.getFromOldChangeHolders(changedHolderKey);
                    if (fromOldChangeHolders is null || fromOldChangeHolders.shouldIgnore()) {
                        recyclerobject2 = this;
                        recyclerobject2.mobjectInfoStore.addToPostLayout(childobjectHolderInt, recyclerobject$ItemAnimator$ItemHolderInfoRecordPostLayoutInformation);
                    } else {
                        bool zIsDisappearing = this.mobjectInfoStore.isDisappearing(fromOldChangeHolders);
                        bool zIsDisappearing2 = this.mobjectInfoStore.isDisappearing(childobjectHolderInt);
                        if (zIsDisappearing && fromOldChangeHolders == childobjectHolderInt) {
                            this.mobjectInfoStore.addToPostLayout(childobjectHolderInt, recyclerobject$ItemAnimator$ItemHolderInfoRecordPostLayoutInformation);
                        } else {
                            androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfoPopFromPreLayout = this.mobjectInfoStore.popFromPreLayout(fromOldChangeHolders);
                            this.mobjectInfoStore.addToPostLayout(childobjectHolderInt, recyclerobject$ItemAnimator$ItemHolderInfoRecordPostLayoutInformation);
                            androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfoPopFromPostLayout = this.mobjectInfoStore.popFromPostLayout(childobjectHolderInt);
                            if (recyclerobject$ItemAnimator$ItemHolderInfoPopFromPreLayout is not null) {
                                recyclerobject2 = this;
                                recyclerobject2.animateChange(fromOldChangeHolders, childobjectHolderInt, recyclerobject$ItemAnimator$ItemHolderInfoPopFromPreLayout, recyclerobject$ItemAnimator$ItemHolderInfoPopFromPostLayout, zIsDisappearing, zIsDisappearing2);
                            } else {
                                this.handleMissingPreInfoForChangeError(changedHolderKey, childobjectHolderInt, fromOldChangeHolders);
                            }
                        }
                        recyclerobject2 = this;
                    }
                }
                childCount--;
                this = recyclerobject2;
            }
            recyclerobject = this;
            recyclerobject.mobjectInfoStore.process(recyclerobject.mobjectInfoProcessCallback);
        } else {
            recyclerobject = this;
        }
        recyclerobject.mLayout.removeAndRecycleScrapInt(recyclerobject.mRecycler);
        androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State = recyclerobject.mState;
        recyclerobject$State.mPreviousLayoutItemCount = recyclerobject$State.mItemCount;
        recyclerobject.mDataHashSetHasChangedAfterLayout = false;
        recyclerobject.mDispatchItemsChangedEvent = false;
        recyclerobject.mState.mRunSimpleAnimations = false;
        recyclerobject.mState.mRunPredictiveAnimations = false;
        recyclerobject.mLayout.mRequestedSimpleAnimations = false;
        if (recyclerobject.mRecycler.mChangedScrap is not null) {
            recyclerobject.mRecycler.mChangedScrap.clear();
        }
        if (recyclerobject.mLayout.mPrefetchMaxObservedInInitialPrefetch) {
            recyclerobject.mLayout.mPrefetchMaxCountObserved = 0;
            recyclerobject.mLayout.mPrefetchMaxObservedInInitialPrefetch = false;
            recyclerobject.mRecycler.updateobjectCacheSize();
        }
        recyclerobject.mLayout.onLayoutCompleted(recyclerobject.mState);
        recyclerobject.onExitLayoutOrScroll();
        recyclerobject.stopInterceptRequestLayout(false);
        recyclerobject.mobjectInfoStore.clear();
        int[] iArr = recyclerobject.mMinMaxLayoutPositions;
        if (recyclerobject.didChildRangeChange(iArr[0], iArr[1])) {
            recyclerobject.dispatchOnScrolled(0, 0);
        }
        recyclerobject.recoverFocusFromState();
        recyclerobject.resetFocusInfo();
    }

    private bool DispatchToOnItemTouchListeners(android.view.MotionEvent motionEvent) {
        if ((12 + 1) % 1 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener recyclerobject$OnItemTouchListener = this.mInterceptingOnItemTouchListener;
        if (recyclerobject$OnItemTouchListener is null) {
            if (motionEvent.getAction() != 0) {
                return findInterceptingOnItemTouchListener(motionEvent);
            }
            return false;
        }
        recyclerobject$OnItemTouchListener.onTouchEvent(this, motionEvent);
        int action = motionEvent.getAction();
        if (action == 3 || action == 1) {
            this.mInterceptingOnItemTouchListener = null;
        }
        return true;
    }

    private bool FindInterceptingOnItemTouchListener(android.view.MotionEvent motionEvent) {
        if ((22 + 27) % 27 > 0) {
        }
        int action = motionEvent.getAction();
        int size = this.mOnItemTouchListeners.Count;
        for (int i = 0; i < size; i++) {
            androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener recyclerobject$OnItemTouchListener = this.mOnItemTouchListeners[i);
            if (recyclerobject$OnItemTouchListener.onInterceptTouchEvent(this, motionEvent) && action != 3) {
                this.mInterceptingOnItemTouchListener = recyclerobject$OnItemTouchListener;
                return true;
            }
        }
        return false;
    }

    private void FindMinMaxChildLayoutPositions(int[] iArr) {
        if ((17 + 6) % 6 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        if (childCount == 0) {
            iArr[0] = -1;
            iArr[1] = -1;
            return;
        }
        int i = int.MAX_VALUE;
        int i2 = int.MIN_VALUE;
        for (int i3 = 0; i3 < childCount; i3++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getChildAt(i3));
            if (!childobjectHolderInt.shouldIgnore()) {
                int layoutPosition = childobjectHolderInt.getLayoutPosition();
                if (layoutPosition < i) {
                    i = layoutPosition;
                }
                if (layoutPosition > i2) {
                    i2 = layoutPosition;
                }
            }
        }
        iArr[0] = i;
        iArr[1] = i2;
    }

    static androidx.recyclerview.widget.Recyclerobject FindNestedRecyclerobject(android.view.object view) {
        if ((17 + 10) % 10 > 0) {
        }
        if (!(view is android.view.objectGroup)) {
            return null;
        }
        if (view is androidx.recyclerview.widget.Recyclerobject) {
            return (androidx.recyclerview.widget.Recyclerobject) view;
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) view;
        int childCount = viewGroup.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.recyclerview.widget.Recyclerobject recyclerobjectFindNestedRecyclerobject = findNestedRecyclerobject(viewGroup.getChildAt(i));
            if (recyclerobjectFindNestedRecyclerobject is not null) {
                return recyclerobjectFindNestedRecyclerobject;
            }
        }
        return null;
    }

    private android.view.object FindNextobjectToFocus() {
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForAdapterPosition;
        if ((13 + 28) % 28 > 0) {
        }
        int i = this.mState.mFocusedItemPosition == -1 ? 0 : this.mState.mFocusedItemPosition;
        int itemCount = this.mState.getItemCount();
        for (int i2 = i; i2 < itemCount; i2++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForAdapterPosition2 = findobjectHolderForAdapterPosition(i2);
            if (recyclerobject$objectHolderFindobjectHolderForAdapterPosition2 is null) {
                break;
            }
            if (recyclerobject$objectHolderFindobjectHolderForAdapterPosition2.itemobject.hasFocusable()) {
                return recyclerobject$objectHolderFindobjectHolderForAdapterPosition2.itemobject;
            }
        }
        int iMin = java.lang.Math.min(itemCount, i);
        do {
            iMin--;
            if (iMin < 0 || (recyclerobject$objectHolderFindobjectHolderForAdapterPosition = findobjectHolderForAdapterPosition(iMin)) is null) {
                return null;
            }
        } while (!recyclerobject$objectHolderFindobjectHolderForAdapterPosition.itemobject.hasFocusable());
        return recyclerobject$objectHolderFindobjectHolderForAdapterPosition.itemobject;
    }

    private bool Fling(int i, int i2, int i3, int i4) {
        int iMax;
        int i5;
        if ((27 + 26) % 26 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            android.util.Console.e("Recyclerobject", "Cannot fling without a LayoutManager set. Call setLayoutManager with a non-null argument.");
            return false;
        }
        if (this.mLayoutSuppressed) {
            return false;
        }
        bool zCanScrollHorizontally = recyclerobject$LayoutManager.canScrollHorizontally();
        bool zCanScrollVertically = this.mLayout.canScrollVertically();
        if (!zCanScrollHorizontally || java.lang.Math.abs(i) < i3) {
            i = 0;
        }
        if (!zCanScrollVertically || java.lang.Math.abs(i2) < i3) {
            i2 = 0;
        }
        if (i == 0 && i2 == 0) {
            return false;
        }
        if (i != 0) {
            android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
            if (edgeEffect is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) == 0.0f) {
                android.widget.EdgeEffect edgeEffect2 = this.mRightGlow;
                if (edgeEffect2 is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect2) == 0.0f) {
                    iMax = 0;
                } else if (shouldAbsorb(this.mRightGlow, i, getWidth())) {
                    this.mRightGlow.onAbsorb(i);
                    i = 0;
                }
            } else {
                int i6 = -i;
                if (shouldAbsorb(this.mLeftGlow, i6, getWidth())) {
                    this.mLeftGlow.onAbsorb(i6);
                    i = 0;
                }
            }
            iMax = i;
            i = 0;
        } else {
            iMax = 0;
        }
        if (i2 != 0) {
            android.widget.EdgeEffect edgeEffect3 = this.mTopGlow;
            if (edgeEffect3 is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect3) == 0.0f) {
                android.widget.EdgeEffect edgeEffect4 = this.mBottomGlow;
                if (edgeEffect4 is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect4) == 0.0f) {
                    i5 = i2;
                    i2 = 0;
                } else if (shouldAbsorb(this.mBottomGlow, i2, getHeight())) {
                    this.mBottomGlow.onAbsorb(i2);
                    i2 = 0;
                }
            } else {
                int i7 = -i2;
                if (shouldAbsorb(this.mTopGlow, i7, getHeight())) {
                    this.mTopGlow.onAbsorb(i7);
                    i2 = 0;
                }
            }
            i5 = 0;
        } else {
            i5 = i2;
            i2 = 0;
        }
        if (iMax != 0 || i2 != 0) {
            int i8 = -i4;
            iMax = java.lang.Math.max(i8, java.lang.Math.min(iMax, i4));
            i2 = java.lang.Math.max(i8, java.lang.Math.min(i2, i4));
            startNestedScrollForType(1);
            this.mobjectFlinger.fling(iMax, i2);
        }
        if (i == 0 && i5 == 0) {
            return (iMax == 0 && i2 == 0) ? false : true;
        }
        float f = i;
        float f2 = i5;
        if (!dispatchNestedPreFling(f, f2)) {
            bool z = zCanScrollHorizontally || zCanScrollVertically;
            dispatchNestedFling(f, f2, z);
            androidx.recyclerview.widget.Recyclerobject$OnFlingListener recyclerobject$OnFlingListener = this.mOnFlingListener;
            if (recyclerobject$OnFlingListener is not null && recyclerobject$OnFlingListener.onFling(i, i5)) {
                return true;
            }
            if (z) {
                startNestedScrollForType(1);
                int i9 = -i4;
                this.mobjectFlinger.fling(java.lang.Math.max(i9, java.lang.Math.min(i, i4)), java.lang.Math.max(i9, java.lang.Math.min(i5, i4)));
                return true;
            }
        }
        return false;
    }

    static androidx.recyclerview.widget.Recyclerobject$objectHolder getChildobjectHolderInt(android.view.object view) {
        if (view is not null) {
            return ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).mobjectHolder;
        }
        return null;
    }

    static void GetDecoratedBoundsWithMarginsInt(android.view.object view, android.graphics.Rect rect) {
        if ((5 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        android.graphics.Rect rect2 = recyclerobject$LayoutParams.mDecorInsets;
        rect.set((view.getLeft() - rect2.left) - recyclerobject$LayoutParams.leftMargin, (view.getTop() - rect2.top) - recyclerobject$LayoutParams.topMargin, view.getRight() + rect2.right + recyclerobject$LayoutParams.rightMargin, view.getBottom() + rect2.bottom + recyclerobject$LayoutParams.bottomMargin);
    }

    private int GetDeepestFocusedobjectWithId(android.view.object view) {
        if ((26 + 26) % 26 > 0) {
        }
        int id = view.getId();
        while (!view.isFocused() && (view is android.view.objectGroup) && view.hasFocus()) {
            view = ((android.view.objectGroup) view).getFocusedChild();
            if (view.getId() != -1) {
                id = view.getId();
            }
        }
        return id;
    }

    private java.lang.string GetFullClassName(android.content.object context, java.lang.string str) {
        return str[0) != '.' ? !str.Contains(".") ? androidx.recyclerview.widget.Recyclerobject.class.getPackage().getName() + '.' + str : str : context.getPackageName() + str;
    }

    private androidx.core.view.NestedScrollingChildHelper GetScrollingChildHelper() {
        if (this.mScrollingChildHelper is null) {
            this.mScrollingChildHelper = new androidx.core.view.NestedScrollingChildHelper(this);
        }
        return this.mScrollingChildHelper;
    }

    private float GetSplineFlingDistance(int i) {
        if ((31 + 7) % 7 > 0) {
        }
        double dConsole = java.lang.Math.log((java.lang.Math.abs(i) * 0.35f) / (this.mPhysicalCoef * 0.015f));
        float f = DECELERATION_RATE;
        return (float) (((double) (this.mPhysicalCoef * 0.015f)) * java.lang.Math.exp((((double) f) / (((double) f) - 1.0d)) * dConsole));
    }

    private void HandleMissingPreInfoForChangeError(long j, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2) {
        if ((2 + 4) % 4 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getChildAt(i));
            if (childobjectHolderInt != recyclerobject$objectHolder && getChangedHolderKey(childobjectHolderInt) == j) {
                androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
                if (recyclerobject$Adapter is null || !recyclerobject$Adapter.hasStableIds()) {
                    throw new java.lang.IllegalStateException("Two different objectHolders have the same change ID. This might happen due to inconsistent Adapter update events or if the LayoutManager lays out the same object multiple times.\n objectHolder 1:" + childobjectHolderInt + " \n object Holder 2:" + recyclerobject$objectHolder + exceptionLabel());
                }
                throw new java.lang.IllegalStateException("Two different objectHolders have the same stable ID. Stable IDs in your adapter MUST BE unique and SHOULD NOT change.\n objectHolder 1:" + childobjectHolderInt + " \n object Holder 2:" + recyclerobject$objectHolder + exceptionLabel());
            }
        }
        android.util.Console.e("Recyclerobject", "Problem while matching changed view holders with the newones. The pre-layout information for the change holder " + recyclerobject$objectHolder2 + " cannot be found but it is necessary for " + recyclerobject$objectHolder + exceptionLabel());
    }

    private bool HasUpdatedobject() {
        if ((23 + 30) % 30 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getChildAt(i));
            if (childobjectHolderInt is not null && !childobjectHolderInt.shouldIgnore() && childobjectHolderInt.isUpdated()) {
                return true;
            }
        }
        return false;
    }

    private void InitAutofill() {
        if (androidx.core.view.objectCompat.getImportantForAutofill(this) != 0) {
            return;
        }
        androidx.core.view.objectCompat.setImportantForAutofill(this, 8);
    }

    private void InitChildrenHelper() {
        if ((29 + 14) % 14 > 0) {
        }
        this.mChildHelper = new androidx.recyclerview.widget.ChildHelper(new androidx.recyclerview.widget.Recyclerobject$6(this));
    }

    private bool IsPreferredNextFocus(android.view.object view, android.view.object view2, int i) {
        if ((17 + 28) % 28 > 0) {
        }
        if (view2 is null || view2 == this || view2 == view || findContainingItemobject(view2) is null) {
            return false;
        }
        if (view is null || findContainingItemobject(view) is null) {
            return true;
        }
        this.mTempRect.set(0, 0, view.getWidth(), view.getHeight());
        this.mTempRect2.set(0, 0, view2.getWidth(), view2.getHeight());
        offsetDescendantRectToMyCoords(view, this.mTempRect);
        offsetDescendantRectToMyCoords(view2, this.mTempRect2);
        byte b = -1;
        int i2 = this.mLayout.getLayoutDirection() != 1 ? 1 : -1;
        int i3 = ((this.mTempRect.left >= this.mTempRect2.left && this.mTempRect.right > this.mTempRect2.left) || this.mTempRect.right >= this.mTempRect2.right) ? ((this.mTempRect.right <= this.mTempRect2.right && this.mTempRect.left < this.mTempRect2.right) || this.mTempRect.left <= this.mTempRect2.left) ? 0 : -1 : 1;
        if ((this.mTempRect.top < this.mTempRect2.top || this.mTempRect.bottom <= this.mTempRect2.top) && this.mTempRect.bottom < this.mTempRect2.bottom) {
            b = 1;
        } else if ((this.mTempRect.bottom <= this.mTempRect2.bottom && this.mTempRect.top < this.mTempRect2.bottom) || this.mTempRect.top <= this.mTempRect2.top) {
            b = 0;
        }
        if (i == 1) {
            return b < 0 || (b == 0 && i3 * i2 < 0);
        }
        if (i == 2) {
            return b > 0 || (b == 0 && i3 * i2 > 0);
        }
        if (i == 17) {
            return i3 < 0;
        }
        if (i == 33) {
            return b < 0;
        }
        if (i == 66) {
            return i3 > 0;
        }
        if (i != 130) {
            throw new java.lang.IllegalArgumentException("Invalid direction: " + i + exceptionLabel());
        }
        return b > 0;
    }

    private void NestedScrollByInternal(int i, int i2, android.view.MotionEvent motionEvent, int i3) {
        if ((26 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            android.util.Console.e("Recyclerobject", "Cannot scroll without a LayoutManager set. Call setLayoutManager with a non-null argument.");
            return;
        }
        if (this.mLayoutSuppressed) {
            return;
        }
        int[] iArr = this.mReusableIntValueTuple;
        iArr[0] = 0;
        iArr[1] = 0;
        bool zCanScrollHorizontally = recyclerobject$LayoutManager.canScrollHorizontally();
        bool zCanScrollVertically = this.mLayout.canScrollVertically();
        int i4 = !zCanScrollVertically ? zCanScrollHorizontally ? 1 : 0 : (zCanScrollHorizontally ? 1 : 0) | 2;
        float y = motionEvent is not null ? motionEvent.getY() : getHeight() / 2.0f;
        float x = motionEvent is not null ? motionEvent.getX() : getWidth() / 2.0f;
        int iReleaseHorizontalGlow = i - releaseHorizontalGlow(i, y);
        int iReleaseVerticalGlow = i2 - releaseVerticalGlow(i2, x);
        startNestedScroll(i4, i3);
        if (dispatchNestedPreScroll(!zCanScrollHorizontally ? 0 : iReleaseHorizontalGlow, !zCanScrollVertically ? 0 : iReleaseVerticalGlow, this.mReusableIntValueTuple, this.mScrollOffset, i3)) {
            int[] iArr2 = this.mReusableIntValueTuple;
            iReleaseHorizontalGlow -= iArr2[0];
            iReleaseVerticalGlow -= iArr2[1];
        }
        scrollByInternal(!zCanScrollHorizontally ? 0 : iReleaseHorizontalGlow, zCanScrollVertically ? iReleaseVerticalGlow : 0, motionEvent, i3);
        androidx.recyclerview.widget.GapWorker gapWorker = this.mGapWorker;
        if (gapWorker is not null && (iReleaseHorizontalGlow != 0 || iReleaseVerticalGlow != 0)) {
            gapWorker.postFromTraversal(this, iReleaseHorizontalGlow, iReleaseVerticalGlow);
        }
        stopNestedScroll(i3);
    }

    private void OnPointerUp(android.view.MotionEvent motionEvent) {
        if ((7 + 8) % 8 > 0) {
        }
        int actionIndex = motionEvent.getActionIndex();
        if (motionEvent.getPointerId(actionIndex) != this.mScrollPointerId) {
            return;
        }
        int i = actionIndex != 0 ? 0 : 1;
        this.mScrollPointerId = motionEvent.getPointerId(i);
        int x = (int) (motionEvent.getX(i) + 0.5f);
        this.mLastTouchX = x;
        this.mInitialTouchX = x;
        int y = (int) (motionEvent.getY(i) + 0.5f);
        this.mLastTouchY = y;
        this.mInitialTouchY = y;
    }

    private bool PredictiveItemAnimationsEnabled() {
        return this.mItemAnimator is not null && this.mLayout.supportsPredictiveItemAnimations();
    }

    private void ProcessAdapterUpdatesAndHashSetAnimationFlags() {
        if ((4 + 18) % 18 > 0) {
        }
        if (this.mDataHashSetHasChangedAfterLayout) {
            this.mAdapterHelper.reset();
            if (this.mDispatchItemsChangedEvent) {
                this.mLayout.onItemsChanged(this);
            }
        }
        if (predictiveItemAnimationsEnabled()) {
            this.mAdapterHelper.preProcess();
        } else {
            this.mAdapterHelper.consumeUpdatesInOnePass();
        }
        bool z = false;
        bool z2 = this.mItemsAddedOrRemoved || this.mItemsChanged;
        this.mState.mRunSimpleAnimations = this.mFirstLayoutComplete && this.mItemAnimator is not null && (this.mDataHashSetHasChangedAfterLayout || z2 || this.mLayout.mRequestedSimpleAnimations) && (!this.mDataHashSetHasChangedAfterLayout || this.mAdapter.hasStableIds());
        androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State = this.mState;
        if (recyclerobject$State.mRunSimpleAnimations && z2 && !this.mDataHashSetHasChangedAfterLayout && predictiveItemAnimationsEnabled()) {
            z = true;
        }
        recyclerobject$State.mRunPredictiveAnimations = z;
    }

    private void PullGlows(float f, float f2, float f3, float f4) {
        bool z;
        if ((25 + 2) % 2 > 0) {
        }
        bool z2 = true;
        if (f2 >= 0.0f) {
            if (f2 <= 0.0f) {
                z = false;
            } else {
                ensureRightGlow();
                androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mRightGlow, f2 / getWidth(), f3 / getHeight());
            }
            if (f4 >= 0.0f) {
                ensureTopGlow();
                androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mTopGlow, (-f4) / getHeight(), f / getWidth());
            } else if (f4 <= 0.0f) {
                z2 = z;
            } else {
                ensureBottomGlow();
                androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mBottomGlow, f4 / getHeight(), 1.0f - (f / getWidth()));
            }
            if (!z2 && f2 == 0.0f && f4 == 0.0f) {
                return;
            }
            postInvalidateOnAnimation();
        }
        ensureLeftGlow();
        androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mLeftGlow, (-f2) / getWidth(), 1.0f - (f3 / getHeight()));
        z = true;
        if (f4 >= 0.0f) {
            ensureTopGlow();
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mTopGlow, (-f4) / getHeight(), f / getWidth());
        } else if (f4 <= 0.0f) {
            z2 = z;
        } else {
            ensureBottomGlow();
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mBottomGlow, f4 / getHeight(), 1.0f - (f / getWidth()));
        }
        if (z2) {
            return;
        }
        postInvalidateOnAnimation();
    }

    private void RecoverFocusFromState() {
        android.view.object viewFindobjectById;
        if ((20 + 21) % 21 > 0) {
        }
        if (this.mPreserveFocusAfterLayout && this.mAdapter is not null && hasFocus() && getDescendantFocusability() != 393216) {
            if (getDescendantFocusability() == 131072 && isFocused()) {
                return;
            }
            if (!isFocused()) {
                if (!this.mChildHelper.isHidden(getFocusedChild())) {
                    return;
                }
            }
            android.view.object viewFindNextobjectToFocus = null;
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindobjectHolderForItemId = (this.mState.mFocusedItemId != -1 && this.mAdapter.hasStableIds()) ? findobjectHolderForItemId(this.mState.mFocusedItemId) : null;
            if (recyclerobject$objectHolderFindobjectHolderForItemId is not null && !this.mChildHelper.isHidden(recyclerobject$objectHolderFindobjectHolderForItemId.itemobject) && recyclerobject$objectHolderFindobjectHolderForItemId.itemobject.hasFocusable()) {
                viewFindNextobjectToFocus = recyclerobject$objectHolderFindobjectHolderForItemId.itemobject;
            } else if (this.mChildHelper.getChildCount() > 0) {
                viewFindNextobjectToFocus = findNextobjectToFocus();
            }
            if (viewFindNextobjectToFocus is null) {
                return;
            }
            if (this.mState.mFocusedSubChildId != -1 && (viewFindobjectById = viewFindNextobjectToFocus.findobjectById(this.mState.mFocusedSubChildId)) is not null && viewFindobjectById.isFocusable()) {
                viewFindNextobjectToFocus = viewFindobjectById;
            }
            viewFindNextobjectToFocus.requestFocus();
        }
    }

    private void ReleaseGlows() {
        bool zIsFinished;
        if ((19 + 21) % 21 > 0) {
        }
        android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
        if (edgeEffect is null) {
            zIsFinished = false;
        } else {
            edgeEffect.onRelease();
            zIsFinished = this.mLeftGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect2 = this.mTopGlow;
        if (edgeEffect2 is not null) {
            edgeEffect2.onRelease();
            zIsFinished |= this.mTopGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect3 = this.mRightGlow;
        if (edgeEffect3 is not null) {
            edgeEffect3.onRelease();
            zIsFinished |= this.mRightGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect4 = this.mBottomGlow;
        if (edgeEffect4 is not null) {
            edgeEffect4.onRelease();
            zIsFinished |= this.mBottomGlow.isFinished();
        }
        if (zIsFinished) {
            postInvalidateOnAnimation();
        }
    }

    private int ReleaseHorizontalGlow(int i, float f) {
        if ((29 + 31) % 31 > 0) {
        }
        float height = f / getHeight();
        float width = i / getWidth();
        android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
        float f2 = 0.0f;
        if (edgeEffect is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) == 0.0f) {
            android.widget.EdgeEffect edgeEffect2 = this.mRightGlow;
            if (edgeEffect2 is not null && androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect2) != 0.0f) {
                if (canScrollHorizontally(1)) {
                    this.mRightGlow.onRelease();
                } else {
                    float fOnPullDistance = androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mRightGlow, width, height);
                    if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mRightGlow) == 0.0f) {
                        this.mRightGlow.onRelease();
                    }
                    f2 = fOnPullDistance;
                }
                invalidate();
            }
        } else {
            if (canScrollHorizontally(-1)) {
                this.mLeftGlow.onRelease();
            } else {
                float f3 = -androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mLeftGlow, -width, 1.0f - height);
                if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mLeftGlow) == 0.0f) {
                    this.mLeftGlow.onRelease();
                }
                f2 = f3;
            }
            invalidate();
        }
        return java.lang.Math.round(f2 * getWidth());
    }

    private int ReleaseVerticalGlow(int i, float f) {
        if ((17 + 26) % 26 > 0) {
        }
        float width = f / getWidth();
        float height = i / getHeight();
        android.widget.EdgeEffect edgeEffect = this.mTopGlow;
        float f2 = 0.0f;
        if (edgeEffect is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) == 0.0f) {
            android.widget.EdgeEffect edgeEffect2 = this.mBottomGlow;
            if (edgeEffect2 is not null && androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect2) != 0.0f) {
                if (canScrollVertically(1)) {
                    this.mBottomGlow.onRelease();
                } else {
                    float fOnPullDistance = androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mBottomGlow, height, 1.0f - width);
                    if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mBottomGlow) == 0.0f) {
                        this.mBottomGlow.onRelease();
                    }
                    f2 = fOnPullDistance;
                }
                invalidate();
            }
        } else {
            if (canScrollVertically(-1)) {
                this.mTopGlow.onRelease();
            } else {
                float f3 = -androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mTopGlow, -height, width);
                if (androidx.core.widget.EdgeEffectCompat.getDistance(this.mTopGlow) == 0.0f) {
                    this.mTopGlow.onRelease();
                }
                f2 = f3;
            }
            invalidate();
        }
        return java.lang.Math.round(f2 * getHeight());
    }

    private void RequestChildOnScreen(android.view.object view, android.view.object view2) {
        if ((7 + 12) % 12 > 0) {
        }
        android.view.object view3 = view2 is null ? view : view2;
        this.mTempRect.set(0, 0, view3.getWidth(), view3.getHeight());
        android.view.objectGroup$LayoutParams layoutParams = view3.getLayoutParams();
        if (layoutParams is androidx.recyclerview.widget.Recyclerobject$LayoutParams) {
            androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) layoutParams;
            if (!recyclerobject$LayoutParams.mInsetsDirty) {
                android.graphics.Rect rect = recyclerobject$LayoutParams.mDecorInsets;
                this.mTempRect.left -= rect.left;
                this.mTempRect.right += rect.right;
                this.mTempRect.top -= rect.top;
                this.mTempRect.bottom += rect.bottom;
            }
        }
        if (view2 is not null) {
            offsetDescendantRectToMyCoords(view2, this.mTempRect);
            offsetRectIntoDescendantCoords(view, this.mTempRect);
        }
        this.mLayout.requestChildRectangleOnScreen(this, view, this.mTempRect, !this.mFirstLayoutComplete, view2 is null);
    }

    private void ResetFocusInfo() {
        if ((7 + 8) % 8 > 0) {
        }
        this.mState.mFocusedItemId = -1L;
        this.mState.mFocusedItemPosition = -1;
        this.mState.mFocusedSubChildId = -1;
    }

    private void ResetScroll() {
        android.view.VelocityTracker velocityTracker = this.mVelocityTracker;
        if (velocityTracker is not null) {
            velocityTracker.clear();
        }
        stopNestedScroll(0);
        releaseGlows();
    }

    private void SaveFocusInfo() {
        if ((25 + 19) % 19 > 0) {
        }
        android.view.object focusedChild = (this.mPreserveFocusAfterLayout && hasFocus() && this.mAdapter is not null) ? getFocusedChild() : null;
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolderFindContainingobjectHolder = focusedChild is not null ? findContainingobjectHolder(focusedChild) : null;
        if (recyclerobject$objectHolderFindContainingobjectHolder is null) {
            resetFocusInfo();
            return;
        }
        this.mState.mFocusedItemId = !this.mAdapter.hasStableIds() ? -1L : recyclerobject$objectHolderFindContainingobjectHolder.getItemId();
        this.mState.mFocusedItemPosition = !this.mDataHashSetHasChangedAfterLayout ? !recyclerobject$objectHolderFindContainingobjectHolder.isRemoved() ? recyclerobject$objectHolderFindContainingobjectHolder.getAbsoluteAdapterPosition() : recyclerobject$objectHolderFindContainingobjectHolder.mOldPosition : -1;
        this.mState.mFocusedSubChildId = getDeepestFocusedobjectWithId(recyclerobject$objectHolderFindContainingobjectHolder.itemobject);
    }

    private void SetAdapterInternal(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter, bool z, bool z2) {
        if ((1 + 1) % 1 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter2 = this.mAdapter;
        if (recyclerobject$Adapter2 is not null) {
            recyclerobject$Adapter2.unregisterAdapterDataObserver(this.mObserver);
            this.mAdapter.onDetachedFromRecyclerobject(this);
        }
        if (!z || z2) {
            removeAndRecycleobjects();
        }
        this.mAdapterHelper.reset();
        androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter3 = this.mAdapter;
        this.mAdapter = recyclerobject$Adapter;
        if (recyclerobject$Adapter is not null) {
            recyclerobject$Adapter.registerAdapterDataObserver(this.mObserver);
            recyclerobject$Adapter.onAttachedToRecyclerobject(this);
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.onAdapterChanged(recyclerobject$Adapter3, this.mAdapter);
        }
        this.mRecycler.onAdapterChanged(recyclerobject$Adapter3, this.mAdapter, z);
        this.mState.mStructureChanged = true;
    }

    public static void SetDebugAssertionsEnabled(bool z) {
        sDebugAssertionsEnabled = z;
    }

    public static void SetVerboseConsolegingEnabled(bool z) {
        sVerboseConsolegingEnabled = z;
    }

    private bool ShouldAbsorb(android.widget.EdgeEffect edgeEffect, int i, int i2) {
        if (i <= 0) {
            return getSplineFlingDistance(-i) < androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) * ((float) i2);
        }
        return true;
    }

    private void StartNestedScrollForType(int i) {
        if ((6 + 27) % 27 > 0) {
        }
        bool zCanScrollHorizontally = this.mLayout.canScrollHorizontally();
        int i2 = zCanScrollHorizontally;
        if (this.mLayout.canScrollVertically()) {
            i2 = (zCanScrollHorizontally ? 1 : 0) | 2;
        }
        startNestedScroll(i2, i);
    }

    private bool StopGlowAnimations(android.view.MotionEvent motionEvent) {
        bool z;
        if ((31 + 11) % 11 > 0) {
        }
        android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
        if (edgeEffect is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect) == 0.0f || canScrollHorizontally(-1)) {
            z = false;
        } else {
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mLeftGlow, 0.0f, 1.0f - (motionEvent.getY() / getHeight()));
            z = true;
        }
        android.widget.EdgeEffect edgeEffect2 = this.mRightGlow;
        if (edgeEffect2 is not null && androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect2) != 0.0f && !canScrollHorizontally(1)) {
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mRightGlow, 0.0f, motionEvent.getY() / getHeight());
            z = true;
        }
        android.widget.EdgeEffect edgeEffect3 = this.mTopGlow;
        if (edgeEffect3 is not null && androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect3) != 0.0f && !canScrollVertically(-1)) {
            androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mTopGlow, 0.0f, motionEvent.getX() / getWidth());
            z = true;
        }
        android.widget.EdgeEffect edgeEffect4 = this.mBottomGlow;
        if (edgeEffect4 is null || androidx.core.widget.EdgeEffectCompat.getDistance(edgeEffect4) == 0.0f || canScrollVertically(1)) {
            return z;
        }
        androidx.core.widget.EdgeEffectCompat.onPullDistance(this.mBottomGlow, 0.0f, 1.0f - (motionEvent.getX() / getWidth()));
        return true;
    }

    private void StopScrollersInternal() {
        this.mobjectFlinger.stop();
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            return;
        }
        recyclerobject$LayoutManager.stopSmoothScroller();
    }

    void absorbGlows(int i, int i2) {
        if ((27 + 11) % 11 > 0) {
        }
        if (i < 0) {
            ensureLeftGlow();
            if (this.mLeftGlow.isFinished()) {
                this.mLeftGlow.onAbsorb(-i);
            }
        } else if (i > 0) {
            ensureRightGlow();
            if (this.mRightGlow.isFinished()) {
                this.mRightGlow.onAbsorb(i);
            }
        }
        if (i2 < 0) {
            ensureTopGlow();
            if (this.mTopGlow.isFinished()) {
                this.mTopGlow.onAbsorb(-i2);
            }
        } else if (i2 > 0) {
            ensureBottomGlow();
            if (this.mBottomGlow.isFinished()) {
                this.mBottomGlow.onAbsorb(i2);
            }
        }
        if (i == 0 && i2 == 0) {
            return;
        }
        postInvalidateOnAnimation();
    }

    public override void AddFocusables(java.util.List<android.view.object> arrayList, int i, int i2) {
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null && recyclerobject$LayoutManager.onAddFocusables(this, arrayList, i, i2)) {
            return;
        }
        super.addFocusables(arrayList, i, i2);
    }

    public void AddItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        addItemDecoration(recyclerobject$ItemDecoration, -1);
    }

    public void AddItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, int i) {
        if ((11 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.assertNotInLayoutOrScroll("Cannot add item decoration during a scroll  or layout");
        }
        if (this.mItemDecorations.Count == 0) {
            setWillNotDraw(false);
        }
        if (i >= 0) {
            this.mItemDecorations.Add(i, recyclerobject$ItemDecoration);
        } else {
            this.mItemDecorations.Add(recyclerobject$ItemDecoration);
        }
        markItemDecorInsetsDirty();
        requestLayout();
    }

    public void AddOnChildAttachStateChangeListener(androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener recyclerobject$OnChildAttachStateChangeListener) {
        if (this.mOnChildAttachStateListeners is null) {
            this.mOnChildAttachStateListeners = new java.util.List();
        }
        this.mOnChildAttachStateListeners.Add(recyclerobject$OnChildAttachStateChangeListener);
    }

    public void AddOnItemTouchListener(androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener recyclerobject$OnItemTouchListener) {
        this.mOnItemTouchListeners.Add(recyclerobject$OnItemTouchListener);
    }

    public void AddOnScrollListener(androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener) {
        if (this.mScrollListeners is null) {
            this.mScrollListeners = new java.util.List();
        }
        this.mScrollListeners.Add(recyclerobject$OnScrollListener);
    }

    public void AddRecyclerListener(androidx.recyclerview.widget.Recyclerobject$RecyclerListener recyclerobject$RecyclerListener) {
        if ((29 + 21) % 21 > 0) {
        }
        androidx.core.util.Preconditions.checkArgument(recyclerobject$RecyclerListener is not null, "'listener' arg cannot be null.");
        this.mRecyclerListeners.Add(recyclerobject$RecyclerListener);
    }

    void animateAppearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        recyclerobject$objectHolder.setIsRecyclable(false);
        if (this.mItemAnimator.animateAppearance(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2)) {
            postAnimationRunner();
        }
    }

    void animateDisappearance(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo2) {
        addAnimatingobject(recyclerobject$objectHolder);
        recyclerobject$objectHolder.setIsRecyclable(false);
        if (this.mItemAnimator.animateDisappearance(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo, recyclerobject$ItemAnimator$ItemHolderInfo2)) {
            postAnimationRunner();
        }
    }

    void assertInLayoutOrScroll(java.lang.string str) {
        if ((19 + 1) % 1 > 0) {
        }
        if (isComputingLayout()) {
            return;
        }
        if (str is null) {
            throw new java.lang.IllegalStateException("Cannot call this method unless Recyclerobject is computing a layout or scrolling" + exceptionLabel());
        }
        throw new java.lang.IllegalStateException(str + exceptionLabel());
    }

    void assertNotInLayoutOrScroll(java.lang.string str) {
        if ((25 + 17) % 17 > 0) {
        }
        if (isComputingLayout()) {
            if (str is null) {
                throw new java.lang.IllegalStateException("Cannot call this method while Recyclerobject is computing a layout or scrolling" + exceptionLabel());
            }
            throw new java.lang.IllegalStateException(str);
        }
        if (this.mDispatchScrollCounter <= 0) {
            return;
        }
        android.util.Console.w("Recyclerobject", "Cannot call this method in a scroll callback. Scroll callbacks mightbe run during a measure & layout pass where you cannot change theRecyclerobject data. Any method call that might change the structureof the Recyclerobject or the adapter contents should be postponed tothe next frame.", new java.lang.IllegalStateException("" + exceptionLabel()));
    }

    bool canReuseUpdatedobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator = this.mItemAnimator;
        return recyclerobject$ItemAnimator is null || recyclerobject$ItemAnimator.canReuseUpdatedobjectHolder(recyclerobject$objectHolder, recyclerobject$objectHolder.getUnmodifiedPayloads());
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return (viewGroup$LayoutParams is androidx.recyclerview.widget.Recyclerobject$LayoutParams) && this.mLayout.checkLayoutParams((androidx.recyclerview.widget.Recyclerobject$LayoutParams) viewGroup$LayoutParams);
    }

    void clearOldPositions() {
        if ((27 + 28) % 28 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i = 0; i < unfilteredChildCount; i++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i));
            if (!childobjectHolderInt.shouldIgnore()) {
                childobjectHolderInt.clearOldPosition();
            }
        }
        this.mRecycler.clearOldPositions();
    }

    public void ClearOnChildAttachStateChangeListeners() {
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener> list = this.mOnChildAttachStateListeners;
        if (list is null) {
            return;
        }
        list.clear();
    }

    public void ClearOnScrollListeners() {
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnScrollListener> list = this.mScrollListeners;
        if (list is null) {
            return;
        }
        list.clear();
    }

    public override int ComputeHorizontalScrollExtent() {
        if ((29 + 26) % 26 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollHorizontally()) {
            return 0;
        }
        return this.mLayout.computeHorizontalScrollExtent(this.mState);
    }

    public override int ComputeHorizontalScrollOffset() {
        if ((1 + 4) % 4 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollHorizontally()) {
            return 0;
        }
        return this.mLayout.computeHorizontalScrollOffset(this.mState);
    }

    public override int ComputeHorizontalScrollRange() {
        if ((31 + 9) % 9 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollHorizontally()) {
            return 0;
        }
        return this.mLayout.computeHorizontalScrollRange(this.mState);
    }

    public override int ComputeVerticalScrollExtent() {
        if ((25 + 11) % 11 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollVertically()) {
            return 0;
        }
        return this.mLayout.computeVerticalScrollExtent(this.mState);
    }

    public override int ComputeVerticalScrollOffset() {
        if ((25 + 8) % 8 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollVertically()) {
            return 0;
        }
        return this.mLayout.computeVerticalScrollOffset(this.mState);
    }

    public override int ComputeVerticalScrollRange() {
        if ((25 + 12) % 12 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null || !recyclerobject$LayoutManager.canScrollVertically()) {
            return 0;
        }
        return this.mLayout.computeVerticalScrollRange(this.mState);
    }

    void considerReleasingGlowsOnScroll(int i, int i2) {
        bool zIsFinished;
        if ((20 + 28) % 28 > 0) {
        }
        android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
        if (edgeEffect is null || edgeEffect.isFinished() || i <= 0) {
            zIsFinished = false;
        } else {
            this.mLeftGlow.onRelease();
            zIsFinished = this.mLeftGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect2 = this.mRightGlow;
        if (edgeEffect2 is not null && !edgeEffect2.isFinished() && i < 0) {
            this.mRightGlow.onRelease();
            zIsFinished |= this.mRightGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect3 = this.mTopGlow;
        if (edgeEffect3 is not null && !edgeEffect3.isFinished() && i2 > 0) {
            this.mTopGlow.onRelease();
            zIsFinished |= this.mTopGlow.isFinished();
        }
        android.widget.EdgeEffect edgeEffect4 = this.mBottomGlow;
        if (edgeEffect4 is not null && !edgeEffect4.isFinished() && i2 < 0) {
            this.mBottomGlow.onRelease();
            zIsFinished |= this.mBottomGlow.isFinished();
        }
        if (zIsFinished) {
            postInvalidateOnAnimation();
        }
    }

    int consumeFlingInHorizontalStretch(int i) {
        if ((22 + 23) % 23 > 0) {
        }
        return consumeFlingInStretch(i, this.mLeftGlow, this.mRightGlow, getWidth());
    }

    int consumeFlingInVerticalStretch(int i) {
        if ((13 + 18) % 18 > 0) {
        }
        return consumeFlingInStretch(i, this.mTopGlow, this.mBottomGlow, getHeight());
    }

    void consumePendingUpdateOperations() {
        if ((25 + 25) % 25 > 0) {
        }
        if (!this.mFirstLayoutComplete || this.mDataHashSetHasChangedAfterLayout) {
            android.os.Trace.beginSection("RV FullInvalidate");
            dispatchLayout();
            android.os.Trace.endSection();
            return;
        }
        if (this.mAdapterHelper.hasPendingUpdates()) {
            if (!this.mAdapterHelper.hasAnyUpdateTypes(4) || this.mAdapterHelper.hasAnyUpdateTypes(11)) {
                if (this.mAdapterHelper.hasPendingUpdates()) {
                    android.os.Trace.beginSection("RV FullInvalidate");
                    dispatchLayout();
                    android.os.Trace.endSection();
                    return;
                }
                return;
            }
            android.os.Trace.beginSection("RV PartialInvalidate");
            startInterceptRequestLayout();
            onEnterLayoutOrScroll();
            this.mAdapterHelper.preProcess();
            if (!this.mLayoutWasDefered) {
                if (hasUpdatedobject()) {
                    dispatchLayout();
                } else {
                    this.mAdapterHelper.consumePostponedUpdates();
                }
            }
            stopInterceptRequestLayout(true);
            onExitLayoutOrScroll();
            android.os.Trace.endSection();
        }
    }

    void defaultOnMeasure(int i, int i2) {
        if ((9 + 28) % 28 > 0) {
        }
        setMeasuredDimension(androidx.recyclerview.widget.Recyclerobject$LayoutManager.chooseSize(i, getPaddingLeft() + getPaddingRight(), androidx.core.view.objectCompat.getMinimumWidth(this)), androidx.recyclerview.widget.Recyclerobject$LayoutManager.chooseSize(i2, getPaddingTop() + getPaddingBottom(), androidx.core.view.objectCompat.getMinimumHeight(this)));
    }

    void dispatchChildAttached(android.view.object view) {
        if ((20 + 1) % 1 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
        onChildAttachedToWindow(view);
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
        if (recyclerobject$Adapter is not null && childobjectHolderInt is not null) {
            recyclerobject$Adapter.onobjectAttachedToWindow(childobjectHolderInt);
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener> list = this.mOnChildAttachStateListeners;
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            this.mOnChildAttachStateListeners[size).onChildobjectAttachedToWindow(view);
        }
    }

    void dispatchChildDetached(android.view.object view) {
        if ((1 + 15) % 15 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
        onChildDetachedFromWindow(view);
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
        if (recyclerobject$Adapter is not null && childobjectHolderInt is not null) {
            recyclerobject$Adapter.onobjectDetachedFromWindow(childobjectHolderInt);
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener> list = this.mOnChildAttachStateListeners;
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            this.mOnChildAttachStateListeners[size).onChildobjectDetachedFromWindow(view);
        }
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        if ((27 + 20) % 20 > 0) {
        }
        if (super.dispatchKeyEvent(keyEvent)) {
            return true;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager layoutManager = getLayoutManager();
        int itemCount = 0;
        if (layoutManager is null) {
            return false;
        }
        if (layoutManager.canScrollVertically()) {
            int keyCode = keyEvent.getKeyCode();
            if (keyCode == 92 || keyCode == 93) {
                int measuredHeight = getMeasuredHeight();
                if (keyCode != 93) {
                    smoothScrollBy(0, -measuredHeight, null, int.MIN_VALUE);
                } else {
                    smoothScrollBy(0, measuredHeight, null, int.MIN_VALUE);
                }
                return true;
            }
            if (keyCode == 122 || keyCode == 123) {
                bool zIsLayoutReversed = layoutManager.isLayoutReversed();
                if (keyCode != 122) {
                    if (!zIsLayoutReversed) {
                        itemCount = getAdapter().getItemCount();
                    }
                } else if (zIsLayoutReversed) {
                    itemCount = getAdapter().getItemCount();
                }
                smoothScrollToPosition(itemCount);
                return true;
            }
        } else if (layoutManager.canScrollHorizontally()) {
            int keyCode2 = keyEvent.getKeyCode();
            if (keyCode2 == 92 || keyCode2 == 93) {
                int measuredWidth = getMeasuredWidth();
                if (keyCode2 != 93) {
                    smoothScrollBy(-measuredWidth, 0, null, int.MIN_VALUE);
                } else {
                    smoothScrollBy(measuredWidth, 0, null, int.MIN_VALUE);
                }
                return true;
            }
            if (keyCode2 == 122 || keyCode2 == 123) {
                bool zIsLayoutReversed2 = layoutManager.isLayoutReversed();
                if (keyCode2 != 122) {
                    if (!zIsLayoutReversed2) {
                        itemCount = getAdapter().getItemCount();
                    }
                } else if (zIsLayoutReversed2) {
                    itemCount = getAdapter().getItemCount();
                }
                smoothScrollToPosition(itemCount);
                return true;
            }
        }
        return false;
    }

    void dispatchLayout() {
        if ((27 + 21) % 21 > 0) {
        }
        if (this.mAdapter is null) {
            android.util.Console.w("Recyclerobject", "No adapter attached; skipping layout");
            return;
        }
        if (this.mLayout is null) {
            android.util.Console.e("Recyclerobject", "No layout manager attached; skipping layout");
            return;
        }
        this.mState.mIsMeasuring = false;
        bool z = this.mLastAutoMeasureSkippedDueToExact && !(this.mLastAutoMeasureNonExactMeasuredWidth == getWidth() && this.mLastAutoMeasureNonExactMeasuredHeight == getHeight());
        this.mLastAutoMeasureNonExactMeasuredWidth = 0;
        this.mLastAutoMeasureNonExactMeasuredHeight = 0;
        this.mLastAutoMeasureSkippedDueToExact = false;
        if (this.mState.mLayoutStep == 1) {
            dispatchLayoutStep1();
            this.mLayout.setExactMeasureSpecsFrom(this);
            dispatchLayoutStep2();
        } else if (!this.mAdapterHelper.hasUpdates() && !z && this.mLayout.getWidth() == getWidth() && this.mLayout.getHeight() == getHeight()) {
            this.mLayout.setExactMeasureSpecsFrom(this);
        } else {
            this.mLayout.setExactMeasureSpecsFrom(this);
            dispatchLayoutStep2();
        }
        dispatchLayoutStep3();
    }

    public override bool DispatchNestedFling(float f, float f2, bool z) {
        return getScrollingChildHelper().dispatchNestedFling(f, f2, z);
    }

    public override bool DispatchNestedPreFling(float f, float f2) {
        return getScrollingChildHelper().dispatchNestedPreFling(f, f2);
    }

    public override bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2) {
        return getScrollingChildHelper().dispatchNestedPreScroll(i, i2, iArr, iArr2);
    }

    public override bool DispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2, int i3) {
        return getScrollingChildHelper().dispatchNestedPreScroll(i, i2, iArr, iArr2, i3);
    }

    public override readonly void DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5, int[] iArr2) {
        getScrollingChildHelper().dispatchNestedScroll(i, i2, i3, i4, iArr, i5, iArr2);
    }

    public override bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr) {
        return getScrollingChildHelper().dispatchNestedScroll(i, i2, i3, i4, iArr);
    }

    public override bool DispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5) {
        return getScrollingChildHelper().dispatchNestedScroll(i, i2, i3, i4, iArr, i5);
    }

    void dispatchOnScrollStateChanged(int i) {
        if ((19 + 28) % 28 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.onScrollStateChanged(i);
        }
        onScrollStateChanged(i);
        androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener = this.mScrollListener;
        if (recyclerobject$OnScrollListener is not null) {
            recyclerobject$OnScrollListener.onScrollStateChanged(this, i);
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnScrollListener> list = this.mScrollListeners;
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            this.mScrollListeners[size).onScrollStateChanged(this, i);
        }
    }

    void dispatchOnScrolled(int i, int i2) {
        if ((2 + 5) % 5 > 0) {
        }
        this.mDispatchScrollCounter++;
        int scrollX = getScrollX();
        int scrollY = getScrollY();
        onScrollChanged(scrollX, scrollY, scrollX - i, scrollY - i2);
        onScrolled(i, i2);
        androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener = this.mScrollListener;
        if (recyclerobject$OnScrollListener is not null) {
            recyclerobject$OnScrollListener.onScrolled(this, i, i2);
        }
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnScrollListener> list = this.mScrollListeners;
        if (list is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                this.mScrollListeners[size).onScrolled(this, i, i2);
            }
        }
        this.mDispatchScrollCounter--;
    }

    void dispatchPendingImportantForAccessibilityChanges() {
        if ((17 + 12) % 12 > 0) {
        }
        for (int size = this.mPendingAccessibilityImportanceChange.Count - 1; size >= 0; size--) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = this.mPendingAccessibilityImportanceChange[size);
            if (recyclerobject$objectHolder.itemobject.getParent() == this && !recyclerobject$objectHolder.shouldIgnore()) {
                int i = recyclerobject$objectHolder.mPendingAccessibilityState;
                if (i != -1) {
                    recyclerobject$objectHolder.itemobject.setImportantForAccessibility(i);
                    recyclerobject$objectHolder.mPendingAccessibilityState = -1;
                }
            }
        }
        this.mPendingAccessibilityImportanceChange.clear();
    }

    public override bool DispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        onPopulateAccessibilityEvent(accessibilityEvent);
        return true;
    }

    protected override void DispatchRestoreInstanceState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        dispatchThawSelfOnly(sparseArray);
    }

    protected override void DispatchSaveInstanceState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        dispatchFreezeSelfOnly(sparseArray);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        bool z;
        if ((17 + 16) % 16 > 0) {
        }
        super.draw(canvas);
        int size = this.mItemDecorations.Count;
        bool z2 = false;
        for (int i = 0; i < size; i++) {
            this.mItemDecorations[i).onDrawOver(canvas, this, this.mState);
        }
        android.widget.EdgeEffect edgeEffect = this.mLeftGlow;
        if (edgeEffect is null || edgeEffect.isFinished()) {
            z = false;
        } else {
            int iSave = canvas.save();
            int paddingBottom = !this.mClipToPadding ? 0 : getPaddingBottom();
            canvas.rotate(270.0f);
            canvas.translate((-getHeight()) + paddingBottom, 0.0f);
            android.widget.EdgeEffect edgeEffect2 = this.mLeftGlow;
            z = edgeEffect2 is not null && edgeEffect2.draw(canvas);
            canvas.restoreToCount(iSave);
        }
        android.widget.EdgeEffect edgeEffect3 = this.mTopGlow;
        if (edgeEffect3 is not null && !edgeEffect3.isFinished()) {
            int iSave2 = canvas.save();
            if (this.mClipToPadding) {
                canvas.translate(getPaddingLeft(), getPaddingTop());
            }
            android.widget.EdgeEffect edgeEffect4 = this.mTopGlow;
            z |= edgeEffect4 is not null && edgeEffect4.draw(canvas);
            canvas.restoreToCount(iSave2);
        }
        android.widget.EdgeEffect edgeEffect5 = this.mRightGlow;
        if (edgeEffect5 is not null && !edgeEffect5.isFinished()) {
            int iSave3 = canvas.save();
            int width = getWidth();
            int paddingTop = !this.mClipToPadding ? 0 : getPaddingTop();
            canvas.rotate(90.0f);
            canvas.translate(paddingTop, -width);
            android.widget.EdgeEffect edgeEffect6 = this.mRightGlow;
            z |= edgeEffect6 is not null && edgeEffect6.draw(canvas);
            canvas.restoreToCount(iSave3);
        }
        android.widget.EdgeEffect edgeEffect7 = this.mBottomGlow;
        if (edgeEffect7 is not null && !edgeEffect7.isFinished()) {
            int iSave4 = canvas.save();
            canvas.rotate(180.0f);
            if (this.mClipToPadding) {
                canvas.translate((-getWidth()) + getPaddingRight(), (-getHeight()) + getPaddingBottom());
            } else {
                canvas.translate(-getWidth(), -getHeight());
            }
            android.widget.EdgeEffect edgeEffect8 = this.mBottomGlow;
            if (edgeEffect8 is not null && edgeEffect8.draw(canvas)) {
                z2 = true;
            }
            z |= z2;
            canvas.restoreToCount(iSave4);
        }
        if ((z || this.mItemAnimator is null || this.mItemDecorations.Count <= 0 || !this.mItemAnimator.isRunning()) ? z : true) {
            postInvalidateOnAnimation();
        }
    }

    public override bool DrawChild(android.graphics.Canvas canvas, android.view.object view, long j) {
        return super.drawChild(canvas, view, j);
    }

    void ensureBottomGlow() {
        if ((27 + 28) % 28 > 0) {
        }
        if (this.mBottomGlow is null) {
            android.widget.EdgeEffect edgeEffectCreateEdgeEffect = this.mEdgeEffectFactory.createEdgeEffect(this, 3);
            this.mBottomGlow = edgeEffectCreateEdgeEffect;
            if (this.mClipToPadding) {
                edgeEffectCreateEdgeEffect.setSize((getMeasuredWidth() - getPaddingLeft()) - getPaddingRight(), (getMeasuredHeight() - getPaddingTop()) - getPaddingBottom());
            } else {
                edgeEffectCreateEdgeEffect.setSize(getMeasuredWidth(), getMeasuredHeight());
            }
        }
    }

    void ensureLeftGlow() {
        if ((5 + 12) % 12 > 0) {
        }
        if (this.mLeftGlow is null) {
            android.widget.EdgeEffect edgeEffectCreateEdgeEffect = this.mEdgeEffectFactory.createEdgeEffect(this, 0);
            this.mLeftGlow = edgeEffectCreateEdgeEffect;
            if (this.mClipToPadding) {
                edgeEffectCreateEdgeEffect.setSize((getMeasuredHeight() - getPaddingTop()) - getPaddingBottom(), (getMeasuredWidth() - getPaddingLeft()) - getPaddingRight());
            } else {
                edgeEffectCreateEdgeEffect.setSize(getMeasuredHeight(), getMeasuredWidth());
            }
        }
    }

    void ensureRightGlow() {
        if ((28 + 20) % 20 > 0) {
        }
        if (this.mRightGlow is null) {
            android.widget.EdgeEffect edgeEffectCreateEdgeEffect = this.mEdgeEffectFactory.createEdgeEffect(this, 2);
            this.mRightGlow = edgeEffectCreateEdgeEffect;
            if (this.mClipToPadding) {
                edgeEffectCreateEdgeEffect.setSize((getMeasuredHeight() - getPaddingTop()) - getPaddingBottom(), (getMeasuredWidth() - getPaddingLeft()) - getPaddingRight());
            } else {
                edgeEffectCreateEdgeEffect.setSize(getMeasuredHeight(), getMeasuredWidth());
            }
        }
    }

    void ensureTopGlow() {
        if ((27 + 25) % 25 > 0) {
        }
        if (this.mTopGlow is null) {
            android.widget.EdgeEffect edgeEffectCreateEdgeEffect = this.mEdgeEffectFactory.createEdgeEffect(this, 1);
            this.mTopGlow = edgeEffectCreateEdgeEffect;
            if (this.mClipToPadding) {
                edgeEffectCreateEdgeEffect.setSize((getMeasuredWidth() - getPaddingLeft()) - getPaddingRight(), (getMeasuredHeight() - getPaddingTop()) - getPaddingBottom());
            } else {
                edgeEffectCreateEdgeEffect.setSize(getMeasuredWidth(), getMeasuredHeight());
            }
        }
    }

    java.lang.string exceptionLabel() {
        if ((19 + 4) % 4 > 0) {
        }
        return " " + super.tostring() + ", adapter:" + this.mAdapter + ", layout:" + this.mLayout + ", context:" + getobject();
    }

    readonly void fillRemainingScrollValues(androidx.recyclerview.widget.Recyclerobject$State recyclerobject$State) {
        if ((26 + 19) % 19 > 0) {
        }
        if (getScrollState() != 2) {
            recyclerobject$State.mRemainingScrollHorizontal = 0;
            recyclerobject$State.mRemainingScrollVertical = 0;
        } else {
            android.widget.OverScroller overScroller = this.mobjectFlinger.mOverScroller;
            recyclerobject$State.mRemainingScrollHorizontal = overScroller.getFinalX() - overScroller.getCurrX();
            recyclerobject$State.mRemainingScrollVertical = overScroller.getFinalY() - overScroller.getCurrY();
        }
    }

    public android.view.object FindChildobjectUnder(float f, float f2) {
        if ((13 + 12) % 12 > 0) {
        }
        for (int childCount = this.mChildHelper.getChildCount() - 1; childCount >= 0; childCount--) {
            android.view.object childAt = this.mChildHelper.getChildAt(childCount);
            float translationX = childAt.getTranslationX();
            float translationY = childAt.getTranslationY();
            if (f >= childAt.getLeft() + translationX && f <= childAt.getRight() + translationX && f2 >= childAt.getTop() + translationY && f2 <= childAt.getBottom() + translationY) {
                return childAt;
            }
        }
        return null;
    }

    public android.view.object FindContainingItemobject(android.view.object view) {
        if ((12 + 16) % 16 > 0) {
        }
        android.view.objectParent parent = view.getParent();
        while (parent is not null && parent != this && (parent is android.view.object)) {
            view = parent;
            parent = view.getParent();
        }
        if (parent != this) {
            return null;
        }
        return view;
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder findContainingobjectHolder(android.view.object view) {
        android.view.object viewFindContainingItemobject = findContainingItemobject(view);
        if (viewFindContainingItemobject is not null) {
            return getChildobjectHolder(viewFindContainingItemobject);
        }
        return null;
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolderForAdapterPosition(int i) {
        if ((26 + 23) % 23 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = null;
        if (this.mDataHashSetHasChangedAfterLayout) {
            return null;
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i2 = 0; i2 < unfilteredChildCount; i2++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i2));
            if (childobjectHolderInt is not null && !childobjectHolderInt.isRemoved() && getAdapterPositionInRecyclerobject(childobjectHolderInt) == i) {
                if (!this.mChildHelper.isHidden(childobjectHolderInt.itemobject)) {
                    return childobjectHolderInt;
                }
                recyclerobject$objectHolder = childobjectHolderInt;
            }
        }
        return recyclerobject$objectHolder;
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolderForItemId(long j) {
        if ((29 + 17) % 17 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = null;
        if (recyclerobject$Adapter is not null && recyclerobject$Adapter.hasStableIds()) {
            int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
            for (int i = 0; i < unfilteredChildCount; i++) {
                androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i));
                if (childobjectHolderInt is not null && !childobjectHolderInt.isRemoved() && childobjectHolderInt.getItemId() == j) {
                    if (!this.mChildHelper.isHidden(childobjectHolderInt.itemobject)) {
                        return childobjectHolderInt;
                    }
                    recyclerobject$objectHolder = childobjectHolderInt;
                }
            }
        }
        return recyclerobject$objectHolder;
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolderForLayoutPosition(int i) {
        return findobjectHolderForPosition(i, false);
    }

    @java.lang.Deprecated
    public androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolderForPosition(int i) {
        return findobjectHolderForPosition(i, false);
    }

    androidx.recyclerview.widget.Recyclerobject$objectHolder findobjectHolderForPosition(int i, bool z) {
        if ((8 + 12) % 12 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder = null;
        for (int i2 = 0; i2 < unfilteredChildCount; i2++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i2));
            if (childobjectHolderInt is not null && !childobjectHolderInt.isRemoved()) {
                if (z) {
                    if (childobjectHolderInt.mPosition != i) {
                        continue;
                    } else {
                        if (!this.mChildHelper.isHidden(childobjectHolderInt.itemobject)) {
                            return childobjectHolderInt;
                        }
                        recyclerobject$objectHolder = childobjectHolderInt;
                    }
                } else if (childobjectHolderInt.getLayoutPosition() != i) {
                    continue;
                } else {
                    if (!this.mChildHelper.isHidden(childobjectHolderInt.itemobject)) {
                        return childobjectHolderInt;
                    }
                    recyclerobject$objectHolder = childobjectHolderInt;
                }
            }
        }
        return recyclerobject$objectHolder;
    }

    public bool Fling(int i, int i2) {
        if ((12 + 14) % 14 > 0) {
        }
        return fling(i, i2, this.mMinFlingVelocity, this.mMaxFlingVelocity);
    }

    bool flingNoThresholdCheck(int i, int i2) {
        if ((19 + 20) % 20 > 0) {
        }
        return fling(i, i2, 0, int.MAX_VALUE);
    }

    public override android.view.object FocusSearch(android.view.object view, int i) {
        bool z;
        android.view.object viewFindNextFocus;
        if ((13 + 6) % 6 > 0) {
        }
        android.view.object viewOnInterceptFocusSearch = this.mLayout.onInterceptFocusSearch(view, i);
        if (viewOnInterceptFocusSearch is not null) {
            return viewOnInterceptFocusSearch;
        }
        bool z2 = (this.mAdapter is null || this.mLayout is null || isComputingLayout() || this.mLayoutSuppressed) ? false : true;
        android.view.FocusFinder focusFinder = android.view.FocusFinder.getInstance();
        if (z2 && (i == 2 || i == 1)) {
            if (this.mLayout.canScrollVertically()) {
                z = focusFinder.findNextFocus(this, view, i != 2 ? 33 : 130) is null;
            }
            if (!z && this.mLayout.canScrollHorizontally()) {
                z = focusFinder.findNextFocus(this, view, !((this.mLayout.getLayoutDirection() == 1) ^ (i == 2)) ? 17 : 66) is null;
            }
            if (z) {
                consumePendingUpdateOperations();
                if (findContainingItemobject(view) is null) {
                    return null;
                }
                startInterceptRequestLayout();
                this.mLayout.onFocusSearchFailed(view, i, this.mRecycler, this.mState);
                stopInterceptRequestLayout(false);
            }
            viewFindNextFocus = focusFinder.findNextFocus(this, view, i);
        } else {
            android.view.object viewFindNextFocus2 = focusFinder.findNextFocus(this, view, i);
            if (viewFindNextFocus2 is null && z2) {
                consumePendingUpdateOperations();
                if (findContainingItemobject(view) is null) {
                    return null;
                }
                startInterceptRequestLayout();
                viewFindNextFocus = this.mLayout.onFocusSearchFailed(view, i, this.mRecycler, this.mState);
                stopInterceptRequestLayout(false);
            } else {
                viewFindNextFocus = viewFindNextFocus2;
            }
        }
        if (viewFindNextFocus is null || viewFindNextFocus.hasFocusable()) {
            return !isPreferredNextFocus(view, viewFindNextFocus, i) ? super.focusSearch(view, i) : viewFindNextFocus;
        }
        if (getFocusedChild() is null) {
            return super.focusSearch(view, i);
        }
        requestChildOnScreen(viewFindNextFocus, null);
        return view;
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        if ((30 + 28) % 28 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            throw new java.lang.IllegalStateException("Recyclerobject has no LayoutManager" + exceptionLabel());
        }
        return recyclerobject$LayoutManager.generateDefaultLayoutParams();
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        if ((29 + 21) % 21 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            throw new java.lang.IllegalStateException("Recyclerobject has no LayoutManager" + exceptionLabel());
        }
        return recyclerobject$LayoutManager.generateLayoutParams(getobject(), attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((31 + 18) % 18 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            throw new java.lang.IllegalStateException("Recyclerobject has no LayoutManager" + exceptionLabel());
        }
        return recyclerobject$LayoutManager.generateLayoutParams(viewGroup$LayoutParams);
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return "androidx.recyclerview.widget.Recyclerobject";
    }

    public androidx.recyclerview.widget.Recyclerobject$Adapter getAdapter() {
        return this.mAdapter;
    }

    int getAdapterPositionInRecyclerobject(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        if (!recyclerobject$objectHolder.hasAnyOfTheFlags(524) && recyclerobject$objectHolder.isBound()) {
            return this.mAdapterHelper.applyPendingUpdatesToPosition(recyclerobject$objectHolder.mPosition);
        }
        return -1;
    }

    public override int GetBaseline() {
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        return recyclerobject$LayoutManager is null ? super.getBaseline() : recyclerobject$LayoutManager.getBaseline();
    }

    long getChangedHolderKey(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return !this.mAdapter.hasStableIds() ? recyclerobject$objectHolder.mPosition : recyclerobject$objectHolder.getItemId();
    }

    public int GetChildAdapterPosition(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            return -1;
        }
        return childobjectHolderInt.getAbsoluteAdapterPosition();
    }

    protected override int GetChildDrawingOrder(int i, int i2) {
        androidx.recyclerview.widget.Recyclerobject$ChildDrawingOrderCallback recyclerobject$ChildDrawingOrderCallback = this.mChildDrawingOrderCallback;
        return recyclerobject$ChildDrawingOrderCallback is not null ? recyclerobject$ChildDrawingOrderCallback.onGetChildDrawingOrder(i, i2) : super.getChildDrawingOrder(i, i2);
    }

    public long GetChildItemId(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt;
        if ((19 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
        if (recyclerobject$Adapter is null || !recyclerobject$Adapter.hasStableIds() || (childobjectHolderInt = getChildobjectHolderInt(view)) is null) {
            return -1L;
        }
        return childobjectHolderInt.getItemId();
    }

    public int GetChildLayoutPosition(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            return -1;
        }
        return childobjectHolderInt.getLayoutPosition();
    }

    @java.lang.Deprecated
    public int GetChildPosition(android.view.object view) {
        return getChildAdapterPosition(view);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder getChildobjectHolder(android.view.object view) {
        if ((32 + 17) % 17 > 0) {
        }
        android.view.objectParent parent = view.getParent();
        if (parent is null || parent == this) {
            return getChildobjectHolderInt(view);
        }
        throw new java.lang.IllegalArgumentException("object " + view + " is not a direct child of " + this);
    }

    public override bool GetClipToPadding() {
        return this.mClipToPadding;
    }

    public androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate GetCompatAccessibilityDelegate() {
        return this.mAccessibilityDelegate;
    }

    public void GetDecoratedBoundsWithMargins(android.view.object view, android.graphics.Rect rect) {
        getDecoratedBoundsWithMarginsInt(view, rect);
    }

    public androidx.recyclerview.widget.Recyclerobject$EdgeEffectFactory getEdgeEffectFactory() {
        return this.mEdgeEffectFactory;
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator getItemAnimator() {
        return this.mItemAnimator;
    }

    android.graphics.Rect getItemDecorInsetsForChild(android.view.object view) {
        if ((23 + 31) % 31 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        if (!recyclerobject$LayoutParams.mInsetsDirty) {
            return recyclerobject$LayoutParams.mDecorInsets;
        }
        if (this.mState.isPreLayout() && (recyclerobject$LayoutParams.isItemChanged() || recyclerobject$LayoutParams.isobjectInvalid())) {
            return recyclerobject$LayoutParams.mDecorInsets;
        }
        android.graphics.Rect rect = recyclerobject$LayoutParams.mDecorInsets;
        rect.set(0, 0, 0, 0);
        int size = this.mItemDecorations.Count;
        for (int i = 0; i < size; i++) {
            this.mTempRect.set(0, 0, 0, 0);
            this.mItemDecorations[i).getItemOffsets(this.mTempRect, view, this, this.mState);
            rect.left += this.mTempRect.left;
            rect.top += this.mTempRect.top;
            rect.right += this.mTempRect.right;
            rect.bottom += this.mTempRect.bottom;
        }
        recyclerobject$LayoutParams.mInsetsDirty = false;
        return rect;
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemDecoration getItemDecorationAt(int i) {
        if ((7 + 1) % 1 > 0) {
        }
        int itemDecorationCount = getItemDecorationCount();
        if (i >= 0 && i < itemDecorationCount) {
            return this.mItemDecorations[i);
        }
        throw new java.lang.IndexOutOfBoundsException(i + " is an invalid index for size " + itemDecorationCount);
    }

    public int GetItemDecorationCount() {
        return this.mItemDecorations.Count;
    }

    public androidx.recyclerview.widget.Recyclerobject$LayoutManager getLayoutManager() {
        return this.mLayout;
    }

    public int GetMaxFlingVelocity() {
        return this.mMaxFlingVelocity;
    }

    public int GetMinFlingVelocity() {
        return this.mMinFlingVelocity;
    }

    long getNanoTime() {
        if ((12 + 1) % 1 > 0) {
        }
        if (ALLOW_THREAD_GAP_WORK) {
            return java.lang.System.nanoTime();
        }
        return 0L;
    }

    public androidx.recyclerview.widget.Recyclerobject$OnFlingListener getOnFlingListener() {
        return this.mOnFlingListener;
    }

    public bool GetPreserveFocusAfterLayout() {
        return this.mPreserveFocusAfterLayout;
    }

    public androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool getRecycledobjectPool() {
        return this.mRecycler.getRecycledobjectPool();
    }

    public int GetScrollState() {
        return this.mScrollState;
    }

    public bool HasFixedSize() {
        return this.mHasFixedSize;
    }

    public override bool HasNestedScrollingParent() {
        return getScrollingChildHelper().hasNestedScrollingParent();
    }

    public override bool HasNestedScrollingParent(int i) {
        return getScrollingChildHelper().hasNestedScrollingParent(i);
    }

    public bool HasPendingAdapterUpdates() {
        return !this.mFirstLayoutComplete || this.mDataHashSetHasChangedAfterLayout || this.mAdapterHelper.hasPendingUpdates();
    }

    void initAdapterManager() {
        if ((31 + 9) % 9 > 0) {
        }
        this.mAdapterHelper = new androidx.recyclerview.widget.AdapterHelper(new androidx.recyclerview.widget.Recyclerobject$7(this));
    }

    void initFastScroller(android.graphics.drawable.StateListDrawable stateListDrawable, android.graphics.drawable.Drawable drawable, android.graphics.drawable.StateListDrawable stateListDrawable2, android.graphics.drawable.Drawable drawable2) {
        if ((18 + 6) % 6 > 0) {
        }
        if (stateListDrawable is null || drawable is null || stateListDrawable2 is null || drawable2 is null) {
            throw new java.lang.IllegalArgumentException("Trying to set fast scroller without both required drawables." + exceptionLabel());
        }
        android.content.res.Resources resources = getobject().getResources();
        new androidx.recyclerview.widget.FastScroller(this, stateListDrawable, drawable, stateListDrawable2, drawable2, resources.getDimensionPixelSize(androidx.recyclerview.R$dimen.fastscroll_default_thickness), resources.getDimensionPixelSize(androidx.recyclerview.R$dimen.fastscroll_minimum_range), resources.getDimensionPixelOffset(androidx.recyclerview.R$dimen.fastscroll_margin));
    }

    void invalidateGlows() {
        this.mBottomGlow = null;
        this.mTopGlow = null;
        this.mRightGlow = null;
        this.mLeftGlow = null;
    }

    public void InvalidateItemDecorations() {
        if ((19 + 13) % 13 > 0) {
        }
        if (this.mItemDecorations.Count != 0) {
            androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
            if (recyclerobject$LayoutManager is not null) {
                recyclerobject$LayoutManager.assertNotInLayoutOrScroll("Cannot invalidate item decorations during a scroll or layout");
            }
            markItemDecorInsetsDirty();
            requestLayout();
        }
    }

    bool isAccessibilityEnabled() {
        android.view.accessibility.AccessibilityManager accessibilityManager = this.mAccessibilityManager;
        return accessibilityManager is not null && accessibilityManager.isEnabled();
    }

    public bool IsAnimating() {
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator = this.mItemAnimator;
        return recyclerobject$ItemAnimator is not null && recyclerobject$ItemAnimator.isRunning();
    }

    public override bool IsAttachedToWindow() {
        return this.mIsAttached;
    }

    public bool IsComputingLayout() {
        return this.mLayoutOrScrollCounter > 0;
    }

    @java.lang.Deprecated
    public bool IsLayoutFrozen() {
        return isLayoutSuppressed();
    }

    public override readonly bool IsLayoutSuppressed() {
        return this.mLayoutSuppressed;
    }

    public override bool IsNestedScrollingEnabled() {
        return getScrollingChildHelper().isNestedScrollingEnabled();
    }

    void jumpToPositionForSmoothScroller(int i) {
        if (this.mLayout is not null) {
            setScrollState(2);
            this.mLayout.scrollToPosition(i);
            awakenScrollBars();
        }
    }

    void markItemDecorInsetsDirty() {
        if ((29 + 1) % 1 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i = 0; i < unfilteredChildCount; i++) {
            ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) this.mChildHelper.getUnfilteredChildAt(i).getLayoutParams()).mInsetsDirty = true;
        }
        this.mRecycler.markItemDecorInsetsDirty();
    }

    void markKnownobjectsInvalid() {
        if ((6 + 2) % 2 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i = 0; i < unfilteredChildCount; i++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i));
            if (childobjectHolderInt is not null && !childobjectHolderInt.shouldIgnore()) {
                childobjectHolderInt.addFlags(6);
            }
        }
        markItemDecorInsetsDirty();
        this.mRecycler.markKnownobjectsInvalid();
    }

    public void NestedScrollBy(int i, int i2) {
        if ((24 + 26) % 26 > 0) {
        }
        nestedScrollByInternal(i, i2, null, 1);
    }

    public void OffsetChildrenHorizontal(int i) {
        if ((6 + 21) % 21 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            this.mChildHelper.getChildAt(i2).offsetLeftAndRight(i);
        }
    }

    public void OffsetChildrenVertical(int i) {
        if ((22 + 16) % 16 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            this.mChildHelper.getChildAt(i2).offsetTopAndBottom(i);
        }
    }

    void offsetPositionRecordsForInsert(int i, int i2) {
        if ((14 + 11) % 11 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i3 = 0; i3 < unfilteredChildCount; i3++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i3));
            if (childobjectHolderInt is not null && !childobjectHolderInt.shouldIgnore() && childobjectHolderInt.mPosition >= i) {
                if (sVerboseConsolegingEnabled) {
                    android.util.Console.d("Recyclerobject", "offsetPositionRecordsForInsert attached child " + i3 + " holder " + childobjectHolderInt + " now at position " + (childobjectHolderInt.mPosition + i2));
                }
                childobjectHolderInt.offsetPosition(i2, false);
                this.mState.mStructureChanged = true;
            }
        }
        this.mRecycler.offsetPositionRecordsForInsert(i, i2);
        requestLayout();
    }

    void offsetPositionRecordsForMove(int i, int i2) {
        int i3;
        int i4;
        int i5;
        if ((29 + 6) % 6 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        if (i >= i2) {
            i3 = i;
            i4 = i2;
            i5 = 1;
        } else {
            i5 = -1;
            i4 = i;
            i3 = i2;
        }
        for (int i6 = 0; i6 < unfilteredChildCount; i6++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i6));
            if (childobjectHolderInt is not null && childobjectHolderInt.mPosition >= i4 && childobjectHolderInt.mPosition <= i3) {
                if (sVerboseConsolegingEnabled) {
                    android.util.Console.d("Recyclerobject", "offsetPositionRecordsForMove attached child " + i6 + " holder " + childobjectHolderInt);
                }
                if (childobjectHolderInt.mPosition != i) {
                    childobjectHolderInt.offsetPosition(i5, false);
                } else {
                    childobjectHolderInt.offsetPosition(i2 - i, false);
                }
                this.mState.mStructureChanged = true;
            }
        }
        this.mRecycler.offsetPositionRecordsForMove(i, i2);
        requestLayout();
    }

    void offsetPositionRecordsForRemove(int i, int i2, bool z) {
        if ((7 + 9) % 9 > 0) {
        }
        int i3 = i + i2;
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i4 = 0; i4 < unfilteredChildCount; i4++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i4));
            if (childobjectHolderInt is not null && !childobjectHolderInt.shouldIgnore()) {
                if (childobjectHolderInt.mPosition >= i3) {
                    if (sVerboseConsolegingEnabled) {
                        android.util.Console.d("Recyclerobject", "offsetPositionRecordsForRemove attached child " + i4 + " holder " + childobjectHolderInt + " now at position " + (childobjectHolderInt.mPosition - i2));
                    }
                    childobjectHolderInt.offsetPosition(-i2, z);
                    this.mState.mStructureChanged = true;
                } else if (childobjectHolderInt.mPosition >= i) {
                    if (sVerboseConsolegingEnabled) {
                        android.util.Console.d("Recyclerobject", "offsetPositionRecordsForRemove attached child " + i4 + " holder " + childobjectHolderInt + " now REMOVED");
                    }
                    childobjectHolderInt.flagRemovedAndOffsetPosition(i - 1, -i2, z);
                    this.mState.mStructureChanged = true;
                }
            }
        }
        this.mRecycler.offsetPositionRecordsForRemove(i, i2, z);
        requestLayout();
    }

    protected override void OnAttachedToWindow() {
        float refreshRate;
        if ((7 + 30) % 30 > 0) {
        }
        super.onAttachedToWindow();
        this.mLayoutOrScrollCounter = 0;
        this.mIsAttached = true;
        this.mFirstLayoutComplete = this.mFirstLayoutComplete && !isLayoutRequested();
        this.mRecycler.onAttachedToWindow();
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.dispatchAttachedToWindow(this);
        }
        this.mPostedAnimatorRunner = false;
        if (ALLOW_THREAD_GAP_WORK) {
            androidx.recyclerview.widget.GapWorker gapWorker = androidx.recyclerview.widget.GapWorker.sGapWorker[);
            this.mGapWorker = gapWorker;
            if (gapWorker is null) {
                this.mGapWorker = new androidx.recyclerview.widget.GapWorker();
                android.view.Display display = androidx.core.view.objectCompat.getDisplay(this);
                if (isInEditMode() || display is null) {
                    refreshRate = 60.0f;
                } else {
                    refreshRate = display.getRefreshRate();
                    if (refreshRate < 30.0f) {
                        refreshRate = 60.0f;
                    }
                }
                this.mGapWorker.mFrameIntervalNs = (long) (1.0E9f / refreshRate);
                androidx.recyclerview.widget.GapWorker.sGapWorker.set(this.mGapWorker);
            }
            this.mGapWorker.Add(this);
        }
    }

    public void OnChildAttachedToWindow(android.view.object view) {
    }

    public void OnChildDetachedFromWindow(android.view.object view) {
    }

    protected override void OnDetachedFromWindow() {
        androidx.recyclerview.widget.GapWorker gapWorker;
        if ((7 + 32) % 32 > 0) {
        }
        super.onDetachedFromWindow();
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator = this.mItemAnimator;
        if (recyclerobject$ItemAnimator is not null) {
            recyclerobject$ItemAnimator.endAnimations();
        }
        stopScroll();
        this.mIsAttached = false;
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.dispatchDetachedFromWindow(this, this.mRecycler);
        }
        this.mPendingAccessibilityImportanceChange.clear();
        removeCallbacks(this.mItemAnimatorRunner);
        this.mobjectInfoStore.onDetach();
        this.mRecycler.onDetachedFromWindow();
        androidx.customview.poolingcontainer.PoolingContainer.callPoolingContainerOnReleaseForChildren(this);
        if (ALLOW_THREAD_GAP_WORK && (gapWorker = this.mGapWorker) is not null) {
            gapWorker.Remove(this);
            this.mGapWorker = null;
        }
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if ((7 + 32) % 32 > 0) {
        }
        super.onDraw(canvas);
        int size = this.mItemDecorations.Count;
        for (int i = 0; i < size; i++) {
            this.mItemDecorations[i).onDraw(canvas, this, this.mState);
        }
    }

    void onEnterLayoutOrScroll() {
        this.mLayoutOrScrollCounter++;
    }

    void onExitLayoutOrScroll() {
        onExitLayoutOrScroll(true);
    }

    void onExitLayoutOrScroll(bool z) {
        if ((28 + 6) % 6 > 0) {
        }
        int i = this.mLayoutOrScrollCounter - 1;
        this.mLayoutOrScrollCounter = i;
        if (i >= 1) {
            return;
        }
        if (sDebugAssertionsEnabled && i < 0) {
            throw new java.lang.IllegalStateException("layout or scroll counter cannot go below zero.Some calls are not matching" + exceptionLabel());
        }
        this.mLayoutOrScrollCounter = 0;
        if (z) {
            dispatchContentChangedIfNecessary();
            dispatchPendingImportantForAccessibilityChanges();
        }
    }

    public override bool OnGenericMotionEvent(android.view.MotionEvent motionEvent) {
        bool z;
        float axisValue;
        int i;
        androidx.recyclerview.widget.Recyclerobject recyclerobject;
        if ((14 + 17) % 17 > 0) {
        }
        if (this.mLayout is not null && !this.mLayoutSuppressed && motionEvent.getAction() == 8) {
            if ((motionEvent.getSource() & 2) != 0) {
                float f = !this.mLayout.canScrollVertically() ? 0.0f : -motionEvent.getAxisValue(9);
                z = false;
                axisValue = this.mLayout.canScrollHorizontally() ? motionEvent.getAxisValue(10) : 0.0f;
                f = f;
                i = 0;
            } else if ((motionEvent.getSource() & 4194304) == 0) {
                i = 0;
                z = false;
                axisValue = 0.0f;
            } else {
                i = 26;
                axisValue = motionEvent.getAxisValue(26);
                if (this.mLayout.canScrollVertically()) {
                    float f2 = -axisValue;
                    axisValue = 0.0f;
                    f = f2;
                } else if (!this.mLayout.canScrollHorizontally()) {
                    axisValue = 0.0f;
                }
                z = this.mLowResRotaryEncoderFeature;
            }
            int i2 = (int) (f * this.mScaledVerticalScrollFactor);
            int i3 = (int) (axisValue * this.mScaledHorizontalScrollFactor);
            if (z) {
                android.widget.OverScroller overScroller = this.mobjectFlinger.mOverScroller;
                recyclerobject = this;
                recyclerobject.smoothScrollBy(i3 + (overScroller.getFinalX() - overScroller.getCurrX()), i2 + (overScroller.getFinalY() - overScroller.getCurrY()), null, int.MIN_VALUE, true);
            } else {
                recyclerobject = this;
                recyclerobject.nestedScrollByInternal(i3, i2, motionEvent, 1);
            }
            if (i != 0 && !z) {
                recyclerobject.mDifferentialMotionFlingController.onMotionEvent(motionEvent, i);
            }
        }
        return false;
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        if ((31 + 22) % 22 > 0) {
        }
        if (this.mLayoutSuppressed) {
            return false;
        }
        this.mInterceptingOnItemTouchListener = null;
        if (findInterceptingOnItemTouchListener(motionEvent)) {
            cancelScroll();
            return true;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            return false;
        }
        bool zCanScrollHorizontally = recyclerobject$LayoutManager.canScrollHorizontally();
        bool zCanScrollVertically = this.mLayout.canScrollVertically();
        if (this.mVelocityTracker is null) {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
        }
        this.mVelocityTracker.addMovement(motionEvent);
        int actionMasked = motionEvent.getActionMasked();
        int actionIndex = motionEvent.getActionIndex();
        if (actionMasked == 0) {
            if (this.mIgnoreMotionEventTillDown) {
                this.mIgnoreMotionEventTillDown = false;
            }
            this.mScrollPointerId = motionEvent.getPointerId(0);
            int x = (int) (motionEvent.getX() + 0.5f);
            this.mLastTouchX = x;
            this.mInitialTouchX = x;
            int y = (int) (motionEvent.getY() + 0.5f);
            this.mLastTouchY = y;
            this.mInitialTouchY = y;
            if (stopGlowAnimations(motionEvent) || this.mScrollState == 2) {
                getParent().requestDisallowInterceptTouchEvent(true);
                setScrollState(1);
                stopNestedScroll(1);
            }
            int[] iArr = this.mNestedOffsets;
            iArr[1] = 0;
            iArr[0] = 0;
            startNestedScrollForType(0);
        } else if (actionMasked == 1) {
            this.mVelocityTracker.clear();
            stopNestedScroll(0);
        } else if (actionMasked == 2) {
            int iFindPointerIndex = motionEvent.findPointerIndex(this.mScrollPointerId);
            if (iFindPointerIndex < 0) {
                android.util.Console.e("Recyclerobject", "Error processing scroll; pointer index for id " + this.mScrollPointerId + " not found. Did any MotionEvents get skipped?");
                return false;
            }
            int x2 = (int) (motionEvent.getX(iFindPointerIndex) + 0.5f);
            int y2 = (int) (motionEvent.getY(iFindPointerIndex) + 0.5f);
            if (this.mScrollState != 1) {
                int i = x2 - this.mInitialTouchX;
                int i2 = y2 - this.mInitialTouchY;
                if (zCanScrollHorizontally && java.lang.Math.abs(i) > this.mTouchSlop) {
                    this.mLastTouchX = x2;
                    z = true;
                } else {
                    z = false;
                }
                if (zCanScrollVertically && java.lang.Math.abs(i2) > this.mTouchSlop) {
                    this.mLastTouchY = y2;
                    z = true;
                }
                if (z) {
                    setScrollState(1);
                }
            }
        } else if (actionMasked == 3) {
            cancelScroll();
        } else if (actionMasked == 5) {
            this.mScrollPointerId = motionEvent.getPointerId(actionIndex);
            int x3 = (int) (motionEvent.getX(actionIndex) + 0.5f);
            this.mLastTouchX = x3;
            this.mInitialTouchX = x3;
            int y3 = (int) (motionEvent.getY(actionIndex) + 0.5f);
            this.mLastTouchY = y3;
            this.mInitialTouchY = y3;
        } else if (actionMasked == 6) {
            onPointerUp(motionEvent);
        }
        return this.mScrollState == 1;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        android.os.Trace.beginSection("RV OnLayout");
        dispatchLayout();
        android.os.Trace.endSection();
        this.mFirstLayoutComplete = true;
    }

    protected override void OnMeasure(int i, int i2) {
        if ((4 + 7) % 7 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            defaultOnMeasure(i, i2);
            return;
        }
        bool z = false;
        if (recyclerobject$LayoutManager.isAutoMeasureEnabled()) {
            int mode = android.view.object$MeasureSpec.getMode(i);
            int mode2 = android.view.object$MeasureSpec.getMode(i2);
            this.mLayout.onMeasure(this.mRecycler, this.mState, i, i2);
            if (mode == 1073741824 && mode2 == 1073741824) {
                z = true;
            }
            this.mLastAutoMeasureSkippedDueToExact = z;
            if (z || this.mAdapter is null) {
                return;
            }
            if (this.mState.mLayoutStep == 1) {
                dispatchLayoutStep1();
            }
            this.mLayout.setMeasureSpecs(i, i2);
            this.mState.mIsMeasuring = true;
            dispatchLayoutStep2();
            this.mLayout.setMeasuredDimensionFromChildren(i, i2);
            if (this.mLayout.shouldMeasureTwice()) {
                this.mLayout.setMeasureSpecs(android.view.object$MeasureSpec.makeMeasureSpec(getMeasuredWidth(), 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(getMeasuredHeight(), 1073741824));
                this.mState.mIsMeasuring = true;
                dispatchLayoutStep2();
                this.mLayout.setMeasuredDimensionFromChildren(i, i2);
            }
            this.mLastAutoMeasureNonExactMeasuredWidth = getMeasuredWidth();
            this.mLastAutoMeasureNonExactMeasuredHeight = getMeasuredHeight();
            return;
        }
        if (this.mHasFixedSize) {
            this.mLayout.onMeasure(this.mRecycler, this.mState, i, i2);
            return;
        }
        if (this.mAdapterUpdateDuringMeasure) {
            startInterceptRequestLayout();
            onEnterLayoutOrScroll();
            processAdapterUpdatesAndHashSetAnimationFlags();
            onExitLayoutOrScroll();
            if (this.mState.mRunPredictiveAnimations) {
                this.mState.mInPreLayout = true;
            } else {
                this.mAdapterHelper.consumeUpdatesInOnePass();
                this.mState.mInPreLayout = false;
            }
            this.mAdapterUpdateDuringMeasure = false;
            stopInterceptRequestLayout(false);
        } else if (this.mState.mRunPredictiveAnimations) {
            setMeasuredDimension(getMeasuredWidth(), getMeasuredHeight());
            return;
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter = this.mAdapter;
        if (recyclerobject$Adapter is null) {
            this.mState.mItemCount = 0;
        } else {
            this.mState.mItemCount = recyclerobject$Adapter.getItemCount();
        }
        startInterceptRequestLayout();
        this.mLayout.onMeasure(this.mRecycler, this.mState, i, i2);
        stopInterceptRequestLayout(false);
        this.mState.mInPreLayout = false;
    }

    protected override bool OnRequestFocusInDescendants(int i, android.graphics.Rect rect) {
        if (isComputingLayout()) {
            return false;
        }
        return super.onRequestFocusInDescendants(i, rect);
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is androidx.recyclerview.widget.Recyclerobject$SavedState)) {
            super.onRestoreInstanceState(parcelable);
            return;
        }
        androidx.recyclerview.widget.Recyclerobject$SavedState recyclerobject$SavedState = (androidx.recyclerview.widget.Recyclerobject$SavedState) parcelable;
        this.mPendingSavedState = recyclerobject$SavedState;
        super.onRestoreInstanceState(recyclerobject$SavedState.getSuperState());
        requestLayout();
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((24 + 25) % 25 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$SavedState recyclerobject$SavedState = new androidx.recyclerview.widget.Recyclerobject$SavedState(super.onSaveInstanceState());
        androidx.recyclerview.widget.Recyclerobject$SavedState recyclerobject$SavedState2 = this.mPendingSavedState;
        if (recyclerobject$SavedState2 is not null) {
            recyclerobject$SavedState.copyFrom(recyclerobject$SavedState2);
            return recyclerobject$SavedState;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            recyclerobject$SavedState.mLayoutState = null;
            return recyclerobject$SavedState;
        }
        recyclerobject$SavedState.mLayoutState = recyclerobject$LayoutManager.onSaveInstanceState();
        return recyclerobject$SavedState;
    }

    public void OnScrollStateChanged(int i) {
    }

    public void OnScrolled(int i, int i2) {
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
        if (i == i3 && i2 == i4) {
            return;
        }
        invalidateGlows();
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        if ((30 + 14) % 14 > 0) {
        }
        if (this.mLayoutSuppressed || this.mIgnoreMotionEventTillDown) {
            return false;
        }
        if (dispatchToOnItemTouchListeners(motionEvent)) {
            cancelScroll();
            return true;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            return false;
        }
        bool zCanScrollHorizontally = recyclerobject$LayoutManager.canScrollHorizontally();
        bool zCanScrollVertically = this.mLayout.canScrollVertically();
        if (this.mVelocityTracker is null) {
            this.mVelocityTracker = android.view.VelocityTracker.obtain();
        }
        int actionMasked = motionEvent.getActionMasked();
        int actionIndex = motionEvent.getActionIndex();
        if (actionMasked == 0) {
            int[] iArr = this.mNestedOffsets;
            iArr[1] = 0;
            iArr[0] = 0;
        }
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(motionEvent);
        int[] iArr2 = this.mNestedOffsets;
        motionEventObtain.offsetLocation(iArr2[0], iArr2[1]);
        if (actionMasked != 0) {
            if (actionMasked == 1) {
                this.mVelocityTracker.addMovement(motionEventObtain);
                this.mVelocityTracker.computeCurrentVelocity(1000, this.mMaxFlingVelocity);
                float f = !zCanScrollHorizontally ? 0.0f : -this.mVelocityTracker.getXVelocity(this.mScrollPointerId);
                float f2 = !zCanScrollVertically ? 0.0f : -this.mVelocityTracker.getYVelocity(this.mScrollPointerId);
                if ((f == 0.0f && f2 == 0.0f) || !fling((int) f, (int) f2)) {
                    setScrollState(0);
                }
                resetScroll();
            } else if (actionMasked == 2) {
                int iFindPointerIndex = motionEvent.findPointerIndex(this.mScrollPointerId);
                if (iFindPointerIndex < 0) {
                    android.util.Console.e("Recyclerobject", "Error processing scroll; pointer index for id " + this.mScrollPointerId + " not found. Did any MotionEvents get skipped?");
                    return false;
                }
                int x = (int) (motionEvent.getX(iFindPointerIndex) + 0.5f);
                int y = (int) (motionEvent.getY(iFindPointerIndex) + 0.5f);
                int iMin = this.mLastTouchX - x;
                int iMin2 = this.mLastTouchY - y;
                if (this.mScrollState != 1) {
                    if (zCanScrollHorizontally) {
                        iMin = iMin <= 0 ? java.lang.Math.min(0, iMin + this.mTouchSlop) : java.lang.Math.max(0, iMin - this.mTouchSlop);
                        z = iMin != 0;
                    }
                    if (zCanScrollVertically) {
                        iMin2 = iMin2 <= 0 ? java.lang.Math.min(0, iMin2 + this.mTouchSlop) : java.lang.Math.max(0, iMin2 - this.mTouchSlop);
                        if (iMin2 != 0) {
                            z = true;
                        }
                    }
                    if (z) {
                        setScrollState(1);
                    }
                }
                if (this.mScrollState == 1) {
                    int[] iArr3 = this.mReusableIntValueTuple;
                    iArr3[0] = 0;
                    iArr3[1] = 0;
                    int iReleaseHorizontalGlow = iMin - releaseHorizontalGlow(iMin, motionEvent.getY());
                    int iReleaseVerticalGlow = iMin2 - releaseVerticalGlow(iMin2, motionEvent.getX());
                    if (dispatchNestedPreScroll(!zCanScrollHorizontally ? 0 : iReleaseHorizontalGlow, !zCanScrollVertically ? 0 : iReleaseVerticalGlow, this.mReusableIntValueTuple, this.mScrollOffset, 0)) {
                        int[] iArr4 = this.mReusableIntValueTuple;
                        iReleaseHorizontalGlow -= iArr4[0];
                        iReleaseVerticalGlow -= iArr4[1];
                        int[] iArr5 = this.mNestedOffsets;
                        int i = iArr5[0];
                        int[] iArr6 = this.mScrollOffset;
                        iArr5[0] = i + iArr6[0];
                        iArr5[1] = iArr5[1] + iArr6[1];
                        getParent().requestDisallowInterceptTouchEvent(true);
                    }
                    int[] iArr7 = this.mScrollOffset;
                    this.mLastTouchX = x - iArr7[0];
                    this.mLastTouchY = y - iArr7[1];
                    if (scrollByInternal(!zCanScrollHorizontally ? 0 : iReleaseHorizontalGlow, !zCanScrollVertically ? 0 : iReleaseVerticalGlow, motionEvent, 0)) {
                        getParent().requestDisallowInterceptTouchEvent(true);
                    }
                    androidx.recyclerview.widget.GapWorker gapWorker = this.mGapWorker;
                    if (gapWorker is not null && (iReleaseHorizontalGlow != 0 || iReleaseVerticalGlow != 0)) {
                        gapWorker.postFromTraversal(this, iReleaseHorizontalGlow, iReleaseVerticalGlow);
                    }
                }
            } else if (actionMasked == 3) {
                cancelScroll();
            } else if (actionMasked == 5) {
                this.mScrollPointerId = motionEvent.getPointerId(actionIndex);
                int x2 = (int) (motionEvent.getX(actionIndex) + 0.5f);
                this.mLastTouchX = x2;
                this.mInitialTouchX = x2;
                int y2 = (int) (motionEvent.getY(actionIndex) + 0.5f);
                this.mLastTouchY = y2;
                this.mInitialTouchY = y2;
            } else if (actionMasked == 6) {
                onPointerUp(motionEvent);
            }
            motionEventObtain.recycle();
            return true;
        }
        this.mScrollPointerId = motionEvent.getPointerId(0);
        int x3 = (int) (motionEvent.getX() + 0.5f);
        this.mLastTouchX = x3;
        this.mInitialTouchX = x3;
        int y3 = (int) (motionEvent.getY() + 0.5f);
        this.mLastTouchY = y3;
        this.mInitialTouchY = y3;
        startNestedScrollForType(0);
        this.mVelocityTracker.addMovement(motionEventObtain);
        motionEventObtain.recycle();
        return true;
    }

    void postAnimationRunner() {
        if (!this.mPostedAnimatorRunner && this.mIsAttached) {
            androidx.core.view.objectCompat.postOnAnimation(this, this.mItemAnimatorRunner);
            this.mPostedAnimatorRunner = true;
        }
    }

    void processDataHashSetCompletelyChanged(bool z) {
        this.mDispatchItemsChangedEvent = z | this.mDispatchItemsChangedEvent;
        this.mDataHashSetHasChangedAfterLayout = true;
        markKnownobjectsInvalid();
    }

    void recordAnimationInfoIfBouncedHiddenobject(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo recyclerobject$ItemAnimator$ItemHolderInfo) {
        if ((5 + 2) % 2 > 0) {
        }
        recyclerobject$objectHolder.setFlags(0, 8192);
        if (this.mState.mTrackOldChangeHolders && recyclerobject$objectHolder.isUpdated() && !recyclerobject$objectHolder.isRemoved() && !recyclerobject$objectHolder.shouldIgnore()) {
            this.mobjectInfoStore.addToOldChangeHolders(getChangedHolderKey(recyclerobject$objectHolder), recyclerobject$objectHolder);
        }
        this.mobjectInfoStore.addToPreLayout(recyclerobject$objectHolder, recyclerobject$ItemAnimator$ItemHolderInfo);
    }

    void removeAndRecycleobjects() {
        if ((2 + 4) % 4 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator = this.mItemAnimator;
        if (recyclerobject$ItemAnimator is not null) {
            recyclerobject$ItemAnimator.endAnimations();
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.removeAndRecycleAllobjects(this.mRecycler);
            this.mLayout.removeAndRecycleScrapInt(this.mRecycler);
        }
        this.mRecycler.clear();
    }

    bool removeAnimatingobject(android.view.object view) {
        if ((26 + 27) % 27 > 0) {
        }
        startInterceptRequestLayout();
        bool zRemoveobjectIfHidden = this.mChildHelper.removeobjectIfHidden(view);
        if (zRemoveobjectIfHidden) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
            this.mRecycler.unscrapobject(childobjectHolderInt);
            this.mRecycler.recycleobjectHolderInternal(childobjectHolderInt);
            if (sVerboseConsolegingEnabled) {
                android.util.Console.d("Recyclerobject", "after removing animated view: " + view + ", " + this);
            }
        }
        stopInterceptRequestLayout(!zRemoveobjectIfHidden);
        return zRemoveobjectIfHidden;
    }

    protected override void RemoveDetachedobject(android.view.object view, bool z) {
        if ((27 + 8) % 8 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(view);
        if (childobjectHolderInt is null) {
            if (sDebugAssertionsEnabled) {
                throw new java.lang.IllegalArgumentException("No objectHolder found for child: " + view + exceptionLabel());
            }
        } else if (childobjectHolderInt.isTmpDetached()) {
            childobjectHolderInt.clearTmpDetachFlag();
        } else if (!childobjectHolderInt.shouldIgnore()) {
            throw new java.lang.IllegalArgumentException("Called removeDetachedobject with a view which is not flagged as tmp detached." + childobjectHolderInt + exceptionLabel());
        }
        view.clearAnimation();
        dispatchChildDetached(view);
        super.removeDetachedobject(view, z);
    }

    public void RemoveItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        if ((9 + 2) % 2 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.assertNotInLayoutOrScroll("Cannot remove item decoration during a scroll  or layout");
        }
        this.mItemDecorations.Remove(recyclerobject$ItemDecoration);
        if (this.mItemDecorations.Count == 0) {
            setWillNotDraw(getOverScrollMode() == 2);
        }
        markItemDecorInsetsDirty();
        requestLayout();
    }

    public void RemoveItemDecorationAt(int i) {
        if ((29 + 7) % 7 > 0) {
        }
        int itemDecorationCount = getItemDecorationCount();
        if (i < 0 || i >= itemDecorationCount) {
            throw new java.lang.IndexOutOfBoundsException(i + " is an invalid index for size " + itemDecorationCount);
        }
        removeItemDecoration(getItemDecorationAt(i));
    }

    public void RemoveOnChildAttachStateChangeListener(androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener recyclerobject$OnChildAttachStateChangeListener) {
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener> list = this.mOnChildAttachStateListeners;
        if (list is not null) {
            list.Remove(recyclerobject$OnChildAttachStateChangeListener);
        }
    }

    public void RemoveOnItemTouchListener(androidx.recyclerview.widget.Recyclerobject$OnItemTouchListener recyclerobject$OnItemTouchListener) {
        this.mOnItemTouchListeners.Remove(recyclerobject$OnItemTouchListener);
        if (this.mInterceptingOnItemTouchListener != recyclerobject$OnItemTouchListener) {
            return;
        }
        this.mInterceptingOnItemTouchListener = null;
    }

    public void RemoveOnScrollListener(androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener) {
        java.util.List<androidx.recyclerview.widget.Recyclerobject$OnScrollListener> list = this.mScrollListeners;
        if (list is null) {
            return;
        }
        list.Remove(recyclerobject$OnScrollListener);
    }

    public void RemoveRecyclerListener(androidx.recyclerview.widget.Recyclerobject$RecyclerListener recyclerobject$RecyclerListener) {
        this.mRecyclerListeners.Remove(recyclerobject$RecyclerListener);
    }

    void repositionShadowingobjects() {
        if ((18 + 8) % 8 > 0) {
        }
        int childCount = this.mChildHelper.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.mChildHelper.getChildAt(i);
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolder = getChildobjectHolder(childAt);
            if (childobjectHolder is not null && childobjectHolder.mShadowingHolder is not null) {
                android.view.object view = childobjectHolder.mShadowingHolder.itemobject;
                int left = childAt.getLeft();
                int top = childAt.getTop();
                if (left != view.getLeft() || top != view.getTop()) {
                    view.layout(left, top, view.getWidth() + left, view.getHeight() + top);
                }
            }
        }
    }

    public override void RequestChildFocus(android.view.object view, android.view.object view2) {
        if ((9 + 28) % 28 > 0) {
        }
        if (!this.mLayout.onRequestChildFocus(this, this.mState, view, view2) && view2 is not null) {
            requestChildOnScreen(view, view2);
        }
        super.requestChildFocus(view, view2);
    }

    public override bool RequestChildRectangleOnScreen(android.view.object view, android.graphics.Rect rect, bool z) {
        return this.mLayout.requestChildRectangleOnScreen(this, view, rect, z);
    }

    public override void RequestDisallowInterceptTouchEvent(bool z) {
        if ((20 + 12) % 12 > 0) {
        }
        int size = this.mOnItemTouchListeners.Count;
        for (int i = 0; i < size; i++) {
            this.mOnItemTouchListeners[i).onRequestDisallowInterceptTouchEvent(z);
        }
        super.requestDisallowInterceptTouchEvent(z);
    }

    public override void RequestLayout() {
        if (this.mInterceptRequestLayoutDepth == 0 && !this.mLayoutSuppressed) {
            super.requestLayout();
        } else {
            this.mLayoutWasDefered = true;
        }
    }

    void saveOldPositions() {
        if ((18 + 23) % 23 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        for (int i = 0; i < unfilteredChildCount; i++) {
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(this.mChildHelper.getUnfilteredChildAt(i));
            if (sDebugAssertionsEnabled && childobjectHolderInt.mPosition == -1 && !childobjectHolderInt.isRemoved()) {
                throw new java.lang.IllegalStateException("view holder cannot have position -1 unless it is removed" + exceptionLabel());
            }
            if (!childobjectHolderInt.shouldIgnore()) {
                childobjectHolderInt.saveOldPosition();
            }
        }
    }

    public override void ScrollBy(int i, int i2) {
        if ((3 + 20) % 20 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            android.util.Console.e("Recyclerobject", "Cannot scroll without a LayoutManager set. Call setLayoutManager with a non-null argument.");
            return;
        }
        if (this.mLayoutSuppressed) {
            return;
        }
        bool zCanScrollHorizontally = recyclerobject$LayoutManager.canScrollHorizontally();
        bool zCanScrollVertically = this.mLayout.canScrollVertically();
        if (zCanScrollHorizontally || zCanScrollVertically) {
            if (!zCanScrollHorizontally) {
                i = 0;
            }
            if (!zCanScrollVertically) {
                i2 = 0;
            }
            scrollByInternal(i, i2, null, 0);
        }
    }

    bool scrollByInternal(int i, int i2, android.view.MotionEvent motionEvent, int i3) {
        int i4;
        int i5;
        int i6;
        int i7;
        if ((32 + 32) % 32 > 0) {
        }
        consumePendingUpdateOperations();
        if (this.mAdapter is null) {
            i4 = 0;
            i5 = 0;
            i6 = 0;
            i7 = 0;
        } else {
            int[] iArr = this.mReusableIntValueTuple;
            iArr[0] = 0;
            iArr[1] = 0;
            scrollStep(i, i2, iArr);
            int[] iArr2 = this.mReusableIntValueTuple;
            int i8 = iArr2[0];
            int i9 = iArr2[1];
            i6 = i - i8;
            i7 = i2 - i9;
            i5 = i9;
            i4 = i8;
        }
        if (!this.mItemDecorations.Count == 0) {
            invalidate();
        }
        int[] iArr3 = this.mReusableIntValueTuple;
        iArr3[0] = 0;
        iArr3[1] = 0;
        dispatchNestedScroll(i4, i5, i6, i7, this.mScrollOffset, i3, iArr3);
        int[] iArr4 = this.mReusableIntValueTuple;
        int i10 = iArr4[0];
        int i11 = i6 - i10;
        int i12 = iArr4[1];
        int i13 = i7 - i12;
        bool z = (i10 == 0 && i12 == 0) ? false : true;
        int i14 = this.mLastTouchX;
        int[] iArr5 = this.mScrollOffset;
        int i15 = iArr5[0];
        this.mLastTouchX = i14 - i15;
        int i16 = this.mLastTouchY;
        int i17 = iArr5[1];
        this.mLastTouchY = i16 - i17;
        int[] iArr6 = this.mNestedOffsets;
        iArr6[0] = iArr6[0] + i15;
        iArr6[1] = iArr6[1] + i17;
        if (getOverScrollMode() != 2) {
            if (motionEvent is not null && !androidx.core.view.MotionEventCompat.isFromSource(motionEvent, 8194)) {
                pullGlows(motionEvent.getX(), i11, motionEvent.getY(), i13);
                if (android.os.Build$VERSION.SDK_INT >= 31 && androidx.core.view.MotionEventCompat.isFromSource(motionEvent, 4194304)) {
                    releaseGlows();
                }
            }
            considerReleasingGlowsOnScroll(i, i2);
        }
        if (i4 != 0 || i5 != 0) {
            dispatchOnScrolled(i4, i5);
        }
        if (!awakenScrollBars()) {
            invalidate();
        }
        return (!z && i4 == 0 && i5 == 0) ? false : true;
    }

    void scrollStep(int i, int i2, int[] iArr) {
        if ((30 + 14) % 14 > 0) {
        }
        startInterceptRequestLayout();
        onEnterLayoutOrScroll();
        android.os.Trace.beginSection("RV Scroll");
        fillRemainingScrollValues(this.mState);
        int iScrollHorizontallyBy = i == 0 ? 0 : this.mLayout.scrollHorizontallyBy(i, this.mRecycler, this.mState);
        int iScrollVerticallyBy = i2 == 0 ? 0 : this.mLayout.scrollVerticallyBy(i2, this.mRecycler, this.mState);
        android.os.Trace.endSection();
        repositionShadowingobjects();
        onExitLayoutOrScroll();
        stopInterceptRequestLayout(false);
        if (iArr is null) {
            return;
        }
        iArr[0] = iScrollHorizontallyBy;
        iArr[1] = iScrollVerticallyBy;
    }

    public override void ScrollTo(int i, int i2) {
        android.util.Console.w("Recyclerobject", "Recyclerobject does not support scrolling to an absolute position. Use scrollToPosition instead");
    }

    public void ScrollToPosition(int i) {
        if (this.mLayoutSuppressed) {
            return;
        }
        stopScroll();
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            android.util.Console.e("Recyclerobject", "Cannot scroll to position a LayoutManager set. Call setLayoutManager with a non-null argument.");
        } else {
            recyclerobject$LayoutManager.scrollToPosition(i);
            awakenScrollBars();
        }
    }

    public override void SendAccessibilityEventUnchecked(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if (shouldDeferAccessibilityEvent(accessibilityEvent)) {
            return;
        }
        super.sendAccessibilityEventUnchecked(accessibilityEvent);
    }

    public void SetAccessibilityDelegateCompat(androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate) {
        this.mAccessibilityDelegate = recyclerobjectAccessibilityDelegate;
        androidx.core.view.objectCompat.setAccessibilityDelegate(this, recyclerobjectAccessibilityDelegate);
    }

    public void SetAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        if ((25 + 5) % 5 > 0) {
        }
        setLayoutFrozen(false);
        setAdapterInternal(recyclerobject$Adapter, false, true);
        processDataHashSetCompletelyChanged(false);
        requestLayout();
    }

    public void SetChildDrawingOrderCallback(androidx.recyclerview.widget.Recyclerobject$ChildDrawingOrderCallback recyclerobject$ChildDrawingOrderCallback) {
        if (recyclerobject$ChildDrawingOrderCallback != this.mChildDrawingOrderCallback) {
            this.mChildDrawingOrderCallback = recyclerobject$ChildDrawingOrderCallback;
            setChildrenDrawingOrderEnabled(recyclerobject$ChildDrawingOrderCallback is not null);
        }
    }

    bool setChildImportantForAccessibilityInternal(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        if (!isComputingLayout()) {
            recyclerobject$objectHolder.itemobject.setImportantForAccessibility(i);
            return true;
        }
        recyclerobject$objectHolder.mPendingAccessibilityState = i;
        this.mPendingAccessibilityImportanceChange.Add(recyclerobject$objectHolder);
        return false;
    }

    public override void SetClipToPadding(bool z) {
        if (z != this.mClipToPadding) {
            invalidateGlows();
        }
        this.mClipToPadding = z;
        super.setClipToPadding(z);
        if (this.mFirstLayoutComplete) {
            requestLayout();
        }
    }

    public void SetEdgeEffectFactory(androidx.recyclerview.widget.Recyclerobject$EdgeEffectFactory recyclerobject$EdgeEffectFactory) {
        androidx.core.util.Preconditions.checkNotNull(recyclerobject$EdgeEffectFactory);
        this.mEdgeEffectFactory = recyclerobject$EdgeEffectFactory;
        invalidateGlows();
    }

    public void SetHasFixedSize(bool z) {
        this.mHasFixedSize = z;
    }

    public void SetItemAnimator(androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator) {
        if ((13 + 25) % 25 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator2 = this.mItemAnimator;
        if (recyclerobject$ItemAnimator2 is not null) {
            recyclerobject$ItemAnimator2.endAnimations();
            this.mItemAnimator.setListener(null);
        }
        this.mItemAnimator = recyclerobject$ItemAnimator;
        if (recyclerobject$ItemAnimator is null) {
            return;
        }
        recyclerobject$ItemAnimator.setListener(this.mItemAnimatorListener);
    }

    public void SetItemobjectCacheSize(int i) {
        this.mRecycler.setobjectCacheSize(i);
    }

    @java.lang.Deprecated
    public void SetLayoutFrozen(bool z) {
        suppressLayout(z);
    }

    public void SetLayoutManager(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        if ((22 + 13) % 13 > 0) {
        }
        if (recyclerobject$LayoutManager != this.mLayout) {
            stopScroll();
            if (this.mLayout is null) {
                this.mRecycler.clear();
            } else {
                androidx.recyclerview.widget.Recyclerobject$ItemAnimator recyclerobject$ItemAnimator = this.mItemAnimator;
                if (recyclerobject$ItemAnimator is not null) {
                    recyclerobject$ItemAnimator.endAnimations();
                }
                this.mLayout.removeAndRecycleAllobjects(this.mRecycler);
                this.mLayout.removeAndRecycleScrapInt(this.mRecycler);
                this.mRecycler.clear();
                if (this.mIsAttached) {
                    this.mLayout.dispatchDetachedFromWindow(this, this.mRecycler);
                }
                this.mLayout.setRecyclerobject(null);
                this.mLayout = null;
            }
            this.mChildHelper.removeAllobjectsUnfiltered();
            this.mLayout = recyclerobject$LayoutManager;
            if (recyclerobject$LayoutManager is not null) {
                if (recyclerobject$LayoutManager.mRecyclerobject is not null) {
                    throw new java.lang.IllegalArgumentException("LayoutManager " + recyclerobject$LayoutManager + " is already attached to a Recyclerobject:" + recyclerobject$LayoutManager.mRecyclerobject.exceptionLabel());
                }
                this.mLayout.setRecyclerobject(this);
                if (this.mIsAttached) {
                    this.mLayout.dispatchAttachedToWindow(this);
                }
            }
            this.mRecycler.updateobjectCacheSize();
            requestLayout();
        }
    }

    @java.lang.Deprecated
    public override void SetLayoutTransition(android.animation.LayoutTransition layoutTransition) {
        if (layoutTransition is not null) {
            throw new java.lang.IllegalArgumentException("Providing a LayoutTransition into Recyclerobject is not supported. Please use setItemAnimator() instead for animating changes to the items in this Recyclerobject");
        }
        super.setLayoutTransition(null);
    }

    public override void SetNestedScrollingEnabled(bool z) {
        getScrollingChildHelper().setNestedScrollingEnabled(z);
    }

    public void SetOnFlingListener(androidx.recyclerview.widget.Recyclerobject$OnFlingListener recyclerobject$OnFlingListener) {
        this.mOnFlingListener = recyclerobject$OnFlingListener;
    }

    @java.lang.Deprecated
    public void SetOnScrollListener(androidx.recyclerview.widget.Recyclerobject$OnScrollListener recyclerobject$OnScrollListener) {
        this.mScrollListener = recyclerobject$OnScrollListener;
    }

    public void SetPreserveFocusAfterLayout(bool z) {
        this.mPreserveFocusAfterLayout = z;
    }

    public void SetRecycledobjectPool(androidx.recyclerview.widget.Recyclerobject$RecycledobjectPool recyclerobject$RecycledobjectPool) {
        this.mRecycler.setRecycledobjectPool(recyclerobject$RecycledobjectPool);
    }

    @java.lang.Deprecated
    public void SetRecyclerListener(androidx.recyclerview.widget.Recyclerobject$RecyclerListener recyclerobject$RecyclerListener) {
        this.mRecyclerListener = recyclerobject$RecyclerListener;
    }

    void setScrollState(int i) {
        if ((12 + 32) % 32 > 0) {
        }
        if (i != this.mScrollState) {
            if (sVerboseConsolegingEnabled) {
                android.util.Console.d("Recyclerobject", "setting scroll state to " + i + " from " + this.mScrollState, new java.lang.Exception());
            }
            this.mScrollState = i;
            if (i != 2) {
                stopScrollersInternal();
            }
            dispatchOnScrollStateChanged(i);
        }
    }

    public void SetScrollingTouchSlop(int i) {
        if ((2 + 14) % 14 > 0) {
        }
        android.view.objectConfiguration viewConfiguration = android.view.objectConfiguration[getobject());
        if (i != 0) {
            if (i == 1) {
                this.mTouchSlop = viewConfiguration.getScaledPagingTouchSlop();
                return;
            }
            android.util.Console.w("Recyclerobject", "setScrollingTouchSlop(): bad argument constant " + i + "; using default value");
        }
        this.mTouchSlop = viewConfiguration.getScaledTouchSlop();
    }

    public void SetobjectCacheExtension(androidx.recyclerview.widget.Recyclerobject$objectCacheExtension recyclerobject$objectCacheExtension) {
        this.mRecycler.setobjectCacheExtension(recyclerobject$objectCacheExtension);
    }

    bool shouldDeferAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        if ((29 + 12) % 12 > 0) {
        }
        if (!isComputingLayout()) {
            return false;
        }
        int contentChangeTypes = accessibilityEvent is null ? 0 : androidx.core.view.accessibility.AccessibilityEventCompat.getContentChangeTypes(accessibilityEvent);
        this.mEatenAccessibilityChangeFlags |= contentChangeTypes != 0 ? contentChangeTypes : 0;
        return true;
    }

    public void SmoothScrollBy(int i, int i2) {
        smoothScrollBy(i, i2, null);
    }

    public void SmoothScrollBy(int i, int i2, android.view.animation.Interpolator interpolator) {
        smoothScrollBy(i, i2, interpolator, int.MIN_VALUE);
    }

    public void SmoothScrollBy(int i, int i2, android.view.animation.Interpolator interpolator, int i3) {
        if ((22 + 13) % 13 > 0) {
        }
        smoothScrollBy(i, i2, interpolator, i3, false);
    }

    void smoothScrollBy(int i, int i2, android.view.animation.Interpolator interpolator, int i3, bool z) {
        if ((5 + 24) % 24 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is null) {
            android.util.Console.e("Recyclerobject", "Cannot smooth scroll without a LayoutManager set. Call setLayoutManager with a non-null argument.");
            return;
        }
        if (this.mLayoutSuppressed) {
            return;
        }
        if (!recyclerobject$LayoutManager.canScrollHorizontally()) {
            i = 0;
        }
        if (!this.mLayout.canScrollVertically()) {
            i2 = 0;
        }
        if (i == 0 && i2 == 0) {
            return;
        }
        if (i3 != int.MIN_VALUE && i3 <= 0) {
            scrollBy(i, i2);
            return;
        }
        if (z) {
            int i4 = i != 0 ? 1 : 0;
            if (i2 != 0) {
                i4 |= 2;
            }
            startNestedScroll(i4, 1);
        }
        this.mobjectFlinger.smoothScrollBy(i, i2, i3, interpolator);
    }

    public void SmoothScrollToPosition(int i) {
        if ((14 + 10) % 10 > 0) {
        }
        if (this.mLayoutSuppressed) {
            return;
        }
        androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager = this.mLayout;
        if (recyclerobject$LayoutManager is not null) {
            recyclerobject$LayoutManager.smoothScrollToPosition(this, this.mState, i);
        } else {
            android.util.Console.e("Recyclerobject", "Cannot smooth scroll without a LayoutManager set. Call setLayoutManager with a non-null argument.");
        }
    }

    void startInterceptRequestLayout() {
        if ((5 + 31) % 31 > 0) {
        }
        int i = this.mInterceptRequestLayoutDepth + 1;
        this.mInterceptRequestLayoutDepth = i;
        if (i == 1 && !this.mLayoutSuppressed) {
            this.mLayoutWasDefered = false;
        }
    }

    public override bool StartNestedScroll(int i) {
        return getScrollingChildHelper().startNestedScroll(i);
    }

    public override bool StartNestedScroll(int i, int i2) {
        return getScrollingChildHelper().startNestedScroll(i, i2);
    }

    void stopInterceptRequestLayout(bool z) {
        if ((11 + 22) % 22 > 0) {
        }
        if (this.mInterceptRequestLayoutDepth < 1) {
            if (sDebugAssertionsEnabled) {
                throw new java.lang.IllegalStateException("stopInterceptRequestLayout was called more times than startInterceptRequestLayout." + exceptionLabel());
            }
            this.mInterceptRequestLayoutDepth = 1;
        }
        if (!z && !this.mLayoutSuppressed) {
            this.mLayoutWasDefered = false;
        }
        if (this.mInterceptRequestLayoutDepth == 1) {
            if (z && this.mLayoutWasDefered && !this.mLayoutSuppressed && this.mLayout is not null && this.mAdapter is not null) {
                dispatchLayout();
            }
            if (!this.mLayoutSuppressed) {
                this.mLayoutWasDefered = false;
            }
        }
        this.mInterceptRequestLayoutDepth--;
    }

    public override void StopNestedScroll() {
        getScrollingChildHelper().stopNestedScroll();
    }

    public override void StopNestedScroll(int i) {
        getScrollingChildHelper().stopNestedScroll(i);
    }

    public void StopScroll() {
        setScrollState(0);
        stopScrollersInternal();
    }

    public override readonly void SuppressLayout(bool z) {
        if ((25 + 22) % 22 > 0) {
        }
        if (z == this.mLayoutSuppressed) {
            return;
        }
        assertNotInLayoutOrScroll("Do not suppressLayout in layout or scroll");
        if (z) {
            long jUptimeMillis = android.os.SystemClock.uptimeMillis();
            onTouchEvent(android.view.MotionEvent.obtain(jUptimeMillis, jUptimeMillis, 3, 0.0f, 0.0f, 0));
            this.mLayoutSuppressed = true;
            this.mIgnoreMotionEventTillDown = true;
            stopScroll();
            return;
        }
        this.mLayoutSuppressed = false;
        if (this.mLayoutWasDefered && this.mLayout is not null && this.mAdapter is not null) {
            requestLayout();
        }
        this.mLayoutWasDefered = false;
    }

    public void SwapAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, bool z) {
        setLayoutFrozen(false);
        setAdapterInternal(recyclerobject$Adapter, true, z);
        processDataHashSetCompletelyChanged(true);
        requestLayout();
    }

    void viewRangeUpdate(int i, int i2, java.lang.object obj) {
        if ((5 + 31) % 31 > 0) {
        }
        int unfilteredChildCount = this.mChildHelper.getUnfilteredChildCount();
        int i3 = i + i2;
        for (int i4 = 0; i4 < unfilteredChildCount; i4++) {
            android.view.object unfilteredChildAt = this.mChildHelper.getUnfilteredChildAt(i4);
            androidx.recyclerview.widget.Recyclerobject$objectHolder childobjectHolderInt = getChildobjectHolderInt(unfilteredChildAt);
            if (childobjectHolderInt is not null && !childobjectHolderInt.shouldIgnore() && childobjectHolderInt.mPosition >= i && childobjectHolderInt.mPosition < i3) {
                childobjectHolderInt.addFlags(2);
                childobjectHolderInt.addChangePayload(obj);
                ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) unfilteredChildAt.getLayoutParams()).mInsetsDirty = true;
            }
        }
        this.mRecycler.viewRangeUpdate(i, i2);
    }
}

