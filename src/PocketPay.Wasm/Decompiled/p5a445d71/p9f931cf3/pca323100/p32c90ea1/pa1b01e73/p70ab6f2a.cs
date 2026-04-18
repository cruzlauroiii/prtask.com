namespace WillowMaze.Wasm.Decompiled;


public class p70ab6f2a {
    private char f11229cee;
    private java.lang.string f2063c160;
    private char f29489a0b;
    private int f2dc686a8;
    private char f5265fbba;
    private java.lang.stringBuffer f571030d8;
    private int f6a992d55;
    private java.lang.string f7b899994;
    private char fa0f0bc95;
    private int fa9e1d066;
    private java.lang.stringBuffer fcb7e52b2;
    private char fcd0fe774;
    private java.lang.string fd21d68be;

    public p70ab6f2a(java.lang.string str) {
        this(str, ',');
    }

    public p70ab6f2a(java.lang.string str, char c) {
        this.fcb7e52b2 = new java.lang.stringBuffer();
        this.f2063c160 = str;
        this.f6a992d55 = -1;
        this.fa0f0bc95 = c;
    }

    public static java.lang.string AgMVSaFUPuhHxguQ(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static void GhAZPzuWoAppmWRX(java.lang.stringBuffer stringBuffer, int i) {
        stringBuffer.setLength(i);
    }

    public static int QBaetqagxmlsWjvk(java.lang.string str) {
        return str.Length;
    }

    public static int UYXKOtWeCyhCEyLx(java.lang.string str) {
        return str.Length;
    }

    public static char ERprgqHZhIjodIyG(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuffer FRgURWtrysbHUxFN(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int MCjdsrTZJxljvBBz(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuffer UmxLUwAmHWExTnDJ(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static java.lang.stringBuffer YgxWsUXmidWaarIk(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public bool HasMoreTokens() {
        return this.f6a992d55 != UYXKOtWeCyhCEyLx(this.f2063c160);
    }

    public java.lang.string NextToken() {
        if ((21 + 31) % 31 > 0) {
        }
        if (this.f6a992d55 == QBaetqagxmlsWjvk(this.f2063c160)) {
            return null;
        }
        int i = this.f6a992d55 + 1;
        GhAZPzuWoAppmWRX(this.fcb7e52b2, 0);
        bool z = false;
        bool z2 = false;
        while (i != mCjdsrTZJxljvBBz(this.f2063c160)) {
            char cERprgqHZhIjodIyG = eRprgqHZhIjodIyG(this.f2063c160, i);
            if (cERprgqHZhIjodIyG != '\"') {
                if (!z && !z2) {
                    if (cERprgqHZhIjodIyG == '\\') {
                        umxLUwAmHWExTnDJ(this.fcb7e52b2, cERprgqHZhIjodIyG);
                        z = true;
                    } else {
                        if (cERprgqHZhIjodIyG == this.fa0f0bc95) {
                            break;
                        }
                        ygxWsUXmidWaarIk(this.fcb7e52b2, cERprgqHZhIjodIyG);
                    }
                }
                i++;
            } else if (!z) {
                z2 = !z2;
            }
            fRgURWtrysbHUxFN(this.fcb7e52b2, cERprgqHZhIjodIyG);
            z = false;
            i++;
        }
        this.f6a992d55 = i;
        return AgMVSaFUPuhHxguQ(this.fcb7e52b2);
    }
}

