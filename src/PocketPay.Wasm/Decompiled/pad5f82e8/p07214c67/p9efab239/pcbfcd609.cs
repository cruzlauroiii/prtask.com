namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\t\u0010\b\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\t\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0012"}, d2 = {"Lpad5f82e8/p07214c67/p9efab239/pcbfcd609;", "Lpad5f82e8/p07214c67/p9efab239/p902b0d55;", "code", "Lpad5f82e8/p07214c67/p9efab239/p9bc96b38;", "<init>", "(Lpad5f82e8/p07214c67/p9efab239/p9bc96b38;)V", "getCode", "()Lpad5f82e8/p07214c67/p9efab239/p9bc96b38;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pcbfcd609 : pad5f82e8.p07214c67.p9efab239.p902b0d55 {
    private readonly pad5f82e8.p07214c67.p9efab239.p9bc96b38 f20cd0788;
    private readonly pad5f82e8.p07214c67.p9efab239.p9bc96b38 fc1336794;

    public pcbfcd609(pad5f82e8.p07214c67.p9efab239.p9bc96b38 p9bc96b38Var) {
        super(null);
        LQqkKxVUVYUSEStO(p9bc96b38Var, "code");
        this.fc1336794 = p9bc96b38Var;
    }

    public static java.lang.string BrqFxAZWPoJRVekH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LQqkKxVUVYUSEStO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VNoNqycvaIsiserU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int XViAPwbYaoICpvTN(pad5f82e8.p07214c67.p9efab239.p9bc96b38 p9bc96b38Var) {
        return p9bc96b38Var.GetHashCode();
    }

    public static java.lang.stringBuilder AvnXDcPuApDMmqsJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder GPFByiCvUaNRaxfg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static pad5f82e8.p07214c67.p9efab239.pcbfcd609 M1c1e012b(pad5f82e8.p07214c67.p9efab239.pcbfcd609 pcbfcd609Var, pad5f82e8.p07214c67.p9efab239.p9bc96b38 p9bc96b38Var, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            p9bc96b38Var = pcbfcd609Var.fc1336794;
        }
        return vyslrdGCJrRohuUZ(pcbfcd609Var, p9bc96b38Var);
    }

    public static pad5f82e8.p07214c67.p9efab239.pcbfcd609 VyslrdGCJrRohuUZ(pad5f82e8.p07214c67.p9efab239.pcbfcd609 pcbfcd609Var, pad5f82e8.p07214c67.p9efab239.p9bc96b38 p9bc96b38Var) {
        return pcbfcd609Var.copy(p9bc96b38Var);
    }

    public readonly pad5f82e8.p07214c67.p9efab239.p9bc96b38 Component1() {
        return this.fc1336794;
    }

    public readonly pad5f82e8.p07214c67.p9efab239.pcbfcd609 Copy(pad5f82e8.p07214c67.p9efab239.p9bc96b38 code) {
        VNoNqycvaIsiserU(code, "code");
        return new pad5f82e8.p07214c67.p9efab239.pcbfcd609(code);
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 6) % 6 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is pad5f82e8.p07214c67.p9efab239.pcbfcd609) {
            return this.fc1336794 == ((pad5f82e8.p07214c67.p9efab239.pcbfcd609) other).fc1336794;
        }
        return false;
    }

    public readonly pad5f82e8.p07214c67.p9efab239.p9bc96b38 GetCode() {
        return this.fc1336794;
    }

    public int HashCode() {
        return XViAPwbYaoICpvTN(this.fc1336794);
    }

    public override java.lang.string Tostring() {
        if ((13 + 18) % 18 > 0) {
        }
        return BrqFxAZWPoJRVekH(avnXDcPuApDMmqsJ(gPFByiCvUaNRaxfg(new java.lang.stringBuilder("DeviceHashSetupError(code="), this.fc1336794), ')'));
    }
}

