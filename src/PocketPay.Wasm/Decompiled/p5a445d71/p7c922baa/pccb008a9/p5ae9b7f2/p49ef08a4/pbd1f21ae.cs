namespace WillowMaze.Wasm.Decompiled;


public class pbd1f21ae : p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p3f7a5eaa {
    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 f2510c390;
    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 f2ed0d892;
    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 f51f8bbce;
    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 f5ebb54fa;
    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 fa1f50ff7;

    public pbd1f21ae(java.io.Stream inputStream, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var) throws java.io.IOException {
        super(false, p4068e159Var);
        this.f2510c390 = SIabdLkOBkUvskKk(inputStream, p4068e159Var.f8d9c307c, p4068e159Var.f7694f4a6);
    }

    public pbd1f21ae(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var) {
        super(false, p4068e159Var);
        this.f2510c390 = p78b04208Var;
    }

    public pbd1f21ae(byte[] bArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var) {
        super(false, p4068e159Var);
        this.f2510c390 = XlXcZaonfmuUaIXl(bArr, p4068e159Var.f8d9c307c, p4068e159Var.f7694f4a6);
    }

    public static bool JxeBktZNpCOiJmqO(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var, java.lang.object obj) {
        return p4068e159Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 SIabdLkOBkUvskKk(java.io.Stream inputStream, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208.mc849dc49(inputStream, i, i2);
    }

    public static bool USZrBJijLAlmzrvo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, java.lang.object obj) {
        return p78b04208Var.Equals(obj);
    }

    public static int WFtuotgsCUoeGZOx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 XlXcZaonfmuUaIXl(byte[] bArr, int i, int i2) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208.mc849dc49(bArr, i, i2);
    }

    public static byte[] FicOjvgyoYrKnIRZ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.pbd1f21ae pbd1f21aeVar) {
        return pbd1f21aeVar.getEncoded();
    }

    public static int HCjbPIprtAkMClJW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p4068e159 p4068e159Var) {
        return p4068e159Var.GetHashCode();
    }

    public static void MWxsqPEQuVvOKbxr(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static byte[] WuzfAlCnEaSaPuhS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var, int i) {
        return p78b04208Var.toBinary(i);
    }

    public bool Equals(java.lang.object obj) {
        if ((20 + 27) % 27 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || !(obj is p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.pbd1f21ae)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.pbd1f21ae pbd1f21aeVar = (p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.pbd1f21ae) obj;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = this.f2510c390;
        if (p78b04208Var is not null) {
            if (!USZrBJijLAlmzrvo(p78b04208Var, pbd1f21aeVar.f2510c390)) {
                return false;
            }
        } else if (pbd1f21aeVar.f2510c390 is not null) {
            return false;
        }
        if (this.f21ffce5b is not null) {
            if (!JxeBktZNpCOiJmqO(this.f21ffce5b, pbd1f21aeVar.f21ffce5b)) {
                return false;
            }
        } else if (pbd1f21aeVar.f21ffce5b is not null) {
            return false;
        }
        return true;
    }

    public byte[] GetEncoded() {
        return wuzfAlCnEaSaPuhS(this.f2510c390, this.f21ffce5b.f7694f4a6);
    }

    public int HashCode() {
        if ((11 + 4) % 4 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p49ef08a4.p89693d33.p78b04208 p78b04208Var = this.f2510c390;
        return (((p78b04208Var is not null ? WFtuotgsCUoeGZOx(p78b04208Var) : 0) + 31) * 31) + (this.f21ffce5b is not null ? hCjbPIprtAkMClJW(this.f21ffce5b) : 0);
    }

    public void WriteTo(java.io.Stream outputStream) throws java.io.IOException {
        mWxsqPEQuVvOKbxr(outputStream, ficOjvgyoYrKnIRZ(this));
    }
}

