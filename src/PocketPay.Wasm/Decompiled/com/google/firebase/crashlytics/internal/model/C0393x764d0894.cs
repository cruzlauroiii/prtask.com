namespace WillowMaze.Wasm.Decompiled;


readonly class C0393x764d0894 : com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 {
    private java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> frames;
    private int importance;
    private java.lang.string name;
    private byte set$0;

    C0393x764d0894() {
    }

    public static java.lang.stringBuilder PSDVxKDMBggtjIXg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PSDVxKDMBggtjIXg(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PSDVxKDMBggtjIXg(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PSDVxKDMBggtjIXg(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QCJojJdZBajjPTAN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QCJojJdZBajjPTAN(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QCJojJdZBajjPTAN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QCJojJdZBajjPTAN(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XfbmFytGhBOfzczX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XfbmFytGhBOfzczX(java.lang.stringBuilder sb, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XfbmFytGhBOfzczX(java.lang.stringBuilder sb, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfbmFytGhBOfzczX(java.lang.stringBuilder sb, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JrroFUQtIZSdsflW(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void JrroFUQtIZSdsflW(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrroFUQtIZSdsflW(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JrroFUQtIZSdsflW(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NeVatMlUmVZNtObi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NeVatMlUmVZNtObi(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NeVatMlUmVZNtObi(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NeVatMlUmVZNtObi(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.firebase.crashlytics.internal.model.CrashlyticsReport$Session$Event$Application$Execution$Thread build() {
        if ((20 + 28) % 28 > 0) {
        }
        if (this.set$0 == 1 && this.name is not null && this.frames is not null) {
            return new com.google.firebase.crashlytics.internal.model.C0391x7e3e3ebd(this.name, this.importance, this.frames, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (this.name is null) {
            PSDVxKDMBggtjIXg(sb, " name");
        }
        if ((1 & this.set$0) == 0) {
            QCJojJdZBajjPTAN(sb, " importance");
        }
        if (this.frames is null) {
            neVatMlUmVZNtObi(sb, " frames");
        }
        throw new java.lang.IllegalStateException(XfbmFytGhBOfzczX(jrroFUQtIZSdsflW(new java.lang.stringBuilder("Missing required properties:"), sb)));
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 SetFrames(java.util.List<com.google.firebase.crashlytics.internal.model.AbstractC0410x40bba182> list) {
        if (list is null) {
            throw new java.lang.NullPointerException("Null frames");
        }
        this.frames = list;
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 SetImportance(int i) {
        this.importance = i;
        this.set$0 = (byte) (this.set$0 | 1);
        return this;
    }

    public override com.google.firebase.crashlytics.internal.model.AbstractC0409x324f3670 SetName(java.lang.string str) {
        if (str is null) {
            throw new java.lang.NullPointerException("Null name");
        }
        this.name = str;
        return this;
    }
}

