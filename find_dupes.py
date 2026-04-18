import re, os, collections

test_dir = 'tests/PrTask.E2E'
files = [f for f in os.listdir(test_dir) if f.endswith('.cs')]

# Extract: method name -> list of assertion strings
method_asserts = {}
file_of_method = {}

pat = re.compile(r'Contains\("((?:[^"\\]|\\.)*)"')

for fname in sorted(files):
    path = os.path.join(test_dir, fname)
    with open(path, 'r', encoding='utf-8') as f:
        content = f.read()

    methods = re.split(r'(?=\[TestMethod)', content)
    for method_block in methods:
        m = re.search(r'public void (\w+)\(\)', method_block)
        if not m:
            continue
        method_name = m.group(1)
        file_of_method[method_name] = fname

        contains = set(pat.findall(method_block))
        method_asserts[method_name] = contains

# Find exact duplicates
exact_dupes = []
seen = {}
for method_name, asserts in method_asserts.items():
    key = frozenset(asserts) if asserts else None
    if key and key in seen:
        exact_dupes.append((method_name, file_of_method[method_name], seen[key], file_of_method[seen[key]]))
    elif key:
        seen[key] = method_name

# Find subset-redundant (all asserts of m1 also in m2, m1 != m2)
redundant = []
methods_list = list(method_asserts.keys())
for i, m1 in enumerate(methods_list):
    s1 = method_asserts[m1]
    if len(s1) < 2:
        continue
    for j, m2 in enumerate(methods_list):
        if i == j:
            continue
        s2 = method_asserts[m2]
        if len(s2) <= len(s1):
            continue
        if s1 < s2:  # strict subset
            redundant.append((m1, file_of_method[m1], m2, file_of_method[m2], len(s1)))

# Find individual assertion duplication count
all_asserts = collections.Counter()
assert_to_methods = collections.defaultdict(list)
for method_name, asserts in method_asserts.items():
    for a in asserts:
        all_asserts[a] += 1
        assert_to_methods[a].append((method_name, file_of_method[method_name]))

print(f'Total test methods: {len(method_asserts)}')
print(f'Exact duplicate test sets: {len(exact_dupes)}')
print(f'Subset-redundant pairs: {len(redundant)}')
print()

print('=== EXACT DUPLICATES (same assertion set) ===')
for m1, f1, m2, f2 in exact_dupes:
    print(f'  DUP: {f1}:{m1}')
    print(f'     = {f2}:{m2}')
    print()

print('=== SUBSET REDUNDANT (all asserts in smaller also in larger) ===')
for m1, f1, m2, f2, cnt in sorted(redundant, key=lambda x: -x[4])[:30]:
    print(f'  SUB({cnt}): {f1}:{m1}')
    print(f'     in: {f2}:{m2}')
    print()

# Count methods that can be removed (exact dupes + strict subsets)
removable = set()
for m1, f1, m2, f2 in exact_dupes:
    removable.add(m1)
for m1, f1, m2, f2, cnt in redundant:
    removable.add(m1)

print(f'=== REMOVABLE METHODS: {len(removable)} ===')
for m in sorted(removable):
    print(f'  {file_of_method[m]}:{m}')

# Most duplicated assertions
print()
print('=== TOP DUPLICATED ASSERTIONS (in 4+ methods) ===')
for a, count in all_asserts.most_common(30):
    if count >= 4:
        methods = assert_to_methods[a]
        print(f'  [{count}x] "{a[:80]}"')
        for mn, fn in methods[:3]:
            print(f'       {fn}:{mn}')
        if len(methods) > 3:
            print(f'       ... +{len(methods)-3} more')
        print()
