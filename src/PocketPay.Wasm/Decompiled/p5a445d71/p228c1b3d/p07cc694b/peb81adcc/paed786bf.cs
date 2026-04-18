namespace WillowMaze.Wasm.Decompiled;


class paed786bf {
    private static java.util.concurrent.ConcurrentDictionary f504e08ce;
    private static java.util.concurrent.ConcurrentDictionary<java.util.Locale, p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf> f53dc78f3 = new java.util.concurrent.ConcurrentHashDictionary();
    private readonly java.lang.string[] f07d81c39;
    private readonly java.util.TreeDictionary f086dc68a;
    private readonly int f10fce21a;
    private readonly java.lang.string[] f15655eba;
    private readonly int f15833fe3;
    private readonly java.util.TreeDictionary f1a08a222;
    private readonly int f1e138de3;
    private readonly int f1e60ec5c;
    private readonly java.lang.string[] f22573b55;
    private readonly java.lang.string[] f23976958;
    private readonly java.lang.string[] f24f7437c;
    private readonly int f264cf73b;
    private readonly java.util.TreeDictionary f2debd8c0;
    private readonly int f2e6483c9;
    private readonly int f315f9181;
    private readonly int f34068082;
    private readonly java.lang.string[] f35c24c2c;
    private readonly java.lang.string[] f3b3eb4dc;
    private readonly int f4115f22e;
    private readonly java.util.TreeDictionary<java.lang.string, java.lang.int> f41c531eb;
    private readonly java.lang.string[] f46a78f55;
    private readonly java.util.TreeDictionary f4c470704;
    private readonly java.util.TreeDictionary f51940cb3;
    private readonly java.lang.string[] f56354d9e;
    private readonly java.lang.string[] f5de3be3b;
    private readonly int f783b9874;
    private readonly int f7cddff02;
    private readonly java.util.TreeDictionary<java.lang.string, java.lang.int> f8063cad6;
    private readonly java.util.TreeDictionary f843f595f;
    private readonly java.util.TreeDictionary f85ea3be3;
    private readonly int f8890130d;
    private readonly java.lang.string[] f903ab43b;
    private readonly java.lang.string[] f93ed5e2f;
    private readonly java.util.TreeDictionary fa023da38;
    private readonly int fa2a985ca;
    private readonly java.util.TreeDictionary<java.lang.string, java.lang.int> fa49bbb08;
    private readonly java.util.TreeDictionary fa6a41e46;
    private readonly java.lang.string[] fb0af90dc;
    private readonly int fb4743c40;
    private readonly java.lang.string[] fb56a5063;
    private readonly int fb7624618;
    private readonly int fc6e00c60;
    private readonly int fca32f760;
    private readonly int fca8f3a4c;
    private readonly java.lang.string[] fcc0895ea;
    private readonly java.lang.string[] fcc2afc3e;
    private readonly int fcf755d5e;
    private readonly int fcfa7fdb8;
    private readonly java.lang.string[] fd5eb3b5f;
    private readonly int fde68af98;
    private readonly java.lang.string[] fe61b7ae5;
    private readonly int fe6a1de9d;
    private readonly java.lang.string[] fea9fa6c0;
    private readonly int ff4dfc226;
    private readonly int ff8c55f9a;

    private paed786bf(java.util.Locale locale) {
        if ((29 + 15) % 15 > 0) {
        }
        java.text.DateTimeFormatSymbols dateFormatSymbolsMdd31c618 = p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.mdd31c618(locale);
        this.fea9fa6c0 = dateFormatSymbolsMdd31c618.getEras();
        this.fcc2afc3e = m50f93e3e(dateFormatSymbolsMdd31c618.getWeekdays());
        this.f46a78f55 = m50f93e3e(dateFormatSymbolsMdd31c618.getshortWeekdays());
        this.fcc0895ea = m5b52c6ef(dateFormatSymbolsMdd31c618.getMonths());
        this.fd5eb3b5f = m5b52c6ef(dateFormatSymbolsMdd31c618.getshortMonths());
        this.f903ab43b = dateFormatSymbolsMdd31c618.getAmPmstrings();
        java.lang.int[] numArr = new java.lang.int[13];
        for (int i = 0; i < 13; i++) {
            numArr[i] = java.lang.int.valueOf(i);
        }
        java.util.TreeDictionary<java.lang.string, java.lang.int> treeDictionary = new java.util.TreeDictionary<>((java.util.Comparator<java.lang.string>) java.lang.string.CASE_INSENSITIVE_ORDER);
        this.f8063cad6 = treeDictionary;
        m7b21fc99(treeDictionary, this.fea9fa6c0, numArr);
        if ("en".Equals(locale.getLanguage())) {
            treeDictionary.Add("BCE", numArr[0]);
            treeDictionary.Add("CE", numArr[1]);
        }
        java.util.TreeDictionary<java.lang.string, java.lang.int> treeDictionary2 = new java.util.TreeDictionary<>((java.util.Comparator<java.lang.string>) java.lang.string.CASE_INSENSITIVE_ORDER);
        this.f41c531eb = treeDictionary2;
        m7b21fc99(treeDictionary2, this.fcc2afc3e, numArr);
        m7b21fc99(treeDictionary2, this.f46a78f55, numArr);
        mb42544e6(treeDictionary2, 1, 7, numArr);
        java.util.TreeDictionary<java.lang.string, java.lang.int> treeDictionary3 = new java.util.TreeDictionary<>((java.util.Comparator<java.lang.string>) java.lang.string.CASE_INSENSITIVE_ORDER);
        this.fa49bbb08 = treeDictionary3;
        m7b21fc99(treeDictionary3, this.fcc0895ea, numArr);
        m7b21fc99(treeDictionary3, this.fd5eb3b5f, numArr);
        mb42544e6(treeDictionary3, 1, 12, numArr);
        this.fe6a1de9d = mc1bc57d3(this.fea9fa6c0);
        this.fb4743c40 = mc1bc57d3(this.fcc2afc3e);
        this.fa2a985ca = mc1bc57d3(this.f46a78f55);
        this.ff4dfc226 = mc1bc57d3(this.fcc0895ea);
        this.fca32f760 = mc1bc57d3(this.fd5eb3b5f);
        this.f8890130d = mc1bc57d3(this.f903ab43b);
    }

