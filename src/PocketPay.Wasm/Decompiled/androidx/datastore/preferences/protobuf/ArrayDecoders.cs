namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class ArrayDecoders {
    static readonly int DEFAULT_RECURSION_LIMIT = 100;
    private static int recursionLimit = 100;

    /* JADX INFO: renamed from: androidx.datastore.preferences.protobuf.ArrayDecoders$1 */
    static /* synthetic */ class C04101 {
        static readonly /* synthetic */ int[] $SwitchDictionary$com$google$protobuf$WireFormat$FieldType = null;

        static {
                goto L9
            L4:
                int r0 = r0.length
                goto L10
            L9:
                goto L123
            Lc:
                goto L32
            L10:
                int[] r0 = new int[r0]
                goto L39
            L16:
                int r0 = r0 % r1
                goto L1c
            L1c:
                if (r0 <= 0) goto L21
                goto L2e
            L21:
                goto L2b
            L25:
                int r0 = r0 + r1
                goto L16
            L2b:
                goto L128
            L2e:
                goto L111
            L32:
                r0 = 6
                goto L119
            L39:
                androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType = r0
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.DOUBLE     // Catch: java.lang.NoSuchFieldError -> L44
                int r1 = AtLBPaGiVDDDYKgS(r1)     // Catch: java.lang.NoSuchFieldError -> L44
                r2 = 1
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L44
            L44:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L4f
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FLOAT     // Catch: java.lang.NoSuchFieldError -> L4f
                int r1 = MjEJuUiSsfuVsatB(r1)     // Catch: java.lang.NoSuchFieldError -> L4f
                r2 = 2
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L4f
            L4f:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L5a
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.INT64     // Catch: java.lang.NoSuchFieldError -> L5a
                int r1 = AoRfZsVqEEPYnYeZ(r1)     // Catch: java.lang.NoSuchFieldError -> L5a
                r2 = 3
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L5a
            L5a:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L65
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.UINT64     // Catch: java.lang.NoSuchFieldError -> L65
                int r1 = BoYetRtQauBVuOnF(r1)     // Catch: java.lang.NoSuchFieldError -> L65
                r2 = 4
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L65
            L65:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L70
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.INT32     // Catch: java.lang.NoSuchFieldError -> L70
                int r1 = yicaSaLWLZCdSLbe(r1)     // Catch: java.lang.NoSuchFieldError -> L70
                r2 = 5
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L70
            L70:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L7b
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.UINT32     // Catch: java.lang.NoSuchFieldError -> L7b
                int r1 = jLjVLNtDAqWfJHXN(r1)     // Catch: java.lang.NoSuchFieldError -> L7b
                r2 = 6
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L7b
            L7b:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L86
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FIXED64     // Catch: java.lang.NoSuchFieldError -> L86
                int r1 = kXsfdFKKEzCQcWqX(r1)     // Catch: java.lang.NoSuchFieldError -> L86
                r2 = 7
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L86
            L86:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L92
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SFIXED64     // Catch: java.lang.NoSuchFieldError -> L92
                int r1 = DFYGgwgFiWWpCOFd(r1)     // Catch: java.lang.NoSuchFieldError -> L92
                r2 = 8
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L92
            L92:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L9e
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FIXED32     // Catch: java.lang.NoSuchFieldError -> L9e
                int r1 = EzMyBNWDFhKbLWSm(r1)     // Catch: java.lang.NoSuchFieldError -> L9e
                r2 = 9
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L9e
            L9e:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Laa
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SFIXED32     // Catch: java.lang.NoSuchFieldError -> Laa
                int r1 = hDfJnfgLPFyxdfvi(r1)     // Catch: java.lang.NoSuchFieldError -> Laa
                r2 = 10
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Laa
            Laa:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lb6
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.BOOL     // Catch: java.lang.NoSuchFieldError -> Lb6
                int r1 = WMzFlPsAiTxvcaWh(r1)     // Catch: java.lang.NoSuchFieldError -> Lb6
                r2 = 11
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lb6
            Lb6:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lc2
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SINT32     // Catch: java.lang.NoSuchFieldError -> Lc2
                int r1 = eDtWKNyqvkXjRkvs(r1)     // Catch: java.lang.NoSuchFieldError -> Lc2
                r2 = 12
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lc2
            Lc2:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lce
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SINT64     // Catch: java.lang.NoSuchFieldError -> Lce
                int r1 = ZgISiPfTTTenUYpw(r1)     // Catch: java.lang.NoSuchFieldError -> Lce
                r2 = 13
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lce
            Lce:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lda
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.ENUM     // Catch: java.lang.NoSuchFieldError -> Lda
                int r1 = xfkNmvJCkpDaAzcI(r1)     // Catch: java.lang.NoSuchFieldError -> Lda
                r2 = 14
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lda
            Lda:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Le6
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.BYTES     // Catch: java.lang.NoSuchFieldError -> Le6
                int r1 = LNArSAFXNqHWDMDB(r1)     // Catch: java.lang.NoSuchFieldError -> Le6
                r2 = 15
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Le6
            Le6:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lf2
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.STRING     // Catch: java.lang.NoSuchFieldError -> Lf2
                int r1 = LuZjnIMBuHfzcALw(r1)     // Catch: java.lang.NoSuchFieldError -> Lf2
                r2 = 16
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lf2
            Lf2:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lfe
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.GROUP     // Catch: java.lang.NoSuchFieldError -> Lfe
                int r1 = fYWFktbZlqMnfZNG(r1)     // Catch: java.lang.NoSuchFieldError -> Lfe
                r2 = 17
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lfe
            Lfe:
                int[] r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L10a
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.MESSAGE     // Catch: java.lang.NoSuchFieldError -> L10a
                int r1 = JIejFHMzKuXXRCrZ(r1)     // Catch: java.lang.NoSuchFieldError -> L10a
                r2 = 18
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L10a
            L10a:
                goto L127
            L10e:
                goto Lc
            L111:
                androidx.datastore.preferences.protobuf.WireFormat$FieldType[] r0 = jtqxSHLeCzNrOlJc()
                goto L4
            L119:
                r1 = 4
                goto L25
            L120:
                goto L2e
            L123:
                goto L10e
            L127:
                return
            L128:
                goto L120
        }

        public static int AoRfZsVqEEPYnYeZ(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
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
                int r0 = r1.ordinal()
                goto L4
        }

        public static int AtLBPaGiVDDDYKgS(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                int r0 = r1.ordinal()
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static int BoYetRtQauBVuOnF(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L14
            L4:
                goto L17
            L7:
                int r0 = r1.ordinal()
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

        public static int DFYGgwgFiWWpCOFd(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto Lf
            L4:
                goto L12
            L7:
                int r0 = r1.ordinal()
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

        public static int EzMyBNWDFhKbLWSm(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
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
                int r0 = r1.ordinal()
                goto Lb
            L18:
                goto L7
        }

        public static int JIejFHMzKuXXRCrZ(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto Lf
            L4:
                goto L12
            L7:
                int r0 = r1.ordinal()
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

        public static int LNArSAFXNqHWDMDB(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                int r0 = r1.ordinal()
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static int LuZjnIMBuHfzcALw(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L11
            L4:
                int r0 = r1.ordinal()
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

        public static int MjEJuUiSsfuVsatB(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L7
            L4:
                goto La
            L7:
                goto Lf
            La:
                goto L13
            Le:
                return r0
            Lf:
                goto L4
            L13:
                int r0 = r1.ordinal()
                goto Le
        }

        public static int WMzFlPsAiTxvcaWh(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                int r0 = r1.ordinal()
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static int ZgISiPfTTTenUYpw(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                int r0 = r1.ordinal()
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        public static int EDtWKNyqvkXjRkvs(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                int r0 = r1.ordinal()
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static int FYWFktbZlqMnfZNG(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L4
            L4:
                goto L14
            L7:
                goto Lb
            Lb:
                int r0 = r1.ordinal()
                goto L13
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto L7
        }

        public static int HDfJnfgLPFyxdfvi(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                int r0 = r1.ordinal()
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static int JLjVLNtDAqWfJHXN(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
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
                int r0 = r1.ordinal()
                goto L4
        }

        public static androidx.datastore.preferences.protobuf.WireFormat.FieldType[] JtqxSHLeCzNrOlJc() {
                goto Lc
            L4:
                androidx.datastore.preferences.protobuf.WireFormat$FieldType[] r0 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.Values
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

        public static int KXsfdFKKEzCQcWqX(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto Lf
            L4:
                goto L12
            L7:
                int r0 = r1.ordinal()
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

        public static int XfkNmvJCkpDaAzcI(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L14
            L4:
                goto L17
            L7:
                int r0 = r1.ordinal()
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

        public static int YicaSaLWLZCdSLbe(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
                goto L14
            L4:
                int r0 = r1.ordinal()
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
    }

    static readonly class Registers {
        public readonly androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistry;
        public int int1;
        public long long1;
        public java.lang.object object1;
        public int recursionDepth;

        Registers() {
                r1 = this;
                goto L4
            L4:
                goto L1c
            L7:
                goto L11
            Lb:
                r1.extensionRegistry = r0
                goto L1b
            L11:
                r1.<init>()
                goto L20
            L18:
                goto L7
            L1b:
                return
            L1c:
                goto L18
            L20:
                androidx.datastore.preferences.protobuf.ExtensionRegistryLite r0 = heegbSNcOEsZoWIq()
                goto Lb
        }

        Registers(androidx.datastore.preferences.protobuf.ExtensionRegistryLite r1) {
                r0 = this;
                goto L20
            L4:
                ubxhVCBzpmWAKUeU(r1)
                goto Lb
            Lb:
                r0.extensionRegistry = r1
                goto L11
            L11:
                return
            L12:
                goto L1d
            L16:
                r0.<init>()
                goto L4
            L1d:
                goto L23
            L20:
                goto L12
            L23:
                goto L16
        }

        public static androidx.datastore.preferences.protobuf.ExtensionRegistryLite HeegbSNcOEsZoWIq() {
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
                androidx.datastore.preferences.protobuf.ExtensionRegistryLite r0 = androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()
                goto L4
        }

        public static java.lang.Class UbxhVCBzpmWAKUeU(java.lang.object r1) {
                goto L14
            L4:
                java.lang.Class r0 = r1.GetType()
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
    }

    static {
            goto L4
        L4:
            goto Lf
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
    }

    private ArrayDecoders() {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void AIFMqkUUrgxJIXoG(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L13
        L4:
            r0.addInt(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static int ANTsTVehlQXktGVz(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static double AWownTRVMgSKnxzJ(byte[] r2, int r3) {
            goto L36
        L4:
            goto L29
        L7:
            goto L19
        Lb:
            goto L7
        Le:
            goto L3d
        L12:
            r0 = 29
            goto L21
        L19:
            double r0 = decodedouble(r2, r3)
            goto L28
        L21:
            r1 = 18
            goto L46
        L28:
            return r0
        L29:
            goto Lb
        L2d:
            if (r0 <= 0) goto L32
            goto L7
        L32:
            goto L4
        L36:
            goto Le
        L39:
            goto L12
        L3d:
            goto L39
        L40:
            int r0 = r0 % r1
            goto L2d
        L46:
            int r0 = r0 + r1
            goto L40
    }

    public static androidx.datastore.preferences.protobuf.WireFormat.FieldType AZhRxyKfQAikZApi(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
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
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r1.getLiteType()
            goto Le
    }

    public static int AfaCoNLfYHqzIkQz(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
            goto Lc
        L4:
            int r0 = r1.ordinal()
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

    public static bool AfdOpafWKXLIQrTj(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Add(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int BMPfEOoWIyrGFHiI(int r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
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
            int r0 = skipField(r1, r2, r3, r4, r5)
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension BTEttLjHoHXOIbhp(androidx.datastore.preferences.protobuf.ExtensionRegistryLite r1, androidx.datastore.preferences.protobuf.MessageLite r2, int r3) {
            goto Lc
        L4:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension r0 = r1.findLiteExtensionByNumber(r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static bool BVtdvpqdDxbJhsUh(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.Add(r2)
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

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BZWdgItAgKkrEAuX() {
            goto L14
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag()
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

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BgQOnzwuQHfXYsPr() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8()
            goto L7
    }

    public static java.lang.int BrKegymlYeOdrULB(int r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object BvyzppsxMEKVHiLX(androidx.datastore.preferences.protobuf.FieldHashSet r1, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r2) {
            goto L11
        L4:
            java.lang.object r0 = r1.getField(r2)
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

    public static int ByknKPpTqErsmpod(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodePackedSInt32List(r1, r2, r3, r4)
            goto Lb
    }

    public static void CDMtLLxOeyWkJBla(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto Lb
        L4:
            r0.storeField(r1, r2)
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

    public static androidx.datastore.preferences.protobuf.bytestring CDOfGynzzJvdnCxW(byte[] r1, int r2, int r3) {
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
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.copyFrom(r1, r2, r3)
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.Schema CVLSopLJnvMwRDmQ(androidx.datastore.preferences.protobuf.Protobuf r1, java.lang.Class r2) {
            goto L11
        L4:
            androidx.datastore.preferences.protobuf.Schema r0 = r1.schemaFor(r2)
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

    public static int CyaWajMhJCyWJlRG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void DAEzuqWRkMzpZABE(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.setField(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.string DHGQLLMBxXTvAqdv(java.lang.stringBuilder r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.Class DMMoldHVrvsIoJFB(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.Class r0 = r1.GetType()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int DMnhVjGRMarrJWwc(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Lb
    }

    public static int DfzzRowdQawiClAB(java.lang.object r1, androidx.datastore.preferences.protobuf.Schema r2, byte[] r3, int r4, int r5, int r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = mergeGroupField(r1, r2, r3, r4, r5, r6, r7)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void DhNarFflxYoCUDys(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.storeField(r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static int DpsIgyJJdjitMvHM(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Lb
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException DrhtWdNlwXGHnyob() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.object EaaQTFVgGeGtNmYL(androidx.datastore.preferences.protobuf.Schema r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.newInstance()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.int EvSKsRiyCEVCEpYp(int r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int EyJqbZWDPkemYGjx(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int FBJCLYOWdoSeZXgv(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static double FYcjUVkMmQXpqlBy(byte[] r2, int r3) {
            goto L4
        L4:
            goto L43
        L7:
            goto L39
        Lb:
            int r0 = r0 % r1
            goto L20
        L11:
            r1 = 26
            goto L29
        L18:
            double r0 = decodedouble(r2, r3)
            goto L47
        L20:
            if (r0 <= 0) goto L25
            goto L35
        L25:
            goto L32
        L29:
            int r0 = r0 + r1
            goto Lb
        L2f:
            goto L7
        L32:
            goto L48
        L35:
            goto L18
        L39:
            r0 = 12
            goto L11
        L40:
            goto L35
        L43:
            goto L2f
        L47:
            return r0
        L48:
            goto L40
    }

    public static void FbawPqMkPYAaoTuR(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.addRepeatedField(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException FjeMSKgILENiNtoB() {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void FoxayBZhGTRpMWew(androidx.datastore.preferences.protobuf.floatList r0, float r1) {
            goto L13
        L4:
            r0.addfloat(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static int FpGPDomMTJTJpWTY(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
    }

    public static void FzpRTEbecjNjNVsr(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.setField(r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static int GAnObXQChaPMZWGp(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = decodeVarint64(r1, r2, r3)
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

    public static float GHozEzcLHEemPWNp(byte[] r1, int r2) {
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
            float r0 = decodefloat(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static void GTPjkcbgesnpPnFb(androidx.datastore.preferences.protobuf.Schema r0, java.lang.object r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
            goto Lb
        L4:
            r0.mergeFrom(r1, r2, r3, r4, r5)
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

    public static int GtbiqIikwpviGBvn(androidx.datastore.preferences.protobuf.WireFormat.FieldType r1) {
            goto L11
        L4:
            int r0 = r1.ordinal()
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

    public static int HCdaInoMxFpeqAwZ(int r1) {
            goto L14
        L4:
            int r0 = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(r1)
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

    public static void HLvJCsXLsOcXRWox(androidx.datastore.preferences.protobuf.boolList r0, bool r1) {
            goto L10
        L4:
            r0.addbool(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static int HUgkBqpErafFYnUA(byte[] r1, int r2) {
            goto L14
        L4:
            int r0 = decodeFixed32(r1, r2)
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

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException HguHiolEklIyJJgT() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int HhYglvQXkYVCUjLm(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodePackeddoubleList(r1, r2, r3, r4)
            goto Lb
    }

    public static int HiFQEgbROZrcZCMi(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static double HvIEwmXjskwkTLaX(byte[] r2, int r3) {
            goto L3d
        L4:
            return r0
        L5:
            goto L1c
        L9:
            goto L5
        Lc:
            goto L44
        L10:
            int r0 = r0 % r1
            goto L2a
        L16:
            int r0 = r0 + r1
            goto L10
        L1c:
            goto Lc
        L1f:
            goto L33
        L23:
            r0 = 32
            goto L36
        L2a:
            if (r0 <= 0) goto L2f
            goto Lc
        L2f:
            goto L9
        L33:
            goto L40
        L36:
            r1 = 20
            goto L16
        L3d:
            goto L1f
        L40:
            goto L23
        L44:
            double r0 = decodedouble(r2, r3)
            goto L4
    }

    public static int IGoDvupRUAHtiOPC(byte[] r1, int r2) {
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
            int r0 = decodeFixed32(r1, r2)
            goto L4
    }

    public static void IbxFbMgCPbTBXkzh(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.setField(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static int IhjRQnRgMXLyvfzT(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static int IncrwcsrOiEgtCbH(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.MessageLite IxlaZzNJMVCyqWMI(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
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
            androidx.datastore.preferences.protobuf.MessageLite r0 = r1.getMessageDefaultInstance()
            goto L4
        L18:
            goto Lc
    }

    public static void IyJwXHHhKgGGIOKL(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.addlong(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static int JQTnFCueXxNhikVf(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.object JWMSkHbZnSTWyYyi(androidx.datastore.preferences.protobuf.Schema r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.newInstance()
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

    public static int JXOLWmUtTietsZyS(int r1, byte[] r2, int r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodeVarint32(r1, r2, r3, r4)
            goto Lb
    }

    public static int JYKIKaXpfVFjOmnC(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
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
            int r0 = decodeMessageField(r1, r2, r3, r4, r5)
            goto L4
    }

    public static bool JdegvQSxCwoYwLdE(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int JgULPOGBpPEaAzgV(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L11
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static int JmAFLnNalFZWzMPZ(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void JpsLqStZIOPKfaAk(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.setField(r1, r2)
            goto Le
    }

    public static void JzdFhVkpycxkUjQa(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setField(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static int JzvnwOvGdRBaNPXC(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int KFFwLFkrrvOxQwVG(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
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
            int r0 = decodeGroupField(r1, r2, r3, r4, r5, r6)
            goto Le
    }

    public static int KWhIkfcLUjncQZjO(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint64(r1, r2, r3)
            goto Le
    }

    public static int KfAOWMQZtDxlPYFG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object KjGnmJgKAjFdGFbG(androidx.datastore.preferences.protobuf.FieldHashSet r1, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.getField(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.int KpILKEfldshiLfDX(int r1) {
            goto Lc
        L4:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException KyZhUtuOFaQMwBOk() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto Le
    }

    public static int LASrRibtVqtyPQQo(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static bool LDTPwapXrraXYmWQ(byte[] r1, int r2, int r3) {
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
            bool r0 = androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(r1, r2, r3)
            goto Lb
    }

    public static int LDZJppExjdLBucYz(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static androidx.datastore.preferences.protobuf.Internal.EnumLite LFLMyJDKIuVBEDBJ(androidx.datastore.preferences.protobuf.Internal.EnumLiteDictionary r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            androidx.datastore.preferences.protobuf.Internal$EnumLite r0 = r1.findValueByNumber(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int LGvBPUUXydNCPrDS(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool LQBjiGtysizPQlJC(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.Add(r2)
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

    public static void LXNKbcDWNQnghTHT(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.addInt(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static int LkchbQuMLnuqTtOa(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int LliTnEcDkHUwJfMJ(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void LzaoCnUVtEPoblBQ(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.storeField(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MHaANAqjUONfZgln() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static int MLAqQXXHWhbjobLA(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            int r0 = decodebytes(r1, r2, r3)
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

    public static void MLSnSDybeePxtIxK(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L10
        L4:
            r0.addInt(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static java.lang.double MiVKQRKqjGzqxxIc(double r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.double r0 = java.lang.double.valueOf(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException MoZIkpZfkXQptcHU() {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int MqFrnlthspwJdLEe(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static float MrircrAgRARWajaf(byte[] r1, int r2) {
            goto Lf
        L4:
            float r0 = decodefloat(r1, r2)
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

    public static int NFWNMDuvmXVCblFe(java.lang.object r1, androidx.datastore.preferences.protobuf.Schema r2, byte[] r3, int r4, int r5, int r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto Lc
        L4:
            int r0 = mergeGroupField(r1, r2, r3, r4, r5, r6, r7)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static void NLtMpozrFbIPcZmH(int r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            checkRecursionLimit(r0)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static float NNNpmKbuUBbCChmu(byte[] r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            float r0 = decodefloat(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void NQIyhHTHEwUPEBbb(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setField(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException NhtPPkPDADOMOVnp() {
            goto Lc
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
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

    public static long NufVKdNVuQJPAgXo(byte[] r2, int r3) {
            goto Lb
        L4:
            goto L36
        L7:
            goto L49
        Lb:
            goto L7
        Le:
            goto L1f
        L12:
            return r0
        L13:
            goto L4
        L17:
            long r0 = decodeFixed64(r2, r3)
            goto L12
        L1f:
            r0 = 19
            goto L26
        L26:
            r1 = 16
            goto L2d
        L2d:
            int r0 = r0 + r1
            goto L43
        L33:
            goto L13
        L36:
            goto L17
        L3a:
            if (r0 <= 0) goto L3f
            goto L36
        L3f:
            goto L33
        L43:
            int r0 = r0 % r1
            goto L3a
        L49:
            goto Le
    }

    public static java.lang.object OAyrfaawWEsEuIux(androidx.datastore.preferences.protobuf.Schema r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1.newInstance()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string OaVaifRvDBDUnKUm(byte[] r1, int r2, int r3) {
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
            java.lang.string r0 = androidx.datastore.preferences.protobuf.Utf8.decodeUtf8(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException OckPVmnRCBasDuXy() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.recursionLimitExceeded()
            goto L4
    }

    public static bool OfBRndYQMimvuVgJ(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
            goto Lc
        L4:
            bool r0 = r1.isRepeated()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static int OksdxfznULTcTFct(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static int PLBNaJFPQxIhOVUl(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static void PMCLyVtvcbhjRSzk(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto Lb
        L4:
            r0.setField(r1, r2)
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

    public static int PkJCcWYmWiCTLWAj(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
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
            int r0 = decodeGroupField(r1, r2, r3, r4, r5, r6)
            goto L4
        L18:
            goto Lc
    }

    public static int PqmyGraSsCPSBxOv(int r1) {
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
            int r0 = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(r1)
            goto L4
        L18:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.Protobuf PtfAVKZFlJZFPntW() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            androidx.datastore.preferences.protobuf.Protobuf r0 = androidx.datastore.preferences.protobuf.Protobuf.getInstance()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int QQKUVGpDRiItyYbC(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void QRZuzFDpRIjNHCfE(androidx.datastore.preferences.protobuf.doubleList r0, double r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.adddouble(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException QjpYNLUFqzTNBXhh() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure()
            goto Le
    }

    public static int QjsVEZnyMDCYRVrY(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void QytvzlmqEsWtnZgE(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.addInt(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static int RTbiEJPuEXrIpxsn(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodeVarint64(r1, r2, r3)
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

    public static java.lang.int RfFKhyqISLbKXtJP(int r1) {
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
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Le
    }

    public static void SBLRNWAlwEGAVPPs(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto Lb
        L4:
            r0.storeField(r1, r2)
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

    public static int SCGMObbLhqPSUFKi(int r1) {
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
            int r0 = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(r1)
            goto Lb
    }

    public static double SQWJjSmxVxXnGKQc(byte[] r2, int r3) {
            goto L13
        L4:
            if (r0 <= 0) goto L9
            goto L42
        L9:
            goto L3f
        Ld:
            int r0 = r0 + r1
            goto L46
        L13:
            goto L1d
        L16:
            goto L2e
        L1a:
            goto L42
        L1d:
            goto L35
        L21:
            return r0
        L22:
            goto L1a
        L26:
            double r0 = decodedouble(r2, r3)
            goto L21
        L2e:
            r0 = 5
            goto L38
        L35:
            goto L16
        L38:
            r1 = 32
            goto Ld
        L3f:
            goto L22
        L42:
            goto L26
        L46:
            int r0 = r0 % r1
            goto L4
    }

    public static int SXNHMnaekCWhgNMp(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException SfwkmPuPzwzpEmXR() {
            goto Lc
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
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

    public static int SkpcvuyUOaFORBEw(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.WireFormat.FieldType SmtoogvleURDYoVo(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
            goto L14
        L4:
            goto L17
        L7:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r1.getLiteType()
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

    public static int SsuTxqNEmngqdnKL(java.lang.object r1, androidx.datastore.preferences.protobuf.Schema r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
            goto L14
        L4:
            int r0 = mergeMessageField(r1, r2, r3, r4, r5, r6)
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

    public static int SuEsLwNKADmpBWuy(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
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
            int r0 = decodeMessageField(r1, r2, r3, r4, r5)
            goto L7
    }

    public static java.lang.long TKSzhhXPXDsYMJJn(long r1) {
            goto Lf
        L4:
            java.lang.long r0 = java.lang.long.valueOf(r1)
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

    public static androidx.datastore.preferences.protobuf.Internal.EnumLiteDictionary TMRDwAaXWGzXbije(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtensionDescriptor r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary r0 = r1.getEnumType()
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException TONrgEtdOZBHMLNv() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto L4
    }

    public static int TVmoDmqWQcYVmgYU(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException UFBDPmkFOoyWfkXx() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VAFZItytGOVodZvb() {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.Protobuf VATkpwMJVrNPTljS() {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            androidx.datastore.preferences.protobuf.Protobuf r0 = androidx.datastore.preferences.protobuf.Protobuf.getInstance()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VOyPFZVjvWMhbrVa() {
            goto L11
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
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

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VXYxyzPqWqxnpceX() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto L4
        L18:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VkBqfCxCupyuHgpN() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto Lb
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VvynvRxINXvJcnja() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure()
            goto L4
    }

    public static int VxYkcnFhbLohBftc(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool VxmwYrfDwhddXaIO(byte[] r1, int r2, int r3) {
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
            bool r0 = androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(r1, r2, r3)
            goto Lb
    }

    public static java.lang.stringBuilder VyOrNFnkAzZHTtOM(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static long WTkMZmncUahFmJPC(long r2) {
            goto L45
        L4:
            return r0
        L5:
            goto L3e
        L9:
            goto L5
        Lc:
            goto L30
        L10:
            if (r0 <= 0) goto L15
            goto Lc
        L15:
            goto L9
        L19:
            int r0 = r0 % r1
            goto L10
        L1f:
            r1 = 20
            goto L38
        L26:
            goto L48
        L29:
            r0 = 19
            goto L1f
        L30:
            long r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r2)
            goto L4
        L38:
            int r0 = r0 + r1
            goto L19
        L3e:
            goto Lc
        L41:
            goto L26
        L45:
            goto L41
        L48:
            goto L29
    }

    public static bool WcwCLyZRNkDEtRFh(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static void WyAfUMfBZiqsHUDa(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.addlong(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static float XLMrooUiEWXaqQGk(byte[] r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            float r0 = decodefloat(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.int XOgZZccejsyVAVtl(int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto Le
    }

    public static void YCMxBUOqCxWVEIvd(androidx.datastore.preferences.protobuf.boolList r0, bool r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.addbool(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException YaHIDSsJnASKUNff() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto Lb
    }

    public static int YkacpBsTACaMMqCd(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lc
        L4:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static void YrXnBFQpqqbzVvbU(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L13
        L4:
            r0.addlong(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static int YuFxwrXBGeLgikGk(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = decodestring(r1, r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int ZGXBznERHwPInBOJ(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static long ZYuRPSPJGkzyUwAs(long r2) {
            goto L3c
        L4:
            int r0 = r0 % r1
            goto L43
        La:
            int r0 = r0 + r1
            goto L4
        L10:
            r0 = 21
            goto L29
        L17:
            goto L33
        L1a:
            goto L1e
        L1e:
            goto L3f
        L21:
            long r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r2)
            goto L37
        L29:
            r1 = 27
            goto La
        L30:
            goto L38
        L33:
            goto L21
        L37:
            return r0
        L38:
            goto L17
        L3c:
            goto L1a
        L3f:
            goto L10
        L43:
            if (r0 <= 0) goto L48
            goto L33
        L48:
            goto L30
    }

    public static int ZngVkwTmcwhlJcWm(int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static androidx.datastore.preferences.protobuf.bytestring ZqpXLggXefajqELQ(byte[] r1, int r2, int r3) {
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
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.copyFrom(r1, r2, r3)
            goto L7
    }

    public static int ZwFhrmYCqiohPcok(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZyqySLtSzmgOHJFr() {
            goto Lf
        L4:
            goto L12
        L7:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
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

    public static androidx.datastore.preferences.protobuf.bytestring ALMVyceJxIREIdUR(byte[] r1, int r2, int r3) {
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
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.copyFrom(r1, r2, r3)
            goto L4
    }

    public static int AVOuvBoHtuMJLaCL(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static void AWyWXzuadoZmKeTh(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.addInt(r1)
            goto Lb
    }

    public static void AqCbHioNuFdsLkOE(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.addlong(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BEZFqPAMrKuaDeLB() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException BukmplxyxFmbvweL() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto Le
    }

    public static long BxuMBECKCKwmOnja(byte[] r2, int r3) {
            goto La
        L4:
            int r0 = r0 + r1
            goto L24
        La:
            goto L20
        Ld:
            goto L3a
        L11:
            return r0
        L12:
            goto L1d
        L16:
            goto L12
        L19:
            goto L44
        L1d:
            goto L19
        L20:
            goto L41
        L24:
            int r0 = r0 % r1
            goto L2a
        L2a:
            if (r0 <= 0) goto L2f
            goto L19
        L2f:
            goto L16
        L33:
            r1 = 20
            goto L4
        L3a:
            r0 = 15
            goto L33
        L41:
            goto Ld
        L44:
            long r0 = decodeFixed64(r2, r3)
            goto L11
    }

    public static java.lang.long CAfuCocyGIwoBsFI(long r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.long r0 = java.lang.long.valueOf(r1)
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

    public static androidx.datastore.preferences.protobuf.Internal.EnumLiteDictionary CGXcbkCyYdrkHXlT(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtensionDescriptor r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary r0 = r1.getEnumType()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object CHPUJGkJdhsddEdL(java.lang.object r1, int r2, java.util.List r3, androidx.datastore.preferences.protobuf.Internal.EnumLiteDictionary r4, java.lang.object r5, androidx.datastore.preferences.protobuf.UnknownFieldSchema r6) {
            goto L11
        L4:
            java.lang.object r0 = androidx.datastore.preferences.protobuf.SchemaUtil.filterUnknownEnumList(r1, r2, r3, r4, r5, r6)
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

    public static int CUCdnrZfVBkwyqsS(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint64(r1, r2, r3)
            goto Lb
    }

    public static androidx.datastore.preferences.protobuf.FieldHashSet CUGOsMaMnlVjoeZa(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtendableMessage r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            androidx.datastore.preferences.protobuf.FieldHashSet r0 = r1.ensureExtensionsAreMutable()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void CgmDQbGBhsMrEAfy(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L10
        L4:
            r0.setField(r1, r2)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    private static void CheckRecursionLimit(int r1) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L13
        Lc:
            goto L2b
        Lf:
            goto L1b
        L13:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r1 = OckPVmnRCBasDuXy()
            goto L2a
        L1b:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.recursionLimit
            goto L21
        L21:
            if (r1 < r0) goto L26
            goto L8
        L26:
            goto L7
        L2a:
            throw r1
        L2b:
            goto L4
    }

    public static long CpqEkkbgxQKUWtYe(long r2) {
            goto L45
        L4:
            r0 = 4
            goto L1a
        Lb:
            goto L13
        Le:
            goto L37
        L12:
            return r0
        L13:
            goto L30
        L17:
            goto L48
        L1a:
            r1 = 30
            goto L3f
        L21:
            int r0 = r0 % r1
            goto L27
        L27:
            if (r0 <= 0) goto L2c
            goto Le
        L2c:
            goto Lb
        L30:
            goto Le
        L33:
            goto L17
        L37:
            long r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r2)
            goto L12
        L3f:
            int r0 = r0 + r1
            goto L21
        L45:
            goto L33
        L48:
            goto L4
    }

    public static int CwqoPmTiPmLxJmlV(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int DIWMDLTnfGYDxttk(int r1) {
            goto L14
        L4:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
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

    public static java.lang.bool DNAHMNvuZoWwQfRA(bool r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    static int DecodeBoolList(int r7, byte[] r8, int r9, int r10, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r11, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r12) {
            goto L21
        L4:
            int r0 = (r5 > r2 ? 1 : (r5 == r2 ? 0 : -1))
            goto L3c
        La:
            goto L52
        Lb:
            goto L56
        Lf:
            goto L82
        L10:
            goto L81
        L14:
            androidx.datastore.preferences.protobuf.boolList r11 = (androidx.datastore.preferences.protobuf.boolList) r11
            goto La7
        L1a:
            HLvJCsXLsOcXRWox(r11, r0)
            goto La
        L21:
            goto L4b
        L24:
            goto Ld3
        L28:
            r1 = 6
            goto Le5
        L2f:
            goto L57
        L32:
            goto L14
        L36:
            long r0 = r12.long1
            goto L6a
        L3c:
            if (r0 != 0) goto L41
            goto La3
        L41:
            goto Lce
        L45:
            goto L24
        L48:
            goto L32
        L4b:
            goto L45
        L4f:
            jKrJkFNFJaeMWIWP(r11, r0)
        L52:
            goto L86
        L56:
            return r9
        L57:
            goto L48
        L5b:
            if (r0 <= 0) goto L60
            goto L32
        L60:
            goto L2f
        L64:
            int r0 = r0 % r1
            goto L5b
        L6a:
            r2 = 0
            goto Ldf
        L70:
            if (r7 != r5) goto L75
            goto Lca
        L75:
            goto Lc8
        L79:
            int r0 = oRZuIwwtCNmxWjVR(r8, r9, r12)
            goto Lbd
        L81:
            r0 = r4
        L82:
            goto L4f
        L86:
            if (r9 < r10) goto L8b
            goto Lb
        L8b:
            goto L79
        L8f:
            r0 = r1
            goto Lf
        L94:
            int r9 = ZGXBznERHwPInBOJ(r8, r0, r12)
            goto L9c
        L9c:
            long r5 = r12.long1
            goto L4
        La2:
            goto Ldb
        La3:
            goto Lda
        La7:
            int r9 = qXFJtsJKxmBBDhLG(r8, r9, r12)
            goto L36
        Laf:
            if (r0 != 0) goto Lb4
            goto L10
        Lb4:
            goto L8f
        Lb8:
            r4 = 0
            goto Laf
        Lbd:
            int r5 = r12.int1
            goto L70
        Lc3:
            r1 = 1
            goto Lb8
        Lc8:
            goto Lb
        Lca:
            goto L94
        Lce:
            r0 = r1
            goto La2
        Ld3:
            r0 = 22
            goto L28
        Lda:
            r0 = r4
        Ldb:
            goto L1a
        Ldf:
            int r0 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto Lc3
        Le5:
            int r0 = r0 + r1
            goto L64
    }

    static int Decodebytes(byte[] r2, int r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L8a
        L4:
            goto L86
        L7:
            goto La2
        Lb:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = VOyPFZVjvWMhbrVa()
            goto L13
        L13:
            throw r2
        L14:
            goto L4
        L18:
            androidx.datastore.preferences.protobuf.bytestring r2 = aLMVyceJxIREIdUR(r2, r3, r0)
            goto Laf
        L20:
            return r3
        L21:
            goto L18
        L25:
            int r1 = r2.length
            goto Laa
        L2a:
            if (r0 == 0) goto L2f
            goto L21
        L2f:
            goto L33
        L33:
            androidx.datastore.preferences.protobuf.bytestring r2 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto L5c
        L39:
            r0 = 23
            goto L67
        L40:
            int r0 = r0 + r1
            goto L6e
        L46:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = bukmplxyxFmbvweL()
            goto L4e
        L4e:
            throw r2
        L4f:
            goto Lb
        L53:
            if (r0 <= r1) goto L58
            goto L63
        L58:
            goto L2a
        L5c:
            r4.object1 = r2
            goto L20
        L62:
            return r3
        L63:
            goto L46
        L67:
            r1 = 6
            goto L40
        L6e:
            int r0 = r0 % r1
            goto L7a
        L74:
            int r0 = r4.int1
            goto L99
        L7a:
            if (r0 <= 0) goto L7f
            goto L86
        L7f:
            goto L83
        L83:
            goto L14
        L86:
            goto L91
        L8a:
            goto L7
        L8d:
            goto L39
        L91:
            int r3 = HiFQEgbROZrcZCMi(r2, r3, r4)
            goto L74
        L99:
            if (r0 >= 0) goto L9e
            goto L4f
        L9e:
            goto L25
        La2:
            goto L8d
        La5:
            int r3 = r3 + r0
            goto L62
        Laa:
            int r1 = r1 - r3
            goto L53
        Laf:
            r4.object1 = r2
            goto La5
    }

    static int DecodebytesList(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L58
        L4:
            vcYeksLvcPCpuufs(r6, r1)
        L7:
            goto Lee
        Lb:
            int r0 = r0 % r1
            goto L46
        L11:
            return r4
        L12:
            goto L91
        L16:
            goto Lfd
        L19:
            goto L80
        L1d:
            int r1 = r1 - r4
            goto L130
        L22:
            int r0 = r7.int1
            goto L111
        L28:
            trEbMKnNcTQbTKrf(r6, r1)
            goto L11a
        L2f:
            int r1 = r3.length
            goto L39
        L34:
            throw r2
        L35:
            goto Lc7
        L39:
            int r1 = r1 - r4
            goto L4f
        L3e:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = KyZhUtuOFaQMwBOk()
            goto Le9
        L46:
            if (r0 <= 0) goto L4b
            goto Lfd
        L4b:
            goto Lfa
        L4f:
            if (r0 <= r1) goto L54
            goto L11c
        L54:
            goto Lbe
        L58:
            goto L19
        L5b:
            goto L139
        L5f:
            if (r0 >= 0) goto L64
            goto Lad
        L64:
            goto La7
        L68:
            int r0 = jexAVTXvPIFzXMKN(r3, r4, r7)
            goto L83
        L70:
            int r0 = r7.int1
            goto L5f
        L76:
            goto Lef
        L77:
            goto L99
        L7b:
            goto Ldc
        L7c:
            goto Lb1
        L80:
            goto L5b
        L83:
            int r1 = r7.int1
            goto L127
        L89:
            int r4 = tKvNMIBJdUAdSwxg(r3, r4, r7)
            goto L70
        L91:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = DrhtWdNlwXGHnyob()
            goto Lac
        L99:
            androidx.datastore.preferences.protobuf.bytestring r1 = CDOfGynzzJvdnCxW(r3, r4, r0)
            goto L4
        La1:
            int r0 = r0 + r1
            goto Lb
        La7:
            int r1 = r3.length
            goto L1d
        Lac:
            throw r2
        Lad:
            goto L3e
        Lb1:
            int r4 = ZwFhrmYCqiohPcok(r3, r0, r7)
            goto L22
        Lb9:
            goto Lef
        Lba:
            goto L140
        Lbe:
            if (r0 == 0) goto Lc3
            goto Lba
        Lc3:
            goto Lcf
        Lc7:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = vIyrKwqoWoQFpUJF()
            goto Ldb
        Lcf:
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto L101
        Ld5:
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto Lf3
        Ldb:
            throw r2
        Ldc:
            goto L11
        Le0:
            if (r0 == 0) goto Le5
            goto L77
        Le5:
            goto Ld5
        Le9:
            throw r2
        Lea:
            goto L16
        Lee:
            int r4 = r4 + r0
        Lef:
            goto L108
        Lf3:
            LQBjiGtysizPQlJC(r6, r0)
            goto L76
        Lfa:
            goto Lea
        Lfd:
            goto L89
        L101:
            mOPVaQQLfmLaRYIH(r6, r0)
            goto Lb9
        L108:
            if (r4 < r5) goto L10d
            goto Ldc
        L10d:
            goto L68
        L111:
            if (r0 >= 0) goto L116
            goto L35
        L116:
            goto L2f
        L11a:
            goto L7
        L11c:
            goto L148
        L120:
            r1 = 12
            goto La1
        L127:
            if (r2 != r1) goto L12c
            goto L7c
        L12c:
            goto L7b
        L130:
            if (r0 <= r1) goto L135
            goto L12
        L135:
            goto Le0
        L139:
            r0 = 28
            goto L120
        L140:
            androidx.datastore.preferences.protobuf.bytestring r1 = ZqpXLggXefajqELQ(r3, r4, r0)
            goto L28
        L148:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = NhtPPkPDADOMOVnp()
            goto L34
    }

    static double Decodedouble(byte[] r0, int r1) {
            goto Lf
        L4:
            double r0 = jldiEBOggoHKmVYF(r0)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L1b
        L16:
            return r0
        L17:
            goto Lc
        L1b:
            long r0 = zthNNneFkvzWnDXt(r0, r1)
            goto L4
    }

    static int DecodedoubleList(int r3, byte[] r4, int r5, int r6, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) {
            goto L47
        L4:
            int r5 = r0 + 8
            goto L53
        La:
            return r5
        Lb:
            goto L71
        Lf:
            androidx.datastore.preferences.protobuf.doubleList r7 = (androidx.datastore.preferences.protobuf.doubleList) r7
            goto L58
        L15:
            goto Lb
        L18:
            goto Lf
        L1c:
            r1 = 4
            goto L8e
        L23:
            kEYHPNLLmRHXNxEC(r7, r1)
            goto L4
        L2a:
            int r0 = r0 % r1
            goto L30
        L30:
            if (r0 <= 0) goto L35
            goto L18
        L35:
            goto L15
        L39:
            int r1 = r8.int1
            goto L7f
        L3f:
            double r1 = SQWJjSmxVxXnGKQc(r4, r0)
            goto L23
        L47:
            goto L74
        L4a:
            goto L94
        L4e:
            goto L54
        L4f:
            goto L3f
        L53:
            goto L8a
        L54:
            goto La
        L58:
            double r0 = HvIEwmXjskwkTLaX(r4, r5)
            goto L78
        L60:
            int r0 = LASrRibtVqtyPQQo(r4, r5, r8)
            goto L39
        L68:
            if (r5 < r6) goto L6d
            goto L54
        L6d:
            goto L60
        L71:
            goto L18
        L74:
            goto L9b
        L78:
            QRZuzFDpRIjNHCfE(r7, r0)
            goto L88
        L7f:
            if (r3 != r1) goto L84
            goto L4f
        L84:
            goto L4e
        L88:
            int r5 = r5 + 8
        L8a:
            goto L68
        L8e:
            int r0 = r0 + r1
            goto L2a
        L94:
            r0 = 1
            goto L1c
        L9b:
            goto L4a
    }

    static int DecodeExtension(int r7, byte[] r8, int r9, int r10, androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtendableMessage<object, object> r11, androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension<object, object> r12, androidx.datastore.preferences.protobuf.UnknownFieldSchema<androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite> r13, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r14) throws java.io.IOException {
            goto L488
        L4:
            r1 = r7
            goto L27e
        L9:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r8 = r12.descriptor
            goto L1ee
        Lf:
            int r7 = JzvnwOvGdRBaNPXC(r7)
            goto L46f
        L17:
            DAEzuqWRkMzpZABE(r0, r9, r7)
            goto L5d1
        L1e:
            androidx.datastore.preferences.protobuf.IntList r7 = new androidx.datastore.preferences.protobuf.IntList
            goto L64b
        L24:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L1e7
        L2a:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L221
        L30:
            bool r7 = fTDsotyDjVllANGa(r7)
            goto L529
        L38:
            r1 = 18
            goto L516
        L3f:
            r10 = r8
            goto L3e2
        L44:
            r11 = r9
            goto L497
        L49:
            r7.<init>()
            goto Le2
        L50:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L63d
        L56:
            r6 = r13
            goto L67c
        L5b:
            int r8 = hGkojDDwRgACtZjA(r8, r9, r7, r14)
            goto L645
        L63:
            int r8 = ByknKPpTqErsmpod(r8, r9, r7, r14)
            goto L24
        L6b:
            IbxFbMgCPbTBXkzh(r0, r9, r7)
            goto L372
        L72:
            r10 = r8
            goto L4b4
        L77:
            int r7 = gWzWHbtoNywBOXWy(r8, r9, r3, r14)
            goto L34e
        L7f:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r11 = r12.descriptor
            goto L4ca
        L85:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r8 = r12.descriptor
            goto L4b9
        L8b:
            java.lang.long r13 = wSKtSYvDKlpNRQZe(r7)
            goto L59f
        L93:
            int r8 = r14.int1
            goto L16c
        L99:
            androidx.datastore.preferences.protobuf.Schema r2 = qzGZUVfqVBVKeJuE(r7, r11)
            goto L254
        La1:
            java.lang.object r7 = fKqTLOrwBPgwMmxQ(r2)
            goto L7f
        La9:
            r2 = r10
            goto L6ae
        Lae:
            int r7 = DfzzRowdQawiClAB(r8, r9, r10, r11, r12, r13, r14)
            goto L326
        Lb6:
            java.lang.string r9 = "Type cannot be packed: "
            goto L2f9
        Lbc:
            r14 = r6
            goto Lae
        Lc1:
            goto L5c7
        Lc4:
            goto L4d1
        Lc8:
            int r8 = HhYglvQXkYVCUjLm(r8, r9, r7, r14)
            goto L2a
        Ld0:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L6e1
        Ld6:
            r7.<init>(r8)
            goto L45a
        Ldd:
            r8 = r7
            goto L5f1
        Le2:
            int r8 = rWbChfdICPIFUNFG(r8, r9, r7, r14)
            goto L1b3
        Lea:
            r3.<init>()
            goto L77
        Lf1:
            if (r7 != 0) goto Lf6
            goto L186
        Lf6:
            goto L36a
        Lfa:
            int r7 = SsuTxqNEmngqdnKL(r1, r2, r3, r4, r5, r6)
            goto L665
        L102:
            FbawPqMkPYAaoTuR(r0, r8, r9)
            goto L2be
        L109:
            long r7 = r6.long1
            goto L117
        L10f:
            bool r7 = OfBRndYQMimvuVgJ(r12)
            goto L3e7
        L117:
            r10 = 0
            goto L3d5
        L11d:
            if (r7 != 0) goto L122
            goto L402
        L122:
            goto L1ad
        L126:
            r7.<init>()
            goto L1bf
        L12d:
            int r7 = r2 << 3
            goto L6d5
        L133:
            r6 = r14
            goto L3b1
        L138:
            double r7 = FYcjUVkMmQXpqlBy(r10, r11)
            goto L428
        L140:
            int r8 = sJWMkOpTFNMmBPML(r8, r9, r7, r14)
            goto L477
        L148:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r8 = r12.descriptor
            goto L58f
        L14e:
            r1 = r9
            goto La9
        L153:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L384
        L159:
            r4 = r10
            goto L32b
        L15e:
            int r11 = GtbiqIikwpviGBvn(r11)
            goto L3c2
        L166:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L4d4
        L16c:
            androidx.datastore.preferences.protobuf.Internal$EnumLite r7 = LFLMyJDKIuVBEDBJ(r7, r8)
            goto L33d
        L174:
            androidx.datastore.preferences.protobuf.IntList r7 = new androidx.datastore.preferences.protobuf.IntList
            goto L5b0
        L17a:
            r6 = r14
            goto L26c
        L17f:
            androidx.datastore.preferences.protobuf.boolList r7 = new androidx.datastore.preferences.protobuf.boolList
            goto L66a
        L185:
            return r7
        L186:
            goto L50
        L18a:
            java.lang.int r13 = BrKegymlYeOdrULB(r7)
            goto L31c
        L192:
            int r7 = tSclREREjvNmJGxV(r10, r11)
            goto L18a
        L19a:
            goto L3ad
        L19c:
            goto L2a2
        L1a0:
            androidx.datastore.preferences.protobuf.MessageLite r11 = wfRrbDJUOhQQopzo(r12)
            goto L290
        L1a8:
            r11 = r9
            goto L138
        L1ad:
            int[] r7 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType
            goto L346
        L1b3:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L69a
        L1b9:
            int[] r7 = androidx.datastore.preferences.protobuf.ArrayDecoders.C04101.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType
            goto L6fc
        L1bf:
            int r8 = vvjuuGtJkvzRbPIv(r8, r9, r7, r14)
            goto L5a5
        L1c7:
            r6 = r14
            goto L3a3
        L1cc:
            goto L3ad
        L1ce:
            goto L43e
        L1d2:
            JzdFhVkpycxkUjQa(r0, r7, r13)
            goto L53a
        L1d9:
            int r0 = r0 % r1
            goto L3b9
        L1df:
            java.lang.long r13 = hAOyoGFgHVjhhbtG(r7)
            goto L205
        L1e7:
            vdOMDvhZvpCDONqU(r0, r9, r7)
            goto L47d
        L1ee:
            fyFLaWhZSIwuQiNf(r0, r8, r7)
        L1f1:
            goto Ldd
        L1f5:
            r10 = r8
            goto L274
        L1fa:
            r11 = r9
            goto L17a
        L1ff:
            int r7 = r14.int1
            goto L2c9
        L205:
            goto L42c
        L207:
            goto L658
        L20b:
            int r9 = VxYkcnFhbLohBftc(r10, r11, r6)
            goto L2c3
        L213:
            java.lang.Class r8 = DMMoldHVrvsIoJFB(r8)
            goto L688
        L21b:
            androidx.datastore.preferences.protobuf.longList r7 = new androidx.datastore.preferences.protobuf.longList
            goto L126
        L221:
            kGMPPVuqmBQtwaiA(r0, r9, r7)
            goto L401
        L228:
            androidx.datastore.preferences.protobuf.MessageLite r8 = IxlaZzNJMVCyqWMI(r12)
            goto L213
        L230:
            goto L3ad
        L232:
            goto L44d
        L236:
            if (r7 == r11) goto L23b
            goto L46b
        L23b:
            goto L608
        L23f:
            r6 = r14
            goto L20b
        L244:
            androidx.datastore.preferences.protobuf.Protobuf r7 = VATkpwMJVrNPTljS()
            goto L1a0
        L24c:
            long r7 = gvoMLPBqHHNWUftL(r10, r11)
            goto L1df
        L254:
            bool r7 = gAjPnwRKVZkDYMSI(r12)
            goto Lf1
        L25c:
            int r9 = SXNHMnaekCWhgNMp(r10, r11, r6)
            goto L109
        L264:
            float r7 = GHozEzcLHEemPWNp(r10, r11)
            goto L2dc
        L26c:
            int r9 = MLAqQXXHWhbjobLA(r10, r11, r6)
            goto L676
        L274:
            r11 = r9
            goto L283
        L279:
            r11 = r9
            goto L1c7
        L27e:
            r3 = r8
            goto L690
        L283:
            r6 = r14
            goto L532
        L288:
            androidx.datastore.preferences.protobuf.Protobuf r7 = PtfAVKZFlJZFPntW()
            goto L228
        L290:
            java.lang.Class r11 = xvzGZQBrDRpOHFph(r11)
            goto L99
        L298:
            return r9
        L299:
            goto L49d
        L29d:
            r5 = 0
            goto L671
        L2a2:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L417
        L2a8:
            java.lang.bool r13 = dNAHMNvuZoWwQfRA(r7)
            goto L4f6
        L2b0:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L1d2
        L2b6:
            long r7 = cpqEkkbgxQKUWtYe(r7)
            goto L8b
        L2be:
            return r7
        L2bf:
            goto L4dc
        L2c3:
            long r7 = r6.long1
            goto L635
        L2c9:
            oNPpEEVmDLMdfyDZ(r1, r2, r7, r13, r6)
            goto L298
        L2d0:
            FzpRTEbecjNjNVsr(r0, r9, r7)
            goto L443
        L2d7:
            r6 = r14
            goto Lfa
        L2dc:
            java.lang.float r13 = lhHBAuUnBoxDcMIg(r7)
        L2e0:
            goto L652
        L2e4:
            java.lang.object r13 = r6.object1
            goto L1cc
        L2ea:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L30
        L2f0:
            if (r7 == 0) goto L2f5
            goto L4cd
        L2f5:
            goto La1
        L2f9:
            r8.<init>(r9)
            goto L6db
        L300:
            java.lang.int r13 = XOgZZccejsyVAVtl(r7)
            goto L438
        L308:
            int r8 = luMXdbijbsHbFvgQ(r8, r9, r7, r14)
            goto L153
        L310:
            r7.<init>()
            goto L308
        L317:
            return r8
        L318:
            goto L41d
        L31c:
            goto L2e0
        L31d:
            goto L3f
        L321:
            r11 = r9
            goto L23f
        L326:
            return r7
        L327:
            goto L1f5
        L32b:
            r6 = r14
            goto L423
        L330:
            bool r7 = oaViDsqBvIHbwQud(r7)
            goto L11d
        L338:
            goto L3ad
        L339:
            goto L354
        L33d:
            if (r7 == 0) goto L342
            goto L299
        L342:
            goto L1ff
        L346:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r10 = SmtoogvleURDYoVo(r12)
            goto L65d
        L34e:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r8 = r12.descriptor
            goto L430
        L354:
            r10 = r8
            goto L1a8
        L359:
            r7 = r7[r10]
            switch(r7) {
                case 1: goto L318;
                case 2: goto L696;
                case 3: goto L5d2;
                case 4: goto L5d2;
                case 5: goto L373;
                case 6: goto L373;
                case 7: goto L5e8;
                case 8: goto L5e8;
                case 9: goto L3fd;
                case 10: goto L3fd;
                case 11: goto L47e;
                case 12: goto L444;
                case 13: goto L51d;
                case 14: goto L378;
                default: goto L35e;
            }
        L35e:
            goto L61b
        L362:
            java.lang.object r7 = KjGnmJgKAjFdGFbG(r0, r7)
            goto L40e
        L36a:
            int r7 = JYKIKaXpfVFjOmnC(r2, r8, r9, r10, r14)
            goto L6f6
        L372:
            return r8
        L373:
            goto L1e
        L377:
            throw r7
        L378:
            goto L510
        L37c:
            int r9 = zlpIaWkZMcNhySeh(r10, r11, r6)
            goto L4bf
        L384:
            NQIyhHTHEwUPEBbb(r0, r9, r7)
            goto L695
        L38b:
            r5 = r13
            goto L406
        L390:
            androidx.datastore.preferences.protobuf.IntList r7 = new androidx.datastore.preferences.protobuf.IntList
            goto L49
        L396:
            r7.<init>()
            goto L521
        L39d:
            long r7 = r6.long1
            goto L2b6
        L3a3:
            int r9 = fXdeegLySYGOvJAa(r10, r11, r6)
            goto L39d
        L3ab:
            int r9 = r11 + 8
        L3ad:
            goto L48f
        L3b1:
            int r9 = JgULPOGBpPEaAzgV(r10, r11, r6)
            goto L621
        L3b9:
            if (r0 <= 0) goto L3be
            goto L5c7
        L3be:
            goto L5c4
        L3c2:
            r7 = r7[r11]
            switch(r7) {
                case 1: goto L339;
                case 2: goto L232;
                case 3: goto L43a;
                case 4: goto L43a;
                case 5: goto L207;
                case 6: goto L207;
                case 7: goto L31d;
                case 8: goto L31d;
                case 9: goto L4f8;
                case 10: goto L4f8;
                case 11: goto L484;
                case 12: goto L5a1;
                case 13: goto L45b;
                case 14: goto L19c;
                case 15: goto L1ce;
                case 16: goto L327;
                case 17: goto L666;
                case 18: goto L499;
                default: goto L3c7;
            }
        L3c7:
            goto L44
        L3cb:
            r6 = r14
            goto L37c
        L3d0:
            r6 = r14
            goto L25c
        L3d5:
            int r7 = (r7 > r10 ? 1 : (r7 == r10 ? 0 : -1))
            goto L596
        L3db:
            zlJfZLEpwTCtSTiE(r0, r7, r13)
            goto L5db
        L3e2:
            r11 = r9
            goto L24c
        L3e7:
            if (r7 != 0) goto L3ec
            goto L2bf
        L3ec:
            goto L14e
        L3f0:
            int r2 = r7 >>> 3
            goto L2ea
        L3f6:
            androidx.datastore.preferences.protobuf.FieldHashSet<androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor> r0 = r11.extensions
            goto L3f0
        L3fc:
            return r8
        L3fd:
            goto L390
        L401:
            return r8
        L402:
            goto L5ec
        L406:
            int r7 = PkJCcWYmWiCTLWAj(r1, r2, r3, r4, r5, r6)
            goto L85
        L40e:
            if (r7 == 0) goto L413
            goto L1f1
        L413:
            goto L452
        L417:
            java.lang.string r8 = "Shouldn't reach here."
            goto Ld6
        L41d:
            androidx.datastore.preferences.protobuf.doubleList r7 = new androidx.datastore.preferences.protobuf.doubleList
            goto L5e0
        L423:
            r10 = r8
            goto L12d
        L428:
            java.lang.double r13 = MiVKQRKqjGzqxxIc(r7)
        L42c:
            goto L3ab
        L430:
            androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary r4 = TMRDwAaXWGzXbije(r8)
            goto L29d
        L438:
            goto L3ad
        L43a:
            goto L683
        L43e:
            r10 = r8
            goto L1fa
        L443:
            return r8
        L444:
            goto L174
        L448:
            r11 = r9
            goto L159
        L44d:
            r10 = r8
            goto L5d6
        L452:
            java.lang.object r7 = OAyrfaawWEsEuIux(r9)
            goto L9
        L45a:
            throw r7
        L45b:
            goto L5ab
        L45f:
            r6 = r13
            goto L6b9
        L464:
            r11 = r9
            goto L3d0
        L469:
            goto L3ad
        L46b:
            goto L1b9
        L46f:
            java.lang.int r13 = RfFKhyqISLbKXtJP(r7)
            goto L482
        L477:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L17
        L47d:
            return r8
        L47e:
            goto L17f
        L482:
            goto L3ad
        L484:
            goto L4c5
        L488:
            goto Lc4
        L48b:
            goto L588
        L48f:
            bool r7 = lFOoTAncjeBQezQX(r12)
            goto L6ed
        L497:
            goto L3ad
        L499:
            goto L244
        L49d:
            int r7 = r14.int1
            goto L501
        L4a3:
            androidx.datastore.preferences.protobuf.longList r7 = new androidx.datastore.preferences.protobuf.longList
            goto L509
        L4a9:
            java.lang.object r9 = r14.object1
            goto L5bd
        L4af:
            r13 = 0
            goto L236
        L4b4:
            r11 = r9
            goto L133
        L4b9:
            java.lang.object r9 = r6.object1
            goto L102
        L4bf:
            int r7 = r6.int1
            goto L300
        L4c5:
            r10 = r8
            goto L464
        L4ca:
            gsVxITQOPTmZMtUr(r0, r11, r7)
        L4cd:
            goto L4
        L4d1:
            goto L48b
        L4d4:
            androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary r7 = cGXcbkCyYdrkHXlT(r7)
            goto L93
        L4dc:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L362
        L4e2:
            goto L6aa
        L4e4:
            goto L6a9
        L4e8:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r9 = yjQrYWDRhxjUxotl(r9)
            goto L6a1
        L4f0:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L3db
        L4f6:
            goto L3ad
        L4f8:
            goto L6e8
        L4fc:
            r11 = r9
            goto L192
        L501:
            java.lang.int r13 = KpILKEfldshiLfDX(r7)
            goto L469
        L509:
            r7.<init>()
            goto L62d
        L510:
            androidx.datastore.preferences.protobuf.IntList r3 = new androidx.datastore.preferences.protobuf.IntList
            goto Lea
        L516:
            int r0 = r0 + r1
            goto L1d9
        L51c:
            return r7
        L51d:
            goto L4a3
        L521:
            int r8 = yicboNlbUocXBLXD(r8, r9, r7, r14)
            goto Ld0
        L529:
            if (r7 != 0) goto L52e
            goto L402
        L52e:
            goto L5f6
        L532:
            int r9 = YuFxwrXBGeLgikGk(r10, r11, r6)
            goto L2e4
        L53a:
            return r9
        L584:
            goto Lc1
        L588:
            r0 = 28
            goto L38
        L58f:
            JpsLqStZIOPKfaAk(r0, r8, r3)
            goto L51c
        L596:
            if (r7 != 0) goto L59b
            goto L4e4
        L59b:
            goto L6c1
        L59f:
            goto L3ad
        L5a1:
            goto L72
        L5a5:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L6b
        L5ab:
            r10 = r8
            goto L279
        L5b0:
            r7.<init>()
            goto L63
        L5b7:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r11 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.ENUM
            goto L4af
        L5bd:
            wzTjLpIVtgVkeXjA(r0, r8, r9)
            goto L185
        L5c4:
            goto L584
        L5c7:
            goto L3f6
        L5cb:
            java.lang.stringBuilder r8 = new java.lang.stringBuilder
            goto Lb6
        L5d1:
            return r8
        L5d2:
            goto L610
        L5d6:
            r11 = r9
            goto L264
        L5db:
            return r9
        L5dc:
            goto L2b0
        L5e0:
            r7.<init>()
            goto Lc8
        L5e7:
            return r8
        L5e8:
            goto L21b
        L5ec:
            r1 = r11
            goto L45f
        L5f1:
            r12 = r4
            goto Lbc
        L5f6:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r7 = r12.descriptor
            goto L330
        L5fc:
            r7.<init>(r8)
            goto L377
        L603:
            r5 = r10
            goto L2d7
        L608:
            int r9 = cwqoPmTiPmLxJmlV(r8, r9, r14)
            goto L166
        L610:
            androidx.datastore.preferences.protobuf.longList r7 = new androidx.datastore.preferences.protobuf.longList
            goto L310
        L616:
            r11 = r9
            goto L3cb
        L61b:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L5cb
        L621:
            int r7 = r6.int1
            goto Lf
        L627:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L2d0
        L62d:
            int r8 = rsQtEvIJbUuZTSnC(r8, r9, r7, r14)
            goto L627
        L635:
            java.lang.long r13 = cAfuCocyGIwoBsFI(r7)
            goto L230
        L63d:
            java.lang.object r7 = BvyzppsxMEKVHiLX(r0, r7)
            goto L2f0
        L645:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L6ce
        L64b:
            r7.<init>()
            goto L140
        L652:
            int r9 = r11 + 4
            goto L338
        L658:
            r10 = r8
            goto L616
        L65d:
            int r10 = AfaCoNLfYHqzIkQz(r10)
            goto L359
        L665:
            return r7
        L666:
            goto L448
        L66a:
            r7.<init>()
            goto L5b
        L671:
            r1 = r11
            goto L56
        L676:
            java.lang.object r13 = r6.object1
            goto L19a
        L67c:
            cHPUJGkJdhsddEdL(r1, r2, r3, r4, r5, r6)
            goto L148
        L683:
            r10 = r8
            goto L321
        L688:
            androidx.datastore.preferences.protobuf.Schema r9 = CVLSopLJnvMwRDmQ(r7, r8)
            goto L10f
        L690:
            r4 = r9
            goto L603
        L695:
            return r8
        L696:
            goto L6b3
        L69a:
            PMCLyVtvcbhjRSzk(r0, r9, r7)
            goto L5e7
        L6a1:
            java.lang.stringBuilder r8 = VyOrNFnkAzZHTtOM(r8, r9)
            goto L6c6
        L6a9:
            r7 = 0
        L6aa:
            goto L2a8
        L6ae:
            r3 = r11
            goto L38b
        L6b3:
            androidx.datastore.preferences.protobuf.floatList r7 = new androidx.datastore.preferences.protobuf.floatList
            goto L396
        L6b9:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r7 = AZhRxyKfQAikZApi(r12)
            goto L5b7
        L6c1:
            r7 = 1
            goto L4e2
        L6c6:
            java.lang.string r8 = DHGQLLMBxXTvAqdv(r8)
            goto L5fc
        L6ce:
            cgmDQbGBhsMrEAfy(r0, r9, r7)
            goto L3fc
        L6d5:
            r13 = r7 | 4
            goto L288
        L6db:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r9 = r12.descriptor
            goto L4e8
        L6e1:
            zauSUKPqestADMDO(r0, r9, r7)
            goto L317
        L6e8:
            r10 = r8
            goto L4fc
        L6ed:
            if (r7 != 0) goto L6f2
            goto L5dc
        L6f2:
            goto L4f0
        L6f6:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtensionDescriptor r8 = r12.descriptor
            goto L4a9
        L6fc:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r11 = iHsvPPxUVURSYozJ(r12)
            goto L15e
    }

    static int DecodeExtensionOrUnknownField(int r6, byte[] r7, int r8, int r9, java.lang.object r10, androidx.datastore.preferences.protobuf.MessageLite r11, androidx.datastore.preferences.protobuf.UnknownFieldSchema<androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite> r12, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r13) throws java.io.IOException {
            goto L4
        L4:
            goto L7b
        L7:
            goto L86
        Lb:
            r1 = 14
            goto L1a
        L12:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r4 = unSiXVJAhpFjCjIF(r10)
            goto L73
        L1a:
            int r0 = r0 + r1
            goto L32
        L20:
            r1 = r7
            goto L6e
        L25:
            r5 = r13
            goto L38
        L2a:
            r3 = r9
            goto L25
        L2f:
            goto L7
        L32:
            int r0 = r0 % r1
            goto L8d
        L38:
            int r6 = zusZXhPipiMghXbj(r0, r1, r2, r3, r4, r5)
            goto L4e
        L40:
            return r6
        L41:
            goto L78
        L45:
            if (r11 == 0) goto L4a
            goto L4f
        L4a:
            goto L12
        L4e:
            return r6
        L4f:
            goto L59
        L53:
            androidx.datastore.preferences.protobuf.ExtensionRegistryLite r1 = r13.extensionRegistry
            goto L9c
        L59:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage r10 = (androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtendableMessage) r10
            goto L7f
        L5f:
            int r6 = itNELVzqhySkjthp(r6, r7, r8, r9, r10, r11, r12, r13)
            goto L40
        L67:
            goto L41
        L6a:
            goto L96
        L6e:
            r2 = r8
            goto L2a
        L73:
            r0 = r6
            goto L20
        L78:
            goto L6a
        L7b:
            goto L2f
        L7f:
            cUGOsMaMnlVjoeZa(r10)
            goto L5f
        L86:
            r0 = 1
            goto Lb
        L8d:
            if (r0 <= 0) goto L92
            goto L6a
        L92:
            goto L67
        L96:
            int r0 = r6 >>> 3
            goto L53
        L9c:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite$GeneratedExtension r11 = BTEttLjHoHXOIbhp(r1, r11, r0)
            goto L45
    }

    static int DecodeFixed32(byte[] r2, int r3) {
            goto L7b
        L4:
            r0 = 8
            goto L4a
        Lb:
            int r0 = r0 % r1
            goto L51
        L11:
            int r1 = r1 << 16
            goto L23
        L17:
            r2 = r2[r3]
            goto L5a
        L1d:
            int r1 = r3 + 2
            goto L28
        L23:
            r0 = r0 | r1
            goto L2e
        L28:
            r1 = r2[r1]
            goto L95
        L2e:
            int r3 = r3 + 3
            goto L17
        L34:
            int r0 = r0 + r1
            goto Lb
        L3a:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L82
        L40:
            goto L7e
        L43:
            goto L6c
        L46:
            goto La1
        L4a:
            r1 = 11
            goto L34
        L51:
            if (r0 <= 0) goto L56
            goto L46
        L56:
            goto L43
        L5a:
            r2 = r2 & 255(0xff, float:3.57E-43)
            goto L60
        L60:
            int r2 = r2 << 24
            goto L70
        L66:
            r0 = r0 | r1
            goto L1d
        L6b:
            return r2
        L6c:
            goto L8e
        L70:
            r2 = r2 | r0
            goto L6b
        L75:
            r1 = r2[r1]
            goto L3a
        L7b:
            goto L91
        L7e:
            goto L4
        L82:
            int r1 = r1 << 8
            goto L66
        L88:
            r0 = r0 & 255(0xff, float:3.57E-43)
            goto L9b
        L8e:
            goto L46
        L91:
            goto L40
        L95:
            r1 = r1 & 255(0xff, float:3.57E-43)
            goto L11
        L9b:
            int r1 = r3 + 1
            goto L75
        La1:
            r0 = r2[r3]
            goto L88
    }

    static int DecodeFixed32List(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L80
        L4:
            r0 = 27
            goto L22
        Lb:
            QytvzlmqEsWtnZgE(r6, r0)
            goto L5b
        L12:
            int r4 = r0 + 4
            goto L18
        L18:
            goto L5d
        L19:
            goto L1d
        L1d:
            return r4
        L1e:
            goto L45
        L22:
            r1 = 16
            goto L2e
        L29:
            goto L19
        L2a:
            goto L96
        L2e:
            int r0 = r0 + r1
            goto L61
        L34:
            goto L83
        L37:
            int r0 = IGoDvupRUAHtiOPC(r3, r4)
            goto Lb
        L3f:
            int r1 = r7.int1
            goto L77
        L45:
            goto L73
        L48:
            goto L34
        L4c:
            eSuJlzBTcLhIYAxj(r6, r4)
            goto L12
        L53:
            int r0 = LGvBPUUXydNCPrDS(r3, r4, r7)
            goto L3f
        L5b:
            int r4 = r4 + 4
        L5d:
            goto L87
        L61:
            int r0 = r0 % r1
            goto L67
        L67:
            if (r0 <= 0) goto L6c
            goto L73
        L6c:
            goto L70
        L70:
            goto L1e
        L73:
            goto L90
        L77:
            if (r2 != r1) goto L7c
            goto L2a
        L7c:
            goto L29
        L80:
            goto L48
        L83:
            goto L4
        L87:
            if (r4 < r5) goto L8c
            goto L19
        L8c:
            goto L53
        L90:
            androidx.datastore.preferences.protobuf.IntList r6 = (androidx.datastore.preferences.protobuf.IntList) r6
            goto L37
        L96:
            int r4 = jAMDlzcfoxzXhvdG(r3, r0)
            goto L4c
    }

    static long DecodeFixed64(byte[] r7, int r8) {
            goto L1a
        L4:
            r4 = r7[r4]
            goto L93
        La:
            r0 = 28
            goto L135
        L11:
            int r4 = r8 + 2
            goto L103
        L17:
            goto L1d
        L1a:
            goto L5d
        L1d:
            goto La
        L21:
            int r4 = r8 + 3
            goto Lf3
        L27:
            long r0 = r0 & r2
            goto L119
        L2c:
            r4 = r7[r4]
            goto L7f
        L32:
            long r7 = (long) r7
            goto L15f
        L37:
            long r4 = r4 << r6
            goto Lee
        L3c:
            long r4 = r4 << r6
            goto L130
        L41:
            r6 = 32
            goto L37
        L47:
            r7 = r7[r8]
            goto L32
        L4d:
            goto Lfa
        L50:
            goto Lb5
        L54:
            r4 = r7[r4]
            goto L13c
        L5a:
            goto L50
        L5d:
            goto L17
        L61:
            long r7 = r7 << r2
            goto L114
        L66:
            long r4 = (long) r4
            goto L84
        L6b:
            long r0 = (long) r0
            goto Ld2
        L70:
            long r0 = r0 | r4
            goto L11
        L75:
            long r4 = r4 << r6
            goto L15a
        L7a:
            long r4 = r4 << r6
            goto L70
        L7f:
            long r4 = (long) r4
            goto L8e
        L84:
            long r4 = r4 & r2
            goto L41
        L89:
            long r4 = (long) r4
            goto L141
        L8e:
            long r4 = r4 & r2
            goto L98
        L93:
            long r4 = (long) r4
            goto Lbb
        L98:
            r6 = 48
            goto Le3
        L9e:
            r6 = 16
            goto L75
        La4:
            int r0 = r0 + r1
            goto Ld8
        Laa:
            r2 = 56
            goto L61
        Lb0:
            long r4 = r4 & r2
            goto L14f
        Lb5:
            r0 = r7[r8]
            goto L6b
        Lbb:
            long r4 = r4 & r2
            goto L124
        Lc0:
            int r4 = r8 + 6
            goto L2c
        Lc6:
            r4 = r7[r4]
            goto L66
        Lcc:
            int r4 = r8 + 4
            goto Lc6
        Ld2:
            r2 = 255(0xff, double:1.26E-321)
            goto L27
        Ld8:
            int r0 = r0 % r1
            goto L146
        Lde:
            long r0 = r0 | r4
            goto Lcc
        Le3:
            long r4 = r4 << r6
            goto L155
        Le8:
            r6 = 24
            goto L11f
        Lee:
            long r0 = r0 | r4
            goto L109
        Lf3:
            r4 = r7[r4]
            goto Lfe
        Lf9:
            return r7
        Lfa:
            goto L5a
        Lfe:
            long r4 = (long) r4
            goto L10f
        L103:
            r4 = r7[r4]
            goto L89
        L109:
            int r4 = r8 + 5
            goto L4
        L10f:
            long r4 = r4 & r2
            goto Le8
        L114:
            long r7 = r7 | r0
            goto Lf9
        L119:
            int r4 = r8 + 1
            goto L54
        L11f:
            long r4 = r4 << r6
            goto Lde
        L124:
            r6 = 40
            goto L3c
        L12a:
            int r8 = r8 + 7
            goto L47
        L130:
            long r0 = r0 | r4
            goto Lc0
        L135:
            r1 = 20
            goto La4
        L13c:
            long r4 = (long) r4
            goto Lb0
        L141:
            long r4 = r4 & r2
            goto L9e
        L146:
            if (r0 <= 0) goto L14b
            goto L50
        L14b:
            goto L4d
        L14f:
            r6 = 8
            goto L7a
        L155:
            long r0 = r0 | r4
            goto L12a
        L15a:
            long r0 = r0 | r4
            goto L21
        L15f:
            long r7 = r7 & r2
            goto Laa
    }

    static int DecodeFixed64List(int r3, byte[] r4, int r5, int r6, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) {
            goto L15
        L4:
            goto L2e
        L7:
            goto L6c
        Lb:
            goto L18
        Le:
            r1 = 32
            goto L8c
        L15:
            goto L35
        L18:
            goto L79
        L1c:
            long r0 = NufVKdNVuQJPAgXo(r4, r5)
            goto L39
        L24:
            if (r0 <= 0) goto L29
            goto L7
        L29:
            goto L4
        L2d:
            return r5
        L2e:
            goto L32
        L32:
            goto L7
        L35:
            goto Lb
        L39:
            IyJwXHHhKgGGIOKL(r7, r0)
            goto L86
        L40:
            long r1 = mjghdpqupKqVtcxR(r4, r0)
            goto L72
        L48:
            if (r3 != r1) goto L4d
            goto L68
        L4d:
            goto L67
        L51:
            if (r5 < r6) goto L56
            goto L63
        L56:
            goto L5a
        L5a:
            int r0 = MqFrnlthspwJdLEe(r4, r5, r8)
            goto L92
        L62:
            goto L88
        L63:
            goto L2d
        L67:
            goto L63
        L68:
            goto L40
        L6c:
            androidx.datastore.preferences.protobuf.longList r7 = (androidx.datastore.preferences.protobuf.longList) r7
            goto L1c
        L72:
            YrXnBFQpqqbzVvbU(r7, r1)
            goto L98
        L79:
            r0 = 24
            goto Le
        L80:
            int r0 = r0 % r1
            goto L24
        L86:
            int r5 = r5 + 8
        L88:
            goto L51
        L8c:
            int r0 = r0 + r1
            goto L80
        L92:
            int r1 = r8.int1
            goto L48
        L98:
            int r5 = r0 + 8
            goto L62
    }

    static float Decodefloat(byte[] r0, int r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L20
        L9:
            goto L5
        Lc:
            goto L18
        L10:
            float r0 = sZFrYdAPSHTaEFPC(r0)
            goto L4
        L18:
            int r0 = HUgkBqpErafFYnUA(r0, r1)
            goto L10
        L20:
            goto Lc
    }

    static int DecodefloatList(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L51
        L4:
            goto L32
        L7:
            goto L70
        Lb:
            r1 = 21
            goto L90
        L12:
            int r0 = r0 % r1
            goto L18
        L18:
            if (r0 <= 0) goto L1d
            goto L7
        L1d:
            goto L4
        L21:
            int r4 = r0 + 4
            goto L83
        L27:
            r0 = 19
            goto Lb
        L2e:
            goto L54
        L31:
            return r4
        L32:
            goto L3f
        L36:
            if (r2 != r1) goto L3b
            goto L47
        L3b:
            goto L46
        L3f:
            goto L7
        L42:
            goto L2e
        L46:
            goto L84
        L47:
            goto L68
        L4b:
            int r4 = r4 + 4
        L4d:
            goto L58
        L51:
            goto L42
        L54:
            goto L27
        L58:
            if (r4 < r5) goto L5d
            goto L84
        L5d:
            goto L96
        L61:
            FoxayBZhGTRpMWew(r6, r0)
            goto L4b
        L68:
            float r4 = NNNpmKbuUBbCChmu(r3, r0)
            goto L7c
        L70:
            androidx.datastore.preferences.protobuf.floatList r6 = (androidx.datastore.preferences.protobuf.floatList) r6
            goto L88
        L76:
            int r1 = r7.int1
            goto L36
        L7c:
            kriBLfwVXruPYPWU(r6, r4)
            goto L21
        L83:
            goto L4d
        L84:
            goto L31
        L88:
            float r0 = XLMrooUiEWXaqQGk(r3, r4)
            goto L61
        L90:
            int r0 = r0 + r1
            goto L12
        L96:
            int r0 = DpsIgyJJdjitMvHM(r3, r4, r7)
            goto L76
    }

    static int DecodeGroupField(androidx.datastore.preferences.protobuf.Schema r7, byte[] r8, int r9, int r10, int r11, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r12) throws java.io.IOException {
            goto L66
        L4:
            gPqLUQWKWNqaGYra(r1, r0)
            goto L1b
        Lb:
            r0 = 20
            goto L26
        L12:
            goto L69
        L15:
            int r0 = r0 % r1
            goto L4b
        L1b:
            r6.object1 = r0
            goto L61
        L21:
            r5 = r11
            goto L46
        L26:
            r1 = 29
            goto L5b
        L2d:
            r4 = r10
            goto L21
        L32:
            java.lang.object r0 = EaaQTFVgGeGtNmYL(r7)
            goto L7a
        L3a:
            goto L62
        L3d:
            goto L32
        L41:
            r3 = r9
            goto L2d
        L46:
            r6 = r12
            goto L6d
        L4b:
            if (r0 <= 0) goto L50
            goto L3d
        L50:
            goto L3a
        L54:
            goto L3d
        L57:
            goto L12
        L5b:
            int r0 = r0 + r1
            goto L15
        L61:
            return r7
        L62:
            goto L54
        L66:
            goto L57
        L69:
            goto Lb
        L6d:
            int r7 = NFWNMDuvmXVCblFe(r0, r1, r2, r3, r4, r5, r6)
            goto L4
        L75:
            r2 = r8
            goto L41
        L7a:
            r1 = r7
            goto L75
    }

    static int DecodeGroupList(androidx.datastore.preferences.protobuf.Schema r7, int r8, byte[] r9, int r10, int r11, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r12, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r13) throws java.io.IOException {
            goto L8e
        L4:
            goto L4a
        L5:
            goto L6c
        L9:
            goto L7f
        Lc:
            goto L27
        L10:
            r6 = r13
            goto La1
        L15:
            r3 = r10
            goto L71
        L1a:
            r0 = 25
            goto Lb1
        L21:
            r0 = r8 & (-8)
            goto L9b
        L27:
            goto L91
        L2a:
            java.lang.object r9 = r6.object1
            goto L65
        L30:
            goto L5
        L31:
            goto L5d
        L35:
            if (r0 <= 0) goto L3a
            goto L7f
        L3a:
            goto L7c
        L3e:
            if (r7 < r4) goto L43
            goto L5
        L43:
            goto La9
        L47:
            fEFBYmxmLFrCHdXf(r12, r9)
        L4a:
            goto L3e
        L4e:
            if (r8 != r9) goto L53
            goto L31
        L53:
            goto L30
        L57:
            int r0 = r0 % r1
            goto L35
        L5d:
            int r7 = rZaKWXDdmUpwmIsO(r1, r2, r3, r4, r5, r6)
            goto L2a
        L65:
            BVtdvpqdDxbJhsUh(r12, r9)
            goto L4
        L6c:
            return r7
        L6d:
            goto L9
        L71:
            r4 = r11
            goto L10
        L76:
            java.lang.object r9 = r6.object1
            goto L47
        L7c:
            goto L6d
        L7f:
            goto L21
        L83:
            r2 = r9
            goto L15
        L88:
            int r0 = r0 + r1
            goto L57
        L8e:
            goto Lc
        L91:
            goto L1a
        L95:
            int r9 = r6.int1
            goto L4e
        L9b:
            r5 = r0 | 4
            goto Lb8
        La1:
            int r7 = KFFwLFkrrvOxQwVG(r1, r2, r3, r4, r5, r6)
            goto L76
        La9:
            int r3 = aVOuvBoHtuMJLaCL(r2, r7, r6)
            goto L95
        Lb1:
            r1 = 18
            goto L88
        Lb8:
            r1 = r7
            goto L83
    }

    static int DecodeMessageField(androidx.datastore.preferences.protobuf.Schema r6, byte[] r7, int r8, int r9, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r10) throws java.io.IOException {
            goto L59
        L4:
            nkcgRPVagRXSZTuS(r1, r0)
            goto L3e
        Lb:
            int r0 = r0 % r1
            goto L4b
        L11:
            r0 = 30
            goto L29
        L18:
            r1 = r6
            goto L60
        L1d:
            goto L76
        L20:
            goto L6d
        L24:
            r5 = r10
            goto L30
        L29:
            r1 = 5
            goto L38
        L30:
            int r6 = qVnspZZGYSOpwyux(r0, r1, r2, r3, r4, r5)
            goto L4
        L38:
            int r0 = r0 + r1
            goto Lb
        L3e:
            r5.object1 = r0
            goto L75
        L44:
            goto L20
        L47:
            goto L6a
        L4b:
            if (r0 <= 0) goto L50
            goto L20
        L50:
            goto L1d
        L54:
            r3 = r8
            goto L65
        L59:
            goto L47
        L5c:
            goto L11
        L60:
            r2 = r7
            goto L54
        L65:
            r4 = r9
            goto L24
        L6a:
            goto L5c
        L6d:
            java.lang.object r0 = JWMSkHbZnSTWyYyi(r6)
            goto L18
        L75:
            return r6
        L76:
            goto L44
    }

    static int DecodeMessageList(androidx.datastore.preferences.protobuf.Schema<object> r2, int r3, byte[] r4, int r5, int r6, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) throws java.io.IOException {
            goto L91
        L4:
            int r0 = IncrwcsrOiEgtCbH(r4, r5, r8)
            goto L37
        Lc:
            goto L5d
        Ld:
            goto L45
        L11:
            if (r3 != r1) goto L16
            goto L33
        L16:
            goto L32
        L1a:
            java.lang.object r0 = r8.object1
            goto L6d
        L20:
            if (r0 <= 0) goto L25
            goto L8d
        L25:
            goto L8a
        L29:
            if (r5 < r6) goto L2e
            goto Ld
        L2e:
            goto L4
        L32:
            goto Ld
        L33:
            goto L3d
        L37:
            int r1 = r8.int1
            goto L11
        L3d:
            int r5 = SuEsLwNKADmpBWuy(r2, r4, r0, r6, r8)
            goto L1a
        L45:
            return r5
        L46:
            goto L4a
        L4a:
            goto L8d
        L4d:
            goto L51
        L51:
            goto L94
        L54:
            int r0 = r0 + r1
            goto L67
        L5a:
            zGeAALrKRRwJulCD(r7, r0)
        L5d:
            goto L29
        L61:
            java.lang.object r0 = r8.object1
            goto L5a
        L67:
            int r0 = r0 % r1
            goto L20
        L6d:
            dzXryJohjVpLOcXj(r7, r0)
            goto Lc
        L74:
            r1 = 20
            goto L54
        L7b:
            int r5 = nIIcSErWDTMmZNVD(r2, r4, r5, r6, r8)
            goto L61
        L83:
            r0 = 10
            goto L74
        L8a:
            goto L46
        L8d:
            goto L7b
        L91:
            goto L4d
        L94:
            goto L83
    }

    static int DecodePackedBoolList(byte[] r5, int r6, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) throws java.io.IOException {
            goto L3a
        L4:
            androidx.datastore.preferences.protobuf.boolList r7 = (androidx.datastore.preferences.protobuf.boolList) r7
            goto L95
        La:
            YCMxBUOqCxWVEIvd(r7, r1)
            goto L90
        L11:
            r1 = 1
            goto Lb2
        L16:
            int r0 = r0 + r6
        L17:
            goto L31
        L1b:
            r1 = 4
            goto L4c
        L22:
            long r1 = r8.long1
            goto L6d
        L28:
            if (r6 == r0) goto L2d
            goto L74
        L2d:
            goto L73
        L31:
            if (r6 < r0) goto L36
            goto L91
        L36:
            goto La3
        L3a:
            goto L5e
        L3d:
            goto L78
        L41:
            int r0 = r0 % r1
            goto L52
        L47:
            throw r5
        L48:
            goto L5b
        L4c:
            int r0 = r0 + r1
            goto L41
        L52:
            if (r0 <= 0) goto L57
            goto Lae
        L57:
            goto Lab
        L5b:
            goto Lae
        L5e:
            goto Lb7
        L62:
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L7f
        L68:
            r1 = 0
        L69:
            goto La
        L6d:
            r3 = 0
            goto L62
        L73:
            return r6
        L74:
            goto L88
        L78:
            r0 = 32
            goto L1b
        L7f:
            if (r1 != 0) goto L84
            goto Lb3
        L84:
            goto L11
        L88:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r5 = rXsIHSPvyAsplPXG()
            goto L47
        L90:
            goto L17
        L91:
            goto L28
        L95:
            int r6 = tBLrdHPjPQSeMjqW(r5, r6, r8)
            goto L9d
        L9d:
            int r0 = r8.int1
            goto L16
        La3:
            int r6 = KWhIkfcLUjncQZjO(r5, r6, r8)
            goto L22
        Lab:
            goto L48
        Lae:
            goto L4
        Lb2:
            goto L69
        Lb3:
            goto L68
        Lb7:
            goto L3d
    }

    static int DecodePackeddoubleList(byte[] r2, int r3, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) throws java.io.IOException {
            goto L68
        L4:
            r1 = 31
            goto L6f
        Lb:
            if (r3 == r5) goto L10
            goto L23
        L10:
            goto L22
        L14:
            int r5 = r5 + r3
        L15:
            goto L7e
        L19:
            if (r0 <= 0) goto L1e
            goto L8a
        L1e:
            goto L87
        L22:
            return r3
        L23:
            goto L2e
        L27:
            r0 = 26
            goto L4
        L2e:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = FjeMSKgILENiNtoB()
            goto L5e
        L36:
            int r5 = r5.int1
            goto L14
        L3c:
            androidx.datastore.preferences.protobuf.doubleList r4 = (androidx.datastore.preferences.protobuf.doubleList) r4
            goto L42
        L42:
            int r3 = KfAOWMQZtDxlPYFG(r2, r3, r5)
            goto L36
        L4a:
            mLMYrSCgjusHFpcy(r4, r0)
            goto L78
        L51:
            int r0 = r0 % r1
            goto L19
        L57:
            goto L8a
        L5a:
            goto L75
        L5e:
            throw r2
        L5f:
            goto L57
        L63:
            goto L15
        L64:
            goto Lb
        L68:
            goto L5a
        L6b:
            goto L27
        L6f:
            int r0 = r0 + r1
            goto L51
        L75:
            goto L6b
        L78:
            int r3 = r3 + 8
            goto L63
        L7e:
            if (r3 < r5) goto L83
            goto L64
        L83:
            goto L8e
        L87:
            goto L5f
        L8a:
            goto L3c
        L8e:
            double r0 = AWownTRVMgSKnxzJ(r2, r3)
            goto L4a
    }

    static int DecodePackedFixed32List(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) throws java.io.IOException {
            goto L58
        L4:
            int r4 = r4 + r2
        L5:
            goto L33
        L9:
            goto L5b
        Lc:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r1 = bEZFqPAMrKuaDeLB()
            goto L14
        L14:
            throw r1
        L15:
            goto L9
        L19:
            goto L5
        L1a:
            goto L2a
        L1e:
            return r2
        L1f:
            goto Lc
        L23:
            sWPHhQQslUXwdpEc(r3, r0)
            goto L5f
        L2a:
            if (r2 == r4) goto L2f
            goto L1f
        L2f:
            goto L1e
        L33:
            if (r2 < r4) goto L38
            goto L1a
        L38:
            goto L50
        L3c:
            int r4 = r4.int1
            goto L4
        L42:
            androidx.datastore.preferences.protobuf.IntList r3 = (androidx.datastore.preferences.protobuf.IntList) r3
            goto L48
        L48:
            int r2 = mZelRXWBCbExoTvG(r1, r2, r4)
            goto L3c
        L50:
            int r0 = vfxoZIriHuSqcUqu(r1, r2)
            goto L23
        L58:
            goto L15
        L5b:
            goto L42
        L5f:
            int r2 = r2 + 4
            goto L19
    }

    static int DecodePackedFixed64List(byte[] r2, int r3, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) throws java.io.IOException {
            goto L4
        L4:
            goto L2c
        L7:
            goto L46
        Lb:
            int r5 = r5.int1
            goto L83
        L11:
            int r0 = r0 + r1
            goto L40
        L17:
            if (r3 < r5) goto L1c
            goto L72
        L1c:
            goto L30
        L20:
            if (r0 <= 0) goto L25
            goto L50
        L25:
            goto L4d
        L29:
            goto L50
        L2c:
            goto L5b
        L30:
            long r0 = bxuMBECKCKwmOnja(r2, r3)
            goto L54
        L38:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = UFBDPmkFOoyWfkXx()
            goto L67
        L40:
            int r0 = r0 % r1
            goto L20
        L46:
            r0 = 13
            goto L7c
        L4d:
            goto L68
        L50:
            goto L76
        L54:
            nSDzJsNOXjrqhaSs(r4, r0)
            goto L88
        L5b:
            goto L7
        L5e:
            if (r3 == r5) goto L63
            goto L6d
        L63:
            goto L6c
        L67:
            throw r2
        L68:
            goto L29
        L6c:
            return r3
        L6d:
            goto L38
        L71:
            goto L84
        L72:
            goto L5e
        L76:
            androidx.datastore.preferences.protobuf.longList r4 = (androidx.datastore.preferences.protobuf.longList) r4
            goto L8e
        L7c:
            r1 = 1
            goto L11
        L83:
            int r5 = r5 + r3
        L84:
            goto L17
        L88:
            int r3 = r3 + 8
            goto L71
        L8e:
            int r3 = yGmaBKtYPdOzxswO(r2, r3, r5)
            goto Lb
    }

    static int DecodePackedfloatList(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) throws java.io.IOException {
            goto L2e
        L4:
            float r0 = MrircrAgRARWajaf(r1, r2)
            goto L4c
        Lc:
            return r2
        Ld:
            goto L26
        L11:
            androidx.datastore.preferences.protobuf.floatList r3 = (androidx.datastore.preferences.protobuf.floatList) r3
            goto L5d
        L17:
            goto L31
        L1a:
            int r2 = r2 + 4
            goto L47
        L20:
            int r4 = r4.int1
            goto L53
        L26:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r1 = nvKQbTCkoOoykhuC()
            goto L58
        L2e:
            goto L59
        L31:
            goto L11
        L35:
            if (r2 == r4) goto L3a
            goto Ld
        L3a:
            goto Lc
        L3e:
            if (r2 < r4) goto L43
            goto L48
        L43:
            goto L4
        L47:
            goto L54
        L48:
            goto L35
        L4c:
            hQuLebepaQRZeYjJ(r3, r0)
            goto L1a
        L53:
            int r4 = r4 + r2
        L54:
            goto L3e
        L58:
            throw r1
        L59:
            goto L17
        L5d:
            int r2 = YkacpBsTACaMMqCd(r1, r2, r4)
            goto L20
    }

    static int DecodePackedSInt32List(byte[] r2, int r3, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) throws java.io.IOException {
            goto L2d
        L4:
            r1 = 13
            goto L91
        Lb:
            int r0 = r5.int1
            goto L6d
        L11:
            if (r3 < r0) goto L16
            goto L62
        L16:
            goto L34
        L1a:
            int r0 = r0 % r1
            goto L88
        L20:
            return r3
        L21:
            goto L25
        L25:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = wKVqFZUcKVGaguSH()
            goto L5c
        L2d:
            goto L9a
        L30:
            goto L66
        L34:
            int r3 = wbjeNvSrKRZrcBEy(r2, r3, r5)
            goto L75
        L3c:
            goto L5d
        L3f:
            goto L82
        L43:
            int r3 = OksdxfznULTcTFct(r2, r3, r5)
            goto Lb
        L4b:
            if (r3 == r0) goto L50
            goto L21
        L50:
            goto L20
        L54:
            int r1 = dIWMDLTnfGYDxttk(r1)
            goto L7b
        L5c:
            throw r2
        L5d:
            goto L97
        L61:
            goto L6e
        L62:
            goto L4b
        L66:
            r0 = 26
            goto L4
        L6d:
            int r0 = r0 + r3
        L6e:
            goto L11
        L72:
            goto L30
        L75:
            int r1 = r5.int1
            goto L54
        L7b:
            aWyWXzuadoZmKeTh(r4, r1)
            goto L61
        L82:
            androidx.datastore.preferences.protobuf.IntList r4 = (androidx.datastore.preferences.protobuf.IntList) r4
            goto L43
        L88:
            if (r0 <= 0) goto L8d
            goto L3f
        L8d:
            goto L3c
        L91:
            int r0 = r0 + r1
            goto L1a
        L97:
            goto L3f
        L9a:
            goto L72
    }

    static int DecodePackedSInt64List(byte[] r3, int r4, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) throws java.io.IOException {
            goto L49
        L4:
            int r0 = r0 + r4
        L5:
            goto L5c
        L9:
            goto L7c
        Lc:
            goto L80
        L10:
            if (r4 == r0) goto L15
            goto L84
        L15:
            goto L83
        L19:
            int r4 = IhjRQnRgMXLyvfzT(r3, r4, r6)
            goto L29
        L21:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r3 = lUpgfaCikYfFdfPe()
            goto L74
        L29:
            int r0 = r6.int1
            goto L4
        L2f:
            int r4 = yrDjxOGwKyoYjSRJ(r3, r4, r6)
            goto L65
        L37:
            goto L5
        L38:
            goto L10
        L3c:
            r1 = 16
            goto L43
        L43:
            int r0 = r0 + r1
            goto L50
        L49:
            goto Lc
        L4c:
            goto L88
        L50:
            int r0 = r0 % r1
            goto L6b
        L56:
            androidx.datastore.preferences.protobuf.longList r5 = (androidx.datastore.preferences.protobuf.longList) r5
            goto L19
        L5c:
            if (r4 < r0) goto L61
            goto L38
        L61:
            goto L2f
        L65:
            long r1 = r6.long1
            goto L96
        L6b:
            if (r0 <= 0) goto L70
            goto L7c
        L70:
            goto L79
        L74:
            throw r3
        L75:
            goto L9
        L79:
            goto L75
        L7c:
            goto L56
        L80:
            goto L4c
        L83:
            return r4
        L84:
            goto L21
        L88:
            r0 = 14
            goto L3c
        L8f:
            yooLzGxrEQyvuevG(r5, r1)
            goto L37
        L96:
            long r1 = ZYuRPSPJGkzyUwAs(r1)
            goto L8f
    }

    static int DecodePackedVarint32List(byte[] r2, int r3, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) throws java.io.IOException {
            goto L21
        L4:
            return r3
        L5:
            goto L81
        L9:
            r1 = 23
            goto L6b
        L10:
            int r1 = r5.int1
            goto L7a
        L16:
            androidx.datastore.preferences.protobuf.IntList r4 = (androidx.datastore.preferences.protobuf.IntList) r4
            goto L89
        L1c:
            goto L46
        L1d:
            goto L28
        L21:
            goto L58
        L24:
            goto L3e
        L28:
            if (r3 == r0) goto L2d
            goto L5
        L2d:
            goto L4
        L31:
            int r0 = r5.int1
            goto L45
        L37:
            goto L92
        L3a:
            goto L16
        L3e:
            r0 = 19
            goto L9
        L45:
            int r0 = r0 + r3
        L46:
            goto L71
        L4a:
            int r3 = uvgGlsIieSmaCIQy(r2, r3, r5)
            goto L10
        L52:
            goto L24
        L55:
            goto L3a
        L58:
            goto L52
        L5c:
            int r0 = r0 % r1
            goto L62
        L62:
            if (r0 <= 0) goto L67
            goto L3a
        L67:
            goto L37
        L6b:
            int r0 = r0 + r1
            goto L5c
        L71:
            if (r3 < r0) goto L76
            goto L1d
        L76:
            goto L4a
        L7a:
            LXNKbcDWNQnghTHT(r4, r1)
            goto L1c
        L81:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = HguHiolEklIyJJgT()
            goto L91
        L89:
            int r3 = eYYtXNjBVWJcBEPY(r2, r3, r5)
            goto L31
        L91:
            throw r2
        L92:
            goto L55
    }

    static int DecodePackedVarint64List(byte[] r3, int r4, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) throws java.io.IOException {
            goto L83
        L4:
            goto L92
        L7:
            goto L11
        Lb:
            int r0 = r6.int1
            goto L3d
        L11:
            androidx.datastore.preferences.protobuf.longList r5 = (androidx.datastore.preferences.protobuf.longList) r5
            goto L35
        L17:
            int r0 = r0 % r1
            goto L42
        L1d:
            goto L7
        L20:
            goto L80
        L24:
            if (r4 < r0) goto L29
            goto L62
        L29:
            goto L2d
        L2d:
            int r4 = cUCdnrZfVBkwyqsS(r3, r4, r6)
            goto L6f
        L35:
            int r4 = QQKUVGpDRiItyYbC(r3, r4, r6)
            goto Lb
        L3d:
            int r0 = r0 + r4
        L3e:
            goto L24
        L42:
            if (r0 <= 0) goto L47
            goto L7
        L47:
            goto L4
        L4b:
            r0 = 30
            goto L52
        L52:
            r1 = 4
            goto L7a
        L59:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r3 = VAFZItytGOVodZvb()
            goto L91
        L61:
            goto L3e
        L62:
            goto L66
        L66:
            if (r4 == r0) goto L6b
            goto L76
        L6b:
            goto L75
        L6f:
            long r1 = r6.long1
            goto L8a
        L75:
            return r4
        L76:
            goto L59
        L7a:
            int r0 = r0 + r1
            goto L17
        L80:
            goto L86
        L83:
            goto L20
        L86:
            goto L4b
        L8a:
            gXWxTbBappgauHhN(r5, r1)
            goto L61
        L91:
            throw r3
        L92:
            goto L1d
    }

    static int DecodeSInt32List(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L56
        L4:
            int r0 = tyGHAzYznjOWrPJI(r0)
            goto L3b
        Lc:
            goto L4a
        Lf:
            goto L13
        L13:
            androidx.datastore.preferences.protobuf.IntList r6 = (androidx.datastore.preferences.protobuf.IntList) r6
            goto L4e
        L19:
            mqTKVnePXGFPbvzI(r6, r0)
            goto La3
        L20:
            goto Lf
        L23:
            goto L64
        L27:
            int r0 = r7.int1
            goto L33
        L2d:
            int r1 = r7.int1
            goto L7c
        L33:
            int r0 = ZngVkwTmcwhlJcWm(r0)
            goto L19
        L3b:
            sigVLHeZVHlBebKq(r6, r0)
        L3e:
            goto L92
        L42:
            r1 = 16
            goto L6d
        L49:
            return r4
        L4a:
            goto L20
        L4e:
            int r4 = LliTnEcDkHUwJfMJ(r3, r4, r7)
            goto La8
        L56:
            goto L23
        L59:
            goto L5d
        L5d:
            r0 = 8
            goto L42
        L64:
            goto L59
        L67:
            int r0 = r0 % r1
            goto L73
        L6d:
            int r0 = r0 + r1
            goto L67
        L73:
            if (r0 <= 0) goto L78
            goto Lf
        L78:
            goto Lc
        L7c:
            if (r2 != r1) goto L81
            goto L8e
        L81:
            goto L8d
        L85:
            int r0 = kZpNDiIucdowQHCi(r3, r4, r7)
            goto L2d
        L8d:
            goto La4
        L8e:
            goto L9b
        L92:
            if (r4 < r5) goto L97
            goto La4
        L97:
            goto L85
        L9b:
            int r4 = LDZJppExjdLBucYz(r3, r0, r7)
            goto L27
        La3:
            goto L3e
        La4:
            goto L49
        La8:
            int r0 = r7.int1
            goto L4
    }

    static int DecodeSInt64List(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L10
        L4:
            goto L63
        L5:
            goto L76
        L9:
            WyAfUMfBZiqsHUDa(r6, r0)
        Lc:
            goto La5
        L10:
            goto L58
        L13:
            goto L6f
        L17:
            if (r2 != r1) goto L1c
            goto L5
        L1c:
            goto L4
        L20:
            return r4
        L21:
            goto L55
        L25:
            goto L21
        L28:
            goto L4f
        L2c:
            wCXEAhZzOXIJpdNI(r6, r0)
            goto L62
        L33:
            r1 = 17
            goto L49
        L3a:
            if (r0 <= 0) goto L3f
            goto L28
        L3f:
            goto L25
        L43:
            long r0 = r7.long1
            goto L67
        L49:
            int r0 = r0 + r1
            goto L87
        L4f:
            androidx.datastore.preferences.protobuf.longList r6 = (androidx.datastore.preferences.protobuf.longList) r6
            goto L95
        L55:
            goto L28
        L58:
            goto L84
        L5c:
            long r0 = r7.long1
            goto L9d
        L62:
            goto Lc
        L63:
            goto L20
        L67:
            long r0 = wKKgFvIupSEHgGBT(r0)
            goto L2c
        L6f:
            r0 = 28
            goto L33
        L76:
            int r4 = LkchbQuMLnuqTtOa(r3, r0, r7)
            goto L43
        L7e:
            int r1 = r7.int1
            goto L17
        L84:
            goto L13
        L87:
            int r0 = r0 % r1
            goto L3a
        L8d:
            int r0 = ohuJdyGlvsnOHNrG(r3, r4, r7)
            goto L7e
        L95:
            int r4 = JQTnFCueXxNhikVf(r3, r4, r7)
            goto L5c
        L9d:
            long r0 = WTkMZmncUahFmJPC(r0)
            goto L9
        La5:
            if (r4 < r5) goto Laa
            goto L63
        Laa:
            goto L8d
    }

    static int Decodestring(byte[] r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L93
        L4:
            int r0 = r0 + r1
            goto L84
        La:
            java.lang.string r1 = new java.lang.string
            goto L9a
        L10:
            if (r0 <= 0) goto L15
            goto L36
        L15:
            goto L33
        L19:
            int r4 = FpGPDomMTJTJpWTY(r3, r4, r5)
            goto L4e
        L21:
            goto L96
        L24:
            if (r0 == 0) goto L29
            goto L80
        L29:
            goto L3a
        L2d:
            r5.object1 = r1
            goto L60
        L33:
            goto L66
        L36:
            goto L19
        L3a:
            java.lang.string r3 = ""
            goto L79
        L40:
            r1.<init>(r3, r4, r0, r2)
            goto L2d
        L47:
            r1 = 13
            goto L4
        L4e:
            int r0 = r5.int1
            goto L8a
        L54:
            return r4
        L55:
            goto L71
        L59:
            goto L36
        L5c:
            goto L21
        L60:
            int r4 = r4 + r0
            goto L54
        L65:
            throw r3
        L66:
            goto L59
        L6a:
            r0 = 13
            goto L47
        L71:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r3 = zCfkpsduucAgBAXo()
            goto L65
        L79:
            r5.object1 = r3
            goto L7f
        L7f:
            return r4
        L80:
            goto La
        L84:
            int r0 = r0 % r1
            goto L10
        L8a:
            if (r0 >= 0) goto L8f
            goto L55
        L8f:
            goto L24
        L93:
            goto L5c
        L96:
            goto L6a
        L9a:
            java.nio.charset.Charset r2 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L40
    }

    static int DecodestringList(int r4, byte[] r5, int r6, int r7, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r8, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r9) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L52
        L4:
            int r2 = r9.int1
            goto L92
        La:
            int r0 = ntOgQkIyyoctLlrk(r5, r6, r9)
            goto L4
        L12:
            goto L8e
        L13:
            goto Lf6
        L17:
            if (r0 >= 0) goto L1c
            goto L61
        L1c:
            goto L10a
        L20:
            WcwCLyZRNkDEtRFh(r8, r1)
            goto L27
        L27:
            goto L33
        L28:
            goto L37
        L2c:
            java.nio.charset.Charset r3 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L9b
        L32:
            int r6 = r6 + r0
        L33:
            goto L3d
        L37:
            java.lang.string r2 = new java.lang.string
            goto L2c
        L3d:
            if (r6 < r7) goto L42
            goto L8e
        L42:
            goto La
        L46:
            znLDNsPDDXCoGuBY(r8, r1)
            goto L4d
        L4d:
            goto L33
        L4e:
            goto Lfe
        L52:
            goto L68
        L55:
            goto La2
        L59:
            r2.<init>(r5, r6, r0, r3)
            goto Ld8
        L60:
            return r6
        L61:
            goto Lba
        L65:
            goto L6f
        L68:
            goto La9
        L6c:
            goto L81
        L6f:
            goto Lb2
        L73:
            tVFzjfzocbMifAae(r8, r2)
        L76:
            goto L32
        L7a:
            int r0 = r9.int1
            goto Lcf
        L80:
            throw r4
        L81:
            goto L65
        L85:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r4 = ZyqySLtSzmgOHJFr()
            goto L8d
        L8d:
            throw r4
        L8e:
            goto L60
        L92:
            if (r4 != r2) goto L97
            goto L13
        L97:
            goto L12
        L9b:
            r2.<init>(r5, r6, r0, r3)
            goto L73
        La2:
            r0 = 10
            goto Lc8
        La9:
            goto L55
        Lac:
            int r0 = r0 % r1
            goto L110
        Lb2:
            int r6 = JmAFLnNalFZWzMPZ(r5, r6, r9)
            goto L119
        Lba:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r4 = VkBqfCxCupyuHgpN()
            goto L80
        Lc2:
            int r0 = r0 + r1
            goto Lac
        Lc8:
            r1 = 15
            goto Lc2
        Lcf:
            if (r0 >= 0) goto Ld4
            goto Le9
        Ld4:
            goto Led
        Ld8:
            hcnSGeLPchhKXLyq(r8, r2)
            goto Le8
        Ldf:
            if (r0 == 0) goto Le4
            goto L28
        Le4:
            goto L20
        Le8:
            goto L76
        Le9:
            goto L85
        Led:
            if (r0 == 0) goto Lf2
            goto L4e
        Lf2:
            goto L46
        Lf6:
            int r6 = TVmoDmqWQcYVmgYU(r5, r0, r9)
            goto L7a
        Lfe:
            java.lang.string r2 = new java.lang.string
            goto L104
        L104:
            java.nio.charset.Charset r3 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L59
        L10a:
            java.lang.string r1 = ""
            goto Ldf
        L110:
            if (r0 <= 0) goto L115
            goto L6f
        L115:
            goto L6c
        L119:
            int r0 = r9.int1
            goto L17
    }

    static int DecodestringListRequireUtf8(int r5, byte[] r6, int r7, int r8, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r9, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r10) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L9f
        L4:
            goto L81
        L5:
            goto L105
        L9:
            if (r7 < r8) goto Le
            goto L12f
        Le:
            goto L3a
        L12:
            throw r5
        L13:
            goto L26
        L17:
            if (r0 == 0) goto L1c
            goto Lee
        L1c:
            goto L6b
        L20:
            java.lang.string r3 = new java.lang.string
            goto L34
        L26:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r5 = gHrieWCsMkibhlDc()
            goto Ld2
        L2e:
            int r0 = r0 % r1
            goto L42
        L34:
            java.nio.charset.Charset r4 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L152
        L3a:
            int r0 = ANTsTVehlQXktGVz(r6, r7, r10)
            goto L78
        L42:
            if (r0 <= 0) goto L47
            goto L61
        L47:
            goto L5e
        L4b:
            java.lang.string r3 = new java.lang.string
            goto L133
        L51:
            return r7
        L52:
            goto L91
        L56:
            int r7 = kGPZLSuvluEIiBcX(r6, r7, r10)
            goto Lf7
        L5e:
            goto Ld3
        L61:
            goto L56
        L65:
            goto Lf3
        L67:
            goto L8b
        L6b:
            lbliPERZjHXirTCu(r9, r1)
            goto Led
        L72:
            java.lang.string r1 = ""
            goto L17
        L78:
            int r2 = r10.int1
            goto L114
        L7e:
            JdegvQSxCwoYwLdE(r9, r3)
        L81:
            goto Lf2
        L85:
            int r2 = r7 + r0
            goto Lbb
        L8b:
            int r2 = r7 + r0
            goto Lc3
        L91:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r5 = MHaANAqjUONfZgln()
            goto L12
        L99:
            int r0 = r0 + r1
            goto L2e
        L9f:
            goto Le9
        La2:
            goto L159
        La6:
            goto L12f
        La8:
            goto Lb3
        Lac:
            xlefJbcreoBXSeFH(r9, r1)
            goto L65
        Lb3:
            int r7 = hPbOiigOFnVDgWph(r6, r0, r10)
            goto Ld7
        Lbb:
            bool r3 = LDTPwapXrraXYmWQ(r6, r7, r2)
            goto L142
        Lc3:
            bool r3 = VxmwYrfDwhddXaIO(r6, r7, r2)
            goto Ldd
        Lcb:
            AfdOpafWKXLIQrTj(r9, r3)
            goto L4
        Ld2:
            throw r5
        Ld3:
            goto Le6
        Ld7:
            int r0 = r10.int1
            goto L139
        Ldd:
            if (r3 != 0) goto Le2
            goto L5
        Le2:
            goto L20
        Le6:
            goto L61
        Le9:
            goto L12b
        Led:
            goto Lf3
        Lee:
            goto L85
        Lf2:
            r7 = r2
        Lf3:
            goto L9
        Lf7:
            int r0 = r10.int1
            goto L160
        Lfd:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r5 = VXYxyzPqWqxnpceX()
            goto L12e
        L105:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r5 = BgQOnzwuQHfXYsPr()
            goto L126
        L10d:
            r3.<init>(r6, r7, r0, r4)
            goto L7e
        L114:
            if (r5 != r2) goto L119
            goto La8
        L119:
            goto La6
        L11d:
            if (r0 == 0) goto L122
            goto L67
        L122:
            goto Lac
        L126:
            throw r5
        L127:
            goto Lfd
        L12b:
            goto La2
        L12e:
            throw r5
        L12f:
            goto L51
        L133:
            java.nio.charset.Charset r4 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L10d
        L139:
            if (r0 >= 0) goto L13e
            goto L127
        L13e:
            goto L11d
        L142:
            if (r3 != 0) goto L147
            goto L52
        L147:
            goto L4b
        L14b:
            r1 = 6
            goto L99
        L152:
            r3.<init>(r6, r7, r0, r4)
            goto Lcb
        L159:
            r0 = 17
            goto L14b
        L160:
            if (r0 >= 0) goto L165
            goto L13
        L165:
            goto L72
    }

    static int DecodestringRequireUtf8(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L22
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r1 = SfwkmPuPzwzpEmXR()
            goto L12
        Lc:
            int r0 = r3.int1
            goto L2e
        L12:
            throw r1
        L13:
            goto L17
        L17:
            goto L25
        L1a:
            java.lang.string r1 = OaVaifRvDBDUnKUm(r1, r2, r0)
            goto L4a
        L22:
            goto L13
        L25:
            goto L42
        L29:
            int r2 = r2 + r0
            goto L50
        L2e:
            if (r0 >= 0) goto L33
            goto L51
        L33:
            goto L5b
        L37:
            r3.object1 = r1
            goto L3d
        L3d:
            return r2
        L3e:
            goto L1a
        L42:
            int r2 = PLBNaJFPQxIhOVUl(r1, r2, r3)
            goto Lc
        L4a:
            r3.object1 = r1
            goto L29
        L50:
            return r2
        L51:
            goto L4
        L55:
            java.lang.string r1 = ""
            goto L37
        L5b:
            if (r0 == 0) goto L60
            goto L3e
        L60:
            goto L55
    }

    static int DecodeUnknownField(int r8, byte[] r9, int r10, int r11, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r12, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r13) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L200
        L4:
            r7 = r13
            goto L223
        L9:
            int r9 = r9 - r1
            goto L1e0
        Le:
            r0 = 28
            goto L235
        L15:
            if (r0 == r11) goto L1a
            goto L18e
        L1a:
            goto L49
        L1e:
            int r11 = r11 - r9
            goto L12a
        L23:
            if (r2 == r0) goto L28
            goto L3e
        L28:
            goto L10b
        L2c:
            throw r8
        L2d:
            goto La6
        L31:
            goto L1cf
        L33:
            goto L16a
        L37:
            r0 = r0 | 4
            goto Lae
        L3d:
            return r10
        L3e:
            goto L122
        L42:
            ehcvJoInpIxPXFxF(r12, r8, r10)
            goto Le2
        L49:
            int r9 = pwpPvxsfGjLrqrgA(r9, r10)
            goto L25b
        L51:
            int r10 = r10 + 8
            goto L14b
        L57:
            androidx.datastore.preferences.protobuf.bytestring r11 = nXnqKdAmPUdWebYz(r3, r9, r10)
            goto Le7
        L5f:
            java.lang.long r9 = TKSzhhXPXDsYMJJn(r0)
            goto L9f
        L67:
            goto L33
        L68:
            goto L1b4
        L6c:
            if (r10 <= r5) goto L71
            goto L3e
        L71:
            goto L23
        L75:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r8 = BZWdgItAgKkrEAuX()
            goto L95
        L7d:
            r11 = 5
            goto L15
        L82:
            int r0 = r0 % r1
            goto Ld9
        L88:
            throw r8
        L89:
            goto L263
        L8d:
            int r0 = SCGMObbLhqPSUFKi(r8)
            goto L24c
        L95:
            throw r8
        L96:
            goto L245
        L9a:
            r7 = r13
            goto L268
        L9f:
            DhNarFflxYoCUDys(r12, r8, r9)
            goto L51
        La6:
            r3 = r9
            goto L146
        Lab:
            goto L203
        Lae:
            int r2 = r13.recursionDepth
            goto Lce
        Lb4:
            if (r10 >= 0) goto Lb9
            goto L15c
        Lb9:
            goto L230
        Lbd:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r8 = MoZIkpZfkXQptcHU()
            goto L1c1
        Lc5:
            if (r0 != r1) goto Lca
            goto L89
        Lca:
            goto Lee
        Lce:
            int r2 = r2 + r1
            goto Ld3
        Ld3:
            r13.recursionDepth = r2
            goto L255
        Ld9:
            if (r0 <= 0) goto Lde
            goto L1b0
        Lde:
            goto L1ad
        Le2:
            return r9
        Le3:
            goto L75
        Le7:
            SBLRNWAlwEGAVPPs(r12, r8, r11)
        Lea:
            goto L192
        Lee:
            r2 = 2
            goto L212
        Lf3:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r8 = TONrgEtdOZBHMLNv()
            goto L88
        Lfb:
            int r4 = iEtjLsTQCOCJqYkW(r9, r10, r13)
            goto L19e
        L103:
            int r0 = QjsVEZnyMDCYRVrY(r8)
            goto L1ee
        L10b:
            LzaoCnUVtEPoblBQ(r12, r8, r6)
            goto L3d
        L112:
            if (r0 != r2) goto L117
            goto L1c2
        L117:
            goto L7d
        L11b:
            CDMtLLxOeyWkJBla(r12, r8, r9)
            goto L17d
        L122:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r8 = VvynvRxINXvJcnja()
            goto L2c
        L12a:
            if (r10 <= r11) goto L12f
            goto L208
        L12f:
            goto L1f7
        L133:
            int r0 = r0 + r1
            goto L82
        L139:
            sVQDpAzfBTpVAHzp(r2)
            goto L1ce
        L140:
            long r10 = r7.long1
            goto L1c6
        L146:
            r7 = r13
            goto L1b9
        L14b:
            return r10
        L14c:
            goto L22b
        L150:
            r7 = r13
            goto L1d3
        L155:
            int r10 = r7.int1
            goto Lb4
        L15b:
            throw r8
        L15c:
            goto Lf3
        L160:
            goto Lea
        L161:
            goto L57
        L165:
            r10 = r4
            goto L67
        L16a:
            r5 = r11
            goto L9a
        L16f:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r6 = xdiTvDIHjVZSxubt()
            goto L20c
        L177:
            androidx.datastore.preferences.protobuf.bytestring r11 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto L197
        L17d:
            int r10 = r10 + 4
            goto L18d
        L183:
            r2 = 3
            goto L112
        L188:
            r5 = r11
            goto L4
        L18d:
            return r10
        L18e:
            goto Lbd
        L192:
            int r9 = r9 + r10
            goto L207
        L197:
            qdbxEDSgUAwIwFJT(r12, r8, r11)
            goto L160
        L19e:
            int r2 = r13.int1
            goto L1a4
        L1a4:
            if (r2 == r0) goto L1a9
            goto L68
        L1a9:
            goto L165
        L1ad:
            goto L96
        L1b0:
            goto L103
        L1b4:
            r3 = r9
            goto L188
        L1b9:
            int r9 = EyJqbZWDPkemYGjx(r3, r10, r7)
            goto L155
        L1c1:
            throw r8
        L1c2:
            goto L16f
        L1c6:
            java.lang.long r10 = mvUdYPaAPwrrcLkp(r10)
            goto L42
        L1ce:
            r2 = 0
        L1cf:
            goto L23c
        L1d3:
            int r9 = RTbiEJPuEXrIpxsn(r3, r10, r7)
            goto L140
        L1db:
            r1 = 1
            goto Lc5
        L1e0:
            r7.recursionDepth = r9
            goto L6c
        L1e6:
            long r0 = onuToqMqBJkoiQNq(r3, r10)
            goto L5f
        L1ee:
            if (r0 != 0) goto L1f3
            goto Le3
        L1f3:
            goto L8d
        L1f7:
            if (r10 == 0) goto L1fc
            goto L161
        L1fc:
            goto L177
        L200:
            goto L248
        L203:
            goto Le
        L207:
            return r9
        L208:
            goto L21b
        L20c:
            r0 = r8 & (-8)
            goto L37
        L212:
            if (r0 != r2) goto L217
            goto L2d
        L217:
            goto L183
        L21b:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r8 = YaHIDSsJnASKUNff()
            goto L15b
        L223:
            int r10 = ihziZwQgLgaxcdYl(r2, r3, r4, r5, r6, r7)
            goto L31
        L22b:
            r3 = r9
            goto L150
        L230:
            int r11 = r3.length
            goto L1e
        L235:
            r1 = 17
            goto L133
        L23c:
            if (r10 < r11) goto L241
            goto L33
        L241:
            goto Lfb
        L245:
            goto L1b0
        L248:
            goto Lab
        L24c:
            if (r0 != 0) goto L251
            goto L14c
        L251:
            goto L1db
        L255:
            int r2 = r13.recursionDepth
            goto L139
        L25b:
            java.lang.int r9 = EvSKsRiyCEVCEpYp(r9)
            goto L11b
        L263:
            r3 = r9
            goto L1e6
        L268:
            int r9 = r7.recursionDepth
            goto L9
    }

    static int DecodeVarint32(int r2, byte[] r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
            goto Lb
        L4:
            goto La1
        L7:
            goto Lec
        Lb:
            goto L30
        Le:
            goto L34
        L12:
            r2 = r2 | r3
            goto L10a
        L17:
            int r3 = r0 << 14
            goto L6d
        L1d:
            r2 = r2 | r0
        L1e:
            goto L56
        L22:
            return r0
        L23:
            goto L15a
        L27:
            int r0 = r4 + 3
            goto Ldb
        L2d:
            goto L7
        L30:
            goto Lc9
        L34:
            r0 = 2
            goto Lc2
        L3b:
            r1 = r3[r4]
            goto Lcc
        L41:
            int r0 = r0 << 28
            goto L1d
        L47:
            r1 = r1 & 127(0x7f, float:1.78E-43)
            goto L7b
        L4d:
            if (r1 >= 0) goto L52
            goto L23
        L52:
            goto Ld5
        L56:
            int r0 = r4 + 1
            goto Lb6
        L5c:
            return r4
        L5d:
            goto L67
        L61:
            int r4 = r4 + 4
            goto Lbc
        L67:
            r0 = r0 & 127(0x7f, float:1.78E-43)
            goto L41
        L6d:
            r2 = r2 | r3
            goto L8f
        L72:
            if (r0 >= 0) goto L77
            goto L5d
        L77:
            goto La5
        L7b:
            int r1 = r1 << 7
            goto L95
        L81:
            r4 = r0
            goto L104
        L86:
            if (r0 >= 0) goto L8b
            goto L13e
        L8b:
            goto L17
        L8f:
            r5.int1 = r2
            goto L13d
        L95:
            r2 = r2 | r1
            goto Le1
        L9a:
            r5.int1 = r2
            goto L11b
        La0:
            return r0
        La1:
            goto L2d
        La5:
            int r3 = r0 << 28
            goto L12
        Lab:
            int r0 = r0 + r1
            goto Lf2
        Lb1:
            r2 = r2 | r0
            goto L27
        Lb6:
            r4 = r3[r4]
            goto L148
        Lbc:
            r0 = r3[r0]
            goto L72
        Lc2:
            r1 = 11
            goto Lab
        Lc9:
            goto Le
        Lcc:
            if (r1 >= 0) goto Ld1
            goto L11c
        Ld1:
            goto L142
        Ld5:
            int r3 = r1 << 21
            goto Le7
        Ldb:
            r1 = r3[r1]
            goto L4d
        Le1:
            int r1 = r4 + 2
            goto L126
        Le7:
            r2 = r2 | r3
            goto Lf8
        Lec:
            r2 = r2 & 127(0x7f, float:1.78E-43)
            goto L120
        Lf2:
            int r0 = r0 % r1
            goto L151
        Lf8:
            r5.int1 = r2
            goto L22
        Lfe:
            r5.int1 = r2
            goto La0
        L104:
            goto L1e
        L106:
            goto Lfe
        L10a:
            r5.int1 = r2
            goto L5c
        L110:
            r2 = r2 | r3
            goto L9a
        L115:
            int r0 = r0 << 14
            goto Lb1
        L11b:
            return r0
        L11c:
            goto L47
        L120:
            int r0 = r4 + 1
            goto L3b
        L126:
            r0 = r3[r0]
            goto L86
        L12c:
            int r1 = r1 << 21
            goto L138
        L132:
            r0 = r0 & 127(0x7f, float:1.78E-43)
            goto L115
        L138:
            r2 = r2 | r1
            goto L61
        L13d:
            return r1
        L13e:
            goto L132
        L142:
            int r3 = r1 << 7
            goto L110
        L148:
            if (r4 < 0) goto L14d
            goto L106
        L14d:
            goto L81
        L151:
            if (r0 <= 0) goto L156
            goto L7
        L156:
            goto L4
        L15a:
            r1 = r1 & 127(0x7f, float:1.78E-43)
            goto L12c
    }

    static int DecodeVarint32(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L11
        L4:
            int r1 = oHTGdxChLlcYmUvO(r2, r1, r0, r3)
            goto Lc
        Lc:
            return r1
        Ld:
            goto L38
        L11:
            goto Ld
        L14:
            goto L24
        L18:
            r3.int1 = r2
            goto L2a
        L1e:
            r2 = r1[r2]
            goto L2f
        L24:
            int r0 = r2 + 1
            goto L1e
        L2a:
            return r0
        L2b:
            goto L4
        L2f:
            if (r2 >= 0) goto L34
            goto L2b
        L34:
            goto L18
        L38:
            goto L14
    }

    static int DecodeVarint32List(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L22
        L4:
            if (r2 != r1) goto L9
            goto Lf
        L9:
            goto Ld
        Ld:
            goto L8e
        Lf:
            goto L29
        L13:
            goto L25
        L16:
            int r0 = r7.int1
            goto L3d
        L1c:
            int r0 = r7.int1
            goto L92
        L22:
            goto L47
        L25:
            goto L6e
        L29:
            int r4 = wLlqJioTjRLgphEp(r3, r0, r7)
            goto L1c
        L31:
            int r0 = r0 % r1
            goto L7e
        L37:
            int r0 = r0 + r1
            goto L31
        L3d:
            AIFMqkUUrgxJIXoG(r6, r0)
        L40:
            goto L75
        L44:
            goto L56
        L47:
            goto L13
        L4b:
            int r0 = dpeSqBQBzjTHQNdW(r3, r4, r7)
            goto L87
        L53:
            goto L63
        L56:
            goto L99
        L5a:
            int r4 = CyaWajMhJCyWJlRG(r3, r4, r7)
            goto L16
        L62:
            return r4
        L63:
            goto L44
        L67:
            r1 = 22
            goto L37
        L6e:
            r0 = 1
            goto L67
        L75:
            if (r4 < r5) goto L7a
            goto L8e
        L7a:
            goto L4b
        L7e:
            if (r0 <= 0) goto L83
            goto L56
        L83:
            goto L53
        L87:
            int r1 = r7.int1
            goto L4
        L8d:
            goto L40
        L8e:
            goto L62
        L92:
            MLSnSDybeePxtIxK(r6, r0)
            goto L8d
        L99:
            androidx.datastore.preferences.protobuf.IntList r6 = (androidx.datastore.preferences.protobuf.IntList) r6
            goto L5a
    }

    static int DecodeVarint64(long r7, byte[] r9, int r10, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r11) {
            goto Lab
        L4:
            long r1 = (long) r1
            goto L5b
        L9:
            r1 = r10 & 127(0x7f, float:1.78E-43)
            goto L4
        Lf:
            goto L23
        L12:
            goto L48
        L16:
            r1 = r3
        L17:
            goto L7c
        L1b:
            long r7 = r7 | r1
            goto L16
        L20:
            goto L35
        L23:
            goto L65
        L27:
            r1 = 23
            goto L50
        L2e:
            r10 = r9[r10]
            goto L9
        L34:
            return r0
        L35:
            goto Lf
        L39:
            long r4 = (long) r2
            goto L9b
        L3e:
            long r7 = r7 | r4
            goto L60
        L43:
            r0 = r10
            goto L4b
        L48:
            goto Lae
        L4b:
            r10 = r6
            goto L56
        L50:
            int r0 = r0 + r1
            goto L85
        L56:
            goto L17
        L57:
            goto L71
        L5b:
            r3 = 7
            goto La6
        L60:
            r6 = r0
            goto L43
        L65:
            r0 = 127(0x7f, double:6.27E-322)
            goto L77
        L6b:
            r0 = r9[r0]
            goto Lb8
        L71:
            r11.long1 = r7
            goto L34
        L77:
            long r7 = r7 & r0
            goto Lbd
        L7c:
            if (r10 < 0) goto L81
            goto L57
        L81:
            goto La0
        L85:
            int r0 = r0 % r1
            goto L8b
        L8b:
            if (r0 <= 0) goto L90
            goto L23
        L90:
            goto L20
        L94:
            r0 = 21
            goto L27
        L9b:
            long r4 = r4 << r1
            goto L3e
        La0:
            int r10 = r0 + 1
            goto L6b
        La6:
            long r1 = r1 << r3
            goto L1b
        Lab:
            goto L12
        Lae:
            goto L94
        Lb2:
            r2 = r0 & 127(0x7f, float:1.78E-43)
            goto L39
        Lb8:
            int r1 = r1 + r3
            goto Lb2
        Lbd:
            int r0 = r10 + 1
            goto L2e
    }

    static int DecodeVarint64(byte[] r5, int r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L59
        L4:
            long r1 = (long) r6
            goto L32
        L9:
            goto L22
        Lc:
            goto L1c
        L10:
            int r0 = r6 + 1
            goto L26
        L16:
            r7.long1 = r1
            goto L40
        L1c:
            goto L5c
        L1f:
            goto L46
        L22:
            goto L10
        L26:
            r6 = r5[r6]
            goto L4
        L2c:
            int r6 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L4a
        L32:
            r3 = 0
            goto L2c
        L38:
            int r5 = jNwIezOzeFMHqgjt(r1, r5, r0, r7)
            goto L45
        L40:
            return r0
        L41:
            goto L38
        L45:
            return r5
        L46:
            goto L9
        L4a:
            if (r6 >= 0) goto L4f
            goto L41
        L4f:
            goto L16
        L53:
            int r0 = r0 % r1
            goto L67
        L59:
            goto Lc
        L5c:
            goto L60
        L60:
            r0 = 29
            goto L76
        L67:
            if (r0 <= 0) goto L6c
            goto L22
        L6c:
            goto L1f
        L70:
            int r0 = r0 + r1
            goto L53
        L76:
            r1 = 16
            goto L70
    }

    static int DecodeVarint64List(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.Internal.ProtobufList<object> r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto L40
        L4:
            goto Ld
        L5:
            goto L90
        L9:
            goto L43
        Lc:
            goto L58
        Ld:
            goto L1a
        L11:
            if (r2 != r1) goto L16
            goto L5
        L16:
            goto L4
        L1a:
            return r4
        L1b:
            goto L26
        L1f:
            goto L1b
        L22:
            goto L34
        L26:
            goto L22
        L29:
            goto L9
        L2d:
            r0 = 11
            goto L47
        L34:
            androidx.datastore.preferences.protobuf.longList r6 = (androidx.datastore.preferences.protobuf.longList) r6
            goto L5c
        L3a:
            long r0 = r7.long1
            goto L4e
        L40:
            goto L29
        L43:
            goto L2d
        L47:
            r1 = 3
            goto L8a
        L4e:
            aqCbHioNuFdsLkOE(r6, r0)
            goto Lc
        L55:
            tWfixQeofaGUVjcJ(r6, r0)
        L58:
            goto L64
        L5c:
            int r4 = eznFLLZXEIHBdFHv(r3, r4, r7)
            goto L98
        L64:
            if (r4 < r5) goto L69
            goto Ld
        L69:
            goto L79
        L6d:
            int r1 = r7.int1
            goto L11
        L73:
            int r0 = r0 % r1
            goto L81
        L79:
            int r0 = SkpcvuyUOaFORBEw(r3, r4, r7)
            goto L6d
        L81:
            if (r0 <= 0) goto L86
            goto L22
        L86:
            goto L1f
        L8a:
            int r0 = r0 + r1
            goto L73
        L90:
            int r4 = xlsibNOIbuRvPqkm(r3, r0, r7)
            goto L3a
        L98:
            long r0 = r7.long1
            goto L55
    }

    public static int DpeSqBQBzjTHQNdW(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static bool DzXryJohjVpLOcXj(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto L4
        L18:
            goto Lc
    }

    public static void ESuJlzBTcLhIYAxj(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
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
            r0.addInt(r1)
            goto Lb
        L17:
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException EWcjLYntzPcqnowg() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag()
            goto L4
        L18:
            goto Lc
    }

    public static int EYYtXNjBVWJcBEPY(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void EhcvJoInpIxPXFxF(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.storeField(r1, r2)
            goto L4
    }

    public static int EznFLLZXEIHBdFHv(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint64(r1, r2, r3)
            goto Le
    }

    public static bool FEFBYmxmLFrCHdXf(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Add(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object FKqTLOrwBPgwMmxQ(androidx.datastore.preferences.protobuf.Schema r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.newInstance()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool FTDsotyDjVllANGa(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtensionDescriptor r1) {
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
            bool r0 = r1.isRepeated()
            goto Lb
        L18:
            goto L7
    }

    public static int FXdeegLySYGOvJAa(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint64(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static void FyFLaWhZSIwuQiNf(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.setField(r1, r2)
            goto Le
    }

    public static bool GAjPnwRKVZkDYMSI(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.isRepeated()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GHrieWCsMkibhlDc() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void GPqLUQWKWNqaGYra(androidx.datastore.preferences.protobuf.Schema r0, java.lang.object r1) {
            goto Lb
        L4:
            r0.makeImmutable(r1)
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

    public static int GWzWHbtoNywBOXWy(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto L14
        L4:
            int r0 = decodePackedVarint32List(r1, r2, r3, r4)
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

    public static void GXWxTbBappgauHhN(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.addlong(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException GiZIMurROIXAiQmS() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L4
    }

    public static void GsVxITQOPTmZMtUr(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            r0.setField(r1, r2)
            goto Lb
    }

    public static long GvoMLPBqHHNWUftL(byte[] r2, int r3) {
            goto Lb
        L4:
            r1 = 31
            goto L21
        Lb:
            goto L32
        Le:
            goto L45
        L12:
            int r0 = r0 % r1
            goto L18
        L18:
            if (r0 <= 0) goto L1d
            goto L3c
        L1d:
            goto L39
        L21:
            int r0 = r0 + r1
            goto L12
        L27:
            long r0 = decodeFixed64(r2, r3)
            goto L40
        L2f:
            goto L3c
        L32:
            goto L36
        L36:
            goto Le
        L39:
            goto L41
        L3c:
            goto L27
        L40:
            return r0
        L41:
            goto L2f
        L45:
            r0 = 15
            goto L4
    }

    public static java.lang.long HAOyoGFgHVjhhbtG(long r1) {
            goto L14
        L4:
            java.lang.long r0 = java.lang.long.valueOf(r1)
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

    public static int HGkojDDwRgACtZjA(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = decodePackedBoolList(r1, r2, r3, r4)
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

    public static int HPbOiigOFnVDgWph(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void HQuLebepaQRZeYjJ(androidx.datastore.preferences.protobuf.floatList r0, float r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.addfloat(r1)
            goto L4
        L17:
            goto Lc
    }

    public static bool HcnSGeLPchhKXLyq(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Add(r2)
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

    public static int IEtjLsTQCOCJqYkW(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.WireFormat.FieldType IHsvPPxUVURSYozJ(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
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
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r1.getLiteType()
            goto Lb
    }

    public static int IhziZwQgLgaxcdYl(int r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = decodeUnknownField(r1, r2, r3, r4, r5, r6)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int ItNELVzqhySkjthp(int r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtendableMessage r5, androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r6, androidx.datastore.preferences.protobuf.UnknownFieldSchema r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = decodeExtension(r1, r2, r3, r4, r5, r6, r7, r8)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int JAMDlzcfoxzXhvdG(byte[] r1, int r2) {
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
            int r0 = decodeFixed32(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static void JKrJkFNFJaeMWIWP(androidx.datastore.preferences.protobuf.boolList r0, bool r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.addbool(r1)
            goto Le
    }

    public static int JNwIezOzeFMHqgjt(long r1, byte[] r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = decodeVarint64(r1, r3, r4, r5)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int JexAVTXvPIFzXMKN(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static double JldiEBOggoHKmVYF(long r2) {
            goto Lb
        L4:
            goto L48
        L7:
            goto L21
        Lb:
            goto L7
        Le:
            goto L1a
        L12:
            double r0 = java.lang.double.longBitsTodouble(r2)
            goto L24
        L1a:
            r0 = 12
            goto L3e
        L21:
            goto Le
        L24:
            return r0
        L25:
            goto L4
        L29:
            int r0 = r0 + r1
            goto L38
        L2f:
            if (r0 <= 0) goto L34
            goto L48
        L34:
            goto L45
        L38:
            int r0 = r0 % r1
            goto L2f
        L3e:
            r1 = 21
            goto L29
        L45:
            goto L25
        L48:
            goto L12
    }

    public static void KEYHPNLLmRHXNxEC(androidx.datastore.preferences.protobuf.doubleList r0, double r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.adddouble(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void KGMPPVuqmBQtwaiA(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.setField(r1, r2)
            goto Le
    }

    public static int KGPZLSuvluEIiBcX(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static int KZpNDiIucdowQHCi(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodeVarint32(r1, r2, r3)
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

    public static void KriBLfwVXruPYPWU(androidx.datastore.preferences.protobuf.floatList r0, float r1) {
            goto L13
        L4:
            r0.addfloat(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static bool LFOoTAncjeBQezQX(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
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
            bool r0 = r1.isRepeated()
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException LUpgfaCikYfFdfPe() {
            goto L14
        L4:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
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

    public static bool LbliPERZjHXirTCu(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Le
    }

    public static java.lang.float LhHBAuUnBoxDcMIg(float r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.float r0 = java.lang.float.valueOf(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int LuMXdbijbsHbFvgQ(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodePackedVarint64List(r1, r2, r3, r4)
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

    public static void MLMYrSCgjusHFpcy(androidx.datastore.preferences.protobuf.doubleList r0, double r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.adddouble(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static bool MOPVaQQLfmLaRYIH(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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

    public static int MZelRXWBCbExoTvG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    static int MergeGroupField(java.lang.object r2, androidx.datastore.preferences.protobuf.Schema r3, byte[] r4, int r5, int r6, int r7, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r8) throws java.io.IOException {
            goto L4c
        L4:
            r2 = r1
            goto L32
        L9:
            goto L68
        Lc:
            goto L8a
        L10:
            NLtMpozrFbIPcZmH(r0)
            goto L85
        L17:
            if (r0 <= 0) goto L1c
            goto L68
        L1c:
            goto L65
        L20:
            r8.object1 = r3
            goto L93
        L26:
            int r0 = r0 % r1
            goto L17
        L2c:
            r8.recursionDepth = r4
            goto L20
        L32:
            int r2 = ovxBoSQlJZhioZjZ(r2, r3, r4, r5, r6, r7, r8)
            goto L3a
        L3a:
            int r4 = r8.recursionDepth
            goto L8d
        L40:
            int r0 = r0 + 1
            goto L5f
        L46:
            androidx.datastore.preferences.protobuf.MessageSchema r3 = (androidx.datastore.preferences.protobuf.MessageSchema) r3
            goto L7f
        L4c:
            goto Lc
        L4f:
            goto L78
        L53:
            r1 = 16
            goto L72
        L5a:
            r3 = r2
            goto L4
        L5f:
            r8.recursionDepth = r0
            goto L6c
        L65:
            goto L94
        L68:
            goto L46
        L6c:
            int r0 = r8.recursionDepth
            goto L10
        L72:
            int r0 = r0 + r1
            goto L26
        L78:
            r0 = 12
            goto L53
        L7f:
            int r0 = r8.recursionDepth
            goto L40
        L85:
            r1 = r3
            goto L5a
        L8a:
            goto L4f
        L8d:
            int r4 = r4 + (-1)
            goto L2c
        L93:
            return r2
        L94:
            goto L9
    }

    static int MergeMessageField(java.lang.object r6, androidx.datastore.preferences.protobuf.Schema r7, byte[] r8, int r9, int r10, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r11) throws java.io.IOException {
            goto L52
        L4:
            r5.object1 = r1
            goto L59
        La:
            int r0 = r0 % r1
            goto L17
        L10:
            yrEFMSkOStBWIQHe(r10)
            goto Lb8
        L17:
            if (r0 <= 0) goto L1c
            goto L35
        L1c:
            goto L32
        L20:
            int r10 = r11.recursionDepth
            goto L10
        L26:
            int r6 = r6 + (-1)
            goto La7
        L2c:
            int r0 = r0 + r1
            goto La
        L32:
            goto L42
        L35:
            goto L46
        L39:
            int r0 = JXOLWmUtTietsZyS(r9, r8, r0, r11)
            goto La1
        L41:
            throw r6
        L42:
            goto L72
        L46:
            int r0 = r9 + 1
            goto L88
        L4c:
            int r6 = r5.recursionDepth
            goto L26
        L52:
            goto L75
        L55:
            goto L6b
        L59:
            return r4
        L5a:
            goto Le0
        L5e:
            GTPjkcbgesnpPnFb(r0, r1, r2, r3, r4, r5)
            goto L4c
        L65:
            int r10 = r10 + 1
            goto Lb2
        L6b:
            r0 = 2
            goto Ld9
        L72:
            goto L35
        L75:
            goto L9e
        L79:
            r3 = r0
            goto Lc7
        L7e:
            r5 = r11
            goto L5e
        L83:
            r1 = r6
            goto L99
        L88:
            r9 = r8[r9]
            goto Ld0
        L8e:
            r2 = r8
            goto L7e
        L93:
            int r10 = r11.recursionDepth
            goto L65
        L99:
            r0 = r7
            goto L8e
        L9e:
            goto L55
        La1:
            int r9 = r11.int1
        La3:
            goto L79
        La7:
            r5.recursionDepth = r6
            goto L4
        Lad:
            int r10 = r10 - r3
            goto Lbe
        Lb2:
            r11.recursionDepth = r10
            goto L20
        Lb8:
            int r4 = r3 + r9
            goto L83
        Lbe:
            if (r9 <= r10) goto Lc3
            goto L5a
        Lc3:
            goto L93
        Lc7:
            if (r9 >= 0) goto Lcc
            goto L5a
        Lcc:
            goto Lad
        Ld0:
            if (r9 < 0) goto Ld5
            goto La3
        Ld5:
            goto L39
        Ld9:
            r1 = 20
            goto L2c
        Le0:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r6 = giZIMurROIXAiQmS()
            goto L41
    }

    public static long MjghdpqupKqVtcxR(byte[] r2, int r3) {
            goto L4
        L4:
            goto Le
        L7:
            goto L28
        Lb:
            goto L24
        Le:
            goto L44
        L12:
            int r0 = r0 % r1
            goto L18
        L18:
            if (r0 <= 0) goto L1d
            goto L24
        L1d:
            goto L21
        L21:
            goto L48
        L24:
            goto L35
        L28:
            r0 = 25
            goto L3d
        L2f:
            int r0 = r0 + r1
            goto L12
        L35:
            long r0 = decodeFixed64(r2, r3)
            goto L47
        L3d:
            r1 = 23
            goto L2f
        L44:
            goto L7
        L47:
            return r0
        L48:
            goto Lb
    }

    public static void MqTKVnePXGFPbvzI(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto Lb
        L4:
            r0.addInt(r1)
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

    public static java.lang.long MvUdYPaAPwrrcLkp(long r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.long r0 = java.lang.long.valueOf(r1)
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

    public static int NIIcSErWDTMmZNVD(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = decodeMessageField(r1, r2, r3, r4, r5)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void NSDzJsNOXjrqhaSs(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto Lb
        L4:
            r0.addlong(r1)
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

    public static androidx.datastore.preferences.protobuf.bytestring NXnqKdAmPUdWebYz(byte[] r1, int r2, int r3) {
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
            androidx.datastore.preferences.protobuf.bytestring r0 = androidx.datastore.preferences.protobuf.bytestring.copyFrom(r1, r2, r3)
            goto L4
    }

    public static void NkcgRPVagRXSZTuS(androidx.datastore.preferences.protobuf.Schema r0, java.lang.object r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.makeImmutable(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static int NtOgQkIyyoctLlrk(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException NvKQbTCkoOoykhuC() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int OHTGdxChLlcYmUvO(int r1, byte[] r2, int r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = decodeVarint32(r1, r2, r3, r4)
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

    public static java.lang.object ONPpEEVmDLMdfyDZ(java.lang.object r1, int r2, int r3, java.lang.object r4, androidx.datastore.preferences.protobuf.UnknownFieldSchema r5) {
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
            java.lang.object r0 = androidx.datastore.preferences.protobuf.SchemaUtil.storeUnknownEnum(r1, r2, r3, r4, r5)
            goto Lb
    }

    public static int ORZuIwwtCNmxWjVR(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
    }

    public static bool OaViDsqBvIHbwQud(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtensionDescriptor r1) {
            goto L14
        L4:
            bool r0 = r1.isPacked()
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

    public static int OhuJdyGlvsnOHNrG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static long OnuToqMqBJkoiQNq(byte[] r2, int r3) {
            goto L2d
        L4:
            int r0 = r0 + r1
            goto L43
        La:
            r1 = 28
            goto L4
        L11:
            goto L20
        L14:
            goto L49
        L18:
            return r0
        L19:
            goto L11
        L1d:
            goto L19
        L20:
            goto L3b
        L24:
            if (r0 <= 0) goto L29
            goto L20
        L29:
            goto L1d
        L2d:
            goto L14
        L30:
            goto L34
        L34:
            r0 = 17
            goto La
        L3b:
            long r0 = decodeFixed64(r2, r3)
            goto L18
        L43:
            int r0 = r0 % r1
            goto L24
        L49:
            goto L30
    }

    public static int OvxBoSQlJZhioZjZ(androidx.datastore.preferences.protobuf.MessageSchema r1, java.lang.object r2, byte[] r3, int r4, int r5, int r6, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r7) {
            goto Lc
        L4:
            int r0 = r1.parseMessage(r2, r3, r4, r5, r6, r7)
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

    public static int PwpPvxsfGjLrqrgA(byte[] r1, int r2) {
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
            int r0 = decodeFixed32(r1, r2)
            goto L7
    }

    public static int QVnspZZGYSOpwyux(java.lang.object r1, androidx.datastore.preferences.protobuf.Schema r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
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
            int r0 = mergeMessageField(r1, r2, r3, r4, r5, r6)
            goto L4
    }

    public static int QXFJtsJKxmBBDhLG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            int r0 = decodeVarint64(r1, r2, r3)
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

    public static void QdbxEDSgUAwIwFJT(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0, int r1, java.lang.object r2) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.storeField(r1, r2)
            goto L4
    }

    public static androidx.datastore.preferences.protobuf.Schema QzGZUVfqVBVKeJuE(androidx.datastore.preferences.protobuf.Protobuf r1, java.lang.Class r2) {
            goto Lf
        L4:
            androidx.datastore.preferences.protobuf.Schema r0 = r1.schemaFor(r2)
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

    public static int RWbChfdICPIFUNFG(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodePackedFixed32List(r1, r2, r3, r4)
            goto L7
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException RXsIHSPvyAsplPXG() {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int RZaKWXDdmUpwmIsO(androidx.datastore.preferences.protobuf.Schema r1, byte[] r2, int r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
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
            int r0 = decodeGroupField(r1, r2, r3, r4, r5, r6)
            goto Lb
    }

    public static int RsQtEvIJbUuZTSnC(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodePackedSInt64List(r1, r2, r3, r4)
            goto L4
    }

    public static int SJWMkOpTFNMmBPML(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = decodePackedVarint32List(r1, r2, r3, r4)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void SVQDpAzfBTpVAHzp(int r0) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            checkRecursionLimit(r0)
            goto L4
    }

    public static void SWPHhQQslUXwdpEc(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.addInt(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static float SZFrYdAPSHTaEFPC(int r1) {
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
            float r0 = java.lang.float.intBitsTofloat(r1)
            goto L4
        L18:
            goto Lc
    }

    public static void SetRecursionLimit(int r0) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            androidx.datastore.preferences.protobuf.ArrayDecoders.recursionLimit = r0
            goto L7
        L12:
            goto L8
        L15:
            goto Lc
    }

    public static void SigVLHeZVHlBebKq(androidx.datastore.preferences.protobuf.IntList r0, int r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.addInt(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    static int SkipField(int r2, byte[] r3, int r4, int r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
            goto L59
        L4:
            int r4 = r4 + 4
            goto Le2
        La:
            goto L55
        Ld:
            goto L87
        L11:
            int r0 = r6.int1
            goto Lb0
        L17:
            r0 = 0
        L18:
            goto L12d
        L1c:
            r2 = r2 | 4
            goto L17
        L22:
            goto L18
        L23:
            goto Le7
        L27:
            return r2
        L28:
            goto L47
        L2c:
            return r4
        L2d:
            goto L7f
        L31:
            goto L23
        L32:
            goto L77
        L36:
            int r2 = DMnhVjGRMarrJWwc(r3, r4, r6)
            goto L11e
        L3e:
            if (r0 != r1) goto L43
            goto L28
        L43:
            goto L99
        L47:
            int r4 = r4 + 8
            goto L2c
        L4d:
            r2 = 5
            goto L13e
        L52:
            goto L8b
        L55:
            goto L136
        L59:
            goto Ld
        L5c:
            goto Lc2
        L60:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = wKMxdjytMyseshpf()
            goto L8a
        L68:
            if (r0 != r1) goto L6d
            goto L95
        L6d:
            goto L4d
        L71:
            int r0 = r0 % r1
            goto Lf0
        L77:
            int r4 = BMPfEOoWIyrGFHiI(r0, r3, r4, r5, r6)
            goto L22
        L7f:
            int r2 = GAnObXQChaPMZWGp(r3, r4, r6)
            goto L9e
        L87:
            goto L5c
        L8a:
            throw r2
        L8b:
            goto La
        L8f:
            int r2 = r2 + r3
            goto L27
        L94:
            throw r2
        L95:
            goto Lc9
        L99:
            r1 = 2
            goto Lb9
        L9e:
            return r2
        L9f:
            goto L60
        La3:
            return r4
        La4:
            goto La8
        La8:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = QjpYNLUFqzTNBXhh()
            goto Lcf
        Lb0:
            if (r0 == r2) goto Lb5
            goto L32
        Lb5:
            goto L31
        Lb9:
            if (r0 != r1) goto Lbe
            goto Ld0
        Lbe:
            goto Ld4
        Lc2:
            r0 = 4
            goto Lf9
        Lc9:
            r2 = r2 & (-8)
            goto L1c
        Lcf:
            throw r2
        Ld0:
            goto L36
        Ld4:
            r1 = 3
            goto L68
        Ld9:
            if (r0 != 0) goto Lde
            goto L2d
        Lde:
            goto L100
        Le2:
            return r4
        Le3:
            goto L116
        Le7:
            if (r4 <= r5) goto Lec
            goto La4
        Lec:
            goto L124
        Lf0:
            if (r0 <= 0) goto Lf5
            goto L55
        Lf5:
            goto L52
        Lf9:
            r1 = 20
            goto L14f
        L100:
            r1 = 1
            goto L3e
        L105:
            int r0 = PqmyGraSsCPSBxOv(r2)
            goto Ld9
        L10d:
            if (r0 != 0) goto L112
            goto L9f
        L112:
            goto L105
        L116:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r2 = eWcjLYntzPcqnowg()
            goto L94
        L11e:
            int r3 = r6.int1
            goto L8f
        L124:
            if (r0 == r2) goto L129
            goto La4
        L129:
            goto La3
        L12d:
            if (r4 < r5) goto L132
            goto L23
        L132:
            goto L147
        L136:
            int r0 = HCdaInoMxFpeqAwZ(r2)
            goto L10d
        L13e:
            if (r0 == r2) goto L143
            goto Le3
        L143:
            goto L4
        L147:
            int r4 = FBJCLYOWdoSeZXgv(r3, r4, r6)
            goto L11
        L14f:
            int r0 = r0 + r1
            goto L71
    }

    public static int TBLrdHPjPQSeMjqW(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static int TKvNMIBJdUAdSwxg(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static int TSclREREjvNmJGxV(byte[] r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = decodeFixed32(r1, r2)
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

    public static bool TVFzjfzocbMifAae(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.Add(r2)
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

    public static void TWfixQeofaGUVjcJ(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.addlong(r1)
            goto L4
    }

    public static bool TrEbMKnNcTQbTKrf(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto L4
        L18:
            goto Lc
    }

    public static int TyGHAzYznjOWrPJI(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite UnSiXVJAhpFjCjIF(java.lang.object r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0 = androidx.datastore.preferences.protobuf.MessageSchema.getMutableUnknownFields(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int UvgGlsIieSmaCIQy(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto Lb
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException VIyrKwqoWoQFpUJF() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool VcYeksLvcPCpuufs(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto Lb
    }

    public static void VdOMDvhZvpCDONqU(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.setField(r1, r2)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static int VfxoZIriHuSqcUqu(byte[] r1, int r2) {
            goto Lc
        L4:
            int r0 = decodeFixed32(r1, r2)
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

    public static int VvjuuGtJkvzRbPIv(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
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
            int r0 = decodePackedFixed64List(r1, r2, r3, r4)
            goto L7
    }

    public static void WCXEAhZzOXIJpdNI(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.addlong(r1)
            goto L4
        L17:
            goto Lc
    }

    public static long WKKgFvIupSEHgGBT(long r2) {
            goto L1d
        L4:
            goto L19
        L7:
            goto L3a
        Lb:
            r1 = 16
            goto L24
        L12:
            int r0 = r0 % r1
            goto L2a
        L18:
            return r0
        L19:
            goto L42
        L1d:
            goto L45
        L20:
            goto L33
        L24:
            int r0 = r0 + r1
            goto L12
        L2a:
            if (r0 <= 0) goto L2f
            goto L7
        L2f:
            goto L4
        L33:
            r0 = 27
            goto Lb
        L3a:
            long r0 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r2)
            goto L18
        L42:
            goto L7
        L45:
            goto L49
        L49:
            goto L20
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WKMxdjytMyseshpf() {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidTag()
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException WKVqFZUcKVGaguSH() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto Lb
        L18:
            goto L7
    }

    public static int WLlqJioTjRLgphEp(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.long WSKtSYvDKlpNRQZe(long r1) {
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
            java.lang.long r0 = java.lang.long.valueOf(r1)
            goto Lb
    }

    public static int WbjeNvSrKRZrcBEy(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static androidx.datastore.preferences.protobuf.MessageLite WfRrbDJUOhQQopzo(androidx.datastore.preferences.protobuf.GeneratedMessageLite.GeneratedExtension r1) {
            goto L14
        L4:
            androidx.datastore.preferences.protobuf.MessageLite r0 = r1.getMessageDefaultInstance()
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

    public static void WzTjLpIVtgVkeXjA(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.addRepeatedField(r1, r2)
            goto Le
    }

    public static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite XdiTvDIHjVZSxubt() {
            goto Lc
        L4:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0 = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static bool XlefJbcreoBXSeFH(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Add(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int XlsibNOIbuRvPqkm(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
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
            int r0 = decodeVarint64(r1, r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.Class XvzGZQBrDRpOHFph(java.lang.object r1) {
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
            java.lang.Class r0 = r1.GetType()
            goto L4
    }

    public static int YGmaBKtYPdOzxswO(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = decodeVarint32(r1, r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int YicboNlbUocXBLXD(byte[] r1, int r2, androidx.datastore.preferences.protobuf.Internal.ProtobufList r3, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r4) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = decodePackedfloatList(r1, r2, r3, r4)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static androidx.datastore.preferences.protobuf.WireFormat.FieldType YjQrYWDRhxjUxotl(androidx.datastore.preferences.protobuf.GeneratedMessageLite.ExtensionDescriptor r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r1.getLiteType()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void YooLzGxrEQyvuevG(androidx.datastore.preferences.protobuf.longList r0, long r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.addlong(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static int YrDjxOGwKyoYjSRJ(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = decodeVarint64(r1, r2, r3)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void YrEFMSkOStBWIQHe(int r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            checkRecursionLimit(r0)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static androidx.datastore.preferences.protobuf.InvalidProtocolBufferException ZCfkpsduucAgBAXo() {
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
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.negativeSize()
            goto Lb
    }

    public static bool ZGeAALrKRRwJulCD(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto L4
    }

    public static void ZauSUKPqestADMDO(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setField(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void ZlJfZLEpwTCtSTiE(androidx.datastore.preferences.protobuf.FieldHashSet r0, androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite r1, java.lang.object r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.addRepeatedField(r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static int ZlpIaWkZMcNhySeh(byte[] r1, int r2, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = decodeVarint32(r1, r2, r3)
            goto Le
    }

    public static bool ZnLDNsPDDXCoGuBY(androidx.datastore.preferences.protobuf.Internal.ProtobufList r1, java.lang.object r2) {
            goto Lc
        L4:
            bool r0 = r1.Add(r2)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static long ZthNNneFkvzWnDXt(byte[] r2, int r3) {
            goto Lc
        L4:
            long r0 = decodeFixed64(r2, r3)
            goto L21
        Lc:
            goto L35
        Lf:
            goto L3c
        L13:
            r1 = 29
            goto L26
        L1a:
            goto L22
        L1d:
            goto L4
        L21:
            return r0
        L22:
            goto L32
        L26:
            int r0 = r0 + r1
            goto L2c
        L2c:
            int r0 = r0 % r1
            goto L43
        L32:
            goto L1d
        L35:
            goto L39
        L39:
            goto Lf
        L3c:
            r0 = 28
            goto L13
        L43:
            if (r0 <= 0) goto L48
            goto L1d
        L48:
            goto L1a
    }

    public static int ZusZXhPipiMghXbj(int r1, byte[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = decodeUnknownField(r1, r2, r3, r4, r5, r6)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }
}

