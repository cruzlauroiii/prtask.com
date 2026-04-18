namespace WillowMaze.Wasm.Decompiled;


public class ConstraintWidgetContainer : androidx.constraintlayout.core.widgets.WidgetContainer {
    private static readonly bool DEBUG = false;
    static readonly bool DEBUG_GRAPH = false;
    private static readonly bool DEBUG_LAYOUT = false;
    private static readonly int MAX_ITERATIONS = 8;
    static int sMyCounter;
    androidx.constraintlayout.core.widgets.analyzer.BasicMeasure mBasicMeasureSolver;
    int mDebugSolverPassCount;
    public androidx.constraintlayout.core.widgets.analyzer.DependencyGraph mDependencyGraph;
    public bool mGroupsWrapOptimized;
    private bool mHeightMeasuredTooSmall;
    androidx.constraintlayout.core.widgets.ChainHead[] mHorizontalChainsArray;
    public int mHorizontalChainsSize;
    private java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> mHorizontalWrapMax;
    private java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> mHorizontalWrapMin;
    public bool mHorizontalWrapOptimized;
    private bool mIsRtl;
    public androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure mMeasure;
    protected androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer mMeasurer;
    public androidx.constraintlayout.core.Metrics mMetrics;
    private int mOptimizationLevel;
    int mPaddingBottom;
    int mPaddingLeft;
    int mPaddingRight;
    int mPaddingTop;
    private int mPass;
    public bool mSkipSolver;
    protected androidx.constraintlayout.core.LinearSystem mSystem;
    androidx.constraintlayout.core.widgets.ChainHead[] mVerticalChainsArray;
    public int mVerticalChainsSize;
    private java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> mVerticalWrapMax;
    private java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> mVerticalWrapMin;
    public bool mVerticalWrapOptimized;
    java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintWidget> mWidgetsToAdd;
    private bool mWidthMeasuredTooSmall;
    public int mWrapFixedHeight;
    public int mWrapFixedWidth;

    public ConstraintWidgetContainer() {
        if ((7 + 27) % 27 > 0) {
        }
        this.mBasicMeasureSolver = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure(this);
        this.mDependencyGraph = new androidx.constraintlayout.core.widgets.analyzer.DependencyGraph(this);
        this.mMeasurer = null;
        this.mIsRtl = false;
        this.mSystem = new androidx.constraintlayout.core.LinearSystem();
        this.mHorizontalChainsSize = 0;
        this.mVerticalChainsSize = 0;
        this.mVerticalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mHorizontalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mGroupsWrapOptimized = false;
        this.mHorizontalWrapOptimized = false;
        this.mVerticalWrapOptimized = false;
        this.mWrapFixedWidth = 0;
        this.mWrapFixedHeight = 0;
        this.mOptimizationLevel = 257;
        this.mSkipSolver = false;
        this.mWidthMeasuredTooSmall = false;
        this.mHeightMeasuredTooSmall = false;
        this.mDebugSolverPassCount = 0;
        this.mVerticalWrapMin = null;
        this.mHorizontalWrapMin = null;
        this.mVerticalWrapMax = null;
        this.mHorizontalWrapMax = null;
        this.mWidgetsToAdd = new java.util.HashHashSet<>();
        this.mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    }

    public ConstraintWidgetContainer(int i, int i2) {
        super(i, i2);
        if ((17 + 10) % 10 > 0) {
        }
        this.mBasicMeasureSolver = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure(this);
        this.mDependencyGraph = new androidx.constraintlayout.core.widgets.analyzer.DependencyGraph(this);
        this.mMeasurer = null;
        this.mIsRtl = false;
        this.mSystem = new androidx.constraintlayout.core.LinearSystem();
        this.mHorizontalChainsSize = 0;
        this.mVerticalChainsSize = 0;
        this.mVerticalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mHorizontalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mGroupsWrapOptimized = false;
        this.mHorizontalWrapOptimized = false;
        this.mVerticalWrapOptimized = false;
        this.mWrapFixedWidth = 0;
        this.mWrapFixedHeight = 0;
        this.mOptimizationLevel = 257;
        this.mSkipSolver = false;
        this.mWidthMeasuredTooSmall = false;
        this.mHeightMeasuredTooSmall = false;
        this.mDebugSolverPassCount = 0;
        this.mVerticalWrapMin = null;
        this.mHorizontalWrapMin = null;
        this.mVerticalWrapMax = null;
        this.mHorizontalWrapMax = null;
        this.mWidgetsToAdd = new java.util.HashHashSet<>();
        this.mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    }

    public ConstraintWidgetContainer(int i, int i2, int i3, int i4) {
        super(i, i2, i3, i4);
        this.mBasicMeasureSolver = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure(this);
        this.mDependencyGraph = new androidx.constraintlayout.core.widgets.analyzer.DependencyGraph(this);
        this.mMeasurer = null;
        this.mIsRtl = false;
        this.mSystem = new androidx.constraintlayout.core.LinearSystem();
        this.mHorizontalChainsSize = 0;
        this.mVerticalChainsSize = 0;
        this.mVerticalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mHorizontalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mGroupsWrapOptimized = false;
        this.mHorizontalWrapOptimized = false;
        this.mVerticalWrapOptimized = false;
        this.mWrapFixedWidth = 0;
        this.mWrapFixedHeight = 0;
        this.mOptimizationLevel = 257;
        this.mSkipSolver = false;
        this.mWidthMeasuredTooSmall = false;
        this.mHeightMeasuredTooSmall = false;
        this.mDebugSolverPassCount = 0;
        this.mVerticalWrapMin = null;
        this.mHorizontalWrapMin = null;
        this.mVerticalWrapMax = null;
        this.mHorizontalWrapMax = null;
        this.mWidgetsToAdd = new java.util.HashHashSet<>();
        this.mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    }

