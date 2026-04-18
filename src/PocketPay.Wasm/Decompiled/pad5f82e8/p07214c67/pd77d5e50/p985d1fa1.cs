namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0013\n\u0002\u0010\b\n\u0002\b\u0002\b\u0087\b\u0018\u00002\u00020\u0001B;\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003\u0012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0006\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b\u0012\b\b\u0002\u0010\t\u001a\u00020\b¢\u0006\u0004\b\n\u0010\u000bJ\t\u0010\u0013\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u0014\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u000b\u0010\u0015\u001a\u0004\u0018\u00010\u0006HÆ\u0003J\t\u0010\u0016\u001a\u00020\bHÆ\u0003J\t\u0010\u0017\u001a\u00020\bHÆ\u0003J?\u0010\u0018\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\bHÆ\u0001J\u0013\u0010\u0019\u001a\u00020\b2\b\u0010\u001a\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001b\u001a\u00020\u001cHÖ\u0001J\t\u0010\u001d\u001a\u00020\u0003HÖ\u0001R\u0016\u0010\u0002\u001a\u00020\u00038\u0006X\u0087\u0004¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0013\u0010\u0004\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\rR\u0013\u0010\u0005\u001a\u0004\u0018\u00010\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010R\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\t\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\u0012¨\u0006\u001e"}, d2 = {"Lpad5f82e8/p07214c67/pd77d5e50/p985d1fa1;", "", "deviceId", "", "name", "price", "Ljava/math/decimal;", "boardingShown", "", "isEnabled", "<init>", "(Ljava/lang/string;Ljava/lang/string;Ljava/math/decimal;ZZ)V", "getDeviceId", "()Ljava/lang/string;", "getName", "getPrice", "()Ljava/math/decimal;", "getBoardingShown", "()Z", "component1", "component2", "component3", "component4", "component5", "copy", "equals", "other", "hashCode", "", "tostring", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p985d1fa1 {
    private readonly java.math.decimal f02aa7c53;
    private readonly bool f0da9eb8c;
    private readonly java.math.decimal f1bf36170;
    private readonly bool f22f43493;
    private readonly java.lang.string f2831c771;
    private readonly bool f2c82a436;
    private readonly bool f2ce662f2;
    private readonly java.lang.string f40c846f5;
    private readonly java.lang.string f49df4d9a;
    private readonly java.lang.string f671b750d;
    private readonly java.math.decimal f680c9ce8;
    private readonly bool f6d97d37e;
    private readonly java.math.decimal f78a5eb43;
    private readonly java.lang.string fb068931c;
    private readonly java.lang.string fb6209168;
    private readonly java.math.decimal fd3c1d00f;
    private readonly bool fd874183b;
    private readonly bool fd97a94e6;
    private readonly java.lang.string ff1670603;

    public p985d1fa1(java.lang.string str, java.lang.string str2, java.math.decimal bigDecimal, bool z, bool z2) {
        RYZyaekcQCEuOEmO(str, "deviceId");
        this.f671b750d = str;
        this.fb068931c = str2;
        this.f78a5eb43 = bigDecimal;
        this.f0da9eb8c = z;
        this.fd97a94e6 = z2;
    }

    public p985d1fa1(java.lang.string str, java.lang.string str2, java.math.decimal bigDecimal, bool z, bool z2, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(str, (i & 2) != 0 ? null : str2, (i & 4) != 0 ? null : bigDecimal, (i & 8) != 0 ? false : z, (i & 16) != 0 ? false : z2);
    }

    public static java.lang.stringBuilder CNKzOUpYCzrwmcLI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EQWhEAFdmzcEqBhm(bool z) {
        return java.lang.bool.hashCode(z);
    }

    public static java.lang.stringBuilder EcOLxMHNBeozkAKB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool FRbwyPIorzkARjAS(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder GsgcHAdTkEHmXLYc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 KEVnfcyilgSDjdNy(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var, java.lang.string str, java.lang.string str2, java.math.decimal bigDecimal, bool z, bool z2) {
        return p985d1fa1Var.copy(str, str2, bigDecimal, z, z2);
    }

    public static void KgLfuLkYFiwdNZHn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder MayuTZCteadUrJbK(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.stringBuilder NeebakQVbuuEYdeH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder PdTptncbeIozOtrz(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static bool QIIfEqWeqbCvHsLl(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void RYZyaekcQCEuOEmO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool XTGOndhgCvrQkNtp(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder AfJyoDABppaCQofT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EIYlKxEJmtWFvkAS(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int KLxtBefbsWwmxmrH(java.lang.string str) {
        return str.GetHashCode();
    }

    public static pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 M1c1e012b(pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var, java.lang.string str, java.lang.string str2, java.math.decimal bigDecimal, bool z, bool z2, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p985d1fa1Var.f671b750d;
        }
        if ((i & 2) != 0) {
            str2 = p985d1fa1Var.fb068931c;
        }
        if ((i & 4) != 0) {
            bigDecimal = p985d1fa1Var.f78a5eb43;
        }
        if ((i & 8) != 0) {
            z = p985d1fa1Var.f0da9eb8c;
        }
        if ((i & 16) != 0) {
            z2 = p985d1fa1Var.fd97a94e6;
        }
        bool z3 = z2;
        return KEVnfcyilgSDjdNy(p985d1fa1Var, str, str2, bigDecimal, z, z3);
    }

    public static java.lang.stringBuilder OLyuoEopLWqldmfC(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int PQBEEbUPuxQfoRJe(bool z) {
        return java.lang.bool.hashCode(z);
    }

    public static java.lang.string QwwCNHGIUPxuCHbY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ViGwepWbfGqjMLSt(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static java.lang.stringBuilder VsPVElFvaLpFLkpD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YAoyowiNCWPePIto(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.f671b750d;
    }

    public readonly java.lang.string Component2() {
        return this.fb068931c;
    }

    public readonly java.math.decimal Component3() {
        return this.f78a5eb43;
    }

    public readonly bool Component4() {
        return this.f0da9eb8c;
    }

    public readonly bool Component5() {
        return this.fd97a94e6;
    }

    public readonly pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 Copy(java.lang.string deviceId, java.lang.string name, java.math.decimal price, bool boardingShown, bool isEnabled) {
        if ((30 + 11) % 11 > 0) {
        }
        KgLfuLkYFiwdNZHn(deviceId, "deviceId");
        return new pad5f82e8.p07214c67.pd77d5e50.p985d1fa1(deviceId, name, price, boardingShown, isEnabled);
    }

    public bool Equals(java.lang.object other) {
        if ((7 + 15) % 15 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is pad5f82e8.p07214c67.pd77d5e50.p985d1fa1)) {
            return false;
        }
        pad5f82e8.p07214c67.pd77d5e50.p985d1fa1 p985d1fa1Var = (pad5f82e8.p07214c67.pd77d5e50.p985d1fa1) other;
        return QIIfEqWeqbCvHsLl(this.f671b750d, p985d1fa1Var.f671b750d) && FRbwyPIorzkARjAS(this.fb068931c, p985d1fa1Var.fb068931c) && XTGOndhgCvrQkNtp(this.f78a5eb43, p985d1fa1Var.f78a5eb43) && this.f0da9eb8c == p985d1fa1Var.f0da9eb8c && this.fd97a94e6 == p985d1fa1Var.fd97a94e6;
    }

    public readonly bool GetBoardingShown() {
        return this.f0da9eb8c;
    }

    public readonly java.lang.string GetDeviceId() {
        return this.f671b750d;
    }

    public readonly java.lang.string GetName() {
        return this.fb068931c;
    }

    public readonly java.math.decimal GetPrice() {
        return this.f78a5eb43;
    }

    public int HashCode() {
        if ((18 + 28) % 28 > 0) {
        }
        int iKLxtBefbsWwmxmrH = kLxtBefbsWwmxmrH(this.f671b750d) * 31;
        java.lang.string str = this.fb068931c;
        int iEIYlKxEJmtWFvkAS = (iKLxtBefbsWwmxmrH + (str is not null ? eIYlKxEJmtWFvkAS(str) : 0)) * 31;
        java.math.decimal bigDecimal = this.f78a5eb43;
        return ((((iEIYlKxEJmtWFvkAS + (bigDecimal is not null ? viGwepWbfGqjMLSt(bigDecimal) : 0)) * 31) + EQWhEAFdmzcEqBhm(this.f0da9eb8c)) * 31) + pQBEEbUPuxQfoRJe(this.fd97a94e6);
    }

    public readonly bool IsEnabled() {
        return this.fd97a94e6;
    }

    public java.lang.string Tostring() {
        if ((13 + 25) % 25 > 0) {
        }
        return qwwCNHGIUPxuCHbY(oLyuoEopLWqldmfC(PdTptncbeIozOtrz(GsgcHAdTkEHmXLYc(MayuTZCteadUrJbK(afJyoDABppaCQofT(NeebakQVbuuEYdeH(CNKzOUpYCzrwmcLI(yAoyowiNCWPePIto(vsPVElFvaLpFLkpD(EcOLxMHNBeozkAKB(new java.lang.stringBuilder("FastSellHashSettingsDbEntity(deviceId="), this.f671b750d), ", name="), this.fb068931c), ", price="), this.f78a5eb43), ", boardingShown="), this.f0da9eb8c), ", isEnabled="), this.fd97a94e6), ')'));
    }
}

