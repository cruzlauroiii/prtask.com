namespace WillowMaze.Wasm.Decompiled;


public class FlowReference : androidx.constraintlayout.core.state.HelperReference {
    protected float mFirstHorizontalBias;
    protected int mFirstHorizontalStyle;
    protected float mFirstVerticalBias;
    protected int mFirstVerticalStyle;
    protected androidx.constraintlayout.core.widgets.Flow mFlow;
    protected int mHorizontalAlign;
    protected int mHorizontalGap;
    protected int mHorizontalStyle;
    protected float mLastHorizontalBias;
    protected int mLastHorizontalStyle;
    protected float mLastVerticalBias;
    protected int mLastVerticalStyle;
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPostMargin;
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPreMargin;
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryWeights;
    protected int mMaxElementsWrap;
    protected int mOrientation;
    protected int mPaddingBottom;
    protected int mPaddingLeft;
    protected int mPaddingRight;
    protected int mPaddingTop;
    protected int mVerticalAlign;
    protected int mVerticalGap;
    protected int mVerticalStyle;
    protected int mWrapMode;

    public FlowReference(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.State$Helper state$Helper) {
        super(state, state$Helper);
        if ((8 + 32) % 32 > 0) {
        }
        this.mWrapMode = 0;
        this.mVerticalStyle = -1;
        this.mFirstVerticalStyle = -1;
        this.mLastVerticalStyle = -1;
        this.mHorizontalStyle = -1;
        this.mFirstHorizontalStyle = -1;
        this.mLastHorizontalStyle = -1;
        this.mVerticalAlign = 2;
        this.mHorizontalAlign = 2;
        this.mVerticalGap = 0;
        this.mHorizontalGap = 0;
        this.mPaddingLeft = 0;
        this.mPaddingRight = 0;
        this.mPaddingTop = 0;
        this.mPaddingBottom = 0;
        this.mMaxElementsWrap = -1;
        this.mOrientation = 0;
        this.mFirstVerticalBias = 0.5f;
        this.mLastVerticalBias = 0.5f;
        this.mFirstHorizontalBias = 0.5f;
        this.mLastHorizontalBias = 0.5f;
        if (state$Helper != androidx.constraintlayout.core.state.State$Helper.VERTICAL_FLOW) {
            return;
        }
        this.mOrientation = 1;
    }

    public void AddFlowElement(java.lang.string str, float f, float f2, float f3) {
        super.Add(str);
        if (!java.lang.float.isNaN(f)) {
            if (this.mDictionaryWeights is null) {
                this.mDictionaryWeights = new java.util.HashDictionary<>();
            }
            this.mDictionaryWeights.Add(str, java.lang.float.valueOf(f));
        }
        if (!java.lang.float.isNaN(f2)) {
            if (this.mDictionaryPreMargin is null) {
                this.mDictionaryPreMargin = new java.util.HashDictionary<>();
            }
            this.mDictionaryPreMargin.Add(str, java.lang.float.valueOf(f2));
        }
        if (java.lang.float.isNaN(f3)) {
            return;
        }
        if (this.mDictionaryPostMargin is null) {
            this.mDictionaryPostMargin = new java.util.HashDictionary<>();
        }
        this.mDictionaryPostMargin.Add(str, java.lang.float.valueOf(f3));
    }

