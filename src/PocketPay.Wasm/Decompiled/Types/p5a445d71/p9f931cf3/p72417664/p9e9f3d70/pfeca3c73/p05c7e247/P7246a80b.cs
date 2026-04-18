namespace WillowMaze.Wasm.Decompiled;

public class P7246a80b : MacSpi, Peff7c557
{
    private static Type F01b40e3c;
    private static Type F2774aea2;
    private static Type F8a153e87;
    private static Type F9b544da6;
    private static Type Fc063c5f7;
    private int F09a8559f;
    private int F174de6f2;
    private int F2496da2f;
    private int F39c23f03;
    private int F41323917;
    private int F46dd24e9;
    private int F4796c2cf;
    private p1748c064 F5b3f89bd;
    private int F696ad15f;
    private int F871ff1c7;
    private int F87893ec7;
    private p1748c064 F8b947cd4;
    private p1748c064 F9834c243;
    private int Fc5a2f7b7;
    private p1748c064 Fde3bc290;
    private int Fe726e783;
    private p1748c064 Ff53d115a;

    private static Hashtable M1174ec15(Dictionary<string, object> P0)
    {
        // call: IEnumerator<object>.next
        // call: Hashtable.<init>
        // call: Dictionary<string, object>.keySet
        // call: HashSet<object>.iterator
        // call: Dictionary<string, object>.get
        // call: IEnumerator<object>.hasNext
        // call: Hashtable.put
        // type: Hashtable
        return default!;
    }

    private byte[] EngineDoFinal()
    {
        // call: p1748c064.doFinal
        // call: p7246a80b.engineGetMacLength
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
        return default!;
    }

    private int EngineGetMacLength()
    {
        // call: p1748c064.getMacSize
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
        return 0;
    }

    private void EngineInit(Key P0, AlgorithmParameterSpec P1)
    {
        // str: "cannot initialize MAC: "
        // str: "PBE requires PBE parameters to be set."
        // str: "cdab66f2fa1085b4bcc5030abc28db32f21a8858556db6248a18d3a6fae7685262dfdd"
        // str: "unknown parameter type: "
        // str: "PKCS12 requires a SecretKey/PBEKey"
        // str: "RIPEMD160"
        // str: "338742c973d1e5006007453bbcd27b20eb7103941e7b9a168b1da5631e8d1af3f4a543"
        // str: "inappropriate parameter type: "
        // str: "PKCS12 requires a PBEParameterSpec"
        // str: "no PKCS12 mapping for HMAC: "
        // str: "GOST"
        // str: "key is null"
        // str: "1d5ce74b54815b2c81712c37951282307e8c0e7231800681fcda9a96ae2f9cf1b8"
        // str: "cc20327a09bde5e2fcccd56f3e31ed7a95daef7e8196e0fbafb0b12e46928a25d15121"
        // str: "b88ae4e43ec7f75b5cdaa9e8fdfaeb8569af50d0709e9e94b37f655074d2ce6e6bb509"
        // call: p1748c064.getAlgorithmName
        // call: p57f0d31f$p2bd4a59b.build
        // call: string.startsWith
        // call: StringBuilder.append
        // call: InvalidAlgorithmParameterException.<init>
        // call: StringBuilder.toString
        // call: peff7c557$p23e8a4b4.m61af3b8e
        // call: InvalidKeyException.<init>
        // call: p51ebc4fd.getParam
        // call: p57f0d31f$p2bd4a59b.setKey
        // call: StringBuilder.<init>
        // call: p94919be6.getKey
        // call: p397c291f.<init>
        // call: object.getClass
        // call: p1748c064.init
        // call: Type.getName
        // call: PBEKey.getSalt
        // call: DecryptString.decryptString
        // call: pdd5da44e.getParameters
        // call: Key.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f01b40e3c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
        // type: InvalidKeyException
        // type: p57f0d31f$p2bd4a59b
        // type: pdd5da44e
        // type: PBEParameterSpec
        // type: ped128738
        // type: InvalidAlgorithmParameterException
        // type: p94919be6
        // type: p397c291f
        // type: StringBuilder
    }

    private void EngineReset()
    {
        // call: p1748c064.reset
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
    }

    private void EngineUpdate(byte P0)
    {
        // call: p1748c064.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
    }

    private void EngineUpdate(byte[] P0, int P1, int P2)
    {
        // call: p1748c064.update
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7246a80b.f8b947cd4
    }

}
