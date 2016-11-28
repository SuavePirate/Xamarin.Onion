# OnionTemplate

This is the main Xamarin.Forms client. This holds our Views (pages), ViewModels, as well as any other non-platform-specific client logic.

This is also where our IoC is set up for the app. For this reason, it references all the other projects in the solution that are not test projects or platform projects.

Although this project references all other projects, the code behinds and ViewModels should NOT reference anything from the Domain Interfaces or Infrastructure layers. It should make calls directly through the Application Interfaces.

