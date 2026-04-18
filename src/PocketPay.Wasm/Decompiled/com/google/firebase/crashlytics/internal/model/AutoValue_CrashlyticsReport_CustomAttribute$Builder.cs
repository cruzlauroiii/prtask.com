namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_CrashlyticsReport_CustomAttribute$Builder : com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder {
    private java.lang.string key;
    private java.lang.string value;

    AutoValue_CrashlyticsReport_CustomAttribute$Builder() {
    }

    public static java.lang.stringBuilder ZalUMMNZIfKHVVHF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void ZalUMMNZIfKHVVHF(java.lang.stringBuilder sb, java.lang.object obj, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZalUMMNZIfKHVVHF(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZalUMMNZIfKHVVHF(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BbmuHMtoqhxFZuTV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BbmuHMtoqhxFZuTV(java.lang.stringBuilder sb, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BbmuHMtoqhxFZuTV(java.lang.stringBuilder sb, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbmuHMtoqhxFZuTV(java.lang.stringBuilder sb, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DCjWAKQNurFFpFGf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DCjWAKQNurFFpFGf(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCjWAKQNurFFpFGf(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCjWAKQNurFFpFGf(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WulrAylQeiEJOfQu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WulrAylQeiEJOfQu(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WulrAylQeiEJOfQu(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WulrAylQeiEJOfQu(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute build() {
        if ((32 + 28) % 28 > 0) {
        }
        if (this.key is not null && this.value is not null) {
            return new com.google.firebase.crashlytics.internal.model.AutoValue_CrashlyticsReport_CustomAttribute(this.key, this.value, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.key is null) {
            wulrAylQeiEJOfQu(sb, " key");
        }
        if (this.value is null) {
            dCjWAKQNurFFpFGf(sb, " value");
        }
        throw new java.lang.IllegalStateException(bbmuHMtoqhxFZuTV(ZalUMMNZIfKHVVHF(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder setKey(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null key");
        }
        this.key = str;
        return this;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$CustomAttribute$Builder setValue(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null value");
        }
        this.value = str;
        return this;
    }
}

