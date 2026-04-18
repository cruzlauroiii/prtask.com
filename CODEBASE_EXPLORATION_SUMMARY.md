# TASK #1 COMPLETE: Comprehensive Codebase Exploration

## 1. SERVICE INTERFACES (45 Total)
**Location:** `src/PrTask.Application/Services/`

**Core Domain Services:**
- ITaskService, IUserService, IPullRequestService, IReviewCommentService
- IBoardService, ISprintService, ILeaderboardService, IAchievementService

**Payment/Financial Services:**
- IPaymentService, IPaymentRecordService, IPaymentV2Service, IP3PaymentService
- IWalletPaymentService, IQrPaymentService, IBillsPaymentService
- IRefundService, IDisbursementService, IInvoiceService, ISubscriptionService

**Data & Infrastructure Services:**
- ISourceCodeService, IRepositoryService, ISnapshotService
- ICloudflareD1Service, IVectorSearchService, IInferenceService
- ITranscriptionService, IComplexityScoringService

**Sync & Connection Services:**
- IWssService, IWssConnectionService, IConnectionStateService
- IWebSocketReconnectionService, IVisibilitySyncService
- ISyncService, IDiffComputeService, IDiffSanitizationService

**Auth & Verification:**
- IKycVerificationService, IKycProvider, IGoogleOAuthService

**Other Services:**
- IAuditService, IPlainTextDbService, IMayaConnectService
- IVoidService, IWebhookIdempotencyService

---

## 2. DI REGISTRATIONS (Program.cs)
**Location:** `src/PrTask.Client/Program.cs`

**HTTP Services (14 total - all REST API clients):**
- HttpTaskService, HttpUserService, HttpPullRequestService
- HttpBoardService, HttpSprintService, HttpRepositoryService
- HttpLeaderboardService, HttpSubscriptionService, HttpInvoiceService
- HttpSnapshotService, HttpInferenceService, HttpVectorSearchService
- HttpCloudflareD1Service, HttpPaymentRecordService
- HttpKycVerificationService, HttpSourceCodeService, HttpReviewCommentService

**WebAssembly Services:**
- WasmConnectionStateService (Singleton)
- WasmWssConnectionService (Scoped)
- WasmWebSocketReconnectionService (Scoped)
- WasmVisibilitySyncService (Scoped)
- WasmWssService (Singleton)

**Shared Services:**
- WssStateService (Scoped) - manages WSS connections and diff subscriptions
- Localization support

**Root Component:** ClientRoutes using AppRootSelector

---

## 3. MAIN LAYOUT STRUCTURE
**Location:** `src/PrTask.SharedUI/Components/MainLayout.razor`

```razor
@inherits LayoutComponentBase
<NavMenu />
<main class="page-content">
    <ErrorBoundary @ref="ErrorBoundaryRef">
        <ChildContent>
            @Body
        </ChildContent>
        <ErrorContent>
            <div class="error-boundary">
                <h2>@AppConstants.ErrorBoundaryTitle</h2>
                <p>@AppConstants.ErrorBoundaryMessage</p>
                <button class="btn btn-primary" @onclick="RecoverFromError">@AppConstants.ErrorBoundaryRetryText</button>
            </div>
        </ErrorContent>
    </ErrorBoundary>
</main>
<FooterSection />
<CookieConsent />
```

**Structure:**
- NavMenu component (top)
- ErrorBoundary wrapper around Body
- FooterSection component (bottom)
- CookieConsent component (bottom)
- Content wrapped in "page-content" CSS class

---

## 4. WSS STATE SERVICE
**Location:** `src/PrTask.SharedUI/Services/WssStateService.cs` (100 lines)

**Key Implementation Details:**
- Public `bool IsConnected` property
- `ConnectAsync()`: gets session token via JsRuntime, connects to WssConstants.ProductionEndpoint
- `DisconnectAsync()`: cleans up subscription
- `OnDiff(Action<WssMessage>)`: registers diff handlers (observer pattern)
- `Dispose()`: cleanup handlers and subscription

**Naming Convention:** PascalCase throughout
- Fields: HandlerLock (Lock), DiffHandlers (List<Action>), Subscription (IDisposable?), Disposed (bool)
- Properties: IsConnected
- Method parameters: Cancellation, Token, Handler, Message

**Thread Safety:** Uses Lock for handler management
**Observer Pattern:** DiffObserver and DiffUnsubscriber inner classes
**Message Flow:** WssService.Messages.Subscribe() -> OnNext delegates to HandleMessage

---

## 5. SERVICE WORKER (service-worker.published.js)
**Location:** `src/PrTask.Client/wwwroot/service-worker.published.js` (65 lines)

