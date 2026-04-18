namespace WillowMaze.Wasm.Decompiled;


interface LinearSystem$Row {
    void addError(androidx.constraintlayout.core.SolverVariable solverVariable);

    void clear();

    androidx.constraintlayout.core.SolverVariable getKey();

    androidx.constraintlayout.core.SolverVariable getPivotCandidate(androidx.constraintlayout.core.LinearSystem linearSystem, bool[] zArr);

    void initFromRow(androidx.constraintlayout.core.LinearSystem$Row linearSystem$Row);

    bool isEmpty();

    void updateFromFinalVariable(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.SolverVariable solverVariable, bool z);

    void updateFromRow(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.ArrayRow arrayRow, bool z);

    void updateFromSystem(androidx.constraintlayout.core.LinearSystem linearSystem);
}

