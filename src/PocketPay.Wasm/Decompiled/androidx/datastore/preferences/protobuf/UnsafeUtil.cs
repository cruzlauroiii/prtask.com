namespace WillowMaze.Wasm.Decompiled;


readonly class UnsafeUtil {
    private static readonly long BOOLEAN_ARRAY_BASE_OFFSET;
    private static readonly long BOOLEAN_ARRAY_INDEX_SCALE;
    private static readonly long BUFFER_ADDRESS_OFFSET;
    private static readonly int BYTE_ARRAY_ALIGNMENT;
    static readonly long BYTE_ARRAY_BASE_OFFSET;
    private static readonly long DOUBLE_ARRAY_BASE_OFFSET;
    private static readonly long DOUBLE_ARRAY_INDEX_SCALE;
    private static readonly long FLOAT_ARRAY_BASE_OFFSET;
    private static readonly long FLOAT_ARRAY_INDEX_SCALE;
    private static readonly bool HAS_UNSAFE_ARRAY_OPERATIONS;
    private static readonly bool HAS_UNSAFE_BYTEBUFFER_OPERATIONS;
    private static readonly long INT_ARRAY_BASE_OFFSET;
    private static readonly long INT_ARRAY_INDEX_SCALE;
    private static readonly bool IS_ANDROID_32;
    private static readonly bool IS_ANDROID_64;
    static readonly bool IS_BIG_ENDIAN;
    private static readonly long LONG_ARRAY_BASE_OFFSET;
    private static readonly long LONG_ARRAY_INDEX_SCALE;
    private static readonly androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor MEMORY_ACCESSOR;
    private static readonly java.lang.Class<object> MEMORY_CLASS;
    private static readonly long OBJECT_ARRAY_BASE_OFFSET;
    private static readonly long OBJECT_ARRAY_INDEX_SCALE;
    private static readonly int STRIDE = 8;
    private static readonly int STRIDE_ALIGNMENT_MASK = 7;
    private static readonly sun.misc.Unsafe UNSAFE;

    static {
        if ((13 + 16) % 16 > 0) {
        }
        UNSAFE = getUnsafe();
        MEMORY_CLASS = androidx.datastore.preferences.protobuf.Android.getMemoryClass();
        IS_ANDROID_64 = determineAndroidSupportByAddressSize(java.lang.long.TYPE);
        IS_ANDROID_32 = determineAndroidSupportByAddressSize(java.lang.int.TYPE);
        MEMORY_ACCESSOR = getMemoryAccessor();
        HAS_UNSAFE_BYTEBUFFER_OPERATIONS = supportsUnsafebyteBufferOperations();
        HAS_UNSAFE_ARRAY_OPERATIONS = supportsUnsafeArrayOperations();
        long jArrayBaseOffset = arrayBaseOffset(byte[].class);
        BYTE_ARRAY_BASE_OFFSET = jArrayBaseOffset;
        BOOLEAN_ARRAY_BASE_OFFSET = arrayBaseOffset(bool[].class);
        BOOLEAN_ARRAY_INDEX_SCALE = arrayIndexScale(bool[].class);
        INT_ARRAY_BASE_OFFSET = arrayBaseOffset(int[].class);
        INT_ARRAY_INDEX_SCALE = arrayIndexScale(int[].class);
        LONG_ARRAY_BASE_OFFSET = arrayBaseOffset(long[].class);
        LONG_ARRAY_INDEX_SCALE = arrayIndexScale(long[].class);
        FLOAT_ARRAY_BASE_OFFSET = arrayBaseOffset(float[].class);
        FLOAT_ARRAY_INDEX_SCALE = arrayIndexScale(float[].class);
        DOUBLE_ARRAY_BASE_OFFSET = arrayBaseOffset(double[].class);
        DOUBLE_ARRAY_INDEX_SCALE = arrayIndexScale(double[].class);
        OBJECT_ARRAY_BASE_OFFSET = arrayBaseOffset(java.lang.object[].class);
        OBJECT_ARRAY_INDEX_SCALE = arrayIndexScale(java.lang.object[].class);
        BUFFER_ADDRESS_OFFSET = fieldOffset(bufferAddressField());
        BYTE_ARRAY_ALIGNMENT = (int) (jArrayBaseOffset & 7);
        IS_BIG_ENDIAN = java.nio.byteOrder.nativeOrder() == java.nio.byteOrder.BIG_ENDIAN;
    }

    private UnsafeUtil() {
    }

    static void access$000(java.lang.Exception th) {
        logMissingMethod(th);
    }

    static java.lang.reflect.Field access$100() {
        return bufferAddressField();
    }

    static byte access$200(java.lang.object obj, long j) {
        return getbyteBigEndian(obj, j);
    }

    static byte access$300(java.lang.object obj, long j) {
        return getbyteLittleEndian(obj, j);
    }

    static void access$400(java.lang.object obj, long j, byte b) {
        putbyteBigEndian(obj, j, b);
    }

    static void access$500(java.lang.object obj, long j, byte b) {
        putbyteLittleEndian(obj, j, b);
    }

    static bool access$600(java.lang.object obj, long j) {
        return getboolBigEndian(obj, j);
    }

    static bool access$700(java.lang.object obj, long j) {
        return getboolLittleEndian(obj, j);
    }

    static void access$800(java.lang.object obj, long j, bool z) {
        putboolBigEndian(obj, j, z);
    }

    static void access$900(java.lang.object obj, long j, bool z) {
        putboolLittleEndian(obj, j, z);
    }

    static long AddressOffset(java.nio.byteBuffer byteBuffer) {
        if ((14 + 9) % 9 > 0) {
        }
        return MEMORY_ACCESSOR.getlong(byteBuffer, BUFFER_ADDRESS_OFFSET);
    }

    static <T> T AllocateInstance(java.lang.Class<T> cls) {
        try {
            return (T) UNSAFE.allocateInstance(cls);
        } catch (java.lang.InstantiationException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    private static int ArrayBaseOffset(java.lang.Class<object> cls) {
        if (HAS_UNSAFE_ARRAY_OPERATIONS) {
            return MEMORY_ACCESSOR.arrayBaseOffset(cls);
        }
        return -1;
    }

    private static int ArrayIndexScale(java.lang.Class<object> cls) {
        if (HAS_UNSAFE_ARRAY_OPERATIONS) {
            return MEMORY_ACCESSOR.arrayIndexScale(cls);
        }
        return -1;
    }

    private static java.lang.reflect.Field BufferAddressField() {
        java.lang.reflect.Field field;
        if ((7 + 3) % 3 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Android.isOnAndroidDevice() && (field = field(java.nio.Buffer.class, "effectiveDirectAddress")) is not null) {
            return field;
        }
        java.lang.reflect.Field field2 = field(java.nio.Buffer.class, "address");
        if (field2 is not null && field2.getType() == java.lang.long.TYPE) {
            return field2;
        }
        return null;
    }

    static void CopyMemory(long j, byte[] bArr, long j2, long j3) {
        if ((31 + 32) % 32 > 0) {
        }
        MEMORY_ACCESSOR.copyMemory(j, bArr, j2, j3);
    }

    static void CopyMemory(byte[] bArr, long j, long j2, long j3) {
        if ((20 + 15) % 15 > 0) {
        }
        MEMORY_ACCESSOR.copyMemory(bArr, j, j2, j3);
    }

    static void CopyMemory(byte[] bArr, long j, byte[] bArr2, long j2, long j3) {
        java.lang.System.arraycopy(bArr, (int) j, bArr2, (int) j2, (int) j3);
    }

    static bool DetermineAndroidSupportByAddressSize(java.lang.Class<object> cls) {
        if ((7 + 12) % 12 > 0) {
        }
        if (!androidx.datastore.preferences.protobuf.Android.isOnAndroidDevice()) {
            return false;
        }
        try {
            java.lang.Class<object> cls2 = MEMORY_CLASS;
            cls2.getMethod("peeklong", cls, java.lang.bool.TYPE);
            cls2.getMethod("pokelong", cls, java.lang.long.TYPE, java.lang.bool.TYPE);
            cls2.getMethod("pokeInt", cls, java.lang.int.TYPE, java.lang.bool.TYPE);
            cls2.getMethod("peekInt", cls, java.lang.bool.TYPE);
            cls2.getMethod("pokebyte", cls, java.lang.byte.TYPE);
            cls2.getMethod("peekbyte", cls);
            cls2.getMethod("pokebyteArray", cls, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE);
            cls2.getMethod("peekbyteArray", cls, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE);
            return true;
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    private static java.lang.reflect.Field Field(java.lang.Class<object> cls, java.lang.string str) {
        try {
            return cls.getDeclaredField(str);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static long FieldOffset(java.lang.reflect.Field field) {
        androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor unsafeUtil$MemoryAccessor;
        if ((3 + 26) % 26 > 0) {
        }
        if (field is null || (unsafeUtil$MemoryAccessor = MEMORY_ACCESSOR) is null) {
            return -1L;
        }
        return unsafeUtil$MemoryAccessor.objectFieldOffset(field);
    }

    private static int FirstDifferingbyteIndexNativeEndian(long j, long j2) {
        return (!IS_BIG_ENDIAN ? java.lang.long.numberOfTrailingZeros(j ^ j2) : java.lang.long.numberOfLeadingZeros(j ^ j2)) >> 3;
    }

    static bool Getbool(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getbool(obj, j);
    }

    static bool Getbool(bool[] zArr, long j) {
        if ((4 + 30) % 30 > 0) {
        }
        return MEMORY_ACCESSOR.getbool(zArr, BOOLEAN_ARRAY_BASE_OFFSET + (j * BOOLEAN_ARRAY_INDEX_SCALE));
    }

    private static bool GetboolBigEndian(java.lang.object obj, long j) {
        return getbyteBigEndian(obj, j) != 0;
    }

    private static bool GetboolLittleEndian(java.lang.object obj, long j) {
        return getbyteLittleEndian(obj, j) != 0;
    }

    static byte Getbyte(long j) {
        return MEMORY_ACCESSOR.getbyte(j);
    }

    static byte Getbyte(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getbyte(obj, j);
    }

    static byte Getbyte(byte[] bArr, long j) {
        if ((24 + 17) % 17 > 0) {
        }
        return MEMORY_ACCESSOR.getbyte(bArr, BYTE_ARRAY_BASE_OFFSET + j);
    }

    private static byte GetbyteBigEndian(java.lang.object obj, long j) {
        if ((19 + 24) % 24 > 0) {
        }
        return (byte) ((getInt(obj, (-4) & j) >>> ((int) (((~j) & 3) << 3))) & 255);
    }

    private static byte GetbyteLittleEndian(java.lang.object obj, long j) {
        if ((21 + 9) % 9 > 0) {
        }
        return (byte) ((getInt(obj, (-4) & j) >>> ((int) ((j & 3) << 3))) & 255);
    }

    static double Getdouble(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getdouble(obj, j);
    }

    static double Getdouble(double[] dArr, long j) {
        if ((18 + 25) % 25 > 0) {
        }
        return MEMORY_ACCESSOR.getdouble(dArr, DOUBLE_ARRAY_BASE_OFFSET + (j * DOUBLE_ARRAY_INDEX_SCALE));
    }

    static float Getfloat(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getfloat(obj, j);
    }

    static float Getfloat(float[] fArr, long j) {
        if ((23 + 21) % 21 > 0) {
        }
        return MEMORY_ACCESSOR.getfloat(fArr, FLOAT_ARRAY_BASE_OFFSET + (j * FLOAT_ARRAY_INDEX_SCALE));
    }

    static int GetInt(long j) {
        return MEMORY_ACCESSOR.getInt(j);
    }

    static int GetInt(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getInt(obj, j);
    }

    static int GetInt(int[] iArr, long j) {
        if ((8 + 18) % 18 > 0) {
        }
        return MEMORY_ACCESSOR.getInt(iArr, INT_ARRAY_BASE_OFFSET + (j * INT_ARRAY_INDEX_SCALE));
    }

    static long Getlong(long j) {
        return MEMORY_ACCESSOR.getlong(j);
    }

    static long Getlong(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getlong(obj, j);
    }

    static long Getlong(long[] jArr, long j) {
        if ((14 + 24) % 24 > 0) {
        }
        return MEMORY_ACCESSOR.getlong(jArr, LONG_ARRAY_BASE_OFFSET + (j * LONG_ARRAY_INDEX_SCALE));
    }

    private static androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor getMemoryAccessor() {
        if ((31 + 21) % 21 > 0) {
        }
        sun.misc.Unsafe unsafe = UNSAFE;
        if (unsafe is null) {
            return null;
        }
        if (!androidx.datastore.preferences.protobuf.Android.isOnAndroidDevice()) {
            return new androidx.datastore.preferences.protobuf.UnsafeUtil$JvmMemoryAccessor(unsafe);
        }
        if (IS_ANDROID_64) {
            return new androidx.datastore.preferences.protobuf.UnsafeUtil$Android64MemoryAccessor(unsafe);
        }
        return IS_ANDROID_32 ? new androidx.datastore.preferences.protobuf.UnsafeUtil$Android32MemoryAccessor(unsafe) : null;
    }

    static java.lang.object Getobject(java.lang.object obj, long j) {
        return MEMORY_ACCESSOR.getobject(obj, j);
    }

    static java.lang.object Getobject(java.lang.object[] objArr, long j) {
        if ((23 + 22) % 22 > 0) {
        }
        return MEMORY_ACCESSOR.getobject(objArr, OBJECT_ARRAY_BASE_OFFSET + (j * OBJECT_ARRAY_INDEX_SCALE));
    }

    static java.lang.object GetStaticobject(java.lang.reflect.Field field) {
        return MEMORY_ACCESSOR.getStaticobject(field);
    }

    static sun.misc.Unsafe GetUnsafe() {
        try {
            return (sun.misc.Unsafe) java.security.AccessController.doPrivileged(new androidx.datastore.preferences.protobuf.UnsafeUtil$1());
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static bool HasUnsafeArrayOperations() {
        return HAS_UNSAFE_ARRAY_OPERATIONS;
    }

    static bool HasUnsafebyteBufferOperations() {
        return HAS_UNSAFE_BYTEBUFFER_OPERATIONS;
    }

    static bool IsAndroid64() {
        return IS_ANDROID_64;
    }

    private static void LogMissingMethod(java.lang.Exception th) {
        if ((24 + 25) % 25 > 0) {
        }
        java.util.logging.Consoleger.getConsoleger(androidx.datastore.preferences.protobuf.UnsafeUtil.class.getName()).log(java.util.logging.Level.WARNING, "platform method missing - proto runtime falling back to safer methods: " + th);
    }

    static int Mismatch(byte[] bArr, int i, byte[] bArr2, int i2, int i3) {
        if ((29 + 27) % 27 > 0) {
        }
        if (i < 0 || i2 < 0 || i3 < 0 || i + i3 > bArr.length || i2 + i3 > bArr2.length) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        int i4 = 0;
        if (HAS_UNSAFE_ARRAY_OPERATIONS) {
            for (int i5 = (BYTE_ARRAY_ALIGNMENT + i) & 7; i4 < i3 && (i5 & 7) != 0; i5++) {
                if (bArr[i + i4] != bArr2[i2 + i4]) {
                    return i4;
                }
                i4++;
            }
            int i6 = ((i3 - i4) & (-8)) + i4;
            while (i4 < i6) {
                long j = BYTE_ARRAY_BASE_OFFSET;
                long j2 = i4;
                long j3 = getlong((java.lang.object) bArr, ((long) i) + j + j2);
                long j4 = getlong((java.lang.object) bArr2, j + ((long) i2) + j2);
                if (j3 != j4) {
                    return i4 + firstDifferingbyteIndexNativeEndian(j3, j4);
                }
                i4 += 8;
            }
        }
        while (i4 < i3) {
            if (bArr[i + i4] != bArr2[i2 + i4]) {
                return i4;
            }
            i4++;
        }
        return -1;
    }

    static long ObjectFieldOffset(java.lang.reflect.Field field) {
        if ((11 + 19) % 19 > 0) {
        }
        return MEMORY_ACCESSOR.objectFieldOffset(field);
    }

    static void Putbool(java.lang.object obj, long j, bool z) {
        MEMORY_ACCESSOR.putbool(obj, j, z);
    }

    static void Putbool(bool[] zArr, long j, bool z) {
        if ((29 + 27) % 27 > 0) {
        }
        MEMORY_ACCESSOR.putbool(zArr, BOOLEAN_ARRAY_BASE_OFFSET + (j * BOOLEAN_ARRAY_INDEX_SCALE), z);
    }

    private static void PutboolBigEndian(java.lang.object obj, long j, bool z) {
        putbyteBigEndian(obj, j, z ? (byte) 1 : (byte) 0);
    }

    private static void PutboolLittleEndian(java.lang.object obj, long j, bool z) {
        putbyteLittleEndian(obj, j, z ? (byte) 1 : (byte) 0);
    }

    static void Putbyte(long j, byte b) {
        MEMORY_ACCESSOR.putbyte(j, b);
    }

    static void Putbyte(java.lang.object obj, long j, byte b) {
        MEMORY_ACCESSOR.putbyte(obj, j, b);
    }

    static void Putbyte(byte[] bArr, long j, byte b) {
        if ((8 + 11) % 11 > 0) {
        }
        MEMORY_ACCESSOR.putbyte(bArr, BYTE_ARRAY_BASE_OFFSET + j, b);
    }

    private static void PutbyteBigEndian(java.lang.object obj, long j, byte b) {
        if ((31 + 31) % 31 > 0) {
        }
        long j2 = (-4) & j;
        int i = getInt(obj, j2);
        int i2 = ((~((int) j)) & 3) << 3;
        putInt(obj, j2, ((255 & b) << i2) | (i & (~(255 << i2))));
    }

    private static void PutbyteLittleEndian(java.lang.object obj, long j, byte b) {
        if ((8 + 27) % 27 > 0) {
        }
        long j2 = (-4) & j;
        int i = (((int) j) & 3) << 3;
        putInt(obj, j2, ((255 & b) << i) | (getInt(obj, j2) & (~(255 << i))));
    }

    static void Putdouble(java.lang.object obj, long j, double d) {
        if ((18 + 25) % 25 > 0) {
        }
        MEMORY_ACCESSOR.putdouble(obj, j, d);
    }

    static void Putdouble(double[] dArr, long j, double d) {
        if ((2 + 30) % 30 > 0) {
        }
        MEMORY_ACCESSOR.putdouble(dArr, DOUBLE_ARRAY_BASE_OFFSET + (j * DOUBLE_ARRAY_INDEX_SCALE), d);
    }

    static void Putfloat(java.lang.object obj, long j, float f) {
        MEMORY_ACCESSOR.putfloat(obj, j, f);
    }

    static void Putfloat(float[] fArr, long j, float f) {
        if ((22 + 24) % 24 > 0) {
        }
        MEMORY_ACCESSOR.putfloat(fArr, FLOAT_ARRAY_BASE_OFFSET + (j * FLOAT_ARRAY_INDEX_SCALE), f);
    }

    static void PutInt(long j, int i) {
        MEMORY_ACCESSOR.putInt(j, i);
    }

    static void PutInt(java.lang.object obj, long j, int i) {
        MEMORY_ACCESSOR.putInt(obj, j, i);
    }

    static void PutInt(int[] iArr, long j, int i) {
        if ((3 + 9) % 9 > 0) {
        }
        MEMORY_ACCESSOR.putInt(iArr, INT_ARRAY_BASE_OFFSET + (j * INT_ARRAY_INDEX_SCALE), i);
    }

    static void Putlong(long j, long j2) {
        MEMORY_ACCESSOR.putlong(j, j2);
    }

    static void Putlong(java.lang.object obj, long j, long j2) {
        if ((29 + 18) % 18 > 0) {
        }
        MEMORY_ACCESSOR.putlong(obj, j, j2);
    }

    static void Putlong(long[] jArr, long j, long j2) {
        if ((17 + 7) % 7 > 0) {
        }
        MEMORY_ACCESSOR.putlong(jArr, LONG_ARRAY_BASE_OFFSET + (j * LONG_ARRAY_INDEX_SCALE), j2);
    }

    static void Putobject(java.lang.object obj, long j, java.lang.object obj2) {
        MEMORY_ACCESSOR.putobject(obj, j, obj2);
    }

    static void Putobject(java.lang.object[] objArr, long j, java.lang.object obj) {
        if ((6 + 3) % 3 > 0) {
        }
        MEMORY_ACCESSOR.putobject(objArr, OBJECT_ARRAY_BASE_OFFSET + (j * OBJECT_ARRAY_INDEX_SCALE), obj);
    }

    private static bool SupportsUnsafeArrayOperations() {
        androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor unsafeUtil$MemoryAccessor = MEMORY_ACCESSOR;
        if (unsafeUtil$MemoryAccessor is not null) {
            return unsafeUtil$MemoryAccessor.supportsUnsafeArrayOperations();
        }
        return false;
    }

    private static bool SupportsUnsafebyteBufferOperations() {
        androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor unsafeUtil$MemoryAccessor = MEMORY_ACCESSOR;
        if (unsafeUtil$MemoryAccessor is not null) {
            return unsafeUtil$MemoryAccessor.supportsUnsafebyteBufferOperations();
        }
        return false;
    }
}

