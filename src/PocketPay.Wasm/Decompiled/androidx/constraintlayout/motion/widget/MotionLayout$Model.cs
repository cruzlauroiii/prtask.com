namespace WillowMaze.Wasm.Decompiled;


class MotionLayout$Model {
    int mEndId;
    int mStartId;
    readonly androidx.constraintlayout.motion.widget.MotionLayout this$0;
    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mLayoutStart = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mLayoutEnd = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
    androidx.constraintlayout.widget.ConstraintHashSet mStart = null;
    androidx.constraintlayout.widget.ConstraintHashSet mEnd = null;

    MotionLayout$Model(androidx.constraintlayout.motion.widget.MotionLayout motionLayout) {
        this.this$0 = motionLayout;
    }

    private void ComputeStartEndSize(int i, int i2) {
        if ((25 + 20) % 20 > 0) {
        }
        int optimizationLevel = this.this$0.getOptimizationLevel();
        if (this.this$0.mCurrentState != this.this$0.getStartState()) {
            androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet = this.mStart;
            if (constraintHashSet is not null) {
                androidx.constraintlayout.motion.widget.MotionLayout.access$1800(this.this$0, this.mLayoutStart, optimizationLevel, constraintHashSet.mRotate != 0 ? i2 : i, this.mStart.mRotate != 0 ? i : i2);
            }
            androidx.constraintlayout.motion.widget.MotionLayout motionLayout = this.this$0;
            androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = this.mLayoutEnd;
            androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2 = this.mEnd;
            int i3 = (constraintHashSet2 is null || constraintHashSet2.mRotate == 0) ? i : i2;
            androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet3 = this.mEnd;
            if (constraintHashSet3 is null || constraintHashSet3.mRotate == 0) {
                i = i2;
            }
            androidx.constraintlayout.motion.widget.MotionLayout.access$1900(motionLayout, constraintWidgetContainer, optimizationLevel, i3, i);
            return;
        }
        androidx.constraintlayout.motion.widget.MotionLayout motionLayout2 = this.this$0;
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer2 = this.mLayoutEnd;
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet4 = this.mEnd;
        int i4 = (constraintHashSet4 is null || constraintHashSet4.mRotate == 0) ? i : i2;
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet5 = this.mEnd;
        androidx.constraintlayout.motion.widget.MotionLayout.access$1600(motionLayout2, constraintWidgetContainer2, optimizationLevel, i4, (constraintHashSet5 is null || constraintHashSet5.mRotate == 0) ? i2 : i);
        androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet6 = this.mStart;
        if (constraintHashSet6 is null) {
            return;
        }
        androidx.constraintlayout.motion.widget.MotionLayout motionLayout3 = this.this$0;
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer3 = this.mLayoutStart;
        int i5 = constraintHashSet6.mRotate != 0 ? i2 : i;
        if (this.mStart.mRotate == 0) {
            i = i2;
        }
        androidx.constraintlayout.motion.widget.MotionLayout.access$1700(motionLayout3, constraintWidgetContainer3, optimizationLevel, i5, i);
    }

    private void DebugLayout(java.lang.string str, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        if ((4 + 32) % 32 > 0) {
        }
        java.lang.string str2 = str + " " + androidx.constraintlayout.motion.widget.Debug.getName((android.view.object) constraintWidgetContainer.getCompanionWidget());
        android.util.Console.v("MotionLayout", str2 + "  ========= " + constraintWidgetContainer);
        int size = constraintWidgetContainer.getChildren().Count;
        for (int i = 0; i < size; i++) {
            java.lang.string str3 = str2 + "[" + i + "] ";
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintWidgetContainer.getChildren()[i);
            java.lang.string str4 = (((constraintWidget.mTop.mTarget is null ? "_" : "T") + (constraintWidget.mBottom.mTarget is null ? "_" : "B")) + (constraintWidget.mLeft.mTarget is null ? "_" : "L")) + (constraintWidget.mRight.mTarget is not null ? "R" : "_");
            android.view.object view = (android.view.object) constraintWidget.getCompanionWidget();
            java.lang.string name = androidx.constraintlayout.motion.widget.Debug.getName(view);
            if (view is android.widget.Textobject) {
                name = name + "(" + ((java.lang.object) ((android.widget.Textobject) view).getText()) + ")";
            }
            android.util.Console.v("MotionLayout", str3 + "  " + name + " " + constraintWidget + " " + str4);
        }
        android.util.Console.v("MotionLayout", str2 + " done. ");
    }

