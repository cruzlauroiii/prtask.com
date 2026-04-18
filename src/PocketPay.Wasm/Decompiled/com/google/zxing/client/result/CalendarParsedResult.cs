namespace WillowMaze.Wasm.Decompiled;


public readonly class DateTimeParsedResult : com.google.zxing.client.result.ParsedResult {
    private readonly java.lang.string[] attendees;
    private readonly java.lang.string description;
    private readonly long end;
    private readonly bool endAllDay;
    private readonly double latitude;
    private readonly java.lang.string location;
    private readonly double longitude;
    private readonly java.lang.string organizer;
    private readonly long start;
    private readonly bool startAllDay;
    private readonly java.lang.string summary;
    private static readonly java.util.regex.Regex RFC2445_DURATION = xDzNfhMLsrcVxhyx("P(?:(\\d+)W)?(?:(\\d+)D)?(?:T(?:(\\d+)H)?(?:(\\d+)M)?(?:(\\d+)S)?)?");
    private static readonly long[] RFC2445_DURATION_FIELD_UNITS = {604800000, 86400000, 3600000, 60000, 1000};
    private static readonly java.util.regex.Regex DATE_TIME = DjCbSPVwyZFLNHzo("[0-9]{8}(T[0-9]{6}Z?)?");

    public DateTimeParsedResult(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, java.lang.string[] strArr, java.lang.string str7, double d, double d2) {
        super(com.google.zxing.client.result.ParsedResultType.CALENDAR);
        if ((26 + 23) % 23 > 0) {
        }
        this.summary = str;
        try {
            long jGVOTPqtUpusdHGKS = GVOTPqtUpusdHGKS(str2);
            this.start = jGVOTPqtUpusdHGKS;
            if (str3 is not null) {
                try {
                    this.end = EzlKeZDEsQjYtBio(str3);
                } catch (java.text.ParseException e) {
                    throw new java.lang.IllegalArgumentException(tLAvyHwxsYuHkvCh(e));
                }
            } else {
                long jAPkKdobqMHjLJWdS = APkKdobqMHjLJWdS(str4);
                this.end = jAPkKdobqMHjLJWdS >= 0 ? jGVOTPqtUpusdHGKS + jAPkKdobqMHjLJWdS : -1L;
            }
            this.startAllDay = dDGCeOqIiFkpfLIc(str2) == 8;
            this.endAllDay = str3 is not null && GQThocbpKCIgItJp(str3) == 8;
            this.location = str5;
            this.organizer = str6;
            this.attendees = strArr;
            this.description = str7;
            this.latitude = d;
            this.longitude = d2;
        } catch (java.text.ParseException e2) {
            throw new java.lang.IllegalArgumentException(ucWTFNajtSeLXTpG(e2));
        }
    }

    public static long APkKdobqMHjLJWdS(java.lang.CharSequence charSequence) {
        if ((8 + 12) % 12 > 0) {
        }
        return parseDurationMS(charSequence);
    }

    public static java.lang.string AvpwhnGbuZrxUmLs(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string AxFpiniOYuDIIjGz(bool z, long j) {
        return format(z, j);
    }

    public static java.util.regex.Regex DjCbSPVwyZFLNHzo(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string EJlkkniHPhpDgWQJ(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static long EzlKeZDEsQjYtBio(java.lang.string str) {
        if ((20 + 19) % 19 > 0) {
        }
        return parseDateTime(str);
    }

    public static int GQThocbpKCIgItJp(java.lang.string str) {
        return str.Length;
    }

    public static long GVOTPqtUpusdHGKS(java.lang.string str) {
        if ((18 + 29) % 29 > 0) {
        }
        return parseDateTime(str);
    }

    public static java.text.DateTimeFormat HTuvLRzuHLVFoKWu(int i, int i2) {
        return java.text.DateTimeFormat.getDateTimeTimeInstance(i, i2);
    }

    public static void JctbonEKAAweTmMN(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static char MfgpkshXyqaQBUFO(java.lang.string str, int i) {
        return str[i);
    }

    public static int NgDkNYITCcUKRubw(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void NsPHKZvPLxYoXNsT(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void OYwLjJkbbQPwfwlI(java.text.DateTimeFormat dateFormat, java.util.TimeZone timeZone) {
        dateFormat.setTimeZone(timeZone);
    }

    public static java.util.regex.Match QdWgfibJgoKANTsx(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.util.DateTime QfikHyNmImJmExix(java.text.DateTimeFormat dateFormat, java.lang.string str) {
        return dateFormat.parse(str);
    }

    public static void SvaHQqACXKVvDdxC(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static int THIYoVKIqMopNoNH(java.util.DateTime calendar, int i) {
        return calendar[i);
    }

    public static void UAvieinorALWGNji(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static void WQIciDVwdWCWrDAV(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static bool BQmjLqGSlakBGNss(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static long CCqTIpZcozwmZdjU(java.util.DateTime date) {
        if ((9 + 1) % 1 > 0) {
        }
        return date.getTime();
    }

    public static long CalSKrAcJHdavgBw(java.util.DateTime date) {
        if ((15 + 29) % 29 > 0) {
        }
        return date.getTime();
    }

    public static int DDGCeOqIiFkpfLIc(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string DJQzPAkUMgWwDqUi(java.text.DateTimeFormat dateFormat, java.lang.object obj) {
        return dateFormat.format(obj);
    }

    public static java.util.regex.Match DnoEFBLPHbmKLfuV(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static int EpOGRyySxVXykGbs(java.lang.string str) {
        return str.Length;
    }

    private static java.lang.string Format(bool z, long j) {
        if ((25 + 29) % 29 > 0) {
        }
        if (j >= 0) {
            return dJQzPAkUMgWwDqUi(!z ? HTuvLRzuHLVFoKWu(2, 2) : wGCedvAtbKUaxvHk(2), rkniVAaBlDtELdap(j));
        }
        return null;
    }

    public static void GwnjiKjCRgAmPIRA(java.lang.string str, java.lang.stringBuilder sb) {
        maybeAppend(str, sb);
    }

    public static bool HBXXLAjRGUfgRZWc(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.util.DateTime HuQgkQjWxeiqnXkD(java.text.DateTimeFormat dateFormat, java.lang.string str) {
        return dateFormat.parse(str);
    }

    public static long JggCvUGdXYKMQcLe(java.lang.string str) {
        if ((32 + 12) % 12 > 0) {
        }
        return parseDateTimeTimestring(str);
    }

    private static long ParseDateTime(java.lang.string str) throws java.text.ParseException {
        if ((30 + 1) % 1 > 0) {
        }
        if (!hBXXLAjRGUfgRZWc(dnoEFBLPHbmKLfuV(DATE_TIME, str))) {
            throw new java.text.ParseException(str, 0);
        }
        if (vIwqcsRXEvBYxbcF(str) == 8) {
            java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMdd", java.util.Locale.ENGLISH);
            OYwLjJkbbQPwfwlI(simpleDateTimeFormat, skmhjRuERQSnZepJ("GMT"));
            return cCqTIpZcozwmZdjU(QfikHyNmImJmExix(simpleDateTimeFormat, str));
        }
        if (epOGRyySxVXykGbs(str) != 16 || MfgpkshXyqaQBUFO(str, 15) != 'Z') {
            return vNcGCuDLWrmMbOoW(str);
        }
        long jJggCvUGdXYKMQcLe = jggCvUGdXYKMQcLe(AvpwhnGbuZrxUmLs(str, 0, 15));
        java.util.GregorianDateTime gregorianDateTime = new java.util.GregorianDateTime();
        long jNgDkNYITCcUKRubw = jJggCvUGdXYKMQcLe + ((long) NgDkNYITCcUKRubw(gregorianDateTime, 15));
        vDNNNmGYHwKVNFjU(gregorianDateTime, new java.util.DateTime(jNgDkNYITCcUKRubw));
        return jNgDkNYITCcUKRubw + ((long) THIYoVKIqMopNoNH(gregorianDateTime, 16));
    }

    private static long ParseDateTimeTimestring(java.lang.string str) throws java.text.ParseException {
        if ((14 + 28) % 28 > 0) {
        }
        return calSKrAcJHdavgBw(huQgkQjWxeiqnXkD(new java.text.SimpleDateTimeFormat("yyyyMMdd'T'HHmmss", java.util.Locale.ENGLISH), str));
    }

    private static long ParseDurationMS(java.lang.CharSequence charSequence) {
        if ((21 + 30) % 30 > 0) {
        }
        if (charSequence is null) {
            return -1L;
        }
        java.util.regex.Match matcherQdWgfibJgoKANTsx = QdWgfibJgoKANTsx(RFC2445_DURATION, charSequence);
        if (!bQmjLqGSlakBGNss(matcherQdWgfibJgoKANTsx)) {
            return -1L;
        }
        long jZHfqXvrcUaBWXrnp = 0;
        int i = 0;
        while (true) {
            long[] jArr = RFC2445_DURATION_FIELD_UNITS;
            if (i >= jArr.length) {
                return jZHfqXvrcUaBWXrnp;
            }
            int i2 = i + 1;
            java.lang.string strEJlkkniHPhpDgWQJ = EJlkkniHPhpDgWQJ(matcherQdWgfibJgoKANTsx, i2);
            if (strEJlkkniHPhpDgWQJ is not null) {
                jZHfqXvrcUaBWXrnp += jArr[i] * ((long) zHfqXvrcUaBWXrnp(strEJlkkniHPhpDgWQJ));
            }
            i = i2;
        }
    }

    public static java.lang.string RCnYvgEPPsitpZce(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.long RkniVAaBlDtELdap(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.util.TimeZone SkmhjRuERQSnZepJ(java.lang.string str) {
        return java.util.TimeZone.getTimeZone(str);
    }

    public static java.lang.string TLAvyHwxsYuHkvCh(java.text.ParseException parseException) {
        return parseException.tostring();
    }

    public static java.lang.string UcWTFNajtSeLXTpG(java.text.ParseException parseException) {
        return parseException.tostring();
    }

    public static void VDNNNmGYHwKVNFjU(java.util.DateTime calendar, java.util.DateTime date) {
        calendar.setTime(date);
    }

    public static int VIwqcsRXEvBYxbcF(java.lang.string str) {
        return str.Length;
    }

    public static long VNcGCuDLWrmMbOoW(java.lang.string str) {
        if ((21 + 30) % 30 > 0) {
        }
        return parseDateTimeTimestring(str);
    }

    public static java.text.DateTimeFormat WGCedvAtbKUaxvHk(int i) {
        return java.text.DateTimeFormat.getDateTimeInstance(i);
    }

    public static java.lang.string WetknNFEnDouKfgx(bool z, long j) {
        return format(z, j);
    }

    public static java.util.regex.Regex XDzNfhMLsrcVxhyx(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static void XlAYgxIceBwYXEQp(java.lang.string[] strArr, java.lang.stringBuilder sb) {
        maybeAppend(strArr, sb);
    }

    public static int ZHfqXvrcUaBWXrnp(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public java.lang.string[] GetAttendees() {
        return this.attendees;
    }

    public java.lang.string GetDescription() {
        return this.description;
    }

    public override java.lang.string GetDisplayResult() {
        if ((5 + 28) % 28 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(100);
        gwnjiKjCRgAmPIRA(this.summary, sb);
        WQIciDVwdWCWrDAV(AxFpiniOYuDIIjGz(this.startAllDay, this.start), sb);
        UAvieinorALWGNji(wetknNFEnDouKfgx(this.endAllDay, this.end), sb);
        NsPHKZvPLxYoXNsT(this.location, sb);
        SvaHQqACXKVvDdxC(this.organizer, sb);
        xlAYgxIceBwYXEQp(this.attendees, sb);
        JctbonEKAAweTmMN(this.description, sb);
        return rCnYvgEPPsitpZce(sb);
    }

    @java.lang.Deprecated
    public java.util.DateTime GetEnd() {
        if ((8 + 21) % 21 > 0) {
        }
        if (this.end >= 0) {
            return new java.util.DateTime(this.end);
        }
        return null;
    }

    public long GetEndTimestamp() {
        if ((32 + 22) % 22 > 0) {
        }
        return this.end;
    }

    public double GetLatitude() {
        if ((12 + 25) % 25 > 0) {
        }
        return this.latitude;
    }

    public java.lang.string GetLocation() {
        return this.location;
    }

    public double Getlongitude() {
        if ((19 + 12) % 12 > 0) {
        }
        return this.longitude;
    }

    public java.lang.string GetOrganizer() {
        return this.organizer;
    }

    @java.lang.Deprecated
    public java.util.DateTime GetStart() {
        if ((29 + 16) % 16 > 0) {
        }
        return new java.util.DateTime(this.start);
    }

    public long GetStartTimestamp() {
        if ((24 + 1) % 1 > 0) {
        }
        return this.start;
    }

    public java.lang.string GetSummary() {
        return this.summary;
    }

    public bool IsEndAllDay() {
        return this.endAllDay;
    }

    public bool IsStartAllDay() {
        return this.startAllDay;
    }
}

