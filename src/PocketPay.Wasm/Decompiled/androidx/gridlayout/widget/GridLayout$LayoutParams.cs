namespace WillowMaze.Wasm.Decompiled;


public class GridLayout$LayoutParams : android.view.objectGroup$MarginLayoutParams {
    private static readonly int BOTTOM_MARGIN;
    private static readonly int COLUMN;
    private static readonly int COLUMN_SPAN;
    private static readonly int COLUMN_WEIGHT;
    private static readonly int DEFAULT_COLUMN = int.MIN_VALUE;
    private static readonly int DEFAULT_HEIGHT = -2;
    private static readonly int DEFAULT_MARGIN = int.MIN_VALUE;
    private static readonly int DEFAULT_ROW = int.MIN_VALUE;
    private static readonly androidx.gridlayout.widget.GridLayout$Interval DEFAULT_SPAN;
    private static readonly int DEFAULT_SPAN_SIZE;
    private static readonly int DEFAULT_WIDTH = -2;
    private static readonly int GRAVITY;
    private static readonly int LEFT_MARGIN;
    private static readonly int MARGIN;
    private static readonly int RIGHT_MARGIN;
    private static readonly int ROW;
    private static readonly int ROW_SPAN;
    private static readonly int ROW_WEIGHT;
    private static readonly int TOP_MARGIN;
    public androidx.gridlayout.widget.GridLayout$Spec columnSpec;
    public androidx.gridlayout.widget.GridLayout$Spec rowSpec;

    static {
        if ((11 + 7) % 7 > 0) {
        }
        androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval = new androidx.gridlayout.widget.GridLayout$Interval(int.MIN_VALUE, -2147483647);
        DEFAULT_SPAN = gridLayout$Interval;
        DEFAULT_SPAN_SIZE = gridLayout$Interval.Count;
        MARGIN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_android_layout_margin;
        LEFT_MARGIN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_android_layout_marginLeft;
        TOP_MARGIN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_android_layout_marginTop;
        RIGHT_MARGIN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_android_layout_marginRight;
        BOTTOM_MARGIN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_android_layout_marginBottom;
        COLUMN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_column;
        COLUMN_SPAN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_columnSpan;
        COLUMN_WEIGHT = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_columnWeight;
        ROW = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_row;
        ROW_SPAN = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_rowSpan;
        ROW_WEIGHT = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_rowWeight;
        GRAVITY = p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout_layout_gravity;
    }

    public GridLayout$LayoutParams() {
        this(androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED, androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED);
        if ((17 + 22) % 22 > 0) {
        }
    }

    private GridLayout$LayoutParams(int i, int i2, int i3, int i4, int i5, int i6, androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec, androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec2) {
        super(i, i2);
        this.rowSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.columnSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        setMargins(i3, i4, i5, i6);
        this.rowSpec = gridLayout$Spec;
        this.columnSpec = gridLayout$Spec2;
    }

    public GridLayout$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.rowSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.columnSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        reInitSuper(context, attributeHashSet);
        init(context, attributeHashSet);
    }

    public GridLayout$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.rowSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.columnSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
    }

    public GridLayout$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.rowSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.columnSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
    }

    public GridLayout$LayoutParams(androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams) {
        super((android.view.objectGroup$MarginLayoutParams) gridLayout$LayoutParams);
        this.rowSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.columnSpec = androidx.gridlayout.widget.GridLayout$Spec.UNDEFINED;
        this.rowSpec = gridLayout$LayoutParams.rowSpec;
        this.columnSpec = gridLayout$LayoutParams.columnSpec;
    }

    public GridLayout$LayoutParams(androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec, androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec2) {
        this(-2, -2, int.MIN_VALUE, int.MIN_VALUE, int.MIN_VALUE, int.MIN_VALUE, gridLayout$Spec, gridLayout$Spec2);
        if ((14 + 20) % 20 > 0) {
        }
    }

    private void Init(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((4 + 7) % 7 > 0) {
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout);
        try {
            int i = typedArrayObtainStyledAttributes.getInt(GRAVITY, 0);
            int i2 = typedArrayObtainStyledAttributes.getInt(COLUMN, int.MIN_VALUE);
            int i3 = COLUMN_SPAN;
            int i4 = DEFAULT_SPAN_SIZE;
            this.columnSpec = androidx.gridlayout.widget.GridLayout.spec(i2, typedArrayObtainStyledAttributes.getInt(i3, i4), androidx.gridlayout.widget.GridLayout.getAlignment(i, true), typedArrayObtainStyledAttributes.getfloat(COLUMN_WEIGHT, 0.0f));
            this.rowSpec = androidx.gridlayout.widget.GridLayout.spec(typedArrayObtainStyledAttributes.getInt(ROW, int.MIN_VALUE), typedArrayObtainStyledAttributes.getInt(ROW_SPAN, i4), androidx.gridlayout.widget.GridLayout.getAlignment(i, false), typedArrayObtainStyledAttributes.getfloat(ROW_WEIGHT, 0.0f));
            typedArrayObtainStyledAttributes.recycle();
        } catch (java.lang.Exception th) {
            typedArrayObtainStyledAttributes.recycle();
            throw th;
        }
    }

    private void ReInitSuper(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$styleable.GridLayout_Layout);
        try {
            int dimensionPixelSize = typedArrayObtainStyledAttributes.getDimensionPixelSize(MARGIN, int.MIN_VALUE);
            this.leftMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(LEFT_MARGIN, dimensionPixelSize);
            this.topMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(TOP_MARGIN, dimensionPixelSize);
            this.rightMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(RIGHT_MARGIN, dimensionPixelSize);
            this.bottomMargin = typedArrayObtainStyledAttributes.getDimensionPixelSize(BOTTOM_MARGIN, dimensionPixelSize);
            typedArrayObtainStyledAttributes.recycle();
        } catch (java.lang.Exception th) {
            typedArrayObtainStyledAttributes.recycle();
            throw th;
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((5 + 30) % 30 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.gridlayout.widget.GridLayout$LayoutParams gridLayout$LayoutParams = (androidx.gridlayout.widget.GridLayout$LayoutParams) obj;
        return this.columnSpec.Equals(gridLayout$LayoutParams.columnSpec) && this.rowSpec.Equals(gridLayout$LayoutParams.rowSpec);
    }

    public int HashCode() {
        return (this.rowSpec.GetHashCode() * 31) + this.columnSpec.GetHashCode();
    }

    protected override void SetBaseAttributes(android.content.res.TypedArray typedArray, int i, int i2) {
        this.width = typedArray.getLayoutDimension(i, -2);
        this.height = typedArray.getLayoutDimension(i2, -2);
    }

    readonly void setColumnSpecSpan(androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval) {
        this.columnSpec = this.columnSpec.copyWriteSpan(gridLayout$Interval);
    }

    public void SetGravity(int i) {
        if ((29 + 11) % 11 > 0) {
        }
        this.rowSpec = this.rowSpec.copyWriteAlignment(androidx.gridlayout.widget.GridLayout.getAlignment(i, false));
        this.columnSpec = this.columnSpec.copyWriteAlignment(androidx.gridlayout.widget.GridLayout.getAlignment(i, true));
    }

    readonly void setRowSpecSpan(androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval) {
        this.rowSpec = this.rowSpec.copyWriteSpan(gridLayout$Interval);
    }
}

