namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004¢\u0006\u0002\u0010\u0005J\r\u0010\b\u001a\u00060\u0003j\u0002`\u0004HÆ\u0003J\u0017\u0010\t\u001a\u00020\u00002\f\b\u0002\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004HÆ\u0001J\u0013\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\rHÖ\u0003J\t\u0010\u000e\u001a\u00020\u000fHÖ\u0001J\b\u0010\u0010\u001a\u00020\u0003H\u0016R\u0018\u0010\u0002\u001a\u00060\u0003j\u0002`\u0004X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0011"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/pc5e33391/p75e2f111;", "Lp5a445d71/p514e2d7a/pa74ad8df/pc5e33391/p75a47e1c;", "value", "", "Lorg/koin/core/qualifier/QualifierValue;", "(Ljava/lang/string;)V", "getValue", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "", "hashCode", "", "tostring", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class p75e2f111 : p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c {
    private readonly java.lang.string f2063c160;
    private readonly java.lang.string faf2559d2;
    private readonly java.lang.string fd5b802ca;
    private readonly java.lang.string feb594931;

    public p75e2f111(java.lang.string str) {
        jDAbYEZETVmTMbDr(str, "value");
        this.f2063c160 = str;
    }

    public static int NaUlrTrykGiBmYUE(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string OBXsJvdJWtbDxsWa(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 p75e2f111Var) {
        return p75e2f111Var.getValue();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 VsCAaDuxtHnEPDli(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 p75e2f111Var, java.lang.string str) {
        return p75e2f111Var.copy(str);
    }

    public static void JDAbYEZETVmTMbDr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 M1c1e012b(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 p75e2f111Var, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = p75e2f111Var.f2063c160;
        }
        return VsCAaDuxtHnEPDli(p75e2f111Var, str);
    }

    public static void UINUuizKHMKTaESR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool WUkZqMsvFOWlKRrW(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string Component1() {
        return this.f2063c160;
    }

    public readonly p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111 Copy(java.lang.string value) {
        uINUuizKHMKTaESR(value, "value");
        return new p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111(value);
    }

    public bool Equals(java.lang.object other) {
        if ((6 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111) {
            return wUkZqMsvFOWlKRrW(this.f2063c160, ((p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75e2f111) other).f2063c160);
        }
        return false;
    }

    public override java.lang.string GetValue() {
        return this.f2063c160;
    }

    public int HashCode() {
        return NaUlrTrykGiBmYUE(this.f2063c160);
    }

    public java.lang.string Tostring() {
        return OBXsJvdJWtbDxsWa(this);
    }
}

