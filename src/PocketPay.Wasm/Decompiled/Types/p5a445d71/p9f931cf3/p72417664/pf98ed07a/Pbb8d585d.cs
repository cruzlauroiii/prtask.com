namespace WillowMaze.Wasm.Decompiled;

public class Pbb8d585d : FilterInputStream
{
    private readonly System.Security.Cryptography.Aes F08406a6e;
    private readonly System.Security.Cryptography.Aes F0ceefb12;
    private int F1940f1ee;
    private readonly byte[] F25dfa9d3;
    private bool F279838f5;
    private int F306e794d;
    private int F4fe2f532;
    private int F51e9ab27;
    private readonly byte[] F521965a6;
    private int F551ce4b2;
    private readonly System.Security.Cryptography.Aes F6ac13469;
    private bool F73d0ccbc;
    private byte[] Fa8513062;
    private readonly System.Security.Cryptography.Aes Fbb6702c9;
    private int Fbbc0db51;
    private byte[] Fcb7e52b2;
    private byte[] Fcfc07724;
    private int Fddc190a7;

    private int M69dd5454()
    {
        // call: Stream.read
        // call: System.Security.Cryptography.Aes.update
        // call: pbb8d585d.mc64e02d4
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f51e9ab27
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f13b5bfe9
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f08406a6e
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f25dfa9d3
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f73d0ccbc
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        return 0;
    }

    private byte[] Mc64e02d4()
    {
        // str: "Error finalising cipher"
        // call: p5553727c.<init>
        // call: System.Security.Cryptography.Aes.doFinal
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f73d0ccbc
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f08406a6e
        // type: p5553727c
        return default!;
    }

    public int Available()
    {
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f51e9ab27
        return 0;
    }

    public void Close()
    {
        // call: pbb8d585d.mc64e02d4
        // call: Stream.close
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f73d0ccbc
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f51e9ab27
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f13b5bfe9
    }

    public void Mark(int P0)
    {
    }

    public bool MarkSupported()
    {
        return false;
    }

    public int Read()
    {
        // call: pbb8d585d.m69dd5454
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.fcb7e52b2
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f51e9ab27
        return 0;
    }

    public int Read(byte[] P0, int P1, int P2)
    {
        // call: pbb8d585d.available
        // call: Math.min
        // call: pbb8d585d.m69dd5454
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f51e9ab27
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.fcb7e52b2
        return 0;
    }

    public void Reset()
    {
    }

    public long Skip(long P0)
    {
        // call: pbb8d585d.available
        // call: Math.min
        // field: p5a445d71.p9f931cf3.p72417664.pf98ed07a.pbb8d585d.f4fe2f532
        return 0;
    }

}