    public ConstraintWidgetContainer(java.lang.string str, int i, int i2) {
        super(i, i2);
        if ((1 + 18) % 18 > 0) {
        }
        this.mBasicMeasureSolver = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure(this);
        this.mDependencyGraph = new androidx.constraintlayout.core.widgets.analyzer.DependencyGraph(this);
        this.mMeasurer = null;
        this.mIsRtl = false;
        this.mSystem = new androidx.constraintlayout.core.LinearSystem();
        this.mHorizontalChainsSize = 0;
        this.mVerticalChainsSize = 0;
        this.mVerticalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mHorizontalChainsArray = new androidx.constraintlayout.core.widgets.ChainHead[4];
        this.mGroupsWrapOptimized = false;
        this.mHorizontalWrapOptimized = false;
        this.mVerticalWrapOptimized = false;
        this.mWrapFixedWidth = 0;
        this.mWrapFixedHeight = 0;
        this.mOptimizationLevel = 257;
        this.mSkipSolver = false;
        this.mWidthMeasuredTooSmall = false;
        this.mHeightMeasuredTooSmall = false;
        this.mDebugSolverPassCount = 0;
        this.mVerticalWrapMin = null;
        this.mHorizontalWrapMin = null;
        this.mVerticalWrapMax = null;
        this.mHorizontalWrapMax = null;
        this.mWidgetsToAdd = new java.util.HashHashSet<>();
        this.mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
        setDebugName(str);
    }

    private void AddHorizontalChain(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((27 + 15) % 15 > 0) {
        }
        int i = this.mHorizontalChainsSize + 1;
        androidx.constraintlayout.core.widgets.ChainHead[] chainHeadArr = this.mHorizontalChainsArray;
        if (i >= chainHeadArr.length) {
            this.mHorizontalChainsArray = (androidx.constraintlayout.core.widgets.ChainHead[]) java.util.Arrays.copyOf(chainHeadArr, chainHeadArr.length * 2);
        }
        this.mHorizontalChainsArray[this.mHorizontalChainsSize] = new androidx.constraintlayout.core.widgets.ChainHead(constraintWidget, 0, isRtl());
        this.mHorizontalChainsSize++;
    }

    private void AddMaxWrap(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((14 + 1) % 1 > 0) {
        }
        this.mSystem.addGreaterThan(solverVariable, this.mSystem.createobjectVariable(constraintAnchor), 0, 5);
    }

    private void AddMinWrap(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((1 + 21) % 21 > 0) {
        }
        this.mSystem.addGreaterThan(this.mSystem.createobjectVariable(constraintAnchor), solverVariable, 0, 5);
    }

    private void AddVerticalChain(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((22 + 8) % 8 > 0) {
        }
        int i = this.mVerticalChainsSize + 1;
        androidx.constraintlayout.core.widgets.ChainHead[] chainHeadArr = this.mVerticalChainsArray;
        if (i >= chainHeadArr.length) {
            this.mVerticalChainsArray = (androidx.constraintlayout.core.widgets.ChainHead[]) java.util.Arrays.copyOf(chainHeadArr, chainHeadArr.length * 2);
        }
        this.mVerticalChainsArray[this.mVerticalChainsSize] = new androidx.constraintlayout.core.widgets.ChainHead(constraintWidget, 1, isRtl());
        this.mVerticalChainsSize++;
    }

