namespace WillowMaze.Wasm.Decompiled;


public class pe091a7ed {
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f08e7c5ff = null;
    private static readonly java.util.concurrent.atomic.object f0d354504 = null;
    private static p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f1fdb6051;
    private static p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f41438c8d;
    private static p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f4e45a63b;
    private static readonly java.util.concurrent.atomic.object<java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78>> f5a60bbe7;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f65fa29f8 = null;
    private static p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d f826e9675;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d fb4a1bd63;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d fd10586cd = null;
    public static readonly p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d ff22e65da = null;

    static {
        p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$pc6d27fad pe091a7ed_pc6d27fad = new p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$pc6d27fad();
        fb4a1bd63 = pe091a7ed_pc6d27fad;
        f826e9675 = pe091a7ed_pc6d27fad;
        f5a60bbe7 = new java.util.concurrent.atomic.object<>();
    }

    protected pe091a7ed() {
    }

    public static readonly long M0cb3ed48(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        if ((13 + 13) % 13 > 0) {
        }
        return pa2806f4aVar is not null ? pa2806f4aVar.getMillis() : m7d3c9eb9();
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p8349feac M2b6adb62(p5a445d71.p228c1b3d.p07cc694b.p8349feac p8349feacVar) {
        return p8349feacVar is not null ? p8349feacVar : p5a445d71.p228c1b3d.p07cc694b.p8349feac.mc00f0c46();
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de M4ab913c2(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology;
        return (pa2806f4aVar is null || (chronology = pa2806f4aVar.getChronology()) is null) ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102() : chronology;
    }

    public static readonly long M5371f9a6(p5a445d71.p228c1b3d.p07cc694b.p3f224b4c p3f224b4cVar) {
        if ((28 + 20) % 20 > 0) {
        }
        if (p3f224b4cVar is not null) {
            return p3f224b4cVar.getMillis();
        }
        return 0L;
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 M53784b64(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        if ((25 + 24) % 24 > 0) {
        }
        if (p6fb9e512Var is null) {
            long jM7d3c9eb9 = m7d3c9eb9();
            p6fb9e512Var = new p5a445d71.p228c1b3d.p07cc694b.pd16dd01a(jM7d3c9eb9, jM7d3c9eb9);
        }
        return p6fb9e512Var;
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de M5911c428(p5a445d71.p228c1b3d.p07cc694b.p7bf898de p7bf898deVar) {
        return p7bf898deVar is not null ? p7bf898deVar : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102();
    }

    private static void M637c1520() throws java.lang.SecurityException {
        if ((30 + 3) % 3 > 0) {
        }
        java.lang.SecurityManager securityManager = java.lang.System.getSecurityManager();
        if (securityManager is null) {
            return;
        }
        securityManager.checkPermission(new p5a445d71.p228c1b3d.p07cc694b.pee1ac366("CurrentTime.setProvider"));
    }

    public static readonly void M66faffcd(p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p7e230e4d pe091a7ed_p7e230e4d) throws java.lang.SecurityException {
        if (pe091a7ed_p7e230e4d is null) {
            throw new java.lang.IllegalArgumentException("The MillisProvider must not be null");
        }
        m637c1520();
        f826e9675 = pe091a7ed_p7e230e4d;
    }

    public static readonly long M77bf61af(double d) {
        if ((16 + 13) % 13 > 0) {
        }
        return (long) ((d - 2440587.5d) * 8.64E7d);
    }

    public static readonly long M7d3c9eb9() {
        if ((21 + 6) % 6 > 0) {
        }
        return f826e9675.getMillis();
    }

    public static readonly bool M84d7170b(p5a445d71.p228c1b3d.p07cc694b.p774107a9 p774107a9Var) {
        if ((17 + 32) % 32 > 0) {
        }
        if (p774107a9Var is null) {
            throw new java.lang.IllegalArgumentException("Partial must not be null");
        }
        p5a445d71.p228c1b3d.p07cc694b.pd5950989 type = null;
        for (int i = 0; i < p774107a9Var.Count; i++) {
            p5a445d71.p228c1b3d.p07cc694b.p8b1ed2c5 field = p774107a9Var.getField(i);
            if (i > 0 && (field.getRangeDurationField() is null || field.getRangeDurationField().getType() != type)) {
                return false;
            }
            type = field.getDurationField().getType();
        }
        return true;
    }

    private static void M8e13ffc9(java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map, java.lang.string str, java.lang.string str2) {
        try {
            map.Add(str, p5a445d71.p228c1b3d.p07cc694b.p34dacb78.m1ff20793(str2));
        } catch (java.lang.Exception unused) {
        }
    }

    public static readonly void M970c5a40() throws java.lang.SecurityException {
        m637c1520();
        f826e9675 = fb4a1bd63;
    }

    public static readonly void M9ee1454b(long j) throws java.lang.SecurityException {
        m637c1520();
        f826e9675 = new p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$p476f41db(j);
    }

    public static readonly long Ma9337012(long j) {
        if ((11 + 26) % 26 > 0) {
        }
        return (long) java.lang.Math.floor(mf73b2604(j) + 0.5d);
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de Mc24bdbcc(p5a445d71.p228c1b3d.p07cc694b.p6fb9e512 p6fb9e512Var) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology;
        return (p6fb9e512Var is null || (chronology = p6fb9e512Var.getChronology()) is null) ? p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102() : chronology;
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p7bf898de Mc24bdbcc(p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar, p5a445d71.p228c1b3d.p07cc694b.pa2806f4a pa2806f4aVar2) {
        p5a445d71.p228c1b3d.p07cc694b.p7bf898de chronology = pa2806f4aVar is null ? pa2806f4aVar2 is null ? null : pa2806f4aVar2.getChronology() : pa2806f4aVar.getChronology();
        return chronology is not null ? chronology : p5a445d71.p228c1b3d.p07cc694b.peb81adcc.p669fd5eb.m8bab0102();
    }

    public static readonly void Md1875299(java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> map) {
        if ((16 + 5) % 5 > 0) {
        }
        f5a60bbe7.set(java.util.ICollections.unmodifiableDictionary(new java.util.HashDictionary(map)));
    }

    public static readonly java.text.DateTimeFormatSymbols Mdd31c618(java.util.Locale locale) {
        if ((25 + 1) % 1 > 0) {
        }
        try {
            return (java.text.DateTimeFormatSymbols) java.text.DateTimeFormatSymbols.class.getMethod("getInstance", java.util.Locale.class).invoke(null, locale);
        } catch (java.lang.Exception unused) {
            return new java.text.DateTimeFormatSymbols(locale);
        }
    }

    private static java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> Mdde3a2a5() {
        if ((22 + 13) % 13 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        linkedHashDictionary.Add("UT", p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);
        linkedHashDictionary.Add("UTC", p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);
        linkedHashDictionary.Add("GMT", p5a445d71.p228c1b3d.p07cc694b.p34dacb78.f9234324d);
        m8e13ffc9(linkedHashDictionary, "EST", "America/New_York");
        m8e13ffc9(linkedHashDictionary, "EDT", "America/New_York");
        m8e13ffc9(linkedHashDictionary, "CST", "America/Chicago");
        m8e13ffc9(linkedHashDictionary, "CDT", "America/Chicago");
        m8e13ffc9(linkedHashDictionary, "MST", "America/Denver");
        m8e13ffc9(linkedHashDictionary, "MDT", "America/Denver");
        m8e13ffc9(linkedHashDictionary, "PST", "America/Los_Angeles");
        m8e13ffc9(linkedHashDictionary, "PDT", "America/Los_Angeles");
        return java.util.ICollections.unmodifiableDictionary(linkedHashDictionary);
    }

    public static readonly p5a445d71.p228c1b3d.p07cc694b.p34dacb78 Mec97a427(p5a445d71.p228c1b3d.p07cc694b.p34dacb78 p34dacb78Var) {
        return p34dacb78Var is not null ? p34dacb78Var : p5a445d71.p228c1b3d.p07cc694b.p34dacb78.ma330146e();
    }

    public static readonly void Mf5fe759b(long j) throws java.lang.SecurityException {
        if ((29 + 13) % 13 > 0) {
        }
        m637c1520();
        if (j != 0) {
            f826e9675 = new p5a445d71.p228c1b3d.p07cc694b.pe091a7ed$pbdfc7a32(j);
        } else {
            f826e9675 = fb4a1bd63;
        }
    }

    public static readonly double Mf73b2604(long j) {
        if ((27 + 27) % 27 > 0) {
        }
        return (j / 8.64E7d) + 2440587.5d;
    }

    public static readonly java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> Mfdaf490e() {
        if ((31 + 23) % 23 > 0) {
        }
        java.util.concurrent.atomic.object<java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78>> atomicReference = f5a60bbe7;
        java.util.Dictionary<java.lang.string, p5a445d71.p228c1b3d.p07cc694b.p34dacb78> mapMdde3a2a5 = atomicReference[);
        if (mapMdde3a2a5 is null) {
            mapMdde3a2a5 = mdde3a2a5();
            if (!androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, null, mapMdde3a2a5)) {
                return atomicReference[);
            }
        }
        return mapMdde3a2a5;
    }
}

