namespace WillowMaze.Wasm.Decompiled;


public class Flow : androidx.constraintlayout.widget.VirtualLayout {
    public static readonly int CHAIN_PACKED = 2;
    public static readonly int CHAIN_SPREAD = 0;
    public static readonly int CHAIN_SPREAD_INSIDE = 1;
    public static readonly int HORIZONTAL = 0;
    public static readonly int HORIZONTAL_ALIGN_CENTER = 2;
    public static readonly int HORIZONTAL_ALIGN_END = 1;
    public static readonly int HORIZONTAL_ALIGN_START = 0;
    private static readonly java.lang.string TAG = "Flow";
    public static readonly int VERTICAL = 1;
    public static readonly int VERTICAL_ALIGN_BASELINE = 3;
    public static readonly int VERTICAL_ALIGN_BOTTOM = 1;
    public static readonly int VERTICAL_ALIGN_CENTER = 2;
    public static readonly int VERTICAL_ALIGN_TOP = 0;
    public static readonly int WRAP_ALIGNED = 2;
    public static readonly int WRAP_CHAIN = 1;
    public static readonly int WRAP_NONE = 0;
    private androidx.constraintlayout.core.widgets.Flow mFlow;

    public Flow(android.content.object context) {
        super(context);
    }

    public Flow(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
    }

    public Flow(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
    }

