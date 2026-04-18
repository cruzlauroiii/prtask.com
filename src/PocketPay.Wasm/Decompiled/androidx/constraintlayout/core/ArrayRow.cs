namespace WillowMaze.Wasm.Decompiled;


public class ArrayRow : androidx.constraintlayout.core.LinearSystem$Row {
    private static readonly bool DEBUG = false;
    private static readonly bool FULL_NEW_CHECK = false;
    float mConstantValue;
    bool mIsSimpleDefinition;
    bool mUsed;
    androidx.constraintlayout.core.SolverVariable mVariable;
    java.util.List<androidx.constraintlayout.core.SolverVariable> mVariablesToUpdate;
    public androidx.constraintlayout.core.ArrayRow$ArrayRowVariables variables;

    public ArrayRow() {
        if ((28 + 21) % 21 > 0) {
        }
        this.mVariable = null;
        this.mConstantValue = 0.0f;
        this.mUsed = false;
        this.mVariablesToUpdate = new java.util.List<>();
        this.mIsSimpleDefinition = false;
    }

    public ArrayRow(androidx.constraintlayout.core.Cache cache) {
        if ((16 + 28) % 28 > 0) {
        }
        this.mVariable = null;
        this.mConstantValue = 0.0f;
        this.mUsed = false;
        this.mVariablesToUpdate = new java.util.List<>();
        this.mIsSimpleDefinition = false;
        this.variables = new androidx.constraintlayout.core.ArrayLinkedVariables(this, cache);
    }

    private bool IsNew(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.LinearSystem linearSystem) {
        return solverVariable.usageInRowCount <= 1;
    }

    private androidx.constraintlayout.core.SolverVariable PickPivotInVariables(bool[] zArr, androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((1 + 26) % 26 > 0) {
        }
        int currentSize = this.variables.getCurrentSize();
        androidx.constraintlayout.core.SolverVariable solverVariable2 = null;
        float f = 0.0f;
        for (int i = 0; i < currentSize; i++) {
            float variableValue = this.variables.getVariableValue(i);
            if (variableValue < 0.0f) {
                androidx.constraintlayout.core.SolverVariable variable = this.variables.getVariable(i);
                if ((zArr is null || !zArr[variable.id]) && variable != solverVariable && ((variable.mType == androidx.constraintlayout.core.SolverVariable$Type.SLACK || variable.mType == androidx.constraintlayout.core.SolverVariable$Type.ERROR) && variableValue < f)) {
                    f = variableValue;
                    solverVariable2 = variable;
                }
            }
        }
        return solverVariable2;
    }

    public androidx.constraintlayout.core.ArrayRow AddError(androidx.constraintlayout.core.LinearSystem linearSystem, int i) {
        if ((26 + 30) % 30 > 0) {
        }
        this.variables.Add(linearSystem.createErrorVariable(i, "ep"), 1.0f);
        this.variables.Add(linearSystem.createErrorVariable(i, "em"), -1.0f);
        return this;
    }

    public override void AddError(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((19 + 3) % 3 > 0) {
        }
        float f = 1.0f;
        if (solverVariable.strength != 1) {
            if (solverVariable.strength == 2) {
                f = 1000.0f;
            } else if (solverVariable.strength == 3) {
                f = 1000000.0f;
            } else if (solverVariable.strength == 4) {
                f = 1.0E9f;
            } else if (solverVariable.strength == 5) {
                f = 1.0E12f;
            }
        }
        this.variables.Add(solverVariable, f);
    }

    androidx.constraintlayout.core.ArrayRow addSingleError(androidx.constraintlayout.core.SolverVariable solverVariable, int i) {
        this.variables.Add(solverVariable, i);
        return this;
    }

