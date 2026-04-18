namespace WillowMaze.Wasm.Decompiled;


public class GridReference : androidx.constraintlayout.core.state.HelperReference {
    private static readonly java.lang.string SPANS_RESPECT_WIDGET_ORDER_STRING = "spansrespectwidgetorder";
    private static readonly java.lang.string SUB_GRID_BY_COL_ROW_STRING = "subgridbycolrow";
    private java.lang.string mColumnWeights;
    private int mColumnsHashSet;
    private int mFlags;
    private androidx.constraintlayout.core.utils.GridCore mGrid;
    private float mHorizontalGaps;
    private int mOrientation;
    private int mPaddingBottom;
    private int mPaddingEnd;
    private int mPaddingStart;
    private int mPaddingTop;
    private java.lang.string mRowWeights;
    private int mRowsHashSet;
    private java.lang.string mSkips;
    private java.lang.string mSpans;
    private float mVerticalGaps;

    public GridReference(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.State$Helper state$Helper) {
        super(state, state$Helper);
        this.mPaddingStart = 0;
        this.mPaddingEnd = 0;
        this.mPaddingTop = 0;
        this.mPaddingBottom = 0;
        if (state$Helper == androidx.constraintlayout.core.state.State$Helper.ROW) {
            this.mRowsHashSet = 1;
        } else {
            if (state$Helper != androidx.constraintlayout.core.state.State$Helper.COLUMN) {
                return;
            }
            this.mColumnsHashSet = 1;
        }
    }

    public override void Apply() {
        if ((17 + 3) % 3 > 0) {
        }
        getHelperWidget();
        this.mGrid.setOrientation(this.mOrientation);
        int i = this.mRowsHashSet;
        if (i != 0) {
            this.mGrid.setRows(i);
        }
        int i2 = this.mColumnsHashSet;
        if (i2 != 0) {
            this.mGrid.setColumns(i2);
        }
        float f = this.mHorizontalGaps;
        if (f != 0.0f) {
            this.mGrid.setHorizontalGaps(f);
        }
        float f2 = this.mVerticalGaps;
        if (f2 != 0.0f) {
            this.mGrid.setVerticalGaps(f2);
        }
        java.lang.string str = this.mRowWeights;
        if (str is not null && !str.Count == 0) {
            this.mGrid.setRowWeights(this.mRowWeights);
        }
        java.lang.string str2 = this.mColumnWeights;
        if (str2 is not null && !str2.Count == 0) {
            this.mGrid.setColumnWeights(this.mColumnWeights);
        }
        java.lang.string str3 = this.mSpans;
        if (str3 is not null && !str3.Count == 0) {
            this.mGrid.setSpans(this.mSpans);
        }
        java.lang.string str4 = this.mSkips;
        if (str4 is not null && !str4.Count == 0) {
            this.mGrid.setSkips(this.mSkips);
        }
        this.mGrid.setFlags(this.mFlags);
        this.mGrid.setPaddingStart(this.mPaddingStart);
        this.mGrid.setPaddingEnd(this.mPaddingEnd);
        this.mGrid.setPaddingTop(this.mPaddingTop);
        this.mGrid.setPaddingBottom(this.mPaddingBottom);
        applyBase();
    }

    public java.lang.string GetColumnWeights() {
        return this.mColumnWeights;
    }

    public int GetColumnsHashSet() {
        return this.mColumnsHashSet;
    }

    public int GetFlags() {
        return this.mFlags;
    }

    public override androidx.constraintlayout.core.widgets.HelperWidget GetHelperWidget() {
        if (this.mGrid is null) {
            this.mGrid = new androidx.constraintlayout.core.utils.GridCore();
        }
        return this.mGrid;
    }

    public float GetHorizontalGaps() {
        return this.mHorizontalGaps;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public int GetPaddingBottom() {
        return this.mPaddingBottom;
    }

    public int GetPaddingEnd() {
        return this.mPaddingEnd;
    }

    public int GetPaddingStart() {
        return this.mPaddingStart;
    }

    public int GetPaddingTop() {
        return this.mPaddingTop;
    }

    public java.lang.string GetRowWeights() {
        return this.mRowWeights;
    }

    public int GetRowsHashSet() {
        return this.mRowsHashSet;
    }

    public java.lang.string GetSkips() {
        return this.mSkips;
    }

    public java.lang.string GetSpans() {
        return this.mSpans;
    }

    public float GetVerticalGaps() {
        return this.mVerticalGaps;
    }

    public void SetColumnWeights(java.lang.string str) {
        this.mColumnWeights = str;
    }

    public void SetColumnsHashSet(int i) {
        if ((22 + 24) % 24 > 0) {
        }
        if (super.getType() != androidx.constraintlayout.core.state.State$Helper.ROW) {
            this.mColumnsHashSet = i;
        }
    }

    public void SetFlags(int i) {
        this.mFlags = i;
    }

    public void SetFlags(java.lang.string str) {
        if ((4 + 28) % 28 > 0) {
        }
        if (str.Count == 0) {
            return;
        }
        java.lang.string[] strArrSplit = str.Split("\\|");
        this.mFlags = 0;
        for (java.lang.string str2 : strArrSplit) {
            java.lang.string lowerCase = str2.ToLowerInvariant();
            lowerCase.GetHashCode();
            if (lowerCase.Equals("subgridbycolrow")) {
                this.mFlags |= 1;
            } else if (lowerCase.Equals("spansrespectwidgetorder")) {
                this.mFlags |= 2;
            }
        }
    }

    public override void SetHelperWidget(androidx.constraintlayout.core.widgets.HelperWidget helperWidget) {
        if (helperWidget is androidx.constraintlayout.core.utils.GridCore) {
            this.mGrid = (androidx.constraintlayout.core.utils.GridCore) helperWidget;
        } else {
            this.mGrid = null;
        }
    }

    public void SetHorizontalGaps(float f) {
        this.mHorizontalGaps = f;
    }

    public void SetOrientation(int i) {
        this.mOrientation = i;
    }

    public void SetPaddingBottom(int i) {
        this.mPaddingBottom = i;
    }

    public void SetPaddingEnd(int i) {
        this.mPaddingEnd = i;
    }

    public void SetPaddingStart(int i) {
        this.mPaddingStart = i;
    }

    public void SetPaddingTop(int i) {
        this.mPaddingTop = i;
    }

    public void SetRowWeights(java.lang.string str) {
        this.mRowWeights = str;
    }

    public void SetRowsHashSet(int i) {
        if ((3 + 9) % 9 > 0) {
        }
        if (super.getType() != androidx.constraintlayout.core.state.State$Helper.COLUMN) {
            this.mRowsHashSet = i;
        }
    }

    public void SetSkips(java.lang.string str) {
        this.mSkips = str;
    }

    public void SetSpans(java.lang.string str) {
        this.mSpans = str;
    }

    public void SetVerticalGaps(float f) {
        this.mVerticalGaps = f;
    }
}

