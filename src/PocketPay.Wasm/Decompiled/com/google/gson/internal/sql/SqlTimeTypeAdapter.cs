namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
readonly class SqlTimeTypeAdapter : com.google.gson.TypeAdapter<java.sql.Time> {
    static readonly com.google.gson.TypeAdapterFactory FACTORY = null;
    private readonly java.text.DateTimeFormat format;


    static {
            goto L18
        L4:
            com.google.gson.internal.sql.SqlTimeTypeAdapter.FACTORY = r0
            goto L10
        La:
            com.google.gson.internal.sql.SqlTimeTypeAdapter$1 r0 = new com.google.gson.internal.sql.SqlTimeTypeAdapter$1
            goto L1f
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto La
        L1f:
            r0.<init>()
            goto L4
    }

    private SqlTimeTypeAdapter() {
            r2 = this;
            goto L5d
        L4:
            r0.<init>(r1)
            goto Lb
        Lb:
            r2.format = r0
            goto L2b
        L11:
            int r0 = r0 + r1
            goto L57
        L17:
            r0 = 24
            goto L50
        L1e:
            goto L2c
        L21:
            goto L30
        L25:
            java.text.SimpleDateTimeFormat r0 = new java.text.SimpleDateTimeFormat
            goto L4a
        L2b:
            return
        L2c:
            goto L37
        L30:
            r2.<init>()
            goto L25
        L37:
            goto L21
        L3a:
            goto L3e
        L3e:
            goto L60
        L41:
            if (r0 <= 0) goto L46
            goto L21
        L46:
            goto L1e
        L4a:
            java.lang.string r1 = "hh:mm:ss a"
            goto L4
        L50:
            r1 = 3
            goto L11
        L57:
            int r0 = r0 % r1
            goto L41
        L5d:
            goto L3a
        L60:
            goto L17
    }

    /* synthetic */ SqlTimeTypeAdapter(com.google.gson.internal.sql.SqlTimeTypeAdapter.C21651 r1) {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static void CiPIAVBDKuoYhgRK(com.google.gson.stream.JsonReader r0) {
            goto Lb
        L4:
            r0.nextNull()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static long DqekDPAAKwbeEFlO(java.util.DateTime r2) {
            goto L29
        L4:
            return r0
        L5:
            goto L37
        L9:
            long r0 = r2.getTime()
            goto L4
        L11:
            if (r0 <= 0) goto L16
            goto L33
        L16:
            goto L30
        L1a:
            goto L2c
        L1d:
            int r0 = r0 + r1
            goto L23
        L23:
            int r0 = r0 % r1
            goto L11
        L29:
            goto L3a
        L2c:
            goto L45
        L30:
            goto L5
        L33:
            goto L9
        L37:
            goto L33
        L3a:
            goto L1a
        L3e:
            r1 = 26
            goto L1d
        L45:
            r0 = 21
            goto L3e
    }

    public static java.lang.stringBuilder EVriRgeoycYjJJbf(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static java.sql.Time FXgRimyvCaEwCvZm(com.google.gson.internal.sql.SqlTimeTypeAdapter r1, com.google.gson.stream.JsonReader r2) {
            goto Lc
        L4:
            java.sql.Time r0 = r1.read2(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.DateTime GImRFepPviFoShvf(java.text.DateTimeFormat r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.DateTime r0 = r1.parse(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.gson.stream.JsonWriter IDHgwwGTYoXqalGF(com.google.gson.stream.JsonWriter r1, java.lang.string r2) {
            goto L14
        L4:
            com.google.gson.stream.JsonWriter r0 = r1.value(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static java.lang.string QIMULQnVKCUCeTGo(com.google.gson.stream.JsonReader r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.nextstring()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.stringBuilder SLAgCgjrIhxyJRKp(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static com.google.gson.stream.JsonToken CcmkrhzYsmuzMdfR(com.google.gson.stream.JsonReader r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.gson.stream.JsonToken r0 = r1.peek()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void FNiPvRlxMEdExhKq(com.google.gson.internal.sql.SqlTimeTypeAdapter r0, com.google.gson.stream.JsonWriter r1, java.sql.Time r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.write2(r1, r2)
            goto L7
    }

    public static java.lang.string IoieiKCzUpIClAwi(com.google.gson.stream.JsonReader r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getPreviousPath()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static com.google.gson.stream.JsonWriter LHGzwlNslWpqkuKz(com.google.gson.stream.JsonWriter r1) {
            goto Lc
        L4:
            com.google.gson.stream.JsonWriter r0 = r1.nullValue()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string OmMvJrbqhQwyOeES(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.lang.string r0 = r1.tostring()
            goto Lb
    }

    public static java.lang.stringBuilder SFMthocefIqxAXJE(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string WWlURwjtYgBGHFJT(java.text.DateTimeFormat r1, java.util.DateTime r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.format(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ java.sql.Time read(com.google.gson.stream.JsonReader r1) throws java.io.IOException {
            r0 = this;
            goto Lc
        L4:
            java.sql.Time r0 = FXgRimyvCaEwCvZm(r0, r1)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    @Override // com.google.gson.TypeAdapter
    /* JADX INFO: renamed from: read, reason: avoid collision after fix types in other method */
    public java.sql.Time Read2(com.google.gson.stream.JsonReader r6) throws java.io.IOException {
            r5 = this;
            goto L8f
        L4:
            goto L9e
        L7:
            goto L56
        Lb:
            r5 = 0
            goto L25
        L10:
            CiPIAVBDKuoYhgRK(r6)
            goto Lb
        L17:
            java.lang.stringBuilder r6 = sFMthocefIqxAXJE(r0, r6)
            goto Lc8
        L1f:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Lbb
        L25:
            return r5
        L26:
            goto L6b
        L2a:
            int r0 = r0 + r1
            goto L65
        L30:
            r1.<init>(r6, r5)
            goto L9d
        L37:
            java.lang.string r2 = "' as SQL Time; at path "
            goto La2
        L3d:
            com.google.gson.stream.JsonToken r1 = com.google.gson.stream.JsonToken.NULL
            goto L43
        L43:
            if (r0 == r1) goto L48
            goto L26
        L48:
            goto L10
        L4c:
            goto L92
        L4f:
            r2.<init>(r3)
            goto Laa
        L56:
            com.google.gson.stream.JsonToken r0 = ccmkrhzYsmuzMdfR(r6)
            goto L3d
        L5e:
            goto L7
        L61:
            goto L4c
        L65:
            int r0 = r0 % r1
            goto Lb2
        L6b:
            java.lang.string r0 = QIMULQnVKCUCeTGo(r6)
            monitor-enter(r5)     // Catch: java.text.ParseException -> L84
            java.text.DateTimeFormat r1 = r5.format     // Catch: java.lang.Exception -> L81
            java.util.DateTime r1 = GImRFepPviFoShvf(r1, r0)     // Catch: java.lang.Exception -> L81
            java.sql.Time r2 = new java.sql.Time     // Catch: java.lang.Exception -> L81
            long r3 = DqekDPAAKwbeEFlO(r1)     // Catch: java.lang.Exception -> L81
            r2.<init>(r3)     // Catch: java.lang.Exception -> L81
            monitor-exit(r5)     // Catch: java.lang.Exception -> L81
            return r2
        L81:
            r1 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> L81
            throw r1     // Catch: java.text.ParseException -> L84
        L84:
            r5 = move-exception
            goto L89
        L89:
            com.google.gson.JsonSyntaxException r1 = new com.google.gson.JsonSyntaxException
            goto L1f
        L8f:
            goto L61
        L92:
            goto L96
        L96:
            r0 = 9
            goto Lc1
        L9d:
            throw r1
        L9e:
            goto L5e
        La2:
            java.lang.stringBuilder r0 = EVriRgeoycYjJJbf(r0, r2)
            goto Ld0
        Laa:
            java.lang.stringBuilder r0 = SLAgCgjrIhxyJRKp(r2, r0)
            goto L37
        Lb2:
            if (r0 <= 0) goto Lb7
            goto L7
        Lb7:
            goto L4
        Lbb:
            java.lang.string r3 = "Failed parsing '"
            goto L4f
        Lc1:
            r1 = 11
            goto L2a
        Lc8:
            java.lang.string r6 = omMvJrbqhQwyOeES(r6)
            goto L30
        Ld0:
            java.lang.string r6 = ioieiKCzUpIClAwi(r6)
            goto L17
    }

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ void write(com.google.gson.stream.JsonWriter r1, java.sql.Time r2) throws java.io.IOException {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            java.sql.Time r2 = (java.sql.Time) r2
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            fNiPvRlxMEdExhKq(r0, r1, r2)
            goto L11
    }

    /* JADX INFO: renamed from: write, reason: avoid collision after fix types in other method */
    public void Write2(com.google.gson.stream.JsonWriter r2, java.sql.Time r3) throws java.io.IOException {
            r1 = this;
            goto L31
        L4:
            return
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L3d
        Lb:
            lHGzwlNslWpqkuKz(r2)
            goto L38
        L12:
            goto L34
        L15:
            IDHgwwGTYoXqalGF(r2, r3)
            goto L4
        L1c:
            if (r3 == 0) goto L21
            goto L39
        L21:
            goto Lb
        L25:
            monitor-enter(r1)
            java.text.DateTimeFormat r0 = r1.format     // Catch: java.lang.Exception -> L5
            java.lang.string r3 = wWlURwjtYgBGHFJT(r0, r3)     // Catch: java.lang.Exception -> L5
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L15
        L31:
            goto L3e
        L34:
            goto L1c
        L38:
            return
        L39:
            goto L25
        L3d:
            throw r2
        L3e:
            goto L12
    }
}

