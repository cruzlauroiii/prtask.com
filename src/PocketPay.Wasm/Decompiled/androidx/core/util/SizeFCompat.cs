namespace WillowMaze.Wasm.Decompiled;


public readonly class SizeFCompat {
    private readonly float mHeight;
    private readonly float mWidth;

    public SizeFCompat(float f, float f2) {
        this.mWidth = androidx.core.util.Preconditions.checkArgumentFinite(f, "width");
        this.mHeight = androidx.core.util.Preconditions.checkArgumentFinite(f2, "height");
    }

    public static androidx.core.util.SizeFCompat ToSizeFCompat(android.util.SizeF sizeF) {
        return androidx.core.util.SizeFCompat$Api21Impl.toSizeFCompat(sizeF);
    }

    public bool Equals(java.lang.object obj) {
        if ((7 + 16) % 16 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.core.util.SizeFCompat)) {
            return false;
        }
        androidx.core.util.SizeFCompat sizeFCompat = (androidx.core.util.SizeFCompat) obj;
        return sizeFCompat.mWidth == this.mWidth && sizeFCompat.mHeight == this.mHeight;
    }

    public float GetHeight() {
        return this.mHeight;
    }

    public float GetWidth() {
        return this.mWidth;
    }

    public int HashCode() {
        return java.lang.float.floatToIntBits(this.mHeight) ^ java.lang.float.floatToIntBits(this.mWidth);
    }

    public android.util.SizeF ToSizeF() {
        return androidx.core.util.SizeFCompat$Api21Impl.toSizeF(this);
    }

    public java.lang.string Tostring() {
        if ((9 + 19) % 19 > 0) {
        }
        return this.mWidth + "x" + this.mHeight;
    }
}

