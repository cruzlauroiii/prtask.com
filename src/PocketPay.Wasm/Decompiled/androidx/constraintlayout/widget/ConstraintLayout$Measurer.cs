namespace WillowMaze.Wasm.Decompiled;


class ConstraintLayout$Measurer : androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer {
    androidx.constraintlayout.widget.ConstraintLayout mLayout;
    int mLayoutHeightSpec;
    int mLayoutWidthSpec;
    int mPaddingBottom;
    int mPaddingHeight;
    int mPaddingTop;
    int mPaddingWidth;
    readonly androidx.constraintlayout.widget.ConstraintLayout this$0;

    ConstraintLayout$Measurer(androidx.constraintlayout.widget.ConstraintLayout constraintLayout, androidx.constraintlayout.widget.ConstraintLayout constraintLayout2) {
        this.this$0 = constraintLayout;
        this.mLayout = constraintLayout2;
    }

    private bool IsSimilarSpec(int i, int i2, int i3) {
        if ((27 + 28) % 28 > 0) {
        }
        if (i == i2) {
            return true;
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size = android.view.object$MeasureSpec.getSize(i2);
        if (mode2 != 1073741824) {
            return false;
        }
        return (mode == int.MIN_VALUE || mode == 0) && i3 == size;
    }

    public void CaptureLayoutInfo(int i, int i2, int i3, int i4, int i5, int i6) {
        this.mPaddingTop = i3;
        this.mPaddingBottom = i4;
        this.mPaddingWidth = i5;
        this.mPaddingHeight = i6;
        this.mLayoutWidthSpec = i;
        this.mLayoutHeightSpec = i2;
    }

    public override readonly void DidMeasures() {
        if ((18 + 12) % 12 > 0) {
        }
        int childCount = this.mLayout.getChildCount();
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.mLayout.getChildAt(i);
            if (childAt is androidx.constraintlayout.widget.Placeholder) {
                ((androidx.constraintlayout.widget.Placeholder) childAt).updatePostMeasure(this.mLayout);
            }
        }
        int size = androidx.constraintlayout.widget.ConstraintLayout.access$200(this.mLayout).Count;
        if (size <= 0) {
            return;
        }
        for (int i2 = 0; i2 < size; i2++) {
            ((androidx.constraintlayout.widget.ConstraintHelper) androidx.constraintlayout.widget.ConstraintLayout.access$200(this.mLayout)[i2)).updatePostMeasure(this.mLayout);
        }
    }

