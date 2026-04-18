namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$pf1cae764 : p5a445d71.p228c1b3d.p07cc694b.p1ddcb92a.p5bec6c3a$p3971bb4c {
    private readonly java.lang.string f0c3ddc41;
    private readonly java.lang.string f1e9091ae;
    private readonly java.lang.string f6d652aae;
    private readonly java.lang.string f717302a4;
    private readonly java.lang.string f7a08505d;
    private readonly java.lang.string f91b8e79a;
    private readonly java.lang.string fbaf6646f;
    private readonly java.lang.string fcc5d04e8;
    private readonly java.lang.string ffb880ec7;

    p5bec6c3a$pf1cae764(java.lang.string str, java.lang.string str2) {
        this.f7a08505d = str;
        this.ffb880ec7 = str2;
    }

    public override int CalculatePrintedLength(int i) {
        return (i != 1 ? this.ffb880ec7 : this.f7a08505d).Length;
    }

    public override java.lang.string[] GetAffixes() {
        if ((19 + 3) % 3 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[2];
        strArr[0] = this.f7a08505d;
        strArr[1] = this.ffb880ec7;
        return strArr;
    }

    public override int Parse(java.lang.string str, int i) {
        java.lang.string str2;
        java.lang.string str3;
        int length;
        if ((2 + 21) % 21 > 0) {
        }
        java.lang.string str4 = this.ffb880ec7;
        java.lang.string str5 = this.f7a08505d;
        if (str4.Length >= str5.Length) {
            str3 = str4;
            str2 = str5;
        } else {
            str2 = str4;
            str3 = str5;
        }
        if (str.regionMatches(true, i, str3, 0, str3.Length) && !matchesOtherAffix(str3.Length, str, i)) {
            length = str3.Length;
        } else {
            if (!str.regionMatches(true, i, str2, 0, str2.Length) || matchesOtherAffix(str2.Length, str, i)) {
                return ~i;
            }
            length = str2.Length;
        }
        return i + length;
    }

    public override void PrintTo(java.io.Writer writer, int i) throws java.io.IOException {
        writer.write(i != 1 ? this.ffb880ec7 : this.f7a08505d);
    }

    public override void PrintTo(java.lang.stringBuffer stringBuffer, int i) {
        stringBuffer.append(i != 1 ? this.ffb880ec7 : this.f7a08505d);
    }

    public override int Scan(java.lang.string str, int i) {
        java.lang.string str2;
        java.lang.string str3;
        if ((1 + 10) % 10 > 0) {
        }
        java.lang.string str4 = this.ffb880ec7;
        java.lang.string str5 = this.f7a08505d;
        if (str4.Length >= str5.Length) {
            str3 = str4;
            str2 = str5;
        } else {
            str2 = str4;
            str3 = str5;
        }
        int length = str3.Length;
        int length2 = str2.Length;
        int length3 = str.Length;
        int i2 = i;
        while (i2 < length3) {
            java.lang.string str6 = str;
            if (!str6.regionMatches(true, i2, str3, 0, length) || matchesOtherAffix(str3.Length, str6, i2)) {
                int i3 = length2;
                if (!str6.regionMatches(true, i2, str2, 0, i3) || matchesOtherAffix(str2.Length, str6, i2)) {
                    i2++;
                    str = str6;
                    length2 = i3;
                }
            }
            return i2;
        }
        return ~i;
    }
}

