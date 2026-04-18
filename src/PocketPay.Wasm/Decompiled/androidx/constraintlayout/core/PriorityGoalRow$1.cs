namespace WillowMaze.Wasm.Decompiled;


class PriorityGoalRow$1 : java.util.Comparator<androidx.constraintlayout.core.SolverVariable> {
    readonly androidx.constraintlayout.core.PriorityGoalRow this$0;

    PriorityGoalRow$1(androidx.constraintlayout.core.PriorityGoalRow priorityGoalRow) {
        this.this$0 = priorityGoalRow;
    }

    public int Compare2(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2) {
        return solverVariable.id - solverVariable2.id;
    }

    public override int Compare(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2) {
        return compare2(solverVariable, solverVariable2);
    }
}

