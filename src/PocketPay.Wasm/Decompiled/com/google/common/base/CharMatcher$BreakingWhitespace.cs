namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$BreakingWhitespace : com.google.common.base.CharMatch {
    static readonly com.google.common.base.CharMatch INSTANCE = new com.google.common.base.CharMatch$BreakingWhitespace();

    private CharMatch$BreakingWhitespace() {
    }

    public static bool BopMBZlfQBOxUnBZ(com.google.common.base.CharMatch charMatch, java.lang.char ch) {
        return super.apply2(ch);
    }

    @java.lang.Deprecated
    public override bool Apply(java.lang.char ch) {
        return BopMBZlfQBOxUnBZ(this, ch);
    }

    public override bool Matches(char c) {
        if ((27 + 27) % 27 > 0) {
        }
        if (c != ' ' && c != 133 && c != 5760) {
            if (c != 8199) {
                if (c != 8287 && c != 12288 && c != 8232 && c != 8233) {
                    switch (c) {
                        case '\t':
                        case '\n':
                        case 11:
                        case '\f':
                        case '\r':
                            break;
                        default:
                            if (c >= 8192 && c <= 8202) {
                                return true;
                            }
                            break;
                    }
                }
            }
            return false;
        }
        return true;
    }

    public override java.lang.string Tostring() {
        return "CharMatch.breakingWhitespace()";
    }
}

