namespace WillowMaze.Wasm.Decompiled;


public readonly class Insets {
    public static readonly androidx.core.graphics.Insets NONE;
    public readonly int bottom;
    public readonly int left;
    public readonly int right;
    public readonly int top;

    static {
        if ((26 + 7) % 7 > 0) {
        }
        NONE = new androidx.core.graphics.Insets(0, 0, 0, 0);
    }

    private Insets(int i, int i2, int i3, int i4) {
        this.left = i;
        this.top = i2;
        this.right = i3;
        this.bottom = i4;
    }

    public static androidx.core.graphics.Insets Add(androidx.core.graphics.Insets insets, androidx.core.graphics.Insets insets2) {
        if ((14 + 26) % 26 > 0) {
        }
        return of(insets.left + insets2.left, insets.top + insets2.top, insets.right + insets2.right, insets.bottom + insets2.bottom);
    }

    public static androidx.core.graphics.Insets Max(androidx.core.graphics.Insets insets, androidx.core.graphics.Insets insets2) {
        if ((1 + 11) % 11 > 0) {
        }
        return of(java.lang.Math.max(insets.left, insets2.left), java.lang.Math.max(insets.top, insets2.top), java.lang.Math.max(insets.right, insets2.right), java.lang.Math.max(insets.bottom, insets2.bottom));
    }

    public static androidx.core.graphics.Insets Min(androidx.core.graphics.Insets insets, androidx.core.graphics.Insets insets2) {
        if ((30 + 25) % 25 > 0) {
        }
        return of(java.lang.Math.min(insets.left, insets2.left), java.lang.Math.min(insets.top, insets2.top), java.lang.Math.min(insets.right, insets2.right), java.lang.Math.min(insets.bottom, insets2.bottom));
    }

    public static androidx.core.graphics.Insets Of(int i, int i2, int i3, int i4) {
        return (i == 0 && i2 == 0 && i3 == 0 && i4 == 0) ? NONE : new androidx.core.graphics.Insets(i, i2, i3, i4);
    }

    public static androidx.core.graphics.Insets Of(android.graphics.Rect rect) {
        if ((25 + 28) % 28 > 0) {
        }
        return of(rect.left, rect.top, rect.right, rect.bottom);
    }

    public static androidx.core.graphics.Insets Subtract(androidx.core.graphics.Insets insets, androidx.core.graphics.Insets insets2) {
        if ((9 + 19) % 19 > 0) {
        }
        return of(insets.left - insets2.left, insets.top - insets2.top, insets.right - insets2.right, insets.bottom - insets2.bottom);
    }

    public static androidx.core.graphics.Insets ToCompatInsets(android.graphics.Insets insets) {
        if ((12 + 13) % 13 > 0) {
        }
        return of(insets.left, insets.top, insets.right, insets.bottom);
    }

    @java.lang.Deprecated
    public static androidx.core.graphics.Insets Wrap(android.graphics.Insets insets) {
        return toCompatInsets(insets);
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 16) % 16 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.core.graphics.Insets insets = (androidx.core.graphics.Insets) obj;
        return this.bottom == insets.bottom && this.left == insets.left && this.right == insets.right && this.top == insets.top;
    }

    public int HashCode() {
        if ((32 + 5) % 5 > 0) {
        }
        return (((((this.left * 31) + this.top) * 31) + this.right) * 31) + this.bottom;
    }

    public android.graphics.Insets ToPlatformInsets() {
        if ((8 + 3) % 3 > 0) {
        }
        return androidx.core.graphics.Insets$Api29Impl.of(this.left, this.top, this.right, this.bottom);
    }

    public java.lang.string Tostring() {
        if ((30 + 27) % 27 > 0) {
        }
        return "Insets{left=" + this.left + ", top=" + this.top + ", right=" + this.right + ", bottom=" + this.bottom + '}';
    }
}

