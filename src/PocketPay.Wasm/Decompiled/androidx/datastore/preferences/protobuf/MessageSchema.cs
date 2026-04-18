namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes5.dex */
@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class MessageSchema<T> : androidx.datastore.preferences.protobuf.Schema<T> {
    private static readonly int CHECK_INITIALIZED_BIT = 1024;
    private static readonly int[] EMPTY_INT_ARRAY = null;
    private static readonly int ENFORCE_UTF8_MASK = 536870912;
    private static readonly int FIELD_TYPE_MASK = 267386880;
    private static readonly int HAS_HAS_BIT = 4096;
    private static readonly int INTS_PER_FIELD = 3;
    private static readonly int LEGACY_ENUM_IS_CLOSED_BIT = 2048;
    private static readonly int LEGACY_ENUM_IS_CLOSED_MASK = int.MIN_VALUE;
    private static readonly int NO_PRESENCE_SENTINEL = 1048575;
    private static readonly int OFFSET_BITS = 20;
    private static readonly int OFFSET_MASK = 1048575;
    static readonly int ONEOF_TYPE_OFFSET = 51;
    private static readonly int REQUIRED_BIT = 256;
    private static readonly int REQUIRED_MASK = 268435456;
    private static readonly sun.misc.Unsafe UNSAFE = null;
    private static readonly int UTF8_CHECK_BIT = 512;
    private readonly int[] buffer;
    private readonly int checkInitializedCount;
    private readonly androidx.datastore.preferences.protobuf.MessageLite defaultInstance;
    private readonly androidx.datastore.preferences.protobuf.ExtensionSchema<object> extensionSchema;
    private readonly bool hasExtensions;
    private readonly int[] intArray;
    private readonly androidx.datastore.preferences.protobuf.ListFieldSchema listFieldSchema;
    private readonly bool lite;
    private readonly androidx.datastore.preferences.protobuf.DictionaryFieldSchema mapFieldSchema;
    private readonly int maxFieldNumber;
    private readonly int minFieldNumber;
    private readonly androidx.datastore.preferences.protobuf.NewInstanceSchema newInstanceSchema;
    private readonly java.lang.object[] objects;
    private readonly int repeatedFieldOffsetStart;
    private readonly androidx.datastore.preferences.protobuf.ProtoSyntax syntax;
    private readonly androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> unknownFieldSchema;
    private readonly bool useCachedSizeField;

    /* JADX INFO: renamed from: androidx.datastore.preferences.protobuf.MessageSchema$1 */
    static /* synthetic */ class C04671 {
        static readonly /* synthetic */ int[] $SwitchDictionary$com$google$protobuf$WireFormat$FieldType = null;

        static {
                goto L18
            L4:
                int r0 = r0 % r1
                goto L117
            La:
                r0 = 29
                goto L11
            L11:
                r1 = 5
                goto L24
            L18:
                goto L110
            L1b:
                goto La
            L1f:
                int r0 = r0.length
                goto L107
            L24:
                int r0 = r0 + r1
                goto L4
            L2a:
                return
            L2b:
                goto L10d
            L2f:
                goto L2b
            L32:
                goto Lff
            L36:
                androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType = r0
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.BOOL     // Catch: java.lang.NoSuchFieldError -> L41
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L41
                r2 = 1
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L41
            L41:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L4c
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.BYTES     // Catch: java.lang.NoSuchFieldError -> L4c
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L4c
                r2 = 2
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L4c
            L4c:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L57
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.DOUBLE     // Catch: java.lang.NoSuchFieldError -> L57
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L57
                r2 = 3
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L57
            L57:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L62
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FIXED32     // Catch: java.lang.NoSuchFieldError -> L62
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L62
                r2 = 4
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L62
            L62:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L6d
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SFIXED32     // Catch: java.lang.NoSuchFieldError -> L6d
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L6d
                r2 = 5
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L6d
            L6d:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L78
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FIXED64     // Catch: java.lang.NoSuchFieldError -> L78
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L78
                r2 = 6
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L78
            L78:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L83
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SFIXED64     // Catch: java.lang.NoSuchFieldError -> L83
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L83
                r2 = 7
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L83
            L83:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L8f
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.FLOAT     // Catch: java.lang.NoSuchFieldError -> L8f
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L8f
                r2 = 8
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L8f
            L8f:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> L9b
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.ENUM     // Catch: java.lang.NoSuchFieldError -> L9b
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> L9b
                r2 = 9
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> L9b
            L9b:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> La7
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.INT32     // Catch: java.lang.NoSuchFieldError -> La7
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> La7
                r2 = 10
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> La7
            La7:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lb3
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.UINT32     // Catch: java.lang.NoSuchFieldError -> Lb3
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Lb3
                r2 = 11
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lb3
            Lb3:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lbf
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.INT64     // Catch: java.lang.NoSuchFieldError -> Lbf
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Lbf
                r2 = 12
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lbf
            Lbf:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lcb
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.UINT64     // Catch: java.lang.NoSuchFieldError -> Lcb
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Lcb
                r2 = 13
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lcb
            Lcb:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Ld7
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.MESSAGE     // Catch: java.lang.NoSuchFieldError -> Ld7
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Ld7
                r2 = 14
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Ld7
            Ld7:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Le3
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SINT32     // Catch: java.lang.NoSuchFieldError -> Le3
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Le3
                r2 = 15
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Le3
            Le3:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lef
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.SINT64     // Catch: java.lang.NoSuchFieldError -> Lef
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Lef
                r2 = 16
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lef
            Lef:
                int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType     // Catch: java.lang.NoSuchFieldError -> Lfb
                androidx.datastore.preferences.protobuf.WireFormat$FieldType r1 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.STRING     // Catch: java.lang.NoSuchFieldError -> Lfb
                int r1 = r1.ordinal()     // Catch: java.lang.NoSuchFieldError -> Lfb
                r2 = 17
                r0[r1] = r2     // Catch: java.lang.NoSuchFieldError -> Lfb
            Lfb:
                goto L2a
            Lff:
                androidx.datastore.preferences.protobuf.WireFormat$FieldType[] r0 = androidx.datastore.preferences.protobuf.WireFormat.FieldType.Values
                goto L1f
            L107:
                int[] r0 = new int[r0]
                goto L36
            L10d:
                goto L32
            L110:
                goto L114
            L114:
                goto L1b
            L117:
                if (r0 <= 0) goto L11c
                goto L32
            L11c:
                goto L2f
        }
    }

    static {
            goto L15
        L4:
            int[] r0 = new int[r0]
            goto La
        La:
            androidx.datastore.preferences.protobuf.MessageSchema.EMPTY_INT_ARRAY = r0
            goto L2a
        L10:
            r0 = 0
            goto L4
        L15:
            goto L20
        L18:
            goto L10
        L1c:
            goto L18
        L1f:
            return
        L20:
            goto L1c
        L24:
            androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE = r0
            goto L1f
        L2a:
            sun.misc.Unsafe r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getUnsafe()
            goto L24
    }

    private MessageSchema(int[] r1, java.lang.object[] r2, int r3, int r4, androidx.datastore.preferences.protobuf.MessageLite r5, androidx.datastore.preferences.protobuf.ProtoSyntax r6, bool r7, int[] r8, int r9, int r10, androidx.datastore.preferences.protobuf.NewInstanceSchema r11, androidx.datastore.preferences.protobuf.ListFieldSchema r12, androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r13, androidx.datastore.preferences.protobuf.ExtensionSchema<object> r14, androidx.datastore.preferences.protobuf.DictionaryFieldSchema r15) {
            r0 = this;
            goto L31
        L4:
            r0.syntax = r6
            goto L1d
        La:
            r1 = 0
        Lb:
            goto L49
        Lf:
            r0.useCachedSizeField = r7
            goto La2
        L15:
            bool r1 = r14.hasExtensions(r5)
            goto L5b
        L1d:
            if (r14 != 0) goto L22
            goto L27
        L22:
            goto L15
        L26:
            goto Lb
        L27:
            goto La
        L2b:
            r0.extensionSchema = r14
            goto L38
        L31:
            goto L45
        L34:
            goto L95
        L38:
            r0.defaultInstance = r5
            goto L84
        L3e:
            r0.lite = r1
            goto L4
        L44:
            return
        L45:
            goto L7b
        L49:
            r0.hasExtensions = r1
            goto Lf
        L4f:
            r0.objects = r2
            goto L69
        L55:
            bool r1 = r5 is androidx.datastore.preferences.protobuf.GeneratedMessageLite
            goto L3e
        L5b:
            if (r1 != 0) goto L60
            goto L27
        L60:
            goto L64
        L64:
            r1 = 1
            goto L26
        L69:
            r0.minFieldNumber = r3
            goto L6f
        L6f:
            r0.maxFieldNumber = r4
            goto L55
        L75:
            r0.mapFieldSchema = r1
            goto L44
        L7b:
            goto L34
        L7e:
            r0.newInstanceSchema = r11
            goto La8
        L84:
            r1 = r15
            goto L75
        L89:
            r0.buffer = r1
            goto L4f
        L8f:
            r0.repeatedFieldOffsetStart = r10
            goto L7e
        L95:
            r0.<init>()
            goto L89
        L9c:
            r0.unknownFieldSchema = r13
            goto L2b
        La2:
            r0.intArray = r8
            goto Lae
        La8:
            r0.listFieldSchema = r12
            goto L9c
        Lae:
            r0.checkInitializedCount = r9
            goto L8f
    }

    private bool ArePresentForEquals(T r1, T r2, int r3) {
            r0 = this;
            goto L2f
        L4:
            bool r1 = r0.isFieldPresent(r1, r3)
            goto Lc
        Lc:
            bool r0 = r0.isFieldPresent(r2, r3)
            goto L26
        L14:
            r0 = 1
            goto L1c
        L19:
            goto L32
        L1c:
            return r0
        L1d:
            goto L36
        L21:
            return r0
        L22:
            goto L19
        L26:
            if (r1 == r0) goto L2b
            goto L1d
        L2b:
            goto L14
        L2f:
            goto L22
        L32:
            goto L4
        L36:
            r0 = 0
            goto L21
    }

    private static <T> bool BoolAt(T r0, long r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r0, r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    private static void CheckMutable(java.lang.object r3) {
            goto L60
        L4:
            return
        L5:
            goto L4c
        L9:
            goto L86
        Lc:
            goto L1f
        L10:
            if (r0 <= 0) goto L15
            goto L86
        L15:
            goto L83
        L19:
            int r0 = r0 % r1
            goto L10
        L1f:
            goto L63
        L22:
            r0.<init>(r3)
            goto L3f
        L29:
            r1.<init>(r2)
            goto L52
        L30:
            java.lang.string r2 = "Mutating immutable message: "
            goto L29
        L36:
            if (r0 != 0) goto L3b
            goto L5
        L3b:
            goto L4
        L3f:
            throw r0
        L40:
            goto L9
        L44:
            bool r0 = isMutable(r3)
            goto L36
        L4c:
            java.lang.IllegalArgumentException r0 = new java.lang.IllegalArgumentException
            goto L7d
        L52:
            java.lang.stringBuilder r3 = r1.append(r3)
            goto L67
        L5a:
            int r0 = r0 + r1
            goto L19
        L60:
            goto Lc
        L63:
            goto L76
        L67:
            java.lang.string r3 = r3.tostring()
            goto L22
        L6f:
            r1 = 25
            goto L5a
        L76:
            r0 = 11
            goto L6f
        L7d:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L30
        L83:
            goto L40
        L86:
            goto L44
    }

    private <K, V> int DecodeDictionaryEntry(byte[] r11, int r12, int r13, androidx.datastore.preferences.protobuf.DictionaryEntryLite.Metadata<K, V> r14, java.util.Dictionary<K, V> r15, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r16) throws java.io.IOException {
            r10 = this;
            goto La2
        L4:
            goto L45
        L5:
            goto Lcf
        L9:
            if (r12 < r7) goto Le
            goto L5
        Le:
            goto L8b
        L12:
            if (r0 >= 0) goto L17
            goto L153
        L17:
            goto L188
        L1b:
            int r0 = r0.getWireType()
            goto L144
        L23:
            r0 = 10
            goto L7f
        L2a:
            goto L17e
        L2d:
            goto L182
        L31:
            if (r12 < 0) goto L36
            goto L104
        L36:
            goto L16b
        L3a:
            r5 = 0
            goto L178
        L3f:
            r3 = 1
            goto L113
        L44:
            r9 = r1
        L45:
            goto L9
        L49:
            V r1 = r14.defaultValue
            goto L18e
        L4f:
            r3 = 2
            goto Lf9
        L54:
            int r0 = r12 >>> 3
            goto Lc1
        L5a:
            r1 = r11
            goto Ld8
        L5f:
            r12 = r11[r12]
            goto L31
        L65:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r4 = r14.keyType
            goto L3a
        L6b:
            goto L140
        L6d:
            goto L11c
        L71:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r14.keyType
            goto L91
        L77:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r10 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.truncatedMessage()
            goto L17d
        L7f:
            r1 = 4
            goto Lf3
        L86:
            goto L45
        L87:
            goto L71
        L8b:
            int r0 = r12 + 1
            goto L5f
        L91:
            int r0 = r0.getWireType()
            goto L127
        L99:
            if (r0 <= 0) goto L9e
            goto L2d
        L9e:
            goto L2a
        La2:
            goto L196
        La5:
            goto L23
        La9:
            goto La5
        Lac:
            if (r0 <= r1) goto Lb1
            goto L153
        Lb1:
            goto L1a0
        Lb5:
            r0 = r10
            goto L5a
        Lba:
            r15.Add(r8, r9)
            goto L14d
        Lc1:
            r1 = r12 & 7
            goto L3f
        Lc7:
            int r12 = r0.decodeDictionaryEntryValue(r1, r2, r3, r4, r5, r6)
            goto L130
        Lcf:
            if (r12 == r7) goto Ld4
            goto L14e
        Ld4:
            goto Lba
        Ld8:
            r3 = r13
            goto L136
        Ldd:
            int r12 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r11, r12, r6)
            goto L19a
        Le5:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r10 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure()
            goto L152
        Led:
            java.lang.object r9 = r6.object1
            goto L86
        Lf3:
            int r0 = r0 + r1
            goto L15f
        Lf9:
            if (r0 != r3) goto Lfe
            goto L6d
        Lfe:
            goto L6b
        L102:
            int r12 = r6.int1
        L104:
            goto L122
        L108:
            K r0 = r14.defaultKey
            goto L49
        L10e:
            r3 = r13
            goto Lc7
        L113:
            if (r0 != r3) goto L118
            goto L87
        L118:
            goto L4f
        L11c:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r0 = r14.valueType
            goto L1b
        L122:
            r2 = r0
            goto L54
        L127:
            if (r1 == r0) goto L12c
            goto L140
        L12c:
            goto L65
        L130:
            java.lang.object r8 = r6.object1
            goto L13e
        L136:
            int r12 = r0.decodeDictionaryEntryValue(r1, r2, r3, r4, r5, r6)
            goto Led
        L13e:
            goto L45
        L140:
            goto L157
        L144:
            if (r1 == r0) goto L149
            goto L140
        L149:
            goto L165
        L14d:
            return r7
        L14e:
            goto Le5
        L152:
            throw r10
        L153:
            goto L77
        L157:
            int r12 = androidx.datastore.preferences.protobuf.ArrayDecoders.skipField(r12, r11, r2, r13, r6)
            goto L4
        L15f:
            int r0 = r0 % r1
            goto L99
        L165:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r4 = r14.valueType
            goto L1a6
        L16b:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r12, r11, r0, r6)
            goto L102
        L173:
            r1 = r11
            goto L10e
        L178:
            r0 = r10
            goto L173
        L17d:
            throw r10
        L17e:
            goto L193
        L182:
            r6 = r16
            goto Ldd
        L188:
            int r1 = r13 - r12
            goto Lac
        L18e:
            r8 = r0
            goto L44
        L193:
            goto L2d
        L196:
            goto La9
        L19a:
            int r0 = r6.int1
            goto L12
        L1a0:
            int r7 = r12 + r0
            goto L108
        L1a6:
            V r12 = r14.defaultValue
            goto L1ac
        L1ac:
            java.lang.Class r5 = r12.GetType()
            goto Lb5
    }

    private int DecodeDictionaryEntryValue(byte[] r1, int r2, int r3, androidx.datastore.preferences.protobuf.WireFormat.FieldType r4, java.lang.Class<object> r5, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r6) throws java.io.IOException {
            r0 = this;
            goto Le4
        L4:
            androidx.datastore.preferences.protobuf.Protobuf r0 = androidx.datastore.preferences.protobuf.Protobuf.getInstance()
            goto L1de
        Lc:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r1, r2, r6)
            goto L180
        L14:
            int r2 = r2 + 4
            goto L70
        L1a:
            java.lang.int r1 = java.lang.int.valueOf(r1)
            goto L116
        L22:
            r6.object1 = r0
            goto Lc3
        L28:
            java.lang.bool r1 = java.lang.bool.valueOf(r1)
            goto Lb0
        L30:
            return r0
        L31:
            goto L164
        L35:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r1, r2, r6)
            goto L1ec
        L3d:
            java.lang.double r0 = java.lang.double.valueOf(r0)
            goto L81
        L45:
            return r0
        L6c:
            goto Lf0
        L70:
            return r2
        L71:
            goto L100
        L75:
            int r1 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto L11c
        L7b:
            r6.object1 = r0
            goto L18b
        L81:
            r6.object1 = r0
            goto L87
        L87:
            int r2 = r2 + 8
            goto L143
        L8d:
            java.lang.int r1 = java.lang.int.valueOf(r1)
            goto L16c
        L95:
            r3 = 0
            goto L75
        L9b:
            r0.<init>(r1)
            goto Ld7
        La2:
            return r0
        La3:
            goto L125
        La7:
            r0 = r0[r4]
            switch(r0) {
                case 1: goto L187;
                case 2: goto L144;
                case 3: goto L71;
                case 4: goto L1a8;
                case 5: goto L1a8;
                case 6: goto L13f;
                case 7: goto L13f;
                case 8: goto La3;
                case 9: goto L151;
                case 10: goto L151;
                case 11: goto L151;
                case 12: goto L1d2;
                case 13: goto L1d2;
                case 14: goto Lfc;
                case 15: goto L1b5;
                case 16: goto L31;
                case 17: goto Ld8;
                default: goto Lac;
            }
        Lac:
            goto L1a1
        Lb0:
            r6.object1 = r1
            goto L45
        Lb6:
            int r1 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
            goto L1a
        Lbe:
            goto L134
        Lbf:
            goto L133
        Lc3:
            int r2 = r2 + 8
            goto L1a7
        Lc9:
            java.lang.long r1 = java.lang.long.valueOf(r1)
            goto L12d
        Ld1:
            long r1 = r6.long1
            goto L95
        Ld7:
            throw r0
        Ld8:
            goto L199
        Ldc:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r1, r2, r6)
            goto L108
        Le4:
            goto L6c
        Le7:
            goto L138
        Leb:
            r1 = 1
            goto Lbe
        Lf0:
            goto Le7
        Lf3:
            java.lang.float r0 = java.lang.float.valueOf(r0)
            goto L7b
        Lfb:
            return r0
        Lfc:
            goto L4
        L100:
            double r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodedouble(r1, r2)
            goto L3d
        L108:
            int r1 = r6.int1
            goto L8d
        L10e:
            long r1 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r1)
            goto L1ac
        L116:
            r6.object1 = r1
            goto Lfb
        L11c:
            if (r1 != 0) goto L121
            goto Lbf
        L121:
            goto Leb
        L125:
            float r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodefloat(r1, r2)
            goto Lf3
        L12d:
            r6.object1 = r1
            goto L150
        L133:
            r1 = 0
        L134:
            goto L28
        L138:
            int[] r0 = androidx.datastore.preferences.protobuf.MessageSchema.C04671.$SwitchDictionary$com$google$protobuf$WireFormat$FieldType
            goto L1c1
        L13e:
            return r2
        L13f:
            goto L1b9
        L143:
            return r2
        L144:
            goto L1d6
        L148:
            java.lang.int r0 = java.lang.int.valueOf(r0)
            goto L17a
        L150:
            return r0
        L151:
            goto Ldc
        L155:
            java.lang.string r1 = "unsupported field type."
            goto L9b
        L15c:
            java.lang.long r0 = java.lang.long.valueOf(r0)
            goto L22
        L164:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r1, r2, r6)
            goto L1e6
        L16c:
            r6.object1 = r1
            goto La2
        L172:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed32(r1, r2)
            goto L148
        L17a:
            r6.object1 = r0
            goto L14
        L180:
            long r1 = r6.long1
            goto Lc9
        L186:
            return r0
        L187:
            goto L191
        L18b:
            int r2 = r2 + 4
            goto L13e
        L191:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r1, r2, r6)
            goto Ld1
        L199:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodestringRequireUtf8(r1, r2, r6)
            goto L30
        L1a1:
            java.lang.Exception r0 = new java.lang.Exception
            goto L155
        L1a7:
            return r2
        L1a8:
            goto L172
        L1ac:
            java.lang.long r1 = java.lang.long.valueOf(r1)
            goto L1f2
        L1b4:
            return r0
        L1b5:
            goto L35
        L1b9:
            long r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed64(r1, r2)
            goto L15c
        L1c1:
            int r4 = r4.ordinal()
            goto La7
        L1c9:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeMessageField(r0, r1, r2, r3, r6)
            goto L1d1
        L1d1:
            return r0
        L1d2:
            goto Lc
        L1d6:
            int r0 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodebytes(r1, r2, r6)
            goto L186
        L1de:
            androidx.datastore.preferences.protobuf.Schema r0 = r0.schemaFor(r5)
            goto L1c9
        L1e6:
            long r1 = r6.long1
            goto L10e
        L1ec:
            int r1 = r6.int1
            goto Lb6
        L1f2:
            r6.object1 = r1
            goto L1b4
    }

    private static <T> double DoubleAt(T r0, long r1) {
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
            double r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r0, r1)
            goto Lb
    }

    private bool Equals(T r6, T r7, int r8) {
            r5 = this;
            goto L10b
        L4:
            return r3
        L5:
            goto L443
        L9:
            if (r5 != 0) goto Le
            goto L65
        Le:
            goto L425
        L12:
            if (r5 != 0) goto L17
            goto L42e
        L17:
            goto L69
        L1b:
            r0 = 4
            goto L131
        L22:
            if (r5 != 0) goto L27
            goto L19d
        L27:
            goto L19c
        L2b:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto L71
        L33:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L3fe
        L3b:
            if (r5 != 0) goto L40
            goto L575
        L40:
            goto L112
        L44:
            return r3
        L45:
            goto L32c
        L49:
            if (r5 != 0) goto L4e
            goto L19d
        L4e:
            goto L512
        L52:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto Lc0
        L5a:
            return r3
        L5b:
            goto L234
        L5f:
            return r4
        L60:
            goto L398
        L64:
            return r4
        L65:
            goto L2a6
        L69:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L16e
        L71:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L474
        L79:
            if (r5 == 0) goto L7e
            goto L28c
        L7e:
            goto L28b
        L82:
            if (r5 != 0) goto L87
            goto La9
        L87:
            goto La8
        L8b:
            long r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L2bc
        L93:
            return r3
        L94:
            goto L14f
        L98:
            bool r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r6, r1)
            goto L554
        La0:
            long r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L388
        La8:
            return r4
        La9:
            goto L2d3
        Lad:
            if (r5 != 0) goto Lb2
            goto L139
        Lb2:
            goto L283
        Lb6:
            return r3
        Lb7:
            goto L356
        Lbb:
            return r4
        Lbc:
            goto L1a1
        Lc0:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L4b9
        Lc8:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L12
        Ld0:
            int r0 = r0 + r1
            goto Lf6
        Ld6:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L459
        Lde:
            long r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r6, r1)
            goto La0
        Le6:
            return r4
        Le7:
            goto L245
        Leb:
            return r4
        Lec:
            goto L142
        Lf0:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L51a
        Lf6:
            int r0 = r0 % r1
            goto L23c
        Lfc:
            r3 = 0
            goto L490
        L101:
            return r4
        L102:
            goto L24a
        L106:
            return r3
        L107:
            goto L3d0
        L10b:
            goto L15a
        L10e:
            goto L1b
        L112:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto L4da
        L11a:
            if (r5 == 0) goto L11f
            goto L550
        L11f:
            goto L54f
        L123:
            return r4
        L124:
            goto L33c
        L128:
            if (r5 == 0) goto L12d
            goto Lbc
        L12d:
            goto Lbb
        L131:
            r1 = 11
            goto Ld0
        L138:
            return r4
        L139:
            goto L4
        L13d:
            return r4
        L13e:
            goto Lb6
        L142:
            return r3
        L143:
            goto L2cb
        L147:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L82
        L14f:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L3d8
        L157:
            goto L3ea
        L15a:
            goto L47d
        L15e:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L3b
        L166:
            long r5 = java.lang.double.doubleTolongBits(r5)
            goto L432
        L16e:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L2ab
        L176:
            double r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r6, r1)
            goto L166
        L17e:
            if (r5 != 0) goto L183
            goto L13e
        L183:
            goto L13d
        L187:
            long r1 = offset(r0)
            goto L480
        L18f:
            return r3
        L190:
            goto L56c
        L194:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L4ca
        L19c:
            return r4
        L19d:
            goto L18f
        L1a1:
            return r3
        L230:
            goto L157
        L234:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L2c2
        L23c:
            if (r0 <= 0) goto L241
            goto L3ea
        L241:
            goto L3e7
        L245:
            return r3
        L246:
            goto L535
        L24a:
            return r3
        L24b:
            goto L317
        L24f:
            return r4
        L250:
            goto L46a
        L254:
            long r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L3e1
        L25c:
            return r4
        L25d:
            goto L93
        L261:
            if (r5 != 0) goto L266
            goto La9
        L266:
            goto L414
        L26a:
            long r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r6, r1)
            goto L8b
        L272:
            if (r5 == 0) goto L277
            goto L44c
        L277:
            goto L44b
        L27b:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L2b3
        L283:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto L34e
        L28b:
            return r4
        L28c:
            goto L106
        L290:
            if (r5 != 0) goto L295
            goto L42e
        L295:
            goto L42d
        L299:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L3c7
        L2a1:
            return r3
        L2a2:
            goto L377
        L2a6:
            return r3
        L2a7:
            goto L15e
        L2ab:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L290
        L2b3:
            if (r5 != 0) goto L2b8
            goto L34a
        L2b8:
            goto L349
        L2bc:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L11a
        L2c2:
            if (r5 != 0) goto L2c7
            goto L28c
        L2c7:
            goto L3ae
        L2cb:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L523
        L2d3:
            return r3
        L2d4:
            goto L4b1
        L2d8:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L128
        L2de:
            int r0 = r5.typeAndOffsetAt(r8)
            goto L187
        L2e6:
            int r6 = java.lang.float.floatToIntBits(r6)
            goto L52c
        L2ee:
            long r7 = java.lang.double.doubleTolongBits(r7)
            goto L2d8
        L2f6:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto Ld6
        L2fe:
            int r5 = java.lang.float.floatToIntBits(r5)
            goto L3bf
        L306:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L37f
        L30e:
            if (r5 == r6) goto L313
            goto L139
        L313:
            goto L138
        L317:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L3b6
        L31f:
            long r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto Lf0
        L327:
            return r3
        L328:
            goto L4a9
        L32c:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L9
        L334:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L3f6
        L33c:
            bool r5 = r5.isOneofCaseEqual(r6, r7, r8)
            goto L49
        L344:
            return r5
        L345:
            goto L4f8
        L349:
            return r4
        L34a:
            goto L44
        L34e:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L30e
        L356:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L509
        L35e:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto L488
        L366:
            if (r5 != 0) goto L36b
            goto L60
        L36b:
            goto L35e
        L36f:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L17e
        L377:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L41c
        L37f:
            if (r5 != 0) goto L384
            goto L44c
        L384:
            goto Lde
        L388:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L272
        L38e:
            return r5
        L38f:
            goto L52
        L393:
            return r4
        L394:
            goto L407
        L398:
            return r3
        L399:
            goto Lc8
        L39d:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L55c
        L3a5:
            if (r5 != 0) goto L3aa
            goto L34a
        L3aa:
            goto L194
        L3ae:
            long r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r6, r1)
            goto L40c
        L3b6:
            if (r5 != 0) goto L3bb
            goto L250
        L3bb:
            goto L462
        L3bf:
            float r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r7, r1)
            goto L2e6
        L3c7:
            if (r5 != 0) goto L3cc
            goto Lec
        L3cc:
            goto L498
        L3d0:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L4a0
        L3d8:
            if (r5 != 0) goto L3dd
            goto L102
        L3dd:
            goto L2b
        L3e1:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L4c1
        L3e7:
            goto L230
        L3ea:
            goto L2de
        L3ee:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L22
        L3f6:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L38e
        L3fe:
            if (r5 == r6) goto L403
            goto Lec
        L403:
            goto Leb
        L407:
            return r3
        L408:
            goto L4f0
        L40c:
            long r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L4e2
        L414:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L4d2
        L41c:
            if (r5 != 0) goto L421
            goto Le7
        L421:
            goto L2f6
        L425:
            long r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r6, r1)
            goto L31f
        L42d:
            return r4
        L42e:
            goto L327
        L432:
            double r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r7, r1)
            goto L2ee
        L43a:
            if (r5 == r6) goto L43f
            goto L25d
        L43f:
            goto L25c
        L443:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L366
        L44b:
            return r4
        L44c:
            goto L2a1
        L450:
            if (r5 == r6) goto L455
            goto L575
        L455:
            goto L574
        L459:
            if (r5 == r6) goto L45e
            goto Le7
        L45e:
            goto Le6
        L462:
            long r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r6, r1)
            goto L254
        L46a:
            return r3
        L46b:
            goto L299
        L46f:
            return r3
        L470:
            goto L306
        L474:
            if (r5 == r6) goto L479
            goto L102
        L479:
            goto L101
        L47d:
            goto L10e
        L480:
            int r0 = type(r0)
            goto Lfc
        L488:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L53d
        L490:
            r4 = 1
            switch(r0) {
                case 0: goto L408;
                case 1: goto L107;
                case 2: goto L5b;
                case 3: goto L143;
                case 4: goto L46b;
                case 5: goto L24b;
                case 6: goto L94;
                case 7: goto Lb7;
                case 8: goto L2d4;
                case 9: goto L328;
                case 10: goto L399;
                case 11: goto L5;
                case 12: goto L246;
                case 13: goto L2a2;
                case 14: goto L470;
                case 15: goto L2a7;
                case 16: goto L45;
                case 17: goto L345;
                case 18: goto L38f;
                case 19: goto L38f;
                case 20: goto L38f;
                case 21: goto L38f;
                case 22: goto L38f;
                case 23: goto L38f;
                case 24: goto L38f;
                case 25: goto L38f;
                case 26: goto L38f;
                case 27: goto L38f;
                case 28: goto L38f;
                case 29: goto L38f;
                case 30: goto L38f;
                case 31: goto L38f;
                case 32: goto L38f;
                case 33: goto L38f;
                case 34: goto L38f;
                case 35: goto L38f;
                case 36: goto L38f;
                case 37: goto L38f;
                case 38: goto L38f;
                case 39: goto L38f;
                case 40: goto L38f;
                case 41: goto L38f;
                case 42: goto L38f;
                case 43: goto L38f;
                case 44: goto L38f;
                case 45: goto L38f;
                case 46: goto L38f;
                case 47: goto L38f;
                case 48: goto L38f;
                case 49: goto L38f;
                case 50: goto L190;
                case 51: goto L124;
                case 52: goto L124;
                case 53: goto L124;
                case 54: goto L124;
                case 55: goto L124;
                case 56: goto L124;
                case 57: goto L124;
                case 58: goto L124;
                case 59: goto L124;
                case 60: goto L124;
                case 61: goto L124;
                case 62: goto L124;
                case 63: goto L124;
                case 64: goto L124;
                case 65: goto L124;
                case 66: goto L124;
                case 67: goto L124;
                case 68: goto L124;
                default: goto L494;
            }
        L494:
            goto L123
        L498:
            int r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r6, r1)
            goto L33
        L4a0:
            if (r5 != 0) goto L4a5
            goto L394
        L4a5:
            goto L4e8
        L4a9:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L261
        L4b1:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L500
        L4b9:
            bool r5 = androidx.datastore.preferences.protobuf.SchemaUtil.safeEquals(r5, r6)
            goto L344
        L4c1:
            if (r5 == 0) goto L4c6
            goto L250
        L4c6:
            goto L24f
        L4ca:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L27b
        L4d2:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L147
        L4da:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L450
        L4e2:
            int r5 = (r5 > r7 ? 1 : (r5 == r7 ? 0 : -1))
            goto L79
        L4e8:
            float r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r6, r1)
            goto L2fe
        L4f0:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L546
        L4f8:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto L3a5
        L500:
            if (r5 != 0) goto L505
            goto L13e
        L505:
            goto L39d
        L509:
            if (r5 != 0) goto L50e
            goto L25d
        L50e:
            goto L98
        L512:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L564
        L51a:
            if (r5 == 0) goto L51f
            goto L65
        L51f:
            goto L64
        L523:
            if (r5 != 0) goto L528
            goto L550
        L528:
            goto L26a
        L52c:
            if (r5 == r6) goto L531
            goto L394
        L531:
            goto L393
        L535:
            bool r5 = r5.arePresentForEquals(r6, r7, r8)
            goto Lad
        L53d:
            if (r5 == r6) goto L542
            goto L60
        L542:
            goto L5f
        L546:
            if (r5 != 0) goto L54b
            goto Lbc
        L54b:
            goto L176
        L54f:
            return r4
        L550:
            goto L5a
        L554:
            bool r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r7, r1)
            goto L43a
        L55c:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L36f
        L564:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L3ee
        L56c:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r6, r1)
            goto L334
        L574:
            return r4
        L575:
            goto L46f
    }

    private <UT, UB> UB FilterDictionaryUnknownEnumValues(java.lang.object r9, int r10, UB r11, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> r12, java.lang.object r13) {
            r8 = this;
            goto L1c
        L4:
            r0 = r8
            goto Lb2
        L9:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r4 = r8.getEnumFieldVerifier(r10)
            goto L42
        L11:
            r6 = r12
            goto L30
        L16:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r0 = r8.mapFieldSchema
            goto L7d
        L1c:
            goto L5a
        L1f:
            goto L9c
        L23:
            long r0 = offset(r0)
            goto L3a
        L2b:
            return r8
        L2c:
            goto L57
        L30:
            r7 = r13
            goto L63
        L35:
            return r11
        L36:
            goto L16
        L3a:
            java.lang.object r9 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r0)
            goto L4b
        L42:
            if (r4 == 0) goto L47
            goto L36
        L47:
            goto L35
        L4b:
            if (r9 == 0) goto L50
            goto L5f
        L50:
            goto L5e
        L54:
            goto L1f
        L57:
            goto L6e
        L5a:
            goto L54
        L5e:
            goto L47
        L5f:
            goto L9
        L63:
            java.lang.object r8 = r0.filterUnknownEnumDictionary(r1, r2, r3, r4, r5, r6, r7)
            goto L2b
        L6b:
            goto L2c
        L6e:
            goto L8e
        L72:
            int r0 = r0 + r1
            goto L96
        L78:
            r5 = r11
            goto L11
        L7d:
            java.util.Dictionary r3 = r0.forMutableDictionaryData(r9)
            goto L4
        L85:
            if (r0 <= 0) goto L8a
            goto L6e
        L8a:
            goto L6b
        L8e:
            int r2 = r8.numberAt(r10)
            goto Laa
        L96:
            int r0 = r0 % r1
            goto L85
        L9c:
            r0 = 27
            goto La3
        La3:
            r1 = 15
            goto L72
        Laa:
            int r0 = r8.typeAndOffsetAt(r10)
            goto L23
        Lb2:
            r1 = r10
            goto L78
    }

    private <K, V, UT, UB> UB FilterUnknownEnumDictionary(int r4, int r5, java.util.Dictionary<K, V> r6, androidx.datastore.preferences.protobuf.Internal.EnumVerifier r7, UB r8, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> r9, java.lang.object r10) {
            r3 = this;
            goto L105
        L4:
            java.lang.object r8 = r9.getBuilderFromMessage(r10)
        L8:
            goto Lee
        Lc:
            r0 = 20
            goto La9
        L13:
            java.lang.object r3 = r3.getDictionaryFieldDefaultEntry(r4)
            goto L3c
        L1b:
            androidx.datastore.preferences.protobuf.bytestring$CodedBuilder r0 = androidx.datastore.preferences.protobuf.bytestring.newCodedBuilder(r0)
            goto L23
        L23:
            androidx.datastore.preferences.protobuf.CodedStream r1 = r0.getCodedOutput()
            java.lang.object r2 = r6.getKey()     // Catch: java.io.IOException -> L51
            java.lang.object r6 = r6.getValue()     // Catch: java.io.IOException -> L51
            androidx.datastore.preferences.protobuf.DictionaryEntryLite.writeTo(r1, r3, r2, r6)     // Catch: java.io.IOException -> L51
            goto L72
        L36:
            int r0 = r0 % r1
            goto Ld5
        L3c:
            androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata r3 = r0.forDictionaryMetadata(r3)
            goto Lb6
        L44:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r0 = r3.mapFieldSchema
            goto L13
        L4a:
            throw r4
        L4b:
            goto Ld0
        L4f:
            goto Le2
        L51:
            r3 = move-exception
            goto Lff
        L56:
            r4.Remove()
            goto L4f
        L5d:
            int r0 = r0 + r1
            goto L36
        L63:
            bool r0 = r7.isInRange(r0)
            goto Lf6
        L6b:
            r4.<init>(r3)
            goto L4a
        L72:
            androidx.datastore.preferences.protobuf.bytestring r6 = r0.build()
            goto L8a
        L7a:
            int r0 = androidx.datastore.preferences.protobuf.DictionaryEntryLite.computeSerializedSize(r3, r0, r1)
            goto L1b
        L82:
            java.lang.object r1 = r6.getValue()
            goto L7a
        L8a:
            r9.addLengthDelimited(r8, r5, r6)
            goto L56
        L91:
            if (r6 != 0) goto L96
            goto L4b
        L96:
            goto Le6
        L9a:
            java.lang.object r0 = r6.getValue()
            goto L115
        La2:
            goto Ld1
        La5:
            goto L44
        La9:
            r1 = 28
            goto L5d
        Lb0:
            java.util.Dictionary$Entry r6 = (java.util.Dictionary.Entry) r6
            goto L9a
        Lb6:
            java.util.HashSet r4 = r6.entryHashSet()
            goto Lde
        Lbe:
            goto L108
        Lc1:
            goto La5
        Lc4:
            goto Lbe
        Lc8:
            int r0 = r0.intValue()
            goto L63
        Ld0:
            return r8
        Ld1:
            goto Lc1
        Ld5:
            if (r0 <= 0) goto Lda
            goto La5
        Lda:
            goto La2
        Lde:
            java.util.IEnumerator r4 = r4.GetEnumerator()
        Le2:
            goto L11b
        Le6:
            java.lang.object r6 = r4.Current
            goto Lb0
        Lee:
            java.lang.object r0 = r6.getKey()
            goto L82
        Lf6:
            if (r0 == 0) goto Lfb
            goto Le2
        Lfb:
            goto L10c
        Lff:
            java.lang.Exception r4 = new java.lang.Exception
            goto L6b
        L105:
            goto Lc4
        L108:
            goto Lc
        L10c:
            if (r8 == 0) goto L111
            goto L8
        L111:
            goto L4
        L115:
            java.lang.int r0 = (java.lang.int) r0
            goto Lc8
        L11b:
            bool r6 = r4.MoveNext()
            goto L91
    }

    private static <T> float FloatAt(T r0, long r1) {
            goto Lf
        L4:
            float r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r0, r1)
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

    private androidx.datastore.preferences.protobuf.Internal.EnumVerifier GetEnumFieldVerifier(int r1) {
            r0 = this;
            goto L1f
        L4:
            goto L22
        L7:
            java.lang.object[] r0 = r0.objects
            goto Ld
        Ld:
            int r1 = r1 / 3
            goto L31
        L13:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r0 = (androidx.datastore.preferences.protobuf.Internal.EnumVerifier) r0
            goto L26
        L19:
            int r1 = r1 + 1
            goto L2b
        L1f:
            goto L27
        L22:
            goto L7
        L26:
            return r0
        L27:
            goto L4
        L2b:
            r0 = r0[r1]
            goto L13
        L31:
            int r1 = r1 * 2
            goto L19
    }

    using (int r1) {
            r0 = this;
            goto L24
        L4:
            java.lang.object[] r0 = r0.objects
            goto L19
        La:
            int r1 = r1 * 2
            goto L13
        L10:
            goto L27
        L13:
            r0 = r0[r1]
            goto L1f
        L19:
            int r1 = r1 / 3
            goto La
        L1f:
            return r0
        L20:
            goto L10
        L24:
            goto L20
        L27:
            goto L4
    }

    private androidx.datastore.preferences.protobuf.Schema GetMessageFieldSchema(int r4) {
            r3 = this;
            goto L4
        L4:
            goto L22
        L7:
            goto L54
        Lb:
            androidx.datastore.preferences.protobuf.Schema r0 = r0.schemaFor(r1)
            goto L78
        L13:
            java.lang.object[] r1 = r3.objects
            goto L35
        L19:
            r0 = r0[r4]
            goto L8a
        L1f:
            goto L44
        L22:
            goto L2c
        L26:
            int r0 = r0 + r1
            goto L3b
        L2c:
            goto L7
        L2f:
            int r4 = r4 / 3
            goto L48
        L35:
            int r2 = r4 + 1
            goto L6c
        L3b:
            int r0 = r0 % r1
            goto L63
        L41:
            goto L97
        L44:
            goto L2f
        L48:
            int r4 = r4 * 2
            goto L72
        L4e:
            r3[r4] = r0
            goto L96
        L54:
            r0 = 11
            goto L83
        L5b:
            androidx.datastore.preferences.protobuf.Protobuf r0 = androidx.datastore.preferences.protobuf.Protobuf.getInstance()
            goto L13
        L63:
            if (r0 <= 0) goto L68
            goto L44
        L68:
            goto L41
        L6c:
            r1 = r1[r2]
            goto L90
        L72:
            java.lang.object[] r0 = r3.objects
            goto L19
        L78:
            java.lang.object[] r3 = r3.objects
            goto L4e
        L7e:
            return r0
        L7f:
            goto L5b
        L83:
            r1 = 6
            goto L26
        L8a:
            androidx.datastore.preferences.protobuf.Schema r0 = (androidx.datastore.preferences.protobuf.Schema) r0
            goto L9b
        L90:
            java.lang.Class r1 = (java.lang.Class) r1
            goto Lb
        L96:
            return r0
        L97:
            goto L1f
        L9b:
            if (r0 != 0) goto La0
            goto L7f
        La0:
            goto L7e
    }

    static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite GetMutableUnknownFields(java.lang.object r2) {
            goto L59
        L4:
            if (r0 == r1) goto L9
            goto L4f
        L9:
            goto L18
        Ld:
            int r0 = r0 + r1
            goto L41
        L13:
            return r0
        L14:
            goto L20
        L18:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0 = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.newInstance()
            goto L4d
        L20:
            goto L63
        L23:
            goto L2e
        L27:
            r1 = 20
            goto Ld
        L2e:
            goto L5c
        L31:
            r0 = 9
            goto L27
        L38:
            if (r0 <= 0) goto L3d
            goto L63
        L3d:
            goto L60
        L41:
            int r0 = r0 % r1
            goto L38
        L47:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r0 = r2.unknownFields
            goto L67
        L4d:
            r2.unknownFields = r0
        L4f:
            goto L13
        L53:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite r2 = (androidx.datastore.preferences.protobuf.GeneratedMessageLite) r2
            goto L47
        L59:
            goto L23
        L5c:
            goto L31
        L60:
            goto L14
        L63:
            goto L53
        L67:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r1 = androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite.getDefaultInstance()
            goto L4
    }

    private <UT, UB> int GetUnknownFieldsSerializedSize(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> r1, T r2) {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.getFromMessage(r2)
            goto L1b
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
        L1b:
            int r0 = r1.getSerializedSize(r0)
            goto L13
    }

    private static <T> int IntAt(T r0, long r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r0, r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    private static bool IsEnforceUtf8(int r1) {
            goto L2f
        L4:
            return r1
        L5:
            goto L1c
        L9:
            if (r1 != 0) goto Le
            goto L5
        Le:
            goto L24
        L12:
            return r1
        L13:
            goto L21
        L17:
            r1 = r1 & r0
            goto L9
        L1c:
            r1 = 0
            goto L12
        L21:
            goto L32
        L24:
            r1 = 1
            goto L4
        L29:
            r0 = 536870912(0x20000000, float:1.0842022E-19)
            goto L17
        L2f:
            goto L13
        L32:
            goto L29
    }

    private bool IsFieldPresent(T r7, int r8) {
            r6 = this;
            goto L3e
        L4:
            long r1 = (long) r1
            goto Ld3
        L9:
            return r5
        La:
            goto L194
        Le:
            int r0 = r0 + r1
            goto L83
        L14:
            if (r7 != 0) goto L19
            goto L16c
        L19:
            goto L6b
        L1d:
            if (r6 != 0) goto L22
            goto L203
        L22:
            goto L202
        L26:
            return r5
        L27:
            goto Lb2
        L2b:
            if (r6 != 0) goto L30
            goto L10c
        L30:
            goto L10b
        L34:
            throw r6
        L35:
            goto L26a
        L39:
            return r5
        L3a:
            goto L12d
        L3e:
            goto L18a
        L41:
            goto La6
        L45:
            return r4
        L46:
            goto L31e
        L4a:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L62
        L50:
            return r4
        L51:
            goto L14c
        L55:
            return r5
        L56:
            goto L110
        L5a:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r0)
            goto L22c
        L62:
            if (r6 != 0) goto L67
            goto L278
        L67:
            goto L277
        L6b:
            java.lang.string r6 = (java.lang.string) r6
            goto L249
        L71:
            bool r6 = r6.Equals(r7)
            goto L319
        L79:
            return r4
        L7a:
            goto L309
        L7e:
            r1 = r1 & r0
            goto L4
        L83:
            int r0 = r0 % r1
            goto L33e
        L89:
            int r3 = (r1 > r3 ? 1 : (r1 == r3 ? 0 : -1))
            goto Le1
        L8f:
            return r4
        L90:
            goto L115
        L94:
            return r6
        L95:
            goto L284
        L99:
            long r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r0)
            goto L4a
        La1:
            r6 = r6 ^ r5
            goto L16b
        La6:
            r0 = 29
            goto Lda
        Lad:
            return r4
        Lae:
            goto L34f
        Lb2:
            return r4
        Lb3:
            goto L251
        Lb7:
            r6 = r6 & r7
            goto L1f1
        Lbc:
            return r6
        Lbd:
            goto Lcd
        Lc1:
            r6.<init>()
            goto L34
        Lc8:
            return r5
        Lc9:
            goto L182
        Lcd:
            java.lang.IllegalArgumentException r6 = new java.lang.IllegalArgumentException
            goto Lc1
        Ld3:
            r3 = 1048575(0xfffff, double:5.18065E-318)
            goto L89
        Lda:
            r1 = 15
            goto Le
        Le1:
            r4 = 0
            goto L331
        Le6:
            return r4
        Le7:
            goto L2c3
        Leb:
            if (r7 != 0) goto Lf0
            goto Lbd
        Lf0:
            goto L2bd
        Lf4:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L179
        Lfa:
            int r6 = type(r6)
            goto L159
        L102:
            if (r6 != 0) goto L107
            goto L20d
        L107:
            goto L20c
        L10b:
            return r5
        L10c:
            goto L45
        L110:
            return r4
        L111:
            goto L2d2
        L115:
            int r6 = r0 >>> 20
            goto L28c
        L11b:
            long r6 = java.lang.double.doubleToRawlongBits(r6)
            goto L2da
        L123:
            return r4
        L124:
            goto L99
        L128:
            return r5
        L129:
            goto L79
        L12d:
            return r4
        L12e:
            goto L235
        L132:
            int r6 = r6.typeAndOffsetAt(r8)
            goto L2e6
        L13a:
            return r4
        L13b:
            goto L301
        L13f:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r0)
            goto L326
        L147:
            return r5
        L148:
            goto L13a
        L14c:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L2c9
        L154:
            return r5
        L155:
            goto Le6
        L159:
            r2 = 0
            switch(r6) {
                case 0: goto Lb3;
                case 1: goto Lae;
                case 2: goto L124;
                case 3: goto L13b;
                case 4: goto L46;
                case 5: goto L111;
                case 6: goto L95;
                case 7: goto L35;
                case 8: goto L312;
                case 9: goto L2f8;
                case 10: goto Le7;
                case 11: goto L183;
                case 12: goto L51;
                case 13: goto L7a;
                case 14: goto L12e;
                case 15: goto L273;
                case 16: goto L1d4;
                case 17: goto L32d;
                default: goto L15e;
            }
        L15e:
            goto L18e
        L162:
            if (r6 != 0) goto L167
            goto L155
        L167:
            goto L154
        L16b:
            return r6
        L16c:
            goto L2e0
        L170:
            if (r6 != 0) goto L175
            goto L27
        L175:
            goto L26
        L179:
            if (r6 != 0) goto L17e
            goto L208
        L17e:
            goto L207
        L182:
            return r4
        L183:
            goto L336
        L187:
            goto L1e4
        L18a:
            goto L316
        L18e:
            java.lang.IllegalArgumentException r6 = new java.lang.IllegalArgumentException
            goto L292
        L194:
            return r4
        L1be:
            goto L187
        L1c2:
            long r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r0)
            goto Lf4
        L1ca:
            if (r6 != 0) goto L1cf
            goto L148
        L1cf:
            goto L147
        L1d3:
            return r4
        L1d4:
            goto L1c2
        L1d8:
            if (r6 != 0) goto L1dd
            goto L3a
        L1dd:
            goto L39
        L1e1:
            goto L1be
        L1e4:
            goto L2b5
        L1e8:
            if (r6 != 0) goto L1ed
            goto L56
        L1ed:
            goto L55
        L1f1:
            if (r6 != 0) goto L1f6
            goto La
        L1f6:
            goto L9
        L1fa:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L1d8
        L202:
            return r5
        L203:
            goto L123
        L207:
            return r5
        L208:
            goto L272
        L20c:
            return r5
        L20d:
            goto L50
        L211:
            return r5
        L212:
            goto L1d3
        L216:
            r6 = r6 ^ r5
            goto Lbc
        L21b:
            if (r6 != 0) goto L220
            goto L2fd
        L220:
            goto L2fc
        L224:
            bool r6 = r7.Equals(r6)
            goto L216
        L22c:
            if (r6 != 0) goto L231
            goto L212
        L231:
            goto L211
        L235:
            long r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r0)
            goto L243
        L23d:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L2b
        L243:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L29f
        L249:
            bool r6 = r6.Count == 0
            goto La1
        L251:
            double r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r7, r0)
            goto L11b
        L259:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto Lb7
        L261:
            if (r3 == 0) goto L266
            goto L90
        L266:
            goto L132
        L26a:
            bool r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r7, r0)
            goto L94
        L272:
            return r4
        L273:
            goto L1fa
        L277:
            return r5
        L278:
            goto Lad
        L27c:
            java.lang.object r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r0)
            goto L71
        L284:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L1e8
        L28c:
            int r6 = r5 << r6
            goto L259
        L292:
            r6.<init>()
            goto L32c
        L299:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L1d
        L29f:
            if (r6 != 0) goto L2a4
            goto L129
        L2a4:
            goto L128
        L2a8:
            return r5
        L2a9:
            goto L311
        L2ad:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r0)
            goto L2ee
        L2b5:
            int r0 = r6.presenceMaskAndOffsetAt(r8)
            goto L357
        L2bd:
            androidx.datastore.preferences.protobuf.bytestring r7 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto L224
        L2c3:
            androidx.datastore.preferences.protobuf.bytestring r6 = androidx.datastore.preferences.protobuf.bytestring.EMPTY
            goto L27c
        L2c9:
            if (r6 != 0) goto L2ce
            goto Lc9
        L2ce:
            goto Lc8
        L2d2:
            long r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r0)
            goto L23d
        L2da:
            int r6 = (r6 > r2 ? 1 : (r6 == r2 ? 0 : -1))
            goto L21b
        L2e0:
            bool r7 = r6 is androidx.datastore.preferences.protobuf.bytestring
            goto Leb
        L2e6:
            long r0 = offset(r6)
            goto Lfa
        L2ee:
            if (r6 != 0) goto L2f3
            goto L2a9
        L2f3:
            goto L2a8
        L2f7:
            return r6
        L2f8:
            goto L2ad
        L2fc:
            return r5
        L2fd:
            goto L8f
        L301:
            long r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r0)
            goto L299
        L309:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L102
        L311:
            return r4
        L312:
            goto L13f
        L316:
            goto L41
        L319:
            r6 = r6 ^ r5
            goto L2f7
        L31e:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L1ca
        L326:
            bool r7 = r6 is java.lang.string
            goto L14
        L32c:
            throw r6
        L32d:
            goto L5a
        L331:
            r5 = 1
            goto L261
        L336:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r0)
            goto L162
        L33e:
            if (r0 <= 0) goto L343
            goto L1e4
        L343:
            goto L1e1
        L347:
            int r6 = java.lang.float.floatToRawIntBits(r6)
            goto L170
        L34f:
            float r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r7, r0)
            goto L347
        L357:
            r1 = 1048575(0xfffff, float:1.469367E-39)
            goto L7e
    }

    private bool IsFieldPresent(T r2, int r3, int r4, int r5, int r6) {
            r1 = this;
            goto L24
        L4:
            return r1
        L5:
            goto L44
        L9:
            if (r4 == r0) goto Le
            goto L40
        Le:
            goto L15
        L12:
            goto L27
        L15:
            bool r1 = r1.isFieldPresent(r2, r3)
            goto L3f
        L1d:
            r0 = 1048575(0xfffff, float:1.469367E-39)
            goto L9
        L24:
            goto L4a
        L27:
            goto L1d
        L2b:
            if (r1 != 0) goto L30
            goto L5
        L30:
            goto L3a
        L34:
            r1 = r5 & r6
            goto L2b
        L3a:
            r1 = 1
            goto L4
        L3f:
            return r1
        L40:
            goto L34
        L44:
            r1 = 0
            goto L49
        L49:
            return r1
        L4a:
            goto L12
    }

    private static bool IsInitialized(java.lang.object r2, int r3, androidx.datastore.preferences.protobuf.Schema r4) {
            goto Lb
        L4:
            goto L2b
        L7:
            goto L59
        Lb:
            goto L7
        Le:
            goto L44
        L12:
            return r2
        L13:
            goto L4
        L17:
            bool r2 = r4.isInitialized(r2)
            goto L12
        L1f:
            if (r0 <= 0) goto L24
            goto L2b
        L24:
            goto L28
        L28:
            goto L13
        L2b:
            goto L51
        L2f:
            r1 = 21
            goto L4b
        L36:
            int r0 = r0 % r1
            goto L1f
        L3c:
            java.lang.object r2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r2, r0)
            goto L17
        L44:
            r0 = 29
            goto L2f
        L4b:
            int r0 = r0 + r1
            goto L36
        L51:
            long r0 = offset(r3)
            goto L3c
        L59:
            goto Le
    }

    private static bool IsLegacyEnumIsClosed(int r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            r1 = 1
            goto L1c
        Lc:
            goto L2c
        Lf:
            goto L30
        L13:
            if (r1 != 0) goto L18
            goto L1d
        L18:
            goto L7
        L1c:
            return r1
        L1d:
            goto L21
        L21:
            r1 = 0
            goto L2b
        L26:
            r1 = r1 & r0
            goto L13
        L2b:
            return r1
        L2c:
            goto L4
        L30:
            r0 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L26
    }

    private <N> bool IsListInitialized(java.lang.object r3, int r4, int r5) {
            r2 = this;
            goto Lb4
        L4:
            bool r4 = r3.Count == 0
            goto L52
        Lc:
            goto L8a
        Ld:
            goto L26
        L11:
            int r0 = r0 % r1
            goto L8e
        L17:
            goto L27
        L1a:
            goto L9c
        L1e:
            goto Lb7
        L21:
            return r4
        L22:
            goto L83
        L26:
            return r0
        L27:
            goto L65
        L2b:
            androidx.datastore.preferences.protobuf.Schema r2 = r2.getMessageFieldSchema(r5)
            goto L44
        L33:
            bool r1 = r2.isInitialized(r1)
            goto Lab
        L3b:
            if (r4 != 0) goto L40
            goto L98
        L40:
            goto L97
        L44:
            r4 = 0
            goto L89
        L49:
            if (r5 < r1) goto L4e
            goto Ld
        L4e:
            goto L74
        L52:
            r0 = 1
            goto L3b
        L57:
            java.util.List r3 = (java.util.List) r3
            goto L4
        L5d:
            int r1 = r3.Count
            goto L49
        L65:
            goto L1a
        L68:
            goto L1e
        L6c:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r3, r0)
            goto L57
        L74:
            java.lang.object r1 = r3[r5)
            goto L33
        L7c:
            r0 = 21
            goto La4
        L83:
            int r5 = r5 + 1
            goto Lc
        L89:
            r5 = r4
        L8a:
            goto L5d
        L8e:
            if (r0 <= 0) goto L93
            goto L1a
        L93:
            goto L17
        L97:
            return r0
        L98:
            goto L2b
        L9c:
            long r0 = offset(r4)
            goto L6c
        La4:
            r1 = 24
            goto Lbb
        Lab:
            if (r1 == 0) goto Lb0
            goto L22
        Lb0:
            goto L21
        Lb4:
            goto L68
        Lb7:
            goto L7c
        Lbb:
            int r0 = r0 + r1
            goto L11
    }

    private bool IsDictionaryInitialized(T r4, int r5, int r6) {
            r3 = this;
            goto L18
        L4:
            if (r4 == 0) goto L9
            goto L89
        L9:
            goto L110
        Ld:
            r4 = 0
        Le:
            goto L78
        L12:
            int r0 = r0 % r1
            goto L8d
        L18:
            goto L104
        L1b:
            goto L3f
        L1f:
            goto L1b
        L22:
            long r1 = offset(r5)
            goto Lb7
        L2a:
            return r3
        L2b:
            goto L5c
        L2f:
            r1 = 15
            goto Ldd
        L36:
            if (r5 != 0) goto L3b
            goto Le4
        L3b:
            goto Le3
        L3f:
            r0 = 24
            goto L2f
        L46:
            java.util.IEnumerator r3 = r3.GetEnumerator()
            goto Ld
        L4e:
            androidx.datastore.preferences.protobuf.WireFormat$FieldType r3 = r3.valueType
            goto L6a
        L54:
            java.lang.Class r6 = r5.GetType()
            goto L85
        L5c:
            return r0
        L5d:
            goto L101
        L61:
            if (r3 != r5) goto L66
            goto La0
        L66:
            goto L9f
        L6a:
            androidx.datastore.preferences.protobuf.WireFormat$JavaType r3 = r3.getJavaType()
            goto Lbf
        L72:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r0 = r3.mapFieldSchema
            goto L22
        L78:
            bool r5 = r3.MoveNext()
            goto Lf0
        L80:
            r0 = 1
            goto L36
        L85:
            androidx.datastore.preferences.protobuf.Schema r4 = r4.schemaFor(r6)
        L89:
            goto L108
        L8d:
            if (r0 <= 0) goto L92
            goto L11b
        L92:
            goto L118
        L96:
            if (r5 == 0) goto L9b
            goto Le
        L9b:
            goto Lb2
        L9f:
            return r0
        La0:
            goto Lf9
        La4:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r3 = r3.mapFieldSchema
            goto Le8
        Laa:
            java.lang.object r5 = r3.Current
            goto L4
        Lb2:
            r3 = 0
            goto L2a
        Lb7:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r4, r1)
            goto Lc5
        Lbf:
            androidx.datastore.preferences.protobuf.WireFormat$JavaType r5 = androidx.datastore.preferences.protobuf.WireFormat.JavaType.MESSAGE
            goto L61
        Lc5:
            java.util.Dictionary r4 = r0.forDictionaryData(r4)
            goto Ld5
        Lcd:
            java.lang.object r5 = r3.getDictionaryFieldDefaultEntry(r6)
            goto La4
        Ld5:
            bool r5 = r4.Count == 0
            goto L80
        Ldd:
            int r0 = r0 + r1
            goto L12
        Le3:
            return r0
        Le4:
            goto Lcd
        Le8:
            androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata r3 = r3.forDictionaryMetadata(r5)
            goto L4e
        Lf0:
            if (r5 != 0) goto Lf5
            goto L2b
        Lf5:
            goto Laa
        Lf9:
            java.util.ICollection r3 = r4.Values
            goto L46
        L101:
            goto L11b
        L104:
            goto L1f
        L108:
            bool r5 = r4.isInitialized(r5)
            goto L96
        L110:
            androidx.datastore.preferences.protobuf.Protobuf r4 = androidx.datastore.preferences.protobuf.Protobuf.getInstance()
            goto L54
        L118:
            goto L5d
        L11b:
            goto L72
    }

    private static bool IsMutable(java.lang.object r1) {
            goto L46
        L4:
            if (r1 == 0) goto L9
            goto Le
        L9:
            goto L24
        Ld:
            return r1
        Le:
            goto L3d
        L12:
            bool r1 = r1.isMutable()
            goto L1f
        L1a:
            r1 = 1
            goto L29
        L1f:
            return r1
        L20:
            goto L1a
        L24:
            r1 = 0
            goto Ld
        L29:
            return r1
        L2a:
            goto L43
        L2e:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite r1 = (androidx.datastore.preferences.protobuf.GeneratedMessageLite) r1
            goto L12
        L34:
            if (r0 != 0) goto L39
            goto L20
        L39:
            goto L2e
        L3d:
            bool r0 = r1 is androidx.datastore.preferences.protobuf.GeneratedMessageLite
            goto L34
        L43:
            goto L49
        L46:
            goto L2a
        L49:
            goto L4
    }

    private bool IsOneofCaseEqual(T r3, T r4, int r5) {
            r2 = this;
            goto L6b
        L4:
            r0 = 10
            goto L3a
        Lb:
            r2 = 1
            goto L19
        L10:
            if (r2 == r3) goto L15
            goto L1a
        L15:
            goto Lb
        L19:
            return r2
        L1a:
            goto L80
        L1e:
            r2 = r2 & r5
            goto L66
        L23:
            goto L6e
        L26:
            return r2
        L27:
            goto L33
        L2b:
            int r2 = r2.presenceMaskAndOffsetAt(r5)
            goto L72
        L33:
            goto L7c
        L36:
            goto L23
        L3a:
            r1 = 15
            goto L60
        L41:
            int r2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r3, r0)
            goto L52
        L49:
            if (r0 <= 0) goto L4e
            goto L7c
        L4e:
            goto L79
        L52:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r4, r0)
            goto L10
        L5a:
            int r0 = r0 % r1
            goto L49
        L60:
            int r0 = r0 + r1
            goto L5a
        L66:
            long r0 = (long) r2
            goto L41
        L6b:
            goto L36
        L6e:
            goto L4
        L72:
            r5 = 1048575(0xfffff, float:1.469367E-39)
            goto L1e
        L79:
            goto L27
        L7c:
            goto L2b
        L80:
            r2 = 0
            goto L26
    }

    private bool IsOneofPresent(T r3, int r4, int r5) {
            r2 = this;
            goto L5d
        L4:
            r0 = 8
            goto L76
        Lb:
            long r0 = (long) r2
            goto L33
        L10:
            goto L47
        L13:
            goto L1c
        L17:
            r2 = r2 & r5
            goto Lb
        L1c:
            goto L60
        L1f:
            return r2
        L20:
            goto L71
        L24:
            int r0 = r0 + r1
            goto L64
        L2a:
            if (r0 <= 0) goto L2f
            goto L47
        L2f:
            goto L44
        L33:
            int r2 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r3, r0)
            goto L3b
        L3b:
            if (r2 == r4) goto L40
            goto L20
        L40:
            goto L58
        L44:
            goto L4c
        L47:
            goto L50
        L4b:
            return r2
        L4c:
            goto L10
        L50:
            int r2 = r2.presenceMaskAndOffsetAt(r5)
            goto L6a
        L58:
            r2 = 1
            goto L1f
        L5d:
            goto L13
        L60:
            goto L4
        L64:
            int r0 = r0 % r1
            goto L2a
        L6a:
            r5 = 1048575(0xfffff, float:1.469367E-39)
            goto L17
        L71:
            r2 = 0
            goto L4b
        L76:
            r1 = 15
            goto L24
    }

    private static bool IsRequired(int r1) {
            goto L4
        L4:
            goto L28
        L7:
            goto L1c
        Lb:
            if (r1 != 0) goto L10
            goto L23
        L10:
            goto L14
        L14:
            r1 = 1
            goto L22
        L19:
            goto L7
        L1c:
            r0 = 268435456(0x10000000, float:2.524355E-29)
            goto L2c
        L22:
            return r1
        L23:
            goto L31
        L27:
            return r1
        L28:
            goto L19
        L2c:
            r1 = r1 & r0
            goto Lb
        L31:
            r1 = 0
            goto L27
    }

    private static <T> long LongAt(T r0, long r1) {
            goto L14
        L4:
            long r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r0, r1)
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

    private <UT, UB, ET : androidx.datastore.preferences.protobuf.FieldHashSet.FieldDescriptorLite<ET>> void mergeFromHelper(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> r18, androidx.datastore.preferences.protobuf.ExtensionSchema<ET> r19, T r20, androidx.datastore.preferences.protobuf.Reader r21, androidx.datastore.preferences.protobuf.ExtensionRegistryLite r22) throws java.io.IOException {
            r17 = this;
            goto L73d
        L4:
            if (r4 != 0) goto L9
            goto L4dc
        L9:
            goto L4d9
        Ld:
            goto L6fc
        L10:
            goto L56b
        L14:
            r2 = r5
            goto L9e8
        L19:
            r7 = r3
            goto L25a
        L1e:
            int r0 = r0 + 1
            goto L88d
        L24:
            if (r0 < r2) goto L29
            goto Lbff
        L29:
            goto L549
        L2d:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto Lc6d
        L35:
            r5 = r11
        L36:
            goto L9ab
        L3a:
            r10 = r18
            goto L7db
        L40:
            goto L477
        L42:
            r0 = move-exception
            goto L521
        L47:
            goto L439
        L49:
            goto L489
        L4d:
            goto Lb34
        L4f:
            goto Lb09
        L53:
            r3 = r7
            r1.readMessageList(r2, r3, r4, r5, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L59:
            r0 = move-exception
            r1 = r12
            goto Lc48
        L5d:
            r6 = r22
            r4 = r13
            r5 = r11
            r1 = r12
            goto L48f
        L64:
            r2 = r5
            r5 = r7
            r1.readstringList(r2, r5, r4)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L6b:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readBoolList(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L7c:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readFixed32List(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L8d:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readFixed64List(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L9e:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readInt32List(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        Laf:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readUInt64List(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        Lc0:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readInt64List(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        Ld1:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readfloatList(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        Le2:
            r2 = r5
            r5 = r7
            androidx.datastore.preferences.protobuf.ListFieldSchema r3 = r1.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            java.util.List r3 = r3.mutableListAt(r2, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.readdoubleList(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        Lf3:
            r2 = r5
            java.lang.object r5 = r1.mutableMessageFieldForMerge(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.MessageLite r5 = (androidx.datastore.preferences.protobuf.MessageLite) r5     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.Schema r7 = r1.getMessageFieldSchema(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.mergeGroupField(r5, r7, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.storeMessageField(r2, r3, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L106:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r14 = r4.readSInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L118:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            int r5 = r4.readSInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L12a:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r14 = r4.readSFixed64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L13c:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            int r5 = r4.readSFixed32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L14e:
            r16 = r7
            r7 = r2
            r2 = r5
            r5 = r16
            int r12 = r4.readEnum()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r13 = r1.getEnumFieldVerifier(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            if (r13 == 0) goto L16b
            bool r13 = r13.isInRange(r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            if (r13 == 0) goto L165
            goto L16b
        L165:
            java.lang.object r5 = androidx.datastore.preferences.protobuf.SchemaUtil.storeUnknownEnum(r2, r7, r12, r11, r10)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto Lc79
        L16b:
            long r13 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r13, r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L177:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            int r5 = r4.readUInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L189:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.bytestring r5 = r4.readbytes()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L19b:
            r2 = r5
            java.lang.object r5 = r1.mutableMessageFieldForMerge(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.MessageLite r5 = (androidx.datastore.preferences.protobuf.MessageLite) r5     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.Schema r7 = r1.getMessageFieldSchema(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r4.mergeMessageField(r5, r7, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.storeMessageField(r2, r3, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1ae:
            r2 = r5
            r5 = r7
            r1.readstring(r2, r5, r4)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1b8:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            bool r5 = r4.readBool()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putbool(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1ca:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            int r5 = r4.readFixed32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1dc:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r14 = r4.readFixed64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1ed:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            int r5 = r4.readInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L1fe:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r14 = r4.readUInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L20f:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            long r14 = r4.readInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L220:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            float r5 = r4.readfloat()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putfloat(r2, r12, r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L241
        L231:
            r2 = r5
            r5 = r7
            long r12 = offset(r5)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            double r14 = r4.readdouble()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            androidx.datastore.preferences.protobuf.UnsafeUtil.putdouble(r2, r12, r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            r1.setFieldPresent(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
        L241:
            goto Lcf6
        L245:
            r6 = r22
            goto L52d
        L24b:
            r4 = r21
            bool r1 = r5.shouldDiscardUnknownFields(r4)     // Catch: java.lang.Exception -> L702
            goto L7ec
        L255:
            r1 = r12
            goto L539
        L25a:
            r4 = r5
        L25b:
            goto L5fe
        L25f:
            if (r0 == 0) goto L264
            goto L3f0
        L264:
            androidx.datastore.preferences.protobuf.FieldHashSet r0 = r19.getMutableExtensions(r20)     // Catch: java.lang.Exception -> L79f
            goto L79d
        L26c:
            r5 = r10
            goto L744
        L271:
            r6 = r22
            goto L55d
        L277:
            int[] r3 = r1.intArray
            goto Lc62
        L27d:
            goto L885
        L27f:
            java.lang.object r7 = r1.mutableOneofMessageFieldForMerge(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.MessageLite r7 = (androidx.datastore.preferences.protobuf.MessageLite) r7     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.Schema r12 = r1.getMessageFieldSchema(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r4.mergeGroupField(r7, r12, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.storeOneofMessageField(r5, r2, r3, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L291:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            long r14 = r4.readSInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.long r7 = java.lang.long.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L2a5:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            int r7 = r4.readSInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L2b9:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            long r14 = r4.readSFixed64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.long r7 = java.lang.long.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L2cd:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            int r7 = r4.readSFixed32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L2e0:
            int r12 = r4.readEnum()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r13 = r1.getEnumFieldVerifier(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            if (r13 == 0) goto L2fc
            bool r13 = r13.isInRange(r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            if (r13 == 0) goto L2f1
            goto L2fc
        L2f1:
            java.lang.object r2 = androidx.datastore.preferences.protobuf.SchemaUtil.storeUnknownEnum(r5, r2, r12, r11, r10)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r16 = r5
            r5 = r2
            r2 = r16
            goto Lc79
        L2fc:
            long r13 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r12)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r13, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L30b:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            int r7 = r4.readUInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L31e:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.bytestring r7 = r4.readbytes()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L32d:
            java.lang.object r7 = r1.mutableOneofMessageFieldForMerge(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.MessageLite r7 = (androidx.datastore.preferences.protobuf.MessageLite) r7     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.Schema r12 = r1.getMessageFieldSchema(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r4.mergeMessageField(r7, r12, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.storeOneofMessageField(r5, r2, r3, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L33e:
            r1.readstring(r5, r7, r4)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
        L344:
            r2 = r5
            goto L241
        L347:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            bool r7 = r4.readBool()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.bool r7 = java.lang.bool.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L35a:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            int r7 = r4.readFixed32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L36d:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            long r14 = r4.readFixed64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.long r7 = java.lang.long.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L380:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            int r7 = r4.readInt32()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.int r7 = java.lang.int.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L393:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            long r14 = r4.readUInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.long r7 = java.lang.long.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L3a6:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            long r14 = r4.readInt64()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.long r7 = java.lang.long.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L3b9:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            float r7 = r4.readfloat()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.float r7 = java.lang.float.valueOf(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L344
        L3cd:
            long r12 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            double r14 = r4.readdouble()     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            java.lang.double r7 = java.lang.double.valueOf(r14)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r12, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            r1.setOneofPresent(r5, r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            goto L454
        L3e3:
            r4 = r2
            goto L5f9
        L3e8:
            goto Lb34
        L3ea:
            goto L4ae
        L3ee:
            goto Lc69
        L3f0:
            goto La05
        L3f4:
            r10 = r6
            goto L74c
        L3f9:
            r5 = r11
        L3fa:
            goto L3a
        L3fe:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto L7a4
        L406:
            int[] r3 = r1.intArray
            goto L8c8
        L40c:
            if (r4 != 0) goto L411
            goto Lb34
        L411:
            goto L415
        L415:
            r10.setBuilderToMessage(r5, r4)
            goto L700
        L41c:
            goto L97f
        L41e:
            r0 = move-exception
            goto Lc57
        L423:
            r10 = r6
            goto L955
        L428:
            if (r3 == 0) goto L42d
            goto Lc79
        L42d:
            goto Lce2
        L431:
            goto Lc9c
        L433:
            goto L4c6
        L437:
            r6 = r22
        L439:
            goto L793
        L43d:
            goto L25b
        L43f:
            goto L465
        L443:
            r6 = r20
            goto L26c
        L449:
            r10 = r1
            goto L5c0
        L44e:
            r1 = r20
            goto L919
        L454:
            goto L344
        L456:
            java.lang.object r4 = r1.getDictionaryFieldDefaultEntry(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L8f6 java.lang.Exception -> L90d
            r2 = r5
            r5 = r6
            r6 = r21
            r1.mergeDictionary(r2, r3, r4, r5, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L8f6 java.lang.Exception -> L90d
            goto L949
        L465:
            r5 = r10
            goto L4
        L46a:
            r6 = r22
            goto Lc83
        L470:
            int r0 = r1.checkInitializedCount
            goto Lca0
        L476:
            r5 = r0
        L477:
            int r2 = r21.getFieldNumber()     // Catch: java.lang.Exception -> L944
            int r3 = r1.positionForFieldNumber(r2)     // Catch: java.lang.Exception -> L944
            goto Lb3d
        L483:
            goto L48f
        L485:
            goto L8dd
        L489:
            r12 = r1
            goto Lbe2
        L48e:
            r5 = r11
        L48f:
            bool r3 = r10.shouldDiscardUnknownFields(r4)     // Catch: java.lang.Exception -> L42
            if (r3 == 0) goto Lc34
            bool r3 = r4.skipField()     // Catch: java.lang.Exception -> L42
            goto Lbc3
        L49d:
            r6 = r20
            goto L733
        L4a3:
            int r1 = r10.repeatedFieldOffsetStart
            goto L85f
        L4a9:
            r4 = r5
        L4aa:
            goto L726
        L4ae:
            r6 = r18
            goto L449
        L4b4:
            if (r5 == 0) goto L4b9
            goto L4be
        L4b9:
            java.lang.object r3 = r10.getBuilderFromMessage(r2)     // Catch: java.lang.Exception -> L42
            r5 = r3
        L4be:
            bool r3 = r10.mergeOneFieldFrom(r5, r4, r9)     // Catch: java.lang.Exception -> L42
            goto L428
        L4c6:
            r10 = r5
            goto L5bb
        L4cb:
            r2 = r1
        L4cc:
            goto L7a9
        L4d0:
            r11 = r1
        L4d1:
            bool r1 = r5.mergeOneFieldFrom(r11, r4, r9)     // Catch: java.lang.Exception -> L702
            goto L4e6
        L4d9:
            r5.setBuilderToMessage(r2, r4)
        L4dc:
            goto L66c
        L4e0:
            r6 = r20
            goto L934
        L4e6:
            if (r1 != 0) goto L4eb
            goto Lcfd
        L4eb:
            goto Lcfb
        L4ef:
            r2 = r1
            goto L92f
        L4f4:
            r5 = r21
            r1.readGroupList(r2, r3, r5, r6, r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L8d0 java.lang.Exception -> Lc96
            goto Lb38
        L4fd:
            r1 = r10
            goto Lc03
        L502:
            r2 = r5
            goto La10
        L507:
            r4 = r5
        L508:
            goto L60a
        L50c:
            r12 = r1
            goto Lc38
        L511:
            goto Lb0a
        L513:
            goto L50c
        L517:
            r8 = 0
            goto Lcd8
        L51c:
            r6 = r4
            goto L24b
        L521:
            goto Lc69
        L523:
            r0 = move-exception
        L524:
            goto Lc47
        L528:
            r5 = r10
            goto L2d
        L52d:
            goto L4cc
        L52f:
            r0 = move-exception
        L530:
            goto L35
        L534:
            r4 = r6
            goto L40
        L539:
            r4 = r13
            goto Lb47
        L53e:
            r2 = r20
            goto L3fe
        L544:
            r4 = r13
            goto L483
        L549:
            int[] r2 = r1.intArray
            goto L624
        L54f:
            r1 = r12
            goto L752
        L554:
            if (r3 == 0) goto L559
            goto Lc79
        L559:
            goto Lcb8
        L55d:
            r11 = r5
            goto L97c
        L562:
            if (r0 <= 0) goto L567
            goto L10
        L567:
            goto Ld
        L56b:
            r1 = r17
            goto L70d
        L571:
            r1 = r10
            goto L836
        L576:
            goto L530
        L578:
            goto L638
        L57c:
            r2 = r1
            goto Lc0d
        L581:
            r4 = r21
            goto L9c6
        L587:
            r12 = r1
            goto L7b3
        L58c:
            r2 = r1
            goto L47
        L591:
            r2 = r20
            goto L8ac
        L597:
            r3 = r4
            goto L4f4
        L59c:
            if (r0 < r3) goto L5a1
            goto L88f
        L5a1:
            goto L5b5
        L5a5:
            r5 = r10
            goto L9c1
        L5aa:
            r1 = r2
            goto L8e2
        L5af:
            int r0 = r0 + 1
            goto Lccd
        L5b5:
            int[] r3 = r1.intArray
            goto L9dc
        L5bb:
            r5 = r2
            goto L40c
        L5c0:
            r1 = r20
            bool r3 = r10.hasExtensions     // Catch: java.lang.Exception -> Lbe9
            if (r3 != 0) goto L5cb
            r7 = r19
            r3 = r8
            goto Ld02
        L5cb:
            androidx.datastore.preferences.protobuf.MessageLite r3 = r10.defaultInstance     // Catch: java.lang.Exception -> Lbe9
            r7 = r19
            java.lang.object r2 = r7.findExtensionByNumber(r4, r3, r2)     // Catch: java.lang.Exception -> Lbe9
            goto Ld01
        L5d7:
            r2 = r1
            goto Lb22
        L5dc:
            int r3 = r1.repeatedFieldOffsetStart
            goto Lced
        L5e2:
            r2 = r20
            goto L62a
        L5e8:
            r0 = r7
            goto Lc8f
        L5ed:
            int r2 = r1.repeatedFieldOffsetStart
            goto L24
        L5f3:
            r6 = r22
            goto L4cb
        L5f9:
            r2 = r1
            goto Lb61
        L5fe:
            int r3 = r1.repeatedFieldOffsetStart
            goto L8d4
        L604:
            goto Lc48
        L606:
            goto Ld06
        L60a:
            int r3 = r1.repeatedFieldOffsetStart
            goto L59c
        L610:
            if (r4 != 0) goto L615
            goto Lb34
        L615:
            goto Lb32
        L619:
            r6 = r10
            goto L87b
        L61e:
            int r0 = r0 + r1
            goto L7e1
        L624:
            r3 = r2[r0]
            goto Lbd7
        L62a:
            goto Lc48
        L62c:
            long r4 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L8f6 java.lang.Exception -> L914
            androidx.datastore.preferences.protobuf.Schema r6 = r1.getMessageFieldSchema(r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L8f6 java.lang.Exception -> L914
            goto L989
        L638:
            r6 = r22
            goto L58c
        L63e:
            r6 = r22
            goto L54f
        L644:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto L831
        L64c:
            r2 = r20
            goto Lc68
        L652:
            r13 = r4
            goto Lcc4
        L657:
            r10 = r5
            goto L604
        L65c:
            r1 = r12
            goto L544
        L661:
            r12 = r1
            goto L9a0
        L666:
            r6 = r22
            goto L53
        L66c:
            throw r0
        L6fc:
            goto L8b2
        L700:
            goto Lb34
        L702:
            r0 = move-exception
            goto L85a
        L707:
            int r0 = r10.checkInitializedCount
            goto Lc9b
        L70d:
            r4 = r22
            goto L517
        L713:
            if (r3 != 0) goto L718
            goto L606
        L718:
            goto L25f
        L71c:
            r4 = r6
            goto L571
        L721:
            r4 = r13
            goto Lc94
        L726:
            int r3 = r1.repeatedFieldOffsetStart
            goto Lcaf
        L72c:
            r6.setBuilderToMessage(r1, r4)
            goto L3e8
        L733:
            r5 = r10
            goto L8fa
        L738:
            r10 = r6
        L739:
            goto L63e
        L73d:
            goto L8b5
        L740:
            goto L8ed
        L744:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto L5af
        L74c:
            goto L36
        L74e:
            goto L78e
        L752:
            r4 = r13
            goto L9b5
        L757:
            r3 = r3[r0]
            goto L443
        L75d:
            r10.setBuilderToMessage(r2, r4)
            goto L4d
        L764:
            r1 = r10
            goto L423
        L769:
            r1 = r2
            goto L76e
        L76e:
            r6 = r5
            goto L826
        L773:
            r5 = r0
            goto L5e8
        L778:
            if (r4 != 0) goto L77d
            goto Lb34
        L77d:
            goto Lc32
        L781:
            r6 = r22
            goto L511
        L787:
            goto L739
        L789:
            r0 = move-exception
            goto L96c
        L78e:
            r11 = r5
            goto L5d7
        L793:
            r5 = r11
        L794:
            goto L65c
        L798:
            r12 = r1
            goto L5aa
        L79d:
            goto L3f0
        L79f:
            r0 = move-exception
            goto Lb42
        L7a4:
            r10 = r1
            goto L769
        L7a9:
            r1 = r12
            goto L721
        L7ae:
            r3 = r6
            goto L8b9
        L7b3:
            r1 = r2
            goto L8ce
        L7b8:
            r2 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            long r3 = offset(r7)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            r13.readUInt32List(r1)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            goto L7d7
        L7c7:
            r12 = r1
            r13 = r4
            r2 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            long r3 = offset(r7)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
            r13.readbytesList(r1)     // Catch: java.lang.Exception -> L52f androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L968
        L7d7:
            goto L245
        L7db:
            r6 = r22
            goto L961
        L7e1:
            int r0 = r0 % r1
            goto L562
        L7e7:
            r11 = r6
            goto L9bc
        L7ec:
            if (r1 != 0) goto L7f1
            goto L7ff
        L7f1:
            bool r1 = r4.skipField()     // Catch: java.lang.Exception -> L7fc
            if (r1 == 0) goto Lcfd
        L7f7:
            r4 = r6
            r1 = r10
            r5 = r11
            goto L477
        L7fc:
            r0 = move-exception
            goto L9bd
        L7ff:
            if (r11 != 0) goto L4d1
            java.lang.object r1 = r5.getBuilderFromMessage(r2)     // Catch: java.lang.Exception -> L7fc
            goto L4d0
        L809:
            r4 = r21
            int r7 = r1.typeAndOffsetAt(r3)     // Catch: java.lang.Exception -> L523
            int r12 = type(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L4f java.lang.Exception -> L523
            switch(r12) {
                case 0: goto L231;
                case 1: goto L220;
                case 2: goto L20f;
                case 3: goto L1fe;
                case 4: goto L1ed;
                case 5: goto L1dc;
                case 6: goto L1ca;
                case 7: goto L1b8;
                case 8: goto L1ae;
                case 9: goto L19b;
                case 10: goto L189;
                case 11: goto L177;
                case 12: goto L14e;
                case 13: goto L13c;
                case 14: goto L12a;
                case 15: goto L118;
                case 16: goto L106;
                case 17: goto Lf3;
                case 18: goto Le2;
                case 19: goto Ld1;
                case 20: goto Lc0;
                case 21: goto Laf;
                case 22: goto L9e;
                case 23: goto L8d;
                case 24: goto L7c;
                case 25: goto L6b;
                case 26: goto L64;
                case 27: goto L485;
                case 28: goto L7c7;
                case 29: goto Lc85;
                case 30: goto L985;
                case 31: goto Laed;
                case 32: goto Ladb;
                case 33: goto Lac9;
                case 34: goto Lab7;
                case 35: goto Laa5;
                case 36: goto La92;
                case 37: goto La7f;
                case 38: goto La6c;
                case 39: goto La59;
                case 40: goto La46;
                case 41: goto La33;
                case 42: goto La20;
                case 43: goto L822;
                case 44: goto L49;
                case 45: goto Lb9a;
                case 46: goto Lb88;
                case 47: goto Lb76;
                case 48: goto L513;
                case 49: goto L62c;
                case 50: goto L456;
                case 51: goto L3cd;
                case 52: goto L3b9;
                case 53: goto L3a6;
                case 54: goto L393;
                case 55: goto L380;
                case 56: goto L36d;
                case 57: goto L35a;
                case 58: goto L347;
                case 59: goto L33e;
                case 60: goto L32d;
                case 61: goto L31e;
                case 62: goto L30b;
                case 63: goto L2e0;
                case 64: goto L2cd;
                case 65: goto L2b9;
                case 66: goto L2a5;
                case 67: goto L291;
                case 68: goto L27f;
                default: goto L816;
            }
        L816:
            goto Lcd3
        L81a:
            r6 = r22
            goto L8a7
        L820:
            goto L794
        L822:
            goto Lc23
        L826:
            int r0 = r0 + 1
            goto Lc73
        L82c:
            r2 = r1
            goto Lb5c
        L831:
            r10 = r5
            goto Lc13
        L836:
            goto L477
        L838:
            r0 = move-exception
            goto Lc4c
        L83d:
            r1 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r4 = r12.listFieldSchema     // Catch: java.lang.Exception -> L41e androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lbb0
            long r5 = offset(r7)     // Catch: java.lang.Exception -> L41e androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lbb0
            java.util.List r4 = r4.mutableListAt(r1, r5)     // Catch: java.lang.Exception -> L41e androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lbb0
            r13.readEnumList(r4)     // Catch: java.lang.Exception -> L41e androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lbb0
            r5 = r4
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r4 = r12.getEnumFieldVerifier(r3)     // Catch: java.lang.Exception -> L41e androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lbb0
            goto Lc08
        L854:
            r6 = r20
            goto L9d1
        L85a:
            r1 = r10
            goto L8c3
        L85f:
            if (r0 < r1) goto L864
            goto L433
        L864:
            goto Lc5c
        L868:
            r10 = r18
            goto L46a
        L86e:
            int r0 = r1.checkInitializedCount
            goto L4a9
        L874:
            r3 = 2147483647(0x7fffffff, float:NaN)
            goto L939
        L87b:
            r5 = r11
            java.lang.object r5 = androidx.datastore.preferences.protobuf.SchemaUtil.filterUnknownEnumList(r1, r2, r3, r4, r5, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L3fa java.lang.Exception -> L789
            goto L57c
        L884:
            r5 = r11
        L885:
            bool r3 = r10.mergeOneFieldFrom(r5, r4, r9)     // Catch: java.lang.Exception -> L42 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L48f
            goto L554
        L88d:
            goto L508
        L88f:
            goto L98f
        L893:
            r2 = r21
            java.lang.object r3 = r0.parseExtension(r1, r2, r3, r4, r5, r6, r7)     // Catch: java.lang.Exception -> L838
            goto L9a6
        L89d:
            r5 = r6
            goto L51c
        L8a2:
            r3 = r2
            goto L4ef
        L8a7:
            r4 = r5
            goto L912
        L8ac:
            r4 = r21
            goto L781
        L8b2:
            goto L10
        L8b5:
            goto Lbfa
        L8b9:
            r6 = r18
            java.lang.object r5 = androidx.datastore.preferences.protobuf.SchemaUtil.filterUnknownEnumList(r1, r2, r3, r4, r5, r6)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L74e java.lang.Exception -> L9b7
            goto Lb4d
        L8c3:
            r10 = r5
            goto Lbbe
        L8c8:
            r3 = r3[r0]
            goto L854
        L8ce:
            goto L530
        L8d0:
            goto L81a
        L8d4:
            if (r7 < r3) goto L8d9
            goto L43f
        L8d9:
            goto L277
        L8dd:
            r12 = r1
            goto L652
        L8e2:
            r13 = r4
            goto L14
        L8e7:
            int r3 = r1.checkInitializedCount
            goto L19
        L8ed:
            r0 = 31
            goto L922
        L8f4:
            goto Lb05
        L8f6:
            goto L591
        L8fa:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto L1e
        L902:
            if (r3 < 0) goto L907
            goto L957
        L907:
            goto L874
        L90b:
            goto L241
        L90d:
            r0 = move-exception
            goto L5e2
        L912:
            goto Lb0a
        L914:
            r0 = move-exception
            goto L661
        L919:
            if (r4 != 0) goto L91e
            goto Lb34
        L91e:
            goto L72c
        L922:
            r1 = 19
            goto L61e
        L929:
            int[] r3 = r1.intArray
            goto L757
        L92f:
            r1 = r3
            goto L7ae
        L934:
            r1 = r10
            goto L644
        L939:
            if (r2 == r3) goto L93e
            goto L3ea
        L93e:
            goto L470
        L942:
            goto Lc69
        L944:
            r0 = move-exception
            goto Lbee
        L949:
            r2 = r20
            goto L581
        L94f:
            int r0 = r0 + 1
            goto L5a5
        L955:
            goto L524
        L957:
            goto La0a
        L95b:
            r6 = r20
            goto L528
        L961:
            r2 = r1
            goto L820
        L966:
            goto Lc69
        L968:
            goto L437
        L96c:
            r2 = r1
            goto L41c
        L971:
            r5 = r18
            goto L53e
        L977:
            r11 = r5
        L978:
            goto L868
        L97c:
            goto L4cc
        L97e:
            r0 = move-exception
        L97f:
            goto Lbcc
        L983:
            goto L36
        L985:
            goto L798
        L989:
            r2 = r20
            goto Ld17
        L98f:
            if (r4 != 0) goto L994
            goto Lb34
        L994:
            goto L75d
        L998:
            java.lang.object r4 = r1.filterDictionaryUnknownEnumValues(r2, r3, r4, r5, r6)
            goto L9e2
        L9a0:
            r1 = r20
            goto L8f4
        L9a6:
            r6 = r4
            goto Lbb9
        L9ab:
            r1 = r12
            goto L966
        L9b0:
            r11 = r5
            goto Lbf4
        L9b5:
            goto Lc79
        L9b7:
            r0 = move-exception
            goto L82c
        L9bc:
            r5 = r7
        L9bd:
            goto Lbb4
        L9c1:
            r10 = r1
            goto L431
        L9c6:
            r6 = r22
            goto L90b
        L9cc:
            r1 = r2
            goto Lcaa
        L9d1:
            r5 = r10
            goto L998
        L9d6:
            goto L4aa
        L9d8:
            goto L778
        L9dc:
            r3 = r3[r0]
            goto L49d
        L9e2:
            int r0 = r0 + 1
            goto L9d6
        L9e8:
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r4 = r12.listFieldSchema     // Catch: java.lang.Exception -> Lb10 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lc8b
            long r6 = offset(r7)     // Catch: java.lang.Exception -> Lb10 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lc8b
            java.util.List r4 = r4.mutableListAt(r2, r6)     // Catch: java.lang.Exception -> Lb10 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lc8b
            r13.readEnumList(r4)     // Catch: java.lang.Exception -> Lb10 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lc8b
            r6 = r4
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r4 = r12.getEnumFieldVerifier(r3)     // Catch: java.lang.Exception -> Lb10 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lc8b
            goto L8a2
        L9ff:
            r1 = r17
            goto L43d
        La05:
            r2 = r5
            goto L773
        La0a:
            r10 = r18
            goto Lc3d
        La10:
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readUInt32List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La20:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readBoolList(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La33:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readFixed32List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La46:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readFixed64List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La59:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readInt32List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La6c:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readUInt64List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La7f:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readInt64List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        La92:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readfloatList(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        Laa5:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readdoubleList(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        Lab7:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readSInt64List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        Lac9:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readSInt32List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        Ladb:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readSFixed64List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            goto Lafe
        Laed:
            r12 = r1
            r13 = r4
            r2 = r5
            r5 = r11
            androidx.datastore.preferences.protobuf.ListFieldSchema r1 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            java.util.List r1 = r1.mutableListAt(r2, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
            r13.readSFixed32List(r1)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L978 java.lang.Exception -> L97e
        Lafe:
            goto Lc1d
        Lb02:
            goto Lcab
        Lb04:
            r0 = move-exception
        Lb05:
            goto Lc28
        Lb09:
            r2 = r5
        Lb0a:
            goto L48e
        Lb0e:
            goto L48f
        Lb10:
            r0 = move-exception
            goto Lc7d
        Lb15:
            if (r11 == 0) goto Lb1a
            goto Lc53
        Lb1a:
            java.lang.object r5 = r10.getBuilderFromMessage(r2)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> Lb0a java.lang.Exception -> Ld0d
            goto L27d
        Lb22:
            r10 = r6
            goto L255
        Lb27:
            r3 = r1[r0]
            goto L4e0
        Lb2d:
            r11 = r5
            goto L89d
        Lb32:
            goto L994
        Lb34:
            goto Lc78
        Lb38:
            r12 = r1
            goto L9cc
        Lb3d:
            r9 = 0
            goto L902
        Lb42:
            r2 = r1
            goto L4fd
        Lb47:
            r6 = r22
            goto Lb0e
        Lb4d:
            r2 = r1
            goto L738
        Lb52:
            r13 = r4
            goto L502
        Lb57:
            r11 = r5
            goto Lc89
        Lb5c:
            r11 = r5
            goto L3f4
        Lb61:
            r5 = r3
            goto L71c
        Lb66:
            r1 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            java.util.List r2 = r2.mutableListAt(r1, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            r13.readSInt64List(r2)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            goto Lcab
        Lb76:
            r12 = r1
            r13 = r4
            r1 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            java.util.List r2 = r2.mutableListAt(r1, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            r13.readSInt32List(r2)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            goto Lcab
        Lb88:
            r12 = r1
            r13 = r4
            r1 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            java.util.List r2 = r2.mutableListAt(r1, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            r13.readSFixed64List(r2)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            goto Lcab
        Lb9a:
            r12 = r1
            r13 = r4
            r1 = r5
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r12.listFieldSchema     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            long r3 = offset(r7)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            java.util.List r2 = r2.mutableListAt(r1, r3)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            r13.readSFixed32List(r2)     // Catch: androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L578 java.lang.Exception -> Lb04
            goto Lb02
        Lbae:
            goto L97f
        Lbb0:
            goto L3f9
        Lbb4:
            r1 = r10
            goto L657
        Lbb9:
            r0 = r5
            goto Lce8
        Lbbe:
            r5 = r2
            goto Lbe7
        Lbc3:
            if (r3 == 0) goto Lbc8
            goto Lc79
        Lbc8:
            goto L86e
        Lbcc:
            r10 = r18
            goto L983
        Lbd2:
            r13 = r4
            goto L7b8
        Lbd7:
            r6 = r20
            goto L971
        Lbdd:
            r5 = r1
            goto L764
        Lbe2:
            r13 = r4
            goto L83d
        Lbe7:
            goto Lc48
        Lbe9:
            r0 = move-exception
            goto Lcdd
        Lbee:
            r10 = r18
            goto L64c
        Lbf4:
            r5 = r20
            goto L809
        Lbfa:
            goto L740
        Lbfd:
            goto Lca1
        Lbff:
            goto Lcbe
        Lc03:
            r10 = r6
            goto L3ee
        Lc08:
            r3 = r5
            goto L619
        Lc0d:
            r10 = r18
            goto L787
        Lc13:
            r5 = r2
            goto L94f
        Lc18:
            r4 = r5
        Lc19:
            goto L5dc
        Lc1d:
            r10 = r18
            goto L271
        Lc23:
            r12 = r1
            goto Lb52
        Lc28:
            r2 = r1
            goto L576
        Lc2d:
            r12 = r1
            goto Lbd2
        Lc32:
            goto L994
        Lc34:
            goto L4b4
        Lc38:
            r13 = r4
            goto Lb66
        Lc3d:
            r6 = r4
            goto L9b0
        Lc42:
            r5 = r11
            goto Lbae
        Lc47:
            r2 = r5
        Lc48:
            goto Lca5
        Lc4c:
            r2 = r1
            goto L7e7
        Lc51:
            goto Lc48
        Lc53:
            goto L884
        Lc57:
            r2 = r1
            goto Lc42
        Lc5c:
            int[] r1 = r10.intArray
            goto Lb27
        Lc62:
            r3 = r3[r7]
            goto L95b
        Lc68:
            r11 = r5
        Lc69:
            goto L8e7
        Lc6d:
            int r7 = r7 + 1
            goto L9ff
        Lc73:
            r1 = r10
            goto Lbfd
        Lc78:
            return
        Lc79:
            goto L534
        Lc7d:
            r10 = r18
            goto Lb57
        Lc83:
            goto L794
        Lc85:
            goto Lc2d
        Lc89:
            goto L36
        Lc8b:
            goto L977
        Lc8f:
            r7 = r6
            goto Ld12
        Lc94:
            goto L241
        Lc96:
            r0 = move-exception
            goto L587
        Lc9b:
            r4 = r11
        Lc9c:
            goto L4a3
        Lca0:
            r4 = r5
        Lca1:
            goto L5ed
        Lca5:
            r5 = r11
            goto L942
        Lcaa:
            r13 = r5
        Lcab:
            goto L5f3
        Lcaf:
            if (r0 < r3) goto Lcb4
            goto L9d8
        Lcb4:
            goto L406
        Lcb8:
            int r0 = r1.checkInitializedCount
            goto L507
        Lcbe:
            r6 = r18
            goto L44e
        Lcc4:
            r2 = r5
            androidx.datastore.preferences.protobuf.Schema r5 = r12.getMessageFieldSchema(r3)     // Catch: java.lang.Exception -> L59 androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.InvalidWireTypeException -> L5d
            goto L666
        Lccd:
            goto Lc19
        Lccf:
            goto L610
        Lcd3:
            r2 = r5
            goto Lb15
        Lcd8:
            r0 = r8
            goto L476
        Lcdd:
            r11 = r5
            goto Lbdd
        Lce2:
            int r0 = r1.checkInitializedCount
            goto Lc18
        Lce8:
            r5 = r7
            goto L3e3
        Lced:
            if (r0 < r3) goto Lcf2
            goto Lccf
        Lcf2:
            goto L929
        Lcf6:
            r5 = r11
            goto Ld0b
        Lcfb:
            goto L7f7
        Lcfd:
            goto L707
        Ld01:
            r3 = r2
        Ld02:
            goto L713
        Ld06:
            r2 = r1
            goto Lb2d
        Ld0b:
            goto Lc79
        Ld0d:
            r0 = move-exception
            goto Lc51
        Ld12:
            r6 = r2
            goto L893
        Ld17:
            r7 = r22
            goto L597
    }

    private readonly <K, V> void MergeDictionary(java.lang.object r5, int r6, java.lang.object r7, androidx.datastore.preferences.protobuf.ExtensionRegistryLite r8, androidx.datastore.preferences.protobuf.Reader r9) throws java.io.IOException {
            r4 = this;
            goto L54
        L4:
            androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata r4 = r4.forDictionaryMetadata(r7)
            goto Lc
        Lc:
            r9.readDictionary(r5, r4, r8)
            goto L2f
        L13:
            goto Lcf
        L16:
            goto L49
        L1a:
            int r0 = r0 % r1
            goto L8c
        L20:
            java.lang.object r2 = r2.newDictionaryField(r7)
            goto L5b
        L28:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r0, r2)
            goto Lc7
        L2f:
            return
        L30:
            goto L13
        L34:
            java.lang.object r6 = r6.newDictionaryField(r7)
            goto Ld3
        L3c:
            int r0 = r0 + r1
            goto L1a
        L42:
            r1 = 11
            goto L3c
        L49:
            goto L57
        L4c:
            bool r2 = r2.isImmutable(r6)
            goto L6a
        L54:
            goto L16
        L57:
            goto Lb2
        L5b:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r3 = r4.mapFieldSchema
            goto La5
        L61:
            if (r6 == 0) goto L66
            goto L74
        L66:
            goto L86
        L6a:
            if (r2 != 0) goto L6f
            goto Lc8
        L6f:
            goto Lb9
        L73:
            goto Lc8
        L74:
            goto Lac
        L78:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r4 = r4.mapFieldSchema
            goto L4
        L7e:
            java.util.Dictionary r5 = r5.forMutableDictionaryData(r6)
            goto L78
        L86:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r6 = r4.mapFieldSchema
            goto L34
        L8c:
            if (r0 <= 0) goto L91
            goto Lcf
        L91:
            goto Lcc
        L95:
            java.lang.object r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r5, r0)
            goto L61
        L9d:
            long r0 = offset(r6)
            goto L95
        La5:
            r3.mergeFrom(r2, r6)
            goto L28
        Lac:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r2 = r4.mapFieldSchema
            goto L4c
        Lb2:
            r0 = 28
            goto L42
        Lb9:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r2 = r4.mapFieldSchema
            goto L20
        Lbf:
            int r6 = r4.typeAndOffsetAt(r6)
            goto L9d
        Lc7:
            r6 = r2
        Lc8:
            goto Lda
        Lcc:
            goto L30
        Lcf:
            goto Lbf
        Ld3:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r5, r0, r6)
            goto L73
        Lda:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r5 = r4.mapFieldSchema
            goto L7e
    }

    private void MergeMessage(T r6, T r7, int r8) {
            r5 = this;
            goto L161
        L4:
            bool r4 = isMutable(r3)
            goto L13d
        Lc:
            java.lang.IllegalStateException r6 = new java.lang.IllegalStateException
            goto L122
        L12:
            androidx.datastore.preferences.protobuf.Schema r7 = r5.getMessageFieldSchema(r8)
            goto L1a
        L1a:
            bool r4 = r5.isFieldPresent(r6, r8)
            goto La9
        L22:
            r0 = 9
            goto L40
        L29:
            return
        L2a:
            goto Lef
        L2e:
            r6.<init>(r5)
            goto L5a
        L35:
            return
        L36:
            goto Lc
        L3a:
            sun.misc.Unsafe r2 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto La1
        L40:
            r1 = 9
            goto L14d
        L47:
            java.lang.string r5 = r5.tostring()
            goto L2e
        L4f:
            return
        L50:
            goto Lb9
        L54:
            int r0 = r0 % r1
            goto L5f
        L5a:
            throw r6
        L5b:
            goto L146
        L5f:
            if (r0 <= 0) goto L64
            goto Leb
        L64:
            goto Le8
        L68:
            java.lang.string r8 = " is present but null: "
            goto Lf7
        L6e:
            java.lang.stringBuilder r5 = r0.append(r5)
            goto L68
        L76:
            java.lang.string r1 = "Source subfield "
            goto Lb2
        L7c:
            r7.mergeFrom(r8, r5)
            goto L15a
        L83:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto Ld7
        L8b:
            r7.mergeFrom(r5, r3)
            goto L35
        L92:
            java.lang.stringBuilder r5 = r5.append(r7)
            goto L47
        L9a:
            r5.setFieldPresent(r6, r8)
            goto L4f
        La1:
            java.lang.object r3 = r2.getobject(r7, r0)
            goto L12f
        La9:
            if (r4 == 0) goto Lae
            goto L50
        Lae:
            goto L4
        Lb2:
            r0.<init>(r1)
            goto L108
        Lb9:
            java.lang.object r5 = r2.getobject(r6, r0)
            goto L11a
        Lc1:
            long r0 = offset(r0)
            goto L3a
        Lc9:
            java.lang.object r8 = r7.newInstance()
            goto L7c
        Ld1:
            goto L156
        Ld3:
            goto Le0
        Ld7:
            if (r0 == 0) goto Ldc
            goto L2a
        Ldc:
            goto L29
        Le0:
            java.lang.object r4 = r7.newInstance()
            goto L110
        Le8:
            goto L5b
        Leb:
            goto L83
        Lef:
            int r0 = r5.typeAndOffsetAt(r8)
            goto Lc1
        Lf7:
            java.lang.stringBuilder r5 = r5.append(r8)
            goto L92
        Lff:
            if (r8 == 0) goto L104
            goto L139
        L104:
            goto Lc9
        L108:
            int r5 = r5.numberAt(r8)
            goto L6e
        L110:
            r7.mergeFrom(r4, r3)
            goto L153
        L117:
            goto L164
        L11a:
            bool r8 = isMutable(r5)
            goto Lff
        L122:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L76
        L128:
            r2.putobject(r6, r0, r3)
            goto Ld1
        L12f:
            if (r3 != 0) goto L134
            goto L36
        L134:
            goto L12
        L138:
            r5 = r8
        L139:
            goto L8b
        L13d:
            if (r4 == 0) goto L142
            goto Ld3
        L142:
            goto L128
        L146:
            goto Leb
        L149:
            goto L117
        L14d:
            int r0 = r0 + r1
            goto L54
        L153:
            r2.putobject(r6, r0, r4)
        L156:
            goto L9a
        L15a:
            r2.putobject(r6, r0, r8)
            goto L138
        L161:
            goto L149
        L164:
            goto L22
    }

    private void MergeOneofMessage(T r7, T r8, int r9) {
            r6 = this;
            goto L96
        L4:
            r3.putobject(r7, r1, r4)
            goto La7
        Lb:
            r8.mergeFrom(r6, r4)
            goto L123
        L12:
            java.lang.object r4 = r3.getobject(r8, r1)
            goto L134
        L1a:
            androidx.datastore.preferences.protobuf.Schema r8 = r6.getMessageFieldSchema(r9)
            goto L11b
        L22:
            bool r1 = r6.isOneofPresent(r8, r0, r9)
            goto L153
        L2a:
            r3.putobject(r7, r1, r9)
            goto Led
        L31:
            return
        L32:
            goto L36
        L36:
            int r1 = r6.typeAndOffsetAt(r9)
            goto L3e
        L3e:
            long r1 = offset(r1)
            goto Ld3
        L46:
            r1 = 16
            goto L4d
        L4d:
            int r0 = r0 + r1
            goto L13d
        L53:
            java.lang.string r9 = " is present but null: "
            goto L102
        L59:
            return
        L5a:
            goto L76
        L5e:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L16a
        L64:
            if (r5 == 0) goto L69
            goto La9
        L69:
            goto L4
        L6d:
            if (r5 == 0) goto L72
            goto L5a
        L72:
            goto L10a
        L76:
            java.lang.object r6 = r3.getobject(r7, r1)
            goto Lfa
        L7e:
            java.lang.string r6 = r6.tostring()
            goto Lcc
        L86:
            r0.<init>(r1)
            goto Lc4
        L8d:
            if (r9 == 0) goto L92
            goto Lee
        L92:
            goto Lbc
        L96:
            goto Lb8
        L99:
            goto Le0
        L9d:
            r8.mergeFrom(r5, r4)
            goto L15c
        La4:
            goto L99
        La7:
            goto L15f
        La9:
            goto L143
        Lad:
            java.lang.stringBuilder r6 = r0.append(r6)
            goto L53
        Lb5:
            goto L12b
        Lb8:
            goto La4
        Lbc:
            java.lang.object r9 = r8.newInstance()
            goto Ld9
        Lc4:
            int r6 = r6.numberAt(r9)
            goto Lad
        Lcc:
            r7.<init>(r6)
            goto L12f
        Ld3:
            sun.misc.Unsafe r3 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L12
        Ld9:
            r8.mergeFrom(r9, r6)
            goto L2a
        Le0:
            r0 = 32
            goto L46
        Le7:
            java.lang.IllegalStateException r7 = new java.lang.IllegalStateException
            goto L5e
        Led:
            r6 = r9
        Lee:
            goto Lb
        Lf2:
            java.lang.stringBuilder r6 = r6.append(r8)
            goto L7e
        Lfa:
            bool r9 = isMutable(r6)
            goto L8d
        L102:
            java.lang.stringBuilder r6 = r6.append(r9)
            goto Lf2
        L10a:
            bool r5 = isMutable(r4)
            goto L64
        L112:
            if (r0 <= 0) goto L117
            goto L12b
        L117:
            goto L128
        L11b:
            bool r5 = r6.isOneofPresent(r7, r0, r9)
            goto L6d
        L123:
            return
        L124:
            goto Le7
        L128:
            goto L130
        L12b:
            goto L14b
        L12f:
            throw r7
        L130:
            goto Lb5
        L134:
            if (r4 != 0) goto L139
            goto L124
        L139:
            goto L1a
        L13d:
            int r0 = r0 % r1
            goto L112
        L143:
            java.lang.object r5 = r8.newInstance()
            goto L9d
        L14b:
            int r0 = r6.numberAt(r9)
            goto L22
        L153:
            if (r1 == 0) goto L158
            goto L32
        L158:
            goto L31
        L15c:
            r3.putobject(r7, r1, r5)
        L15f:
            goto L163
        L163:
            r6.setOneofPresent(r7, r0, r9)
            goto L59
        L16a:
            java.lang.string r1 = "Source subfield "
            goto L86
    }

    private void MergeSingleField(T r6, T r7, int r8) {
            r5 = this;
            goto L332
        L4:
            r0 = 9
            goto L3d9
        Lb:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r6, r1, r7)
            goto L27c
        L12:
            goto L299
        L14:
            goto L24b
        L18:
            if (r0 != 0) goto L1d
            goto L299
        L1d:
            goto L318
        L21:
            return
        L22:
            goto L17e
        L26:
            r5.setFieldPresent(r6, r8)
            goto L2a2
        L2d:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L259
        L35:
            goto Lbe
        L38:
            goto L328
        L3c:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L300
        L44:
            if (r0 != 0) goto L49
            goto L299
        L49:
            goto L2d
        L4d:
            if (r0 != 0) goto L52
            goto L299
        L52:
            goto L1e9
        L56:
            java.lang.object r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L23c
        L5e:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L14b
        L66:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r6, r1, r3)
            goto L16f
        L6d:
            int r3 = r5.numberAt(r8)
            goto L43f
        L75:
            r5.setFieldPresent(r6, r8)
            goto L19d
        L7c:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L26
        L83:
            return
        L84:
            goto L309
        L88:
            r5.setFieldPresent(r6, r8)
            goto L1a7
        L8f:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L125
        L97:
            return
        L98:
            goto L2e2
        L9c:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto La4
        La4:
            if (r0 != 0) goto La9
            goto L299
        La9:
            goto L423
        Lad:
            r5.mergeMessage(r6, r7, r8)
            goto L3d4
        Lb4:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L205
        Lbb:
            goto L3d0
        Lbe:
            goto L1dc
        Lc2:
            double r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r7, r1)
            goto L1f6
        Lca:
            if (r0 != 0) goto Lcf
            goto L299
        Lcf:
            goto L56
        Ld3:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L4d
        Ldb:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r6, r1, r3)
            goto L104
        Le2:
            r5.mergeMessage(r6, r7, r8)
            goto L40a
        Le9:
            if (r0 != 0) goto Lee
            goto L299
        Lee:
            goto L15a
        Lf2:
            if (r0 != 0) goto Lf7
            goto L299
        Lf7:
            goto L2ea
        Lfb:
            if (r0 != 0) goto L100
            goto L299
        L100:
            goto L40f
        L104:
            r5.setFieldPresent(r6, r8)
            goto L83
        L10b:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putbool(r6, r1, r7)
            goto L196
        L112:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r6, r1, r3)
            goto L2f9
        L119:
            r5.mergeListsAt(r6, r7, r1)
            goto L2b5
        L120:
            return
        L121:
            goto L432
        L125:
            if (r0 != 0) goto L12a
            goto L299
        L12a:
            goto L5e
        L12e:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L1c2
        L136:
            androidx.datastore.preferences.protobuf.SchemaUtil.mergeDictionary(r5, r6, r7, r1)
            goto L21
        L13d:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto Lfb
        L145:
            int r0 = r0 % r1
            goto L283
        L14b:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r6, r1, r3)
            goto L42b
        L152:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L22e
        L15a:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L1ac
        L162:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto Le9
        L16a:
            return
        L16b:
            goto L152
        L16f:
            r5.setFieldPresent(r6, r8)
            goto L237
        L176:
            java.lang.object r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto Lb
        L17e:
            androidx.datastore.preferences.protobuf.ListFieldSchema r5 = r5.listFieldSchema
            goto L119
        L184:
            if (r0 != 0) goto L189
            goto L299
        L189:
            goto L2c1
        L18d:
            if (r0 != 0) goto L192
            goto L299
        L192:
            goto Lc2
        L196:
            r5.setFieldPresent(r6, r8)
            goto L3f6
        L19d:
            return
        L19e:
            goto L3e0
        L1a2:
            return
        L1a3:
            goto L3fb
        L1a7:
            return
        L1a8:
            goto Lad
        L1ac:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L75
        L1b3:
            r5.setFieldPresent(r6, r8)
            goto L1a2
        L1ba:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L66
        L1c2:
            if (r0 != 0) goto L1c7
            goto L299
        L1c7:
            goto L176
        L1cb:
            bool r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r7, r1)
            goto L10b
        L1d3:
            if (r0 != 0) goto L1d8
            goto L299
        L1d8:
            goto L1cb
        L1dc:
            int r0 = r5.typeAndOffsetAt(r8)
            goto L451
        L1e4:
            return
        L1e5:
            goto L243
        L1e9:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L7c
        L1f1:
            return
        L1f2:
            goto L252
        L1f6:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putdouble(r6, r1, r3)
            goto L296
        L1fd:
            bool r0 = r5.isOneofPresent(r7, r3, r8)
            goto L18
        L205:
            r5.setFieldPresent(r6, r8)
            goto L2a7
        L20c:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L2d1
        L214:
            return
        L215:
            goto L1fd
        L219:
            java.lang.object r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L44a
        L221:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r5 = r5.mapFieldSchema
            goto L136
        L227:
            r5.setFieldPresent(r6, r8)
            goto L291
        L22e:
            if (r0 != 0) goto L233
            goto L299
        L233:
            goto L1ba
        L237:
            return
        L238:
            goto L260
        L23c:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r6, r1, r7)
            goto L268
        L243:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L18d
        L24b:
            r5.mergeOneofMessage(r6, r7, r8)
            goto L214
        L252:
            r5.mergeOneofMessage(r6, r7, r8)
            goto L97
        L259:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L26f
        L260:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto Lf2
        L268:
            r5.setOneofPresent(r6, r3, r8)
            goto L43a
        L26f:
            r5.setFieldPresent(r6, r8)
            goto L16a
        L276:
            int r0 = r0 + r1
            goto L145
        L27c:
            r5.setFieldPresent(r6, r8)
            goto L417
        L283:
            if (r0 <= 0) goto L288
            goto Lbe
        L288:
            goto Lbb
        L28c:
            return
        L28d:
            goto Ld3
        L291:
            return
        L292:
            goto L13d
        L296:
            r5.setFieldPresent(r6, r8)
        L299:
            goto L341
        L29d:
            return
        L29e:
            goto L162
        L2a2:
            return
        L2a3:
            goto L8f
        L2a7:
            return
        L2a8:
            goto L3c
        L2ac:
            if (r0 != 0) goto L2b1
            goto L299
        L2b1:
            goto L219
        L2b5:
            return
        L2b6:
            goto Le2
        L2ba:
            r5.setOneofPresent(r6, r3, r8)
            goto L1f1
        L2c1:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto Lb4
        L2c9:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto Ldb
        L2d1:
            if (r0 != 0) goto L2d6
            goto L299
        L2d6:
            goto L339
        L2da:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L1d3
        L2e2:
            bool r0 = r5.isOneofPresent(r7, r3, r8)
            goto Lca
        L2ea:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L3e8
        L2f2:
            r5.setFieldPresent(r6, r8)
            goto L1e4
        L2f9:
            r5.setFieldPresent(r6, r8)
            goto L28c
        L300:
            if (r0 != 0) goto L305
            goto L299
        L305:
            goto L320
        L309:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L44
        L311:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putfloat(r6, r1, r7)
            goto L2f2
        L318:
            java.lang.object r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r7, r1)
            goto L403
        L320:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L41c
        L328:
            goto L335
        L32b:
            r5.setFieldPresent(r6, r8)
            goto L120
        L332:
            goto L38
        L335:
            goto L4
        L339:
            int r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r7, r1)
            goto L3ef
        L341:
            return
        L3d0:
            goto L35
        L3d4:
            return
        L3d5:
            goto L12e
        L3d9:
            r1 = 20
            goto L276
        L3e0:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L184
        L3e8:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putlong(r6, r1, r3)
            goto L227
        L3ef:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L32b
        L3f6:
            return
        L3f7:
            goto L20c
        L3fb:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L2ac
        L403:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r6, r1, r7)
            goto L2ba
        L40a:
            return
        L40b:
            goto L9c
        L40f:
            float r7 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r7, r1)
            goto L311
        L417:
            return
        L418:
            goto L2da
        L41c:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r6, r1, r7)
            goto L1b3
        L423:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r7, r1)
            goto L112
        L42b:
            r5.setFieldPresent(r6, r8)
            goto L29d
        L432:
            bool r0 = r5.isFieldPresent(r7, r8)
            goto L459
        L43a:
            return
        L43b:
            goto L221
        L43f:
            int r0 = type(r0)
            switch(r0) {
                case 0: goto L1e5;
                case 1: goto L292;
                case 2: goto L238;
                case 3: goto L16b;
                case 4: goto L84;
                case 5: goto L121;
                case 6: goto L3f7;
                case 7: goto L418;
                case 8: goto L3d5;
                case 9: goto L1a8;
                case 10: goto L1a3;
                case 11: goto L2a8;
                case 12: goto L19e;
                case 13: goto L29e;
                case 14: goto L2a3;
                case 15: goto L28d;
                case 16: goto L40b;
                case 17: goto L2b6;
                case 18: goto L22;
                case 19: goto L22;
                case 20: goto L22;
                case 21: goto L22;
                case 22: goto L22;
                case 23: goto L22;
                case 24: goto L22;
                case 25: goto L22;
                case 26: goto L22;
                case 27: goto L22;
                case 28: goto L22;
                case 29: goto L22;
                case 30: goto L22;
                case 31: goto L22;
                case 32: goto L22;
                case 33: goto L22;
                case 34: goto L22;
                case 35: goto L22;
                case 36: goto L22;
                case 37: goto L22;
                case 38: goto L22;
                case 39: goto L22;
                case 40: goto L22;
                case 41: goto L22;
                case 42: goto L22;
                case 43: goto L22;
                case 44: goto L22;
                case 45: goto L22;
                case 46: goto L22;
                case 47: goto L22;
                case 48: goto L22;
                case 49: goto L22;
                case 50: goto L43b;
                case 51: goto L98;
                case 52: goto L98;
                case 53: goto L98;
                case 54: goto L98;
                case 55: goto L98;
                case 56: goto L98;
                case 57: goto L98;
                case 58: goto L98;
                case 59: goto L98;
                case 60: goto L1f2;
                case 61: goto L215;
                case 62: goto L215;
                case 63: goto L215;
                case 64: goto L215;
                case 65: goto L215;
                case 66: goto L215;
                case 67: goto L215;
                case 68: goto L14;
                default: goto L446;
            }
        L446:
            goto L12
        L44a:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r6, r1, r7)
            goto L88
        L451:
            long r1 = offset(r0)
            goto L6d
        L459:
            if (r0 != 0) goto L45e
            goto L299
        L45e:
            goto L2c9
    }

    private java.lang.object MutableMessageFieldForMerge(T r4, int r5) {
            r3 = this;
            goto L4
        L4:
            goto L6e
        L7:
            goto L4e
        Lb:
            goto L7
        Le:
            int r0 = r0 + r1
            goto L1d
        L14:
            if (r3 != 0) goto L19
            goto L83
        L19:
            goto L80
        L1d:
            int r0 = r0 % r1
            goto L5d
        L23:
            java.lang.object r3 = r3.getobject(r4, r1)
            goto Lae
        L2b:
            sun.misc.Unsafe r3 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L23
        L31:
            bool r3 = r3.isFieldPresent(r4, r5)
            goto L8e
        L39:
            return r3
        L3a:
            goto L46
        L3e:
            int r1 = r3.typeAndOffsetAt(r5)
            goto L9e
        L46:
            java.lang.object r4 = r0.newInstance()
            goto L14
        L4e:
            r0 = 20
            goto L97
        L55:
            androidx.datastore.preferences.protobuf.Schema r0 = r3.getMessageFieldSchema(r5)
            goto L3e
        L5d:
            if (r0 <= 0) goto L62
            goto L8a
        L62:
            goto L87
        L66:
            return r3
        L67:
            goto L2b
        L6b:
            goto L8a
        L6e:
            goto Lb
        L72:
            if (r4 != 0) goto L77
            goto L3a
        L77:
            goto L39
        L7b:
            return r4
        L7c:
            goto L6b
        L80:
            r0.mergeFrom(r4, r3)
        L83:
            goto L7b
        L87:
            goto L7c
        L8a:
            goto L55
        L8e:
            if (r3 == 0) goto L93
            goto L67
        L93:
            goto La6
        L97:
            r1 = 7
            goto Le
        L9e:
            long r1 = offset(r1)
            goto L31
        La6:
            java.lang.object r3 = r0.newInstance()
            goto L66
        Lae:
            bool r4 = isMutable(r3)
            goto L72
    }

    private java.lang.object MutableOneofMessageFieldForMerge(T r4, int r5, int r6) {
            r3 = this;
            goto L87
        L4:
            r0 = 3
            goto L5c
        Lb:
            if (r4 != 0) goto L10
            goto L15
        L10:
            goto L14
        L14:
            return r3
        L15:
            goto Lae
        L19:
            int r0 = r0 + r1
            goto L96
        L1f:
            goto L7b
        L22:
            goto L9c
        L26:
            return r4
        L27:
            goto L1f
        L2b:
            long r1 = offset(r3)
            goto L63
        L33:
            bool r5 = r3.isOneofPresent(r4, r5, r6)
            goto La5
        L3b:
            if (r3 != 0) goto L40
            goto L58
        L40:
            goto L55
        L44:
            bool r4 = isMutable(r3)
            goto Lb
        L4c:
            if (r0 <= 0) goto L51
            goto L7b
        L51:
            goto L78
        L55:
            r0.mergeFrom(r4, r3)
        L58:
            goto L26
        L5c:
            r1 = 16
            goto L19
        L63:
            java.lang.object r3 = r5.getobject(r4, r1)
            goto L44
        L6b:
            return r3
        L6c:
            goto L9f
        L70:
            java.lang.object r3 = r0.newInstance()
            goto L6b
        L78:
            goto L27
        L7b:
            goto L8e
        L7f:
            int r3 = r3.typeAndOffsetAt(r6)
            goto L2b
        L87:
            goto L22
        L8a:
            goto L4
        L8e:
            androidx.datastore.preferences.protobuf.Schema r0 = r3.getMessageFieldSchema(r6)
            goto L33
        L96:
            int r0 = r0 % r1
            goto L4c
        L9c:
            goto L8a
        L9f:
            sun.misc.Unsafe r5 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L7f
        La5:
            if (r5 == 0) goto Laa
            goto L6c
        Laa:
            goto L70
        Lae:
            java.lang.object r4 = r0.newInstance()
            goto L3b
    }

    static <T> androidx.datastore.preferences.protobuf.MessageSchema<T> NewSchema(java.lang.Class<T> r0, androidx.datastore.preferences.protobuf.MessageInfo r1, androidx.datastore.preferences.protobuf.NewInstanceSchema r2, androidx.datastore.preferences.protobuf.ListFieldSchema r3, androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r4, androidx.datastore.preferences.protobuf.ExtensionSchema<object> r5, androidx.datastore.preferences.protobuf.DictionaryFieldSchema r6) {
            goto L31
        L4:
            androidx.datastore.preferences.protobuf.MessageSchema r0 = newSchemaForMessageInfo(r1, r2, r3, r4, r5, r6)
            goto L17
        Lc:
            androidx.datastore.preferences.protobuf.MessageSchema r0 = newSchemaForRawMessageInfo(r1, r2, r3, r4, r5, r6)
            goto L3e
        L14:
            goto L34
        L17:
            return r0
        L18:
            goto L14
        L1c:
            androidx.datastore.preferences.protobuf.StructuralMessageInfo r1 = (androidx.datastore.preferences.protobuf.StructuralMessageInfo) r1
            goto L4
        L22:
            androidx.datastore.preferences.protobuf.RawMessageInfo r1 = (androidx.datastore.preferences.protobuf.RawMessageInfo) r1
            goto Lc
        L28:
            if (r0 != 0) goto L2d
            goto L3f
        L2d:
            goto L22
        L31:
            goto L18
        L34:
            goto L38
        L38:
            bool r0 = r1 is androidx.datastore.preferences.protobuf.RawMessageInfo
            goto L28
        L3e:
            return r0
        L3f:
            goto L1c
    }

    static <T> androidx.datastore.preferences.protobuf.MessageSchema<T> NewSchemaForMessageInfo(androidx.datastore.preferences.protobuf.StructuralMessageInfo r20, androidx.datastore.preferences.protobuf.NewInstanceSchema r21, androidx.datastore.preferences.protobuf.ListFieldSchema r22, androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r23, androidx.datastore.preferences.protobuf.ExtensionSchema<object> r24, androidx.datastore.preferences.protobuf.DictionaryFieldSchema r25) {
            goto L1ee
        L4:
            if (r1 == 0) goto L9
            goto L2d0
        L9:
            goto L2ce
        Ld:
            if (r10 <= r11) goto L12
            goto L1d4
        L12:
            goto Lb0
        L16:
            r18 = r24
            goto L67
        L1c:
            storeFieldData(r2, r5, r12, r6)
            goto L1ce
        L23:
            r3 = r0[r3]
            goto L2a3
        L29:
            r15 = r14
        L2a:
            goto L207
        L2e:
            int[] r4 = androidx.datastore.preferences.protobuf.MessageSchema.EMPTY_INT_ARRAY
        L30:
            goto L8f
        L34:
            r17 = r12
            goto L2f5
        L3a:
            if (r11 == r10) goto L3f
            goto L146
        L3f:
            goto L165
        L43:
            r15 = r10
        L44:
            goto L385
        L48:
            r14 = r13
            goto L29
        L4d:
            int[] r3 = new int[r4]
            goto L298
        L53:
            int r2 = r3.length
            goto L2db
        L58:
            r7 = r2
            goto L2c4
        L5d:
            r7 = r1
            goto L62
        L62:
            r8 = r3
        L63:
            goto L24e
        L67:
            r19 = r25
            goto L78
        L6d:
            r13 = r12
            goto L48
        L72:
            int r3 = r3 + (-1)
            goto L23
        L78:
            r4 = r0
            goto L2d4
        L7d:
            r0 = 9
            goto L2ee
        L84:
            int r0 = r4.length
            goto L1e9
        L89:
            int r1 = r1 * 2
            goto L14a
        L8f:
            r9 = r2
            goto L107
        L94:
            int r2 = r3.length
            goto L1ba
        L99:
            r17 = r23
            goto L16
        L9f:
            r3 = r1
        La0:
            goto L2b6
        La4:
            r10 = 49
            goto L1fb
        Laa:
            goto L196
        Lac:
            goto L2b1
        Lb0:
            int r10 = r15 + 1
            goto L37d
        Lb6:
            r1[r15] = r2
            goto L43
        Lbc:
            int r9 = r1.length
            goto Lc1
        Lc1:
            java.lang.System.arraycopy(r1, r2, r12, r0, r9)
            goto L1de
        Lc8:
            if (r13 == r14) goto Lcd
            goto L21b
        Lcd:
            goto L360
        Ld1:
            int[] r4 = r20.getCheckInitialized()
            goto L180
        Ld9:
            r3[r14] = r12
            goto L1d3
        Ldf:
            int r9 = r3.length
            goto L13e
        Le4:
            int r11 = r11.id()
            goto L125
        Lec:
            int r0 = r0 % r1
            goto L232
        Lf2:
            goto L340
        Lf5:
            goto Lfe
        Lf9:
            r4 = r3
            goto L195
        Lfe:
            goto L1f1
        L101:
            r4[r13] = r12
            goto L145
        L107:
            r12 = r9
            goto L6d
        L10c:
            if (r9 < r2) goto L111
            goto L35c
        L111:
            goto L1a0
        L115:
            int r0 = r4.length
            goto Ldf
        L11a:
            int r3 = r3 + 1
            goto Laa
        L120:
            int r0 = r4.length
            goto L21f
        L125:
            if (r11 <= r10) goto L12a
            goto L1ae
        L12a:
            goto L1ac
        L12e:
            int r1 = r1.getFieldNumber()
            goto L2bf
        L136:
            androidx.datastore.preferences.protobuf.FieldType r13 = r12.getType()
            goto L38b
        L13e:
            java.lang.System.arraycopy(r3, r2, r12, r0, r9)
            goto L120
        L145:
            r13 = r10
        L146:
            goto L25b
        L14a:
            java.lang.object[] r6 = new java.lang.object[r1]
            goto L2c9
        L150:
            if (r1 == 0) goto L155
            goto L1c2
        L155:
            goto L58
        L159:
            int r2 = r14 + 1
            goto Ld9
        L15f:
            int[] r3 = androidx.datastore.preferences.protobuf.MessageSchema.EMPTY_INT_ARRAY
        L161:
            goto L4
        L165:
            int r10 = r13 + 1
            goto L101
        L16b:
            androidx.datastore.preferences.protobuf.FieldType r11 = androidx.datastore.preferences.protobuf.FieldType.MAP
            goto L36e
        L171:
            int r3 = r1 * 3
            goto L201
        L177:
            if (r13 < r11) goto L17c
            goto L146
        L17c:
            goto L377
        L180:
            if (r4 == 0) goto L185
            goto L30
        L185:
            goto L2e
        L189:
            r11 = 18
            goto L263
        L18f:
            r1 = r0[r2]
            goto L12e
        L195:
            r9 = r4
        L196:
            goto La4
        L19a:
            r10 = 49
            goto L22c
        L1a0:
            r2 = r0[r9]
            goto L253
        L1a6:
            int[] r12 = new int[r0]
            goto L84
        L1ac:
            int r9 = r9 + 1
        L1ae:
            goto L11a
        L1b2:
            int r10 = r10.id()
            goto L248
        L1ba:
            int r14 = r1 + r2
            goto L1e4
        L1c0:
            goto L63
        L1c2:
            goto L18f
        L1c6:
            int r10 = r10.id()
            goto L189
        L1ce:
            int r11 = r4.length
            goto L177
        L1d3:
            r14 = r2
        L1d4:
            goto L2ab
        L1d8:
            r12 = r0[r3]
            goto L136
        L1de:
            androidx.datastore.preferences.protobuf.MessageSchema r0 = new androidx.datastore.preferences.protobuf.MessageSchema
            goto L2e0
        L1e4:
            r11 = 1
            goto L354
        L1e9:
            r2 = 0
            goto L322
        L1ee:
            goto Lf5
        L1f1:
            goto L7d
        L1f5:
            int r0 = r0 + r1
            goto Lec
        L1fb:
            r11 = 18
            goto L311
        L201:
            int[] r5 = new int[r3]
            goto L89
        L207:
            int r2 = r0.length
            goto L10c
        L20c:
            if (r13 >= r11) goto L211
            goto L1ae
        L211:
            goto L344
        L215:
            int r2 = (int) r11
            goto Lb6
        L21a:
            goto L1ae
        L21b:
            goto L31a
        L21f:
            int r9 = r3.length
            goto L2fd
        L224:
            androidx.datastore.preferences.protobuf.FieldInfo[] r0 = r20.getFields()
            goto L30c
        L22c:
            r11 = 18
            goto L35a
        L232:
            if (r0 <= 0) goto L237
            goto L340
        L237:
            goto L33d
        L23b:
            int r2 = r1.length
            goto L307
        L240:
            int r13 = r13.id()
            goto L20c
        L248:
            r11 = 49
            goto Ld
        L24e:
            int r1 = r0.length
            goto L171
        L253:
            int r10 = r2.getFieldNumber()
            goto L1c
        L25b:
            androidx.datastore.preferences.protobuf.FieldType r10 = r2.getType()
            goto L16b
        L263:
            if (r10 >= r11) goto L268
            goto L1d4
        L268:
            goto L366
        L26c:
            int r13 = r4.length
            goto L329
        L271:
            int r12 = r17 + 3
            goto L19a
        L277:
            goto L44
        L279:
            goto L34c
        L27d:
            r3 = r2
            goto Lf9
        L282:
            int r0 = r4.length
            goto L53
        L287:
            androidx.datastore.preferences.protobuf.ProtoSyntax r10 = r20.getSyntax()
            goto L26c
        L28f:
            if (r4 > 0) goto L294
            goto L29a
        L294:
            goto L4d
        L298:
            goto La0
        L29a:
            goto L9f
        L29e:
            return r4
        L29f:
            goto Lf2
        L2a3:
            int r3 = r3.getFieldNumber()
            goto L5d
        L2ab:
            r17 = r12
            goto L277
        L2b1:
            r1 = 0
            goto L28f
        L2b6:
            if (r9 > 0) goto L2bb
            goto L339
        L2bb:
            goto L337
        L2bf:
            int r3 = r0.length
            goto L72
        L2c4:
            r8 = r7
            goto L1c0
        L2c9:
            int r1 = r0.length
            goto L27d
        L2ce:
            int[] r1 = androidx.datastore.preferences.protobuf.MessageSchema.EMPTY_INT_ARRAY
        L2d0:
            goto L282
        L2d4:
            r4.<init>(r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19)
            goto L29e
        L2db:
            int r0 = r0 + r2
            goto L23b
        L2e0:
            androidx.datastore.preferences.protobuf.MessageLite r9 = r20.getDefaultInstance()
            goto L287
        L2e8:
            r16 = r22
            goto L99
        L2ee:
            r1 = 10
            goto L1f5
        L2f5:
            long r11 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r2)
            goto L215
        L2fd:
            int r0 = r0 + r9
            goto Lbc
        L302:
            r2 = 0
            goto L150
        L307:
            int r0 = r0 + r2
            goto L1a6
        L30c:
            int r1 = r0.length
            goto L302
        L311:
            if (r3 < r1) goto L316
            goto Lac
        L316:
            goto L1d8
        L31a:
            androidx.datastore.preferences.protobuf.FieldType r13 = r12.getType()
            goto L240
        L322:
            java.lang.System.arraycopy(r4, r2, r12, r2, r0)
            goto L115
        L329:
            int r1 = r4.length
            goto L94
        L32e:
            if (r3 == 0) goto L333
            goto L161
        L333:
            goto L15f
        L337:
            int[] r1 = new int[r9]
        L339:
            goto Ld1
        L33d:
            goto L29f
        L340:
            goto L224
        L344:
            androidx.datastore.preferences.protobuf.FieldType r11 = r12.getType()
            goto Le4
        L34c:
            androidx.datastore.preferences.protobuf.FieldType r10 = r2.getType()
            goto L1c6
        L354:
            r15 = r21
            goto L2e8
        L35a:
            goto L2a
        L35c:
            goto L32e
        L360:
            int r4 = r4 + 1
            goto L21a
        L366:
            androidx.datastore.preferences.protobuf.FieldType r10 = r2.getType()
            goto L1b2
        L36e:
            if (r10 == r11) goto L373
            goto L279
        L373:
            goto L159
        L377:
            r11 = r4[r13]
            goto L3a
        L37d:
            java.lang.reflect.Field r2 = r2.getField()
            goto L34
        L385:
            int r9 = r9 + 1
            goto L271
        L38b:
            androidx.datastore.preferences.protobuf.FieldType r14 = androidx.datastore.preferences.protobuf.FieldType.MAP
            goto Lc8
    }

    static <T> androidx.datastore.preferences.protobuf.MessageSchema<T> NewSchemaForRawMessageInfo(androidx.datastore.preferences.protobuf.RawMessageInfo r33, androidx.datastore.preferences.protobuf.NewInstanceSchema r34, androidx.datastore.preferences.protobuf.ListFieldSchema r35, androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r36, androidx.datastore.preferences.protobuf.ExtensionSchema<object> r37, androidx.datastore.preferences.protobuf.DictionaryFieldSchema r38) {
            goto L5aa
        L4:
            r10[r1] = r3
        L6:
            goto L865
        La:
            int r4 = r5 << 20
            goto Le7
        L10:
            int r15 = r3 * 2
            goto Lec
        L16:
            int r12 = r10 + 1
            goto La20
        L1c:
            r0 = r31 | r0
            goto L4bf
        L22:
            r10[r1] = r15
        L24:
            goto L896
        L28:
            java.lang.string r2 = (java.lang.string) r2
            goto Lf1
        L2e:
            r2 = 55296(0xd800, float:7.7486E-41)
            goto L4f7
        L35:
            goto L24
        L36:
            goto Lbaa
        L3a:
            int r9 = r8 + 1
            goto L744
        L40:
            int r31 = r31 + 13
            goto L98f
        L46:
            java.lang.Class r3 = r2.getType()
            goto Le1
        L4e:
            r23 = r38
            goto L554
        L54:
            r13 = r13 & 8191(0x1fff, float:1.1478E-41)
            goto L9f6
        L5a:
            r7 = 0
        L5b:
            goto L8ef
        L5f:
            r19 = r1
        L61:
            goto La73
        L65:
            r12 = r14
        L66:
            goto L9e
        L6a:
            r1 = 9
            goto L711
        L70:
            r3 = r3 & 8191(0x1fff, float:1.1478E-41)
            goto Lca7
        L76:
            r4 = r23
        L78:
            goto Lbf3
        L7c:
            r24 = 1
            goto L76
        L82:
            int r3 = r3 << r8
            goto L840
        L87:
            int r11 = r10 + 1
            goto L4a6
        L8d:
            r0 = 18
            goto L280
        L93:
            r7 = r26
            goto L51b
        L99:
            r8 = r10
        L9a:
            goto L3a
        L9e:
            int r13 = r12 + 1
            goto L94c
        La4:
            r10 = r10 & 8191(0x1fff, float:1.1478E-41)
            goto L3cd
        Laa:
            r6 = r6 & 8191(0x1fff, float:1.1478E-41)
            goto L9fb
        Lb0:
            r14 = r14 & 8191(0x1fff, float:1.1478E-41)
            goto L82e
        Lb6:
            bool r0 = r15 is java.lang.reflect.Field
            goto L538
        Lbc:
            if (r10 >= r5) goto Lc1
            goto L6f2
        Lc1:
            goto L69f
        Lc5:
            r3 = r1
            goto L71a
        Lca:
            r1 = 30
            goto L34b
        Ld0:
            r27 = r3
            goto L84b
        Ld6:
            r0 = 536870912(0x20000000, float:1.0842022E-19)
            goto La36
        Ldc:
            r11 = r8
            goto Lc05
        Le1:
            r10[r1] = r3
        Le3:
            goto L5fa
        Le7:
            r0 = r0 | r4
            goto L3d8
        Lec:
            int r15 = r15 + r6
            goto L8af
        Lf1:
            java.lang.reflect.Field r2 = reflectField(r14, r2)
            goto L1f8
        Lf9:
            r0 = r4 & 512(0x200, float:7.17E-43)
            goto L763
        Lff:
            char r6 = r0[r6)
            goto L916
        L107:
            r23 = 13
            goto La0c
        L10d:
            int r11 = r11 << r12
            goto Lcc5
        L112:
            int r27 = r15 + 2
            goto L20f
        L118:
            r11 = 13
        L11a:
            goto L16
        L11e:
            int r16 = r14 + 1
            goto L981
        L124:
            char r3 = r0[r3)
            goto L1b2
        L12c:
            int r1 = r1 + 1
            goto Lbb5
        L132:
            r0 = r0 | r28
            goto L900
        L138:
            int r1 = r1 * 2
            goto L12c
        L13e:
            goto L1fa
        L140:
            goto L28
        L144:
            r26 = r1
            goto L5ea
        L14a:
            r30 = r0
            goto L5d7
        L150:
            int r11 = r11 << r12
            goto Lb80
        L155:
            r6 = 1
        L156:
            goto L693
        L15a:
            int r1 = r0.Length
            goto L4e1
        L162:
            r3 = r31
            goto L5bd
        L168:
            androidx.datastore.preferences.protobuf.ProtoSyntax r3 = androidx.datastore.preferences.protobuf.ProtoSyntax.PROTO2
            goto L881
        L16e:
            char r1 = r0[r1)
            goto L66c
        L176:
            long r1 = r9.objectFieldOffset(r2)
            goto L7c4
        L17e:
            int r23 = r7 / 32
            goto L310
        L184:
            r12 = r14
            goto L7ed
        L189:
            goto La0e
        L18b:
            goto L515
        L18f:
            r11 = r11 | r12
            goto L65
        L194:
            if (r8 >= r5) goto L199
            goto L399
        L199:
            goto L3d2
        L19d:
            r1 = 9
            goto L2d3
        L1a3:
            int[] r12 = new int[r15]
            goto L10
        L1a9:
            if (r11 >= r5) goto L1ae
            goto L4d8
        L1ae:
            goto L2c1
        L1b2:
            if (r3 >= r5) goto L1b7
            goto L156
        L1b7:
            goto Lac6
        L1bb:
            r17 = r13
            goto L8cc
        L1c1:
            if (r5 == r1) goto L1c6
            goto L2af
        L1c6:
            goto L2ad
        L1ca:
            androidx.datastore.preferences.protobuf.ProtoSyntax r14 = r33.getSyntax()
            goto Lcf6
        L1d2:
            int r1 = r20 / 3
            goto La00
        L1d8:
            r3 = r9
        L1d9:
            goto L9ba
        L1dd:
            r0 = r30
            goto Lc98
        L1e3:
            goto Lc33
        L1e5:
            goto L78a
        L1e9:
            if (r9 >= r5) goto L1ee
            goto L550
        L1ee:
            goto L304
        L1f2:
            r0 = 49
            goto L468
        L1f8:
            r13[r7] = r2
        L1fa:
            goto L176
        L1fe:
            r22 = r37
            goto L4e
        L204:
            r30 = r0
            goto Lb6
        L20a:
            r7 = r7 | r1
            goto L5b7
        L20f:
            r28 = r13[r31]
            goto L7af
        L215:
            int r0 = r22 + 1
            goto L6cf
        L21b:
            r2 = r13[r7]
            goto Lce7
        L221:
            int r13 = r13 + 13
            goto L184
        L227:
            int r15 = r13 + r11
            goto L933
        L22d:
            r8 = r10
            goto L39d
        L232:
            r1 = r4 & 2048(0x800, float:2.87E-42)
            goto L336
        L238:
            int r2 = (int) r2
            goto L6c3
        L23d:
            r0 = 0
        L23e:
            goto L1c
        L242:
            java.lang.reflect.Field r1 = (java.lang.reflect.Field) r1
            goto La8b
        L248:
            if (r5 >= r1) goto L24d
            goto L5bf
        L24d:
            goto La1a
        L251:
            goto Laf9
        L253:
            goto L6e5
        L257:
            r12 = r11
            goto L4f2
        L25c:
            char r12 = r0[r12)
            goto Lcd8
        L264:
            r3 = r1
            goto Lb2c
        L269:
            r1 = 12
            goto L2fb
        L26f:
            r3 = r3 | r6
            goto Lcbf
        L274:
            r23 = 13
        L276:
            goto La06
        L27a:
            r3 = r3 & 8191(0x1fff, float:1.1478E-41)
            goto L82
        L280:
            if (r5 >= r0) goto L285
            goto L82a
        L285:
            goto L1f2
        L289:
            if (r7 >= r5) goto L28e
            goto L51d
        L28e:
            goto L8ba
        L292:
            if (r4 >= r5) goto L297
            goto L7cb
        L297:
            goto L99b
        L29b:
            r12 = 13
        L29d:
            goto L77e
        L2a1:
            int r21 = r20 / 3
            goto L453
        L2a7:
            goto Lc39
        L2a9:
            goto L269
        L2ad:
            goto L74e
        L2af:
            goto L7f9
        L2b3:
            r7 = r7 | r3
            goto L62b
        L2b8:
            if (r4 >= r5) goto L2bd
            goto L18b
        L2bd:
            goto L87b
        L2c1:
            r11 = r11 & 8191(0x1fff, float:1.1478E-41)
            goto L150
        L2c7:
            int r1 = r19 + 1
            goto L4cb
        L2cd:
            int r1 = r15 + 3
            goto L67a
        L2d3:
            if (r2 != r1) goto L2d8
            goto L36
        L2d8:
            goto Lb14
        L2dc:
            int r23 = r23 + 13
            goto L462
        L2e2:
            if (r3 != 0) goto L2e7
            goto L7d7
        L2e7:
            goto Lc0a
        L2eb:
            r16 = r12
            goto L1bb
        L2f1:
            r4 = 0
        L2f2:
            goto Lb03
        L2f6:
            r12 = r12 | r13
            goto L330
        L2fb:
            if (r5 != r1) goto L300
            goto L74e
        L300:
            goto Lca
        L304:
            r9 = r9 & 8191(0x1fff, float:1.1478E-41)
            goto L118
        L30a:
            goto L627
        L30c:
            goto L3c7
        L310:
            int r3 = r3 + r23
            goto Lc84
        L316:
            if (r5 == r1) goto L31b
            goto L1e5
        L31b:
            goto L1e3
        L31f:
            r13 = r13 | r14
            goto L81c
        L324:
            r3 = r13[r31]
            goto L6a5
        L32a:
            r30 = r0
            goto L264
        L330:
            int r14 = r14 + 13
            goto Lae7
        L336:
            if (r1 != 0) goto L33b
            goto L897
        L33b:
            goto Lb85
        L33f:
            r27 = r3
            goto L74c
        L345:
            r1 = r26
            goto L9b4
        L34b:
            if (r5 != r1) goto L350
            goto L74e
        L350:
            goto Laec
        L354:
            r14 = r16
            goto L4fc
        L35a:
            r7 = r23
            goto L274
        L360:
            r7 = r7 | r1
            goto L40
        L365:
            int r15 = r15 + 2
            goto L8fa
        L36b:
            int[] r2 = new int[r2]
            goto L8d6
        L371:
            androidx.datastore.preferences.protobuf.ProtoSyntax r1 = r33.getSyntax()
            goto L64f
        L379:
            r4 = r23
            goto L107
        L37f:
            return r8
        L380:
            goto Ld06
        L384:
            int r12 = r12 << r13
            goto L18f
        L389:
            if (r6 >= r5) goto L38e
            goto L7d1
        L38e:
            goto Laa
        L392:
            bool r1 = r2 is java.lang.reflect.Field
            goto Lced
        L398:
            r9 = r11
        L399:
            goto Laa8
        L39d:
            goto L88c
        L39f:
            goto Lacb
        L3a3:
            if (r4 != 0) goto L3a8
            goto L79f
        L3a8:
            goto L938
        L3ac:
            if (r7 >= r15) goto L3b1
            goto L62d
        L3b1:
            goto L641
        L3b5:
            int r4 = r4 << r23
            goto Lc6a
        L3bb:
            r0 = r4 & 256(0x100, float:3.59E-43)
            goto Lc46
        L3c1:
            r10[r21] = r15
            goto Ld0
        L3c7:
            r29 = r2
            goto L59b
        L3cd:
            int r10 = r10 << r11
            goto L8ea
        L3d2:
            r8 = r8 & 8191(0x1fff, float:1.1478E-41)
            goto L427
        L3d8:
            r0 = r0 | r1
            goto L870
        L3dd:
            r15 = 13
        L3df:
            goto L11e
        L3e3:
            char r11 = r0[r11)
            goto Labd
        L3eb:
            r8 = r8 & 8191(0x1fff, float:1.1478E-41)
            goto L4e6
        L3f1:
            r1 = r2
            goto Lbbb
        L3f6:
            r16[r21] = r20
            goto L2a1
        L3fc:
            r3 = r3 | r6
            goto Lb9f
        L401:
            char r7 = r0[r7)
            goto L289
        L409:
            r27 = r3
            goto L168
        L40f:
            r3 = r28
        L411:
            goto Lafd
        L415:
            r0 = 4
            goto La7e
        L41c:
            r10[r1] = r15
            goto L35
        L422:
            r6 = r6 | r8
            goto L631
        L427:
            r10 = 13
        L429:
            goto L563
        L42d:
            r27 = r3
            goto L1d2
        L433:
            int r1 = r1 * 2
            goto L8e4
        L439:
            long r2 = r9.objectFieldOffset(r2)
            goto L238
        L441:
            r13 = r13 & 8191(0x1fff, float:1.1478E-41)
            goto L3dd
        L447:
            int r0 = r7 << 20
            goto L132
        L44d:
            r15 = r13[r15]
            goto L41c
        L453:
            int r21 = r21 * 2
            goto L112
        L459:
            if (r10 >= r5) goto L45e
            goto Lb47
        L45e:
            goto La4
        L462:
            r3 = r28
            goto L251
        L468:
            if (r5 <= r0) goto L46d
            goto L82a
        L46d:
            goto L215
        L471:
            r12 = r12 & 8191(0x1fff, float:1.1478E-41)
            goto L50f
        L477:
            if (r1 != 0) goto L47c
            goto Le3
        L47c:
            goto L9ea
        L480:
            int r10 = r8 + 1
            goto La6b
        L486:
            r27 = r3
            goto L7f3
        L48c:
            char r3 = r0[r3)
            goto L9db
        L494:
            r13 = 13
        L496:
            goto L706
        L49a:
            int r23 = r3 + 1
            goto Lb6c
        L4a0:
            r8 = 13
        L4a2:
            goto L617
        L4a6:
            char r10 = r0[r10)
            goto Lbc
        L4ae:
            bool r1 = r1.Equals(r2)
            goto L4b6
        L4b6:
            if (r1 == 0) goto L4bb
            goto L33b
        L4bb:
            goto L232
        L4bf:
            r4 = r4 & 2048(0x800, float:2.87E-42)
            goto L3a3
        L4c5:
            r28 = r1
            goto L91f
        L4cb:
            r16[r19] = r20
            goto L5f
        L4d1:
            goto L4a2
        L4d2:
            goto L9af
        L4d6:
            goto L29d
        L4d8:
            goto L10d
        L4dc:
            r10 = r8
            goto L93e
        L4e1:
            r2 = 0
            goto Lc8a
        L4e6:
            int r8 = r8 << r9
            goto L422
        L4eb:
            r5 = 55296(0xd800, float:7.7486E-41)
            goto Lbea
        L4f2:
            r15 = r12
            goto L80a
        L4f7:
            goto L543
        L4f8:
            goto Lbd5
        L4fc:
            goto L3df
        L4fe:
            goto L95a
        L502:
            goto L380
        L505:
            goto La28
        L509:
            int r0 = r0 % r1
            goto L925
        L50f:
            r14 = 13
        L511:
            goto Lcd2
        L515:
            int r4 = r4 << r23
            goto L606
        L51b:
            goto L276
        L51d:
            goto L90b
        L521:
            int r7 = r7 + 1
            goto L21b
        L527:
            if (r13 >= r5) goto L52c
            goto L7a5
        L52c:
            goto L54
        L530:
            goto L5ad
        L533:
            r8 = r2
            goto L4dc
        L538:
            if (r0 != 0) goto L53d
            goto L98b
        L53d:
            goto L5b1
        L541:
            r31 = 13
        L543:
            goto L816
        L547:
            char r4 = r0[r4)
            goto L2b8
        L54f:
            r10 = r12
        L550:
            goto L87
        L554:
            r18 = r8
            goto L758
        L55a:
            if (r5 == r1) goto L55f
            goto Lb10
        L55f:
            goto L6c9
        L563:
            int r11 = r9 + 1
            goto Lbc0
        L569:
            int r10 = r10 + 13
            goto L8d1
        L56f:
            int r23 = r23 + 13
            goto L58f
        L575:
            char r13 = r0[r13)
            goto Lc5b
        L57d:
            if (r1 != 0) goto L582
            goto L682
        L582:
            goto Lb39
        L586:
            if (r9 >= r5) goto L58b
            goto Lb0a
        L58b:
            goto L5dc
        L58f:
            r4 = r25
            goto L189
        L595:
            goto L36
        L597:
            goto Lb3f
        L59b:
            androidx.datastore.preferences.protobuf.MessageSchema r0 = new androidx.datastore.preferences.protobuf.MessageSchema
            goto L838
        L5a1:
            if (r12 >= r5) goto L5a6
            goto L68f
        L5a6:
            goto L471
        L5aa:
            goto Ld09
        L5ad:
            goto L415
        L5b1:
            java.lang.reflect.Field r15 = (java.lang.reflect.Field) r15
            goto L989
        L5b7:
            r1 = r32
        L5b9:
            goto Lcad
        L5bd:
            goto L411
        L5bf:
            goto L890
        L5c3:
            int r7 = r7 << r23
            goto L701
        L5c9:
            int r12 = r12 << r13
            goto L876
        L5ce:
            if (r2 == r1) goto L5d3
            goto L897
        L5d3:
            goto L371
        L5d7:
            r0 = r1
            goto L95f
        L5dc:
            r9 = r9 & 8191(0x1fff, float:1.1478E-41)
            goto L7e1
        L5e2:
            androidx.datastore.preferences.protobuf.MessageLite r14 = r33.getDefaultInstance()
            goto L965
        L5ea:
            r1 = r4 & 1024(0x400, float:1.435E-42)
            goto Lbe1
        L5f0:
            r6 = r6 | r8
            goto L99
        L5f5:
            int r10 = r10 << r11
            goto Lbd0
        L5fa:
            r1 = r31
        L5fc:
            goto L439
        L600:
            r28 = r0
            goto Lf9
        L606:
            r3 = r3 | r4
            goto L790
        L60b:
            int r11 = r11 + 13
            goto Lb8b
        L611:
            r22 = r8
            goto Lbf9
        L617:
            int r9 = r3 + 1
            goto Lc9f
        L61d:
            char r13 = r0[r13)
            goto L527
        L625:
            r20 = 0
        L627:
            goto L7b5
        L62b:
            goto Lb1c
        L62d:
            goto Lb1a
        L631:
            int r9 = r9 + 13
            goto L22d
        L637:
            int r0 = (int) r0
            goto Lb66
        L63c:
            int r9 = r9 << r10
            goto L911
        L641:
            r7 = r7 & 8191(0x1fff, float:1.1478E-41)
            goto Laf7
        L647:
            char r3 = r0[r3)
            goto Lade
        L64f:
            androidx.datastore.preferences.protobuf.ProtoSyntax r2 = androidx.datastore.preferences.protobuf.ProtoSyntax.PROTO2
            goto L4ae
        L655:
            int r3 = r7 + 1
            goto L8dc
        L65b:
            r7 = r26
            goto L7c9
        L661:
            r12 = r12 & 8191(0x1fff, float:1.1478E-41)
            goto L5c9
        L667:
            r13 = r13 | r14
            goto L9e4
        L66c:
            if (r1 >= r2) goto L671
            goto L4f8
        L671:
            goto Ld00
        L675:
            r3 = 1
        L676:
            goto L699
        L67a:
            r15 = r13[r27]
            goto L3c1
        L680:
            goto L5fc
        L682:
            goto L995
        L686:
            java.lang.reflect.Field r2 = reflectField(r14, r2)
            goto L752
        L68e:
            r13 = r15
        L68f:
            goto L9a9
        L693:
            int r3 = r6 + 1
            goto Lff
        L699:
            int r6 = r3 + 1
            goto L124
        L69f:
            r10 = r10 & 8191(0x1fff, float:1.1478E-41)
            goto L29b
        L6a5:
            r10[r1] = r3
            goto Lc37
        L6ab:
            r1 = r13[r7]
            goto L810
        L6b1:
            int r7 = r7 * 2
            goto L6ab
        L6b7:
            r0 = 268435456(0x10000000, float:2.524355E-29)
            goto Lc55
        L6bd:
            int r1 = r1 + 1
            goto L46
        L6c3:
            r3 = r4 & 4096(0x1000, float:5.74E-42)
            goto L2e2
        L6c9:
            int r1 = r21 + 1
            goto L3f6
        L6cf:
            r16[r22] = r2
            goto L828
        L6d5:
            char r6 = r0[r6)
            goto La3c
        L6dd:
            char r11 = r0[r11)
            goto L1a9
        L6e5:
            int r3 = r3 << r23
            goto L2b3
        L6eb:
            r1 = r4 & 2048(0x800, float:2.87E-42)
            goto L477
        L6f1:
            r11 = r13
        L6f2:
            goto Lcb9
        L6f6:
            java.lang.string r15 = (java.lang.string) r15
            goto Lbc8
        L6fc:
            r7 = 0
            goto L778
        L701:
            r4 = r4 | r7
            goto L772
        L706:
            int r14 = r12 + 1
            goto L25c
        L70c:
            r8 = r8 | r9
            goto L569
        L711:
            if (r5 != r1) goto L716
            goto Lc33
        L716:
            goto Lb74
        L71a:
            long r0 = r9.objectFieldOffset(r15)
            goto L637
        L722:
            int r27 = r20 + 2
            goto L600
        L728:
            r8 = r0
            goto L796
        L72d:
            int r20 = r20 + 3
            goto L447
        L733:
            char r9 = r0[r9)
            goto L1e9
        L73b:
            if (r2 != 0) goto L740
            goto La8c
        L740:
            goto L242
        L744:
            char r8 = r0[r8)
            goto L194
        L74c:
            goto Le3
        L74e:
            goto La12
        L752:
            r31 = r1
            goto L6a
        L758:
            r9 = r29
            goto L728
        L75e:
            r6 = r6 | r3
            goto L1d8
        L763:
            if (r0 != 0) goto L768
            goto La38
        L768:
            goto Ld6
        L76c:
            r19 = 0
            goto L625
        L772:
            int r23 = r23 + 13
            goto L93
        L778:
            r27 = r3
            goto L162
        L77e:
            int r13 = r11 + 1
            goto L6dd
        L784:
            r27 = r3
            goto Lb0e
        L78a:
            r1 = 27
            goto Lc75
        L790:
            r4 = r25
            goto Lbff
        L796:
            r8.<init>(r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23)
            goto L37f
        L79d:
            goto L2f2
        L79f:
            goto L2f1
        L7a3:
            goto L511
        L7a5:
            goto L857
        L7a9:
            r28 = r7
            goto L5a
        L7af:
            r10[r21] = r28
            goto L4c5
        L7b5:
            if (r3 < r1) goto L7ba
            goto L30c
        L7ba:
            goto L49a
        L7be:
            r31 = r1
            goto L19d
        L7c4:
            int r1 = (int) r1
            goto L14a
        L7c9:
            goto L8c8
        L7cb:
            goto L8c6
        L7cf:
            goto Lc66
        L7d1:
            goto L92e
        L7d5:
            goto L5b
        L7d7:
            goto L32a
        L7db:
            r3 = r3 & 8191(0x1fff, float:1.1478E-41)
            goto L379
        L7e1:
            int r9 = r9 << r10
            goto L70c
        L7e6:
            r2 = 55296(0xd800, float:7.7486E-41)
            goto Lc16
        L7ed:
            goto L496
        L7ef:
            goto L384
        L7f3:
            int r1 = r20 / 3
            goto La85
        L7f9:
            r1 = 50
            goto L55a
        L7ff:
            int r1 = r1 * 2
            goto Lb4b
        L805:
            int r1 = (int) r1
            goto L521
        L80a:
            r17 = r15
            goto Lba4
        L810:
            bool r2 = r1 is java.lang.reflect.Field
            goto L73b
        L816:
            int r32 = r1 + 1
            goto L16e
        L81c:
            r14 = r16
        L81e:
            goto L227
        L822:
            int r9 = r6 + 1
            goto L973
        L828:
            r22 = r0
        L82a:
            goto Lbb0
        L82e:
            int r14 = r14 << r15
            goto L667
        L833:
            r6 = r9
            goto L7cf
        L838:
            androidx.datastore.preferences.protobuf.MessageLite r13 = r33.getDefaultInstance()
            goto L1ca
        L840:
            r6 = r6 | r3
            goto L8a9
        L845:
            int r6 = r3 + 1
            goto L647
        L84b:
            r21 = r28
            goto L680
        L851:
            int r1 = r1 + 1
            goto L365
        L857:
            int r13 = r13 << r14
            goto L9ce
        L85c:
            if (r3 >= r5) goto L861
            goto L4d2
        L861:
            goto L27a
        L865:
            r1 = r15
            goto Lc31
        L86a:
            r2 = r13[r15]
            goto L9c8
        L870:
            r29[r2] = r0
            goto L72d
        L876:
            r11 = r11 | r12
            goto L221
        L87b:
            r4 = r4 & 8191(0x1fff, float:1.1478E-41)
            goto L3b5
        L881:
            if (r1 != r3) goto L886
            goto L47c
        L886:
            goto L6eb
        L88a:
            r9 = 13
        L88c:
            goto L480
        L890:
            int r1 = r15 + 1
            goto L86a
        L896:
            r15 = r2
        L897:
            goto L6b1
        L89b:
            r31 = r0
            goto L3bb
        L8a1:
            java.lang.reflect.Field r1 = reflectField(r14, r1)
            goto Lad0
        L8a9:
            int r8 = r8 + 13
            goto Lb61
        L8af:
            r6 = r11
            goto Ldc
        L8b4:
            r5 = r4 & 255(0xff, float:3.57E-43)
            goto L144
        L8ba:
            r7 = r7 & 8191(0x1fff, float:1.1478E-41)
            goto L5c3
        L8c0:
            goto L676
        L8c2:
            goto L155
        L8c6:
            r7 = r23
        L8c8:
            goto L8b4
        L8cc:
            r3 = r14
            goto L906
        L8d1:
            r9 = r11
            goto Lb08
        L8d6:
            int r10 = r10 * 2
            goto La65
        L8dc:
            char r7 = r0[r7)
            goto Lb51
        L8e4:
            int r1 = r1 + 1
            goto Lc10
        L8ea:
            r9 = r9 | r10
            goto L60b
        L8ef:
            r1 = r0
            goto L8d
        L8f4:
            int r12 = r12 + 13
            goto L9c3
        L8fa:
            r3 = r13[r31]
            goto L4
        L900:
            r29[r27] = r0
            goto L345
        L906:
            r12 = r9
        L907:
            goto Lbdb
        L90b:
            int r7 = r7 << r23
            goto La54
        L911:
            r8 = r8 | r9
            goto L398
        L916:
            if (r6 >= r5) goto L91b
            goto L1d9
        L91b:
            goto La30
        L91f:
            r1 = r4 & 2048(0x800, float:2.87E-42)
            goto L57d
        L925:
            if (r0 <= 0) goto L92a
            goto L505
        L92a:
            goto L502
        L92e:
            int r6 = r6 << r8
            goto L3fc
        L933:
            int r15 = r15 + r12
            goto L1a3
        L938:
            r4 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L79d
        L93e:
            r11 = r10
            goto L257
        L943:
            if (r14 >= r5) goto L948
            goto L4fe
        L948:
            goto Lb0
        L94c:
            char r12 = r0[r12)
            goto L5a1
        L954:
            r29[r20] = r27
            goto L722
        L95a:
            int r14 = r14 << r15
            goto L31f
        L95f:
            r1 = r27
            goto L6fc
        L965:
            java.lang.Class r14 = r14.GetType()
            goto L96d
        L96d:
            int r2 = r10 * 3
            goto L36b
        L973:
            char r6 = r0[r6)
            goto L389
        L97b:
            int r28 = r3 + 1
            goto L48c
        L981:
            char r14 = r0[r14)
            goto L943
        L989:
            goto Lc80
        L98b:
            goto L6f6
        L98f:
            r1 = r32
            goto L2e
        L995:
            r1 = r27
            goto Lb99
        L99b:
            r4 = r4 & 8191(0x1fff, float:1.1478E-41)
            goto L35a
        L9a1:
            java.lang.object[] r13 = r33.getobjects()
            goto L5e2
        L9a9:
            int r14 = r13 + 1
            goto L575
        L9af:
            int r3 = r3 << r8
            goto L75e
        L9b4:
            r2 = r29
            goto L1dd
        L9ba:
            if (r6 == 0) goto L9bf
            goto Ld0f
        L9bf:
            goto La90
        L9c3:
            r11 = r13
            goto L4d6
        L9c8:
            java.lang.string r2 = (java.lang.string) r2
            goto L686
        L9ce:
            r12 = r12 | r13
            goto L68e
        L9d3:
            char r7 = r0[r7)
            goto L7e6
        L9db:
            if (r3 >= r15) goto L9e0
            goto L253
        L9e0:
            goto L70
        L9e4:
            int r15 = r15 + 13
            goto L354
        L9ea:
            int r1 = r20 / 3
            goto L7ff
        L9f0:
            r21 = r36
            goto L1fe
        L9f6:
            int r13 = r13 << r14
            goto L2f6
        L9fb:
            int r6 = r6 << r8
            goto L26f
        La00:
            int r1 = r1 * 2
            goto L851
        La06:
            int r26 = r7 + 1
            goto L401
        La0c:
            r24 = 1
        La0e:
            goto La4e
        La12:
            androidx.datastore.preferences.protobuf.ProtoSyntax r1 = r33.getSyntax()
            goto L409
        La1a:
            int r1 = r7 + 1
            goto L9d3
        La20:
            char r10 = r0[r10)
            goto L459
        La28:
            java.lang.string r0 = r33.getstringInfo()
            goto L15a
        La30:
            r6 = r6 & 8191(0x1fff, float:1.1478E-41)
            goto L4a0
        La36:
            goto Laf3
        La38:
            goto Laf2
        La3c:
            if (r6 >= r5) goto La41
            goto L9a
        La41:
            goto Lb33
        La45:
            if (r5 == r1) goto La4a
            goto L2a9
        La4a:
            goto L2a7
        La4e:
            int r25 = r4 + 1
            goto L547
        La54:
            r4 = r4 | r7
            goto L65b
        La59:
            int r1 = r1 << r31
            goto L360
        La5f:
            java.lang.reflect.Field r2 = (java.lang.reflect.Field) r2
            goto L13e
        La65:
            java.lang.object[] r10 = new java.lang.object[r10]
            goto Lc1f
        La6b:
            char r8 = r0[r8)
            goto Lc3d
        La73:
            r1 = 51
            goto La96
        La79:
            r6 = r3
            goto L2eb
        La7e:
            r1 = 10
            goto Lc25
        La85:
            int r1 = r1 * 2
            goto L6bd
        La8b:
            goto Lad2
        La8c:
            goto Lb26
        La90:
            int[] r6 = androidx.datastore.preferences.protobuf.MessageSchema.EMPTY_INT_ARRAY
            goto L533
        La96:
            r29 = r2
            goto L248
        La9c:
            r3 = r3 & 8191(0x1fff, float:1.1478E-41)
            goto Lc64
        Laa2:
            int r8 = r6 + 1
            goto L6d5
        Laa8:
            int r10 = r9 + 1
            goto L733
        Laae:
            r1 = 49
            goto La45
        Lab4:
            if (r2 == r1) goto Lab9
            goto L597
        Lab9:
            goto L595
        Labd:
            if (r11 >= r5) goto Lac2
            goto L66
        Lac2:
            goto Lc4f
        Lac6:
            r3 = r6
            goto L8c0
        Lacb:
            int r8 = r8 << r9
            goto L5f0
        Lad0:
            r13[r7] = r1
        Lad2:
            goto Lcca
        Lad6:
            char r4 = r0[r4)
            goto L292
        Lade:
            if (r3 >= r5) goto Lae3
            goto Lba0
        Lae3:
            goto La9c
        Lae7:
            r13 = r15
            goto L7a3
        Laec:
            r1 = 44
            goto L1c1
        Laf2:
            r0 = 0
        Laf3:
            goto L89b
        Laf7:
            r23 = 13
        Laf9:
            goto L97b
        Lafd:
            int r2 = r20 + 1
            goto L954
        Lb03:
            r0 = r0 | r4
            goto La
        Lb08:
            goto L429
        Lb0a:
            goto L63c
        Lb0e:
            goto L5fc
        Lb10:
            goto L33f
        Lb14:
            r1 = 17
            goto Lab4
        Lb1a:
            r28 = r3
        Lb1c:
            goto Lb20
        Lb20:
            int r3 = r6 * 2
            goto L17e
        Lb26:
            java.lang.string r1 = (java.lang.string) r1
            goto L8a1
        Lb2c:
            r0 = 1048575(0xfffff, float:1.469367E-39)
            goto L7a9
        Lb33:
            r6 = r6 & 8191(0x1fff, float:1.1478E-41)
            goto L88a
        Lb39:
            int r21 = r21 + 1
            goto L2cd
        Lb3f:
            r1 = 12
            goto L5ce
        Lb45:
            goto L11a
        Lb47:
            goto L5f5
        Lb4b:
            int r1 = r1 + 1
            goto Lc2b
        Lb51:
            r15 = 55296(0xd800, float:7.7486E-41)
            goto L3ac
        Lb58:
            if (r3 >= r5) goto Lb5d
            goto Lc01
        Lb5d:
            goto L7db
        Lb61:
            r3 = r9
            goto L4d1
        Lb66:
            int r7 = r7 % 32
            goto L7d5
        Lb6c:
            char r3 = r0[r3)
            goto Lb58
        Lb74:
            r1 = 17
            goto L316
        Lb7a:
            r7 = r7 & 8191(0x1fff, float:1.1478E-41)
            goto L541
        Lb80:
            r10 = r10 | r11
            goto L8f4
        Lb85:
            int r1 = r20 / 3
            goto L138
        Lb8b:
            r10 = r12
            goto Lb45
        Lb90:
            if (r5 <= r3) goto Lb95
            goto L7d7
        Lb95:
            goto L655
        Lb99:
            r21 = r28
            goto L784
        Lb9f:
            r6 = r9
        Lba0:
            goto Laa2
        Lba4:
            r16 = r6
            goto Lc6f
        Lbaa:
            int r1 = r20 / 3
            goto L433
        Lbb0:
            r0 = r1
            goto L3f1
        Lbb5:
            int r2 = r15 + 1
            goto L44d
        Lbbb:
            r15 = r3
            goto L40f
        Lbc0:
            char r9 = r0[r9)
            goto L586
        Lbc8:
            java.lang.reflect.Field r15 = reflectField(r14, r15)
            goto Lc7e
        Lbd0:
            r9 = r9 | r10
            goto L54f
        Lbd5:
            int r1 = r1 << r31
            goto L20a
        Lbdb:
            sun.misc.Unsafe r9 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L9a1
        Lbe1:
            if (r1 != 0) goto Lbe6
            goto L61
        Lbe6:
            goto L2c7
        Lbea:
            if (r3 >= r5) goto Lbef
            goto L8c2
        Lbef:
            goto L675
        Lbf3:
            int r23 = r4 + 1
            goto Lad6
        Lbf9:
            r21 = r17
            goto L76c
        Lbff:
            goto L78
        Lc01:
            goto L7c
        Lc05:
            r8 = r6
            goto La79
        Lc0a:
            r3 = 17
            goto Lb90
        Lc10:
            int r2 = r15 + 1
            goto Lc92
        Lc16:
            if (r7 >= r2) goto Lc1b
            goto L5b9
        Lc1b:
            goto Lb7a
        Lc1f:
            int r8 = r17 + r8
            goto L611
        Lc25:
            int r0 = r0 + r1
            goto L509
        Lc2b:
            int r15 = r15 + 2
            goto L324
        Lc31:
            goto L5fc
        Lc33:
            goto L486
        Lc37:
            goto L6
        Lc39:
            goto L42d
        Lc3d:
            if (r8 >= r5) goto Lc42
            goto L39f
        Lc42:
            goto L3eb
        Lc46:
            if (r0 != 0) goto Lc4b
            goto Lc57
        Lc4b:
            goto L6b7
        Lc4f:
            r11 = r11 & 8191(0x1fff, float:1.1478E-41)
            goto L494
        Lc55:
            goto L23e
        Lc57:
            goto L23d
        Lc5b:
            if (r13 >= r5) goto Lc60
            goto L81e
        Lc60:
            goto L441
        Lc64:
            r8 = 13
        Lc66:
            goto L822
        Lc6a:
            r3 = r3 | r4
            goto L56f
        Lc6f:
            r6 = r17
            goto Ld0d
        Lc75:
            if (r5 != r1) goto Lc7a
            goto Lc39
        Lc7a:
            goto Laae
        Lc7e:
            r13[r3] = r15
        Lc80:
            goto Lc5
        Lc84:
            r15 = r13[r3]
            goto L204
        Lc8a:
            char r3 = r0[r2)
            goto L4eb
        Lc92:
            r15 = r13[r15]
            goto L22
        Lc98:
            r5 = 55296(0xd800, float:7.7486E-41)
            goto L30a
        Lc9f:
            char r3 = r0[r3)
            goto L85c
        Lca7:
            int r3 = r3 << r23
            goto Lcfb
        Lcad:
            int r2 = r5 + (-51)
            goto L7be
        Lcb3:
            r19 = r34
            goto Lce1
        Lcb9:
            int r12 = r11 + 1
            goto L3e3
        Lcbf:
            int r8 = r8 + 13
            goto L833
        Lcc5:
            r10 = r10 | r11
            goto L6f1
        Lcca:
            long r1 = r9.objectFieldOffset(r1)
            goto L805
        Lcd2:
            int r15 = r13 + 1
            goto L61d
        Lcd8:
            if (r12 >= r5) goto Lcdd
            goto L7ef
        Lcdd:
            goto L661
        Lce1:
            r20 = r35
            goto L9f0
        Lce7:
            r27 = r1
            goto L392
        Lced:
            if (r1 != 0) goto Lcf2
            goto L140
        Lcf2:
            goto La5f
        Lcf6:
            r15 = 0
            goto Lcb3
        Lcfb:
            r7 = r7 | r3
            goto L2dc
        Ld00:
            r1 = r1 & 8191(0x1fff, float:1.1478E-41)
            goto La59
        Ld06:
            goto L505
        Ld09:
            goto L530
        Ld0d:
            goto L907
        Ld0f:
            goto L845
    }

    private int NumberAt(int r1) {
            r0 = this;
            goto L4
        L4:
            goto L1b
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int[] r0 = r0.buffer
            goto L14
        L14:
            r0 = r0[r1]
            goto L1a
        L1a:
            return r0
        L1b:
            goto Lb
    }

    private static long Offset(int r2) {
            goto L33
        L4:
            return r0
        L5:
            goto Le
        L9:
            long r0 = (long) r2
            goto L4
        Le:
            goto L4b
        L11:
            goto L22
        L15:
            int r0 = r0 % r1
            goto L3a
        L1b:
            r0 = 25
            goto L2c
        L22:
            goto L36
        L25:
            r0 = 1048575(0xfffff, float:1.469367E-39)
            goto L43
        L2c:
            r1 = 11
            goto L4f
        L33:
            goto L11
        L36:
            goto L1b
        L3a:
            if (r0 <= 0) goto L3f
            goto L4b
        L3f:
            goto L48
        L43:
            r2 = r2 & r0
            goto L9
        L48:
            goto L5
        L4b:
            goto L25
        L4f:
            int r0 = r0 + r1
            goto L15
    }

    private static <T> bool OneofboolAt(T r0, long r1) {
            goto L1f
        L4:
            java.lang.bool r0 = (java.lang.bool) r0
            goto L17
        La:
            java.lang.object r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r0, r1)
            goto L4
        L12:
            return r0
        L13:
            goto L26
        L17:
            bool r0 = r0.boolValue()
            goto L12
        L1f:
            goto L13
        L22:
            goto La
        L26:
            goto L22
    }

    private static <T> double OneofdoubleAt(T r0, long r1) {
            goto L22
        L4:
            double r0 = r0.doubleValue()
            goto L14
        Lc:
            java.lang.object r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r0, r1)
            goto L19
        L14:
            return r0
        L15:
            goto L1f
        L19:
            java.lang.double r0 = (java.lang.double) r0
            goto L4
        L1f:
            goto L25
        L22:
            goto L15
        L25:
            goto Lc
    }

    private static <T> float OneoffloatAt(T r0, long r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L26
        L9:
            java.lang.object r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r0, r1)
            goto L20
        L11:
            goto L5
        L14:
            goto L9
        L18:
            float r0 = r0.floatValue()
            goto L4
        L20:
            java.lang.float r0 = (java.lang.float) r0
            goto L18
        L26:
            goto L14
    }

    private static <T> int OneofIntAt(T r0, long r1) {
            goto L22
        L4:
            int r0 = r0.intValue()
            goto L1d
        Lc:
            goto L25
        Lf:
            java.lang.object r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r0, r1)
            goto L17
        L17:
            java.lang.int r0 = (java.lang.int) r0
            goto L4
        L1d:
            return r0
        L1e:
            goto Lc
        L22:
            goto L1e
        L25:
            goto Lf
    }

    private static <T> long OneoflongAt(T r0, long r1) {
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
            java.lang.object r0 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r0, r1)
            goto L23
        L1b:
            long r0 = r0.longValue()
            goto L4
        L23:
            java.lang.long r0 = (java.lang.long) r0
            goto L1b
    }

    private <K, V> int ParseDictionaryField(T r10, byte[] r11, int r12, int r13, int r14, long r15, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r17) throws java.io.IOException {
            r9 = this;
            goto L52
        L4:
            int r0 = r0.decodeDictionaryEntry(r1, r2, r3, r4, r5, r6)
            goto Lc
        Lc:
            return r0
        Ld:
            goto Lc6
        L11:
            r6 = r7
        L12:
            goto L88
        L16:
            r0 = r9
            goto Ld6
        L1b:
            sun.misc.Unsafe r4 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L35
        L21:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r1 = r9.mapFieldSchema
            goto L74
        L27:
            r4.putobject(r10, r2, r7)
            goto L11
        L2e:
            goto Ld
        L31:
            goto L6f
        L35:
            java.lang.object r5 = r9.getDictionaryFieldDefaultEntry(r14)
            goto L4a
        L3d:
            int r0 = r0 % r1
            goto Lcd
        L43:
            r0 = 27
            goto L93
        L4a:
            java.lang.object r6 = r4.getobject(r10, r2)
            goto L61
        L52:
            goto Lc9
        L55:
            goto L43
        L59:
            androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata r4 = r1.forDictionaryMetadata(r5)
            goto L21
        L61:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r7 = r9.mapFieldSchema
            goto L67
        L67:
            bool r7 = r7.isImmutable(r6)
            goto La1
        L6f:
            r2 = r15
            goto L1b
        L74:
            java.util.Dictionary r5 = r1.forMutableDictionaryData(r6)
            goto L16
        L7c:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r7 = r9.mapFieldSchema
            goto Laa
        L82:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r8 = r9.mapFieldSchema
            goto L9a
        L88:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r1 = r9.mapFieldSchema
            goto L59
        L8e:
            r3 = r13
            goto Lbb
        L93:
            r1 = 4
            goto Lb5
        L9a:
            r8.mergeFrom(r7, r6)
            goto L27
        La1:
            if (r7 != 0) goto La6
            goto L12
        La6:
            goto L7c
        Laa:
            java.lang.object r7 = r7.newDictionaryField(r5)
            goto L82
        Lb2:
            goto L55
        Lb5:
            int r0 = r0 + r1
            goto L3d
        Lbb:
            r6 = r17
            goto L4
        Lc1:
            r2 = r12
            goto L8e
        Lc6:
            goto L31
        Lc9:
            goto Lb2
        Lcd:
            if (r0 <= 0) goto Ld2
            goto L31
        Ld2:
            goto L2e
        Ld6:
            r1 = r11
            goto Lc1
    }

    private int ParseOneofField(T r15, byte[] r16, int r17, int r18, int r19, int r20, int r21, int r22, int r23, long r24, int r26, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r27) throws java.io.IOException {
            r14 = this;
            goto L13e
        L4:
            r2 = r21
            goto L3b4
        La:
            r10 = 5
            goto L249
        Lf:
            int r2 = r13.int1
            goto L136
        L15:
            r14 = r16
            goto L493
        L1b:
            r5.putobject(r15, r3, r14)
            goto L4f7
        L22:
            r5 = r18
            goto L1c1
        L28:
            if (r1 != 0) goto L2d
            goto L4ec
        L2d:
            goto L4ea
        L31:
            r13 = r27
            goto L12d
        L37:
            return r14
        L38:
            goto L3cb
        L3c:
            r11 = r16
            goto Ld9
        L42:
            return r1
        L43:
            goto L62
        L47:
            if (r2 == r11) goto L4c
            goto L38
        L4c:
            goto L2ac
        L50:
            goto L323
        L52:
            goto L4cc
        L56:
            r1 = r17
            goto L38a
        L5c:
            java.lang.string r9 = new java.lang.string
            goto L41a
        L62:
            r14 = r16
            goto L428
        L68:
            r1 = r17
            goto L83
        L6e:
            r10 = r19
            goto L1bb
        L74:
            r13 = r27
            goto L499
        L7a:
            if (r2 == r3) goto L7f
            goto L4e0
        L7f:
            goto L4e4
        L83:
            if (r2 == r10) goto L88
            goto L38
        L88:
            goto L3f8
        L8c:
            r5.putobject(r15, r3, r1)
            goto L33b
        L93:
            r14 = r16
            goto L19b
        L99:
            long r1 = r13.long1
            goto L21d
        L9f:
            long r1 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r1)
            goto L4d4
        La7:
            r11 = r16
            goto L435
        Lad:
            if (r2 == 0) goto Lb2
            goto L23d
        Lb2:
            goto L37e
        Lb6:
            int r1 = r13.int1
            goto L18b
        Lbc:
            int r14 = r1 + 8
            goto L342
        Lc2:
            if (r9 != 0) goto Lc7
            goto L323
        Lc7:
            goto L53e
        Lcb:
            r5.putobject(r15, r3, r14)
            goto L51b
        Ld2:
            r5.putobject(r15, r3, r1)
            goto L514
        Ld9:
            r1 = r17
            goto L44f
        Ldf:
            int[] r6 = r14.buffer
            goto L570
        Le5:
            goto L38
        Le7:
            goto L31d
        Leb:
            r6 = r2 | 4
            goto L165
        Lf1:
            r2 = r10 & (-8)
            goto Leb
        Lf7:
            r9 = 536870912(0x20000000, float:1.0842022E-19)
            goto L43b
        Lfd:
            bool r9 = androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(r14, r1, r9)
            goto L479
        L105:
            return r14
        L106:
            goto L1f5
        L10a:
            java.lang.object r1 = r13.object1
            goto L352
        L110:
            androidx.datastore.preferences.protobuf.Schema r2 = r14.getMessageFieldSchema(r9)
            goto L372
        L118:
            java.lang.long r14 = java.lang.long.valueOf(r9)
            goto L2e1
        L120:
            long r1 = r13.long1
            goto L393
        L126:
            r14.storeOneofMessageField(r15, r8, r9, r1)
            goto L4b4
        L12d:
            if (r2 == r12) goto L132
            goto L38
        L132:
            goto L45b
        L136:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r14 = r14.getEnumFieldVerifier(r9)
            goto L446
        L13e:
            goto L1d8
        L141:
            goto L1ce
        L145:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed32(r16, r17)
            goto L1e1
        L14d:
            r14 = r16
            goto L4a8
        L153:
            r1 = r17
            goto L455
        L159:
            r5.putInt(r15, r6, r8)
            goto L4b9
        L160:
            int r1 = r1 + r2
        L161:
            goto L2a0
        L165:
            androidx.datastore.preferences.protobuf.Schema r2 = r14.getMessageFieldSchema(r9)
            goto L378
        L16d:
            r1 = r17
            goto L4ae
        L173:
            r4 = r17
            goto L22
        L179:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodebytes(r11, r1, r13)
            goto L10a
        L181:
            return r14
        L182:
            goto L4a2
        L186:
            return r14
        L187:
            goto L3c
        L18b:
            int r1 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r1)
            goto L25e
        L193:
            java.lang.float r14 = java.lang.float.valueOf(r14)
            goto Lcb
        L19b:
            r1 = r17
            goto L302
        L1a1:
            r5.putobject(r15, r3, r1)
            goto L316
        L1a8:
            int r14 = r1 + 8
            goto L4c5
        L1ae:
            r1 = 29
            goto L1b5
        L1b5:
            int r0 = r0 + r1
            goto L2d5
        L1bb:
            r13 = r27
            goto L2bb
        L1c1:
            r7 = r27
            goto L3ba
        L1c7:
            goto L3f4
        L1ca:
            goto L230
        L1ce:
            r0 = 21
            goto L1ae
        L1d5:
            goto L1ca
        L1d8:
            goto L313
        L1dc:
            return r14
        L1dd:
            goto L14d
        L1e1:
            java.lang.int r14 = java.lang.int.valueOf(r14)
            goto L1b
        L1e9:
            int r1 = r13.int1
            goto L52e
        L1ef:
            r11 = r16
            goto L28b
        L1f5:
            r14 = r16
            goto L16d
        L1fb:
            r14.storeField(r10, r0)
            goto L2a7
        L202:
            java.lang.object r1 = r14.mutableOneofMessageFieldForMerge(r15, r8, r9)
            goto L110
        L20a:
            r14 = r16
            goto L68
        L210:
            r5.putobject(r15, r3, r1)
            goto L2f0
        L217:
            r11 = r16
            goto L556
        L21d:
            r9 = 0
            goto L2f7
        L223:
            r5.putobject(r15, r3, r14)
            goto L23b
        L22a:
            r9 = r26
            goto L414
        L230:
            r8 = r20
            goto L4
        L236:
            return r14
        L237:
            goto L15
        L23b:
            goto L161
        L23d:
            goto Lf7
        L241:
            int r1 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r11, r1, r13)
            goto Lf
        L249:
            r11 = 1
            goto L4dc
        L24e:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r11, r1, r13)
            goto Lb6
        L256:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r14, r1, r13)
            goto L120
        L25e:
            java.lang.int r1 = java.lang.int.valueOf(r1)
            goto L8c
        L266:
            java.lang.bool r1 = java.lang.bool.valueOf(r11)
            goto L569
        L26e:
            java.lang.double r14 = java.lang.double.valueOf(r9)
            goto L55c
        L276:
            r5 = r18
            goto L2c9
        L27c:
            r14 = r16
            goto L359
        L282:
            if (r2 == 0) goto L287
            goto L38
        L287:
            goto L48b
        L28b:
            r1 = r17
            goto L407
        L291:
            long r1 = r13.long1
            goto L9f
        L297:
            if (r2 == r12) goto L29c
            goto L38
        L29c:
            goto L179
        L2a0:
            r5.putInt(r15, r6, r8)
            goto L42
        L2a7:
            return r1
        L2a8:
            goto L35f
        L2ac:
            double r9 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodedouble(r16, r17)
            goto L26e
        L2b4:
            r5.putInt(r15, r6, r8)
            goto L181
        L2bb:
            if (r2 == 0) goto L2c0
            goto L38
        L2c0:
            goto L241
        L2c4:
            r11 = 0
        L2c5:
            goto L266
        L2c9:
            r3 = r11
            goto L544
        L2ce:
            r5.putobject(r15, r3, r14)
            goto L4be
        L2d5:
            int r0 = r0 % r1
            goto L3c2
        L2db:
            r1 = r17
            goto Le5
        L2e1:
            r5.putobject(r15, r3, r14)
            goto Lbc
        L2e8:
            java.lang.object r1 = r14.mutableOneofMessageFieldForMerge(r15, r8, r9)
            goto Lf1
        L2f0:
            r5.putInt(r15, r6, r8)
            goto L236
        L2f7:
            int r1 = (r1 > r9 ? 1 : (r1 == r9 ? 0 : -1))
            goto L28
        L2fd:
            r6 = r6 & r7
            goto L474
        L302:
            if (r2 == r10) goto L307
            goto L38
        L307:
            goto L145
        L30b:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.mergeMessageField(r1, r2, r3, r4, r5, r6)
            goto L527
        L313:
            goto L141
        L316:
            r5.putInt(r15, r6, r8)
            goto L3aa
        L31d:
            r3 = 3
            goto L7a
        L322:
            throw r14
        L323:
            goto L5c
        L327:
            r6 = r6[r7]
            goto L40d
        L32d:
            if (r2 == 0) goto L332
            goto L38
        L332:
            goto L24e
        L336:
            return r2
        L337:
            goto L27c
        L33b:
            r5.putInt(r15, r6, r8)
            goto L441
        L342:
            r5.putInt(r15, r6, r8)
            goto L105
        L349:
            if (r2 == 0) goto L34e
            goto L38
        L34e:
            goto L3a2
        L352:
            r5.putobject(r15, r3, r1)
            goto L159
        L359:
            r1 = r17
            goto L31
        L35f:
            java.lang.int r14 = java.lang.int.valueOf(r2)
            goto L2ce
        L367:
            long r2 = (long) r2
            goto L420
        L36c:
            r13 = r27
            goto L46b
        L372:
            r4 = r17
            goto L276
        L378:
            r3 = r16
            goto L173
        L37e:
            java.lang.string r14 = ""
            goto L223
        L384:
            goto L2a8
        L386:
            goto L549
        L38a:
            if (r2 == r11) goto L38f
            goto L38
        L38f:
            goto L536
        L393:
            java.lang.long r1 = java.lang.long.valueOf(r1)
            goto L1a1
        L39b:
            r9.<init>(r14, r1, r2, r10)
            goto L42e
        L3a2:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r14, r1, r13)
            goto L1e9
        L3aa:
            return r14
        L3ab:
            goto L20a
        L3af:
            return r14
        L3b0:
            goto L93
        L3b4:
            r3 = r24
            goto L22a
        L3ba:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.mergeGroupField(r1, r2, r3, r4, r5, r6, r7)
            goto L126
        L3c2:
            if (r0 <= 0) goto L3c7
            goto L1ca
        L3c7:
            goto L1c7
        L3cb:
            return r1
        L3f4:
            goto L1d5
        L3f8:
            float r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodefloat(r16, r17)
            goto L193
        L400:
            r5.putInt(r15, r6, r8)
            goto L1dc
        L407:
            r13 = r27
            goto L297
        L40d:
            r7 = 1048575(0xfffff, float:1.469367E-39)
            goto L2fd
        L414:
            sun.misc.Unsafe r5 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto Ldf
        L41a:
            java.nio.charset.Charset r10 = androidx.datastore.preferences.protobuf.Internal.UTF_8
            goto L39b
        L420:
            java.lang.long r0 = java.lang.long.valueOf(r2)
            goto L1fb
        L428:
            r1 = r17
            goto L36c
        L42e:
            r5.putobject(r15, r3, r9)
            goto L160
        L435:
            r1 = r17
            goto L505
        L43b:
            r9 = r22 & r9
            goto Lc2
        L441:
            return r14
        L442:
            goto L217
        L446:
            if (r14 != 0) goto L44b
            goto L2a8
        L44b:
            goto L4fd
        L44f:
            r13 = r27
            goto L32d
        L455:
            r13 = r27
            goto L282
        L45b:
            int r1 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r14, r1, r13)
            goto L563
        L463:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r14, r1, r13)
            goto L99
        L46b:
            if (r2 == 0) goto L470
            goto L38
        L470:
            goto L463
        L474:
            long r6 = (long) r6
            goto La
        L479:
            if (r9 != 0) goto L47e
            goto L52
        L47e:
            goto L50
        L482:
            if (r2 == r12) goto L487
            goto L38
        L487:
            goto L202
        L48b:
            int r14 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r11, r1, r13)
            goto L291
        L493:
            r1 = r17
            goto L74
        L499:
            if (r2 == 0) goto L49e
            goto L38
        L49e:
            goto L256
        L4a2:
            r14 = r16
            goto L56
        L4a8:
            r1 = r17
            goto L47
        L4ae:
            r13 = r27
            goto L349
        L4b4:
            return r2
        L4b5:
            goto L521
        L4b9:
            return r14
        L4ba:
            goto La7
        L4be:
            r5.putInt(r15, r6, r8)
            goto L551
        L4c5:
            r5.putInt(r15, r6, r8)
            goto L37
        L4cc:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r14 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidUtf8()
            goto L322
        L4d4:
            java.lang.long r1 = java.lang.long.valueOf(r1)
            goto Ld2
        L4dc:
            r12 = 2
            switch(r23) {
                case 51: goto L1dd;
                case 52: goto L3ab;
                case 53: goto L237;
                case 54: goto L237;
                case 55: goto L106;
                case 56: goto L182;
                case 57: goto L3b0;
                case 58: goto L43;
                case 59: goto L337;
                case 60: goto L4ba;
                case 61: goto L552;
                case 62: goto L106;
                case 63: goto L442;
                case 64: goto L3b0;
                case 65: goto L182;
                case 66: goto L187;
                case 67: goto L4b5;
                case 68: goto Le7;
                default: goto L4e0;
            }
        L4e0:
            goto L2db
        L4e4:
            r10 = r19
            goto L2e8
        L4ea:
            goto L2c5
        L4ec:
            goto L2c4
        L4f0:
            r5.putInt(r15, r6, r8)
            goto L3af
        L4f7:
            int r14 = r1 + 4
            goto L2b4
        L4fd:
            bool r14 = r14.isInRange(r2)
            goto L50b
        L505:
            r13 = r27
            goto L482
        L50b:
            if (r14 != 0) goto L510
            goto L386
        L510:
            goto L384
        L514:
            r5.putInt(r15, r6, r8)
            goto L186
        L51b:
            int r14 = r1 + 4
            goto L400
        L521:
            r11 = r16
            goto L153
        L527:
            r14.storeOneofMessageField(r15, r8, r9, r1)
            goto L336
        L52e:
            java.lang.int r1 = java.lang.int.valueOf(r1)
            goto L210
        L536:
            long r9 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed64(r16, r17)
            goto L118
        L53e:
            int r9 = r1 + r2
            goto Lfd
        L544:
            r6 = r13
            goto L30b
        L549:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r14 = getMutableUnknownFields(r15)
            goto L367
        L551:
            return r1
        L552:
            goto L1ef
        L556:
            r1 = r17
            goto L6e
        L55c:
            r5.putobject(r15, r3, r14)
            goto L1a8
        L563:
            int r2 = r13.int1
            goto Lad
        L569:
            r5.putobject(r15, r3, r1)
            goto L4f0
        L570:
            int r7 = r9 + 2
            goto L327
    }

    private int ParseRepeatedField(T r9, byte[] r10, int r11, int r12, int r13, int r14, int r15, int r16, long r17, int r19, long r20, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r22) throws java.io.IOException {
            r8 = this;
            goto L391
        L4:
            r19 = r22
            goto L52e
        La:
            r19 = r6
            goto L33b
        L10:
            r17 = r12
            goto L4d9
        L16:
            r8 = r22
            goto L86
        L1c:
            r18 = r6
            goto L17b
        L22:
            r16 = r11
            goto L10
        L28:
            return r8
        L29:
            goto L2a9
        L2d:
            r9 = 3
            goto L1cd
        L32:
            r14 = r13
            goto L285
        L37:
            r4 = r11
            goto L18c
        L3c:
            return r11
        L82:
            goto L4d2
        L86:
            if (r15 == r7) goto L8b
            goto L15b
        L8b:
            goto L233
        L8f:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedSInt64List(r10, r11, r6, r8)
            goto L2b2
        L97:
            androidx.datastore.preferences.protobuf.Schema r8 = r8.getMessageFieldSchema(r1)
            goto L1b9
        L9f:
            r19 = r2
            goto L1c
        La5:
            return r8
        La6:
            goto L3c
        Laa:
            r18 = r6
            goto L2db
        Lb0:
            r17 = r11
            goto L4fa
        Lb6:
            goto L1aa
        Lb8:
            goto L1a9
        Lbc:
            r6 = r5
            goto L274
        Lc1:
            r3 = 1
            switch(r19) {
                case 18: goto L1ef;
                case 19: goto L55e;
                case 20: goto L156;
                case 21: goto L156;
                case 22: goto L30c;
                case 23: goto L2cc;
                case 24: goto L4a0;
                case 25: goto L519;
                case 26: goto Lf6;
                case 27: goto L22f;
                case 28: goto L252;
                case 29: goto L30c;
                case 30: goto L2ed;
                case 31: goto L4a0;
                case 32: goto L2cc;
                case 33: goto L24d;
                case 34: goto L2b8;
                case 35: goto L1ef;
                case 36: goto L55e;
                case 37: goto L156;
                case 38: goto L156;
                case 39: goto L30c;
                case 40: goto L2cc;
                case 41: goto L4a0;
                case 42: goto L519;
                case 43: goto L30c;
                case 44: goto L2ed;
                case 45: goto L4a0;
                case 46: goto L2cc;
                case 47: goto L24d;
                case 48: goto L2b8;
                case 49: goto L11d;
                default: goto Lc5;
            }
        Lc5:
            goto L11b
        Lc9:
            r16 = r11
            goto L4a4
        Lcf:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedFixed32List(r10, r11, r6, r8)
            goto L4e4
        Ld7:
            goto L82
        Lda:
            goto L31b
        Lde:
            int r10 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32List(r2, r3, r4, r5, r6, r7)
        Le2:
            goto L226
        Le6:
            if (r15 == 0) goto Leb
            goto La6
        Leb:
            goto L2d0
        Lef:
            r19 = r8
            goto L100
        Lf5:
            return r8
        Lf6:
            goto L2f6
        Lfa:
            r18 = r6
            goto L113
        L100:
            r15 = r10
            goto L4aa
        L105:
            r18 = r6
            goto L10b
        L10b:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32List(r14, r15, r16, r17, r18, r19)
            goto L155
        L113:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed32List(r14, r15, r16, r17, r18, r19)
            goto L2cb
        L11b:
            goto La6
        L11d:
            goto L2d
        L121:
            if (r0 <= 0) goto L126
            goto Lda
        L126:
            goto Ld7
        L12a:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedFixed64List(r10, r11, r6, r2)
            goto L54d
        L132:
            if (r6 == 0) goto L137
            goto L385
        L137:
            goto L3df
        L13b:
            if (r15 == r7) goto L140
            goto L29
        L140:
            goto L367
        L144:
            r14 = r13
            goto L305
        L149:
            androidx.datastore.preferences.protobuf.Internal$ProtobufList r5 = (androidx.datastore.preferences.protobuf.Internal.ProtobufList) r5
            goto L497
        L14f:
            r19 = r8
            goto L45c
        L155:
            return r8
        L156:
            goto L16
        L15a:
            return r8
        L15b:
            goto L183
        L15f:
            if (r15 == r3) goto L164
            goto La6
        L164:
            goto L26f
        L168:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeSInt64List(r14, r15, r16, r17, r18, r19)
            goto L24c
        L170:
            r17 = r12
            goto L4ef
        L176:
            r14 = r13
            goto L9f
        L17b:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodedoubleList(r14, r15, r16, r17, r18, r19)
            goto La5
        L183:
            if (r15 == 0) goto L188
            goto La6
        L188:
            goto L14f
        L18c:
            r5 = r12
            goto L4cd
        L191:
            if (r15 == 0) goto L196
            goto La6
        L196:
            goto L210
        L19a:
            if (r15 == r7) goto L19f
            goto L2b3
        L19f:
            goto L8f
        L1a3:
            r20 = r22
            goto La
        L1a9:
            int r6 = r6 * r7
        L1aa:
            goto L421
        L1ae:
            r17 = r12
            goto L5bd
        L1b4:
            r12 = 0
            goto L361
        L1b9:
            r14 = r8
            goto L29a
        L1be:
            r20 = r8
            goto L261
        L1c4:
            if (r15 == r7) goto L1c9
            goto La6
        L1c9:
            goto L413
        L1cd:
            if (r15 == r9) goto L1d2
            goto La6
        L1d2:
            goto L97
        L1d6:
            r2 = r22
            goto L352
        L1dc:
            return r8
        L1dd:
            goto L3a7
        L1e1:
            androidx.datastore.preferences.protobuf.SchemaUtil.filterUnknownEnumList(r15, r16, r17, r18, r19, r20)
            goto L251
        L1e8:
            r8 = r22
            goto L13b
        L1ee:
            return r8
        L1ef:
            goto L40d
        L1f3:
            r16 = r11
            goto L27f
        L1f9:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedfloatList(r10, r11, r6, r8)
            goto L51d
        L201:
            r19 = r22
            goto L2d5
        L207:
            if (r15 == r7) goto L20c
            goto L51e
        L20c:
            goto L1f9
        L210:
            r19 = r8
            goto L552
        L216:
            return r8
        L217:
            goto L443
        L21b:
            r16 = r11
            goto L1ae
        L221:
            r14 = r13
            goto L105
        L226:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r11 = r8.getEnumFieldVerifier(r1)
            goto L1b4
        L22e:
            return r8
        L22f:
            goto L1c4
        L233:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedVarint64List(r10, r11, r6, r8)
            goto L15a
        L23b:
            r15 = r10
            goto L3b0
        L240:
            r8 = r22
            goto L595
        L246:
            r16 = r11
            goto L461
        L24c:
            return r8
        L24d:
            goto L240
        L251:
            return r10
        L252:
            goto L3ed
        L256:
            r17 = r12
            goto L3d4
        L25c:
            r2 = r13
            goto Lde
        L261:
            r15 = r9
            goto L5d1
        L266:
            if (r15 == r7) goto L26b
            goto L3c5
        L26b:
            goto L321
        L26f:
            r15 = r10
            goto L1f3
        L274:
            r2 = 5
            goto Lc1
        L279:
            r17 = r11
            goto L3d9
        L27f:
            r17 = r12
            goto L176
        L285:
            r19 = r2
            goto L4de
        L28b:
            r15 = r10
            goto L32f
        L290:
            r7 = 2
            goto L132
        L295:
            r14 = r13
            goto L42f
        L29a:
            r16 = r10
            goto L279
        L2a0:
            if (r8 == 0) goto L2a5
            goto L409
        L2a5:
            goto L28b
        L2a9:
            if (r15 == 0) goto L2ae
            goto La6
        L2ae:
            goto L534
        L2b2:
            return r8
        L2b3:
            goto L191
        L2b7:
            return r8
        L2b8:
            goto L547
        L2bc:
            r8 = r22
            goto L207
        L2c2:
            if (r6 == 0) goto L2c7
            goto Lb8
        L2c7:
            goto L4c7
        L2cb:
            return r8
        L2cc:
            goto L3c9
        L2d0:
            r3 = r10
            goto L37
        L2d5:
            r18 = r6
            goto L57f
        L2db:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeSInt32List(r14, r15, r16, r17, r18, r19)
            goto L2ec
        L2e3:
            if (r15 == r3) goto L2e8
            goto La6
        L2e8:
            goto L34d
        L2ec:
            return r8
        L2ed:
            goto L1d6
        L2f1:
            r15 = r10
            goto L579
        L2f6:
            if (r15 == r7) goto L2fb
            goto La6
        L2fb:
            goto L490
        L2ff:
            r18 = r6
            goto L389
        L305:
            r18 = r6
            goto L59e
        L30b:
            return r8
        L30c:
            goto L56a
        L310:
            r15 = r10
            goto L21b
        L315:
            r19 = r6
            goto L587
        L31b:
            r1 = r16
            goto L3be
        L321:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackeddoubleList(r10, r11, r6, r2)
            goto L3c4
        L329:
            int r8 = (r8 > r0 ? 1 : (r8 == r0 ? 0 : -1))
            goto L2a0
        L32f:
            r16 = r11
            goto L3e7
        L335:
            r16 = r11
            goto L3a1
        L33b:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeGroupList(r14, r15, r16, r17, r18, r19, r20)
            goto L2b7
        L343:
            r15 = r13
            goto L48a
        L348:
            r15 = r13
            goto L1a3
        L34d:
            r15 = r10
            goto L429
        L352:
            if (r15 == r7) goto L357
            goto L4c3
        L357:
            goto L3b6
        L35b:
            r19 = r12
            goto L557
        L361:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r8 = r8.unknownFieldSchema
            goto L1be
        L367:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedBoolList(r10, r11, r6, r8)
            goto L28
        L36f:
            r15 = r10
            goto Lc9
        L374:
            r14 = r13
            goto L58f
        L379:
            if (r15 == r7) goto L37e
            goto L54e
        L37e:
            goto L12a
        L382:
            r4.putobject(r9, r2, r5)
        L385:
            goto Lbc
        L389:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64List(r14, r15, r16, r17, r18, r19)
            goto L55d
        L391:
            goto L4d5
        L394:
            goto L5ae
        L398:
            if (r15 == r7) goto L39d
            goto L217
        L39d:
            goto L53f
        L3a1:
            r17 = r12
            goto L295
        L3a7:
            if (r15 == 0) goto L3ac
            goto La6
        L3ac:
            goto L3fc
        L3b0:
            r16 = r11
            goto L170
        L3b6:
            int r10 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedVarint32List(r10, r11, r6, r2)
            goto L4c1
        L3be:
            r2 = r20
            goto L512
        L3c4:
            return r8
        L3c5:
            goto L15f
        L3c9:
            r2 = r22
            goto L379
        L3cf:
            r15 = r10
            goto L335
        L3d4:
            r14 = r13
            goto L201
        L3d9:
            r18 = r12
            goto L348
        L3df:
            int r6 = r5.Count
            goto L2c2
        L3e7:
            r17 = r12
            goto L500
        L3ed:
            if (r15 == r7) goto L3f2
            goto La6
        L3f2:
            goto L36f
        L3f6:
            r19 = r8
            goto L310
        L3fc:
            r19 = r8
            goto L23b
        L402:
            r0 = 0
            goto L329
        L408:
            return r8
        L409:
            goto L5b8
        L40d:
            r2 = r22
            goto L266
        L413:
            androidx.datastore.preferences.protobuf.Schema r8 = r8.getMessageFieldSchema(r1)
            goto L4b0
        L41b:
            r8 = r22
            goto L47b
        L421:
            androidx.datastore.preferences.protobuf.Internal$ProtobufList r5 = r5.mutableCopyWithCapacity(r6)
            goto L382
        L429:
            r16 = r11
            goto L4bb
        L42f:
            r18 = r6
            goto L5a6
        L435:
            r17 = r12
            goto L221
        L43b:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodestringList(r14, r15, r16, r17, r18, r19)
            goto L408
        L443:
            if (r15 == 0) goto L448
            goto La6
        L448:
            goto Lef
        L44c:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodebytesList(r14, r15, r16, r17, r18, r19)
            goto L22e
        L454:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed64List(r14, r15, r16, r17, r18, r19)
            goto L30b
        L45c:
            r15 = r10
            goto L22
        L461:
            r17 = r12
            goto L374
        L467:
            int r0 = r0 + r1
            goto L522
        L46d:
            r19 = r22
            goto L484
        L473:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedSInt32List(r10, r11, r6, r8)
            goto L1dc
        L47b:
            if (r15 == r7) goto L480
            goto L4e5
        L480:
            goto Lcf
        L484:
            r18 = r6
            goto L43b
        L48a:
            r20 = r22
            goto L315
        L490:
            r8 = 536870912(0x20000000, double:2.65249474E-315)
            goto L4e9
        L497:
            bool r6 = r5.isModifiable()
            goto L290
        L49f:
            return r8
        L4a0:
            goto L41b
        L4a4:
            r17 = r12
            goto L53a
        L4aa:
            r16 = r11
            goto L435
        L4b0:
            r14 = r8
            goto L5cb
        L4b5:
            r17 = r12
            goto L144
        L4bb:
            r17 = r12
            goto L32
        L4c1:
            goto Le2
        L4c3:
            goto Le6
        L4c7:
            r6 = 10
            goto Lb6
        L4cd:
            r7 = r2
            goto L25c
        L4d2:
            goto Lda
        L4d5:
            goto L5b5
        L4d9:
            r14 = r13
            goto L2ff
        L4de:
            r18 = r6
            goto L454
        L4e4:
            return r8
        L4e5:
            goto L5c2
        L4e9:
            long r8 = r17 & r8
            goto L402
        L4ef:
            r14 = r13
            goto Laa
        L4f4:
            r19 = r8
            goto L2f1
        L4fa:
            r18 = r12
            goto L343
        L500:
            r14 = r13
            goto L46d
        L505:
            r17 = r6
            goto L1e1
        L50b:
            r1 = 2
            goto L467
        L512:
            sun.misc.Unsafe r4 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L562
        L518:
            return r8
        L519:
            goto L1e8
        L51d:
            return r8
        L51e:
            goto L570
        L522:
            int r0 = r0 % r1
            goto L121
        L528:
            r16 = r11
            goto L256
        L52e:
            r18 = r6
            goto L44c
        L534:
            r19 = r8
            goto L3cf
        L53a:
            r14 = r13
            goto L4
        L53f:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodePackedVarint32List(r10, r11, r6, r8)
            goto L216
        L547:
            r8 = r22
            goto L19a
        L54d:
            return r8
        L54e:
            goto L2e3
        L552:
            r15 = r10
            goto L246
        L557:
            r16 = r14
            goto L505
        L55d:
            return r8
        L55e:
            goto L2bc
        L562:
            java.lang.object r5 = r4.getobject(r9, r2)
            goto L149
        L56a:
            r8 = r22
            goto L398
        L570:
            if (r15 == r2) goto L575
            goto La6
        L575:
            goto L4f4
        L579:
            r16 = r11
            goto L4b5
        L57f:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodestringListRequireUtf8(r14, r15, r16, r17, r18, r19)
            goto L518
        L587:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeMessageList(r14, r15, r16, r17, r18, r19, r20)
            goto Lf5
        L58f:
            r18 = r6
            goto L168
        L595:
            if (r15 == r7) goto L59a
            goto L1dd
        L59a:
            goto L473
        L59e:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodefloatList(r14, r15, r16, r17, r18, r19)
            goto L1ee
        L5a6:
            int r8 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeBoolList(r14, r15, r16, r17, r18, r19)
            goto L49f
        L5ae:
            r0 = 28
            goto L50b
        L5b5:
            goto L394
        L5b8:
            r15 = r10
            goto L528
        L5bd:
            r14 = r13
            goto Lfa
        L5c2:
            if (r15 == r2) goto L5c7
            goto La6
        L5c7:
            goto L3f6
        L5cb:
            r16 = r10
            goto Lb0
        L5d1:
            r18 = r11
            goto L35b
    }

    private int PositionForFieldNumber(int r2) {
            r1 = this;
            goto L24
        L4:
            if (r2 >= r0) goto L9
            goto L18
        L9:
            goto L3c
        Ld:
            r0 = 0
            goto L34
        L12:
            r1 = -1
            goto L1c
        L17:
            return r1
        L18:
            goto L12
        L1c:
            return r1
        L1d:
            goto L21
        L21:
            goto L27
        L24:
            goto L1d
        L27:
            goto L42
        L2b:
            if (r2 <= r0) goto L30
            goto L18
        L30:
            goto Ld
        L34:
            int r1 = r1.slowPositionForFieldNumber(r2, r0)
            goto L17
        L3c:
            int r0 = r1.maxFieldNumber
            goto L2b
        L42:
            int r0 = r1.minFieldNumber
            goto L4
    }

    private int PositionForFieldNumber(int r2, int r3) {
            r1 = this;
            goto Ld
        L4:
            if (r2 >= r0) goto L9
            goto L29
        L9:
            goto L30
        Ld:
            goto L3f
        L10:
            goto L1d
        L14:
            if (r2 <= r0) goto L19
            goto L29
        L19:
            goto L36
        L1d:
            int r0 = r1.minFieldNumber
            goto L4
        L23:
            r1 = -1
            goto L3e
        L28:
            return r1
        L29:
            goto L23
        L2d:
            goto L10
        L30:
            int r0 = r1.maxFieldNumber
            goto L14
        L36:
            int r1 = r1.slowPositionForFieldNumber(r2, r3)
            goto L28
        L3e:
            return r1
        L3f:
            goto L2d
    }

    private int PresenceMaskAndOffsetAt(int r1) {
            r0 = this;
            goto L18
        L4:
            r0 = r0[r1]
            goto La
        La:
            return r0
        Lb:
            goto L15
        Lf:
            int[] r0 = r0.buffer
            goto L1f
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto Lf
        L1f:
            int r1 = r1 + 2
            goto L4
    }

    private <E> void ReadGroupList(java.lang.object r1, long r2, androidx.datastore.preferences.protobuf.Reader r4, androidx.datastore.preferences.protobuf.Schema<E> r5, androidx.datastore.preferences.protobuf.ExtensionRegistryLite r6) throws java.io.IOException {
            r0 = this;
            goto L21
        L4:
            r4.readGroupList(r0, r5, r6)
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L24
        L13:
            androidx.datastore.preferences.protobuf.ListFieldSchema r0 = r0.listFieldSchema
            goto L19
        L19:
            java.util.List r0 = r0.mutableListAt(r1, r2)
            goto L4
        L21:
            goto Lc
        L24:
            goto L13
    }

    private <E> void ReadMessageList(java.lang.object r3, int r4, androidx.datastore.preferences.protobuf.Reader r5, androidx.datastore.preferences.protobuf.Schema<E> r6, androidx.datastore.preferences.protobuf.ExtensionRegistryLite r7) throws java.io.IOException {
            r2 = this;
            goto L4e
        L4:
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r2.listFieldSchema
            goto L18
        La:
            long r0 = offset(r4)
            goto L4
        L12:
            int r0 = r0 + r1
            goto L37
        L18:
            java.util.List r2 = r2.mutableListAt(r3, r0)
            goto L30
        L20:
            if (r0 <= 0) goto L25
            goto L4a
        L25:
            goto L47
        L29:
            r0 = 18
            goto L55
        L30:
            r5.readMessageList(r2, r6, r7)
            goto L5c
        L37:
            int r0 = r0 % r1
            goto L20
        L3d:
            goto L4a
        L40:
            goto L44
        L44:
            goto L51
        L47:
            goto L5d
        L4a:
            goto La
        L4e:
            goto L40
        L51:
            goto L29
        L55:
            r1 = 22
            goto L12
        L5c:
            return
        L5d:
            goto L3d
    }

    private void Readstring(java.lang.object r3, int r4, androidx.datastore.preferences.protobuf.Reader r5) throws java.io.IOException {
            r2 = this;
            goto Ld
        L4:
            if (r0 != 0) goto L9
            goto L4c
        L9:
            goto L60
        Ld:
            goto L1e
        L10:
            goto L27
        L14:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r3, r0, r2)
            goto L68
        L1b:
            goto L9e
        L1e:
            goto L50
        L22:
            return
        L23:
            goto L1b
        L27:
            r0 = 18
            goto L3c
        L2e:
            int r0 = r0 + r1
            goto L6d
        L34:
            java.lang.string r2 = r5.readstring()
            goto L14
        L3c:
            r1 = 4
            goto L2e
        L43:
            bool r0 = isEnforceUtf8(r4)
            goto L4
        L4b:
            return
        L4c:
            goto L53
        L50:
            goto L10
        L53:
            bool r2 = r2.lite
            goto La2
        L59:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r3, r0, r2)
            goto L22
        L60:
            long r0 = offset(r4)
            goto L82
        L68:
            return
        L69:
            goto Lab
        L6d:
            int r0 = r0 % r1
            goto L92
        L73:
            long r0 = offset(r4)
            goto L34
        L7b:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(r3, r0, r2)
            goto L4b
        L82:
            java.lang.string r2 = r5.readstringRequireUtf8()
            goto L7b
        L8a:
            androidx.datastore.preferences.protobuf.bytestring r2 = r5.readbytes()
            goto L59
        L92:
            if (r0 <= 0) goto L97
            goto L9e
        L97:
            goto L9b
        L9b:
            goto L23
        L9e:
            goto L43
        La2:
            if (r2 != 0) goto La7
            goto L69
        La7:
            goto L73
        Lab:
            long r0 = offset(r4)
            goto L8a
    }

    private void ReadstringList(java.lang.object r3, int r4, androidx.datastore.preferences.protobuf.Reader r5) throws java.io.IOException {
            r2 = this;
            goto L18
        L4:
            return
        L5:
            goto L87
        L9:
            r5.readstringList(r2)
            goto L4
        L10:
            long r0 = offset(r4)
            goto L2f
        L18:
            goto L8a
        L1b:
            goto L37
        L1f:
            if (r0 <= 0) goto L24
            goto L2b
        L24:
            goto L28
        L28:
            goto L5
        L2b:
            goto L73
        L2f:
            java.util.List r2 = r2.mutableListAt(r3, r0)
            goto L9
        L37:
            r0 = 23
            goto L6c
        L3e:
            if (r0 != 0) goto L43
            goto L5a
        L43:
            goto L7b
        L47:
            goto L1b
        L4a:
            r5.readstringListRequireUtf8(r2)
            goto L59
        L51:
            long r0 = offset(r4)
            goto L64
        L59:
            return
        L5a:
            goto L8e
        L5e:
            int r0 = r0 + r1
            goto L81
        L64:
            java.util.List r2 = r2.mutableListAt(r3, r0)
            goto L4a
        L6c:
            r1 = 26
            goto L5e
        L73:
            bool r0 = isEnforceUtf8(r4)
            goto L3e
        L7b:
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r2.listFieldSchema
            goto L51
        L81:
            int r0 = r0 % r1
            goto L1f
        L87:
            goto L2b
        L8a:
            goto L47
        L8e:
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r2.listFieldSchema
            goto L10
    }

    private static java.lang.reflect.Field ReflectField(java.lang.Class<object> r5, java.lang.string r6) {
            goto L4
        L4:
            goto Le3
        L7:
            goto Lc5
        Lb:
            if (r0 <= 0) goto L10
            goto L30
        L10:
            goto L2d
        L14:
            if (r2 < r1) goto L19
            goto L46
        L19:
            goto L66
        L1d:
            java.lang.stringBuilder r6 = r2.append(r6)
            goto Lcc
        L25:
            java.lang.stringBuilder r5 = r6.append(r5)
            goto L90
        L2d:
            goto L39
        L30:
            java.lang.reflect.Field r5 = r5.getDeclaredField(r6)     // Catch: java.lang.NoSuchFieldException -> Lac
            goto Lab
        L38:
            throw r1
        L39:
            goto Le0
        L3d:
            java.lang.string r6 = java.util.Arrays.tostring(r0)
            goto Le7
        L45:
            goto Lb1
        L46:
            goto Lef
        L4a:
            int r0 = r0 % r1
            goto Lb
        L50:
            if (r4 != 0) goto L55
            goto L9f
        L55:
            goto L9e
        L59:
            java.lang.string r5 = r5.tostring()
            goto Ld2
        L61:
            int r1 = r0.length
            goto Lb0
        L66:
            r3 = r0[r2]
            goto Lb5
        L6c:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L83
        L72:
            int r2 = r2 + 1
            goto L45
        L78:
            bool r4 = r6.Equals(r4)
            goto L50
        L80:
            goto L7
        L83:
            java.lang.string r3 = "Field "
            goto Ld9
        L89:
            r1 = 7
            goto Lf5
        L90:
            java.lang.string r6 = " not found. Known fields are "
            goto Lbd
        L96:
            java.lang.string r5 = r5.getName()
            goto L25
        L9e:
            return r3
        L9f:
            goto L72
        La3:
            java.lang.reflect.Field[] r0 = r5.getDeclaredFields()
            goto L61
        Lab:
            return r5
        Lac:
            goto La3
        Lb0:
            r2 = 0
        Lb1:
            goto L14
        Lb5:
            java.lang.string r4 = r3.getName()
            goto L78
        Lbd:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto L3d
        Lc5:
            r0 = 24
            goto L89
        Lcc:
            java.lang.string r2 = " for "
            goto Lfb
        Ld2:
            r1.<init>(r5)
            goto L38
        Ld9:
            r2.<init>(r3)
            goto L1d
        Le0:
            goto L30
        Le3:
            goto L80
        Le7:
            java.lang.stringBuilder r5 = r5.append(r6)
            goto L59
        Lef:
            java.lang.Exception r1 = new java.lang.Exception
            goto L6c
        Lf5:
            int r0 = r0 + r1
            goto L4a
        Lfb:
            java.lang.stringBuilder r6 = r6.append(r2)
            goto L96
    }

    private void SetFieldPresent(T r5, int r6) {
            r4 = this;
            goto La
        L4:
            int r4 = r4 >>> 20
            goto L85
        La:
            goto L6d
        Ld:
            goto L91
        L11:
            int r6 = (r0 > r2 ? 1 : (r0 == r2 ? 0 : -1))
            goto L5c
        L17:
            return
        L18:
            goto L6a
        L1c:
            int r4 = r4.presenceMaskAndOffsetAt(r6)
            goto L78
        L24:
            if (r0 <= 0) goto L29
            goto L37
        L29:
            goto L34
        L2d:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r5, r0, r4)
            goto L17
        L34:
            goto L18
        L37:
            goto L1c
        L3b:
            r4 = r4 | r6
            goto L2d
        L40:
            goto Ld
        L43:
            int r6 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r5, r0)
            goto L3b
        L4b:
            int r0 = r0 % r1
            goto L24
        L51:
            int r4 = r6 << r4
            goto L43
        L57:
            long r0 = (long) r6
            goto L71
        L5c:
            if (r6 == 0) goto L61
            goto L99
        L61:
            goto L98
        L65:
            r6 = r6 & r4
            goto L57
        L6a:
            goto L37
        L6d:
            goto L40
        L71:
            r2 = 1048575(0xfffff, double:5.18065E-318)
            goto L11
        L78:
            r6 = 1048575(0xfffff, float:1.469367E-39)
            goto L65
        L7f:
            int r0 = r0 + r1
            goto L4b
        L85:
            r6 = 1
            goto L51
        L8a:
            r1 = 2
            goto L7f
        L91:
            r0 = 24
            goto L8a
        L98:
            return
        L99:
            goto L4
    }

    private void SetOneofPresent(T r3, int r4, int r5) {
            r2 = this;
            goto L56
        L4:
            int r0 = r0 + r1
            goto L50
        La:
            r0 = 7
            goto L11
        L11:
            r1 = 31
            goto L4
        L18:
            r2 = r2 & r5
            goto L4b
        L1d:
            goto L59
        L20:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putInt(r3, r0, r4)
            goto L46
        L27:
            int r2 = r2.presenceMaskAndOffsetAt(r5)
            goto L38
        L2f:
            if (r0 <= 0) goto L34
            goto L42
        L34:
            goto L3f
        L38:
            r5 = 1048575(0xfffff, float:1.469367E-39)
            goto L18
        L3f:
            goto L47
        L42:
            goto L27
        L46:
            return
        L47:
            goto L5d
        L4b:
            long r0 = (long) r2
            goto L20
        L50:
            int r0 = r0 % r1
            goto L2f
        L56:
            goto L60
        L59:
            goto La
        L5d:
            goto L42
        L60:
            goto L1d
    }

    private int SlowPositionForFieldNumber(int r5, int r6) {
            r4 = this;
            goto L15
        L4:
            int[] r0 = r4.buffer
            goto La2
        La:
            r0 = r1
            goto L81
        Lf:
            int r1 = r1 >>> 1
            goto L1c
        L15:
            goto L91
        L18:
            goto L68
        L1c:
            int r2 = r1 * 3
            goto L86
        L22:
            r6 = r1
            goto L7c
        L27:
            int r1 = r0 + r6
            goto Lf
        L2d:
            int r0 = r0 + (-1)
        L2f:
            goto L51
        L33:
            int r1 = r1 + 1
            goto L22
        L39:
            if (r5 == r3) goto L3e
            goto L5b
        L3e:
            goto L5a
        L42:
            if (r0 <= 0) goto L47
            goto Lb0
        L47:
            goto Lad
        L4b:
            int r0 = r0 + r1
            goto La7
        L51:
            if (r6 <= r0) goto L56
            goto L7d
        L56:
            goto L27
        L5a:
            return r2
        L5b:
            goto L5f
        L5f:
            if (r5 < r3) goto L64
            goto L82
        L64:
            goto L9c
        L68:
            r0 = 12
            goto L95
        L6f:
            goto L18
        L72:
            r4 = -1
            goto L77
        L77:
            return r4
        L78:
            goto L8e
        L7c:
            goto L2f
        L7d:
            goto L72
        L81:
            goto L2f
        L82:
            goto L33
        L86:
            int r3 = r4.numberAt(r2)
            goto L39
        L8e:
            goto Lb0
        L91:
            goto L6f
        L95:
            r1 = 3
            goto L4b
        L9c:
            int r1 = r1 + (-1)
            goto La
        La2:
            int r0 = r0.length
            goto Lb4
        La7:
            int r0 = r0 % r1
            goto L42
        Lad:
            goto L78
        Lb0:
            goto L4
        Lb4:
            int r0 = r0 / 3
            goto L2d
    }

    private static void StoreFieldData(androidx.datastore.preferences.protobuf.FieldInfo r8, int[] r9, int r10, java.lang.object[] r11) {
            goto L90
        L4:
            int r4 = java.lang.int.numberOfTrailingZeros(r4)
            goto L1f7
        Lc:
            int r10 = r10 * 2
            goto L51
        L12:
            java.lang.reflect.Field r0 = r8.getCachedSizeField()
            goto La5
        L1a:
            java.lang.reflect.Field r0 = r0.getCaseField()
            goto L1cd
        L22:
            androidx.datastore.preferences.protobuf.FieldType r0 = r8.getType()
            goto L146
        L2a:
            bool r4 = r0.isList()
            goto L1b0
        L32:
            int r0 = r0 + r1
            goto L8a
        L38:
            goto L27b
        L3a:
            goto L27a
        L3e:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r8 = r8.getEnumVerifier()
            goto L274
        L46:
            r9[r10] = r5
            goto L211
        L4c:
            return
        L4d:
            goto Le3
        L51:
            int r10 = r10 + 1
            goto L1a0
        L57:
            r11[r10] = r8
        L59:
            goto L193
        L5d:
            int r5 = r8.getFieldNumber()
            goto L46
        L65:
            if (r9 != 0) goto L6a
            goto L59
        L6a:
            goto L188
        L6e:
            int r0 = (int) r4
            goto L18e
        L73:
            if (r0 == 0) goto L78
            goto L1f9
        L78:
            goto L224
        L7c:
            int r1 = r10 + 2
            goto L14e
        L82:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r9 = r8.getEnumVerifier()
            goto L65
        L8a:
            int r0 = r0 % r1
            goto L26b
        L90:
            goto L106
        L93:
            goto L2a0
        L97:
            androidx.datastore.preferences.protobuf.OneofInfo r0 = r8.getOneof()
            goto L205
        L9f:
            goto L28c
        La1:
            goto L22
        La5:
            long r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r0)
            goto L28a
        Lad:
            int r10 = r10 / 3
            goto Ld7
        Lb3:
            bool r0 = r0.isDictionary()
            goto L73
        Lbb:
            if (r0 == 0) goto Lc0
            goto L297
        Lc0:
            goto L131
        Lc4:
            r1 = 4
            goto L32
        Lcb:
            r9[r1] = r0
            goto L17a
        Ld1:
            int r10 = r10 + 1
            goto Ldd
        Ld7:
            int r10 = r10 * 2
            goto L236
        Ldd:
            r11[r10] = r9
            goto L22c
        Le3:
            if (r9 != 0) goto Le8
            goto L22d
        Le8:
            goto Lfa
        Lec:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r3)
            goto L154
        Lf4:
            goto L28c
        Lf6:
            goto L12
        Lfa:
            int r10 = r10 / 3
            goto L27f
        L100:
            goto L93
        L103:
            goto L20d
        L106:
            goto L100
        L10a:
            if (r9 != 0) goto L10f
            goto L59
        L10f:
            goto L159
        L113:
            if (r0 != 0) goto L118
            goto La1
        L118:
            goto L23e
        L11c:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r9 = r8.getEnumVerifier()
            goto L10a
        L124:
            int r3 = (int) r2
            goto L198
        L129:
            int r4 = r8.getPresenceMask()
            goto L4
        L131:
            r0 = 1048575(0xfffff, float:1.469367E-39)
            goto L296
        L138:
            long r2 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r2)
            goto L124
        L140:
            r6 = 536870912(0x20000000, float:1.0842022E-19)
            goto L38
        L146:
            java.lang.reflect.Field r2 = r8.getField()
            goto L138
        L14e:
            int r2 = r4 << 20
            goto L29b
        L154:
            int r3 = (int) r3
            goto L1a
        L159:
            int r10 = r10 / 3
            goto Lc
        L15f:
            r1 = r1 | r3
            goto L182
        L164:
            java.lang.object r0 = r8.getDictionaryDefaultEntry()
            goto L246
        L16c:
            r1 = r1 | r2
            goto L15f
        L171:
            if (r6 != 0) goto L176
            goto L3a
        L176:
            goto L140
        L17a:
            java.lang.Class r9 = r8.getMessageFieldClass()
            goto L164
        L182:
            r9[r5] = r1
            goto L7c
        L188:
            int r10 = r10 + 1
            goto L3e
        L18e:
            r4 = r1
            goto L9f
        L193:
            return
        L194:
            goto L103
        L198:
            int r2 = r0.id()
            goto L2a
        L1a0:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r8 = r8.getEnumVerifier()
            goto L57
        L1a8:
            long r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r0)
            goto L24f
        L1b0:
            if (r4 == 0) goto L1b5
            goto L1f9
        L1b5:
            goto Lb3
        L1b9:
            int r2 = r2 << 20
            goto L16c
        L1bf:
            java.lang.reflect.Field r0 = r8.getCachedSizeField()
            goto L2a7
        L1c7:
            int r10 = r10 + 1
            goto L1dd
        L1cd:
            long r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.objectFieldOffset(r0)
        L1d1:
            goto L6e
        L1d5:
            bool r7 = r8.isRequired()
            goto L25c
        L1dd:
            r11[r10] = r9
            goto L231
        L1e3:
            r11[r10] = r0
            goto L1e9
        L1e9:
            if (r9 != 0) goto L1ee
            goto L232
        L1ee:
            goto L1c7
        L1f2:
            r0 = r1
            goto L217
        L1f7:
            goto L28c
        L1f9:
            goto L1bf
        L1fd:
            bool r6 = r8.isEnforceUtf8()
            goto L171
        L205:
            r1 = 0
            goto L113
        L20a:
            goto L194
        L20d:
            goto L97
        L211:
            int r5 = r10 + 1
            goto L1fd
        L217:
            r4 = r0
            goto Lf4
        L21c:
            int r2 = r2.id()
            goto L265
        L224:
            java.lang.reflect.Field r0 = r8.getPresenceField()
            goto Lbb
        L22c:
            return
        L22d:
            goto L11c
        L231:
            return
        L232:
            goto L82
        L236:
            java.lang.object r0 = r8.getDictionaryDefaultEntry()
            goto L1e3
        L23e:
            androidx.datastore.preferences.protobuf.FieldType r2 = r8.getType()
            goto L21c
        L246:
            if (r0 != 0) goto L24b
            goto L4d
        L24b:
            goto Lad
        L24f:
            int r0 = (int) r4
        L250:
            goto L129
        L254:
            java.lang.reflect.Field r3 = r0.getValueField()
            goto Lec
        L25c:
            if (r7 != 0) goto L261
            goto L292
        L261:
            goto L290
        L265:
            int r2 = r2 + 51
            goto L254
        L26b:
            if (r0 <= 0) goto L270
            goto L20d
        L270:
            goto L20a
        L274:
            r11[r10] = r8
            goto L4c
        L27a:
            r6 = r1
        L27b:
            goto L1d5
        L27f:
            int r10 = r10 * 2
            goto Ld1
        L285:
            r1 = r1 | r6
            goto L1b9
        L28a:
            goto L1d1
        L28c:
            goto L5d
        L290:
            r1 = 268435456(0x10000000, float:2.524355E-29)
        L292:
            goto L285
        L296:
            goto L250
        L297:
            goto L1a8
        L29b:
            r0 = r0 | r2
            goto Lcb
        L2a0:
            r0 = 28
            goto Lc4
        L2a7:
            if (r0 == 0) goto L2ac
            goto Lf6
        L2ac:
            goto L1f2
    }

    private void StoreMessageField(T r4, int r5, java.lang.object r6) {
            r3 = this;
            goto L1f
        L4:
            goto L64
        L7:
            goto L40
        Lb:
            r0 = 11
            goto L18
        L12:
            int r0 = r0 % r1
            goto L5a
        L18:
            r1 = 29
            goto L46
        L1f:
            goto L31
        L22:
            goto Lb
        L26:
            long r1 = offset(r1)
            goto L4c
        L2e:
            goto L7
        L31:
            goto L35
        L35:
            goto L22
        L38:
            int r1 = r3.typeAndOffsetAt(r5)
            goto L26
        L40:
            sun.misc.Unsafe r0 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L38
        L46:
            int r0 = r0 + r1
            goto L12
        L4c:
            r0.putobject(r4, r1, r6)
            goto L53
        L53:
            r3.setFieldPresent(r4, r5)
            goto L63
        L5a:
            if (r0 <= 0) goto L5f
            goto L7
        L5f:
            goto L4
        L63:
            return
        L64:
            goto L2e
    }

    private void StoreOneofMessageField(T r4, int r5, int r6, java.lang.object r7) {
            r3 = this;
            goto L2a
        L4:
            r1 = 22
            goto L18
        Lb:
            sun.misc.Unsafe r0 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L3f
        L11:
            r3.setOneofPresent(r4, r5, r6)
            goto L4e
        L18:
            int r0 = r0 + r1
            goto L39
        L1e:
            if (r0 <= 0) goto L23
            goto L64
        L23:
            goto L61
        L27:
            goto L2d
        L2a:
            goto L5d
        L2d:
            goto L53
        L31:
            long r1 = offset(r1)
            goto L47
        L39:
            int r0 = r0 % r1
            goto L1e
        L3f:
            int r1 = r3.typeAndOffsetAt(r6)
            goto L31
        L47:
            r0.putobject(r4, r1, r7)
            goto L11
        L4e:
            return
        L4f:
            goto L5a
        L53:
            r0 = 19
            goto L4
        L5a:
            goto L64
        L5d:
            goto L27
        L61:
            goto L4f
        L64:
            goto Lb
    }

    private static int Type(int r1) {
            goto L4
        L4:
            goto L20
        L7:
            goto L11
        Lb:
            int r1 = r1 >>> 20
            goto L1f
        L11:
            r0 = 267386880(0xff00000, float:2.3665827E-29)
            goto L17
        L17:
            r1 = r1 & r0
            goto Lb
        L1c:
            goto L7
        L1f:
            return r1
        L20:
            goto L1c
    }

    private int TypeAndOffsetAt(int r1) {
            r0 = this;
            goto L1e
        L4:
            int r1 = r1 + 1
            goto La
        La:
            r0 = r0[r1]
            goto L16
        L10:
            int[] r0 = r0.buffer
            goto L4
        L16:
            return r0
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L10
    }

    private void WriteFieldsInAscendingOrder(T r19, androidx.datastore.preferences.protobuf.Writer r20) throws java.io.IOException {
            r18 = this;
            goto L96b
        L4:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt32List(r5, r12, r6, r14)
        L7:
            goto L5ed
        Lb:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt64List(r5, r12, r6, r15)
            goto L818
        L12:
            r14 = 0
            goto Lbf0
        L17:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L372
        L1f:
            r15 = 0
            goto Lddf
        L24:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto Ld30
        L2c:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto Lcb9
        L34:
            androidx.datastore.preferences.protobuf.bytestring r0 = (androidx.datastore.preferences.protobuf.bytestring) r0
            goto L7ac
        L3a:
            r0 = 18
            goto L272
        L41:
            if (r2 < r9) goto L46
            goto L193
        L46:
            goto L265
        L4a:
            int r5 = r0.numberAt(r2)
            goto Ldb9
        L52:
            goto Ld41
        L54:
            goto Lbbc
        L58:
            goto L26e
        L5a:
            goto Lb3b
        L5e:
            r15 = 0
            goto L6c5
        L63:
            int r7 = r16 << r7
            goto Lbe5
        L69:
            if (r5 != 0) goto L6e
            goto Lb4f
        L6e:
            goto L9e1
        L72:
            r6.writebytes(r14, r5)
            goto L68b
        L79:
            r6.writeInt32(r14, r0)
            goto L737
        L80:
            if (r7 != 0) goto L85
            goto Ld80
        L85:
            goto L79a
        L89:
            int r14 = r0.numberAt(r2)
            goto L588
        L91:
            int r5 = r0.numberAt(r2)
            goto Lbb
        L99:
            r15 = 0
            goto L148
        L9e:
            goto Lb4f
        La0:
            goto L25f
        La4:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L1b2
        Lac:
            int r0 = r10.getInt(r1, r12)
            goto L115
        Lb4:
            r6.writeUInt32(r14, r0)
            goto L640
        Lbb:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lae0
        Lc3:
            java.util.List r12 = (java.util.List) r12
            goto L2bf
        Lc9:
            r14 = 0
            goto Lb99
        Lce:
            r2.serializeExtension(r6, r3)
            goto L492
        Ld5:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeGroupList(r5, r12, r6, r13)
            goto L8b9
        Ldc:
            java.util.List r12 = (java.util.List) r12
            goto L5a8
        Le2:
            r0.writeDictionaryHelper(r6, r14, r5, r2)
            goto L7c0
        Le9:
            int r5 = r0.numberAt(r2)
            goto Lb1a
        Lf1:
            if (r5 != 0) goto Lf6
            goto L7b6
        Lf6:
            goto L963
        Lfa:
            java.util.List r12 = (java.util.List) r12
            goto L5cb
        L100:
            androidx.datastore.preferences.protobuf.FieldHashSet r2 = r2.getExtensions(r1)
            goto L99c
        L108:
            java.util.List r12 = (java.util.List) r12
            goto Lb92
        L10e:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt64List(r5, r12, r6, r14)
            goto L9e
        L115:
            r6.writeEnum(r14, r0)
            goto L9e9
        L11c:
            r6.writeGroup(r14, r5, r12)
            goto La3c
        L123:
            int r5 = r0.numberAt(r2)
            goto L295
        L12b:
            java.util.List r12 = (java.util.List) r12
            goto Lb
        L131:
            java.util.List r12 = (java.util.List) r12
            goto Lc30
        L137:
            r3 = r4
            goto L8b4
        L13c:
            goto Lb4f
        L13e:
            goto Lc1a
        L142:
            bool r2 = r0.hasExtensions
            goto L631
        L148:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L33f
        L150:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lb2a
        L158:
            int r5 = oneofIntAt(r1, r12)
            goto L27f
        L160:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L316
        L168:
            goto L96e
        L16b:
            int r0 = r0 % r1
            goto Lc57
        L171:
            r15 = 0
            goto L691
        L176:
            r15 = 0
            goto L91
        L17b:
            r15 = 0
            goto L49a
        L180:
            double r12 = oneofdoubleAt(r1, r12)
            goto L8ee
        L188:
            if (r5 != 0) goto L18d
            goto Lb4f
        L18d:
            goto L409
        L191:
            goto L2ec
        L193:
            goto L865
        L197:
            int r0 = r0 + r1
            goto L16b
        L19d:
            goto L193
        L19e:
            goto L90c
        L1a2:
            r15 = 0
            goto L918
        L1a7:
            goto Lb4f
        L1a9:
            goto L3df
        L1ad:
            r15 = 0
            goto Ld03
        L1b2:
            if (r5 != 0) goto L1b7
            goto Lb4f
        L1b7:
            goto La4d
        L1bb:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L2f9
        L1c3:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L12b
        L1cb:
            r14 = r16
            goto L668
        L1d1:
            int r5 = r0.numberAt(r2)
            goto L93e
        L1d9:
            int r7 = r7 >>> 20
            goto L63
        L1df:
            if (r15 <= r7) goto L1e4
            goto L5a
        L1e4:
            goto Lca8
        L1e8:
            if (r5 != 0) goto L1ed
            goto L7b6
        L1ed:
            goto L5b5
        L1f1:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeBoolList(r5, r12, r6, r15)
            goto Lde7
        L1f8:
            r6.writeInt64(r14, r12)
            goto Lb0c
        L1ff:
            if (r5 != 0) goto L204
            goto L7b6
        L204:
            goto L484
        L208:
            goto L7
        L20a:
            goto L12
        L20e:
            r3 = 0
            goto L19d
        L213:
            r0.writestring(r14, r5, r6)
            goto L62b
        L21a:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Ld64
        L222:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L3ae
        L22a:
            r12 = r7 & r11
            goto L2f0
        L230:
            goto Lb4f
        L232:
            goto L21a
        L236:
            if (r5 != 0) goto L23b
            goto Lb4f
        L23b:
            goto Lc67
        L23f:
            r14 = r16
            goto La82
        L245:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt64List(r5, r12, r6, r14)
            goto Ld4d
        L24c:
            goto L7
        L24e:
            goto Lb5a
        L252:
            goto Ld41
        L254:
            goto L1a2
        L258:
            r6.writeUInt64(r14, r12)
            goto L7ba
        L25f:
            r14 = r16
            goto L926
        L265:
            int r13 = r0.typeAndOffsetAt(r2)
            goto L89
        L26d:
            r5 = 0
        L26e:
            goto L80
        L272:
            r1 = 19
            goto L197
        L279:
            java.util.List r12 = (java.util.List) r12
            goto L8f5
        L27f:
            r6.writeInt32(r14, r5)
            goto L8a6
        L286:
            int r5 = r0.numberAt(r2)
            goto L88f
        L28e:
            r6.writeSInt64(r14, r12)
            goto L4b1
        L295:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L9cb
        L29d:
            r15 = 0
            goto Le9
        L2a2:
            goto L193
        L2a4:
            goto L20e
        L2a8:
            androidx.datastore.preferences.protobuf.SchemaUtil.writebytesList(r5, r12, r6)
            goto Lbd7
        L2af:
            if (r5 != 0) goto L2b4
            goto Lb4f
        L2b4:
            goto La73
        L2b8:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt64List(r5, r12, r6, r14)
            goto L762
        L2bf:
            androidx.datastore.preferences.protobuf.Schema r13 = r0.getMessageFieldSchema(r2)
            goto Lb53
        L2c7:
            r15 = 0
            goto L904
        L2cc:
            r14 = r16
            goto L874
        L2d2:
            java.util.Dictionary$Entry r3 = (java.util.Dictionary.Entry) r3
            goto L5d2
        L2d8:
            r6.writeEnum(r14, r5)
            goto L230
        L2df:
            r14 = r16
            goto Ldc1
        L2e5:
            r14 = r16
            goto L123
        L2eb:
            r5 = 0
        L2ec:
            goto L41
        L2f0:
            if (r12 != r4) goto L2f5
            goto Laed
        L2f5:
            goto Lb7c
        L2f9:
            java.util.List r12 = (java.util.List) r12
            goto Ld29
        L2ff:
            r15 = 0
            goto L451
        L304:
            goto L7
        L306:
            goto L436
        L30a:
            r0.writeUnknownInMessageTo(r2, r1, r6)
            goto L4b7
        L311:
            r4 = r5
            goto L26d
        L316:
            java.util.List r12 = (java.util.List) r12
            goto Lab0
        L31c:
            java.util.List r12 = (java.util.List) r12
            goto Lbeb
        L322:
            int r5 = r0.numberAt(r2)
            goto L844
        L32a:
            r6.writeBool(r14, r5)
            goto L13c
        L331:
            double r12 = doubleAt(r1, r12)
            goto Ld3e
        L339:
            goto Lb4f
        L33b:
            goto L57a
        L33f:
            if (r5 != 0) goto L344
            goto Ld41
        L344:
            goto L946
        L348:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L770
        L350:
            int r5 = r0.numberAt(r2)
            goto Lda3
        L358:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L131
        L360:
            int r16 = r2 + 2
            goto L9f7
        L366:
            goto L814
        L368:
            goto Lc9a
        L36c:
            java.util.List r12 = (java.util.List) r12
            goto Ld0b
        L372:
            if (r5 != 0) goto L377
            goto Lb4f
        L377:
            goto La26
        L37b:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto L5e5
        L383:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lce7
        L38b:
            java.util.List r12 = (java.util.List) r12
            goto L92e
        L391:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(r5, r12, r6, r14)
            goto Lb06
        L398:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r12 = r0.extensionSchema
            goto La65
        L39e:
            r6.writeMessage(r14, r5, r12)
            goto L801
        L3a5:
            if (r5 != 0) goto L3aa
            goto Lb4f
        L3aa:
            goto L24
        L3ae:
            java.util.List r12 = (java.util.List) r12
            goto L8dc
        L3b4:
            java.util.Dictionary$Entry r7 = (java.util.Dictionary.Entry) r7
            goto L54a
        L3ba:
            java.lang.object r2 = r8.Current
            goto Lae6
        L3c2:
            goto L7b6
        L3c4:
            goto L7f4
        L3c8:
            int r0 = r10.getInt(r1, r12)
            goto L659
        L3d0:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lc22
        L3d8:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt32List(r5, r12, r6, r14)
            goto La42
        L3df:
            int r5 = r0.numberAt(r2)
            goto L222
        L3e7:
            long r12 = oneoflongAt(r1, r12)
            goto Ld12
        L3ef:
            r1 = r19
            goto L564
        L3f5:
            goto Lb4f
        L3f7:
            goto La0a
        L3fb:
            if (r5 != 0) goto L400
            goto L7b6
        L400:
            goto Lc28
        L404:
            r7 = r3
            goto L137
        L409:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto L5d7
        L411:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Lc9f
        L419:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Ldc
        L421:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lc94
        L429:
            goto Ld41
        L42b:
            goto Lb65
        L42f:
            r6.writeSInt32(r14, r0)
            goto L7d4
        L436:
            r14 = 0
            goto L4a
        L43b:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L4a8
        L443:
            androidx.datastore.preferences.protobuf.Schema r13 = r0.getMessageFieldSchema(r2)
            goto Ld5
        L44b:
            java.util.List r12 = (java.util.List) r12
            goto L6a7
        L451:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L84c
        L459:
            if (r5 != 0) goto L45e
            goto L7b6
        L45e:
            goto Labf
        L462:
            r2 = 0
            goto L2eb
        L467:
            int r5 = r0.numberAt(r2)
            goto Lcf5
        L46f:
            int r2 = r2 + 3
            goto L676
        L475:
            java.lang.object r3 = r2.Current
            goto L2d2
        L47d:
            goto L546
        L480:
            goto L855
        L484:
            long r12 = r10.getlong(r1, r12)
            goto L1f8
        L48c:
            goto Lb4f
        L48e:
            goto L17
        L492:
            bool r2 = r8.MoveNext()
            goto L9d8
        L49a:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L954
        L4a2:
            goto Lb4f
        L4a4:
            goto Lab7
        L4a8:
            if (r5 != 0) goto L4ad
            goto Lb4f
        L4ad:
            goto L988
        L4b1:
            goto L7b6
        L4b3:
            goto L2ff
        L4b7:
            return
        L546:
            goto L75b
        L54a:
            goto L26e
        L54c:
            goto L73c
        L550:
            long r12 = oneoflongAt(r1, r12)
            goto L614
        L558:
            goto Lb4f
        L55a:
            goto L23f
        L55e:
            r14 = r16
            goto Lbc1
        L564:
            r6 = r20
            goto L142
        L56a:
            if (r5 != 0) goto L56f
            goto L7b6
        L56f:
            goto L3c8
        L573:
            androidx.datastore.preferences.protobuf.SchemaUtil.writedoubleList(r5, r12, r6, r14)
            goto L747
        L57a:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L69
        L582:
            goto Ld41
        L584:
            goto Laab
        L588:
            int r15 = type(r13)
            goto L5bd
        L590:
            r6.writeSFixed64(r14, r12)
            goto L807
        L597:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L236
        L59f:
            if (r3 == 0) goto L5a4
            goto L368
        L5a4:
            goto L646
        L5a8:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed64List(r5, r12, r6, r14)
            goto L63a
        L5af:
            r14 = r16
            goto Lded
        L5b5:
            long r12 = r10.getlong(r1, r12)
            goto L28e
        L5bd:
            r7 = 17
            goto L1df
        L5c3:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L6e3
        L5cb:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed64List(r5, r12, r6, r14)
            goto L703
        L5d2:
            r8 = r2
            goto L366
        L5d7:
            androidx.datastore.preferences.protobuf.Schema r12 = r0.getMessageFieldSchema(r2)
            goto Ldd8
        L5df:
            goto Lb4f
        L5e1:
            goto L1cb
        L5e5:
            androidx.datastore.preferences.protobuf.Schema r12 = r0.getMessageFieldSchema(r2)
            goto L72a
        L5ed:
            r15 = r14
            goto L920
        L5f2:
            if (r5 != 0) goto L5f7
            goto Lb4f
        L5f7:
            goto L158
        L5fb:
            r15 = 0
            goto L972
        L600:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L990
        L608:
            r6.writeFixed32(r14, r5)
            goto L7e8
        L60f:
            r15 = 0
            goto L8cd
        L614:
            r6.writeSInt64(r14, r12)
            goto La92
        L61b:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt64List(r5, r12, r6, r15)
            goto L8c7
        L622:
            if (r12 <= r14) goto L627
            goto Ld80
        L627:
            goto L398
        L62b:
            goto Ld41
        L62d:
            goto La98
        L631:
            if (r2 != 0) goto L636
            goto L368
        L636:
            goto L782
        L63a:
            goto Lb4f
        L63c:
            goto L55e
        L640:
            goto L7b6
        L642:
            goto L860
        L646:
            java.util.IEnumerator r2 = r2.GetEnumerator()
            goto L475
        L64e:
            goto Ld41
        L650:
            goto L171
        L654:
            r7 = r3
            goto Lb85
        L659:
            r6.writeSFixed32(r14, r0)
            goto L80d
        L660:
            int r0 = r10.getInt(r1, r12)
            goto L824
        L668:
            int r5 = r0.numberAt(r2)
            goto Ldc9
        L670:
            goto Lb4f
        L672:
            goto Lb12
        L676:
            r5 = r4
            goto L87c
        L67b:
            if (r5 != 0) goto L680
            goto L7b6
        L680:
            goto Lac
        L684:
            androidx.datastore.preferences.protobuf.SchemaUtil.writedoubleList(r5, r12, r6, r15)
            goto L252
        L68b:
            goto Lb4f
        L68d:
            goto L83c
        L691:
            int r5 = r0.numberAt(r2)
            goto L3d0
        L699:
            int r5 = r0.numberAt(r2)
            goto Lced
        L6a1:
            goto L7b6
        L6a3:
            goto La48
        L6a7:
            r14 = r16
            goto L10e
        L6ad:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lf1
        L6b5:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L3a5
        L6bd:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Lc6f
        L6c5:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Ld5b
        L6cd:
            long r12 = oneoflongAt(r1, r12)
            goto L258
        L6d5:
            r14 = r16
            goto Lba9
        L6db:
            int r0 = r10.getInt(r1, r12)
            goto L42f
        L6e3:
            java.util.List r12 = (java.util.List) r12
            goto L245
        L6e9:
            if (r5 != 0) goto L6ee
            goto Lb4f
        L6ee:
            goto L6cd
        L6f2:
            if (r7 != 0) goto L6f7
            goto L54c
        L6f7:
            goto L9aa
        L6fb:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L1ff
        L703:
            goto L7
        L705:
            goto Lc8f
        L709:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L44b
        L711:
            if (r5 != 0) goto L716
            goto Lb4f
        L716:
            goto L180
        L71a:
            r6.writeFixed64(r14, r12)
            goto Lbb6
        L721:
            if (r5 != 0) goto L726
            goto L7b6
        L726:
            goto La8a
        L72a:
            r6.writeGroup(r14, r5, r12)
            goto L429
        L731:
            java.util.List r12 = (java.util.List) r12
            goto L78e
        L737:
            goto L7b6
        L738:
            goto Lcdc
        L73c:
            r7 = 0
            goto Ld7e
        L741:
            java.util.List r12 = (java.util.List) r12
            goto Lcc6
        L747:
            goto Lb4f
        L749:
            goto L1d1
        L74d:
            int r5 = r0.numberAt(r2)
            goto L421
        L755:
            goto Lb4f
        L757:
            goto L6d5
        L75b:
            goto L480
        L75e:
            goto L168
        L762:
            goto Lb4f
        L764:
            goto L2df
        L768:
            int r5 = r0.numberAt(r2)
            goto L709
        L770:
            if (r5 != 0) goto L775
            goto Lb4f
        L775:
            goto L550
        L779:
            if (r5 != 0) goto L77e
            goto Ld41
        L77e:
            goto L37b
        L782:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r2 = r0.extensionSchema
            goto L100
        L788:
            java.util.List r12 = (java.util.List) r12
            goto L9d1
        L78e:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed32List(r5, r12, r6, r14)
            goto L304
        L795:
            r3 = r2
            goto L2a2
        L79a:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r12 = r0.extensionSchema
            goto Ldfb
        L7a0:
            goto L7
        L7a2:
            goto Lc9
        L7a6:
            r5 = r17
            goto L58
        L7ac:
            r6.writebytes(r14, r0)
            goto Lcc0
        L7b3:
            r6.writefloat(r14, r0)
        L7b6:
            goto L94e
        L7ba:
            goto Lb4f
        L7bc:
            goto L6bd
        L7c0:
            goto Lb4f
        L7c2:
            goto L350
        L7c6:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L741
        L7ce:
            sun.misc.Unsafe r10 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto Ld9c
        L7d4:
            goto L7b6
        L7d6:
            goto L17b
        L7da:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L459
        L7e2:
            goto Lb4f
        L7e4:
            goto L2e5
        L7e8:
            goto Lb4f
        L7ea:
            goto L597
        L7ee:
            goto Lb4f
        L7f0:
            goto L43b
        L7f4:
            r15 = 0
            goto Lc49
        L7f9:
            int r5 = r0.numberAt(r2)
            goto L82b
        L801:
            goto Ld41
        L803:
            goto L99
        L807:
            goto L7b6
        L809:
            goto Le0e
        L80d:
            goto L7b6
        L80f:
            goto L60f
        L813:
            r8 = 0
        L814:
            goto Lb76
        L818:
            goto Ld41
        L81a:
            goto L29d
        L81e:
            goto Lb4f
        L820:
            goto L8fc
        L824:
            r6.writeFixed32(r14, r0)
            goto L3c2
        L82b:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Ldf5
        L833:
            if (r5 != 0) goto L838
            goto L7b6
        L838:
            goto Lb22
        L83c:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L188
        L844:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lc3
        L84c:
            if (r5 != 0) goto L851
            goto L7b6
        L851:
            goto L6db
        L855:
            r0 = r18
            goto L3ef
        L85b:
            int r9 = r2.length
            goto L7ce
        L860:
            r15 = 0
            goto L7da
        L865:
            if (r3 != 0) goto L86a
            goto L19e
        L86a:
            goto Lce1
        L86e:
            goto Ld41
        L870:
            goto L176
        L874:
            int r5 = r0.numberAt(r2)
            goto La55
        L87c:
            r4 = r3
            goto Ldab
        L881:
            if (r5 != 0) goto L886
            goto L7b6
        L886:
            goto Lc0d
        L88a:
            long r4 = (long) r12
            goto Lbcf
        L88f:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L731
        L897:
            r6.writeUInt64(r14, r12)
            goto L6a1
        L89e:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L279
        L8a6:
            goto Lb4f
        L8a8:
            goto La02
        L8ac:
            int r5 = r0.numberAt(r2)
            goto Lad8
        L8b4:
            r4 = r5
            goto L7a6
        L8b9:
            goto Lb4f
        L8bb:
            goto L768
        L8bf:
            int r5 = r0.numberAt(r2)
            goto L419
        L8c7:
            goto Ld41
        L8c9:
            goto L1f
        L8cd:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L67b
        L8d5:
            r6.writeSInt32(r14, r5)
            goto L81e
        L8dc:
            r15 = 0
            goto L1f1
        L8e1:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed64List(r5, r12, r6, r15)
            goto L582
        L8e8:
            r16 = 1
            goto L22a
        L8ee:
            r6.writedouble(r14, r12)
            goto L912
        L8f5:
            androidx.datastore.preferences.protobuf.SchemaUtil.writestringList(r5, r12, r6)
            goto L1a7
        L8fc:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L2af
        L904:
            int r5 = r0.numberAt(r2)
            goto La5d
        L90c:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r2 = r0.unknownFieldSchema
            goto L30a
        L912:
            goto Lb4f
        L914:
            goto L980
        L918:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L779
        L920:
            goto Ld41
        L922:
            goto L7f9
        L926:
            int r5 = r0.numberAt(r2)
            goto Lc7f
        L92e:
            androidx.datastore.preferences.protobuf.SchemaUtil.writefloatList(r5, r12, r6, r15)
            goto L9b8
        L935:
            if (r5 != 0) goto L93a
            goto Ld41
        L93a:
            goto L331
        L93e:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L31c
        L946:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto L213
        L94e:
            r0 = r18
            goto L52
        L954:
            if (r5 != 0) goto L959
            goto L7b6
        L959:
            goto Ld21
        L95d:
            goto Lb4f
        L95f:
            goto La10
        L963:
            long r12 = r10.getlong(r1, r12)
            goto L897
        L96b:
            goto L75e
        L96e:
            goto L3a
        L972:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L881
        L97a:
            androidx.datastore.preferences.protobuf.bytestring r5 = (androidx.datastore.preferences.protobuf.bytestring) r5
            goto L72
        L980:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto Le2
        L988:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto L97a
        L990:
            java.util.List r12 = (java.util.List) r12
            goto L4
        L996:
            java.util.List r12 = (java.util.List) r12
            goto Lc42
        L99c:
            bool r3 = r2.Count == 0
            goto L59f
        L9a4:
            goto Lb4f
        L9a6:
            goto Lcb3
        L9aa:
            java.lang.object r7 = r8.Current
            goto L3b4
        L9b2:
            java.util.List r12 = (java.util.List) r12
            goto L2b8
        L9b8:
            goto Ld41
        L9ba:
            goto L2c7
        L9be:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt64List(r5, r12, r6, r14)
            goto L208
        L9c5:
            r14 = r16
            goto L699
        L9cb:
            java.util.List r12 = (java.util.List) r12
            goto L573
        L9d1:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed64List(r5, r12, r6, r14)
            goto L558
        L9d8:
            if (r2 != 0) goto L9dd
            goto L2a4
        L9dd:
            goto L3ba
        L9e1:
            float r5 = oneoffloatAt(r1, r12)
            goto Lcd5
        L9e9:
            goto L7b6
        L9eb:
            goto Lc15
        L9ef:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L36c
        L9f7:
            r7 = r7[r16]
            goto L8e8
        L9fd:
            r15 = 0
            goto L150
        La02:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L6e9
        La0a:
            r14 = r16
            goto Ld19
        La10:
            int r5 = r0.numberAt(r2)
            goto L89e
        La18:
            int r5 = oneofIntAt(r1, r12)
            goto Laf9
        La20:
            goto Lb4f
        La22:
            goto La4
        La26:
            int r5 = oneofIntAt(r1, r12)
            goto L2d8
        La2e:
            r14 = r16
            goto L8ac
        La34:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L3fb
        La3c:
            goto Lb4f
        La3e:
            goto L348
        La42:
            goto Lb4f
        La44:
            goto L2cc
        La48:
            r15 = 0
            goto L6fb
        La4d:
            int r5 = oneofIntAt(r1, r12)
            goto Ldd1
        La55:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L788
        La5d:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto La9d
        La65:
            r12.serializeExtension(r6, r7)
            goto Laa3
        La6c:
            r6.writeFixed64(r14, r12)
            goto L670
        La73:
            long r12 = oneoflongAt(r1, r12)
            goto Lb41
        La7b:
            r6.writeBool(r14, r0)
            goto Lbc9
        La82:
            int r5 = r0.numberAt(r2)
            goto L9ef
        La8a:
            int r0 = r10.getInt(r1, r12)
            goto Lb4
        La92:
            goto Lb4f
        La94:
            goto Lb33
        La98:
            r15 = 0
            goto La34
        La9d:
            java.util.List r12 = (java.util.List) r12
            goto L684
        Laa3:
            bool r7 = r8.MoveNext()
            goto L6f2
        Laab:
            r15 = 0
            goto Lb8a
        Lab0:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeBoolList(r5, r12, r6, r14)
            goto Lc37
        Lab7:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Ld6d
        Labf:
            java.lang.object r0 = r10.getobject(r1, r12)
            goto L34
        Lac7:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L1e8
        Lacf:
            if (r5 != 0) goto Lad4
            goto Lb4f
        Lad4:
            goto Ld53
        Lad8:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L9b2
        Lae0:
            java.util.List r12 = (java.util.List) r12
            goto L61b
        Lae6:
            java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2
            goto L795
        Laec:
            r4 = r12
        Laed:
            goto L1d9
        Laf1:
            int r0 = r10.getInt(r1, r12)
            goto L79
        Laf9:
            r6.writeUInt32(r14, r5)
            goto L7ee
        Lb00:
            goto Lb4f
        Lb02:
            goto L411
        Lb06:
            goto Lb4f
        Lb08:
            goto La2e
        Lb0c:
            goto L7b6
        Lb0e:
            goto L5fb
        Lb12:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L5f2
        Lb1a:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L38b
        Lb22:
            long r12 = r10.getlong(r1, r12)
            goto L71a
        Lb2a:
            if (r5 != 0) goto Lb2f
            goto Ld41
        Lb2f:
            goto Lccd
        Lb33:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Lc04
        Lb3b:
            r16 = 1
            goto L654
        Lb41:
            r6.writeSFixed64(r14, r12)
            goto La20
        Lb48:
            long r12 = offset(r13)
            switch(r15) {
                case 0: goto L54;
                case 1: goto Lb0e;
                case 2: goto L6a3;
                case 3: goto L738;
                case 4: goto Lbb8;
                case 5: goto L3c4;
                case 6: goto Lbcb;
                case 7: goto L62d;
                case 8: goto L803;
                case 9: goto Lcc2;
                case 10: goto L642;
                case 11: goto L9eb;
                case 12: goto L80f;
                case 13: goto L809;
                case 14: goto L7d6;
                case 15: goto L4b3;
                case 16: goto L42b;
                case 17: goto L254;
                case 18: goto L9ba;
                case 19: goto L81a;
                case 20: goto L8c9;
                case 21: goto L870;
                case 22: goto L584;
                case 23: goto L650;
                case 24: goto Lde9;
                case 25: goto L1a9;
                case 26: goto L95f;
                case 27: goto Lbd9;
                case 28: goto L922;
                case 29: goto L7a2;
                case 30: goto L306;
                case 31: goto L705;
                case 32: goto L24e;
                case 33: goto L20a;
                case 34: goto L749;
                case 35: goto L7e4;
                case 36: goto Ld4f;
                case 37: goto L764;
                case 38: goto Lb08;
                case 39: goto L63c;
                case 40: goto L9a6;
                case 41: goto Lc39;
                case 42: goto L3f7;
                case 43: goto L757;
                case 44: goto L5e1;
                case 45: goto L55a;
                case 46: goto La44;
                case 47: goto La0;
                case 48: goto L8bb;
                case 49: goto L7c2;
                case 50: goto L914;
                case 51: goto Lc00;
                case 52: goto L33b;
                case 53: goto L7bc;
                case 54: goto L8a8;
                case 55: goto L672;
                case 56: goto L7ea;
                case 57: goto L13e;
                case 58: goto L4a4;
                case 59: goto Lb02;
                case 60: goto L68d;
                case 61: goto L7f0;
                case 62: goto L232;
                case 63: goto L48e;
                case 64: goto La22;
                case 65: goto L820;
                case 66: goto La94;
                case 67: goto La3e;
                case 68: goto Ld3a;
                default: goto Lb4f;
            }
        Lb4f:
            goto Lc3d
        Lb53:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeMessageList(r5, r12, r6, r13)
            goto L95d
        Lb5a:
            r14 = 0
            goto L467
        Lb5f:
            java.util.List r12 = (java.util.List) r12
            goto Lb6a
        Lb65:
            r15 = 0
            goto Lac7
        Lb6a:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeEnumList(r5, r12, r6, r14)
            goto L755
        Lb71:
            r4 = r11
            goto L462
        Lb76:
            int[] r2 = r0.buffer
            goto L85b
        Lb7c:
            if (r12 == r11) goto Lb81
            goto Lcff
        Lb81:
            goto Lcae
        Lb85:
            r3 = r4
            goto L311
        Lb8a:
            int r5 = r0.numberAt(r2)
            goto L358
        Lb92:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeEnumList(r5, r12, r6, r14)
            goto L7a0
        Lb99:
            int r5 = r0.numberAt(r2)
            goto L600
        Lba1:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto L711
        Lba9:
            int r5 = r0.numberAt(r2)
            goto Ld84
        Lbb1:
            r5 = r4
        Lbb2:
            goto Laec
        Lbb6:
            goto L7b6
        Lbb8:
            goto L1ad
        Lbbc:
            r15 = 0
            goto Lc87
        Lbc1:
            int r5 = r0.numberAt(r2)
            goto L383
        Lbc9:
            goto L7b6
        Lbcb:
            goto L5e
        Lbcf:
            int r4 = r10.getInt(r1, r4)
            goto Lbb1
        Lbd7:
            goto Lb4f
        Lbd9:
            goto L322
        Lbdd:
            int r5 = oneofIntAt(r1, r12)
            goto L8d5
        Lbe5:
            r17 = r7
            goto L404
        Lbeb:
            r14 = 0
            goto L9be
        Lbf0:
            int r5 = r0.numberAt(r2)
            goto L7c6
        Lbf8:
            java.util.List r12 = (java.util.List) r12
            goto L443
        Lbfe:
            goto Lb4f
        Lc00:
            goto Lba1
        Lc04:
            if (r5 != 0) goto Lc09
            goto Lb4f
        Lc09:
            goto Lbdd
        Lc0d:
            float r0 = floatAt(r1, r12)
            goto L7b3
        Lc15:
            r15 = 0
            goto Ld76
        Lc1a:
            bool r5 = r0.isOneofPresent(r1, r14, r2)
            goto Lacf
        Lc22:
            java.util.List r12 = (java.util.List) r12
            goto L8e1
        Lc28:
            bool r0 = boolAt(r1, r12)
            goto La7b
        Lc30:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(r5, r12, r6, r15)
            goto L86e
        Lc37:
            goto Lb4f
        Lc39:
            goto L5af
        Lc3d:
            r15 = 0
            goto Ld38
        Lc42:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt32List(r5, r12, r6, r14)
            goto L3f5
        Lc49:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L833
        Lc51:
            java.util.List r12 = (java.util.List) r12
            goto Lc78
        Lc57:
            if (r0 <= 0) goto Lc5c
            goto L480
        Lc5c:
            goto L47d
        Lc60:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed32List(r5, r12, r6, r15)
            goto L64e
        Lc67:
            long r12 = oneoflongAt(r1, r12)
            goto La6c
        Lc6f:
            if (r5 != 0) goto Lc74
            goto Lb4f
        Lc74:
            goto L3e7
        Lc78:
            androidx.datastore.preferences.protobuf.SchemaUtil.writefloatList(r5, r12, r6, r14)
            goto L7e2
        Lc7f:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Le03
        Lc87:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L935
        Lc8f:
            r14 = 0
            goto L286
        Lc94:
            java.util.List r12 = (java.util.List) r12
            goto Lc60
        Lc9a:
            r3 = 0
            goto L813
        Lc9f:
            if (r5 != 0) goto Lca4
            goto Lb4f
        Lca4:
            goto L2c
        Lca8:
            int[] r7 = r0.buffer
            goto L360
        Lcae:
            r5 = 0
            goto Lcfd
        Lcb3:
            r14 = r16
            goto L8bf
        Lcb9:
            r0.writestring(r14, r5, r6)
            goto L4a2
        Lcc0:
            goto L7b6
        Lcc2:
            goto L9fd
        Lcc6:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt32List(r5, r12, r6, r14)
            goto L24c
        Lccd:
            java.lang.object r5 = r10.getobject(r1, r12)
            goto Ld94
        Lcd5:
            r6.writefloat(r14, r5)
            goto Lbfe
        Lcdc:
            r15 = 0
            goto L6ad
        Lce1:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r2 = r0.extensionSchema
            goto Lce
        Lce7:
            java.util.List r12 = (java.util.List) r12
            goto L391
        Lced:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lc51
        Lcf5:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lfa
        Lcfd:
            goto Lbb2
        Lcff:
            goto L88a
        Ld03:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Ldb0
        Ld0b:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed32List(r5, r12, r6, r14)
            goto L5df
        Ld12:
            r6.writeInt64(r14, r12)
            goto L339
        Ld19:
            int r5 = r0.numberAt(r2)
            goto L160
        Ld21:
            long r12 = r10.getlong(r1, r12)
            goto L590
        Ld29:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed32List(r5, r12, r6, r14)
            goto L9a4
        Ld30:
            androidx.datastore.preferences.protobuf.Schema r12 = r0.getMessageFieldSchema(r2)
            goto L11c
        Ld38:
            goto Ld41
        Ld3a:
            goto L6b5
        Ld3e:
            r6.writedouble(r14, r12)
        Ld41:
            goto L46f
        Ld45:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L56a
        Ld4d:
            goto Lb4f
        Ld4f:
            goto L9c5
        Ld53:
            int r5 = oneofIntAt(r1, r12)
            goto L608
        Ld5b:
            if (r5 != 0) goto Ld60
            goto L7b6
        Ld60:
            goto L660
        Ld64:
            if (r5 != 0) goto Ld69
            goto Lb4f
        Ld69:
            goto La18
        Ld6d:
            if (r5 != 0) goto Ld72
            goto Lb4f
        Ld72:
            goto Ld8c
        Ld76:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L721
        Ld7e:
            goto L26e
        Ld80:
            goto Lb48
        Ld84:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L996
        Ld8c:
            bool r5 = oneofboolAt(r1, r12)
            goto L32a
        Ld94:
            androidx.datastore.preferences.protobuf.Schema r12 = r0.getMessageFieldSchema(r2)
            goto L39e
        Ld9c:
            r11 = 1048575(0xfffff, float:1.469367E-39)
            goto Lb71
        Lda3:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lbf8
        Ldab:
            r3 = r7
            goto L191
        Ldb0:
            if (r5 != 0) goto Ldb5
            goto L7b6
        Ldb5:
            goto Laf1
        Ldb9:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto L108
        Ldc1:
            int r5 = r0.numberAt(r2)
            goto L5c3
        Ldc9:
            java.lang.object r12 = r10.getobject(r1, r12)
            goto Lb5f
        Ldd1:
            r6.writeSFixed32(r14, r5)
            goto L48c
        Ldd8:
            r6.writeMessage(r14, r5, r12)
            goto Lb00
        Lddf:
            int r5 = r0.numberAt(r2)
            goto L1c3
        Lde7:
            goto Ld41
        Lde9:
            goto Le09
        Lded:
            int r5 = r0.numberAt(r2)
            goto L1bb
        Ldf5:
            java.util.List r12 = (java.util.List) r12
            goto L2a8
        Ldfb:
            int r12 = r12.extensionNumber(r7)
            goto L622
        Le03:
            java.util.List r12 = (java.util.List) r12
            goto L3d8
        Le09:
            r15 = 0
            goto L74d
        Le0e:
            r15 = 0
            goto Ld45
    }

    private void WriteFieldsInDescendingOrder(T r11, androidx.datastore.preferences.protobuf.Writer r12) throws java.io.IOException {
            r10 = this;
            goto L49b
        L4:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Ld4b
        Lc:
            java.util.List r4 = (java.util.List) r4
            goto L115
        L12:
            androidx.datastore.preferences.protobuf.SchemaUtil.writestringList(r5, r4, r12)
            goto L357
        L19:
            goto L753
        L1b:
            goto L6d7
        L1f:
            long r8 = offset(r4)
            goto L575
        L27:
            int r5 = r10.numberAt(r3)
            goto L748
        L2f:
            goto L753
        L31:
            goto L8b9
        L35:
            goto L5f1
        L37:
            goto La0d
        L3b:
            r12.writebytes(r5, r4)
            goto Lb38
        L42:
            r12.writeMessage(r5, r4, r6)
            goto L9ff
        L49:
            if (r6 != 0) goto L4e
            goto L753
        L4e:
            goto L5d9
        L52:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L3d7
        L5a:
            r12.writeUInt32(r5, r4)
            goto L26a
        L61:
            long r6 = offset(r4)
            goto L222
        L69:
            long r8 = offset(r4)
            goto L62e
        L71:
            r12.writeUInt32(r5, r4)
            goto L542
        L78:
            if (r6 != 0) goto L7d
            goto L753
        L7d:
            goto Laf3
        L81:
            java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2
            goto L893
        L87:
            goto L753
        L89:
            goto Ld43
        L8d:
            int r5 = r10.numberAt(r3)
            goto L60b
        L95:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L9d
        L9d:
            if (r6 != 0) goto La2
            goto L753
        La2:
            goto L342
        La6:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r6 = r10.extensionSchema
            goto Ld51
        Lac:
            if (r2 != 0) goto Lb1
            goto La4f
        Lb1:
            goto La6
        Lb5:
            long r6 = offset(r4)
            goto L2fc
        Lbd:
            long r6 = oneoflongAt(r11, r6)
            goto Ld79
        Lc5:
            r12.writeSInt64(r5, r6)
            goto Ld80
        Lcc:
            int r5 = r10.numberAt(r3)
            goto L3b8
        Ld4:
            if (r6 != 0) goto Ld9
            goto L753
        Ld9:
            goto L6ed
        Ldd:
            long r6 = offset(r4)
            goto L850
        Le5:
            if (r6 != 0) goto Lea
            goto L753
        Lea:
            goto Lc83
        Lee:
            if (r6 != 0) goto Lf3
            goto L753
        Lf3:
            goto Lbe4
        Lf7:
            r1 = 2
            goto Lc4a
        Lfe:
            androidx.datastore.preferences.protobuf.SchemaUtil.writedoubleList(r5, r4, r12, r7)
            goto Lb4d
        L105:
            long r8 = offset(r4)
            goto L792
        L10d:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L7fc
        L115:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt64List(r5, r4, r12, r7)
            goto L885
        L11c:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L87f
        L124:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L8e8
        L12c:
            r12.writeInt32(r5, r4)
            goto Lac2
        L133:
            androidx.datastore.preferences.protobuf.FieldHashSet r0 = r0.getExtensions(r11)
            goto Lb71
        L13b:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L6c5
        L143:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto La27
        L14b:
            long r6 = offset(r4)
            goto L10d
        L153:
            java.util.List r4 = (java.util.List) r4
            goto L48c
        L159:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L1e6
        L161:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed32List(r5, r4, r12, r8)
            goto Lbb0
        L168:
            java.util.List r4 = (java.util.List) r4
            goto Lc6d
        L16e:
            java.util.List r4 = (java.util.List) r4
            goto L8ee
        L174:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L583
        L17c:
            if (r6 != 0) goto L181
            goto L753
        L181:
            goto L30d
        L185:
            if (r6 != 0) goto L18a
            goto L753
        L18a:
            goto Le53
        L18e:
            goto L753
        L190:
            goto L8a2
        L194:
            goto L753
        L196:
            goto Lcc0
        L19a:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeBoolList(r5, r4, r12, r8)
            goto L5a6
        L1a1:
            int r4 = intAt(r11, r6)
            goto L12c
        L1a9:
            java.util.List r4 = (java.util.List) r4
            goto Lc99
        L1af:
            goto L753
        L1b1:
            goto L27
        L1b5:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L6ce
        L1bd:
            r8 = 0
            switch(r6) {
                case 0: goto L5d5;
                case 1: goto Lbe0;
                case 2: goto L5f7;
                case 3: goto Lac4;
                case 4: goto L256;
                case 5: goto L472;
                case 6: goto L7c9;
                case 7: goto L623;
                case 8: goto L9ef;
                case 9: goto Ldc4;
                case 10: goto L26c;
                case 11: goto Lb6d;
                case 12: goto L8dc;
                case 13: goto L1c7;
                case 14: goto L89;
                case 15: goto Ld82;
                case 16: goto L1b;
                case 17: goto Lcef;
                case 18: goto L596;
                case 19: goto Lc29;
                case 20: goto L777;
                case 21: goto Le05;
                case 22: goto L31;
                case 23: goto L2a6;
                case 24: goto L5a8;
                case 25: goto L359;
                case 26: goto Lb24;
                case 27: goto L91c;
                case 28: goto L1b1;
                case 29: goto L59c;
                case 30: goto Lbb2;
                case 31: goto L922;
                case 32: goto L4f1;
                case 33: goto L57f;
                case 34: goto Lb4f;
                case 35: goto L4b4;
                case 36: goto L429;
                case 37: goto L190;
                case 38: goto Le10;
                case 39: goto L72b;
                case 40: goto La3b;
                case 41: goto L7a4;
                case 42: goto L3a6;
                case 43: goto Lbac;
                case 44: goto L3cb;
                case 45: goto La65;
                case 46: goto L400;
                case 47: goto L887;
                case 48: goto L1da;
                case 49: goto Lc61;
                case 50: goto Ldd2;
                case 51: goto Lc1b;
                case 52: goto L2f0;
                case 53: goto L6e9;
                case 54: goto L250;
                case 55: goto L21e;
                case 56: goto L9fb;
                case 57: goto Ld02;
                case 58: goto L196;
                case 59: goto La01;
                case 60: goto Lb3a;
                case 61: goto L544;
                case 62: goto L76a;
                case 63: goto L3b4;
                case 64: goto Ld28;
                case 65: goto L1cd;
                case 66: goto L615;
                case 67: goto L27a;
                case 68: goto L9f5;
                default: goto L1c1;
            }
        L1c1:
            goto L9f3
        L1c5:
            goto L753
        L1c7:
            goto Le4b
        L1cb:
            goto L753
        L1cd:
            goto L174
        L1d1:
            r10.writestring(r5, r4, r12)
            goto L194
        L1d8:
            goto L753
        L1da:
            goto L695
        L1de:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto L71c
        L1e6:
            if (r6 != 0) goto L1eb
            goto L753
        L1eb:
            goto L3cf
        L1ef:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L4fd
        L1f7:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto La30
        L1ff:
            r12.writeInt64(r5, r6)
            goto L2ee
        L206:
            r12.writeSFixed64(r5, r6)
            goto L1c5
        L20d:
            float r4 = oneoffloatAt(r11, r6)
            goto La53
        L215:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeBoolList(r5, r4, r12, r7)
            goto L7a2
        L21c:
            goto L753
        L21e:
            goto L79a
        L222:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L68f
        L22a:
            long r6 = offset(r4)
            goto Le43
        L232:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt64List(r5, r4, r12, r8)
            goto Lc27
        L239:
            java.util.Dictionary$Entry r2 = (java.util.Dictionary.Entry) r2
            goto La69
        L23f:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L1d1
        L247:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed64List(r5, r4, r12, r7)
            goto L729
        L24e:
            goto L753
        L250:
            goto L942
        L254:
            goto L753
        L256:
            goto L5fb
        L25a:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L315
        L262:
            int r5 = r10.numberAt(r3)
            goto L7b0
        L26a:
            goto L753
        L26c:
            goto L4aa
        L270:
            long r8 = offset(r4)
            goto Lc0b
        L278:
            goto L753
        L27a:
            goto L1f7
        L27e:
            int r5 = r10.numberAt(r3)
            goto L31b
        L286:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt64List(r5, r4, r12, r7)
            goto L427
        L28d:
            java.util.Dictionary$Entry r11 = (java.util.Dictionary.Entry) r11
            goto L2da
        L293:
            int r3 = r3 + (-3)
            goto L5ef
        L299:
            r1 = 0
            goto L9e4
        L29e:
            java.util.List r4 = (java.util.List) r4
            goto L232
        L2a4:
            goto L753
        L2a6:
            goto L35d
        L2aa:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L677
        L2b2:
            if (r6 != 0) goto L2b7
            goto L753
        L2b7:
            goto La19
        L2bb:
            long r6 = offset(r4)
            goto L8f5
        L2c3:
            goto Le36
        L2c6:
            goto L67d
        L2ca:
            long r6 = offset(r4)
            goto L44c
        L2d2:
            long r6 = offset(r4)
            goto Lb30
        L2da:
            r2 = r11
            goto L35
        L2df:
            long r6 = longAt(r11, r6)
            goto Lc5
        L2e7:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt64List(r5, r4, r12, r7)
            goto L18e
        L2ee:
            goto L753
        L2f0:
            goto L6df
        L2f4:
            java.lang.object r2 = r0.Current
            goto L81
        L2fc:
            long r6 = longAt(r11, r6)
            goto L206
        L304:
            if (r11 != 0) goto L309
            goto L37
        L309:
            goto L78a
        L30d:
            long r6 = offset(r4)
            goto Lb3e
        L315:
            java.util.List r4 = (java.util.List) r4
            goto L161
        L31b:
            long r6 = offset(r4)
            goto L4cf
        L323:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Le5
        L32b:
            java.util.List r4 = (java.util.List) r4
            goto L722
        L331:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Ldf5
        L339:
            if (r6 != 0) goto L33e
            goto L753
        L33e:
            goto Le2b
        L342:
            long r6 = offset(r4)
            goto L5cb
        L34a:
            r2 = r1
            goto La4d
        L34f:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto Ld34
        L357:
            goto L753
        L359:
            goto Ld2c
        L35d:
            int r5 = r10.numberAt(r3)
            goto L548
        L365:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L153
        L36d:
            long r6 = offset(r4)
            goto L757
        L375:
            long r8 = offset(r4)
            goto L88b
        L37d:
            java.util.IEnumerator r0 = r0.descendingIEnumerator()
            goto L2f4
        L385:
            if (r2 == 0) goto L38a
            goto L895
        L38a:
            goto L37d
        L38e:
            int r5 = r10.numberAt(r3)
            goto Ld9d
        L396:
            java.util.List r4 = (java.util.List) r4
            goto Laab
        L39c:
            long r6 = offset(r4)
            goto Ld0e
        L3a4:
            goto L753
        L3a6:
            goto L860
        L3aa:
            long r6 = offset(r4)
            goto Ld3b
        L3b2:
            goto L753
        L3b4:
            goto Lc03
        L3b8:
            long r6 = offset(r4)
            goto L124
        L3c0:
            if (r6 != 0) goto L3c5
            goto L753
        L3c5:
            goto Lcb1
        L3c9:
            goto L753
        L3cb:
            goto Lda5
        L3cf:
            long r6 = offset(r4)
            goto Lbd
        L3d7:
            if (r6 != 0) goto L3dc
            goto L753
        L3dc:
            goto L47e
        L3e0:
            long r6 = offset(r4)
            goto Lc74
        L3e8:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L665
        L3f0:
            androidx.datastore.preferences.protobuf.bytestring r4 = (androidx.datastore.preferences.protobuf.bytestring) r4
            goto L5ac
        L3f6:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto La5a
        L3fe:
            goto L753
        L400:
            goto L80a
        L404:
            r12.writeUInt64(r5, r6)
            goto L5f5
        L40b:
            int r3 = r3.length
            goto L5a0
        L410:
            long r6 = offset(r4)
            goto Lac8
        L418:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeMessageList(r5, r4, r12, r6)
            goto Lb22
        L41f:
            long r8 = offset(r4)
            goto L1de
        L427:
            goto L753
        L429:
            goto Lb79
        L42d:
            long r6 = offset(r4)
            goto Lab2
        L435:
            r12.writeGroup(r5, r4, r6)
            goto L278
        L43c:
            java.lang.object r2 = r0.Current
            goto L239
        L444:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto La21
        L44c:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L8b2
        L454:
            r12.writeSInt32(r5, r4)
            goto L87
        L45b:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed64List(r5, r4, r12, r8)
            goto L920
        L462:
            java.util.List r4 = (java.util.List) r4
            goto Lcf3
        L468:
            int r6 = type(r4)
            goto Le09
        L470:
            goto L753
        L472:
            goto L143
        L476:
            int r5 = r10.numberAt(r3)
            goto L1f
        L47e:
            long r6 = offset(r4)
            goto L7ec
        L486:
            java.util.List r4 = (java.util.List) r4
            goto L934
        L48c:
            androidx.datastore.preferences.protobuf.SchemaUtil.writedoubleList(r5, r4, r12, r8)
            goto Lced
        L493:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto Ld59
        L49b:
            goto L2c6
        L49e:
            goto L70d
        L4a2:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L636
        L4aa:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L2b2
        L4b2:
            goto L753
        L4b4:
            goto L5b3
        L4b8:
            if (r6 != 0) goto L4bd
            goto L753
        L4bd:
            goto L3e0
        L4c1:
            long r6 = offset(r4)
            goto Lddd
        L4c9:
            java.util.List r4 = (java.util.List) r4
            goto Lb14
        L4cf:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L53c
        L4d7:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L185
        L4df:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L17c
        L4e7:
            int r5 = r10.numberAt(r3)
            goto L14b
        L4ef:
            goto L753
        L4f1:
            goto Lb63
        L4f5:
            int r4 = intAt(r11, r6)
            goto Ldd6
        L4fd:
            if (r6 != 0) goto L502
            goto L753
        L502:
            goto L646
        L506:
            r12.writeGroup(r5, r4, r6)
            goto L19
        L50d:
            r12.writeEnum(r5, r4)
            goto Lb6b
        L514:
            if (r6 != 0) goto L519
            goto L753
        L519:
            goto L2d2
        L51d:
            long r6 = offset(r4)
            goto L11c
        L525:
            int r5 = r10.numberAt(r3)
            goto L7d4
        L52d:
            int r4 = oneofIntAt(r11, r6)
            goto L76e
        L535:
            r12.writeSFixed64(r5, r6)
            goto Ld26
        L53c:
            java.util.List r4 = (java.util.List) r4
            goto L55f
        L542:
            goto L753
        L544:
            goto L6f5
        L548:
            long r6 = offset(r4)
            goto Ld95
        L550:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L506
        L558:
            r12.writeSFixed32(r5, r4)
            goto L8da
        L55f:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L418
        L567:
            java.util.List r4 = (java.util.List) r4
            goto Lc43
        L56d:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Lae5
        L575:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto L812
        L57d:
            goto L753
        L57f:
            goto L90c
        L583:
            if (r6 != 0) goto L588
            goto L753
        L588:
            goto L36d
        L58c:
            double r6 = doubleAt(r11, r6)
            goto L750
        L594:
            goto L753
        L596:
            goto L262
        L59a:
            goto L753
        L59c:
            goto L6fd
        L5a0:
            int r3 = r3 + (-3)
        L5a2:
            goto L73f
        L5a6:
            goto L753
        L5a8:
            goto L4e7
        L5ac:
            r12.writebytes(r5, r4)
            goto Ldc2
        L5b3:
            int r5 = r10.numberAt(r3)
            goto Lb5b
        L5bb:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L827
        L5c3:
            long r6 = offset(r4)
            goto L2aa
        L5cb:
            int r4 = oneofIntAt(r11, r6)
            goto L818
        L5d3:
            goto L753
        L5d5:
            goto Ld71
        L5d9:
            long r6 = offset(r4)
            goto L52d
        L5e1:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto Lcd6
        L5e9:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r6 = r10.extensionSchema
            goto L7cd
        L5ef:
            goto L5a2
        L5f1:
            goto L899
        L5f5:
            goto L753
        L5f7:
            goto Ldba
        L5fb:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Lbd5
        L603:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L3f0
        L60b:
            long r8 = offset(r4)
            goto L56d
        L613:
            goto L753
        L615:
            goto L5bb
        L619:
            long r6 = offset(r4)
            goto L58c
        L621:
            goto L753
        L623:
            goto L1ef
        L627:
            r12.writeSInt64(r5, r6)
            goto L613
        L62e:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Lcfa
        L636:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L435
        L63e:
            long r6 = offset(r4)
            goto L5e1
        L646:
            long r6 = offset(r4)
            goto Lc35
        L64e:
            int r4 = r10.typeAndOffsetAt(r3)
            goto L65d
        L656:
            r12.writeBool(r5, r4)
            goto Ld00
        L65d:
            int r5 = r10.numberAt(r3)
        L661:
            goto Lac
        L665:
            r12.writeMessage(r5, r4, r6)
            goto L9ed
        L66c:
            goto L5f1
        L66d:
            goto L951
        L671:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r10.unknownFieldSchema
            goto Lc50
        L677:
            java.util.List r4 = (java.util.List) r4
            goto L45b
        L67d:
            goto L49e
        L680:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeGroupList(r5, r4, r12, r6)
            goto L1d8
        L687:
            int r5 = r10.numberAt(r3)
            goto L42d
        L68f:
            java.util.List r4 = (java.util.List) r4
            goto La3f
        L695:
            int r5 = r10.numberAt(r3)
            goto L8c1
        L69d:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L6b5
        L6a5:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto Lbcf
        L6ad:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L49
        L6b5:
            if (r6 != 0) goto L6ba
            goto L753
        L6ba:
            goto Lc2d
        L6be:
            r12.writeFixed64(r5, r6)
            goto L254
        L6c5:
            if (r6 != 0) goto L6ca
            goto L753
        L6ca:
            goto L840
        L6ce:
            if (r6 != 0) goto L6d3
            goto L753
        L6d3:
            goto Lbc7
        L6d7:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L78
        L6df:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L339
        L6e7:
            goto L753
        L6e9:
            goto L1b5
        L6ed:
            long r6 = offset(r4)
            goto Lded
        L6f5:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Lba1
        L6fd:
            int r5 = r10.numberAt(r3)
            goto L4c1
        L705:
            int r5 = r10.numberAt(r3)
            goto L39c
        L70d:
            r0 = 19
            goto Lf7
        L714:
            long r6 = offset(r4)
            goto Ld61
        L71c:
            java.util.List r4 = (java.util.List) r4
            goto L2e7
        L722:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed64List(r5, r4, r12, r8)
            goto L2f
        L729:
            goto L753
        L72b:
            goto Lc57
        L72f:
            if (r6 != 0) goto L734
            goto L753
        L734:
            goto Lb5
        L738:
            r12.writeBool(r5, r4)
            goto L7c7
        L73f:
            if (r3 >= 0) goto L744
            goto L5f1
        L744:
            goto L64e
        L748:
            long r6 = offset(r4)
            goto Lafb
        L750:
            r12.writedouble(r5, r6)
        L753:
            goto L293
        L757:
            long r6 = oneoflongAt(r11, r6)
            goto L535
        L75f:
            if (r6 > r5) goto L764
            goto La4f
        L764:
            goto L5e9
        L768:
            goto L753
        L76a:
            goto L77b
        L76e:
            r12.writeSFixed32(r5, r4)
            goto L3b2
        L775:
            goto L753
        L777:
            goto L687
        L77b:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto L4b8
        L783:
            r12.writeInt32(r5, r4)
            goto L24e
        L78a:
            java.lang.object r11 = r0.Current
            goto L28d
        L792:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Le14
        L79a:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Le1a
        L7a2:
            goto L753
        L7a4:
            goto L7f4
        L7a8:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto L4c9
        L7b0:
            long r6 = offset(r4)
            goto L365
        L7b8:
            if (r0 <= 0) goto L7bd
            goto Le36
        L7bd:
            goto Le33
        L7c1:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r11 = r10.extensionSchema
            goto Lb1b
        L7c7:
            goto L753
        L7c9:
            goto L802
        L7cd:
            r6.serializeExtension(r12, r2)
            goto Lb0c
        L7d4:
            long r6 = offset(r4)
            goto L25a
        L7dc:
            long r6 = longAt(r11, r6)
            goto L8fd
        L7e4:
            long r8 = offset(r4)
            goto La8d
        L7ec:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L550
        L7f4:
            int r5 = r10.numberAt(r3)
            goto Ldfb
        L7fc:
            java.util.List r4 = (java.util.List) r4
            goto Lb46
        L802:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Lee
        L80a:
            int r5 = r10.numberAt(r3)
            goto Lb53
        L812:
            java.util.List r4 = (java.util.List) r4
            goto L247
        L818:
            r12.writeFixed32(r5, r4)
            goto L9f9
        L81f:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Lcdc
        L827:
            if (r6 != 0) goto L82c
            goto L753
        L82c:
            goto L2bb
        L830:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L514
        L838:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Le3a
        L840:
            long r6 = offset(r4)
            goto L4a2
        L848:
            long r6 = longAt(r11, r6)
            goto L6be
        L850:
            int r4 = oneofIntAt(r11, r6)
            goto L783
        L858:
            long r6 = offset(r4)
            goto Ld69
        L860:
            int r5 = r10.numberAt(r3)
            goto L270
        L868:
            long r6 = oneoflongAt(r11, r6)
            goto L1ff
        L870:
            r12.writefloat(r5, r4)
            goto L5d3
        L877:
            int r4 = intAt(r11, r6)
            goto L454
        L87f:
            java.util.List r4 = (java.util.List) r4
            goto L94a
        L885:
            goto L753
        L887:
            goto Lca0
        L88b:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Lc13
        L893:
            goto Ldb6
        L895:
            goto Lae0
        L899:
            if (r2 != 0) goto L89e
            goto L66d
        L89e:
            goto L7c1
        L8a2:
            int r5 = r10.numberAt(r3)
            goto L69
        L8aa:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L914
        L8b2:
            r10.writeDictionaryHelper(r12, r5, r4, r3)
            goto Lc5f
        L8b9:
            int r5 = r10.numberAt(r3)
            goto L51d
        L8c1:
            long r8 = offset(r4)
            goto Lc8b
        L8c9:
            if (r6 != 0) goto L8ce
            goto L753
        L8ce:
            goto L619
        L8d2:
            long r6 = offset(r4)
            goto L8aa
        L8da:
            goto L753
        L8dc:
            goto Ldad
        L8e0:
            long r6 = offset(r4)
            goto L23f
        L8e8:
            java.util.List r4 = (java.util.List) r4
            goto L12
        L8ee:
            androidx.datastore.preferences.protobuf.SchemaUtil.writebytesList(r5, r4, r12)
            goto L91a
        L8f5:
            int r4 = oneofIntAt(r11, r6)
            goto Lbec
        L8fd:
            r12.writeInt64(r5, r6)
            goto Lbde
        L904:
            int r5 = r10.numberAt(r3)
            goto La05
        L90c:
            int r5 = r10.numberAt(r3)
            goto La9c
        L914:
            java.util.List r4 = (java.util.List) r4
            goto Lde5
        L91a:
            goto L753
        L91c:
            goto L27e
        L920:
            goto L753
        L922:
            goto L525
        L926:
            bool r0 = r10.hasExtensions
            goto L299
        L92c:
            long r6 = oneoflongAt(r11, r6)
            goto L627
        L934:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeEnumList(r5, r4, r12, r7)
            goto Lbaa
        L93b:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed32List(r5, r4, r12, r7)
            goto La39
        L942:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Lb03
        L94a:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(r5, r4, r12, r8)
            goto Le03
        L951:
            return
        L9e0:
            goto L2c3
        L9e4:
            if (r0 != 0) goto L9e9
            goto L895
        L9e9:
            goto Lcc8
        L9ed:
            goto L753
        L9ef:
            goto Lc1f
        L9f3:
            goto L753
        L9f5:
            goto L13b
        L9f9:
            goto L753
        L9fb:
            goto L159
        L9ff:
            goto L753
        La01:
            goto L838
        La05:
            long r8 = offset(r4)
            goto L7a8
        La0d:
            r2 = r1
            goto L66c
        La12:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed64List(r5, r4, r12, r7)
            goto La63
        La19:
            long r6 = offset(r4)
            goto L603
        La21:
            java.util.List r4 = (java.util.List) r4
            goto Lfe
        La27:
            if (r6 != 0) goto La2c
            goto L753
        La2c:
            goto Lad0
        La30:
            if (r6 != 0) goto La35
            goto L753
        La35:
            goto La85
        La39:
            goto L753
        La3b:
            goto L476
        La3f:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt64List(r5, r4, r12, r8)
            goto L775
        La46:
            r12.writeEnum(r5, r4)
            goto L768
        La4d:
            goto L661
        La4f:
            goto L468
        La53:
            r12.writefloat(r5, r4)
            goto Lc19
        La5a:
            if (r6 != 0) goto La5f
            goto L753
        La5f:
            goto L410
        La63:
            goto L753
        La65:
            goto L904
        La69:
            goto L661
        La6b:
            goto L34a
        La6f:
            long r6 = offset(r4)
            goto Lbf3
        La77:
            int r5 = r10.numberAt(r3)
            goto L41f
        La7f:
            int r0 = r0 % r1
            goto L7b8
        La85:
            long r6 = offset(r4)
            goto L92c
        La8d:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto L1a9
        La95:
            r12.writedouble(r5, r6)
            goto Ldd0
        La9c:
            long r6 = offset(r4)
            goto Lb28
        Laa4:
            r12.writeUInt64(r5, r6)
            goto L6e7
        Laab:
            androidx.datastore.preferences.protobuf.SchemaUtil.writefloatList(r5, r4, r12, r8)
            goto L594
        Lab2:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L29e
        Laba:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L462
        Lac2:
            goto L753
        Lac4:
            goto L69d
        Lac8:
            int r4 = intAt(r11, r6)
            goto L5a
        Lad0:
            long r6 = offset(r4)
            goto L848
        Lad8:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto L486
        Lae0:
            r0 = r1
            goto Ldb5
        Lae5:
            java.util.List r4 = (java.util.List) r4
            goto Lc7c
        Laeb:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto Lc93
        Laf3:
            long r6 = offset(r4)
            goto L2df
        Lafb:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L16e
        Lb03:
            if (r6 != 0) goto Lb08
            goto L753
        Lb08:
            goto La6f
        Lb0c:
            bool r2 = r0.MoveNext()
            goto Ld16
        Lb14:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSFixed32List(r5, r4, r12, r7)
            goto L3c9
        Lb1b:
            r11.serializeExtension(r12, r2)
            goto Lc65
        Lb22:
            goto L753
        Lb24:
            goto Lcc
        Lb28:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L567
        Lb30:
            float r4 = floatAt(r11, r6)
            goto L870
        Lb38:
            goto L753
        Lb3a:
            goto L323
        Lb3e:
            double r6 = oneofdoubleAt(r11, r6)
            goto La95
        Lb46:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeFixed32List(r5, r4, r12, r8)
            goto L2a4
        Lb4d:
            goto L753
        Lb4f:
            goto L38e
        Lb53:
            long r8 = offset(r4)
            goto L4
        Lb5b:
            long r8 = offset(r4)
            goto L444
        Lb63:
            int r5 = r10.numberAt(r3)
            goto L5c3
        Lb6b:
            goto L753
        Lb6d:
            goto L3f6
        Lb71:
            bool r2 = r0.Count == 0
            goto L385
        Lb79:
            int r5 = r10.numberAt(r3)
            goto L105
        Lb81:
            androidx.datastore.preferences.protobuf.SchemaUtil.writefloatList(r5, r4, r12, r7)
            goto L4b2
        Lb88:
            int r5 = r10.numberAt(r3)
            goto L8d2
        Lb90:
            long r6 = offset(r4)
            goto L7dc
        Lb98:
            if (r6 != 0) goto Lb9d
            goto L753
        Lb9d:
            goto L22a
        Lba1:
            if (r6 != 0) goto Lba6
            goto L753
        Lba6:
            goto Lce5
        Lbaa:
            goto L753
        Lbac:
            goto L8d
        Lbb0:
            goto L753
        Lbb2:
            goto Ld06
        Lbb6:
            if (r6 != 0) goto Lbbb
            goto L753
        Lbbb:
            goto L858
        Lbbf:
            long r6 = offset(r4)
            goto Laba
        Lbc7:
            long r6 = offset(r4)
            goto L868
        Lbcf:
            androidx.datastore.preferences.protobuf.bytestring r4 = (androidx.datastore.preferences.protobuf.bytestring) r4
            goto L3b
        Lbd5:
            if (r6 != 0) goto Lbda
            goto L753
        Lbda:
            goto Ldc8
        Lbde:
            goto L753
        Lbe0:
            goto L830
        Lbe4:
            long r6 = offset(r4)
            goto L4f5
        Lbec:
            r12.writeSInt32(r5, r4)
            goto L1cb
        Lbf3:
            long r6 = oneoflongAt(r11, r6)
            goto Laa4
        Lbfb:
            long r8 = offset(r4)
            goto Lad8
        Lc03:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Lb98
        Lc0b:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Ld86
        Lc13:
            java.util.List r4 = (java.util.List) r4
            goto Lcb9
        Lc19:
            goto L753
        Lc1b:
            goto L4df
        Lc1f:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L3c0
        Lc27:
            goto L753
        Lc29:
            goto L705
        Lc2d:
            long r6 = offset(r4)
            goto Le23
        Lc35:
            bool r4 = boolAt(r11, r6)
            goto L738
        Lc3d:
            int[] r3 = r10.buffer
            goto L40b
        Lc43:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt32List(r5, r4, r12, r8)
            goto L4ef
        Lc4a:
            int r0 = r0 + r1
            goto La7f
        Lc50:
            r10.writeUnknownInMessageTo(r0, r11, r12)
            goto L926
        Lc57:
            int r5 = r10.numberAt(r3)
            goto L375
        Lc5f:
            goto L753
        Lc61:
            goto Lb88
        Lc65:
            bool r11 = r0.MoveNext()
            goto L304
        Lc6d:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt32List(r5, r4, r12, r8)
            goto L1af
        Lc74:
            int r4 = oneofIntAt(r11, r6)
            goto L71
        Lc7c:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeUInt32List(r5, r4, r12, r7)
            goto L3a4
        Lc83:
            long r6 = offset(r4)
            goto L493
        Lc8b:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r8)
            goto Lc
        Lc93:
            java.util.List r4 = (java.util.List) r4
            goto Ld1f
        Lc99:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt32List(r5, r4, r12, r7)
            goto L3fe
        Lca0:
            int r5 = r10.numberAt(r3)
            goto L7e4
        Lca8:
            if (r6 != 0) goto Lcad
            goto L753
        Lcad:
            goto L3aa
        Lcb1:
            long r6 = offset(r4)
            goto L34f
        Lcb9:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeInt32List(r5, r4, r12, r7)
            goto Le0e
        Lcc0:
            bool r6 = r10.isOneofPresent(r11, r5, r3)
            goto Ld4
        Lcc8:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r0 = r10.extensionSchema
            goto L133
        Lcce:
            int r5 = r10.numberAt(r3)
            goto L61
        Lcd6:
            java.util.List r4 = (java.util.List) r4
            goto L19a
        Lcdc:
            if (r6 != 0) goto Lce1
            goto L753
        Lce1:
            goto L714
        Lce5:
            long r6 = offset(r4)
            goto L6a5
        Lced:
            goto L753
        Lcef:
            goto L52
        Lcf3:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeEnumList(r5, r4, r12, r8)
            goto L59a
        Lcfa:
            java.util.List r4 = (java.util.List) r4
            goto L286
        Ld00:
            goto L753
        Ld02:
            goto L95
        Ld06:
            int r5 = r10.numberAt(r3)
            goto Lbbf
        Ld0e:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L396
        Ld16:
            if (r2 != 0) goto Ld1b
            goto La6b
        Ld1b:
            goto L43c
        Ld1f:
            androidx.datastore.preferences.protobuf.SchemaUtil.writeSInt64List(r5, r4, r12, r8)
            goto L57d
        Ld26:
            goto L753
        Ld28:
            goto L6ad
        Ld2c:
            int r5 = r10.numberAt(r3)
            goto L63e
        Ld34:
            r10.writestring(r5, r4, r12)
            goto L621
        Ld3b:
            int r4 = intAt(r11, r6)
            goto L50d
        Ld43:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L72f
        Ld4b:
            java.util.List r4 = (java.util.List) r4
            goto La12
        Ld51:
            int r6 = r6.extensionNumber(r2)
            goto L75f
        Ld59:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L42
        Ld61:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L3e8
        Ld69:
            int r4 = intAt(r11, r6)
            goto L558
        Ld71:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto L8c9
        Ld79:
            r12.writeFixed64(r5, r6)
            goto L21c
        Ld80:
            goto L753
        Ld82:
            goto L4d7
        Ld86:
            java.util.List r4 = (java.util.List) r4
            goto L215
        Ld8c:
            if (r6 != 0) goto Ld91
            goto L753
        Ld91:
            goto Lb90
        Ld95:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L32b
        Ld9d:
            long r6 = offset(r4)
            goto Laeb
        Lda5:
            int r5 = r10.numberAt(r3)
            goto Lbfb
        Ldad:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Lca8
        Ldb5:
            r2 = r0
        Ldb6:
            goto Lc3d
        Ldba:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Ld8c
        Ldc2:
            goto L753
        Ldc4:
            goto L81f
        Ldc8:
            long r6 = offset(r4)
            goto L1a1
        Ldd0:
            goto L753
        Ldd2:
            goto L2ca
        Ldd6:
            r12.writeFixed32(r5, r4)
            goto L470
        Lddd:
            java.lang.object r4 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r11, r6)
            goto L168
        Lde5:
            androidx.datastore.preferences.protobuf.Schema r6 = r10.getMessageFieldSchema(r3)
            goto L680
        Lded:
            bool r4 = oneofboolAt(r11, r6)
            goto L656
        Ldf5:
            java.util.List r4 = (java.util.List) r4
            goto L93b
        Ldfb:
            long r8 = offset(r4)
            goto L331
        Le03:
            goto L753
        Le05:
            goto Lcce
        Le09:
            r7 = 1
            goto L1bd
        Le0e:
            goto L753
        Le10:
            goto La77
        Le14:
            java.util.List r4 = (java.util.List) r4
            goto Lb81
        Le1a:
            if (r6 != 0) goto Le1f
            goto L753
        Le1f:
            goto Ldd
        Le23:
            long r6 = longAt(r11, r6)
            goto L404
        Le2b:
            long r6 = offset(r4)
            goto L20d
        Le33:
            goto L9e0
        Le36:
            goto L671
        Le3a:
            if (r6 != 0) goto Le3f
            goto L753
        Le3f:
            goto L8e0
        Le43:
            int r4 = oneofIntAt(r11, r6)
            goto La46
        Le4b:
            bool r6 = r10.isFieldPresent(r11, r3)
            goto Lbb6
        Le53:
            long r6 = offset(r4)
            goto L877
    }

    private <K, V> void WriteDictionaryHelper(androidx.datastore.preferences.protobuf.Writer r2, int r3, java.lang.object r4, int r5) throws java.io.IOException {
            r1 = this;
            goto L40
        L4:
            java.lang.object r5 = r1.getDictionaryFieldDefaultEntry(r5)
            goto L23
        Lc:
            java.util.Dictionary r1 = r1.forDictionaryData(r4)
            goto L39
        L14:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r1 = r1.mapFieldSchema
            goto Lc
        L1a:
            if (r4 != 0) goto L1f
            goto L3c
        L1f:
            goto L2b
        L23:
            androidx.datastore.preferences.protobuf.DictionaryEntryLite$Metadata r5 = r0.forDictionaryMetadata(r5)
            goto L14
        L2b:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r0 = r1.mapFieldSchema
            goto L4
        L31:
            return
        L32:
            goto L36
        L36:
            goto L43
        L39:
            r2.writeDictionary(r3, r5, r1)
        L3c:
            goto L31
        L40:
            goto L32
        L43:
            goto L1a
    }

    private void Writestring(int r1, java.lang.object r2, androidx.datastore.preferences.protobuf.Writer r3) throws java.io.IOException {
            r0 = this;
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            androidx.datastore.preferences.protobuf.bytestring r2 = (androidx.datastore.preferences.protobuf.bytestring) r2
            goto Lf
        Lf:
            r3.writebytes(r1, r2)
            goto L36
        L16:
            r3.writestring(r1, r2)
            goto L4
        L1d:
            if (r0 != 0) goto L22
            goto L5
        L22:
            goto L3b
        L26:
            goto L2c
        L29:
            goto L37
        L2c:
            goto L30
        L30:
            bool r0 = r2 is java.lang.string
            goto L1d
        L36:
            return
        L37:
            goto L26
        L3b:
            java.lang.string r2 = (java.lang.string) r2
            goto L16
    }

    private <UT, UB> void WriteUnknownInMessageTo(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> r1, T r2, androidx.datastore.preferences.protobuf.Writer r3) throws java.io.IOException {
            r0 = this;
            goto L4
        L4:
            goto L16
        L7:
            goto L1a
        Lb:
            goto L7
        Le:
            r1.writeTo(r0, r3)
            goto L15
        L15:
            return
        L16:
            goto Lb
        L1a:
            java.lang.object r0 = r1.getFromMessage(r2)
            goto Le
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public bool Equals(T r5, T r6) {
            r4 = this;
            goto L9e
        L4:
            int r0 = r0 % r1
            goto Lcd
        La:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r4 = r4.extensionSchema
            goto L48
        L10:
            int r0 = r0 + r1
            goto L4
        L16:
            java.lang.object r2 = r2.getFromMessage(r6)
            goto L3b
        L1e:
            return r1
        L1f:
            goto L50
        L23:
            int r0 = r0.length
            goto L78
        L28:
            return r4
        L29:
            goto L89
        L2d:
            goto Ld7
        L2f:
            goto La5
        L33:
            androidx.datastore.preferences.protobuf.FieldHashSet r5 = r0.getExtensions(r5)
            goto La
        L3b:
            bool r0 = r0.Equals(r2)
            goto Lab
        L43:
            r4 = 1
            goto L28
        L48:
            androidx.datastore.preferences.protobuf.FieldHashSet r4 = r4.getExtensions(r6)
            goto L96
        L50:
            bool r0 = r4.hasExtensions
            goto L67
        L56:
            return r1
        L57:
            goto Lb4
        L5b:
            return r4
        L5c:
            goto L43
        L60:
            r1 = 21
            goto L10
        L67:
            if (r0 != 0) goto L6c
            goto L5c
        L6c:
            goto L90
        L70:
            bool r3 = r4.Equals(r5, r6, r2)
            goto Le2
        L78:
            r1 = 0
            goto Ld6
        L7d:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r2 = r4.unknownFieldSchema
            goto L16
        L83:
            int[] r0 = r4.buffer
            goto L23
        L89:
            goto Lbd
        L8c:
            goto Lca
        L90:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r0 = r4.extensionSchema
            goto L33
        L96:
            bool r4 = r5.Equals(r4)
            goto L5b
        L9e:
            goto L8c
        La1:
            goto Ldb
        La5:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r4.unknownFieldSchema
            goto Leb
        Lab:
            if (r0 == 0) goto Lb0
            goto L1f
        Lb0:
            goto L1e
        Lb4:
            int r2 = r2 + 3
            goto L2d
        Lba:
            goto L29
        Lbd:
            goto L83
        Lc1:
            if (r2 < r0) goto Lc6
            goto L2f
        Lc6:
            goto L70
        Lca:
            goto La1
        Lcd:
            if (r0 <= 0) goto Ld2
            goto Lbd
        Ld2:
            goto Lba
        Ld6:
            r2 = r1
        Ld7:
            goto Lc1
        Ldb:
            r0 = 32
            goto L60
        Le2:
            if (r3 == 0) goto Le7
            goto L57
        Le7:
            goto L56
        Leb:
            java.lang.object r0 = r0.getFromMessage(r5)
            goto L7d
    }

    int getSchemaSize() {
            r0 = this;
            goto L17
        L4:
            goto L1a
        L7:
            int r0 = r0 * 3
            goto L12
        Ld:
            int r0 = r0.length
            goto L7
        L12:
            return r0
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto L1e
        L1e:
            int[] r0 = r0.buffer
            goto Ld
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public int GetSerializedSize(T r18) {
            r17 = this;
            goto La47
        L4:
            int r5 = r5.id()
            goto Lc09
        Lc:
            if (r5 != 0) goto L11
            goto L8df
        L11:
            goto L306
        L15:
            if (r5 != 0) goto L1a
            goto L856
        L1a:
            goto L251
        L1e:
            goto Le3c
        L20:
            goto L5d3
        L24:
            goto Le3c
        L26:
            goto Le9a
        L2a:
            int r8 = r8 + r5
            goto Le04
        L2f:
            r12 = r7
        L30:
            goto L98e
        L34:
            goto L1b9
        L36:
            goto L867
        L3a:
            goto L5e5
        L3c:
            goto L1a7
        L40:
            goto Le3c
        L42:
            goto Lef6
        L46:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Ldd0
        L4e:
            if (r8 != 0) goto L53
            goto L57b
        L53:
            goto Lc7b
        L57:
            goto Le3c
        L59:
            goto L823
        L5d:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computestringSize(r11, r5)
            goto L5be
        L65:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L15
        L6d:
            goto La4a
        L70:
            r6.putInt(r1, r8, r5)
        L73:
            goto Lc67
        L77:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lc95
        L7f:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto Lac5
        L87:
            goto Le3c
        L89:
            goto L862
        L8d:
            r6.putInt(r1, r8, r5)
        L90:
            goto L4ab
        L94:
            goto L1b9
        L96:
            goto L77b
        L9a:
            int r0 = r6.getInt(r1, r8)
            goto La02
        La2:
            r13 = r7
        La3:
            goto L374
        La7:
            r0 = r17
            goto L8dd
        Lad:
            r5 = r12
            goto L90a
        Lb2:
            goto L197
        Lb4:
            goto Lca1
        Lb8:
            goto Le3c
        Lba:
            goto L9c4
        Lbe:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L494
        Lc6:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L16e
        Lce:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeSFixed32Size(r11, r7)
            goto L63a
        Ld6:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L4ca
        Lde:
            r5 = 1
            goto L2e0
        Le3:
            androidx.datastore.preferences.protobuf.MessageLite r5 = (androidx.datastore.preferences.protobuf.MessageLite) r5
            goto Lbd3
        Le9:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32ListNoTag(r5)
            goto L3f2
        Lf1:
            r6.putInt(r1, r8, r5)
        Lf4:
            goto L183
        Lf8:
            java.util.List r5 = (java.util.List) r5
            goto Laa5
        Lfe:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r0 = r0.extensionSchema
            goto L7ba
        L104:
            bool r8 = r0.useCachedSizeField
            goto L772
        L10a:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeSInt32Size(r11, r5)
            goto L24
        L112:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L631
        L11a:
            if (r5 != 0) goto L11f
            goto L856
        L11f:
            goto L363
        L123:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeSFixed64Size(r11, r14)
            goto L1e
        L12b:
            r5 = r12
            goto L613
        L130:
            int r11 = r0.numberAt(r2)
            goto Lf41
        L138:
            goto Le3c
        L13a:
            goto Le7a
        L13e:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lc48
        L146:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto L1d4
        L14e:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeSFixed32Size(r11, r7)
            goto Lbb3
        L156:
            goto Le3c
        L158:
            goto L52b
        L15c:
            sun.misc.Unsafe r6 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L93a
        L162:
            bool r8 = r0.useCachedSizeField
            goto L4e
        L168:
            java.util.List r5 = (java.util.List) r5
            goto L9d8
        L16e:
            if (r5 != 0) goto L173
            goto L856
        L173:
            goto L3fb
        L177:
            r3 = r7
            goto L837
        L17c:
            r6.putInt(r1, r8, r5)
        L17f:
            goto Ld6
        L183:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L4f1
        L18b:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L395
        L193:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeInt64Size(r11, r8)
        L197:
            goto L6a1
        L19b:
            goto Le3c
        L19d:
            goto L5b0
        L1a1:
            int[] r5 = r0.buffer
            goto L2d3
        L1a7:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lc42
        L1af:
            goto Le3c
        L1b1:
            goto L429
        L1b5:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
        L1b9:
            goto L439
        L1bd:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeUInt32List(r11, r5, r7)
            goto L7c8
        L1c5:
            if (r13 != r3) goto L1ca
            goto La11
        L1ca:
            goto L4c1
        L1ce:
            goto Le3c
        L1d0:
            goto L6b3
        L1d4:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeGroupList(r11, r5, r8)
            goto Lbb9
        L1dc:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computebytesSize(r11, r5)
            goto L97f
        L1e4:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lc
        L1ec:
            int r9 = r16 + r0
            goto L2b4
        L1f2:
            if (r8 != 0) goto L1f7
            goto L90
        L1f7:
            goto L7ce
        L1fb:
            int r2 = r2 + 3
            goto L922
        L201:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeBoolSize(r11, r5)
            goto La56
        L209:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeGroupSize(r11, r5, r8)
            goto Lf2f
        L211:
            goto Le3c
        L213:
            goto Lb85
        L217:
            goto L856
        L219:
            goto Ldd9
        L21d:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32ListNoTag(r5)
            goto Lcac
        L225:
            goto Le3c
        L227:
            goto L4b3
        L22b:
            r5 = r12
            goto L2fe
        L230:
            if (r5 != 0) goto L235
            goto L856
        L235:
            goto L423
        L239:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lf8
        L241:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computefloatSize(r11, r8)
        L245:
            goto L1ec
        L249:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto La23
        L251:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lbab
        L259:
            int r0 = r6.getInt(r1, r8)
            goto Lec2
        L261:
            goto Le3c
        L263:
            goto L249
        L267:
            java.util.List r5 = (java.util.List) r5
            goto L471
        L26d:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L8b8
        L275:
            goto Le3c
        L277:
            goto L81b
        L27b:
            r9 = r4
            goto L40b
        L280:
            int r5 = oneofIntAt(r1, r8)
            goto Lcf0
        L288:
            r6.putInt(r1, r8, r5)
        L28b:
            goto Ld4a
        L28f:
            r5 = r12
            goto L606
        L294:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto La37
        L29c:
            goto L197
        L29e:
            goto L12b
        L2a2:
            r4 = r3
            goto La10
        L2a7:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeInt32ListNoTag(r5)
            goto L985
        L2af:
            r5 = r12
            goto L70d
        L2b4:
            r0 = r17
            goto Ldf6
        L2ba:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computedoubleSize(r11, r8)
            goto L854
        L2c2:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeUInt32ListNoTag(r5)
            goto L8af
        L2ca:
            if (r8 != 0) goto L2cf
            goto L28b
        L2cf:
            goto Ld72
        L2d3:
            int r5 = r5.length
            goto Lcd0
        L2d8:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto La1d
        L2e0:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeBoolSize(r11, r5)
            goto Le6b
        L2e8:
            if (r5 != 0) goto L2ed
            goto L856
        L2ed:
            goto L13e
        L2f1:
            r5 = r12
            goto Le1c
        L2f6:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Ld0a
        L2fe:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lc29
        L306:
            int r0 = r6.getInt(r1, r8)
            goto Lb6c
        L30e:
            r6.putInt(r1, r8, r5)
        L311:
            goto Lc01
        L315:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L267
        L31d:
            java.util.List r5 = (java.util.List) r5
            goto Led7
        L323:
            int r5 = r5.id()
            goto L36b
        L32b:
            if (r5 != 0) goto L330
            goto L856
        L330:
            goto Lcca
        L334:
            long r8 = (long) r13
            goto Lcb5
        L339:
            java.lang.object r0 = r6.getobject(r1, r8)
            goto L6ad
        L341:
            if (r5 != 0) goto L346
            goto L8df
        L346:
            goto La95
        L34a:
            if (r5 != 0) goto L34f
            goto L856
        L34f:
            goto L123
        L353:
            long r8 = offset(r5)
            goto L55c
        L35b:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L976
        L363:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeFixed64Size(r11, r14)
            goto L455
        L36b:
            if (r10 >= r5) goto L370
            goto L9f0
        L370:
            goto L7e5
        L374:
            r5 = 0
            goto L72f
        L379:
            r5 = r12
            goto La3f
        L37e:
            java.util.List r5 = (java.util.List) r5
            goto Le38
        L384:
            if (r8 != 0) goto L389
            goto L1d0
        L389:
            goto L9d2
        L38d:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lf15
        L395:
            if (r5 != 0) goto L39a
            goto Lc77
        L39a:
            goto L9e0
        L39e:
            if (r5 != 0) goto L3a3
            goto L856
        L3a3:
            goto L902
        L3a7:
            r2 = r7
            goto Lbec
        L3ac:
            goto L1b9
        L3ae:
            goto L68c
        L3b2:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L341
        L3ba:
            goto Lb62
        L3bd:
            goto L446
        L3c1:
            bool r2 = r0.hasExtensions
            goto Ld01
        L3c7:
            androidx.datastore.preferences.protobuf.bytestring r5 = (androidx.datastore.preferences.protobuf.bytestring) r5
            goto L1dc
        L3cd:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto L793
        L3d5:
            androidx.datastore.preferences.protobuf.bytestring r0 = (androidx.datastore.preferences.protobuf.bytestring) r0
            goto Lbf1
        L3db:
            if (r5 > 0) goto L3e0
            goto L856
        L3e0:
            goto L525
        L3e4:
            int r12 = r15 << r12
            goto L511
        L3ea:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L66d
        L3f2:
            if (r5 > 0) goto L3f7
            goto L856
        L3f7:
            goto Lf35
        L3fb:
            int r5 = oneofIntAt(r1, r8)
            goto Ldc0
        L403:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeSInt32ListNoTag(r5)
            goto L888
        L40b:
            r3 = r8
        L40c:
            goto L1a1
        L410:
            r0 = 14
            goto L7eb
        L417:
            goto L40c
        L419:
            goto Ld60
        L41d:
            int r9 = r16 + r5
            goto Lc80
        L423:
            r8 = 0
            goto L593
        L429:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L31d
        L431:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeEnumListNoTag(r5)
            goto L7f2
        L439:
            int r8 = r8 + r9
            goto L2a
        L43e:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeFixed32Size(r11, r7)
            goto L5cd
        L446:
            r0 = r17
            goto L9cc
        L44c:
            if (r5 != 0) goto L451
            goto L8f8
        L451:
            goto L3d5
        L455:
            goto Le3c
        L457:
            goto L35b
        L45b:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L9e8
        L463:
            r5 = r12
            goto L85a
        L468:
            if (r5 != 0) goto L46d
            goto L8df
        L46d:
            goto L49a
        L471:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32List(r11, r5, r7)
            goto L479
        L479:
            goto Le3c
        L47b:
            goto L783
        L47f:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L8d2
        L487:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L57f
        L48f:
            long r8 = (long) r13
            goto L694
        L494:
            goto L1b9
        L496:
            goto Ld16
        L49a:
            long r8 = r6.getlong(r1, r8)
            goto L193
        L4a2:
            if (r5 != 0) goto L4a7
            goto L856
        L4a7:
            goto Lce
        L4ab:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L93f
        L4b3:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Le10
        L4bb:
            bool r8 = r0.useCachedSizeField
            goto Le48
        L4c1:
            if (r13 == r8) goto L4c6
            goto L839
        L4c6:
            goto L177
        L4ca:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto Lf29
        L4d2:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Le32
        L4da:
            java.util.List r5 = (java.util.List) r5
            goto Lb74
        L4e0:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeInt64ListNoTag(r5)
            goto L4e8
        L4e8:
            if (r5 > 0) goto L4ed
            goto L856
        L4ed:
            goto L6f0
        L4f1:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L3ac
        L4f9:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L8a1
        L501:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64List(r11, r5, r7)
            goto Ledf
        L509:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32List(r11, r5, r7)
            goto L7c2
        L511:
            goto L30
        L513:
            goto L2f
        L517:
            java.lang.string r0 = (java.lang.string) r0
            goto L727
        L51d:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64ListNoTag(r5)
            goto L7a1
        L525:
            bool r8 = r0.useCachedSizeField
            goto L1f2
        L52b:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r5 = r0.mapFieldSchema
            goto Lde1
        L531:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto Lcf8
        L539:
            java.lang.object r9 = r0.getDictionaryFieldDefaultEntry(r2)
            goto L562
        L541:
            if (r5 != 0) goto L546
            goto L8df
        L546:
            goto L9a
        L54a:
            bool r8 = r0.useCachedSizeField
            goto L931
        L550:
            java.util.List r5 = (java.util.List) r5
            goto L2c2
        L556:
            bool r8 = r0.useCachedSizeField
            goto Leb3
        L55c:
            androidx.datastore.preferences.protobuf.FieldType r5 = androidx.datastore.preferences.protobuf.FieldType.DOUBLE_LIST_PACKED
            goto L323
        L562:
            int r5 = r5.getSerializedSize(r11, r8, r9)
            goto Ld1e
        L56a:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32Size(r11, r5)
            goto L9b8
        L572:
            goto Le3c
        L574:
            goto Lc32
        L578:
            r6.putInt(r1, r8, r5)
        L57b:
            goto L83d
        L57f:
            if (r5 != 0) goto L584
            goto L856
        L584:
            goto Lf0d
        L588:
            r5 = r12
            goto L654
        L58d:
            r0 = r17
            goto L968
        L593:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computedoubleSize(r11, r8)
            goto L156
        L59b:
            long r8 = (long) r13
            goto Lf1
        L5a0:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeMessage(r11, r5, r8)
            goto L275
        L5a8:
            int r2 = r0.getUnknownFieldsSerializedSize(r2, r1)
            goto L6a7
        L5b0:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto Leed
        L5b8:
            java.util.List r5 = (java.util.List) r5
            goto L4e0
        L5be:
            goto Le3c
        L5c0:
            goto L740
        L5c4:
            if (r5 != 0) goto L5c9
            goto L8df
        L5c9:
            goto Lbf9
        L5cd:
            goto Le3c
        L5cf:
            goto L9fa
        L5d3:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L4a2
        L5db:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L3c7
        L5e3:
            r9 = r16
        L5e5:
            goto L1fb
        L5e9:
            bool r8 = r0.useCachedSizeField
            goto L2ca
        L5ef:
            if (r5 != 0) goto L5f4
            goto L8df
        L5f4:
            goto L339
        L5f8:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeSFixed64Size(r11, r14)
            goto L667
        L600:
            bool r8 = r0.useCachedSizeField
            goto Le29
        L606:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lb7c
        L60e:
            long r8 = (long) r13
            goto Lf06
        L613:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lc8c
        L61b:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeSInt64Size(r11, r8)
            goto L138
        L623:
            goto Le3c
        L625:
            goto L2d8
        L629:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeInt64List(r11, r5, r7)
            goto Lda4
        L631:
            if (r5 != 0) goto L636
            goto L856
        L636:
            goto L43e
        L63a:
            goto Le3c
        L63c:
            goto Lc6
        L640:
            bool r8 = r0.useCachedSizeField
            goto Ld88
        L646:
            if (r5 != 0) goto L64b
            goto L856
        L64b:
            goto Ldc8
        L64f:
            r5 = r12
            goto Le92
        L654:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L646
        L65c:
            goto L197
        L65e:
            goto L379
        L662:
            r5 = r12
            goto L46
        L667:
            goto L245
        L669:
            goto L28f
        L66d:
            java.util.List r5 = (java.util.List) r5
            goto L2a7
        L673:
            int r0 = r0.getSerializedSize()
            goto L80e
        L67b:
            if (r5 != 0) goto L680
            goto Lc77
        L680:
            goto L241
        L684:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lcdf
        L68c:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lcd9
        L694:
            r6.putInt(r1, r8, r5)
        L697:
            goto L294
        L69b:
            goto L856
        L69d:
            goto L8d8
        L6a1:
            int r9 = r16 + r0
            goto La7
        L6a7:
            int r9 = r16 + r2
            goto L3c1
        L6ad:
            androidx.datastore.preferences.protobuf.bytestring r0 = (androidx.datastore.preferences.protobuf.bytestring) r0
            goto La8d
        L6b3:
            java.lang.string r5 = (java.lang.string) r5
            goto L5d
        L6b9:
            bool r8 = r0.useCachedSizeField
            goto Le5a
        L6bf:
            r5 = r12
            goto L1e4
        L6c4:
            r5 = r12
            goto La15
        L6c9:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto La5c
        L6d1:
            if (r5 != 0) goto L6d6
            goto L8df
        L6d6:
            goto L813
        L6da:
            goto L1b9
        L6dc:
            goto L6f6
        L6e0:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto La85
        L6e8:
            int r5 = r0.typeAndOffsetAt(r2)
            goto Lea2
        L6f0:
            bool r8 = r0.useCachedSizeField
            goto Le82
        L6f6:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L5b8
        L6fe:
            java.util.List r5 = (java.util.List) r5
            goto Le9
        L704:
            if (r8 != 0) goto L709
            goto L17f
        L709:
            goto L8eb
        L70d:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L6d1
        L715:
            goto Le3c
        L717:
            goto L947
        L71b:
            java.util.List r5 = (java.util.List) r5
            goto Lefe
        L721:
            goto Le3c
        L723:
            goto L2f6
        L727:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computestringSize(r11, r0)
            goto L65c
        L72f:
            r14 = 0
            switch(r10) {
                case 0: goto L9f6;
                case 1: goto L69d;
                case 2: goto Lca8;
                case 3: goto La0c;
                case 4: goto L82d;
                case 5: goto L9ae;
                case 6: goto La58;
                case 7: goto L65e;
                case 8: goto L89;
                case 9: goto L29e;
                case 10: goto Lb4;
                case 11: goto Lc25;
                case 12: goto Lbb5;
                case 13: goto L669;
                case 14: goto Ld54;
                case 15: goto La74;
                case 16: goto Lf31;
                case 17: goto Lc82;
                case 18: goto L42;
                case 19: goto Lda6;
                case 20: goto L263;
                case 21: goto L227;
                case 22: goto L1b1;
                case 23: goto L7c4;
                case 24: goto Le25;
                case 25: goto L574;
                case 26: goto L723;
                case 27: goto L717;
                case 28: goto L7ca;
                case 29: goto L625;
                case 30: goto L47b;
                case 31: goto Lee1;
                case 32: goto L59;
                case 33: goto L79d;
                case 34: goto L3c;
                case 35: goto Lacf;
                case 36: goto Lc58;
                case 37: goto L6dc;
                case 38: goto L36;
                case 39: goto L850;
                case 40: goto L3ae;
                case 41: goto L9ea;
                case 42: goto La5e;
                case 43: goto L8d4;
                case 44: goto Lf2b;
                case 45: goto Ldb7;
                case 46: goto L496;
                case 47: goto L96;
                case 48: goto Lbbb;
                case 49: goto Ld20;
                case 50: goto L158;
                case 51: goto Lba;
                case 52: goto Ld9b;
                case 53: goto L19d;
                case 54: goto L9b4;
                case 55: goto L457;
                case 56: goto L5cf;
                case 57: goto Le6d;
                case 58: goto L5c0;
                case 59: goto L277;
                case 60: goto L981;
                case 61: goto L9ba;
                case 62: goto L213;
                case 63: goto L63c;
                case 64: goto L20;
                case 65: goto L26;
                case 66: goto L13a;
                case 67: goto L8fe;
                case 68: goto L219;
                default: goto L734;
            }
        L734:
            goto L217
        L738:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt64Size(r11, r8)
            goto Lca6
        L740:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto Labc
        L748:
            r15 = 1
            goto Lce7
        L74d:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeSInt64List(r11, r5, r7)
            goto L79b
        L755:
            r6.putInt(r1, r8, r5)
        L758:
            goto Ld42
        L75c:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L6fe
        L764:
            java.util.List r5 = (java.util.List) r5
            goto L91a
        L76a:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L84e
        L772:
            if (r8 != 0) goto L777
            goto Lf09
        L777:
            goto L60e
        L77b:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L7fb
        L783:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lbbf
        L78b:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L5ef
        L793:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeMessageList(r11, r5, r8)
            goto L721
        L79b:
            goto Le3c
        L79d:
            goto Le40
        L7a1:
            if (r5 > 0) goto L7a6
            goto L856
        L7a6:
            goto L104
        L7aa:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Lbe3
        L7b2:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64ListNoTag(r5)
            goto L8c9
        L7ba:
            androidx.datastore.preferences.protobuf.FieldHashSet r0 = r0.getExtensions(r1)
            goto L673
        L7c2:
            goto Le3c
        L7c4:
            goto L239
        L7c8:
            goto Le3c
        L7ca:
            goto L8c1
        L7ce:
            long r8 = (long) r13
            goto L8d
        L7d3:
            if (r5 != 0) goto L7d8
            goto L856
        L7d8:
            goto Laad
        L7dc:
            if (r5 > 0) goto L7e1
            goto L856
        L7e1:
            goto L54a
        L7e5:
            androidx.datastore.preferences.protobuf.FieldType r5 = androidx.datastore.preferences.protobuf.FieldType.SINT64_LIST_PACKED
            goto L4
        L7eb:
            r1 = 21
            goto Lc86
        L7f2:
            if (r5 > 0) goto L7f7
            goto L856
        L7f7:
            goto L162
        L7fb:
            java.util.List r5 = (java.util.List) r5
            goto L403
        L801:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeUInt64List(r11, r5, r7)
            goto L261
        L809:
            long r8 = (long) r13
            goto L70
        L80e:
            int r9 = r9 + r0
        L80f:
            goto Lad3
        L813:
            long r8 = r6.getlong(r1, r8)
            goto Le63
        L81b:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L2e8
        L823:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L8f0
        L82b:
            goto L245
        L82d:
            goto Lcc5
        L831:
            bool r5 = r0 is androidx.datastore.preferences.protobuf.bytestring
            goto L44c
        L837:
            goto Lba7
        L839:
            goto Leca
        L83d:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L47f
        L845:
            if (r8 != 0) goto L84a
            goto Lab8
        L84a:
            goto Ldbb
        L84e:
            goto L1b9
        L850:
            goto L3ea
        L854:
            goto Le3c
        L856:
            goto L5e3
        L85a:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L32b
        L862:
            r5 = r12
            goto L3b2
        L867:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L168
        L86f:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeFixed64Size(r11, r14)
            goto L82b
        L877:
            if (r5 > 0) goto L87c
            goto L856
        L87c:
            goto La7f
        L880:
            long r8 = oneoflongAt(r1, r8)
            goto L61b
        L888:
            if (r5 > 0) goto L88d
            goto L856
        L88d:
            goto L5e9
        L891:
            r6.putInt(r1, r8, r5)
        L894:
            goto La9d
        L898:
            if (r5 != 0) goto L89d
            goto L856
        L89d:
            goto L8e3
        L8a1:
            java.util.List r5 = (java.util.List) r5
            goto L509
        L8a7:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeEnumList(r11, r5, r7)
            goto L623
        L8af:
            if (r5 > 0) goto L8b4
            goto L856
        L8b4:
            goto L6b9
        L8b8:
            if (r5 != 0) goto L8bd
            goto L856
        L8bd:
            goto L5db
        L8c1:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L4da
        L8c9:
            if (r5 > 0) goto L8ce
            goto L856
        L8ce:
            goto L600
        L8d2:
            goto L1b9
        L8d4:
            goto L929
        L8d8:
            r8 = r5
            goto Lad
        L8dd:
            goto L5e5
        L8df:
            goto Le0a
        L8e3:
            int r5 = oneofIntAt(r1, r8)
            goto L10a
        L8eb:
            long r8 = (long) r13
            goto L17c
        L8f0:
            java.util.List r5 = (java.util.List) r5
            goto L501
        L8f6:
            goto L197
        L8f8:
            goto L517
        L8fc:
            goto Le3c
        L8fe:
            goto L531
        L902:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Ldaf
        L90a:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L67b
        L912:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Ld2c
        L91a:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeBoolListNoTag(r5)
            goto L7dc
        L922:
            r8 = 1048575(0xfffff, float:1.469367E-39)
            goto L417
        L929:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L550
        L931:
            if (r8 != 0) goto L936
            goto La7b
        L936:
            goto Lbc5
        L93a:
            r7 = 0
            goto Le8b
        L93f:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L94
        L947:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lc61
        L94f:
            java.util.List r5 = (java.util.List) r5
            goto Lecf
        L955:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto L994
        L95d:
            r5 = r12
            goto L7aa
        L962:
            int r0 = r0 % r1
            goto Lc1a
        L968:
            r1 = r18
            goto L9f4
        L96e:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeInt64Size(r11, r8)
            goto Ld99
        L976:
            if (r5 != 0) goto L97b
            goto L856
        L97b:
            goto L280
        L97f:
            goto Le3c
        L981:
            goto L65
        L985:
            if (r5 > 0) goto L98a
            goto L856
        L98a:
            goto L556
        L98e:
            r16 = r9
            goto L353
        L994:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeGroupSize(r11, r5, r8)
            goto L8fc
        L99c:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L764
        L9a4:
            long r8 = oneoflongAt(r1, r8)
            goto L96e
        L9ac:
            goto L245
        L9ae:
            goto L662
        L9b2:
            goto Le3c
        L9b4:
            goto L487
        L9b8:
            goto Le3c
        L9ba:
            goto L26d
        L9be:
            java.util.List r5 = (java.util.List) r5
            goto Lc3a
        L9c4:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L230
        L9cc:
            r1 = r18
            goto L15c
        L9d2:
            androidx.datastore.preferences.protobuf.bytestring r5 = (androidx.datastore.preferences.protobuf.bytestring) r5
            goto Ldfc
        L9d8:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeUInt64ListNoTag(r5)
            goto Le51
        L9e0:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeFixed32Size(r11, r7)
            goto L9ac
        L9e8:
            goto L1b9
        L9ea:
            goto L75c
        L9ee:
            goto La3
        L9f0:
            goto La2
        L9f4:
            goto L856
        L9f6:
            goto L463
        L9fa:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L11a
        La02:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeSInt32Size(r11, r0)
            goto Ld52
        La0a:
            goto L197
        La0c:
            goto L22b
        La10:
            r3 = r13
        La11:
            goto Lb66
        La15:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L468
        La1d:
            java.util.List r5 = (java.util.List) r5
            goto L1bd
        La23:
            java.util.List r5 = (java.util.List) r5
            goto L629
        La29:
            long r8 = r6.getlong(r1, r8)
            goto L738
        La31:
            java.util.List r5 = (java.util.List) r5
            goto L7b2
        La37:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto Lacd
        La3f:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Ld77
        La47:
            goto Ld69
        La4a:
            goto L410
        La4e:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeSInt64ListNoTag(r5)
            goto L3db
        La56:
            goto L245
        La58:
            goto Ldaa
        La5c:
            goto L1b9
        La5e:
            goto L99c
        La62:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32List(r11, r5, r7)
            goto L40
        La6a:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto Le71
        La72:
            goto L197
        La74:
            goto L64f
        La78:
            r6.putInt(r1, r8, r5)
        La7b:
            goto Ld3a
        La7f:
            bool r8 = r0.useCachedSizeField
            goto L704
        La85:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto Ldb5
        La8d:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computebytesSize(r11, r0)
            goto L29c
        La95:
            java.lang.object r0 = r6.getobject(r1, r8)
            goto L831
        La9d:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L76a
        Laa5:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64List(r11, r5, r7)
            goto L1af
        Laad:
            int r5 = oneofIntAt(r1, r8)
            goto L56a
        Lab5:
            r6.putInt(r1, r8, r5)
        Lab8:
            goto Lc4e
        Labc:
            if (r5 != 0) goto Lac1
            goto L856
        Lac1:
            goto Lde
        Lac5:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto Lc56
        Lacd:
            goto L1b9
        Lacf:
            goto Ld80
        Lad3:
            return r9
        Lb62:
            goto Ld66
        Lb66:
            int r12 = r12 >>> 20
            goto L3e4
        Lb6c:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32Size(r11, r0)
            goto Lb2
        Lb74:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizebytestringList(r11, r5)
            goto L715
        Lb7c:
            if (r5 != 0) goto Lb81
            goto Lc77
        Lb81:
            goto L14e
        Lb85:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L7d3
        Lb8d:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Lc6f
        Lb95:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L71b
        Lb9d:
            r13 = r12 & r8
            goto Lc9b
        Lba3:
            int r3 = r6.getInt(r1, r3)
        Lba7:
            goto L2a2
        Lbab:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto L5a0
        Lbb3:
            goto L245
        Lbb5:
            goto L2f1
        Lbb9:
            goto Le3c
        Lbbb:
            goto Lb8d
        Lbbf:
            java.util.List r5 = (java.util.List) r5
            goto L8a7
        Lbc5:
            long r8 = (long) r13
            goto La78
        Lbca:
            if (r8 != 0) goto Lbcf
            goto L856
        Lbcf:
            goto Ld58
        Lbd3:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto L209
        Lbdb:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizestringList(r11, r5)
            goto L572
        Lbe3:
            if (r5 != 0) goto Lbe8
            goto Lc77
        Lbe8:
            goto L5f8
        Lbec:
            r4 = r2
            goto L27b
        Lbf1:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computebytesSize(r11, r0)
            goto L8f6
        Lbf9:
            int r0 = r6.getInt(r1, r8)
            goto Ldee
        Lc01:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L1b5
        Lc09:
            if (r10 <= r5) goto Lc0e
            goto L9f0
        Lc0e:
            goto L9ee
        Lc12:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt64Size(r11, r8)
            goto L19b
        Lc1a:
            if (r0 <= 0) goto Lc1f
            goto L3bd
        Lc1f:
            goto L3ba
        Lc23:
            goto L197
        Lc25:
            goto L6bf
        Lc29:
            if (r5 != 0) goto Lc2e
            goto L8df
        Lc2e:
            goto La29
        Lc32:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L9be
        Lc3a:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeBoolList(r11, r5, r7)
            goto Le24
        Lc42:
            java.util.List r5 = (java.util.List) r5
            goto L74d
        Lc48:
            bool r8 = r5 is androidx.datastore.preferences.protobuf.bytestring
            goto L384
        Lc4e:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto Ld32
        Lc56:
            goto L1b9
        Lc58:
            goto L38d
        Lc5c:
            long r8 = (long) r13
            goto L30e
        Lc61:
            java.util.List r5 = (java.util.List) r5
            goto L3cd
        Lc67:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L6c9
        Lc6f:
            java.util.List r5 = (java.util.List) r5
            goto La4e
        Lc75:
            goto L5e5
        Lc77:
            goto L58d
        Lc7b:
            long r8 = (long) r13
            goto L578
        Lc80:
            goto L5e5
        Lc82:
            goto L588
        Lc86:
            int r0 = r0 + r1
            goto L962
        Lc8c:
            if (r5 != 0) goto Lc91
            goto L856
        Lc91:
            goto L684
        Lc95:
            java.util.List r5 = (java.util.List) r5
            goto L146
        Lc9b:
            r14 = 17
            goto L748
        Lca1:
            r5 = r12
            goto L78b
        Lca6:
            goto L197
        Lca8:
            goto L6c4
        Lcac:
            if (r5 > 0) goto Lcb1
            goto L856
        Lcb1:
            goto L640
        Lcb5:
            r6.putInt(r1, r8, r5)
        Lcb8:
            goto L7f
        Lcbc:
            if (r8 != 0) goto Lcc1
            goto Lf4
        Lcc1:
            goto L59b
        Lcc5:
            r5 = r12
            goto La6a
        Lcca:
            r8 = 0
            goto L2ba
        Lcd0:
            if (r2 < r5) goto Lcd5
            goto L419
        Lcd5:
            goto L6e8
        Lcd9:
            java.util.List r5 = (java.util.List) r5
            goto Lee5
        Lcdf:
            androidx.datastore.preferences.protobuf.Schema r8 = r0.getMessageFieldSchema(r2)
            goto Ld24
        Lce7:
            if (r10 <= r14) goto Lcec
            goto L513
        Lcec:
            goto L1c5
        Lcf0:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeInt32Size(r11, r5)
            goto L9b2
        Lcf8:
            if (r5 != 0) goto Lcfd
            goto L856
        Lcfd:
            goto L880
        Ld01:
            if (r2 != 0) goto Ld06
            goto L80f
        Ld06:
            goto Lfe
        Ld0a:
            java.util.List r5 = (java.util.List) r5
            goto Lbdb
        Ld10:
            r12 = r12[r13]
            goto Lb9d
        Ld16:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Le16
        Ld1e:
            goto Le3c
        Ld20:
            goto L77
        Ld24:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeMessage(r11, r5, r8)
            goto L87
        Ld2c:
            java.util.List r5 = (java.util.List) r5
            goto L431
        Ld32:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L6da
        Ld3a:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto L45b
        Ld42:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto Lf21
        Ld4a:
            int r8 = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(r11)
            goto Lbe
        Ld52:
            goto L197
        Ld54:
            goto L95d
        Ld58:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computefloatSize(r11, r5)
            goto Lb8
        Ld60:
            r16 = r9
            goto Lf3b
        Ld66:
            goto L3bd
        Ld69:
            goto L6d
        Ld6d:
            long r8 = (long) r13
            goto L755
        Ld72:
            long r8 = (long) r13
            goto L288
        Ld77:
            if (r5 != 0) goto Ld7c
            goto Lc77
        Ld7c:
            goto Ld9f
        Ld80:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto La31
        Ld88:
            if (r8 != 0) goto Ld8d
            goto L697
        Ld8d:
            goto L48f
        Ld91:
            bool r8 = r0.isOneofPresent(r1, r11, r2)
            goto Lbca
        Ld99:
            goto Le3c
        Ld9b:
            goto Ld91
        Ld9f:
            r5 = 1
            goto L201
        Lda4:
            goto Le3c
        Lda6:
            goto L4d2
        Ldaa:
            r5 = r12
            goto L18b
        Ldaf:
            androidx.datastore.preferences.protobuf.MessageLite r5 = (androidx.datastore.preferences.protobuf.MessageLite) r5
            goto L955
        Ldb5:
            goto L1b9
        Ldb7:
            goto Lb95
        Ldbb:
            long r8 = (long) r13
            goto Lab5
        Ldc0:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computeEnumSize(r11, r5)
            goto L211
        Ldc8:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto Le3
        Ldd0:
            if (r5 != 0) goto Ldd5
            goto Lc77
        Ldd5:
            goto L86f
        Ldd9:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L39e
        Lde1:
            java.lang.object r8 = r6.getobject(r1, r8)
            goto L539
        Lde9:
            long r8 = (long) r13
            goto L891
        Ldee:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeEnumSize(r11, r0)
            goto Lc23
        Ldf6:
            r1 = r18
            goto Lc75
        Ldfc:
            int r5 = androidx.datastore.preferences.protobuf.CodedStream.computebytesSize(r11, r5)
            goto L1ce
        Le04:
            int r9 = r16 + r8
            goto L3a
        Le0a:
            r0 = r17
            goto L69b
        Le10:
            java.util.List r5 = (java.util.List) r5
            goto L801
        Le16:
            java.util.List r5 = (java.util.List) r5
            goto L51d
        Le1c:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L5c4
        Le24:
            goto Le3c
        Le25:
            goto L4f9
        Le29:
            if (r8 != 0) goto Le2e
            goto L311
        Le2e:
            goto Lc5c
        Le32:
            java.util.List r5 = (java.util.List) r5
            goto La62
        Le38:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64List(r11, r5, r7)
        Le3c:
            goto L41d
        Le40:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L94f
        Le48:
            if (r8 != 0) goto Le4d
            goto L894
        Le4d:
            goto Lde9
        Le51:
            if (r5 > 0) goto Le56
            goto L856
        Le56:
            goto Lebc
        Le5a:
            if (r8 != 0) goto Le5f
            goto L73
        Le5f:
            goto L809
        Le63:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeSInt64Size(r11, r8)
            goto La72
        Le6b:
            goto Le3c
        Le6d:
            goto L112
        Le71:
            if (r5 != 0) goto Le76
            goto L8df
        Le76:
            goto L259
        Le7a:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L898
        Le82:
            if (r8 != 0) goto Le87
            goto Lcb8
        Le87:
            goto L334
        Le8b:
            r8 = 1048575(0xfffff, float:1.469367E-39)
            goto L3a7
        Le92:
            bool r5 = r0.isFieldPresent(r1, r2, r3, r4, r5)
            goto L541
        Le9a:
            bool r5 = r0.isOneofPresent(r1, r11, r2)
            goto L34a
        Lea2:
            int r10 = type(r5)
            goto L130
        Leaa:
            if (r5 > 0) goto Leaf
            goto L856
        Leaf:
            goto L4bb
        Leb3:
            if (r8 != 0) goto Leb8
            goto L758
        Leb8:
            goto Ld6d
        Lebc:
            bool r8 = r0.useCachedSizeField
            goto L845
        Lec2:
            int r0 = androidx.datastore.preferences.protobuf.CodedStream.computeInt32Size(r11, r0)
            goto La0a
        Leca:
            long r3 = (long) r13
            goto Lba3
        Lecf:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeSInt32List(r11, r5, r7)
            goto L57
        Led7:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeInt32List(r11, r5, r7)
            goto L225
        Ledf:
            goto Le3c
        Lee1:
            goto L315
        Lee5:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed64ListNoTag(r5)
            goto Leaa
        Leed:
            if (r5 != 0) goto Lef2
            goto L856
        Lef2:
            goto L9a4
        Lef6:
            java.lang.object r5 = r6.getobject(r1, r8)
            goto L37e
        Lefe:
            int r5 = androidx.datastore.preferences.protobuf.SchemaUtil.computeSizeFixed32ListNoTag(r5)
            goto L877
        Lf06:
            r6.putInt(r1, r8, r5)
        Lf09:
            goto L6e0
        Lf0d:
            long r8 = oneoflongAt(r1, r8)
            goto Lc12
        Lf15:
            java.util.List r5 = (java.util.List) r5
            goto L21d
        Lf1b:
            int r13 = r2 + 2
            goto Ld10
        Lf21:
            int r9 = androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(r5)
            goto L34
        Lf29:
            goto L1b9
        Lf2b:
            goto L912
        Lf2f:
            goto Le3c
        Lf31:
            goto L2af
        Lf35:
            bool r8 = r0.useCachedSizeField
            goto Lcbc
        Lf3b:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r2 = r0.unknownFieldSchema
            goto L5a8
        Lf41:
            int[] r12 = r0.buffer
            goto Lf1b
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public int HashCode(T r9) {
            r8 = this;
            goto L475
        L4:
            long r3 = oneoflongAt(r9, r5)
            goto L86
        Lc:
            int r2 = r2 * 53
            goto L621
        L12:
            int r4 = r8.numberAt(r1)
            goto L16e
        L1a:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L401
        L22:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L696
        L2a:
            if (r3 != 0) goto L2f
            goto L289
        L2f:
            goto L421
        L33:
            if (r3 != 0) goto L38
            goto L289
        L38:
            goto L324
        L3c:
            if (r3 != 0) goto L41
            goto L1d8
        L41:
            goto L1d4
        L45:
            goto L5a8
        L47:
            goto L596
        L4b:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashbool(r3)
            goto L4fb
        L53:
            long r3 = oneoflongAt(r9, r5)
            goto L263
        L5b:
            if (r3 != 0) goto L60
            goto L289
        L60:
            goto L314
        L64:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L4aa
        L6c:
            int r2 = r2 * 53
            goto L4
        L72:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L3f0
        L7a:
            int r2 = r2 * 53
            goto L2c5
        L80:
            goto L5a8
        L82:
            goto L1f2
        L86:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L5c2
        L8e:
            int r3 = r3.GetHashCode()
            goto L184
        L96:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L25a
        L9e:
            return r2
        L12e:
            goto L243
        L132:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L165
        L13a:
            int r2 = r2 * 53
            goto L4cc
        L140:
            int r3 = oneofIntAt(r9, r5)
            goto L460
        L148:
            bool r0 = r8.hasExtensions
            goto L303
        L14e:
            int r2 = r2 + r8
        L14f:
            goto L9e
        L153:
            int r2 = r2 * 53
            goto L571
        L159:
            int r2 = r2 * 53
            goto L5f0
        L15f:
            int r2 = r2 * 53
            goto L3dc
        L165:
            if (r3 != 0) goto L16a
            goto L289
        L16a:
            goto L43d
        L16e:
            long r5 = offset(r3)
            goto L521
        L176:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L190
        L17e:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r8 = r8.extensionSchema
            goto L3a4
        L184:
            goto L5a8
        L186:
            goto L2eb
        L18a:
            goto L5a8
        L18c:
            goto L60e
        L190:
            goto L5a8
        L192:
            goto L3e4
        L196:
            goto L5a8
        L198:
            goto L72
        L19c:
            int r2 = r2 * 53
            goto L31c
        L1a2:
            r2 = r1
        L1a3:
            goto L3cb
        L1a7:
            int r2 = r2 * 53
            goto L585
        L1ad:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L1c3
        L1b5:
            int r3 = oneofIntAt(r9, r5)
            goto L5ce
        L1bd:
            goto L5a8
        L1bf:
            goto L614
        L1c3:
            if (r3 != 0) goto L1c8
            goto L289
        L1c8:
            goto L653
        L1cc:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L4b5
        L1d4:
            int r7 = r3.GetHashCode()
        L1d8:
            goto L13a
        L1dc:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L32a
        L1e4:
            int r1 = r1 + 3
            goto L293
        L1ea:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L33c
        L1f2:
            int r2 = r2 * 53
            goto L34a
        L1f8:
            goto L289
        L1fa:
            goto L2bd
        L1fe:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L659
        L206:
            if (r3 != 0) goto L20b
            goto L289
        L20b:
            goto L271
        L20f:
            goto L12e
        L212:
            goto L59e
        L216:
            int r2 = r2 * 53
            goto L176
        L21c:
            long r3 = java.lang.double.doubleTolongBits(r3)
            goto L5a4
        L224:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L61c
        L22c:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L407
        L234:
            int r2 = r2 * 53
            goto L606
        L23a:
            if (r3 != 0) goto L23f
            goto L289
        L23f:
            goto L454
        L243:
            goto L212
        L246:
            goto L449
        L24a:
            int r3 = oneofIntAt(r9, r5)
            goto L196
        L252:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r9, r5)
            goto L224
        L25a:
            if (r3 != 0) goto L25f
            goto L289
        L25f:
            goto L159
        L263:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L5e2
        L26b:
            goto L5a8
        L26d:
            goto L132
        L271:
            int r2 = r2 * 53
            goto L360
        L277:
            int r3 = r3.GetHashCode()
            goto L1bd
        L27f:
            if (r3 != 0) goto L284
            goto L289
        L284:
            goto L336
        L288:
            int r2 = r2 + r3
        L289:
            goto L1e4
        L28d:
            goto L1d8
        L28f:
            goto L234
        L293:
            goto L1a3
        L295:
            goto L51b
        L299:
            int r2 = r2 * 53
            goto L1dc
        L29f:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L58d
        L2a7:
            long r3 = oneoflongAt(r9, r5)
            goto L22
        L2af:
            int r2 = r2 * 53
            goto L17e
        L2b5:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L466
        L2bd:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L537
        L2c5:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L501
        L2cd:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r9, r5)
            goto L64
        L2d5:
            int r3 = r3.GetHashCode()
            goto L18a
        L2dd:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L427
        L2e5:
            int r2 = r2 * 53
            goto L37e
        L2eb:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L5b
        L2f3:
            int r7 = r3.GetHashCode()
            goto L28d
        L2fb:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L507
        L303:
            if (r0 != 0) goto L308
            goto L14f
        L308:
            goto L2af
        L30c:
            float r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getfloat(r9, r5)
            goto L686
        L314:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L5d4
        L31c:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L638
        L324:
            int r2 = r2 * 53
            goto L2a7
        L32a:
            goto L5a8
        L32c:
            goto L216
        L330:
            goto L5a8
        L332:
            goto L29f
        L336:
            int r2 = r2 * 53
            goto L646
        L33c:
            goto L5a8
        L33e:
            goto L3ea
        L342:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L80
        L34a:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L2d5
        L352:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L56b
        L35a:
            int r2 = r2 * 53
            goto L1a
        L360:
            double r3 = oneofdoubleAt(r9, r5)
            goto L63e
        L368:
            int r3 = oneofIntAt(r9, r5)
            goto L45
        L370:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L55c
        L378:
            int r2 = r2 * 53
            goto L1ea
        L37e:
            int r3 = oneofIntAt(r9, r5)
            goto L4da
        L386:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L62f
        L38e:
            int r2 = r2 * 53
            goto L30c
        L394:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L54c
        L39c:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L23a
        L3a4:
            androidx.datastore.preferences.protobuf.FieldHashSet r8 = r8.getExtensions(r9)
            goto L49c
        L3ac:
            if (r3 != 0) goto L3b1
            goto L289
        L3b1:
            goto L153
        L3b5:
            bool r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getbool(r9, r5)
            goto L4b
        L3bd:
            goto L5a8
        L3bf:
            goto L4a4
        L3c3:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L27f
        L3cb:
            if (r1 < r0) goto L3d0
            goto L295
        L3d0:
            goto L5ba
        L3d4:
            int r3 = r3.GetHashCode()
            goto L415
        L3dc:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r9, r5)
            goto L2b5
        L3e4:
            int r2 = r2 * 53
            goto L22c
        L3ea:
            int r2 = r2 * 53
            goto L252
        L3f0:
            if (r3 != 0) goto L3f5
            goto L289
        L3f5:
            goto L40f
        L3f9:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L4d1
        L401:
            goto L5a8
        L403:
            goto L299
        L407:
            int r3 = r3.GetHashCode()
            goto L540
        L40f:
            int r2 = r2 * 53
            goto L484
        L415:
            goto L5a8
        L417:
            goto L4f5
        L41b:
            int r0 = r0 % r1
            goto L4c3
        L421:
            int r2 = r2 * 53
            goto L24a
        L427:
            int r2 = r2 * 53
            goto L494
        L42d:
            double r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getdouble(r9, r5)
            goto L21c
        L435:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r9, r5)
            goto L47c
        L43d:
            int r2 = r2 * 53
            goto L1b5
        L443:
            goto L5a8
        L445:
            goto L48c
        L449:
            goto L478
        L44c:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L8e
        L454:
            int r2 = r2 * 53
            goto L53
        L45a:
            int r0 = r0 + r1
            goto L41b
        L460:
            goto L5a8
        L462:
            goto L394
        L466:
            goto L5a8
        L468:
            goto L38e
        L46c:
            r7 = 37
            switch(r3) {
                case 0: goto L69e;
                case 1: goto L468;
                case 2: goto L61d;
                case 3: goto L33e;
                case 4: goto L4ac;
                case 5: goto L3bf;
                case 6: goto L4fd;
                case 7: goto L417;
                case 8: goto L4bf;
                case 9: goto L542;
                case 10: goto L192;
                case 11: goto L32c;
                case 12: goto L403;
                case 13: goto L533;
                case 14: goto L503;
                case 15: goto L509;
                case 16: goto L28f;
                case 17: goto L332;
                case 18: goto L18c;
                case 19: goto L18c;
                case 20: goto L18c;
                case 21: goto L18c;
                case 22: goto L18c;
                case 23: goto L18c;
                case 24: goto L18c;
                case 25: goto L18c;
                case 26: goto L18c;
                case 27: goto L18c;
                case 28: goto L18c;
                case 29: goto L18c;
                case 30: goto L18c;
                case 31: goto L18c;
                case 32: goto L18c;
                case 33: goto L18c;
                case 34: goto L18c;
                case 35: goto L18c;
                case 36: goto L18c;
                case 37: goto L18c;
                case 38: goto L18c;
                case 39: goto L18c;
                case 40: goto L18c;
                case 41: goto L18c;
                case 42: goto L18c;
                case 43: goto L18c;
                case 44: goto L18c;
                case 45: goto L18c;
                case 46: goto L18c;
                case 47: goto L18c;
                case 48: goto L18c;
                case 49: goto L18c;
                case 50: goto L82;
                case 51: goto L445;
                case 52: goto L5e4;
                case 53: goto L56d;
                case 54: goto L198;
                case 55: goto L698;
                case 56: goto L47;
                case 57: goto L548;
                case 58: goto L581;
                case 59: goto L1bf;
                case 60: goto L186;
                case 61: goto L4dc;
                case 62: goto L5d0;
                case 63: goto L26d;
                case 64: goto L5c4;
                case 65: goto L462;
                case 66: goto L62b;
                case 67: goto L67a;
                case 68: goto L1fa;
                default: goto L471;
            }
        L471:
            goto L1f8
        L475:
            goto L246
        L478:
            goto L4e0
        L47c:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L531
        L484:
            long r3 = oneoflongAt(r9, r5)
            goto L352
        L48c:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L206
        L494:
            int r3 = r3.GetHashCode()
            goto L678
        L49c:
            int r8 = r8.GetHashCode()
            goto L14e
        L4a4:
            int r2 = r2 * 53
            goto L2cd
        L4aa:
            goto L5a8
        L4ac:
            goto L378
        L4b0:
            r1 = 0
            goto L1a2
        L4b5:
            int r3 = r3.GetHashCode()
            goto L330
        L4bd:
            goto L289
        L4bf:
            goto L19c
        L4c3:
            if (r0 <= 0) goto L4c8
            goto L212
        L4c8:
            goto L20f
        L4cc:
            int r2 = r2 + r7
            goto L4bd
        L4d1:
            if (r3 != 0) goto L4d6
            goto L289
        L4d6:
            goto L1a7
        L4da:
            goto L5a8
        L4dc:
            goto L1fe
        L4e0:
            r0 = 3
            goto L555
        L4e7:
            int r0 = r0.GetHashCode()
            goto L5f8
        L4ef:
            int r2 = r2 * 53
            goto L5e8
        L4f5:
            int r2 = r2 * 53
            goto L3b5
        L4fb:
            goto L5a8
        L4fd:
            goto Lc
        L501:
            goto L5a8
        L503:
            goto L5c8
        L507:
            goto L5a8
        L509:
            goto L7a
        L50d:
            int r2 = r2 * 53
            goto L42d
        L513:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L5fd
        L51b:
            int r2 = r2 * 53
            goto L662
        L521:
            int r3 = type(r3)
            goto L46c
        L529:
            int r3 = java.lang.float.floatToIntBits(r3)
            goto L443
        L531:
            goto L5a8
        L533:
            goto L35a
        L537:
            if (r3 != 0) goto L53c
            goto L289
        L53c:
            goto L2dd
        L540:
            goto L5a8
        L542:
            goto L668
        L546:
            goto L5a8
        L548:
            goto L1ad
        L54c:
            if (r3 != 0) goto L551
            goto L289
        L551:
            goto L6c
        L555:
            r1 = 14
            goto L45a
        L55c:
            if (r3 != 0) goto L561
            goto L289
        L561:
            goto L5b4
        L565:
            int r2 = r2 * 53
            goto L44c
        L56b:
            goto L5a8
        L56d:
            goto L39c
        L571:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L579
        L579:
            java.lang.string r3 = (java.lang.string) r3
            goto L67e
        L57f:
            goto L5a8
        L581:
            goto L386
        L585:
            int r3 = oneofIntAt(r9, r5)
            goto L26b
        L58d:
            if (r3 != 0) goto L592
            goto L1d8
        L592:
            goto L2f3
        L596:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L33
        L59e:
            int[] r0 = r8.buffer
            goto L64e
        L5a4:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
        L5a8:
            goto L288
        L5ac:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashbool(r3)
            goto L546
        L5b4:
            int r2 = r2 * 53
            goto L140
        L5ba:
            int r3 = r8.typeAndOffsetAt(r1)
            goto L12
        L5c2:
            goto L5a8
        L5c4:
            goto L3f9
        L5c8:
            int r2 = r2 * 53
            goto L435
        L5ce:
            goto L5a8
        L5d0:
            goto L513
        L5d4:
            int r2 = r2 * 53
            goto L277
        L5da:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L2a
        L5e2:
            goto L5a8
        L5e4:
            goto L96
        L5e8:
            bool r3 = oneofboolAt(r9, r5)
            goto L5ac
        L5f0:
            float r3 = oneoffloatAt(r9, r5)
            goto L529
        L5f8:
            int r2 = r2 + r0
            goto L148
        L5fd:
            if (r3 != 0) goto L602
            goto L289
        L602:
            goto L2e5
        L606:
            long r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getlong(r9, r5)
            goto L2fb
        L60e:
            int r2 = r2 * 53
            goto L1cc
        L614:
            bool r3 = r8.isOneofPresent(r9, r4, r1)
            goto L3ac
        L61c:
            goto L5a8
        L61d:
            goto L15f
        L621:
            int r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getInt(r9, r5)
            goto L3bd
        L629:
            goto L5a8
        L62b:
            goto L370
        L62f:
            if (r3 != 0) goto L634
            goto L289
        L634:
            goto L4ef
        L638:
            java.lang.string r3 = (java.lang.string) r3
            goto L3d4
        L63e:
            long r3 = java.lang.double.doubleTolongBits(r3)
            goto L342
        L646:
            long r3 = oneoflongAt(r9, r5)
            goto L68e
        L64e:
            int r0 = r0.length
            goto L4b0
        L653:
            int r2 = r2 * 53
            goto L368
        L659:
            if (r3 != 0) goto L65e
            goto L289
        L65e:
            goto L565
        L662:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r8.unknownFieldSchema
            goto L670
        L668:
            java.lang.object r3 = androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(r9, r5)
            goto L3c
        L670:
            java.lang.object r0 = r0.getFromMessage(r9)
            goto L4e7
        L678:
            goto L5a8
        L67a:
            goto L3c3
        L67e:
            int r3 = r3.GetHashCode()
            goto L57f
        L686:
            int r3 = java.lang.float.floatToIntBits(r3)
            goto L69c
        L68e:
            int r3 = androidx.datastore.preferences.protobuf.Internal.hashlong(r3)
            goto L629
        L696:
            goto L5a8
        L698:
            goto L5da
        L69c:
            goto L5a8
        L69e:
            goto L50d
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public readonly bool IsInitialized(T r15) {
            r14 = this;
            goto L93
        L4:
            r4 = r2
        L5:
            goto L19b
        L9:
            r9 = r5[r2]
            goto L5d
        Lf:
            bool r14 = r7.isListInitialized(r8, r13, r9)
            goto L251
        L17:
            r7 = r14
            goto Ldc
        L1c:
            bool r14 = r14.isInitialized()
            goto L248
        L24:
            int[] r5 = r14.intArray
            goto L9
        L2a:
            return r1
        L2b:
            goto L25f
        L2f:
            r3 = r0
            goto L1cd
        L34:
            r0 = 1048575(0xfffff, float:1.469367E-39)
            goto L227
        L3b:
            goto L1d3
        L3e:
            goto L34
        L42:
            r10 = r3
            goto L88
        L47:
            r15 = 27
            goto L1e2
        L4d:
            r15 = 9
            goto L121
        L53:
            r7 = r14
            goto La3
        L58:
            r15 = r8
            goto L267
        L5d:
            int r5 = r14.numberAt(r9)
            goto L16a
        L65:
            r4 = r11
            goto L8d
        L6a:
            int r7 = r7 >>> 20
            goto L70
        L70:
            int r12 = r6 << r7
            goto Lee
        L76:
            if (r2 < r5) goto L7b
            goto L8f
        L7b:
            goto L24
        L7f:
            if (r14 != 0) goto L84
            goto L244
        L84:
            goto L238
        L88:
            r11 = r4
        L89:
            goto La8
        L8d:
            goto L5
        L8f:
            goto L53
        L93:
            goto L203
        L96:
            goto Le7
        L9a:
            if (r14 == 0) goto L9f
            goto L244
        L9f:
            goto L243
        La3:
            r8 = r15
            goto Le1
        La8:
            bool r3 = isRequired(r13)
            goto L17
        Lb0:
            return r1
        Lb1:
            goto L1c5
        Lb5:
            androidx.datastore.preferences.protobuf.Schema r14 = r7.getMessageFieldSchema(r9)
            goto Lc2
        Lbd:
            r11 = r4
            goto L271
        Lc2:
            bool r14 = isInitialized(r8, r13, r14)
            goto L9a
        Lca:
            if (r0 <= 0) goto Lcf
            goto L3e
        Lcf:
            goto L3b
        Ld3:
            if (r14 != 0) goto Ld8
            goto L244
        Ld8:
            goto Lb5
        Ldc:
            r8 = r15
            goto L20d
        Le1:
            bool r14 = r7.hasExtensions
            goto L138
        Le7:
            r0 = 1
            goto L172
        Lee:
            if (r8 != r3) goto Lf3
            goto Lfe
        Lf3:
            goto L141
        Lf7:
            int[] r7 = r14.buffer
            goto L1dc
        Lfd:
            goto L89
        Lfe:
            goto L42
        L102:
            r15 = 49
            goto L153
        L108:
            return r1
        L109:
            goto L130
        L10d:
            long r6 = (long) r8
            goto L1f3
        L112:
            if (r14 != r15) goto L117
            goto L2b
        L117:
            goto L102
        L11b:
            r15 = 60
            goto L14a
        L121:
            if (r14 != r15) goto L126
            goto L109
        L126:
            goto L190
        L12a:
            int r0 = r0 + r1
            goto L18a
        L130:
            bool r14 = r7.isFieldPresent(r8, r9, r10, r11, r12)
            goto Ld3
        L138:
            if (r14 != 0) goto L13d
            goto L1d8
        L13d:
            goto L1b0
        L141:
            if (r8 != r0) goto L146
            goto L1f7
        L146:
            goto L207
        L14a:
            if (r14 != r15) goto L14f
            goto L2b
        L14f:
            goto L15c
        L153:
            if (r14 != r15) goto L158
            goto L25b
        L158:
            goto L1b6
        L15c:
            r15 = 68
            goto L112
        L162:
            androidx.datastore.preferences.protobuf.FieldHashSet r14 = r14.getExtensions(r8)
            goto L1c
        L16a:
            int r13 = r14.typeAndOffsetAt(r9)
            goto Lf7
        L172:
            r1 = 17
            goto L12a
        L179:
            if (r14 == 0) goto L17e
            goto L244
        L17e:
            goto L25a
        L182:
            bool r14 = isInitialized(r8, r13, r14)
            goto L179
        L18a:
            int r0 = r0 % r1
            goto Lca
        L190:
            r15 = 17
            goto L21e
        L196:
            r14 = r7
            goto L58
        L19b:
            int r5 = r14.checkInitializedCount
            goto L1fb
        L1a1:
            int r2 = r2 + 1
            goto L196
        L1a7:
            if (r14 != r15) goto L1ac
            goto L26d
        L1ac:
            goto L26c
        L1b0:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r14 = r7.extensionSchema
            goto L162
        L1b6:
            r15 = 50
            goto L1a7
        L1bc:
            if (r14 == 0) goto L1c1
            goto L244
        L1c1:
            goto L2a
        L1c5:
            int r14 = type(r13)
            goto L4d
        L1cd:
            r2 = r1
            goto L4
        L1d2:
            return r6
        L1d3:
            goto L200
        L1d7:
            return r1
        L1d8:
            goto L1d2
        L1dc:
            int r8 = r9 + 2
            goto L22c
        L1e2:
            if (r14 != r15) goto L1e7
            goto L25b
        L1e7:
            goto L11b
        L1eb:
            bool r14 = r7.isDictionaryInitialized(r8, r13, r9)
            goto L1bc
        L1f3:
            int r4 = r3.getInt(r15, r6)
        L1f7:
            goto Lbd
        L1fb:
            r6 = 1
            goto L76
        L200:
            goto L3e
        L203:
            goto L240
        L207:
            sun.misc.Unsafe r3 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L10d
        L20d:
            if (r3 != 0) goto L212
            goto Lb1
        L212:
            goto L216
        L216:
            bool r14 = r7.isFieldPresent(r8, r9, r10, r11, r12)
            goto L276
        L21e:
            if (r14 != r15) goto L223
            goto L109
        L223:
            goto L47
        L227:
            r1 = 0
            goto L2f
        L22c:
            r7 = r7[r8]
            goto L232
        L232:
            r8 = r7 & r0
            goto L6a
        L238:
            androidx.datastore.preferences.protobuf.Schema r14 = r7.getMessageFieldSchema(r9)
            goto L182
        L240:
            goto L96
        L243:
            return r1
        L244:
            goto L1a1
        L248:
            if (r14 == 0) goto L24d
            goto L1d8
        L24d:
            goto L1d7
        L251:
            if (r14 == 0) goto L256
            goto L244
        L256:
            goto L108
        L25a:
            return r1
        L25b:
            goto Lf
        L25f:
            bool r14 = r7.isOneofPresent(r8, r5, r9)
            goto L7f
        L267:
            r3 = r10
            goto L65
        L26c:
            goto L244
        L26d:
            goto L1eb
        L271:
            r10 = r8
            goto Lfd
        L276:
            if (r14 == 0) goto L27b
            goto Lb1
        L27b:
            goto Lb0
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public void MakeImmutable(T r8) {
            r7 = this;
            goto L16
        L4:
            int[] r0 = r7.buffer
            goto L11
        La:
            r0.makeImmutable(r8)
            goto L7b
        L11:
            int r0 = r0.length
            goto L174
        L16:
            goto L77
        L19:
            goto L2c
        L1d:
            if (r2 != r5) goto L22
            goto L70
        L22:
            goto L5f
        L26:
            int r0 = r0 % r1
            goto L19b
        L2c:
            r0 = 18
            goto L17e
        L33:
            r0.clearMemoizedSerializedSize()
            goto L48
        L3a:
            bool r2 = r7.isFieldPresent(r8, r1)
            goto L65
        L42:
            int r1 = r1 + 3
            goto L110
        L48:
            r0.clearMemoizedHashCode()
            goto L138
        L4f:
            java.lang.object r3 = r5.getobject(r8, r3)
            goto Lb5
        L57:
            int r2 = r7.typeAndOffsetAt(r1)
            goto L89
        L5f:
            r5 = 60
            goto L1a4
        L65:
            if (r2 != 0) goto L6a
            goto L15b
        L6a:
            goto L1d5
        L6e:
            goto L15b
        L70:
            goto L3a
        L74:
            goto L167
        L77:
            goto L1c3
        L7b:
            bool r0 = r7.hasExtensions
            goto L16b
        L81:
            java.lang.object r5 = r2.getobject(r8, r3)
            goto L1b2
        L89:
            long r3 = offset(r2)
            goto L9e
        L91:
            sun.misc.Unsafe r5 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L18d
        L97:
            r2.putobject(r8, r3, r5)
            goto L15f
        L9e:
            int r2 = type(r2)
            goto L14b
        La6:
            goto L154
        La8:
            goto L1c6
        Lac:
            if (r2 != 0) goto Lb1
            goto L15b
        Lb1:
            goto L185
        Lb5:
            r2.makeImmutable(r3)
            goto L6e
        Lbc:
            return
        L106:
            goto L74
        L10a:
            sun.misc.Unsafe r5 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L4f
        L110:
            goto L175
        L111:
            goto L1ff
        L115:
            bool r0 = isMutable(r8)
            goto L205
        L11d:
            int r0 = r0 + r1
            goto L26
        L123:
            sun.misc.Unsafe r2 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L81
        L129:
            if (r1 < r0) goto L12e
            goto L111
        L12e:
            goto L57
        L132:
            r5 = 68
            goto L1dd
        L138:
            r0.markImmutable()
        L13b:
            goto L4
        L13f:
            androidx.datastore.preferences.protobuf.GeneratedMessageLite r0 = (androidx.datastore.preferences.protobuf.GeneratedMessageLite) r0
            goto L33
        L145:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r7 = r7.extensionSchema
            goto L151
        L14b:
            r5 = 9
            goto L1d
        L151:
            r7.makeImmutable(r8)
        L154:
            goto Lbc
        L158:
            r2.makeImmutable(r3)
        L15b:
            goto L42
        L15f:
            goto L15b
        L160:
            goto L195
        L164:
            goto L106
        L167:
            goto L115
        L16b:
            if (r0 != 0) goto L170
            goto L154
        L170:
            goto L145
        L174:
            r1 = 0
        L175:
            goto L129
        L179:
            goto L15b
        L17a:
            goto L123
        L17e:
            r1 = 18
            goto L11d
        L185:
            androidx.datastore.preferences.protobuf.Schema r2 = r7.getMessageFieldSchema(r1)
            goto L10a
        L18d:
            java.lang.object r3 = r5.getobject(r8, r3)
            goto L158
        L195:
            androidx.datastore.preferences.protobuf.ListFieldSchema r2 = r7.listFieldSchema
            goto L20e
        L19b:
            if (r0 <= 0) goto L1a0
            goto L167
        L1a0:
            goto L164
        L1a4:
            if (r2 != r5) goto L1a9
            goto L217
        L1a9:
            goto L132
        L1ad:
            r0 = r8
            goto L13f
        L1b2:
            if (r5 != 0) goto L1b7
            goto L15b
        L1b7:
            goto L1f1
        L1bb:
            java.lang.object r5 = r6.toImmutable(r5)
            goto L97
        L1c3:
            goto L19
        L1c6:
            bool r0 = r8 is androidx.datastore.preferences.protobuf.GeneratedMessageLite
            goto L1cc
        L1cc:
            if (r0 != 0) goto L1d1
            goto L13b
        L1d1:
            goto L1ad
        L1d5:
            androidx.datastore.preferences.protobuf.Schema r2 = r7.getMessageFieldSchema(r1)
            goto L91
        L1dd:
            if (r2 != r5) goto L1e2
            goto L217
        L1e2:
            switch(r2) {
                case 17: goto L70;
                case 18: goto L160;
                case 19: goto L160;
                case 20: goto L160;
                case 21: goto L160;
                case 22: goto L160;
                case 23: goto L160;
                case 24: goto L160;
                case 25: goto L160;
                case 26: goto L160;
                case 27: goto L160;
                case 28: goto L160;
                case 29: goto L160;
                case 30: goto L160;
                case 31: goto L160;
                case 32: goto L160;
                case 33: goto L160;
                case 34: goto L160;
                case 35: goto L160;
                case 36: goto L160;
                case 37: goto L160;
                case 38: goto L160;
                case 39: goto L160;
                case 40: goto L160;
                case 41: goto L160;
                case 42: goto L160;
                case 43: goto L160;
                case 44: goto L160;
                case 45: goto L160;
                case 46: goto L160;
                case 47: goto L160;
                case 48: goto L160;
                case 49: goto L160;
                case 50: goto L17a;
                default: goto L1e5;
            }
        L1e5:
            goto L179
        L1e9:
            bool r2 = r7.isOneofPresent(r8, r2, r1)
            goto Lac
        L1f1:
            androidx.datastore.preferences.protobuf.DictionaryFieldSchema r6 = r7.mapFieldSchema
            goto L1bb
        L1f7:
            int r2 = r7.numberAt(r1)
            goto L1e9
        L1ff:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r7.unknownFieldSchema
            goto La
        L205:
            if (r0 == 0) goto L20a
            goto La8
        L20a:
            goto La6
        L20e:
            r2.makeImmutableListAt(r8, r3)
            goto L215
        L215:
            goto L15b
        L217:
            goto L1f7
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public void MergeFrom(T r7, androidx.datastore.preferences.protobuf.Reader r8, androidx.datastore.preferences.protobuf.ExtensionRegistryLite r9) throws java.io.IOException {
            r6 = this;
            goto Lb
        L4:
            checkMutable(r7)
            goto L61
        Lb:
            goto L39
        Le:
            goto L5a
        L12:
            r0 = r6
            goto L67
        L17:
            r5 = r9
            goto L2f
        L1c:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r2 = r6.extensionSchema
            goto L12
        L22:
            int r0 = r0 + r1
            goto L6c
        L28:
            r1 = 19
            goto L22
        L2f:
            r0.mergeFromHelper(r1, r2, r3, r4, r5)
            goto L55
        L36:
            goto L51
        L39:
            goto L4b
        L3d:
            if (r0 <= 0) goto L42
            goto L51
        L42:
            goto L4e
        L46:
            r4 = r8
            goto L17
        L4b:
            goto Le
        L4e:
            goto L56
        L51:
            goto L72
        L55:
            return
        L56:
            goto L36
        L5a:
            r0 = 10
            goto L28
        L61:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r1 = r6.unknownFieldSchema
            goto L1c
        L67:
            r3 = r7
            goto L46
        L6c:
            int r0 = r0 % r1
            goto L3d
        L72:
            r9.GetType()
            goto L4
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public void MergeFrom(T r3, T r4) {
            r2 = this;
            goto Le
        L4:
            return
        L5:
            goto L72
        L9:
            goto L5e
        La:
            goto L8f
        Le:
            goto L75
        L11:
            goto L49
        L15:
            androidx.datastore.preferences.protobuf.ExtensionSchema<object> r2 = r2.extensionSchema
            goto L79
        L1b:
            checkMutable(r3)
            goto L32
        L22:
            androidx.datastore.preferences.protobuf.SchemaUtil.mergeUnknownFields(r0, r3, r4)
            goto La0
        L29:
            if (r0 < r1) goto L2e
            goto La
        L2e:
            goto L56
        L32:
            r4.GetType()
            goto L5d
        L39:
            goto L11
        L3c:
            int r0 = r0 + 3
            goto L9
        L42:
            r1 = 17
            goto L50
        L49:
            r0 = 1
            goto L42
        L50:
            int r0 = r0 + r1
            goto L95
        L56:
            r2.mergeSingleField(r3, r4, r0)
            goto L3c
        L5d:
            r0 = 0
        L5e:
            goto L89
        L62:
            goto L5
        L65:
            goto L1b
        L69:
            if (r0 != 0) goto L6e
            goto L7c
        L6e:
            goto L15
        L72:
            goto L65
        L75:
            goto L39
        L79:
            androidx.datastore.preferences.protobuf.SchemaUtil.mergeExtensions(r2, r3, r4)
        L7c:
            goto L4
        L80:
            if (r0 <= 0) goto L85
            goto L65
        L85:
            goto L62
        L89:
            int[] r1 = r2.buffer
            goto L9b
        L8f:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r2.unknownFieldSchema
            goto L22
        L95:
            int r0 = r0 % r1
            goto L80
        L9b:
            int r1 = r1.length
            goto L29
        La0:
            bool r0 = r2.hasExtensions
            goto L69
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public void MergeFrom(T r8, byte[] r9, int r10, int r11, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r12) throws java.io.IOException {
            r7 = this;
            goto L5d
        L4:
            r2 = r9
            goto L47
        L9:
            return
        La:
            goto L3b
        Le:
            int r0 = r0 % r1
            goto L2d
        L14:
            goto La
        L17:
            goto L58
        L1b:
            int r0 = r0 + r1
            goto Le
        L21:
            r4 = r11
            goto L42
        L26:
            r1 = 11
            goto L1b
        L2d:
            if (r0 <= 0) goto L32
            goto L17
        L32:
            goto L14
        L36:
            r0 = r7
            goto L53
        L3b:
            goto L17
        L3e:
            goto L64
        L42:
            r6 = r12
            goto L67
        L47:
            r3 = r10
            goto L21
        L4c:
            r0 = 24
            goto L26
        L53:
            r1 = r8
            goto L4
        L58:
            r5 = 0
            goto L36
        L5d:
            goto L3e
        L60:
            goto L4c
        L64:
            goto L60
        L67:
            r0.parseMessage(r1, r2, r3, r4, r5, r6)
            goto L9
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public T NewInstance() {
            r1 = this;
            goto Lc
        L4:
            return r1
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            androidx.datastore.preferences.protobuf.NewInstanceSchema r0 = r1.newInstanceSchema
            goto L19
        L19:
            androidx.datastore.preferences.protobuf.MessageLite r1 = r1.defaultInstance
            goto L1f
        L1f:
            java.lang.object r1 = r0.newInstance(r1)
            goto L4
    }

    int parseMessage(T r27, byte[] r28, int r29, int r30, int r31, androidx.datastore.preferences.protobuf.ArrayDecoders.Registers r32) throws java.io.IOException {
            r26 = this;
            goto Lf69
        L4:
            r3 = r9
            goto Laae
        L9:
            r12 = r12 | r20
            goto La4c
        Lf:
            r1 = r27
            goto L693
        L15:
            r5 = r21
            goto Lf64
        L1b:
            r5 = r22
            goto L5ba
        L21:
            r0 = r9
        L22:
            goto L27c
        L26:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putbool(r8, r5, r4)
            goto Lec2
        L2d:
            r2 = r28
            goto L437
        L33:
            r2.putInt(r1, r4, r6)
            goto L9d3
        L3a:
            r1.putlong(r2, r3, r5)
            goto Lc52
        L41:
            r10 = r10 & r17
            goto L33f
        L47:
            if (r0 == r15) goto L4c
            goto L26a
        L4c:
            goto L92e
        L50:
            goto L804
        L52:
            goto L4f5
        L56:
            r9 = r24
            goto Lfc4
        L5c:
            r10 = r0
            goto Lbea
        L61:
            r8 = r10
            goto L6d5
        L66:
            r3 = r2
            goto L8af
        L6b:
            r3 = r32
            goto La68
        L71:
            r12 = r12 | r20
            goto L6f2
        L77:
            androidx.datastore.preferences.protobuf.ExtensionRegistryLite r1 = r13.extensionRegistry
            goto Lf57
        L7d:
            r5 = r19
            goto L1a6
        L83:
            r3 = r7
            goto L962
        L88:
            r11 = r5
            goto L818
        L8d:
            r10 = 3
            goto L3eb
        L92:
            r1 = r27
            goto Lf5
        L98:
            r6 = r21
            goto L92
        L9e:
            r6 = r8
            goto Ld4f
        La3:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r1, r2, r3)
            goto L3b4
        Lab:
            r2 = r28
            goto L4a5
        Lb1:
            int r5 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r9, r14, r8)
            goto L866
        Lb9:
            r17 = 1048575(0xfffff, float:1.469367E-39)
            goto L8d
        Lc0:
            if (r7 == r14) goto Lc5
            goto Lec4
        Lc5:
            goto L8bb
        Lc9:
            r12 = r18
            goto L99e
        Lcf:
            java.lang.object r6 = r3.object1
            goto L4db
        Ld5:
            r2 = r28
            goto L53e
        Ldb:
            int[] r0 = r9.intArray
            goto L654
        Le1:
            if (r7 == r14) goto Le6
            goto L52
        Le6:
            goto Ld94
        Lea:
            r8 = r1
            goto L3f4
        Lef:
            r5 = r21
            goto L56
        Lf5:
            r18 = r12
            goto L8d8
        Lfb:
            goto L559
        Lfd:
            goto L392
        L101:
            r6 = r8
            goto Lad6
        L106:
            r2 = r9
            goto L6f8
        L10b:
            java.lang.object r2 = r0.filterDictionaryUnknownEnumValues(r1, r2, r3, r4, r5)
            goto L3f9
        L113:
            goto Lec4
        L115:
            goto L1db
        L119:
            r25 = r9
            goto L416
        L11f:
            r9 = r3
            goto L35e
        L124:
            r2.putInt(r1, r3, r6)
            goto Leb0
        L12b:
            r3 = r2
            goto L9f1
        L130:
            java.lang.object r1 = r0.mutableMessageFieldForMerge(r4, r11)
            goto L857
        L138:
            r3 = r25
            goto L113
        L13e:
            r12 = r12 | r20
            goto L7cf
        L144:
            r4 = r3
            goto L12b
        L149:
            goto L823
        L14b:
            goto Lb49
        L14f:
            if (r3 < r4) goto L154
            goto L769
        L154:
            goto Lbfa
        L158:
            r5 = r8
            goto Le13
        L15d:
            r24 = r1
            goto Ldc3
        L163:
            int r4 = (r4 > r6 ? 1 : (r4 == r6 ? 0 : -1))
            goto L1f2
        L169:
            r8 = r17
            goto L634
        L16f:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.mergeMessageField(r1, r2, r3, r4, r5, r6)
            goto La06
        L177:
            r14 = 2
            goto L9eb
        L17c:
            throw r0
        L17d:
            goto Lf2c
        L181:
            if (r9 == r0) goto L186
            goto L6a1
        L186:
            goto Le7a
        L18a:
            r1 = r25
            goto L71
        L190:
            r0 = r9
            goto La9d
        L195:
            r11 = r18
            goto Lf3b
        L19b:
            r8 = r1
            goto Lc6c
        L1a0:
            r24 = r3
            goto L623
        L1a6:
            int r3 = androidx.datastore.preferences.protobuf.ArrayDecoders.mergeGroupField(r2, r3, r4, r5, r6, r7, r8)
            goto L67f
        L1ae:
            r1 = 11
            goto L4c5
        L1b5:
            float r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodefloat(r9, r14)
            goto Lf41
        L1bd:
            long r4 = r3.long1
            goto Laff
        L1c3:
            r1 = r28
            goto L752
        L1c9:
            r7 = r32
            goto L528
        L1cf:
            r2 = r19
            goto L51c
        L1d5:
            r19 = r18
            goto L77f
        L1db:
            r3 = r32
            goto Lea
        L1e1:
            r8 = r25
            goto L45a
        L1e7:
            r3 = r2[r3]
            goto Lb10
        L1ed:
            r11 = -1
            goto L2a6
        L1f2:
            if (r4 != 0) goto L1f7
            goto L3a0
        L1f7:
            goto L46a
        L1fb:
            r12 = r18
            goto L9b6
        L201:
            r13 = r32
            goto L598
        L207:
            r2 = r14
            goto L4ab
        L20c:
            if (r7 == r14) goto L211
            goto Lbaa
        L211:
            goto L2d8
        L215:
            r6 = r11
            goto L5e1
        L21a:
            r24 = r9
            goto L7c9
        L220:
            r2 = r8
            goto L304
        L225:
            r4 = r3
            goto Ld4a
        L22a:
            if (r7 != r3) goto L22f
            goto Lf87
        L22f:
            goto L4bf
        L233:
            r9 = r32
            goto L9bc
        L239:
            r24 = r9
            goto L8f0
        L23f:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r4 = getMutableUnknownFields(r1)
            goto Lce9
        L247:
            r9 = r3
            goto Le4a
        L24c:
            r12 = r12 | r20
        L24e:
            goto L61d
        L252:
            r1 = r8
            goto L29b
        L257:
            r10 = r22
            goto Lf35
        L25d:
            goto L7bc
        L25f:
            goto L71a
        L263:
            r2 = 1
            goto L276
        L268:
            goto L759
        L26a:
            goto L937
        L26e:
            bool r6 = r2.isModifiable()
            goto La1c
        L276:
            r9 = r28
            goto Lac7
        L27c:
            r9 = r24
            goto Lb2b
        L282:
            double r6 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodedouble(r9, r14)
            goto Ld1a
        L28a:
            r9 = r26
            goto Led2
        L290:
            r7 = r13
            goto L4b7
        L295:
            r21 = r14
            goto L9aa
        L29b:
            r8 = r3
            goto L32b
        L2a0:
            r6 = r30
            goto L325
        L2a6:
            r3 = r29
            goto L948
        L2ac:
            r0 = r26
            goto Lb53
        L2b2:
            r2.putInt(r6, r0, r12)
        L2b5:
            goto Ld36
        L2b9:
            r1 = r9
            goto L796
        L2be:
            r12 = r12 | r20
            goto La32
        L2c4:
            long r2 = (long) r10
            goto L84f
        L2c9:
            androidx.datastore.preferences.protobuf.Internal$ProtobufList r2 = (androidx.datastore.preferences.protobuf.Internal.ProtobufList) r2
            goto L26e
        L2cf:
            if (r7 == 0) goto L2d4
            goto L964
        L2d4:
            goto Ldb6
        L2d8:
            r4 = r1
            goto L130
        L2dd:
            r2 = r3
            goto Le39
        L2e2:
            r22 = r4
            goto L5a9
        L2e8:
            r7 = r30
            goto L4ea
        L2ee:
            r3 = r9
            goto Lb64
        L2f3:
            if (r7 != r3) goto L2f8
            goto Lb2d
        L2f8:
            goto L83d
        L2fc:
            int r5 = r0.positionForFieldNumber(r14, r6)
            goto L7f7
        L304:
            r8 = r3
            goto L93d
        L309:
            r6 = r11
            goto L5f3
        L30e:
            r2 = r28
            goto L649
        L314:
            goto L530
        L317:
            goto Lce0
        L31b:
            r8 = r5
            goto Ld80
        L320:
            r6 = r9
            goto L475
        L325:
            r8 = r32
            goto L68e
        L32b:
            r3 = r25
            goto L9e5
        L331:
            r12 = r18
        L333:
            goto L47
        L337:
            int r6 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag32(r6)
            goto L33
        L33f:
            if (r10 != r8) goto L344
            goto L47c
        L344:
            goto L957
        L348:
            r14 = r19
            goto L567
        L34e:
            goto L9a6
        L350:
            goto L23f
        L354:
            r3 = r7
            goto Lf52
        L359:
            r0 = r5
            goto Lc5f
        L35e:
            r3 = r22
            goto L3a
        L364:
            r8 = r14
            goto Lec8
        L369:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodestringRequireUtf8(r1, r2, r3)
            goto Lcfa
        L371:
            r22 = r3
            goto L461
        L377:
            r2.putInt(r1, r4, r7)
            goto Leb6
        L37e:
            r8 = r32
            goto L25d
        L384:
            goto L559
        L386:
            goto Lf5f
        L38a:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure()
            goto L971
        L392:
            r8 = r32
            goto Le28
        L398:
            int r3 = r14 + 8
            goto L9
        L39e:
            goto Lb1b
        L3a0:
            goto Lb19
        L3a4:
            r8 = r17
            goto L767
        L3aa:
            r8 = r6
            goto Ldf9
        L3af:
            r1 = r9
            goto L11f
        L3b4:
            r22 = r5
            goto L1bd
        L3ba:
            int r1 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeMessageList(r1, r2, r3, r4, r5, r6, r7)
            goto Lbb4
        L3c2:
            r5 = r21
            goto Lc11
        L3c8:
            r11 = r5
            goto Ld6f
        L3cd:
            if (r11 <= r10) goto L3d2
            goto Lafb
        L3d2:
            goto Le74
        L3d6:
            if (r7 == 0) goto L3db
            goto Ld02
        L3db:
            goto Lb1
        L3df:
            r10 = r10[r20]
            goto L7f1
        L3e5:
            r16 = 0
            goto L1ed
        L3eb:
            if (r14 > r5) goto L3f0
            goto L7f9
        L3f0:
            goto L8eb
        L3f4:
            r11 = r5
            goto L1cf
        L3f9:
            r3 = r2
            goto L5f9
        L3fe:
            r1.putlong(r2, r3, r5)
            goto Lb4e
        L405:
            r4 = r30
            goto L7ab
        L40b:
            r12 = r12 | r20
            goto Lbd0
        L411:
            r9 = r0
            goto La41
        L416:
            r9 = r2
            goto Lb3e
        L41b:
            androidx.datastore.preferences.protobuf.Internal$EnumVerifier r14 = r0.getEnumFieldVerifier(r11)
            goto Lb8c
        L423:
            r2 = r9
            goto L309
        L428:
            r2 = r1
            goto L42d
        L42d:
            r1 = r8
            goto L9d9
        L432:
            r6 = r2
            goto L585
        L437:
            r4 = r30
            goto Lb73
        L43d:
            r14 = r19
            goto L1b
        L443:
            int r6 = r6 * 2
        L445:
            goto Lc22
        L449:
            r8 = r17
            goto L1fb
        L44f:
            r1 = r6
            goto Ldcf
        L454:
            int r7 = r9.int1
            goto L41b
        L45a:
            r0.storeMessageField(r1, r11, r4)
            goto L2be
        L461:
            if (r8 != r14) goto L466
            goto Lb3a
        L466:
            goto Lc85
        L46a:
            r4 = 1
            goto L39e
        L46f:
            r4 = r28
            goto L2a0
        L475:
            r9 = r5
            goto L486
        L47a:
            goto Lb0c
        L47c:
            goto Ldf3
        L480:
            r10 = 17
            goto L3cd
        L486:
            r5 = r30
            goto L16f
        L48c:
            r9 = r3
            goto L21a
        L491:
            r5 = r21
            goto L557
        L497:
            int r20 = r5 + 2
            goto L3df
        L49d:
            r2 = 5
            switch(r11) {
                case 0: goto L7ff;
                case 1: goto Lfd;
                case 2: goto L674;
                case 3: goto L674;
                case 4: goto L8d4;
                case 5: goto L9e7;
                case 6: goto Lf0b;
                case 7: goto Le46;
                case 8: goto L115;
                case 9: goto L512;
                case 10: goto Leb8;
                case 11: goto L8d4;
                case 12: goto L9d5;
                case 13: goto Lf0b;
                case 14: goto L9e7;
                case 15: goto Le67;
                case 16: goto L25f;
                case 17: goto L386;
                default: goto L4a1;
            }
        L4a1:
            goto Le8a
        L4a5:
            r4 = r30
            goto Lfab
        L4ab:
            r19 = r18
            goto L7b0
        L4b1:
            r11 = r18
            goto L491
        L4b7:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeExtensionOrUnknownField(r0, r1, r2, r3, r4, r5, r6, r7)
            goto L7a0
        L4bf:
            r0 = r26
            goto L5db
        L4c5:
            int r0 = r0 + r1
            goto Lb05
        L4cb:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r6 = r9.unknownFieldSchema
            goto Ld8e
        L4d1:
            r9 = r0
            goto L1a0
        L4d6:
            r9 = r1
            goto Lf15
        L4db:
            r9.putobject(r8, r4, r6)
            goto Le44
        L4e2:
            long r5 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed64(r1, r14)
            goto L861
        L4ea:
            r13 = r0
            goto L58d
        L4ef:
            r18 = r11
            goto Lc64
        L4f5:
            r9 = r26
            goto L803
        L4fb:
            r0 = 21
            goto L1ae
        L502:
            r7 = r8
        L503:
            goto L61
        L507:
            if (r10 == r14) goto L50c
            goto L882
        L50c:
            goto L629
        L510:
            goto Ld02
        L512:
            goto Lc8f
        L516:
            goto L503
        L518:
            goto Lcb9
        L51c:
            r4 = r22
            goto L177
        L522:
            r5 = r27
            goto L562
        L528:
            r3 = r6
            goto Lae5
        L52d:
            goto L99a
        L530:
            goto L2ac
        L534:
            r2 = r1
            goto Lb5e
        L539:
            r9 = r8
            goto L364
        L53e:
            int r7 = r0.parseRepeatedField(r1, r2, r3, r4, r5, r6, r7, r8, r9, r11, r12, r14)
            goto L6a5
        L546:
            r0 = r13
            goto L207
        L54b:
            r14 = r32
            goto L15d
        L551:
            r1 = r25
            goto L119
        L557:
            goto L8c6
        L559:
            goto L4d1
        L55d:
            r8 = r3
            goto L8d2
        L562:
            r1 = r6
            goto L90e
        L567:
            r3 = r22
            goto Lfd0
        L56d:
            int r2 = r14 + 4
        L56f:
            goto L13e
        L573:
            r0 = r17
            goto L927
        L579:
            int r14 = r13 >>> 3
            goto L6af
        L57f:
            r3 = r19
            goto La46
        L585:
            androidx.datastore.preferences.protobuf.Schema r1 = r0.getMessageFieldSchema(r8)
            goto L762
        L58d:
            r8 = r2
            goto L268
        L592:
            r5 = r22
            goto L62f
        L598:
            goto L333
        L59a:
            goto L70f
        L59e:
            r7 = r30
            goto Le5a
        L5a4:
            r2 = r1
            goto L3af
        L5a9:
            r24 = r9
            goto Lfd6
        L5af:
            r13 = r3
            goto Lcc5
        L5b4:
            r9 = r32
            goto L20c
        L5ba:
            r1 = r28
            goto Lfb0
        L5c0:
            r4 = r22
            goto L832
        L5c6:
            r14 = r19
            goto L592
        L5cc:
            r3 = r14
            goto Lc77
        L5d1:
            r9 = r1
            goto L7da
        L5d6:
            r3 = r9
            goto Ld21
        L5db:
            r1 = r27
            goto Lab
        L5e1:
            r11 = r18
            goto Lf91
        L5e7:
            int r3 = r21 << 3
            goto L612
        L5ed:
            r5 = r30
            goto L8b5
        L5f3:
            r11 = r18
            goto Lf20
        L5f9:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r3 = (androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) r3
            goto Lb25
        L5ff:
            r4 = r22
            goto L263
        L605:
            long r3 = offset(r6)
            goto L480
        L60d:
            r11 = r5
            goto L904
        L612:
            r7 = r3 | 4
            goto Ld0c
        L618:
            r2 = r1
            goto L18a
        L61d:
            r4 = r30
        L61f:
            goto Ld6a
        L623:
            r17 = r10
            goto L546
        L629:
            r12 = r16
            goto L880
        L62f:
            r4 = 1
            goto La2c
        L634:
            r12 = r18
        L636:
            goto Le7f
        L63a:
            r2 = r13
            goto Lc17
        L63f:
            r8 = r6
            goto L320
        L644:
            r6 = r8
            goto L169
        L649:
            r4 = r30
            goto Ld74
        L64f:
            r3 = r2
            goto L428
        L654:
            r2 = r0[r10]
            goto L88c
        L65a:
            r11 = r5
            goto L5c6
        L65f:
            r8 = r32
            goto Lb59
        L665:
            r0.storeMessageField(r8, r11, r4)
            goto Lba8
        L66c:
            r5 = r22
            goto Lb1f
        L672:
            goto L73d
        L674:
            goto L6c1
        L678:
            r1.putlong(r2, r3, r5)
            goto Lbae
        L67f:
            r25 = r4
            goto Lfe4
        L685:
            if (r7 == r3) goto L68a
            goto L518
        L68a:
            goto Lc95
        L68e:
            r11 = r5
            goto L7d
        L693:
            r2 = r28
            goto Ldd9
        L699:
            int r20 = r2 << r20
            goto L41
        L69f:
            goto La42
        L6a1:
            goto La81
        L6a5:
            r13 = r5
            goto L22a
        L6aa:
            r9 = r3
            goto L354
        L6af:
            r7 = r13 & 7
            goto Lb9
        L6b5:
            r25 = r13
            goto L5af
        L6bb:
            r9 = r32
            goto Lb83
        L6c1:
            r8 = r32
            goto L88
        L6c7:
            if (r13 == r15) goto L6cc
            goto L6e9
        L6cc:
            goto L6e8
        L6d0:
            r9 = r0
            goto L359
        L6d5:
            r6 = r11
            goto L4b1
        L6da:
            int r3 = r7.int1
        L6dc:
            goto L6b5
        L6e0:
            int r7 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r9, r14, r8)
            goto Lce3
        L6e8:
            return r8
        L6e9:
            goto L38a
        L6ed:
            r3 = r9
            goto La62
        L6f2:
            r4 = r30
            goto L83
        L6f8:
            r3 = r19
            goto Lf1a
        L6fe:
            r9 = r2
            goto Lefe
        L703:
            r4.storeField(r13, r5)
            goto L9a4
        L70a:
            r6 = r11
            goto L195
        L70f:
            int[] r6 = r0.buffer
            goto L8a4
        L715:
            r7 = r2
            goto Lf48
        L71a:
            r8 = r28
            goto Lda0
        L720:
            r1 = r27
            goto La16
        L726:
            r3 = r22
            goto L837
        L72c:
            if (r7 == r2) goto L731
            goto L559
        L731:
            goto L1b5
        L735:
            r2 = 27
            goto Lf97
        L73b:
            r4 = r30
        L73d:
            goto L502
        L741:
            r9 = r0
            goto L758
        L746:
            r5 = r22
            goto L26
        L74c:
            r19 = r18
            goto Lfbe
        L752:
            r3 = r30
            goto L290
        L758:
            r8 = r3
        L759:
            goto L573
        L75d:
            r3 = r1
            goto Lecd
        L762:
            r2 = r9
            goto L247
        L767:
            goto L636
        L769:
            goto Lfa0
        L76d:
            bool r6 = r14.isInRange(r7)
            goto Lc00
        L775:
            r3 = r14
            goto L813
        L77a:
            r11 = r5
            goto L106
        L77f:
            r18 = r12
            goto Lfca
        L785:
            r8 = r17
            goto Lc9
        L78b:
            r2 = r8
            goto La51
        L790:
            r3 = r19
            goto L2cf
        L796:
            r13 = r10
            goto L94d
        L79b:
            r8 = r10
            goto Ld00
        L7a0:
            r6 = r4
            goto L59e
        L7a5:
            r22 = r5
            goto L4e2
        L7ab:
            r3 = r7
            goto L9e
        L7b0:
            r13 = r8
            goto Ld65
        L7b5:
            r3 = r19
            goto Ldd4
        L7bb:
            r11 = r5
        L7bc:
            goto L5d6
        L7c0:
            if (r5 == r11) goto L7c5
            goto L59a
        L7c5:
            goto Lb9a
        L7c9:
            r17 = r10
            goto L81d
        L7cf:
            r4 = r30
            goto L943
        L7d5:
            r6 = r4
            goto L225
        L7da:
            r1 = r8
            goto La92
        L7df:
            long r0 = (long) r0
            goto Lcf4
        L7e4:
            checkMutable(r1)
            goto Lc71
        L7eb:
            int r2 = r14 + 4
            goto L7fd
        L7f1:
            int r20 = r10 >>> 20
            goto Ldbe
        L7f7:
            goto Lbbe
        L7f9:
            goto Lbba
        L7fd:
            goto L8a0
        L7ff:
            goto L65f
        L803:
            r2 = r3
        L804:
            goto Lef9
        L808:
            r11 = r5
            goto Lc9d
        L80d:
            r2 = r28
            goto L405
        L813:
            r14 = r2
            goto Lf09
        L818:
            r2 = r9
            goto L348
        L81d:
            r3 = r14
            goto L74c
        L822:
            r9 = r4
        L823:
            goto L73b
        L827:
            r5 = r2
            goto Ld5
        L82c:
            goto Lbeb
        L82e:
            goto L952
        L832:
            r14 = 2
            goto L6bb
        L837:
            r9 = r28
            goto L3d6
        L83d:
            r1 = r27
            goto L80d
        L843:
            r25 = r9
            goto Le23
        L849:
            r9 = r28
            goto L735
        L84f:
            int r2 = r9.getInt(r1, r2)
            goto Lea0
        L857:
            r5 = r2
            goto Lfe9
        L85c:
            r3 = r2
            goto Lfb
        L861:
            r2 = r9
            goto La57
        L866:
            int r6 = r8.int1
            goto L124
        L86c:
            if (r8 == r7) goto L871
            goto L89a
        L871:
            goto L898
        L875:
            r2 = r1
            goto Lf0f
        L87a:
            r14 = r19
            goto Lf4d
        L880:
            goto Lb0c
        L882:
            goto L2c4
        L886:
            int r6 = r9.int1
            goto L337
        L88c:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r4 = r9.unknownFieldSchema
            goto L522
        L892:
            r3 = r19
            goto L5c0
        L898:
            goto L6cc
        L89a:
            goto Lee2
        L89e:
            int r2 = r14 + 8
        L8a0:
            goto L9c5
        L8a4:
            int r18 = r5 + 1
            goto La72
        L8aa:
            r1 = r2
            goto L40b
        L8af:
            r2 = r28
            goto Le4f
        L8b5:
            r7 = r32
            goto L63a
        L8bb:
            bool r6 = isEnforceUtf8(r6)
            goto Lf70
        L8c3:
            r8 = 1048575(0xfffff, float:1.469367E-39)
        L8c6:
            goto L14f
        L8ca:
            long r5 = androidx.datastore.preferences.protobuf.CodedStream.decodeZigZag64(r3)
            goto Le9b
        L8d2:
            goto Ld02
        L8d4:
            goto Lf8b
        L8d8:
            r12 = r4
            goto Lb94
        L8dd:
            int r13 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r3, r2, r13, r7)
            goto L6da
        L8e5:
            r14 = r17
            goto Lb0b
        L8eb:
            int r6 = r6 / r10
            goto L2fc
        L8f0:
            r19 = r11
            goto L295
        L8f6:
            r1 = r2
            goto L220
        L8fb:
            if (r11 <= r1) goto L900
            goto Le0f
        L900:
            goto L2b9
        L904:
            r2 = r9
            goto L892
        L909:
            r1 = 0
            goto L5c
        L90e:
            r0 = r9
            goto L10b
        L913:
            r11 = r5
            goto L790
        L918:
            r3 = r9
            goto L849
        L91d:
            r12 = r6
            goto Lc45
        L922:
            r9 = r2
            goto L78b
        L927:
            r14 = 1048575(0xfffff, float:1.469367E-39)
            goto Lccb
        L92e:
            if (r15 != 0) goto L933
            goto L26a
        L933:
            goto Ldab
        L937:
            bool r1 = r9.hasExtensions
            goto L9fd
        L93d:
            r3 = r22
            goto L678
        L943:
            r7 = r3
            goto L70a
        L948:
            r5 = r11
            goto Lf7f
        L94d:
            long r9 = (long) r6
            goto L54b
        L952:
            r1 = r6
            goto L190
        L957:
            r21 = r14
            goto Le54
        L95d:
            r2 = r7
            goto L331
        L962:
            goto L61f
        L964:
            goto L843
        L968:
            if (r7 == r2) goto L96d
            goto Laec
        L96d:
            goto Lc4a
        L971:
            throw r0
        L99a:
            goto L314
        L99e:
            r11 = r19
            goto L15
        L9a4:
            goto L24e
        L9a6:
            goto L377
        L9aa:
            r8 = r16
            goto L411
        L9b0:
            r3 = r30
            goto Ld7a
        L9b6:
            r11 = r19
            goto L3c2
        L9bc:
            if (r7 == 0) goto L9c1
            goto La53
        L9c1:
            goto Lc7d
        L9c5:
            r12 = r12 | r20
            goto L144
        L9cb:
            int r6 = r0.parseDictionaryField(r1, r2, r3, r4, r5, r6, r8)
            goto L31b
        L9d3:
            goto Lc5b
        L9d5:
            goto Lb31
        L9d9:
            goto Lf53
        L9db:
            goto Ld3c
        L9df:
            r21 = r14
            goto L87a
        L9e5:
            goto L559
        L9e7:
            goto Lcee
        L9eb:
            r1 = r28
            goto Lc0
        L9f1:
            r2 = r9
            goto L822
        L9f6:
            r3.putobject(r1, r4, r2)
        L9f9:
            goto L432
        L9fd:
            if (r1 != 0) goto La02
            goto Le5b
        La02:
            goto L77
        La06:
            r4 = r1
            goto Le90
        La0b:
            r9 = r11
            goto L1d5
        La10:
            r25 = r2
            goto L534
        La16:
            r2 = r28
            goto Lc3f
        La1c:
            if (r6 == 0) goto La21
            goto L9f9
        La21:
            goto Ld42
        La25:
            r0.setBuilderToMessage(r1, r3)
        La28:
            goto La38
        La2c:
            r1 = r28
            goto Ld27
        La32:
            r4 = r30
            goto L715
        La38:
            if (r15 == 0) goto La3d
            goto L17d
        La3d:
            goto L86c
        La41:
            r0 = r13
        La42:
            goto L201
        La46:
            r4 = r22
            goto L233
        La4c:
            r4 = r9
            goto L6fe
        La51:
            goto Lf53
        La53:
            goto Ledd
        La57:
            r9 = r1
            goto L8f6
        La5c:
            r18 = r12
            goto L741
        La62:
            r14 = r19
            goto L5ff
        La68:
            r8 = r1
            goto Laba
        La6d:
            r5 = r13
            goto L257
        La72:
            r6 = r6[r18]
            goto L4ef
        La78:
            if (r14 != 0) goto La7d
            goto L9a6
        La7d:
            goto L76d
        La81:
            r0 = r26
            goto Le07
        La87:
            goto L445
        La89:
            goto L443
        La8d:
            r2 = r6
            goto L50
        La92:
            r8 = r3
            goto L775
        La97:
            r2 = r28
            goto Laea
        La9d:
            if (r3 != 0) goto Laa2
            goto La28
        Laa2:
            goto Lddf
        Laa6:
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite r4 = getMutableUnknownFields(r6)
            goto Lcd4
        Laae:
            r14 = r19
            goto Lcda
        Lab4:
            r17 = r8
            goto Lbc2
        Laba:
            r11 = r5
            goto Lde5
        Labf:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeUnknownField(r0, r1, r2, r3, r4, r5)
            goto Le1e
        Lac7:
            if (r7 == r2) goto Lacc
            goto L559
        Lacc:
            goto L282
        Lad0:
            r14 = r19
            goto L726
        Lad6:
            r0 = r9
            goto L3a4
        Ladb:
            r2 = r9
            goto Lad0
        Lae0:
            r8 = r10
            goto Ld5a
        Lae5:
            r6 = r8
            goto L449
        Laea:
            goto L8c6
        Laec:
            goto L48c
        Laf0:
            if (r7 == 0) goto Laf5
            goto Ld02
        Laf5:
            goto L6e0
        Laf9:
            goto L333
        Lafb:
            goto Lfb9
        Laff:
            r6 = 0
            goto L163
        Lb05:
            int r0 = r0 % r1
            goto Le6b
        Lb0b:
            r10 = r8
        Lb0c:
            goto L49d
        Lb10:
            if (r3 < 0) goto Lb15
            goto L6dc
        Lb15:
            goto L8dd
        Lb19:
            r4 = r16
        Lb1b:
            goto L746
        Lb1f:
            r1 = r28
            goto Lef0
        Lb25:
            int r10 = r10 + 1
            goto L82c
        Lb2b:
            goto L8c6
        Lb2d:
            goto L95d
        Lb31:
            r8 = r28
            goto L808
        Lb37:
            r9.putInt(r1, r2, r12)
        Lb3a:
            goto L507
        Lb3e:
            r2 = r3
            goto L138
        Lb43:
            r0 = r26
            goto Lf
        Lb49:
            r2 = r9
            goto L4d6
        Lb4e:
            r3 = r1
            goto L8aa
        Lb53:
            r1 = r27
            goto L30e
        Lb59:
            r11 = r5
            goto L6ed
        Lb5e:
            r1 = r25
            goto L3fe
        Lb64:
            r9 = r2
            goto L2dd
        Lb69:
            r4 = r3
            goto L918
        Lb6e:
            r8 = r1
            goto L65a
        Lb73:
            r12 = r8
            goto La6d
        Lb78:
            r6 = 10
            goto La87
        Lb7e:
            r8 = r1
            goto L551
        Lb83:
            if (r7 == r14) goto Lb88
            goto La53
        Lb88:
            goto Ldff
        Lb8c:
            bool r6 = isLegacyEnumIsClosed(r6)
            goto Lff1
        Lb94:
            r4 = r30
            goto L827
        Lb9a:
            r2 = r3
            goto Lf03
        Lb9f:
            if (r7 == 0) goto Lba4
            goto La53
        Lba4:
            goto Lbdc
        Lba8:
            goto L56f
        Lbaa:
            goto Ld06
        Lbae:
            r25 = r2
            goto L875
        Lbb4:
            r4 = r30
            goto L75d
        Lbba:
            int r5 = r0.positionForFieldNumber(r14)
        Lbbe:
            goto L7c0
        Lbc2:
            r24 = r9
            goto La5c
        Lbc8:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodestring(r1, r2, r3)
        Lbcc:
            goto Lcf
        Lbd0:
            r4 = r30
            goto L423
        Lbd6:
            r3 = r32
            goto L19b
        Lbdc:
            int r3 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r8, r3, r9)
            goto L886
        Lbe4:
            java.lang.object r6 = r9.object1
            goto Lc58
        Lbea:
            r3 = r1
        Lbeb:
            goto Led7
        Lbef:
            r2 = r8
            goto L1e1
        Lbf4:
            r8 = r28
            goto L77a
        Lbfa:
            int r13 = r3 + 1
            goto L1e7
        Lc00:
            if (r6 != 0) goto Lc05
            goto L350
        Lc05:
            goto L34e
        Lc09:
            int r7 = r0.parseOneofField(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r12, r13)
            goto L6d0
        Lc11:
            goto L22
        Lc13:
            goto Le5f
        Lc17:
            r4 = r14
            goto L3ba
        Lc1c:
            r12 = r18
            goto L69f
        Lc22:
            androidx.datastore.preferences.protobuf.Internal$ProtobufList r2 = r2.mutableCopyWithCapacity(r6)
            goto L9f6
        Lc2a:
            r1 = r27
            goto La97
        Lc30:
            if (r10 < r0) goto Lc35
            goto L82e
        Lc35:
            goto Ldb
        Lc39:
            goto L52
        Lc3b:
            goto Ld89
        Lc3f:
            r4 = r30
            goto L158
        Lc45:
            r13 = r12
            goto L8c3
        Lc4a:
            java.lang.object r2 = r3.getobject(r1, r4)
            goto L2c9
        Lc52:
            r25 = r2
            goto L618
        Lc58:
            r2.putobject(r1, r4, r6)
        Lc5b:
            goto L24c
        Lc5f:
            r8 = r12
            goto L2f3
        Lc64:
            int r11 = type(r6)
            goto Ld30
        Lc6c:
            r11 = r5
            goto L43d
        Lc71:
            sun.misc.Unsafe r9 = androidx.datastore.preferences.protobuf.MessageSchema.UNSAFE
            goto L3e5
        Lc77:
            r1 = 49
            goto L8fb
        Lc7d:
            int r3 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint32(r8, r3, r9)
            goto L454
        Lc85:
            long r2 = (long) r8
            goto Lb37
        Lc8a:
            r13 = r2
            goto L2e2
        Lc8f:
            r8 = r28
            goto L3c8
        Lc95:
            java.lang.object r2 = r0.mutableMessageFieldForMerge(r1, r5)
            goto L5e7
        Lc9d:
            r2 = r9
            goto L57f
        Lca2:
            if (r6 == 0) goto Lca7
            goto La89
        Lca7:
            goto Lb78
        Lcab:
            r2 = r13
            goto L5cc
        Lcb0:
            if (r1 != r3) goto Lcb5
            goto Le5b
        Lcb5:
            goto Lfa5
        Lcb9:
            r11 = r5
            goto L37e
        Lcbe:
            r9.putInt(r8, r5, r2)
            goto L56d
        Lcc5:
            r3 = r25
            goto L579
        Lccb:
            if (r0 != r14) goto Lcd0
            goto L2b5
        Lcd0:
            goto L7df
        Lcd4:
            r1 = r28
            goto L9b0
        Lcda:
            r4 = r22
            goto Ld9a
        Lce0:
            goto Lf6c
        Lce3:
            long r5 = r8.long1
            goto La10
        Lce9:
            long r5 = (long) r7
            goto Ldeb
        Lcee:
            r3 = r32
            goto Lb6e
        Lcf4:
            r2 = r24
            goto L2b2
        Lcfa:
            goto Lbcc
        Lcfc:
            goto Lbc8
        Ld00:
            goto L8c6
        Ld02:
            goto L85c
        Ld06:
            r25 = r8
            goto Lb7e
        Ld0c:
            androidx.datastore.preferences.protobuf.Schema r3 = r0.getMessageFieldSchema(r5)
            goto L46f
        Ld14:
            r9 = r28
            goto L384
        Ld1a:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putdouble(r1, r4, r6)
            goto L89e
        Ld21:
            r14 = r19
            goto Ld14
        Ld27:
            if (r7 == r4) goto Ld2c
            goto L14b
        Ld2c:
            goto L7a5
        Ld30:
            r19 = r3
            goto L605
        Ld36:
            int r0 = r9.checkInitializedCount
            goto L909
        Ld3c:
            r25 = r9
            goto Ld60
        Ld42:
            int r6 = r2.Count
            goto Lca2
        Ld4a:
            r3 = r8
            goto L63f
        Ld4f:
            r7 = r13
            goto L785
        Ld54:
            r9 = r32
            goto Lb9f
        Ld5a:
            r11 = r18
            goto Lebc
        Ld60:
            r9 = r1
            goto L252
        Ld65:
            r8 = r11
            goto Laf9
        Ld6a:
            r7 = r9
            goto L215
        Ld6f:
            r2 = r9
            goto L7b5
        Ld74:
            r15 = r31
            goto Lea5
        Ld7a:
            r5 = r32
            goto Labf
        Ld80:
            if (r6 != r3) goto Ld85
            goto Lc13
        Ld85:
            goto Lb43
        Ld89:
            r9 = r3
            goto Lcab
        Ld8e:
            r4 = r27
            goto L1c3
        Ld94:
            r0 = r26
            goto L720
        Ld9a:
            r9 = r28
            goto L72c
        Lda0:
            r2 = r32
            goto L913
        Lda6:
            r7 = r4
            goto Lab4
        Ldab:
            r6 = r27
            goto L2e8
        Ldb1:
            r2 = 2
            goto L968
        Ldb6:
            int r7 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeVarint64(r8, r3, r2)
            goto Ldc9
        Ldbe:
            r2 = 1
            goto L699
        Ldc3:
            r17 = r13
            goto Le33
        Ldc9:
            long r3 = r2.long1
            goto L8ca
        Ldcf:
            r4 = r7
            goto L101
        Ldd4:
            r14 = 2
            goto L5b4
        Ldd9:
            r4 = r30
            goto L1c9
        Lddf:
            androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> r0 = r0.unknownFieldSchema
            goto La25
        Lde5:
            r2 = r19
            goto L66c
        Ldeb:
            java.lang.long r5 = java.lang.long.valueOf(r5)
            goto L703
        Ldf3:
            r22 = r3
            goto Lf26
        Ldf9:
            r6 = r21
            goto Lc09
        Ldff:
            int r3 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodebytes(r8, r3, r9)
            goto Lbe4
        Le07:
            r1 = r27
            goto L2d
        Le0d:
            goto L804
        Le0f:
            goto Lc8a
        Le13:
            r6 = r22
            goto Le95
        Le19:
            r3 = r5
            goto L672
        Le1e:
            r7 = r3
        Le1f:
            goto L66
        Le23:
            r9 = r2
            goto Lf79
        Le28:
            r11 = r5
            goto L4
        Le2d:
            r6 = r27
            goto Laa6
        Le33:
            r19 = r18
            goto L98
        Le39:
            r4 = r30
            goto Le19
        Le3f:
            r3 = r6
            goto L665
        Le44:
            goto L56f
        Le46:
            goto L6b
        Le4a:
            r3 = r2
            goto L5ed
        Le4f:
            r13 = r0
            goto L44f
        Le54:
            r14 = r17
            goto L371
        Le5a:
            goto Le1f
        Le5b:
            goto Le2d
        Le5f:
            r9 = r26
            goto La8d
        Le65:
            goto La53
        Le67:
            goto Lbf4
        Le6b:
            if (r0 <= 0) goto Le70
            goto L530
        Le70:
            goto L52d
        Le74:
            int[] r10 = r0.buffer
            goto L497
        Le7a:
            r14 = 2
            goto Le1
        Le7f:
            r11 = r19
            goto Lef
        Le85:
            r14 = r9
            goto L5d1
        Le8a:
            r8 = r32
            goto L7bb
        Le90:
            r1 = r3
            goto Le3f
        Le95:
            r8 = r32
            goto L9cb
        Le9b:
            r3 = r2
            goto L5a4
        Lea0:
            r12 = r2
            goto L47a
        Lea5:
            r7 = r32
            goto L7e4
        Leab:
            r11 = r5
            goto Ladb
        Leb0:
            r12 = r12 | r20
            goto L2ee
        Leb6:
            goto Lc5b
        Leb8:
            goto Leea
        Lebc:
            r5 = r21
            goto Lc2a
        Lec2:
            goto L56f
        Lec4:
            goto Le85
        Lec8:
            r14 = r3
            goto L510
        Lecd:
            r6 = r8
            goto Lae0
        Led2:
            r2 = r7
            goto Le0d
        Led7:
            int r0 = r9.repeatedFieldOffsetStart
            goto Lc30
        Ledd:
            r14 = r9
            goto L539
        Lee2:
            androidx.datastore.preferences.protobuf.InvalidProtocolBufferException r0 = androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.parseFailure()
            goto L17c
        Leea:
            r8 = r28
            goto L60d
        Lef0:
            if (r7 == 0) goto Lef5
            goto Lec4
        Lef5:
            goto La3
        Lef9:
            r0 = r13
            goto Lc1c
        Lefe:
            r2 = r4
            goto L149
        Lf03:
            r17 = r8
            goto L239
        Lf09:
            goto L559
        Lf0b:
            goto Lbd6
        Lf0f:
            r1 = r25
            goto L398
        Lf15:
            r1 = r8
            goto L55d
        Lf1a:
            r4 = r22
            goto Ld54
        Lf20:
            r5 = r21
            goto L6aa
        Lf26:
            r21 = r14
            goto L8e5
        Lf2c:
            if (r8 <= r7) goto Lf31
            goto L6e9
        Lf31:
            goto L6c7
        Lf35:
            r13 = r32
            goto L3aa
        Lf3b:
            r5 = r21
            goto L64f
        Lf41:
            androidx.datastore.preferences.protobuf.UnsafeUtil.putfloat(r1, r4, r2)
            goto L7eb
        Lf48:
            r2 = r8
            goto L516
        Lf4d:
            r8 = r5
            goto Lb69
        Lf52:
            r7 = r8
        Lf53:
            goto L79b
        Lf57:
            androidx.datastore.preferences.protobuf.ExtensionRegistryLite r3 = androidx.datastore.preferences.protobuf.ExtensionRegistryLite.getEmptyRegistry()
            goto Lcb0
        Lf5f:
            r3 = 3
            goto L685
        Lf64:
            r13 = r0
            goto L21
        Lf69:
            goto L317
        Lf6c:
            goto L4fb
        Lf70:
            if (r6 != 0) goto Lf75
            goto Lcfc
        Lf75:
            goto L369
        Lf79:
            r2 = r25
            goto Le65
        Lf7f:
            r6 = r16
            goto L91d
        Lf85:
            goto L8c6
        Lf87:
            goto L28a
        Lf8b:
            r8 = r32
            goto Leab
        Lf91:
            r5 = r21
            goto L922
        Lf97:
            if (r11 == r2) goto Lf9c
            goto Lc3b
        Lf9c:
            goto Ldb1
        Lfa0:
            r6 = r1
            goto Lda6
        Lfa5:
            androidx.datastore.preferences.protobuf.MessageLite r5 = r9.defaultInstance
            goto L4cb
        Lfab:
            r3 = r7
            goto L644
        Lfb0:
            if (r7 == r2) goto Lfb5
            goto L9db
        Lfb5:
            goto Lfdc
        Lfb9:
            r10 = r8
            goto L9df
        Lfbe:
            r18 = r12
            goto Lc39
        Lfc4:
            r7 = r32
            goto Lf85
        Lfca:
            r0 = 50
            goto L181
        Lfd0:
            r9 = r28
            goto Laf0
        Lfd6:
            r17 = r10
            goto La0b
        Lfdc:
            int r2 = androidx.datastore.preferences.protobuf.ArrayDecoders.decodeFixed32(r1, r14)
            goto Lcbe
        Lfe4:
            r4 = r2
            goto Lbef
        Lfe9:
            androidx.datastore.preferences.protobuf.Schema r2 = r0.getMessageFieldSchema(r11)
            goto L7d5
        Lff1:
            if (r6 != 0) goto Lff6
            goto L9a6
        Lff6:
            goto La78
    }

    @Override // androidx.datastore.preferences.protobuf.Schema
    public void WriteTo(T r3, androidx.datastore.preferences.protobuf.Writer r4) throws java.io.IOException {
            r2 = this;
            goto L4d
        L4:
            return
        L5:
            goto L39
        L9:
            r0 = 8
            goto L17
        L10:
            r2.writeFieldsInAscendingOrder(r3, r4)
            goto L4
        L17:
            r1 = 9
            goto L26
        L1e:
            return
        L1f:
            goto L10
        L23:
            goto L50
        L26:
            int r0 = r0 + r1
            goto L33
        L2c:
            r2.writeFieldsInDescendingOrder(r3, r4)
            goto L1e
        L33:
            int r0 = r0 % r1
            goto L65
        L39:
            goto L49
        L3c:
            goto L23
        L40:
            androidx.datastore.preferences.protobuf.Writer$FieldOrder r1 = androidx.datastore.preferences.protobuf.Writer.FieldOrder.DESCENDING
            goto L5c
        L46:
            goto L5
        L49:
            goto L54
        L4d:
            goto L3c
        L50:
            goto L9
        L54:
            androidx.datastore.preferences.protobuf.Writer$FieldOrder r0 = r4.fieldOrder()
            goto L40
        L5c:
            if (r0 == r1) goto L61
            goto L1f
        L61:
            goto L2c
        L65:
            if (r0 <= 0) goto L6a
            goto L49
        L6a:
            goto L46
    }
}

