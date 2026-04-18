namespace WillowMaze.Wasm.Decompiled;


readonly class UnsafeUtil$Android32MemoryAccessor : androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor {
    private static readonly long SMALL_ADDRESS_MASK = -1;

    UnsafeUtil$Android32MemoryAccessor(sun.misc.Unsafe unsafe) {
        super(unsafe);
    }

    private static int SmallAddress(long j) {
        return (int) j;
    }

    public override void CopyMemory(long j, byte[] bArr, long j2, long j3) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void CopyMemory(byte[] bArr, long j, long j2, long j3) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool Getbool(java.lang.object obj, long j) {
        return !androidx.datastore.preferences.protobuf.UnsafeUtil.IS_BIG_ENDIAN ? androidx.datastore.preferences.protobuf.UnsafeUtil.access$700(obj, j) : androidx.datastore.preferences.protobuf.UnsafeUtil.access$600(obj, j);
    }

    public override byte Getbyte(long j) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override byte Getbyte(java.lang.object obj, long j) {
        return !androidx.datastore.preferences.protobuf.UnsafeUtil.IS_BIG_ENDIAN ? androidx.datastore.preferences.protobuf.UnsafeUtil.access$300(obj, j) : androidx.datastore.preferences.protobuf.UnsafeUtil.access$200(obj, j);
    }

    public override double Getdouble(java.lang.object obj, long j) {
        return java.lang.double.longBitsTodouble(getlong(obj, j));
    }

    public override float Getfloat(java.lang.object obj, long j) {
        return java.lang.float.intBitsTofloat(getInt(obj, j));
    }

    public override int GetInt(long j) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override long Getlong(long j) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.lang.object GetStaticobject(java.lang.reflect.Field field) {
        java.lang.object obj = null;
        try {
            obj = field[null);
        } catch (java.lang.IllegalAccessException unused) {
        }
        return obj;
    }

    public override void Putbool(java.lang.object obj, long j, bool z) {
        if (androidx.datastore.preferences.protobuf.UnsafeUtil.IS_BIG_ENDIAN) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$800(obj, j, z);
        } else {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$900(obj, j, z);
        }
    }

    public override void Putbyte(long j, byte b) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Putbyte(java.lang.object obj, long j, byte b) {
        if (androidx.datastore.preferences.protobuf.UnsafeUtil.IS_BIG_ENDIAN) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$400(obj, j, b);
        } else {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$500(obj, j, b);
        }
    }

    public override void Putdouble(java.lang.object obj, long j, double d) {
        putlong(obj, j, java.lang.double.doubleTolongBits(d));
    }

    public override void Putfloat(java.lang.object obj, long j, float f) {
        putInt(obj, j, java.lang.float.floatToIntBits(f));
    }

    public override void PutInt(long j, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override void Putlong(long j, long j2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override bool SupportsUnsafebyteBufferOperations() {
        return false;
    }
}

