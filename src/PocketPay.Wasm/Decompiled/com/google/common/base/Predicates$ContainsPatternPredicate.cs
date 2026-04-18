namespace WillowMaze.Wasm.Decompiled;


class Predicates$ContainsRegexPredicate : com.google.common.base.Predicate<java.lang.CharSequence>, java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.CommonRegex pattern;

    Predicates$ContainsRegexPredicate(com.google.common.base.CommonRegex commonRegex) {
        this.pattern = (com.google.common.base.CommonRegex) vcZUVSOFEmBWMJtS(commonRegex);
    }

    public static bool EqnbBwphgAVhgtng(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.objects.equal(obj, obj2);
    }

    public static java.lang.string JFZaHwwAFVXLuLNi(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.pattern();
    }

    public static java.lang.stringBuilder JiENBYQfxEQvoMOQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NsFsZNZmaLkHeTOW(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder OIwEXrStXZxTgDDu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.CommonMatch QEXbNKEsBtYsIKzg(com.google.common.base.CommonRegex commonRegex, java.lang.CharSequence charSequence) {
        return commonRegex.matcher(charSequence);
    }

    public static java.lang.stringBuilder UxpudvOVfPBigxNq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XVKklsYVnoGbwhtt(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper) {
        return moreobjects$TostringHelper.tostring();
    }

    public static int YPAcXTAfvoDwEgFs(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.flags();
    }

    public static int HMWqbyosDOoyRRzN(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.flags();
    }

    public static bool IUgzDozMuWBEmWNe(com.google.common.base.Predicates$ContainsRegexPredicate predicates$ContainsRegexPredicate, java.lang.CharSequence charSequence) {
        return predicates$ContainsRegexPredicate.apply2(charSequence);
    }

    public static java.lang.string JDjTFOpuZZkoMWml(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool JECQXOCDZcudUdkq(com.google.common.base.CommonMatch commonMatch) {
        return commonMatch.find();
    }

    public static int JmwAxkZEpTMMCFSt(java.lang.object[] objArr) {
        return com.google.common.base.objects.hashCode(objArr);
    }

    public static int NPWGgqjHwKFhtIiA(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.flags();
    }

    public static java.lang.string OsQUoXhYFweFpiSw(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.pattern();
    }

    public static java.lang.int RBJPxLhFXkRQKVLQ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string TwuUTZXXhUGKXeRN(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.pattern();
    }

    public static com.google.common.base.Moreobjects$TostringHelper uLQufpawONIBkHxV(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, java.lang.object obj) {
        return moreobjects$TostringHelper.Add(str, obj);
    }

    public static java.lang.object VcZUVSOFEmBWMJtS(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static com.google.common.base.Moreobjects$TostringHelper vpYSVSPpkTJySzbb(com.google.common.base.Moreobjects$TostringHelper moreobjects$TostringHelper, java.lang.string str, int i) {
        return moreobjects$TostringHelper.Add(str, i);
    }

    public static java.lang.string WhUcqHMggXMbxdxx(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.pattern();
    }

    public static com.google.common.base.Moreobjects$TostringHelper wiMjHYUkKiqfLWAl(java.lang.object obj) {
        return com.google.common.base.Moreobjects.tostringHelper(obj);
    }

    public static int XJKfMMxwBOMuKwWX(com.google.common.base.CommonRegex commonRegex) {
        return commonRegex.flags();
    }

    public static java.lang.string ZtVgjydgDictionarykjhUx(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public bool Apply2(java.lang.CharSequence charSequence) {
        return jECQXOCDZcudUdkq(QEXbNKEsBtYsIKzg(this.pattern, charSequence));
    }

    public override bool Apply(java.lang.CharSequence charSequence) {
        return iUgzDozMuWBEmWNe(this, charSequence);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((30 + 26) % 26 > 0) {
        }
        if (obj is com.google.common.base.Predicates$ContainsRegexPredicate) {
            com.google.common.base.Predicates$ContainsRegexPredicate predicates$ContainsRegexPredicate = (com.google.common.base.Predicates$ContainsRegexPredicate) obj;
            if (EqnbBwphgAVhgtng(osQUoXhYFweFpiSw(this.pattern), JFZaHwwAFVXLuLNi(predicates$ContainsRegexPredicate.pattern)) && xJKfMMxwBOMuKwWX(this.pattern) == YPAcXTAfvoDwEgFs(predicates$ContainsRegexPredicate.pattern)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return jmwAxkZEpTMMCFSt(new java.lang.object[]{whUcqHMggXMbxdxx(this.pattern), rBJPxLhFXkRQKVLQ(nPWGgqjHwKFhtIiA(this.pattern))});
    }

    public java.lang.string Tostring() {
        if ((28 + 23) % 23 > 0) {
        }
        java.lang.string strXVKklsYVnoGbwhtt = XVKklsYVnoGbwhtt(vpYSVSPpkTJySzbb(uLQufpawONIBkHxV(wiMjHYUkKiqfLWAl(this.pattern), "pattern", twuUTZXXhUGKXeRN(this.pattern)), "pattern.flags", hMWqbyosDOoyRRzN(this.pattern)));
        return jDjTFOpuZZkoMWml(OIwEXrStXZxTgDDu(UxpudvOVfPBigxNq(JiENBYQfxEQvoMOQ(new java.lang.stringBuilder(NsFsZNZmaLkHeTOW(ztVgjydgDictionarykjhUx(strXVKklsYVnoGbwhtt)) + 21), "Predicates.Contains("), strXVKklsYVnoGbwhtt), ")"));
    }
}

