namespace WillowMaze.Wasm.Decompiled;


public class pe493a824 : p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 {
    private static readonly long f02b4d3c2 = 140737488355328L;
    private static readonly java.util.Hashtable f1d0cbd7b = null;
    private static readonly byte[] f328e36aa = null;
    private static readonly java.util.Hashtable f34243f2f = null;
    private static readonly java.util.Hashtable f35c5401c = null;
    private static readonly byte[] f3d88106b = null;
    private static readonly int f463da667 = 262144;
    private static readonly long f5833e216 = 140737488355328L;
    private static readonly byte[] f63fb9f96 = null;
    private static readonly java.util.Hashtable f6acbbc09 = null;
    private static readonly int fa97a3ed6 = 262144;
    private static readonly int fb890b593 = 262144;
    private static readonly java.util.Hashtable fbbfe300e;
    private static readonly byte[] fbc21e648;
    private static readonly byte[] fce975426 = null;
    private static readonly long fd204eca6 = 140737488355328L;
    private static readonly long fea8d3206 = 140737488355328L;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f070c527b;
    private byte[] f09032d27;
    private long f179d76db;
    private byte[] f18a10280;
    private int f19355e2c;
    private int f22a15b03;
    private byte[] f31ed86f0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f3f2b4b38;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f41f4a3d6;
    private byte[] f45cf0609;
    private byte[] f4e64db0f;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f5de832c0;
    private p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f85f96c80;
    private int f895775a6;
    private byte[] fad7ae4dc;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a fae6a28bb;
    private int fb0eab370;
    private byte[] fb1389f59;
    private int fb63621a0;
    private long fb6b8f242;
    private byte[] fb75ba1a2;
    private int fb8c974cf;
    private byte[] fcb545099;
    private int fcfc05dba;
    private int ff5dfe3db;