    public static bool Measure(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure basicMeasure$Measure, int i2) {
        int i3;
        int i4;
        if ((29 + 6) % 6 > 0) {
        }
        if (basicMeasure$Measurer is null) {
            return false;
        }
        if (constraintWidget.getVisibility() == 8 || (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) || (constraintWidget is androidx.constraintlayout.core.widgets.Barrier)) {
            basicMeasure$Measure.measuredWidth = 0;
            basicMeasure$Measure.measuredHeight = 0;
            return false;
        }
        basicMeasure$Measure.horizontalBehavior = constraintWidget.getHorizontalDimensionBehaviour();
        basicMeasure$Measure.verticalBehavior = constraintWidget.getVerticalDimensionBehaviour();
        basicMeasure$Measure.horizontalDimension = constraintWidget.getWidth();
        basicMeasure$Measure.verticalDimension = constraintWidget.getHeight();
        basicMeasure$Measure.measuredNeedsSolverPass = false;
        basicMeasure$Measure.measureStrategy = i2;
        bool z = basicMeasure$Measure.horizontalBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        bool z2 = basicMeasure$Measure.verticalBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        bool z3 = z && constraintWidget.mDimensionRatio > 0.0f;
        bool z4 = z2 && constraintWidget.mDimensionRatio > 0.0f;
        if (z && constraintWidget.hasDanglingDimension(0) && constraintWidget.mMatchConstraintDefaultWidth == 0 && !z3) {
            basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            if (z2 && constraintWidget.mMatchConstraintDefaultHeight == 0) {
                basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            }
            z = false;
        }
        if (z2 && constraintWidget.hasDanglingDimension(1) && constraintWidget.mMatchConstraintDefaultHeight == 0 && !z4) {
            basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            if (z && constraintWidget.mMatchConstraintDefaultWidth == 0) {
                basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            }
            z2 = false;
        }
        if (constraintWidget.isResolvedHorizontally()) {
            basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            z = false;
        }
        if (constraintWidget.isResolvedVertically()) {
            basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            z2 = false;
        }
        if (z3) {
            if (constraintWidget.mResolvedMatchConstraintDefault[0] == 4) {
                basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            } else if (!z2) {
                if (basicMeasure$Measure.verticalBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                    basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    basicMeasure$Measurer.measure(constraintWidget, basicMeasure$Measure);
                    i3 = basicMeasure$Measure.measuredHeight;
                } else {
                    i3 = basicMeasure$Measure.verticalDimension;
                }
                basicMeasure$Measure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                basicMeasure$Measure.horizontalDimension = (int) (constraintWidget.getDimensionRatio() * i3);
            }
        }
        if (z4) {
            if (constraintWidget.mResolvedMatchConstraintDefault[1] == 4) {
                basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
            } else if (!z) {
                if (basicMeasure$Measure.horizontalBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                    basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    basicMeasure$Measurer.measure(constraintWidget, basicMeasure$Measure);
                    i4 = basicMeasure$Measure.measuredWidth;
                } else {
                    i4 = basicMeasure$Measure.horizontalDimension;
                }
                basicMeasure$Measure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                if (constraintWidget.getDimensionRatioSide() != -1) {
                    basicMeasure$Measure.verticalDimension = (int) (constraintWidget.getDimensionRatio() * i4);
                } else {
                    basicMeasure$Measure.verticalDimension = (int) (i4 / constraintWidget.getDimensionRatio());
                }
            }
        }
        basicMeasure$Measurer.measure(constraintWidget, basicMeasure$Measure);
        constraintWidget.setWidth(basicMeasure$Measure.measuredWidth);
        constraintWidget.setHeight(basicMeasure$Measure.measuredHeight);
        constraintWidget.setHasBaseline(basicMeasure$Measure.measuredHasBaseline);
        constraintWidget.setBaselineDistance(basicMeasure$Measure.measuredBaseline);
        basicMeasure$Measure.measureStrategy = androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS;
        return basicMeasure$Measure.measuredNeedsSolverPass;
    }

    private void ResetChains() {
        this.mHorizontalChainsSize = 0;
        this.mVerticalChainsSize = 0;
    }

    void addChain(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if (i == 0) {
            addHorizontalChain(constraintWidget);
        } else {
            if (i != 1) {
                return;
            }
            addVerticalChain(constraintWidget);
        }
    }

