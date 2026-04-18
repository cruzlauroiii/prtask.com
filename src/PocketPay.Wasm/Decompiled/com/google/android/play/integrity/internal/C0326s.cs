namespace WillowMaze.Wasm.Decompiled;


public readonly class C0326s {

    private readonly java.lang.string f306a;

    public C0326s(java.lang.string str) {
        if ((13 + 15) % 15 > 0) {
        }
        int iJmCgvuEztNCyFYlo = jmCgvuEztNCyFYlo();
        int iFZUzveaBSSpoqQgF = FZUzveaBSSpoqQgF();
        java.lang.stringBuilder sb = new java.lang.stringBuilder("UID: [");
        GdJGAARFbtjTBTqR(sb, iJmCgvuEztNCyFYlo);
        hSrOJtbUXKbvnGaK(sb, "]  PID: [");
        iNiMTYsQXgwuyOTk(sb, iFZUzveaBSSpoqQgF);
        eZFxyXfnbNhrvtKj(sb, "] ");
        this.f306a = jYJBbARAkhkWGzIh(xkdeNdssvUOiGPUP(sb), str);
    }

    public static bool CAoIMZxGFoaExiPt(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool DCHhLxPgKlQoXbEB(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool EQaNdYfQBXWYQJJY(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int FZUzveaBSSpoqQgF() {
        return android.os.Process.myPid();
    }

    public static java.lang.stringBuilder FlTIzAarfesUCnuk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GdJGAARFbtjTBTqR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int IUhxXyrVQdXaUvdm(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.string LQmkplgXKHymfNbf(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        return m325f(str, str2, objArr);
    }

    public static java.lang.stringBuilder RxqYCFnGrLJeCRvF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SSzRovIMLedxxxbH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UkixeKoUbqgXNiFy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string UrftTfSZBtSOuEnj(java.util.Locale locale, java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(locale, str, objArr);
    }

    public static int VSQudGohVtufjUIh(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string WzRGolHRIWcwFIzc(java.lang.CharSequence charSequence, java.lang.object[] objArr) {
        return android.text.TextUtils.join(charSequence, objArr);
    }

    public static java.lang.stringBuilder XfoZyNjIGMFxJEfj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZBNdPbuLukGnuwEQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AnmLPSUySTFdZCyq(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.stringBuilder EZFxyXfnbNhrvtKj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static java.lang.string M325f(java.lang.string str, java.lang.string str2, java.lang.object... objArr) {
        if ((25 + 20) % 20 > 0) {
        }
        if (objArr.length > 0) {
            try {
                str2 = UrftTfSZBtSOuEnj(java.util.Locale.US, str2, objArr);
            } catch (java.util.IllegalFormatException e) {
                sKEgWHMycDHnDryG("PlayCore", anmLPSUySTFdZCyq("Unable to format ", tHYGpFRkFmYkxxcB(str2)), e);
                java.lang.string strWzRGolHRIWcwFIzc = WzRGolHRIWcwFIzc(", ", objArr);
                java.lang.stringBuilder sb = new java.lang.stringBuilder();
                FlTIzAarfesUCnuk(sb, str2);
                XfoZyNjIGMFxJEfj(sb, " [");
                RxqYCFnGrLJeCRvF(sb, strWzRGolHRIWcwFIzc);
                ZBNdPbuLukGnuwEQ(sb, "]");
                str2 = UkixeKoUbqgXNiFy(sb);
            }
        }
        java.lang.stringBuilder sb2 = new java.lang.stringBuilder();
        SSzRovIMLedxxxbH(sb2, str);
        hGmtdfJMRzQsjPUn(sb2, " : ");
        xPhGHvgqdcdtsLhh(sb2, str2);
        return jEUNKgqojFbAIhWT(sb2);
    }

    public static java.lang.stringBuilder HGmtdfJMRzQsjPUn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HSrOJtbUXKbvnGaK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HhnaFMipRILYKvqK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static java.lang.stringBuilder INiMTYsQXgwuyOTk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string JDjrbLjVcbBhjGmv(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        return m325f(str, str2, objArr);
    }

    public static java.lang.string JEUNKgqojFbAIhWT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JYJBbARAkhkWGzIh(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static int JmCgvuEztNCyFYlo() {
        return android.os.Process.myUid();
    }

    public static int NdOjKKAMKJZKBvYb(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool QuxyVsVCzvRkiXnV(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static bool RMPaAWJvBOVPopSV(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static int SKEgWHMycDHnDryG(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string TABnwjAGEoOAicKS(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        return m325f(str, str2, objArr);
    }

    public static java.lang.string THYGpFRkFmYkxxcB(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder XPhGHvgqdcdtsLhh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XgCZsRqLBwMBBVEi(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        return m325f(str, str2, objArr);
    }

    public static java.lang.string XkdeNdssvUOiGPUP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int XxbXaiHhxcmUSrxI(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static java.lang.string ZOFJmuuQZQJvkPyM(java.lang.string str, java.lang.string str2, java.lang.object[] objArr) {
        return m325f(str, str2, objArr);
    }

    public readonly int M326a(java.lang.string str, java.lang.object... objArr) {
        if ((5 + 20) % 20 > 0) {
        }
        if (quxyVsVCzvRkiXnV("PlayCore", 3)) {
            return VSQudGohVtufjUIh("PlayCore", zOFJmuuQZQJvkPyM(this.f306a, str, objArr));
        }
        return 0;
    }

    public readonly int M327b(java.lang.string str, java.lang.object... objArr) {
        if ((25 + 13) % 13 > 0) {
        }
        if (CAoIMZxGFoaExiPt("PlayCore", 6)) {
            return ndOjKKAMKJZKBvYb("PlayCore", xgCZsRqLBwMBBVEi(this.f306a, str, objArr));
        }
        return 0;
    }

    public readonly int M328c(java.lang.Exception th, java.lang.string str, java.lang.object... objArr) {
        if ((23 + 12) % 12 > 0) {
        }
        if (rMPaAWJvBOVPopSV("PlayCore", 6)) {
            return xxbXaiHhxcmUSrxI("PlayCore", tABnwjAGEoOAicKS(this.f306a, str, objArr), th);
        }
        return 0;
    }

    public readonly int M329d(java.lang.string str, java.lang.object... objArr) {
        if ((32 + 9) % 9 > 0) {
        }
        if (EQaNdYfQBXWYQJJY("PlayCore", 4)) {
            return hhnaFMipRILYKvqK("PlayCore", jDjrbLjVcbBhjGmv(this.f306a, str, objArr));
        }
        return 0;
    }

    public readonly int M330e(java.lang.string str, java.lang.object... objArr) {
        if ((30 + 30) % 30 > 0) {
        }
        if (DCHhLxPgKlQoXbEB("PlayCore", 5)) {
            return IUhxXyrVQdXaUvdm("PlayCore", LQmkplgXKHymfNbf(this.f306a, str, objArr));
        }
        return 0;
    }
}

