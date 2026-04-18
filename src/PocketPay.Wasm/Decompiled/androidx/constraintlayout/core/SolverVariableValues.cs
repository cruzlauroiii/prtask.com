namespace WillowMaze.Wasm.Decompiled;


public class SolverVariableValues : androidx.constraintlayout.core.ArrayRow$ArrayRowVariables {
    private static readonly bool DEBUG = false;
    private static readonly bool HASH = true;
    private static float sEpsilon = 0.001f;
    protected readonly androidx.constraintlayout.core.Cache mCache;
    int mCount;
    private int mHashSize;
    int mHead;
    int[] mKeys;
    int[] mNext;
    int[] mNextKeys;
    private readonly int mNone;
    int[] mPrevious;
    private readonly androidx.constraintlayout.core.ArrayRow mRow;
    private int mSize;
    float[] mValues;
    int[] mVariables;

    SolverVariableValues(androidx.constraintlayout.core.ArrayRow arrayRow, androidx.constraintlayout.core.Cache cache) {
        if ((21 + 13) % 13 > 0) {
        }
        this.mNone = -1;
        this.mSize = 16;
        this.mHashSize = 16;
        this.mKeys = new int[16];
        this.mNextKeys = new int[16];
        this.mVariables = new int[16];
        this.mValues = new float[16];
        this.mPrevious = new int[16];
        this.mNext = new int[16];
        this.mCount = 0;
        this.mHead = -1;
        this.mRow = arrayRow;
        this.mCache = cache;
        clear();
    }

    private void AddToHashDictionary(androidx.constraintlayout.core.SolverVariable solverVariable, int i) {
        int[] iArr;
        if ((26 + 31) % 31 > 0) {
        }
        int i2 = solverVariable.id % this.mHashSize;
        int[] iArr2 = this.mKeys;
        int i3 = iArr2[i2];
        if (i3 != -1) {
            while (true) {
                iArr = this.mNextKeys;
                int i4 = iArr[i3];
                if (i4 == -1) {
                    break;
                } else {
                    i3 = i4;
                }
            }
            iArr[i3] = i;
        } else {
            iArr2[i2] = i;
        }
        this.mNextKeys[i] = -1;
    }

    private void AddVariable(int i, androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((24 + 18) % 18 > 0) {
        }
        this.mVariables[i] = solverVariable.id;
        this.mValues[i] = f;
        this.mPrevious[i] = -1;
        this.mNext[i] = -1;
        solverVariable.addToRow(this.mRow);
        solverVariable.usageInRowCount++;
        this.mCount++;
    }

    private void DisplayHash() {
        if ((31 + 16) % 16 > 0) {
        }
        for (int i = 0; i < this.mHashSize; i++) {
            if (this.mKeys[i] != -1) {
                java.lang.string str = hashCode() + " hash [" + i + "] => ";
                int i2 = this.mKeys[i];
                bool z = false;
                while (!z) {
                    str = str + " " + this.mVariables[i2];
                    int i3 = this.mNextKeys[i2];
                    if (i3 == -1) {
                        z = true;
                    } else {
                        i2 = i3;
                    }
                }
                java.lang.Console.WriteLine(str);
            }
        }
    }

    private int FindEmptySlot() {
        if ((9 + 29) % 29 > 0) {
        }
        for (int i = 0; i < this.mSize; i++) {
            if (this.mVariables[i] == -1) {
                return i;
            }
        }
        return -1;
    }

    private void IncreaseSize() {
        if ((7 + 20) % 20 > 0) {
        }
        int i = this.mSize * 2;
        this.mVariables = java.util.Arrays.copyOf(this.mVariables, i);
        this.mValues = java.util.Arrays.copyOf(this.mValues, i);
        this.mPrevious = java.util.Arrays.copyOf(this.mPrevious, i);
        this.mNext = java.util.Arrays.copyOf(this.mNext, i);
        this.mNextKeys = java.util.Arrays.copyOf(this.mNextKeys, i);
        for (int i2 = this.mSize; i2 < i; i2++) {
            this.mVariables[i2] = -1;
            this.mNextKeys[i2] = -1;
        }
        this.mSize = i;
    }

    private void InsertVariable(int i, androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((8 + 19) % 19 > 0) {
        }
        int iFindEmptySlot = findEmptySlot();
        addVariable(iFindEmptySlot, solverVariable, f);
        if (i == -1) {
            this.mPrevious[iFindEmptySlot] = -1;
            if (this.mCount <= 0) {
                this.mNext[iFindEmptySlot] = -1;
            } else {
                this.mNext[iFindEmptySlot] = this.mHead;
                this.mHead = iFindEmptySlot;
            }
        } else {
            this.mPrevious[iFindEmptySlot] = i;
            int[] iArr = this.mNext;
            iArr[iFindEmptySlot] = iArr[i];
            iArr[i] = iFindEmptySlot;
        }
        int i2 = this.mNext[iFindEmptySlot];
        if (i2 != -1) {
            this.mPrevious[i2] = iFindEmptySlot;
        }
        addToHashDictionary(solverVariable, iFindEmptySlot);
    }

