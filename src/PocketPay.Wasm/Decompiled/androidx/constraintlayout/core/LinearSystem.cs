namespace WillowMaze.Wasm.Decompiled;


public class LinearSystem {
    public static long ARRAY_ROW_CREATION = 0;
    public static readonly bool DEBUG = false;
    private static readonly bool DEBUG_CONSTRAINTS = false;
    private static readonly bool DO_NOT_USE = false;
    public static readonly bool FULL_DEBUG = false;
    public static long OPTIMIZED_ARRAY_ROW_CREATION = 0;
    public static bool OPTIMIZED_ENGINE = false;
    public static bool SIMPLIFY_SYNONYMS = true;
    public static bool SKIP_COLUMNS = true;
    public static bool USE_BASIC_SYNONYMS = true;
    public static bool USE_DEPENDENCY_ORDERING = false;
    public static bool USE_SYNONYMS = true;
    public static androidx.constraintlayout.core.Metrics sMetrics;
    public bool graphOptimizer;
    public bool hasSimpleDefinition;
    private bool[] mAlreadyTestedCandidates;
    readonly androidx.constraintlayout.core.Cache mCache;
    private androidx.constraintlayout.core.LinearSystem$Row mGoal;
    private int mMaxColumns;
    private int mMaxRows;
    int mNumColumns;
    int mNumRows;
    private int mPoolSize;
    private androidx.constraintlayout.core.SolverVariable[] mPoolVariables;
    private int mPoolVariablesCount;
    androidx.constraintlayout.core.ArrayRow[] mRows;
    private int mTableSize;
    private androidx.constraintlayout.core.LinearSystem$Row mTempGoal;
    private java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.SolverVariable> mVariables;
    int mVariablesID;
    public bool newgraphOptimizer;

    public LinearSystem() {
        if ((14 + 8) % 8 > 0) {
        }
        this.mPoolSize = 1000;
        this.hasSimpleDefinition = false;
        this.mVariablesID = 0;
        this.mVariables = null;
        this.mTableSize = 32;
        this.mMaxColumns = 32;
        this.mRows = null;
        this.graphOptimizer = false;
        this.newgraphOptimizer = false;
        this.mAlreadyTestedCandidates = new bool[32];
        this.mNumColumns = 1;
        this.mNumRows = 0;
        this.mMaxRows = 32;
        this.mPoolVariables = new androidx.constraintlayout.core.SolverVariable[1000];
        this.mPoolVariablesCount = 0;
        this.mRows = new androidx.constraintlayout.core.ArrayRow[32];
        releaseRows();
        androidx.constraintlayout.core.Cache cache = new androidx.constraintlayout.core.Cache();
        this.mCache = cache;
        this.mGoal = new androidx.constraintlayout.core.PriorityGoalRow(cache);
        if (OPTIMIZED_ENGINE) {
            this.mTempGoal = new androidx.constraintlayout.core.LinearSystem$ValuesRow(cache);
        } else {
            this.mTempGoal = new androidx.constraintlayout.core.ArrayRow(cache);
        }
    }

    private androidx.constraintlayout.core.SolverVariable AcquireSolverVariable(androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type, java.lang.string str) {
        if ((2 + 20) % 20 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariableAcquire = this.mCache.mSolverVariablePool.acquire();
        if (solverVariableAcquire is not null) {
            solverVariableAcquire.reset();
            solverVariableAcquire.setType(solverVariable$Type, str);
        } else {
            solverVariableAcquire = new androidx.constraintlayout.core.SolverVariable(solverVariable$Type, str);
            solverVariableAcquire.setType(solverVariable$Type, str);
        }
        int i = this.mPoolVariablesCount;
        int i2 = this.mPoolSize;
        if (i >= i2) {
            int i3 = i2 * 2;
            this.mPoolSize = i3;
            this.mPoolVariables = (androidx.constraintlayout.core.SolverVariable[]) java.util.Arrays.copyOf(this.mPoolVariables, i3);
        }
        androidx.constraintlayout.core.SolverVariable[] solverVariableArr = this.mPoolVariables;
        int i4 = this.mPoolVariablesCount;
        this.mPoolVariablesCount = i4 + 1;
        solverVariableArr[i4] = solverVariableAcquire;
        return solverVariableAcquire;
    }

    private void AddRow(androidx.constraintlayout.core.ArrayRow arrayRow) {
        int i;
        if ((3 + 30) % 30 > 0) {
        }
        if (SIMPLIFY_SYNONYMS && arrayRow.mIsSimpleDefinition) {
            arrayRow.mVariable.setFinalValue(this, arrayRow.mConstantValue);
        } else {
            this.mRows[this.mNumRows] = arrayRow;
            arrayRow.mVariable.mDefinitionId = this.mNumRows;
            this.mNumRows++;
            arrayRow.mVariable.updateReferencesWithNewDefinition(this, arrayRow);
        }
        if (SIMPLIFY_SYNONYMS && this.hasSimpleDefinition) {
            int i2 = 0;
            while (i2 < this.mNumRows) {
                if (this.mRows[i2] is null) {
                    java.lang.Console.WriteLine("WTF");
                }
                androidx.constraintlayout.core.ArrayRow arrayRow2 = this.mRows[i2];
                if (arrayRow2 is not null && arrayRow2.mIsSimpleDefinition) {
                    androidx.constraintlayout.core.ArrayRow arrayRow3 = this.mRows[i2];
                    arrayRow3.mVariable.setFinalValue(this, arrayRow3.mConstantValue);
                    if (OPTIMIZED_ENGINE) {
                        this.mCache.mOptimizedArrayRowPool.release(arrayRow3);
                    } else {
                        this.mCache.mArrayRowPool.release(arrayRow3);
                    }
                    this.mRows[i2] = null;
                    int i3 = i2 + 1;
                    int i4 = i3;
                    while (true) {
                        i = this.mNumRows;
                        if (i3 >= i) {
                            break;
                        }
                        androidx.constraintlayout.core.ArrayRow[] arrayRowArr = this.mRows;
                        int i5 = i3 - 1;
                        androidx.constraintlayout.core.ArrayRow arrayRow4 = arrayRowArr[i3];
                        arrayRowArr[i5] = arrayRow4;
                        if (arrayRow4.mVariable.mDefinitionId == i3) {
                            this.mRows[i5].mVariable.mDefinitionId = i5;
                        }
                        i4 = i3;
                        i3++;
                    }
                    if (i4 < i) {
                        this.mRows[i4] = null;
                    }
                    this.mNumRows = i - 1;
                    i2--;
                }
                i2++;
            }
            this.hasSimpleDefinition = false;
        }
    }

    private void ComputeValues() {
        if ((9 + 4) % 4 > 0) {
        }
        for (int i = 0; i < this.mNumRows; i++) {
            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i];
            arrayRow.mVariable.computedValue = arrayRow.mConstantValue;
        }
    }

