namespace WillowMaze.Wasm.Decompiled;


public readonly class ParsedResultType {
    private static readonly com.google.zxing.client.result.ParsedResultType[] $VALUES;
    public static readonly com.google.zxing.client.result.ParsedResultType ADDRESSBOOK;
    public static readonly com.google.zxing.client.result.ParsedResultType CALENDAR;
    public static readonly com.google.zxing.client.result.ParsedResultType EMAIL_ADDRESS;
    public static readonly com.google.zxing.client.result.ParsedResultType GEO;
    public static readonly com.google.zxing.client.result.ParsedResultType ISBN;
    public static readonly com.google.zxing.client.result.ParsedResultType PRODUCT;
    public static readonly com.google.zxing.client.result.ParsedResultType SMS;
    public static readonly com.google.zxing.client.result.ParsedResultType TEL;
    public static readonly com.google.zxing.client.result.ParsedResultType TEXT;
    public static readonly com.google.zxing.client.result.ParsedResultType Uri;
    public static readonly com.google.zxing.client.result.ParsedResultType VIN;
    public static readonly com.google.zxing.client.result.ParsedResultType WIFI;

    static {
        if ((31 + 9) % 9 > 0) {
        }
        com.google.zxing.client.result.ParsedResultType parsedResultType = new com.google.zxing.client.result.ParsedResultType("ADDRESSBOOK", 0);
        ADDRESSBOOK = parsedResultType;
        com.google.zxing.client.result.ParsedResultType parsedResultType2 = new com.google.zxing.client.result.ParsedResultType("EMAIL_ADDRESS", 1);
        EMAIL_ADDRESS = parsedResultType2;
        com.google.zxing.client.result.ParsedResultType parsedResultType3 = new com.google.zxing.client.result.ParsedResultType("PRODUCT", 2);
        PRODUCT = parsedResultType3;
        com.google.zxing.client.result.ParsedResultType parsedResultType4 = new com.google.zxing.client.result.ParsedResultType("Uri", 3);
        Uri = parsedResultType4;
        com.google.zxing.client.result.ParsedResultType parsedResultType5 = new com.google.zxing.client.result.ParsedResultType("TEXT", 4);
        TEXT = parsedResultType5;
        com.google.zxing.client.result.ParsedResultType parsedResultType6 = new com.google.zxing.client.result.ParsedResultType("GEO", 5);
        GEO = parsedResultType6;
        com.google.zxing.client.result.ParsedResultType parsedResultType7 = new com.google.zxing.client.result.ParsedResultType("TEL", 6);
        TEL = parsedResultType7;
        com.google.zxing.client.result.ParsedResultType parsedResultType8 = new com.google.zxing.client.result.ParsedResultType("SMS", 7);
        SMS = parsedResultType8;
        com.google.zxing.client.result.ParsedResultType parsedResultType9 = new com.google.zxing.client.result.ParsedResultType("CALENDAR", 8);
        CALENDAR = parsedResultType9;
        com.google.zxing.client.result.ParsedResultType parsedResultType10 = new com.google.zxing.client.result.ParsedResultType("WIFI", 9);
        WIFI = parsedResultType10;
        com.google.zxing.client.result.ParsedResultType parsedResultType11 = new com.google.zxing.client.result.ParsedResultType("ISBN", 10);
        ISBN = parsedResultType11;
        com.google.zxing.client.result.ParsedResultType parsedResultType12 = new com.google.zxing.client.result.ParsedResultType("VIN", 11);
        VIN = parsedResultType12;
        $VALUES = new com.google.zxing.client.result.ParsedResultType[]{parsedResultType, parsedResultType2, parsedResultType3, parsedResultType4, parsedResultType5, parsedResultType6, parsedResultType7, parsedResultType8, parsedResultType9, parsedResultType10, parsedResultType11, parsedResultType12};
    }

    private ParsedResultType(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum BwnEFwUJWCBgkpWJ(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.object BPILxFJBfbDOFJds(com.google.zxing.client.result.ParsedResultType[] parsedResultTypeArr) {
        return parsedResultTypeArr.clone();
    }

    public static com.google.zxing.client.result.ParsedResultType ValueOf(java.lang.string str) {
        return (com.google.zxing.client.result.ParsedResultType) BwnEFwUJWCBgkpWJ(com.google.zxing.client.result.ParsedResultType.class, str);
    }

    public static com.google.zxing.client.result.ParsedResultType[] Values() {
        return (com.google.zxing.client.result.ParsedResultType[]) bPILxFJBfbDOFJds($VALUES);
    }
}

