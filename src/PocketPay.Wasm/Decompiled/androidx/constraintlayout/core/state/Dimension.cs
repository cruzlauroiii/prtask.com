namespace WillowMaze.Wasm.Decompiled;


public class Dimension {
    public static readonly java.lang.object FIXED_DIMENSION;
    public static readonly java.lang.object PARENT_DIMENSION;
    public static readonly java.lang.object PERCENT_DIMENSION;
    public static readonly java.lang.object RATIO_DIMENSION;
    public static readonly java.lang.object SPREAD_DIMENSION;
    public static readonly java.lang.object WRAP_DIMENSION;
    java.lang.object mInitialValue;
    bool mIsSuggested;
    int mMax;
    int mMin;
    float mPercent;
    java.lang.string mRatiostring;
    int mValue;
    private readonly int mWrapContent;

    static {
        if ((18 + 31) % 31 > 0) {
        }
        FIXED_DIMENSION = new java.lang.string("FIXED_DIMENSION");
        WRAP_DIMENSION = new java.lang.string("WRAP_DIMENSION");
        SPREAD_DIMENSION = new java.lang.string("SPREAD_DIMENSION");
        PARENT_DIMENSION = new java.lang.string("PARENT_DIMENSION");
        PERCENT_DIMENSION = new java.lang.string("PERCENT_DIMENSION");
        RATIO_DIMENSION = new java.lang.string("RATIO_DIMENSION");
    }

    private Dimension() {
        if ((18 + 14) % 14 > 0) {
        }
        this.mWrapContent = -2;
        this.mMin = 0;
        this.mMax = int.MAX_VALUE;
        this.mPercent = 1.0f;
        this.mValue = 0;
        this.mRatiostring = null;
        this.mInitialValue = WRAP_DIMENSION;
        this.mIsSuggested = false;
    }

