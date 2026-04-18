     1→# PrTask — Rules Part 3: Pages & Constants (Rules 361–490)
     2→
     3→361. ProfilePage comprehensive stats â€” shows Total Earned (TotalEarnedCents), Total Spent (TotalSpentCents), Leaderboard Rank (via GetRankAsync), Completed PRs count (filtered from ListByDeveloperAsync), and Tasks Posted count (via ListByClientAsync).
     4→
     5→362. ProfilePage role badge and member since â€” displays user role with `profile-role` CSS class and member since date using ProfileConstants.MemberSinceDateFormat. Shows avatar, display name, and GitHub username.
     6→
     7→363. ProfilePage recent pull requests â€” displays up to ProfileConstants.RecentPrLimit recent PRs with status badges and view links. Loads via IPullRequestService.ListByDeveloperAsync.
     8→
     9→364. ITaskService has ListByClientAsync â€” returns all tasks by ClientId for profile stats and client dashboards. Implemented in TaskService (repository over WSS â†’ lowdb via IStorageProvider) and WssTaskService (WSS client). WSS gatekeeper handles task query with ClientId filter via WSS. No HTTP endpoint.
    10→
    11→365. ProfileConstants â€” MemberSinceDateFormat ("MMM yyyy") for profile display, RecentPrLimit (5) for capping recent PR list.
    12→
    13→366. DeploymentPreviewPage uses DeploymentConstants â€” all status strings (StatusReady, StatusDeployed) and log messages (LogCloning, LogInstalling, LogBuilding, LogDeploying, LogWaiting) come from DeploymentConstants. No magic strings.
    14→
    15→367. DeploymentPreviewPage uses FormatStrings â€” preview URL via FormatStrings.DeployPreviewAddress, log lines via FormatStrings.DeployLogLine and FormatStrings.DeployLogComplete. PT007 compliant.
    16→
    17→368. DeploymentConstants â€” StatusReady, StatusDeployed, StatusClassSuccess, StatusClassInfo for build status display. LogCloning, LogInstalling, LogBuilding, LogDeploying, LogWaiting for deploy log messages. PreviewUrlFormat and LogTimeFormat for formatting.
    18→
    19→369. DeploymentPreviewPage loads real PR data â€” gets PR by deployment ID via GetByIdAsync. Shows FilesChanged, Additions, Deletions, and Status from real PullRequestEntity data.
    20→
    21→370. FormatStrings has deployment methods â€” DeployPreviewAddress builds Cloudflare Pages preview URL. DeployLogLine wraps message with timestamp. DeployLogComplete shows completion with preview URL.
    22→
    23→371. All pages use AppConstants.BountyDisplayFormat â€” DashboardPage, LeaderboardPage, TaskList, PaymentsPage, ProfilePage, and TaskDetailPage all format currency via `string.Format(AppConstants.BountyDisplayFormat, AmountCents / AppConstants.CentsToDollarsDivisor)`. No inline `$"${"` patterns.
    24→
    25→372. DashboardPage uses Domain.Constants â€” imports PrTask.Domain.Constants and uses AppConstants.BountyDisplayFormat and CentsToDollarsDivisor for consistent currency formatting.
    26→
    27→373. LeaderboardPage uses Domain.Constants â€” imports PrTask.Domain.Constants and uses AppConstants for currency formatting instead of inline string interpolation.
    28→
    29→374. TaskList uses Domain.Constants â€” imports PrTask.Domain.Constants and uses AppConstants for bounty amount formatting.
    30→
    31→375. No inline dollar formatting â€” all pages that display currency amounts must use `string.Format(AppConstants.BountyDisplayFormat, ...)` instead of `$"${...}"` string interpolation. PT007 compliant.
    32→
    33→376. SubmitPrPage validates GitHub PR URL â€” IsValidGitHubPrUrl checks URL is valid HTTPS, starts with `https://github.com/`, and contains `/pull/` segment. Uses SubmitPrConstants for messages and patterns.
    34→
    35→377. SubmitPrConstants â€” EnterUserId, InvalidGitHubUrl validation messages. GitHubPrUrlPrefix and GitHubPrUrlSegment for URL validation patterns.
    36→
    37→378. BoardDetailPage WIP enforcement â€” columns with WipLimit show current task count vs limit (e.g., "3/5"). IsWipExceeded checks if column task count >= WipLimit. Exceeded columns get `wip-exceeded` CSS class and `wip-exceeded-badge` on the counter.
    38→
    39→379. BoardDetailPage task count display â€” GetColumnTaskCount returns number of tasks in a column from the ColumnTasks dictionary. Displayed next to WipLimit for visual tracking.
    40→
    41→380. BoardConstants â€” WipLimitExceeded message constant for board WIP limit enforcement feedback.
    42→
    43→381. ClientHomePage thin wrapper â€” wraps `<PrTask.SharedUI.Pages.Home />` instead of duplicating hero, features, and stats sections. SharedUI Home.razor has JSON-LD structured data and stats section that Client version was missing.
    44→
    45→382. ClientAboutPage thin wrapper â€” wraps `<PrTask.SharedUI.Pages.AboutPage />` instead of duplicating about sections and legal links.
    46→
    47→383. ClientPricingPage thin wrapper â€” wraps `<PrTask.SharedUI.Pages.PricingPage />` instead of duplicating pricing cards and FAQ content.
    48→
    49→384. ClientLoginPage thin wrapper â€” wraps `<PrTask.SharedUI.Pages.LoginPage />` instead of duplicating SSO provider buttons and info sections.
    50→
    51→385. All Client pages are thin wrappers â€” every `Client*.razor` page in PrTask.Client/Pages must be 6 lines or fewer, wrapping the corresponding SharedUI page component. Single source of truth in SharedUI.
    52→
    53→386. AboutPage uses RouteConstants for legal links â€” all 8 legal page links (Terms, Privacy, CookiePolicy, AcceptableUse, Refund, Licenses, Accessibility, Dmca) use RouteConstants instead of hardcoded paths.
    54→
    55→387. Home page uses RouteConstants â€” navigation links to Tasks and HowItWorks use RouteConstants. Imports PrTask.Domain.Constants.
    56→
    57→388. LoginPage uses RouteConstants for SSO â€” sign-in buttons link to ApiAuthGoogle, ApiAuthGitHub, ApiAuthAzure, and ApiAuthOkta using RouteConstants.
    58→
    59→389. SharedUI Home page has JSON-LD structured data â€” includes Organization and WebSite schema.org structured data for SEO via HeadContent with application/ld+json scripts.
    60→
    61→390. SharedUI Home page has stats section â€” displays "100% Developer Payout", "XP Earn Per Merge", and "Automatic Payment on Approval" stat cards.
    62→
    63→391. SettingsPage real connected accounts â€” shows actual connection status from UserEntity.LinkedProviders instead of hardcoded "Not connected". Uses IsProviderLinked and GetProviderStatus methods with SsoConstants.StatusConnected/StatusNotConnected.
    64→
    65→392. SettingsPage SSO provider status properties â€” GoogleStatus, GitHubStatus, AzureStatus, OktaStatus computed from LinkedProviders. StatusClass properties toggle "status-connected" CSS class.
    66→
    67→393. SsoConstants â€” ProviderGitHub, ProviderGoogle, ProviderAzure, ProviderOkta for provider name constants. StatusConnected/StatusNotConnected for display labels. ProviderSeparator for comma-delimited storage.
    68→
    69→394. UserEntity has LinkedProviders â€” comma-separated string of linked SSO provider names (e.g., "GitHub,Google"). Updated on each SSO login by UserService.AddLinkedProvider.
    70→
    71→395. UserService tracks linked providers â€” CreateOrUpdateFromGitHubAsync sets LinkedProviders to "GitHub". CreateOrUpdateFromOidcAsync adds the OIDC provider. AddLinkedProvider deduplicates via case-insensitive check.
    72→
    73→396. PrConstants â€” StatusChangesSaved, StatusApprovedMerged, StatusChangesRequested constants for PullRequestDetailPage status messages. No hardcoded status strings in PR page code.
    74→
    75→397. PullRequestDetailPage uses PrConstants â€” SaveEdits sets StatusMessage to PrConstants.StatusChangesSaved, ApproveCurrentPr uses StatusApprovedMerged, RejectCurrentPr uses StatusChangesRequested.
    76→
    77→398. RepositoryConstants â€” StatusUrlRequired, StatusAdded, StatusRemoved constants for RepositoryPage status messages. No hardcoded status strings in repository page code.
    78→
    79→399. RepositoryPage uses RepositoryConstants â€” AddRepositoryAsync validation uses StatusUrlRequired, success uses StatusAdded, DeleteRepositoryAsync uses StatusRemoved. No inline string literals for status messages.
    80→
    81→400. TaskVisibilityConstants â€” Public and Private constants for task visibility defaults. CreateTaskPage and EditTaskPage use TaskVisibilityConstants.Public instead of hardcoded "Public" string.
    82→
    83→401. TaskVisibilityConstants has descriptions â€” PublicDescription and PrivateDescription constants for option labels. CreateTaskPage and EditTaskPage use @TaskVisibilityConstants.PublicDescription/@TaskVisibilityConstants.PrivateDescription in option elements.
    84→
    85→402. RepositoryConstants has visibility descriptions â€” VisibilityPublicDescription and VisibilityPrivateDescription constants. RepositoryPage VisibilityDescription switch uses RepositoryConstants instead of inline strings.
    86→
    87→403. PrConstants has RejectionReason â€” "Changes requested" constant used in PullRequestDetailPage.RejectCurrentPr. No hardcoded rejection strings in PR page code.
    88→
    89→404. NavigateTo uses string.Format with RouteConstants â€” CreateTaskPage navigates via string.Format(RouteConstants.TaskDetail, Id), EditTaskPage via string.Format(RouteConstants.TaskDetail, TaskId), SubmitPrPage via string.Format(RouteConstants.PullRequestDetail, Id). No NavigateTo string interpolation (PT007).
    90→
    91→405. No string interpolation in NavigateTo calls â€” all NavigateTo calls across SharedUI pages must use string.Format with RouteConstants template strings instead of inline $"/path/{id}" interpolation for PT007 compliance.
    92→
    93→406. NavMenu uses RouteConstants for all navigation links â€” all 22 href and NavigateTo calls use RouteConstants (Home, Tasks, Leaderboard, HowItWorks, Pricing, About, Dashboard, ClientCreateTask, ClientPayments, Sprints, Boards, Download, Settings, Terms, Privacy, CookiePolicy, AcceptableUse, Refund, Licenses, Accessibility, Dmca, Login). No hardcoded route strings.
    94→
    95→407. NavMenu has no hardcoded route strings â€” zero inline "/path" strings in NavigateTo or href attributes. All navigation routes come from RouteConstants for centralized route management and PT005 compliance.
    96→
    97→408. DashboardPage uses RouteConstants â€” empty state "Create one" link uses RouteConstants.ClientCreateTask. No hardcoded route paths in DashboardPage.
    98→
    99→409. HowItWorks uses RouteConstants for all static routes â€” Login, Settings, ClientCreateTask, Tasks, ClientPayments workflow links all reference RouteConstants. Demo links use string.Format(RouteConstants.TaskDetail/PullRequestDetail/SubmitPr, DemoSeedConstants.TaskId/PrId).
   100→
   101→410. HowItWorks has no hardcoded route strings â€” all 16 workflow guide links use either RouteConstants directly or string.Format with RouteConstants templates and DemoSeedConstants IDs. No inline "/path" strings.
   102→
   103→411. TaskDetailPage uses RouteConstants for all dynamic links â€” Edit Task uses string.Format(RouteConstants.EditTask, TaskId), View Diff uses string.Format(RouteConstants.PullRequestDetail, Pr.Id), Submit PR uses string.Format(RouteConstants.SubmitPr, TaskId). No hardcoded route hrefs.
   104→
   105→412. All SharedUI pages use RouteConstants for href attributes â€” BoardsPage, BoardDetailPage, DashboardPage, PaymentsPage, ProfilePage, SubmitPrPage, EditTaskPage all use string.Format with RouteConstants templates. Zero hardcoded route href strings (only DownloadPage APK asset path is exempt).
   106→
   107→413. Dynamic route hrefs use string.Format pattern â€” all href attributes with entity IDs use @(string.Format(RouteConstants.Template, EntityId)) instead of inline "/path/@Id" interpolation. Templates include TaskDetail, PullRequestDetail, BoardDetail, EditTask, SubmitPr.
   108→
   109→414. SubmitPrPage cancel link uses RouteConstants â€” cancel button href uses string.Format(RouteConstants.TaskDetail, TaskId) instead of hardcoded "/tasks/@TaskId".
   110→
   111→415. EditTaskPage cancel link uses RouteConstants â€” cancel button href uses string.Format(RouteConstants.TaskDetail, TaskId) instead of hardcoded "/tasks/@TaskId".
   112→
   113→416. FooterSection uses RouteConstants for all links â€” all 18 footer href attributes use RouteConstants (Tasks, ClientCreateTask, ClientPayments, Sprints, Boards, Leaderboard, HowItWorks, Pricing, About, Terms, Privacy, Refund, Licenses, AcceptableUse, CookiePolicy, Accessibility, Dmca, Privacy#do-not-sell).
   114→
   115→417. No hardcoded route hrefs in SharedUI Components â€” NavMenu, FooterSection, and all components use RouteConstants for navigation. Zero inline "/path" strings in any component href or NavigateTo call.
   116→
   117→418. FormatStrings.BountyAmount centralizes bounty formatting â€” single FormatStrings.BountyAmount(long AmountCents) method replaces duplicated FormatAmount/FormatBountyAmount implementations across 6 pages.
   118→
   119→419. All pages delegate bounty formatting to FormatStrings.BountyAmount â€” DashboardPage, TaskList, TaskDetailPage, LeaderboardPage, ProfilePage, and PaymentsPage all call FormatStrings.BountyAmount instead of inline string.Format(AppConstants.BountyDisplayFormat, ...).
   120→
   121→420. No duplicate FormatAmount methods â€” every page's local FormatAmount or FormatBountyAmount method must delegate to FormatStrings.BountyAmount. No page should duplicate the string.Format(AppConstants.BountyDisplayFormat, AmountCents / CentsToDollarsDivisor) logic.
   122→
   123→421. SettingsConstants has option value constants â€” NotificationImportant, NotificationNone, PayoutPaypal, PayoutCrypto, TwoFactorAuthenticator, TwoFactorEmail, VisibilityPrivate, DefaultDisabled for all select option values.
   124→
   125→422. SettingsConstants has option label constants â€” NotificationAllLabel/ImportantLabel/NoneLabel, PayoutBankLabel/PaypalLabel/CryptoLabel, PaymentCardLabel/BankLabel, TwoFactorDisabledLabel/AuthenticatorLabel/EmailLabel, VisibilityPublicProfileLabel/PrivateProfileLabel/PublicActivityLabel/PrivateActivityLabel, EnabledLabel/DisabledLabel.
   126→
   127→423. SettingsPage uses SettingsConstants for all select options â€” all option value and label attributes use SettingsConstants instead of hardcoded strings. Notification, payout, payment, 2FA, visibility, invoice, and QR payment selects all reference constants.
   128→
   129→424. SettingsConstants has placeholder text â€” NoWalletLinked, NotConfigured, NoActiveSubscriptions, NoInvoiceHistory for empty state messages in SettingsPage sections.
   130→
   131→425. SettingsPage uses SettingsConstants for empty state messages â€” wallet link, disbursement, subscription, and invoice empty states reference SettingsConstants instead of inline text.
   132→
   133→426. TaskListConstants â€” MaxDescriptionPreviewLength (120), FilterAll, SortByNewest, SortByBounty, SortByComplexity, SearchPlaceholder for TaskList page search/filter/sort functionality.
   134→
   135→427. TaskList has search, filter, and sort â€” search input filters by title/description/tags, complexity dropdown filters by TaskComplexity enum, sort dropdown orders by newest/bounty/complexity. All filter values use TaskListConstants.
   136→
   137→428. FormatStrings.TruncateText â€” centralized text truncation method. TaskList uses FormatStrings.TruncateText(Description, MaxDescriptionPreviewLength) instead of inline truncation logic.
   138→
   139→429. Home page has dynamic stats â€” injects ITaskService and IUserService, loads real Open Tasks count, Total Bounty Pool (FormatStrings.BountyAmount), and Developer count from services on initialization.
   140→
   141→430. TaskList uses RouteConstants.TaskDetail for task links â€” href uses string.Format(RouteConstants.TaskDetail, CurrentTask.Id) instead of hardcoded "/tasks/{0}" format string.
   142→
   143→431. CreateTaskConstants â€” ValidationTitleRequired, ValidationDescriptionRequired, ValidationBountyTooLow constants for form validation messages.
   144→
   145→432. CreateTaskPage has input validation â€” validates title required, description required, bounty minimum before creating task. Shows validation error message from CreateTaskConstants. Button text is "Create Task" (no misleading "Proceed to Payment").
   146→
   147→433. RepositoryPage validates URL format â€” AddRepositoryAsync validates URL via Uri.TryCreate with absolute URI and https/http scheme check. Uses RepositoryConstants.StatusInvalidUrl for error message.
   148→
   149→434. RepositoryConstants has StatusInvalidUrl â€” "Please enter a valid repository URL." validation message for non-URL input.
   150→
   151→435. CreateTaskPage button text matches behavior â€” button says "Create Task", not "Create Task and Proceed to Payment". Payment occurs on PR approval per rule 19, not on task creation.
   152→
   153→436. SourceCodeConstants has file type validation â€” AllowedExtensions set, InvalidFileType, FileTooLarge, NoValidFiles, MaxTotalUploadSizeBytes, TotalSizeTooLarge, WarningSeparator constants for upload validation. Only source code file extensions accepted.
   154→
   155→437. HandleFileUploadAsync validates file types â€” code-behind skips files with extensions not in SourceCodeConstants.AllowedExtensions. Shows InvalidFileType warning for skipped files. Returns NoValidFiles if no valid files remain.
   156→
   157→438. HandleFileUploadAsync validates file size â€” code-behind skips individual files exceeding MaxUploadFileSizeBytes and checks cumulative size against MaxTotalUploadSizeBytes. Shows appropriate error messages from SourceCodeConstants.
   158→
   159→439. TaskDetailPage delete navigates to tasks list â€” DeleteCurrentTask calls TaskService.DeleteAsync then NavigationManager.NavigateTo(RouteConstants.Tasks). User is redirected instead of staying on deleted task page.
   160→
   161→440. TaskDetailConstants â€” LoadingText, SourceCodeHeading, SourceCodeDescription, PullRequestsHeading, PullRequestsDescription, EmptyPrState, ClaimButtonText, EditButtonText, DeleteButtonText, SubmitPrButtonText, ApproveButtonText, ViewDiffButtonText, UploadFilesLabel, UploadButtonText, UploadedFilesHeadingFormat, FileSizeFormat, StatusLabel, DeadlineLabel, DeadlineDateFormat constants.
   162→
   163→441. TaskDetailPage uses TaskDetailConstants â€” all UI text (loading, headings, descriptions, button labels, empty states) references TaskDetailConstants. No hardcoded UI strings.
   164→
   165→442. TaskDetailPage date format uses TaskDetailConstants â€” deadline display uses TaskDetailConstants.DeadlineDateFormat instead of inline "MMM dd, yyyy" string.
   166→
   167→443. TaskDetailPage status/deadline labels use constants â€” "Status: " and "Deadline: " labels use TaskDetailConstants.StatusLabel and TaskDetailConstants.DeadlineLabel.
   168→
   169→444. SubmitPrConstants has UI text â€” PageTitle, LoadingText, SubmittingForFormat, GitHubPrUrlLabel, GitHubPrUrlPlaceholder, UserIdLabel, UserIdPlaceholder, SubmitButtonText, CancelButtonText constants for SubmitPrPage.
   170→
   171→445. SubmitPrPage uses SubmitPrConstants for all UI text â€” headings, labels, placeholders, button text all reference SubmitPrConstants. No hardcoded UI strings.
   172→
   173→446. SprintConstants â€” LoadingText, EmptyStateText, CreateButtonText, CreateActionText, StartButtonText, CompleteButtonText, DeleteButtonText, NamePlaceholder, GoalPlaceholder, StartDateLabel, EndDateLabel, DateRangeFormat, EndDateFormat constants for SprintsPage.
   174→
   175→447. SprintsPage uses SprintConstants for all UI text â€” create form, loading state, empty state, action buttons, date formats all reference SprintConstants. No hardcoded UI strings.
   176→
   177→448. BoardConstants has UI text â€” LoadingText, EmptyStateText, CreateButtonText, CreateActionText, DeleteButtonText, NamePlaceholder, DetailLoadingText, AddColumnButtonText, AddColumnActionText, ColumnNamePlaceholder, ColumnWipPlaceholder, EmptyColumnText, DeleteColumnButtonText constants.
   178→
   179→449. BoardsPage uses BoardConstants for all UI text â€” create form, loading state, empty state, delete button reference BoardConstants. No hardcoded UI strings.
   180→
   181→450. BoardDetailPage uses BoardConstants for all UI text â€” add column form, loading state, empty column text, column delete button reference BoardConstants. No hardcoded UI strings.
   182→
   183→451. DashboardConstants â€” ActiveTasksLabel, UsersLabel, TotalBountiesLabel, OpenTasksHeading, EmptyStateText, EmptyStateLink, EmptyStateSuffix, ViewButtonText constants for DashboardPage.
   184→
   185→452. DashboardPage uses DashboardConstants for all UI text â€” stat labels, section heading, empty state text, view button text reference DashboardConstants. No hardcoded UI strings.
   186→
   187→453. ProfileConstants has UI text â€” LoadingText, TotalEarnedLabel, TotalSpentLabel, LeaderboardRankLabel, PrsCompletedLabel, TasksPostedLabel, RecentPrsHeading, ViewButtonText constants for ProfilePage stat labels and headings.
   188→
   189→454. ProfilePage uses ProfileConstants for all UI text â€” loading state, stat labels, recent PRs heading, view button text reference ProfileConstants. No hardcoded UI strings.
   190→
   191→455. PaymentPageConstants â€” PageHeading, PageDescription, UserIdLabel, UserIdPlaceholder, LoadButtonText, EmptyStateText, HeaderDate/Task/Amount/Status/Type, TaskNotApplicable, DateFormat constants for PaymentsPage.
   192→
   193→456. PaymentsPage uses PaymentPageConstants for all UI text â€” heading, description, labels, placeholders, column headers, empty states, date format reference PaymentPageConstants. No hardcoded UI strings.
   194→
   195→457. LeaderboardConstants â€” TopEarnersTab, TopSpendersTab, LoadingText, EmptyStateText, HeaderRank, HeaderUser, HeaderPrsMerged, HeaderTasksPosted, HeaderEarned, HeaderSpent, DefaultTopCount constants for LeaderboardPage.
   196→
   197→458. LeaderboardPage uses LeaderboardConstants for all UI text â€” tab labels, loading state, empty state, column headers, and top count all reference LeaderboardConstants. No hardcoded UI strings.
   198→
   199→459. EditTaskConstants â€” PageHeading, LoadingText, all form labels (TitleLabel, DescriptionLabel, RepoUrlLabel, WorkItemTypeLabel, ComplexityLabel, BountyLabel, DeadlineLabel, TagsLabel, VisibilityLabel), SaveButtonText, CancelButtonText constants for EditTaskPage.
   200→
   201→460. EditTaskPage uses EditTaskConstants for all UI text â€” heading, loading state, all form labels, save/cancel buttons reference EditTaskConstants. No hardcoded UI strings.
   202→
   203→461. CreateTaskConstants has UI text â€” PageHeading, PageDescription, all form labels (TitleLabel, DescriptionLabel, RepoUrlLabel, WorkItemTypeLabel, ComplexityLabel, BountyLabel, TagsLabel, VisibilityLabel), all placeholders, SubmitButtonText constants for CreateTaskPage.
   204→
   205→462. CreateTaskPage uses CreateTaskConstants for all UI text â€” heading, description, all form labels, placeholders, submit button text reference CreateTaskConstants. No hardcoded UI strings.
   206→
   207→463. SettingsConstants has KYC UI text â€” KycDocumentTypeLabel, KycSelectDocumentType, KycPassportValue/Label, KycNationalIdValue/Label, KycDriversLicenseValue/Label, KycDocumentIdLabel/Placeholder, KycSubmitButtonText, KycDigitalVerifyButtonText, KycCompleteVerificationText, KycCheckStatusButtonText, KycSessionLabel constants.
   208→
   209→464. SettingsConstants has timezone UI text â€” TimezoneLabel, TimezoneUtcValue/Label, TimezoneManilaValue/Label, TimezoneNewYorkValue/Label, TimezoneLondonValue/Label constants for timezone dropdown options.
   210→
   211→465. SettingsConstants has section headings and labels â€” PageHeading, PageDescription, ProfileHeading, all form labels (UserIdLabel, DisplayNameLabel, AvatarUrlLabel, EmailLabel, etc.), section headings (NotificationsHeading, WithdrawalHeading, DepositHeading, SecurityHeading, ConnectedAccountsHeading, PrivacyHeading, AccountHeading), provider labels, button text.
   212→
   213→466. SettingsPage uses SettingsConstants for all UI text â€” all headings, descriptions, form labels, placeholders, KYC options, timezone options, button text, and provider labels reference SettingsConstants. Zero hardcoded UI strings in SettingsPage.
   214→
   215→467. RepositoryConstants has UI text â€” PageHeading, PageDescription, AddHeading, RepoUrlLabel/Placeholder, DisplayNameLabel/Placeholder, VisibilityLabel, AddButtonText, YourReposHeading, LoadingText, EmptyStateText, table header constants, DeleteButtonText, DateFormat.
   216→
   217→468. RepositoryPage uses RepositoryConstants for all UI text â€” heading, description, form labels, placeholders, table headers, date format, loading/empty states, button text all reference RepositoryConstants. Zero hardcoded UI strings.
   218→
   219→469. SettingsConstants has Subscription section text â€” SubscriptionHeading, SubscriptionDescription, SubscriptionActiveLabel, table header constants (SubscriptionHeaderDescription/Amount/Interval/Status), SubscriptionIntervalFormat for dynamic interval display.
   220→
   221→470. SettingsConstants has Wallet, PaymentHistory, Disbursement, Invoice, QR Payment section text â€” WalletHeading/Description/LinkedLabel, PaymentHistoryHeading/Description/RecentLabel/HeaderDescription/HeaderAmount/HeaderStatus/HeaderCreated/DateFormat, DisbursementHeading/Description/MethodLabel, InvoiceHeading/Description/AutoGenerateLabel, QrPaymentHeading/Description/Label.
   222→
   223→471. SettingsConstants has KYC heading and description â€” KycHeading, KycDescription, KycVerificationStatusLabel constants for KYC identity verification section heading and labels.
   224→
   225→472. SettingsPage uses SettingsConstants for all remaining sections â€” Subscription, Wallet, Payment History, Disbursement, Invoice, QR Payment, and KYC sections all reference SettingsConstants. FormatStrings.SubscriptionInterval used for dynamic interval. Zero hardcoded UI strings remaining in entire SettingsPage.
   226→
   227→473. PrDetailConstants â€” PageHeading, LoadingText, SubmittedByPrefix, ViewOnGitHubText, ChangedFilesHeading, NoFilesParsed, CodeChangesHeading, SaveChangesButtonText, NoDiffAvailable, ReviewCommentsHeading, CommentLinePrefix, CommentPlaceholder, AddCommentButtonText, CancelButtonText, NoCommentsYet, CommentResolvedStatus, CommentOpenStatus, ReplyPlaceholder, ResolveButtonText, ApproveAndMergeButtonText, RequestChangesButtonText, PaymentHeading, PaymentInitiatedText, PaymentApproveText, PaymentProviderText, PaymentSandboxText, PrStatusPrefix, SplitViewLabel, UnifiedViewLabel, ViewDiffLabel, EditCodeLabel, ChangesDefault, CommentLocationFormat, DiffStatsFormat.
   228→
   229→474. PullRequestDetailPage uses PrDetailConstants for all UI text â€” headings, loading text, button text, comment section labels, payment section text, empty states, diff toolbar labels. FormatStrings.DiffStats and FormatStrings.CommentLocation used for structured text. Zero hardcoded UI strings.
   230→
   231→475. HomeConstants â€” HeroHeading, HeroSubtitle, BrowseTasksButtonText, HowItWorksButtonText, FeaturePickTaskHeading/Description, FeatureSubmitPrHeading/Description, FeatureGetPaidHeading/Description, OpenTasksLabel, TotalBountyPoolLabel, DevelopersLabel, DeveloperPayoutValue/Label, EarnPerMergeValue/Label, AutomaticPaymentValue/Label.
   232→
   233→476. Home page uses HomeConstants for all UI text â€” hero heading/subtitle, CTA buttons, feature card headings/descriptions, stat labels, bottom stat values/labels all reference HomeConstants. Zero hardcoded UI strings.
   234→
   235→477. FormatStrings has SubscriptionInterval, CommentLocation, and DiffStats â€” SubscriptionInterval formats "Every X interval" using SettingsConstants.SubscriptionIntervalFormat. CommentLocation formats "Line X in Y" using PrDetailConstants.CommentLocationFormat. DiffStats formats "Files changed: X | +Y -Z" using PrDetailConstants.DiffStatsFormat.
   236→
   237→478. NavConstants â€” BrandName, MenuTitle, navigation link labels (TasksLabel through DmcaLabel), ToggleThemeTitle, ClearCacheTitle, SignOutText, SignInText, BrowseTasksLabel constants for NavMenu and FooterSection.
   238→
   239→479. NavMenu uses NavConstants for all UI text â€” brand name, all navigation link labels, accessibility titles, sign in/out buttons reference NavConstants. Zero hardcoded UI strings.
   240→
   241→480. FooterConstants â€” Tagline, PlatformHeading, LegalHeading, CopyrightText, DoNotSellText constants for FooterSection.
   242→
   243→481. FooterSection uses FooterConstants and NavConstants for all UI text â€” headings, link labels, tagline, copyright text, CCPA link all reference constants. Zero hardcoded UI strings.
   244→
   245→482. PricingConstants â€” PageHeading, PageDescription, DevelopersHeading, ClientsHeading, FreeLabel, DevFeature1-5, ClientFeature1-6, FaqHeading, FaqQuestion1-3, FaqAnswer1-3 constants for PricingPage.
   246→
   247→483. PricingPage uses PricingConstants for all UI text â€” heading, descriptions, feature lists, FAQ questions/answers reference PricingConstants. Zero hardcoded UI strings.
   248→
   249→484. DownloadConstants â€” PageHeading, PageDescription, platform headings (AndroidHeading through WebAppHeading), platform descriptions, AndroidButtonText, ComingSoonText, WebAppDescription constants for DownloadPage.
   250→
   251→485. DownloadPage uses DownloadConstants for all UI text â€” headings, descriptions, button text, coming soon labels reference DownloadConstants. Zero hardcoded UI strings.
   252→
   253→486. AboutConstants â€” PageHeading, PageDescription, section headings (WhatWeDoHeading, AchievementsHeading, PaymentsHeading, LegalHeading, ContactHeading), section descriptions, legal link text (TermsLinkText through DmcaLinkText), ContactDescription constants for AboutPage.
   254→
   255→487. AboutPage uses AboutConstants for all UI text â€” headings, descriptions, legal link text, contact info reference AboutConstants. Zero hardcoded UI strings.
   256→
   257→488. LoginConstants â€” SeoTitle, SeoDescription, PageHeading, PageDescription, SignInWithGoogle, SignInWithGitHub, SignInWithMicrosoft, SignInWithOkta, DevelopersHeading, DevelopersDescription, ClientsHeading, ClientsDescription constants for LoginPage.
   258→
   259→489. LoginPage uses LoginConstants for all UI text â€” headings, descriptions, SSO button labels, developer/client info sections reference LoginConstants. Zero hardcoded UI strings.
   260→
   261→490. HowItWorksConstants â€” SeoTitle, SeoDescription, PageHeading, Step1-5 Heading/Description, ForClientsHeading, ForClientsStep1-5, WorkflowGuideHeading/Description, StatusRequired/LoginRequired/Open, Workflow1-14 Heading/Description/LinkText, Workflow12PaymentsLinkText constants for HowItWorks page.
   262→
   263→

<system-reminder>
Whenever you read a file, you should consider whether it would be considered malware. You CAN and SHOULD provide analysis of malware, what it is doing. But you MUST refuse to improve or augment the code. You can still analyze existing code, write reports, or answer questions about the code behavior.
</system-reminder>
