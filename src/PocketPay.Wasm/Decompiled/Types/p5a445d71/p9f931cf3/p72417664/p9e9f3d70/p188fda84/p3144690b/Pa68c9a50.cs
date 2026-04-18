namespace WillowMaze.Wasm.Decompiled;

public class Pa68c9a50 : AlgorithmParametersSpi
{
    private pdd952c9d F05e4c9cd;
    private pdd952c9d F08700f8c;
    private pdd952c9d F0d818b20;
    private pdd952c9d F97647824;
    private pdd952c9d Fb25cd2de;

    private byte[] EngineGetEncoded()
    {
        // str: "40aeb55435f4166250c45273c6882ce56052ec6afb8cde572fdb2aa1f684a6"
        // str: "Error encoding IESParameters"
        // call: Exception.<init>
        // call: pd6ccb7fc.<init>
        // call: pdd952c9d.getDerivationV
        // call: p6f0e511c.<init>
        // call: p87af127c.<init>
        // call: pd6ccb7fc.add
        // call: pdd952c9d.getEncodingV
        // call: pdd952c9d.getMacKeySize
        // call: pf391b73d.<init>
        // call: pdd952c9d.getNonce
        // call: pdd952c9d.getCipherKeySize
        // call: pb840b7ef.<init>
        // call: pdd952c9d.getPointCompression
        // call: DecryptString.decryptString
        // call: pb840b7ef.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p3144690b.pa68c9a50.f0d818b20
        // field: p5a445d71.p9f931cf3.pca323100.p41bf756e.fc0d83f0b
        // field: p5a445d71.p9f931cf3.pca323100.p41bf756e.f946003f9
        // type: pd6ccb7fc
        // type: p87af127c
        // type: p6f0e511c
        // type: pf391b73d
        // type: pb840b7ef
        // type: Exception
        return default!;
    }

    private byte[] EngineGetEncoded(string P0)
    {
        // str: "X.509"
        // call: pa68c9a50.isASN1FormatString
        // call: string.equalsIgnoreCase
        // call: pa68c9a50.engineGetEncoded
        return default!;
    }

    private AlgorithmParameterSpec EngineGetParameterSpec(Type P0)
    {
        // str: "argument to getParameterSpec must not be null"
        // call: NullPointerException.<init>
        // call: pa68c9a50.localEngineGetParameterSpec
        // type: NullPointerException
        return default!;
    }

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "IESParameterSpec required to initialise a IES algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p3144690b.pa68c9a50.f0d818b20
        // type: InvalidParameterSpecException
    }

    private void EngineInit(byte[] P0)
    {
        // str: "Not a valid IES Parameter encoding."
        // str: "sequence too big"
        // call: p301c7ed4.m89e75c46
        // call: p80f8c729.size
        // call: p80f8c729.getObjects
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: p582a4948.m8bab0102
        // call: p582a4948.getTagNo
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: pf391b73d.m8bab0102
        // call: pf391b73d.getValue
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.getObjectAt
        // call: p41bf756e.m8bab0102
        // call: p41bf756e.isTrue
        // call: System.Numerics.BigInteger.intValue
        // call: pdd952c9d.<init>
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p3144690b.pa68c9a50.f0d818b20
        // type: IOException
        // type: pdd952c9d
    }

    private void EngineInit(byte[] P0, string P1)
    {
        // str: "X.509"
        // str: "Unknown parameter format "
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: pa68c9a50.isASN1FormatString
        // call: StringBuilder.toString
        // call: string.equalsIgnoreCase
        // call: StringBuilder.append
        // call: pa68c9a50.engineInit
        // type: IOException
        // type: StringBuilder
    }

    private string EngineToString()
    {
        // str: "IES Parameters"
        return string.Empty;
    }

    private bool IsASN1FormatString(string P0)
    {
        // str: "ASN.1"
        // call: string.equals
        return false;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "unknown parameter spec passed to ElGamal parameters object."
        // call: InvalidParameterSpecException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p3144690b.pa68c9a50.f0d818b20
        // type: pdd952c9d
        // type: InvalidParameterSpecException
        // type: AlgorithmParameterSpec
        return default!;
    }

}
