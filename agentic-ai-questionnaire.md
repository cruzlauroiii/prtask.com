# Agentic AI Labor Platform — Pre-Interview Technical Questionnaire

**From:** Lauro Cruz III (noahblesse@gmail.com)

---

## SECTION 1 — VISION & PRODUCT THINKING

### Q1: What is the difference between a chatbot and an agentic AI system?

A chatbot is reactive — it waits for input, generates a response, and stops. It has no goals, no memory of what it should be doing next, and no ability to take actions in external systems. On a hiring platform, a chatbot would be: "Ask me anything about job openings" — the worker types a question, gets an answer, and the conversation dies.

An agentic AI system has goals, plans, takes actions, observes results, and iterates. It operates autonomously between user interactions. On the same hiring platform, an agentic system would: monitor new job postings every hour, compare them against the worker's profile and salary requirements, draft personalized outreach messages to matching employers, schedule interviews on the worker's behalf, and follow up if no response comes within 48 hours — all without the worker opening the app.

The core difference is the loop. A chatbot is `input → output`. An agent is `goal → plan → act → observe → revise → act again`. The agent does not need the user in the loop for every step.

I built this pattern in PrTask (prtask.com) — the platform does not just list tasks. When a developer's profile matches a new task, the system scores complexity, surfaces it with priority, and when a PR is approved, payment fires automatically. The developer does not click "pay me" — the system acts on the approval event autonomously.

---

### Q2: First 5 minutes of the personal career agent for a logistics worker

**0:00–0:30 — Warm start, not a form.**
The agent greets the worker by name (pulled from SSO profile) and says something like: "I'm your career agent. I'll find jobs that match you and handle the outreach. Let's start — what kind of work do you do?" One open question, not a 15-field form.

**0:30–1:30 — Conversational profiling.**
The agent asks 3–4 targeted questions in natural language:
- "What's your most recent role?" (extracts: job title, industry vertical, recency)
- "Do you drive? What license?" (logistics-specific — CDL, forklift cert, hazmat)
- "What shift works for you?" (schedule constraints)
- "What's the minimum pay you'd accept?" (salary floor — critical for matching)

Each answer is processed by Claude with a structured extraction prompt. The system prompt instructs Claude to extract entities (role, certifications, location, availability, pay floor) into a typed JSON schema and ask follow-up questions only if critical fields are ambiguous.

**1:30–3:00 — Inference and enrichment.**
While the worker is still chatting, the agent is already working in the background:
- Infers experience level from job title + years (e.g., "warehouse associate, 4 years" → mid-level)
- Geocodes their location for commute radius matching
- Cross-references certifications against active job requirements in the database
- Builds an initial embedding vector from their profile for semantic job matching

**3:00–4:00 — First value delivery.**
The agent surfaces 2–3 real matches: "I found 3 jobs within 15 miles that match your experience. Here's the top one — [Company], [Role], [$Pay/hr], [Shift]. Want me to apply for you?"

This is the trust moment. If the agent delivers a relevant match in under 4 minutes, the worker believes in it. If it asks 20 questions and shows nothing, they leave.

**4:00–5:00 — Permission and autonomy setup.**
"I can watch for new jobs and message you when something matches. I can also apply on your behalf if you want — you'd just confirm. What level of autonomy do you want?" This sets the agentic behavior boundary with explicit user consent.

**Claude's role at each step:**
- Conversational extraction: Claude with a system prompt containing the profile schema and extraction instructions
- Inference: Claude evaluates partial profiles against job requirement patterns
- Match explanation: Claude generates natural-language explanations of why a job matches
- All grounded in real data — job details come from the database, not Claude's imagination

---

### Q3: 6 weeks to make it fundable — what to build, what to skip

**Build (Weeks 1–6):**

**Week 1–2: The career agent conversation loop.**
A single-page app where a logistics worker talks to their career agent. The agent asks questions, builds a profile, and surfaces real job matches from a seeded database of 200+ logistics jobs. Claude handles the conversation with a well-tuned system prompt. Profile data persists in Supabase. This is the product — everything else supports it.

**Week 3–4: The "apply for me" action.**
When the worker says "apply," the agent drafts an outreach message, shows it to the worker for approval, and sends it (even if "sending" is just writing to a database that an employer dashboard reads). This is the agentic moment investors need to see — the AI took an action in the real world.

**Week 5: Employer-side dashboard.**
A simple dashboard where employers see incoming applications, ranked by match quality. Shows the agent's reasoning: "This candidate matches because: CDL-A certified, 3 years warehouse experience, available night shift, lives 8 miles away." Employers do not need their own agent yet — a ranked inbox is enough.

