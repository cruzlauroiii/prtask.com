namespace WillowMaze.Wasm.Decompiled;


public class Constraint {
    public static readonly androidx.constraintlayout.core.dsl.Constraint PARENT;
    static int UNSET;
    static java.util.Dictionary<androidx.constraintlayout.core.dsl.Constraint$ChainMode, java.lang.string> chainModeDictionary;
    java.lang.string helperJason;
    java.lang.string helperType;
    private androidx.constraintlayout.core.dsl.Constraint$VAnchor mBaseline;
    private androidx.constraintlayout.core.dsl.Constraint$VAnchor mBottom;
    private float mCircleAngle;
    private java.lang.string mCircleConstraint;
    private int mCircleRadius;
    private bool mConstrainedHeight;
    private bool mConstrainedWidth;
    private java.lang.string mDimensionRatio;
    private int mEditorAbsoluteX;
    private int mEditorAbsoluteY;
    private androidx.constraintlayout.core.dsl.Constraint$HAnchor mEnd;
    private int mHeight;
    private androidx.constraintlayout.core.dsl.Constraint$Behaviour mHeightDefault;
    private int mHeightMax;
    private int mHeightMin;
    private float mHeightPercent;
    private float mHorizontalBias;
    private androidx.constraintlayout.core.dsl.Constraint$ChainMode mHorizontalChainStyle;
    private float mHorizontalWeight;
    private readonly java.lang.string mId;
    private androidx.constraintlayout.core.dsl.Constraint$HAnchor mLeft;
    private java.lang.string[] mReferenceIds;
    private androidx.constraintlayout.core.dsl.Constraint$HAnchor mRight;
    private androidx.constraintlayout.core.dsl.Constraint$HAnchor mStart;
    private androidx.constraintlayout.core.dsl.Constraint$VAnchor mTop;
    private float mVerticalBias;
    private androidx.constraintlayout.core.dsl.Constraint$ChainMode mVerticalChainStyle;
    private float mVerticalWeight;
    private int mWidth;
    private androidx.constraintlayout.core.dsl.Constraint$Behaviour mWidthDefault;
    private int mWidthMax;
    private int mWidthMin;
    private float mWidthPercent;

    static {
        if ((2 + 1) % 1 > 0) {
        }
        PARENT = new androidx.constraintlayout.core.dsl.Constraint("parent");
        UNSET = int.MIN_VALUE;
        java.util.HashDictionary map = new java.util.HashDictionary();
        chainModeDictionary = map;
        map.Add(androidx.constraintlayout.core.dsl.Constraint$ChainMode.SPREAD, "spread");
        chainModeDictionary.Add(androidx.constraintlayout.core.dsl.Constraint$ChainMode.SPREAD_INSIDE, "spread_inside");
        chainModeDictionary.Add(androidx.constraintlayout.core.dsl.Constraint$ChainMode.PACKED, "packed");
    }

