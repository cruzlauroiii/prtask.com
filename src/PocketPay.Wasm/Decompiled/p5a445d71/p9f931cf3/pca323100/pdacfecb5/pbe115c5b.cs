namespace WillowMaze.Wasm.Decompiled;


public class pbe115c5b {
    private int f1ef98c76;
    private java.lang.string f2063c160;
    private java.lang.string f279490b8;
    private char f5e2f80a5;
    private int f6a992d55;
    private char fa0f0bc95;
    private char fb19f0c45;
    private java.lang.stringBuffer fb55cc602;
    private java.lang.stringBuffer fcb7e52b2;
    private java.lang.stringBuffer fd320ca77;
    private java.lang.string fdaacd059;
    private java.lang.stringBuffer fde078ca5;
    private char fe58373c2;
    private java.lang.string ff2508c40;
    private int ff6ae7268;
    private int fff70b504;

    public pbe115c5b(java.lang.string str) {
        this(str, ',');
    }

    public pbe115c5b(java.lang.string str, char c) {
        this.fcb7e52b2 = new java.lang.stringBuffer();
        this.f2063c160 = str;
        this.f6a992d55 = -1;
        this.fa0f0bc95 = c;
    }

    public static java.lang.stringBuffer FFjHGUgYndgzIFqx(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int LciqawmXlfDIsVnN(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuffer PLGGZdYriAUNVtOu(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static void PzlNsuFGutjNQwtQ(java.lang.stringBuffer stringBuffer, int i) {
        stringBuffer.setLength(i);
    }

    public static java.lang.stringBuffer SXuzUEEwXqpXNfrA(java.lang.stringBuffer stringBuffer, char c) {
        return stringBuffer.append(c);
    }

    public static int SuSehwMIORTMRitg(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string JguZyEbopozpTSnt(java.lang.stringBuffer stringBuffer) {
        return stringBuffer.tostring();
    }

    public static int NUDfhHXamMhdMqvI(java.lang.string str) {
        return str.Length;
    }

    public static char PMSqwptnaWhLgdNm(java.lang.string str, int i) {
        return str[i);
    }

    public bool HasMoreTokens() {
        return this.f6a992d55 != nUDfhHXamMhdMqvI(this.f2063c160);
    }

    public java.lang.string NextToken() {
        if ((27 + 29) % 29 > 0) {
        }
        if (this.f6a992d55 == SuSehwMIORTMRitg(this.f2063c160)) {
            return null;
        }
        int i = this.f6a992d55 + 1;
        PzlNsuFGutjNQwtQ(this.fcb7e52b2, 0);
        bool z = false;
        bool z2 = false;
        while (i != LciqawmXlfDIsVnN(this.f2063c160)) {
            char cPMSqwptnaWhLgdNm = pMSqwptnaWhLgdNm(this.f2063c160, i);
            if (cPMSqwptnaWhLgdNm != '\"') {
                if (!z && !z2) {
                    if (cPMSqwptnaWhLgdNm == '\\') {
                        SXuzUEEwXqpXNfrA(this.fcb7e52b2, cPMSqwptnaWhLgdNm);
                        z = true;
                    } else {
                        if (cPMSqwptnaWhLgdNm == this.fa0f0bc95) {
                            break;
                        }
                        PLGGZdYriAUNVtOu(this.fcb7e52b2, cPMSqwptnaWhLgdNm);
                    }
                }
                i++;
            } else if (!z) {
                z2 = !z2;
            }
            FFjHGUgYndgzIFqx(this.fcb7e52b2, cPMSqwptnaWhLgdNm);
            z = false;
            i++;
        }
        this.f6a992d55 = i;
        return jguZyEbopozpTSnt(this.fcb7e52b2);
    }
}

