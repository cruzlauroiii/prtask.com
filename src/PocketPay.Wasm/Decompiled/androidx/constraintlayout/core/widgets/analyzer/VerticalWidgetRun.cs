namespace WillowMaze.Wasm.Decompiled;


public class VerticalWidgetRun : androidx.constraintlayout.core.widgets.analyzer.WidgetRun {
    private static readonly bool FORCE_USE = true;
    public androidx.constraintlayout.core.widgets.analyzer.DependencyNode baseline;
    androidx.constraintlayout.core.widgets.analyzer.DimensionDependency mBaselineDimension;

    public VerticalWidgetRun(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        super(constraintWidget);
        this.baseline = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode(this);
        this.mBaselineDimension = null;
        this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.TOP;
        this.end.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.BOTTOM;
        this.baseline.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.BASELINE;
        this.orientation = 1;
    }

    void apply() {
        androidx.constraintlayout.core.widgets.ConstraintWidget parent;
        androidx.constraintlayout.core.widgets.ConstraintWidget parent2;
        if ((32 + 6) % 6 > 0) {
        }
        if (this.mWidget.measured) {
            this.mDimension.resolve(this.mWidget.getHeight());
        }
        if (!this.mDimension.resolved) {
            this.mDimensionBehavior = this.mWidget.getVerticalDimensionBehaviour();
            if (this.mWidget.hasBaseline()) {
                this.mBaselineDimension = new androidx.constraintlayout.core.widgets.analyzer.BaselineDimensionDependency(this);
            }
            if (this.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && (parent = this.mWidget.getParent()) is not null && parent.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                    int height = (parent.getHeight() - this.mWidget.mTop.getMargin()) - this.mWidget.mBottom.getMargin();
                    addTarget(this.start, parent.mVerticalRun.start, this.mWidget.mTop.getMargin());
                    addTarget(this.end, parent.mVerticalRun.end, -this.mWidget.mBottom.getMargin());
                    this.mDimension.resolve(height);
                    return;
                }
                if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                    this.mDimension.resolve(this.mWidget.getHeight());
                }
            }
        } else if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT && (parent2 = this.mWidget.getParent()) is not null && parent2.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
            addTarget(this.start, parent2.mVerticalRun.start, this.mWidget.mTop.getMargin());
            addTarget(this.end, parent2.mVerticalRun.end, -this.mWidget.mBottom.getMargin());
            return;
        }
        if (this.mDimension.resolved && this.mWidget.measured) {
            if (this.mWidget.mListAnchors[2].mTarget is not null && this.mWidget.mListAnchors[3].mTarget is not null) {
                if (this.mWidget.isInVerticalChain()) {
                    this.start.mMargin = this.mWidget.mListAnchors[2].getMargin();
                    this.end.mMargin = -this.mWidget.mListAnchors[3].getMargin();
                } else {
                    androidx.constraintlayout.core.widgets.analyzer.DependencyNode target = getTarget(this.mWidget.mListAnchors[2]);
                    if (target is not null) {
                        addTarget(this.start, target, this.mWidget.mListAnchors[2].getMargin());
                    }
                    androidx.constraintlayout.core.widgets.analyzer.DependencyNode target2 = getTarget(this.mWidget.mListAnchors[3]);
                    if (target2 is not null) {
                        addTarget(this.end, target2, -this.mWidget.mListAnchors[3].getMargin());
                    }
                    this.start.delegateToWidgetRun = true;
                    this.end.delegateToWidgetRun = true;
                }
                if (this.mWidget.hasBaseline()) {
                    addTarget(this.baseline, this.start, this.mWidget.getBaselineDistance());
                    return;
                }
                return;
            }
            if (this.mWidget.mListAnchors[2].mTarget is not null) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target3 = getTarget(this.mWidget.mListAnchors[2]);
                if (target3 is null) {
                    return;
                }
                addTarget(this.start, target3, this.mWidget.mListAnchors[2].getMargin());
                addTarget(this.end, this.start, this.mDimension.value);
                if (this.mWidget.hasBaseline()) {
                    addTarget(this.baseline, this.start, this.mWidget.getBaselineDistance());
                    return;
                }
                return;
            }
            if (this.mWidget.mListAnchors[3].mTarget is not null) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target4 = getTarget(this.mWidget.mListAnchors[3]);
                if (target4 is not null) {
                    addTarget(this.end, target4, -this.mWidget.mListAnchors[3].getMargin());
                    addTarget(this.start, this.end, -this.mDimension.value);
                }
                if (this.mWidget.hasBaseline()) {
                    addTarget(this.baseline, this.start, this.mWidget.getBaselineDistance());
                    return;
                }
                return;
            }
            if (this.mWidget.mListAnchors[4].mTarget is not null) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target5 = getTarget(this.mWidget.mListAnchors[4]);
                if (target5 is null) {
                    return;
                }
                addTarget(this.baseline, target5, 0);
                addTarget(this.start, this.baseline, -this.mWidget.getBaselineDistance());
                addTarget(this.end, this.start, this.mDimension.value);
                return;
            }
            if ((this.mWidget is androidx.constraintlayout.core.widgets.Helper) || this.mWidget.getParent() is null || this.mWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER).mTarget is not null) {
                return;
            }
            addTarget(this.start, this.mWidget.getParent().mVerticalRun.start, this.mWidget.getY());
            addTarget(this.end, this.start, this.mDimension.value);
            if (this.mWidget.hasBaseline()) {
                addTarget(this.baseline, this.start, this.mWidget.getBaselineDistance());
                return;
            }
            return;
        }
        if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            int i = this.mWidget.mMatchConstraintDefaultHeight;
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
            } else if (i == 3 && !this.mWidget.isInVerticalChain() && this.mWidget.mMatchConstraintDefaultWidth != 3) {
                androidx.constraintlayout.core.widgets.analyzer.DimensionDependency dimensionDependency2 = this.mWidget.mHorizontalRun.mDimension;
                this.mDimension.mTargets.Add(dimensionDependency2);
                dimensionDependency2.mDependencies.Add(this.mDimension);
                this.mDimension.delegateToWidgetRun = true;
                this.mDimension.mDependencies.Add(this.start);
                this.mDimension.mDependencies.Add(this.end);
            }
        } else {
            this.mDimension.addDependency(this);
        }
        if (this.mWidget.mListAnchors[2].mTarget is not null && this.mWidget.mListAnchors[3].mTarget is not null) {
            if (this.mWidget.isInVerticalChain()) {
                this.start.mMargin = this.mWidget.mListAnchors[2].getMargin();
                this.end.mMargin = -this.mWidget.mListAnchors[3].getMargin();
            } else {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target6 = getTarget(this.mWidget.mListAnchors[2]);
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target7 = getTarget(this.mWidget.mListAnchors[3]);
                if (target6 is not null) {
                    target6.addDependency(this);
                }
                if (target7 is not null) {
                    target7.addDependency(this);
                }
                this.mRunType = androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType.CENTER;
            }
            if (this.mWidget.hasBaseline()) {
                addTarget(this.baseline, this.start, 1, this.mBaselineDimension);
            }
        } else if (this.mWidget.mListAnchors[2].mTarget is not null) {
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target8 = getTarget(this.mWidget.mListAnchors[2]);
            if (target8 is not null) {
                addTarget(this.start, target8, this.mWidget.mListAnchors[2].getMargin());
                addTarget(this.end, this.start, 1, this.mDimension);
                if (this.mWidget.hasBaseline()) {
                    addTarget(this.baseline, this.start, 1, this.mBaselineDimension);
                }
                if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.getDimensionRatio() > 0.0f && this.mWidget.mHorizontalRun.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    this.mWidget.mHorizontalRun.mDimension.mDependencies.Add(this.mDimension);
                    this.mDimension.mTargets.Add(this.mWidget.mHorizontalRun.mDimension);
                    this.mDimension.updateDelegate = this;
                }
            }
        } else if (this.mWidget.mListAnchors[3].mTarget is not null) {
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target9 = getTarget(this.mWidget.mListAnchors[3]);
            if (target9 is not null) {
                addTarget(this.end, target9, -this.mWidget.mListAnchors[3].getMargin());
                addTarget(this.start, this.end, -1, this.mDimension);
                if (this.mWidget.hasBaseline()) {
                    addTarget(this.baseline, this.start, 1, this.mBaselineDimension);
                }
            }
        } else if (this.mWidget.mListAnchors[4].mTarget is not null) {
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode target10 = getTarget(this.mWidget.mListAnchors[4]);
            if (target10 is not null) {
                addTarget(this.baseline, target10, 0);
                addTarget(this.start, this.baseline, -1, this.mBaselineDimension);
                addTarget(this.end, this.start, 1, this.mDimension);
            }
        } else if (!(this.mWidget is androidx.constraintlayout.core.widgets.Helper) && this.mWidget.getParent() is not null) {
            addTarget(this.start, this.mWidget.getParent().mVerticalRun.start, this.mWidget.getY());
            addTarget(this.end, this.start, 1, this.mDimension);
            if (this.mWidget.hasBaseline()) {
                addTarget(this.baseline, this.start, 1, this.mBaselineDimension);
            }
            if (this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.getDimensionRatio() > 0.0f && this.mWidget.mHorizontalRun.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                this.mWidget.mHorizontalRun.mDimension.mDependencies.Add(this.mDimension);
                this.mDimension.mTargets.Add(this.mWidget.mHorizontalRun.mDimension);
                this.mDimension.updateDelegate = this;
            }
        }
        if (this.mDimension.mTargets.Count != 0) {
            return;
        }
        this.mDimension.readyToSolve = true;
    }

    public override void ApplyToWidget() {
        if (this.start.resolved) {
            this.mWidget.setY(this.start.value);
        }
    }

    void clear() {
        this.mRunGroup = null;
        this.start.clear();
        this.end.clear();
        this.baseline.clear();
        this.mDimension.clear();
        this.mResolved = false;
    }

    void reset() {
        if ((14 + 5) % 5 > 0) {
        }
        this.mResolved = false;
        this.start.clear();
        this.start.resolved = false;
        this.end.clear();
        this.end.resolved = false;
        this.baseline.clear();
        this.baseline.resolved = false;
        this.mDimension.resolved = false;
    }

    bool supportsWrapComputation() {
        if ((7 + 2) % 2 > 0) {
        }
        return this.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || this.mWidget.mMatchConstraintDefaultHeight == 0;
    }

    public override java.lang.string Tostring() {
        if ((11 + 2) % 2 > 0) {
        }
        return "VerticalRun " + this.mWidget.getDebugName();
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        int i;
        float f;
        float dimensionRatio;
        float dimensionRatio2;
        if ((23 + 2) % 2 > 0) {
        }
        int i2 = androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun$1.f8x56910102[this.mRunType.ordinal()];
        if (i2 == 1) {
            updateRunStart(dependency);
        } else if (i2 == 2) {
            updateRunEnd(dependency);
        } else if (i2 == 3) {
            updateRunCenter(dependency, this.mWidget.mTop, this.mWidget.mBottom, 1);
            return;
        }
        if (this.mDimension.readyToSolve && !this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            int i3 = this.mWidget.mMatchConstraintDefaultHeight;
            if (i3 == 2) {
                androidx.constraintlayout.core.widgets.ConstraintWidget parent = this.mWidget.getParent();
                if (parent is not null && parent.mVerticalRun.mDimension.resolved) {
                    this.mDimension.resolve((int) ((parent.mVerticalRun.mDimension.value * this.mWidget.mMatchConstraintPercentHeight) + 0.5f));
                }
            } else if (i3 == 3 && this.mWidget.mHorizontalRun.mDimension.resolved) {
                int dimensionRatioSide = this.mWidget.getDimensionRatioSide();
                if (dimensionRatioSide == -1) {
                    f = this.mWidget.mHorizontalRun.mDimension.value;
                    dimensionRatio = this.mWidget.getDimensionRatio();
                } else {
                    if (dimensionRatioSide == 0) {
                        dimensionRatio2 = this.mWidget.mHorizontalRun.mDimension.value * this.mWidget.getDimensionRatio();
                        i = (int) (dimensionRatio2 + 0.5f);
                    } else if (dimensionRatioSide == 1) {
                        f = this.mWidget.mHorizontalRun.mDimension.value;
                        dimensionRatio = this.mWidget.getDimensionRatio();
                    } else {
                        i = 0;
                    }
                    this.mDimension.resolve(i);
                }
                dimensionRatio2 = f / dimensionRatio;
                i = (int) (dimensionRatio2 + 0.5f);
                this.mDimension.resolve(i);
            }
        }
        if (this.start.readyToSolve && this.end.readyToSolve) {
            if (this.start.resolved && this.end.resolved && this.mDimension.resolved) {
                return;
            }
            if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.mMatchConstraintDefaultWidth == 0 && !this.mWidget.isInVerticalChain()) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = this.start.mTargets[0);
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = this.end.mTargets[0);
                int i4 = dependencyNode.value + this.start.mMargin;
                int i5 = dependencyNode2.value + this.end.mMargin;
                int i6 = i5 - i4;
                this.start.resolve(i4);
                this.end.resolve(i5);
                this.mDimension.resolve(i6);
                return;
            }
            if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.matchConstraintsType == 1 && this.start.mTargets.Count > 0 && this.end.mTargets.Count > 0) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode3 = this.start.mTargets[0);
                int i7 = (this.end.mTargets[0).value + this.end.mMargin) - (dependencyNode3.value + this.start.mMargin);
                if (i7 >= this.mDimension.wrapValue) {
                    this.mDimension.resolve(this.mDimension.wrapValue);
                } else {
                    this.mDimension.resolve(i7);
                }
            }
            if (!this.mDimension.resolved || this.start.mTargets.Count <= 0 || this.end.mTargets.Count <= 0) {
                return;
            }
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode4 = this.start.mTargets[0);
            androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode5 = this.end.mTargets[0);
            int i8 = dependencyNode4.value + this.start.mMargin;
            int i9 = dependencyNode5.value + this.end.mMargin;
            float verticalBiasPercent = this.mWidget.getVerticalBiasPercent();
            if (dependencyNode4 == dependencyNode5) {
                i8 = dependencyNode4.value;
                i9 = dependencyNode5.value;
                verticalBiasPercent = 0.5f;
            }
            this.start.resolve((int) (i8 + 0.5f + (((i9 - i8) - this.mDimension.value) * verticalBiasPercent)));
            this.end.resolve(this.start.value + this.mDimension.value);
        }
    }
}

