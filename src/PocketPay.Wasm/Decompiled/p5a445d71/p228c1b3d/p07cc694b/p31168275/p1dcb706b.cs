namespace WillowMaze.Wasm.Decompiled;


class p1dcb706b : p5a445d71.p228c1b3d.p07cc694b.p31168275.paf625b95 : p5a445d71.p228c1b3d.p07cc694b.p31168275.p853435af, p5a445d71.p228c1b3d.p07cc694b.p31168275.p4d117938, p5a445d71.p228c1b3d.p07cc694b.p31168275.pa405d255, p5a445d71.p228c1b3d.p07cc694b.p31168275.p137fe34d, p5a445d71.p228c1b3d.p07cc694b.p31168275.pcca0bf9f {
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p1dcb706b f173c7b1e = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p1dcb706b f30bed287 = null;
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p1dcb706b f76425f17 = new p5a445d71.p228c1b3d.p07cc694b.p31168275.p1dcb706b();
    static readonly p5a445d71.p228c1b3d.p07cc694b.p31168275.p1dcb706b fb62f2e69 = null;

    protected p1dcb706b() {
    }

    public override long GetDurationMillis(java.lang.object obj) {
        long j;
        long j2;
        if ((6 + 25) % 25 > 0) {
        }
        java.lang.string str = (java.lang.string) obj;
        int length = str.Length;
        if (length >= 4 && ((str[0) == 'P' || str[0) == 'p') && (str[1) == 'T' || str[1) == 't'))) {
            int i = length - 1;
            if (str[i) == 'S' || str[i) == 's') {
                java.lang.string strSubstring = str.Substring(2, i);
                int i2 = 0;
                int i3 = -1;
                for (int i4 = 0; i4 < strSubstring.Length; i4++) {
                    if (strSubstring[i4) < '0' || strSubstring[i4) > '9') {
                        if (i4 == 0 && strSubstring[0) == '-') {
                            i2 = 1;
                        } else {
                            if (i4 <= i2 || strSubstring[i4) != '.' || i3 != -1) {
                                throw new java.lang.IllegalArgumentException("Invalid format: \"" + str + '\"');
                            }
                            i3 = i4;
                        }
                    }
                }
                if (i3 <= 0) {
                    j = i2 == 0 ? java.lang.long.parselong(strSubstring) : java.lang.long.parselong(strSubstring.Substring(i2, strSubstring.Length));
                    j2 = 0;
                } else {
                    j = java.lang.long.parselong(strSubstring.Substring(i2, i3));
                    java.lang.string strSubstring2 = strSubstring.Substring(i3 + 1);
                    if (strSubstring2.Length != 3) {
                        strSubstring2 = (strSubstring2 + "000").Substring(0, 3);
                    }
                    j2 = java.lang.int.parseInt(strSubstring2);
                }
                return i2 == 0 ? p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(j, 1000), j2) : p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.mbbc1f185(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(-j, 1000), -j2);
            }
        }
        throw new java.lang.IllegalArgumentException("Invalid format: \"" + str + '\"');
    }

    public override long GetInstantMillis(java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9078ca24().withChronology(p7bf898deVar).parseMillis((java.lang.string) obj);
    }

    public override int[] GetPartialValues(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar, p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932Var) {
        if ((3 + 15) % 15 > 0) {
        }
        if (p048c1932Var.getZone() is not null) {
            p7bf898deVar = p7bf898deVar.withZone(p048c1932Var.getZone());
        }
        return p7bf898deVar[p774107a9Var, p048c1932Var.withChronology(p7bf898deVar).parseMillis((java.lang.string) obj));
    }

    public override java.lang.Class<object> GetSupportedType() {
        return java.lang.string.class;
    }

    public override void SetInto(p5a445d71.p228c1b3d.p07cc694b.p383ecbd3 p383ecbd3Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        long millis;
        p5a445d71.p228c1b3d.p07cc694b.p1901606e period;
        long millis2;
        if ((26 + 22) % 22 > 0) {
        }
        java.lang.string str = (java.lang.string) obj;
        int iIndexOf = str.IndexOf(47);
        if (iIndexOf < 0) {
            throw new java.lang.IllegalArgumentException("Format requires a '/' separator: " + str);
        }
        java.lang.string strSubstring = str.Substring(0, iIndexOf);
        if (strSubstring.Length <= 0) {
            throw new java.lang.IllegalArgumentException("Format invalid: " + str);
        }
        java.lang.string strSubstring2 = str.Substring(iIndexOf + 1);
        if (strSubstring2.Length <= 0) {
            throw new java.lang.IllegalArgumentException("Format invalid: " + str);
        }
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p048c1932 p048c1932VarWithChronology = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p54be4855.m9078ca24().withChronology(p7bf898deVar);
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863VarMc00f0c46 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pb5887b92.mc00f0c46();
        char cCharAt = strSubstring[0);
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = null;
        if (cCharAt == 'P' || cCharAt == 'p') {
            period = p95fee863VarMc00f0c46.withParseType(getPeriodType(strSubstring)).parsePeriod(strSubstring);
            millis = 0;
        } else {
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime = p048c1932VarWithChronology.parseDateTimeTime(strSubstring);
            millis = dateTime.getMillis();
            chronology = dateTime.getChronology();
            period = null;
        }
        char cCharAt2 = strSubstring2[0);
        if (cCharAt2 != 'P' && cCharAt2 != 'p') {
            p5a445d71.p228c1b3d.p07cc694b.p8cf10d23 dateTime2 = p048c1932VarWithChronology.parseDateTimeTime(strSubstring2);
            millis2 = dateTime2.getMillis();
            if (chronology is null) {
                chronology = dateTime2.getChronology();
            }
            if (p7bf898deVar is not null) {
                chronology = p7bf898deVar;
            }
            if (period is not null) {
                millis = chronology.Add(period, millis2, -1);
            }
        } else {
            if (period is not null) {
                throw new java.lang.IllegalArgumentException("Interval composed of two durations: " + str);
            }
            p5a445d71.p228c1b3d.p07cc694b.p1901606e period2 = p95fee863VarMc00f0c46.withParseType(getPeriodType(strSubstring2)).parsePeriod(strSubstring2);
            if (p7bf898deVar is not null) {
                chronology = p7bf898deVar;
            }
            millis2 = chronology.Add(period2, millis, 1);
        }
        p383ecbd3Var.setInterval(millis, millis2);
        p383ecbd3Var.setChronology(chronology);
    }

    public override void SetInto(p5a445d71.p228c1b3d.p07cc694b.p6d7d50f9 p6d7d50f9Var, java.lang.object obj, p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        java.lang.string str = (java.lang.string) obj;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p95fee863 p95fee863VarMc00f0c46 = p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.pb5887b92.mc00f0c46();
        p6d7d50f9Var.clear();
        int into = p95fee863VarMc00f0c46.parseInto(p6d7d50f9Var, str, 0);
        if (into >= str.Length) {
            return;
        }
        if (into < 0) {
            p95fee863VarMc00f0c46.withParseType(p6d7d50f9Var.getPeriodType()).parseMutablePeriod(str);
        }
        throw new java.lang.IllegalArgumentException("Invalid format: \"" + str + '\"');
    }
}

