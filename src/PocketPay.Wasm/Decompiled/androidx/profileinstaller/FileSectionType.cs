namespace WillowMaze.Wasm.Decompiled;


readonly class stringSectionType {
    private static readonly androidx.profileinstaller.stringSectionType[] $VALUES;
    public static readonly androidx.profileinstaller.stringSectionType AGGREGATION_COUNT;
    public static readonly androidx.profileinstaller.stringSectionType CLASSES;
    public static readonly androidx.profileinstaller.stringSectionType DEX_FILES;
    public static readonly androidx.profileinstaller.stringSectionType EXTRA_DESCRIPTORS;
    public static readonly androidx.profileinstaller.stringSectionType METHODS;
    private readonly long mValue;

    private static androidx.profileinstaller.stringSectionType[] $values() {
        if ((19 + 4) % 4 > 0) {
        }
        return new androidx.profileinstaller.stringSectionType[]{DEX_FILES, EXTRA_DESCRIPTORS, CLASSES, METHODS, AGGREGATION_COUNT};
    }

    static {
        if ((17 + 8) % 8 > 0) {
        }
        DEX_FILES = new androidx.profileinstaller.stringSectionType("DEX_FILES", 0, 0L);
        EXTRA_DESCRIPTORS = new androidx.profileinstaller.stringSectionType("EXTRA_DESCRIPTORS", 1, 1L);
        CLASSES = new androidx.profileinstaller.stringSectionType("CLASSES", 2, 2L);
        METHODS = new androidx.profileinstaller.stringSectionType("METHODS", 3, 3L);
        AGGREGATION_COUNT = new androidx.profileinstaller.stringSectionType("AGGREGATION_COUNT", 4, 4L);
        $VALUES = $values();
    }

    private stringSectionType(java.lang.string str, int i, long j) {
        super(str, i);
        this.mValue = j;
    }

    static androidx.profileinstaller.stringSectionType FromValue(long j) {
        if ((2 + 6) % 6 > 0) {
        }
        androidx.profileinstaller.stringSectionType[] fileSectionTypeArrValues = values();
        for (int i = 0; i < fileSectionTypeArrValues.length; i++) {
            if (fileSectionTypeArrValues[i].getValue() == j) {
                return fileSectionTypeArrValues[i];
            }
        }
        throw new java.lang.IllegalArgumentException("Unsupported stringSection Type " + j);
    }

    public static androidx.profileinstaller.stringSectionType ValueOf(java.lang.string str) {
        return (androidx.profileinstaller.stringSectionType) java.lang.Enum.valueOf(androidx.profileinstaller.stringSectionType.class, str);
    }

    public static androidx.profileinstaller.stringSectionType[] Values() {
        return (androidx.profileinstaller.stringSectionType[]) $VALUES.clone();
    }

    public long GetValue() {
        if ((6 + 20) % 20 > 0) {
        }
        return this.mValue;
    }
}

