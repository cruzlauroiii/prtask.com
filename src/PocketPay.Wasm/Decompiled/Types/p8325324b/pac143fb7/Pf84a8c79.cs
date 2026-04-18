namespace WillowMaze.Wasm.Decompiled;

public class Pf84a8c79 : P0bfd7fb7
{
    private readonly pef9926d1 F1ffe46c0;
    private readonly p44cd4abe F2a446288;
    private readonly p6d29e2ef F3b221080;
    private readonly pef9926d1 F3cd4a202;
    private readonly p44cd4abe F8af308bf;
    private readonly p3851083a F91b5f5ab;
    private readonly p6d29e2ef F97e1f910;
    private readonly p6d29e2ef F9b0a5a29;
    private readonly p3851083a F9d84311b;
    private readonly p44cd4abe Fab168a8c;
    private readonly p44cd4abe Fb14c10aa;
    private readonly pef9926d1 Fd8f0064e;

    public object AddPositionToReceipt(pd031d465 P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: pf84a8c79$p234facb0$1.<init>
        // call: ResultKt.throwOnFailure
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.clearReceiptDiscount
        // call: IllegalStateException.<init>
        // call: p3851083a.addPositionToReceipt
        // field: p8325324b.pac143fb7.pf84a8c79$p234facb0$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79$p234facb0$1.L$1
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: p8325324b.pac143fb7.pf84a8c79$p234facb0$1.fd304ba20
        // field: p8325324b.pac143fb7.pf84a8c79$p234facb0$1.fb4a88417
        // field: kotlin.Unit.INSTANCE
        // type: pf84a8c79$p234facb0$1
        // type: IllegalStateException
        return default!;
    }

    public object CheckDuplicateReceipt(string P0, object P1)
    {
        // call: p3851083a.checkDuplicateReceipt
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object GetCurrentSellReceipt(object P0)
    {
        // call: p3851083a.getSellReceipt
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object GetLastFastSellPosition(object P0)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: p44cd4abe.getSelectedDevice
        // call: pef9926d1.getLastFastSellPosition
        // call: ResultKt.throwOnFailure
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p4f30e9bd.getDeviceId
        // call: pf84a8c79$p99a76d2b$1.<init>
        // call: IllegalStateException.<init>
        // field: p8325324b.pac143fb7.pf84a8c79$p99a76d2b$1.fb4a88417
        // field: p8325324b.pac143fb7.pf84a8c79$p99a76d2b$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79$p99a76d2b$1.fd304ba20
        // field: p8325324b.pac143fb7.pf84a8c79.fd8f0064e
        // field: p8325324b.pac143fb7.pf84a8c79.f8af308bf
        // type: pf84a8c79$p99a76d2b$1
        // type: IllegalStateException
        return default!;
    }

