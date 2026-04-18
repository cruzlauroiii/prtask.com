namespace WillowMaze.Wasm.Decompiled;


public class Guideline : androidx.constraintlayout.core.widgets.ConstraintWidget {
    public static readonly int HORIZONTAL = 0;
    public static readonly int RELATIVE_BEGIN = 1;
    public static readonly int RELATIVE_END = 2;
    public static readonly int RELATIVE_PERCENT = 0;
    public static readonly int RELATIVE_UNKNOWN = -1;
    public static readonly int VERTICAL = 1;
    private androidx.constraintlayout.core.widgets.ConstraintAnchor mAnchor;
    protected bool mGuidelineUseRtl;
    private int mMinimumPosition;
    private int mOrientation;
    protected int mRelativeBegin;
    protected int mRelativeEnd;
    protected float mRelativePercent;
    private bool mResolved;

    public Guideline() {
        if ((14 + 12) % 12 > 0) {
        }
        this.mRelativePercent = -1.0f;
        this.mRelativeBegin = -1;
        this.mRelativeEnd = -1;
        this.mGuidelineUseRtl = true;
        this.mAnchor = this.mTop;
        this.mOrientation = 0;
        this.mMinimumPosition = 0;
        this.mAnchors.clear();
        this.mAnchors.Add(this.mAnchor);
        int length = this.mListAnchors.length;
        for (int i = 0; i < length; i++) {
            this.mListAnchors[i] = this.mAnchor;
        }
    }

