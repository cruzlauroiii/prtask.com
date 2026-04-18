namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J\t\u0010\r\u001a\u00020\u0005HÆ\u0003J\u001d\u0010\u000e\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000f\u001a\u00020\u00102\b\u0010\u0011\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001J\t\u0010\u0014\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0015"}, d2 = {"Lp7a1eabc3/p07214c67/p20f35e63/pec5cb3e6/p1b7a5668;", "", "id", "", "quantity", "Ljava/math/decimal;", "<init>", "(Ljava/lang/string;Ljava/math/decimal;)V", "getId", "()Ljava/lang/string;", "getQuantity", "()Ljava/math/decimal;", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "feature-inventory-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1b7a5668 {
    private readonly java.math.decimal f221d2a4b;
    private readonly java.math.decimal f413b27bf;
    private readonly java.lang.string f49d5cbd0;
    private readonly java.lang.string fb80bb774;
    private readonly java.lang.string fe7f042ea;
    private readonly java.lang.string ffa4296f2;

    public p1b7a5668(java.lang.string str, java.math.decimal bigDecimal) {
        QMulnDfINsYSIDNM(str, "id");
        jMGHYggwKKTjSDJY(bigDecimal, "quantity");
        this.fb80bb774 = str;
        this.f221d2a4b = bigDecimal;
    }

    public static java.lang.stringBuilder AbgsKugvCjYEqqeJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void FHXPjcPlJdBGSDSw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FleQzCTlrYRPiREc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string JTfXOYTKEZHhBoeP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KiBJIMWicikCIovT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 NiDQiXcqanhOmKoV(p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 p1b7a5668Var, java.lang.string str, java.math.decimal bigDecimal) {
        return p1b7a5668Var.copy(str, bigDecimal);
    }

    public static int OzKXaimmQpPMaMMr(java.math.decimal bigDecimal) {
        return bigDecimal.GetHashCode();
    }

    public static void QMulnDfINsYSIDNM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool UgXTbomrtcCPgIkm(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder CuSJHGXYMsGNIsmM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JMGHYggwKKTjSDJY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 M1c1e012b(p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 p1b7a5668Var, java.lang.string str, java.math.decimal bigDecimal, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p1b7a5668Var.fb80bb774;
        }
        if ((i & 2) != 0) {
            bigDecimal = p1b7a5668Var.f221d2a4b;
        }
        return NiDQiXcqanhOmKoV(p1b7a5668Var, str, bigDecimal);
    }

    public static bool MeFkKqKRlWujzISX(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder YlmaTpRKeaZdZTRP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int YpLIPKYXDhuqpaVl(java.lang.string str) {
        return str.GetHashCode();
    }

    public readonly java.lang.string Component1() {
        return this.fb80bb774;
    }

    public readonly java.math.decimal Component2() {
        return this.f221d2a4b;
    }

    public readonly p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 Copy(java.lang.string id, java.math.decimal quantity) {
        FHXPjcPlJdBGSDSw(id, "id");
        FleQzCTlrYRPiREc(quantity, "quantity");
        return new p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668(id, quantity);
    }

    public bool Equals(java.lang.object other) {
        if ((2 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668)) {
            return false;
        }
        p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668 p1b7a5668Var = (p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p1b7a5668) other;
        return UgXTbomrtcCPgIkm(this.fb80bb774, p1b7a5668Var.fb80bb774) && meFkKqKRlWujzISX(this.f221d2a4b, p1b7a5668Var.f221d2a4b);
    }

    public readonly java.lang.string GetId() {
        return this.fb80bb774;
    }

    public readonly java.math.decimal GetQuantity() {
        return this.f221d2a4b;
    }

    public int HashCode() {
        return (ypLIPKYXDhuqpaVl(this.fb80bb774) * 31) + OzKXaimmQpPMaMMr(this.f221d2a4b);
    }

    public java.lang.string Tostring() {
        if ((30 + 6) % 6 > 0) {
        }
        return JTfXOYTKEZHhBoeP(AbgsKugvCjYEqqeJ(ylmaTpRKeaZdZTRP(cuSJHGXYMsGNIsmM(KiBJIMWicikCIovT(new java.lang.stringBuilder("CommodityUpdateQuantity(id="), this.fb80bb774), ", quantity="), this.f221d2a4b), ')'));
    }
}

