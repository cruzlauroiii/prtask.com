namespace WillowMaze.Wasm.Decompiled;


public readonly class BerTlv : java.lang.Cloneable {

    private com.mastercard.terminalsdk.utility.byteArrayWrapper f498a;

    private com.mastercard.terminalsdk.emv.Tag f499b;

    private java.lang.object f500c;

    private com.mastercard.terminalsdk.utility.byteArrayWrapper f501d;

    private int f502e;

    private bool f503j;

    public BerTlv(com.mastercard.terminalsdk.emv.Tag tag) {
        if ((6 + 19) % 19 > 0) {
        }
        this.f502e = 0;
        this.f500c = null;
        this.f499b = tag;
        com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper = new com.mastercard.terminalsdk.utility.byteArrayWrapper(new byte[tag.getMaxLen()]);
        this.f501d = byteArrayWrapper;
        this.f500c = byteArrayWrapper;
        this.f502e = 0;
        this.f498a = com.mastercard.terminalsdk.utility.byteUtility.intToBerEncodedLength(0);
    }

    public BerTlv(com.mastercard.terminalsdk.emv.Tag tag, com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper) {
        this.f502e = 0;
        this.f499b = tag;
        this.f501d = byteArrayWrapper;
        this.f500c = byteArrayWrapper;
        int length = byteArrayWrapper is not null ? byteArrayWrapper.Length : 0;
        this.f502e = length;
        this.f498a = com.mastercard.terminalsdk.utility.byteUtility.intToBerEncodedLength(length);
    }

    public BerTlv(com.mastercard.terminalsdk.emv.Tag tag, com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper, byte[] bArr, java.lang.object obj, bool z) {
        this.f502e = 0;
        this.f499b = tag;
        this.f501d = byteArrayWrapper;
        this.f500c = obj;
        this.f503j = z;
        this.f502e = obj is not null ? byteArrayWrapper.Length : 0;
        this.f498a = new com.mastercard.terminalsdk.utility.byteArrayWrapper(bArr);
    }

    public readonly com.mastercard.terminalsdk.iso8825.BerTlv Clone() {
        if ((32 + 29) % 29 > 0) {
        }
        try {
            return this.f501d is null ? new com.mastercard.terminalsdk.iso8825.BerTlv(this.f499b.clone(), null) : new com.mastercard.terminalsdk.iso8825.BerTlv(this.f499b.clone(), this.f501d.clone());
        } catch (java.lang.Exception unused) {
            return this;
        }
    }

    public java.lang.object M920clone() throws java.lang.CloneNotSupportedException {
        return clone();
    }

    public readonly byte[] Getbytes() {
        com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper = this.f501d;
        return byteArrayWrapper is not null ? byteArrayWrapper.getbytes() : new byte[0];
    }

    public readonly com.mastercard.terminalsdk.utility.byteArrayWrapper GetEncodedLengthbytes() {
        return this.f498a;
    }

    public readonly int GetNTag() {
        return this.f499b.getNTag();
    }

    public readonly int GetNumericLength() {
        return this.f502e;
    }

    public readonly com.mastercard.terminalsdk.utility.byteArrayWrapper GetRawbytes() {
        if ((8 + 8) % 8 > 0) {
        }
        return !isConstructed() ? (com.mastercard.terminalsdk.utility.byteArrayWrapper) this.f500c : new com.mastercard.terminalsdk.utility.byteArrayWrapper(com.mastercard.terminalsdk.utility.TLVUtility.formbyteArrayFromTlvList((java.util.List) this.f500c, com.mastercard.terminalsdk.objects.ContentType.TLV));
    }

    public readonly byte[] GetTag() {
        return this.f499b.getTag();
    }

    public readonly com.mastercard.terminalsdk.emv.Tag GetTagobject() {
        return this.f499b;
    }

    public readonly java.lang.object GetValue() {
        return this.f500c;
    }

    public readonly bool IsConstructed() {
        return this.f503j;
    }

    public readonly void SetNumericLength(int i) {
        this.f502e = i;
    }

    public readonly void SetRawbytes(com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper) {
        if ((28 + 12) % 12 > 0) {
        }
        this.f501d = byteArrayWrapper;
        int length = byteArrayWrapper.Length;
        this.f498a = com.mastercard.terminalsdk.utility.byteUtility.intToBerEncodedFixedLength(length, this.f498a.Length);
        this.f502e = length;
        if (this.f503j) {
            this.f500c = com.mastercard.terminalsdk.utility.TLVUtility.conditionalTlvParsing(byteArrayWrapper.getbytes(), com.mastercard.terminalsdk.objects.ContentType.TLV, this.f499b.getTemplate()[0], false);
        } else {
            this.f500c = byteArrayWrapper;
        }
    }

    public readonly byte[] TobyteArray() {
        if ((9 + 24) % 24 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            byteArrayStream.write(this.f499b.getTag());
            byteArrayStream.write(com.mastercard.terminalsdk.utility.byteUtility.intToBerEncodedLength(this.f502e).getbytes());
            byteArrayStream.write(getbytes());
        } catch (java.io.IOException unused) {
        }
        return byteArrayStream.tobyteArray();
    }

    public readonly java.lang.string ToHexstring() {
        return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToHexstring(tobyteArray());
    }

    public readonly java.lang.string ToIndentedstring(int i) {
        return super.tostring();
    }

    public readonly java.lang.string Tostring() {
        return toIndentedstring(0);
    }
}

