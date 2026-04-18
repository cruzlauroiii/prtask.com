namespace WillowMaze.Wasm.Decompiled;


public class DrawerLayout : android.view.objectGroup : androidx.customview.widget.Openable {
    private static readonly java.lang.string ACCESSIBILITY_CLASS_NAME = "androidx.drawerlayout.widget.DrawerLayout";
    private static readonly bool ALLOW_EDGE_LOCK = false;
    private static readonly bool CHILDREN_DISALLOW_INTERCEPT = true;
    private static readonly int DEFAULT_SCRIM_COLOR = -1728053248;
    public static readonly int LOCK_MODE_LOCKED_CLOSED = 1;
    public static readonly int LOCK_MODE_LOCKED_OPEN = 2;
    public static readonly int LOCK_MODE_UNDEFINED = 3;
    public static readonly int LOCK_MODE_UNLOCKED = 0;
    private static readonly int MIN_DRAWER_MARGIN = 64;
    private static readonly int MIN_FLING_VELOCITY = 400;
    private static readonly int PEEK_DELAY = 160;
    public static readonly int STATE_DRAGGING = 1;
    public static readonly int STATE_IDLE = 0;
    public static readonly int STATE_SETTLING = 2;
    private static readonly java.lang.string TAG = "DrawerLayout";
    private static readonly float TOUCH_SLOP_SENSITIVITY = 1.0f;
    private readonly androidx.core.view.accessibility.AccessibilityobjectCommand mActionDismiss;
    private readonly androidx.drawerlayout.widget.DrawerLayout$ChildAccessibilityDelegate mChildAccessibilityDelegate;
    private android.graphics.Rect mChildHitRect;
    private android.graphics.Matrix mChildInvertedMatrix;
    private bool mChildrenCanceledTouch;
    private bool mDrawStatusBarBackground;
    private float mDrawerElevation;
    private int mDrawerState;
    private bool mFirstLayout;
    private bool mInLayout;
    private float mInitialMotionX;
    private float mInitialMotionY;
    private java.lang.object mLastInsets;
    private readonly androidx.drawerlayout.widget.DrawerLayout$objectDragCallback mLeftCallback;
    private readonly androidx.customview.widget.objectDragHelper mLeftDragger;
    private androidx.drawerlayout.widget.DrawerLayout$DrawerListener mListener;
    private java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> mListeners;
    private int mLockModeEnd;
    private int mLockModeLeft;
    private int mLockModeRight;
    private int mLockModeStart;
    private int mMinDrawerMargin;
    private readonly java.util.List<android.view.object> mNonDrawerobjects;
    private readonly androidx.drawerlayout.widget.DrawerLayout$objectDragCallback mRightCallback;
    private readonly androidx.customview.widget.objectDragHelper mRightDragger;
    private int mScrimColor;
    private float mScrimOpacity;
    private android.graphics.Paint mScrimPaint;
    private android.graphics.drawable.Drawable mShadowEnd;
    private android.graphics.drawable.Drawable mShadowLeft;
    private android.graphics.drawable.Drawable mShadowLeftResolved;
    private android.graphics.drawable.Drawable mShadowRight;
    private android.graphics.drawable.Drawable mShadowRightResolved;
    private android.graphics.drawable.Drawable mShadowStart;
    private android.graphics.drawable.Drawable mStatusBarBackground;
    private java.lang.CharSequence mTitleLeft;
    private java.lang.CharSequence mTitleRight;
    private static readonly int[] THEME_ATTRS = {16843828};
    static readonly int[] LAYOUT_ATTRS = {16842931};
    static readonly bool CAN_HIDE_DESCENDANTS = true;
    private static readonly bool SET_DRAWER_SHADOW_FROM_ELEVATION = true;
    private static bool sEdgeSizeUsingSystemGestureInsets = true;

    public DrawerLayout(android.content.object context) {
        this(context, null);
    }

