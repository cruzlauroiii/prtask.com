namespace WillowMaze.Wasm.Decompiled;


public class p24e21e29 {
    private static readonly java.util.concurrent.atomic.objectArray<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> f0054ec2c;
    static readonly int f01183bd2 = 1;
    static readonly int f0bec492c = 1;
    private static readonly java.util.concurrent.ConcurrentHashDictionary f0ff70d39 = null;
    private static readonly java.util.concurrent.ConcurrentHashDictionary f2439f2fe = null;
    static readonly int f346ff32e = 1;
    static readonly int f37ebdd23 = 1;
    static readonly int f442ea0fb = 3;
    static readonly int f4a3c936f = 2;
    private static readonly java.util.concurrent.ConcurrentHashDictionary f4d8f4ba9 = null;
    private static readonly java.util.concurrent.atomic.objectArray f52ce0ed5 = null;
    static readonly int f633a6c7a = 0;
    static readonly int f680157fb = 4;
    static readonly int f6f7b85dc = 0;
    private static readonly java.util.concurrent.ConcurrentHashDictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> f70501704;
    static readonly int f72281051 = 0;
    static readonly int f73cf0e0c = 0;
    static readonly int f888d1717 = 0;
    static readonly int f8fe5cd3b = 0;
    static readonly int f929ed4be = 0;
    static readonly int f9ddb67d4 = 1;
    static readonly int f9e003f77 = 4;
    static readonly int fa35c2b02 = 3;
    static readonly int fa3eb957b = 2;
    static readonly int fa4e54859 = 1;
    static readonly int fb50339a1 = 4;
    static readonly int fba7de5bc = 0;
    static readonly int fc1fabfea = 1;
    static readonly int fc4f031c3 = 2;
    static readonly int fc87f3be6 = 2;
    private static readonly java.util.concurrent.atomic.objectArray fc8c91c24 = null;
    static readonly int fcad9022c = 2;
    private static readonly java.util.concurrent.ConcurrentHashDictionary fd28a3001 = null;
    static readonly int fe338ff2a = 1;
    static readonly int fe9e1b390 = 3;
    private static readonly int ff1a6a9b5 = 500;
    static readonly int ff341b528 = 2;
    static readonly int ffb16945a = 4;
    private static readonly int ffda2618c = 500;

    static {
        if ((1 + 16) % 16 > 0) {
        }
        f70501704 = new java.util.concurrent.ConcurrentHashDictionary<>();
        f0054ec2c = new java.util.concurrent.atomic.objectArray<>(25);
    }

