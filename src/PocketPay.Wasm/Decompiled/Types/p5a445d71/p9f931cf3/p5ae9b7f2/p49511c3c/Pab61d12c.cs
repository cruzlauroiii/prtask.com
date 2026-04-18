namespace WillowMaze.Wasm.Decompiled;

public class Pab61d12c : P07d32999
{
    private p089e1c8f F0f8416c2;
    private byte[] F14e9b3a3;
    private int F233bc7f7;
    private byte[] F31c6b4ea;
    private byte[] F47a86cec;
    private int F6a1aa600;
    private int F77a81d5c;
    private p089e1c8f F9960e413;
    private int Fbbad5c59;
    private byte[] Fcaf9b6b9;
    private int Fd17bedbc;
    private int Ff8d1366d;

    private p94919be6 M3e40063e(byte[] P0, byte[] P1)
    {
        // call: p089e1c8f.init
        // call: p94919be6.<init>
        // call: p089e1c8f.update
        // call: p089e1c8f.doFinal
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f0f8416c2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f6a1aa600
        // type: p94919be6
        return default!;
    }

    private void M5d8d6ec2()
    {
        // str: "HKDF cannot generate more than 255 blocks of HashLen size"
        // call: p089e1c8f.update
        // call: p089e1c8f.doFinal
        // call: p96068848.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.fcaf9b6b9
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f47a86cec
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f6a1aa600
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f233bc7f7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f0f8416c2
        // type: p96068848
    }

    public int GenerateBytes(byte[] P0, int P1, int P2)
    {
        // str: "HKDF may only be used for 255 * HashLen bytes of output"
        // call: System.arraycopy
        // call: Math.min
        // call: p96068848.<init>
        // call: pab61d12c.m5d8d6ec2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f47a86cec
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f6a1aa600
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f233bc7f7
        // type: p96068848
        return 0;
    }

    public pe5cfc515 GetDigest()
    {
        // call: p089e1c8f.getUnderlyingDigest
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f0f8416c2
        return default!;
    }

    public void Init(p873e950b P0)
    {
        // str: "HKDF parameters required for HKDFBytesGenerator"
        // call: pbd1efa83.getIKM
        // call: IllegalArgumentException.<init>
        // call: pbd1efa83.getInfo
        // call: p089e1c8f.init
        // call: pbd1efa83.getSalt
        // call: pbd1efa83.skipExtract
        // call: pab61d12c.m3e40063e
        // call: p94919be6.<init>
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f0f8416c2
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f6a1aa600
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f47a86cec
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.f233bc7f7
        // field: p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.pab61d12c.fcaf9b6b9
        // type: p94919be6
        // type: IllegalArgumentException
    }

}
