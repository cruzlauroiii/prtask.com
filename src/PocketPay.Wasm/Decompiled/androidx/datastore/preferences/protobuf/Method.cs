namespace WillowMaze.Wasm.Decompiled;


public readonly class Method : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.Method, androidx.datastore.preferences.protobuf.Method$Builder> : androidx.datastore.preferences.protobuf.MethodOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.Method DEFAULT_INSTANCE;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 6;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Method> PARSER = null;
    public static readonly int REQUEST_STREAMING_FIELD_NUMBER = 3;
    public static readonly int REQUEST_TYPE_Uri_FIELD_NUMBER = 2;
    public static readonly int RESPONSE_STREAMING_FIELD_NUMBER = 5;
    public static readonly int RESPONSE_TYPE_Uri_FIELD_NUMBER = 4;
    public static readonly int SYNTAX_FIELD_NUMBER = 7;
    private bool requestStreaming_;
    private bool responseStreaming_;
    private int syntax_;
    private java.lang.string name_ = "";
    private java.lang.string requestTypeUrl_ = "";
    private java.lang.string responseTypeUrl_ = "";
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> options_ = emptyProtobufList();

    static {
        if ((14 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.Method method = new androidx.datastore.preferences.protobuf.Method();
        DEFAULT_INSTANCE = method;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.Method.class, method);
    }

    private Method() {
    }

    static androidx.datastore.preferences.protobuf.Method access$000() {
        return DEFAULT_INSTANCE;
    }

    static void access$100(androidx.datastore.preferences.protobuf.Method method, java.lang.string str) {
        method.setName(str);
    }

    static void access$1000(androidx.datastore.preferences.protobuf.Method method) {
        method.clearResponseTypeUrl();
    }

    static void access$1100(androidx.datastore.preferences.protobuf.Method method, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        method.setResponseTypeUrlbytes(bytestring);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.Method method, bool z) {
        method.setResponseStreaming(z);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.Method method) {
        method.clearResponseStreaming();
    }

    static void access$1400(androidx.datastore.preferences.protobuf.Method method, int i, androidx.datastore.preferences.protobuf.Option option) {
        method.setOptions(i, option);
    }

    static void access$1500(androidx.datastore.preferences.protobuf.Method method, androidx.datastore.preferences.protobuf.Option option) {
        method.addOptions(option);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.Method method, int i, androidx.datastore.preferences.protobuf.Option option) {
        method.addOptions(i, option);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.Method method, java.lang.IEnumerable iterable) {
        method.addAllOptions(iterable);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.Method method) {
        method.clearOptions();
    }

    static void access$1900(androidx.datastore.preferences.protobuf.Method method, int i) {
        method.removeOptions(i);
    }

    static void access$200(androidx.datastore.preferences.protobuf.Method method) {
        method.clearName();
    }

    static void access$2000(androidx.datastore.preferences.protobuf.Method method, int i) {
        method.setSyntaxValue(i);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.Method method, androidx.datastore.preferences.protobuf.Syntax syntax) {
        method.setSyntax(syntax);
    }

    static void access$2200(androidx.datastore.preferences.protobuf.Method method) {
        method.clearSyntax();
    }

    static void access$300(androidx.datastore.preferences.protobuf.Method method, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        method.setNamebytes(bytestring);
    }

    static void access$400(androidx.datastore.preferences.protobuf.Method method, java.lang.string str) {
        method.setRequestTypeUrl(str);
    }

    static void access$500(androidx.datastore.preferences.protobuf.Method method) {
        method.clearRequestTypeUrl();
    }

    static void access$600(androidx.datastore.preferences.protobuf.Method method, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        method.setRequestTypeUrlbytes(bytestring);
    }

    static void access$700(androidx.datastore.preferences.protobuf.Method method, bool z) {
        method.setRequestStreaming(z);
    }

    static void access$800(androidx.datastore.preferences.protobuf.Method method) {
        method.clearRequestStreaming();
    }

    static void access$900(androidx.datastore.preferences.protobuf.Method method, java.lang.string str) {
        method.setResponseTypeUrl(str);
    }

    private void AddAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        ensureOptionsIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.options_);
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

    private void ClearName() {
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = emptyProtobufList();
    }

    private void ClearRequestStreaming() {
        this.requestStreaming_ = false;
    }

    private void ClearRequestTypeUrl() {
        this.requestTypeUrl_ = getDefaultInstance().getRequestTypeUrl();
    }

    private void ClearResponseStreaming() {
        this.responseStreaming_ = false;
    }

    private void ClearResponseTypeUrl() {
        this.responseTypeUrl_ = getDefaultInstance().getResponseTypeUrl();
    }

    private void ClearSyntax() {
        this.syntax_ = 0;
    }

    private void EnsureOptionsIsMutable() {
        if ((9 + 28) % 28 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.Option> internal$ProtobufList = this.options_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.options_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    public static androidx.datastore.preferences.protobuf.Method GetDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    public static androidx.datastore.preferences.protobuf.Method$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.Method$Builder newBuilder(androidx.datastore.preferences.protobuf.Method method) {
        return DEFAULT_INSTANCE.createBuilder(method);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.Method ParseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.Method) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Method> Parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveOptions(int i) {
        ensureOptionsIsMutable();
        this.options_.Remove(i);
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

    private void SetRequestStreaming(bool z) {
        this.requestStreaming_ = z;
    }

    private void SetRequestTypeUrl(java.lang.string str) {
        str.GetType();
        this.requestTypeUrl_ = str;
    }

    private void SetRequestTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.requestTypeUrl_ = bytestring.tostringUtf8();
    }

    private void SetResponseStreaming(bool z) {
        this.responseStreaming_ = z;
    }

    private void SetResponseTypeUrl(java.lang.string str) {
        str.GetType();
        this.responseTypeUrl_ = str;
    }

    private void SetResponseTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        checkbytestringIsUtf8(bytestring);
        this.responseTypeUrl_ = bytestring.tostringUtf8();
    }

    private void SetSyntax(androidx.datastore.preferences.protobuf.Syntax syntax) {
        this.syntax_ = syntax.getNumber();
    }

    private void SetSyntaxValue(int i) {
        this.syntax_ = i;
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((29 + 21) % 21 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.Method$1.f32xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.Method();
            case 2:
                return new androidx.datastore.preferences.protobuf.Method$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0000\u0007\u0000\u0000\u0001\u0007\u0007\u0000\u0001\u0000\u0001Ȉ\u0002Ȉ\u0003\u0007\u0004Ȉ\u0005\u0007\u0006\u001b\u0007\f", new java.lang.object[]{"name_", "requestTypeUrl_", "requestStreaming_", "responseTypeUrl_", "responseStreaming_", "options_", androidx.datastore.preferences.protobuf.Option.class, "syntax_"});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.Method> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.Method.class) {
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

    public override bool GetRequestStreaming() {
        return this.requestStreaming_;
    }

    public override java.lang.string GetRequestTypeUrl() {
        return this.requestTypeUrl_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetRequestTypeUrlbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.requestTypeUrl_);
    }

    public override bool GetResponseStreaming() {
        return this.responseStreaming_;
    }

    public override java.lang.string GetResponseTypeUrl() {
        return this.responseTypeUrl_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetResponseTypeUrlbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.responseTypeUrl_);
    }

    public override androidx.datastore.preferences.protobuf.Syntax GetSyntax() {
        androidx.datastore.preferences.protobuf.Syntax syntaxForNumber = androidx.datastore.preferences.protobuf.Syntax.forNumber(this.syntax_);
        return syntaxForNumber is not null ? syntaxForNumber : androidx.datastore.preferences.protobuf.Syntax.UNRECOGNIZED;
    }

    public override int GetSyntaxValue() {
        return this.syntax_;
    }
}

