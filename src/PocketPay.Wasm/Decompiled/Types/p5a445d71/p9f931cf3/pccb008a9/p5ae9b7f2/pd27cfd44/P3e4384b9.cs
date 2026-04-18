namespace WillowMaze.Wasm.Decompiled;

public class P3e4384b9
{
    private static int F00f38eec;
    private static int F02363ed3;
    private static int F0fc5e965;
    private static int F0fe22f0d;
    private static short F1f0962f5;
    private static int F26d5056b;
    private static int F2a319453;
    private static int F2a86c3ef;
    private static int F2b83d654;
    private static int F31e447c1;
    private static int F32b7728e;
    private static int F3400909b;
    private static int F35bb98c9;
    private static int F36aac45f;
    private static int F52afe18a;
    private static int F5db08644;
    private static short F6b16e515;
    private static int F6babc22f;
    private static short F9be8025a;
    private static short F9c1bfb4f;
    private static short Fa29490bd;
    private static int Fad3e1af1;
    private static short Fb6640b96;
    private static int Fc2a3a1ad;
    private static int Fc454c91a;
    private static int Fcb2c627b;
    private static short Fcfa59732;
    private static int Fcff73c3b;
    private static short Fdcccd6ae;
    private static int Fe0269b3c;
    private static int Fe7e3c29a;
    private static int Ff1bdbc01;
    private static int Fff0641ad;

    public static int M0fbf8164(byte[] P0, int P1, int P2)
    {
        return 0;
    }

    public static p1f46f851 M36faf070(p5b89b9c3 P0)
    {
        // call: p5b89b9c3.getQ
        // call: p5b89b9c3.getMasterSecret
        // call: p5b89b9c3.getParameter
        // call: p1f46f851.<init>
        // call: p5b89b9c3.getI
        // call: p3e4384b9.m36faf070
        // type: p1f46f851
        return default!;
    }

    private static byte[] M36faf070(paa63fca2 P0, byte[] P1, int P2, byte[] P3)
    {
        // call: paa63fca2.getW
        // call: paa63fca2.getP
        // call: pbcba235a.u32str
        // call: pbcba235a.m13b3f3e7
        // call: pe1a02e85.deriveSeed
        // call: pe5cfc515.update
        // call: pbcba235a.padUntil
        // call: pbcba235a.bytes
        // call: paa63fca2.getDigestOID
        // call: p69279707.me0825354
        // call: pbcba235a.build
        // call: pe1a02e85.<init>
        // call: pe1a02e85.setJ
        // call: pe5cfc515.getDigestSize
        // call: paa63fca2.getN
        // call: pe5cfc515.doFinal
        // call: pe1a02e85.setQ
        // call: pbcba235a.u16str
        // call: p4492081c.m7b247d76
        // type: pe1a02e85
        return default!;
    }

    public static int M64304d34(byte[] P0, int P1, paa63fca2 P2)
    {
        // call: paa63fca2.getW
        // call: p3e4384b9.m0fbf8164
        // call: paa63fca2.getLs
        return 0;
    }

    public static p56cbf129 Mbc547944(p5b89b9c3 P0, byte[] P1, byte[] P2)
    {
        // call: p56cbf129.<init>
        // call: paa63fca2.getN
        // call: pe5cfc515.doFinal
        // call: paa63fca2.getDigestOID
        // call: pbcba235a.build
        // call: pbcba235a.bytes
        // call: pbcba235a.u32str
        // call: pe1a02e85.deriveSeed
        // call: p3e4384b9.m64304d34
        // call: p5b89b9c3.getQ
        // call: pe5cfc515.update
        // call: p5b89b9c3.getDerivationFunction
        // call: pbcba235a.m13b3f3e7
        // call: p3e4384b9.m0fbf8164
        // call: paa63fca2.getW
        // call: System.arraycopy
        // call: p5b89b9c3.getParameter
        // call: pe1a02e85.setJ
        // call: paa63fca2.getP
        // call: p69279707.me0825354
        // type: p56cbf129
        return default!;
    }

    public static p56cbf129 Mbc547944(p86d70d45 P0, p5b89b9c3 P1, byte[][] P2, byte[] P3, bool P4)
    {
        // call: p3e4384b9.mbc547944
        // call: p8c5394a1.m592f8eff
        // call: System.arraycopy
        // call: pf502f530.getC
        // call: p5b89b9c3.getParameter
        // call: paa63fca2.getN
        // call: pf502f530.getQ
        // call: p5b89b9c3.getSignatureContext
        return default!;
    }

    public static bool Mbfa4108a(p1f46f851 P0, p56cbf129 P1, byte[] P2, bool P3)
    {
        // str: "public key and signature ots types do not match"
        // call: p1f46f851.getParameter
        // call: object.equals
        // call: p3e4384b9.me486064e
        // call: p56cbf129.getType
        // call: pff43b8de.m2a3f81d2
        // call: p1ac14b98.<init>
        // call: p1f46f851.getK
        // type: p1ac14b98
        return false;
    }

    public static byte[] Me486064e(p1f46f851 P0, p56cbf129 P1, byte[] P2)
    {
        // call: p8c5394a1.m592f8eff
        // call: p3e4384b9.me486064e
        // call: p1f46f851.createOtsContext
        return default!;
    }

    public static byte[] Me486064e(pf502f530 P0)
    {
        // call: pe5cfc515.update
        // call: pf502f530.getPublicKey
        // call: p69279707.me0825354
        // call: pbcba235a.m13b3f3e7
        // call: paa63fca2.getN
        // call: p3e4384b9.m64304d34
        // call: pbcba235a.build
        // call: p8c5394a1.m935dddad
        // call: p5a1c166f.getOtsSignature
        // call: p56cbf129.getY
        // call: p1f46f851.getQ
        // call: paa63fca2.getDigestOID
        // call: pe5cfc515.doFinal
        // call: p8c5394a1.m592f8eff
        // call: p4492081c.m7b247d76
        // call: p8c5394a1.mcb312b5b
        // call: p1f46f851.getParameter
        // call: p3e4384b9.m0fbf8164
        // call: paa63fca2.getW
        // call: System.arraycopy
        return default!;
    }

}
