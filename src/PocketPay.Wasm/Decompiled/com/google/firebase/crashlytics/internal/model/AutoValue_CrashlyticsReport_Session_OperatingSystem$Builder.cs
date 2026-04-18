namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_Session_OperatingSystem$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder {
    private java.lang.string buildVersion;
    private bool jailbroken;
    private int platform;
    private byte set$0;
    private java.lang.string version;

    AutoValue_CrashlyticsReport_Session_OperatingSystem$Builder() {
    }

    public static java.lang.stringBuilder FjVlJUxCirujXggs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FjVlJUxCirujXggs(java.lang.stringBuilder sb, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FjVlJUxCirujXggs(java.lang.stringBuilder sb, java.lang.string str, char c, int i, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FjVlJUxCirujXggs(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IcVogOYcTqpjiEVH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IcVogOYcTqpjiEVH(java.lang.stringBuilder sb, java.lang.string str, float f, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IcVogOYcTqpjiEVH(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IcVogOYcTqpjiEVH(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NhsaXZGqzKJaaMDF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void NhsaXZGqzKJaaMDF(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NhsaXZGqzKJaaMDF(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NhsaXZGqzKJaaMDF(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PNLaFwcUGCyVaUxM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PNLaFwcUGCyVaUxM(java.lang.stringBuilder sb, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PNLaFwcUGCyVaUxM(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PNLaFwcUGCyVaUxM(java.lang.stringBuilder sb, java.lang.string str, int i, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DbyaangGdgPvmouY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DbyaangGdgPvmouY(java.lang.stringBuilder sb, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DbyaangGdgPvmouY(java.lang.stringBuilder sb, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DbyaangGdgPvmouY(java.lang.stringBuilder sb, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IhWYswcWiWqQjnci(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IhWYswcWiWqQjnci(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IhWYswcWiWqQjnci(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IhWYswcWiWqQjnci(java.lang.stringBuilder sb, java.lang.string str, short s, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem build() {
        if ((7 + 32) % 32 > 0) {
        }
        if (this.set$0 == 3 && this.version is not null && this.buildVersion is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_OperatingSystem(this.platform, this.version, this.buildVersion, this.jailbroken, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if ((this.set$0 & 1) == 0) {
            ihWYswcWiWqQjnci(sb, " platform");
        }
        if (this.version is null) {
            IcVogOYcTqpjiEVH(sb, " version");
        }
        if (this.buildVersion is null) {
            FjVlJUxCirujXggs(sb, " buildVersion");
        }
        if ((this.set$0 & 2) == 0) {
            PNLaFwcUGCyVaUxM(sb, " jailbroken");
        }
        throw new java.lang.IllegalStateException(dbyaangGdgPvmouY(NhsaXZGqzKJaaMDF(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder setBuildVersion(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null buildVersion");
        }
        this.buildVersion = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder setJailbroken(bool z) {
        this.jailbroken = z;
        this.set$0 = (byte) (this.set$0 | 2);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder setPlatform(int i) {
        this.platform = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$OperatingSystem$Builder setVersion(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null version");
        }
        this.version = str;
        return this;
    }
}