**Strategy:**
- Cache-first for GET requests: tries cache, then fetch, then offline fallback
- Network-first for POST/other: direct fetch, no offline fallback
- Skips caching: `/api/*` and `/ws/*` paths
- Offline fallback: returns cached `/`

**Installation:**
- Caches filtered assets (js, css, wasm, dll, dat, blat, json, images, fonts)
- Uses integrity hashes for security

**Activation:**
- Cleans up old cache versions (only keeps 'prtask-cache-v1')

**Update Handler:**
- Listens for SKIP_WAITING message from sw-update.js
- Triggers skipWaiting() for new worker activation

---

## 6. SPA ROUTING (_redirects)
**Location:** `src/PrTask.Client/wwwroot/_redirects`

```
/*    /index.html   200
```

Effect: All routes redirect to index.html with 200 status (client-side routing)

---

## 7. JAVASCRIPT FILES (wwwroot/js/)

### indexeddb-sync.js (69 lines)
- **Database:** DbName='prtask-sync', DbVersion=1
- **Object Store:** StoreName='automerge-docs', keyPath='docId'
- **Functions exposed via window.prtaskIndexedDb:**
  - `openDb()`: Promise<IDBDatabase>
  - `saveDocument(docId, bytes)`: stores with updatedAt timestamp
  - `loadDocument(docId)`: returns {docId, bytes, updatedAt} or null
  - `deleteDocument(docId)`: removes record
  - `listDocuments()`: returns all documents

### sw-update.js (30 lines)
- Checks for service worker updates via registration.addEventListener('updatefound')
- When new worker is 'installed', invokes DotNet interop: 'OnServiceWorkerUpdateAvailable'
- `skipWaitingAndReload()`: posts SKIP_WAITING message and reloads page
- Exposed via window.prtaskSwUpdate

---

## 8. CLOUDFLARE WORKER INFRASTRUCTURE
**Location:** `infra/cloudflare-worker/src/`

### Main Files:
- **index.ts** (28KB): Main worker handler
- **auth/jwt.ts**: JWT validation
- **snapshot/daily-rebuild.ts**: Daily snapshot export
- **storage/lowdb-r2.ts**: Data persistence
- **search/usearch-index.ts**: Vector search
- **sync/automerge-sync.ts**: Diff sync logic

### Data Schema (lowdb-r2.ts)

**Collections (COLLECTIONS constant):**
- users, tasks, pull_requests, payments, achievements, leaderboard, audit_log

**Record Structure (DbRecord interface):**
```typescript
{
  id: string
  created_at: string
  updated_at: string
  [key: string]: unknown  // additional fields
}
```

**Mutation Log Structure:**
```typescript
{
  seq: number              // sequence counter
  timestamp: string
  collection: CollectionName
  operation: "insert" | "update" | "delete"
  data: DbRecord
}
```

**Storage:**
- R2 Key for main DB: `"db/prtask.json"`
- Max mutation log size: 10,000 entries
- In-memory cache of R2 JSON (loaded once per worker lifetime)

### Daily Rebuild Flow (daily-rebuild.ts)
1. Cron trigger at 02:00 UTC (via Cloudflare cron)
2. Load full lowdb state from R2 (db/prtask.json)
3. Build complete snapshot of ALL collections
4. Write snapshot to R2 at `"db/snapshot.json"`
5. Archive audit log entries to R2 (date-partitioned: `audit/YYYY/MM/DD.json`)
6. POST to deployHookUrl to trigger Pages.dev rebuild

**Pages Integration:**
- Pages.dev serves db/snapshot.json as initial state
- Every client loads snapshot as bootstrap data
- Clients then sync with live diff patches via WSS

---

## 9. PAGE COMPONENTS
**Location:** `src/PrTask.SharedUI/Pages/`

**File Listing:**
- AboutPage.razor
- BoardDetailPage.razor, BoardsPage.razor
- Client/CreateTaskPage.razor, Client/EditTaskPage.razor, Client/PaymentsPage.razor, Client/RepositoryPage.razor
- DashboardPage.razor, DeploymentPreviewPage.razor, DownloadPage.razor
- (10+ other pages)

**Component Pattern:**
- Directive: `@page "/Route"`
- Dependency Injection: `@inject IServiceInterface ServiceName`
- Code-behind: `@code { ... properties and methods ... }`
- Constants: Import from `PrTask.Domain.Constants` namespace
- Naming: PascalCase properties (ActiveTaskCount, UserCount, etc.)

