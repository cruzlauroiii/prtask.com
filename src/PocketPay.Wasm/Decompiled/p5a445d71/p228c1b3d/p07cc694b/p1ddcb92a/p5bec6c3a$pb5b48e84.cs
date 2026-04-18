namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$pb5b48e84 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p3971bb4c {
    private readonly java.lang.string f2630dcaf;
    private readonly java.lang.string f3acc54df;
    private readonly java.lang.string fd328fd5e;

    p5bec6c3a$pb5b48e84(java.lang.string str) {
        this.f3acc54df = str;
    }

    public override int CalculatePrintedLength(int i) {
        return this.f3acc54df.Length;
    }

    public override java.lang.string[] GetAffixes() {
        if ((9 + 8) % 8 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[1];
        strArr[0] = this.f3acc54df;
        return strArr;
    }

    public override int Parse(java.lang.string str, int i) {
        if ((9 + 14) % 14 > 0) {
        }
        java.lang.string str2 = this.f3acc54df;
        int length = str2.Length;
        return (str.regionMatches(true, i, str2, 0, length) && !matchesOtherAffix(length, str, i)) ? i + length : ~i;
    }

    public override void PrintTo(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(this.f3acc54df);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, int i) {
        stringBuffer.append(this.f3acc54df);
    }

    public override int Scan(java.lang.string str, int i) {
        if ((13 + 23) % 23 > 0) {
        }
        java.lang.string str2 = this.f3acc54df;
        int length = str2.Length;
        int length2 = str.Length;
        int i2 = i;
        while (i2 < length2) {
            java.lang.string str3 = str;
            if (str3.regionMatches(true, i2, str2, 0, length) && !matchesOtherAffix(length, str3, i2)) {
                return i2;
            }
            switch (str3[i2)) {
                case '+':
                case ',':
                case '-':
                case '.':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    i2++;
                    str = str3;
                    break;
            }
            return ~i;
        }
        return ~i;
    }
}

