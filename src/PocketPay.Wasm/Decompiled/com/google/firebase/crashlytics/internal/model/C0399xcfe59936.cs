namespace WillowMaze.Wasm.Decompiled;


readonly class C0399xcfe59936 : com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd {
    private bool defaultProcess;
    private int importance;
    private int pid;
    private java.lang.string processName;
    private byte set$0;

    C0399xcfe59936() {
    }

    public static java.lang.stringBuilder BmnvZShGezRfPgqp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BmnvZShGezRfPgqp(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BmnvZShGezRfPgqp(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmnvZShGezRfPgqp(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IMxoPFdjXZpcZjNb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IMxoPFdjXZpcZjNb(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OluqWgWfGZrDwFKq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OluqWgWfGZrDwFKq(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YksDQYDDzyQvIwAw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YksDQYDDzyQvIwAw(java.lang.stringBuilder sb, java.lang.string str, short s, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BdeqfiOCQMYotoAr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder sb, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder sb, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BdeqfiOCQMYotoAr(java.lang.stringBuilder sb, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FgIwuHLZsJkRanAR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder sb, java.lang.object obj, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FgIwuHLZsJkRanAR(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$ProcessDetails build() {
        if ((27 + 19) % 19 > 0) {
        }
        if (this.set$0 == 7 && this.processName is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0397x94fa915f(this.processName, this.pid, this.importance, this.defaultProcess, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.processName is null) {
            YksDQYDDzyQvIwAw(sb, " processName");
        }
        if ((this.set$0 & 1) == 0) {
            BmnvZShGezRfPgqp(sb, " pid");
        }
        if ((this.set$0 & 2) == 0) {
            IMxoPFdjXZpcZjNb(sb, " importance");
        }
        if ((this.set$0 & 4) == 0) {
            OluqWgWfGZrDwFKq(sb, " defaultProcess");
        }
        throw new java.lang.IllegalStateException(bdeqfiOCQMYotoAr(fgIwuHLZsJkRanAR(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd SetDefaultProcess(bool z) {
        this.defaultProcess = z;
        this.set$0 = (byte) (this.set$0 | 4);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd SetImportance(int i) {
        this.importance = i;
        this.set$0 = (byte) (this.set$0 | 2);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd SetPid(int i) {
        this.pid = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0412x9f440dcd SetProcessName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null processName");
        }
        this.processName = str;
        return this;
    }
}