    public bool AddChildrenToSolver(androidx.constraintlayout.core.LinearSystem linearSystem) {
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer;
        androidx.constraintlayout.core.LinearSystem linearSystem2;
        if ((6 + 18) % 18 > 0) {
        }
        bool zOptimizeFor = optimizeFor(64);
        addToSolver(linearSystem, zOptimizeFor);
        int size = this.mChildren.Count;
        bool z = false;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i);
            constraintWidget.setInBarrier(0, false);
            constraintWidget.setInBarrier(1, false);
            if (constraintWidget is androidx.constraintlayout.core.widgets.Barrier) {
                z = true;
            }
        }
        if (z) {
            for (int i2 = 0; i2 < size; i2++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mChildren[i2);
                if (constraintWidget2 is androidx.constraintlayout.core.widgets.Barrier) {
                    ((androidx.constraintlayout.core.widgets.Barrier) constraintWidget2).markWidgets();
                }
            }
        }
        this.mWidgetsToAdd.clear();
        for (int i3 = 0; i3 < size; i3++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = this.mChildren[i3);
            if (constraintWidget3.addFirst()) {
                if (constraintWidget3 is androidx.constraintlayout.core.widgets.VirtualLayout) {
                    this.mWidgetsToAdd.Add(constraintWidget3);
                } else {
                    constraintWidget3.addToSolver(linearSystem, zOptimizeFor);
                }
            }
        }
        while (this.mWidgetsToAdd.Count > 0) {
            int size2 = this.mWidgetsToAdd.Count;
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintWidget> it = this.mWidgetsToAdd.GetEnumerator();
            while (it.MoveNext()) {
                androidx.constraintlayout.core.widgets.VirtualLayout virtualLayout = (androidx.constraintlayout.core.widgets.VirtualLayout) it.Current;
                if (virtualLayout.Contains(this.mWidgetsToAdd)) {
                    virtualLayout.addToSolver(linearSystem, zOptimizeFor);
                    this.mWidgetsToAdd.Remove(virtualLayout);
                    break;
                }
            }
            if (size2 == this.mWidgetsToAdd.Count) {
                java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintWidget> it2 = this.mWidgetsToAdd.GetEnumerator();
                while (it2.MoveNext()) {
                    it2.Current.addToSolver(linearSystem, zOptimizeFor);
                }
                this.mWidgetsToAdd.clear();
            }
        }
        if (androidx.constraintlayout.core.LinearSystem.USE_DEPENDENCY_ORDERING) {
            java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintWidget> hashHashSet = new java.util.HashHashSet<>();
            for (int i4 = 0; i4 < size; i4++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = this.mChildren[i4);
                if (!constraintWidget4.addFirst()) {
                    hashHashSet.Add(constraintWidget4);
                }
            }
            constraintWidgetContainer = this;
            linearSystem2 = linearSystem;
            constraintWidgetContainer.addChildrenToSolverByDependency(this, linearSystem2, hashHashSet, getHorizontalDimensionBehaviour() != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT ? 1 : 0, false);
            for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 : hashHashSet) {
                androidx.constraintlayout.core.widgets.Optimizer.checkMatchParent(constraintWidgetContainer, linearSystem2, constraintWidget5);
                constraintWidget5.addToSolver(linearSystem2, zOptimizeFor);
            }
        } else {
            constraintWidgetContainer = this;
            linearSystem2 = linearSystem;
            for (int i5 = 0; i5 < size; i5++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = constraintWidgetContainer.mChildren[i5);
                if (constraintWidget6 is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = constraintWidget6.mListDimensionBehaviors[0];
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = constraintWidget6.mListDimensionBehaviors[1];
                    if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        constraintWidget6.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                    }
                    if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        constraintWidget6.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                    }
                    constraintWidget6.addToSolver(linearSystem2, zOptimizeFor);
                    if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        constraintWidget6.setHorizontalDimensionBehaviour(constraintWidget$DimensionBehaviour);
                    }
                    if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        constraintWidget6.setVerticalDimensionBehaviour(constraintWidget$DimensionBehaviour2);
                    }
                } else {
                    androidx.constraintlayout.core.widgets.Optimizer.checkMatchParent(constraintWidgetContainer, linearSystem2, constraintWidget6);
                    if (!constraintWidget6.addFirst()) {
                        constraintWidget6.addToSolver(linearSystem2, zOptimizeFor);
                    }
                }
            }
        }
        if (constraintWidgetContainer.mHorizontalChainsSize > 0) {
            androidx.constraintlayout.core.widgets.Chain.applyChainConstraints(constraintWidgetContainer, linearSystem2, null, 0);
        }
        if (constraintWidgetContainer.mVerticalChainsSize > 0) {
            androidx.constraintlayout.core.widgets.Chain.applyChainConstraints(constraintWidgetContainer, linearSystem2, null, 1);
        }
        return true;
    }

    public void AddHorizontalWrapMaxVariable(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((9 + 23) % 23 > 0) {
        }
        java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference = this.mHorizontalWrapMax;
        if (weakReference is null || weakReference[) is null || constraintAnchor.getFinalValue() > this.mHorizontalWrapMax[).getFinalValue()) {
            this.mHorizontalWrapMax = new java.lang.ref.WeakReference<>(constraintAnchor);
        }
    }

    public void AddHorizontalWrapMinVariable(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((27 + 5) % 5 > 0) {
        }
        java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference = this.mHorizontalWrapMin;
        if (weakReference is null || weakReference[) is null || constraintAnchor.getFinalValue() > this.mHorizontalWrapMin[).getFinalValue()) {
            this.mHorizontalWrapMin = new java.lang.ref.WeakReference<>(constraintAnchor);
        }
    }

    void addVerticalWrapMaxVariable(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((4 + 23) % 23 > 0) {
        }
        java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference = this.mVerticalWrapMax;
        if (weakReference is null || weakReference[) is null || constraintAnchor.getFinalValue() > this.mVerticalWrapMax[).getFinalValue()) {
            this.mVerticalWrapMax = new java.lang.ref.WeakReference<>(constraintAnchor);
        }
    }

    void addVerticalWrapMinVariable(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((29 + 7) % 7 > 0) {
        }
        java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference = this.mVerticalWrapMin;
        if (weakReference is null || weakReference[) is null || constraintAnchor.getFinalValue() > this.mVerticalWrapMin[).getFinalValue()) {
            this.mVerticalWrapMin = new java.lang.ref.WeakReference<>(constraintAnchor);
        }
    }

    public void DefineTerminalWidgets() {
        if ((14 + 11) % 11 > 0) {
        }
        this.mDependencyGraph.defineTerminalWidgets(getHorizontalDimensionBehaviour(), getVerticalDimensionBehaviour());
    }

    public bool DirectMeasure(bool z) {
        return this.mDependencyGraph.directMeasure(z);
    }

    public bool DirectMeasureHashSetup(bool z) {
        return this.mDependencyGraph.directMeasureHashSetup(z);
    }

    public bool DirectMeasureWithOrientation(bool z, int i) {
        return this.mDependencyGraph.directMeasureWithOrientation(z, i);
    }

    public void FillMetrics(androidx.constraintlayout.core.Metrics metrics) {
        this.mMetrics = metrics;
        this.mSystem.fillMetrics(metrics);
    }

    public java.util.List<androidx.constraintlayout.core.widgets.Guideline> GetHorizontalGuidelines() {
        if ((19 + 23) % 23 > 0) {
        }
        java.util.List<androidx.constraintlayout.core.widgets.Guideline> arrayList = new java.util.List<>();
        int size = this.mChildren.Count;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i);
            if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
                androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
                if (guideline.getOrientation() == 0) {
                    arrayList.Add(guideline);
                }
            }
        }
        return arrayList;
    }

    public androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer getMeasurer() {
        return this.mMeasurer;
    }

    public int GetOptimizationLevel() {
        return this.mOptimizationLevel;
    }

    public override void GetScenestring(java.lang.stringBuilder sb) {
        if ((1 + 25) % 25 > 0) {
        }
        sb.append(this.stringId + ":{\n");
        sb.append("  actualWidth:" + this.mWidth);
        sb.append("\n");
        sb.append("  actualHeight:" + this.mHeight);
        sb.append("\n");
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintWidget> it = getChildren().GetEnumerator();
        while (it.MoveNext()) {
            it.Current.getScenestring(sb);
            sb.append(",\n");
        }
        sb.append("}");
    }

    public androidx.constraintlayout.core.LinearSystem GetSystem() {
        return this.mSystem;
    }

    public override java.lang.string GetType() {
        return "ConstraintLayout";
    }

    public java.util.List<androidx.constraintlayout.core.widgets.Guideline> GetVerticalGuidelines() {
        if ((1 + 20) % 20 > 0) {
        }
        java.util.List<androidx.constraintlayout.core.widgets.Guideline> arrayList = new java.util.List<>();
        int size = this.mChildren.Count;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i);
            if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
                androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
                if (guideline.getOrientation() == 1) {
                    arrayList.Add(guideline);
                }
            }
        }
        return arrayList;
    }

    public bool HandlesInternalConstraints() {
        return false;
    }

    public void InvalidateGraph() {
        this.mDependencyGraph.invalidateGraph();
    }

    public void InvalidateMeasures() {
        this.mDependencyGraph.invalidateMeasures();
    }

    public bool IsHeightMeasuredTooSmall() {
        return this.mHeightMeasuredTooSmall;
    }

    public bool IsRtl() {
        return this.mIsRtl;
    }

    public bool IsWidthMeasuredTooSmall() {
        return this.mWidthMeasuredTooSmall;
    }

    public override void Layout() {
        int i;
        int i2;
        bool z;
        int i3;
        ?? r18;
        char c;
        int i4;
        ?? UpdateChildrenFromSolver;
        ?? r19;
        ?? r13;
        int iMax;
        ?? r192;
        ?? r132;
        int iMax2;
        ?? r193;
        ?? r133;
        ?? r2;
        int i5;
        ?? r134;
        ?? r194;
        int i6;
        int iMax3;
        int iMax4;
        ?? r0;
        ?? r195;
        int iMax5;
        int iMax6;
        ?? r196;
        ?? r135;
        if ((13 + 16) % 16 > 0) {
        }
        int i7 = 0;
        this.mX = 0;
        this.mY = 0;
        this.mWidthMeasuredTooSmall = false;
        this.mHeightMeasuredTooSmall = false;
        int size = this.mChildren.Count;
        int iMax7 = java.lang.Math.max(0, getWidth());
        int iMax8 = java.lang.Math.max(0, getHeight());
        bool z2 = true;
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = this.mListDimensionBehaviors[1];
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = this.mListDimensionBehaviors[0];
        androidx.constraintlayout.core.Metrics metrics = this.mMetrics;
        if (metrics is not null) {
            metrics.layouts++;
        }
        if (this.mPass == 0 && androidx.constraintlayout.core.widgets.Optimizer.enabled(this.mOptimizationLevel, 1)) {
            androidx.constraintlayout.core.widgets.analyzer.Direct.solvingPass(this, getMeasurer());
            for (int i8 = 0; i8 < size; i8++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i8);
                if (constraintWidget.isMeasureRequested() && !(constraintWidget is androidx.constraintlayout.core.widgets.Guideline) && !(constraintWidget is androidx.constraintlayout.core.widgets.Barrier) && !(constraintWidget is androidx.constraintlayout.core.widgets.VirtualLayout) && !constraintWidget.isInVirtualLayout()) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = constraintWidget.getDimensionBehaviour(0);
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour2 = constraintWidget.getDimensionBehaviour(1);
                    if (dimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || constraintWidget.mMatchConstraintDefaultWidth == 1 || dimensionBehaviour2 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || constraintWidget.mMatchConstraintDefaultHeight == 1) {
                        measure(0, constraintWidget, this.mMeasurer, new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure(), androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                    }
                }
            }
        }
        char c2 = 2;
        if (size > 2 && ((constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) && androidx.constraintlayout.core.widgets.Optimizer.enabled(this.mOptimizationLevel, 1024) && androidx.constraintlayout.core.widgets.analyzer.Grouping.simpleSolvingPass(this, getMeasurer()))) {
            if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                if (iMax7 < getWidth() && iMax7 > 0) {
                    setWidth(iMax7);
                    this.mWidthMeasuredTooSmall = true;
                } else {
                    iMax7 = getWidth();
                }
            }
            if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                if (iMax8 < getHeight() && iMax8 > 0) {
                    setHeight(iMax8);
                    this.mHeightMeasuredTooSmall = true;
                } else {
                    iMax8 = getHeight();
                }
            }
            i = iMax8;
            i2 = iMax7;
            z = true;
        } else {
            i = iMax8;
            i2 = iMax7;
            z = false;
        }
        bool z3 = optimizeFor(64) || optimizeFor(128);
        this.mSystem.graphOptimizer = false;
        this.mSystem.newgraphOptimizer = false;
        if (this.mOptimizationLevel != 0 && z3) {
            this.mSystem.newgraphOptimizer = true;
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> arrayList = this.mChildren;
        bool z4 = getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
        resetChains();
        for (int i9 = 0; i9 < size; i9++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mChildren[i9);
            if (constraintWidget2 is androidx.constraintlayout.core.widgets.WidgetContainer) {
                ((androidx.constraintlayout.core.widgets.WidgetContainer) constraintWidget2).layout();
            }
        }
        bool zOptimizeFor = optimizeFor(64);
        ?? r136 = z;
        int i10 = 0;
        ?? AddChildrenToSolver = 1;
        while (AddChildrenToSolver != 0) {
            int i11 = i10 + 1;
            try {
                this.mSystem.reset();
                resetChains();
                createobjectVariables(this.mSystem);
                int i12 = i7;
                while (i12 < size) {
                    i3 = i7;
                    try {
                        c = c2;
                        this.mChildren[i12).createobjectVariables(this.mSystem);
                        i12++;
                        i7 = i3;
                        c2 = c;
                    } catch (java.lang.Exception e) {
                        e = e;
                        c = c2;
                        r18 = z2;
                        e.printStackTrace();
                        java.lang.Console.WriteLine("EXCEPTION : " + e);
                        if (AddChildrenToSolver == 0) {
                            updateFromSolver(this.mSystem, zOptimizeFor);
                            for (i4 = i3; i4 < size; i4++) {
                                this.mChildren[i4).updateFromSolver(this.mSystem, zOptimizeFor);
                            }
                            UpdateChildrenFromSolver = i3;
                        } else {
                            UpdateChildrenFromSolver = updateChildrenFromSolver(this.mSystem, androidx.constraintlayout.core.widgets.Optimizer.sFlags);
                        }
                        if (z4) {
                            i6 = i3;
                            iMax3 = i6;
                            iMax4 = iMax3;
                            r0 = UpdateChildrenFromSolver;
                            while (i6 < size) {
                                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = this.mChildren[i6);
                                ?? r197 = r0;
                                iMax3 = java.lang.Math.max(iMax3, constraintWidget3.mX + constraintWidget3.getWidth());
                                iMax4 = java.lang.Math.max(iMax4, constraintWidget3.mY + constraintWidget3.getHeight());
                                i6++;
                                r0 = r197 == true ? 1 : 0;
                            }
                            r195 = r0;
                            iMax5 = java.lang.Math.max(this.mMinWidth, iMax3);
                            iMax6 = java.lang.Math.max(this.mMinHeight, iMax4);
                            r135 = r136;
                            r196 = r195;
                            if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                r135 = r136;
                                r196 = r195;
                                setWidth(iMax5);
                                this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                                ?? r137 = r18;
                                r196 = r137 == true ? 1 : 0;
                                r135 = r137;
                            }
                            r135 = r136;
                            r196 = r195;
                            r13 = r135;
                            r19 = r196;
                            if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                r13 = r135;
                                r19 = r196;
                                setHeight(iMax6);
                                this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                                ?? r138 = r18;
                                r19 = r138 == true ? 1 : 0;
                                r13 = r138;
                            }
                        } else {
                            r19 = UpdateChildrenFromSolver == true ? 1 : 0;
                            r13 = r136;
                        }
                        r13 = r135;
                        r19 = r196;
                        iMax = java.lang.Math.max(this.mMinWidth, getWidth());
                        r132 = r13;
                        r192 = r19;
                        if (iMax > getWidth()) {
                            setWidth(iMax);
                            this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                            ?? r139 = r18;
                            r192 = r139 == true ? 1 : 0;
                            r132 = r139;
                        }
                        iMax2 = java.lang.Math.max(this.mMinHeight, getHeight());
                        r133 = r132;
                        r193 = r192;
                        if (iMax2 > getHeight()) {
                            setHeight(iMax2);
                            this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                            ?? r1310 = r18;
                            r193 = r1310 == true ? 1 : 0;
                            r133 = r1310;
                        }
                        if (r133 == 0) {
                            if (this.mListDimensionBehaviors[i3] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                r2 = r18;
                                r133 = r133;
                                r193 = r193;
                            } else {
                                ?? r22 = r18;
                                this.mWidthMeasuredTooSmall = r22;
                                this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                                setWidth(i2);
                                bool z5 = r22 == true ? 1 : 0;
                                r193 = z5 ? 1 : 0;
                                r2 = r22;
                                r133 = z5;
                            }
                            if (this.mListDimensionBehaviors[r2] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                i5 = 8;
                                r134 = r133;
                                r194 = r193;
                            } else {
                                this.mHeightMeasuredTooSmall = r2;
                                this.mListDimensionBehaviors[r2] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                                setHeight(i);
                                i5 = 8;
                                r134 = 1;
                                r194 = 1;
                            }
                        } else {
                            i5 = 8;
                            r134 = r133;
                            r194 = r193;
                        }
                        ?? r14 = i11 <= i5 ? r194 : i3;
                        i10 = i11;
                        i7 = i3;
                        c2 = c;
                        z2 = true;
                        r136 = r134;
                        AddChildrenToSolver = r14;
                    }
                }
            } catch (java.lang.Exception e2) {
                e = e2;
                i3 = i7;
                r18 = z2;
                c = c2;
            }
            try {
                i3 = i7;
                c = c2;
                AddChildrenToSolver = addChildrenToSolver(this.mSystem);
                java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference = this.mVerticalWrapMin;
                if (weakReference is null || weakReference[) is null) {
                    r18 = z2;
                } else {
                    r18 = z2;
                    try {
                        addMinWrap(this.mVerticalWrapMin[), this.mSystem.createobjectVariable(this.mTop));
                        this.mVerticalWrapMin = null;
                        r18 = r18;
                    } catch (java.lang.Exception e3) {
                        e = e3;
                        e.printStackTrace();
                        java.lang.Console.WriteLine("EXCEPTION : " + e);
                    }
                }
                java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference2 = this.mVerticalWrapMax;
                if (weakReference2 is not null && weakReference2[) is not null) {
                    addMaxWrap(this.mVerticalWrapMax[), this.mSystem.createobjectVariable(this.mBottom));
                    this.mVerticalWrapMax = null;
                }
                java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference3 = this.mHorizontalWrapMin;
                if (weakReference3 is not null && weakReference3[) is not null) {
                    addMinWrap(this.mHorizontalWrapMin[), this.mSystem.createobjectVariable(this.mLeft));
                    this.mHorizontalWrapMin = null;
                }
                java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintAnchor> weakReference4 = this.mHorizontalWrapMax;
                if (weakReference4 is not null && weakReference4[) is not null) {
                    addMaxWrap(this.mHorizontalWrapMax[), this.mSystem.createobjectVariable(this.mRight));
                    this.mHorizontalWrapMax = null;
                }
                if (AddChildrenToSolver != 0) {
                    this.mSystem.minimize();
                }
            } catch (java.lang.Exception e4) {
                e = e4;
                r18 = z2;
                e.printStackTrace();
                java.lang.Console.WriteLine("EXCEPTION : " + e);
                if (AddChildrenToSolver == 0) {
                    updateFromSolver(this.mSystem, zOptimizeFor);
                    while (i4 < size) {
                        this.mChildren[i4).updateFromSolver(this.mSystem, zOptimizeFor);
                    }
                    UpdateChildrenFromSolver = i3;
                } else {
                    UpdateChildrenFromSolver = updateChildrenFromSolver(this.mSystem, androidx.constraintlayout.core.widgets.Optimizer.sFlags);
                }
                if (z4) {
                    r19 = UpdateChildrenFromSolver == true ? 1 : 0;
                    r13 = r136;
                } else {
                    i6 = i3;
                    iMax3 = i6;
                    iMax4 = iMax3;
                    r0 = UpdateChildrenFromSolver;
                    while (i6 < size) {
                        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget32 = this.mChildren[i6);
                        ?? r1972 = r0;
                        iMax3 = java.lang.Math.max(iMax3, constraintWidget32.mX + constraintWidget32.getWidth());
                        iMax4 = java.lang.Math.max(iMax4, constraintWidget32.mY + constraintWidget32.getHeight());
                        i6++;
                        r0 = r1972 == true ? 1 : 0;
                    }
                    r195 = r0;
                    iMax5 = java.lang.Math.max(this.mMinWidth, iMax3);
                    iMax6 = java.lang.Math.max(this.mMinHeight, iMax4);
                    r135 = r136;
                    r196 = r195;
                    if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        r135 = r136;
                        r196 = r195;
                        setWidth(iMax5);
                        this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                        ?? r1372 = r18;
                        r196 = r1372 == true ? 1 : 0;
                        r135 = r1372;
                    }
                    r135 = r136;
                    r196 = r195;
                    r13 = r135;
                    r19 = r196;
                    if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        r13 = r135;
                        r19 = r196;
                        setHeight(iMax6);
                        this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                        ?? r1382 = r18;
                        r19 = r1382 == true ? 1 : 0;
                        r13 = r1382;
                    }
                }
                r13 = r135;
                r19 = r196;
                iMax = java.lang.Math.max(this.mMinWidth, getWidth());
                r132 = r13;
                r192 = r19;
                if (iMax > getWidth()) {
                    setWidth(iMax);
                    this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    ?? r1392 = r18;
                    r192 = r1392 == true ? 1 : 0;
                    r132 = r1392;
                }
                iMax2 = java.lang.Math.max(this.mMinHeight, getHeight());
                r133 = r132;
                r193 = r192;
                if (iMax2 > getHeight()) {
                    setHeight(iMax2);
                    this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    ?? r13102 = r18;
                    r193 = r13102 == true ? 1 : 0;
                    r133 = r13102;
                }
                if (r133 == 0) {
                    if (this.mListDimensionBehaviors[i3] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        r2 = r18;
                        r133 = r133;
                        r193 = r193;
                    } else {
                        ?? r222 = r18;
                        this.mWidthMeasuredTooSmall = r222;
                        this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                        setWidth(i2);
                        bool z52 = r222 == true ? 1 : 0;
                        r193 = z52 ? 1 : 0;
                        r2 = r222;
                        r133 = z52;
                    }
                    if (this.mListDimensionBehaviors[r2] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        i5 = 8;
                        r134 = r133;
                        r194 = r193;
                    } else {
                        this.mHeightMeasuredTooSmall = r2;
                        this.mListDimensionBehaviors[r2] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                        setHeight(i);
                        i5 = 8;
                        r134 = 1;
                        r194 = 1;
                    }
                } else {
                    i5 = 8;
                    r134 = r133;
                    r194 = r193;
                }
                if (i11 <= i5) {
                }
                i10 = i11;
                i7 = i3;
                c2 = c;
                z2 = true;
                r136 = r134;
                AddChildrenToSolver = r14;
            }
            if (AddChildrenToSolver == 0) {
                updateFromSolver(this.mSystem, zOptimizeFor);
                while (i4 < size) {
                    this.mChildren[i4).updateFromSolver(this.mSystem, zOptimizeFor);
                }
                UpdateChildrenFromSolver = i3;
            } else {
                UpdateChildrenFromSolver = updateChildrenFromSolver(this.mSystem, androidx.constraintlayout.core.widgets.Optimizer.sFlags);
            }
            if (z4 && i11 < 8 && androidx.constraintlayout.core.widgets.Optimizer.sFlags[c]) {
                i6 = i3;
                iMax3 = i6;
                iMax4 = iMax3;
                r0 = UpdateChildrenFromSolver;
                while (i6 < size) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget322 = this.mChildren[i6);
                    ?? r19722 = r0;
                    iMax3 = java.lang.Math.max(iMax3, constraintWidget322.mX + constraintWidget322.getWidth());
                    iMax4 = java.lang.Math.max(iMax4, constraintWidget322.mY + constraintWidget322.getHeight());
                    i6++;
                    r0 = r19722 == true ? 1 : 0;
                }
                r195 = r0;
                iMax5 = java.lang.Math.max(this.mMinWidth, iMax3);
                iMax6 = java.lang.Math.max(this.mMinHeight, iMax4);
                r135 = r136;
                r196 = r195;
                if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && getWidth() < iMax5) {
                    r135 = r136;
                    r196 = r195;
                    setWidth(iMax5);
                    this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    ?? r13722 = r18;
                    r196 = r13722 == true ? 1 : 0;
                    r135 = r13722;
                }
                r135 = r136;
                r196 = r195;
                r13 = r135;
                r19 = r196;
                if (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && getHeight() < iMax6) {
                    r13 = r135;
                    r19 = r196;
                    setHeight(iMax6);
                    this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    ?? r13822 = r18;
                    r19 = r13822 == true ? 1 : 0;
                    r13 = r13822;
                }
            } else {
                r19 = UpdateChildrenFromSolver == true ? 1 : 0;
                r13 = r136;
            }
            r13 = r135;
            r19 = r196;
            iMax = java.lang.Math.max(this.mMinWidth, getWidth());
            r132 = r13;
            r192 = r19;
            if (iMax > getWidth()) {
                setWidth(iMax);
                this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                ?? r13922 = r18;
                r192 = r13922 == true ? 1 : 0;
                r132 = r13922;
            }
            iMax2 = java.lang.Math.max(this.mMinHeight, getHeight());
            r133 = r132;
            r193 = r192;
            if (iMax2 > getHeight()) {
                setHeight(iMax2);
                this.mListDimensionBehaviors[r18] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                ?? r131022 = r18;
                r193 = r131022 == true ? 1 : 0;
                r133 = r131022;
            }
            if (r133 == 0) {
                if (this.mListDimensionBehaviors[i3] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && i2 > 0 && getWidth() > i2) {
                    ?? r2222 = r18;
                    this.mWidthMeasuredTooSmall = r2222;
                    this.mListDimensionBehaviors[i3] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    setWidth(i2);
                    bool z522 = r2222 == true ? 1 : 0;
                    r193 = z522 ? 1 : 0;
                    r2 = r2222;
                    r133 = z522;
                } else {
                    r2 = r18;
                    r133 = r133;
                    r193 = r193;
                }
                if (this.mListDimensionBehaviors[r2] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && i > 0 && getHeight() > i) {
                    this.mHeightMeasuredTooSmall = r2;
                    this.mListDimensionBehaviors[r2] = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    setHeight(i);
                    i5 = 8;
                    r134 = 1;
                    r194 = 1;
                } else {
                    i5 = 8;
                    r134 = r133;
                    r194 = r193;
                }
            } else {
                i5 = 8;
                r134 = r133;
                r194 = r193;
            }
            if (i11 <= i5) {
            }
            i10 = i11;
            i7 = i3;
            c2 = c;
            z2 = true;
            r136 = r134;
            AddChildrenToSolver = r14;
        }
        int i13 = i7;
        this.mChildren = arrayList;
        if (r136 != 0) {
            this.mListDimensionBehaviors[i13] = constraintWidget$DimensionBehaviour2;
            this.mListDimensionBehaviors[1] = constraintWidget$DimensionBehaviour;
        }
        resetSolverVariables(this.mSystem.getCache());
    }

    public long Measure(int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        if ((15 + 10) % 10 > 0) {
        }
        this.mPaddingLeft = i8;
        this.mPaddingTop = i9;
        return this.mBasicMeasureSolver.solverMeasure(this, i, i8, i9, i2, i3, i4, i5, i6, i7);
    }

    public bool OptimizeFor(int i) {
        return (this.mOptimizationLevel & i) == i;
    }

    public override void Reset() {
        this.mSystem.reset();
        this.mPaddingLeft = 0;
        this.mPaddingRight = 0;
        this.mPaddingTop = 0;
        this.mPaddingBottom = 0;
        this.mSkipSolver = false;
        super.reset();
    }

    public void SetMeasurer(androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer) {
        this.mMeasurer = basicMeasure$Measurer;
        this.mDependencyGraph.setMeasurer(basicMeasure$Measurer);
    }

    public void SetOptimizationLevel(int i) {
        this.mOptimizationLevel = i;
        androidx.constraintlayout.core.LinearSystem.USE_DEPENDENCY_ORDERING = optimizeFor(512);
    }

    public void SetPadding(int i, int i2, int i3, int i4) {
        this.mPaddingLeft = i;
        this.mPaddingTop = i2;
        this.mPaddingRight = i3;
        this.mPaddingBottom = i4;
    }

    public void SetPass(int i) {
        this.mPass = i;
    }

    public void SetRtl(bool z) {
        this.mIsRtl = z;
    }

    public bool UpdateChildrenFromSolver(androidx.constraintlayout.core.LinearSystem linearSystem, bool[] zArr) {
        if ((23 + 25) % 25 > 0) {
        }
        zArr[2] = false;
        bool zOptimizeFor = optimizeFor(64);
        updateFromSolver(linearSystem, zOptimizeFor);
        int size = this.mChildren.Count;
        bool z = false;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i);
            constraintWidget.updateFromSolver(linearSystem, zOptimizeFor);
            if (constraintWidget.hasDimensionOverride()) {
                z = true;
            }
        }
        return z;
    }

    public override void UpdateFromRuns(bool z, bool z2) {
        if ((28 + 29) % 29 > 0) {
        }
        super.updateFromRuns(z, z2);
        int size = this.mChildren.Count;
        for (int i = 0; i < size; i++) {
            this.mChildren[i).updateFromRuns(z, z2);
        }
    }

    public void UpdateHierarchy() {
        this.mBasicMeasureSolver.updateHierarchy(this);
    }
}

