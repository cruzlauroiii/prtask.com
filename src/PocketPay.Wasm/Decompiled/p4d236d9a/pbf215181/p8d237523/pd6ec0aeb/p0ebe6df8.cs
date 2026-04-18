namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fHÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0011"}, d2 = {"Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p0ebe6df8;", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pee97be03;", "screen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;)V", "getScreen", "()Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p0ebe6df8 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f4d3314c0;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f599eba19;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f75e0e624;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e faf7c3742;

    public p0ebe6df8(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        DFfiFApJkUXVVSCm(p2fc3359eVar, "screen");
        this.f599eba19 = p2fc3359eVar;
    }

    public static void DFfiFApJkUXVVSCm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string HOcrWPzSFfEGpPCI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OWnrCoUeCosynVtQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder SJiwCmbKAwLfqVAu(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8 ZSBlBkgZSMnNrJSC(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8 p0ebe6df8Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        return p0ebe6df8Var.copy(p2fc3359eVar);
    }

    public static java.lang.stringBuilder JdOphETnmDiWiaWO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool KsVukXuTLlxwNqsU(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8 M1c1e012b(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8 p0ebe6df8Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p2fc3359eVar = p0ebe6df8Var.f599eba19;
        }
        return ZSBlBkgZSMnNrJSC(p0ebe6df8Var, p2fc3359eVar);
    }

    public static int ObNJHSDgEehkcXsR(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e Component1() {
        return this.f599eba19;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8 Copy(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        OWnrCoUeCosynVtQ(screen, "screen");
        return new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8(screen);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8) {
            return ksVukXuTLlxwNqsU(this.f599eba19, ((p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p0ebe6df8) other).f599eba19);
        }
        return false;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetScreen() {
        return this.f599eba19;
    }

    public int HashCode() {
        return obNJHSDgEehkcXsR(this.f599eba19);
    }

    public java.lang.string Tostring() {
        if ((5 + 16) % 16 > 0) {
        }
        return HOcrWPzSFfEGpPCI(jdOphETnmDiWiaWO(SJiwCmbKAwLfqVAu(new java.lang.stringBuilder("Replace(screen="), this.f599eba19), ')'));
    }
}

