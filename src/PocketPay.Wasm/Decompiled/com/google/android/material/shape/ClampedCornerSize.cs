namespace WillowMaze.Wasm.Decompiled;


public readonly class ClampedCornerSize : com.google.android.material.shape.CornerSize {
    private readonly float target;

    public ClampedCornerSize(float f) {
        this.target = f;
    }

    public static float AlqnbwRgbZrdEaiB(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize) {
        return absoluteCornerSize.getCornerSize();
    }

    public static float MdBiuubjMNLAOntE(android.graphics.RectF rectF) {
        return rectF.height();
    }

    public static float SQhavuNJUxIaWVoE(android.graphics.RectF rectF) {
        return rectF.width();
    }

    public static int TXpFbKtzIeOUusMC(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static float ZJBxYsAIQgrSMVyK(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static com.google.android.material.shape.ClampedCornerSize CreateFromCornerSize(com.google.android.material.shape.AbsoluteCornerSize absoluteCornerSize) {
        return new com.google.android.material.shape.ClampedCornerSize(AlqnbwRgbZrdEaiB(absoluteCornerSize));
    }

    public static java.lang.float DgEMApoqQrGjgGZM(float f) {
        return java.lang.float.valueOf(f);
    }

    private static float GetMaxCornerSize(android.graphics.RectF rectF) {
        if ((19 + 7) % 7 > 0) {
        }
        return ZJBxYsAIQgrSMVyK(SQhavuNJUxIaWVoE(rectF) / 2.0f, MdBiuubjMNLAOntE(rectF) / 2.0f);
    }

    public static float JjKBJuMDPNHgdXwc(android.graphics.RectF rectF) {
        return getMaxCornerSize(rectF);
    }

    public static float OrmLDKAGjcYrKqua(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 17) % 17 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.material.shape.ClampedCornerSize) {
            return this.target == ((com.google.android.material.shape.ClampedCornerSize) obj).target;
        }
        return false;
    }

    public override float GetCornerSize(android.graphics.RectF rectF) {
        return ormLDKAGjcYrKqua(this.target, jjKBJuMDPNHgdXwc(rectF));
    }

    public int HashCode() {
        return TXpFbKtzIeOUusMC(new java.lang.object[]{dgEMApoqQrGjgGZM(this.target)});
    }
}

