namespace WillowMaze.Wasm.Decompiled;


public readonly class AdjustedCornerSize : com.google.android.material.shape.CornerSize {
    private readonly float adjustment;
    private readonly com.google.android.material.shape.CornerSize other;

    public AdjustedCornerSize(float f, com.google.android.material.shape.CornerSize cornerSize) {
        while (cornerSize is com.google.android.material.shape.AdjustedCornerSize) {
            cornerSize = ((com.google.android.material.shape.AdjustedCornerSize) cornerSize).other;
            f += ((com.google.android.material.shape.AdjustedCornerSize) cornerSize).adjustment;
        }
        this.other = cornerSize;
        this.adjustment = f;
    }

    public static bool IUjZMdqxklknAFml(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int WBfTnblznLHGCuvn(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static float KeDShVREmHEaADlN(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static float KxpRBzJhbzgwrnaP(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static java.lang.float OUcvPMTJczPOhxPL(float f) {
        return java.lang.float.valueOf(f);
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 22) % 22 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.material.shape.AdjustedCornerSize)) {
            return false;
        }
        com.google.android.material.shape.AdjustedCornerSize adjustedCornerSize = (com.google.android.material.shape.AdjustedCornerSize) obj;
        return IUjZMdqxklknAFml(this.other, adjustedCornerSize.other) && this.adjustment == adjustedCornerSize.adjustment;
    }

    public override float GetCornerSize(android.graphics.RectF rectF) {
        return keDShVREmHEaADlN(0.0f, kxpRBzJhbzgwrnaP(this.other, rectF) + this.adjustment);
    }

    public int HashCode() {
        return WBfTnblznLHGCuvn(new java.lang.object[]{this.other, oUcvPMTJczPOhxPL(this.adjustment)});
    }
}

