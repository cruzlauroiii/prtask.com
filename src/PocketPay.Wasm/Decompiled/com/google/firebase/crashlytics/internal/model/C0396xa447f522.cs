namespace WillowMaze.Wasm.Decompiled;


readonly class C0396xa447f522 : com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 {
    private java.lang.string file;
    private int importance;
    private long offset;
    private long pc;
    private byte set$0;
    private java.lang.string symbol;

    C0396xa447f522() {
    }

    public static java.lang.stringBuilder GiknshaPOBHglXyU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void GiknshaPOBHglXyU(java.lang.stringBuilder sb, java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GiknshaPOBHglXyU(java.lang.stringBuilder sb, java.lang.object obj, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GiknshaPOBHglXyU(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PmbjBQqCjgoBmPnK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PmbjBQqCjgoBmPnK(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PmbjBQqCjgoBmPnK(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PmbjBQqCjgoBmPnK(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BHNjjmPFLNPWtUjm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BHNjjmPFLNPWtUjm(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BHNjjmPFLNPWtUjm(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHNjjmPFLNPWtUjm(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BoLUZAzlYAgSsTZM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BoLUZAzlYAgSsTZM(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoLUZAzlYAgSsTZM(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BoLUZAzlYAgSsTZM(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DYphnvEQPAeDehPu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DYphnvEQPAeDehPu(java.lang.stringBuilder sb, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DYphnvEQPAeDehPu(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DYphnvEQPAeDehPu(java.lang.stringBuilder sb, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JZofnZUeBQiKkTTz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JZofnZUeBQiKkTTz(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JZofnZUeBQiKkTTz(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JZofnZUeBQiKkTTz(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182 Build() {
        if ((2 + 31) % 31 > 0) {
        }
        if (this.set$0 == 7 && this.symbol is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0394xce3d994b(this.pc, this.symbol, this.file, this.offset, this.importance, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if ((this.set$0 & 1) == 0) {
            bHNjjmPFLNPWtUjm(sb, " pc");
        }
        if (this.symbol is null) {
            PmbjBQqCjgoBmPnK(sb, " symbol");
        }
        if ((this.set$0 & 2) == 0) {
            jZofnZUeBQiKkTTz(sb, " offset");
        }
        if ((this.set$0 & 4) == 0) {
            boLUZAzlYAgSsTZM(sb, " importance");
        }
        throw new java.lang.IllegalStateException(dYphnvEQPAeDehPu(GiknshaPOBHglXyU(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 Setstring(java.lang.string str) {
        this.file = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 SetImportance(int i) {
        this.importance = i;
        this.set$0 = (byte) (this.set$0 | 4);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 SetOffset(long j) {
        this.offset = j;
        this.set$0 = (byte) (this.set$0 | 2);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 SetPc(long j) {
        this.pc = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0411xb6f1d659 SetSymbol(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null symbol");
        }
        this.symbol = str;
        return this;
    }
}

