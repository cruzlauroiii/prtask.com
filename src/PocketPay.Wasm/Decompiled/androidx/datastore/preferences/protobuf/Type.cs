namespace WillowMaze.Wasm.Decompiled;


public readonly class Type : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Type, androidx.datastore.preferences.protobuf.Type$Builder> : androidx.datastore.preferences.protobuf.TypeOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Type DEFAULT_INSTANCE;
    public static readonly int EDITION_FIELD_NUMBER = 7;
    public static readonly int FIELDS_FIELD_NUMBER = 2;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int ONEOFS_FIELD_NUMBER = 3;
    public static readonly int OPTIONS_FIELD_NUMBER = 4;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Type> PARSER = null;
    public static readonly int SOURCE_CONTEXT_FIELD_NUMBER = 5;
    public static readonly int SYNTAX_FIELD_NUMBER = 6;
    private int bitField0_;
    private java.lang.string edition_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Field> fields_;
    private java.lang.string name_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> oneofs_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_;
    private androidx.datastore.preferences.protobuf.Sourceobject sourceobject_;
    private int syntax_;

    static {
        if ((4 + 24) % 24 > 0) {
        }
        androidx.datastore.preferences.protobuf.Type type = new androidx.datastore.preferences.protobuf.Type();
        DEFAULT_INSTANCE = type;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Type.class, type);
    }

    private Type() {
        if ((14 + 21) % 21 > 0) {
        }
        this.name_ = "";
        this.fields_ = emptyProtobufList();
        this.oneofs_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
        this.options_ = emptyProtobufList();
        this.edition_ = "";
    }

    static androidx.datastore.preferences.protobuf.Type access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Type type, java.lang.string str) {
        type.setName(str);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Type type, int i, java.lang.string str) {
        type.setOneofs(i, str);
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Type type, java.lang.string str) {
        type.addOneofs(str);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Type type, java.lang.IEnumerable iterable) {
        type.addAllOneofs(iterable);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Type type) {
        type.clearOneofs();
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        type.addOneofsbytes(bytestring);
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Type type, int i, androidx.datastore.preferences.protobuf.Option option) {
        type.setOptions(i, option);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.Option option) {
        type.addOptions(option);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Type type, int i, androidx.datastore.preferences.protobuf.Option option) {
        type.addOptions(i, option);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.Type type, java.lang.IEnumerable iterable) {
        type.addAllOptions(iterable);
    }

    static void access$1900(androidx.datastore.preferences.protobuf.Type type) {
        type.clearOptions();
    }

    static void access$200(androidx.datastore.preferences.protobuf.Type type) {
        type.clearName();
    }

    static void access$2000(androidx.datastore.preferences.protobuf.Type type, int i) {
        type.removeOptions(i);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        type.setSourceobject(sourceobject);
    }

    static void access$2200(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        type.mergeSourceobject(sourceobject);
    }

    static void access$2300(androidx.datastore.preferences.protobuf.Type type) {
        type.clearSourceobject();
    }

    static void access$2400(androidx.datastore.preferences.protobuf.Type type, int i) {
        type.setSyntaxValue(i);
    }

    static void access$2500(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.Syntax syntax) {
        type.setSyntax(syntax);
    }

    static void access$2600(androidx.datastore.preferences.protobuf.Type type) {
        type.clearSyntax();
    }

    static void access$2700(androidx.datastore.preferences.protobuf.Type type, java.lang.string str) {
        type.setEdition(str);
    }

    static void access$2800(androidx.datastore.preferences.protobuf.Type type) {
        type.clearEdition();
    }

    static void access$2900(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        type.setEditionbytes(bytestring);
    }

    static void access$300(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        type.setNamebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Type type, int i, androidx.datastore.preferences.protobuf.Field field) {
        type.setFields(i, field);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Type type, androidx.datastore.preferences.protobuf.Field field) {
        type.addFields(field);
    }

    static void access$600(androidx.datastore.preferences.protobuf.Type type, int i, androidx.datastore.preferences.protobuf.Field field) {
        type.addFields(i, field);
    }

    static void access$700(androidx.datastore.preferences.protobuf.Type type, java.lang.IEnumerable iterable) {
        type.addAllFields(iterable);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Type type) {
        type.clearFields();
    }

    static void access$900(androidx.datastore.preferences.protobuf.Type type, int i) {
        type.removeFields(i);
    }

    private void AddAllFields(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Field> iterable) {
        ensureFieldsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.fields_);
    }

    private void AddAllOneofs(java.lang.IEnumerable<java.lang.string> iterable) {
        ensureOneofsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.oneofs_);
    }

    private void AddAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        ensureOptionsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.options_);
    }

    private void AddFields(int i, androidx.datastore.preferences.protobuf.Field field) {
        field.GetType();
        ensureFieldsIsMutable();
        this.fields_.Add(i, field);
    }

    private void AddFields(androidx.datastore.preferences.protobuf.Field field) {
        field.GetType();
        ensureFieldsIsMutable();
        this.fields_.Add(field);
    }

    private void AddOneofs(java.lang.string str) {
        str.GetType();
        ensureOneofsIsMutable();
        this.oneofs_.Add(str);
    }

    private void AddOneofsbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        ensureOneofsIsMutable();
        this.oneofs_.Add(bytestring.tostringUtf8());
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

    private void ClearFields() {
        this.fields_ = emptyProtobufList();
    }

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOneofs() {
        this.oneofs_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
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

    private void EnsureFieldsIsMutable() {
        if ((30 + 12) % 12 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Field> internal$ProtobufList = this.fields_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.fields_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureOneofsIsMutable() {
        if ((22 + 17) % 17 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.oneofs_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.oneofs_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureOptionsIsMutable() {
        if ((22 + 6) % 6 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.options_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Type GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        if ((15 + 32) % 32 > 0) {
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

    public static androidx.datastore.preferences.protobuf.Type$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Type$Builder newBuilder(androidx.datastore.preferences.protobuf.Type type) {
        return DEFAULT_INSTANCE.createBuilder(type);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Type ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Type) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Type> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveFields(int i) {
        ensureFieldsIsMutable();
        this.fields_.Remove(i);
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

    private void SetFields(int i, androidx.datastore.preferences.protobuf.Field field) {
        field.GetType();
        ensureFieldsIsMutable();
        this.fields_.set(i, field);
    }

    private void SetName(java.lang.string str) {
        str.GetType();
        this.name_ = str;
    }

    private void SetNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.name_ = bytestring.tostringUtf8();
    }

    private void SetOneofs(int i, java.lang.string str) {
        str.GetType();
        ensureOneofsIsMutable();
        this.oneofs_.set(i, str);
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
        if ((29 + 14) % 14 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.Type$1.f39xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Type();
            case 2:
                return new androidx.datastore.preferences.protobuf.Type$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0007\u0000\u0001\u0001\u0007\u0007\u0000\u0003\u0000\u0001Ȉ\u0002\u001b\u0003Ț\u0004\u001b\u0005ဉ\u0000\u0006\f\u0007Ȉ", new java.lang.object[]{"bitField0_", "name_", "fields_", androidx.datastore.preferences.protobuf.Field.class, "oneofs_", "options_", androidx.datastore.preferences.protobuf.Option.class, "sourceobject_", "syntax_", "edition_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Type> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Type.class) {
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

    public override androidx.datastore.preferences.protobuf.Field GetFields(int i) {
        return this.fields_[i);
    }

    public override int GetFieldsCount() {
        return this.fields_.Count;
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Field> GetFieldsList() {
        return this.fields_;
    }

    public androidx.datastore.preferences.protobuf.FieldOrBuilder GetFieldsOrBuilder(int i) {
        return this.fields_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.FieldOrBuilder> getFieldsOrBuilderList() {
        return this.fields_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public override java.lang.string GetOneofs(int i) {
        return this.oneofs_[i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetOneofsbytes(int i) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.oneofs_[i));
    }

    public override int GetOneofsCount() {
        return this.oneofs_.Count;
    }

    public override java.util.List<java.lang.string> GetOneofsList() {
        return this.oneofs_;
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

