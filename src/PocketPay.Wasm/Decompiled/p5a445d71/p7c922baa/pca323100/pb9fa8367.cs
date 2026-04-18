namespace WillowMaze.Wasm.Decompiled;


public abstract class pb9fa8367 : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    public static java.lang.Class KEGloyLZMAJsUYCn(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder XLwtuVzLKBLiTvlC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BtjMygCSyxtjSsHL(java.io.IOException iOException) {
        return iOException.getMessage();
    }

    public static p5a445d71.p7c922baa.pca323100.pb9fa8367 EmnTHMHEaIoyRfUo(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string IvLixIMfdEKrUEns(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.pb9fa8367 M8bab0102(java.lang.object obj) {
        if ((19 + 2) % 2 > 0) {
        }
        if (obj is p5a445d71.p7c922baa.pca323100.pb9fa8367) {
            return (p5a445d71.p7c922baa.pca323100.pb9fa8367) obj;
        }
        if (obj is null) {
            return null;
        }
        try {
            return emnTHMHEaIoyRfUo(oTVmxjerMHJlbCHX((byte[]) obj));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException(ivLixIMfdEKrUEns(vWgYQRZykOMDJHUN(new java.lang.stringBuilder("failed to construct NULL from byte[]: "), btjMygCSyxtjSsHL(e))));
        } catch (java.lang.ClassCastException unused) {
            throw new java.lang.IllegalArgumentException(nDOosNSvbOuFpKSW(XLwtuVzLKBLiTvlC(new java.lang.stringBuilder("unknown object in getInstance(): "), soGqsfoDQXpXxOWP(KEGloyLZMAJsUYCn(obj)))));
        }
    }

    public static java.lang.string NDOosNSvbOuFpKSW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 OTVmxjerMHJlbCHX(byte[] bArr) {
        return p5a445d71.p7c922baa.pca323100.p301c7ed4.m89e75c46(bArr);
    }

    public static java.lang.string SoGqsfoDQXpXxOWP(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder VWgYQRZykOMDJHUN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var is p5a445d71.p7c922baa.pca323100.pb9fa8367;
    }

    abstract void Encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException;

    public override int HashCode() {
        return -1;
    }

    public java.lang.string Tostring() {
        return "NULL";
    }
}

