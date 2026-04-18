namespace WillowMaze.Wasm.Decompiled;


public readonly class Enum$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.Enum, androidx.datastore.preferences.protobuf.Enum$Builder> : androidx.datastore.preferences.protobuf.EnumOrBuilder {
    private Enum$Builder() {
        super(androidx.datastore.preferences.protobuf.Enum.access$000());
    }

    Enum$Builder(androidx.datastore.preferences.protobuf.Enum$1 enum$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addAllEnumvalue(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.EnumValue> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$700((androidx.datastore.preferences.protobuf.Enum) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addAllOptions(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.Option> iterable) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1300((androidx.datastore.preferences.protobuf.Enum) this.instance, iterable);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue$Builder enumValue$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$600((androidx.datastore.preferences.protobuf.Enum) this.instance, i, enumValue$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$600((androidx.datastore.preferences.protobuf.Enum) this.instance, i, enumValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addEnumvalue(androidx.datastore.preferences.protobuf.EnumValue$Builder enumValue$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$500((androidx.datastore.preferences.protobuf.Enum) this.instance, enumValue$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addEnumvalue(androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$500((androidx.datastore.preferences.protobuf.Enum) this.instance, enumValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1200((androidx.datastore.preferences.protobuf.Enum) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1200((androidx.datastore.preferences.protobuf.Enum) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addOptions(androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1100((androidx.datastore.preferences.protobuf.Enum) this.instance, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder addOptions(androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1100((androidx.datastore.preferences.protobuf.Enum) this.instance, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearEdition() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$2300((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearEnumvalue() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$800((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearName() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$200((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearOptions() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1400((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearSourceobject() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1800((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder clearSyntax() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$2100((androidx.datastore.preferences.protobuf.Enum) this.instance);
        return this;
    }

    public override java.lang.string GetEdition() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getEdition();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetEditionbytes() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getEditionbytes();
    }

    public override androidx.datastore.preferences.protobuf.EnumValue GetEnumvalue(int i) {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getEnumvalue(i);
    }

    public override int GetEnumvalueCount() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getEnumvalueCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.EnumValue> GetEnumvalueList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.Enum) this.instance).getEnumvalueList());
    }

    public override java.lang.string GetName() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getName();
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getNamebytes();
    }

    public override androidx.datastore.preferences.protobuf.Option GetOptions(int i) {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getOptions(i);
    }

    public override int GetOptionsCount() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getOptionsCount();
    }

    public override java.util.List<androidx.datastore.preferences.protobuf.Option> GetOptionsList() {
        return java.util.ICollections.unmodifiableList(((androidx.datastore.preferences.protobuf.Enum) this.instance).getOptionsList());
    }

    public override androidx.datastore.preferences.protobuf.Sourceobject GetSourceobject() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getSourceobject();
    }

    public override androidx.datastore.preferences.protobuf.Syntax GetSyntax() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getSyntax();
    }

    public override int GetSyntaxValue() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).getSyntaxValue();
    }

    public override bool HasSourceobject() {
        return ((androidx.datastore.preferences.protobuf.Enum) this.instance).hasSourceobject();
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder mergeSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1700((androidx.datastore.preferences.protobuf.Enum) this.instance, sourceobject);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder removeEnumvalue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$900((androidx.datastore.preferences.protobuf.Enum) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder removeOptions(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1500((androidx.datastore.preferences.protobuf.Enum) this.instance, i);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setEdition(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$2200((androidx.datastore.preferences.protobuf.Enum) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setEditionbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$2400((androidx.datastore.preferences.protobuf.Enum) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue$Builder enumValue$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$400((androidx.datastore.preferences.protobuf.Enum) this.instance, i, enumValue$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setEnumvalue(int i, androidx.datastore.preferences.protobuf.EnumValue enumValue) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$400((androidx.datastore.preferences.protobuf.Enum) this.instance, i, enumValue);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setName(java.lang.string str) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$100((androidx.datastore.preferences.protobuf.Enum) this.instance, str);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setNamebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$300((androidx.datastore.preferences.protobuf.Enum) this.instance, bytestring);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option$Builder option$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1000((androidx.datastore.preferences.protobuf.Enum) this.instance, i, option$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setOptions(int i, androidx.datastore.preferences.protobuf.Option option) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1000((androidx.datastore.preferences.protobuf.Enum) this.instance, i, option);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setSourceobject(androidx.datastore.preferences.protobuf.Sourceobject$Builder sourceobject$Builder) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1600((androidx.datastore.preferences.protobuf.Enum) this.instance, sourceobject$Builder.build());
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setSourceobject(androidx.datastore.preferences.protobuf.Sourceobject sourceobject) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1600((androidx.datastore.preferences.protobuf.Enum) this.instance, sourceobject);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setSyntax(androidx.datastore.preferences.protobuf.Syntax syntax) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$2000((androidx.datastore.preferences.protobuf.Enum) this.instance, syntax);
        return this;
    }

    public androidx.datastore.preferences.protobuf.Enum$Builder setSyntaxValue(int i) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.Enum.access$1900((androidx.datastore.preferences.protobuf.Enum) this.instance, i);
        return this;
    }
}

