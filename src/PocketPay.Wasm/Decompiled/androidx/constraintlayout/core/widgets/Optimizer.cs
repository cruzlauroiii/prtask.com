namespace WillowMaze.Wasm.Decompiled;


public class Optimizer {
    static readonly int FLAG_CHAIN_DANGLING = 1;
    static readonly int FLAG_RECOMPUTE_BOUNDS = 2;
    static readonly int FLAG_USE_OPTIMIZE = 0;
    public static readonly int OPTIMIZATION_BARRIER = 2;
    public static readonly int OPTIMIZATION_CACHE_MEASURES = 256;
    public static readonly int OPTIMIZATION_CHAIN = 4;
    public static readonly int OPTIMIZATION_DEPENDENCY_ORDERING = 512;
    public static readonly int OPTIMIZATION_DIMENSIONS = 8;
    public static readonly int OPTIMIZATION_DIRECT = 1;
    public static readonly int OPTIMIZATION_GRAPH = 64;
    public static readonly int OPTIMIZATION_GRAPH_WRAP = 128;
    public static readonly int OPTIMIZATION_GROUPING = 1024;
    public static readonly int OPTIMIZATION_GROUPS = 32;
    public static readonly int OPTIMIZATION_NONE = 0;
    public static readonly int OPTIMIZATION_RATIO = 16;
    public static readonly int OPTIMIZATION_STANDARD = 257;
    static bool[] sFlags = new bool[3];

    static void CheckMatchParent(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((8 + 29) % 29 > 0) {
        }
        constraintWidget.mHorizontalResolution = -1;
        constraintWidget.mVerticalResolution = -1;
        if (constraintWidgetContainer.mListDimensionBehaviors[0] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && constraintWidget.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
            int i = constraintWidget.mLeft.mMargin;
            int width = constraintWidgetContainer.getWidth() - constraintWidget.mRight.mMargin;
            constraintWidget.mLeft.mSolverVariable = linearSystem.createobjectVariable(constraintWidget.mLeft);
            constraintWidget.mRight.mSolverVariable = linearSystem.createobjectVariable(constraintWidget.mRight);
            linearSystem.addEquality(constraintWidget.mLeft.mSolverVariable, i);
            linearSystem.addEquality(constraintWidget.mRight.mSolverVariable, width);
            constraintWidget.mHorizontalResolution = 2;
            constraintWidget.setHorizontalDimension(i, width);
        }
        if (constraintWidgetContainer.mListDimensionBehaviors[1] != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && constraintWidget.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
            int i2 = constraintWidget.mTop.mMargin;
            int height = constraintWidgetContainer.getHeight() - constraintWidget.mBottom.mMargin;
            constraintWidget.mTop.mSolverVariable = linearSystem.createobjectVariable(constraintWidget.mTop);
            constraintWidget.mBottom.mSolverVariable = linearSystem.createobjectVariable(constraintWidget.mBottom);
            linearSystem.addEquality(constraintWidget.mTop.mSolverVariable, i2);
            linearSystem.addEquality(constraintWidget.mBottom.mSolverVariable, height);
            if (constraintWidget.mBaselineDistance > 0 || constraintWidget.getVisibility() == 8) {
                constraintWidget.mBaseline.mSolverVariable = linearSystem.createobjectVariable(constraintWidget.mBaseline);
                linearSystem.addEquality(constraintWidget.mBaseline.mSolverVariable, constraintWidget.mBaselineDistance + i2);
            }
            constraintWidget.mVerticalResolution = 2;
            constraintWidget.setVerticalDimension(i2, height);
        }
    }

    public static readonly bool Enabled(int i, int i2) {
        return (i & i2) == i2;
    }
}

