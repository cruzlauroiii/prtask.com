namespace WillowMaze.Wasm.Decompiled;

public class P6599673d : P1eb558b5
{
    private readonly Deflater F0a8ccfbb;
    private readonly pc74ae48a F0ef1f65f;
    private readonly pc74ae48a F23bbdcd9;
    private bool F349e6863;
    private readonly pd84c6f13 F3ac8faae;
    private readonly pc74ae48a F3f80f324;
    private readonly CRC32 F519e06fd;
    private readonly Deflater F71e1f7f8;
    private readonly pc74ae48a F7520b2e7;
    private bool F7b91e6ff;
    private bool F7beecdc7;
    private readonly pd84c6f13 F8b00f30b;
    private readonly CRC32 Fb657b70d;
    private bool Fbeb91ad1;
    private readonly CRC32 Fc5cf5dcd;
    private readonly pd84c6f13 Fe6036ed6;
    private bool Fed7054c0;
    private readonly CRC32 Ff5ad59c5;
    private readonly Deflater Ff66f6876;
    private readonly pd84c6f13 Ff6e04117;

    private void M1220607c()
    {
        // call: Deflater.getBytesRead
        // call: pd84c6f13.writeIntLe
        // call: CRC32.getValue
        // field: p38cb8f46.p6599673d.ff6e04117
        // field: p38cb8f46.p6599673d.ff5ad59c5
        // field: p38cb8f46.p6599673d.f0a8ccfbb
    }

    private void Mf25b14da(p7e62bc34 P0, long P1)
    {
        // call: CRC32.update
        // call: Intrinsics.checkNotNull
        // call: Math.min
        // field: p38cb8f46.p4b77e2a9.faa9f73ee
        // field: p38cb8f46.p7e62bc34.f96e89a29
        // field: p38cb8f46.p4b77e2a9.f5e0bdcbd
        // field: p38cb8f46.p4b77e2a9.fd0cab90d
        // field: p38cb8f46.p4b77e2a9.f8d777f38
        // field: p38cb8f46.p6599673d.ff5ad59c5
    }

    public Deflater -deprecated_deflater()
    {
        // field: p38cb8f46.p6599673d.f0a8ccfbb
        return default!;
    }

    public void Close()
    {
        // call: Deflater.end
        // call: pd84c6f13.close
        // call: pc74ae48a.finishDeflate$okio
        // call: p6599673d.m1220607c
        // field: p38cb8f46.p6599673d.f349e6863
        // field: p38cb8f46.p6599673d.f0a8ccfbb
        // field: p38cb8f46.p6599673d.ff6e04117
        // field: p38cb8f46.p6599673d.f7520b2e7
    }

    public Deflater Deflater()
    {
        // field: p38cb8f46.p6599673d.f0a8ccfbb
        return default!;
    }

    public void Flush()
    {
        // call: pc74ae48a.flush
        // field: p38cb8f46.p6599673d.f7520b2e7
    }

    public pc85a251c Timeout()
    {
        // call: pd84c6f13.timeout
        // field: p38cb8f46.p6599673d.ff6e04117
        return default!;
    }

    public void Write(p7e62bc34 P0, long P1)
    {
        // str: "byteCount < 0: "
        // str: "source"
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: p6599673d.mf25b14da
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pc74ae48a.write
        // call: object.toString
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p6599673d.f7520b2e7
        // type: StringBuilder
        // type: IllegalArgumentException
    }

}
