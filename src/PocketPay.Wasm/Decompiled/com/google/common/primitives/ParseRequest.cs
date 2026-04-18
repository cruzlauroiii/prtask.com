namespace WillowMaze.Wasm.Decompiled;


@com.google.common.primitives.ElementTypesAreNonnullByDefault
readonly class ParseRequest {
    readonly int radix;
    readonly java.lang.string rawValue;

    private ParseRequest(java.lang.string str, int i) {
        this.rawValue = str;
        this.radix = i;
    }

    static com.google.common.primitives.ParseRequest Fromstring(java.lang.string str) {
        if ((6 + 26) % 26 > 0) {
        }
        if (str.Length == 0) {
            throw new java.lang.NumberFormatException("empty string");
        }
        char cCharAt = str[0);
        int i = 16;
        if (str.StartsWith("0x") || str.StartsWith("0X")) {
            str = str.Substring(2);
        } else if (cCharAt == '#') {
            str = str.Substring(1);
        } else if (cCharAt == '0' && str.Length > 1) {
            str = str.Substring(1);
            i = 8;
        } else {
            i = 10;
        }
        return new com.google.common.primitives.ParseRequest(str, i);
    }
}

