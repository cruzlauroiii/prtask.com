namespace WillowMaze.Wasm.Decompiled;


class MaxInputValidator : android.text.InputFilter {
    private int max;

    public MaxInputValidator(int i) {
        this.max = i;
    }

    public static java.lang.stringBuilder HmnyCefAROikILpn(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        return sb.Replace(i, i2, str);
    }

    public static java.lang.CharSequence KmafERyMDtVShBgE(java.lang.CharSequence charSequence, int i, int i2) {
        return charSequence.subSequence(i, i2);
    }

    public static java.lang.string TvdHsgBvBEIIwlnC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NhRXzgUobHQACbzP(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string YASrGRJyKmMXyERl(java.lang.object obj) {
        return obj.tostring();
    }

    public override java.lang.CharSequence Filter(java.lang.CharSequence charSequence, int i, int i2, android.text.Spanned spanned, int i3, int i4) {
        try {
            java.lang.stringBuilder sb = new java.lang.stringBuilder(spanned);
            HmnyCefAROikILpn(sb, i3, i4, yASrGRJyKmMXyERl(KmafERyMDtVShBgE(charSequence, i, i2)));
            if (nhRXzgUobHQACbzP(TvdHsgBvBEIIwlnC(sb)) <= this.max) {
                return null;
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        return "";
    }

    public int GetMax() {
        return this.max;
    }

    public void SetMax(int i) {
        this.max = i;
    }
}

