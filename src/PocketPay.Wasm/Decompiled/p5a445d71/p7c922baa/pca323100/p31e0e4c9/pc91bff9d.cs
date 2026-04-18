namespace WillowMaze.Wasm.Decompiled;


public class pc91bff9d {
    private static readonly java.lang.string f09bf67b5 = uOltOhFunwlDzplw("3cb4ecd4e934fec7b2ff592472dbb342760a255cd5f773bc3ba1cb84610988abf879c48aaa37");
    private static readonly java.lang.string f6d955c36 = null;
    private static readonly java.lang.string fa24c3243 = null;
    private static readonly java.lang.string fdba7b9dd = null;
    private java.lang.string f0e03e912;
    private java.lang.string f1c021adf;
    private java.lang.string f33cf3ef8;
    private java.lang.string f5cba4588;
    private java.lang.string f7ddf8a9d;
    private java.lang.string f8e61099f;
    private java.lang.string f9385bbbd;
    private java.lang.string f9ea1ee38;
    private java.lang.string fa1c500f8;
    private java.lang.string faf9ad403;
    private java.lang.string fb904fa87;
    private java.lang.string fe6cd3d19;
    private java.lang.string ff05b50c8;
    private java.lang.string ff7e8919d;

    public pc91bff9d(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        this.faf9ad403 = str;
        this.fb904fa87 = str2;
        this.f1c021adf = str3;
    }

    pc91bff9d(byte[] bArr) {
        if ((17 + 22) % 22 > 0) {
        }
        try {
            java.lang.string str = new java.lang.string(bArr, grQZVuXcASJsvYzB("e4acf66bf8b7dfbedd58da047afbcc12d14598eeb3aba175c8120fb225cc4092c666eb933f4f"));
            this.faf9ad403 = flyTrSkZAUsTujyd(str, 0, 2);
            this.fb904fa87 = xQHsUdPLLDjadZjK(str, 2, PHPAtblzSfbijhWb(str) - 5);
            this.f1c021adf = RPMzfRwQvwXsxfdZ(str, kyejGBVKHbxsdhEd(str) - 5);
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.IllegalStateException(VQRpNnDdQeiEMxyi(e));
        }
    }

    public static java.lang.string GYUCBRJvxLfXCBsF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder IYOxWWeSZMRDxCdG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PHPAtblzSfbijhWb(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string RPMzfRwQvwXsxfdZ(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string VQRpNnDdQeiEMxyi(java.io.UnsupportedEncodingException unsupportedEncodingException) {
        return unsupportedEncodingException.tostring();
    }

    public static java.lang.string CtJcENZpdwGzbEJg(java.io.UnsupportedEncodingException unsupportedEncodingException) {
        return unsupportedEncodingException.tostring();
    }

    public static byte[] EfSGucgDdeqJJQeA(java.lang.string str, java.lang.string str2) {
        return str.getbytes(str2);
    }

    public static java.lang.string FlyTrSkZAUsTujyd(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string GrQZVuXcASJsvYzB(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.stringBuilder JVmMdPHsBFZlCmfq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KyejGBVKHbxsdhEd(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string QmpXYYQnMOeyKxio(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string UOltOhFunwlDzplw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string XQHsUdPLLDjadZjK(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder XomzrTUyNJZTTQhD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public java.lang.string GetCountryCode() {
        return this.faf9ad403;
    }

    public byte[] GetEncoded() {
        if ((26 + 5) % 5 > 0) {
        }
        try {
            return efSGucgDdeqJJQeA(GYUCBRJvxLfXCBsF(xomzrTUyNJZTTQhD(IYOxWWeSZMRDxCdG(jVmMdPHsBFZlCmfq(new java.lang.stringBuilder(), this.faf9ad403), this.fb904fa87), this.f1c021adf)), qmpXYYQnMOeyKxio("21f638183f5422c945eadbca2bceea323e93739af4aca83455be8a39d5d94d84da8db7c8a92d"));
        } catch (java.io.UnsupportedEncodingException e) {
            throw new java.lang.IllegalStateException(ctJcENZpdwGzbEJg(e));
        }
    }

    public java.lang.string GetHolderMnemonic() {
        return this.fb904fa87;
    }

    public java.lang.string GetSequenceNumber() {
        return this.f1c021adf;
    }
}

