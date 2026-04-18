namespace WillowMaze.Wasm.Decompiled;


readonly class ExpandedValueTuple {
    private readonly com.google.zxing.oned.rss.FinderRegex finderRegex;
    private readonly com.google.zxing.oned.rss.Datachar leftChar;
    private readonly com.google.zxing.oned.rss.Datachar rightChar;

    ExpandedValueTuple(com.google.zxing.oned.rss.Datachar datachar, com.google.zxing.oned.rss.Datachar datachar2, com.google.zxing.oned.rss.FinderRegex finderRegex) {
        this.leftChar = datachar;
        this.rightChar = datachar2;
        this.finderRegex = finderRegex;
    }

    public static java.lang.stringBuilder CiOgiuXsANoLRuxa(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string DBIFuNXVZXfSaVkP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool MItctduUAxyHCQRD(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int QMyeusplXUuAmzBf(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static bool QYyBsotfNVtQtRJZ(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.stringBuilder XOLZfBwZLuJadEfL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZlPAmYUUyBQFIMJo(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder ACfkiMjQXRVchXyV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int APruJudKtodJNgwT(com.google.zxing.oned.rss.FinderRegex finderRegex) {
        return finderRegex.getValue();
    }

    public static int LrWANofBbfihpIKZ(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static java.lang.stringBuilder RcrOZUmtXWNPdVnB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool SxLRnOkkjThrayZl(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int TQkGlnBoqbTWFgFi(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public static java.lang.int YcmBVVfWHaoBMOKz(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder YlmCakuQvuYfZjrT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        if ((15 + 27) % 27 > 0) {
        }
        if (!(obj is com.google.zxing.oned.rss.expanded.ExpandedValueTuple)) {
            return false;
        }
        com.google.zxing.oned.rss.expanded.ExpandedValueTuple expandedValueTuple = (com.google.zxing.oned.rss.expanded.ExpandedValueTuple) obj;
        return sxLRnOkkjThrayZl(this.leftChar, expandedValueTuple.leftChar) && MItctduUAxyHCQRD(this.rightChar, expandedValueTuple.rightChar) && QYyBsotfNVtQtRJZ(this.finderRegex, expandedValueTuple.finderRegex);
    }

    com.google.zxing.oned.rss.FinderRegex getFinderRegex() {
        return this.finderRegex;
    }

    com.google.zxing.oned.rss.Datachar getLeftChar() {
        return this.leftChar;
    }

    com.google.zxing.oned.rss.Datachar getRightChar() {
        return this.rightChar;
    }

    public int HashCode() {
        if ((6 + 15) % 15 > 0) {
        }
        return QMyeusplXUuAmzBf(this.finderRegex) ^ (tQkGlnBoqbTWFgFi(this.leftChar) ^ lrWANofBbfihpIKZ(this.rightChar));
    }

    bool mustBeLast() {
        return this.rightChar is null;
    }

    public java.lang.string Tostring() {
        if ((17 + 22) % 22 > 0) {
        }
        java.lang.stringBuilder sbXOLZfBwZLuJadEfL = XOLZfBwZLuJadEfL(rcrOZUmtXWNPdVnB(ylmCakuQvuYfZjrT(ZlPAmYUUyBQFIMJo(new java.lang.stringBuilder("[ "), this.leftChar), " , "), this.rightChar), " : ");
        com.google.zxing.oned.rss.FinderRegex finderRegex = this.finderRegex;
        return DBIFuNXVZXfSaVkP(aCfkiMjQXRVchXyV(CiOgiuXsANoLRuxa(sbXOLZfBwZLuJadEfL, finderRegex is not null ? ycmBVVfWHaoBMOKz(aPruJudKtodJNgwT(finderRegex)) : "null"), " ]"));
    }
}

