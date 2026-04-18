namespace WillowMaze.Wasm.Decompiled;

public class Pbf81b3bd : Peb79da3a, P3a1edd0a, Pec546d1c
{
    private readonly byte[] F0d2d9d76;
    private bool F1aec9c5d;
    private readonly pe6015194 F21ffce5b;
    private p8fc89a90 F246658d0;
    private readonly byte[] F26f08bcf;
    private long F26ff8a69;
    private p8fc89a90 F2d89489a;
    private long F3293d86d;
    private readonly byte[] F529a2433;
    private readonly byte[] F52cf1df7;
    private readonly pe6015194 F5b17bc39;
    private readonly byte[] F63a9f0ea;
    private long F6a992d55;
    private readonly byte[] F7b1eec5c;
    private readonly byte[] F84cedee1;
    private readonly byte[] F892733e8;
    private readonly byte[] F8fc08004;
    private readonly byte[] F91ec7bcf;
    private readonly byte[] F9ace2fd7;
    private p8fc89a90 Fa2f25f17;
    private readonly byte[] Fa5c6199e;
    private readonly byte[] Fb3a0a7bb;
    private readonly byte[] Fb6850a85;
    private bool Fbbf20d92;
    private p8fc89a90 Fbfabbe87;
    private readonly byte[] Fc189eb78;
    private p8fc89a90 Fc5a683bf;
    private readonly byte[] Fd70b5bc6;
    private readonly pe6015194 Fe36dca70;
    private readonly byte[] Fe454fde5;

    public pbf81b3bd ExtractKeyShard(int P0)
    {
        // str: "cannot ask for a shard with 0 keys"
        // str: "usageCount exceeds usages remaining"
        // call: pbf81b3bd.getUsagesRemaining
        // call: pbf81b3bd$p2bd4a59b.<init>
        // call: pbf81b3bd$p2bd4a59b.withSecretKeySeed
        // call: pbf81b3bd$p2bd4a59b.withSecretKeyPRF
        // call: pbf81b3bd$p2bd4a59b.withPublicSeed
        // call: pbf81b3bd$p2bd4a59b.withRoot
        // call: pbf81b3bd.getIndex
        // call: pbf81b3bd$p2bd4a59b.withIndex
        // call: p8fc89a90.<init>
        // call: pbf81b3bd$p2bd4a59b.withBDSState
        // call: pbf81b3bd$p2bd4a59b.build
        // call: pbf81b3bd.rollKey
        // call: IllegalArgumentException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fb3a0a7bb
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f63a9f0ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f246658d0
        // type: IllegalArgumentException
        // type: pbf81b3bd$p2bd4a59b
        // type: p8fc89a90
        return default!;
    }

    private p8fc89a90 GetBDSState()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f246658d0
        return default!;
    }

    public byte[] GetEncoded()
    {
        // call: pbf81b3bd.toByteArray
        return default!;
    }

    public long GetIndex()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f6a992d55
        return 0;
    }

    public pbf81b3bd GetNextKey()
    {
        // call: pbf81b3bd.extractKeyShard
        return default!;
    }

    public pe6015194 GetParameters()
    {
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f21ffce5b
        return default!;
    }

    public byte[] GetPublicSeed()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f529a2433
        return default!;
    }

    public byte[] GetRoot()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f63a9f0ea
        return default!;
    }

    public byte[] GetSecretKeyPRF()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fb3a0a7bb
        return default!;
    }

    public byte[] GetSecretKeySeed()
    {
        // call: p0f7b81e5.m20260f59
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fd70b5bc6
        return default!;
    }

    public long GetUsagesRemaining()
    {
        // call: p8fc89a90.getMaxIndex
        // call: pbf81b3bd.getIndex
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f246658d0
        return 0;
    }

    private pbf81b3bd RollKey()
    {
        // call: pbf81b3bd.getIndex
        // call: p8fc89a90.getMaxIndex
        // call: p8fc89a90.updateState
        // call: p8fc89a90.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f246658d0
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f1aec9c5d
        // type: p8fc89a90
        return default!;
    }

    public byte[] ToByteArray()
    {
        // str: "error serializing bds state: "
        // call: pe6015194.getTreeDigestSize
        // call: pe6015194.getHeight
        // call: p0f7b81e5.me6b9e09d
        // call: p0f7b81e5.m7d427729
        // call: p0f7b81e5.m235cdd01
        // call: pff43b8de.md844b504
        // call: StringBuilder.<init>
        // call: IOException.getMessage
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f21ffce5b
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f6a992d55
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fd70b5bc6
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.fb3a0a7bb
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f529a2433
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f63a9f0ea
        // field: p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pbf81b3bd.f246658d0
        // type: IllegalStateException
        // type: StringBuilder
        return default!;
    }

}
