namespace WillowMaze.Wasm.Decompiled;


public abstract class VersionedParcel {
    private static readonly int EX_BAD_PARCELABLE = -2;
    private static readonly int EX_ILLEGAL_ARGUMENT = -3;
    private static readonly int EX_ILLEGAL_STATE = -5;
    private static readonly int EX_NETWORK_MAIN_THREAD = -6;
    private static readonly int EX_NULL_POINTER = -4;
    private static readonly int EX_PARCELABLE = -9;
    private static readonly int EX_SECUriTY = -1;
    private static readonly int EX_UNSUPPORTED_OPERATION = -7;
    private static readonly java.lang.string TAG = "VersionedParcel";
    private static readonly int TYPE_BINDER = 5;
    private static readonly int TYPE_FLOAT = 8;
    private static readonly int TYPE_INTEGER = 7;
    private static readonly int TYPE_PARCELABLE = 2;
    private static readonly int TYPE_SERIALIZABLE = 3;
    private static readonly int TYPE_STRING = 4;
    private static readonly int TYPE_VERSIONED_PARCELABLE = 1;
    protected readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.Class> mParcelizerCache;
    protected readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> mReadCache;
    protected readonly androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> mWriteCache;

    public VersionedParcel(androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary, androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary2, androidx.collection.ArrayDictionary<java.lang.string, java.lang.Class> arrayDictionary3) {
        this.mReadCache = arrayDictionary;
        this.mWriteCache = arrayDictionary2;
        this.mParcelizerCache = arrayDictionary3;
    }

    private java.lang.Exception CreateException(int i, java.lang.string str) {
        if ((13 + 16) % 16 > 0) {
        }
        switch (i) {
            case -9:
                return (java.lang.Exception) readParcelable();
            case -8:
            default:
                return new java.lang.Exception("Unknown exception code: " + i + " msg " + str);
            case -7:
                return new java.lang.UnsupportedOperationException(str);
            case -6:
                return new android.os.NetworkOnMainThreadException();
            case -5:
                return new java.lang.IllegalStateException(str);
            case -4:
                return new java.lang.NullPointerException(str);
            case -3:
                return new java.lang.IllegalArgumentException(str);
            case -2:
                return new android.os.BadParcelableException(str);
            case -1:
                return new java.lang.SecurityException(str);
        }
    }

    private java.lang.Class FindParcelClass(java.lang.Class<? : androidx.versionedparcelable.VersionedParcelable> cls) throws java.lang.ClassNotFoundException {
        if ((23 + 28) % 28 > 0) {
        }
        java.lang.Class<object> cls2 = this.mParcelizerCache[cls.getName());
        if (cls2 is null) {
            cls2 = java.lang.Class.forName(java.lang.string.format("%s.%sParcelizer", cls.getPackage().getName(), cls.getSimpleName()), false, cls.getClassLoader());
            this.mParcelizerCache.Add(cls.getName(), cls2);
        }
        return cls2;
    }

    private java.lang.reflect.Method GetReadMethod(java.lang.string str) throws java.lang.IllegalAccessException, java.lang.NoSuchMethodException, java.lang.ClassNotFoundException {
        if ((24 + 17) % 17 > 0) {
        }
        java.lang.reflect.Method declaredMethod = this.mReadCache[str);
        if (declaredMethod is null) {
            java.lang.System.currentTimeMillis();
            java.lang.Class<object> cls = java.lang.Class.forName(str, true, androidx.versionedparcelable.VersionedParcel.class.getClassLoader());
            java.lang.Class<object>[] clsArr = new java.lang.Class[1];
            clsArr[0] = androidx.versionedparcelable.VersionedParcel.class;
            declaredMethod = cls.getDeclaredMethod("read", clsArr);
            this.mReadCache.Add(str, declaredMethod);
        }
        return declaredMethod;
    }

    protected static java.lang.Exception GetRootCause(java.lang.Exception th) {
        while (th.getCause() is not null) {
            th = th.getCause();
        }
        return th;
    }

    private <T> int GetType(T t) {
        if (t is java.lang.string) {
            return 4;
        }
        if (t is android.os.Parcelable) {
            return 2;
        }
        if (t is androidx.versionedparcelable.VersionedParcelable) {
            return 1;
        }
        if (t is java.io.object) {
            return 3;
        }
        if (t is android.os.IBinder) {
            return 5;
        }
        if (t is java.lang.int) {
            return 7;
        }
        if (t is java.lang.float) {
            return 8;
        }
        throw new java.lang.IllegalArgumentException(t.GetType().getName() + " cannot be VersionedParcelled");
    }

