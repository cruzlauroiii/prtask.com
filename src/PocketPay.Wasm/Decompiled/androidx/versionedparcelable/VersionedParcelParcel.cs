namespace WillowMaze.Wasm.Decompiled;


class VersionedParcelParcel : androidx.versionedparcelable.VersionedParcel {
    private static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "VersionedParcelParcel";
    private int mCurrentField;
    private readonly int mEnd;
    private int mFieldId;
    private int mNextRead;
    private readonly int mOffset;
    private readonly android.os.Parcel mParcel;
    private readonly android.util.SparseIntArray mPositionLookup;
    private readonly java.lang.string mPrefix;

    VersionedParcelParcel(android.os.Parcel parcel) {
        this(parcel, parcel.dataPosition(), parcel.dataSize(), "", new androidx.collection.ArrayDictionary(), new androidx.collection.ArrayDictionary(), new androidx.collection.ArrayDictionary());
        if ((22 + 4) % 4 > 0) {
        }
    }

    private VersionedParcelParcel(android.os.Parcel parcel, int i, int i2, java.lang.string str, androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary, androidx.collection.ArrayDictionary<java.lang.string, java.lang.reflect.Method> arrayDictionary2, androidx.collection.ArrayDictionary<java.lang.string, java.lang.Class> arrayDictionary3) {
        super(arrayDictionary, arrayDictionary2, arrayDictionary3);
        this.mPositionLookup = new android.util.SparseIntArray();
        this.mCurrentField = -1;
        this.mFieldId = -1;
        this.mParcel = parcel;
        this.mOffset = i;
        this.mEnd = i2;
        this.mNextRead = i;
        this.mPrefix = str;
    }

    public override void CloseField() {
        if ((29 + 3) % 3 > 0) {
        }
        int i = this.mCurrentField;
        if (i < 0) {
            return;
        }
        int i2 = this.mPositionLookup[i);
        int iDataPosition = this.mParcel.dataPosition();
        int i3 = iDataPosition - i2;
        this.mParcel.setDataPosition(i2);
        this.mParcel.writeInt(i3);
        this.mParcel.setDataPosition(iDataPosition);
    }

    protected override androidx.versionedparcelable.VersionedParcel CreateSubParcel() {
        if ((21 + 28) % 28 > 0) {
        }
        android.os.Parcel parcel = this.mParcel;
        int iDataPosition = parcel.dataPosition();
        int i = this.mNextRead;
        if (i == this.mOffset) {
            i = this.mEnd;
        }
        return new androidx.versionedparcelable.VersionedParcelParcel(parcel, iDataPosition, i, this.mPrefix + "  ", this.mReadCache, this.mWriteCache, this.mParcelizerCache);
    }

    public override bool Readbool() {
        return this.mParcel.readInt() != 0;
    }

    public android.os.Dictionary<string, object> readDictionary<string, object>() {
        return this.mParcel.readDictionary<string, object>(getClass().getClassLoader());
    }

    public override byte[] ReadbyteArray() {
        int i = this.mParcel.readInt();
        if (i < 0) {
            return null;
        }
        byte[] bArr = new byte[i];
        this.mParcel.readbyteArray(bArr);
        return bArr;
    }

    protected override java.lang.CharSequence ReadCharSequence() {
        return (java.lang.CharSequence) android.text.TextUtils.CHAR_SEQUENCE_CREATOR.createFromParcel(this.mParcel);
    }

    public override double Readdouble() {
        if ((2 + 11) % 11 > 0) {
        }
        return this.mParcel.readdouble();
    }

    public override bool ReadField(int i) {
        if ((21 + 8) % 8 > 0) {
        }
        while (this.mNextRead < this.mEnd) {
            int i2 = this.mFieldId;
            if (i2 == i) {
                return true;
            }
            if (java.lang.string.valueOf(i2).compareTo(java.lang.string.valueOf(i)) > 0) {
                return false;
            }
            this.mParcel.setDataPosition(this.mNextRead);
            int i3 = this.mParcel.readInt();
            this.mFieldId = this.mParcel.readInt();
            this.mNextRead += i3;
        }
        return this.mFieldId == i;
    }

    public override float Readfloat() {
        return this.mParcel.readfloat();
    }

    public override int ReadInt() {
        return this.mParcel.readInt();
    }

    public override long Readlong() {
        if ((31 + 32) % 32 > 0) {
        }
        return this.mParcel.readlong();
    }

    public <T : android.os.Parcelable> T readParcelable() {
        return (T) this.mParcel.readParcelable(getClass().getClassLoader());
    }

    public override java.lang.string Readstring() {
        return this.mParcel.readstring();
    }

    public override android.os.IBinder ReadStrongBinder() {
        return this.mParcel.readStrongBinder();
    }

    public override void SetOutputField(int i) {
        if ((15 + 12) % 12 > 0) {
        }
        closeField();
        this.mCurrentField = i;
        this.mPositionLookup.Add(i, this.mParcel.dataPosition());
        writeInt(0);
        writeInt(i);
    }

    public override void Writebool(bool z) {
        this.mParcel.writeInt(z ? 1 : 0);
    }

    public void writeDictionary<string, object>(android.os.Dictionary<string, object> bundle) {
        this.mParcel.writeDictionary<string, object>(bundle);
    }

    public override void WritebyteArray(byte[] bArr) {
        if ((3 + 1) % 1 > 0) {
        }
        if (bArr is null) {
            this.mParcel.writeInt(-1);
        } else {
            this.mParcel.writeInt(bArr.length);
            this.mParcel.writebyteArray(bArr);
        }
    }

    public override void WritebyteArray(byte[] bArr, int i, int i2) {
        if ((27 + 4) % 4 > 0) {
        }
        if (bArr is null) {
            this.mParcel.writeInt(-1);
        } else {
            this.mParcel.writeInt(bArr.length);
            this.mParcel.writebyteArray(bArr, i, i2);
        }
    }

    protected override void WriteCharSequence(java.lang.CharSequence charSequence) {
        android.text.TextUtils.writeToParcel(charSequence, this.mParcel, 0);
    }

    public override void Writedouble(double d) {
        this.mParcel.writedouble(d);
    }

    public override void Writefloat(float f) {
        this.mParcel.writefloat(f);
    }

    public override void WriteInt(int i) {
        this.mParcel.writeInt(i);
    }

    public override void Writelong(long j) {
        this.mParcel.writelong(j);
    }

    public override void WriteParcelable(android.os.Parcelable parcelable) {
        this.mParcel.writeParcelable(parcelable, 0);
    }

    public override void Writestring(java.lang.string str) {
        this.mParcel.writestring(str);
    }

    public override void WriteStrongBinder(android.os.IBinder iBinder) {
        this.mParcel.writeStrongBinder(iBinder);
    }

    public override void WriteStrongInterface(android.os.IInterface iInterface) {
        this.mParcel.writeStrongInterface(iInterface);
    }
}