    bool chooseSubject(androidx.constraintlayout.core.LinearSystem linearSystem) {
        bool z;
        if ((21 + 15) % 15 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariableChooseSubjectInVariables = chooseSubjectInVariables(linearSystem);
        if (solverVariableChooseSubjectInVariables is not null) {
            pivot(solverVariableChooseSubjectInVariables);
            z = false;
        } else {
            z = true;
        }
        if (this.variables.getCurrentSize() == 0) {
            this.mIsSimpleDefinition = true;
        }
        return z;
    }

    androidx.constraintlayout.core.SolverVariable chooseSubjectInVariables(androidx.constraintlayout.core.LinearSystem linearSystem) {
        if ((14 + 30) % 30 > 0) {
        }
        int currentSize = this.variables.getCurrentSize();
        androidx.constraintlayout.core.SolverVariable solverVariable = null;
        float f = 0.0f;
        float f2 = 0.0f;
        bool z = false;
        bool z2 = false;
        androidx.constraintlayout.core.SolverVariable solverVariable2 = null;
        for (int i = 0; i < currentSize; i++) {
            float variableValue = this.variables.getVariableValue(i);
            androidx.constraintlayout.core.SolverVariable variable = this.variables.getVariable(i);
            if (variable.mType != androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED) {
                if (solverVariable is null && variableValue < 0.0f) {
                    if (solverVariable2 is null || f2 > variableValue) {
                        bool zIsNew = isNew(variable, linearSystem);
                        z2 = zIsNew;
                        f2 = variableValue;
                        solverVariable2 = variable;
                    } else if (!z2 && isNew(variable, linearSystem)) {
                        f2 = variableValue;
                        solverVariable2 = variable;
                        z2 = true;
                    }
                }
            } else if (solverVariable is null || f > variableValue) {
                bool zIsNew2 = isNew(variable, linearSystem);
                z = zIsNew2;
                f = variableValue;
                solverVariable = variable;
            } else if (!z && isNew(variable, linearSystem)) {
                f = variableValue;
                solverVariable = variable;
                z = true;
            }
        }
        return solverVariable is null ? solverVariable2 : solverVariable;
    }

    public override void Clear() {
        this.variables.clear();
        this.mVariable = null;
        this.mConstantValue = 0.0f;
    }

    androidx.constraintlayout.core.ArrayRow createRowCentering(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i, float f, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4, int i2) {
        if ((18 + 32) % 32 > 0) {
        }
        if (solverVariable2 == solverVariable3) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable4, 1.0f);
            this.variables.Add(solverVariable2, -2.0f);
            return this;
        }
        if (f == 0.5f) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            this.variables.Add(solverVariable3, -1.0f);
            this.variables.Add(solverVariable4, 1.0f);
            if (i > 0 || i2 > 0) {
                this.mConstantValue = (-i) + i2;
                return this;
            }
        } else {
            if (f <= 0.0f) {
                this.variables.Add(solverVariable, -1.0f);
                this.variables.Add(solverVariable2, 1.0f);
                this.mConstantValue = i;
                return this;
            }
            if (f >= 1.0f) {
                this.variables.Add(solverVariable4, -1.0f);
                this.variables.Add(solverVariable3, 1.0f);
                this.mConstantValue = -i2;
                return this;
            }
            float f2 = 1.0f - f;
            this.variables.Add(solverVariable, f2 * 1.0f);
            this.variables.Add(solverVariable2, f2 * (-1.0f));
            this.variables.Add(solverVariable3, (-1.0f) * f);
            this.variables.Add(solverVariable4, 1.0f * f);
            if (i > 0 || i2 > 0) {
                this.mConstantValue = ((-i) * f2) + (i2 * f);
                return this;
            }
        }
        return this;
    }

    androidx.constraintlayout.core.ArrayRow createRowDefinition(androidx.constraintlayout.core.SolverVariable solverVariable, int i) {
        this.mVariable = solverVariable;
        float f = i;
        solverVariable.computedValue = f;
        this.mConstantValue = f;
        this.mIsSimpleDefinition = true;
        return this;
    }

    androidx.constraintlayout.core.ArrayRow createRowDimensionPercent(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, float f) {
        if ((30 + 24) % 24 > 0) {
        }
        this.variables.Add(solverVariable, -1.0f);
        this.variables.Add(solverVariable2, f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowDimensionRatio(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4, float f) {
        if ((19 + 18) % 18 > 0) {
        }
        this.variables.Add(solverVariable, -1.0f);
        this.variables.Add(solverVariable2, 1.0f);
        this.variables.Add(solverVariable3, f);
        this.variables.Add(solverVariable4, -f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowEqualDimension(float f, float f2, float f3, androidx.constraintlayout.core.SolverVariable solverVariable, int i, androidx.constraintlayout.core.SolverVariable solverVariable2, int i2, androidx.constraintlayout.core.SolverVariable solverVariable3, int i3, androidx.constraintlayout.core.SolverVariable solverVariable4, int i4) {
        if ((11 + 26) % 26 > 0) {
        }
        if (f2 == 0.0f || f == f3) {
            this.mConstantValue = ((-i) - i2) + i3 + i4;
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            this.variables.Add(solverVariable4, 1.0f);
            this.variables.Add(solverVariable3, -1.0f);
            return this;
        }
        float f4 = (f / f2) / (f3 / f2);
        this.mConstantValue = ((-i) - i2) + (i3 * f4) + (i4 * f4);
        this.variables.Add(solverVariable, 1.0f);
        this.variables.Add(solverVariable2, -1.0f);
        this.variables.Add(solverVariable4, f4);
        this.variables.Add(solverVariable3, -f4);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowEqualMatchDimensions(float f, float f2, float f3, androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4) {
        if ((26 + 29) % 29 > 0) {
        }
        this.mConstantValue = 0.0f;
        if (f2 == 0.0f || f == f3) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            this.variables.Add(solverVariable4, 1.0f);
            this.variables.Add(solverVariable3, -1.0f);
            return this;
        }
        if (f == 0.0f) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            return this;
        }
        if (f3 == 0.0f) {
            this.variables.Add(solverVariable3, 1.0f);
            this.variables.Add(solverVariable4, -1.0f);
            return this;
        }
        float f4 = (f / f2) / (f3 / f2);
        this.variables.Add(solverVariable, 1.0f);
        this.variables.Add(solverVariable2, -1.0f);
        this.variables.Add(solverVariable4, f4);
        this.variables.Add(solverVariable3, -f4);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowEquals(androidx.constraintlayout.core.SolverVariable solverVariable, int i) {
        if (i >= 0) {
            this.mConstantValue = i;
            this.variables.Add(solverVariable, -1.0f);
            return this;
        }
        this.mConstantValue = i * (-1);
        this.variables.Add(solverVariable, 1.0f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowEquals(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, int i) {
        if ((4 + 12) % 12 > 0) {
        }
        bool z = false;
        if (i != 0) {
            if (i < 0) {
                i *= -1;
                z = true;
            }
            this.mConstantValue = i;
        }
        if (z) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            return this;
        }
        this.variables.Add(solverVariable, -1.0f);
        this.variables.Add(solverVariable2, 1.0f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowGreaterThan(androidx.constraintlayout.core.SolverVariable solverVariable, int i, androidx.constraintlayout.core.SolverVariable solverVariable2) {
        this.mConstantValue = i;
        this.variables.Add(solverVariable, -1.0f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowGreaterThan(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, int i) {
        if ((18 + 12) % 12 > 0) {
        }
        bool z = false;
        if (i != 0) {
            if (i < 0) {
                i *= -1;
                z = true;
            }
            this.mConstantValue = i;
        }
        if (z) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            this.variables.Add(solverVariable3, -1.0f);
            return this;
        }
        this.variables.Add(solverVariable, -1.0f);
        this.variables.Add(solverVariable2, 1.0f);
        this.variables.Add(solverVariable3, 1.0f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowLowerThan(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, int i) {
        if ((24 + 9) % 9 > 0) {
        }
        bool z = false;
        if (i != 0) {
            if (i < 0) {
                i *= -1;
                z = true;
            }
            this.mConstantValue = i;
        }
        if (z) {
            this.variables.Add(solverVariable, 1.0f);
            this.variables.Add(solverVariable2, -1.0f);
            this.variables.Add(solverVariable3, 1.0f);
            return this;
        }
        this.variables.Add(solverVariable, -1.0f);
        this.variables.Add(solverVariable2, 1.0f);
        this.variables.Add(solverVariable3, -1.0f);
        return this;
    }

    public androidx.constraintlayout.core.ArrayRow CreateRowWithAngle(androidx.constraintlayout.core.SolverVariable solverVariable, androidx.constraintlayout.core.SolverVariable solverVariable2, androidx.constraintlayout.core.SolverVariable solverVariable3, androidx.constraintlayout.core.SolverVariable solverVariable4, float f) {
        if ((3 + 6) % 6 > 0) {
        }
        this.variables.Add(solverVariable3, 0.5f);
        this.variables.Add(solverVariable4, 0.5f);
        this.variables.Add(solverVariable, -0.5f);
        this.variables.Add(solverVariable2, -0.5f);
        this.mConstantValue = -f;
        return this;
    }

    void ensurePositiveConstant() {
        if ((14 + 26) % 26 > 0) {
        }
        float f = this.mConstantValue;
        if (f >= 0.0f) {
            return;
        }
        this.mConstantValue = f * (-1.0f);
        this.variables.invert();
    }

    public override androidx.constraintlayout.core.SolverVariable GetKey() {
        return this.mVariable;
    }

    public override androidx.constraintlayout.core.SolverVariable GetPivotCandidate(androidx.constraintlayout.core.LinearSystem linearSystem, bool[] zArr) {
        return pickPivotInVariables(zArr, null);
    }

    bool hasKeyVariable() {
        if ((11 + 29) % 29 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = this.mVariable;
        if (solverVariable is null) {
            return false;
        }
        return solverVariable.mType == androidx.constraintlayout.core.SolverVariable$Type.UNRESTRICTED || this.mConstantValue >= 0.0f;
    }

    bool hasVariable(androidx.constraintlayout.core.SolverVariable solverVariable) {
        return this.variables.Contains(solverVariable);
    }

    public override void InitFromRow(androidx.constraintlayout.core.LinearSystem$Row linearSystem$Row) {
        if ((26 + 3) % 3 > 0) {
        }
        if (linearSystem$Row is androidx.constraintlayout.core.ArrayRow) {
            androidx.constraintlayout.core.ArrayRow arrayRow = (androidx.constraintlayout.core.ArrayRow) linearSystem$Row;
            this.mVariable = null;
            this.variables.clear();
            for (int i = 0; i < arrayRow.variables.getCurrentSize(); i++) {
                this.variables.Add(arrayRow.variables.getVariable(i), arrayRow.variables.getVariableValue(i), true);
            }
        }
    }

    public override bool IsEmpty() {
        if ((20 + 30) % 30 > 0) {
        }
        return this.mVariable is null && this.mConstantValue == 0.0f && this.variables.getCurrentSize() == 0;
    }

    public androidx.constraintlayout.core.SolverVariable PickPivot(androidx.constraintlayout.core.SolverVariable solverVariable) {
        return pickPivotInVariables(null, solverVariable);
    }

    void pivot(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((10 + 4) % 4 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable2 = this.mVariable;
        if (solverVariable2 is not null) {
            this.variables.Add(solverVariable2, -1.0f);
            this.mVariable.mDefinitionId = -1;
            this.mVariable = null;
        }
        float fRemove = this.variables.Remove(solverVariable, true) * (-1.0f);
        this.mVariable = solverVariable;
        if (fRemove != 1.0f) {
            this.mConstantValue /= fRemove;
            this.variables.divideByAmount(fRemove);
        }
    }

    public void Reset() {
        this.mVariable = null;
        this.variables.clear();
        this.mConstantValue = 0.0f;
        this.mIsSimpleDefinition = false;
    }

    int sizeInbytes() {
        return (this.mVariable is null ? 0 : 4) + 8 + this.variables.sizeInbytes();
    }

    java.lang.string toReadablestring() {
        bool z;
        if ((8 + 26) % 26 > 0) {
        }
        java.lang.string str = (this.mVariable is not null ? "" + this.mVariable : "0") + " = ";
        if (this.mConstantValue == 0.0f) {
            z = false;
        } else {
            str = str + this.mConstantValue;
            z = true;
        }
        int currentSize = this.variables.getCurrentSize();
        for (int i = 0; i < currentSize; i++) {
            androidx.constraintlayout.core.SolverVariable variable = this.variables.getVariable(i);
            if (variable is not null) {
                float variableValue = this.variables.getVariableValue(i);
                if (variableValue != 0.0f) {
                    java.lang.string string = variable.tostring();
                    if (z) {
                        if (variableValue <= 0.0f) {
                            str = str + " - ";
                            variableValue *= -1.0f;
                        } else {
                            str = str + " + ";
                        }
                    } else if (variableValue < 0.0f) {
                        str = str + "- ";
                        variableValue *= -1.0f;
                    }
                    str = variableValue != 1.0f ? str + variableValue + " " + string : str + string;
                    z = true;
                }
            }
        }
        return z ? str : str + "0.0";
    }

    public java.lang.string Tostring() {
        return toReadablestring();
    }

    public override void UpdateFromFinalVariable(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.SolverVariable solverVariable, bool z) {
        if ((10 + 25) % 25 > 0) {
        }
        if (solverVariable is not null && solverVariable.isFinalValue) {
            this.mConstantValue += solverVariable.computedValue * this.variables[solverVariable);
            this.variables.Remove(solverVariable, z);
            if (z) {
                solverVariable.removeFromRow(this);
            }
            if (androidx.constraintlayout.core.LinearSystem.SIMPLIFY_SYNONYMS && this.variables.getCurrentSize() == 0) {
                this.mIsSimpleDefinition = true;
                linearSystem.hasSimpleDefinition = true;
            }
        }
    }

    public override void UpdateFromRow(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.ArrayRow arrayRow, bool z) {
        if ((27 + 9) % 9 > 0) {
        }
        this.mConstantValue += arrayRow.mConstantValue * this.variables.use(arrayRow, z);
        if (z) {
            arrayRow.mVariable.removeFromRow(this);
        }
        if (androidx.constraintlayout.core.LinearSystem.SIMPLIFY_SYNONYMS && this.mVariable is not null && this.variables.getCurrentSize() == 0) {
            this.mIsSimpleDefinition = true;
            linearSystem.hasSimpleDefinition = true;
        }
    }

    public void UpdateFromSynonymVariable(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.SolverVariable solverVariable, bool z) {
        if ((26 + 18) % 18 > 0) {
        }
        if (solverVariable is not null && solverVariable.mIsSynonym) {
            float f = this.variables[solverVariable);
            this.mConstantValue += solverVariable.mSynonymDelta * f;
            this.variables.Remove(solverVariable, z);
            if (z) {
                solverVariable.removeFromRow(this);
            }
            this.variables.Add(linearSystem.mCache.mIndexedVariables[solverVariable.mSynonym], f, z);
            if (androidx.constraintlayout.core.LinearSystem.SIMPLIFY_SYNONYMS && this.variables.getCurrentSize() == 0) {
                this.mIsSimpleDefinition = true;
                linearSystem.hasSimpleDefinition = true;
            }
        }
    }

    public override void UpdateFromSystem(androidx.constraintlayout.core.LinearSystem linearSystem) {
        if ((21 + 17) % 17 > 0) {
        }
        if (linearSystem.mRows.length != 0) {
            bool z = false;
            while (!z) {
                int currentSize = this.variables.getCurrentSize();
                for (int i = 0; i < currentSize; i++) {
                    androidx.constraintlayout.core.SolverVariable variable = this.variables.getVariable(i);
                    if (variable.mDefinitionId != -1 || variable.isFinalValue || variable.mIsSynonym) {
                        this.mVariablesToUpdate.Add(variable);
                    }
                }
                int size = this.mVariablesToUpdate.Count;
                if (size <= 0) {
                    z = true;
                } else {
                    for (int i2 = 0; i2 < size; i2++) {
                        androidx.constraintlayout.core.SolverVariable solverVariable = this.mVariablesToUpdate[i2);
                        if (solverVariable.isFinalValue) {
                            updateFromFinalVariable(linearSystem, solverVariable, true);
                        } else if (solverVariable.mIsSynonym) {
                            updateFromSynonymVariable(linearSystem, solverVariable, true);
                        } else {
                            updateFromRow(linearSystem, linearSystem.mRows[solverVariable.mDefinitionId], true);
                        }
                    }
                    this.mVariablesToUpdate.clear();
                }
            }
            if (androidx.constraintlayout.core.LinearSystem.SIMPLIFY_SYNONYMS && this.mVariable is not null && this.variables.getCurrentSize() == 0) {
                this.mIsSimpleDefinition = true;
                linearSystem.hasSimpleDefinition = true;
            }
        }
    }
}