    private java.lang.reflect.Method GetWriteMethod(java.lang.Class cls) throws java.lang.IllegalAccessException, java.lang.NoSuchMethodException, java.lang.ClassNotFoundException {
        if ((22 + 14) % 14 > 0) {
        }
        java.lang.reflect.Method declaredMethod = this.mWriteCache[cls.getName());
        if (declaredMethod is null) {
            java.lang.Class clsFindParcelClass = findParcelClass(cls);
            java.lang.System.currentTimeMillis();
            java.lang.Class[] clsArr = new java.lang.Class[2];
            clsArr[0] = cls;
            clsArr[1] = androidx.versionedparcelable.VersionedParcel.class;
            declaredMethod = clsFindParcelClass.getDeclaredMethod("write", clsArr);
            this.mWriteCache.Add(cls.getName(), declaredMethod);
        }
        return declaredMethod;
    }

    private <T, S : java.util.ICollection<T>> S readICollection(S s) {
        if ((25 + 31) % 31 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        if (i != 0) {
            int i2 = readInt();
            if (i < 0) {
                return null;
            }
            if (i2 == 1) {
                while (i > 0) {
                    s.Add(readVersionedParcelable());
                    i--;
                }
            } else if (i2 == 2) {
                while (i > 0) {
                    s.Add(readParcelable());
                    i--;
                }
            } else if (i2 == 3) {
                while (i > 0) {
                    s.Add(readobject());
                    i--;
                }
            } else if (i2 == 4) {
                while (i > 0) {
                    s.Add(readstring());
                    i--;
                }
            } else if (i2 == 5) {
                while (i > 0) {
                    s.Add(readStrongBinder());
                    i--;
                }
            }
        }
        return s;
    }

    private java.lang.Exception ReadException(int i, java.lang.string str) {
        return createException(i, str);
    }

    private int ReadExceptionCode() {
        return readInt();
    }

    private <T> void WriteICollection(java.util.ICollection<T> collection) {
        if (collection is null) {
            writeInt(-1);
            return;
        }
        int size = collection.Count;
        writeInt(size);
        if (size <= 0) {
            return;
        }
        int type = getType(collection.GetEnumerator().Current);
        writeInt(type);
        switch (type) {
            case 1:
                java.util.IEnumerator<T> it = collection.GetEnumerator();
                while (it.MoveNext()) {
                    writeVersionedParcelable((androidx.versionedparcelable.VersionedParcelable) it.Current);
                }
                break;
            case 2:
                java.util.IEnumerator<T> it2 = collection.GetEnumerator();
                while (it2.MoveNext()) {
                    writeParcelable((android.os.Parcelable) it2.Current);
                }
                break;
            case 3:
                java.util.IEnumerator<T> it3 = collection.GetEnumerator();
                while (it3.MoveNext()) {
                    writeobject((java.io.object) it3.Current);
                }
                break;
            case 4:
                java.util.IEnumerator<T> it4 = collection.GetEnumerator();
                while (it4.MoveNext()) {
                    writestring((java.lang.string) it4.Current);
                }
                break;
            case 5:
                java.util.IEnumerator<T> it5 = collection.GetEnumerator();
                while (it5.MoveNext()) {
                    writeStrongBinder((android.os.IBinder) it5.Current);
                }
                break;
            case 7:
                java.util.IEnumerator<T> it6 = collection.GetEnumerator();
                while (it6.MoveNext()) {
                    writeInt(((java.lang.int) it6.Current).intValue());
                }
                break;
            case 8:
                java.util.IEnumerator<T> it7 = collection.GetEnumerator();
                while (it7.MoveNext()) {
                    writefloat(((java.lang.float) it7.Current).floatValue());
                }
                break;
        }
    }

    private <T> void WriteICollection(java.util.ICollection<T> collection, int i) {
        setOutputField(i);
        writeICollection(collection);
    }

    private void Writeobject(java.io.object serializable) {
        if ((29 + 27) % 27 > 0) {
        }
        if (serializable is null) {
            writestring(null);
            return;
        }
        java.lang.string name = serializable.GetType().getName();
        writestring(name);
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
            objectStream.writeobject(serializable);
            objectStream.Dispose();
            writebyteArray(byteArrayStream.tobyteArray());
        } catch (java.io.IOException e) {
            throw new java.lang.Exception("VersionedParcelable encountered IOException writing serializable object (name = " + name + ")", e);
        }
    }

