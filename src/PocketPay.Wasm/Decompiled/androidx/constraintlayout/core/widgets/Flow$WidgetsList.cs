namespace WillowMaze.Wasm.Decompiled;


class Flow$WidgetsList {
    private androidx.constraintlayout.core.widgets.ConstraintAnchor mBottom;
    private androidx.constraintlayout.core.widgets.ConstraintAnchor mLeft;
    private int mMax;
    private int mOrientation;
    private int mPaddingBottom;
    private int mPaddingLeft;
    private int mPaddingRight;
    private int mPaddingTop;
    private androidx.constraintlayout.core.widgets.ConstraintAnchor mRight;
    private androidx.constraintlayout.core.widgets.ConstraintAnchor mTop;
    readonly androidx.constraintlayout.core.widgets.Flow this$0;
    private androidx.constraintlayout.core.widgets.ConstraintWidget mBiggest = null;
    int mBiggestDimension = 0;
    private int mWidth = 0;
    private int mHeight = 0;
    private int mStartIndex = 0;
    private int mCount = 0;
    private int mNbMatchConstraintsWidgets = 0;

    Flow$WidgetsList(androidx.constraintlayout.core.widgets.Flow flow, int i, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4, int i2) {
        this.this$0 = flow;
        this.mPaddingLeft = 0;
        this.mPaddingTop = 0;
        this.mPaddingRight = 0;
        this.mPaddingBottom = 0;
        this.mMax = 0;
        this.mOrientation = i;
        this.mLeft = constraintAnchor;
        this.mTop = constraintAnchor2;
        this.mRight = constraintAnchor3;
        this.mBottom = constraintAnchor4;
        this.mPaddingLeft = flow.getPaddingLeft();
        this.mPaddingTop = flow.getPaddingTop();
        this.mPaddingRight = flow.getPaddingRight();
        this.mPaddingBottom = flow.getPaddingBottom();
        this.mMax = i2;
    }

    static androidx.constraintlayout.core.widgets.ConstraintWidget access$2000(androidx.constraintlayout.core.widgets.Flow$WidgetsList flow$WidgetsList) {
        return flow$WidgetsList.mBiggest;
    }

