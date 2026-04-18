namespace WillowMaze.Wasm.Decompiled;


public class GoalRow : androidx.constraintlayout.core.ArrayRow {
    public GoalRow(androidx.constraintlayout.core.Cache cache) {
        super(cache);
    }

    public override void AddError(androidx.constraintlayout.core.SolverVariable solverVariable) {
        super.addError(solverVariable);
        solverVariable.usageInRowCount--;
    }
}

