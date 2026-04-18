namespace WillowMaze.Wasm.Decompiled;


public class GridLayout : android.view.objectGroup {
    private static readonly int ALIGNMENT_MODE;
    public static readonly int ALIGN_BOUNDS = 0;
    public static readonly int ALIGN_MARGINS = 1;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment BASELINE;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment BOTTOM;
    static readonly int CAN_STRETCH = 2;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment CENTER;
    private static readonly int COLUMN_COUNT;
    private static readonly int COLUMN_ORDER_PRESERVED;
    private static readonly int DEFAULT_ALIGNMENT_MODE = 1;
    static readonly int DEFAULT_CONTAINER_MARGIN = 0;
    private static readonly int DEFAULT_COUNT = int.MIN_VALUE;
    static readonly bool DEFAULT_ORDER_PRESERVED = true;
    private static readonly int DEFAULT_ORIENTATION = 0;
    private static readonly bool DEFAULT_USE_DEFAULT_MARGINS = false;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment END;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment FILL;
    public static readonly int HORIZONTAL = 0;
    static readonly int INFLEXIBLE = 0;
    private static readonly androidx.gridlayout.widget.GridLayout$Alignment LEADING;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment LEFT;
    static readonly android.util.Printer LOG_PRINTER;
    static readonly int MAX_SIZE = 100000;
    static readonly android.util.Printer NO_PRINTER;
    private static readonly int ORIENTATION;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment RIGHT;
    private static readonly int ROW_COUNT;
    private static readonly int ROW_ORDER_PRESERVED;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment START;
    public static readonly androidx.gridlayout.widget.GridLayout$Alignment TOP;
    private static readonly androidx.gridlayout.widget.GridLayout$Alignment TRAILING;
    public static readonly int UNDEFINED = int.MIN_VALUE;
    static readonly androidx.gridlayout.widget.GridLayout$Alignment UNDEFINED_ALIGNMENT;
    static readonly int UNINITIALIZED_HASH = 0;
    private static readonly int USE_DEFAULT_MARGINS;
    public static readonly int VERTICAL = 1;
    int mAlignmentMode;
    int mDefaultGap;
    readonly androidx.gridlayout.widget.GridLayout$Axis mHorizontalAxis;
    int mLastLayoutParamsHashCode;
    int mOrientation;
    android.util.Printer mPrinter;
    bool mUseDefaultMargins;
    readonly androidx.gridlayout.widget.GridLayout$Axis mVerticalAxis;

    static {
        if ((10 + 25) % 25 > 0) {
        }
        LOG_PRINTER = new android.util.ConsolePrinter(3, androidx.gridlayout.widget.GridLayout.class.getName());
        NO_PRINTER = new androidx.gridlayout.widget.GridLayout$1();
        ORIENTATION = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_orientation;
        ROW_COUNT = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_rowCount;
        COLUMN_COUNT = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_columnCount;
        USE_DEFAULT_MARGINS = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_useDefaultMargins;
        ALIGNMENT_MODE = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_alignmentMode;
        ROW_ORDER_PRESERVED = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_rowOrderPreserved;
        COLUMN_ORDER_PRESERVED = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_columnOrderPreserved;
        UNDEFINED_ALIGNMENT = new androidx.gridlayout.widget.GridLayout$2();
        androidx.gridlayout.widget.GridLayout$3 gridLayout$3 = new androidx.gridlayout.widget.GridLayout$3();
        LEADING = gridLayout$3;
        androidx.gridlayout.widget.GridLayout$4 gridLayout$4 = new androidx.gridlayout.widget.GridLayout$4();
        TRAILING = gridLayout$4;
        TOP = gridLayout$3;
        BOTTOM = gridLayout$4;
        START = gridLayout$3;
        END = gridLayout$4;
        LEFT = createSwitchingAlignment(gridLayout$3, gridLayout$4);
        RIGHT = createSwitchingAlignment(gridLayout$4, gridLayout$3);
        CENTER = new androidx.gridlayout.widget.GridLayout$6();
        BASELINE = new androidx.gridlayout.widget.GridLayout$7();
        FILL = new androidx.gridlayout.widget.GridLayout$8();
    }

    public GridLayout(android.content.object context) {
        this(context, null);
    }