    public object GetNoteReceipt(object P0)
    {
        // call: p3851083a.getNoteReceipt
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object GetReceiptPositions(object P0)
    {
        // call: p3851083a.getReceiptPositions
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object HasUnfinishedReceipt(object P0)
    {
        // call: p3851083a.hasUnfinishedReceipt
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object IncreasePositionQuantity(pd031d465 P0, decimal P1, object P2)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: ResultKt.throwOnFailure
        // call: p3851083a.increasePositionQuantity
        // call: IllegalStateException.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: pf84a8c79$p643683c5$1.<init>
        // call: p3851083a.clearReceiptDiscount
        // field: p8325324b.pac143fb7.pf84a8c79$p643683c5$1.fd304ba20
        // field: p8325324b.pac143fb7.pf84a8c79$p643683c5$1.L$2
        // field: p8325324b.pac143fb7.pf84a8c79$p643683c5$1.L$1
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79$p643683c5$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: p8325324b.pac143fb7.pf84a8c79$p643683c5$1.fb4a88417
        // type: IllegalStateException
        // type: pf84a8c79$p643683c5$1
        return default!;
    }

    public bool IsAnimationNotePreviewShown()
    {
        // call: pd4ccf9ff.getNoteReceiptAnimation
        // call: p6d29e2ef.getAnimationPreview
        // call: bool.booleanValue
        // field: p8325324b.pac143fb7.pf84a8c79.f97e1f910
        return false;
    }

    public bool IsAnimationPreviewShown()
    {
        // call: bool.booleanValue
        // call: pd4ccf9ff.getSellPositionAnimation
        // call: p6d29e2ef.getAnimationPreview
        // field: p8325324b.pac143fb7.pf84a8c79.f97e1f910
        return false;
    }

    public object OpenEmptySellReceipt(object P0)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.openEmptySellReceipt
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object OpenNotEmptySellReceipt(ped663a3e P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.openNotEmptySellReceipt
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object OpenOrEditSellReceipt(object P0)
    {
        // call: p3851083a.openOrEditSellReceipt
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object OpenSinglePaymentIfNeeded(object P0)
    {
        // call: p3851083a.openSinglePaymentIfNeeded
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object RemoveAllPositionsFromReceipt(object P0)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: p3851083a.removeAllPositionsFromReceipt
        // call: ResultKt.throwOnFailure
        // call: pf84a8c79$p5be57e9d$1.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: IllegalStateException.<init>
        // call: p3851083a.clearReceiptDiscount
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: p8325324b.pac143fb7.pf84a8c79$p5be57e9d$1.fd304ba20
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79$p5be57e9d$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79$p5be57e9d$1.fb4a88417
        // type: IllegalStateException
        // type: pf84a8c79$p5be57e9d$1
        return default!;
    }

    public object RemoveCurrentReceipt(object P0)
    {
        // call: p3851083a.removeCurrentReceipt
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object RemovePositionFromReceipt(pd031d465 P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: p3851083a.clearReceiptDiscount
        // call: ResultKt.throwOnFailure
        // call: pf84a8c79$pc5336464$1.<init>
        // call: p3851083a.removePositionFromReceipt
        // call: IllegalStateException.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79$pc5336464$1.L$1
        // field: p8325324b.pac143fb7.pf84a8c79$pc5336464$1.fd304ba20
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79$pc5336464$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79$pc5336464$1.fb4a88417
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // type: IllegalStateException
        // type: pf84a8c79$pc5336464$1
        return default!;
    }

    public object ReplacePosition(pd031d465 P0, pd031d465 P1, object P2)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: ResultKt.throwOnFailure
        // call: p3851083a.clearReceiptDiscount
        // call: p3851083a.replacePosition
        // call: IllegalStateException.<init>
        // call: pf84a8c79$pb7ecc47b$1.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: p8325324b.pac143fb7.pf84a8c79$pb7ecc47b$1.L$0
        // field: p8325324b.pac143fb7.pf84a8c79$pb7ecc47b$1.fd304ba20
        // field: p8325324b.pac143fb7.pf84a8c79$pb7ecc47b$1.L$1
        // field: p8325324b.pac143fb7.pf84a8c79$pb7ecc47b$1.L$2
        // field: p8325324b.pac143fb7.pf84a8c79$pb7ecc47b$1.fb4a88417
        // field: kotlin.Unit.INSTANCE
        // type: IllegalStateException
        // type: pf84a8c79$pb7ecc47b$1
        return default!;
    }

    public void SetAnimationNotePreviewIsShown()
    {
        // call: pd4ccf9ff.m1c1e012b
        // call: p6d29e2ef.setAnimationPreview
        // call: bool.valueOf
        // call: p6d29e2ef.getAnimationPreview
        // field: p8325324b.pac143fb7.pf84a8c79.f97e1f910
    }

    public void SetAnimationPreviewIsShown()
    {
        // call: bool.valueOf
        // call: pd4ccf9ff.m1c1e012b
        // call: p6d29e2ef.getAnimationPreview
        // call: p6d29e2ef.setAnimationPreview
        // field: p8325324b.pac143fb7.pf84a8c79.f97e1f910
    }

    public object SetLastFastSellPosition(string P0, decimal P1, object P2)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: pf84a8c79$padc69192$1.<init>
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p4f30e9bd.getDeviceId
        // call: p44cd4abe.getSelectedDevice
        // call: pef9926d1.setLastSellPosition
        // field: p8325324b.pac143fb7.pf84a8c79$padc69192$1.fd304ba20
        // field: p8325324b.pac143fb7.pf84a8c79$padc69192$1.L$1
        // field: p8325324b.pac143fb7.pf84a8c79$padc69192$1.L$2
        // field: p8325324b.pac143fb7.pf84a8c79$padc69192$1.L$0
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.fd8f0064e
        // field: p8325324b.pac143fb7.pf84a8c79$padc69192$1.fb4a88417
        // field: p8325324b.pac143fb7.pf84a8c79.f8af308bf
        // type: pf84a8c79$padc69192$1
        // type: IllegalStateException
        return default!;
    }

    public object SetNoteReceipt(string P0, object P1)
    {
        // call: p3851083a.setNoteReceipt
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object SetPaymentAddress(string P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.setPaymentAddress
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object SetPaymentPlace(string P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.setPaymentPlace
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object SetPaymentType(p8c261c90 P0, object P1)
    {
        // call: p3851083a.setPaymentType
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object SetQRPayInfo(pc5f0acf1 P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.setQRPayInfo
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object SetReceiptClientEmail(string P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.setReceiptClientEmail
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object SetReceiptClientPhone(string P0, object P1)
    {
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.setReceiptClientPhone
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object SetShouldPrintReceipt(bool P0, object P1)
    {
        // call: p3851083a.setShouldPrintReceipt
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object SetTransactionToFirstPayment(pf8872840 P0, object P1)
    {
        // call: p3851083a.setTransactionToFirstPayment
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

    public object UpdatePayment(pad7c4a1f P0, string P1, object P2)
    {
        // call: p3851083a.updatePayment
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: kotlin.Unit.INSTANCE
        return default!;
    }

    public object UpdatePosition(pd031d465 P0, object P1)
    {
        // str: "call to 'resume' before 'invoke' with coroutine"
        // call: pf84a8c79$p4c5a4754$1.<init>
        // call: IllegalStateException.<init>
        // call: ResultKt.throwOnFailure
        // call: p3851083a.updatePosition
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // call: p3851083a.clearReceiptDiscount
        // field: p8325324b.pac143fb7.pf84a8c79$p4c5a4754$1.fb4a88417
        // field: p8325324b.pac143fb7.pf84a8c79$p4c5a4754$1.L$1
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        // field: p8325324b.pac143fb7.pf84a8c79$p4c5a4754$1.fd304ba20
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79$p4c5a4754$1.L$0
        // type: pf84a8c79$p4c5a4754$1
        // type: IllegalStateException
        return default!;
    }

    public object UpdateReceiptDiscount(decimal P0, object P1)
    {
        // call: p3851083a.updateReceiptDiscount
        // call: IntrinsicsKt.getCOROUTINE_SUSPENDED
        // field: kotlin.Unit.INSTANCE
        // field: p8325324b.pac143fb7.pf84a8c79.f91b5f5ab
        return default!;
    }

}
