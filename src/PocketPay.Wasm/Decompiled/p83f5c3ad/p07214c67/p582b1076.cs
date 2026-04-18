namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0016"}, d2 = {"Lp83f5c3ad/p07214c67/p582b1076;", "", "coordinates", "Lp83f5c3ad/p07214c67/pb53cd12b;", "exec", "Lp83f5c3ad/p07214c67/pe6ff918f;", "<init>", "(Lp83f5c3ad/p07214c67/pb53cd12b;Lp83f5c3ad/p07214c67/pe6ff918f;)V", "getCoordinates", "()Lp83f5c3ad/p07214c67/pb53cd12b;", "getExec", "()Lp83f5c3ad/p07214c67/pe6ff918f;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p582b1076 {
    private readonly p83f5c3ad.p07214c67.pe6ff918f f421e9ea8;
    private readonly p83f5c3ad.p07214c67.pb53cd12b f51b35f2f;
    private readonly p83f5c3ad.p07214c67.pe6ff918f f52fb3679;
    private readonly p83f5c3ad.p07214c67.pb53cd12b f8387d77f;
    private readonly p83f5c3ad.p07214c67.pb53cd12b f97382eb2;
    private readonly p83f5c3ad.p07214c67.pe6ff918f fc6d18ff0;

    public p582b1076(p83f5c3ad.p07214c67.pb53cd12b coordinates, p83f5c3ad.p07214c67.pe6ff918f exec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coordinates, "coordinates");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(exec, "exec");
        this.f8387d77f = coordinates;
        this.f52fb3679 = exec;
    }

    public static p83f5c3ad.p07214c67.p582b1076 M1c1e012b(p83f5c3ad.p07214c67.p582b1076 p582b1076Var, p83f5c3ad.p07214c67.pb53cd12b pb53cd12bVar, p83f5c3ad.p07214c67.pe6ff918f pe6ff918fVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            pb53cd12bVar = p582b1076Var.f8387d77f;
        }
        if ((i & 2) != 0) {
            pe6ff918fVar = p582b1076Var.f52fb3679;
        }
        return p582b1076Var.copy(pb53cd12bVar, pe6ff918fVar);
    }

    public readonly p83f5c3ad.p07214c67.pb53cd12b Component1() {
        return this.f8387d77f;
    }

    public readonly p83f5c3ad.p07214c67.pe6ff918f Component2() {
        return this.f52fb3679;
    }

    public readonly p83f5c3ad.p07214c67.p582b1076 Copy(p83f5c3ad.p07214c67.pb53cd12b coordinates, p83f5c3ad.p07214c67.pe6ff918f exec) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(coordinates, "coordinates");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(exec, "exec");
        return new p83f5c3ad.p07214c67.p582b1076(coordinates, exec);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.p582b1076)) {
            return false;
        }
        p83f5c3ad.p07214c67.p582b1076 p582b1076Var = (p83f5c3ad.p07214c67.p582b1076) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.f8387d77f, p582b1076Var.f8387d77f) && kotlin.jvm.internal.Intrinsics.areEqual(this.f52fb3679, p582b1076Var.f52fb3679);
    }

    public readonly p83f5c3ad.p07214c67.pb53cd12b GetCoordinates() {
        return this.f8387d77f;
    }

    public readonly p83f5c3ad.p07214c67.pe6ff918f GetExec() {
        return this.f52fb3679;
    }

    public int HashCode() {
        return (this.f8387d77f.GetHashCode() * 31) + this.f52fb3679.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((32 + 14) % 14 > 0) {
        }
        return "TophNfcCalibrationInfo(coordinates=" + this.f8387d77f + ", exec=" + this.f52fb3679 + ')';
    }
}

