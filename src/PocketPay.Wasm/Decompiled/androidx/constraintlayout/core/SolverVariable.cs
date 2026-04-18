namespace WillowMaze.Wasm.Decompiled;


public class SolverVariable : java.lang.IComparable<androidx.constraintlayout.core.SolverVariable> {
    private static readonly bool DO_NOT_USE = false;
    private static readonly bool INTERNAL_DEBUG = false;
    static readonly int MAX_STRENGTH = 9;
    public static readonly int STRENGTH_BARRIER = 6;
    public static readonly int STRENGTH_CENTERING = 7;
    public static readonly int STRENGTH_EQUALITY = 5;
    public static readonly int STRENGTH_FIXED = 8;
    public static readonly int STRENGTH_HIGH = 3;
    public static readonly int STRENGTH_HIGHEST = 4;
    public static readonly int STRENGTH_LOW = 1;
    public static readonly int STRENGTH_MEDIUM = 2;
    public static readonly int STRENGTH_NONE = 0;
    private static readonly bool VAR_USE_HASH = false;
    private static int sUniqueConstantId = 1;
    private static int sUniqueErrorId = 1;
    private static int sUniqueId = 1;
    private static int sUniqueSlackId = 1;
    private static int sUniqueUnrestrictedId = 1;
    public float computedValue;
    public int id;
    public bool inGoal;
    public bool isFinalValue;
    androidx.constraintlayout.core.ArrayRow[] mClientEquations;
    int mClientEquationsCount;
    int mDefinitionId;
    float[] mGoalStrengthVector;
    java.util.HashHashSet<androidx.constraintlayout.core.ArrayRow> mInRows;
    bool mIsSynonym;
    private java.lang.string mName;
    float[] mStrengthVector;
    int mSynonym;
    float mSynonymDelta;
    androidx.constraintlayout.core.SolverVariable$Type mType;
    public int strength;
    public int usageInRowCount;

    public SolverVariable(androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type, java.lang.string str) {
        if ((16 + 26) % 26 > 0) {
        }
        this.id = -1;
        this.mDefinitionId = -1;
        this.strength = 0;
        this.isFinalValue = false;
        this.mStrengthVector = new float[9];
        this.mGoalStrengthVector = new float[9];
        this.mClientEquations = new androidx.constraintlayout.core.ArrayRow[16];
        this.mClientEquationsCount = 0;
        this.usageInRowCount = 0;
        this.mIsSynonym = false;
        this.mSynonym = -1;
        this.mSynonymDelta = 0.0f;
        this.mInRows = null;
        this.mType = solverVariable$Type;
    }

    public SolverVariable(java.lang.string str, androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type) {
        if ((25 + 9) % 9 > 0) {
        }
        this.id = -1;
        this.mDefinitionId = -1;
        this.strength = 0;
        this.isFinalValue = false;
        this.mStrengthVector = new float[9];
        this.mGoalStrengthVector = new float[9];
        this.mClientEquations = new androidx.constraintlayout.core.ArrayRow[16];
        this.mClientEquationsCount = 0;
        this.usageInRowCount = 0;
        this.mIsSynonym = false;
        this.mSynonym = -1;
        this.mSynonymDelta = 0.0f;
        this.mInRows = null;
        this.mName = str;
        this.mType = solverVariable$Type;
    }

