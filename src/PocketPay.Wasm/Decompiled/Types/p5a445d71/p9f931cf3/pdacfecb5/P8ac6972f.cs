namespace WillowMaze.Wasm.Decompiled;

public class P8ac6972f : CertSelector, P0c3cd33e
{
    private readonly pd6a0bc72 F55d004ca;
    private readonly pd6a0bc72 Fa403f799;
    private readonly pd6a0bc72 Feddd984d;
    private readonly pd6a0bc72 Ff062c171;

    private object[] M03200c1c(pf17d2ecd[] P0)
    {
        // str: "badly formed Name object"
        // call: pf17d2ecd.getTagNo
        // call: List<object>.<init>
        // call: Exception.<init>
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: X500Principal.<init>
        // call: List<object>.add
        // call: List<object>.toArray
        // call: List<object>.size
        // type: List<object>
        // type: X500Principal
        // type: Exception
        return default!;
    }

    private bool M04117a1f(pe2c8c969 P0, pfb202cf8 P1)
    {
        // call: pfb202cf8.getNames
        // call: pf17d2ecd.getName
        // call: p0fd1bdf1.toASN1Primitive
        // call: p301c7ed4.getEncoded
        // call: pe2c8c969.<init>
        // call: pe2c8c969.equals
        // call: pf17d2ecd.getTagNo
        // type: pe2c8c969
        return false;
    }

    private pfb202cf8 M3abd4d9a(pe2c8c969 P0)
    {
        // call: pb840b7ef.<init>
        // call: pfb202cf8.m8bab0102
        // call: pf17d2ecd.<init>
        // type: pf17d2ecd
        // type: pb840b7ef
        return default!;
    }

    private Principal[] Me3677186(pfb202cf8 P0)
    {
        // call: p8ac6972f.m03200c1c
        // call: pfb202cf8.getNames
        // call: List<object>.<init>
        // call: List<object>.toArray
        // call: List<object>.size
        // call: List<object>.add
        // type: List<object>
        return default!;
    }

    public object Clone()
    {
        // call: pd6a0bc72.toASN1Primitive
        // call: p8ac6972f.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        // type: p8ac6972f
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: pd6a0bc72.equals
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return false;
    }

    public string GetDigestAlgorithm()
    {
        // call: pd6a0bc72.getObjectDigestInfo
        // call: p364bf33a.getId
        // call: p234a7530.getAlgorithm
        // call: pb8b73df0.getDigestAlgorithm
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return string.Empty;
    }

    public int GetDigestedObjectType()
    {
        // call: pb8b73df0.getDigestedObjectType
        // call: pd6a0bc72.getObjectDigestInfo
        // call: p4f02e7ce.intValueExact
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return 0;
    }

    public Principal[] GetEntityNames()
    {
        // call: pd6a0bc72.getEntityName
        // call: p8ac6972f.me3677186
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return default!;
    }

    public Principal[] GetIssuer()
    {
        // call: p8ac6972f.me3677186
        // call: pd6a0bc72.getBaseCertificateID
        // call: pcaf0afb6.getIssuer
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return default!;
    }

    public byte[] GetObjectDigest()
    {
        // call: p29d19857.getBytes
        // call: pd6a0bc72.getObjectDigestInfo
        // call: pb8b73df0.getObjectDigest
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return default!;
    }

    public string GetOtherObjectTypeID()
    {
        // call: p364bf33a.getId
        // call: pd6a0bc72.getObjectDigestInfo
        // call: pb8b73df0.getOtherObjectTypeID
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return string.Empty;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: pcaf0afb6.getSerial
        // call: pd6a0bc72.getBaseCertificateID
        // call: pf391b73d.getValue
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return default!;
    }

    public int HashCode()
    {
        // call: pd6a0bc72.hashCode
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return 0;
    }

    public bool Match(object P0)
    {
        // call: p8ac6972f.match
        return false;
    }

    public bool Match(Certificate P0)
    {
        // str: "de9218a32d9f2c07d681436b3546931a8c1e4a661da6da94a88a603078e0"
        // call: pd6a0bc72.getBaseCertificateID
        // call: pcaf0afb6.getSerial
        // call: X509Certificate.getSerialNumber
        // call: pf391b73d.hasValue
        // call: pdff4fba6.m705fc6d7
        // call: pcaf0afb6.getIssuer
        // call: p8ac6972f.m04117a1f
        // call: pd6a0bc72.getEntityName
        // call: pdff4fba6.me6c3728a
        // call: pd6a0bc72.getObjectDigestInfo
        // call: p8ac6972f.getDigestAlgorithm
        // call: DecryptString.decryptString
        // call: System.Security.Cryptography.HashAlgorithm.getInstance
        // call: p8ac6972f.getDigestedObjectType
        // call: Certificate.getEncoded
        // call: System.Security.Cryptography.HashAlgorithm.update
        // call: Certificate.getPublicKey
        // call: PublicKey.getEncoded
        // call: System.Security.Cryptography.HashAlgorithm.digest
        // call: p8ac6972f.getObjectDigest
        // field: p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f.fa403f799
        return false;
    }

}
