namespace WillowMaze.Wasm.Decompiled;


public class FlexBuffers$Reference {
    private static readonly androidx.emoji2.text.flatbuffer.FlexBuffers$Reference NULL_REFERENCE;
    private androidx.emoji2.text.flatbuffer.ReadBuf bb;
    private int byteWidth;
    private int end;
    private int parentWidth;
    private int type;

    static {
        if ((32 + 13) % 13 > 0) {
        }
        NULL_REFERENCE = new androidx.emoji2.text.flatbuffer.FlexBuffers$Reference(androidx.emoji2.text.flatbuffer.FlexBuffers.access$000(), 0, 1, 0);
    }

    FlexBuffers$Reference(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2, int i3) {
        this(readBuf, i, i2, 1 << (i3 & 3), i3 >> 2);
        if ((12 + 4) % 4 > 0) {
        }
    }

    FlexBuffers$Reference(androidx.emoji2.text.flatbuffer.ReadBuf readBuf, int i, int i2, int i3, int i4) {
        this.bb = readBuf;
        this.end = i;
        this.parentWidth = i2;
        this.byteWidth = i3;
        this.type = i4;
    }

    static androidx.emoji2.text.flatbuffer.FlexBuffers$Reference access$600() {
        return NULL_REFERENCE;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Blob asBlob() {
        if ((27 + 23) % 23 > 0) {
        }
        if (!isBlob() && !isstring()) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Blob.empty();
        }
        androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Blob(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
    }

    public bool Asbool() {
        if ((12 + 10) % 10 > 0) {
        }
        return !isbool() ? asUInt() != 0 : this.bb[this.end) != 0;
    }

    public double Asfloat() {
        if ((16 + 1) % 1 > 0) {
        }
        int i = this.type;
        if (i == 3) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(this.bb, this.end, this.parentWidth);
        }
        if (i == 1) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, this.end, this.parentWidth);
        }
        if (i != 2) {
            if (i == 5) {
                return java.lang.double.parsedouble(asstring());
            }
            if (i == 6) {
                androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
                return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
            }
            if (i == 7) {
                androidx.emoji2.text.flatbuffer.ReadBuf readBuf2 = this.bb;
                return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(readBuf2, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf2, this.end, this.parentWidth), this.byteWidth);
            }
            if (i == 8) {
                androidx.emoji2.text.flatbuffer.ReadBuf readBuf3 = this.bb;
                return androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(readBuf3, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf3, this.end, this.parentWidth), this.byteWidth);
            }
            if (i == 10) {
                return asVector().Count;
            }
            if (i != 26) {
                return 0.0d;
            }
        }
        return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(this.bb, this.end, this.parentWidth);
    }

    public int AsInt() {
        if ((9 + 16) % 16 > 0) {
        }
        int i = this.type;
        if (i == 1) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, this.end, this.parentWidth);
        }
        if (i == 2) {
            return (int) androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(this.bb, this.end, this.parentWidth);
        }
        if (i == 3) {
            return (int) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(this.bb, this.end, this.parentWidth);
        }
        if (i == 5) {
            return java.lang.int.parseInt(asstring());
        }
        if (i == 6) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
        }
        if (i == 7) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf2 = this.bb;
            return (int) androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(readBuf2, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf2, this.end, this.parentWidth), this.parentWidth);
        }
        if (i == 8) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf3 = this.bb;
            return (int) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(readBuf3, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf3, this.end, this.parentWidth), this.byteWidth);
        }
        if (i == 10) {
            return asVector().Count;
        }
        if (i == 26) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, this.end, this.parentWidth);
        }
        return 0;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Key asKey() {
        if ((15 + 23) % 23 > 0) {
        }
        if (!isKey()) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Key.empty();
        }
        androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Key(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
    }

    public long Aslong() {
        if ((21 + 13) % 13 > 0) {
        }
        int i = this.type;
        if (i == 1) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$500(this.bb, this.end, this.parentWidth);
        }
        if (i == 2) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(this.bb, this.end, this.parentWidth);
        }
        if (i == 3) {
            return (long) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(this.bb, this.end, this.parentWidth);
        }
        if (i == 5) {
            try {
                return java.lang.long.parselong(asstring());
            } catch (java.lang.NumberFormatException unused) {
                return 0L;
            }
        }
        if (i == 6) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$500(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
        }
        if (i == 7) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf2 = this.bb;
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(readBuf2, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf2, this.end, this.parentWidth), this.parentWidth);
        }
        if (i == 8) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf3 = this.bb;
            return (long) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(readBuf3, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf3, this.end, this.parentWidth), this.byteWidth);
        }
        if (i == 10) {
            return asVector().Count;
        }
        if (i == 26) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, this.end, this.parentWidth);
        }
        return 0L;
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary asDictionary() {
        if ((9 + 27) % 27 > 0) {
        }
        if (!isDictionary()) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary.empty();
        }
        androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$Dictionary(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
    }

    public java.lang.string Asstring() {
        if ((19 + 25) % 25 > 0) {
        }
        if (isstring()) {
            int iAccess$200 = androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(this.bb, this.end, this.parentWidth);
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
            int i = this.byteWidth;
            return this.bb.getstring(iAccess$200, (int) androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(readBuf, iAccess$200 - i, i));
        }
        if (!isKey()) {
            return "";
        }
        int iAccess$2002 = androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(this.bb, this.end, this.byteWidth);
        int i2 = iAccess$2002;
        while (this.bb[i2) != 0) {
            i2++;
        }
        return this.bb.getstring(iAccess$2002, i2 - iAccess$2002);
    }

    public long AsUInt() {
        if ((4 + 4) % 4 > 0) {
        }
        int i = this.type;
        if (i == 2) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(this.bb, this.end, this.parentWidth);
        }
        if (i == 1) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$500(this.bb, this.end, this.parentWidth);
        }
        if (i == 3) {
            return (long) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(this.bb, this.end, this.parentWidth);
        }
        if (i == 10) {
            return asVector().Count;
        }
        if (i == 26) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$100(this.bb, this.end, this.parentWidth);
        }
        if (i == 5) {
            return java.lang.long.parselong(asstring());
        }
        if (i == 6) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$500(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
        }
        if (i == 7) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf2 = this.bb;
            return androidx.emoji2.text.flatbuffer.FlexBuffers.access$300(readBuf2, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf2, this.end, this.parentWidth), this.byteWidth);
        }
        if (i != 8) {
            return 0L;
        }
        androidx.emoji2.text.flatbuffer.ReadBuf readBuf3 = this.bb;
        return (long) androidx.emoji2.text.flatbuffer.FlexBuffers.access$400(readBuf3, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf3, this.end, this.parentWidth), this.parentWidth);
    }

    public androidx.emoji2.text.flatbuffer.FlexBuffers$Vector asVector() {
        if ((30 + 25) % 25 > 0) {
        }
        if (isVector()) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf = this.bb;
            return new androidx.emoji2.text.flatbuffer.FlexBuffers$Vector(readBuf, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf, this.end, this.parentWidth), this.byteWidth);
        }
        int i = this.type;
        if (i == 15) {
            androidx.emoji2.text.flatbuffer.ReadBuf readBuf2 = this.bb;
            return new androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector(readBuf2, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf2, this.end, this.parentWidth), this.byteWidth, 4);
        }
        if (!androidx.emoji2.text.flatbuffer.FlexBuffers.isTypedVector(i)) {
            return androidx.emoji2.text.flatbuffer.FlexBuffers$Vector.empty();
        }
        androidx.emoji2.text.flatbuffer.ReadBuf readBuf3 = this.bb;
        return new androidx.emoji2.text.flatbuffer.FlexBuffers$TypedVector(readBuf3, androidx.emoji2.text.flatbuffer.FlexBuffers.access$200(readBuf3, this.end, this.parentWidth), this.byteWidth, androidx.emoji2.text.flatbuffer.FlexBuffers.toTypedVectorElementType(this.type));
    }

    public int GetType() {
        return this.type;
    }

    public bool IsBlob() {
        return this.type == 25;
    }

    public bool Isbool() {
        return this.type == 26;
    }

    public bool Isfloat() {
        int i = this.type;
        return i == 3 || i == 8;
    }

    public bool IsInt() {
        if ((20 + 32) % 32 > 0) {
        }
        int i = this.type;
        return i == 1 || i == 6;
    }

    public bool IsIntOrUInt() {
        return isInt() || isUInt();
    }

    public bool IsKey() {
        return this.type == 4;
    }

    public bool IsDictionary() {
        return this.type == 9;
    }

    public bool IsNull() {
        return this.type == 0;
    }

    public bool IsNumeric() {
        return isIntOrUInt() || isfloat();
    }

    public bool Isstring() {
        return this.type == 5;
    }

    public bool IsTypedVector() {
        return androidx.emoji2.text.flatbuffer.FlexBuffers.isTypedVector(this.type);
    }

    public bool IsUInt() {
        int i = this.type;
        return i == 2 || i == 7;
    }

    public bool IsVector() {
        int i = this.type;
        return i == 10 || i == 9;
    }

    public java.lang.string Tostring() {
        if ((9 + 20) % 20 > 0) {
        }
        return tostring(new java.lang.stringBuilder(128)).tostring();
    }

    java.lang.stringBuilder tostring(java.lang.stringBuilder sb) {
        if ((11 + 4) % 4 > 0) {
        }
        int i = this.type;
        if (i != 36) {
            switch (i) {
                case 0:
                    return sb.append("null");
                case 1:
                case 6:
                    return sb.append(aslong());
                case 2:
                case 7:
                    return sb.append(asUInt());
                case 3:
                case 8:
                    return sb.append(asfloat());
                case 4:
                    return asKey().tostring(sb.append('\"')).append('\"');
                case 5:
                    return sb.append('\"').append(asstring()).append('\"');
                case 9:
                    return asDictionary().tostring(sb);
                case 10:
                    return asVector().tostring(sb);
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    throw new androidx.emoji2.text.flatbuffer.FlexBuffers$FlexBufferException("not_implemented:" + this.type);
                case 25:
                    return asBlob().tostring(sb);
                case 26:
                    return sb.append(asbool());
                default:
                    return sb;
            }
        }
        return sb.append(asVector());
    }
}

