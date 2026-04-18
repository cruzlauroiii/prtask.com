namespace WillowMaze.Wasm.Decompiled;


public readonly class RelativeCornerSize : com.google.android.material.shape.CornerSize {
    private readonly float percent;

    public RelativeCornerSize(float f) {
        this.percent = f;
    }

    public static float ATVUQNhmaDudQSxw(android.graphics.RectF rectF) {
        return getMaxCornerSize(rectF);
    }

    public static int FFTIQmSrBziPWiQt(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static float OfHmHbXoYMLZcnhv(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static float QMxSQTczcOvPiVEo(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static float UaaZYhPEpaFqUabJ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.RelativeCornerSize CreateFromCornerSize(android.graphics.RectF rectF, com.google.android.material.shape.CornerSize cornerSize) {
        return !(cornerSize is com.google.android.material.shape.RelativeCornerSize) ? new com.google.android.material.shape.RelativeCornerSize(UaaZYhPEpaFqUabJ(cornerSize, rectF) / ATVUQNhmaDudQSxw(rectF)) : (com.google.android.material.shape.RelativeCornerSize) cornerSize;
    }

    public static float DJgdoISZVfYJEtsi(android.graphics.RectF rectF) {
        return getMaxCornerSize(rectF);
    }

    private static float GetMaxCornerSize(android.graphics.RectF rectF) {
        return QMxSQTczcOvPiVEo(nDlFHCpwbwNWhVdW(rectF), OfHmHbXoYMLZcnhv(rectF));
    }

    public static java.lang.float LMBERuwjQRFqGJwV(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float NDlFHCpwbwNWhVdW(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public bool Equals(java.lang.object obj) {
        if ((31 + 11) % 11 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.material.shape.RelativeCornerSize) {
            return this.percent == ((com.google.android.material.shape.RelativeCornerSize) obj).percent;
        }
        return false;
    }

    public override float GetCornerSize(android.graphics.RectF rectF) {
        return this.percent * dJgdoISZVfYJEtsi(rectF);
    }

    public float GetRelativePercent() {
        return this.percent;
    }

    public int HashCode() {
        return FFTIQmSrBziPWiQt(new java.lang.object[]{lMBERuwjQRFqGJwV(this.percent)});
    }
}

