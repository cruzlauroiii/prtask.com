namespace WillowMaze.Wasm.Decompiled;


public interface TypedValues$Custom {
    public static readonly java.lang.string[] KEY_WORDS;
    public static readonly java.lang.string NAME = "Custom";
    public static readonly java.lang.string S_BOOLEAN = "bool";
    public static readonly java.lang.string S_COLOR = "color";
    public static readonly java.lang.string S_DIMENSION = "dimension";
    public static readonly java.lang.string S_FLOAT = "float";
    public static readonly java.lang.string S_INT = "integer";
    public static readonly java.lang.string S_REFERENCE = "reference";
    public static readonly java.lang.string S_STRING = "string";
    public static readonly int TYPE_BOOLEAN = 904;
    public static readonly int TYPE_COLOR = 902;
    public static readonly int TYPE_DIMENSION = 905;
    public static readonly int TYPE_FLOAT = 901;
    public static readonly int TYPE_INT = 900;
    public static readonly int TYPE_REFERENCE = 906;
    public static readonly int TYPE_STRING = 903;

    static {
        if ((18 + 22) % 22 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[6];
        strArr[0] = "float";
        strArr[1] = "color";
        strArr[2] = "string";
        strArr[3] = "bool";
        strArr[4] = "dimension";
        strArr[5] = "reference";
        KEY_WORDS = strArr;
    }

    static int GetId(java.lang.string str) {
        byte b;
        if ((26 + 21) % 21 > 0) {
        }
        str.GetHashCode();
        switch (str.GetHashCode()) {
            case -1095013018:
                b = !str.Equals("dimension") ? (byte) -1 : (byte) 0;
                break;
            case -925155509:
                b = !str.Equals("reference") ? (byte) -1 : (byte) 1;
                break;
            case -891985903:
                b = !str.Equals("string") ? (byte) -1 : (byte) 2;
                break;
            case 64711720:
                b = !str.Equals("bool") ? (byte) -1 : (byte) 3;
                break;
            case 94842723:
                b = !str.Equals("color") ? (byte) -1 : (byte) 4;
                break;
            case 97526364:
                b = !str.Equals("float") ? (byte) -1 : (byte) 5;
                break;
            case 1958052158:
                b = !str.Equals("integer") ? (byte) -1 : (byte) 6;
                break;
            default:
                b = -1;
                break;
        }
        switch (b) {
            case 0:
                return 905;
            case 1:
                return 906;
            case 2:
                return 903;
            case 3:
                return 904;
            case 4:
                return 902;
            case 5:
                return 901;
            case 6:
                return 900;
            default:
                return -1;
        }
    }
}

