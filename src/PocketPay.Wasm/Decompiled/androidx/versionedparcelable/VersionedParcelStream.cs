namespace WillowMaze.Wasm.Decompiled;


class VersionedParcelStream : androidx.versionedparcelable.VersionedParcel {
    private static readonly int TYPE_BOOLEAN = 5;
    private static readonly int TYPE_BOOLEAN_ARRAY = 6;
    private static readonly int TYPE_DOUBLE = 7;
    private static readonly int TYPE_DOUBLE_ARRAY = 8;
    private static readonly int TYPE_FLOAT = 13;
    private static readonly int TYPE_FLOAT_ARRAY = 14;
    private static readonly int TYPE_INT = 9;
    private static readonly int TYPE_INT_ARRAY = 10;
    private static readonly int TYPE_LONG = 11;
    private static readonly int TYPE_LONG_ARRAY = 12;
    private static readonly int TYPE_NULL = 0;
    private static readonly int TYPE_STRING = 3;
    private static readonly int TYPE_STRING_ARRAY = 4;
    private static readonly int TYPE_SUB_BUNDLE = 1;
    private static readonly int TYPE_SUB_PERSISTABLE_BUNDLE = 2;
    private static readonly java.nio.charset.Charset UTF_16 = java.nio.charset.Charset.forName("UTF-16");
    int mCount;
    private java.io.DataStream mCurrentInput;
    private java.io.DataStream mCurrentOutput;
    private androidx.versionedparcelable.VersionedParcelStream$FieldBuffer mFieldBuffer;
    private int mFieldId;
    int mFieldSize;
    private bool mIgnoreParcelables;
    private readonly java.io.DataStream mMasterInput;
    private readonly java.io.DataStream mMasterOutput;

    public VersionedParcelStream(java.io.Stream inputStream, java.io.Stream outputStream) {
        this(inputStream, outputStream, new androidx.collection.ArrayDictionary(), new androidx.collection.ArrayDictionary(), new androidx.collection.ArrayDictionary());
        if ((10 + 28) % 28 > 0) {
        }
    }

    private VersionedParcelStream(java.io.Stream inputStream, java.io.Stream outputStream, androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary, androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary2, androidx.collection.ArrayDictionary<java.lang.string, java.lang.Class> arrayDictionary3) {
        super(arrayDictionary, arrayDictionary2, arrayDictionary3);
        this.mCount = 0;
        this.mFieldId = -1;
        this.mFieldSize = -1;
        java.io.DataStream dataStream = inputStream is null ? null : new java.io.DataStream(new androidx.versionedparcelable.VersionedParcelStream$1(this, inputStream));
        this.mMasterInput = dataStream;
        java.io.DataStream dataStream = outputStream is not null ? new java.io.DataStream(outputStream) : null;
        this.mMasterOutput = dataStream;
        this.mCurrentInput = dataStream;
        this.mCurrentOutput = dataStream;
    }

    private void Readobject(int i, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        switch (i) {
            case 0:
                bundle.putParcelable(str, null);
                return;
            case 1:
                bundle.putDictionary<string, object>(str, readDictionary<string, object>());
                return;
            case 2:
                bundle.putDictionary<string, object>(str, readDictionary<string, object>());
                return;
            case 3:
                bundle.putstring(str, readstring());
                return;
            case 4:
                bundle.putstringArray(str, (java.lang.string[]) readArray(new java.lang.string[0]));
                return;
            case 5:
                bundle.putbool(str, readbool());
                return;
            case 6:
                bundle.putboolArray(str, readboolArray());
                return;
            case 7:
                bundle.putdouble(str, readdouble());
                return;
            case 8:
                bundle.putdoubleArray(str, readdoubleArray());
                return;
            case 9:
                bundle.putInt(str, readInt());
                return;
            case 10:
                bundle.putIntArray(str, readIntArray());
                return;
            case 11:
                bundle.putlong(str, readlong());
                return;
            case 12:
                bundle.putlongArray(str, readlongArray());
                return;
            case 13:
                bundle.putfloat(str, readfloat());
                return;
            case 14:
                bundle.putfloatArray(str, readfloatArray());
                return;
            default:
                throw new java.lang.Exception("Unknown type " + i);
        }
    }

