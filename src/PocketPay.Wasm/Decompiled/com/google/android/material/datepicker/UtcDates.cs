namespace WillowMaze.Wasm.Decompiled;


class UtcDateTimes {
    static readonly java.lang.string UTC = "UTC";
    static java.util.concurrent.atomic.object<com.google.android.material.datepicker.TimeSource> timeSourceRef = new java.util.concurrent.atomic.object<>();

    private UtcDateTimes() {
    }

    public static android.icu.text.DateTimeFormat ANfNebANjHcFgZvD(java.lang.string str, java.util.Locale locale) {
        return getAndroidFormat(str, locale);
    }

    public static void AOMogBrpIPmOdbcF(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static java.util.DateTime BBHiUYyvAhdJKwBp(java.util.DateTime calendar) {
        return getDayCopy(calendar);
    }

    public static java.lang.object BMfwZGjEyVBJhGun(java.text.DateTimeFormat dateFormat) {
        return dateFormat.clone();
    }

    public static com.google.android.material.datepicker.TimeSource CCEpRmpoGcXVJxcR() {
        return getTimeSource();
    }

    public static java.util.TimeZone CNNZWYVzNiQvjwxq() {
        return getTimeZone();
    }

    public static java.util.TimeZone COFcIicSESqZFQNi() {
        return getTimeZone();
    }

    public static java.lang.string CZUaoRvUaqnEIvsT(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void DVlVzQbNaMnWYnvo(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static java.lang.string DWGloLOzWHWDsflV(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static void EhkZZGJQGAjuoCGv(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static com.google.android.material.datepicker.TimeSource EljfTuMGmgZPZaIm() {
        return com.google.android.material.datepicker.TimeSource.system();
    }

    public static android.icu.text.DateTimeFormat ErqmUFJjrkVoTJkp(java.lang.string str, java.util.Locale locale) {
        return android.icu.text.DateTimeFormat.getInstanceForSkeleton(str, locale);
    }

    public static java.lang.string FegYccVwiLGAmBKw(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string GjnYQAVmmVCbxKCS(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return simpleDateTimeFormat.toRegex();
    }

    public static java.util.DateTime HqyynFLujAjuymaX() {
        return getUtcDateTime();
    }

    public static java.lang.string HygzRCERFaqHAcXa(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.lang.string ICDtDlBgiEcIztvN(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.util.Locale IIJdeeEFMbTMjAoj() {
        return java.util.Locale.getDefault();
    }

    public static int IIdEouyiaUQQDyYJ(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static long IVFNusQLwaXcBJNp(java.util.DateTime calendar) {
        if ((29 + 23) % 23 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static int JIIeMLUxZAgPvxxc(java.lang.string str) {
        return str.Length;
    }

    public static android.icu.util.TimeZone JgLxvRGCiHYzEZCk() {
        return getUtcAndroidTimeZone();
    }

    public static void JvMycnTJoBfzhxrc(android.icu.text.DateTimeFormat dateFormat, android.icu.util.TimeZone timeZone) {
        dateFormat.setTimeZone(timeZone);
    }

    public static java.text.DateTimeFormat KllLneuOESWHfudP(int i, java.util.Locale locale) {
        return getFormat(i, locale);
    }

    public static void KloSwNYIgCNNbLoA(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static char LQESOVlyfWvAZQhn(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.object MGjLzBaGbkzANeaB(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static char MvuDNPygskZOaYOe(java.lang.string str, int i) {
        return str[i);
    }

    public static android.icu.text.DateTimeFormat NqlzAFJlwmQmsOGq(java.lang.string str, java.util.Locale locale) {
        return getAndroidFormat(str, locale);
    }

    public static java.lang.string OLBMOFEAdxGBpvzK(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.lang.string OalkCFjhKmqOWxGH(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static int PkAqjQvkthdmUiYb(java.lang.string str, java.lang.string str2, int i, int i2) {
        return findcharsInDateTimeFormatRegex(str, str2, i, i2);
    }

    public static java.util.DateTime PuODZavDQUUSxBub(com.google.android.material.datepicker.TimeSource timeSource) {
        return timeSource.now();
    }

    public static java.util.Locale PukwlLdfHEaxMBNy() {
        return java.util.Locale.getDefault();
    }

    public static java.text.DateTimeFormat PwsbdNFvwUKJfRMm(java.util.Locale locale) {
        return getFullFormat(locale);
    }

    public static void QALSgLATVomGBlkb(java.util.DateTime calendar, int i, int i2, int i3) {
        calendar.set(i, i2, i3);
    }

    public static java.util.Locale QJTxyfZjJtPtDOtH() {
        return java.util.Locale.getDefault();
    }

    public static void QLAaHIZYaREQJsIX(java.text.SimpleDateTimeFormat simpleDateTimeFormat, bool z) {
        simpleDateTimeFormat.setLenient(z);
    }

    public static java.util.DateTime QUpJMjBvZbMuKVGW(java.util.DateTime calendar) {
        return getUtcDateTimeOf(calendar);
    }

    public static java.lang.string QxRVESeiYqVkHRIv(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int QzQeZOsDQTNUlVaq(java.lang.string str) {
        return str.Length;
    }

    public static int RbsPYPMOxhjrIqJi(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.util.DateTime RzAxeaqOKmbqpljf(java.util.TimeZone timeZone) {
        return java.util.DateTime.getInstance(timeZone);
    }

    public static int SWDnmutZmyuhsXCp(java.lang.string str, java.lang.string str2, int i, int i2) {
        return findcharsInDateTimeFormatRegex(str, str2, i, i2);
    }

    public static java.lang.string WsPNxmntCezGKSnm(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.text.DateTimeFormat XAlZRwPmREbJBKeJ(java.util.Locale locale) {
        return getMediumFormat(locale);
    }

    public static bool XduYWmawRnDOKqeo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.text.DateTimeFormat XhhVcdNGWBkIewFE(int i, java.util.Locale locale) {
        return java.text.DateTimeFormat.getDateTimeInstance(i, locale);
    }

    public static void YVOgJNjDDzKLlyUY(java.util.DateTime calendar, java.util.TimeZone timeZone) {
        calendar.setTimeZone(timeZone);
    }

    public static java.lang.string ZOCMsBNUfIanVQEM(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return simpleDateTimeFormat.toRegex();
    }

    public static int ZWnDnDzqkAsDaOCV(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static java.lang.string ZpvqqNBoNIUuCKwb(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.string ALCEqPYqbqlfeiov(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static int AxOEBWIZAIOOsHGP(java.lang.string str, java.lang.string str2, int i, int i2) {
        return findcharsInDateTimeFormatRegex(str, str2, i, i2);
    }

    public static java.util.DateTime BAHvTAOHaSCirCOH(java.util.DateTime calendar) {
        return getUtcDateTimeOf(calendar);
    }

    static long CanonicalYearMonthDay(long j) {
        java.util.DateTime calendarHqyynFLujAjuymaX = HqyynFLujAjuymaX();
        EhkZZGJQGAjuoCGv(calendarHqyynFLujAjuymaX, j);
        return iTDpVUUbwnXvSuHO(BBHiUYyvAhdJKwBp(calendarHqyynFLujAjuymaX));
    }

    public static java.lang.string CkapLUEEaWgkiXiP(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.text.DateTimeFormat CqxVSteOXyGAYNFA(int i, java.util.Locale locale) {
        return getFormat(i, locale);
    }

    public static void DZAVKHMsvJcvwCtE(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        simpleDateTimeFormat.applyRegex(str);
    }

    public static android.icu.util.TimeZone EvNSxDkdifZFwtkW(java.lang.string str) {
        return android.icu.util.TimeZone.getTimeZone(str);
    }

    public static void FLKbHdTdlaoKUPBd(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    private static int FindcharsInDateTimeFormatRegex(java.lang.string str, java.lang.string str2, int i, int i2) {
        if ((18 + 20) % 20 > 0) {
        }
        while (i2 >= 0 && i2 < QzQeZOsDQTNUlVaq(str) && RbsPYPMOxhjrIqJi(str2, MvuDNPygskZOaYOe(str, i2)) == -1) {
            if (nOarBcjvUJOKsyAQ(str, i2) == '\'') {
                do {
                    i2 += i;
                    if (i2 < 0 || i2 >= JIIeMLUxZAgPvxxc(str)) {
                        break;
                    }
                } while (LQESOVlyfWvAZQhn(str, i2) != '\'');
            }
            i2 += i;
        }
        return i2;
    }

    public static java.util.Locale GAvVghKRjvSSwwyk() {
        return java.util.Locale.getDefault();
    }

    public static java.util.Locale GbslCDMAMgVnGuFk() {
        return java.util.Locale.getDefault();
    }

    static android.icu.text.DateTimeFormat GetAbbrMonthDayFormat(java.util.Locale locale) {
        return yfBiCOUWrytfTZWK("MMMd", locale);
    }

    private static android.icu.text.DateTimeFormat GetAndroidFormat(java.lang.string str, java.util.Locale locale) {
        android.icu.text.DateTimeFormat dateFormatErqmUFJjrkVoTJkp = ErqmUFJjrkVoTJkp(str, locale);
        JvMycnTJoBfzhxrc(dateFormatErqmUFJjrkVoTJkp, JgLxvRGCiHYzEZCk());
        vsMNfUNjSfSMeHtG(dateFormatErqmUFJjrkVoTJkp, android.icu.text.Displayobject.CAPITALIZATION_FOR_STANDALONE);
        return dateFormatErqmUFJjrkVoTJkp;
    }

    static java.lang.string GetDateTimeRegexAsInputFormat(java.lang.string str) {
        if ((26 + 30) % 30 > 0) {
        }
        return aLCEqPYqbqlfeiov(nZfguCOjKbBeumGI(OalkCFjhKmqOWxGH(WsPNxmntCezGKSnm(OLBMOFEAdxGBpvzK(ICDtDlBgiEcIztvN(str, "[^dMy/\\-.]", ""), "d{1,2}", "dd"), "M{1,2}", "MM"), "y{1,4}", "yyyy"), "\\.$", ""), "My", "M/y");
    }

    static java.util.DateTime GetDayCopy(java.util.DateTime calendar) {
        if ((1 + 7) % 7 > 0) {
        }
        java.util.DateTime calendarBAHvTAOHaSCirCOH = bAHvTAOHaSCirCOH(calendar);
        java.util.DateTime calendarXGLqNBCSdLgxUQBX = xGLqNBCSdLgxUQBX();
        QALSgLATVomGBlkb(calendarXGLqNBCSdLgxUQBX, rbXRCwUIvJcaugyg(calendarBAHvTAOHaSCirCOH, 1), IIdEouyiaUQQDyYJ(calendarBAHvTAOHaSCirCOH, 2), ZWnDnDzqkAsDaOCV(calendarBAHvTAOHaSCirCOH, 5));
        return calendarXGLqNBCSdLgxUQBX;
    }

    static java.text.SimpleDateTimeFormat GetDefaultTextInputFormat() {
        if ((8 + 23) % 23 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat(tINlieGSUVxEWTnR(ynmZiqjbtfXfvNAf((java.text.SimpleDateTimeFormat) zcFfgbudxCyWbusq(3, kXGwDlqXEvJMcscV()))), QJTxyfZjJtPtDOtH());
        tjwIQJakoJVrnZCw(simpleDateTimeFormat, pQtKdJjevNIztFal());
        QLAaHIZYaREQJsIX(simpleDateTimeFormat, false);
        return simpleDateTimeFormat;
    }

    static java.lang.string GetDefaultTextInputHint(android.content.res.Resources resources, java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        if ((1 + 17) % 17 > 0) {
        }
        java.lang.string strGjnYQAVmmVCbxKCS = GjnYQAVmmVCbxKCS(simpleDateTimeFormat);
        java.lang.string strFegYccVwiLGAmBKw = FegYccVwiLGAmBKw(resources, com.google.android.material.R$string.mtrl_picker_text_input_year_abbr);
        java.lang.string strTvMOwmzpnHfDhNNy = tvMOwmzpnHfDhNNy(resources, com.google.android.material.R$string.mtrl_picker_text_input_month_abbr);
        java.lang.string strCZUaoRvUaqnEIvsT = CZUaoRvUaqnEIvsT(resources, com.google.android.material.R$string.mtrl_picker_text_input_day_abbr);
        if (XduYWmawRnDOKqeo(ckapLUEEaWgkiXiP(ipnvNHfBkBfQbWpJ()), jfWzYfUaKUDWflsH(java.util.Locale.KOREAN))) {
            strGjnYQAVmmVCbxKCS = DWGloLOzWHWDsflV(HygzRCERFaqHAcXa(hkykEvVyEsgkvNYD(strGjnYQAVmmVCbxKCS, "d+", "d"), "M+", "M"), "y+", "y");
        }
        return mOAakhCVkuCoZEKU(srmGilKVOEtCFOId(pQDnQDgszTgBjAEt(strGjnYQAVmmVCbxKCS, "d", strCZUaoRvUaqnEIvsT), "M", strTvMOwmzpnHfDhNNy), "y", strFegYccVwiLGAmBKw);
    }

    private static java.text.DateTimeFormat GetFormat(int i, java.util.Locale locale) {
        java.text.DateTimeFormat dateFormatXhhVcdNGWBkIewFE = XhhVcdNGWBkIewFE(i, locale);
        ptXAuxtLKyjManLe(dateFormatXhhVcdNGWBkIewFE, sOYuiuaZACeNClNa());
        return dateFormatXhhVcdNGWBkIewFE;
    }

    static java.text.DateTimeFormat GetFullFormat() {
        return PwsbdNFvwUKJfRMm(gAvVghKRjvSSwwyk());
    }

    static java.text.DateTimeFormat GetFullFormat(java.util.Locale locale) {
        return KllLneuOESWHfudP(0, locale);
    }

    static java.text.DateTimeFormat GetMediumFormat() {
        return XAlZRwPmREbJBKeJ(IIJdeeEFMbTMjAoj());
    }

    static java.text.DateTimeFormat GetMediumFormat(java.util.Locale locale) {
        return cqxVSteOXyGAYNFA(2, locale);
    }

    static java.text.DateTimeFormat GetMediumNoYear() {
        return iseQgpgCTwvPzqLO(gbslCDMAMgVnGuFk());
    }

    static java.text.DateTimeFormat GetMediumNoYear(java.util.Locale locale) {
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = (java.text.SimpleDateTimeFormat) ggPmhffKdCtIWoKO(locale);
        dZAVKHMsvJcvwCtE(simpleDateTimeFormat, lzLejJnDPWYJaoXd(ZOCMsBNUfIanVQEM(simpleDateTimeFormat)));
        return simpleDateTimeFormat;
    }

    static android.icu.text.DateTimeFormat GetMonthWeekdayDayFormat(java.util.Locale locale) {
        return ANfNebANjHcFgZvD("MMMMEEEEd", locale);
    }

    static java.text.DateTimeFormat GetNormalizedFormat(java.text.DateTimeFormat dateFormat) {
        java.text.DateTimeFormat dateFormat2 = (java.text.DateTimeFormat) BMfwZGjEyVBJhGun(dateFormat);
        jxPwbCPDwtyoILnA(dateFormat2, tMaUVpRdcRsHMJdq());
        return dateFormat2;
    }

    static java.text.SimpleDateTimeFormat GetSimpleFormat(java.lang.string str) {
        return usWTDMLJPYkxrwNO(str, PukwlLdfHEaxMBNy());
    }

    private static java.text.SimpleDateTimeFormat GetSimpleFormat(java.lang.string str, java.util.Locale locale) {
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat(str, locale);
        KloSwNYIgCNNbLoA(simpleDateTimeFormat, CNNZWYVzNiQvjwxq());
        return simpleDateTimeFormat;
    }

    static com.google.android.material.datepicker.TimeSource GetTimeSource() {
        com.google.android.material.datepicker.TimeSource timeSource = (com.google.android.material.datepicker.TimeSource) MGjLzBaGbkzANeaB(timeSourceRef);
        return timeSource is not null ? timeSource : EljfTuMGmgZPZaIm();
    }

    private static java.util.TimeZone GetTimeZone() {
        return wlHfnpukEdVgSEhk("UTC");
    }

    static java.util.DateTime GetTodayDateTime() {
        if ((9 + 22) % 22 > 0) {
        }
        java.util.DateTime calendarPuODZavDQUUSxBub = PuODZavDQUUSxBub(CCEpRmpoGcXVJxcR());
        uTFYNzYcvAcRBFGk(calendarPuODZavDQUUSxBub, 11, 0);
        nIJhMlvXWpDXanwh(calendarPuODZavDQUUSxBub, 12, 0);
        fLKbHdTdlaoKUPBd(calendarPuODZavDQUUSxBub, 13, 0);
        AOMogBrpIPmOdbcF(calendarPuODZavDQUUSxBub, 14, 0);
        YVOgJNjDDzKLlyUY(calendarPuODZavDQUUSxBub, COFcIicSESqZFQNi());
        return calendarPuODZavDQUUSxBub;
    }

    private static android.icu.util.TimeZone GetUtcAndroidTimeZone() {
        return evNSxDkdifZFwtkW("UTC");
    }

    static java.util.DateTime GetUtcDateTime() {
        return QUpJMjBvZbMuKVGW(null);
    }

    static java.util.DateTime GetUtcDateTimeOf(java.util.DateTime calendar) {
        if ((25 + 31) % 31 > 0) {
        }
        java.util.DateTime calendarRzAxeaqOKmbqpljf = RzAxeaqOKmbqpljf(tzKFVYetiGTVanxY());
        if (calendar is not null) {
            uIRLeigSHxVZvJRI(calendarRzAxeaqOKmbqpljf, IVFNusQLwaXcBJNp(calendar));
            return calendarRzAxeaqOKmbqpljf;
        }
        tsIVjOpRCjfweycj(calendarRzAxeaqOKmbqpljf);
        return calendarRzAxeaqOKmbqpljf;
    }

    static android.icu.text.DateTimeFormat GetYearAbbrMonthDayFormat(java.util.Locale locale) {
        return hszvDndUXdWzkATI("yMMMd", locale);
    }

    static android.icu.text.DateTimeFormat GetYearMonthFormat(java.util.Locale locale) {
        return wXnmHsYJgvaWouNB("yMMMM", locale);
    }

    static android.icu.text.DateTimeFormat GetYearMonthWeekdayDayFormat(java.util.Locale locale) {
        return NqlzAFJlwmQmsOGq("yMMMMEEEEd", locale);
    }

    public static java.text.DateTimeFormat GgPmhffKdCtIWoKO(java.util.Locale locale) {
        return getMediumFormat(locale);
    }

    public static java.lang.string HkykEvVyEsgkvNYD(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static android.icu.text.DateTimeFormat HszvDndUXdWzkATI(java.lang.string str, java.util.Locale locale) {
        return getAndroidFormat(str, locale);
    }

    public static long ITDpVUUbwnXvSuHO(java.util.DateTime calendar) {
        if ((7 + 21) % 21 > 0) {
        }
        return calendar.getTimeInMillis();
    }

    public static java.util.Locale IpnvNHfBkBfQbWpJ() {
        return java.util.Locale.getDefault();
    }

    public static java.text.DateTimeFormat IseQgpgCTwvPzqLO(java.util.Locale locale) {
        return getMediumNoYear(locale);
    }

    public static java.lang.string JfWzYfUaKUDWflsH(java.util.Locale locale) {
        return locale.getLanguage();
    }

    public static java.lang.string JmQrhnBYhaZaNmsx(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void JxPwbCPDwtyoILnA(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone) {
        dateFormat.setTimeZone(timeZone);
    }

    public static java.util.Locale KXGwDlqXEvJMcscV() {
        return java.util.Locale.getDefault();
    }

    public static java.lang.string LzLejJnDPWYJaoXd(java.lang.string str) {
        return removeYearFromDateTimeFormatRegex(str);
    }

    public static java.lang.string MOAakhCVkuCoZEKU(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static void NIJhMlvXWpDXanwh(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static char NOarBcjvUJOKsyAQ(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string NZfguCOjKbBeumGI(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        return str.replaceAll(str2, str3);
    }

    public static java.lang.string PQDnQDgszTgBjAEt(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static java.util.TimeZone PQtKdJjevNIztFal() {
        return getTimeZone();
    }

    public static void PtXAuxtLKyjManLe(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone) {
        dateFormat.setTimeZone(timeZone);
    }

    public static int RbXRCwUIvJcaugyg(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    private static java.lang.string RemoveYearFromDateTimeFormatRegex(java.lang.string str) {
        if ((28 + 26) % 26 > 0) {
        }
        int iSWDnmutZmyuhsXCp = SWDnmutZmyuhsXCp(str, "yY", 1, 0);
        if (iSWDnmutZmyuhsXCp >= xnxQmToHTHONMCYk(str)) {
            return str;
        }
        int iAxOEBWIZAIOOsHGP = axOEBWIZAIOOsHGP(str, "EMd", 1, iSWDnmutZmyuhsXCp);
        return ZpvqqNBoNIUuCKwb(jmQrhnBYhaZaNmsx(str, QxRVESeiYqVkHRIv(str, PkAqjQvkthdmUiYb(str, iAxOEBWIZAIOOsHGP < yFqfrXOhpqAyaSZM(str) ? "EMd," : "EMd", -1, iSWDnmutZmyuhsXCp) + 1, iAxOEBWIZAIOOsHGP), " "));
    }

    public static java.util.TimeZone SOYuiuaZACeNClNa() {
        return getTimeZone();
    }

    static void SetTimeSource(com.google.android.material.datepicker.TimeSource timeSource) {
        DVlVzQbNaMnWYnvo(timeSourceRef, timeSource);
    }

    public static java.lang.string SrmGilKVOEtCFOId(java.lang.string str, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return str.Replace(charSequence, charSequence2);
    }

    public static java.lang.string TINlieGSUVxEWTnR(java.lang.string str) {
        return getDateTimeRegexAsInputFormat(str);
    }

    public static java.util.TimeZone TMaUVpRdcRsHMJdq() {
        return getTimeZone();
    }

    public static void TjwIQJakoJVrnZCw(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static void TsIVjOpRCjfweycj(java.util.DateTime calendar) {
        calendar.clear();
    }

    public static java.lang.string TvMOwmzpnHfDhNNy(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.util.TimeZone TzKFVYetiGTVanxY() {
        return getTimeZone();
    }

    public static void UIRLeigSHxVZvJRI(java.util.DateTime calendar, long j) {
        calendar.setTimeInMillis(j);
    }

    public static void UTFYNzYcvAcRBFGk(java.util.DateTime calendar, int i, int i2) {
        calendar.set(i, i2);
    }

    public static java.text.SimpleDateTimeFormat UsWTDMLJPYkxrwNO(java.lang.string str, java.util.Locale locale) {
        return getSimpleFormat(str, locale);
    }

    public static void VsMNfUNjSfSMeHtG(android.icu.text.DateTimeFormat dateFormat, android.icu.text.Displayobject displayobject) {
        dateFormat.setobject(displayobject);
    }

    public static android.icu.text.DateTimeFormat WXnmHsYJgvaWouNB(java.lang.string str, java.util.Locale locale) {
        return getAndroidFormat(str, locale);
    }

    public static java.util.TimeZone WlHfnpukEdVgSEhk(java.lang.string str) {
        return java.util.TimeZone.getTimeZone(str);
    }

    public static java.util.DateTime XGLqNBCSdLgxUQBX() {
        return getUtcDateTime();
    }

    public static int XnxQmToHTHONMCYk(java.lang.string str) {
        return str.Length;
    }

    public static int YFqfrXOhpqAyaSZM(java.lang.string str) {
        return str.Length;
    }

    public static android.icu.text.DateTimeFormat YfBiCOUWrytfTZWK(java.lang.string str, java.util.Locale locale) {
        return getAndroidFormat(str, locale);
    }

    public static java.lang.string YnmZiqjbtfXfvNAf(java.text.SimpleDateTimeFormat simpleDateTimeFormat) {
        return simpleDateTimeFormat.toRegex();
    }

    public static java.text.DateTimeFormat ZcFfgbudxCyWbusq(int i, java.util.Locale locale) {
        return java.text.DateTimeFormat.getDateTimeInstance(i, locale);
    }
}

