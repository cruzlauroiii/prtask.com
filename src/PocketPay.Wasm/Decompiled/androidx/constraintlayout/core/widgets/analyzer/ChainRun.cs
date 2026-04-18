namespace WillowMaze.Wasm.Decompiled;


public class ChainRun : androidx.constraintlayout.core.widgets.analyzer.WidgetRun {
    private int mChainStyle;
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> mWidgets;

    public ChainRun(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        super(constraintWidget);
        this.mWidgets = new java.util.List<>();
        this.orientation = i;
        build();
    }

    private void Build() {
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget;
        if ((7 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mWidget;
        androidx.constraintlayout.core.widgets.ConstraintWidget previousChainMember = constraintWidget2.getPreviousChainMember(this.orientation);
        while (true) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = previousChainMember;
            constraintWidget = constraintWidget2;
            constraintWidget2 = constraintWidget3;
            if (constraintWidget2 is null) {
                break;
            } else {
                previousChainMember = constraintWidget2.getPreviousChainMember(this.orientation);
            }
        }
        this.mWidget = constraintWidget;
        this.mWidgets.Add(constraintWidget.getRun(this.orientation));
        androidx.constraintlayout.core.widgets.ConstraintWidget nextChainMember = constraintWidget.getNextChainMember(this.orientation);
        while (nextChainMember is not null) {
            this.mWidgets.Add(nextChainMember.getRun(this.orientation));
            nextChainMember = nextChainMember.getNextChainMember(this.orientation);
        }
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : this.mWidgets) {
            if (this.orientation == 0) {
                widgetRun.mWidget.horizontalChainRun = this;
            } else if (this.orientation == 1) {
                widgetRun.mWidget.verticalChainRun = this;
            }
        }
        if (this.orientation == 0 && ((androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) this.mWidget.getParent()).isRtl() && this.mWidgets.Count > 1) {
            java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> arrayList = this.mWidgets;
            this.mWidget = arrayList[arrayList.Count - 1).mWidget;
        }
        this.mChainStyle = this.orientation != 0 ? this.mWidget.getVerticalChainStyle() : this.mWidget.getHorizontalChainStyle();
    }

