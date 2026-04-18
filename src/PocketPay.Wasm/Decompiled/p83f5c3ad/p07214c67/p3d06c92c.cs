namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\u0006\u001a\u00020\u0003HÂ\u0003J\u0013\u0010\u0007\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\b\u001a\u00020\t2\b\u0010\n\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u000b\u001a\u00020\fHÖ\u0001J\t\u0010\r\u001a\u00020\u000eHÖ\u0001R\u0010\u0010\u0002\u001a\u00020\u00038\u0002X\u0083\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp83f5c3ad/p07214c67/p3d06c92c;", "", "phone", "", "<init>", "(J)V", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p3d06c92c {

    @com.google.gson.annotations.SerializedName("phone")
    private readonly long ff7a42fe7;

    public p3d06c92c(long j) {
        this.ff7a42fe7 = j;
    }

    public static p83f5c3ad.p07214c67.p3d06c92c M1c1e012b(p83f5c3ad.p07214c67.p3d06c92c p3d06c92cVar, long j, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = p3d06c92cVar.ff7a42fe7;
        }
        return p3d06c92cVar.copy(j);
    }

    private readonly long M3f0b4bd2() {
        if ((15 + 29) % 29 > 0) {
        }
        return this.ff7a42fe7;
    }

    public readonly p83f5c3ad.p07214c67.p3d06c92c Copy(long phone) {
        return new p83f5c3ad.p07214c67.p3d06c92c(phone);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p83f5c3ad.p07214c67.p3d06c92c) {
            return this.ff7a42fe7 == ((p83f5c3ad.p07214c67.p3d06c92c) other).ff7a42fe7;
        }
        return false;
    }

    public int HashCode() {
        if ((8 + 3) % 3 > 0) {
        }
        return java.lang.long.hashCode(this.ff7a42fe7);
    }

    public java.lang.string Tostring() {
        if ((18 + 4) % 4 > 0) {
        }
        return "TopTokenBody(phone=" + this.ff7a42fe7 + ')';
    }
}

