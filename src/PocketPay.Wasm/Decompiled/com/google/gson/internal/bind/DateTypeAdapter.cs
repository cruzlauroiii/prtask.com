namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public readonly class DateTimeTypeAdapter : com.google.gson.TypeAdapter<java.util.DateTime> {
    public static readonly com.google.gson.TypeAdapterFactory FACTORY = null;
    private readonly java.util.List<java.text.DateTimeFormat> dateFormats;


    static {
            goto L4
        L4:
            goto L22
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.gson.internal.bind.DateTimeTypeAdapter$1 r0 = new com.google.gson.internal.bind.DateTimeTypeAdapter$1
            goto L14
        L14:
            r0.<init>()
            goto L1b
        L1b:
            com.google.gson.internal.bind.DateTimeTypeAdapter.FACTORY = r0
            goto L21
        L21:
            return
        L22:
            goto Lb
    }

    public DateTimeTypeAdapter() {
            r3 = this;
            goto L4a
        L4:
            int r0 = r0 % r1
            goto L2a
        La:
            goto Lbb
        Ld:
            goto L47
        L11:
            java.text.DateTimeFormat r3 = FGUFmJikxuCUVsZF(r1, r1, r3)
            goto La3
        L19:
            if (r3 == 0) goto L1e
            goto L8e
        L1e:
            goto L3f
        L22:
            bool r3 = YywCqVuqymzVMpsK(r3, r2)
            goto L19
        L2a:
            if (r0 <= 0) goto L2f
            goto Lbb
        L2f:
            goto Lb8
        L33:
            r3.<init>()
            goto L6c
        L3a:
            return
        L3b:
            goto La
        L3f:
            java.text.DateTimeFormat r3 = hINPNSmrgcXKGPlN(r1, r1)
            goto L8b
        L47:
            goto L4d
        L4a:
            goto Ld
        L4d:
            goto L77
        L51:
            java.util.Locale r3 = java.util.Locale.US
            goto L72
        L57:
            yTjUhPldIHgOoCtk(r0, r3)
        L5a:
            goto L3a
        L5e:
            bool r3 = rSIoVBCpCPmxwVei()
            goto L92
        L66:
            java.util.Locale r2 = java.util.Locale.US
            goto L22
        L6c:
            java.util.List r0 = new java.util.List
            goto L84
        L72:
            r1 = 2
            goto L11
        L77:
            r0 = 28
            goto Lbf
        L7e:
            r3.dateFormats = r0
            goto L51
        L84:
            r0.<init>()
            goto L7e
        L8b:
            lZPrkXYlwXXDWWBw(r0, r3)
        L8e:
            goto L5e
        L92:
            if (r3 != 0) goto L97
            goto L5a
        L97:
            goto L9b
        L9b:
            java.text.DateTimeFormat r3 = qGSkVtUbzbRFrdNT(r1, r1)
            goto L57
        La3:
            vGciiyRqlFEezndu(r0, r3)
            goto Laa
        Laa:
            java.util.Locale r3 = ObmCwqvxdeciDAUH()
            goto L66
        Lb2:
            int r0 = r0 + r1
            goto L4
        Lb8:
            goto L3b
        Lbb:
            goto L33
        Lbf:
            r1 = 2
            goto Lb2
    }

    public static java.lang.stringBuilder DZmmTkjKrRYXgmrt(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.text.DateTimeFormat FGUFmJikxuCUVsZF(int r1, int r2, java.util.Locale r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.text.DateTimeFormat r0 = java.text.DateTimeFormat.getDateTimeTimeInstance(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string GXAWMQhnpgyjEDZm(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.gson.stream.JsonWriter HrYGkrsFfJNXOoSz(com.google.gson.stream.JsonWriter r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.gson.stream.JsonWriter r0 = r1.value(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.gson.stream.JsonToken LKLodvPxtNitYVUG(com.google.gson.stream.JsonReader r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            com.google.gson.stream.JsonToken r0 = r1.peek()
            goto L4
        L18:
            goto Lc
    }

    public static java.util.DateTime LTEgaHWbahhmfCog(java.lang.string r1, java.text.ParsePosition r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.DateTime r0 = com.google.gson.internal.bind.util.ISO8601Utils.parse(r1, r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.stringBuilder MndGpOqXhpqRnUJO(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
    }

    public static java.util.Locale ObmCwqvxdeciDAUH() {
            goto L14
        L4:
            goto L17
        L7:
            java.util.Locale r0 = java.util.Locale.getDefault()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.util.DateTime SOPbjGUghnljLAth(com.google.gson.internal.bind.DateTimeTypeAdapter r1, com.google.gson.stream.JsonReader r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.DateTime r0 = r1.read2(r2)
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

    public static java.util.IEnumerator XqxQalGOQosjoDkf(java.util.List r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool YywCqVuqymzVMpsK(java.util.Locale r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Equals(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void BWhgBTnzKGBFADXn(com.google.gson.stream.JsonReader r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.nextNull()
            goto Lb
        L17:
            goto L7
    }

    public static com.google.gson.stream.JsonWriter CrXxUICPcAXHIESf(com.google.gson.stream.JsonWriter r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.gson.stream.JsonWriter r0 = r1.nullValue()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    private java.util.DateTime DeserializeToDateTime(com.google.gson.stream.JsonReader r5) throws java.io.IOException {
            r4 = this;
            goto L82
        L4:
            r1 = 19
            goto L14
        Lb:
            goto L85
        Le:
            java.lang.string r2 = "' as DateTime; at path "
            goto L43
        L14:
            int r0 = r0 + r1
            goto L37
        L1a:
            java.lang.string r5 = lvgRwjSjGHtOexAl(r5)
            goto L9d
        L22:
            java.lang.stringBuilder r0 = DZmmTkjKrRYXgmrt(r2, r0)
            goto Le
        L2a:
            throw r4
        L2b:
            goto L90
        L2f:
            java.lang.string r0 = pVjYImVhPTFmBNGZ(r5)
            goto L4b
        L37:
            int r0 = r0 % r1
            goto L51
        L3d:
            return r4
        L3e:
            r4 = move-exception
            goto L97
        L43:
            java.lang.stringBuilder r0 = eHpfnOwRUNKgbAfB(r0, r2)
            goto L1a
        L4b:
            java.util.List<java.text.DateTimeFormat> r1 = r4.dateFormats
            goto La5
        L51:
            if (r0 <= 0) goto L56
            goto L71
        L56:
            goto L6e
        L5a:
            java.lang.string r3 = "Failed parsing '"
            goto L67
        L60:
            r0 = 32
            goto L4
        L67:
            r2.<init>(r3)
            goto L22
        L6e:
            goto L2b
        L71:
            goto L2f
        L75:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L5a
        L7b:
            throw r1
        L7c:
            r4 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7c
            goto L2a
        L82:
            goto L93
        L85:
            goto L60
        L89:
            r1.<init>(r5, r4)
            goto L7b
        L90:
            goto L71
        L93:
            goto Lb
        L97:
            com.google.gson.JsonSyntaxException r1 = new com.google.gson.JsonSyntaxException
            goto L75
        L9d:
            java.lang.stringBuilder r5 = MndGpOqXhpqRnUJO(r0, r5)
            goto Lcd
        La5:
            monitor-enter(r1)
            java.util.List<java.text.DateTimeFormat> r4 = r4.dateFormats     // Catch: java.lang.Exception -> L7c
            java.util.IEnumerator r4 = XqxQalGOQosjoDkf(r4)     // Catch: java.lang.Exception -> L7c
        Lac:
            bool r2 = tUKVeHbvZIdtPAbV(r4)     // Catch: java.lang.Exception -> L7c
            if (r2 == 0) goto Lbe
            java.lang.object r2 = gSXlOdzzGrylOLBm(r4)     // Catch: java.lang.Exception -> L7c
            java.text.DateTimeFormat r2 = (java.text.DateTimeFormat) r2     // Catch: java.lang.Exception -> L7c
            java.util.DateTime r4 = gzcmNlkOHQHHAZtd(r2, r0)     // Catch: java.lang.Exception -> L7c java.text.ParseException -> Lac
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7c
            return r4
        Lbe:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7c
            java.text.ParsePosition r4 = new java.text.ParsePosition     // Catch: java.text.ParseException -> L3e
            r1 = 0
            r4.<init>(r1)     // Catch: java.text.ParseException -> L3e
            java.util.DateTime r4 = LTEgaHWbahhmfCog(r0, r4)     // Catch: java.text.ParseException -> L3e
            goto L3d
        Lcd:
            java.lang.string r5 = GXAWMQhnpgyjEDZm(r5)
            goto L89
    }

    public static java.lang.stringBuilder EHpfnOwRUNKgbAfB(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object GSXlOdzzGrylOLBm(java.util.IEnumerator r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.Current
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.util.DateTime GzcmNlkOHQHHAZtd(java.text.DateTimeFormat r1, java.lang.string r2) {
            goto L14
        L4:
            java.util.DateTime r0 = r1.parse(r2)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static java.text.DateTimeFormat HINPNSmrgcXKGPlN(int r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.text.DateTimeFormat r0 = java.text.DateTimeFormat.getDateTimeTimeInstance(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void KluGvrTyzIqusxWl(com.google.gson.internal.bind.DateTimeTypeAdapter r0, com.google.gson.stream.JsonWriter r1, java.util.DateTime r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.write2(r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static bool LZPrkXYlwXXDWWBw(java.util.List r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            bool r0 = r1.Add(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string LvgRwjSjGHtOexAl(com.google.gson.stream.JsonReader r1) {
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

    public static java.lang.string PVjYImVhPTFmBNGZ(com.google.gson.stream.JsonReader r1) {
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
            java.lang.string r0 = r1.nextstring()
            goto L4
    }

    public static java.text.DateTimeFormat QGSkVtUbzbRFrdNT(int r1, int r2) {
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
            java.text.DateTimeFormat r0 = com.google.gson.internal.PreJava9DateTimeFormatProvider.getUSDateTimeTimeFormat(r1, r2)
            goto Le
    }

    public static bool RSIoVBCpCPmxwVei() {
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
            bool r0 = com.google.gson.internal.JavaVersion.isJava9OrLater()
            goto Le
    }

    public static java.lang.string SHjOGhduktFwlzkl(java.text.DateTimeFormat r1, java.util.DateTime r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = r1.format(r2)
            goto Lb
        L18:
            goto L7
    }

    public static bool TUKVeHbvZIdtPAbV(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto Le
    }

    public static bool VGciiyRqlFEezndu(java.util.List r1, java.lang.object r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.Add(r2)
            goto L7
    }

    public static java.util.DateTime XBfgeyeDESknciHB(com.google.gson.internal.bind.DateTimeTypeAdapter r1, com.google.gson.stream.JsonReader r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.DateTime r0 = r1.deserializeToDateTime(r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object XClVkXUIDeRVhuYd(java.util.List r1, int r2) {
            goto Lc
        L4:
            java.lang.object r0 = r1[r2)
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

    public static bool YTjUhPldIHgOoCtk(java.util.List r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Add(r2)
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

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ java.util.DateTime read(com.google.gson.stream.JsonReader r1) throws java.io.IOException {
            r0 = this;
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
            java.util.DateTime r0 = SOPbjGUghnljLAth(r0, r1)
            goto L4
    }

    @Override // com.google.gson.TypeAdapter
    /* JADX INFO: renamed from: read, reason: avoid collision after fix types in other method */
    public java.util.DateTime Read2(com.google.gson.stream.JsonReader r3) throws java.io.IOException {
            r2 = this;
            goto L5b
        L4:
            goto L1f
        L7:
            goto L23
        Lb:
            return r2
        Lc:
            goto L4
        L10:
            com.google.gson.stream.JsonToken r1 = com.google.gson.stream.JsonToken.NULL
            goto L6b
        L16:
            int r0 = r0 % r1
            goto L62
        L1c:
            goto Lc
        L1f:
            goto L3f
        L23:
            goto L5e
        L26:
            r0 = 24
            goto L4d
        L2d:
            java.util.DateTime r2 = xBfgeyeDESknciHB(r2, r3)
            goto Lb
        L35:
            return r2
        L36:
            goto L2d
        L3a:
            r2 = 0
            goto L35
        L3f:
            com.google.gson.stream.JsonToken r0 = LKLodvPxtNitYVUG(r3)
            goto L10
        L47:
            int r0 = r0 + r1
            goto L16
        L4d:
            r1 = 22
            goto L47
        L54:
            bWhgBTnzKGBFADXn(r3)
            goto L3a
        L5b:
            goto L7
        L5e:
            goto L26
        L62:
            if (r0 <= 0) goto L67
            goto L1f
        L67:
            goto L1c
        L6b:
            if (r0 == r1) goto L70
            goto L36
        L70:
            goto L54
    }

    @Override // com.google.gson.TypeAdapter
    public /* bridge */ /* synthetic */ void write(com.google.gson.stream.JsonWriter r1, java.util.DateTime r2) throws java.io.IOException {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto L1a
        Lb:
            kluGvrTyzIqusxWl(r0, r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
        L1a:
            java.util.DateTime r2 = (java.util.DateTime) r2
            goto Lb
    }

    /* JADX INFO: renamed from: write, reason: avoid collision after fix types in other method */
    public void Write2(com.google.gson.stream.JsonWriter r3, java.util.DateTime r4) throws java.io.IOException {
            r2 = this;
            goto L66
        L4:
            return
        L5:
            goto L28
        L9:
            throw r3
        La:
            goto L5f
        Le:
            goto L69
        L11:
            if (r0 <= 0) goto L16
            goto L3e
        L16:
            goto L3b
        L1a:
            r1 = 30
            goto L7e
        L21:
            crXxUICPcAXHIESf(r3)
            goto L4
        L28:
            java.util.List<java.text.DateTimeFormat> r0 = r2.dateFormats
            goto L51
        L2e:
            java.util.List<java.text.DateTimeFormat> r2 = r2.dateFormats
            goto L74
        L34:
            HrYGkrsFfJNXOoSz(r3, r4)
            goto L6d
        L3b:
            goto La
        L3e:
            goto L56
        L42:
            r0 = 18
            goto L1a
        L49:
            java.lang.object r0 = xClVkXUIDeRVhuYd(r0, r1)
            goto L8a
        L51:
            r1 = 0
            goto L49
        L56:
            if (r4 == 0) goto L5b
            goto L5
        L5b:
            goto L21
        L5f:
            goto L3e
        L62:
            goto Le
        L66:
            goto L62
        L69:
            goto L42
        L6d:
            return
        L6e:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6e
            goto L9
        L74:
            monitor-enter(r2)
            java.lang.string r4 = sHjOGhduktFwlzkl(r0, r4)     // Catch: java.lang.Exception -> L6e
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6e
            goto L34
        L7e:
            int r0 = r0 + r1
            goto L84
        L84:
            int r0 = r0 % r1
            goto L11
        L8a:
            java.text.DateTimeFormat r0 = (java.text.DateTimeFormat) r0
            goto L2e
    }
}

