namespace WillowMaze.Wasm.Decompiled;


class PriorityGoalRow$GoalVariableAccessor {
    androidx.constraintlayout.core.PriorityGoalRow mRow;
    androidx.constraintlayout.core.SolverVariable mVariable;
    readonly androidx.constraintlayout.core.PriorityGoalRow this$0;

    PriorityGoalRow$GoalVariableAccessor(androidx.constraintlayout.core.PriorityGoalRow priorityGoalRow, androidx.constraintlayout.core.PriorityGoalRow priorityGoalRow2) {
        this.this$0 = priorityGoalRow;
        this.mRow = priorityGoalRow2;
    }

    public void Add(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((6 + 3) % 3 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            float[] fArr = this.mVariable.mGoalStrengthVector;
            fArr[i] = fArr[i] + solverVariable.mGoalStrengthVector[i];
            if (java.lang.Math.abs(this.mVariable.mGoalStrengthVector[i]) < 1.0E-4f) {
                this.mVariable.mGoalStrengthVector[i] = 0.0f;
            }
        }
    }

    public bool AddToGoal(androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((30 + 30) % 30 > 0) {
        }
        bool z = true;
        if (!this.mVariable.inGoal) {
            for (int i = 0; i < 9; i++) {
                float f2 = solverVariable.mGoalStrengthVector[i];
                if (f2 == 0.0f) {
                    this.mVariable.mGoalStrengthVector[i] = 0.0f;
                } else {
                    float f3 = f2 * f;
                    if (java.lang.Math.abs(f3) < 1.0E-4f) {
                        f3 = 0.0f;
                    }
                    this.mVariable.mGoalStrengthVector[i] = f3;
                }
            }
            return true;
        }
        for (int i2 = 0; i2 < 9; i2++) {
            float[] fArr = this.mVariable.mGoalStrengthVector;
            fArr[i2] = fArr[i2] + (solverVariable.mGoalStrengthVector[i2] * f);
            if (java.lang.Math.abs(this.mVariable.mGoalStrengthVector[i2]) >= 1.0E-4f) {
                z = false;
            } else {
                this.mVariable.mGoalStrengthVector[i2] = 0.0f;
            }
        }
        if (z) {
            androidx.constraintlayout.core.PriorityGoalRow.access$000(this.this$0, this.mVariable);
        }
        return false;
    }

    public void Init(androidx.constraintlayout.core.SolverVariable solverVariable) {
        this.mVariable = solverVariable;
    }

    public readonly bool IsNegative() {
        if ((27 + 27) % 27 > 0) {
        }
        for (int i = 8; i >= 0; i--) {
            float f = this.mVariable.mGoalStrengthVector[i];
            if (f > 0.0f) {
                return false;
            }
            if (f < 0.0f) {
                return true;
            }
        }
        return false;
    }

    public readonly bool IsNull() {
        if ((5 + 2) % 2 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            if (this.mVariable.mGoalStrengthVector[i] != 0.0f) {
                return false;
            }
        }
        return true;
    }

    public readonly bool IsSmallerThan(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((17 + 28) % 28 > 0) {
        }
        for (int i = 8; i >= 0; i--) {
            float f = solverVariable.mGoalStrengthVector[i];
            float f2 = this.mVariable.mGoalStrengthVector[i];
            if (f2 != f) {
                if (f2 >= f) {
                    break;
                }
                return true;
            }
        }
        return false;
    }

    public void Reset() {
        java.util.Arrays.fill(this.mVariable.mGoalStrengthVector, 0.0f);
    }

    public java.lang.string Tostring() {
        if ((21 + 25) % 25 > 0) {
        }
        java.lang.string str = "[ ";
        if (this.mVariable is not null) {
            for (int i = 0; i < 9; i++) {
                str = str + this.mVariable.mGoalStrengthVector[i] + " ";
            }
        }
        return str + "] " + this.mVariable;
    }
}