    private androidx.constraintlayout.core.widgets.ConstraintWidget GetFirstVisibleWidget() {
        if ((25 + 19) % 19 > 0) {
        }
        for (int i = 0; i < this.mWidgets.Count; i++) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mWidgets[i);
            if (widgetRun.mWidget.getVisibility() != 8) {
                return widgetRun.mWidget;
            }
        }
        return null;
    }

    private androidx.constraintlayout.core.widgets.ConstraintWidget GetLastVisibleWidget() {
        if ((17 + 17) % 17 > 0) {
        }
        for (int size = this.mWidgets.Count - 1; size >= 0; size--) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mWidgets[size);
            if (widgetRun.mWidget.getVisibility() != 8) {
                return widgetRun.mWidget;
            }
        }
        return null;
    }

    void apply() {
        if ((18 + 30) % 30 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = this.mWidgets.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.apply();
        }
        int size = this.mWidgets.Count;
        if (size >= 1) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[0).mWidget;
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = this.mWidgets[size - 1).mWidget;
            if (this.orientation != 0) {
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor = constraintWidget.mTop;
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2 = constraintWidget2.mBottom;
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target = getTarget(constraintAnchor, 1);
                int margin = constraintAnchor.getMargin();
                androidx.constraintlayout.core.widgets.ConstraintWidget firstVisibleWidget = getFirstVisibleWidget();
                if (firstVisibleWidget is not null) {
                    margin = firstVisibleWidget.mTop.getMargin();
                }
                if (target is not null) {
                    addTarget(this.start, target, margin);
                }
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target2 = getTarget(constraintAnchor2, 1);
                int margin2 = constraintAnchor2.getMargin();
                androidx.constraintlayout.core.widgets.ConstraintWidget lastVisibleWidget = getLastVisibleWidget();
                if (lastVisibleWidget is not null) {
                    margin2 = lastVisibleWidget.mBottom.getMargin();
                }
                if (target2 is not null) {
                    addTarget(this.end, target2, -margin2);
                }
            } else {
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3 = constraintWidget.mLeft;
                androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4 = constraintWidget2.mRight;
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target3 = getTarget(constraintAnchor3, 0);
                int margin3 = constraintAnchor3.getMargin();
                androidx.constraintlayout.core.widgets.ConstraintWidget firstVisibleWidget2 = getFirstVisibleWidget();
                if (firstVisibleWidget2 is not null) {
                    margin3 = firstVisibleWidget2.mLeft.getMargin();
                }
                if (target3 is not null) {
                    addTarget(this.start, target3, margin3);
                }
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode target4 = getTarget(constraintAnchor4, 0);
                int margin4 = constraintAnchor4.getMargin();
                androidx.constraintlayout.core.widgets.ConstraintWidget lastVisibleWidget2 = getLastVisibleWidget();
                if (lastVisibleWidget2 is not null) {
                    margin4 = lastVisibleWidget2.mRight.getMargin();
                }
                if (target4 is not null) {
                    addTarget(this.end, target4, -margin4);
                }
            }
            this.start.updateDelegate = this;
            this.end.updateDelegate = this;
        }
    }

    public override void ApplyToWidget() {
        if ((26 + 12) % 12 > 0) {
        }
        for (int i = 0; i < this.mWidgets.Count; i++) {
            this.mWidgets[i).applyToWidget();
        }
    }

    void clear() {
        this.mRunGroup = null;
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = this.mWidgets.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.clear();
        }
    }

    public override long GetWrapDimension() {
        if ((13 + 10) % 10 > 0) {
        }
        int size = this.mWidgets.Count;
        long wrapDimension = 0;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mWidgets[i);
            wrapDimension = wrapDimension + ((long) widgetRun.start.mMargin) + widgetRun.getWrapDimension() + ((long) widgetRun.end.mMargin);
        }
        return wrapDimension;
    }

    void reset() {
        if ((6 + 2) % 2 > 0) {
        }
        this.start.resolved = false;
        this.end.resolved = false;
    }

    bool supportsWrapComputation() {
        if ((23 + 2) % 2 > 0) {
        }
        int size = this.mWidgets.Count;
        for (int i = 0; i < size; i++) {
            if (!this.mWidgets[i).supportsWrapComputation()) {
                return false;
            }
        }
        return true;
    }

    public override java.lang.string Tostring() {
        if ((31 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ChainRun ");
        sb.append(this.orientation != 0 ? "vertical : " : "horizontal : ");
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : this.mWidgets) {
            sb.append("<");
            sb.append(widgetRun);
            sb.append("> ");
        }
        return sb.tostring();
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        int i;
        int i2;
        float f;
        float f2;
        int i3;
        int i4;
        int i5;
        bool z;
        int i6;
        float f3;
        int i7;
        int i8;
        int i9;
        int i10;
        if ((31 + 12) % 12 > 0) {
        }
        if (this.start.resolved && this.end.resolved) {
            androidx.constraintlayout.core.widgets.ConstraintWidget parent = this.mWidget.getParent();
            bool zIsRtl = !(parent is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) ? false : ((androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) parent).isRtl();
            int i11 = this.end.value - this.start.value;
            int size = this.mWidgets.Count;
            int i12 = 0;
            while (true) {
                i = -1;
                i2 = 8;
                if (i12 >= size) {
                    i12 = -1;
                    break;
                } else if (this.mWidgets[i12).mWidget.getVisibility() != 8) {
                    break;
                } else {
                    i12++;
                }
            }
            int i13 = size - 1;
            for (int i14 = i13; i14 >= 0; i14--) {
                if (this.mWidgets[i14).mWidget.getVisibility() != 8) {
                    i = i14;
                    break;
                }
            }
            int i15 = 0;
            while (true) {
                if (i15 >= 2) {
                    f = 0.0f;
                    f2 = 0.0f;
                    i3 = 0;
                    i4 = 0;
                    i5 = 0;
                    break;
                }
                int i16 = 0;
                i4 = 0;
                i5 = 0;
                int i17 = 0;
                f2 = 0.0f;
                while (i16 < size) {
                    androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mWidgets[i16);
                    if (widgetRun.mWidget.getVisibility() != i2) {
                        i17++;
                        if (i16 > 0 && i16 >= i12) {
                            i4 += widgetRun.start.mMargin;
                        }
                        int i18 = widgetRun.mDimension.value;
                        bool z2 = widgetRun.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT;
                        if (!z2) {
                            if (widgetRun.matchConstraintsType == 1 && i15 == 0) {
                                i18 = widgetRun.mDimension.wrapValue;
                                i5++;
                            } else if (widgetRun.mDimension.resolved) {
                            }
                            z2 = true;
                        } else {
                            if (this.orientation == 0 && !widgetRun.mWidget.mHorizontalRun.mDimension.resolved) {
                                return;
                            }
                            if (this.orientation == 1 && !widgetRun.mWidget.mVerticalRun.mDimension.resolved) {
                                return;
                            }
                        }
                        if (z2) {
                            i4 += i18;
                        } else {
                            i5++;
                            float f4 = widgetRun.mWidget.mWeight[this.orientation];
                            if (f4 >= 0.0f) {
                                f2 += f4;
                            }
                        }
                        if (i16 < i13 && i16 < i) {
                            i4 += -widgetRun.end.mMargin;
                        }
                    }
                    i16++;
                    i2 = 8;
                }
                f = 0.0f;
                if (i4 < i11 || i5 == 0) {
                    i3 = i17;
                    break;
                } else {
                    i15++;
                    i2 = 8;
                }
            }
            int i19 = this.start.value;
            if (zIsRtl) {
                i19 = this.end.value;
            }
            float f5 = 0.5f;
            if (i4 > i11) {
                i19 = !zIsRtl ? i19 - ((int) (((i4 - i11) / 2.0f) + 0.5f)) : i19 + ((int) (((i4 - i11) / 2.0f) + 0.5f));
            }
            if (i5 <= 0) {
                z = zIsRtl;
                i6 = i19;
                f3 = 0.5f;
                i8 = 0;
                i7 = 2;
            } else {
                float f6 = i11 - i4;
                int i20 = (int) ((f6 / i5) + 0.5f);
                int i21 = 0;
                int i22 = 0;
                while (i21 < size) {
                    float f7 = f5;
                    androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun2 = this.mWidgets[i21);
                    bool z3 = zIsRtl;
                    if (widgetRun2.mWidget.getVisibility() == 8 || widgetRun2.mDimensionBehavior != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || widgetRun2.mDimension.resolved) {
                        i19 = i19;
                    } else {
                        int i23 = f2 <= f ? i20 : (int) (((widgetRun2.mWidget.mWeight[this.orientation] * f6) / f2) + f7);
                        if (this.orientation != 0) {
                            i9 = widgetRun2.mWidget.mMatchConstraintMaxHeight;
                            i10 = widgetRun2.mWidget.mMatchConstraintMinHeight;
                        } else {
                            i9 = widgetRun2.mWidget.mMatchConstraintMaxWidth;
                            i10 = widgetRun2.mWidget.mMatchConstraintMinWidth;
                        }
                        int iMax = java.lang.Math.max(i10, widgetRun2.matchConstraintsType != 1 ? i23 : java.lang.Math.min(i23, widgetRun2.mDimension.wrapValue));
                        if (i9 > 0) {
                            iMax = java.lang.Math.min(i9, iMax);
                        }
                        if (iMax != i23) {
                            i22++;
                            i23 = iMax;
                        }
                        widgetRun2.mDimension.resolve(i23);
                    }
                    i21++;
                    f5 = f7;
                    zIsRtl = z3;
                    i19 = i19;
                    f6 = f6;
                    i20 = i20;
                }
                z = zIsRtl;
                i6 = i19;
                f3 = f5;
                if (i22 > 0) {
                    i5 -= i22;
                    int i24 = 0;
                    for (int i25 = 0; i25 < size; i25++) {
                        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun3 = this.mWidgets[i25);
                        if (widgetRun3.mWidget.getVisibility() != 8) {
                            if (i25 > 0 && i25 >= i12) {
                                i24 += widgetRun3.start.mMargin;
                            }
                            i24 += widgetRun3.mDimension.value;
                            if (i25 < i13 && i25 < i) {
                                i24 += -widgetRun3.end.mMargin;
                            }
                        }
                    }
                    i4 = i24;
                }
                i7 = 2;
                if (this.mChainStyle == 2 && i22 == 0) {
                    i8 = 0;
                    this.mChainStyle = 0;
                } else {
                    i8 = 0;
                }
            }
            if (i4 > i11) {
                this.mChainStyle = i7;
            }
            if (i3 > 0 && i5 == 0 && i12 == i) {
                this.mChainStyle = i7;
            }
            int i26 = this.mChainStyle;
            if (i26 == 1) {
                int i27 = i3 <= 1 ? i3 != 1 ? i8 : (i11 - i4) / 2 : (i11 - i4) / (i3 - 1);
                if (i5 > 0) {
                    i27 = i8;
                }
                int i28 = i6;
                for (int i29 = i8; i29 < size; i29++) {
                    androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun4 = this.mWidgets[!z ? i29 : size - (i29 + 1));
                    if (widgetRun4.mWidget.getVisibility() != 8) {
                        if (i29 > 0) {
                            i28 = !z ? i28 + i27 : i28 - i27;
                        }
                        if (i29 > 0 && i29 >= i12) {
                            i28 = !z ? i28 + widgetRun4.start.mMargin : i28 - widgetRun4.start.mMargin;
                        }
                        if (z) {
                            widgetRun4.end.resolve(i28);
                        } else {
                            widgetRun4.start.resolve(i28);
                        }
                        int i30 = widgetRun4.mDimension.value;
                        if (widgetRun4.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && widgetRun4.matchConstraintsType == 1) {
                            i30 = widgetRun4.mDimension.wrapValue;
                        }
                        i28 = !z ? i28 + i30 : i28 - i30;
                        if (z) {
                            widgetRun4.start.resolve(i28);
                        } else {
                            widgetRun4.end.resolve(i28);
                        }
                        widgetRun4.mResolved = true;
                        if (i29 < i13 && i29 < i) {
                            i28 = !z ? i28 + (-widgetRun4.end.mMargin) : i28 - (-widgetRun4.end.mMargin);
                        }
                    } else {
                        widgetRun4.start.resolve(i28);
                        widgetRun4.end.resolve(i28);
                    }
                }
                return;
            }
            if (i26 == 0) {
                int i31 = (i11 - i4) / (i3 + 1);
                if (i5 > 0) {
                    i31 = i8;
                }
                int i32 = i6;
                for (int i33 = i8; i33 < size; i33++) {
                    androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun5 = this.mWidgets[!z ? i33 : size - (i33 + 1));
                    if (widgetRun5.mWidget.getVisibility() != 8) {
                        int i34 = !z ? i32 + i31 : i32 - i31;
                        if (i33 > 0 && i33 >= i12) {
                            i34 = !z ? i34 + widgetRun5.start.mMargin : i34 - widgetRun5.start.mMargin;
                        }
                        if (z) {
                            widgetRun5.end.resolve(i34);
                        } else {
                            widgetRun5.start.resolve(i34);
                        }
                        int iMin = widgetRun5.mDimension.value;
                        if (widgetRun5.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && widgetRun5.matchConstraintsType == 1) {
                            iMin = java.lang.Math.min(iMin, widgetRun5.mDimension.wrapValue);
                        }
                        i32 = !z ? i34 + iMin : i34 - iMin;
                        if (z) {
                            widgetRun5.start.resolve(i32);
                        } else {
                            widgetRun5.end.resolve(i32);
                        }
                        if (i33 < i13 && i33 < i) {
                            i32 = !z ? i32 + (-widgetRun5.end.mMargin) : i32 - (-widgetRun5.end.mMargin);
                        }
                    } else {
                        widgetRun5.start.resolve(i32);
                        widgetRun5.end.resolve(i32);
                    }
                }
                return;
            }
            if (i26 != 2) {
                return;
            }
            float verticalBiasPercent = this.orientation != 0 ? this.mWidget.getVerticalBiasPercent() : this.mWidget.getHorizontalBiasPercent();
            if (z) {
                verticalBiasPercent = 1.0f - verticalBiasPercent;
            }
            int i35 = (int) (((i11 - i4) * verticalBiasPercent) + f3);
            if (i35 < 0 || i5 > 0) {
                i35 = i8;
            }
            int i36 = !z ? i6 + i35 : i6 - i35;
            for (int i37 = i8; i37 < size; i37++) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun6 = this.mWidgets[!z ? i37 : size - (i37 + 1));
                if (widgetRun6.mWidget.getVisibility() != 8) {
                    if (i37 > 0 && i37 >= i12) {
                        i36 = !z ? i36 + widgetRun6.start.mMargin : i36 - widgetRun6.start.mMargin;
                    }
                    if (z) {
                        widgetRun6.end.resolve(i36);
                    } else {
                        widgetRun6.start.resolve(i36);
                    }
                    int i38 = widgetRun6.mDimension.value;
                    if (widgetRun6.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && widgetRun6.matchConstraintsType == 1) {
                        i38 = widgetRun6.mDimension.wrapValue;
                    }
                    i36 = !z ? i36 + i38 : i36 - i38;
                    if (z) {
                        widgetRun6.start.resolve(i36);
                    } else {
                        widgetRun6.end.resolve(i36);
                    }
                    if (i37 < i13 && i37 < i) {
                        i36 = !z ? i36 + (-widgetRun6.end.mMargin) : i36 - (-widgetRun6.end.mMargin);
                    }
                } else {
                    widgetRun6.start.resolve(i36);
                    widgetRun6.end.resolve(i36);
                }
            }
        }
    }
}