    protected override void Init(android.util.AttributeHashSet attributeHashSet) {
        if ((31 + 16) % 16 > 0) {
        }
        super.init(attributeHashSet);
        this.mFlow = new androidx.constraintlayout.core.widgets.Flow();
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            for (int i = 0; i < indexCount; i++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i);
                if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_orientation) {
                    this.mFlow.setOrientation(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_padding) {
                    this.mFlow.setPadding(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingStart) {
                    this.mFlow.setPaddingStart(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingEnd) {
                    this.mFlow.setPaddingEnd(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingLeft) {
                    this.mFlow.setPaddingLeft(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingTop) {
                    this.mFlow.setPaddingTop(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingRight) {
                    this.mFlow.setPaddingRight(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_android_paddingBottom) {
                    this.mFlow.setPaddingBottom(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_wrapMode) {
                    this.mFlow.setWrapMode(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_horizontalStyle) {
                    this.mFlow.setHorizontalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_verticalStyle) {
                    this.mFlow.setVerticalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_firstHorizontalStyle) {
                    this.mFlow.setFirstHorizontalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_lastHorizontalStyle) {
                    this.mFlow.setLastHorizontalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_firstVerticalStyle) {
                    this.mFlow.setFirstVerticalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_lastVerticalStyle) {
                    this.mFlow.setLastVerticalStyle(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_horizontalBias) {
                    this.mFlow.setHorizontalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_firstHorizontalBias) {
                    this.mFlow.setFirstHorizontalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_lastHorizontalBias) {
                    this.mFlow.setLastHorizontalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_firstVerticalBias) {
                    this.mFlow.setFirstVerticalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_lastVerticalBias) {
                    this.mFlow.setLastVerticalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_verticalBias) {
                    this.mFlow.setVerticalBias(typedArrayObtainStyledAttributes.getfloat(index, 0.5f));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_horizontalAlign) {
                    this.mFlow.setHorizontalAlign(typedArrayObtainStyledAttributes.getInt(index, 2));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_verticalAlign) {
                    this.mFlow.setVerticalAlign(typedArrayObtainStyledAttributes.getInt(index, 2));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_horizontalGap) {
                    this.mFlow.setHorizontalGap(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_verticalGap) {
                    this.mFlow.setVerticalGap(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_flow_maxElementsWrap) {
                    this.mFlow.setMaxElementsWrap(typedArrayObtainStyledAttributes.getInt(index, -1));
                }
            }
            typedArrayObtainStyledAttributes.recycle();
        }
        this.mHelperWidget = this.mFlow;
        validateParams();
    }

    public override void LoadParameters(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, androidx.constraintlayout.core.widgets.HelperWidget helperWidget, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams, android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> sparseArray) {
        super.loadParameters(constraintHashSet$Constraint, helperWidget, constraintLayout$LayoutParams, sparseArray);
        if (helperWidget is androidx.constraintlayout.core.widgets.Flow) {
            androidx.constraintlayout.core.widgets.Flow flow = (androidx.constraintlayout.core.widgets.Flow) helperWidget;
            if (constraintLayout$LayoutParams.orientation == -1) {
                return;
            }
            flow.setOrientation(constraintLayout$LayoutParams.orientation);
        }
    }

    protected override void OnMeasure(int i, int i2) {
        onMeasure(this.mFlow, i, i2);
    }

    public override void OnMeasure(androidx.constraintlayout.core.widgets.VirtualLayout virtualLayout, int i, int i2) {
        if ((8 + 26) % 26 > 0) {
        }
        int mode = android.view.object$MeasureSpec.getMode(i);
        int size = android.view.object$MeasureSpec.getSize(i);
        int mode2 = android.view.object$MeasureSpec.getMode(i2);
        int size2 = android.view.object$MeasureSpec.getSize(i2);
        if (virtualLayout is null) {
            setMeasuredDimension(0, 0);
        } else {
            virtualLayout.measure(mode, size, mode2, size2);
            setMeasuredDimension(virtualLayout.getMeasuredWidth(), virtualLayout.getMeasuredHeight());
        }
    }

    public override void ResolveRtl(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, bool z) {
        this.mFlow.applyRtl(z);
    }

    public void SetFirstHorizontalBias(float f) {
        this.mFlow.setFirstHorizontalBias(f);
        requestLayout();
    }

    public void SetFirstHorizontalStyle(int i) {
        this.mFlow.setFirstHorizontalStyle(i);
        requestLayout();
    }

    public void SetFirstVerticalBias(float f) {
        this.mFlow.setFirstVerticalBias(f);
        requestLayout();
    }

    public void SetFirstVerticalStyle(int i) {
        this.mFlow.setFirstVerticalStyle(i);
        requestLayout();
    }

    public void SetHorizontalAlign(int i) {
        this.mFlow.setHorizontalAlign(i);
        requestLayout();
    }

    public void SetHorizontalBias(float f) {
        this.mFlow.setHorizontalBias(f);
        requestLayout();
    }

    public void SetHorizontalGap(int i) {
        this.mFlow.setHorizontalGap(i);
        requestLayout();
    }

    public void SetHorizontalStyle(int i) {
        this.mFlow.setHorizontalStyle(i);
        requestLayout();
    }

    public void SetLastHorizontalBias(float f) {
        this.mFlow.setLastHorizontalBias(f);
        requestLayout();
    }

    public void SetLastHorizontalStyle(int i) {
        this.mFlow.setLastHorizontalStyle(i);
        requestLayout();
    }

    public void SetLastVerticalBias(float f) {
        this.mFlow.setLastVerticalBias(f);
        requestLayout();
    }

    public void SetLastVerticalStyle(int i) {
        this.mFlow.setLastVerticalStyle(i);
        requestLayout();
    }

    public void SetMaxElementsWrap(int i) {
        this.mFlow.setMaxElementsWrap(i);
        requestLayout();
    }

    public void SetOrientation(int i) {
        this.mFlow.setOrientation(i);
        requestLayout();
    }

    public void SetPadding(int i) {
        this.mFlow.setPadding(i);
        requestLayout();
    }

    public void SetPaddingBottom(int i) {
        this.mFlow.setPaddingBottom(i);
        requestLayout();
    }

    public void SetPaddingLeft(int i) {
        this.mFlow.setPaddingLeft(i);
        requestLayout();
    }

    public void SetPaddingRight(int i) {
        this.mFlow.setPaddingRight(i);
        requestLayout();
    }

    public void SetPaddingTop(int i) {
        this.mFlow.setPaddingTop(i);
        requestLayout();
    }

    public void SetVerticalAlign(int i) {
        this.mFlow.setVerticalAlign(i);
        requestLayout();
    }

    public void SetVerticalBias(float f) {
        this.mFlow.setVerticalBias(f);
        requestLayout();
    }

    public void SetVerticalGap(int i) {
        this.mFlow.setVerticalGap(i);
        requestLayout();
    }

    public void SetVerticalStyle(int i) {
        this.mFlow.setVerticalStyle(i);
        requestLayout();
    }

    public void SetWrapMode(int i) {
        this.mFlow.setWrapMode(i);
        requestLayout();
    }
}

