namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has CancelPaymentAsync and MayaConstants has CancelPaymentEndpoint with cancel path")]
    public void Rule176MayaCancelPayment()
    {
        var PaymentService = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(PaymentService.Contains("CancelPaymentAsync"),
            "IPaymentService must have CancelPaymentAsync method");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("CancelPaymentEndpoint"),
            "MayaConstants must define CancelPaymentEndpoint");
        Assert.IsTrue(MayaConst.Contains("cancel"),
            "CancelPaymentEndpoint must contain cancel path segment");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has GetPaymentStatusLightAsync for lightweight status check")]
    public void Rule177MayaPaymentStatusLight()
    {
        var PaymentService = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(PaymentService.Contains("GetPaymentStatusLightAsync"),
            "IPaymentService must have GetPaymentStatusLightAsync method");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("PaymentStatusEndpoint"),
            "MayaConstants must define PaymentStatusEndpoint");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IPaymentService has CapturePaymentAsync distinct from P3 capture endpoints")]
    public void Rule178MayaV1PaymentCapture()
    {
        var PaymentService = ReadSource("PrTask.Application", "Services", "IPaymentService.cs");
        Assert.IsTrue(PaymentService.Contains("CapturePaymentAsync"),
            "IPaymentService must have CapturePaymentAsync method");
        var MayaConst = ReadSource("PrTask.Domain", "Constants", "MayaConstants.cs");
        Assert.IsTrue(MayaConst.Contains("P3CaptureEndpoint"),
            "MayaConstants must still have P3CaptureEndpoint as a separate endpoint");
        var FormatStr = ReadSource("PrTask.Domain", "Constants", "FormatStrings.cs");
        Assert.IsTrue(FormatStr.Contains("MayaPaymentCapturePath"),
            "FormatStrings must have MayaPaymentCapturePath for v1 capture distinct from P3");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("IMayaConnectService exists in Application Services with OAuth methods")]
    public void Rule179MayaConnectOAuth()
    {
        var ConnectPath = Path.Combine(SourceRoot, "PrTask.Application", "Services", "IMayaConnectService.cs");
        Assert.IsTrue(File.Exists(ConnectPath), "IMayaConnectService must exist in PrTask.Application/Services");
        var Connect = File.ReadAllText(ConnectPath);
        Assert.IsTrue(Connect.Contains("AuthorizeAsync"),
            "IMayaConnectService must have AuthorizeAsync method");
        Assert.IsTrue(Connect.Contains("ExchangeTokenAsync"),
            "IMayaConnectService must have ExchangeTokenAsync method");
        Assert.IsTrue(Connect.Contains("RefreshTokenAsync"),
            "IMayaConnectService must have RefreshTokenAsync method");
        Assert.IsTrue(Connect.Contains("GetUserInfoAsync"),
            "IMayaConnectService must have GetUserInfoAsync method");
        Assert.IsTrue(Connect.Contains("GetJwkAsync"),
            "IMayaConnectService must have GetJwkAsync method");
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("WorkItemType enum has Epic Feature Story Task Bug and SprintEntity BoardEntity BoardColumnEntity have required properties")]
    public void Rule180WorkItemSprintBoardTests()
    {
        var WorkItemType = ReadSource("PrTask.Domain", "Models", "WorkItemType.cs");
        Assert.IsTrue(WorkItemType.Contains("Epic"), "WorkItemType must have Epic value");
        Assert.IsTrue(WorkItemType.Contains("Feature"), "WorkItemType must have Feature value");
        Assert.IsTrue(WorkItemType.Contains("Story"), "WorkItemType must have Story value");
        Assert.IsTrue(WorkItemType.Contains("Task"), "WorkItemType must have Task value");
        Assert.IsTrue(WorkItemType.Contains("Bug"), "WorkItemType must have Bug value");

        var Sprint = ReadSource("PrTask.Domain", "Models", "SprintEntity.cs");
        Assert.IsTrue(Sprint.Contains("Id"), "SprintEntity must have Id property");
        Assert.IsTrue(Sprint.Contains("Name"), "SprintEntity must have Name property");
        Assert.IsTrue(Sprint.Contains("Goal"), "SprintEntity must have Goal property");
        Assert.IsTrue(Sprint.Contains("OwnerId"), "SprintEntity must have OwnerId property");
        Assert.IsTrue(Sprint.Contains("Status"), "SprintEntity must have Status property");
        Assert.IsTrue(Sprint.Contains("StartDate"), "SprintEntity must have StartDate property");
        Assert.IsTrue(Sprint.Contains("EndDate"), "SprintEntity must have EndDate property");

        var Board = ReadSource("PrTask.Domain", "Models", "BoardEntity.cs");
        Assert.IsTrue(Board.Contains("Id"), "BoardEntity must have Id property");
        Assert.IsTrue(Board.Contains("Name"), "BoardEntity must have Name property");
        Assert.IsTrue(Board.Contains("OwnerId"), "BoardEntity must have OwnerId property");
        Assert.IsTrue(Board.Contains("Type"), "BoardEntity must have Type property");
        Assert.IsTrue(Board.Contains("SprintId"), "BoardEntity must have SprintId property");

        var BoardColumn = ReadSource("PrTask.Domain", "Models", "BoardColumnEntity.cs");
        Assert.IsTrue(BoardColumn.Contains("Id"), "BoardColumnEntity must have Id property");
        Assert.IsTrue(BoardColumn.Contains("BoardId"), "BoardColumnEntity must have BoardId property");
        Assert.IsTrue(BoardColumn.Contains("Name"), "BoardColumnEntity must have Name property");
        Assert.IsTrue(BoardColumn.Contains("Order"), "BoardColumnEntity must have Order property");
        Assert.IsTrue(BoardColumn.Contains("WipLimit"), "BoardColumnEntity must have WipLimit property");
    }
}
