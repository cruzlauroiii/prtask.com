namespace WillowMaze.Wasm.Decompiled;


public class p64a11661 : p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 {
    private static readonly int[] f10cb9aa8 = null;
    private static readonly int[] f13d47beb = null;
    private static readonly int[] f19256c2b = null;
    private static readonly int[] f301d90e3 = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, int.MIN_VALUE, 0};
    private static readonly int[] f7d302144 = null;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f84fbe9fa;
    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f89693d33;

    public p64a11661(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, java.util.Random random) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = frUWWdpVIFrlkApr(this.f0cab8ba8);
        this.f89693d33 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        AVVJLaKWqjVQAUDr(this, random);
    }

    public p64a11661(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = WoCdiBVduFZOptaa(this.f0cab8ba8);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        this.f89693d33 = p31c30ba9Var2;
        zHvNMNqOiFFCrfjh(p31c30ba9Var2, this.f91243d4a);
    }

    public p64a11661(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, byte[] bArr) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = VeNfzIlFYCoaByCx(this.f0cab8ba8);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, bArr);
        this.f89693d33 = p31c30ba9Var;
        UJxtXiWcvwQvAgyc(p31c30ba9Var, this.f91243d4a);
    }

    public p64a11661(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, int[] iArr) {
        if ((18 + 32) % 32 > 0) {
        }
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = xZbXEiTLwDnGGtyD(this.f0cab8ba8);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, iArr);
        this.f89693d33 = p31c30ba9Var;
        jYMCFJWnxuIKWiNI(p31c30ba9Var, p60c83654Var.f91243d4a);
    }

    public p64a11661(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        this.f0cab8ba8 = p64a11661Var.f0cab8ba8;
        this.f91243d4a = p64a11661Var.f91243d4a;
        this.f89693d33 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p64a11661Var.f89693d33);
    }

    public static int[] AAncmMvslIDaidgs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.getPc();
    }

    public static void AVVJLaKWqjVQAUDr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, java.util.Random random) {
        p64a11661Var.m720d57fa(random);
    }

    public static void AZyXmgHYguIOyghy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, int[] iArr) {
        p64a11661Var.mae71c0e6(iArr);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 AntZkZjrmKMtpvjP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.m67055f8a();
    }

    public static bool BNdjXKgfIGEHUqLs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, java.lang.object obj) {
        return p31c30ba9Var.Equals(obj);
    }

    public static void BcrAVgYKnQAMlFeu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, int i) {
        p64a11661Var.m8adb9e12(i);
    }

    public static void BeWMHIXowXKYNhhM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.shiftRightThis();
    }

    public static void BoqtNYurwqzGYgdM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void BqBHwalXdsfZkGsZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.setBit(i);
    }

    public static int CqckSGfIQMQRQybi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.getDegree();
    }

    public static void DNbeDlqgVmQTOOWI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 DSKfMlXeNwoXgEYQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.squarePreCalc();
    }

    public static java.math.Bigint DeCWKimcsMbWLthu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.toFlexiBigInt();
    }

    public static void DsenugpeWNGAzDKk(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 DuZMbGoHPLOBnEhK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.m67055f8a();
    }

    public static java.lang.string EBEfVOMVNggmASbw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.tostring(i);
    }

    public static void ELdBLqDvRozBFCqA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignOne();
    }

    public static void ETHuxmpPRDjmxvhb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.addToThis(pa7462101Var);
    }

    public static int FEKOpGlWaLDsmwFt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static void FGZRpbEznazZwzQm(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.multiplyThisBy(pa7462101Var);
    }

    public static void GDsWvRZTOnTCGXLN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static bool GZsUmlCKGousTvPK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isZero();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 HOkCFzFblCNVAfGB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.remainder(p31c30ba9Var2);
    }

    public static bool HRzEuqMWSJjjKoqi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, java.lang.object obj) {
        return p31c30ba9Var.Equals(obj);
    }

    public static void HVEvWMzAtjlvQCpZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.multiplyThisBy(pa7462101Var);
    }

    public static void HyAKWNLkurZwVJyV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.multiplyThisBy(pa7462101Var);
    }

    public static bool HyXCNOdOVyOfAcNE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static int IsmgExCOlSclQPFL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.GetHashCode();
    }

    public static void JJhaRbycVcNGtsTr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void MEUxZnDlNCiONPyR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisBitwise();
    }

    public static void MlRzctBaCyoVqpeR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static void NLQjaDUXFDsObdWh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static int NTUQfJJlppEDaenB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static bool NjdqOhIIOHhfnCpH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.isPentanomial();
    }

    public static void OUVHsJKfhwSGimQz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, java.util.Random random) {
        p31c30ba9Var.randomize(random);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 PUxVnGbdXBJUlHjv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.multiply(p31c30ba9Var2);
    }

    public static void PemkhsBamSminUng(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void QKVhKIbRNicVxlSk(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.addToThis(pa7462101Var);
    }

    public static void QkAHASyrovpKkKdT(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 QsslPXhTiBJfgIoL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return m529e9e0b(p60c83654Var);
    }

    public static bool RoYCAPuJZDWnuJco(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isOne();
    }

    public static byte[] SDmRTOSGYUoTejhs(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.tobyteArray();
    }

    public static void SHRhafDuoptvkfTK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void SfnbybVemdQtSKFe(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static int SrQbjZbrjJMHEpYj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void TWAtqbEWLxjxfRdu(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.squareThisBitwise();
    }

    public static void TivBthyMOlGIqLwy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static int UAIiWHvJbtOqkmev(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void UJxtXiWcvwQvAgyc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void UPRnvDvTxkelACET(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static bool UpSYpxUJxBdEiaPx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isOne();
    }

    public static void UzFIsHefmuUndGQK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static void VUvNCIDdsJTkhDvo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static int VeNfzIlFYCoaByCx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static bool VfpaELjpdeyKAasJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, java.lang.object obj) {
        return p64a11661Var.Equals(obj);
    }

    public static void VmkUgcMHFKcwTruZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static void WNbaOITnuAjvKWKc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.assignZero();
    }

    public static bool WZzNNemAibmqlArJ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isOne();
    }

    public static void WhIUTevQzbcuEaSC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 WlJPVALvLGnXvPMP(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p64a11661Var.multiply(pa7462101Var);
    }

    public static int WoCdiBVduFZOptaa(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static bool XBKYzcIsBwsnWZQW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void XViSnJiCYptLeJCx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisPreCalc();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 XZLYSDJKNrvZSJrz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.invertMAIA();
    }

    public static void XdlFTGTuIluBjiNL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i, int[] iArr) {
        p31c30ba9Var.reducePentanomial(i, iArr);
    }

    public static void XfNtzaDuSXDyFMOd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.addToThis(pa7462101Var);
    }

    public static int XvKyvpsPxzTcNNSd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static bool XvyWGmPSJjnTRJXM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, java.lang.object obj) {
        return p64a11661Var.Equals(obj);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 YBlktltalCrOgTwf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static void YNxoEvabMbXAEeud(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 YUEfyuFBgRqsCnXp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static void YguzhYYFxoreyoqf(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static void ZpVcvJdzOkFMSMrU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.addToThis(pa7462101Var);
    }

    public static void AIbNKIpqnoiClKao(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.squareThisPreCalc();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 AKwkRiqOHTfDeNjB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.square();
    }

    public static void AiqrDkxHyZxKTorj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static void BIhwoQmGlXNweZCb(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static void BOmTqrrYIoYdupbc(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.shiftRightThis();
    }

    public static void BelVQDmePJYLWvWG(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareRootThis();
    }

    public static void BuIbmKIBNBRZIzlg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void CckAHYcdKlUwruAN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i, int i2) {
        p31c30ba9Var.reduceTrinomial(i, i2);
    }

    public static void CcuFHDGexnRKjhPH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.addToThis(pa7462101Var);
    }

    public static java.lang.string CdTRnAhBZoLuWUak(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.tostring(i);
    }

    public static void CgMMbpSpxwUSnrwj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisPreCalc();
    }

    public static bool DSPLOgTBfiTSKeXd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.isTrinomial();
    }

    public static int DsbuHzMaZgnbujvY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void DsdEZlOXagXGRdsv(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void DvWIWQmUxXBGLYNY(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static void DxWylIVJCssdGIPI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static void DyGHnLhcfhHYecNA(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.increaseThis();
    }

    public static void EVgaZDQdzSNUogFI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisPreCalc();
    }

    public static int EwTGdzfCivaYaBAN(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.getDegree();
    }

    public static bool FUiFtWOFRyXRUyPy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, java.lang.object obj) {
        return paf03ad66Var.Equals(obj);
    }

    public static int FrUWWdpVIFrlkApr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static void FtTbgdseWIGiirTK(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        p31c30ba9Var.addToThis(p31c30ba9Var2);
    }

    public static int FusbyNCdbbTJylzd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void FvVCxoRiWqdiQPHX(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void FzAyymepHnuBcWtz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisMatrix();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 GykapfSWQRPiOzni(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return m529e9e0b(p60c83654Var);
    }

    public static void HgKvucmUeRZnyUno(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        p64a11661Var.multiplyThisBy(pa7462101Var);
    }

    public static void HgzCbnyCRftmFFAq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static bool IMXvDvGWhMhkkhSp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isZero();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 IPTPqPNYWCHcgQPS(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.square();
    }

    public static int JWUmcYoEzMfcvzDz(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void JYMCFJWnxuIKWiNI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void JuZDMltQJplZwmdC(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static void KMvOnzjSRyTlydoV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static bool KiIpAioErVVWkkkh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void LLUgZodCSwtMKjso(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static void LTUjxcbqScUKnYyo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static int LUwVYNMbJWDRCZhB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.GetHashCode();
    }

    public static void LsvHXTNmPPrUMkXt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static void LzfYwbwOKIpWDTeU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 M529e9e0b(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        if ((5 + 29) % 29 > 0) {
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p60c83654Var, new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(CqckSGfIQMQRQybi(p60c83654Var)));
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M67055f8a() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f89693d33);
    }

    private void M720d57fa(java.util.Random random) {
        if ((16 + 26) % 26 > 0) {
        }
        dsdEZlOXagXGRdsv(this.f89693d33, this.f91243d4a);
        OUVHsJKfhwSGimQz(this.f89693d33, random);
    }

    private void M8adb9e12(int i) {
        if ((13 + 23) % 23 > 0) {
        }
        int i2 = this.f91243d4a - i;
        int iSrQbjZbrjJMHEpYj = SrQbjZbrjJMHEpYj(this.f89693d33);
        while (true) {
            iSrQbjZbrjJMHEpYj--;
            if (iSrQbjZbrjJMHEpYj < this.f91243d4a) {
                qOMsMhJBwdkkKfEV(this.f89693d33);
                opouHrjnHgekAiLE(this.f89693d33, this.f91243d4a);
                return;
            } else if (rDBuFyPpZQWnMMnR(this.f89693d33, iSrQbjZbrjJMHEpYj)) {
                lzfYwbwOKIpWDTeU(this.f89693d33, iSrQbjZbrjJMHEpYj);
                GDsWvRZTOnTCGXLN(this.f89693d33, iSrQbjZbrjJMHEpYj - i2);
                QkAHASyrovpKkKdT(this.f89693d33, iSrQbjZbrjJMHEpYj - this.f91243d4a);
            }
        }
    }

    private p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 M8ae6f599() throws java.lang.Exception {
        if ((20 + 27) % 27 > 0) {
        }
        if ((this.f91243d4a & 1) == 0) {
            throw new java.lang.Exception();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        for (int i = 1; i <= ((this.f91243d4a - 1) >> 1); i++) {
            hgzCbnyCRftmFFAq(p64a11661Var);
            kMvOnzjSRyTlydoV(p64a11661Var);
            ccuFHDGexnRKjhPH(p64a11661Var, this);
        }
        return p64a11661Var;
    }

    public static int MULjaEsKeJSyxarw(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void MaLphTKCbHgpAaWZ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.shiftRightThis();
    }

    private void Mae71c0e6(int[] iArr) {
        if ((31 + 18) % 18 > 0) {
        }
        int i = this.f91243d4a - iArr[2];
        int i2 = this.f91243d4a - iArr[1];
        int i3 = this.f91243d4a - iArr[0];
        for (int iOhiNecIbdDsBmeSR = ohiNecIbdDsBmeSR(this.f89693d33) - 1; iOhiNecIbdDsBmeSR >= this.f91243d4a; iOhiNecIbdDsBmeSR--) {
            if (XBKYzcIsBwsnWZQW(this.f89693d33, iOhiNecIbdDsBmeSR)) {
                NLQjaDUXFDsObdWh(this.f89693d33, iOhiNecIbdDsBmeSR);
                DsenugpeWNGAzDKk(this.f89693d33, iOhiNecIbdDsBmeSR - i);
                VmkUgcMHFKcwTruZ(this.f89693d33, iOhiNecIbdDsBmeSR - i2);
                xUnDDgRSOShtXBUI(this.f89693d33, iOhiNecIbdDsBmeSR - i3);
                juZDMltQJplZwmdC(this.f89693d33, iOhiNecIbdDsBmeSR - this.f91243d4a);
            }
        }
        vtvVYHvOEImKlryX(this.f89693d33);
        buIbmKIBNBRZIzlg(this.f89693d33, this.f91243d4a);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 Mbc21e648(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        if ((2 + 19) % 19 > 0) {
        }
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p60c83654Var, new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(ewTGdzfCivaYaBAN(p60c83654Var), new int[]{1}));
    }

    private void Md6a01b30() {
        if ((27 + 6) % 6 > 0) {
        }
        if (jWUmcYoEzMfcvzDz(this.f89693d33) <= this.f91243d4a) {
            if (XvKyvpsPxzTcNNSd(this.f89693d33) >= this.f91243d4a) {
                return;
            }
            rYEgNUyOvBhqKeDd(this.f89693d33, this.f91243d4a);
            return;
        }
        if (dSPLOgTBfiTSKeXd((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8)) {
            try {
                int iTwqWvcuStWTKjvai = twqWvcuStWTKjvai((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
                if (this.f91243d4a - iTwqWvcuStWTKjvai > 32 && mebpcgVuGSTIsPqx(this.f89693d33) <= (this.f91243d4a << 1)) {
                    cckAHYcdKlUwruAN(this.f89693d33, this.f91243d4a, iTwqWvcuStWTKjvai);
                    return;
                } else {
                    BcrAVgYKnQAMlFeu(this, iTwqWvcuStWTKjvai);
                    return;
                }
            } catch (java.lang.Exception unused) {
                throw new java.lang.Exception("GF2nPolynomialElement.reduce: the field polynomial is not a trinomial");
            }
        }
        if (!NjdqOhIIOHhfnCpH((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8)) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarHOkCFzFblCNVAfGB = HOkCFzFblCNVAfGB(this.f89693d33, pTWHmavBBGGGSPfI(this.f0cab8ba8));
            this.f89693d33 = p31c30ba9VarHOkCFzFblCNVAfGB;
            fvVCxoRiWqdiQPHX(p31c30ba9VarHOkCFzFblCNVAfGB, this.f91243d4a);
            return;
        }
        try {
            int[] iArrAAncmMvslIDaidgs = AAncmMvslIDaidgs((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
            if (this.f91243d4a - iArrAAncmMvslIDaidgs[2] > 32 && dsbuHzMaZgnbujvY(this.f89693d33) <= (this.f91243d4a << 1)) {
                XdlFTGTuIluBjiNL(this.f89693d33, this.f91243d4a, iArrAAncmMvslIDaidgs);
            } else {
                AZyXmgHYguIOyghy(this, iArrAAncmMvslIDaidgs);
            }
        } catch (java.lang.Exception unused2) {
            throw new java.lang.Exception("GF2nPolynomialElement.reduce: the field polynomial is not a pentanomial");
        }
    }

    public static int MebpcgVuGSTIsPqx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void MubsPyOuRAVVhmNH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static bool MvNinEOkCGaFViOq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var, java.lang.object obj) {
        return paf03ad66Var.Equals(obj);
    }

    public static java.lang.object NGYWRlmjroLFxKLH(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.clone();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 NrOgBGYSBgoGeiqo(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.m8ae6f599();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 OYDfHHQWyMwIPbSi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static int OhiNecIbdDsBmeSR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void OpouHrjnHgekAiLE(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 PTWHmavBBGGGSPfI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static void PeQXSmAijsfHftKg(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void QOMsMhJBwdkkKfEV(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static bool QUCxhaxQTAqFRmTU(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.isOne();
    }

    public static void QjwoVnsXRroYTZLy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public static bool RDBuFyPpZQWnMMnR(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void RYEgNUyOvBhqKeDd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static bool RaPTIKxzuGzgYxLB(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2) {
        return p31c30ba9Var.vectorMult(p31c30ba9Var2);
    }

    public static bool RhJDxuYspSVWgHab(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isZero();
    }

    public static void SFbRctEIfswnRKUt(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 SSgKTTnnQyJHaoLx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) {
        return p1bf4f0f9Var.Add(pa7462101Var);
    }

    public static void TRRPmbNFhDUYfnfi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisPreCalc();
    }

    public static bool TSAZPmitJTSchzRx(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isZero();
    }

    public static bool TbdbdWujhFdFTTGM(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 TidyTrlMrrxEOpal(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static int TwqWvcuStWTKjvai(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return p60c83654Var.getTc();
    }

    public static bool UOKWmZzuFfILzuaL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isZero();
    }

    public static int UVDpjsSOZJAtpKad(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m1d16fd25(i);
    }

    public static void UpzBwgEHDGSbdEVW(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static int UqazLoSnGMQErGsd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        return p31c30ba9Var.getLength();
    }

    public static void VtvVYHvOEImKlryX(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void WetrdwMoEBmxTLmi(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void WfKcnVNkADJMIWXL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.md6a01b30();
    }

    public static void WwhxJFNjPbcvkTLq(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThisPreCalc();
    }

    public static void WxkEGXKbjaFYSsXj(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.increaseThis();
    }

    public static bool XNTakdcTXITJZrVp(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        return p64a11661Var.isZero();
    }

    public static void XUnDDgRSOShtXBUI(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.xorBit(i);
    }

    public static int XZbXEiTLwDnGGtyD(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getDegree();
    }

    public static void XlHKDdJJcyrnFVkl(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p31c30ba9Var.reduceN();
    }

    public static void XwvJubYiXEVcNXAQ(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        p64a11661Var.squareThis();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 YOiijpWfqTgyNnGk(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        return paf03ad66Var.getFieldPolynomial();
    }

    public static p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 YdAcnXwFdpfqAllL(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        return mbc21e648(p60c83654Var);
    }

    public static void ZHvNMNqOiFFCrfjh(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        p31c30ba9Var.expandN(i);
    }

    public static bool ZxURqEhaWedrqnFr(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, int i) {
        return p31c30ba9Var.testBit(i);
    }

    public static void ZxivyqeBDVmCghYd(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2, int i) {
        p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, i);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Add(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        ETHuxmpPRDjmxvhb(p64a11661Var, pa7462101Var);
        return p64a11661Var;
    }

    public override void AddToThis(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((31 + 31) % 31 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) pa7462101Var;
        if (!mvNinEOkCGaFViOq(this.f0cab8ba8, p64a11661Var.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        SfnbybVemdQtSKFe(this.f89693d33, p64a11661Var.f89693d33);
    }

    void assignOne() {
        ELdBLqDvRozBFCqA(this.f89693d33);
    }

    void assignZero() {
        WNbaOITnuAjvKWKc(this.f89693d33);
    }

    public override java.lang.object Clone() {
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
    }

    public override bool Equals(java.lang.object obj) {
        if ((32 + 23) % 23 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            return false;
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) obj;
        if (this.f0cab8ba8 == p64a11661Var.f0cab8ba8 || HRzEuqMWSJjjKoqi(yOiijpWfqTgyNnGk(this.f0cab8ba8), tidyTrlMrrxEOpal(p64a11661Var.f0cab8ba8))) {
            return BNdjXKgfIGEHUqLs(this.f89693d33, p64a11661Var.f89693d33);
        }
        return false;
    }

    public override int HashCode() {
        return lUwVYNMbJWDRCZhB(this.f0cab8ba8) + IsmgExCOlSclQPFL(this.f89693d33);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        dyGHnLhcfhHYecNA(p64a11661Var);
        return p64a11661Var;
    }

    public override void IncreaseThis() {
        wxkEGXKbjaFYSsXj(this.f89693d33);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Invert() throws java.lang.ArithmeticException {
        return XZLYSDJKNrvZSJrz(this);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertEEA() throws java.lang.ArithmeticException {
        if ((7 + 29) % 29 > 0) {
        }
        if (tSAZPmitJTSchzRx(this)) {
            throw new java.lang.ArithmeticException();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 32, "ONE");
        WhIUTevQzbcuEaSC(p31c30ba9Var);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 32);
        BoqtNYurwqzGYgdM(p31c30ba9Var2);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarDuZMbGoHPLOBnEhK = DuZMbGoHPLOBnEhK(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarYBlktltalCrOgTwf = YBlktltalCrOgTwf(this.f0cab8ba8);
        peQXSmAijsfHftKg(p31c30ba9VarDuZMbGoHPLOBnEhK);
        while (!RoYCAPuJZDWnuJco(p31c30ba9VarDuZMbGoHPLOBnEhK)) {
            lTUjxcbqScUKnYyo(p31c30ba9VarDuZMbGoHPLOBnEhK);
            upzBwgEHDGSbdEVW(p31c30ba9VarYBlktltalCrOgTwf);
            int iFusbyNCdbbTJylzd = fusbyNCdbbTJylzd(p31c30ba9VarDuZMbGoHPLOBnEhK) - UAIiWHvJbtOqkmev(p31c30ba9VarYBlktltalCrOgTwf);
            if (iFusbyNCdbbTJylzd < 0) {
                iFusbyNCdbbTJylzd = -iFusbyNCdbbTJylzd;
                xlHKDdJJcyrnFVkl(p31c30ba9Var);
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var2;
                p31c30ba9Var2 = p31c30ba9Var;
                p31c30ba9Var = p31c30ba9Var3;
                p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9VarYBlktltalCrOgTwf;
                p31c30ba9VarYBlktltalCrOgTwf = p31c30ba9VarDuZMbGoHPLOBnEhK;
                p31c30ba9VarDuZMbGoHPLOBnEhK = p31c30ba9Var4;
            }
            qjwoVnsXRroYTZLy(p31c30ba9VarDuZMbGoHPLOBnEhK, p31c30ba9VarYBlktltalCrOgTwf, iFusbyNCdbbTJylzd);
            zxivyqeBDVmCghYd(p31c30ba9Var, p31c30ba9Var2, iFusbyNCdbbTJylzd);
        }
        TivBthyMOlGIqLwy(p31c30ba9Var);
        return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, p31c30ba9Var);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertMAIA() throws java.lang.ArithmeticException {
        if ((15 + 8) % 8 > 0) {
        }
        if (iMXvDvGWhMhkkhSp(this)) {
            throw new java.lang.ArithmeticException();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, "ONE");
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarAntZkZjrmKMtpvjP = AntZkZjrmKMtpvjP(this);
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarYUEfyuFBgRqsCnXp = YUEfyuFBgRqsCnXp(this.f0cab8ba8);
        while (true) {
            if (!zxURqEhaWedrqnFr(p31c30ba9VarAntZkZjrmKMtpvjP, 0)) {
                maLphTKCbHgpAaWZ(p31c30ba9VarAntZkZjrmKMtpvjP);
                if (HyXCNOdOVyOfAcNE(p31c30ba9Var, 0)) {
                    ftTbgdseWIGiirTK(p31c30ba9Var, oYDfHHQWyMwIPbSi(this.f0cab8ba8));
                    BeWMHIXowXKYNhhM(p31c30ba9Var);
                } else {
                    bOmTqrrYIoYdupbc(p31c30ba9Var);
                }
            } else {
                if (WZzNNemAibmqlArJ(p31c30ba9VarAntZkZjrmKMtpvjP)) {
                    return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, p31c30ba9Var);
                }
                JJhaRbycVcNGtsTr(p31c30ba9VarAntZkZjrmKMtpvjP);
                SHRhafDuoptvkfTK(p31c30ba9VarYUEfyuFBgRqsCnXp);
                if (uqazLoSnGMQErGsd(p31c30ba9VarAntZkZjrmKMtpvjP) < mULjaEsKeJSyxarw(p31c30ba9VarYUEfyuFBgRqsCnXp)) {
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var2;
                    p31c30ba9Var2 = p31c30ba9Var;
                    p31c30ba9Var = p31c30ba9Var3;
                    p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9VarYUEfyuFBgRqsCnXp;
                    p31c30ba9VarYUEfyuFBgRqsCnXp = p31c30ba9VarAntZkZjrmKMtpvjP;
                    p31c30ba9VarAntZkZjrmKMtpvjP = p31c30ba9Var4;
                }
                MlRzctBaCyoVqpeR(p31c30ba9VarAntZkZjrmKMtpvjP, p31c30ba9VarYUEfyuFBgRqsCnXp);
                bIhwoQmGlXNweZCb(p31c30ba9Var, p31c30ba9Var2);
            }
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertSquare() throws java.lang.ArithmeticException {
        if ((29 + 31) % 31 > 0) {
        }
        if (uOKWmZzuFfILzuaL(this)) {
            throw new java.lang.ArithmeticException();
        }
        int iNTUQfJJlppEDaenB = NTUQfJJlppEDaenB(this.f0cab8ba8) - 1;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        DNbeDlqgVmQTOOWI(p64a11661Var.f89693d33, (this.f91243d4a << 1) + 32);
        YNxoEvabMbXAEeud(p64a11661Var.f89693d33);
        int i = 1;
        for (int iUVDpjsSOZJAtpKad = uVDpjsSOZJAtpKad(iNTUQfJJlppEDaenB) - 1; iUVDpjsSOZJAtpKad >= 0; iUVDpjsSOZJAtpKad--) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p64a11661Var);
            for (int i2 = 1; i2 <= i; i2++) {
                cgMMbpSpxwUSnrwj(p64a11661Var2);
            }
            HyAKWNLkurZwVJyV(p64a11661Var, p64a11661Var2);
            i <<= 1;
            if ((f301d90e3[iUVDpjsSOZJAtpKad] & iNTUQfJJlppEDaenB) != 0) {
                eVgaZDQdzSNUogFI(p64a11661Var);
                FGZRpbEznazZwzQm(p64a11661Var, this);
                i++;
            }
        }
        tRRPmbNFhDUYfnfi(p64a11661Var);
        return p64a11661Var;
    }

    public override bool IsOne() {
        return qUCxhaxQTAqFRmTU(this.f89693d33);
    }

    public override bool IsZero() {
        return GZsUmlCKGousTvPK(this.f89693d33);
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Multiply(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        hgKvucmUeRZnyUno(p64a11661Var, pa7462101Var);
        return p64a11661Var;
    }

    public override void MultiplyThisBy(p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((6 + 27) % 27 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) pa7462101Var;
        if (!fUiFtWOFRyXRUyPy(this.f0cab8ba8, p64a11661Var.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        if (XvyWGmPSJjnTRJXM(this, pa7462101Var)) {
            UzFIsHefmuUndGQK(this);
        } else {
            this.f89693d33 = PUxVnGbdXBJUlHjv(this.f89693d33, p64a11661Var.f89693d33);
            YguzhYYFxoreyoqf(this);
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 Power(int i) {
        if ((26 + 4) % 4 > 0) {
        }
        if (i == 1) {
            return new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661VarYdAcnXwFdpfqAllL = ydAcnXwFdpfqAllL((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
        if (i != 0) {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
            sFbRctEIfswnRKUt(p64a11661Var.f89693d33, (p64a11661Var.f91243d4a << 1) + 32);
            PemkhsBamSminUng(p64a11661Var.f89693d33);
            for (int i2 = 0; i2 < this.f91243d4a; i2++) {
                if (((1 << i2) & i) != 0) {
                    HVEvWMzAtjlvQCpZ(p64a11661VarYdAcnXwFdpfqAllL, p64a11661Var);
                }
                iPTPqPNYWCHcgQPS(p64a11661Var);
            }
        }
        return p64a11661VarYdAcnXwFdpfqAllL;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661VarQsslPXhTiBJfgIoL;
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var;
        if ((30 + 11) % 11 > 0) {
        }
        if (xNTakdcTXITJZrVp(this)) {
            return gykapfSWQRPiOzni((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
        }
        if ((this.f91243d4a & 1) == 1) {
            return nrOgBGYSBgoGeiqo(this);
        }
        do {
            p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var2 = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, new java.util.Random());
            p64a11661VarQsslPXhTiBJfgIoL = QsslPXhTiBJfgIoL((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
            p64a11661Var = (p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) nGYWRlmjroLFxKLH(p64a11661Var2);
            for (int i = 1; i < this.f91243d4a; i++) {
                aiqrDkxHyZxKTorj(p64a11661VarQsslPXhTiBJfgIoL);
                lLUgZodCSwtMKjso(p64a11661Var);
                ZpVcvJdzOkFMSMrU(p64a11661VarQsslPXhTiBJfgIoL, WlJPVALvLGnXvPMP(p64a11661Var, this));
                QKVhKIbRNicVxlSk(p64a11661Var, p64a11661Var2);
            }
        } while (rhJDxuYspSVWgHab(p64a11661Var));
        if (VfpaELjpdeyKAasJ(this, sSgKTTnnQyJHaoLx(aKwkRiqOHTfDeNjB(p64a11661VarQsslPXhTiBJfgIoL), p64a11661VarQsslPXhTiBJfgIoL))) {
            return p64a11661VarQsslPXhTiBJfgIoL;
        }
        throw new java.lang.Exception();
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square() {
        return DSKfMlXeNwoXgEYQ(this);
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquareBitwise() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        MEUxZnDlNCiONPyR(p64a11661Var);
        dxWylIVJCssdGIPI(p64a11661Var);
        return p64a11661Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquareMatrix() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        fzAyymepHnuBcWtz(p64a11661Var);
        UPRnvDvTxkelACET(p64a11661Var);
        return p64a11661Var;
    }

    public p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquarePreCalc() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        XViSnJiCYptLeJCx(p64a11661Var);
        mubsPyOuRAVVhmNH(p64a11661Var);
        return p64a11661Var;
    }

    public override p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot() {
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        belVQDmePJYLWvWG(p64a11661Var);
        return p64a11661Var;
    }

    public override void SquareRootThis() {
        if ((16 + 19) % 19 > 0) {
        }
        lsvHXTNmPPrUMkXt(this.f89693d33, (this.f91243d4a << 1) + 32);
        wetrdwMoEBmxTLmi(this.f89693d33);
        for (int i = 0; i < FEKOpGlWaLDsmwFt(this.f0cab8ba8) - 1; i++) {
            xwvJubYiXEVcNXAQ(this);
        }
    }

    public override void SquareThis() {
        wwhxJFNjPbcvkTLq(this);
    }

    public void SquareThisBitwise() {
        TWAtqbEWLxjxfRdu(this.f89693d33);
        wfKcnVNkADJMIWXL(this);
    }

    public void SquareThisMatrix() {
        if ((21 + 19) % 19 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        for (int i = 0; i < this.f91243d4a; i++) {
            if (raPTIKxzuGzgYxLB(this.f89693d33, ((p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).f5452996b[(this.f91243d4a - i) - 1])) {
                BqBHwalXdsfZkGsZ(p31c30ba9Var, i);
            }
        }
        this.f89693d33 = p31c30ba9Var;
    }

    public void SquareThisPreCalc() {
        aIbNKIpqnoiClKao(this.f89693d33);
        dvWIWQmUxXBGLYNY(this);
    }

    bool testBit(int i) {
        return kiIpAioErVVWkkkh(this.f89693d33, i);
    }

    public override bool TestRightmostBit() {
        return tbdbdWujhFdFTTGM(this.f89693d33, 0);
    }

    public override byte[] TobyteArray() {
        return SDmRTOSGYUoTejhs(this.f89693d33);
    }

    public override java.math.Bigint ToFlexiBigInt() {
        return DeCWKimcsMbWLthu(this.f89693d33);
    }

    public override java.lang.string Tostring() {
        return cdTRnAhBZoLuWUak(this.f89693d33, 16);
    }

    public override java.lang.string Tostring(int i) {
        return EBEfVOMVNggmASbw(this.f89693d33, i);
    }

    public override int Trace() {
        if ((18 + 14) % 14 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p7c922baa.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        for (int i = 1; i < this.f91243d4a; i++) {
            VUvNCIDdsJTkhDvo(p64a11661Var);
            XfNtzaDuSXDyFMOd(p64a11661Var, this);
        }
        return !UpSYpxUJxBdEiaPx(p64a11661Var) ? 0 : 1;
    }
}