**Week 6: Polish, demo script, metrics.**
Analytics dashboard showing: profiles created, matches made, applications sent, response rates. Even with demo data, investors need to see you built for measurement. Polish the onboarding flow until it feels like magic.

**Deliberately leave out:**
- Payment processing — no transactions needed for a fundraise demo
- Mobile app — web-only, responsive design is fine
- Real employer integrations (ATS systems, job board APIs) — seed the database manually
- Multi-language support — English only for V1
- Production infrastructure (Kubernetes, CI/CD, monitoring) — deploy on Vercel/Railway, single instance
- Background job scheduling — fake it with cron or manual triggers
- Compliance (SOC2, GDPR) — document the plan, don't build it yet

The fundraise pitch is: "The agent built a profile through conversation, found a match, and applied — in 4 minutes. Here's what happens when we plug in real job feeds and scale to 10,000 workers."

---

## SECTION 2 — TECHNICAL APPROACH

### Q4: Architecture for the personal career agent

```
┌─────────────────────────────────────────────────┐
│  Frontend (Next.js or Blazor WASM)              │
│  - Chat UI with streaming responses             │
│  - Profile dashboard                            │
│  - Job match cards                              │
│  WebSocket connection for real-time updates      │
├─────────────────────────────────────────────────┤
│  API Layer (Node.js/Express or ASP.NET Core)    │
│  - /api/chat — conversation endpoint            │
│  - /api/profile — worker profile CRUD           │
│  - /api/jobs — job search and matching          │
│  - /api/actions — agent actions (apply, message)│
│  WebSocket server for streaming                  │
├─────────────────────────────────────────────────┤
│  Agent Orchestrator                              │
│  - Manages conversation state machine            │
│  - Decides when to extract, match, or act        │
│  - Calls Claude API with context injection       │
│  - Executes tool calls (search jobs, apply, etc) │
├─────────────────────────────────────────────────┤
│  Claude API (Anthropic)                          │
│  - System prompt: agent persona + instructions   │
│  - Tool use: search_jobs, get_profile,           │
│    apply_to_job, send_message                    │
│  - Streaming for real-time UX                    │
├─────────────────────────────────────────────────┤
│  Data Layer                                      │
│  - Supabase (Postgres): profiles, jobs, matches  │
│  - Supabase Realtime: live updates               │
│  - Redis: session state, conversation cache      │
│  - pgvector: semantic job matching embeddings     │
└─────────────────────────────────────────────────┘
```

**Specific choices and why:**

**AI Logic:** Claude API (claude-sonnet-4-20250514 for speed, claude-opus-4-20250514 for complex reasoning). I would use Claude's tool use feature — define tools like `search_jobs(criteria)`, `apply_to_job(job_id, message)`, `update_profile(fields)`. The agent orchestrator sends the conversation to Claude, Claude decides which tool to call, the orchestrator executes it and feeds the result back. This is the agentic loop.

**State and memory:** Conversation history stored in Supabase with a session ID. Between sessions, the agent loads: (1) the worker's profile (structured data), (2) a summary of the last 3 conversations (generated by Claude at end-of-session), and (3) any pending actions (jobs applied to, responses waiting). This is injected into the system prompt as context. I would not store raw conversation history in the prompt — it burns tokens. Instead, I summarize and inject structured state.

**Frontend:** For speed-to-demo, I would use Next.js with the Vercel AI SDK — it has built-in streaming support for Claude, handles tool calls on the client, and deploys in minutes. For production scale, I would migrate to Blazor WASM (which is what I use for PrTask) for offline-first capability and .NET ecosystem benefits.

