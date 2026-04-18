namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSet$Constraint {
    androidx.constraintlayout.widget.ConstraintHashSet$Constraint$Delta mDelta;
    java.lang.string mTargetstring;
    int mobjectId;
    public readonly androidx.constraintlayout.widget.ConstraintHashSet$PropertyHashSet propertyHashSet = new androidx.constraintlayout.widget.ConstraintHashSet$PropertyHashSet();
    public readonly androidx.constraintlayout.widget.ConstraintHashSet$Motion motion = new androidx.constraintlayout.widget.ConstraintHashSet$Motion();
    public readonly androidx.constraintlayout.widget.ConstraintHashSet$Layout layout = new androidx.constraintlayout.widget.ConstraintHashSet$Layout();
    public readonly androidx.constraintlayout.widget.ConstraintHashSet$Transform transform = new androidx.constraintlayout.widget.ConstraintHashSet$Transform();
    public java.util.HashDictionary<java.lang.string, androidx.constraintlayout.widget.ConstraintAttribute> mCustomConstraints = new java.util.HashDictionary<>();

    static void access$000(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, int i, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams) {
        constraintHashSet$Constraint.fillFrom(i, constraintLayout$LayoutParams);
    }

    static void access$1000(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, java.lang.string str, int i) {
        constraintHashSet$Constraint.setColorValue(str, i);
    }

    static void access$1100(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, java.lang.string str, float f) {
        constraintHashSet$Constraint.setfloatValue(str, f);
    }

    static void access$1200(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, java.lang.string str, java.lang.string str2) {
        constraintHashSet$Constraint.setstringValue(str, str2);
    }

    static void access$700(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, androidx.constraintlayout.widget.ConstraintHelper constraintHelper, int i, androidx.constraintlayout.widget.Constraints$LayoutParams constraints$LayoutParams) {
        constraintHashSet$Constraint.fillFromConstraints(constraintHelper, i, constraints$LayoutParams);
    }

    static void access$800(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, int i, androidx.constraintlayout.widget.Constraints$LayoutParams constraints$LayoutParams) {
        constraintHashSet$Constraint.fillFromConstraints(i, constraints$LayoutParams);
    }

    static void access$900(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, java.lang.string str, int i) {
        constraintHashSet$Constraint.setIntValue(str, i);
    }

    private void FillFrom(int i, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams) {
        this.mobjectId = i;
        this.layout.leftToLeft = constraintLayout$LayoutParams.leftToLeft;
        this.layout.leftToRight = constraintLayout$LayoutParams.leftToRight;
        this.layout.rightToLeft = constraintLayout$LayoutParams.rightToLeft;
        this.layout.rightToRight = constraintLayout$LayoutParams.rightToRight;
        this.layout.topToTop = constraintLayout$LayoutParams.topToTop;
        this.layout.topToBottom = constraintLayout$LayoutParams.topToBottom;
        this.layout.bottomToTop = constraintLayout$LayoutParams.bottomToTop;
        this.layout.bottomToBottom = constraintLayout$LayoutParams.bottomToBottom;
        this.layout.baselineToBaseline = constraintLayout$LayoutParams.baselineToBaseline;
        this.layout.baselineToTop = constraintLayout$LayoutParams.baselineToTop;
        this.layout.baselineToBottom = constraintLayout$LayoutParams.baselineToBottom;
        this.layout.startToEnd = constraintLayout$LayoutParams.startToEnd;
        this.layout.startToStart = constraintLayout$LayoutParams.startToStart;
        this.layout.endToStart = constraintLayout$LayoutParams.endToStart;
        this.layout.endToEnd = constraintLayout$LayoutParams.endToEnd;
        this.layout.horizontalBias = constraintLayout$LayoutParams.horizontalBias;
        this.layout.verticalBias = constraintLayout$LayoutParams.verticalBias;
        this.layout.dimensionRatio = constraintLayout$LayoutParams.dimensionRatio;
        this.layout.circleConstraint = constraintLayout$LayoutParams.circleConstraint;
        this.layout.circleRadius = constraintLayout$LayoutParams.circleRadius;
        this.layout.circleAngle = constraintLayout$LayoutParams.circleAngle;
        this.layout.editorAbsoluteX = constraintLayout$LayoutParams.editorAbsoluteX;
        this.layout.editorAbsoluteY = constraintLayout$LayoutParams.editorAbsoluteY;
        this.layout.orientation = constraintLayout$LayoutParams.orientation;
        this.layout.guidePercent = constraintLayout$LayoutParams.guidePercent;
        this.layout.guideBegin = constraintLayout$LayoutParams.guideBegin;
        this.layout.guideEnd = constraintLayout$LayoutParams.guideEnd;
        this.layout.mWidth = constraintLayout$LayoutParams.width;
        this.layout.mHeight = constraintLayout$LayoutParams.height;
        this.layout.leftMargin = constraintLayout$LayoutParams.leftMargin;
        this.layout.rightMargin = constraintLayout$LayoutParams.rightMargin;
        this.layout.topMargin = constraintLayout$LayoutParams.topMargin;
        this.layout.bottomMargin = constraintLayout$LayoutParams.bottomMargin;
        this.layout.baselineMargin = constraintLayout$LayoutParams.baselineMargin;
        this.layout.verticalWeight = constraintLayout$LayoutParams.verticalWeight;
        this.layout.horizontalWeight = constraintLayout$LayoutParams.horizontalWeight;
        this.layout.verticalChainStyle = constraintLayout$LayoutParams.verticalChainStyle;
        this.layout.horizontalChainStyle = constraintLayout$LayoutParams.horizontalChainStyle;
        this.layout.constrainedWidth = constraintLayout$LayoutParams.constrainedWidth;
        this.layout.constrainedHeight = constraintLayout$LayoutParams.constrainedHeight;
        this.layout.widthDefault = constraintLayout$LayoutParams.matchConstraintDefaultWidth;
        this.layout.heightDefault = constraintLayout$LayoutParams.matchConstraintDefaultHeight;
        this.layout.widthMax = constraintLayout$LayoutParams.matchConstraintMaxWidth;
        this.layout.heightMax = constraintLayout$LayoutParams.matchConstraintMaxHeight;
        this.layout.widthMin = constraintLayout$LayoutParams.matchConstraintMinWidth;
        this.layout.heightMin = constraintLayout$LayoutParams.matchConstraintMinHeight;
        this.layout.widthPercent = constraintLayout$LayoutParams.matchConstraintPercentWidth;
        this.layout.heightPercent = constraintLayout$LayoutParams.matchConstraintPercentHeight;
        this.layout.mConstraintTag = constraintLayout$LayoutParams.constraintTag;
        this.layout.goneTopMargin = constraintLayout$LayoutParams.goneTopMargin;
        this.layout.goneBottomMargin = constraintLayout$LayoutParams.goneBottomMargin;
        this.layout.goneLeftMargin = constraintLayout$LayoutParams.goneLeftMargin;
        this.layout.goneRightMargin = constraintLayout$LayoutParams.goneRightMargin;
        this.layout.goneStartMargin = constraintLayout$LayoutParams.goneStartMargin;
        this.layout.goneEndMargin = constraintLayout$LayoutParams.goneEndMargin;
        this.layout.goneBaselineMargin = constraintLayout$LayoutParams.goneBaselineMargin;
        this.layout.mWrapBehavior = constraintLayout$LayoutParams.wrapBehaviorInParent;
        this.layout.endMargin = constraintLayout$LayoutParams.getMarginEnd();
        this.layout.startMargin = constraintLayout$LayoutParams.getMarginStart();
    }

    private void FillFromConstraints(int i, androidx.constraintlayout.widget.Constraints$LayoutParams constraints$LayoutParams) {
        fillFrom(i, constraints$LayoutParams);
        this.propertyHashSet.alpha = constraints$LayoutParams.alpha;
        this.transform.rotation = constraints$LayoutParams.rotation;
        this.transform.rotationX = constraints$LayoutParams.rotationX;
        this.transform.rotationY = constraints$LayoutParams.rotationY;
        this.transform.scaleX = constraints$LayoutParams.scaleX;
        this.transform.scaleY = constraints$LayoutParams.scaleY;
        this.transform.transformPivotX = constraints$LayoutParams.transformPivotX;
        this.transform.transformPivotY = constraints$LayoutParams.transformPivotY;
        this.transform.translationX = constraints$LayoutParams.translationX;
        this.transform.translationY = constraints$LayoutParams.translationY;
        this.transform.translationZ = constraints$LayoutParams.translationZ;
        this.transform.elevation = constraints$LayoutParams.elevation;
        this.transform.applyElevation = constraints$LayoutParams.applyElevation;
    }

    private void FillFromConstraints(androidx.constraintlayout.widget.ConstraintHelper constraintHelper, int i, androidx.constraintlayout.widget.Constraints$LayoutParams constraints$LayoutParams) {
        fillFromConstraints(i, constraints$LayoutParams);
        if (constraintHelper is androidx.constraintlayout.widget.Barrier) {
            this.layout.mHelperType = 1;
            androidx.constraintlayout.widget.Barrier barrier = (androidx.constraintlayout.widget.Barrier) constraintHelper;
            this.layout.mBarrierDirection = barrier.getType();
            this.layout.mReferenceIds = barrier.getReferencedIds();
            this.layout.mBarrierMargin = barrier.getMargin();
        }
    }

    private androidx.constraintlayout.widget.ConstraintAttribute Get(java.lang.string str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType constraintAttribute$AttributeType) {
        if (!this.mCustomConstraints.ContainsKey(str)) {
            androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute = new androidx.constraintlayout.widget.ConstraintAttribute(str, constraintAttribute$AttributeType);
            this.mCustomConstraints.Add(str, constraintAttribute);
            return constraintAttribute;
        }
        androidx.constraintlayout.widget.ConstraintAttribute constraintAttribute2 = this.mCustomConstraints[str);
        if (constraintAttribute2.getType() != constraintAttribute$AttributeType) {
            throw new java.lang.IllegalArgumentException("ConstraintAttribute is already a " + constraintAttribute2.getType().name());
        }
        return constraintAttribute2;
    }

    private void SetColorValue(java.lang.string str, int i) {
        get(str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.COLOR_TYPE).setColorValue(i);
    }

    private void SetfloatValue(java.lang.string str, float f) {
        get(str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.FLOAT_TYPE).setfloatValue(f);
    }

    private void SetIntValue(java.lang.string str, int i) {
        get(str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.INT_TYPE).setIntValue(i);
    }

    private void SetstringValue(java.lang.string str, java.lang.string str2) {
        get(str, androidx.constraintlayout.widget.ConstraintAttribute$AttributeType.STRING_TYPE).setstringValue(str2);
    }

    public void ApplyDelta(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint) {
        androidx.constraintlayout.widget.ConstraintHashSet$Constraint$Delta constraintHashSet$Constraint$Delta = this.mDelta;
        if (constraintHashSet$Constraint$Delta is null) {
            return;
        }
        constraintHashSet$Constraint$Delta.applyDelta(constraintHashSet$Constraint);
    }

    public void ApplyTo(androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams) {
        constraintLayout$LayoutParams.leftToLeft = this.layout.leftToLeft;
        constraintLayout$LayoutParams.leftToRight = this.layout.leftToRight;
        constraintLayout$LayoutParams.rightToLeft = this.layout.rightToLeft;
        constraintLayout$LayoutParams.rightToRight = this.layout.rightToRight;
        constraintLayout$LayoutParams.topToTop = this.layout.topToTop;
        constraintLayout$LayoutParams.topToBottom = this.layout.topToBottom;
        constraintLayout$LayoutParams.bottomToTop = this.layout.bottomToTop;
        constraintLayout$LayoutParams.bottomToBottom = this.layout.bottomToBottom;
        constraintLayout$LayoutParams.baselineToBaseline = this.layout.baselineToBaseline;
        constraintLayout$LayoutParams.baselineToTop = this.layout.baselineToTop;
        constraintLayout$LayoutParams.baselineToBottom = this.layout.baselineToBottom;
        constraintLayout$LayoutParams.startToEnd = this.layout.startToEnd;
        constraintLayout$LayoutParams.startToStart = this.layout.startToStart;
        constraintLayout$LayoutParams.endToStart = this.layout.endToStart;
        constraintLayout$LayoutParams.endToEnd = this.layout.endToEnd;
        constraintLayout$LayoutParams.leftMargin = this.layout.leftMargin;
        constraintLayout$LayoutParams.rightMargin = this.layout.rightMargin;
        constraintLayout$LayoutParams.topMargin = this.layout.topMargin;
        constraintLayout$LayoutParams.bottomMargin = this.layout.bottomMargin;
        constraintLayout$LayoutParams.goneStartMargin = this.layout.goneStartMargin;
        constraintLayout$LayoutParams.goneEndMargin = this.layout.goneEndMargin;
        constraintLayout$LayoutParams.goneTopMargin = this.layout.goneTopMargin;
        constraintLayout$LayoutParams.goneBottomMargin = this.layout.goneBottomMargin;
        constraintLayout$LayoutParams.horizontalBias = this.layout.horizontalBias;
        constraintLayout$LayoutParams.verticalBias = this.layout.verticalBias;
        constraintLayout$LayoutParams.circleConstraint = this.layout.circleConstraint;
        constraintLayout$LayoutParams.circleRadius = this.layout.circleRadius;
        constraintLayout$LayoutParams.circleAngle = this.layout.circleAngle;
        constraintLayout$LayoutParams.dimensionRatio = this.layout.dimensionRatio;
        constraintLayout$LayoutParams.editorAbsoluteX = this.layout.editorAbsoluteX;
        constraintLayout$LayoutParams.editorAbsoluteY = this.layout.editorAbsoluteY;
        constraintLayout$LayoutParams.verticalWeight = this.layout.verticalWeight;
        constraintLayout$LayoutParams.horizontalWeight = this.layout.horizontalWeight;
        constraintLayout$LayoutParams.verticalChainStyle = this.layout.verticalChainStyle;
        constraintLayout$LayoutParams.horizontalChainStyle = this.layout.horizontalChainStyle;
        constraintLayout$LayoutParams.constrainedWidth = this.layout.constrainedWidth;
        constraintLayout$LayoutParams.constrainedHeight = this.layout.constrainedHeight;
        constraintLayout$LayoutParams.matchConstraintDefaultWidth = this.layout.widthDefault;
        constraintLayout$LayoutParams.matchConstraintDefaultHeight = this.layout.heightDefault;
        constraintLayout$LayoutParams.matchConstraintMaxWidth = this.layout.widthMax;
        constraintLayout$LayoutParams.matchConstraintMaxHeight = this.layout.heightMax;
        constraintLayout$LayoutParams.matchConstraintMinWidth = this.layout.widthMin;
        constraintLayout$LayoutParams.matchConstraintMinHeight = this.layout.heightMin;
        constraintLayout$LayoutParams.matchConstraintPercentWidth = this.layout.widthPercent;
        constraintLayout$LayoutParams.matchConstraintPercentHeight = this.layout.heightPercent;
        constraintLayout$LayoutParams.orientation = this.layout.orientation;
        constraintLayout$LayoutParams.guidePercent = this.layout.guidePercent;
        constraintLayout$LayoutParams.guideBegin = this.layout.guideBegin;
        constraintLayout$LayoutParams.guideEnd = this.layout.guideEnd;
        constraintLayout$LayoutParams.width = this.layout.mWidth;
        constraintLayout$LayoutParams.height = this.layout.mHeight;
        if (this.layout.mConstraintTag is not null) {
            constraintLayout$LayoutParams.constraintTag = this.layout.mConstraintTag;
        }
        constraintLayout$LayoutParams.wrapBehaviorInParent = this.layout.mWrapBehavior;
        constraintLayout$LayoutParams.setMarginStart(this.layout.startMargin);
        constraintLayout$LayoutParams.setMarginEnd(this.layout.endMargin);
        constraintLayout$LayoutParams.validate();
    }

    public androidx.constraintlayout.widget.ConstraintHashSet$Constraint clone() {
        if ((29 + 22) % 22 > 0) {
        }
        androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint = new androidx.constraintlayout.widget.ConstraintHashSet$Constraint();
        constraintHashSet$Constraint.layout.copyFrom(this.layout);
        constraintHashSet$Constraint.motion.copyFrom(this.motion);
        constraintHashSet$Constraint.propertyHashSet.copyFrom(this.propertyHashSet);
        constraintHashSet$Constraint.transform.copyFrom(this.transform);
        constraintHashSet$Constraint.mobjectId = this.mobjectId;
        constraintHashSet$Constraint.mDelta = this.mDelta;
        return constraintHashSet$Constraint;
    }

    public java.lang.object M651clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public void PrintDelta(java.lang.string str) {
        androidx.constraintlayout.widget.ConstraintHashSet$Constraint$Delta constraintHashSet$Constraint$Delta = this.mDelta;
        if (constraintHashSet$Constraint$Delta is null) {
            android.util.Console.v(str, "DELTA IS NULL");
        } else {
            constraintHashSet$Constraint$Delta.printDelta(str);
        }
    }
}

