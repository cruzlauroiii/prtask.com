namespace WillowMaze.Wasm.Decompiled;


public class p10497fe1 {
    private java.lang.object f1263ff45;
    private java.lang.object fbfa1d0ff;
    private java.util.List<java.lang.object> fe1f67c18 = new java.util.List<>();
    private java.util.List fecbc6558;

    static void M09cad532(java.lang.Appendable appendable, int i) throws java.io.IOException {
        while (true) {
            i--;
            if (i < 0) {
                return;
            } else {
                appendable.append((char) 65533);
            }
        }
    }

    private void M1b8ff6b9(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var) {
        if (p0f7d4495Var is null) {
            throw new java.lang.IllegalArgumentException("No printer supplied");
        }
    }

    private bool M45e2fff0(java.lang.object obj) {
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946)) {
            return false;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) {
            return ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) obj).isParser();
        }
        return true;
    }

    private void M690300c1(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        if (p05c336c9Var is null) {
            throw new java.lang.IllegalArgumentException("No parser supplied");
        }
    }

    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 M7d602354(java.lang.object obj) {
        this.fbfa1d0ff = null;
        this.fe1f67c18.Add(obj);
        this.fe1f67c18.Add(obj);
        return this;
    }

    private p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 M7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var) {
        this.fbfa1d0ff = null;
        this.fe1f67c18.Add(p8b970cd7Var);
        this.fe1f67c18.Add(pff2c7946Var);
        return this;
    }

    static bool M82f991d4(java.lang.CharSequence charSequence, int i, java.lang.string str) {
        if ((7 + 16) % 16 > 0) {
        }
        int length = str.Length;
        if (charSequence.Length - i < length) {
            return false;
        }
        for (int i2 = 0; i2 < length; i2++) {
            char cCharAt = charSequence[i + i2);
            char cCharAt2 = str[i2);
            if (cCharAt != cCharAt2) {
                char upperCase = java.lang.char.toUpperCase(cCharAt);
                char upperCase2 = java.lang.char.toUpperCase(cCharAt2);
                if (upperCase != upperCase2 && java.lang.char.toLowerCase(upperCase) != java.lang.char.toLowerCase(upperCase2)) {
                    return false;
                }
            }
        }
        return true;
    }

    static bool M857352e2(java.lang.CharSequence charSequence, int i, java.lang.string str) {
        if ((14 + 30) % 30 > 0) {
        }
        int length = str.Length;
        if (charSequence.Length - i < length) {
            return false;
        }
        for (int i2 = 0; i2 < length; i2++) {
            if (charSequence[i + i2) != str[i2)) {
                return false;
            }
        }
        return true;
    }

    private java.lang.object Maa4a6e9f() {
        if ((21 + 19) % 19 > 0) {
        }
        java.lang.object p10497fe1_p141a5b46 = this.fbfa1d0ff;
        if (p10497fe1_p141a5b46 is null) {
            if (this.fe1f67c18.Count == 2) {
                java.lang.object obj = this.fe1f67c18[0);
                java.lang.object obj2 = this.fe1f67c18[1);
                if (obj is null) {
                    p10497fe1_p141a5b46 = obj2;
                } else if (obj == obj2 || obj2 is null) {
                    p10497fe1_p141a5b46 = obj;
                }
            }
            if (p10497fe1_p141a5b46 is null) {
                p10497fe1_p141a5b46 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46(this.fe1f67c18);
            }
            this.fbfa1d0ff = p10497fe1_p141a5b46;
        }
        return p10497fe1_p141a5b46;
    }

    private bool Mb835d02a(java.lang.object obj) {
        if (!(obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7)) {
            return false;
        }
        if (obj is p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) {
            return ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p141a5b46) obj).isPrinter();
        }
        return true;
    }

    private bool Mf76788d7(java.lang.object obj) {
        return mb835d02a(obj) || m45e2fff0(obj);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 Append(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        if (p048c1932Var is null) {
            throw new java.lang.IllegalArgumentException("No formatter supplied");
        }
        return m7d602354(p048c1932Var.getPrinter0(), p048c1932Var.getParser0());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 Append(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        m690300c1(p05c336c9Var);
        return m7d602354(null, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 Append(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var) {
        m1b8ff6b9(p0f7d4495Var);
        return m7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1.m8bf8854b(p0f7d4495Var), null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 Append(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        m1b8ff6b9(p0f7d4495Var);
        m690300c1(p05c336c9Var);
        return m7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1.m8bf8854b(p0f7d4495Var), p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9Var));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 Append(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 p0f7d4495Var, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9[] p05c336c9VarArr) {
        if ((14 + 31) % 31 > 0) {
        }
        if (p0f7d4495Var is not null) {
            m1b8ff6b9(p0f7d4495Var);
        }
        if (p05c336c9VarArr is null) {
            throw new java.lang.IllegalArgumentException("No parsers supplied");
        }
        int length = p05c336c9VarArr.length;
        int i = 0;
        if (length == 1) {
            if (p05c336c9VarArr[0] is null) {
                throw new java.lang.IllegalArgumentException("No parser supplied");
            }
            return m7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1.m8bf8854b(p0f7d4495Var), p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9VarArr[0]));
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] pff2c7946VarArr = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[length];
        while (i < length - 1) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946VarM8bf8854b = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9VarArr[i]);
            pff2c7946VarArr[i] = pff2c7946VarM8bf8854b;
            if (pff2c7946VarM8bf8854b is null) {
                throw new java.lang.IllegalArgumentException("Incomplete parser array");
            }
            i++;
        }
        pff2c7946VarArr[i] = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9VarArr[i]);
        return m7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pef0035d1.m8bf8854b(p0f7d4495Var), new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pb685da49(pff2c7946VarArr));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendCenturyOfEra(int i, int i2) {
        return appendSignedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m88c0fef2(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendClockhourOfDay(int i) {
        if ((32 + 21) % 21 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mebda781b(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendClockhourOfHalfday(int i) {
        if ((5 + 5) % 5 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m102e2fcb(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDayOfMonth(int i) {
        if ((13 + 2) % 2 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m79c2c19f(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDayOfWeek(int i) {
        if ((22 + 10) % 10 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25(), i, 1);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDayOfWeekshortText() {
        return appendshortText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDayOfWeekText() {
        return appendText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mce4dee25());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDayOfYear(int i) {
        if ((12 + 32) % 32 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9229ca79(), i, 3);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2) {
        if ((5 + 7) % 7 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        if (i2 < i) {
            i2 = i;
        }
        if (i >= 0 && i2 > 0) {
            return i > 1 ? m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p223f51d7(p51c74e65Var, i2, false, i)) : m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p8021bb5c(p51c74e65Var, i2, false));
        }
        throw new java.lang.IllegalArgumentException();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendEraText() {
        return appendText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf5c0a6a());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFixedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((1 + 27) % 27 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("Illegal number of digits: " + i);
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p51949957(p51c74e65Var, i, false));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFixedSignedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i) {
        if ((10 + 9) % 9 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("Illegal number of digits: " + i);
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p51949957(p51c74e65Var, i, true));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFraction(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2) {
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        if (i2 < i) {
            i2 = i;
        }
        if (i >= 0 && i2 > 0) {
            return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pef993538(p51c74e65Var, i, i2));
        }
        throw new java.lang.IllegalArgumentException();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFractionOfDay(int i, int i2) {
        return appendFraction(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9229ca79(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFractionOfHour(int i, int i2) {
        return appendFraction(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.ma45b2995(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFractionOfMinute(int i, int i2) {
        return appendFraction(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mfcbc0a5c(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendFractionOfSecond(int i, int i2) {
        return appendFraction(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m5379c120(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendHalfdayOfDayText() {
        return appendText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m212edea0());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendHourOfDay(int i) {
        if ((22 + 3) % 3 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.ma45b2995(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendHourOfHalfday(int i) {
        if ((14 + 20) % 20 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mbc9c6a67(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendLiteral(char c) {
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p9b5a4973(c));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendLiteral(java.lang.string str) {
        if ((2 + 25) % 25 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException("Literal must not be null");
        }
        int length = str.Length;
        return length == 0 ? this : length == 1 ? m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p9b5a4973(str[0))) : m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p7029cff1(str));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMillisOfDay(int i) {
        if ((31 + 19) % 19 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m34e1ea81(), i, 8);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMillisOfSecond(int i) {
        if ((32 + 15) % 15 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m9ca06283(), i, 3);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMinuteOfDay(int i) {
        if ((28 + 19) % 19 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mfcbc0a5c(), i, 4);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMinuteOfHour(int i) {
        if ((15 + 13) % 13 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mcf489f23(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMonthOfYear(int i) {
        if ((31 + 16) % 16 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMonthOfYearshortText() {
        return appendshortText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendMonthOfYearText() {
        return appendText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m62ae7cb3());
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 appendobject?(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 p05c336c9Var) {
        if ((20 + 32) % 32 > 0) {
        }
        m690300c1(p05c336c9Var);
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[] pff2c7946VarArr = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946[2];
        pff2c7946VarArr[0] = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pd973c505.m8bf8854b(p05c336c9Var);
        pff2c7946VarArr[1] = null;
        return m7d602354(null, new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pb685da49(pff2c7946VarArr));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendRegex(java.lang.string str) {
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29.m81a4128b(this, str);
        return this;
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendSecondOfDay(int i) {
        if ((20 + 18) % 18 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m5379c120(), i, 5);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendSecondOfMinute(int i) {
        if ((23 + 22) % 22 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.med807558(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendshortText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((12 + 3) % 3 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pf0bfb289(p51c74e65Var, true));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendSignedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var, int i, int i2) {
        if ((2 + 18) % 18 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        if (i2 < i) {
            i2 = i;
        }
        if (i >= 0 && i2 > 0) {
            return i > 1 ? m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p223f51d7(p51c74e65Var, i2, true, i)) : m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p8021bb5c(p51c74e65Var, i2, true));
        }
        throw new java.lang.IllegalArgumentException();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendText(p5a445d71.p228c1b3d.p07cc694b.p51c74e65 p51c74e65Var) {
        if ((2 + 15) % 15 > 0) {
        }
        if (p51c74e65Var is null) {
            throw new java.lang.IllegalArgumentException("Field type must not be null");
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pf0bfb289(p51c74e65Var, false));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneId() {
        if ((20 + 31) % 31 > 0) {
        }
        return m7d602354(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f.f76425f17, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p3285783f.f76425f17);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneName() {
        if ((23 + 2) % 2 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0(0, null), null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneName(java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map) {
        if ((13 + 9) % 9 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0 p10497fe1_pde585bb0 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0(0, map);
        return m7d602354(p10497fe1_pde585bb0, p10497fe1_pde585bb0);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneOffset(java.lang.string str, java.lang.string str2, bool z, int i, int i2) {
        if ((8 + 29) % 29 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p1050d6f4(str, str2, z, i, i2));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneOffset(java.lang.string str, bool z, int i, int i2) {
        if ((29 + 22) % 22 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p1050d6f4(str, str, z, i, i2));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneshortName() {
        if ((29 + 15) % 15 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0(1, null), null);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTimeZoneshortName(java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map) {
        if ((31 + 32) % 32 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0 p10497fe1_pde585bb0 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$pde585bb0(1, map);
        return m7d602354(p10497fe1_pde585bb0, p10497fe1_pde585bb0);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTwoDigitWeekyear(int i) {
        return appendTwoDigitWeekyear(i, false);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTwoDigitWeekyear(int i, bool z) {
        if ((21 + 13) % 13 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p6f2ecb2d(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4(), i, z));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTwoDigitYear(int i) {
        return appendTwoDigitYear(i, false);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendTwoDigitYear(int i, bool z) {
        if ((8 + 29) % 29 > 0) {
        }
        return m7d602354(new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1$p6f2ecb2d(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), i, z));
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendWeekOfWeekyear(int i) {
        if ((16 + 23) % 23 > 0) {
        }
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m14836d67(), i, 2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendWeekyear(int i, int i2) {
        return appendSignedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m05eb1cc4(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendYear(int i, int i2) {
        return appendSignedDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.m84cdc76c(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendYearOfCentury(int i, int i2) {
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.meff75873(), i, i2);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 AppendYearOfEra(int i, int i2) {
        return appendDecimal(p5a445d71.p228c1b3d.p07cc694b.p51c74e65.mf730c4b2(), i, i2);
    }

    public bool CanBuildFormatter() {
        return mf76788d7(maa4a6e9f());
    }

    public bool CanBuildParser() {
        return m45e2fff0(maa4a6e9f());
    }

    public bool CanBuildPrinter() {
        return mb835d02a(maa4a6e9f());
    }

    public void Clear() {
        this.fbfa1d0ff = null;
        this.fe1f67c18.clear();
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 ToFormatter() {
        if ((16 + 27) % 27 > 0) {
        }
        java.lang.object objMaa4a6e9f = maa4a6e9f();
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7 p8b970cd7Var = !mb835d02a(objMaa4a6e9f) ? null : (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7) objMaa4a6e9f;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946 pff2c7946Var = m45e2fff0(objMaa4a6e9f) ? (p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946) objMaa4a6e9f : null;
        if (p8b970cd7Var is null && pff2c7946Var is null) {
            throw new java.lang.UnsupportedOperationException("Both printing and parsing not supported");
        }
        return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932(p8b970cd7Var, pff2c7946Var);
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p05c336c9 ToParser() {
        java.lang.object objMaa4a6e9f = maa4a6e9f();
        if (m45e2fff0(objMaa4a6e9f)) {
            return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4928f97c.m8bf8854b((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pff2c7946) objMaa4a6e9f);
        }
        throw new java.lang.UnsupportedOperationException("Parsing is not supported");
    }

    public p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p0f7d4495 ToPrinter() {
        java.lang.object objMaa4a6e9f = maa4a6e9f();
        if (mb835d02a(objMaa4a6e9f)) {
            return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pf33cac8c.m8bf8854b((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p8b970cd7) objMaa4a6e9f);
        }
        throw new java.lang.UnsupportedOperationException("Printing is not supported");
    }
}