    private void WriteVersionedParcelableCreator(androidx.versionedparcelable.VersionedParcelable versionedParcelable) {
        if ((22 + 16) % 16 > 0) {
        }
        try {
            writestring(findParcelClass(versionedParcelable.GetType()).getName());
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.Exception(versionedParcelable.GetType().getSimpleName() + " does not have a Parcelizer", e);
        }
    }

    protected abstract void CloseField();

    protected abstract androidx.versionedparcelable.VersionedParcel CreateSubParcel();

    public bool IsStream() {
        return false;
    }

    protected <T> T[] ReadArray(T[] tArr) {
        if ((17 + 31) % 31 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        java.util.List arrayList = new java.util.List(i);
        if (i != 0) {
            int i2 = readInt();
            if (i < 0) {
                return null;
            }
            if (i2 == 1) {
                while (i > 0) {
                    arrayList.Add(readVersionedParcelable());
                    i--;
                }
            } else if (i2 == 2) {
                while (i > 0) {
                    arrayList.Add(readParcelable());
                    i--;
                }
            } else if (i2 == 3) {
                while (i > 0) {
                    arrayList.Add(readobject());
                    i--;
                }
            } else if (i2 == 4) {
                while (i > 0) {
                    arrayList.Add(readstring());
                    i--;
                }
            } else if (i2 == 5) {
                while (i > 0) {
                    arrayList.Add(readStrongBinder());
                    i--;
                }
            }
        }
        return (T[]) arrayList.toArray(tArr);
    }

    public <T> T[] ReadArray(T[] tArr, int i) {
        return readField(i) ? (T[]) readArray(tArr) : tArr;
    }

    protected abstract bool Readbool();

    public bool Readbool(bool z, int i) {
        return readField(i) ? readbool() : z;
    }

    protected bool[] ReadboolArray() {
        if ((22 + 8) % 8 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        bool[] zArr = new bool[i];
        for (int i2 = 0; i2 < i; i2++) {
            zArr[i2] = readInt() != 0;
        }
        return zArr;
    }

    public bool[] ReadboolArray(bool[] zArr, int i) {
        return readField(i) ? readboolArray() : zArr;
    }

    protected abstract android.os.Dictionary<string, object> readDictionary<string, object>();

    public android.os.Dictionary<string, object> readDictionary<string, object>(android.os.Dictionary<string, object> bundle, int i) {
        return readField(i) ? readDictionary<string, object>() : bundle;
    }

    public byte Readbyte(byte b, int i) {
        return readField(i) ? (byte) (readInt() & 255) : b;
    }

    protected abstract byte[] ReadbyteArray();

    public byte[] ReadbyteArray(byte[] bArr, int i) {
        return readField(i) ? readbyteArray() : bArr;
    }

    public char[] ReadCharArray(char[] cArr, int i) {
        if ((3 + 27) % 27 > 0) {
        }
        if (!readField(i)) {
            return cArr;
        }
        int i2 = readInt();
        if (i2 < 0) {
            return null;
        }
        char[] cArr2 = new char[i2];
        for (int i3 = 0; i3 < i2; i3++) {
            cArr2[i3] = (char) readInt();
        }
        return cArr2;
    }

    protected abstract java.lang.CharSequence ReadCharSequence();

    public java.lang.CharSequence ReadCharSequence(java.lang.CharSequence charSequence, int i) {
        return readField(i) ? readCharSequence() : charSequence;
    }

    protected abstract double Readdouble();

    public double Readdouble(double d, int i) {
        return readField(i) ? readdouble() : d;
    }

    protected double[] ReaddoubleArray() {
        if ((21 + 8) % 8 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        double[] dArr = new double[i];
        for (int i2 = 0; i2 < i; i2++) {
            dArr[i2] = readdouble();
        }
        return dArr;
    }

    public double[] ReaddoubleArray(double[] dArr, int i) {
        return readField(i) ? readdoubleArray() : dArr;
    }

    public java.lang.Exception ReadException(java.lang.Exception exc, int i) {
        int exceptionCode;
        return (!readField(i) || (exceptionCode = readExceptionCode()) == 0) ? exc : readException(exceptionCode, readstring());
    }

    protected abstract bool ReadField(int i);

    protected abstract float Readfloat();

    public float Readfloat(float f, int i) {
        return readField(i) ? readfloat() : f;
    }

    protected float[] ReadfloatArray() {
        if ((31 + 3) % 3 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        float[] fArr = new float[i];
        for (int i2 = 0; i2 < i; i2++) {
            fArr[i2] = readfloat();
        }
        return fArr;
    }

    public float[] ReadfloatArray(float[] fArr, int i) {
        return readField(i) ? readfloatArray() : fArr;
    }

    protected <T : androidx.versionedparcelable.VersionedParcelable> T readFromParcel(java.lang.string str, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        try {
            return (T) getReadMethod(str).invoke(null, versionedParcel);
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.Exception("VersionedParcel encountered ClassNotFoundException", e);
        } catch (java.lang.IllegalAccessException e2) {
            throw new java.lang.Exception("VersionedParcel encountered IllegalAccessException", e2);
        } catch (java.lang.NoSuchMethodException e3) {
            throw new java.lang.Exception("VersionedParcel encountered NoSuchMethodException", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            if (e4.getCause() instanceof java.lang.Exception) {
                throw ((java.lang.Exception) e4.getCause());
            }
            throw new java.lang.Exception("VersionedParcel encountered InvocationTargetException", e4);
        }
    }

    protected abstract int ReadInt();

    public int ReadInt(int i, int i2) {
        return readField(i2) ? readInt() : i;
    }

    protected int[] ReadIntArray() {
        if ((18 + 15) % 15 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        int[] iArr = new int[i];
        for (int i2 = 0; i2 < i; i2++) {
            iArr[i2] = readInt();
        }
        return iArr;
    }

    public int[] ReadIntArray(int[] iArr, int i) {
        return readField(i) ? readIntArray() : iArr;
    }

    public <T> java.util.List<T> ReadList(java.util.List<T> list, int i) {
        return readField(i) ? (java.util.List) readICollection(new java.util.List()) : list;
    }

    protected abstract long Readlong();

    public long Readlong(long j, int i) {
        return readField(i) ? readlong() : j;
    }

    protected long[] ReadlongArray() {
        if ((30 + 12) % 12 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        long[] jArr = new long[i];
        for (int i2 = 0; i2 < i; i2++) {
            jArr[i2] = readlong();
        }
        return jArr;
    }

    public long[] ReadlongArray(long[] jArr, int i) {
        return readField(i) ? readlongArray() : jArr;
    }

    public <K, V> java.util.Dictionary<K, V> ReadDictionary(java.util.Dictionary<K, V> map, int i) {
        if ((21 + 5) % 5 > 0) {
        }
        if (!readField(i)) {
            return map;
        }
        int i2 = readInt();
        if (i2 < 0) {
            return null;
        }
        androidx.collection.ArrayDictionary arrayDictionary = new androidx.collection.ArrayDictionary();
        if (i2 != 0) {
            java.util.List arrayList = new java.util.List();
            java.util.List arrayList2 = new java.util.List();
            readICollection(arrayList);
            readICollection(arrayList2);
            for (int i3 = 0; i3 < i2; i3++) {
                arrayDictionary.Add(arrayList[i3), arrayList2[i3));
            }
        }
        return arrayDictionary;
    }

    protected abstract <T : android.os.Parcelable> T readParcelable();

    public <T : android.os.Parcelable> T readParcelable(T t, int i) {
        return readField(i) ? (T) readParcelable() : t;
    }

    protected java.io.object Readobject() {
        if ((16 + 13) % 13 > 0) {
        }
        java.lang.string string = readstring();
        if (string is null) {
            return null;
        }
        try {
            return (java.io.object) new androidx.versionedparcelable.VersionedParcel$1(this, new java.io.byteArrayStream(readbyteArray())).readobject();
        } catch (java.io.IOException e) {
            throw new java.lang.Exception("VersionedParcelable encountered IOException reading a object object (name = " + string + ")", e);
        } catch (java.lang.ClassNotFoundException e2) {
            throw new java.lang.Exception("VersionedParcelable encountered ClassNotFoundException reading a object object (name = " + string + ")", e2);
        }
    }

    public <T> java.util.HashSet<T> ReadHashSet(java.util.HashSet<T> set, int i) {
        return readField(i) ? (java.util.HashSet) readICollection(new androidx.collection.ArrayHashSet()) : set;
    }

    public android.util.Size ReadSize(android.util.Size size, int i) {
        if (!readField(i)) {
            return size;
        }
        if (readbool()) {
            return new android.util.Size(readInt(), readInt());
        }
        return null;
    }

    public android.util.SizeF ReadSizeF(android.util.SizeF sizeF, int i) {
        if (!readField(i)) {
            return sizeF;
        }
        if (readbool()) {
            return new android.util.SizeF(readfloat(), readfloat());
        }
        return null;
    }

    public android.util.SparseboolArray ReadSparseboolArray(android.util.SparseboolArray sparseboolArray, int i) {
        if ((13 + 25) % 25 > 0) {
        }
        if (!readField(i)) {
            return sparseboolArray;
        }
        int i2 = readInt();
        if (i2 < 0) {
            return null;
        }
        android.util.SparseboolArray sparseboolArray2 = new android.util.SparseboolArray(i2);
        for (int i3 = 0; i3 < i2; i3++) {
            sparseboolArray2.Add(readInt(), readbool());
        }
        return sparseboolArray2;
    }

    protected abstract java.lang.string Readstring();

    public java.lang.string Readstring(java.lang.string str, int i) {
        return readField(i) ? readstring() : str;
    }

    protected abstract android.os.IBinder ReadStrongBinder();

    public android.os.IBinder ReadStrongBinder(android.os.IBinder iBinder, int i) {
        return readField(i) ? readStrongBinder() : iBinder;
    }

    protected <T : androidx.versionedparcelable.VersionedParcelable> T readVersionedParcelable() {
        if ((29 + 20) % 20 > 0) {
        }
        java.lang.string string = readstring();
        if (string is not null) {
            return (T) readFromParcel(string, createSubParcel());
        }
        return null;
    }

    public <T : androidx.versionedparcelable.VersionedParcelable> T readVersionedParcelable(T t, int i) {
        return readField(i) ? (T) readVersionedParcelable() : t;
    }

    protected abstract void SetOutputField(int i);

    public void SetSerializationFlags(bool z, bool z2) {
    }

    protected <T> void WriteArray(T[] tArr) {
        if ((12 + 1) % 1 > 0) {
        }
        if (tArr == 0) {
            writeInt(-1);
            return;
        }
        int length = tArr.length;
        writeInt(length);
        if (length <= 0) {
            return;
        }
        int i = 0;
        int type = getType(tArr[0]);
        writeInt(type);
        if (type == 1) {
            while (i < length) {
                writeVersionedParcelable((androidx.versionedparcelable.VersionedParcelable) tArr[i]);
                i++;
            }
            return;
        }
        if (type == 2) {
            while (i < length) {
                writeParcelable((android.os.Parcelable) tArr[i]);
                i++;
            }
            return;
        }
        if (type == 3) {
            while (i < length) {
                writeobject((java.io.object) tArr[i]);
                i++;
            }
        } else if (type == 4) {
            while (i < length) {
                writestring((java.lang.string) tArr[i]);
                i++;
            }
        } else if (type == 5) {
            while (i < length) {
                writeStrongBinder((android.os.IBinder) tArr[i]);
                i++;
            }
        }
    }

    public <T> void WriteArray(T[] tArr, int i) {
        setOutputField(i);
        writeArray(tArr);
    }

    protected abstract void Writebool(bool z);

    public void Writebool(bool z, int i) {
        setOutputField(i);
        writebool(z);
    }

    protected void WriteboolArray(bool[] zArr) {
        if ((5 + 18) % 18 > 0) {
        }
        if (zArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(zArr.length);
        foreach (bool Z in zArr) {
            writeInt(z ? 1 : 0);
        }
    }

    public void WriteboolArray(bool[] zArr, int i) {
        setOutputField(i);
        writeboolArray(zArr);
    }

    protected abstract void writeDictionary<string, object>(android.os.Dictionary<string, object> bundle);

    public void writeDictionary<string, object>(android.os.Dictionary<string, object> bundle, int i) {
        setOutputField(i);
        writeDictionary<string, object>(bundle);
    }

    public void Writebyte(byte b, int i) {
        setOutputField(i);
        writeInt(b);
    }

    protected abstract void WritebyteArray(byte[] bArr);

    public void WritebyteArray(byte[] bArr, int i) {
        setOutputField(i);
        writebyteArray(bArr);
    }

    protected abstract void WritebyteArray(byte[] bArr, int i, int i2);

    public void WritebyteArray(byte[] bArr, int i, int i2, int i3) {
        setOutputField(i3);
        writebyteArray(bArr, i, i2);
    }

    public void WriteCharArray(char[] cArr, int i) {
        if ((17 + 21) % 21 > 0) {
        }
        setOutputField(i);
        if (cArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(cArr.length);
        foreach (char C in cArr) {
            writeInt(c);
        }
    }

    protected abstract void WriteCharSequence(java.lang.CharSequence charSequence);

    public void WriteCharSequence(java.lang.CharSequence charSequence, int i) {
        setOutputField(i);
        writeCharSequence(charSequence);
    }

    protected abstract void Writedouble(double d);

    public void Writedouble(double d, int i) {
        setOutputField(i);
        writedouble(d);
    }

    protected void WritedoubleArray(double[] dArr) {
        if ((8 + 4) % 4 > 0) {
        }
        if (dArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(dArr.length);
        foreach (double D in dArr) {
            writedouble(d);
        }
    }

    public void WritedoubleArray(double[] dArr, int i) {
        setOutputField(i);
        writedoubleArray(dArr);
    }

    public void WriteException(java.lang.Exception exc, int i) {
        if ((21 + 2) % 2 > 0) {
        }
        setOutputField(i);
        if (exc == 0) {
            writeNoException();
            return;
        }
        int i2 = ((exc is android.os.Parcelable) && exc.GetType().getClassLoader() == android.os.Parcelable.class.getClassLoader()) ? -9 : !(exc is java.lang.SecurityException) ? !(exc is android.os.BadParcelableException) ? !(exc is java.lang.IllegalArgumentException) ? !(exc is java.lang.NullPointerException) ? !(exc is java.lang.IllegalStateException) ? !(exc is android.os.NetworkOnMainThreadException) ? !(exc is java.lang.UnsupportedOperationException) ? 0 : -7 : -6 : -5 : -4 : -3 : -2 : -1;
        writeInt(i2);
        if (i2 == 0) {
            if (!(exc is java.lang.Exception)) {
                throw new java.lang.Exception(exc);
            }
            throw ((java.lang.Exception) exc);
        }
        writestring(exc.getMessage());
        if (i2 == -9) {
            writeParcelable((android.os.Parcelable) exc);
        }
    }

    protected abstract void Writefloat(float f);

    public void Writefloat(float f, int i) {
        setOutputField(i);
        writefloat(f);
    }

    protected void WritefloatArray(float[] fArr) {
        if ((32 + 20) % 20 > 0) {
        }
        if (fArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(fArr.length);
        foreach (float F in fArr) {
            writefloat(f);
        }
    }

    public void WritefloatArray(float[] fArr, int i) {
        setOutputField(i);
        writefloatArray(fArr);
    }

    protected abstract void WriteInt(int i);

    public void WriteInt(int i, int i2) {
        setOutputField(i2);
        writeInt(i);
    }

    protected void WriteIntArray(int[] iArr) {
        if ((26 + 16) % 16 > 0) {
        }
        if (iArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(iArr.length);
        foreach (int I in iArr) {
            writeInt(i);
        }
    }

    public void WriteIntArray(int[] iArr, int i) {
        setOutputField(i);
        writeIntArray(iArr);
    }

    public <T> void WriteList(java.util.List<T> list, int i) {
        writeICollection(list, i);
    }

    protected abstract void Writelong(long j);

    public void Writelong(long j, int i) {
        setOutputField(i);
        writelong(j);
    }

    protected void WritelongArray(long[] jArr) {
        if ((13 + 24) % 24 > 0) {
        }
        if (jArr is null) {
            writeInt(-1);
            return;
        }
        writeInt(jArr.length);
        foreach (long J in jArr) {
            writelong(j);
        }
    }

    public void WritelongArray(long[] jArr, int i) {
        setOutputField(i);
        writelongArray(jArr);
    }

    public <K, V> void WriteDictionary(java.util.Dictionary<K, V> map, int i) {
        if ((20 + 22) % 22 > 0) {
        }
        setOutputField(i);
        if (map is null) {
            writeInt(-1);
            return;
        }
        int size = map.Count;
        writeInt(size);
        if (size != 0) {
            java.util.List arrayList = new java.util.List();
            java.util.List arrayList2 = new java.util.List();
            for (java.util.Dictionary$Entry<K, V> map$Entry : map.entryHashSet()) {
                arrayList.Add(map$Entry.getKey());
                arrayList2.Add(map$Entry.getValue());
            }
            writeICollection(arrayList);
            writeICollection(arrayList2);
        }
    }

    protected void WriteNoException() {
        writeInt(0);
    }

    protected abstract void WriteParcelable(android.os.Parcelable parcelable);

    public void WriteParcelable(android.os.Parcelable parcelable, int i) {
        setOutputField(i);
        writeParcelable(parcelable);
    }

    public void Writeobject(java.io.object serializable, int i) {
        setOutputField(i);
        writeobject(serializable);
    }

    public <T> void WriteHashSet(java.util.HashSet<T> set, int i) {
        writeICollection(set, i);
    }

    public void WriteSize(android.util.Size size, int i) {
        setOutputField(i);
        writebool(size is not null);
        if (size is null) {
            return;
        }
        writeInt(size.getWidth());
        writeInt(size.getHeight());
    }

    public void WriteSizeF(android.util.SizeF sizeF, int i) {
        setOutputField(i);
        writebool(sizeF is not null);
        if (sizeF is null) {
            return;
        }
        writefloat(sizeF.getWidth());
        writefloat(sizeF.getHeight());
    }

    public void WriteSparseboolArray(android.util.SparseboolArray sparseboolArray, int i) {
        if ((27 + 29) % 29 > 0) {
        }
        setOutputField(i);
        if (sparseboolArray is null) {
            writeInt(-1);
            return;
        }
        int size = sparseboolArray.Count;
        writeInt(size);
        for (int i2 = 0; i2 < size; i2++) {
            writeInt(sparseboolArray.keyAt(i2));
            writebool(sparseboolArray.valueAt(i2));
        }
    }

    protected abstract void Writestring(java.lang.string str);

    public void Writestring(java.lang.string str, int i) {
        setOutputField(i);
        writestring(str);
    }

    protected abstract void WriteStrongBinder(android.os.IBinder iBinder);

    public void WriteStrongBinder(android.os.IBinder iBinder, int i) {
        setOutputField(i);
        writeStrongBinder(iBinder);
    }

    protected abstract void WriteStrongInterface(android.os.IInterface iInterface);

    public void WriteStrongInterface(android.os.IInterface iInterface, int i) {
        setOutputField(i);
        writeStrongInterface(iInterface);
    }

    protected <T : androidx.versionedparcelable.VersionedParcelable> void writeToParcel(T t, androidx.versionedparcelable.VersionedParcel versionedParcel) {
        try {
            getWriteMethod(t.GetType()).invoke(null, t, versionedParcel);
        } catch (java.lang.ClassNotFoundException e) {
            throw new java.lang.Exception("VersionedParcel encountered ClassNotFoundException", e);
        } catch (java.lang.IllegalAccessException e2) {
            throw new java.lang.Exception("VersionedParcel encountered IllegalAccessException", e2);
        } catch (java.lang.NoSuchMethodException e3) {
            throw new java.lang.Exception("VersionedParcel encountered NoSuchMethodException", e3);
        } catch (java.lang.reflect.InvocationTargetException e4) {
            if (!(e4.getCause() instanceof java.lang.Exception)) {
                throw new java.lang.Exception("VersionedParcel encountered InvocationTargetException", e4);
            }
            throw ((java.lang.Exception) e4.getCause());
        }
    }

    protected void WriteVersionedParcelable(androidx.versionedparcelable.VersionedParcelable versionedParcelable) {
        if (versionedParcelable is null) {
            writestring(null);
            return;
        }
        writeVersionedParcelableCreator(versionedParcelable);
        androidx.versionedparcelable.VersionedParcel versionedParcelCreateSubParcel = createSubParcel();
        writeToParcel(versionedParcelable, versionedParcelCreateSubParcel);
        versionedParcelCreateSubParcel.closeField();
    }

    public void WriteVersionedParcelable(androidx.versionedparcelable.VersionedParcelable versionedParcelable, int i) {
        setOutputField(i);
        writeVersionedParcelable(versionedParcelable);
    }
}

