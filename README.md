# Xamarin.Onion
Templates for Xamarin / C# projects that use a scalable Onion Architecture. These templates make use of Separation of Concerns, Model View ViewModel, Inversion of Control, and Dependency Injection. There is an assumption that the user of these templates has an understanding of these concepts at a high level.

## Source
This is where the solution and projects exist for the templates

## Templates
This is where the actual Visual Studio Templates exist

## Using the templates

1. Download or Pull the repo
2. Copy each of the desired template .zip files from `Templates` that you want to have in VS
3. Paste them into your VS Project Templates folder. (Typically `Documents\Visual Studio 2015\Templates\ProjectTemplates`)
4. Open Visual Studio
5. Create New Project
6. Navigate to the `Visual C#` subtree
7. Find the template(s) you added (ex: "Xamarin Forms Scalable Project")
8. Select the template of your choosing
9. Name the project
10. *Suggested*: Right click Solution > Restore Nuget Packages
11. Choose start up project from the three platforms
12. Run

### Resolving Issues

#### VS not responding after clicking on Create New Project
Because you've added a large template to your VS installation, it needs to initialize these in order for them to be usable. After a template is initialized, it is cached and this process will be quicker. Just give it some time.

#### `Error Build action 'EmbeddedResource' is not supported by one or more of the project's targets`

This error can happen when one of the Xamarin.Forms projects has issues updating from its nuget packages. Do a Clean, then Restore Nuget Packages, then try again.
