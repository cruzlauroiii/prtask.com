namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\fHÖ\u0003J\t\u0010\r\u001a\u00020\u000eHÖ\u0001J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u0011"}, d2 = {"Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p67d2f674;", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pee97be03;", "screen", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "(Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;)V", "getScreen", "()Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p2fc3359e;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class p67d2f674 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03 {
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f301bc3cb;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f599eba19;
    private readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e f7bc65009;

    public p67d2f674(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        vmmCOJMbxAAUagpW(p2fc3359eVar, "screen");
        this.f599eba19 = p2fc3359eVar;
    }

    public static int HEDyEVwpUwprgWtP(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string SAzVJnwXKNYqkfaT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674 BbGGpEKaYmaSfsya(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674 p67d2f674Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar) {
        return p67d2f674Var.copy(p2fc3359eVar);
    }

    public static bool IHtKzBfGMPgrMnWL(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674 M1c1e012b(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674 p67d2f674Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e p2fc3359eVar, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p2fc3359eVar = p67d2f674Var.f599eba19;
        }
        return bbGGpEKaYmaSfsya(p67d2f674Var, p2fc3359eVar);
    }

    public static java.lang.stringBuilder PvaMnirpnAbKIino(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ReuAGDJGzFGwBFEW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VmmCOJMbxAAUagpW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder WANFfrgLPVcEiNWF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e Component1() {
        return this.f599eba19;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674 Copy(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e screen) {
        reuAGDJGzFGwBFEW(screen, "screen");
        return new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674(screen);
    }

    public bool Equals(java.lang.object other) {
        if ((21 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674) {
            return iHtKzBfGMPgrMnWL(this.f599eba19, ((p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p67d2f674) other).f599eba19);
        }
        return false;
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p2fc3359e GetScreen() {
        return this.f599eba19;
    }

    public int HashCode() {
        return HEDyEVwpUwprgWtP(this.f599eba19);
    }

    public java.lang.string Tostring() {
        if ((27 + 16) % 16 > 0) {
        }
        return SAzVJnwXKNYqkfaT(pvaMnirpnAbKIino(wANFfrgLPVcEiNWF(new java.lang.stringBuilder("Forward(screen="), this.f599eba19), ')'));
    }
}

