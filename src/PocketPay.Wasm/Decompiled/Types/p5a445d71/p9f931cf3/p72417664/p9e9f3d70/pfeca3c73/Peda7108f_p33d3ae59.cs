namespace WillowMaze.Wasm.Decompiled;

public class Peda7108f_p33d3ae59 : Peda7108f$p4c3b1c92
{
    private p364bf33a F3b62b082;
    private byte[] F44f90a54;
    private p364bf33a Fa4167731;
    private byte[] Ff0b53b2d;

    private void EngineInit(AlgorithmParameterSpec P0)
    {
        // str: "IvParameterSpec required to initialise a IV parameters algorithm parameters object"
        // call: InvalidParameterSpecException.<init>
        // call: IvParameterSpec.getIV
        // call: IllegalArgumentException.getMessage
        // call: pc5c653c7.getIV
        // call: pc5c653c7.getSBox
        // call: peda7108f$p33d3ae59.getSBoxOID
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.fa4167731
        // type: InvalidParameterSpecException
    }

    private string EngineToString()
    {
        // str: "GOST 28147 IV Parameters"
        return string.Empty;
    }

    private AlgorithmParameterSpec LocalEngineGetParameterSpec(Type P0)
    {
        // str: "AlgorithmParameterSpec not recognized: "
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: Type.getName
        // call: IvParameterSpec.<init>
        // call: pc5c653c7.<init>
        // call: InvalidParameterSpecException.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.fa4167731
        // type: pc5c653c7
        // type: AlgorithmParameterSpec
        // type: IvParameterSpec
        // type: InvalidParameterSpecException
        // type: StringBuilder
        return default!;
    }

    private byte[] LocalGetEncoded()
    {
        // call: p9f54f8ae.getEncoded
        // call: p9f54f8ae.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.ff0b53b2d
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.fa4167731
        // type: p9f54f8ae
        return default!;
    }

    private void LocalInit(byte[] P0)
    {
        // str: "Unable to recognize parameters"
        // call: p11b04310.getOctets
        // call: p11b04310.m8bab0102
        // call: p9f54f8ae.getIV
        // call: p9f54f8ae.m8bab0102
        // call: p301c7ed4.m89e75c46
        // call: p9f54f8ae.getEncryptionParamSet
        // call: IOException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.fa4167731
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.peda7108f$p33d3ae59.ff0b53b2d
        // type: IOException
    }

}