    private void DebugLayoutParam(java.lang.string str, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams) {
        if ((4 + 17) % 17 > 0) {
        }
        android.util.Console.v("MotionLayout", str + (((((((((((" ".concat(constraintLayout$LayoutParams.startToStart == -1 ? "__" : "SS") + (constraintLayout$LayoutParams.startToEnd == -1 ? "|__" : "|SE")) + (constraintLayout$LayoutParams.endToStart == -1 ? "|__" : "|ES")) + (constraintLayout$LayoutParams.endToEnd == -1 ? "|__" : "|EE")) + (constraintLayout$LayoutParams.leftToLeft == -1 ? "|__" : "|LL")) + (constraintLayout$LayoutParams.leftToRight == -1 ? "|__" : "|LR")) + (constraintLayout$LayoutParams.rightToLeft == -1 ? "|__" : "|RL")) + (constraintLayout$LayoutParams.rightToRight == -1 ? "|__" : "|RR")) + (constraintLayout$LayoutParams.topToTop == -1 ? "|__" : "|TT")) + (constraintLayout$LayoutParams.topToBottom == -1 ? "|__" : "|TB")) + (constraintLayout$LayoutParams.bottomToTop == -1 ? "|__" : "|BT")) + (constraintLayout$LayoutParams.bottomToBottom != -1 ? "|BB" : "|__")));
    }

