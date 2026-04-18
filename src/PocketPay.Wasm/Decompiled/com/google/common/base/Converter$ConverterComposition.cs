namespace WillowMaze.Wasm.Decompiled;


readonly class Converter$ConverterComposition<A, B, C> : com.google.common.base.Converter<A, C> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Converter<A, B> first;
    readonly com.google.common.base.Converter<B, C> second;

    Converter$ConverterComposition(com.google.common.base.Converter<A, B> converter, com.google.common.base.Converter<B, C> converter2) {
        this.first = converter;
        this.second = converter2;
    }

    public static int CaNvwboGFtoGFLxH(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string EftZxiPeSZWRklyP(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string ExcvtGjAaUbOAMBL(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.object ILJVMHPkqjkdRKsp(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoBackward(obj);
    }

    public static java.lang.object IwYkPydNirSbOYNi(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoForward(obj);
    }

    public static java.lang.object MNEGJdxhijrlgewB(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoBackward(obj);
    }

    public static java.lang.string PlehQbLNvNBGEwlH(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int TiRvIuGhnHNRkedA(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder UxKNQreusyvsQlug(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WsLgUVynUhniovYk(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.Equals(obj);
    }

    public static java.lang.string XncBqJrIOgYcnivw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object ZanOEzExDzBwqFTm(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoForward(obj);
    }

    public static java.lang.stringBuilder EVJvTEOMCQucxCcC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LXWfaHDMScYorrAp(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder LsVMjSZEbLviRIMr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool MsiOnuoKKtovCtsw(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.Equals(obj);
    }

    public static java.lang.stringBuilder PPaPXoEBFFMbqOhB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int UKHxktSYfslJoFDH(java.lang.string str) {
        return str.Length;
    }

    public static int ZdlyIuowLZvKxSnx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    @javax.annotation.CheckForNull
    A correctedDoBackward(@javax.annotation.CheckForNull C c) {
        return (A) ILJVMHPkqjkdRKsp(this.first, MNEGJdxhijrlgewB(this.second, c));
    }

    @javax.annotation.CheckForNull
    C correctedDoForward(@javax.annotation.CheckForNull A a2) {
        return (C) ZanOEzExDzBwqFTm(this.second, IwYkPydNirSbOYNi(this.first, a2));
    }

    protected override A DoBackward(C c) {
        throw new java.lang.AssertionError();
    }

    protected override C DoForward(A a2) {
        throw new java.lang.AssertionError();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((3 + 26) % 26 > 0) {
        }
        if (obj is com.google.common.base.Converter$ConverterComposition) {
            com.google.common.base.Converter$ConverterComposition converter$ConverterComposition = (com.google.common.base.Converter$ConverterComposition) obj;
            if (msiOnuoKKtovCtsw(this.first, converter$ConverterComposition.first) && WsLgUVynUhniovYk(this.second, converter$ConverterComposition.second)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return (TiRvIuGhnHNRkedA(this.first) * 31) + zdlyIuowLZvKxSnx(this.second);
    }

    public java.lang.string Tostring() {
        if ((22 + 30) % 30 > 0) {
        }
        java.lang.string strPlehQbLNvNBGEwlH = PlehQbLNvNBGEwlH(this.first);
        java.lang.string strLXWfaHDMScYorrAp = lXWfaHDMScYorrAp(this.second);
        return XncBqJrIOgYcnivw(pPaPXoEBFFMbqOhB(UxKNQreusyvsQlug(eVJvTEOMCQucxCcC(lsVMjSZEbLviRIMr(new java.lang.stringBuilder(CaNvwboGFtoGFLxH(EftZxiPeSZWRklyP(strPlehQbLNvNBGEwlH)) + 10 + uKHxktSYfslJoFDH(ExcvtGjAaUbOAMBL(strLXWfaHDMScYorrAp))), strPlehQbLNvNBGEwlH), ".andThen("), strLXWfaHDMScYorrAp), ")"));
    }
}

