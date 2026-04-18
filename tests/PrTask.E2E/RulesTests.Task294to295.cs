using PrTask.Domain.Constants;
namespace PrTask.E2E;
public partial class RulesTests
{
    [TestMethod, TestCategory("Rules")]
    [DisplayName("BillsPaymentEndpoints source uses correct route constants and service injection")]
    public async Task BillsPaymentEndpointsSourceStructureAsync()
    {
        var Source = ReadSource("PrTask.Server", "Endpoints", "BillsPaymentEndpoints.cs");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.ApiBillsPayments)),
            "Maps group to RouteConstants.ApiBillsPayments");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.SubBillers)),
            "Has billers GET route via RouteConstants.SubBillers");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.SubBillerBySlug)),
            "Has biller-by-slug GET route via RouteConstants.SubBillerBySlug");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.SubRoot)),
            "Has create POST route via RouteConstants.SubRoot");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.SubBillPaymentExecute)),
            "Has execute POST route via RouteConstants.SubBillPaymentExecute");
        Assert.IsTrue(Source.Contains(nameof(RouteConstants) + "." + nameof(RouteConstants.SubBillPaymentStatus)),
            "Has status GET route via RouteConstants.SubBillPaymentStatus");
        Assert.IsTrue(Source.Contains("IBillsPaymentService"), "Injects IBillsPaymentService");
        Assert.IsTrue(Source.Contains("RequireAuthorization"), "Requires authorization on group");
        Assert.IsTrue(Source.Contains("GetBillersAsync"), "Calls GetBillersAsync");
        Assert.IsTrue(Source.Contains("GetBillerAsync"), "Calls GetBillerAsync");
        Assert.IsTrue(Source.Contains("CreateBillPaymentAsync"), "Calls CreateBillPaymentAsync");
        Assert.IsTrue(Source.Contains("ExecuteBillPaymentAsync"), "Calls ExecuteBillPaymentAsync");
        Assert.IsTrue(Source.Contains("GetBillPaymentStatusAsync"), "Calls GetBillPaymentStatusAsync");
        Assert.IsTrue(Source.Contains("Results.NotFound"), "Returns NotFound for missing resources");
        Assert.IsTrue(Source.Contains("Results.Created"), "Returns Created for new bill payments");
        Assert.IsTrue(Source.Contains("Results.BadRequest"), "Returns BadRequest on failure");
        Assert.IsTrue(Source.Contains("CreateBillPaymentRequest"), "Defines CreateBillPaymentRequest record");
        Assert.IsTrue(Source.Contains("ExecuteBillPaymentRequest"), "Defines ExecuteBillPaymentRequest record");
        await Task.CompletedTask;
    }

    [TestMethod, TestCategory("Rules")]
    [DisplayName("DiditConstants has workflow management constants for KYC workflows")]
    public async Task DiditWorkflowManagementConstantsAsync()
    {
        var Source = ReadSource("PrTask.Domain", "Constants", "DiditConstants.cs");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.WorkflowsPath)),
            "Has WorkflowsPath constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.WorkflowByIdPath)),
            "Has WorkflowByIdPath constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.PropertyWorkflowType)),
            "Has PropertyWorkflowType constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.PropertyWorkflowLabel)),
            "Has PropertyWorkflowLabel constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.PropertyUuid)),
            "Has PropertyUuid constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.WorkflowTypeKyc)),
            "Has WorkflowTypeKyc constant");
        Assert.IsTrue(Source.Contains(nameof(DiditConstants.DefaultWorkflowId)),
            "Has DefaultWorkflowId constant");
        Assert.IsTrue(Source.Contains("/v3/workflows/"),
            "WorkflowsPath uses v3 API");
        Assert.IsTrue(Source.Contains("workflow_type"),
            "PropertyWorkflowType maps to workflow_type");
        Assert.IsTrue(Source.Contains("workflow_label"),
            "PropertyWorkflowLabel maps to workflow_label");
        Assert.IsTrue(Source.Contains("kyc"),
            "WorkflowTypeKyc value is kyc");
        await Task.CompletedTask;
    }
}
