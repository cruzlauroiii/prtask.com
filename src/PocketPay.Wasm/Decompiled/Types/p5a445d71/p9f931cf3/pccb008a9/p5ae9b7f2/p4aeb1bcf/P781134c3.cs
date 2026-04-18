namespace WillowMaze.Wasm.Decompiled;

public class P781134c3
{
    private p823c49a3 F00e3c37f;
    private readonly pf62ef2d9 F21ffce5b;
    private p823c49a3 F236c9563;
    private readonly pf62ef2d9 F3795b15a;
    private p893af95b F4f70c1ac;
    private System.Security.Cryptography.RandomNumberGenerator F4fcdb8aa;
    private pe1225d2e F89057bd9;
    private p893af95b F8b8bc6f2;
    private p893af95b F9a94baa2;
    private readonly pf62ef2d9 Faeabd605;
    private p823c49a3 Fbd0c8e3b;
    private pe1225d2e Fc36853ea;
    private System.Security.Cryptography.RandomNumberGenerator Fc43fb241;
    private readonly pf62ef2d9 Fcf5f5fe2;
    private System.Security.Cryptography.RandomNumberGenerator Fe4f029ff;

    public p823c49a3 ExportPrivateKey()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        return default!;
    }

    public pe1225d2e ExportPublicKey()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        return default!;
    }

    public void GenerateKeys()
    {
        // call: pd255ec94.getPublic
        // call: p823c49a3.getPublicSeed
        // call: pf62ef2d9.getTreeDigestSize
        // call: p781134c3.getParams
        // call: p2dd6c2e6.<init>
        // call: p893af95b.importKeys
        // call: p2dd6c2e6.generateKeyPair
        // call: p2dd6c2e6.init
        // call: p2a2f9dbf.<init>
        // call: pd255ec94.getPrivate
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc43fb241
        // type: p2a2f9dbf
        // type: p2dd6c2e6
    }

    public int GetIndex()
    {
        // call: p823c49a3.getIndex
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        return 0;
    }

    public pf62ef2d9 GetParams()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        return default!;
    }

    public p823c49a3 GetPrivateKey()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        return default!;
    }

    public byte[] GetPublicSeed()
    {
        // call: p823c49a3.getPublicSeed
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        return default!;
    }

    public byte[] GetRoot()
    {
        // call: p823c49a3.getRoot
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        return default!;
    }

    private p893af95b GetWOTSPlus()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        return default!;
    }

    public void ImportState(p823c49a3 P0, pe1225d2e P1)
    {
        // str: "public seed of private key and public key do not match"
        // str: "root of private key and public key do not match"
        // call: p823c49a3.getRoot
        // call: IllegalStateException.<init>
        // call: pe1225d2e.getPublicSeed
        // call: pf62ef2d9.getTreeDigestSize
        // call: p823c49a3.getPublicSeed
        // call: p893af95b.importKeys
        // call: pff43b8de.m2a3f81d2
        // call: pe1225d2e.getRoot
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // type: IllegalStateException
    }

    public void ImportState(byte[] P0, byte[] P1)
    {
        // str: "publicKey == null"
        // str: "public seed of private key and public key do not match"
        // str: "privateKey == null"
        // str: "root of private key and public key do not match"
        // call: pe1225d2e.getRoot
        // call: pe1225d2e$p2bd4a59b.<init>
        // call: p823c49a3.getPublicSeed
        // call: p823c49a3$p2bd4a59b.build
        // call: pf62ef2d9.getTreeDigestSize
        // call: IllegalStateException.<init>
        // call: NullPointerException.<init>
        // call: pe1225d2e$p2bd4a59b.withPublicKey
        // call: pe1225d2e$p2bd4a59b.build
        // call: p823c49a3$p2bd4a59b.<init>
        // call: pe1225d2e.getPublicSeed
        // call: pff43b8de.m2a3f81d2
        // call: p823c49a3.getRoot
        // call: p823c49a3$p2bd4a59b.withPrivateKey
        // call: p893af95b.importKeys
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        // type: NullPointerException
        // type: IllegalStateException
        // type: pe1225d2e$p2bd4a59b
        // type: p823c49a3$p2bd4a59b
    }

    private void SetIndex(int P0)
    {
        // call: p823c49a3$p2bd4a59b.<init>
        // call: p823c49a3.getBDSState
        // call: p823c49a3$p2bd4a59b.build
        // call: p823c49a3.getSecretKeyPRF
        // call: p823c49a3$p2bd4a59b.withPublicSeed
        // call: p823c49a3.getSecretKeySeed
        // call: p823c49a3$p2bd4a59b.withSecretKeyPRF
        // call: p823c49a3.getRoot
        // call: p823c49a3$p2bd4a59b.withBDSState
        // call: p823c49a3$p2bd4a59b.withSecretKeySeed
        // call: p823c49a3.getPublicSeed
        // call: p823c49a3$p2bd4a59b.withRoot
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // type: p823c49a3$p2bd4a59b
    }

    private void SetPublicSeed(byte[] P0)
    {
        // call: p823c49a3$p2bd4a59b.<init>
        // call: pe1225d2e$p2bd4a59b.<init>
        // call: p823c49a3.getBDSState
        // call: p893af95b.importKeys
        // call: pf62ef2d9.getTreeDigestSize
        // call: p823c49a3$p2bd4a59b.withBDSState
        // call: p823c49a3$p2bd4a59b.build
        // call: p823c49a3$p2bd4a59b.withSecretKeyPRF
        // call: p823c49a3.getSecretKeySeed
        // call: pe1225d2e$p2bd4a59b.build
        // call: p823c49a3$p2bd4a59b.withRoot
        // call: p823c49a3$p2bd4a59b.withSecretKeySeed
        // call: pe1225d2e$p2bd4a59b.withPublicSeed
        // call: p823c49a3.getSecretKeyPRF
        // call: p781134c3.getRoot
        // call: p823c49a3$p2bd4a59b.withPublicSeed
        // call: pe1225d2e$p2bd4a59b.withRoot
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // type: p823c49a3$p2bd4a59b
        // type: pe1225d2e$p2bd4a59b
    }

    private void SetRoot(byte[] P0)
    {
        // call: p823c49a3.getBDSState
        // call: pe1225d2e$p2bd4a59b.withPublicSeed
        // call: p823c49a3$p2bd4a59b.withPublicSeed
        // call: pe1225d2e$p2bd4a59b.build
        // call: p823c49a3$p2bd4a59b.<init>
        // call: p823c49a3.getSecretKeyPRF
        // call: p823c49a3.getSecretKeySeed
        // call: p823c49a3$p2bd4a59b.withBDSState
        // call: p781134c3.getPublicSeed
        // call: pe1225d2e$p2bd4a59b.<init>
        // call: p823c49a3$p2bd4a59b.withSecretKeyPRF
        // call: p823c49a3$p2bd4a59b.withRoot
        // call: p823c49a3$p2bd4a59b.withSecretKeySeed
        // call: p823c49a3$p2bd4a59b.build
        // call: pe1225d2e$p2bd4a59b.withRoot
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // type: pe1225d2e$p2bd4a59b
        // type: p823c49a3$p2bd4a59b
    }

    public byte[] Sign(byte[] P0)
    {
        // str: "message == null"
        // call: pac63e525.<init>
        // call: pac63e525.init
        // call: pac63e525.generateSignature
        // call: p781134c3.importState
        // call: pac63e525.getUpdatedPrivateKey
        // call: NullPointerException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fc36853ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // type: NullPointerException
        // type: pac63e525
        return default!;
    }

    public bool VerifySignature(byte[] P0, byte[] P1, byte[] P2)
    {
        // str: "signature == null"
        // str: "message == null"
        // str: "publicKey == null"
        // call: pac63e525.<init>
        // call: p781134c3.getParams
        // call: pe1225d2e$p2bd4a59b.<init>
        // call: NullPointerException.<init>
        // call: pe1225d2e$p2bd4a59b.build
        // call: pac63e525.verifySignature
        // call: pe1225d2e$p2bd4a59b.withPublicKey
        // call: pac63e525.init
        // type: pe1225d2e$p2bd4a59b
        // type: NullPointerException
        // type: pac63e525
        return false;
    }

    private p2b6338ab WotsSign(byte[] P0, pd57771ba P1)
    {
        // str: "size of messageDigest needs to be equal to size of digest"
        // str: "otsHashAddress == null"
        // call: p893af95b.sign
        // call: NullPointerException.<init>
        // call: pf62ef2d9.getTreeDigestSize
        // call: IllegalArgumentException.<init>
        // call: p893af95b.importKeys
        // call: p781134c3.getPublicSeed
        // call: p893af95b.getWOTSPlusSecretKey
        // call: p823c49a3.getSecretKeySeed
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.f8b8bc6f2
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p781134c3.fbd0c8e3b
        // type: NullPointerException
        // type: IllegalArgumentException
        return default!;
    }

}
