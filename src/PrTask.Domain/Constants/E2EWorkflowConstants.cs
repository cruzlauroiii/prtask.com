namespace PrTask.Domain.Constants;
public static class E2EWorkflowConstants
{
    public const string ScreenshotFormat = "e2e-wf-{0:D2}-{1}.png";
    public const string BeforeLabel = "before";
    public const string AfterLabel = "after";
    public const string SourceFile1Path = "src/Calculator.cs";
    public const string SourceFile1Original = "public class Calculator { public int Add(int A, int B) => A + B; }";
    public const string SourceFile1Modified = "public class Calculator { public int Add(int A, int B) => A + B; public int Subtract(int A, int B) => A - B; }";
    public const string SourceFile2Path = "src/Program.cs";
    public const string SourceFile2Content = "var Calc = new Calculator(); Console.WriteLine(Calc.Add(1, 2));";
    public const string DiffMarker = "diff --git";
    public const string SubtractMarker = "Subtract";
    public const int StepCount = 14;
    public const int MinScreenshotBytes = 10240;
    public const string StepScreenshotFormat = "e2e-step-{0}-{1}.png";
    public const string StepModifyCode = "modify-code";
    public const string StepSubmitPr = "submit-pr";
    public const string StepReviewDiff = "review-diff";
    public const string StepAddComments = "add-comments";
    public const string StepResolveComments = "resolve-comments";
    public const string StepApproveAndPay = "approve-and-pay";
    public const string StepAcceptPayment = "accept-payment";
    public const string ReplyBody = "E2E: Fixed the extraction, good catch.";
    public const string CommentResolvedAssertMsg = "Comment must be resolved";
    public const string DiffContainsEditAssertMsg = "Diff must contain edited code";
    public const string PrCreatedAssertMsg = "PR must be created in DB";
    public const string PrDiffMatchAssertMsg = "PR diff must match expected changes";
    public const string PaymentRespondedAssertMsg = "Maya checkout must respond";
    public const string PaymentRecordAssertMsg = "Payment record must be accessible";
}
