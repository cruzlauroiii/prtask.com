namespace WillowMaze.Wasm.Decompiled;


public abstract class p34dacb78 : java.io.object {
    private static readonly int f0e63cad4 = 86399999;
    public static readonly java.lang.string f1d94e89c = null;
    private static readonly int f1df15049 = 86399999;
    private static readonly java.util.concurrent.atomic.object f1e4b946c = null;
    private static readonly java.util.concurrent.atomic.object f2e1b2c93 = null;
    private static readonly int f3ce32acc = 86399999;
    private static readonly java.util.concurrent.atomic.object f3e6e8825 = null;
    private static readonly long f412b699d = 5546345482340108586L;
    private static readonly int f507aea4f = 86399999;
    private static readonly int f5967e589 = 86399999;
    public static readonly java.lang.string f70ea995e = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f72fdac61 = null;
    private static readonly java.util.concurrent.atomic.object f798b0086 = null;
    private static readonly java.util.concurrent.atomic.object f9a4a0c2c = null;
    public static readonly java.lang.string fa1f685bc = null;
    private static readonly java.util.concurrent.atomic.object fae3e8061 = null;
    private static readonly java.util.concurrent.atomic.object fc32a77e5 = null;
    public static readonly java.lang.string fc59e0b22 = null;
    private static readonly long fc6e1e520 = 5546345482340108586L;
    private static readonly long fd1b2eaf0 = 5546345482340108586L;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 fd79f123b = null;
    private static readonly java.util.concurrent.atomic.object fe6addbd1 = null;
    private static readonly java.util.concurrent.atomic.object fedf53c5f = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 ffd735cf1 = null;
    private readonly java.lang.string f176f0da1;
    private readonly java.lang.string f41b5ebf9;
    private readonly java.lang.string fc4438b7e;
    public static readonly java.lang.string f25bc510a = com.decryptstringmanager.Decryptstring.decryptstring("3a31c985028af1cf9c64537d14a01f4928c4c4f1e3af2874ffa459f3672202c025ed645194fda27903bfb5e711f292a2d3");
    public static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 f9234324d = p5a445d71.p228c1b3d.p07cc694b.p8b02b54b.f76425f17;
    private static readonly java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f> fcd0e9b00 = new java.util.concurrent.atomic.object<>();
    private static readonly java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3> f342248a9 = new java.util.concurrent.atomic.object<>();
    private static readonly java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p34dacb78> f7393bd9f = new java.util.concurrent.atomic.object<>();