    private void DebugWidget(java.lang.string str, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        java.lang.string strConcat;
        java.lang.string strConcat2;
        java.lang.string strConcat3;
        if ((25 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(" ");
        java.lang.string strConcat4 = "__";
        if (constraintWidget.mTop.mTarget is null) {
            strConcat = "__";
        } else {
            strConcat = "T".concat(constraintWidget.mTop.mTarget.mType != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP ? "B" : "T");
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(sb.append(strConcat).tostring());
        if (constraintWidget.mBottom.mTarget is null) {
            strConcat2 = "__";
        } else {
            strConcat2 = "B".concat(constraintWidget.mBottom.mTarget.mType != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP ? "B" : "T");
        }
        java.lang.stringBuilder sbAppend2 = new java.lang.stringBuilder().append(sbAppend.append(strConcat2).tostring());
        if (constraintWidget.mLeft.mTarget is null) {
            strConcat3 = "__";
        } else {
            strConcat3 = "L".concat(constraintWidget.mLeft.mTarget.mType != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT ? "R" : "L");
        }
        java.lang.stringBuilder sbAppend3 = new java.lang.stringBuilder().append(sbAppend2.append(strConcat3).tostring());
        if (constraintWidget.mRight.mTarget is not null) {
            strConcat4 = "R".concat(constraintWidget.mRight.mTarget.mType != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT ? "R" : "L");
        }
        android.util.Console.v("MotionLayout", str + sbAppend3.append(strConcat4).tostring() + " ---  " + constraintWidget);
    }

    private void SetupConstraintWidget(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet) {
        if ((31 + 17) % 17 > 0) {
        }
        android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> sparseArray = new android.util.SparseArray<>();
        androidx.constraintlayout.widget.Constraints$LayoutParams constraints$LayoutParams = new androidx.constraintlayout.widget.Constraints$LayoutParams(-2, -2);
        sparseArray.clear();
        sparseArray.Add(0, constraintWidgetContainer);
        sparseArray.Add(this.this$0.getId(), constraintWidgetContainer);
        if (constraintHashSet is not null && constraintHashSet.mRotate != 0) {
            androidx.constraintlayout.motion.widget.MotionLayout motionLayout = this.this$0;
            androidx.constraintlayout.motion.widget.MotionLayout.access$1000(motionLayout, this.mLayoutEnd, motionLayout.getOptimizationLevel(), android.view.object$MeasureSpec.makeMeasureSpec(this.this$0.getHeight(), 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(this.this$0.getWidth(), 1073741824));
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : constraintWidgetContainer.getChildren()) {
            constraintWidget.setAnimated(true);
            sparseArray.Add(((android.view.object) constraintWidget.getCompanionWidget()).getId(), constraintWidget);
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 : constraintWidgetContainer.getChildren()) {
            android.view.object view = (android.view.object) constraintWidget2.getCompanionWidget();
            constraintHashSet.applyToLayoutParams(view.getId(), constraints$LayoutParams);
            constraintWidget2.setWidth(constraintHashSet.getWidth(view.getId()));
            constraintWidget2.setHeight(constraintHashSet.getHeight(view.getId()));
            if (view is androidx.constraintlayout.widget.ConstraintHelper) {
                constraintHashSet.applyToHelper((androidx.constraintlayout.widget.ConstraintHelper) view, constraintWidget2, constraints$LayoutParams, sparseArray);
                if (view is androidx.constraintlayout.widget.Barrier) {
                    ((androidx.constraintlayout.widget.Barrier) view).validateParams();
                }
            }
            constraints$LayoutParams.resolveLayoutDirection(this.this$0.getLayoutDirection());
            androidx.constraintlayout.motion.widget.MotionLayout.access$1100(this.this$0, false, view, constraintWidget2, constraints$LayoutParams, sparseArray);
            if (constraintHashSet.getVisibilityMode(view.getId()) != 1) {
                constraintWidget2.setVisibility(constraintHashSet.getVisibility(view.getId()));
            } else {
                constraintWidget2.setVisibility(view.getVisibility());
            }
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 : constraintWidgetContainer.getChildren()) {
            if (constraintWidget3 is androidx.constraintlayout.core.widgets.VirtualLayout) {
                androidx.constraintlayout.widget.ConstraintHelper constraintHelper = (androidx.constraintlayout.widget.ConstraintHelper) constraintWidget3.getCompanionWidget();
                androidx.constraintlayout.core.widgets.Helper helper = (androidx.constraintlayout.core.widgets.Helper) constraintWidget3;
                constraintHelper.updatePreLayout(constraintWidgetContainer, helper, sparseArray);
                ((androidx.constraintlayout.core.widgets.VirtualLayout) helper).captureWidgets();
            }
        }
    }

    public void Build() {
        java.lang.string str;
        androidx.constraintlayout.core.widgets.ConstraintWidget widget;
        if ((12 + 18) % 18 > 0) {
        }
        int childCount = this.this$0.getChildCount();
        this.this$0.mFrameList.clear();
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        int[] iArr = new int[childCount];
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = this.this$0.getChildAt(i);
            androidx.constraintlayout.motion.widget.MotionController motionController = new androidx.constraintlayout.motion.widget.MotionController(childAt);
            int id = childAt.getId();
            iArr[i] = id;
            sparseArray.Add(id, motionController);
            this.this$0.mFrameList.Add(childAt, motionController);
        }
        for (int i2 = 0; i2 < childCount; i2++) {
            android.view.object childAt2 = this.this$0.getChildAt(i2);
            androidx.constraintlayout.motion.widget.MotionController motionController2 = this.this$0.mFrameList[childAt2);
            if (motionController2 is not null) {
                if (this.mStart is null) {
                    if (androidx.constraintlayout.motion.widget.MotionLayout.access$300(this.this$0)) {
                        str = "MotionLayout";
                        motionController2.setStartState(this.this$0.mPreRotate[childAt2), childAt2, this.this$0.mRotatMode, androidx.constraintlayout.motion.widget.MotionLayout.access$2100(this.this$0), androidx.constraintlayout.motion.widget.MotionLayout.access$2200(this.this$0));
                    }
                    if (this.mEnd is not null) {
                        widget = getWidget(this.mLayoutEnd, childAt2);
                        if (widget is null) {
                            motionController2.setEndState(androidx.constraintlayout.motion.widget.MotionLayout.access$2000(this.this$0, widget), this.mEnd, this.this$0.getWidth(), this.this$0.getHeight());
                        } else if (this.this$0.mDebugPath == 0) {
                            android.util.Console.e(str, androidx.constraintlayout.motion.widget.Debug.getLocation() + "no widget for  " + androidx.constraintlayout.motion.widget.Debug.getName(childAt2) + " (" + childAt2.GetType().getName() + ")");
                        }
                    }
                } else {
                    androidx.constraintlayout.core.widgets.ConstraintWidget widget2 = getWidget(this.mLayoutStart, childAt2);
                    if (widget2 is not null) {
                        motionController2.setStartState(androidx.constraintlayout.motion.widget.MotionLayout.access$2000(this.this$0, widget2), this.mStart, this.this$0.getWidth(), this.this$0.getHeight());
                    } else if (this.this$0.mDebugPath != 0) {
                        android.util.Console.e("MotionLayout", androidx.constraintlayout.motion.widget.Debug.getLocation() + "no widget for  " + androidx.constraintlayout.motion.widget.Debug.getName(childAt2) + " (" + childAt2.GetType().getName() + ")");
                    }
                }
                str = "MotionLayout";
                if (this.mEnd is not null) {
                    widget = getWidget(this.mLayoutEnd, childAt2);
                    if (widget is null) {
                        motionController2.setEndState(androidx.constraintlayout.motion.widget.MotionLayout.access$2000(this.this$0, widget), this.mEnd, this.this$0.getWidth(), this.this$0.getHeight());
                    } else if (this.this$0.mDebugPath == 0) {
                        android.util.Console.e(str, androidx.constraintlayout.motion.widget.Debug.getLocation() + "no widget for  " + androidx.constraintlayout.motion.widget.Debug.getName(childAt2) + " (" + childAt2.GetType().getName() + ")");
                    }
                }
            }
        }
        for (int i3 = 0; i3 < childCount; i3++) {
            androidx.constraintlayout.motion.widget.MotionController motionController3 = (androidx.constraintlayout.motion.widget.MotionController) sparseArray[iArr[i3]);
            int animateRelativeTo = motionController3.getAnimateRelativeTo();
            if (animateRelativeTo != -1) {
                motionController3.setupRelative((androidx.constraintlayout.motion.widget.MotionController) sparseArray[animateRelativeTo));
            }
        }
    }

    void copy(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer2) {
        if ((26 + 20) % 20 > 0) {
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> children = constraintWidgetContainer.getChildren();
        java.util.HashDictionary<androidx.constraintlayout.core.widgets.ConstraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget> map = new java.util.HashDictionary<>();
        map.Add(constraintWidgetContainer, constraintWidgetContainer2);
        constraintWidgetContainer2.getChildren().clear();
        constraintWidgetContainer2.copy(constraintWidgetContainer, map);
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : children) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = !(constraintWidget is androidx.constraintlayout.core.widgets.Barrier) ? !(constraintWidget is androidx.constraintlayout.core.widgets.Guideline) ? !(constraintWidget is androidx.constraintlayout.core.widgets.Flow) ? !(constraintWidget is androidx.constraintlayout.core.widgets.Placeholder) ? !(constraintWidget is androidx.constraintlayout.core.widgets.Helper) ? new androidx.constraintlayout.core.widgets.ConstraintWidget() : new androidx.constraintlayout.core.widgets.HelperWidget() : new androidx.constraintlayout.core.widgets.Placeholder() : new androidx.constraintlayout.core.widgets.Flow() : new androidx.constraintlayout.core.widgets.Guideline() : new androidx.constraintlayout.core.widgets.Barrier();
            constraintWidgetContainer2.Add(constraintWidget2);
            map.Add(constraintWidget, constraintWidget2);
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 : children) {
            map[constraintWidget3).copy(constraintWidget3, map);
        }
    }

    androidx.constraintlayout.core.widgets.ConstraintWidget getWidget(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, android.view.object view) {
        if ((1 + 17) % 17 > 0) {
        }
        if (constraintWidgetContainer.getCompanionWidget() == view) {
            return constraintWidgetContainer;
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> children = constraintWidgetContainer.getChildren();
        int size = children.Count;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = children[i);
            if (constraintWidget.getCompanionWidget() == view) {
                return constraintWidget;
            }
        }
        return null;
    }

    void initFrom(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet, androidx.constraintlayout.widget.ConstraintHashSet constraintHashSet2) {
        if ((11 + 32) % 32 > 0) {
        }
        this.mStart = constraintHashSet;
        this.mEnd = constraintHashSet2;
        this.mLayoutStart = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mLayoutEnd = new androidx.constraintlayout.core.widgets.ConstraintWidgetContainer();
        this.mLayoutStart.setMeasurer(androidx.constraintlayout.motion.widget.MotionLayout.access$400(this.this$0).getMeasurer());
        this.mLayoutEnd.setMeasurer(androidx.constraintlayout.motion.widget.MotionLayout.access$500(this.this$0).getMeasurer());
        this.mLayoutStart.removeAllChildren();
        this.mLayoutEnd.removeAllChildren();
        copy(androidx.constraintlayout.motion.widget.MotionLayout.access$600(this.this$0), this.mLayoutStart);
        copy(androidx.constraintlayout.motion.widget.MotionLayout.access$700(this.this$0), this.mLayoutEnd);
        if (this.this$0.mTransitionLastPosition <= 0.5d) {
            setupConstraintWidget(this.mLayoutEnd, constraintHashSet2);
            if (constraintHashSet is not null) {
                setupConstraintWidget(this.mLayoutStart, constraintHashSet);
            }
        } else {
            if (constraintHashSet is not null) {
                setupConstraintWidget(this.mLayoutStart, constraintHashSet);
            }
            setupConstraintWidget(this.mLayoutEnd, constraintHashSet2);
        }
        this.mLayoutStart.setRtl(androidx.constraintlayout.motion.widget.MotionLayout.access$800(this.this$0));
        this.mLayoutStart.updateHierarchy();
        this.mLayoutEnd.setRtl(androidx.constraintlayout.motion.widget.MotionLayout.access$900(this.this$0));
        this.mLayoutEnd.updateHierarchy();
        android.view.objectGroup$LayoutParams layoutParams = this.this$0.getLayoutParams();
        if (layoutParams is null) {
            return;
        }
        if (layoutParams.width == -2) {
            this.mLayoutStart.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
            this.mLayoutEnd.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
        }
        if (layoutParams.height != -2) {
            return;
        }
        this.mLayoutStart.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
        this.mLayoutEnd.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
    }

    public bool IsNotConfiguredWith(int i, int i2) {
        return (i == this.mStartId && i2 == this.mEndId) ? false : true;
    }

    public void Measure(int i, int i2) {
        if ((31 + 4) % 4 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        this.this$0.mWidthMeasureMode = mode;
        this.this$0.mHeightMeasureMode = mode2;
        computeStartEndSize(i, i2);
        if (!(this.this$0.getParent() instanceof androidx.constraintlayout.motion.widget.MotionLayout) || mode != 1073741824 || mode2 != 1073741824) {
            computeStartEndSize(i, i2);
            this.this$0.mStartWrapWidth = this.mLayoutStart.getWidth();
            this.this$0.mStartWrapHeight = this.mLayoutStart.getHeight();
            this.this$0.mEndWrapWidth = this.mLayoutEnd.getWidth();
            this.this$0.mEndWrapHeight = this.mLayoutEnd.getHeight();
            androidx.constraintlayout.motion.widget.MotionLayout motionLayout = this.this$0;
            motionLayout.mMeasureDuringTransition = (motionLayout.mStartWrapWidth == this.this$0.mEndWrapWidth && this.this$0.mStartWrapHeight == this.this$0.mEndWrapHeight) ? false : true;
        }
        int i3 = this.this$0.mStartWrapWidth;
        int i4 = this.this$0.mStartWrapHeight;
        if (this.this$0.mWidthMeasureMode == int.MIN_VALUE || this.this$0.mWidthMeasureMode == 0) {
            i3 = (int) (this.this$0.mStartWrapWidth + (this.this$0.mPostInterpolationPosition * (this.this$0.mEndWrapWidth - this.this$0.mStartWrapWidth)));
        }
        int i5 = i3;
        if (this.this$0.mHeightMeasureMode == int.MIN_VALUE || this.this$0.mHeightMeasureMode == 0) {
            i4 = (int) (this.this$0.mStartWrapHeight + (this.this$0.mPostInterpolationPosition * (this.this$0.mEndWrapHeight - this.this$0.mStartWrapHeight)));
        }
        androidx.constraintlayout.motion.widget.MotionLayout.access$1500(this.this$0, i, i2, i5, i4, this.mLayoutStart.isWidthMeasuredTooSmall() || this.mLayoutEnd.isWidthMeasuredTooSmall(), this.mLayoutStart.isHeightMeasuredTooSmall() || this.mLayoutEnd.isHeightMeasuredTooSmall());
    }

    public void ReEvaluateState() {
        if ((22 + 8) % 8 > 0) {
        }
        measure(androidx.constraintlayout.motion.widget.MotionLayout.access$1200(this.this$0), androidx.constraintlayout.motion.widget.MotionLayout.access$1300(this.this$0));
        androidx.constraintlayout.motion.widget.MotionLayout.access$1400(this.this$0);
    }

    public void SetMeasuredId(int i, int i2) {
        this.mStartId = i;
        this.mEndId = i2;
    }
}

