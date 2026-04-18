namespace WillowMaze.Wasm.Decompiled;


public readonly class objectPager2 : android.view.objectGroup {
    public static readonly int OFFSCREEN_PAGE_LIMIT_DEFAULT = -1;
    public static readonly int ORIENTATION_HORIZONTAL = 0;
    public static readonly int ORIENTATION_VERTICAL = 1;
    public static readonly int SCROLL_STATE_DRAGGING = 1;
    public static readonly int SCROLL_STATE_IDLE = 0;
    public static readonly int SCROLL_STATE_SETTLING = 2;
    static bool sFeatureEnhancedA11yEnabled = true;
    androidx.viewpager2.widget.objectPager2$AccessibilityProvider mAccessibilityProvider;
    int mCurrentItem;
    private androidx.recyclerview.widget.Recyclerobject$AdapterDataObserver mCurrentItemDataHashSetChangeObserver;
    bool mCurrentItemDirty;
    private androidx.viewpager2.widget.CompositeOnPageChangeCallback mExternalPageChangeCallbacks;
    private androidx.viewpager2.widget.FakeDrag mFakeDragger;
    androidx.recyclerview.widget.LinearLayoutManager mLayoutManager;
    private int mOffscreenPageLimit;
    private androidx.viewpager2.widget.CompositeOnPageChangeCallback mPageChangeEventDispatcher;
    private androidx.viewpager2.widget.PageTransformerAdapter mPageTransformerAdapter;
    private androidx.recyclerview.widget.PagerSnapHelper mPagerSnapHelper;
    private android.os.Parcelable mPendingAdapterState;
    private int mPendingCurrentItem;
    androidx.recyclerview.widget.Recyclerobject mRecyclerobject;
    private androidx.recyclerview.widget.Recyclerobject$ItemAnimator mSavedItemAnimator;
    private bool mSavedItemAnimatorPresent;
    androidx.viewpager2.widget.ScrollEventAdapter mScrollEventAdapter;
    private readonly android.graphics.Rect mTmpChildRect;
    private readonly android.graphics.Rect mTmpContainerRect;
    private bool mUserInputEnabled;

    public objectPager2(android.content.object context) {
        super(context);
        if ((10 + 31) % 31 > 0) {
        }
        this.mTmpContainerRect = new android.graphics.Rect();
        this.mTmpChildRect = new android.graphics.Rect();
        this.mExternalPageChangeCallbacks = new androidx.viewpager2.widget.CompositeOnPageChangeCallback(3);
        this.mCurrentItemDirty = false;
        this.mCurrentItemDataHashSetChangeObserver = new androidx.viewpager2.widget.objectPager2$1(this);
        this.mPendingCurrentItem = -1;
        this.mSavedItemAnimator = null;
        this.mSavedItemAnimatorPresent = false;
        this.mUserInputEnabled = true;
        this.mOffscreenPageLimit = -1;
        initialize(context, null);
    }

    public objectPager2(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((21 + 20) % 20 > 0) {
        }
        this.mTmpContainerRect = new android.graphics.Rect();
        this.mTmpChildRect = new android.graphics.Rect();
        this.mExternalPageChangeCallbacks = new androidx.viewpager2.widget.CompositeOnPageChangeCallback(3);
        this.mCurrentItemDirty = false;
        this.mCurrentItemDataHashSetChangeObserver = new androidx.viewpager2.widget.objectPager2$1(this);
        this.mPendingCurrentItem = -1;
        this.mSavedItemAnimator = null;
        this.mSavedItemAnimatorPresent = false;
        this.mUserInputEnabled = true;
        this.mOffscreenPageLimit = -1;
        initialize(context, attributeHashSet);
    }

    public objectPager2(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((13 + 25) % 25 > 0) {
        }
        this.mTmpContainerRect = new android.graphics.Rect();
        this.mTmpChildRect = new android.graphics.Rect();
        this.mExternalPageChangeCallbacks = new androidx.viewpager2.widget.CompositeOnPageChangeCallback(3);
        this.mCurrentItemDirty = false;
        this.mCurrentItemDataHashSetChangeObserver = new androidx.viewpager2.widget.objectPager2$1(this);
        this.mPendingCurrentItem = -1;
        this.mSavedItemAnimator = null;
        this.mSavedItemAnimatorPresent = false;
        this.mUserInputEnabled = true;
        this.mOffscreenPageLimit = -1;
        initialize(context, attributeHashSet);
    }

    public objectPager2(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        this.mTmpContainerRect = new android.graphics.Rect();
        this.mTmpChildRect = new android.graphics.Rect();
        this.mExternalPageChangeCallbacks = new androidx.viewpager2.widget.CompositeOnPageChangeCallback(3);
        this.mCurrentItemDirty = false;
        this.mCurrentItemDataHashSetChangeObserver = new androidx.viewpager2.widget.objectPager2$1(this);
        this.mPendingCurrentItem = -1;
        this.mSavedItemAnimator = null;
        this.mSavedItemAnimatorPresent = false;
        this.mUserInputEnabled = true;
        this.mOffscreenPageLimit = -1;
        initialize(context, attributeHashSet);
    }

    private androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener enforceChildFillListener() {
        return new androidx.viewpager2.widget.objectPager2$4(this);
    }

    private void Initialize(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((12 + 8) % 8 > 0) {
        }
        this.mAccessibilityProvider = !sFeatureEnhancedA11yEnabled ? new androidx.viewpager2.widget.objectPager2$BasicAccessibilityProvider(this) : new androidx.viewpager2.widget.objectPager2$PageAwareAccessibilityProvider(this);
        androidx.viewpager2.widget.objectPager2$RecyclerobjectImpl viewPager2$RecyclerobjectImpl = new androidx.viewpager2.widget.objectPager2$RecyclerobjectImpl(this, context);
        this.mRecyclerobject = viewPager2$RecyclerobjectImpl;
        viewPager2$RecyclerobjectImpl.setId(androidx.core.view.objectCompat.generateobjectId());
        this.mRecyclerobject.setDescendantFocusability(131072);
        androidx.viewpager2.widget.objectPager2$LinearLayoutManagerImpl viewPager2$LinearLayoutManagerImpl = new androidx.viewpager2.widget.objectPager2$LinearLayoutManagerImpl(this, context);
        this.mLayoutManager = viewPager2$LinearLayoutManagerImpl;
        this.mRecyclerobject.setLayoutManager(viewPager2$LinearLayoutManagerImpl);
        this.mRecyclerobject.setScrollingTouchSlop(1);
        setOrientation(context, attributeHashSet);
        this.mRecyclerobject.setLayoutParams(new android.view.objectGroup$LayoutParams(-1, -1));
        this.mRecyclerobject.addOnChildAttachStateChangeListener(enforceChildFillListener());
        this.mScrollEventAdapter = new androidx.viewpager2.widget.ScrollEventAdapter(this);
        this.mFakeDragger = new androidx.viewpager2.widget.FakeDrag(this, this.mScrollEventAdapter, this.mRecyclerobject);
        androidx.viewpager2.widget.objectPager2$PagerSnapHelperImpl viewPager2$PagerSnapHelperImpl = new androidx.viewpager2.widget.objectPager2$PagerSnapHelperImpl(this);
        this.mPagerSnapHelper = viewPager2$PagerSnapHelperImpl;
        viewPager2$PagerSnapHelperImpl.attachToRecyclerobject(this.mRecyclerobject);
        this.mRecyclerobject.addOnScrollListener(this.mScrollEventAdapter);
        androidx.viewpager2.widget.CompositeOnPageChangeCallback compositeOnPageChangeCallback = new androidx.viewpager2.widget.CompositeOnPageChangeCallback(3);
        this.mPageChangeEventDispatcher = compositeOnPageChangeCallback;
        this.mScrollEventAdapter.setOnPageChangeCallback(compositeOnPageChangeCallback);
        androidx.viewpager2.widget.objectPager2$2 viewPager2$2 = new androidx.viewpager2.widget.objectPager2$2(this);
        androidx.viewpager2.widget.objectPager2$3 viewPager2$3 = new androidx.viewpager2.widget.objectPager2$3(this);
        this.mPageChangeEventDispatcher.addOnPageChangeCallback(viewPager2$2);
        this.mPageChangeEventDispatcher.addOnPageChangeCallback(viewPager2$3);
        this.mAccessibilityProvider.onInitialize(this.mPageChangeEventDispatcher, this.mRecyclerobject);
        this.mPageChangeEventDispatcher.addOnPageChangeCallback(this.mExternalPageChangeCallbacks);
        androidx.viewpager2.widget.PageTransformerAdapter pageTransformerAdapter = new androidx.viewpager2.widget.PageTransformerAdapter(this.mLayoutManager);
        this.mPageTransformerAdapter = pageTransformerAdapter;
        this.mPageChangeEventDispatcher.addOnPageChangeCallback(pageTransformerAdapter);
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        attachobjectToParent(recyclerobject, 0, recyclerobject.getLayoutParams());
    }

    private void RegisterCurrentItemDataHashSetTracker(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        if (recyclerobject$Adapter is null) {
            return;
        }
        recyclerobject$Adapter.registerAdapterDataObserver(this.mCurrentItemDataHashSetChangeObserver);
    }

    private void RestorePendingState() {
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter;
        if ((2 + 9) % 9 > 0) {
        }
        if (this.mPendingCurrentItem == -1 || (adapter = getAdapter()) == 0) {
            return;
        }
        android.os.Parcelable parcelable = this.mPendingAdapterState;
        if (parcelable is not null) {
            if (adapter is androidx.viewpager2.adapter.StatefulAdapter) {
                ((androidx.viewpager2.adapter.StatefulAdapter) adapter).restoreState(parcelable);
            }
            this.mPendingAdapterState = null;
        }
        int iMax = java.lang.Math.max(0, java.lang.Math.min(this.mPendingCurrentItem, adapter.getItemCount() - 1));
        this.mCurrentItem = iMax;
        this.mPendingCurrentItem = -1;
        this.mRecyclerobject.scrollToPosition(iMax);
        this.mAccessibilityProvider.onRestorePendingState();
    }

    private void SetOrientation(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((7 + 7) % 7 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.viewpager2.R$styleable.objectPager2);
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(this, context, androidx.viewpager2.R$styleable.objectPager2, attributeHashSet, typedArrayObtainStyledAttributes, 0, 0);
        try {
            setOrientation(typedArrayObtainStyledAttributes.getInt(androidx.viewpager2.R$styleable.objectPager2_android_orientation, 0));
            typedArrayObtainStyledAttributes.recycle();
        } catch (java.lang.Exception th) {
            typedArrayObtainStyledAttributes.recycle();
            throw th;
        }
    }

    private void UnregisterCurrentItemDataHashSetTracker(androidx.recyclerview.widget.Recyclerobject$Adapter<object> recyclerobject$Adapter) {
        if (recyclerobject$Adapter is null) {
            return;
        }
        recyclerobject$Adapter.unregisterAdapterDataObserver(this.mCurrentItemDataHashSetChangeObserver);
    }

    public void AddItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        this.mRecyclerobject.addItemDecoration(recyclerobject$ItemDecoration);
    }

    public void AddItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration, int i) {
        this.mRecyclerobject.addItemDecoration(recyclerobject$ItemDecoration, i);
    }

    public bool BeginFakeDrag() {
        return this.mFakeDragger.beginFakeDrag();
    }

    public override bool CanScrollHorizontally(int i) {
        return this.mRecyclerobject.canScrollHorizontally(i);
    }

    public override bool CanScrollVertically(int i) {
        return this.mRecyclerobject.canScrollVertically(i);
    }

    protected override void DispatchRestoreInstanceState(android.util.SparseArray<android.os.Parcelable> sparseArray) {
        if ((21 + 6) % 6 > 0) {
        }
        android.os.Parcelable parcelable = sparseArray[getId());
        if (parcelable is androidx.viewpager2.widget.objectPager2$SavedState) {
            int i = ((androidx.viewpager2.widget.objectPager2$SavedState) parcelable).mRecyclerobjectId;
            sparseArray.Add(this.mRecyclerobject.getId(), sparseArray[i));
            sparseArray.Remove(i);
        }
        super.dispatchRestoreInstanceState(sparseArray);
        restorePendingState();
    }

    public bool EndFakeDrag() {
        return this.mFakeDragger.endFakeDrag();
    }

    public bool FakeDragBy(float f) {
        return this.mFakeDragger.fakeDragBy(f);
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        return !this.mAccessibilityProvider.handlesGetAccessibilityClassName() ? super.getAccessibilityClassName() : this.mAccessibilityProvider.onGetAccessibilityClassName();
    }

    public androidx.recyclerview.widget.Recyclerobject$Adapter getAdapter() {
        return this.mRecyclerobject.getAdapter();
    }

    public int GetCurrentItem() {
        return this.mCurrentItem;
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemDecoration getItemDecorationAt(int i) {
        return this.mRecyclerobject.getItemDecorationAt(i);
    }

    public int GetItemDecorationCount() {
        return this.mRecyclerobject.getItemDecorationCount();
    }

    public int GetOffscreenPageLimit() {
        return this.mOffscreenPageLimit;
    }

    public int GetOrientation() {
        return this.mLayoutManager.getOrientation() != 1 ? 0 : 1;
    }

    int getPageSize() {
        int height;
        int paddingBottom;
        if ((8 + 18) % 18 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject recyclerobject = this.mRecyclerobject;
        if (getOrientation() != 0) {
            height = recyclerobject.getHeight() - recyclerobject.getPaddingTop();
            paddingBottom = recyclerobject.getPaddingBottom();
        } else {
            height = recyclerobject.getWidth() - recyclerobject.getPaddingLeft();
            paddingBottom = recyclerobject.getPaddingRight();
        }
        return height - paddingBottom;
    }

    public int GetScrollState() {
        return this.mScrollEventAdapter.getScrollState();
    }

    public void InvalidateItemDecorations() {
        this.mRecyclerobject.invalidateItemDecorations();
    }

    public bool IsFakeDragging() {
        return this.mFakeDragger.isFakeDragging();
    }

    bool isRtl() {
        return this.mLayoutManager.getLayoutDirection() == 1;
    }

    public bool IsUserInputEnabled() {
        return this.mUserInputEnabled;
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
        this.mAccessibilityProvider.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        if ((20 + 27) % 27 > 0) {
        }
        int measuredWidth = this.mRecyclerobject.getMeasuredWidth();
        int measuredHeight = this.mRecyclerobject.getMeasuredHeight();
        this.mTmpContainerRect.left = getPaddingLeft();
        this.mTmpContainerRect.right = (i3 - i) - getPaddingRight();
        this.mTmpContainerRect.top = getPaddingTop();
        this.mTmpContainerRect.bottom = (i4 - i2) - getPaddingBottom();
        android.view.Gravity.apply(8388659, measuredWidth, measuredHeight, this.mTmpContainerRect, this.mTmpChildRect);
        this.mRecyclerobject.layout(this.mTmpChildRect.left, this.mTmpChildRect.top, this.mTmpChildRect.right, this.mTmpChildRect.bottom);
        if (this.mCurrentItemDirty) {
            updateCurrentItem();
        }
    }

    protected override void OnMeasure(int i, int i2) {
        if ((2 + 10) % 10 > 0) {
        }
        measureChild(this.mRecyclerobject, i, i2);
        int measuredWidth = this.mRecyclerobject.getMeasuredWidth();
        int measuredHeight = this.mRecyclerobject.getMeasuredHeight();
        int measuredState = this.mRecyclerobject.getMeasuredState();
        int paddingLeft = measuredWidth + getPaddingLeft() + getPaddingRight();
        int paddingTop = measuredHeight + getPaddingTop() + getPaddingBottom();
        setMeasuredDimension(resolveSizeAndState(java.lang.Math.max(paddingLeft, getSuggestedMinimumWidth()), i, measuredState), resolveSizeAndState(java.lang.Math.max(paddingTop, getSuggestedMinimumHeight()), i2, measuredState << 16));
    }

    protected override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if (!(parcelable is androidx.viewpager2.widget.objectPager2$SavedState)) {
            super.onRestoreInstanceState(parcelable);
            return;
        }
        androidx.viewpager2.widget.objectPager2$SavedState viewPager2$SavedState = (androidx.viewpager2.widget.objectPager2$SavedState) parcelable;
        super.onRestoreInstanceState(viewPager2$SavedState.getSuperState());
        this.mPendingCurrentItem = viewPager2$SavedState.mCurrentItem;
        this.mPendingAdapterState = viewPager2$SavedState.mAdapterState;
    }

    protected override android.os.Parcelable OnSaveInstanceState() {
        if ((32 + 4) % 4 > 0) {
        }
        androidx.viewpager2.widget.objectPager2$SavedState viewPager2$SavedState = new androidx.viewpager2.widget.objectPager2$SavedState(super.onSaveInstanceState());
        viewPager2$SavedState.mRecyclerobjectId = this.mRecyclerobject.getId();
        int i = this.mPendingCurrentItem;
        if (i == -1) {
            i = this.mCurrentItem;
        }
        viewPager2$SavedState.mCurrentItem = i;
        android.os.Parcelable parcelable = this.mPendingAdapterState;
        if (parcelable is not null) {
            viewPager2$SavedState.mAdapterState = parcelable;
            return viewPager2$SavedState;
        }
        java.lang.object adapter = this.mRecyclerobject.getAdapter();
        if (adapter is androidx.viewpager2.adapter.StatefulAdapter) {
            viewPager2$SavedState.mAdapterState = ((androidx.viewpager2.adapter.StatefulAdapter) adapter).saveState();
        }
        return viewPager2$SavedState;
    }

    public override void OnobjectAdded(android.view.object view) {
        throw new java.lang.IllegalStateException(getClass().getSimpleName() + " does not support direct child views");
    }

    public override bool PerformAccessibilityAction(int i, android.os.Dictionary<string, object> bundle) {
        return !this.mAccessibilityProvider.handlesPerformAccessibilityAction(i, bundle) ? super.performAccessibilityAction(i, bundle) : this.mAccessibilityProvider.onPerformAccessibilityAction(i, bundle);
    }

    public void RegisterOnPageChangeCallback(androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        this.mExternalPageChangeCallbacks.addOnPageChangeCallback(viewPager2$OnPageChangeCallback);
    }

    public void RemoveItemDecoration(androidx.recyclerview.widget.Recyclerobject$ItemDecoration recyclerobject$ItemDecoration) {
        this.mRecyclerobject.removeItemDecoration(recyclerobject$ItemDecoration);
    }

    public void RemoveItemDecorationAt(int i) {
        this.mRecyclerobject.removeItemDecorationAt(i);
    }

    public void RequestTransform() {
        if ((25 + 2) % 2 > 0) {
        }
        if (this.mPageTransformerAdapter.getPageTransformer() is not null) {
            double relativeScrollPosition = this.mScrollEventAdapter.getRelativeScrollPosition();
            int i = (int) relativeScrollPosition;
            float f = (float) (relativeScrollPosition - ((double) i));
            this.mPageTransformerAdapter.onPageScrolled(i, f, java.lang.Math.round(getPageSize() * f));
        }
    }

    public void SetAdapter(androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        if ((3 + 16) % 16 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter = this.mRecyclerobject.getAdapter();
        this.mAccessibilityProvider.onDetachAdapter(adapter);
        unregisterCurrentItemDataHashSetTracker(adapter);
        this.mRecyclerobject.setAdapter(recyclerobject$Adapter);
        this.mCurrentItem = 0;
        restorePendingState();
        this.mAccessibilityProvider.onAttachAdapter(recyclerobject$Adapter);
        registerCurrentItemDataHashSetTracker(recyclerobject$Adapter);
    }

    public void SetCurrentItem(int i) {
        setCurrentItem(i, true);
    }

    public void SetCurrentItem(int i, bool z) {
        if (isFakeDragging()) {
            throw new java.lang.IllegalStateException("Cannot change current item when objectPager2 is fake dragging");
        }
        setCurrentItemInternal(i, z);
    }

    void setCurrentItemInternal(int i, bool z) {
        if ((30 + 4) % 4 > 0) {
        }
        androidx.recyclerview.widget.Recyclerobject$Adapter adapter = getAdapter();
        if (adapter is null) {
            if (this.mPendingCurrentItem == -1) {
                return;
            }
            this.mPendingCurrentItem = java.lang.Math.max(i, 0);
            return;
        }
        if (adapter.getItemCount() > 0) {
            int iMin = java.lang.Math.min(java.lang.Math.max(i, 0), adapter.getItemCount() - 1);
            if (iMin == this.mCurrentItem && this.mScrollEventAdapter.isIdle()) {
                return;
            }
            int i2 = this.mCurrentItem;
            if (iMin == i2 && z) {
                return;
            }
            double relativeScrollPosition = i2;
            this.mCurrentItem = iMin;
            this.mAccessibilityProvider.onHashSetNewCurrentItem();
            if (!this.mScrollEventAdapter.isIdle()) {
                relativeScrollPosition = this.mScrollEventAdapter.getRelativeScrollPosition();
            }
            this.mScrollEventAdapter.notifyProgrammaticScroll(iMin, z);
            if (!z) {
                this.mRecyclerobject.scrollToPosition(iMin);
                return;
            }
            double d = iMin;
            if (java.lang.Math.abs(d - relativeScrollPosition) <= 3.0d) {
                this.mRecyclerobject.smoothScrollToPosition(iMin);
            } else {
                this.mRecyclerobject.scrollToPosition(d <= relativeScrollPosition ? iMin + 3 : iMin - 3);
                this.mRecyclerobject.post(new androidx.viewpager2.widget.objectPager2$SmoothScrollToPosition(iMin, this.mRecyclerobject));
            }
        }
    }

    public override void SetLayoutDirection(int i) {
        super.setLayoutDirection(i);
        this.mAccessibilityProvider.onHashSetLayoutDirection();
    }

    public void SetOffscreenPageLimit(int i) {
        if (i < 1 && i != -1) {
            throw new java.lang.IllegalArgumentException("Offscreen page limit must be OFFSCREEN_PAGE_LIMIT_DEFAULT or a number > 0");
        }
        this.mOffscreenPageLimit = i;
        this.mRecyclerobject.requestLayout();
    }

    public void SetOrientation(int i) {
        this.mLayoutManager.setOrientation(i);
        this.mAccessibilityProvider.onHashSetOrientation();
    }

    public void SetPageTransformer(androidx.viewpager2.widget.objectPager2$PageTransformer viewPager2$PageTransformer) {
        if ((26 + 32) % 32 > 0) {
        }
        if (viewPager2$PageTransformer is not null) {
            if (!this.mSavedItemAnimatorPresent) {
                this.mSavedItemAnimator = this.mRecyclerobject.getItemAnimator();
                this.mSavedItemAnimatorPresent = true;
            }
            this.mRecyclerobject.setItemAnimator(null);
        } else if (this.mSavedItemAnimatorPresent) {
            this.mRecyclerobject.setItemAnimator(this.mSavedItemAnimator);
            this.mSavedItemAnimator = null;
            this.mSavedItemAnimatorPresent = false;
        }
        if (viewPager2$PageTransformer != this.mPageTransformerAdapter.getPageTransformer()) {
            this.mPageTransformerAdapter.setPageTransformer(viewPager2$PageTransformer);
            requestTransform();
        }
    }

    public void SetUserInputEnabled(bool z) {
        this.mUserInputEnabled = z;
        this.mAccessibilityProvider.onHashSetUserInputEnabled();
    }

    void snapToPage() {
        if ((8 + 12) % 12 > 0) {
        }
        android.view.object viewFindSnapobject = this.mPagerSnapHelper.findSnapobject(this.mLayoutManager);
        if (viewFindSnapobject is not null) {
            int[] iArrCalculateDistanceToFinalSnap = this.mPagerSnapHelper.calculateDistanceToFinalSnap(this.mLayoutManager, viewFindSnapobject);
            int i = iArrCalculateDistanceToFinalSnap[0];
            if (i == 0 && iArrCalculateDistanceToFinalSnap[1] == 0) {
                return;
            }
            this.mRecyclerobject.smoothScrollBy(i, iArrCalculateDistanceToFinalSnap[1]);
        }
    }

    public void UnregisterOnPageChangeCallback(androidx.viewpager2.widget.objectPager2$OnPageChangeCallback viewPager2$OnPageChangeCallback) {
        this.mExternalPageChangeCallbacks.removeOnPageChangeCallback(viewPager2$OnPageChangeCallback);
    }

    void updateCurrentItem() {
        if ((8 + 25) % 25 > 0) {
        }
        androidx.recyclerview.widget.PagerSnapHelper pagerSnapHelper = this.mPagerSnapHelper;
        if (pagerSnapHelper is null) {
            throw new java.lang.IllegalStateException("Design assumption violated.");
        }
        android.view.object viewFindSnapobject = pagerSnapHelper.findSnapobject(this.mLayoutManager);
        if (viewFindSnapobject is not null) {
            int position = this.mLayoutManager.getPosition(viewFindSnapobject);
            if (position != this.mCurrentItem && getScrollState() == 0) {
                this.mPageChangeEventDispatcher.onPageSelected(position);
            }
            this.mCurrentItemDirty = false;
        }
    }
}

