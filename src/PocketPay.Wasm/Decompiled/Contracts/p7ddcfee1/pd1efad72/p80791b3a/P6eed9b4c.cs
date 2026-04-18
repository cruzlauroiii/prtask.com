namespace WillowMaze.Wasm.Decompiled;

public interface P6eed9b4c
{
    void Cancel();
    p1eb558b5 CreateRequestBody(p15c2d85f P0, long P1);
    void FinishRequest();
    void FlushRequest();
    pc2c7dd60 GetConnection();
    pf31bbdd1 OpenResponseBodySource(pd64ed3e9 P0);
    pd64ed3e9$p2bd4a59b ReadResponseHeaders(bool P0);
    long ReportedContentLength(pd64ed3e9 P0);
    p883d7615 Trailers();
    void WriteRequestHeaders(p15c2d85f P0);
}
