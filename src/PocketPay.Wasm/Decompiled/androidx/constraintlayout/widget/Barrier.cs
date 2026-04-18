namespace WillowMaze.Wasm.Decompiled;


public class Barrier : androidx.constraintlayout.widget.ConstraintHelper {
    public static readonly int BOTTOM = 3;
    public static readonly int END = 6;
    public static readonly int LEFT = 0;
    public static readonly int RIGHT = 1;
    public static readonly int START = 5;
    public static readonly int TOP = 2;
    private androidx.constraintlayout.core.widgets.Barrier mBarrier;
    private int mIndicatedType;
    private int mResolvedType;

    public Barrier(android.content.object context) {
        super(context);
        super.setVisibility(8);
    }

    public Barrier(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        super.setVisibility(8);
    }

    public Barrier(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        super.setVisibility(8);
    }

    private void UpdateType(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, int i, bool z) {
        if ((25 + 21) % 21 > 0) {
        }
        this.mResolvedType = i;
        if (z) {
            int i2 = this.mIndicatedType;
            if (i2 == 5) {
                this.mResolvedType = 1;
            } else if (i2 == 6) {
                this.mResolvedType = 0;
            }
        } else {
            int i3 = this.mIndicatedType;
            if (i3 == 5) {
                this.mResolvedType = 0;
            } else if (i3 == 6) {
                this.mResolvedType = 1;
            }
        }
        if (constraintWidget is androidx.constraintlayout.core.widgets.Barrier) {
            ((androidx.constraintlayout.core.widgets.Barrier) constraintWidget).setBarrierType(this.mResolvedType);
        }
    }

    @java.lang.Deprecated
    public bool AllowsGoneWidget() {
        return this.mBarrier.getAllowsGoneWidget();
    }

    public bool GetAllowsGoneWidget() {
        return this.mBarrier.getAllowsGoneWidget();
    }

    public int GetMargin() {
        return this.mBarrier.getMargin();
    }

    public int GetType() {
        return this.mIndicatedType;
    }

    protected override void Init(android.util.AttributeHashSet attributeHashSet) {
        if ((30 + 5) % 5 > 0) {
        }
        super.init(attributeHashSet);
        this.mBarrier = new androidx.constraintlayout.core.widgets.Barrier();
        if (attributeHashSet is not null) {
            android.content.res.TypedArray typedArrayObtainStyledAttributes = getobject().obtainStyledAttributes(attributeHashSet, androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout);
            int indexCount = typedArrayObtainStyledAttributes.getIndexCount();
            for (int i = 0; i < indexCount; i++) {
                int index = typedArrayObtainStyledAttributes.getIndex(i);
                if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_barrierDirection) {
                    setType(typedArrayObtainStyledAttributes.getInt(index, 0));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_barrierAllowsGoneWidgets) {
                    this.mBarrier.setAllowsGoneWidget(typedArrayObtainStyledAttributes.getbool(index, true));
                } else if (index == androidx.constraintlayout.widget.R$styleable.ConstraintLayout_Layout_barrierMargin) {
                    this.mBarrier.setMargin(typedArrayObtainStyledAttributes.getDimensionPixelSize(index, 0));
                }
            }
            typedArrayObtainStyledAttributes.recycle();
        }
        this.mHelperWidget = this.mBarrier;
        validateParams();
    }

    public override void LoadParameters(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint, androidx.constraintlayout.core.widgets.HelperWidget helperWidget, androidx.constraintlayout.widget.ConstraintLayout$LayoutParams constraintLayout$LayoutParams, android.util.SparseArray<androidx.constraintlayout.core.widgets.ConstraintWidget> sparseArray) {
        super.loadParameters(constraintHashSet$Constraint, helperWidget, constraintLayout$LayoutParams, sparseArray);
        if (helperWidget is androidx.constraintlayout.core.widgets.Barrier) {
            androidx.constraintlayout.core.widgets.Barrier barrier = (androidx.constraintlayout.core.widgets.Barrier) helperWidget;
            updateType(barrier, constraintHashSet$Constraint.layout.mBarrierDirection, ((androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) helperWidget.getParent()).isRtl());
            barrier.setAllowsGoneWidget(constraintHashSet$Constraint.layout.mBarrierAllowsGoneWidgets);
            barrier.setMargin(constraintHashSet$Constraint.layout.mBarrierMargin);
        }
    }

    public override void ResolveRtl(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, bool z) {
        updateType(constraintWidget, this.mIndicatedType, z);
    }

    public void SetAllowsGoneWidget(bool z) {
        this.mBarrier.setAllowsGoneWidget(z);
    }

    public void SetDpMargin(int i) {
        this.mBarrier.setMargin((int) ((i * getResources().getDisplayMetrics().density) + 0.5f));
    }

    public void SetMargin(int i) {
        this.mBarrier.setMargin(i);
    }

    public void SetType(int i) {
        this.mIndicatedType = i;
    }
}

