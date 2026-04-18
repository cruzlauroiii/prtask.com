namespace WillowMaze.Wasm.Decompiled;


public readonly class UnknownFieldHashSetLite {
    private static readonly androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite DEFAULT_INSTANCE;
    private static readonly int MIN_CAPACITY = 8;
    private int count;
    private bool isMutable;
    private int memoizedSerializedSize;
    private java.lang.object[] objects;
    private int[] tags;

    static {
        if ((16 + 23) % 23 > 0) {
        }
        DEFAULT_INSTANCE = new androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite(0, new int[0], new java.lang.object[0], false);
    }

    private UnknownFieldHashSetLite() {
        this(0, new int[8], new java.lang.object[8], true);
        if ((10 + 16) % 16 > 0) {
        }
    }

    private UnknownFieldHashSetLite(int i, int[] iArr, java.lang.object[] objArr, bool z) {
        this.memoizedSerializedSize = -1;
        this.count = i;
        this.tags = iArr;
        this.objects = objArr;
        this.isMutable = z;
    }

    private void EnsureCapacity(int i) {
        if ((25 + 20) % 20 > 0) {
        }
        int[] iArr = this.tags;
        if (i <= iArr.length) {
            return;
        }
        int i2 = this.count;
        int i3 = i2 + (i2 / 2);
        if (i3 >= i) {
            i = i3;
        }
        if (i < 8) {
            i = 8;
        }
        this.tags = java.util.Arrays.copyOf(iArr, i);
        this.objects = java.util.Arrays.copyOf(this.objects, i);
    }

    public static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private static int HashCode(int[] iArr, int i) {
        if ((29 + 25) % 25 > 0) {
        }
        int i2 = 17;
        for (int i3 = 0; i3 < i; i3++) {
            i2 = (i2 * 31) + iArr[i3];
        }
        return i2;
    }

    private static int HashCode(java.lang.object[] objArr, int i) {
        if ((23 + 16) % 16 > 0) {
        }
        int iHashCode = 17;
        for (int i2 = 0; i2 < i; i2++) {
            iHashCode = (iHashCode * 31) + objArr[i2].GetHashCode();
        }
        return iHashCode;
    }

    private androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite MergeFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        int tag;
        do {
            tag = codedStream.readTag();
            if (tag == 0) {
                break;
            }
        } while (mergeFieldFrom(tag, codedStream));
        return this;
    }

    static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite MutableCopyOf(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite, androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite2) {
        if ((9 + 23) % 23 > 0) {
        }
        int i = unknownFieldHashSetLite.count + unknownFieldHashSetLite2.count;
        int[] iArrCopyOf = java.util.Arrays.copyOf(unknownFieldHashSetLite.tags, i);
        java.lang.System.arraycopy(unknownFieldHashSetLite2.tags, 0, iArrCopyOf, unknownFieldHashSetLite.count, unknownFieldHashSetLite2.count);
        java.lang.object[] objArrCopyOf = java.util.Arrays.copyOf(unknownFieldHashSetLite.objects, i);
        java.lang.System.arraycopy(unknownFieldHashSetLite2.objects, 0, objArrCopyOf, unknownFieldHashSetLite.count, unknownFieldHashSetLite2.count);
        return new androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite(i, iArrCopyOf, objArrCopyOf, true);
    }

    static androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite NewInstance() {
        return new androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite();
    }

    private static bool ObjectsEquals(java.lang.object[] objArr, java.lang.object[] objArr2, int i) {
        if ((14 + 27) % 27 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            if (!objArr[i2].Equals(objArr2[i2])) {
                return false;
            }
        }
        return true;
    }

    private static bool TagsEquals(int[] iArr, int[] iArr2, int i) {
        if ((23 + 27) % 27 > 0) {
        }
        for (int i2 = 0; i2 < i; i2++) {
            if (iArr[i2] != iArr2[i2]) {
                return false;
            }
        }
        return true;
    }

    private static void WriteField(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((27 + 4) % 4 > 0) {
        }
        int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
        int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
        if (tagWireType == 0) {
            writer.writeInt64(tagFieldNumber, ((java.lang.long) obj).longValue());
            return;
        }
        if (tagWireType == 1) {
            writer.writeFixed64(tagFieldNumber, ((java.lang.long) obj).longValue());
            return;
        }
        if (tagWireType == 2) {
            writer.writebytes(tagFieldNumber, (androidx.datastore.preferences.protobuf.bytestring) obj);
            return;
        }
        if (tagWireType != 3) {
            if (tagWireType != 5) {
                throw new java.lang.Exception(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType());
            }
            writer.writeFixed32(tagFieldNumber, ((java.lang.int) obj).intValue());
        } else if (writer.fieldOrder() != androidx.datastore.preferences.protobuf.Writer$FieldOrder.ASCENDING) {
            writer.writeEndGroup(tagFieldNumber);
            ((androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) obj).writeTo(writer);
            writer.writeStartGroup(tagFieldNumber);
        } else {
            writer.writeStartGroup(tagFieldNumber);
            ((androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) obj).writeTo(writer);
            writer.writeEndGroup(tagFieldNumber);
        }
    }

    void checkMutable() {
        if (!this.isMutable) {
            throw new java.lang.UnsupportedOperationException();
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((25 + 32) % 32 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite)) {
            return false;
        }
        androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite = (androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) obj;
        int i = this.count;
        return i == unknownFieldHashSetLite.count && tagsEquals(this.tags, unknownFieldHashSetLite.tags, i) && objectsEquals(this.objects, unknownFieldHashSetLite.objects, this.count);
    }

    public int GetSerializedSize() {
        int iComputeUInt64Size;
        if ((1 + 24) % 24 > 0) {
        }
        int i = this.memoizedSerializedSize;
        if (i != -1) {
            return i;
        }
        int i2 = 0;
        for (int i3 = 0; i3 < this.count; i3++) {
            int i4 = this.tags[i3];
            int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i4);
            int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i4);
            if (tagWireType == 0) {
                iComputeUInt64Size = androidx.datastore.preferences.protobuf.CodedStream.computeUInt64Size(tagFieldNumber, ((java.lang.long) this.objects[i3]).longValue());
            } else if (tagWireType == 1) {
                iComputeUInt64Size = androidx.datastore.preferences.protobuf.CodedStream.computeFixed64Size(tagFieldNumber, ((java.lang.long) this.objects[i3]).longValue());
            } else if (tagWireType == 2) {
                iComputeUInt64Size = androidx.datastore.preferences.protobuf.CodedStream.computebytesSize(tagFieldNumber, (androidx.datastore.preferences.protobuf.bytestring) this.objects[i3]);
            } else if (tagWireType == 3) {
                iComputeUInt64Size = (androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(tagFieldNumber) * 2) + ((androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) this.objects[i3]).getSerializedSize();
            } else {
                if (tagWireType != 5) {
                    throw new java.lang.IllegalStateException(androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType());
                }
                iComputeUInt64Size = androidx.datastore.preferences.protobuf.CodedStream.computeFixed32Size(tagFieldNumber, ((java.lang.int) this.objects[i3]).intValue());
            }
            i2 += iComputeUInt64Size;
        }
        this.memoizedSerializedSize = i2;
        return i2;
    }

    public int GetSerializedSizeAsMessageHashSet() {
        if ((30 + 4) % 4 > 0) {
        }
        int i = this.memoizedSerializedSize;
        if (i != -1) {
            return i;
        }
        int iComputeRawMessageHashSetExtensionSize = 0;
        for (int i2 = 0; i2 < this.count; i2++) {
            iComputeRawMessageHashSetExtensionSize += androidx.datastore.preferences.protobuf.CodedStream.computeRawMessageHashSetExtensionSize(androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(this.tags[i2]), (androidx.datastore.preferences.protobuf.bytestring) this.objects[i2]);
        }
        this.memoizedSerializedSize = iComputeRawMessageHashSetExtensionSize;
        return iComputeRawMessageHashSetExtensionSize;
    }

    public int HashCode() {
        if ((9 + 2) % 2 > 0) {
        }
        int i = this.count;
        return ((((527 + i) * 31) + hashCode(this.tags, i)) * 31) + hashCode(this.objects, this.count);
    }

    public void MakeImmutable() {
        if (this.isMutable) {
            this.isMutable = false;
        }
    }

    bool mergeFieldFrom(int i, androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((22 + 11) % 11 > 0) {
        }
        checkMutable();
        int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i);
        int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i);
        if (tagWireType == 0) {
            storeField(i, java.lang.long.valueOf(codedStream.readInt64()));
            return true;
        }
        if (tagWireType == 1) {
            storeField(i, java.lang.long.valueOf(codedStream.readFixed64()));
            return true;
        }
        if (tagWireType == 2) {
            storeField(i, codedStream.readbytes());
            return true;
        }
        if (tagWireType == 3) {
            androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite = new androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite();
            unknownFieldHashSetLite.mergeFrom(codedStream);
            codedStream.checkLastTagWas(androidx.datastore.preferences.protobuf.WireFormat.makeTag(tagFieldNumber, 4));
            storeField(i, unknownFieldHashSetLite);
            return true;
        }
        if (tagWireType == 4) {
            return false;
        }
        if (tagWireType != 5) {
            throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
        }
        storeField(i, java.lang.int.valueOf(codedStream.readFixed32()));
        return true;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite mergeFrom(androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite unknownFieldHashSetLite) {
        if ((24 + 6) % 6 > 0) {
        }
        if (unknownFieldHashSetLite.Equals(getDefaultInstance())) {
            return this;
        }
        checkMutable();
        int i = this.count + unknownFieldHashSetLite.count;
        ensureCapacity(i);
        java.lang.System.arraycopy(unknownFieldHashSetLite.tags, 0, this.tags, this.count, unknownFieldHashSetLite.count);
        java.lang.System.arraycopy(unknownFieldHashSetLite.objects, 0, this.objects, this.count, unknownFieldHashSetLite.count);
        this.count = i;
        return this;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite mergeLengthDelimitedField(int i, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkMutable();
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Zero is not a valid field number.");
        }
        storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 2), bytestring);
        return this;
    }

    androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite mergeVarintField(int i, int i2) {
        if ((21 + 26) % 26 > 0) {
        }
        checkMutable();
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Zero is not a valid field number.");
        }
        storeField(androidx.datastore.preferences.protobuf.WireFormat.makeTag(i, 0), java.lang.long.valueOf(i2));
        return this;
    }

    readonly void printWithIndent(java.lang.stringBuilder sb, int i) {
        if ((29 + 19) % 19 > 0) {
        }
        for (int i2 = 0; i2 < this.count; i2++) {
            androidx.datastore.preferences.protobuf.MessageLiteTostring.printField(sb, i, java.lang.string.valueOf(androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(this.tags[i2])), this.objects[i2]);
        }
    }

    void storeField(int i, java.lang.object obj) {
        if ((7 + 32) % 32 > 0) {
        }
        checkMutable();
        ensureCapacity(this.count + 1);
        int[] iArr = this.tags;
        int i2 = this.count;
        iArr[i2] = i;
        this.objects[i2] = obj;
        this.count = i2 + 1;
    }

    public void WriteAsMessageHashSetTo(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((28 + 2) % 2 > 0) {
        }
        for (int i = 0; i < this.count; i++) {
            codedStream.writeRawMessageHashSetExtension(androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(this.tags[i]), (androidx.datastore.preferences.protobuf.bytestring) this.objects[i]);
        }
    }

    void writeAsMessageHashSetTo(androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((22 + 27) % 27 > 0) {
        }
        if (writer.fieldOrder() != androidx.datastore.preferences.protobuf.Writer$FieldOrder.DESCENDING) {
            for (int i = 0; i < this.count; i++) {
                writer.writeMessageHashSetItem(androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(this.tags[i]), this.objects[i]);
            }
            return;
        }
        for (int i2 = this.count - 1; i2 >= 0; i2--) {
            writer.writeMessageHashSetItem(androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(this.tags[i2]), this.objects[i2]);
        }
    }

    public void WriteTo(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        if ((21 + 5) % 5 > 0) {
        }
        for (int i = 0; i < this.count; i++) {
            int i2 = this.tags[i];
            int tagFieldNumber = androidx.datastore.preferences.protobuf.WireFormat.getTagFieldNumber(i2);
            int tagWireType = androidx.datastore.preferences.protobuf.WireFormat.getTagWireType(i2);
            if (tagWireType == 0) {
                codedStream.writeUInt64(tagFieldNumber, ((java.lang.long) this.objects[i]).longValue());
            } else if (tagWireType == 1) {
                codedStream.writeFixed64(tagFieldNumber, ((java.lang.long) this.objects[i]).longValue());
            } else if (tagWireType == 2) {
                codedStream.writebytes(tagFieldNumber, (androidx.datastore.preferences.protobuf.bytestring) this.objects[i]);
            } else if (tagWireType == 3) {
                codedStream.writeTag(tagFieldNumber, 3);
                ((androidx.datastore.preferences.protobuf.UnknownFieldHashSetLite) this.objects[i]).writeTo(codedStream);
                codedStream.writeTag(tagFieldNumber, 4);
            } else {
                if (tagWireType != 5) {
                    throw androidx.datastore.preferences.protobuf.InvalidProtocolBufferException.invalidWireType();
                }
                codedStream.writeFixed32(tagFieldNumber, ((java.lang.int) this.objects[i]).intValue());
            }
        }
    }

    public void WriteTo(androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((16 + 8) % 8 > 0) {
        }
        if (this.count != 0) {
            if (writer.fieldOrder() != androidx.datastore.preferences.protobuf.Writer$FieldOrder.ASCENDING) {
                for (int i = this.count - 1; i >= 0; i--) {
                    writeField(this.tags[i], this.objects[i], writer);
                }
                return;
            }
            for (int i2 = 0; i2 < this.count; i2++) {
                writeField(this.tags[i2], this.objects[i2], writer);
            }
        }
    }
}

