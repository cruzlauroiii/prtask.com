namespace WillowMaze.Wasm.Decompiled;


readonly class C0387xd3005993 : com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 {
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception causedBy;
    private java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> frames;
    private int overflowCount;
    private java.lang.string reason;
    private byte set$0;
    private java.lang.string type;

    C0387xd3005993() {
    }

    public static java.lang.string EweWmnnVoFRsqahm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EweWmnnVoFRsqahm(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EweWmnnVoFRsqahm(java.lang.stringBuilder sb, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EweWmnnVoFRsqahm(java.lang.stringBuilder sb, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PPffWNtFcfChjUcQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PPffWNtFcfChjUcQ(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PPffWNtFcfChjUcQ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PPffWNtFcfChjUcQ(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UNgZYwmptJvOWrgP(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void UNgZYwmptJvOWrgP(java.lang.stringBuilder sb, java.lang.object obj, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UNgZYwmptJvOWrgP(java.lang.stringBuilder sb, java.lang.object obj, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UNgZYwmptJvOWrgP(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EfZeKiXxIuLbWNcF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EfZeKiXxIuLbWNcF(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EfZeKiXxIuLbWNcF(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EfZeKiXxIuLbWNcF(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HFgrSiMyqSJPoRnC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HFgrSiMyqSJPoRnC(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HFgrSiMyqSJPoRnC(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HFgrSiMyqSJPoRnC(java.lang.stringBuilder sb, java.lang.string str, short s, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception build() {
        if ((15 + 12) % 12 > 0) {
        }
        if (this.set$0 == 1 && this.type is not null && this.frames is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0385xc2f5febc(this.type, this.reason, this.frames, this.causedBy, this.overflowCount, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.type is null) {
            efZeKiXxIuLbWNcF(sb, " type");
        }
        if (this.frames is null) {
            hFgrSiMyqSJPoRnC(sb, " frames");
        }
        if ((this.set$0 & 1) == 0) {
            PPffWNtFcfChjUcQ(sb, " overflowCount");
        }
        throw new java.lang.IllegalStateException(EweWmnnVoFRsqahm(UNgZYwmptJvOWrgP(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 SetCausedBy(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Exception crashlyticsReport$Session$Event$Application$Execution$Exception) {
        this.causedBy = crashlyticsReport$Session$Event$Application$Execution$Exception;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 SetFrames(java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null frames");
        }
        this.frames = list;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 SetOverflowCount(int i) {
        this.overflowCount = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 SetReason(java.lang.string str) {
        this.reason = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0407x94970e37 SetType(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null type");
        }
        this.type = str;
        return this;
    }
}