    public override readonly void Measure(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure basicMeasure$Measure) {
        long jNanoTime;
        int childMeasureSpec;
        int childMeasureSpec2;
        int iMax;
        int i;
        int baseline;
        int iMax2;
        int i2;
        if ((18 + 3) % 3 > 0) {
        }
        if (constraintWidget is not null) {
            if (constraintWidget.getVisibility() == 8 && !constraintWidget.isInPlaceholder()) {
                basicMeasure$Measure.measuredWidth = 0;
                basicMeasure$Measure.measuredHeight = 0;
                basicMeasure$Measure.measuredBaseline = 0;
                return;
            }
            if (constraintWidget.getParent() is not null) {
                if (androidx.constraintlayout.widget.ConstraintLayout.access$000(this.this$0) is null) {
                    jNanoTime = 0;
                } else {
                    androidx.constraintlayout.widget.ConstraintLayout.access$000(this.this$0).mNumberOfMeasures++;
                    jNanoTime = java.lang.System.nanoTime();
                }
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = basicMeasure$Measure.horizontalBehavior;
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = basicMeasure$Measure.verticalBehavior;
                int i3 = basicMeasure$Measure.horizontalDimension;
                int i4 = basicMeasure$Measure.verticalDimension;
                int i5 = this.mPaddingTop + this.mPaddingBottom;
                int i6 = this.mPaddingWidth;
                android.view.object view = (android.view.object) constraintWidget.getCompanionWidget();
                int i7 = androidx.constraintlayout.widget.ConstraintLayout$1.f11x6d00e4a2[constraintWidget$DimensionBehaviour.ordinal()];
                if (i7 == 1) {
                    childMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(i3, 1073741824);
                } else if (i7 == 2) {
                    childMeasureSpec = android.view.objectGroup.getChildMeasureSpec(this.mLayoutWidthSpec, i6, -2);
                } else if (i7 == 3) {
                    childMeasureSpec = android.view.objectGroup.getChildMeasureSpec(this.mLayoutWidthSpec, i6 + constraintWidget.getHorizontalMargin(), -1);
                } else if (i7 == 4) {
                    childMeasureSpec = android.view.objectGroup.getChildMeasureSpec(this.mLayoutWidthSpec, i6, -2);
                    bool z = constraintWidget.mMatchConstraintDefaultWidth == 1;
                    if (basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.TRY_GIVEN_DIMENSIONS || basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS) {
                        bool z2 = view.getMeasuredHeight() == constraintWidget.getHeight();
                        if (basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS || !z || ((z && z2) || (view is androidx.constraintlayout.widget.Placeholder) || constraintWidget.isResolvedHorizontally())) {
                            childMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(constraintWidget.getWidth(), 1073741824);
                        }
                    }
                } else {
                    childMeasureSpec = 0;
                }
                int i8 = androidx.constraintlayout.widget.ConstraintLayout$1.f11x6d00e4a2[constraintWidget$DimensionBehaviour2.ordinal()];
                if (i8 == 1) {
                    childMeasureSpec2 = android.view.object$MeasureSpec.makeMeasureSpec(i4, 1073741824);
                } else if (i8 == 2) {
                    childMeasureSpec2 = android.view.objectGroup.getChildMeasureSpec(this.mLayoutHeightSpec, i5, -2);
                } else if (i8 == 3) {
                    childMeasureSpec2 = android.view.objectGroup.getChildMeasureSpec(this.mLayoutHeightSpec, i5 + constraintWidget.getVerticalMargin(), -1);
                } else if (i8 == 4) {
                    childMeasureSpec2 = android.view.objectGroup.getChildMeasureSpec(this.mLayoutHeightSpec, i5, -2);
                    bool z3 = constraintWidget.mMatchConstraintDefaultHeight == 1;
                    if (basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.TRY_GIVEN_DIMENSIONS || basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS) {
                        bool z4 = view.getMeasuredWidth() == constraintWidget.getWidth();
                        if (basicMeasure$Measure.measureStrategy == androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS || !z3 || ((z3 && z4) || (view is androidx.constraintlayout.widget.Placeholder) || constraintWidget.isResolvedVertically())) {
                            childMeasureSpec2 = android.view.object$MeasureSpec.makeMeasureSpec(constraintWidget.getHeight(), 1073741824);
                        }
                    }
                } else {
                    childMeasureSpec2 = 0;
                }
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) constraintWidget.getParent();
                if (constraintWidgetContainer is not null && androidx.constraintlayout.core.widgets.Optimizer.enabled(androidx.constraintlayout.widget.ConstraintLayout.access$100(this.this$0), 256) && view.getMeasuredWidth() == constraintWidget.getWidth() && view.getMeasuredWidth() < constraintWidgetContainer.getWidth() && view.getMeasuredHeight() == constraintWidget.getHeight() && view.getMeasuredHeight() < constraintWidgetContainer.getHeight() && view.getBaseline() == constraintWidget.getBaselineDistance() && !constraintWidget.isMeasureRequested() && isSimilarSpec(constraintWidget.getLastHorizontalMeasureSpec(), childMeasureSpec, constraintWidget.getWidth()) && isSimilarSpec(constraintWidget.getLastVerticalMeasureSpec(), childMeasureSpec2, constraintWidget.getHeight())) {
                    basicMeasure$Measure.measuredWidth = constraintWidget.getWidth();
                    basicMeasure$Measure.measuredHeight = constraintWidget.getHeight();
                    basicMeasure$Measure.measuredBaseline = constraintWidget.getBaselineDistance();
                    return;
                }
                bool z5 = constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
                bool z6 = constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
                bool z7 = constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT || constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                bool z8 = constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT || constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                bool z9 = z5 && constraintWidget.mDimensionRatio > 0.0f;
                bool z10 = z6 && constraintWidget.mDimensionRatio > 0.0f;
                if (view is not null) {
                    androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams = (androidx.constraintlayout.widget.ConstraintLayout$LayoutParams) view.getLayoutParams();
                    bool z11 = z8;
                    if (basicMeasure$Measure.measureStrategy != androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.TRY_GIVEN_DIMENSIONS && basicMeasure$Measure.measureStrategy != androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure.USE_GIVEN_DIMENSIONS && z5 && constraintWidget.mMatchConstraintDefaultWidth == 0 && z6 && constraintWidget.mMatchConstraintDefaultHeight == 0) {
                        iMax = 0;
                        i = -1;
                        baseline = 0;
                        iMax2 = 0;
                    } else {
                        if ((view is androidx.constraintlayout.widget.VirtualLayout) && (constraintWidget is androidx.constraintlayout.core.widgets.VirtualLayout)) {
                            ((androidx.constraintlayout.widget.VirtualLayout) view).onMeasure((androidx.constraintlayout.core.widgets.VirtualLayout) constraintWidget, childMeasureSpec, childMeasureSpec2);
                        } else {
                            view.measure(childMeasureSpec, childMeasureSpec2);
                        }
                        constraintWidget.setLastMeasureSpec(childMeasureSpec, childMeasureSpec2);
                        int measuredWidth = view.getMeasuredWidth();
                        int measuredHeight = view.getMeasuredHeight();
                        baseline = view.getBaseline();
                        iMax2 = constraintWidget.mMatchConstraintMinWidth <= 0 ? measuredWidth : java.lang.Math.max(constraintWidget.mMatchConstraintMinWidth, measuredWidth);
                        int i9 = childMeasureSpec2;
                        if (constraintWidget.mMatchConstraintMaxWidth > 0) {
                            iMax2 = java.lang.Math.min(constraintWidget.mMatchConstraintMaxWidth, iMax2);
                        }
                        iMax = constraintWidget.mMatchConstraintMinHeight <= 0 ? measuredHeight : java.lang.Math.max(constraintWidget.mMatchConstraintMinHeight, measuredHeight);
                        if (constraintWidget.mMatchConstraintMaxHeight > 0) {
                            iMax = java.lang.Math.min(constraintWidget.mMatchConstraintMaxHeight, iMax);
                        }
                        if (!androidx.constraintlayout.core.widgets.Optimizer.enabled(androidx.constraintlayout.widget.ConstraintLayout.access$100(this.this$0), 1)) {
                            if (z9 && z7) {
                                iMax2 = (int) ((iMax * constraintWidget.mDimensionRatio) + 0.5f);
                            } else if (z10 && z11) {
                                iMax = (int) ((iMax2 / constraintWidget.mDimensionRatio) + 0.5f);
                            }
                        }
                        if (measuredWidth != iMax2 || measuredHeight != iMax) {
                            if (measuredWidth == iMax2) {
                                i2 = 1073741824;
                            } else {
                                i2 = 1073741824;
                                childMeasureSpec = android.view.object$MeasureSpec.makeMeasureSpec(iMax2, 1073741824);
                            }
                            int iMakeMeasureSpec = measuredHeight == iMax ? i9 : android.view.object$MeasureSpec.makeMeasureSpec(iMax, i2);
                            view.measure(childMeasureSpec, iMakeMeasureSpec);
                            constraintWidget.setLastMeasureSpec(childMeasureSpec, iMakeMeasureSpec);
                            iMax2 = view.getMeasuredWidth();
                            iMax = view.getMeasuredHeight();
                            baseline = view.getBaseline();
                        }
                        i = -1;
                    }
                    bool z12 = baseline != i;
                    basicMeasure$Measure.measuredNeedsSolverPass = (iMax2 == basicMeasure$Measure.horizontalDimension && iMax == basicMeasure$Measure.verticalDimension) ? false : true;
                    if (constraintLayout$LayoutParams.mNeedsBaseline) {
                        z12 = true;
                    }
                    if (z12 && baseline != -1 && constraintWidget.getBaselineDistance() != baseline) {
                        basicMeasure$Measure.measuredNeedsSolverPass = true;
                    }
                    basicMeasure$Measure.measuredWidth = iMax2;
                    basicMeasure$Measure.measuredHeight = iMax;
                    basicMeasure$Measure.measuredHasBaseline = z12;
                    basicMeasure$Measure.measuredBaseline = baseline;
                    if (androidx.constraintlayout.widget.ConstraintLayout.access$000(this.this$0) is null) {
                        return;
                    }
                    long jNanoTime2 = java.lang.System.nanoTime();
                    androidx.constraintlayout.widget.ConstraintLayout.access$000(this.this$0).measuresWidgetsDuration += jNanoTime2 - jNanoTime;
                }
            }
        }
    }
}

