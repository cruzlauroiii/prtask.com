namespace WillowMaze.Wasm.Decompiled;


readonly class C0378x8932d97f : com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 {
    private java.lang.string arch;
    private java.lang.string buildId;
    private java.lang.string libraryName;

    C0378x8932d97f() {
    }

    public static java.lang.stringBuilder ESDYrxGnhqtSarms(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ESDYrxGnhqtSarms(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ESDYrxGnhqtSarms(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void ESDYrxGnhqtSarms(java.lang.stringBuilder sb, java.lang.string str, float f, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FfdoSuEnvhzwZpHl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FfdoSuEnvhzwZpHl(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FfdoSuEnvhzwZpHl(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FfdoSuEnvhzwZpHl(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HGLHXlYqtpVzYWYJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HGLHXlYqtpVzYWYJ(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HGLHXlYqtpVzYWYJ(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HGLHXlYqtpVzYWYJ(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KEGVHyIttaNFmwOy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void KEGVHyIttaNFmwOy(java.lang.stringBuilder sb, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KEGVHyIttaNFmwOy(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KEGVHyIttaNFmwOy(java.lang.stringBuilder sb, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LUSsfOUKuqQOhRgS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void LUSsfOUKuqQOhRgS(java.lang.stringBuilder sb, java.lang.object obj, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LUSsfOUKuqQOhRgS(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LUSsfOUKuqQOhRgS(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$ApplicationExitInfo$BuildIdDictionarypingForArch build() {
        if ((25 + 20) % 20 > 0) {
        }
        if (this.arch is not null && this.libraryName is not null && this.buildId is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0376xb26d2aa8(this.arch, this.libraryName, this.buildId, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.arch is null) {
            ESDYrxGnhqtSarms(sb, " arch");
        }
        if (this.libraryName is null) {
            FfdoSuEnvhzwZpHl(sb, " libraryName");
        }
        if (this.buildId is null) {
            HGLHXlYqtpVzYWYJ(sb, " buildId");
        }
        throw new java.lang.IllegalStateException(kEGVHyIttaNFmwOy(lUSsfOUKuqQOhRgS(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 SetArch(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null arch");
        }
        this.arch = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 SetBuildId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null buildId");
        }
        this.buildId = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0404x11189392 SetLibraryName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null libraryName");
        }
        this.libraryName = str;
        return this;
    }
}