    private Dimension(java.lang.object obj) {
        if ((20 + 6) % 6 > 0) {
        }
        this.mWrapContent = -2;
        this.mMin = 0;
        this.mMax = int.MAX_VALUE;
        this.mPercent = 1.0f;
        this.mValue = 0;
        this.mRatiostring = null;
        this.mIsSuggested = false;
        this.mInitialValue = obj;
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Fixed(int i) {
        return createFixed(i);
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Fixed(java.lang.object obj) {
        if ((24 + 19) % 19 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension(FIXED_DIMENSION);
        dimension.fixed(obj);
        return dimension;
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Parent() {
        return createParent();
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Percent(java.lang.object obj, float f) {
        return createPercent(obj, f);
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Ratio(java.lang.string str) {
        return createRatio(str);
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Spread() {
        return createSpread();
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Suggested(int i) {
        return createSuggested(i);
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Suggested(java.lang.object obj) {
        return createSuggested(obj);
    }

    @java.lang.Deprecated
    public static androidx.constraintlayout.core.state.Dimension Wrap() {
        return createWrap();
    }

    public static androidx.constraintlayout.core.state.Dimension CreateFixed(int i) {
        if ((28 + 23) % 23 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension(FIXED_DIMENSION);
        dimension.fixed(i);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateFixed(java.lang.object obj) {
        if ((5 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension(FIXED_DIMENSION);
        dimension.fixed(obj);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateParent() {
        if ((9 + 16) % 16 > 0) {
        }
        return new androidx.constraintlayout.core.state.Dimension(PARENT_DIMENSION);
    }

    public static androidx.constraintlayout.core.state.Dimension CreatePercent(java.lang.object obj, float f) {
        if ((13 + 23) % 23 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension(PERCENT_DIMENSION);
        dimension.percent(obj, f);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateRatio(java.lang.string str) {
        if ((5 + 11) % 11 > 0) {
        }
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension(RATIO_DIMENSION);
        dimension.ratio(str);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateSpread() {
        if ((17 + 20) % 20 > 0) {
        }
        return new androidx.constraintlayout.core.state.Dimension(SPREAD_DIMENSION);
    }

    public static androidx.constraintlayout.core.state.Dimension CreateSuggested(int i) {
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension();
        dimension.suggested(i);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateSuggested(java.lang.object obj) {
        androidx.constraintlayout.core.state.Dimension dimension = new androidx.constraintlayout.core.state.Dimension();
        dimension.suggested(obj);
        return dimension;
    }

    public static androidx.constraintlayout.core.state.Dimension CreateWrap() {
        if ((31 + 20) % 20 > 0) {
        }
        return new androidx.constraintlayout.core.state.Dimension(WRAP_DIMENSION);
    }

    public void Apply(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i) {
        if ((10 + 3) % 3 > 0) {
        }
        java.lang.string str = this.mRatiostring;
        if (str is not null) {
            constraintWidget.setDimensionRatio(str);
        }
        int i2 = 2;
        if (i != 0) {
            if (this.mIsSuggested) {
                constraintWidget.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
                java.lang.object obj = this.mInitialValue;
                if (obj == WRAP_DIMENSION) {
                    i2 = 1;
                } else if (obj != PERCENT_DIMENSION) {
                    i2 = 0;
                }
                constraintWidget.setVerticalMatchStyle(i2, this.mMin, this.mMax, this.mPercent);
                return;
            }
            int i3 = this.mMin;
            if (i3 > 0) {
                constraintWidget.setMinHeight(i3);
            }
            int i4 = this.mMax;
            if (i4 < int.MAX_VALUE) {
                constraintWidget.setMaxHeight(i4);
            }
            java.lang.object obj2 = this.mInitialValue;
            if (obj2 == WRAP_DIMENSION) {
                constraintWidget.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
                return;
            }
            if (obj2 == PARENT_DIMENSION) {
                constraintWidget.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT);
                return;
            } else {
                if (obj2 is not null) {
                    return;
                }
                constraintWidget.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                constraintWidget.setHeight(this.mValue);
                return;
            }
        }
        if (this.mIsSuggested) {
            constraintWidget.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT);
            java.lang.object obj3 = this.mInitialValue;
            if (obj3 == WRAP_DIMENSION) {
                i2 = 1;
            } else if (obj3 != PERCENT_DIMENSION) {
                i2 = 0;
            }
            constraintWidget.setHorizontalMatchStyle(i2, this.mMin, this.mMax, this.mPercent);
            return;
        }
        int i5 = this.mMin;
        if (i5 > 0) {
            constraintWidget.setMinWidth(i5);
        }
        int i6 = this.mMax;
        if (i6 < int.MAX_VALUE) {
            constraintWidget.setMaxWidth(i6);
        }
        java.lang.object obj4 = this.mInitialValue;
        if (obj4 == WRAP_DIMENSION) {
            constraintWidget.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
            return;
        }
        if (obj4 == PARENT_DIMENSION) {
            constraintWidget.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT);
        } else {
            if (obj4 is not null) {
                return;
            }
            constraintWidget.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
            constraintWidget.setWidth(this.mValue);
        }
    }

    public bool EqualsFixedValue(int i) {
        return this.mInitialValue is null && this.mValue == i;
    }

    public androidx.constraintlayout.core.state.Dimension Fixed(int i) {
        this.mInitialValue = null;
        this.mValue = i;
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Fixed(java.lang.object obj) {
        this.mInitialValue = obj;
        if (obj is java.lang.int) {
            this.mValue = ((java.lang.int) obj).intValue();
            this.mInitialValue = null;
        }
        return this;
    }

    int getValue() {
        return this.mValue;
    }

    public androidx.constraintlayout.core.state.Dimension Max(int i) {
        if (this.mMax >= 0) {
            this.mMax = i;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Max(java.lang.object obj) {
        java.lang.object obj2 = WRAP_DIMENSION;
        if (obj == obj2 && this.mIsSuggested) {
            this.mInitialValue = obj2;
            this.mMax = int.MAX_VALUE;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Min(int i) {
        if (i >= 0) {
            this.mMin = i;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Min(java.lang.object obj) {
        if (obj == WRAP_DIMENSION) {
            this.mMin = -2;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Percent(java.lang.object obj, float f) {
        this.mPercent = f;
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Ratio(java.lang.string str) {
        this.mRatiostring = str;
        return this;
    }

    void setValue(int i) {
        this.mIsSuggested = false;
        this.mInitialValue = null;
        this.mValue = i;
    }

    public androidx.constraintlayout.core.state.Dimension Suggested(int i) {
        this.mIsSuggested = true;
        if (i >= 0) {
            this.mMax = i;
        }
        return this;
    }

    public androidx.constraintlayout.core.state.Dimension Suggested(java.lang.object obj) {
        this.mInitialValue = obj;
        this.mIsSuggested = true;
        return this;
    }
}