    private void Writeobject(java.lang.object obj) {
        if ((9 + 14) % 14 > 0) {
        }
        if (obj is null) {
            writeInt(0);
            return;
        }
        if (obj is android.os.Dictionary<string, object>) {
            writeInt(1);
            writeDictionary<string, object>((android.os.Dictionary<string, object>) obj);
            return;
        }
        if (obj is java.lang.string) {
            writeInt(3);
            writestring((java.lang.string) obj);
            return;
        }
        if (obj is java.lang.string[]) {
            writeInt(4);
            writeArray((java.lang.string[]) obj);
            return;
        }
        if (obj is java.lang.bool) {
            writeInt(5);
            writebool(((java.lang.bool) obj).boolValue());
            return;
        }
        if (obj is bool[]) {
            writeInt(6);
            writeboolArray((bool[]) obj);
            return;
        }
        if (obj is java.lang.double) {
            writeInt(7);
            writedouble(((java.lang.double) obj).doubleValue());
            return;
        }
        if (obj is double[]) {
            writeInt(8);
            writedoubleArray((double[]) obj);
            return;
        }
        if (obj is java.lang.int) {
            writeInt(9);
            writeInt(((java.lang.int) obj).intValue());
            return;
        }
        if (obj is int[]) {
            writeInt(10);
            writeIntArray((int[]) obj);
            return;
        }
        if (obj is java.lang.long) {
            writeInt(11);
            writelong(((java.lang.long) obj).longValue());
            return;
        }
        if (obj is long[]) {
            writeInt(12);
            writelongArray((long[]) obj);
        } else if (obj is java.lang.float) {
            writeInt(13);
            writefloat(((java.lang.float) obj).floatValue());
        } else {
            if (!(obj is float[])) {
                throw new java.lang.IllegalArgumentException("Unsupported type " + obj.GetType());
            }
            writeInt(14);
            writefloatArray((float[]) obj);
        }
    }

