# LinqOptimizer SDK-Style Conversion Tasks

## Overview

This document tracks the conversion of all 6 projects in the LinqOptimizer solution from legacy project format to modern SDK-style format while maintaining .NET Framework 4.8 as the target framework.

**Progress**: 1/5 tasks complete (20%) ![0%](https://progress-bar.xyz/20)

---

## Tasks

### [✓] TASK-001: Verify prerequisites *(Completed: 2026-03-15 18:56)*
**References**: Plan §Phase 0

- [✓] (1) Verify .NET SDK installed and supports SDK-style projects targeting net48
- [✓] (2) SDK version meets requirements (**Verify**)
- [✓] (3) Verify .NET SDK supports F# SDK-style projects
- [✓] (4) F# SDK support available (**Verify**)

---

### [▶] TASK-002: Atomic SDK-style conversion of all projects
**References**: Plan §Phase 1, Plan §Project-by-Project Migration Plans

- [✓] (1) Convert all 6 project files to SDK-style format using conversion tool (preserve F# file ordering per Plan: Core=21 files, FSharp=4 files, Tests.FSharp=4 files)
- [✓] (2) All 6 projects have Sdk="Microsoft.NET.Sdk" and TargetFramework=net48 (**Verify**)
- [✓] (3) Migrate all packages.config entries to PackageReference per Plan §Phase 1 step 2 (Core, Tests.CSharp, Tests.FSharp; omit System.ValueTuple and explicit FSharp.Core per plan)
- [✓] (4) All packages migrated to PackageReference format (**Verify**)
- [✓] (5) Set GenerateAssemblyInfo=false in all 4 projects with AssemblyInfo files (Core, Base, CSharp, FSharp)
- [✓] (6) AssemblyInfo handling configured (**Verify**)
- [✓] (7) Remove legacy NuGet infrastructure from test projects per Plan §Phase 1 step 4 (EnsureNuGetPackageBuildImports targets, NuGet/NUnit imports, obsolete properties)
- [✓] (8) Legacy NuGet infrastructure removed (**Verify**)
- [✓] (9) Remove legacy F# infrastructure from all 3 F# projects per Plan §Phase 1 step 5 (Choose blocks, FSharpTargetsPath, TargetFSharpCoreVersion property)
- [✓] (10) Legacy F# infrastructure removed (**Verify**)
- [✓] (11) Resolve duplicate FSharp.Core references in Tests.FSharp per Plan §Phase 1 step 6 (remove both HintPath and GAC references, rely on SDK implicit reference)
- [✓] (12) Single FSharp.Core reference in Tests.FSharp (**Verify**)
- [✓] (13) Delete all 3 packages.config files (Core, Tests.CSharp, Tests.FSharp)
- [✓] (14) No packages.config files remain (**Verify**)
- [✓] (15) Preserve custom build configurations per Plan §Phase 1 step 5 (CORE_COMPILETOMETHOD in Core Release, Release-Mono with MONO_BUILD in Tests.CSharp, Tailcalls in F# projects, DocumentationFile in libraries)
- [✓] (16) Custom configurations preserved (**Verify**)
- [✓] (17) Restore all dependencies
- [✓] (18) Dependencies restored successfully (**Verify**)
- [▶] (19) Build entire solution and fix all compilation errors (reference Plan §Project-by-Project Migration Plans for project-specific breaking changes and Plan §Expected Breaking Changes sections)
- [ ] (20) Solution builds with 0 errors (**Verify**)

---

### [ ] TASK-003: Test validation
**References**: Plan §Phase 2

- [ ] (1) Run tests in LinqOptimizer.Tests.FSharp project
- [ ] (2) Fix any test failures (if NUnit test adapter not discovered, add NUnit3TestAdapter package reference)
- [ ] (3) Re-run Tests.FSharp after fixes
- [ ] (4) All Tests.FSharp tests pass (**Verify**)
- [ ] (5) Run tests in LinqOptimizer.Tests.CSharp project
- [ ] (6) Fix any test failures
- [ ] (7) Re-run Tests.CSharp after fixes
- [ ] (8) All Tests.CSharp tests pass (**Verify**)

---

### [ ] TASK-004: Final cleanup and verification
**References**: Plan §Phase 3

- [ ] (1) Delete packages/ folder at solution root
- [ ] (2) packages/ folder deleted (**Verify**)
- [ ] (3) Build solution in Release-Mono configuration
- [ ] (4) Release-Mono build succeeds with MONO_BUILD define active (**Verify**)
- [ ] (5) Build LinqOptimizer.Core in Release configuration
- [ ] (6) Release build succeeds with CORE_COMPILETOMETHOD define active (**Verify**)
- [ ] (7) Verify DocumentationFile XML outputs generated for all library projects (Core, Base, CSharp, FSharp)
- [ ] (8) Documentation XML files present (**Verify**)
- [ ] (9) Review app.config binding redirects in test projects and remove redundant entries if SDK auto-generated them
- [ ] (10) Binding redirects reviewed and cleaned up (**Verify**)
- [ ] (11) Build solution in Debug configuration
- [ ] (12) Debug build succeeds (**Verify**)
- [ ] (13) Build solution in Release configuration
- [ ] (14) Release build succeeds (**Verify**)
- [ ] (15) Build solution in Release-Mono configuration
- [ ] (16) Release-Mono build succeeds (**Verify**)

---

### [ ] TASK-005: Commit all changes
**References**: Plan §Source Control Strategy

- [ ] (1) Commit all conversion changes with message: "Convert all projects to SDK-style format - Converted 6 projects (3 C#, 3 F#) to SDK-style format - Migrated 3 packages.config files to PackageReference - Resolved duplicate FSharp.Core reference in Tests.FSharp - Removed legacy NuGet infrastructure from test projects - Preserved F# file ordering (29 files across 3 projects) - Preserved custom build configurations - Deleted packages.config files and packages/ folder - Set GenerateAssemblyInfo=false in 4 projects - All projects build successfully in Debug, Release, and Release-Mono - All tests pass"

---



