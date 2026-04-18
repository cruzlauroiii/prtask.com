namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
readonly class SqlDateTimeTypeAdapter : com.google.gson.TypeAdapter<java.sql.DateTime> {
    static readonly com.google.gson.TypeAdapterFactory FACTORY = null;
    private readonly java.text.DateTimeFormat format;


    static {
            goto L17
        L4:
            com.google.gson.internal.sql.SqlDateTimeTypeAdapter$1 r0 = new com.google.gson.internal.sql.SqlDateTimeTypeAdapter$1
            goto La
        La:
            r0.<init>()
            goto L11
        L11:
            com.google.gson.internal.sql.SqlDateTimeTypeAdapter.FACTORY = r0
            goto L21
        L17:
            goto L22
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            return
        L22:
            goto L1e
    }

    private SqlDateTimeTypeAdapter() {
            r2 = this;
            goto L16
        L4:
            int r0 = r0 % r1
            goto L1d
        La:
            goto L32
        Ld:
            goto L2c
        L11:
            return
        L12:
            goto La
        L16:
            goto Ld
        L19:
            goto L50
        L1d:
            if (r0 <= 0) goto L22
            goto L32
        L22:
            goto L2f
        L26:
            int r0 = r0 + r1
            goto L4
        L2c:
            goto L19
        L2f:
            goto L12
        L32:
            goto L43
        L36:
            java.lang.string r1 = "MMM d, yyyy"
            goto L57
        L3c:
            r1 = 2
            goto L26
        L43:
            r2.<init>()
            goto L4a
        L4a:
            java.text.SimpleDateTimeFormat r0 = new java.text.SimpleDateTimeFormat
            goto L36
        L50:
            r0 = 20
            goto L3c
        L57:
            r0.<init>(r1)
            goto L5e
        L5e:
            r2.format = r0
            goto L11
    }

    /* synthetic */ SqlDateTimeTypeAdapter(com.google.gson.internal.sql.SqlDateTimeTypeAdapter.C21641 r1) {
            r0 = this;
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.<init>()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static java.lang.stringBuilder AubMjAnNHKkHXcJu(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.string CCHVqvHHHCgmimWx(com.google.gson.stream.JsonReader r1) {
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

    public static void DOtIjpeCwatShezW(com.google.gson.stream.JsonReader r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.nextNull()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.gson.stream.JsonWriter FzAAanWmVasKINwg(com.google.gson.stream.JsonWriter r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.gson.stream.JsonWriter r0 = r1.nullValue()
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

    public static java.sql.DateTime HJOrNfmvUlljPsRZ(com.google.gson.internal.sql.SqlDateTimeTypeAdapter r1, com.google.gson.stream.JsonReader r2) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.sql.DateTime r0 = r1.read2(r2)
            goto Le
    }

    public static long HTXIqDozEPsajkDE(java.util.DateTime r2) {
            goto L29
        L4:
            if (r0 <= 0) goto L9
            goto L33
        L9:
            goto L30
        Ld:
            long r0 = r2.getTime()
            goto L47
        L15:
            r0 = 32
            goto L3d
        L1c:
            int r0 = r0 % r1
            goto L4
        L22:
            goto L33
        L25:
            goto L44
        L29:
            goto L25
        L2c:
            goto L15
        L30:
            goto L48
        L33:
            goto Ld
        L37:
            int r0 = r0 + r1
            goto L1c
        L3d:
            r1 = 2
            goto L37
        L44:
            goto L2c
        L47:
            return r0
        L48:
            goto L22
    }

    public static java.util.DateTime HniYKiXXUbZkTbEq(java.text.DateTimeFormat r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.util.DateTime r0 = r1.parse(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string HwXbAnoOeuuPRMgH(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void OpllleQycYWcwmgw(com.google.gson.internal.sql.SqlDateTimeTypeAdapter r0, com.google.gson.stream.JsonWriter r1, java.sql.DateTime r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.write2(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static com.google.gson.stream.JsonToken CHkSgSPVADhHQlBk(com.google.gson.stream.JsonReader r1) {
            goto L11
        L4:
            com.google.gson.stream.JsonToken r0 = r1.peek()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.stringBuilder DAaBhsMqcyxVSIau(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string HirrILFDwlcRegQg(com.google.gson.stream.JsonReader r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getPreviousPath()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string NsTVGJijSTkOZCai(java.text.DateTimeFormat r1, java.util.DateTime r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.format(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder OLbYhoQaAbQmYbjp(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static com.google.gson.stream.JsonWriter PcqRMtDwCCDHTyBP(com.google.gson.stream.JsonWriter r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.gson.stream.JsonWriter r0 = r1.value(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ java.sql.DateTime read(com.google.gson.stream.JsonReader r1) throws java.io.IOException {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.sql.DateTime r0 = HJOrNfmvUlljPsRZ(r0, r1)
            goto Le
    }

    @Override // com.google.gson.TypeAdapter
    /* JADX INFO: renamed from: read, reason: avoid collision after fix types in other method */
    public java.sql.DateTime Read2(com.google.gson.stream.JsonReader r5) throws java.io.IOException {
            r4 = this;
            goto La9
        L4:
            java.lang.string r5 = hirrILFDwlcRegQg(r5)
            goto L3d
        Lc:
            java.lang.string r0 = CCHVqvHHHCgmimWx(r5)
            monitor-enter(r4)     // Catch: java.text.ParseException -> L9f
            java.text.DateTimeFormat r1 = r4.format     // Catch: java.lang.Exception -> L9c
            java.util.DateTime r1 = HniYKiXXUbZkTbEq(r1, r0)     // Catch: java.lang.Exception -> L9c
            monitor-exit(r4)     // Catch: java.lang.Exception -> L9c
            java.sql.DateTime r4 = new java.sql.DateTime     // Catch: java.text.ParseException -> L9f
            long r1 = HTXIqDozEPsajkDE(r1)     // Catch: java.text.ParseException -> L9f
            r4.<init>(r1)     // Catch: java.text.ParseException -> L9f
            goto L9b
        L25:
            goto L46
        L28:
            goto L35
        L2c:
            if (r0 == r1) goto L31
            goto La5
        L31:
            goto L8d
        L35:
            com.google.gson.stream.JsonToken r0 = cHkSgSPVADhHQlBk(r5)
            goto L63
        L3d:
            java.lang.stringBuilder r5 = AubMjAnNHKkHXcJu(r0, r5)
            goto L5b
        L45:
            throw r1
        L46:
            goto L86
        L4a:
            java.lang.stringBuilder r0 = oLbYhoQaAbQmYbjp(r2, r0)
            goto L80
        L52:
            if (r0 <= 0) goto L57
            goto L28
        L57:
            goto L25
        L5b:
            java.lang.string r5 = HwXbAnoOeuuPRMgH(r5)
            goto L74
        L63:
            com.google.gson.stream.JsonToken r1 = com.google.gson.stream.JsonToken.NULL
            goto L2c
        L69:
            java.lang.stringBuilder r0 = dAaBhsMqcyxVSIau(r0, r2)
            goto L4
        L71:
            goto Lac
        L74:
            r1.<init>(r5, r4)
            goto L45
        L7b:
            r4 = 0
            goto La4
        L80:
            java.lang.string r2 = "' as SQL DateTime; at path "
            goto L69
        L86:
            goto L28
        L89:
            goto L71
        L8d:
            DOtIjpeCwatShezW(r5)
            goto L7b
        L94:
            r0 = 31
            goto Lcf
        L9b:
            return r4
        L9c:
            r1 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L9c
            throw r1     // Catch: java.text.ParseException -> L9f
        L9f:
            r4 = move-exception
            goto Lb0
        La4:
            return r4
        La5:
            goto Lc
        La9:
            goto L89
        Lac:
            goto L94
        Lb0:
            com.google.gson.JsonSyntaxException r1 = new com.google.gson.JsonSyntaxException
            goto Lc9
        Lb6:
            int r0 = r0 % r1
            goto L52
        Lbc:
            r2.<init>(r3)
            goto L4a
        Lc3:
            int r0 = r0 + r1
            goto Lb6
        Lc9:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto Ld6
        Lcf:
            r1 = 1
            goto Lc3
        Ld6:
            java.lang.string r3 = "Failed parsing '"
            goto Lbc
    }

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ void write(com.google.gson.stream.JsonWriter r1, java.sql.DateTime r2) throws java.io.IOException {
            r0 = this;
            goto L4
        L4:
            goto L1c
        L7:
            goto Lb
        Lb:
            java.sql.DateTime r2 = (java.sql.DateTime) r2
            goto L11
        L11:
            OpllleQycYWcwmgw(r0, r1, r2)
            goto L1b
        L18:
            goto L7
        L1b:
            return
        L1c:
            goto L18
    }

    /* JADX INFO: renamed from: write, reason: avoid collision after fix types in other method */
    public void Write2(com.google.gson.stream.JsonWriter r2, java.sql.DateTime r3) throws java.io.IOException {
            r1 = this;
            goto L3b
        L4:
            throw r2
        L5:
            goto L20
        L9:
            FzAAanWmVasKINwg(r2)
            goto L36
        L10:
            pcqRMtDwCCDHTyBP(r2, r3)
            goto L23
        L17:
            if (r3 == 0) goto L1c
            goto L37
        L1c:
            goto L9
        L20:
            goto L3e
        L23:
            return
        L24:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L4
        L2a:
            monitor-enter(r1)
            java.text.DateTimeFormat r0 = r1.format     // Catch: java.lang.Exception -> L24
            java.lang.string r3 = nsTVGJijSTkOZCai(r0, r3)     // Catch: java.lang.Exception -> L24
            monitor-exit(r1)     // Catch: java.lang.Exception -> L24
            goto L10
        L36:
            return
        L37:
            goto L2a
        L3b:
            goto L5
        L3e:
            goto L17
    }
}

