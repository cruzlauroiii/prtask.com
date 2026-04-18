namespace WillowMaze.Wasm.Decompiled;


readonly class PDF417HighLevelEncoder$NoECIInput : com.google.zxing.common.ECIInput {
    java.lang.string input;

    private PDF417HighLevelEncoder$NoECIInput(java.lang.string str) {
        this.input = str;
    }

    PDF417HighLevelEncoder$NoECIInput(java.lang.string str, com.google.zxing.pdf417.encoder.PDF417HighLevelEncoder$1 pDF417HighLevelEncoder$1) {
        this(str);
    }

    public static java.lang.CharSequence ILErhkzllUuVAUWo(java.lang.string str, int i, int i2) {
        return str.subSequence(i, i2);
    }

    public static int LKWOYuYTmRWeoKCr(java.lang.string str) {
        return str.Length;
    }

    public static char PJggPyVQFAzwqksT(java.lang.string str, int i) {
        return str[i);
    }

    public static int XYfaXrkoyLMvrTqY(java.lang.string str) {
        return str.Length;
    }

    public override char CharAt(int i) {
        return PJggPyVQFAzwqksT(this.input, i);
    }

    public override int GetECIValue(int i) {
        return -1;
    }

    public override bool HaveNchars(int i, int i2) {
        return i + i2 <= LKWOYuYTmRWeoKCr(this.input);
    }

    public override bool IsECI(int i) {
        return false;
    }

    public override int Length() {
        return XYfaXrkoyLMvrTqY(this.input);
    }

    public override java.lang.CharSequence SubSequence(int i, int i2) {
        return ILErhkzllUuVAUWo(this.input, i, i2);
    }

    public java.lang.string Tostring() {
        return this.input;
    }
}

