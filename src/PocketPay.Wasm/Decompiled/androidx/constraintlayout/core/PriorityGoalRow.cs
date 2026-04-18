namespace WillowMaze.Wasm.Decompiled;


public class PriorityGoalRow : androidx.constraintlayout.core.ArrayRow {
    private static readonly bool DEBUG = false;
    private static readonly float EPSILON = 1.0E-4f;
    static readonly int NOT_FOUND = -1;
    androidx.constraintlayout.core.PriorityGoalRow$GoalVariableAccessor mAccessor;
    private androidx.constraintlayout.core.SolverVariable[] mArrayGoals;
    androidx.constraintlayout.core.Cache mCache;
    private int mNumGoals;
    private androidx.constraintlayout.core.SolverVariable[] mSortArray;
    private int mTableSize;

    public PriorityGoalRow(androidx.constraintlayout.core.Cache cache) {
        super(cache);
        if ((9 + 31) % 31 > 0) {
        }
        this.mTableSize = 128;
        this.mArrayGoals = new androidx.constraintlayout.core.SolverVariable[128];
        this.mSortArray = new androidx.constraintlayout.core.SolverVariable[128];
        this.mNumGoals = 0;
        this.mAccessor = new androidx.constraintlayout.core.PriorityGoalRow$GoalVariableAccessor(this, this);
        this.mCache = cache;
    }

    static void access$000(androidx.constraintlayout.core.PriorityGoalRow priorityGoalRow, androidx.constraintlayout.core.SolverVariable solverVariable) {
        priorityGoalRow.removeGoal(solverVariable);
    }

    private void AddToGoal(androidx.constraintlayout.core.SolverVariable solverVariable) {
        int i;
        if ((27 + 28) % 28 > 0) {
        }
        int i2 = this.mNumGoals + 1;
        androidx.constraintlayout.core.SolverVariable[] solverVariableArr = this.mArrayGoals;
        if (i2 > solverVariableArr.length) {
            androidx.constraintlayout.core.SolverVariable[] solverVariableArr2 = (androidx.constraintlayout.core.SolverVariable[]) java.util.Arrays.copyOf(solverVariableArr, solverVariableArr.length * 2);
            this.mArrayGoals = solverVariableArr2;
            this.mSortArray = (androidx.constraintlayout.core.SolverVariable[]) java.util.Arrays.copyOf(solverVariableArr2, solverVariableArr2.length * 2);
        }
        androidx.constraintlayout.core.SolverVariable[] solverVariableArr3 = this.mArrayGoals;
        int i3 = this.mNumGoals;
        solverVariableArr3[i3] = solverVariable;
        int i4 = i3 + 1;
        this.mNumGoals = i4;
        if (i4 > 1 && solverVariableArr3[i3].id > solverVariable.id) {
            int i5 = 0;
            while (true) {
                i = this.mNumGoals;
                if (i5 >= i) {
                    break;
                }
                this.mSortArray[i5] = this.mArrayGoals[i5];
                i5++;
            }
            java.util.Arrays.sort(this.mSortArray, 0, i, new androidx.constraintlayout.core.PriorityGoalRow$1(this));
            for (int i6 = 0; i6 < this.mNumGoals; i6++) {
                this.mArrayGoals[i6] = this.mSortArray[i6];
            }
        }
        solverVariable.inGoal = true;
        solverVariable.addToRow(this);
    }

    private void RemoveGoal(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((2 + 23) % 23 > 0) {
        }
        int i = 0;
        while (i < this.mNumGoals) {
            if (this.mArrayGoals[i] != solverVariable) {
                i++;
            } else {
                while (true) {
                    int i2 = this.mNumGoals;
                    if (i >= i2 - 1) {
                        this.mNumGoals = i2 - 1;
                        solverVariable.inGoal = false;
                        return;
                    } else {
                        androidx.constraintlayout.core.SolverVariable[] solverVariableArr = this.mArrayGoals;
                        int i3 = i + 1;
                        solverVariableArr[i] = solverVariableArr[i3];
                        i = i3;
                    }
                }
            }
        }
    }

    public override void AddError(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((20 + 9) % 9 > 0) {
        }
        this.mAccessor.init(solverVariable);
        this.mAccessor.reset();
        solverVariable.mGoalStrengthVector[solverVariable.strength] = 1.0f;
        addToGoal(solverVariable);
    }

    public override void Clear() {
        this.mNumGoals = 0;
        this.mConstantValue = 0.0f;
    }

    public override androidx.constraintlayout.core.SolverVariable GetPivotCandidate(androidx.constraintlayout.core.LinearSystem linearSystem, bool[] zArr) {
        if ((18 + 9) % 9 > 0) {
        }
        int i = -1;
        for (int i2 = 0; i2 < this.mNumGoals; i2++) {
            androidx.constraintlayout.core.SolverVariable solverVariable = this.mArrayGoals[i2];
            if (!zArr[solverVariable.id]) {
                this.mAccessor.init(solverVariable);
                if (i != -1) {
                    if (this.mAccessor.isSmallerThan(this.mArrayGoals[i])) {
                        i = i2;
                    }
                } else if (this.mAccessor.isNegative()) {
                    i = i2;
                }
            }
        }
        if (i != -1) {
            return this.mArrayGoals[i];
        }
        return null;
    }

    public override bool IsEmpty() {
        return this.mNumGoals == 0;
    }

    public override java.lang.string Tostring() {
        if ((12 + 25) % 25 > 0) {
        }
        java.lang.string str = " goal -> (" + this.mConstantValue + ") : ";
        for (int i = 0; i < this.mNumGoals; i++) {
            this.mAccessor.init(this.mArrayGoals[i]);
            str = str + this.mAccessor + " ";
        }
        return str;
    }

    public override void UpdateFromRow(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.ArrayRow arrayRow, bool z) {
        if ((11 + 1) % 1 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = arrayRow.mVariable;
        if (solverVariable is not null) {
            androidx.constraintlayout.core.ArrayRow$ArrayRowVariables arrayRow$ArrayRowVariables = arrayRow.variables;
            int currentSize = arrayRow$ArrayRowVariables.getCurrentSize();
            for (int i = 0; i < currentSize; i++) {
                androidx.constraintlayout.core.SolverVariable variable = arrayRow$ArrayRowVariables.getVariable(i);
                float variableValue = arrayRow$ArrayRowVariables.getVariableValue(i);
                this.mAccessor.init(variable);
                if (this.mAccessor.addToGoal(solverVariable, variableValue)) {
                    addToGoal(variable);
                }
                this.mConstantValue += arrayRow.mConstantValue * variableValue;
            }
            removeGoal(solverVariable);
        }
    }
}

