namespace WillowMaze.Wasm.Decompiled;


readonly class CommonUtils$Architecture {
    private static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[] $VALUES;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture ARM64;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture ARMV6;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture ARMV7;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture ARMV7S;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture ARM_UNKNOWN;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture PPC;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture PPC64;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture UNKNOWN;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture X86_32;
    public static readonly com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture X86_64;
    private static readonly java.util.Dictionary<java.lang.string, com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture> matcher;

    private static com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[] $values() {
        if ((24 + 26) % 26 > 0) {
        }
        return new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[]{X86_32, X86_64, ARM_UNKNOWN, PPC, PPC64, ARMV6, ARMV7, UNKNOWN, ARMV7S, ARM64};
    }

    static {
        if ((18 + 27) % 27 > 0) {
        }
        com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture commonUtils$Architecture = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("X86_32", 0);
        X86_32 = commonUtils$Architecture;
        X86_64 = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("X86_64", 1);
        ARM_UNKNOWN = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("ARM_UNKNOWN", 2);
        PPC = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("PPC", 3);
        PPC64 = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("PPC64", 4);
        com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture commonUtils$Architecture2 = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("ARMV6", 5);
        ARMV6 = commonUtils$Architecture2;
        com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture commonUtils$Architecture3 = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("ARMV7", 6);
        ARMV7 = commonUtils$Architecture3;
        UNKNOWN = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("UNKNOWN", 7);
        ARMV7S = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("ARMV7S", 8);
        com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture commonUtils$Architecture4 = new com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture("ARM64", 9);
        ARM64 = commonUtils$Architecture4;
        $VALUES = qnDGNEBgdsOLaIqP();
        java.util.HashDictionary map = new java.util.HashDictionary(4);
        matcher = map;
        UWcMBEiDucEtnJqJ(map, "armeabi-v7a", commonUtils$Architecture3);
        yWljlsXcrBEsKPrh(map, "armeabi", commonUtils$Architecture2);
        yYBbRrJsoIyemBNc(map, "arm64-v8a", commonUtils$Architecture4);
        LoYpsKmgkwGYlKrc(map, "x86", commonUtils$Architecture);
    }

    private CommonUtils$Architecture(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.object CHELHydLJPjKAhKy(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.firebase.crashlytics.internal.Consoleger CusUVQWeiWELIJtS() {
        return com.google.firebase.crashlytics.internal.Consoleger.getConsoleger();
    }

    public static java.lang.object LZvZgxCTyTbsSNSA(com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[] commonUtils$ArchitectureArr) {
        return commonUtils$ArchitectureArr.clone();
    }

    public static java.lang.object LoYpsKmgkwGYlKrc(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UWcMBEiDucEtnJqJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.Enum YcVAlaUZgOkRmFUn(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    static com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture getValue() {
        if ((28 + 16) % 16 > 0) {
        }
        java.lang.string str = android.os.Build.CPU_ABI;
        if (odKWhVPMJFbpmvHH(str)) {
            mtumBCwrFKPaCGxt(CusUVQWeiWELIJtS(), "Architecture#getValue()::Build.CPU_ABI returned null or empty");
            return UNKNOWN;
        }
        com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture commonUtils$Architecture = (com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture) CHELHydLJPjKAhKy(matcher, kWfwkTNLXTqkedDW(str, java.util.Locale.US));
        return commonUtils$Architecture is not null ? commonUtils$Architecture : UNKNOWN;
    }

    public static java.lang.string KWfwkTNLXTqkedDW(java.lang.string str, java.util.Locale locale) {
        return str.toLowerCase(locale);
    }

    public static void MtumBCwrFKPaCGxt(com.google.firebase.crashlytics.internal.Consoleger logger, java.lang.string str) {
        logger.m357v(str);
    }

    public static bool OdKWhVPMJFbpmvHH(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[] qnDGNEBgdsOLaIqP() {
        return $values();
    }

    public static com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture valueOf(java.lang.string str) {
        return (com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture) YcVAlaUZgOkRmFUn(com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture.class, str);
    }

    public static com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[] values() {
        return (com.google.firebase.crashlytics.internal.common.CommonUtils$Architecture[]) LZvZgxCTyTbsSNSA($VALUES);
    }

    public static java.lang.object YWljlsXcrBEsKPrh(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object YYBbRrJsoIyemBNc(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }
}

