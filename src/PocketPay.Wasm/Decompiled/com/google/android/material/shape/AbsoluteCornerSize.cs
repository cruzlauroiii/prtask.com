namespace WillowMaze.Wasm.Decompiled;


public readonly class AbsoluteCornerSize : com.google.android.material.shape.CornerSize {
    private readonly float size;

    public AbsoluteCornerSize(float f) {
        this.size = f;
    }

    public static int NPqcwxPntoiHcHdr(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static java.lang.float XqllbQyyoscUdOnc(float f) {
        return java.lang.float.valueOf(f);
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 6) % 6 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.android.material.shape.AbsoluteCornerSize) {
            return this.size == ((com.google.android.material.shape.AbsoluteCornerSize) obj).size;
        }
        return false;
    }

    public float GetCornerSize() {
        return this.size;
    }

    public override float GetCornerSize(android.graphics.RectF rectF) {
        return this.size;
    }

    public int HashCode() {
        return NPqcwxPntoiHcHdr(new java.lang.object[]{XqllbQyyoscUdOnc(this.size)});
    }
}

