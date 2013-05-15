# AngularJS Tutorial With ASP.NET WebAPI

## Overview
Builds on the AngularJS tutorial http://docs.angularjs.org/tutorial and puts it on top of ASP.Net's Web API.  Each commit is a self-contained step that demonstrates some aspect of how to get the original code working with the Web API.

Blog posts that work go through the code at: http://stevefriend.blogspot.co.uk/2013/05/angularjs-tutorial-and-net-web-api-part.html

## Prerequisites

### The original AngularJS Phone Catalog Tutorial Application
- Read it, work through it, download the code.

## Workings of the application
- The application filesystem layout structure is builds on top of the structure that the AngularJS NuGet package sets up (i.e. a 'Scripts' folder at the root of the application)
- Unlike the original tutorial code, this does have a back-end, although ultimately it still just reads JSON files to get the required data.
- There are no unit tests as these are well covered by the original tutorial.

## Commits
- The commits generally follow the original tutorial from step 5, however step 5 has two commits to match the blog posts that go with this.

### step5
- Get an ApiController taking a get request from the AngularJS application

### step5b
- Tidy up the ApiController so that it uses a repository to pull data back from, rather than have it hard-coded.  Add in some simple DI using the DependencyResolver for good measure.

### step6
- Changes that follow the AngularJS tutorial to get templating and links working. 

### step7
- Changes that follow the AngularJS tutorial to demonstrate routing and multiple views in AngularJS.

### step8
- Changes to the Web API code to power the AngularJS 'phone-detail' view.

### step9
- Adding a filter to an AngularJS view.

### step10
- Adding event handling to the AngularJS application.  These do not interact with the Web API.

### step11
- Using a higher level of abstraction for the requests to the Web API in the AngularJS application.  Main point of interest is how to wire these up to the Web API underneath to make the service calls.
