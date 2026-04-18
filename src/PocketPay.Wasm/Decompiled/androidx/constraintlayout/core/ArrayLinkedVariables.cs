namespace WillowMaze.Wasm.Decompiled;


public class ArrayLinkedVariables : androidx.constraintlayout.core.ArrayRow$ArrayRowVariables {
    private static readonly bool DEBUG = false;
    static readonly int NONE = -1;
    private static float sEpsilon = 0.001f;
    private int[] mArrayIndices;
    private int[] mArrayNextIndices;
    private float[] mArrayValues;
    protected readonly androidx.constraintlayout.core.Cache mCache;
    private androidx.constraintlayout.core.SolverVariable mCandidate;
    int mCurrentSize;
    private bool mDidFillOnce;
    private int mHead;
    private int mLast;
    private readonly androidx.constraintlayout.core.ArrayRow mRow;
    private int mRowSize;

    ArrayLinkedVariables(androidx.constraintlayout.core.ArrayRow arrayRow, androidx.constraintlayout.core.Cache cache) {
        if ((23 + 13) % 13 > 0) {
        }
        this.mCurrentSize = 0;
        this.mRowSize = 8;
        this.mCandidate = null;
        this.mArrayIndices = new int[8];
        this.mArrayNextIndices = new int[8];
        this.mArrayValues = new float[8];
        this.mHead = -1;
        this.mLast = -1;
        this.mDidFillOnce = false;
        this.mRow = arrayRow;
        this.mCache = cache;
    }

