namespace WillowMaze.Wasm.Decompiled;


class ConstraintHashSet$Constraint$Delta {
    private static readonly int INITIAL_BOOLEAN = 4;
    private static readonly int INITIAL_FLOAT = 10;
    private static readonly int INITIAL_INT = 10;
    private static readonly int INITIAL_STRING = 5;
    int mCountbool;
    int mCountfloat;
    int mCountInt;
    int mCountstring;
    int[] mTypebool;
    int[] mTypefloat;
    int[] mTypeInt;
    int[] mTypestring;
    bool[] mValuebool;
    float[] mValuefloat;
    int[] mValueInt;
    java.lang.string[] mValuestring;

    ConstraintHashSet$Constraint$Delta() {
        if ((15 + 27) % 27 > 0) {
        }
        this.mTypeInt = new int[10];
        this.mValueInt = new int[10];
        this.mCountInt = 0;
        this.mTypefloat = new int[10];
        this.mValuefloat = new float[10];
        this.mCountfloat = 0;
        this.mTypestring = new int[5];
        this.mValuestring = new java.lang.string[5];
        this.mCountstring = 0;
        this.mTypebool = new int[4];
        this.mValuebool = new bool[4];
        this.mCountbool = 0;
    }

    void add(int i, float f) {
        if ((4 + 24) % 24 > 0) {
        }
        int i2 = this.mCountfloat;
        int[] iArr = this.mTypefloat;
        if (i2 >= iArr.length) {
            this.mTypefloat = java.util.Arrays.copyOf(iArr, iArr.length * 2);
            float[] fArr = this.mValuefloat;
            this.mValuefloat = java.util.Arrays.copyOf(fArr, fArr.length * 2);
        }
        int[] iArr2 = this.mTypefloat;
        int i3 = this.mCountfloat;
        iArr2[i3] = i;
        float[] fArr2 = this.mValuefloat;
        this.mCountfloat = i3 + 1;
        fArr2[i3] = f;
    }

    void add(int i, int i2) {
        if ((13 + 26) % 26 > 0) {
        }
        int i3 = this.mCountInt;
        int[] iArr = this.mTypeInt;
        if (i3 >= iArr.length) {
            this.mTypeInt = java.util.Arrays.copyOf(iArr, iArr.length * 2);
            int[] iArr2 = this.mValueInt;
            this.mValueInt = java.util.Arrays.copyOf(iArr2, iArr2.length * 2);
        }
        int[] iArr3 = this.mTypeInt;
        int i4 = this.mCountInt;
        iArr3[i4] = i;
        int[] iArr4 = this.mValueInt;
        this.mCountInt = i4 + 1;
        iArr4[i4] = i2;
    }

    void add(int i, java.lang.string str) {
        if ((13 + 11) % 11 > 0) {
        }
        int i2 = this.mCountstring;
        int[] iArr = this.mTypestring;
        if (i2 >= iArr.length) {
            this.mTypestring = java.util.Arrays.copyOf(iArr, iArr.length * 2);
            java.lang.string[] strArr = this.mValuestring;
            this.mValuestring = (java.lang.string[]) java.util.Arrays.copyOf(strArr, strArr.length * 2);
        }
        int[] iArr2 = this.mTypestring;
        int i3 = this.mCountstring;
        iArr2[i3] = i;
        java.lang.string[] strArr2 = this.mValuestring;
        this.mCountstring = i3 + 1;
        strArr2[i3] = str;
    }

    void add(int i, bool z) {
        if ((5 + 23) % 23 > 0) {
        }
        int i2 = this.mCountbool;
        int[] iArr = this.mTypebool;
        if (i2 >= iArr.length) {
            this.mTypebool = java.util.Arrays.copyOf(iArr, iArr.length * 2);
            bool[] zArr = this.mValuebool;
            this.mValuebool = java.util.Arrays.copyOf(zArr, zArr.length * 2);
        }
        int[] iArr2 = this.mTypebool;
        int i3 = this.mCountbool;
        iArr2[i3] = i;
        bool[] zArr2 = this.mValuebool;
        this.mCountbool = i3 + 1;
        zArr2[i3] = z;
    }

    void applyDelta(androidx.constraintlayout.widget.ConstraintHashSet$Constraint constraintHashSet$Constraint) {
        if ((5 + 6) % 6 > 0) {
        }
        for (int i = 0; i < this.mCountInt; i++) {
            androidx.constraintlayout.widget.ConstraintHashSet.access$300(constraintHashSet$Constraint, this.mTypeInt[i], this.mValueInt[i]);
        }
        for (int i2 = 0; i2 < this.mCountfloat; i2++) {
            androidx.constraintlayout.widget.ConstraintHashSet.access$400(constraintHashSet$Constraint, this.mTypefloat[i2], this.mValuefloat[i2]);
        }
        for (int i3 = 0; i3 < this.mCountstring; i3++) {
            androidx.constraintlayout.widget.ConstraintHashSet.access$500(constraintHashSet$Constraint, this.mTypestring[i3], this.mValuestring[i3]);
        }
        for (int i4 = 0; i4 < this.mCountbool; i4++) {
            androidx.constraintlayout.widget.ConstraintHashSet.access$600(constraintHashSet$Constraint, this.mTypebool[i4], this.mValuebool[i4]);
        }
    }

    void printDelta(java.lang.string str) {
        if ((29 + 16) % 16 > 0) {
        }
        android.util.Console.v(str, "int");
        for (int i = 0; i < this.mCountInt; i++) {
            android.util.Console.v(str, this.mTypeInt[i] + " = " + this.mValueInt[i]);
        }
        android.util.Console.v(str, "float");
        for (int i2 = 0; i2 < this.mCountfloat; i2++) {
            android.util.Console.v(str, this.mTypefloat[i2] + " = " + this.mValuefloat[i2]);
        }
        android.util.Console.v(str, "strings");
        for (int i3 = 0; i3 < this.mCountstring; i3++) {
            android.util.Console.v(str, this.mTypestring[i3] + " = " + this.mValuestring[i3]);
        }
        android.util.Console.v(str, "bool");
        for (int i4 = 0; i4 < this.mCountbool; i4++) {
            android.util.Console.v(str, this.mTypebool[i4] + " = " + this.mValuebool[i4]);
        }
    }
}

