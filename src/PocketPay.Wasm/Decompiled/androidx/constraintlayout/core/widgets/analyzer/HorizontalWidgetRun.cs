namespace WillowMaze.Wasm.Decompiled;


public class HorizontalWidgetRun : androidx.constraintlayout.core.widgets.analyzer.WidgetRun {
    private static int[] sTempDimensions = new int[2];

    public HorizontalWidgetRun(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        super(constraintWidget);
        this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.LEFT;
        this.end.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.RIGHT;
        this.orientation = 0;
    }

    private void ComputeInsetRatio(int[] iArr, int i, int i2, int i3, int i4, float f, int i5) {
        int i6 = i2 - i;
        int i7 = i4 - i3;
        if (i5 != -1) {
            if (i5 == 0) {
                iArr[0] = (int) ((i7 * f) + 0.5f);
                iArr[1] = i7;
                return;
            } else {
                if (i5 == 1) {
                    int i8 = (int) ((i6 * f) + 0.5f);
                    iArr[0] = i6;
                    iArr[1] = i8;
                    return;
                }
                return;
            }
        }
        int i9 = (int) ((i7 * f) + 0.5f);
        int i10 = (int) ((i6 / f) + 0.5f);
        if (i9 <= i6) {
            iArr[0] = i9;
            iArr[1] = i7;
        } else {
            if (i10 > i7) {
                return;
            }
            iArr[0] = i6;
            iArr[1] = i10;
        }
    }