**Example (DashboardPage.razor):**
- Route: `/Dashboard`
- Injects: ITaskService, IUserService, IPullRequestService
- Properties: ActiveTaskCount, UserCount, TotalBountyCents, PrCount, RecentTasks
- Renders: Stats cards, task grid, uses RouteConstants for links

---

## 10. CLIENT SERVICE IMPLEMENTATIONS
**Location:** `src/PrTask.Client/Services/`

### HTTP Services (16 total):
HttpBoardService, HttpCloudflareD1Service, HttpInferenceService, HttpInvoiceService, HttpKycVerificationService, HttpLeaderboardService, HttpPaymentRecordService, HttpPullRequestService, HttpRepositoryService, HttpReviewCommentService, HttpSnapshotService, HttpSourceCodeService, HttpSprintService, HttpSubscriptionService, HttpTaskService, HttpUserService, HttpVectorSearchService

### WASM Services (5 total):
WasmConnectionStateService, WasmVisibilitySyncService, WasmWebSocketReconnectionService, WasmWssConnectionService, WasmWssService

### HTTP Service Pattern (example: HttpUserService)
```csharp
public class HttpUserService(HttpClient Http) : IUserService
{
    private static readonly JsonSerializerOptions JsonOptions = new() { PropertyNameCaseInsensitive = true };

    public async Task<UserEntity?> GetByIdAsync(string UserId)
    {
        try { return await Http.GetFromJsonAsync<UserEntity>(string.Format(RouteConstants.ApiUserById, UserId), JsonOptions); }
        catch { return null; }
    }

    public async Task<IReadOnlyList<UserEntity>> ListAsync()
    {
        try { return await Http.GetFromJsonAsync<UserEntity[]>(RouteConstants.ApiUsers, JsonOptions) ?? []; }
        catch { return []; }
    }

    public async Task<UserEntity> UpdateAsync(UserEntity Entity)
    {
        await Http.PutAsJsonAsync(string.Format(RouteConstants.ApiUserById, Entity.Id), Entity);
        return Entity;
    }
}
```

**Pattern Details:**
- Constructor: `public HttpXxxService(HttpClient Http)`
- PascalCase parameters: UserId, DisplayName, AvatarUrl, Email
- Methods: GetByIdAsync, ListAsync, CreateAsync, UpdateAsync, DeleteAsync
- Error handling: try-catch blocks returning null on failure
- JSON options: PropertyNameCaseInsensitive = true
- Routes: All use RouteConstants class

---

## KEY ARCHITECTURAL PATTERNS

### 1. PascalCase Everywhere
- C# properties, methods, variables: PascalCase
- API routes: PascalCase segments
- JSON property names: Match C# PascalCase

### 2. Service Layer Pattern
- Interface per service (IXxxService)
- HTTP client per interface (HttpXxxService)
- Constructor injection of HttpClient
- Error resilience: catch and return null

### 3. Async-First Design
- All I/O: `async Task<T>` or `Task`
- Await all async calls
- CancellationToken support in WSS connect

### 4. Dependency Injection
- AddScoped for stateless services
- AddSingleton for stateful services (ConnectionState, WssService)
- DI in Razor components via @inject

### 5. WSS Real-Time Sync
- IWssService abstraction
- WasmWssService implementation for WASM
- WssStateService as subscription manager
- Observer pattern for diff handlers
- Session token from JsRuntime

### 6. Offline-First with Service Worker
- Cache-first strategy for GET
- IndexedDB for automerge docs
- Offline fallback to /
- Skips caching for /api/ and /ws

### 7. Snapshot-Based State Distribution
- Daily rebuild exports full state
- Pages.dev serves snapshot.json
- Clients bootstrap from snapshot
- Live patches applied on top

---

## CRITICAL NOTES FOR IMPLEMENTATION

1. All new services must register in Program.cs DI
2. Follow HttpXxxService naming for HTTP clients
3. Implement IXxxService interface for all services
4. Use RouteConstants for all API paths
5. Maintain PascalCase throughout codebase
6. Service worker strategy: cache-first for assets, network for API
7. WSS is the single source of truth for live data
8. snapshot.json from R2 is bootstrap data for new clients
9. Mutation log enables client catchup on reconnect
10. All async operations must be awaited

---

## READY FOR NEXT TASKS

Implementation teams can now proceed with:
- Task #2: OPFS storage layer (opfs-store.js)
- Task #3: ILocalStoreService interface
- Task #4: LocalUserService replacement
- Task #5: SyncStatusBar component
- Task #6: Service worker OPFS integration
- Task #7: WSS to LocalStore wiring
- Task #8: Daily rebuild templates
- Task #9: Routing and DI updates
