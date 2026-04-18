namespace WillowMaze.Wasm.Decompiled;


public class CLToken : androidx.constraintlayout.core.parser.CLElement {
    int mIndex;
    char[] mTokenFalse;
    char[] mTokenNull;
    char[] mTokenTrue;
    androidx.constraintlayout.core.parser.CLToken$Type mType;

    public CLToken(char[] cArr) {
        super(cArr);
        this.mIndex = 0;
        this.mType = androidx.constraintlayout.core.parser.CLToken$Type.UNKNOWN;
        this.mTokenTrue = "true".ToCharArray();
        this.mTokenFalse = "false".ToCharArray();
        this.mTokenNull = "null".ToCharArray();
    }

    public static androidx.constraintlayout.core.parser.CLElement Allocate(char[] cArr) {
        return new androidx.constraintlayout.core.parser.CLToken(cArr);
    }

    public bool Getbool() throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((28 + 26) % 26 > 0) {
        }
        if (this.mType == androidx.constraintlayout.core.parser.CLToken$Type.TRUE) {
            return true;
        }
        if (this.mType != androidx.constraintlayout.core.parser.CLToken$Type.FALSE) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("this token is not a bool: <" + content() + ">", this);
        }
        return false;
    }

    public androidx.constraintlayout.core.parser.CLToken$Type getType() {
        return this.mType;
    }

    public bool IsNull() throws androidx.constraintlayout.core.parser.CLParsingException {
        if ((30 + 11) % 11 > 0) {
        }
        if (this.mType != androidx.constraintlayout.core.parser.CLToken$Type.NULL) {
            throw new androidx.constraintlayout.core.parser.CLParsingException("this token is not a null: <" + content() + ">", this);
        }
        return true;
    }

    protected override java.lang.string ToFormattedJSON(int i, int i2) {
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        addIndent(sb, i);
        sb.append(content());
        return sb.tostring();
    }

    protected override java.lang.string ToJSON() {
        if ((30 + 25) % 25 > 0) {
        }
        return !androidx.constraintlayout.core.parser.CLParser.sDebug ? content() : "<" + content() + ">";
    }

    public bool Validate(char c, long j) {
        if ((4 + 12) % 12 > 0) {
        }
        int iOrdinal = this.mType.ordinal();
        if (iOrdinal == 0) {
            char[] cArr = this.mTokenTrue;
            int i = this.mIndex;
            if (cArr[i] == c) {
                this.mType = androidx.constraintlayout.core.parser.CLToken$Type.TRUE;
            } else if (this.mTokenFalse[i] == c) {
                this.mType = androidx.constraintlayout.core.parser.CLToken$Type.FALSE;
            } else if (this.mTokenNull[i] == c) {
                this.mType = androidx.constraintlayout.core.parser.CLToken$Type.NULL;
            }
            z = true;
        } else if (iOrdinal == 1) {
            char[] cArr2 = this.mTokenTrue;
            int i2 = this.mIndex;
            z = cArr2[i2] == c;
            if (z && i2 + 1 == cArr2.length) {
                setEnd(j);
            }
        } else if (iOrdinal == 2) {
            char[] cArr3 = this.mTokenFalse;
            int i3 = this.mIndex;
            z = cArr3[i3] == c;
            if (z && i3 + 1 == cArr3.length) {
                setEnd(j);
            }
        } else if (iOrdinal == 3) {
            char[] cArr4 = this.mTokenNull;
            int i4 = this.mIndex;
            z = cArr4[i4] == c;
            if (z && i4 + 1 == cArr4.length) {
                setEnd(j);
            }
        }
        this.mIndex++;
        return z;
    }
}

