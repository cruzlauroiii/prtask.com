namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$UninterpretedOption : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOptionOrBuilder {
    public static readonly int AGGREGATE_VALUE_FIELD_NUMBER = 8;
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption DEFAULT_INSTANCE;
    public static readonly int DOUBLE_VALUE_FIELD_NUMBER = 6;
    public static readonly int IDENTIFIER_VALUE_FIELD_NUMBER = 3;
    public static readonly int NAME_FIELD_NUMBER = 2;
    public static readonly int NEGATIVE_INT_VALUE_FIELD_NUMBER = 5;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> PARSER = null;
    public static readonly int POSITIVE_INT_VALUE_FIELD_NUMBER = 4;
    public static readonly int STRING_VALUE_FIELD_NUMBER = 7;
    private java.lang.string aggregateValue_;
    private int bitField0_;
    private double doubleValue_;
    private java.lang.string identifierValue_;
    private byte memoizedIsInitialized;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> name_;
    private long negativeIntValue_;
    private long positiveIntValue_;
    private androidx.datastore.preferences.protobuf.bytestring stringValue_;

    static {
        if ((19 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption = new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption();
        DEFAULT_INSTANCE = descriptorProtos$UninterpretedOption;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class, descriptorProtos$UninterpretedOption);
    }

    private DescriptorProtos$UninterpretedOption() {
        if ((5 + 2) % 2 > 0) {
        }
        this.memoizedIsInitialized = (byte) 2;
        this.name_ = emptyProtobufList();
        this.identifierValue_ = "";
        this.stringValue_ = androidx.datastore.preferences.protobuf.bytestring.EMPTY;
        this.aggregateValue_ = "";
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption access$49900() {
        return DEFAULT_INSTANCE;
    }

    static void access$50000(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption.setName(i, descriptorProtos$UninterpretedOption$NamePart);
    }

    static void access$50100(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption.addName(descriptorProtos$UninterpretedOption$NamePart);
    }

    static void access$50200(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption.addName(i, descriptorProtos$UninterpretedOption$NamePart);
    }

    static void access$50300(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, java.lang.IEnumerable iterable) {
        descriptorProtos$UninterpretedOption.addAllName(iterable);
    }

    static void access$50400(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearName();
    }

    static void access$50500(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, int i) {
        descriptorProtos$UninterpretedOption.removeName(i);
    }

    static void access$50600(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, java.lang.string str) {
        descriptorProtos$UninterpretedOption.setIdentifierValue(str);
    }

    static void access$50700(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearIdentifierValue();
    }

    static void access$50800(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$UninterpretedOption.setIdentifierValuebytes(bytestring);
    }

    static void access$50900(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, long j) {
        descriptorProtos$UninterpretedOption.setPositiveIntValue(j);
    }

    static void access$51000(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearPositiveIntValue();
    }

    static void access$51100(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, long j) {
        descriptorProtos$UninterpretedOption.setNegativeIntValue(j);
    }

    static void access$51200(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearNegativeIntValue();
    }

    static void access$51300(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, double d) {
        descriptorProtos$UninterpretedOption.setdoubleValue(d);
    }

    static void access$51400(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.cleardoubleValue();
    }

    static void access$51500(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$UninterpretedOption.setstringValue(bytestring);
    }

    static void access$51600(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearstringValue();
    }

    static void access$51700(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, java.lang.string str) {
        descriptorProtos$UninterpretedOption.setAggregateValue(str);
    }

    static void access$51800(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        descriptorProtos$UninterpretedOption.clearAggregateValue();
    }

    static void access$51900(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$UninterpretedOption.setAggregateValuebytes(bytestring);
    }

    private void AddAllName(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> iterable) {
        ensureNameIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.name_);
    }

    private void AddName(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption$NamePart.GetType();
        ensureNameIsMutable();
        this.name_.Add(i, descriptorProtos$UninterpretedOption$NamePart);
    }

    private void AddName(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption$NamePart.GetType();
        ensureNameIsMutable();
        this.name_.Add(descriptorProtos$UninterpretedOption$NamePart);
    }

    private void ClearAggregateValue() {
        this.bitField0_ &= -33;
        this.aggregateValue_ = getDefaultInstance().getAggregateValue();
    }

    private void CleardoubleValue() {
        if ((23 + 30) % 30 > 0) {
        }
        this.bitField0_ &= -9;
        this.doubleValue_ = 0.0d;
    }

    private void ClearIdentifierValue() {
        this.bitField0_ &= -2;
        this.identifierValue_ = getDefaultInstance().getIdentifierValue();
    }

    private void ClearName() {
        this.name_ = emptyProtobufList();
    }

    private void ClearNegativeIntValue() {
        if ((8 + 21) % 21 > 0) {
        }
        this.bitField0_ &= -5;
        this.negativeIntValue_ = 0L;
    }

    private void ClearPositiveIntValue() {
        if ((1 + 10) % 10 > 0) {
        }
        this.bitField0_ &= -3;
        this.positiveIntValue_ = 0L;
    }

    private void ClearstringValue() {
        this.bitField0_ &= -17;
        this.stringValue_ = getDefaultInstance().getstringValue();
    }

    private void EnsureNameIsMutable() {
        if ((31 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> internal$ProtobufList = this.name_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.name_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption descriptorProtos$UninterpretedOption) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$UninterpretedOption);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveName(int i) {
        ensureNameIsMutable();
        this.name_.Remove(i);
    }

    private void SetAggregateValue(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 32;
        this.aggregateValue_ = str;
    }

    private void SetAggregateValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.aggregateValue_ = bytestring.tostringUtf8();
        this.bitField0_ |= 32;
    }

    private void SetdoubleValue(double d) {
        this.bitField0_ |= 8;
        this.doubleValue_ = d;
    }

    private void SetIdentifierValue(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.identifierValue_ = str;
    }

    private void SetIdentifierValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.identifierValue_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    private void SetName(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart descriptorProtos$UninterpretedOption$NamePart) {
        descriptorProtos$UninterpretedOption$NamePart.GetType();
        ensureNameIsMutable();
        this.name_.set(i, descriptorProtos$UninterpretedOption$NamePart);
    }

    private void SetNegativeIntValue(long j) {
        this.bitField0_ |= 4;
        this.negativeIntValue_ = j;
    }

    private void SetPositiveIntValue(long j) {
        this.bitField0_ |= 2;
        this.positiveIntValue_ = j;
    }

    private void SetstringValue(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        bytestring.GetType();
        this.bitField0_ |= 16;
        this.stringValue_ = bytestring;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((11 + 25) % 25 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0007\u0000\u0001\u0002\b\u0007\u0000\u0001\u0001\u0002Л\u0003ဈ\u0000\u0004ဃ\u0001\u0005ဂ\u0002\u0006က\u0003\u0007ည\u0004\bဈ\u0005", new java.lang.object[]{"bitField0_", "name_", androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart.class, "identifierValue_", "positiveIntValue_", "negativeIntValue_", "doubleValue_", "stringValue_", "aggregateValue_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption.class) {
                    try {
                        generatedMessageLite$DefaultInstanceBasedParser = PARSER;
                        if (generatedMessageLite$DefaultInstanceBasedParser is null) {
                            generatedMessageLite$DefaultInstanceBasedParser = new androidx.datastore.preferences.protobuf.GeneratedMessageLite$DefaultInstanceBasedParser(DEFAULT_INSTANCE);
                            PARSER = generatedMessageLite$DefaultInstanceBasedParser;
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                    break;
                }
                return generatedMessageLite$DefaultInstanceBasedParser;
            case 6:
                return java.lang.byte.valueOf(this.memoizedIsInitialized);
            case 7:
                this.memoizedIsInitialized = (byte) (obj is not null ? 1 : 0);
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override java.lang.string GetAggregateValue() {
        return this.aggregateValue_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetAggregateValuebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.aggregateValue_);
    }

    public override double GetdoubleValue() {
        if ((12 + 21) % 21 > 0) {
        }
        return this.doubleValue_;
    }

    public override java.lang.string GetIdentifierValue() {
        return this.identifierValue_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetIdentifierValuebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.identifierValue_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart getName(int i) {
        return this.name_[i);
    }

    public override int GetNameCount() {
        return this.name_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePart> getNameList() {
        return this.name_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePartOrBuilder getNameOrBuilder(int i) {
        return this.name_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$UninterpretedOption$NamePartOrBuilder> getNameOrBuilderList() {
        return this.name_;
    }

    public override long GetNegativeIntValue() {
        if ((27 + 3) % 3 > 0) {
        }
        return this.negativeIntValue_;
    }

    public override long GetPositiveIntValue() {
        if ((5 + 28) % 28 > 0) {
        }
        return this.positiveIntValue_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetstringValue() {
        return this.stringValue_;
    }

    public override bool HasAggregateValue() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasdoubleValue() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasIdentifierValue() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasNegativeIntValue() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasPositiveIntValue() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasstringValue() {
        return (this.bitField0_ & 16) != 0;
    }
}

