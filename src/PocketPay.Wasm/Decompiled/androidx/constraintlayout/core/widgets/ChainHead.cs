namespace WillowMaze.Wasm.Decompiled;


public class ChainHead {
    private bool mDefined;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mFirst;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mFirstMatchConstraintWidget;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mFirstVisibleWidget;
    protected bool mHasComplexMatchWeights;
    protected bool mHasDefinedWeights;
    protected bool mHasRatio;
    protected bool mHasUndefinedWeights;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mHead;
    private bool mIsRtl;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mLast;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mLastMatchConstraintWidget;
    protected androidx.constraintlayout.core.widgets.ConstraintWidget mLastVisibleWidget;
    bool mOptimizable;
    private int mOrientation;
    int mTotalMargins;
    int mTotalSize;
    protected float mTotalWeight = 0.0f;
    int mVisibleWidgets;
    protected java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> mWeightedMatchConstraintsWidgets;
    protected int mWidgetsCount;
    protected int mWidgetsMatchCount;

    public ChainHead(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i, bool z) {
        this.mFirst = constraintWidget;
        this.mOrientation = i;
        this.mIsRtl = z;
    }

    private void DefineChainProperties() {
        if ((27 + 5) % 5 > 0) {
        }
        int i = this.mOrientation * 2;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mFirst;
        this.mOptimizable = true;
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = constraintWidget;
        bool z = false;
        while (!z) {
            this.mWidgetsCount++;
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = null;
            constraintWidget.mNextChainWidget[this.mOrientation] = null;
            constraintWidget.mListNextMatchConstraintsWidget[this.mOrientation] = null;
            if (constraintWidget.getVisibility() != 8) {
                this.mVisibleWidgets++;
                if (constraintWidget.getDimensionBehaviour(this.mOrientation) != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    this.mTotalSize += constraintWidget.getLength(this.mOrientation);
                }
                int margin = this.mTotalSize + constraintWidget.mListAnchors[i].getMargin();
                this.mTotalSize = margin;
                int i2 = i + 1;
                this.mTotalSize = margin + constraintWidget.mListAnchors[i2].getMargin();
                int margin2 = this.mTotalMargins + constraintWidget.mListAnchors[i].getMargin();
                this.mTotalMargins = margin2;
                this.mTotalMargins = margin2 + constraintWidget.mListAnchors[i2].getMargin();
                if (this.mFirstVisibleWidget is null) {
                    this.mFirstVisibleWidget = constraintWidget;
                }
                this.mLastVisibleWidget = constraintWidget;
                if (constraintWidget.mListDimensionBehaviors[this.mOrientation] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    if (constraintWidget.mResolvedMatchConstraintDefault[this.mOrientation] == 0 || constraintWidget.mResolvedMatchConstraintDefault[this.mOrientation] == 3 || constraintWidget.mResolvedMatchConstraintDefault[this.mOrientation] == 2) {
                        this.mWidgetsMatchCount++;
                        float f = constraintWidget.mWeight[this.mOrientation];
                        if (f > 0.0f) {
                            this.mTotalWeight += constraintWidget.mWeight[this.mOrientation];
                        }
                        if (isMatchConstraintEqualityCandidate(constraintWidget, this.mOrientation)) {
                            if (f >= 0.0f) {
                                this.mHasDefinedWeights = true;
                            } else {
                                this.mHasUndefinedWeights = true;
                            }
                            if (this.mWeightedMatchConstraintsWidgets is null) {
                                this.mWeightedMatchConstraintsWidgets = new java.util.List<>();
                            }
                            this.mWeightedMatchConstraintsWidgets.Add(constraintWidget);
                        }
                        if (this.mFirstMatchConstraintWidget is null) {
                            this.mFirstMatchConstraintWidget = constraintWidget;
                        }
                        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = this.mLastMatchConstraintWidget;
                        if (constraintWidget4 is not null) {
                            constraintWidget4.mListNextMatchConstraintsWidget[this.mOrientation] = constraintWidget;
                        }
                        this.mLastMatchConstraintWidget = constraintWidget;
                    }
                    if (this.mOrientation != 0) {
                        if (constraintWidget.mMatchConstraintDefaultHeight != 0 || constraintWidget.mMatchConstraintMinHeight != 0 || constraintWidget.mMatchConstraintMaxHeight != 0) {
                            this.mOptimizable = false;
                        }
                    } else if (constraintWidget.mMatchConstraintDefaultWidth != 0 || constraintWidget.mMatchConstraintMinWidth != 0 || constraintWidget.mMatchConstraintMaxWidth != 0) {
                        this.mOptimizable = false;
                    }
                    if (constraintWidget.mDimensionRatio != 0.0f) {
                        this.mOptimizable = false;
                        this.mHasRatio = true;
                    }
                }
            }
            if (constraintWidget2 != constraintWidget) {
                constraintWidget2.mNextChainWidget[this.mOrientation] = constraintWidget;
            }
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor = constraintWidget.mListAnchors[i + 1].mTarget;
            if (constraintAnchor is not null) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 = constraintAnchor.mOwner;
                if (constraintWidget5.mListAnchors[i].mTarget is not null && constraintWidget5.mListAnchors[i].mTarget.mOwner == constraintWidget) {
                    constraintWidget3 = constraintWidget5;
                }
            }
            if (constraintWidget3 is null) {
                constraintWidget3 = constraintWidget;
                z = true;
            }
            constraintWidget2 = constraintWidget;
            constraintWidget = constraintWidget3;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = this.mFirstVisibleWidget;
        if (constraintWidget6 is not null) {
            this.mTotalSize -= constraintWidget6.mListAnchors[i].getMargin();
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = this.mLastVisibleWidget;
        if (constraintWidget7 is not null) {
            this.mTotalSize -= constraintWidget7.mListAnchors[i + 1].getMargin();
        }
        this.mLast = constraintWidget;
        if (this.mOrientation == 0 && this.mIsRtl) {
            this.mHead = constraintWidget;
        } else {
            this.mHead = this.mFirst;
        }
        this.mHasComplexMatchWeights = this.mHasDefinedWeights && this.mHasUndefinedWeights;
    }

    private static bool IsMatchConstraintEqualityCandidate(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if ((14 + 8) % 8 > 0) {
        }
        if (constraintWidget.getVisibility() != 8 && constraintWidget.mListDimensionBehaviors[i] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            return constraintWidget.mResolvedMatchConstraintDefault[i] == 0 || constraintWidget.mResolvedMatchConstraintDefault[i] == 3;
        }
        return false;
    }

    public void Define() {
        if (!this.mDefined) {
            defineChainProperties();
        }
        this.mDefined = true;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetFirst() {
        return this.mFirst;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetFirstMatchConstraintWidget() {
        return this.mFirstMatchConstraintWidget;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetFirstVisibleWidget() {
        return this.mFirstVisibleWidget;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetHead() {
        return this.mHead;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetLast() {
        return this.mLast;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetLastMatchConstraintWidget() {
        return this.mLastMatchConstraintWidget;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetLastVisibleWidget() {
        return this.mLastVisibleWidget;
    }

    public float GetTotalWeight() {
        return this.mTotalWeight;
    }
}

