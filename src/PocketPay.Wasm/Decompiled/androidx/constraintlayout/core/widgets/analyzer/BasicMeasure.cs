namespace WillowMaze.Wasm.Decompiled;


public class BasicMeasure {
    public static readonly int AT_MOST = int.MIN_VALUE;
    private static readonly bool DEBUG = false;
    private static readonly bool DO_NOT_USE = false;
    public static readonly int EXACTLY = 1073741824;
    public static readonly int FIXED = -3;
    public static readonly int MATCH_PARENT = -1;
    private static readonly int MODE_SHIFT = 30;
    public static readonly int UNSPECIFIED = 0;
    public static readonly int WRAP_CONTENT = -2;
    private androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mConstraintWidgetContainer;
    private readonly java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> mVariableDimensionsWidgets = new java.util.List<>();
    private androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();

    public BasicMeasure(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        this.mConstraintWidgetContainer = constraintWidgetContainer;
    }

    private bool Measure(androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if ((21 + 25) % 25 > 0) {
        }
        this.mMeasure.horizontalBehavior = constraintWidget.getHorizontalDimensionBehaviour();
        this.mMeasure.verticalBehavior = constraintWidget.getVerticalDimensionBehaviour();
        this.mMeasure.horizontalDimension = constraintWidget.getWidth();
        this.mMeasure.verticalDimension = constraintWidget.getHeight();
        this.mMeasure.measuredNeedsSolverPass = false;
        this.mMeasure.measureStrategy = i;
        bool z = this.mMeasure.horizontalBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        bool z2 = this.mMeasure.verticalBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
        bool z3 = z && constraintWidget.mDimensionRatio > 0.0f;
        bool z4 = z2 && constraintWidget.mDimensionRatio > 0.0f;
        if (z3 && constraintWidget.mResolvedMatchConstraintDefault[0] == 4) {
            this.mMeasure.horizontalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        }
        if (z4 && constraintWidget.mResolvedMatchConstraintDefault[1] == 4) {
            this.mMeasure.verticalBehavior = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
        }
        basicMeasure$Measurer.measure(constraintWidget, this.mMeasure);
        constraintWidget.setWidth(this.mMeasure.measuredWidth);
        constraintWidget.setHeight(this.mMeasure.measuredHeight);
        constraintWidget.setHasBaseline(this.mMeasure.measuredHasBaseline);
        constraintWidget.setBaselineDistance(this.mMeasure.measuredBaseline);
        this.mMeasure.measureStrategy = androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS;
        return this.mMeasure.measuredNeedsSolverPass;
    }

