namespace WillowMaze.Wasm.Decompiled;

public class P4b279415 : P5fa140e9
{
    private readonly p9cd72ef0 F99e5e314;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void BackToEditSellReceipt()
    {
        // call: p9cd72ef0.backTo
        // call: p5fa140e9$pb0da8397.mbcdc39c7
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void BackToFastSellChoosePaySystem()
    {
        // call: p4b279415.getFastSellChoosePaySystemScreen
        // call: p9cd72ef0.backTo
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void BackToSellChoosePaySystem()
    {
        // call: p3b8fcfe0.SellReceiptChoosePaymentSystemScreen
        // call: p9cd72ef0.backTo
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public p2fc3359e GetEditSellReceiptScreen(ped663a3e P0)
    {
        // call: p3b8fcfe0.EditSellReceiptScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        return default!;
    }

    public p2fc3359e GetFastSellChoosePaySystemScreen()
    {
        // call: p3b8fcfe0.FastSellChoosePaySystemScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        return default!;
    }

    public p2fc3359e GetSellReceiptChoosePaymentSystemScreen()
    {
        // call: p3b8fcfe0.SellReceiptChoosePaymentSystemScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        return default!;
    }

    public p2fc3359e GetSellReceiptSuccessfullySent(p9ded6185 P0)
    {
        // str: "receipt"
        // call: p3b8fcfe0.SellReceiptSuccessfullySentScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        return default!;
    }

    public void NewRootChainWithFastSell(p2fc3359e P0)
    {
        // str: "launcherScreen"
        // call: Intrinsics.checkNotNullParameter
        // call: p4b279415.getFastSellChoosePaySystemScreen
        // call: p9cd72ef0.newRootChain
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenComboFastSellChain(p2fc3359e P0)
    {
        // str: "comboPaymentScreen"
        // call: p4b279415.getFastSellChoosePaySystemScreen
        // call: p9cd72ef0.newChain
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenComboSellChain(ped663a3e P0, p2fc3359e P1)
    {
        // str: "receipt"
        // str: "comboPaymentScreen"
        // call: p3b8fcfe0.SellReceiptChoosePaymentSystemScreen
        // call: p9cd72ef0.newChain
        // call: Intrinsics.checkNotNullParameter
        // call: p4b279415.getEditSellReceiptScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenEditSellPosition(pd031d465 P0, string P1, p1cc31b4d P2)
    {
        // str: "editPositionRoute"
        // call: p9cd72ef0.navigateTo
        // call: p3b8fcfe0.EditSellPositionScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenEditSellPositionName()
    {
        // call: p3b8fcfe0.EditPositionNameScreen
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenEditSellReceipt(ped663a3e P0)
    {
        // call: p4b279415.getEditSellReceiptScreen
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenFastSell()
    {
        // call: p4b279415.getFastSellChoosePaySystemScreen
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenPositionDiscount(pd031d465 P0)
    {
        // str: "position"
        // call: Intrinsics.checkNotNullParameter
        // call: p3b8fcfe0.PositionDiscountScreen
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenReceiptDiscount()
    {
        // call: p3b8fcfe0.ReceiptDiscountScreen
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
    }

    public void OpenSellAllPaymentTypes(List<object> P0)
    {
        // str: "paymentTypes"
        // call: p9cd72ef0.navigateTo
        // call: Intrinsics.checkNotNullParameter
        // call: p3b8fcfe0.SellAllPaymentTypesScreen
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
    }

    public void OpenSellReceiptChoosePaymentSystem()
    {
        // call: p9cd72ef0.navigateTo
        // call: p3b8fcfe0.SellReceiptChoosePaymentSystemScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void OpenSellReceiptSuccessfullySent(p9ded6185 P0)
    {
        // str: "receipt"
        // call: Intrinsics.checkNotNullParameter
        // call: p4b279415.getSellReceiptSuccessfullySent
        // call: p9cd72ef0.navigateTo
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void ReplaceSellReceiptSuccessfullySent(p9ded6185 P0)
    {
        // str: "receipt"
        // call: p4b279415.getSellReceiptSuccessfullySent
        // call: p9cd72ef0.replaceScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void ReplaceSendSellReceiptError()
    {
        // call: p3b8fcfe0.SendSellReceiptErrorScreen
        // call: p9cd72ef0.replaceScreen
        // field: p8325324b.pfd9160bb.p3b8fcfe0.f76425f17
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void SendResult(string P0, object P1)
    {
        // str: "key"
        // str: "data"
        // call: p9cd72ef0.sendResult
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "key"
        // str: "listener"
        // call: p9cd72ef0.setResultListener
        // call: Intrinsics.checkNotNullParameter
        // field: p8325324b.pfd9160bb.p4b279415.ff3395cd5
    }

}