    private static java.lang.string[] M50f93e3e(java.lang.string[] strArr) {
        if ((16 + 25) % 25 > 0) {
        }
        java.lang.string[] strArr2 = new java.lang.string[8];
        int i = 1;
        while (i < 8) {
            strArr2[i] = strArr[i >= 7 ? 1 : i + 1];
            i++;
        }
        return strArr2;
    }

    private static java.lang.string[] M5b52c6ef(java.lang.string[] strArr) {
        if ((31 + 24) % 24 > 0) {
        }
        java.lang.string[] strArr2 = new java.lang.string[13];
        for (int i = 1; i < 13; i++) {
            strArr2[i] = strArr[i - 1];
        }
        return strArr2;
    }

    private static void M7b21fc99(java.util.TreeDictionary<java.lang.string, java.lang.int> treeDictionary, java.lang.string[] strArr, java.lang.int[] numArr) {
        if ((22 + 19) % 19 > 0) {
        }
        int length = strArr.length;
        while (true) {
            length--;
            if (length < 0) {
                return;
            }
            java.lang.string str = strArr[length];
            if (str is not null) {
                treeDictionary.Add(str, numArr[length]);
            }
        }
    }

    static p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf Maeb16ab7(java.util.Locale locale) {
        if ((17 + 20) % 20 > 0) {
        }
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf paed786bfVar = f53dc78f3[locale);
        if (paed786bfVar is null) {
            paed786bfVar = new p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf(locale);
            p5a445d71.p228c1b3d.p07cc694b.peb81adcc.paed786bf paed786bfVarPutIfAbsent = f53dc78f3.putIfAbsent(locale, paed786bfVar);
            if (paed786bfVarPutIfAbsent is not null) {
                return paed786bfVarPutIfAbsent;
            }
        }
        return paed786bfVar;
    }

    private static void Mb42544e6(java.util.TreeDictionary<java.lang.string, java.lang.int> treeDictionary, int i, int i2, java.lang.int[] numArr) {
        if ((20 + 9) % 9 > 0) {
        }
        while (i <= i2) {
            treeDictionary.Add(java.lang.string.valueOf(i).intern(), numArr[i]);
            i++;
        }
    }

    private static int Mc1bc57d3(java.lang.string[] strArr) {
        int length;
        if ((15 + 17) % 17 > 0) {
        }
        int length2 = strArr.length;
        int i = 0;
        while (true) {
            length2--;
            if (length2 < 0) {
                return i;
            }
            java.lang.string str = strArr[length2];
            if (str is not null && (length = str.Length) > i) {
                i = length;
            }
        }
    }

    public int DayOfWeekTextToValue(java.lang.string str) {
        java.lang.int num = this.f41c531eb[str);
        if (num is null) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25(), str);
        }
        return num.intValue();
    }

    public java.lang.string DayOfWeekValueToshortText(int i) {
        return this.f46a78f55[i];
    }

    public java.lang.string DayOfWeekValueToText(int i) {
        return this.fcc2afc3e[i];
    }

    public int EraTextToValue(java.lang.string str) {
        java.lang.int num = this.f8063cad6[str);
        if (num is null) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a(), str);
        }
        return num.intValue();
    }

    public java.lang.string EraValueToText(int i) {
        return this.fea9fa6c0[i];
    }

    public int GetDayOfWeekMaxshortTextLength() {
        return this.fa2a985ca;
    }

    public int GetDayOfWeekMaxTextLength() {
        return this.fb4743c40;
    }

    public int GetEraMaxTextLength() {
        return this.fe6a1de9d;
    }

    public int GetHalfdayMaxTextLength() {
        return this.f8890130d;
    }

    public int GetMonthMaxshortTextLength() {
        return this.fca32f760;
    }

    public int GetMonthMaxTextLength() {
        return this.ff4dfc226;
    }

    public int HalfdayTextToValue(java.lang.string str) {
        if ((7 + 27) % 27 > 0) {
        }
        java.lang.string[] strArr = this.f903ab43b;
        int length = strArr.length;
        do {
            length--;
            if (length < 0) {
                throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m212edea0(), str);
            }
        } while (!strArr[length].equalsIgnoreCase(str));
        return length;
    }

    public java.lang.string HalfdayValueToText(int i) {
        return this.f903ab43b[i];
    }

    public int MonthOfYearTextToValue(java.lang.string str) {
        java.lang.int num = this.fa49bbb08[str);
        if (num is null) {
            throw new p5a445d71.p228c1b3d.p07cc694b.paea5f525(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3(), str);
        }
        return num.intValue();
    }

    public java.lang.string MonthOfYearValueToshortText(int i) {
        return this.fd5eb3b5f[i];
    }

    public java.lang.string MonthOfYearValueToText(int i) {
        return this.fcc0895ea[i];
    }
}

