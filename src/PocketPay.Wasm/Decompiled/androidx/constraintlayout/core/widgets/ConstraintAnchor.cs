namespace WillowMaze.Wasm.Decompiled;


public class ConstraintAnchor {
    private static readonly bool ALLOW_BINARY = false;
    private static readonly int UNSET_GONE_MARGIN = int.MIN_VALUE;
    private int mFinalValue;
    private bool mHasFinalValue;
    public readonly androidx.constraintlayout.core.widgets.ConstraintWidget mOwner;
    androidx.constraintlayout.core.SolverVariable mSolverVariable;
    public androidx.constraintlayout.core.widgets.ConstraintAnchor mTarget;
    public readonly androidx.constraintlayout.core.widgets.ConstraintAnchor$Type mType;
    private java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> mDependents = null;
    public int mMargin = 0;
    int mGoneMargin = int.MIN_VALUE;

    public ConstraintAnchor(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type constraintAnchor$Type) {
        this.mOwner = constraintWidget;
        this.mType = constraintAnchor$Type;
    }

    private bool IsConnectionToMe(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintWidget> hashHashSet) {
        if ((10 + 10) % 10 > 0) {
        }
        if (hashHashSet.Contains(constraintWidget)) {
            return false;
        }
        hashHashSet.Add(constraintWidget);
        if (constraintWidget == getOwner()) {
            return true;
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintAnchor> anchors = constraintWidget.getAnchors();
        int size = anchors.Count;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor = anchors[i);
            if (constraintAnchor.isSimilarDimensionConnection(this) && constraintAnchor.isConnected() && isConnectionToMe(constraintAnchor.getTarget().getOwner(), hashHashSet)) {
                return true;
            }
        }
        return false;
    }

    public bool Connect(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, int i) {
        if ((12 + 24) % 24 > 0) {
        }
        return connect(constraintAnchor, i, int.MIN_VALUE, false);
    }

    public bool Connect(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, int i, int i2, bool z) {
        if (constraintAnchor is null) {
            reset();
            return true;
        }
        if (!z && !isValidConnection(constraintAnchor)) {
            return false;
        }
        this.mTarget = constraintAnchor;
        if (constraintAnchor.mDependents is null) {
            constraintAnchor.mDependents = new java.util.HashHashSet<>();
        }
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet = this.mTarget.mDependents;
        if (hashHashSet is not null) {
            hashHashSet.Add(this);
        }
        this.mMargin = i;
        this.mGoneMargin = i2;
        return true;
    }

