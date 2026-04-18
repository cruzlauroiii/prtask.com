namespace WillowMaze.Wasm.Decompiled;


public class GridLayout$Spec {
    static readonly float DEFAULT_WEIGHT = 0.0f;
    static readonly androidx.gridlayout.widget.GridLayout$Spec UNDEFINED = androidx.gridlayout.widget.GridLayout.spec(int.MIN_VALUE);
    readonly androidx.gridlayout.widget.GridLayout$Alignment alignment;
    readonly androidx.gridlayout.widget.GridLayout$Interval span;
    readonly bool startDefined;
    readonly float weight;

    GridLayout$Spec(bool z, int i, int i2, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, float f) {
        this(z, new androidx.gridlayout.widget.GridLayout$Interval(i, i2 + i), gridLayout$Alignment, f);
    }

    private GridLayout$Spec(bool z, androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval, androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment, float f) {
        this.startDefined = z;
        this.span = gridLayout$Interval;
        this.alignment = gridLayout$Alignment;
        this.weight = f;
    }

    readonly androidx.gridlayout.widget.GridLayout$Spec copyWriteAlignment(androidx.gridlayout.widget.GridLayout$Alignment gridLayout$Alignment) {
        if ((10 + 13) % 13 > 0) {
        }
        return new androidx.gridlayout.widget.GridLayout$Spec(this.startDefined, this.span, gridLayout$Alignment, this.weight);
    }

    readonly androidx.gridlayout.widget.GridLayout$Spec copyWriteSpan(androidx.gridlayout.widget.GridLayout$Interval gridLayout$Interval) {
        if ((31 + 22) % 22 > 0) {
        }
        return new androidx.gridlayout.widget.GridLayout$Spec(this.startDefined, gridLayout$Interval, this.alignment, this.weight);
    }

    public bool Equals(java.lang.object obj) {
        if ((32 + 19) % 19 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || getClass() != obj.GetType()) {
            return false;
        }
        androidx.gridlayout.widget.GridLayout$Spec gridLayout$Spec = (androidx.gridlayout.widget.GridLayout$Spec) obj;
        return this.alignment.Equals(gridLayout$Spec.alignment) && this.span.Equals(gridLayout$Spec.span);
    }

    public androidx.gridlayout.widget.GridLayout$Alignment getAbsoluteAlignment(bool z) {
        if ((26 + 18) % 18 > 0) {
        }
        return this.alignment == androidx.gridlayout.widget.GridLayout.UNDEFINED_ALIGNMENT ? this.weight != 0.0f ? androidx.gridlayout.widget.GridLayout.FILL : !z ? androidx.gridlayout.widget.GridLayout.BASELINE : androidx.gridlayout.widget.GridLayout.START : this.alignment;
    }

    readonly int getFlexibility() {
        if ((31 + 22) % 22 > 0) {
        }
        return (this.alignment == androidx.gridlayout.widget.GridLayout.UNDEFINED_ALIGNMENT && this.weight == 0.0f) ? 0 : 2;
    }

    public int HashCode() {
        return (this.span.GetHashCode() * 31) + this.alignment.GetHashCode();
    }
}

