namespace WillowMaze.Wasm.Decompiled;

public class Pfe3ad449 : Pd2e37f48
{
    private DateTime F21f1ba3a;
    private DateTime F65fb60f9;
    private p15bd1150 F6e9fb8f5;
    private DateTime F9f01899a;
    private DateTime Faf5e14c4;
    private p15bd1150 Fb6ba9fa6;
    private p15bd1150 Fc645bdb8;
    private DateTime Fcf2c8475;
    private DateTime Ffea8a759;

    private static p15bd1150 M7bc9c2ce(Stream P0)
    {
        // str: "exception decoding certificate structure: "
        // call: Exception.toString
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: p15bd1150.m8bab0102
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.<init>
        // type: pd1c2953c
        // type: StringBuilder
        // type: IOException
        return default!;
    }

    private HashSet<object> Mf684fa0b(bool P0)
    {
        // call: p63e4e92b.isCritical
        // call: p15bd1150.getAcinfo
        // call: p364bf33a.getId
        // call: Enumeration.nextElement
        // call: HashSet<object>.<init>
        // call: Enumeration.hasMoreElements
        // call: p5e2f5f3c.oids
        // call: HashSet<object>.add
        // call: pebfd602b.getExtensions
        // call: p5e2f5f3c.getExtension
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: HashSet<object>
        return default!;
    }

    public void CheckValidity()
    {
        // call: pfe3ad449.checkValidity
        // call: DateTime.<init>
        // type: DateTime
    }

    public void CheckValidity(DateTime P0)
    {
        // str: "certificate not valid till "
        // str: "certificate expired on "
        // call: DateTime.before
        // call: pfe3ad449.getNotAfter
        // call: pfe3ad449.getNotBefore
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: DateTime.after
        // call: CertificateExpiredException.<init>
        // call: CertificateNotYetValidException.<init>
        // type: StringBuilder
        // type: CertificateNotYetValidException
        // type: CertificateExpiredException
    }

    public bool Equals(object P0)
    {
        // call: pfe3ad449.getEncoded
        // call: pd2e37f48.getEncoded
        // call: pff43b8de.m2a3f81d2
        return false;
    }

    public pe9e8674a[] GetAttributes()
    {
        // call: p80f8c729.getObjectAt
        // call: p15bd1150.getAcinfo
        // call: pebfd602b.getAttributes
        // call: p80f8c729.size
        // call: pe9e8674a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: pe9e8674a
        return default!;
    }

    public pe9e8674a[] GetAttributes(string P0)
    {
        // call: List<object>.size
        // call: List<object>.toArray
        // call: List<object>.add
        // call: pe9e8674a.<init>
        // call: p80f8c729.getObjectAt
        // call: p80f8c729.size
        // call: string.equals
        // call: List<object>.<init>
        // call: p15bd1150.getAcinfo
        // call: pe9e8674a.getOID
        // call: pebfd602b.getAttributes
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: pe9e8674a
        // type: List<object>
        return default!;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: pfe3ad449.mf684fa0b
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: p15bd1150.getEncoded
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "ea7067b618f6504b2dd9ec44704eb4fbd5d1ae6518ab5799ff8bbf263c56a0"
        // str: "error encoding "
        // call: p5e2f5f3c.getExtension
        // call: p15bd1150.getAcinfo
        // call: p63e4e92b.getExtnValue
        // call: DecryptString.decryptString
        // call: p11b04310.getEncoded
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pebfd602b.getExtensions
        // call: Exception.toString
        // call: StringBuilder.append
        // call: Exception.<init>
        // call: p364bf33a.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: Exception
        // type: StringBuilder
        // type: p364bf33a
        return default!;
    }

    public p8ac6972f GetHolder()
    {
        // call: pebfd602b.getHolder
        // call: pd6a0bc72.toASN1Primitive
        // call: p15bd1150.getAcinfo
        // call: p8ac6972f.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: p8ac6972f
        return default!;
    }

    public p73d7b518 GetIssuer()
    {
        // call: p15bd1150.getAcinfo
        // call: pebfd602b.getIssuer
        // call: p73d7b518.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: p73d7b518
        return default!;
    }

    public bool[] GetIssuerUniqueID()
    {
        // call: p29d19857.getBytes
        // call: p15bd1150.getAcinfo
        // call: pebfd602b.getIssuerUniqueID
        // call: p29d19857.getPadBits
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: pfe3ad449.mf684fa0b
        return default!;
    }

    public DateTime GetNotAfter()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.f21f1ba3a
        return default!;
    }

    public DateTime GetNotBefore()
    {
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fcf2c8475
        return default!;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: pf391b73d.getValue
        // call: pebfd602b.getSerialNumber
        // call: p15bd1150.getAcinfo
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        return default!;
    }

    public byte[] GetSignature()
    {
        // call: p15bd1150.getSignatureValue
        // call: p29d19857.getOctets
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        return default!;
    }

    public int GetVersion()
    {
        // call: pf391b73d.intValueExact
        // call: p15bd1150.getAcinfo
        // call: pebfd602b.getVersion
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        return 0;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: HashSet<object>.isEmpty
        // call: pfe3ad449.getCriticalExtensionOIDs
        return false;
    }

    public int HashCode()
    {
        // call: pfe3ad449.getEncoded
        // call: pff43b8de.m550d1cc0
        return 0;
    }

    public void Verify(PublicKey P0, string P1)
    {
        // str: "Signature algorithm in certificate info not same as outer certificate"
        // str: "Exception encoding certificate info object"
        // str: "Public key presented not for certificate signature"
        // call: Signature.initVerify
        // call: p15bd1150.getAcinfo
        // call: pebfd602b.getEncoded
        // call: Signature.update
        // call: InvalidKeyException.<init>
        // call: p15bd1150.getSignatureAlgorithm
        // call: CertificateException.<init>
        // call: SignatureException.<init>
        // call: p364bf33a.getId
        // call: pebfd602b.getSignature
        // call: pfe3ad449.getSignature
        // call: p234a7530.getAlgorithm
        // call: Signature.verify
        // call: Signature.getInstance
        // call: p234a7530.equals
        // field: p5a445d71.p9f931cf3.pdacfecb5.pfe3ad449.fb6ba9fa6
        // type: InvalidKeyException
        // type: SignatureException
        // type: CertificateException
    }

}
