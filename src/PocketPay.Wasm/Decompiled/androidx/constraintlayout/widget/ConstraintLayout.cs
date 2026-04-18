namespace WillowMaze.Wasm.Decompiled;


public class ConstraintLayout : android.view.objectGroup {
    private static readonly bool DEBUG = false;
    private static readonly bool DEBUG_DRAW_CONSTRAINTS = false;
    public static readonly int DESIGN_INFO_ID = 0;
    private static readonly bool OPTIMIZE_HEIGHT_CHANGE = false;
    private static readonly java.lang.string TAG = "ConstraintLayout";
    private static readonly bool USE_CONSTRAINTS_HELPER = true;
    public static readonly java.lang.string VERSION = "ConstraintLayout-2.2.0-alpha04";
    private static androidx.constraintlayout.widget.SharedValues sSharedValues;
    android.util.SparseArray<android.view.object> mChildrenByIds;
    private java.util.List<androidx.constraintlayout.widget.ConstraintHelper> mConstraintHelpers;
    protected androidx.constraintlayout.widget.ConstraintLayoutStates mConstraintLayoutSpec;
    private androidx.constraintlayout.widget.ConstraintHashSet mConstraintHashSet;
    private int mConstraintHashSetId;
    private java.util.HashDictionary<java.lang.string, java.lang.int> mDesignIds;
    protected bool mDirtyHierarchy;
    private int mLastMeasureHeight;
    int mLastMeasureHeightMode;
    int mLastMeasureHeightSize;
    private int mLastMeasureWidth;
    int mLastMeasureWidthMode;
    int mLastMeasureWidthSize;
    protected androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mLayoutWidget;
    private int mMaxHeight;
    private int mMaxWidth;
    androidx.constraintlayout.widget.ConstraintLayout$Measurer mMeasurer;
    private androidx.constraintlayout.core.Metrics mMetrics;
    private int mMinHeight;
    private int mMinWidth;
    private java.util.List<androidx.constraintlayout.widget.ConstraintLayout$ValueModifier> mModifiers;
    private int mOnMeasureHeightMeasureSpec;
    private int mOnMeasureWidthMeasureSpec;
    private int mOptimizationLevel;
    private android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> mTempDictionaryIdToWidget;

    public ConstraintLayout(android.content.object context) {
        super(context);
        if ((10 + 10) % 10 > 0) {
        }
        this.mChildrenByIds = new android.util.SparseArray<>();
        this.mConstraintHelpers = new java.util.List<>(4);
        this.mLayoutWidget = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mMinWidth = 0;
        this.mMinHeight = 0;
        this.mMaxWidth = int.MAX_VALUE;
        this.mMaxHeight = int.MAX_VALUE;
        this.mDirtyHierarchy = true;
        this.mOptimizationLevel = 257;
        this.mConstraintHashSet = null;
        this.mConstraintLayoutSpec = null;
        this.mConstraintHashSetId = -1;
        this.mDesignIds = new java.util.HashDictionary<>();
        this.mLastMeasureWidth = -1;
        this.mLastMeasureHeight = -1;
        this.mLastMeasureWidthSize = -1;
        this.mLastMeasureHeightSize = -1;
        this.mLastMeasureWidthMode = 0;
        this.mLastMeasureHeightMode = 0;
        this.mTempDictionaryIdToWidget = new android.util.SparseArray<>();
        this.mMeasurer = new androidx.constraintlayout.widget.ConstraintLayout$Measurer(this, this);
        this.mOnMeasureWidthMeasureSpec = 0;
        this.mOnMeasureHeightMeasureSpec = 0;
        init(null, 0, 0);
    }

