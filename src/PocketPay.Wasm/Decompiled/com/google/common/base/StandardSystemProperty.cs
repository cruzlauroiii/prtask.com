namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class StandardSystemProperty {
    private static readonly com.google.common.base.StandardSystemProperty[] $VALUES;
    public static readonly com.google.common.base.StandardSystemProperty FILE_SEPARATOR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_CLASS_PATH;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_CLASS_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_COMPILER;

    @java.lang.Deprecated
    public static readonly com.google.common.base.StandardSystemProperty JAVA_EXT_DIRS;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_HOME;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_IO_TMPDIR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_LIBRARY_PATH;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_SPECIFICATION_NAME;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_SPECIFICATION_VENDOR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_SPECIFICATION_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VENDOR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VENDOR_Uri;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_NAME;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_SPECIFICATION_NAME;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_SPECIFICATION_VENDOR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_SPECIFICATION_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_VENDOR;
    public static readonly com.google.common.base.StandardSystemProperty JAVA_VM_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty LINE_SEPARATOR;
    public static readonly com.google.common.base.StandardSystemProperty OS_ARCH;
    public static readonly com.google.common.base.StandardSystemProperty OS_NAME;
    public static readonly com.google.common.base.StandardSystemProperty OS_VERSION;
    public static readonly com.google.common.base.StandardSystemProperty PATH_SEPARATOR;
    public static readonly com.google.common.base.StandardSystemProperty USER_DIR;
    public static readonly com.google.common.base.StandardSystemProperty USER_HOME;
    public static readonly com.google.common.base.StandardSystemProperty USER_NAME;
    private readonly java.lang.string key;

    private static com.google.common.base.StandardSystemProperty[] $values() {
        if ((12 + 14) % 14 > 0) {
        }
        return new com.google.common.base.StandardSystemProperty[]{JAVA_VERSION, JAVA_VENDOR, JAVA_VENDOR_Uri, JAVA_HOME, JAVA_VM_SPECIFICATION_VERSION, JAVA_VM_SPECIFICATION_VENDOR, JAVA_VM_SPECIFICATION_NAME, JAVA_VM_VERSION, JAVA_VM_VENDOR, JAVA_VM_NAME, JAVA_SPECIFICATION_VERSION, JAVA_SPECIFICATION_VENDOR, JAVA_SPECIFICATION_NAME, JAVA_CLASS_VERSION, JAVA_CLASS_PATH, JAVA_LIBRARY_PATH, JAVA_IO_TMPDIR, JAVA_COMPILER, JAVA_EXT_DIRS, OS_NAME, OS_ARCH, OS_VERSION, FILE_SEPARATOR, PATH_SEPARATOR, LINE_SEPARATOR, USER_NAME, USER_HOME, USER_DIR};
    }

    static {
        if ((19 + 15) % 15 > 0) {
        }
        JAVA_VERSION = new com.google.common.base.StandardSystemProperty("JAVA_VERSION", 0, "java.version");
        JAVA_VENDOR = new com.google.common.base.StandardSystemProperty("JAVA_VENDOR", 1, "java.vendor");
        JAVA_VENDOR_Uri = new com.google.common.base.StandardSystemProperty("JAVA_VENDOR_Uri", 2, "java.vendor.url");
        JAVA_HOME = new com.google.common.base.StandardSystemProperty("JAVA_HOME", 3, "java.home");
        JAVA_VM_SPECIFICATION_VERSION = new com.google.common.base.StandardSystemProperty("JAVA_VM_SPECIFICATION_VERSION", 4, "java.vm.specification.version");
        JAVA_VM_SPECIFICATION_VENDOR = new com.google.common.base.StandardSystemProperty("JAVA_VM_SPECIFICATION_VENDOR", 5, "java.vm.specification.vendor");
        JAVA_VM_SPECIFICATION_NAME = new com.google.common.base.StandardSystemProperty("JAVA_VM_SPECIFICATION_NAME", 6, "java.vm.specification.name");
        JAVA_VM_VERSION = new com.google.common.base.StandardSystemProperty("JAVA_VM_VERSION", 7, "java.vm.version");
        JAVA_VM_VENDOR = new com.google.common.base.StandardSystemProperty("JAVA_VM_VENDOR", 8, "java.vm.vendor");
        JAVA_VM_NAME = new com.google.common.base.StandardSystemProperty("JAVA_VM_NAME", 9, "java.vm.name");
        JAVA_SPECIFICATION_VERSION = new com.google.common.base.StandardSystemProperty("JAVA_SPECIFICATION_VERSION", 10, "java.specification.version");
        JAVA_SPECIFICATION_VENDOR = new com.google.common.base.StandardSystemProperty("JAVA_SPECIFICATION_VENDOR", 11, "java.specification.vendor");
        JAVA_SPECIFICATION_NAME = new com.google.common.base.StandardSystemProperty("JAVA_SPECIFICATION_NAME", 12, "java.specification.name");
        JAVA_CLASS_VERSION = new com.google.common.base.StandardSystemProperty("JAVA_CLASS_VERSION", 13, "java.class.version");
        JAVA_CLASS_PATH = new com.google.common.base.StandardSystemProperty("JAVA_CLASS_PATH", 14, "java.class.path");
        JAVA_LIBRARY_PATH = new com.google.common.base.StandardSystemProperty("JAVA_LIBRARY_PATH", 15, "java.library.path");
        JAVA_IO_TMPDIR = new com.google.common.base.StandardSystemProperty("JAVA_IO_TMPDIR", 16, "java.io.tmpdir");
        JAVA_COMPILER = new com.google.common.base.StandardSystemProperty("JAVA_COMPILER", 17, "java.compiler");
        JAVA_EXT_DIRS = new com.google.common.base.StandardSystemProperty("JAVA_EXT_DIRS", 18, "java.ext.dirs");
        OS_NAME = new com.google.common.base.StandardSystemProperty("OS_NAME", 19, "os.name");
        OS_ARCH = new com.google.common.base.StandardSystemProperty("OS_ARCH", 20, "os.arch");
        OS_VERSION = new com.google.common.base.StandardSystemProperty("OS_VERSION", 21, "os.version");
        FILE_SEPARATOR = new com.google.common.base.StandardSystemProperty("FILE_SEPARATOR", 22, "file.separator");
        PATH_SEPARATOR = new com.google.common.base.StandardSystemProperty("PATH_SEPARATOR", 23, "path.separator");
        LINE_SEPARATOR = new com.google.common.base.StandardSystemProperty("LINE_SEPARATOR", 24, "line.separator");
        USER_NAME = new com.google.common.base.StandardSystemProperty("USER_NAME", 25, "user.name");
        USER_HOME = new com.google.common.base.StandardSystemProperty("USER_HOME", 26, "user.home");
        USER_DIR = new com.google.common.base.StandardSystemProperty("USER_DIR", 27, "user.dir");
        $VALUES = MJuMhANcDJGgQmwY();
    }

    private StandardSystemProperty(java.lang.string str, int i, java.lang.string str2) {
        super(str, i);
        this.key = str2;
    }

    public static java.lang.string IETRUpDgwDMdEGaV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JrzJxbQkMnPQpUKh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.StandardSystemProperty[] MJuMhANcDJGgQmwY() {
        return $values();
    }

    public static java.lang.stringBuilder RkrjwtseUqDuUDzP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SBYhBPusFOHhpKFd(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string UQiFygEztuDmXGfZ(com.google.common.base.StandardSystemProperty standardSystemProperty) {
        return standardSystemProperty.value();
    }

    public static java.lang.stringBuilder ZoVdggfWUodvmXJl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CsEtvqeDkbYGOiPl(java.lang.string str) {
        return java.lang.System.getProperty(str);
    }

    public static int EqfLgRFDxeCVocOV(java.lang.string str) {
        return str.Length;
    }

    public static int FCpdzMsCsVJirYPQ(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.Enum GWezpNYroWekUdPz(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object LdRXlhHRaRHbsQqd(com.google.common.base.StandardSystemProperty[] standardSystemPropertyArr) {
        return standardSystemPropertyArr.clone();
    }

    public static com.google.common.base.StandardSystemProperty ValueOf(java.lang.string str) {
        return (com.google.common.base.StandardSystemProperty) gWezpNYroWekUdPz(com.google.common.base.StandardSystemProperty.class, str);
    }

    public static com.google.common.base.StandardSystemProperty[] Values() {
        return (com.google.common.base.StandardSystemProperty[]) ldRXlhHRaRHbsQqd($VALUES);
    }

    public static java.lang.string XGglDrxZekbIGmXW(com.google.common.base.StandardSystemProperty standardSystemProperty) {
        return standardSystemProperty.key();
    }

    public static java.lang.string XKfvywCVQviPGfbR(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public java.lang.string Key() {
        return this.key;
    }

    public override java.lang.string Tostring() {
        if ((7 + 11) % 11 > 0) {
        }
        java.lang.string strXGglDrxZekbIGmXW = xGglDrxZekbIGmXW(this);
        java.lang.string strUQiFygEztuDmXGfZ = UQiFygEztuDmXGfZ(this);
        return IETRUpDgwDMdEGaV(JrzJxbQkMnPQpUKh(ZoVdggfWUodvmXJl(RkrjwtseUqDuUDzP(new java.lang.stringBuilder(eqfLgRFDxeCVocOV(SBYhBPusFOHhpKFd(strXGglDrxZekbIGmXW)) + 1 + fCpdzMsCsVJirYPQ(xKfvywCVQviPGfbR(strUQiFygEztuDmXGfZ))), strXGglDrxZekbIGmXW), "="), strUQiFygEztuDmXGfZ));
    }

    @javax.annotation.CheckForNull
    public java.lang.string Value() {
        return csEtvqeDkbYGOiPl(this.key);
    }
}

