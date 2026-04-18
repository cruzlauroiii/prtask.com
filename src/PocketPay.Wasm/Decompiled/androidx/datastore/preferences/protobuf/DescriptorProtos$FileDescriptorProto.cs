namespace WillowMaze.Wasm.Decompiled;


public readonly class DescriptorProtos$stringDescriptorProto : androidx.datastore.preferences.protobuf.GeneratedMessageLite<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto$Builder> : androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProtoOrBuilder {
    private static readonly androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto DEFAULT_INSTANCE;
    public static readonly int DEPENDENCY_FIELD_NUMBER = 3;
    public static readonly int EDITION_FIELD_NUMBER = 14;
    public static readonly int ENUM_TYPE_FIELD_NUMBER = 5;
    public static readonly int EXTENSION_FIELD_NUMBER = 7;
    public static readonly int MESSAGE_TYPE_FIELD_NUMBER = 4;
    public static readonly int NAME_FIELD_NUMBER = 1;
    public static readonly int OPTIONS_FIELD_NUMBER = 8;
    public static readonly int PACKAGE_FIELD_NUMBER = 2;
    private static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> PARSER = null;
    public static readonly int PUBLIC_DEPENDENCY_FIELD_NUMBER = 10;
    public static readonly int SERVICE_FIELD_NUMBER = 6;
    public static readonly int SOURCE_CODE_INFO_FIELD_NUMBER = 9;
    public static readonly int SYNTAX_FIELD_NUMBER = 12;
    public static readonly int WEAK_DEPENDENCY_FIELD_NUMBER = 11;
    private int bitField0_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> dependency_;
    private int edition_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> enumType_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> extension_;
    private byte memoizedIsInitialized;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> messageType_;
    private java.lang.string name_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions options_;
    private java.lang.string package_;
    private androidx.datastore.preferences.protobuf.Internal$IntList publicDependency_;
    private androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> service_;
    private androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo sourceCodeInfo_;
    private java.lang.string syntax_;
    private androidx.datastore.preferences.protobuf.Internal$IntList weakDependency_;

    static {
        if ((22 + 30) % 30 > 0) {
        }
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto = new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto();
        DEFAULT_INSTANCE = descriptorProtos$stringDescriptorProto;
        androidx.datastore.preferences.protobuf.GeneratedMessageLite.registerDefaultInstance(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto.class, descriptorProtos$stringDescriptorProto);
    }

    private DescriptorProtos$stringDescriptorProto() {
        if ((16 + 11) % 11 > 0) {
        }
        this.memoizedIsInitialized = (byte) 2;
        this.name_ = "";
        this.package_ = "";
        this.dependency_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
        this.publicDependency_ = emptyIntList();
        this.weakDependency_ = emptyIntList();
        this.messageType_ = emptyProtobufList();
        this.enumType_ = emptyProtobufList();
        this.service_ = emptyProtobufList();
        this.extension_ = emptyProtobufList();
        this.syntax_ = "";
    }

    static void access$1000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearName();
    }

    static void access$1100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringDescriptorProto.setNamebytes(bytestring);
    }

    static void access$1200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.string str) {
        descriptorProtos$stringDescriptorProto.setPackage(str);
    }

    static void access$1300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearPackage();
    }

    static void access$1400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringDescriptorProto.setPackagebytes(bytestring);
    }

    static void access$1500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, java.lang.string str) {
        descriptorProtos$stringDescriptorProto.setDependency(i, str);
    }

    static void access$1600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.string str) {
        descriptorProtos$stringDescriptorProto.addDependency(str);
    }

    static void access$1700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllDependency(iterable);
    }

    static void access$1800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearDependency();
    }

    static void access$1900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringDescriptorProto.addDependencybytes(bytestring);
    }

    static void access$2000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, int i2) {
        descriptorProtos$stringDescriptorProto.setPublicDependency(i, i2);
    }

    static void access$2100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.addPublicDependency(i);
    }

    static void access$2200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllPublicDependency(iterable);
    }

    static void access$2300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearPublicDependency();
    }

    static void access$2400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, int i2) {
        descriptorProtos$stringDescriptorProto.setWeakDependency(i, i2);
    }

    static void access$2500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.addWeakDependency(i);
    }

    static void access$2600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllWeakDependency(iterable);
    }

    static void access$2700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearWeakDependency();
    }

    static void access$2800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$stringDescriptorProto.setMessageType(i, descriptorProtos$DescriptorProto);
    }

    static void access$2900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$stringDescriptorProto.addMessageType(descriptorProtos$DescriptorProto);
    }

    static void access$3000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$stringDescriptorProto.addMessageType(i, descriptorProtos$DescriptorProto);
    }

    static void access$3100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllMessageType(iterable);
    }

    static void access$3200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearMessageType();
    }

    static void access$3300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.removeMessageType(i);
    }

    static void access$3400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$stringDescriptorProto.setEnumType(i, descriptorProtos$EnumDescriptorProto);
    }

    static void access$3500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addEnumType(descriptorProtos$EnumDescriptorProto);
    }

    static void access$3600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addEnumType(i, descriptorProtos$EnumDescriptorProto);
    }

    static void access$3700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllEnumType(iterable);
    }

    static void access$3800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearEnumType();
    }

    static void access$3900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.removeEnumType(i);
    }

    static void access$4000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$stringDescriptorProto.setService(i, descriptorProtos$ServiceDescriptorProto);
    }

    static void access$4100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addService(descriptorProtos$ServiceDescriptorProto);
    }

    static void access$4200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addService(i, descriptorProtos$ServiceDescriptorProto);
    }

    static void access$4300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllService(iterable);
    }

    static void access$4400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearService();
    }

    static void access$4500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.removeService(i);
    }

    static void access$4600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$stringDescriptorProto.setExtension(i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$4700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addExtension(descriptorProtos$FieldDescriptorProto);
    }

    static void access$4800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$stringDescriptorProto.addExtension(i, descriptorProtos$FieldDescriptorProto);
    }

    static void access$4900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.IEnumerable iterable) {
        descriptorProtos$stringDescriptorProto.addAllExtension(iterable);
    }

    static void access$5000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearExtension();
    }

    static void access$5100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, int i) {
        descriptorProtos$stringDescriptorProto.removeExtension(i);
    }

    static void access$5200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringDescriptorProto.setOptions(descriptorProtos$stringOptions);
    }

    static void access$5300(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringDescriptorProto.mergeOptions(descriptorProtos$stringOptions);
    }

    static void access$5400(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearOptions();
    }

    static void access$5500(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        descriptorProtos$stringDescriptorProto.setSourceCodeInfo(descriptorProtos$SourceCodeInfo);
    }

    static void access$5600(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        descriptorProtos$stringDescriptorProto.mergeSourceCodeInfo(descriptorProtos$SourceCodeInfo);
    }

    static void access$5700(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearSourceCodeInfo();
    }

    static void access$5800(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.string str) {
        descriptorProtos$stringDescriptorProto.setSyntax(str);
    }

    static void access$5900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearSyntax();
    }

    static void access$6000(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.bytestring bytestring) {
        descriptorProtos$stringDescriptorProto.setSyntaxbytes(bytestring);
    }

    static void access$6100(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        descriptorProtos$stringDescriptorProto.setEdition(descriptorProtos$Edition);
    }

    static void access$6200(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        descriptorProtos$stringDescriptorProto.clearEdition();
    }

    static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto access$800() {
        return DEFAULT_INSTANCE;
    }

    static void access$900(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto, java.lang.string str) {
        descriptorProtos$stringDescriptorProto.setName(str);
    }

    private void AddAllDependency(java.lang.IEnumerable<java.lang.string> iterable) {
        ensureDependencyIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.dependency_);
    }

    private void AddAllEnumType(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> iterable) {
        ensureEnumTypeIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.enumType_);
    }

    private void AddAllExtension(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> iterable) {
        ensureExtensionIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.extension_);
    }

    private void AddAllMessageType(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> iterable) {
        ensureMessageTypeIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.messageType_);
    }

    private void AddAllPublicDependency(java.lang.IEnumerable<? : java.lang.int> iterable) {
        ensurePublicDependencyIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.publicDependency_);
    }

    private void AddAllService(java.lang.IEnumerable<? : androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> iterable) {
        ensureServiceIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.service_);
    }

    private void AddAllWeakDependency(java.lang.IEnumerable<? : java.lang.int> iterable) {
        ensureWeakDependencyIsMutable();
        androidx.datastore.preferences.protobuf.AbstractMessageLite.addAll(iterable, this.weakDependency_);
    }

    private void AddDependency(java.lang.string str) {
        str.GetType();
        ensureDependencyIsMutable();
        this.dependency_.Add(str);
    }

    private void AddDependencybytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        ensureDependencyIsMutable();
        this.dependency_.Add(bytestring.tostringUtf8());
    }

    private void AddEnumType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.GetType();
        ensureEnumTypeIsMutable();
        this.enumType_.Add(i, descriptorProtos$EnumDescriptorProto);
    }

    private void AddEnumType(androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.GetType();
        ensureEnumTypeIsMutable();
        this.enumType_.Add(descriptorProtos$EnumDescriptorProto);
    }

    private void AddExtension(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.GetType();
        ensureExtensionIsMutable();
        this.extension_.Add(i, descriptorProtos$FieldDescriptorProto);
    }

    private void AddExtension(androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.GetType();
        ensureExtensionIsMutable();
        this.extension_.Add(descriptorProtos$FieldDescriptorProto);
    }

    private void AddMessageType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.GetType();
        ensureMessageTypeIsMutable();
        this.messageType_.Add(i, descriptorProtos$DescriptorProto);
    }

    private void AddMessageType(androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.GetType();
        ensureMessageTypeIsMutable();
        this.messageType_.Add(descriptorProtos$DescriptorProto);
    }

    private void AddPublicDependency(int i) {
        ensurePublicDependencyIsMutable();
        this.publicDependency_.addInt(i);
    }

    private void AddService(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.GetType();
        ensureServiceIsMutable();
        this.service_.Add(i, descriptorProtos$ServiceDescriptorProto);
    }

    private void AddService(androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.GetType();
        ensureServiceIsMutable();
        this.service_.Add(descriptorProtos$ServiceDescriptorProto);
    }

    private void AddWeakDependency(int i) {
        ensureWeakDependencyIsMutable();
        this.weakDependency_.addInt(i);
    }

    private void ClearDependency() {
        this.dependency_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.emptyProtobufList();
    }

    private void ClearEdition() {
        this.bitField0_ &= -33;
        this.edition_ = 0;
    }

    private void ClearEnumType() {
        this.enumType_ = emptyProtobufList();
    }

    private void ClearExtension() {
        this.extension_ = emptyProtobufList();
    }

    private void ClearMessageType() {
        this.messageType_ = emptyProtobufList();
    }

    private void ClearName() {
        this.bitField0_ &= -2;
        this.name_ = getDefaultInstance().getName();
    }

    private void ClearOptions() {
        this.options_ = null;
        this.bitField0_ &= -5;
    }

    private void ClearPackage() {
        this.bitField0_ &= -3;
        this.package_ = getDefaultInstance().getPackage();
    }

    private void ClearPublicDependency() {
        this.publicDependency_ = emptyIntList();
    }

    private void ClearService() {
        this.service_ = emptyProtobufList();
    }

    private void ClearSourceCodeInfo() {
        this.sourceCodeInfo_ = null;
        this.bitField0_ &= -9;
    }

    private void ClearSyntax() {
        this.bitField0_ &= -17;
        this.syntax_ = getDefaultInstance().getSyntax();
    }

    private void ClearWeakDependency() {
        this.weakDependency_ = emptyIntList();
    }

    private void EnsureDependencyIsMutable() {
        if ((31 + 20) % 20 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<java.lang.string> internal$ProtobufList = this.dependency_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.dependency_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureEnumTypeIsMutable() {
        if ((12 + 29) % 29 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> internal$ProtobufList = this.enumType_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.enumType_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureExtensionIsMutable() {
        if ((4 + 27) % 27 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> internal$ProtobufList = this.extension_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.extension_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureMessageTypeIsMutable() {
        if ((27 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> internal$ProtobufList = this.messageType_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.messageType_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsurePublicDependencyIsMutable() {
        if ((13 + 26) % 26 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.publicDependency_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.publicDependency_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    private void EnsureServiceIsMutable() {
        if ((20 + 32) % 32 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$ProtobufList<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> internal$ProtobufList = this.service_;
        if (internal$ProtobufList.isModifiable()) {
            return;
        }
        this.service_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$ProtobufList);
    }

    private void EnsureWeakDependencyIsMutable() {
        if ((21 + 25) % 25 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList = this.weakDependency_;
        if (internal$IntList.isModifiable()) {
            return;
        }
        this.weakDependency_ = androidx.datastore.preferences.protobuf.GeneratedMessageLite.mutableCopy(internal$IntList);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto getDefaultInstance() {
        return DEFAULT_INSTANCE;
    }

    private void MergeOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        if ((10 + 2) % 2 > 0) {
        }
        descriptorProtos$stringOptions.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions2 = this.options_;
        if (descriptorProtos$stringOptions2 is null || descriptorProtos$stringOptions2 == androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions.getDefaultInstance()) {
            this.options_ = descriptorProtos$stringOptions;
        } else {
            this.options_ = ((androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions$Builder) androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions.newBuilder(this.options_).mergeFrom(descriptorProtos$stringOptions)).buildPartial();
        }
        this.bitField0_ |= 4;
    }

    private void MergeSourceCodeInfo(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        if ((25 + 31) % 31 > 0) {
        }
        descriptorProtos$SourceCodeInfo.GetType();
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo2 = this.sourceCodeInfo_;
        if (descriptorProtos$SourceCodeInfo2 is null || descriptorProtos$SourceCodeInfo2 == androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.getDefaultInstance()) {
            this.sourceCodeInfo_ = descriptorProtos$SourceCodeInfo;
        } else {
            this.sourceCodeInfo_ = androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.newBuilder(this.sourceCodeInfo_).mergeFrom(descriptorProtos$SourceCodeInfo).buildPartial();
        }
        this.bitField0_ |= 8;
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto$Builder newBuilder() {
        return DEFAULT_INSTANCE.createBuilder();
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto$Builder newBuilder(androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto descriptorProtos$stringDescriptorProto) {
        return DEFAULT_INSTANCE.createBuilder(descriptorProtos$stringDescriptorProto);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseDelimitedFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseDelimitedFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) parseDelimitedFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bytestring, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(androidx.datastore.preferences.protobuf.CodedStream codedStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, codedStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(java.io.Stream inputStream) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(java.io.Stream inputStream, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws java.io.IOException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, inputStream, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(java.nio.byteBuffer byteBuffer, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, byteBuffer, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(byte[] bArr) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr);
    }

    public static androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto parseFrom(byte[] bArr, androidx.datastore.preferences.protobuf.ExtensionRegistryLite extensionRegistryLite) throws androidx.datastore.preferences.protobuf.InvalidProtocolBufferException {
        return (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto) androidx.datastore.preferences.protobuf.GeneratedMessageLite.parseFrom(DEFAULT_INSTANCE, bArr, extensionRegistryLite);
    }

    public static androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> parser() {
        return DEFAULT_INSTANCE.getParserForType();
    }

    private void RemoveEnumType(int i) {
        ensureEnumTypeIsMutable();
        this.enumType_.Remove(i);
    }

    private void RemoveExtension(int i) {
        ensureExtensionIsMutable();
        this.extension_.Remove(i);
    }

    private void RemoveMessageType(int i) {
        ensureMessageTypeIsMutable();
        this.messageType_.Remove(i);
    }

    private void RemoveService(int i) {
        ensureServiceIsMutable();
        this.service_.Remove(i);
    }

    private void SetDependency(int i, java.lang.string str) {
        str.GetType();
        ensureDependencyIsMutable();
        this.dependency_.set(i, str);
    }

    private void SetEdition(androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$Edition) {
        this.edition_ = descriptorProtos$Edition.getNumber();
        this.bitField0_ |= 32;
    }

    private void SetEnumType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto descriptorProtos$EnumDescriptorProto) {
        descriptorProtos$EnumDescriptorProto.GetType();
        ensureEnumTypeIsMutable();
        this.enumType_.set(i, descriptorProtos$EnumDescriptorProto);
    }

    private void SetExtension(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto descriptorProtos$FieldDescriptorProto) {
        descriptorProtos$FieldDescriptorProto.GetType();
        ensureExtensionIsMutable();
        this.extension_.set(i, descriptorProtos$FieldDescriptorProto);
    }

    private void SetMessageType(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto descriptorProtos$DescriptorProto) {
        descriptorProtos$DescriptorProto.GetType();
        ensureMessageTypeIsMutable();
        this.messageType_.set(i, descriptorProtos$DescriptorProto);
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

    private void SetOptions(androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions) {
        descriptorProtos$stringOptions.GetType();
        this.options_ = descriptorProtos$stringOptions;
        this.bitField0_ |= 4;
    }

    private void SetPackage(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 2;
        this.package_ = str;
    }

    private void SetPackagebytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.package_ = bytestring.tostringUtf8();
        this.bitField0_ |= 2;
    }

    private void SetPublicDependency(int i, int i2) {
        ensurePublicDependencyIsMutable();
        this.publicDependency_.setInt(i, i2);
    }

    private void SetService(int i, androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto descriptorProtos$ServiceDescriptorProto) {
        descriptorProtos$ServiceDescriptorProto.GetType();
        ensureServiceIsMutable();
        this.service_.set(i, descriptorProtos$ServiceDescriptorProto);
    }

    private void SetSourceCodeInfo(androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo) {
        descriptorProtos$SourceCodeInfo.GetType();
        this.sourceCodeInfo_ = descriptorProtos$SourceCodeInfo;
        this.bitField0_ |= 8;
    }

    private void SetSyntax(java.lang.string str) {
        str.GetType();
        this.bitField0_ |= 16;
        this.syntax_ = str;
    }

    private void SetSyntaxbytes(androidx.datastore.preferences.protobuf.bytestring bytestring) {
        this.syntax_ = bytestring.tostringUtf8();
        this.bitField0_ |= 16;
    }

    private void SetWeakDependency(int i, int i2) {
        ensureWeakDependencyIsMutable();
        this.weakDependency_.setInt(i, i2);
    }

    protected override readonly java.lang.object DynamicMethod(androidx.datastore.preferences.protobuf.GeneratedMessageLite$MethodToInvoke generatedMessageLite$MethodToInvoke, java.lang.object obj, java.lang.object obj2) {
        androidx.datastore.preferences.protobuf.Parser generatedMessageLite$DefaultInstanceBasedParser;
        if ((15 + 28) % 28 > 0) {
        }
        switch (androidx.datastore.preferences.protobuf.DescriptorProtos$1.f19xa1df5c61[generatedMessageLite$MethodToInvoke.ordinal()]) {
            case 1:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto();
            case 2:
                return new androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto$Builder(null);
            case 3:
                return newMessageInfo(DEFAULT_INSTANCE, "\u0001\r\u0000\u0001\u0001\u000e\r\u0000\u0007\u0005\u0001ဈ\u0000\u0002ဈ\u0001\u0003\u001a\u0004Л\u0005Л\u0006Л\u0007Л\bᐉ\u0002\tဉ\u0003\n\u0016\u000b\u0016\fဈ\u0004\u000e᠌\u0005", new java.lang.object[]{"bitField0_", "name_", "package_", "dependency_", "messageType_", androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto.class, "enumType_", androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto.class, "service_", androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto.class, "extension_", androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto.class, "options_", "sourceCodeInfo_", "publicDependency_", "weakDependency_", "syntax_", "edition_", androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.internalGetVerifier()});
            case 4:
                return DEFAULT_INSTANCE;
            case 5:
                androidx.datastore.preferences.protobuf.Parser<androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto> parser = PARSER;
                if (parser is not null) {
                    return parser;
                }
                lock (androidx.datastore.preferences.protobuf.DescriptorProtos$stringDescriptorProto.class) {
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

    public override java.lang.string GetDependency(int i) {
        return this.dependency_[i);
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetDependencybytes(int i) {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.dependency_[i));
    }

    public override int GetDependencyCount() {
        return this.dependency_.Count;
    }

    public override java.util.List<java.lang.string> GetDependencyList() {
        return this.dependency_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$Edition getEdition() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$Edition descriptorProtos$EditionForNumber = androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.forNumber(this.edition_);
        return descriptorProtos$EditionForNumber is not null ? descriptorProtos$EditionForNumber : androidx.datastore.preferences.protobuf.DescriptorProtos$Edition.EDITION_UNKNOWN;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto getEnumType(int i) {
        return this.enumType_[i);
    }

    public override int GetEnumTypeCount() {
        return this.enumType_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProto> getEnumTypeList() {
        return this.enumType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder getEnumTypeOrBuilder(int i) {
        return this.enumType_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$EnumDescriptorProtoOrBuilder> getEnumTypeOrBuilderList() {
        return this.enumType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto getExtension(int i) {
        return this.extension_[i);
    }

    public override int GetExtensionCount() {
        return this.extension_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProto> getExtensionList() {
        return this.extension_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder getExtensionOrBuilder(int i) {
        return this.extension_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$FieldDescriptorProtoOrBuilder> getExtensionOrBuilderList() {
        return this.extension_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto getMessageType(int i) {
        return this.messageType_[i);
    }

    public override int GetMessageTypeCount() {
        return this.messageType_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProto> getMessageTypeList() {
        return this.messageType_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder getMessageTypeOrBuilder(int i) {
        return this.messageType_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$DescriptorProtoOrBuilder> getMessageTypeOrBuilderList() {
        return this.messageType_;
    }

    public override java.lang.string GetName() {
        return this.name_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetNamebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.name_);
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions getOptions() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions descriptorProtos$stringOptions = this.options_;
        return descriptorProtos$stringOptions is not null ? descriptorProtos$stringOptions : androidx.datastore.preferences.protobuf.DescriptorProtos$stringOptions.getDefaultInstance();
    }

    public override java.lang.string GetPackage() {
        return this.package_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetPackagebytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.package_);
    }

    public override int GetPublicDependency(int i) {
        return this.publicDependency_.getInt(i);
    }

    public override int GetPublicDependencyCount() {
        return this.publicDependency_.Count;
    }

    public override java.util.List<java.lang.int> GetPublicDependencyList() {
        return this.publicDependency_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto getService(int i) {
        return this.service_[i);
    }

    public override int GetServiceCount() {
        return this.service_.Count;
    }

    public java.util.List<androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProto> getServiceList() {
        return this.service_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProtoOrBuilder getServiceOrBuilder(int i) {
        return this.service_[i);
    }

    public java.util.List<? : androidx.datastore.preferences.protobuf.DescriptorProtos$ServiceDescriptorProtoOrBuilder> getServiceOrBuilderList() {
        return this.service_;
    }

    public androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo getSourceCodeInfo() {
        androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo descriptorProtos$SourceCodeInfo = this.sourceCodeInfo_;
        return descriptorProtos$SourceCodeInfo is not null ? descriptorProtos$SourceCodeInfo : androidx.datastore.preferences.protobuf.DescriptorProtos$SourceCodeInfo.getDefaultInstance();
    }

    public override java.lang.string GetSyntax() {
        return this.syntax_;
    }

    public override androidx.datastore.preferences.protobuf.bytestring GetSyntaxbytes() {
        return androidx.datastore.preferences.protobuf.bytestring.copyFromUtf8(this.syntax_);
    }

    public override int GetWeakDependency(int i) {
        return this.weakDependency_.getInt(i);
    }

    public override int GetWeakDependencyCount() {
        return this.weakDependency_.Count;
    }

    public override java.util.List<java.lang.int> GetWeakDependencyList() {
        return this.weakDependency_;
    }

    public override bool HasEdition() {
        return (this.bitField0_ & 32) != 0;
    }

    public override bool HasName() {
        return (this.bitField0_ & 1) != 0;
    }

    public override bool HasOptions() {
        return (this.bitField0_ & 4) != 0;
    }

    public override bool HasPackage() {
        return (this.bitField0_ & 2) != 0;
    }

    public override bool HasSourceCodeInfo() {
        return (this.bitField0_ & 8) != 0;
    }

    public override bool HasSyntax() {
        return (this.bitField0_ & 16) != 0;
    }
}

