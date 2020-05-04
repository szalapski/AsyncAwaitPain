- setup
	- load deck
	- get books ready
	- load AsyncAwaitPain in run-x branch
        - build to ensure it works
        - zoom window to 100 chars wide
	- load BigBallOfMud 
    - zoom to start magnifier
	
- Not covering 
    - Rename 
    - Move

:02 - Slides
    - AccountController.cs 
:07    - R# warnings
        - Remove unused usings
        - Remove redundant names   
            - Write code in a way that is simpler for those who know the language, not for those who don't.
    - Commit refactorings often; build often
:11 - R# suggestions
        - Use expression-bodied methods/properties
        - Restrict members/references to get-only, readonly, private, internal, static, or const whereever possible
        - Simplify conditionals with logic and underused operators: ?.  ??  ?:     
        - Eliminate redundant special cases
        - Use Null propagation
        - Use nameof operator
    - turn off R# code analysis
    - turn off R#
        ReSharper > Options > Code Inspection > Settings,
:18	- if-else in GetExternalLogins
       - Move declaration
	- Kill a loop with LINQ in GetExternalLogins
    - Extract a method in GetExternalLogins
    - Invert If in GetErrorResult
    - Make simple blocks one line in GetErrorResult
    - combine boolean logic in FromIdentity
    - convert return to conditional expression using ternary (implicitly convertible) in RegisterExternal
        
:30  - seven-step DI refactoring in BigBallOfMud.HomeController
 Refactor static/ dependency into proper DI in 7 steps:
   1. (static only) Sequester the untestable/uninjectable code into a class containing
	only the tightly-coupled code
		a. extract instance method
		b. extract instance class from that method
		c. use the new class and method with "new"
	2. make local reference for the "new" object only
	3. move local to instance 
	4. modify the instance fields to an abstract type (i.e. interface)
	5. introduce proper constructor and bastardize old constructor
	6. configure DI at composition root
	7. remove bastard constructor
	N. clean up code (always)        

  - Kill loops with Linq - GetManageInfo;  GetExternalLogins
    

Things maybe to mention
- Refactoring is not about less typing
- Keyboard shortcuts to learn
  - Ctrl+arrows, ctrl+backspace
  - Ctrl+.
  - Ctrl+R R to rename

#Links
  - https://sourcemaking.com/refactoring/refactorings
  - https://www.jetbrains.com/help/resharper/Main_Set_of_Refactorings.html
  - https://www.thekua.com/publications/RefactoringCheatSheet.pdf