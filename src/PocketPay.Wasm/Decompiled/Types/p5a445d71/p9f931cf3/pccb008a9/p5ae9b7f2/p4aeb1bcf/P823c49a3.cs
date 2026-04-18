namespace WillowMaze.Wasm.Decompiled;

public class P823c49a3 : P793993fc, P3a1edd0a, Pec546d1c
{
    private readonly byte[] F1596793e;
    private p1a8a272a F1cbdde06;
    private readonly pf62ef2d9 F1d72a096;
    private readonly byte[] F1ffa285e;
    private readonly pf62ef2d9 F21ffce5b;
    private p1a8a272a F246658d0;
    private readonly byte[] F278a6ba6;
    private readonly pf62ef2d9 F332e30a7;
    private readonly pf62ef2d9 F3a43e402;
    private readonly byte[] F529a2433;
    private readonly byte[] F63a9f0ea;
    private readonly pf62ef2d9 F6ad28485;
    private p1a8a272a F6fe6c194;
    private readonly byte[] Fa200a2c8;
    private readonly byte[] Fa33b78b1;
    private readonly byte[] Fb3a0a7bb;
    private p1a8a272a Fb47b7317;
    private readonly byte[] Fbac58fd7;
    private readonly byte[] Fc018273a;
    private readonly byte[] Fc1cff30f;
    private p1a8a272a Fc3ae25e6;
    private readonly byte[] Fd70b5bc6;
    private readonly byte[] Fec19fcb9;
    private readonly byte[] Ff575112e;

    public p823c49a3 ExtractKeyShard(int P0)
    {
        // str: "cannot ask for a shard with 0 keys"
        // str: "usageCount exceeds usages remaining"
        // call: p823c49a3.getUsagesRemaining
        // call: p823c49a3$p2bd4a59b.<init>
        // call: p823c49a3$p2bd4a59b.withSecretKeySeed
        // call: p823c49a3$p2bd4a59b.withSecretKeyPRF
        // call: p823c49a3$p2bd4a59b.withPublicSeed
        // call: p823c49a3$p2bd4a59b.withRoot
        // call: p823c49a3.getIndex
        // call: p823c49a3$p2bd4a59b.withIndex
        // call: p1a8a272a.getIndex
        // call: pf62ef2d9.getTreeDigestOID
        // call: p1a8a272a.withMaxIndex
        // call: p823c49a3$p2bd4a59b.withBDSState
        // call: p823c49a3$p2bd4a59b.build
        // call: p1a8a272a.getMaxIndex
        // call: p1a8a272a.<init>
        // call: pd57771ba$p2bd4a59b.<init>
        // call: pd57771ba$p2bd4a59b.build
        // call: p1a8a272a.getNextState
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fb3a0a7bb
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f63a9f0ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        // type: p823c49a3$p2bd4a59b
        // type: p1a8a272a
        // type: pd57771ba$p2bd4a59b
        // type: IllegalArgumentException
        return default!;
    }

    private p1a8a272a GetBDSState()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: p823c49a3.toByteArray
        return default!;
    }

    public int GetIndex()
    {
        // call: p1a8a272a.getIndex
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        return 0;
    }

    public p823c49a3 GetNextKey()
    {
        // call: p823c49a3.extractKeyShard
        return default!;
    }

    public pf62ef2d9 GetParameters()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f21ffce5b
        return default!;
    }

    public byte[] GetPublicSeed()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f529a2433
        return default!;
    }

    public byte[] GetRoot()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f63a9f0ea
        return default!;
    }

    public byte[] GetSecretKeyPRF()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fb3a0a7bb
        return default!;
    }

    public byte[] GetSecretKeySeed()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fd70b5bc6
        return default!;
    }

    public long GetUsagesRemaining()
    {
        // call: p1a8a272a.getMaxIndex
        // call: p823c49a3.getIndex
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        return 0;
    }

    private p823c49a3 RollKey()
    {
        // call: p1a8a272a.getIndex
        // call: p1a8a272a.getMaxIndex
        // call: pd57771ba$p2bd4a59b.<init>
        // call: pd57771ba$p2bd4a59b.build
        // call: p1a8a272a.getNextState
        // call: p1a8a272a.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f21ffce5b
        // type: pd57771ba$p2bd4a59b
        // type: p1a8a272a
        return default!;
    }

    public byte[] ToByteArray()
    {
        // str: "error serializing bds state: "
        // call: pf62ef2d9.getTreeDigestSize
        // call: p1a8a272a.getIndex
        // call: p4492081c.m27c2615b
        // call: p0f7b81e5.m7d427729
        // call: p0f7b81e5.m235cdd01
        // call: pff43b8de.md844b504
        // call: StringBuilder.<init>
        // call: IOException.getMessage
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: Exception.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f246658d0
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.fb3a0a7bb
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p823c49a3.f63a9f0ea
        // type: Exception
        // type: StringBuilder
        return default!;
    }

}