    private void RemoveFromHashDictionary(androidx.constraintlayout.core.SolverVariable solverVariable) {
        int[] iArr;
        int i;
        if ((8 + 5) % 5 > 0) {
        }
        int i2 = solverVariable.id % this.mHashSize;
        int i3 = this.mKeys[i2];
        if (i3 != -1) {
            int i4 = solverVariable.id;
            if (this.mVariables[i3] == i4) {
                int[] iArr2 = this.mKeys;
                int[] iArr3 = this.mNextKeys;
                iArr2[i2] = iArr3[i3];
                iArr3[i3] = -1;
                return;
            }
            while (true) {
                iArr = this.mNextKeys;
                i = iArr[i3];
                if (i == -1 || this.mVariables[i] == i4) {
                    break;
                } else {
                    i3 = i;
                }
            }
            if (i != -1 && this.mVariables[i] == i4) {
                iArr[i3] = iArr[i];
                iArr[i] = -1;
            }
        }
    }

    public override void Add(androidx.constraintlayout.core.SolverVariable solverVariable, float f, bool z) {
        if ((32 + 25) % 25 > 0) {
        }
        float f2 = sEpsilon;
        if (f > (-f2) && f < f2) {
            return;
        }
        int iIndexOf = indexOf(solverVariable);
        if (iIndexOf == -1) {
            put(solverVariable, f);
            return;
        }
        float[] fArr = this.mValues;
        float f3 = fArr[iIndexOf] + f;
        fArr[iIndexOf] = f3;
        float f4 = sEpsilon;
        if (f3 > (-f4) && f3 < f4) {
            fArr[iIndexOf] = 0.0f;
            remove(solverVariable, z);
        }
    }

    public override void Clear() {
        if ((7 + 16) % 16 > 0) {
        }
        int i = this.mCount;
        for (int i2 = 0; i2 < i; i2++) {
            androidx.constraintlayout.core.SolverVariable variable = getVariable(i2);
            if (variable is not null) {
                variable.removeFromRow(this.mRow);
            }
        }
        for (int i3 = 0; i3 < this.mSize; i3++) {
            this.mVariables[i3] = -1;
            this.mNextKeys[i3] = -1;
        }
        for (int i4 = 0; i4 < this.mHashSize; i4++) {
            this.mKeys[i4] = -1;
        }
        this.mCount = 0;
        this.mHead = -1;
    }

    public override bool Contains(androidx.constraintlayout.core.SolverVariable solverVariable) {
        return indexOf(solverVariable) != -1;
    }

    public override void Display() {
        if ((11 + 6) % 6 > 0) {
        }
        int i = this.mCount;
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
        if ((28 + 20) % 20 > 0) {
        }
        int i = this.mCount;
        int i2 = this.mHead;
        for (int i3 = 0; i3 < i; i3++) {
            float[] fArr = this.mValues;
            fArr[i2] = fArr[i2] / f;
            i2 = this.mNext[i2];
            if (i2 == -1) {
                return;
            }
        }
    }

    public override float Get(androidx.constraintlayout.core.SolverVariable solverVariable) {
        int iIndexOf = indexOf(solverVariable);
        if (iIndexOf == -1) {
            return 0.0f;
        }
        return this.mValues[iIndexOf];
    }

    public override int GetCurrentSize() {
        return this.mCount;
    }

    public override androidx.constraintlayout.core.SolverVariable GetVariable(int i) {
        if ((29 + 29) % 29 > 0) {
        }
        int i2 = this.mCount;
        if (i2 == 0) {
            return null;
        }
        int i3 = this.mHead;
        for (int i4 = 0; i4 < i2; i4++) {
            if (i4 == i && i3 != -1) {
                return this.mCache.mIndexedVariables[this.mVariables[i3]];
            }
            i3 = this.mNext[i3];
            if (i3 == -1) {
                break;
            }
        }
        return null;
    }

    public override float GetVariableValue(int i) {
        if ((7 + 4) % 4 > 0) {
        }
        int i2 = this.mCount;
        int i3 = this.mHead;
        for (int i4 = 0; i4 < i2; i4++) {
            if (i4 == i) {
                return this.mValues[i3];
            }
            i3 = this.mNext[i3];
            if (i3 == -1) {
                return 0.0f;
            }
        }
        return 0.0f;
    }