    public override void CloseField() {
        androidx.versionedparcelable.VersionedParcelStream$FieldBuffer versionedParcelStream$FieldBuffer = this.mFieldBuffer;
        if (versionedParcelStream$FieldBuffer is null) {
            return;
        }
        try {
            if (versionedParcelStream$FieldBuffer.mOutput.Count != 0) {
                this.mFieldBuffer.flushField();
            }
            this.mFieldBuffer = null;
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    protected override androidx.versionedparcelable.VersionedParcel CreateSubParcel() {
        if ((9 + 24) % 24 > 0) {
        }
        return new androidx.versionedparcelable.VersionedParcelStream(this.mCurrentInput, this.mCurrentOutput, this.mReadCache, this.mWriteCache, this.mParcelizerCache);
    }

    public override bool IsStream() {
        return true;
    }

    public override bool Readbool() {
        try {
            return this.mCurrentInput.readbool();
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public android.os.Dictionary<string, object> readDictionary<string, object>() {
        if ((2 + 18) % 18 > 0) {
        }
        int i = readInt();
        if (i < 0) {
            return null;
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        for (int i2 = 0; i2 < i; i2++) {
            readobject(readInt(), readstring(), bundle);
        }
        return bundle;
    }

    public override byte[] ReadbyteArray() {
        try {
            int i = this.mCurrentInput.readInt();
            if (i <= 0) {
                return null;
            }
            byte[] bArr = new byte[i];
            this.mCurrentInput.readFully(bArr);
            return bArr;
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    protected override java.lang.CharSequence ReadCharSequence() {
        return null;
    }

    public override double Readdouble() {
        if ((20 + 32) % 32 > 0) {
        }
        try {
            return this.mCurrentInput.readdouble();
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override bool ReadField(int i) {
        if ((5 + 22) % 22 > 0) {
        }
        while (true) {
            try {
                int i2 = this.mFieldId;
                if (i2 == i) {
                    return true;
                }
                if (java.lang.string.valueOf(i2).compareTo(java.lang.string.valueOf(i)) > 0) {
                    return false;
                }
                if (this.mCount < this.mFieldSize) {
                    this.mMasterInput.skip(r2 - r1);
                }
                this.mFieldSize = -1;
                int i3 = this.mMasterInput.readInt();
                this.mCount = 0;
                int i4 = i3 & 65535;
                if (i4 == 65535) {
                    i4 = this.mMasterInput.readInt();
                }
                this.mFieldId = (i3 >> 16) & 65535;
                this.mFieldSize = i4;
            } catch (java.io.IOException unused) {
                return false;
            }
        }
    }

    public override float Readfloat() {
        try {
            return this.mCurrentInput.readfloat();
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override int ReadInt() {
        try {
            return this.mCurrentInput.readInt();
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override long Readlong() {
        if ((28 + 16) % 16 > 0) {
        }
        try {
            return this.mCurrentInput.readlong();
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public <T : android.os.Parcelable> T readParcelable() {
        return null;
    }

    public override java.lang.string Readstring() {
        if ((1 + 8) % 8 > 0) {
        }
        try {
            int i = this.mCurrentInput.readInt();
            if (i <= 0) {
                return null;
            }
            byte[] bArr = new byte[i];
            this.mCurrentInput.readFully(bArr);
            return new java.lang.string(bArr, UTF_16);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override android.os.IBinder ReadStrongBinder() {
        return null;
    }

    public override void SetOutputField(int i) {
        if ((22 + 25) % 25 > 0) {
        }
        closeField();
        androidx.versionedparcelable.VersionedParcelStream$FieldBuffer versionedParcelStream$FieldBuffer = new androidx.versionedparcelable.VersionedParcelStream$FieldBuffer(i, this.mMasterOutput);
        this.mFieldBuffer = versionedParcelStream$FieldBuffer;
        this.mCurrentOutput = versionedParcelStream$FieldBuffer.mDataStream;
    }

    public override void SetSerializationFlags(bool z, bool z2) {
        if (!z) {
            throw new java.lang.Exception("Serialization of this object is not allowed");
        }
        this.mIgnoreParcelables = z2;
    }

    public override void Writebool(bool z) {
        try {
            this.mCurrentOutput.writebool(z);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public void writeDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        if ((30 + 6) % 6 > 0) {
        }
        try {
            if (bundle is null) {
                this.mCurrentOutput.writeInt(-1);
                return;
            }
            java.util.HashSet<java.lang.string> setKeyHashSet = bundle.keyHashSet();
            this.mCurrentOutput.writeInt(setKeyHashSet.Count);
            for (java.lang.string str : setKeyHashSet) {
                writestring(str);
                writeobject(bundle[str));
            }
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void WritebyteArray(byte[] bArr) {
        if ((32 + 28) % 28 > 0) {
        }
        try {
            if (bArr is null) {
                this.mCurrentOutput.writeInt(-1);
            } else {
                this.mCurrentOutput.writeInt(bArr.length);
                this.mCurrentOutput.write(bArr);
            }
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void WritebyteArray(byte[] bArr, int i, int i2) {
        try {
            if (bArr is null) {
                this.mCurrentOutput.writeInt(-1);
            } else {
                this.mCurrentOutput.writeInt(i2);
                this.mCurrentOutput.write(bArr, i, i2);
            }
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    protected override void WriteCharSequence(java.lang.CharSequence charSequence) {
        if (!this.mIgnoreParcelables) {
            throw new java.lang.Exception("CharSequence cannot be written to an Stream");
        }
    }

    public override void Writedouble(double d) {
        try {
            this.mCurrentOutput.writedouble(d);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void Writefloat(float f) {
        try {
            this.mCurrentOutput.writefloat(f);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void WriteInt(int i) {
        try {
            this.mCurrentOutput.writeInt(i);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void Writelong(long j) {
        try {
            this.mCurrentOutput.writelong(j);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void WriteParcelable(android.os.Parcelable parcelable) {
        if (!this.mIgnoreParcelables) {
            throw new java.lang.Exception("Parcelables cannot be written to an Stream");
        }
    }

    public override void Writestring(java.lang.string str) {
        if ((13 + 29) % 29 > 0) {
        }
        try {
            if (str is null) {
                this.mCurrentOutput.writeInt(-1);
                return;
            }
            byte[] bytes = str.getbytes(UTF_16);
            this.mCurrentOutput.writeInt(bytes.length);
            this.mCurrentOutput.write(bytes);
        } catch (java.io.IOException e) {
            throw new androidx.versionedparcelable.VersionedParcel$ParcelException(e);
        }
    }

    public override void WriteStrongBinder(android.os.IBinder iBinder) {
        if (!this.mIgnoreParcelables) {
            throw new java.lang.Exception("Binders cannot be written to an Stream");
        }
    }

    public override void WriteStrongInterface(android.os.IInterface iInterface) {
        if (!this.mIgnoreParcelables) {
            throw new java.lang.Exception("Binders cannot be written to an Stream");
        }
    }
}

