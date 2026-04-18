namespace WillowMaze.Wasm.Decompiled;

public interface P06050a91_p53205501
{
    pc3755e61 Call();
    int ConnectTimeoutMillis();
    pc2cc7082 Connection();
    pd64ed3e9 Proceed(p15c2d85f P0);
    int ReadTimeoutMillis();
    p15c2d85f Request();
    p06050a91$p53205501 WithConnectTimeout(int P0, TimeUnit P1);
    p06050a91$p53205501 WithReadTimeout(int P0, TimeUnit P1);
    p06050a91$p53205501 WithWriteTimeout(int P0, TimeUnit P1);
    int WriteTimeoutMillis();
}