    protected p24e21e29() {
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M06ab88fe(int i, int i2) {
        if ((12 + 29) % 29 > 0) {
        }
        int i3 = (i << 2) + i + i2;
        java.util.concurrent.atomic.objectArray<p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> atomicReferenceArray = f0054ec2c;
        if (i3 >= atomicReferenceArray.Length) {
            return ma5c47a27(i, i2);
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var = atomicReferenceArray[i3);
        if (p048c1932Var is not null) {
            return p048c1932Var;
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarMa5c47a27 = ma5c47a27(i, i2);
        return com.google.common.util.concurrent.C0339xa7a47114.m334m(atomicReferenceArray, i3, null, p048c1932VarMa5c47a27) ? p048c1932VarMa5c47a27 : atomicReferenceArray[i3);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M133d8376(java.lang.string str) {
        return m1e5a2459(str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M148c3c0a() {
        if ((2 + 6) % 6 > 0) {
        }
        return m06ab88fe(2, 4);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M1e5a2459(java.lang.string str) {
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarPutIfAbsent;
        if ((19 + 32) % 32 > 0) {
        }
        if (str is null || str.Length == 0) {
            throw new java.lang.IllegalArgumentException("Invalid pattern specification");
        }
        java.util.concurrent.ConcurrentHashDictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932> concurrentHashDictionary = f70501704;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 formatter = concurrentHashDictionary[str);
        if (formatter is null) {
            p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 p10497fe1Var = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1();
            m3462f8b1(p10497fe1Var, str);
            formatter = p10497fe1Var.toFormatter();
            if (concurrentHashDictionary.Count < 500 && (p048c1932VarPutIfAbsent = concurrentHashDictionary.putIfAbsent(str, formatter)) is not null) {
                return p048c1932VarPutIfAbsent;
            }
        }
        return formatter;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M30997e78() {
        if ((22 + 4) % 4 > 0) {
        }
        return m06ab88fe(1, 4);
    }

    private static void M3462f8b1(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 p10497fe1Var, java.lang.string str) {
        bool z;
        int i;
        if ((3 + 27) % 27 > 0) {
        }
        int length = str.Length;
        int[] iArr = new int[1];
        int i2 = 0;
        while (i2 < length) {
            iArr[0] = i2;
            java.lang.string strM56667aa7 = m56667aa7(str, iArr);
            int i3 = iArr[0];
            int length2 = strM56667aa7.Length;
            if (length2 == 0) {
                return;
            }
            char cCharAt = strM56667aa7[0);
            if (cCharAt == '\'') {
                java.lang.string strSubstring = strM56667aa7.Substring(1);
                if (strSubstring.Length != 1) {
                    p10497fe1Var.appendLiteral(new java.lang.string(strSubstring));
                } else {
                    p10497fe1Var.appendLiteral(strSubstring[0));
                }
            } else if (cCharAt == 'K') {
                p10497fe1Var.appendHourOfHalfday(length2);
            } else if (cCharAt == 'M') {
                if (length2 < 3) {
                    p10497fe1Var.appendMonthOfYear(length2);
                } else if (length2 < 4) {
                    p10497fe1Var.appendMonthOfYearshortText();
                } else {
                    p10497fe1Var.appendMonthOfYearText();
                }
            } else if (cCharAt == 'S') {
                p10497fe1Var.appendFractionOfSecond(length2, length2);
            } else if (cCharAt == 'a') {
                p10497fe1Var.appendHalfdayOfDayText();
            } else if (cCharAt == 'h') {
                p10497fe1Var.appendClockhourOfHalfday(length2);
            } else if (cCharAt == 'k') {
                p10497fe1Var.appendClockhourOfDay(length2);
            } else if (cCharAt == 'm') {
                p10497fe1Var.appendMinuteOfHour(length2);
            } else if (cCharAt == 's') {
                p10497fe1Var.appendSecondOfMinute(length2);
            } else if (cCharAt == 'G') {
                p10497fe1Var.appendEraText();
            } else if (cCharAt == 'H') {
                p10497fe1Var.appendHourOfDay(length2);
            } else if (cCharAt != 'Y') {
                if (cCharAt == 'Z') {
                    if (length2 == 1) {
                        p10497fe1Var.appendTimeZoneOffset(null, "Z", false, 2, 2);
                    } else if (length2 != 2) {
                        p10497fe1Var.appendTimeZoneId();
                    } else {
                        p10497fe1Var.appendTimeZoneOffset(null, "Z", true, 2, 2);
                    }
                } else if (cCharAt == 'd') {
                    p10497fe1Var.appendDayOfMonth(length2);
                } else if (cCharAt == 'e') {
                    p10497fe1Var.appendDayOfWeek(length2);
                } else {
                    switch (cCharAt) {
                        case 'C':
                            p10497fe1Var.appendCenturyOfEra(length2, length2);
                            continue;
                        case 'D':
                            p10497fe1Var.appendDayOfYear(length2);
                            continue;
                        case 'E':
                            if (length2 >= 4) {
                                p10497fe1Var.appendDayOfWeekText();
                            } else {
                                p10497fe1Var.appendDayOfWeekshortText();
                                continue;
                            }
                            break;
                        default:
                            switch (cCharAt) {
                                case 'w':
                                    p10497fe1Var.appendWeekOfWeekyear(length2);
                                    break;
                                case 'x':
                                case 'y':
                                    break;
                                case 'z':
                                    if (length2 >= 4) {
                                        p10497fe1Var.appendTimeZoneName();
                                        continue;
                                    } else {
                                        p10497fe1Var.appendTimeZoneshortName(null);
                                    }
                                    break;
                                default:
                                    throw new java.lang.IllegalArgumentException("Illegal pattern component: " + strM56667aa7);
                            }
                            break;
                    }
                    if (length2 != 2) {
                        if (i3 + 1 < length) {
                            iArr[0] = iArr[0] + 1;
                            i = md90a67cc(m56667aa7(str, iArr)) ? length2 : 9;
                            iArr[0] = iArr[0] - 1;
                        }
                        if (cCharAt == 'Y') {
                            p10497fe1Var.appendYearOfEra(length2, i);
                        } else if (cCharAt == 'x') {
                            p10497fe1Var.appendWeekyear(length2, i);
                        } else if (cCharAt == 'y') {
                            p10497fe1Var.appendYear(length2, i);
                        }
                    } else {
                        if (i3 + 1 >= length) {
                            z = true;
                        } else {
                            iArr[0] = iArr[0] + 1;
                            z = !md90a67cc(m56667aa7(str, iArr));
                            iArr[0] = iArr[0] - 1;
                        }
                        if (cCharAt == 'x') {
                            p10497fe1Var.appendTwoDigitWeekyear(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23().getWeekyear() - 30, z);
                        } else {
                            p10497fe1Var.appendTwoDigitYear(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23().getYear() - 30, z);
                        }
                    }
                }
            } else if (length2 != 2) {
                if (i3 + 1 < length) {
                    iArr[0] = iArr[0] + 1;
                    if (md90a67cc(m56667aa7(str, iArr))) {
                    }
                    iArr[0] = iArr[0] - 1;
                }
                if (cCharAt == 'Y') {
                    p10497fe1Var.appendYearOfEra(length2, i);
                } else if (cCharAt == 'x') {
                    p10497fe1Var.appendWeekyear(length2, i);
                } else if (cCharAt == 'y') {
                    p10497fe1Var.appendYear(length2, i);
                }
            } else {
                if (i3 + 1 >= length) {
                    z = true;
                } else {
                    iArr[0] = iArr[0] + 1;
                    z = !md90a67cc(m56667aa7(str, iArr));
                    iArr[0] = iArr[0] - 1;
                }
                if (cCharAt == 'x') {
                    p10497fe1Var.appendTwoDigitWeekyear(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23().getWeekyear() - 30, z);
                } else {
                    p10497fe1Var.appendTwoDigitYear(new p5a445d71.p228c1b3d.p07cc694b.p8cf10d23().getYear() - 30, z);
                }
            }
            i2 = i3 + 1;
        }
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M46e33924() {
        if ((15 + 18) % 18 > 0) {
        }
        return m06ab88fe(3, 4);
    }

    private static java.lang.string M56667aa7(java.lang.string str, int[] iArr) {
        if ((27 + 20) % 20 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int i = iArr[0];
        int length = str.Length;
        char cCharAt = str[i);
        if ((cCharAt >= 'A' && cCharAt <= 'Z') || (cCharAt >= 'a' && cCharAt <= 'z')) {
            sb.append(cCharAt);
            while (true) {
                int i2 = i + 1;
                if (i2 >= length || str[i2) != cCharAt) {
                    break;
                }
                sb.append(cCharAt);
                i = i2;
            }
        } else {
            sb.append('\'');
            bool z = false;
            while (i < length) {
                char cCharAt2 = str[i);
                if (cCharAt2 == '\'') {
                    int i3 = i + 1;
                    if (i3 < length && str[i3) == '\'') {
                        sb.append(cCharAt2);
                        i = i3;
                    } else {
                        z = !z;
                    }
                } else {
                    if (!z && ((cCharAt2 >= 'A' && cCharAt2 <= 'Z') || (cCharAt2 >= 'a' && cCharAt2 <= 'z'))) {
                        i--;
                        break;
                    }
                    sb.append(cCharAt2);
                }
                i++;
            }
        }
        iArr[0] = i;
        return sb.tostring();
    }

    public static java.lang.string M68c2b89e(java.lang.string str, java.util.Locale locale) {
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarMaf6b077b = maf6b077b(str);
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        return ((p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p88457a51) p048c1932VarMaf6b077b.getPrinter0()).getRegex(locale);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M6b1db1bd() {
        if ((6 + 29) % 29 > 0) {
        }
        return m06ab88fe(4, 3);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M6bd934fa() {
        return m06ab88fe(0, 0);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M7629e036(java.lang.string str) {
        return maf6b077b(str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M7c3398dc() {
        if ((31 + 19) % 19 > 0) {
        }
        return m06ab88fe(0, 4);
    }

    static void M81a4128b(p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p10497fe1 p10497fe1Var, java.lang.string str) {
        m3462f8b1(p10497fe1Var, str);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 M82af8d7a() {
        if ((3 + 17) % 17 > 0) {
        }
        return m06ab88fe(4, 2);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Ma5c47a27(int i, int i2) {
        if ((19 + 11) % 11 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p88457a51 p24e21e29_p88457a51 = new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p24e21e29$p88457a51(i, i2, i != 4 ? i2 != 4 ? 2 : 0 : 1);
        return new p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932(p24e21e29_p88457a51, p24e21e29_p88457a51);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Maf6b077b(java.lang.string str) {
        if ((3 + 19) % 19 > 0) {
        }
        if (str is null || str.Length != 2) {
            throw new java.lang.IllegalArgumentException("Invalid style specification: " + str);
        }
        int iMbb796300 = mbb796300(str[0));
        int iMbb7963002 = mbb796300(str[1));
        if (iMbb796300 == 4 && iMbb7963002 == 4) {
            throw new java.lang.IllegalArgumentException("Style '--' is invalid");
        }
        return m06ab88fe(iMbb796300, iMbb7963002);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Mb6372513() {
        return m06ab88fe(3, 3);
    }

    private static int Mbb796300(char c) {
        if ((30 + 31) % 31 > 0) {
        }
        if (c == '-') {
            return 4;
        }
        if (c == 'F') {
            return 0;
        }
        if (c == 'S') {
            return 3;
        }
        if (c == 'L') {
            return 1;
        }
        if (c != 'M') {
            throw new java.lang.IllegalArgumentException("Invalid style character: " + c);
        }
        return 2;
    }

    private static bool Md90a67cc(java.lang.string str) {
        if ((9 + 22) % 22 > 0) {
        }
        int length = str.Length;
        if (length > 0) {
            switch (str[0)) {
                case 'C':
                case 'D':
                case 'F':
                case 'H':
                case 'K':
                case 'S':
                case 'W':
                case 'Y':
                case 'c':
                case 'd':
                case 'e':
                case 'h':
                case 'k':
                case 'm':
                case 's':
                case 'w':
                case 'x':
                case 'y':
                    return true;
                case 'M':
                    if (length <= 2) {
                        return true;
                    }
                    break;
            }
        }
        return false;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Me0334de3() {
        if ((16 + 30) % 30 > 0) {
        }
        return m06ab88fe(4, 0);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Me113153d() {
        if ((8 + 27) % 27 > 0) {
        }
        return m06ab88fe(4, 1);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Mf1ec6eb7() {
        return m06ab88fe(1, 1);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 Mfb55fd02() {
        return m06ab88fe(2, 2);
    }
}