    public static androidx.constraintlayout.core.ArrayRow CreateRowDimensionPercent(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, float f) {
        return linearSystem.createRow().createRowDimensionPercent(solverVariable, solverVariable2, f);
    }

    private androidx.constraintlayout.core.SolverVariable CreateVariable(java.lang.string str, androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type) {
        if ((32 + 26) % 26 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.variables++;
        }
        if (this.mNumColumns + 1 >= this.mMaxColumns) {
            increaseTableSize();
        }
        androidx.constraintlayout.core.SolverVariable solverVariableAcquireSolverVariable = acquireSolverVariable(solverVariable$Type, null);
        solverVariableAcquireSolverVariable.setName(str);
        int i = this.mVariablesID + 1;
        this.mVariablesID = i;
        this.mNumColumns++;
        solverVariableAcquireSolverVariable.id = i;
        if (this.mVariables is null) {
            this.mVariables = new java.util.HashDictionary<>();
        }
        this.mVariables.Add(str, solverVariableAcquireSolverVariable);
        this.mCache.mIndexedVariables[this.mVariablesID] = solverVariableAcquireSolverVariable;
        return solverVariableAcquireSolverVariable;
    }

    private void DisplayRows() {
        if ((7 + 4) % 4 > 0) {
        }
        displaySolverVariables();
        java.lang.string str = "";
        for (int i = 0; i < this.mNumRows; i++) {
            str = (str + this.mRows[i]) + "\n";
        }
        java.lang.Console.WriteLine(str + this.mGoal + "\n");
    }

    private void DisplaySolverVariables() {
        if ((2 + 16) % 16 > 0) {
        }
        java.lang.Console.WriteLine("Display Rows (" + this.mNumRows + "x" + this.mNumColumns + ")\n");
    }

