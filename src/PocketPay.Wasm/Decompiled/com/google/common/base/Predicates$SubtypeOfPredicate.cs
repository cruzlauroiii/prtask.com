namespace WillowMaze.Wasm.Decompiled;


class Predicates$SubtypeOfPredicate : com.google.common.base.Predicate<java.lang.Class<object>>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.Class<object> clazz;

    private Predicates$SubtypeOfPredicate(java.lang.Class<object> cls) {
        this.clazz = (java.lang.Class) klDshnLgvsNHipjj(cls);
    }

    Predicates$SubtypeOfPredicate(java.lang.Class cls, com.google.common.base.Predicates$1 predicates$1) {
        this(cls);
    }

    public static bool GDjXzcVdewKDkyIT(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.stringBuilder HvlOfDzIVIlQQjTK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int JZQwzLSMAbWaCaRR(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder QgSOJBKcDLuqoGvB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RcQIrEEYvHFDDMwV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WEajuHoGrFguQdGZ(com.google.common.base.Predicates$SubtypeOfPredicate predicates$SubtypeOfPredicate, java.lang.Class cls) {
        return predicates$SubtypeOfPredicate.apply2((java.lang.Class<object>) cls);
    }

    public static java.lang.string WhazefkUZaYHpXJl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XcNgkHNMWYALilvz(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string IXChyOmdLiIMMLLk(java.lang.Class cls) {
        return cls.getName();
    }

    public static int JYPMZqGslsVncmlb(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object KlDshnLgvsNHipjj(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public bool Apply2(java.lang.Class<object> cls) {
        return GDjXzcVdewKDkyIT(this.clazz, cls);
    }

    public override bool Apply(java.lang.Class<object> cls) {
        return WEajuHoGrFguQdGZ(this, cls);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 9) % 9 > 0) {
        }
        if (obj is com.google.common.base.Predicates$SubtypeOfPredicate) {
            if (this.clazz == ((com.google.common.base.Predicates$SubtypeOfPredicate) obj).clazz) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return JZQwzLSMAbWaCaRR(this.clazz);
    }

    public java.lang.string Tostring() {
        if ((15 + 14) % 14 > 0) {
        }
        java.lang.string strIXChyOmdLiIMMLLk = iXChyOmdLiIMMLLk(this.clazz);
        return WhazefkUZaYHpXJl(RcQIrEEYvHFDDMwV(HvlOfDzIVIlQQjTK(QgSOJBKcDLuqoGvB(new java.lang.stringBuilder(jYPMZqGslsVncmlb(XcNgkHNMWYALilvz(strIXChyOmdLiIMMLLk)) + 22), "Predicates.subtypeOf("), strIXChyOmdLiIMMLLk), ")"));
    }
}

