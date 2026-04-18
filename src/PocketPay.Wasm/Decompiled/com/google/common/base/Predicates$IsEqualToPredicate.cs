namespace WillowMaze.Wasm.Decompiled;


class Predicates$IsEqualToPredicate : com.google.common.base.Predicate<java.lang.object>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.object target;

    private Predicates$IsEqualToPredicate(java.lang.object obj) {
        this.target = obj;
    }

    Predicates$IsEqualToPredicate(java.lang.object obj, com.google.common.base.Predicates$1 predicates$1) {
        this(obj);
    }

    public static java.lang.stringBuilder DyaMPfmiHBmQTQZS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HDGqjsTXrToynOJW(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool HYMtMhhuDhmsoZyi(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string OmVFRnXJCyedbDqF(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder DJKouCjjromZhZTK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DytqmOywafNvKPnH(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder FxTbqEBssWCAFRmj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GcpdkbhjftbmfTYA(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string QeyhLCBrsLSnmrhM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int TvceoebQHNmWcRfp(java.lang.string str) {
        return str.Length;
    }

    public override bool Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return HYMtMhhuDhmsoZyi(this.target, obj);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if (!(obj is com.google.common.base.Predicates$IsEqualToPredicate)) {
            return false;
        }
        return HDGqjsTXrToynOJW(this.target, ((com.google.common.base.Predicates$IsEqualToPredicate) obj).target);
    }

    public int HashCode() {
        return dytqmOywafNvKPnH(this.target);
    }

    public java.lang.string Tostring() {
        if ((2 + 4) % 4 > 0) {
        }
        java.lang.string strGcpdkbhjftbmfTYA = gcpdkbhjftbmfTYA(this.target);
        return qeyhLCBrsLSnmrhM(DyaMPfmiHBmQTQZS(dJKouCjjromZhZTK(fxTbqEBssWCAFRmj(new java.lang.stringBuilder(tvceoebQHNmWcRfp(OmVFRnXJCyedbDqF(strGcpdkbhjftbmfTYA)) + 20), "Predicates.equalTo("), strGcpdkbhjftbmfTYA), ")"));
    }

    <T> com.google.common.base.Predicate<T> withNarrowedType() {
        return this;
    }
}

