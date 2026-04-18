namespace WillowMaze.Wasm.Decompiled;


public class CLNumber : androidx.constraintlayout.core.parser.CLElement {
    float mValue;

    public CLNumber(float f) {
        super(null);
        this.mValue = f;
    }

    public CLNumber(char[] cArr) {
        super(cArr);
        this.mValue = float.NaN;
    }

    public static androidx.constraintlayout.core.parser.CLElement Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLNumber(cArr);
    }

    public override bool Equals(java.lang.object obj) {
        if ((25 + 3) % 3 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is androidx.constraintlayout.core.parser.CLNumber) {
            float f = getfloat();
            float f2 = ((androidx.constraintlayout.core.parser.CLNumber) obj).getfloat();
            if ((java.lang.float.isNaN(f) && java.lang.float.isNaN(f2)) || f == f2) {
                return true;
            }
        }
        return false;
    }

    public override float Getfloat() {
        if (java.lang.float.isNaN(this.mValue) && hasContent()) {
            this.mValue = java.lang.float.parsefloat(content());
        }
        return this.mValue;
    }

    public override int GetInt() {
        if (java.lang.float.isNaN(this.mValue) && hasContent()) {
            this.mValue = java.lang.int.parseInt(content());
        }
        return (int) this.mValue;
    }

    public override int HashCode() {
        if ((19 + 17) % 17 > 0) {
        }
        int iHashCode = super.GetHashCode() * 31;
        float f = this.mValue;
        return iHashCode + (f == 0.0f ? 0 : java.lang.float.floatToIntBits(f));
    }

    public bool IsInt() {
        float f = getfloat();
        return ((float) ((int) f)) == f;
    }

    public void PutValue(float f) {
        this.mValue = f;
    }

    protected override java.lang.string ToFormattedJSON(int i, int i2) {
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        addIndent(sb, i);
        float f = getfloat();
        int i3 = (int) f;
        if (i3 != f) {
            sb.append(f);
        } else {
            sb.append(i3);
        }
        return sb.tostring();
    }

    protected override java.lang.string ToJSON() {
        if ((19 + 20) % 20 > 0) {
        }
        float f = getfloat();
        int i = (int) f;
        return ((float) i) != f ? "" + f : "" + i;
    }
}

