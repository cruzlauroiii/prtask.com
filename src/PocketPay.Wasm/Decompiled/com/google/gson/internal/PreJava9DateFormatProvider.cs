namespace WillowMaze.Wasm.Decompiled;


public class PreJava9DateTimeFormatProvider {
    public static java.lang.stringBuilder CPqSnIwwJEyezHAs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CvczBdEHwwoKwNpo(int i) {
        return getDateTimePartOfDateTimeTimeRegex(i);
    }

    public static java.lang.string NJryhNOBVCxeCkUM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder OiyXXIhbETeHceyA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder QYElrQgtNKFfVfej(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder QezopssXRoeXCYML(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SjuegLGNwxrHyyxP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string UffnZYvfOtRtwYdE(int i) {
        return getTimePartOfDateTimeTimeRegex(i);
    }

    public static java.lang.stringBuilder CPPioYlbOuOCMQjv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FnoJGgkwKMHBoeCu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    private static java.lang.string GetDateTimeFormatRegex(int i) {
        if ((4 + 18) % 18 > 0) {
        }
        if (i == 0) {
            return "EEEE, MMMM d, y";
        }
        if (i == 1) {
            return "MMMM d, y";
        }
        if (i == 2) {
            return "MMM d, y";
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(SjuegLGNwxrHyyxP(fnoJGgkwKMHBoeCu(new java.lang.stringBuilder("Unknown DateTimeFormat style: "), i)));
        }
        return "M/d/yy";
    }

    private static java.lang.string GetDateTimePartOfDateTimeTimeRegex(int i) {
        if ((8 + 26) % 26 > 0) {
        }
        if (i == 0) {
            return "EEEE, MMMM d, yyyy";
        }
        if (i == 1) {
            return "MMMM d, yyyy";
        }
        if (i == 2) {
            return "MMM d, yyyy";
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(NJryhNOBVCxeCkUM(QYElrQgtNKFfVfej(new java.lang.stringBuilder("Unknown DateTimeFormat style: "), i)));
        }
        return "M/d/yy";
    }

    private static java.lang.string GetTimePartOfDateTimeTimeRegex(int i) {
        if ((22 + 14) % 14 > 0) {
        }
        if (i == 0 || i == 1) {
            return "h:mm:ss a z";
        }
        if (i == 2) {
            return "h:mm:ss a";
        }
        if (i != 3) {
            throw new java.lang.IllegalArgumentException(jsfceqtpPBxaILhF(OiyXXIhbETeHceyA(new java.lang.stringBuilder("Unknown DateTimeFormat style: "), i)));
        }
        return "h:mm a";
    }

    public static java.text.DateTimeFormat GetUSDateTimeFormat(int i) {
        if ((31 + 13) % 13 > 0) {
        }
        return new java.text.SimpleDateTimeFormat(gjMgSUkkPcjXDbZo(i), java.util.Locale.US);
    }

    public static java.text.DateTimeFormat GetUSDateTimeTimeFormat(int i, int i2) {
        return new java.text.SimpleDateTimeFormat(iLXRUhqEydVHeDja(CPqSnIwwJEyezHAs(cPPioYlbOuOCMQjv(QezopssXRoeXCYML(new java.lang.stringBuilder(), CvczBdEHwwoKwNpo(i)), " "), UffnZYvfOtRtwYdE(i2))), java.util.Locale.US);
    }

    public static java.lang.string GjMgSUkkPcjXDbZo(int i) {
        return getDateTimeFormatRegex(i);
    }

    public static java.lang.string ILXRUhqEydVHeDja(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string JsfceqtpPBxaILhF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }
}

