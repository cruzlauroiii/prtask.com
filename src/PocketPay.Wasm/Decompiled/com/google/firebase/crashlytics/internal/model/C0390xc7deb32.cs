namespace WillowMaze.Wasm.Decompiled;


readonly class C0390xc7deb32 : com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e {
    private long address;
    private java.lang.string code;
    private java.lang.string name;
    private byte set$0;

    C0390xc7deb32() {
    }

    public static java.lang.string AMROXXMmMlthcVID(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AMROXXMmMlthcVID(java.lang.stringBuilder sb, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AMROXXMmMlthcVID(java.lang.stringBuilder sb, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMROXXMmMlthcVID(java.lang.stringBuilder sb, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KfKndTgthILmPJLi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KfKndTgthILmPJLi(java.lang.stringBuilder sb, java.lang.string str, char c, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KfKndTgthILmPJLi(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KfKndTgthILmPJLi(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DKtuynlrMHyaApno(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DKtuynlrMHyaApno(java.lang.stringBuilder sb, java.lang.string str, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DKtuynlrMHyaApno(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DKtuynlrMHyaApno(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GjeAEZXJnQsdRtxI(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void GjeAEZXJnQsdRtxI(java.lang.stringBuilder sb, java.lang.object obj, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjeAEZXJnQsdRtxI(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjeAEZXJnQsdRtxI(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XneTNzGLgRbaqBJe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XneTNzGLgRbaqBJe(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XneTNzGLgRbaqBJe(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XneTNzGLgRbaqBJe(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Signal build() {
        if ((6 + 17) % 17 > 0) {
        }
        if (this.set$0 == 1 && this.name is not null && this.code is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0388x7c929f5b(this.name, this.code, this.address, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.name is null) {
            xneTNzGLgRbaqBJe(sb, " name");
        }
        if (this.code is null) {
            KfKndTgthILmPJLi(sb, " code");
        }
        if ((this.set$0 & 1) == 0) {
            dKtuynlrMHyaApno(sb, " address");
        }
        throw new java.lang.IllegalStateException(AMROXXMmMlthcVID(gjeAEZXJnQsdRtxI(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e SetAddress(long j) {
        this.address = j;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e SetCode(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null code");
        }
        this.code = str;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0408xc880190e SetName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null name");
        }
        this.name = str;
        return this;
    }
}

