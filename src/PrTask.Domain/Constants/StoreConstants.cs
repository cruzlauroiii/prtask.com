namespace PrTask.Domain.Constants;

public static class StoreConstants
{
    public const string CollectionUsers = "Users";
    public const string CollectionTasks = "Tasks";
    public const string CollectionBoards = "Boards";
    public const string CollectionBoardColumns = "BoardColumns";
    public const string CollectionPullRequests = "PullRequests";
    public const string CollectionPayments = "Payments";
    public const string CollectionSprints = "Sprints";
    public const string CollectionLeaderboard = "Leaderboard";
    public const string CollectionReviewComments = "ReviewComments";
    public const string CollectionRepositories = "Repositories";
    public const string CollectionSourceCode = "SourceCode";
    public const string CollectionInvoices = "Invoices";
    public const string CollectionSubscriptions = "Subscriptions";

    public const string MutationTypeUpsertUser = "UpsertUser";
    public const string MutationTypeUpdateUser = "UpdateUser";
    public const string MutationTypeDeleteUser = "DeleteUser";

    public const string MutationTypeCreateTask = "CreateTask";
    public const string MutationTypeClaimTask = "ClaimTask";
    public const string MutationTypeUpdateTask = "UpdateTask";
    public const string MutationTypeDeleteTask = "DeleteTask";

    public const string MutationTypeCreateBoard = "CreateBoard";
    public const string MutationTypeUpdateBoard = "UpdateBoard";
    public const string MutationTypeDeleteBoard = "DeleteBoard";

    public const string MutationTypeCreateColumn = "CreateColumn";
    public const string MutationTypeUpdateColumn = "UpdateColumn";
    public const string MutationTypeDeleteColumn = "DeleteColumn";

    public const string MutationTypeSubmitPr = "SubmitPr";
    public const string MutationTypeApprovePr = "ApprovePr";
    public const string MutationTypeRejectPr = "RejectPr";
    public const string MutationTypeUpdatePr = "UpdatePr";
    public const string MutationTypeDeletePr = "DeletePr";

    public const string MutationTypeCreatePayment = "CreatePayment";
    public const string MutationTypeUpdatePayment = "UpdatePayment";
    public const string MutationTypeUpdatePaymentStatus = "UpdatePaymentStatus";
    public const string MutationTypeDeletePayment = "DeletePayment";

    public const string MutationTypeCreateSprint = "CreateSprint";
    public const string MutationTypeUpdateSprint = "UpdateSprint";
    public const string MutationTypeDeleteSprint = "DeleteSprint";

    public const string MutationTypeUpdateLeaderboard = "UpdateLeaderboard";

    public const string MutationTypeCreateComment = "CreateComment";
    public const string MutationTypeResolveComment = "ResolveComment";
    public const string MutationTypeDeleteComment = "DeleteComment";

    public const string MutationTypeCreateRepository = "CreateRepository";
    public const string MutationTypeUpdateRepository = "UpdateRepository";
    public const string MutationTypeDeleteRepository = "DeleteRepository";

    public const string MutationTypeStoreSourceCode = "StoreSourceCode";
    public const string MutationTypeStoreModifiedFiles = "StoreModifiedFiles";
    public const string MutationTypeDeleteSourceCode = "DeleteSourceCode";

    public const string MutationTypeCreateInvoice = "CreateInvoice";
    public const string MutationTypeDeleteInvoice = "DeleteInvoice";

    public const string MutationTypeCreateSubscription = "CreateSubscription";
    public const string MutationTypeCancelSubscription = "CancelSubscription";

    public const string MutationTypeCreateKycSession = "CreateKycSession";
    public const string MutationTypeUpdateKycStatus = "UpdateKycStatus";
    public const string MutationTypeDeleteKycSession = "DeleteKycSession";

    public const string MutationTypeIndexVector = "IndexVector";
    public const string MutationTypeDeleteVector = "DeleteVector";

    public const string SourceCodeFilesKeyFormat = "SourceCode_{0}_Files";
    public const string SourceCodeModifiedKeyFormat = "SourceCode_{0}_{1}_Modified";
}
