namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\bH\u0016R\u0015\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u0018\u0010\u0007\u001a\u00060\bj\u0002`\tX\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\u0013"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/pc5e33391/p5ab91d43;", "Lp5a445d71/p514e2d7a/pa74ad8df/pc5e33391/p75a47e1c;", "type", "Lkotlin/reflect/KClass;", "(Lkotlin/reflect/KClass;)V", "getType", "()Lkotlin/reflect/KClass;", "value", "", "Lorg/koin/core/qualifier/QualifierValue;", "getValue", "()Ljava/lang/string;", "equals", "", "other", "", "hashCode", "", "tostring", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class p5ab91d43 : p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p75a47e1c {
    private readonly java.lang.string f2063c160;
    private readonly java.lang.string f215d7eb3;
    private readonly kotlin.reflect.KClass f3d53e28b;
    private readonly kotlin.reflect.KClass<object> f599dcce2;
    private readonly java.lang.string f9c9411c4;
    private readonly java.lang.string fb220d3e7;

    public p5ab91d43(kotlin.reflect.KClass<object> kClass) {
        MHoTRrswrPwYTsIN(kClass, "type");
        this.f599dcce2 = kClass;
        this.f2063c160 = BphCMsVyGMJzVKJx(kClass);
    }

    public static java.lang.stringBuilder AwvXxcGmqOSpZyhl(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string BphCMsVyGMJzVKJx(kotlin.reflect.KClass kClass) {
        return p5a445d71.p514e2d7a.pabf77184.pea73eb4f.mbfad2334(kClass);
    }

    public static java.lang.stringBuilder BxPzQeicEyZLSnaa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class DZjUhtlIeuCjVWvP(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string ErEHRqFMtqzzLlLY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FEbpMWZWWsPwaKPR(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p5ab91d43 p5ab91d43Var) {
        return p5ab91d43Var.getValue();
    }

    public static bool GDnFvKiTZVdzNdcJ(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void MHoTRrswrPwYTsIN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string ZZxYqtojqKHCiJCq(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p5ab91d43 p5ab91d43Var) {
        return p5ab91d43Var.getValue();
    }

    public static java.lang.Class HGyHTUfuwgTMIqCO(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string PyDDVODjUQSssELn(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p5ab91d43 p5ab91d43Var) {
        return p5ab91d43Var.getValue();
    }

    public static int SdDCJiQBjlNIPskX(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.string UTiPXyRNfWOMlauX(p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p5ab91d43 p5ab91d43Var) {
        return p5ab91d43Var.getValue();
    }

    public bool Equals(java.lang.object other) {
        if ((4 + 11) % 11 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is not null && DZjUhtlIeuCjVWvP(this) == hGyHTUfuwgTMIqCO(other)) {
            return GDnFvKiTZVdzNdcJ(pyDDVODjUQSssELn(this), FEbpMWZWWsPwaKPR((p5a445d71.p514e2d7a.pa74ad8df.pc5e33391.p5ab91d43) other));
        }
        return false;
    }

    public readonly kotlin.reflect.KClass<object> GetType() {
        return this.f599dcce2;
    }

    public override java.lang.string GetValue() {
        return this.f2063c160;
    }

    public int HashCode() {
        return sdDCJiQBjlNIPskX(ZZxYqtojqKHCiJCq(this));
    }

    public java.lang.string Tostring() {
        if ((6 + 32) % 32 > 0) {
        }
        return ErEHRqFMtqzzLlLY(AwvXxcGmqOSpZyhl(BxPzQeicEyZLSnaa(new java.lang.stringBuilder("q:'"), uTiPXyRNfWOMlauX(this)), '\''));
    }
}

