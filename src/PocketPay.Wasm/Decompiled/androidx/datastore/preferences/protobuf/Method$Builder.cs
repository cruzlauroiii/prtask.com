namespace WillowMaze.Wasm.Decompiled;


public readonly class Method$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Method, androidx.datastore.preferences.protobuf.Method$Builder> : androidx.datastore.preferences.protobuf.MethodOrBuilder {
    private Method$Builder() {
        super(androidx.datastore.preferences.protobuf.Method.access$000());
    }

    Method$Builder(androidx.datastore.preferences.protobuf.Method$1 method$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Method$Builder addAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1700((androidx.datastore.preferences.protobuf.Method) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1600((androidx.datastore.preferences.protobuf.Method) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1600((androidx.datastore.preferences.protobuf.Method) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder addOptions(androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1500((androidx.datastore.preferences.protobuf.Method) this.instance, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder addOptions(androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1500((androidx.datastore.preferences.protobuf.Method) this.instance, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$200((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearOptions() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1800((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearRequestStreaming() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$800((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearRequestTypeUrl() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$500((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearResponseStreaming() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1300((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearResponseTypeUrl() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1000((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder clearSyntax() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$2200((androidx.datastore.preferences.protobuf.Method) this.instance);
        return this;
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getNamebytes();
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getOptions(i);
    }

    public override int GetOptionsCount() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getOptionsCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.Method) this.instance).getOptionsList());
    }

    public override bool GetRequestStreaming() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getRequestStreaming();
    }

    public override java.lang.string GetRequestTypeUrl() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getRequestTypeUrl();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetRequestTypeUrlbytes() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getRequestTypeUrlbytes();
    }

    public override bool GetResponseStreaming() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getResponseStreaming();
    }

    public override java.lang.string GetResponseTypeUrl() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getResponseTypeUrl();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetResponseTypeUrlbytes() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getResponseTypeUrlbytes();
    }

    public override androidx.datastore.preferences.protobuf.Syntax GetSyntax() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getSyntax();
    }

    public override int GetSyntaxValue() {
        return ((androidx.datastore.preferences.protobuf.Method) this.instance).getSyntaxValue();
    }

    public androidx.datastore.preferences.protobuf.Method$Builder removeOptions(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1900((androidx.datastore.preferences.protobuf.Method) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$100((androidx.datastore.preferences.protobuf.Method) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$300((androidx.datastore.preferences.protobuf.Method) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1400((androidx.datastore.preferences.protobuf.Method) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1400((androidx.datastore.preferences.protobuf.Method) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setRequestStreaming(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$700((androidx.datastore.preferences.protobuf.Method) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setRequestTypeUrl(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$400((androidx.datastore.preferences.protobuf.Method) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setRequestTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$600((androidx.datastore.preferences.protobuf.Method) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setResponseStreaming(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1200((androidx.datastore.preferences.protobuf.Method) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setResponseTypeUrl(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$900((androidx.datastore.preferences.protobuf.Method) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setResponseTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$1100((androidx.datastore.preferences.protobuf.Method) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setSyntax(androidx.datastore.preferences.protobuf.Syntax syntax) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$2100((androidx.datastore.preferences.protobuf.Method) this.instance, syntax);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Method$Builder setSyntaxValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Method.access$2000((androidx.datastore.preferences.protobuf.Method) this.instance, i);
        return this;
    }
}

