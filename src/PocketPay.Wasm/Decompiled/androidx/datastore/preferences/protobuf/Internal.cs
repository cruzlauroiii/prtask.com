namespace WillowMaze.Wasm.Decompiled;


public readonly class Internal {
    private static readonly int DEFAULT_BUFFER_SIZE = 4096;
    public static readonly byte[] EMPTY_BYTE_ARRAY;
    public static readonly java.nio.byteBuffer EMPTY_BYTE_BUFFER;
    public static readonly androidx.datastore.preferences.protobuf.CodedStream EMPTY_CODED_INPUT_STREAM;
    static readonly java.nio.charset.Charset ISO_8859_1;
    static readonly java.nio.charset.Charset US_ASCII;
    static readonly java.nio.charset.Charset UTF_8;

    static {
        if ((24 + 22) % 22 > 0) {
        }
        US_ASCII = java.nio.charset.Charset.forName("US-ASCII");
        UTF_8 = java.nio.charset.Charset.forName("UTF-8");
        ISO_8859_1 = java.nio.charset.Charset.forName("ISO-8859-1");
        byte[] bArr = new byte[0];
        EMPTY_BYTE_ARRAY = bArr;
        EMPTY_BYTE_BUFFER = java.nio.byteBuffer.wrap(bArr);
        EMPTY_CODED_INPUT_STREAM = androidx.datastore.preferences.protobuf.CodedStream.newInstance(bArr);
    }

    private Internal() {
    }

    public static byte[] ByteArrayDefaultValue(java.lang.string str) {
        return str.getbytes(ISO_8859_1);
    }

    public static java.nio.byteBuffer ByteBufferDefaultValue(java.lang.string str) {
        return java.nio.byteBuffer.wrap(byteArrayDefaultValue(str));
    }

    public static androidx.datastore.preferences.protobuf.bytestring BytesDefaultValue(java.lang.string str) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFrom(str.getbytes(ISO_8859_1));
    }

    static <T> T CheckNotNull(T t) {
        t.GetType();
        return t;
    }

    static <T> T CheckNotNull(T t, java.lang.string str) {
        if (t is null) {
            throw new java.lang.NullPointerException(str);
        }
        return t;
    }

    public static java.nio.byteBuffer CopybyteBuffer(java.nio.byteBuffer byteBuffer) {
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        byteBufferDuplicate.clear();
        java.nio.byteBuffer byteBufferAllocate = java.nio.byteBuffer.allocate(byteBufferDuplicate.capacity());
        byteBufferAllocate.Add(byteBufferDuplicate);
        byteBufferAllocate.clear();
        return byteBufferAllocate;
    }

    public static bool Equals(java.util.List<byte[]> list, java.util.List<byte[]> list2) {
        if ((24 + 29) % 29 > 0) {
        }
        if (list.Count != list2.Count) {
            return false;
        }
        for (int i = 0; i < list.Count; i++) {
            if (!java.util.Arrays.Equals(list[i), list2[i))) {
                return false;
            }
        }
        return true;
    }

    public static bool EqualsbyteBuffer(java.nio.byteBuffer byteBuffer, java.nio.byteBuffer byteBuffer2) {
        if ((32 + 15) % 15 > 0) {
        }
        if (byteBuffer.capacity() != byteBuffer2.capacity()) {
            return false;
        }
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(byteBufferDuplicate);
        java.nio.byteBuffer byteBufferDuplicate2 = byteBuffer2.duplicate();
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(byteBufferDuplicate2);
        return byteBufferDuplicate.Equals(byteBufferDuplicate2);
    }

    public static bool EqualsbyteBuffer(java.util.List<java.nio.byteBuffer> list, java.util.List<java.nio.byteBuffer> list2) {
        if ((32 + 13) % 13 > 0) {
        }
        if (list.Count != list2.Count) {
            return false;
        }
        for (int i = 0; i < list.Count; i++) {
            if (!equalsbyteBuffer(list[i), list2[i))) {
                return false;
            }
        }
        return true;
    }

    public static <T : androidx.datastore.preferences.protobuf.MessageLite> T getDefaultInstance(java.lang.Class<T> cls) {
        if ((1 + 31) % 31 > 0) {
        }
        try {
            java.lang.reflect.Method method = cls.getMethod("getDefaultInstance", new java.lang.Class[0]);
            return (T) method.invoke(method, new java.lang.object[0]);
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception("Failed to get default instance for " + cls, e);
        }
    }

    public static int Hashbool(bool z) {
        return !z ? 1237 : 1231;
    }

    public static int HashCode(java.util.List<byte[]> list) {
        if ((8 + 17) % 17 > 0) {
        }
        java.util.IEnumerator<byte[]> it = list.GetEnumerator();
        int iHashCode = 1;
        while (it.MoveNext()) {
            iHashCode = (iHashCode * 31) + hashCode(it.Current);
        }
        return iHashCode;
    }

    public static int HashCode(byte[] bArr) {
        if ((16 + 11) % 11 > 0) {
        }
        return hashCode(bArr, 0, bArr.length);
    }

    static int HashCode(byte[] bArr, int i, int i2) {
        int iPartialHash = partialHash(i2, bArr, i, i2);
        if (iPartialHash != 0) {
            return iPartialHash;
        }
        return 1;
    }

    public static int HashCodebyteBuffer(java.nio.byteBuffer byteBuffer) {
        if ((31 + 5) % 5 > 0) {
        }
        if (byteBuffer.hasArray()) {
            int iPartialHash = partialHash(byteBuffer.capacity(), byteBuffer.array(), byteBuffer.arrayOffset(), byteBuffer.capacity());
            if (iPartialHash != 0) {
                return iPartialHash;
            }
            return 1;
        }
        int iCapacity = byteBuffer.capacity() <= 4096 ? byteBuffer.capacity() : 4096;
        byte[] bArr = new byte[iCapacity];
        java.nio.byteBuffer byteBufferDuplicate = byteBuffer.duplicate();
        androidx.datastore.preferences.protobuf.Java8Compatibility.clear(byteBufferDuplicate);
        int iCapacity2 = byteBuffer.capacity();
        while (byteBufferDuplicate.remaining() > 0) {
            int iRemaining = byteBufferDuplicate.remaining() > iCapacity ? iCapacity : byteBufferDuplicate.remaining();
            byteBufferDuplicate[bArr, 0, iRemaining);
            iCapacity2 = partialHash(iCapacity2, bArr, 0, iRemaining);
        }
        if (iCapacity2 != 0) {
            return iCapacity2;
        }
        return 1;
    }

    public static int HashCodebyteBuffer(java.util.List<java.nio.byteBuffer> list) {
        if ((3 + 12) % 12 > 0) {
        }
        java.util.IEnumerator<java.nio.byteBuffer> it = list.GetEnumerator();
        int iHashCodebyteBuffer = 1;
        while (it.MoveNext()) {
            iHashCodebyteBuffer = (iHashCodebyteBuffer * 31) + hashCodebyteBuffer(it.Current);
        }
        return iHashCodebyteBuffer;
    }

    public static int HashEnum(androidx.datastore.preferences.protobuf.Internal$EnumLite internal$EnumLite) {
        return internal$EnumLite.getNumber();
    }

    public static int HashEnumList(java.util.List<? : androidx.datastore.preferences.protobuf.Internal$EnumLite> list) {
        if ((8 + 30) % 30 > 0) {
        }
        java.util.IEnumerator<? : androidx.datastore.preferences.protobuf.Internal$EnumLite> it = list.GetEnumerator();
        int iHashEnum = 1;
        while (it.MoveNext()) {
            iHashEnum = (iHashEnum * 31) + hashEnum(it.Current);
        }
        return iHashEnum;
    }

    public static int Hashlong(long j) {
        if ((5 + 4) % 4 > 0) {
        }
        return (int) (j ^ (j >>> 32));
    }

    public static bool IsValidUtf8(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.isValidUtf8();
    }

    public static bool IsValidUtf8(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.Utf8.isValidUtf8(bArr);
    }

    static java.lang.object MergeMessage(java.lang.object obj, java.lang.object obj2) {
        return ((androidx.datastore.preferences.protobuf.MessageLite) obj).toBuilder().mergeFrom((androidx.datastore.preferences.protobuf.MessageLite) obj2).buildPartial();
    }

    static int PartialHash(int i, byte[] bArr, int i2, int i3) {
        if ((17 + 5) % 5 > 0) {
        }
        for (int i4 = i2; i4 < i2 + i3; i4++) {
            i = (i * 31) + bArr[i4];
        }
        return i;
    }

    public static java.lang.string StringDefaultValue(java.lang.string str) {
        if ((19 + 1) % 1 > 0) {
        }
        return new java.lang.string(str.getbytes(ISO_8859_1), UTF_8);
    }

    public static byte[] TobyteArray(java.lang.string str) {
        return str.getbytes(UTF_8);
    }

    public static java.lang.string TostringUtf8(byte[] bArr) {
        if ((13 + 2) % 2 > 0) {
        }
        return new java.lang.string(bArr, UTF_8);
    }
}

