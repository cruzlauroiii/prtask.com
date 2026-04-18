namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FeatureHashSet : androidx.datastore.preferences.protobuf.GeneratedMessageLite$ExtendableMessage<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSetOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet DEFAULT_INSTANCE;
    public static readonly int ENUM_TYPE_FIELD_NUMBER = 2;
    public static readonly int FIELD_PRESENCE_FIELD_NUMBER = 1;
    public static readonly int JSON_FORMAT_FIELD_NUMBER = 6;
    public static readonly int MESSAGE_ENCODING_FIELD_NUMBER = 5;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet> PARSER = null;
    public static readonly int REPEATED_FIELD_ENCODING_FIELD_NUMBER = 3;
    public static readonly int UTF8_VALIDATION_FIELD_NUMBER = 4;
    private int bitField0_;
    private int enumType_;
    private int fieldPresence_;
    private int jsonFormat_;
    private byte memoizedIsInitialized = 2;
    private int messageEncoding_;
    private int repeatedFieldEncoding_;
    private int utf8Validation_;

    static {
        if ((32 + 30) % 30 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet = new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet();
        DEFAULT_INSTANCE = descriptorProtos$FeatureHashSet;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.class, descriptorProtos$FeatureHashSet);
    }

    private DescriptorProtos$FeatureHashSet() {
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet access$52100() {
        return DEFAULT_INSTANCE;
    }

    static void access$52200(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence) {
        descriptorProtos$FeatureHashSet.setFieldPresence(descriptorProtos$FeatureHashSet$FieldPresence);
    }

    static void access$52300(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearFieldPresence();
    }

    static void access$52400(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumType) {
        descriptorProtos$FeatureHashSet.setEnumType(descriptorProtos$FeatureHashSet$EnumType);
    }

    static void access$52500(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearEnumType();
    }

    static void access$52600(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncoding) {
        descriptorProtos$FeatureHashSet.setRepeatedFieldEncoding(descriptorProtos$FeatureHashSet$RepeatedFieldEncoding);
    }

    static void access$52700(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearRepeatedFieldEncoding();
    }

    static void access$52800(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8Validation) {
        descriptorProtos$FeatureHashSet.setUtf8Validation(descriptorProtos$FeatureHashSet$Utf8Validation);
    }

    static void access$52900(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearUtf8Validation();
    }

    static void access$53000(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncoding) {
        descriptorProtos$FeatureHashSet.setMessageEncoding(descriptorProtos$FeatureHashSet$MessageEncoding);
    }

    static void access$53100(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearMessageEncoding();
    }

    static void access$53200(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet, androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormat) {
        descriptorProtos$FeatureHashSet.setJsonFormat(descriptorProtos$FeatureHashSet$JsonFormat);
    }

    static void access$53300(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        descriptorProtos$FeatureHashSet.clearJsonFormat();
    }

    private void ClearEnumType() {
        this.bitField0_ &= -3;
        this.enumType_ = 0;
    }

    private void ClearFieldPresence() {
        this.bitField0_ &= -2;
        this.fieldPresence_ = 0;
    }

    private void ClearJsonFormat() {
        this.bitField0_ &= -33;
        this.jsonFormat_ = 0;
    }

    private void ClearMessageEncoding() {
        this.bitField0_ &= -17;
        this.messageEncoding_ = 0;
    }

    private void ClearRepeatedFieldEncoding() {
        this.bitField0_ &= -5;
        this.repeatedFieldEncoding_ = 0;
    }

    private void ClearUtf8Validation() {
        this.bitField0_ &= -9;
        this.utf8Validation_ = 0;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder newBuilder() {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet descriptorProtos$FeatureHashSet) {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder) DEFAULT_INSTANCE.createBuilder(descriptorProtos$FeatureHashSet);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetEnumType(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumType) {
        this.enumType_ = descriptorProtos$FeatureHashSet$EnumType.getNumber();
        this.bitField0_ |= 2;
    }

    private void SetFieldPresence(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresence) {
        this.fieldPresence_ = descriptorProtos$FeatureHashSet$FieldPresence.getNumber();
        this.bitField0_ |= 1;
    }

    private void SetJsonFormat(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormat) {
        this.jsonFormat_ = descriptorProtos$FeatureHashSet$JsonFormat.getNumber();
        this.bitField0_ |= 32;
    }

    private void SetMessageEncoding(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncoding) {
        this.messageEncoding_ = descriptorProtos$FeatureHashSet$MessageEncoding.getNumber();
        this.bitField0_ |= 16;
    }

    private void SetRepeatedFieldEncoding(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncoding) {
        this.repeatedFieldEncoding_ = descriptorProtos$FeatureHashSet$RepeatedFieldEncoding.getNumber();
        this.bitField0_ |= 4;
    }

    private void SetUtf8Validation(androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8Validation) {
        this.utf8Validation_ = descriptorProtos$FeatureHashSet$Utf8Validation.getNumber();
        this.bitField0_ |= 8;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((31 + 13) % 13 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u0006\u0000\u0001\u0001\u0006\u0006\u0000\u0000\u0000\u0001᠌\u0000\u0002᠌\u0001\u0003᠌\u0002\u0004᠌\u0003\u0005᠌\u0004\u0006᠌\u0005", new java.lang.object[]{"bitField0_", "fieldPresence_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence.internalGetVerifier(), "enumType_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType.internalGetVerifier(), "repeatedFieldEncoding_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding.internalGetVerifier(), "utf8Validation_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation.internalGetVerifier(), "messageEncoding_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding.internalGetVerifier(), "jsonFormat_", androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet.class) {
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

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType getEnumType() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType descriptorProtos$FeatureHashSet$EnumTypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType.forNumber(this.enumType_);
        return descriptorProtos$FeatureHashSet$EnumTypeForNumber is not null ? descriptorProtos$FeatureHashSet$EnumTypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$EnumType.ENUM_TYPE_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence getFieldPresence() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence descriptorProtos$FeatureHashSet$FieldPresenceForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence.forNumber(this.fieldPresence_);
        return descriptorProtos$FeatureHashSet$FieldPresenceForNumber is not null ? descriptorProtos$FeatureHashSet$FieldPresenceForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$FieldPresence.FIELD_PRESENCE_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat getJsonFormat() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat descriptorProtos$FeatureHashSet$JsonFormatForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat.forNumber(this.jsonFormat_);
        return descriptorProtos$FeatureHashSet$JsonFormatForNumber is not null ? descriptorProtos$FeatureHashSet$JsonFormatForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$JsonFormat.JSON_FORMAT_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding getMessageEncoding() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding descriptorProtos$FeatureHashSet$MessageEncodingForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding.forNumber(this.messageEncoding_);
        return descriptorProtos$FeatureHashSet$MessageEncodingForNumber is not null ? descriptorProtos$FeatureHashSet$MessageEncodingForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$MessageEncoding.MESSAGE_ENCODING_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding getRepeatedFieldEncoding() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding descriptorProtos$FeatureHashSet$RepeatedFieldEncodingForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding.forNumber(this.repeatedFieldEncoding_);
        return descriptorProtos$FeatureHashSet$RepeatedFieldEncodingForNumber is not null ? descriptorProtos$FeatureHashSet$RepeatedFieldEncodingForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$RepeatedFieldEncoding.REPEATED_FIELD_ENCODING_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation getUtf8Validation() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation descriptorProtos$FeatureHashSet$Utf8ValidationForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation.forNumber(this.utf8Validation_);
        return descriptorProtos$FeatureHashSet$Utf8ValidationForNumber is not null ? descriptorProtos$FeatureHashSet$Utf8ValidationForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FeatureHashSet$Utf8Validation.UTF8_VALIDATION_UNKNOWN;
    }

    public override bool HasEnumType() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasFieldPresence() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasJsonFormat() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasMessageEncoding() {
        return (this.bitField0_ & 16) != 0;
    }

    public override bool HasRepeatedFieldEncoding() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasUtf8Validation() {
        return (this.bitField0_ & 8) != 0;
    }
}