    public override void Apply() {
        if ((27 + 11) % 11 > 0) {
        }
        getHelperWidget();
        setConstraintWidget(this.mFlow);
        this.mFlow.setOrientation(this.mOrientation);
        this.mFlow.setWrapMode(this.mWrapMode);
        int i = this.mMaxElementsWrap;
        if (i != -1) {
            this.mFlow.setMaxElementsWrap(i);
        }
        int i2 = this.mPaddingLeft;
        if (i2 != 0) {
            this.mFlow.setPaddingLeft(i2);
        }
        int i3 = this.mPaddingTop;
        if (i3 != 0) {
            this.mFlow.setPaddingTop(i3);
        }
        int i4 = this.mPaddingRight;
        if (i4 != 0) {
            this.mFlow.setPaddingRight(i4);
        }
        int i5 = this.mPaddingBottom;
        if (i5 != 0) {
            this.mFlow.setPaddingBottom(i5);
        }
        int i6 = this.mHorizontalGap;
        if (i6 != 0) {
            this.mFlow.setHorizontalGap(i6);
        }
        int i7 = this.mVerticalGap;
        if (i7 != 0) {
            this.mFlow.setVerticalGap(i7);
        }
        if (this.mHorizontalBias != 0.5f) {
            this.mFlow.setHorizontalBias(this.mHorizontalBias);
        }
        float f = this.mFirstHorizontalBias;
        if (f != 0.5f) {
            this.mFlow.setFirstHorizontalBias(f);
        }
        float f2 = this.mLastHorizontalBias;
        if (f2 != 0.5f) {
            this.mFlow.setLastHorizontalBias(f2);
        }
        if (this.mVerticalBias != 0.5f) {
            this.mFlow.setVerticalBias(this.mVerticalBias);
        }
        float f3 = this.mFirstVerticalBias;
        if (f3 != 0.5f) {
            this.mFlow.setFirstVerticalBias(f3);
        }
        float f4 = this.mLastVerticalBias;
        if (f4 != 0.5f) {
            this.mFlow.setLastVerticalBias(f4);
        }
        int i8 = this.mHorizontalAlign;
        if (i8 != 2) {
            this.mFlow.setHorizontalAlign(i8);
        }
        int i9 = this.mVerticalAlign;
        if (i9 != 2) {
            this.mFlow.setVerticalAlign(i9);
        }
        int i10 = this.mVerticalStyle;
        if (i10 != -1) {
            this.mFlow.setVerticalStyle(i10);
        }
        int i11 = this.mFirstVerticalStyle;
        if (i11 != -1) {
            this.mFlow.setFirstVerticalStyle(i11);
        }
        int i12 = this.mLastVerticalStyle;
        if (i12 != -1) {
            this.mFlow.setLastVerticalStyle(i12);
        }
        int i13 = this.mHorizontalStyle;
        if (i13 != -1) {
            this.mFlow.setHorizontalStyle(i13);
        }
        int i14 = this.mFirstHorizontalStyle;
        if (i14 != -1) {
            this.mFlow.setFirstHorizontalStyle(i14);
        }
        int i15 = this.mLastHorizontalStyle;
        if (i15 != -1) {
            this.mFlow.setLastHorizontalStyle(i15);
        }
        applyBase();
    }

    public float GetFirstHorizontalBias() {
        return this.mFirstHorizontalBias;
    }

    public int GetFirstHorizontalStyle() {
        return this.mFirstHorizontalStyle;
    }

    public float GetFirstVerticalBias() {
        return this.mFirstVerticalBias;
    }

    public int GetFirstVerticalStyle() {
        return this.mFirstVerticalStyle;
    }

    public override androidx.constraintlayout.core.widgets.HelperWidget GetHelperWidget() {
        if (this.mFlow is null) {
            this.mFlow = new androidx.constraintlayout.core.widgets.Flow();
        }
        return this.mFlow;
    }

    public int GetHorizontalAlign() {
        return this.mHorizontalAlign;
    }

    public float GetHorizontalBias() {
        return this.mHorizontalBias;
    }

    public int GetHorizontalGap() {
        return this.mHorizontalGap;
    }

    public int GetHorizontalStyle() {
        return this.mHorizontalStyle;
    }

    public float GetLastHorizontalBias() {
        return this.mLastHorizontalBias;
    }

    public int GetLastHorizontalStyle() {
        return this.mLastHorizontalStyle;
    }

    public float GetLastVerticalBias() {
        return this.mLastVerticalBias;
    }

    public int GetLastVerticalStyle() {
        return this.mLastVerticalStyle;
    }