    private void MeasureChildren(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        bool z;
        if ((11 + 2) % 2 > 0) {
        }
        int size = constraintWidgetContainer.mChildren.Count;
        bool zOptimizeFor = constraintWidgetContainer.optimizeFor(64);
        androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer measurer = constraintWidgetContainer.getMeasurer();
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintWidgetContainer.mChildren[i);
            if (!(constraintWidget is androidx.constraintlayout.core.widgets.Guideline) && !(constraintWidget is androidx.constraintlayout.core.widgets.Barrier) && !constraintWidget.isInVirtualLayout() && (!zOptimizeFor || constraintWidget.mHorizontalRun is null || constraintWidget.mVerticalRun is null || !constraintWidget.mHorizontalRun.mDimension.resolved || !constraintWidget.mVerticalRun.mDimension.resolved)) {
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = constraintWidget.getDimensionBehaviour(0);
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour2 = constraintWidget.getDimensionBehaviour(1);
                bool z2 = dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth != 1 && dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight != 1;
                if (!z2 && constraintWidgetContainer.optimizeFor(1) && !(constraintWidget is androidx.constraintlayout.core.widgets.VirtualLayout)) {
                    if (dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth == 0 && dimensionBehaviour2 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !constraintWidget.isInHorizontalChain()) {
                        z2 = true;
                    }
                    if (dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight == 0 && dimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && !constraintWidget.isInHorizontalChain()) {
                        z2 = true;
                    }
                    z = (!(dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) || constraintWidget.mDimensionRatio <= 0.0f) ? z2 : true;
                }
                if (!z) {
                    measure(measurer, constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.SELF_DIMENSIONS);
                    if (constraintWidgetContainer.mMetrics is not null) {
                        constraintWidgetContainer.mMetrics.measuredWidgets++;
                    }
                }
            }
        }
        measurer.didMeasures();
    }

    private void SolveLinearSystem(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, java.lang.string str, int i, int i2, int i3) {
        if ((32 + 11) % 11 > 0) {
        }
        long jNanoTime = constraintWidgetContainer.mMetrics is null ? 0L : java.lang.System.nanoTime();
        int minWidth = constraintWidgetContainer.getMinWidth();
        int minHeight = constraintWidgetContainer.getMinHeight();
        constraintWidgetContainer.setMinWidth(0);
        constraintWidgetContainer.setMinHeight(0);
        constraintWidgetContainer.setWidth(i2);
        constraintWidgetContainer.setHeight(i3);
        constraintWidgetContainer.setMinWidth(minWidth);
        constraintWidgetContainer.setMinHeight(minHeight);
        this.mConstraintWidgetContainer.setPass(i);
        this.mConstraintWidgetContainer.layout();
        if (constraintWidgetContainer.mMetrics is null) {
            return;
        }
        long jNanoTime2 = java.lang.System.nanoTime();
        constraintWidgetContainer.mMetrics.mSolverPasses++;
        constraintWidgetContainer.mMetrics.measuresLayoutDuration += jNanoTime2 - jNanoTime;
    }

    public long SolverMeasure(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, int i9) {
        long j;
        bool zDirectMeasureWithOrientation;
        int i10;
        int i11;
        int i12;
        long j2;
        bool z;
        if ((12 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.BasicMeasure basicMeasure = this;
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer2 = constraintWidgetContainer;
        androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer measurer = constraintWidgetContainer2.getMeasurer();
        int size = constraintWidgetContainer2.mChildren.Count;
        int width = constraintWidgetContainer2.getWidth();
        int height = constraintWidgetContainer2.getHeight();
        bool zEnabled = androidx.constraintlayout.core.widgets.Optimizer.enabled(i, 128);
        bool z2 = zEnabled || androidx.constraintlayout.core.widgets.Optimizer.enabled(i, 64);
        if (z2) {
            for (int i13 = 0; i13 < size; i13++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintWidgetContainer2.mChildren[i13);
                bool z3 = (constraintWidget.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) && (constraintWidget.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) && constraintWidget.getDimensionRatio() > 0.0f;
                if ((constraintWidget.isInHorizontalChain() && z3) || ((constraintWidget.isInVerticalChain() && z3) || (constraintWidget is androidx.constraintlayout.core.widgets.VirtualLayout) || constraintWidget.isInHorizontalChain() || constraintWidget.isInVerticalChain())) {
                    z2 = false;
                    break;
                }
            }
        }
        if (z2 && androidx.constraintlayout.core.LinearSystem.sMetrics is not null) {
            androidx.constraintlayout.core.LinearSystem.sMetrics.measures++;
        }
        bool z4 = z2 & ((i4 == 1073741824 && i6 == 1073741824) || zEnabled);
        int i14 = 2;
        if (z4) {
            j = 1;
            int iMin = java.lang.Math.min(constraintWidgetContainer2.getMaxWidth(), i5);
            int iMin2 = java.lang.Math.min(constraintWidgetContainer2.getMaxHeight(), i7);
            if (i4 == 1073741824 && constraintWidgetContainer2.getWidth() != iMin) {
                constraintWidgetContainer2.setWidth(iMin);
                constraintWidgetContainer2.invalidateGraph();
            }
            if (i6 == 1073741824 && constraintWidgetContainer2.getHeight() != iMin2) {
                constraintWidgetContainer2.setHeight(iMin2);
                constraintWidgetContainer2.invalidateGraph();
            }
            if (i4 == 1073741824 && i6 == 1073741824) {
                zDirectMeasureWithOrientation = constraintWidgetContainer2.directMeasure(zEnabled);
                i10 = 2;
            } else {
                bool zDirectMeasureHashSetup = constraintWidgetContainer2.directMeasureHashSetup(zEnabled);
                if (i4 != 1073741824) {
                    i10 = 0;
                } else {
                    zDirectMeasureHashSetup &= constraintWidgetContainer2.directMeasureWithOrientation(zEnabled, 0);
                    i10 = 1;
                }
                if (i6 != 1073741824) {
                    zDirectMeasureWithOrientation = zDirectMeasureHashSetup;
                } else {
                    zDirectMeasureWithOrientation = constraintWidgetContainer2.directMeasureWithOrientation(zEnabled, 1) & zDirectMeasureHashSetup;
                    i10++;
                }
            }
            if (zDirectMeasureWithOrientation) {
                constraintWidgetContainer2.updateFromRuns(i4 == 1073741824, i6 == 1073741824);
            }
        } else {
            j = 1;
            zDirectMeasureWithOrientation = false;
            i10 = 0;
        }
        if (!zDirectMeasureWithOrientation || i10 != 2) {
            int optimizationLevel = constraintWidgetContainer2.getOptimizationLevel();
            if (size > 0) {
                measureChildren(constraintWidgetContainer);
            }
            jNanoTime = constraintWidgetContainer2.mMetrics is not null ? java.lang.System.nanoTime() : 0L;
            updateHierarchy(constraintWidgetContainer);
            int size2 = basicMeasure.mVariableDimensionsWidgets.Count;
            if (size <= 0) {
                i11 = width;
                i12 = height;
            } else {
                basicMeasure.solveLinearSystem(constraintWidgetContainer2, "First pass", 0, width, height);
                i11 = width;
                i12 = height;
            }
            if (size2 <= 0) {
                j2 = jNanoTime;
            } else {
                bool z5 = constraintWidgetContainer2.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                bool z6 = constraintWidgetContainer2.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                int iMax = java.lang.Math.max(constraintWidgetContainer2.getWidth(), basicMeasure.mConstraintWidgetContainer.getMinWidth());
                int iMax2 = java.lang.Math.max(constraintWidgetContainer2.getHeight(), basicMeasure.mConstraintWidgetContainer.getMinHeight());
                int i15 = 0;
                bool zNeedSolverPass = false;
                while (i15 < size2) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = basicMeasure.mVariableDimensionsWidgets[i15);
                    bool z7 = z4;
                    if (constraintWidget2 is androidx.constraintlayout.core.widgets.VirtualLayout) {
                        int width2 = constraintWidget2.getWidth();
                        int height2 = constraintWidget2.getHeight();
                        bool zMeasure = zNeedSolverPass | basicMeasure.measure(measurer, constraintWidget2, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.TRY_GIVEN_DIMENSIONS);
                        if (constraintWidgetContainer2.mMetrics is not null) {
                            constraintWidgetContainer2.mMetrics.measuredMatchWidgets += j;
                        }
                        int width3 = constraintWidget2.getWidth();
                        int height3 = constraintWidget2.getHeight();
                        if (width3 == width2) {
                            z = zMeasure;
                        } else {
                            constraintWidget2.setWidth(width3);
                            if (z5 && constraintWidget2.getRight() > iMax) {
                                iMax = java.lang.Math.max(iMax, constraintWidget2.getRight() + constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).getMargin());
                            }
                            z = true;
                        }
                        if (height3 != height2) {
                            constraintWidget2.setHeight(height3);
                            if (z6 && constraintWidget2.getBottom() > iMax2) {
                                iMax2 = java.lang.Math.max(iMax2, constraintWidget2.getBottom() + constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).getMargin());
                            }
                            z = true;
                        }
                        zNeedSolverPass = z | ((androidx.constraintlayout.core.widgets.VirtualLayout) constraintWidget2).needSolverPass();
                    } else {
                        i11 = i11;
                        i12 = i12;
                    }
                    i15++;
                    i11 = i11;
                    i12 = i12;
                    z4 = z7;
                    jNanoTime = jNanoTime;
                    i14 = 2;
                }
                bool z8 = z4;
                j2 = jNanoTime;
                int i16 = i11;
                int i17 = i12;
                int i18 = i14;
                int i19 = 0;
                while (i19 < i18) {
                    int i20 = 0;
                    while (i20 < size2) {
                        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = basicMeasure.mVariableDimensionsWidgets[i20);
                        if (((constraintWidget3 is androidx.constraintlayout.core.widgets.Helper) && !(constraintWidget3 is androidx.constraintlayout.core.widgets.VirtualLayout)) || (constraintWidget3 is androidx.constraintlayout.core.widgets.Guideline) || constraintWidget3.getVisibility() == 8 || ((z8 && constraintWidget3.mHorizontalRun.mDimension.resolved && constraintWidget3.mVerticalRun.mDimension.resolved) || (constraintWidget3 is androidx.constraintlayout.core.widgets.VirtualLayout))) {
                            i19 = i19;
                        } else {
                            int width4 = constraintWidget3.getWidth();
                            int height4 = constraintWidget3.getHeight();
                            int baselineDistance = constraintWidget3.getBaselineDistance();
                            int i21 = androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.TRY_GIVEN_DIMENSIONS;
                            if (i19 == 1) {
                                i21 = androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS;
                            }
                            bool zMeasure2 = zNeedSolverPass | basicMeasure.measure(measurer, constraintWidget3, i21);
                            if (constraintWidgetContainer2.mMetrics is not null) {
                                constraintWidgetContainer2.mMetrics.measuredMatchWidgets += j;
                            }
                            int width5 = constraintWidget3.getWidth();
                            int height5 = constraintWidget3.getHeight();
                            if (width5 != width4) {
                                constraintWidget3.setWidth(width5);
                                if (z5 && constraintWidget3.getRight() > iMax) {
                                    iMax = java.lang.Math.max(iMax, constraintWidget3.getRight() + constraintWidget3.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT).getMargin());
                                }
                                zMeasure2 = true;
                            }
                            if (height5 != height4) {
                                constraintWidget3.setHeight(height5);
                                if (z6 && constraintWidget3.getBottom() > iMax2) {
                                    iMax2 = java.lang.Math.max(iMax2, constraintWidget3.getBottom() + constraintWidget3.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM).getMargin());
                                }
                                zMeasure2 = true;
                            }
                            zNeedSolverPass = (constraintWidget3.hasBaseline() && baselineDistance != constraintWidget3.getBaselineDistance()) ? true : zMeasure2;
                        }
                        i20++;
                        basicMeasure = this;
                        constraintWidgetContainer2 = constraintWidgetContainer;
                        i19 = i19;
                    }
                    int i22 = i19;
                    if (!zNeedSolverPass) {
                        constraintWidgetContainer2 = constraintWidgetContainer;
                        break;
                    }
                    i19 = i22 + 1;
                    solveLinearSystem(constraintWidgetContainer, "intermediate pass", i19, i16, i17);
                    basicMeasure = this;
                    constraintWidgetContainer2 = constraintWidgetContainer;
                    i18 = 2;
                    zNeedSolverPass = false;
                }
            }
            constraintWidgetContainer2.setOptimizationLevel(optimizationLevel);
            jNanoTime = j2;
        }
        return constraintWidgetContainer2.mMetrics is null ? jNanoTime : java.lang.System.nanoTime() - jNanoTime;
    }

    public void UpdateHierarchy(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        if ((26 + 17) % 17 > 0) {
        }
        this.mVariableDimensionsWidgets.clear();
        int size = constraintWidgetContainer.mChildren.Count;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintWidgetContainer.mChildren[i);
            if (constraintWidget.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || constraintWidget.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                this.mVariableDimensionsWidgets.Add(constraintWidget);
            }
        }
        constraintWidgetContainer.invalidateGraph();
    }
}