**Vector search for matching:** Worker profiles and job descriptions get embedded (via Claude's embeddings or a dedicated model). When a new job is posted, compute similarity against all worker profiles. When a worker updates their profile, recompute against active jobs. Store embeddings in pgvector (Supabase extension) or a dedicated service like Pinecone. In PrTask, I built this with USearch — a native C++ vector search library with .NET bindings I wrote from scratch.

---

### Q5: Claude Code vs. Lovable — how I would use each

I use Claude Code daily — it is my primary development tool. PrTask (30+ projects, 200+ source files, multi-language, clean architecture) was built almost entirely through Claude Code. I know its strengths and limits intimately.

**Claude Code handles:**
- Architecture decisions and scaffolding entire project structures
- Writing backend logic: API endpoints, database queries, service layers, business rules
- Complex refactoring across multiple files (rename a domain entity and it updates every layer)
- Writing and debugging system prompts for Claude API integrations
- Infrastructure as code (I use it for Terraform/Cloudflare Worker configs)
- Test generation and debugging
- Code review and optimization

**Where Claude Code needs oversight:**
- It can over-engineer solutions if you do not constrain it. I use a CLAUDE.md file with strict rules (no comments, no unnecessary abstractions, PascalCase everywhere) and custom Roslyn analyzers that reject violations at build time.
- It sometimes generates code that compiles but does not match the runtime behavior you want — you still need to run the code and test it.
- For UI work, it generates correct markup but you need visual verification in a browser.

**Lovable handles:**
- Rapid UI prototyping — give it a description and get a styled, responsive page in minutes
- Component scaffolding for standard patterns (dashboards, forms, card layouts, tables)
- Design system consistency — it produces clean Tailwind/shadcn output
- Landing pages and marketing content

**Where Lovable hits limits:**
- Complex state management (WebSocket connections, optimistic updates, offline sync) — it scaffolds the UI but the logic needs handwriting or Claude Code
- Backend logic — Lovable is frontend-focused. Anything involving database queries, authentication flows, or API orchestration goes through Claude Code or manual code
- Custom interactions (drag-and-drop boards, real-time collaborative editing) — Lovable generates the container but not the behavior

**How I would combine them for this platform:**
1. Lovable: generate the chat UI, profile dashboard, employer inbox, landing page — get the look right fast
2. Claude Code: build the agent orchestrator, Claude API integration, Supabase schema, matching algorithm, WebSocket streaming layer
3. Hand-written: WebSocket reconnection logic, edge cases in the agent state machine, payment integration security, and anything where Claude Code generates something subtly wrong that only a human debugging session catches

The overlap is in component code — both can generate a React component. I would use Lovable for the first draft (better design sense) and Claude Code for iteration (better at logic changes).

---

### Q6: Keeping the UX fast with 3–5 second Claude API calls

**1. Streaming responses (most important).**
Use Claude's streaming API. The first token arrives in ~200ms. The user sees the agent "typing" immediately — the perceived wait drops from 5 seconds to near-zero. I would use Server-Sent Events or WebSocket to push tokens to the frontend as they arrive. The Vercel AI SDK handles this out of the box. In PrTask, I built streaming over WebSocket with the Anthropic streaming API — same pattern.

**2. Optimistic UI updates.**
When the user sends a message, immediately render it in the chat, show a typing indicator, and disable the input. Do not wait for the API. When the user clicks "Apply to this job," immediately show "Application sent ✓" and fire the API call in the background. If it fails, show an error and offer retry — but 99% of the time it succeeds and the user never waited.

**3. Skeleton loaders and progressive rendering.**
When loading the dashboard, show skeleton cards immediately. As job matches stream in (from vector search), render each card as it arrives. Do not wait for all results. The first match appears in ~500ms, the rest fill in over 1–2 seconds.

**4. Background pre-fetching.**
While the user reads the agent's response, pre-fetch the next likely data: if the agent mentioned 3 job matches, fetch the full details of all 3 before the user clicks any of them. When they click, the detail view is instant.

**5. Cached responses for common patterns.**
First-time onboarding questions are predictable. Cache the agent's initial greeting and first question — no API call needed. Cache job detail pages aggressively (they do not change minute-to-minute).

**6. Parallel tool execution.**
When Claude decides to call multiple tools (e.g., search_jobs AND get_profile), execute them in parallel, not sequentially. This cuts multi-tool turns from 6 seconds to 3 seconds.

**7. Edge compute for the API layer.**
Deploy the API on Cloudflare Workers or Vercel Edge — the orchestration code runs in ~50ms at the edge, so the only latency is the Claude API call itself. In PrTask, the entire API layer runs on a Cloudflare Worker with D1, KV, and R2 — sub-100ms for everything except the AI call.

---

### Q7: System prompt structure for the career agent

```
You are CareerAgent, a personal career assistant for logistics and supply chain workers on [Platform Name].

## Your Role
You help workers find jobs, build their profiles, and manage their career. You are proactive — you do not just answer questions, you take action.

## Current Worker Profile
Name: {worker.name}
Location: {worker.city}, {worker.state}
Certifications: {worker.certifications | join(", ")}
Experience: {worker.experience_summary}
Pay Floor: ${worker.min_hourly_rate}/hr
Availability: {worker.shift_preferences}
Last Active: {worker.last_seen}

## Conversation History Summary
{session.previous_summary}

## Pending Actions
{agent.pending_actions | format_list}

## Available Tools
- search_jobs(criteria: object) — Search job database. Returns real jobs only.
- update_profile(fields: object) — Update worker profile fields.
- apply_to_job(job_id: string, cover_message: string) — Submit application on worker's behalf. Requires worker confirmation.
- send_message(employer_id: string, message: string) — Message an employer. Requires worker confirmation.
- schedule_reminder(datetime: string, message: string) — Set a follow-up reminder.

## Rules
1. NEVER invent job details. Every job you mention MUST come from a search_jobs tool call. If no jobs match, say so honestly.
2. NEVER fabricate salary figures, company names, or job requirements. Only quote data returned by tools.
3. When the worker asks about a job, call search_jobs first, then respond using the results.
4. Before taking any action (applying, messaging), show the worker what you plan to do and ask for confirmation.
5. If the worker's profile is incomplete, gently ask for missing fields — do not block them from using the platform.
6. Keep responses concise. Logistics workers are busy. No filler, no corporate speak.
7. If you do not know something, say "I don't have that information" — do not guess.

## Tone
Direct, helpful, no jargon. Talk like a knowledgeable friend who happens to know the logistics job market, not like a corporate recruiter.
```

**Key design decisions:**

**Grounding with real data:** The system prompt explicitly forbids Claude from generating job details. Every job mention must come from a tool call. This is the single most important anti-hallucination measure — Claude cannot hallucinate what it must retrieve.

**Structured context injection:** The worker's profile is injected as structured data, not as a conversation replay. This uses fewer tokens and gives Claude precise facts to reference. The "Conversation History Summary" is a Claude-generated summary from the previous session — not the raw transcript. This keeps the context window manageable as sessions accumulate.

**Tool-first architecture:** By defining tools with typed parameters, Claude's responses become verifiable. If Claude calls `search_jobs({location: "Chicago", role: "forklift operator"})`, the orchestrator executes a real database query. The results are real. Claude then narrates those results — it cannot inject fake entries.

**Action confirmation gate:** Rules 4 explicitly requires confirmation before acting. This prevents the agent from spamming employers or applying to jobs the worker did not approve. The trust escalation happens over time — after 10 confirmed applies, offer "auto-apply to 90%+ matches."

**Session memory without token bloat:** Instead of stuffing 50 conversation turns into the prompt, the orchestrator runs a summarization call at session end: "Summarize this conversation in 3 bullet points focusing on: profile changes, jobs discussed, actions taken." That summary is 50 tokens instead of 2,000.

---

## SECTION 3 — SPEED, SCALABILITY & FUNDRAISING MINDSET

### Q8: 3-week VC demo plan

**Week 1: The conversation that builds a profile.**

- Day 1–2: Supabase schema (workers, jobs, applications, conversations). Seed 200 logistics jobs from real job board data (Indeed/LinkedIn scrapes or manual entry). Set up Claude API integration with streaming.
- Day 3–4: Build the chat UI (Lovable for layout, Claude Code for WebSocket streaming). Worker talks to the agent, agent extracts profile, stores in Supabase.
- Day 5: End-to-end flow works — worker opens app, chats for 2 minutes, has a complete profile.

**Week 2: The match and the action.**

- Day 1–2: Implement job matching — pgvector embeddings for semantic search, plus hard filters (location, certifications, pay). Agent surfaces top 3 matches in conversation.
- Day 3–4: "Apply for me" flow — agent drafts message, worker confirms, application recorded. Employer dashboard (basic table view) shows incoming applications with match scores.
- Day 5: Polish the agent's personality. Tune the system prompt until the conversation feels natural and the matches feel relevant.

**Week 3: Demo day preparation.**

- Day 1–2: Analytics page — profiles created, matches made, application-to-response rate (with demo data showing traction). Landing page with value prop.
- Day 3: Record a scripted demo video as backup. Run through the live demo 20+ times. Identify and fix every edge case in the demo path.
- Day 4–5: Deploy to production URL. SSL, custom domain, fast load time. The investor should be able to pull it up on their phone during the pitch.

**What the demo shows:**
A logistics worker opens the app, talks to their career agent for 3 minutes, gets matched to a real-looking job, says "apply for me," and the agent handles it. Then flip to the employer dashboard — the application is there with a match score and explanation. Total demo time: 5 minutes.

**What investors do not need to know:**
- The 200 jobs were manually seeded, not pulled from a live API
- The "employer" is a demo account we control
- The matching algorithm is embeddings + basic filters, not a sophisticated ML model
- There is no background job runner — matches are computed on-demand during the conversation
- There is one server instance on Railway, not a scalable cluster
- The "analytics" are computed from seeded historical data, not real usage
- There is no mobile app — it is a responsive web app

None of this is fake — it all works. It is just not production-scale yet. The fundraise buys the engineering time to make it real.

---

### Q9: Biggest technical risk and mitigation

**The biggest risk is cost-per-interaction at scale.**

A single worker conversation that extracts a profile, searches jobs, and drafts an application takes 3–5 Claude API calls. At Opus pricing (~$15/M input, ~$75/M output tokens), a 2,000-token conversation with tool calls costs roughly $0.15–0.30 per session. If 10,000 workers use it daily, that is $1,500–3,000/day in API costs — $45K–90K/month before the platform generates revenue.

**Mitigation in V1:**
1. **Use Sonnet for 80% of interactions.** Profile extraction, job matching narration, and simple Q&A do not need Opus. Reserve Opus for complex reasoning (career coaching, ambiguous job comparisons). This cuts cost by ~5x.
2. **Cache aggressively.** Job descriptions do not change hourly — cache embeddings and match results. Common onboarding questions get cached responses. Prompt caching (Anthropic's built-in feature) reduces repeated system prompt costs by 90%.
3. **Summarize, do not replay.** Never send full conversation history. Summarize previous sessions into 50-token bullets. This keeps input tokens flat regardless of how many sessions a worker has had.
4. **Set a token budget per session.** If a conversation exceeds 4,000 output tokens, gracefully wrap up: "I've found some great matches for you — let me know if you want to explore more tomorrow." This prevents runaway conversations from burning budget.
5. **Batch background operations.** The agent checking for new matches does not need a full Claude call. A simple embedding similarity query against the job database is pennies. Only invoke Claude when there is something to communicate to the worker.

**Second-order risk:** Latency at scale. Claude API calls are 2–5 seconds. If the orchestrator is synchronous, one slow call blocks the entire request. Mitigation: streaming (hide latency), async architecture (WebSocket, not REST), and edge compute (Cloudflare Workers) to minimize non-AI latency.

---

### Q10: Something I built that is live

**Link:** [https://prtask.com](https://prtask.com)

PrTask is a developer marketplace where clients post software development tasks with payments and developers submit code for review. When the client approves the work, payment fires automatically. The platform is live at prtask.com, served via Cloudflare Worker proxying GitHub Pages, with 16 language translations, full legal compliance pages (Terms, Privacy, Refund, DMCA, Cookie Policy, Accessibility), SSO via GitHub/Google/Azure/Okta, and a complete payment integration with Maya Business.

**The tech stack:** .NET 10, Blazor WebAssembly, MAUI Android, Cloudflare Workers (D1 + KV + R2), Automerge CRDTs for real-time sync, USearch for vector similarity search, a custom multi-language transpiler (Java/JS/TS/C/x86 → C#), and a custom HTML fingerprinting pipeline for cache busting. Zero third-party runtime NuGet packages — every dependency is either built from scratch or compile-time only.

**A decision I am proud of: Building offline-first with Automerge CRDTs.**

Instead of a traditional REST API where every action requires a server round-trip, I built the entire data layer on Automerge — a conflict-free replicated data type library. The client stores data locally (IndexedDB + Origin Private File System), syncs diffs to the server via WebSocket, and merges changes automatically. This means the app works completely offline, syncs when connectivity returns, and handles concurrent edits without conflicts.

I wrote the .NET Automerge bindings from scratch — P/Invoke wrappers around the native C library with typed document APIs. This was a hard decision because it added weeks of work and there was no existing .NET library. But it paid off: the app loads instantly (no network wait), works on unreliable mobile connections (critical for the Philippines market), and the sync architecture scales horizontally because there is no centralized write lock.

**A decision I would change: Building a custom transpiler instead of using established tools.**

PrTask includes a transpiler that converts Java, JavaScript, TypeScript, C, and x86 assembly into C#. I built it to decompile Android APKs (specifically a payment app) and convert them into Blazor WASM components. While it works and taught me an enormous amount about compiler design, it was over-engineered for the actual need. I could have achieved 80% of the value by using ILSpy for .NET decompilation and writing thin wrappers around the specific APIs I needed. The transpiler consumed weeks of development time that could have gone into user-facing features. The lesson: solve the problem in front of you, not the general case — unless the general case is the product.

---

*Thank you for the thorough questionnaire. I am happy to dive deeper into any of these answers during the interview.*

Lauro Cruz III
noahblesse@gmail.com
https://prtask.com
https://linkedin.com/in/lauro-iii-cruz-942a152a2
