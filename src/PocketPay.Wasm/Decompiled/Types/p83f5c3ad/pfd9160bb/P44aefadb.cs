namespace WillowMaze.Wasm.Decompiled;

public class P44aefadb : P1ceed351
{
    private static p44aefadb$p910eef8c F08d7c490;
    public static string F0927edfa;
    public static string F269872f0;
    public static string F309c6bb7;
    public static string F313c01d5;
    public static string F45025f50;
    public static string F5b337dcc;
    public static string F804bd13a;
    public static string F8bcbc401;
    private static p44aefadb$p910eef8c F910eef8c;
    public static string F962f576a;
    public static string F98a50321;
    private static p44aefadb$p910eef8c F9a9e8b9e;
    private static p44aefadb$p910eef8c Fd8f256a8;
    private readonly p9cd72ef0 F90d2470d;
    private readonly p9cd72ef0 Ff3395cd5;

    public void Back()
    {
        // call: p9cd72ef0.exit
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public DialogFragment GetReceiptBSDialogFragment()
    {
        // call: p2a2acc6d.<init>
        // type: p2a2acc6d
        return default!;
    }

    public string GetReceiptSendByEmailKey()
    {
        // str: "1b67be0f88cbd35907215197f28528267b2995d41d37ed55c0b802eef6563cf58bedc7d4df557fcf92993da7af"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public string GetTophAutoActivationKey()
    {
        // str: "774b6c838256e013e7839fe72e795721a3b4df0ef5c9b1117296837ee344c34fc4fee1a43cb54e0cb3fcbc3926a9fb481..."
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public p2fc3359e GetTophFlow(p15913342 P0, p9ded6185 P1, pad7c4a1f P2, pbfc85237 P3)
    {
        // str: "startTapOnPhoneRoute"
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.TophFlow
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        return default!;
    }

    public string GetTophLogoutKey()
    {
        // str: "91fa907daad2e3e2fd86809c97d228c2ce7af76ac1df1c7f75f9813975bd3a58aa83f9887741e2ca2d4e3d"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public string GetTophPaymentKey()
    {
        // str: "30010f8be6ed722dbd8caa12cbf0f3d9636abed02a43d5d7c0a83ec06902496b4eef061d1dd026ff2aab9ccf"
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public void OpenActivation()
    {
        // call: pf0d70128.ActivationScreen
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenActivationConfirm(pdc33845b P0, string P1)
    {
        // str: "activationCredentials"
        // str: "activationType"
        // call: p9cd72ef0.navigateTo
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.ActivationConfirmScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenActivationViaEmail()
    {
        // call: pf0d70128.ActivationViaEmailScreen
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenActivationViaSms()
    {
        // call: pf0d70128.ActivationViaSmsScreen
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenChooseRegion()
    {
        // call: p9cd72ef0.navigateTo
        // call: pf0d70128.ChooseRegionScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenCreateOrder()
    {
        // call: p9cd72ef0.navigateTo
        // call: pf0d70128.CreateOrderScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenOrderStatus(p80e68906 P0)
    {
        // str: "orderStatus"
        // call: p9cd72ef0.navigateTo
        // call: pf0d70128.OrderStatusScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenQrSlip(p9ded6185 P0)
    {
        // str: "receipt"
        // call: p9cd72ef0.navigateTo
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.QrSlipScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void OpenSendReceiptToEmail(p9ded6185 P0)
    {
        // str: "receipt"
        // call: pf0d70128.SendReceiptToEmailScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void OpenSendReceiptToPhone(p9ded6185 P0)
    {
        // str: "receipt"
        // call: p9cd72ef0.navigateTo
        // call: pf0d70128.SendReceiptToPhoneScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void OpenTophNfcCalibration()
    {
        // call: pf0d70128.TophCalibrationScreen
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void OpenTophSendReport()
    {
        // call: pf0d70128.TophSendReportScreen
        // call: p9cd72ef0.navigateTo
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceToBalanceGone()
    {
        // call: pf0d70128.BalanceGoneScreen
        // call: p9cd72ef0.replaceScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void ReplaceToBalanceSuccess(pbc0ca418 P0)
    {
        // str: "balance"
        // call: pf0d70128.BalanceSuccessScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.replaceScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceToPaymentSellGone()
    {
        // call: pf0d70128.PaymentSellGoneScreen
        // call: p9cd72ef0.replaceScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceToTophBalanceError(string P0)
    {
        // str: "errorMessage"
        // call: pf0d70128.BalanceErrorScreen
        // call: p9cd72ef0.replaceScreen
        // call: Intrinsics.checkNotNullParameter
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceToTophPaybackError(string P0, pb455e130 P1)
    {
        // str: "errorMessage"
        // str: "transferData"
        // call: p9cd72ef0.replaceScreen
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.PaybackErrorScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void ReplaceToTophPaybackGone(string P0)
    {
        // str: "message"
        // call: p9cd72ef0.replaceScreen
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.PaybackGoneScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceToTophPaymentError(string P0, pb455e130 P1)
    {
        // str: "transferData"
        // str: "errorMessage"
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.PaymentErrorScreen
        // call: p9cd72ef0.replaceScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void ReplaceTophNfcCalibration()
    {
        // call: p9cd72ef0.replaceScreen
        // call: pf0d70128.TophCalibrationScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void ReplaceTophNfcCalibrationError()
    {
        // call: p9cd72ef0.replaceScreen
        // call: pf0d70128.TophCalibrationErrorScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void SendResult(string P0, object P1)
    {
        // str: "data"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.sendResult
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void SetResultListener(string P0, p449a7995 P1)
    {
        // str: "listener"
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.setResultListener
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartActivationFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.ActivationScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartAuthFlow()
    {
        // call: pf0d70128.AuthScreen
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartBusinessOrderFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.BusinessOrderScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartCashierOrderFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.CashierOrderScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartLauncherFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.LauncherScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartPaymentSellSuccessFlow(p9ded6185 P0, pb455e130 P1)
    {
        // str: "transferData"
        // call: pf0d70128.PaymentSellSuccessScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartQrSlipFlow(p9ded6185 P0)
    {
        // str: "receipt"
        // call: pf0d70128.QrSlipScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartSendReceiptToEmailFlow(p9ded6185 P0)
    {
        // str: "receipt"
        // call: pf0d70128.SendReceiptToEmailScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartSendReceiptToPhoneFlow(p9ded6185 P0)
    {
        // str: "receipt"
        // call: pf0d70128.SendReceiptToPhoneScreen
        // call: Intrinsics.checkNotNullParameter
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartTophBalanceFlow()
    {
        // call: pf0d70128.BalanceScreen
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophInfoFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.TophInfoScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartTophNfcCalibrationFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.TophCalibrationBoardingScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophNfcCalibrationHelpFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.TophCalibrationHelpScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophPaybackFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.PaybackScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophPaybackSuccessFlow(p9ded6185 P0, pb455e130 P1)
    {
        // str: "receipt"
        // str: "transferData"
        // call: p9cd72ef0.newRootScreen
        // call: Intrinsics.checkNotNullParameter
        // call: pf0d70128.PaybackSuccessScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophPaymentSellFlow()
    {
        // call: pf0d70128.PaymentSellScreen
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

    public void StartTophQrInfoFlow()
    {
        // call: pf0d70128.TophQrInfoScreen
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophQrPaybackFlow()
    {
        // call: pf0d70128.QrPaybackScreen
        // call: p9cd72ef0.newRootScreen
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
    }

    public void StartTophQrSellFlow()
    {
        // call: p9cd72ef0.newRootScreen
        // call: pf0d70128.QrSellScreen
        // field: p83f5c3ad.pfd9160bb.pf0d70128.f76425f17
        // field: p83f5c3ad.pfd9160bb.p44aefadb.ff3395cd5
    }

}