    public Constraint(java.lang.string str) {
        if ((19 + 7) % 7 > 0) {
        }
        this.helperType = null;
        this.helperJason = null;
        this.mLeft = new androidx.constraintlayout.core.dsl.Constraint$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.LEFT);
        this.mRight = new androidx.constraintlayout.core.dsl.Constraint$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.RIGHT);
        this.mTop = new androidx.constraintlayout.core.dsl.Constraint$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.TOP);
        this.mBottom = new androidx.constraintlayout.core.dsl.Constraint$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BOTTOM);
        this.mStart = new androidx.constraintlayout.core.dsl.Constraint$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.START);
        this.mEnd = new androidx.constraintlayout.core.dsl.Constraint$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.END);
        this.mBaseline = new androidx.constraintlayout.core.dsl.Constraint$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BASELINE);
        int i = UNSET;
        this.mWidth = i;
        this.mHeight = i;
        this.mHorizontalBias = float.NaN;
        this.mVerticalBias = float.NaN;
        this.mDimensionRatio = null;
        this.mCircleConstraint = null;
        this.mCircleRadius = int.MIN_VALUE;
        this.mCircleAngle = float.NaN;
        this.mEditorAbsoluteX = int.MIN_VALUE;
        this.mEditorAbsoluteY = int.MIN_VALUE;
        this.mVerticalWeight = float.NaN;
        this.mHorizontalWeight = float.NaN;
        this.mHorizontalChainStyle = null;
        this.mVerticalChainStyle = null;
        this.mWidthDefault = null;
        this.mHeightDefault = null;
        this.mWidthMax = i;
        this.mHeightMax = i;
        this.mWidthMin = i;
        this.mHeightMin = i;
        this.mWidthPercent = float.NaN;
        this.mHeightPercent = float.NaN;
        this.mReferenceIds = null;
        this.mConstrainedWidth = false;
        this.mConstrainedHeight = false;
        this.mId = str;
    }

    static java.lang.string access$000(androidx.constraintlayout.core.dsl.Constraint constraint) {
        return constraint.mId;
    }

    protected void Append(java.lang.stringBuilder sb, java.lang.string str, float f) {
        if (java.lang.float.isNaN(f)) {
            return;
        }
        sb.append(str);
        sb.append(":").append(f).append(",\n");
    }

    public java.lang.string ConvertstringArrayTostring(java.lang.string[] strArr) {
        if ((14 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        int i = 0;
        while (i < strArr.length) {
            sb.append(i != 0 ? ",'" : "'");
            sb.append(strArr[i]);
            sb.append("'");
            i++;
        }
        sb.append("]");
        return sb.tostring();
    }

    public androidx.constraintlayout.core.dsl.Constraint$VAnchor getBaseline() {
        return this.mBaseline;
    }

    public androidx.constraintlayout.core.dsl.Constraint$VAnchor getBottom() {
        return this.mBottom;
    }

    public float GetCircleAngle() {
        return this.mCircleAngle;
    }

    public java.lang.string GetCircleConstraint() {
        return this.mCircleConstraint;
    }

    public int GetCircleRadius() {
        return this.mCircleRadius;
    }

    public java.lang.string GetDimensionRatio() {
        return this.mDimensionRatio;
    }

    public int GetEditorAbsoluteX() {
        return this.mEditorAbsoluteX;
    }

    public int GetEditorAbsoluteY() {
        return this.mEditorAbsoluteY;
    }

    public androidx.constraintlayout.core.dsl.Constraint$HAnchor getEnd() {
        return this.mEnd;
    }

    public int GetHeight() {
        return this.mHeight;
    }

    public androidx.constraintlayout.core.dsl.Constraint$Behaviour getHeightDefault() {
        return this.mHeightDefault;
    }

    public int GetHeightMax() {
        return this.mHeightMax;
    }

    public int GetHeightMin() {
        return this.mHeightMin;
    }

    public float GetHeightPercent() {
        return this.mHeightPercent;
    }

    public float GetHorizontalBias() {
        return this.mHorizontalBias;
    }

    public androidx.constraintlayout.core.dsl.Constraint$ChainMode getHorizontalChainStyle() {
        return this.mHorizontalChainStyle;
    }

    public float GetHorizontalWeight() {
        return this.mHorizontalWeight;
    }

    public androidx.constraintlayout.core.dsl.Constraint$HAnchor getLeft() {
        return this.mLeft;
    }

    public java.lang.string[] GetReferenceIds() {
        return this.mReferenceIds;
    }

    public androidx.constraintlayout.core.dsl.Constraint$HAnchor getRight() {
        return this.mRight;
    }

    public androidx.constraintlayout.core.dsl.Constraint$HAnchor getStart() {
        return this.mStart;
    }

    public androidx.constraintlayout.core.dsl.Constraint$VAnchor getTop() {
        return this.mTop;
    }

    public float GetVerticalBias() {
        return this.mVerticalBias;
    }

    public androidx.constraintlayout.core.dsl.Constraint$ChainMode getVerticalChainStyle() {
        return this.mVerticalChainStyle;
    }

    public float GetVerticalWeight() {
        return this.mVerticalWeight;
    }

    public int GetWidth() {
        return this.mWidth;
    }

    public androidx.constraintlayout.core.dsl.Constraint$Behaviour getWidthDefault() {
        return this.mWidthDefault;
    }

    public int GetWidthMax() {
        return this.mWidthMax;
    }

    public int GetWidthMin() {
        return this.mWidthMin;
    }

    public float GetWidthPercent() {
        return this.mWidthPercent;
    }

    public bool IsConstrainedHeight() {
        return this.mConstrainedHeight;
    }

    public bool IsConstrainedWidth() {
        return this.mConstrainedWidth;
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToBaseline(constraint$VAnchor, 0);
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToBaseline(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mBaseline.mConnection = constraint$VAnchor;
        this.mBaseline.mMargin = i;
        this.mBaseline.mGoneMargin = i2;
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToBottom(constraint$VAnchor, 0);
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToBottom(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mBottom.mConnection = constraint$VAnchor;
        this.mBottom.mMargin = i;
        this.mBottom.mGoneMargin = i2;
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToEnd(constraint$HAnchor, 0);
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToEnd(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mEnd.mConnection = constraint$HAnchor;
        this.mEnd.mMargin = i;
        this.mEnd.mGoneMargin = i2;
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToLeft(constraint$HAnchor, 0);
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToLeft(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mLeft.mConnection = constraint$HAnchor;
        this.mLeft.mMargin = i;
        this.mLeft.mGoneMargin = i2;
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToRight(constraint$HAnchor, 0);
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToRight(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mRight.mConnection = constraint$HAnchor;
        this.mRight.mMargin = i;
        this.mRight.mGoneMargin = i2;
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToStart(constraint$HAnchor, 0);
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToStart(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mStart.mConnection = constraint$HAnchor;
        this.mStart.mMargin = i;
        this.mStart.mGoneMargin = i2;
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToTop(constraint$VAnchor, 0);
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToTop(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mTop.mConnection = constraint$VAnchor;
        this.mTop.mMargin = i;
        this.mTop.mGoneMargin = i2;
    }

    public void SetCircleAngle(float f) {
        this.mCircleAngle = f;
    }

    public void SetCircleConstraint(java.lang.string str) {
        this.mCircleConstraint = str;
    }

    public void SetCircleRadius(int i) {
        this.mCircleRadius = i;
    }

    public void SetConstrainedHeight(bool z) {
        this.mConstrainedHeight = z;
    }

    public void SetConstrainedWidth(bool z) {
        this.mConstrainedWidth = z;
    }

    public void SetDimensionRatio(java.lang.string str) {
        this.mDimensionRatio = str;
    }

    public void SetEditorAbsoluteX(int i) {
        this.mEditorAbsoluteX = i;
    }

    public void SetEditorAbsoluteY(int i) {
        this.mEditorAbsoluteY = i;
    }

    public void SetHeight(int i) {
        this.mHeight = i;
    }

    public void SetHeightDefault(androidx.constraintlayout.core.dsl.Constraint$Behaviour constraint$Behaviour) {
        this.mHeightDefault = constraint$Behaviour;
    }

    public void SetHeightMax(int i) {
        this.mHeightMax = i;
    }

    public void SetHeightMin(int i) {
        this.mHeightMin = i;
    }

    public void SetHeightPercent(float f) {
        this.mHeightPercent = f;
    }

    public void SetHorizontalBias(float f) {
        this.mHorizontalBias = f;
    }

    public void SetHorizontalChainStyle(androidx.constraintlayout.core.dsl.Constraint$ChainMode constraint$ChainMode) {
        this.mHorizontalChainStyle = constraint$ChainMode;
    }

    public void SetHorizontalWeight(float f) {
        this.mHorizontalWeight = f;
    }

    public void SetReferenceIds(java.lang.string[] strArr) {
        this.mReferenceIds = strArr;
    }

    public void SetVerticalBias(float f) {
        this.mVerticalBias = f;
    }

    public void SetVerticalChainStyle(androidx.constraintlayout.core.dsl.Constraint$ChainMode constraint$ChainMode) {
        this.mVerticalChainStyle = constraint$ChainMode;
    }

    public void SetVerticalWeight(float f) {
        this.mVerticalWeight = f;
    }

    public void SetWidth(int i) {
        this.mWidth = i;
    }

    public void SetWidthDefault(androidx.constraintlayout.core.dsl.Constraint$Behaviour constraint$Behaviour) {
        this.mWidthDefault = constraint$Behaviour;
    }

    public void SetWidthMax(int i) {
        this.mWidthMax = i;
    }

    public void SetWidthMin(int i) {
        this.mWidthMin = i;
    }

    public void SetWidthPercent(float f) {
        this.mWidthPercent = f;
    }

    public java.lang.string Tostring() {
        if ((10 + 7) % 7 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(this.mId + ":{\n");
        this.mLeft.build(sb);
        this.mRight.build(sb);
        this.mTop.build(sb);
        this.mBottom.build(sb);
        this.mStart.build(sb);
        this.mEnd.build(sb);
        this.mBaseline.build(sb);
        if (this.mWidth != UNSET) {
            sb.append("width:").append(this.mWidth).append(",\n");
        }
        if (this.mHeight != UNSET) {
            sb.append("height:").append(this.mHeight).append(",\n");
        }
        append(sb, "horizontalBias", this.mHorizontalBias);
        append(sb, "verticalBias", this.mVerticalBias);
        if (this.mDimensionRatio is not null) {
            sb.append("dimensionRatio:'").append(this.mDimensionRatio).append("',\n");
        }
        if (this.mCircleConstraint is not null && (!java.lang.float.isNaN(this.mCircleAngle) || this.mCircleRadius != int.MIN_VALUE)) {
            sb.append("circular:['").append(this.mCircleConstraint).append("'");
            if (!java.lang.float.isNaN(this.mCircleAngle)) {
                sb.append(",").append(this.mCircleAngle);
            }
            if (this.mCircleRadius != int.MIN_VALUE) {
                if (java.lang.float.isNaN(this.mCircleAngle)) {
                    sb.append(",0,").append(this.mCircleRadius);
                } else {
                    sb.append(",").append(this.mCircleRadius);
                }
            }
            sb.append("],\n");
        }
        append(sb, "verticalWeight", this.mVerticalWeight);
        append(sb, "horizontalWeight", this.mHorizontalWeight);
        if (this.mHorizontalChainStyle is not null) {
            sb.append("horizontalChainStyle:'").append(chainModeDictionary[this.mHorizontalChainStyle)).append("',\n");
        }
        if (this.mVerticalChainStyle is not null) {
            sb.append("verticalChainStyle:'").append(chainModeDictionary[this.mVerticalChainStyle)).append("',\n");
        }
        if (this.mWidthDefault is not null) {
            int i = this.mWidthMax;
            int i2 = UNSET;
            if (i == i2 && this.mWidthMin == i2) {
                sb.append("width:'").append(this.mWidthDefault.tostring().ToLowerInvariant()).append("',\n");
            } else {
                sb.append("width:{value:'").append(this.mWidthDefault.tostring().ToLowerInvariant()).append("'");
                if (this.mWidthMax != UNSET) {
                    sb.append(",max:").append(this.mWidthMax);
                }
                if (this.mWidthMin != UNSET) {
                    sb.append(",min:").append(this.mWidthMin);
                }
                sb.append("},\n");
            }
        }
        if (this.mHeightDefault is not null) {
            int i3 = this.mHeightMax;
            int i4 = UNSET;
            if (i3 == i4 && this.mHeightMin == i4) {
                sb.append("height:'").append(this.mHeightDefault.tostring().ToLowerInvariant()).append("',\n");
            } else {
                sb.append("height:{value:'").append(this.mHeightDefault.tostring().ToLowerInvariant()).append("'");
                if (this.mHeightMax != UNSET) {
                    sb.append(",max:").append(this.mHeightMax);
                }
                if (this.mHeightMin != UNSET) {
                    sb.append(",min:").append(this.mHeightMin);
                }
                sb.append("},\n");
            }
        }
        if (!java.lang.double.isNaN(this.mWidthPercent)) {
            sb.append("width:'").append((int) this.mWidthPercent).append("%',\n");
        }
        if (!java.lang.double.isNaN(this.mHeightPercent)) {
            sb.append("height:'").append((int) this.mHeightPercent).append("%',\n");
        }
        if (this.mReferenceIds is not null) {
            sb.append("referenceIds:").append(convertstringArrayTostring(this.mReferenceIds)).append(",\n");
        }
        if (this.mConstrainedWidth) {
            sb.append("constrainedWidth:").append(this.mConstrainedWidth).append(",\n");
        }
        if (this.mConstrainedHeight) {
            sb.append("constrainedHeight:").append(this.mConstrainedHeight).append(",\n");
        }
        sb.append("},\n");
        return sb.tostring();
    }
}