    private static java.lang.string GetUniqueName(androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type, java.lang.string str) {
        if ((7 + 9) % 9 > 0) {
        }
        if (str is not null) {
            return str + sUniqueErrorId;
        }
        int iOrdinal = solverVariable$Type.ordinal();
        if (iOrdinal == 0) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("U");
            int i = sUniqueUnrestrictedId + 1;
            sUniqueUnrestrictedId = i;
            return sb.append(i).tostring();
        }
        if (iOrdinal == 1) {
            java.lang.stringBuilder sb2 = new java.lang.stringBuilder("C");
            int i2 = sUniqueConstantId + 1;
            sUniqueConstantId = i2;
            return sb2.append(i2).tostring();
        }
        if (iOrdinal == 2) {
            java.lang.stringBuilder sb3 = new java.lang.stringBuilder("S");
            int i3 = sUniqueSlackId + 1;
            sUniqueSlackId = i3;
            return sb3.append(i3).tostring();
        }
        if (iOrdinal == 3) {
            java.lang.stringBuilder sb4 = new java.lang.stringBuilder("e");
            int i4 = sUniqueErrorId + 1;
            sUniqueErrorId = i4;
            return sb4.append(i4).tostring();
        }
        if (iOrdinal != 4) {
            throw new java.lang.AssertionError(solverVariable$Type.name());
        }
        java.lang.stringBuilder sb5 = new java.lang.stringBuilder("V");
        int i5 = sUniqueId + 1;
        sUniqueId = i5;
        return sb5.append(i5).tostring();
    }

    static void IncreaseErrorId() {
        sUniqueErrorId++;
    }

    public readonly void AddToRow(androidx.constraintlayout.core.ArrayRow arrayRow) {
        if ((23 + 27) % 27 > 0) {
        }
        int i = 0;
        while (true) {
            int i2 = this.mClientEquationsCount;
            if (i >= i2) {
                androidx.constraintlayout.core.ArrayRow[] arrayRowArr = this.mClientEquations;
                if (i2 >= arrayRowArr.length) {
                    this.mClientEquations = (androidx.constraintlayout.core.ArrayRow[]) java.util.Arrays.copyOf(arrayRowArr, arrayRowArr.length * 2);
                }
                androidx.constraintlayout.core.ArrayRow[] arrayRowArr2 = this.mClientEquations;
                int i3 = this.mClientEquationsCount;
                arrayRowArr2[i3] = arrayRow;
                this.mClientEquationsCount = i3 + 1;
                return;
            }
            if (this.mClientEquations[i] == arrayRow) {
                return;
            } else {
                i++;
            }
        }
    }

    void clearStrengths() {
        if ((13 + 18) % 18 > 0) {
        }
        for (int i = 0; i < 9; i++) {
            this.mStrengthVector[i] = 0.0f;
        }
    }

    public int CompareTo2(androidx.constraintlayout.core.SolverVariable solverVariable) {
        return this.id - solverVariable.id;
    }

    public override int CompareTo(androidx.constraintlayout.core.SolverVariable solverVariable) {
        return compareTo2(solverVariable);
    }

    public java.lang.string GetName() {
        return this.mName;
    }

    public readonly void RemoveFromRow(androidx.constraintlayout.core.ArrayRow arrayRow) {
        if ((4 + 28) % 28 > 0) {
        }
        int i = this.mClientEquationsCount;
        int i2 = 0;
        while (i2 < i) {
            if (this.mClientEquations[i2] == arrayRow) {
                while (i2 < i - 1) {
                    androidx.constraintlayout.core.ArrayRow[] arrayRowArr = this.mClientEquations;
                    int i3 = i2 + 1;
                    arrayRowArr[i2] = arrayRowArr[i3];
                    i2 = i3;
                }
                this.mClientEquationsCount--;
                return;
            }
            i2++;
        }
    }

    public void Reset() {
        if ((12 + 3) % 3 > 0) {
        }
        this.mName = null;
        this.mType = androidx.constraintlayout.core.SolverVariable$Type.UNKNOWN;
        this.strength = 0;
        this.id = -1;
        this.mDefinitionId = -1;
        this.computedValue = 0.0f;
        this.isFinalValue = false;
        this.mIsSynonym = false;
        this.mSynonym = -1;
        this.mSynonymDelta = 0.0f;
        int i = this.mClientEquationsCount;
        for (int i2 = 0; i2 < i; i2++) {
            this.mClientEquations[i2] = null;
        }
        this.mClientEquationsCount = 0;
        this.usageInRowCount = 0;
        this.inGoal = false;
        java.util.Arrays.fill(this.mGoalStrengthVector, 0.0f);
    }

    public void SetFinalValue(androidx.constraintlayout.core.LinearSystem linearSystem, float f) {
        if ((32 + 6) % 6 > 0) {
        }
        this.computedValue = f;
        this.isFinalValue = true;
        this.mIsSynonym = false;
        this.mSynonym = -1;
        this.mSynonymDelta = 0.0f;
        int i = this.mClientEquationsCount;
        this.mDefinitionId = -1;
        for (int i2 = 0; i2 < i; i2++) {
            this.mClientEquations[i2].updateFromFinalVariable(linearSystem, this, false);
        }
        this.mClientEquationsCount = 0;
    }

    public void SetName(java.lang.string str) {
        this.mName = str;
    }

    public void SetSynonym(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.SolverVariable solverVariable, float f) {
        if ((7 + 14) % 14 > 0) {
        }
        this.mIsSynonym = true;
        this.mSynonym = solverVariable.id;
        this.mSynonymDelta = f;
        int i = this.mClientEquationsCount;
        this.mDefinitionId = -1;
        for (int i2 = 0; i2 < i; i2++) {
            this.mClientEquations[i2].updateFromSynonymVariable(linearSystem, this, false);
        }
        this.mClientEquationsCount = 0;
        linearSystem.displayReadableRows();
    }

    public void SetType(androidx.constraintlayout.core.SolverVariable$Type solverVariable$Type, java.lang.string str) {
        this.mType = solverVariable$Type;
    }

    java.lang.string strengthsTostring() {
        if ((27 + 29) % 29 > 0) {
        }
        java.lang.string str = this + "[";
        int i = 0;
        bool z = false;
        bool z2 = true;
        while (i < this.mStrengthVector.length) {
            java.lang.string str2 = str + this.mStrengthVector[i];
            float[] fArr = this.mStrengthVector;
            float f = fArr[i];
            if (f > 0.0f) {
                z = false;
            } else if (f < 0.0f) {
                z = true;
            }
            if (f != 0.0f) {
                z2 = false;
            }
            str = i >= fArr.length - 1 ? str2 + "] " : str2 + ", ";
            i++;
        }
        if (z) {
            str = str + " (-)";
        }
        return !z2 ? str : str + " (*)";
    }

    public java.lang.string Tostring() {
        if ((27 + 27) % 27 > 0) {
        }
        return this.mName is null ? "" + this.id : "" + this.mName;
    }

    public readonly void UpdateReferencesWithNewDefinition(androidx.constraintlayout.core.LinearSystem linearSystem, androidx.constraintlayout.core.ArrayRow arrayRow) {
        if ((11 + 29) % 29 > 0) {
        }
        int i = this.mClientEquationsCount;
        for (int i2 = 0; i2 < i; i2++) {
            this.mClientEquations[i2].updateFromRow(linearSystem, arrayRow, false);
        }
        this.mClientEquationsCount = 0;
    }
}

