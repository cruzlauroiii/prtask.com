namespace WillowMaze.Wasm.Decompiled;

public interface ApplicationInput
{
    List<object> AdditionalTlvs();
    bool ContinueWithTransaction();
    byte[] TagsToRead();
    List<object> TlvsToWriteAfterGenAC();
    List<object> TlvsToWriteBeforeGenAC();
}
