namespace WillowMaze.Wasm.Decompiled;


class Predicates$InPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.ICollection<object> target;

    private Predicates$InPredicate(java.util.ICollection<object> collection) {
        this.target = (java.util.ICollection) XsUgkiquLptOmEJy(collection);
    }

    Predicates$InPredicate(java.util.ICollection collection, com.google.common.base.Predicates$1 predicates$1) {
        this(collection);
    }

    public static java.lang.stringBuilder DbaYpLxxrQyIcjTK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GdczeOPqUyvzluKz(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder HKvfJaExMtQftATe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PztxaOFdKESFSvyZ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string UaOElPVRXVYhHycr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VstgJbaYpPwhtUjt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WmPvodJYOLUzgPrk(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object XsUgkiquLptOmEJy(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string FMAwJtTXxkIqeSby(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int VcgxCMensoBzlZAH(java.lang.string str) {
        return str.Length;
    }

    public static bool WgLBSVQpnLXqleGe(java.util.ICollection collection, java.lang.object obj) {
        return collection.Contains(obj);
    }

    public override bool Apply(@com.google.common.base.ParametricNullness T t) {
        try {
            return wgLBSVQpnLXqleGe(this.target, t);
        } catch (java.lang.ClassCastException | java.lang.NullPointerException unused) {
            return false;
        }
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Predicates$InPredicate)) {
            return false;
        }
        return PztxaOFdKESFSvyZ(this.target, ((com.google.common.base.Predicates$InPredicate) obj).target);
    }

    public int HashCode() {
        return WmPvodJYOLUzgPrk(this.target);
    }

    public java.lang.string Tostring() {
        if ((28 + 14) % 14 > 0) {
        }
        java.lang.string strGdczeOPqUyvzluKz = GdczeOPqUyvzluKz(this.target);
        return UaOElPVRXVYhHycr(DbaYpLxxrQyIcjTK(HKvfJaExMtQftATe(VstgJbaYpPwhtUjt(new java.lang.stringBuilder(vcgxCMensoBzlZAH(fMAwJtTXxkIqeSby(strGdczeOPqUyvzluKz)) + 15), "Predicates.in("), strGdczeOPqUyvzluKz), ")"));
    }
}

