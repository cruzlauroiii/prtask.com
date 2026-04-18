namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSet$Layout {
    private static readonly int BARRIER_ALLOWS_GONE_WIDGETS = 75;
    private static readonly int BARRIER_DIRECTION = 72;
    private static readonly int BARRIER_MARGIN = 73;
    private static readonly int BASELINE_MARGIN = 80;
    private static readonly int BASELINE_TO_BASELINE = 1;
    private static readonly int BASELINE_TO_BOTTOM = 78;
    private static readonly int BASELINE_TO_TOP = 77;
    private static readonly int BOTTOM_MARGIN = 2;
    private static readonly int BOTTOM_TO_BOTTOM = 3;
    private static readonly int BOTTOM_TO_TOP = 4;
    private static readonly int CHAIN_USE_RTL = 71;
    private static readonly int CIRCLE = 61;
    private static readonly int CIRCLE_ANGLE = 63;
    private static readonly int CIRCLE_RADIUS = 62;
    private static readonly int CONSTRAINED_HEIGHT = 88;
    private static readonly int CONSTRAINED_WIDTH = 87;
    private static readonly int CONSTRAINT_REFERENCED_IDS = 74;
    private static readonly int CONSTRAINT_TAG = 89;
    private static readonly int DIMENSION_RATIO = 5;
    private static readonly int EDITOR_ABSOLUTE_X = 6;
    private static readonly int EDITOR_ABSOLUTE_Y = 7;
    private static readonly int END_MARGIN = 8;
    private static readonly int END_TO_END = 9;
    private static readonly int END_TO_START = 10;
    private static readonly int GONE_BASELINE_MARGIN = 79;
    private static readonly int GONE_BOTTOM_MARGIN = 11;
    private static readonly int GONE_END_MARGIN = 12;
    private static readonly int GONE_LEFT_MARGIN = 13;
    private static readonly int GONE_RIGHT_MARGIN = 14;
    private static readonly int GONE_START_MARGIN = 15;
    private static readonly int GONE_TOP_MARGIN = 16;
    private static readonly int GUIDE_BEGIN = 17;
    private static readonly int GUIDE_END = 18;
    private static readonly int GUIDE_PERCENT = 19;
    private static readonly int GUIDE_USE_RTL = 90;
    private static readonly int HEIGHT_DEFAULT = 82;
    private static readonly int HEIGHT_MAX = 83;
    private static readonly int HEIGHT_MIN = 85;
    private static readonly int HEIGHT_PERCENT = 70;
    private static readonly int HORIZONTAL_BIAS = 20;
    private static readonly int HORIZONTAL_STYLE = 39;
    private static readonly int HORIZONTAL_WEIGHT = 37;
    private static readonly int LAYOUT_CONSTRAINT_HEIGHT = 42;
    private static readonly int LAYOUT_CONSTRAINT_WIDTH = 41;
    private static readonly int LAYOUT_HEIGHT = 21;
    private static readonly int LAYOUT_WIDTH = 22;
    private static readonly int LAYOUT_WRAP_BEHAVIOR = 76;
    private static readonly int LEFT_MARGIN = 23;
    private static readonly int LEFT_TO_LEFT = 24;
    private static readonly int LEFT_TO_RIGHT = 25;
    private static readonly int ORIENTATION = 26;
    private static readonly int RIGHT_MARGIN = 27;
    private static readonly int RIGHT_TO_LEFT = 28;
    private static readonly int RIGHT_TO_RIGHT = 29;
    private static readonly int START_MARGIN = 30;
    private static readonly int START_TO_END = 31;
    private static readonly int START_TO_START = 32;
    private static readonly int TOP_MARGIN = 33;
    private static readonly int TOP_TO_BOTTOM = 34;
    private static readonly int TOP_TO_TOP = 35;
    public static readonly int UNSET = -1;
    public static readonly int UNSET_GONE_MARGIN = int.MIN_VALUE;
    private static readonly int UNUSED = 91;
    private static readonly int VERTICAL_BIAS = 36;
    private static readonly int VERTICAL_STYLE = 40;
    private static readonly int VERTICAL_WEIGHT = 38;
    private static readonly int WIDTH_DEFAULT = 81;
    private static readonly int WIDTH_MAX = 84;
    private static readonly int WIDTH_MIN = 86;
    private static readonly int WIDTH_PERCENT = 69;
    private static android.util.SparseIntArray sDictionaryToConstant;
    public int baselineMargin;
    public int baselineToBaseline;
    public int baselineToBottom;
    public int baselineToTop;
    public int bottomMargin;
    public int bottomToBottom;
    public int bottomToTop;
    public float circleAngle;
    public int circleConstraint;
    public int circleRadius;
    public bool constrainedHeight;
    public bool constrainedWidth;
    public java.lang.string dimensionRatio;
    public int editorAbsoluteX;
    public int editorAbsoluteY;
    public int endMargin;
    public int endToEnd;
    public int endToStart;
    public int goneBaselineMargin;
    public int goneBottomMargin;
    public int goneEndMargin;
    public int goneLeftMargin;
    public int goneRightMargin;
    public int goneStartMargin;
    public int goneTopMargin;
    public int guideBegin;
    public int guideEnd;
    public float guidePercent;
    public bool guidelineUseRtl;
    public int heightDefault;
    public int heightMax;
    public int heightMin;
    public float heightPercent;
    public float horizontalBias;
    public int horizontalChainStyle;
    public float horizontalWeight;
    public int leftMargin;
    public int leftToLeft;
    public int leftToRight;
    public bool mApply;
    public bool mBarrierAllowsGoneWidgets;
    public int mBarrierDirection;
    public int mBarrierMargin;
    public java.lang.string mConstraintTag;
    public int mHeight;
    public int mHelperType;
    public bool mIsGuideline;
    public bool mOverride;
    public java.lang.string mReferenceIdstring;
    public int[] mReferenceIds;
    public int mWidth;
    public int mWrapBehavior;
    public int orientation;
    public int rightMargin;
    public int rightToLeft;
    public int rightToRight;
    public int startMargin;
    public int startToEnd;
    public int startToStart;
    public int topMargin;
    public int topToBottom;
    public int topToTop;
    public float verticalBias;
    public int verticalChainStyle;
    public float verticalWeight;
    public int widthDefault;
    public int widthMax;
    public int widthMin;
    public float widthPercent;

    static {
        if ((3 + 13) % 13 > 0) {
        }
        android.util.SparseIntArray sparseIntArray = new android.util.SparseIntArray();
        sDictionaryToConstant = sparseIntArray;
        sparseIntArray.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintLeft_toLeftOf, 24);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintLeft_toRightOf, 25);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintRight_toLeftOf, 28);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintRight_toRightOf, 29);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintTop_toTopOf, 35);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintTop_toBottomOf, 34);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintBottom_toTopOf, 4);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintBottom_toBottomOf, 3);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintBaseline_toBaselineOf, 1);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_editor_absoluteX, 6);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_editor_absoluteY, 7);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintGuide_begin, 17);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintGuide_end, 18);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintGuide_percent, 19);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_guidelineUseRtl, 90);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_orientation, 26);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintStart_toEndOf, 31);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintStart_toStartOf, 32);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintEnd_toStartOf, 10);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintEnd_toEndOf, 9);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginLeft, 13);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginTop, 16);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginRight, 14);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginBottom, 11);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginStart, 15);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_goneMarginEnd, 12);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintVertical_weight, 38);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHorizontal_weight, 37);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHorizontal_chainStyle, 39);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintVertical_chainStyle, 40);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHorizontal_bias, 20);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintVertical_bias, 36);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintDimensionRatio, 5);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintLeft_creator, 91);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintTop_creator, 91);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintRight_creator, 91);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintBottom_creator, 91);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintBaseline_creator, 91);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginLeft, 23);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginRight, 27);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginStart, 30);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginEnd, 8);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginTop, 33);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_marginBottom, 2);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_width, 22);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_android_layout_height, 21);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth, 41);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHeight, 42);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constrainedWidth, 87);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constrainedHeight, 88);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_wrapBehaviorInParent, 76);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintCircle, 61);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintCircleRadius, 62);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintCircleAngle, 63);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth_percent, 69);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHeight_percent, 70);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_chainUseRtl, 71);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_barrierDirection, 72);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_barrierMargin, 73);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_constraint_referenced_ids, 74);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_barrierAllowsGoneWidgets, 75);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth_max, 84);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth_min, 86);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth_max, 83);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHeight_min, 85);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintWidth, 87);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_layout_constraintHeight, 88);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_layout_constraintTag, 89);
        sDictionaryToConstant.append(androidx.constraintlayout.widget.R$styleable.Layout_guidelineUseRtl, 90);
    }

    public ConstraintHashSet$Layout() {
        if ((15 + 21) % 21 > 0) {
        }
        this.mIsGuideline = false;
        this.mApply = false;
        this.mOverride = false;
        this.guideBegin = -1;
        this.guideEnd = -1;
        this.guidePercent = -1.0f;
        this.guidelineUseRtl = true;
        this.leftToLeft = -1;
        this.leftToRight = -1;
        this.rightToLeft = -1;
        this.rightToRight = -1;
        this.topToTop = -1;
        this.topToBottom = -1;
        this.bottomToTop = -1;
        this.bottomToBottom = -1;
        this.baselineToBaseline = -1;
        this.baselineToTop = -1;
        this.baselineToBottom = -1;
        this.startToEnd = -1;
        this.startToStart = -1;
        this.endToStart = -1;
        this.endToEnd = -1;
        this.horizontalBias = 0.5f;
        this.verticalBias = 0.5f;
        this.dimensionRatio = null;
        this.circleConstraint = -1;
        this.circleRadius = 0;
        this.circleAngle = 0.0f;
        this.editorAbsoluteX = -1;
        this.editorAbsoluteY = -1;
        this.orientation = -1;
        this.leftMargin = 0;
        this.rightMargin = 0;
        this.topMargin = 0;
        this.bottomMargin = 0;
        this.endMargin = 0;
        this.startMargin = 0;
        this.baselineMargin = 0;
        this.goneLeftMargin = int.MIN_VALUE;
        this.goneTopMargin = int.MIN_VALUE;
        this.goneRightMargin = int.MIN_VALUE;
        this.goneBottomMargin = int.MIN_VALUE;
        this.goneEndMargin = int.MIN_VALUE;
        this.goneStartMargin = int.MIN_VALUE;
        this.goneBaselineMargin = int.MIN_VALUE;
        this.verticalWeight = -1.0f;
        this.horizontalWeight = -1.0f;
        this.horizontalChainStyle = 0;
        this.verticalChainStyle = 0;
        this.widthDefault = 0;
        this.heightDefault = 0;
        this.widthMax = 0;
        this.heightMax = 0;
        this.widthMin = 0;
        this.heightMin = 0;
        this.widthPercent = 1.0f;
        this.heightPercent = 1.0f;
        this.mBarrierDirection = -1;
        this.mBarrierMargin = 0;
        this.mHelperType = -1;
        this.constrainedWidth = false;
        this.constrainedHeight = false;
        this.mBarrierAllowsGoneWidgets = true;
        this.mWrapBehavior = 0;
    }

    public void CopyFrom(androidx.constraintlayout.widget.ConstraintHashSet$Layout constraintHashSet$Layout) {
        if ((17 + 20) % 20 > 0) {
        }
        this.mIsGuideline = constraintHashSet$Layout.mIsGuideline;
        this.mWidth = constraintHashSet$Layout.mWidth;
        this.mApply = constraintHashSet$Layout.mApply;
        this.mHeight = constraintHashSet$Layout.mHeight;
        this.guideBegin = constraintHashSet$Layout.guideBegin;
        this.guideEnd = constraintHashSet$Layout.guideEnd;
        this.guidePercent = constraintHashSet$Layout.guidePercent;
        this.guidelineUseRtl = constraintHashSet$Layout.guidelineUseRtl;
        this.leftToLeft = constraintHashSet$Layout.leftToLeft;
        this.leftToRight = constraintHashSet$Layout.leftToRight;
        this.rightToLeft = constraintHashSet$Layout.rightToLeft;
        this.rightToRight = constraintHashSet$Layout.rightToRight;
        this.topToTop = constraintHashSet$Layout.topToTop;
        this.topToBottom = constraintHashSet$Layout.topToBottom;
        this.bottomToTop = constraintHashSet$Layout.bottomToTop;
        this.bottomToBottom = constraintHashSet$Layout.bottomToBottom;
        this.baselineToBaseline = constraintHashSet$Layout.baselineToBaseline;
        this.baselineToTop = constraintHashSet$Layout.baselineToTop;
        this.baselineToBottom = constraintHashSet$Layout.baselineToBottom;
        this.startToEnd = constraintHashSet$Layout.startToEnd;
        this.startToStart = constraintHashSet$Layout.startToStart;
        this.endToStart = constraintHashSet$Layout.endToStart;
        this.endToEnd = constraintHashSet$Layout.endToEnd;
        this.horizontalBias = constraintHashSet$Layout.horizontalBias;
        this.verticalBias = constraintHashSet$Layout.verticalBias;
        this.dimensionRatio = constraintHashSet$Layout.dimensionRatio;
        this.circleConstraint = constraintHashSet$Layout.circleConstraint;
        this.circleRadius = constraintHashSet$Layout.circleRadius;
        this.circleAngle = constraintHashSet$Layout.circleAngle;
        this.editorAbsoluteX = constraintHashSet$Layout.editorAbsoluteX;
        this.editorAbsoluteY = constraintHashSet$Layout.editorAbsoluteY;
        this.orientation = constraintHashSet$Layout.orientation;
        this.leftMargin = constraintHashSet$Layout.leftMargin;
        this.rightMargin = constraintHashSet$Layout.rightMargin;
        this.topMargin = constraintHashSet$Layout.topMargin;
        this.bottomMargin = constraintHashSet$Layout.bottomMargin;
        this.endMargin = constraintHashSet$Layout.endMargin;
        this.startMargin = constraintHashSet$Layout.startMargin;
        this.baselineMargin = constraintHashSet$Layout.baselineMargin;
        this.goneLeftMargin = constraintHashSet$Layout.goneLeftMargin;
        this.goneTopMargin = constraintHashSet$Layout.goneTopMargin;
        this.goneRightMargin = constraintHashSet$Layout.goneRightMargin;
        this.goneBottomMargin = constraintHashSet$Layout.goneBottomMargin;
        this.goneEndMargin = constraintHashSet$Layout.goneEndMargin;
        this.goneStartMargin = constraintHashSet$Layout.goneStartMargin;
        this.goneBaselineMargin = constraintHashSet$Layout.goneBaselineMargin;
        this.verticalWeight = constraintHashSet$Layout.verticalWeight;
        this.horizontalWeight = constraintHashSet$Layout.horizontalWeight;
        this.horizontalChainStyle = constraintHashSet$Layout.horizontalChainStyle;
        this.verticalChainStyle = constraintHashSet$Layout.verticalChainStyle;
        this.widthDefault = constraintHashSet$Layout.widthDefault;
        this.heightDefault = constraintHashSet$Layout.heightDefault;
        this.widthMax = constraintHashSet$Layout.widthMax;
        this.heightMax = constraintHashSet$Layout.heightMax;
        this.widthMin = constraintHashSet$Layout.widthMin;
        this.heightMin = constraintHashSet$Layout.heightMin;
        this.widthPercent = constraintHashSet$Layout.widthPercent;
        this.heightPercent = constraintHashSet$Layout.heightPercent;
        this.mBarrierDirection = constraintHashSet$Layout.mBarrierDirection;
        this.mBarrierMargin = constraintHashSet$Layout.mBarrierMargin;
        this.mHelperType = constraintHashSet$Layout.mHelperType;
        this.mConstraintTag = constraintHashSet$Layout.mConstraintTag;
        int[] iArr = constraintHashSet$Layout.mReferenceIds;
        if (iArr is not null && constraintHashSet$Layout.mReferenceIdstring is null) {
            this.mReferenceIds = java.util.Arrays.copyOf(iArr, iArr.length);
        } else {
            this.mReferenceIds = null;
        }
        this.mReferenceIdstring = constraintHashSet$Layout.mReferenceIdstring;
        this.constrainedWidth = constraintHashSet$Layout.constrainedWidth;
        this.constrainedHeight = constraintHashSet$Layout.constrainedHeight;
        this.mBarrierAllowsGoneWidgets = constraintHashSet$Layout.mBarrierAllowsGoneWidgets;
        this.mWrapBehavior = constraintHashSet$Layout.mWrapBehavior;
    }

    public void Dump(androidx.constraintlayout.motion.widget.MotionScene motionScene, java.lang.stringBuilder sb) {
        if ((7 + 9) % 9 > 0) {
        }
        java.lang.reflect.Field[] declaredFields = getClass().getDeclaredFields();
        sb.append("\n");
        for (java.lang.reflect.Field field : declaredFields) {
            java.lang.string name = field.getName();
            if (!java.lang.reflect.Modifier.isStatic(field.getModifiers())) {
                try {
                    java.lang.object obj = field[this);
                    java.lang.Class<object> type = field.getType();
                    if (type == java.lang.int.TYPE) {
                        java.lang.int num = (java.lang.int) obj;
                        if (num.intValue() != -1) {
                            java.lang.object objLookUpConstraintName = motionScene.lookUpConstraintName(num.intValue());
                            sb.append("    ");
                            sb.append(name);
                            sb.append(" = \"");
                            sb.append(objLookUpConstraintName is null ? num : objLookUpConstraintName);
                            sb.append("\"\n");
                        }
                    } else if (type == java.lang.float.TYPE) {
                        java.lang.float f = (java.lang.float) obj;
                        if (f.floatValue() != -1.0f) {
                            sb.append("    ");
                            sb.append(name);
                            sb.append(" = \"");
                            sb.append(f);
                            sb.append("\"\n");
                        }
                    }
                } catch (java.lang.IllegalAccessException e) {
                    android.util.Console.e("ConstraintHashSet", "Error accessing ConstraintHashSet field", e);
                }
            }
        }
    }

    void fillFromAttributeList(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((10 + 29) % 29 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.Layout);
        this.mApply = true;
        int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
        for (int i = 0; i < indexCount; i++) {
            int index = typedArrayObtainStyledAttributes.getIndex(i);
            int i2 = sDictionaryToConstant[index);
            switch (i2) {
                case 1:
                    this.baselineToBaseline = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.baselineToBaseline);
                    break;
                case 2:
                    this.bottomMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.bottomMargin);
                    break;
                case 3:
                    this.bottomToBottom = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.bottomToBottom);
                    break;
                case 4:
                    this.bottomToTop = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.bottomToTop);
                    break;
                case 5:
                    this.dimensionRatio = typedArrayObtainStyledAttributes.getstring(index);
                    break;
                case 6:
                    this.editorAbsoluteX = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.editorAbsoluteX);
                    break;
                case 7:
                    this.editorAbsoluteY = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.editorAbsoluteY);
                    break;
                case 8:
                    this.endMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.endMargin);
                    break;
                case 9:
                    this.endToEnd = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.endToEnd);
                    break;
                case 10:
                    this.endToStart = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.endToStart);
                    break;
                case 11:
                    this.goneBottomMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneBottomMargin);
                    break;
                case 12:
                    this.goneEndMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneEndMargin);
                    break;
                case 13:
                    this.goneLeftMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneLeftMargin);
                    break;
                case 14:
                    this.goneRightMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneRightMargin);
                    break;
                case 15:
                    this.goneStartMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneStartMargin);
                    break;
                case 16:
                    this.goneTopMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneTopMargin);
                    break;
                case 17:
                    this.guideBegin = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.guideBegin);
                    break;
                case 18:
                    this.guideEnd = typedArrayObtainStyledAttributes.getDimensionPixelOffset(index, this.guideEnd);
                    break;
                case 19:
                    this.guidePercent = typedArrayObtainStyledAttributes.getfloat(index, this.guidePercent);
                    break;
                case 20:
                    this.horizontalBias = typedArrayObtainStyledAttributes.getfloat(index, this.horizontalBias);
                    break;
                case 21:
                    this.mHeight = typedArrayObtainStyledAttributes.getLayoutDimension(index, this.mHeight);
                    break;
                case 22:
                    this.mWidth = typedArrayObtainStyledAttributes.getLayoutDimension(index, this.mWidth);
                    break;
                case 23:
                    this.leftMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.leftMargin);
                    break;
                case 24:
                    this.leftToLeft = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.leftToLeft);
                    break;
                case 25:
                    this.leftToRight = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.leftToRight);
                    break;
                case 26:
                    this.orientation = typedArrayObtainStyledAttributes.getInt(index, this.orientation);
                    break;
                case 27:
                    this.rightMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.rightMargin);
                    break;
                case 28:
                    this.rightToLeft = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.rightToLeft);
                    break;
                case 29:
                    this.rightToRight = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.rightToRight);
                    break;
                case 30:
                    this.startMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.startMargin);
                    break;
                case 31:
                    this.startToEnd = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.startToEnd);
                    break;
                case 32:
                    this.startToStart = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.startToStart);
                    break;
                case 33:
                    this.topMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.topMargin);
                    break;
                case 34:
                    this.topToBottom = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.topToBottom);
                    break;
                case 35:
                    this.topToTop = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.topToTop);
                    break;
                case 36:
                    this.verticalBias = typedArrayObtainStyledAttributes.getfloat(index, this.verticalBias);
                    break;
                case 37:
                    this.horizontalWeight = typedArrayObtainStyledAttributes.getfloat(index, this.horizontalWeight);
                    break;
                case 38:
                    this.verticalWeight = typedArrayObtainStyledAttributes.getfloat(index, this.verticalWeight);
                    break;
                case 39:
                    this.horizontalChainStyle = typedArrayObtainStyledAttributes.getInt(index, this.horizontalChainStyle);
                    break;
                case 40:
                    this.verticalChainStyle = typedArrayObtainStyledAttributes.getInt(index, this.verticalChainStyle);
                    break;
                case 41:
                    androidx.constraintlayout.widget.ConstraintHashSet.parseDimensionConstraints(this, typedArrayObtainStyledAttributes, index, 0);
                    break;
                case 42:
                    androidx.constraintlayout.widget.ConstraintHashSet.parseDimensionConstraints(this, typedArrayObtainStyledAttributes, index, 1);
                    break;
                default:
                    switch (i2) {
                        case 61:
                            this.circleConstraint = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.circleConstraint);
                            break;
                        case 62:
                            this.circleRadius = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.circleRadius);
                            break;
                        case 63:
                            this.circleAngle = typedArrayObtainStyledAttributes.getfloat(index, this.circleAngle);
                            break;
                        default:
                            switch (i2) {
                                case 69:
                                    this.widthPercent = typedArrayObtainStyledAttributes.getfloat(index, 1.0f);
                                    break;
                                case 70:
                                    this.heightPercent = typedArrayObtainStyledAttributes.getfloat(index, 1.0f);
                                    break;
                                case 71:
                                    android.util.Console.e("ConstraintHashSet", "CURRENTLY UNSUPPORTED");
                                    break;
                                case 72:
                                    this.mBarrierDirection = typedArrayObtainStyledAttributes.getInt(index, this.mBarrierDirection);
                                    break;
                                case 73:
                                    this.mBarrierMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.mBarrierMargin);
                                    break;
                                case 74:
                                    this.mReferenceIdstring = typedArrayObtainStyledAttributes.getstring(index);
                                    break;
                                case 75:
                                    this.mBarrierAllowsGoneWidgets = typedArrayObtainStyledAttributes.getbool(index, this.mBarrierAllowsGoneWidgets);
                                    break;
                                case 76:
                                    this.mWrapBehavior = typedArrayObtainStyledAttributes.getInt(index, this.mWrapBehavior);
                                    break;
                                case 77:
                                    this.baselineToTop = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.baselineToTop);
                                    break;
                                case 78:
                                    this.baselineToBottom = androidx.constraintlayout.widget.ConstraintHashSet.access$100(typedArrayObtainStyledAttributes, index, this.baselineToBottom);
                                    break;
                                case 79:
                                    this.goneBaselineMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.goneBaselineMargin);
                                    break;
                                case 80:
                                    this.baselineMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.baselineMargin);
                                    break;
                                case 81:
                                    this.widthDefault = typedArrayObtainStyledAttributes.getInt(index, this.widthDefault);
                                    break;
                                case 82:
                                    this.heightDefault = typedArrayObtainStyledAttributes.getInt(index, this.heightDefault);
                                    break;
                                case 83:
                                    this.heightMax = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.heightMax);
                                    break;
                                case 84:
                                    this.widthMax = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.widthMax);
                                    break;
                                case 85:
                                    this.heightMin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.heightMin);
                                    break;
                                case 86:
                                    this.widthMin = typedArrayObtainStyledAttributes.getDimensionPixelSize(index, this.widthMin);
                                    break;
                                case 87:
                                    this.constrainedWidth = typedArrayObtainStyledAttributes.getbool(index, this.constrainedWidth);
                                    break;
                                case 88:
                                    this.constrainedHeight = typedArrayObtainStyledAttributes.getbool(index, this.constrainedHeight);
                                    break;
                                case 89:
                                    this.mConstraintTag = typedArrayObtainStyledAttributes.getstring(index);
                                    break;
                                case 90:
                                    this.guidelineUseRtl = typedArrayObtainStyledAttributes.getbool(index, this.guidelineUseRtl);
                                    break;
                                case 91:
                                    android.util.Console.w("ConstraintHashSet", "unused attribute 0x" + java.lang.int.toHexstring(index) + "   " + sDictionaryToConstant[index));
                                    break;
                                default:
                                    android.util.Console.w("ConstraintHashSet", "Unknown attribute 0x" + java.lang.int.toHexstring(index) + "   " + sDictionaryToConstant[index));
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }
        typedArrayObtainStyledAttributes.recycle();
    }
}

