namespace WillowMaze.Wasm.Decompiled;

public class P158bf392 : P1b3a5bf0
{
    private readonly p9cd72ef0 F14f7ec35;
    private readonly p9cd72ef0 F2d297a94;
    private readonly p9cd72ef0 F8779bf2a;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void BackToPaybackChoosePaymentSystem()
    {
        // call: pf2a28181.PaybackChoosePaymentSystemScreen
        // call: p9cd72ef0.backTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void BackToPaybackPositions()
    {
        // call: p9cd72ef0.backTo
        // call: pf2a28181.PaybackPositionsScreen
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void BackToPaybackReceiptList()
    {
        // call: pf2a28181.PaybackReceiptListScreen
        // call: p9cd72ef0.backTo
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
    }

    public void NewChainWithReceipt()
    {
        // call: pf2a28181.PaybackPositionsScreen
        // call: p9cd72ef0.newChain
        // call: pf2a28181.PaybackReceiptDetailScreen
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
    }

    public void OpenComboPaybackChain(p2fc3359e P0)
    {
        // str: "comboPaybackPaymentScreen"
        // call: pf2a28181.PaybackPositionsScreen
        // call: pf2a28181.PaybackChoosePaymentSystemScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.newChain
        // call: pf2a28181.PaybackReceiptDetailScreen
        // call: pf2a28181.PaybackReceiptListScreen
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenEditPaybackPosition(pd031d465 P0, string P1)
    {
        // call: pf2a28181.EditPaybackPositionScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenEditPaybackPositionName()
    {
        // call: pf2a28181.EditPaybackPositionNameScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenPaybackChoosePaymentSystem()
    {
        // call: pf2a28181.PaybackChoosePaymentSystemScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
    }

    public void OpenPaybackError()
    {
        // call: p9cd72ef0.navigateTo
        // call: pf2a28181.PaybackErrorScreen
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
    }

    public void OpenPaybackPositions()
    {
        // call: pf2a28181.PaybackPositionsScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenPaybackReceiptDetail()
    {
        // call: p9cd72ef0.navigateTo
        // call: pf2a28181.PaybackReceiptDetailScreen
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenPaybackReceiptList()
    {
        // call: pf2a28181.PaybackReceiptListScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenPaybackSearch()
    {
        // call: pf2a28181.PaybackSearchScreen
        // call: p9cd72ef0.navigateTo
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void OpenPaybackSuccess(p9ded6185 P0)
    {
        // str: "receipt"
        // call: pf2a28181.PaybackSuccessScreen
        // call: p9cd72ef0.navigateTo
        // call: Intrinsics.checkNotNullParameter
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void ReplacePaybackError()
    {
        // call: p9cd72ef0.replaceScreen
        // call: pf2a28181.PaybackErrorScreen
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void ReplacePaybackSuccess(p9ded6185 P0)
    {
        // str: "receipt"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.replaceScreen
        // call: pf2a28181.PaybackSuccessScreen
        // field: p4670093c.pfd9160bb.pf2a28181.f76425f17
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void SendResult(string P0, object P1)
    {
        // str: "data"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "key"
        // str: "listener"
        // call: p9cd72ef0.setResultListener
        // call: Intrinsics.checkNotNullParameter
        // field: p4670093c.pfd9160bb.p158bf392.ff3395cd5
    }

}