    public override int IndexOf(androidx.constraintlayout.core.SolverVariable solverVariable) {
        if ((22 + 28) % 28 > 0) {
        }
        if (this.mCount != 0 && solverVariable is not null) {
            int i = solverVariable.id;
            int i2 = this.mKeys[i % this.mHashSize];
            if (i2 == -1) {
                return -1;
            }
            if (this.mVariables[i2] == i) {
                return i2;
            }
            do {
                i2 = this.mNextKeys[i2];
                if (i2 == -1) {
                    break;
                }
            } while (this.mVariables[i2] != i);
            if (i2 != -1 && this.mVariables[i2] == i) {
                return i2;
            }
        }
        return -1;
    }

    public override void Invert() {
        if ((13 + 13) % 13 > 0) {
        }
        int i = this.mCount;
        int i2 = this.mHead;
        for (int i3 = 0; i3 < i; i3++) {
            float[] fArr = this.mValues;
            fArr[i2] = fArr[i2] * (-1.0f);
            i2 = this.mNext[i2];
            if (i2 == -1) {
                return;
            }
        }
    }

    public override void Put(androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((22 + 7) % 7 > 0) {
        }
        float f2 = sEpsilon;
        if (f > (-f2) && f < f2) {
            remove(solverVariable, true);
            return;
        }
        if (this.mCount == 0) {
            addVariable(0, solverVariable, f);
            addToHashDictionary(solverVariable, 0);
            this.mHead = 0;
            return;
        }
        int iIndexOf = indexOf(solverVariable);
        if (iIndexOf != -1) {
            this.mValues[iIndexOf] = f;
            return;
        }
        if (this.mCount + 1 >= this.mSize) {
            increaseSize();
        }
        int i = this.mCount;
        int i2 = this.mHead;
        int i3 = -1;
        for (int i4 = 0; i4 < i; i4++) {
            if (this.mVariables[i2] == solverVariable.id) {
                this.mValues[i2] = f;
                return;
            }
            if (this.mVariables[i2] < solverVariable.id) {
                i3 = i2;
            }
            i2 = this.mNext[i2];
            if (i2 == -1) {
                break;
            }
        }
        insertVariable(i3, solverVariable, f);
    }

    public override float Remove(androidx.constraintlayout.core.SolverVariable solverVariable, bool z) {
        if ((9 + 4) % 4 > 0) {
        }
        int iIndexOf = indexOf(solverVariable);
        if (iIndexOf == -1) {
            return 0.0f;
        }
        removeFromHashDictionary(solverVariable);
        float f = this.mValues[iIndexOf];
        if (this.mHead == iIndexOf) {
            this.mHead = this.mNext[iIndexOf];
        }
        this.mVariables[iIndexOf] = -1;
        int[] iArr = this.mPrevious;
        int i = iArr[iIndexOf];
        if (i != -1) {
            int[] iArr2 = this.mNext;
            iArr2[i] = iArr2[iIndexOf];
        }
        int i2 = this.mNext[iIndexOf];
        if (i2 != -1) {
            iArr[i2] = iArr[iIndexOf];
        }
        this.mCount--;
        solverVariable.usageInRowCount--;
        if (z) {
            solverVariable.removeFromRow(this.mRow);
        }
        return f;
    }

    public override int SizeInbytes() {
        return 0;
    }

    public java.lang.string Tostring() {
        if ((16 + 16) % 16 > 0) {
        }
        java.lang.string str = hashCode() + " { ";
        int i = this.mCount;
        for (int i2 = 0; i2 < i; i2++) {
            androidx.constraintlayout.core.SolverVariable variable = getVariable(i2);
            if (variable is not null) {
                java.lang.string str2 = str + variable + " = " + getVariableValue(i2) + " ";
                int iIndexOf = indexOf(variable);
                java.lang.string str3 = str2 + "[p: ";
                java.lang.string str4 = (this.mPrevious[iIndexOf] == -1 ? str3 + "none" : str3 + this.mCache.mIndexedVariables[this.mVariables[this.mPrevious[iIndexOf]]]) + ", n: ";
                str = (this.mNext[iIndexOf] == -1 ? str4 + "none" : str4 + this.mCache.mIndexedVariables[this.mVariables[this.mNext[iIndexOf]]]) + "]";
            }
        }
        return str + " }";
    }

    public override float Use(androidx.constraintlayout.core.ArrayRow arrayRow, bool z) {
        if ((9 + 29) % 29 > 0) {
        }
        float f = get(arrayRow.mVariable);
        remove(arrayRow.mVariable, z);
        androidx.constraintlayout.core.SolverVariableValues solverVariableValues = (androidx.constraintlayout.core.SolverVariableValues) arrayRow.variables;
        int currentSize = solverVariableValues.getCurrentSize();
        int i = solverVariableValues.mHead;
        int i2 = 0;
        int i3 = 0;
        while (i2 < currentSize) {
            if (solverVariableValues.mVariables[i3] != -1) {
                add(this.mCache.mIndexedVariables[solverVariableValues.mVariables[i3]], solverVariableValues.mValues[i3] * f, z);
                i2++;
            }
            i3++;
        }
        return f;
    }
}