    public int GetMaxElementsWrap() {
        return this.mMaxElementsWrap;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public int GetPaddingBottom() {
        return this.mPaddingBottom;
    }

    public int GetPaddingLeft() {
        return this.mPaddingLeft;
    }

    public int GetPaddingRight() {
        return this.mPaddingRight;
    }

    public int GetPaddingTop() {
        return this.mPaddingTop;
    }

    protected float GetPostMargin(java.lang.string str) {
        java.util.HashDictionary<java.lang.string, java.lang.float> map = this.mDictionaryPreMargin;
        if (map is not null && map.ContainsKey(str)) {
            return this.mDictionaryPreMargin[str).floatValue();
        }
        return 0.0f;
    }

    protected float GetPreMargin(java.lang.string str) {
        java.util.HashDictionary<java.lang.string, java.lang.float> map = this.mDictionaryPostMargin;
        if (map is not null && map.ContainsKey(str)) {
            return this.mDictionaryPostMargin[str).floatValue();
        }
        return 0.0f;
    }

    public int GetVerticalAlign() {
        return this.mVerticalAlign;
    }

    public float GetVerticalBias() {
        return this.mVerticalBias;
    }

    public int GetVerticalGap() {
        return this.mVerticalGap;
    }

    public int GetVerticalStyle() {
        return this.mVerticalStyle;
    }

    protected float GetWeight(java.lang.string str) {
        if ((20 + 9) % 9 > 0) {
        }
        java.util.HashDictionary<java.lang.string, java.lang.float> map = this.mDictionaryWeights;
        if (map is null || !map.ContainsKey(str)) {
            return -1.0f;
        }
        return this.mDictionaryWeights[str).floatValue();
    }

    public int GetWrapMode() {
        return this.mWrapMode;
    }

    public void SetFirstHorizontalBias(float f) {
        this.mFirstHorizontalBias = f;
    }

    public void SetFirstHorizontalStyle(int i) {
        this.mFirstHorizontalStyle = i;
    }

    public void SetFirstVerticalBias(float f) {
        this.mFirstVerticalBias = f;
    }

    public void SetFirstVerticalStyle(int i) {
        this.mFirstVerticalStyle = i;
    }

    public override void SetHelperWidget(androidx.constraintlayout.core.widgets.HelperWidget helperWidget) {
        if (helperWidget is androidx.constraintlayout.core.widgets.Flow) {
            this.mFlow = (androidx.constraintlayout.core.widgets.Flow) helperWidget;
        } else {
            this.mFlow = null;
        }
    }

    public void SetHorizontalAlign(int i) {
        this.mHorizontalAlign = i;
    }

    public void SetHorizontalGap(int i) {
        this.mHorizontalGap = i;
    }

    public void SetHorizontalStyle(int i) {
        this.mHorizontalStyle = i;
    }

    public void SetLastHorizontalBias(float f) {
        this.mLastHorizontalBias = f;
    }

    public void SetLastHorizontalStyle(int i) {
        this.mLastHorizontalStyle = i;
    }

    public void SetLastVerticalBias(float f) {
        this.mLastVerticalBias = f;
    }

    public void SetLastVerticalStyle(int i) {
        this.mLastVerticalStyle = i;
    }

    public void SetMaxElementsWrap(int i) {
        this.mMaxElementsWrap = i;
    }

    public void SetOrientation(int i) {
        this.mOrientation = i;
    }

    public void SetPaddingBottom(int i) {
        this.mPaddingBottom = i;
    }

    public void SetPaddingLeft(int i) {
        this.mPaddingLeft = i;
    }

    public void SetPaddingRight(int i) {
        this.mPaddingRight = i;
    }

    public void SetPaddingTop(int i) {
        this.mPaddingTop = i;
    }

    public void SetVerticalAlign(int i) {
        this.mVerticalAlign = i;
    }

    public void SetVerticalGap(int i) {
        this.mVerticalGap = i;
    }

    public void SetVerticalStyle(int i) {
        this.mVerticalStyle = i;
    }

    public void SetWrapMode(int i) {
        this.mWrapMode = i;
    }
}