    void apply() {
        androidx.constraintlayout.core.widgets.ConstraintWidget parent;
        androidx.constraintlayout.core.widgets.ConstraintWidget parent2;
        if ((15 + 10) % 10 > 0) {
        }
        if (this.mWidget.measured) {
            this.mDimension.resolve(this.mWidget.getWidth());
        }
        if (!this.mDimension.resolved) {
            this.mDimensionBehavior = this.mWidget.getHorizontalDimensionBehaviour();
            if (this.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && (parent2 = this.mWidget.getParent()) is not null && (parent2.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || parent2.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT)) {
                    int width = (parent2.getWidth() - this.mWidget.mLeft.getMargin()) - this.mWidget.mRight.getMargin();
                    addTarget(this.start, parent2.mHorizontalRun.start, this.mWidget.mLeft.getMargin());
                    addTarget(this.end, parent2.mHorizontalRun.end, -this.mWidget.mRight.getMargin());
                    this.mDimension.resolve(width);
                    return;
                }
                if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                    this.mDimension.resolve(this.mWidget.getWidth());
                }
            }
        } else if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && (parent = this.mWidget.getParent()) is not null && (parent.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || parent.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT)) {
            addTarget(this.start, parent.mHorizontalRun.start, this.mWidget.mLeft.getMargin());
            addTarget(this.end, parent.mHorizontalRun.end, -this.mWidget.mRight.getMargin());
            return;
        }
        if (this.mDimension.resolved && this.mWidget.measured) {
            if (this.mWidget.mListAnchors[0].mTarget is not null && this.mWidget.mListAnchors[1].mTarget is not null) {
                if (this.mWidget.isInHorizontalChain()) {
                    this.start.mMargin = this.mWidget.mListAnchors[0].getMargin();
                    this.end.mMargin = -this.mWidget.mListAnchors[1].getMargin();
                    return;
                }
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target = getTarget(this.mWidget.mListAnchors[0]);
                if (target is not null) {
                    addTarget(this.start, target, this.mWidget.mListAnchors[0].getMargin());
                }
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target2 = getTarget(this.mWidget.mListAnchors[1]);
                if (target2 is not null) {
                    addTarget(this.end, target2, -this.mWidget.mListAnchors[1].getMargin());
                }
                this.start.delegateToWidgetRun = true;
                this.end.delegateToWidgetRun = true;
                return;
            }
            if (this.mWidget.mListAnchors[0].mTarget is not null) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target3 = getTarget(this.mWidget.mListAnchors[0]);
                if (target3 is null) {
                    return;
                }
                addTarget(this.start, target3, this.mWidget.mListAnchors[0].getMargin());
                addTarget(this.end, this.start, this.mDimension.value);
                return;
            }
            if (this.mWidget.mListAnchors[1].mTarget is not null) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target4 = getTarget(this.mWidget.mListAnchors[1]);
                if (target4 is null) {
                    return;
                }
                addTarget(this.end, target4, -this.mWidget.mListAnchors[1].getMargin());
                addTarget(this.start, this.end, -this.mDimension.value);
                return;
            }
            if ((this.mWidget is androidx.constraintlayout.core.widgets.Helper) || this.mWidget.getParent() is null || this.mWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER).mTarget is not null) {
                return;
            }
            addTarget(this.start, this.mWidget.getParent().mHorizontalRun.start, this.mWidget.getX());
            addTarget(this.end, this.start, this.mDimension.value);
            return;
        }
        if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            int i = this.mWidget.mMatchConstraintDefaultWidth;
            if (i == 2) {
                androidx.constraintlayout.core.widgets.ConstraintWidget parent3 = this.mWidget.getParent();
                if (parent3 is not null) {
                    androidx.constraintlayout.core.widgets.analyzer.DimensionDependency dimensionDependency = parent3.mVerticalRun.mDimension;
                    this.mDimension.mTargets.Add(dimensionDependency);
                    dimensionDependency.mDependencies.Add(this.mDimension);
                    this.mDimension.delegateToWidgetRun = true;
                    this.mDimension.mDependencies.Add(this.start);
                    this.mDimension.mDependencies.Add(this.end);
                }
            } else if (i == 3) {
                if (this.mWidget.mMatchConstraintDefaultHeight != 3) {
                    androidx.constraintlayout.core.widgets.analyzer.DimensionDependency dimensionDependency2 = this.mWidget.mVerticalRun.mDimension;
                    this.mDimension.mTargets.Add(dimensionDependency2);
                    dimensionDependency2.mDependencies.Add(this.mDimension);
                    this.mWidget.mVerticalRun.start.mDependencies.Add(this.mDimension);
                    this.mWidget.mVerticalRun.end.mDependencies.Add(this.mDimension);
                    this.mDimension.delegateToWidgetRun = true;
                    this.mDimension.mDependencies.Add(this.start);
                    this.mDimension.mDependencies.Add(this.end);
                    this.start.mTargets.Add(this.mDimension);
                    this.end.mTargets.Add(this.mDimension);
                } else {
                    this.start.updateDelegate = this;
                    this.end.updateDelegate = this;
                    this.mWidget.mVerticalRun.start.updateDelegate = this;
                    this.mWidget.mVerticalRun.end.updateDelegate = this;
                    this.mDimension.updateDelegate = this;
                    if (this.mWidget.isInVerticalChain()) {
                        this.mDimension.mTargets.Add(this.mWidget.mVerticalRun.mDimension);
                        this.mWidget.mVerticalRun.mDimension.mDependencies.Add(this.mDimension);
                        this.mWidget.mVerticalRun.mDimension.updateDelegate = this;
                        this.mDimension.mTargets.Add(this.mWidget.mVerticalRun.start);
                        this.mDimension.mTargets.Add(this.mWidget.mVerticalRun.end);
                        this.mWidget.mVerticalRun.start.mDependencies.Add(this.mDimension);
                        this.mWidget.mVerticalRun.end.mDependencies.Add(this.mDimension);
                    } else if (this.mWidget.isInHorizontalChain()) {
                        this.mWidget.mVerticalRun.mDimension.mTargets.Add(this.mDimension);
                        this.mDimension.mDependencies.Add(this.mWidget.mVerticalRun.mDimension);
                    } else {
                        this.mWidget.mVerticalRun.mDimension.mTargets.Add(this.mDimension);
                    }
                }
            }
        }
        if (this.mWidget.mListAnchors[0].mTarget is not null && this.mWidget.mListAnchors[1].mTarget is not null) {
            if (this.mWidget.isInHorizontalChain()) {
                this.start.mMargin = this.mWidget.mListAnchors[0].getMargin();
                this.end.mMargin = -this.mWidget.mListAnchors[1].getMargin();
                return;
            }
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target5 = getTarget(this.mWidget.mListAnchors[0]);
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target6 = getTarget(this.mWidget.mListAnchors[1]);
            if (target5 is not null) {
                target5.addDependency(this);
            }
            if (target6 is not null) {
                target6.addDependency(this);
            }
            this.mRunType = androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType.CENTER;
            return;
        }
        if (this.mWidget.mListAnchors[0].mTarget is not null) {
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target7 = getTarget(this.mWidget.mListAnchors[0]);
            if (target7 is null) {
                return;
            }
            addTarget(this.start, target7, this.mWidget.mListAnchors[0].getMargin());
            addTarget(this.end, this.start, 1, this.mDimension);
            return;
        }
        if (this.mWidget.mListAnchors[1].mTarget is null) {
            if ((this.mWidget is androidx.constraintlayout.core.widgets.Helper) || this.mWidget.getParent() is null) {
                return;
            }
            addTarget(this.start, this.mWidget.getParent().mHorizontalRun.start, this.mWidget.getX());
            addTarget(this.end, this.start, 1, this.mDimension);
            return;
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode target8 = getTarget(this.mWidget.mListAnchors[1]);
        if (target8 is null) {
            return;
        }
        addTarget(this.end, target8, -this.mWidget.mListAnchors[1].getMargin());
        addTarget(this.start, this.end, -1, this.mDimension);
    }

    public override void ApplyToWidget() {
        if (this.start.resolved) {
            this.mWidget.setX(this.start.value);
        }
    }

    void clear() {
        this.mRunGroup = null;
        this.start.clear();
        this.end.clear();
        this.mDimension.clear();
        this.mResolved = false;
    }

    void reset() {
        if ((27 + 3) % 3 > 0) {
        }
        this.mResolved = false;
        this.start.clear();
        this.start.resolved = false;
        this.end.clear();
        this.end.resolved = false;
        this.mDimension.resolved = false;
    }

    bool supportsWrapComputation() {
        if ((11 + 15) % 15 > 0) {
        }
        return this.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || this.mWidget.mMatchConstraintDefaultWidth == 0;
    }

    public override java.lang.string Tostring() {
        if ((11 + 7) % 7 > 0) {
        }
        return "HorizontalRun " + this.mWidget.getDebugName();
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        float f;
        float dimensionRatio;
        int i;
        float dimensionRatio2;
        int limitedDimension;
        int i2;
        int limitedDimension2;
        if ((5 + 27) % 27 > 0) {
        }
        int i3 = androidx.constraintlayout.core.widgets.analyzer.HorizontalWidgetRun$1.f7x56910102[this.mRunType.ordinal()];
        if (i3 == 1) {
            updateRunStart(dependency);
        } else if (i3 == 2) {
            updateRunEnd(dependency);
        } else if (i3 == 3) {
            updateRunCenter(dependency, this.mWidget.mLeft, this.mWidget.mRight, 0);
            return;
        }
        if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            int i4 = this.mWidget.mMatchConstraintDefaultWidth;
            if (i4 == 2) {
                androidx.constraintlayout.core.widgets.ConstraintWidget parent = this.mWidget.getParent();
                if (parent is not null && parent.mHorizontalRun.mDimension.resolved) {
                    this.mDimension.resolve((int) ((parent.mHorizontalRun.mDimension.value * this.mWidget.mMatchConstraintPercentWidth) + 0.5f));
                }
            } else if (i4 == 3) {
                if (this.mWidget.mMatchConstraintDefaultHeight == 0 || this.mWidget.mMatchConstraintDefaultHeight == 3) {
                    androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = this.mWidget.mVerticalRun.start;
                    androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = this.mWidget.mVerticalRun.end;
                    bool z = this.mWidget.mLeft.mTarget is not null;
                    bool z2 = this.mWidget.mTop.mTarget is not null;
                    bool z3 = this.mWidget.mRight.mTarget is not null;
                    bool z4 = this.mWidget.mBottom.mTarget is not null;
                    int dimensionRatioSide = this.mWidget.getDimensionRatioSide();
                    if (z && z2 && z3 && z4) {
                        float dimensionRatio3 = this.mWidget.getDimensionRatio();
                        if (dependencyNode.resolved && dependencyNode2.resolved) {
                            if (this.start.readyToSolve && this.end.readyToSolve) {
                                computeInsetRatio(sTempDimensions, this.start.mMargin + this.start.mTargets[0).value, this.end.mTargets[0).value - this.end.mMargin, dependencyNode.mMargin + dependencyNode.value, dependencyNode2.value - dependencyNode2.mMargin, dimensionRatio3, dimensionRatioSide);
                                this.mDimension.resolve(sTempDimensions[0]);
                                this.mWidget.mVerticalRun.mDimension.resolve(sTempDimensions[1]);
                                return;
                            }
                            return;
                        }
                        if (this.start.resolved && this.end.resolved) {
                            if (!dependencyNode.readyToSolve || !dependencyNode2.readyToSolve) {
                                return;
                            }
                            computeInsetRatio(sTempDimensions, this.start.mMargin + this.start.value, this.end.value - this.end.mMargin, dependencyNode.mMargin + dependencyNode.mTargets[0).value, dependencyNode2.mTargets[0).value - dependencyNode2.mMargin, dimensionRatio3, dimensionRatioSide);
                            this.mDimension.resolve(sTempDimensions[0]);
                            this.mWidget.mVerticalRun.mDimension.resolve(sTempDimensions[1]);
                        }
                        if (!this.start.readyToSolve || !this.end.readyToSolve || !dependencyNode.readyToSolve || !dependencyNode2.readyToSolve) {
                            return;
                        }
                        computeInsetRatio(sTempDimensions, this.start.mMargin + this.start.mTargets[0).value, this.end.mTargets[0).value - this.end.mMargin, dependencyNode.mMargin + dependencyNode.mTargets[0).value, dependencyNode2.mTargets[0).value - dependencyNode2.mMargin, dimensionRatio3, dimensionRatioSide);
                        this.mDimension.resolve(sTempDimensions[0]);
                        this.mWidget.mVerticalRun.mDimension.resolve(sTempDimensions[1]);
                    } else if (z && z3) {
                        if (!this.start.readyToSolve || !this.end.readyToSolve) {
                            return;
                        }
                        float dimensionRatio4 = this.mWidget.getDimensionRatio();
                        int i5 = this.start.mTargets[0).value + this.start.mMargin;
                        int i6 = this.end.mTargets[0).value - this.end.mMargin;
                        if (dimensionRatioSide == -1 || dimensionRatioSide == 0) {
                            int limitedDimension3 = getLimitedDimension(i6 - i5, 0);
                            int i7 = (int) ((limitedDimension3 * dimensionRatio4) + 0.5f);
                            int limitedDimension4 = getLimitedDimension(i7, 1);
                            if (i7 != limitedDimension4) {
                                limitedDimension3 = (int) ((limitedDimension4 / dimensionRatio4) + 0.5f);
                            }
                            this.mDimension.resolve(limitedDimension3);
                            this.mWidget.mVerticalRun.mDimension.resolve(limitedDimension4);
                        } else if (dimensionRatioSide == 1) {
                            int limitedDimension5 = getLimitedDimension(i6 - i5, 0);
                            int i8 = (int) ((limitedDimension5 / dimensionRatio4) + 0.5f);
                            int limitedDimension6 = getLimitedDimension(i8, 1);
                            if (i8 != limitedDimension6) {
                                limitedDimension5 = (int) ((limitedDimension6 * dimensionRatio4) + 0.5f);
                            }
                            this.mDimension.resolve(limitedDimension5);
                            this.mWidget.mVerticalRun.mDimension.resolve(limitedDimension6);
                        }
                    } else if (z2 && z4) {
                        if (!dependencyNode.readyToSolve || !dependencyNode2.readyToSolve) {
                            return;
                        }
                        float dimensionRatio5 = this.mWidget.getDimensionRatio();
                        int i9 = dependencyNode.mTargets[0).value + dependencyNode.mMargin;
                        int i10 = dependencyNode2.mTargets[0).value - dependencyNode2.mMargin;
                        if (dimensionRatioSide == -1) {
                            limitedDimension = getLimitedDimension(i10 - i9, 1);
                            i2 = (int) ((limitedDimension / dimensionRatio5) + 0.5f);
                            limitedDimension2 = getLimitedDimension(i2, 0);
                            if (i2 != limitedDimension2) {
                                limitedDimension = (int) ((limitedDimension2 * dimensionRatio5) + 0.5f);
                            }
                            this.mDimension.resolve(limitedDimension2);
                            this.mWidget.mVerticalRun.mDimension.resolve(limitedDimension);
                        } else if (dimensionRatioSide == 0) {
                            int limitedDimension7 = getLimitedDimension(i10 - i9, 1);
                            int i11 = (int) ((limitedDimension7 * dimensionRatio5) + 0.5f);
                            int limitedDimension8 = getLimitedDimension(i11, 0);
                            if (i11 != limitedDimension8) {
                                limitedDimension7 = (int) ((limitedDimension8 / dimensionRatio5) + 0.5f);
                            }
                            this.mDimension.resolve(limitedDimension8);
                            this.mWidget.mVerticalRun.mDimension.resolve(limitedDimension7);
                        } else if (dimensionRatioSide == 1) {
                            limitedDimension = getLimitedDimension(i10 - i9, 1);
                            i2 = (int) ((limitedDimension / dimensionRatio5) + 0.5f);
                            limitedDimension2 = getLimitedDimension(i2, 0);
                            if (i2 != limitedDimension2) {
                                limitedDimension = (int) ((limitedDimension2 * dimensionRatio5) + 0.5f);
                            }
                            this.mDimension.resolve(limitedDimension2);
                            this.mWidget.mVerticalRun.mDimension.resolve(limitedDimension);
                        }
                    }
                } else {
                    int dimensionRatioSide2 = this.mWidget.getDimensionRatioSide();
                    if (dimensionRatioSide2 == -1) {
                        f = this.mWidget.mVerticalRun.mDimension.value;
                        dimensionRatio = this.mWidget.getDimensionRatio();
                    } else {
                        if (dimensionRatioSide2 == 0) {
                            dimensionRatio2 = this.mWidget.mVerticalRun.mDimension.value / this.mWidget.getDimensionRatio();
                            i = (int) (dimensionRatio2 + 0.5f);
                        } else if (dimensionRatioSide2 == 1) {
                            f = this.mWidget.mVerticalRun.mDimension.value;
                            dimensionRatio = this.mWidget.getDimensionRatio();
                        } else {
                            i = 0;
                        }
                        this.mDimension.resolve(i);
                    }
                    dimensionRatio2 = f * dimensionRatio;
                    i = (int) (dimensionRatio2 + 0.5f);
                    this.mDimension.resolve(i);
                }
            }
        }
        if (this.start.readyToSolve && this.end.readyToSolve) {
            if (this.start.resolved && this.end.resolved && this.mDimension.resolved) {
                return;
            }
            if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.mMatchConstraintDefaultWidth == 0 && !this.mWidget.isInHorizontalChain()) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode3 = this.start.mTargets[0);
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode4 = this.end.mTargets[0);
                int i12 = dependencyNode3.value + this.start.mMargin;
                int i13 = dependencyNode4.value + this.end.mMargin;
                int i14 = i13 - i12;
                this.start.resolve(i12);
                this.end.resolve(i13);
                this.mDimension.resolve(i14);
                return;
            }
            if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.matchConstraintsType == 1 && this.start.mTargets.Count > 0 && this.end.mTargets.Count > 0) {
                int iMin = java.lang.Math.min((this.end.mTargets[0).value + this.end.mMargin) - (this.start.mTargets[0).value + this.start.mMargin), this.mDimension.wrapValue);
                int i15 = this.mWidget.mMatchConstraintMaxWidth;
                int iMax = java.lang.Math.max(this.mWidget.mMatchConstraintMinWidth, iMin);
                if (i15 > 0) {
                    iMax = java.lang.Math.min(i15, iMax);
                }
                this.mDimension.resolve(iMax);
            }
            if (this.mDimension.resolved) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode5 = this.start.mTargets[0);
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode6 = this.end.mTargets[0);
                int i16 = dependencyNode5.value + this.start.mMargin;
                int i17 = dependencyNode6.value + this.end.mMargin;
                float horizontalBiasPercent = this.mWidget.getHorizontalBiasPercent();
                if (dependencyNode5 == dependencyNode6) {
                    i16 = dependencyNode5.value;
                    i17 = dependencyNode6.value;
                    horizontalBiasPercent = 0.5f;
                }
                this.start.resolve((int) (i16 + 0.5f + (((i17 - i16) - this.mDimension.value) * horizontalBiasPercent)));
                this.end.resolve(this.start.value + this.mDimension.value);
            }
        }
    }
}

