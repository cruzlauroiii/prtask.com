namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$FieldDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto DEFAULT_INSTANCE;
    public static readonly int DEFAULT_VALUE_FIELD_NUMBER = 7;
    public static readonly int EXTENDEE_FIELD_NUMBER = 2;
    public static readonly int JSON_NAME_FIELD_NUMBER = 10;
    public static readonly int LABEL_FIELD_NUMBER = 4;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int NUMBER_FIELD_NUMBER = 3;
    public static readonly int ONEOF_INDEX_FIELD_NUMBER = 9;
    public static readonly int OPTIONS_FIELD_NUMBER = 8;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> PARSER = null;
    public static readonly int PROTO3_OPTIONAL_FIELD_NUMBER = 17;
    public static readonly int TYPE_FIELD_NUMBER = 5;
    public static readonly int TYPE_NAME_FIELD_NUMBER = 6;
    private int bitField0_;
    private java.lang.string defaultValue_;
    private java.lang.string extendee_;
    private java.lang.string jsonName_;
    private int label_;
    private byte memoizedIsInitialized;
    private java.lang.string name_;
    private int number_;
    private int oneofIndex_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions options_;
    private bool proto3object?_;
    private java.lang.string typeName_;
    private int type_;

    static {
        if ((16 + 31) % 31 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$FieldDescriptorProto;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto.class, descriptorProtos$FieldDescriptorProto);
    }

    private DescriptorProtos$FieldDescriptorProto() {
        if ((20 + 12) % 12 > 0) {
        }
        this.memoizedIsInitialized = (byte) 2;
        this.name_ = "";
        this.label_ = 1;
        this.type_ = 1;
        this.typeName_ = "";
        this.extendee_ = "";
        this.defaultValue_ = "";
        this.jsonName_ = "";
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto access$16700() {
        return DEFAULT_INSTANCE;
    }

    static void access$16800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, java.lang.string str) {
        descriptorProtos$FieldDescriptorProto.setName(str);
    }

    static void access$16900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearName();
    }

    static void access$17000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldDescriptorProto.setNamebytes(bytestring);
    }

    static void access$17100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, int i) {
        descriptorProtos$FieldDescriptorProto.setNumber(i);
    }

    static void access$17200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearNumber();
    }

    static void access$17300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$Label) {
        descriptorProtos$FieldDescriptorProto.setLabel(descriptorProtos$FieldDescriptorProto$Label);
    }

    static void access$17400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearLabel();
    }

    static void access$17500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type descriptorProtos$FieldDescriptorProto$Type) {
        descriptorProtos$FieldDescriptorProto.setType(descriptorProtos$FieldDescriptorProto$Type);
    }

    static void access$17600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearType();
    }

    static void access$17700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, java.lang.string str) {
        descriptorProtos$FieldDescriptorProto.setTypeName(str);
    }

    static void access$17800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearTypeName();
    }

    static void access$17900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldDescriptorProto.setTypeNamebytes(bytestring);
    }

    static void access$18000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, java.lang.string str) {
        descriptorProtos$FieldDescriptorProto.setExtendee(str);
    }

    static void access$18100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearExtendee();
    }

    static void access$18200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldDescriptorProto.setExtendeebytes(bytestring);
    }

    static void access$18300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, java.lang.string str) {
        descriptorProtos$FieldDescriptorProto.setDefaultValue(str);
    }

    static void access$18400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearDefaultValue();
    }

    static void access$18500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldDescriptorProto.setDefaultValuebytes(bytestring);
    }

    static void access$18600(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, int i) {
        descriptorProtos$FieldDescriptorProto.setOneofIndex(i);
    }

    static void access$18700(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearOneofIndex();
    }

    static void access$18800(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, java.lang.string str) {
        descriptorProtos$FieldDescriptorProto.setJsonName(str);
    }

    static void access$18900(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearJsonName();
    }

    static void access$19000(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$FieldDescriptorProto.setJsonNamebytes(bytestring);
    }

    static void access$19100(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldDescriptorProto.setOptions(descriptorProtos$FieldOptions);
    }

    static void access$19200(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldDescriptorProto.mergeOptions(descriptorProtos$FieldOptions);
    }

    static void access$19300(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearOptions();
    }

    static void access$19400(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto, bool z) {
        descriptorProtos$FieldDescriptorProto.setProto3object?(z);
    }

    static void access$19500(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.clearProto3object?();
    }

    private void ClearDefaultValue() {
        this.bitField0_ &= -65;
        this.defaultValue_ = getDefaultInstance().getDefaultValue();
    }

    private void ClearExtendee() {
        this.bitField0_ &= -33;
        this.extendee_ = getDefaultInstance().getExtendee();
    }

    private void ClearJsonName() {
        this.bitField0_ &= -257;
        this.jsonName_ = getDefaultInstance().getJsonName();
    }

    private void ClearLabel() {
        this.bitField0_ &= -5;
        this.label_ = 1;
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearNumber() {
        this.bitField0_ &= -3;
        this.number_ = 0;
    }

    private void ClearOneofIndex() {
        this.bitField0_ &= -129;
        this.oneofIndex_ = 0;
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -513;
    }

    private void clearProto3object?() {
        this.bitField0_ &= -1025;
        this.proto3object?_ = false;
    }

    private void ClearType() {
        this.bitField0_ &= -9;
        this.type_ = 1;
    }

    private void ClearTypeName() {
        this.bitField0_ &= -17;
        this.typeName_ = getDefaultInstance().getTypeName();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        if ((3 + 2) % 2 > 0) {
        }
        descriptorProtos$FieldOptions.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions2 = this.options_;
        if (descriptorProtos$FieldOptions2 is null || descriptorProtos$FieldOptions2 == androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions.getDefaultInstance()) {
            this.options_ = descriptorProtos$FieldOptions;
        } else {
            this.options_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions.newBuilder(this.options_).mergeFrom(descriptorProtos$FieldOptions)).buildPartial();
        }
        this.bitField0_ |= 512;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$FieldDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void SetDefaultValue(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 64;
        this.defaultValue_ = str;
    }

    private void SetDefaultValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.defaultValue_ = bytestring.tostringUtf8();
        this.bitField0_ |= 64;
    }

    private void SetExtendee(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 32;
        this.extendee_ = str;
    }

    private void SetExtendeebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.extendee_ = bytestring.tostringUtf8();
        this.bitField0_ |= 32;
    }

    private void SetJsonName(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 256;
        this.jsonName_ = str;
    }

    private void SetJsonNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.jsonName_ = bytestring.tostringUtf8();
        this.bitField0_ |= 256;
    }

    private void SetLabel(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$Label) {
        this.label_ = descriptorProtos$FieldDescriptorProto$Label.getNumber();
        this.bitField0_ |= 4;
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 1;
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.name_ = bytestring.tostringUtf8();
        this.bitField0_ |= 1;
    }

    private void SetNumber(int i) {
        this.bitField0_ |= 2;
        this.number_ = i;
    }

    private void SetOneofIndex(int i) {
        this.bitField0_ |= 128;
        this.oneofIndex_ = i;
    }

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions) {
        descriptorProtos$FieldOptions.GetType();
        this.options_ = descriptorProtos$FieldOptions;
        this.bitField0_ |= 512;
    }

    private void setProto3object?(bool z) {
        this.bitField0_ |= 1024;
        this.proto3object?_ = z;
    }

    private void SetType(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type descriptorProtos$FieldDescriptorProto$Type) {
        this.type_ = descriptorProtos$FieldDescriptorProto$Type.getNumber();
        this.bitField0_ |= 8;
    }

    private void SetTypeName(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 16;
        this.typeName_ = str;
    }

    private void SetTypeNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.typeName_ = bytestring.tostringUtf8();
        this.bitField0_ |= 16;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((13 + 25) % 25 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\u000b\u0000\u0001\u0001\u0011\u000b\u0000\u0000\u0001\u0001ဈ\u0000\u0002ဈ\u0005\u0003င\u0001\u0004᠌\u0002\u0005᠌\u0003\u0006ဈ\u0004\u0007ဈ\u0006\bᐉ\t\tင\u0007\nဈ\b\u0011ဇ\n", new java.lang.object[]{"bitField0_", "name_", "extendee_", "number_", "label_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label.internalGetVerifier(), "type_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type.internalGetVerifier(), "typeName_", "defaultValue_", "options_", "oneofIndex_", "jsonName_", "proto3object?_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto.class) {
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

    public override java.lang.string GetDefaultValue() {
        return this.defaultValue_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetDefaultValuebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.defaultValue_);
    }

    public override java.lang.string GetExtendee() {
        return this.extendee_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetExtendeebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.extendee_);
    }

    public override java.lang.string GetJsonName() {
        return this.jsonName_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetJsonNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.jsonName_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label getLabel() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label descriptorProtos$FieldDescriptorProto$LabelForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label.forNumber(this.label_);
        return descriptorProtos$FieldDescriptorProto$LabelForNumber is not null ? descriptorProtos$FieldDescriptorProto$LabelForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Label.LABEL_OPTIONAL;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public override int GetNumber() {
        return this.number_;
    }

    public override int GetOneofIndex() {
        return this.oneofIndex_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions descriptorProtos$FieldOptions = this.options_;
        return descriptorProtos$FieldOptions is not null ? descriptorProtos$FieldOptions : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldOptions.getDefaultInstance();
    }

    public bool getProto3object?() {
        return this.proto3object?_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type getType() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type descriptorProtos$FieldDescriptorProto$TypeForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type.forNumber(this.type_);
        return descriptorProtos$FieldDescriptorProto$TypeForNumber is not null ? descriptorProtos$FieldDescriptorProto$TypeForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto$Type.TYPE_DOUBLE;
    }

    public override java.lang.string GetTypeName() {
        return this.typeName_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetTypeNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.typeName_);
    }

    public override bool HasDefaultValue() {
        return (this.bitField0_ & 64) != 0;
    }

    public override bool HasExtendee() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasJsonName() {
        return (this.bitField0_ & 256) != 0;
    }

    public override bool HasLabel() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasNumber() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasOneofIndex() {
        return (this.bitField0_ & 128) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 512) != 0;
    }

    public bool hasProto3object?() {
        return (this.bitField0_ & 1024) != 0;
    }

    public override bool HasType() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasTypeName() {
        return (this.bitField0_ & 16) != 0;
    }
}

