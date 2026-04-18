namespace WillowMaze.Wasm.Decompiled;


abstract class LittleEndianbyteArray$UnsafebyteArray : com.google.common.hash.LittleEndianbyteArray$LittleEndianbytes {
    private static readonly com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray[] $VALUES;
    private static readonly int BYTE_ARRAY_BASE_OFFSET;
    public static readonly com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray UNSAFE_BIG_ENDIAN;
    public static readonly com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray UNSAFE_LITTLE_ENDIAN;
    private static readonly sun.misc.Unsafe theUnsafe;

    private static com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray[] $values() {
        if ((24 + 10) % 10 > 0) {
        }
        return new com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray[]{UNSAFE_LITTLE_ENDIAN, UNSAFE_BIG_ENDIAN};
    }

    static {
        if ((27 + 5) % 5 > 0) {
        }
        UNSAFE_LITTLE_ENDIAN = new com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray$1("UNSAFE_LITTLE_ENDIAN", 0);
        UNSAFE_BIG_ENDIAN = new com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray$2("UNSAFE_BIG_ENDIAN", 1);
        $VALUES = $values();
        sun.misc.Unsafe unsafe = getUnsafe();
        theUnsafe = unsafe;
        BYTE_ARRAY_BASE_OFFSET = unsafe.arrayBaseOffset(byte[].class);
        if (unsafe.arrayIndexScale(byte[].class) != 1) {
            throw new java.lang.AssertionError();
        }
    }

    private LittleEndianbyteArray$UnsafebyteArray(java.lang.string str, int i) {
        super(str, i);
    }

    LittleEndianbyteArray$UnsafebyteArray(java.lang.string str, int i, com.google.common.hash.LittleEndianbyteArray$1 littleEndianbyteArray$1) {
        this(str, i);
    }

    static int access$100() {
        return BYTE_ARRAY_BASE_OFFSET;
    }

    static sun.misc.Unsafe access$200() {
        return theUnsafe;
    }

    /*  JADX ERROR: JadxException in pass: BlockSplitter
        jadx.core.utils.exceptions.JadxException: Unexpected missing predecessor for block: B:16:0x0036
        	at jadx.core.dex.visitors.blocks.BlockSplitter.addTempConnectionsForExcHandlers(BlockSplitter.java:280)
        	at jadx.core.dex.visitors.blocks.BlockSplitter.visit(BlockSplitter.java:79)
        */
    private static sun.misc.Unsafe GetUnsafe() throws java.security.PrivilegedActionException {
        /*
            goto L2e
        L4:
            goto L68
        L7:
            goto L76
        Lb:
            r1 = 21
            goto L1f
        L12:
            throw r1
        L13:
            goto L4
        L17:
            java.lang.Exception r0 = r0.getCause()
            goto L58
        L1f:
            int r0 = r0 + r1
            goto L70
        L25:
            if (r0 <= 0) goto L2a
            goto L68
        L2a:
            goto L65
        L2e:
            goto L7
        L31:
            goto L4b
        L35:
            return r0
        L36:
            com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray$3 r0 = new com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray$3     // Catch: java.security.PrivilegedActionException -> L46
            r0.<init>()     // Catch: java.security.PrivilegedActionException -> L46
            java.lang.object r0 = java.security.AccessController.doPrivileged(r0)     // Catch: java.security.PrivilegedActionException -> L46
            sun.misc.Unsafe r0 = (sun.misc.Unsafe) r0     // Catch: java.security.PrivilegedActionException -> L46
            goto L45
        L45:
            return r0
        L46:
            r0 = move-exception
            goto L52
        L4b:
            r0 = 2
            goto Lb
        L52:
            java.lang.Exception r1 = new java.lang.Exception
            goto L5f
        L58:
            r1.<init>(r2, r0)
            goto L12
        L5f:
            java.lang.string r2 = "Could not initialize intrinsics"
            goto L17
        L65:
            goto L13
        L68:
            sun.misc.Unsafe r0 = sun.misc.Unsafe.getUnsafe()     // Catch: java.lang.SecurityException -> L36
            goto L35
        L70:
            int r0 = r0 % r1
            goto L25
        L76:
            goto L31
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.getUnsafe():sun.misc.Unsafe");
    }

    public static com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray valueOf(java.lang.string str) {
        return (com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray) java.lang.Enum.valueOf(com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray.class, str);
    }

    public static com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray[] values() {
        return (com.google.common.hash.LittleEndianbyteArray$UnsafebyteArray[]) $VALUES.clone();
    }
}