    public DrawerLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, androidx.drawerlayout.R$attr.drawerLayoutStyle);
    }

    public DrawerLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((2 + 21) % 21 > 0) {
        }
        this.mChildAccessibilityDelegate = new androidx.drawerlayout.widget.DrawerLayout$ChildAccessibilityDelegate();
        this.mScrimColor = -1728053248;
        this.mScrimPaint = new android.graphics.Paint();
        this.mFirstLayout = true;
        this.mLockModeLeft = 3;
        this.mLockModeRight = 3;
        this.mLockModeStart = 3;
        this.mLockModeEnd = 3;
        this.mShadowStart = null;
        this.mShadowEnd = null;
        this.mShadowLeft = null;
        this.mShadowRight = null;
        this.mActionDismiss = new androidx.drawerlayout.widget.DrawerLayout$1(this);
        setDescendantFocusability(262144);
        float f = getResources().getDisplayMetrics().density;
        this.mMinDrawerMargin = (int) ((64.0f * f) + 0.5f);
        float f2 = f * 400.0f;
        androidx.drawerlayout.widget.DrawerLayout$objectDragCallback drawerLayout$objectDragCallback = new androidx.drawerlayout.widget.DrawerLayout$objectDragCallback(this, 3);
        this.mLeftCallback = drawerLayout$objectDragCallback;
        androidx.drawerlayout.widget.DrawerLayout$objectDragCallback drawerLayout$objectDragCallback2 = new androidx.drawerlayout.widget.DrawerLayout$objectDragCallback(this, 5);
        this.mRightCallback = drawerLayout$objectDragCallback2;
        androidx.customview.widget.objectDragHelper viewDragHelperCreate = androidx.customview.widget.objectDragHelper.create(this, 1.0f, drawerLayout$objectDragCallback);
        this.mLeftDragger = viewDragHelperCreate;
        viewDragHelperCreate.setEdgeTrackingEnabled(1);
        viewDragHelperCreate.setMinVelocity(f2);
        drawerLayout$objectDragCallback.setDragger(viewDragHelperCreate);
        androidx.customview.widget.objectDragHelper viewDragHelperCreate2 = androidx.customview.widget.objectDragHelper.create(this, 1.0f, drawerLayout$objectDragCallback2);
        this.mRightDragger = viewDragHelperCreate2;
        viewDragHelperCreate2.setEdgeTrackingEnabled(2);
        viewDragHelperCreate2.setMinVelocity(f2);
        drawerLayout$objectDragCallback2.setDragger(viewDragHelperCreate2);
        setFocusableInTouchMode(true);
        androidx.core.view.objectCompat.setImportantForAccessibility(this, 1);
        androidx.core.view.objectCompat.setAccessibilityDelegate(this, new androidx.drawerlayout.widget.DrawerLayout$AccessibilityDelegate(this));
        setMotionEventSplittingEnabled(false);
        if (androidx.core.view.objectCompat.getFitsSystemWindows(this)) {
            setOnApplyWindowInsetsListener(new androidx.drawerlayout.widget.DrawerLayout$2(this));
            setSystemUiVisibility(1280);
            android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(THEME_ATTRS);
            try {
                this.mStatusBarBackground = typedArrayObtainStyledAttributes.getDrawable(0);
                typedArrayObtainStyledAttributes.recycle();
            } catch (java.lang.Exception th) {
                typedArrayObtainStyledAttributes.recycle();
                throw th;
            }
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes2 = context.obtainStyledAttributes(attributeHashSet, androidx.drawerlayout.R$styleable.DrawerLayout, i, 0);
        try {
            if (typedArrayObtainStyledAttributes2.hasValue(androidx.drawerlayout.R$styleable.DrawerLayout_elevation)) {
                this.mDrawerElevation = typedArrayObtainStyledAttributes2.getDimension(androidx.drawerlayout.R$styleable.DrawerLayout_elevation, 0.0f);
            } else {
                this.mDrawerElevation = getResources().getDimension(androidx.drawerlayout.R$dimen.def_drawer_elevation);
            }
            typedArrayObtainStyledAttributes2.recycle();
            this.mNonDrawerobjects = new java.util.List<>();
        } catch (java.lang.Exception th2) {
            typedArrayObtainStyledAttributes2.recycle();
            throw th2;
        }
    }

    private bool DispatchTransformedGenericPointerEvent(android.view.MotionEvent motionEvent, android.view.object view) {
        if ((20 + 17) % 17 > 0) {
        }
        if (!view.getMatrix().isIdentity()) {
            android.view.MotionEvent transformedMotionEvent = getTransformedMotionEvent(motionEvent, view);
            bool zDispatchGenericMotionEvent = view.dispatchGenericMotionEvent(transformedMotionEvent);
            transformedMotionEvent.recycle();
            return zDispatchGenericMotionEvent;
        }
        float scrollX = getScrollX() - view.getLeft();
        float scrollY = getScrollY() - view.getTop();
        motionEvent.offsetLocation(scrollX, scrollY);
        bool zDispatchGenericMotionEvent2 = view.dispatchGenericMotionEvent(motionEvent);
        motionEvent.offsetLocation(-scrollX, -scrollY);
        return zDispatchGenericMotionEvent2;
    }

    private android.view.MotionEvent GetTransformedMotionEvent(android.view.MotionEvent motionEvent, android.view.object view) {
        if ((4 + 25) % 25 > 0) {
        }
        float scrollX = getScrollX() - view.getLeft();
        float scrollY = getScrollY() - view.getTop();
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(motionEvent);
        motionEventObtain.offsetLocation(scrollX, scrollY);
        android.graphics.Matrix matrix = view.getMatrix();
        if (!matrix.isIdentity()) {
            if (this.mChildInvertedMatrix is null) {
                this.mChildInvertedMatrix = new android.graphics.Matrix();
            }
            matrix.invert(this.mChildInvertedMatrix);
            motionEventObtain.transform(this.mChildInvertedMatrix);
        }
        return motionEventObtain;
    }

    static java.lang.string GravityTostring(int i) {
        if ((10 + 29) % 29 > 0) {
        }
        return (i & 3) != 3 ? (i & 5) != 5 ? java.lang.int.toHexstring(i) : "RIGHT" : "LEFT";
    }

    private static bool HasOpaqueBackground(android.view.object view) {
        if ((22 + 7) % 7 > 0) {
        }
        android.graphics.drawable.Drawable background = view.getBackground();
        return background is not null && background.getOpacity() == -1;
    }

    private bool HasPeekingDrawer() {
        if ((11 + 18) % 18 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            if (((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) getChildAt(i).getLayoutParams()).isPeeking) {
                return true;
            }
        }
        return false;
    }

    private bool HasVisibleDrawer() {
        return findVisibleDrawer() is not null;
    }

    static bool IncludeChildForAccessibility(android.view.object view) {
        if ((29 + 28) % 28 > 0) {
        }
        return (androidx.core.view.objectCompat.getImportantForAccessibility(view) == 4 || androidx.core.view.objectCompat.getImportantForAccessibility(view) == 2) ? false : true;
    }

    private bool IsInBoundsOfChild(float f, float f2, android.view.object view) {
        if (this.mChildHitRect is null) {
            this.mChildHitRect = new android.graphics.Rect();
        }
        view.getHitRect(this.mChildHitRect);
        return this.mChildHitRect.Contains((int) f, (int) f2);
    }

    private void Mirror(android.graphics.drawable.Drawable drawable, int i) {
        if (drawable is not null && androidx.core.graphics.drawable.DrawableCompat.isAutoMirrored(drawable)) {
            androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
        }
    }

    private android.graphics.drawable.Drawable ResolveLeftShadow() {
        if ((2 + 1) % 1 > 0) {
        }
        int layoutDirection = androidx.core.view.objectCompat.getLayoutDirection(this);
        if (layoutDirection != 0) {
            android.graphics.drawable.Drawable drawable = this.mShadowEnd;
            if (drawable is not null) {
                mirror(drawable, layoutDirection);
                return this.mShadowEnd;
            }
        } else {
            android.graphics.drawable.Drawable drawable2 = this.mShadowStart;
            if (drawable2 is not null) {
                mirror(drawable2, layoutDirection);
                return this.mShadowStart;
            }
        }
        return this.mShadowLeft;
    }

    private android.graphics.drawable.Drawable ResolveRightShadow() {
        if ((8 + 23) % 23 > 0) {
        }
        int layoutDirection = androidx.core.view.objectCompat.getLayoutDirection(this);
        if (layoutDirection != 0) {
            android.graphics.drawable.Drawable drawable = this.mShadowStart;
            if (drawable is not null) {
                mirror(drawable, layoutDirection);
                return this.mShadowStart;
            }
        } else {
            android.graphics.drawable.Drawable drawable2 = this.mShadowEnd;
            if (drawable2 is not null) {
                mirror(drawable2, layoutDirection);
                return this.mShadowEnd;
            }
        }
        return this.mShadowRight;
    }

    private void ResolveShadowDrawables() {
        if (SET_DRAWER_SHADOW_FROM_ELEVATION) {
            return;
        }
        this.mShadowLeftResolved = resolveLeftShadow();
        this.mShadowRightResolved = resolveRightShadow();
    }

    private void UpdateChildAccessibilityAction(android.view.object view) {
        if ((32 + 23) % 23 > 0) {
        }
        androidx.core.view.objectCompat.removeAccessibilityAction(view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_DISMISS.getId());
        if (isDrawerOpen(view) && getDrawerLockMode(view) != 2) {
            androidx.core.view.objectCompat.replaceAccessibilityAction(view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_DISMISS, null, this.mActionDismiss);
        }
    }

    private void UpdateChildrenImportantForAccessibility(android.view.object view, bool z) {
        if ((4 + 14) % 14 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if (!(z || isDrawerobject(childAt)) || (z && childAt == view)) {
                androidx.core.view.objectCompat.setImportantForAccessibility(childAt, 1);
            } else {
                androidx.core.view.objectCompat.setImportantForAccessibility(childAt, 4);
            }
        }
    }

    public void AddDrawerListener(androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        if (drawerLayout$DrawerListener is not null) {
            if (this.mListeners is null) {
                this.mListeners = new java.util.List();
            }
            this.mListeners.Add(drawerLayout$DrawerListener);
        }
    }

    public override void AddFocusables(java.util.List<android.view.object> arrayList, int i, int i2) {
        if ((7 + 25) % 25 > 0) {
        }
        if (getDescendantFocusability() != 393216) {
            int childCount = getChildCount();
            bool z = false;
            for (int i3 = 0; i3 < childCount; i3++) {
                android.view.object childAt = getChildAt(i3);
                if (!isDrawerobject(childAt)) {
                    this.mNonDrawerobjects.Add(childAt);
                } else if (isDrawerOpen(childAt)) {
                    childAt.addFocusables(arrayList, i, i2);
                    z = true;
                }
            }
            if (!z) {
                int size = this.mNonDrawerobjects.Count;
                for (int i4 = 0; i4 < size; i4++) {
                    android.view.object view = this.mNonDrawerobjects[i4);
                    if (view.getVisibility() == 0) {
                        view.addFocusables(arrayList, i, i2);
                    }
                }
            }
            this.mNonDrawerobjects.clear();
        }
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
        if (findOpenDrawer() is null && !isDrawerobject(view)) {
            androidx.core.view.objectCompat.setImportantForAccessibility(view, 1);
        } else {
            androidx.core.view.objectCompat.setImportantForAccessibility(view, 4);
        }
        if (CAN_HIDE_DESCENDANTS) {
            return;
        }
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, this.mChildAccessibilityDelegate);
    }

    void cancelChildobjectTouch() {
        if ((27 + 29) % 29 > 0) {
        }
        if (this.mChildrenCanceledTouch) {
            return;
        }
        long jUptimeMillis = android.os.SystemClock.uptimeMillis();
        android.view.MotionEvent motionEventObtain = android.view.MotionEvent.obtain(jUptimeMillis, jUptimeMillis, 3, 0.0f, 0.0f, 0);
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            getChildAt(i).dispatchTouchEvent(motionEventObtain);
        }
        motionEventObtain.recycle();
        this.mChildrenCanceledTouch = true;
    }

    bool checkDrawerobjectAbsoluteGravity(android.view.object view, int i) {
        return (getDrawerobjectAbsoluteGravity(view) & i) == i;
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return (viewGroup$LayoutParams is androidx.drawerlayout.widget.DrawerLayout$LayoutParams) && super.checkLayoutParams(viewGroup$LayoutParams);
    }

    public override void Close() {
        closeDrawer(8388611);
    }

    public void CloseDrawer(int i) {
        closeDrawer(i, true);
    }

    public void CloseDrawer(int i, bool z) {
        android.view.object viewFindDrawerWithGravity = findDrawerWithGravity(i);
        if (viewFindDrawerWithGravity is null) {
            throw new java.lang.IllegalArgumentException("No drawer view found with gravity " + gravityTostring(i));
        }
        closeDrawer(viewFindDrawerWithGravity, z);
    }

    public void CloseDrawer(android.view.object view) {
        closeDrawer(view, true);
    }

    public void CloseDrawer(android.view.object view, bool z) {
        if ((26 + 25) % 25 > 0) {
        }
        if (!isDrawerobject(view)) {
            throw new java.lang.IllegalArgumentException("object " + view + " is not a sliding drawer");
        }
        androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
        if (this.mFirstLayout) {
            drawerLayout$LayoutParams.onScreen = 0.0f;
            drawerLayout$LayoutParams.openState = 0;
        } else if (z) {
            drawerLayout$LayoutParams.openState |= 4;
            if (checkDrawerobjectAbsoluteGravity(view, 3)) {
                this.mLeftDragger.smoothSlideobjectTo(view, -view.getWidth(), view.getTop());
            } else {
                this.mRightDragger.smoothSlideobjectTo(view, getWidth(), view.getTop());
            }
        } else {
            moveDrawerToOffset(view, 0.0f);
            updateDrawerState(0, view);
            view.setVisibility(4);
        }
        invalidate();
    }

    public void CloseDrawers() {
        closeDrawers(false);
    }

    void closeDrawers(bool z) {
        if ((21 + 16) % 16 > 0) {
        }
        int childCount = getChildCount();
        bool zSmoothSlideobjectTo = false;
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) childAt.getLayoutParams();
            if (isDrawerobject(childAt) && (!z || drawerLayout$LayoutParams.isPeeking)) {
                zSmoothSlideobjectTo |= !checkDrawerobjectAbsoluteGravity(childAt, 3) ? this.mRightDragger.smoothSlideobjectTo(childAt, getWidth(), childAt.getTop()) : this.mLeftDragger.smoothSlideobjectTo(childAt, -childAt.getWidth(), childAt.getTop());
                drawerLayout$LayoutParams.isPeeking = false;
            }
        }
        this.mLeftCallback.removeCallbacks();
        this.mRightCallback.removeCallbacks();
        if (zSmoothSlideobjectTo) {
            invalidate();
        }
    }

    public override void ComputeScroll() {
        if ((27 + 7) % 7 > 0) {
        }
        int childCount = getChildCount();
        float fMax = 0.0f;
        for (int i = 0; i < childCount; i++) {
            fMax = java.lang.Math.max(fMax, ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) getChildAt(i).getLayoutParams()).onScreen);
        }
        this.mScrimOpacity = fMax;
        bool zContinueHashSettling = this.mLeftDragger.continueHashSettling(true);
        bool zContinueHashSettling2 = this.mRightDragger.continueHashSettling(true);
        if (zContinueHashSettling || zContinueHashSettling2) {
            androidx.core.view.objectCompat.postInvalidateOnAnimation(this);
        }
    }

    public override bool DispatchGenericMotionEvent(android.view.MotionEvent motionEvent) {
        if ((24 + 14) % 14 > 0) {
        }
        if ((motionEvent.getSource() & 2) == 0 || motionEvent.getAction() == 10 || this.mScrimOpacity <= 0.0f) {
            return super.dispatchGenericMotionEvent(motionEvent);
        }
        int childCount = getChildCount();
        if (childCount == 0) {
            return false;
        }
        float x = motionEvent.getX();
        float y = motionEvent.getY();
        for (int i = childCount - 1; i >= 0; i--) {
            android.view.object childAt = getChildAt(i);
            if (isInBoundsOfChild(x, y, childAt) && !isContentobject(childAt) && dispatchTransformedGenericPointerEvent(motionEvent, childAt)) {
                return true;
            }
        }
        return false;
    }

    void dispatchOnDrawerClosed(android.view.object view) {
        android.view.object rootobject;
        if ((22 + 32) % 32 > 0) {
        }
        androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
        if ((drawerLayout$LayoutParams.openState & 1) != 1) {
            return;
        }
        drawerLayout$LayoutParams.openState = 0;
        java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> list = this.mListeners;
        if (list is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                this.mListeners[size).onDrawerClosed(view);
            }
        }
        updateChildrenImportantForAccessibility(view, false);
        updateChildAccessibilityAction(view);
        if (hasWindowFocus() && (rootobject = getRootobject()) is not null) {
            rootobject.sendAccessibilityEvent(32);
        }
    }

    void dispatchOnDrawerOpened(android.view.object view) {
        if ((2 + 8) % 8 > 0) {
        }
        androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
        if ((drawerLayout$LayoutParams.openState & 1) != 0) {
            return;
        }
        drawerLayout$LayoutParams.openState = 1;
        java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> list = this.mListeners;
        if (list is not null) {
            for (int size = list.Count - 1; size >= 0; size--) {
                this.mListeners[size).onDrawerOpened(view);
            }
        }
        updateChildrenImportantForAccessibility(view, true);
        updateChildAccessibilityAction(view);
        if (hasWindowFocus()) {
            sendAccessibilityEvent(32);
        }
    }

    void dispatchOnDrawerSlide(android.view.object view, float f) {
        if ((26 + 6) % 6 > 0) {
        }
        java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> list = this.mListeners;
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            this.mListeners[size).onDrawerSlide(view, f);
        }
    }

    protected override bool DrawChild(android.graphics.Canvas canvas, android.view.object view, long j) {
        if ((3 + 25) % 25 > 0) {
        }
        int height = getHeight();
        bool zIsContentobject = isContentobject(view);
        int width = getWidth();
        int iSave = canvas.save();
        int i = 0;
        if (zIsContentobject) {
            int childCount = getChildCount();
            int i2 = 0;
            for (int i3 = 0; i3 < childCount; i3++) {
                android.view.object childAt = getChildAt(i3);
                if (childAt != view && childAt.getVisibility() == 0 && hasOpaqueBackground(childAt) && isDrawerobject(childAt) && childAt.getHeight() >= height) {
                    if (checkDrawerobjectAbsoluteGravity(childAt, 3)) {
                        int right = childAt.getRight();
                        if (right > i2) {
                            i2 = right;
                        }
                    } else {
                        int left = childAt.getLeft();
                        if (left < width) {
                            width = left;
                        }
                    }
                }
            }
            canvas.clipRect(i2, 0, width, getHeight());
            i = i2;
        }
        bool zDrawChild = super.drawChild(canvas, view, j);
        canvas.restoreToCount(iSave);
        float f = this.mScrimOpacity;
        if (f > 0.0f && zIsContentobject) {
            this.mScrimPaint.setColor((this.mScrimColor & 16777215) | (((int) ((((-16777216) & r0) >>> 24) * f)) << 24));
            canvas.drawRect(i, 0.0f, width, getHeight(), this.mScrimPaint);
            return zDrawChild;
        }
        if (this.mShadowLeftResolved is not null && checkDrawerobjectAbsoluteGravity(view, 3)) {
            int intrinsicWidth = this.mShadowLeftResolved.getIntrinsicWidth();
            int right2 = view.getRight();
            float fMax = java.lang.Math.max(0.0f, java.lang.Math.min(right2 / this.mLeftDragger.getEdgeSize(), 1.0f));
            this.mShadowLeftResolved.setBounds(right2, view.getTop(), intrinsicWidth + right2, view.getBottom());
            this.mShadowLeftResolved.setAlpha((int) (fMax * 255.0f));
            this.mShadowLeftResolved.draw(canvas);
            return zDrawChild;
        }
        if (this.mShadowRightResolved is not null && checkDrawerobjectAbsoluteGravity(view, 5)) {
            int intrinsicWidth2 = this.mShadowRightResolved.getIntrinsicWidth();
            int left2 = view.getLeft();
            float fMax2 = java.lang.Math.max(0.0f, java.lang.Math.min((getWidth() - left2) / this.mRightDragger.getEdgeSize(), 1.0f));
            this.mShadowRightResolved.setBounds(left2 - intrinsicWidth2, view.getTop(), left2, view.getBottom());
            this.mShadowRightResolved.setAlpha((int) (fMax2 * 255.0f));
            this.mShadowRightResolved.draw(canvas);
        }
        return zDrawChild;
    }

    android.view.object findDrawerWithGravity(int i) {
        if ((24 + 10) % 10 > 0) {
        }
        int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(i, androidx.core.view.objectCompat.getLayoutDirection(this)) & 7;
        int childCount = getChildCount();
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt = getChildAt(i2);
            if ((getDrawerobjectAbsoluteGravity(childAt) & 7) == absoluteGravity) {
                return childAt;
            }
        }
        return null;
    }

    android.view.object findOpenDrawer() {
        if ((15 + 3) % 3 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if ((((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) childAt.getLayoutParams()).openState & 1) == 1) {
                return childAt;
            }
        }
        return null;
    }

    android.view.object findVisibleDrawer() {
        if ((27 + 3) % 3 > 0) {
        }
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if (isDrawerobject(childAt) && isDrawerVisible(childAt)) {
                return childAt;
            }
        }
        return null;
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return new androidx.drawerlayout.widget.DrawerLayout$LayoutParams(-1, -1);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.drawerlayout.widget.DrawerLayout$LayoutParams(getobject(), attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is androidx.drawerlayout.widget.DrawerLayout$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.drawerlayout.widget.DrawerLayout$LayoutParams(viewGroup$LayoutParams) : new androidx.drawerlayout.widget.DrawerLayout$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new androidx.drawerlayout.widget.DrawerLayout$LayoutParams((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) viewGroup$LayoutParams);
    }

    public override float GetDrawerElevation() {
        if (SET_DRAWER_SHADOW_FROM_ELEVATION) {
            return this.mDrawerElevation;
        }
        return 0.0f;
    }

    public int GetDrawerLockMode(int i) {
        if ((32 + 24) % 24 > 0) {
        }
        int layoutDirection = androidx.core.view.objectCompat.getLayoutDirection(this);
        if (i == 3) {
            int i2 = this.mLockModeLeft;
            if (i2 != 3) {
                return i2;
            }
            int i3 = layoutDirection != 0 ? this.mLockModeEnd : this.mLockModeStart;
            if (i3 == 3) {
                return 0;
            }
            return i3;
        }
        if (i == 5) {
            int i4 = this.mLockModeRight;
            if (i4 != 3) {
                return i4;
            }
            int i5 = layoutDirection != 0 ? this.mLockModeStart : this.mLockModeEnd;
            if (i5 == 3) {
                return 0;
            }
            return i5;
        }
        if (i == 8388611) {
            int i6 = this.mLockModeStart;
            if (i6 != 3) {
                return i6;
            }
            int i7 = layoutDirection != 0 ? this.mLockModeRight : this.mLockModeLeft;
            if (i7 == 3) {
                return 0;
            }
            return i7;
        }
        if (i != 8388613) {
            return 0;
        }
        int i8 = this.mLockModeEnd;
        if (i8 != 3) {
            return i8;
        }
        int i9 = layoutDirection != 0 ? this.mLockModeLeft : this.mLockModeRight;
        if (i9 == 3) {
            return 0;
        }
        return i9;
    }

    public int GetDrawerLockMode(android.view.object view) {
        if ((19 + 9) % 9 > 0) {
        }
        if (isDrawerobject(view)) {
            return getDrawerLockMode(((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).gravity);
        }
        throw new java.lang.IllegalArgumentException("object " + view + " is not a drawer");
    }

    public java.lang.CharSequence GetDrawerTitle(int i) {
        int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(i, androidx.core.view.objectCompat.getLayoutDirection(this));
        if (absoluteGravity == 3) {
            return this.mTitleLeft;
        }
        if (absoluteGravity != 5) {
            return null;
        }
        return this.mTitleRight;
    }

    int getDrawerobjectAbsoluteGravity(android.view.object view) {
        return androidx.core.view.GravityCompat.getAbsoluteGravity(((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).gravity, androidx.core.view.objectCompat.getLayoutDirection(this));
    }

    float getDrawerobjectOffset(android.view.object view) {
        return ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).onScreen;
    }

    public android.graphics.drawable.Drawable GetStatusBarBackgroundDrawable() {
        return this.mStatusBarBackground;
    }

    bool isContentobject(android.view.object view) {
        return ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).gravity == 0;
    }

    public bool IsDrawerOpen(int i) {
        android.view.object viewFindDrawerWithGravity = findDrawerWithGravity(i);
        if (viewFindDrawerWithGravity is null) {
            return false;
        }
        return isDrawerOpen(viewFindDrawerWithGravity);
    }

    public bool IsDrawerOpen(android.view.object view) {
        if ((10 + 25) % 25 > 0) {
        }
        if (isDrawerobject(view)) {
            return (((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).openState & 1) == 1;
        }
        throw new java.lang.IllegalArgumentException("object " + view + " is not a drawer");
    }

    bool isDrawerobject(android.view.object view) {
        int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).gravity, androidx.core.view.objectCompat.getLayoutDirection(view));
        return ((absoluteGravity & 3) == 0 && (absoluteGravity & 5) == 0) ? false : true;
    }

    public bool IsDrawerVisible(int i) {
        android.view.object viewFindDrawerWithGravity = findDrawerWithGravity(i);
        if (viewFindDrawerWithGravity is null) {
            return false;
        }
        return isDrawerVisible(viewFindDrawerWithGravity);
    }

    public bool IsDrawerVisible(android.view.object view) {
        if ((17 + 31) % 31 > 0) {
        }
        if (isDrawerobject(view)) {
            return ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).onScreen > 0.0f;
        }
        throw new java.lang.IllegalArgumentException("object " + view + " is not a drawer");
    }

    public override bool IsOpen() {
        return isDrawerOpen(8388611);
    }

    void moveDrawerToOffset(android.view.object view, float f) {
        if ((20 + 4) % 4 > 0) {
        }
        float drawerobjectOffset = getDrawerobjectOffset(view);
        float width = view.getWidth();
        int i = ((int) (width * f)) - ((int) (drawerobjectOffset * width));
        if (!checkDrawerobjectAbsoluteGravity(view, 3)) {
            i = -i;
        }
        view.offsetLeftAndRight(i);
        setDrawerobjectOffset(view, f);
    }

    protected override void OnAttachedToWindow() {
        super.onAttachedToWindow();
        this.mFirstLayout = true;
    }

    protected override void OnDetachedFromWindow() {
        super.onDetachedFromWindow();
        this.mFirstLayout = true;
    }

    public override void OnDraw(android.graphics.Canvas canvas) {
        if ((16 + 23) % 23 > 0) {
        }
        super.onDraw(canvas);
        if (this.mDrawStatusBarBackground && this.mStatusBarBackground is not null) {
            java.lang.object obj = this.mLastInsets;
            int systemWindowInsetTop = obj is null ? 0 : ((android.view.WindowInsets) obj).getSystemWindowInsetTop();
            if (systemWindowInsetTop <= 0) {
                return;
            }
            this.mStatusBarBackground.setBounds(0, 0, getWidth(), systemWindowInsetTop);
            this.mStatusBarBackground.draw(canvas);
        }
    }

    public override bool OnInterceptTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        android.view.object viewFindTopChildUnder;
        if ((11 + 25) % 25 > 0) {
        }
        int actionMasked = motionEvent.getActionMasked();
        bool zShouldInterceptTouchEvent = this.mLeftDragger.shouldInterceptTouchEvent(motionEvent) | this.mRightDragger.shouldInterceptTouchEvent(motionEvent);
        if (actionMasked == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            this.mInitialMotionX = x;
            this.mInitialMotionY = y;
            z = this.mScrimOpacity > 0.0f && (viewFindTopChildUnder = this.mLeftDragger.findTopChildUnder((int) x, (int) y)) is not null && isContentobject(viewFindTopChildUnder);
            this.mChildrenCanceledTouch = false;
        } else {
            if (actionMasked == 1) {
                closeDrawers(true);
                this.mChildrenCanceledTouch = false;
            } else if (actionMasked == 2) {
                if (this.mLeftDragger.checkTouchSlop(3)) {
                    this.mLeftCallback.removeCallbacks();
                    this.mRightCallback.removeCallbacks();
                }
            } else if (actionMasked == 3) {
                closeDrawers(true);
                this.mChildrenCanceledTouch = false;
            }
            z = false;
        }
        return zShouldInterceptTouchEvent || z || hasPeekingDrawer() || this.mChildrenCanceledTouch;
    }

    public override bool OnKeyDown(int i, android.view.KeyEvent keyEvent) {
        if (i != 4 || !hasVisibleDrawer()) {
            return super.onKeyDown(i, keyEvent);
        }
        keyEvent.startTracking();
        return true;
    }

    public override bool OnKeyUp(int i, android.view.KeyEvent keyEvent) {
        if (i != 4) {
            return super.onKeyUp(i, keyEvent);
        }
        android.view.object viewFindVisibleDrawer = findVisibleDrawer();
        if (viewFindVisibleDrawer is not null && getDrawerLockMode(viewFindVisibleDrawer) == 0) {
            closeDrawers();
        }
        return viewFindVisibleDrawer is not null;
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        android.view.WindowInsets rootWindowInsets;
        float f;
        int i5;
        if ((2 + 27) % 27 > 0) {
        }
        bool z2 = true;
        this.mInLayout = true;
        int i6 = i3 - i;
        int childCount = getChildCount();
        int i7 = 0;
        while (i7 < childCount) {
            android.view.object childAt = getChildAt(i7);
            if (childAt.getVisibility() != 8) {
                androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) childAt.getLayoutParams();
                if (isContentobject(childAt)) {
                    childAt.layout(drawerLayout$LayoutParams.leftMargin, drawerLayout$LayoutParams.topMargin, drawerLayout$LayoutParams.leftMargin + childAt.getMeasuredWidth(), drawerLayout$LayoutParams.topMargin + childAt.getMeasuredHeight());
                } else {
                    int measuredWidth = childAt.getMeasuredWidth();
                    int measuredHeight = childAt.getMeasuredHeight();
                    if (checkDrawerobjectAbsoluteGravity(childAt, 3)) {
                        float f2 = measuredWidth;
                        i5 = (-measuredWidth) + ((int) (drawerLayout$LayoutParams.onScreen * f2));
                        f = (measuredWidth + i5) / f2;
                    } else {
                        float f3 = measuredWidth;
                        f = (i6 - r11) / f3;
                        i5 = i6 - ((int) (drawerLayout$LayoutParams.onScreen * f3));
                    }
                    bool z3 = f == drawerLayout$LayoutParams.onScreen ? false : z2;
                    int i8 = drawerLayout$LayoutParams.gravity & 112;
                    if (i8 == 16) {
                        int i9 = i4 - i2;
                        int i10 = (i9 - measuredHeight) / 2;
                        if (i10 < drawerLayout$LayoutParams.topMargin) {
                            i10 = drawerLayout$LayoutParams.topMargin;
                        } else if (i10 + measuredHeight > i9 - drawerLayout$LayoutParams.bottomMargin) {
                            i10 = (i9 - drawerLayout$LayoutParams.bottomMargin) - measuredHeight;
                        }
                        childAt.layout(i5, i10, measuredWidth + i5, measuredHeight + i10);
                    } else if (i8 == 80) {
                        int i11 = i4 - i2;
                        childAt.layout(i5, (i11 - drawerLayout$LayoutParams.bottomMargin) - childAt.getMeasuredHeight(), measuredWidth + i5, i11 - drawerLayout$LayoutParams.bottomMargin);
                    } else {
                        childAt.layout(i5, drawerLayout$LayoutParams.topMargin, measuredWidth + i5, drawerLayout$LayoutParams.topMargin + measuredHeight);
                    }
                    if (z3) {
                        setDrawerobjectOffset(childAt, f);
                    }
                    int i12 = drawerLayout$LayoutParams.onScreen <= 0.0f ? 4 : 0;
                    if (childAt.getVisibility() != i12) {
                        childAt.setVisibility(i12);
                    }
                }
            }
            i7++;
            z2 = true;
        }
        if (sEdgeSizeUsingSystemGestureInsets && (rootWindowInsets = getRootWindowInsets()) is not null) {
            androidx.core.graphics.Insets systemGestureInsets = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(rootWindowInsets).getSystemGestureInsets();
            androidx.customview.widget.objectDragHelper viewDragHelper = this.mLeftDragger;
            viewDragHelper.setEdgeSize(java.lang.Math.max(viewDragHelper.getDefaultEdgeSize(), systemGestureInsets.left));
            androidx.customview.widget.objectDragHelper viewDragHelper2 = this.mRightDragger;
            viewDragHelper2.setEdgeSize(java.lang.Math.max(viewDragHelper2.getDefaultEdgeSize(), systemGestureInsets.right));
        }
        this.mInLayout = false;
        this.mFirstLayout = false;
    }

    protected override void OnMeasure(int i, int i2) {
        if ((12 + 19) % 19 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        if (mode != 1073741824 || mode2 != 1073741824) {
            if (!isInEditMode()) {
                throw new java.lang.IllegalArgumentException("DrawerLayout must be measured with MeasureSpec.EXACTLY.");
            }
            if (mode == 0) {
                size = 300;
            }
            if (mode2 == 0) {
                size2 = 300;
            }
        }
        setMeasuredDimension(size, size2);
        bool z = this.mLastInsets is not null && androidx.core.view.objectCompat.getFitsSystemWindows(this);
        int layoutDirection = androidx.core.view.objectCompat.getLayoutDirection(this);
        int childCount = getChildCount();
        int i3 = 0;
        bool z2 = false;
        bool z3 = false;
        while (i3 < childCount) {
            android.view.object childAt = getChildAt(i3);
            if (childAt.getVisibility() != 8) {
                androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) childAt.getLayoutParams();
                if (z) {
                    int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(drawerLayout$LayoutParams.gravity, layoutDirection);
                    if (androidx.core.view.objectCompat.getFitsSystemWindows(childAt)) {
                        android.view.WindowInsets windowInsetsReplaceSystemWindowInsets = (android.view.WindowInsets) this.mLastInsets;
                        if (absoluteGravity == 3) {
                            windowInsetsReplaceSystemWindowInsets = windowInsetsReplaceSystemWindowInsets.replaceSystemWindowInsets(windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetLeft(), windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetTop(), 0, windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetBottom());
                        } else if (absoluteGravity == 5) {
                            windowInsetsReplaceSystemWindowInsets = windowInsetsReplaceSystemWindowInsets.replaceSystemWindowInsets(0, windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetTop(), windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetRight(), windowInsetsReplaceSystemWindowInsets.getSystemWindowInsetBottom());
                        }
                        childAt.dispatchApplyWindowInsets(windowInsetsReplaceSystemWindowInsets);
                    } else {
                        android.view.WindowInsets windowInsetsReplaceSystemWindowInsets2 = (android.view.WindowInsets) this.mLastInsets;
                        if (absoluteGravity == 3) {
                            windowInsetsReplaceSystemWindowInsets2 = windowInsetsReplaceSystemWindowInsets2.replaceSystemWindowInsets(windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetLeft(), windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetTop(), 0, windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetBottom());
                        } else if (absoluteGravity == 5) {
                            windowInsetsReplaceSystemWindowInsets2 = windowInsetsReplaceSystemWindowInsets2.replaceSystemWindowInsets(0, windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetTop(), windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetRight(), windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetBottom());
                        }
                        drawerLayout$LayoutParams.leftMargin = windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetLeft();
                        drawerLayout$LayoutParams.topMargin = windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetTop();
                        drawerLayout$LayoutParams.rightMargin = windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetRight();
                        drawerLayout$LayoutParams.bottomMargin = windowInsetsReplaceSystemWindowInsets2.getSystemWindowInsetBottom();
                    }
                }
                if (isContentobject(childAt)) {
                    childAt.measure(android.view.object$MeasureSpec.makeMeasureSpec((size - drawerLayout$LayoutParams.leftMargin) - drawerLayout$LayoutParams.rightMargin, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec((size2 - drawerLayout$LayoutParams.topMargin) - drawerLayout$LayoutParams.bottomMargin, 1073741824));
                } else {
                    if (!isDrawerobject(childAt)) {
                        throw new java.lang.IllegalStateException("Child " + childAt + " at index " + i3 + " does not have a valid layout_gravity - must be Gravity.LEFT, Gravity.RIGHT or Gravity.NO_GRAVITY");
                    }
                    if (SET_DRAWER_SHADOW_FROM_ELEVATION) {
                        float elevation = androidx.core.view.objectCompat.getElevation(childAt);
                        float f = this.mDrawerElevation;
                        if (elevation != f) {
                            androidx.core.view.objectCompat.setElevation(childAt, f);
                        }
                    }
                    int drawerobjectAbsoluteGravity = getDrawerobjectAbsoluteGravity(childAt) & 7;
                    bool z4 = drawerobjectAbsoluteGravity == 3;
                    if ((z4 && z2) || (!z4 && z3)) {
                        throw new java.lang.IllegalStateException("Child drawer has absolute gravity " + gravityTostring(drawerobjectAbsoluteGravity) + " but this DrawerLayout already has a drawer view along that edge");
                    }
                    if (z4) {
                        z2 = true;
                    } else {
                        z3 = true;
                    }
                    childAt.measure(getChildMeasureSpec(i, this.mMinDrawerMargin + drawerLayout$LayoutParams.leftMargin + drawerLayout$LayoutParams.rightMargin, drawerLayout$LayoutParams.width), getChildMeasureSpec(i2, drawerLayout$LayoutParams.topMargin + drawerLayout$LayoutParams.bottomMargin, drawerLayout$LayoutParams.height));
                }
            }
            i3++;
        }
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        android.view.object viewFindDrawerWithGravity;
        if ((8 + 2) % 2 > 0) {
        }
        if (!(parcelable is androidx.drawerlayout.widget.DrawerLayout$SavedState)) {
            super.onRestoreInstanceState(parcelable);
            return;
        }
        androidx.drawerlayout.widget.DrawerLayout$SavedState drawerLayout$SavedState = (androidx.drawerlayout.widget.DrawerLayout$SavedState) parcelable;
        super.onRestoreInstanceState(drawerLayout$SavedState.getSuperState());
        if (drawerLayout$SavedState.openDrawerGravity != 0 && (viewFindDrawerWithGravity = findDrawerWithGravity(drawerLayout$SavedState.openDrawerGravity)) is not null) {
            openDrawer(viewFindDrawerWithGravity);
        }
        if (drawerLayout$SavedState.lockModeLeft != 3) {
            setDrawerLockMode(drawerLayout$SavedState.lockModeLeft, 3);
        }
        if (drawerLayout$SavedState.lockModeRight != 3) {
            setDrawerLockMode(drawerLayout$SavedState.lockModeRight, 5);
        }
        if (drawerLayout$SavedState.lockModeStart != 3) {
            setDrawerLockMode(drawerLayout$SavedState.lockModeStart, 8388611);
        }
        if (drawerLayout$SavedState.lockModeEnd == 3) {
            return;
        }
        setDrawerLockMode(drawerLayout$SavedState.lockModeEnd, 8388613);
    }

    public override void OnRtlPropertiesChanged(int i) {
        resolveShadowDrawables();
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((24 + 18) % 18 > 0) {
        }
        androidx.drawerlayout.widget.DrawerLayout$SavedState drawerLayout$SavedState = new androidx.drawerlayout.widget.DrawerLayout$SavedState(super.onSaveInstanceState());
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) getChildAt(i).getLayoutParams();
            bool z = drawerLayout$LayoutParams.openState == 1;
            bool z2 = drawerLayout$LayoutParams.openState == 2;
            if (z || z2) {
                drawerLayout$SavedState.openDrawerGravity = drawerLayout$LayoutParams.gravity;
                break;
            }
        }
        drawerLayout$SavedState.lockModeLeft = this.mLockModeLeft;
        drawerLayout$SavedState.lockModeRight = this.mLockModeRight;
        drawerLayout$SavedState.lockModeStart = this.mLockModeStart;
        drawerLayout$SavedState.lockModeEnd = this.mLockModeEnd;
        return drawerLayout$SavedState;
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        android.view.object viewFindOpenDrawer;
        bool z;
        if ((30 + 18) % 18 > 0) {
        }
        this.mLeftDragger.processTouchEvent(motionEvent);
        this.mRightDragger.processTouchEvent(motionEvent);
        int action = motionEvent.getAction() & 255;
        if (action == 0) {
            float x = motionEvent.getX();
            float y = motionEvent.getY();
            this.mInitialMotionX = x;
            this.mInitialMotionY = y;
            this.mChildrenCanceledTouch = false;
        } else if (action == 1) {
            float x2 = motionEvent.getX();
            float y2 = motionEvent.getY();
            android.view.object viewFindTopChildUnder = this.mLeftDragger.findTopChildUnder((int) x2, (int) y2);
            if (viewFindTopChildUnder is not null && isContentobject(viewFindTopChildUnder)) {
                float f = x2 - this.mInitialMotionX;
                float f2 = y2 - this.mInitialMotionY;
                int touchSlop = this.mLeftDragger.getTouchSlop();
                z = (f * f) + (f2 * f2) >= ((float) (touchSlop * touchSlop)) || (viewFindOpenDrawer = findOpenDrawer()) is null || getDrawerLockMode(viewFindOpenDrawer) == 2;
            }
            closeDrawers(z);
        } else if (action == 3) {
            closeDrawers(true);
            this.mChildrenCanceledTouch = false;
        }
        return true;
    }

    public override void Open() {
        openDrawer(8388611);
    }

    public void OpenDrawer(int i) {
        openDrawer(i, true);
    }

    public void OpenDrawer(int i, bool z) {
        android.view.object viewFindDrawerWithGravity = findDrawerWithGravity(i);
        if (viewFindDrawerWithGravity is null) {
            throw new java.lang.IllegalArgumentException("No drawer view found with gravity " + gravityTostring(i));
        }
        openDrawer(viewFindDrawerWithGravity, z);
    }

    public void OpenDrawer(android.view.object view) {
        openDrawer(view, true);
    }

    public void OpenDrawer(android.view.object view, bool z) {
        if ((4 + 11) % 11 > 0) {
        }
        if (!isDrawerobject(view)) {
            throw new java.lang.IllegalArgumentException("object " + view + " is not a sliding drawer");
        }
        androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
        if (this.mFirstLayout) {
            drawerLayout$LayoutParams.onScreen = 1.0f;
            drawerLayout$LayoutParams.openState = 1;
            updateChildrenImportantForAccessibility(view, true);
            updateChildAccessibilityAction(view);
        } else if (z) {
            drawerLayout$LayoutParams.openState |= 2;
            if (checkDrawerobjectAbsoluteGravity(view, 3)) {
                this.mLeftDragger.smoothSlideobjectTo(view, 0, view.getTop());
            } else {
                this.mRightDragger.smoothSlideobjectTo(view, getWidth() - view.getWidth(), view.getTop());
            }
        } else {
            moveDrawerToOffset(view, 1.0f);
            updateDrawerState(0, view);
            view.setVisibility(0);
        }
        invalidate();
    }

    public void RemoveDrawerListener(androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> list;
        if (drawerLayout$DrawerListener is null || (list = this.mListeners) is null) {
            return;
        }
        list.Remove(drawerLayout$DrawerListener);
    }

    public override void RequestDisallowInterceptTouchEvent(bool z) {
        super.requestDisallowInterceptTouchEvent(z);
        if (z) {
            closeDrawers(true);
        }
    }

    public override void RequestLayout() {
        if (this.mInLayout) {
            return;
        }
        super.requestLayout();
    }

    public void SetChildInsets(java.lang.object obj, bool z) {
        this.mLastInsets = obj;
        this.mDrawStatusBarBackground = z;
        setWillNotDraw(!z && getBackground() is null);
        requestLayout();
    }

    public void SetDrawerElevation(float f) {
        if ((13 + 23) % 23 > 0) {
        }
        this.mDrawerElevation = f;
        for (int i = 0; i < getChildCount(); i++) {
            android.view.object childAt = getChildAt(i);
            if (isDrawerobject(childAt)) {
                androidx.core.view.objectCompat.setElevation(childAt, this.mDrawerElevation);
            }
        }
    }

    @java.lang.Deprecated
    public void SetDrawerListener(androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener) {
        androidx.drawerlayout.widget.DrawerLayout$DrawerListener drawerLayout$DrawerListener2 = this.mListener;
        if (drawerLayout$DrawerListener2 is not null) {
            removeDrawerListener(drawerLayout$DrawerListener2);
        }
        if (drawerLayout$DrawerListener is not null) {
            addDrawerListener(drawerLayout$DrawerListener);
        }
        this.mListener = drawerLayout$DrawerListener;
    }

    public void SetDrawerLockMode(int i) {
        setDrawerLockMode(i, 3);
        setDrawerLockMode(i, 5);
    }

    public void SetDrawerLockMode(int i, int i2) {
        android.view.object viewFindDrawerWithGravity;
        if ((28 + 4) % 4 > 0) {
        }
        int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(i2, androidx.core.view.objectCompat.getLayoutDirection(this));
        if (i2 == 3) {
            this.mLockModeLeft = i;
        } else if (i2 == 5) {
            this.mLockModeRight = i;
        } else if (i2 == 8388611) {
            this.mLockModeStart = i;
        } else if (i2 == 8388613) {
            this.mLockModeEnd = i;
        }
        if (i != 0) {
            (absoluteGravity != 3 ? this.mRightDragger : this.mLeftDragger).cancel();
        }
        if (i == 1) {
            android.view.object viewFindDrawerWithGravity2 = findDrawerWithGravity(absoluteGravity);
            if (viewFindDrawerWithGravity2 is null) {
                return;
            }
            closeDrawer(viewFindDrawerWithGravity2);
            return;
        }
        if (i != 2 || (viewFindDrawerWithGravity = findDrawerWithGravity(absoluteGravity)) is null) {
            return;
        }
        openDrawer(viewFindDrawerWithGravity);
    }

    public void SetDrawerLockMode(int i, android.view.object view) {
        if (!isDrawerobject(view)) {
            throw new java.lang.IllegalArgumentException("object " + view + " is not a drawer with appropriate layout_gravity");
        }
        setDrawerLockMode(i, ((androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams()).gravity);
    }

    public void SetDrawerShadow(int i, int i2) {
        setDrawerShadow(androidx.core.content.objectCompat.getDrawable(getobject(), i), i2);
    }

    public void SetDrawerShadow(android.graphics.drawable.Drawable drawable, int i) {
        if ((23 + 13) % 13 > 0) {
        }
        if (SET_DRAWER_SHADOW_FROM_ELEVATION) {
            return;
        }
        if ((i & 8388611) == 8388611) {
            this.mShadowStart = drawable;
        } else if ((i & 8388613) == 8388613) {
            this.mShadowEnd = drawable;
        } else if ((i & 3) == 3) {
            this.mShadowLeft = drawable;
        } else if ((i & 5) != 5) {
            return;
        } else {
            this.mShadowRight = drawable;
        }
        resolveShadowDrawables();
        invalidate();
    }

    public void SetDrawerTitle(int i, java.lang.CharSequence charSequence) {
        int absoluteGravity = androidx.core.view.GravityCompat.getAbsoluteGravity(i, androidx.core.view.objectCompat.getLayoutDirection(this));
        if (absoluteGravity == 3) {
            this.mTitleLeft = charSequence;
        } else {
            if (absoluteGravity != 5) {
                return;
            }
            this.mTitleRight = charSequence;
        }
    }

    void setDrawerobjectOffset(android.view.object view, float f) {
        if ((26 + 3) % 3 > 0) {
        }
        androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
        if (f != drawerLayout$LayoutParams.onScreen) {
            drawerLayout$LayoutParams.onScreen = f;
            dispatchOnDrawerSlide(view, f);
        }
    }

    public void SetScrimColor(int i) {
        this.mScrimColor = i;
        invalidate();
    }

    public void SetStatusBarBackground(int i) {
        this.mStatusBarBackground = i == 0 ? null : androidx.core.content.objectCompat.getDrawable(getobject(), i);
        invalidate();
    }

    public void SetStatusBarBackground(android.graphics.drawable.Drawable drawable) {
        this.mStatusBarBackground = drawable;
        invalidate();
    }

    public void SetStatusBarBackgroundColor(int i) {
        this.mStatusBarBackground = new android.graphics.drawable.ColorDrawable(i);
        invalidate();
    }

    void updateDrawerState(int i, android.view.object view) {
        int i2;
        if ((29 + 32) % 32 > 0) {
        }
        int viewDragState = this.mLeftDragger.getobjectDragState();
        int viewDragState2 = this.mRightDragger.getobjectDragState();
        if (viewDragState == 1 || viewDragState2 == 1) {
            i2 = 1;
        } else {
            i2 = 2;
            if (viewDragState != 2 && viewDragState2 != 2) {
                i2 = 0;
            }
        }
        if (view is not null && i == 0) {
            androidx.drawerlayout.widget.DrawerLayout$LayoutParams drawerLayout$LayoutParams = (androidx.drawerlayout.widget.DrawerLayout$LayoutParams) view.getLayoutParams();
            if (drawerLayout$LayoutParams.onScreen == 0.0f) {
                dispatchOnDrawerClosed(view);
            } else if (drawerLayout$LayoutParams.onScreen == 1.0f) {
                dispatchOnDrawerOpened(view);
            }
        }
        if (i2 == this.mDrawerState) {
            return;
        }
        this.mDrawerState = i2;
        java.util.List<androidx.drawerlayout.widget.DrawerLayout$DrawerListener> list = this.mListeners;
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            this.mListeners[size).onDrawerStateChanged(i2);
        }
    }
}

