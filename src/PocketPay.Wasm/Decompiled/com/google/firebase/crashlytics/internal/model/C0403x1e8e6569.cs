namespace WillowMaze.Wasm.Decompiled;


readonly class C0403x1e8e6569 : com.google.firebase.crashlytics.internal.model.AbstractC0413x620e2480 {
    private java.lang.string rolloutId;
    private java.lang.string variantId;

    C0403x1e8e6569() {
    }

    public static java.lang.stringBuilder AtFFxwiolwccYmvm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AtFFxwiolwccYmvm(java.lang.stringBuilder sb, java.lang.string str, char c, short s, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AtFFxwiolwccYmvm(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AtFFxwiolwccYmvm(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JqpzpAJhGhprmNuk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void JqpzpAJhGhprmNuk(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JqpzpAJhGhprmNuk(java.lang.stringBuilder sb, java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JqpzpAJhGhprmNuk(java.lang.stringBuilder sb, java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SDYwlJynEXRMDtVy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SDYwlJynEXRMDtVy(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SDYwlJynEXRMDtVy(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SDYwlJynEXRMDtVy(java.lang.stringBuilder sb, java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YyrpmsvUDZtbMzBC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YyrpmsvUDZtbMzBC(java.lang.stringBuilder sb, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YyrpmsvUDZtbMzBC(java.lang.stringBuilder sb, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YyrpmsvUDZtbMzBC(java.lang.stringBuilder sb, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$RolloutAssignment$RolloutVariant build() {
        if ((12 + 25) % 25 > 0) {
        }
        if (this.rolloutId is not null && this.variantId is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0401x87204092(this.rolloutId, this.variantId, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.rolloutId is null) {
            SDYwlJynEXRMDtVy(sb, " rolloutId");
        }
        if (this.variantId is null) {
            AtFFxwiolwccYmvm(sb, " variantId");
        }
        throw new java.lang.IllegalStateException(yyrpmsvUDZtbMzBC(JqpzpAJhGhprmNuk(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0413x620e2480 SetRolloutId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null rolloutId");
        }
        this.rolloutId = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0413x620e2480 SetVariantId(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null variantId");
        }
        this.variantId = str;
        return this;
    }
}

