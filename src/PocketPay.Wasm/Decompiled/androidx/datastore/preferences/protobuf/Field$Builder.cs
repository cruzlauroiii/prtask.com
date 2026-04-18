namespace WillowMaze.Wasm.Decompiled;


public readonly class Field$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Field, androidx.datastore.preferences.protobuf.Field$Builder> : androidx.datastore.preferences.protobuf.FieldOrBuilder {
    private Field$Builder() {
        super(androidx.datastore.preferences.protobuf.Field.access$000());
    }

    Field$Builder(androidx.datastore.preferences.protobuf.Field$1 field$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Field$Builder addAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2200((androidx.datastore.preferences.protobuf.Field) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2100((androidx.datastore.preferences.protobuf.Field) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2100((androidx.datastore.preferences.protobuf.Field) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder addOptions(androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2000((androidx.datastore.preferences.protobuf.Field) this.instance, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder addOptions(androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2000((androidx.datastore.preferences.protobuf.Field) this.instance, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearCardinality() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$600((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearDefaultValue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2900((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearJsonName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2600((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearKind() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$300((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1000((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearNumber() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$800((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearOneofIndex() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1600((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearOptions() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2300((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearPacked() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1800((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder clearTypeUrl() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1300((androidx.datastore.preferences.protobuf.Field) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Cardinality getCardinality() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getCardinality();
    }

    public override int GetCardinalityValue() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getCardinalityValue();
    }

    public override java.lang.string GetDefaultValue() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getDefaultValue();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetDefaultValuebytes() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getDefaultValuebytes();
    }

    public override java.lang.string GetJsonName() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getJsonName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetJsonNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getJsonNamebytes();
    }

    public androidx.datastore.preferences.protobuf.Field$Kind getKind() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getKind();
    }

    public override int GetKindValue() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getKindValue();
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getNamebytes();
    }

    public override int GetNumber() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getNumber();
    }

    public override int GetOneofIndex() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getOneofIndex();
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getOptions(i);
    }

    public override int GetOptionsCount() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getOptionsCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.Field) this.instance).getOptionsList());
    }

    public override bool GetPacked() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getPacked();
    }

    public override java.lang.string GetTypeUrl() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getTypeUrl();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetTypeUrlbytes() {
        return ((androidx.datastore.preferences.protobuf.Field) this.instance).getTypeUrlbytes();
    }

    public androidx.datastore.preferences.protobuf.Field$Builder removeOptions(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2400((androidx.datastore.preferences.protobuf.Field) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setCardinality(androidx.datastore.preferences.protobuf.Field$Cardinality field$Cardinality) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$500((androidx.datastore.preferences.protobuf.Field) this.instance, field$Cardinality);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setCardinalityValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$400((androidx.datastore.preferences.protobuf.Field) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setDefaultValue(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2800((androidx.datastore.preferences.protobuf.Field) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setDefaultValuebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$3000((androidx.datastore.preferences.protobuf.Field) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setJsonName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2500((androidx.datastore.preferences.protobuf.Field) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setJsonNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$2700((androidx.datastore.preferences.protobuf.Field) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setKind(androidx.datastore.preferences.protobuf.Field$Kind field$Kind) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$200((androidx.datastore.preferences.protobuf.Field) this.instance, field$Kind);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setKindValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$100((androidx.datastore.preferences.protobuf.Field) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$900((androidx.datastore.preferences.protobuf.Field) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1100((androidx.datastore.preferences.protobuf.Field) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setNumber(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$700((androidx.datastore.preferences.protobuf.Field) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setOneofIndex(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1500((androidx.datastore.preferences.protobuf.Field) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1900((androidx.datastore.preferences.protobuf.Field) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1900((androidx.datastore.preferences.protobuf.Field) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setPacked(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1700((androidx.datastore.preferences.protobuf.Field) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setTypeUrl(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1200((androidx.datastore.preferences.protobuf.Field) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Field$Builder setTypeUrlbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Field.access$1400((androidx.datastore.preferences.protobuf.Field) this.instance, bytestring);
        return this;
    }
}

