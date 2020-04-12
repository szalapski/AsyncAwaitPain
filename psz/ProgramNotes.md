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

- AccountController.cs 
    - R# warnings
        - Remove unused usings
        - Remove redundant names   
            - Write code in a way that is simpler for those who know the language, not for those who don't.
    - Commit refactorings often; build often
    - R# suggestions
        - Use expression-bodied methods/properties
            - try to build; be willing to upgrade to latest 
        - Restrict members/references to get-only, readonly, private, internal, static, or const whereever possible
            - build
        - Simplify conditionals with logic and underused operators: ?.  ??  ?:     
            - build        
        - Eliminate redundant special cases
            - build
        - Use Null propagation
            - build
        - Use nameof operator
            - build
    - turn off R# code analysis
    - turn off R#
        ReSharper > Options > Code Inspection > Settings,
	- if-else in GetExternalLogins
       - Move declaration
       - build
    - Invert If in GetErrorResult
       - Remove braces
       - build
    - Make simple blocks one line in GetErrorResult
        - build
    - combine boolean logic in FromIdentity
        - build
    - convert return to conditional expression using ternary (implicitly convertible) in RegisterExternal
        - build
    - GetExternalLogins - string 
        - build
    - Extract a method in GetExternalLogins
         - build
         - commit and push

  - seven-step DI refactoring in BigBallOfMud.HomeController
  1. (static only) Sequester the untestable/uninjectable code into a tightly-coupled implementation
	a. extract instance method
	b. extract instance class from that method
	c. use the new class and method with "new"
  2. make local refereance for the "new" object only
  3. move local to instance and switch to abstract type (i.e. interface)
  4. bastardize constructor
  5. configure DI
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