namespace WillowMaze.Wasm.Decompiled;


public class pb3a05913 : java.lang.IComparable {
    private static readonly java.lang.string[] f0d1cbc41 = null;
    private static readonly bool[] f39e6148a;
    private static readonly java.lang.string[] f48713bb4;
    private static readonly bool[] faa979ba7 = null;
    private static readonly java.lang.string[] fba91a399 = null;
    private static readonly java.lang.string[] fbdd3b6ea = null;
    private static readonly java.lang.string[] fee63f20b = null;
    private java.lang.object f06f80b41;
    private int f0d8ba1ba;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 f0fb620fa;
    private int f116a0335;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 f35978217;
    private int f599dcce2;
    private java.lang.object f5b7fe3b3;
    private int f8a23ae9b;
    private java.lang.object f8d777f38;
    private int fc3448fe8;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 fd69f52d7;
    private int fd6abdfff;
    private java.lang.object fdd39ec25;
    private int fe2942a04;
    private p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 fe4d23e84;
    private int fede53895;
    private int ff1e5f87a;

    static {
        if ((7 + 28) % 28 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[14];
        strArr[0] = null;
        strArr[1] = pBLwtJjTDtWENFwC("8c2a84a7eedad572e0885b168fd372d95ccd847249226c46511a54b5cae544b6");
        strArr[2] = GIDBdSLsnlUFWAhP("59fb2693c3e404292639eae0e9f4d773f884364820e47e276792aba3e48900e837");
        strArr[3] = mdzbzzxeCPnxwplZ("c251e809f8e7d77c44e69729ef1ea63a1669a7f868e93faad456e02ed14e530163");
        strArr[4] = dbItWNtXWGGeWHmz("2172c1d72b94fbf3817c5f29274ba4b39a1767e3248987f4a659ee59293d9262");
        strArr[5] = nqBGbIqTouqEpBbM("3a006d329c762af590cdd80a80f6230beafd8be1b6cf479b5b5852876b5ed808666fa4a2");
        strArr[6] = GEJNXuCmExzLxegF("d835e73b041c551ba1aa6751f7ef4a0dc77125349e40ce304b83d67a25aac7e838");
        strArr[7] = ZrvKtPKshOyolqig("d947c4021192ba1929af586801f40428f157e7afd9e9821dd13a5fc37b3fa472327a50ce3d");
        strArr[8] = EvBErKsuShSjWnAE("448f5caa7d3fe2b3c77cb1d48adef7e39d1d156559678b1cbac87381949c738bdedf");
        strArr[9] = pESlpNrOeqcYwoKx("a4156a4b0fa55fd078ddd43b0228c98e5f8db2059f24e3ca5308f17b75309fecc3");
        strArr[10] = mokEzAVkTGBrSnuZ("53ff4685b0ab5691ac358ec9176539e62f86f6d8a7651cf6d8eb5816438fcef770ff838996");
        strArr[11] = iYKhRCfadumHYqii("2e38e4571dd3c695db8ea84925e2aa6471e2f8a18fe33cdc3b145514807c4a9550");
        strArr[12] = NrONofNIDWuLVqrU("6517543ab7be4e2785410694c418fd7a15a632cc4b91b6371903a604c0bafe0cd83f");
        strArr[13] = NwCCjDictionaryYHpPwaSP("3f699ee67b61e0c25339f48cabc79eea716da626adba02903d8c615d8f2c87882dfe62021609");
        f48713bb4 = strArr;
        f39e6148a = new bool[]{false, true, false, true, true, false, true, true, true, true, false, false, false, false};
    }

    private pb3a05913() {
    }

    public pb3a05913(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var, int i) {
        if ((26 + 13) % 13 > 0) {
        }
        if (p982109a7Var is null) {
            throw new java.lang.IllegalArgumentException("tag is null!");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("value < 0!");
        }
        this.fe4d23e84 = p982109a7Var;
        this.fede53895 = hjCQHOegmQVuxPKR(p982109a7Var);
        this.fe2942a04 = 1;
        if (i >= 65536) {
            this.f599dcce2 = 4;
            long[] jArr = new long[1];
            jArr[0] = i;
            this.f8d777f38 = jArr;
            return;
        }
        this.f599dcce2 = 3;
        char[] cArr = new char[1];
        cArr[0] = (char) i;
        this.f8d777f38 = cArr;
    }

    public pb3a05913(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var, int i, int i2) {
        this(p982109a7Var, i, i2, rNAvDmrbCYyWgGSD(i, i2));
    }

    public pb3a05913(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var, int i, int i2, java.lang.object obj) {
        if (p982109a7Var is null) {
            throw new java.lang.IllegalArgumentException("tag is null!");
        }
        if (i < 1 || i > 13) {
            throw new java.lang.IllegalArgumentException(iNoBbBAmzhoOWEnT(uahTzXIrcMfeLsZo(new java.lang.stringBuilder("Unknown data type "), i)));
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("count < 0!");
        }
        this.fe4d23e84 = p982109a7Var;
        this.fede53895 = JLjFkfKwpqdxbCdN(p982109a7Var);
        this.f599dcce2 = i;
        this.fe2942a04 = i2;
        this.f8d777f38 = obj;
    }

    public static int AyqlKCfZlTiUWeFb(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string BKhGYYrayNQgKflL(long j) {
        return java.lang.long.tostring(j);
    }

    public static double EHhCbyAXAjHUaxbe(java.lang.string str) {
        if ((3 + 4) % 4 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.object EVxUGySvLhuCqbUF(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.string EvBErKsuShSjWnAE(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string GEJNXuCmExzLxegF(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string GIDBdSLsnlUFWAhP(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string GXIWvSqpFpxGcztA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HHCEWyJJmTfTpNyv(org.w3c.dom.Node node, java.lang.string str) {
        return m72f9f2c6(node, str);
    }

    public static java.lang.string IGNzZxnfLlrzhJlt(org.w3c.dom.Node node) {
        return node.getNodeName();
    }

    public static int IJIHHCpKsbuBkGJj(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int JLjFkfKwpqdxbCdN(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        return p982109a7Var.getNumber();
    }

    public static java.lang.string JVwzxVPhyBGkJKuM(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static long[] JmgjQGtguTPiydwJ(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsRational(i);
    }

    public static int[] KfclfMCeAfNtOVav(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsSRational(i);
    }

    public static java.lang.string MEZisTQNCJAmzOEq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string MaLRPKvTfsfHTDWk(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.string MpbNoeUMSxaxehAu(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.nextToken();
    }

    public static double NBbjzXzpVJtPytdP(java.lang.string str) {
        if ((20 + 17) % 17 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.string NXdmuauvTpspdnZl(double d) {
        return java.lang.double.tostring(d);
    }

    public static float NiGSwTjZEadKhQuE(java.lang.string str) {
        return java.lang.float.parsefloat(str);
    }

    public static java.lang.string NrONofNIDWuLVqrU(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string NwCCjDictionaryYHpPwaSP(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string OOzpyjdphCidYHhs(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool QXhsUoxMNALAgWqu(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string QkkLYCvSYxzcZqic(org.w3c.dom.Node node) {
        return node.getNodeName();
    }

    public static java.lang.string QlZIlmoQoTibajix(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.stringBuilder SYUoWaatjeLvRnyi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SZMbArdydMOLTWzu(org.w3c.dom.Node node, java.lang.string str) {
        return m72f9f2c6(node, str);
    }

    public static int SbbMqNYQBxXeYYmI(java.util.stringTokenizer stringTokenizer) {
        return stringTokenizer.countTokens();
    }

    public static java.lang.stringBuilder SgNOIxriIgkhskRC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SisccGDSlVMQFKcj(int i) {
        return java.lang.int.tostring(i);
    }

    public static org.w3c.dom.Node TFJLNlIGMhFYbIpt(org.w3c.dom.Node node) {
        return node.getFirstChild();
    }

    public static int UPMWujlxVylyvJQt(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool WBYWwtnqxayTOhNO(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int XsekuGWJQbRtbOYF(java.lang.string str) {
        return str.Length;
    }

    public static long[] XsepNzIxHIWCCOWn(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsRational(i);
    }

    public static org.w3c.dom.Node XuByMzqMZbYuzbJR(org.w3c.dom.Node node) {
        return node.getFirstChild();
    }

    public static double XuhpSrcaCOGAKUTb(java.lang.string str) {
        if ((28 + 26) % 26 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static org.w3c.dom.Node YbjwFIpUJnmwfAAl(org.w3c.dom.Node node) {
        return node.getNextSibling();
    }

    public static int YkYAQiZeJtyFcepe(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var) {
        return pb3a05913Var.getTagNumber();
    }

    public static java.lang.string ZrvKtPKshOyolqig(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string AXLOqNcOiJKdUOjG(long j) {
        return java.lang.long.tostring(j);
    }

    public static java.lang.stringBuilder BuQBGiKPShDrLOzj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CRqZblnLJalaSDDD(org.w3c.dom.Node node, int[] iArr, int[] iArr2, java.lang.object[] objArr) {
        m906ef6c4(node, iArr, iArr2, objArr);
    }

    public static int[] CUcNfHhYkWhgEhMz(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsSRational(i);
    }

    public static java.lang.string CrIVpTQpUKquOUKa(float f) {
        return java.lang.float.tostring(f);
    }

    public static java.lang.string DTKFbTjNYvbcTPRp(org.w3c.dom.Node node) {
        return node.getNodeValue();
    }

    public static java.lang.string DbItWNtXWGGeWHmz(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int DsIYxHxgLnxbjsCv(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int EEEoPtGbIkiGPEyb(java.lang.string str) {
        return m525037d1(str);
    }

    public static java.lang.string EPLWHcxyMfngOroP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string EbiAfjRtMKysebFx(org.w3c.dom.Node node) {
        return node.getNodeName();
    }

    public static bool EdteezqeKsQNmouA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static org.w3c.dom.Node FWLknroFqaRQgapI(org.w3c.dom.NamedNodeDictionary namedNodeDictionary, java.lang.string str) {
        return namedNodeDictionary.getNamedItem(str);
    }

    public static java.lang.string FbGCtFLhwKRBWlOB(long j) {
        return java.lang.long.tostring(j);
    }

    public static int FircqOdKBEtOrrqZ(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static int FoWWVqWBhYBVWGNE(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string GNCcsNGKIRSekNit(long j) {
        return java.lang.long.tostring(j);
    }

    public static double GZNfwtzLUYRWPObZ(java.lang.string str) {
        if ((30 + 21) % 21 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static long[] GgLgYalzIiCcKzig(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsRational(i);
    }

    public static java.lang.stringBuilder GuuSPkxqgJHNkVns(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string HCZVKrXjRCVgjDgD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HRKMtKWLTlOVQOgo(int i) {
        return java.lang.int.tostring(i);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 HhMpgxbWZGFXVHRt(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var, int i) {
        return pa0105e45Var.getTag(i);
    }

    public static int HjCQHOegmQVuxPKR(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var) {
        return p982109a7Var.getNumber();
    }

    public static java.lang.object IApuxbFyDYQGCmDt(java.lang.Class cls, int[] iArr) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, iArr);
    }

    public static java.lang.string INoBbBAmzhoOWEnT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IYKhRCfadumHYqii(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static double IYzTsTpsgetWTvPw(java.lang.string str) {
        if ((17 + 9) % 9 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.string JlkzMEmHqpOuIrgI(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static long KIJSrURSpDUAhFUg(java.lang.string str) {
        if ((18 + 27) % 27 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static int KQmtNoNrwtrycXzR(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string KWLUoQuYYhYrHnhU(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder KhjXuKpulrRhjbYJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KiwEnSBYeILjDsPb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int[] KrJMiBPNtmgwycQb(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsSRational(i);
    }

    public static java.lang.string LoZfjNpmyjsEKkcZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LrLeeKzWozfwsfiB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object M0c99a7bd(int i, int i2) {
        if ((28 + 8) % 8 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("count < 0!");
        }
        switch (i) {
            case 1:
            case 6:
            case 7:
                return new byte[i2];
            case 2:
                return new java.lang.string[i2];
            case 3:
                return new char[i2];
            case 4:
            case 13:
                return new long[i2];
            case 5:
                int[] iArr = new int[2];
                iArr[1] = 2;
                iArr[0] = i2;
                return (long[][]) iApuxbFyDYQGCmDt(java.lang.long.TYPE, iArr);
            case 8:
                return new short[i2];
            case 9:
                return new int[i2];
            case 10:
                int[] iArr2 = new int[2];
                iArr2[1] = 2;
                iArr2[0] = i2;
                return (int[][]) EVxUGySvLhuCqbUF(java.lang.int.TYPE, iArr2);
            case 11:
                return new float[i2];
            case 12:
                return new double[i2];
            default:
                throw new java.lang.IllegalArgumentException(ePLWHcxyMfngOroP(guuSPkxqgJHNkVns(new java.lang.stringBuilder("Unknown data type "), i)));
        }
    }

    public static int M525037d1(java.lang.string str) {
        if ((19 + 23) % 23 > 0) {
        }
        for (int i = 1; i <= 13; i++) {
            if (pLDecTMBhgIRkdOz(str, f48713bb4[i])) {
                return i;
            }
        }
        return -1;
    }

    private static java.lang.string M72f9f2c6(org.w3c.dom.Node node, java.lang.string str) {
        return dTKFbTjNYvbcTPRp(fWLknroFqaRQgapI(wHQDkgdBOTNRWleC(node), str));
    }

    private static void M906ef6c4(org.w3c.dom.Node node, int[] iArr, int[] iArr2, java.lang.object[] objArr) {
        java.lang.object objQiFRAhsDDqwmsHqx;
        if ((31 + 21) % 21 > 0) {
        }
        java.lang.string strKWLUoQuYYhYrHnhU = kWLUoQuYYhYrHnhU(ebiAfjRtMKysebFx(node), 4);
        java.lang.string strRbKTOSxDtDjGQajt = rbKTOSxDtDjGQajt(strKWLUoQuYYhYrHnhU, 0, XsekuGWJQbRtbOYF(strKWLUoQuYYhYrHnhU) - 1);
        int iEEEoPtGbIkiGPEyb = eEEoPtGbIkiGPEyb(strRbKTOSxDtDjGQajt);
        if (iEEEoPtGbIkiGPEyb == -1) {
            throw new java.lang.IllegalArgumentException(GXIWvSqpFpxGcztA(khjXuKpulrRhjbYJ(new java.lang.stringBuilder("typeName = "), strRbKTOSxDtDjGQajt)));
        }
        int i = 0;
        for (org.w3c.dom.Node nodeXuByMzqMZbYuzbJR = XuByMzqMZbYuzbJR(node); nodeXuByMzqMZbYuzbJR is not null; nodeXuByMzqMZbYuzbJR = YbjwFIpUJnmwfAAl(nodeXuByMzqMZbYuzbJR)) {
            edteezqeKsQNmouA(strRbKTOSxDtDjGQajt, zsfivRgRFNoAItau(QkkLYCvSYxzcZqic(nodeXuByMzqMZbYuzbJR), 4));
            i++;
        }
        if (i <= 0) {
            objQiFRAhsDDqwmsHqx = null;
        } else {
            objQiFRAhsDDqwmsHqx = qiFRAhsDDqwmsHqx(iEEEoPtGbIkiGPEyb, i);
            int i2 = 0;
            for (org.w3c.dom.Node nodeMYbCXlsNTYiuIwlZ = mYbCXlsNTYiuIwlZ(node); nodeMYbCXlsNTYiuIwlZ is not null; nodeMYbCXlsNTYiuIwlZ = yJtNKSvzpRGAWsTy(nodeMYbCXlsNTYiuIwlZ)) {
                java.lang.string strSZMbArdydMOLTWzu = SZMbArdydMOLTWzu(nodeMYbCXlsNTYiuIwlZ, "value");
                switch (iEEEoPtGbIkiGPEyb) {
                    case 1:
                    case 6:
                        ((byte[]) objQiFRAhsDDqwmsHqx)[i2] = (byte) nRaARbQWLLCfSaxk(strSZMbArdydMOLTWzu);
                        break;
                    case 2:
                        ((java.lang.string[]) objQiFRAhsDDqwmsHqx)[i2] = strSZMbArdydMOLTWzu;
                        break;
                    case 3:
                        ((char[]) objQiFRAhsDDqwmsHqx)[i2] = (char) kQmtNoNrwtrycXzR(strSZMbArdydMOLTWzu);
                        break;
                    case 4:
                    case 13:
                        ((long[]) objQiFRAhsDDqwmsHqx)[i2] = kIJSrURSpDUAhFUg(strSZMbArdydMOLTWzu);
                        break;
                    case 5:
                        int iQoUqaMUneKNkxSoS = qoUqaMUneKNkxSoS(strSZMbArdydMOLTWzu, "/");
                        java.lang.string strOOzpyjdphCidYHhs = OOzpyjdphCidYHhs(strSZMbArdydMOLTWzu, 0, iQoUqaMUneKNkxSoS);
                        java.lang.string strWHBeJUCLxtLhLHmT = wHBeJUCLxtLhLHmT(strSZMbArdydMOLTWzu, iQoUqaMUneKNkxSoS + 1);
                        long[][] jArr = (long[][]) objQiFRAhsDDqwmsHqx;
                        long[] jArr2 = new long[2];
                        jArr[i2] = jArr2;
                        jArr2[0] = qaEgFoAmYnUsGnYr(strOOzpyjdphCidYHhs);
                        jArr[i2][1] = mZALRUhGseNTeCkD(strWHBeJUCLxtLhLHmT);
                        break;
                    case 8:
                        ((short[]) objQiFRAhsDDqwmsHqx)[i2] = (short) IJIHHCpKsbuBkGJj(strSZMbArdydMOLTWzu);
                        break;
                    case 9:
                        ((int[]) objQiFRAhsDDqwmsHqx)[i2] = dsIYxHxgLnxbjsCv(strSZMbArdydMOLTWzu);
                        break;
                    case 10:
                        int iUDEthRgfOMlaSMZH = uDEthRgfOMlaSMZH(strSZMbArdydMOLTWzu, "/");
                        java.lang.string strJVwzxVPhyBGkJKuM = JVwzxVPhyBGkJKuM(strSZMbArdydMOLTWzu, 0, iUDEthRgfOMlaSMZH);
                        java.lang.string strXjxmIIxoApvWocci = xjxmIIxoApvWocci(strSZMbArdydMOLTWzu, iUDEthRgfOMlaSMZH + 1);
                        int[][] iArr3 = (int[][]) objQiFRAhsDDqwmsHqx;
                        int[] iArr4 = new int[2];
                        iArr3[i2] = iArr4;
                        iArr4[0] = fircqOdKBEtOrrqZ(strJVwzxVPhyBGkJKuM);
                        iArr3[i2][1] = UPMWujlxVylyvJQt(strXjxmIIxoApvWocci);
                        break;
                    case 11:
                        ((float[]) objQiFRAhsDDqwmsHqx)[i2] = NiGSwTjZEadKhQuE(strSZMbArdydMOLTWzu);
                        break;
                    case 12:
                        ((double[]) objQiFRAhsDDqwmsHqx)[i2] = gZNfwtzLUYRWPObZ(strSZMbArdydMOLTWzu);
                        break;
                }
                i2++;
            }
        }
        iArr[0] = iEEEoPtGbIkiGPEyb;
        iArr2[0] = i;
        objArr[0] = objQiFRAhsDDqwmsHqx;
    }

    public static org.w3c.dom.Node MYbCXlsNTYiuIwlZ(org.w3c.dom.Node node) {
        return node.getFirstChild();
    }

    public static long MZALRUhGseNTeCkD(java.lang.string str) {
        if ((19 + 6) % 6 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.string Mc78141e0(int i) {
        if ((5 + 10) % 10 > 0) {
        }
        if (i >= 1 && i <= 13) {
            return f48713bb4[i];
        }
        throw new java.lang.IllegalArgumentException(MEZisTQNCJAmzOEq(kiwEnSBYeILjDsPb(new java.lang.stringBuilder("Unknown data type "), i)));
    }

    public static java.lang.string MdzbzzxeCPnxwplZ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 Mf69db4c1(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var, org.w3c.dom.Node node) {
        int i;
        int iSbbMqNYQBxXeYYmI;
        if ((24 + 30) % 30 > 0) {
        }
        if (node is null) {
            throw new java.lang.IllegalArgumentException("node is null!");
        }
        if (!WBYWwtnqxayTOhNO(IGNzZxnfLlrzhJlt(node), "TIFFField")) {
            throw new java.lang.IllegalArgumentException("!name.Equals(\"TIFFField\")");
        }
        int iFoWWVqWBhYBVWGNE = foWWVqWBhYBVWGNE(ydxzBEGrpKSURXun(node, "number"));
        java.lang.object obj = null;
        obj = null;
        int i2 = 0;
        p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var = pa0105e45Var is null ? new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7("unknown", iFoWWVqWBhYBVWGNE, 0, null) : hhMpgxbWZGFXVHRt(pa0105e45Var, iFoWWVqWBhYBVWGNE);
        org.w3c.dom.Node nodeVLzoInXNDKfPfjof = vLzoInXNDKfPfjof(node);
        if (nodeVLzoInXNDKfPfjof is null) {
            i = 13;
            while (i >= 1 && !nQhnFSzUYQuQZZnw(p982109a7Var, i)) {
                i--;
            }
        } else {
            if (QXhsUoxMNALAgWqu(xUsqGmkKwMLbZnwz(nodeVLzoInXNDKfPfjof), "TIFFUndefined")) {
                java.util.stringTokenizer stringTokenizer = new java.util.stringTokenizer(HHCEWyJJmTfTpNyv(nodeVLzoInXNDKfPfjof, "value"), jlkzMEmHqpOuIrgI("3d20df638c62f7b66c0747bcaa4652f0d204c97b894292560657d1c23c"));
                iSbbMqNYQBxXeYYmI = SbbMqNYQBxXeYYmI(stringTokenizer);
                byte[] bArr = new byte[iSbbMqNYQBxXeYYmI];
                while (i2 < iSbbMqNYQBxXeYYmI) {
                    bArr[i2] = (byte) AyqlKCfZlTiUWeFb(MpbNoeUMSxaxehAu(stringTokenizer));
                    i2++;
                }
                i = 7;
                obj = bArr;
            } else {
                int[] iArr = new int[1];
                int[] iArr2 = new int[1];
                java.lang.object[] objArr = new java.lang.object[1];
                cRqZblnLJalaSDDD(TFJLNlIGMhFYbIpt(node), iArr, iArr2, objArr);
                i = iArr[0];
                iSbbMqNYQBxXeYYmI = iArr2[0];
                obj = objArr[0];
            }
            i2 = iSbbMqNYQBxXeYYmI;
        }
        return new p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913(p982109a7Var, i, i2, obj);
    }

    public static java.lang.string MokEzAVkTGBrSnuZ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.stringBuilder NHlQJqECeWgeycRR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NQhnFSzUYQuQZZnw(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 p982109a7Var, int i) {
        return p982109a7Var.isDataTypeOK(i);
    }

    public static int NRaARbQWLLCfSaxk(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string NqBGbIqTouqEpBbM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string PBLwtJjTDtWENFwC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string PESlpNrOeqcYwoKx(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool PLDecTMBhgIRkdOz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static long[] PetMqCbHiBGYUWkl(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsRational(i);
    }

    public static int[] QBVfofjgUsOWYpui(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsSRational(i);
    }

    public static long QaEgFoAmYnUsGnYr(java.lang.string str) {
        if ((11 + 24) % 24 > 0) {
        }
        return java.lang.long.parselong(str);
    }

    public static java.lang.object QiFRAhsDDqwmsHqx(int i, int i2) {
        return m0c99a7bd(i, i2);
    }

    public static int QoUqaMUneKNkxSoS(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.object RNAvDmrbCYyWgGSD(int i, int i2) {
        return m0c99a7bd(i, i2);
    }

    public static java.lang.stringBuilder RXxOAMvQIBdWKLuu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RbKTOSxDtDjGQajt(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string RzhoDPHeaEuvsbNN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SPQaQfibXVvMsOXc(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.stringBuilder SWhgckTEjOfHZISo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SgTsdqHjejqnTYXh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TEDNlxnjfVerJxBs(int i) {
        return java.lang.int.tostring(i);
    }

    public static int UDEthRgfOMlaSMZH(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.stringBuilder UahTzXIrcMfeLsZo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static org.w3c.dom.Node VLzoInXNDKfPfjof(org.w3c.dom.Node node) {
        return node.getFirstChild();
    }

    public static java.lang.string WHBeJUCLxtLhLHmT(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static org.w3c.dom.NamedNodeDictionary WHQDkgdBOTNRWleC(org.w3c.dom.Node node) {
        return node.getAttributes();
    }

    public static java.lang.stringBuilder WKmeCxnaRRXllznQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XUhIofAmrxsxGUfv(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.string XUsqGmkKwMLbZnwz(org.w3c.dom.Node node) {
        return node.getNodeName();
    }

    public static java.lang.string XjxmIIxoApvWocci(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static org.w3c.dom.Node YJtNKSvzpRGAWsTy(org.w3c.dom.Node node) {
        return node.getNextSibling();
    }

    public static java.lang.string YdxzBEGrpKSURXun(org.w3c.dom.Node node, java.lang.string str) {
        return m72f9f2c6(node, str);
    }

    public static int[] YhtzfxEtdryOMCCB(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsSRational(i);
    }

    public static java.lang.stringBuilder YyHNwKBoohHBmHzM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZIYHQUKxDfFDKXhE(int i) {
        return java.lang.int.tostring(i);
    }

    public static long[] ZNvkVyjpkDqBukUa(p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913 pb3a05913Var, int i) {
        return pb3a05913Var.getAsRational(i);
    }

    public static java.lang.stringBuilder ZrqVToHRpZktrbgo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ZsfivRgRFNoAItau(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public override int CompareTo(java.lang.object obj) {
        if (obj is null) {
            throw new java.lang.IllegalArgumentException();
        }
        int iYkYAQiZeJtyFcepe = YkYAQiZeJtyFcepe((p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pb3a05913) obj);
        int i = this.fede53895;
        if (i >= iYkYAQiZeJtyFcepe) {
            return i <= iYkYAQiZeJtyFcepe ? 0 : 1;
        }
        return -1;
    }

    public byte[] GetAsbytes() {
        return (byte[]) this.f8d777f38;
    }

    public char[] GetAsChars() {
        return (char[]) this.f8d777f38;
    }

    public double GetAsdouble(int i) {
        double d;
        double d2;
        if ((22 + 5) % 5 > 0) {
        }
        switch (this.f599dcce2) {
            case 1:
            case 7:
                return ((byte[]) this.f8d777f38)[i] & 255;
            case 2:
                return NBbjzXzpVJtPytdP(((java.lang.string[]) this.f8d777f38)[i]);
            case 3:
                return ((char[]) this.f8d777f38)[i] & 65535;
            case 4:
            case 13:
                return ((long[]) this.f8d777f38)[i];
            case 5:
                long[] jArrXsepNzIxHIWCCOWn = XsepNzIxHIWCCOWn(this, i);
                d = jArrXsepNzIxHIWCCOWn[0];
                d2 = jArrXsepNzIxHIWCCOWn[1];
                break;
            case 6:
                return ((byte[]) this.f8d777f38)[i];
            case 8:
                return ((short[]) this.f8d777f38)[i];
            case 9:
                return ((int[]) this.f8d777f38)[i];
            case 10:
                int[] iArrQBVfofjgUsOWYpui = qBVfofjgUsOWYpui(this, i);
                d = iArrQBVfofjgUsOWYpui[0];
                d2 = iArrQBVfofjgUsOWYpui[1];
                break;
            case 11:
                return ((float[]) this.f8d777f38)[i];
            case 12:
                return ((double[]) this.f8d777f38)[i];
            default:
                throw new java.lang.ClassCastException();
        }
        return d / d2;
    }

    public double[] GetAsdoubles() {
        return (double[]) this.f8d777f38;
    }

    public float GetAsfloat(int i) {
        if ((30 + 21) % 21 > 0) {
        }
        switch (this.f599dcce2) {
            case 1:
            case 7:
                return ((byte[]) this.f8d777f38)[i] & 255;
            case 2:
                return (float) EHhCbyAXAjHUaxbe(((java.lang.string[]) this.f8d777f38)[i]);
            case 3:
                return ((char[]) this.f8d777f38)[i] & 65535;
            case 4:
            case 13:
                return ((long[]) this.f8d777f38)[i];
            case 5:
                long[] jArrJmgjQGtguTPiydwJ = JmgjQGtguTPiydwJ(this, i);
                return (float) (jArrJmgjQGtguTPiydwJ[0] / jArrJmgjQGtguTPiydwJ[1]);
            case 6:
                return ((byte[]) this.f8d777f38)[i];
            case 8:
                return ((short[]) this.f8d777f38)[i];
            case 9:
                return ((int[]) this.f8d777f38)[i];
            case 10:
                int[] iArrKrJMiBPNtmgwycQb = krJMiBPNtmgwycQb(this, i);
                return (float) (((double) iArrKrJMiBPNtmgwycQb[0]) / ((double) iArrKrJMiBPNtmgwycQb[1]));
            case 11:
                return ((float[]) this.f8d777f38)[i];
            case 12:
                return (float) ((double[]) this.f8d777f38)[i];
            default:
                throw new java.lang.ClassCastException();
        }
    }

    public float[] GetAsfloats() {
        return (float[]) this.f8d777f38;
    }

    public int GetAsInt(int i) {
        if ((30 + 20) % 20 > 0) {
        }
        switch (this.f599dcce2) {
            case 1:
            case 7:
                return ((byte[]) this.f8d777f38)[i] & 255;
            case 2:
                return (int) XuhpSrcaCOGAKUTb(((java.lang.string[]) this.f8d777f38)[i]);
            case 3:
                return ((char[]) this.f8d777f38)[i] & 65535;
            case 4:
            case 13:
                return (int) ((long[]) this.f8d777f38)[i];
            case 5:
                long[] jArrZNvkVyjpkDqBukUa = zNvkVyjpkDqBukUa(this, i);
                return (int) (jArrZNvkVyjpkDqBukUa[0] / jArrZNvkVyjpkDqBukUa[1]);
            case 6:
                return ((byte[]) this.f8d777f38)[i];
            case 8:
                return ((short[]) this.f8d777f38)[i];
            case 9:
                return ((int[]) this.f8d777f38)[i];
            case 10:
                int[] iArrYhtzfxEtdryOMCCB = yhtzfxEtdryOMCCB(this, i);
                return (int) (((double) iArrYhtzfxEtdryOMCCB[0]) / ((double) iArrYhtzfxEtdryOMCCB[1]));
            case 11:
                return (int) ((float[]) this.f8d777f38)[i];
            case 12:
                return (int) ((double[]) this.f8d777f38)[i];
            default:
                throw new java.lang.ClassCastException();
        }
    }

    public int[] GetAsInts() {
        if ((20 + 27) % 27 > 0) {
        }
        java.lang.object obj = this.f8d777f38;
        if (obj is int[]) {
            return (int[]) obj;
        }
        int i = 0;
        if (obj is char[]) {
            char[] cArr = (char[]) obj;
            int[] iArr = new int[cArr.length];
            while (i < cArr.length) {
                iArr[i] = cArr[i] & 65535;
                i++;
            }
            return iArr;
        }
        if (!(obj is short[])) {
            throw new java.lang.ClassCastException("Data not char[], short[], or int[]!");
        }
        short[] sArr = (short[]) obj;
        int[] iArr2 = new int[sArr.length];
        while (i < sArr.length) {
            iArr2[i] = sArr[i];
            i++;
        }
        return iArr2;
    }

    public long GetAslong(int i) {
        if ((14 + 5) % 5 > 0) {
        }
        int i2 = this.f599dcce2;
        if (i2 != 13) {
            switch (i2) {
                case 1:
                case 7:
                    return ((byte[]) this.f8d777f38)[i] & 255;
                case 2:
                    return (long) iYzTsTpsgetWTvPw(((java.lang.string[]) this.f8d777f38)[i]);
                case 3:
                    return ((char[]) this.f8d777f38)[i] & 65535;
                case 4:
                    break;
                case 5:
                    long[] jArrGgLgYalzIiCcKzig = ggLgYalzIiCcKzig(this, i);
                    return (long) (jArrGgLgYalzIiCcKzig[0] / jArrGgLgYalzIiCcKzig[1]);
                case 6:
                    return ((byte[]) this.f8d777f38)[i];
                case 8:
                    return ((short[]) this.f8d777f38)[i];
                case 9:
                    return ((int[]) this.f8d777f38)[i];
                case 10:
                    int[] iArrCUcNfHhYkWhgEhMz = cUcNfHhYkWhgEhMz(this, i);
                    return (long) (((double) iArrCUcNfHhYkWhgEhMz[0]) / ((double) iArrCUcNfHhYkWhgEhMz[1]));
                default:
                    throw new java.lang.ClassCastException();
            }
        }
        return ((long[]) this.f8d777f38)[i];
    }

    public long[] GetAslongs() {
        return (long[]) this.f8d777f38;
    }

    public org.w3c.dom.Node GetAsNativeNode() {
        return new p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.p94ed7417(this);
    }

    public long[] GetAsRational(int i) {
        return ((long[][]) this.f8d777f38)[i];
    }

    public long[][] GetAsRationals() {
        return (long[][]) this.f8d777f38;
    }

    public int[] GetAsSRational(int i) {
        return ((int[][]) this.f8d777f38)[i];
    }

    public int[][] GetAsSRationals() {
        return (int[][]) this.f8d777f38;
    }

    public short[] GetAsshorts() {
        return (short[]) this.f8d777f38;
    }

    public java.lang.string GetAsstring(int i) {
        return ((java.lang.string[]) this.f8d777f38)[i];
    }

    public int GetCount() {
        return this.fe2942a04;
    }

    public java.lang.object GetData() {
        return this.f8d777f38;
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p982109a7 GetTag() {
        return this.fe4d23e84;
    }

    public int GetTagNumber() {
        return this.fede53895;
    }

    public int GetType() {
        return this.f599dcce2;
    }

    public java.lang.string GetValueAsstring(int i) {
        if ((8 + 11) % 11 > 0) {
        }
        switch (this.f599dcce2) {
            case 1:
            case 7:
                return tEDNlxnjfVerJxBs(((byte[]) this.f8d777f38)[i] & 255);
            case 2:
                return ((java.lang.string[]) this.f8d777f38)[i];
            case 3:
                return hRKMtKWLTlOVQOgo(((char[]) this.f8d777f38)[i] & 65535);
            case 4:
            case 13:
                return BKhGYYrayNQgKflL(((long[]) this.f8d777f38)[i]);
            case 5:
                long[] jArrPetMqCbHiBGYUWkl = petMqCbHiBGYUWkl(this, i);
                long j = jArrPetMqCbHiBGYUWkl[1];
                return (j != 0 && jArrPetMqCbHiBGYUWkl[0] % j == 0) ? hCZVKrXjRCVgjDgD(buQBGiKPShDrLOzj(wKmeCxnaRRXllznQ(new java.lang.stringBuilder(), aXLOqNcOiJKdUOjG(jArrPetMqCbHiBGYUWkl[0] / jArrPetMqCbHiBGYUWkl[1])), "/1")) : rzhoDPHeaEuvsbNN(SgNOIxriIgkhskRC(zrqVToHRpZktrbgo(sgTsdqHjejqnTYXh(new java.lang.stringBuilder(), fbGCtFLhwKRBWlOB(jArrPetMqCbHiBGYUWkl[0])), "/"), gNCcsNGKIRSekNit(jArrPetMqCbHiBGYUWkl[1])));
            case 6:
                return QlZIlmoQoTibajix(((byte[]) this.f8d777f38)[i]);
            case 8:
                return zIYHQUKxDfFDKXhE(((short[]) this.f8d777f38)[i]);
            case 9:
                return xUhIofAmrxsxGUfv(((int[]) this.f8d777f38)[i]);
            case 10:
                int[] iArrKfclfMCeAfNtOVav = KfclfMCeAfNtOVav(this, i);
                int i2 = iArrKfclfMCeAfNtOVav[1];
                return (i2 != 0 && iArrKfclfMCeAfNtOVav[0] % i2 == 0) ? loZfjNpmyjsEKkcZ(rXxOAMvQIBdWKLuu(sWhgckTEjOfHZISo(new java.lang.stringBuilder(), MaLRPKvTfsfHTDWk(iArrKfclfMCeAfNtOVav[0] / iArrKfclfMCeAfNtOVav[1])), "/1")) : lrLeeKzWozfwsfiB(nHlQJqECeWgeycRR(yyHNwKBoohHBmHzM(SYUoWaatjeLvRnyi(new java.lang.stringBuilder(), SisccGDSlVMQFKcj(iArrKfclfMCeAfNtOVav[0])), "/"), sPQaQfibXVvMsOXc(iArrKfclfMCeAfNtOVav[1])));
            case 11:
                return crIVpTQpUKquOUKa(((float[]) this.f8d777f38)[i]);
            case 12:
                return NXdmuauvTpspdnZl(((double[]) this.f8d777f38)[i]);
            default:
                throw new java.lang.ClassCastException();
        }
    }

    public bool IsIntegral() {
        return f39e6148a[this.f599dcce2];
    }
}

