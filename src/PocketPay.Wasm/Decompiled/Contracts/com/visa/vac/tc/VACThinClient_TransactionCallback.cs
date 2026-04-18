namespace WillowMaze.Wasm.Decompiled;

public interface VACThinClient_TransactionCallback
{
    void OnCVM(int P0, Transaction P1);
    void OnComplete(int P0, Transaction P1);
    void OnFailure(int P0, Transaction P1);
    void OnProgress(int P0, Transaction P1);
}