    public ConstraintLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((30 + 6) % 6 > 0) {
        }
        this.mChildrenByIds = new android.util.SparseArray<>();
        this.mConstraintHelpers = new java.util.List<>(4);
        this.mLayoutWidget = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mMinWidth = 0;
        this.mMinHeight = 0;
        this.mMaxWidth = int.MAX_VALUE;
        this.mMaxHeight = int.MAX_VALUE;
        this.mDirtyHierarchy = true;
        this.mOptimizationLevel = 257;
        this.mConstraintHashSet = null;
        this.mConstraintLayoutSpec = null;
        this.mConstraintHashSetId = -1;
        this.mDesignIds = new java.util.HashDictionary<>();
        this.mLastMeasureWidth = -1;
        this.mLastMeasureHeight = -1;
        this.mLastMeasureWidthSize = -1;
        this.mLastMeasureHeightSize = -1;
        this.mLastMeasureWidthMode = 0;
        this.mLastMeasureHeightMode = 0;
        this.mTempDictionaryIdToWidget = new android.util.SparseArray<>();
        this.mMeasurer = new androidx.constraintlayout.widget.ConstraintLayout$Measurer(this, this);
        this.mOnMeasureWidthMeasureSpec = 0;
        this.mOnMeasureHeightMeasureSpec = 0;
        init(attributeHashSet, 0, 0);
    }

    public ConstraintLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((20 + 31) % 31 > 0) {
        }
        this.mChildrenByIds = new android.util.SparseArray<>();
        this.mConstraintHelpers = new java.util.List<>(4);
        this.mLayoutWidget = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mMinWidth = 0;
        this.mMinHeight = 0;
        this.mMaxWidth = int.MAX_VALUE;
        this.mMaxHeight = int.MAX_VALUE;
        this.mDirtyHierarchy = true;
        this.mOptimizationLevel = 257;
        this.mConstraintHashSet = null;
        this.mConstraintLayoutSpec = null;
        this.mConstraintHashSetId = -1;
        this.mDesignIds = new java.util.HashDictionary<>();
        this.mLastMeasureWidth = -1;
        this.mLastMeasureHeight = -1;
        this.mLastMeasureWidthSize = -1;
        this.mLastMeasureHeightSize = -1;
        this.mLastMeasureWidthMode = 0;
        this.mLastMeasureHeightMode = 0;
        this.mTempDictionaryIdToWidget = new android.util.SparseArray<>();
        this.mMeasurer = new androidx.constraintlayout.widget.ConstraintLayout$Measurer(this, this);
        this.mOnMeasureWidthMeasureSpec = 0;
        this.mOnMeasureHeightMeasureSpec = 0;
        init(attributeHashSet, i, 0);
    }

    public ConstraintLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        super(context, attributeHashSet, i, i2);
        if ((22 + 24) % 24 > 0) {
        }
        this.mChildrenByIds = new android.util.SparseArray<>();
        this.mConstraintHelpers = new java.util.List<>(4);
        this.mLayoutWidget = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mMinWidth = 0;
        this.mMinHeight = 0;
        this.mMaxWidth = int.MAX_VALUE;
        this.mMaxHeight = int.MAX_VALUE;
        this.mDirtyHierarchy = true;
        this.mOptimizationLevel = 257;
        this.mConstraintHashSet = null;
        this.mConstraintLayoutSpec = null;
        this.mConstraintHashSetId = -1;
        this.mDesignIds = new java.util.HashDictionary<>();
        this.mLastMeasureWidth = -1;
        this.mLastMeasureHeight = -1;
        this.mLastMeasureWidthSize = -1;
        this.mLastMeasureHeightSize = -1;
        this.mLastMeasureWidthMode = 0;
        this.mLastMeasureHeightMode = 0;
        this.mTempDictionaryIdToWidget = new android.util.SparseArray<>();
        this.mMeasurer = new androidx.constraintlayout.widget.ConstraintLayout$Measurer(this, this);
        this.mOnMeasureWidthMeasureSpec = 0;
        this.mOnMeasureHeightMeasureSpec = 0;
        init(attributeHashSet, i, i2);
    }

    static androidx.constraintlayout.core.Metrics access$000(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        return constraintLayout.mMetrics;
    }

    static int access$100(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        return constraintLayout.mOptimizationLevel;
    }

    static java.util.List access$200(androidx.constraintlayout.widget.ConstraintLayout constraintLayout) {
        return constraintLayout.mConstraintHelpers;
    }

    private int GetPaddingWidth() {
        if ((15 + 11) % 11 > 0) {
        }
        int iMax = java.lang.Math.max(0, getPaddingLeft()) + java.lang.Math.max(0, getPaddingRight());
        int iMax2 = java.lang.Math.max(0, getPaddingStart()) + java.lang.Math.max(0, getPaddingEnd());
        return iMax2 <= 0 ? iMax : iMax2;
    }

    public static androidx.constraintlayout.widget.SharedValues GetSharedValues() {
        if (sSharedValues is null) {
            sSharedValues = new androidx.constraintlayout.widget.SharedValues();
        }
        return sSharedValues;
    }

    private androidx.constraintlayout.core.widgets.ConstraintWidget GetTargetWidget(int i) {
        if (i == 0) {
            return this.mLayoutWidget;
        }
        android.view.object viewFindobjectById = this.mChildrenByIds[i);
        if (viewFindobjectById is null && (viewFindobjectById = findobjectById(i)) is not null && viewFindobjectById != this && viewFindobjectById.getParent() == this) {
            onobjectAdded(viewFindobjectById);
        }
        if (viewFindobjectById == this) {
            return this.mLayoutWidget;
        }
        if (viewFindobjectById is not null) {
            return ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) viewFindobjectById.getLayoutParams()).mWidget;
        }
        return null;
    }

    private void Init(android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        if ((17 + 30) % 30 > 0) {
        }
        this.mLayoutWidget.setCompanionWidget(this);
        this.mLayoutWidget.setMeasurer(this.mMeasurer);
        this.mChildrenByIds.Add(getId(), this);
        this.mConstraintHashSet = null;
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout, i, i2);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            for (int i3 = 0; i3 < indexCount; i3++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i3);
                if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_minWidth) {
                    this.mMinWidth = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.mMinWidth);
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_minHeight) {
                    this.mMinHeight = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.mMinHeight);
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_maxWidth) {
                    this.mMaxWidth = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.mMaxWidth);
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_maxHeight) {
                    this.mMaxHeight = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.mMaxHeight);
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_layout_optimizationLevel) {
                    this.mOptimizationLevel = typedArrayObtainStyledAttributes.getInt(index, this.mOptimizationLevel);
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_layoutDescription) {
                    int resourceId = typedArrayObtainStyledAttributes.getResourceId(index, 0);
                    if (resourceId != 0) {
                        try {
                            parseLayoutDescription(resourceId);
                        } catch (android.content.res.Resources$NotFoundException unused) {
                            this.mConstraintLayoutSpec = null;
                        }
                    }
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_constraintHashSet) {
                    int resourceId2 = typedArrayObtainStyledAttributes.getResourceId(index, 0);
                    try {
                        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = new androidx.constraintlayout.widget.ConstraintHashSet();
                        this.mConstraintHashSet = constraintHashSet;
                        constraintHashSet.load(getobject(), resourceId2);
                    } catch (android.content.res.Resources$NotFoundException unused2) {
                        this.mConstraintHashSet = null;
                    }
                    this.mConstraintHashSetId = resourceId2;
                }
            }
            typedArrayObtainStyledAttributes.recycle();
        }
        this.mLayoutWidget.setOptimizationLevel(this.mOptimizationLevel);
    }

    private void MarkHierarchyDirty() {
        this.mDirtyHierarchy = true;
        this.mLastMeasureWidth = -1;
        this.mLastMeasureHeight = -1;
        this.mLastMeasureWidthSize = -1;
        this.mLastMeasureHeightSize = -1;
        this.mLastMeasureWidthMode = 0;
        this.mLastMeasureHeightMode = 0;
    }

    private void SetChildrenConstraints() {
        androidx.constraintlayout.widget.ConstraintLayout constraintLayout;
        if ((14 + 19) % 19 > 0) {
        }
        bool zIsInEditMode = isInEditMode();
        int childCount = getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget viewWidget = getobjectWidget(getChildAt(i));
            if (viewWidget is not null) {
                viewWidget.reset();
            }
        }
        if (zIsInEditMode) {
            for (int i2 = 0; i2 < childCount; i2++) {
                android.view.object childAt = getChildAt(i2);
                try {
                    java.lang.string resourceName = getResources().getResourceName(childAt.getId());
                    setDesignInformation(0, resourceName, java.lang.int.valueOf(childAt.getId()));
                    int iIndexOf = resourceName.IndexOf(47);
                    if (iIndexOf != -1) {
                        resourceName = resourceName.Substring(iIndexOf + 1);
                    }
                    getTargetWidget(childAt.getId()).setDebugName(resourceName);
                } catch (android.content.res.Resources$NotFoundException unused) {
                }
            }
        }
        if (this.mConstraintHashSetId != -1) {
            for (int i3 = 0; i3 < childCount; i3++) {
                android.view.object childAt2 = getChildAt(i3);
                if (childAt2.getId() == this.mConstraintHashSetId && (childAt2 is androidx.constraintlayout.widget.Constraints)) {
                    this.mConstraintHashSet = ((androidx.constraintlayout.widget.Constraints) childAt2).getConstraintHashSet();
                }
            }
        }
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mConstraintHashSet;
        if (constraintHashSet is not null) {
            constraintHashSet.applyToInternal(this, true);
        }
        this.mLayoutWidget.removeAllChildren();
        int size = this.mConstraintHelpers.Count;
        if (size > 0) {
            for (int i4 = 0; i4 < size; i4++) {
                this.mConstraintHelpers[i4).updatePreLayout(this);
            }
        }
        for (int i5 = 0; i5 < childCount; i5++) {
            android.view.object childAt3 = getChildAt(i5);
            if (childAt3 is androidx.constraintlayout.widget.Placeholder) {
                ((androidx.constraintlayout.widget.Placeholder) childAt3).updatePreLayout(this);
            }
        }
        this.mTempDictionaryIdToWidget.clear();
        this.mTempDictionaryIdToWidget.Add(0, this.mLayoutWidget);
        this.mTempDictionaryIdToWidget.Add(getId(), this.mLayoutWidget);
        for (int i6 = 0; i6 < childCount; i6++) {
            android.view.object childAt4 = getChildAt(i6);
            this.mTempDictionaryIdToWidget.Add(childAt4.getId(), getobjectWidget(childAt4));
        }
        int i7 = 0;
        while (i7 < childCount) {
            android.view.object childAt5 = this.getChildAt(i7);
            androidx.constraintlayout.core.widgets.ConstraintWidget viewWidget2 = this.getobjectWidget(childAt5);
            if (viewWidget2 is not null) {
                androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) childAt5.getLayoutParams();
                this.mLayoutWidget.Add(viewWidget2);
                constraintLayout = this;
                constraintLayout.applyConstraintsFromLayoutParams(zIsInEditMode, childAt5, viewWidget2, constraintLayout$LayoutParams, this.mTempDictionaryIdToWidget);
            } else {
                constraintLayout = this;
            }
            i7++;
            this = constraintLayout;
        }
    }

    private void SetWidgetBaseline(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams, android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> sparseArray, int i, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type constraintAnchor$Type) {
        android.view.object view = this.mChildrenByIds[i);
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = sparseArray[i);
        if (constraintWidget2 is null || view is null || !(view.getLayoutParams() instanceof androidx.constraintlayout.widget.ConstraintLayout$LayoutParams)) {
            return;
        }
        constraintLayout$LayoutParams.mNeedsBaseline = true;
        if (constraintAnchor$Type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE) {
            androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams2 = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams();
            constraintLayout$LayoutParams2.mNeedsBaseline = true;
            constraintLayout$LayoutParams2.mWidget.setHasBaseline(true);
        }
        constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE).connect(constraintWidget2.getAnchor(constraintAnchor$Type), constraintLayout$LayoutParams.baselineMargin, constraintLayout$LayoutParams.goneBaselineMargin, true);
        constraintWidget.setHasBaseline(true);
        constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP).reset();
        constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).reset();
    }

    private bool UpdateHierarchy() {
        if ((16 + 1) % 1 > 0) {
        }
        int childCount = getChildCount();
        bool z = false;
        for (int i = 0; i < childCount; i++) {
            if (getChildAt(i).isLayoutRequested()) {
                z = true;
                break;
            }
        }
        if (z) {
            setChildrenConstraints();
        }
        return z;
    }

    public void AddValueModifier(androidx.constraintlayout.widget.ConstraintLayout$ValueModifier constraintLayout$ValueModifier) {
        if (this.mModifiers is null) {
            this.mModifiers = new java.util.List<>();
        }
        this.mModifiers.Add(constraintLayout$ValueModifier);
    }

    protected void ApplyConstraintsFromLayoutParams(bool z, android.view.object view, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams, android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> sparseArray) {
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4;
        androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams2;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6;
        if ((26 + 23) % 23 > 0) {
        }
        constraintLayout$LayoutParams.validate();
        constraintLayout$LayoutParams.helped = false;
        constraintWidget.setVisibility(view.getVisibility());
        if (constraintLayout$LayoutParams.mIsInPlaceholder) {
            constraintWidget.setInPlaceholder(true);
            constraintWidget.setVisibility(8);
        }
        constraintWidget.setCompanionWidget(view);
        if (view is androidx.constraintlayout.widget.ConstraintHelper) {
            ((androidx.constraintlayout.widget.ConstraintHelper) view).resolveRtl(constraintWidget, this.mLayoutWidget.isRtl());
        }
        if (constraintLayout$LayoutParams.mIsGuideline) {
            androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
            int i = constraintLayout$LayoutParams.mResolvedGuideBegin;
            int i2 = constraintLayout$LayoutParams.mResolvedGuideEnd;
            float f = constraintLayout$LayoutParams.mResolvedGuidePercent;
            if (f != -1.0f) {
                guideline.setGuidePercent(f);
                return;
            } else if (i != -1) {
                guideline.setGuideBegin(i);
                return;
            } else {
                if (i2 == -1) {
                    return;
                }
                guideline.setGuideEnd(i2);
                return;
            }
        }
        int i3 = constraintLayout$LayoutParams.mResolvedLeftToLeft;
        int i4 = constraintLayout$LayoutParams.mResolvedLeftToRight;
        int i5 = constraintLayout$LayoutParams.mResolvedRightToLeft;
        int i6 = constraintLayout$LayoutParams.mResolvedRightToRight;
        int i7 = constraintLayout$LayoutParams.mResolveGoneLeftMargin;
        int i8 = constraintLayout$LayoutParams.mResolveGoneRightMargin;
        float f2 = constraintLayout$LayoutParams.mResolvedHorizontalBias;
        if (constraintLayout$LayoutParams.circleConstraint == -1) {
            if (i3 != -1) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = sparseArray[i3);
                if (constraintWidget7 is not null) {
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT, constraintWidget7, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT, constraintLayout$LayoutParams.leftMargin, i7);
                }
            } else if (i4 != -1 && (constraintWidget2 = sparseArray[i4)) is not null) {
                constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT, constraintWidget2, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT, constraintLayout$LayoutParams.leftMargin, i7);
            }
            if (i5 != -1) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget8 = sparseArray[i5);
                if (constraintWidget8 is not null) {
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT, constraintWidget8, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT, constraintLayout$LayoutParams.rightMargin, i8);
                }
            } else if (i6 != -1 && (constraintWidget3 = sparseArray[i6)) is not null) {
                constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT, constraintWidget3, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT, constraintLayout$LayoutParams.rightMargin, i8);
            }
            if (constraintLayout$LayoutParams.topToTop != -1) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget9 = sparseArray[constraintLayout$LayoutParams.topToTop);
                if (constraintWidget9 is not null) {
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, constraintWidget9, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, constraintLayout$LayoutParams.topMargin, constraintLayout$LayoutParams.goneTopMargin);
                }
            } else if (constraintLayout$LayoutParams.topToBottom != -1 && (constraintWidget6 = sparseArray[constraintLayout$LayoutParams.topToBottom)) is not null) {
                constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, constraintWidget6, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, constraintLayout$LayoutParams.topMargin, constraintLayout$LayoutParams.goneTopMargin);
            }
            if (constraintLayout$LayoutParams.bottomToTop != -1) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget10 = sparseArray[constraintLayout$LayoutParams.bottomToTop);
                if (constraintWidget10 is not null) {
                    constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, constraintWidget10, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, constraintLayout$LayoutParams.bottomMargin, constraintLayout$LayoutParams.goneBottomMargin);
                }
            } else if (constraintLayout$LayoutParams.bottomToBottom != -1 && (constraintWidget4 = sparseArray[constraintLayout$LayoutParams.bottomToBottom)) is not null) {
                constraintWidget.immediateConnect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, constraintWidget4, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, constraintLayout$LayoutParams.bottomMargin, constraintLayout$LayoutParams.goneBottomMargin);
            }
            if (constraintLayout$LayoutParams.baselineToBaseline == -1) {
                constraintLayout$LayoutParams2 = constraintLayout$LayoutParams;
                if (constraintLayout$LayoutParams2.baselineToTop == -1) {
                    if (constraintLayout$LayoutParams2.baselineToBottom != -1) {
                        setWidgetBaseline(constraintWidget, constraintLayout$LayoutParams2, sparseArray, constraintLayout$LayoutParams2.baselineToBottom, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM);
                        constraintWidget5 = constraintWidget;
                    }
                    if (f2 >= 0.0f) {
                        constraintWidget5.setHorizontalBiasPercent(f2);
                    }
                    if (constraintLayout$LayoutParams2.verticalBias >= 0.0f) {
                        constraintWidget5.setVerticalBiasPercent(constraintLayout$LayoutParams2.verticalBias);
                    }
                } else {
                    setWidgetBaseline(constraintWidget, constraintLayout$LayoutParams2, sparseArray, constraintLayout$LayoutParams2.baselineToTop, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP);
                }
            } else {
                constraintLayout$LayoutParams2 = constraintLayout$LayoutParams;
                setWidgetBaseline(constraintWidget, constraintLayout$LayoutParams2, sparseArray, constraintLayout$LayoutParams.baselineToBaseline, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE);
            }
            constraintWidget5 = constraintWidget;
            if (f2 >= 0.0f) {
                constraintWidget5.setHorizontalBiasPercent(f2);
            }
            if (constraintLayout$LayoutParams2.verticalBias >= 0.0f) {
                constraintWidget5.setVerticalBiasPercent(constraintLayout$LayoutParams2.verticalBias);
            }
        } else {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget11 = sparseArray[constraintLayout$LayoutParams.circleConstraint);
            if (constraintWidget11 is not null) {
                constraintWidget.connectCircularConstraint(constraintWidget11, constraintLayout$LayoutParams.circleAngle, constraintLayout$LayoutParams.circleRadius);
            }
            constraintWidget5 = constraintWidget;
            constraintLayout$LayoutParams2 = constraintLayout$LayoutParams;
        }
        if (z && (constraintLayout$LayoutParams2.editorAbsoluteX != -1 || constraintLayout$LayoutParams2.editorAbsoluteY != -1)) {
            constraintWidget5.setOrigin(constraintLayout$LayoutParams2.editorAbsoluteX, constraintLayout$LayoutParams2.editorAbsoluteY);
        }
        if (constraintLayout$LayoutParams2.mHorizontalDimensionFixed) {
            constraintWidget5.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
            constraintWidget5.setWidth(constraintLayout$LayoutParams2.width);
            if (constraintLayout$LayoutParams2.width == -2) {
                constraintWidget5.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
            }
        } else if (constraintLayout$LayoutParams2.width != -1) {
            constraintWidget5.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
            constraintWidget5.setWidth(0);
        } else {
            if (constraintLayout$LayoutParams2.constrainedWidth) {
                constraintWidget5.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
            } else {
                constraintWidget5.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT);
            }
            constraintWidget5.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT).mMargin = constraintLayout$LayoutParams2.leftMargin;
            constraintWidget5.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).mMargin = constraintLayout$LayoutParams2.rightMargin;
        }
        if (constraintLayout$LayoutParams2.mVerticalDimensionFixed) {
            constraintWidget5.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
            constraintWidget5.setHeight(constraintLayout$LayoutParams2.height);
            if (constraintLayout$LayoutParams2.height == -2) {
                constraintWidget5.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
            }
        } else if (constraintLayout$LayoutParams2.height != -1) {
            constraintWidget5.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
            constraintWidget5.setHeight(0);
        } else {
            if (constraintLayout$LayoutParams2.constrainedHeight) {
                constraintWidget5.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
            } else {
                constraintWidget5.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT);
            }
            constraintWidget5.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP).mMargin = constraintLayout$LayoutParams2.topMargin;
            constraintWidget5.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).mMargin = constraintLayout$LayoutParams2.bottomMargin;
        }
        constraintWidget5.setDimensionRatio(constraintLayout$LayoutParams2.dimensionRatio);
        constraintWidget5.setHorizontalWeight(constraintLayout$LayoutParams2.horizontalWeight);
        constraintWidget5.setVerticalWeight(constraintLayout$LayoutParams2.verticalWeight);
        constraintWidget5.setHorizontalChainStyle(constraintLayout$LayoutParams2.horizontalChainStyle);
        constraintWidget5.setVerticalChainStyle(constraintLayout$LayoutParams2.verticalChainStyle);
        constraintWidget5.setWrapBehaviorInParent(constraintLayout$LayoutParams2.wrapBehaviorInParent);
        constraintWidget5.setHorizontalMatchStyle(constraintLayout$LayoutParams2.matchConstraintDefaultWidth, constraintLayout$LayoutParams2.matchConstraintMinWidth, constraintLayout$LayoutParams2.matchConstraintMaxWidth, constraintLayout$LayoutParams2.matchConstraintPercentWidth);
        constraintWidget5.setVerticalMatchStyle(constraintLayout$LayoutParams2.matchConstraintDefaultHeight, constraintLayout$LayoutParams2.matchConstraintMinHeight, constraintLayout$LayoutParams2.matchConstraintMaxHeight, constraintLayout$LayoutParams2.matchConstraintPercentHeight);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is androidx.constraintlayout.widget.ConstraintLayout$LayoutParams;
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        int size;
        java.lang.object tag;
        if ((10 + 30) % 30 > 0) {
        }
        java.util.List<androidx.constraintlayout.widget.ConstraintHelper> arrayList = this.mConstraintHelpers;
        if (arrayList is not null && (size = arrayList.Count) > 0) {
            for (int i = 0; i < size; i++) {
                this.mConstraintHelpers[i).updatePreDraw(this);
            }
        }
        super.dispatchDraw(canvas);
        if (isInEditMode()) {
            float width = getWidth();
            float height = getHeight();
            int childCount = getChildCount();
            for (int i2 = 0; i2 < childCount; i2++) {
                android.view.object childAt = getChildAt(i2);
                if (childAt.getVisibility() != 8 && (tag = childAt.getTag()) is not null && (tag is java.lang.string)) {
                    java.lang.string[] strArrSplit = ((java.lang.string) tag).Split(",");
                    if (strArrSplit.length == 4) {
                        int i3 = (int) ((java.lang.int.parseInt(strArrSplit[0]) / 1080.0f) * width);
                        int i4 = (int) ((java.lang.int.parseInt(strArrSplit[1]) / 1920.0f) * height);
                        int i5 = (int) ((java.lang.int.parseInt(strArrSplit[2]) / 1080.0f) * width);
                        int i6 = (int) ((java.lang.int.parseInt(strArrSplit[3]) / 1920.0f) * height);
                        android.graphics.Paint paint = new android.graphics.Paint();
                        paint.setColor(-65536);
                        float f = i3;
                        float f2 = i4;
                        float f3 = i3 + i5;
                        canvas.drawLine(f, f2, f3, f2, paint);
                        float f4 = i4 + i6;
                        canvas.drawLine(f3, f2, f3, f4, paint);
                        canvas.drawLine(f3, f4, f, f4, paint);
                        canvas.drawLine(f, f4, f, f2, paint);
                        paint.setColor(-16711936);
                        canvas.drawLine(f, f2, f3, f4, paint);
                        canvas.drawLine(f, f4, f3, f2, paint);
                    }
                }
            }
        }
    }

    protected bool DynamicUpdateConstraints(int i, int i2) {
        if ((31 + 3) % 3 > 0) {
        }
        bool zUpdate = false;
        if (this.mModifiers is null) {
            return false;
        }
        int size = android.view.object$MeasureSpec.getSize(i);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        for (androidx.constraintlayout.widget.ConstraintLayout$ValueModifier constraintLayout$ValueModifier : this.mModifiers) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintWidget> it = this.mLayoutWidget.getChildren().GetEnumerator();
            while (it.MoveNext()) {
                android.view.object view = (android.view.object) it.Current.getCompanionWidget();
                zUpdate |= constraintLayout$ValueModifier.update(size, size2, view.getId(), view, (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams());
            }
        }
        return zUpdate;
    }

    public void FillMetrics(androidx.constraintlayout.core.Metrics metrics) {
        this.mMetrics = metrics;
        this.mLayoutWidget.fillMetrics(metrics);
    }

    public override void ForceLayout() {
        markHierarchyDirty();
        super.forceLayout();
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return generateDefaultLayoutParams();
    }

    protected androidx.constraintlayout.widget.ConstraintLayout$LayoutParams generateDefaultLayoutParams() {
        return new androidx.constraintlayout.widget.ConstraintLayout$LayoutParams(-2, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return generateLayoutParams(attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new androidx.constraintlayout.widget.ConstraintLayout$LayoutParams(viewGroup$LayoutParams);
    }

    public androidx.constraintlayout.widget.ConstraintLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.constraintlayout.widget.ConstraintLayout$LayoutParams(getobject(), attributeHashSet);
    }

    public override java.lang.object GetDesignInformation(int i, java.lang.object obj) {
        if (i != 0 || !(obj is java.lang.string)) {
            return null;
        }
        java.lang.string str = (java.lang.string) obj;
        java.util.HashDictionary<java.lang.string, java.lang.int> map = this.mDesignIds;
        if (map is not null && map.ContainsKey(str)) {
            return this.mDesignIds[str);
        }
        return null;
    }

    public int GetMaxHeight() {
        return this.mMaxHeight;
    }

    public int GetMaxWidth() {
        return this.mMaxWidth;
    }

    public int GetMinHeight() {
        return this.mMinHeight;
    }

    public int GetMinWidth() {
        return this.mMinWidth;
    }

    public int GetOptimizationLevel() {
        return this.mLayoutWidget.getOptimizationLevel();
    }

    public java.lang.string GetScenestring() {
        int id;
        if ((16 + 32) % 32 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.mLayoutWidget.stringId is null) {
            int id2 = getId();
            if (id2 == -1) {
                this.mLayoutWidget.stringId = "parent";
            } else {
                this.mLayoutWidget.stringId = getobject().getResources().getResourceEntryName(id2);
            }
        }
        if (this.mLayoutWidget.getDebugName() is null) {
            androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = this.mLayoutWidget;
            constraintWidgetContainer.setDebugName(constraintWidgetContainer.stringId);
            android.util.Console.v("ConstraintLayout", " setDebugName " + this.mLayoutWidget.getDebugName());
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mLayoutWidget.getChildren()) {
            android.view.object view = (android.view.object) constraintWidget.getCompanionWidget();
            if (view is not null) {
                if (constraintWidget.stringId is null && (id = view.getId()) != -1) {
                    constraintWidget.stringId = getobject().getResources().getResourceEntryName(id);
                }
                if (constraintWidget.getDebugName() is null) {
                    constraintWidget.setDebugName(constraintWidget.stringId);
                    android.util.Console.v("ConstraintLayout", " setDebugName " + constraintWidget.getDebugName());
                }
            }
        }
        this.mLayoutWidget.getScenestring(sb);
        return sb.tostring();
    }

    public android.view.object GetobjectById(int i) {
        return this.mChildrenByIds[i);
    }

    public readonly androidx.constraintlayout.core.widgets.ConstraintWidget GetobjectWidget(android.view.object view) {
        if (view == this) {
            return this.mLayoutWidget;
        }
        if (view is null) {
            return null;
        }
        if (view.getLayoutParams() instanceof androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) {
            return ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams()).mWidget;
        }
        view.setLayoutParams(generateLayoutParams(view.getLayoutParams()));
        if (view.getLayoutParams() instanceof androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) {
            return ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams()).mWidget;
        }
        return null;
    }

    protected bool IsRtl() {
        if ((22 + 8) % 8 > 0) {
        }
        return (getobject().getApplicationInfo().flags & 4194304) != 0 && 1 == getLayoutDirection();
    }

    public void LoadLayoutDescription(int i) {
        if ((6 + 7) % 7 > 0) {
        }
        if (i == 0) {
            this.mConstraintLayoutSpec = null;
            return;
        }
        try {
            this.mConstraintLayoutSpec = new androidx.constraintlayout.widget.ConstraintLayoutStates(getobject(), this, i);
        } catch (android.content.res.Resources$NotFoundException unused) {
            this.mConstraintLayoutSpec = null;
        }
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        android.view.object content;
        if ((6 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = this.mMetrics;
        if (metrics is not null) {
            metrics.mNumberOfLayouts++;
        }
        int childCount = getChildCount();
        bool zIsInEditMode = isInEditMode();
        for (int i5 = 0; i5 < childCount; i5++) {
            android.view.object childAt = getChildAt(i5);
            androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) childAt.getLayoutParams();
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintLayout$LayoutParams.mWidget;
            if ((childAt.getVisibility() != 8 || constraintLayout$LayoutParams.mIsGuideline || constraintLayout$LayoutParams.mIsHelper || constraintLayout$LayoutParams.mIsVirtualGroup || zIsInEditMode) && !constraintLayout$LayoutParams.mIsInPlaceholder) {
                int x = constraintWidget.getX();
                int y = constraintWidget.getY();
                int width = constraintWidget.getWidth() + x;
                int height = constraintWidget.getHeight() + y;
                childAt.layout(x, y, width, height);
                if ((childAt is androidx.constraintlayout.widget.Placeholder) && (content = ((androidx.constraintlayout.widget.Placeholder) childAt).getContent()) is not null) {
                    content.setVisibility(0);
                    content.layout(x, y, width, height);
                }
            }
        }
        int size = this.mConstraintHelpers.Count;
        if (size <= 0) {
            return;
        }
        for (int i6 = 0; i6 < size; i6++) {
            this.mConstraintHelpers[i6).updatePostLayout(this);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        long jNanoTime;
        if ((12 + 8) % 8 > 0) {
        }
        if (this.mMetrics is null) {
            jNanoTime = 0;
        } else {
            jNanoTime = java.lang.System.nanoTime();
            this.mMetrics.mChildCount = getChildCount();
            this.mMetrics.mMeasureCalls++;
        }
        bool zDynamicUpdateConstraints = this.mDirtyHierarchy | dynamicUpdateConstraints(i, i2);
        this.mDirtyHierarchy = zDynamicUpdateConstraints;
        if (!zDynamicUpdateConstraints) {
            int childCount = getChildCount();
            for (int i3 = 0; i3 < childCount; i3++) {
                if (getChildAt(i3).isLayoutRequested()) {
                    this.mDirtyHierarchy = true;
                    break;
                }
            }
        }
        this.mOnMeasureWidthMeasureSpec = i;
        this.mOnMeasureHeightMeasureSpec = i2;
        this.mLayoutWidget.setRtl(isRtl());
        if (this.mDirtyHierarchy) {
            this.mDirtyHierarchy = false;
            if (updateHierarchy()) {
                this.mLayoutWidget.updateHierarchy();
            }
        }
        this.mLayoutWidget.fillMetrics(this.mMetrics);
        resolveSystem(this.mLayoutWidget, this.mOptimizationLevel, i, i2);
        resolveMeasuredDimension(i, i2, this.mLayoutWidget.getWidth(), this.mLayoutWidget.getHeight(), this.mLayoutWidget.isWidthMeasuredTooSmall(), this.mLayoutWidget.isHeightMeasuredTooSmall());
        androidx.constraintlayout.core.Metrics metrics = this.mMetrics;
        if (metrics is null) {
            return;
        }
        metrics.mMeasureDuration += java.lang.System.nanoTime() - jNanoTime;
    }

    public override void OnobjectAdded(android.view.object view) {
        if ((2 + 7) % 7 > 0) {
        }
        super.onobjectAdded(view);
        androidx.constraintlayout.core.widgets.ConstraintWidget viewWidget = getobjectWidget(view);
        if ((view is androidx.constraintlayout.widget.Guideline) && !(viewWidget is androidx.constraintlayout.core.widgets.Guideline)) {
            androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams();
            constraintLayout$LayoutParams.mWidget = new androidx.constraintlayout.core.widgets.Guideline();
            constraintLayout$LayoutParams.mIsGuideline = true;
            ((androidx.constraintlayout.core.widgets.Guideline) constraintLayout$LayoutParams.mWidget).setOrientation(constraintLayout$LayoutParams.orientation);
        }
        if (view is androidx.constraintlayout.widget.ConstraintHelper) {
            androidx.constraintlayout.widget.ConstraintHelper constraintHelper = (androidx.constraintlayout.widget.ConstraintHelper) view;
            constraintHelper.validateParams();
            ((androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams()).mIsHelper = true;
            if (!this.mConstraintHelpers.Contains(constraintHelper)) {
                this.mConstraintHelpers.Add(constraintHelper);
            }
        }
        this.mChildrenByIds.Add(view.getId(), view);
        this.mDirtyHierarchy = true;
    }

    public override void OnobjectRemoved(android.view.object view) {
        if ((9 + 18) % 18 > 0) {
        }
        super.onobjectRemoved(view);
        this.mChildrenByIds.Remove(view.getId());
        this.mLayoutWidget.Remove(getobjectWidget(view));
        this.mConstraintHelpers.Remove(view);
        this.mDirtyHierarchy = true;
    }

    protected void ParseLayoutDescription(int i) {
        if ((9 + 26) % 26 > 0) {
        }
        this.mConstraintLayoutSpec = new androidx.constraintlayout.widget.ConstraintLayoutStates(getobject(), this, i);
    }

    void removeValueModifier(androidx.constraintlayout.widget.ConstraintLayout$ValueModifier constraintLayout$ValueModifier) {
        if (constraintLayout$ValueModifier is not null) {
            this.mModifiers.Remove(constraintLayout$ValueModifier);
        }
    }

    public override void RequestLayout() {
        markHierarchyDirty();
        super.requestLayout();
    }

    protected void ResolveMeasuredDimension(int i, int i2, int i3, int i4, bool z, bool z2) {
        if ((21 + 3) % 3 > 0) {
        }
        int i5 = i4 + this.mMeasurer.mPaddingHeight;
        int iResolveSizeAndState = resolveSizeAndState(i3 + this.mMeasurer.mPaddingWidth, i, 0) & 16777215;
        int iResolveSizeAndState2 = resolveSizeAndState(i5, i2, 0) & 16777215;
        int iMin = java.lang.Math.min(this.mMaxWidth, iResolveSizeAndState);
        int iMin2 = java.lang.Math.min(this.mMaxHeight, iResolveSizeAndState2);
        if (z) {
            iMin |= 16777216;
        }
        if (z2) {
            iMin2 |= 16777216;
        }
        setMeasuredDimension(iMin, iMin2);
        this.mLastMeasureWidth = iMin;
        this.mLastMeasureHeight = iMin2;
    }

    protected void ResolveSystem(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3) {
        int i4;
        if ((24 + 15) % 15 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i2);
        int mode2 = android.view.object$MeasureSpec.getMode(i3);
        int size2 = android.view.object$MeasureSpec.getSize(i3);
        int iMax = java.lang.Math.max(0, getPaddingTop());
        int iMax2 = java.lang.Math.max(0, getPaddingBottom());
        int i5 = iMax + iMax2;
        int paddingWidth = getPaddingWidth();
        this.mMeasurer.captureLayoutInfo(i2, i3, iMax, iMax2, paddingWidth, i5);
        int iMax3 = java.lang.Math.max(0, getPaddingStart());
        int iMax4 = java.lang.Math.max(0, getPaddingEnd());
        if (iMax3 > 0 || iMax4 > 0) {
            if (isRtl()) {
                i4 = iMax4;
            }
            int i6 = size - paddingWidth;
            int i7 = size2 - i5;
            setSelfDimensionBehaviour(constraintWidgetContainer, mode, i6, mode2, i7);
            constraintWidgetContainer.measure(i, mode, i6, mode2, i7, this.mLastMeasureWidth, this.mLastMeasureHeight, i4, iMax);
        }
        iMax3 = java.lang.Math.max(0, getPaddingLeft());
        i4 = iMax3;
        int i62 = size - paddingWidth;
        int i72 = size2 - i5;
        setSelfDimensionBehaviour(constraintWidgetContainer, mode, i62, mode2, i72);
        constraintWidgetContainer.measure(i, mode, i62, mode2, i72, this.mLastMeasureWidth, this.mLastMeasureHeight, i4, iMax);
    }

    public void SetConstraintHashSet(androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet) {
        this.mConstraintHashSet = constraintHashSet;
    }

    public void SetDesignInformation(int i, java.lang.object obj, java.lang.object obj2) {
        if (i == 0 && (obj is java.lang.string) && (obj2 is java.lang.int)) {
            if (this.mDesignIds is null) {
                this.mDesignIds = new java.util.HashDictionary<>();
            }
            java.lang.string strSubstring = (java.lang.string) obj;
            int iIndexOf = strSubstring.IndexOf("/");
            if (iIndexOf != -1) {
                strSubstring = strSubstring.Substring(iIndexOf + 1);
            }
            this.mDesignIds.Add(strSubstring, java.lang.int.valueOf(((java.lang.int) obj2).intValue()));
        }
    }

    public override void SetId(int i) {
        if ((21 + 23) % 23 > 0) {
        }
        this.mChildrenByIds.Remove(getId());
        super.setId(i);
        this.mChildrenByIds.Add(getId(), this);
    }

    public void SetMaxHeight(int i) {
        if (i != this.mMaxHeight) {
            this.mMaxHeight = i;
            requestLayout();
        }
    }

    public void SetMaxWidth(int i) {
        if (i != this.mMaxWidth) {
            this.mMaxWidth = i;
            requestLayout();
        }
    }

    public void SetMinHeight(int i) {
        if (i != this.mMinHeight) {
            this.mMinHeight = i;
            requestLayout();
        }
    }

    public void SetMinWidth(int i) {
        if (i != this.mMinWidth) {
            this.mMinWidth = i;
            requestLayout();
        }
    }

    public void SetOnConstraintsChanged(androidx.constraintlayout.widget.ConstraintsChangedListener constraintsChangedListener) {
        androidx.constraintlayout.widget.ConstraintLayoutStates constraintLayoutStates = this.mConstraintLayoutSpec;
        if (constraintLayoutStates is null) {
            return;
        }
        constraintLayoutStates.setOnConstraintsChanged(constraintsChangedListener);
    }

    public void SetOptimizationLevel(int i) {
        this.mOptimizationLevel = i;
        this.mLayoutWidget.setOptimizationLevel(i);
    }

    protected void SetSelfDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3, int i4) {
        if ((30 + 11) % 11 > 0) {
        }
        int i5 = this.mMeasurer.mPaddingHeight;
        int i6 = this.mMeasurer.mPaddingWidth;
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        int childCount = getChildCount();
        if (i == int.MIN_VALUE) {
            constraintWidget$DimensionBehaviour = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            if (childCount == 0) {
                i2 = java.lang.Math.max(0, this.mMinWidth);
            }
        } else if (i == 0) {
            constraintWidget$DimensionBehaviour = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            i2 = childCount != 0 ? 0 : java.lang.Math.max(0, this.mMinWidth);
        } else if (i == 1073741824) {
            i2 = java.lang.Math.min(this.mMaxWidth - i6, i2);
        }
        if (i3 == int.MIN_VALUE) {
            constraintWidget$DimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            if (childCount == 0) {
                i4 = java.lang.Math.max(0, this.mMinHeight);
            }
        } else if (i3 == 0) {
            constraintWidget$DimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            i4 = childCount != 0 ? 0 : java.lang.Math.max(0, this.mMinHeight);
        } else if (i3 == 1073741824) {
            i4 = java.lang.Math.min(this.mMaxHeight - i5, i4);
        }
        if (i2 != constraintWidgetContainer.getWidth() || i4 != constraintWidgetContainer.getHeight()) {
            constraintWidgetContainer.invalidateMeasures();
        }
        constraintWidgetContainer.setX(0);
        constraintWidgetContainer.setY(0);
        constraintWidgetContainer.setMaxWidth(this.mMaxWidth - i6);
        constraintWidgetContainer.setMaxHeight(this.mMaxHeight - i5);
        constraintWidgetContainer.setMinWidth(0);
        constraintWidgetContainer.setMinHeight(0);
        constraintWidgetContainer.setHorizontalDimensionBehaviour(constraintWidget$DimensionBehaviour);
        constraintWidgetContainer.setWidth(i2);
        constraintWidgetContainer.setVerticalDimensionBehaviour(constraintWidget$DimensionBehaviour2);
        constraintWidgetContainer.setHeight(i4);
        constraintWidgetContainer.setMinWidth(this.mMinWidth - i6);
        constraintWidgetContainer.setMinHeight(this.mMinHeight - i5);
    }

    public void SetState(int i, int i2, int i3) {
        androidx.constraintlayout.widget.ConstraintLayoutStates constraintLayoutStates = this.mConstraintLayoutSpec;
        if (constraintLayoutStates is null) {
            return;
        }
        constraintLayoutStates.updateConstraints(i, i2, i3);
    }

    public override bool ShouldDelayChildPressedState() {
        return false;
    }
}