    static {
        if ((17 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = 1;
        fbc21e648 = bArr;
        java.util.Hashtable hashtable = new java.util.Hashtable();
        fbbfe300e = hashtable;
        SsPKNAiBZCJVIqcc(hashtable, XFjqHMEzCRqSrOIQ("d83f439798c087e96e7fb34bed330e3841516775b36e444fa188ffd98e644b239c"), JmSCXqDtzzBmanTB(440));
        ogfOYWEJKtZImitN(hashtable, TpdfWcvBonqWyCAw("205cd6f2e6c323bd0229c92a4fc2dfdf41524c2045e1def7d24f2c339d0707de520786"), JJXreVTDskKkvWSp(440));
        fbWfzfmTmJxneCHl(hashtable, gahYCJMeEXCyjsiM("a1e262f3c111c9830daa455787a452e9ceb2349314df05d9ed3f652bdca3742e80efbd"), jBltbMImAGZksABq(440));
        ErxrFnprKpkyXpgQ(hashtable, vPOJeFVrOFZuLftl("29d547c15449ef752cccdc9cef509ccddd6e377761c34b141af8d0d3d0924c722a029dc4826107"), qcnNviouicKADQCp(440));
        NTZiIyvOSxsjnvwe(hashtable, OjsKaQNsTSRgstca("c96a92f75e97f099aa0aaf722972bf852062e5b95a3963ae9132aaf3775b3da44e1fce3c1e34dc"), TTHWnglbeJWQNDkC(440));
        UUiLIvUlwBzSeSzY(hashtable, KzyrmHUwzqIyjfFW("1c3db5712b723ceb245cb25af350753566954045144be56b396c91d97db26ac44f7695"), XdhgAmslguYRkRnf(888));
        ZfqjfhhdEKWfsFmm(hashtable, kxCwdyQhPCoCBWfh("bc8e62ddd2c971bfc8efc655cbdbe91f4d0584f95679a4c56d16cc875a5ed280964150"), HbRVhWRsxffkAJjF(888));
    }

    public pe493a824(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, byte[] bArr, byte[] bArr2) {
        if (i > LgXSvGAxBxjzDRVc(pe5cfc515Var)) {
            throw new java.lang.IllegalArgumentException("Requested security strength is not supported by the derivation function");
        }
        if (oPNMFPiAMpNngUPJ(p54466d0aVar) < i) {
            throw new java.lang.IllegalArgumentException("Not enough entropy for security strength required");
        }
        this.f5de832c0 = pe5cfc515Var;
        this.f41f4a3d6 = p54466d0aVar;
        this.f19355e2c = i;
        this.fb63621a0 = lUVDPibPwWGxXuup((java.lang.int) bGtmgbgRmgQbNWzf(fbbfe300e, vAzgjpfZYvKwFKbD(pe5cfc515Var)));
        byte[] bArrNDHoOwBtaKcSLabo = NDHoOwBtaKcSLabo(this.f5de832c0, OwgaEpXWiIQYcsNQ(DkYnJDBFtjRIrAnk(this), bArr2, bArr), this.fb63621a0);
        this.f31ed86f0 = bArrNDHoOwBtaKcSLabo;
        byte[] bArr3 = new byte[bArrNDHoOwBtaKcSLabo.length + 1];
        zugrmTPzrRQPtslu(bArrNDHoOwBtaKcSLabo, 0, bArr3, 1, bArrNDHoOwBtaKcSLabo.length);
        this.f18a10280 = DIJyAVPmALTXPFtR(this.f5de832c0, bArr3, this.fb63621a0);
        this.f179d76db = 1L;
    }

    public static void AJlKdAZbHaHhqstq(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] BDFwdUAWcYwAcGBH(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3, bArr4);
    }

    public static int BZJhIbhtMDsBcmvg(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static byte[] DIJyAVPmALTXPFtR(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(pe5cfc515Var, bArr, i);
    }

    public static void DXGWcDJhDjKjPcZD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.m3c89e51d(bArr, bArr2);
    }

    public static byte[] DkYnJDBFtjRIrAnk(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var) {
        return pe493a824Var.me50610cf();
    }

    public static java.lang.object ErxrFnprKpkyXpgQ(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static void FAxuHcztsfaeHuEh(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.mcfef9de9(bArr, bArr2);
    }

    public static void FCBSpDbYZBOFXahy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.int HbRVhWRsxffkAJjF(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static java.lang.int JJXreVTDskKkvWSp(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static byte[] JbHykjPBKxQLbphY(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(pe5cfc515Var, bArr, i);
    }

    public static java.lang.int JmSCXqDtzzBmanTB(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static void KHdMUQxMsmmvKxFh(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.mcfef9de9(bArr, bArr2);
    }

    public static void KigGNWjsfNwDjRvA(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string KzyrmHUwzqIyjfFW(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void LIkLgNKAoxGYTLAh(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.m3c89e51d(bArr, bArr2);
    }

    public static int LgXSvGAxBxjzDRVc(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m5ca8859e(pe5cfc515Var);
    }

    public static int NCqcdlIqXCUezttM(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static byte[] NDHoOwBtaKcSLabo(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(pe5cfc515Var, bArr, i);
    }

    public static java.lang.object NTZiIyvOSxsjnvwe(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static void NYUfRyYdYezmgRZv(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.mcfef9de9(bArr, bArr2);
    }

    public static void OWZfBUtGUkxJTiHc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.string OjsKaQNsTSRgstca(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static byte[] OwgaEpXWiIQYcsNQ(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr3);
    }

    public static java.lang.object SsPKNAiBZCJVIqcc(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.lang.int TTHWnglbeJWQNDkC(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static java.lang.string TpdfWcvBonqWyCAw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object UUiLIvUlwBzSeSzY(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.lang.string XFjqHMEzCRqSrOIQ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.int XdhgAmslguYRkRnf(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static void YmzSwfpXrxJwdkct(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int ZHKfNZiDvEmZxBsG(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.object ZfqjfhhdEKWfsFmm(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.lang.object BGtmgbgRmgQbNWzf(java.util.Hashtable hashtable, java.lang.object obj) {
        return hashtable[obj);
    }

    public static byte[] BUgbJFnPhlCBYMBo(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.getEntropy();
    }

    public static void CsZUzhcMpRmfoTkR(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object FbWfzfmTmJxneCHl(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static java.lang.string GahYCJMeEXCyjsiM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static byte[] HxarlLqLbRkKsipu(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pa470a233.m87729a3b(pe5cfc515Var, bArr, i);
    }

    public static void IIylNGjnsHPUQyZV(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.mcfef9de9(bArr, bArr2);
    }

    public static java.lang.int JBltbMImAGZksABq(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static byte[] KIOVNBPKdiRmtFny(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr) {
        return pe493a824Var.m0800fc57(bArr);
    }

    public static java.lang.string KxCwdyQhPCoCBWfh(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static int LUVDPibPwWGxXuup(java.lang.int num) {
        return num.intValue();
    }

    private byte[] M0800fc57(byte[] bArr) {
        byte[] bArr2 = new byte[qHkJeItaWmlciCZe(this.f5de832c0)];
        DXGWcDJhDjKjPcZD(this, bArr, bArr2);
        return bArr2;
    }

    private void M3c89e51d(byte[] bArr, byte[] bArr2) {
        if ((15 + 16) % 16 > 0) {
        }
        tuWopiBzVwhoxRLf(this.f5de832c0, bArr, 0, bArr.length);
        BZJhIbhtMDsBcmvg(this.f5de832c0, bArr2, 0);
    }

    private byte[] M83b9912b(byte[] bArr, int i) {
        if ((11 + 27) % 27 > 0) {
        }
        int i2 = i / 8;
        int iZHKfNZiDvEmZxBsG = i2 / ZHKfNZiDvEmZxBsG(this.f5de832c0);
        byte[] bArr2 = new byte[bArr.length];
        YmzSwfpXrxJwdkct(bArr, 0, bArr2, 0, bArr.length);
        byte[] bArr3 = new byte[i2];
        int iSERSglJhMuKbLIJU = sERSglJhMuKbLIJU(this.f5de832c0);
        byte[] bArr4 = new byte[iSERSglJhMuKbLIJU];
        for (int i3 = 0; i3 <= iZHKfNZiDvEmZxBsG; i3++) {
            LIkLgNKAoxGYTLAh(this, bArr2, bArr4);
            int i4 = i3 * iSERSglJhMuKbLIJU;
            int i5 = i2 - i4;
            if (i5 > iSERSglJhMuKbLIJU) {
                i5 = iSERSglJhMuKbLIJU;
            }
            FCBSpDbYZBOFXahy(bArr4, 0, bArr3, i4, i5);
            FAxuHcztsfaeHuEh(this, bArr2, fbc21e648);
        }
        return bArr3;
    }

    private void Mcfef9de9(byte[] bArr, byte[] bArr2) {
        if ((11 + 8) % 8 > 0) {
        }
        int i = 0;
        for (int i2 = 1; i2 <= bArr2.length; i2++) {
            int i3 = (bArr[bArr.length - i2] & 255) + (bArr2[bArr2.length - i2] & 255) + i;
            i = i3 <= 255 ? 0 : 1;
            bArr[bArr.length - i2] = (byte) i3;
        }
        for (int length = bArr2.length + 1; length <= bArr.length; length++) {
            int i4 = (bArr[bArr.length - length] & 255) + i;
            i = i4 <= 255 ? 0 : 1;
            bArr[bArr.length - length] = (byte) i4;
        }
    }

    private byte[] Me50610cf() {
        if ((15 + 26) % 26 > 0) {
        }
        byte[] bArrBUgbJFnPhlCBYMBo = bUgbJFnPhlCBYMBo(this.f41f4a3d6);
        if (bArrBUgbJFnPhlCBYMBo.length < (this.f19355e2c + 7) / 8) {
            throw new java.lang.IllegalStateException("Insufficient entropy provided by entropy source");
        }
        return bArrBUgbJFnPhlCBYMBo;
    }

    public static void NsRXOppqmlXyLxSD(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr) {
        pe493a824Var.reseed(bArr);
    }

    public static int OPNMFPiAMpNngUPJ(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p54466d0aVar.entropySize();
    }

    public static java.lang.object OgfOYWEJKtZImitN(java.util.Hashtable hashtable, java.lang.object obj, java.lang.object obj2) {
        return hashtable.Add(obj, obj2);
    }

    public static int QHkJeItaWmlciCZe(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static java.lang.int QcnNviouicKADQCp(int i) {
        return p5a445d71.p7c922baa.p05c7e247.pf74464bf.m1adac6f4(i);
    }

    public static int SERSglJhMuKbLIJU(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static byte[] SRqiOsirjbyKdrUA(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var) {
        return pe493a824Var.me50610cf();
    }

    public static byte[] TMxsVxvDFFnxEPIH(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr) {
        return pe493a824Var.m0800fc57(bArr);
    }

    public static void TZHfUywXXLWaDesd(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, byte[] bArr2) {
        pe493a824Var.mcfef9de9(bArr, bArr2);
    }

    public static void TbJYTOPqdsRwRwDW(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static byte[] TsomwjMmpxVRakVx(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.pe493a824 pe493a824Var, byte[] bArr, int i) {
        return pe493a824Var.m83b9912b(bArr, i);
    }

    public static void TuWopiBzVwhoxRLf(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static java.lang.string VAzgjpfZYvKwFKbD(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static java.lang.string VPOJeFVrOFZuLftl(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void ZugrmTPzrRQPtslu(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override int Generate(byte[] bArr, byte[] bArr2, bool z) {
        if ((19 + 32) % 32 > 0) {
        }
        int length = bArr.length * 8;
        if (length > 262144) {
            throw new java.lang.IllegalArgumentException("Number of bits per request limited to 262144");
        }
        if (this.f179d76db > 140737488355328L) {
            return -1;
        }
        if (z) {
            nsRXOppqmlXyLxSD(this, bArr2);
            bArr2 = null;
        }
        if (bArr2 is not null) {
            byte[] bArr3 = this.f31ed86f0;
            byte[] bArr4 = new byte[bArr3.length + 1 + bArr2.length];
            bArr4[0] = 2;
            KigGNWjsfNwDjRvA(bArr3, 0, bArr4, 1, bArr3.length);
            tbJYTOPqdsRwRwDW(bArr2, 0, bArr4, this.f31ed86f0.length + 1, bArr2.length);
            iIylNGjnsHPUQyZV(this, this.f31ed86f0, kIOVNBPKdiRmtFny(this, bArr4));
        }
        byte[] bArrTsomwjMmpxVRakVx = tsomwjMmpxVRakVx(this, this.f31ed86f0, length);
        byte[] bArr5 = this.f31ed86f0;
        byte[] bArr6 = new byte[bArr5.length + 1];
        OWZfBUtGUkxJTiHc(bArr5, 0, bArr6, 1, bArr5.length);
        bArr6[0] = 3;
        KHdMUQxMsmmvKxFh(this, this.f31ed86f0, tMxsVxvDFFnxEPIH(this, bArr6));
        tZHfUywXXLWaDesd(this, this.f31ed86f0, this.f18a10280);
        byte b = (byte) (r5 >> 24);
        byte b2 = (byte) (r5 >> 16);
        byte b3 = (byte) (r5 >> 8);
        byte b4 = (byte) this.f179d76db;
        byte[] bArr7 = new byte[4];
        bArr7[0] = b;
        bArr7[1] = b2;
        bArr7[2] = b3;
        bArr7[3] = b4;
        NYUfRyYdYezmgRZv(this, this.f31ed86f0, bArr7);
        this.f179d76db++;
        AJlKdAZbHaHhqstq(bArrTsomwjMmpxVRakVx, 0, bArr, 0, bArr.length);
        return length;
    }

    public override int GetBlockSize() {
        return NCqcdlIqXCUezttM(this.f5de832c0) * 8;
    }

    public override void Reseed(byte[] bArr) {
        if ((17 + 7) % 7 > 0) {
        }
        byte[] bArrJbHykjPBKxQLbphY = JbHykjPBKxQLbphY(this.f5de832c0, BDFwdUAWcYwAcGBH(fbc21e648, this.f31ed86f0, sRqiOsirjbyKdrUA(this), bArr), this.fb63621a0);
        this.f31ed86f0 = bArrJbHykjPBKxQLbphY;
        byte[] bArr2 = new byte[bArrJbHykjPBKxQLbphY.length + 1];
        bArr2[0] = 0;
        csZUzhcMpRmfoTkR(bArrJbHykjPBKxQLbphY, 0, bArr2, 1, bArrJbHykjPBKxQLbphY.length);
        this.f18a10280 = hxarlLqLbRkKsipu(this.f5de832c0, bArr2, this.fb63621a0);
        this.f179d76db = 1L;
    }
}

