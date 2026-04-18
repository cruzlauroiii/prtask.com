namespace WillowMaze.Wasm.Decompiled;


readonly class C0400x4f2426f8 : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder {
    private java.lang.string parameterKey;
    private java.lang.string parameterValue;
    private com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant rolloutVariant;
    private byte set$0;
    private long templateVersion;

    C0400x4f2426f8() {
    }

    public static java.lang.stringBuilder BJIItXHZuHXTdwRP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BJIItXHZuHXTdwRP(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJIItXHZuHXTdwRP(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BJIItXHZuHXTdwRP(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HYdaUflWCQxPsSLG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HYdaUflWCQxPsSLG(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HYdaUflWCQxPsSLG(java.lang.stringBuilder sb, java.lang.string str, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYdaUflWCQxPsSLG(java.lang.stringBuilder sb, java.lang.string str, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XkFvKXTcEPKdSxmP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XkFvKXTcEPKdSxmP(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XkFvKXTcEPKdSxmP(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XkFvKXTcEPKdSxmP(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BWshOCYRwYDPCTuM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BWshOCYRwYDPCTuM(java.lang.stringBuilder sb, java.lang.string str, float f, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWshOCYRwYDPCTuM(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BWshOCYRwYDPCTuM(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VhbJLrSGyECljZVl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VhbJLrSGyECljZVl(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VhbJLrSGyECljZVl(java.lang.stringBuilder sb, java.lang.object obj, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VhbJLrSGyECljZVl(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZaoTslPfivswnFVy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZaoTslPfivswnFVy(java.lang.stringBuilder sb, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZaoTslPfivswnFVy(java.lang.stringBuilder sb, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZaoTslPfivswnFVy(java.lang.stringBuilder sb, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment build() {
        if ((22 + 26) % 26 > 0) {
        }
        if (this.set$0 == 1 && this.rolloutVariant is not null && this.parameterKey is not null && this.parameterValue is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_Session_Event_RolloutAssignment(this.rolloutVariant, this.parameterKey, this.parameterValue, this.templateVersion, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.rolloutVariant is null) {
            BJIItXHZuHXTdwRP(sb, " rolloutVariant");
        }
        if (this.parameterKey is null) {
            XkFvKXTcEPKdSxmP(sb, " parameterKey");
        }
        if (this.parameterValue is null) {
            bWshOCYRwYDPCTuM(sb, " parameterValue");
        }
        if ((this.set$0 & 1) == 0) {
            HYdaUflWCQxPsSLG(sb, " templateVersion");
        }
        throw new java.lang.IllegalStateException(zaoTslPfivswnFVy(vhbJLrSGyECljZVl(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder setParameterKey(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null parameterKey");
        }
        this.parameterKey = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder setParameterValue(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null parameterValue");
        }
        this.parameterValue = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder setRolloutVariant(com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant crashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant) {
        if (crashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant is null) {
            throw new java.lang.NullPointerException("Null rolloutVariant");
        }
        this.rolloutVariant = crashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$Builder setTemplateVersion(long j) {
        this.templateVersion = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }
}