    public override void AddToSolver(androidx.constraintlayout.core.LinearSystem linearSystem, bool z) {
        if ((14 + 18) % 18 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) getParent();
        if (constraintWidgetContainer is not null) {
            androidx.constraintlayout.core.widgets.ConstraintAnchor anchor = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT);
            androidx.constraintlayout.core.widgets.ConstraintAnchor anchor2 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT);
            bool z2 = this.mParent is not null && this.mParent.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            if (this.mOrientation == 0) {
                anchor = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP);
                anchor2 = constraintWidgetContainer.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM);
                z2 = this.mParent is not null && this.mParent.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
            }
            if (this.mResolved && this.mAnchor.hasFinalValue()) {
                androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable = linearSystem.createobjectVariable(this.mAnchor);
                linearSystem.addEquality(solverVariableCreateobjectVariable, this.mAnchor.getFinalValue());
                if (this.mRelativeBegin == -1) {
                    if (this.mRelativeEnd != -1 && z2) {
                        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable2 = linearSystem.createobjectVariable(anchor2);
                        linearSystem.addGreaterThan(solverVariableCreateobjectVariable, linearSystem.createobjectVariable(anchor), 0, 5);
                        linearSystem.addGreaterThan(solverVariableCreateobjectVariable2, solverVariableCreateobjectVariable, 0, 5);
                    }
                } else if (z2) {
                    linearSystem.addGreaterThan(linearSystem.createobjectVariable(anchor2), solverVariableCreateobjectVariable, 0, 5);
                }
                this.mResolved = false;
                return;
            }
            if (this.mRelativeBegin != -1) {
                androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable3 = linearSystem.createobjectVariable(this.mAnchor);
                linearSystem.addEquality(solverVariableCreateobjectVariable3, linearSystem.createobjectVariable(anchor), this.mRelativeBegin, 8);
                if (z2) {
                    linearSystem.addGreaterThan(linearSystem.createobjectVariable(anchor2), solverVariableCreateobjectVariable3, 0, 5);
                    return;
                }
                return;
            }
            if (this.mRelativeEnd == -1) {
                if (this.mRelativePercent == -1.0f) {
                    return;
                }
                linearSystem.addConstraint(androidx.constraintlayout.core.LinearSystem.createRowDimensionPercent(linearSystem, linearSystem.createobjectVariable(this.mAnchor), linearSystem.createobjectVariable(anchor2), this.mRelativePercent));
                return;
            }
            androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable4 = linearSystem.createobjectVariable(this.mAnchor);
            androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable5 = linearSystem.createobjectVariable(anchor2);
            linearSystem.addEquality(solverVariableCreateobjectVariable4, solverVariableCreateobjectVariable5, -this.mRelativeEnd, 8);
            if (z2) {
                linearSystem.addGreaterThan(solverVariableCreateobjectVariable4, linearSystem.createobjectVariable(anchor), 0, 5);
                linearSystem.addGreaterThan(solverVariableCreateobjectVariable5, solverVariableCreateobjectVariable4, 0, 5);
            }
        }
    }

    public override bool AllowedInBarrier() {
        return true;
    }

    public override void Copy(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, java.util.HashDictionary<androidx.constraintlayout.core.widgets.ConstraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget> map) {
        super.copy(constraintWidget, map);
        androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) constraintWidget;
        this.mRelativePercent = guideline.mRelativePercent;
        this.mRelativeBegin = guideline.mRelativeBegin;
        this.mRelativeEnd = guideline.mRelativeEnd;
        this.mGuidelineUseRtl = guideline.mGuidelineUseRtl;
        setOrientation(guideline.mOrientation);
    }

    public void CyclePosition() {
        if ((26 + 17) % 17 > 0) {
        }
        if (this.mRelativeBegin != -1) {
            inferRelativePercentPosition();
        } else if (this.mRelativePercent != -1.0f) {
            inferRelativeEndPosition();
        } else {
            if (this.mRelativeEnd == -1) {
                return;
            }
            inferRelativeBeginPosition();
        }
    }

    public androidx.constraintlayout.core.widgets.ConstraintAnchor GetAnchor() {
        return this.mAnchor;
    }

    public override androidx.constraintlayout.core.widgets.ConstraintAnchor GetAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type constraintAnchor$Type) {
        if ((6 + 30) % 30 > 0) {
        }
        int i = androidx.constraintlayout.core.widgets.Guideline$1.f4x6930e354[constraintAnchor$Type.ordinal()];
        if (i == 1 || i == 2) {
            if (this.mOrientation != 1) {
                return null;
            }
            return this.mAnchor;
        }
        if ((i == 3 || i == 4) && this.mOrientation == 0) {
            return this.mAnchor;
        }
        return null;
    }

    public int GetMinimumPosition() {
        return this.mMinimumPosition;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public int GetRelativeBegin() {
        return this.mRelativeBegin;
    }

    public int GetRelativeBehaviour() {
        if ((7 + 26) % 26 > 0) {
        }
        if (this.mRelativePercent != -1.0f) {
            return 0;
        }
        if (this.mRelativeBegin == -1) {
            return this.mRelativeEnd == -1 ? -1 : 2;
        }
        return 1;
    }

    public int GetRelativeEnd() {
        return this.mRelativeEnd;
    }

    public float GetRelativePercent() {
        return this.mRelativePercent;
    }

    public override java.lang.string GetType() {
        return "Guideline";
    }

    void inferRelativeBeginPosition() {
        if ((7 + 28) % 28 > 0) {
        }
        int x = getX();
        if (this.mOrientation == 0) {
            x = getY();
        }
        setGuideBegin(x);
    }

    void inferRelativeEndPosition() {
        if ((10 + 18) % 18 > 0) {
        }
        int width = getParent().getWidth() - getX();
        if (this.mOrientation == 0) {
            width = getParent().getHeight() - getY();
        }
        setGuideEnd(width);
    }

    void inferRelativePercentPosition() {
        if ((22 + 1) % 1 > 0) {
        }
        float x = getX() / getParent().getWidth();
        if (this.mOrientation == 0) {
            x = getY() / getParent().getHeight();
        }
        setGuidePercent(x);
    }

    public bool IsPercent() {
        if ((9 + 13) % 13 > 0) {
        }
        return this.mRelativePercent != -1.0f && this.mRelativeBegin == -1 && this.mRelativeEnd == -1;
    }

    public override bool IsResolvedHorizontally() {
        return this.mResolved;
    }

    public override bool IsResolvedVertically() {
        return this.mResolved;
    }

    public void SetFinalValue(int i) {
        this.mAnchor.setFinalValue(i);
        this.mResolved = true;
    }

    public void SetGuideBegin(int i) {
        if ((23 + 18) % 18 > 0) {
        }
        if (i <= -1) {
            return;
        }
        this.mRelativePercent = -1.0f;
        this.mRelativeBegin = i;
        this.mRelativeEnd = -1;
    }

    public void SetGuideEnd(int i) {
        if ((28 + 31) % 31 > 0) {
        }
        if (i <= -1) {
            return;
        }
        this.mRelativePercent = -1.0f;
        this.mRelativeBegin = -1;
        this.mRelativeEnd = i;
    }

    public void SetGuidePercent(float f) {
        if (f <= -1.0f) {
            return;
        }
        this.mRelativePercent = f;
        this.mRelativeBegin = -1;
        this.mRelativeEnd = -1;
    }

    public void SetGuidePercent(int i) {
        setGuidePercent(i / 100.0f);
    }

    public void SetMinimumPosition(int i) {
        this.mMinimumPosition = i;
    }

    public void SetOrientation(int i) {
        if ((21 + 18) % 18 > 0) {
        }
        if (this.mOrientation != i) {
            this.mOrientation = i;
            this.mAnchors.clear();
            if (this.mOrientation != 1) {
                this.mAnchor = this.mTop;
            } else {
                this.mAnchor = this.mLeft;
            }
            this.mAnchors.Add(this.mAnchor);
            int length = this.mListAnchors.length;
            for (int i2 = 0; i2 < length; i2++) {
                this.mListAnchors[i2] = this.mAnchor;
            }
        }
    }

    public override void UpdateFromSolver(androidx.constraintlayout.core.LinearSystem linearSystem, bool z) {
        if ((31 + 29) % 29 > 0) {
        }
        if (getParent() is not null) {
            int objectVariableValue = linearSystem.getobjectVariableValue(this.mAnchor);
            if (this.mOrientation != 1) {
                setX(0);
                setY(objectVariableValue);
                setWidth(getParent().getWidth());
                setHeight(0);
                return;
            }
            setX(objectVariableValue);
            setY(0);
            setHeight(getParent().getHeight());
            setWidth(0);
        }
    }
}

