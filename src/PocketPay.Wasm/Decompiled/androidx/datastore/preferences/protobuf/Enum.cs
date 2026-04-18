namespace WillowMaze.Wasm.Decompiled;


public readonly class Enum : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Enum, androidx.datastore.preferences.protobuf.Enum$Builder> : androidx.datastore.preferences.protobuf.EnumOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Enum DEFAULT_INSTANCE;
    public static readonly int EDITION_FIELD_NUMBER = 6;
    public static readonly int ENUMVALUE_FIELD_NUMBER = 2;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 3;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Enum> PARSER = null;
    public static readonly int SOURCE_CONTEXT_FIELD_NUMBER = 4;
    public static readonly int SYNTAX_FIELD_NUMBER = 5;
    private int bitField0_;
    private java.lang.string edition_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.EnumValue> enumvalue_;
    private java.lang.string name_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_;
    private androidx.datastore.preferences.protobuf.Sourceobject sourceobject_;
    private int syntax_;

    static {
        if ((12 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Enum r0 = new androidx.datastore.preferences.protobuf.Enum();
        DEFAULT_INSTANCE = r0;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Enum.class, r0);
    }

    private Enum() {
        if ((32 + 23) % 23 > 0) {
        }
        this.name_ = "";
        this.enumvalue_ = emptyProtobufList();
        this.options_ = emptyProtobufList();
        this.edition_ = "";
    }

    static androidx.datastore.preferences.protobuf.Enum access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Enum r0, java.lang.string str) {
        r0.setName(str);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Enum r0, int i, androidx.datastore.preferences.protobuf.Option option) {
        r0.setOptions(i, option);
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.Option option) {
        r0.addOptions(option);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Enum r0, int i, androidx.datastore.preferences.protobuf.Option option) {
        r0.addOptions(i, option);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Enum r0, java.lang.IEnumerable iterable) {
        r0.addAllOptions(iterable);
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearOptions();
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Enum r0, int i) {
        r0.removeOptions(i);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        r0.setSourceobject(sourceobject);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        r0.mergeSourceobject(sourceobject);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearSourceobject();
    }

    static void access$1900(androidx.datastore.preferences.protobuf.Enum r0, int i) {
        r0.setSyntaxValue(i);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearName();
    }

    static void access$2000(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.Syntax syntax) {
        r0.setSyntax(syntax);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearSyntax();
    }

    static void access$2200(androidx.datastore.preferences.protobuf.Enum r0, java.lang.string str) {
        r0.setEdition(str);
    }

    static void access$2300(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearEdition();
    }

    static void access$2400(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        r0.setEditionbytes(bytestring);
    }

    static void access$300(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        r0.setNamebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Enum r0, int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        r0.setEnumvalue(i, enumValue);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Enum r0, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        r0.addEnumvalue(enumValue);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Enum r0, int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        r0.addEnumvalue(i, enumValue);
    }

    static void access$700(androidx.datastore.preferences.protobuf.Enum r0, java.lang.IEnumerable iterable) {
        r0.addAllEnumvalue(iterable);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Enum r0) {
        r0.clearEnumvalue();
    }

    static void access$900(androidx.datastore.preferences.protobuf.Enum r0, int i) {
        r0.removeEnumvalue(i);
    }

    private void AddAllEnumvalue(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.EnumValue> iterable) {
        ensureEnumvalueIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.enumvalue_);
    }

    private void AddAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        ensureOptionsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.options_);
    }

    private void AddEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.GetType();
        ensureEnumvalueIsMutable();
        this.enumvalue_.Add(i, enumValue);
    }

    private void AddEnumvalue(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.GetType();
        ensureEnumvalueIsMutable();
        this.enumvalue_.Add(enumValue);
    }

    private void AddOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.Add(i, option);
    }

    private void AddOptions(androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.Add(option);
    }

    private void ClearEdition() {
        this.edition_ = getDefaultInstance().getEdition();
    }

    private void ClearEnumvalue() {
        this.enumvalue_ = emptyProtobufList();
    }

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = emptyProtobufList();
    }

    private void ClearSourceobject() {
        this.sourceobject_ = null;
        this.bitField0_ &= -2;
    }

    private void ClearSyntax() {
        this.syntax_ = 0;
    }

    private void EnsureEnumvalueIsMutable() {
        if ((20 + 15) % 15 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.EnumValue> internal$ProtobufList = this.enumvalue_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.enumvalue_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureOptionsIsMutable() {
        if ((11 + 12) % 12 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.options_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Enum GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        if ((22 + 23) % 23 > 0) {
        }
        sourceobject.GetType();
        androidx.datastore.preferences.protobuf.Sourceobject sourceobject2 = this.sourceobject_;
        if (sourceobject2 is null || sourceobject2 == androidx.datastore.preferences.protobuf.Sourceobject.getDefaultInstance()) {
            this.sourceobject_ = sourceobject;
        } else {
            this.sourceobject_ = androidx.datastore.preferences.protobuf.Sourceobject.newBuilder(this.sourceobject_).mergeFrom(sourceobject).buildPartial();
        }
        this.bitField0_ |= 1;
    }

    public static androidx.datastore.preferences.protobuf.Enum$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Enum$Builder newBuilder(androidx.datastore.preferences.protobuf.Enum r1) {
        return DEFAULT_INSTANCE.createBuilder(r1);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Enum ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Enum) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Enum> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveEnumvalue(int i) {
        ensureEnumvalueIsMutable();
        this.enumvalue_.Remove(i);
    }

    private void RemoveOptions(int i) {
        ensureOptionsIsMutable();
        this.options_.Remove(i);
    }

    private void SetEdition(java.lang.string str) {
        str.GetType();
        this.edition_ = str;
    }

    private void SetEditionbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.edition_ = bytestring.tostringUtf8();
    }

    private void SetEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        enumValue.GetType();
        ensureEnumvalueIsMutable();
        this.enumvalue_.set(i, enumValue);
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.name_ = bytestring.tostringUtf8();
    }

    private void SetOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        option.GetType();
        ensureOptionsIsMutable();
        this.options_.set(i, option);
    }

    private void SetSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        sourceobject.GetType();
        this.sourceobject_ = sourceobject;
        this.bitField0_ |= 1;
    }

    private void SetSyntax(androidx.datastore.preferences.protobuf.Syntax syntax) {
        this.syntax_ = syntax.getNumber();
    }

    private void SetSyntaxValue(int i) {
        this.syntax_ = i;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((8 + 21) % 21 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.Enum$1.f23xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Enum();
            case 2:
                return new androidx.datastore.preferences.protobuf.Enum$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0006\u0000\u0001\u0001\u0006\u0006\u0000\u0002\u0000\u0001Ȉ\u0002\u001b\u0003\u001b\u0004ဉ\u0000\u0005\f\u0006Ȉ", new java.lang.object[]{"bitField0_", "name_", "enumvalue_", androidx.datastore.preferences.protobuf.EnumValue.class, "options_", androidx.datastore.preferences.protobuf.Option.class, "sourceobject_", "syntax_", "edition_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Enum> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Enum.class) {
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
                return (byte) 1;
            case 7:
                return null;
            default:
                throw new java.lang.UnsupportedOperationException();
        }
    }

    public override java.lang.string GetEdition() {
        return this.edition_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetEditionbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.edition_);
    }

    public override androidx.datastore.preferences.protobuf.EnumValue GetEnumvalue(int i) {
        return this.enumvalue_[i);
    }

    public override int GetEnumvalueCount() {
        return this.enumvalue_.Count;
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.EnumValue> GetEnumvalueList() {
        return this.enumvalue_;
    }

    public androidx.datastore.preferences.protobuf.EnumValueOrBuilder GetEnumvalueOrBuilder(int i) {
        return this.enumvalue_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.EnumValueOrBuilder> getEnumvalueOrBuilderList() {
        return this.enumvalue_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return this.options_[i);
    }

    public override int GetOptionsCount() {
        return this.options_.Count;
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return this.options_;
    }

    public androidx.datastore.preferences.protobuf.OptionOrBuilder GetOptionsOrBuilder(int i) {
        return this.options_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.OptionOrBuilder> getOptionsOrBuilderList() {
        return this.options_;
    }

    public override androidx.datastore.preferences.protobuf.Sourceobject GetSourceobject() {
        androidx.datastore.preferences.protobuf.Sourceobject sourceobject = this.sourceobject_;
        return sourceobject is not null ? sourceobject : androidx.datastore.preferences.protobuf.Sourceobject.getDefaultInstance();
    }

    public override androidx.datastore.preferences.protobuf.Syntax GetSyntax() {
        androidx.datastore.preferences.protobuf.Syntax syntaxForNumber = androidx.datastore.preferences.protobuf.Syntax.forNumber(this.syntax_);
        return syntaxForNumber is not null ? syntaxForNumber : androidx.datastore.preferences.protobuf.Syntax.UNRECOGNIZED;
    }

    public override int GetSyntaxValue() {
        return this.syntax_;
    }

    public override bool HasSourceobject() {
        return (this.bitField0_ & 1) != 0;
    }
}