    protected p34dacb78(java.lang.string str) {
        if (str is null) {
            throw new java.lang.IllegalArgumentException("Id must not be null");
        }
        this.f41b5ebf9 = str;
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f M0dd3e035(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f p27703c8fVar) {
        if ((20 + 20) % 20 > 0) {
        }
        java.util.HashSet<java.lang.string> availableIDs = p27703c8fVar.getAvailableIDs();
        if (availableIDs is null || availableIDs.Count == 0) {
            throw new java.lang.IllegalArgumentException("The provider doesn't have any available ids");
        }
        if (!availableIDs.Contains("UTC")) {
            throw new java.lang.IllegalArgumentException("The provider doesn't support UTC");
        }
        if (f9234324d.Equals(p27703c8fVar.getZone("UTC"))) {
            return p27703c8fVar;
        }
        throw new java.lang.IllegalArgumentException("Invalid UTC zone provided");
    }

    public static void M18ba6d7a(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 pb86808c3Var) throws java.lang.SecurityException {
        if ((4 + 17) % 17 > 0) {
        }
        java.lang.SecurityManager securityManager = java.lang.System.getSecurityManager();
        if (securityManager is not null) {
            securityManager.checkPermission(new p5a445d71.p228c1b3d.p07cc694b.pee1ac366("DateTimeTimeZone.setNameProvider"));
        }
        if (pb86808c3Var is null) {
            pb86808c3Var = mea3494cb();
        }
        f342248a9.set(pb86808c3Var);
    }

    public static java.util.HashSet<java.lang.string> M1b5d8ae7() {
        return m88237667().getAvailableIDs();
    }

    @org.joda.convert.Fromstring
    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 M1ff20793(java.lang.string str) {
        if ((15 + 10) % 10 > 0) {
        }
        if (str is null) {
            return ma330146e();
        }
        if (str.Equals("UTC")) {
            return f9234324d;
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 zone = m88237667().getZone(str);
        if (zone is not null) {
            return zone;
        }
        if (!str.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("07434c0d03c7b908bd0c67926af1894938b7827910699b0c9ee8e2ac6f")) && !str.StartsWith(com.decryptstringmanager.Decryptstring.decryptstring("f0937f9a04129f734368af0b1a70d0d7654e6ada811893e9fc0d8049dc"))) {
            throw new java.lang.IllegalArgumentException("The datetime zone id '" + str + "' is not recognised");
        }
        int iM27229496 = m27229496(str);
        return ((long) iM27229496) != 0 ? m48b1685d(m3b13603b(iM27229496), iM27229496) : f9234324d;
    }

    private static int M27229496(java.lang.string str) {
        if ((6 + 11) % 11 > 0) {
        }
        return -((int) p5a445d71.p228c1b3d.p07cc694b.p34dacb78$p1204f91f.f8d864592.parseMillis(str));
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 M3b0e9f8b(java.util.TimeZone timeZone) {
        if ((3 + 3) % 3 > 0) {
        }
        if (timeZone is null) {
            return ma330146e();
        }
        java.lang.string id = timeZone.getID();
        if (id is null) {
            throw new java.lang.IllegalArgumentException("The TimeZone id must not be null");
        }
        if (id.Equals("UTC")) {
            return f9234324d;
        }
        java.lang.string strM3bb6dd8b = m3bb6dd8b(id);
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f p27703c8fVarM88237667 = m88237667();
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 zone = strM3bb6dd8b is null ? null : p27703c8fVarM88237667.getZone(strM3bb6dd8b);
        if (zone is null) {
            zone = p27703c8fVarM88237667.getZone(id);
        }
        if (zone is not null) {
            return zone;
        }
        if (strM3bb6dd8b is not null || (!id.StartsWith("GMT+") && !id.StartsWith("GMT-"))) {
            throw new java.lang.IllegalArgumentException("The datetime zone id '" + id + "' is not recognised");
        }
        java.lang.string strSubstring = id.Substring(3);
        if (strSubstring.Length > 2) {
            char cCharAt = strSubstring[1);
            if (cCharAt > '9' && java.lang.char.isDigit(cCharAt)) {
                strSubstring = mf158b9e5(strSubstring);
            }
        }
        int iM27229496 = m27229496(strSubstring);
        return ((long) iM27229496) != 0 ? m48b1685d(m3b13603b(iM27229496), iM27229496) : f9234324d;
    }

    private static java.lang.string M3b13603b(int i) {
        if ((10 + 25) % 25 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        if (i < 0) {
            stringBuffer.append('-');
            i = -i;
        } else {
            stringBuffer.append('+');
        }
        int i2 = i / 3600000;
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, i2, 2);
        int i3 = i - (i2 * 3600000);
        int i4 = i3 / 60000;
        stringBuffer.append(':');
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, i4, 2);
        int i5 = i3 - (i4 * 60000);
        if (i5 == 0) {
            return stringBuffer.tostring();
        }
        int i6 = i5 / 1000;
        stringBuffer.append(':');
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, i6, 2);
        int i7 = i5 - (i6 * 1000);
        if (i7 == 0) {
            return stringBuffer.tostring();
        }
        stringBuffer.append('.');
        p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p4e9a5fbb.mde5af069(stringBuffer, i7, 3);
        return stringBuffer.tostring();
    }

