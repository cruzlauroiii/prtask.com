namespace WillowMaze.Wasm.Decompiled;

public interface P5fa140e9
{
    void Back();
    void BackToEditSellReceipt();
    void BackToFastSellChoosePaySystem();
    void BackToSellChoosePaySystem();
    p2fc3359e GetEditSellReceiptScreen(ped663a3e P0);
    p2fc3359e GetFastSellChoosePaySystemScreen();
    p2fc3359e GetSellReceiptChoosePaymentSystemScreen();
    p2fc3359e GetSellReceiptSuccessfullySent(p9ded6185 P0);
    void NewRootChainWithFastSell(p2fc3359e P0);
    void OpenComboFastSellChain(p2fc3359e P0);
    void OpenComboSellChain(ped663a3e P0, p2fc3359e P1);
    void OpenEditSellPosition(pd031d465 P0, string P1, p1cc31b4d P2);
    void OpenEditSellPositionName();
    void OpenEditSellReceipt(ped663a3e P0);
    void OpenFastSell();
    void OpenPositionDiscount(pd031d465 P0);
    void OpenReceiptDiscount();
    void OpenSellAllPaymentTypes(List<object> P0);
    void OpenSellReceiptChoosePaymentSystem();
    void OpenSellReceiptSuccessfullySent(p9ded6185 P0);
    void ReplaceSellReceiptSuccessfullySent(p9ded6185 P0);
    void ReplaceSendSellReceiptError();
    void SendResult(string P0, object P1);
    void SetResultListener(string P0, p449a7995 P1);
}
