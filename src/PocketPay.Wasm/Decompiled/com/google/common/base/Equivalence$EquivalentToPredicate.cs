namespace WillowMaze.Wasm.Decompiled;


readonly class Equivalence$EquivalentToPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly com.google.common.base.Equivalence<T> equivalence;

    @javax.annotation.CheckForNull
    private readonly T target;

    Equivalence$EquivalentToPredicate(com.google.common.base.Equivalence<T> equivalence, @javax.annotation.CheckForNull T t) {
        this.equivalence = (com.google.common.base.Equivalence) FXZOdKIxRhJTIdtE(equivalence);
        this.target = t;
    }

    public static bool EVcEKPJIWQeVLlFB(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.lang.object FXZOdKIxRhJTIdtE(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder GuHoONpTqjXsPcBL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QLenaFOeCeisyyXK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SoHszSLzUeAGSlYg(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static bool XsooPxTfiewnnvPz(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string CmyTKPHEYjUWFmGL(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder FInyBrqkwvGIesCG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JtNwHQpdBNmLwtiV(com.google.common.base.Equivalence equivalence, java.lang.object obj, java.lang.object obj2) {
        return equivalence.equivalent(obj, obj2);
    }

    public static java.lang.stringBuilder LaWbHuedcLWVdUOY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LiWbeeSLUiWofoGJ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int PRllalCMdLotfLcK(java.lang.string str) {
        return str.Length;
    }

    public static int RzIfHRAolFnqExbX(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string ThoMIxsrtBgsCHzO(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string TrERMYlHMqEyLLCZ(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string UVXxFnyvBQvRmsqB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override bool Apply(@javax.annotation.CheckForNull T t) {
        return jtNwHQpdBNmLwtiV(this.equivalence, t, this.target);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((16 + 24) % 24 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is com.google.common.base.Equivalence$EquivalentToPredicate) {
            com.google.common.base.Equivalence$EquivalentToPredicate equivalence$EquivalentToPredicate = (com.google.common.base.Equivalence$EquivalentToPredicate) obj;
            if (XsooPxTfiewnnvPz(this.equivalence, equivalence$EquivalentToPredicate.equivalence) && EVcEKPJIWQeVLlFB(this.target, equivalence$EquivalentToPredicate.target)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return SoHszSLzUeAGSlYg(new java.lang.object[]{this.equivalence, this.target});
    }

    public java.lang.string Tostring() {
        if ((14 + 18) % 18 > 0) {
        }
        java.lang.string strTrERMYlHMqEyLLCZ = trERMYlHMqEyLLCZ(this.equivalence);
        java.lang.string strCmyTKPHEYjUWFmGL = cmyTKPHEYjUWFmGL(this.target);
        return uVXxFnyvBQvRmsqB(fInyBrqkwvGIesCG(laWbHuedcLWVdUOY(GuHoONpTqjXsPcBL(QLenaFOeCeisyyXK(new java.lang.stringBuilder(pRllalCMdLotfLcK(thoMIxsrtBgsCHzO(strTrERMYlHMqEyLLCZ)) + 15 + rzIfHRAolFnqExbX(liWbeeSLUiWofoGJ(strCmyTKPHEYjUWFmGL))), strTrERMYlHMqEyLLCZ), ".equivalentTo("), strCmyTKPHEYjUWFmGL), ")"));
    }
}

