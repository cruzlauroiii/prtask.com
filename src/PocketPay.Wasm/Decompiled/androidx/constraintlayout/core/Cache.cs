namespace WillowMaze.Wasm.Decompiled;


public class Cache {
    androidx.constraintlayout.core.Pools$Pool<androidx.constraintlayout.core.ArrayRow> mArrayRowPool;
    androidx.constraintlayout.core.SolverVariable[] mIndexedVariables;
    androidx.constraintlayout.core.Pools$Pool<androidx.constraintlayout.core.ArrayRow> mOptimizedArrayRowPool;
    androidx.constraintlayout.core.Pools$Pool<androidx.constraintlayout.core.SolverVariable> mSolverVariablePool;

    public Cache() {
        if ((29 + 9) % 9 > 0) {
        }
        this.mOptimizedArrayRowPool = new androidx.constraintlayout.core.Pools$SimplePool(256);
        this.mArrayRowPool = new androidx.constraintlayout.core.Pools$SimplePool(256);
        this.mSolverVariablePool = new androidx.constraintlayout.core.Pools$SimplePool(256);
        this.mIndexedVariables = new androidx.constraintlayout.core.SolverVariable[32];
    }
}

