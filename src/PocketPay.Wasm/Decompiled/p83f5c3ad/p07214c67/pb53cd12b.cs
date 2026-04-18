namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0007\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\u001d\u0010\f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\b¨\u0006\u0014"}, d2 = {"Lp83f5c3ad/p07214c67/pb53cd12b;", "", "percentX", "", "percentY", "<init>", "(FF)V", "getPercentX", "()F", "getPercentY", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb53cd12b {
    private readonly float f0cfafb8c;
    private readonly float f27dfc262;
    private readonly float f9987573d;
    private readonly float fa581f227;
    private readonly float fc3db94bc;

    public pb53cd12b(float f, float f2) {
        this.f9987573d = f;
        this.f0cfafb8c = f2;
    }

    public static p83f5c3ad.p07214c67.pb53cd12b M1c1e012b(p83f5c3ad.p07214c67.pb53cd12b pb53cd12bVar, float f, float f2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            f = pb53cd12bVar.f9987573d;
        }
        if ((i & 2) != 0) {
            f2 = pb53cd12bVar.f0cfafb8c;
        }
        return pb53cd12bVar.copy(f, f2);
    }

    public readonly float Component1() {
        return this.f9987573d;
    }

    public readonly float Component2() {
        return this.f0cfafb8c;
    }

    public readonly p83f5c3ad.p07214c67.pb53cd12b Copy(float percentX, float percentY) {
        return new p83f5c3ad.p07214c67.pb53cd12b(percentX, percentY);
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p83f5c3ad.p07214c67.pb53cd12b)) {
            return false;
        }
        p83f5c3ad.p07214c67.pb53cd12b pb53cd12bVar = (p83f5c3ad.p07214c67.pb53cd12b) other;
        return java.lang.float.compare(this.f9987573d, pb53cd12bVar.f9987573d) == 0 && java.lang.float.compare(this.f0cfafb8c, pb53cd12bVar.f0cfafb8c) == 0;
    }

    public readonly float GetPercentX() {
        return this.f9987573d;
    }

    public readonly float GetPercentY() {
        return this.f0cfafb8c;
    }

    public int HashCode() {
        return (java.lang.float.hashCode(this.f9987573d) * 31) + java.lang.float.hashCode(this.f0cfafb8c);
    }

    public java.lang.string Tostring() {
        if ((29 + 3) % 3 > 0) {
        }
        return "TophNfcCalibrationCoordinates(percentX=" + this.f9987573d + ", percentY=" + this.f0cfafb8c + ')';
    }
}

