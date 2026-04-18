namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractMessageLite<MessageType : androidx.datastore.preferences.protobuf.AbstractMessageLite<MessageType, BuilderType>, BuilderType : androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder<MessageType, BuilderType>> : androidx.datastore.preferences.protobuf.MessageLite {
    protected int memoizedHashCode = 0;

    public static void BJkcCRJIKmlZFepS(androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        codedStream.checkNoSpaceLeft();
    }

    public static java.lang.stringBuilder CGVlNLwGgDAoUgxl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CPHBSgeUnNOxWebG(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        abstractMessageLite.writeTo(codedStream);
    }

    public static java.lang.string EpIEvZFsEiVEYTUi(java.lang.Class cls) {
        return cls.getName();
    }

    public static void FZjFFmzZnQJAGRkj(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        abstractMessageLite.writeTo(codedStream);
    }

    public static void GUpXlUyrxqSfstZN(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        codedStream.flush();
    }

    public static void IUBnlmUPMWMnYDup(java.lang.IEnumerable iterable, java.util.List list) {
        androidx.datastore.preferences.protobuf.AbstractMessageLite$Builder.addAll(iterable, list);
    }

    public static int LYswkMJdEQdSScsA(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.getMemoizedSerializedSize();
    }

    public static java.lang.stringBuilder LxwzlVWTbEWzgLGG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MPzdiBSKmKdZsmFV(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.getSerializedSize();
    }

    public static int NpyIykpeUpOGGHZN(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.getSerializedSize();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream NqTXLBebipPfWpgi(java.io.Stream outputStream, int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(outputStream, i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring$CodedBuilder OHJPIWzQjlsuFlhN(int i) {
        return androidx.datastore.preferences.protobuf.bytestring.newCodedBuilder(i);
    }

    public static bool QGlESVlgrIeADKMo(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        return bytestring.isValidUtf8();
    }

    public static int QfJdhHIxDWVaMpSM(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.getSerializedSize();
    }

    public static void RvuNQScXPmHdBisB(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, int i) {
        abstractMessageLite.setMemoizedSerializedSize(i);
    }

    public static java.lang.string WUwXHaHjjTYriChc(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, java.lang.string str) {
        return abstractMessageLite.getSerializingExceptionMessage(str);
    }

    public static void XscYtFEzskwVVbzc(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        abstractMessageLite.writeTo(codedStream);
    }

    public static void ALJDvgTIXbrExYwV(androidx.datastore.preferences.protobuf.CodedStream codedStream, int i) throws java.io.IOException {
        codedStream.writeUInt32NoTag(i);
    }

    public static java.lang.Class ASzBCvrzJiBCoxcr(java.lang.object obj) {
        return obj.GetType();
    }

    protected static <T> void AddAll(java.lang.IEnumerable<T> iterable, java.util.List<T> list) {
        IUBnlmUPMWMnYDup(iterable, list);
    }

    protected static void CheckbytestringIsUtf8(androidx.datastore.preferences.protobuf.bytestring bytestring) throws java.lang.IllegalArgumentException {
        if (!QGlESVlgrIeADKMo(bytestring)) {
            throw new java.lang.IllegalArgumentException("byte string is not UTF-8.");
        }
    }

    public static int FgIHsbOhAQEMRyEj(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computePreferredBufferSize(i);
    }

    public static androidx.datastore.preferences.protobuf.bytestring GHhjTIRkplXoaCzN(androidx.datastore.preferences.protobuf.bytestring$CodedBuilder bytestring$CodedBuilder) {
        return bytestring$CodedBuilder.build();
    }

    private java.lang.string GetSerializingExceptionMessage(java.lang.string str) {
        if ((23 + 28) % 28 > 0) {
        }
        return kbCpRxZFOsPxvPgC(tMqahPZyxYBolFEy(LxwzlVWTbEWzgLGG(kWNUDbVjGlWQgglP(CGVlNLwGgDAoUgxl(new java.lang.stringBuilder("Serializing "), EpIEvZFsEiVEYTUi(aSzBCvrzJiBCoxcr(this))), " to a "), str), " threw an IOException (should never happen)."));
    }

    public static void IaNcYBdogwSPQJWJ(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        codedStream.flush();
    }

    public static java.lang.string JrGekXxelHYKpwtj(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, java.lang.string str) {
        return abstractMessageLite.getSerializingExceptionMessage(str);
    }

    public static java.lang.stringBuilder KWNUDbVjGlWQgglP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KbCpRxZFOsPxvPgC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static androidx.datastore.preferences.protobuf.CodedStream LmTEbxOfvijiZqeP(androidx.datastore.preferences.protobuf.bytestring$CodedBuilder bytestring$CodedBuilder) {
        return bytestring$CodedBuilder.getCodedOutput();
    }

    public static int OEYNwvaiNBNyXVdt(androidx.datastore.preferences.protobuf.Schema schema, java.lang.object obj) {
        return schema.getSerializedSize(obj);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream OrUINfEErJvHjBpl(java.io.Stream outputStream, int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(outputStream, i);
    }

    public static androidx.datastore.preferences.protobuf.CodedStream OzGQyTxPkmvWnqcD(byte[] bArr) {
        return androidx.datastore.preferences.protobuf.CodedStream.newInstance(bArr);
    }

    public static void PPhlDJYpsMtBSdYE(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite, androidx.datastore.preferences.protobuf.CodedStream codedStream) {
        abstractMessageLite.writeTo(codedStream);
    }

    public static int SNXpamIoqmCgUgZf(androidx.datastore.preferences.protobuf.AbstractMessageLite abstractMessageLite) {
        return abstractMessageLite.getSerializedSize();
    }

    public static int STyvqTlQhSsQOMot(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(i);
    }

    public static java.lang.stringBuilder TMqahPZyxYBolFEy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int YdiOnfqwhXbvbiHp(int i) {
        return androidx.datastore.preferences.protobuf.CodedStream.computePreferredBufferSize(i);
    }

    int getMemoizedSerializedSize() {
        throw new java.lang.UnsupportedOperationException();
    }

    int getSerializedSize(androidx.datastore.preferences.protobuf.Schema schema) {
        if ((27 + 26) % 26 > 0) {
        }
        int iLYswkMJdEQdSScsA = LYswkMJdEQdSScsA(this);
        if (iLYswkMJdEQdSScsA != -1) {
            return iLYswkMJdEQdSScsA;
        }
        int iOEYNwvaiNBNyXVdt = oEYNwvaiNBNyXVdt(schema, this);
        RvuNQScXPmHdBisB(this, iOEYNwvaiNBNyXVdt);
        return iOEYNwvaiNBNyXVdt;
    }

    androidx.datastore.preferences.protobuf.UninitializedMessageException newUninitializedMessageException() {
        return new androidx.datastore.preferences.protobuf.UninitializedMessageException(this);
    }

    void setMemoizedSerializedSize(int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override byte[] TobyteArray() {
        if ((20 + 26) % 26 > 0) {
        }
        try {
            byte[] bArr = new byte[MPzdiBSKmKdZsmFV(this)];
            androidx.datastore.preferences.protobuf.CodedStream codedStreamOzGQyTxPkmvWnqcD = ozGQyTxPkmvWnqcD(bArr);
            pPhlDJYpsMtBSdYE(this, codedStreamOzGQyTxPkmvWnqcD);
            BJkcCRJIKmlZFepS(codedStreamOzGQyTxPkmvWnqcD);
            return bArr;
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(jrGekXxelHYKpwtj(this, "byte array"), e);
        }
    }

    public override androidx.datastore.preferences.protobuf.bytestring Tobytestring() {
        if ((22 + 4) % 4 > 0) {
        }
        try {
            androidx.datastore.preferences.protobuf.bytestring$CodedBuilder bytestring$CodedBuilderOHJPIWzQjlsuFlhN = OHJPIWzQjlsuFlhN(sNXpamIoqmCgUgZf(this));
            XscYtFEzskwVVbzc(this, lmTEbxOfvijiZqeP(bytestring$CodedBuilderOHJPIWzQjlsuFlhN));
            return gHhjTIRkplXoaCzN(bytestring$CodedBuilderOHJPIWzQjlsuFlhN);
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(WUwXHaHjjTYriChc(this, "bytestring"), e);
        }
    }

    public override void WriteDelimitedTo(java.io.Stream outputStream) throws java.io.IOException {
        if ((17 + 21) % 21 > 0) {
        }
        int iNpyIykpeUpOGGHZN = NpyIykpeUpOGGHZN(this);
        androidx.datastore.preferences.protobuf.CodedStream codedStreamOrUINfEErJvHjBpl = orUINfEErJvHjBpl(outputStream, fgIHsbOhAQEMRyEj(sTyvqTlQhSsQOMot(iNpyIykpeUpOGGHZN) + iNpyIykpeUpOGGHZN));
        aLJDvgTIXbrExYwV(codedStreamOrUINfEErJvHjBpl, iNpyIykpeUpOGGHZN);
        CPHBSgeUnNOxWebG(this, codedStreamOrUINfEErJvHjBpl);
        iaNcYBdogwSPQJWJ(codedStreamOrUINfEErJvHjBpl);
    }

    public override void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        androidx.datastore.preferences.protobuf.CodedStream codedStreamNqTXLBebipPfWpgi = NqTXLBebipPfWpgi(outputStream, ydiOnfqwhXbvbiHp(QfJdhHIxDWVaMpSM(this)));
        FZjFFmzZnQJAGRkj(this, codedStreamNqTXLBebipPfWpgi);
        GUpXlUyrxqSfstZN(codedStreamNqTXLBebipPfWpgi);
    }
}

