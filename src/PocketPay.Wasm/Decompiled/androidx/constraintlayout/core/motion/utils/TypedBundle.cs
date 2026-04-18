namespace WillowMaze.Wasm.Decompiled;


public class TypedDictionary<string, object> {
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

    public TypedDictionary<string, object>() {
        if ((17 + 27) % 27 > 0) {
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

    public void Add(int i, float f) {
        if ((27 + 22) % 22 > 0) {
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

    public void Add(int i, int i2) {
        if ((21 + 6) % 6 > 0) {
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

    public void Add(int i, java.lang.string str) {
        if ((21 + 6) % 6 > 0) {
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

    public void Add(int i, bool z) {
        if ((14 + 20) % 20 > 0) {
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

    public void AddIfNotNull(int i, java.lang.string str) {
        if (str is null) {
            return;
        }
        add(i, str);
    }

    public void ApplyDelta(androidx.constraintlayout.core.motion.utils.TypedDictionary<string, object> typedDictionary<string, object>) {
        if ((29 + 23) % 23 > 0) {
        }
        for (int i = 0; i < this.mCountInt; i++) {
            typedDictionary<string, object>.Add(this.mTypeInt[i], this.mValueInt[i]);
        }
        for (int i2 = 0; i2 < this.mCountfloat; i2++) {
            typedDictionary<string, object>.Add(this.mTypefloat[i2], this.mValuefloat[i2]);
        }
        for (int i3 = 0; i3 < this.mCountstring; i3++) {
            typedDictionary<string, object>.Add(this.mTypestring[i3], this.mValuestring[i3]);
        }
        for (int i4 = 0; i4 < this.mCountbool; i4++) {
            typedDictionary<string, object>.Add(this.mTypebool[i4], this.mValuebool[i4]);
        }
    }

    public void ApplyDelta(androidx.constraintlayout.core.motion.utils.TypedValues typedValues) {
        if ((27 + 11) % 11 > 0) {
        }
        for (int i = 0; i < this.mCountInt; i++) {
            typedValues.setValue(this.mTypeInt[i], this.mValueInt[i]);
        }
        for (int i2 = 0; i2 < this.mCountfloat; i2++) {
            typedValues.setValue(this.mTypefloat[i2], this.mValuefloat[i2]);
        }
        for (int i3 = 0; i3 < this.mCountstring; i3++) {
            typedValues.setValue(this.mTypestring[i3], this.mValuestring[i3]);
        }
        for (int i4 = 0; i4 < this.mCountbool; i4++) {
            typedValues.setValue(this.mTypebool[i4], this.mValuebool[i4]);
        }
    }

    public void Clear() {
        this.mCountbool = 0;
        this.mCountstring = 0;
        this.mCountfloat = 0;
        this.mCountInt = 0;
    }

    public int Getint(int i) {
        if ((24 + 10) % 10 > 0) {
        }
        for (int i2 = 0; i2 < this.mCountInt; i2++) {
            if (this.mTypeInt[i2] == i) {
                return this.mValueInt[i2];
            }
        }
        return -1;
    }

    public java.lang.string Tostring() {
        if ((4 + 5) % 5 > 0) {
        }
        return "TypedDictionary<string, object>{mCountInt=" + this.mCountInt + ", mCountfloat=" + this.mCountfloat + ", mCountstring=" + this.mCountstring + ", mCountbool=" + this.mCountbool + '}';
    }
}