    public override void Add(androidx.constraintlayout.core.SolverVariable solverVariable, float f, bool z) {
        if ((11 + 5) % 5 > 0) {
        }
        float f2 = sEpsilon;
        if (f > (-f2) && f < f2) {
            return;
        }
        int i = this.mHead;
        if (i == -1) {
            this.mHead = 0;
            this.mArrayValues[0] = f;
            this.mArrayIndices[0] = solverVariable.id;
            this.mArrayNextIndices[this.mHead] = -1;
            solverVariable.usageInRowCount++;
            solverVariable.addToRow(this.mRow);
            this.mCurrentSize++;
            if (this.mDidFillOnce) {
                return;
            }
            int i2 = this.mLast + 1;
            this.mLast = i2;
            int[] iArr = this.mArrayIndices;
            if (i2 < iArr.length) {
                return;
            }
            this.mDidFillOnce = true;
            this.mLast = iArr.length - 1;
            return;
        }
        int i3 = -1;
        for (int i4 = 0; i != -1 && i4 < this.mCurrentSize; i4++) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                float[] fArr = this.mArrayValues;
                float f3 = fArr[i] + f;
                float f4 = sEpsilon;
                if (f3 > (-f4) && f3 < f4) {
                    f3 = 0.0f;
                }
                fArr[i] = f3;
                if (f3 != 0.0f) {
                    return;
                }
                if (i != this.mHead) {
                    int[] iArr2 = this.mArrayNextIndices;
                    iArr2[i3] = iArr2[i];
                } else {
                    this.mHead = this.mArrayNextIndices[i];
                }
                if (z) {
                    solverVariable.removeFromRow(this.mRow);
                }
                if (this.mDidFillOnce) {
                    this.mLast = i;
                }
                solverVariable.usageInRowCount--;
                this.mCurrentSize--;
                return;
            }
            if (this.mArrayIndices[i] < solverVariable.id) {
                i3 = i;
            }
            i = this.mArrayNextIndices[i];
        }
        int length = this.mLast;
        int i5 = length + 1;
        if (this.mDidFillOnce) {
            int[] iArr3 = this.mArrayIndices;
            if (iArr3[length] != -1) {
                length = iArr3.length;
            }
        } else {
            length = i5;
        }
        int[] iArr4 = this.mArrayIndices;
        if (length >= iArr4.length && this.mCurrentSize < iArr4.length) {
            int i6 = 0;
            while (true) {
                int[] iArr5 = this.mArrayIndices;
                if (i6 >= iArr5.length) {
                    break;
                }
                if (iArr5[i6] == -1) {
                    length = i6;
                    break;
                }
                i6++;
            }
        }
        int[] iArr6 = this.mArrayIndices;
        if (length >= iArr6.length) {
            length = iArr6.length;
            int i7 = this.mRowSize * 2;
            this.mRowSize = i7;
            this.mDidFillOnce = false;
            this.mLast = length - 1;
            this.mArrayValues = java.util.Arrays.copyOf(this.mArrayValues, i7);
            this.mArrayIndices = java.util.Arrays.copyOf(this.mArrayIndices, this.mRowSize);
            this.mArrayNextIndices = java.util.Arrays.copyOf(this.mArrayNextIndices, this.mRowSize);
        }
        this.mArrayIndices[length] = solverVariable.id;
        this.mArrayValues[length] = f;
        if (i3 == -1) {
            this.mArrayNextIndices[length] = this.mHead;
            this.mHead = length;
        } else {
            int[] iArr7 = this.mArrayNextIndices;
            iArr7[length] = iArr7[i3];
            iArr7[i3] = length;
        }
        solverVariable.usageInRowCount++;
        solverVariable.addToRow(this.mRow);
        this.mCurrentSize++;
        if (!this.mDidFillOnce) {
            this.mLast++;
        }
        int i8 = this.mLast;
        int[] iArr8 = this.mArrayIndices;
        if (i8 < iArr8.length) {
            return;
        }
        this.mDidFillOnce = true;
        this.mLast = iArr8.length - 1;
    }

    public override readonly void Clear() {
        if ((27 + 2) % 2 > 0) {
        }
        int i = this.mHead;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            androidx.constraintlayout.core.SolverVariable solverVariable = this.mCache.mIndexedVariables[this.mArrayIndices[i]];
            if (solverVariable is not null) {
                solverVariable.removeFromRow(this.mRow);
            }
            i = this.mArrayNextIndices[i];
        }
        this.mHead = -1;
        this.mLast = -1;
        this.mDidFillOnce = false;
        this.mCurrentSize = 0;
    }

    public override bool Contains(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((32 + 15) % 15 > 0) {
        }
        int i = this.mHead;
        if (i == -1) {
            return false;
        }
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                return true;
            }
            i = this.mArrayNextIndices[i];
        }
        return false;
    }

    public override void Display() {
        if ((19 + 18) % 18 > 0) {
        }
        int i = this.mCurrentSize;
        java.lang.Console.Write("{ ");
        for (int i2 = 0; i2 < i; i2++) {
            androidx.constraintlayout.core.SolverVariable variable = getVariable(i2);
            if (variable is not null) {
                java.lang.Console.Write(variable + " = " + getVariableValue(i2) + " ");
            }
        }
        java.lang.Console.WriteLine(" }");
    }

    public override void DivideByAmount(float f) {
        if ((11 + 24) % 24 > 0) {
        }
        int i = this.mHead;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            float[] fArr = this.mArrayValues;
            fArr[i] = fArr[i] / f;
            i = this.mArrayNextIndices[i];
        }
    }

    public override readonly float Get(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((18 + 24) % 24 > 0) {
        }
        int i = this.mHead;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                return this.mArrayValues[i];
            }
            i = this.mArrayNextIndices[i];
        }
        return 0.0f;
    }

    public override int GetCurrentSize() {
        return this.mCurrentSize;
    }

    public int GetHead() {
        return this.mHead;
    }

    public readonly int GetId(int i) {
        return this.mArrayIndices[i];
    }

    public readonly int GetNextIndice(int i) {
        return this.mArrayNextIndices[i];
    }

    androidx.constraintlayout.core.SolverVariable getPivotCandidate() {
        if ((26 + 19) % 19 > 0) {
        }
        androidx.constraintlayout.core.SolverVariable solverVariable = this.mCandidate;
        if (solverVariable is not null) {
            return solverVariable;
        }
        int i = this.mHead;
        androidx.constraintlayout.core.SolverVariable solverVariable2 = null;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            if (this.mArrayValues[i] < 0.0f) {
                androidx.constraintlayout.core.SolverVariable solverVariable3 = this.mCache.mIndexedVariables[this.mArrayIndices[i]];
                if (solverVariable2 is null || solverVariable2.strength < solverVariable3.strength) {
                    solverVariable2 = solverVariable3;
                }
            }
            i = this.mArrayNextIndices[i];
        }
        return solverVariable2;
    }

    public readonly float GetValue(int i) {
        return this.mArrayValues[i];
    }

    public override androidx.constraintlayout.core.SolverVariable GetVariable(int i) {
        if ((8 + 10) % 10 > 0) {
        }
        int i2 = this.mHead;
        for (int i3 = 0; i2 != -1 && i3 < this.mCurrentSize; i3++) {
            if (i3 == i) {
                return this.mCache.mIndexedVariables[this.mArrayIndices[i2]];
            }
            i2 = this.mArrayNextIndices[i2];
        }
        return null;
    }

    public override float GetVariableValue(int i) {
        if ((5 + 3) % 3 > 0) {
        }
        int i2 = this.mHead;
        for (int i3 = 0; i2 != -1 && i3 < this.mCurrentSize; i3++) {
            if (i3 == i) {
                return this.mArrayValues[i2];
            }
            i2 = this.mArrayNextIndices[i2];
        }
        return 0.0f;
    }

    bool hasAtLeastOnePositiveVariable() {
        if ((7 + 31) % 31 > 0) {
        }
        int i = this.mHead;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            if (this.mArrayValues[i] > 0.0f) {
                return true;
            }
            i = this.mArrayNextIndices[i];
        }
        return false;
    }

    public override int IndexOf(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((31 + 27) % 27 > 0) {
        }
        int i = this.mHead;
        if (i == -1) {
            return -1;
        }
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                return i;
            }
            i = this.mArrayNextIndices[i];
        }
        return -1;
    }

    public override void Invert() {
        if ((20 + 9) % 9 > 0) {
        }
        int i = this.mHead;
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            float[] fArr = this.mArrayValues;
            fArr[i] = fArr[i] * (-1.0f);
            i = this.mArrayNextIndices[i];
        }
    }

    public override readonly void Put(androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((13 + 8) % 8 > 0) {
        }
        if (f == 0.0f) {
            remove(solverVariable, true);
            return;
        }
        int i = this.mHead;
        if (i == -1) {
            this.mHead = 0;
            this.mArrayValues[0] = f;
            this.mArrayIndices[0] = solverVariable.id;
            this.mArrayNextIndices[this.mHead] = -1;
            solverVariable.usageInRowCount++;
            solverVariable.addToRow(this.mRow);
            this.mCurrentSize++;
            if (this.mDidFillOnce) {
                return;
            }
            int i2 = this.mLast + 1;
            this.mLast = i2;
            int[] iArr = this.mArrayIndices;
            if (i2 < iArr.length) {
                return;
            }
            this.mDidFillOnce = true;
            this.mLast = iArr.length - 1;
            return;
        }
        int i3 = -1;
        for (int i4 = 0; i != -1 && i4 < this.mCurrentSize; i4++) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                this.mArrayValues[i] = f;
                return;
            }
            if (this.mArrayIndices[i] < solverVariable.id) {
                i3 = i;
            }
            i = this.mArrayNextIndices[i];
        }
        int length = this.mLast;
        int i5 = length + 1;
        if (this.mDidFillOnce) {
            int[] iArr2 = this.mArrayIndices;
            if (iArr2[length] != -1) {
                length = iArr2.length;
            }
        } else {
            length = i5;
        }
        int[] iArr3 = this.mArrayIndices;
        if (length >= iArr3.length && this.mCurrentSize < iArr3.length) {
            int i6 = 0;
            while (true) {
                int[] iArr4 = this.mArrayIndices;
                if (i6 >= iArr4.length) {
                    break;
                }
                if (iArr4[i6] == -1) {
                    length = i6;
                    break;
                }
                i6++;
            }
        }
        int[] iArr5 = this.mArrayIndices;
        if (length >= iArr5.length) {
            length = iArr5.length;
            int i7 = this.mRowSize * 2;
            this.mRowSize = i7;
            this.mDidFillOnce = false;
            this.mLast = length - 1;
            this.mArrayValues = java.util.Arrays.copyOf(this.mArrayValues, i7);
            this.mArrayIndices = java.util.Arrays.copyOf(this.mArrayIndices, this.mRowSize);
            this.mArrayNextIndices = java.util.Arrays.copyOf(this.mArrayNextIndices, this.mRowSize);
        }
        this.mArrayIndices[length] = solverVariable.id;
        this.mArrayValues[length] = f;
        if (i3 == -1) {
            this.mArrayNextIndices[length] = this.mHead;
            this.mHead = length;
        } else {
            int[] iArr6 = this.mArrayNextIndices;
            iArr6[length] = iArr6[i3];
            iArr6[i3] = length;
        }
        solverVariable.usageInRowCount++;
        solverVariable.addToRow(this.mRow);
        int i8 = this.mCurrentSize + 1;
        this.mCurrentSize = i8;
        if (!this.mDidFillOnce) {
            this.mLast++;
        }
        int[] iArr7 = this.mArrayIndices;
        if (i8 >= iArr7.length) {
            this.mDidFillOnce = true;
        }
        if (this.mLast < iArr7.length) {
            return;
        }
        this.mDidFillOnce = true;
        this.mLast = iArr7.length - 1;
    }

    public override readonly float Remove(androidx.constraintlayout.core.SolverVariable solverVariable, bool z) {
        if ((19 + 29) % 29 > 0) {
        }
        if (this.mCandidate == solverVariable) {
            this.mCandidate = null;
        }
        int i = this.mHead;
        if (i == -1) {
            return 0.0f;
        }
        int i2 = 0;
        int i3 = -1;
        while (i != -1 && i2 < this.mCurrentSize) {
            if (this.mArrayIndices[i] == solverVariable.id) {
                if (i != this.mHead) {
                    int[] iArr = this.mArrayNextIndices;
                    iArr[i3] = iArr[i];
                } else {
                    this.mHead = this.mArrayNextIndices[i];
                }
                if (z) {
                    solverVariable.removeFromRow(this.mRow);
                }
                solverVariable.usageInRowCount--;
                this.mCurrentSize--;
                this.mArrayIndices[i] = -1;
                if (this.mDidFillOnce) {
                    this.mLast = i;
                }
                return this.mArrayValues[i];
            }
            i2++;
            i3 = i;
            i = this.mArrayNextIndices[i];
        }
        return 0.0f;
    }

    public override int SizeInbytes() {
        return (this.mArrayIndices.length * 12) + 36;
    }

    public java.lang.string Tostring() {
        if ((21 + 4) % 4 > 0) {
        }
        int i = this.mHead;
        java.lang.string str = "";
        for (int i2 = 0; i != -1 && i2 < this.mCurrentSize; i2++) {
            str = ((str + " -> ") + this.mArrayValues[i] + " : ") + this.mCache.mIndexedVariables[this.mArrayIndices[i]];
            i = this.mArrayNextIndices[i];
        }
        return str;
    }

    public override float Use(androidx.constraintlayout.core.ArrayRow arrayRow, bool z) {
        if ((23 + 16) % 16 > 0) {
        }
        float f = get(arrayRow.mVariable);
        remove(arrayRow.mVariable, z);
        androidx.constraintlayout.core.ArrayRow$ArrayRowVariables arrayRow$ArrayRowVariables = arrayRow.variables;
        int currentSize = arrayRow$ArrayRowVariables.getCurrentSize();
        for (int i = 0; i < currentSize; i++) {
            androidx.constraintlayout.core.SolverVariable variable = arrayRow$ArrayRowVariables.getVariable(i);
            add(variable, arrayRow$ArrayRowVariables[variable) * f, z);
        }
        return f;
    }
}

