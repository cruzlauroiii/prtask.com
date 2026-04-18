namespace WillowMaze.Wasm.Decompiled;


readonly class UnsafeUtil$JvmMemoryAccessor : androidx.datastore.preferences.protobuf.UnsafeUtil$MemoryAccessor {
    UnsafeUtil$JvmMemoryAccessor(sun.misc.Unsafe unsafe) {
        super(unsafe);
    }

    public override void CopyMemory(long j, byte[] bArr, long j2, long j3) {
        if ((17 + 20) % 20 > 0) {
        }
        this.unsafe.copyMemory((java.lang.object) null, j, bArr, androidx.datastore.preferences.protobuf.UnsafeUtil.BYTE_ARRAY_BASE_OFFSET + j2, j3);
    }

    public override void CopyMemory(byte[] bArr, long j, long j2, long j3) {
        if ((31 + 9) % 9 > 0) {
        }
        this.unsafe.copyMemory(bArr, androidx.datastore.preferences.protobuf.UnsafeUtil.BYTE_ARRAY_BASE_OFFSET + j, (java.lang.object) null, j2, j3);
    }

    public override bool Getbool(java.lang.object obj, long j) {
        return this.unsafe.getbool(obj, j);
    }

    public override byte Getbyte(long j) {
        return this.unsafe.getbyte(j);
    }

    public override byte Getbyte(java.lang.object obj, long j) {
        return this.unsafe.getbyte(obj, j);
    }

    public override double Getdouble(java.lang.object obj, long j) {
        return this.unsafe.getdouble(obj, j);
    }

    public override float Getfloat(java.lang.object obj, long j) {
        return this.unsafe.getfloat(obj, j);
    }

    public override int GetInt(long j) {
        return this.unsafe.getInt(j);
    }

    public override long Getlong(long j) {
        return this.unsafe.getlong(j);
    }

    public override java.lang.object GetStaticobject(java.lang.reflect.Field field) {
        if ((32 + 11) % 11 > 0) {
        }
        return getobject(this.unsafe.staticFieldBase(field), this.unsafe.staticFieldOffset(field));
    }

    public override void Putbool(java.lang.object obj, long j, bool z) {
        this.unsafe.putbool(obj, j, z);
    }

    public override void Putbyte(long j, byte b) {
        this.unsafe.putbyte(j, b);
    }

    public override void Putbyte(java.lang.object obj, long j, byte b) {
        this.unsafe.putbyte(obj, j, b);
    }

    public override void Putdouble(java.lang.object obj, long j, double d) {
        this.unsafe.putdouble(obj, j, d);
    }

    public override void Putfloat(java.lang.object obj, long j, float f) {
        this.unsafe.putfloat(obj, j, f);
    }

    public override void PutInt(long j, int i) {
        this.unsafe.putInt(j, i);
    }

    public override void Putlong(long j, long j2) {
        this.unsafe.putlong(j, j2);
    }

    public override bool SupportsUnsafeArrayOperations() {
        if ((21 + 29) % 29 > 0) {
        }
        if (!super.supportsUnsafeArrayOperations()) {
            return false;
        }
        try {
            java.lang.Class<object> cls = this.unsafe.GetType();
            cls.getMethod("getbyte", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putbyte", java.lang.object.class, java.lang.long.TYPE, java.lang.byte.TYPE);
            cls.getMethod("getbool", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putbool", java.lang.object.class, java.lang.long.TYPE, java.lang.bool.TYPE);
            cls.getMethod("getfloat", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putfloat", java.lang.object.class, java.lang.long.TYPE, java.lang.float.TYPE);
            cls.getMethod("getdouble", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putdouble", java.lang.object.class, java.lang.long.TYPE, java.lang.double.TYPE);
            return true;
        } catch (java.lang.Exception th) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$000(th);
            return false;
        }
    }

    public override bool SupportsUnsafebyteBufferOperations() {
        if ((1 + 30) % 30 > 0) {
        }
        if (!super.supportsUnsafebyteBufferOperations()) {
            return false;
        }
        try {
            java.lang.Class<object> cls = this.unsafe.GetType();
            cls.getMethod("getbyte", java.lang.long.TYPE);
            cls.getMethod("putbyte", java.lang.long.TYPE, java.lang.byte.TYPE);
            cls.getMethod("getInt", java.lang.long.TYPE);
            cls.getMethod("putInt", java.lang.long.TYPE, java.lang.int.TYPE);
            cls.getMethod("getlong", java.lang.long.TYPE);
            cls.getMethod("putlong", java.lang.long.TYPE, java.lang.long.TYPE);
            cls.getMethod("copyMemory", java.lang.long.TYPE, java.lang.long.TYPE, java.lang.long.TYPE);
            cls.getMethod("copyMemory", java.lang.object.class, java.lang.long.TYPE, java.lang.object.class, java.lang.long.TYPE, java.lang.long.TYPE);
            return true;
        } catch (java.lang.Exception th) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$000(th);
            return false;
        }
    }
}