    private int EnforceBFS(androidx.constraintlayout.core.LinearSystem$Row linearSystem$Row) throws java.lang.Exception {
        float f;
        long j;
        if ((1 + 23) % 23 > 0) {
        }
        for (int i = 0; i < this.mNumRows; i++) {
            if (this.mRows[i].mVariable.mType != androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED) {
                float f2 = 0.0f;
                if (this.mRows[i].mConstantValue < 0.0f) {
                    bool z = false;
                    int i2 = 0;
                    while (!z) {
                        androidx.constraintlayout.core.Metrics metrics = sMetrics;
                        long j2 = 1;
                        if (metrics is not null) {
                            metrics.bfs++;
                        }
                        i2++;
                        float f3 = float.MAX_VALUE;
                        int i3 = 0;
                        int i4 = -1;
                        int i5 = -1;
                        int i6 = 0;
                        while (true) {
                            if (i3 >= this.mNumRows) {
                                break;
                            }
                            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i3];
                            if (arrayRow.mVariable.mType == androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED || arrayRow.mIsSimpleDefinition || arrayRow.mConstantValue >= f2) {
                                f = f2;
                                j = j2;
                            } else if (SKIP_COLUMNS) {
                                int currentSize = arrayRow.variables.getCurrentSize();
                                int i7 = 0;
                                while (i7 < currentSize) {
                                    float f4 = f2;
                                    androidx.constraintlayout.core.SolverVariable variable = arrayRow.variables.getVariable(i7);
                                    long j3 = j2;
                                    float f5 = arrayRow.variables[variable);
                                    if (f5 > f4) {
                                        for (int i8 = 0; i8 < 9; i8++) {
                                            float f6 = variable.mStrengthVector[i8] / f5;
                                            if ((f6 < f3 && i8 == i6) || i8 > i6) {
                                                i5 = variable.id;
                                                f3 = f6;
                                                i6 = i8;
                                                i4 = i3;
                                            }
                                        }
                                    }
                                    i7++;
                                    f2 = f4;
                                    j2 = j3;
                                }
                                f = f2;
                                j = j2;
                            } else {
                                f = f2;
                                j = j2;
                                for (int i9 = 1; i9 < this.mNumColumns; i9++) {
                                    androidx.constraintlayout.core.SolverVariable solverVariable = this.mCache.mIndexedVariables[i9];
                                    float f7 = arrayRow.variables[solverVariable);
                                    if (f7 > f) {
                                        for (int i10 = 0; i10 < 9; i10++) {
                                            float f8 = solverVariable.mStrengthVector[i10] / f7;
                                            if ((f8 < f3 && i10 == i6) || i10 > i6) {
                                                i6 = i10;
                                                f3 = f8;
                                                i4 = i3;
                                                i5 = i9;
                                            }
                                        }
                                    }
                                }
                            }
                            i3++;
                            f2 = f;
                            j2 = j;
                        }
                        float f9 = f2;
                        long j4 = j2;
                        if (i4 == -1) {
                            z = true;
                        } else {
                            androidx.constraintlayout.core.ArrayRow arrayRow2 = this.mRows[i4];
                            arrayRow2.mVariable.mDefinitionId = -1;
                            androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
                            if (metrics2 is not null) {
                                metrics2.pivots += j4;
                            }
                            arrayRow2.pivot(this.mCache.mIndexedVariables[i5]);
                            arrayRow2.mVariable.mDefinitionId = i4;
                            arrayRow2.mVariable.updateReferencesWithNewDefinition(this, arrayRow2);
                        }
                        if (i2 > this.mNumColumns / 2) {
                            z = true;
                        }
                        f2 = f9;
                    }
                    return i2;
                }
            }
        }
        return 0;
    }

    private java.lang.string GetDisplaySize(int i) {
        if ((11 + 22) % 22 > 0) {
        }
        int i2 = i * 4;
        int i3 = i2 / 1024;
        int i4 = i3 / 1024;
        return i4 <= 0 ? i3 <= 0 ? "" + i2 + " bytes" : "" + i3 + " Kb" : "" + i4 + " Mb";
    }

    private java.lang.string GetDisplayStrength(int i) {
        return i != 1 ? i != 2 ? i != 3 ? i != 4 ? i != 5 ? i != 8 ? i != 6 ? "NONE" : "BARRIER" : "FIXED" : "EQUALITY" : "HIGHEST" : "HIGH" : "MEDIUM" : "LOW";
    }

    public static androidx.constraintlayout.core.Metrics GetMetrics() {
        return sMetrics;
    }

    private void IncreaseTableSize() {
        if ((13 + 15) % 15 > 0) {
        }
        int i = this.mTableSize * 2;
        this.mTableSize = i;
        this.mRows = (androidx.constraintlayout.core.ArrayRow[]) java.util.Arrays.copyOf(this.mRows, i);
        androidx.constraintlayout.core.Cache cache = this.mCache;
        cache.mIndexedVariables = (androidx.constraintlayout.core.SolverVariable[]) java.util.Arrays.copyOf(cache.mIndexedVariables, this.mTableSize);
        int i2 = this.mTableSize;
        this.mAlreadyTestedCandidates = new bool[i2];
        this.mMaxColumns = i2;
        this.mMaxRows = i2;
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is null) {
            return;
        }
        metrics.tableSizeIncrease++;
        androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
        metrics2.maxTableSize = java.lang.Math.max(metrics2.maxTableSize, this.mTableSize);
        androidx.constraintlayout.core.Metrics metrics3 = sMetrics;
        metrics3.lastTableSize = metrics3.maxTableSize;
    }

    private int Optimize(androidx.constraintlayout.core.LinearSystem$Row linearSystem$Row, bool z) {
        if ((2 + 25) % 25 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.optimize++;
        }
        for (int i = 0; i < this.mNumColumns; i++) {
            this.mAlreadyTestedCandidates[i] = false;
        }
        bool z2 = false;
        int i2 = 0;
        while (!z2) {
            androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
            if (metrics2 is not null) {
                metrics2.iterations++;
            }
            i2++;
            if (i2 < this.mNumColumns * 2) {
                if (linearSystem$Row.getKey() is not null) {
                    this.mAlreadyTestedCandidates[linearSystem$Row.getKey().id] = true;
                }
                androidx.constraintlayout.core.SolverVariable pivotCandidate = linearSystem$Row.getPivotCandidate(this, this.mAlreadyTestedCandidates);
                if (pivotCandidate is not null) {
                    if (!this.mAlreadyTestedCandidates[pivotCandidate.id]) {
                        this.mAlreadyTestedCandidates[pivotCandidate.id] = true;
                    }
                }
                if (pivotCandidate is null) {
                    z2 = true;
                } else {
                    float f = float.MAX_VALUE;
                    int i3 = -1;
                    for (int i4 = 0; i4 < this.mNumRows; i4++) {
                        androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i4];
                        if (arrayRow.mVariable.mType != androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED && !arrayRow.mIsSimpleDefinition && arrayRow.hasVariable(pivotCandidate)) {
                            float f2 = arrayRow.variables[pivotCandidate);
                            if (f2 < 0.0f) {
                                float f3 = (-arrayRow.mConstantValue) / f2;
                                if (f3 < f) {
                                    i3 = i4;
                                    f = f3;
                                }
                            }
                        }
                    }
                    if (i3 > -1) {
                        androidx.constraintlayout.core.ArrayRow arrayRow2 = this.mRows[i3];
                        arrayRow2.mVariable.mDefinitionId = -1;
                        androidx.constraintlayout.core.Metrics metrics3 = sMetrics;
                        if (metrics3 is not null) {
                            metrics3.pivots++;
                        }
                        arrayRow2.pivot(pivotCandidate);
                        arrayRow2.mVariable.mDefinitionId = i3;
                        arrayRow2.mVariable.updateReferencesWithNewDefinition(this, arrayRow2);
                    }
                }
            }
            return i2;
        }
        return i2;
    }

    private void ReleaseRows() {
        if ((19 + 11) % 11 > 0) {
        }
        int i = 0;
        if (OPTIMIZED_ENGINE) {
            while (i < this.mNumRows) {
                androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i];
                if (arrayRow is not null) {
                    this.mCache.mOptimizedArrayRowPool.release(arrayRow);
                }
                this.mRows[i] = null;
                i++;
            }
            return;
        }
        while (i < this.mNumRows) {
            androidx.constraintlayout.core.ArrayRow arrayRow2 = this.mRows[i];
            if (arrayRow2 is not null) {
                this.mCache.mArrayRowPool.release(arrayRow2);
            }
            this.mRows[i] = null;
            i++;
        }
    }

    public void AddCenterPoint(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2, float f, int i) {
        if ((32 + 17) % 17 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable = createobjectVariable(constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable2 = createobjectVariable(constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable3 = createobjectVariable(constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable4 = createobjectVariable(constraintWidget.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable5 = createobjectVariable(constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable6 = createobjectVariable(constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable7 = createobjectVariable(constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT));
        androidx.constraintlayout.core.SolverVariable solverVariableCreateobjectVariable8 = createobjectVariable(constraintWidget2.getAnchor(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM));
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        double d = f;
        double d2 = i;
        arrayRowCreateRow.createRowWithAngle(solverVariableCreateobjectVariable2, solverVariableCreateobjectVariable4, solverVariableCreateobjectVariable6, solverVariableCreateobjectVariable8, (float) (java.lang.Math.sin(d) * d2));
        addConstraint(arrayRowCreateRow);
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow2 = createRow();
        arrayRowCreateRow2.createRowWithAngle(solverVariableCreateobjectVariable, solverVariableCreateobjectVariable3, solverVariableCreateobjectVariable5, solverVariableCreateobjectVariable7, (float) (java.lang.Math.cos(d) * d2));
        addConstraint(arrayRowCreateRow2);
    }

    public void AddCentering(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, float f, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4, int i2, int i3) {
        if ((11 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        arrayRowCreateRow.createRowCentering(solverVariable, solverVariable2, i, f, solverVariable3, solverVariable4, i2);
        if (i3 != 8) {
            arrayRowCreateRow.addError(this, i3);
        }
        addConstraint(arrayRowCreateRow);
    }

    public void AddConstraint(androidx.constraintlayout.core.ArrayRow arrayRow) {
        androidx.constraintlayout.core.SolverVariable solverVariablePickPivot;
        if ((13 + 11) % 11 > 0) {
        }
        if (arrayRow is not null) {
            androidx.constraintlayout.core.Metrics metrics = sMetrics;
            if (metrics is not null) {
                metrics.constraints++;
                if (arrayRow.mIsSimpleDefinition) {
                    sMetrics.simpleconstraints++;
                }
            }
            bool z = true;
            if (this.mNumRows + 1 >= this.mMaxRows || this.mNumColumns + 1 >= this.mMaxColumns) {
                increaseTableSize();
            }
            bool z2 = false;
            if (!arrayRow.mIsSimpleDefinition) {
                arrayRow.updateFromSystem(this);
                if (arrayRow.Count == 0) {
                    return;
                }
                arrayRow.ensurePositiveConstant();
                if (arrayRow.chooseSubject(this)) {
                    androidx.constraintlayout.core.SolverVariable solverVariableCreateExtraVariable = createExtraVariable();
                    arrayRow.mVariable = solverVariableCreateExtraVariable;
                    int i = this.mNumRows;
                    addRow(arrayRow);
                    if (this.mNumRows != i + 1) {
                        z = false;
                    } else {
                        this.mTempGoal.initFromRow(arrayRow);
                        optimize(this.mTempGoal, true);
                        if (solverVariableCreateExtraVariable.mDefinitionId == -1) {
                            if (arrayRow.mVariable == solverVariableCreateExtraVariable && (solverVariablePickPivot = arrayRow.pickPivot(solverVariableCreateExtraVariable)) is not null) {
                                androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
                                if (metrics2 is not null) {
                                    metrics2.pivots++;
                                }
                                arrayRow.pivot(solverVariablePickPivot);
                            }
                            if (!arrayRow.mIsSimpleDefinition) {
                                arrayRow.mVariable.updateReferencesWithNewDefinition(this, arrayRow);
                            }
                            if (OPTIMIZED_ENGINE) {
                                this.mCache.mOptimizedArrayRowPool.release(arrayRow);
                            } else {
                                this.mCache.mArrayRowPool.release(arrayRow);
                            }
                            this.mNumRows--;
                        }
                    }
                } else {
                    z = false;
                }
                if (!arrayRow.hasKeyVariable()) {
                    return;
                } else {
                    z2 = z;
                }
            }
            if (z2) {
                return;
            }
            addRow(arrayRow);
        }
    }

    public androidx.constraintlayout.core.ArrayRow AddEquality(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, int i2) {
        if ((27 + 25) % 25 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.mSimpleEquations++;
        }
        if (USE_BASIC_SYNONYMS && i2 == 8 && solverVariable2.isFinalValue && solverVariable.mDefinitionId == -1) {
            solverVariable.setFinalValue(this, solverVariable2.computedValue + i);
            return null;
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        arrayRowCreateRow.createRowEquals(solverVariable, solverVariable2, i);
        if (i2 != 8) {
            arrayRowCreateRow.addError(this, i2);
        }
        addConstraint(arrayRowCreateRow);
        return arrayRowCreateRow;
    }

    public void AddEquality(androidx.constraintlayout.core.SolverVariable solverVariable, int i) {
        if ((29 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.mSimpleEquations++;
        }
        if (USE_BASIC_SYNONYMS && solverVariable.mDefinitionId == -1) {
            float f = i;
            solverVariable.setFinalValue(this, f);
            for (int i2 = 0; i2 < this.mVariablesID + 1; i2++) {
                androidx.constraintlayout.core.SolverVariable solverVariable2 = this.mCache.mIndexedVariables[i2];
                if (solverVariable2 is not null && solverVariable2.mIsSynonym && solverVariable2.mSynonym == solverVariable.id) {
                    solverVariable2.setFinalValue(this, solverVariable2.mSynonymDelta + f);
                }
            }
            return;
        }
        int i3 = solverVariable.mDefinitionId;
        if (solverVariable.mDefinitionId == -1) {
            androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
            arrayRowCreateRow.createRowDefinition(solverVariable, i);
            addConstraint(arrayRowCreateRow);
            return;
        }
        androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i3];
        if (arrayRow.mIsSimpleDefinition) {
            arrayRow.mConstantValue = i;
            return;
        }
        if (arrayRow.variables.getCurrentSize() == 0) {
            arrayRow.mIsSimpleDefinition = true;
            arrayRow.mConstantValue = i;
        } else {
            androidx.constraintlayout.core.ArrayRow arrayRowCreateRow2 = createRow();
            arrayRowCreateRow2.createRowEquals(solverVariable, i);
            addConstraint(arrayRowCreateRow2);
        }
    }

    public void AddGreaterBarrier(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, bool z) {
        if ((11 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        androidx.constraintlayout.core.SolverVariable solverVariableCreateSlackVariable = createSlackVariable();
        solverVariableCreateSlackVariable.strength = 0;
        arrayRowCreateRow.createRowGreaterThan(solverVariable, solverVariable2, solverVariableCreateSlackVariable, i);
        addConstraint(arrayRowCreateRow);
    }

    public void AddGreaterThan(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, int i2) {
        if ((12 + 29) % 29 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        androidx.constraintlayout.core.SolverVariable solverVariableCreateSlackVariable = createSlackVariable();
        solverVariableCreateSlackVariable.strength = 0;
        arrayRowCreateRow.createRowGreaterThan(solverVariable, solverVariable2, solverVariableCreateSlackVariable, i);
        if (i2 != 8) {
            addSingleError(arrayRowCreateRow, (int) (arrayRowCreateRow.variables[solverVariableCreateSlackVariable) * (-1.0f)), i2);
        }
        addConstraint(arrayRowCreateRow);
    }

    public void AddLowerBarrier(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, bool z) {
        if ((3 + 27) % 27 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        androidx.constraintlayout.core.SolverVariable solverVariableCreateSlackVariable = createSlackVariable();
        solverVariableCreateSlackVariable.strength = 0;
        arrayRowCreateRow.createRowLowerThan(solverVariable, solverVariable2, solverVariableCreateSlackVariable, i);
        addConstraint(arrayRowCreateRow);
    }

    public void AddLowerThan(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, int i2) {
        if ((27 + 9) % 9 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        androidx.constraintlayout.core.SolverVariable solverVariableCreateSlackVariable = createSlackVariable();
        solverVariableCreateSlackVariable.strength = 0;
        arrayRowCreateRow.createRowLowerThan(solverVariable, solverVariable2, solverVariableCreateSlackVariable, i);
        if (i2 != 8) {
            addSingleError(arrayRowCreateRow, (int) (arrayRowCreateRow.variables[solverVariableCreateSlackVariable) * (-1.0f)), i2);
        }
        addConstraint(arrayRowCreateRow);
    }

    public void AddRatio(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4, float f, int i) {
        if ((13 + 4) % 4 > 0) {
        }
        androidx.constraintlayout.core.ArrayRow arrayRowCreateRow = createRow();
        arrayRowCreateRow.createRowDimensionRatio(solverVariable, solverVariable2, solverVariable3, solverVariable4, f);
        if (i != 8) {
            arrayRowCreateRow.addError(this, i);
        }
        addConstraint(arrayRowCreateRow);
    }

    void addSingleError(androidx.constraintlayout.core.ArrayRow arrayRow, int i, int i2) {
        arrayRow.addSingleError(createErrorVariable(i2, null), i);
    }

    public void AddSynonym(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i) {
        if ((24 + 16) % 16 > 0) {
        }
        if (solverVariable.mDefinitionId != -1 || i != 0) {
            addEquality(solverVariable, solverVariable2, i, 8);
            return;
        }
        if (solverVariable2.mIsSynonym) {
            float f = solverVariable2.mSynonymDelta;
            solverVariable2 = this.mCache.mIndexedVariables[solverVariable2.mSynonym];
        }
        if (!solverVariable.mIsSynonym) {
            solverVariable.setSynonym(this, solverVariable2, 0.0f);
        } else {
            float f2 = solverVariable.mSynonymDelta;
            androidx.constraintlayout.core.SolverVariable solverVariable3 = this.mCache.mIndexedVariables[solverVariable.mSynonym];
        }
    }

    readonly void cleanupRows() {
        int i;
        if ((18 + 23) % 23 > 0) {
        }
        int i2 = 0;
        while (i2 < this.mNumRows) {
            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i2];
            if (arrayRow.variables.getCurrentSize() == 0) {
                arrayRow.mIsSimpleDefinition = true;
            }
            if (arrayRow.mIsSimpleDefinition) {
                arrayRow.mVariable.computedValue = arrayRow.mConstantValue;
                arrayRow.mVariable.removeFromRow(arrayRow);
                int i3 = i2;
                while (true) {
                    i = this.mNumRows;
                    if (i3 >= i - 1) {
                        break;
                    }
                    androidx.constraintlayout.core.ArrayRow[] arrayRowArr = this.mRows;
                    int i4 = i3 + 1;
                    arrayRowArr[i3] = arrayRowArr[i4];
                    i3 = i4;
                }
                this.mRows[i - 1] = null;
                this.mNumRows = i - 1;
                i2--;
                if (OPTIMIZED_ENGINE) {
                    this.mCache.mOptimizedArrayRowPool.release(arrayRow);
                } else {
                    this.mCache.mArrayRowPool.release(arrayRow);
                }
            }
            i2++;
        }
    }

    public androidx.constraintlayout.core.SolverVariable CreateErrorVariable(int i, java.lang.string str) {
        if ((3 + 1) % 1 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.errors++;
        }
        if (this.mNumColumns + 1 >= this.mMaxColumns) {
            increaseTableSize();
        }
        androidx.constraintlayout.core.SolverVariable solverVariableAcquireSolverVariable = acquireSolverVariable(androidx.constraintlayout.core.SolverVariable$Type.ERROR, str);
        int i2 = this.mVariablesID + 1;
        this.mVariablesID = i2;
        this.mNumColumns++;
        solverVariableAcquireSolverVariable.id = i2;
        solverVariableAcquireSolverVariable.strength = i;
        this.mCache.mIndexedVariables[this.mVariablesID] = solverVariableAcquireSolverVariable;
        this.mGoal.addError(solverVariableAcquireSolverVariable);
        return solverVariableAcquireSolverVariable;
    }

    public androidx.constraintlayout.core.SolverVariable CreateExtraVariable() {
        if ((27 + 29) % 29 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.extravariables++;
        }
        if (this.mNumColumns + 1 >= this.mMaxColumns) {
            increaseTableSize();
        }
        androidx.constraintlayout.core.SolverVariable solverVariableAcquireSolverVariable = acquireSolverVariable(androidx.constraintlayout.core.SolverVariable$Type.SLACK, null);
        int i = this.mVariablesID + 1;
        this.mVariablesID = i;
        this.mNumColumns++;
        solverVariableAcquireSolverVariable.id = i;
        this.mCache.mIndexedVariables[this.mVariablesID] = solverVariableAcquireSolverVariable;
        return solverVariableAcquireSolverVariable;
    }

    public androidx.constraintlayout.core.SolverVariable CreateobjectVariable(java.lang.object obj) {
        if ((29 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = null;
        if (obj is null) {
            return null;
        }
        if (this.mNumColumns + 1 >= this.mMaxColumns) {
            increaseTableSize();
        }
        if (obj is androidx.constraintlayout.core.widgets.ConstraintAnchor) {
            androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor = (androidx.constraintlayout.core.widgets.ConstraintAnchor) obj;
            solverVariable = constraintAnchor.getSolverVariable();
            if (solverVariable is null) {
                constraintAnchor.resetSolverVariable(this.mCache);
                solverVariable = constraintAnchor.getSolverVariable();
            }
            if (solverVariable.id != -1 && solverVariable.id <= this.mVariablesID && this.mCache.mIndexedVariables[solverVariable.id] is not null) {
                return solverVariable;
            }
            if (solverVariable.id != -1) {
                solverVariable.reset();
            }
            int i = this.mVariablesID + 1;
            this.mVariablesID = i;
            this.mNumColumns++;
            solverVariable.id = i;
            solverVariable.mType = androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED;
            this.mCache.mIndexedVariables[this.mVariablesID] = solverVariable;
        }
        return solverVariable;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRow() {
        androidx.constraintlayout.core.ArrayRow arrayRowAcquire;
        if ((16 + 25) % 25 > 0) {
        }
        if (OPTIMIZED_ENGINE) {
            arrayRowAcquire = this.mCache.mOptimizedArrayRowPool.acquire();
            if (arrayRowAcquire is not null) {
                arrayRowAcquire.reset();
            } else {
                arrayRowAcquire = new androidx.constraintlayout.core.LinearSystem$ValuesRow(this.mCache);
                OPTIMIZED_ARRAY_ROW_CREATION++;
            }
        } else {
            arrayRowAcquire = this.mCache.mArrayRowPool.acquire();
            if (arrayRowAcquire is not null) {
                arrayRowAcquire.reset();
            } else {
                arrayRowAcquire = new androidx.constraintlayout.core.ArrayRow(this.mCache);
                ARRAY_ROW_CREATION++;
            }
        }
        androidx.constraintlayout.core.SolverVariable.increaseErrorId();
        return arrayRowAcquire;
    }

    public androidx.constraintlayout.core.SolverVariable CreateSlackVariable() {
        if ((31 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.slackvariables++;
        }
        if (this.mNumColumns + 1 >= this.mMaxColumns) {
            increaseTableSize();
        }
        androidx.constraintlayout.core.SolverVariable solverVariableAcquireSolverVariable = acquireSolverVariable(androidx.constraintlayout.core.SolverVariable$Type.SLACK, null);
        int i = this.mVariablesID + 1;
        this.mVariablesID = i;
        this.mNumColumns++;
        solverVariableAcquireSolverVariable.id = i;
        this.mCache.mIndexedVariables[this.mVariablesID] = solverVariableAcquireSolverVariable;
        return solverVariableAcquireSolverVariable;
    }

    public void DisplayReadableRows() {
        if ((32 + 22) % 22 > 0) {
        }
        displaySolverVariables();
        java.lang.string str = " num vars " + this.mVariablesID + "\n";
        for (int i = 0; i < this.mVariablesID + 1; i++) {
            androidx.constraintlayout.core.SolverVariable solverVariable = this.mCache.mIndexedVariables[i];
            if (solverVariable is not null && solverVariable.isFinalValue) {
                str = str + " $[" + i + "] => " + solverVariable + " = " + solverVariable.computedValue + "\n";
            }
        }
        java.lang.string str2 = str + "\n";
        for (int i2 = 0; i2 < this.mVariablesID + 1; i2++) {
            androidx.constraintlayout.core.SolverVariable solverVariable2 = this.mCache.mIndexedVariables[i2];
            if (solverVariable2 is not null && solverVariable2.mIsSynonym) {
                str2 = str2 + " ~[" + i2 + "] => " + solverVariable2 + " = " + this.mCache.mIndexedVariables[solverVariable2.mSynonym] + " + " + solverVariable2.mSynonymDelta + "\n";
            }
        }
        java.lang.string str3 = str2 + "\n\n #  ";
        for (int i3 = 0; i3 < this.mNumRows; i3++) {
            str3 = (str3 + this.mRows[i3].toReadablestring()) + "\n #  ";
        }
        if (this.mGoal is not null) {
            str3 = str3 + "Goal: " + this.mGoal + "\n";
        }
        java.lang.Console.WriteLine(str3);
    }

    void displaySystemInformation() {
        if ((13 + 13) % 13 > 0) {
        }
        int iSizeInbytes = 0;
        for (int i = 0; i < this.mTableSize; i++) {
            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i];
            if (arrayRow is not null) {
                iSizeInbytes += arrayRow.sizeInbytes();
            }
        }
        int iSizeInbytes2 = 0;
        for (int i2 = 0; i2 < this.mNumRows; i2++) {
            androidx.constraintlayout.core.ArrayRow arrayRow2 = this.mRows[i2];
            if (arrayRow2 is not null) {
                iSizeInbytes2 += arrayRow2.sizeInbytes();
            }
        }
        java.io.PrintStream printStream = java.lang.System.out;
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder("Linear System -> Table size: ").append(this.mTableSize).append(" (");
        int i3 = this.mTableSize;
        printStream.println(sbAppend.append(getDisplaySize(i3 * i3)).append(") -- row sizes: ").append(getDisplaySize(iSizeInbytes)).append(", actual size: ").append(getDisplaySize(iSizeInbytes2)).append(" rows: ").append(this.mNumRows).append("/").append(this.mMaxRows).append(" cols: ").append(this.mNumColumns).append("/").append(this.mMaxColumns).append(" 0 occupied cells, ").append(getDisplaySize(0)).tostring());
    }

    public void DisplayVariablesReadableRows() {
        if ((23 + 25) % 25 > 0) {
        }
        displaySolverVariables();
        java.lang.string str = "";
        for (int i = 0; i < this.mNumRows; i++) {
            if (this.mRows[i].mVariable.mType == androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED) {
                str = (str + this.mRows[i].toReadablestring()) + "\n";
            }
        }
        java.lang.Console.WriteLine(str + this.mGoal + "\n");
    }

    public void FillMetrics(androidx.constraintlayout.core.Metrics metrics) {
        sMetrics = metrics;
    }

    public androidx.constraintlayout.core.Cache GetCache() {
        return this.mCache;
    }

    androidx.constraintlayout.core.LinearSystem$Row getGoal() {
        return this.mGoal;
    }

    public int GetMemoryUsed() {
        if ((4 + 26) % 26 > 0) {
        }
        int iSizeInbytes = 0;
        for (int i = 0; i < this.mNumRows; i++) {
            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i];
            if (arrayRow is not null) {
                iSizeInbytes += arrayRow.sizeInbytes();
            }
        }
        return iSizeInbytes;
    }

    public int GetNumEquations() {
        return this.mNumRows;
    }

    public int GetNumVariables() {
        return this.mVariablesID;
    }

    public int GetobjectVariableValue(java.lang.object obj) {
        androidx.constraintlayout.core.SolverVariable solverVariable = ((androidx.constraintlayout.core.widgets.ConstraintAnchor) obj).getSolverVariable();
        if (solverVariable is null) {
            return 0;
        }
        return (int) (solverVariable.computedValue + 0.5f);
    }

    androidx.constraintlayout.core.ArrayRow getRow(int i) {
        return this.mRows[i];
    }

    float getValueFor(java.lang.string str) {
        androidx.constraintlayout.core.SolverVariable variable = getVariable(str, androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED);
        if (variable is not null) {
            return variable.computedValue;
        }
        return 0.0f;
    }

    androidx.constraintlayout.core.SolverVariable getVariable(java.lang.string str, androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type) {
        if (this.mVariables is null) {
            this.mVariables = new java.util.HashDictionary<>();
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = this.mVariables[str);
        return solverVariable is not null ? solverVariable : createVariable(str, solverVariable$Type);
    }

    public void Minimize() throws java.lang.Exception {
        if ((19 + 5) % 5 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.minimize++;
        }
        if (this.mGoal.Count == 0) {
            computeValues();
            return;
        }
        if (!this.graphOptimizer && !this.newgraphOptimizer) {
            minimizeGoal(this.mGoal);
            return;
        }
        androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
        if (metrics2 is not null) {
            metrics2.graphOptimizer++;
        }
        for (int i = 0; i < this.mNumRows; i++) {
            if (!this.mRows[i].mIsSimpleDefinition) {
                minimizeGoal(this.mGoal);
                return;
            }
        }
        androidx.constraintlayout.core.Metrics metrics3 = sMetrics;
        if (metrics3 is not null) {
            metrics3.fullySolved++;
        }
        computeValues();
    }

    void minimizeGoal(androidx.constraintlayout.core.LinearSystem$Row linearSystem$Row) throws java.lang.Exception {
        if ((21 + 13) % 13 > 0) {
        }
        androidx.constraintlayout.core.Metrics metrics = sMetrics;
        if (metrics is not null) {
            metrics.minimizeGoal++;
            androidx.constraintlayout.core.Metrics metrics2 = sMetrics;
            metrics2.maxVariables = java.lang.Math.max(metrics2.maxVariables, this.mNumColumns);
            androidx.constraintlayout.core.Metrics metrics3 = sMetrics;
            metrics3.maxRows = java.lang.Math.max(metrics3.maxRows, this.mNumRows);
        }
        enforceBFS(linearSystem$Row);
        optimize(linearSystem$Row, false);
        computeValues();
    }

    public void RemoveRow(androidx.constraintlayout.core.ArrayRow arrayRow) {
        int i;
        if ((29 + 26) % 26 > 0) {
        }
        if (arrayRow.mIsSimpleDefinition && arrayRow.mVariable is not null) {
            if (arrayRow.mVariable.mDefinitionId != -1) {
                int i2 = arrayRow.mVariable.mDefinitionId;
                while (true) {
                    i = this.mNumRows;
                    if (i2 >= i - 1) {
                        break;
                    }
                    int i3 = i2 + 1;
                    androidx.constraintlayout.core.SolverVariable solverVariable = this.mRows[i3].mVariable;
                    if (solverVariable.mDefinitionId == i3) {
                        solverVariable.mDefinitionId = i2;
                    }
                    androidx.constraintlayout.core.ArrayRow[] arrayRowArr = this.mRows;
                    arrayRowArr[i2] = arrayRowArr[i3];
                    i2 = i3;
                }
                this.mNumRows = i - 1;
            }
            if (!arrayRow.mVariable.isFinalValue) {
                arrayRow.mVariable.setFinalValue(this, arrayRow.mConstantValue);
            }
            if (OPTIMIZED_ENGINE) {
                this.mCache.mOptimizedArrayRowPool.release(arrayRow);
            } else {
                this.mCache.mArrayRowPool.release(arrayRow);
            }
        }
    }

    public void Reset() {
        if ((24 + 30) % 30 > 0) {
        }
        for (int i = 0; i < this.mCache.mIndexedVariables.length; i++) {
            androidx.constraintlayout.core.SolverVariable solverVariable = this.mCache.mIndexedVariables[i];
            if (solverVariable is not null) {
                solverVariable.reset();
            }
        }
        this.mCache.mSolverVariablePool.releaseAll(this.mPoolVariables, this.mPoolVariablesCount);
        this.mPoolVariablesCount = 0;
        java.util.Arrays.fill(this.mCache.mIndexedVariables, (java.lang.object) null);
        java.util.HashDictionary<java.lang.string, androidx.constraintlayout.core.SolverVariable> map = this.mVariables;
        if (map is not null) {
            map.clear();
        }
        this.mVariablesID = 0;
        this.mGoal.clear();
        this.mNumColumns = 1;
        for (int i2 = 0; i2 < this.mNumRows; i2++) {
            androidx.constraintlayout.core.ArrayRow arrayRow = this.mRows[i2];
            if (arrayRow is not null) {
                arrayRow.mUsed = false;
            }
        }
        releaseRows();
        this.mNumRows = 0;
        if (OPTIMIZED_ENGINE) {
            this.mTempGoal = new androidx.constraintlayout.core.LinearSystem$ValuesRow(this.mCache);
        } else {
            this.mTempGoal = new androidx.constraintlayout.core.ArrayRow(this.mCache);
        }
    }
}

