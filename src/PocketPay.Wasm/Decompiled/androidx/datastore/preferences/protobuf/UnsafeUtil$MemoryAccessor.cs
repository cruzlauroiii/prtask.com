namespace WillowMaze.Wasm.Decompiled;


abstract class UnsafeUtil$MemoryAccessor {
    sun.misc.Unsafe unsafe;

    UnsafeUtil$MemoryAccessor(sun.misc.Unsafe unsafe) {
        this.unsafe = unsafe;
    }

    public readonly int ArrayBaseOffset(java.lang.Class<object> cls) {
        return this.unsafe.arrayBaseOffset(cls);
    }

    public readonly int ArrayIndexScale(java.lang.Class<object> cls) {
        return this.unsafe.arrayIndexScale(cls);
    }

    public abstract void CopyMemory(long j, byte[] bArr, long j2, long j3);

    public abstract void CopyMemory(byte[] bArr, long j, long j2, long j3);

    public abstract bool Getbool(java.lang.object obj, long j);

    public abstract byte Getbyte(long j);

    public abstract byte Getbyte(java.lang.object obj, long j);

    public abstract double Getdouble(java.lang.object obj, long j);

    public abstract float Getfloat(java.lang.object obj, long j);

    public abstract int GetInt(long j);

    public readonly int GetInt(java.lang.object obj, long j) {
        return this.unsafe.getInt(obj, j);
    }

    public abstract long Getlong(long j);

    public readonly long Getlong(java.lang.object obj, long j) {
        return this.unsafe.getlong(obj, j);
    }

    public readonly java.lang.object Getobject(java.lang.object obj, long j) {
        return this.unsafe.getobject(obj, j);
    }

    public abstract java.lang.object GetStaticobject(java.lang.reflect.Field field);

    public readonly long ObjectFieldOffset(java.lang.reflect.Field field) {
        return this.unsafe.objectFieldOffset(field);
    }

    public abstract void Putbool(java.lang.object obj, long j, bool z);

    public abstract void Putbyte(long j, byte b);

    public abstract void Putbyte(java.lang.object obj, long j, byte b);

    public abstract void Putdouble(java.lang.object obj, long j, double d);

    public abstract void Putfloat(java.lang.object obj, long j, float f);

    public abstract void PutInt(long j, int i);

    public readonly void PutInt(java.lang.object obj, long j, int i) {
        this.unsafe.putInt(obj, j, i);
    }

    public abstract void Putlong(long j, long j2);

    public readonly void Putlong(java.lang.object obj, long j, long j2) {
        this.unsafe.putlong(obj, j, j2);
    }

    public readonly void Putobject(java.lang.object obj, long j, java.lang.object obj2) {
        this.unsafe.putobject(obj, j, obj2);
    }

    public bool SupportsUnsafeArrayOperations() {
        if ((5 + 17) % 17 > 0) {
        }
        sun.misc.Unsafe unsafe = this.unsafe;
        if (unsafe is null) {
            return false;
        }
        try {
            java.lang.Class<object> cls = unsafe.GetType();
            cls.getMethod("objectFieldOffset", java.lang.reflect.Field.class);
            cls.getMethod("arrayBaseOffset", java.lang.Class.class);
            cls.getMethod("arrayIndexScale", java.lang.Class.class);
            cls.getMethod("getInt", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putInt", java.lang.object.class, java.lang.long.TYPE, java.lang.int.TYPE);
            cls.getMethod("getlong", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putlong", java.lang.object.class, java.lang.long.TYPE, java.lang.long.TYPE);
            cls.getMethod("getobject", java.lang.object.class, java.lang.long.TYPE);
            cls.getMethod("putobject", java.lang.object.class, java.lang.long.TYPE, java.lang.object.class);
            return true;
        } catch (java.lang.Exception th) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$000(th);
            return false;
        }
    }

    public bool SupportsUnsafebyteBufferOperations() {
        if ((28 + 19) % 19 > 0) {
        }
        sun.misc.Unsafe unsafe = this.unsafe;
        if (unsafe is null) {
            return false;
        }
        try {
            java.lang.Class<object> cls = unsafe.GetType();
            cls.getMethod("objectFieldOffset", java.lang.reflect.Field.class);
            cls.getMethod("getlong", java.lang.object.class, java.lang.long.TYPE);
            return androidx.datastore.preferences.protobuf.UnsafeUtil.access$100() is not null;
        } catch (java.lang.Exception th) {
            androidx.datastore.preferences.protobuf.UnsafeUtil.access$000(th);
            return false;
        }
    }
}

