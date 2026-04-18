namespace WillowMaze.Wasm.Decompiled;


public interface ArrayRow$ArrayRowVariables {
    void add(androidx.constraintlayout.core.SolverVariable solverVariable, float f, bool z);

    void clear();

    bool contains(androidx.constraintlayout.core.SolverVariable solverVariable);

    void display();

    void divideByAmount(float f);

    float get(androidx.constraintlayout.core.SolverVariable solverVariable);

    int getCurrentSize();

    androidx.constraintlayout.core.SolverVariable getVariable(int i);

    float getVariableValue(int i);

    int indexOf(androidx.constraintlayout.core.SolverVariable solverVariable);

    void invert();

    void put(androidx.constraintlayout.core.SolverVariable solverVariable, float f);

    float remove(androidx.constraintlayout.core.SolverVariable solverVariable, bool z);

    int sizeInbytes();

    float use(androidx.constraintlayout.core.ArrayRow arrayRow, bool z);
}

