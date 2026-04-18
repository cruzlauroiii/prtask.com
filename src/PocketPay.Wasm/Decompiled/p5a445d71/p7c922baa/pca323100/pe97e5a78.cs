namespace WillowMaze.Wasm.Decompiled;


public class pe97e5a78 : p5a445d71.p7c922baa.pca323100.pa1bc6907 {
    private static readonly int f4aba510a = 1000;
    private static readonly int f900917ea = 1000;
    private java.util.Vector f771804df;
    private java.util.Vector fcfdb301c;

    public pe97e5a78(java.util.Vector vector) {
        super(vUWXSLYLZdMZPpCO(vector));
        this.fcfdb301c = vector;
    }

    public pe97e5a78(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this(vxwRbOpGYJOKNkiL(p0fd1bdf1Var));
    }

    public pe97e5a78(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        super(BFjmJBUDwUkIyJzR(p301c7ed4Var));
    }

    public pe97e5a78(byte[] bArr) {
        super(bArr);
    }

    public static java.util.Enumeration BAfBcdvzupdlGtDq(java.util.Vector vector) {
        return vector.elements();
    }

    public static byte[] BFjmJBUDwUkIyJzR(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return md6c3dad7(p301c7ed4Var);
    }

    public static java.lang.Class EwdxvPnvdSijxMts(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string FNTQECSdAICAqgfX(java.io.IOException iOException) {
        return iOException.tostring();
    }

    public static java.lang.string FbqVdZODbqZYCqiP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[] GkojmtEOglLVkhlj(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static byte[] IJlOWipfKKecHWmP(p5a445d71.p7c922baa.pca323100.p6f0e511c p6f0e511cVar) {
        return p6f0e511cVar.getOctets();
    }

    public static void MGQuirUIDistrLyT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void OTCVIzTRiVhZtIrW(java.io.byteArrayStream byteArrayStream, byte[] bArr) {
        byteArrayStream.write(bArr);
    }

    public static java.util.Enumeration TSgBsXZDSlURomzn(java.util.Vector vector) {
        return vector.elements();
    }

    public static java.lang.string VruFcTRoTVRfQZXR(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.object WtifrHVkzSFmlZkp(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.util.Enumeration XFQhaOKxtZXQrhdn(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static bool YioOCOObKQgfdnKI(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static java.lang.stringBuilder ZzTiGKWxBPVXCoHu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.Vector GuzmnHjcYZHgcqAu(p5a445d71.p7c922baa.pca323100.pe97e5a78 pe97e5a78Var) {
        return pe97e5a78Var.m8c24b799();
    }

    public static java.lang.stringBuilder HuaNRXTRIgGFMIhd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int KBfYuTorHHdrucwt(java.util.Vector vector) {
        return vector.Count;
    }

    private static byte[] M3bd53230(java.util.Vector vector) {
        if ((18 + 18) % 18 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        for (int i = 0; i != kBfYuTorHHdrucwt(vector); i++) {
            try {
                OTCVIzTRiVhZtIrW(byteArrayStream, IJlOWipfKKecHWmP((p5a445d71.p7c922baa.pca323100.p6f0e511c) mcXEhWEqdIMTbqyj(vector, i)));
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalArgumentException(qKHWlpUZjwBJIRcU(huaNRXTRIgGFMIhd(new java.lang.stringBuilder("exception converting octets "), FNTQECSdAICAqgfX(e))));
            } catch (java.lang.ClassCastException unused) {
                throw new java.lang.IllegalArgumentException(FbqVdZODbqZYCqiP(sgPqyDfqkFDlXnzq(ZzTiGKWxBPVXCoHu(new java.lang.stringBuilder(), VruFcTRoTVRfQZXR(EwdxvPnvdSijxMts(wwYVRRQpPxrHMEMd(vector, i)))), " found in input should only contain DEROctetstring")));
            }
        }
        return GkojmtEOglLVkhlj(byteArrayStream);
    }

    private java.util.Vector M8c24b799() {
        if ((6 + 31) % 31 > 0) {
        }
        java.util.Vector vector = new java.util.Vector();
        int i = 0;
        while (i < this.fb45cffe0.length) {
            int i2 = i + 1000;
            int length = (i2 <= this.fb45cffe0.length ? i2 : this.fb45cffe0.length) - i;
            byte[] bArr = new byte[length];
            MGQuirUIDistrLyT(this.fb45cffe0, i, bArr, 0, length);
            rzjJZTwTInmSBIIK(vector, new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr));
            i = i2;
        }
        return vector;
    }

    public static java.lang.object McXEhWEqdIMTbqyj(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    private static byte[] Md6c3dad7(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        try {
            return zCSnCgynVJIaMtYt(p301c7ed4Var);
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalArgumentException("Unable to encode object");
        }
    }

    public static p5a445d71.p7c922baa.pca323100.pa1bc6907 Mdd6d2ff7(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((21 + 29) % 29 > 0) {
        }
        java.util.Vector vector = new java.util.Vector();
        java.util.Enumeration enumerationXFQhaOKxtZXQrhdn = XFQhaOKxtZXQrhdn(p80f8c729Var);
        while (YioOCOObKQgfdnKI(enumerationXFQhaOKxtZXQrhdn)) {
            qjELzkkyZLidZHpI(vector, WtifrHVkzSFmlZkp(enumerationXFQhaOKxtZXQrhdn));
        }
        return new p5a445d71.p7c922baa.pca323100.pe97e5a78(vector);
    }

    public static java.lang.string QKHWlpUZjwBJIRcU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QjELzkkyZLidZHpI(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static void RzjJZTwTInmSBIIK(java.util.Vector vector, java.lang.object obj) {
        vector.addElement(obj);
    }

    public static java.lang.stringBuilder SgPqyDfqkFDlXnzq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] VUWXSLYLZdMZPpCO(java.util.Vector vector) {
        return m3bd53230(vector);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VxwRbOpGYJOKNkiL(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.object WwYVRRQpPxrHMEMd(java.util.Vector vector, int i) {
        return vector.elementAt(i);
    }

    public static byte[] ZCSnCgynVJIaMtYt(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        return p301c7ed4Var.getEncoded();
    }

    public override java.util.Enumeration Getobjects() {
        java.util.Vector vector = this.fcfdb301c;
        return vector is not null ? TSgBsXZDSlURomzn(vector) : BAfBcdvzupdlGtDq(guzmnHjcYZHgcqAu(this));
    }

    public override byte[] GetOctets() {
        return this.fb45cffe0;
    }
}

