namespace WillowMaze.Wasm.Decompiled;


public readonly class JavaFeaturesProto$JavaFeatures$Builder : androidx.datastore.preferences.protobuf.GeneratedMessageLite$Builder<androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures, androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder> : androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeaturesOrBuilder {
    private JavaFeaturesProto$JavaFeatures$Builder() {
        super(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.access$000());
    }

    JavaFeaturesProto$JavaFeatures$Builder(androidx.datastore.preferences.protobuf.JavaFeaturesProto$1 javaFeaturesProto$1) {
        this();
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder clearLegacyClosedEnum() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.access$200((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance);
        return this;
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder clearUtf8Validation() {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.access$400((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance);
        return this;
    }

    public override bool GetLegacyClosedEnum() {
        return ((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance).getLegacyClosedEnum();
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation getUtf8Validation() {
        return ((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance).getUtf8Validation();
    }

    public override bool HasLegacyClosedEnum() {
        return ((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance).hasLegacyClosedEnum();
    }

    public override bool HasUtf8Validation() {
        return ((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance).hasUtf8Validation();
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder setLegacyClosedEnum(bool z) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.access$100((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance, z);
        return this;
    }

    public androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Builder setUtf8Validation(androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures$Utf8Validation javaFeaturesProto$JavaFeatures$Utf8Validation) {
        copyOnWrite();
        androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures.access$300((androidx.datastore.preferences.protobuf.JavaFeaturesProto$JavaFeatures) this.instance, javaFeaturesProto$JavaFeatures$Utf8Validation);
        return this;
    }
}

