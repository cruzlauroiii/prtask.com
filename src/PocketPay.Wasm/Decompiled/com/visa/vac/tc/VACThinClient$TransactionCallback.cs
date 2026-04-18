namespace WillowMaze.Wasm.Decompiled;


public interface VACThinClient$TransactionCallback {
    void onCVM(int i, com.visa.vac.tc.emvconverter.Transaction transaction);

    void onComplete(int i, com.visa.vac.tc.emvconverter.Transaction transaction);

    void onFailure(int i, com.visa.vac.tc.emvconverter.Transaction transaction);

    void onProgress(int i, com.visa.vac.tc.emvconverter.Transaction transaction);
}

