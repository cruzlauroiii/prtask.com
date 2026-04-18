namespace WillowMaze.Wasm.Decompiled;


public class paff8972b : p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p6127f74f {
    private static readonly java.lang.string f5d4cac01 = null;
    private static readonly java.lang.string f70bb8dc9 = p5a445d71.p7c922baa.p05c7e247.p89be9433.m2295b6f1();
    private static readonly java.lang.string f9294ff7a = null;
    private static readonly java.lang.string f9a785923 = null;
    private static readonly java.lang.string fb364bb3c = null;
    private bool f22b9cdb5;
    private bool f260ca9dd;
    private java.lang.Exception f2b82a08e;
    private java.lang.Exception f42552b1f;
    private java.lang.Exception f623a8fcc;
    private bool f6e4891ea;
    private java.lang.Exception f710538c0;
    private java.lang.string f78e73102;
    private java.lang.Exception faea0fb5e;
    private java.lang.string fb6c9bcc1;
    private java.lang.string fd95e7379;
    private bool fe92d8d92;

    public paff8972b(bool z, java.lang.string str) {
        this.f260ca9dd = z;
        this.f78e73102 = str;
    }

    public paff8972b(bool z, java.lang.string str, java.lang.Exception th) {
        this.f260ca9dd = z;
        this.f78e73102 = str;
        this.f42552b1f = th;
    }

    public static p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p6127f74f M26934eb3(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var, java.lang.string str) {
        if ((22 + 30) % 30 > 0) {
        }
        return new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.paff8972b(false, p0cbc6611Var.getName() + ": " + str);
    }

    public static p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p6127f74f M26934eb3(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var, java.lang.string str, java.lang.object obj, java.lang.object obj2) {
        if ((6 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str);
        java.lang.string str2 = f70bb8dc9;
        return m26934eb3(p0cbc6611Var, sbAppend.append(str2).append("Expected: ").append(obj).append(str2).append("Found   : ").append(obj2).tostring());
    }

    public static p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p6127f74f M26934eb3(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var, java.lang.string str, java.lang.Exception th) {
        if ((28 + 9) % 9 > 0) {
        }
        return new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.paff8972b(false, p0cbc6611Var.getName() + ": " + str, th);
    }

    public static java.lang.string M33f06530(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4) {
        if ((15 + 4) % 4 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer(str);
        stringBuffer.append(" failing ").append(str2);
        java.lang.string str5 = f70bb8dc9;
        stringBuffer.append(str5).append("    expected: ").append(str3);
        stringBuffer.append(str5).append("    got     : ").append(str4);
        return stringBuffer.tostring();
    }

    public static p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p6127f74f M802024b2(p5a445d71.p7c922baa.p05c7e247.p098f6bcd.p0cbc6611 p0cbc6611Var, java.lang.string str) {
        if ((20 + 9) % 9 > 0) {
        }
        return new p5a445d71.p7c922baa.p05c7e247.p098f6bcd.paff8972b(true, p0cbc6611Var.getName() + ": " + str);
    }

    public override java.lang.Exception GetException() {
        return this.f42552b1f;
    }

    public override bool IsSuccessful() {
        return this.f260ca9dd;
    }

    public override java.lang.string Tostring() {
        return this.f78e73102;
    }
}

