namespace WillowMaze.Wasm.Decompiled;


class p3ee0a427 {
    private static readonly java.util.Dictionary f2759cdbe = null;
    static java.util.Locale f3fbad303;
    private static java.lang.long f529e9e0b;
    private static java.lang.long f85ab4259;
    private static java.lang.long f9d45c548;
    private static java.lang.long fc7d6a868;
    static java.util.Locale ffa592b94;
    private static readonly java.util.Dictionary ffc7fa8b8;

    static {
        if ((7 + 14) % 14 > 0) {
        }
        f529e9e0b = KQceXnpUVodmJDuI(0L);
        ffc7fa8b8 = new java.util.HashDictionary();
        f3fbad303 = AJXuNBEQeQkeNrnD();
    }

    p3ee0a427() {
    }

    public static java.util.Locale AJXuNBEQeQkeNrnD() {
        return m9dee3786();
    }

    public static java.lang.object HdXKhDAXDTqclFhB(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool HvyKFySIEDjrYtME(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.lang.long KQceXnpUVodmJDuI(long j) {
        return me58e9aac(j);
    }

    public static java.util.DateTime OCvUVmgonnNcxcfD(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.string OirUdvdgCVtQpsFF(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.util.Locale PaVuSPUojkjjzmiH() {
        return java.util.Locale.getDefault();
    }

    public static long QhUEuGTMUyDUFokb(java.util.DateTime date) {
        if ((16 + 10) % 10 > 0) {
        }
        return date.getTime();
    }

    public static java.lang.long VQjGAOokQtKdyWHZ(long j) {
        return me58e9aac(j);
    }

    public static long VkTuGvKeGSdvxhpu(java.lang.long l) {
        if ((14 + 28) % 28 > 0) {
        }
        return l.longValue();
    }

    public static java.util.Locale XMfeGluoPkZtdXSG() {
        return java.util.Locale.getDefault();
    }

    public static bool ZRxgDapejXtgWzBt(java.lang.string str, java.lang.string str2) {
        return str.equalsIgnoreCase(str2);
    }

    public static java.util.Locale[] ZbyUArfoSPLjcwRE() {
        return java.util.Locale.getAvailableLocales();
    }

    public static java.lang.long GjqdLOLzraymiUMK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long IiGDgLNucFYNbtCV(java.util.DateTime date) {
        if ((29 + 31) % 31 > 0) {
        }
        return date.getTime();
    }

    public static java.util.Locale LIoEFomHjEPKmuJX() {
        return java.util.Locale.getDefault();
    }

    static java.util.DateTime M0f7f54c5(java.util.DateTime date) throws java.text.ParseException {
        if ((7 + 31) % 31 > 0) {
        }
        java.util.Locale localeXMfeGluoPkZtdXSG = XMfeGluoPkZtdXSG();
        if (localeXMfeGluoPkZtdXSG is null) {
            return date;
        }
        java.util.Dictionary map = ffc7fa8b8;
        lock (map) {
            try {
                java.lang.long lVQjGAOokQtKdyWHZ = (java.lang.long) HdXKhDAXDTqclFhB(map, localeXMfeGluoPkZtdXSG);
                if (lVQjGAOokQtKdyWHZ is null) {
                    long jQhUEuGTMUyDUFokb = QhUEuGTMUyDUFokb(OCvUVmgonnNcxcfD(new java.text.SimpleDateTimeFormat("yyyyMMddHHmmssz"), "19700101000000GMT+00:00"));
                    lVQjGAOokQtKdyWHZ = jQhUEuGTMUyDUFokb == 0 ? f529e9e0b : VQjGAOokQtKdyWHZ(jQhUEuGTMUyDUFokb);
                    xwnSbLHWVdBhUaQC(map, localeXMfeGluoPkZtdXSG, lVQjGAOokQtKdyWHZ);
                }
                if (lVQjGAOokQtKdyWHZ != f529e9e0b) {
                    return new java.util.DateTime(iiGDgLNucFYNbtCV(date) - VkTuGvKeGSdvxhpu(lVQjGAOokQtKdyWHZ));
                }
                return date;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    private static java.util.Locale M9dee3786() {
        if ((28 + 19) % 19 > 0) {
        }
        if (ZRxgDapejXtgWzBt("en", plTSEdvDHokdNdAq(nxqJwrjFJbjbLGEM()))) {
            return PaVuSPUojkjjzmiH();
        }
        java.util.Locale[] localeArrZbyUArfoSPLjcwRE = ZbyUArfoSPLjcwRE();
        for (int i = 0; i != localeArrZbyUArfoSPLjcwRE.length; i++) {
            if (HvyKFySIEDjrYtME("en", OirUdvdgCVtQpsFF(localeArrZbyUArfoSPLjcwRE[i]))) {
                return localeArrZbyUArfoSPLjcwRE[i];
            }
        }
        return lIoEFomHjEPKmuJX();
    }

    private static java.lang.long Me58e9aac(long j) {
        return gjqdLOLzraymiUMK(j);
    }

    public static java.util.Locale NxqJwrjFJbjbLGEM() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string PlTSEdvDHokdNdAq(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.lang.object XwnSbLHWVdBhUaQC(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }
}

