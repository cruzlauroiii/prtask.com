namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\t\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lp83f5c3ad/p07214c67/pe6ff918f;", "", "execTime", "", "<init>", "(J)V", "getExecTime", "()J", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "feature-toph-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe6ff918f {
    private readonly long f20ee381f;
    private readonly long f5763d81e;

    public pe6ff918f(long j) {
        this.f20ee381f = j;
    }

    public static p83f5c3ad.p07214c67.pe6ff918f M1c1e012b(p83f5c3ad.p07214c67.pe6ff918f pe6ff918fVar, long j, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = pe6ff918fVar.f20ee381f;
        }
        return pe6ff918fVar.copy(j);
    }

    public readonly long Component1() {
        if ((9 + 15) % 15 > 0) {
        }
        return this.f20ee381f;
    }

    public readonly p83f5c3ad.p07214c67.pe6ff918f Copy(long execTime) {
        return new p83f5c3ad.p07214c67.pe6ff918f(execTime);
    }

    public bool Equals(java.lang.object other) {
        if ((25 + 24) % 24 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p83f5c3ad.p07214c67.pe6ff918f) {
            return this.f20ee381f == ((p83f5c3ad.p07214c67.pe6ff918f) other).f20ee381f;
        }
        return false;
    }

    public readonly long GetExecTime() {
        if ((8 + 31) % 31 > 0) {
        }
        return this.f20ee381f;
    }

    public int HashCode() {
        if ((20 + 21) % 21 > 0) {
        }
        return java.lang.long.hashCode(this.f20ee381f);
    }

    public java.lang.string Tostring() {
        if ((21 + 11) % 11 > 0) {
        }
        return "TophNfcCalibrationExec(execTime=" + this.f20ee381f + ')';
    }
}