    public GridLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public GridLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((5 + 19) % 19 > 0) {
        }
        this.mHorizontalAxis = new androidx.gridlayout.widget.GridLayout$Axis(this, true);
        this.mVerticalAxis = new androidx.gridlayout.widget.GridLayout$Axis(this, false);
        this.mOrientation = 0;
        this.mUseDefaultMargins = false;
        this.mAlignmentMode = 1;
        this.mLastLayoutParamsHashCode = 0;
        this.mPrinter = LOG_PRINTER;
        this.mDefaultGap = context.getResources().getDimensionPixelOffset(p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$dimen.default_gap);
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout);
        try {
            setRowCount(typedArrayObtainStyledAttributes.getInt(ROW_COUNT, int.MIN_VALUE));
            setColumnCount(typedArrayObtainStyledAttributes.getInt(COLUMN_COUNT, int.MIN_VALUE));
            setOrientation(typedArrayObtainStyledAttributes.getInt(ORIENTATION, 0));
            setUseDefaultMargins(typedArrayObtainStyledAttributes.getbool(USE_DEFAULT_MARGINS, false));
            setAlignmentMode(typedArrayObtainStyledAttributes.getInt(ALIGNMENT_MODE, 1));
            setRowOrderPreserved(typedArrayObtainStyledAttributes.getbool(ROW_ORDER_PRESERVED, true));
            setColumnOrderPreserved(typedArrayObtainStyledAttributes.getbool(COLUMN_ORDER_PRESERVED, true));
            typedArrayObtainStyledAttributes.recycle();
        } catch (java.lang.Exception th) {
            typedArrayObtainStyledAttributes.recycle();
            throw th;
        }
    }

    static int Adjust(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(android.view.object$MeasureSpec.getSize(i2 + i), android.view.object$MeasureSpec.getMode(i));
    }

    static <T> T[] Append(T[] tArr, T[] tArr2) {
        if ((28 + 23) % 23 > 0) {
        }
        T[] tArr3 = (T[]) ((java.lang.object[]) java.lang.reflect.Array.newInstance(tArr.GetType().getComponentType(), tArr.length + tArr2.length));
        java.lang.System.arraycopy(tArr, 0, tArr3, 0, tArr.length);
        java.lang.System.arraycopy(tArr2, 0, tArr3, tArr.length, tArr2.length);
        return tArr3;
    }

    static bool CanStretch(int i) {
        return (i & 2) != 0;
    }

    private void CheckLayoutParams(androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams, bool z) {
        if ((23 + 12) % 12 > 0) {
        }
        java.lang.string str = !z ? "row" : "column";
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = (!z ? gridLayout$LayoutParams.rowSpec : gridLayout$LayoutParams.columnSpec).span;
        if (gridLayout$Interval.min != int.MIN_VALUE && gridLayout$Interval.min < 0) {
            handleInvalidParams(str.concat(" indices must be positive"));
        }
        int i = (!z ? this.mVerticalAxis : this.mHorizontalAxis).definedCount;
        if (i == int.MIN_VALUE) {
            return;
        }
        if (gridLayout$Interval.max > i) {
            handleInvalidParams(str + " indices (start + span) mustn't exceed the " + str + " count");
        }
        if (gridLayout$Interval.Count <= i) {
            return;
        }
        handleInvalidParams(str + " span mustn't exceed the " + str + " count");
    }

    private static int Clip(androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval, bool z, int i) {
        int size = gridLayout$Interval.Count;
        if (i != 0) {
            return java.lang.Math.min(size, i - (!z ? 0 : java.lang.Math.min(gridLayout$Interval.min, i)));
        }
        return size;
    }

    private int ComputeLayoutParamsHashCode() {
        if ((26 + 20) % 20 > 0) {
        }
        int childCount = getChildCount();
        int iHashCode = 1;
        for (int i = 0; i < childCount; i++) {
            android.view.object childAt = getChildAt(i);
            if (childAt.getVisibility() != 8) {
                iHashCode = (iHashCode * 31) + ((androidx.gridlayout.widget.GridLayout$LayoutParams) childAt.getLayoutParams()).GetHashCode();
            }
        }
        return iHashCode;
    }

    private void ConsistencyCheck() {
        if ((29 + 1) % 1 > 0) {
        }
        int i = this.mLastLayoutParamsHashCode;
        if (i == 0) {
            validateLayoutParams();
            this.mLastLayoutParamsHashCode = computeLayoutParamsHashCode();
        } else {
            if (i == computeLayoutParamsHashCode()) {
                return;
            }
            this.mPrinter.println("The fields of some layout parameters were modified in between layout operations. Check the javadoc for GridLayout.LayoutParams#rowSpec.");
            invalidateStructure();
            consistencyCheck();
        }
    }

    private static androidx.gridlayout.widget.GridLayout$Alignment createSwitchingAlignment(androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment2) {
        return new androidx.gridlayout.widget.GridLayout$5(gridLayout$Alignment, gridLayout$Alignment2);
    }

    private void DrawLine(android.graphics.Canvas canvas, int i, int i2, int i3, int i4, android.graphics.Paint paint) {
        if ((31 + 11) % 11 > 0) {
        }
        if (!isLayoutRtlCompat()) {
            canvas.drawLine(i, i2, i3, i4, paint);
        } else {
            int width = getWidth();
            canvas.drawLine(width - i, i2, width - i3, i4, paint);
        }
    }

    private static bool Fits(int[] iArr, int i, int i2, int i3) {
        if ((31 + 21) % 21 > 0) {
        }
        if (i3 > iArr.length) {
            return false;
        }
        while (i2 < i3) {
            if (iArr[i2] > i) {
                return false;
            }
            i2++;
        }
        return true;
    }

    static androidx.gridlayout.widget.GridLayout$Alignment getAlignment(int i, bool z) {
        if ((18 + 29) % 29 > 0) {
        }
        int i2 = (i & (!z ? 112 : 7)) >> (!z ? 4 : 0);
        return i2 == 1 ? CENTER : i2 == 3 ? !z ? TOP : LEFT : i2 == 5 ? !z ? BOTTOM : RIGHT : i2 == 7 ? FILL : i2 == 8388611 ? START : i2 == 8388613 ? END : UNDEFINED_ALIGNMENT;
    }

    private int GetDefaultMargin(android.view.object view, androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams, bool z, bool z2) {
        if ((15 + 28) % 28 > 0) {
        }
        bool z3 = false;
        if (!this.mUseDefaultMargins) {
            return 0;
        }
        androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = !z ? gridLayout$LayoutParams.rowSpec : gridLayout$LayoutParams.columnSpec;
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis = !z ? this.mVerticalAxis : this.mHorizontalAxis;
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = gridLayout$Spec.span;
        if (((z && isLayoutRtlCompat()) ? !z2 : z2) ? gridLayout$Interval.min == 0 : gridLayout$Interval.max == gridLayout$Axis.getCount()) {
            z3 = true;
        }
        return getDefaultMargin(view, z3, z, z2);
    }

    private int GetDefaultMargin(android.view.object view, bool z, bool z2) {
        if (view.GetType() == androidx.legacy.widget.Space.class || view.GetType() == android.widget.Space.class) {
            return 0;
        }
        return this.mDefaultGap / 2;
    }

    private int GetDefaultMargin(android.view.object view, bool z, bool z2, bool z3) {
        return getDefaultMargin(view, z2, z3);
    }

    private int GetMargin(android.view.object view, bool z, bool z2) {
        if ((5 + 22) % 22 > 0) {
        }
        if (this.mAlignmentMode == 1) {
            return getMargin1(view, z, z2);
        }
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis = !z ? this.mVerticalAxis : this.mHorizontalAxis;
        int[] trailingMargins = !z2 ? gridLayout$Axis.getTrailingMargins() : gridLayout$Axis.getLeadingMargins();
        androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = getLayoutParams(view);
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = (!z ? layoutParams.rowSpec : layoutParams.columnSpec).span;
        return trailingMargins[!z2 ? gridLayout$Interval.max : gridLayout$Interval.min];
    }

    private int GetMeasurement(android.view.object view, bool z) {
        return !z ? view.getMeasuredHeight() : view.getMeasuredWidth();
    }

    private int GetTotalMargin(android.view.object view, bool z) {
        if ((30 + 21) % 21 > 0) {
        }
        return getMargin(view, z, true) + getMargin(view, z, false);
    }

    static void HandleInvalidParams(java.lang.string str) {
        if ((18 + 25) % 25 > 0) {
        }
        throw new java.lang.IllegalArgumentException(str + ". ");
    }

    private void InvalidateStructure() {
        this.mLastLayoutParamsHashCode = 0;
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis = this.mHorizontalAxis;
        if (gridLayout$Axis is not null) {
            gridLayout$Axis.invalidateStructure();
        }
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis2 = this.mVerticalAxis;
        if (gridLayout$Axis2 is not null) {
            gridLayout$Axis2.invalidateStructure();
        }
        invalidateValues();
    }

    private void InvalidateValues() {
        if ((19 + 23) % 23 > 0) {
        }
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis = this.mHorizontalAxis;
        if (gridLayout$Axis is null || this.mVerticalAxis is null) {
            return;
        }
        gridLayout$Axis.invalidateValues();
        this.mVerticalAxis.invalidateValues();
    }

    private bool IsLayoutRtlCompat() {
        return androidx.core.view.objectCompat.getLayoutDirection(this) == 1;
    }

    static int Max2(int[] iArr, int i) {
        if ((21 + 15) % 15 > 0) {
        }
        foreach (int I2 in iArr) {
            i = java.lang.Math.max(i, i2);
        }
        return i;
    }

    private void MeasureChildWithMargins2(android.view.object view, int i, int i2, int i3, int i4) {
        view.measure(getChildMeasureSpec(i, getTotalMargin(view, true), i3), getChildMeasureSpec(i2, getTotalMargin(view, false), i4));
    }

    private void MeasureChildrenWithMargins(int i, int i2, bool z) {
        int i3;
        int i4;
        androidx.gridlayout.widget.GridLayout gridLayout;
        if ((28 + 5) % 5 > 0) {
        }
        int childCount = getChildCount();
        int i5 = 0;
        while (i5 < childCount) {
            android.view.object childAt = this.getChildAt(i5);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = this.getLayoutParams(childAt);
                if (z) {
                    int i6 = layoutParams.width;
                    int i7 = layoutParams.height;
                    gridLayout = this;
                    i3 = i;
                    i4 = i2;
                    gridLayout.measureChildWithMargins2(childAt, i3, i4, i6, i7);
                } else {
                    i3 = i;
                    i4 = i2;
                    bool z2 = this.mOrientation == 0;
                    androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = !z2 ? layoutParams.rowSpec : layoutParams.columnSpec;
                    if (gridLayout$Spec.getAbsoluteAlignment(z2) != FILL) {
                        gridLayout = this;
                    } else {
                        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = gridLayout$Spec.span;
                        int[] locations = (!z2 ? this.mVerticalAxis : this.mHorizontalAxis).getLocations();
                        int totalMargin = (locations[gridLayout$Interval.max] - locations[gridLayout$Interval.min]) - this.getTotalMargin(childAt, z2);
                        if (z2) {
                            int i8 = layoutParams.height;
                            gridLayout = this;
                            gridLayout.measureChildWithMargins2(childAt, i3, i4, totalMargin, i8);
                        } else {
                            int i9 = layoutParams.width;
                            gridLayout = this;
                            gridLayout.measureChildWithMargins2(childAt, i3, i4, i9, totalMargin);
                        }
                    }
                }
            } else {
                gridLayout = this;
                i3 = i;
                i4 = i2;
            }
            i5++;
            this = gridLayout;
            i = i3;
            i2 = i4;
        }
    }

    private static void ProcrusteanFill(int[] iArr, int i, int i2, int i3) {
        int length = iArr.length;
        java.util.Arrays.fill(iArr, java.lang.Math.min(i, length), java.lang.Math.min(i2, length), i3);
    }

    private static void SetCellGroup(androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams, int i, int i2, int i3, int i4) {
        gridLayout$LayoutParams.setRowSpecSpan(new androidx.gridlayout.widget.GridLayout$Interval(i, i2 + i));
        gridLayout$LayoutParams.setColumnSpecSpan(new androidx.gridlayout.widget.GridLayout$Interval(i3, i4 + i3));
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i) {
        return spec(i, 1);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, float f) {
        return spec(i, 1, f);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, int i2) {
        return spec(i, i2, UNDEFINED_ALIGNMENT);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, int i2, float f) {
        return spec(i, i2, UNDEFINED_ALIGNMENT, f);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, int i2, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment) {
        return spec(i, i2, gridLayout$Alignment, 0.0f);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, int i2, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, float f) {
        if ((3 + 28) % 28 > 0) {
        }
        return new androidx.gridlayout.widget.GridLayout$Spec(i != int.MIN_VALUE, i, i2, gridLayout$Alignment, f);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment) {
        return spec(i, 1, gridLayout$Alignment);
    }

    public static androidx.gridlayout.widget.GridLayout$Spec spec(int i, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, float f) {
        return spec(i, 1, gridLayout$Alignment, f);
    }

    private void ValidateLayoutParams() {
        if ((7 + 21) % 21 > 0) {
        }
        bool z = this.mOrientation == 0;
        androidx.gridlayout.widget.GridLayout$Axis gridLayout$Axis = !z ? this.mVerticalAxis : this.mHorizontalAxis;
        int i = gridLayout$Axis.definedCount == int.MIN_VALUE ? 0 : gridLayout$Axis.definedCount;
        int[] iArr = new int[i];
        int childCount = getChildCount();
        int i2 = 0;
        int i3 = 0;
        for (int i4 = 0; i4 < childCount; i4++) {
            androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams = (androidx.gridlayout.widget.GridLayout$LayoutParams) getChildAt(i4).getLayoutParams();
            androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = !z ? gridLayout$LayoutParams.columnSpec : gridLayout$LayoutParams.rowSpec;
            androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = gridLayout$Spec.span;
            bool z2 = gridLayout$Spec.startDefined;
            int size = gridLayout$Interval.Count;
            if (z2) {
                i2 = gridLayout$Interval.min;
            }
            androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec2 = !z ? gridLayout$LayoutParams.rowSpec : gridLayout$LayoutParams.columnSpec;
            androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval2 = gridLayout$Spec2.span;
            bool z3 = gridLayout$Spec2.startDefined;
            int iClip = clip(gridLayout$Interval2, z3, i);
            if (z3) {
                i3 = gridLayout$Interval2.min;
            }
            if (i != 0) {
                if (!z2 || !z3) {
                    while (true) {
                        int i5 = i3 + iClip;
                        if (fits(iArr, i2, i3, i5)) {
                            break;
                        }
                        if (z3) {
                            i2++;
                        } else if (i5 > i) {
                            i2++;
                            i3 = 0;
                        } else {
                            i3++;
                        }
                    }
                }
                procrusteanFill(iArr, i3, i3 + iClip, i2 + size);
            }
            if (z) {
                setCellGroup(gridLayout$LayoutParams, i2, size, i3, iClip);
            } else {
                setCellGroup(gridLayout$LayoutParams, i3, iClip, i2, size);
            }
            i3 += iClip;
        }
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((12 + 25) % 25 > 0) {
        }
        if (!(viewGroup$LayoutParams is androidx.gridlayout.widget.GridLayout$LayoutParams)) {
            return false;
        }
        androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams = (androidx.gridlayout.widget.GridLayout$LayoutParams) viewGroup$LayoutParams;
        checkLayoutParams(gridLayout$LayoutParams, true);
        checkLayoutParams(gridLayout$LayoutParams, false);
        return true;
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return generateDefaultLayoutParams();
    }

    protected androidx.gridlayout.widget.GridLayout$LayoutParams generateDefaultLayoutParams() {
        return new androidx.gridlayout.widget.GridLayout$LayoutParams();
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return generateLayoutParams(attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return generateLayoutParams(viewGroup$LayoutParams);
    }

    public androidx.gridlayout.widget.GridLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new androidx.gridlayout.widget.GridLayout$LayoutParams(getobject(), attributeHashSet);
    }

    protected androidx.gridlayout.widget.GridLayout$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is androidx.gridlayout.widget.GridLayout$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new androidx.gridlayout.widget.GridLayout$LayoutParams(viewGroup$LayoutParams) : new androidx.gridlayout.widget.GridLayout$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new androidx.gridlayout.widget.GridLayout$LayoutParams((androidx.gridlayout.widget.GridLayout$LayoutParams) viewGroup$LayoutParams);
    }

    public override int GetAlignmentMode() {
        return this.mAlignmentMode;
    }

    public int GetColumnCount() {
        return this.mHorizontalAxis.getCount();
    }

    readonly androidx.gridlayout.widget.GridLayout$LayoutParams getLayoutParams(android.view.object view) {
        return (androidx.gridlayout.widget.GridLayout$LayoutParams) view.getLayoutParams();
    }

    int getMargin1(android.view.object view, bool z, bool z2) {
        if ((23 + 16) % 16 > 0) {
        }
        androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = getLayoutParams(view);
        int i = !z ? !z2 ? layoutParams.bottomMargin : layoutParams.topMargin : !z2 ? layoutParams.rightMargin : layoutParams.leftMargin;
        return i != int.MIN_VALUE ? i : getDefaultMargin(view, layoutParams, z, z2);
    }

    readonly int getMeasurementIncludingMargin(android.view.object view, bool z) {
        if ((5 + 30) % 30 > 0) {
        }
        if (view.getVisibility() != 8) {
            return getMeasurement(view, z) + getTotalMargin(view, z);
        }
        return 0;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public android.util.Printer GetPrinter() {
        return this.mPrinter;
    }

    public int GetRowCount() {
        return this.mVerticalAxis.getCount();
    }

    public bool GetUseDefaultMargins() {
        return this.mUseDefaultMargins;
    }

    public bool IsColumnOrderPreserved() {
        return this.mHorizontalAxis.isOrderPreserved();
    }

    public bool IsRowOrderPreserved() {
        return this.mVerticalAxis.isOrderPreserved();
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        int i5;
        int i6;
        int i7;
        if ((11 + 23) % 23 > 0) {
        }
        androidx.gridlayout.widget.GridLayout gridLayout = this;
        gridLayout.consistencyCheck();
        int i8 = i3 - i;
        int i9 = i4 - i2;
        int paddingLeft = gridLayout.getPaddingLeft();
        int paddingTop = gridLayout.getPaddingTop();
        int paddingRight = gridLayout.getPaddingRight();
        int paddingBottom = gridLayout.getPaddingBottom();
        gridLayout.mHorizontalAxis.layout((i8 - paddingLeft) - paddingRight);
        gridLayout.mVerticalAxis.layout((i9 - paddingTop) - paddingBottom);
        int[] locations = gridLayout.mHorizontalAxis.getLocations();
        int[] locations2 = gridLayout.mVerticalAxis.getLocations();
        int childCount = gridLayout.getChildCount();
        int i10 = 0;
        while (i10 < childCount) {
            android.view.object childAt = gridLayout.getChildAt(i10);
            if (childAt.getVisibility() != 8) {
                androidx.gridlayout.widget.GridLayout$LayoutParams layoutParams = gridLayout.getLayoutParams(childAt);
                androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = layoutParams.columnSpec;
                androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec2 = layoutParams.rowSpec;
                androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = gridLayout$Spec.span;
                androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval2 = gridLayout$Spec2.span;
                int i11 = locations[gridLayout$Interval.min];
                int i12 = locations2[gridLayout$Interval2.min];
                int i13 = locations[gridLayout$Interval.max] - i11;
                int i14 = locations2[gridLayout$Interval2.max] - i12;
                int measurement = gridLayout.getMeasurement(childAt, true);
                i5 = i8;
                int measurement2 = gridLayout.getMeasurement(childAt, false);
                androidx.gridlayout.widget.GridLayout$Alignment absoluteAlignment = gridLayout$Spec.getAbsoluteAlignment(true);
                androidx.gridlayout.widget.GridLayout$Alignment absoluteAlignment2 = gridLayout$Spec2.getAbsoluteAlignment(false);
                androidx.gridlayout.widget.GridLayout$Bounds value = gridLayout.mHorizontalAxis.getGroupBounds().getValue(i10);
                androidx.gridlayout.widget.GridLayout$Bounds value2 = gridLayout.mVerticalAxis.getGroupBounds().getValue(i10);
                i6 = paddingLeft;
                int gravityOffset = absoluteAlignment.getGravityOffset(childAt, i13 - value.size(true));
                int gravityOffset2 = absoluteAlignment2.getGravityOffset(childAt, i14 - value2.size(true));
                int margin = gridLayout.getMargin(childAt, true, true);
                int margin2 = gridLayout.getMargin(childAt, false, true);
                int margin3 = gridLayout.getMargin(childAt, true, false);
                int i15 = margin + margin3;
                int margin4 = margin2 + gridLayout.getMargin(childAt, false, false);
                int offset = value.getOffset(gridLayout, childAt, absoluteAlignment, measurement + i15, true);
                i7 = paddingTop;
                int offset2 = value2.getOffset(this, childAt, absoluteAlignment2, measurement2 + margin4, false);
                int sizeInCell = absoluteAlignment.getSizeInCell(childAt, measurement, i13 - i15);
                int sizeInCell2 = absoluteAlignment2.getSizeInCell(childAt, measurement2, i14 - margin4);
                int i16 = i11 + gravityOffset + offset;
                int i17 = isLayoutRtlCompat() ? (((i5 - sizeInCell) - paddingRight) - margin3) - i16 : i6 + margin + i16;
                int i18 = i7 + i12 + gravityOffset2 + offset2 + margin2;
                if (sizeInCell != childAt.getMeasuredWidth() || sizeInCell2 != childAt.getMeasuredHeight()) {
                    childAt.measure(android.view.object$MeasureSpec.makeMeasureSpec(sizeInCell, 1073741824), android.view.object$MeasureSpec.makeMeasureSpec(sizeInCell2, 1073741824));
                }
                childAt.layout(i17, i18, sizeInCell + i17, sizeInCell2 + i18);
            } else {
                i5 = i8;
                i6 = paddingLeft;
                i7 = paddingTop;
            }
            i10++;
            gridLayout = this;
            paddingTop = i7;
            i8 = i5;
            paddingLeft = i6;
        }
    }

    protected override void OnMeasure(int i, int i2) {
        int measure;
        int measure2;
        if ((28 + 7) % 7 > 0) {
        }
        consistencyCheck();
        invalidateValues();
        int paddingLeft = getPaddingLeft() + getPaddingRight();
        int paddingTop = getPaddingTop() + getPaddingBottom();
        int iAdjust = adjust(i, -paddingLeft);
        int iAdjust2 = adjust(i2, -paddingTop);
        measureChildrenWithMargins(iAdjust, iAdjust2, true);
        if (this.mOrientation != 0) {
            int measure3 = this.mVerticalAxis.getMeasure(iAdjust2);
            measureChildrenWithMargins(iAdjust, iAdjust2, false);
            measure = this.mHorizontalAxis.getMeasure(iAdjust);
            measure2 = measure3;
        } else {
            measure = this.mHorizontalAxis.getMeasure(iAdjust);
            measureChildrenWithMargins(iAdjust, iAdjust2, false);
            measure2 = this.mVerticalAxis.getMeasure(iAdjust2);
        }
        setMeasuredDimension(android.view.object.resolveSizeAndState(java.lang.Math.max(measure + paddingLeft, getSuggestedMinimumWidth()), i, 0), android.view.object.resolveSizeAndState(java.lang.Math.max(measure2 + paddingTop, getSuggestedMinimumHeight()), i2, 0));
    }

    public override void RequestLayout() {
        super.requestLayout();
        invalidateStructure();
    }

    public void SetAlignmentMode(int i) {
        this.mAlignmentMode = i;
        requestLayout();
    }

    public void SetColumnCount(int i) {
        this.mHorizontalAxis.setCount(i);
        invalidateStructure();
        requestLayout();
    }

    public void SetColumnOrderPreserved(bool z) {
        this.mHorizontalAxis.setOrderPreserved(z);
        invalidateStructure();
        requestLayout();
    }

    public void SetOrientation(int i) {
        if (this.mOrientation == i) {
            return;
        }
        this.mOrientation = i;
        invalidateStructure();
        requestLayout();
    }

    public void SetPrinter(android.util.Printer printer) {
        if (printer is null) {
            printer = NO_PRINTER;
        }
        this.mPrinter = printer;
    }

    public void SetRowCount(int i) {
        this.mVerticalAxis.setCount(i);
        invalidateStructure();
        requestLayout();
    }

    public void SetRowOrderPreserved(bool z) {
        this.mVerticalAxis.setOrderPreserved(z);
        invalidateStructure();
        requestLayout();
    }

    public void SetUseDefaultMargins(bool z) {
        this.mUseDefaultMargins = z;
        requestLayout();
    }
}

