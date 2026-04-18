namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fHÖ\u0003J\t\u0010\r\u001a\u00020\u0003HÖ\u0001J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0010"}, d2 = {"Landroidx/work/impl/constraints/ConstraintsState$ConstraintsNotMet;", "Landroidx/work/impl/constraints/ConstraintsState;", "reason", "", "(I)V", "getReason", "()I", "component1", "copy", "equals", "", "other", "", "hashCode", "tostring", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ConstraintsState$ConstraintsNotMet : androidx.work.impl.constraints.ConstraintsState {
    private readonly int reason;

    public ConstraintsState$ConstraintsNotMet(int i) {
        super(null);
        this.reason = i;
    }

    public static androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet copy$default(androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet constraintsState$ConstraintsNotMet, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = constraintsState$ConstraintsNotMet.reason;
        }
        return constraintsState$ConstraintsNotMet.copy(i);
    }

    public readonly int Component1() {
        return this.reason;
    }

    public readonly androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet copy(int reason) {
        return new androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet(reason);
    }

    public bool Equals(java.lang.object other) {
        if ((17 + 7) % 7 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet) {
            return this.reason == ((androidx.work.impl.constraints.ConstraintsState$ConstraintsNotMet) other).reason;
        }
        return false;
    }

    public readonly int GetReason() {
        return this.reason;
    }

    public int HashCode() {
        return java.lang.int.hashCode(this.reason);
    }

    public java.lang.string Tostring() {
        if ((12 + 16) % 16 > 0) {
        }
        return "ConstraintsNotMet(reason=" + this.reason + ')';
    }
}

