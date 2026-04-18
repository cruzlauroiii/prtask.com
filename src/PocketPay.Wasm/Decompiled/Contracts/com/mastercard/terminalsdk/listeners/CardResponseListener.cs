namespace WillowMaze.Wasm.Decompiled;

public interface CardResponseListener
{
    void OnL1RSPException(ErrorIndication$L1_Error_Code P0);
    void OnResponse(byte[] P0);
}