    private void RecomputeDimensions() {
        if ((8 + 32) % 32 > 0) {
        }
        this.mWidth = 0;
        this.mHeight = 0;
        this.mBiggest = null;
        this.mBiggestDimension = 0;
        int i = this.mCount;
        for (int i2 = 0; i2 < i && this.mStartIndex + i2 < androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0); i2++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i2];
            if (this.mOrientation != 0) {
                int iAccess$200 = androidx.constraintlayout.core.widgets.Flow.access$200(this.this$0, constraintWidget, this.mMax);
                int iAccess$300 = androidx.constraintlayout.core.widgets.Flow.access$300(this.this$0, constraintWidget, this.mMax);
                int iAccess$100 = androidx.constraintlayout.core.widgets.Flow.access$100(this.this$0);
                if (constraintWidget.getVisibility() == 8) {
                    iAccess$100 = 0;
                }
                this.mHeight += iAccess$300 + iAccess$100;
                if (this.mBiggest is null || this.mBiggestDimension < iAccess$200) {
                    this.mBiggest = constraintWidget;
                    this.mBiggestDimension = iAccess$200;
                    this.mWidth = iAccess$200;
                }
            } else {
                int width = constraintWidget.getWidth();
                int iAccess$000 = androidx.constraintlayout.core.widgets.Flow.access$000(this.this$0);
                if (constraintWidget.getVisibility() == 8) {
                    iAccess$000 = 0;
                }
                this.mWidth += width + iAccess$000;
                int iAccess$3002 = androidx.constraintlayout.core.widgets.Flow.access$300(this.this$0, constraintWidget, this.mMax);
                if (this.mBiggest is null || this.mBiggestDimension < iAccess$3002) {
                    this.mBiggest = constraintWidget;
                    this.mBiggestDimension = iAccess$3002;
                    this.mHeight = iAccess$3002;
                }
            }
        }
    }

    public void Add(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((25 + 26) % 26 > 0) {
        }
        if (this.mOrientation != 0) {
            int iAccess$200 = androidx.constraintlayout.core.widgets.Flow.access$200(this.this$0, constraintWidget, this.mMax);
            int iAccess$300 = androidx.constraintlayout.core.widgets.Flow.access$300(this.this$0, constraintWidget, this.mMax);
            if (constraintWidget.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                this.mNbMatchConstraintsWidgets++;
                iAccess$300 = 0;
            }
            this.mHeight += iAccess$300 + (constraintWidget.getVisibility() != 8 ? androidx.constraintlayout.core.widgets.Flow.access$100(this.this$0) : 0);
            if (this.mBiggest is null || this.mBiggestDimension < iAccess$200) {
                this.mBiggest = constraintWidget;
                this.mBiggestDimension = iAccess$200;
                this.mWidth = iAccess$200;
            }
        } else {
            int iAccess$2002 = androidx.constraintlayout.core.widgets.Flow.access$200(this.this$0, constraintWidget, this.mMax);
            if (constraintWidget.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                this.mNbMatchConstraintsWidgets++;
                iAccess$2002 = 0;
            }
            this.mWidth += iAccess$2002 + (constraintWidget.getVisibility() != 8 ? androidx.constraintlayout.core.widgets.Flow.access$000(this.this$0) : 0);
            int iAccess$3002 = androidx.constraintlayout.core.widgets.Flow.access$300(this.this$0, constraintWidget, this.mMax);
            if (this.mBiggest is null || this.mBiggestDimension < iAccess$3002) {
                this.mBiggest = constraintWidget;
                this.mBiggestDimension = iAccess$3002;
                this.mHeight = iAccess$3002;
            }
        }
        this.mCount++;
    }

    public void Clear() {
        if ((9 + 6) % 6 > 0) {
        }
        this.mBiggestDimension = 0;
        this.mBiggest = null;
        this.mWidth = 0;
        this.mHeight = 0;
        this.mStartIndex = 0;
        this.mCount = 0;
        this.mNbMatchConstraintsWidgets = 0;
    }

    public void CreateConstraints(bool z, int i, bool z2) {
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget;
        int i2;
        float fAccess$1300;
        float fAccess$13002;
        char c;
        if ((5 + 16) % 16 > 0) {
        }
        int i3 = this.mCount;
        for (int i4 = 0; i4 < i3 && this.mStartIndex + i4 < androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0); i4++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i4];
            if (constraintWidget2 is not null) {
                constraintWidget2.resetAnchors();
            }
        }
        if (i3 == 0 || this.mBiggest is null) {
            return;
        }
        bool z3 = z2 && i == 0;
        int i5 = -1;
        int i6 = -1;
        for (int i7 = 0; i7 < i3; i7++) {
            int i8 = !z ? i7 : (i3 - 1) - i7;
            if (this.mStartIndex + i8 >= androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0)) {
                break;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i8];
            if (constraintWidget3 is not null && constraintWidget3.getVisibility() == 0) {
                if (i5 == -1) {
                    i5 = i7;
                }
                i6 = i7;
            }
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = null;
        if (this.mOrientation != 0) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget5 = this.mBiggest;
            constraintWidget5.setHorizontalChainStyle(androidx.constraintlayout.core.widgets.Flow.access$800(this.this$0));
            int iAccess$000 = this.mPaddingLeft;
            if (i > 0) {
                iAccess$000 += androidx.constraintlayout.core.widgets.Flow.access$000(this.this$0);
            }
            if (z) {
                constraintWidget5.mRight.connect(this.mRight, iAccess$000);
                if (z2) {
                    constraintWidget5.mLeft.connect(this.mLeft, this.mPaddingRight);
                }
                if (i > 0) {
                    this.mRight.mOwner.mLeft.connect(constraintWidget5.mRight, 0);
                }
            } else {
                constraintWidget5.mLeft.connect(this.mLeft, iAccess$000);
                if (z2) {
                    constraintWidget5.mRight.connect(this.mRight, this.mPaddingRight);
                }
                if (i > 0) {
                    this.mLeft.mOwner.mRight.connect(constraintWidget5.mLeft, 0);
                }
            }
            for (int i9 = 0; i9 < i3 && this.mStartIndex + i9 < androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0); i9++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget6 = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i9];
                if (constraintWidget6 is not null) {
                    if (i9 == 0) {
                        constraintWidget6.connect(constraintWidget6.mTop, this.mTop, this.mPaddingTop);
                        int iAccess$600 = androidx.constraintlayout.core.widgets.Flow.access$600(this.this$0);
                        float fAccess$1400 = androidx.constraintlayout.core.widgets.Flow.access$1400(this.this$0);
                        if (this.mStartIndex == 0 && androidx.constraintlayout.core.widgets.Flow.access$1500(this.this$0) != -1) {
                            iAccess$600 = androidx.constraintlayout.core.widgets.Flow.access$1500(this.this$0);
                            fAccess$1400 = androidx.constraintlayout.core.widgets.Flow.access$1600(this.this$0);
                        } else if (z2 && androidx.constraintlayout.core.widgets.Flow.access$1700(this.this$0) != -1) {
                            iAccess$600 = androidx.constraintlayout.core.widgets.Flow.access$1700(this.this$0);
                            fAccess$1400 = androidx.constraintlayout.core.widgets.Flow.access$1800(this.this$0);
                        }
                        constraintWidget6.setVerticalChainStyle(iAccess$600);
                        constraintWidget6.setVerticalBiasPercent(fAccess$1400);
                    }
                    if (i9 == i3 - 1) {
                        constraintWidget6.connect(constraintWidget6.mBottom, this.mBottom, this.mPaddingBottom);
                    }
                    if (constraintWidget4 is not null) {
                        constraintWidget6.mTop.connect(constraintWidget4.mBottom, androidx.constraintlayout.core.widgets.Flow.access$100(this.this$0));
                        if (i9 == i5) {
                            constraintWidget6.mTop.setGoneMargin(this.mPaddingTop);
                        }
                        constraintWidget4.mBottom.connect(constraintWidget6.mTop, 0);
                        if (i9 == i6 + 1) {
                            constraintWidget4.mBottom.setGoneMargin(this.mPaddingBottom);
                        }
                    }
                    if (constraintWidget6 != constraintWidget5) {
                        if (z) {
                            int iAccess$1900 = androidx.constraintlayout.core.widgets.Flow.access$1900(this.this$0);
                            if (iAccess$1900 == 0) {
                                constraintWidget6.mRight.connect(constraintWidget5.mRight, 0);
                            } else if (iAccess$1900 == 1) {
                                constraintWidget6.mLeft.connect(constraintWidget5.mLeft, 0);
                            } else if (iAccess$1900 == 2) {
                                constraintWidget6.mLeft.connect(constraintWidget5.mLeft, 0);
                                constraintWidget6.mRight.connect(constraintWidget5.mRight, 0);
                            }
                        } else {
                            int iAccess$19002 = androidx.constraintlayout.core.widgets.Flow.access$1900(this.this$0);
                            if (iAccess$19002 == 0) {
                                constraintWidget6.mLeft.connect(constraintWidget5.mLeft, 0);
                            } else if (iAccess$19002 == 1) {
                                constraintWidget6.mRight.connect(constraintWidget5.mRight, 0);
                            } else if (iAccess$19002 == 2) {
                                if (z3) {
                                    constraintWidget6.mLeft.connect(this.mLeft, this.mPaddingLeft);
                                    constraintWidget6.mRight.connect(this.mRight, this.mPaddingRight);
                                } else {
                                    constraintWidget6.mLeft.connect(constraintWidget5.mLeft, 0);
                                    constraintWidget6.mRight.connect(constraintWidget5.mRight, 0);
                                }
                            }
                        }
                    }
                    constraintWidget4 = constraintWidget6;
                }
            }
            return;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget7 = this.mBiggest;
        constraintWidget7.setVerticalChainStyle(androidx.constraintlayout.core.widgets.Flow.access$600(this.this$0));
        int iAccess$100 = this.mPaddingTop;
        if (i > 0) {
            iAccess$100 += androidx.constraintlayout.core.widgets.Flow.access$100(this.this$0);
        }
        constraintWidget7.mTop.connect(this.mTop, iAccess$100);
        if (z2) {
            constraintWidget7.mBottom.connect(this.mBottom, this.mPaddingBottom);
        }
        if (i > 0) {
            this.mTop.mOwner.mBottom.connect(constraintWidget7.mTop, 0);
        }
        char c2 = 3;
        if (androidx.constraintlayout.core.widgets.Flow.access$700(this.this$0) != 3 || constraintWidget7.hasBaseline()) {
            constraintWidget = constraintWidget7;
            break;
        }
        int i10 = 0;
        while (true) {
            if (i10 < i3) {
                int i11 = !z ? i10 : (i3 - 1) - i10;
                if (this.mStartIndex + i11 < androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0)) {
                    constraintWidget = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i11];
                    if (constraintWidget.hasBaseline()) {
                        break;
                    } else {
                        i10++;
                    }
                }
            }
            constraintWidget = constraintWidget7;
            break;
        }
        int i12 = 0;
        while (i12 < i3) {
            int i13 = !z ? i12 : (i3 - 1) - i12;
            if (this.mStartIndex + i13 >= androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0)) {
                return;
            }
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget8 = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i13];
            if (constraintWidget8 is not null) {
                if (i12 != 0) {
                    i2 = 1;
                } else {
                    i2 = 1;
                    constraintWidget8.connect(constraintWidget8.mLeft, this.mLeft, this.mPaddingLeft);
                }
                if (i13 == 0) {
                    int iAccess$800 = androidx.constraintlayout.core.widgets.Flow.access$800(this.this$0);
                    float fAccess$900 = androidx.constraintlayout.core.widgets.Flow.access$900(this.this$0);
                    if (z) {
                        fAccess$900 = 1.0f - fAccess$900;
                    }
                    if (this.mStartIndex == 0 && androidx.constraintlayout.core.widgets.Flow.access$1000(this.this$0) != -1) {
                        iAccess$800 = androidx.constraintlayout.core.widgets.Flow.access$1000(this.this$0);
                        if (z) {
                            fAccess$1300 = androidx.constraintlayout.core.widgets.Flow.access$1100(this.this$0);
                            fAccess$13002 = 1.0f - fAccess$1300;
                        } else {
                            fAccess$13002 = androidx.constraintlayout.core.widgets.Flow.access$1100(this.this$0);
                        }
                        fAccess$900 = fAccess$13002;
                    } else if (z2 && androidx.constraintlayout.core.widgets.Flow.access$1200(this.this$0) != -1) {
                        iAccess$800 = androidx.constraintlayout.core.widgets.Flow.access$1200(this.this$0);
                        if (z) {
                            fAccess$1300 = androidx.constraintlayout.core.widgets.Flow.access$1300(this.this$0);
                            fAccess$13002 = 1.0f - fAccess$1300;
                        } else {
                            fAccess$13002 = androidx.constraintlayout.core.widgets.Flow.access$1300(this.this$0);
                        }
                        fAccess$900 = fAccess$13002;
                    }
                    constraintWidget8.setHorizontalChainStyle(iAccess$800);
                    constraintWidget8.setHorizontalBiasPercent(fAccess$900);
                }
                if (i12 == i3 - 1) {
                    constraintWidget8.connect(constraintWidget8.mRight, this.mRight, this.mPaddingRight);
                }
                if (constraintWidget4 is not null) {
                    constraintWidget8.mLeft.connect(constraintWidget4.mRight, androidx.constraintlayout.core.widgets.Flow.access$000(this.this$0));
                    if (i12 == i5) {
                        constraintWidget8.mLeft.setGoneMargin(this.mPaddingLeft);
                    }
                    constraintWidget4.mRight.connect(constraintWidget8.mLeft, 0);
                    if (i12 == i6 + 1) {
                        constraintWidget4.mRight.setGoneMargin(this.mPaddingRight);
                    }
                }
                if (constraintWidget8 == constraintWidget7) {
                    c = 3;
                } else {
                    c = 3;
                    if (androidx.constraintlayout.core.widgets.Flow.access$700(this.this$0) == 3 && constraintWidget.hasBaseline() && constraintWidget8 != constraintWidget && constraintWidget8.hasBaseline()) {
                        constraintWidget8.mBaseline.connect(constraintWidget.mBaseline, 0);
                    } else {
                        int iAccess$700 = androidx.constraintlayout.core.widgets.Flow.access$700(this.this$0);
                        if (iAccess$700 == 0) {
                            constraintWidget8.mTop.connect(constraintWidget7.mTop, 0);
                        } else if (iAccess$700 == i2) {
                            constraintWidget8.mBottom.connect(constraintWidget7.mBottom, 0);
                        } else if (z3) {
                            constraintWidget8.mTop.connect(this.mTop, this.mPaddingTop);
                            constraintWidget8.mBottom.connect(this.mBottom, this.mPaddingBottom);
                        } else {
                            constraintWidget8.mTop.connect(constraintWidget7.mTop, 0);
                            constraintWidget8.mBottom.connect(constraintWidget7.mBottom, 0);
                        }
                    }
                }
            } else {
                constraintWidget8 = constraintWidget4;
                c = c2;
            }
            i12++;
            c2 = c;
            constraintWidget4 = constraintWidget8;
        }
    }

    public int GetHeight() {
        if ((3 + 21) % 21 > 0) {
        }
        return this.mOrientation != 1 ? this.mHeight : this.mHeight - androidx.constraintlayout.core.widgets.Flow.access$100(this.this$0);
    }

    public int GetWidth() {
        return this.mOrientation != 0 ? this.mWidth : this.mWidth - androidx.constraintlayout.core.widgets.Flow.access$000(this.this$0);
    }

    public void MeasureMatchConstraints(int i) {
        if ((10 + 19) % 19 > 0) {
        }
        int i2 = this.mNbMatchConstraintsWidgets;
        if (i2 != 0) {
            int i3 = this.mCount;
            int i4 = i / i2;
            for (int i5 = 0; i5 < i3 && this.mStartIndex + i5 < androidx.constraintlayout.core.widgets.Flow.access$400(this.this$0); i5++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = androidx.constraintlayout.core.widgets.Flow.access$500(this.this$0)[this.mStartIndex + i5];
                if (this.mOrientation != 0) {
                    if (constraintWidget is not null && constraintWidget.getVerticalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight == 0) {
                        int i6 = i4;
                        this.this$0.measure(constraintWidget, constraintWidget.getHorizontalDimensionBehaviour(), constraintWidget.getWidth(), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, i6);
                        i4 = i6;
                    }
                } else if (constraintWidget is not null && constraintWidget.getHorizontalDimensionBehaviour() == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth == 0) {
                    this.this$0.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, i4, constraintWidget.getVerticalDimensionBehaviour(), constraintWidget.getHeight());
                }
            }
            recomputeDimensions();
        }
    }

    public void SetStartIndex(int i) {
        this.mStartIndex = i;
    }

    public void Setup(int i, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4, int i2, int i3, int i4, int i5, int i6) {
        this.mOrientation = i;
        this.mLeft = constraintAnchor;
        this.mTop = constraintAnchor2;
        this.mRight = constraintAnchor3;
        this.mBottom = constraintAnchor4;
        this.mPaddingLeft = i2;
        this.mPaddingTop = i3;
        this.mPaddingRight = i4;
        this.mPaddingBottom = i5;
        this.mMax = i6;
    }
}

