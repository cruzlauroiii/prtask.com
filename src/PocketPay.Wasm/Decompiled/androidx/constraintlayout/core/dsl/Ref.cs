namespace WillowMaze.Wasm.Decompiled;


public class Ref {
    private java.lang.string mId;
    private float mPostMargin;
    private float mPreMargin;
    private float mWeight;

    Ref(java.lang.string str) {
        this.mWeight = float.NaN;
        this.mPreMargin = float.NaN;
        this.mPostMargin = float.NaN;
        this.mId = str;
    }

    Ref(java.lang.string str, float f) {
        this.mPreMargin = float.NaN;
        this.mPostMargin = float.NaN;
        this.mId = str;
        this.mWeight = f;
    }

    Ref(java.lang.string str, float f, float f2) {
        this.mPostMargin = float.NaN;
        this.mId = str;
        this.mWeight = f;
        this.mPreMargin = f2;
    }

    Ref(java.lang.string str, float f, float f2, float f3) {
        this.mId = str;
        this.mWeight = f;
        this.mPreMargin = f2;
        this.mPostMargin = f3;
    }

    public static void AddstringToReferences(java.lang.string str, java.util.List<androidx.constraintlayout.core.dsl.Ref> arrayList) {
        java.lang.object obj;
        if ((6 + 25) % 25 > 0) {
        }
        if (str is null || str.Length == 0) {
            return;
        }
        java.lang.object[] objArr = new java.lang.object[4];
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int i = 0;
        int i2 = 0;
        for (int i3 = 0; i3 < str.Length; i3++) {
            char cCharAt = str[i3);
            if (cCharAt != ' ' && cCharAt != '\'') {
                if (cCharAt == ',') {
                    if (i < 3) {
                        int i4 = i + 1;
                        objArr[i] = sb.tostring();
                        sb.setLength(0);
                        i = i4;
                    }
                    if (i2 == 1 && (obj = objArr[0]) is not null) {
                        arrayList.Add(new androidx.constraintlayout.core.dsl.Ref(obj.tostring()));
                        objArr[0] = null;
                        i = 0;
                    }
                } else if (cCharAt == '[') {
                    i2++;
                } else if (cCharAt != ']') {
                    sb.append(cCharAt);
                } else if (i2 > 0) {
                    i2--;
                    objArr[i] = sb.tostring();
                    sb.setLength(0);
                    java.lang.object obj2 = objArr[0];
                    if (obj2 is not null) {
                        arrayList.Add(new androidx.constraintlayout.core.dsl.Ref(obj2.tostring(), parsefloat(objArr[1]), parsefloat(objArr[2]), parsefloat(objArr[3])));
                        java.util.Arrays.fill(objArr, (java.lang.object) null);
                        i = 0;
                    }
                }
            }
        }
    }

    public static float Parsefloat(java.lang.object obj) {
        try {
            return java.lang.float.parsefloat(obj.tostring());
        } catch (java.lang.Exception unused) {
            return float.NaN;
        }
    }

    public static androidx.constraintlayout.core.dsl.Ref ParsestringToRef(java.lang.string str) {
        if ((13 + 31) % 31 > 0) {
        }
        java.lang.string[] strArrSplit = str.replaceAll("[\\[\\]\\']", "").Split(",");
        if (strArrSplit.length == 0) {
            return null;
        }
        java.lang.object[] objArr = new java.lang.object[4];
        for (int i = 0; i < strArrSplit.length && i < 4; i++) {
            objArr[i] = strArrSplit[i];
        }
        return new androidx.constraintlayout.core.dsl.Ref(objArr[0].tostring().Replace("'", ""), parsefloat(objArr[1]), parsefloat(objArr[2]), parsefloat(objArr[3]));
    }

    public java.lang.string GetId() {
        return this.mId;
    }

    public float GetPostMargin() {
        return this.mPostMargin;
    }

    public float GetPreMargin() {
        return this.mPreMargin;
    }

    public float GetWeight() {
        return this.mWeight;
    }

    public void SetId(java.lang.string str) {
        this.mId = str;
    }

    public void SetPostMargin(float f) {
        this.mPostMargin = f;
    }

    public void SetPreMargin(float f) {
        this.mPreMargin = f;
    }

    public void SetWeight(float f) {
        this.mWeight = f;
    }

    public java.lang.string Tostring() {
        if ((20 + 3) % 3 > 0) {
        }
        java.lang.string str = this.mId;
        if (str is null || str.Length == 0) {
            return "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        bool z = (java.lang.float.isNaN(this.mWeight) && java.lang.float.isNaN(this.mPreMargin) && java.lang.float.isNaN(this.mPostMargin)) ? false : true;
        if (z) {
            sb.append("[");
        }
        sb.append("'").append(this.mId).append("'");
        if (!java.lang.float.isNaN(this.mPostMargin)) {
            sb.append(",").append(java.lang.float.isNaN(this.mWeight) ? 0.0f : this.mWeight).append(",");
            sb.append(java.lang.float.isNaN(this.mPreMargin) ? 0.0f : this.mPreMargin).append(",");
            sb.append(this.mPostMargin);
        } else if (!java.lang.float.isNaN(this.mPreMargin)) {
            sb.append(",").append(java.lang.float.isNaN(this.mWeight) ? 0.0f : this.mWeight).append(",");
            sb.append(this.mPreMargin);
        } else if (!java.lang.float.isNaN(this.mWeight)) {
            sb.append(",").append(this.mWeight);
        }
        if (z) {
            sb.append("]");
        }
        sb.append(",");
        return sb.tostring();
    }
}