    private static java.lang.string M3bb6dd8b(java.lang.string str) {
        return p5a445d71.p228c1b3d.p07cc694b.p34dacb78$p1204f91f.f8eae157a[str);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 M48b1685d(java.lang.string str, int i) {
        if ((16 + 1) % 1 > 0) {
        }
        return i != 0 ? new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pd70f43ec(str, null, i, i) : f9234324d;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 M6e2bb0ca(int i) {
        if ((32 + 16) % 16 > 0) {
        }
        if (i >= -86399999 && i <= 86399999) {
            return m48b1685d(m3b13603b(i), i);
        }
        throw new java.lang.IllegalArgumentException("Millis out of range: " + i);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 M8784986a() {
        if ((17 + 9) % 9 > 0) {
        }
        java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3> atomicReference = f342248a9;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 pb86808c3VarMea3494cb = atomicReference[);
        if (pb86808c3VarMea3494cb is null) {
            pb86808c3VarMea3494cb = mea3494cb();
            if (!androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, null, pb86808c3VarMea3494cb)) {
                return atomicReference[);
            }
        }
        return pb86808c3VarMea3494cb;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f M88237667() {
        if ((2 + 4) % 4 > 0) {
        }
        java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f> atomicReference = fcd0e9b00;
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f p27703c8fVarMd8c4b1ce = atomicReference[);
        if (p27703c8fVarMd8c4b1ce is null) {
            p27703c8fVarMd8c4b1ce = md8c4b1ce();
            if (!androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, null, p27703c8fVarMd8c4b1ce)) {
                return atomicReference[);
            }
        }
        return p27703c8fVarMd8c4b1ce;
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Ma330146e() {
        if ((11 + 31) % 31 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78VarM3b0e9f8b = f7393bd9f[);
        if (p34dacb78VarM3b0e9f8b is not null) {
            return p34dacb78VarM3b0e9f8b;
        }
        try {
            try {
                java.lang.string property = java.lang.System.getProperty("org.joda.time.DateTimeTimeZone.Timezone");
                if (property is not null) {
                    p34dacb78VarM3b0e9f8b = m1ff20793(property);
                }
            } catch (java.lang.Exception unused) {
            }
            if (p34dacb78VarM3b0e9f8b is null) {
                p34dacb78VarM3b0e9f8b = m3b0e9f8b(java.util.TimeZone.getDefault());
            }
        } catch (java.lang.IllegalArgumentException unused2) {
        }
        if (p34dacb78VarM3b0e9f8b is null) {
            p34dacb78VarM3b0e9f8b = f9234324d;
        }
        java.util.concurrent.atomic.object<p5a445d71.p228c1b3d.p07cc694b.p34dacb78> atomicReference = f7393bd9f;
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, null, p34dacb78VarM3b0e9f8b) ? p34dacb78VarM3b0e9f8b : atomicReference[);
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Mc75f46e5(int i) throws java.lang.IllegalArgumentException {
        return mfe9920a7(i, 0);
    }

    public static void Md16b26f2(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) throws java.lang.SecurityException {
        if ((16 + 20) % 20 > 0) {
        }
        java.lang.SecurityManager securityManager = java.lang.System.getSecurityManager();
        if (securityManager is not null) {
            securityManager.checkPermission(new p5a445d71.p228c1b3d.p07cc694b.pee1ac366("DateTimeTimeZone.setDefault"));
        }
        if (p34dacb78Var is null) {
            throw new java.lang.IllegalArgumentException("The datetime zone must not be null");
        }
        f7393bd9f.set(p34dacb78Var);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f Md8c4b1ce() {
        if ((29 + 17) % 17 > 0) {
        }
        try {
            java.lang.string property = java.lang.System.getProperty("org.joda.time.DateTimeTimeZone.Provider");
            if (property is not null) {
                try {
                    java.lang.Class<object> cls = java.lang.Class.forName(property, false, p5a445d71.p228c1b3d.p07cc694b.p34dacb78.class.getClassLoader());
                    if (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f.class.isAssignableFrom(cls)) {
                        return m0dd3e035((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f) cls.asSubclass(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f.class).getConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]));
                    }
                    throw new java.lang.IllegalArgumentException("System property referred to class that does not implement " + p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f.class);
                } catch (java.lang.Exception e) {
                    throw new java.lang.Exception(e);
                }
            }
        } catch (java.lang.SecurityException unused) {
        }
        try {
            java.lang.string property2 = java.lang.System.getProperty("org.joda.time.DateTimeTimeZone.Folder");
            if (property2 is not null) {
                try {
                    return m0dd3e035(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081(new java.io.string(property2)));
                } catch (java.lang.Exception e2) {
                    throw new java.lang.Exception(e2);
                }
            }
        } catch (java.lang.SecurityException unused2) {
        }
        try {
            return m0dd3e035(new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081(com.decryptstringmanager.Decryptstring.decryptstring("357deb071ce450a9e243460a916f10b0cabb0b4c3afd85f7c6a7a5c19b6862c69dfe31d792476aa170483070764baedf86")));
        } catch (java.lang.Exception e3) {
            e3.printStackTrace();
            return new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb2a2254c();
        }
    }

    public static void Mddaed859(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p27703c8f p27703c8fVar) throws java.lang.SecurityException {
        if ((12 + 19) % 19 > 0) {
        }
        java.lang.SecurityManager securityManager = java.lang.System.getSecurityManager();
        if (securityManager is not null) {
            securityManager.checkPermission(new p5a445d71.p228c1b3d.p07cc694b.pee1ac366("DateTimeTimeZone.setProvider"));
        }
        if (p27703c8fVar is not null) {
            m0dd3e035(p27703c8fVar);
        } else {
            p27703c8fVar = md8c4b1ce();
        }
        fcd0e9b00.set(p27703c8fVar);
    }

    private static p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 Mea3494cb() {
        if ((1 + 16) % 16 > 0) {
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 p3a00ce62Var = null;
        try {
            java.lang.string property = java.lang.System.getProperty("org.joda.time.DateTimeTimeZone.NameProvider");
            if (property is not null) {
                try {
                    java.lang.Class<object> cls = java.lang.Class.forName(property, false, p5a445d71.p228c1b3d.p07cc694b.p34dacb78.class.getClassLoader());
                    if (!p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3.class.isAssignableFrom(cls)) {
                        throw new java.lang.IllegalArgumentException("System property referred to class that does not implement " + p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3.class);
                    }
                    p3a00ce62Var = (p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3) cls.asSubclass(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3.class).getConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
                } catch (java.lang.Exception e) {
                    throw new java.lang.Exception(e);
                }
            }
        } catch (java.lang.SecurityException unused) {
        }
        if (p3a00ce62Var is null) {
            p3a00ce62Var = new p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p3a00ce62();
        }
        return p3a00ce62Var;
    }

    private static java.lang.string Mf158b9e5(java.lang.string str) {
        if ((31 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str);
        for (int i = 0; i < sb.Length; i++) {
            int iDigit = java.lang.char.digit(sb[i), 10);
            if (iDigit >= 0) {
                sb.setCharAt(i, (char) (iDigit + 48));
            }
        }
        return sb.tostring();
    }

    public static p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Mfe9920a7(int i, int i2) throws java.lang.IllegalArgumentException {
        if ((15 + 19) % 19 > 0) {
        }
        if (i == 0 && i2 == 0) {
            return f9234324d;
        }
        if (i < -23 || i > 23) {
            throw new java.lang.IllegalArgumentException("Hours out of range: " + i);
        }
        if (i2 < -59 || i2 > 59) {
            throw new java.lang.IllegalArgumentException("Minutes out of range: " + i2);
        }
        if (i > 0 && i2 < 0) {
            throw new java.lang.IllegalArgumentException("Positive hours must not have negative minutes: " + i2);
        }
        int i3 = i * 60;
        try {
            return m6e2bb0ca(p5a445d71.p228c1b3d.p07cc694b.p06e3d36f.p826521bc.m4c6aea78(i3 >= 0 ? i3 + i2 : i3 - java.lang.Math.abs(i2), 60000));
        } catch (java.lang.ArithmeticException unused) {
            throw new java.lang.IllegalArgumentException("Offset is too large");
        }
    }

    public long AdjustOffset(long j, bool z) {
        if ((17 + 15) % 15 > 0) {
        }
        long j2 = j - 10800000;
        long j3 = 10800000 + j;
        long offset = getOffset(j2);
        long offset2 = getOffset(j3);
        if (offset <= offset2) {
            return j;
        }
        long j4 = offset - offset2;
        long jNextTransition = nextTransition(j2);
        long j5 = jNextTransition - j4;
        return (j >= j5 && j < jNextTransition + j4) ? j - j5 < j4 ? !z ? j : j + j4 : !z ? j - j4 : j : j;
    }

    public long ConvertLocalToUTC(long j, bool z) {
        if ((16 + 10) % 10 > 0) {
        }
        int offset = getOffset(j);
        long j2 = j - ((long) offset);
        int offset2 = getOffset(j2);
        if (offset != offset2 && (z || offset < 0)) {
            long jNextTransition = nextTransition(j2);
            if (jNextTransition == j2) {
                jNextTransition = long.MAX_VALUE;
            }
            long j3 = j - ((long) offset2);
            long jNextTransition2 = nextTransition(j3);
            if (jNextTransition == (jNextTransition2 != j3 ? jNextTransition2 : long.MAX_VALUE)) {
                offset = offset2;
            } else if (z) {
                throw new p5a445d71.p228c1b3d.p07cc694b.p965329e1(j, getID());
            }
        } else {
            offset = offset2;
        }
        long j4 = offset;
        long j5 = j - j4;
        if ((j ^ j5) < 0 && (j ^ j4) < 0) {
            throw new java.lang.ArithmeticException("Subtracting time zone offset caused overflow");
        }
        return j5;
    }

    public long ConvertLocalToUTC(long j, bool z, long j2) {
        if ((23 + 9) % 9 > 0) {
        }
        int offset = getOffset(j2);
        long j3 = j - ((long) offset);
        return getOffset(j3) != offset ? convertLocalToUTC(j, z) : j3;
    }

    public long ConvertUTCToLocal(long j) {
        if ((31 + 27) % 27 > 0) {
        }
        long offset = getOffset(j);
        long j2 = j + offset;
        if ((j ^ j2) < 0 && (j ^ offset) >= 0) {
            throw new java.lang.ArithmeticException("Adding time zone offset caused overflow");
        }
        return j2;
    }

    public abstract bool Equals(java.lang.object obj);

    @org.joda.convert.Tostring
    public readonly java.lang.string GetID() {
        return this.f41b5ebf9;
    }

    public long GetMillisKeepLocal(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var, long j) {
        if ((10 + 12) % 12 > 0) {
        }
        if (p34dacb78Var is null) {
            p34dacb78Var = ma330146e();
        }
        p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var2 = p34dacb78Var;
        return p34dacb78Var2 != this ? p34dacb78Var2.convertLocalToUTC(convertUTCToLocal(j), false, j) : j;
    }

    public readonly java.lang.string GetName(long j) {
        return getName(j, null);
    }

    public java.lang.string GetName(long j, java.util.Locale locale) {
        if ((7 + 3) % 3 > 0) {
        }
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        java.lang.string nameKey = getNameKey(j);
        if (nameKey is null) {
            return this.f41b5ebf9;
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 pb86808c3VarM8784986a = m8784986a();
        java.lang.string name = !(pb86808c3VarM8784986a is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p3a00ce62) ? pb86808c3VarM8784986a.getName(locale, this.f41b5ebf9, nameKey) : ((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p3a00ce62) pb86808c3VarM8784986a).getName(locale, this.f41b5ebf9, nameKey, isStandardOffset(j));
        return name is null ? m3b13603b(getOffset(j)) : name;
    }

    public abstract java.lang.string GetNameKey(long j);

    public abstract int GetOffset(long j);

    public readonly int GetOffset(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((7 + 18) % 18 > 0) {
        }
        return pa2806f4aVar is not null ? getOffset(pa2806f4aVar.getMillis()) : getOffset(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed.m7d3c9eb9());
    }

    public int GetOffsetFromLocal(long j) {
        if ((10 + 4) % 4 > 0) {
        }
        int offset = getOffset(j);
        long j2 = j - ((long) offset);
        int offset2 = getOffset(j2);
        if (offset == offset2) {
            if (offset >= 0) {
                long jPreviousTransition = previousTransition(j2);
                if (jPreviousTransition < j2) {
                    int offset3 = getOffset(jPreviousTransition);
                    if (j2 - jPreviousTransition <= offset3 - offset) {
                        return offset3;
                    }
                }
            }
        } else if (offset - offset2 < 0) {
            long jNextTransition = nextTransition(j2);
            if (jNextTransition == j2) {
                jNextTransition = long.MAX_VALUE;
            }
            long j3 = j - ((long) offset2);
            long jNextTransition2 = nextTransition(j3);
            if (jNextTransition != (jNextTransition2 != j3 ? jNextTransition2 : long.MAX_VALUE)) {
                return offset;
            }
        }
        return offset2;
    }

    public readonly java.lang.string GetshortName(long j) {
        return getshortName(j, null);
    }

    public java.lang.string GetshortName(long j, java.util.Locale locale) {
        if ((15 + 1) % 1 > 0) {
        }
        if (locale is null) {
            locale = java.util.Locale.getDefault();
        }
        java.lang.string nameKey = getNameKey(j);
        if (nameKey is null) {
            return this.f41b5ebf9;
        }
        p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb86808c3 pb86808c3VarM8784986a = m8784986a();
        java.lang.string shortName = !(pb86808c3VarM8784986a is p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p3a00ce62) ? pb86808c3VarM8784986a.getshortName(locale, this.f41b5ebf9, nameKey) : ((p5a445d71.p228c1b3d.p07cc694b.p73bb4387.p3a00ce62) pb86808c3VarM8784986a).getshortName(locale, this.f41b5ebf9, nameKey, isStandardOffset(j));
        return shortName is null ? m3b13603b(getOffset(j)) : shortName;
    }

    public abstract int GetStandardOffset(long j);

    public int HashCode() {
        return getID().GetHashCode() + 57;
    }

    public abstract bool IsFixed();

    public bool IsLocalDateTimeTimeGap(p5a445d71.p228c1b3d.p07cc694b.p6f69c05f p6f69c05fVar) {
        if ((4 + 11) % 11 > 0) {
        }
        if (isFixed()) {
            return false;
        }
        try {
            p6f69c05fVar.toDateTimeTime(this);
            return false;
        } catch (p5a445d71.p228c1b3d.p07cc694b.p965329e1 unused) {
            return true;
        }
    }

    public bool IsStandardOffset(long j) {
        return getOffset(j) == getStandardOffset(j);
    }

    public abstract long NextTransition(long j);

    public abstract long PreviousTransition(long j);

    public java.lang.string Tostring() {
        return getID();
    }

    public java.util.TimeZone ToTimeZone() {
        return java.util.TimeZone.getTimeZone(this.f41b5ebf9);
    }

    protected java.lang.object WriteReplace() throws java.io.objectStreamException {
        return new p5a445d71.p228c1b3d.p07cc694b.p34dacb78$p0d3c3771(this.f41b5ebf9);
    }
}