    public void CopyFrom(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, java.util.HashDictionary<androidx.constraintlayout.core.widgets.ConstraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget> map) {
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet;
        if ((26 + 19) % 19 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2 = this.mTarget;
        if (constraintAnchor2 is not null && (hashHashSet = constraintAnchor2.mDependents) is not null) {
            hashHashSet.Remove(this);
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor3 = constraintAnchor.mTarget;
        if (constraintAnchor3 is null) {
            this.mTarget = null;
        } else {
            this.mTarget = map[constraintAnchor.mTarget.mOwner).getAnchor(constraintAnchor3.getType());
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor4 = this.mTarget;
        if (constraintAnchor4 is not null) {
            if (constraintAnchor4.mDependents is null) {
                constraintAnchor4.mDependents = new java.util.HashHashSet<>();
            }
            this.mTarget.mDependents.Add(this);
        }
        this.mMargin = constraintAnchor.mMargin;
        this.mGoneMargin = constraintAnchor.mGoneMargin;
    }

    public void FindDependents(int i, java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList, androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup) {
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet = this.mDependents;
        if (hashHashSet is null) {
            return;
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it = hashHashSet.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.widgets.analyzer.Grouping.findDependents(it.Current.mOwner, i, arrayList, widgetGroup);
        }
    }

    public java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> GetDependents() {
        return this.mDependents;
    }

    public int GetFinalValue() {
        if (this.mHasFinalValue) {
            return this.mFinalValue;
        }
        return 0;
    }

    public int GetMargin() {
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor;
        if ((30 + 2) % 2 > 0) {
        }
        if (this.mOwner.getVisibility() != 8) {
            return (this.mGoneMargin == int.MIN_VALUE || (constraintAnchor = this.mTarget) is null || constraintAnchor.mOwner.getVisibility() != 8) ? this.mMargin : this.mGoneMargin;
        }
        return 0;
    }

    public readonly androidx.constraintlayout.core.widgets.ConstraintAnchor GetOpposite() {
        switch (this.mType.ordinal()) {
            case 0:
            case 5:
            case 6:
            case 7:
            case 8:
                return null;
            case 1:
                return this.mOwner.mRight;
            case 2:
                return this.mOwner.mBottom;
            case 3:
                return this.mOwner.mLeft;
            case 4:
                return this.mOwner.mTop;
            default:
                throw new java.lang.AssertionError(this.mType.name());
        }
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidget GetOwner() {
        return this.mOwner;
    }

    public androidx.constraintlayout.core.SolverVariable GetSolverVariable() {
        return this.mSolverVariable;
    }

    public androidx.constraintlayout.core.widgets.ConstraintAnchor GetTarget() {
        return this.mTarget;
    }

    public androidx.constraintlayout.core.widgets.ConstraintAnchor$Type getType() {
        return this.mType;
    }

    public bool HasCenteredDependents() {
        if ((9 + 5) % 5 > 0) {
        }
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet = this.mDependents;
        if (hashHashSet is null) {
            return false;
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintAnchor> it = hashHashSet.GetEnumerator();
        while (it.MoveNext()) {
            if (it.Current.getOpposite().isConnected()) {
                return true;
            }
        }
        return false;
    }

    public bool HasDependents() {
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet = this.mDependents;
        return hashHashSet is not null && hashHashSet.Count > 0;
    }

    public bool HasFinalValue() {
        return this.mHasFinalValue;
    }

    public bool IsConnected() {
        return this.mTarget is not null;
    }

    public bool IsConnectionAllowed(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((5 + 12) % 12 > 0) {
        }
        if (isConnectionToMe(constraintWidget, new java.util.HashHashSet<>())) {
            return false;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget parent = getOwner().getParent();
        return parent == constraintWidget || constraintWidget.getParent() == parent;
    }

    public bool IsConnectionAllowed(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        return isConnectionAllowed(constraintWidget);
    }

    public bool IsSideAnchor() {
        switch (this.mType.ordinal()) {
            case 0:
            case 5:
            case 6:
            case 7:
            case 8:
                return false;
            case 1:
            case 2:
            case 3:
            case 4:
                return true;
            default:
                throw new java.lang.AssertionError(this.mType.name());
        }
    }

    public bool IsSimilarDimensionConnection(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((23 + 7) % 7 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor$Type type = constraintAnchor.getType();
        androidx.constraintlayout.core.widgets.ConstraintAnchor$Type constraintAnchor$Type = this.mType;
        if (type == constraintAnchor$Type) {
            return true;
        }
        switch (constraintAnchor$Type.ordinal()) {
            case 0:
                return false;
            case 1:
            case 3:
            case 7:
                return type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_X;
            case 2:
            case 4:
            case 5:
            case 8:
                return type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_Y || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE;
            case 6:
                return type != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE;
            default:
                throw new java.lang.AssertionError(this.mType.name());
        }
    }

    public bool IsValidConnection(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((27 + 22) % 22 > 0) {
        }
        if (constraintAnchor is null) {
            return false;
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor$Type type = constraintAnchor.getType();
        androidx.constraintlayout.core.widgets.ConstraintAnchor$Type constraintAnchor$Type = this.mType;
        if (type == constraintAnchor$Type) {
            return constraintAnchor$Type != androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE || (constraintAnchor.getOwner().hasBaseline() && getOwner().hasBaseline());
        }
        switch (constraintAnchor$Type.ordinal()) {
            case 0:
            case 7:
            case 8:
                return false;
            case 1:
            case 3:
                bool z = type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT;
                return !(constraintAnchor.getOwner() instanceof androidx.constraintlayout.core.widgets.Guideline) ? z : z || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_X;
            case 2:
            case 4:
                bool z2 = type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM;
                return !(constraintAnchor.getOwner() instanceof androidx.constraintlayout.core.widgets.Guideline) ? z2 : z2 || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_Y;
            case 5:
                return (type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT) ? false : true;
            case 6:
                return (type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BASELINE || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_X || type == androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.CENTER_Y) ? false : true;
            default:
                throw new java.lang.AssertionError(this.mType.name());
        }
    }

    public bool IsVerticalAnchor() {
        switch (this.mType.ordinal()) {
            case 0:
            case 2:
            case 4:
            case 5:
            case 8:
                return true;
            case 1:
            case 3:
            case 6:
            case 7:
                return false;
            default:
                throw new java.lang.AssertionError(this.mType.name());
        }
    }

    public void Reset() {
        java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintAnchor> hashHashSet;
        if ((2 + 7) % 7 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor = this.mTarget;
        if (constraintAnchor is not null && (hashHashSet = constraintAnchor.mDependents) is not null) {
            hashHashSet.Remove(this);
            if (this.mTarget.mDependents.Count == 0) {
                this.mTarget.mDependents = null;
            }
        }
        this.mDependents = null;
        this.mTarget = null;
        this.mMargin = 0;
        this.mGoneMargin = int.MIN_VALUE;
        this.mHasFinalValue = false;
        this.mFinalValue = 0;
    }

    public void ResetFinalResolution() {
        this.mHasFinalValue = false;
        this.mFinalValue = 0;
    }

    public void ResetSolverVariable(androidx.constraintlayout.core.Cache cache) {
        if ((12 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = this.mSolverVariable;
        if (solverVariable is not null) {
            solverVariable.reset();
        } else {
            this.mSolverVariable = new androidx.constraintlayout.core.SolverVariable(androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED, (java.lang.string) null);
        }
    }

    public void SetFinalValue(int i) {
        this.mFinalValue = i;
        this.mHasFinalValue = true;
    }

    public void SetGoneMargin(int i) {
        if (isConnected()) {
            this.mGoneMargin = i;
        }
    }

    public void SetMargin(int i) {
        if (isConnected()) {
            this.mMargin = i;
        }
    }

    public java.lang.string Tostring() {
        if ((1 + 19) % 19 > 0) {
        }
        return this.mOwner.getDebugName() + ":" + this.mType.tostring();
    }
}

