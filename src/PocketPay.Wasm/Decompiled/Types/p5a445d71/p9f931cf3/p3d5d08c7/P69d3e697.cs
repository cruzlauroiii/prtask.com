namespace WillowMaze.Wasm.Decompiled;

public class P69d3e697 : P074a0740
{
    private static Hashtable F0d6496bf;
    private static Hashtable F12127061;
    private static Hashtable F1e47101f;
    private static Hashtable F21ffce5b;
    private static Hashtable F2fd4550b;
    private static HashSet<object> F36403fa6;
    private static HashSet<object> F42889e64;
    private static Hashtable F5d71ddf6;
    private static Hashtable F654e5aec;
    private static Hashtable F66270707;
    private static Hashtable F7a6ebfc3;
    private static HashSet<object> F9033c63f;
    private static Hashtable F9763d6ad;
    private static HashSet<object> Fad880eda;
    private static Hashtable Fc872f818;
    private static HashSet<object> Fdf4085ae;
    private static Hashtable Ff11ab75c;
    private static Hashtable Ffb6f283e;

    private static string M15b600f8(p364bf33a P0)
    {
        // str: "RIPEMD160"
        // str: "SHA384"
        // str: "39e8e18b1d8579c61463db209f244737edf3b8f71d92b4798cfdff1effc3379276cf"
        // str: "SHA1"
        // str: "b908c9685d5effda8d6b808daa91bdb1b1bd798e319b57cfaa64e5b33adfec9061f3"
        // str: "SHA224"
        // str: "RIPEMD256"
        // str: "MD5"
        // str: "GOST3411"
        // str: "RIPEMD128"
        // call: DecryptString.decryptString
        // call: p364bf33a.equals
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.ff8ce6695
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f1bc29b36
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f40964ed3
        // field: p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.f742a86b1
        // field: p5a445d71.p9f931cf3.pca323100.p204b173b.pd07b2240.fbba06797
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f17fdb97b
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613
        // field: p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f144d5874
        // field: p5a445d71.p9f931cf3.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3
        // field: p5a445d71.p9f931cf3.pca323100.pff670599.p0d0fe8be.f22a47664
        return string.Empty;
    }

    private void M666068eb(Signature P0, p0fd1bdf1 P1)
    {
        // str: "d568839d3028f54fce3d0d0fddca5cf7e07881a50fa53bf39db73879c41bd7"
        // str: "IOException decoding parameters: "
        // str: "f3f2c3cc4d534fa6b429d18a818675d77131dc7b71a5ccae14e72dd3edfb994b"
        // str: "Exception extracting parameters: "
        // call: p4631e342.equals
        // call: AlgorithmParameters.getInstance
        // call: p0fd1bdf1.toASN1Primitive
        // call: DecryptString.decryptString
        // call: p301c7ed4.getEncoded
        // call: AlgorithmParameters.init
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Signature.getAlgorithm
        // call: string.endsWith
        // call: SignatureException.<init>
        // call: GeneralSecurityException.getMessage
        // call: AlgorithmParameters.getParameterSpec
        // call: Signature.setParameter
        // call: StringBuilder.append
        // call: Signature.getProvider
        // call: IOException.getMessage
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // type: StringBuilder
        // type: SignatureException
        // type: PSSParameterSpec
    }

    private static string M6d7cc104(p234a7530 P0)
    {
        // str: "withRSAandMGF1"
        // call: pfa0321ce.m8bab0102
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.toString
        // call: p234a7530.getParameters
        // call: StringBuilder.append
        // call: pfa0321ce.getHashAlgorithm
        // call: p69d3e697.m15b600f8
        // call: StringBuilder.<init>
        // call: p364bf33a.getId
        // call: p4631e342.equals
        // call: p364bf33a.equals
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f0b225980
        // type: StringBuilder
        return string.Empty;
    }

    private static p22ab0bb1 M7426f89f(X500Principal P0)
    {
        // str: "can't convert name"
        // call: IllegalArgumentException.<init>
        // call: X500Principal.getEncoded
        // call: pe2c8c969.<init>
        // type: IllegalArgumentException
        // type: pe2c8c969
        return default!;
    }

    private static p80f8c729 Maddf2758(byte[] P0)
    {
        // str: "badly encoded request"
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: IllegalArgumentException.<init>
        // type: pd1c2953c
        // type: IllegalArgumentException
        return default!;
    }

    private static pfa0321ce Mfd229e49(p234a7530 P0, int P1)
    {
        // call: pf391b73d.<init>
        // call: pfa0321ce.<init>
        // call: p234a7530.<init>
        // field: p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c.f906e847c
        // type: pf391b73d
        // type: pfa0321ce
        // type: p234a7530
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "df269aa8d30f18fa035634304930a1d7ce79c78c7b509a82f30ea9af467a22"
        // call: Exception.<init>
        // call: DecryptString.decryptString
        // call: p69d3e697.getEncoded
        // call: IOException.toString
        // type: Exception
        return default!;
    }

    public PublicKey GetPublicKey()
    {
        // str: "4800c3591f4417034034cedc5990272bd899483abfe4e4f02a336dc8ec0c"
        // call: DecryptString.decryptString
        // call: p69d3e697.getPublicKey
        return default!;
    }

    public PublicKey GetPublicKey(string P0)
    {
        // str: "error decoding public key"
        // call: p6cd4ad2c.getSubjectPublicKeyInfo
        // call: p1522cc54.<init>
        // call: p1522cc54.getOctets
        // call: X509EncodedKeySpec.<init>
        // call: p3cdccfc9.getAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.getId
        // call: KeyFactory.getInstance
        // call: KeyFactory.generatePublic
        // call: InvalidKeyException.<init>
        // call: Hashtable.get
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f9a2021af
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f0d6496bf
        // type: X509EncodedKeySpec
        // type: p1522cc54
        // type: InvalidKeyException
        return default!;
    }

    public bool Verify()
    {
        // str: "13f7924c10ec0a471fba52bf042d16c897b9ef7c09a05b7cf43090569957"
        // call: DecryptString.decryptString
        // call: p69d3e697.verify
        return false;
    }

    public bool Verify(string P0)
    {
        // call: p69d3e697.getPublicKey
        // call: p69d3e697.verify
        return false;
    }

    public bool Verify(PublicKey P0, string P1)
    {
        // str: "6a32d55a5fdfa26ff158bb5af21f9814e113d5479f1f230d8ffc499a218da6"
        // str: "exception encoding TBS cert request - "
        // call: p69d3e697.m666068eb
        // call: StringBuilder.<init>
        // call: p69d3e697.m6d7cc104
        // call: Signature.getInstance
        // call: Signature.initVerify
        // call: DecryptString.decryptString
        // call: p6cd4ad2c.getEncoded
        // call: Signature.update
        // call: p234a7530.getAlgorithm
        // call: StringBuilder.toString
        // call: p1522cc54.getOctets
        // call: SignatureException.<init>
        // call: StringBuilder.append
        // call: Hashtable.get
        // call: p234a7530.getParameters
        // call: Signature.verify
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f4ddf4fb6
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f9a2021af
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f9763d6ad
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p69d3e697.f34a907d9
        // type: StringBuilder
        // type: SignatureException
        return false;
    }

}
