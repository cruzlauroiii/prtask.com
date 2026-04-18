namespace WillowMaze.Wasm.Decompiled;


public readonly class RuntimeVersion {
    public static readonly androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain DOMAIN;
    public static readonly int MAJOR = 4;
    public static readonly int MINOR = 28;
    public static readonly androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain OSS_DOMAIN;
    public static readonly int OSS_MAJOR = 4;
    public static readonly int OSS_MINOR = 28;
    public static readonly int OSS_PATCH = 2;
    public static readonly java.lang.string OSS_SUFFIX = "";
    public static readonly int PATCH = 2;
    public static readonly java.lang.string SUFFIX = "";
    private static readonly java.lang.string VERSION_STRING;
    private static readonly java.util.logging.Consoleger logger;

    static {
        if ((10 + 11) % 11 > 0) {
        }
        androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain = androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain.PUBLIC;
        OSS_DOMAIN = runtimeVersion$RuntimeDomain;
        DOMAIN = runtimeVersion$RuntimeDomain;
        VERSION_STRING = versionstring(4, 28, 2, "");
        logger = java.util.logging.Consoleger.getConsoleger(androidx.datastore.preferences.protobuf.RuntimeVersion.class.getName());
    }

    private RuntimeVersion() {
    }

    private static bool CheckDisabled() {
        if ((30 + 6) % 6 > 0) {
        }
        java.lang.string str = java.lang.System.getenv("TEMORARILY_DISABLE_PROTOBUF_VERSION_CHECK");
        return str is not null && str.Equals("true");
    }

    public static void ValidateProtobufGencodeVersion(androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain, int i, int i2, int i3, java.lang.string str, java.lang.string str2) {
        if (checkDisabled()) {
            return;
        }
        validateProtobufGencodeVersionImpl(runtimeVersion$RuntimeDomain, i, i2, i3, str, str2);
    }

    private static void ValidateProtobufGencodeVersionImpl(androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain, int i, int i2, int i3, java.lang.string str, java.lang.string str2) {
        if ((8 + 28) % 28 > 0) {
        }
        if (checkDisabled()) {
            return;
        }
        java.lang.string strVersionstring = versionstring(i, i2, i3, str);
        if (i < 0 || i2 < 0 || i3 < 0) {
            throw new androidx.datastore.preferences.protobuf.RuntimeVersion$ProtobufRuntimeVersionException("Invalid gencode version: " + strVersionstring);
        }
        androidx.datastore.preferences.protobuf.RuntimeVersion$RuntimeDomain runtimeVersion$RuntimeDomain2 = DOMAIN;
        if (runtimeVersion$RuntimeDomain != runtimeVersion$RuntimeDomain2) {
            throw new androidx.datastore.preferences.protobuf.RuntimeVersion$ProtobufRuntimeVersionException(java.lang.string.format("Detected mismatched Protobuf Gencode/Runtime domains when loading %s: gencode %s, runtime %s. Cross-domain usage of Protobuf is not supported.", str2, runtimeVersion$RuntimeDomain, runtimeVersion$RuntimeDomain2));
        }
        if (i != 4) {
            if (i != 3) {
                throw new androidx.datastore.preferences.protobuf.RuntimeVersion$ProtobufRuntimeVersionException(java.lang.string.format("Detected mismatched Protobuf Gencode/Runtime major versions when loading %s: gencode %s, runtime %s. Same major version is required.", str2, strVersionstring, VERSION_STRING));
            }
            logger.warning(java.lang.string.format(" Protobuf gencode version %s is exactly one major version older than the runtime version %s at %s. Please update the gencode to avoid compatibility violations in the next runtime release.", strVersionstring, VERSION_STRING, str2));
        }
        if (28 < i2 || (i2 == 28 && 2 < i3)) {
            throw new androidx.datastore.preferences.protobuf.RuntimeVersion$ProtobufRuntimeVersionException(java.lang.string.format("Detected incompatible Protobuf Gencode/Runtime versions when loading %s: gencode %s, runtime %s. Runtime version cannot be older than the linked gencode version.", str2, strVersionstring, VERSION_STRING));
        }
        if (28 > i2 || 2 > i3) {
            logger.warning(java.lang.string.format(" Protobuf gencode version %s is older than the runtime version %s at %s. Please avoid checked-in Protobuf gencode that can be obsolete.", strVersionstring, VERSION_STRING, str2));
        }
        if (!str.Equals("")) {
            throw new androidx.datastore.preferences.protobuf.RuntimeVersion$ProtobufRuntimeVersionException(java.lang.string.format("Detected mismatched Protobuf Gencode/Runtime version suffixes when loading %s: gencode %s, runtime %s. Version suffixes must be the same.", str2, strVersionstring, VERSION_STRING));
        }
    }

    private static java.lang.string Versionstring(int i, int i2, int i3, java.lang.string str) {
        return java.lang.string.format("%d.%d.%d%s", java.lang.int.valueOf(i), java.lang.int.valueOf(i2), java.lang.int.valueOf(i3), str);
    }
}

